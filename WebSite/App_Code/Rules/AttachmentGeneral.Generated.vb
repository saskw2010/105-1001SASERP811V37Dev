Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class AttachmentGeneralBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("AttachmentGeneral", RowKind.New)>  _
        Public Sub BuildNewAttachmentGeneral()
            UpdateFieldValue("Tasneefcode1",  HttpContext.Current.Session("Tasneefcode1").ToString())
        End Sub
    End Class
End Namespace
