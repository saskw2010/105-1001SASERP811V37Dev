Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class stpurhdr1001BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("stpurhdr1001", RowKind.New)>  _
        Public Sub BuildNewstpurhdr1001()
            UpdateFieldValue("Brn_No", 1)
            UpdateFieldValue("Doc_Dt", DateTime.now())
            UpdateFieldValue("typcmsup", 2)
            UpdateFieldValue("curcode", 1)
        End Sub
    End Class
End Namespace
