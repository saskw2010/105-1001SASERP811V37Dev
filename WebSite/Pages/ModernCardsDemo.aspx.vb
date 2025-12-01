Imports System

Partial Class ModernCardsDemo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' تحديد عنوان الصفحة
            Page.Title = "تجربة الكروت الحديثة - Modern Cards Demo"
        End If
    End Sub
End Class
