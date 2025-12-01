<%@ WebHandler Language="VB" Class="MenuService" %>

Imports System
Imports System.Web
Imports System.Web.Script.Serialization
Imports System.Text
Imports System.Collections.Generic

Public Class MenuService : Implements IHttpHandler

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return True
        End Get
    End Property

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "application/json; charset=utf-8"
        context.Response.Cache.SetCacheability(HttpCacheability.NoCache)
        context.Response.Cache.SetNoStore()

        Try
            Dim depth As Integer = 4
            Dim serializer As New JavaScriptSerializer()

            ' Check if SiteMap is available
            If System.Web.SiteMap.Provider Is Nothing Then
                context.Response.Write("{""items"":[], ""error"":""No SiteMap provider configured""}")
                Return
            End If

            ' Build tree from SiteMapProvider (used by TargetControlID="PageMenuBar")
            Dim root As SiteMapNode = System.Web.SiteMap.RootNode
            If root Is Nothing Then
                context.Response.Write("{""items"":[], ""error"":""No SiteMap root node found""}")
                Return
            End If

            ' Find the real starting node used for PageMenuBar: ShowStartingNode=False in master
            ' So we return the first level children of root as level-1 items (no level-0)
            Dim items As New List(Of Object)()
            If root.ChildNodes IsNot Nothing Then
                For Each node As SiteMapNode In root.ChildNodes
                    Dim item As Object = NodeToObject(node, 1, depth)
                    If item IsNot Nothing Then items.Add(item)
                Next
            End If

            Dim result = New With { .items = items, .version = 1, .timestamp = DateTime.UtcNow, .count = items.Count }
            context.Response.Write(serializer.Serialize(result))
        Catch ex As Exception
            context.Response.StatusCode = 500
            Dim errorMsg As String = ex.Message
            If ex.InnerException IsNot Nothing Then
                errorMsg = errorMsg & " Inner: " & ex.InnerException.Message
            End If
            context.Response.Write("{""error"":""" & EscapeJsonString(errorMsg) & """, ""stackTrace"":""" & EscapeJsonString(ex.StackTrace) & """}")
        End Try
    End Sub

    Private Function NodeToObject(node As SiteMapNode, level As Integer, maxDepth As Integer) As Object
        If level > maxDepth OrElse node Is Nothing Then Return Nothing

        Try
            ' Security trim: only include nodes the current user can see
            If Not node.IsAccessibleToUser(HttpContext.Current) Then Return Nothing
        Catch
            ' If security check fails, include the node anyway
        End Try

        Dim children As New List(Of Object)()
        If node.ChildNodes IsNot Nothing AndAlso node.ChildNodes.Count > 0 AndAlso level < maxDepth Then
            For Each child As SiteMapNode In node.ChildNodes
                Dim c = NodeToObject(child, level + 1, maxDepth)
                If c IsNot Nothing Then children.Add(c)
            Next
        End If

        Dim nodeTitle As String = ""
        If Not String.IsNullOrEmpty(node.Title) Then
            nodeTitle = node.Title
        ElseIf Not String.IsNullOrEmpty(node.Description) Then
            nodeTitle = node.Description
        Else
            nodeTitle = "Menu Item"
        End If

        Dim nodeUrl As String = "#"
        If Not String.IsNullOrEmpty(node.Url) Then
            nodeUrl = ResolveUrl(node.Url)
        End If

        Return New With {
            .title = nodeTitle,
            .url = nodeUrl,
            .level = level,
            .children = children
        }
    End Function

    Private Function ResolveUrl(url As String) As String
        If String.IsNullOrEmpty(url) Then Return "#"
        If url.StartsWith("http", StringComparison.OrdinalIgnoreCase) OrElse url.StartsWith("javascript:") Then
            Return url
        End If
        Try
            Return VirtualPathUtility.ToAbsolute(url)
        Catch
            Return url
        End Try
    End Function

    Private Function EscapeJsonString(s As String) As String
        If String.IsNullOrEmpty(s) Then Return ""
        Return s.Replace("\", "\\").Replace("""", "\""").Replace(vbCrLf, "\n").Replace(vbCr, "\n").Replace(vbLf, "\n")
    End Function

End Class
