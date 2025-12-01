Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.Services
Imports System.Web.Script.Services
Imports System.Web.Caching

' DTO: شكل العقدة اللي هترجع للـ front-end
Public Class MenuNodeDto
    Public Property Title As String
    Public Property Url As String
    Public Property BadgeText As String      ' اختياري: نص البادج
    Public Property BadgeType As String      ' اختياري: info|success|warning|danger|neutral
    Public Property Icon As String           ' اختياري: "fa-solid fa-users"
    Public Property Children As List(Of MenuNodeDto)

    Public Sub New()
        Children = New List(Of MenuNodeDto)()
    End Sub
End Class

Partial Public Class MenuApi
    Inherits System.Web.UI.Page

    ' GETMENU: استدعِها بـ fetch(".../Pages/MenuApi.aspx/GetMenuTree", {method:"POST", headers:{...}, body:"{}"})
    <WebMethod()>
    <ScriptMethod(ResponseFormat:=ResponseFormat.Json, UseHttpGet:=False)>
    Public Shared Function GetMenuTree() As Object
        Dim ctx As HttpContext = HttpContext.Current

        Dim version As String = GetMenuVersion(ctx)
        Dim userName As String =
            If(ctx IsNot Nothing AndAlso ctx.User IsNot Nothing AndAlso
               ctx.User.Identity IsNot Nothing AndAlso ctx.User.Identity.IsAuthenticated,
               ctx.User.Identity.Name, "anon")

        Dim cacheKey As String = "MenuTree:" & userName & ":" & version
        Dim items As List(Of MenuNodeDto) = TryCast(HttpRuntime.Cache(cacheKey), List(Of MenuNodeDto))

        If items Is Nothing Then
            items = New List(Of MenuNodeDto)()

            Dim root As SiteMapNode = System.Web.SiteMap.RootNode
            If root IsNot Nothing Then
                For Each n As SiteMapNode In root.ChildNodes
                    If System.Web.SiteMap.Provider.IsAccessibleToUser(ctx, n) Then
                        items.Add(BuildNode(n, ctx))
                    End If
                Next
            End If

            ' اربط الكاش بملف web.sitemap لو موجود (عشان أي تعديل يكسر الكاش تلقائيًا)
            Dim siteMapPath As String = ctx.Server.MapPath("~/web.sitemap")
            If IO.File.Exists(siteMapPath) Then
                Dim dep As New CacheDependency(siteMapPath)
                HttpRuntime.Cache.Insert(cacheKey, items, dep, DateTime.UtcNow.AddHours(4), Cache.NoSlidingExpiration)
            Else
                HttpRuntime.Cache.Insert(cacheKey, items, Nothing, DateTime.UtcNow.AddHours(2), Cache.NoSlidingExpiration)
            End If
        End If

        Return New With {
            .version = version,
            .items = items
        }
    End Function

    ' يبني العقدة الحالية + الأطفال (recursive)
    Private Shared Function BuildNode(n As SiteMapNode, ctx As HttpContext) As MenuNodeDto
        Dim node As New MenuNodeDto()
        node.Title = If(n.Title, If(n.Description, n.Key))
        node.Url = If(String.IsNullOrWhiteSpace(n.Url), Nothing, VirtualPathUtility.ToAbsolute(n.Url, ctx.Request.ApplicationPath))
        node.BadgeText = SafeAttr(n, "badgeText")
        node.BadgeType = SafeAttr(n, "badgeType")
        node.Icon = SafeAttr(n, "icon")

        If n.HasChildNodes Then
            For Each c As SiteMapNode In n.ChildNodes
                If System.Web.SiteMap.Provider.IsAccessibleToUser(ctx, c) Then
                    node.Children.Add(BuildNode(c, ctx))
                End If
            Next
        End If

        Return node
    End Function

    ' قراءة Attribute بأمان بدون لمس .Attributes (اللي ممكن تكون Protected)
    Private Shared Function SafeAttr(n As SiteMapNode, key As String) As String
        Try
            Dim v As String = n(key) ' الإنديكسر العام
            If String.IsNullOrEmpty(v) Then Return Nothing
            Return v
        Catch
            Return Nothing
        End Try
    End Function

    ' نسخة المنيو = آخر تعديل لملف web.sitemap (لو موجود)
    Private Shared Function GetMenuVersion(ctx As HttpContext) As String
        Try
            Dim path As String = ctx.Server.MapPath("~/web.sitemap")
            If IO.File.Exists(path) Then
                Return IO.File.GetLastWriteTimeUtc(path).ToString("yyyyMMddHHmmss")
            End If
        Catch
            ' تجاهل أي أخطاء ملفية
        End Try
        Return "static-1"
    End Function

End Class
