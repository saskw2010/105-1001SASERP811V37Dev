Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schvchdlydetailreg2BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schvchdlydetailreg2", RowKind.New)>  _
        Public Sub BuildNewschvchdlydetailreg2()
            UpdateFieldValue("Trsd_Dt", DateTime.now())
        End Sub
    End Class
End Namespace
