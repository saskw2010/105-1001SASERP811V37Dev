Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace Rules
    
    Partial Public Class ProgramsShortTermBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("ProgramsShortTerm", RowKind.Existing)>  _
        Public Sub BuildExistingRow()
            PopulateManyToManyField("branshlist", "ProgramCode", "", "", "")
        End Sub
        
        <ControllerAction("ProgramsShortTerm", "Insert", ActionPhase.Before),  _
         ControllerAction("ProgramsShortTerm", "Update", ActionPhase.Before)>  _
        Public Sub BeforeInsertOrUpdate()
            Dim valueOfbranshlist As FieldValue = SelectFieldValueObject("branshlist")
            If (Not (valueOfbranshlist) Is Nothing) Then
                valueOfbranshlist.Modified = false
            End If
        End Sub
        
        <ControllerAction("ProgramsShortTerm", "Insert", ActionPhase.After),  _
         ControllerAction("ProgramsShortTerm", "Update", ActionPhase.After)>  _
        Public Sub AfterInsertOrUpdate()
            UpdateManyToManyField("branshlist", "ProgramCode", "", "", "")
        End Sub
        
        <ControllerAction("ProgramsShortTerm", "Delete", ActionPhase.Before)>  _
        Public Sub BeforeDelete()
            ClearManyToManyField("branshlist", "ProgramCode", "", "", "")
        End Sub
    End Class
End Namespace
