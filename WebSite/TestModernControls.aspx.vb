Imports System

Partial Public Class TestModernControls
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                ' Test that controls are loading properly
                TestControlsLoading()
            End If
        Catch ex As Exception
            Response.Write("<div style='color: red; padding: 10px; border: 1px solid red; margin: 10px; border-radius: 5px;'>")
            Response.Write("<strong>Error:</strong> " & Server.HtmlEncode(ex.Message))
            Response.Write("</div>")
        End Try
    End Sub

    Private Sub TestControlsLoading()
        Try
            ' Test ModernTOC control
            If modernTOC1 IsNot Nothing Then
                Response.Write("<!-- ModernTOC control loaded successfully -->")
            Else
                Response.Write("<!-- Warning: ModernTOC control is null -->")
            End If

            ' Test ModernAjarTOC control
            If modernAjarTOC1 IsNot Nothing Then
                Response.Write("<!-- ModernAjarTOC control loaded successfully -->")
            Else
                Response.Write("<!-- Warning: ModernAjarTOC control is null -->")
            End If

        Catch ex As Exception
            Response.Write("<!-- Error testing controls: " & Server.HtmlEncode(ex.Message) & " -->")
        End Try
    End Sub

End Class
