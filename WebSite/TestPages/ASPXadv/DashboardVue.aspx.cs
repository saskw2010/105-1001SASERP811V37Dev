using System;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;
using System.Linq;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;

/// <summary>
/// Represents a dashboard category containing metrics
/// </summary>
public class DashboardCategory
{
    public long Id { get; set; }
    public string NameEn { get; set; }
    public string NameAr { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
    public List<DashboardMetric> Metrics { get; set; }
}

/// <summary>
/// Represents a dashboard metric with value and metadata
/// </summary>
public class DashboardMetric
{
    public string Id { get; set; }
    public long CategoryId { get; set; }
    public int OrderId { get; set; }
    public string Description { get; set; }
    public string UnitName { get; set; }
    public decimal CurrentValue { get; set; }
    public decimal MonthlyBalance { get; set; }
    public string SubType { get; set; }
    public string Icon { get; set; }
    public string Color { get; set; }
    public bool IsRefreshing { get; set; }
}

public partial class app_myaspxpages_DashboardVue : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Login.html");
                return;
            }
        }
    }

    [WebMethod]
    public static string GetDashboardData()
    {
        try
        {
            var categories = LoadUserDashboardCategories();
            return JsonConvert.SerializeObject(categories);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine("Error in GetDashboardData: " + ex.Message);
            throw new Exception("Failed to load dashboard data: " + ex.Message);
        }
    }

    [WebMethod]
    public static string RefreshMetric(long categoryId, int metricId)
    {
        try
        {
            var metric = LoadSingleMetric(categoryId, metricId);
            return JsonConvert.SerializeObject(metric);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine("Error in RefreshMetric: " + ex.Message);
            throw new Exception("Failed to refresh metric: " + ex.Message);
        }
    }

    private static List<DashboardCategory> LoadUserDashboardCategories()
    {
        var categories = new List<DashboardCategory>();
        
        // Get current user roles
        string currentUser = HttpContext.Current.User.Identity.Name;
        if (string.IsNullOrEmpty(currentUser))
        {
            throw new Exception("User not authenticated");
        }

        string[] userRoles = Roles.GetRolesForUser(currentUser);
        System.Diagnostics.Debug.WriteLine("Loading categories for user: " + currentUser + ", roles: " + string.Join(", ", userRoles));

        using (SqlConnection conn = new SqlConnection(GetConnectionString()))
        {
            conn.Open();
            
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT DashboardCatID, CatNameAr, CatNameEn, Description, UserRoles
                FROM DashboardCatList 
                ORDER BY DashboardCatID", conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long catId = Convert.ToInt64(reader["DashboardCatID"]);
                        string userRolesStr = reader["UserRoles"] != null ? reader["UserRoles"].ToString() : "";
                        
                        // Check if user has access to this category
                        if (HasCategoryAccess(userRoles, userRolesStr))
                        {
                            var category = new DashboardCategory
                            {
                                Id = catId,
                                NameEn = reader["CatNameEn"] != null ? reader["CatNameEn"].ToString() : "",
                                NameAr = reader["CatNameAr"] != null ? reader["CatNameAr"].ToString() : "",
                                Description = reader["Description"] != null ? reader["Description"].ToString() : "",
                                Icon = GetCategoryIcon(reader["CatNameEn"] != null ? reader["CatNameEn"].ToString() : ""),
                                Metrics = new List<DashboardMetric>()
                            };
                            
                            categories.Add(category);
                        }
                    }
                }
            }
            
            // Load metrics for each category
            foreach (var category in categories)
            {
                category.Metrics = LoadCategoryMetrics(category.Id);
            }
        }

        return categories;
    }

    private static List<DashboardMetric> LoadCategoryMetrics(long categoryId)
    {
        var metrics = new List<DashboardMetric>();

        using (SqlConnection conn = new SqlConnection(GetConnectionString()))
        {
            conn.Open();
            
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT 
                    DescriptionKey, 
                    ValueKey as UnitName,
                    COALESCE(OpenBalance, 0) as OpenBalance,
                    COALESCE(Credit, 0) as Credit,
                    COALESCE(Debit, 0) as Debit,
                    ValueKey1 as SubType,
                    OrderID,
                    Acc_no,
                    (SELECT SUM(m.Credit - m.Debit) 
                     FROM DashBoardHome m 
                     WHERE m.Acc_no = d.Acc_no 
                     AND MONTH(m.OpenBalanceDate) = MONTH(GETDATE())
                     AND YEAR(m.OpenBalanceDate) = YEAR(GETDATE())
                    ) as MonthlyBalance
                FROM DashBoardHome d
                WHERE DashboardCatID = @CategoryID 
                ORDER BY OrderID", conn))
            {
                cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string descriptionKey = reader["DescriptionKey"] != null ? reader["DescriptionKey"].ToString() : "";
                        string unitName = reader["UnitName"] != null ? reader["UnitName"].ToString() : "";
                        int orderId = Convert.ToInt32(reader["OrderID"]);
                        
                        decimal currentValue = reader["OpenBalance"] != DBNull.Value && !string.IsNullOrEmpty(reader["OpenBalance"].ToString()) ? 
                            Convert.ToDecimal(reader["OpenBalance"]) : 
                            Convert.ToDecimal(reader["Debit"]) - Convert.ToDecimal(reader["Credit"]);
                            
                        decimal monthlyBalance = reader["MonthlyBalance"] != DBNull.Value ? 
                            Convert.ToDecimal(reader["MonthlyBalance"]) : 0;
                            
                        string subType = reader["SubType"] != null ? reader["SubType"].ToString() : "";

                        var metric = new DashboardMetric
                        {
                            Id = categoryId + "_" + orderId,
                            CategoryId = categoryId,
                            OrderId = orderId,
                            Description = descriptionKey,
                            UnitName = unitName,
                            CurrentValue = currentValue,
                            MonthlyBalance = monthlyBalance,
                            SubType = subType,
                            Icon = GetMetricIcon(descriptionKey),
                            Color = GetMetricColor(categoryId, orderId),
                            IsRefreshing = false
                        };

                        metrics.Add(metric);
                    }
                }
            }
        }

        return metrics;
    }

    private static DashboardMetric LoadSingleMetric(long categoryId, int orderId)
    {
        using (SqlConnection conn = new SqlConnection(GetConnectionString()))
        {
            conn.Open();
            
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT 
                    DescriptionKey, 
                    ValueKey as UnitName,
                    COALESCE(OpenBalance, 0) as OpenBalance,
                    COALESCE(Credit, 0) as Credit,
                    COALESCE(Debit, 0) as Debit,
                    ValueKey1 as SubType,
                    OrderID,
                    Acc_no,
                    (SELECT SUM(m.Credit - m.Debit) 
                     FROM DashBoardHome m 
                     WHERE m.Acc_no = d.Acc_no 
                     AND MONTH(m.OpenBalanceDate) = MONTH(GETDATE())
                     AND YEAR(m.OpenBalanceDate) = YEAR(GETDATE())
                    ) as MonthlyBalance
                FROM DashBoardHome d
                WHERE DashboardCatID = @CategoryID AND OrderID = @OrderID", conn))
            {
                cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string descriptionKey = reader["DescriptionKey"] != null ? reader["DescriptionKey"].ToString() : "";
                        string unitName = reader["UnitName"] != null ? reader["UnitName"].ToString() : "";
                        
                        decimal currentValue = reader["OpenBalance"] != DBNull.Value && !string.IsNullOrEmpty(reader["OpenBalance"].ToString()) ? 
                            Convert.ToDecimal(reader["OpenBalance"]) : 
                            Convert.ToDecimal(reader["Debit"]) - Convert.ToDecimal(reader["Credit"]);
                            
                        decimal monthlyBalance = reader["MonthlyBalance"] != DBNull.Value ? 
                            Convert.ToDecimal(reader["MonthlyBalance"]) : 0;
                            
                        string subType = reader["SubType"] != null ? reader["SubType"].ToString() : "";

                        return new DashboardMetric
                        {
                            Id = categoryId + "_" + orderId,
                            CategoryId = categoryId,
                            OrderId = orderId,
                            Description = descriptionKey,
                            UnitName = unitName,
                            CurrentValue = currentValue,
                            MonthlyBalance = monthlyBalance,
                            SubType = subType,
                            Icon = GetMetricIcon(descriptionKey),
                            Color = GetMetricColor(categoryId, orderId),
                            IsRefreshing = false
                        };
                    }
                }
            }
        }

        throw new Exception("Metric not found: Category " + categoryId + ", Order " + orderId);
    }

    private static bool HasCategoryAccess(string[] userRoles, string categoryRoles)
    {
        if (string.IsNullOrEmpty(categoryRoles)) return true; // If no roles specified, allow access
        if (userRoles.Contains("Admin", StringComparer.OrdinalIgnoreCase) || 
            userRoles.Contains("administrators", StringComparer.OrdinalIgnoreCase)) return true;

        var requiredRoles = categoryRoles.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                       .Select(r => r.Trim().ToLower());
        return userRoles.Any(role => requiredRoles.Contains(role.ToLower()));
    }

    private static string GetCategoryIcon(string categoryName)
    {
        if (string.IsNullOrEmpty(categoryName))
            return "fas fa-chart-bar";

        string lowerName = categoryName.ToLower();
        if (lowerName.Contains("finance") || lowerName.Contains("مالية"))
            return "fas fa-coins";
        if (lowerName.Contains("fleet") || lowerName.Contains("أسطول"))
            return "fas fa-car";
        if (lowerName.Contains("customer") || lowerName.Contains("عميل"))
            return "fas fa-users";
        if (lowerName.Contains("supplier") || lowerName.Contains("مورد"))
            return "fas fa-truck";
        
        return "fas fa-chart-bar"; // Default icon
    }

    private static string GetMetricIcon(string descriptionKey)
    {
        if (string.IsNullOrEmpty(descriptionKey))
            return "fas fa-chart-bar";

        string key = descriptionKey.ToLower();
        if (key.Contains("صندوق") || key.Contains("cash"))
            return "fas fa-cash-register";
        if (key.Contains("بنك") || key.Contains("bank"))
            return "fas fa-university";
        if (key.Contains("دائنون") || key.Contains("creditor"))
            return "fas fa-hand-holding-usd";
        if (key.Contains("مدينون") || key.Contains("debtor"))
            return "fas fa-users";
        if (key.Contains("تحصيل") || key.Contains("collection"))
            return "fas fa-money-bill-wave";
        if (key.Contains("سيارات") || key.Contains("car"))
            return "fas fa-car";
        if (key.Contains("ورشة") || key.Contains("workshop"))
            return "fas fa-tools";
        
        return "fas fa-chart-bar";
    }

    private static string GetMetricColor(long categoryId, int orderId)
    {
        // Finance category colors
        if (categoryId == 1)
        {
            switch (orderId)
            {
                case 100: return "#28a745"; // Kuwaiti Cash
                case 200: return "#20c997"; // Saudi Cash
                case 300: return "#17a2b8"; // Dollar Cash
                case 400: return "#007bff"; // Bank
                case 700: return "#6610f2"; // Daily Collection
                default: return "#495057";
            }
        }
        // Fleet category colors
        else if (categoryId == 2)
        {
            switch (orderId)
            {
                case 800: return "#28a745"; // Rented Cars
                case 900: return "#dc3545"; // Stopped Cars
                case 1000: return "#ffc107"; // Workshop Cars
                case 1100: return "#17a2b8"; // Requested Cars
                default: return "#495057";
            }
        }
        
        return "#495057"; // Default color
    }

    private static string GetConnectionString()
    {
        var connectionStringSettings = ConfigurationManager.ConnectionStrings["ConnectionString"];
        string connectionString = connectionStringSettings != null ? connectionStringSettings.ConnectionString : null;
        if (string.IsNullOrEmpty(connectionString))
        {
            var eZeeSettings = ConfigurationManager.ConnectionStrings["eZee"];
            connectionString = eZeeSettings != null ? eZeeSettings.ConnectionString : null;
        }
        if (string.IsNullOrEmpty(connectionString))
        {
            var defaultSettings = ConfigurationManager.ConnectionStrings["DefaultConnection"];
            connectionString = defaultSettings != null ? defaultSettings.ConnectionString : null;
        }
        
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new Exception("No valid connection string found");
        }
        
        return connectionString;
    }
}
