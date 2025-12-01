Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schApplicationonlineBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schApplicationonline", RowKind.New)>  _
        Public Sub BuildNewschApplicationonline()
            UpdateFieldValue("AcademicYearto", 54)
        End Sub
    End Class
End Namespace
