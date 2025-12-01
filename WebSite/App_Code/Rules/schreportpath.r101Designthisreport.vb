Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schreportpathBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Custom" and argument that matches "Designthisreport".
        ''' </summary>
        <Rule("r101Designthisreport")>  _
        Public Sub r101DesignthisreportImplementation(ByVal controllerNameid As Nullable(Of Long), ByVal controllerName As String, ByVal reportCode As String, ByVal modifiedBy As String, ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdOn As Nullable(Of DateTime), ByVal notes As String, ByVal notes1 As String, ByVal mynotes As String)
            'This is the placeholder for method implementation.
			result.NavigateUrl = "~/pages/webreportviwerDyn.aspx?reportquery=" & reportCode & "&controllername=" & controllerName & 
			"&filterarr=&viewname=grid1&designflag=true"
			
        End Sub
    End Class
End Namespace
