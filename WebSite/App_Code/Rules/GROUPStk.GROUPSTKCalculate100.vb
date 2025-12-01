Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class GROUPStkBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' Rule "GROUPSTK" implementation:
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("GROUPSTKCalculate100")>  _
        Public Sub GROUPSTKCalculate100Implementation(ByVal iD As Nullable(Of Long), ByVal mASTERNOD As Nullable(Of Long), ByVal mASTERNODID_USER As String, ByVal iD_USER As String, ByVal gROUPA As String, ByVal gROUPE As String, ByVal modifiedBy As String, ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
