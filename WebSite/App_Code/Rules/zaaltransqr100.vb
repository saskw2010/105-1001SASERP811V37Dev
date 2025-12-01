Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class zaaltransqr100BusinessRules
        Inherits eZee.Rules.SharedBusinessRules

        ''' <summary>
        ''' This method will execute in any view for an action
        ''' handler="eZee.Rules.zaaltransqr100BusinessRules"
        ''' with a command name that matches "Custom" and argument that matches "printbaraa".
        ''' </summary>
        <Rule("Zalltransqr100")> _
        Public Sub SchStudentmos1001r100Implementation()
            eZee.Rules.SharedBusinessRules.getdatatable2016()
        End Sub
    End Class
End Namespace
