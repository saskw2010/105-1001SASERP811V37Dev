Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class CardstudentBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("Cardstudent", RowKind.New)>  _
        Public Sub BuildNewCardstudent()
            UpdateFieldValue("rosom", 0)
            UpdateFieldValue("Bookrosom", 0)
            UpdateFieldValue("Transportation", 0)
            UpdateFieldValue("rosomregister", 0)
            UpdateFieldValue("Cash", 0)
            UpdateFieldValue("keynet", 0)
            UpdateFieldValue("checkvalue", 0)
            UpdateFieldValue("checknumber", 0)
            UpdateFieldValue("transno", CType(HttpContext.Current.Session.Item("schvchdlyhdregid"),Int64))
            UpdateFieldValue("Pymnt_No", 1)
            UpdateFieldValue("moneypaidto", 0)
            UpdateFieldValue("rosom_1", 0)
            UpdateFieldValue("rosom_2", 0)
            UpdateFieldValue("rosom_3", 0)
            UpdateFieldValue("rosom_4", 0)
            UpdateFieldValue("rosom_5", 0)
            UpdateFieldValue("rosom_6", 0)
            UpdateFieldValue("rosom_7", 0)
            UpdateFieldValue("moneypaidto_1", 0)
        End Sub
    End Class
End Namespace
