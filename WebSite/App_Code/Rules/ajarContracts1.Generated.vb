Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class ajarContracts1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("ajarContracts1", RowKind.New)>  _
        Public Sub BuildNewajarContracts1()
            UpdateFieldValue("CntctDate", DateTime.Now)
            UpdateFieldValue("StartDate", DateTime.Now)
            UpdateFieldValue("cntstcode", 1)
            UpdateFieldValue("deleviryservice", 0)
        End Sub
    End Class
End Namespace
