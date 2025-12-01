Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class contractshandler
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("ajrContracts", RowKind.New)>  _
        Public Sub BuildNewajrContracts()
            UpdateFieldValue("CntctDate", DateTime.Now)
            UpdateFieldValue("StartDate", DateTime.Now)
            UpdateFieldValue("cntstcode", 1)
            UpdateFieldValue("deleviryservice", 0)
        End Sub
    End Class
End Namespace
