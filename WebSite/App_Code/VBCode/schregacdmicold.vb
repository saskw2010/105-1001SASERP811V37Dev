Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class schregacdmicold
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Regacdmic As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Transdate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Acdcode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcdAcademicYear As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcdGlFinperiodFin_period_info As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcdGlFinperiodaccountnumberAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schtrnsid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchtrnsschtrnsDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentSchstCivilidnumber As String
        
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
        Private m_Stage As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StageShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeacdAcademicYear As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeacdGlFinperiodFin_period_info As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeStageShortDesc1 As String
        
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
        Private m_Gadah As Nullable(Of Long)
        
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
        Private m_Id As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Theidname_1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schsthlthcaseid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchsthlthcaseschsthlthcaseDesc As String
        
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
        Private m_Resigncases As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schclasskindid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstclasskinddmgid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schtransferid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Joindate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Classorder As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Scucessflag As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Approved As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedOn As Nullable(Of DateTime)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, false, false)>  _
        Public Property regacdmic() As Nullable(Of Long)
            Get
                Return m_Regacdmic
            End Get
            Set
                m_Regacdmic = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property transdate() As Nullable(Of DateTime)
            Get
                Return m_Transdate
            End Get
            Set
                m_Transdate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property acdcode() As Nullable(Of Long)
            Get
                Return m_Acdcode
            End Get
            Set
                m_Acdcode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property acdAcademicYear() As String
            Get
                Return m_AcdAcademicYear
            End Get
            Set
                m_AcdAcademicYear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property acdGlFinperiodFin_period_info() As String
            Get
                Return m_AcdGlFinperiodFin_period_info
            End Get
            Set
                m_AcdGlFinperiodFin_period_info = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property acdGlFinperiodaccountnumberAcc_Nm() As String
            Get
                Return m_AcdGlFinperiodaccountnumberAcc_Nm
            End Get
            Set
                m_AcdGlFinperiodaccountnumberAcc_Nm = value
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
        Public Property Stage() As Nullable(Of Long)
            Get
                Return m_Stage
            End Get
            Set
                m_Stage = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property StageShortDesc1() As String
            Get
                Return m_StageShortDesc1
            End Get
            Set
                m_StageShortDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property GradeCode() As Nullable(Of Long)
            Get
                Return m_GradeCode
            End Get
            Set
                m_GradeCode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeShortDesc1() As String
            Get
                Return m_GradeShortDesc1
            End Get
            Set
                m_GradeShortDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeacdAcademicYear() As String
            Get
                Return m_GradeacdAcademicYear
            End Get
            Set
                m_GradeacdAcademicYear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeacdGlFinperiodFin_period_info() As String
            Get
                Return m_GradeacdGlFinperiodFin_period_info
            End Get
            Set
                m_GradeacdGlFinperiodFin_period_info = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GradeStageShortDesc1() As String
            Get
                Return m_GradeStageShortDesc1
            End Get
            Set
                m_GradeStageShortDesc1 = value
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
        Public Property gadah() As Nullable(Of Long)
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
        Public Property resigncases() As String
            Get
                Return m_Resigncases
            End Get
            Set
                m_Resigncases = value
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
        Public Property schstclasskinddmgid() As Nullable(Of Long)
            Get
                Return m_Schstclasskinddmgid
            End Get
            Set
                m_Schstclasskinddmgid = value
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
        Public Property joindate() As Nullable(Of DateTime)
            Get
                Return m_Joindate
            End Get
            Set
                m_Joindate = value
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
        Public Property scucessflag() As Nullable(Of Boolean)
            Get
                Return m_Scucessflag
            End Get
            Set
                m_Scucessflag = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property approved() As Nullable(Of Boolean)
            Get
                Return m_Approved
            End Get
            Set
                m_Approved = value
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
        
        Public Overloads Shared Function [Select]( _
                    ByVal regacdmic As Nullable(Of Long),  _
                    ByVal transdate As Nullable(Of DateTime),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal gradeacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeStageShortDesc1 As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstatus_schstatus_name As String,  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal schstudenttypschstudenttyp As String,  _
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
                    ByVal gadah As Nullable(Of Long),  _
                    ByVal houseno As String,  _
                    ByVal emergencyTelNo1 As String,  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal mothercasejob_desc As String,  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal fathercasejob_desc As String,  _
                    ByVal socialstatus As Nullable(Of Long),  _
                    ByVal socialstatusschsocialstatuscaseDesc As String,  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal theidname_1 As String,  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal schsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal studentsefastudentsefaar As String,  _
                    ByVal studentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentsefadebitaccountClsacc_Acc_Nm As String,  _
                    ByVal studentsefadebitaccountAcc_BndAcc_Nm As String,  _
                    ByVal resigncases As String,  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal joindate As Nullable(Of DateTime),  _
                    ByVal classorder As Nullable(Of Long),  _
                    ByVal scucessflag As Nullable(Of Boolean),  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime)) As List(Of eZee.Data.Objects.schregacdmicold)
            Return New schregacdmicoldFactory().Select(regacdmic, transdate, acdcode, acdAcademicYear, acdGlFinperiodFin_period_info, acdGlFinperiodaccountnumberAcc_Nm, schtrnsid, schtrnsschtrnsDesc, studentCode, studentSchstCivilidnumber, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, stage, stageShortDesc1, gradeCode, gradeShortDesc1, gradeacdAcademicYear, gradeacdGlFinperiodFin_period_info, gradeStageShortDesc1, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, cntry_No1, cntry_No1Cntry_Nm, cntry_No2, cntry_No2Cntry_Nm, state, stateState_Nm, area, areaDesc1, blockno, streetno, gadah, houseno, emergencyTelNo1, mothercase, mothercasejob_desc, fathercase, fathercasejob_desc, socialstatus, socialstatusschsocialstatuscaseDesc, id, theidname_1, schsthlthcaseid, schsthlthcaseschsthlthcaseDesc, studentsefa, studentsefastudentsefaar, studentsefadebitaccountAcc_Nm, studentsefadebitaccountClsacc_Acc_Nm, studentsefadebitaccountAcc_BndAcc_Nm, resigncases, schclasskindid, schstclasskinddmgid, schtransferid, joindate, classorder, scucessflag, approved, modifiedBy, modifiedOn, createdBy, createdOn)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.schregacdmicold) As List(Of eZee.Data.Objects.schregacdmicold)
            Return New schregacdmicoldFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicold)
            Return New schregacdmicoldFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregacdmicold)
            Return New schregacdmicoldFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicold)
            Return New schregacdmicoldFactory().Select(filter, sort, schregacdmicoldFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregacdmicold)
            Return New schregacdmicoldFactory().Select(filter, sort, schregacdmicoldFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicold)
            Return New schregacdmicoldFactory().Select(filter, Nothing, schregacdmicoldFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregacdmicold)
            Return New schregacdmicoldFactory().Select(filter, Nothing, schregacdmicoldFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schregacdmicold
            Return New schregacdmicoldFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.schregacdmicold
            Return New schregacdmicoldFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal regacdmic As Nullable(Of Long)) As eZee.Data.Objects.schregacdmicold
            Return New schregacdmicoldFactory().SelectSingle(regacdmic)
        End Function
        
        Public Function Insert() As Integer
            Return New schregacdmicoldFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New schregacdmicoldFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New schregacdmicoldFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("regacdmic: {0}", Me.regacdmic)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class schregacdmicoldFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("schregacdmicold")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("schregacdmicold")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("schregacdmicold")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("schregacdmicold")
            End Get
        End Property
        
        Public Shared Function Create() As schregacdmicoldFactory
            Return New schregacdmicoldFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal regacdmic As Nullable(Of Long),  _
                    ByVal transdate As Nullable(Of DateTime),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal gradeacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeStageShortDesc1 As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstatus_schstatus_name As String,  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal schstudenttypschstudenttyp As String,  _
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
                    ByVal gadah As Nullable(Of Long),  _
                    ByVal houseno As String,  _
                    ByVal emergencyTelNo1 As String,  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal mothercasejob_desc As String,  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal fathercasejob_desc As String,  _
                    ByVal socialstatus As Nullable(Of Long),  _
                    ByVal socialstatusschsocialstatuscaseDesc As String,  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal theidname_1 As String,  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal schsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal studentsefastudentsefaar As String,  _
                    ByVal studentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentsefadebitaccountClsacc_Acc_Nm As String,  _
                    ByVal studentsefadebitaccountAcc_BndAcc_Nm As String,  _
                    ByVal resigncases As String,  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal joindate As Nullable(Of DateTime),  _
                    ByVal classorder As Nullable(Of Long),  _
                    ByVal scucessflag As Nullable(Of Boolean),  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If regacdmic.HasValue Then
                filter.Add(("regacdmic:=" + regacdmic.Value.ToString()))
            End If
            If transdate.HasValue Then
                filter.Add(("transdate:=" + transdate.Value.ToString()))
            End If
            If acdcode.HasValue Then
                filter.Add(("acdcode:=" + acdcode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(acdAcademicYear)) Then
                filter.Add(("acdAcademicYear:*" + acdAcademicYear))
            End If
            If Not (String.IsNullOrEmpty(acdGlFinperiodFin_period_info)) Then
                filter.Add(("acdGlFinperiodFin_period_info:*" + acdGlFinperiodFin_period_info))
            End If
            If Not (String.IsNullOrEmpty(acdGlFinperiodaccountnumberAcc_Nm)) Then
                filter.Add(("acdGlFinperiodaccountnumberAcc_Nm:*" + acdGlFinperiodaccountnumberAcc_Nm))
            End If
            If schtrnsid.HasValue Then
                filter.Add(("schtrnsid:=" + schtrnsid.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schtrnsschtrnsDesc)) Then
                filter.Add(("schtrnsschtrnsDesc:*" + schtrnsschtrnsDesc))
            End If
            If studentCode.HasValue Then
                filter.Add(("StudentCode:=" + studentCode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(studentSchstCivilidnumber)) Then
                filter.Add(("StudentSchstCivilidnumber:*" + studentSchstCivilidnumber))
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
            If stage.HasValue Then
                filter.Add(("Stage:=" + stage.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(stageShortDesc1)) Then
                filter.Add(("StageShortDesc1:*" + stageShortDesc1))
            End If
            If gradeCode.HasValue Then
                filter.Add(("GradeCode:=" + gradeCode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(gradeShortDesc1)) Then
                filter.Add(("GradeShortDesc1:*" + gradeShortDesc1))
            End If
            If Not (String.IsNullOrEmpty(gradeacdAcademicYear)) Then
                filter.Add(("GradeacdAcademicYear:*" + gradeacdAcademicYear))
            End If
            If Not (String.IsNullOrEmpty(gradeacdGlFinperiodFin_period_info)) Then
                filter.Add(("GradeacdGlFinperiodFin_period_info:*" + gradeacdGlFinperiodFin_period_info))
            End If
            If Not (String.IsNullOrEmpty(gradeStageShortDesc1)) Then
                filter.Add(("GradeStageShortDesc1:*" + gradeStageShortDesc1))
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
            If gadah.HasValue Then
                filter.Add(("gadah:=" + gadah.Value.ToString()))
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
            If id.HasValue Then
                filter.Add(("id:=" + id.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(theidname_1)) Then
                filter.Add(("Theidname_1:*" + theidname_1))
            End If
            If schsthlthcaseid.HasValue Then
                filter.Add(("schsthlthcaseid:=" + schsthlthcaseid.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schsthlthcaseschsthlthcaseDesc)) Then
                filter.Add(("schsthlthcaseschsthlthcaseDesc:*" + schsthlthcaseschsthlthcaseDesc))
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
            If Not (String.IsNullOrEmpty(resigncases)) Then
                filter.Add(("resigncases:*" + resigncases))
            End If
            If schclasskindid.HasValue Then
                filter.Add(("Schclasskindid:=" + schclasskindid.Value.ToString()))
            End If
            If schstclasskinddmgid.HasValue Then
                filter.Add(("schstclasskinddmgid:=" + schstclasskinddmgid.Value.ToString()))
            End If
            If schtransferid.HasValue Then
                filter.Add(("Schtransferid:=" + schtransferid.Value.ToString()))
            End If
            If joindate.HasValue Then
                filter.Add(("joindate:=" + joindate.Value.ToString()))
            End If
            If classorder.HasValue Then
                filter.Add(("classorder:=" + classorder.Value.ToString()))
            End If
            If scucessflag.HasValue Then
                filter.Add(("scucessflag:=" + scucessflag.Value.ToString()))
            End If
            If approved.HasValue Then
                filter.Add(("approved:=" + approved.Value.ToString()))
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
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal regacdmic As Nullable(Of Long),  _
                    ByVal transdate As Nullable(Of DateTime),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal gradeacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeStageShortDesc1 As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstatus_schstatus_name As String,  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal schstudenttypschstudenttyp As String,  _
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
                    ByVal gadah As Nullable(Of Long),  _
                    ByVal houseno As String,  _
                    ByVal emergencyTelNo1 As String,  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal mothercasejob_desc As String,  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal fathercasejob_desc As String,  _
                    ByVal socialstatus As Nullable(Of Long),  _
                    ByVal socialstatusschsocialstatuscaseDesc As String,  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal theidname_1 As String,  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal schsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal studentsefastudentsefaar As String,  _
                    ByVal studentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentsefadebitaccountClsacc_Acc_Nm As String,  _
                    ByVal studentsefadebitaccountAcc_BndAcc_Nm As String,  _
                    ByVal resigncases As String,  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal joindate As Nullable(Of DateTime),  _
                    ByVal classorder As Nullable(Of Long),  _
                    ByVal scucessflag As Nullable(Of Boolean),  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.schregacdmicold)
            Dim request As PageRequest = CreateRequest(regacdmic, transdate, acdcode, acdAcademicYear, acdGlFinperiodFin_period_info, acdGlFinperiodaccountnumberAcc_Nm, schtrnsid, schtrnsschtrnsDesc, studentCode, studentSchstCivilidnumber, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, stage, stageShortDesc1, gradeCode, gradeShortDesc1, gradeacdAcademicYear, gradeacdGlFinperiodFin_period_info, gradeStageShortDesc1, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, cntry_No1, cntry_No1Cntry_Nm, cntry_No2, cntry_No2Cntry_Nm, state, stateState_Nm, area, areaDesc1, blockno, streetno, gadah, houseno, emergencyTelNo1, mothercase, mothercasejob_desc, fathercase, fathercasejob_desc, socialstatus, socialstatusschsocialstatuscaseDesc, id, theidname_1, schsthlthcaseid, schsthlthcaseschsthlthcaseDesc, studentsefa, studentsefastudentsefaar, studentsefadebitaccountAcc_Nm, studentsefadebitaccountClsacc_Acc_Nm, studentsefadebitaccountAcc_BndAcc_Nm, resigncases, schclasskindid, schstclasskinddmgid, schtransferid, joindate, classorder, scucessflag, approved, modifiedBy, modifiedOn, createdBy, createdOn, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schregacdmicold", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schregacdmicold)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.schregacdmicold) As List(Of eZee.Data.Objects.schregacdmicold)
            Return [Select](qbe.regacdmic, qbe.transdate, qbe.acdcode, qbe.acdAcademicYear, qbe.acdGlFinperiodFin_period_info, qbe.acdGlFinperiodaccountnumberAcc_Nm, qbe.schtrnsid, qbe.schtrnsschtrnsDesc, qbe.StudentCode, qbe.StudentSchstCivilidnumber, qbe.branch, qbe.ThebranchDesc1, qbe.Thebranchsgmsgm_Nm, qbe.ThebranchsgmOpcoOpcoName, qbe.ThebranchGenderGender, qbe.ThebranchstageShortDesc1, qbe.ThebranchschtypschtypDesc, qbe.Stage, qbe.StageShortDesc1, qbe.GradeCode, qbe.GradeShortDesc1, qbe.GradeacdAcademicYear, qbe.GradeacdGlFinperiodFin_period_info, qbe.GradeStageShortDesc1, qbe.Class, qbe.ClassClassDesc1, qbe.schstatus_code, qbe.schstatus_schstatus_name, qbe.schstudenttypid, qbe.schstudenttypschstudenttyp, qbe.Cntry_No1, qbe.Cntry_No1Cntry_Nm, qbe.Cntry_No2, qbe.Cntry_No2Cntry_Nm, qbe.state, qbe.stateState_Nm, qbe.area, qbe.areaDesc1, qbe.blockno, qbe.streetno, qbe.gadah, qbe.houseno, qbe.EmergencyTelNo1, qbe.mothercase, qbe.mothercasejob_desc, qbe.fathercase, qbe.fathercasejob_desc, qbe.socialstatus, qbe.socialstatusschsocialstatuscaseDesc, qbe.id, qbe.Theidname_1, qbe.schsthlthcaseid, qbe.schsthlthcaseschsthlthcaseDesc, qbe.studentsefa, qbe.studentsefastudentsefaar, qbe.studentsefadebitaccountAcc_Nm, qbe.studentsefadebitaccountClsacc_Acc_Nm, qbe.studentsefadebitaccountAcc_BndAcc_Nm, qbe.resigncases, qbe.Schclasskindid, qbe.schstclasskinddmgid, qbe.Schtransferid, qbe.joindate, qbe.classorder, qbe.scucessflag, qbe.approved, qbe.ModifiedBy, qbe.ModifiedOn, qbe.CreatedBy, qbe.CreatedOn)
        End Function
        
        Public Function SelectCount( _
                    ByVal regacdmic As Nullable(Of Long),  _
                    ByVal transdate As Nullable(Of DateTime),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal gradeacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeStageShortDesc1 As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstatus_schstatus_name As String,  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal schstudenttypschstudenttyp As String,  _
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
                    ByVal gadah As Nullable(Of Long),  _
                    ByVal houseno As String,  _
                    ByVal emergencyTelNo1 As String,  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal mothercasejob_desc As String,  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal fathercasejob_desc As String,  _
                    ByVal socialstatus As Nullable(Of Long),  _
                    ByVal socialstatusschsocialstatuscaseDesc As String,  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal theidname_1 As String,  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal schsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal studentsefastudentsefaar As String,  _
                    ByVal studentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentsefadebitaccountClsacc_Acc_Nm As String,  _
                    ByVal studentsefadebitaccountAcc_BndAcc_Nm As String,  _
                    ByVal resigncases As String,  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal joindate As Nullable(Of DateTime),  _
                    ByVal classorder As Nullable(Of Long),  _
                    ByVal scucessflag As Nullable(Of Boolean),  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(regacdmic, transdate, acdcode, acdAcademicYear, acdGlFinperiodFin_period_info, acdGlFinperiodaccountnumberAcc_Nm, schtrnsid, schtrnsschtrnsDesc, studentCode, studentSchstCivilidnumber, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, stage, stageShortDesc1, gradeCode, gradeShortDesc1, gradeacdAcademicYear, gradeacdGlFinperiodFin_period_info, gradeStageShortDesc1, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, cntry_No1, cntry_No1Cntry_Nm, cntry_No2, cntry_No2Cntry_Nm, state, stateState_Nm, area, areaDesc1, blockno, streetno, gadah, houseno, emergencyTelNo1, mothercase, mothercasejob_desc, fathercase, fathercasejob_desc, socialstatus, socialstatusschsocialstatuscaseDesc, id, theidname_1, schsthlthcaseid, schsthlthcaseschsthlthcaseDesc, studentsefa, studentsefastudentsefaar, studentsefadebitaccountAcc_Nm, studentsefadebitaccountClsacc_Acc_Nm, studentsefadebitaccountAcc_BndAcc_Nm, resigncases, schclasskindid, schstclasskinddmgid, schtransferid, joindate, classorder, scucessflag, approved, modifiedBy, modifiedOn, createdBy, createdOn, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schregacdmicold", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal regacdmic As Nullable(Of Long),  _
                    ByVal transdate As Nullable(Of DateTime),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal gradeacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeStageShortDesc1 As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstatus_schstatus_name As String,  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal schstudenttypschstudenttyp As String,  _
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
                    ByVal gadah As Nullable(Of Long),  _
                    ByVal houseno As String,  _
                    ByVal emergencyTelNo1 As String,  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal mothercasejob_desc As String,  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal fathercasejob_desc As String,  _
                    ByVal socialstatus As Nullable(Of Long),  _
                    ByVal socialstatusschsocialstatuscaseDesc As String,  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal theidname_1 As String,  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal schsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal studentsefastudentsefaar As String,  _
                    ByVal studentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentsefadebitaccountClsacc_Acc_Nm As String,  _
                    ByVal studentsefadebitaccountAcc_BndAcc_Nm As String,  _
                    ByVal resigncases As String,  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal joindate As Nullable(Of DateTime),  _
                    ByVal classorder As Nullable(Of Long),  _
                    ByVal scucessflag As Nullable(Of Boolean),  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime)) As List(Of eZee.Data.Objects.schregacdmicold)
            Return [Select](regacdmic, transdate, acdcode, acdAcademicYear, acdGlFinperiodFin_period_info, acdGlFinperiodaccountnumberAcc_Nm, schtrnsid, schtrnsschtrnsDesc, studentCode, studentSchstCivilidnumber, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, stage, stageShortDesc1, gradeCode, gradeShortDesc1, gradeacdAcademicYear, gradeacdGlFinperiodFin_period_info, gradeStageShortDesc1, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, cntry_No1, cntry_No1Cntry_Nm, cntry_No2, cntry_No2Cntry_Nm, state, stateState_Nm, area, areaDesc1, blockno, streetno, gadah, houseno, emergencyTelNo1, mothercase, mothercasejob_desc, fathercase, fathercasejob_desc, socialstatus, socialstatusschsocialstatuscaseDesc, id, theidname_1, schsthlthcaseid, schsthlthcaseschsthlthcaseDesc, studentsefa, studentsefastudentsefaar, studentsefadebitaccountAcc_Nm, studentsefadebitaccountClsacc_Acc_Nm, studentsefadebitaccountAcc_BndAcc_Nm, resigncases, schclasskindid, schstclasskinddmgid, schtransferid, joindate, classorder, scucessflag, approved, modifiedBy, modifiedOn, createdBy, createdOn, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal regacdmic As Nullable(Of Long)) As eZee.Data.Objects.schregacdmicold
            Dim list As List(Of eZee.Data.Objects.schregacdmicold) = [Select](regacdmic, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicold)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("schregacdmicold", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schregacdmicold)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicold)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicold)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schregacdmicold
            Dim list As List(Of eZee.Data.Objects.schregacdmicold) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theschregacdmicold As eZee.Data.Objects.schregacdmicold, ByVal original_schregacdmicold As eZee.Data.Objects.schregacdmicold) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("regacdmic", original_schregacdmicold.regacdmic, theschregacdmicold.regacdmic))
            values.Add(New FieldValue("transdate", original_schregacdmicold.transdate, theschregacdmicold.transdate))
            values.Add(New FieldValue("acdcode", original_schregacdmicold.acdcode, theschregacdmicold.acdcode))
            values.Add(New FieldValue("acdAcademicYear", original_schregacdmicold.acdAcademicYear, theschregacdmicold.acdAcademicYear, true))
            values.Add(New FieldValue("acdGlFinperiodFin_period_info", original_schregacdmicold.acdGlFinperiodFin_period_info, theschregacdmicold.acdGlFinperiodFin_period_info, true))
            values.Add(New FieldValue("acdGlFinperiodaccountnumberAcc_Nm", original_schregacdmicold.acdGlFinperiodaccountnumberAcc_Nm, theschregacdmicold.acdGlFinperiodaccountnumberAcc_Nm, true))
            values.Add(New FieldValue("schtrnsid", original_schregacdmicold.schtrnsid, theschregacdmicold.schtrnsid))
            values.Add(New FieldValue("schtrnsschtrnsDesc", original_schregacdmicold.schtrnsschtrnsDesc, theschregacdmicold.schtrnsschtrnsDesc, true))
            values.Add(New FieldValue("StudentCode", original_schregacdmicold.StudentCode, theschregacdmicold.StudentCode))
            values.Add(New FieldValue("StudentSchstCivilidnumber", original_schregacdmicold.StudentSchstCivilidnumber, theschregacdmicold.StudentSchstCivilidnumber, true))
            values.Add(New FieldValue("branch", original_schregacdmicold.branch, theschregacdmicold.branch))
            values.Add(New FieldValue("ThebranchDesc1", original_schregacdmicold.ThebranchDesc1, theschregacdmicold.ThebranchDesc1, true))
            values.Add(New FieldValue("Thebranchsgmsgm_Nm", original_schregacdmicold.Thebranchsgmsgm_Nm, theschregacdmicold.Thebranchsgmsgm_Nm, true))
            values.Add(New FieldValue("ThebranchsgmOpcoOpcoName", original_schregacdmicold.ThebranchsgmOpcoOpcoName, theschregacdmicold.ThebranchsgmOpcoOpcoName, true))
            values.Add(New FieldValue("ThebranchGenderGender", original_schregacdmicold.ThebranchGenderGender, theschregacdmicold.ThebranchGenderGender, true))
            values.Add(New FieldValue("ThebranchstageShortDesc1", original_schregacdmicold.ThebranchstageShortDesc1, theschregacdmicold.ThebranchstageShortDesc1, true))
            values.Add(New FieldValue("ThebranchschtypschtypDesc", original_schregacdmicold.ThebranchschtypschtypDesc, theschregacdmicold.ThebranchschtypschtypDesc, true))
            values.Add(New FieldValue("Stage", original_schregacdmicold.Stage, theschregacdmicold.Stage))
            values.Add(New FieldValue("StageShortDesc1", original_schregacdmicold.StageShortDesc1, theschregacdmicold.StageShortDesc1, true))
            values.Add(New FieldValue("GradeCode", original_schregacdmicold.GradeCode, theschregacdmicold.GradeCode))
            values.Add(New FieldValue("GradeShortDesc1", original_schregacdmicold.GradeShortDesc1, theschregacdmicold.GradeShortDesc1, true))
            values.Add(New FieldValue("GradeacdAcademicYear", original_schregacdmicold.GradeacdAcademicYear, theschregacdmicold.GradeacdAcademicYear, true))
            values.Add(New FieldValue("GradeacdGlFinperiodFin_period_info", original_schregacdmicold.GradeacdGlFinperiodFin_period_info, theschregacdmicold.GradeacdGlFinperiodFin_period_info, true))
            values.Add(New FieldValue("GradeStageShortDesc1", original_schregacdmicold.GradeStageShortDesc1, theschregacdmicold.GradeStageShortDesc1, true))
            values.Add(New FieldValue("Class", original_schregacdmicold.Class, theschregacdmicold.Class))
            values.Add(New FieldValue("ClassClassDesc1", original_schregacdmicold.ClassClassDesc1, theschregacdmicold.ClassClassDesc1, true))
            values.Add(New FieldValue("schstatus_code", original_schregacdmicold.schstatus_code, theschregacdmicold.schstatus_code))
            values.Add(New FieldValue("schstatus_schstatus_name", original_schregacdmicold.schstatus_schstatus_name, theschregacdmicold.schstatus_schstatus_name, true))
            values.Add(New FieldValue("schstudenttypid", original_schregacdmicold.schstudenttypid, theschregacdmicold.schstudenttypid))
            values.Add(New FieldValue("schstudenttypschstudenttyp", original_schregacdmicold.schstudenttypschstudenttyp, theschregacdmicold.schstudenttypschstudenttyp, true))
            values.Add(New FieldValue("Cntry_No1", original_schregacdmicold.Cntry_No1, theschregacdmicold.Cntry_No1))
            values.Add(New FieldValue("Cntry_No1Cntry_Nm", original_schregacdmicold.Cntry_No1Cntry_Nm, theschregacdmicold.Cntry_No1Cntry_Nm, true))
            values.Add(New FieldValue("Cntry_No2", original_schregacdmicold.Cntry_No2, theschregacdmicold.Cntry_No2))
            values.Add(New FieldValue("Cntry_No2Cntry_Nm", original_schregacdmicold.Cntry_No2Cntry_Nm, theschregacdmicold.Cntry_No2Cntry_Nm, true))
            values.Add(New FieldValue("state", original_schregacdmicold.state, theschregacdmicold.state))
            values.Add(New FieldValue("stateState_Nm", original_schregacdmicold.stateState_Nm, theschregacdmicold.stateState_Nm, true))
            values.Add(New FieldValue("area", original_schregacdmicold.area, theschregacdmicold.area))
            values.Add(New FieldValue("areaDesc1", original_schregacdmicold.areaDesc1, theschregacdmicold.areaDesc1, true))
            values.Add(New FieldValue("blockno", original_schregacdmicold.blockno, theschregacdmicold.blockno))
            values.Add(New FieldValue("streetno", original_schregacdmicold.streetno, theschregacdmicold.streetno))
            values.Add(New FieldValue("gadah", original_schregacdmicold.gadah, theschregacdmicold.gadah))
            values.Add(New FieldValue("houseno", original_schregacdmicold.houseno, theschregacdmicold.houseno))
            values.Add(New FieldValue("addressdetail", original_schregacdmicold.addressdetail, theschregacdmicold.addressdetail))
            values.Add(New FieldValue("EmergencyTelNo1", original_schregacdmicold.EmergencyTelNo1, theschregacdmicold.EmergencyTelNo1))
            values.Add(New FieldValue("mothercase", original_schregacdmicold.mothercase, theschregacdmicold.mothercase))
            values.Add(New FieldValue("mothercasejob_desc", original_schregacdmicold.mothercasejob_desc, theschregacdmicold.mothercasejob_desc, true))
            values.Add(New FieldValue("fathercase", original_schregacdmicold.fathercase, theschregacdmicold.fathercase))
            values.Add(New FieldValue("fathercasejob_desc", original_schregacdmicold.fathercasejob_desc, theschregacdmicold.fathercasejob_desc, true))
            values.Add(New FieldValue("socialstatus", original_schregacdmicold.socialstatus, theschregacdmicold.socialstatus))
            values.Add(New FieldValue("socialstatusschsocialstatuscaseDesc", original_schregacdmicold.socialstatusschsocialstatuscaseDesc, theschregacdmicold.socialstatusschsocialstatuscaseDesc, true))
            values.Add(New FieldValue("id", original_schregacdmicold.id, theschregacdmicold.id))
            values.Add(New FieldValue("Theidname_1", original_schregacdmicold.Theidname_1, theschregacdmicold.Theidname_1, true))
            values.Add(New FieldValue("schsthlthcaseid", original_schregacdmicold.schsthlthcaseid, theschregacdmicold.schsthlthcaseid))
            values.Add(New FieldValue("schsthlthcaseschsthlthcaseDesc", original_schregacdmicold.schsthlthcaseschsthlthcaseDesc, theschregacdmicold.schsthlthcaseschsthlthcaseDesc, true))
            values.Add(New FieldValue("studentsefa", original_schregacdmicold.studentsefa, theschregacdmicold.studentsefa))
            values.Add(New FieldValue("studentsefastudentsefaar", original_schregacdmicold.studentsefastudentsefaar, theschregacdmicold.studentsefastudentsefaar, true))
            values.Add(New FieldValue("studentsefadebitaccountAcc_Nm", original_schregacdmicold.studentsefadebitaccountAcc_Nm, theschregacdmicold.studentsefadebitaccountAcc_Nm, true))
            values.Add(New FieldValue("studentsefadebitaccountClsacc_Acc_Nm", original_schregacdmicold.studentsefadebitaccountClsacc_Acc_Nm, theschregacdmicold.studentsefadebitaccountClsacc_Acc_Nm, true))
            values.Add(New FieldValue("studentsefadebitaccountAcc_BndAcc_Nm", original_schregacdmicold.studentsefadebitaccountAcc_BndAcc_Nm, theschregacdmicold.studentsefadebitaccountAcc_BndAcc_Nm, true))
            values.Add(New FieldValue("resigncases", original_schregacdmicold.resigncases, theschregacdmicold.resigncases))
            values.Add(New FieldValue("Schclasskindid", original_schregacdmicold.Schclasskindid, theschregacdmicold.Schclasskindid))
            values.Add(New FieldValue("schstclasskinddmgid", original_schregacdmicold.schstclasskinddmgid, theschregacdmicold.schstclasskinddmgid))
            values.Add(New FieldValue("Schtransferid", original_schregacdmicold.Schtransferid, theschregacdmicold.Schtransferid))
            values.Add(New FieldValue("joindate", original_schregacdmicold.joindate, theschregacdmicold.joindate))
            values.Add(New FieldValue("classorder", original_schregacdmicold.classorder, theschregacdmicold.classorder))
            values.Add(New FieldValue("scucessflag", original_schregacdmicold.scucessflag, theschregacdmicold.scucessflag))
            values.Add(New FieldValue("approved", original_schregacdmicold.approved, theschregacdmicold.approved))
            values.Add(New FieldValue("ModifiedBy", original_schregacdmicold.ModifiedBy, theschregacdmicold.ModifiedBy))
            values.Add(New FieldValue("ModifiedOn", original_schregacdmicold.ModifiedOn, theschregacdmicold.ModifiedOn))
            values.Add(New FieldValue("CreatedBy", original_schregacdmicold.CreatedBy, theschregacdmicold.CreatedBy))
            values.Add(New FieldValue("CreatedOn", original_schregacdmicold.CreatedOn, theschregacdmicold.CreatedOn))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theschregacdmicold As eZee.Data.Objects.schregacdmicold, ByVal original_schregacdmicold As eZee.Data.Objects.schregacdmicold, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "schregacdmicold"
            args.View = dataView
            args.Values = CreateFieldValues(theschregacdmicold, original_schregacdmicold)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("schregacdmicold", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theschregacdmicold)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theschregacdmicold As eZee.Data.Objects.schregacdmicold, ByVal original_schregacdmicold As eZee.Data.Objects.schregacdmicold) As Integer
            Return ExecuteAction(theschregacdmicold, original_schregacdmicold, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theschregacdmicold As eZee.Data.Objects.schregacdmicold) As Integer
            Return Update(theschregacdmicold, SelectSingle(theschregacdmicold.regacdmic))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theschregacdmicold As eZee.Data.Objects.schregacdmicold) As Integer
            Return ExecuteAction(theschregacdmicold, New schregacdmicold(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theschregacdmicold As eZee.Data.Objects.schregacdmicold) As Integer
            Return ExecuteAction(theschregacdmicold, theschregacdmicold, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
