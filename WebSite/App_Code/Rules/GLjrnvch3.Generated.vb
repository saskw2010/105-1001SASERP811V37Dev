Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class GLjrnvch3BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("GLjrnvch3", RowKind.New)>  _
        Public Sub BuildNewGLjrnvch3()
            UpdateFieldValue("Tr_Dt", DateTime.Now())
            UpdateFieldValue("Tr_Db", 0)
            UpdateFieldValue("Tr_Cr", 0)
            UpdateFieldValue("curno", 1)
        End Sub
    End Class
End Namespace
