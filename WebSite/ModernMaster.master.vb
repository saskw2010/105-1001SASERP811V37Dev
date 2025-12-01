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

Partial Public Class ModernMaster
    Inherits Global.System.Web.UI.MasterPage
    
    Public Shared MicrosoftJavaScript() As String = New String() {"MicrosoftAjax.js", "MicrosoftAjaxWebForms.js", "MicrosoftAjaxApplicationServices.js"}
    
    Shared Sub New()
        ApplicationServices.EnableMinifiedCss = True
    End Sub
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            ' تفعيل Script Localization إذا لم يكن Combined Script مُفعل
            If AquariumExtenderBase.EnableCombinedScript Then
                sm.EnableScriptLocalization = False
            End If
            
            ' إضافة CSS Class للصفحة
            ApplyPageCssClass()
            
            ' تحميل CKEditor
            LoadCKEditor()
            
            ' تطبيق التحسينات الحديثة
            ApplyModernEnhancements()
            
        Catch ex As Exception
            ' تسجيل الخطأ دون توقف التطبيق
            System.Diagnostics.Debug.WriteLine("ModernMaster Page_Load Error: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' تطبيق CSS Class للصفحة
    ''' Apply CSS class to the page
    ''' </summary>
    Private Sub ApplyPageCssClass()
        Try
            Dim pageCssClass As String = (Page.GetType().Name + " Loading Modern")
            
            ' البحث عن خاصية CssClass في الصفحة
            Dim cssClassProperty As PropertyInfo = Page.GetType().GetProperty("CssClass")
            If cssClassProperty IsNot Nothing Then
                Dim existingCssClass As String = CType(cssClassProperty.GetValue(Page, Nothing), String)
                If Not String.IsNullOrEmpty(existingCssClass) Then
                    pageCssClass = pageCssClass & " " & existingCssClass
                End If
            End If
            
            ' إضافة تصنيف العرض
            If Not pageCssClass.Contains("Wide") Then
                pageCssClass = pageCssClass & " Standard"
            End If
            
            ' تطبيق CSS Class على Form
            ApplyCssClassToForm(pageCssClass)
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("ApplyPageCssClass Error: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' تطبيق CSS Class على Form
    ''' Apply CSS class to the form
    ''' </summary>
    ''' <param name="cssClass">CSS Class المطلوب</param>
    Private Sub ApplyCssClassToForm(cssClass As String)
        Try
            If Page.Form IsNot Nothing AndAlso Page.Form.Controls.Count > 0 Then
                Dim firstControl As Control = Page.Form.Controls(0)
                
                If TypeOf firstControl Is LiteralControl Then
                    Dim literalControl As LiteralControl = CType(firstControl, LiteralControl)
                    If Not String.IsNullOrEmpty(cssClass) Then
                        literalControl.Text = Regex.Replace(literalControl.Text, 
                                                          "<div class=""modern-layout-wrapper"">", 
                                                          String.Format("<div class=""modern-layout-wrapper {0}"">", cssClass))
                    End If
                End If
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("ApplyCssClassToForm Error: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' تحميل CKEditor
    ''' Load CKEditor
    ''' </summary>
    Private Sub LoadCKEditor()
        Try
            Dim currentScriptManager As ScriptManager = ScriptManager.GetCurrent(Page)
            If currentScriptManager IsNot Nothing Then
                currentScriptManager.Scripts.Add(New ScriptReference("~/ckeditor/ckeditor.js"))
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("LoadCKEditor Error: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' تطبيق التحسينات الحديثة
    ''' Apply modern enhancements
    ''' </summary>
    Private Sub ApplyModernEnhancements()
        Try
            ' إضافة JavaScript للتحسينات الحديثة
            Dim modernScript As String = GetModernEnhancementScript()
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "ModernEnhancements", modernScript, False)

            ' تطبيق تحسينات على MenuExtender
            EnhanceMenuExtender()
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("ApplyModernEnhancements Error: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' تحسين MenuExtender
    ''' Enhance MenuExtender
    ''' </summary>
    Private Sub EnhanceMenuExtender()
        Try
            If Menu1 IsNot Nothing Then
                ' تطبيق إعدادات محسنة
                ' Note: HoverStyle and PopupPosition properties may not exist on AquariumExtenderBase
                ' Menu1.HoverStyle = AquariumExtenderBase.HoverStyle.Auto
                ' Menu1.PopupPosition = AquariumExtenderBase.PopupPosition.Left
                Menu1.ShowSiteActions = True
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("EnhanceMenuExtender Error: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' الحصول على JavaScript للتحسينات الحديثة
    ''' Get modern enhancement JavaScript
    ''' </summary>
    ''' <returns>JavaScript Code</returns>
    Private Function GetModernEnhancementScript() As String
        Return "<script type='text/javascript'>" & vbCrLf & _
        "document.addEventListener('DOMContentLoaded', function() {" & vbCrLf & _
        "    console.log('Modern Master Page enhancements loaded');" & vbCrLf & _
        "    " & vbCrLf & _
        "    // تحسين عرض القوائم" & vbCrLf & _
        "    enhanceMenuDisplay();" & vbCrLf & _
        "    " & vbCrLf & _
        "    // تحسين Navigation" & vbCrLf & _
        "    enhanceNavigation();" & vbCrLf & _
        "    " & vbCrLf & _
        "    // تحسين المظهر العام" & vbCrLf & _
        "    enhanceGeneralAppearance();" & vbCrLf & _
        "});" & vbCrLf & _
        "" & vbCrLf & _
        "function enhanceMenuDisplay() {" & vbCrLf & _
        "    try {" & vbCrLf & _
        "        // البحث عن عناصر القائمة وتحسينها" & vbCrLf & _
        "        const menuItems = document.querySelectorAll('.AspNet-Menu-Horizontal li, .AspNet-Menu li');" & vbCrLf & _
        "        menuItems.forEach(function(item) {" & vbCrLf & _
        "            item.classList.add('modern-menu-item');" & vbCrLf & _
        "        });" & vbCrLf & _
        "        " & vbCrLf & _
        "        // تحسين الروابط" & vbCrLf & _
        "        const menuLinks = document.querySelectorAll('.AspNet-Menu a');" & vbCrLf & _
        "        menuLinks.forEach(function(link) {" & vbCrLf & _
        "            link.classList.add('modern-menu-link');" & vbCrLf & _
        "        });" & vbCrLf & _
        "    } catch (e) {" & vbCrLf & _
        "        console.log('Menu enhancement error:', e);" & vbCrLf & _
        "    }" & vbCrLf & _
        "}" & vbCrLf & _
        "" & vbCrLf & _
        "function enhanceNavigation() {" & vbCrLf & _
        "    try {" & vbCrLf & _
        "        // تحسين Breadcrumb" & vbCrLf & _
        "        const breadcrumb = document.querySelector('.AspNet-SiteMapPath');" & vbCrLf & _
        "        if (breadcrumb) {" & vbCrLf & _
        "            breadcrumb.classList.add('modern-breadcrumb-enhanced');" & vbCrLf & _
        "        }" & vbCrLf & _
        "        " & vbCrLf & _
        "        // إضافة تأثيرات hover" & vbCrLf & _
        "        const navLinks = document.querySelectorAll('.modern-navigation a');" & vbCrLf & _
        "        navLinks.forEach(function(link) {" & vbCrLf & _
        "            link.addEventListener('mouseenter', function() {" & vbCrLf & _
        "                this.style.transform = 'translateY(-2px)';" & vbCrLf & _
        "            });" & vbCrLf & _
        "            " & vbCrLf & _
        "            link.addEventListener('mouseleave', function() {" & vbCrLf & _
        "                this.style.transform = 'translateY(0)';" & vbCrLf & _
        "            });" & vbCrLf & _
        "        });" & vbCrLf & _
        "    } catch (e) {" & vbCrLf & _
        "        console.log('Navigation enhancement error:', e);" & vbCrLf & _
        "    }" & vbCrLf & _
        "}" & vbCrLf & _
        "" & vbCrLf & _
        "function enhanceGeneralAppearance() {" & vbCrLf & _
        "    try {" & vbCrLf & _
        "        // إضافة تأثيرات التحميل" & vbCrLf & _
        "        setTimeout(function() {" & vbCrLf & _
        "            document.body.classList.remove('Loading');" & vbCrLf & _
        "            document.body.classList.add('Loaded');" & vbCrLf & _
        "        }, 500);" & vbCrLf & _
        "        " & vbCrLf & _
        "        // تحسين الجداول" & vbCrLf & _
        "        const tables = document.querySelectorAll('table');" & vbCrLf & _
        "        tables.forEach(function(table) {" & vbCrLf & _
        "            table.classList.add('modern-table');" & vbCrLf & _
        "        });" & vbCrLf & _
        "        " & vbCrLf & _
        "        // تحسين النماذج" & vbCrLf & _
        "        const forms = document.querySelectorAll('form');" & vbCrLf & _
        "        forms.forEach(function(form) {" & vbCrLf & _
        "            form.classList.add('modern-form');" & vbCrLf & _
        "        });" & vbCrLf & _
        "    } catch (e) {" & vbCrLf & _
        "        console.log('General enhancement error:', e);" & vbCrLf & _
        "    }" & vbCrLf & _
        "}" & vbCrLf & _
        "</script>"
    End Function
    
    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreRender
        Try
            ' تنفيذ العمليات قبل الرندر
            ApplyFinalEnhancements()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Page_PreRender Error: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' تطبيق التحسينات الأخيرة
    ''' Apply final enhancements
    ''' </summary>
    Private Sub ApplyFinalEnhancements()
        Try
            ' تحسين المحتوى النهائي
            OptimizeContent()
            
            ' إضافة Meta Tags
            AddMetaTags()
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("ApplyFinalEnhancements Error: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' تحسين المحتوى
    ''' Optimize content
    ''' </summary>
    Private Sub OptimizeContent()
        Try
            ' إخفاء العناصر الفارغة
            HideEmptyElements()
            
            ' تحسين العناصر المرئية
            EnhanceVisibleElements()
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("OptimizeContent Error: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' إخفاء العناصر الفارغة
    ''' Hide empty elements
    ''' </summary>
    Private Sub HideEmptyElements()
        Try
            Dim script As String = "<script type='text/javascript'>" & vbCrLf & _
            "document.addEventListener('DOMContentLoaded', function() {" & vbCrLf & _
            "    // إخفاء العناصر التي تحتوي على placeholder فقط" & vbCrLf & _
            "    const placeholders = document.querySelectorAll('.placeholder');" & vbCrLf & _
            "    placeholders.forEach(function(el) {" & vbCrLf & _
            "        if (el.textContent.trim() === '') {" & vbCrLf & _
            "            el.style.display = 'none';" & vbCrLf & _
            "        }" & vbCrLf & _
            "    });" & vbCrLf & _
            "});" & vbCrLf & _
            "</script>"
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "HideEmptyElements", script, False)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("HideEmptyElements Error: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' تحسين العناصر المرئية
    ''' Enhance visible elements
    ''' </summary>
    Private Sub EnhanceVisibleElements()
        Try
            ' إضافة تحسينات بصرية
            Dim enhancementScript As String = "<script type='text/javascript'>" & vbCrLf & _
            "document.addEventListener('DOMContentLoaded', function() {" & vbCrLf & _
            "    // تحسين الأزرار" & vbCrLf & _
            "    const buttons = document.querySelectorAll('input[type=""button""], input[type=""submit""], button');" & vbCrLf & _
            "    buttons.forEach(function(btn) {" & vbCrLf & _
            "        if (!btn.classList.contains('modern-btn')) {" & vbCrLf & _
            "            btn.classList.add('modern-btn');" & vbCrLf & _
            "        }" & vbCrLf & _
            "    });" & vbCrLf & _
            "    " & vbCrLf & _
            "    // تحسين حقول الإدخال" & vbCrLf & _
            "    const inputs = document.querySelectorAll('input[type=""text""], input[type=""email""], input[type=""password""], textarea, select');" & vbCrLf & _
            "    inputs.forEach(function(input) {" & vbCrLf & _
            "        if (!input.classList.contains('modern-input')) {" & vbCrLf & _
            "            input.classList.add('modern-input');" & vbCrLf & _
            "        }" & vbCrLf & _
            "    });" & vbCrLf & _
            "});" & vbCrLf & _
            "</script>"
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "EnhanceVisibleElements", enhancementScript, False)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("EnhanceVisibleElements Error: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' إضافة Meta Tags
    ''' Add meta tags
    ''' </summary>
    Private Sub AddMetaTags()
        Try
            ' إضافة Meta Tags للـ SEO والمظهر
            If Page.Header IsNot Nothing Then
                ' Viewport meta tag (إذا لم يكن موجود)
                Dim viewportExists As Boolean = False
                For Each control As Control In Page.Header.Controls
                    If TypeOf control Is HtmlMeta Then
                        Dim meta As HtmlMeta = CType(control, HtmlMeta)
                        If meta.Name = "viewport" Then
                            viewportExists = True
                            Exit For
                        End If
                    End If
                Next
                
                If Not viewportExists Then
                    Dim viewportMeta As New HtmlMeta()
                    viewportMeta.Name = "viewport"
                    viewportMeta.Content = "width=device-width, initial-scale=1.0"
                    Page.Header.Controls.AddAt(0, viewportMeta)
                End If
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("AddMetaTags Error: " & ex.Message)
        End Try
    End Sub
    
    Protected Sub sm_ResolveScriptReference(ByVal sender As Object, ByVal e As ScriptReferenceEventArgs) Handles sm.ResolveScriptReference
        Try
            ' معالجة Script References
            ProcessScriptReference(e)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("sm_ResolveScriptReference Error: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' معالجة Script Reference
    ''' Process script reference
    ''' </summary>
    ''' <param name="e">Script Reference Event Args</param>
    Private Sub ProcessScriptReference(e As ScriptReferenceEventArgs)
        Try
            ' يمكن إضافة منطق معالجة Scripts هنا إذا لزم الأمر
            ' مثل تحديد مسارات Scripts أو تطبيق تحسينات
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("ProcessScriptReference Error: " & ex.Message)
        End Try
    End Sub
    
End Class
