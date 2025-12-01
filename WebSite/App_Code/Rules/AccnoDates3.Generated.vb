Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class AccnoDates3BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("AccnoDates3", RowKind.New)>  _
        Public Sub BuildNewAccnoDates3()
            UpdateFieldValue("usercashid", 1)
        End Sub
    End Class
End Namespace
