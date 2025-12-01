Imports System

Partial Class UnifiedUserTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Page load logic for unified user info system test
        Response.Write("<!-- Unified User Test Page Loaded at " & DateTime.Now.ToString() & " -->")
    End Sub
End Class
