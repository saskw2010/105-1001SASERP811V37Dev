Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class itembatchBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("itembatch", RowKind.New)>  _
        Public Sub BuildNewitembatch()
            UpdateFieldValue("ITMREQ", ((6)))
        End Sub
    End Class
End Namespace
