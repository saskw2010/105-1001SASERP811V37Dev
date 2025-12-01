Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schvchdlydetailregTrsNoBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schvchdlydetailregTrsNo", RowKind.New)>  _
        Public Sub BuildNewschvchdlydetailregTrsNo()
            UpdateFieldValue("Trs_Dt", DateTime.now())
        End Sub
    End Class
End Namespace
