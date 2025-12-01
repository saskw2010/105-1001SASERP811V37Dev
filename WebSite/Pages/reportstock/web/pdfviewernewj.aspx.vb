
Partial Class pdfviewernewj
    Inherits System.Web.UI.Page

    Public Shared SReportFileName1 As String

    Protected Sub Page_InitComplete(sender As Object, e As EventArgs) Handles Me.InitComplete
        '' ScriptManager.RegisterStartupScript(Me, Me.GetType(), "ClientScript", "print({});", True)
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        'SReportFileName1 = "11"  'Request.QueryString("Name")


    End Sub

    Protected Sub Page_LoadComplete(sender As Object, e As EventArgs) Handles Me.LoadComplete

    End Sub

    Protected Sub Page_PreRenderComplete(sender As Object, e As EventArgs) Handles Me.PreRenderComplete

    End Sub
End Class
