Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class OpCoBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("OpCo", RowKind.Existing)>  _
        Public Sub BuildExistingRow()
            PopulateManyToManyField("userlists", "OpcoID", "", "", "")
        End Sub
        
        <ControllerAction("OpCo", "Insert", ActionPhase.Before),  _
         ControllerAction("OpCo", "Update", ActionPhase.Before)>  _
        Public Sub BeforeInsertOrUpdate()
            Dim valueOfuserlists As FieldValue = SelectFieldValueObject("userlists")
            If (Not (valueOfuserlists) Is Nothing) Then
                valueOfuserlists.Modified = false
            End If
        End Sub
        
        <ControllerAction("OpCo", "Insert", ActionPhase.After),  _
         ControllerAction("OpCo", "Update", ActionPhase.After)>  _
        Public Sub AfterInsertOrUpdate()
            UpdateManyToManyField("userlists", "OpcoID", "", "", "")
        End Sub
        
        <ControllerAction("OpCo", "Delete", ActionPhase.Before)>  _
        Public Sub BeforeDelete()
            ClearManyToManyField("userlists", "OpcoID", "", "", "")
        End Sub
    End Class
End Namespace
