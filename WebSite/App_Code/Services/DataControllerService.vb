Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Web
Imports System.Web.Script.Services
Imports System.Web.Services

Namespace eZee.Services
    
    <WebService([Namespace]:="http://www.codeontime.com/productsdaf.aspx"),  _
     WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1),  _
     ScriptService()>  _
    Public Class DataControllerService
        Inherits System.Web.Services.WebService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Protected ReadOnly Property Permalinks() As List(Of String())
            Get
                Dim links As List(Of String()) = CType(Session("Permalinks"),List(Of String()))
                If (links Is Nothing) Then
                    links = New List(Of String())()
                    Session("Permalinks") = links
                End If
                Return links
            End Get
        End Property
        
        <WebMethod(EnableSession:=true),  _
         ScriptMethod()>  _
        Public Function GetPage(ByVal controller As String, ByVal view As String, ByVal request As PageRequest) As ViewPage
            Return ControllerFactory.CreateDataController().GetPage(controller, view, request)
        End Function
        
        <WebMethod(EnableSession:=true),  _
         ScriptMethod()>  _
        Public Function GetListOfValues(ByVal controller As String, ByVal view As String, ByVal request As DistinctValueRequest) As Object()
            Return ControllerFactory.CreateDataController().GetListOfValues(controller, view, request)
        End Function
        
        <WebMethod(EnableSession:=true),  _
         ScriptMethod()>  _
        Public Function Execute(ByVal controller As String, ByVal view As String, ByVal args As ActionArgs) As ActionResult
            Return ControllerFactory.CreateDataController().Execute(controller, view, args)
        End Function
        
        <WebMethod(EnableSession:=true),  _
         ScriptMethod()>  _
        Public Function GetCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
            Return ControllerFactory.CreateAutoCompleteManager().GetCompletionList(prefixText, count, contextKey)
        End Function
        
        Protected Function FindPermalink(ByVal link As String) As String()
            For Each entry() As String in Permalinks
                If (entry(0) = link) Then
                    Return entry
                End If
            Next
            Return Nothing
        End Function
        
        <WebMethod(EnableSession:=true),  _
         ScriptMethod()>  _
        Public Sub SavePermalink(ByVal link As String, ByVal html As String)
            Dim permalink() As String = FindPermalink(link)
            If Permalinks.Contains(permalink) Then
                Permalinks.Remove(permalink)
            End If
            If Not (String.IsNullOrEmpty(html)) Then
                Permalinks.Insert(0, New String() {link, html})
            Else
                If (Permalinks.Count > 0) Then
                    Permalinks.RemoveAt(0)
                End If
            End If
            Do While (Permalinks.Count > 10)
                Permalinks.RemoveAt((Permalinks.Count - 1))
            Loop
        End Sub
        
        <WebMethod(),  _
         ScriptMethod()>  _
        Public Function EncodePermalink(ByVal link As String, ByVal rooted As Boolean) As String
            Dim enc As StringEncryptor = New StringEncryptor()
            If rooted Then
                Dim appPath As String = Context.Request.ApplicationPath
                If appPath.Equals("/") Then
                    appPath = String.Empty
                End If
                Return String.Format("{0}://{1}{2}/default.aspx?_link={3}", Context.Request.Url.Scheme, Context.Request.Url.Authority, appPath, HttpUtility.UrlEncode(enc.Encrypt(link)))
            Else
                Dim linkSegments() As String = link.Split(Global.Microsoft.VisualBasic.ChrW(63))
                Dim arguments As String = String.Empty
                If (linkSegments.Length > 1) Then
                    arguments = linkSegments(1)
                End If
                Return String.Format("{0}?_link={1}", linkSegments(0), HttpUtility.UrlEncode(enc.Encrypt(arguments)))
            End If
        End Function
        
        <WebMethod(EnableSession:=true),  _
         ScriptMethod()>  _
        Public Function ListAllPermalinks() As String()()
            Return Permalinks.ToArray()
        End Function
        
        <WebMethod(EnableSession:=true),  _
         ScriptMethod()>  _
        Public Function Login(ByVal username As String, ByVal password As String, ByVal createPersistentCookie As Boolean) As Boolean
            Return ApplicationServices.Login(username, password, createPersistentCookie)
        End Function
        
        <WebMethod(EnableSession:=true),  _
         ScriptMethod()>  _
        Public Sub Logout()
            ApplicationServices.Logout()
        End Sub
        
        <WebMethod(EnableSession:=true),  _
         ScriptMethod()>  _
        Public Function Roles() As String()
            Return ApplicationServices.Roles()
        End Function
    End Class
End Namespace
