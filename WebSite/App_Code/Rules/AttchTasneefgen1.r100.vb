Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class AttchTasneefgen1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "SQL" and argument that matches "Next".
        ''' </summary>
        <Rule("r100")>  _
        Public Sub r100Implementation(ByVal tasneefcode1 As Nullable(Of Long), ByVal tasneefDesc1 As String, ByVal tasneefDesc2 As String, ByVal modifiedBy As String, ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
            HttpContext.Current.Session.Add("Tasneefcode1", tasneefcode1)
            Result.NavigateUrl = "~/Pages/Attach.aspx?Tasneefcode1=" & tasneefcode1.ToString()


        End Sub
    End Class
End Namespace
