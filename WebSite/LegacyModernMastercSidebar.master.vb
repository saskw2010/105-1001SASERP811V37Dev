Imports eZee.Services
Imports eZee.Web
Imports System
Imports System.Collections.Generic
Imports System.Globalization
Imports System.Linq
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.IO

Partial Public Class Main
    Inherits Global.System.Web.UI.MasterPage

    Public Shared MicrosoftJavaScript() As String = New String() {"MicrosoftAjax.js", "MicrosoftAjaxWebForms.js", "MicrosoftAjaxApplicationServices.js"}

    Shared Sub New()
        ApplicationServices.EnableMinifiedCss = True
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ' ScriptManager is now properly declared in the master page

        Dim pageCssClass As String = (Page.GetType().Name + " Loading")
        Dim p As PropertyInfo = Page.GetType().GetProperty("CssClass")
        If (Not (p) Is Nothing) Then
            Dim cssClassName As String = CType(p.GetValue(Page, Nothing), String)
            If Not (String.IsNullOrEmpty(pageCssClass)) Then
                pageCssClass = (pageCssClass + " ")
            End If
            pageCssClass = (pageCssClass + cssClassName)
        End If
        If Not (pageCssClass.Contains("Wide")) Then
            pageCssClass = (pageCssClass + " Standard")
        End If

        Dim c As LiteralControl = CType(Page.Form.Controls(0), LiteralControl)
        If ((Not (c) Is Nothing) AndAlso Not (String.IsNullOrEmpty(pageCssClass))) Then
            c.Text = Regex.Replace(c.Text, "<div>", String.Format("<div class=""{0}"">", pageCssClass))
        End If

        ' Legacy Menu Integration - Enhanced for Modern Design
        If Not IsPostBack Then
            ' ≈⁄œ«œ „⁄·Ê„«  «·„” Œœ„ ··„‰ÌÊ «··ÌÃ«”Ì
            SetupLegacyMenuUserInfo()

            ' ≈⁄œ«œ »Ì«‰«  «·„‰ÌÊ «··ÌÃ«”Ì
            SetupLegacyMenuData()

            ' ≈⁄œ«œ „⁄·Ê„«  «·’›Õ… «·Õ«·Ì…
            SetupCurrentPageInfo()

            '' Publish canonical ASMX endpoint (virtual-dir safe)
            'Dim asmxBase As String = ResolveUrl("~/Services/DataControllerService.asmx")
            '' Hidden field for server-side reads
            'Dim hf = TryCast(Me.FindControl("AsmxBaseField"), HiddenField)
            'If hf IsNot Nothing Then
            '    hf.Value = asmxBase
            'End If
            '' Expose to client: body dataset, window.AppConfig, and localStorage
            'Dim script As String = _
            '    "(function(){" & vbCrLf & _
            '    "  try {" & vbCrLf & _
            '    "    var asmx='" & asmxBase.Replace("'", "\'") & "';" & vbCrLf & _
            '    "    if (document && document.body) document.body.setAttribute('data-asmx-base', asmx);" & vbCrLf & _
            '    "    window.AppConfig = window.AppConfig || {};" & vbCrLf & _
            '    "    window.AppConfig.asmxBase = asmx;" & vbCrLf & _
            '    "    try { localStorage.setItem('saserp.asmxBase', asmx); } catch(e){}" & vbCrLf & _
            '    "  } catch(e) { console && console.warn && console.warn('asmxBase publish failed', e); }" & vbCrLf & _
            '    "})();"
            'Page.ClientScript.RegisterStartupScript(Me.GetType(), "AsmxbPublish", script, True)
        End If

        ' Add common classes to body
        Try
            Dim bodyControl As HtmlGenericControl = TryCast(Me.Page.Master.FindControl("Body"), HtmlGenericControl)
            If bodyControl IsNot Nothing Then
                Dim current As String = bodyControl.Attributes("class")
                If String.IsNullOrEmpty(current) Then current = String.Empty
                bodyControl.Attributes("class") = (current & " modern-navigation enhanced-theme legacy-menu-integration").Trim()
            End If
        Catch ex As Exception
            ' Log error if needed
            System.Diagnostics.Debug.WriteLine("Error adding body classes: " & ex.Message)
        End Try

        '' ÿ»¯ﬁ «·ÀÌ„ „‰ «·ﬂÊﬂÌ themePreference (ﬂ·«” + „·› CSS «Œ Ì«—Ì)
        'ApplyThemeFromCookie()
    End Sub

    ' ≈⁄œ«œ „⁄·Ê„«  «·„” Œœ„ ··„‰ÌÊ «··ÌÃ«”Ì
    Private Sub SetupLegacyMenuUserInfo()
        Try
            ' «·Õ’Ê· ⁄·Ï „⁄·Ê„«  «·„” Œœ„ «·Õ«·Ì
            Dim userName As String = "«·„” Œœ„"

            ' „Õ«Ê·… «·Õ’Ê· ⁄·Ï «”„ «·„” Œœ„ „‰ «·‰Ÿ«„
            Try
                If HttpContext.Current.User.Identity.IsAuthenticated Then
                    userName = HttpContext.Current.User.Identity.Name
                End If
            Catch ex As Exception
                ' «” Œœ«„ «”„ «› —«÷Ì ≈–« ›‘· «·Õ’Ê· ⁄·Ï «”„ «·„” Œœ„
            End Try

            ' ≈÷«›… «”„ «·„” Œœ„ ≈·Ï JavaScript
            Dim userScript As String = String.Format(
                "window.__username = '{0}';",
                userName.Replace("'", "\'")
            )
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "UserInfo", userScript, True)

        Catch ex As Exception
            ' Log error if needed
            System.Diagnostics.Debug.WriteLine("Error setting up legacy menu user info: " & ex.Message)
        End Try
    End Sub

    ' ≈⁄œ«œ »Ì«‰«  «·„‰ÌÊ «··ÌÃ«”Ì
    Private Sub SetupLegacyMenuData()
        Try
            Dim menuData As New List(Of Object)()

            ' ≈÷«›… ⁄‰«’— «·„‰ÌÊ «·—∆Ì”Ì…
            menuData.Add(New With {
                .id = 1,
                .title = "«·—∆Ì”Ì…",
                .url = "/Default.aspx",
                .icon = "fas fa-home",
                .children = New List(Of Object)()
            })

            menuData.Add(New With {
                .id = 2,
                .title = "«·„Œ«“‰",
                .url = "#",
                .icon = "fas fa-boxes",
                .children = New List(Of Object) From {
                    New With {.id = 21, .title = "≈œ«—… «·„Œ«“‰", .url = "/Pages/Inventory.aspx", .icon = "fas fa-warehouse"},
                    New With {.id = 22, .title = "Ã—œ «·„Œ“Ê‰", .url = "/Pages/Stock.aspx", .icon = "fas fa-cubes"},
                    New With {.id = 23, .title = " ÕÊÌ·« ", .url = "/Pages/Transfer.aspx", .icon = "fas fa-exchange-alt"}
                }
            })

            menuData.Add(New With {
                .id = 3,
                .title = "«·„»Ì⁄« ",
                .url = "#",
                .icon = "fas fa-shopping-cart",
                .children = New List(Of Object) From {
                    New With {.id = 31, .title = "›Ê« Ì— «·„»Ì⁄« ", .url = "/Pages/Sales.aspx", .icon = "fas fa-file-invoice-dollar"},
                    New With {.id = 32, .title = "«·⁄„·«¡", .url = "/Pages/Customers.aspx", .icon = "fas fa-users"},
                    New With {.id = 33, .title = "⁄—Ê÷ «·√”⁄«—", .url = "/Pages/Quotes.aspx", .icon = "fas fa-file-alt"}
                }
            })

            menuData.Add(New With {
                .id = 4,
                .title = "«·„‘ —Ì« ",
                .url = "#",
                .icon = "fas fa-shopping-bag",
                .children = New List(Of Object) From {
                    New With {.id = 41, .title = "›Ê« Ì— «·„‘ —Ì« ", .url = "/Pages/Purchases.aspx", .icon = "fas fa-file-invoice"},
                    New With {.id = 42, .title = "«·„Ê—œÌ‰", .url = "/Pages/Suppliers.aspx", .icon = "fas fa-truck"},
                    New With {.id = 43, .title = "ÿ·»«  «·‘—«¡", .url = "/Pages/PurchaseOrders.aspx", .icon = "fas fa-clipboard-list"}
                }
            })

            menuData.Add(New With {
                .id = 5,
                .title = "«· ﬁ«—Ì—",
                .url = "#",
                .icon = "fas fa-chart-pie",
                .children = New List(Of Object) From {
                    New With {.id = 51, .title = "«· ﬁ«—Ì— «·„«·Ì…", .url = "/Pages/FinancialReports.aspx", .icon = "fas fa-chart-line"},
                    New With {.id = 52, .title = " ﬁ«—Ì— «·„»Ì⁄« ", .url = "/Pages/SalesReports.aspx", .icon = "fas fa-chart-bar"},
                    New With {.id = 53, .title = " ﬁ«—Ì— «·„Œ«“‰", .url = "/Pages/InventoryReports.aspx", .icon = "fas fa-warehouse"}
                }
            })

            menuData.Add(New With {
                .id = 6,
                .title = "«·≈⁄œ«œ« ",
                .url = "/Pages/Settings.aspx",
                .icon = "fas fa-cog",
                .children = New List(Of Object)()
            })

            '  ÕÊÌ· «·»Ì«‰«  ≈·Ï JSON
            Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer()
            Dim menuJson As String = serializer.Serialize(menuData)

            ' ≈÷«›… «·»Ì«‰«  ≈·Ï JavaScript
            Dim menuScript As String = String.Format(
                "(function() {{" & vbCrLf &
                "    window.LegacyMenuData = {0};" & vbCrLf &
                "    console.log('Legacy menu data loaded:', window.LegacyMenuData);" & vbCrLf &
                "}})();",
                menuJson
            )

            Page.ClientScript.RegisterStartupScript(Me.GetType(), "MenuData", menuScript, True)

        Catch ex As Exception
            ' Log error if needed
            System.Diagnostics.Debug.WriteLine("Error setting up legacy menu data: " & ex.Message)

            ' ≈÷«›… »Ì«‰«  «› —«÷Ì… ›Ì Õ«·… «·Œÿ√
            Dim defaultMenuScript As String = String.Format(
                "(function() {{" & vbCrLf &
                "    window.LegacyMenuData = [{{" & vbCrLf &
                "        id: 1," & vbCrLf &
                "        title: '«·—∆Ì”Ì…'," & vbCrLf &
                "        url: '/Default.aspx'," & vbCrLf &
                "        icon: 'fas fa-home'," & vbCrLf &
                "        children: []" & vbCrLf &
                "    }}];" & vbCrLf &
                "    console.log('Default menu data loaded');" & vbCrLf &
                "}})();"
            )

            Page.ClientScript.RegisterStartupScript(Me.GetType(), "DefaultMenuData", defaultMenuScript, True)
        End Try
    End Sub

    ' ≈⁄œ«œ „⁄·Ê„«  «·’›Õ… «·Õ«·Ì…
    Private Sub SetupCurrentPageInfo()
        Try
            Dim currentPath As String = Request.Path
            Dim pageScript As String = String.Format(
                "window.__currentPage = '{0}';",
                currentPath.Replace("'", "\'")
            )
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "CurrentPage", pageScript, True)
        Catch ex As Exception
            ' Log error if needed
            System.Diagnostics.Debug.WriteLine("Error setting up current page info: " & ex.Message)
        End Try
    End Sub

    '  ÿ»Ìﬁ «·ÀÌ„ „‰ «·ﬂÊﬂÌ
    Private Sub ApplyThemeFromCookie()
        ' «ﬁ—√ «·ﬂÊﬂÌ
        Dim savedTheme As String = Nothing
        Dim themeCookie As HttpCookie = Request.Cookies("themePreference")

        If themeCookie IsNot Nothing Then
            savedTheme = themeCookie.Value
        End If

        ' ÿ»¯ﬁ «·ÀÌ„ ·Ê ›ÌÂ ﬁÌ„…
        If Not String.IsNullOrEmpty(savedTheme) Then
            ' («Œ Ì«—Ì) ›· —… »”Ìÿ… ·„‰⁄ ﬁÌ„ €—Ì»…
            savedTheme = System.Text.RegularExpressions.Regex.Replace(savedTheme, "[^A-Za-z0-9\-_]", "")

            ' √÷› ﬂ·«” ··‹ <body> „À·: theme-dark √Ê theme-light
            If Body IsNot Nothing Then
                Dim cur As String = Body.Attributes("class")
                If String.IsNullOrEmpty(cur) Then cur = String.Empty
                Body.Attributes("class") = (cur & " theme-" & savedTheme.ToLower()).Trim()
            End If

            ' («Œ Ì«—Ì) Õ„¯· „·› CSS ··ÀÌ„
            ' Dim themeCss As String = String.Format("~/css/themes/{0}.css", savedTheme)
            ' Dim cssLink As New HtmlLink()
            ' cssLink.Href = ResolveUrl(themeCss)
            ' cssLink.Attributes("rel") = "stylesheet"
            ' cssLink.Attributes("type") = "text/css"
            ' Page.Header.Controls.Add(cssLink)
        End If
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreRender
        ' √Ì  ⁄œÌ·«  ﬁ»· «·—Ì‰œ—
    End Sub

    Protected Sub sm_ResolveScriptReference(ByVal sender As Object, ByVal e As ScriptReferenceEventArgs) Handles sm.ResolveScriptReference
        ' Õ· „‘«ﬂ· „—«Ã⁄ «·”ﬂ—Ì» 
        If AquariumExtenderBase.EnableCombinedScript Then
            Select Case e.Script.Name
                Case "MicrosoftAjax.js"
                    e.Script.Path = "~/js/MicrosoftAjax.js"
                Case "MicrosoftAjaxWebForms.js"
                    e.Script.Path = "~/js/MicrosoftAjaxWebForms.js"
                Case "MicrosoftAjaxApplicationServices.js"
                    e.Script.Path = "~/js/MicrosoftAjaxApplicationServices.js"
            End Select
        End If
    End Sub
End Class