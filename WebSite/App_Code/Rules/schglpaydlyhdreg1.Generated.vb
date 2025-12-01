Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schglpaydlyhdreg1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schglpaydlyhdreg1", RowKind.New)>  _
        Public Sub BuildNewschglpaydlyhdreg1()
            UpdateFieldValue("Trs_Dt", DateTime.Now())
            UpdateFieldValue("approved", 0)
            UpdateFieldValue("posted", 0)
            UpdateFieldValue("deleted", 0)
            UpdateFieldValue("havdetails", 0)
            UpdateFieldValue("acdcode", 32)
            UpdateFieldValue("Pymnt_No", 2)
            UpdateFieldValue("sumofdebit", 0)
        End Sub
    End Class
End Namespace
