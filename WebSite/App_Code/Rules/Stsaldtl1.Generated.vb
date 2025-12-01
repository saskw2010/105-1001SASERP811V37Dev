Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class Stsaldtl1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("Stsaldtl1", RowKind.New)>  _
        Public Sub BuildNewStsaldtl1()
            UpdateFieldValue("Unit_No", 1)
            UpdateFieldValue("Discount", 0)
            UpdateFieldValue("darb", 0)
        End Sub
    End Class
End Namespace
