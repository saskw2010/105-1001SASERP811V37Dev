Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class AspNetUsersBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("AspNetUsers", RowKind.Existing)>  _
        Public Sub BuildExistingRow()
            PopulateManyToManyField("usersroleslist", "Id", "AspNetUserRoles", "UserId", "RoleId")
            PopulateManyToManyField("userstyplist", "Id", "usertypjoin", "Id", "UsrTypID")
        End Sub
        
        <ControllerAction("AspNetUsers", "Insert", ActionPhase.Before),  _
         ControllerAction("AspNetUsers", "Update", ActionPhase.Before)>  _
        Public Sub BeforeInsertOrUpdate()
            Dim valueOfusersroleslist As FieldValue = SelectFieldValueObject("usersroleslist")
            If (Not (valueOfusersroleslist) Is Nothing) Then
                valueOfusersroleslist.Modified = false
            End If
            Dim valueOfuserstyplist As FieldValue = SelectFieldValueObject("userstyplist")
            If (Not (valueOfuserstyplist) Is Nothing) Then
                valueOfuserstyplist.Modified = false
            End If
        End Sub
        
        <ControllerAction("AspNetUsers", "Insert", ActionPhase.After),  _
         ControllerAction("AspNetUsers", "Update", ActionPhase.After)>  _
        Public Sub AfterInsertOrUpdate()
            UpdateManyToManyField("usersroleslist", "Id", "AspNetUserRoles", "UserId", "RoleId")
            UpdateManyToManyField("userstyplist", "Id", "usertypjoin", "Id", "UsrTypID")
        End Sub
        
        <ControllerAction("AspNetUsers", "Delete", ActionPhase.Before)>  _
        Public Sub BeforeDelete()
            ClearManyToManyField("usersroleslist", "Id", "AspNetUserRoles", "UserId", "RoleId")
            ClearManyToManyField("userstyplist", "Id", "usertypjoin", "Id", "UsrTypID")
        End Sub
    End Class
End Namespace
