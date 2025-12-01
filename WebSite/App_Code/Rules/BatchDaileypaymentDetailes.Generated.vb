Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class BatchDaileypaymentDetailesBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("BatchDaileypaymentDetailes", RowKind.New)>  _
        Public Sub BuildNewBatchDaileypaymentDetailes()
            UpdateFieldValue("Transactiondate", DateTime.Now())
            UpdateFieldValue("Referancedate", DateTime.Now())
        End Sub
    End Class
End Namespace
