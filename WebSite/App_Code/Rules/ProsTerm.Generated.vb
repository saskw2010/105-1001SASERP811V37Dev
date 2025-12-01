Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class ProsTermBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("ProsTerm", RowKind.Existing)>  _
        Public Sub BuildExistingRow()
            PopulateManyToManyField("sgmlist", "prostermcode", "prostermsgm", "prostermcode", "")
        End Sub
        
        <ControllerAction("ProsTerm", "Insert", ActionPhase.Before),  _
         ControllerAction("ProsTerm", "Update", ActionPhase.Before)>  _
        Public Sub BeforeInsertOrUpdate()
            Dim valueOfsgmlist As FieldValue = SelectFieldValueObject("sgmlist")
            If (Not (valueOfsgmlist) Is Nothing) Then
                valueOfsgmlist.Modified = false
            End If
        End Sub
        
        <ControllerAction("ProsTerm", "Insert", ActionPhase.After),  _
         ControllerAction("ProsTerm", "Update", ActionPhase.After)>  _
        Public Sub AfterInsertOrUpdate()
            UpdateManyToManyField("sgmlist", "prostermcode", "prostermsgm", "prostermcode", "")
        End Sub
        
        <ControllerAction("ProsTerm", "Delete", ActionPhase.Before)>  _
        Public Sub BeforeDelete()
            ClearManyToManyField("sgmlist", "prostermcode", "prostermsgm", "prostermcode", "")
        End Sub
    End Class
End Namespace
