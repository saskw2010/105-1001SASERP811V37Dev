Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class Schapplication1002BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("Schapplication1002", RowKind.New)>  _
        Public Sub BuildNewSchapplication1002()
            UpdateFieldValue("AcademicYearto", 54)
        End Sub
    End Class
End Namespace
