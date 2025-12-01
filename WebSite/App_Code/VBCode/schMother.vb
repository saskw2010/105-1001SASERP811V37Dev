Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class schMother
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_MotherCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Firstname1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Firstname2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_Cntry_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Job_no As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Job_job_desc As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_WorkTel1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_WorkTel2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CivilidNumber As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CivilidExpDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_MobileNumber1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_EmergencyTelNo1 As String
        
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
        Private m_Residenceaddress1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Religion As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ReligionReljan_nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Email2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PoBox As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_State As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_TheStateState_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Area As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AreaDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Blockno As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Streetno As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Houseno As String
        
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
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property MotherCode() As Nullable(Of Long)
            Get
                Return m_MotherCode
            End Get
            Set
                m_MotherCode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property firstname1() As String
            Get
                Return m_Firstname1
            End Get
            Set
                m_Firstname1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property firstname2() As String
            Get
                Return m_Firstname2
            End Get
            Set
                m_Firstname2 = value
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
        Public Property CivilidNumber() As String
            Get
                Return m_CivilidNumber
            End Get
            Set
                m_CivilidNumber = value
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
        Public Property EmergencyTelNo1() As String
            Get
                Return m_EmergencyTelNo1
            End Get
            Set
                m_EmergencyTelNo1 = value
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
        Public Property residenceaddress1() As String
            Get
                Return m_Residenceaddress1
            End Get
            Set
                m_Residenceaddress1 = value
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
        Public Property houseno() As String
            Get
                Return m_Houseno
            End Get
            Set
                m_Houseno = value
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
                    ByVal motherCode As Nullable(Of Long),  _
                    ByVal firstname1 As String,  _
                    ByVal firstname2 As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm As String,  _
                    ByVal job_no As Nullable(Of Long),  _
                    ByVal job_job_desc As String,  _
                    ByVal workTel1 As String,  _
                    ByVal workTel2 As String,  _
                    ByVal civilidNumber As String,  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal mobileNumber1 As String,  _
                    ByVal emergencyTelNo1 As String,  _
                    ByVal kuwaitnationalityNo As String,  _
                    ByVal kuwaitnationalityDate As Nullable(Of DateTime),  _
                    ByVal passportNumber As String,  _
                    ByVal passportPlace As String,  _
                    ByVal passportissueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal residencenumber As String,  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal residenceaddress1 As String,  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal religionReljan_nm As String,  _
                    ByVal email1 As String,  _
                    ByVal email2 As String,  _
                    ByVal poBox As String,  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal theStateState_Nm As String,  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal areaDesc1 As String,  _
                    ByVal blockno As String,  _
                    ByVal streetno As String,  _
                    ByVal houseno As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime)) As List(Of eZee.Data.Objects.schMother)
            Return New schMotherFactory().Select(motherCode, firstname1, firstname2, cntry_No, cntry_Cntry_Nm, job_no, job_job_desc, workTel1, workTel2, civilidNumber, civilidExpDate, mobileNumber1, emergencyTelNo1, kuwaitnationalityNo, kuwaitnationalityDate, passportNumber, passportPlace, passportissueDate, passportExpDate, residencenumber, residenceExpDate, residenceaddress1, religion, religionReljan_nm, email1, email2, poBox, state, theStateState_Nm, area, areaDesc1, blockno, streetno, houseno, modifiedBy, modifiedOn, createdBy, createdOn)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.schMother) As List(Of eZee.Data.Objects.schMother)
            Return New schMotherFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schMother)
            Return New schMotherFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schMother)
            Return New schMotherFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schMother)
            Return New schMotherFactory().Select(filter, sort, schMotherFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schMother)
            Return New schMotherFactory().Select(filter, sort, schMotherFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schMother)
            Return New schMotherFactory().Select(filter, Nothing, schMotherFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schMother)
            Return New schMotherFactory().Select(filter, Nothing, schMotherFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schMother
            Return New schMotherFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.schMother
            Return New schMotherFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal motherCode As Nullable(Of Long)) As eZee.Data.Objects.schMother
            Return New schMotherFactory().SelectSingle(motherCode)
        End Function
        
        Public Function Insert() As Integer
            Return New schMotherFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New schMotherFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New schMotherFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("MotherCode: {0}", Me.MotherCode)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class schMotherFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("schMother")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("schMother")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("schMother")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("schMother")
            End Get
        End Property
        
        Public Shared Function Create() As schMotherFactory
            Return New schMotherFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal motherCode As Nullable(Of Long),  _
                    ByVal firstname1 As String,  _
                    ByVal firstname2 As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm As String,  _
                    ByVal job_no As Nullable(Of Long),  _
                    ByVal job_job_desc As String,  _
                    ByVal workTel1 As String,  _
                    ByVal workTel2 As String,  _
                    ByVal civilidNumber As String,  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal mobileNumber1 As String,  _
                    ByVal emergencyTelNo1 As String,  _
                    ByVal kuwaitnationalityNo As String,  _
                    ByVal kuwaitnationalityDate As Nullable(Of DateTime),  _
                    ByVal passportNumber As String,  _
                    ByVal passportPlace As String,  _
                    ByVal passportissueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal residencenumber As String,  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal residenceaddress1 As String,  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal religionReljan_nm As String,  _
                    ByVal email1 As String,  _
                    ByVal email2 As String,  _
                    ByVal poBox As String,  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal theStateState_Nm As String,  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal areaDesc1 As String,  _
                    ByVal blockno As String,  _
                    ByVal streetno As String,  _
                    ByVal houseno As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If motherCode.HasValue Then
                filter.Add(("MotherCode:=" + motherCode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(firstname1)) Then
                filter.Add(("firstname1:*" + firstname1))
            End If
            If Not (String.IsNullOrEmpty(firstname2)) Then
                filter.Add(("firstname2:*" + firstname2))
            End If
            If cntry_No.HasValue Then
                filter.Add(("Cntry_No:=" + cntry_No.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(cntry_Cntry_Nm)) Then
                filter.Add(("Cntry_Cntry_Nm:*" + cntry_Cntry_Nm))
            End If
            If job_no.HasValue Then
                filter.Add(("job_no:=" + job_no.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(job_job_desc)) Then
                filter.Add(("job_job_desc:*" + job_job_desc))
            End If
            If Not (String.IsNullOrEmpty(workTel1)) Then
                filter.Add(("WorkTel1:*" + workTel1))
            End If
            If Not (String.IsNullOrEmpty(workTel2)) Then
                filter.Add(("WorkTel2:*" + workTel2))
            End If
            If Not (String.IsNullOrEmpty(civilidNumber)) Then
                filter.Add(("CivilidNumber:*" + civilidNumber))
            End If
            If civilidExpDate.HasValue Then
                filter.Add(("CivilidExpDate:=" + civilidExpDate.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(mobileNumber1)) Then
                filter.Add(("MobileNumber1:*" + mobileNumber1))
            End If
            If Not (String.IsNullOrEmpty(emergencyTelNo1)) Then
                filter.Add(("EmergencyTelNo1:*" + emergencyTelNo1))
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
            If Not (String.IsNullOrEmpty(residenceaddress1)) Then
                filter.Add(("residenceaddress1:*" + residenceaddress1))
            End If
            If religion.HasValue Then
                filter.Add(("religion:=" + religion.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(religionReljan_nm)) Then
                filter.Add(("religionReljan_nm:*" + religionReljan_nm))
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
            If Not (String.IsNullOrEmpty(blockno)) Then
                filter.Add(("blockno:*" + blockno))
            End If
            If Not (String.IsNullOrEmpty(streetno)) Then
                filter.Add(("streetno:*" + streetno))
            End If
            If Not (String.IsNullOrEmpty(houseno)) Then
                filter.Add(("houseno:*" + houseno))
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
                    ByVal motherCode As Nullable(Of Long),  _
                    ByVal firstname1 As String,  _
                    ByVal firstname2 As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm As String,  _
                    ByVal job_no As Nullable(Of Long),  _
                    ByVal job_job_desc As String,  _
                    ByVal workTel1 As String,  _
                    ByVal workTel2 As String,  _
                    ByVal civilidNumber As String,  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal mobileNumber1 As String,  _
                    ByVal emergencyTelNo1 As String,  _
                    ByVal kuwaitnationalityNo As String,  _
                    ByVal kuwaitnationalityDate As Nullable(Of DateTime),  _
                    ByVal passportNumber As String,  _
                    ByVal passportPlace As String,  _
                    ByVal passportissueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal residencenumber As String,  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal residenceaddress1 As String,  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal religionReljan_nm As String,  _
                    ByVal email1 As String,  _
                    ByVal email2 As String,  _
                    ByVal poBox As String,  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal theStateState_Nm As String,  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal areaDesc1 As String,  _
                    ByVal blockno As String,  _
                    ByVal streetno As String,  _
                    ByVal houseno As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.schMother)
            Dim request As PageRequest = CreateRequest(motherCode, firstname1, firstname2, cntry_No, cntry_Cntry_Nm, job_no, job_job_desc, workTel1, workTel2, civilidNumber, civilidExpDate, mobileNumber1, emergencyTelNo1, kuwaitnationalityNo, kuwaitnationalityDate, passportNumber, passportPlace, passportissueDate, passportExpDate, residencenumber, residenceExpDate, residenceaddress1, religion, religionReljan_nm, email1, email2, poBox, state, theStateState_Nm, area, areaDesc1, blockno, streetno, houseno, modifiedBy, modifiedOn, createdBy, createdOn, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schMother", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schMother)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.schMother) As List(Of eZee.Data.Objects.schMother)
            Return [Select](qbe.MotherCode, qbe.firstname1, qbe.firstname2, qbe.Cntry_No, qbe.Cntry_Cntry_Nm, qbe.job_no, qbe.job_job_desc, qbe.WorkTel1, qbe.WorkTel2, qbe.CivilidNumber, qbe.CivilidExpDate, qbe.MobileNumber1, qbe.EmergencyTelNo1, qbe.KuwaitnationalityNo, qbe.KuwaitnationalityDate, qbe.PassportNumber, qbe.PassportPlace, qbe.PassportissueDate, qbe.PassportExpDate, qbe.Residencenumber, qbe.ResidenceExpDate, qbe.residenceaddress1, qbe.religion, qbe.religionReljan_nm, qbe.Email1, qbe.Email2, qbe.PoBox, qbe.State, qbe.TheStateState_Nm, qbe.area, qbe.areaDesc1, qbe.blockno, qbe.streetno, qbe.houseno, qbe.ModifiedBy, qbe.ModifiedOn, qbe.CreatedBy, qbe.CreatedOn)
        End Function
        
        Public Function SelectCount( _
                    ByVal motherCode As Nullable(Of Long),  _
                    ByVal firstname1 As String,  _
                    ByVal firstname2 As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm As String,  _
                    ByVal job_no As Nullable(Of Long),  _
                    ByVal job_job_desc As String,  _
                    ByVal workTel1 As String,  _
                    ByVal workTel2 As String,  _
                    ByVal civilidNumber As String,  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal mobileNumber1 As String,  _
                    ByVal emergencyTelNo1 As String,  _
                    ByVal kuwaitnationalityNo As String,  _
                    ByVal kuwaitnationalityDate As Nullable(Of DateTime),  _
                    ByVal passportNumber As String,  _
                    ByVal passportPlace As String,  _
                    ByVal passportissueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal residencenumber As String,  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal residenceaddress1 As String,  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal religionReljan_nm As String,  _
                    ByVal email1 As String,  _
                    ByVal email2 As String,  _
                    ByVal poBox As String,  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal theStateState_Nm As String,  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal areaDesc1 As String,  _
                    ByVal blockno As String,  _
                    ByVal streetno As String,  _
                    ByVal houseno As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(motherCode, firstname1, firstname2, cntry_No, cntry_Cntry_Nm, job_no, job_job_desc, workTel1, workTel2, civilidNumber, civilidExpDate, mobileNumber1, emergencyTelNo1, kuwaitnationalityNo, kuwaitnationalityDate, passportNumber, passportPlace, passportissueDate, passportExpDate, residencenumber, residenceExpDate, residenceaddress1, religion, religionReljan_nm, email1, email2, poBox, state, theStateState_Nm, area, areaDesc1, blockno, streetno, houseno, modifiedBy, modifiedOn, createdBy, createdOn, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schMother", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal motherCode As Nullable(Of Long),  _
                    ByVal firstname1 As String,  _
                    ByVal firstname2 As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm As String,  _
                    ByVal job_no As Nullable(Of Long),  _
                    ByVal job_job_desc As String,  _
                    ByVal workTel1 As String,  _
                    ByVal workTel2 As String,  _
                    ByVal civilidNumber As String,  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal mobileNumber1 As String,  _
                    ByVal emergencyTelNo1 As String,  _
                    ByVal kuwaitnationalityNo As String,  _
                    ByVal kuwaitnationalityDate As Nullable(Of DateTime),  _
                    ByVal passportNumber As String,  _
                    ByVal passportPlace As String,  _
                    ByVal passportissueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal residencenumber As String,  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal residenceaddress1 As String,  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal religionReljan_nm As String,  _
                    ByVal email1 As String,  _
                    ByVal email2 As String,  _
                    ByVal poBox As String,  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal theStateState_Nm As String,  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal areaDesc1 As String,  _
                    ByVal blockno As String,  _
                    ByVal streetno As String,  _
                    ByVal houseno As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime)) As List(Of eZee.Data.Objects.schMother)
            Return [Select](motherCode, firstname1, firstname2, cntry_No, cntry_Cntry_Nm, job_no, job_job_desc, workTel1, workTel2, civilidNumber, civilidExpDate, mobileNumber1, emergencyTelNo1, kuwaitnationalityNo, kuwaitnationalityDate, passportNumber, passportPlace, passportissueDate, passportExpDate, residencenumber, residenceExpDate, residenceaddress1, religion, religionReljan_nm, email1, email2, poBox, state, theStateState_Nm, area, areaDesc1, blockno, streetno, houseno, modifiedBy, modifiedOn, createdBy, createdOn, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal motherCode As Nullable(Of Long)) As eZee.Data.Objects.schMother
            Dim list As List(Of eZee.Data.Objects.schMother) = [Select](motherCode, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schMother)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("schMother", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schMother)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schMother)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schMother)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schMother
            Dim list As List(Of eZee.Data.Objects.schMother) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theschMother As eZee.Data.Objects.schMother, ByVal original_schMother As eZee.Data.Objects.schMother) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("MotherCode", original_schMother.MotherCode, theschMother.MotherCode, true))
            values.Add(New FieldValue("firstname1", original_schMother.firstname1, theschMother.firstname1))
            values.Add(New FieldValue("firstname2", original_schMother.firstname2, theschMother.firstname2))
            values.Add(New FieldValue("Cntry_No", original_schMother.Cntry_No, theschMother.Cntry_No))
            values.Add(New FieldValue("Cntry_Cntry_Nm", original_schMother.Cntry_Cntry_Nm, theschMother.Cntry_Cntry_Nm, true))
            values.Add(New FieldValue("job_no", original_schMother.job_no, theschMother.job_no))
            values.Add(New FieldValue("job_job_desc", original_schMother.job_job_desc, theschMother.job_job_desc, true))
            values.Add(New FieldValue("WorkTel1", original_schMother.WorkTel1, theschMother.WorkTel1))
            values.Add(New FieldValue("WorkTel2", original_schMother.WorkTel2, theschMother.WorkTel2))
            values.Add(New FieldValue("CivilidNumber", original_schMother.CivilidNumber, theschMother.CivilidNumber))
            values.Add(New FieldValue("CivilidExpDate", original_schMother.CivilidExpDate, theschMother.CivilidExpDate))
            values.Add(New FieldValue("MobileNumber1", original_schMother.MobileNumber1, theschMother.MobileNumber1))
            values.Add(New FieldValue("EmergencyTelNo1", original_schMother.EmergencyTelNo1, theschMother.EmergencyTelNo1))
            values.Add(New FieldValue("KuwaitnationalityNo", original_schMother.KuwaitnationalityNo, theschMother.KuwaitnationalityNo))
            values.Add(New FieldValue("KuwaitnationalityDate", original_schMother.KuwaitnationalityDate, theschMother.KuwaitnationalityDate))
            values.Add(New FieldValue("PassportNumber", original_schMother.PassportNumber, theschMother.PassportNumber))
            values.Add(New FieldValue("PassportPlace", original_schMother.PassportPlace, theschMother.PassportPlace))
            values.Add(New FieldValue("PassportissueDate", original_schMother.PassportissueDate, theschMother.PassportissueDate))
            values.Add(New FieldValue("PassportExpDate", original_schMother.PassportExpDate, theschMother.PassportExpDate))
            values.Add(New FieldValue("Residencenumber", original_schMother.Residencenumber, theschMother.Residencenumber))
            values.Add(New FieldValue("ResidenceExpDate", original_schMother.ResidenceExpDate, theschMother.ResidenceExpDate))
            values.Add(New FieldValue("residenceaddress1", original_schMother.residenceaddress1, theschMother.residenceaddress1))
            values.Add(New FieldValue("religion", original_schMother.religion, theschMother.religion))
            values.Add(New FieldValue("religionReljan_nm", original_schMother.religionReljan_nm, theschMother.religionReljan_nm, true))
            values.Add(New FieldValue("Email1", original_schMother.Email1, theschMother.Email1))
            values.Add(New FieldValue("Email2", original_schMother.Email2, theschMother.Email2))
            values.Add(New FieldValue("PoBox", original_schMother.PoBox, theschMother.PoBox))
            values.Add(New FieldValue("State", original_schMother.State, theschMother.State))
            values.Add(New FieldValue("TheStateState_Nm", original_schMother.TheStateState_Nm, theschMother.TheStateState_Nm, true))
            values.Add(New FieldValue("area", original_schMother.area, theschMother.area))
            values.Add(New FieldValue("areaDesc1", original_schMother.areaDesc1, theschMother.areaDesc1, true))
            values.Add(New FieldValue("blockno", original_schMother.blockno, theschMother.blockno))
            values.Add(New FieldValue("streetno", original_schMother.streetno, theschMother.streetno))
            values.Add(New FieldValue("houseno", original_schMother.houseno, theschMother.houseno))
            values.Add(New FieldValue("ModifiedBy", original_schMother.ModifiedBy, theschMother.ModifiedBy))
            values.Add(New FieldValue("ModifiedOn", original_schMother.ModifiedOn, theschMother.ModifiedOn))
            values.Add(New FieldValue("CreatedBy", original_schMother.CreatedBy, theschMother.CreatedBy))
            values.Add(New FieldValue("CreatedOn", original_schMother.CreatedOn, theschMother.CreatedOn))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theschMother As eZee.Data.Objects.schMother, ByVal original_schMother As eZee.Data.Objects.schMother, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "schMother"
            args.View = dataView
            args.Values = CreateFieldValues(theschMother, original_schMother)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("schMother", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theschMother)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theschMother As eZee.Data.Objects.schMother, ByVal original_schMother As eZee.Data.Objects.schMother) As Integer
            Return ExecuteAction(theschMother, original_schMother, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theschMother As eZee.Data.Objects.schMother) As Integer
            Return Update(theschMother, SelectSingle(theschMother.MotherCode))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theschMother As eZee.Data.Objects.schMother) As Integer
            Return ExecuteAction(theschMother, New schMother(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theschMother As eZee.Data.Objects.schMother) As Integer
            Return ExecuteAction(theschMother, theschMother, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
