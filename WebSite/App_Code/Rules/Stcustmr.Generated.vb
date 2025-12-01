Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class StcustmrBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("Stcustmr", RowKind.New)>  _
        Public Sub BuildNewStcustmr()
            UpdateFieldValue("blacklist", 0)
        End Sub
    End Class
End Namespace
