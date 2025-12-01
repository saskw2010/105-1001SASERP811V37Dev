Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class GljrnvchhdrT1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("GljrnvchhdrT1", RowKind.New)>  _
        Public Sub BuildNewGljrnvchhdrT1()
            UpdateFieldValue("Jr_Ty", 102)
        End Sub
    End Class
End Namespace
