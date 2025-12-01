Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class EVOL_MemoBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("EVOL_Memo", RowKind.Existing)>  _
        Public Sub BuildExistingRow()
            PopulateManyToManyField("userlist", "ID", "EVOLMemo", "ID", "UserName")
        End Sub
        
        <ControllerAction("EVOL_Memo", "Insert", ActionPhase.Before),  _
         ControllerAction("EVOL_Memo", "Update", ActionPhase.Before)>  _
        Public Sub BeforeInsertOrUpdate()
            Dim valueOfuserlist As FieldValue = SelectFieldValueObject("userlist")
            If (Not (valueOfuserlist) Is Nothing) Then
                valueOfuserlist.Modified = false
            End If
        End Sub
        
        <ControllerAction("EVOL_Memo", "Insert", ActionPhase.After),  _
         ControllerAction("EVOL_Memo", "Update", ActionPhase.After)>  _
        Public Sub AfterInsertOrUpdate()
            UpdateManyToManyField("userlist", "ID", "EVOLMemo", "ID", "UserName")
        End Sub
        
        <ControllerAction("EVOL_Memo", "Delete", ActionPhase.Before)>  _
        Public Sub BeforeDelete()
            ClearManyToManyField("userlist", "ID", "EVOLMemo", "ID", "UserName")
        End Sub
    End Class
End Namespace
