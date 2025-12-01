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
        If AquariumExtenderBase.EnableCombinedScript Then
            sm.EnableScriptLocalization = False
        End If

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
            ' إعداد معلومات المستخدم للمنيو الليجاسي
            SetupLegacyMenuUserInfo()

            ' إعداد بيانات المنيو الليجاسي
            SetupLegacyMenuData()

            ' إعداد معلومات الصفحة الحالية
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

        '' طبّق الثيم من الكوكي themePreference (كلاس + ملف CSS اختياري)
        'ApplyThemeFromCookie()
    End Sub

    ' إعداد معلومات المستخدم للمنيو الليجاسي
    Private Sub SetupLegacyMenuUserInfo()
        Try
            ' الحصول على معلومات المستخدم الحالي
            Dim userName As String = "المستخدم"

            ' محاولة الحصول على اسم المستخدم من النظام
            Try
                If HttpContext.Current.User.Identity.IsAuthenticated Then
                    userName = HttpContext.Current.User.Identity.Name
                End If
            Catch ex As Exception
                ' استخدام اسم افتراضي إذا فشل الحصول على اسم المستخدم
            End Try

            ' إضافة اسم المستخدم إلى JavaScript
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

    ' إعداد بيانات المنيو الليجاسي
    Private Sub SetupLegacyMenuData()
        Try
            Dim menuData As New List(Of Object)()

            ' إضافة عناصر المنيو الرئيسية
            menuData.Add(New With {
                .id = 1,
                .title = "الرئيسية",
                .url = "/Default.aspx",
                .icon = "fas fa-home",
                .children = New List(Of Object)()
            })

            menuData.Add(New With {
                .id = 2,
                .title = "المخازن",
                .url = "#",
                .icon = "fas fa-boxes",
                .children = New List(Of Object) From {
                    New With {.id = 21, .title = "إدارة المخازن", .url = "/Pages/Inventory.aspx", .icon = "fas fa-warehouse"},
                    New With {.id = 22, .title = "جرد المخزون", .url = "/Pages/Stock.aspx", .icon = "fas fa-cubes"},
                    New With {.id = 23, .title = "تحويلات", .url = "/Pages/Transfer.aspx", .icon = "fas fa-exchange-alt"}
                }
            })

            menuData.Add(New With {
                .id = 3,
                .title = "المبيعات",
                .url = "#",
                .icon = "fas fa-shopping-cart",
                .children = New List(Of Object) From {
                    New With {.id = 31, .title = "فواتير المبيعات", .url = "/Pages/Sales.aspx", .icon = "fas fa-file-invoice-dollar"},
                    New With {.id = 32, .title = "العملاء", .url = "/Pages/Customers.aspx", .icon = "fas fa-users"},
                    New With {.id = 33, .title = "عروض الأسعار", .url = "/Pages/Quotes.aspx", .icon = "fas fa-file-alt"}
                }
            })

            menuData.Add(New With {
                .id = 4,
                .title = "المشتريات",
                .url = "#",
                .icon = "fas fa-shopping-bag",
                .children = New List(Of Object) From {
                    New With {.id = 41, .title = "فواتير المشتريات", .url = "/Pages/Purchases.aspx", .icon = "fas fa-file-invoice"},
                    New With {.id = 42, .title = "الموردين", .url = "/Pages/Suppliers.aspx", .icon = "fas fa-truck"},
                    New With {.id = 43, .title = "طلبات الشراء", .url = "/Pages/PurchaseOrders.aspx", .icon = "fas fa-clipboard-list"}
                }
            })

            menuData.Add(New With {
                .id = 5,
                .title = "التقارير",
                .url = "#",
                .icon = "fas fa-chart-pie",
                .children = New List(Of Object) From {
                    New With {.id = 51, .title = "التقارير المالية", .url = "/Pages/FinancialReports.aspx", .icon = "fas fa-chart-line"},
                    New With {.id = 52, .title = "تقارير المبيعات", .url = "/Pages/SalesReports.aspx", .icon = "fas fa-chart-bar"},
                    New With {.id = 53, .title = "تقارير المخازن", .url = "/Pages/InventoryReports.aspx", .icon = "fas fa-warehouse"}
                }
            })

            menuData.Add(New With {
                .id = 6,
                .title = "الإعدادات",
                .url = "/Pages/Settings.aspx",
                .icon = "fas fa-cog",
                .children = New List(Of Object)()
            })

            ' تحويل البيانات إلى JSON
            Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer()
            Dim menuJson As String = serializer.Serialize(menuData)

            ' إضافة البيانات إلى JavaScript
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

            ' إضافة بيانات افتراضية في حالة الخطأ
            Dim defaultMenuScript As String = String.Format(
                "(function() {{" & vbCrLf &
                "    window.LegacyMenuData = [{{" & vbCrLf &
                "        id: 1," & vbCrLf &
                "        title: 'الرئيسية'," & vbCrLf &
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

    ' إعداد معلومات الصفحة الحالية
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

    ' تطبيق الثيم من الكوكي
    Private Sub ApplyThemeFromCookie()
        ' اقرأ الكوكي
        Dim savedTheme As String = Nothing
        Dim themeCookie As HttpCookie = Request.Cookies("themePreference")

        If themeCookie IsNot Nothing Then
            savedTheme = themeCookie.Value
        End If

        ' طبّق الثيم لو فيه قيمة
        If Not String.IsNullOrEmpty(savedTheme) Then
            ' (اختياري) فلترة بسيطة لمنع قيم غريبة
            savedTheme = System.Text.RegularExpressions.Regex.Replace(savedTheme, "[^A-Za-z0-9\-_]", "")

            ' أضف كلاس للـ <body> مثل: theme-dark أو theme-light
            If Body IsNot Nothing Then
                Dim cur As String = Body.Attributes("class")
                If String.IsNullOrEmpty(cur) Then cur = String.Empty
                Body.Attributes("class") = (cur & " theme-" & savedTheme.ToLower()).Trim()
            End If

            ' (اختياري) حمّل ملف CSS للثيم
            ' Dim themeCss As String = String.Format("~/css/themes/{0}.css", savedTheme)
            ' Dim cssLink As New HtmlLink()
            ' cssLink.Href = ResolveUrl(themeCss)
            ' cssLink.Attributes("rel") = "stylesheet"
            ' cssLink.Attributes("type") = "text/css"
            ' Page.Header.Controls.Add(cssLink)
        End If
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreRender
        ' أي تعديلات قبل الريندر
    End Sub

    Protected Sub sm_ResolveScriptReference(ByVal sender As Object, ByVal e As ScriptReferenceEventArgs) Handles sm.ResolveScriptReference
        ' حل مشاكل مراجع السكريبت
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