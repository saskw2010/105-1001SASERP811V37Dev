Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class Gljrnvchhdr1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("Gljrnvchhdr1", RowKind.New)>  _
        Public Sub BuildNewGljrnvchhdr1()
            UpdateFieldValue("Trs_Dt", DateTime.Now())
        End Sub
    End Class
End Namespace
