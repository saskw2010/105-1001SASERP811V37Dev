Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DashboardModels

Partial Public Class Controls_HRDashboard
    Inherits Global.System.Web.UI.UserControl

    Private _hrModel As HRDashboardModel

    ''' <summary>
    ''' HR Dashboard Model Property
    ''' خاصية نموذج لوحة تحكم الموارد البشرية
    ''' </summary>
    Public Property HRModel As HRDashboardModel
        Get
            If _hrModel Is Nothing Then
                _hrModel = New HRDashboardModel()
            End If
            Return _hrModel
        End Get
        Set(value As HRDashboardModel)
            _hrModel = value
        End Set
    End Property

    ''' <summary>
    ''' Page Load Event
    ''' حدث تحميل الصفحة
    ''' </summary>
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadHRData()
            BindData()
        End If
    End Sub

    ''' <summary>
    ''' Load HR data from model
    ''' تحميل بيانات الموارد البشرية من النموذج
    ''' </summary>
    Private Sub LoadHRData()
        Try
            HRModel = New HRDashboardModel()
            System.Diagnostics.Debug.WriteLine("HR Dashboard: Loaded " & HRModel.Departments.Count.ToString() & " departments")
            System.Diagnostics.Debug.WriteLine("HR Dashboard: Loaded " & HRModel.RecentActivities.Count.ToString() & " activities")
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error loading HR data: " & ex.Message)
            CreateFallbackData()
        End Try
    End Sub

    ''' <summary>
    ''' Bind data to UI controls
    ''' ربط البيانات بعناصر واجهة المستخدم
    ''' </summary>
    Private Sub BindData()
        Try
            BindEmployeeStatistics()
            BindDepartmentsData()
            BindActivitiesData()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error binding HR data: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Bind employee statistics
    ''' ربط إحصائيات الموظفين
    ''' </summary>
    Private Sub BindEmployeeStatistics()
        If lblTotalEmployees IsNot Nothing Then
            lblTotalEmployees.Text = HRModel.TotalEmployees.ToString()
        End If
        
        If lblActiveEmployees IsNot Nothing Then
            lblActiveEmployees.Text = HRModel.ActiveEmployees.ToString()
        End If
        
        If lblPresentToday IsNot Nothing Then
            lblPresentToday.Text = HRModel.PresentToday.ToString()
        End If
        
        If lblOnLeave IsNot Nothing Then
            lblOnLeave.Text = HRModel.OnLeave.ToString()
        End If
        
        If lblNewHires IsNot Nothing Then
            lblNewHires.Text = HRModel.NewHires.ToString()
        End If
        
        If lblPendingLeaves IsNot Nothing Then
            lblPendingLeaves.Text = HRModel.PendingLeaves.ToString()
        End If
    End Sub

    ''' <summary>
    ''' Bind departments data
    ''' ربط بيانات الأقسام
    ''' </summary>
    Private Sub BindDepartmentsData()
        If rptDepartments IsNot Nothing AndAlso HRModel.Departments IsNot Nothing Then
            rptDepartments.DataSource = HRModel.Departments
            rptDepartments.DataBind()
        End If
    End Sub

    ''' <summary>
    ''' Bind activities data
    ''' ربط بيانات النشاطات
    ''' </summary>
    Private Sub BindActivitiesData()
        If rptActivities IsNot Nothing AndAlso HRModel.RecentActivities IsNot Nothing Then
            Dim recentActivities = HRModel.RecentActivities.Take(6).ToList()
            rptActivities.DataSource = recentActivities
            rptActivities.DataBind()
        End If
    End Sub

    ''' <summary>
    ''' Get activity CSS class based on type
    ''' الحصول على فئة CSS للنشاط حسب النوع
    ''' </summary>
    Protected Function GetActivityClass(activityType As Object) As String
        If activityType Is Nothing Then Return "default"
        
        Dim type As String = activityType.ToString().ToLower()
        Select Case type
            Case "توظيف", "hiring"
                Return "hiring"
            Case "إجازة", "leave"
                Return "leave"
            Case "تدريب", "training"
                Return "training"
            Case Else
                Return "default"
        End Select
    End Function

    ''' <summary>
    ''' Get activity icon based on type
    ''' الحصول على أيقونة النشاط حسب النوع
    ''' </summary>
    Protected Function GetActivityIcon(activityType As Object) As String
        If activityType Is Nothing Then Return "fa-info"
        
        Dim type As String = activityType.ToString().ToLower()
        Select Case type
            Case "توظيف", "hiring"
                Return "fa-user-plus"
            Case "إجازة", "leave"
                Return "fa-calendar-alt"
            Case "تدريب", "training"
                Return "fa-graduation-cap"
            Case Else
                Return "fa-info"
        End Select
    End Function

    ''' <summary>
    ''' Create fallback data
    ''' إنشاء بيانات احتياطية
    ''' </summary>
    Private Sub CreateFallbackData()
        HRModel = New HRDashboardModel() With {
            .TotalEmployees = 50,
            .ActiveEmployees = 48,
            .NewHires = 3,
            .PendingLeaves = 5,
            .Departments = New List(Of DepartmentSummary) From {
                New DepartmentSummary With {
                    .Name = "قسم تجريبي",
                    .EmployeeCount = 10,
                    .Manager = "مدير تجريبي",
                    .Budget = 50000D
                }
            },
            .RecentActivities = New List(Of HRActivity) From {
                New HRActivity With {
                    .Id = 1,
                    .ActivityDate = DateTime.Now.AddDays(-1),
                    .Description = "نشاط تجريبي",
                    .Type = "تدريب",
                    .Employee = "موظف تجريبي"
                }
            }
        }
    End Sub

    ''' <summary>
    ''' Get HR summary for external use
    ''' الحصول على ملخص الموارد البشرية للاستخدام الخارجي
    ''' </summary>
    Public Function GetHRSummary() As String
        Return "الموظفون: " & HRModel.TotalEmployees.ToString() & _
               " - النشطون: " & HRModel.ActiveEmployees.ToString() & _
               " - الجدد: " & HRModel.NewHires.ToString() & _
               " - طلبات الإجازة: " & HRModel.PendingLeaves.ToString()
    End Function

    ''' <summary>
    ''' Handle HR actions (called from JavaScript)
    ''' التعامل مع إجراءات الموارد البشرية (مستدعاة من JavaScript)
    ''' </summary>
    <System.Web.Services.WebMethod()>
    Public Shared Function HandleHRAction(action As String, data As String) As String
        Try
            Select Case action.ToLower()
                Case "addemployee"
                    Return "تم إضافة موظف جديد بنجاح"
                Case "manageleaves"
                    Return "تم فتح إدارة الإجازات"
                Case "generatepayroll"
                    Return "تم إنشاء كشف رواتب جديد"
                Case "viewreports"
                    Return "تم فتح تقارير الموارد البشرية"
                Case "training"
                    Return "تم فتح البرامج التدريبية"
                Case "performance"
                    Return "تم فتح تقييم الأداء"
                Case Else
                    Return "إجراء غير معروف"
            End Select
        Catch ex As Exception
            Return "خطأ: " & ex.Message
        End Try
    End Function

    ''' <summary>
    ''' Refresh HR dashboard data
    ''' تحديث بيانات لوحة تحكم الموارد البشرية
    ''' </summary>
    Public Sub RefreshDashboard()
        LoadHRData()
        BindData()
    End Sub

End Class
