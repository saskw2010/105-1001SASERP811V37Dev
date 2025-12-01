Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Net
Imports System.Configuration
Imports System.Xml
Imports System.IO
Imports eZee.Data
Imports translatemeyamosso

Partial Public Class Controls_TableOfContents
    Inherits Global.System.Web.UI.UserControl

    ' Static flag to prevent multiple instances from loading navigation data
    Private Shared navigationDataLoaded As Boolean = False
    Private Shared navigationDataLock As New Object()

    ' Modern navigation data structures
    Public Class NavigationItem
        Public Property Title As String
        Public Property Url As String
        Public Property Description As String
        Public Property Icon As String
        Public Property Level As Integer
        
        Public Sub New()
        End Sub
    End Class

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            Try
                ' Add instance identifier for debugging
                Dim instanceId As String = Me.ClientID
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "PageLoadStart_" & instanceId,
                    "console.log('🚀 TableOfContents Page_Load started - Instance: " & instanceId & " - IsPostBack: false');", True)

                ' Check if this is a duplicate instance
                SyncLock navigationDataLock
                    If navigationDataLoaded Then
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "DuplicateInstance_" & instanceId,
                            "console.warn('⚠️ Duplicate TableOfContents instance detected: " & instanceId & " - Skipping navigation data load');", True)
                        
                        ' Still do user tracking but skip navigation data loading
                        DoUserTracking()
                        Return
                    Else
                        navigationDataLoaded = True
                        ScriptManager.RegisterStartupScript(Me, GetType(Page), "FirstInstance_" & instanceId,
                            "console.log('✅ First TableOfContents instance: " & instanceId & " - Loading navigation data');", True)
                    End If
                End SyncLock

                ' Load user tracking data
                DoUserTracking()

                ' Load navigation data FIRST - This will populate the repeater
                LoadNavigationData()

                ' Load modern content AFTER navigation data is loaded
                LoadModernContent()
                ApplyConfigurationSettings()

                ScriptManager.RegisterStartupScript(Me, GetType(Page), "PageLoadComplete_" & instanceId,
                    "console.log('✅ TableOfContents Page_Load completed successfully - Instance: " & instanceId & "');", True)

            Catch ex As Exception
                ' Handle error gracefully
                Dim instanceId As String = Me.ClientID
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "PageLoadError_" & instanceId,
                    "console.error('❌ TableOfContents Page_Load error - Instance: " & instanceId & " - " & HttpUtility.JavaScriptStringEncode(ex.Message) & "');", True)

                litModernToc.Text = "<div class='error-message'>" &
                                  "<i class='fas fa-exclamation-triangle'></i>" &
                                  "<p>An error occurred while loading the page. Please try again later.</p>" &
                                  "<div class='error-details' style='display:none;'>" & HttpUtility.HtmlEncode(ex.ToString()) & "</div>" &
                                  "</div>"
                litModernToc.Visible = True
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Handle user tracking separately to avoid duplication
    ''' </summary>
    Private Sub DoUserTracking()
        Try
            Dim instanceId As String = Me.ClientID
            
            OnlineActiveUsers.OnlineUsersInstance.OnlineUsers.SetUserOnline(Page.User.Identity.Name)

            Dim workstationidstring As String = DataLogic.GetConnectionStringworkstation()
            Session.Add("workstationidstring", workstationidstring)
            Dim ixi As Integer = DataLogic.logintrack(Page.User.Identity.Name, DateTime.Now(), workstationidstring)

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "UserTracking_" & instanceId,
                "console.log('👤 User tracking completed for: " & HttpUtility.JavaScriptStringEncode(Page.User.Identity.Name) & " - Instance: " & instanceId & "');", True)

            ' Get IP Address
            Dim ipaddress As String = Request.ServerVariables("HTTP_X_FORWARDED_FOR")
            If String.IsNullOrEmpty(ipaddress) Then
                ipaddress = Request.ServerVariables("REMOTE_ADDR")
            End If
            Label3.Text = Label3.Text & "  ::  " & ipaddress

            ' Display IP address list
            Dim ipmosso As IPHostEntry = Dns.GetHostByName(Dns.GetHostName())
            Label4.Text = ipmosso.AddressList(0).ToString()
            TextBox1.Text = ""
            For i As Integer = 0 To ipmosso.AddressList.Length - 1
                TextBox1.Text = TextBox1.Text & ipmosso.AddressList(i).ToString() & vbNewLine
            Next

            Label6.Text = Session("workstationidstring").ToString()

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "IPCompleted_" & instanceId,
                "console.log('🌐 IP tracking completed: " & HttpUtility.JavaScriptStringEncode(ipaddress) & " - Instance: " & instanceId & "');", True)

        Catch ex As Exception
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "UserTrackingError_" & Me.ClientID,
                "console.error('❌ User tracking error - Instance: " & Me.ClientID & " - " & HttpUtility.JavaScriptStringEncode(ex.Message) & "');", True)
        End Try
    End Sub

    ''' <summary>
    ''' Load navigation data from current sitemap node and bind to repeater
    ''' </summary>
    Private Sub LoadNavigationData()
        Try
            Dim instanceId As String = Me.ClientID
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "LoadNavDataStart_" & instanceId,
                "console.log('📊 LoadNavigationData() started - Instance: " & instanceId & "...');", True)

            ' Reset the flag on fresh page load (not postback)
            If Not IsPostBack Then
                SyncLock navigationDataLock
                    navigationDataLoaded = False
                End SyncLock
            End If

            Dim navigationItems As New List(Of NavigationItem)()

            ' Get current sitemap node (same logic as backup RadSiteMap StartFromCurrentNode="true")
            Dim currentNode As SiteMapNode = SiteMap.CurrentNode

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "SitemapInfo_" & instanceId,
                "console.log('🗺️ Current SiteMap Node (" & instanceId & "): " & If(currentNode IsNot Nothing, currentNode.Title, "null") & "');", True)

            ' If current node exists, load its children (this matches RadSiteMap behavior)
            If currentNode IsNot Nothing AndAlso currentNode.ChildNodes IsNot Nothing AndAlso currentNode.ChildNodes.Count > 0 Then
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "ProcessChildren_" & instanceId,
                    "console.log('👥 Processing " & currentNode.ChildNodes.Count.ToString() & " child nodes - Instance: " & instanceId & "...');", True)

                ' Process child nodes of current node - exactly like RadSiteMap with StartFromCurrentNode
                For Each childNode As SiteMapNode In currentNode.ChildNodes
                    AddNavigationItem(childNode, navigationItems)
                Next
            ElseIf currentNode IsNot Nothing AndAlso currentNode.ParentNode IsNot Nothing Then
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "ProcessSiblings_" & instanceId,
                    "console.log('👫 No children found, processing siblings - Instance: " & instanceId & "...');", True)

                ' If current node has no children, show siblings (alternative approach)
                For Each siblingNode As SiteMapNode In currentNode.ParentNode.ChildNodes
                    If siblingNode.Url <> currentNode.Url Then ' Exclude current node itself
                        AddNavigationItem(siblingNode, navigationItems)
                    End If
                Next
            Else
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "ProcessRoot_" & instanceId,
                    "console.log('🌳 Loading from root node (fallback) - Instance: " & instanceId & "...');", True)

                ' Fallback: Load from root if no current node (when not in sitemap)
                Dim rootNode As SiteMapNode = SiteMap.RootNode
                If rootNode IsNot Nothing AndAlso rootNode.ChildNodes IsNot Nothing Then
                    For Each childNode As SiteMapNode In rootNode.ChildNodes
                        AddNavigationItem(childNode, navigationItems)
                    Next
                End If
            End If

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "NavItemsCount_" & instanceId,
                "console.log('📋 Total navigation items created (" & instanceId & "): " & navigationItems.Count.ToString() & "');", True)

            ' Debug: Log each navigation item
            For i As Integer = 0 To navigationItems.Count - 1
                Dim item As NavigationItem = navigationItems(i)
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "NavItem_" & instanceId & "_" & i.ToString(),
                    "console.log('📄 Nav Item " & (i + 1).ToString() & " (" & instanceId & "): " & HttpUtility.JavaScriptStringEncode(item.Title) & " | " & HttpUtility.JavaScriptStringEncode(item.Url) & "');", True)
            Next

            ' Bind to repeater directly (not using SiteMapDataSource)
            rptNavigation.DataSource = navigationItems
            rptNavigation.DataBind()

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "RepeaterBound_" & instanceId,
                "console.log('✅ Repeater data bound successfully (" & instanceId & ") with " & navigationItems.Count.ToString() & " items');", True)

            ' Also update SiteMapDataSource for backup
            SiteMapDataSource1x.StartFromCurrentNode = True
            SiteMapDataSource1x.ShowStartingNode = False

        Catch ex As Exception
            Dim instanceId As String = Me.ClientID
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "LoadNavDataError_" & instanceId,
                "console.error('❌ LoadNavigationData error (" & instanceId & "): " & HttpUtility.JavaScriptStringEncode(ex.Message) & "'); " &
                "console.log('🔄 Falling back to default navigation...');", True)

            ' If sitemap fails, load default navigation
            LoadDefaultNavigation()
        End Try
    End Sub

    ''' <summary>
    ''' Add navigation item with proper translation and image support
    ''' </summary>
    Private Sub AddNavigationItem(node As SiteMapNode, navigationItems As List(Of NavigationItem))
        If node Is Nothing OrElse String.IsNullOrEmpty(node.Title) OrElse String.IsNullOrEmpty(node.Url) Then
            Return
        End If

        ' Get translated title and image
        Dim translatedTitle As String = translatemeyamosso.GetResourceValuemosso(node.Title)
        Dim nodeImage As String = GetResourceImagemosso(node.Url)

        ' Create navigation item with image path
        Dim navItem As New NavigationItem() With {
            .Title = translatedTitle,
            .Url = ResolveUrl(node.Url),
            .Description = If(String.IsNullOrEmpty(node.Description), translatedTitle, translatemeyamosso.GetResourceValuemosso(node.Description)),
            .Icon = nodeImage,
            .Level = 0
        }

        navigationItems.Add(navItem)
    End Sub

    ''' <summary>
    ''' Process sitemap node recursively - Modified to work like backup RadSiteMap
    ''' </summary>
    Private Sub ProcessSiteMapNode(node As SiteMapNode, navigationItems As List(Of NavigationItem), level As Integer)
        If node Is Nothing Then Return

        ' Add current node with image support
        If Not String.IsNullOrEmpty(node.Title) And Not String.IsNullOrEmpty(node.Url) Then
            ' Get translated title and image
            Dim translatedTitle As String = translatemeyamosso.GetResourceValuemosso(node.Title)
            Dim nodeImage As String = GetResourceImagemosso(node.Url)

            Dim navItem As New NavigationItem() With {
                .Title = translatedTitle,
                .Url = ResolveUrl(node.Url),
                .Description = If(String.IsNullOrEmpty(node.Description), translatedTitle, translatemeyamosso.GetResourceValuemosso(node.Description)),
                .Icon = nodeImage,
                .Level = level
            }

            navigationItems.Add(navItem)
        End If

        ' Process child nodes recursively (but limit depth for performance)
        If node.ChildNodes IsNot Nothing AndAlso level < 2 Then
            For Each childNode As SiteMapNode In node.ChildNodes
                ProcessSiteMapNode(childNode, navigationItems, level + 1)
            Next
        End If
    End Sub

    ''' <summary>
    ''' Get resource image for navigation item (similar to translatemeyamosso.GetResourcemosso)
    ''' </summary>
    Private Function GetResourceImagemosso(url As String) As String
        Try
            ' Extract page name from URL for image mapping
            Dim pageName As String = ""
            If Not String.IsNullOrEmpty(url) Then
                pageName = System.IO.Path.GetFileNameWithoutExtension(url)
            End If

            ' Default image mapping based on page URL
            Select Case pageName.ToLower()
                Case "default", "home"
                    Return ResolveUrl("~/images/dashboard/10001.png")
                Case "users", "user"
                    Return ResolveUrl("~/images/dashboard/10002.png")
                Case "reports", "report"
                    Return ResolveUrl("~/images/dashboard/10003.png")
                Case "settings", "setting"
                    Return ResolveUrl("~/images/dashboard/10004.png")
                Case "finance", "financial"
                    Return ResolveUrl("~/images/dashboard/10005.png")
                Case "school", "students"
                    Return ResolveUrl("~/images/dashboard/10006.png")
                Case "inventory", "stock"
                    Return ResolveUrl("~/images/dashboard/10007.png")
                Case "hr", "human"
                    Return ResolveUrl("~/images/dashboard/10008.png")
                Case Else
                    ' Try to get from translation system if available
                    Dim translatedImage As String = translatemeyamosso.GetResourceValuemosso(pageName & "_Image")
                    If Not String.IsNullOrEmpty(translatedImage) AndAlso translatedImage <> pageName & "_Image" Then
                        Return ResolveUrl(translatedImage)
                    Else
                        Return ResolveUrl("~/images/dashboard/10001.png") ' Default fallback
                    End If
            End Select

        Catch ex As Exception
            Return ResolveUrl("~/images/dashboard/10001.png") ' Safe fallback
        End Try
    End Function

    ''' <summary>
    ''' Get appropriate icon based on node title
    ''' </summary>
    Private Function GetIconForNode(title As String) As String
        If String.IsNullOrEmpty(title) Then Return "fas fa-cube"

        title = title.ToLower()

        If title.Contains("home") OrElse title.Contains("رئيسية") Then
            Return "fas fa-home"
        ElseIf title.Contains("user") OrElse title.Contains("مستخدم") Then
            Return "fas fa-users"
        ElseIf title.Contains("report") OrElse title.Contains("تقرير") Then
            Return "fas fa-chart-bar"
        ElseIf title.Contains("setting") OrElse title.Contains("إعداد") Then
            Return "fas fa-cog"
        ElseIf title.Contains("school") OrElse title.Contains("مدرسة") Then
            Return "fas fa-graduation-cap"
        ElseIf title.Contains("finance") OrElse title.Contains("مالية") Then
            Return "fas fa-dollar-sign"
        ElseIf title.Contains("inventory") OrElse title.Contains("مخزون") Then
            Return "fas fa-boxes"
        Else
            Return "fas fa-cube"
        End If
    End Function

    ''' <summary>
    ''' Load default navigation when sitemap is not available
    ''' </summary>
    Private Sub LoadDefaultNavigation()
        Dim defaultItems As New List(Of NavigationItem)() From {
            New NavigationItem() With {
                .Title = "الرئيسية",
                .Url = "~/Default.aspx",
                .Description = "الصفحة الرئيسية للنظام",
                .Icon = "fas fa-home",
                .Level = 0
            },
            New NavigationItem() With {
                .Title = "إدارة المستخدمين",
                .Url = "~/Pages/Users.aspx",
                .Description = "إضافة وإدارة المستخدمين",
                .Icon = "fas fa-users",
                .Level = 0
            },
            New NavigationItem() With {
                .Title = "التقارير",
                .Url = "~/Pages/Reports.aspx",
                .Description = "عرض التقارير والإحصائيات",
                .Icon = "fas fa-chart-bar",
                .Level = 0
            },
            New NavigationItem() With {
                .Title = "الإعدادات",
                .Url = "~/Pages/Settings.aspx",
                .Description = "إعدادات النظام العامة",
                .Icon = "fas fa-cog",
                .Level = 0
            }
        }

        rptNavigation.DataSource = defaultItems
        rptNavigation.DataBind()
    End Sub

    ''' <summary>
    ''' تحميل المحتوى الحديث باستخدام DynamicControlConverter
    ''' Load modern content using DynamicControlConverter
    ''' </summary>
    Private Sub LoadModernContent()
        Try
            ' Add logging for LoadModernContent
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "LoadModernContentStart",
                "console.log('🔄 LoadModernContent() started - trying DynamicControlConverter...');", True)

            ' استخدام المحول الديناميكي لإنشاء التصميم الحديث
            Dim modernHtml As String = DynamicControlConverter.ConvertTableOfContentsToModern(Me.Page, "modernTocConverted")
            litModernToc.Text = modernHtml
            litModernToc.Visible = True

            ScriptManager.RegisterStartupScript(Me, GetType(Page), "LoadModernContentSuccess",
                "console.log('✅ LoadModernContent() success - DynamicControlConverter worked'); " &
                "console.log('📝 Modern HTML length: " & modernHtml.Length.ToString() & " characters');", True)

        Catch ex As Exception
            ' في حالة فشل التحويل، عرض رسالة خطأ مفيدة
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "LoadModernContentError",
                "console.warn('⚠️ LoadModernContent() - DynamicControlConverter failed, showing error message'); " &
                "console.error('❌ Error details: " & HttpUtility.JavaScriptStringEncode(ex.Message) & "');", True)

            litModernToc.Text = "<div class='conversion-error'>" &
                              "<div class='error-header'>" &
                              "<i class='fas fa-tools'></i>" &
                              "<h3>تحويل تلقائي للتصميم الحديث</h3>" &
                              "</div>" &
                              "<p>جاري تحويل TableOfContents من Telerik إلى التصميم الحديث...</p>" &
                              "<div class='error-details'>" &
                              "تفاصيل: " & HttpUtility.HtmlEncode(ex.Message) &
                              "</div>" &
                              "<p><strong>الحل:</strong> استخدم وضع Legacy للوقت الحالي.</p>" &
                              "</div>" &
                              "<style>" &
                              ".conversion-error {" &
                              "  background: linear-gradient(135deg, rgba(234, 179, 8, 0.1), rgba(245, 158, 11, 0.1));" &
                              "  border: 1px solid rgba(245, 158, 11, 0.3);" &
                              "  border-radius: 12px;" &
                              "  padding: 2rem;" &
                              "  text-align: center;" &
                              "  margin: 2rem 0;" &
                              "}" &
                              ".error-header {" &
                              "  display: flex;" &
                              "  align-items: center;" &
                              "  justify-content: center;" &
                              "  gap: 0.5rem;" &
                              "  margin-bottom: 1rem;" &
                              "  color: #f59e0b;" &
                              "}" &
                              ".error-details {" &
                              "  background: rgba(245, 158, 11, 0.1);" &
                              "  border-radius: 8px;" &
                              "  padding: 1rem;" &
                              "  margin: 1rem 0;" &
                              "  font-family: monospace;" &
                              "  font-size: 0.9rem;" &
                              "  color: #92400e;" &
                              "}" &
                              "</style>"
            litModernToc.Visible = True
        End Try
    End Sub

    ''' <summary>
    ''' تطبيق الإعدادات من web.config
    ''' Apply settings from web.config
    ''' </summary>
    Private Sub ApplyConfigurationSettings()
        Try
            ' قراءة الإعدادات من web.config
            Dim defaultMode As String = ConfigurationManager.AppSettings("TableOfContents.DefaultMode")
            Dim enableToggle As String = ConfigurationManager.AppSettings("TableOfContents.EnableToggle")
            Dim showModeSelector As String = ConfigurationManager.AppSettings("TableOfContents.ShowModeSelector")

            ' Add console logging for configuration
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "LogConfig",
                "console.log('🔧 TableOfContents Configuration:');" &
                "console.log('   📋 Default Mode: " & If(String.IsNullOrEmpty(defaultMode), "none", defaultMode) & "');" &
                "console.log('   🔄 Enable Toggle: " & If(String.IsNullOrEmpty(enableToggle), "none", enableToggle) & "');" &
                "console.log('   👁️ Show Mode Selector: " & If(String.IsNullOrEmpty(showModeSelector), "none", showModeSelector) & "');", True)

            ' تطبيق الوضع الافتراضي
            If Not String.IsNullOrEmpty(defaultMode) AndAlso defaultMode.ToLower() = "modern" Then
                ' بدء في الوضع الحديث
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "SetDefaultMode_" & Me.ClientID,
                    "console.log('🎯 Setting default mode to modern for instance: " & Me.ClientID & "'); " &
                    "setTimeout(function() { " &
                    "  console.log('⏰ Timeout triggered for " & Me.ClientID & ", calling switchToModernMode...'); " &
                    "  if (typeof switchToModernMode_" & Me.ClientID & " === 'function') { " &
                    "    switchToModernMode_" & Me.ClientID & "(); " &
                    "  } else if (typeof switchToModernMode === 'function') { " &
                    "    switchToModernMode(); " &
                    "  } else { " &
                    "    console.error('❌ switchToModernMode function not found for " & Me.ClientID & "!'); " &
                    "  } " &
                    "}, 100);", True)
            End If

            ' إخفاء أزرار التبديل إذا كان معطل
            If Not String.IsNullOrEmpty(enableToggle) AndAlso enableToggle.ToLower() = "false" Then
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "HideToggle",
                    "console.log('🚫 Hiding toggle buttons...'); " &
                    "document.addEventListener('DOMContentLoaded', function() { " &
                    "  var toggle = document.querySelector('.toc-mode-selector'); " &
                    "  if(toggle) { " &
                    "    toggle.style.display = 'none'; " &
                    "    console.log('✅ Toggle hidden'); " &
                    "  } else { " &
                    "    console.log('ℹ️ No toggle found to hide'); " &
                    "  } " &
                    "});", True)
            End If

            ' إخفاء محدد الوضع إذا كان معطل
            If Not String.IsNullOrEmpty(showModeSelector) AndAlso showModeSelector.ToLower() = "false" Then
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "HideModeSelector",
                    "console.log('🚫 Hiding mode selector...'); " &
                    "document.addEventListener('DOMContentLoaded', function() { " &
                    "  var selector = document.querySelector('.mode-toggle'); " &
                    "  if(selector) { " &
                    "    selector.style.display = 'none'; " &
                    "    console.log('✅ Mode selector hidden'); " &
                    "  } else { " &
                    "    console.log('ℹ️ No mode selector found to hide'); " &
                    "  } " &
                    "});", True)
            End If

        Catch ex As Exception
            ' تجاهل أخطاء قراءة الإعدادات ولكن اطبع log
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "ConfigError",
                "console.error('❌ Configuration error: " & HttpUtility.JavaScriptStringEncode(ex.Message) & "');", True)
        End Try
    End Sub
    Function GetExternalIP(ByVal webPath As String) As String
        Dim output As String = ""
        Dim webReq As New System.Net.WebClient
        output = System.Text.Encoding.ASCII.GetString((webReq.DownloadData(webPath)))
        webReq.Dispose()
        Return output
    End Function
    Private Sub ConfigureNodeTargets(ByVal nodes As TreeNodeCollection)
        For Each n As TreeNode In nodes
            Dim m As Match = Regex.Match(n.NavigateUrl, "^(_\w+):(.+)$")
            If m.Success Then
                n.Target = m.Groups(1).Value
                n.NavigateUrl = m.Groups(2).Value
            End If
            ConfigureNodeTargets(n.ChildNodes)
        Next
    End Sub
End Class
