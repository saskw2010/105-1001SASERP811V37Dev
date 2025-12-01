Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class SchStudent
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchstCivilidnumber As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_FirstName1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_FirstName2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchstEmail As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_FatherCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_MotherCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Religion As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Genderid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Joiningdate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_State As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Area As Nullable(Of Long)
        
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
        Private m_EmergencyTelNo2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_EmergencyTelNo3 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_EmergencyTelNo4 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Acdcode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Stage As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Class As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstatus_code As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstudenttypid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_BirthDate As Nullable(Of DateTime)
        
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
        Private m_Residenceaddress As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Id As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Joindate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstsplid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schclasskindid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstclasskinddmgid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schtransferid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentsefa As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schsthlthcaseid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schtransferdate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Resigncases As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CivilidExpDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Notes As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PassportNumber As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PassportPlace As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PassportIssueDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PassportExpDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PhotoFileName As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PhotoLength As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PhotoContentType As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Picture() As Byte
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PictureFileName As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PictureContentType As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PictureLength As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Accountnumber As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fatherrecord As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Typ As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ApplicationCodeauto As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Rerecord As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StageAppliedto As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeApplied As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcademicYearto As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Classto As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Calsstoorder As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branchto As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No2 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathercase As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Mothercase As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathersocialstatus As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathername As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathercivilid As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Busid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_BUSPAY As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AMT00 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_TTLADV As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_TTLDEP As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_TTLPAY As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_TTLOTH As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Parentsrelation As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Photo() As Byte
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property StudentCode() As Nullable(Of Long)
            Get
                Return m_StudentCode
            End Get
            Set
                m_StudentCode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property SchstCivilidnumber() As String
            Get
                Return m_SchstCivilidnumber
            End Get
            Set
                m_SchstCivilidnumber = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property FirstName1() As String
            Get
                Return m_FirstName1
            End Get
            Set
                m_FirstName1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property FirstName2() As String
            Get
                Return m_FirstName2
            End Get
            Set
                m_FirstName2 = value
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
        Public Property branch() As Nullable(Of Long)
            Get
                Return m_Branch
            End Get
            Set
                m_Branch = value
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
        Public Property Cntry_No() As Nullable(Of Long)
            Get
                Return m_Cntry_No
            End Get
            Set
                m_Cntry_No = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Genderid() As Nullable(Of Long)
            Get
                Return m_Genderid
            End Get
            Set
                m_Genderid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Joiningdate() As Nullable(Of DateTime)
            Get
                Return m_Joiningdate
            End Get
            Set
                m_Joiningdate = value
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
        Public Property area() As Nullable(Of Long)
            Get
                Return m_Area
            End Get
            Set
                m_Area = value
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
        Public Property EmergencyTelNo2() As String
            Get
                Return m_EmergencyTelNo2
            End Get
            Set
                m_EmergencyTelNo2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property EmergencyTelNo3() As String
            Get
                Return m_EmergencyTelNo3
            End Get
            Set
                m_EmergencyTelNo3 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property EmergencyTelNo4() As String
            Get
                Return m_EmergencyTelNo4
            End Get
            Set
                m_EmergencyTelNo4 = value
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
        Public Property Stage() As Nullable(Of Long)
            Get
                Return m_Stage
            End Get
            Set
                m_Stage = value
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
        Public Property [Class]() As Nullable(Of Long)
            Get
                Return m_Class
            End Get
            Set
                m_Class = value
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
        Public Property schstudenttypid() As Nullable(Of Long)
            Get
                Return m_Schstudenttypid
            End Get
            Set
                m_Schstudenttypid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property BirthDate() As Nullable(Of DateTime)
            Get
                Return m_BirthDate
            End Get
            Set
                m_BirthDate = value
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
        Public Property Residenceaddress() As String
            Get
                Return m_Residenceaddress
            End Get
            Set
                m_Residenceaddress = value
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
        Public Property joindate() As Nullable(Of DateTime)
            Get
                Return m_Joindate
            End Get
            Set
                m_Joindate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property schstsplid() As Nullable(Of Long)
            Get
                Return m_Schstsplid
            End Get
            Set
                m_Schstsplid = value
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
        Public Property studentsefa() As Nullable(Of Long)
            Get
                Return m_Studentsefa
            End Get
            Set
                m_Studentsefa = value
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
        Public Property Schtransferdate() As Nullable(Of DateTime)
            Get
                Return m_Schtransferdate
            End Get
            Set
                m_Schtransferdate = value
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
        Public Property CivilidExpDate() As Nullable(Of DateTime)
            Get
                Return m_CivilidExpDate
            End Get
            Set
                m_CivilidExpDate = value
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
        Public Property PassportNumber() As String
            Get
                Return m_PassportNumber
            End Get
            Set
                m_PassportNumber = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property PassportPlace() As String
            Get
                Return m_PassportPlace
            End Get
            Set
                m_PassportPlace = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property PassportIssueDate() As Nullable(Of DateTime)
            Get
                Return m_PassportIssueDate
            End Get
            Set
                m_PassportIssueDate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property PassportExpDate() As Nullable(Of DateTime)
            Get
                Return m_PassportExpDate
            End Get
            Set
                m_PassportExpDate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property PhotoFileName() As String
            Get
                Return m_PhotoFileName
            End Get
            Set
                m_PhotoFileName = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property PhotoLength() As Nullable(Of Integer)
            Get
                Return m_PhotoLength
            End Get
            Set
                m_PhotoLength = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property PhotoContentType() As String
            Get
                Return m_PhotoContentType
            End Get
            Set
                m_PhotoContentType = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Picture() As Byte()
            Get
                Return m_Picture
            End Get
            Set
                m_Picture = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property PictureFileName() As String
            Get
                Return m_PictureFileName
            End Get
            Set
                m_PictureFileName = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property PictureContentType() As String
            Get
                Return m_PictureContentType
            End Get
            Set
                m_PictureContentType = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property PictureLength() As Nullable(Of Integer)
            Get
                Return m_PictureLength
            End Get
            Set
                m_PictureLength = value
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
        Public Property accountnumber() As Nullable(Of Decimal)
            Get
                Return m_Accountnumber
            End Get
            Set
                m_Accountnumber = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fatherrecord() As Nullable(Of Boolean)
            Get
                Return m_Fatherrecord
            End Get
            Set
                m_Fatherrecord = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property typ() As Nullable(Of Long)
            Get
                Return m_Typ
            End Get
            Set
                m_Typ = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ApplicationCodeauto() As Nullable(Of Long)
            Get
                Return m_ApplicationCodeauto
            End Get
            Set
                m_ApplicationCodeauto = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Rerecord() As Nullable(Of Decimal)
            Get
                Return m_Rerecord
            End Get
            Set
                m_Rerecord = value
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
        Public Property GradeApplied() As Nullable(Of Long)
            Get
                Return m_GradeApplied
            End Get
            Set
                m_GradeApplied = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property AcademicYearto() As Nullable(Of Long)
            Get
                Return m_AcademicYearto
            End Get
            Set
                m_AcademicYearto = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Classto() As Nullable(Of Long)
            Get
                Return m_Classto
            End Get
            Set
                m_Classto = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Calsstoorder() As Nullable(Of Long)
            Get
                Return m_Calsstoorder
            End Get
            Set
                m_Calsstoorder = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property branchto() As Nullable(Of Long)
            Get
                Return m_Branchto
            End Get
            Set
                m_Branchto = value
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
        Public Property Cntry_No2() As Nullable(Of Long)
            Get
                Return m_Cntry_No2
            End Get
            Set
                m_Cntry_No2 = value
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
        Public Property mothercase() As Nullable(Of Long)
            Get
                Return m_Mothercase
            End Get
            Set
                m_Mothercase = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fathersocialstatus() As Nullable(Of Long)
            Get
                Return m_Fathersocialstatus
            End Get
            Set
                m_Fathersocialstatus = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fathername() As String
            Get
                Return m_Fathername
            End Get
            Set
                m_Fathername = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fathercivilid() As String
            Get
                Return m_Fathercivilid
            End Get
            Set
                m_Fathercivilid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property busid() As Nullable(Of Long)
            Get
                Return m_Busid
            End Get
            Set
                m_Busid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property BUSPAY() As Nullable(Of Decimal)
            Get
                Return m_BUSPAY
            End Get
            Set
                m_BUSPAY = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property AMT00() As Nullable(Of Decimal)
            Get
                Return m_AMT00
            End Get
            Set
                m_AMT00 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property TTLADV() As Nullable(Of Decimal)
            Get
                Return m_TTLADV
            End Get
            Set
                m_TTLADV = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property TTLDEP() As Nullable(Of Decimal)
            Get
                Return m_TTLDEP
            End Get
            Set
                m_TTLDEP = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property TTLPAY() As Nullable(Of Decimal)
            Get
                Return m_TTLPAY
            End Get
            Set
                m_TTLPAY = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property TTLOTH() As Nullable(Of Decimal)
            Get
                Return m_TTLOTH
            End Get
            Set
                m_TTLOTH = value
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
        Public Property Photo() As Byte()
            Get
                Return m_Photo
            End Get
            Set
                m_Photo = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select]( _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal schstCivilidnumber As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal motherCode As Nullable(Of Long),  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal genderid As Nullable(Of Long),  _
                    ByVal joiningdate As Nullable(Of DateTime),  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal birthDate As Nullable(Of DateTime),  _
                    ByVal birthdocdate As Nullable(Of DateTime),  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal joindate As Nullable(Of DateTime),  _
                    ByVal schstsplid As Nullable(Of Long),  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal schtransferdate As Nullable(Of DateTime),  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal passportIssueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal photoFileName As String,  _
                    ByVal photoLength As Nullable(Of Integer),  _
                    ByVal photoContentType As String,  _
                    ByVal pictureFileName As String,  _
                    ByVal pictureContentType As String,  _
                    ByVal pictureLength As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal accountnumber As Nullable(Of Decimal),  _
                    ByVal fatherrecord As Nullable(Of Boolean),  _
                    ByVal typ As Nullable(Of Long),  _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal rerecord As Nullable(Of Decimal),  _
                    ByVal stageAppliedto As Nullable(Of Long),  _
                    ByVal gradeApplied As Nullable(Of Long),  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal classto As Nullable(Of Long),  _
                    ByVal calsstoorder As Nullable(Of Long),  _
                    ByVal branchto As Nullable(Of Long),  _
                    ByVal cntry_No1 As Nullable(Of Long),  _
                    ByVal cntry_No2 As Nullable(Of Long),  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal fathersocialstatus As Nullable(Of Long),  _
                    ByVal busid As Nullable(Of Long),  _
                    ByVal bUSPAY As Nullable(Of Decimal),  _
                    ByVal aMT00 As Nullable(Of Decimal),  _
                    ByVal tTLADV As Nullable(Of Decimal),  _
                    ByVal tTLDEP As Nullable(Of Decimal),  _
                    ByVal tTLPAY As Nullable(Of Decimal),  _
                    ByVal tTLOTH As Nullable(Of Decimal),  _
                    ByVal parentsrelation As Nullable(Of Long)) As List(Of eZee.Data.Objects.SchStudent)
            Return New SchStudentFactory().Select(studentCode, schstCivilidnumber, branch, fatherCode, motherCode, religion, cntry_No, genderid, joiningdate, state, area, acdcode, stage, gradeCode, [class], schstatus_code, schstudenttypid, birthDate, birthdocdate, residenceExpDate, id, joindate, schstsplid, schclasskindid, schstclasskinddmgid, schtransferid, studentsefa, schsthlthcaseid, schtransferdate, civilidExpDate, passportIssueDate, passportExpDate, photoFileName, photoLength, photoContentType, pictureFileName, pictureContentType, pictureLength, modifiedBy, modifiedOn, createdBy, createdOn, accountnumber, fatherrecord, typ, applicationCodeauto, rerecord, stageAppliedto, gradeApplied, academicYearto, classto, calsstoorder, branchto, cntry_No1, cntry_No2, fathercase, mothercase, fathersocialstatus, busid, bUSPAY, aMT00, tTLADV, tTLDEP, tTLPAY, tTLOTH, parentsrelation)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.SchStudent) As List(Of eZee.Data.Objects.SchStudent)
            Return New SchStudentFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.SchStudent)
            Return New SchStudentFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.SchStudent)
            Return New SchStudentFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.SchStudent)
            Return New SchStudentFactory().Select(filter, sort, SchStudentFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.SchStudent)
            Return New SchStudentFactory().Select(filter, sort, SchStudentFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.SchStudent)
            Return New SchStudentFactory().Select(filter, Nothing, SchStudentFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.SchStudent)
            Return New SchStudentFactory().Select(filter, Nothing, SchStudentFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.SchStudent
            Return New SchStudentFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.SchStudent
            Return New SchStudentFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal studentCode As Nullable(Of Long)) As eZee.Data.Objects.SchStudent
            Return New SchStudentFactory().SelectSingle(studentCode)
        End Function
        
        Public Function Insert() As Integer
            Return New SchStudentFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New SchStudentFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New SchStudentFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("StudentCode: {0}", Me.StudentCode)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class SchStudentFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("SchStudent")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("SchStudent")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("SchStudent")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("SchStudent")
            End Get
        End Property
        
        Public Shared Function Create() As SchStudentFactory
            Return New SchStudentFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal schstCivilidnumber As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal motherCode As Nullable(Of Long),  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal genderid As Nullable(Of Long),  _
                    ByVal joiningdate As Nullable(Of DateTime),  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal birthDate As Nullable(Of DateTime),  _
                    ByVal birthdocdate As Nullable(Of DateTime),  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal joindate As Nullable(Of DateTime),  _
                    ByVal schstsplid As Nullable(Of Long),  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal schtransferdate As Nullable(Of DateTime),  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal passportIssueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal photoFileName As String,  _
                    ByVal photoLength As Nullable(Of Integer),  _
                    ByVal photoContentType As String,  _
                    ByVal pictureFileName As String,  _
                    ByVal pictureContentType As String,  _
                    ByVal pictureLength As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal accountnumber As Nullable(Of Decimal),  _
                    ByVal fatherrecord As Nullable(Of Boolean),  _
                    ByVal typ As Nullable(Of Long),  _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal rerecord As Nullable(Of Decimal),  _
                    ByVal stageAppliedto As Nullable(Of Long),  _
                    ByVal gradeApplied As Nullable(Of Long),  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal classto As Nullable(Of Long),  _
                    ByVal calsstoorder As Nullable(Of Long),  _
                    ByVal branchto As Nullable(Of Long),  _
                    ByVal cntry_No1 As Nullable(Of Long),  _
                    ByVal cntry_No2 As Nullable(Of Long),  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal fathersocialstatus As Nullable(Of Long),  _
                    ByVal busid As Nullable(Of Long),  _
                    ByVal bUSPAY As Nullable(Of Decimal),  _
                    ByVal aMT00 As Nullable(Of Decimal),  _
                    ByVal tTLADV As Nullable(Of Decimal),  _
                    ByVal tTLDEP As Nullable(Of Decimal),  _
                    ByVal tTLPAY As Nullable(Of Decimal),  _
                    ByVal tTLOTH As Nullable(Of Decimal),  _
                    ByVal parentsrelation As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If studentCode.HasValue Then
                filter.Add(("StudentCode:=" + studentCode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schstCivilidnumber)) Then
                filter.Add(("SchstCivilidnumber:*" + schstCivilidnumber))
            End If
            If branch.HasValue Then
                filter.Add(("branch:=" + branch.Value.ToString()))
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
            If cntry_No.HasValue Then
                filter.Add(("Cntry_No:=" + cntry_No.Value.ToString()))
            End If
            If genderid.HasValue Then
                filter.Add(("Genderid:=" + genderid.Value.ToString()))
            End If
            If joiningdate.HasValue Then
                filter.Add(("Joiningdate:=" + joiningdate.Value.ToString()))
            End If
            If state.HasValue Then
                filter.Add(("state:=" + state.Value.ToString()))
            End If
            If area.HasValue Then
                filter.Add(("area:=" + area.Value.ToString()))
            End If
            If acdcode.HasValue Then
                filter.Add(("acdcode:=" + acdcode.Value.ToString()))
            End If
            If stage.HasValue Then
                filter.Add(("Stage:=" + stage.Value.ToString()))
            End If
            If gradeCode.HasValue Then
                filter.Add(("GradeCode:=" + gradeCode.Value.ToString()))
            End If
            If [class].HasValue Then
                filter.Add(("Class:=" + [class].Value.ToString()))
            End If
            If schstatus_code.HasValue Then
                filter.Add(("schstatus_code:=" + schstatus_code.Value.ToString()))
            End If
            If schstudenttypid.HasValue Then
                filter.Add(("schstudenttypid:=" + schstudenttypid.Value.ToString()))
            End If
            If birthDate.HasValue Then
                filter.Add(("BirthDate:=" + birthDate.Value.ToString()))
            End If
            If birthdocdate.HasValue Then
                filter.Add(("birthdocdate:=" + birthdocdate.Value.ToString()))
            End If
            If residenceExpDate.HasValue Then
                filter.Add(("ResidenceExpDate:=" + residenceExpDate.Value.ToString()))
            End If
            If id.HasValue Then
                filter.Add(("id:=" + id.Value.ToString()))
            End If
            If joindate.HasValue Then
                filter.Add(("joindate:=" + joindate.Value.ToString()))
            End If
            If schstsplid.HasValue Then
                filter.Add(("schstsplid:=" + schstsplid.Value.ToString()))
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
            If studentsefa.HasValue Then
                filter.Add(("studentsefa:=" + studentsefa.Value.ToString()))
            End If
            If schsthlthcaseid.HasValue Then
                filter.Add(("schsthlthcaseid:=" + schsthlthcaseid.Value.ToString()))
            End If
            If schtransferdate.HasValue Then
                filter.Add(("Schtransferdate:=" + schtransferdate.Value.ToString()))
            End If
            If civilidExpDate.HasValue Then
                filter.Add(("CivilidExpDate:=" + civilidExpDate.Value.ToString()))
            End If
            If passportIssueDate.HasValue Then
                filter.Add(("PassportIssueDate:=" + passportIssueDate.Value.ToString()))
            End If
            If passportExpDate.HasValue Then
                filter.Add(("PassportExpDate:=" + passportExpDate.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(photoFileName)) Then
                filter.Add(("PhotoFileName:*" + photoFileName))
            End If
            If photoLength.HasValue Then
                filter.Add(("PhotoLength:=" + photoLength.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(photoContentType)) Then
                filter.Add(("PhotoContentType:*" + photoContentType))
            End If
            If Not (String.IsNullOrEmpty(pictureFileName)) Then
                filter.Add(("PictureFileName:*" + pictureFileName))
            End If
            If Not (String.IsNullOrEmpty(pictureContentType)) Then
                filter.Add(("PictureContentType:*" + pictureContentType))
            End If
            If pictureLength.HasValue Then
                filter.Add(("PictureLength:=" + pictureLength.Value.ToString()))
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
            If accountnumber.HasValue Then
                filter.Add(("accountnumber:=" + accountnumber.Value.ToString()))
            End If
            If fatherrecord.HasValue Then
                filter.Add(("fatherrecord:=" + fatherrecord.Value.ToString()))
            End If
            If typ.HasValue Then
                filter.Add(("typ:=" + typ.Value.ToString()))
            End If
            If applicationCodeauto.HasValue Then
                filter.Add(("ApplicationCodeauto:=" + applicationCodeauto.Value.ToString()))
            End If
            If rerecord.HasValue Then
                filter.Add(("Rerecord:=" + rerecord.Value.ToString()))
            End If
            If stageAppliedto.HasValue Then
                filter.Add(("StageAppliedto:=" + stageAppliedto.Value.ToString()))
            End If
            If gradeApplied.HasValue Then
                filter.Add(("GradeApplied:=" + gradeApplied.Value.ToString()))
            End If
            If academicYearto.HasValue Then
                filter.Add(("AcademicYearto:=" + academicYearto.Value.ToString()))
            End If
            If classto.HasValue Then
                filter.Add(("Classto:=" + classto.Value.ToString()))
            End If
            If calsstoorder.HasValue Then
                filter.Add(("Calsstoorder:=" + calsstoorder.Value.ToString()))
            End If
            If branchto.HasValue Then
                filter.Add(("branchto:=" + branchto.Value.ToString()))
            End If
            If cntry_No1.HasValue Then
                filter.Add(("Cntry_No1:=" + cntry_No1.Value.ToString()))
            End If
            If cntry_No2.HasValue Then
                filter.Add(("Cntry_No2:=" + cntry_No2.Value.ToString()))
            End If
            If fathercase.HasValue Then
                filter.Add(("fathercase:=" + fathercase.Value.ToString()))
            End If
            If mothercase.HasValue Then
                filter.Add(("mothercase:=" + mothercase.Value.ToString()))
            End If
            If fathersocialstatus.HasValue Then
                filter.Add(("fathersocialstatus:=" + fathersocialstatus.Value.ToString()))
            End If
            If busid.HasValue Then
                filter.Add(("busid:=" + busid.Value.ToString()))
            End If
            If bUSPAY.HasValue Then
                filter.Add(("BUSPAY:=" + bUSPAY.Value.ToString()))
            End If
            If aMT00.HasValue Then
                filter.Add(("AMT00:=" + aMT00.Value.ToString()))
            End If
            If tTLADV.HasValue Then
                filter.Add(("TTLADV:=" + tTLADV.Value.ToString()))
            End If
            If tTLDEP.HasValue Then
                filter.Add(("TTLDEP:=" + tTLDEP.Value.ToString()))
            End If
            If tTLPAY.HasValue Then
                filter.Add(("TTLPAY:=" + tTLPAY.Value.ToString()))
            End If
            If tTLOTH.HasValue Then
                filter.Add(("TTLOTH:=" + tTLOTH.Value.ToString()))
            End If
            If parentsrelation.HasValue Then
                filter.Add(("parentsrelation:=" + parentsrelation.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal schstCivilidnumber As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal motherCode As Nullable(Of Long),  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal genderid As Nullable(Of Long),  _
                    ByVal joiningdate As Nullable(Of DateTime),  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal birthDate As Nullable(Of DateTime),  _
                    ByVal birthdocdate As Nullable(Of DateTime),  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal joindate As Nullable(Of DateTime),  _
                    ByVal schstsplid As Nullable(Of Long),  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal schtransferdate As Nullable(Of DateTime),  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal passportIssueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal photoFileName As String,  _
                    ByVal photoLength As Nullable(Of Integer),  _
                    ByVal photoContentType As String,  _
                    ByVal pictureFileName As String,  _
                    ByVal pictureContentType As String,  _
                    ByVal pictureLength As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal accountnumber As Nullable(Of Decimal),  _
                    ByVal fatherrecord As Nullable(Of Boolean),  _
                    ByVal typ As Nullable(Of Long),  _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal rerecord As Nullable(Of Decimal),  _
                    ByVal stageAppliedto As Nullable(Of Long),  _
                    ByVal gradeApplied As Nullable(Of Long),  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal classto As Nullable(Of Long),  _
                    ByVal calsstoorder As Nullable(Of Long),  _
                    ByVal branchto As Nullable(Of Long),  _
                    ByVal cntry_No1 As Nullable(Of Long),  _
                    ByVal cntry_No2 As Nullable(Of Long),  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal fathersocialstatus As Nullable(Of Long),  _
                    ByVal busid As Nullable(Of Long),  _
                    ByVal bUSPAY As Nullable(Of Decimal),  _
                    ByVal aMT00 As Nullable(Of Decimal),  _
                    ByVal tTLADV As Nullable(Of Decimal),  _
                    ByVal tTLDEP As Nullable(Of Decimal),  _
                    ByVal tTLPAY As Nullable(Of Decimal),  _
                    ByVal tTLOTH As Nullable(Of Decimal),  _
                    ByVal parentsrelation As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.SchStudent)
            Dim request As PageRequest = CreateRequest(studentCode, schstCivilidnumber, branch, fatherCode, motherCode, religion, cntry_No, genderid, joiningdate, state, area, acdcode, stage, gradeCode, [class], schstatus_code, schstudenttypid, birthDate, birthdocdate, residenceExpDate, id, joindate, schstsplid, schclasskindid, schstclasskinddmgid, schtransferid, studentsefa, schsthlthcaseid, schtransferdate, civilidExpDate, passportIssueDate, passportExpDate, photoFileName, photoLength, photoContentType, pictureFileName, pictureContentType, pictureLength, modifiedBy, modifiedOn, createdBy, createdOn, accountnumber, fatherrecord, typ, applicationCodeauto, rerecord, stageAppliedto, gradeApplied, academicYearto, classto, calsstoorder, branchto, cntry_No1, cntry_No2, fathercase, mothercase, fathersocialstatus, busid, bUSPAY, aMT00, tTLADV, tTLDEP, tTLPAY, tTLOTH, parentsrelation, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("SchStudent", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.SchStudent)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.SchStudent) As List(Of eZee.Data.Objects.SchStudent)
            Return [Select](qbe.StudentCode, qbe.SchstCivilidnumber, qbe.branch, qbe.FatherCode, qbe.MotherCode, qbe.Religion, qbe.Cntry_No, qbe.Genderid, qbe.Joiningdate, qbe.state, qbe.area, qbe.acdcode, qbe.Stage, qbe.GradeCode, qbe.Class, qbe.schstatus_code, qbe.schstudenttypid, qbe.BirthDate, qbe.birthdocdate, qbe.ResidenceExpDate, qbe.id, qbe.joindate, qbe.schstsplid, qbe.Schclasskindid, qbe.schstclasskinddmgid, qbe.Schtransferid, qbe.studentsefa, qbe.schsthlthcaseid, qbe.Schtransferdate, qbe.CivilidExpDate, qbe.PassportIssueDate, qbe.PassportExpDate, qbe.PhotoFileName, qbe.PhotoLength, qbe.PhotoContentType, qbe.PictureFileName, qbe.PictureContentType, qbe.PictureLength, qbe.ModifiedBy, qbe.ModifiedOn, qbe.CreatedBy, qbe.CreatedOn, qbe.accountnumber, qbe.fatherrecord, qbe.typ, qbe.ApplicationCodeauto, qbe.Rerecord, qbe.StageAppliedto, qbe.GradeApplied, qbe.AcademicYearto, qbe.Classto, qbe.Calsstoorder, qbe.branchto, qbe.Cntry_No1, qbe.Cntry_No2, qbe.fathercase, qbe.mothercase, qbe.fathersocialstatus, qbe.busid, qbe.BUSPAY, qbe.AMT00, qbe.TTLADV, qbe.TTLDEP, qbe.TTLPAY, qbe.TTLOTH, qbe.parentsrelation)
        End Function
        
        Public Function SelectCount( _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal schstCivilidnumber As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal motherCode As Nullable(Of Long),  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal genderid As Nullable(Of Long),  _
                    ByVal joiningdate As Nullable(Of DateTime),  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal birthDate As Nullable(Of DateTime),  _
                    ByVal birthdocdate As Nullable(Of DateTime),  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal joindate As Nullable(Of DateTime),  _
                    ByVal schstsplid As Nullable(Of Long),  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal schtransferdate As Nullable(Of DateTime),  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal passportIssueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal photoFileName As String,  _
                    ByVal photoLength As Nullable(Of Integer),  _
                    ByVal photoContentType As String,  _
                    ByVal pictureFileName As String,  _
                    ByVal pictureContentType As String,  _
                    ByVal pictureLength As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal accountnumber As Nullable(Of Decimal),  _
                    ByVal fatherrecord As Nullable(Of Boolean),  _
                    ByVal typ As Nullable(Of Long),  _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal rerecord As Nullable(Of Decimal),  _
                    ByVal stageAppliedto As Nullable(Of Long),  _
                    ByVal gradeApplied As Nullable(Of Long),  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal classto As Nullable(Of Long),  _
                    ByVal calsstoorder As Nullable(Of Long),  _
                    ByVal branchto As Nullable(Of Long),  _
                    ByVal cntry_No1 As Nullable(Of Long),  _
                    ByVal cntry_No2 As Nullable(Of Long),  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal fathersocialstatus As Nullable(Of Long),  _
                    ByVal busid As Nullable(Of Long),  _
                    ByVal bUSPAY As Nullable(Of Decimal),  _
                    ByVal aMT00 As Nullable(Of Decimal),  _
                    ByVal tTLADV As Nullable(Of Decimal),  _
                    ByVal tTLDEP As Nullable(Of Decimal),  _
                    ByVal tTLPAY As Nullable(Of Decimal),  _
                    ByVal tTLOTH As Nullable(Of Decimal),  _
                    ByVal parentsrelation As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(studentCode, schstCivilidnumber, branch, fatherCode, motherCode, religion, cntry_No, genderid, joiningdate, state, area, acdcode, stage, gradeCode, [class], schstatus_code, schstudenttypid, birthDate, birthdocdate, residenceExpDate, id, joindate, schstsplid, schclasskindid, schstclasskinddmgid, schtransferid, studentsefa, schsthlthcaseid, schtransferdate, civilidExpDate, passportIssueDate, passportExpDate, photoFileName, photoLength, photoContentType, pictureFileName, pictureContentType, pictureLength, modifiedBy, modifiedOn, createdBy, createdOn, accountnumber, fatherrecord, typ, applicationCodeauto, rerecord, stageAppliedto, gradeApplied, academicYearto, classto, calsstoorder, branchto, cntry_No1, cntry_No2, fathercase, mothercase, fathersocialstatus, busid, bUSPAY, aMT00, tTLADV, tTLDEP, tTLPAY, tTLOTH, parentsrelation, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("SchStudent", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal schstCivilidnumber As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal motherCode As Nullable(Of Long),  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal genderid As Nullable(Of Long),  _
                    ByVal joiningdate As Nullable(Of DateTime),  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal birthDate As Nullable(Of DateTime),  _
                    ByVal birthdocdate As Nullable(Of DateTime),  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal joindate As Nullable(Of DateTime),  _
                    ByVal schstsplid As Nullable(Of Long),  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal schtransferdate As Nullable(Of DateTime),  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal passportIssueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal photoFileName As String,  _
                    ByVal photoLength As Nullable(Of Integer),  _
                    ByVal photoContentType As String,  _
                    ByVal pictureFileName As String,  _
                    ByVal pictureContentType As String,  _
                    ByVal pictureLength As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal accountnumber As Nullable(Of Decimal),  _
                    ByVal fatherrecord As Nullable(Of Boolean),  _
                    ByVal typ As Nullable(Of Long),  _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal rerecord As Nullable(Of Decimal),  _
                    ByVal stageAppliedto As Nullable(Of Long),  _
                    ByVal gradeApplied As Nullable(Of Long),  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal classto As Nullable(Of Long),  _
                    ByVal calsstoorder As Nullable(Of Long),  _
                    ByVal branchto As Nullable(Of Long),  _
                    ByVal cntry_No1 As Nullable(Of Long),  _
                    ByVal cntry_No2 As Nullable(Of Long),  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal fathersocialstatus As Nullable(Of Long),  _
                    ByVal busid As Nullable(Of Long),  _
                    ByVal bUSPAY As Nullable(Of Decimal),  _
                    ByVal aMT00 As Nullable(Of Decimal),  _
                    ByVal tTLADV As Nullable(Of Decimal),  _
                    ByVal tTLDEP As Nullable(Of Decimal),  _
                    ByVal tTLPAY As Nullable(Of Decimal),  _
                    ByVal tTLOTH As Nullable(Of Decimal),  _
                    ByVal parentsrelation As Nullable(Of Long)) As List(Of eZee.Data.Objects.SchStudent)
            Return [Select](studentCode, schstCivilidnumber, branch, fatherCode, motherCode, religion, cntry_No, genderid, joiningdate, state, area, acdcode, stage, gradeCode, [class], schstatus_code, schstudenttypid, birthDate, birthdocdate, residenceExpDate, id, joindate, schstsplid, schclasskindid, schstclasskinddmgid, schtransferid, studentsefa, schsthlthcaseid, schtransferdate, civilidExpDate, passportIssueDate, passportExpDate, photoFileName, photoLength, photoContentType, pictureFileName, pictureContentType, pictureLength, modifiedBy, modifiedOn, createdBy, createdOn, accountnumber, fatherrecord, typ, applicationCodeauto, rerecord, stageAppliedto, gradeApplied, academicYearto, classto, calsstoorder, branchto, cntry_No1, cntry_No2, fathercase, mothercase, fathersocialstatus, busid, bUSPAY, aMT00, tTLADV, tTLDEP, tTLPAY, tTLOTH, parentsrelation, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal studentCode As Nullable(Of Long)) As eZee.Data.Objects.SchStudent
            Dim list As List(Of eZee.Data.Objects.SchStudent) = [Select](studentCode, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.SchStudent)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("SchStudent", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.SchStudent)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.SchStudent)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.SchStudent)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.SchStudent
            Dim list As List(Of eZee.Data.Objects.SchStudent) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theSchStudent As eZee.Data.Objects.SchStudent, ByVal original_SchStudent As eZee.Data.Objects.SchStudent) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("StudentCode", original_SchStudent.StudentCode, theSchStudent.StudentCode, true))
            values.Add(New FieldValue("SchstCivilidnumber", original_SchStudent.SchstCivilidnumber, theSchStudent.SchstCivilidnumber))
            values.Add(New FieldValue("FirstName1", original_SchStudent.FirstName1, theSchStudent.FirstName1))
            values.Add(New FieldValue("FirstName2", original_SchStudent.FirstName2, theSchStudent.FirstName2))
            values.Add(New FieldValue("schstEmail", original_SchStudent.schstEmail, theSchStudent.schstEmail))
            values.Add(New FieldValue("branch", original_SchStudent.branch, theSchStudent.branch))
            values.Add(New FieldValue("FatherCode", original_SchStudent.FatherCode, theSchStudent.FatherCode))
            values.Add(New FieldValue("MotherCode", original_SchStudent.MotherCode, theSchStudent.MotherCode))
            values.Add(New FieldValue("Religion", original_SchStudent.Religion, theSchStudent.Religion))
            values.Add(New FieldValue("Cntry_No", original_SchStudent.Cntry_No, theSchStudent.Cntry_No))
            values.Add(New FieldValue("Genderid", original_SchStudent.Genderid, theSchStudent.Genderid))
            values.Add(New FieldValue("Joiningdate", original_SchStudent.Joiningdate, theSchStudent.Joiningdate))
            values.Add(New FieldValue("state", original_SchStudent.state, theSchStudent.state))
            values.Add(New FieldValue("area", original_SchStudent.area, theSchStudent.area))
            values.Add(New FieldValue("blockno", original_SchStudent.blockno, theSchStudent.blockno))
            values.Add(New FieldValue("streetno", original_SchStudent.streetno, theSchStudent.streetno))
            values.Add(New FieldValue("gadah", original_SchStudent.gadah, theSchStudent.gadah))
            values.Add(New FieldValue("houseno", original_SchStudent.houseno, theSchStudent.houseno))
            values.Add(New FieldValue("addressdetail", original_SchStudent.addressdetail, theSchStudent.addressdetail))
            values.Add(New FieldValue("EmergencyTelNo1", original_SchStudent.EmergencyTelNo1, theSchStudent.EmergencyTelNo1))
            values.Add(New FieldValue("EmergencyTelNo2", original_SchStudent.EmergencyTelNo2, theSchStudent.EmergencyTelNo2))
            values.Add(New FieldValue("EmergencyTelNo3", original_SchStudent.EmergencyTelNo3, theSchStudent.EmergencyTelNo3))
            values.Add(New FieldValue("EmergencyTelNo4", original_SchStudent.EmergencyTelNo4, theSchStudent.EmergencyTelNo4))
            values.Add(New FieldValue("acdcode", original_SchStudent.acdcode, theSchStudent.acdcode))
            values.Add(New FieldValue("Stage", original_SchStudent.Stage, theSchStudent.Stage))
            values.Add(New FieldValue("GradeCode", original_SchStudent.GradeCode, theSchStudent.GradeCode))
            values.Add(New FieldValue("Class", original_SchStudent.Class, theSchStudent.Class))
            values.Add(New FieldValue("schstatus_code", original_SchStudent.schstatus_code, theSchStudent.schstatus_code))
            values.Add(New FieldValue("schstudenttypid", original_SchStudent.schstudenttypid, theSchStudent.schstudenttypid))
            values.Add(New FieldValue("BirthDate", original_SchStudent.BirthDate, theSchStudent.BirthDate))
            values.Add(New FieldValue("BirthDocNo", original_SchStudent.BirthDocNo, theSchStudent.BirthDocNo))
            values.Add(New FieldValue("birthdocdate", original_SchStudent.birthdocdate, theSchStudent.birthdocdate))
            values.Add(New FieldValue("BirthDocPlace", original_SchStudent.BirthDocPlace, theSchStudent.BirthDocPlace))
            values.Add(New FieldValue("BirthPlace", original_SchStudent.BirthPlace, theSchStudent.BirthPlace))
            values.Add(New FieldValue("Residencenumber", original_SchStudent.Residencenumber, theSchStudent.Residencenumber))
            values.Add(New FieldValue("ResidenceExpDate", original_SchStudent.ResidenceExpDate, theSchStudent.ResidenceExpDate))
            values.Add(New FieldValue("Residenceaddress", original_SchStudent.Residenceaddress, theSchStudent.Residenceaddress))
            values.Add(New FieldValue("id", original_SchStudent.id, theSchStudent.id))
            values.Add(New FieldValue("joindate", original_SchStudent.joindate, theSchStudent.joindate))
            values.Add(New FieldValue("schstsplid", original_SchStudent.schstsplid, theSchStudent.schstsplid))
            values.Add(New FieldValue("Schclasskindid", original_SchStudent.Schclasskindid, theSchStudent.Schclasskindid))
            values.Add(New FieldValue("schstclasskinddmgid", original_SchStudent.schstclasskinddmgid, theSchStudent.schstclasskinddmgid))
            values.Add(New FieldValue("Schtransferid", original_SchStudent.Schtransferid, theSchStudent.Schtransferid))
            values.Add(New FieldValue("studentsefa", original_SchStudent.studentsefa, theSchStudent.studentsefa))
            values.Add(New FieldValue("schsthlthcaseid", original_SchStudent.schsthlthcaseid, theSchStudent.schsthlthcaseid))
            values.Add(New FieldValue("Schtransferdate", original_SchStudent.Schtransferdate, theSchStudent.Schtransferdate))
            values.Add(New FieldValue("resigncases", original_SchStudent.resigncases, theSchStudent.resigncases))
            values.Add(New FieldValue("CivilidExpDate", original_SchStudent.CivilidExpDate, theSchStudent.CivilidExpDate))
            values.Add(New FieldValue("Notes", original_SchStudent.Notes, theSchStudent.Notes))
            values.Add(New FieldValue("PassportNumber", original_SchStudent.PassportNumber, theSchStudent.PassportNumber))
            values.Add(New FieldValue("PassportPlace", original_SchStudent.PassportPlace, theSchStudent.PassportPlace))
            values.Add(New FieldValue("PassportIssueDate", original_SchStudent.PassportIssueDate, theSchStudent.PassportIssueDate))
            values.Add(New FieldValue("PassportExpDate", original_SchStudent.PassportExpDate, theSchStudent.PassportExpDate))
            values.Add(New FieldValue("PhotoFileName", original_SchStudent.PhotoFileName, theSchStudent.PhotoFileName))
            values.Add(New FieldValue("PhotoLength", original_SchStudent.PhotoLength, theSchStudent.PhotoLength))
            values.Add(New FieldValue("PhotoContentType", original_SchStudent.PhotoContentType, theSchStudent.PhotoContentType))
            values.Add(New FieldValue("Picture", original_SchStudent.Picture, theSchStudent.Picture))
            values.Add(New FieldValue("PictureFileName", original_SchStudent.PictureFileName, theSchStudent.PictureFileName))
            values.Add(New FieldValue("PictureContentType", original_SchStudent.PictureContentType, theSchStudent.PictureContentType))
            values.Add(New FieldValue("PictureLength", original_SchStudent.PictureLength, theSchStudent.PictureLength))
            values.Add(New FieldValue("ModifiedBy", original_SchStudent.ModifiedBy, theSchStudent.ModifiedBy))
            values.Add(New FieldValue("ModifiedOn", original_SchStudent.ModifiedOn, theSchStudent.ModifiedOn))
            values.Add(New FieldValue("CreatedBy", original_SchStudent.CreatedBy, theSchStudent.CreatedBy))
            values.Add(New FieldValue("CreatedOn", original_SchStudent.CreatedOn, theSchStudent.CreatedOn))
            values.Add(New FieldValue("accountnumber", original_SchStudent.accountnumber, theSchStudent.accountnumber))
            values.Add(New FieldValue("fatherrecord", original_SchStudent.fatherrecord, theSchStudent.fatherrecord))
            values.Add(New FieldValue("typ", original_SchStudent.typ, theSchStudent.typ))
            values.Add(New FieldValue("ApplicationCodeauto", original_SchStudent.ApplicationCodeauto, theSchStudent.ApplicationCodeauto))
            values.Add(New FieldValue("Rerecord", original_SchStudent.Rerecord, theSchStudent.Rerecord))
            values.Add(New FieldValue("StageAppliedto", original_SchStudent.StageAppliedto, theSchStudent.StageAppliedto))
            values.Add(New FieldValue("GradeApplied", original_SchStudent.GradeApplied, theSchStudent.GradeApplied))
            values.Add(New FieldValue("AcademicYearto", original_SchStudent.AcademicYearto, theSchStudent.AcademicYearto))
            values.Add(New FieldValue("Classto", original_SchStudent.Classto, theSchStudent.Classto))
            values.Add(New FieldValue("Calsstoorder", original_SchStudent.Calsstoorder, theSchStudent.Calsstoorder))
            values.Add(New FieldValue("branchto", original_SchStudent.branchto, theSchStudent.branchto))
            values.Add(New FieldValue("Cntry_No1", original_SchStudent.Cntry_No1, theSchStudent.Cntry_No1))
            values.Add(New FieldValue("Cntry_No2", original_SchStudent.Cntry_No2, theSchStudent.Cntry_No2))
            values.Add(New FieldValue("fathercase", original_SchStudent.fathercase, theSchStudent.fathercase))
            values.Add(New FieldValue("mothercase", original_SchStudent.mothercase, theSchStudent.mothercase))
            values.Add(New FieldValue("fathersocialstatus", original_SchStudent.fathersocialstatus, theSchStudent.fathersocialstatus))
            values.Add(New FieldValue("fathername", original_SchStudent.fathername, theSchStudent.fathername))
            values.Add(New FieldValue("fathercivilid", original_SchStudent.fathercivilid, theSchStudent.fathercivilid))
            values.Add(New FieldValue("busid", original_SchStudent.busid, theSchStudent.busid))
            values.Add(New FieldValue("BUSPAY", original_SchStudent.BUSPAY, theSchStudent.BUSPAY))
            values.Add(New FieldValue("AMT00", original_SchStudent.AMT00, theSchStudent.AMT00))
            values.Add(New FieldValue("TTLADV", original_SchStudent.TTLADV, theSchStudent.TTLADV))
            values.Add(New FieldValue("TTLDEP", original_SchStudent.TTLDEP, theSchStudent.TTLDEP))
            values.Add(New FieldValue("TTLPAY", original_SchStudent.TTLPAY, theSchStudent.TTLPAY))
            values.Add(New FieldValue("TTLOTH", original_SchStudent.TTLOTH, theSchStudent.TTLOTH))
            values.Add(New FieldValue("parentsrelation", original_SchStudent.parentsrelation, theSchStudent.parentsrelation))
            values.Add(New FieldValue("Photo", original_SchStudent.Photo, theSchStudent.Photo))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theSchStudent As eZee.Data.Objects.SchStudent, ByVal original_SchStudent As eZee.Data.Objects.SchStudent, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "SchStudent"
            args.View = dataView
            args.Values = CreateFieldValues(theSchStudent, original_SchStudent)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("SchStudent", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theSchStudent)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theSchStudent As eZee.Data.Objects.SchStudent, ByVal original_SchStudent As eZee.Data.Objects.SchStudent) As Integer
            Return ExecuteAction(theSchStudent, original_SchStudent, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theSchStudent As eZee.Data.Objects.SchStudent) As Integer
            Return Update(theSchStudent, SelectSingle(theSchStudent.StudentCode))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theSchStudent As eZee.Data.Objects.SchStudent) As Integer
            Return ExecuteAction(theSchStudent, New SchStudent(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theSchStudent As eZee.Data.Objects.SchStudent) As Integer
            Return ExecuteAction(theSchStudent, theSchStudent, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
