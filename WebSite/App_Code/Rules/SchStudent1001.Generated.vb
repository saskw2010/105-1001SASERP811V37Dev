Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class SchStudent1001BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("SchStudent1001", RowKind.New)>  _
        Public Sub BuildNewSchStudent1001()
            UpdateFieldValue("branch", 1)
            UpdateFieldValue("Genderid", 2)
            UpdateFieldValue("acdcode", 50)
        End Sub
    End Class
End Namespace
