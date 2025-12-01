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

Partial Public Class MainCopy1
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

        ' Ensure <body> has modern classes (safer than LiteralControl replacement)
        If Body IsNot Nothing Then
            Dim current As String = Body.Attributes("class")
            If current Is Nothing Then current = String.Empty
            Dim ensure As String = (current & " modern-navigation enhanced-theme").Trim()
            Body.Attributes("class") = ensure
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

        ' Publish username and culture to client for reliable UI (avoid DOM scraping)
        Try
            Dim uname As String = String.Empty
            If Context IsNot Nothing AndAlso Context.User IsNot Nothing AndAlso Context.User.Identity IsNot Nothing AndAlso Context.User.Identity.IsAuthenticated Then
                uname = Context.User.Identity.Name
            End If
            Dim culture As String = System.Threading.Thread.CurrentThread.CurrentUICulture.IetfLanguageTag
            Dim dir As String = If(System.Threading.Thread.CurrentThread.CurrentUICulture.TextInfo.IsRightToLeft, "rtl", "ltr")

            Dim unameEsc As String = (If(uname, String.Empty)).Replace("\", "\\").Replace("""", "\""")
            Dim cultureEsc As String = (If(culture, String.Empty)).Replace("\", "\\").Replace("""", "\""")
            Dim script As String =
                "(function(){try{" &
                "window.__username=\"" & unameEsc & " \ ";" &
                "window.__culture=\"" & cultureEsc & " \ ";" &
                "document&&document.documentElement&&document.documentElement.setAttribute('dir','" & dir & "');" &
                "}catch(e){}})();"
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "PublishUserCulture", script, True)
        Catch ex As Exception
            ' ignore
        End Try

        ' طبّق الثيم من الكوكي themePreference (كلاس + ملف CSS اختياري)
        ApplyThemeFromCookie()
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

            ' أضف كلاس للـ <body> مثل: theme-dark أو theme-light
            If Body IsNot Nothing Then
                Dim cur As String = Body.Attributes("class")
                If cur Is Nothing Then cur = String.Empty
                Body.Attributes("class") = (cur & " theme-" & savedTheme).Trim()
            End If

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

