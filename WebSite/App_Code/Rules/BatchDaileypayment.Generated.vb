Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class BatchDaileypaymentBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("BatchDaileypayment", RowKind.New)>  _
        Public Sub BuildNewBatchDaileypayment()
            UpdateFieldValue("RecivedMoney", 0)
        End Sub
    End Class
End Namespace
