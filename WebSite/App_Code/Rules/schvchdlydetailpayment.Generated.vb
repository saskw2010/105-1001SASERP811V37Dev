Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class handschvchdlydetailpayment
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schvchdlydetailpayment", RowKind.New)>  _
        Public Sub BuildNewschvchdlydetailpayment()
            UpdateFieldValue("Pymnt_No", 1)
            UpdateFieldValue("moneypaidto", 0)
        End Sub
    End Class
End Namespace
