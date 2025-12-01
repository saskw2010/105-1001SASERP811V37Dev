Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class maintncrequestBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("maintncrequest", RowKind.New)>  _
        Public Sub BuildNewmaintncrequest()
            UpdateFieldValue("Doc_Dt", DateTime.Now())
        End Sub
    End Class
End Namespace
