Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class schFather
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_FatherCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathfirstname1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathfirstname2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Job_no As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Job_job_desc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_Cntry_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_MaritalStatus As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_MaritalStatusStatus_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Religion As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ReligionReljan_nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_State As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_TheStateState_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Area As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AreaDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Residenceaddress1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ResidenceTel1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ResidenceTel2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ResidenceTel3 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Companyname1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Companyname2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_WorkTel1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_WorkTel2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_WorkTel3 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_KuwaitnationalityNo As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_KuwaitnationalityDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PassportNumber As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PassportPlace As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PassportissueDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PassportExpDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Residencenumber As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ResidenceExpDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_FathCivilidNumber As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CivilidExpDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_MobileNumber1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_MobileNumber2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PagerNumber1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PagerNumber2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PoBox As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Webusername As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Webpassword As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Webblocking As Nullable(Of Boolean)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Typ As Nullable(Of Long)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property FatherCode() As Nullable(Of Long)
            Get
                Return m_FatherCode
            End Get
            Set
                m_FatherCode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fathfirstname1() As String
            Get
                Return m_Fathfirstname1
            End Get
            Set
                m_Fathfirstname1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fathfirstname2() As String
            Get
                Return m_Fathfirstname2
            End Get
            Set
                m_Fathfirstname2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property job_no() As Nullable(Of Long)
            Get
                Return m_Job_no
            End Get
            Set
                m_Job_no = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property job_job_desc() As String
            Get
                Return m_Job_job_desc
            End Get
            Set
                m_Job_job_desc = value
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
        Public Property Cntry_Cntry_Nm() As String
            Get
                Return m_Cntry_Cntry_Nm
            End Get
            Set
                m_Cntry_Cntry_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property MaritalStatus() As Nullable(Of Long)
            Get
                Return m_MaritalStatus
            End Get
            Set
                m_MaritalStatus = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property MaritalStatusStatus_Nm() As String
            Get
                Return m_MaritalStatusStatus_Nm
            End Get
            Set
                m_MaritalStatusStatus_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property religion() As Nullable(Of Long)
            Get
                Return m_Religion
            End Get
            Set
                m_Religion = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property religionReljan_nm() As String
            Get
                Return m_ReligionReljan_nm
            End Get
            Set
                m_ReligionReljan_nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property State() As Nullable(Of Long)
            Get
                Return m_State
            End Get
            Set
                m_State = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property TheStateState_Nm() As String
            Get
                Return m_TheStateState_Nm
            End Get
            Set
                m_TheStateState_Nm = value
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
        Public Property residenceaddress1() As String
            Get
                Return m_Residenceaddress1
            End Get
            Set
                m_Residenceaddress1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ResidenceTel1() As String
            Get
                Return m_ResidenceTel1
            End Get
            Set
                m_ResidenceTel1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ResidenceTel2() As String
            Get
                Return m_ResidenceTel2
            End Get
            Set
                m_ResidenceTel2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ResidenceTel3() As String
            Get
                Return m_ResidenceTel3
            End Get
            Set
                m_ResidenceTel3 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property companyname1() As String
            Get
                Return m_Companyname1
            End Get
            Set
                m_Companyname1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property companyname2() As String
            Get
                Return m_Companyname2
            End Get
            Set
                m_Companyname2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property WorkTel1() As String
            Get
                Return m_WorkTel1
            End Get
            Set
                m_WorkTel1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property WorkTel2() As String
            Get
                Return m_WorkTel2
            End Get
            Set
                m_WorkTel2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property WorkTel3() As String
            Get
                Return m_WorkTel3
            End Get
            Set
                m_WorkTel3 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property KuwaitnationalityNo() As String
            Get
                Return m_KuwaitnationalityNo
            End Get
            Set
                m_KuwaitnationalityNo = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property KuwaitnationalityDate() As Nullable(Of DateTime)
            Get
                Return m_KuwaitnationalityDate
            End Get
            Set
                m_KuwaitnationalityDate = value
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
        Public Property PassportissueDate() As Nullable(Of DateTime)
            Get
                Return m_PassportissueDate
            End Get
            Set
                m_PassportissueDate = value
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
        Public Property fathCivilidNumber() As String
            Get
                Return m_FathCivilidNumber
            End Get
            Set
                m_FathCivilidNumber = value
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
        Public Property MobileNumber1() As String
            Get
                Return m_MobileNumber1
            End Get
            Set
                m_MobileNumber1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property MobileNumber2() As String
            Get
                Return m_MobileNumber2
            End Get
            Set
                m_MobileNumber2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property PagerNumber1() As String
            Get
                Return m_PagerNumber1
            End Get
            Set
                m_PagerNumber1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property PagerNumber2() As String
            Get
                Return m_PagerNumber2
            End Get
            Set
                m_PagerNumber2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Email1() As String
            Get
                Return m_Email1
            End Get
            Set
                m_Email1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Email2() As String
            Get
                Return m_Email2
            End Get
            Set
                m_Email2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property PoBox() As String
            Get
                Return m_PoBox
            End Get
            Set
                m_PoBox = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property webusername() As String
            Get
                Return m_Webusername
            End Get
            Set
                m_Webusername = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property webpassword() As String
            Get
                Return m_Webpassword
            End Get
            Set
                m_Webpassword = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property webblocking() As Nullable(Of Boolean)
            Get
                Return m_Webblocking
            End Get
            Set
                m_Webblocking = value
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
        Public Property typ() As Nullable(Of Long)
            Get
                Return m_Typ
            End Get
            Set
                m_Typ = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select]( _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal fathfirstname1 As String,  _
                    ByVal fathfirstname2 As String,  _
                    ByVal job_no As Nullable(Of Long),  _
                    ByVal job_job_desc As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm As String,  _
                    ByVal maritalStatus As Nullable(Of Long),  _
                    ByVal maritalStatusStatus_Nm As String,  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal religionReljan_nm As String,  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal theStateState_Nm As String,  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal areaDesc1 As String,  _
                    ByVal residenceTel1 As String,  _
                    ByVal residenceTel2 As String,  _
                    ByVal residenceTel3 As String,  _
                    ByVal companyname1 As String,  _
                    ByVal companyname2 As String,  _
                    ByVal workTel1 As String,  _
                    ByVal workTel2 As String,  _
                    ByVal workTel3 As String,  _
                    ByVal kuwaitnationalityNo As String,  _
                    ByVal kuwaitnationalityDate As Nullable(Of DateTime),  _
                    ByVal passportNumber As String,  _
                    ByVal passportPlace As String,  _
                    ByVal passportissueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal residencenumber As String,  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal fathCivilidNumber As String,  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal mobileNumber1 As String,  _
                    ByVal mobileNumber2 As String,  _
                    ByVal pagerNumber1 As String,  _
                    ByVal pagerNumber2 As String,  _
                    ByVal email1 As String,  _
                    ByVal email2 As String,  _
                    ByVal poBox As String,  _
                    ByVal webusername As String,  _
                    ByVal webpassword As String,  _
                    ByVal webblocking As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal typ As Nullable(Of Long)) As List(Of eZee.Data.Objects.schFather)
            Return New schFatherFactory().Select(fatherCode, fathfirstname1, fathfirstname2, job_no, job_job_desc, cntry_No, cntry_Cntry_Nm, maritalStatus, maritalStatusStatus_Nm, religion, religionReljan_nm, state, theStateState_Nm, area, areaDesc1, residenceTel1, residenceTel2, residenceTel3, companyname1, companyname2, workTel1, workTel2, workTel3, kuwaitnationalityNo, kuwaitnationalityDate, passportNumber, passportPlace, passportissueDate, passportExpDate, residencenumber, residenceExpDate, fathCivilidNumber, civilidExpDate, mobileNumber1, mobileNumber2, pagerNumber1, pagerNumber2, email1, email2, poBox, webusername, webpassword, webblocking, modifiedBy, modifiedOn, createdBy, createdOn, typ)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.schFather) As List(Of eZee.Data.Objects.schFather)
            Return New schFatherFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schFather)
            Return New schFatherFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schFather)
            Return New schFatherFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schFather)
            Return New schFatherFactory().Select(filter, sort, schFatherFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schFather)
            Return New schFatherFactory().Select(filter, sort, schFatherFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schFather)
            Return New schFatherFactory().Select(filter, Nothing, schFatherFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schFather)
            Return New schFatherFactory().Select(filter, Nothing, schFatherFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schFather
            Return New schFatherFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.schFather
            Return New schFatherFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal fatherCode As Nullable(Of Long)) As eZee.Data.Objects.schFather
            Return New schFatherFactory().SelectSingle(fatherCode)
        End Function
        
        Public Function Insert() As Integer
            Return New schFatherFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New schFatherFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New schFatherFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("FatherCode: {0}", Me.FatherCode)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class schFatherFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("schFather")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("schFather")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("schFather")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("schFather")
            End Get
        End Property
        
        Public Shared Function Create() As schFatherFactory
            Return New schFatherFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal fathfirstname1 As String,  _
                    ByVal fathfirstname2 As String,  _
                    ByVal job_no As Nullable(Of Long),  _
                    ByVal job_job_desc As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm As String,  _
                    ByVal maritalStatus As Nullable(Of Long),  _
                    ByVal maritalStatusStatus_Nm As String,  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal religionReljan_nm As String,  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal theStateState_Nm As String,  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal areaDesc1 As String,  _
                    ByVal residenceTel1 As String,  _
                    ByVal residenceTel2 As String,  _
                    ByVal residenceTel3 As String,  _
                    ByVal companyname1 As String,  _
                    ByVal companyname2 As String,  _
                    ByVal workTel1 As String,  _
                    ByVal workTel2 As String,  _
                    ByVal workTel3 As String,  _
                    ByVal kuwaitnationalityNo As String,  _
                    ByVal kuwaitnationalityDate As Nullable(Of DateTime),  _
                    ByVal passportNumber As String,  _
                    ByVal passportPlace As String,  _
                    ByVal passportissueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal residencenumber As String,  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal fathCivilidNumber As String,  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal mobileNumber1 As String,  _
                    ByVal mobileNumber2 As String,  _
                    ByVal pagerNumber1 As String,  _
                    ByVal pagerNumber2 As String,  _
                    ByVal email1 As String,  _
                    ByVal email2 As String,  _
                    ByVal poBox As String,  _
                    ByVal webusername As String,  _
                    ByVal webpassword As String,  _
                    ByVal webblocking As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal typ As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If fatherCode.HasValue Then
                filter.Add(("FatherCode:=" + fatherCode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(fathfirstname1)) Then
                filter.Add(("fathfirstname1:*" + fathfirstname1))
            End If
            If Not (String.IsNullOrEmpty(fathfirstname2)) Then
                filter.Add(("fathfirstname2:*" + fathfirstname2))
            End If
            If job_no.HasValue Then
                filter.Add(("job_no:=" + job_no.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(job_job_desc)) Then
                filter.Add(("job_job_desc:*" + job_job_desc))
            End If
            If cntry_No.HasValue Then
                filter.Add(("Cntry_No:=" + cntry_No.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(cntry_Cntry_Nm)) Then
                filter.Add(("Cntry_Cntry_Nm:*" + cntry_Cntry_Nm))
            End If
            If maritalStatus.HasValue Then
                filter.Add(("MaritalStatus:=" + maritalStatus.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(maritalStatusStatus_Nm)) Then
                filter.Add(("MaritalStatusStatus_Nm:*" + maritalStatusStatus_Nm))
            End If
            If religion.HasValue Then
                filter.Add(("religion:=" + religion.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(religionReljan_nm)) Then
                filter.Add(("religionReljan_nm:*" + religionReljan_nm))
            End If
            If state.HasValue Then
                filter.Add(("State:=" + state.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(theStateState_Nm)) Then
                filter.Add(("TheStateState_Nm:*" + theStateState_Nm))
            End If
            If area.HasValue Then
                filter.Add(("area:=" + area.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(areaDesc1)) Then
                filter.Add(("areaDesc1:*" + areaDesc1))
            End If
            If Not (String.IsNullOrEmpty(residenceTel1)) Then
                filter.Add(("ResidenceTel1:*" + residenceTel1))
            End If
            If Not (String.IsNullOrEmpty(residenceTel2)) Then
                filter.Add(("ResidenceTel2:*" + residenceTel2))
            End If
            If Not (String.IsNullOrEmpty(residenceTel3)) Then
                filter.Add(("ResidenceTel3:*" + residenceTel3))
            End If
            If Not (String.IsNullOrEmpty(companyname1)) Then
                filter.Add(("companyname1:*" + companyname1))
            End If
            If Not (String.IsNullOrEmpty(companyname2)) Then
                filter.Add(("companyname2:*" + companyname2))
            End If
            If Not (String.IsNullOrEmpty(workTel1)) Then
                filter.Add(("WorkTel1:*" + workTel1))
            End If
            If Not (String.IsNullOrEmpty(workTel2)) Then
                filter.Add(("WorkTel2:*" + workTel2))
            End If
            If Not (String.IsNullOrEmpty(workTel3)) Then
                filter.Add(("WorkTel3:*" + workTel3))
            End If
            If Not (String.IsNullOrEmpty(kuwaitnationalityNo)) Then
                filter.Add(("KuwaitnationalityNo:*" + kuwaitnationalityNo))
            End If
            If kuwaitnationalityDate.HasValue Then
                filter.Add(("KuwaitnationalityDate:=" + kuwaitnationalityDate.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(passportNumber)) Then
                filter.Add(("PassportNumber:*" + passportNumber))
            End If
            If Not (String.IsNullOrEmpty(passportPlace)) Then
                filter.Add(("PassportPlace:*" + passportPlace))
            End If
            If passportissueDate.HasValue Then
                filter.Add(("PassportissueDate:=" + passportissueDate.Value.ToString()))
            End If
            If passportExpDate.HasValue Then
                filter.Add(("PassportExpDate:=" + passportExpDate.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(residencenumber)) Then
                filter.Add(("Residencenumber:*" + residencenumber))
            End If
            If residenceExpDate.HasValue Then
                filter.Add(("ResidenceExpDate:=" + residenceExpDate.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(fathCivilidNumber)) Then
                filter.Add(("fathCivilidNumber:*" + fathCivilidNumber))
            End If
            If civilidExpDate.HasValue Then
                filter.Add(("CivilidExpDate:=" + civilidExpDate.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(mobileNumber1)) Then
                filter.Add(("MobileNumber1:*" + mobileNumber1))
            End If
            If Not (String.IsNullOrEmpty(mobileNumber2)) Then
                filter.Add(("MobileNumber2:*" + mobileNumber2))
            End If
            If Not (String.IsNullOrEmpty(pagerNumber1)) Then
                filter.Add(("PagerNumber1:*" + pagerNumber1))
            End If
            If Not (String.IsNullOrEmpty(pagerNumber2)) Then
                filter.Add(("PagerNumber2:*" + pagerNumber2))
            End If
            If Not (String.IsNullOrEmpty(email1)) Then
                filter.Add(("Email1:*" + email1))
            End If
            If Not (String.IsNullOrEmpty(email2)) Then
                filter.Add(("Email2:*" + email2))
            End If
            If Not (String.IsNullOrEmpty(poBox)) Then
                filter.Add(("PoBox:*" + poBox))
            End If
            If Not (String.IsNullOrEmpty(webusername)) Then
                filter.Add(("webusername:*" + webusername))
            End If
            If Not (String.IsNullOrEmpty(webpassword)) Then
                filter.Add(("webpassword:*" + webpassword))
            End If
            If webblocking.HasValue Then
                filter.Add(("webblocking:=" + webblocking.Value.ToString()))
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
            If typ.HasValue Then
                filter.Add(("typ:=" + typ.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal fathfirstname1 As String,  _
                    ByVal fathfirstname2 As String,  _
                    ByVal job_no As Nullable(Of Long),  _
                    ByVal job_job_desc As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm As String,  _
                    ByVal maritalStatus As Nullable(Of Long),  _
                    ByVal maritalStatusStatus_Nm As String,  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal religionReljan_nm As String,  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal theStateState_Nm As String,  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal areaDesc1 As String,  _
                    ByVal residenceTel1 As String,  _
                    ByVal residenceTel2 As String,  _
                    ByVal residenceTel3 As String,  _
                    ByVal companyname1 As String,  _
                    ByVal companyname2 As String,  _
                    ByVal workTel1 As String,  _
                    ByVal workTel2 As String,  _
                    ByVal workTel3 As String,  _
                    ByVal kuwaitnationalityNo As String,  _
                    ByVal kuwaitnationalityDate As Nullable(Of DateTime),  _
                    ByVal passportNumber As String,  _
                    ByVal passportPlace As String,  _
                    ByVal passportissueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal residencenumber As String,  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal fathCivilidNumber As String,  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal mobileNumber1 As String,  _
                    ByVal mobileNumber2 As String,  _
                    ByVal pagerNumber1 As String,  _
                    ByVal pagerNumber2 As String,  _
                    ByVal email1 As String,  _
                    ByVal email2 As String,  _
                    ByVal poBox As String,  _
                    ByVal webusername As String,  _
                    ByVal webpassword As String,  _
                    ByVal webblocking As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal typ As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.schFather)
            Dim request As PageRequest = CreateRequest(fatherCode, fathfirstname1, fathfirstname2, job_no, job_job_desc, cntry_No, cntry_Cntry_Nm, maritalStatus, maritalStatusStatus_Nm, religion, religionReljan_nm, state, theStateState_Nm, area, areaDesc1, residenceTel1, residenceTel2, residenceTel3, companyname1, companyname2, workTel1, workTel2, workTel3, kuwaitnationalityNo, kuwaitnationalityDate, passportNumber, passportPlace, passportissueDate, passportExpDate, residencenumber, residenceExpDate, fathCivilidNumber, civilidExpDate, mobileNumber1, mobileNumber2, pagerNumber1, pagerNumber2, email1, email2, poBox, webusername, webpassword, webblocking, modifiedBy, modifiedOn, createdBy, createdOn, typ, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schFather", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schFather)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.schFather) As List(Of eZee.Data.Objects.schFather)
            Return [Select](qbe.FatherCode, qbe.fathfirstname1, qbe.fathfirstname2, qbe.job_no, qbe.job_job_desc, qbe.Cntry_No, qbe.Cntry_Cntry_Nm, qbe.MaritalStatus, qbe.MaritalStatusStatus_Nm, qbe.religion, qbe.religionReljan_nm, qbe.State, qbe.TheStateState_Nm, qbe.area, qbe.areaDesc1, qbe.ResidenceTel1, qbe.ResidenceTel2, qbe.ResidenceTel3, qbe.companyname1, qbe.companyname2, qbe.WorkTel1, qbe.WorkTel2, qbe.WorkTel3, qbe.KuwaitnationalityNo, qbe.KuwaitnationalityDate, qbe.PassportNumber, qbe.PassportPlace, qbe.PassportissueDate, qbe.PassportExpDate, qbe.Residencenumber, qbe.ResidenceExpDate, qbe.fathCivilidNumber, qbe.CivilidExpDate, qbe.MobileNumber1, qbe.MobileNumber2, qbe.PagerNumber1, qbe.PagerNumber2, qbe.Email1, qbe.Email2, qbe.PoBox, qbe.webusername, qbe.webpassword, qbe.webblocking, qbe.ModifiedBy, qbe.ModifiedOn, qbe.CreatedBy, qbe.CreatedOn, qbe.typ)
        End Function
        
        Public Function SelectCount( _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal fathfirstname1 As String,  _
                    ByVal fathfirstname2 As String,  _
                    ByVal job_no As Nullable(Of Long),  _
                    ByVal job_job_desc As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm As String,  _
                    ByVal maritalStatus As Nullable(Of Long),  _
                    ByVal maritalStatusStatus_Nm As String,  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal religionReljan_nm As String,  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal theStateState_Nm As String,  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal areaDesc1 As String,  _
                    ByVal residenceTel1 As String,  _
                    ByVal residenceTel2 As String,  _
                    ByVal residenceTel3 As String,  _
                    ByVal companyname1 As String,  _
                    ByVal companyname2 As String,  _
                    ByVal workTel1 As String,  _
                    ByVal workTel2 As String,  _
                    ByVal workTel3 As String,  _
                    ByVal kuwaitnationalityNo As String,  _
                    ByVal kuwaitnationalityDate As Nullable(Of DateTime),  _
                    ByVal passportNumber As String,  _
                    ByVal passportPlace As String,  _
                    ByVal passportissueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal residencenumber As String,  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal fathCivilidNumber As String,  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal mobileNumber1 As String,  _
                    ByVal mobileNumber2 As String,  _
                    ByVal pagerNumber1 As String,  _
                    ByVal pagerNumber2 As String,  _
                    ByVal email1 As String,  _
                    ByVal email2 As String,  _
                    ByVal poBox As String,  _
                    ByVal webusername As String,  _
                    ByVal webpassword As String,  _
                    ByVal webblocking As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal typ As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(fatherCode, fathfirstname1, fathfirstname2, job_no, job_job_desc, cntry_No, cntry_Cntry_Nm, maritalStatus, maritalStatusStatus_Nm, religion, religionReljan_nm, state, theStateState_Nm, area, areaDesc1, residenceTel1, residenceTel2, residenceTel3, companyname1, companyname2, workTel1, workTel2, workTel3, kuwaitnationalityNo, kuwaitnationalityDate, passportNumber, passportPlace, passportissueDate, passportExpDate, residencenumber, residenceExpDate, fathCivilidNumber, civilidExpDate, mobileNumber1, mobileNumber2, pagerNumber1, pagerNumber2, email1, email2, poBox, webusername, webpassword, webblocking, modifiedBy, modifiedOn, createdBy, createdOn, typ, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schFather", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal fathfirstname1 As String,  _
                    ByVal fathfirstname2 As String,  _
                    ByVal job_no As Nullable(Of Long),  _
                    ByVal job_job_desc As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm As String,  _
                    ByVal maritalStatus As Nullable(Of Long),  _
                    ByVal maritalStatusStatus_Nm As String,  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal religionReljan_nm As String,  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal theStateState_Nm As String,  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal areaDesc1 As String,  _
                    ByVal residenceTel1 As String,  _
                    ByVal residenceTel2 As String,  _
                    ByVal residenceTel3 As String,  _
                    ByVal companyname1 As String,  _
                    ByVal companyname2 As String,  _
                    ByVal workTel1 As String,  _
                    ByVal workTel2 As String,  _
                    ByVal workTel3 As String,  _
                    ByVal kuwaitnationalityNo As String,  _
                    ByVal kuwaitnationalityDate As Nullable(Of DateTime),  _
                    ByVal passportNumber As String,  _
                    ByVal passportPlace As String,  _
                    ByVal passportissueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal residencenumber As String,  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal fathCivilidNumber As String,  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal mobileNumber1 As String,  _
                    ByVal mobileNumber2 As String,  _
                    ByVal pagerNumber1 As String,  _
                    ByVal pagerNumber2 As String,  _
                    ByVal email1 As String,  _
                    ByVal email2 As String,  _
                    ByVal poBox As String,  _
                    ByVal webusername As String,  _
                    ByVal webpassword As String,  _
                    ByVal webblocking As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal typ As Nullable(Of Long)) As List(Of eZee.Data.Objects.schFather)
            Return [Select](fatherCode, fathfirstname1, fathfirstname2, job_no, job_job_desc, cntry_No, cntry_Cntry_Nm, maritalStatus, maritalStatusStatus_Nm, religion, religionReljan_nm, state, theStateState_Nm, area, areaDesc1, residenceTel1, residenceTel2, residenceTel3, companyname1, companyname2, workTel1, workTel2, workTel3, kuwaitnationalityNo, kuwaitnationalityDate, passportNumber, passportPlace, passportissueDate, passportExpDate, residencenumber, residenceExpDate, fathCivilidNumber, civilidExpDate, mobileNumber1, mobileNumber2, pagerNumber1, pagerNumber2, email1, email2, poBox, webusername, webpassword, webblocking, modifiedBy, modifiedOn, createdBy, createdOn, typ, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal fatherCode As Nullable(Of Long)) As eZee.Data.Objects.schFather
            Dim list As List(Of eZee.Data.Objects.schFather) = [Select](fatherCode, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schFather)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("schFather", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schFather)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schFather)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schFather)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schFather
            Dim list As List(Of eZee.Data.Objects.schFather) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theschFather As eZee.Data.Objects.schFather, ByVal original_schFather As eZee.Data.Objects.schFather) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("FatherCode", original_schFather.FatherCode, theschFather.FatherCode, true))
            values.Add(New FieldValue("fathfirstname1", original_schFather.fathfirstname1, theschFather.fathfirstname1))
            values.Add(New FieldValue("fathfirstname2", original_schFather.fathfirstname2, theschFather.fathfirstname2))
            values.Add(New FieldValue("job_no", original_schFather.job_no, theschFather.job_no))
            values.Add(New FieldValue("job_job_desc", original_schFather.job_job_desc, theschFather.job_job_desc, true))
            values.Add(New FieldValue("Cntry_No", original_schFather.Cntry_No, theschFather.Cntry_No))
            values.Add(New FieldValue("Cntry_Cntry_Nm", original_schFather.Cntry_Cntry_Nm, theschFather.Cntry_Cntry_Nm, true))
            values.Add(New FieldValue("MaritalStatus", original_schFather.MaritalStatus, theschFather.MaritalStatus))
            values.Add(New FieldValue("MaritalStatusStatus_Nm", original_schFather.MaritalStatusStatus_Nm, theschFather.MaritalStatusStatus_Nm, true))
            values.Add(New FieldValue("religion", original_schFather.religion, theschFather.religion))
            values.Add(New FieldValue("religionReljan_nm", original_schFather.religionReljan_nm, theschFather.religionReljan_nm, true))
            values.Add(New FieldValue("State", original_schFather.State, theschFather.State))
            values.Add(New FieldValue("TheStateState_Nm", original_schFather.TheStateState_Nm, theschFather.TheStateState_Nm, true))
            values.Add(New FieldValue("area", original_schFather.area, theschFather.area))
            values.Add(New FieldValue("areaDesc1", original_schFather.areaDesc1, theschFather.areaDesc1, true))
            values.Add(New FieldValue("residenceaddress1", original_schFather.residenceaddress1, theschFather.residenceaddress1))
            values.Add(New FieldValue("ResidenceTel1", original_schFather.ResidenceTel1, theschFather.ResidenceTel1))
            values.Add(New FieldValue("ResidenceTel2", original_schFather.ResidenceTel2, theschFather.ResidenceTel2))
            values.Add(New FieldValue("ResidenceTel3", original_schFather.ResidenceTel3, theschFather.ResidenceTel3))
            values.Add(New FieldValue("companyname1", original_schFather.companyname1, theschFather.companyname1))
            values.Add(New FieldValue("companyname2", original_schFather.companyname2, theschFather.companyname2))
            values.Add(New FieldValue("WorkTel1", original_schFather.WorkTel1, theschFather.WorkTel1))
            values.Add(New FieldValue("WorkTel2", original_schFather.WorkTel2, theschFather.WorkTel2))
            values.Add(New FieldValue("WorkTel3", original_schFather.WorkTel3, theschFather.WorkTel3))
            values.Add(New FieldValue("KuwaitnationalityNo", original_schFather.KuwaitnationalityNo, theschFather.KuwaitnationalityNo))
            values.Add(New FieldValue("KuwaitnationalityDate", original_schFather.KuwaitnationalityDate, theschFather.KuwaitnationalityDate))
            values.Add(New FieldValue("PassportNumber", original_schFather.PassportNumber, theschFather.PassportNumber))
            values.Add(New FieldValue("PassportPlace", original_schFather.PassportPlace, theschFather.PassportPlace))
            values.Add(New FieldValue("PassportissueDate", original_schFather.PassportissueDate, theschFather.PassportissueDate))
            values.Add(New FieldValue("PassportExpDate", original_schFather.PassportExpDate, theschFather.PassportExpDate))
            values.Add(New FieldValue("Residencenumber", original_schFather.Residencenumber, theschFather.Residencenumber))
            values.Add(New FieldValue("ResidenceExpDate", original_schFather.ResidenceExpDate, theschFather.ResidenceExpDate))
            values.Add(New FieldValue("fathCivilidNumber", original_schFather.fathCivilidNumber, theschFather.fathCivilidNumber))
            values.Add(New FieldValue("CivilidExpDate", original_schFather.CivilidExpDate, theschFather.CivilidExpDate))
            values.Add(New FieldValue("MobileNumber1", original_schFather.MobileNumber1, theschFather.MobileNumber1))
            values.Add(New FieldValue("MobileNumber2", original_schFather.MobileNumber2, theschFather.MobileNumber2))
            values.Add(New FieldValue("PagerNumber1", original_schFather.PagerNumber1, theschFather.PagerNumber1))
            values.Add(New FieldValue("PagerNumber2", original_schFather.PagerNumber2, theschFather.PagerNumber2))
            values.Add(New FieldValue("Email1", original_schFather.Email1, theschFather.Email1))
            values.Add(New FieldValue("Email2", original_schFather.Email2, theschFather.Email2))
            values.Add(New FieldValue("PoBox", original_schFather.PoBox, theschFather.PoBox))
            values.Add(New FieldValue("webusername", original_schFather.webusername, theschFather.webusername))
            values.Add(New FieldValue("webpassword", original_schFather.webpassword, theschFather.webpassword))
            values.Add(New FieldValue("webblocking", original_schFather.webblocking, theschFather.webblocking))
            values.Add(New FieldValue("ModifiedBy", original_schFather.ModifiedBy, theschFather.ModifiedBy))
            values.Add(New FieldValue("ModifiedOn", original_schFather.ModifiedOn, theschFather.ModifiedOn))
            values.Add(New FieldValue("CreatedBy", original_schFather.CreatedBy, theschFather.CreatedBy))
            values.Add(New FieldValue("CreatedOn", original_schFather.CreatedOn, theschFather.CreatedOn))
            values.Add(New FieldValue("typ", original_schFather.typ, theschFather.typ))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theschFather As eZee.Data.Objects.schFather, ByVal original_schFather As eZee.Data.Objects.schFather, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "schFather"
            args.View = dataView
            args.Values = CreateFieldValues(theschFather, original_schFather)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("schFather", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theschFather)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theschFather As eZee.Data.Objects.schFather, ByVal original_schFather As eZee.Data.Objects.schFather) As Integer
            Return ExecuteAction(theschFather, original_schFather, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theschFather As eZee.Data.Objects.schFather) As Integer
            Return Update(theschFather, SelectSingle(theschFather.FatherCode))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theschFather As eZee.Data.Objects.schFather) As Integer
            Return ExecuteAction(theschFather, New schFather(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theschFather As eZee.Data.Objects.schFather) As Integer
            Return ExecuteAction(theschFather, theschFather, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
