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
            Dim userRole As String = "مستخدم"

            Dim currentUser = HttpContext.Current.User
            If currentUser.Identity.IsAuthenticated Then
                userName = currentUser.Identity.Name
                If String.IsNullOrEmpty(userName) Then
                    userName = "المستخدم"
                End If

                ' محاولة الحصول على الدور
                Try
                    If currentUser.IsInRole("Admin") Then
                        userRole = "مدير النظام"
                    ElseIf currentUser.IsInRole("Manager") Then
                        userRole = "مدير"
                    ElseIf currentUser.IsInRole("User") Then
                        userRole = "مستخدم"
                    Else
                        userRole = "مستخدم"
                    End If
                Catch ex As Exception
                    userRole = "مستخدم"
                End Try
            End If

            ' إضافة البيانات إلى JavaScript
            Dim userInfoScript As String = String.Format(
                "(function() {{" & vbCrLf &
                "    window.LegacyMenuUserInfo = {{" & vbCrLf &
                "        userName: '{0}'," & vbCrLf &
                "        userRole: '{1}'," & vbCrLf &
                "        isAuthenticated: {2}," & vbCrLf &
                "        currentCulture: '{3}'" & vbCrLf &
                "    }};" & vbCrLf &
                "}})();",
                userName.Replace("'", "\'"),
                userRole.Replace("'", "\'"),
                If(HttpContext.Current.User.Identity.IsAuthenticated, "true", "false"),
                System.Globalization.CultureInfo.CurrentUICulture.Name
            )

            Page.ClientScript.RegisterStartupScript(Me.GetType(), "LegacyMenuUserInfo", userInfoScript, True)

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
                .id = "home",
                .title = "الرئيسية",
                .description = "الصفحة الرئيسية للنظام",
                .icon = "fas fa-home",
                .url = "/Default.aspx",
                .hasChildren = False
            })

            ' المخازن
            Dim inventoryItems As New List(Of Object)()
            inventoryItems.Add(New With {.title = "إدارة المخازن", .url = "/Pages/Inventory.aspx", .icon = "fas fa-warehouse"})
            inventoryItems.Add(New With {.title = "جرد المخزون", .url = "/Pages/Stock.aspx", .icon = "fas fa-cubes"})
            inventoryItems.Add(New With {.title = "تحويلات", .url = "/Pages/Transfer.aspx", .icon = "fas fa-exchange-alt"})

            menuData.Add(New With {
                .id = "inventory",
                .title = "المخازن",
                .description = "إدارة المنتجات والمخزون",
                .icon = "fas fa-boxes",
                .url = "#",
                .hasChildren = True,
                .children = inventoryItems,
                .childrenCount = inventoryItems.Count
            })

            ' المبيعات
            Dim salesItems As New List(Of Object)()
            salesItems.Add(New With {.title = "فواتير المبيعات", .url = "/Pages/Sales.aspx", .icon = "fas fa-chart-line"})
            salesItems.Add(New With {.title = "العملاء", .url = "/Pages/Customers.aspx", .icon = "fas fa-users"})
            salesItems.Add(New With {.title = "عروض الأسعار", .url = "/Pages/Quotes.aspx", .icon = "fas fa-file-contract"})

            menuData.Add(New With {
                .id = "sales",
                .title = "المبيعات",
                .description = "إدارة عمليات البيع",
                .icon = "fas fa-shopping-cart",
                .url = "#",
                .hasChildren = True,
                .children = salesItems,
                .childrenCount = salesItems.Count
            })

            ' المشتريات
            Dim purchaseItems As New List(Of Object)()
            purchaseItems.Add(New With {.title = "فواتير المشتريات", .url = "/Pages/Purchases.aspx", .icon = "fas fa-shopping-bag"})
            purchaseItems.Add(New With {.title = "الموردين", .url = "/Pages/Suppliers.aspx", .icon = "fas fa-truck-loading"})
            purchaseItems.Add(New With {.title = "طلبات الشراء", .url = "/Pages/Orders.aspx", .icon = "fas fa-clipboard-list"})

            menuData.Add(New With {
                .id = "purchases",
                .title = "المشتريات",
                .description = "إدارة عمليات الشراء",
                .icon = "fas fa-truck",
                .url = "#",
                .hasChildren = True,
                .children = purchaseItems,
                .childrenCount = purchaseItems.Count
            })

            ' التقارير
            Dim reportsItems As New List(Of Object)()
            reportsItems.Add(New With {.title = "التقارير المالية", .url = "/Pages/FinancialReports.aspx", .icon = "fas fa-chart-bar"})
            reportsItems.Add(New With {.title = "تقارير المبيعات", .url = "/Pages/SalesReports.aspx", .icon = "fas fa-chart-line"})
            reportsItems.Add(New With {.title = "تقارير المخازن", .url = "/Pages/InventoryReports.aspx", .icon = "fas fa-warehouse"})

            menuData.Add(New With {
                .id = "reports",
                .title = "التقارير",
                .description = "التقارير والإحصائيات",
                .icon = "fas fa-chart-pie",
                .url = "#",
                .hasChildren = True,
                .children = reportsItems,
                .childrenCount = reportsItems.Count
            })

            ' إعدادات
            menuData.Add(New With {
                .id = "settings",
                .title = "الإعدادات",
                .description = "إعدادات النظام",
                .icon = "fas fa-cog",
                .url = "/Pages/Settings.aspx",
                .hasChildren = False
            })

            ' تحويل البيانات إلى JSON
            Dim menuJson As String = Newtonsoft.Json.JsonConvert.SerializeObject(menuData)

            ' إضافة البيانات إلى JavaScript
            Dim menuScript As String = String.Format(
                "(function() {{" & vbCrLf &
                "    window.LegacyMenuData = {0};" & vbCrLf &
                "    console.log('Legacy menu data loaded:', window.LegacyMenuData);" & vbCrLf &
                "}})();",
                menuJson
            )

            Page.ClientScript.RegisterStartupScript(Me.GetType(), "LegacyMenuData", menuScript, True)

        Catch ex As Exception
            ' Log error if needed
            System.Diagnostics.Debug.WriteLine("Error setting up legacy menu data: " & ex.Message)

            ' إضافة بيانات افتراضية في حالة الخطأ
            Dim fallbackScript As String = String.Format(
                "(function() {{" & vbCrLf &
                "    window.LegacyMenuData = [{{" & vbCrLf &
                "        id: 'home'," & vbCrLf &
                "        title: 'الرئيسية'," & vbCrLf &
                "        description: 'الصفحة الرئيسية للنظام'," & vbCrLf &
                "        icon: 'fas fa-home'," & vbCrLf &
                "        url: '/Default.aspx'," & vbCrLf &
                "        hasChildren: false" & vbCrLf &
                "    }}];" & vbCrLf &
                "    console.log('Legacy menu fallback data loaded');" & vbCrLf &
                "}})();"
            )

            Page.ClientScript.RegisterStartupScript(Me.GetType(), "LegacyMenuDataFallback", fallbackScript, True)
        End Try
    End Sub

    ' إعداد معلومات الصفحة الحالية
    Private Sub SetupCurrentPageInfo()
        Try
            Dim currentPage As String = Request.Url.AbsolutePath
            Dim pageTitle As String = "SKYsaas ERP"

            ' محاولة الحصول على عنوان الصفحة
            If Page.Title IsNot Nothing AndAlso Not String.IsNullOrEmpty(Page.Title) Then
                pageTitle = Page.Title
            Else
                ' تحديد العنوان بناءً على المسار
                If currentPage.ToLower().Contains("default") Then
                    pageTitle = "الرئيسية - SKYsaas ERP"
                ElseIf currentPage.ToLower().Contains("inventory") Then
                    pageTitle = "المخازن - SKYsaas ERP"
                ElseIf currentPage.ToLower().Contains("sales") Then
                    pageTitle = "المبيعات - SKYsaas ERP"
                ElseIf currentPage.ToLower().Contains("purchases") Then
                    pageTitle = "المشتريات - SKYsaas ERP"
                ElseIf currentPage.ToLower().Contains("reports") Then
                    pageTitle = "التقارير - SKYsaas ERP"
                ElseIf currentPage.ToLower().Contains("settings") Then
                    pageTitle = "الإعدادات - SKYsaas ERP"
                End If
            End If

            ' إضافة البيانات إلى JavaScript
            Dim pageInfoScript As String = String.Format(
                "(function() {{" & vbCrLf &
                "    window.LegacyMenuPageInfo = {{" & vbCrLf &
                "        currentPage: '{0}'," & vbCrLf &
                "        pageTitle: '{1}'," & vbCrLf &
                "        fullUrl: '{2}'" & vbCrLf &
                "    }};" & vbCrLf &
                "}})();",
                currentPage.Replace("'", "\'"),
                pageTitle.Replace("'", "\'"),
                Request.Url.AbsoluteUri.Replace("'", "\'")
            )

            Page.ClientScript.RegisterStartupScript(Me.GetType(), "LegacyMenuPageInfo", pageInfoScript, True)

        Catch ex As Exception
            ' Log error if needed
            System.Diagnostics.Debug.WriteLine("Error setting up current page info: " & ex.Message)
        End Try
    End Sub

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

            ' Add theme class to body
            Try
                Dim bodyControl As HtmlGenericControl = TryCast(Me.Page.Master.FindControl("Body"), HtmlGenericControl)
                If bodyControl IsNot Nothing Then
                    Dim cur As String = bodyControl.Attributes("class")
                    If String.IsNullOrEmpty(cur) Then cur = String.Empty
                    bodyControl.Attributes("class") = (cur & " theme-" & savedTheme).Trim()
                End If
            Catch ex As Exception
                ' Log error if needed
                System.Diagnostics.Debug.WriteLine("Error applying theme: " & ex.Message)
            End Try

            ' (اختياري) لو عندك ملف CSS لكل ثيم، ضيفه للهيدر
            If Page.Header IsNot Nothing Then
                Dim cssPath As String = ResolveUrl("~/themes/" & savedTheme & ".css")
                Dim link As New HtmlLink()
                link.Href = cssPath
                link.Attributes("rel") = "stylesheet"
                link.Attributes("type") = "text/css"
                Page.Header.Controls.Add(link)
            End If
        End If
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreRender
        ' أي تعديلات قبل الريندر
    End Sub

    Protected Sub sm_ResolveScriptReference(ByVal sender As Object, ByVal e As ScriptReferenceEventArgs) Handles sm.ResolveScriptReference
        ' لو عايز تتحكم في مسارات السكربتات الافتراضية
        ' (اتركها فاضية لو مش محتاج)
    End Sub
End Class