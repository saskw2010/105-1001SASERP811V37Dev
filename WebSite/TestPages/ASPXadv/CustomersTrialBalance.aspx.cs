using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public class CustomerTrialBalanceData
{
    public string CustomerNo { get; set; }
    public string CustomerName { get; set; }
    public decimal OpeningBalance { get; set; }
    public decimal TotalDebit { get; set; }
    public decimal TotalCredit { get; set; }
    public decimal PeriodMovement { get; set; }
    public decimal ClosingBalance { get; set; }
    public int TransactionCount { get; set; }
    public bool IsActive { get; set; }
}

public class CustomerAnalysisData
{
    public string CustomerNo { get; set; }
    public string CustomerName { get; set; }
    public string AccountNo { get; set; }
    public string AccountName { get; set; }
    public decimal TotalDebit { get; set; }
    public decimal TotalCredit { get; set; }
    public decimal NetMovement { get; set; }
    public int TransactionCount { get; set; }
}

public partial class CustomersTrialBalance : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Set default dates
            txtFromDate.Text = DateTime.Now.AddDays(-30).ToString("yyyy-MM-dd");
            txtToDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            
            // Set default checkbox states
            chkShowOpeningBalance.Checked = false; // Default unchecked as requested
            chkShowAnalysis.Checked = false;
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtFromDate.Text) || string.IsNullOrEmpty(txtToDate.Text))
        {
            ShowMessage("يرجى إدخال تواريخ صحيحة", "error");
            return;
        }

        try
        {
            LoadTrialBalance();
            
            if (chkShowAnalysis.Checked)
            {
                LoadAnalysisData();
            }
        }
        catch (Exception ex)
        {
            ShowMessage("خطأ في تحميل البيانات: " + ex.Message, "error");
        }
    }

    private void LoadTrialBalance()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["eZee"].ConnectionString))
            {
                conn.Open();
                
                // Create temporary table for better performance
                CreateTemporaryTable(conn);
                
                // Get all customers and their data
                List<CustomerTrialBalanceData> customers = GetCustomerTrialBalanceData(conn);
                
                if (customers.Count > 0)
                {
                    // Bind to GridView
                    gvTrialBalance.DataSource = customers;
                    gvTrialBalance.DataBind();
                    
                    // Update summary cards
                    UpdateSummaryCards(customers);
                    
                    // Show sections
                    tableContainer.Visible = true;
                    summarySection.Visible = true;
                    exportButtons.Visible = true;
                }
                else
                {
                    ShowMessage("لا توجد بيانات للعملاء في الفترة المحددة", "error");
                    tableContainer.Visible = false;
                    summarySection.Visible = false;
                    exportButtons.Visible = false;
                }
                
                // Cleanup temporary table
                CleanupTemporaryTable(conn);
            }
        }
        catch (Exception ex)
        {
            ShowMessage("خطأ في تحميل ميزان المراجعة: " + ex.Message, "error");
        }
    }

    private void CreateTemporaryTable(SqlConnection conn)
    {
        try
        {
            string createTempTableQuery = @"
                IF OBJECT_ID('tempdb..#CustomerTrialBalance') IS NOT NULL
                    DROP TABLE #CustomerTrialBalance
                
                CREATE TABLE #CustomerTrialBalance (
                    CustomerNo NVARCHAR(50),
                    CustomerName NVARCHAR(255),
                    OpeningBalance DECIMAL(18,2) DEFAULT 0,
                    TotalDebit DECIMAL(18,2) DEFAULT 0,
                    TotalCredit DECIMAL(18,2) DEFAULT 0,
                    PeriodMovement DECIMAL(18,2) DEFAULT 0,
                    ClosingBalance DECIMAL(18,2) DEFAULT 0,
                    TransactionCount INT DEFAULT 0
                )";

            using (SqlCommand cmd = new SqlCommand(createTempTableQuery, conn))
            {
                cmd.ExecuteNonQuery();
            }

            // Insert customer data
            string insertQuery = @"
                INSERT INTO #CustomerTrialBalance (CustomerNo, CustomerName)
                SELECT DISTINCT Cstm_No, Cstm_Nm 
                FROM Stcustmr
                WHERE EXISTS (
                    SELECT 1 FROM QGlschstatment 
                    WHERE cstyp_NO = 1 AND CSMSUP_NO = Stcustmr.Cstm_No 
                    AND Tr_Dt BETWEEN @fromDate AND @toDate
                )";

            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
            {
                cmd.Parameters.AddWithValue("@fromDate", DateTime.Parse(txtFromDate.Text));
                cmd.Parameters.AddWithValue("@toDate", DateTime.Parse(txtToDate.Text));
                cmd.ExecuteNonQuery();
            }

            // Update opening balances if requested
            if (chkShowOpeningBalance.Checked)
            {
                string updateOpeningQuery = @"
                    UPDATE #CustomerTrialBalance 
                    SET OpeningBalance = ISNULL((
                        SELECT SUM(ISNULL(Tr_db, 0) - ISNULL(tr_cr, 0))
                        FROM QGlschstatment 
                        WHERE cstyp_NO = 1 AND CSMSUP_NO = #CustomerTrialBalance.CustomerNo 
                        AND Tr_Dt < @fromDate
                    ), 0)";

                using (SqlCommand cmd = new SqlCommand(updateOpeningQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@fromDate", DateTime.Parse(txtFromDate.Text));
                    cmd.ExecuteNonQuery();
                }
            }

            // Update period movements
            string updateMovementQuery = @"
                UPDATE #CustomerTrialBalance 
                SET 
                    TotalDebit = ISNULL((
                        SELECT SUM(ISNULL(Tr_db, 0))
                        FROM QGlschstatment 
                        WHERE cstyp_NO = 1 AND CSMSUP_NO = #CustomerTrialBalance.CustomerNo 
                        AND Tr_Dt BETWEEN @fromDate AND @toDate
                    ), 0),
                    TotalCredit = ISNULL((
                        SELECT SUM(ISNULL(tr_cr, 0))
                        FROM QGlschstatment 
                        WHERE cstyp_NO = 1 AND CSMSUP_NO = #CustomerTrialBalance.CustomerNo 
                        AND Tr_Dt BETWEEN @fromDate AND @toDate
                    ), 0),
                    TransactionCount = ISNULL((
                        SELECT COUNT(*)
                        FROM QGlschstatment 
                        WHERE cstyp_NO = 1 AND CSMSUP_NO = #CustomerTrialBalance.CustomerNo 
                        AND Tr_Dt BETWEEN @fromDate AND @toDate
                    ), 0)";

            using (SqlCommand cmd = new SqlCommand(updateMovementQuery, conn))
            {
                cmd.Parameters.AddWithValue("@fromDate", DateTime.Parse(txtFromDate.Text));
                cmd.Parameters.AddWithValue("@toDate", DateTime.Parse(txtToDate.Text));
                cmd.ExecuteNonQuery();
            }

            // Update calculated fields
            string updateCalculatedQuery = @"
                UPDATE #CustomerTrialBalance 
                SET 
                    PeriodMovement = TotalDebit - TotalCredit,
                    ClosingBalance = OpeningBalance + TotalDebit - TotalCredit";

            using (SqlCommand cmd = new SqlCommand(updateCalculatedQuery, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new Exception("خطأ في إنشاء الجدول المؤقت: " + ex.Message);
        }
    }

    private List<CustomerTrialBalanceData> GetCustomerTrialBalanceData(SqlConnection conn)
    {
        List<CustomerTrialBalanceData> customers = new List<CustomerTrialBalanceData>();

        try
        {
            string query = @"
                SELECT * FROM #CustomerTrialBalance 
                ORDER BY CustomerNo";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new CustomerTrialBalanceData
                        {
                            CustomerNo = reader["CustomerNo"].ToString(),
                            CustomerName = reader["CustomerName"].ToString(),
                            OpeningBalance = Convert.ToDecimal(reader["OpeningBalance"]),
                            TotalDebit = Convert.ToDecimal(reader["TotalDebit"]),
                            TotalCredit = Convert.ToDecimal(reader["TotalCredit"]),
                            PeriodMovement = Convert.ToDecimal(reader["PeriodMovement"]),
                            ClosingBalance = Convert.ToDecimal(reader["ClosingBalance"]),
                            TransactionCount = Convert.ToInt32(reader["TransactionCount"])
                        });
                    }
                }
            }

            // Add totals row
            if (customers.Count > 0)
            {
                var totals = new CustomerTrialBalanceData
                {
                    CustomerNo = "***",
                    CustomerName = "*** إجمالي العملاء ***",
                    OpeningBalance = customers.Sum(c => c.OpeningBalance),
                    TotalDebit = customers.Sum(c => c.TotalDebit),
                    TotalCredit = customers.Sum(c => c.TotalCredit),
                    PeriodMovement = customers.Sum(c => c.PeriodMovement),
                    ClosingBalance = customers.Sum(c => c.ClosingBalance),
                    TransactionCount = customers.Sum(c => c.TransactionCount)
                };
                customers.Add(totals);
            }
        }
        catch (Exception ex)
        {
            throw new Exception("خطأ في تحميل بيانات العملاء: " + ex.Message);
        }

        return customers;
    }

    private void CleanupTemporaryTable(SqlConnection conn)
    {
        try
        {
            string dropTempTableQuery = @"
                IF OBJECT_ID('tempdb..#CustomerTrialBalance') IS NOT NULL
                    DROP TABLE #CustomerTrialBalance";

            using (SqlCommand cmd = new SqlCommand(dropTempTableQuery, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
        catch
        {
            // Ignore cleanup errors
        }
    }

    private void UpdateSummaryCards(List<CustomerTrialBalanceData> customers)
    {
        try
        {
            var dataCustomers = customers.Where(c => !c.CustomerNo.StartsWith("*")).ToList();
            
            totalCustomersCard.InnerText = dataCustomers.Count.ToString();
            totalDebitCard.InnerText = dataCustomers.Sum(c => c.TotalDebit).ToString("N2");
            totalCreditCard.InnerText = dataCustomers.Sum(c => c.TotalCredit).ToString("N2");
            
            decimal netBalance = dataCustomers.Sum(c => c.ClosingBalance);
            netBalanceCard.InnerText = netBalance.ToString("N2");
            netBalanceCard.Attributes["class"] = "card-value " + (netBalance > 0 ? "positive" : netBalance < 0 ? "negative" : "");
        }
        catch (Exception ex)
        {
            ShowMessage("خطأ في تحديث بطاقات الملخص: " + ex.Message, "error");
        }
    }

    private void LoadAnalysisData()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["eZee"].ConnectionString))
            {
                conn.Open();
                
                string query = @"
                    SELECT 
                        c.Cstm_No as CustomerNo,
                        c.Cstm_Nm as CustomerName,
                        q.Acc_no as AccountNo,
                        q.Acc_Nm as AccountName,
                        SUM(ISNULL(q.Tr_db, 0)) as TotalDebit,
                        SUM(ISNULL(q.tr_cr, 0)) as TotalCredit,
                        SUM(ISNULL(q.Tr_db, 0)) - SUM(ISNULL(q.tr_cr, 0)) as NetMovement,
                        COUNT(*) as TransactionCount
                    FROM QGlschstatment q
                    INNER JOIN Stcustmr c ON q.cstyp_NO = 1 AND q.CSMSUP_NO = c.Cstm_No
                    WHERE q.Tr_Dt BETWEEN @fromDate AND @toDate
                    GROUP BY c.Cstm_No, c.Cstm_Nm, q.Acc_no, q.Acc_Nm
                    ORDER BY c.Cstm_No, q.Acc_no";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fromDate", DateTime.Parse(txtFromDate.Text));
                    cmd.Parameters.AddWithValue("@toDate", DateTime.Parse(txtToDate.Text));

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            gvAnalysis.DataSource = dt;
                            gvAnalysis.DataBind();
                            analysisSection.Visible = true;

                            // Prepare chart data (top 10 customers by absolute closing balance)
                            var chartData = GetTopCustomersForChart(conn);
                            if (chartData.Count > 0)
                            {
                                string chartDataJson = new JavaScriptSerializer().Serialize(chartData);
                                string script = "updateAnalysisChart(" + chartDataJson + ");";
                                ClientScript.RegisterStartupScript(this.GetType(), "UpdateChart", script, true);
                            }
                        }
                        else
                        {
                            analysisSection.Visible = false;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ShowMessage("خطأ في تحميل بيانات التحليل: " + ex.Message, "error");
        }
    }

    private List<object> GetTopCustomersForChart(SqlConnection conn)
    {
        List<object> chartData = new List<object>();

        try
        {
            string query = @"
                SELECT TOP 10
                    c.Cstm_Nm as CustomerName,
                    SUM(ISNULL(q.Tr_db, 0)) - SUM(ISNULL(q.tr_cr, 0)) as ClosingBalance
                FROM QGlschstatment q
                INNER JOIN Stcustmr c ON q.cstyp_NO = 1 AND q.CSMSUP_NO = c.Cstm_No
                WHERE q.Tr_Dt BETWEEN @fromDate AND @toDate
                GROUP BY c.Cstm_No, c.Cstm_Nm
                ORDER BY ABS(SUM(ISNULL(q.Tr_db, 0)) - SUM(ISNULL(q.tr_cr, 0))) DESC";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fromDate", DateTime.Parse(txtFromDate.Text));
                cmd.Parameters.AddWithValue("@toDate", DateTime.Parse(txtToDate.Text));

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        chartData.Add(new
                        {
                            customerName = reader["CustomerName"].ToString(),
                            closingBalance = Convert.ToDecimal(reader["ClosingBalance"])
                        });
                    }
                }
            }
        }
        catch
        {
            // Return empty list on error
        }

        return chartData;
    }

    protected void gvTrialBalance_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            CustomerTrialBalanceData data = (CustomerTrialBalanceData)e.Row.DataItem;

            if (data.CustomerNo.StartsWith("***"))
            {
                e.Row.CssClass += " total-row";
            }
        }
    }

    protected void gvAnalysis_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            // Add any special formatting for analysis rows if needed
        }
    }

    protected void btnExportExcel_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=CustomersTrialBalance_" + DateTime.Now.ToString("yyyyMMdd") + ".xls");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";
            
            using (StringWriter sw = new StringWriter())
            {
                HtmlTextWriter hw = new HtmlTextWriter(sw);
                
                // Export trial balance
                hw.Write("<h3>ميزان مراجعة العملاء</h3>");
                gvTrialBalance.RenderControl(hw);
                
                // Export analysis if visible
                if (analysisSection.Visible && gvAnalysis.Rows.Count > 0)
                {
                    hw.Write("<br/><br/><h3>تحليل العملاء والحسابات</h3>");
                    gvAnalysis.RenderControl(hw);
                }
                
                Response.Output.Write(sw.ToString());
                Response.Flush();
                Response.End();
            }
        }
        catch (Exception ex)
        {
            ShowMessage("خطأ في تصدير البيانات: " + ex.Message, "error");
        }
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        // Required for export functionality
    }

    private void ShowMessage(string message, string type)
    {
        string cssClass = type == "error" ? "error-message" : "success-message";
        string icon = type == "error" ? "fas fa-exclamation-triangle" : "fas fa-check-circle";
        
        litMessage.Text = @"
            <div class='message " + cssClass + @"'>
                <i class='" + icon + @"'></i>
                " + message + @"
            </div>";
    }
}
