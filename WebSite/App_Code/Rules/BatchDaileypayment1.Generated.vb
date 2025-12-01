Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class BatchDaileypayment1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("BatchDaileypayment1", RowKind.New)>  _
        Public Sub BuildNewBatchDaileypayment1()
            UpdateFieldValue("RecivedMoney", 0)
        End Sub
    End Class
End Namespace
