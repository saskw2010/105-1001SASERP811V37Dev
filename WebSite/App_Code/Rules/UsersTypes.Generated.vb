Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class UsersTypesBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("UsersTypes", RowKind.Existing)>  _
        Public Sub BuildExistingRow()
            PopulateManyToManyField("usertyperoles", "UsrTypID", "UsersTypes_roles", "UsrTypID", "id")
        End Sub
        
        <ControllerAction("UsersTypes", "Insert", ActionPhase.Before),  _
         ControllerAction("UsersTypes", "Update", ActionPhase.Before)>  _
        Public Sub BeforeInsertOrUpdate()
            Dim valueOfusertyperoles As FieldValue = SelectFieldValueObject("usertyperoles")
            If (Not (valueOfusertyperoles) Is Nothing) Then
                valueOfusertyperoles.Modified = false
            End If
        End Sub
        
        <ControllerAction("UsersTypes", "Insert", ActionPhase.After),  _
         ControllerAction("UsersTypes", "Update", ActionPhase.After)>  _
        Public Sub AfterInsertOrUpdate()
            UpdateManyToManyField("usertyperoles", "UsrTypID", "UsersTypes_roles", "UsrTypID", "id")
        End Sub
        
        <ControllerAction("UsersTypes", "Delete", ActionPhase.Before)>  _
        Public Sub BeforeDelete()
            ClearManyToManyField("usertyperoles", "UsrTypID", "UsersTypes_roles", "UsrTypID", "id")
        End Sub
    End Class
End Namespace
