Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security
Imports System.Drawing
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Xml.XPath
Namespace eZee.Rules
    
    Partial Public Class mrtcontrollerNameBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Custom" and argument that matches "deletereportwithfile".
        ''' </summary>
        <Rule("deletereportwithfile")>  _
        Public Sub deletereportwithfileImplementation(ByVal controllerNameid As Nullable(Of Long), ByVal controllerName As String, ByVal reportCode As String, ByVal notes As String, ByVal notes1 As String, ByVal mynotes As String, ByVal modifiedBy As String, ByVal modifiedByUserId As Nullable(Of System.Guid), ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdById As Nullable(Of System.Guid), ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
			Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
			If (System.IO.File.Exists(appDirectory + "\Reports\" + reportCode + ".mrt")) Then
			System.IO.File.Delete(appDirectory + "\Reports\" + reportCode + ".mrt")
			end if
			
        End Sub
    End Class
End Namespace
