Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schvchdlydetailregBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schvchdlydetailreg", RowKind.New)>  _
        Public Sub BuildNewschvchdlydetailreg()
            UpdateFieldValue("Trsd_Dt", DateTime.now())
        End Sub
    End Class
End Namespace
