
Partial Class pdfviewernew
    Inherits System.Web.UI.Page

    Public Shared SReportFileName1 As String
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        SReportFileName1 = "11"  'Request.QueryString("Name")
        '' ScriptManager.RegisterStartupScript(Me, Me.GetType(), "ClientScript", "printPage1('testme');", True)

    End Sub

    Protected Sub Page_LoadComplete(sender As Object, e As EventArgs) Handles Me.LoadComplete

    End Sub
End Class
