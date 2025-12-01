Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schglpaydlyhdregcashBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schglpaydlyhdregcash", RowKind.New)>  _
        Public Sub BuildNewschglpaydlyhdregcash()
            UpdateFieldValue("Trs_Dt", DateTime.Now)
        End Sub
    End Class
End Namespace
