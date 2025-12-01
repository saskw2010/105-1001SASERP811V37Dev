Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class RegActivitesBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("RegActivites", RowKind.Existing)>  _
        Public Sub BuildExistingRow()
            PopulateManyToManyField("calendarday", "Activitesid", "RegActivitescalender", "Activitesid", "serial")
        End Sub
        
        <ControllerAction("RegActivites", "Insert", ActionPhase.Before),  _
         ControllerAction("RegActivites", "Update", ActionPhase.Before)>  _
        Public Sub BeforeInsertOrUpdate()
            Dim valueOfcalendarday As FieldValue = SelectFieldValueObject("calendarday")
            If (Not (valueOfcalendarday) Is Nothing) Then
                valueOfcalendarday.Modified = false
            End If
        End Sub
        
        <ControllerAction("RegActivites", "Insert", ActionPhase.After),  _
         ControllerAction("RegActivites", "Update", ActionPhase.After)>  _
        Public Sub AfterInsertOrUpdate()
            UpdateManyToManyField("calendarday", "Activitesid", "RegActivitescalender", "Activitesid", "serial")
        End Sub
        
        <ControllerAction("RegActivites", "Delete", ActionPhase.Before)>  _
        Public Sub BeforeDelete()
            ClearManyToManyField("calendarday", "Activitesid", "RegActivitescalender", "Activitesid", "serial")
        End Sub
    End Class
End Namespace
