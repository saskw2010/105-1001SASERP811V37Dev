Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class schregtransF
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Trnsfid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schtrnsid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchtrnsschtrnsDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchtrnsschtrnsDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Transdate As Nullable(Of DateTime)
        
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
        Private m_Acdcode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Resons As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Resigndate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Startdate1 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Enddate2 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Notes As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Restdays As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Totaldays As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Amountreturn As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Approved As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Insehabdate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Periodbymonth As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schooltransfeer As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_FirstName1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Classtransfeer1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Amountreturn1 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Amountreturn2 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Amountreturn3 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Amount As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Amount1 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Amount12 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch1Desc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch1sgmsgm_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch1sgmOpcoOpcoName As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch1GenderGender As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch1stageShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch1schtypschtypDesc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Acdcodeapplay As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcdcodeapplayAcademicYear As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcdcodeapplayGlFinperiodFin_period_info As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcdcodeapplayGlFinperiodaccountnumberAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Approveamount As Nullable(Of Long)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property trnsfid() As Nullable(Of Long)
            Get
                Return m_Trnsfid
            End Get
            Set
                m_Trnsfid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schtrnsid() As Nullable(Of Long)
            Get
                Return m_Schtrnsid
            End Get
            Set
                m_Schtrnsid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schtrnsschtrnsDesc1() As String
            Get
                Return m_SchtrnsschtrnsDesc1
            End Get
            Set
                m_SchtrnsschtrnsDesc1 = value
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
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property transdate() As Nullable(Of DateTime)
            Get
                Return m_Transdate
            End Get
            Set
                m_Transdate = value
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
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
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
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
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
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
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
        Public Property acdcode() As Nullable(Of Long)
            Get
                Return m_Acdcode
            End Get
            Set
                m_Acdcode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property resons() As String
            Get
                Return m_Resons
            End Get
            Set
                m_Resons = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property resigndate() As Nullable(Of DateTime)
            Get
                Return m_Resigndate
            End Get
            Set
                m_Resigndate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property startdate1() As Nullable(Of DateTime)
            Get
                Return m_Startdate1
            End Get
            Set
                m_Startdate1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property enddate2() As Nullable(Of DateTime)
            Get
                Return m_Enddate2
            End Get
            Set
                m_Enddate2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property notes() As String
            Get
                Return m_Notes
            End Get
            Set
                m_Notes = value
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
        Public Property restdays() As Nullable(Of Decimal)
            Get
                Return m_Restdays
            End Get
            Set
                m_Restdays = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property totaldays() As Nullable(Of Decimal)
            Get
                Return m_Totaldays
            End Get
            Set
                m_Totaldays = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Amountreturn() As Nullable(Of Decimal)
            Get
                Return m_Amountreturn
            End Get
            Set
                m_Amountreturn = value
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
        Public Property insehabdate() As Nullable(Of DateTime)
            Get
                Return m_Insehabdate
            End Get
            Set
                m_Insehabdate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Periodbymonth() As Nullable(Of Decimal)
            Get
                Return m_Periodbymonth
            End Get
            Set
                m_Periodbymonth = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Schooltransfeer() As String
            Get
                Return m_Schooltransfeer
            End Get
            Set
                m_Schooltransfeer = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property FirstName1() As String
            Get
                Return m_FirstName1
            End Get
            Set
                m_FirstName1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Classtransfeer1() As String
            Get
                Return m_Classtransfeer1
            End Get
            Set
                m_Classtransfeer1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Amountreturn1() As Nullable(Of Decimal)
            Get
                Return m_Amountreturn1
            End Get
            Set
                m_Amountreturn1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Amountreturn2() As Nullable(Of Decimal)
            Get
                Return m_Amountreturn2
            End Get
            Set
                m_Amountreturn2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Amountreturn3() As Nullable(Of Decimal)
            Get
                Return m_Amountreturn3
            End Get
            Set
                m_Amountreturn3 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Amount() As Nullable(Of Decimal)
            Get
                Return m_Amount
            End Get
            Set
                m_Amount = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Amount1() As Nullable(Of Decimal)
            Get
                Return m_Amount1
            End Get
            Set
                m_Amount1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Amount12() As Nullable(Of Decimal)
            Get
                Return m_Amount12
            End Get
            Set
                m_Amount12 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property branch1() As Nullable(Of Long)
            Get
                Return m_Branch1
            End Get
            Set
                m_Branch1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property branch1Desc1() As String
            Get
                Return m_Branch1Desc1
            End Get
            Set
                m_Branch1Desc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property branch1sgmsgm_Nm() As String
            Get
                Return m_Branch1sgmsgm_Nm
            End Get
            Set
                m_Branch1sgmsgm_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property branch1sgmOpcoOpcoName() As String
            Get
                Return m_Branch1sgmOpcoOpcoName
            End Get
            Set
                m_Branch1sgmOpcoOpcoName = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property branch1GenderGender() As String
            Get
                Return m_Branch1GenderGender
            End Get
            Set
                m_Branch1GenderGender = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property branch1stageShortDesc1() As String
            Get
                Return m_Branch1stageShortDesc1
            End Get
            Set
                m_Branch1stageShortDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property branch1schtypschtypDesc() As String
            Get
                Return m_Branch1schtypschtypDesc
            End Get
            Set
                m_Branch1schtypschtypDesc = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property acdcodeapplay() As Nullable(Of Long)
            Get
                Return m_Acdcodeapplay
            End Get
            Set
                m_Acdcodeapplay = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property acdcodeapplayAcademicYear() As String
            Get
                Return m_AcdcodeapplayAcademicYear
            End Get
            Set
                m_AcdcodeapplayAcademicYear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property acdcodeapplayGlFinperiodFin_period_info() As String
            Get
                Return m_AcdcodeapplayGlFinperiodFin_period_info
            End Get
            Set
                m_AcdcodeapplayGlFinperiodFin_period_info = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property acdcodeapplayGlFinperiodaccountnumberAcc_Nm() As String
            Get
                Return m_AcdcodeapplayGlFinperiodaccountnumberAcc_Nm
            End Get
            Set
                m_AcdcodeapplayGlFinperiodaccountnumberAcc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property approveamount() As Nullable(Of Long)
            Get
                Return m_Approveamount
            End Get
            Set
                m_Approveamount = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select]( _
                    ByVal trnsfid As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc1 As String,  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal transdate As Nullable(Of DateTime),  _
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
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal resons As String,  _
                    ByVal resigndate As Nullable(Of DateTime),  _
                    ByVal startdate1 As Nullable(Of DateTime),  _
                    ByVal enddate2 As Nullable(Of DateTime),  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal restdays As Nullable(Of Decimal),  _
                    ByVal totaldays As Nullable(Of Decimal),  _
                    ByVal amountreturn As Nullable(Of Decimal),  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal insehabdate As Nullable(Of DateTime),  _
                    ByVal periodbymonth As Nullable(Of Decimal),  _
                    ByVal schooltransfeer As String,  _
                    ByVal firstName1 As String,  _
                    ByVal classtransfeer1 As String,  _
                    ByVal amountreturn1 As Nullable(Of Decimal),  _
                    ByVal amountreturn2 As Nullable(Of Decimal),  _
                    ByVal amountreturn3 As Nullable(Of Decimal),  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal amount1 As Nullable(Of Decimal),  _
                    ByVal amount12 As Nullable(Of Decimal),  _
                    ByVal branch1 As Nullable(Of Long),  _
                    ByVal branch1Desc1 As String,  _
                    ByVal branch1sgmsgm_Nm As String,  _
                    ByVal branch1sgmOpcoOpcoName As String,  _
                    ByVal branch1GenderGender As String,  _
                    ByVal branch1stageShortDesc1 As String,  _
                    ByVal branch1schtypschtypDesc As String,  _
                    ByVal acdcodeapplay As Nullable(Of Long),  _
                    ByVal acdcodeapplayAcademicYear As String,  _
                    ByVal acdcodeapplayGlFinperiodFin_period_info As String,  _
                    ByVal acdcodeapplayGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal approveamount As Nullable(Of Long)) As List(Of eZee.Data.Objects.schregtransF)
            Return New schregtransFFactory().Select(trnsfid, schtrnsid, schtrnsschtrnsDesc1, schtrnsschtrnsDesc, transdate, studentCode, studentSchstCivilidnumber, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, stage, stageShortDesc1, gradeCode, gradeShortDesc1, gradeacdAcademicYear, gradeacdGlFinperiodFin_period_info, gradeStageShortDesc1, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, acdcode, resons, resigndate, startdate1, enddate2, notes, modifiedBy, modifiedOn, createdBy, createdOn, restdays, totaldays, amountreturn, approved, insehabdate, periodbymonth, schooltransfeer, firstName1, classtransfeer1, amountreturn1, amountreturn2, amountreturn3, amount, amount1, amount12, branch1, branch1Desc1, branch1sgmsgm_Nm, branch1sgmOpcoOpcoName, branch1GenderGender, branch1stageShortDesc1, branch1schtypschtypDesc, acdcodeapplay, acdcodeapplayAcademicYear, acdcodeapplayGlFinperiodFin_period_info, acdcodeapplayGlFinperiodaccountnumberAcc_Nm, approveamount)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.schregtransF) As List(Of eZee.Data.Objects.schregtransF)
            Return New schregtransFFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregtransF)
            Return New schregtransFFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregtransF)
            Return New schregtransFFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregtransF)
            Return New schregtransFFactory().Select(filter, sort, schregtransFFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregtransF)
            Return New schregtransFFactory().Select(filter, sort, schregtransFFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregtransF)
            Return New schregtransFFactory().Select(filter, Nothing, schregtransFFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregtransF)
            Return New schregtransFFactory().Select(filter, Nothing, schregtransFFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schregtransF
            Return New schregtransFFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.schregtransF
            Return New schregtransFFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal trnsfid As Nullable(Of Long)) As eZee.Data.Objects.schregtransF
            Return New schregtransFFactory().SelectSingle(trnsfid)
        End Function
        
        Public Function Insert() As Integer
            Return New schregtransFFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New schregtransFFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New schregtransFFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("trnsfid: {0}", Me.trnsfid)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class schregtransFFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("schregtransF")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("schregtransF")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("schregtransF")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("schregtransF")
            End Get
        End Property
        
        Public Shared Function Create() As schregtransFFactory
            Return New schregtransFFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal trnsfid As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc1 As String,  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal transdate As Nullable(Of DateTime),  _
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
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal resons As String,  _
                    ByVal resigndate As Nullable(Of DateTime),  _
                    ByVal startdate1 As Nullable(Of DateTime),  _
                    ByVal enddate2 As Nullable(Of DateTime),  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal restdays As Nullable(Of Decimal),  _
                    ByVal totaldays As Nullable(Of Decimal),  _
                    ByVal amountreturn As Nullable(Of Decimal),  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal insehabdate As Nullable(Of DateTime),  _
                    ByVal periodbymonth As Nullable(Of Decimal),  _
                    ByVal schooltransfeer As String,  _
                    ByVal firstName1 As String,  _
                    ByVal classtransfeer1 As String,  _
                    ByVal amountreturn1 As Nullable(Of Decimal),  _
                    ByVal amountreturn2 As Nullable(Of Decimal),  _
                    ByVal amountreturn3 As Nullable(Of Decimal),  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal amount1 As Nullable(Of Decimal),  _
                    ByVal amount12 As Nullable(Of Decimal),  _
                    ByVal branch1 As Nullable(Of Long),  _
                    ByVal branch1Desc1 As String,  _
                    ByVal branch1sgmsgm_Nm As String,  _
                    ByVal branch1sgmOpcoOpcoName As String,  _
                    ByVal branch1GenderGender As String,  _
                    ByVal branch1stageShortDesc1 As String,  _
                    ByVal branch1schtypschtypDesc As String,  _
                    ByVal acdcodeapplay As Nullable(Of Long),  _
                    ByVal acdcodeapplayAcademicYear As String,  _
                    ByVal acdcodeapplayGlFinperiodFin_period_info As String,  _
                    ByVal acdcodeapplayGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal approveamount As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If trnsfid.HasValue Then
                filter.Add(("trnsfid:=" + trnsfid.Value.ToString()))
            End If
            If schtrnsid.HasValue Then
                filter.Add(("schtrnsid:=" + schtrnsid.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schtrnsschtrnsDesc1)) Then
                filter.Add(("schtrnsschtrnsDesc1:*" + schtrnsschtrnsDesc1))
            End If
            If Not (String.IsNullOrEmpty(schtrnsschtrnsDesc)) Then
                filter.Add(("schtrnsschtrnsDesc:*" + schtrnsschtrnsDesc))
            End If
            If transdate.HasValue Then
                filter.Add(("transdate:=" + transdate.Value.ToString()))
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
            If acdcode.HasValue Then
                filter.Add(("acdcode:=" + acdcode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(resons)) Then
                filter.Add(("resons:*" + resons))
            End If
            If resigndate.HasValue Then
                filter.Add(("resigndate:=" + resigndate.Value.ToString()))
            End If
            If startdate1.HasValue Then
                filter.Add(("startdate1:=" + startdate1.Value.ToString()))
            End If
            If enddate2.HasValue Then
                filter.Add(("enddate2:=" + enddate2.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(notes)) Then
                filter.Add(("notes:*" + notes))
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
            If restdays.HasValue Then
                filter.Add(("restdays:=" + restdays.Value.ToString()))
            End If
            If totaldays.HasValue Then
                filter.Add(("totaldays:=" + totaldays.Value.ToString()))
            End If
            If amountreturn.HasValue Then
                filter.Add(("Amountreturn:=" + amountreturn.Value.ToString()))
            End If
            If approved.HasValue Then
                filter.Add(("approved:=" + approved.Value.ToString()))
            End If
            If insehabdate.HasValue Then
                filter.Add(("insehabdate:=" + insehabdate.Value.ToString()))
            End If
            If periodbymonth.HasValue Then
                filter.Add(("Periodbymonth:=" + periodbymonth.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schooltransfeer)) Then
                filter.Add(("Schooltransfeer:*" + schooltransfeer))
            End If
            If Not (String.IsNullOrEmpty(firstName1)) Then
                filter.Add(("FirstName1:*" + firstName1))
            End If
            If Not (String.IsNullOrEmpty(classtransfeer1)) Then
                filter.Add(("Classtransfeer1:*" + classtransfeer1))
            End If
            If amountreturn1.HasValue Then
                filter.Add(("Amountreturn1:=" + amountreturn1.Value.ToString()))
            End If
            If amountreturn2.HasValue Then
                filter.Add(("Amountreturn2:=" + amountreturn2.Value.ToString()))
            End If
            If amountreturn3.HasValue Then
                filter.Add(("Amountreturn3:=" + amountreturn3.Value.ToString()))
            End If
            If amount.HasValue Then
                filter.Add(("Amount:=" + amount.Value.ToString()))
            End If
            If amount1.HasValue Then
                filter.Add(("Amount1:=" + amount1.Value.ToString()))
            End If
            If amount12.HasValue Then
                filter.Add(("Amount12:=" + amount12.Value.ToString()))
            End If
            If branch1.HasValue Then
                filter.Add(("branch1:=" + branch1.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(branch1Desc1)) Then
                filter.Add(("branch1Desc1:*" + branch1Desc1))
            End If
            If Not (String.IsNullOrEmpty(branch1sgmsgm_Nm)) Then
                filter.Add(("branch1sgmsgm_Nm:*" + branch1sgmsgm_Nm))
            End If
            If Not (String.IsNullOrEmpty(branch1sgmOpcoOpcoName)) Then
                filter.Add(("branch1sgmOpcoOpcoName:*" + branch1sgmOpcoOpcoName))
            End If
            If Not (String.IsNullOrEmpty(branch1GenderGender)) Then
                filter.Add(("branch1GenderGender:*" + branch1GenderGender))
            End If
            If Not (String.IsNullOrEmpty(branch1stageShortDesc1)) Then
                filter.Add(("branch1stageShortDesc1:*" + branch1stageShortDesc1))
            End If
            If Not (String.IsNullOrEmpty(branch1schtypschtypDesc)) Then
                filter.Add(("branch1schtypschtypDesc:*" + branch1schtypschtypDesc))
            End If
            If acdcodeapplay.HasValue Then
                filter.Add(("acdcodeapplay:=" + acdcodeapplay.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(acdcodeapplayAcademicYear)) Then
                filter.Add(("acdcodeapplayAcademicYear:*" + acdcodeapplayAcademicYear))
            End If
            If Not (String.IsNullOrEmpty(acdcodeapplayGlFinperiodFin_period_info)) Then
                filter.Add(("acdcodeapplayGlFinperiodFin_period_info:*" + acdcodeapplayGlFinperiodFin_period_info))
            End If
            If Not (String.IsNullOrEmpty(acdcodeapplayGlFinperiodaccountnumberAcc_Nm)) Then
                filter.Add(("acdcodeapplayGlFinperiodaccountnumberAcc_Nm:*" + acdcodeapplayGlFinperiodaccountnumberAcc_Nm))
            End If
            If approveamount.HasValue Then
                filter.Add(("approveamount:=" + approveamount.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal trnsfid As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc1 As String,  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal transdate As Nullable(Of DateTime),  _
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
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal resons As String,  _
                    ByVal resigndate As Nullable(Of DateTime),  _
                    ByVal startdate1 As Nullable(Of DateTime),  _
                    ByVal enddate2 As Nullable(Of DateTime),  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal restdays As Nullable(Of Decimal),  _
                    ByVal totaldays As Nullable(Of Decimal),  _
                    ByVal amountreturn As Nullable(Of Decimal),  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal insehabdate As Nullable(Of DateTime),  _
                    ByVal periodbymonth As Nullable(Of Decimal),  _
                    ByVal schooltransfeer As String,  _
                    ByVal firstName1 As String,  _
                    ByVal classtransfeer1 As String,  _
                    ByVal amountreturn1 As Nullable(Of Decimal),  _
                    ByVal amountreturn2 As Nullable(Of Decimal),  _
                    ByVal amountreturn3 As Nullable(Of Decimal),  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal amount1 As Nullable(Of Decimal),  _
                    ByVal amount12 As Nullable(Of Decimal),  _
                    ByVal branch1 As Nullable(Of Long),  _
                    ByVal branch1Desc1 As String,  _
                    ByVal branch1sgmsgm_Nm As String,  _
                    ByVal branch1sgmOpcoOpcoName As String,  _
                    ByVal branch1GenderGender As String,  _
                    ByVal branch1stageShortDesc1 As String,  _
                    ByVal branch1schtypschtypDesc As String,  _
                    ByVal acdcodeapplay As Nullable(Of Long),  _
                    ByVal acdcodeapplayAcademicYear As String,  _
                    ByVal acdcodeapplayGlFinperiodFin_period_info As String,  _
                    ByVal acdcodeapplayGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal approveamount As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.schregtransF)
            Dim request As PageRequest = CreateRequest(trnsfid, schtrnsid, schtrnsschtrnsDesc1, schtrnsschtrnsDesc, transdate, studentCode, studentSchstCivilidnumber, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, stage, stageShortDesc1, gradeCode, gradeShortDesc1, gradeacdAcademicYear, gradeacdGlFinperiodFin_period_info, gradeStageShortDesc1, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, acdcode, resons, resigndate, startdate1, enddate2, notes, modifiedBy, modifiedOn, createdBy, createdOn, restdays, totaldays, amountreturn, approved, insehabdate, periodbymonth, schooltransfeer, firstName1, classtransfeer1, amountreturn1, amountreturn2, amountreturn3, amount, amount1, amount12, branch1, branch1Desc1, branch1sgmsgm_Nm, branch1sgmOpcoOpcoName, branch1GenderGender, branch1stageShortDesc1, branch1schtypschtypDesc, acdcodeapplay, acdcodeapplayAcademicYear, acdcodeapplayGlFinperiodFin_period_info, acdcodeapplayGlFinperiodaccountnumberAcc_Nm, approveamount, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schregtransF", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schregtransF)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.schregtransF) As List(Of eZee.Data.Objects.schregtransF)
            Return [Select](qbe.trnsfid, qbe.schtrnsid, qbe.schtrnsschtrnsDesc1, qbe.schtrnsschtrnsDesc, qbe.transdate, qbe.StudentCode, qbe.StudentSchstCivilidnumber, qbe.branch, qbe.ThebranchDesc1, qbe.Thebranchsgmsgm_Nm, qbe.ThebranchsgmOpcoOpcoName, qbe.ThebranchGenderGender, qbe.ThebranchstageShortDesc1, qbe.ThebranchschtypschtypDesc, qbe.Stage, qbe.StageShortDesc1, qbe.GradeCode, qbe.GradeShortDesc1, qbe.GradeacdAcademicYear, qbe.GradeacdGlFinperiodFin_period_info, qbe.GradeStageShortDesc1, qbe.Class, qbe.ClassClassDesc1, qbe.schstatus_code, qbe.schstatus_schstatus_name, qbe.schstudenttypid, qbe.schstudenttypschstudenttyp, qbe.acdcode, qbe.resons, qbe.resigndate, qbe.startdate1, qbe.enddate2, qbe.notes, qbe.ModifiedBy, qbe.ModifiedOn, qbe.CreatedBy, qbe.CreatedOn, qbe.restdays, qbe.totaldays, qbe.Amountreturn, qbe.approved, qbe.insehabdate, qbe.Periodbymonth, qbe.Schooltransfeer, qbe.FirstName1, qbe.Classtransfeer1, qbe.Amountreturn1, qbe.Amountreturn2, qbe.Amountreturn3, qbe.Amount, qbe.Amount1, qbe.Amount12, qbe.branch1, qbe.branch1Desc1, qbe.branch1sgmsgm_Nm, qbe.branch1sgmOpcoOpcoName, qbe.branch1GenderGender, qbe.branch1stageShortDesc1, qbe.branch1schtypschtypDesc, qbe.acdcodeapplay, qbe.acdcodeapplayAcademicYear, qbe.acdcodeapplayGlFinperiodFin_period_info, qbe.acdcodeapplayGlFinperiodaccountnumberAcc_Nm, qbe.approveamount)
        End Function
        
        Public Function SelectCount( _
                    ByVal trnsfid As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc1 As String,  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal transdate As Nullable(Of DateTime),  _
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
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal resons As String,  _
                    ByVal resigndate As Nullable(Of DateTime),  _
                    ByVal startdate1 As Nullable(Of DateTime),  _
                    ByVal enddate2 As Nullable(Of DateTime),  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal restdays As Nullable(Of Decimal),  _
                    ByVal totaldays As Nullable(Of Decimal),  _
                    ByVal amountreturn As Nullable(Of Decimal),  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal insehabdate As Nullable(Of DateTime),  _
                    ByVal periodbymonth As Nullable(Of Decimal),  _
                    ByVal schooltransfeer As String,  _
                    ByVal firstName1 As String,  _
                    ByVal classtransfeer1 As String,  _
                    ByVal amountreturn1 As Nullable(Of Decimal),  _
                    ByVal amountreturn2 As Nullable(Of Decimal),  _
                    ByVal amountreturn3 As Nullable(Of Decimal),  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal amount1 As Nullable(Of Decimal),  _
                    ByVal amount12 As Nullable(Of Decimal),  _
                    ByVal branch1 As Nullable(Of Long),  _
                    ByVal branch1Desc1 As String,  _
                    ByVal branch1sgmsgm_Nm As String,  _
                    ByVal branch1sgmOpcoOpcoName As String,  _
                    ByVal branch1GenderGender As String,  _
                    ByVal branch1stageShortDesc1 As String,  _
                    ByVal branch1schtypschtypDesc As String,  _
                    ByVal acdcodeapplay As Nullable(Of Long),  _
                    ByVal acdcodeapplayAcademicYear As String,  _
                    ByVal acdcodeapplayGlFinperiodFin_period_info As String,  _
                    ByVal acdcodeapplayGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal approveamount As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(trnsfid, schtrnsid, schtrnsschtrnsDesc1, schtrnsschtrnsDesc, transdate, studentCode, studentSchstCivilidnumber, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, stage, stageShortDesc1, gradeCode, gradeShortDesc1, gradeacdAcademicYear, gradeacdGlFinperiodFin_period_info, gradeStageShortDesc1, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, acdcode, resons, resigndate, startdate1, enddate2, notes, modifiedBy, modifiedOn, createdBy, createdOn, restdays, totaldays, amountreturn, approved, insehabdate, periodbymonth, schooltransfeer, firstName1, classtransfeer1, amountreturn1, amountreturn2, amountreturn3, amount, amount1, amount12, branch1, branch1Desc1, branch1sgmsgm_Nm, branch1sgmOpcoOpcoName, branch1GenderGender, branch1stageShortDesc1, branch1schtypschtypDesc, acdcodeapplay, acdcodeapplayAcademicYear, acdcodeapplayGlFinperiodFin_period_info, acdcodeapplayGlFinperiodaccountnumberAcc_Nm, approveamount, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schregtransF", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal trnsfid As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Long),  _
                    ByVal schtrnsschtrnsDesc1 As String,  _
                    ByVal schtrnsschtrnsDesc As String,  _
                    ByVal transdate As Nullable(Of DateTime),  _
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
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal resons As String,  _
                    ByVal resigndate As Nullable(Of DateTime),  _
                    ByVal startdate1 As Nullable(Of DateTime),  _
                    ByVal enddate2 As Nullable(Of DateTime),  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal restdays As Nullable(Of Decimal),  _
                    ByVal totaldays As Nullable(Of Decimal),  _
                    ByVal amountreturn As Nullable(Of Decimal),  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal insehabdate As Nullable(Of DateTime),  _
                    ByVal periodbymonth As Nullable(Of Decimal),  _
                    ByVal schooltransfeer As String,  _
                    ByVal firstName1 As String,  _
                    ByVal classtransfeer1 As String,  _
                    ByVal amountreturn1 As Nullable(Of Decimal),  _
                    ByVal amountreturn2 As Nullable(Of Decimal),  _
                    ByVal amountreturn3 As Nullable(Of Decimal),  _
                    ByVal amount As Nullable(Of Decimal),  _
                    ByVal amount1 As Nullable(Of Decimal),  _
                    ByVal amount12 As Nullable(Of Decimal),  _
                    ByVal branch1 As Nullable(Of Long),  _
                    ByVal branch1Desc1 As String,  _
                    ByVal branch1sgmsgm_Nm As String,  _
                    ByVal branch1sgmOpcoOpcoName As String,  _
                    ByVal branch1GenderGender As String,  _
                    ByVal branch1stageShortDesc1 As String,  _
                    ByVal branch1schtypschtypDesc As String,  _
                    ByVal acdcodeapplay As Nullable(Of Long),  _
                    ByVal acdcodeapplayAcademicYear As String,  _
                    ByVal acdcodeapplayGlFinperiodFin_period_info As String,  _
                    ByVal acdcodeapplayGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal approveamount As Nullable(Of Long)) As List(Of eZee.Data.Objects.schregtransF)
            Return [Select](trnsfid, schtrnsid, schtrnsschtrnsDesc1, schtrnsschtrnsDesc, transdate, studentCode, studentSchstCivilidnumber, branch, thebranchDesc1, thebranchsgmsgm_Nm, thebranchsgmOpcoOpcoName, thebranchGenderGender, thebranchstageShortDesc1, thebranchschtypschtypDesc, stage, stageShortDesc1, gradeCode, gradeShortDesc1, gradeacdAcademicYear, gradeacdGlFinperiodFin_period_info, gradeStageShortDesc1, [class], classClassDesc1, schstatus_code, schstatus_schstatus_name, schstudenttypid, schstudenttypschstudenttyp, acdcode, resons, resigndate, startdate1, enddate2, notes, modifiedBy, modifiedOn, createdBy, createdOn, restdays, totaldays, amountreturn, approved, insehabdate, periodbymonth, schooltransfeer, firstName1, classtransfeer1, amountreturn1, amountreturn2, amountreturn3, amount, amount1, amount12, branch1, branch1Desc1, branch1sgmsgm_Nm, branch1sgmOpcoOpcoName, branch1GenderGender, branch1stageShortDesc1, branch1schtypschtypDesc, acdcodeapplay, acdcodeapplayAcademicYear, acdcodeapplayGlFinperiodFin_period_info, acdcodeapplayGlFinperiodaccountnumberAcc_Nm, approveamount, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal trnsfid As Nullable(Of Long)) As eZee.Data.Objects.schregtransF
            Dim list As List(Of eZee.Data.Objects.schregtransF) = [Select](trnsfid, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregtransF)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("schregtransF", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schregtransF)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregtransF)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregtransF)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schregtransF
            Dim list As List(Of eZee.Data.Objects.schregtransF) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theschregtransF As eZee.Data.Objects.schregtransF, ByVal original_schregtransF As eZee.Data.Objects.schregtransF) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("trnsfid", original_schregtransF.trnsfid, theschregtransF.trnsfid, true))
            values.Add(New FieldValue("schtrnsid", original_schregtransF.schtrnsid, theschregtransF.schtrnsid))
            values.Add(New FieldValue("schtrnsschtrnsDesc1", original_schregtransF.schtrnsschtrnsDesc1, theschregtransF.schtrnsschtrnsDesc1, true))
            values.Add(New FieldValue("schtrnsschtrnsDesc", original_schregtransF.schtrnsschtrnsDesc, theschregtransF.schtrnsschtrnsDesc, true))
            values.Add(New FieldValue("transdate", original_schregtransF.transdate, theschregtransF.transdate))
            values.Add(New FieldValue("StudentCode", original_schregtransF.StudentCode, theschregtransF.StudentCode))
            values.Add(New FieldValue("StudentSchstCivilidnumber", original_schregtransF.StudentSchstCivilidnumber, theschregtransF.StudentSchstCivilidnumber, true))
            values.Add(New FieldValue("branch", original_schregtransF.branch, theschregtransF.branch))
            values.Add(New FieldValue("ThebranchDesc1", original_schregtransF.ThebranchDesc1, theschregtransF.ThebranchDesc1, true))
            values.Add(New FieldValue("Thebranchsgmsgm_Nm", original_schregtransF.Thebranchsgmsgm_Nm, theschregtransF.Thebranchsgmsgm_Nm, true))
            values.Add(New FieldValue("ThebranchsgmOpcoOpcoName", original_schregtransF.ThebranchsgmOpcoOpcoName, theschregtransF.ThebranchsgmOpcoOpcoName, true))
            values.Add(New FieldValue("ThebranchGenderGender", original_schregtransF.ThebranchGenderGender, theschregtransF.ThebranchGenderGender, true))
            values.Add(New FieldValue("ThebranchstageShortDesc1", original_schregtransF.ThebranchstageShortDesc1, theschregtransF.ThebranchstageShortDesc1, true))
            values.Add(New FieldValue("ThebranchschtypschtypDesc", original_schregtransF.ThebranchschtypschtypDesc, theschregtransF.ThebranchschtypschtypDesc, true))
            values.Add(New FieldValue("Stage", original_schregtransF.Stage, theschregtransF.Stage))
            values.Add(New FieldValue("StageShortDesc1", original_schregtransF.StageShortDesc1, theschregtransF.StageShortDesc1, true))
            values.Add(New FieldValue("GradeCode", original_schregtransF.GradeCode, theschregtransF.GradeCode))
            values.Add(New FieldValue("GradeShortDesc1", original_schregtransF.GradeShortDesc1, theschregtransF.GradeShortDesc1, true))
            values.Add(New FieldValue("GradeacdAcademicYear", original_schregtransF.GradeacdAcademicYear, theschregtransF.GradeacdAcademicYear, true))
            values.Add(New FieldValue("GradeacdGlFinperiodFin_period_info", original_schregtransF.GradeacdGlFinperiodFin_period_info, theschregtransF.GradeacdGlFinperiodFin_period_info, true))
            values.Add(New FieldValue("GradeStageShortDesc1", original_schregtransF.GradeStageShortDesc1, theschregtransF.GradeStageShortDesc1, true))
            values.Add(New FieldValue("Class", original_schregtransF.Class, theschregtransF.Class))
            values.Add(New FieldValue("ClassClassDesc1", original_schregtransF.ClassClassDesc1, theschregtransF.ClassClassDesc1, true))
            values.Add(New FieldValue("schstatus_code", original_schregtransF.schstatus_code, theschregtransF.schstatus_code))
            values.Add(New FieldValue("schstatus_schstatus_name", original_schregtransF.schstatus_schstatus_name, theschregtransF.schstatus_schstatus_name, true))
            values.Add(New FieldValue("schstudenttypid", original_schregtransF.schstudenttypid, theschregtransF.schstudenttypid))
            values.Add(New FieldValue("schstudenttypschstudenttyp", original_schregtransF.schstudenttypschstudenttyp, theschregtransF.schstudenttypschstudenttyp, true))
            values.Add(New FieldValue("acdcode", original_schregtransF.acdcode, theschregtransF.acdcode))
            values.Add(New FieldValue("resons", original_schregtransF.resons, theschregtransF.resons))
            values.Add(New FieldValue("resigndate", original_schregtransF.resigndate, theschregtransF.resigndate))
            values.Add(New FieldValue("startdate1", original_schregtransF.startdate1, theschregtransF.startdate1))
            values.Add(New FieldValue("enddate2", original_schregtransF.enddate2, theschregtransF.enddate2))
            values.Add(New FieldValue("notes", original_schregtransF.notes, theschregtransF.notes))
            values.Add(New FieldValue("ModifiedBy", original_schregtransF.ModifiedBy, theschregtransF.ModifiedBy))
            values.Add(New FieldValue("ModifiedOn", original_schregtransF.ModifiedOn, theschregtransF.ModifiedOn))
            values.Add(New FieldValue("CreatedBy", original_schregtransF.CreatedBy, theschregtransF.CreatedBy))
            values.Add(New FieldValue("CreatedOn", original_schregtransF.CreatedOn, theschregtransF.CreatedOn))
            values.Add(New FieldValue("restdays", original_schregtransF.restdays, theschregtransF.restdays))
            values.Add(New FieldValue("totaldays", original_schregtransF.totaldays, theschregtransF.totaldays))
            values.Add(New FieldValue("Amountreturn", original_schregtransF.Amountreturn, theschregtransF.Amountreturn))
            values.Add(New FieldValue("approved", original_schregtransF.approved, theschregtransF.approved))
            values.Add(New FieldValue("insehabdate", original_schregtransF.insehabdate, theschregtransF.insehabdate))
            values.Add(New FieldValue("Periodbymonth", original_schregtransF.Periodbymonth, theschregtransF.Periodbymonth))
            values.Add(New FieldValue("Schooltransfeer", original_schregtransF.Schooltransfeer, theschregtransF.Schooltransfeer))
            values.Add(New FieldValue("FirstName1", original_schregtransF.FirstName1, theschregtransF.FirstName1, true))
            values.Add(New FieldValue("Classtransfeer1", original_schregtransF.Classtransfeer1, theschregtransF.Classtransfeer1))
            values.Add(New FieldValue("Amountreturn1", original_schregtransF.Amountreturn1, theschregtransF.Amountreturn1))
            values.Add(New FieldValue("Amountreturn2", original_schregtransF.Amountreturn2, theschregtransF.Amountreturn2))
            values.Add(New FieldValue("Amountreturn3", original_schregtransF.Amountreturn3, theschregtransF.Amountreturn3))
            values.Add(New FieldValue("Amount", original_schregtransF.Amount, theschregtransF.Amount))
            values.Add(New FieldValue("Amount1", original_schregtransF.Amount1, theschregtransF.Amount1))
            values.Add(New FieldValue("Amount12", original_schregtransF.Amount12, theschregtransF.Amount12))
            values.Add(New FieldValue("branch1", original_schregtransF.branch1, theschregtransF.branch1))
            values.Add(New FieldValue("branch1Desc1", original_schregtransF.branch1Desc1, theschregtransF.branch1Desc1, true))
            values.Add(New FieldValue("branch1sgmsgm_Nm", original_schregtransF.branch1sgmsgm_Nm, theschregtransF.branch1sgmsgm_Nm, true))
            values.Add(New FieldValue("branch1sgmOpcoOpcoName", original_schregtransF.branch1sgmOpcoOpcoName, theschregtransF.branch1sgmOpcoOpcoName, true))
            values.Add(New FieldValue("branch1GenderGender", original_schregtransF.branch1GenderGender, theschregtransF.branch1GenderGender, true))
            values.Add(New FieldValue("branch1stageShortDesc1", original_schregtransF.branch1stageShortDesc1, theschregtransF.branch1stageShortDesc1, true))
            values.Add(New FieldValue("branch1schtypschtypDesc", original_schregtransF.branch1schtypschtypDesc, theschregtransF.branch1schtypschtypDesc, true))
            values.Add(New FieldValue("acdcodeapplay", original_schregtransF.acdcodeapplay, theschregtransF.acdcodeapplay))
            values.Add(New FieldValue("acdcodeapplayAcademicYear", original_schregtransF.acdcodeapplayAcademicYear, theschregtransF.acdcodeapplayAcademicYear, true))
            values.Add(New FieldValue("acdcodeapplayGlFinperiodFin_period_info", original_schregtransF.acdcodeapplayGlFinperiodFin_period_info, theschregtransF.acdcodeapplayGlFinperiodFin_period_info, true))
            values.Add(New FieldValue("acdcodeapplayGlFinperiodaccountnumberAcc_Nm", original_schregtransF.acdcodeapplayGlFinperiodaccountnumberAcc_Nm, theschregtransF.acdcodeapplayGlFinperiodaccountnumberAcc_Nm, true))
            values.Add(New FieldValue("approveamount", original_schregtransF.approveamount, theschregtransF.approveamount))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theschregtransF As eZee.Data.Objects.schregtransF, ByVal original_schregtransF As eZee.Data.Objects.schregtransF, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "schregtransF"
            args.View = dataView
            args.Values = CreateFieldValues(theschregtransF, original_schregtransF)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("schregtransF", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theschregtransF)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theschregtransF As eZee.Data.Objects.schregtransF, ByVal original_schregtransF As eZee.Data.Objects.schregtransF) As Integer
            Return ExecuteAction(theschregtransF, original_schregtransF, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theschregtransF As eZee.Data.Objects.schregtransF) As Integer
            Return Update(theschregtransF, SelectSingle(theschregtransF.trnsfid))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theschregtransF As eZee.Data.Objects.schregtransF) As Integer
            Return ExecuteAction(theschregtransF, New schregtransF(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theschregtransF As eZee.Data.Objects.schregtransF) As Integer
            Return ExecuteAction(theschregtransF, theschregtransF, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
