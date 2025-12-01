Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.Script.Serialization

Partial Class UniversalNavMaster
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                InitializePage()
                SetupClientConfiguration()
                LoadPageSpecificSettings()
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in UniversalNavMaster Page_Load: " & ex.Message)
        End Try
    End Sub

    Private Sub InitializePage()
        Try
            ' Set page title if not already set
            If String.IsNullOrEmpty(Page.Title) Then
                Page.Title = "SASERP V37 - نظام إدارة موارد المؤسسات"
            End If

            ' Add meta tags for mobile optimization
            Dim viewport As New HtmlMeta()
            viewport.Name = "viewport"
            viewport.Content = "width=device-width, initial-scale=1.0, user-scalable=no"
            Page.Header.Controls.Add(viewport)

            ' Add theme color meta
            Dim themeColor As New HtmlMeta()
            themeColor.Name = "theme-color"
            themeColor.Content = "#2c3e50"
            Page.Header.Controls.Add(themeColor)

            ' Add manifest for PWA
            Dim manifest As New HtmlLink()
            manifest.Attributes("rel") = "manifest"
            manifest.Href = ResolveUrl("~/manifest.json")
            Page.Header.Controls.Add(manifest)

            ' Add favicon
            Dim favicon As New HtmlLink()
            favicon.Attributes("rel") = "icon"
            favicon.Attributes("type") = "image/png"
            favicon.Href = ResolveUrl("~/favicon.png")
            Page.Header.Controls.Add(favicon)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error initializing page: " & ex.Message)
        End Try
    End Sub

    Private Sub SetupClientConfiguration()
        Try
            ' Create client configuration object using Anonymous Type
            Dim asmxBase As String = ResolveUrl("~/Services/DataControllerService.asmx")
            Dim startingNodeUrl As String = Nothing
            Dim currentNode As SiteMapNode = SiteMap.CurrentNode
            If currentNode IsNot Nothing Then
                startingNodeUrl = If(currentNode.ParentNode IsNot Nothing, currentNode.ParentNode.Url, currentNode.Url)
            Else
                startingNodeUrl = "~/Default.aspx"
            End If

            Dim clientConfig = New With {
                .apiBaseUrl = ResolveUrl("~/"),
                .asmxBase = asmxBase,
                .currentUser = If(HttpContext.Current.User.Identity.IsAuthenticated, HttpContext.Current.User.Identity.Name, ""),
                .isAuthenticated = HttpContext.Current.User.Identity.IsAuthenticated,
                .culture = System.Threading.Thread.CurrentThread.CurrentCulture.Name,
                .isRtl = True,
                .appVersion = "1.1.37",
                .environment = If(HttpContext.Current.IsDebuggingEnabled, "development", "production"),
                .features = New With {
                    .enableNotifications = True,
                    .enableOfflineMode = False,
                    .enableAnalytics = False
                },
                .nav = New With {
                    .startingNodeUrl = startingNodeUrl
                }
            }

            ' Convert to JSON and inject into page
            Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer()
            Dim json As String = serializer.Serialize(clientConfig)
            Dim script As String = String.Format("window.AppConfig = {0};", json)

            Page.ClientScript.RegisterStartupScript(Me.GetType(), "AppConfig", script, True)

            ' Also publish to body dataset and localStorage for non-Vue scripts
            Dim publishAsmxb As String = _
                "(function(){" & vbCrLf & _
                "  try {" & vbCrLf & _
                "    var asmx='" & asmxBase.Replace("'", "\'") & "';" & vbCrLf & _
                "    if (document && document.body) document.body.setAttribute('data-asmx-base', asmx);" & vbCrLf & _
                "    try { localStorage.setItem('saserp.asmxBase', asmx); } catch(e){}" & vbCrLf & _
                "  } catch(e) { console && console.warn && console.warn('asmxBase publish failed', e); }" & vbCrLf & _
                "})();"
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "AsmxbPublishUNM", publishAsmxb, True)

            ' Ensure Vue global is present (once)
            Dim vueKey As String = "VueGlobalInclude"
            If Page.Header IsNot Nothing AndAlso Page.Header.FindControl(vueKey) Is Nothing Then
                Dim scriptTag As New HtmlGenericControl("script")
                scriptTag.ID = vueKey
                scriptTag.Attributes("type") = "text/javascript"
                scriptTag.Attributes("src") = ResolveUrl("~/js/vue.global.prod.js")
                Page.Header.Controls.Add(scriptTag)
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error setting up client configuration: " & ex.Message)
        End Try
    End Sub

    ' Allow pages to change body class safely
    Public Sub ReplaceBodyClass(newClass As String)
        Try
            Dim script As String = "document.body.className='" & newClass.Replace("'", "\'") & "';"
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "ReplaceBodyClass", script, True)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error replacing body class: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadPageSpecificSettings()
        Try
            ' Get current page name
            Dim pageName As String = IO.Path.GetFileNameWithoutExtension(Request.PhysicalPath)
            
            ' Apply page-specific configurations
            Select Case pageName.ToLower()
                Case "default", "home"
                    AddPageClass("homepage")
                    SetPagePriority("high")
                    
                Case "login", "signin"
                    AddPageClass("login-page")
                    HideNavigationForLogin()
                    
                Case "dashboard"
                    AddPageClass("dashboard-page")
                    SetPagePriority("high")
                    
                Case Else
                    AddPageClass("content-page")
            End Select

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error loading page specific settings: " & ex.Message)
        End Try
    End Sub

    Private Sub AddPageClass(className As String)
        Try
            ' Add CSS class to body
            Dim bodyClass As String = HttpContext.Current.Items("BodyClass")
            If String.IsNullOrEmpty(bodyClass) Then
                bodyClass = className
            Else
                bodyClass = bodyClass & " " & className
            End If
            HttpContext.Current.Items("BodyClass") = bodyClass

            ' Apply class via JavaScript
            Dim script As String = String.Format("document.body.classList.add('{0}');", className)
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "AddBodyClass_" & className, script, True)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error adding page class: " & ex.Message)
        End Try
    End Sub

    Private Sub SetPagePriority(priority As String)
        Try
            ' Add performance hints for important pages
            If priority = "high" Then
                ' Add preload hints
                Dim preloadScript As New HtmlLink()
                preloadScript.Attributes("rel") = "preload"
                preloadScript.Attributes("as") = "script"
                preloadScript.Href = ResolveUrl("~/js/navigation-vue-components.js")
                Page.Header.Controls.Add(preloadScript)
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error setting page priority: " & ex.Message)
        End Try
    End Sub

    Private Sub HideNavigationForLogin()
        Try
            ' Hide navigation for login pages
            Dim hideNavScript As String = _
                "document.addEventListener('DOMContentLoaded', function() {" & vbCrLf & _
                "    const navElement = document.getElementById('universalHamburgerMenu');" & vbCrLf & _
                "    if (navElement) {" & vbCrLf & _
                "        navElement.style.display = 'none';" & vbCrLf & _
                "    }" & vbCrLf & _
                "    document.body.classList.add('no-navigation');" & vbCrLf & _
                "});"
            
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "HideNavigation", hideNavScript, True)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error hiding navigation: " & ex.Message)
        End Try
    End Sub

    Protected Sub Page_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        Try
            ' Add final configurations before rendering
            OptimizePagePerformance()
            AddAnalyticsIfEnabled()
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in Page_PreRender: " & ex.Message)
        End Try
    End Sub

    Private Sub OptimizePagePerformance()
        Try
            ' Add performance optimizations
            If Not HttpContext.Current.IsDebuggingEnabled Then
                ' Enable compression
                Response.Filter = New System.IO.Compression.GZipStream(Response.Filter, System.IO.Compression.CompressionMode.Compress)
                Response.AppendHeader("Content-Encoding", "gzip")
            End If

            ' Set cache headers for static resources
            If Request.Url.PathAndQuery.Contains(".css") OrElse Request.Url.PathAndQuery.Contains(".js") Then
                Response.Cache.SetExpires(DateTime.Now.AddDays(30))
                Response.Cache.SetCacheability(HttpCacheability.Public)
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error optimizing performance: " & ex.Message)
        End Try
    End Sub

    Private Sub AddAnalyticsIfEnabled()
        Try
            ' Add analytics code if enabled
            Dim enableAnalytics As Boolean = False ' Configure in web.config
            
            If enableAnalytics Then
                Dim analyticsScript As String = _
                    "// Add analytics tracking code here" & vbCrLf & _
                    "console.log('Analytics tracking enabled');"
                
                Page.ClientScript.RegisterStartupScript(Me.GetType(), "Analytics", analyticsScript, True)
            End If

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error adding analytics: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Method to register additional CSS files from content pages
    ''' </summary>
    Public Sub RegisterCSS(cssPath As String)
        Try
            Dim cssLink As New HtmlLink()
            cssLink.Href = ResolveUrl(cssPath)
            cssLink.Attributes("rel") = "stylesheet"
            cssLink.Attributes("type") = "text/css"
            Page.Header.Controls.Add(cssLink)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error registering CSS: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Method to register additional JavaScript files from content pages
    ''' </summary>
    Public Sub RegisterJS(jsPath As String, Optional defer As Boolean = False)
        Try
            Dim script As New HtmlGenericControl("script")
            script.Attributes("type") = "text/javascript"
            script.Attributes("src") = ResolveUrl(jsPath)
            If defer Then
                script.Attributes("defer") = "defer"
            End If
            Page.Header.Controls.Add(script)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error registering JS: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Method to set page meta description
    ''' </summary>
    Public Sub SetMetaDescription(description As String)
        Try
            Dim metaDesc As New HtmlMeta()
            metaDesc.Name = "description"
            metaDesc.Content = description
            Page.Header.Controls.Add(metaDesc)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error setting meta description: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Method to set page keywords
    ''' </summary>
    Public Sub SetMetaKeywords(keywords As String)
        Try
            Dim metaKeywords As New HtmlMeta()
            metaKeywords.Name = "keywords"
            metaKeywords.Content = keywords
            Page.Header.Controls.Add(metaKeywords)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error setting meta keywords: " & ex.Message)
        End Try
    End Sub

End Class
