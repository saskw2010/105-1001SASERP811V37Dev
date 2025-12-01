Imports System

Partial Class conversion_status
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' تسجيل معلومات الصفحة
            Page.Title = "TableOfContents Conversion Status - SASERP System"
            
            ' إضافة meta tags
            Dim metaDescription As New HtmlMeta()
            metaDescription.Name = "description"
            metaDescription.Content = "Status page showing successful conversion of TableOfContents controls from Telerik to modern design"
            Page.Header.Controls.Add(metaDescription)
        End If
    End Sub

End Class
