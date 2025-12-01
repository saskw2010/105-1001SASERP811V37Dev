Imports AjaxControlToolkit
Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Configuration
Imports System.Data
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts

Namespace eZee.Web
    
    <TargetControlType(GetType(HtmlGenericControl)),  _
     ToolboxItem(false)>  _
    Public Class MembershipManagerExtender
        Inherits AquariumExtenderBase
        
        Public Sub New()
            MyBase.New("Web.MembershipManager")
        End Sub
        
        Protected Overrides Sub ConfigureDescriptor(ByVal descriptor As ScriptBehaviorDescriptor)
        End Sub
        
        Protected Overrides Sub ConfigureScripts(ByVal scripts As List(Of ScriptReference))
            If EnableCombinedScript Then
                Return
            End If
            scripts.Add(CreateScriptReference("~/Scripts/Web.MembershipResources.js"))
            scripts.Add(CreateScriptReference("~/Scripts/Web.MembershipManager.js"))
            scripts.AddRange(ScriptObjectBuilder.GetScriptReferences(GetType(TabContainer)))
        End Sub
    End Class
End Namespace
