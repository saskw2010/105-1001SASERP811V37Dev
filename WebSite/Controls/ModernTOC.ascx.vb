Imports System
Imports System.Data
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports translatemeyamosso

Partial Class Controls_ModernTOC
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then
                LoadNavigationData()
            End If
        Catch ex As Exception
            ' Log error and show fallback content
            ShowFallbackContent(ex.Message)
        End Try
    End Sub

    Private Sub LoadNavigationData()
        Try
            ' Create sample navigation data
            Dim navigationData As New DataTable()
            navigationData.Columns.Add("Title", GetType(String))
            navigationData.Columns.Add("Description", GetType(String))
            navigationData.Columns.Add("Url", GetType(String))
            navigationData.Columns.Add("IconClass", GetType(String))

            ' Add sample navigation items
            AddNavigationItem(navigationData, "Home", "Main dashboard and overview", "~/Default.aspx", "fas fa-home")
            AddNavigationItem(navigationData, "Users", "User management and administration", "~/Pages/Users.aspx", "fas fa-users")
            AddNavigationItem(navigationData, "Reports", "Reports and analytics", "~/Pages/Reports.aspx", "fas fa-chart-bar")
            AddNavigationItem(navigationData, "Settings", "System configuration", "~/Pages/Settings.aspx", "fas fa-cog")
            AddNavigationItem(navigationData, "Help", "Documentation and support", "~/Pages/Help.aspx", "fas fa-question-circle")
            AddNavigationItem(navigationData, "About", "About this system", "~/Pages/About.aspx", "fas fa-info-circle")

            ' Try to get data from SiteMap if available
            Try
                If SiteMap.RootNode IsNot Nothing AndAlso SiteMap.RootNode.ChildNodes IsNot Nothing Then
                    navigationData.Clear() ' Clear sample data if we have real sitemap data
                    LoadFromSiteMap(navigationData, SiteMap.RootNode.ChildNodes)
                End If
            Catch ex As Exception
                ' Continue with sample data if sitemap fails
            End Try

            ' Bind data to repeater
            rptModernNavigation.DataSource = navigationData
            rptModernNavigation.DataBind()

        Catch ex As Exception
            ShowFallbackContent(ex.Message)
        End Try
    End Sub

    Private Sub AddNavigationItem(ByVal dt As DataTable, ByVal title As String, ByVal description As String, ByVal url As String, ByVal iconClass As String)
        Dim row As DataRow = dt.NewRow()
        row("Title") = title
        row("Description") = description
        row("Url") = ResolveUrl(url)
        row("IconClass") = iconClass
        dt.Rows.Add(row)
    End Sub

    Private Sub LoadFromSiteMap(ByVal dt As DataTable, ByVal nodes As SiteMapNodeCollection)
        For Each node As SiteMapNode In nodes
            If node.Url IsNot Nothing AndAlso node.Url <> String.Empty Then
                Dim iconClass As String = "fas fa-cube"
                
                ' Determine icon based on URL or title
                If node.Url.ToLower().Contains("users") Then
                    iconClass = "fas fa-users"
                ElseIf node.Url.ToLower().Contains("report") Then
                    iconClass = "fas fa-chart-bar"
                ElseIf node.Url.ToLower().Contains("setting") Then
                    iconClass = "fas fa-cog"
                ElseIf node.Url.ToLower().Contains("help") Then
                    iconClass = "fas fa-question-circle"
                ElseIf node.Url.ToLower().Contains("default") OrElse node.Url.ToLower().Contains("home") Then
                    iconClass = "fas fa-home"
                End If

                AddNavigationItem(dt, node.Title, node.Description, node.Url, iconClass)
            End If
        Next
    End Sub

    Private Sub ShowFallbackContent(ByVal errorMessage As String)
        Try
            ' Create a simple fallback navigation
            Dim fallbackHtml As String = "<div class='modern-nav-card'>" &
                "<i class='modern-nav-icon fas fa-exclamation-triangle'></i>" &
                "<div class='modern-nav-title'>Navigation Error</div>" &
                "<div class='modern-nav-description'>Unable to load navigation: " & Server.HtmlEncode(errorMessage) & "</div>" &
                "</div>"

            cardGrid.InnerHtml = fallbackHtml
        Catch ex As Exception
            ' Last resort fallback
            cardGrid.InnerHtml = "<div>Navigation temporarily unavailable</div>"
        End Try
    End Sub

    Public ReadOnly Property CardGridClientID() As String
        Get
            Return cardGrid.ClientID
        End Get
    End Property

    Public ReadOnly Property LoadingContainerClientID() As String
        Get
            Return loadingContainer.ClientID
        End Get
    End Property

End Class
