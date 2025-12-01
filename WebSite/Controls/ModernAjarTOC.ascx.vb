Imports System
Imports System.Data
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports translatemeyamosso

Partial Class Controls_ModernAjarTOC
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then
                LoadEnhancedNavigationData()
            End If
        Catch ex As Exception
            ' Log error and show fallback content
            ShowEnhancedFallbackContent(ex.Message)
        End Try
    End Sub

    Private Sub LoadEnhancedNavigationData()
        Try
            ' Create enhanced navigation data with premium features
            Dim navigationData As New DataTable()
            navigationData.Columns.Add("Title", GetType(String))
            navigationData.Columns.Add("Description", GetType(String))
            navigationData.Columns.Add("Url", GetType(String))
            navigationData.Columns.Add("IconClass", GetType(String))
            navigationData.Columns.Add("Category", GetType(String))
            navigationData.Columns.Add("IsPremium", GetType(Boolean))

            ' Add premium navigation items
            AddEnhancedNavigationItem(navigationData, "Dashboard", "Advanced analytics and real-time insights", "~/Default.aspx", "fas fa-tachometer-alt", "Core", True)
            AddEnhancedNavigationItem(navigationData, "User Management", "Advanced user administration with role-based access", "~/Pages/Users.aspx", "fas fa-users-cog", "Administration", True)
            AddEnhancedNavigationItem(navigationData, "Advanced Reports", "Comprehensive reporting with data visualization", "~/Pages/Reports.aspx", "fas fa-chart-line", "Analytics", True)
            AddEnhancedNavigationItem(navigationData, "System Configuration", "Advanced system settings and customization", "~/Pages/Settings.aspx", "fas fa-cogs", "Configuration", True)
            AddEnhancedNavigationItem(navigationData, "API Management", "RESTful API endpoints and documentation", "~/Pages/API.aspx", "fas fa-code", "Development", True)
            AddEnhancedNavigationItem(navigationData, "Security Center", "Advanced security monitoring and controls", "~/Pages/Security.aspx", "fas fa-shield-alt", "Security", True)
            AddEnhancedNavigationItem(navigationData, "Performance Monitor", "System performance metrics and optimization", "~/Pages/Performance.aspx", "fas fa-performance", "Monitoring", True)
            AddEnhancedNavigationItem(navigationData, "Premium Support", "24/7 premium support and documentation", "~/Pages/Support.aspx", "fas fa-headset", "Support", True)

            ' Try to get data from SiteMap if available
            Try
                If SiteMap.RootNode IsNot Nothing AndAlso SiteMap.RootNode.ChildNodes IsNot Nothing Then
                    ' Enhance sitemap data rather than replace it
                    EnhanceSiteMapData(navigationData, SiteMap.RootNode.ChildNodes)
                End If
            Catch ex As Exception
                ' Continue with premium sample data if sitemap fails
            End Try

            ' Bind enhanced data to repeater
            rptModernAjarNavigation.DataSource = navigationData
            rptModernAjarNavigation.DataBind()

        Catch ex As Exception
            ShowEnhancedFallbackContent(ex.Message)
        End Try
    End Sub

    Private Sub AddEnhancedNavigationItem(ByVal dt As DataTable, ByVal title As String, ByVal description As String, ByVal url As String, ByVal iconClass As String, ByVal category As String, ByVal isPremium As Boolean)
        Dim row As DataRow = dt.NewRow()
        row("Title") = title
        row("Description") = description
        row("Url") = ResolveUrl(url)
        row("IconClass") = iconClass
        row("Category") = category
        row("IsPremium") = isPremium
        dt.Rows.Add(row)
    End Sub

    Private Sub EnhanceSiteMapData(ByVal dt As DataTable, ByVal nodes As SiteMapNodeCollection)
        ' Clear sample data if we have real sitemap data
        dt.Clear()
        
        For Each node As SiteMapNode In nodes
            If node.Url IsNot Nothing AndAlso node.Url <> String.Empty Then
                Dim iconClass As String = "fas fa-cube"
                Dim category As String = "General"
                Dim isPremium As Boolean = True ' All items in this premium control are considered premium
                
                ' Enhanced icon determination with more specific mappings
                Select Case True
                    Case node.Url.ToLower().Contains("users") OrElse node.Title.ToLower().Contains("user")
                        iconClass = "fas fa-users-cog"
                        category = "Administration"
                    Case node.Url.ToLower().Contains("report") OrElse node.Title.ToLower().Contains("report")
                        iconClass = "fas fa-chart-line"
                        category = "Analytics"
                    Case node.Url.ToLower().Contains("setting") OrElse node.Title.ToLower().Contains("config")
                        iconClass = "fas fa-cogs"
                        category = "Configuration"
                    Case node.Url.ToLower().Contains("security") OrElse node.Title.ToLower().Contains("security")
                        iconClass = "fas fa-shield-alt"
                        category = "Security"
                    Case node.Url.ToLower().Contains("api") OrElse node.Title.ToLower().Contains("api")
                        iconClass = "fas fa-code"
                        category = "Development"
                    Case node.Url.ToLower().Contains("help") OrElse node.Title.ToLower().Contains("support")
                        iconClass = "fas fa-headset"
                        category = "Support"
                    Case node.Url.ToLower().Contains("default") OrElse node.Url.ToLower().Contains("home") OrElse node.Title.ToLower().Contains("dashboard")
                        iconClass = "fas fa-tachometer-alt"
                        category = "Core"
                    Case node.Title.ToLower().Contains("performance") OrElse node.Title.ToLower().Contains("monitor")
                        iconClass = "fas fa-performance"
                        category = "Monitoring"
                    Case Else
                        iconClass = "fas fa-star"
                        category = "Premium"
                End Select

                ' Enhanced description
                Dim enhancedDescription As String = node.Description
                If String.IsNullOrEmpty(enhancedDescription) Then
                    enhancedDescription = "Advanced " & node.Title & " with premium features and enhanced functionality"
                End If

                AddEnhancedNavigationItem(dt, node.Title, enhancedDescription, node.Url, iconClass, category, isPremium)
            End If
        Next
    End Sub

    Private Sub ShowEnhancedFallbackContent(ByVal errorMessage As String)
        Try
            ' Create an enhanced fallback navigation with premium styling
            Dim fallbackHtml As String = "<div class='modern-ajar-card'>" &
                "<i class='modern-ajar-icon fas fa-exclamation-triangle'></i>" &
                "<div class='modern-ajar-title-text'>Navigation Service Unavailable</div>" &
                "<div class='modern-ajar-description'>The premium navigation service is temporarily unavailable. Please try again later.</div>" &
                "<div class='modern-ajar-badge'>Service Alert</div>" &
                "</div>" &
                "<div class='modern-ajar-card'>" &
                "<i class='modern-ajar-icon fas fa-home'></i>" &
                "<div class='modern-ajar-title-text'>Return to Dashboard</div>" &
                "<div class='modern-ajar-description'>Go back to the main dashboard while we restore the navigation service.</div>" &
                "<div class='modern-ajar-badge'>Available</div>" &
                "</div>"

            ajarCardGrid.InnerHtml = fallbackHtml
        Catch ex As Exception
            ' Last resort premium fallback
            ajarCardGrid.InnerHtml = "<div class='modern-ajar-card'><div class='modern-ajar-title-text'>Premium Navigation</div><div class='modern-ajar-description'>Temporarily unavailable</div></div>"
        End Try
    End Sub

    Public ReadOnly Property AjarCardGridClientID() As String
        Get
            Return ajarCardGrid.ClientID
        End Get
    End Property

    Public ReadOnly Property AjarLoadingContainerClientID() As String
        Get
            Return ajarLoadingContainer.ClientID
        End Get
    End Property

    ' Enhanced methods for premium features
    Public Sub ShowLoadingState()
        Try
            ajarLoadingContainer.Attributes("class") = "modern-ajar-loading active"
            ajarCardGrid.Style("display") = "none"
        Catch ex As Exception
            ' Silently handle errors
        End Try
    End Sub

    Public Sub HideLoadingState()
        Try
            ajarLoadingContainer.Attributes("class") = "modern-ajar-loading"
            ajarCardGrid.Style("display") = "grid"
        Catch ex As Exception
            ' Silently handle errors
        End Try
    End Sub

    Public Sub RefreshNavigationData()
        Try
            LoadEnhancedNavigationData()
        Catch ex As Exception
            ShowEnhancedFallbackContent(ex.Message)
        End Try
    End Sub

End Class
