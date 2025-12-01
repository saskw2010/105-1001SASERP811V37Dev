Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schglvchdlydetailpaymentBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schglvchdlydetailpayment", RowKind.New)>  _
        Public Sub BuildNewschglvchdlydetailpayment()
            UpdateFieldValue("Pymnt_No", 1)
        End Sub
    End Class
End Namespace
