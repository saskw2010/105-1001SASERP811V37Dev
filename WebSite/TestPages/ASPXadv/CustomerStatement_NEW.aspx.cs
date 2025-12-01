using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerStatement : System.Web.UI.Page
{
    private string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["eZee"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadAccounts();
            LoadCustomers();
            SetDefaultDates();
        }
    }

    private void LoadAccounts()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT DISTINCT g.acc_no, g.acc_nm 
                    FROM glmstrfl g
                    WHERE g.acc_no IN (
                        SELECT DISTINCT acc_no FROM Stcustmr WHERE acc_no IS NOT NULL AND acc_no != ''
                    )
                    ORDER BY g.acc_no";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        ddlAccount.Items.Clear();
                        ddlAccount.Items.Add(new ListItem("-- جميع الحسابات --", ""));

                        while (reader.Read())
                        {
                            string accountNo = reader["acc_no"].ToString();
                            string accountName = reader["acc_nm"].ToString();
                            ddlAccount.Items.Add(new ListItem(accountNo + " - " + accountName, accountNo));
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ShowMessage("خطأ في تحميل الحسابات: " + ex.Message, "error");
        }
    }

    private void LoadCustomers(string accountNo = "")
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT Cstm_No, Cstm_Nm, acc_no
                    FROM Stcustmr 
                    WHERE (@AccountNo = '' OR @AccountNo IS NULL OR acc_no = @AccountNo)
                    ORDER BY Cstm_Nm";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountNo", string.IsNullOrEmpty(accountNo) ? "" : accountNo);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        ddlCustomer.Items.Clear();
                        ddlCustomer.Items.Add(new ListItem("اختر العميل", ""));

                        while (reader.Read())
                        {
                            string customerNo = reader["Cstm_No"].ToString();
                            string customerName = reader["Cstm_Nm"].ToString();
                            string accNo = reader["acc_no"].ToString();
                            string displayText = customerName + " (" + customerNo + ")";
                            if (!string.IsNullOrEmpty(accNo))
                            {
                                displayText += " - حساب: " + accNo;
                            }
                            ddlCustomer.Items.Add(new ListItem(displayText, customerNo));
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ShowMessage("خطأ في تحميل العملاء: " + ex.Message, "error");
        }
    }

    protected void ddlAccount_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadCustomers(ddlAccount.SelectedValue);
    }

    protected void ddlCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(ddlCustomer.SelectedValue))
        {
            txtCustomer.Text = ddlCustomer.SelectedValue;
        }
    }

    private void SetDefaultDates()
    {
        if (string.IsNullOrEmpty(txtFromDate.Text))
        {
            txtFromDate.Text = new DateTime(DateTime.Now.Year, 1, 1).ToString("yyyy-MM-dd");
        }
        if (string.IsNullOrEmpty(txtToDate.Text))
        {
            txtToDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string customerNo = !string.IsNullOrEmpty(txtCustomer.Text.Trim()) ? txtCustomer.Text.Trim() : ddlCustomer.SelectedValue;
        
        if (string.IsNullOrEmpty(customerNo))
        {
            ShowMessage("يرجى اختيار أو إدخال رقم العميل", "error");
            return;
        }

        if (string.IsNullOrEmpty(txtFromDate.Text) || string.IsNullOrEmpty(txtToDate.Text))
        {
            ShowMessage("يرجى إدخال تاريخ البداية والنهاية", "error");
            return;
        }

        LoadCustomerStatement(customerNo);
    }

    private void LoadCustomerStatement(string customerNo)
    {
        try
        {
            DateTime fromDate = DateTime.Parse(txtFromDate.Text);
            DateTime toDate = DateTime.Parse(txtToDate.Text);
            string accountNo = ddlAccount.SelectedValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Get customer info
                string customerQuery = @"
                    SELECT Cstm_Nm, acc_no 
                    FROM Stcustmr 
                    WHERE Cstm_No = @CustomerNo";

                string customerName = "";
                string customerAccount = "";

                using (SqlCommand cmd = new SqlCommand(customerQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerNo", customerNo);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customerName = reader["Cstm_Nm"].ToString();
                            customerAccount = reader["acc_no"].ToString();
                        }
                        else
                        {
                            ShowMessage("العميل غير موجود", "error");
                            return;
                        }
                    }
                }

                // Update customer info display
                customerInfo.Visible = true;
                this.customerName.InnerText = "العميل: " + customerName + " (" + customerNo + ")";
                if (!string.IsNullOrEmpty(customerAccount))
                {
                    this.customerName.InnerText += " - حساب: " + customerAccount;
                }

                // Calculate opening balance
                decimal openingBalance = 0;
                if (chkShowOpeningBalance.Checked)
                {
                    string openingQuery = @"
                        SELECT ISNULL(SUM(Tr_db - tr_cr), 0) as OpeningBalance
                        FROM QGlschstatment 
                        WHERE cstyp_NO = 1 
                        AND CSMSUP_NO = @CustomerNo
                        AND (@AccountNo = '' OR @AccountNo IS NULL OR Acc_no = @AccountNo)
                        AND Tr_Dt < @FromDate";

                    using (SqlCommand cmd = new SqlCommand(openingQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerNo", customerNo);
                        cmd.Parameters.AddWithValue("@AccountNo", string.IsNullOrEmpty(accountNo) ? "" : accountNo);
                        cmd.Parameters.AddWithValue("@FromDate", fromDate);

                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            openingBalance = Convert.ToDecimal(result);
                        }
                    }
                }

                // Get statement data
                string query = @"
                    SELECT q.Tr_Dt, q.Tr_no, q.Acc_no, g.acc_nm as Acc_Nm, q.Tr_Dsc1 as Description,
                           q.Tr_db, q.tr_cr
                    FROM QGlschstatment q
                    LEFT JOIN glmstrfl g ON g.acc_no = q.Acc_no
                    WHERE q.cstyp_NO = 1 
                    AND q.CSMSUP_NO = @CustomerNo
                    AND (@AccountNo = '' OR @AccountNo IS NULL OR q.Acc_no = @AccountNo)
                    AND q.Tr_Dt BETWEEN @FromDate AND @ToDate
                    ORDER BY q.Tr_Dt ASC, q.Tr_no ASC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerNo", customerNo);
                    cmd.Parameters.AddWithValue("@AccountNo", string.IsNullOrEmpty(accountNo) ? "" : accountNo);
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            // Calculate running balance
                            decimal runningBalance = openingBalance;
                            dt.Columns.Add("RunningBalance", typeof(decimal));

                            // Add opening balance row if checked
                            if (chkShowOpeningBalance.Checked)
                            {
                                DataRow openingRow = dt.NewRow();
                                openingRow["Tr_Dt"] = fromDate.AddDays(-1);
                                openingRow["Tr_no"] = DBNull.Value; // Fixed: Use DBNull instead of empty string
                                openingRow["Acc_no"] = "";
                                openingRow["Acc_Nm"] = "";
                                openingRow["Description"] = "الرصيد الافتتاحي";
                                openingRow["Tr_db"] = 0;
                                openingRow["tr_cr"] = 0;
                                openingRow["RunningBalance"] = openingBalance;
                                dt.Rows.InsertAt(openingRow, 0);
                            }

                            // Calculate running balance for each row
                            int startIndex = chkShowOpeningBalance.Checked ? 1 : 0;
                            for (int i = startIndex; i < dt.Rows.Count; i++)
                            {
                                decimal debit = Convert.ToDecimal(dt.Rows[i]["Tr_db"] ?? 0);
                                decimal credit = Convert.ToDecimal(dt.Rows[i]["tr_cr"] ?? 0);
                                runningBalance += (debit - credit);
                                dt.Rows[i]["RunningBalance"] = runningBalance;
                            }

                            // Calculate totals
                            decimal totalDebit = 0;
                            decimal totalCredit = 0;
                            decimal periodMovement = 0;

                            for (int i = startIndex; i < dt.Rows.Count; i++)
                            {
                                totalDebit += Convert.ToDecimal(dt.Rows[i]["Tr_db"] ?? 0);
                                totalCredit += Convert.ToDecimal(dt.Rows[i]["tr_cr"] ?? 0);
                            }

                            periodMovement = totalDebit - totalCredit;
                            decimal closingBalance = openingBalance + periodMovement;

                            // Update balance cards
                            UpdateBalanceCards(openingBalance, periodMovement, closingBalance, dt.Rows.Count - startIndex);

                            // Bind data
                            gvStatement.DataSource = dt;
                            gvStatement.DataBind();

                            // Show sections
                            balanceSection.Visible = true;
                            tableContainer.Visible = true;
                            exportButtons.Visible = true;

                            // Load monthly pivot if checked
                            if (chkShowMonthlyPivot.Checked)
                            {
                                LoadMonthlyPivot(customerNo, accountNo, fromDate, toDate);
                            }
                            else
                            {
                                monthlyPivotSection.Visible = false;
                            }

                            ShowMessage("تم تحميل " + (dt.Rows.Count - startIndex).ToString() + " معاملة بنجاح", "success");
                        }
                        else
                        {
                            ShowMessage("لا توجد معاملات في الفترة المحددة", "error");
                            ClearResults();
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ShowMessage("خطأ في تحميل البيانات: " + ex.Message, "error");
            ClearResults();
        }
    }

    private void LoadMonthlyPivot(string customerNo, string accountNo, DateTime fromDate, DateTime toDate)
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        YEAR(Tr_Dt) as Year,
                        MONTH(Tr_Dt) as Month,
                        DATENAME(MONTH, Tr_Dt) + ' ' + CAST(YEAR(Tr_Dt) AS VARCHAR) as MonthName,
                        SUM(Tr_db) as TotalDebit,
                        SUM(tr_cr) as TotalCredit,
                        SUM(Tr_db - tr_cr) as NetMovement,
                        COUNT(*) as TransactionCount
                    FROM QGlschstatment 
                    WHERE cstyp_NO = 1 
                    AND CSMSUP_NO = @CustomerNo
                    AND (@AccountNo = '' OR @AccountNo IS NULL OR Acc_no = @AccountNo)
                    AND Tr_Dt BETWEEN @FromDate AND @ToDate
                    GROUP BY YEAR(Tr_Dt), MONTH(Tr_Dt), DATENAME(MONTH, Tr_Dt)
                    ORDER BY YEAR(Tr_Dt), MONTH(Tr_Dt)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerNo", customerNo);
                    cmd.Parameters.AddWithValue("@AccountNo", string.IsNullOrEmpty(accountNo) ? "" : accountNo);
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            gvMonthlyPivot.DataSource = dt;
                            gvMonthlyPivot.DataBind();
                            monthlyPivotSection.Visible = true;
                        }
                        else
                        {
                            monthlyPivotSection.Visible = false;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ShowMessage("خطأ في تحميل التحليل الشهري: " + ex.Message, "error");
            monthlyPivotSection.Visible = false;
        }
    }

    private void UpdateBalanceCards(decimal opening, decimal movement, decimal closing, int transactionCount)
    {
        // Opening Balance
        openingBalanceCard.InnerText = opening.ToString("N2");
        openingBalanceCard.Attributes["class"] = "balance-amount " + (opening > 0 ? "positive" : opening < 0 ? "negative" : "zero");

        // Period Movement
        periodMovementCard.InnerText = movement.ToString("N2");
        periodMovementCard.Attributes["class"] = "balance-amount " + (movement > 0 ? "positive" : movement < 0 ? "negative" : "zero");

        // Closing Balance
        closingBalanceCard.InnerText = closing.ToString("N2");
        closingBalanceCard.Attributes["class"] = "balance-amount " + (closing > 0 ? "positive" : closing < 0 ? "negative" : "zero");

        // Transaction Count
        transactionCountCard.InnerText = transactionCount.ToString();
        transactionCountCard.Attributes["class"] = "balance-amount";
    }

    protected void gvStatement_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView drv = (DataRowView)e.Row.DataItem;
            
            // Check if this is the opening balance row
            if (drv["Description"].ToString() == "الرصيد الافتتاحي")
            {
                e.Row.CssClass = "opening-row";
                return;
            }

            // Format amounts
            decimal debit = Convert.ToDecimal(drv["Tr_db"] ?? 0);
            decimal credit = Convert.ToDecimal(drv["tr_cr"] ?? 0);
            decimal runningBalance = Convert.ToDecimal(drv["RunningBalance"] ?? 0);

            // Format debit column
            if (e.Row.Cells[5].Controls.Count > 0)
            {
                e.Row.Cells[5].Text = debit.ToString("N2");
                if (debit > 0)
                    e.Row.Cells[5].CssClass += " positive-amount";
            }

            // Format credit column
            if (e.Row.Cells[6].Controls.Count > 0)
            {
                e.Row.Cells[6].Text = credit.ToString("N2");
                if (credit > 0)
                    e.Row.Cells[6].CssClass += " positive-amount";
            }

            // Format running balance column
            if (e.Row.Cells[7].Controls.Count > 0)
            {
                e.Row.Cells[7].Text = runningBalance.ToString("N2");
                if (runningBalance > 0)
                    e.Row.Cells[7].CssClass += " positive-amount";
                else if (runningBalance < 0)
                    e.Row.Cells[7].CssClass += " negative-amount";
            }
        }
    }

    protected void gvMonthlyPivot_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            DataRowView drv = (DataRowView)e.Row.DataItem;
            
            decimal netMovement = Convert.ToDecimal(drv["NetMovement"] ?? 0);
            
            // Format net movement column
            if (e.Row.Cells[3].Controls.Count > 0)
            {
                if (netMovement > 0)
                    e.Row.Cells[3].CssClass += " positive-pivot";
                else if (netMovement < 0)
                    e.Row.Cells[3].CssClass += " negative-pivot";
            }
        }
    }

    protected void btnExportExcel_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=CustomerStatement.xls");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";

            using (StringWriter sw = new StringWriter())
            {
                HtmlTextWriter hw = new HtmlTextWriter(sw);
                
                // Export the GridView
                gvStatement.HeaderRow.BackColor = System.Drawing.Color.White;
                foreach (TableCell cell in gvStatement.HeaderRow.Cells)
                {
                    cell.BackColor = gvStatement.HeaderStyle.BackColor;
                }

                foreach (GridViewRow row in gvStatement.Rows)
                {
                    row.BackColor = System.Drawing.Color.White;
                    foreach (TableCell cell in row.Cells)
                    {
                        if (row.RowIndex % 2 == 0)
                        {
                            cell.BackColor = gvStatement.AlternatingRowStyle.BackColor;
                        }
                        else
                        {
                            cell.BackColor = gvStatement.RowStyle.BackColor;
                        }
                        cell.CssClass = "";
                    }
                }

                gvStatement.RenderControl(hw);
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

    private void ShowMessage(string message, string type)
    {
        string alertClass = type == "success" ? "success-message" : "error-message";
        string icon = type == "success" ? "fas fa-check-circle" : "fas fa-exclamation-triangle";
        
        litMessage.Text = $@"
            <div class='message {alertClass}'>
                <i class='{icon}'></i>
                {message}
            </div>";
    }

    private void ClearResults()
    {
        balanceSection.Visible = false;
        tableContainer.Visible = false;
        exportButtons.Visible = false;
        monthlyPivotSection.Visible = false;
        customerInfo.Visible = false;
    }

    public override void VerifyRenderingInServerForm(Control control)
    {
        // Required for exporting GridView to Excel
    }
}
