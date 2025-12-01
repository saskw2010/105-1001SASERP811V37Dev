Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schApplicationhandlr1001
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schApplication1001", RowKind.New)>  _
        Public Sub BuildNewschApplication1001()
            UpdateFieldValue("schtrnsid", 2)
           
            UpdateFieldValue("ApplicationDate", DateTime.Now())
           
            UpdateFieldValue("AcademicYearto", 54)
            UpdateFieldValue("schstatus_code", 1)
            UpdateFieldValue("schstudenttypid", 1)
            UpdateFieldValue("passfail", false)
            UpdateFieldValue("fromout", 1)
            UpdateFieldValue("schsthlthcaseid", 1)
            UpdateFieldValue("studentsefa", 1)
            UpdateFieldValue("Schclasskindid", 1)
            UpdateFieldValue("schstclasskinddmgid", 1)
            UpdateFieldValue("Schtransferid", 1)
            UpdateFieldValue("studentBalance1", 0)
            UpdateFieldValue("schtrnsid_1", 1)
            UpdateFieldValue("ApplicationDate_1", DateTime.Now())
            UpdateFieldValue("schstatus_code_1", 1)
            UpdateFieldValue("schstudenttypid_1", 1)
            UpdateFieldValue("schsthlthcaseid_1", 1)
            UpdateFieldValue("studentsefa_1", 1)
            UpdateFieldValue("Schclasskindid_1", 1)
            UpdateFieldValue("schstclasskinddmgid_1", 1)
            UpdateFieldValue("Schtransferid_1", 1)
        End Sub
    End Class
End Namespace
