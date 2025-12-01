Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Text
Imports System.Security.Principal
Imports System.Web.Security

''' <summary>
''' Advanced Menu Builder for SKY ERP System
''' Provides full control over menu HTML generation while maintaining security and sitemap integration
''' </summary>
Public Class AdvancedMenuBuilder

    Public Structure MenuConfiguration
        Public ShowIcons As Boolean
        Public EnableDropdowns As Boolean
        Public UseRoleBasedSecurity As Boolean
        Public TranslateMenuTitles As Boolean
        Public MaxDepthLevel As Integer
        Public CssClasses As MenuCssClasses
        Public CustomIconMapping As Dictionary(Of String, String)
    End Structure

    Public Structure MenuCssClasses
        Public NavWrapper As String
        Public NavContainer As String
        Public NavBrand As String
        Public NavMenu As String
        Public NavItem As String
        Public NavLink As String
        Public NavDropdown As String
        Public NavDropdownItem As String
        Public NavToggle As String
        Public ActiveClass As String
        Public HasChildrenClass As String
    End Structure

    Public Structure MenuItemData
        Public Title As String
        Public TranslatedTitle As String
        Public Url As String
        Public Description As String
        Public Icon As String
        Public CssClass As String
        Public Roles As String()
        Public HasChildren As Boolean
        Public Children As List(Of MenuItemData)
        Public Level As Integer
        Public IsVisible As Boolean
        Public IsAccessible As Boolean
    End Structure

    Private _config As MenuConfiguration
    Private _siteMapProvider As SiteMapProvider
    Private _currentUser As IPrincipal

    Public Sub New(Optional config As MenuConfiguration? = Nothing)
        Try
            _config = If(config, GetDefaultConfiguration())
            _siteMapProvider = SiteMap.Provider
            _currentUser = HttpContext.Current.User
            
            ' Ensure CustomIconMapping is initialized
            If _config.CustomIconMapping Is Nothing Then
                _config.CustomIconMapping = GetDefaultIconMapping()
            End If
        Catch ex As Exception
            ' Fallback to minimal configuration
            _config = GetDefaultConfiguration()
            System.Diagnostics.Debug.WriteLine("Error initializing AdvancedMenuBuilder: " & ex.Message)
        End Try
    End Sub

    Public Shared Function GetDefaultConfiguration() As MenuConfiguration
        Return New MenuConfiguration With {
            .ShowIcons = True,
            .EnableDropdowns = True,
            .UseRoleBasedSecurity = True,
            .TranslateMenuTitles = True,
            .MaxDepthLevel = 3,
            .CssClasses = New MenuCssClasses With {
                .NavWrapper = "modern-nav-wrapper",
                .NavContainer = "nav-container",
                .NavBrand = "nav-brand",
                .NavMenu = "nav-menu",
                .NavItem = "nav-item",
                .NavLink = "nav-link",
                .NavDropdown = "nav-dropdown",
                .NavDropdownItem = "nav-dropdown-item",
                .NavToggle = "nav-toggle",
                .ActiveClass = "active",
                .HasChildrenClass = "has-children"
            },
            .CustomIconMapping = GetDefaultIconMapping()
        }
    End Function

    Public Shared Function GetDefaultIconMapping() As Dictionary(Of String, String)
        Return New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
            {"Home", "fas fa-home"},
            {"HomePage", "fas fa-home"},
            {"SiteHome", "fas fa-home"},
            {"Membership", "fas fa-users"},
            {"Member", "fas fa-user"},
            {"Users", "fas fa-users-cog"},
            {"memo", "fas fa-sticky-note"},
            {"Message", "fas fa-envelope"},
            {"ALLMessage", "fas fa-envelope-open"},
            {"Category", "fas fa-tags"},
            {"Tools", "fas fa-tools"},
            {"Settings", "fas fa-cog"},
            {"Administration", "fas fa-user-shield"},
            {"Security", "fas fa-shield-alt"},
            {"Reports", "fas fa-chart-bar"},
            {"Profile", "fas fa-user-circle"},
            {"Help", "fas fa-question-circle"},
            {"Desk", "fas fa-headset"},
            {"Ticket", "fas fa-ticket-alt"},
            {"Attachment", "fas fa-paperclip"},
            {"Comment", "fas fa-comment"},
            {"Event", "fas fa-bell"},
            {"Notification", "fas fa-bell-o"},
            {"Tag", "fas fa-tag"},
            {"Details", "fas fa-info-circle"},
            {"Log", "fas fa-history"},
            {"Role", "fas fa-user-tag"},
            {"Application", "fas fa-desktop"},
            {"System", "fas fa-server"},
            {"Translation", "fas fa-language"},
            {"Other", "fas fa-ellipsis-h"},
            {"ToDo", "fas fa-tasks"},
            {"Priority", "fas fa-flag"},
            {"Site", "fas fa-globe"},
            {"Content", "fas fa-file-alt"},
            {"Contact", "fas fa-address-book"}
        }
    End Function

    ''' <summary>
    ''' Generates the complete navigation menu HTML
    ''' </summary>
    Public Function GenerateMenuHtml() As String
        Dim menuData = BuildMenuData()
        Return GenerateHtmlFromData(menuData)
    End Function

    ''' <summary>
    ''' Builds the menu data structure from sitemap with security filtering
    ''' </summary>
    Private Function BuildMenuData() As List(Of MenuItemData)
        Dim menuItems As New List(Of MenuItemData)

        Try
            If _siteMapProvider Is Nothing OrElse _siteMapProvider.RootNode Is Nothing Then
                Return menuItems
            End If

            ' Process root node children
            For Each childNode As SiteMapNode In _siteMapProvider.RootNode.ChildNodes
                Try
                    Dim menuItem = ProcessSiteMapNode(childNode, 0)
                    If menuItem.IsVisible Then
                        menuItems.Add(menuItem)
                    End If
                Catch nodeEx As Exception
                    ' Log the error but continue processing other nodes
                    System.Diagnostics.Debug.WriteLine("Error processing node " & childNode.Title & ": " & nodeEx.Message)
                End Try
            Next

        Catch ex As Exception
            ' Log the error
            System.Diagnostics.Debug.WriteLine("Error building menu data: " & ex.Message)
        End Try

        Return menuItems
    End Function

    ''' <summary>
    ''' Processes a single sitemap node and its children with enhanced translation and security
    ''' </summary>
    Private Function ProcessSiteMapNode(node As SiteMapNode, level As Integer) As MenuItemData
        Dim menuItem As New MenuItemData With {
            .Title = CleanTitle(node.Title),
            .Url = If(String.IsNullOrEmpty(node.Url), "#", ResolveUrl(node.Url)),
            .Description = node.Description,
            .Level = level,
            .Children = New List(Of MenuItemData),
            .CssClass = node("cssClass")
        }

        ' ⚠️ IMPORTANT: Level 3 only - stop processing beyond level 2 (0,1,2 = 3 levels)
        ' The user emphasized this multiple times - it's not just a max number!
        If level > 2 Then
            menuItem.IsVisible = False
            menuItem.IsAccessible = False
            Return menuItem
        End If

        ' Enhanced translation using the existing system
        menuItem.TranslatedTitle = If(_config.TranslateMenuTitles, 
            GetTranslatedTitle(menuItem.Title), menuItem.Title)

        ' Parse roles with enhanced security
        menuItem.Roles = ParseRolesEnhanced(node.Roles)

        ' Enhanced security check
        menuItem.IsAccessible = CheckAccessEnhanced(menuItem.Roles, menuItem.Title)
        menuItem.IsVisible = menuItem.IsAccessible AndAlso level <= 2  ' Support 3 levels (0, 1, 2)

        ' Enhanced icon mapping
        menuItem.Icon = GetIconForMenuItem(menuItem.Title)

        ' Process children ONLY if within 3-level limit (level < 2 allows levels 0, 1, 2)
        If node.HasChildNodes AndAlso level < 2 AndAlso menuItem.IsAccessible Then
            For Each childNode As SiteMapNode In node.ChildNodes
                Dim childItem = ProcessSiteMapNode(childNode, level + 1)
                If childItem.IsVisible Then
                    menuItem.Children.Add(childItem)
                End If
            Next
        End If

        menuItem.HasChildren = menuItem.Children.Count > 0

        Return menuItem
    End Function

    ''' <summary>
    ''' Enhanced translation using the existing translatemeyamosso system
    ''' </summary>
    Private Function GetTranslatedTitle(title As String) As String
        Try
            ' Use the existing translation system from the RadMenu
            Return translatemeyamosso.GetResourceValuemosso(title)
        Catch ex As Exception
            ' Fallback to original title on error
            Return title
        End Try
    End Function

    ''' <summary>
    ''' Enhanced role parsing with better error handling
    ''' </summary>
    Private Function ParseRolesEnhanced(rolesString As IList) As String()
        Try
            If rolesString Is Nothing Then Return New String() {}
            
            Dim roles As New List(Of String)
            For Each role In rolesString
                If Not String.IsNullOrEmpty(role.ToString()) Then
                    roles.AddRange(role.ToString().Split(","c).Select(Function(r) r.Trim()).Where(Function(r) Not String.IsNullOrEmpty(r)))
                End If
            Next
            
            Return roles.ToArray()
        Catch ex As Exception
            ' Return empty array on error - default to public access
            Return New String() {}
        End Try
    End Function

    ''' <summary>
    ''' Enhanced access control matching the original RadMenu security logic
    ''' </summary>
    Private Function CheckAccessEnhanced(roles As String(), title As String) As Boolean
        Try
            If Not _config.UseRoleBasedSecurity OrElse _currentUser Is Nothing Then
                Return True
            End If

            ' No roles specified = public access
            If roles Is Nothing OrElse roles.Length = 0 Then
                Return True
            End If

            ' Check for wildcard access
            If roles.Contains("*") Then
                Return True
            End If

            ' Check user roles
            For Each role In roles
                If _currentUser.IsInRole(role.Trim()) Then
                    Return True
                End If
            Next

            ' Enhanced security rules based on menu title (like the original RadMenu system)
            Select Case title.ToLower().Trim()
                Case "membership", "members", "users", "security"
                    Return _currentUser.IsInRole("Administrator") OrElse _currentUser.IsInRole("Security") OrElse _currentUser.IsInRole("UserManager")
                Case "reports", "report"
                    Return _currentUser.IsInRole("Administrator") OrElse _currentUser.IsInRole("Reports") OrElse _currentUser.IsInRole("Manager") OrElse _currentUser.IsInRole("Viewer")
                Case "settings", "administration", "admin"
                    Return _currentUser.IsInRole("Administrator") OrElse _currentUser.IsInRole("SystemAdmin")
                Case "tools", "elmah", "logs"
                    Return _currentUser.IsInRole("Administrator") OrElse _currentUser.IsInRole("Developer")
                Case "helpdesk", "help desk", "tickets"
                    Return _currentUser.IsInRole("Administrator") OrElse _currentUser.IsInRole("Support") OrElse _currentUser.IsInRole("HelpDesk")
                Case "profile", "my site"
                    Return True ' These are typically user-specific and should be accessible
                Case Else
                    ' For unspecified items, default to allowing access if user is authenticated
                    Return _currentUser.Identity.IsAuthenticated
            End Select

        Catch ex As Exception
            ' On error, be conservative but don't break the menu
            System.Diagnostics.Debug.WriteLine("Enhanced access check error: " & ex.Message)
            Return _currentUser IsNot Nothing AndAlso _currentUser.Identity.IsAuthenticated
        End Try

        Return False
    End Function

    ''' <summary>
    ''' Generates HTML from menu data structure
    ''' </summary>
    Private Function GenerateHtmlFromData(menuItems As List(Of MenuItemData)) As String
        Dim html As New StringBuilder()

        html.AppendLine("<div class=""" & _config.CssClasses.NavWrapper & """>")
        html.AppendLine("    <nav class=""modern-navbar"">")
        html.AppendLine("        <div class=""" & _config.CssClasses.NavContainer & """>")
        
        ' Brand/Logo
        html.AppendLine(GenerateBrandHtml())
        
        ' Mobile toggle
        html.AppendLine(GenerateToggleHtml())
        
        ' Main menu
        html.AppendLine("            <ul class=""" & _config.CssClasses.NavMenu & """ id=""navMenu"">")
        
        For Each item In menuItems
            html.AppendLine(GenerateMenuItemHtml(item))
        Next
        
        html.AppendLine("            </ul>")
        html.AppendLine("        </div>")
        html.AppendLine("    </nav>")
        html.AppendLine("</div>")

        Return html.ToString()
    End Function

    ''' <summary>
    ''' Generates HTML for a single menu item
    ''' </summary>
    Private Function GenerateMenuItemHtml(item As MenuItemData) As String
        Dim html As New StringBuilder()
        Dim cssClasses As New List(Of String) From {_config.CssClasses.NavItem}
        
        If item.HasChildren AndAlso _config.EnableDropdowns Then
            cssClasses.Add(_config.CssClasses.HasChildrenClass)
        End If

        If IsCurrentPage(item.Url) Then
            cssClasses.Add(_config.CssClasses.ActiveClass)
        End If

        html.AppendLine("                <li class=""" & String.Join(" ", cssClasses) & """>")
        
        ' Main link
        Dim linkClasses = _config.CssClasses.NavLink
        If IsCurrentPage(item.Url) Then
            linkClasses &= " " & _config.CssClasses.ActiveClass
        End If

        html.AppendLine("                    <a href=""" & item.Url & """ class=""" & linkClasses & """ title=""" & item.Description & """>")
        
        If _config.ShowIcons AndAlso Not String.IsNullOrEmpty(item.Icon) Then
            html.AppendLine("                        <i class=""" & item.Icon & """></i>")
        End If
        
        html.AppendLine("                        <span>" & HttpUtility.HtmlEncode(item.TranslatedTitle) & "</span>")
        
        If item.HasChildren AndAlso _config.EnableDropdowns Then
            html.AppendLine("                        <i class=""fas fa-chevron-down""></i>")
        End If
        
        html.AppendLine("                    </a>")
        
        ' Dropdown menu
        If item.HasChildren AndAlso _config.EnableDropdowns Then
            html.AppendLine("                    <div class=""" & _config.CssClasses.NavDropdown & """>")
            
            For Each child In item.Children
                html.AppendLine(GenerateDropdownItemHtml(child))
            Next
            
            html.AppendLine("                    </div>")
        End If
        
        html.AppendLine("                </li>")

        Return html.ToString()
    End Function

    ''' <summary>
    ''' Generates HTML for dropdown items
    ''' </summary>
    Private Function GenerateDropdownItemHtml(item As MenuItemData) As String
        Dim html As New StringBuilder()
        Dim cssClasses = _config.CssClasses.NavDropdownItem
        
        If IsCurrentPage(item.Url) Then
            cssClasses &= " " & _config.CssClasses.ActiveClass
        End If

        html.AppendLine("                        <a href=""" & item.Url & """ class=""" & cssClasses & """ title=""" & item.Description & """>")
        
        If _config.ShowIcons AndAlso Not String.IsNullOrEmpty(item.Icon) Then
            html.AppendLine("                            <i class=""" & item.Icon & """></i>")
        End If
        
        html.AppendLine("                            " & HttpUtility.HtmlEncode(item.TranslatedTitle))
        html.AppendLine("                        </a>")

        Return html.ToString()
    End Function

    ''' <summary>
    ''' Generates grouped children HTML for large menus
    ''' </summary>
    Private Function GenerateGroupedChildrenHtml(children As List(Of MenuItemData)) As String
        Dim html As New StringBuilder()
        Dim itemsPerColumn = Math.Ceiling(children.Count / 3.0) ' 3 columns max
        Dim currentColumn = 0
        Dim currentItem = 0
        
        html.AppendLine("                                <div class=""dropdown-columns"">")
        
        For i = 0 To 2 ' Max 3 columns
            If currentItem >= children.Count Then Exit For
            
            html.AppendLine("                                    <div class=""dropdown-column"">")
            
            Dim itemsInThisColumn = Math.Min(itemsPerColumn, children.Count - currentItem)
            For j = 0 To itemsInThisColumn - 1
                If currentItem < children.Count Then
                    html.AppendLine(GenerateDropdownItemHtml(children(currentItem)))
                    currentItem += 1
                End If
            Next
            
            html.AppendLine("                                    </div>")
        Next
        
        html.AppendLine("                                </div>")
        
        Return html.ToString()
    End Function

    ''' <summary>
    ''' Generates brand/logo HTML
    ''' </summary>
    Private Function GenerateBrandHtml() As String
        Return "            <a href=""" & ResolveUrl("~/Default.aspx") & """ class=""" & _config.CssClasses.NavBrand & """>" & vbCrLf & _
               "                <img src=""/favicon.png"" alt=""Logo"" />" & vbCrLf & _
               "                <span>SKY ERP</span>" & vbCrLf & _
               "            </a>"
    End Function

    ''' <summary>
    ''' Generates mobile toggle button HTML
    ''' </summary>
    Private Function GenerateToggleHtml() As String
        Return "            <button class=""" & _config.CssClasses.NavToggle & """ onclick=""toggleNavMenu()"">" & vbCrLf & _
               "                <i class=""fas fa-bars""></i>" & vbCrLf & _
               "            </button>"
    End Function

    ''' <summary>
    ''' Utility methods
    ''' </summary>
    Private Function CleanTitle(title As String) As String
        If String.IsNullOrEmpty(title) Then Return ""
        
        ' Remove translation markers
        title = System.Text.RegularExpressions.Regex.Replace(title, "\^[^)]*\^", "")
        Return title.Trim()
    End Function

    Private Function TranslateTitle(title As String) As String
        Try
            ' Use your existing translation method
            Return translatemeyamosso.GetResourceValuemosso(title)
        Catch
            Return title
        End Try
    End Function

    Private Function ParseRoles(rolesString As IList) As String()
        If rolesString Is Nothing Then Return New String() {}
        
        Dim roles As New List(Of String)
        For Each role In rolesString
            If Not String.IsNullOrEmpty(role.ToString()) Then
                roles.AddRange(role.ToString().Split(","c).Select(Function(r) r.Trim()))
            End If
        Next
        
        Return roles.ToArray()
    End Function

    Private Function CheckAccess(roles As String()) As Boolean
        If Not _config.UseRoleBasedSecurity OrElse _currentUser Is Nothing Then
            Return True
        End If

        If roles Is Nothing OrElse roles.Length = 0 Then
            Return True
        End If

        ' Check for wildcard
        If roles.Contains("*") Then
            Return True
        End If

        ' Check user roles
        For Each role In roles
            If _currentUser.IsInRole(role) Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Function GetIconForMenuItem(title As String) As String
        If Not _config.ShowIcons Then Return ""

        ' Check custom mapping first
        If _config.CustomIconMapping.ContainsKey(title) Then
            Return _config.CustomIconMapping(title)
        End If

        ' Enhanced icon mapping system
        If String.IsNullOrEmpty(title) Then Return "fas fa-circle"

        Dim cleanTitle = title.ToLower().Trim()

        ' ⚡ Core System Icons
        Select Case cleanTitle
            Case "home", "main", "dashboard", "default"
                Return "fas fa-home"
            Case "orders", "order", "purchase order", "sales order"
                Return "fas fa-shopping-cart"
            Case "customers", "customer", "clients", "client"
                Return "fas fa-users"
            Case "products", "product", "inventory", "items", "item"
                Return "fas fa-boxes"
            Case "suppliers", "supplier", "vendors", "vendor"
                Return "fas fa-truck"
            Case "employees", "employee", "staff", "personnel"
                Return "fas fa-id-badge"
            Case "accounting", "financial", "finance", "accounts"
                Return "fas fa-calculator"
            Case "reports", "report", "analytics", "analysis"
                Return "fas fa-chart-bar"
            Case "settings", "configuration", "config", "setup"
                Return "fas fa-cog"
            Case "profile", "my profile", "user profile"
                Return "fas fa-user"
            Case "logout", "sign out", "exit"
                Return "fas fa-sign-out-alt"
            Case "login", "sign in", "authentication"
                Return "fas fa-sign-in-alt"
                
            ' 📊 ERP Specific Icons
            Case "invoices", "invoice", "billing", "bills"
                Return "fas fa-file-invoice-dollar"
            Case "payments", "payment", "transactions"
                Return "fas fa-credit-card"
            Case "warehouse", "warehouses", "storage"
                Return "fas fa-warehouse"
            Case "shipping", "delivery", "dispatch"
                Return "fas fa-shipping-fast"
            Case "purchase", "purchasing", "procurement"
                Return "fas fa-shopping-bag"
            Case "sales", "selling", "revenue"
                Return "fas fa-chart-line"
            Case "contracts", "contract", "agreements"
                Return "fas fa-file-contract"
            Case "projects", "project", "tasks", "task"
                Return "fas fa-project-diagram"
            Case "calendar", "schedule", "appointments"
                Return "fas fa-calendar-alt"
            Case "documents", "document", "files", "file"
                Return "fas fa-folder-open"
                
            ' 🔧 Admin & Security Icons
            Case "administration", "admin", "management"
                Return "fas fa-tools"
            Case "security", "permissions", "roles", "access"
                Return "fas fa-shield-alt"
            Case "users", "user management", "accounts"
                Return "fas fa-users-cog"
            Case "backups", "backup", "restore"
                Return "fas fa-hdd"
            Case "logs", "audit", "history", "elmah"
                Return "fas fa-clipboard-list"
            Case "help", "support", "helpdesk", "help desk"
                Return "fas fa-question-circle"
            Case "notifications", "alerts", "messages"
                Return "fas fa-bell"
            Case "tools", "utilities", "maintenance"
                Return "fas fa-wrench"
                
            ' 📋 Data Management Icons
            Case "import", "upload", "data import"
                Return "fas fa-upload"
            Case "export", "download", "data export"
                Return "fas fa-download"
            Case "categories", "category", "classification"
                Return "fas fa-tags"
            Case "templates", "template", "forms"
                Return "fas fa-file-alt"
            Case "approval", "approvals", "workflow"
                Return "fas fa-check-circle"
            Case "search", "find", "lookup"
                Return "fas fa-search"
            Case "print", "printing", "printer"
                Return "fas fa-print"
            Case "email", "mail", "communications"
                Return "fas fa-envelope"
                
            ' 🏢 Business Process Icons
            Case "crm", "customer relationship"
                Return "fas fa-handshake"
            Case "hrm", "human resources", "hr"
                Return "fas fa-user-tie"
            Case "payroll", "salary", "wages"
                Return "fas fa-money-check-alt"
            Case "quality", "qc", "quality control"
                Return "fas fa-medal"
            Case "compliance", "regulations", "standards"
                Return "fas fa-balance-scale"
            Case "budgets", "budget", "planning"
                Return "fas fa-piggy-bank"
            Case "forecasting", "forecast", "predictions"
                Return "fas fa-chart-area"
            Case "kpi", "metrics", "performance"
                Return "fas fa-tachometer-alt"
                
            ' 🔄 Process Icons
            Case "workflow", "processes", "automation"
                Return "fas fa-sitemap"
            Case "integration", "api", "connections"
                Return "fas fa-plug"
            Case "synchronization", "sync", "update"
                Return "fas fa-sync-alt"
            Case "validation", "verify", "check"
                Return "fas fa-check-double"
            Case "conversion", "transform", "migrate"
                Return "fas fa-exchange-alt"
                
            ' Default fallback icons based on common patterns
            Case Else
                If cleanTitle.Contains("manage") OrElse cleanTitle.Contains("management") Then
                    Return "fas fa-tasks"
                ElseIf cleanTitle.Contains("create") OrElse cleanTitle.Contains("add") OrElse cleanTitle.Contains("new") Then
                    Return "fas fa-plus-circle"
                ElseIf cleanTitle.Contains("edit") OrElse cleanTitle.Contains("update") OrElse cleanTitle.Contains("modify") Then
                    Return "fas fa-edit"
                ElseIf cleanTitle.Contains("delete") OrElse cleanTitle.Contains("remove") Then
                    Return "fas fa-trash-alt"
                ElseIf cleanTitle.Contains("view") OrElse cleanTitle.Contains("display") OrElse cleanTitle.Contains("show") Then
                    Return "fas fa-eye"
                ElseIf cleanTitle.Contains("list") OrElse cleanTitle.Contains("browse") Then
                    Return "fas fa-list"
                ElseIf cleanTitle.Contains("master") OrElse cleanTitle.Contains("main") Then
                    Return "fas fa-database"
                ElseIf cleanTitle.Contains("detail") OrElse cleanTitle.Contains("info") Then
                    Return "fas fa-info-circle"
                Else
                    Return "fas fa-folder" ' Default fallback
                End If
        End Select
    End Function

    Private Function ResolveUrl(url As String) As String
        If String.IsNullOrEmpty(url) Then Return "#"
        
        If url.StartsWith("~/") Then
            Return VirtualPathUtility.ToAbsolute(url)
        End If
        
        Return url
    End Function

    Private Function IsCurrentPage(url As String) As Boolean
        If String.IsNullOrEmpty(url) OrElse url = "#" Then Return False
        
        Dim currentPath = HttpContext.Current.Request.Path
        Dim resolvedUrl = ResolveUrl(url)
        
        Return String.Equals(currentPath, resolvedUrl, StringComparison.OrdinalIgnoreCase)
    End Function

    ''' <summary>
    ''' Public methods for customization
    ''' </summary>
    Public Sub AddCustomIcon(title As String, iconClass As String)
        If _config.CustomIconMapping Is Nothing Then
            _config.CustomIconMapping = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        End If
        
        ' Check if key exists and update or add accordingly
        If _config.CustomIconMapping.ContainsKey(title) Then
            _config.CustomIconMapping(title) = iconClass
        Else
            _config.CustomIconMapping.Add(title, iconClass)
        End If
    End Sub

    Public Sub SetConfiguration(config As MenuConfiguration)
        _config = config
    End Sub

    Public Function GetMenuData() As List(Of MenuItemData)
        Return BuildMenuData()
    End Function

    ''' <summary>
    ''' Generate menu as JSON for JavaScript consumption
    ''' </summary>
    Public Function GenerateMenuJson() As String
        Dim menuData = BuildMenuData()
        ' Convert to JSON (you might want to use a JSON serializer here)
        Return Newtonsoft.Json.JsonConvert.SerializeObject(menuData)
    End Function

End Class
