
Partial Class Help_Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        mylist.DataSource = YouTubeVideoHelper.GetVideos()
        mylist.DataBind()
    End Sub
End Class
