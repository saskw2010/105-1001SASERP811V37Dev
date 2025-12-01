Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schvchdlyhdreg1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schvchdlyhdreg1", RowKind.New)>  _
        Public Sub BuildNewschvchdlyhdreg1()
            UpdateFieldValue("branch", CType(HttpContext.Current.Session.Item("branch"),Int64))
            UpdateFieldValue("sgm", CType(HttpContext.Current.Session.Item("sgm"),Int64))
            UpdateFieldValue("Trs_Dt", DateTime.Now)
            UpdateFieldValue("Balance", 0)
            '            UpdateFieldValue("ReferanceNo", getmyreferance())
            UpdateFieldValue("IDregorg", 1)
            UpdateFieldValue("acdcode", CType(HttpContext.Current.Session.Item("acdcode"),Int64))
            UpdateFieldValue("sumofdebit", 0)
        End Sub
    End Class
End Namespace
