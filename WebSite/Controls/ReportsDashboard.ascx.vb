Imports DashboardModels

Partial Public Class Controls_ReportsDashboard
    Inherits Global.System.Web.UI.UserControl

    Private _reportsModel As ReportsDashboardModel

    Public Property ReportsModel As ReportsDashboardModel
        Get
            If _reportsModel Is Nothing Then
                _reportsModel = New ReportsDashboardModel()
            End If
            Return _reportsModel
        End Get
        Set(value As ReportsDashboardModel)
            _reportsModel = value
        End Set
    End Property

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadReportsData()
            BindData()
        End If
    End Sub

    Private Sub LoadReportsData()
        ReportsModel = New ReportsDashboardModel()
    End Sub

    Private Sub BindData()
        If lblTotalReports IsNot Nothing Then
            lblTotalReports.Text = ReportsModel.TotalReports.ToString()
        End If
        
        If lblRecentReports IsNot Nothing Then
            lblRecentReports.Text = If(ReportsModel.RecentActivities IsNot Nothing, ReportsModel.RecentActivities.Count.ToString(), "0")
        End If
        
        If lblScheduledReports IsNot Nothing Then
            lblScheduledReports.Text = ReportsModel.ScheduledReports.ToString()
        End If

        If lblGeneratedToday IsNot Nothing Then
            lblGeneratedToday.Text = ReportsModel.GeneratedToday.ToString()
        End If

        If lblActiveReports IsNot Nothing Then
            lblActiveReports.Text = ReportsModel.ActiveReports.ToString()
        End If
        
        If rptAvailableReports IsNot Nothing Then
            rptAvailableReports.DataSource = ReportsModel.AvailableReports
            rptAvailableReports.DataBind()
        End If
    End Sub

    <System.Web.Services.WebMethod()>
    Public Shared Function HandleReportsAction(action As String, data As String) As String
        Try
            Select Case action.ToLower()
                Case "generatereport"
                    Return "تم إنشاء التقرير بنجاح"
                Case "createcustomreport"
                    Return "تم إنشاء تقرير مخصص"
                Case "schedulereport"
                    Return "تم جدولة التقرير"
                Case "exportdata"
                    Return "تم تصدير البيانات"
                Case Else
                    Return "إجراء غير معروف"
            End Select
        Catch ex As Exception
            Return "خطأ: " & ex.Message
        End Try
    End Function

End Class
