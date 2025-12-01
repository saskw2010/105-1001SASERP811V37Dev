
Partial Class Help_logout
    Inherits System.Web.UI.Page

    Private Sub Help_logout_Load(sender As Object, e As EventArgs) Handles Me.Load
        System.Web.Security.FormsAuthentication.SignOut()
        Session.Abandon()

    End Sub
End Class
