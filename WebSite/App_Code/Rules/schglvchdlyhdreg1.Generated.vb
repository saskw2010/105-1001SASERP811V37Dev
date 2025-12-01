Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schglvchdlyhdreg1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schglvchdlyhdreg1", RowKind.New)>  _
        Public Sub BuildNewschglvchdlyhdreg1()
            UpdateFieldValue("Trs_Dt", DateTime.Now)
        End Sub
    End Class
End Namespace
