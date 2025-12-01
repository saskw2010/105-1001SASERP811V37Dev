Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Text
Imports System.Web.Security
Imports System.Web.Script.Serialization

Partial Class UniversalHamburgerMenu
    Inherits System.Web.UI.UserControl

    Public Structure NavigationItem
        Public Id As String
        Public Title As String
        Public TranslatedTitle As String
        Public Url As String
        Public Description As String
        Public Icon As String
        Public CssClass As String
        Public Roles() As String
        Public HasChildren As Boolean
        Public Children As List(Of NavigationItem)
        Public Level As Integer
        Public IsVisible As Boolean
        Public IsAccessible As Boolean
        Public ChildrenCount As Integer
        Public ParentId As String
        Public SortOrder As Integer
    End Structure

    Public Structure UserInfo
        Public Username As String
        Public DisplayName As String
        Public Role As String
        Public Avatar As String
        Public IsAuthenticated As Boolean
        Public Permissions() As String
    End Structure

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                LoadNavigationData()
                LoadUserInformation()
                SetCurrentPageInfo()
            End If
        Catch ex As Exception
            ' Log error and provide fallback
            System.Diagnostics.Debug.WriteLine("Error in UniversalHamburgerMenu Page_Load: " & ex.Message)
            LoadFallbackData()
        End Try
    End Sub

    Private Sub LoadNavigationData()
        Try
            Dim provider As SiteMapProvider = SiteMap.Provider
            If provider Is Nothing OrElse provider.RootNode Is Nothing Then
                LoadFallbackMenuData()
                Return
            End If

            Dim startingNode As SiteMapNode = GetStartingNode(provider)
            Dim cacheKey As String = "UHM_Menu_" & If(HttpContext.Current.User.Identity.IsAuthenticated, HttpContext.Current.User.Identity.Name, "anon") & "_" & If(startingNode IsNot Nothing AndAlso Not String.IsNullOrEmpty(startingNode.Url), startingNode.Url, "root")

            Dim cachedJson As String = TryCast(HttpRuntime.Cache(cacheKey), String)
            If Not String.IsNullOrEmpty(cachedJson) Then
                hdnMenuData.Value = cachedJson
                Return
            End If

            Dim navigationItems As New List(Of NavigationItem)

            ' Build menu starting from the selected node (children only), similar to StartFromCurrentNode with ShowStartingNode=False
            If startingNode IsNot Nothing Then
                For Each childNode As SiteMapNode In startingNode.ChildNodes
                    If IsNodeAccessible(childNode) Then
                        Dim navItem = ProcessSiteMapNode(childNode, 0)
                        If navItem.IsVisible Then
                            navigationItems.Add(navItem)
                        End If
                    End If
                Next
            End If

            ' Sort by priority/order
            navigationItems = navigationItems.OrderBy(Function(x) x.SortOrder).ToList()

            ' Convert to JSON for JavaScript consumption using JavaScriptSerializer (project convention)
            Dim js As New JavaScriptSerializer()
            js.MaxJsonLength = Integer.MaxValue
            Dim jsonData As String = js.Serialize(navigationItems)
            hdnMenuData.Value = jsonData

            ' Cache for 10 minutes per user + starting node
            HttpRuntime.Cache.Insert(cacheKey, jsonData, Nothing, DateTime.Now.AddMinutes(10), System.Web.Caching.Cache.NoSlidingExpiration)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error loading navigation data: " & ex.Message)
            LoadFallbackMenuData()
        End Try
    End Sub

    Private Function GetStartingNode(provider As SiteMapProvider) As SiteMapNode
        Try
            ' 1) QueryString override: ?startNode=/Pages/Finance/Default.aspx or app-relative path
            Dim qsStart As String = HttpContext.Current.Request.QueryString("startNode")
            If Not String.IsNullOrEmpty(qsStart) Then
                Dim nodeFromQs As SiteMapNode = provider.FindSiteMapNode(qsStart)
                If nodeFromQs IsNot Nothing Then
                    If nodeFromQs.HasChildNodes Then Return nodeFromQs
                    If nodeFromQs.ParentNode IsNot Nothing Then Return nodeFromQs.ParentNode
                End If
            End If

            ' 2) Current node logic
            Dim current As SiteMapNode = SiteMap.CurrentNode
            If current Is Nothing Then
                Return provider.RootNode
            End If

            If current.HasChildNodes Then
                Return current
            End If

            If current.ParentNode IsNot Nothing Then
                Return current.ParentNode
            End If

            Return provider.RootNode
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error determining starting node: " & ex.Message)
            Return provider.RootNode
        End Try
    End Function

    Private Function ProcessSiteMapNode(node As SiteMapNode, level As Integer) As NavigationItem
        Dim navItem As New NavigationItem()

        Try
            navItem.Id = Guid.NewGuid().ToString()
            navItem.Title = CleanMenuTitle(node.Title)
            navItem.TranslatedTitle = GetTranslatedTitle(node.Title)
            navItem.Url = If(String.IsNullOrEmpty(node.Url), "#", ResolveUrl(node.Url))
            navItem.Description = node.Description
            navItem.Icon = GetIconForNode(node)
            navItem.CssClass = If(node("cssClass"), "")
            navItem.Level = level
            navItem.HasChildren = node.HasChildNodes
            navItem.IsVisible = True
            navItem.IsAccessible = IsNodeAccessible(node)
            navItem.SortOrder = GetNodeSortOrder(node)

            ' Process roles
            If node.Roles IsNot Nothing AndAlso node.Roles.Count > 0 Then
                Dim rolesList As New List(Of String)()
                For Each role As String In node.Roles
                    If Not String.IsNullOrEmpty(role) Then rolesList.Add(role.Trim())
                Next
                If rolesList.Count = 0 Then
                    navItem.Roles = New String() {"*"}
                Else
                    navItem.Roles = rolesList.ToArray()
                End If
            Else
                navItem.Roles = New String() {"*"}
            End If

            ' Process children - Support up to 3 levels (0, 1, 2)
            navItem.Children = New List(Of NavigationItem)
            If node.HasChildNodes AndAlso level < 2 Then ' Allow children only if current level is less than 2 (to support levels 0, 1, 2)
                For Each childNode As SiteMapNode In node.ChildNodes
                    If IsNodeAccessible(childNode) Then
                        Dim childItem = ProcessSiteMapNode(childNode, level + 1)
                        If childItem.IsVisible Then
                            childItem.ParentId = navItem.Id
                            navItem.Children.Add(childItem)
                        End If
                    End If
                Next
                navItem.ChildrenCount = navItem.Children.Count
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error processing sitemap node: " & ex.Message)
            navItem.IsVisible = False
        End Try

        Return navItem
    End Function

    Private Function IsNodeAccessible(node As SiteMapNode) As Boolean
        Try
            ' Check if user is authenticated
            If Not HttpContext.Current.User.Identity.IsAuthenticated Then
                Return False
            End If

            ' Check roles
            If node.Roles IsNot Nothing AndAlso node.Roles.Count > 0 Then
                For Each role As String In node.Roles
                    If role = "*" OrElse HttpContext.Current.User.IsInRole(role.Trim()) Then
                        Return True
                    End If
                Next
                Return False
            End If

            ' Default to accessible if no specific roles defined
            Return True

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error checking node accessibility: " & ex.Message)
            Return False
        End Try
    End Function

    Private Function CleanMenuTitle(title As String) As String
        If String.IsNullOrEmpty(title) Then Return ""
        
        ' Remove common prefixes/suffixes
        title = title.Replace("View ", "").Replace("Edit ", "").Replace("Add ", "")
        title = title.Replace(" View", "").Replace(" Edit", "").Replace(" Add", "")
        
        ' Clean up numbering
        title = System.Text.RegularExpressions.Regex.Replace(title, "\s+\d+$", "")
        title = System.Text.RegularExpressions.Regex.Replace(title, "^\d+\s+", "")
        
        Return title.Trim()
    End Function

    Private Function GetTranslatedTitle(title As String) As String
        Try
            ' Integration with existing translation system
            ' This would connect to your existing translation logic
            Return title ' Placeholder for now
        Catch ex As Exception
            Return title
        End Try
    End Function

    Private Function GetIconForNode(node As SiteMapNode) As String
        Dim title = node.Title.ToLower()
        
        ' Icon mapping based on title/category
        If title.Contains("dashboard") OrElse title.Contains("home") Then Return "fas fa-home"
        If title.Contains("account") OrElse title.Contains("gl") Then Return "fas fa-calculator"
        If title.Contains("stock") OrElse title.Contains("inventory") Then Return "fas fa-boxes"
        If title.Contains("report") Then Return "fas fa-file-alt"
        If title.Contains("user") OrElse title.Contains("security") Then Return "fas fa-users"
        If title.Contains("setting") OrElse title.Contains("config") Then Return "fas fa-cogs"
        If title.Contains("customer") OrElse title.Contains("crm") Then Return "fas fa-user-friends"
        If title.Contains("supplier") OrElse title.Contains("purchase") Then Return "fas fa-truck"
        If title.Contains("sale") OrElse title.Contains("invoice") Then Return "fas fa-receipt"
        If title.Contains("hr") OrElse title.Contains("employee") Then Return "fas fa-user-tie"
        If title.Contains("finance") OrElse title.Contains("payment") Then Return "fas fa-money-bill"
        
        ' Default icon
        Return "fas fa-folder"
    End Function

    Private Function GetNodeSortOrder(node As SiteMapNode) As Integer
        ' Extract sort order from attributes or use default ordering
        Dim order As String = node("sortOrder")
        If Not String.IsNullOrEmpty(order) Then
            Dim result As Integer
            If Integer.TryParse(order, result) Then
                Return result
            End If
        End If
        
        ' Default ordering based on title
        Dim title = node.Title.ToLower()
        If title.Contains("dashboard") OrElse title.Contains("home") Then Return 1
        If title.Contains("account") OrElse title.Contains("gl") Then Return 2
        If title.Contains("stock") Then Return 3
        If title.Contains("sale") Then Return 4
        If title.Contains("purchase") Then Return 5
        If title.Contains("hr") Then Return 6
        If title.Contains("report") Then Return 7
        If title.Contains("setting") Then Return 8
        
        Return 100 ' Default for others
    End Function

    Private Sub LoadUserInformation()
        Try
            Dim userInfo As New UserInfo()

            If HttpContext.Current.User.Identity.IsAuthenticated Then
                userInfo.Username = HttpContext.Current.User.Identity.Name
                userInfo.DisplayName = GetUserDisplayName()
                userInfo.Role = GetUserPrimaryRole()
                userInfo.Avatar = GetUserAvatar()
                userInfo.IsAuthenticated = True
                userInfo.Permissions = GetUserPermissions()
            Else
                userInfo.Username = "Guest"
                userInfo.DisplayName = "ضيف"
                userInfo.Role = "Guest"
                userInfo.IsAuthenticated = False
                userInfo.Permissions = New String() {}
            End If

            Dim js As New JavaScriptSerializer()
            js.MaxJsonLength = Integer.MaxValue
            Dim jsonData As String = js.Serialize(userInfo)
            hdnUserInfo.Value = jsonData

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error loading user information: " & ex.Message)
            hdnUserInfo.Value = "{""username"":""Guest"",""isAuthenticated"":false}"
        End Try
    End Sub

    Private Function GetUserDisplayName() As String
        Try
            ' Get display name from user profile or membership
            Dim user = Membership.GetUser()
            If user IsNot Nothing Then
                Return user.UserName
            End If
            Return HttpContext.Current.User.Identity.Name
        Catch ex As Exception
            Return HttpContext.Current.User.Identity.Name
        End Try
    End Function

    Private Function GetUserPrimaryRole() As String
        Try
            ' Get the primary role for the user
            Dim roles As String() = System.Web.Security.Roles.GetRolesForUser()
            If roles.Length > 0 Then
                Return roles(0)
            End If
            Return "User"
        Catch ex As Exception
            Return "User"
        End Try
    End Function

    Private Function GetUserAvatar() As String
        ' Return default or user-specific avatar
        Return "fas fa-user-circle"
    End Function

    Private Function GetUserPermissions() As String()
        Try
            ' Get user permissions from roles
            Return Roles.GetRolesForUser()
        Catch ex As Exception
            Return {}
        End Try
    End Function

    Private Sub SetCurrentPageInfo()
        Try
            Dim currentPath = HttpContext.Current.Request.AppRelativeCurrentExecutionFilePath
            Dim pageName = IO.Path.GetFileNameWithoutExtension(currentPath)

            ' Build breadcrumbs from sitemap
            Dim breadcrumbs As New List(Of Object)()
            Dim n As SiteMapNode = SiteMap.CurrentNode
            While n IsNot Nothing
                breadcrumbs.Insert(0, New With { .title = n.Title, .url = n.Url })
                n = n.ParentNode
            End While

            Dim js As New JavaScriptSerializer()

            ' Find matching sitemap node
            Dim currentNode = SiteMap.CurrentNode
            If currentNode IsNot Nothing Then
                hdnCurrentPage.Value = js.Serialize(New With {
                    .path = currentPath,
                    .title = currentNode.Title,
                    .description = currentNode.Description,
                    .breadcrumbs = breadcrumbs
                })
            Else
                hdnCurrentPage.Value = js.Serialize(New With {
                    .path = currentPath,
                    .title = pageName,
                    .description = "",
                    .breadcrumbs = breadcrumbs
                })
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error setting current page info: " & ex.Message)
            hdnCurrentPage.Value = "{""title"":""الصفحة الحالية""}"
        End Try
    End Sub

    Private Sub LoadFallbackData()
        ' Provide basic fallback data in case of errors
        hdnMenuData.Value = "[{""title"":""الرئيسية"",""url"":""~/Default.aspx"",""icon"":""fas fa-home""}]"
        hdnUserInfo.Value = "{""username"":""Guest"",""isAuthenticated"":false}"
        hdnCurrentPage.Value = "{""title"":""النظام""}"
    End Sub

    Private Sub LoadFallbackMenuData()
        ' Basic fallback menu structure
        Dim fallbackMenu = New List(Of NavigationItem) From {
            New NavigationItem With {
                .Id = "home",
                .Title = "الرئيسية",
                .Url = "~/Default.aspx",
                .Icon = "fas fa-home",
                .IsVisible = True,
                .HasChildren = False
            },
            New NavigationItem With {
                .Id = "dashboard",
                .Title = "لوحة التحكم",
                .Url = "~/Pages/Dashboard.aspx",
                .Icon = "fas fa-chart-pie",
                .IsVisible = True,
                .HasChildren = False
            }
        }

        Dim js As New JavaScriptSerializer()
        hdnMenuData.Value = js.Serialize(fallbackMenu)
    End Sub

    Protected Sub Page_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        ' Register required JavaScript and CSS
        RegisterRequiredResources()
    End Sub

    Private Sub RegisterRequiredResources()
        Try
            ' Register CSS
            Dim cssLink As New HtmlLink()
            cssLink.Href = ResolveUrl("~/css/universal-hamburger-menu.css")
            cssLink.Attributes("rel") = "stylesheet"
            cssLink.Attributes("type") = "text/css"
            Page.Header.Controls.Add(cssLink)

            ' Ensure Vue is available
            Dim vueScript As New HtmlGenericControl("script")
            vueScript.Attributes("type") = "text/javascript"
            vueScript.Attributes("src") = ResolveUrl("~/js/vue.global.prod.js")
            Page.Header.Controls.Add(vueScript)

            ' Register JavaScript
            Dim scriptManager As ScriptManager = ScriptManager.GetCurrent(Page)
            If scriptManager IsNot Nothing Then
                scriptManager.Scripts.Add(New ScriptReference("~/js/navigation-vue-components.js"))
            Else
                ' Fallback if no ScriptManager
                Page.ClientScript.RegisterClientScriptInclude("NavigationVueComponents", ResolveUrl("~/js/navigation-vue-components.js"))
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error registering resources: " & ex.Message)
        End Try
    End Sub

End Class
