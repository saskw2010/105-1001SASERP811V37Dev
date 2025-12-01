Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class GljrnvchhdrTBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("GljrnvchhdrT", RowKind.New)>  _
        Public Sub BuildNewGljrnvchhdrT()
            UpdateFieldValue("Jr_Ty", 101)
        End Sub
    End Class
End Namespace
