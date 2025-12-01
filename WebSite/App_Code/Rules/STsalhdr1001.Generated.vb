Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class STsalhdr1001BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("STsalhdr1001", RowKind.New)>  _
        Public Sub BuildNewSTsalhdr1001()
            UpdateFieldValue("Doc_ty", 11)
            UpdateFieldValue("Brn_No_1", getmyfirstbranch)
            UpdateFieldValue("Pym_No_1", 1)
            UpdateFieldValue("Slm_No_1", getmysalesaccount)
            UpdateFieldValue("Doc_Dt_1", DateTime.now())
            UpdateFieldValue("Doc_ty_1", 1)
            UpdateFieldValue("typcmsup_1", 1)
            UpdateFieldValue("Cstm_No_1", getmycashaccount)
            UpdateFieldValue("curcode_1", 1)
            UpdateFieldValue("curprice_1", 1)
        End Sub
    End Class
End Namespace
