Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class schApplication1001
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ApplicationCodeauto As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schtrnsid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchtrnsschtrnsDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Thebranchsgmsgm_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchsgmOpcoOpcoName As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchGenderGender As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchschtypschtypDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ApplicationDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentSchstCivilidnumber As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentareaDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentbranchDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentbranchsgmsgm_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentbranchGenderGender As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentbranchschtypschtypDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentCntry_Cntry_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentGenderGender As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentReligionReljan_nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentstateState_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentidname_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentacdAcademicYear As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentacdGlFinperiodFin_period_info As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentClassClassDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentSchclasskindSchclasskinddesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentFatherfathfirstname1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentFatherMaritalStatusStatus_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentFatherareaDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentFatherCntry_Cntry_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentFatherreligionReljan_nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentFatherStateState_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentFatherjob_job_desc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentGradeShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentGradeacdAcademicYear As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentGradeStageShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentMotherfirstname1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentMotherareaDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentMotherCntry_Cntry_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentMotherreligionReljan_nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentMotherStateState_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentMotherjob_job_desc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentStageShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentschstatus_schstatus_name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentschstclasskinddmgschstclasskinddmgDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentschstsplschstsplDsc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentschsthlthcaseschsthlthcaseDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentstudentsefastudentsefaar As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentstudentsefadebitaccountAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentschstudenttypschstudenttyp As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentSchtransferSchtransferDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Civilidst As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentfullname As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathername As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_Cntry_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_DateofBirth As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Genderid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GenderGender As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StageAppliedto As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StageAppliedtoShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeApplied As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeAppliedShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeAppliedacdAcademicYear As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeAppliedacdGlFinperiodFin_period_info As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeAppliedStageShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcademicYearto As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcademicYeartoAcademicYear As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcademicYeartoGlFinperiodFin_period_info As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcademicYeartoGlFinperiodaccountnumberAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Class As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ClassClassDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstatus_code As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstatus_schstatus_name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstudenttypid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstudenttypschstudenttyp As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Id As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Theidname_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CurrentSchool As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Remarks As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathertel As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathertel2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Passfail As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fromout As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fatherjob As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fatheraddress As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathertel3 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fatheremail As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Ageyear As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agemonth As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Ageday As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Homephone As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Printed As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_BirthDocNo As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Birthdocdate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_BirthDocPlace As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_BirthPlace As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Residencenumber As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ResidenceExpDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schsthlthcaseid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchsthlthcaseschsthlthcaseDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No1Cntry_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No2 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No2Cntry_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_State As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StateState_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Area As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AreaDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Blockno As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Streetno As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Gadah As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Houseno As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Addressdetail As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_EmergencyTelNo1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Mothercase As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Mothercasejob_desc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathercase As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathercasejob_desc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Socialstatus As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SocialstatusschsocialstatuscaseDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentsefa As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentsefastudentsefaar As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentsefadebitaccountAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentsefadebitaccountClsacc_Acc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentsefadebitaccountAcc_BndAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schclasskindid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchclasskindSchclasskinddesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstclasskinddmgid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchstclasskinddmgschstclasskinddmgDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schtransferid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchtransferSchtransferDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Classorder As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agarulyear As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agarulmonth As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Dateofcalculate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agarulyearmax As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agarulmonthmax As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentBalance1 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentnotes As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Calssserial As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Paidrosom As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Parentsrelation As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Theparentsrelationparentsrelationdesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentfullname1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ApplicationCodeauto_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schtrnsid_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchtrnsschtrnsDesc_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchDesc1_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Thebranchsgmsgm_Nm_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchsgmOpcoOpcoName_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchGenderGender_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchschtypschtypDesc_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ApplicationDate_1 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentCode_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentSchstCivilidnumber_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Civilidst_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentfullname_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathername_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_Cntry_Nm_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_DateofBirth_1 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Genderid_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GenderGender_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StageAppliedto_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StageAppliedtoShortDesc1_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeApplied_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeAppliedShortDesc1_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeAppliedacdAcademicYear_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeAppliedacdGlFinperiodFin_period_info_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeAppliedStageShortDesc1_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcademicYearto_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcademicYeartoAcademicYear_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcademicYeartoGlFinperiodFin_period_info_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcademicYeartoGlFinperiodaccountnumberAcc_Nm_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Class_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ClassClassDesc1_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstatus_code_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstatus_schstatus_name_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstudenttypid_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstudenttypschstudenttyp_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Id_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Theidname_1_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CurrentSchool_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Remarks_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathertel_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathertel2_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Passfail_1 As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fromout_1 As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fatherjob_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fatheraddress_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathertel3_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fatheremail_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Ageyear_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agemonth_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Ageday_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Homephone_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Printed_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_BirthDocNo_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Birthdocdate_1 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_BirthDocPlace_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_BirthPlace_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Residencenumber_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ResidenceExpDate_1 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schsthlthcaseid_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchsthlthcaseschsthlthcaseDesc_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No1_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No1Cntry_Nm_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No2_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No2Cntry_Nm_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_State_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StateState_Nm_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Area_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AreaDesc1_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Blockno_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Streetno_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Gadah_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Houseno_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Addressdetail_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_EmergencyTelNo1_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Mothercase_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Mothercasejob_desc_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathercase_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathercasejob_desc_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Socialstatus_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SocialstatusschsocialstatuscaseDesc_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentsefa_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentsefastudentsefaar_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentsefadebitaccountAcc_Nm_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentsefadebitaccountClsacc_Acc_Nm_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentsefadebitaccountAcc_BndAcc_Nm_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schclasskindid_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchclasskindSchclasskinddesc_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstclasskinddmgid_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchstclasskinddmgschstclasskinddmgDesc_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schtransferid_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchtransferSchtransferDesc_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Classorder_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedBy_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedOn_1 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedBy_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedOn_1 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agarulyear_1 As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agarulmonth_1 As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Dateofcalculate_1 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agarulyearmax_1 As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agarulmonthmax_1 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agarulmonthmax_2 As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Calssserial_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Paidrosom_1 As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Parentsrelation_1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Theparentsrelationparentsrelationdesc_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentfullname1_1 As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property ApplicationCodeauto() As Nullable(Of Long)
            Get
                Return m_ApplicationCodeauto
            End Get
            Set
                m_ApplicationCodeauto = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property schtrnsid() As Nullable(Of Long)
            Get
                Return m_Schtrnsid
            End Get
            Set
                m_Schtrnsid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schtrnsschtrnsDesc() As String
            Get
                Return m_SchtrnsschtrnsDesc
            End Get
            Set
                m_SchtrnsschtrnsDesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property branch() As Nullable(Of Long)
            Get
                Return m_Branch
            End Get
            Set
                m_Branch = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchDesc1() As String
            Get
                Return m_ThebranchDesc1
            End Get
            Set
                m_ThebranchDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Thebranchsgmsgm_Nm() As String
            Get
                Return m_Thebranchsgmsgm_Nm
            End Get
            Set
                m_Thebranchsgmsgm_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchsgmOpcoOpcoName() As String
            Get
                Return m_ThebranchsgmOpcoOpcoName
            End Get
            Set
                m_ThebranchsgmOpcoOpcoName = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchGenderGender() As String
            Get
                Return m_ThebranchGenderGender
            End Get
            Set
                m_ThebranchGenderGender = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchschtypschtypDesc() As String
            Get
                Return m_ThebranchschtypschtypDesc
            End Get
            Set
                m_ThebranchschtypschtypDesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property ApplicationDate() As Nullable(Of DateTime)
            Get
                Return m_ApplicationDate
            End Get
            Set
                m_ApplicationDate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentCode() As Nullable(Of Long)
            Get
                Return m_StudentCode
            End Get
            Set
                m_StudentCode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentSchstCivilidnumber() As String
            Get
                Return m_StudentSchstCivilidnumber
            End Get
            Set
                m_StudentSchstCivilidnumber = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentareaDesc1() As String
            Get
                Return m_StudentareaDesc1
            End Get
            Set
                m_StudentareaDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentbranchDesc1() As String
            Get
                Return m_StudentbranchDesc1
            End Get
            Set
                m_StudentbranchDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Studentbranchsgmsgm_Nm() As String
            Get
                Return m_Studentbranchsgmsgm_Nm
            End Get
            Set
                m_Studentbranchsgmsgm_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentbranchGenderGender() As String
            Get
                Return m_StudentbranchGenderGender
            End Get
            Set
                m_StudentbranchGenderGender = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentbranchschtypschtypDesc() As String
            Get
                Return m_StudentbranchschtypschtypDesc
            End Get
            Set
                m_StudentbranchschtypschtypDesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentCntry_Cntry_Nm() As String
            Get
                Return m_StudentCntry_Cntry_Nm
            End Get
            Set
                m_StudentCntry_Cntry_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentGenderGender() As String
            Get
                Return m_StudentGenderGender
            End Get
            Set
                m_StudentGenderGender = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentReligionReljan_nm() As String
            Get
                Return m_StudentReligionReljan_nm
            End Get
            Set
                m_StudentReligionReljan_nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentstateState_Nm() As String
            Get
                Return m_StudentstateState_Nm
            End Get
            Set
                m_StudentstateState_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Studentidname_1() As String
            Get
                Return m_Studentidname_1
            End Get
            Set
                m_Studentidname_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentacdAcademicYear() As String
            Get
                Return m_StudentacdAcademicYear
            End Get
            Set
                m_StudentacdAcademicYear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentacdGlFinperiodFin_period_info() As String
            Get
                Return m_StudentacdGlFinperiodFin_period_info
            End Get
            Set
                m_StudentacdGlFinperiodFin_period_info = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentClassClassDesc1() As String
            Get
                Return m_StudentClassClassDesc1
            End Get
            Set
                m_StudentClassClassDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentSchclasskindSchclasskinddesc() As String
            Get
                Return m_StudentSchclasskindSchclasskinddesc
            End Get
            Set
                m_StudentSchclasskindSchclasskinddesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentFatherfathfirstname1() As String
            Get
                Return m_StudentFatherfathfirstname1
            End Get
            Set
                m_StudentFatherfathfirstname1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentFatherMaritalStatusStatus_Nm() As String
            Get
                Return m_StudentFatherMaritalStatusStatus_Nm
            End Get
            Set
                m_StudentFatherMaritalStatusStatus_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentFatherareaDesc1() As String
            Get
                Return m_StudentFatherareaDesc1
            End Get
            Set
                m_StudentFatherareaDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentFatherCntry_Cntry_Nm() As String
            Get
                Return m_StudentFatherCntry_Cntry_Nm
            End Get
            Set
                m_StudentFatherCntry_Cntry_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentFatherreligionReljan_nm() As String
            Get
                Return m_StudentFatherreligionReljan_nm
            End Get
            Set
                m_StudentFatherreligionReljan_nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentFatherStateState_Nm() As String
            Get
                Return m_StudentFatherStateState_Nm
            End Get
            Set
                m_StudentFatherStateState_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentFatherjob_job_desc() As String
            Get
                Return m_StudentFatherjob_job_desc
            End Get
            Set
                m_StudentFatherjob_job_desc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentGradeShortDesc1() As String
            Get
                Return m_StudentGradeShortDesc1
            End Get
            Set
                m_StudentGradeShortDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentGradeacdAcademicYear() As String
            Get
                Return m_StudentGradeacdAcademicYear
            End Get
            Set
                m_StudentGradeacdAcademicYear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentGradeStageShortDesc1() As String
            Get
                Return m_StudentGradeStageShortDesc1
            End Get
            Set
                m_StudentGradeStageShortDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentMotherfirstname1() As String
            Get
                Return m_StudentMotherfirstname1
            End Get
            Set
                m_StudentMotherfirstname1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentMotherareaDesc1() As String
            Get
                Return m_StudentMotherareaDesc1
            End Get
            Set
                m_StudentMotherareaDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentMotherCntry_Cntry_Nm() As String
            Get
                Return m_StudentMotherCntry_Cntry_Nm
            End Get
            Set
                m_StudentMotherCntry_Cntry_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentMotherreligionReljan_nm() As String
            Get
                Return m_StudentMotherreligionReljan_nm
            End Get
            Set
                m_StudentMotherreligionReljan_nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentMotherStateState_Nm() As String
            Get
                Return m_StudentMotherStateState_Nm
            End Get
            Set
                m_StudentMotherStateState_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentMotherjob_job_desc() As String
            Get
                Return m_StudentMotherjob_job_desc
            End Get
            Set
                m_StudentMotherjob_job_desc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentStageShortDesc1() As String
            Get
                Return m_StudentStageShortDesc1
            End Get
            Set
                m_StudentStageShortDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Studentschstatus_schstatus_name() As String
            Get
                Return m_Studentschstatus_schstatus_name
            End Get
            Set
                m_Studentschstatus_schstatus_name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentschstclasskinddmgschstclasskinddmgDesc() As String
            Get
                Return m_StudentschstclasskinddmgschstclasskinddmgDesc
            End Get
            Set
                m_StudentschstclasskinddmgschstclasskinddmgDesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentschstsplschstsplDsc() As String
            Get
                Return m_StudentschstsplschstsplDsc
            End Get
            Set
                m_StudentschstsplschstsplDsc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentschsthlthcaseschsthlthcaseDesc() As String
            Get
                Return m_StudentschsthlthcaseschsthlthcaseDesc
            End Get
            Set
                m_StudentschsthlthcaseschsthlthcaseDesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Studentstudentsefastudentsefaar() As String
            Get
                Return m_Studentstudentsefastudentsefaar
            End Get
            Set
                m_Studentstudentsefastudentsefaar = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentstudentsefadebitaccountAcc_Nm() As String
            Get
                Return m_StudentstudentsefadebitaccountAcc_Nm
            End Get
            Set
                m_StudentstudentsefadebitaccountAcc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Studentschstudenttypschstudenttyp() As String
            Get
                Return m_Studentschstudenttypschstudenttyp
            End Get
            Set
                m_Studentschstudenttypschstudenttyp = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentSchtransferSchtransferDesc() As String
            Get
                Return m_StudentSchtransferSchtransferDesc
            End Get
            Set
                m_StudentSchtransferSchtransferDesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property civilidst() As String
            Get
                Return m_Civilidst
            End Get
            Set
                m_Civilidst = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property studentfullname() As String
            Get
                Return m_Studentfullname
            End Get
            Set
                m_Studentfullname = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Fathername() As String
            Get
                Return m_Fathername
            End Get
            Set
                m_Fathername = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Cntry_No() As Nullable(Of Long)
            Get
                Return m_Cntry_No
            End Get
            Set
                m_Cntry_No = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Cntry_Cntry_Nm() As String
            Get
                Return m_Cntry_Cntry_Nm
            End Get
            Set
                m_Cntry_Cntry_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property DateofBirth() As Nullable(Of DateTime)
            Get
                Return m_DateofBirth
            End Get
            Set
                m_DateofBirth = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Genderid() As Nullable(Of Long)
            Get
                Return m_Genderid
            End Get
            Set
                m_Genderid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GenderGender() As String
            Get
                Return m_GenderGender
            End Get
            Set
                m_GenderGender = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StageAppliedto() As Nullable(Of Long)
            Get
                Return m_StageAppliedto
            End Get
            Set
                m_StageAppliedto = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StageAppliedtoShortDesc1() As String
            Get
                Return m_StageAppliedtoShortDesc1
            End Get
            Set
                m_StageAppliedtoShortDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeApplied() As Nullable(Of Long)
            Get
                Return m_GradeApplied
            End Get
            Set
                m_GradeApplied = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeAppliedShortDesc1() As String
            Get
                Return m_GradeAppliedShortDesc1
            End Get
            Set
                m_GradeAppliedShortDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeAppliedacdAcademicYear() As String
            Get
                Return m_GradeAppliedacdAcademicYear
            End Get
            Set
                m_GradeAppliedacdAcademicYear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeAppliedacdGlFinperiodFin_period_info() As String
            Get
                Return m_GradeAppliedacdGlFinperiodFin_period_info
            End Get
            Set
                m_GradeAppliedacdGlFinperiodFin_period_info = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeAppliedStageShortDesc1() As String
            Get
                Return m_GradeAppliedStageShortDesc1
            End Get
            Set
                m_GradeAppliedStageShortDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property AcademicYearto() As Nullable(Of Long)
            Get
                Return m_AcademicYearto
            End Get
            Set
                m_AcademicYearto = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property AcademicYeartoAcademicYear() As String
            Get
                Return m_AcademicYeartoAcademicYear
            End Get
            Set
                m_AcademicYeartoAcademicYear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property AcademicYeartoGlFinperiodFin_period_info() As String
            Get
                Return m_AcademicYeartoGlFinperiodFin_period_info
            End Get
            Set
                m_AcademicYeartoGlFinperiodFin_period_info = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property AcademicYeartoGlFinperiodaccountnumberAcc_Nm() As String
            Get
                Return m_AcademicYeartoGlFinperiodaccountnumberAcc_Nm
            End Get
            Set
                m_AcademicYeartoGlFinperiodaccountnumberAcc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property [Class]() As Nullable(Of Long)
            Get
                Return m_Class
            End Get
            Set
                m_Class = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ClassClassDesc1() As String
            Get
                Return m_ClassClassDesc1
            End Get
            Set
                m_ClassClassDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstatus_code() As Nullable(Of Long)
            Get
                Return m_Schstatus_code
            End Get
            Set
                m_Schstatus_code = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstatus_schstatus_name() As String
            Get
                Return m_Schstatus_schstatus_name
            End Get
            Set
                m_Schstatus_schstatus_name = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstudenttypid() As Nullable(Of Long)
            Get
                Return m_Schstudenttypid
            End Get
            Set
                m_Schstudenttypid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstudenttypschstudenttyp() As String
            Get
                Return m_Schstudenttypschstudenttyp
            End Get
            Set
                m_Schstudenttypschstudenttyp = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property id() As Nullable(Of Long)
            Get
                Return m_Id
            End Get
            Set
                m_Id = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Theidname_1() As String
            Get
                Return m_Theidname_1
            End Get
            Set
                m_Theidname_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CurrentSchool() As String
            Get
                Return m_CurrentSchool
            End Get
            Set
                m_CurrentSchool = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Remarks() As String
            Get
                Return m_Remarks
            End Get
            Set
                m_Remarks = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Fathertel() As String
            Get
                Return m_Fathertel
            End Get
            Set
                m_Fathertel = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Fathertel2() As String
            Get
                Return m_Fathertel2
            End Get
            Set
                m_Fathertel2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property passfail() As Nullable(Of Boolean)
            Get
                Return m_Passfail
            End Get
            Set
                m_Passfail = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property fromout() As Nullable(Of Boolean)
            Get
                Return m_Fromout
            End Get
            Set
                m_Fromout = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fatherjob() As String
            Get
                Return m_Fatherjob
            End Get
            Set
                m_Fatherjob = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fatheraddress() As String
            Get
                Return m_Fatheraddress
            End Get
            Set
                m_Fatheraddress = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property fathertel3() As String
            Get
                Return m_Fathertel3
            End Get
            Set
                m_Fathertel3 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fatheremail() As String
            Get
                Return m_Fatheremail
            End Get
            Set
                m_Fatheremail = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ageyear() As Nullable(Of Long)
            Get
                Return m_Ageyear
            End Get
            Set
                m_Ageyear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property agemonth() As Nullable(Of Long)
            Get
                Return m_Agemonth
            End Get
            Set
                m_Agemonth = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ageday() As Nullable(Of Long)
            Get
                Return m_Ageday
            End Get
            Set
                m_Ageday = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property homephone() As String
            Get
                Return m_Homephone
            End Get
            Set
                m_Homephone = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property printed() As Nullable(Of Long)
            Get
                Return m_Printed
            End Get
            Set
                m_Printed = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property BirthDocNo() As String
            Get
                Return m_BirthDocNo
            End Get
            Set
                m_BirthDocNo = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property birthdocdate() As Nullable(Of DateTime)
            Get
                Return m_Birthdocdate
            End Get
            Set
                m_Birthdocdate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property BirthDocPlace() As String
            Get
                Return m_BirthDocPlace
            End Get
            Set
                m_BirthDocPlace = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property BirthPlace() As String
            Get
                Return m_BirthPlace
            End Get
            Set
                m_BirthPlace = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Residencenumber() As String
            Get
                Return m_Residencenumber
            End Get
            Set
                m_Residencenumber = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ResidenceExpDate() As Nullable(Of DateTime)
            Get
                Return m_ResidenceExpDate
            End Get
            Set
                m_ResidenceExpDate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schsthlthcaseid() As Nullable(Of Long)
            Get
                Return m_Schsthlthcaseid
            End Get
            Set
                m_Schsthlthcaseid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schsthlthcaseschsthlthcaseDesc() As String
            Get
                Return m_SchsthlthcaseschsthlthcaseDesc
            End Get
            Set
                m_SchsthlthcaseschsthlthcaseDesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Cntry_No1() As Nullable(Of Long)
            Get
                Return m_Cntry_No1
            End Get
            Set
                m_Cntry_No1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Cntry_No1Cntry_Nm() As String
            Get
                Return m_Cntry_No1Cntry_Nm
            End Get
            Set
                m_Cntry_No1Cntry_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Cntry_No2() As Nullable(Of Long)
            Get
                Return m_Cntry_No2
            End Get
            Set
                m_Cntry_No2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Cntry_No2Cntry_Nm() As String
            Get
                Return m_Cntry_No2Cntry_Nm
            End Get
            Set
                m_Cntry_No2Cntry_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property state() As Nullable(Of Long)
            Get
                Return m_State
            End Get
            Set
                m_State = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property stateState_Nm() As String
            Get
                Return m_StateState_Nm
            End Get
            Set
                m_StateState_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property area() As Nullable(Of Long)
            Get
                Return m_Area
            End Get
            Set
                m_Area = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property areaDesc1() As String
            Get
                Return m_AreaDesc1
            End Get
            Set
                m_AreaDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property blockno() As String
            Get
                Return m_Blockno
            End Get
            Set
                m_Blockno = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property streetno() As String
            Get
                Return m_Streetno
            End Get
            Set
                m_Streetno = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property gadah() As String
            Get
                Return m_Gadah
            End Get
            Set
                m_Gadah = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property houseno() As String
            Get
                Return m_Houseno
            End Get
            Set
                m_Houseno = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property addressdetail() As String
            Get
                Return m_Addressdetail
            End Get
            Set
                m_Addressdetail = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property EmergencyTelNo1() As String
            Get
                Return m_EmergencyTelNo1
            End Get
            Set
                m_EmergencyTelNo1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property mothercase() As Nullable(Of Long)
            Get
                Return m_Mothercase
            End Get
            Set
                m_Mothercase = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property mothercasejob_desc() As String
            Get
                Return m_Mothercasejob_desc
            End Get
            Set
                m_Mothercasejob_desc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fathercase() As Nullable(Of Long)
            Get
                Return m_Fathercase
            End Get
            Set
                m_Fathercase = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fathercasejob_desc() As String
            Get
                Return m_Fathercasejob_desc
            End Get
            Set
                m_Fathercasejob_desc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property socialstatus() As Nullable(Of Long)
            Get
                Return m_Socialstatus
            End Get
            Set
                m_Socialstatus = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property socialstatusschsocialstatuscaseDesc() As String
            Get
                Return m_SocialstatusschsocialstatuscaseDesc
            End Get
            Set
                m_SocialstatusschsocialstatuscaseDesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentsefa() As Nullable(Of Long)
            Get
                Return m_Studentsefa
            End Get
            Set
                m_Studentsefa = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentsefastudentsefaar() As String
            Get
                Return m_Studentsefastudentsefaar
            End Get
            Set
                m_Studentsefastudentsefaar = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentsefadebitaccountAcc_Nm() As String
            Get
                Return m_StudentsefadebitaccountAcc_Nm
            End Get
            Set
                m_StudentsefadebitaccountAcc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentsefadebitaccountClsacc_Acc_Nm() As String
            Get
                Return m_StudentsefadebitaccountClsacc_Acc_Nm
            End Get
            Set
                m_StudentsefadebitaccountClsacc_Acc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentsefadebitaccountAcc_BndAcc_Nm() As String
            Get
                Return m_StudentsefadebitaccountAcc_BndAcc_Nm
            End Get
            Set
                m_StudentsefadebitaccountAcc_BndAcc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Schclasskindid() As Nullable(Of Long)
            Get
                Return m_Schclasskindid
            End Get
            Set
                m_Schclasskindid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property SchclasskindSchclasskinddesc() As String
            Get
                Return m_SchclasskindSchclasskinddesc
            End Get
            Set
                m_SchclasskindSchclasskinddesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstclasskinddmgid() As Nullable(Of Long)
            Get
                Return m_Schstclasskinddmgid
            End Get
            Set
                m_Schstclasskinddmgid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstclasskinddmgschstclasskinddmgDesc() As String
            Get
                Return m_SchstclasskinddmgschstclasskinddmgDesc
            End Get
            Set
                m_SchstclasskinddmgschstclasskinddmgDesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Schtransferid() As Nullable(Of Long)
            Get
                Return m_Schtransferid
            End Get
            Set
                m_Schtransferid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property SchtransferSchtransferDesc() As String
            Get
                Return m_SchtransferSchtransferDesc
            End Get
            Set
                m_SchtransferSchtransferDesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property classorder() As Nullable(Of Long)
            Get
                Return m_Classorder
            End Get
            Set
                m_Classorder = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ModifiedBy() As String
            Get
                Return m_ModifiedBy
            End Get
            Set
                m_ModifiedBy = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ModifiedOn() As Nullable(Of DateTime)
            Get
                Return m_ModifiedOn
            End Get
            Set
                m_ModifiedOn = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CreatedBy() As String
            Get
                Return m_CreatedBy
            End Get
            Set
                m_CreatedBy = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CreatedOn() As Nullable(Of DateTime)
            Get
                Return m_CreatedOn
            End Get
            Set
                m_CreatedOn = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property agarulyear() As Nullable(Of Single)
            Get
                Return m_Agarulyear
            End Get
            Set
                m_Agarulyear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property agarulmonth() As Nullable(Of Single)
            Get
                Return m_Agarulmonth
            End Get
            Set
                m_Agarulmonth = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property dateofcalculate() As Nullable(Of DateTime)
            Get
                Return m_Dateofcalculate
            End Get
            Set
                m_Dateofcalculate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property agarulyearmax() As Nullable(Of Single)
            Get
                Return m_Agarulyearmax
            End Get
            Set
                m_Agarulyearmax = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property agarulmonthmax() As Nullable(Of Single)
            Get
                Return m_Agarulmonthmax
            End Get
            Set
                m_Agarulmonthmax = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentBalance1() As Nullable(Of Decimal)
            Get
                Return m_StudentBalance1
            End Get
            Set
                m_StudentBalance1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property studentnotes() As String
            Get
                Return m_Studentnotes
            End Get
            Set
                m_Studentnotes = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property calssserial() As Nullable(Of Long)
            Get
                Return m_Calssserial
            End Get
            Set
                m_Calssserial = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property paidrosom() As Nullable(Of Single)
            Get
                Return m_Paidrosom
            End Get
            Set
                m_Paidrosom = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property parentsrelation() As Nullable(Of Long)
            Get
                Return m_Parentsrelation
            End Get
            Set
                m_Parentsrelation = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Theparentsrelationparentsrelationdesc() As String
            Get
                Return m_Theparentsrelationparentsrelationdesc
            End Get
            Set
                m_Theparentsrelationparentsrelationdesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentfullname1() As String
            Get
                Return m_Studentfullname1
            End Get
            Set
                m_Studentfullname1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property ApplicationCodeauto_1() As Nullable(Of Long)
            Get
                Return m_ApplicationCodeauto_1
            End Get
            Set
                m_ApplicationCodeauto_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property schtrnsid_1() As Nullable(Of Long)
            Get
                Return m_Schtrnsid_1
            End Get
            Set
                m_Schtrnsid_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schtrnsschtrnsDesc_1() As String
            Get
                Return m_SchtrnsschtrnsDesc_1
            End Get
            Set
                m_SchtrnsschtrnsDesc_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property branch_1() As Nullable(Of Long)
            Get
                Return m_Branch_1
            End Get
            Set
                m_Branch_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchDesc1_1() As String
            Get
                Return m_ThebranchDesc1_1
            End Get
            Set
                m_ThebranchDesc1_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Thebranchsgmsgm_Nm_1() As String
            Get
                Return m_Thebranchsgmsgm_Nm_1
            End Get
            Set
                m_Thebranchsgmsgm_Nm_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchsgmOpcoOpcoName_1() As String
            Get
                Return m_ThebranchsgmOpcoOpcoName_1
            End Get
            Set
                m_ThebranchsgmOpcoOpcoName_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchGenderGender_1() As String
            Get
                Return m_ThebranchGenderGender_1
            End Get
            Set
                m_ThebranchGenderGender_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ThebranchschtypschtypDesc_1() As String
            Get
                Return m_ThebranchschtypschtypDesc_1
            End Get
            Set
                m_ThebranchschtypschtypDesc_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property ApplicationDate_1() As Nullable(Of DateTime)
            Get
                Return m_ApplicationDate_1
            End Get
            Set
                m_ApplicationDate_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentCode_1() As Nullable(Of Long)
            Get
                Return m_StudentCode_1
            End Get
            Set
                m_StudentCode_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StudentSchstCivilidnumber_1() As String
            Get
                Return m_StudentSchstCivilidnumber_1
            End Get
            Set
                m_StudentSchstCivilidnumber_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property civilidst_1() As String
            Get
                Return m_Civilidst_1
            End Get
            Set
                m_Civilidst_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property studentfullname_1() As String
            Get
                Return m_Studentfullname_1
            End Get
            Set
                m_Studentfullname_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Fathername_1() As String
            Get
                Return m_Fathername_1
            End Get
            Set
                m_Fathername_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Cntry_No_1() As Nullable(Of Long)
            Get
                Return m_Cntry_No_1
            End Get
            Set
                m_Cntry_No_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Cntry_Cntry_Nm_1() As String
            Get
                Return m_Cntry_Cntry_Nm_1
            End Get
            Set
                m_Cntry_Cntry_Nm_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property DateofBirth_1() As Nullable(Of DateTime)
            Get
                Return m_DateofBirth_1
            End Get
            Set
                m_DateofBirth_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property Genderid_1() As Nullable(Of Long)
            Get
                Return m_Genderid_1
            End Get
            Set
                m_Genderid_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GenderGender_1() As String
            Get
                Return m_GenderGender_1
            End Get
            Set
                m_GenderGender_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StageAppliedto_1() As Nullable(Of Long)
            Get
                Return m_StageAppliedto_1
            End Get
            Set
                m_StageAppliedto_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StageAppliedtoShortDesc1_1() As String
            Get
                Return m_StageAppliedtoShortDesc1_1
            End Get
            Set
                m_StageAppliedtoShortDesc1_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeApplied_1() As Nullable(Of Long)
            Get
                Return m_GradeApplied_1
            End Get
            Set
                m_GradeApplied_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeAppliedShortDesc1_1() As String
            Get
                Return m_GradeAppliedShortDesc1_1
            End Get
            Set
                m_GradeAppliedShortDesc1_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeAppliedacdAcademicYear_1() As String
            Get
                Return m_GradeAppliedacdAcademicYear_1
            End Get
            Set
                m_GradeAppliedacdAcademicYear_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeAppliedacdGlFinperiodFin_period_info_1() As String
            Get
                Return m_GradeAppliedacdGlFinperiodFin_period_info_1
            End Get
            Set
                m_GradeAppliedacdGlFinperiodFin_period_info_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeAppliedStageShortDesc1_1() As String
            Get
                Return m_GradeAppliedStageShortDesc1_1
            End Get
            Set
                m_GradeAppliedStageShortDesc1_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property AcademicYearto_1() As Nullable(Of Long)
            Get
                Return m_AcademicYearto_1
            End Get
            Set
                m_AcademicYearto_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property AcademicYeartoAcademicYear_1() As String
            Get
                Return m_AcademicYeartoAcademicYear_1
            End Get
            Set
                m_AcademicYeartoAcademicYear_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property AcademicYeartoGlFinperiodFin_period_info_1() As String
            Get
                Return m_AcademicYeartoGlFinperiodFin_period_info_1
            End Get
            Set
                m_AcademicYeartoGlFinperiodFin_period_info_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property AcademicYeartoGlFinperiodaccountnumberAcc_Nm_1() As String
            Get
                Return m_AcademicYeartoGlFinperiodaccountnumberAcc_Nm_1
            End Get
            Set
                m_AcademicYeartoGlFinperiodaccountnumberAcc_Nm_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Class_1() As Nullable(Of Long)
            Get
                Return m_Class_1
            End Get
            Set
                m_Class_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ClassClassDesc1_1() As String
            Get
                Return m_ClassClassDesc1_1
            End Get
            Set
                m_ClassClassDesc1_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstatus_code_1() As Nullable(Of Long)
            Get
                Return m_Schstatus_code_1
            End Get
            Set
                m_Schstatus_code_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstatus_schstatus_name_1() As String
            Get
                Return m_Schstatus_schstatus_name_1
            End Get
            Set
                m_Schstatus_schstatus_name_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstudenttypid_1() As Nullable(Of Long)
            Get
                Return m_Schstudenttypid_1
            End Get
            Set
                m_Schstudenttypid_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstudenttypschstudenttyp_1() As String
            Get
                Return m_Schstudenttypschstudenttyp_1
            End Get
            Set
                m_Schstudenttypschstudenttyp_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property id_1() As Nullable(Of Long)
            Get
                Return m_Id_1
            End Get
            Set
                m_Id_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Theidname_1_1() As String
            Get
                Return m_Theidname_1_1
            End Get
            Set
                m_Theidname_1_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CurrentSchool_1() As String
            Get
                Return m_CurrentSchool_1
            End Get
            Set
                m_CurrentSchool_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Remarks_1() As String
            Get
                Return m_Remarks_1
            End Get
            Set
                m_Remarks_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Fathertel_1() As String
            Get
                Return m_Fathertel_1
            End Get
            Set
                m_Fathertel_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Fathertel2_1() As String
            Get
                Return m_Fathertel2_1
            End Get
            Set
                m_Fathertel2_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property passfail_1() As Nullable(Of Boolean)
            Get
                Return m_Passfail_1
            End Get
            Set
                m_Passfail_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property fromout_1() As Nullable(Of Boolean)
            Get
                Return m_Fromout_1
            End Get
            Set
                m_Fromout_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fatherjob_1() As String
            Get
                Return m_Fatherjob_1
            End Get
            Set
                m_Fatherjob_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fatheraddress_1() As String
            Get
                Return m_Fatheraddress_1
            End Get
            Set
                m_Fatheraddress_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property fathertel3_1() As String
            Get
                Return m_Fathertel3_1
            End Get
            Set
                m_Fathertel3_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fatheremail_1() As String
            Get
                Return m_Fatheremail_1
            End Get
            Set
                m_Fatheremail_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ageyear_1() As Nullable(Of Long)
            Get
                Return m_Ageyear_1
            End Get
            Set
                m_Ageyear_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property agemonth_1() As Nullable(Of Long)
            Get
                Return m_Agemonth_1
            End Get
            Set
                m_Agemonth_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ageday_1() As Nullable(Of Long)
            Get
                Return m_Ageday_1
            End Get
            Set
                m_Ageday_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property homephone_1() As String
            Get
                Return m_Homephone_1
            End Get
            Set
                m_Homephone_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property printed_1() As Nullable(Of Long)
            Get
                Return m_Printed_1
            End Get
            Set
                m_Printed_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property BirthDocNo_1() As String
            Get
                Return m_BirthDocNo_1
            End Get
            Set
                m_BirthDocNo_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property birthdocdate_1() As Nullable(Of DateTime)
            Get
                Return m_Birthdocdate_1
            End Get
            Set
                m_Birthdocdate_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property BirthDocPlace_1() As String
            Get
                Return m_BirthDocPlace_1
            End Get
            Set
                m_BirthDocPlace_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property BirthPlace_1() As String
            Get
                Return m_BirthPlace_1
            End Get
            Set
                m_BirthPlace_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Residencenumber_1() As String
            Get
                Return m_Residencenumber_1
            End Get
            Set
                m_Residencenumber_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ResidenceExpDate_1() As Nullable(Of DateTime)
            Get
                Return m_ResidenceExpDate_1
            End Get
            Set
                m_ResidenceExpDate_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schsthlthcaseid_1() As Nullable(Of Long)
            Get
                Return m_Schsthlthcaseid_1
            End Get
            Set
                m_Schsthlthcaseid_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schsthlthcaseschsthlthcaseDesc_1() As String
            Get
                Return m_SchsthlthcaseschsthlthcaseDesc_1
            End Get
            Set
                m_SchsthlthcaseschsthlthcaseDesc_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Cntry_No1_1() As Nullable(Of Long)
            Get
                Return m_Cntry_No1_1
            End Get
            Set
                m_Cntry_No1_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Cntry_No1Cntry_Nm_1() As String
            Get
                Return m_Cntry_No1Cntry_Nm_1
            End Get
            Set
                m_Cntry_No1Cntry_Nm_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Cntry_No2_1() As Nullable(Of Long)
            Get
                Return m_Cntry_No2_1
            End Get
            Set
                m_Cntry_No2_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Cntry_No2Cntry_Nm_1() As String
            Get
                Return m_Cntry_No2Cntry_Nm_1
            End Get
            Set
                m_Cntry_No2Cntry_Nm_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property state_1() As Nullable(Of Long)
            Get
                Return m_State_1
            End Get
            Set
                m_State_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property stateState_Nm_1() As String
            Get
                Return m_StateState_Nm_1
            End Get
            Set
                m_StateState_Nm_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property area_1() As Nullable(Of Long)
            Get
                Return m_Area_1
            End Get
            Set
                m_Area_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property areaDesc1_1() As String
            Get
                Return m_AreaDesc1_1
            End Get
            Set
                m_AreaDesc1_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property blockno_1() As String
            Get
                Return m_Blockno_1
            End Get
            Set
                m_Blockno_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property streetno_1() As String
            Get
                Return m_Streetno_1
            End Get
            Set
                m_Streetno_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property gadah_1() As String
            Get
                Return m_Gadah_1
            End Get
            Set
                m_Gadah_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property houseno_1() As String
            Get
                Return m_Houseno_1
            End Get
            Set
                m_Houseno_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property addressdetail_1() As String
            Get
                Return m_Addressdetail_1
            End Get
            Set
                m_Addressdetail_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property EmergencyTelNo1_1() As String
            Get
                Return m_EmergencyTelNo1_1
            End Get
            Set
                m_EmergencyTelNo1_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property mothercase_1() As Nullable(Of Long)
            Get
                Return m_Mothercase_1
            End Get
            Set
                m_Mothercase_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property mothercasejob_desc_1() As String
            Get
                Return m_Mothercasejob_desc_1
            End Get
            Set
                m_Mothercasejob_desc_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fathercase_1() As Nullable(Of Long)
            Get
                Return m_Fathercase_1
            End Get
            Set
                m_Fathercase_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fathercasejob_desc_1() As String
            Get
                Return m_Fathercasejob_desc_1
            End Get
            Set
                m_Fathercasejob_desc_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property socialstatus_1() As Nullable(Of Long)
            Get
                Return m_Socialstatus_1
            End Get
            Set
                m_Socialstatus_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property socialstatusschsocialstatuscaseDesc_1() As String
            Get
                Return m_SocialstatusschsocialstatuscaseDesc_1
            End Get
            Set
                m_SocialstatusschsocialstatuscaseDesc_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentsefa_1() As Nullable(Of Long)
            Get
                Return m_Studentsefa_1
            End Get
            Set
                m_Studentsefa_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentsefastudentsefaar_1() As String
            Get
                Return m_Studentsefastudentsefaar_1
            End Get
            Set
                m_Studentsefastudentsefaar_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentsefadebitaccountAcc_Nm_1() As String
            Get
                Return m_StudentsefadebitaccountAcc_Nm_1
            End Get
            Set
                m_StudentsefadebitaccountAcc_Nm_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentsefadebitaccountClsacc_Acc_Nm_1() As String
            Get
                Return m_StudentsefadebitaccountClsacc_Acc_Nm_1
            End Get
            Set
                m_StudentsefadebitaccountClsacc_Acc_Nm_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentsefadebitaccountAcc_BndAcc_Nm_1() As String
            Get
                Return m_StudentsefadebitaccountAcc_BndAcc_Nm_1
            End Get
            Set
                m_StudentsefadebitaccountAcc_BndAcc_Nm_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Schclasskindid_1() As Nullable(Of Long)
            Get
                Return m_Schclasskindid_1
            End Get
            Set
                m_Schclasskindid_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property SchclasskindSchclasskinddesc_1() As String
            Get
                Return m_SchclasskindSchclasskinddesc_1
            End Get
            Set
                m_SchclasskindSchclasskinddesc_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstclasskinddmgid_1() As Nullable(Of Long)
            Get
                Return m_Schstclasskinddmgid_1
            End Get
            Set
                m_Schstclasskinddmgid_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstclasskinddmgschstclasskinddmgDesc_1() As String
            Get
                Return m_SchstclasskinddmgschstclasskinddmgDesc_1
            End Get
            Set
                m_SchstclasskinddmgschstclasskinddmgDesc_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Schtransferid_1() As Nullable(Of Long)
            Get
                Return m_Schtransferid_1
            End Get
            Set
                m_Schtransferid_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property SchtransferSchtransferDesc_1() As String
            Get
                Return m_SchtransferSchtransferDesc_1
            End Get
            Set
                m_SchtransferSchtransferDesc_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property classorder_1() As Nullable(Of Long)
            Get
                Return m_Classorder_1
            End Get
            Set
                m_Classorder_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ModifiedBy_1() As String
            Get
                Return m_ModifiedBy_1
            End Get
            Set
                m_ModifiedBy_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ModifiedOn_1() As Nullable(Of DateTime)
            Get
                Return m_ModifiedOn_1
            End Get
            Set
                m_ModifiedOn_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CreatedBy_1() As String
            Get
                Return m_CreatedBy_1
            End Get
            Set
                m_CreatedBy_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CreatedOn_1() As Nullable(Of DateTime)
            Get
                Return m_CreatedOn_1
            End Get
            Set
                m_CreatedOn_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property agarulyear_1() As Nullable(Of Single)
            Get
                Return m_Agarulyear_1
            End Get
            Set
                m_Agarulyear_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property agarulmonth_1() As Nullable(Of Single)
            Get
                Return m_Agarulmonth_1
            End Get
            Set
                m_Agarulmonth_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property dateofcalculate_1() As Nullable(Of DateTime)
            Get
                Return m_Dateofcalculate_1
            End Get
            Set
                m_Dateofcalculate_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property agarulyearmax_1() As Nullable(Of Single)
            Get
                Return m_Agarulyearmax_1
            End Get
            Set
                m_Agarulyearmax_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property agarulmonthmax_1() As Nullable(Of Decimal)
            Get
                Return m_Agarulmonthmax_1
            End Get
            Set
                m_Agarulmonthmax_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property agarulmonthmax_2() As Nullable(Of Single)
            Get
                Return m_Agarulmonthmax_2
            End Get
            Set
                m_Agarulmonthmax_2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property calssserial_1() As Nullable(Of Long)
            Get
                Return m_Calssserial_1
            End Get
            Set
                m_Calssserial_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property paidrosom_1() As Nullable(Of Single)
            Get
                Return m_Paidrosom_1
            End Get
            Set
                m_Paidrosom_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property parentsrelation_1() As Nullable(Of Long)
            Get
                Return m_Parentsrelation_1
            End Get
            Set
                m_Parentsrelation_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Theparentsrelationparentsrelationdesc_1() As String
            Get
                Return m_Theparentsrelationparentsrelationdesc_1
            End Get
            Set
                m_Theparentsrelationparentsrelationdesc_1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentfullname1_1() As String
            Get
                Return m_Studentfullname1_1
            End Get
            Set
                m_Studentfullname1_1 = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select]( _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal studentareaDesc1 As String,  _
                    ByVal studentbranchDesc1 As String,  _
                    ByVal studentbranchsgmsgm_Nm As String,  _
                    ByVal studentbranchGenderGender As String,  _
                    ByVal studentbranchschtypschtypDesc As String,  _
                    ByVal studentCntry_Cntry_Nm As String,  _
                    ByVal studentGenderGender As String,  _
                    ByVal studentReligionReljan_nm As String,  _
                    ByVal studentstateState_Nm As String,  _
                    ByVal studentidname_1 As String,  _
                    ByVal studentacdAcademicYear As String,  _
                    ByVal studentacdGlFinperiodFin_period_info As String,  _
                    ByVal studentClassClassDesc1 As String,  _
                    ByVal studentSchclasskindSchclasskinddesc As String,  _
                    ByVal studentFatherfathfirstname1 As String,  _
                    ByVal studentFatherMaritalStatusStatus_Nm As String,  _
                    ByVal studentFatherareaDesc1 As String,  _
                    ByVal studentFatherCntry_Cntry_Nm As String,  _
                    ByVal studentFatherreligionReljan_nm As String,  _
                    ByVal studentFatherStateState_Nm As String,  _
                    ByVal studentFatherjob_job_desc As String,  _
                    ByVal studentGradeShortDesc1 As String,  _
                    ByVal studentGradeacdAcademicYear As String,  _
                    ByVal studentGradeStageShortDesc1 As String,  _
                    ByVal studentMotherfirstname1 As String,  _
                    ByVal studentMotherareaDesc1 As String,  _
                    ByVal studentMotherCntry_Cntry_Nm As String,  _
                    ByVal studentMotherreligionReljan_nm As String,  _
                    ByVal studentMotherStateState_Nm As String,  _
                    ByVal studentMotherjob_job_desc As String,  _
                    ByVal studentStageShortDesc1 As String,  _
                    ByVal studentschstatus_schstatus_name As String,  _
                    ByVal studentschstclasskinddmgschstclasskinddmgDesc As String,  _
                    ByVal studentschstsplschstsplDsc As String,  _
                    ByVal studentschsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal studentstudentsefastudentsefaar As String,  _
                    ByVal studentstudentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentschstudenttypschstudenttyp As String,  _
                    ByVal studentSchtransferSchtransferDesc As String,  _
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
                    ByVal gradeAppliedacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeAppliedStageShortDesc1 As String,  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal academicYeartoAcademicYear As String,  _
                    ByVal academicYeartoGlFinperiodFin_period_info As String,  _
                    ByVal academicYeartoGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
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
                    ByVal agarulyear As Nullable(Of Single),  _
                    ByVal agarulmonth As Nullable(Of Single),  _
                    ByVal dateofcalculate As Nullable(Of DateTime),  _
                    ByVal agarulyearmax As Nullable(Of Single),  _
                    ByVal agarulmonthmax As Nullable(Of Single),  _
                    ByVal studentBalance1 As Nullable(Of Decimal),  _
                    ByVal calssserial As Nullable(Of Long),  _
                    ByVal paidrosom As Nullable(Of Single),  _
                    ByVal parentsrelation As Nullable(Of Long),  _
                    ByVal theparentsrelationparentsrelationdesc As String,  _
                    ByVal applicationCodeauto_1 As Nullable(Of Long),  _
                    ByVal schtrnsid_1 As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc_1 As String,  _
                    ByVal branch_1 As Nullable(Of Long),  _
                    ByVal thebranchDesc1_1 As String,  _
                    ByVal thebranchsgmsgm_Nm_1 As String,  _
                    ByVal thebranchsgmOpcoOpcoName_1 As String,  _
                    ByVal thebranchGenderGender_1 As String,  _
                    ByVal thebranchschtypschtypDesc_1 As String,  _
                    ByVal applicationDate_1 As Nullable(Of DateTime),  _
                    ByVal studentCode_1 As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber_1 As String,  _
                    ByVal civilidst_1 As String,  _
                    ByVal fathername_1 As String,  _
                    ByVal cntry_No_1 As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm_1 As String,  _
                    ByVal dateofBirth_1 As Nullable(Of DateTime),  _
                    ByVal genderid_1 As Nullable(Of Long),  _
                    ByVal genderGender_1 As String,  _
                    ByVal stageAppliedto_1 As Nullable(Of Long),  _
                    ByVal stageAppliedtoShortDesc1_1 As String,  _
                    ByVal gradeApplied_1 As Nullable(Of Long),  _
                    ByVal gradeAppliedShortDesc1_1 As String,  _
                    ByVal gradeAppliedacdAcademicYear_1 As String,  _
                    ByVal gradeAppliedacdGlFinperiodFin_period_info_1 As String,  _
                    ByVal gradeAppliedStageShortDesc1_1 As String,  _
                    ByVal academicYearto_1 As Nullable(Of Long),  _
                    ByVal academicYeartoAcademicYear_1 As String,  _
                    ByVal academicYeartoGlFinperiodFin_period_info_1 As String,  _
                    ByVal academicYeartoGlFinperiodaccountnumberAcc_Nm_1 As String,  _
                    ByVal class_1 As Nullable(Of Long),  _
                    ByVal classClassDesc1_1 As String,  _
                    ByVal schstatus_code_1 As Nullable(Of Long),  _
                    ByVal schstatus_schstatus_name_1 As String,  _
                    ByVal schstudenttypid_1 As Nullable(Of Long),  _
                    ByVal schstudenttypschstudenttyp_1 As String,  _
                    ByVal id_1 As Nullable(Of Long),  _
                    ByVal theidname_1_1 As String,  _
                    ByVal currentSchool_1 As String,  _
                    ByVal remarks_1 As String,  _
                    ByVal fathertel_1 As String,  _
                    ByVal fathertel2_1 As String,  _
                    ByVal passfail_1 As Nullable(Of Boolean),  _
                    ByVal fatherjob_1 As String,  _
                    ByVal fatheraddress_1 As String,  _
                    ByVal fathertel3_1 As String,  _
                    ByVal fatheremail_1 As String,  _
                    ByVal ageyear_1 As Nullable(Of Long),  _
                    ByVal agemonth_1 As Nullable(Of Long),  _
                    ByVal ageday_1 As Nullable(Of Long),  _
                    ByVal homephone_1 As String,  _
                    ByVal printed_1 As Nullable(Of Long),  _
                    ByVal birthDocNo_1 As String,  _
                    ByVal birthdocdate_1 As Nullable(Of DateTime),  _
                    ByVal birthDocPlace_1 As String,  _
                    ByVal birthPlace_1 As String,  _
                    ByVal residencenumber_1 As String,  _
                    ByVal residenceExpDate_1 As Nullable(Of DateTime),  _
                    ByVal schsthlthcaseid_1 As Nullable(Of Long),  _
                    ByVal schsthlthcaseschsthlthcaseDesc_1 As String,  _
                    ByVal cntry_No1_1 As Nullable(Of Long),  _
                    ByVal cntry_No1Cntry_Nm_1 As String,  _
                    ByVal cntry_No2_1 As Nullable(Of Long),  _
                    ByVal cntry_No2Cntry_Nm_1 As String,  _
                    ByVal state_1 As Nullable(Of Long),  _
                    ByVal stateState_Nm_1 As String,  _
                    ByVal area_1 As Nullable(Of Long),  _
                    ByVal areaDesc1_1 As String,  _
                    ByVal blockno_1 As String,  _
                    ByVal streetno_1 As String,  _
                    ByVal gadah_1 As String,  _
                    ByVal houseno_1 As String,  _
                    ByVal emergencyTelNo1_1 As String,  _
                    ByVal mothercase_1 As Nullable(Of Long),  _
                    ByVal mothercasejob_desc_1 As String,  _
                    ByVal fathercase_1 As Nullable(Of Long),  _
                    ByVal fathercasejob_desc_1 As String,  _
                    ByVal socialstatus_1 As Nullable(Of Long),  _
                    ByVal socialstatusschsocialstatuscaseDesc_1 As String,  _
                    ByVal studentsefa_1 As Nullable(Of Long),  _
                    ByVal studentsefastudentsefaar_1 As String,  _
                    ByVal studentsefadebitaccountAcc_Nm_1 As String,  _
                    ByVal studentsefadebitaccountClsacc_Acc_Nm_1 As String,  _
                    ByVal studentsefadebitaccountAcc_BndAcc_Nm_1 As String,  _
                    ByVal schclasskindid_1 As Nullable(Of Long),  _
                    ByVal schclasskindSchclasskinddesc_1 As String,  _
                    ByVal schstclasskinddmgid_1 As Nullable(Of Long),  _
                    ByVal schstclasskinddmgschstclasskinddmgDesc_1 As String,  _
                    ByVal schtransferid_1 As Nullable(Of Long),  _
                    ByVal schtransferSchtransferDesc_1 As String,  _
                    ByVal classorder_1 As Nullable(Of Long),  _
                    ByVal modifiedBy_1 As String,  _
                    ByVal modifiedOn_1 As Nullable(Of DateTime),  _
                    ByVal createdBy_1 As String,  _
                    ByVal createdOn_1 As Nullable(Of DateTime),  _
                    ByVal agarulyear_1 As Nullable(Of Single),  _
                    ByVal agarulmonth_1 As Nullable(Of Single),  _
                    ByVal dateofcalculate_1 As Nullable(Of DateTime),  _
                    ByVal agarulyearmax_1 As Nullable(Of Single),  _
                    ByVal agarulmonthmax_1 As Nullable(Of Decimal),  _
                    ByVal agarulmonthmax_2 As Nullable(Of Single),  _
                    ByVal calssserial_1 As Nullable(Of Long),  _
                    ByVal paidrosom_1 As Nullable(Of Single),  _
                    ByVal parentsrelation_1 As Nullable(Of Long),  _
                    ByVal theparentsrelationparentsrelationdesc_1 As String) As List(Of eZee.Data.Objects.schApplication1001)
            Return New schApplication1001Factory().Select(applicationCodeauto, schtrnsid, schtrnsschtrnsDesc, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchschtypschtypDesc, applicationDate, studentCode, studentSchstCivilidnumber, studentareaDesc1, studentbranchDesc1, studentbranchsgmsgm_Nm, studentbranchGenderGender, studentbranchschtypschtypDesc, studentCntry_Cntry_Nm, studentGenderGender, studentReligionReljan_nm, studentstateState_Nm, studentidname_1, studentacdAcademicYear, studentacdGlFinperiodFin_period_info, studentClassClassDesc1, studentSchclasskindSchclasskinddesc, studentFatherfathfirstname1, studentFatherMaritalStatusStatus_Nm, studentFatherareaDesc1, studentFatherCntry_Cntry_Nm, studentFatherreligionReljan_nm, studentFatherStateState_Nm, studentFatherjob_job_desc, studentGradeShortDesc1, studentGradeacdAcademicYear, studentGradeStageShortDesc1, studentMotherfirstname1, studentMotherareaDesc1, studentMotherCntry_Cntry_Nm, studentMotherreligionReljan_nm, studentMotherStateState_Nm, studentMotherjob_job_desc, studentStageShortDesc1, studentschstatus_schstatus_name, studentschstclasskinddmgschstclasskinddmgDesc, studentschstsplschstsplDsc, studentschsthlthcaseschsthlthcaseDesc, studentstudentsefastudentsefaar, studentstudentsefadebitaccountAcc_Nm, studentschstudenttypschstudenttyp, studentSchtransferSchtransferDesc, fathername, cntry_No, cntry_Cntry_Nm, dateofBirth, genderid, genderGender, stageAppliedto, stageAppliedtoShortDesc1, gradeApplied, gradeAppliedShortDesc1, gradeAppliedacdAcademicYear, gradeAppliedacdGlFinperiodFin_period_info, gradeAppliedStageShortDesc1, academicYearto, academicYeartoAcademicYear, academicYeartoGlFinperiodFin_period_info, academicYeartoGlFinperiodaccountnumberAcc_Nm, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, id, theidname_1, currentSchool, remarks, fathertel, fathertel2, passfail, fatherjob, fatheraddress, fathertel3, fatheremail, ageyear, agemonth, ageday, homephone, printed, birthDocNo, birthdocdate, birthDocPlace, birthPlace, residencenumber, residenceExpDate, schsthlthcaseid, schsthlthcaseschsthlthcaseDesc, cntry_No1, cntry_No1Cntry_Nm, cntry_No2, cntry_No2Cntry_Nm, state, stateState_Nm, area, areaDesc1, blockno, streetno, gadah, houseno, emergencyTelNo1, mothercase, mothercasejob_desc, fathercase, fathercasejob_desc, socialstatus, socialstatusschsocialstatuscaseDesc, studentsefa, studentsefastudentsefaar, studentsefadebitaccountAcc_Nm, studentsefadebitaccountClsacc_Acc_Nm, studentsefadebitaccountAcc_BndAcc_Nm, schclasskindid, schclasskindSchclasskinddesc, schstclasskinddmgid, schstclasskinddmgschstclasskinddmgDesc, schtransferid, schtransferSchtransferDesc, classorder, modifiedBy, modifiedOn, createdBy, createdOn, agarulyear, agarulmonth, dateofcalculate, agarulyearmax, agarulmonthmax, studentBalance1, calssserial, paidrosom, parentsrelation, theparentsrelationparentsrelationdesc, applicationCodeauto_1, schtrnsid_1, schtrnsschtrnsDesc_1, branch_1, thebranchDesc1_1, thebranchsgmsgm_Nm_1, thebranchsgmOpcoOpcoName_1, thebranchGenderGender_1, thebranchschtypschtypDesc_1, applicationDate_1, studentCode_1, studentSchstCivilidnumber_1, civilidst_1, fathername_1, cntry_No_1, cntry_Cntry_Nm_1, dateofBirth_1, genderid_1, genderGender_1, stageAppliedto_1, stageAppliedtoShortDesc1_1, gradeApplied_1, gradeAppliedShortDesc1_1, gradeAppliedacdAcademicYear_1, gradeAppliedacdGlFinperiodFin_period_info_1, gradeAppliedStageShortDesc1_1, academicYearto_1, academicYeartoAcademicYear_1, academicYeartoGlFinperiodFin_period_info_1, academicYeartoGlFinperiodaccountnumberAcc_Nm_1, class_1, classClassDesc1_1, schstatus_code_1, schstatus_schstatus_name_1, schstudenttypid_1, schstudenttypschstudenttyp_1, id_1, theidname_1_1, currentSchool_1, remarks_1, fathertel_1, fathertel2_1, passfail_1, fatherjob_1, fatheraddress_1, fathertel3_1, fatheremail_1, ageyear_1, agemonth_1, ageday_1, homephone_1, printed_1, birthDocNo_1, birthdocdate_1, birthDocPlace_1, birthPlace_1, residencenumber_1, residenceExpDate_1, schsthlthcaseid_1, schsthlthcaseschsthlthcaseDesc_1, cntry_No1_1, cntry_No1Cntry_Nm_1, cntry_No2_1, cntry_No2Cntry_Nm_1, state_1, stateState_Nm_1, area_1, areaDesc1_1, blockno_1, streetno_1, gadah_1, houseno_1, emergencyTelNo1_1, mothercase_1, mothercasejob_desc_1, fathercase_1, fathercasejob_desc_1, socialstatus_1, socialstatusschsocialstatuscaseDesc_1, studentsefa_1, studentsefastudentsefaar_1, studentsefadebitaccountAcc_Nm_1, studentsefadebitaccountClsacc_Acc_Nm_1, studentsefadebitaccountAcc_BndAcc_Nm_1, schclasskindid_1, schclasskindSchclasskinddesc_1, schstclasskinddmgid_1, schstclasskinddmgschstclasskinddmgDesc_1, schtransferid_1, schtransferSchtransferDesc_1, classorder_1, modifiedBy_1, modifiedOn_1, createdBy_1, createdOn_1, agarulyear_1, agarulmonth_1, dateofcalculate_1, agarulyearmax_1, agarulmonthmax_1, agarulmonthmax_2, calssserial_1, paidrosom_1, parentsrelation_1, theparentsrelationparentsrelationdesc_1)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.schApplication1001) As List(Of eZee.Data.Objects.schApplication1001)
            Return New schApplication1001Factory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schApplication1001)
            Return New schApplication1001Factory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schApplication1001)
            Return New schApplication1001Factory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schApplication1001)
            Return New schApplication1001Factory().Select(filter, sort, schApplication1001Factory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schApplication1001)
            Return New schApplication1001Factory().Select(filter, sort, schApplication1001Factory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schApplication1001)
            Return New schApplication1001Factory().Select(filter, Nothing, schApplication1001Factory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schApplication1001)
            Return New schApplication1001Factory().Select(filter, Nothing, schApplication1001Factory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schApplication1001
            Return New schApplication1001Factory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.schApplication1001
            Return New schApplication1001Factory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal applicationCodeauto As Nullable(Of Long), ByVal applicationCodeauto_1 As Nullable(Of Long)) As eZee.Data.Objects.schApplication1001
            Return New schApplication1001Factory().SelectSingle(applicationCodeauto, applicationCodeauto_1)
        End Function
        
        Public Function Insert() As Integer
            Return New schApplication1001Factory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New schApplication1001Factory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New schApplication1001Factory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("ApplicationCodeauto: {0}; ApplicationCodeauto_1: {1}", Me.ApplicationCodeauto, Me.ApplicationCodeauto_1)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class schApplication1001Factory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("schApplication1001")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("schApplication1001")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("schApplication1001")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("schApplication1001")
            End Get
        End Property
        
        Public Shared Function Create() As schApplication1001Factory
            Return New schApplication1001Factory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal studentareaDesc1 As String,  _
                    ByVal studentbranchDesc1 As String,  _
                    ByVal studentbranchsgmsgm_Nm As String,  _
                    ByVal studentbranchGenderGender As String,  _
                    ByVal studentbranchschtypschtypDesc As String,  _
                    ByVal studentCntry_Cntry_Nm As String,  _
                    ByVal studentGenderGender As String,  _
                    ByVal studentReligionReljan_nm As String,  _
                    ByVal studentstateState_Nm As String,  _
                    ByVal studentidname_1 As String,  _
                    ByVal studentacdAcademicYear As String,  _
                    ByVal studentacdGlFinperiodFin_period_info As String,  _
                    ByVal studentClassClassDesc1 As String,  _
                    ByVal studentSchclasskindSchclasskinddesc As String,  _
                    ByVal studentFatherfathfirstname1 As String,  _
                    ByVal studentFatherMaritalStatusStatus_Nm As String,  _
                    ByVal studentFatherareaDesc1 As String,  _
                    ByVal studentFatherCntry_Cntry_Nm As String,  _
                    ByVal studentFatherreligionReljan_nm As String,  _
                    ByVal studentFatherStateState_Nm As String,  _
                    ByVal studentFatherjob_job_desc As String,  _
                    ByVal studentGradeShortDesc1 As String,  _
                    ByVal studentGradeacdAcademicYear As String,  _
                    ByVal studentGradeStageShortDesc1 As String,  _
                    ByVal studentMotherfirstname1 As String,  _
                    ByVal studentMotherareaDesc1 As String,  _
                    ByVal studentMotherCntry_Cntry_Nm As String,  _
                    ByVal studentMotherreligionReljan_nm As String,  _
                    ByVal studentMotherStateState_Nm As String,  _
                    ByVal studentMotherjob_job_desc As String,  _
                    ByVal studentStageShortDesc1 As String,  _
                    ByVal studentschstatus_schstatus_name As String,  _
                    ByVal studentschstclasskinddmgschstclasskinddmgDesc As String,  _
                    ByVal studentschstsplschstsplDsc As String,  _
                    ByVal studentschsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal studentstudentsefastudentsefaar As String,  _
                    ByVal studentstudentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentschstudenttypschstudenttyp As String,  _
                    ByVal studentSchtransferSchtransferDesc As String,  _
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
                    ByVal gradeAppliedacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeAppliedStageShortDesc1 As String,  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal academicYeartoAcademicYear As String,  _
                    ByVal academicYeartoGlFinperiodFin_period_info As String,  _
                    ByVal academicYeartoGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
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
                    ByVal agarulyear As Nullable(Of Single),  _
                    ByVal agarulmonth As Nullable(Of Single),  _
                    ByVal dateofcalculate As Nullable(Of DateTime),  _
                    ByVal agarulyearmax As Nullable(Of Single),  _
                    ByVal agarulmonthmax As Nullable(Of Single),  _
                    ByVal studentBalance1 As Nullable(Of Decimal),  _
                    ByVal calssserial As Nullable(Of Long),  _
                    ByVal paidrosom As Nullable(Of Single),  _
                    ByVal parentsrelation As Nullable(Of Long),  _
                    ByVal theparentsrelationparentsrelationdesc As String,  _
                    ByVal applicationCodeauto_1 As Nullable(Of Long),  _
                    ByVal schtrnsid_1 As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc_1 As String,  _
                    ByVal branch_1 As Nullable(Of Long),  _
                    ByVal thebranchDesc1_1 As String,  _
                    ByVal thebranchsgmsgm_Nm_1 As String,  _
                    ByVal thebranchsgmOpcoOpcoName_1 As String,  _
                    ByVal thebranchGenderGender_1 As String,  _
                    ByVal thebranchschtypschtypDesc_1 As String,  _
                    ByVal applicationDate_1 As Nullable(Of DateTime),  _
                    ByVal studentCode_1 As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber_1 As String,  _
                    ByVal civilidst_1 As String,  _
                    ByVal fathername_1 As String,  _
                    ByVal cntry_No_1 As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm_1 As String,  _
                    ByVal dateofBirth_1 As Nullable(Of DateTime),  _
                    ByVal genderid_1 As Nullable(Of Long),  _
                    ByVal genderGender_1 As String,  _
                    ByVal stageAppliedto_1 As Nullable(Of Long),  _
                    ByVal stageAppliedtoShortDesc1_1 As String,  _
                    ByVal gradeApplied_1 As Nullable(Of Long),  _
                    ByVal gradeAppliedShortDesc1_1 As String,  _
                    ByVal gradeAppliedacdAcademicYear_1 As String,  _
                    ByVal gradeAppliedacdGlFinperiodFin_period_info_1 As String,  _
                    ByVal gradeAppliedStageShortDesc1_1 As String,  _
                    ByVal academicYearto_1 As Nullable(Of Long),  _
                    ByVal academicYeartoAcademicYear_1 As String,  _
                    ByVal academicYeartoGlFinperiodFin_period_info_1 As String,  _
                    ByVal academicYeartoGlFinperiodaccountnumberAcc_Nm_1 As String,  _
                    ByVal class_1 As Nullable(Of Long),  _
                    ByVal classClassDesc1_1 As String,  _
                    ByVal schstatus_code_1 As Nullable(Of Long),  _
                    ByVal schstatus_schstatus_name_1 As String,  _
                    ByVal schstudenttypid_1 As Nullable(Of Long),  _
                    ByVal schstudenttypschstudenttyp_1 As String,  _
                    ByVal id_1 As Nullable(Of Long),  _
                    ByVal theidname_1_1 As String,  _
                    ByVal currentSchool_1 As String,  _
                    ByVal remarks_1 As String,  _
                    ByVal fathertel_1 As String,  _
                    ByVal fathertel2_1 As String,  _
                    ByVal passfail_1 As Nullable(Of Boolean),  _
                    ByVal fatherjob_1 As String,  _
                    ByVal fatheraddress_1 As String,  _
                    ByVal fathertel3_1 As String,  _
                    ByVal fatheremail_1 As String,  _
                    ByVal ageyear_1 As Nullable(Of Long),  _
                    ByVal agemonth_1 As Nullable(Of Long),  _
                    ByVal ageday_1 As Nullable(Of Long),  _
                    ByVal homephone_1 As String,  _
                    ByVal printed_1 As Nullable(Of Long),  _
                    ByVal birthDocNo_1 As String,  _
                    ByVal birthdocdate_1 As Nullable(Of DateTime),  _
                    ByVal birthDocPlace_1 As String,  _
                    ByVal birthPlace_1 As String,  _
                    ByVal residencenumber_1 As String,  _
                    ByVal residenceExpDate_1 As Nullable(Of DateTime),  _
                    ByVal schsthlthcaseid_1 As Nullable(Of Long),  _
                    ByVal schsthlthcaseschsthlthcaseDesc_1 As String,  _
                    ByVal cntry_No1_1 As Nullable(Of Long),  _
                    ByVal cntry_No1Cntry_Nm_1 As String,  _
                    ByVal cntry_No2_1 As Nullable(Of Long),  _
                    ByVal cntry_No2Cntry_Nm_1 As String,  _
                    ByVal state_1 As Nullable(Of Long),  _
                    ByVal stateState_Nm_1 As String,  _
                    ByVal area_1 As Nullable(Of Long),  _
                    ByVal areaDesc1_1 As String,  _
                    ByVal blockno_1 As String,  _
                    ByVal streetno_1 As String,  _
                    ByVal gadah_1 As String,  _
                    ByVal houseno_1 As String,  _
                    ByVal emergencyTelNo1_1 As String,  _
                    ByVal mothercase_1 As Nullable(Of Long),  _
                    ByVal mothercasejob_desc_1 As String,  _
                    ByVal fathercase_1 As Nullable(Of Long),  _
                    ByVal fathercasejob_desc_1 As String,  _
                    ByVal socialstatus_1 As Nullable(Of Long),  _
                    ByVal socialstatusschsocialstatuscaseDesc_1 As String,  _
                    ByVal studentsefa_1 As Nullable(Of Long),  _
                    ByVal studentsefastudentsefaar_1 As String,  _
                    ByVal studentsefadebitaccountAcc_Nm_1 As String,  _
                    ByVal studentsefadebitaccountClsacc_Acc_Nm_1 As String,  _
                    ByVal studentsefadebitaccountAcc_BndAcc_Nm_1 As String,  _
                    ByVal schclasskindid_1 As Nullable(Of Long),  _
                    ByVal schclasskindSchclasskinddesc_1 As String,  _
                    ByVal schstclasskinddmgid_1 As Nullable(Of Long),  _
                    ByVal schstclasskinddmgschstclasskinddmgDesc_1 As String,  _
                    ByVal schtransferid_1 As Nullable(Of Long),  _
                    ByVal schtransferSchtransferDesc_1 As String,  _
                    ByVal classorder_1 As Nullable(Of Long),  _
                    ByVal modifiedBy_1 As String,  _
                    ByVal modifiedOn_1 As Nullable(Of DateTime),  _
                    ByVal createdBy_1 As String,  _
                    ByVal createdOn_1 As Nullable(Of DateTime),  _
                    ByVal agarulyear_1 As Nullable(Of Single),  _
                    ByVal agarulmonth_1 As Nullable(Of Single),  _
                    ByVal dateofcalculate_1 As Nullable(Of DateTime),  _
                    ByVal agarulyearmax_1 As Nullable(Of Single),  _
                    ByVal agarulmonthmax_1 As Nullable(Of Decimal),  _
                    ByVal agarulmonthmax_2 As Nullable(Of Single),  _
                    ByVal calssserial_1 As Nullable(Of Long),  _
                    ByVal paidrosom_1 As Nullable(Of Single),  _
                    ByVal parentsrelation_1 As Nullable(Of Long),  _
                    ByVal theparentsrelationparentsrelationdesc_1 As String,  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If applicationCodeauto.HasValue Then
                filter.Add(("ApplicationCodeauto:=" + applicationCodeauto.Value.ToString()))
            End If
            If schtrnsid.HasValue Then
                filter.Add(("schtrnsid:=" + schtrnsid.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schtrnsschtrnsDesc)) Then
                filter.Add(("schtrnsschtrnsDesc:*" + schtrnsschtrnsDesc))
            End If
            If branch.HasValue Then
                filter.Add(("branch:=" + branch.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(thebranchDesc1)) Then
                filter.Add(("ThebranchDesc1:*" + thebranchDesc1))
            End If
            If Not (String.IsNullOrEmpty(thebranchsgmsgm_Nm)) Then
                filter.Add(("Thebranchsgmsgm_Nm:*" + thebranchsgmsgm_Nm))
            End If
            If Not (String.IsNullOrEmpty(thebranchsgmOpcoOpcoName)) Then
                filter.Add(("ThebranchsgmOpcoOpcoName:*" + thebranchsgmOpcoOpcoName))
            End If
            If Not (String.IsNullOrEmpty(thebranchGenderGender)) Then
                filter.Add(("ThebranchGenderGender:*" + thebranchGenderGender))
            End If
            If Not (String.IsNullOrEmpty(thebranchschtypschtypDesc)) Then
                filter.Add(("ThebranchschtypschtypDesc:*" + thebranchschtypschtypDesc))
            End If
            If applicationDate.HasValue Then
                filter.Add(("ApplicationDate:=" + applicationDate.Value.ToString()))
            End If
            If studentCode.HasValue Then
                filter.Add(("StudentCode:=" + studentCode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(studentSchstCivilidnumber)) Then
                filter.Add(("StudentSchstCivilidnumber:*" + studentSchstCivilidnumber))
            End If
            If Not (String.IsNullOrEmpty(studentareaDesc1)) Then
                filter.Add(("StudentareaDesc1:*" + studentareaDesc1))
            End If
            If Not (String.IsNullOrEmpty(studentbranchDesc1)) Then
                filter.Add(("StudentbranchDesc1:*" + studentbranchDesc1))
            End If
            If Not (String.IsNullOrEmpty(studentbranchsgmsgm_Nm)) Then
                filter.Add(("Studentbranchsgmsgm_Nm:*" + studentbranchsgmsgm_Nm))
            End If
            If Not (String.IsNullOrEmpty(studentbranchGenderGender)) Then
                filter.Add(("StudentbranchGenderGender:*" + studentbranchGenderGender))
            End If
            If Not (String.IsNullOrEmpty(studentbranchschtypschtypDesc)) Then
                filter.Add(("StudentbranchschtypschtypDesc:*" + studentbranchschtypschtypDesc))
            End If
            If Not (String.IsNullOrEmpty(studentCntry_Cntry_Nm)) Then
                filter.Add(("StudentCntry_Cntry_Nm:*" + studentCntry_Cntry_Nm))
            End If
            If Not (String.IsNullOrEmpty(studentGenderGender)) Then
                filter.Add(("StudentGenderGender:*" + studentGenderGender))
            End If
            If Not (String.IsNullOrEmpty(studentReligionReljan_nm)) Then
                filter.Add(("StudentReligionReljan_nm:*" + studentReligionReljan_nm))
            End If
            If Not (String.IsNullOrEmpty(studentstateState_Nm)) Then
                filter.Add(("StudentstateState_Nm:*" + studentstateState_Nm))
            End If
            If Not (String.IsNullOrEmpty(studentidname_1)) Then
                filter.Add(("Studentidname_1:*" + studentidname_1))
            End If
            If Not (String.IsNullOrEmpty(studentacdAcademicYear)) Then
                filter.Add(("StudentacdAcademicYear:*" + studentacdAcademicYear))
            End If
            If Not (String.IsNullOrEmpty(studentacdGlFinperiodFin_period_info)) Then
                filter.Add(("StudentacdGlFinperiodFin_period_info:*" + studentacdGlFinperiodFin_period_info))
            End If
            If Not (String.IsNullOrEmpty(studentClassClassDesc1)) Then
                filter.Add(("StudentClassClassDesc1:*" + studentClassClassDesc1))
            End If
            If Not (String.IsNullOrEmpty(studentSchclasskindSchclasskinddesc)) Then
                filter.Add(("StudentSchclasskindSchclasskinddesc:*" + studentSchclasskindSchclasskinddesc))
            End If
            If Not (String.IsNullOrEmpty(studentFatherfathfirstname1)) Then
                filter.Add(("StudentFatherfathfirstname1:*" + studentFatherfathfirstname1))
            End If
            If Not (String.IsNullOrEmpty(studentFatherMaritalStatusStatus_Nm)) Then
                filter.Add(("StudentFatherMaritalStatusStatus_Nm:*" + studentFatherMaritalStatusStatus_Nm))
            End If
            If Not (String.IsNullOrEmpty(studentFatherareaDesc1)) Then
                filter.Add(("StudentFatherareaDesc1:*" + studentFatherareaDesc1))
            End If
            If Not (String.IsNullOrEmpty(studentFatherCntry_Cntry_Nm)) Then
                filter.Add(("StudentFatherCntry_Cntry_Nm:*" + studentFatherCntry_Cntry_Nm))
            End If
            If Not (String.IsNullOrEmpty(studentFatherreligionReljan_nm)) Then
                filter.Add(("StudentFatherreligionReljan_nm:*" + studentFatherreligionReljan_nm))
            End If
            If Not (String.IsNullOrEmpty(studentFatherStateState_Nm)) Then
                filter.Add(("StudentFatherStateState_Nm:*" + studentFatherStateState_Nm))
            End If
            If Not (String.IsNullOrEmpty(studentFatherjob_job_desc)) Then
                filter.Add(("StudentFatherjob_job_desc:*" + studentFatherjob_job_desc))
            End If
            If Not (String.IsNullOrEmpty(studentGradeShortDesc1)) Then
                filter.Add(("StudentGradeShortDesc1:*" + studentGradeShortDesc1))
            End If
            If Not (String.IsNullOrEmpty(studentGradeacdAcademicYear)) Then
                filter.Add(("StudentGradeacdAcademicYear:*" + studentGradeacdAcademicYear))
            End If
            If Not (String.IsNullOrEmpty(studentGradeStageShortDesc1)) Then
                filter.Add(("StudentGradeStageShortDesc1:*" + studentGradeStageShortDesc1))
            End If
            If Not (String.IsNullOrEmpty(studentMotherfirstname1)) Then
                filter.Add(("StudentMotherfirstname1:*" + studentMotherfirstname1))
            End If
            If Not (String.IsNullOrEmpty(studentMotherareaDesc1)) Then
                filter.Add(("StudentMotherareaDesc1:*" + studentMotherareaDesc1))
            End If
            If Not (String.IsNullOrEmpty(studentMotherCntry_Cntry_Nm)) Then
                filter.Add(("StudentMotherCntry_Cntry_Nm:*" + studentMotherCntry_Cntry_Nm))
            End If
            If Not (String.IsNullOrEmpty(studentMotherreligionReljan_nm)) Then
                filter.Add(("StudentMotherreligionReljan_nm:*" + studentMotherreligionReljan_nm))
            End If
            If Not (String.IsNullOrEmpty(studentMotherStateState_Nm)) Then
                filter.Add(("StudentMotherStateState_Nm:*" + studentMotherStateState_Nm))
            End If
            If Not (String.IsNullOrEmpty(studentMotherjob_job_desc)) Then
                filter.Add(("StudentMotherjob_job_desc:*" + studentMotherjob_job_desc))
            End If
            If Not (String.IsNullOrEmpty(studentStageShortDesc1)) Then
                filter.Add(("StudentStageShortDesc1:*" + studentStageShortDesc1))
            End If
            If Not (String.IsNullOrEmpty(studentschstatus_schstatus_name)) Then
                filter.Add(("Studentschstatus_schstatus_name:*" + studentschstatus_schstatus_name))
            End If
            If Not (String.IsNullOrEmpty(studentschstclasskinddmgschstclasskinddmgDesc)) Then
                filter.Add(("StudentschstclasskinddmgschstclasskinddmgDesc:*" + studentschstclasskinddmgschstclasskinddmgDesc))
            End If
            If Not (String.IsNullOrEmpty(studentschstsplschstsplDsc)) Then
                filter.Add(("StudentschstsplschstsplDsc:*" + studentschstsplschstsplDsc))
            End If
            If Not (String.IsNullOrEmpty(studentschsthlthcaseschsthlthcaseDesc)) Then
                filter.Add(("StudentschsthlthcaseschsthlthcaseDesc:*" + studentschsthlthcaseschsthlthcaseDesc))
            End If
            If Not (String.IsNullOrEmpty(studentstudentsefastudentsefaar)) Then
                filter.Add(("Studentstudentsefastudentsefaar:*" + studentstudentsefastudentsefaar))
            End If
            If Not (String.IsNullOrEmpty(studentstudentsefadebitaccountAcc_Nm)) Then
                filter.Add(("StudentstudentsefadebitaccountAcc_Nm:*" + studentstudentsefadebitaccountAcc_Nm))
            End If
            If Not (String.IsNullOrEmpty(studentschstudenttypschstudenttyp)) Then
                filter.Add(("Studentschstudenttypschstudenttyp:*" + studentschstudenttypschstudenttyp))
            End If
            If Not (String.IsNullOrEmpty(studentSchtransferSchtransferDesc)) Then
                filter.Add(("StudentSchtransferSchtransferDesc:*" + studentSchtransferSchtransferDesc))
            End If
            If Not (String.IsNullOrEmpty(fathername)) Then
                filter.Add(("Fathername:*" + fathername))
            End If
            If cntry_No.HasValue Then
                filter.Add(("Cntry_No:=" + cntry_No.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(cntry_Cntry_Nm)) Then
                filter.Add(("Cntry_Cntry_Nm:*" + cntry_Cntry_Nm))
            End If
            If dateofBirth.HasValue Then
                filter.Add(("DateofBirth:=" + dateofBirth.Value.ToString()))
            End If
            If genderid.HasValue Then
                filter.Add(("Genderid:=" + genderid.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(genderGender)) Then
                filter.Add(("GenderGender:*" + genderGender))
            End If
            If stageAppliedto.HasValue Then
                filter.Add(("StageAppliedto:=" + stageAppliedto.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(stageAppliedtoShortDesc1)) Then
                filter.Add(("StageAppliedtoShortDesc1:*" + stageAppliedtoShortDesc1))
            End If
            If gradeApplied.HasValue Then
                filter.Add(("GradeApplied:=" + gradeApplied.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(gradeAppliedShortDesc1)) Then
                filter.Add(("GradeAppliedShortDesc1:*" + gradeAppliedShortDesc1))
            End If
            If Not (String.IsNullOrEmpty(gradeAppliedacdAcademicYear)) Then
                filter.Add(("GradeAppliedacdAcademicYear:*" + gradeAppliedacdAcademicYear))
            End If
            If Not (String.IsNullOrEmpty(gradeAppliedacdGlFinperiodFin_period_info)) Then
                filter.Add(("GradeAppliedacdGlFinperiodFin_period_info:*" + gradeAppliedacdGlFinperiodFin_period_info))
            End If
            If Not (String.IsNullOrEmpty(gradeAppliedStageShortDesc1)) Then
                filter.Add(("GradeAppliedStageShortDesc1:*" + gradeAppliedStageShortDesc1))
            End If
            If academicYearto.HasValue Then
                filter.Add(("AcademicYearto:=" + academicYearto.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(academicYeartoAcademicYear)) Then
                filter.Add(("AcademicYeartoAcademicYear:*" + academicYeartoAcademicYear))
            End If
            If Not (String.IsNullOrEmpty(academicYeartoGlFinperiodFin_period_info)) Then
                filter.Add(("AcademicYeartoGlFinperiodFin_period_info:*" + academicYeartoGlFinperiodFin_period_info))
            End If
            If Not (String.IsNullOrEmpty(academicYeartoGlFinperiodaccountnumberAcc_Nm)) Then
                filter.Add(("AcademicYeartoGlFinperiodaccountnumberAcc_Nm:*" + academicYeartoGlFinperiodaccountnumberAcc_Nm))
            End If
            If [class].HasValue Then
                filter.Add(("Class:=" + [class].Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(classClassDesc1)) Then
                filter.Add(("ClassClassDesc1:*" + classClassDesc1))
            End If
            If schstatus_code.HasValue Then
                filter.Add(("schstatus_code:=" + schstatus_code.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schstatus_schstatus_name)) Then
                filter.Add(("schstatus_schstatus_name:*" + schstatus_schstatus_name))
            End If
            If schstudenttypid.HasValue Then
                filter.Add(("schstudenttypid:=" + schstudenttypid.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schstudenttypschstudenttyp)) Then
                filter.Add(("schstudenttypschstudenttyp:*" + schstudenttypschstudenttyp))
            End If
            If id.HasValue Then
                filter.Add(("id:=" + id.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(theidname_1)) Then
                filter.Add(("Theidname_1:*" + theidname_1))
            End If
            If Not (String.IsNullOrEmpty(currentSchool)) Then
                filter.Add(("CurrentSchool:*" + currentSchool))
            End If
            If Not (String.IsNullOrEmpty(remarks)) Then
                filter.Add(("Remarks:*" + remarks))
            End If
            If Not (String.IsNullOrEmpty(fathertel)) Then
                filter.Add(("Fathertel:*" + fathertel))
            End If
            If Not (String.IsNullOrEmpty(fathertel2)) Then
                filter.Add(("Fathertel2:*" + fathertel2))
            End If
            If passfail.HasValue Then
                filter.Add(("passfail:=" + passfail.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(fatherjob)) Then
                filter.Add(("fatherjob:*" + fatherjob))
            End If
            If Not (String.IsNullOrEmpty(fatheraddress)) Then
                filter.Add(("fatheraddress:*" + fatheraddress))
            End If
            If Not (String.IsNullOrEmpty(fathertel3)) Then
                filter.Add(("fathertel3:*" + fathertel3))
            End If
            If Not (String.IsNullOrEmpty(fatheremail)) Then
                filter.Add(("fatheremail:*" + fatheremail))
            End If
            If ageyear.HasValue Then
                filter.Add(("ageyear:=" + ageyear.Value.ToString()))
            End If
            If agemonth.HasValue Then
                filter.Add(("agemonth:=" + agemonth.Value.ToString()))
            End If
            If ageday.HasValue Then
                filter.Add(("ageday:=" + ageday.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(homephone)) Then
                filter.Add(("homephone:*" + homephone))
            End If
            If printed.HasValue Then
                filter.Add(("printed:=" + printed.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(birthDocNo)) Then
                filter.Add(("BirthDocNo:*" + birthDocNo))
            End If
            If birthdocdate.HasValue Then
                filter.Add(("birthdocdate:=" + birthdocdate.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(birthDocPlace)) Then
                filter.Add(("BirthDocPlace:*" + birthDocPlace))
            End If
            If Not (String.IsNullOrEmpty(birthPlace)) Then
                filter.Add(("BirthPlace:*" + birthPlace))
            End If
            If Not (String.IsNullOrEmpty(residencenumber)) Then
                filter.Add(("Residencenumber:*" + residencenumber))
            End If
            If residenceExpDate.HasValue Then
                filter.Add(("ResidenceExpDate:=" + residenceExpDate.Value.ToString()))
            End If
            If schsthlthcaseid.HasValue Then
                filter.Add(("schsthlthcaseid:=" + schsthlthcaseid.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schsthlthcaseschsthlthcaseDesc)) Then
                filter.Add(("schsthlthcaseschsthlthcaseDesc:*" + schsthlthcaseschsthlthcaseDesc))
            End If
            If cntry_No1.HasValue Then
                filter.Add(("Cntry_No1:=" + cntry_No1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(cntry_No1Cntry_Nm)) Then
                filter.Add(("Cntry_No1Cntry_Nm:*" + cntry_No1Cntry_Nm))
            End If
            If cntry_No2.HasValue Then
                filter.Add(("Cntry_No2:=" + cntry_No2.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(cntry_No2Cntry_Nm)) Then
                filter.Add(("Cntry_No2Cntry_Nm:*" + cntry_No2Cntry_Nm))
            End If
            If state.HasValue Then
                filter.Add(("state:=" + state.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(stateState_Nm)) Then
                filter.Add(("stateState_Nm:*" + stateState_Nm))
            End If
            If area.HasValue Then
                filter.Add(("area:=" + area.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(areaDesc1)) Then
                filter.Add(("areaDesc1:*" + areaDesc1))
            End If
            If Not (String.IsNullOrEmpty(blockno)) Then
                filter.Add(("blockno:*" + blockno))
            End If
            If Not (String.IsNullOrEmpty(streetno)) Then
                filter.Add(("streetno:*" + streetno))
            End If
            If Not (String.IsNullOrEmpty(gadah)) Then
                filter.Add(("gadah:*" + gadah))
            End If
            If Not (String.IsNullOrEmpty(houseno)) Then
                filter.Add(("houseno:*" + houseno))
            End If
            If Not (String.IsNullOrEmpty(emergencyTelNo1)) Then
                filter.Add(("EmergencyTelNo1:*" + emergencyTelNo1))
            End If
            If mothercase.HasValue Then
                filter.Add(("mothercase:=" + mothercase.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(mothercasejob_desc)) Then
                filter.Add(("mothercasejob_desc:*" + mothercasejob_desc))
            End If
            If fathercase.HasValue Then
                filter.Add(("fathercase:=" + fathercase.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(fathercasejob_desc)) Then
                filter.Add(("fathercasejob_desc:*" + fathercasejob_desc))
            End If
            If socialstatus.HasValue Then
                filter.Add(("socialstatus:=" + socialstatus.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(socialstatusschsocialstatuscaseDesc)) Then
                filter.Add(("socialstatusschsocialstatuscaseDesc:*" + socialstatusschsocialstatuscaseDesc))
            End If
            If studentsefa.HasValue Then
                filter.Add(("studentsefa:=" + studentsefa.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(studentsefastudentsefaar)) Then
                filter.Add(("studentsefastudentsefaar:*" + studentsefastudentsefaar))
            End If
            If Not (String.IsNullOrEmpty(studentsefadebitaccountAcc_Nm)) Then
                filter.Add(("studentsefadebitaccountAcc_Nm:*" + studentsefadebitaccountAcc_Nm))
            End If
            If Not (String.IsNullOrEmpty(studentsefadebitaccountClsacc_Acc_Nm)) Then
                filter.Add(("studentsefadebitaccountClsacc_Acc_Nm:*" + studentsefadebitaccountClsacc_Acc_Nm))
            End If
            If Not (String.IsNullOrEmpty(studentsefadebitaccountAcc_BndAcc_Nm)) Then
                filter.Add(("studentsefadebitaccountAcc_BndAcc_Nm:*" + studentsefadebitaccountAcc_BndAcc_Nm))
            End If
            If schclasskindid.HasValue Then
                filter.Add(("Schclasskindid:=" + schclasskindid.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schclasskindSchclasskinddesc)) Then
                filter.Add(("SchclasskindSchclasskinddesc:*" + schclasskindSchclasskinddesc))
            End If
            If schstclasskinddmgid.HasValue Then
                filter.Add(("schstclasskinddmgid:=" + schstclasskinddmgid.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schstclasskinddmgschstclasskinddmgDesc)) Then
                filter.Add(("schstclasskinddmgschstclasskinddmgDesc:*" + schstclasskinddmgschstclasskinddmgDesc))
            End If
            If schtransferid.HasValue Then
                filter.Add(("Schtransferid:=" + schtransferid.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schtransferSchtransferDesc)) Then
                filter.Add(("SchtransferSchtransferDesc:*" + schtransferSchtransferDesc))
            End If
            If classorder.HasValue Then
                filter.Add(("classorder:=" + classorder.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(modifiedBy)) Then
                filter.Add(("ModifiedBy:*" + modifiedBy))
            End If
            If modifiedOn.HasValue Then
                filter.Add(("ModifiedOn:=" + modifiedOn.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(createdBy)) Then
                filter.Add(("CreatedBy:*" + createdBy))
            End If
            If createdOn.HasValue Then
                filter.Add(("CreatedOn:=" + createdOn.Value.ToString()))
            End If
            If agarulyear.HasValue Then
                filter.Add(("agarulyear:=" + agarulyear.Value.ToString()))
            End If
            If agarulmonth.HasValue Then
                filter.Add(("agarulmonth:=" + agarulmonth.Value.ToString()))
            End If
            If dateofcalculate.HasValue Then
                filter.Add(("dateofcalculate:=" + dateofcalculate.Value.ToString()))
            End If
            If agarulyearmax.HasValue Then
                filter.Add(("agarulyearmax:=" + agarulyearmax.Value.ToString()))
            End If
            If agarulmonthmax.HasValue Then
                filter.Add(("agarulmonthmax:=" + agarulmonthmax.Value.ToString()))
            End If
            If studentBalance1.HasValue Then
                filter.Add(("studentBalance1:=" + studentBalance1.Value.ToString()))
            End If
            If calssserial.HasValue Then
                filter.Add(("calssserial:=" + calssserial.Value.ToString()))
            End If
            If paidrosom.HasValue Then
                filter.Add(("paidrosom:=" + paidrosom.Value.ToString()))
            End If
            If parentsrelation.HasValue Then
                filter.Add(("parentsrelation:=" + parentsrelation.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(theparentsrelationparentsrelationdesc)) Then
                filter.Add(("Theparentsrelationparentsrelationdesc:*" + theparentsrelationparentsrelationdesc))
            End If
            If applicationCodeauto_1.HasValue Then
                filter.Add(("ApplicationCodeauto_1:=" + applicationCodeauto_1.Value.ToString()))
            End If
            If schtrnsid_1.HasValue Then
                filter.Add(("schtrnsid_1:=" + schtrnsid_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schtrnsschtrnsDesc_1)) Then
                filter.Add(("schtrnsschtrnsDesc_1:*" + schtrnsschtrnsDesc_1))
            End If
            If branch_1.HasValue Then
                filter.Add(("branch_1:=" + branch_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(thebranchDesc1_1)) Then
                filter.Add(("ThebranchDesc1_1:*" + thebranchDesc1_1))
            End If
            If Not (String.IsNullOrEmpty(thebranchsgmsgm_Nm_1)) Then
                filter.Add(("Thebranchsgmsgm_Nm_1:*" + thebranchsgmsgm_Nm_1))
            End If
            If Not (String.IsNullOrEmpty(thebranchsgmOpcoOpcoName_1)) Then
                filter.Add(("ThebranchsgmOpcoOpcoName_1:*" + thebranchsgmOpcoOpcoName_1))
            End If
            If Not (String.IsNullOrEmpty(thebranchGenderGender_1)) Then
                filter.Add(("ThebranchGenderGender_1:*" + thebranchGenderGender_1))
            End If
            If Not (String.IsNullOrEmpty(thebranchschtypschtypDesc_1)) Then
                filter.Add(("ThebranchschtypschtypDesc_1:*" + thebranchschtypschtypDesc_1))
            End If
            If applicationDate_1.HasValue Then
                filter.Add(("ApplicationDate_1:=" + applicationDate_1.Value.ToString()))
            End If
            If studentCode_1.HasValue Then
                filter.Add(("StudentCode_1:=" + studentCode_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(studentSchstCivilidnumber_1)) Then
                filter.Add(("StudentSchstCivilidnumber_1:*" + studentSchstCivilidnumber_1))
            End If
            If Not (String.IsNullOrEmpty(civilidst_1)) Then
                filter.Add(("civilidst_1:*" + civilidst_1))
            End If
            If Not (String.IsNullOrEmpty(fathername_1)) Then
                filter.Add(("Fathername_1:*" + fathername_1))
            End If
            If cntry_No_1.HasValue Then
                filter.Add(("Cntry_No_1:=" + cntry_No_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(cntry_Cntry_Nm_1)) Then
                filter.Add(("Cntry_Cntry_Nm_1:*" + cntry_Cntry_Nm_1))
            End If
            If dateofBirth_1.HasValue Then
                filter.Add(("DateofBirth_1:=" + dateofBirth_1.Value.ToString()))
            End If
            If genderid_1.HasValue Then
                filter.Add(("Genderid_1:=" + genderid_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(genderGender_1)) Then
                filter.Add(("GenderGender_1:*" + genderGender_1))
            End If
            If stageAppliedto_1.HasValue Then
                filter.Add(("StageAppliedto_1:=" + stageAppliedto_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(stageAppliedtoShortDesc1_1)) Then
                filter.Add(("StageAppliedtoShortDesc1_1:*" + stageAppliedtoShortDesc1_1))
            End If
            If gradeApplied_1.HasValue Then
                filter.Add(("GradeApplied_1:=" + gradeApplied_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(gradeAppliedShortDesc1_1)) Then
                filter.Add(("GradeAppliedShortDesc1_1:*" + gradeAppliedShortDesc1_1))
            End If
            If Not (String.IsNullOrEmpty(gradeAppliedacdAcademicYear_1)) Then
                filter.Add(("GradeAppliedacdAcademicYear_1:*" + gradeAppliedacdAcademicYear_1))
            End If
            If Not (String.IsNullOrEmpty(gradeAppliedacdGlFinperiodFin_period_info_1)) Then
                filter.Add(("GradeAppliedacdGlFinperiodFin_period_info_1:*" + gradeAppliedacdGlFinperiodFin_period_info_1))
            End If
            If Not (String.IsNullOrEmpty(gradeAppliedStageShortDesc1_1)) Then
                filter.Add(("GradeAppliedStageShortDesc1_1:*" + gradeAppliedStageShortDesc1_1))
            End If
            If academicYearto_1.HasValue Then
                filter.Add(("AcademicYearto_1:=" + academicYearto_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(academicYeartoAcademicYear_1)) Then
                filter.Add(("AcademicYeartoAcademicYear_1:*" + academicYeartoAcademicYear_1))
            End If
            If Not (String.IsNullOrEmpty(academicYeartoGlFinperiodFin_period_info_1)) Then
                filter.Add(("AcademicYeartoGlFinperiodFin_period_info_1:*" + academicYeartoGlFinperiodFin_period_info_1))
            End If
            If Not (String.IsNullOrEmpty(academicYeartoGlFinperiodaccountnumberAcc_Nm_1)) Then
                filter.Add(("AcademicYeartoGlFinperiodaccountnumberAcc_Nm_1:*" + academicYeartoGlFinperiodaccountnumberAcc_Nm_1))
            End If
            If class_1.HasValue Then
                filter.Add(("Class_1:=" + class_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(classClassDesc1_1)) Then
                filter.Add(("ClassClassDesc1_1:*" + classClassDesc1_1))
            End If
            If schstatus_code_1.HasValue Then
                filter.Add(("schstatus_code_1:=" + schstatus_code_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schstatus_schstatus_name_1)) Then
                filter.Add(("schstatus_schstatus_name_1:*" + schstatus_schstatus_name_1))
            End If
            If schstudenttypid_1.HasValue Then
                filter.Add(("schstudenttypid_1:=" + schstudenttypid_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schstudenttypschstudenttyp_1)) Then
                filter.Add(("schstudenttypschstudenttyp_1:*" + schstudenttypschstudenttyp_1))
            End If
            If id_1.HasValue Then
                filter.Add(("id_1:=" + id_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(theidname_1_1)) Then
                filter.Add(("Theidname_1_1:*" + theidname_1_1))
            End If
            If Not (String.IsNullOrEmpty(currentSchool_1)) Then
                filter.Add(("CurrentSchool_1:*" + currentSchool_1))
            End If
            If Not (String.IsNullOrEmpty(remarks_1)) Then
                filter.Add(("Remarks_1:*" + remarks_1))
            End If
            If Not (String.IsNullOrEmpty(fathertel_1)) Then
                filter.Add(("Fathertel_1:*" + fathertel_1))
            End If
            If Not (String.IsNullOrEmpty(fathertel2_1)) Then
                filter.Add(("Fathertel2_1:*" + fathertel2_1))
            End If
            If passfail_1.HasValue Then
                filter.Add(("passfail_1:=" + passfail_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(fatherjob_1)) Then
                filter.Add(("fatherjob_1:*" + fatherjob_1))
            End If
            If Not (String.IsNullOrEmpty(fatheraddress_1)) Then
                filter.Add(("fatheraddress_1:*" + fatheraddress_1))
            End If
            If Not (String.IsNullOrEmpty(fathertel3_1)) Then
                filter.Add(("fathertel3_1:*" + fathertel3_1))
            End If
            If Not (String.IsNullOrEmpty(fatheremail_1)) Then
                filter.Add(("fatheremail_1:*" + fatheremail_1))
            End If
            If ageyear_1.HasValue Then
                filter.Add(("ageyear_1:=" + ageyear_1.Value.ToString()))
            End If
            If agemonth_1.HasValue Then
                filter.Add(("agemonth_1:=" + agemonth_1.Value.ToString()))
            End If
            If ageday_1.HasValue Then
                filter.Add(("ageday_1:=" + ageday_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(homephone_1)) Then
                filter.Add(("homephone_1:*" + homephone_1))
            End If
            If printed_1.HasValue Then
                filter.Add(("printed_1:=" + printed_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(birthDocNo_1)) Then
                filter.Add(("BirthDocNo_1:*" + birthDocNo_1))
            End If
            If birthdocdate_1.HasValue Then
                filter.Add(("birthdocdate_1:=" + birthdocdate_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(birthDocPlace_1)) Then
                filter.Add(("BirthDocPlace_1:*" + birthDocPlace_1))
            End If
            If Not (String.IsNullOrEmpty(birthPlace_1)) Then
                filter.Add(("BirthPlace_1:*" + birthPlace_1))
            End If
            If Not (String.IsNullOrEmpty(residencenumber_1)) Then
                filter.Add(("Residencenumber_1:*" + residencenumber_1))
            End If
            If residenceExpDate_1.HasValue Then
                filter.Add(("ResidenceExpDate_1:=" + residenceExpDate_1.Value.ToString()))
            End If
            If schsthlthcaseid_1.HasValue Then
                filter.Add(("schsthlthcaseid_1:=" + schsthlthcaseid_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schsthlthcaseschsthlthcaseDesc_1)) Then
                filter.Add(("schsthlthcaseschsthlthcaseDesc_1:*" + schsthlthcaseschsthlthcaseDesc_1))
            End If
            If cntry_No1_1.HasValue Then
                filter.Add(("Cntry_No1_1:=" + cntry_No1_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(cntry_No1Cntry_Nm_1)) Then
                filter.Add(("Cntry_No1Cntry_Nm_1:*" + cntry_No1Cntry_Nm_1))
            End If
            If cntry_No2_1.HasValue Then
                filter.Add(("Cntry_No2_1:=" + cntry_No2_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(cntry_No2Cntry_Nm_1)) Then
                filter.Add(("Cntry_No2Cntry_Nm_1:*" + cntry_No2Cntry_Nm_1))
            End If
            If state_1.HasValue Then
                filter.Add(("state_1:=" + state_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(stateState_Nm_1)) Then
                filter.Add(("stateState_Nm_1:*" + stateState_Nm_1))
            End If
            If area_1.HasValue Then
                filter.Add(("area_1:=" + area_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(areaDesc1_1)) Then
                filter.Add(("areaDesc1_1:*" + areaDesc1_1))
            End If
            If Not (String.IsNullOrEmpty(blockno_1)) Then
                filter.Add(("blockno_1:*" + blockno_1))
            End If
            If Not (String.IsNullOrEmpty(streetno_1)) Then
                filter.Add(("streetno_1:*" + streetno_1))
            End If
            If Not (String.IsNullOrEmpty(gadah_1)) Then
                filter.Add(("gadah_1:*" + gadah_1))
            End If
            If Not (String.IsNullOrEmpty(houseno_1)) Then
                filter.Add(("houseno_1:*" + houseno_1))
            End If
            If Not (String.IsNullOrEmpty(emergencyTelNo1_1)) Then
                filter.Add(("EmergencyTelNo1_1:*" + emergencyTelNo1_1))
            End If
            If mothercase_1.HasValue Then
                filter.Add(("mothercase_1:=" + mothercase_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(mothercasejob_desc_1)) Then
                filter.Add(("mothercasejob_desc_1:*" + mothercasejob_desc_1))
            End If
            If fathercase_1.HasValue Then
                filter.Add(("fathercase_1:=" + fathercase_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(fathercasejob_desc_1)) Then
                filter.Add(("fathercasejob_desc_1:*" + fathercasejob_desc_1))
            End If
            If socialstatus_1.HasValue Then
                filter.Add(("socialstatus_1:=" + socialstatus_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(socialstatusschsocialstatuscaseDesc_1)) Then
                filter.Add(("socialstatusschsocialstatuscaseDesc_1:*" + socialstatusschsocialstatuscaseDesc_1))
            End If
            If studentsefa_1.HasValue Then
                filter.Add(("studentsefa_1:=" + studentsefa_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(studentsefastudentsefaar_1)) Then
                filter.Add(("studentsefastudentsefaar_1:*" + studentsefastudentsefaar_1))
            End If
            If Not (String.IsNullOrEmpty(studentsefadebitaccountAcc_Nm_1)) Then
                filter.Add(("studentsefadebitaccountAcc_Nm_1:*" + studentsefadebitaccountAcc_Nm_1))
            End If
            If Not (String.IsNullOrEmpty(studentsefadebitaccountClsacc_Acc_Nm_1)) Then
                filter.Add(("studentsefadebitaccountClsacc_Acc_Nm_1:*" + studentsefadebitaccountClsacc_Acc_Nm_1))
            End If
            If Not (String.IsNullOrEmpty(studentsefadebitaccountAcc_BndAcc_Nm_1)) Then
                filter.Add(("studentsefadebitaccountAcc_BndAcc_Nm_1:*" + studentsefadebitaccountAcc_BndAcc_Nm_1))
            End If
            If schclasskindid_1.HasValue Then
                filter.Add(("Schclasskindid_1:=" + schclasskindid_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schclasskindSchclasskinddesc_1)) Then
                filter.Add(("SchclasskindSchclasskinddesc_1:*" + schclasskindSchclasskinddesc_1))
            End If
            If schstclasskinddmgid_1.HasValue Then
                filter.Add(("schstclasskinddmgid_1:=" + schstclasskinddmgid_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schstclasskinddmgschstclasskinddmgDesc_1)) Then
                filter.Add(("schstclasskinddmgschstclasskinddmgDesc_1:*" + schstclasskinddmgschstclasskinddmgDesc_1))
            End If
            If schtransferid_1.HasValue Then
                filter.Add(("Schtransferid_1:=" + schtransferid_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schtransferSchtransferDesc_1)) Then
                filter.Add(("SchtransferSchtransferDesc_1:*" + schtransferSchtransferDesc_1))
            End If
            If classorder_1.HasValue Then
                filter.Add(("classorder_1:=" + classorder_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(modifiedBy_1)) Then
                filter.Add(("ModifiedBy_1:*" + modifiedBy_1))
            End If
            If modifiedOn_1.HasValue Then
                filter.Add(("ModifiedOn_1:=" + modifiedOn_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(createdBy_1)) Then
                filter.Add(("CreatedBy_1:*" + createdBy_1))
            End If
            If createdOn_1.HasValue Then
                filter.Add(("CreatedOn_1:=" + createdOn_1.Value.ToString()))
            End If
            If agarulyear_1.HasValue Then
                filter.Add(("agarulyear_1:=" + agarulyear_1.Value.ToString()))
            End If
            If agarulmonth_1.HasValue Then
                filter.Add(("agarulmonth_1:=" + agarulmonth_1.Value.ToString()))
            End If
            If dateofcalculate_1.HasValue Then
                filter.Add(("dateofcalculate_1:=" + dateofcalculate_1.Value.ToString()))
            End If
            If agarulyearmax_1.HasValue Then
                filter.Add(("agarulyearmax_1:=" + agarulyearmax_1.Value.ToString()))
            End If
            If agarulmonthmax_1.HasValue Then
                filter.Add(("agarulmonthmax_1:=" + agarulmonthmax_1.Value.ToString()))
            End If
            If agarulmonthmax_2.HasValue Then
                filter.Add(("agarulmonthmax_2:=" + agarulmonthmax_2.Value.ToString()))
            End If
            If calssserial_1.HasValue Then
                filter.Add(("calssserial_1:=" + calssserial_1.Value.ToString()))
            End If
            If paidrosom_1.HasValue Then
                filter.Add(("paidrosom_1:=" + paidrosom_1.Value.ToString()))
            End If
            If parentsrelation_1.HasValue Then
                filter.Add(("parentsrelation_1:=" + parentsrelation_1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(theparentsrelationparentsrelationdesc_1)) Then
                filter.Add(("Theparentsrelationparentsrelationdesc_1:*" + theparentsrelationparentsrelationdesc_1))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal studentareaDesc1 As String,  _
                    ByVal studentbranchDesc1 As String,  _
                    ByVal studentbranchsgmsgm_Nm As String,  _
                    ByVal studentbranchGenderGender As String,  _
                    ByVal studentbranchschtypschtypDesc As String,  _
                    ByVal studentCntry_Cntry_Nm As String,  _
                    ByVal studentGenderGender As String,  _
                    ByVal studentReligionReljan_nm As String,  _
                    ByVal studentstateState_Nm As String,  _
                    ByVal studentidname_1 As String,  _
                    ByVal studentacdAcademicYear As String,  _
                    ByVal studentacdGlFinperiodFin_period_info As String,  _
                    ByVal studentClassClassDesc1 As String,  _
                    ByVal studentSchclasskindSchclasskinddesc As String,  _
                    ByVal studentFatherfathfirstname1 As String,  _
                    ByVal studentFatherMaritalStatusStatus_Nm As String,  _
                    ByVal studentFatherareaDesc1 As String,  _
                    ByVal studentFatherCntry_Cntry_Nm As String,  _
                    ByVal studentFatherreligionReljan_nm As String,  _
                    ByVal studentFatherStateState_Nm As String,  _
                    ByVal studentFatherjob_job_desc As String,  _
                    ByVal studentGradeShortDesc1 As String,  _
                    ByVal studentGradeacdAcademicYear As String,  _
                    ByVal studentGradeStageShortDesc1 As String,  _
                    ByVal studentMotherfirstname1 As String,  _
                    ByVal studentMotherareaDesc1 As String,  _
                    ByVal studentMotherCntry_Cntry_Nm As String,  _
                    ByVal studentMotherreligionReljan_nm As String,  _
                    ByVal studentMotherStateState_Nm As String,  _
                    ByVal studentMotherjob_job_desc As String,  _
                    ByVal studentStageShortDesc1 As String,  _
                    ByVal studentschstatus_schstatus_name As String,  _
                    ByVal studentschstclasskinddmgschstclasskinddmgDesc As String,  _
                    ByVal studentschstsplschstsplDsc As String,  _
                    ByVal studentschsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal studentstudentsefastudentsefaar As String,  _
                    ByVal studentstudentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentschstudenttypschstudenttyp As String,  _
                    ByVal studentSchtransferSchtransferDesc As String,  _
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
                    ByVal gradeAppliedacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeAppliedStageShortDesc1 As String,  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal academicYeartoAcademicYear As String,  _
                    ByVal academicYeartoGlFinperiodFin_period_info As String,  _
                    ByVal academicYeartoGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
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
                    ByVal agarulyear As Nullable(Of Single),  _
                    ByVal agarulmonth As Nullable(Of Single),  _
                    ByVal dateofcalculate As Nullable(Of DateTime),  _
                    ByVal agarulyearmax As Nullable(Of Single),  _
                    ByVal agarulmonthmax As Nullable(Of Single),  _
                    ByVal studentBalance1 As Nullable(Of Decimal),  _
                    ByVal calssserial As Nullable(Of Long),  _
                    ByVal paidrosom As Nullable(Of Single),  _
                    ByVal parentsrelation As Nullable(Of Long),  _
                    ByVal theparentsrelationparentsrelationdesc As String,  _
                    ByVal applicationCodeauto_1 As Nullable(Of Long),  _
                    ByVal schtrnsid_1 As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc_1 As String,  _
                    ByVal branch_1 As Nullable(Of Long),  _
                    ByVal thebranchDesc1_1 As String,  _
                    ByVal thebranchsgmsgm_Nm_1 As String,  _
                    ByVal thebranchsgmOpcoOpcoName_1 As String,  _
                    ByVal thebranchGenderGender_1 As String,  _
                    ByVal thebranchschtypschtypDesc_1 As String,  _
                    ByVal applicationDate_1 As Nullable(Of DateTime),  _
                    ByVal studentCode_1 As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber_1 As String,  _
                    ByVal civilidst_1 As String,  _
                    ByVal fathername_1 As String,  _
                    ByVal cntry_No_1 As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm_1 As String,  _
                    ByVal dateofBirth_1 As Nullable(Of DateTime),  _
                    ByVal genderid_1 As Nullable(Of Long),  _
                    ByVal genderGender_1 As String,  _
                    ByVal stageAppliedto_1 As Nullable(Of Long),  _
                    ByVal stageAppliedtoShortDesc1_1 As String,  _
                    ByVal gradeApplied_1 As Nullable(Of Long),  _
                    ByVal gradeAppliedShortDesc1_1 As String,  _
                    ByVal gradeAppliedacdAcademicYear_1 As String,  _
                    ByVal gradeAppliedacdGlFinperiodFin_period_info_1 As String,  _
                    ByVal gradeAppliedStageShortDesc1_1 As String,  _
                    ByVal academicYearto_1 As Nullable(Of Long),  _
                    ByVal academicYeartoAcademicYear_1 As String,  _
                    ByVal academicYeartoGlFinperiodFin_period_info_1 As String,  _
                    ByVal academicYeartoGlFinperiodaccountnumberAcc_Nm_1 As String,  _
                    ByVal class_1 As Nullable(Of Long),  _
                    ByVal classClassDesc1_1 As String,  _
                    ByVal schstatus_code_1 As Nullable(Of Long),  _
                    ByVal schstatus_schstatus_name_1 As String,  _
                    ByVal schstudenttypid_1 As Nullable(Of Long),  _
                    ByVal schstudenttypschstudenttyp_1 As String,  _
                    ByVal id_1 As Nullable(Of Long),  _
                    ByVal theidname_1_1 As String,  _
                    ByVal currentSchool_1 As String,  _
                    ByVal remarks_1 As String,  _
                    ByVal fathertel_1 As String,  _
                    ByVal fathertel2_1 As String,  _
                    ByVal passfail_1 As Nullable(Of Boolean),  _
                    ByVal fatherjob_1 As String,  _
                    ByVal fatheraddress_1 As String,  _
                    ByVal fathertel3_1 As String,  _
                    ByVal fatheremail_1 As String,  _
                    ByVal ageyear_1 As Nullable(Of Long),  _
                    ByVal agemonth_1 As Nullable(Of Long),  _
                    ByVal ageday_1 As Nullable(Of Long),  _
                    ByVal homephone_1 As String,  _
                    ByVal printed_1 As Nullable(Of Long),  _
                    ByVal birthDocNo_1 As String,  _
                    ByVal birthdocdate_1 As Nullable(Of DateTime),  _
                    ByVal birthDocPlace_1 As String,  _
                    ByVal birthPlace_1 As String,  _
                    ByVal residencenumber_1 As String,  _
                    ByVal residenceExpDate_1 As Nullable(Of DateTime),  _
                    ByVal schsthlthcaseid_1 As Nullable(Of Long),  _
                    ByVal schsthlthcaseschsthlthcaseDesc_1 As String,  _
                    ByVal cntry_No1_1 As Nullable(Of Long),  _
                    ByVal cntry_No1Cntry_Nm_1 As String,  _
                    ByVal cntry_No2_1 As Nullable(Of Long),  _
                    ByVal cntry_No2Cntry_Nm_1 As String,  _
                    ByVal state_1 As Nullable(Of Long),  _
                    ByVal stateState_Nm_1 As String,  _
                    ByVal area_1 As Nullable(Of Long),  _
                    ByVal areaDesc1_1 As String,  _
                    ByVal blockno_1 As String,  _
                    ByVal streetno_1 As String,  _
                    ByVal gadah_1 As String,  _
                    ByVal houseno_1 As String,  _
                    ByVal emergencyTelNo1_1 As String,  _
                    ByVal mothercase_1 As Nullable(Of Long),  _
                    ByVal mothercasejob_desc_1 As String,  _
                    ByVal fathercase_1 As Nullable(Of Long),  _
                    ByVal fathercasejob_desc_1 As String,  _
                    ByVal socialstatus_1 As Nullable(Of Long),  _
                    ByVal socialstatusschsocialstatuscaseDesc_1 As String,  _
                    ByVal studentsefa_1 As Nullable(Of Long),  _
                    ByVal studentsefastudentsefaar_1 As String,  _
                    ByVal studentsefadebitaccountAcc_Nm_1 As String,  _
                    ByVal studentsefadebitaccountClsacc_Acc_Nm_1 As String,  _
                    ByVal studentsefadebitaccountAcc_BndAcc_Nm_1 As String,  _
                    ByVal schclasskindid_1 As Nullable(Of Long),  _
                    ByVal schclasskindSchclasskinddesc_1 As String,  _
                    ByVal schstclasskinddmgid_1 As Nullable(Of Long),  _
                    ByVal schstclasskinddmgschstclasskinddmgDesc_1 As String,  _
                    ByVal schtransferid_1 As Nullable(Of Long),  _
                    ByVal schtransferSchtransferDesc_1 As String,  _
                    ByVal classorder_1 As Nullable(Of Long),  _
                    ByVal modifiedBy_1 As String,  _
                    ByVal modifiedOn_1 As Nullable(Of DateTime),  _
                    ByVal createdBy_1 As String,  _
                    ByVal createdOn_1 As Nullable(Of DateTime),  _
                    ByVal agarulyear_1 As Nullable(Of Single),  _
                    ByVal agarulmonth_1 As Nullable(Of Single),  _
                    ByVal dateofcalculate_1 As Nullable(Of DateTime),  _
                    ByVal agarulyearmax_1 As Nullable(Of Single),  _
                    ByVal agarulmonthmax_1 As Nullable(Of Decimal),  _
                    ByVal agarulmonthmax_2 As Nullable(Of Single),  _
                    ByVal calssserial_1 As Nullable(Of Long),  _
                    ByVal paidrosom_1 As Nullable(Of Single),  _
                    ByVal parentsrelation_1 As Nullable(Of Long),  _
                    ByVal theparentsrelationparentsrelationdesc_1 As String,  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.schApplication1001)
            Dim request As PageRequest = CreateRequest(applicationCodeauto, schtrnsid, schtrnsschtrnsDesc, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchschtypschtypDesc, applicationDate, studentCode, studentSchstCivilidnumber, studentareaDesc1, studentbranchDesc1, studentbranchsgmsgm_Nm, studentbranchGenderGender, studentbranchschtypschtypDesc, studentCntry_Cntry_Nm, studentGenderGender, studentReligionReljan_nm, studentstateState_Nm, studentidname_1, studentacdAcademicYear, studentacdGlFinperiodFin_period_info, studentClassClassDesc1, studentSchclasskindSchclasskinddesc, studentFatherfathfirstname1, studentFatherMaritalStatusStatus_Nm, studentFatherareaDesc1, studentFatherCntry_Cntry_Nm, studentFatherreligionReljan_nm, studentFatherStateState_Nm, studentFatherjob_job_desc, studentGradeShortDesc1, studentGradeacdAcademicYear, studentGradeStageShortDesc1, studentMotherfirstname1, studentMotherareaDesc1, studentMotherCntry_Cntry_Nm, studentMotherreligionReljan_nm, studentMotherStateState_Nm, studentMotherjob_job_desc, studentStageShortDesc1, studentschstatus_schstatus_name, studentschstclasskinddmgschstclasskinddmgDesc, studentschstsplschstsplDsc, studentschsthlthcaseschsthlthcaseDesc, studentstudentsefastudentsefaar, studentstudentsefadebitaccountAcc_Nm, studentschstudenttypschstudenttyp, studentSchtransferSchtransferDesc, fathername, cntry_No, cntry_Cntry_Nm, dateofBirth, genderid, genderGender, stageAppliedto, stageAppliedtoShortDesc1, gradeApplied, gradeAppliedShortDesc1, gradeAppliedacdAcademicYear, gradeAppliedacdGlFinperiodFin_period_info, gradeAppliedStageShortDesc1, academicYearto, academicYeartoAcademicYear, academicYeartoGlFinperiodFin_period_info, academicYeartoGlFinperiodaccountnumberAcc_Nm, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, id, theidname_1, currentSchool, remarks, fathertel, fathertel2, passfail, fatherjob, fatheraddress, fathertel3, fatheremail, ageyear, agemonth, ageday, homephone, printed, birthDocNo, birthdocdate, birthDocPlace, birthPlace, residencenumber, residenceExpDate, schsthlthcaseid, schsthlthcaseschsthlthcaseDesc, cntry_No1, cntry_No1Cntry_Nm, cntry_No2, cntry_No2Cntry_Nm, state, stateState_Nm, area, areaDesc1, blockno, streetno, gadah, houseno, emergencyTelNo1, mothercase, mothercasejob_desc, fathercase, fathercasejob_desc, socialstatus, socialstatusschsocialstatuscaseDesc, studentsefa, studentsefastudentsefaar, studentsefadebitaccountAcc_Nm, studentsefadebitaccountClsacc_Acc_Nm, studentsefadebitaccountAcc_BndAcc_Nm, schclasskindid, schclasskindSchclasskinddesc, schstclasskinddmgid, schstclasskinddmgschstclasskinddmgDesc, schtransferid, schtransferSchtransferDesc, classorder, modifiedBy, modifiedOn, createdBy, createdOn, agarulyear, agarulmonth, dateofcalculate, agarulyearmax, agarulmonthmax, studentBalance1, calssserial, paidrosom, parentsrelation, theparentsrelationparentsrelationdesc, applicationCodeauto_1, schtrnsid_1, schtrnsschtrnsDesc_1, branch_1, thebranchDesc1_1, thebranchsgmsgm_Nm_1, thebranchsgmOpcoOpcoName_1, thebranchGenderGender_1, thebranchschtypschtypDesc_1, applicationDate_1, studentCode_1, studentSchstCivilidnumber_1, civilidst_1, fathername_1, cntry_No_1, cntry_Cntry_Nm_1, dateofBirth_1, genderid_1, genderGender_1, stageAppliedto_1, stageAppliedtoShortDesc1_1, gradeApplied_1, gradeAppliedShortDesc1_1, gradeAppliedacdAcademicYear_1, gradeAppliedacdGlFinperiodFin_period_info_1, gradeAppliedStageShortDesc1_1, academicYearto_1, academicYeartoAcademicYear_1, academicYeartoGlFinperiodFin_period_info_1, academicYeartoGlFinperiodaccountnumberAcc_Nm_1, class_1, classClassDesc1_1, schstatus_code_1, schstatus_schstatus_name_1, schstudenttypid_1, schstudenttypschstudenttyp_1, id_1, theidname_1_1, currentSchool_1, remarks_1, fathertel_1, fathertel2_1, passfail_1, fatherjob_1, fatheraddress_1, fathertel3_1, fatheremail_1, ageyear_1, agemonth_1, ageday_1, homephone_1, printed_1, birthDocNo_1, birthdocdate_1, birthDocPlace_1, birthPlace_1, residencenumber_1, residenceExpDate_1, schsthlthcaseid_1, schsthlthcaseschsthlthcaseDesc_1, cntry_No1_1, cntry_No1Cntry_Nm_1, cntry_No2_1, cntry_No2Cntry_Nm_1, state_1, stateState_Nm_1, area_1, areaDesc1_1, blockno_1, streetno_1, gadah_1, houseno_1, emergencyTelNo1_1, mothercase_1, mothercasejob_desc_1, fathercase_1, fathercasejob_desc_1, socialstatus_1, socialstatusschsocialstatuscaseDesc_1, studentsefa_1, studentsefastudentsefaar_1, studentsefadebitaccountAcc_Nm_1, studentsefadebitaccountClsacc_Acc_Nm_1, studentsefadebitaccountAcc_BndAcc_Nm_1, schclasskindid_1, schclasskindSchclasskinddesc_1, schstclasskinddmgid_1, schstclasskinddmgschstclasskinddmgDesc_1, schtransferid_1, schtransferSchtransferDesc_1, classorder_1, modifiedBy_1, modifiedOn_1, createdBy_1, createdOn_1, agarulyear_1, agarulmonth_1, dateofcalculate_1, agarulyearmax_1, agarulmonthmax_1, agarulmonthmax_2, calssserial_1, paidrosom_1, parentsrelation_1, theparentsrelationparentsrelationdesc_1, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schApplication1001", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schApplication1001)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.schApplication1001) As List(Of eZee.Data.Objects.schApplication1001)
            Return [Select](qbe.ApplicationCodeauto, qbe.schtrnsid, qbe.schtrnsschtrnsDesc, qbe.branch, qbe.ThebranchDesc1, qbe.Thebranchsgmsgm_Nm, qbe.ThebranchsgmOpcoOpcoName, qbe.ThebranchGenderGender, qbe.ThebranchschtypschtypDesc, qbe.ApplicationDate, qbe.StudentCode, qbe.StudentSchstCivilidnumber, qbe.StudentareaDesc1, qbe.StudentbranchDesc1, qbe.Studentbranchsgmsgm_Nm, qbe.StudentbranchGenderGender, qbe.StudentbranchschtypschtypDesc, qbe.StudentCntry_Cntry_Nm, qbe.StudentGenderGender, qbe.StudentReligionReljan_nm, qbe.StudentstateState_Nm, qbe.Studentidname_1, qbe.StudentacdAcademicYear, qbe.StudentacdGlFinperiodFin_period_info, qbe.StudentClassClassDesc1, qbe.StudentSchclasskindSchclasskinddesc, qbe.StudentFatherfathfirstname1, qbe.StudentFatherMaritalStatusStatus_Nm, qbe.StudentFatherareaDesc1, qbe.StudentFatherCntry_Cntry_Nm, qbe.StudentFatherreligionReljan_nm, qbe.StudentFatherStateState_Nm, qbe.StudentFatherjob_job_desc, qbe.StudentGradeShortDesc1, qbe.StudentGradeacdAcademicYear, qbe.StudentGradeStageShortDesc1, qbe.StudentMotherfirstname1, qbe.StudentMotherareaDesc1, qbe.StudentMotherCntry_Cntry_Nm, qbe.StudentMotherreligionReljan_nm, qbe.StudentMotherStateState_Nm, qbe.StudentMotherjob_job_desc, qbe.StudentStageShortDesc1, qbe.Studentschstatus_schstatus_name, qbe.StudentschstclasskinddmgschstclasskinddmgDesc, qbe.StudentschstsplschstsplDsc, qbe.StudentschsthlthcaseschsthlthcaseDesc, qbe.Studentstudentsefastudentsefaar, qbe.StudentstudentsefadebitaccountAcc_Nm, qbe.Studentschstudenttypschstudenttyp, qbe.StudentSchtransferSchtransferDesc, qbe.Fathername, qbe.Cntry_No, qbe.Cntry_Cntry_Nm, qbe.DateofBirth, qbe.Genderid, qbe.GenderGender, qbe.StageAppliedto, qbe.StageAppliedtoShortDesc1, qbe.GradeApplied, qbe.GradeAppliedShortDesc1, qbe.GradeAppliedacdAcademicYear, qbe.GradeAppliedacdGlFinperiodFin_period_info, qbe.GradeAppliedStageShortDesc1, qbe.AcademicYearto, qbe.AcademicYeartoAcademicYear, qbe.AcademicYeartoGlFinperiodFin_period_info, qbe.AcademicYeartoGlFinperiodaccountnumberAcc_Nm, qbe.Class, qbe.ClassClassDesc1, qbe.schstatus_code, qbe.schstatus_schstatus_name, qbe.schstudenttypid, qbe.schstudenttypschstudenttyp, qbe.id, qbe.Theidname_1, qbe.CurrentSchool, qbe.Remarks, qbe.Fathertel, qbe.Fathertel2, qbe.passfail, qbe.fatherjob, qbe.fatheraddress, qbe.fathertel3, qbe.fatheremail, qbe.ageyear, qbe.agemonth, qbe.ageday, qbe.homephone, qbe.printed, qbe.BirthDocNo, qbe.birthdocdate, qbe.BirthDocPlace, qbe.BirthPlace, qbe.Residencenumber, qbe.ResidenceExpDate, qbe.schsthlthcaseid, qbe.schsthlthcaseschsthlthcaseDesc, qbe.Cntry_No1, qbe.Cntry_No1Cntry_Nm, qbe.Cntry_No2, qbe.Cntry_No2Cntry_Nm, qbe.state, qbe.stateState_Nm, qbe.area, qbe.areaDesc1, qbe.blockno, qbe.streetno, qbe.gadah, qbe.houseno, qbe.EmergencyTelNo1, qbe.mothercase, qbe.mothercasejob_desc, qbe.fathercase, qbe.fathercasejob_desc, qbe.socialstatus, qbe.socialstatusschsocialstatuscaseDesc, qbe.studentsefa, qbe.studentsefastudentsefaar, qbe.studentsefadebitaccountAcc_Nm, qbe.studentsefadebitaccountClsacc_Acc_Nm, qbe.studentsefadebitaccountAcc_BndAcc_Nm, qbe.Schclasskindid, qbe.SchclasskindSchclasskinddesc, qbe.schstclasskinddmgid, qbe.schstclasskinddmgschstclasskinddmgDesc, qbe.Schtransferid, qbe.SchtransferSchtransferDesc, qbe.classorder, qbe.ModifiedBy, qbe.ModifiedOn, qbe.CreatedBy, qbe.CreatedOn, qbe.agarulyear, qbe.agarulmonth, qbe.dateofcalculate, qbe.agarulyearmax, qbe.agarulmonthmax, qbe.studentBalance1, qbe.calssserial, qbe.paidrosom, qbe.parentsrelation, qbe.Theparentsrelationparentsrelationdesc, qbe.ApplicationCodeauto_1, qbe.schtrnsid_1, qbe.schtrnsschtrnsDesc_1, qbe.branch_1, qbe.ThebranchDesc1_1, qbe.Thebranchsgmsgm_Nm_1, qbe.ThebranchsgmOpcoOpcoName_1, qbe.ThebranchGenderGender_1, qbe.ThebranchschtypschtypDesc_1, qbe.ApplicationDate_1, qbe.StudentCode_1, qbe.StudentSchstCivilidnumber_1, qbe.civilidst_1, qbe.Fathername_1, qbe.Cntry_No_1, qbe.Cntry_Cntry_Nm_1, qbe.DateofBirth_1, qbe.Genderid_1, qbe.GenderGender_1, qbe.StageAppliedto_1, qbe.StageAppliedtoShortDesc1_1, qbe.GradeApplied_1, qbe.GradeAppliedShortDesc1_1, qbe.GradeAppliedacdAcademicYear_1, qbe.GradeAppliedacdGlFinperiodFin_period_info_1, qbe.GradeAppliedStageShortDesc1_1, qbe.AcademicYearto_1, qbe.AcademicYeartoAcademicYear_1, qbe.AcademicYeartoGlFinperiodFin_period_info_1, qbe.AcademicYeartoGlFinperiodaccountnumberAcc_Nm_1, qbe.Class_1, qbe.ClassClassDesc1_1, qbe.schstatus_code_1, qbe.schstatus_schstatus_name_1, qbe.schstudenttypid_1, qbe.schstudenttypschstudenttyp_1, qbe.id_1, qbe.Theidname_1_1, qbe.CurrentSchool_1, qbe.Remarks_1, qbe.Fathertel_1, qbe.Fathertel2_1, qbe.passfail_1, qbe.fatherjob_1, qbe.fatheraddress_1, qbe.fathertel3_1, qbe.fatheremail_1, qbe.ageyear_1, qbe.agemonth_1, qbe.ageday_1, qbe.homephone_1, qbe.printed_1, qbe.BirthDocNo_1, qbe.birthdocdate_1, qbe.BirthDocPlace_1, qbe.BirthPlace_1, qbe.Residencenumber_1, qbe.ResidenceExpDate_1, qbe.schsthlthcaseid_1, qbe.schsthlthcaseschsthlthcaseDesc_1, qbe.Cntry_No1_1, qbe.Cntry_No1Cntry_Nm_1, qbe.Cntry_No2_1, qbe.Cntry_No2Cntry_Nm_1, qbe.state_1, qbe.stateState_Nm_1, qbe.area_1, qbe.areaDesc1_1, qbe.blockno_1, qbe.streetno_1, qbe.gadah_1, qbe.houseno_1, qbe.EmergencyTelNo1_1, qbe.mothercase_1, qbe.mothercasejob_desc_1, qbe.fathercase_1, qbe.fathercasejob_desc_1, qbe.socialstatus_1, qbe.socialstatusschsocialstatuscaseDesc_1, qbe.studentsefa_1, qbe.studentsefastudentsefaar_1, qbe.studentsefadebitaccountAcc_Nm_1, qbe.studentsefadebitaccountClsacc_Acc_Nm_1, qbe.studentsefadebitaccountAcc_BndAcc_Nm_1, qbe.Schclasskindid_1, qbe.SchclasskindSchclasskinddesc_1, qbe.schstclasskinddmgid_1, qbe.schstclasskinddmgschstclasskinddmgDesc_1, qbe.Schtransferid_1, qbe.SchtransferSchtransferDesc_1, qbe.classorder_1, qbe.ModifiedBy_1, qbe.ModifiedOn_1, qbe.CreatedBy_1, qbe.CreatedOn_1, qbe.agarulyear_1, qbe.agarulmonth_1, qbe.dateofcalculate_1, qbe.agarulyearmax_1, qbe.agarulmonthmax_1, qbe.agarulmonthmax_2, qbe.calssserial_1, qbe.paidrosom_1, qbe.parentsrelation_1, qbe.Theparentsrelationparentsrelationdesc_1)
        End Function
        
        Public Function SelectCount( _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal studentareaDesc1 As String,  _
                    ByVal studentbranchDesc1 As String,  _
                    ByVal studentbranchsgmsgm_Nm As String,  _
                    ByVal studentbranchGenderGender As String,  _
                    ByVal studentbranchschtypschtypDesc As String,  _
                    ByVal studentCntry_Cntry_Nm As String,  _
                    ByVal studentGenderGender As String,  _
                    ByVal studentReligionReljan_nm As String,  _
                    ByVal studentstateState_Nm As String,  _
                    ByVal studentidname_1 As String,  _
                    ByVal studentacdAcademicYear As String,  _
                    ByVal studentacdGlFinperiodFin_period_info As String,  _
                    ByVal studentClassClassDesc1 As String,  _
                    ByVal studentSchclasskindSchclasskinddesc As String,  _
                    ByVal studentFatherfathfirstname1 As String,  _
                    ByVal studentFatherMaritalStatusStatus_Nm As String,  _
                    ByVal studentFatherareaDesc1 As String,  _
                    ByVal studentFatherCntry_Cntry_Nm As String,  _
                    ByVal studentFatherreligionReljan_nm As String,  _
                    ByVal studentFatherStateState_Nm As String,  _
                    ByVal studentFatherjob_job_desc As String,  _
                    ByVal studentGradeShortDesc1 As String,  _
                    ByVal studentGradeacdAcademicYear As String,  _
                    ByVal studentGradeStageShortDesc1 As String,  _
                    ByVal studentMotherfirstname1 As String,  _
                    ByVal studentMotherareaDesc1 As String,  _
                    ByVal studentMotherCntry_Cntry_Nm As String,  _
                    ByVal studentMotherreligionReljan_nm As String,  _
                    ByVal studentMotherStateState_Nm As String,  _
                    ByVal studentMotherjob_job_desc As String,  _
                    ByVal studentStageShortDesc1 As String,  _
                    ByVal studentschstatus_schstatus_name As String,  _
                    ByVal studentschstclasskinddmgschstclasskinddmgDesc As String,  _
                    ByVal studentschstsplschstsplDsc As String,  _
                    ByVal studentschsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal studentstudentsefastudentsefaar As String,  _
                    ByVal studentstudentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentschstudenttypschstudenttyp As String,  _
                    ByVal studentSchtransferSchtransferDesc As String,  _
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
                    ByVal gradeAppliedacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeAppliedStageShortDesc1 As String,  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal academicYeartoAcademicYear As String,  _
                    ByVal academicYeartoGlFinperiodFin_period_info As String,  _
                    ByVal academicYeartoGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
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
                    ByVal agarulyear As Nullable(Of Single),  _
                    ByVal agarulmonth As Nullable(Of Single),  _
                    ByVal dateofcalculate As Nullable(Of DateTime),  _
                    ByVal agarulyearmax As Nullable(Of Single),  _
                    ByVal agarulmonthmax As Nullable(Of Single),  _
                    ByVal studentBalance1 As Nullable(Of Decimal),  _
                    ByVal calssserial As Nullable(Of Long),  _
                    ByVal paidrosom As Nullable(Of Single),  _
                    ByVal parentsrelation As Nullable(Of Long),  _
                    ByVal theparentsrelationparentsrelationdesc As String,  _
                    ByVal applicationCodeauto_1 As Nullable(Of Long),  _
                    ByVal schtrnsid_1 As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc_1 As String,  _
                    ByVal branch_1 As Nullable(Of Long),  _
                    ByVal thebranchDesc1_1 As String,  _
                    ByVal thebranchsgmsgm_Nm_1 As String,  _
                    ByVal thebranchsgmOpcoOpcoName_1 As String,  _
                    ByVal thebranchGenderGender_1 As String,  _
                    ByVal thebranchschtypschtypDesc_1 As String,  _
                    ByVal applicationDate_1 As Nullable(Of DateTime),  _
                    ByVal studentCode_1 As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber_1 As String,  _
                    ByVal civilidst_1 As String,  _
                    ByVal fathername_1 As String,  _
                    ByVal cntry_No_1 As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm_1 As String,  _
                    ByVal dateofBirth_1 As Nullable(Of DateTime),  _
                    ByVal genderid_1 As Nullable(Of Long),  _
                    ByVal genderGender_1 As String,  _
                    ByVal stageAppliedto_1 As Nullable(Of Long),  _
                    ByVal stageAppliedtoShortDesc1_1 As String,  _
                    ByVal gradeApplied_1 As Nullable(Of Long),  _
                    ByVal gradeAppliedShortDesc1_1 As String,  _
                    ByVal gradeAppliedacdAcademicYear_1 As String,  _
                    ByVal gradeAppliedacdGlFinperiodFin_period_info_1 As String,  _
                    ByVal gradeAppliedStageShortDesc1_1 As String,  _
                    ByVal academicYearto_1 As Nullable(Of Long),  _
                    ByVal academicYeartoAcademicYear_1 As String,  _
                    ByVal academicYeartoGlFinperiodFin_period_info_1 As String,  _
                    ByVal academicYeartoGlFinperiodaccountnumberAcc_Nm_1 As String,  _
                    ByVal class_1 As Nullable(Of Long),  _
                    ByVal classClassDesc1_1 As String,  _
                    ByVal schstatus_code_1 As Nullable(Of Long),  _
                    ByVal schstatus_schstatus_name_1 As String,  _
                    ByVal schstudenttypid_1 As Nullable(Of Long),  _
                    ByVal schstudenttypschstudenttyp_1 As String,  _
                    ByVal id_1 As Nullable(Of Long),  _
                    ByVal theidname_1_1 As String,  _
                    ByVal currentSchool_1 As String,  _
                    ByVal remarks_1 As String,  _
                    ByVal fathertel_1 As String,  _
                    ByVal fathertel2_1 As String,  _
                    ByVal passfail_1 As Nullable(Of Boolean),  _
                    ByVal fatherjob_1 As String,  _
                    ByVal fatheraddress_1 As String,  _
                    ByVal fathertel3_1 As String,  _
                    ByVal fatheremail_1 As String,  _
                    ByVal ageyear_1 As Nullable(Of Long),  _
                    ByVal agemonth_1 As Nullable(Of Long),  _
                    ByVal ageday_1 As Nullable(Of Long),  _
                    ByVal homephone_1 As String,  _
                    ByVal printed_1 As Nullable(Of Long),  _
                    ByVal birthDocNo_1 As String,  _
                    ByVal birthdocdate_1 As Nullable(Of DateTime),  _
                    ByVal birthDocPlace_1 As String,  _
                    ByVal birthPlace_1 As String,  _
                    ByVal residencenumber_1 As String,  _
                    ByVal residenceExpDate_1 As Nullable(Of DateTime),  _
                    ByVal schsthlthcaseid_1 As Nullable(Of Long),  _
                    ByVal schsthlthcaseschsthlthcaseDesc_1 As String,  _
                    ByVal cntry_No1_1 As Nullable(Of Long),  _
                    ByVal cntry_No1Cntry_Nm_1 As String,  _
                    ByVal cntry_No2_1 As Nullable(Of Long),  _
                    ByVal cntry_No2Cntry_Nm_1 As String,  _
                    ByVal state_1 As Nullable(Of Long),  _
                    ByVal stateState_Nm_1 As String,  _
                    ByVal area_1 As Nullable(Of Long),  _
                    ByVal areaDesc1_1 As String,  _
                    ByVal blockno_1 As String,  _
                    ByVal streetno_1 As String,  _
                    ByVal gadah_1 As String,  _
                    ByVal houseno_1 As String,  _
                    ByVal emergencyTelNo1_1 As String,  _
                    ByVal mothercase_1 As Nullable(Of Long),  _
                    ByVal mothercasejob_desc_1 As String,  _
                    ByVal fathercase_1 As Nullable(Of Long),  _
                    ByVal fathercasejob_desc_1 As String,  _
                    ByVal socialstatus_1 As Nullable(Of Long),  _
                    ByVal socialstatusschsocialstatuscaseDesc_1 As String,  _
                    ByVal studentsefa_1 As Nullable(Of Long),  _
                    ByVal studentsefastudentsefaar_1 As String,  _
                    ByVal studentsefadebitaccountAcc_Nm_1 As String,  _
                    ByVal studentsefadebitaccountClsacc_Acc_Nm_1 As String,  _
                    ByVal studentsefadebitaccountAcc_BndAcc_Nm_1 As String,  _
                    ByVal schclasskindid_1 As Nullable(Of Long),  _
                    ByVal schclasskindSchclasskinddesc_1 As String,  _
                    ByVal schstclasskinddmgid_1 As Nullable(Of Long),  _
                    ByVal schstclasskinddmgschstclasskinddmgDesc_1 As String,  _
                    ByVal schtransferid_1 As Nullable(Of Long),  _
                    ByVal schtransferSchtransferDesc_1 As String,  _
                    ByVal classorder_1 As Nullable(Of Long),  _
                    ByVal modifiedBy_1 As String,  _
                    ByVal modifiedOn_1 As Nullable(Of DateTime),  _
                    ByVal createdBy_1 As String,  _
                    ByVal createdOn_1 As Nullable(Of DateTime),  _
                    ByVal agarulyear_1 As Nullable(Of Single),  _
                    ByVal agarulmonth_1 As Nullable(Of Single),  _
                    ByVal dateofcalculate_1 As Nullable(Of DateTime),  _
                    ByVal agarulyearmax_1 As Nullable(Of Single),  _
                    ByVal agarulmonthmax_1 As Nullable(Of Decimal),  _
                    ByVal agarulmonthmax_2 As Nullable(Of Single),  _
                    ByVal calssserial_1 As Nullable(Of Long),  _
                    ByVal paidrosom_1 As Nullable(Of Single),  _
                    ByVal parentsrelation_1 As Nullable(Of Long),  _
                    ByVal theparentsrelationparentsrelationdesc_1 As String,  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(applicationCodeauto, schtrnsid, schtrnsschtrnsDesc, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchschtypschtypDesc, applicationDate, studentCode, studentSchstCivilidnumber, studentareaDesc1, studentbranchDesc1, studentbranchsgmsgm_Nm, studentbranchGenderGender, studentbranchschtypschtypDesc, studentCntry_Cntry_Nm, studentGenderGender, studentReligionReljan_nm, studentstateState_Nm, studentidname_1, studentacdAcademicYear, studentacdGlFinperiodFin_period_info, studentClassClassDesc1, studentSchclasskindSchclasskinddesc, studentFatherfathfirstname1, studentFatherMaritalStatusStatus_Nm, studentFatherareaDesc1, studentFatherCntry_Cntry_Nm, studentFatherreligionReljan_nm, studentFatherStateState_Nm, studentFatherjob_job_desc, studentGradeShortDesc1, studentGradeacdAcademicYear, studentGradeStageShortDesc1, studentMotherfirstname1, studentMotherareaDesc1, studentMotherCntry_Cntry_Nm, studentMotherreligionReljan_nm, studentMotherStateState_Nm, studentMotherjob_job_desc, studentStageShortDesc1, studentschstatus_schstatus_name, studentschstclasskinddmgschstclasskinddmgDesc, studentschstsplschstsplDsc, studentschsthlthcaseschsthlthcaseDesc, studentstudentsefastudentsefaar, studentstudentsefadebitaccountAcc_Nm, studentschstudenttypschstudenttyp, studentSchtransferSchtransferDesc, fathername, cntry_No, cntry_Cntry_Nm, dateofBirth, genderid, genderGender, stageAppliedto, stageAppliedtoShortDesc1, gradeApplied, gradeAppliedShortDesc1, gradeAppliedacdAcademicYear, gradeAppliedacdGlFinperiodFin_period_info, gradeAppliedStageShortDesc1, academicYearto, academicYeartoAcademicYear, academicYeartoGlFinperiodFin_period_info, academicYeartoGlFinperiodaccountnumberAcc_Nm, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, id, theidname_1, currentSchool, remarks, fathertel, fathertel2, passfail, fatherjob, fatheraddress, fathertel3, fatheremail, ageyear, agemonth, ageday, homephone, printed, birthDocNo, birthdocdate, birthDocPlace, birthPlace, residencenumber, residenceExpDate, schsthlthcaseid, schsthlthcaseschsthlthcaseDesc, cntry_No1, cntry_No1Cntry_Nm, cntry_No2, cntry_No2Cntry_Nm, state, stateState_Nm, area, areaDesc1, blockno, streetno, gadah, houseno, emergencyTelNo1, mothercase, mothercasejob_desc, fathercase, fathercasejob_desc, socialstatus, socialstatusschsocialstatuscaseDesc, studentsefa, studentsefastudentsefaar, studentsefadebitaccountAcc_Nm, studentsefadebitaccountClsacc_Acc_Nm, studentsefadebitaccountAcc_BndAcc_Nm, schclasskindid, schclasskindSchclasskinddesc, schstclasskinddmgid, schstclasskinddmgschstclasskinddmgDesc, schtransferid, schtransferSchtransferDesc, classorder, modifiedBy, modifiedOn, createdBy, createdOn, agarulyear, agarulmonth, dateofcalculate, agarulyearmax, agarulmonthmax, studentBalance1, calssserial, paidrosom, parentsrelation, theparentsrelationparentsrelationdesc, applicationCodeauto_1, schtrnsid_1, schtrnsschtrnsDesc_1, branch_1, thebranchDesc1_1, thebranchsgmsgm_Nm_1, thebranchsgmOpcoOpcoName_1, thebranchGenderGender_1, thebranchschtypschtypDesc_1, applicationDate_1, studentCode_1, studentSchstCivilidnumber_1, civilidst_1, fathername_1, cntry_No_1, cntry_Cntry_Nm_1, dateofBirth_1, genderid_1, genderGender_1, stageAppliedto_1, stageAppliedtoShortDesc1_1, gradeApplied_1, gradeAppliedShortDesc1_1, gradeAppliedacdAcademicYear_1, gradeAppliedacdGlFinperiodFin_period_info_1, gradeAppliedStageShortDesc1_1, academicYearto_1, academicYeartoAcademicYear_1, academicYeartoGlFinperiodFin_period_info_1, academicYeartoGlFinperiodaccountnumberAcc_Nm_1, class_1, classClassDesc1_1, schstatus_code_1, schstatus_schstatus_name_1, schstudenttypid_1, schstudenttypschstudenttyp_1, id_1, theidname_1_1, currentSchool_1, remarks_1, fathertel_1, fathertel2_1, passfail_1, fatherjob_1, fatheraddress_1, fathertel3_1, fatheremail_1, ageyear_1, agemonth_1, ageday_1, homephone_1, printed_1, birthDocNo_1, birthdocdate_1, birthDocPlace_1, birthPlace_1, residencenumber_1, residenceExpDate_1, schsthlthcaseid_1, schsthlthcaseschsthlthcaseDesc_1, cntry_No1_1, cntry_No1Cntry_Nm_1, cntry_No2_1, cntry_No2Cntry_Nm_1, state_1, stateState_Nm_1, area_1, areaDesc1_1, blockno_1, streetno_1, gadah_1, houseno_1, emergencyTelNo1_1, mothercase_1, mothercasejob_desc_1, fathercase_1, fathercasejob_desc_1, socialstatus_1, socialstatusschsocialstatuscaseDesc_1, studentsefa_1, studentsefastudentsefaar_1, studentsefadebitaccountAcc_Nm_1, studentsefadebitaccountClsacc_Acc_Nm_1, studentsefadebitaccountAcc_BndAcc_Nm_1, schclasskindid_1, schclasskindSchclasskinddesc_1, schstclasskinddmgid_1, schstclasskinddmgschstclasskinddmgDesc_1, schtransferid_1, schtransferSchtransferDesc_1, classorder_1, modifiedBy_1, modifiedOn_1, createdBy_1, createdOn_1, agarulyear_1, agarulmonth_1, dateofcalculate_1, agarulyearmax_1, agarulmonthmax_1, agarulmonthmax_2, calssserial_1, paidrosom_1, parentsrelation_1, theparentsrelationparentsrelationdesc_1, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schApplication1001", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal studentareaDesc1 As String,  _
                    ByVal studentbranchDesc1 As String,  _
                    ByVal studentbranchsgmsgm_Nm As String,  _
                    ByVal studentbranchGenderGender As String,  _
                    ByVal studentbranchschtypschtypDesc As String,  _
                    ByVal studentCntry_Cntry_Nm As String,  _
                    ByVal studentGenderGender As String,  _
                    ByVal studentReligionReljan_nm As String,  _
                    ByVal studentstateState_Nm As String,  _
                    ByVal studentidname_1 As String,  _
                    ByVal studentacdAcademicYear As String,  _
                    ByVal studentacdGlFinperiodFin_period_info As String,  _
                    ByVal studentClassClassDesc1 As String,  _
                    ByVal studentSchclasskindSchclasskinddesc As String,  _
                    ByVal studentFatherfathfirstname1 As String,  _
                    ByVal studentFatherMaritalStatusStatus_Nm As String,  _
                    ByVal studentFatherareaDesc1 As String,  _
                    ByVal studentFatherCntry_Cntry_Nm As String,  _
                    ByVal studentFatherreligionReljan_nm As String,  _
                    ByVal studentFatherStateState_Nm As String,  _
                    ByVal studentFatherjob_job_desc As String,  _
                    ByVal studentGradeShortDesc1 As String,  _
                    ByVal studentGradeacdAcademicYear As String,  _
                    ByVal studentGradeStageShortDesc1 As String,  _
                    ByVal studentMotherfirstname1 As String,  _
                    ByVal studentMotherareaDesc1 As String,  _
                    ByVal studentMotherCntry_Cntry_Nm As String,  _
                    ByVal studentMotherreligionReljan_nm As String,  _
                    ByVal studentMotherStateState_Nm As String,  _
                    ByVal studentMotherjob_job_desc As String,  _
                    ByVal studentStageShortDesc1 As String,  _
                    ByVal studentschstatus_schstatus_name As String,  _
                    ByVal studentschstclasskinddmgschstclasskinddmgDesc As String,  _
                    ByVal studentschstsplschstsplDsc As String,  _
                    ByVal studentschsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal studentstudentsefastudentsefaar As String,  _
                    ByVal studentstudentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentschstudenttypschstudenttyp As String,  _
                    ByVal studentSchtransferSchtransferDesc As String,  _
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
                    ByVal gradeAppliedacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeAppliedStageShortDesc1 As String,  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal academicYeartoAcademicYear As String,  _
                    ByVal academicYeartoGlFinperiodFin_period_info As String,  _
                    ByVal academicYeartoGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
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
                    ByVal agarulyear As Nullable(Of Single),  _
                    ByVal agarulmonth As Nullable(Of Single),  _
                    ByVal dateofcalculate As Nullable(Of DateTime),  _
                    ByVal agarulyearmax As Nullable(Of Single),  _
                    ByVal agarulmonthmax As Nullable(Of Single),  _
                    ByVal studentBalance1 As Nullable(Of Decimal),  _
                    ByVal calssserial As Nullable(Of Long),  _
                    ByVal paidrosom As Nullable(Of Single),  _
                    ByVal parentsrelation As Nullable(Of Long),  _
                    ByVal theparentsrelationparentsrelationdesc As String,  _
                    ByVal applicationCodeauto_1 As Nullable(Of Long),  _
                    ByVal schtrnsid_1 As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc_1 As String,  _
                    ByVal branch_1 As Nullable(Of Long),  _
                    ByVal thebranchDesc1_1 As String,  _
                    ByVal thebranchsgmsgm_Nm_1 As String,  _
                    ByVal thebranchsgmOpcoOpcoName_1 As String,  _
                    ByVal thebranchGenderGender_1 As String,  _
                    ByVal thebranchschtypschtypDesc_1 As String,  _
                    ByVal applicationDate_1 As Nullable(Of DateTime),  _
                    ByVal studentCode_1 As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber_1 As String,  _
                    ByVal civilidst_1 As String,  _
                    ByVal fathername_1 As String,  _
                    ByVal cntry_No_1 As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm_1 As String,  _
                    ByVal dateofBirth_1 As Nullable(Of DateTime),  _
                    ByVal genderid_1 As Nullable(Of Long),  _
                    ByVal genderGender_1 As String,  _
                    ByVal stageAppliedto_1 As Nullable(Of Long),  _
                    ByVal stageAppliedtoShortDesc1_1 As String,  _
                    ByVal gradeApplied_1 As Nullable(Of Long),  _
                    ByVal gradeAppliedShortDesc1_1 As String,  _
                    ByVal gradeAppliedacdAcademicYear_1 As String,  _
                    ByVal gradeAppliedacdGlFinperiodFin_period_info_1 As String,  _
                    ByVal gradeAppliedStageShortDesc1_1 As String,  _
                    ByVal academicYearto_1 As Nullable(Of Long),  _
                    ByVal academicYeartoAcademicYear_1 As String,  _
                    ByVal academicYeartoGlFinperiodFin_period_info_1 As String,  _
                    ByVal academicYeartoGlFinperiodaccountnumberAcc_Nm_1 As String,  _
                    ByVal class_1 As Nullable(Of Long),  _
                    ByVal classClassDesc1_1 As String,  _
                    ByVal schstatus_code_1 As Nullable(Of Long),  _
                    ByVal schstatus_schstatus_name_1 As String,  _
                    ByVal schstudenttypid_1 As Nullable(Of Long),  _
                    ByVal schstudenttypschstudenttyp_1 As String,  _
                    ByVal id_1 As Nullable(Of Long),  _
                    ByVal theidname_1_1 As String,  _
                    ByVal currentSchool_1 As String,  _
                    ByVal remarks_1 As String,  _
                    ByVal fathertel_1 As String,  _
                    ByVal fathertel2_1 As String,  _
                    ByVal passfail_1 As Nullable(Of Boolean),  _
                    ByVal fatherjob_1 As String,  _
                    ByVal fatheraddress_1 As String,  _
                    ByVal fathertel3_1 As String,  _
                    ByVal fatheremail_1 As String,  _
                    ByVal ageyear_1 As Nullable(Of Long),  _
                    ByVal agemonth_1 As Nullable(Of Long),  _
                    ByVal ageday_1 As Nullable(Of Long),  _
                    ByVal homephone_1 As String,  _
                    ByVal printed_1 As Nullable(Of Long),  _
                    ByVal birthDocNo_1 As String,  _
                    ByVal birthdocdate_1 As Nullable(Of DateTime),  _
                    ByVal birthDocPlace_1 As String,  _
                    ByVal birthPlace_1 As String,  _
                    ByVal residencenumber_1 As String,  _
                    ByVal residenceExpDate_1 As Nullable(Of DateTime),  _
                    ByVal schsthlthcaseid_1 As Nullable(Of Long),  _
                    ByVal schsthlthcaseschsthlthcaseDesc_1 As String,  _
                    ByVal cntry_No1_1 As Nullable(Of Long),  _
                    ByVal cntry_No1Cntry_Nm_1 As String,  _
                    ByVal cntry_No2_1 As Nullable(Of Long),  _
                    ByVal cntry_No2Cntry_Nm_1 As String,  _
                    ByVal state_1 As Nullable(Of Long),  _
                    ByVal stateState_Nm_1 As String,  _
                    ByVal area_1 As Nullable(Of Long),  _
                    ByVal areaDesc1_1 As String,  _
                    ByVal blockno_1 As String,  _
                    ByVal streetno_1 As String,  _
                    ByVal gadah_1 As String,  _
                    ByVal houseno_1 As String,  _
                    ByVal emergencyTelNo1_1 As String,  _
                    ByVal mothercase_1 As Nullable(Of Long),  _
                    ByVal mothercasejob_desc_1 As String,  _
                    ByVal fathercase_1 As Nullable(Of Long),  _
                    ByVal fathercasejob_desc_1 As String,  _
                    ByVal socialstatus_1 As Nullable(Of Long),  _
                    ByVal socialstatusschsocialstatuscaseDesc_1 As String,  _
                    ByVal studentsefa_1 As Nullable(Of Long),  _
                    ByVal studentsefastudentsefaar_1 As String,  _
                    ByVal studentsefadebitaccountAcc_Nm_1 As String,  _
                    ByVal studentsefadebitaccountClsacc_Acc_Nm_1 As String,  _
                    ByVal studentsefadebitaccountAcc_BndAcc_Nm_1 As String,  _
                    ByVal schclasskindid_1 As Nullable(Of Long),  _
                    ByVal schclasskindSchclasskinddesc_1 As String,  _
                    ByVal schstclasskinddmgid_1 As Nullable(Of Long),  _
                    ByVal schstclasskinddmgschstclasskinddmgDesc_1 As String,  _
                    ByVal schtransferid_1 As Nullable(Of Long),  _
                    ByVal schtransferSchtransferDesc_1 As String,  _
                    ByVal classorder_1 As Nullable(Of Long),  _
                    ByVal modifiedBy_1 As String,  _
                    ByVal modifiedOn_1 As Nullable(Of DateTime),  _
                    ByVal createdBy_1 As String,  _
                    ByVal createdOn_1 As Nullable(Of DateTime),  _
                    ByVal agarulyear_1 As Nullable(Of Single),  _
                    ByVal agarulmonth_1 As Nullable(Of Single),  _
                    ByVal dateofcalculate_1 As Nullable(Of DateTime),  _
                    ByVal agarulyearmax_1 As Nullable(Of Single),  _
                    ByVal agarulmonthmax_1 As Nullable(Of Decimal),  _
                    ByVal agarulmonthmax_2 As Nullable(Of Single),  _
                    ByVal calssserial_1 As Nullable(Of Long),  _
                    ByVal paidrosom_1 As Nullable(Of Single),  _
                    ByVal parentsrelation_1 As Nullable(Of Long),  _
                    ByVal theparentsrelationparentsrelationdesc_1 As String) As List(Of eZee.Data.Objects.schApplication1001)
            Return [Select](applicationCodeauto, schtrnsid, schtrnsschtrnsDesc, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchschtypschtypDesc, applicationDate, studentCode, studentSchstCivilidnumber, studentareaDesc1, studentbranchDesc1, studentbranchsgmsgm_Nm, studentbranchGenderGender, studentbranchschtypschtypDesc, studentCntry_Cntry_Nm, studentGenderGender, studentReligionReljan_nm, studentstateState_Nm, studentidname_1, studentacdAcademicYear, studentacdGlFinperiodFin_period_info, studentClassClassDesc1, studentSchclasskindSchclasskinddesc, studentFatherfathfirstname1, studentFatherMaritalStatusStatus_Nm, studentFatherareaDesc1, studentFatherCntry_Cntry_Nm, studentFatherreligionReljan_nm, studentFatherStateState_Nm, studentFatherjob_job_desc, studentGradeShortDesc1, studentGradeacdAcademicYear, studentGradeStageShortDesc1, studentMotherfirstname1, studentMotherareaDesc1, studentMotherCntry_Cntry_Nm, studentMotherreligionReljan_nm, studentMotherStateState_Nm, studentMotherjob_job_desc, studentStageShortDesc1, studentschstatus_schstatus_name, studentschstclasskinddmgschstclasskinddmgDesc, studentschstsplschstsplDsc, studentschsthlthcaseschsthlthcaseDesc, studentstudentsefastudentsefaar, studentstudentsefadebitaccountAcc_Nm, studentschstudenttypschstudenttyp, studentSchtransferSchtransferDesc, fathername, cntry_No, cntry_Cntry_Nm, dateofBirth, genderid, genderGender, stageAppliedto, stageAppliedtoShortDesc1, gradeApplied, gradeAppliedShortDesc1, gradeAppliedacdAcademicYear, gradeAppliedacdGlFinperiodFin_period_info, gradeAppliedStageShortDesc1, academicYearto, academicYeartoAcademicYear, academicYeartoGlFinperiodFin_period_info, academicYeartoGlFinperiodaccountnumberAcc_Nm, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, id, theidname_1, currentSchool, remarks, fathertel, fathertel2, passfail, fatherjob, fatheraddress, fathertel3, fatheremail, ageyear, agemonth, ageday, homephone, printed, birthDocNo, birthdocdate, birthDocPlace, birthPlace, residencenumber, residenceExpDate, schsthlthcaseid, schsthlthcaseschsthlthcaseDesc, cntry_No1, cntry_No1Cntry_Nm, cntry_No2, cntry_No2Cntry_Nm, state, stateState_Nm, area, areaDesc1, blockno, streetno, gadah, houseno, emergencyTelNo1, mothercase, mothercasejob_desc, fathercase, fathercasejob_desc, socialstatus, socialstatusschsocialstatuscaseDesc, studentsefa, studentsefastudentsefaar, studentsefadebitaccountAcc_Nm, studentsefadebitaccountClsacc_Acc_Nm, studentsefadebitaccountAcc_BndAcc_Nm, schclasskindid, schclasskindSchclasskinddesc, schstclasskinddmgid, schstclasskinddmgschstclasskinddmgDesc, schtransferid, schtransferSchtransferDesc, classorder, modifiedBy, modifiedOn, createdBy, createdOn, agarulyear, agarulmonth, dateofcalculate, agarulyearmax, agarulmonthmax, studentBalance1, calssserial, paidrosom, parentsrelation, theparentsrelationparentsrelationdesc, applicationCodeauto_1, schtrnsid_1, schtrnsschtrnsDesc_1, branch_1, thebranchDesc1_1, thebranchsgmsgm_Nm_1, thebranchsgmOpcoOpcoName_1, thebranchGenderGender_1, thebranchschtypschtypDesc_1, applicationDate_1, studentCode_1, studentSchstCivilidnumber_1, civilidst_1, fathername_1, cntry_No_1, cntry_Cntry_Nm_1, dateofBirth_1, genderid_1, genderGender_1, stageAppliedto_1, stageAppliedtoShortDesc1_1, gradeApplied_1, gradeAppliedShortDesc1_1, gradeAppliedacdAcademicYear_1, gradeAppliedacdGlFinperiodFin_period_info_1, gradeAppliedStageShortDesc1_1, academicYearto_1, academicYeartoAcademicYear_1, academicYeartoGlFinperiodFin_period_info_1, academicYeartoGlFinperiodaccountnumberAcc_Nm_1, class_1, classClassDesc1_1, schstatus_code_1, schstatus_schstatus_name_1, schstudenttypid_1, schstudenttypschstudenttyp_1, id_1, theidname_1_1, currentSchool_1, remarks_1, fathertel_1, fathertel2_1, passfail_1, fatherjob_1, fatheraddress_1, fathertel3_1, fatheremail_1, ageyear_1, agemonth_1, ageday_1, homephone_1, printed_1, birthDocNo_1, birthdocdate_1, birthDocPlace_1, birthPlace_1, residencenumber_1, residenceExpDate_1, schsthlthcaseid_1, schsthlthcaseschsthlthcaseDesc_1, cntry_No1_1, cntry_No1Cntry_Nm_1, cntry_No2_1, cntry_No2Cntry_Nm_1, state_1, stateState_Nm_1, area_1, areaDesc1_1, blockno_1, streetno_1, gadah_1, houseno_1, emergencyTelNo1_1, mothercase_1, mothercasejob_desc_1, fathercase_1, fathercasejob_desc_1, socialstatus_1, socialstatusschsocialstatuscaseDesc_1, studentsefa_1, studentsefastudentsefaar_1, studentsefadebitaccountAcc_Nm_1, studentsefadebitaccountClsacc_Acc_Nm_1, studentsefadebitaccountAcc_BndAcc_Nm_1, schclasskindid_1, schclasskindSchclasskinddesc_1, schstclasskinddmgid_1, schstclasskinddmgschstclasskinddmgDesc_1, schtransferid_1, schtransferSchtransferDesc_1, classorder_1, modifiedBy_1, modifiedOn_1, createdBy_1, createdOn_1, agarulyear_1, agarulmonth_1, dateofcalculate_1, agarulyearmax_1, agarulmonthmax_1, agarulmonthmax_2, calssserial_1, paidrosom_1, parentsrelation_1, theparentsrelationparentsrelationdesc_1, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal applicationCodeauto As Nullable(Of Long), ByVal applicationCodeauto_1 As Nullable(Of Long)) As eZee.Data.Objects.schApplication1001
            Dim list As List(Of eZee.Data.Objects.schApplication1001) = [Select](applicationCodeauto, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, applicationCodeauto_1, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schApplication1001)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("schApplication1001", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schApplication1001)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schApplication1001)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schApplication1001)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schApplication1001
            Dim list As List(Of eZee.Data.Objects.schApplication1001) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theschApplication1001 As eZee.Data.Objects.schApplication1001, ByVal original_schApplication1001 As eZee.Data.Objects.schApplication1001) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("ApplicationCodeauto", original_schApplication1001.ApplicationCodeauto, theschApplication1001.ApplicationCodeauto, true))
            values.Add(New FieldValue("schtrnsid", original_schApplication1001.schtrnsid, theschApplication1001.schtrnsid))
            values.Add(New FieldValue("schtrnsschtrnsDesc", original_schApplication1001.schtrnsschtrnsDesc, theschApplication1001.schtrnsschtrnsDesc, true))
            values.Add(New FieldValue("branch", original_schApplication1001.branch, theschApplication1001.branch))
            values.Add(New FieldValue("ThebranchDesc1", original_schApplication1001.ThebranchDesc1, theschApplication1001.ThebranchDesc1, true))
            values.Add(New FieldValue("Thebranchsgmsgm_Nm", original_schApplication1001.Thebranchsgmsgm_Nm, theschApplication1001.Thebranchsgmsgm_Nm, true))
            values.Add(New FieldValue("ThebranchsgmOpcoOpcoName", original_schApplication1001.ThebranchsgmOpcoOpcoName, theschApplication1001.ThebranchsgmOpcoOpcoName, true))
            values.Add(New FieldValue("ThebranchGenderGender", original_schApplication1001.ThebranchGenderGender, theschApplication1001.ThebranchGenderGender, true))
            values.Add(New FieldValue("ThebranchschtypschtypDesc", original_schApplication1001.ThebranchschtypschtypDesc, theschApplication1001.ThebranchschtypschtypDesc, true))
            values.Add(New FieldValue("ApplicationDate", original_schApplication1001.ApplicationDate, theschApplication1001.ApplicationDate))
            values.Add(New FieldValue("StudentCode", original_schApplication1001.StudentCode, theschApplication1001.StudentCode))
            values.Add(New FieldValue("StudentSchstCivilidnumber", original_schApplication1001.StudentSchstCivilidnumber, theschApplication1001.StudentSchstCivilidnumber, true))
            values.Add(New FieldValue("StudentareaDesc1", original_schApplication1001.StudentareaDesc1, theschApplication1001.StudentareaDesc1, true))
            values.Add(New FieldValue("StudentbranchDesc1", original_schApplication1001.StudentbranchDesc1, theschApplication1001.StudentbranchDesc1, true))
            values.Add(New FieldValue("Studentbranchsgmsgm_Nm", original_schApplication1001.Studentbranchsgmsgm_Nm, theschApplication1001.Studentbranchsgmsgm_Nm, true))
            values.Add(New FieldValue("StudentbranchGenderGender", original_schApplication1001.StudentbranchGenderGender, theschApplication1001.StudentbranchGenderGender, true))
            values.Add(New FieldValue("StudentbranchschtypschtypDesc", original_schApplication1001.StudentbranchschtypschtypDesc, theschApplication1001.StudentbranchschtypschtypDesc, true))
            values.Add(New FieldValue("StudentCntry_Cntry_Nm", original_schApplication1001.StudentCntry_Cntry_Nm, theschApplication1001.StudentCntry_Cntry_Nm, true))
            values.Add(New FieldValue("StudentGenderGender", original_schApplication1001.StudentGenderGender, theschApplication1001.StudentGenderGender, true))
            values.Add(New FieldValue("StudentReligionReljan_nm", original_schApplication1001.StudentReligionReljan_nm, theschApplication1001.StudentReligionReljan_nm, true))
            values.Add(New FieldValue("StudentstateState_Nm", original_schApplication1001.StudentstateState_Nm, theschApplication1001.StudentstateState_Nm, true))
            values.Add(New FieldValue("Studentidname_1", original_schApplication1001.Studentidname_1, theschApplication1001.Studentidname_1, true))
            values.Add(New FieldValue("StudentacdAcademicYear", original_schApplication1001.StudentacdAcademicYear, theschApplication1001.StudentacdAcademicYear, true))
            values.Add(New FieldValue("StudentacdGlFinperiodFin_period_info", original_schApplication1001.StudentacdGlFinperiodFin_period_info, theschApplication1001.StudentacdGlFinperiodFin_period_info, true))
            values.Add(New FieldValue("StudentClassClassDesc1", original_schApplication1001.StudentClassClassDesc1, theschApplication1001.StudentClassClassDesc1, true))
            values.Add(New FieldValue("StudentSchclasskindSchclasskinddesc", original_schApplication1001.StudentSchclasskindSchclasskinddesc, theschApplication1001.StudentSchclasskindSchclasskinddesc, true))
            values.Add(New FieldValue("StudentFatherfathfirstname1", original_schApplication1001.StudentFatherfathfirstname1, theschApplication1001.StudentFatherfathfirstname1, true))
            values.Add(New FieldValue("StudentFatherMaritalStatusStatus_Nm", original_schApplication1001.StudentFatherMaritalStatusStatus_Nm, theschApplication1001.StudentFatherMaritalStatusStatus_Nm, true))
            values.Add(New FieldValue("StudentFatherareaDesc1", original_schApplication1001.StudentFatherareaDesc1, theschApplication1001.StudentFatherareaDesc1, true))
            values.Add(New FieldValue("StudentFatherCntry_Cntry_Nm", original_schApplication1001.StudentFatherCntry_Cntry_Nm, theschApplication1001.StudentFatherCntry_Cntry_Nm, true))
            values.Add(New FieldValue("StudentFatherreligionReljan_nm", original_schApplication1001.StudentFatherreligionReljan_nm, theschApplication1001.StudentFatherreligionReljan_nm, true))
            values.Add(New FieldValue("StudentFatherStateState_Nm", original_schApplication1001.StudentFatherStateState_Nm, theschApplication1001.StudentFatherStateState_Nm, true))
            values.Add(New FieldValue("StudentFatherjob_job_desc", original_schApplication1001.StudentFatherjob_job_desc, theschApplication1001.StudentFatherjob_job_desc, true))
            values.Add(New FieldValue("StudentGradeShortDesc1", original_schApplication1001.StudentGradeShortDesc1, theschApplication1001.StudentGradeShortDesc1, true))
            values.Add(New FieldValue("StudentGradeacdAcademicYear", original_schApplication1001.StudentGradeacdAcademicYear, theschApplication1001.StudentGradeacdAcademicYear, true))
            values.Add(New FieldValue("StudentGradeStageShortDesc1", original_schApplication1001.StudentGradeStageShortDesc1, theschApplication1001.StudentGradeStageShortDesc1, true))
            values.Add(New FieldValue("StudentMotherfirstname1", original_schApplication1001.StudentMotherfirstname1, theschApplication1001.StudentMotherfirstname1, true))
            values.Add(New FieldValue("StudentMotherareaDesc1", original_schApplication1001.StudentMotherareaDesc1, theschApplication1001.StudentMotherareaDesc1, true))
            values.Add(New FieldValue("StudentMotherCntry_Cntry_Nm", original_schApplication1001.StudentMotherCntry_Cntry_Nm, theschApplication1001.StudentMotherCntry_Cntry_Nm, true))
            values.Add(New FieldValue("StudentMotherreligionReljan_nm", original_schApplication1001.StudentMotherreligionReljan_nm, theschApplication1001.StudentMotherreligionReljan_nm, true))
            values.Add(New FieldValue("StudentMotherStateState_Nm", original_schApplication1001.StudentMotherStateState_Nm, theschApplication1001.StudentMotherStateState_Nm, true))
            values.Add(New FieldValue("StudentMotherjob_job_desc", original_schApplication1001.StudentMotherjob_job_desc, theschApplication1001.StudentMotherjob_job_desc, true))
            values.Add(New FieldValue("StudentStageShortDesc1", original_schApplication1001.StudentStageShortDesc1, theschApplication1001.StudentStageShortDesc1, true))
            values.Add(New FieldValue("Studentschstatus_schstatus_name", original_schApplication1001.Studentschstatus_schstatus_name, theschApplication1001.Studentschstatus_schstatus_name, true))
            values.Add(New FieldValue("StudentschstclasskinddmgschstclasskinddmgDesc", original_schApplication1001.StudentschstclasskinddmgschstclasskinddmgDesc, theschApplication1001.StudentschstclasskinddmgschstclasskinddmgDesc, true))
            values.Add(New FieldValue("StudentschstsplschstsplDsc", original_schApplication1001.StudentschstsplschstsplDsc, theschApplication1001.StudentschstsplschstsplDsc, true))
            values.Add(New FieldValue("StudentschsthlthcaseschsthlthcaseDesc", original_schApplication1001.StudentschsthlthcaseschsthlthcaseDesc, theschApplication1001.StudentschsthlthcaseschsthlthcaseDesc, true))
            values.Add(New FieldValue("Studentstudentsefastudentsefaar", original_schApplication1001.Studentstudentsefastudentsefaar, theschApplication1001.Studentstudentsefastudentsefaar, true))
            values.Add(New FieldValue("StudentstudentsefadebitaccountAcc_Nm", original_schApplication1001.StudentstudentsefadebitaccountAcc_Nm, theschApplication1001.StudentstudentsefadebitaccountAcc_Nm, true))
            values.Add(New FieldValue("Studentschstudenttypschstudenttyp", original_schApplication1001.Studentschstudenttypschstudenttyp, theschApplication1001.Studentschstudenttypschstudenttyp, true))
            values.Add(New FieldValue("StudentSchtransferSchtransferDesc", original_schApplication1001.StudentSchtransferSchtransferDesc, theschApplication1001.StudentSchtransferSchtransferDesc, true))
            values.Add(New FieldValue("civilidst", original_schApplication1001.civilidst, theschApplication1001.civilidst))
            values.Add(New FieldValue("studentfullname", original_schApplication1001.studentfullname, theschApplication1001.studentfullname))
            values.Add(New FieldValue("Fathername", original_schApplication1001.Fathername, theschApplication1001.Fathername))
            values.Add(New FieldValue("Cntry_No", original_schApplication1001.Cntry_No, theschApplication1001.Cntry_No))
            values.Add(New FieldValue("Cntry_Cntry_Nm", original_schApplication1001.Cntry_Cntry_Nm, theschApplication1001.Cntry_Cntry_Nm, true))
            values.Add(New FieldValue("DateofBirth", original_schApplication1001.DateofBirth, theschApplication1001.DateofBirth))
            values.Add(New FieldValue("Genderid", original_schApplication1001.Genderid, theschApplication1001.Genderid))
            values.Add(New FieldValue("GenderGender", original_schApplication1001.GenderGender, theschApplication1001.GenderGender, true))
            values.Add(New FieldValue("StageAppliedto", original_schApplication1001.StageAppliedto, theschApplication1001.StageAppliedto))
            values.Add(New FieldValue("StageAppliedtoShortDesc1", original_schApplication1001.StageAppliedtoShortDesc1, theschApplication1001.StageAppliedtoShortDesc1, true))
            values.Add(New FieldValue("GradeApplied", original_schApplication1001.GradeApplied, theschApplication1001.GradeApplied))
            values.Add(New FieldValue("GradeAppliedShortDesc1", original_schApplication1001.GradeAppliedShortDesc1, theschApplication1001.GradeAppliedShortDesc1, true))
            values.Add(New FieldValue("GradeAppliedacdAcademicYear", original_schApplication1001.GradeAppliedacdAcademicYear, theschApplication1001.GradeAppliedacdAcademicYear, true))
            values.Add(New FieldValue("GradeAppliedacdGlFinperiodFin_period_info", original_schApplication1001.GradeAppliedacdGlFinperiodFin_period_info, theschApplication1001.GradeAppliedacdGlFinperiodFin_period_info, true))
            values.Add(New FieldValue("GradeAppliedStageShortDesc1", original_schApplication1001.GradeAppliedStageShortDesc1, theschApplication1001.GradeAppliedStageShortDesc1, true))
            values.Add(New FieldValue("AcademicYearto", original_schApplication1001.AcademicYearto, theschApplication1001.AcademicYearto))
            values.Add(New FieldValue("AcademicYeartoAcademicYear", original_schApplication1001.AcademicYeartoAcademicYear, theschApplication1001.AcademicYeartoAcademicYear, true))
            values.Add(New FieldValue("AcademicYeartoGlFinperiodFin_period_info", original_schApplication1001.AcademicYeartoGlFinperiodFin_period_info, theschApplication1001.AcademicYeartoGlFinperiodFin_period_info, true))
            values.Add(New FieldValue("AcademicYeartoGlFinperiodaccountnumberAcc_Nm", original_schApplication1001.AcademicYeartoGlFinperiodaccountnumberAcc_Nm, theschApplication1001.AcademicYeartoGlFinperiodaccountnumberAcc_Nm, true))
            values.Add(New FieldValue("Class", original_schApplication1001.Class, theschApplication1001.Class))
            values.Add(New FieldValue("ClassClassDesc1", original_schApplication1001.ClassClassDesc1, theschApplication1001.ClassClassDesc1, true))
            values.Add(New FieldValue("schstatus_code", original_schApplication1001.schstatus_code, theschApplication1001.schstatus_code))
            values.Add(New FieldValue("schstatus_schstatus_name", original_schApplication1001.schstatus_schstatus_name, theschApplication1001.schstatus_schstatus_name, true))
            values.Add(New FieldValue("schstudenttypid", original_schApplication1001.schstudenttypid, theschApplication1001.schstudenttypid))
            values.Add(New FieldValue("schstudenttypschstudenttyp", original_schApplication1001.schstudenttypschstudenttyp, theschApplication1001.schstudenttypschstudenttyp, true))
            values.Add(New FieldValue("id", original_schApplication1001.id, theschApplication1001.id))
            values.Add(New FieldValue("Theidname_1", original_schApplication1001.Theidname_1, theschApplication1001.Theidname_1, true))
            values.Add(New FieldValue("CurrentSchool", original_schApplication1001.CurrentSchool, theschApplication1001.CurrentSchool))
            values.Add(New FieldValue("Remarks", original_schApplication1001.Remarks, theschApplication1001.Remarks))
            values.Add(New FieldValue("Fathertel", original_schApplication1001.Fathertel, theschApplication1001.Fathertel))
            values.Add(New FieldValue("Fathertel2", original_schApplication1001.Fathertel2, theschApplication1001.Fathertel2))
            values.Add(New FieldValue("passfail", original_schApplication1001.passfail, theschApplication1001.passfail, true))
            values.Add(New FieldValue("fromout", original_schApplication1001.fromout, theschApplication1001.fromout))
            values.Add(New FieldValue("fatherjob", original_schApplication1001.fatherjob, theschApplication1001.fatherjob))
            values.Add(New FieldValue("fatheraddress", original_schApplication1001.fatheraddress, theschApplication1001.fatheraddress))
            values.Add(New FieldValue("fathertel3", original_schApplication1001.fathertel3, theschApplication1001.fathertel3))
            values.Add(New FieldValue("fatheremail", original_schApplication1001.fatheremail, theschApplication1001.fatheremail))
            values.Add(New FieldValue("ageyear", original_schApplication1001.ageyear, theschApplication1001.ageyear))
            values.Add(New FieldValue("agemonth", original_schApplication1001.agemonth, theschApplication1001.agemonth))
            values.Add(New FieldValue("ageday", original_schApplication1001.ageday, theschApplication1001.ageday))
            values.Add(New FieldValue("homephone", original_schApplication1001.homephone, theschApplication1001.homephone))
            values.Add(New FieldValue("printed", original_schApplication1001.printed, theschApplication1001.printed))
            values.Add(New FieldValue("BirthDocNo", original_schApplication1001.BirthDocNo, theschApplication1001.BirthDocNo))
            values.Add(New FieldValue("birthdocdate", original_schApplication1001.birthdocdate, theschApplication1001.birthdocdate))
            values.Add(New FieldValue("BirthDocPlace", original_schApplication1001.BirthDocPlace, theschApplication1001.BirthDocPlace))
            values.Add(New FieldValue("BirthPlace", original_schApplication1001.BirthPlace, theschApplication1001.BirthPlace))
            values.Add(New FieldValue("Residencenumber", original_schApplication1001.Residencenumber, theschApplication1001.Residencenumber))
            values.Add(New FieldValue("ResidenceExpDate", original_schApplication1001.ResidenceExpDate, theschApplication1001.ResidenceExpDate))
            values.Add(New FieldValue("schsthlthcaseid", original_schApplication1001.schsthlthcaseid, theschApplication1001.schsthlthcaseid))
            values.Add(New FieldValue("schsthlthcaseschsthlthcaseDesc", original_schApplication1001.schsthlthcaseschsthlthcaseDesc, theschApplication1001.schsthlthcaseschsthlthcaseDesc, true))
            values.Add(New FieldValue("Cntry_No1", original_schApplication1001.Cntry_No1, theschApplication1001.Cntry_No1))
            values.Add(New FieldValue("Cntry_No1Cntry_Nm", original_schApplication1001.Cntry_No1Cntry_Nm, theschApplication1001.Cntry_No1Cntry_Nm, true))
            values.Add(New FieldValue("Cntry_No2", original_schApplication1001.Cntry_No2, theschApplication1001.Cntry_No2))
            values.Add(New FieldValue("Cntry_No2Cntry_Nm", original_schApplication1001.Cntry_No2Cntry_Nm, theschApplication1001.Cntry_No2Cntry_Nm, true))
            values.Add(New FieldValue("state", original_schApplication1001.state, theschApplication1001.state))
            values.Add(New FieldValue("stateState_Nm", original_schApplication1001.stateState_Nm, theschApplication1001.stateState_Nm, true))
            values.Add(New FieldValue("area", original_schApplication1001.area, theschApplication1001.area))
            values.Add(New FieldValue("areaDesc1", original_schApplication1001.areaDesc1, theschApplication1001.areaDesc1, true))
            values.Add(New FieldValue("blockno", original_schApplication1001.blockno, theschApplication1001.blockno))
            values.Add(New FieldValue("streetno", original_schApplication1001.streetno, theschApplication1001.streetno))
            values.Add(New FieldValue("gadah", original_schApplication1001.gadah, theschApplication1001.gadah))
            values.Add(New FieldValue("houseno", original_schApplication1001.houseno, theschApplication1001.houseno))
            values.Add(New FieldValue("addressdetail", original_schApplication1001.addressdetail, theschApplication1001.addressdetail))
            values.Add(New FieldValue("EmergencyTelNo1", original_schApplication1001.EmergencyTelNo1, theschApplication1001.EmergencyTelNo1))
            values.Add(New FieldValue("mothercase", original_schApplication1001.mothercase, theschApplication1001.mothercase))
            values.Add(New FieldValue("mothercasejob_desc", original_schApplication1001.mothercasejob_desc, theschApplication1001.mothercasejob_desc, true))
            values.Add(New FieldValue("fathercase", original_schApplication1001.fathercase, theschApplication1001.fathercase))
            values.Add(New FieldValue("fathercasejob_desc", original_schApplication1001.fathercasejob_desc, theschApplication1001.fathercasejob_desc, true))
            values.Add(New FieldValue("socialstatus", original_schApplication1001.socialstatus, theschApplication1001.socialstatus))
            values.Add(New FieldValue("socialstatusschsocialstatuscaseDesc", original_schApplication1001.socialstatusschsocialstatuscaseDesc, theschApplication1001.socialstatusschsocialstatuscaseDesc, true))
            values.Add(New FieldValue("studentsefa", original_schApplication1001.studentsefa, theschApplication1001.studentsefa))
            values.Add(New FieldValue("studentsefastudentsefaar", original_schApplication1001.studentsefastudentsefaar, theschApplication1001.studentsefastudentsefaar, true))
            values.Add(New FieldValue("studentsefadebitaccountAcc_Nm", original_schApplication1001.studentsefadebitaccountAcc_Nm, theschApplication1001.studentsefadebitaccountAcc_Nm, true))
            values.Add(New FieldValue("studentsefadebitaccountClsacc_Acc_Nm", original_schApplication1001.studentsefadebitaccountClsacc_Acc_Nm, theschApplication1001.studentsefadebitaccountClsacc_Acc_Nm, true))
            values.Add(New FieldValue("studentsefadebitaccountAcc_BndAcc_Nm", original_schApplication1001.studentsefadebitaccountAcc_BndAcc_Nm, theschApplication1001.studentsefadebitaccountAcc_BndAcc_Nm, true))
            values.Add(New FieldValue("Schclasskindid", original_schApplication1001.Schclasskindid, theschApplication1001.Schclasskindid))
            values.Add(New FieldValue("SchclasskindSchclasskinddesc", original_schApplication1001.SchclasskindSchclasskinddesc, theschApplication1001.SchclasskindSchclasskinddesc, true))
            values.Add(New FieldValue("schstclasskinddmgid", original_schApplication1001.schstclasskinddmgid, theschApplication1001.schstclasskinddmgid))
            values.Add(New FieldValue("schstclasskinddmgschstclasskinddmgDesc", original_schApplication1001.schstclasskinddmgschstclasskinddmgDesc, theschApplication1001.schstclasskinddmgschstclasskinddmgDesc, true))
            values.Add(New FieldValue("Schtransferid", original_schApplication1001.Schtransferid, theschApplication1001.Schtransferid))
            values.Add(New FieldValue("SchtransferSchtransferDesc", original_schApplication1001.SchtransferSchtransferDesc, theschApplication1001.SchtransferSchtransferDesc, true))
            values.Add(New FieldValue("classorder", original_schApplication1001.classorder, theschApplication1001.classorder))
            values.Add(New FieldValue("ModifiedBy", original_schApplication1001.ModifiedBy, theschApplication1001.ModifiedBy))
            values.Add(New FieldValue("ModifiedOn", original_schApplication1001.ModifiedOn, theschApplication1001.ModifiedOn))
            values.Add(New FieldValue("CreatedBy", original_schApplication1001.CreatedBy, theschApplication1001.CreatedBy))
            values.Add(New FieldValue("CreatedOn", original_schApplication1001.CreatedOn, theschApplication1001.CreatedOn))
            values.Add(New FieldValue("agarulyear", original_schApplication1001.agarulyear, theschApplication1001.agarulyear, true))
            values.Add(New FieldValue("agarulmonth", original_schApplication1001.agarulmonth, theschApplication1001.agarulmonth))
            values.Add(New FieldValue("dateofcalculate", original_schApplication1001.dateofcalculate, theschApplication1001.dateofcalculate))
            values.Add(New FieldValue("agarulyearmax", original_schApplication1001.agarulyearmax, theschApplication1001.agarulyearmax))
            values.Add(New FieldValue("agarulmonthmax", original_schApplication1001.agarulmonthmax, theschApplication1001.agarulmonthmax))
            values.Add(New FieldValue("studentBalance1", original_schApplication1001.studentBalance1, theschApplication1001.studentBalance1))
            values.Add(New FieldValue("studentnotes", original_schApplication1001.studentnotes, theschApplication1001.studentnotes, true))
            values.Add(New FieldValue("calssserial", original_schApplication1001.calssserial, theschApplication1001.calssserial))
            values.Add(New FieldValue("paidrosom", original_schApplication1001.paidrosom, theschApplication1001.paidrosom))
            values.Add(New FieldValue("parentsrelation", original_schApplication1001.parentsrelation, theschApplication1001.parentsrelation))
            values.Add(New FieldValue("Theparentsrelationparentsrelationdesc", original_schApplication1001.Theparentsrelationparentsrelationdesc, theschApplication1001.Theparentsrelationparentsrelationdesc, true))
            values.Add(New FieldValue("studentfullname1", original_schApplication1001.studentfullname1, theschApplication1001.studentfullname1))
            values.Add(New FieldValue("ApplicationCodeauto_1", original_schApplication1001.ApplicationCodeauto_1, theschApplication1001.ApplicationCodeauto_1, true))
            values.Add(New FieldValue("schtrnsid_1", original_schApplication1001.schtrnsid_1, theschApplication1001.schtrnsid_1))
            values.Add(New FieldValue("schtrnsschtrnsDesc_1", original_schApplication1001.schtrnsschtrnsDesc_1, theschApplication1001.schtrnsschtrnsDesc_1, true))
            values.Add(New FieldValue("branch_1", original_schApplication1001.branch_1, theschApplication1001.branch_1))
            values.Add(New FieldValue("ThebranchDesc1_1", original_schApplication1001.ThebranchDesc1_1, theschApplication1001.ThebranchDesc1_1, true))
            values.Add(New FieldValue("Thebranchsgmsgm_Nm_1", original_schApplication1001.Thebranchsgmsgm_Nm_1, theschApplication1001.Thebranchsgmsgm_Nm_1, true))
            values.Add(New FieldValue("ThebranchsgmOpcoOpcoName_1", original_schApplication1001.ThebranchsgmOpcoOpcoName_1, theschApplication1001.ThebranchsgmOpcoOpcoName_1, true))
            values.Add(New FieldValue("ThebranchGenderGender_1", original_schApplication1001.ThebranchGenderGender_1, theschApplication1001.ThebranchGenderGender_1, true))
            values.Add(New FieldValue("ThebranchschtypschtypDesc_1", original_schApplication1001.ThebranchschtypschtypDesc_1, theschApplication1001.ThebranchschtypschtypDesc_1, true))
            values.Add(New FieldValue("ApplicationDate_1", original_schApplication1001.ApplicationDate_1, theschApplication1001.ApplicationDate_1))
            values.Add(New FieldValue("StudentCode_1", original_schApplication1001.StudentCode_1, theschApplication1001.StudentCode_1))
            values.Add(New FieldValue("StudentSchstCivilidnumber_1", original_schApplication1001.StudentSchstCivilidnumber_1, theschApplication1001.StudentSchstCivilidnumber_1, true))
            values.Add(New FieldValue("civilidst_1", original_schApplication1001.civilidst_1, theschApplication1001.civilidst_1))
            values.Add(New FieldValue("studentfullname_1", original_schApplication1001.studentfullname_1, theschApplication1001.studentfullname_1))
            values.Add(New FieldValue("Fathername_1", original_schApplication1001.Fathername_1, theschApplication1001.Fathername_1))
            values.Add(New FieldValue("Cntry_No_1", original_schApplication1001.Cntry_No_1, theschApplication1001.Cntry_No_1))
            values.Add(New FieldValue("Cntry_Cntry_Nm_1", original_schApplication1001.Cntry_Cntry_Nm_1, theschApplication1001.Cntry_Cntry_Nm_1, true))
            values.Add(New FieldValue("DateofBirth_1", original_schApplication1001.DateofBirth_1, theschApplication1001.DateofBirth_1))
            values.Add(New FieldValue("Genderid_1", original_schApplication1001.Genderid_1, theschApplication1001.Genderid_1))
            values.Add(New FieldValue("GenderGender_1", original_schApplication1001.GenderGender_1, theschApplication1001.GenderGender_1, true))
            values.Add(New FieldValue("StageAppliedto_1", original_schApplication1001.StageAppliedto_1, theschApplication1001.StageAppliedto_1))
            values.Add(New FieldValue("StageAppliedtoShortDesc1_1", original_schApplication1001.StageAppliedtoShortDesc1_1, theschApplication1001.StageAppliedtoShortDesc1_1, true))
            values.Add(New FieldValue("GradeApplied_1", original_schApplication1001.GradeApplied_1, theschApplication1001.GradeApplied_1))
            values.Add(New FieldValue("GradeAppliedShortDesc1_1", original_schApplication1001.GradeAppliedShortDesc1_1, theschApplication1001.GradeAppliedShortDesc1_1, true))
            values.Add(New FieldValue("GradeAppliedacdAcademicYear_1", original_schApplication1001.GradeAppliedacdAcademicYear_1, theschApplication1001.GradeAppliedacdAcademicYear_1, true))
            values.Add(New FieldValue("GradeAppliedacdGlFinperiodFin_period_info_1", original_schApplication1001.GradeAppliedacdGlFinperiodFin_period_info_1, theschApplication1001.GradeAppliedacdGlFinperiodFin_period_info_1, true))
            values.Add(New FieldValue("GradeAppliedStageShortDesc1_1", original_schApplication1001.GradeAppliedStageShortDesc1_1, theschApplication1001.GradeAppliedStageShortDesc1_1, true))
            values.Add(New FieldValue("AcademicYearto_1", original_schApplication1001.AcademicYearto_1, theschApplication1001.AcademicYearto_1))
            values.Add(New FieldValue("AcademicYeartoAcademicYear_1", original_schApplication1001.AcademicYeartoAcademicYear_1, theschApplication1001.AcademicYeartoAcademicYear_1, true))
            values.Add(New FieldValue("AcademicYeartoGlFinperiodFin_period_info_1", original_schApplication1001.AcademicYeartoGlFinperiodFin_period_info_1, theschApplication1001.AcademicYeartoGlFinperiodFin_period_info_1, true))
            values.Add(New FieldValue("AcademicYeartoGlFinperiodaccountnumberAcc_Nm_1", original_schApplication1001.AcademicYeartoGlFinperiodaccountnumberAcc_Nm_1, theschApplication1001.AcademicYeartoGlFinperiodaccountnumberAcc_Nm_1, true))
            values.Add(New FieldValue("Class_1", original_schApplication1001.Class_1, theschApplication1001.Class_1))
            values.Add(New FieldValue("ClassClassDesc1_1", original_schApplication1001.ClassClassDesc1_1, theschApplication1001.ClassClassDesc1_1, true))
            values.Add(New FieldValue("schstatus_code_1", original_schApplication1001.schstatus_code_1, theschApplication1001.schstatus_code_1))
            values.Add(New FieldValue("schstatus_schstatus_name_1", original_schApplication1001.schstatus_schstatus_name_1, theschApplication1001.schstatus_schstatus_name_1, true))
            values.Add(New FieldValue("schstudenttypid_1", original_schApplication1001.schstudenttypid_1, theschApplication1001.schstudenttypid_1))
            values.Add(New FieldValue("schstudenttypschstudenttyp_1", original_schApplication1001.schstudenttypschstudenttyp_1, theschApplication1001.schstudenttypschstudenttyp_1, true))
            values.Add(New FieldValue("id_1", original_schApplication1001.id_1, theschApplication1001.id_1))
            values.Add(New FieldValue("Theidname_1_1", original_schApplication1001.Theidname_1_1, theschApplication1001.Theidname_1_1, true))
            values.Add(New FieldValue("CurrentSchool_1", original_schApplication1001.CurrentSchool_1, theschApplication1001.CurrentSchool_1))
            values.Add(New FieldValue("Remarks_1", original_schApplication1001.Remarks_1, theschApplication1001.Remarks_1))
            values.Add(New FieldValue("Fathertel_1", original_schApplication1001.Fathertel_1, theschApplication1001.Fathertel_1))
            values.Add(New FieldValue("Fathertel2_1", original_schApplication1001.Fathertel2_1, theschApplication1001.Fathertel2_1))
            values.Add(New FieldValue("passfail_1", original_schApplication1001.passfail_1, theschApplication1001.passfail_1))
            values.Add(New FieldValue("fromout_1", original_schApplication1001.fromout_1, theschApplication1001.fromout_1))
            values.Add(New FieldValue("fatherjob_1", original_schApplication1001.fatherjob_1, theschApplication1001.fatherjob_1))
            values.Add(New FieldValue("fatheraddress_1", original_schApplication1001.fatheraddress_1, theschApplication1001.fatheraddress_1))
            values.Add(New FieldValue("fathertel3_1", original_schApplication1001.fathertel3_1, theschApplication1001.fathertel3_1))
            values.Add(New FieldValue("fatheremail_1", original_schApplication1001.fatheremail_1, theschApplication1001.fatheremail_1))
            values.Add(New FieldValue("ageyear_1", original_schApplication1001.ageyear_1, theschApplication1001.ageyear_1))
            values.Add(New FieldValue("agemonth_1", original_schApplication1001.agemonth_1, theschApplication1001.agemonth_1))
            values.Add(New FieldValue("ageday_1", original_schApplication1001.ageday_1, theschApplication1001.ageday_1))
            values.Add(New FieldValue("homephone_1", original_schApplication1001.homephone_1, theschApplication1001.homephone_1))
            values.Add(New FieldValue("printed_1", original_schApplication1001.printed_1, theschApplication1001.printed_1))
            values.Add(New FieldValue("BirthDocNo_1", original_schApplication1001.BirthDocNo_1, theschApplication1001.BirthDocNo_1))
            values.Add(New FieldValue("birthdocdate_1", original_schApplication1001.birthdocdate_1, theschApplication1001.birthdocdate_1))
            values.Add(New FieldValue("BirthDocPlace_1", original_schApplication1001.BirthDocPlace_1, theschApplication1001.BirthDocPlace_1))
            values.Add(New FieldValue("BirthPlace_1", original_schApplication1001.BirthPlace_1, theschApplication1001.BirthPlace_1))
            values.Add(New FieldValue("Residencenumber_1", original_schApplication1001.Residencenumber_1, theschApplication1001.Residencenumber_1))
            values.Add(New FieldValue("ResidenceExpDate_1", original_schApplication1001.ResidenceExpDate_1, theschApplication1001.ResidenceExpDate_1))
            values.Add(New FieldValue("schsthlthcaseid_1", original_schApplication1001.schsthlthcaseid_1, theschApplication1001.schsthlthcaseid_1))
            values.Add(New FieldValue("schsthlthcaseschsthlthcaseDesc_1", original_schApplication1001.schsthlthcaseschsthlthcaseDesc_1, theschApplication1001.schsthlthcaseschsthlthcaseDesc_1, true))
            values.Add(New FieldValue("Cntry_No1_1", original_schApplication1001.Cntry_No1_1, theschApplication1001.Cntry_No1_1))
            values.Add(New FieldValue("Cntry_No1Cntry_Nm_1", original_schApplication1001.Cntry_No1Cntry_Nm_1, theschApplication1001.Cntry_No1Cntry_Nm_1, true))
            values.Add(New FieldValue("Cntry_No2_1", original_schApplication1001.Cntry_No2_1, theschApplication1001.Cntry_No2_1))
            values.Add(New FieldValue("Cntry_No2Cntry_Nm_1", original_schApplication1001.Cntry_No2Cntry_Nm_1, theschApplication1001.Cntry_No2Cntry_Nm_1, true))
            values.Add(New FieldValue("state_1", original_schApplication1001.state_1, theschApplication1001.state_1))
            values.Add(New FieldValue("stateState_Nm_1", original_schApplication1001.stateState_Nm_1, theschApplication1001.stateState_Nm_1, true))
            values.Add(New FieldValue("area_1", original_schApplication1001.area_1, theschApplication1001.area_1))
            values.Add(New FieldValue("areaDesc1_1", original_schApplication1001.areaDesc1_1, theschApplication1001.areaDesc1_1, true))
            values.Add(New FieldValue("blockno_1", original_schApplication1001.blockno_1, theschApplication1001.blockno_1))
            values.Add(New FieldValue("streetno_1", original_schApplication1001.streetno_1, theschApplication1001.streetno_1))
            values.Add(New FieldValue("gadah_1", original_schApplication1001.gadah_1, theschApplication1001.gadah_1))
            values.Add(New FieldValue("houseno_1", original_schApplication1001.houseno_1, theschApplication1001.houseno_1))
            values.Add(New FieldValue("addressdetail_1", original_schApplication1001.addressdetail_1, theschApplication1001.addressdetail_1))
            values.Add(New FieldValue("EmergencyTelNo1_1", original_schApplication1001.EmergencyTelNo1_1, theschApplication1001.EmergencyTelNo1_1))
            values.Add(New FieldValue("mothercase_1", original_schApplication1001.mothercase_1, theschApplication1001.mothercase_1))
            values.Add(New FieldValue("mothercasejob_desc_1", original_schApplication1001.mothercasejob_desc_1, theschApplication1001.mothercasejob_desc_1, true))
            values.Add(New FieldValue("fathercase_1", original_schApplication1001.fathercase_1, theschApplication1001.fathercase_1))
            values.Add(New FieldValue("fathercasejob_desc_1", original_schApplication1001.fathercasejob_desc_1, theschApplication1001.fathercasejob_desc_1, true))
            values.Add(New FieldValue("socialstatus_1", original_schApplication1001.socialstatus_1, theschApplication1001.socialstatus_1))
            values.Add(New FieldValue("socialstatusschsocialstatuscaseDesc_1", original_schApplication1001.socialstatusschsocialstatuscaseDesc_1, theschApplication1001.socialstatusschsocialstatuscaseDesc_1, true))
            values.Add(New FieldValue("studentsefa_1", original_schApplication1001.studentsefa_1, theschApplication1001.studentsefa_1))
            values.Add(New FieldValue("studentsefastudentsefaar_1", original_schApplication1001.studentsefastudentsefaar_1, theschApplication1001.studentsefastudentsefaar_1, true))
            values.Add(New FieldValue("studentsefadebitaccountAcc_Nm_1", original_schApplication1001.studentsefadebitaccountAcc_Nm_1, theschApplication1001.studentsefadebitaccountAcc_Nm_1, true))
            values.Add(New FieldValue("studentsefadebitaccountClsacc_Acc_Nm_1", original_schApplication1001.studentsefadebitaccountClsacc_Acc_Nm_1, theschApplication1001.studentsefadebitaccountClsacc_Acc_Nm_1, true))
            values.Add(New FieldValue("studentsefadebitaccountAcc_BndAcc_Nm_1", original_schApplication1001.studentsefadebitaccountAcc_BndAcc_Nm_1, theschApplication1001.studentsefadebitaccountAcc_BndAcc_Nm_1, true))
            values.Add(New FieldValue("Schclasskindid_1", original_schApplication1001.Schclasskindid_1, theschApplication1001.Schclasskindid_1))
            values.Add(New FieldValue("SchclasskindSchclasskinddesc_1", original_schApplication1001.SchclasskindSchclasskinddesc_1, theschApplication1001.SchclasskindSchclasskinddesc_1, true))
            values.Add(New FieldValue("schstclasskinddmgid_1", original_schApplication1001.schstclasskinddmgid_1, theschApplication1001.schstclasskinddmgid_1))
            values.Add(New FieldValue("schstclasskinddmgschstclasskinddmgDesc_1", original_schApplication1001.schstclasskinddmgschstclasskinddmgDesc_1, theschApplication1001.schstclasskinddmgschstclasskinddmgDesc_1, true))
            values.Add(New FieldValue("Schtransferid_1", original_schApplication1001.Schtransferid_1, theschApplication1001.Schtransferid_1))
            values.Add(New FieldValue("SchtransferSchtransferDesc_1", original_schApplication1001.SchtransferSchtransferDesc_1, theschApplication1001.SchtransferSchtransferDesc_1, true))
            values.Add(New FieldValue("classorder_1", original_schApplication1001.classorder_1, theschApplication1001.classorder_1))
            values.Add(New FieldValue("ModifiedBy_1", original_schApplication1001.ModifiedBy_1, theschApplication1001.ModifiedBy_1))
            values.Add(New FieldValue("ModifiedOn_1", original_schApplication1001.ModifiedOn_1, theschApplication1001.ModifiedOn_1))
            values.Add(New FieldValue("CreatedBy_1", original_schApplication1001.CreatedBy_1, theschApplication1001.CreatedBy_1))
            values.Add(New FieldValue("CreatedOn_1", original_schApplication1001.CreatedOn_1, theschApplication1001.CreatedOn_1))
            values.Add(New FieldValue("agarulyear_1", original_schApplication1001.agarulyear_1, theschApplication1001.agarulyear_1, true))
            values.Add(New FieldValue("agarulmonth_1", original_schApplication1001.agarulmonth_1, theschApplication1001.agarulmonth_1))
            values.Add(New FieldValue("dateofcalculate_1", original_schApplication1001.dateofcalculate_1, theschApplication1001.dateofcalculate_1))
            values.Add(New FieldValue("agarulyearmax_1", original_schApplication1001.agarulyearmax_1, theschApplication1001.agarulyearmax_1))
            values.Add(New FieldValue("agarulmonthmax_1", original_schApplication1001.agarulmonthmax_1, theschApplication1001.agarulmonthmax_1))
            values.Add(New FieldValue("agarulmonthmax_2", original_schApplication1001.agarulmonthmax_2, theschApplication1001.agarulmonthmax_2))
            values.Add(New FieldValue("calssserial_1", original_schApplication1001.calssserial_1, theschApplication1001.calssserial_1))
            values.Add(New FieldValue("paidrosom_1", original_schApplication1001.paidrosom_1, theschApplication1001.paidrosom_1))
            values.Add(New FieldValue("parentsrelation_1", original_schApplication1001.parentsrelation_1, theschApplication1001.parentsrelation_1))
            values.Add(New FieldValue("Theparentsrelationparentsrelationdesc_1", original_schApplication1001.Theparentsrelationparentsrelationdesc_1, theschApplication1001.Theparentsrelationparentsrelationdesc_1, true))
            values.Add(New FieldValue("studentfullname1_1", original_schApplication1001.studentfullname1_1, theschApplication1001.studentfullname1_1))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theschApplication1001 As eZee.Data.Objects.schApplication1001, ByVal original_schApplication1001 As eZee.Data.Objects.schApplication1001, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "schApplication1001"
            args.View = dataView
            args.Values = CreateFieldValues(theschApplication1001, original_schApplication1001)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("schApplication1001", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theschApplication1001)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theschApplication1001 As eZee.Data.Objects.schApplication1001, ByVal original_schApplication1001 As eZee.Data.Objects.schApplication1001) As Integer
            Return ExecuteAction(theschApplication1001, original_schApplication1001, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theschApplication1001 As eZee.Data.Objects.schApplication1001) As Integer
            Return Update(theschApplication1001, SelectSingle(theschApplication1001.ApplicationCodeauto, theschApplication1001.ApplicationCodeauto_1))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theschApplication1001 As eZee.Data.Objects.schApplication1001) As Integer
            Return ExecuteAction(theschApplication1001, New schApplication1001(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theschApplication1001 As eZee.Data.Objects.schApplication1001) As Integer
            Return ExecuteAction(theschApplication1001, theschApplication1001, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
