Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class _Dates3BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("_Dates3", RowKind.New)>  _
        Public Sub BuildNew_Dates3()
            UpdateFieldValue("usercashid", 1)
        End Sub
    End Class
End Namespace
