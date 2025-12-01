Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class TripKindlistBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("TripKindlist", RowKind.New)>  _
        Public Sub BuildNewTripKindlist()
            UpdateFieldValue("transactionflag", 0)
        End Sub
    End Class
End Namespace
