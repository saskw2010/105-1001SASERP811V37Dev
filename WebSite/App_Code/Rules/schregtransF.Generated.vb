Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schregtransfhndlr
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schregtransF", RowKind.New)>  _
        Public Sub BuildNewschregtransF()
            UpdateFieldValue("transdate", DateTime.now)
            UpdateFieldValue("branch", CType(HttpContext.Current.Session.Item("branch"),Int64))
            UpdateFieldValue("approved", 0)
        End Sub
    End Class
End Namespace
