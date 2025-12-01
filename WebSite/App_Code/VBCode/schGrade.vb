Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class schGrade
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GradeCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ShortDesc2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Desc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Desc2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Acdcode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcdAcademicYear As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcdGlFinperiodFin_period_info As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcdGlFinperiodaccountnumberAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Totutionsfees As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Books As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Totalfees As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Registerationfees As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Registrationstartdate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Firstinstalmmentdate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Firstinstalmmentpercent1 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Secondinstalmmentdate2 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Secondinstalmmentpercent2 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Thirdinstalmmentdate21 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Thirdinstalmmentpercent21 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fourthinstalmmentdate3 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Fourthinstalmmentpercent3 As Nullable(Of Decimal)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Agecalculatedate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Ageexpectedbyyear As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Ageexpectedbymonth As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ModifiedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedBy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CreatedOn As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StageCode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StageShortDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Ageexpectedbyyear1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Ageexpectedbymonth1 As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Nextgrade As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_NextStageCode As Nullable(Of Long)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property GradeCode() As Nullable(Of Long)
            Get
                Return m_GradeCode
            End Get
            Set
                m_GradeCode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ShortDesc1() As String
            Get
                Return m_ShortDesc1
            End Get
            Set
                m_ShortDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ShortDesc2() As String
            Get
                Return m_ShortDesc2
            End Get
            Set
                m_ShortDesc2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Desc1() As String
            Get
                Return m_Desc1
            End Get
            Set
                m_Desc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Desc2() As String
            Get
                Return m_Desc2
            End Get
            Set
                m_Desc2 = value
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
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Totutionsfees() As Nullable(Of Decimal)
            Get
                Return m_Totutionsfees
            End Get
            Set
                m_Totutionsfees = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Books() As Nullable(Of Decimal)
            Get
                Return m_Books
            End Get
            Set
                m_Books = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Totalfees() As Nullable(Of Decimal)
            Get
                Return m_Totalfees
            End Get
            Set
                m_Totalfees = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property registerationfees() As Nullable(Of Decimal)
            Get
                Return m_Registerationfees
            End Get
            Set
                m_Registerationfees = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property registrationstartdate() As Nullable(Of DateTime)
            Get
                Return m_Registrationstartdate
            End Get
            Set
                m_Registrationstartdate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Firstinstalmmentdate() As Nullable(Of DateTime)
            Get
                Return m_Firstinstalmmentdate
            End Get
            Set
                m_Firstinstalmmentdate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Firstinstalmmentpercent1() As Nullable(Of Decimal)
            Get
                Return m_Firstinstalmmentpercent1
            End Get
            Set
                m_Firstinstalmmentpercent1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Secondinstalmmentdate2() As Nullable(Of DateTime)
            Get
                Return m_Secondinstalmmentdate2
            End Get
            Set
                m_Secondinstalmmentdate2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Secondinstalmmentpercent2() As Nullable(Of Decimal)
            Get
                Return m_Secondinstalmmentpercent2
            End Get
            Set
                m_Secondinstalmmentpercent2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property thirdinstalmmentdate21() As Nullable(Of DateTime)
            Get
                Return m_Thirdinstalmmentdate21
            End Get
            Set
                m_Thirdinstalmmentdate21 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property thirdinstalmmentpercent21() As Nullable(Of Decimal)
            Get
                Return m_Thirdinstalmmentpercent21
            End Get
            Set
                m_Thirdinstalmmentpercent21 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fourthinstalmmentdate3() As Nullable(Of DateTime)
            Get
                Return m_Fourthinstalmmentdate3
            End Get
            Set
                m_Fourthinstalmmentdate3 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property fourthinstalmmentpercent3() As Nullable(Of Decimal)
            Get
                Return m_Fourthinstalmmentpercent3
            End Get
            Set
                m_Fourthinstalmmentpercent3 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property agecalculatedate() As Nullable(Of DateTime)
            Get
                Return m_Agecalculatedate
            End Get
            Set
                m_Agecalculatedate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ageexpectedbyyear() As Nullable(Of Long)
            Get
                Return m_Ageexpectedbyyear
            End Get
            Set
                m_Ageexpectedbyyear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ageexpectedbymonth() As Nullable(Of Long)
            Get
                Return m_Ageexpectedbymonth
            End Get
            Set
                m_Ageexpectedbymonth = value
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
        Public Property StageCode() As Nullable(Of Long)
            Get
                Return m_StageCode
            End Get
            Set
                m_StageCode = value
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
        Public Property ageexpectedbyyear1() As Nullable(Of Long)
            Get
                Return m_Ageexpectedbyyear1
            End Get
            Set
                m_Ageexpectedbyyear1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ageexpectedbymonth1() As Nullable(Of Long)
            Get
                Return m_Ageexpectedbymonth1
            End Get
            Set
                m_Ageexpectedbymonth1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property nextgrade() As Nullable(Of Long)
            Get
                Return m_Nextgrade
            End Get
            Set
                m_Nextgrade = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property nextStageCode() As Nullable(Of Long)
            Get
                Return m_NextStageCode
            End Get
            Set
                m_NextStageCode = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select]( _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal shortDesc1 As String,  _
                    ByVal shortDesc2 As String,  _
                    ByVal desc1 As String,  _
                    ByVal desc2 As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal totutionsfees As Nullable(Of Decimal),  _
                    ByVal books As Nullable(Of Decimal),  _
                    ByVal totalfees As Nullable(Of Decimal),  _
                    ByVal registerationfees As Nullable(Of Decimal),  _
                    ByVal registrationstartdate As Nullable(Of DateTime),  _
                    ByVal firstinstalmmentdate As Nullable(Of DateTime),  _
                    ByVal firstinstalmmentpercent1 As Nullable(Of Decimal),  _
                    ByVal secondinstalmmentdate2 As Nullable(Of DateTime),  _
                    ByVal secondinstalmmentpercent2 As Nullable(Of Decimal),  _
                    ByVal thirdinstalmmentdate21 As Nullable(Of DateTime),  _
                    ByVal thirdinstalmmentpercent21 As Nullable(Of Decimal),  _
                    ByVal fourthinstalmmentdate3 As Nullable(Of DateTime),  _
                    ByVal fourthinstalmmentpercent3 As Nullable(Of Decimal),  _
                    ByVal agecalculatedate As Nullable(Of DateTime),  _
                    ByVal ageexpectedbyyear As Nullable(Of Long),  _
                    ByVal ageexpectedbymonth As Nullable(Of Long),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal stageCode As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal ageexpectedbyyear1 As Nullable(Of Long),  _
                    ByVal ageexpectedbymonth1 As Nullable(Of Long),  _
                    ByVal nextgrade As Nullable(Of Long),  _
                    ByVal nextStageCode As Nullable(Of Long)) As List(Of eZee.Data.Objects.schGrade)
            Return New schGradeFactory().Select(gradeCode, shortDesc1, shortDesc2, desc1, desc2, acdcode, acdAcademicYear, acdGlFinperiodFin_period_info, acdGlFinperiodaccountnumberAcc_Nm, totutionsfees, books, totalfees, registerationfees, registrationstartdate, firstinstalmmentdate, firstinstalmmentpercent1, secondinstalmmentdate2, secondinstalmmentpercent2, thirdinstalmmentdate21, thirdinstalmmentpercent21, fourthinstalmmentdate3, fourthinstalmmentpercent3, agecalculatedate, ageexpectedbyyear, ageexpectedbymonth, modifiedBy, modifiedOn, createdBy, createdOn, stageCode, stageShortDesc1, ageexpectedbyyear1, ageexpectedbymonth1, nextgrade, nextStageCode)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.schGrade) As List(Of eZee.Data.Objects.schGrade)
            Return New schGradeFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schGrade)
            Return New schGradeFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schGrade)
            Return New schGradeFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schGrade)
            Return New schGradeFactory().Select(filter, sort, schGradeFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schGrade)
            Return New schGradeFactory().Select(filter, sort, schGradeFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schGrade)
            Return New schGradeFactory().Select(filter, Nothing, schGradeFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schGrade)
            Return New schGradeFactory().Select(filter, Nothing, schGradeFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schGrade
            Return New schGradeFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.schGrade
            Return New schGradeFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal gradeCode As Nullable(Of Long)) As eZee.Data.Objects.schGrade
            Return New schGradeFactory().SelectSingle(gradeCode)
        End Function
        
        Public Function Insert() As Integer
            Return New schGradeFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New schGradeFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New schGradeFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("GradeCode: {0}", Me.GradeCode)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class schGradeFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("schGrade")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("schGrade")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("schGrade")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("schGrade")
            End Get
        End Property
        
        Public Shared Function Create() As schGradeFactory
            Return New schGradeFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal shortDesc1 As String,  _
                    ByVal shortDesc2 As String,  _
                    ByVal desc1 As String,  _
                    ByVal desc2 As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal totutionsfees As Nullable(Of Decimal),  _
                    ByVal books As Nullable(Of Decimal),  _
                    ByVal totalfees As Nullable(Of Decimal),  _
                    ByVal registerationfees As Nullable(Of Decimal),  _
                    ByVal registrationstartdate As Nullable(Of DateTime),  _
                    ByVal firstinstalmmentdate As Nullable(Of DateTime),  _
                    ByVal firstinstalmmentpercent1 As Nullable(Of Decimal),  _
                    ByVal secondinstalmmentdate2 As Nullable(Of DateTime),  _
                    ByVal secondinstalmmentpercent2 As Nullable(Of Decimal),  _
                    ByVal thirdinstalmmentdate21 As Nullable(Of DateTime),  _
                    ByVal thirdinstalmmentpercent21 As Nullable(Of Decimal),  _
                    ByVal fourthinstalmmentdate3 As Nullable(Of DateTime),  _
                    ByVal fourthinstalmmentpercent3 As Nullable(Of Decimal),  _
                    ByVal agecalculatedate As Nullable(Of DateTime),  _
                    ByVal ageexpectedbyyear As Nullable(Of Long),  _
                    ByVal ageexpectedbymonth As Nullable(Of Long),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal stageCode As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal ageexpectedbyyear1 As Nullable(Of Long),  _
                    ByVal ageexpectedbymonth1 As Nullable(Of Long),  _
                    ByVal nextgrade As Nullable(Of Long),  _
                    ByVal nextStageCode As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If gradeCode.HasValue Then
                filter.Add(("GradeCode:=" + gradeCode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(shortDesc1)) Then
                filter.Add(("ShortDesc1:*" + shortDesc1))
            End If
            If Not (String.IsNullOrEmpty(shortDesc2)) Then
                filter.Add(("ShortDesc2:*" + shortDesc2))
            End If
            If Not (String.IsNullOrEmpty(desc1)) Then
                filter.Add(("Desc1:*" + desc1))
            End If
            If Not (String.IsNullOrEmpty(desc2)) Then
                filter.Add(("Desc2:*" + desc2))
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
            If totutionsfees.HasValue Then
                filter.Add(("Totutionsfees:=" + totutionsfees.Value.ToString()))
            End If
            If books.HasValue Then
                filter.Add(("Books:=" + books.Value.ToString()))
            End If
            If totalfees.HasValue Then
                filter.Add(("Totalfees:=" + totalfees.Value.ToString()))
            End If
            If registerationfees.HasValue Then
                filter.Add(("registerationfees:=" + registerationfees.Value.ToString()))
            End If
            If registrationstartdate.HasValue Then
                filter.Add(("registrationstartdate:=" + registrationstartdate.Value.ToString()))
            End If
            If firstinstalmmentdate.HasValue Then
                filter.Add(("Firstinstalmmentdate:=" + firstinstalmmentdate.Value.ToString()))
            End If
            If firstinstalmmentpercent1.HasValue Then
                filter.Add(("Firstinstalmmentpercent1:=" + firstinstalmmentpercent1.Value.ToString()))
            End If
            If secondinstalmmentdate2.HasValue Then
                filter.Add(("Secondinstalmmentdate2:=" + secondinstalmmentdate2.Value.ToString()))
            End If
            If secondinstalmmentpercent2.HasValue Then
                filter.Add(("Secondinstalmmentpercent2:=" + secondinstalmmentpercent2.Value.ToString()))
            End If
            If thirdinstalmmentdate21.HasValue Then
                filter.Add(("thirdinstalmmentdate21:=" + thirdinstalmmentdate21.Value.ToString()))
            End If
            If thirdinstalmmentpercent21.HasValue Then
                filter.Add(("thirdinstalmmentpercent21:=" + thirdinstalmmentpercent21.Value.ToString()))
            End If
            If fourthinstalmmentdate3.HasValue Then
                filter.Add(("fourthinstalmmentdate3:=" + fourthinstalmmentdate3.Value.ToString()))
            End If
            If fourthinstalmmentpercent3.HasValue Then
                filter.Add(("fourthinstalmmentpercent3:=" + fourthinstalmmentpercent3.Value.ToString()))
            End If
            If agecalculatedate.HasValue Then
                filter.Add(("agecalculatedate:=" + agecalculatedate.Value.ToString()))
            End If
            If ageexpectedbyyear.HasValue Then
                filter.Add(("ageexpectedbyyear:=" + ageexpectedbyyear.Value.ToString()))
            End If
            If ageexpectedbymonth.HasValue Then
                filter.Add(("ageexpectedbymonth:=" + ageexpectedbymonth.Value.ToString()))
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
            If stageCode.HasValue Then
                filter.Add(("StageCode:=" + stageCode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(stageShortDesc1)) Then
                filter.Add(("StageShortDesc1:*" + stageShortDesc1))
            End If
            If ageexpectedbyyear1.HasValue Then
                filter.Add(("ageexpectedbyyear1:=" + ageexpectedbyyear1.Value.ToString()))
            End If
            If ageexpectedbymonth1.HasValue Then
                filter.Add(("ageexpectedbymonth1:=" + ageexpectedbymonth1.Value.ToString()))
            End If
            If nextgrade.HasValue Then
                filter.Add(("nextgrade:=" + nextgrade.Value.ToString()))
            End If
            If nextStageCode.HasValue Then
                filter.Add(("nextStageCode:=" + nextStageCode.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal shortDesc1 As String,  _
                    ByVal shortDesc2 As String,  _
                    ByVal desc1 As String,  _
                    ByVal desc2 As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal totutionsfees As Nullable(Of Decimal),  _
                    ByVal books As Nullable(Of Decimal),  _
                    ByVal totalfees As Nullable(Of Decimal),  _
                    ByVal registerationfees As Nullable(Of Decimal),  _
                    ByVal registrationstartdate As Nullable(Of DateTime),  _
                    ByVal firstinstalmmentdate As Nullable(Of DateTime),  _
                    ByVal firstinstalmmentpercent1 As Nullable(Of Decimal),  _
                    ByVal secondinstalmmentdate2 As Nullable(Of DateTime),  _
                    ByVal secondinstalmmentpercent2 As Nullable(Of Decimal),  _
                    ByVal thirdinstalmmentdate21 As Nullable(Of DateTime),  _
                    ByVal thirdinstalmmentpercent21 As Nullable(Of Decimal),  _
                    ByVal fourthinstalmmentdate3 As Nullable(Of DateTime),  _
                    ByVal fourthinstalmmentpercent3 As Nullable(Of Decimal),  _
                    ByVal agecalculatedate As Nullable(Of DateTime),  _
                    ByVal ageexpectedbyyear As Nullable(Of Long),  _
                    ByVal ageexpectedbymonth As Nullable(Of Long),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal stageCode As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal ageexpectedbyyear1 As Nullable(Of Long),  _
                    ByVal ageexpectedbymonth1 As Nullable(Of Long),  _
                    ByVal nextgrade As Nullable(Of Long),  _
                    ByVal nextStageCode As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.schGrade)
            Dim request As PageRequest = CreateRequest(gradeCode, shortDesc1, shortDesc2, desc1, desc2, acdcode, acdAcademicYear, acdGlFinperiodFin_period_info, acdGlFinperiodaccountnumberAcc_Nm, totutionsfees, books, totalfees, registerationfees, registrationstartdate, firstinstalmmentdate, firstinstalmmentpercent1, secondinstalmmentdate2, secondinstalmmentpercent2, thirdinstalmmentdate21, thirdinstalmmentpercent21, fourthinstalmmentdate3, fourthinstalmmentpercent3, agecalculatedate, ageexpectedbyyear, ageexpectedbymonth, modifiedBy, modifiedOn, createdBy, createdOn, stageCode, stageShortDesc1, ageexpectedbyyear1, ageexpectedbymonth1, nextgrade, nextStageCode, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schGrade", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schGrade)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.schGrade) As List(Of eZee.Data.Objects.schGrade)
            Return [Select](qbe.GradeCode, qbe.ShortDesc1, qbe.ShortDesc2, qbe.Desc1, qbe.Desc2, qbe.acdcode, qbe.acdAcademicYear, qbe.acdGlFinperiodFin_period_info, qbe.acdGlFinperiodaccountnumberAcc_Nm, qbe.Totutionsfees, qbe.Books, qbe.Totalfees, qbe.registerationfees, qbe.registrationstartdate, qbe.Firstinstalmmentdate, qbe.Firstinstalmmentpercent1, qbe.Secondinstalmmentdate2, qbe.Secondinstalmmentpercent2, qbe.thirdinstalmmentdate21, qbe.thirdinstalmmentpercent21, qbe.fourthinstalmmentdate3, qbe.fourthinstalmmentpercent3, qbe.agecalculatedate, qbe.ageexpectedbyyear, qbe.ageexpectedbymonth, qbe.ModifiedBy, qbe.ModifiedOn, qbe.CreatedBy, qbe.CreatedOn, qbe.StageCode, qbe.StageShortDesc1, qbe.ageexpectedbyyear1, qbe.ageexpectedbymonth1, qbe.nextgrade, qbe.nextStageCode)
        End Function
        
        Public Function SelectCount( _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal shortDesc1 As String,  _
                    ByVal shortDesc2 As String,  _
                    ByVal desc1 As String,  _
                    ByVal desc2 As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal totutionsfees As Nullable(Of Decimal),  _
                    ByVal books As Nullable(Of Decimal),  _
                    ByVal totalfees As Nullable(Of Decimal),  _
                    ByVal registerationfees As Nullable(Of Decimal),  _
                    ByVal registrationstartdate As Nullable(Of DateTime),  _
                    ByVal firstinstalmmentdate As Nullable(Of DateTime),  _
                    ByVal firstinstalmmentpercent1 As Nullable(Of Decimal),  _
                    ByVal secondinstalmmentdate2 As Nullable(Of DateTime),  _
                    ByVal secondinstalmmentpercent2 As Nullable(Of Decimal),  _
                    ByVal thirdinstalmmentdate21 As Nullable(Of DateTime),  _
                    ByVal thirdinstalmmentpercent21 As Nullable(Of Decimal),  _
                    ByVal fourthinstalmmentdate3 As Nullable(Of DateTime),  _
                    ByVal fourthinstalmmentpercent3 As Nullable(Of Decimal),  _
                    ByVal agecalculatedate As Nullable(Of DateTime),  _
                    ByVal ageexpectedbyyear As Nullable(Of Long),  _
                    ByVal ageexpectedbymonth As Nullable(Of Long),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal stageCode As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal ageexpectedbyyear1 As Nullable(Of Long),  _
                    ByVal ageexpectedbymonth1 As Nullable(Of Long),  _
                    ByVal nextgrade As Nullable(Of Long),  _
                    ByVal nextStageCode As Nullable(Of Long),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(gradeCode, shortDesc1, shortDesc2, desc1, desc2, acdcode, acdAcademicYear, acdGlFinperiodFin_period_info, acdGlFinperiodaccountnumberAcc_Nm, totutionsfees, books, totalfees, registerationfees, registrationstartdate, firstinstalmmentdate, firstinstalmmentpercent1, secondinstalmmentdate2, secondinstalmmentpercent2, thirdinstalmmentdate21, thirdinstalmmentpercent21, fourthinstalmmentdate3, fourthinstalmmentpercent3, agecalculatedate, ageexpectedbyyear, ageexpectedbymonth, modifiedBy, modifiedOn, createdBy, createdOn, stageCode, stageShortDesc1, ageexpectedbyyear1, ageexpectedbymonth1, nextgrade, nextStageCode, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schGrade", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal shortDesc1 As String,  _
                    ByVal shortDesc2 As String,  _
                    ByVal desc1 As String,  _
                    ByVal desc2 As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal totutionsfees As Nullable(Of Decimal),  _
                    ByVal books As Nullable(Of Decimal),  _
                    ByVal totalfees As Nullable(Of Decimal),  _
                    ByVal registerationfees As Nullable(Of Decimal),  _
                    ByVal registrationstartdate As Nullable(Of DateTime),  _
                    ByVal firstinstalmmentdate As Nullable(Of DateTime),  _
                    ByVal firstinstalmmentpercent1 As Nullable(Of Decimal),  _
                    ByVal secondinstalmmentdate2 As Nullable(Of DateTime),  _
                    ByVal secondinstalmmentpercent2 As Nullable(Of Decimal),  _
                    ByVal thirdinstalmmentdate21 As Nullable(Of DateTime),  _
                    ByVal thirdinstalmmentpercent21 As Nullable(Of Decimal),  _
                    ByVal fourthinstalmmentdate3 As Nullable(Of DateTime),  _
                    ByVal fourthinstalmmentpercent3 As Nullable(Of Decimal),  _
                    ByVal agecalculatedate As Nullable(Of DateTime),  _
                    ByVal ageexpectedbyyear As Nullable(Of Long),  _
                    ByVal ageexpectedbymonth As Nullable(Of Long),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal stageCode As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal ageexpectedbyyear1 As Nullable(Of Long),  _
                    ByVal ageexpectedbymonth1 As Nullable(Of Long),  _
                    ByVal nextgrade As Nullable(Of Long),  _
                    ByVal nextStageCode As Nullable(Of Long)) As List(Of eZee.Data.Objects.schGrade)
            Return [Select](gradeCode, shortDesc1, shortDesc2, desc1, desc2, acdcode, acdAcademicYear, acdGlFinperiodFin_period_info, acdGlFinperiodaccountnumberAcc_Nm, totutionsfees, books, totalfees, registerationfees, registrationstartdate, firstinstalmmentdate, firstinstalmmentpercent1, secondinstalmmentdate2, secondinstalmmentpercent2, thirdinstalmmentdate21, thirdinstalmmentpercent21, fourthinstalmmentdate3, fourthinstalmmentpercent3, agecalculatedate, ageexpectedbyyear, ageexpectedbymonth, modifiedBy, modifiedOn, createdBy, createdOn, stageCode, stageShortDesc1, ageexpectedbyyear1, ageexpectedbymonth1, nextgrade, nextStageCode, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal gradeCode As Nullable(Of Long)) As eZee.Data.Objects.schGrade
            Dim list As List(Of eZee.Data.Objects.schGrade) = [Select](gradeCode, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schGrade)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("schGrade", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schGrade)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schGrade)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schGrade)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schGrade
            Dim list As List(Of eZee.Data.Objects.schGrade) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theschGrade As eZee.Data.Objects.schGrade, ByVal original_schGrade As eZee.Data.Objects.schGrade) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("GradeCode", original_schGrade.GradeCode, theschGrade.GradeCode, true))
            values.Add(New FieldValue("ShortDesc1", original_schGrade.ShortDesc1, theschGrade.ShortDesc1))
            values.Add(New FieldValue("ShortDesc2", original_schGrade.ShortDesc2, theschGrade.ShortDesc2))
            values.Add(New FieldValue("Desc1", original_schGrade.Desc1, theschGrade.Desc1))
            values.Add(New FieldValue("Desc2", original_schGrade.Desc2, theschGrade.Desc2))
            values.Add(New FieldValue("acdcode", original_schGrade.acdcode, theschGrade.acdcode))
            values.Add(New FieldValue("acdAcademicYear", original_schGrade.acdAcademicYear, theschGrade.acdAcademicYear, true))
            values.Add(New FieldValue("acdGlFinperiodFin_period_info", original_schGrade.acdGlFinperiodFin_period_info, theschGrade.acdGlFinperiodFin_period_info, true))
            values.Add(New FieldValue("acdGlFinperiodaccountnumberAcc_Nm", original_schGrade.acdGlFinperiodaccountnumberAcc_Nm, theschGrade.acdGlFinperiodaccountnumberAcc_Nm, true))
            values.Add(New FieldValue("Totutionsfees", original_schGrade.Totutionsfees, theschGrade.Totutionsfees))
            values.Add(New FieldValue("Books", original_schGrade.Books, theschGrade.Books))
            values.Add(New FieldValue("Totalfees", original_schGrade.Totalfees, theschGrade.Totalfees))
            values.Add(New FieldValue("registerationfees", original_schGrade.registerationfees, theschGrade.registerationfees))
            values.Add(New FieldValue("registrationstartdate", original_schGrade.registrationstartdate, theschGrade.registrationstartdate))
            values.Add(New FieldValue("Firstinstalmmentdate", original_schGrade.Firstinstalmmentdate, theschGrade.Firstinstalmmentdate))
            values.Add(New FieldValue("Firstinstalmmentpercent1", original_schGrade.Firstinstalmmentpercent1, theschGrade.Firstinstalmmentpercent1))
            values.Add(New FieldValue("Secondinstalmmentdate2", original_schGrade.Secondinstalmmentdate2, theschGrade.Secondinstalmmentdate2))
            values.Add(New FieldValue("Secondinstalmmentpercent2", original_schGrade.Secondinstalmmentpercent2, theschGrade.Secondinstalmmentpercent2))
            values.Add(New FieldValue("thirdinstalmmentdate21", original_schGrade.thirdinstalmmentdate21, theschGrade.thirdinstalmmentdate21))
            values.Add(New FieldValue("thirdinstalmmentpercent21", original_schGrade.thirdinstalmmentpercent21, theschGrade.thirdinstalmmentpercent21))
            values.Add(New FieldValue("fourthinstalmmentdate3", original_schGrade.fourthinstalmmentdate3, theschGrade.fourthinstalmmentdate3))
            values.Add(New FieldValue("fourthinstalmmentpercent3", original_schGrade.fourthinstalmmentpercent3, theschGrade.fourthinstalmmentpercent3))
            values.Add(New FieldValue("agecalculatedate", original_schGrade.agecalculatedate, theschGrade.agecalculatedate))
            values.Add(New FieldValue("ageexpectedbyyear", original_schGrade.ageexpectedbyyear, theschGrade.ageexpectedbyyear))
            values.Add(New FieldValue("ageexpectedbymonth", original_schGrade.ageexpectedbymonth, theschGrade.ageexpectedbymonth))
            values.Add(New FieldValue("ModifiedBy", original_schGrade.ModifiedBy, theschGrade.ModifiedBy))
            values.Add(New FieldValue("ModifiedOn", original_schGrade.ModifiedOn, theschGrade.ModifiedOn))
            values.Add(New FieldValue("CreatedBy", original_schGrade.CreatedBy, theschGrade.CreatedBy))
            values.Add(New FieldValue("CreatedOn", original_schGrade.CreatedOn, theschGrade.CreatedOn))
            values.Add(New FieldValue("StageCode", original_schGrade.StageCode, theschGrade.StageCode))
            values.Add(New FieldValue("StageShortDesc1", original_schGrade.StageShortDesc1, theschGrade.StageShortDesc1, true))
            values.Add(New FieldValue("ageexpectedbyyear1", original_schGrade.ageexpectedbyyear1, theschGrade.ageexpectedbyyear1))
            values.Add(New FieldValue("ageexpectedbymonth1", original_schGrade.ageexpectedbymonth1, theschGrade.ageexpectedbymonth1))
            values.Add(New FieldValue("nextgrade", original_schGrade.nextgrade, theschGrade.nextgrade))
            values.Add(New FieldValue("nextStageCode", original_schGrade.nextStageCode, theschGrade.nextStageCode))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theschGrade As eZee.Data.Objects.schGrade, ByVal original_schGrade As eZee.Data.Objects.schGrade, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "schGrade"
            args.View = dataView
            args.Values = CreateFieldValues(theschGrade, original_schGrade)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("schGrade", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theschGrade)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theschGrade As eZee.Data.Objects.schGrade, ByVal original_schGrade As eZee.Data.Objects.schGrade) As Integer
            Return ExecuteAction(theschGrade, original_schGrade, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theschGrade As eZee.Data.Objects.schGrade) As Integer
            Return Update(theschGrade, SelectSingle(theschGrade.GradeCode))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theschGrade As eZee.Data.Objects.schGrade) As Integer
            Return ExecuteAction(theschGrade, New schGrade(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theschGrade As eZee.Data.Objects.schGrade) As Integer
            Return ExecuteAction(theschGrade, theschGrade, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
