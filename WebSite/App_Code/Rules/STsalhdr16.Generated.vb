Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class STsalhdr16BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("STsalhdr16", RowKind.New)>  _
        Public Sub BuildNewSTsalhdr16()
            UpdateFieldValue("Brn_No", getmyfirstbranch())
            UpdateFieldValue("Pym_No", 1)
            UpdateFieldValue("Slm_No", getmysalesaccount)
            UpdateFieldValue("Doc_Dt", DateTime.now())
            UpdateFieldValue("Doc_ty", 1)
            UpdateFieldValue("typcmsup", 1)
            UpdateFieldValue("Cstm_No", getmycashaccount)
            UpdateFieldValue("curcode", 1)
            UpdateFieldValue("curprice", 1)
        End Sub
    End Class
End Namespace
