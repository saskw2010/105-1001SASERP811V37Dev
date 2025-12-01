Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class schApplication
        
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
        Private m_ThebranchstageShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ThebranchschtypschtypDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ApplicationDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentSchstCivilidnumber As String
        
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
        Private m_Calssserial As Nullable(Of Long)
        
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
        Private m_StudentBalance1 As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentnotes As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Paidrosom As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fatherrecord As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentfullname1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Parentsrelation As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Theparentsrelationparentsrelationdesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_EncryptedNationalIDNumber() As Byte
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Resigncases As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchstEmail As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_FatherCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_MotherCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Religion As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Notes As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CivilidExpDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_BookRecive As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agarulyear_1 As Nullable(Of Single)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agarulmonth_1 As Nullable(Of Single)
        
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
        Public Property ThebranchstageShortDesc1() As String
            Get
                Return m_ThebranchstageShortDesc1
            End Get
            Set
                m_ThebranchstageShortDesc1 = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
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
        Public Property calssserial() As Nullable(Of Long)
            Get
                Return m_Calssserial
            End Get
            Set
                m_Calssserial = value
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
        Public Property studentBalance1() As Nullable(Of Single)
            Get
                Return m_StudentBalance1
            End Get
            Set
                m_StudentBalance1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentnotes() As String
            Get
                Return m_Studentnotes
            End Get
            Set
                m_Studentnotes = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property fatherrecord() As Nullable(Of Boolean)
            Get
                Return m_Fatherrecord
            End Get
            Set
                m_Fatherrecord = value
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
        Public Property EncryptedNationalIDNumber() As Byte()
            Get
                Return m_EncryptedNationalIDNumber
            End Get
            Set
                m_EncryptedNationalIDNumber = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property resigncases() As String
            Get
                Return m_Resigncases
            End Get
            Set
                m_Resigncases = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstEmail() As String
            Get
                Return m_SchstEmail
            End Get
            Set
                m_SchstEmail = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property FatherCode() As Nullable(Of Long)
            Get
                Return m_FatherCode
            End Get
            Set
                m_FatherCode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property MotherCode() As Nullable(Of Long)
            Get
                Return m_MotherCode
            End Get
            Set
                m_MotherCode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Religion() As Nullable(Of Long)
            Get
                Return m_Religion
            End Get
            Set
                m_Religion = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Notes() As String
            Get
                Return m_Notes
            End Get
            Set
                m_Notes = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CivilidExpDate() As Nullable(Of DateTime)
            Get
                Return m_CivilidExpDate
            End Get
            Set
                m_CivilidExpDate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property BookRecive() As Nullable(Of Boolean)
            Get
                Return m_BookRecive
            End Get
            Set
                m_BookRecive = value
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
        
        Public Overloads Shared Function [Select]( _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc As String,  _
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
                    ByVal agarulyear_1 As Nullable(Of Single),  _
                    ByVal agarulmonth_1 As Nullable(Of Single)) As List(Of eZee.Data.Objects.schApplication)
            Return New schApplicationFactory().Select(applicationCodeauto, schtrnsid, schtrnsschtrnsDesc, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, applicationDate, studentCode, studentSchstCivilidnumber, civilidst, fathername, cntry_No, cntry_Cntry_Nm, dateofBirth, genderid, genderGender, stageAppliedto, stageAppliedtoShortDesc1, gradeApplied, gradeAppliedShortDesc1, gradeAppliedacdAcademicYear, gradeAppliedacdGlFinperiodFin_period_info, gradeAppliedStageShortDesc1, academicYearto, academicYeartoAcademicYear, academicYeartoGlFinperiodFin_period_info, academicYeartoGlFinperiodaccountnumberAcc_Nm, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, id, theidname_1, currentSchool, remarks, fathertel, fathertel2, passfail, fatherjob, fatheraddress, fathertel3, fatheremail, ageyear, agemonth, ageday, homephone, printed, birthDocNo, birthdocdate, birthDocPlace, birthPlace, residencenumber, residenceExpDate, schsthlthcaseid, schsthlthcaseschsthlthcaseDesc, cntry_No1, cntry_No1Cntry_Nm, cntry_No2, cntry_No2Cntry_Nm, state, stateState_Nm, area, areaDesc1, blockno, streetno, gadah, houseno, emergencyTelNo1, mothercase, mothercasejob_desc, fathercase, fathercasejob_desc, socialstatus, socialstatusschsocialstatuscaseDesc, studentsefa, studentsefastudentsefaar, studentsefadebitaccountAcc_Nm, studentsefadebitaccountClsacc_Acc_Nm, studentsefadebitaccountAcc_BndAcc_Nm, schclasskindid, schclasskindSchclasskinddesc, schstclasskinddmgid, schstclasskinddmgschstclasskinddmgDesc, schtransferid, schtransferSchtransferDesc, classorder, modifiedBy, modifiedOn, createdBy, createdOn, calssserial, agarulyear, agarulmonth, dateofcalculate, agarulyearmax, agarulmonthmax, studentBalance1, studentnotes, paidrosom, fatherrecord, parentsrelation, theparentsrelationparentsrelationdesc, schstEmail, fatherCode, motherCode, religion, civilidExpDate, bookRecive, agarulyear_1, agarulmonth_1)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.schApplication) As List(Of eZee.Data.Objects.schApplication)
            Return New schApplicationFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schApplication)
            Return New schApplicationFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schApplication)
            Return New schApplicationFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schApplication)
            Return New schApplicationFactory().Select(filter, sort, schApplicationFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schApplication)
            Return New schApplicationFactory().Select(filter, sort, schApplicationFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schApplication)
            Return New schApplicationFactory().Select(filter, Nothing, schApplicationFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schApplication)
            Return New schApplicationFactory().Select(filter, Nothing, schApplicationFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schApplication
            Return New schApplicationFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.schApplication
            Return New schApplicationFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal applicationCodeauto As Nullable(Of Long)) As eZee.Data.Objects.schApplication
            Return New schApplicationFactory().SelectSingle(applicationCodeauto)
        End Function
        
        Public Function Insert() As Integer
            Return New schApplicationFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New schApplicationFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New schApplicationFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("ApplicationCodeauto: {0}", Me.ApplicationCodeauto)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class schApplicationFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("schApplication")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("schApplication")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("schApplication")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("schApplication")
            End Get
        End Property
        
        Public Shared Function Create() As schApplicationFactory
            Return New schApplicationFactory()
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
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
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
                    ByVal agarulyear_1 As Nullable(Of Single),  _
                    ByVal agarulmonth_1 As Nullable(Of Single),  _
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
            If Not (String.IsNullOrEmpty(thebranchstageShortDesc1)) Then
                filter.Add(("ThebranchstageShortDesc1:*" + thebranchstageShortDesc1))
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
            If Not (String.IsNullOrEmpty(civilidst)) Then
                filter.Add(("civilidst:*" + civilidst))
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
            If calssserial.HasValue Then
                filter.Add(("calssserial:=" + calssserial.Value.ToString()))
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
            If Not (String.IsNullOrEmpty(studentnotes)) Then
                filter.Add(("studentnotes:*" + studentnotes))
            End If
            If paidrosom.HasValue Then
                filter.Add(("paidrosom:=" + paidrosom.Value.ToString()))
            End If
            If fatherrecord.HasValue Then
                filter.Add(("fatherrecord:=" + fatherrecord.Value.ToString()))
            End If
            If parentsrelation.HasValue Then
                filter.Add(("parentsrelation:=" + parentsrelation.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(theparentsrelationparentsrelationdesc)) Then
                filter.Add(("Theparentsrelationparentsrelationdesc:*" + theparentsrelationparentsrelationdesc))
            End If
            If Not (String.IsNullOrEmpty(schstEmail)) Then
                filter.Add(("schstEmail:*" + schstEmail))
            End If
            If fatherCode.HasValue Then
                filter.Add(("FatherCode:=" + fatherCode.Value.ToString()))
            End If
            If motherCode.HasValue Then
                filter.Add(("MotherCode:=" + motherCode.Value.ToString()))
            End If
            If religion.HasValue Then
                filter.Add(("Religion:=" + religion.Value.ToString()))
            End If
            If civilidExpDate.HasValue Then
                filter.Add(("CivilidExpDate:=" + civilidExpDate.Value.ToString()))
            End If
            If bookRecive.HasValue Then
                filter.Add(("BookRecive:=" + bookRecive.Value.ToString()))
            End If
            If agarulyear_1.HasValue Then
                filter.Add(("agarulyear_1:=" + agarulyear_1.Value.ToString()))
            End If
            If agarulmonth_1.HasValue Then
                filter.Add(("agarulmonth_1:=" + agarulmonth_1.Value.ToString()))
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
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
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
                    ByVal agarulyear_1 As Nullable(Of Single),  _
                    ByVal agarulmonth_1 As Nullable(Of Single),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.schApplication)
            Dim request As PageRequest = CreateRequest(applicationCodeauto, schtrnsid, schtrnsschtrnsDesc, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, applicationDate, studentCode, studentSchstCivilidnumber, civilidst, fathername, cntry_No, cntry_Cntry_Nm, dateofBirth, genderid, genderGender, stageAppliedto, stageAppliedtoShortDesc1, gradeApplied, gradeAppliedShortDesc1, gradeAppliedacdAcademicYear, gradeAppliedacdGlFinperiodFin_period_info, gradeAppliedStageShortDesc1, academicYearto, academicYeartoAcademicYear, academicYeartoGlFinperiodFin_period_info, academicYeartoGlFinperiodaccountnumberAcc_Nm, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, id, theidname_1, currentSchool, remarks, fathertel, fathertel2, passfail, fatherjob, fatheraddress, fathertel3, fatheremail, ageyear, agemonth, ageday, homephone, printed, birthDocNo, birthdocdate, birthDocPlace, birthPlace, residencenumber, residenceExpDate, schsthlthcaseid, schsthlthcaseschsthlthcaseDesc, cntry_No1, cntry_No1Cntry_Nm, cntry_No2, cntry_No2Cntry_Nm, state, stateState_Nm, area, areaDesc1, blockno, streetno, gadah, houseno, emergencyTelNo1, mothercase, mothercasejob_desc, fathercase, fathercasejob_desc, socialstatus, socialstatusschsocialstatuscaseDesc, studentsefa, studentsefastudentsefaar, studentsefadebitaccountAcc_Nm, studentsefadebitaccountClsacc_Acc_Nm, studentsefadebitaccountAcc_BndAcc_Nm, schclasskindid, schclasskindSchclasskinddesc, schstclasskinddmgid, schstclasskinddmgschstclasskinddmgDesc, schtransferid, schtransferSchtransferDesc, classorder, modifiedBy, modifiedOn, createdBy, createdOn, calssserial, agarulyear, agarulmonth, dateofcalculate, agarulyearmax, agarulmonthmax, studentBalance1, studentnotes, paidrosom, fatherrecord, parentsrelation, theparentsrelationparentsrelationdesc, schstEmail, fatherCode, motherCode, religion, civilidExpDate, bookRecive, agarulyear_1, agarulmonth_1, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schApplication", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schApplication)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.schApplication) As List(Of eZee.Data.Objects.schApplication)
            Return [Select](qbe.ApplicationCodeauto, qbe.schtrnsid, qbe.schtrnsschtrnsDesc, qbe.branch, qbe.ThebranchDesc1, qbe.Thebranchsgmsgm_Nm, qbe.ThebranchsgmOpcoOpcoName, qbe.ThebranchGenderGender, qbe.ThebranchstageShortDesc1, qbe.ThebranchschtypschtypDesc, qbe.ApplicationDate, qbe.StudentCode, qbe.StudentSchstCivilidnumber, qbe.civilidst, qbe.Fathername, qbe.Cntry_No, qbe.Cntry_Cntry_Nm, qbe.DateofBirth, qbe.Genderid, qbe.GenderGender, qbe.StageAppliedto, qbe.StageAppliedtoShortDesc1, qbe.GradeApplied, qbe.GradeAppliedShortDesc1, qbe.GradeAppliedacdAcademicYear, qbe.GradeAppliedacdGlFinperiodFin_period_info, qbe.GradeAppliedStageShortDesc1, qbe.AcademicYearto, qbe.AcademicYeartoAcademicYear, qbe.AcademicYeartoGlFinperiodFin_period_info, qbe.AcademicYeartoGlFinperiodaccountnumberAcc_Nm, qbe.Class, qbe.ClassClassDesc1, qbe.schstatus_code, qbe.schstatus_schstatus_name, qbe.schstudenttypid, qbe.schstudenttypschstudenttyp, qbe.id, qbe.Theidname_1, qbe.CurrentSchool, qbe.Remarks, qbe.Fathertel, qbe.Fathertel2, qbe.passfail, qbe.fatherjob, qbe.fatheraddress, qbe.fathertel3, qbe.fatheremail, qbe.ageyear, qbe.agemonth, qbe.ageday, qbe.homephone, qbe.printed, qbe.BirthDocNo, qbe.birthdocdate, qbe.BirthDocPlace, qbe.BirthPlace, qbe.Residencenumber, qbe.ResidenceExpDate, qbe.schsthlthcaseid, qbe.schsthlthcaseschsthlthcaseDesc, qbe.Cntry_No1, qbe.Cntry_No1Cntry_Nm, qbe.Cntry_No2, qbe.Cntry_No2Cntry_Nm, qbe.state, qbe.stateState_Nm, qbe.area, qbe.areaDesc1, qbe.blockno, qbe.streetno, qbe.gadah, qbe.houseno, qbe.EmergencyTelNo1, qbe.mothercase, qbe.mothercasejob_desc, qbe.fathercase, qbe.fathercasejob_desc, qbe.socialstatus, qbe.socialstatusschsocialstatuscaseDesc, qbe.studentsefa, qbe.studentsefastudentsefaar, qbe.studentsefadebitaccountAcc_Nm, qbe.studentsefadebitaccountClsacc_Acc_Nm, qbe.studentsefadebitaccountAcc_BndAcc_Nm, qbe.Schclasskindid, qbe.SchclasskindSchclasskinddesc, qbe.schstclasskinddmgid, qbe.schstclasskinddmgschstclasskinddmgDesc, qbe.Schtransferid, qbe.SchtransferSchtransferDesc, qbe.classorder, qbe.ModifiedBy, qbe.ModifiedOn, qbe.CreatedBy, qbe.CreatedOn, qbe.calssserial, qbe.agarulyear, qbe.agarulmonth, qbe.dateofcalculate, qbe.agarulyearmax, qbe.agarulmonthmax, qbe.studentBalance1, qbe.studentnotes, qbe.paidrosom, qbe.fatherrecord, qbe.parentsrelation, qbe.Theparentsrelationparentsrelationdesc, qbe.schstEmail, qbe.FatherCode, qbe.MotherCode, qbe.Religion, qbe.CivilidExpDate, qbe.BookRecive, qbe.agarulyear_1, qbe.agarulmonth_1)
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
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
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
                    ByVal agarulyear_1 As Nullable(Of Single),  _
                    ByVal agarulmonth_1 As Nullable(Of Single),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(applicationCodeauto, schtrnsid, schtrnsschtrnsDesc, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, applicationDate, studentCode, studentSchstCivilidnumber, civilidst, fathername, cntry_No, cntry_Cntry_Nm, dateofBirth, genderid, genderGender, stageAppliedto, stageAppliedtoShortDesc1, gradeApplied, gradeAppliedShortDesc1, gradeAppliedacdAcademicYear, gradeAppliedacdGlFinperiodFin_period_info, gradeAppliedStageShortDesc1, academicYearto, academicYeartoAcademicYear, academicYeartoGlFinperiodFin_period_info, academicYeartoGlFinperiodaccountnumberAcc_Nm, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, id, theidname_1, currentSchool, remarks, fathertel, fathertel2, passfail, fatherjob, fatheraddress, fathertel3, fatheremail, ageyear, agemonth, ageday, homephone, printed, birthDocNo, birthdocdate, birthDocPlace, birthPlace, residencenumber, residenceExpDate, schsthlthcaseid, schsthlthcaseschsthlthcaseDesc, cntry_No1, cntry_No1Cntry_Nm, cntry_No2, cntry_No2Cntry_Nm, state, stateState_Nm, area, areaDesc1, blockno, streetno, gadah, houseno, emergencyTelNo1, mothercase, mothercasejob_desc, fathercase, fathercasejob_desc, socialstatus, socialstatusschsocialstatuscaseDesc, studentsefa, studentsefastudentsefaar, studentsefadebitaccountAcc_Nm, studentsefadebitaccountClsacc_Acc_Nm, studentsefadebitaccountAcc_BndAcc_Nm, schclasskindid, schclasskindSchclasskinddesc, schstclasskinddmgid, schstclasskinddmgschstclasskinddmgDesc, schtransferid, schtransferSchtransferDesc, classorder, modifiedBy, modifiedOn, createdBy, createdOn, calssserial, agarulyear, agarulmonth, dateofcalculate, agarulyearmax, agarulmonthmax, studentBalance1, studentnotes, paidrosom, fatherrecord, parentsrelation, theparentsrelationparentsrelationdesc, schstEmail, fatherCode, motherCode, religion, civilidExpDate, bookRecive, agarulyear_1, agarulmonth_1, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schApplication", dataView, request)
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
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
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
                    ByVal agarulyear_1 As Nullable(Of Single),  _
                    ByVal agarulmonth_1 As Nullable(Of Single)) As List(Of eZee.Data.Objects.schApplication)
            Return [Select](applicationCodeauto, schtrnsid, schtrnsschtrnsDesc, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, applicationDate, studentCode, studentSchstCivilidnumber, civilidst, fathername, cntry_No, cntry_Cntry_Nm, dateofBirth, genderid, genderGender, stageAppliedto, stageAppliedtoShortDesc1, gradeApplied, gradeAppliedShortDesc1, gradeAppliedacdAcademicYear, gradeAppliedacdGlFinperiodFin_period_info, gradeAppliedStageShortDesc1, academicYearto, academicYeartoAcademicYear, academicYeartoGlFinperiodFin_period_info, academicYeartoGlFinperiodaccountnumberAcc_Nm, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, id, theidname_1, currentSchool, remarks, fathertel, fathertel2, passfail, fatherjob, fatheraddress, fathertel3, fatheremail, ageyear, agemonth, ageday, homephone, printed, birthDocNo, birthdocdate, birthDocPlace, birthPlace, residencenumber, residenceExpDate, schsthlthcaseid, schsthlthcaseschsthlthcaseDesc, cntry_No1, cntry_No1Cntry_Nm, cntry_No2, cntry_No2Cntry_Nm, state, stateState_Nm, area, areaDesc1, blockno, streetno, gadah, houseno, emergencyTelNo1, mothercase, mothercasejob_desc, fathercase, fathercasejob_desc, socialstatus, socialstatusschsocialstatuscaseDesc, studentsefa, studentsefastudentsefaar, studentsefadebitaccountAcc_Nm, studentsefadebitaccountClsacc_Acc_Nm, studentsefadebitaccountAcc_BndAcc_Nm, schclasskindid, schclasskindSchclasskinddesc, schstclasskinddmgid, schstclasskinddmgschstclasskinddmgDesc, schtransferid, schtransferSchtransferDesc, classorder, modifiedBy, modifiedOn, createdBy, createdOn, calssserial, agarulyear, agarulmonth, dateofcalculate, agarulyearmax, agarulmonthmax, studentBalance1, studentnotes, paidrosom, fatherrecord, parentsrelation, theparentsrelationparentsrelationdesc, schstEmail, fatherCode, motherCode, religion, civilidExpDate, bookRecive, agarulyear_1, agarulmonth_1, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal applicationCodeauto As Nullable(Of Long)) As eZee.Data.Objects.schApplication
            Dim list As List(Of eZee.Data.Objects.schApplication) = [Select](applicationCodeauto, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schApplication)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("schApplication", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schApplication)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schApplication)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schApplication)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schApplication
            Dim list As List(Of eZee.Data.Objects.schApplication) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theschApplication As eZee.Data.Objects.schApplication, ByVal original_schApplication As eZee.Data.Objects.schApplication) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("ApplicationCodeauto", original_schApplication.ApplicationCodeauto, theschApplication.ApplicationCodeauto, true))
            values.Add(New FieldValue("schtrnsid", original_schApplication.schtrnsid, theschApplication.schtrnsid))
            values.Add(New FieldValue("schtrnsschtrnsDesc", original_schApplication.schtrnsschtrnsDesc, theschApplication.schtrnsschtrnsDesc, true))
            values.Add(New FieldValue("branch", original_schApplication.branch, theschApplication.branch))
            values.Add(New FieldValue("ThebranchDesc1", original_schApplication.ThebranchDesc1, theschApplication.ThebranchDesc1, true))
            values.Add(New FieldValue("Thebranchsgmsgm_Nm", original_schApplication.Thebranchsgmsgm_Nm, theschApplication.Thebranchsgmsgm_Nm, true))
            values.Add(New FieldValue("ThebranchsgmOpcoOpcoName", original_schApplication.ThebranchsgmOpcoOpcoName, theschApplication.ThebranchsgmOpcoOpcoName, true))
            values.Add(New FieldValue("ThebranchGenderGender", original_schApplication.ThebranchGenderGender, theschApplication.ThebranchGenderGender, true))
            values.Add(New FieldValue("ThebranchstageShortDesc1", original_schApplication.ThebranchstageShortDesc1, theschApplication.ThebranchstageShortDesc1, true))
            values.Add(New FieldValue("ThebranchschtypschtypDesc", original_schApplication.ThebranchschtypschtypDesc, theschApplication.ThebranchschtypschtypDesc, true))
            values.Add(New FieldValue("ApplicationDate", original_schApplication.ApplicationDate, theschApplication.ApplicationDate))
            values.Add(New FieldValue("StudentCode", original_schApplication.StudentCode, theschApplication.StudentCode))
            values.Add(New FieldValue("StudentSchstCivilidnumber", original_schApplication.StudentSchstCivilidnumber, theschApplication.StudentSchstCivilidnumber, true))
            values.Add(New FieldValue("civilidst", original_schApplication.civilidst, theschApplication.civilidst))
            values.Add(New FieldValue("studentfullname", original_schApplication.studentfullname, theschApplication.studentfullname))
            values.Add(New FieldValue("Fathername", original_schApplication.Fathername, theschApplication.Fathername))
            values.Add(New FieldValue("Cntry_No", original_schApplication.Cntry_No, theschApplication.Cntry_No))
            values.Add(New FieldValue("Cntry_Cntry_Nm", original_schApplication.Cntry_Cntry_Nm, theschApplication.Cntry_Cntry_Nm, true))
            values.Add(New FieldValue("DateofBirth", original_schApplication.DateofBirth, theschApplication.DateofBirth))
            values.Add(New FieldValue("Genderid", original_schApplication.Genderid, theschApplication.Genderid))
            values.Add(New FieldValue("GenderGender", original_schApplication.GenderGender, theschApplication.GenderGender, true))
            values.Add(New FieldValue("StageAppliedto", original_schApplication.StageAppliedto, theschApplication.StageAppliedto))
            values.Add(New FieldValue("StageAppliedtoShortDesc1", original_schApplication.StageAppliedtoShortDesc1, theschApplication.StageAppliedtoShortDesc1, true))
            values.Add(New FieldValue("GradeApplied", original_schApplication.GradeApplied, theschApplication.GradeApplied))
            values.Add(New FieldValue("GradeAppliedShortDesc1", original_schApplication.GradeAppliedShortDesc1, theschApplication.GradeAppliedShortDesc1, true))
            values.Add(New FieldValue("GradeAppliedacdAcademicYear", original_schApplication.GradeAppliedacdAcademicYear, theschApplication.GradeAppliedacdAcademicYear, true))
            values.Add(New FieldValue("GradeAppliedacdGlFinperiodFin_period_info", original_schApplication.GradeAppliedacdGlFinperiodFin_period_info, theschApplication.GradeAppliedacdGlFinperiodFin_period_info, true))
            values.Add(New FieldValue("GradeAppliedStageShortDesc1", original_schApplication.GradeAppliedStageShortDesc1, theschApplication.GradeAppliedStageShortDesc1, true))
            values.Add(New FieldValue("AcademicYearto", original_schApplication.AcademicYearto, theschApplication.AcademicYearto))
            values.Add(New FieldValue("AcademicYeartoAcademicYear", original_schApplication.AcademicYeartoAcademicYear, theschApplication.AcademicYeartoAcademicYear, true))
            values.Add(New FieldValue("AcademicYeartoGlFinperiodFin_period_info", original_schApplication.AcademicYeartoGlFinperiodFin_period_info, theschApplication.AcademicYeartoGlFinperiodFin_period_info, true))
            values.Add(New FieldValue("AcademicYeartoGlFinperiodaccountnumberAcc_Nm", original_schApplication.AcademicYeartoGlFinperiodaccountnumberAcc_Nm, theschApplication.AcademicYeartoGlFinperiodaccountnumberAcc_Nm, true))
            values.Add(New FieldValue("Class", original_schApplication.Class, theschApplication.Class))
            values.Add(New FieldValue("ClassClassDesc1", original_schApplication.ClassClassDesc1, theschApplication.ClassClassDesc1, true))
            values.Add(New FieldValue("schstatus_code", original_schApplication.schstatus_code, theschApplication.schstatus_code))
            values.Add(New FieldValue("schstatus_schstatus_name", original_schApplication.schstatus_schstatus_name, theschApplication.schstatus_schstatus_name, true))
            values.Add(New FieldValue("schstudenttypid", original_schApplication.schstudenttypid, theschApplication.schstudenttypid))
            values.Add(New FieldValue("schstudenttypschstudenttyp", original_schApplication.schstudenttypschstudenttyp, theschApplication.schstudenttypschstudenttyp, true))
            values.Add(New FieldValue("id", original_schApplication.id, theschApplication.id))
            values.Add(New FieldValue("Theidname_1", original_schApplication.Theidname_1, theschApplication.Theidname_1, true))
            values.Add(New FieldValue("CurrentSchool", original_schApplication.CurrentSchool, theschApplication.CurrentSchool))
            values.Add(New FieldValue("Remarks", original_schApplication.Remarks, theschApplication.Remarks))
            values.Add(New FieldValue("Fathertel", original_schApplication.Fathertel, theschApplication.Fathertel))
            values.Add(New FieldValue("Fathertel2", original_schApplication.Fathertel2, theschApplication.Fathertel2))
            values.Add(New FieldValue("passfail", original_schApplication.passfail, theschApplication.passfail))
            values.Add(New FieldValue("fromout", original_schApplication.fromout, theschApplication.fromout))
            values.Add(New FieldValue("fatherjob", original_schApplication.fatherjob, theschApplication.fatherjob))
            values.Add(New FieldValue("fatheraddress", original_schApplication.fatheraddress, theschApplication.fatheraddress))
            values.Add(New FieldValue("fathertel3", original_schApplication.fathertel3, theschApplication.fathertel3))
            values.Add(New FieldValue("fatheremail", original_schApplication.fatheremail, theschApplication.fatheremail))
            values.Add(New FieldValue("ageyear", original_schApplication.ageyear, theschApplication.ageyear))
            values.Add(New FieldValue("agemonth", original_schApplication.agemonth, theschApplication.agemonth))
            values.Add(New FieldValue("ageday", original_schApplication.ageday, theschApplication.ageday))
            values.Add(New FieldValue("homephone", original_schApplication.homephone, theschApplication.homephone))
            values.Add(New FieldValue("printed", original_schApplication.printed, theschApplication.printed))
            values.Add(New FieldValue("BirthDocNo", original_schApplication.BirthDocNo, theschApplication.BirthDocNo))
            values.Add(New FieldValue("birthdocdate", original_schApplication.birthdocdate, theschApplication.birthdocdate))
            values.Add(New FieldValue("BirthDocPlace", original_schApplication.BirthDocPlace, theschApplication.BirthDocPlace))
            values.Add(New FieldValue("BirthPlace", original_schApplication.BirthPlace, theschApplication.BirthPlace))
            values.Add(New FieldValue("Residencenumber", original_schApplication.Residencenumber, theschApplication.Residencenumber))
            values.Add(New FieldValue("ResidenceExpDate", original_schApplication.ResidenceExpDate, theschApplication.ResidenceExpDate))
            values.Add(New FieldValue("schsthlthcaseid", original_schApplication.schsthlthcaseid, theschApplication.schsthlthcaseid))
            values.Add(New FieldValue("schsthlthcaseschsthlthcaseDesc", original_schApplication.schsthlthcaseschsthlthcaseDesc, theschApplication.schsthlthcaseschsthlthcaseDesc, true))
            values.Add(New FieldValue("Cntry_No1", original_schApplication.Cntry_No1, theschApplication.Cntry_No1))
            values.Add(New FieldValue("Cntry_No1Cntry_Nm", original_schApplication.Cntry_No1Cntry_Nm, theschApplication.Cntry_No1Cntry_Nm, true))
            values.Add(New FieldValue("Cntry_No2", original_schApplication.Cntry_No2, theschApplication.Cntry_No2))
            values.Add(New FieldValue("Cntry_No2Cntry_Nm", original_schApplication.Cntry_No2Cntry_Nm, theschApplication.Cntry_No2Cntry_Nm, true))
            values.Add(New FieldValue("state", original_schApplication.state, theschApplication.state))
            values.Add(New FieldValue("stateState_Nm", original_schApplication.stateState_Nm, theschApplication.stateState_Nm, true))
            values.Add(New FieldValue("area", original_schApplication.area, theschApplication.area))
            values.Add(New FieldValue("areaDesc1", original_schApplication.areaDesc1, theschApplication.areaDesc1, true))
            values.Add(New FieldValue("blockno", original_schApplication.blockno, theschApplication.blockno))
            values.Add(New FieldValue("streetno", original_schApplication.streetno, theschApplication.streetno))
            values.Add(New FieldValue("gadah", original_schApplication.gadah, theschApplication.gadah))
            values.Add(New FieldValue("houseno", original_schApplication.houseno, theschApplication.houseno))
            values.Add(New FieldValue("addressdetail", original_schApplication.addressdetail, theschApplication.addressdetail))
            values.Add(New FieldValue("EmergencyTelNo1", original_schApplication.EmergencyTelNo1, theschApplication.EmergencyTelNo1))
            values.Add(New FieldValue("mothercase", original_schApplication.mothercase, theschApplication.mothercase))
            values.Add(New FieldValue("mothercasejob_desc", original_schApplication.mothercasejob_desc, theschApplication.mothercasejob_desc, true))
            values.Add(New FieldValue("fathercase", original_schApplication.fathercase, theschApplication.fathercase))
            values.Add(New FieldValue("fathercasejob_desc", original_schApplication.fathercasejob_desc, theschApplication.fathercasejob_desc, true))
            values.Add(New FieldValue("socialstatus", original_schApplication.socialstatus, theschApplication.socialstatus))
            values.Add(New FieldValue("socialstatusschsocialstatuscaseDesc", original_schApplication.socialstatusschsocialstatuscaseDesc, theschApplication.socialstatusschsocialstatuscaseDesc, true))
            values.Add(New FieldValue("studentsefa", original_schApplication.studentsefa, theschApplication.studentsefa))
            values.Add(New FieldValue("studentsefastudentsefaar", original_schApplication.studentsefastudentsefaar, theschApplication.studentsefastudentsefaar, true))
            values.Add(New FieldValue("studentsefadebitaccountAcc_Nm", original_schApplication.studentsefadebitaccountAcc_Nm, theschApplication.studentsefadebitaccountAcc_Nm, true))
            values.Add(New FieldValue("studentsefadebitaccountClsacc_Acc_Nm", original_schApplication.studentsefadebitaccountClsacc_Acc_Nm, theschApplication.studentsefadebitaccountClsacc_Acc_Nm, true))
            values.Add(New FieldValue("studentsefadebitaccountAcc_BndAcc_Nm", original_schApplication.studentsefadebitaccountAcc_BndAcc_Nm, theschApplication.studentsefadebitaccountAcc_BndAcc_Nm, true))
            values.Add(New FieldValue("Schclasskindid", original_schApplication.Schclasskindid, theschApplication.Schclasskindid))
            values.Add(New FieldValue("SchclasskindSchclasskinddesc", original_schApplication.SchclasskindSchclasskinddesc, theschApplication.SchclasskindSchclasskinddesc, true))
            values.Add(New FieldValue("schstclasskinddmgid", original_schApplication.schstclasskinddmgid, theschApplication.schstclasskinddmgid))
            values.Add(New FieldValue("schstclasskinddmgschstclasskinddmgDesc", original_schApplication.schstclasskinddmgschstclasskinddmgDesc, theschApplication.schstclasskinddmgschstclasskinddmgDesc, true))
            values.Add(New FieldValue("Schtransferid", original_schApplication.Schtransferid, theschApplication.Schtransferid))
            values.Add(New FieldValue("SchtransferSchtransferDesc", original_schApplication.SchtransferSchtransferDesc, theschApplication.SchtransferSchtransferDesc, true))
            values.Add(New FieldValue("classorder", original_schApplication.classorder, theschApplication.classorder))
            values.Add(New FieldValue("ModifiedBy", original_schApplication.ModifiedBy, theschApplication.ModifiedBy))
            values.Add(New FieldValue("ModifiedOn", original_schApplication.ModifiedOn, theschApplication.ModifiedOn))
            values.Add(New FieldValue("CreatedBy", original_schApplication.CreatedBy, theschApplication.CreatedBy))
            values.Add(New FieldValue("CreatedOn", original_schApplication.CreatedOn, theschApplication.CreatedOn))
            values.Add(New FieldValue("calssserial", original_schApplication.calssserial, theschApplication.calssserial))
            values.Add(New FieldValue("agarulyear", original_schApplication.agarulyear, theschApplication.agarulyear, true))
            values.Add(New FieldValue("agarulmonth", original_schApplication.agarulmonth, theschApplication.agarulmonth))
            values.Add(New FieldValue("dateofcalculate", original_schApplication.dateofcalculate, theschApplication.dateofcalculate))
            values.Add(New FieldValue("agarulyearmax", original_schApplication.agarulyearmax, theschApplication.agarulyearmax))
            values.Add(New FieldValue("agarulmonthmax", original_schApplication.agarulmonthmax, theschApplication.agarulmonthmax))
            values.Add(New FieldValue("studentBalance1", original_schApplication.studentBalance1, theschApplication.studentBalance1))
            values.Add(New FieldValue("studentnotes", original_schApplication.studentnotes, theschApplication.studentnotes))
            values.Add(New FieldValue("paidrosom", original_schApplication.paidrosom, theschApplication.paidrosom))
            values.Add(New FieldValue("fatherrecord", original_schApplication.fatherrecord, theschApplication.fatherrecord))
            values.Add(New FieldValue("studentfullname1", original_schApplication.studentfullname1, theschApplication.studentfullname1))
            values.Add(New FieldValue("parentsrelation", original_schApplication.parentsrelation, theschApplication.parentsrelation))
            values.Add(New FieldValue("Theparentsrelationparentsrelationdesc", original_schApplication.Theparentsrelationparentsrelationdesc, theschApplication.Theparentsrelationparentsrelationdesc, true))
            values.Add(New FieldValue("EncryptedNationalIDNumber", original_schApplication.EncryptedNationalIDNumber, theschApplication.EncryptedNationalIDNumber))
            values.Add(New FieldValue("resigncases", original_schApplication.resigncases, theschApplication.resigncases))
            values.Add(New FieldValue("schstEmail", original_schApplication.schstEmail, theschApplication.schstEmail))
            values.Add(New FieldValue("FatherCode", original_schApplication.FatherCode, theschApplication.FatherCode))
            values.Add(New FieldValue("MotherCode", original_schApplication.MotherCode, theschApplication.MotherCode))
            values.Add(New FieldValue("Religion", original_schApplication.Religion, theschApplication.Religion))
            values.Add(New FieldValue("Notes", original_schApplication.Notes, theschApplication.Notes))
            values.Add(New FieldValue("CivilidExpDate", original_schApplication.CivilidExpDate, theschApplication.CivilidExpDate))
            values.Add(New FieldValue("BookRecive", original_schApplication.BookRecive, theschApplication.BookRecive))
            values.Add(New FieldValue("agarulyear_1", original_schApplication.agarulyear_1, theschApplication.agarulyear_1, true))
            values.Add(New FieldValue("agarulmonth_1", original_schApplication.agarulmonth_1, theschApplication.agarulmonth_1, true))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theschApplication As eZee.Data.Objects.schApplication, ByVal original_schApplication As eZee.Data.Objects.schApplication, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "schApplication"
            args.View = dataView
            args.Values = CreateFieldValues(theschApplication, original_schApplication)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("schApplication", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theschApplication)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theschApplication As eZee.Data.Objects.schApplication, ByVal original_schApplication As eZee.Data.Objects.schApplication) As Integer
            Return ExecuteAction(theschApplication, original_schApplication, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theschApplication As eZee.Data.Objects.schApplication) As Integer
            Return Update(theschApplication, SelectSingle(theschApplication.ApplicationCodeauto))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theschApplication As eZee.Data.Objects.schApplication) As Integer
            Return ExecuteAction(theschApplication, New schApplication(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theschApplication As eZee.Data.Objects.schApplication) As Integer
            Return ExecuteAction(theschApplication, theschApplication, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
