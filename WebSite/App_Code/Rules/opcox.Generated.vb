Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class opcoxBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("opcox", RowKind.Existing)>  _
        Public Sub BuildExistingRow()
            PopulateManyToManyField("UserId", "opcoid", "opcox", "", "UserId")
        End Sub
        
        <ControllerAction("opcox", "Insert", ActionPhase.Before),  _
         ControllerAction("opcox", "Update", ActionPhase.Before)>  _
        Public Sub BeforeInsertOrUpdate()
            Dim valueOfUserId As FieldValue = SelectFieldValueObject("UserId")
            If (Not (valueOfUserId) Is Nothing) Then
                valueOfUserId.Modified = false
            End If
        End Sub
        
        <ControllerAction("opcox", "Insert", ActionPhase.After),  _
         ControllerAction("opcox", "Update", ActionPhase.After)>  _
        Public Sub AfterInsertOrUpdate()
            UpdateManyToManyField("UserId", "opcoid", "opcox", "", "UserId")
        End Sub
        
        <ControllerAction("opcox", "Delete", ActionPhase.Before)>  _
        Public Sub BeforeDelete()
            ClearManyToManyField("UserId", "opcoid", "opcox", "", "UserId")
        End Sub
    End Class
End Namespace
