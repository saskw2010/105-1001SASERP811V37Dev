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
Imports Telerik.Web.UI

Partial Public Class Mainy
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
        ScriptManager.GetCurrent(Page).Scripts.Add(New ScriptReference("~/ckeditor/ckeditor.js"))
        Dim hostName As String = HttpContext.Current.Request.Url.Host
        lblDomainName.Text = "Current domain name: " & hostName
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreRender
    End Sub

    Protected Sub sm_ResolveScriptReference(ByVal sender As Object, ByVal e As ScriptReferenceEventArgs) Handles sm.ResolveScriptReference
    End Sub
    Private Sub RadMenu1_ItemDataBound(sender As Object, e As RadMenuEventArgs) Handles RadMenu1.ItemDataBound
        e.Item.ToolTip = translatemeyamosso.GetResourceValuemosso(CStr(DataBinder.Eval(e.Item.DataItem, "title")))
        e.Item.Text = translatemeyamosso.GetResourceValuemosso(CStr(DataBinder.Eval(e.Item.DataItem, "title")))

        'Dim spage As String = Path.GetFileName(e.Item.NavigateUrl)
        'If Right(spage, 5) = ".aspx" Then
        '    spage = Left(spage, Len(spage) - 5)
        'End If
        'e.Item.Value = spage
        'e.Item.NavigateUrl = ""
    End Sub
End Class
