Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Web
Imports System.Web.Configuration
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Xml.Linq


Partial Public Class _Default
    Inherits Global.System.Web.UI.Page
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If (Request.Params("_page") = "_blank") Then
            Return
        End If
        
        ' التحقق من تسجيل الدخول قبل إعادة التوجيه
        If Not Page.User.Identity.IsAuthenticated Then
            ' إذا لم يكن مسجل دخول، توجيهه إلى صفحة تسجيل الدخول
            Response.Redirect("~/Login.aspx")
            Return
        End If
        
        Dim link As String = Request.Params("_link")
        If Not (String.IsNullOrEmpty(link)) Then
            Dim enc As StringEncryptor = New StringEncryptor()
            Dim permalink() As String = enc.Decrypt(link.Split(Global.Microsoft.VisualBasic.ChrW(44))(0)).Split(Global.Microsoft.VisualBasic.ChrW(63))
            Page.ClientScript.RegisterStartupScript([GetType](), "Redirect", String.Format("location.replace('{0}?_link={1}');" & ControlChars.CrLf , permalink(0), HttpUtility.UrlEncode(link)), true)
        Else
            ' المستخدم مسجل دخول، توجيهه إلى الصفحة الرئيسية
            Response.Redirect("~/Pages/Home.aspx")
        End If
    End Sub
End Class
