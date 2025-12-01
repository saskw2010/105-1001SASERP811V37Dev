Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schClassConfigBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schClassConfig", RowKind.Existing)>  _
        Public Sub BuildExistingRow()
            PopulateManyToManyField("studydays", "classcode", "schClassstudy", "", "")
        End Sub
        
        <ControllerAction("schClassConfig", "Insert", ActionPhase.Before),  _
         ControllerAction("schClassConfig", "Update", ActionPhase.Before)>  _
        Public Sub BeforeInsertOrUpdate()
            Dim valueOfstudydays As FieldValue = SelectFieldValueObject("studydays")
            If (Not (valueOfstudydays) Is Nothing) Then
                valueOfstudydays.Modified = false
            End If
        End Sub
        
        <ControllerAction("schClassConfig", "Insert", ActionPhase.After),  _
         ControllerAction("schClassConfig", "Update", ActionPhase.After)>  _
        Public Sub AfterInsertOrUpdate()
            UpdateManyToManyField("studydays", "classcode", "schClassstudy", "", "")
        End Sub
        
        <ControllerAction("schClassConfig", "Delete", ActionPhase.Before)>  _
        Public Sub BeforeDelete()
            ClearManyToManyField("studydays", "classcode", "schClassstudy", "", "")
        End Sub
    End Class
End Namespace
