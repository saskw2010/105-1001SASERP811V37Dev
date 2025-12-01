Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class user_detailsBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <ControllerAction("user_details", "Calculate", "UserEmail")>  _
        Public Sub Calculateuser_details( _
                    ByVal userName As String,  _
                    ByVal userEmail As String,  _
                    ByVal firstName As String,  _
                    ByVal lastName As String,  _
                    ByVal myphone As String,  _
                    ByVal myphoneTel As String,  _
                    ByVal catid1 As Nullable(Of Long),  _
                    ByVal thecatid1cat1name As String,  _
                    ByVal catid2 As Nullable(Of Long),  _
                    ByVal thecatid2cat2name As String,  _
                    ByVal thecatid2Cntry_Cntry_Nm As String,  _
                    ByVal catid3 As Nullable(Of Long),  _
                    ByVal thecatid3cat3name As String,  _
                    ByVal thecatid3catid2cat2name As String,  _
                    ByVal thecatid3catid2Cntry_Cntry_Nm As String,  _
                    ByVal catid4 As Nullable(Of Long),  _
                    ByVal thecatid4cat4name As String,  _
                    ByVal catid5 As Nullable(Of Long),  _
                    ByVal thecatid5cat5name As String,  _
                    ByVal catid6 As Nullable(Of Long),  _
                    ByVal thecatid6cat6name As String,  _
                    ByVal catid7 As Nullable(Of Long),  _
                    ByVal thecatid7cat7name As String,  _
                    ByVal catid8 As Nullable(Of Long),  _
                    ByVal thecatid8cat8name As String,  _
                    ByVal catid9 As Nullable(Of Long),  _
                    ByVal thecatid9cat9name As String,  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal isactive As Nullable(Of Boolean),  _
                    ByVal isdeleted As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal departmentid As Nullable(Of Long))
            UpdateFieldValue("UserEmail", getuseremail())
        End Sub
        
        <RowBuilder("user_details", RowKind.New)>  _
        Public Sub BuildNewuser_details()
            UpdateFieldValue("UserName", HttpContext.Current.User.Identity.Name)
            UpdateFieldValue("UserEmail", getuseremail())
        End Sub
        
        <ControllerAction("user_details", "Insert", ActionPhase.Before),  _
         ControllerAction("user_details", "Update", ActionPhase.Before)>  _
        Public Sub AssignFieldValuesTouser_details( _
                    ByVal userName As String,  _
                    ByVal userEmail As String,  _
                    ByVal firstName As String,  _
                    ByVal lastName As String,  _
                    ByVal myphone As String,  _
                    ByVal myphoneTel As String,  _
                    ByVal catid1 As Nullable(Of Long),  _
                    ByVal thecatid1cat1name As String,  _
                    ByVal catid2 As Nullable(Of Long),  _
                    ByVal thecatid2cat2name As String,  _
                    ByVal thecatid2Cntry_Cntry_Nm As String,  _
                    ByVal catid3 As Nullable(Of Long),  _
                    ByVal thecatid3cat3name As String,  _
                    ByVal thecatid3catid2cat2name As String,  _
                    ByVal thecatid3catid2Cntry_Cntry_Nm As String,  _
                    ByVal catid4 As Nullable(Of Long),  _
                    ByVal thecatid4cat4name As String,  _
                    ByVal catid5 As Nullable(Of Long),  _
                    ByVal thecatid5cat5name As String,  _
                    ByVal catid6 As Nullable(Of Long),  _
                    ByVal thecatid6cat6name As String,  _
                    ByVal catid7 As Nullable(Of Long),  _
                    ByVal thecatid7cat7name As String,  _
                    ByVal catid8 As Nullable(Of Long),  _
                    ByVal thecatid8cat8name As String,  _
                    ByVal catid9 As Nullable(Of Long),  _
                    ByVal thecatid9cat9name As String,  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal isactive As Nullable(Of Boolean),  _
                    ByVal isdeleted As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal departmentid As Nullable(Of Long))
            Dim UserEmailFieldValue As FieldValue = SelectFieldValueObject("UserEmail")
            Dim UserEmailCodeValue As Object = getuseremail()
            If (UserEmailFieldValue Is Nothing) Then
                AddFieldValue("UserEmail", UserEmailCodeValue)
            Else
                UserEmailFieldValue.NewValue = UserEmailCodeValue
                UserEmailFieldValue.Modified = true
                UserEmailFieldValue.ReadOnly = false
            End If
        End Sub
    End Class
End Namespace
