Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class _Dates2BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("_Dates2", RowKind.New)>  _
        Public Sub BuildNew_Dates2()
            UpdateFieldValue("usercashid", 1)
        End Sub
    End Class
End Namespace
