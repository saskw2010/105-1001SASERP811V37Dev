Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schApplicationhandlr
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schApplication", RowKind.New)>  _
        Public Sub BuildNewschApplication()
            UpdateFieldValue("schtrnsid", 1)
           
            UpdateFieldValue("ApplicationDate", DateTime.Now())
           
            UpdateFieldValue("AcademicYearto", 54)
            UpdateFieldValue("schstatus_code", 1)
            UpdateFieldValue("schstudenttypid", 1)
            UpdateFieldValue("passfail", True)
            UpdateFieldValue("schsthlthcaseid", 1)
            UpdateFieldValue("studentsefa", 1)
            UpdateFieldValue("Schclasskindid", 1)
            UpdateFieldValue("schstclasskinddmgid", 1)
            UpdateFieldValue("Schtransferid", 1)
        End Sub
      
    End Class
End Namespace
