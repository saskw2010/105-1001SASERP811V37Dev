Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class AccnoDatesBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("AccnoDates", RowKind.New)>  _
        Public Sub BuildNewAccnoDates()
            UpdateFieldValue("usercashid", 1)
        End Sub
    End Class
End Namespace
