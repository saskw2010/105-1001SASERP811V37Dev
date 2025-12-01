Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class schregacdmicforimport
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ApplicationDate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcademicYearto As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schtrnsid As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StudentCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Branch As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StageAppliedto As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeApplied As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Class As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstatus_code As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstudenttypid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No2 As Nullable(Of Long)
        
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
        Private m_Mothercase As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathercase As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Socialstatus As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Id As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schsthlthcaseid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentsefa As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Resigncases As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schclasskindid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schstclasskinddmgid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Schtransferid As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Classorder As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Passfail As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Paidrosom As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_FatherCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Civilidst As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Studentfullname As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fathername As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Cntry_No As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_DateofBirth As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Genderid As Nullable(Of Long)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ApplicationDate() As Nullable(Of DateTime)
            Get
                Return m_ApplicationDate
            End Get
            Set
                m_ApplicationDate = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property schtrnsid() As Nullable(Of Integer)
            Get
                Return m_Schtrnsid
            End Get
            Set
                m_Schtrnsid = value
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
        Public Property branch() As Nullable(Of Long)
            Get
                Return m_Branch
            End Get
            Set
                m_Branch = value
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
        Public Property mothercase() As Nullable(Of Long)
            Get
                Return m_Mothercase
            End Get
            Set
                m_Mothercase = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property socialstatus() As Nullable(Of Integer)
            Get
                Return m_Socialstatus
            End Get
            Set
                m_Socialstatus = value
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
        Public Property schsthlthcaseid() As Nullable(Of Long)
            Get
                Return m_Schsthlthcaseid
            End Get
            Set
                m_Schsthlthcaseid = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property classorder() As Nullable(Of Integer)
            Get
                Return m_Classorder
            End Get
            Set
                m_Classorder = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property passfail() As Nullable(Of Integer)
            Get
                Return m_Passfail
            End Get
            Set
                m_Passfail = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property paidrosom() As Nullable(Of Integer)
            Get
                Return m_Paidrosom
            End Get
            Set
                m_Paidrosom = value
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
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property civilidst() As Nullable(Of Long)
            Get
                Return m_Civilidst
            End Get
            Set
                m_Civilidst = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property studentfullname() As String
            Get
                Return m_Studentfullname
            End Get
            Set
                m_Studentfullname = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Fathername() As String
            Get
                Return m_Fathername
            End Get
            Set
                m_Fathername = value
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
        Public Property DateofBirth() As Nullable(Of DateTime)
            Get
                Return m_DateofBirth
            End Get
            Set
                m_DateofBirth = value
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
        
        Public Overloads Shared Function [Select]( _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Integer),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal stageAppliedto As Nullable(Of Long),  _
                    ByVal gradeApplied As Nullable(Of Long),  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal cntry_No1 As Nullable(Of Long),  _
                    ByVal cntry_No2 As Nullable(Of Long),  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal socialstatus As Nullable(Of Integer),  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal classorder As Nullable(Of Integer),  _
                    ByVal passfail As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal paidrosom As Nullable(Of Integer),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal civilidst As Nullable(Of Long),  _
                    ByVal fathername As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal dateofBirth As Nullable(Of DateTime),  _
                    ByVal genderid As Nullable(Of Long)) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Return New schregacdmicforimportFactory().Select(applicationDate, academicYearto, schtrnsid, studentCode, branch, stageAppliedto, gradeApplied, [class], schstatus_code, schstudenttypid, cntry_No1, cntry_No2, state, area, mothercase, fathercase, socialstatus, id, schsthlthcaseid, studentsefa, schclasskindid, schstclasskinddmgid, schtransferid, classorder, passfail, modifiedBy, modifiedOn, createdBy, createdOn, paidrosom, fatherCode, civilidst, fathername, cntry_No, dateofBirth, genderid)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.schregacdmicforimport) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Return New schregacdmicforimportFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Return New schregacdmicforimportFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Return New schregacdmicforimportFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Return New schregacdmicforimportFactory().Select(filter, sort, schregacdmicforimportFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Return New schregacdmicforimportFactory().Select(filter, sort, schregacdmicforimportFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Return New schregacdmicforimportFactory().Select(filter, Nothing, schregacdmicforimportFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Return New schregacdmicforimportFactory().Select(filter, Nothing, schregacdmicforimportFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schregacdmicforimport
            Return New schregacdmicforimportFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.schregacdmicforimport
            Return New schregacdmicforimportFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("")
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class schregacdmicforimportFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("schregacdmicforimport")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("schregacdmicforimport")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("schregacdmicforimport")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("schregacdmicforimport")
            End Get
        End Property
        
        Public Shared Function Create() As schregacdmicforimportFactory
            Return New schregacdmicforimportFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Integer),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal stageAppliedto As Nullable(Of Long),  _
                    ByVal gradeApplied As Nullable(Of Long),  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal cntry_No1 As Nullable(Of Long),  _
                    ByVal cntry_No2 As Nullable(Of Long),  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal socialstatus As Nullable(Of Integer),  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal classorder As Nullable(Of Integer),  _
                    ByVal passfail As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal paidrosom As Nullable(Of Integer),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal civilidst As Nullable(Of Long),  _
                    ByVal fathername As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal dateofBirth As Nullable(Of DateTime),  _
                    ByVal genderid As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If applicationDate.HasValue Then
                filter.Add(("ApplicationDate:=" + applicationDate.Value.ToString()))
            End If
            If academicYearto.HasValue Then
                filter.Add(("AcademicYearto:=" + academicYearto.Value.ToString()))
            End If
            If schtrnsid.HasValue Then
                filter.Add(("schtrnsid:=" + schtrnsid.Value.ToString()))
            End If
            If studentCode.HasValue Then
                filter.Add(("StudentCode:=" + studentCode.Value.ToString()))
            End If
            If branch.HasValue Then
                filter.Add(("branch:=" + branch.Value.ToString()))
            End If
            If stageAppliedto.HasValue Then
                filter.Add(("StageAppliedto:=" + stageAppliedto.Value.ToString()))
            End If
            If gradeApplied.HasValue Then
                filter.Add(("GradeApplied:=" + gradeApplied.Value.ToString()))
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
            If cntry_No1.HasValue Then
                filter.Add(("Cntry_No1:=" + cntry_No1.Value.ToString()))
            End If
            If cntry_No2.HasValue Then
                filter.Add(("Cntry_No2:=" + cntry_No2.Value.ToString()))
            End If
            If state.HasValue Then
                filter.Add(("state:=" + state.Value.ToString()))
            End If
            If area.HasValue Then
                filter.Add(("area:=" + area.Value.ToString()))
            End If
            If mothercase.HasValue Then
                filter.Add(("mothercase:=" + mothercase.Value.ToString()))
            End If
            If fathercase.HasValue Then
                filter.Add(("fathercase:=" + fathercase.Value.ToString()))
            End If
            If socialstatus.HasValue Then
                filter.Add(("socialstatus:=" + socialstatus.Value.ToString()))
            End If
            If id.HasValue Then
                filter.Add(("id:=" + id.Value.ToString()))
            End If
            If schsthlthcaseid.HasValue Then
                filter.Add(("schsthlthcaseid:=" + schsthlthcaseid.Value.ToString()))
            End If
            If studentsefa.HasValue Then
                filter.Add(("studentsefa:=" + studentsefa.Value.ToString()))
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
            If classorder.HasValue Then
                filter.Add(("classorder:=" + classorder.Value.ToString()))
            End If
            If passfail.HasValue Then
                filter.Add(("passfail:=" + passfail.Value.ToString()))
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
            If paidrosom.HasValue Then
                filter.Add(("paidrosom:=" + paidrosom.Value.ToString()))
            End If
            If fatherCode.HasValue Then
                filter.Add(("FatherCode:=" + fatherCode.Value.ToString()))
            End If
            If civilidst.HasValue Then
                filter.Add(("civilidst:=" + civilidst.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(fathername)) Then
                filter.Add(("Fathername:*" + fathername))
            End If
            If cntry_No.HasValue Then
                filter.Add(("Cntry_No:=" + cntry_No.Value.ToString()))
            End If
            If dateofBirth.HasValue Then
                filter.Add(("DateofBirth:=" + dateofBirth.Value.ToString()))
            End If
            If genderid.HasValue Then
                filter.Add(("Genderid:=" + genderid.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Integer),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal stageAppliedto As Nullable(Of Long),  _
                    ByVal gradeApplied As Nullable(Of Long),  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal cntry_No1 As Nullable(Of Long),  _
                    ByVal cntry_No2 As Nullable(Of Long),  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal socialstatus As Nullable(Of Integer),  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal classorder As Nullable(Of Integer),  _
                    ByVal passfail As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal paidrosom As Nullable(Of Integer),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal civilidst As Nullable(Of Long),  _
                    ByVal fathername As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal dateofBirth As Nullable(Of DateTime),  _
                    ByVal genderid As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Dim request As PageRequest = CreateRequest(applicationDate, academicYearto, schtrnsid, studentCode, branch, stageAppliedto, gradeApplied, [class], schstatus_code, schstudenttypid, cntry_No1, cntry_No2, state, area, mothercase, fathercase, socialstatus, id, schsthlthcaseid, studentsefa, schclasskindid, schstclasskinddmgid, schtransferid, classorder, passfail, modifiedBy, modifiedOn, createdBy, createdOn, paidrosom, fatherCode, civilidst, fathername, cntry_No, dateofBirth, genderid, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schregacdmicforimport", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schregacdmicforimport)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.schregacdmicforimport) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Return [Select](qbe.ApplicationDate, qbe.AcademicYearto, qbe.schtrnsid, qbe.StudentCode, qbe.branch, qbe.StageAppliedto, qbe.GradeApplied, qbe.Class, qbe.schstatus_code, qbe.schstudenttypid, qbe.Cntry_No1, qbe.Cntry_No2, qbe.state, qbe.area, qbe.mothercase, qbe.fathercase, qbe.socialstatus, qbe.id, qbe.schsthlthcaseid, qbe.studentsefa, qbe.Schclasskindid, qbe.schstclasskinddmgid, qbe.Schtransferid, qbe.classorder, qbe.passfail, qbe.ModifiedBy, qbe.ModifiedOn, qbe.CreatedBy, qbe.CreatedOn, qbe.paidrosom, qbe.FatherCode, qbe.civilidst, qbe.Fathername, qbe.Cntry_No, qbe.DateofBirth, qbe.Genderid)
        End Function
        
        Public Function SelectCount( _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Integer),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal stageAppliedto As Nullable(Of Long),  _
                    ByVal gradeApplied As Nullable(Of Long),  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal cntry_No1 As Nullable(Of Long),  _
                    ByVal cntry_No2 As Nullable(Of Long),  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal socialstatus As Nullable(Of Integer),  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal classorder As Nullable(Of Integer),  _
                    ByVal passfail As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal paidrosom As Nullable(Of Integer),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal civilidst As Nullable(Of Long),  _
                    ByVal fathername As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal dateofBirth As Nullable(Of DateTime),  _
                    ByVal genderid As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(applicationDate, academicYearto, schtrnsid, studentCode, branch, stageAppliedto, gradeApplied, [class], schstatus_code, schstudenttypid, cntry_No1, cntry_No2, state, area, mothercase, fathercase, socialstatus, id, schsthlthcaseid, studentsefa, schclasskindid, schstclasskinddmgid, schtransferid, classorder, passfail, modifiedBy, modifiedOn, createdBy, createdOn, paidrosom, fatherCode, civilidst, fathername, cntry_No, dateofBirth, genderid, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schregacdmicforimport", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal applicationDate As Nullable(Of DateTime),  _
                    ByVal academicYearto As Nullable(Of Long),  _
                    ByVal schtrnsid As Nullable(Of Integer),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal stageAppliedto As Nullable(Of Long),  _
                    ByVal gradeApplied As Nullable(Of Long),  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal cntry_No1 As Nullable(Of Long),  _
                    ByVal cntry_No2 As Nullable(Of Long),  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal mothercase As Nullable(Of Long),  _
                    ByVal fathercase As Nullable(Of Long),  _
                    ByVal socialstatus As Nullable(Of Integer),  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal classorder As Nullable(Of Integer),  _
                    ByVal passfail As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal paidrosom As Nullable(Of Integer),  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal civilidst As Nullable(Of Long),  _
                    ByVal fathername As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal dateofBirth As Nullable(Of DateTime),  _
                    ByVal genderid As Nullable(Of Long)) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Return [Select](applicationDate, academicYearto, schtrnsid, studentCode, branch, stageAppliedto, gradeApplied, [class], schstatus_code, schstudenttypid, cntry_No1, cntry_No2, state, area, mothercase, fathercase, socialstatus, id, schsthlthcaseid, studentsefa, schclasskindid, schstclasskinddmgid, schtransferid, classorder, passfail, modifiedBy, modifiedOn, createdBy, createdOn, paidrosom, fatherCode, civilidst, fathername, cntry_No, dateofBirth, genderid, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("schregacdmicforimport", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schregacdmicforimport)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schregacdmicforimport)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schregacdmicforimport
            Dim list As List(Of eZee.Data.Objects.schregacdmicforimport) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
    End Class
End Namespace
