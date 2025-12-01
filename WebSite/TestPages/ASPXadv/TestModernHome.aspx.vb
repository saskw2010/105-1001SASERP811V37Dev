Imports System

Partial Class TestPages_ASPXADV_TestModernHome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then
                ' Initialize test page
                InitializeTestPage()
            End If
        Catch ex As Exception
            ' Handle any errors
            Response.Write("<div class='alert alert-danger'>Error loading page: " & ex.Message & "</div>")
        End Try
    End Sub

    Private Sub InitializeTestPage()
        ' Set page metadata
        Page.Title = "Modern Home Table of Contents Test - Sky365"
        
        ' Add any initialization logic here
        ScriptManager.RegisterStartupScript(Me, GetType(Page), "TestPageInit",
            "console.log('🧪 TestModernHome page initialized successfully');", True)
    End Sub
End Class
