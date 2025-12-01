Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class SoftwareProjectsBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("SoftwareProjects", RowKind.Existing)>  _
        Public Sub BuildExistingRow()
            PopulateManyToManyField("ProjectModules", "sprid", "SoftwareProjectsModuleslist", "sprid", "sprModuleid")
        End Sub
        
        <ControllerAction("SoftwareProjects", "Insert", ActionPhase.Before),  _
         ControllerAction("SoftwareProjects", "Update", ActionPhase.Before)>  _
        Public Sub BeforeInsertOrUpdate()
            Dim valueOfProjectModules As FieldValue = SelectFieldValueObject("ProjectModules")
            If (Not (valueOfProjectModules) Is Nothing) Then
                valueOfProjectModules.Modified = false
            End If
        End Sub
        
        <ControllerAction("SoftwareProjects", "Insert", ActionPhase.After),  _
         ControllerAction("SoftwareProjects", "Update", ActionPhase.After)>  _
        Public Sub AfterInsertOrUpdate()
            UpdateManyToManyField("ProjectModules", "sprid", "SoftwareProjectsModuleslist", "sprid", "sprModuleid")
        End Sub
        
        <ControllerAction("SoftwareProjects", "Delete", ActionPhase.Before)>  _
        Public Sub BeforeDelete()
            ClearManyToManyField("ProjectModules", "sprid", "SoftwareProjectsModuleslist", "sprid", "sprModuleid")
        End Sub
    End Class
End Namespace
