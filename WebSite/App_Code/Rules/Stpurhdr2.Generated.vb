Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class Stpurhdr2BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("Stpurhdr2", RowKind.New)>  _
        Public Sub BuildNewStpurhdr2()
            UpdateFieldValue("Brn_No", 1)
            UpdateFieldValue("Doc_Dt", DateTime.now())
            UpdateFieldValue("typcmsup", 2)
            UpdateFieldValue("curcode", 1)
        End Sub
    End Class
End Namespace
