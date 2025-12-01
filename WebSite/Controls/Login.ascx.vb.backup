Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls


Partial Public Class Controls_Login
    Inherits Global.System.Web.UI.UserControl
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If (Page.User.Identity.IsAuthenticated AndAlso Not (String.IsNullOrEmpty(Request.Params("ReturnUrl")))) Then
            Response.Redirect("~/Pages/Home.aspx")
        End If
    End Sub
End Class
