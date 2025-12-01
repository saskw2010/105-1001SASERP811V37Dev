Imports DashboardModels

Partial Public Class TestPages_DashboardPreview
    Inherits Global.System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' إعداد الصفحة للعرض
            InitializeDashboards()
        End If
    End Sub

    Private Sub InitializeDashboards()
        Try
            ' تسجيل بداية التحميل
            Response.Write("<!-- بداية تحميل الدشبوردز - " & DateTime.Now.ToString() & " -->")
            
            ' تهيئة الدشبوردز (تتم تلقائياً من خلال الكنترولز)
            ' الكنترولز ستقوم بتحميل البيانات الافتراضية تلقائياً
            
            ' تسجيل نهاية التحميل
            Response.Write("<!-- تم تحميل الدشبوردز بنجاح - " & DateTime.Now.ToString() & " -->")
            
        Catch ex As Exception
            ' في حالة وجود خطأ
            Response.Write("<!-- خطأ في تحميل الدشبوردز: " & ex.Message & " -->")
        End Try
    End Sub

End Class
