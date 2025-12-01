Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class mrtcontrollerNameBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Custom" and argument that matches "Designthisreport".
        ''' </summary>
        <Rule("r101Designthisreport")>  _
        Public Sub r101DesignthisreportImplementation(ByVal controllerNameid As Nullable(Of Long), ByVal controllerName As String, ByVal reportCode As String, ByVal notes As String)
            'This is the placeholder for method implementation.
			result.NavigateUrl = "~/pages/webreportviwerDyn.aspx?reportquery=" & reportCode & "&controllername=" & controllerName & 
			"&filterarr=&viewname=grid1&designflag=true"
			''"pages/webreportviwerDyn.aspx?reportquery=mrtajrContracts1100001&controllername=ajarContracts1&filterarr=&viewname=grid1&designflag=true"
        End Sub
    End Class
End Namespace
