Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.Script.Serialization
Imports DashboardModels

' TestPages/TestDashboardData.aspx.vb
' Code-behind للصفحة التي تعرض بيانات Dashboard للاختبار

Partial Class TestPages_TestDashboardData
    Inherits System.Web.UI.Page

    ' متغيرات البيانات المحمية للاستخدام في الصفحة
    Protected financialData As FinancialDashboardModel
    Protected hrData As HRDashboardModel
    Protected operationsData As OperationsDashboardModel
    Protected reportsData As ReportsDashboardModel
    
    ' معلومات إضافية
    Protected systemInfo As Dictionary(Of String, Object)
    Protected lastUpdated As DateTime
    Protected dataSource As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ' تسجيل بدء تحميل الصفحة
            Response.Write("<!-- Page Load Started: " & DateTime.Now.ToString() & " -->")
            
            If Not IsPostBack Then
                LoadDashboardData()
                LoadSystemInfo()
            End If
            
            ' تحديث معلومات آخر تحديث
            lastUpdated = DateTime.Now
            dataSource = "Sample Data Generator"
            
        Catch ex As Exception
            ' في حالة حدوث خطأ، استخدم بيانات افتراضية
            HandleError(ex)
            LoadFallbackData()
        End Try
    End Sub

    Private Sub LoadDashboardData()
        Try
            ' تحميل بيانات المحاسبة المالية
            financialData = New FinancialDashboardModel()
            financialData.LoadSampleData()
            
            ' تحميل بيانات الموارد البشرية
            hrData = New HRDashboardModel()
            hrData.LoadSampleData()
            
            ' تحميل بيانات العمليات
            operationsData = New OperationsDashboardModel()
            operationsData.LoadSampleData()
            
            ' تحميل بيانات التقارير
            reportsData = New ReportsDashboardModel()
            reportsData.LoadSampleData()
            
            ' تسجيل نجاح التحميل
            Response.Write("<!-- Dashboard Data Loaded Successfully -->")
            
        Catch ex As Exception
            Throw New Exception("خطأ في تحميل بيانات Dashboard: " & ex.Message, ex)
        End Try
    End Sub

    Private Sub LoadSystemInfo()
        Try
            systemInfo = New Dictionary(Of String, Object)()
            
            ' معلومات النظام
            systemInfo.Add("SystemName", "SASERP V37")
            systemInfo.Add("Version", "37.1.0")
            systemInfo.Add("BuildDate", "2025-08-08")
            systemInfo.Add("Environment", "Development")
            
            ' معلومات الخادم
            systemInfo.Add("ServerName", Environment.MachineName)
            systemInfo.Add("ServerTime", DateTime.Now)
            systemInfo.Add("TimeZone", TimeZone.CurrentTimeZone.StandardName)
            
            ' معلومات المستخدم
            If HttpContext.Current.User IsNot Nothing AndAlso HttpContext.Current.User.Identity.IsAuthenticated Then
                systemInfo.Add("UserName", HttpContext.Current.User.Identity.Name)
                systemInfo.Add("IsAuthenticated", True)
            Else
                systemInfo.Add("UserName", "Guest")
                systemInfo.Add("IsAuthenticated", False)
            End If
            
            ' إحصائيات الأداء
            systemInfo.Add("MemoryUsage", GC.GetTotalMemory(False))
            systemInfo.Add("ProcessorCount", Environment.ProcessorCount)
            
            ' معلومات التطبيق
            systemInfo.Add("ApplicationPath", HttpContext.Current.Request.ApplicationPath)
            systemInfo.Add("VirtualPath", HttpContext.Current.Request.Path)
            
        Catch ex As Exception
            ' في حالة فشل تحميل معلومات النظام، استخدم معلومات أساسية
            systemInfo = New Dictionary(Of String, Object)()
            systemInfo.Add("SystemName", "SASERP V37")
            systemInfo.Add("Status", "Limited Info Available")
            systemInfo.Add("Error", ex.Message)
        End Try
    End Sub

    Private Sub LoadFallbackData()
        Try
            ' بيانات احتياطية في حالة فشل التحميل الرئيسي
            financialData = New FinancialDashboardModel() With {
                .TotalRevenue = 100000,
                .TotalExpenses = 75000,
                .NetProfit = 25000,
                .CashFlow = 50000
            }
            
            hrData = New HRDashboardModel() With {
                .TotalEmployees = 50,
                .PresentToday = 45,
                .OnLeave = 3,
                .NewHires = 2
            }
            
            operationsData = New OperationsDashboardModel() With {
                .TotalOrders = 100,
                .ProcessedToday = 25,
                .PendingOrders = 15,
                .CompletedOrders = 85
            }
            
            reportsData = New ReportsDashboardModel() With {
                .TotalReports = 25,
                .GeneratedToday = 5,
                .ScheduledReports = 8,
                .ActiveReports = 12
            }
            
            Response.Write("<!-- Fallback Data Loaded -->")
            
        Catch ex As Exception
            ' إذا فشل حتى تحميل البيانات الاحتياطية، استخدم بيانات فارغة
            InitializeEmptyData()
        End Try
    End Sub

    Private Sub InitializeEmptyData()
        financialData = New FinancialDashboardModel()
        hrData = New HRDashboardModel()
        operationsData = New OperationsDashboardModel()
        reportsData = New ReportsDashboardModel()
        
        Response.Write("<!-- Empty Data Initialized -->")
    End Sub

    Private Sub HandleError(ByVal ex As Exception)
        ' تسجيل الخطأ
        Dim errorMessage As String = String.Format("خطأ في الصفحة {0}: {1}", Request.Path, ex.Message)
        
        ' كتابة الخطأ كتعليق HTML للتطوير
        Response.Write("<!-- ERROR: " & errorMessage & " -->")
        
        ' في بيئة الإنتاج، يمكن إرسال الخطأ إلى نظام التسجيل
        ' Logger.LogError(errorMessage, ex)
    End Sub

    ' دوال مساعدة للصفحة
    Protected Function FormatCurrency(ByVal amount As Decimal) As String
        Return amount.ToString("C", New System.Globalization.CultureInfo("ar-SA"))
    End Function

    Protected Function FormatNumber(ByVal number As Integer) As String
        Return number.ToString("N0")
    End Function

    Protected Function FormatDate(ByVal dateValue As DateTime) As String
        Return dateValue.ToString("dd/MM/yyyy HH:mm")
    End Function

    Protected Function GetStatusClass(ByVal status As String) As String
        Select Case status.ToLower()
            Case "active", "completed", "success"
                Return "status-success"
            Case "pending", "processing"
                Return "status-warning"
            Case "inactive", "failed", "error"
                Return "status-danger"
            Case Else
                Return "status-info"
        End Select
    End Function

    ' دالة للحصول على بيانات JSON للاستخدام في JavaScript
    Protected Function GetDashboardDataAsJson() As String
        Try
            Dim jsonData As New Dictionary(Of String, Object)()
            
            jsonData.Add("financial", financialData)
            jsonData.Add("hr", hrData)
            jsonData.Add("operations", operationsData)
            jsonData.Add("reports", reportsData)
            jsonData.Add("systemInfo", systemInfo)
            jsonData.Add("lastUpdated", lastUpdated)
            
            ' تحويل إلى JSON باستخدام JavaScriptSerializer
            Dim serializer As New JavaScriptSerializer()
            Return serializer.Serialize(jsonData)
            
        Catch ex As Exception
            ' في حالة فشل التحويل، أرجع JSON أساسي
            Return "{""status"":""error"",""message"":""" & ex.Message & """}"
        End Try
    End Function

    ' WebMethod للحصول على البيانات عبر AJAX
    <System.Web.Services.WebMethod()>
    Public Shared Function GetLiveData() As String
        Try
            Dim financial As New FinancialDashboardModel()
            financial.LoadSampleData()
            
            Dim serializer As New JavaScriptSerializer()
            Return serializer.Serialize(financial)
        Catch ex As Exception
            Return "{""error"":""" & ex.Message & """}"
        End Try
    End Function

    ' WebMethod للحصول على إحصائيات سريعة
    <System.Web.Services.WebMethod()>
    Public Shared Function GetQuickStats() As String
        Try
            Dim stats As New Dictionary(Of String, Object)()
            stats.Add("timestamp", DateTime.Now)
            stats.Add("users_online", 15)
            stats.Add("system_status", "Operational")
            stats.Add("last_backup", DateTime.Now.AddHours(-6))
            
            Dim serializer As New JavaScriptSerializer()
            Return serializer.Serialize(stats)
        Catch ex As Exception
            Return "{""error"":""" & ex.Message & """}"
        End Try
    End Function

End Class
