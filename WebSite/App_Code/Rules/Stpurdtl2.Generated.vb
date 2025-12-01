Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class Stpurdtl2BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("Stpurdtl2", RowKind.New)>  _
        Public Sub BuildNewStpurdtl2()
            UpdateFieldValue("UnitPrice", 0)
            UpdateFieldValue("Quantity", 0)
            UpdateFieldValue("Idate", DateTime.Now())
        End Sub
    End Class
End Namespace
