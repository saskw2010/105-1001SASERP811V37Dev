Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class CaCrstylBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "DownloadFile" and argument that matches "ExternalDoc".
        ''' </summary>
        <Rule("cacrstylr101")>  _
        Public Sub cacrstylr101Implementation(ByVal styl_No As Nullable(Of Long), ByVal styl_Nm As String, ByVal styl_Nme As String, ByVal externalDocFileName As String, ByVal externalDocLength As Nullable(Of Long), ByVal externalDocContentType As String, ByVal modifiedBy As String, ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdOn As Nullable(Of DateTime), ByVal codeflag As String, ByVal madein As String)
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
