Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schApplication4BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("schApplication4", RowKind.New)>  _
        Public Sub BuildNewschApplication4()
            UpdateFieldValue("schtrnsid", 1)
            UpdateFieldValue("branch", CType(HttpContext.Current.Session.Item("branch"),Int64))
            UpdateFieldValue("ApplicationDate", DateTime.Now())
            UpdateFieldValue("Genderid", CType(HttpContext.Current.Session.Item("Genderid"),Int64))
            UpdateFieldValue("AcademicYearto", 52)
            UpdateFieldValue("schstatus_code", 1)
            UpdateFieldValue("schstudenttypid", 1)
            UpdateFieldValue("passfail", True)
            UpdateFieldValue("schsthlthcaseid", 1)
            UpdateFieldValue("studentsefa", 1)
            UpdateFieldValue("Schclasskindid", 1)
            UpdateFieldValue("schstclasskinddmgid", 1)
            UpdateFieldValue("Schtransferid", 1)
        End Sub
        
        <ControllerAction("schApplication4", "Insert", ActionPhase.Before),  _
         ControllerAction("schApplication4", "Update", ActionPhase.Before)>  _
        Public Sub AssignFieldValuesToschApplication4( _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal studentacdAcademicYear As String,  _
                    ByVal studentbranchDesc1 As String,  _
                    ByVal studentbranchsgmsgm_Nm As String,  _
                    ByVal studentbranchGenderGender As String,  _
                    ByVal studentbranchstageShortDesc1 As String,  _
                    ByVal studentbranchschtypschtypDesc As String,  _
                    ByVal studentGradeShortDesc1 As String,  _
                    ByVal studentGradeacdAcademicYear As String,  _
                    ByVal studentGradeStageShortDesc1 As String,  _
                    ByVal studentschstatus_schstatus_name As String,  _
                    ByVal studentschstudenttypschstudenttyp As String,  _
                    ByVal civilidst As String,  _
                    ByVal fathername As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm As String,  _
                    ByVal dateofBirth As Nullable(Of DateTime),  _
                    ByVal genderid As Nullable(Of Long),  _
                    ByVal genderGender As String,  _
                    ByVal stageAppliedto As Nullable(Of Long),  _
                    ByVal stageAppliedtoShortDesc1 As String,  _
                    ByVal gradeApplied As Nullable(Of Long),  _
                    ByVal gradeAppliedShortDesc1 As String,  _
                    ByVal gradeAppliedacdAcademicYear As String,  _
                    ByVal gradeAppliedStageShortDesc1 As String,  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal academicYeartoAcademicYear As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
                    ByVal classTeacherEmp_NOt As String,  _
                    ByVal classTeacherHld_ErnReq_NM As String,  _
                    ByVal classTeachersgmsgm_Nm As String,  _
                    ByVal classTeachersalrycatgrade_desc_a As String,  _
                    ByVal classTeacherBlood_TypeModifiedBy As String,  _
                    ByVal classTeacherBnk_Bnk_Acc As String,  _
                    ByVal classTeacherSub_BnkBnk_Acc As String,  _
                    ByVal classTeacherCntry_Cntry_Nm As String,  _
                    ByVal classTeacherDepm_Depm_Nm As String,  _
                    ByVal classTeacherEduct_TypeEduct_Nm As String,  _
                    ByVal classTeacherJob_StuEmp_Stunm As String,  _
                    ByVal classTeacherEarning_Earning_Nm As String,  _
                    ByVal classTeacherGenderGender As String,  _
                    ByVal classTeacherJob_Job_Nm As String,  _
                    ByVal classTeacherLoc_Loc_Nm As String,  _
                    ByVal classTeacherOwnr_Ownr_ID As String,  _
                    ByVal classTeacherReljanReljan_nm As String,  _
                    ByVal classTeacherStatus_TypeStatus_Nm As String,  _
                    ByVal classTeacherbranchDesc1 As String,  _
                    ByVal classTeacherUniq_BADGENUMBER As String,  _
                    ByVal classBranchDesc1 As String,  _
                    ByVal classBranchsgmsgm_Nm As String,  _
                    ByVal classBranchGenderGender As String,  _
                    ByVal classBranchstageShortDesc1 As String,  _
                    ByVal classBranchschtypschtypDesc As String,  _
                    ByVal classGradeShortDesc1 As String,  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstatus_schstatus_name As String,  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal schstudenttypschstudenttyp As String,  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal theidname_1 As String,  _
                    ByVal currentSchool As String,  _
                    ByVal remarks As String,  _
                    ByVal fathertel As String,  _
                    ByVal fathertel2 As String,  _
                    ByVal passfail As Nullable(Of Boolean),  _
                    ByVal fatherjob As String,  _
                    ByVal fatheraddress As String,  _
                    ByVal fathertel3 As String,  _
                    ByVal fatheremail As String,  _
                    ByVal ageyear As Nullable(Of Long),  _
                    ByVal agemonth As Nullable(Of Long),  _
                    ByVal ageday As Nullable(Of Long),  _
                    ByVal homephone As String,  _
                    ByVal printed As Nullable(Of Long),  _
                    ByVal birthDocNo As String,  _
                    ByVal birthdocdate As Nullable(Of DateTime),  _
                    ByVal birthDocPlace As String,  _
                    ByVal birthPlace As String,  _
                    ByVal residencenumber As String,  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal schsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal cntry_No1 As Nullable(Of Long),  _
                    ByVal cntry_No1Cntry_Nm As String,  _
                    ByVal cntry_No2 As Nullable(Of Long),  _
                    ByVal cntry_No2Cntry_Nm As String,  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal stateState_Nm As String,  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal areaDesc1 As String,  _
                    ByVal blockno As String,  _
                    ByVal streetno As String,  _
                    ByVal gadah As String,  _
                    ByVal houseno As String,  _
                    ByVal emergencyTelNo1 As String,  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal mothercasejob_desc As String,  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal fathercasejob_desc As String,  _
                    ByVal socialstatus As Nullable(Of Long),  _
                    ByVal socialstatusschsocialstatuscaseDesc As String,  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal studentsefastudentsefaar As String,  _
                    ByVal studentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentsefadebitaccountClsacc_Acc_Nm As String,  _
                    ByVal studentsefadebitaccountAcc_BndAcc_Nm As String,  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schclasskindSchclasskinddesc As String,  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgschstclasskinddmgDesc As String,  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal schtransferSchtransferDesc As String,  _
                    ByVal classorder As Nullable(Of Long),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal calssserial As Nullable(Of Long),  _
                    ByVal agarulyear As Nullable(Of Single),  _
                    ByVal agarulmonth As Nullable(Of Single),  _
                    ByVal dateofcalculate As Nullable(Of DateTime),  _
                    ByVal agarulyearmax As Nullable(Of Single),  _
                    ByVal agarulmonthmax As Nullable(Of Single),  _
                    ByVal studentBalance1 As Nullable(Of Single),  _
                    ByVal studentnotes As String,  _
                    ByVal paidrosom As Nullable(Of Single),  _
                    ByVal fatherrecord As Nullable(Of Boolean),  _
                    ByVal parentsrelation As Nullable(Of Long),  _
                    ByVal theparentsrelationparentsrelationdesc As String,  _
                    ByVal schstEmail As String,  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal motherCode As Nullable(Of Long),  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal bookRecive As Nullable(Of Boolean),  _
                    ByVal bookDiscount As Nullable(Of Decimal),  _
                    ByVal rosomDiscount As Nullable(Of Decimal),  _
                    ByVal busid As Nullable(Of Long),  _
                    ByVal bUSPAY As Nullable(Of Decimal),  _
                    ByVal aMT00 As Nullable(Of Decimal),  _
                    ByVal tTLADV As Nullable(Of Decimal),  _
                    ByVal tTLDEP As Nullable(Of Decimal),  _
                    ByVal tTLPAY As Nullable(Of Decimal),  _
                    ByVal tTLOTH As Nullable(Of Decimal),  _
                    ByVal printcount As Nullable(Of Long),  _
                    ByVal agarulyear_1 As Nullable(Of Single),  _
                    ByVal agarulmonth_1 As Nullable(Of Single))
            Dim schtrnsidFieldValue As FieldValue = SelectFieldValueObject("schtrnsid")
            Dim schtrnsidCodeValue As Object = 1
            If (schtrnsidFieldValue Is Nothing) Then
                AddFieldValue("schtrnsid", schtrnsidCodeValue)
            Else
                schtrnsidFieldValue.NewValue = schtrnsidCodeValue
                schtrnsidFieldValue.Modified = true
                schtrnsidFieldValue.ReadOnly = false
            End If
        End Sub
    End Class
End Namespace
