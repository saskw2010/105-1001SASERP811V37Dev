using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

// Helper class for date ranges to replace tuple syntax
public class DateRange
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    
    public DateRange(DateTime start, DateTime end)
    {
        Start = start;
        End = end;
    }
}

public partial class app_myaspxpages_FinancialDashboardVue : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Vue.js handles everything on client-side
        // This page only provides Web Methods for API calls
    }

    [WebMethod]
    public static string GetDashboardData(string period, bool isDemo, bool isArabic)
    {
        try
        {
            // Add debugging information
            var debugInfo = new
            {
                period = period,
                isDemo = isDemo,
                isArabic = isArabic,
                connectionStringExists = !string.IsNullOrEmpty(GetWorkingConnectionString()),
                timestamp = DateTime.Now
            };
            
            var result = new
            {
                income = GetIncomeData(period, isDemo, isArabic),
                expenses = GetExpensesData(period, isDemo, isArabic),
                paymentMethods = GetPaymentMethodsData(period, isDemo, isArabic),
                summary = GetSummaryData(period, isDemo, isArabic),
                debug = debugInfo
            };

            return JsonConvert.SerializeObject(result);
        }
        catch (Exception ex)
        {
            // Enhanced error logging
            var errorInfo = new { 
                error = ex.Message, 
                stackTrace = ex.StackTrace,
                period = period,
                isDemo = isDemo,
                timestamp = DateTime.Now
            };
            return JsonConvert.SerializeObject(errorInfo);
        }
    }

    // Helper method to get working connection string
    private static string GetWorkingConnectionString()
    {
        string[] connectionNames = { "ConnectionString", "eZee", "DefaultConnection" };
        
        foreach (string name in connectionNames)
        {
            var connectionStringSettings = ConfigurationManager.ConnectionStrings[name];
            string connString = connectionStringSettings != null ? connectionStringSettings.ConnectionString : null;
            if (!string.IsNullOrEmpty(connString))
            {
                return connString;
            }
        }
        
        return null;
    }

    private static List<object> GetIncomeData(string period, bool isDemo, bool isArabic)
    {
        var data = new List<object>();
        
        if (isDemo)
        {
            // Demo data
            data.Add(new { 
                id = 1, 
                date = DateTime.Today.AddDays(-1), 
                description = isArabic ? "سند قبض رقم 001" : "Receipt #001", 
                amount = 5000,
                method = isArabic ? "نقداً" : "Cash"
            });
            data.Add(new { 
                id = 2, 
                date = DateTime.Today.AddDays(-3), 
                description = isArabic ? "سند قبض رقم 002" : "Receipt #002", 
                amount = 3500,
                method = isArabic ? "شيك" : "Check"
            });
            data.Add(new { 
                id = 3, 
                date = DateTime.Today.AddDays(-5), 
                description = isArabic ? "سند قبض رقم 003" : "Receipt #003", 
                amount = 7200,
                method = isArabic ? "تحويل بنكي" : "Bank Transfer"
            });
        }
        else
        {
            // Real data from database with enhanced debugging
            try
            {
                var dateRange = GetDateRange(period);
                string connectionString = GetWorkingConnectionString();
                
                if (!string.IsNullOrEmpty(connectionString))
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        // Enhanced query with CORRECT joins and table structure
                        string query = @"
                            SELECT TOP 50
                                schglvchdlydetailpayment.schglvchdlydetailpaymentid as Id,
                                schglvchdlydetailpayment.schglvchdlyhdregid as HeaderId,
                                schglvchdlyhdreg.Trs_Dt as TransactionDate,
                                ISNULL(Pymnt_.Pymnt_Nm, @DefaultMethod) as PaymentMethod,
                                ISNULL(schglvchdlydetailpayment.moneypaidto, 0) as Amount,
                                ISNULL(schglvchdlyhdreg.Delevername, @DefaultDescription) as Description,
                                ISNULL(schglvchdlyhdreg.ReferanceNo, '') as ReferenceNo,
                                ISNULL(schBnk_.schBnk_Nm, '') as BankName,
                                ISNULL(schglvchdlydetailpayment.paymentnotes, '') as Notes
                            FROM dbo.schglvchdlydetailpayment schglvchdlydetailpayment
                                LEFT JOIN dbo.schglvchdlyhdreg schglvchdlyhdreg 
                                    ON schglvchdlydetailpayment.schglvchdlyhdregid = schglvchdlyhdreg.schglvchdlyhdregid
                                LEFT JOIN dbo.Pymntype Pymnt_ 
                                    ON schglvchdlydetailpayment.Pymnt_No = Pymnt_.Pymnt_No
                                LEFT JOIN dbo.schGLacnBnk schBnk_ 
                                    ON schglvchdlydetailpayment.schBnk_No = schBnk_.schBnk_No
                            WHERE schglvchdlyhdreg.Trs_Dt >= @StartDate 
                                AND schglvchdlyhdreg.Trs_Dt <= @EndDate
                                AND COALESCE(schglvchdlydetailpayment.moneypaidto, 0) > 0
                            ORDER BY schglvchdlyhdreg.Trs_Dt DESC";

                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@StartDate", dateRange.Start);
                            command.Parameters.AddWithValue("@EndDate", dateRange.End);
                            command.Parameters.AddWithValue("@DefaultDescription", isArabic ? "سند قبض" : "Receipt Voucher");
                            command.Parameters.AddWithValue("@DefaultMethod", isArabic ? "غير محدد" : "Not Specified");

                            connection.Open();
                            using (var reader = command.ExecuteReader())
                            {
                                int recordCount = 0;
                                while (reader.Read())
                                {
                                    recordCount++;
                                    var description = GetSafeString(reader, "Description");
                                    var referenceNo = GetSafeString(reader, "ReferenceNo");
                                    var notes = GetSafeString(reader, "Notes");
                                    
                                    // Build a comprehensive description
                                    var fullDescription = description;
                                    if (!string.IsNullOrEmpty(referenceNo))
                                    {
                                        fullDescription += " - Ref: " + referenceNo;
                                    }
                                    if (!string.IsNullOrEmpty(notes))
                                    {
                                        fullDescription += " - " + notes;
                                    }
                                    
                                    data.Add(new
                                    {
                                        id = GetSafeInt(reader, "Id"),
                                        headerId = GetSafeInt(reader, "HeaderId"),
                                        date = GetSafeDateTime(reader, "TransactionDate"),
                                        description = fullDescription,
                                        amount = GetSafeDecimal(reader, "Amount"),
                                        method = GetSafeString(reader, "PaymentMethod"),
                                        bankName = GetSafeString(reader, "BankName"),
                                        referenceNo = referenceNo,
                                        notes = notes
                                    });
                                }
                                
                                // Add debug record if no data found
                                if (recordCount == 0)
                                {
                                    data.Add(new
                                    {
                                        id = 0,
                                        date = DateTime.Now,
                                        description = "Debug: No data found for " + period + " from " + dateRange.Start.ToString("yyyy-MM-dd") + " to " + dateRange.End.ToString("yyyy-MM-dd"),
                                        amount = 0,
                                        method = "Debug"
                                    });
                                }
                            }
                        }
                    }
                }
                else
                {
                    // No connection string available
                    data.Add(new
                    {
                        id = 0,
                        date = DateTime.Now,
                        description = "Debug: No connection string available",
                        amount = 0,
                        method = "Debug"
                    });
                }
            }
            catch (Exception ex)
            {
                // Add error info to data for debugging
                data.Add(new
                {
                    id = 0,
                    date = DateTime.Now,
                    description = "Debug Error: " + ex.Message,
                    amount = 0,
                    method = "Error"
                });
            }
        }

        return data;
    }

    private static List<object> GetExpensesData(string period, bool isDemo, bool isArabic)
    {
        var data = new List<object>();
        
        if (isDemo)
        {
            // Demo expenses data
            data.Add(new { 
                id = 1, 
                date = DateTime.Today.AddDays(-2), 
                description = isArabic ? "مصروف مكتبي" : "Office Expense", 
                amount = 1200 
            });
            data.Add(new { 
                id = 2, 
                date = DateTime.Today.AddDays(-4), 
                description = isArabic ? "فاتورة كهرباء" : "Electricity Bill", 
                amount = 800 
            });
        }
        else
        {
            // Real expenses data from payment cash tables
            try
            {
                var dateRange = GetDateRange(period);
                string connectionString = GetWorkingConnectionString();
                
                if (!string.IsNullOrEmpty(connectionString))
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        // Updated query using payment cash schema for expenses
                        string query = @"
                            SELECT 
                                schglpaydlydetailpaymentcash.schglpaydlydetailpaymentid as Id,
                                schglpaydlydetailpaymentcash.schglpaydlyhdregid as HeaderId,
                                schglpaydlyhdreg.Trs_Dt as TransactionDate,
                                ISNULL(Pymnt_.Pymnt_Nm, @DefaultMethod) as PaymentMethod,
                                ISNULL(schglpaydlydetailpaymentcash.curvalue, 0) as Amount,
                                ISNULL(schglpaydlydetailpaymentcash.moneypaidto, @DefaultDescription) as Description,
                                ISNULL(schglpaydlydetailpaymentcash.paymentnotes, '') as Notes,
                                ISNULL(Acc_.Acc_Nm, '') as AccountName,
                                ISNULL(Acc_Clsacc_.Acc_Nm, '') as AccountClass,
                                ISNULL(schBnk_.schBnk_Nm, '') as BankName,
                                ISNULL(glcostcntr.Costcntr_Nm, '') as CostCenter
                            FROM dbo.schglpaydlydetailpaymentcash schglpaydlydetailpaymentcash
                                LEFT JOIN dbo.schglpaydlyhdregcash schglpaydlyhdreg 
                                    ON schglpaydlydetailpaymentcash.schglpaydlyhdregid = schglpaydlyhdreg.schglpaydlyhdregid
                                LEFT JOIN dbo.Pymntype Pymnt_ 
                                    ON schglpaydlydetailpaymentcash.Pymnt_No = Pymnt_.Pymnt_No
                                LEFT JOIN dbo.GLmstrfl Acc_ 
                                    ON schglpaydlydetailpaymentcash.Acc_no = Acc_.Acc_No
                                LEFT JOIN dbo.GLmfbab Acc_Clsacc_ 
                                    ON Acc_.Clsacc_No = Acc_Clsacc_.Acc_Bab
                                LEFT JOIN dbo.schGLacnBnk schBnk_ 
                                    ON schglpaydlydetailpaymentcash.schBnk_No = schBnk_.schBnk_No
                                LEFT JOIN dbo.GLcostcntr glcostcntr 
                                    ON schglpaydlydetailpaymentcash.glcostcntr = glcostcntr.Costcntr_No
                            WHERE schglpaydlyhdreg.Trs_Dt >= @StartDate 
                                AND schglpaydlyhdreg.Trs_Dt <= @EndDate
                                AND COALESCE(schglpaydlydetailpaymentcash.curvalue, 0) > 0
                            ORDER BY schglpaydlyhdreg.Trs_Dt DESC";

                        using (var command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@StartDate", dateRange.Start);
                            command.Parameters.AddWithValue("@EndDate", dateRange.End);
                            command.Parameters.AddWithValue("@DefaultDescription", isArabic ? "سند صرف" : "Payment Voucher");
                            command.Parameters.AddWithValue("@DefaultMethod", isArabic ? "غير محدد" : "Not Specified");

                            connection.Open();
                            using (var reader = command.ExecuteReader())
                            {
                                int recordCount = 0;
                                while (reader.Read())
                                {
                                    recordCount++;
                                    var description = GetSafeString(reader, "Description");
                                    var notes = GetSafeString(reader, "Notes");
                                    var accountName = GetSafeString(reader, "AccountName");
                                    var accountClass = GetSafeString(reader, "AccountClass");
                                    var costCenter = GetSafeString(reader, "CostCenter");
                                    
                                    // Build a comprehensive description for expenses
                                    var fullDescription = description;
                                    if (!string.IsNullOrEmpty(accountName))
                                    {
                                        fullDescription += " - " + accountName;
                                    }
                                    if (!string.IsNullOrEmpty(accountClass))
                                    {
                                        fullDescription += " (" + accountClass + ")";
                                    }
                                    if (!string.IsNullOrEmpty(costCenter))
                                    {
                                        fullDescription += " - " + costCenter;
                                    }
                                    if (!string.IsNullOrEmpty(notes))
                                    {
                                        fullDescription += " - " + notes;
                                    }
                                    
                                    data.Add(new
                                    {
                                        id = GetSafeInt(reader, "Id"),
                                        headerId = GetSafeInt(reader, "HeaderId"),
                                        date = GetSafeDateTime(reader, "TransactionDate"),
                                        description = fullDescription,
                                        amount = GetSafeDecimal(reader, "Amount"),
                                        method = GetSafeString(reader, "PaymentMethod"),
                                        bankName = GetSafeString(reader, "BankName"),
                                        accountName = accountName,
                                        accountClass = accountClass,
                                        costCenter = costCenter,
                                        notes = notes
                                    });
                                }
                                
                                // Add debug record if no data found
                                if (recordCount == 0)
                                {
                                    data.Add(new
                                    {
                                        id = 0,
                                        date = DateTime.Now,
                                        description = "Debug: No expense data found for " + period + " from " + dateRange.Start.ToString("yyyy-MM-dd") + " to " + dateRange.End.ToString("yyyy-MM-dd"),
                                        amount = 0,
                                        method = "Debug"
                                    });
                                }
                            }
                        }
                    }
                }
                else
                {
                    // No connection string available
                    data.Add(new
                    {
                        id = 0,
                        date = DateTime.Now,
                        description = "Debug: No connection string available for expenses",
                        amount = 0,
                        method = "Debug"
                    });
                }
            }
            catch (Exception ex)
            {
                // Add error info to data for debugging
                data.Add(new
                {
                    id = 0,
                    date = DateTime.Now,
                    description = "Debug Error in Expenses: " + ex.Message,
                    amount = 0,
                    method = "Error"
                });
            }
        }

        return data;
    }

    private static List<object> GetPaymentMethodsData(string period, bool isDemo, bool isArabic)
    {
        var data = new List<object>();
        
        if (isDemo)
        {
            // Demo payment methods
            data.Add(new { method = isArabic ? "نقداً" : "Cash", amount = 8500 });
            data.Add(new { method = isArabic ? "شيك" : "Check", amount = 4200 });
            data.Add(new { method = isArabic ? "تحويل بنكي" : "Bank Transfer", amount = 3000 });
        }
        else
        {
            // Real payment methods grouping
            var dateRange = GetDateRange(period);
            var connectionStringSettings = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            string connectionString = connectionStringSettings != null ? connectionStringSettings.ConnectionString : null;
            
            if (!string.IsNullOrEmpty(connectionString))
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            Pymnt_Pymnt_Nm as PaymentMethod,
                            SUM(moneypaidto) as TotalAmount,
                            COUNT(*) as TransactionCount
                        FROM schglvchdlydetailpayment 
                        WHERE Trs_Dt BETWEEN @StartDate AND @EndDate
                        GROUP BY Pymnt_Pymnt_Nm
                        ORDER BY TotalAmount DESC";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", dateRange.Start);
                        command.Parameters.AddWithValue("@EndDate", dateRange.End);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                data.Add(new
                                {
                                    method = GetSafeString(reader, "PaymentMethod"),
                                    amount = GetSafeDecimal(reader, "TotalAmount"),
                                    count = GetSafeInt(reader, "TransactionCount")
                                });
                            }
                        }
                    }
                }
            }
        }

        return data;
    }

    private static object GetSummaryData(string period, bool isDemo, bool isArabic)
    {
        if (isDemo)
        {
            return new
            {
                totalIncome = 15700m,
                totalExpenses = 2000m,
                balance = 13700m,
                incomeCount = 3,
                expensesCount = 2
            };
        }
        else
        {
            // Calculate real summary using CORRECT table structure
            var dateRange = GetDateRange(period);
            string connectionString = GetWorkingConnectionString();
            
            decimal totalIncome = 0;
            int incomeCount = 0;
            decimal totalExpenses = 0;
            int expensesCount = 0;
            
            if (!string.IsNullOrEmpty(connectionString))
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    // CORRECTED query for income with proper JOINs and date field
                    string incomeQuery = @"
                        SELECT 
                            SUM(COALESCE(schglvchdlydetailpayment.moneypaidto, 0)) as TotalAmount,
                            COUNT(*) as TransactionCount
                        FROM dbo.schglvchdlydetailpayment schglvchdlydetailpayment
                            LEFT JOIN dbo.schglvchdlyhdreg schglvchdlyhdreg 
                                ON schglvchdlydetailpayment.schglvchdlyhdregid = schglvchdlyhdreg.schglvchdlyhdregid
                        WHERE schglvchdlyhdreg.Trs_Dt >= @StartDate 
                            AND schglvchdlyhdreg.Trs_Dt <= @EndDate
                            AND COALESCE(schglvchdlydetailpayment.moneypaidto, 0) > 0";

                    using (var command = new SqlCommand(incomeQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", dateRange.Start);
                        command.Parameters.AddWithValue("@EndDate", dateRange.End);

                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                totalIncome = GetSafeDecimal(reader, "TotalAmount");
                                incomeCount = GetSafeInt(reader, "TransactionCount");
                            }
                        }
                    }
                    
                    // Query for expenses from payment cash tables
                    string expensesQuery = @"
                        SELECT 
                            SUM(COALESCE(schglpaydlydetailpaymentcash.curvalue, 0)) as TotalAmount,
                            COUNT(*) as TransactionCount
                        FROM dbo.schglpaydlydetailpaymentcash schglpaydlydetailpaymentcash
                            LEFT JOIN dbo.schglpaydlyhdregcash schglpaydlyhdreg 
                                ON schglpaydlydetailpaymentcash.schglpaydlyhdregid = schglpaydlyhdreg.schglpaydlyhdregid
                        WHERE schglpaydlyhdreg.Trs_Dt >= @StartDate 
                            AND schglpaydlyhdreg.Trs_Dt <= @EndDate
                            AND COALESCE(schglpaydlydetailpaymentcash.curvalue, 0) > 0";

                    using (var command = new SqlCommand(expensesQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StartDate", dateRange.Start);
                        command.Parameters.AddWithValue("@EndDate", dateRange.End);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                totalExpenses = GetSafeDecimal(reader, "TotalAmount");
                                expensesCount = GetSafeInt(reader, "TransactionCount");
                            }
                        }
                    }
                }
            }

            return new
            {
                totalIncome = totalIncome,
                totalExpenses = totalExpenses,
                balance = totalIncome - totalExpenses,
                incomeCount = incomeCount,
                expensesCount = expensesCount
            };
        }
    }

    private static DateRange GetDateRange(string period)
    {
        var today = DateTime.Today;
        
        switch (period.ToLower())
        {
            case "today":
                return new DateRange(today, today.AddDays(1).AddSeconds(-1));
            case "week":
                var startOfWeek = today.AddDays(-(int)today.DayOfWeek);
                return new DateRange(startOfWeek, startOfWeek.AddDays(7).AddSeconds(-1));
            case "month":
                var startOfMonth = new DateTime(today.Year, today.Month, 1);
                return new DateRange(startOfMonth, startOfMonth.AddMonths(1).AddSeconds(-1));
            case "year":
                var startOfYear = new DateTime(today.Year, 1, 1);
                return new DateRange(startOfYear, startOfYear.AddYears(1).AddSeconds(-1));
            default:
                return new DateRange(today.AddDays(-30), today.AddDays(1).AddSeconds(-1));
        }
    }

    // Helper methods for safe database value extraction
    private static string GetSafeString(SqlDataReader reader, string columnName)
    {
        try
        {
            int ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? string.Empty : reader.GetString(ordinal);
        }
        catch
        {
            return string.Empty;
        }
    }

    private static int GetSafeInt(SqlDataReader reader, string columnName)
    {
        try
        {
            int ordinal = reader.GetOrdinal(columnName);
            return reader.IsDBNull(ordinal) ? 0 : reader.GetInt32(ordinal);
        }
        catch
        {
            return 0;
        }
    }

    private static decimal GetSafeDecimal(SqlDataReader reader, string columnName)
    {
        try
        {
            int ordinal = reader.GetOrdinal(columnName);
            if (reader.IsDBNull(ordinal)) return 0m;
            
            var value = reader.GetValue(ordinal);
            if (value is decimal) return (decimal)value;
            if (value is double) return (decimal)(double)value;
            if (value is float) return (decimal)(float)value;
            if (value is int) return (decimal)(int)value;
            
            decimal result;
            return decimal.TryParse(value.ToString(), out result) ? result : 0m;
        }
        catch
        {
            return 0m;
        }
    }

    private static DateTime GetSafeDateTime(SqlDataReader reader, string columnName)
    {
        try
        {
            var value = reader[columnName];
            if (value == null || value == DBNull.Value)
                return DateTime.MinValue;
            
            DateTime result;
            return DateTime.TryParse(value.ToString(), out result) ? result : DateTime.MinValue;
        }
        catch
        {
            return DateTime.MinValue;
        }
    }

    // ===================================================================
    // 🎯 Categorized Income WebMethods
    // ===================================================================
    
    [WebMethod]
    public static object GetIncomeCategorySummary(string startDate, string endDate, bool useDemo = false)
    {
        try
        {
            DateTime start = DateTime.Parse(startDate);
            DateTime end = DateTime.Parse(endDate);
            
            string connectionString = GetWorkingConnectionString();
            if (string.IsNullOrEmpty(connectionString))
            {
                return new { success = false, error = "No database connection available" };
            }

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("SP_GetIncomeVouchersWithCategories", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StartDate", start);
                    command.Parameters.AddWithValue("@EndDate", end);
                    command.Parameters.AddWithValue("@UseDemo", useDemo);
                    command.Parameters.AddWithValue("@ReturnSummary", true); // Get summary for cards

                    connection.Open();
                    
                    var categories = new List<object>();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(new
                            {
                                categoryId = GetSafeInt(reader, "CategoryId"),
                                categoryName = GetSafeString(reader, "CategoryName"),
                                categoryIcon = GetSafeString(reader, "CategoryIcon"),
                                voucherCount = GetSafeInt(reader, "VoucherCount"),
                                totalAmount = GetSafeDecimal(reader, "TotalAmount"),
                                avgAmount = GetSafeDecimal(reader, "AvgAmount"),
                                minAmount = GetSafeDecimal(reader, "MinAmount"),
                                maxAmount = GetSafeDecimal(reader, "MaxAmount")
                            });
                        }
                    }

                    return new { success = true, data = categories };
                }
            }
        }
        catch (Exception ex)
        {
            return new { success = false, error = ex.Message };
        }
    }

    [WebMethod]
    public static object GetIncomeDetailsWithCategories(string startDate, string endDate, bool useDemo = false)
    {
        try
        {
            DateTime start = DateTime.Parse(startDate);
            DateTime end = DateTime.Parse(endDate);
            
            string connectionString = GetWorkingConnectionString();
            if (string.IsNullOrEmpty(connectionString))
            {
                return new { success = false, error = "No database connection available" };
            }

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("SP_GetIncomeVouchersWithCategories", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StartDate", start);
                    command.Parameters.AddWithValue("@EndDate", end);
                    command.Parameters.AddWithValue("@UseDemo", useDemo);
                    command.Parameters.AddWithValue("@ReturnSummary", false); // Get details for grid

                    connection.Open();
                    
                    var details = new List<object>();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            details.Add(new
                            {
                                voucherId = GetSafeInt(reader, "VoucherID"),
                                voucherNo = GetSafeString(reader, "VoucherNo"),
                                voucherDate = GetSafeDateTime(reader, "VoucherDate").ToString("yyyy-MM-dd"),
                                amount = GetSafeDecimal(reader, "Amount"),
                                paymentType = GetSafeString(reader, "PaymentType"),
                                description = GetSafeString(reader, "Description"),
                                payerName = GetSafeString(reader, "PayerName"),
                                categoryId = GetSafeInt(reader, "CategoryId"),
                                categoryName = GetSafeString(reader, "CategoryName"),
                                categoryIcon = GetSafeString(reader, "CategoryIcon"),
                                dataSource = GetSafeString(reader, "DataSource"),
                                dataSourceDisplay = GetSafeString(reader, "DataSourceDisplay"),
                                amountFormatted = GetSafeString(reader, "AmountFormatted")
                            });
                        }
                    }

                    return new { success = true, data = details };
                }
            }
        }
        catch (Exception ex)
        {
            return new { success = false, error = ex.Message };
        }
    }
}
