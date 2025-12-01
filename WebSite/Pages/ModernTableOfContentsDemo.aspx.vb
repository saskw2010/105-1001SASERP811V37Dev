Imports System

Partial Public Class Pages_ModernTableOfContentsDemo
    Inherits Global.System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' Set initial theme based on user preference or default
            InitializeTheme()
            ' Initialize the modern TOC
            InitializeModernTOC()
        End If
    End Sub

    Protected Sub btnRefreshCards_Click(sender As Object, e As EventArgs)
        Try
            ' Refresh the ModernTOC control if available
            If modernTOC IsNot Nothing Then
                ' The control will automatically reload its data
                modernTOC.DataBind()
            End If
        Catch ex As Exception
            ' Fallback: Force refresh of the entire page
            Response.Redirect(Request.RawUrl)
        End Try
    End Sub

    Private Sub InitializeTheme()
        ' Ì»œ√ »ÀÌ„ «› —«÷Ì (light) ÊÌÿ»¯ﬁ «·ÀÌ„ «·„Õ›ÊŸ ·Ê „ÊÃÊœ
        Try
            Dim savedTheme As String = Nothing
            Dim themeCookie As HttpCookie = Request.Cookies("themePreference")
            If themeCookie IsNot Nothing Then
                savedTheme = themeCookie.Value
            End If

            If Not String.IsNullOrEmpty(savedTheme) Then
                ' ›· —… »”Ìÿ… ··ﬁÌ„… (Õ—Ê›/√—ﬁ«„/‘—ÿ… Ê‘—ÿ…  Õ  ›ﬁÿ)
                savedTheme = System.Text.RegularExpressions.Regex.Replace(savedTheme, "[^A-Za-z0-9\-_]", "")

                ' 1) √÷› ﬂ·«” ··‹ <body> „À·: theme-dark √Ê theme-light
                'If Body IsNot Nothing Then
                '    Dim cur As String = Body.Attributes("class")
                '    If cur Is Nothing Then cur = String.Empty
                '    Body.Attributes("class") = (cur & " theme-" & savedTheme).Trim()
                'End If

                ' 2) («Œ Ì«—Ì) ·Ê ⁄‰œﬂ „·› CSS ·ﬂ· ÀÌ„
                If Page IsNot Nothing AndAlso Page.Header IsNot Nothing Then
                    Dim cssPath As String = ResolveUrl("~/themes/" & savedTheme & ".css")
                    Dim link As New HtmlLink()
                    link.Href = cssPath
                    link.Attributes("rel") = "stylesheet"
                    link.Attributes("type") = "text/css"
                    Page.Header.Controls.Add(link)
                End If
            End If
        Catch ex As Exception
            '  Ã«Â· √Ì Œÿ√ Ê«” „— »«·ÀÌ„ «·«› —«÷Ì
        End Try
    End Sub


    Private Sub InitializeModernTOC()
        Try
            ' Initialize the modern table of contents
            If modernTOC IsNot Nothing Then
                ' Any additional initialization can be done here
                ' The control will handle its own data loading
            End If
        Catch ex As Exception
            ' Handle initialization errors gracefully
            ' The control should still function with its fallback content
        End Try
    End Sub

    ' Property to access the ModernTOC control
    Protected ReadOnly Property ModernTOCControl() As Object
        Get
            Return modernTOC
        End Get
    End Property

End Class
