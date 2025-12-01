Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class ConfirmationRecivreviewBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("ConfirmationRecivreview", RowKind.New)>  _
        Public Sub BuildNewConfirmationRecivreview()
            UpdateFieldValue("cstyp_No", 7)
            UpdateFieldValue("depositflage", 1)
            UpdateFieldValue("depositdate", DateTime.Now())
        End Sub
    End Class
End Namespace
