Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Class MenuDemo
    Inherits System.Web.UI.Page

    Private _menuBuilder As AdvancedMenuBuilder

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            InitializeDemo()
        End If
        UpdateMenuDisplay()
    End Sub

    Private Sub InitializeDemo()
        ' Set default values
        chkShowIcons.Checked = True
        chkEnableDropdowns.Checked = True
        chkTranslateTitles.Checked = True
        chkUseSecurity.Checked = True
        ddlMaxDepth.SelectedValue = "4"
        ddlTheme.SelectedValue = "default"
    End Sub

    Protected Sub btnUpdateMenu_Click(sender As Object, e As EventArgs)
        UpdateMenuDisplay()
    End Sub

    Protected Sub btnResetConfig_Click(sender As Object, e As EventArgs)
        InitializeDemo()
        UpdateMenuDisplay()
    End Sub

    Protected Sub btnExportConfig_Click(sender As Object, e As EventArgs)
        Try
            Dim config = GetCurrentConfiguration()
            Dim configJson = Newtonsoft.Json.JsonConvert.SerializeObject(config, Newtonsoft.Json.Formatting.Indented)
            
            Response.Clear()
            Response.ContentType = "application/json"
            Response.AddHeader("Content-Disposition", "attachment; filename=menu-config.json")
            Response.Write(configJson)
            Response.End()
        Catch ex As Exception
            ' Handle error
            ClientScript.RegisterStartupScript(Me.GetType(), "error", "alert('Error exporting configuration: " & ex.Message & "');", True)
        End Try
    End Sub

    Private Sub UpdateMenuDisplay()
        Try
            ' Create menu builder with current configuration
            Dim config = GetCurrentConfiguration()
            _menuBuilder = New AdvancedMenuBuilder(config)
            
            ' Add custom icons based on theme
            AddThemeSpecificIcons()
            
            ' Generate navigation for top of page
            litNavigationDemo.Text = _menuBuilder.GenerateMenuHtml()
            
            ' Generate preview (static version)
            litMenuPreview.Text = GenerateMenuPreview()
            
            ' Generate JSON data
            litMenuJson.Text = _menuBuilder.GenerateMenuJson()
            
        Catch ex As Exception
            litNavigationDemo.Text = "<div class='error'>Error generating menu: " & ex.Message & "</div>"
            litMenuPreview.Text = "<div class='error'>Error: " & ex.Message & "</div>"
            litMenuJson.Text = "{""error"": """ & ex.Message & """}"
        End Try
    End Sub

    Private Function GetCurrentConfiguration() As AdvancedMenuBuilder.MenuConfiguration
        Dim config As New AdvancedMenuBuilder.MenuConfiguration
        
        ' Basic options
        config.ShowIcons = chkShowIcons.Checked
        config.EnableDropdowns = chkEnableDropdowns.Checked
        config.TranslateMenuTitles = chkTranslateTitles.Checked
        config.UseRoleBasedSecurity = chkUseSecurity.Checked
        config.MaxDepthLevel = Integer.Parse(ddlMaxDepth.SelectedValue)
        
        ' CSS classes based on theme
        config.CssClasses = GetThemeCssClasses(ddlTheme.SelectedValue)
        
        ' Custom icon mapping
        config.CustomIconMapping = AdvancedMenuBuilder.GetDefaultIconMapping()
        
        Return config
    End Function

    Private Function GetThemeCssClasses(theme As String) As AdvancedMenuBuilder.MenuCssClasses
        Dim cssClasses As New AdvancedMenuBuilder.MenuCssClasses
        
        Select Case theme.ToLower()
            Case "dark"
                cssClasses = New AdvancedMenuBuilder.MenuCssClasses With {
                    .NavWrapper = "modern-nav-wrapper dark-theme",
                    .NavContainer = "nav-container",
                    .NavBrand = "nav-brand",
                    .NavMenu = "nav-menu",
                    .NavItem = "nav-item",
                    .NavLink = "nav-link dark",
                    .NavDropdown = "nav-dropdown dark",
                    .NavDropdownItem = "nav-dropdown-item dark",
                    .NavToggle = "nav-toggle",
                    .ActiveClass = "active",
                    .HasChildrenClass = "has-children"
                }
                
            Case "light"
                cssClasses = New AdvancedMenuBuilder.MenuCssClasses With {
                    .NavWrapper = "modern-nav-wrapper light-theme",
                    .NavContainer = "nav-container",
                    .NavBrand = "nav-brand",
                    .NavMenu = "nav-menu",
                    .NavItem = "nav-item",
                    .NavLink = "nav-link light",
                    .NavDropdown = "nav-dropdown light",
                    .NavDropdownItem = "nav-dropdown-item light",
                    .NavToggle = "nav-toggle",
                    .ActiveClass = "active",
                    .HasChildrenClass = "has-children"
                }
                
            Case "corporate"
                cssClasses = New AdvancedMenuBuilder.MenuCssClasses With {
                    .NavWrapper = "modern-nav-wrapper corporate-theme",
                    .NavContainer = "nav-container",
                    .NavBrand = "nav-brand",
                    .NavMenu = "nav-menu",
                    .NavItem = "nav-item",
                    .NavLink = "nav-link corporate",
                    .NavDropdown = "nav-dropdown corporate",
                    .NavDropdownItem = "nav-dropdown-item corporate",
                    .NavToggle = "nav-toggle",
                    .ActiveClass = "active",
                    .HasChildrenClass = "has-children"
                }
                
            Case Else ' default
                cssClasses = AdvancedMenuBuilder.GetDefaultConfiguration().CssClasses
        End Select
        
        Return cssClasses
    End Function

    Private Sub AddThemeSpecificIcons()
        If _menuBuilder Is Nothing Then Return
        
        Select Case ddlTheme.SelectedValue.ToLower()
            Case "dark"
                _menuBuilder.AddCustomIcon("Home", "fas fa-home-lg-alt")
                _menuBuilder.AddCustomIcon("Membership", "fas fa-users-crown")
                
            Case "corporate"
                _menuBuilder.AddCustomIcon("Home", "fas fa-building")
                _menuBuilder.AddCustomIcon("Membership", "fas fa-user-tie")
                _menuBuilder.AddCustomIcon("memo", "fas fa-file-contract")
                
            Case Else
                ' Use defaults
        End Select
    End Sub

    Private Function GenerateMenuPreview() As String
        If _menuBuilder Is Nothing Then Return ""
        
        Try
            ' Get menu data
            Dim menuData = _menuBuilder.GetMenuData()
            
            ' Generate a simplified HTML preview
            Dim preview As New System.Text.StringBuilder()
            preview.AppendLine("<div class='menu-preview-tree'>")
            
            For Each item In menuData
                preview.AppendLine(GeneratePreviewItem(item, 0))
            Next
            
            preview.AppendLine("</div>")
            
            ' Add some basic styling for the preview
            preview.Insert(0, "<style>" & vbCrLf & _
                "    .menu-preview-tree { font-family: monospace; }" & vbCrLf & _
                "    .preview-item { margin: 5px 0; }" & vbCrLf & _
                "    .preview-indent { margin-left: 20px; }" & vbCrLf & _
                "    .preview-icon { color: #2563eb; margin-right: 5px; }" & vbCrLf & _
                "    .preview-title { font-weight: bold; }" & vbCrLf & _
                "    .preview-url { color: #666; font-size: 0.9em; }" & vbCrLf & _
                "    .preview-roles { color: #f59e0b; font-size: 0.8em; }" & vbCrLf & _
                "</style>")
            
            Return preview.ToString()
            
        Catch ex As Exception
            Return "<div class='error'>Preview Error: " & ex.Message & "</div>"
        End Try
    End Function

    Private Function GeneratePreviewItem(item As AdvancedMenuBuilder.MenuItemData, level As Integer) As String
        Dim html As New System.Text.StringBuilder()
        Dim indent = String.Join("", Enumerable.Repeat("&nbsp;&nbsp;&nbsp;&nbsp;", level))
        
        html.AppendLine("<div class='preview-item'>")
        html.AppendLine("  " & indent & "<span class='preview-icon'>" & item.Icon & "</span>")
        html.AppendLine("  <span class='preview-title'>" & HttpUtility.HtmlEncode(item.TranslatedTitle) & "</span>")
        html.AppendLine("  <span class='preview-url'>(" & item.Url & ")</span>")
        
        If item.Roles IsNot Nothing AndAlso item.Roles.Length > 0 Then
            html.AppendLine("  <span class='preview-roles'>[" & String.Join(", ", item.Roles) & "]</span>")
        End If
        
        html.AppendLine("</div>")
        
        ' Add children
        For Each child In item.Children
            html.AppendLine(GeneratePreviewItem(child, level + 1))
        Next
        
        Return html.ToString()
    End Function
End Class
