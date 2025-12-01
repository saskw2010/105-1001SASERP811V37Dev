Partial Class FullWidthTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' صفحة اختبار العرض الكامل
        ' تستخدم لمراقبة وتشخيص مشاكل عرض المحتوى
        
        If Not IsPostBack Then
            ' تسجيل تحميل الصفحة
            System.Diagnostics.Debug.WriteLine("🚀 Full Width Test Page Loaded")
            System.Diagnostics.Debug.WriteLine("📍 Current Time: " & DateTime.Now.ToString())
            System.Diagnostics.Debug.WriteLine("🌍 User Agent: " & Request.UserAgent)
            System.Diagnostics.Debug.WriteLine("📱 Is Mobile: " & Request.Browser.IsMobileDevice.ToString())
        End If
    End Sub
End Class
