Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class schAcademicyear
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Code As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AcademicYear As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Startdate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Enddate As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GlFinperiodID As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GlFinperiodFin_period_info As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GlFinperiodaccountnumberAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GlFinperiodaccountnumberClsacc_Acc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_GlFinperiodaccountnumberAcc_BndAcc_Nm As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Startdatein As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Startdatepaystart As Nullable(Of DateTime)
        
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
        Private m_Agecalculatedate As Nullable(Of DateTime)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property Code() As Nullable(Of Long)
            Get
                Return m_Code
            End Get
            Set
                m_Code = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property AcademicYear() As String
            Get
                Return m_AcademicYear
            End Get
            Set
                m_AcademicYear = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property startdate() As Nullable(Of DateTime)
            Get
                Return m_Startdate
            End Get
            Set
                m_Startdate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property enddate() As Nullable(Of DateTime)
            Get
                Return m_Enddate
            End Get
            Set
                m_Enddate = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GlFinperiodID() As Nullable(Of Long)
            Get
                Return m_GlFinperiodID
            End Get
            Set
                m_GlFinperiodID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GlFinperiodFin_period_info() As String
            Get
                Return m_GlFinperiodFin_period_info
            End Get
            Set
                m_GlFinperiodFin_period_info = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GlFinperiodaccountnumberAcc_Nm() As String
            Get
                Return m_GlFinperiodaccountnumberAcc_Nm
            End Get
            Set
                m_GlFinperiodaccountnumberAcc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GlFinperiodaccountnumberClsacc_Acc_Nm() As String
            Get
                Return m_GlFinperiodaccountnumberClsacc_Acc_Nm
            End Get
            Set
                m_GlFinperiodaccountnumberClsacc_Acc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property GlFinperiodaccountnumberAcc_BndAcc_Nm() As String
            Get
                Return m_GlFinperiodaccountnumberAcc_BndAcc_Nm
            End Get
            Set
                m_GlFinperiodaccountnumberAcc_BndAcc_Nm = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property startdatein() As Nullable(Of DateTime)
            Get
                Return m_Startdatein
            End Get
            Set
                m_Startdatein = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property startdatepaystart() As Nullable(Of DateTime)
            Get
                Return m_Startdatepaystart
            End Get
            Set
                m_Startdatepaystart = value
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
        Public Property Agecalculatedate() As Nullable(Of DateTime)
            Get
                Return m_Agecalculatedate
            End Get
            Set
                m_Agecalculatedate = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select]( _
                    ByVal code As Nullable(Of Long),  _
                    ByVal academicYear As String,  _
                    ByVal startdate As Nullable(Of DateTime),  _
                    ByVal enddate As Nullable(Of DateTime),  _
                    ByVal glFinperiodID As Nullable(Of Long),  _
                    ByVal glFinperiodFin_period_info As String,  _
                    ByVal glFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal glFinperiodaccountnumberClsacc_Acc_Nm As String,  _
                    ByVal glFinperiodaccountnumberAcc_BndAcc_Nm As String,  _
                    ByVal startdatein As Nullable(Of DateTime),  _
                    ByVal startdatepaystart As Nullable(Of DateTime),  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal agecalculatedate As Nullable(Of DateTime)) As List(Of eZee.Data.Objects.schAcademicyear)
            Return New schAcademicyearFactory().Select(code, academicYear, startdate, enddate, glFinperiodID, glFinperiodFin_period_info, glFinperiodaccountnumberAcc_Nm, glFinperiodaccountnumberClsacc_Acc_Nm, glFinperiodaccountnumberAcc_BndAcc_Nm, startdatein, startdatepaystart, notes, modifiedBy, modifiedOn, createdBy, createdOn, agecalculatedate)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.schAcademicyear) As List(Of eZee.Data.Objects.schAcademicyear)
            Return New schAcademicyearFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schAcademicyear)
            Return New schAcademicyearFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schAcademicyear)
            Return New schAcademicyearFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schAcademicyear)
            Return New schAcademicyearFactory().Select(filter, sort, schAcademicyearFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schAcademicyear)
            Return New schAcademicyearFactory().Select(filter, sort, schAcademicyearFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schAcademicyear)
            Return New schAcademicyearFactory().Select(filter, Nothing, schAcademicyearFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schAcademicyear)
            Return New schAcademicyearFactory().Select(filter, Nothing, schAcademicyearFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schAcademicyear
            Return New schAcademicyearFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.schAcademicyear
            Return New schAcademicyearFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal code As Nullable(Of Long)) As eZee.Data.Objects.schAcademicyear
            Return New schAcademicyearFactory().SelectSingle(code)
        End Function
        
        Public Function Insert() As Integer
            Return New schAcademicyearFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New schAcademicyearFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New schAcademicyearFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("Code: {0}", Me.Code)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class schAcademicyearFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("schAcademicyear")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("schAcademicyear")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("schAcademicyear")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("schAcademicyear")
            End Get
        End Property
        
        Public Shared Function Create() As schAcademicyearFactory
            Return New schAcademicyearFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal code As Nullable(Of Long),  _
                    ByVal academicYear As String,  _
                    ByVal startdate As Nullable(Of DateTime),  _
                    ByVal enddate As Nullable(Of DateTime),  _
                    ByVal glFinperiodID As Nullable(Of Long),  _
                    ByVal glFinperiodFin_period_info As String,  _
                    ByVal glFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal glFinperiodaccountnumberClsacc_Acc_Nm As String,  _
                    ByVal glFinperiodaccountnumberAcc_BndAcc_Nm As String,  _
                    ByVal startdatein As Nullable(Of DateTime),  _
                    ByVal startdatepaystart As Nullable(Of DateTime),  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal agecalculatedate As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If code.HasValue Then
                filter.Add(("Code:=" + code.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(academicYear)) Then
                filter.Add(("AcademicYear:*" + academicYear))
            End If
            If startdate.HasValue Then
                filter.Add(("startdate:=" + startdate.Value.ToString()))
            End If
            If enddate.HasValue Then
                filter.Add(("enddate:=" + enddate.Value.ToString()))
            End If
            If glFinperiodID.HasValue Then
                filter.Add(("GlFinperiodID:=" + glFinperiodID.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(glFinperiodFin_period_info)) Then
                filter.Add(("GlFinperiodFin_period_info:*" + glFinperiodFin_period_info))
            End If
            If Not (String.IsNullOrEmpty(glFinperiodaccountnumberAcc_Nm)) Then
                filter.Add(("GlFinperiodaccountnumberAcc_Nm:*" + glFinperiodaccountnumberAcc_Nm))
            End If
            If Not (String.IsNullOrEmpty(glFinperiodaccountnumberClsacc_Acc_Nm)) Then
                filter.Add(("GlFinperiodaccountnumberClsacc_Acc_Nm:*" + glFinperiodaccountnumberClsacc_Acc_Nm))
            End If
            If Not (String.IsNullOrEmpty(glFinperiodaccountnumberAcc_BndAcc_Nm)) Then
                filter.Add(("GlFinperiodaccountnumberAcc_BndAcc_Nm:*" + glFinperiodaccountnumberAcc_BndAcc_Nm))
            End If
            If startdatein.HasValue Then
                filter.Add(("startdatein:=" + startdatein.Value.ToString()))
            End If
            If startdatepaystart.HasValue Then
                filter.Add(("startdatepaystart:=" + startdatepaystart.Value.ToString()))
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
            If agecalculatedate.HasValue Then
                filter.Add(("Agecalculatedate:=" + agecalculatedate.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal code As Nullable(Of Long),  _
                    ByVal academicYear As String,  _
                    ByVal startdate As Nullable(Of DateTime),  _
                    ByVal enddate As Nullable(Of DateTime),  _
                    ByVal glFinperiodID As Nullable(Of Long),  _
                    ByVal glFinperiodFin_period_info As String,  _
                    ByVal glFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal glFinperiodaccountnumberClsacc_Acc_Nm As String,  _
                    ByVal glFinperiodaccountnumberAcc_BndAcc_Nm As String,  _
                    ByVal startdatein As Nullable(Of DateTime),  _
                    ByVal startdatepaystart As Nullable(Of DateTime),  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal agecalculatedate As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.schAcademicyear)
            Dim request As PageRequest = CreateRequest(code, academicYear, startdate, enddate, glFinperiodID, glFinperiodFin_period_info, glFinperiodaccountnumberAcc_Nm, glFinperiodaccountnumberClsacc_Acc_Nm, glFinperiodaccountnumberAcc_BndAcc_Nm, startdatein, startdatepaystart, notes, modifiedBy, modifiedOn, createdBy, createdOn, agecalculatedate, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schAcademicyear", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schAcademicyear)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.schAcademicyear) As List(Of eZee.Data.Objects.schAcademicyear)
            Return [Select](qbe.Code, qbe.AcademicYear, qbe.startdate, qbe.enddate, qbe.GlFinperiodID, qbe.GlFinperiodFin_period_info, qbe.GlFinperiodaccountnumberAcc_Nm, qbe.GlFinperiodaccountnumberClsacc_Acc_Nm, qbe.GlFinperiodaccountnumberAcc_BndAcc_Nm, qbe.startdatein, qbe.startdatepaystart, qbe.notes, qbe.ModifiedBy, qbe.ModifiedOn, qbe.CreatedBy, qbe.CreatedOn, qbe.Agecalculatedate)
        End Function
        
        Public Function SelectCount( _
                    ByVal code As Nullable(Of Long),  _
                    ByVal academicYear As String,  _
                    ByVal startdate As Nullable(Of DateTime),  _
                    ByVal enddate As Nullable(Of DateTime),  _
                    ByVal glFinperiodID As Nullable(Of Long),  _
                    ByVal glFinperiodFin_period_info As String,  _
                    ByVal glFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal glFinperiodaccountnumberClsacc_Acc_Nm As String,  _
                    ByVal glFinperiodaccountnumberAcc_BndAcc_Nm As String,  _
                    ByVal startdatein As Nullable(Of DateTime),  _
                    ByVal startdatepaystart As Nullable(Of DateTime),  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal agecalculatedate As Nullable(Of DateTime),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(code, academicYear, startdate, enddate, glFinperiodID, glFinperiodFin_period_info, glFinperiodaccountnumberAcc_Nm, glFinperiodaccountnumberClsacc_Acc_Nm, glFinperiodaccountnumberAcc_BndAcc_Nm, startdatein, startdatepaystart, notes, modifiedBy, modifiedOn, createdBy, createdOn, agecalculatedate, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schAcademicyear", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal code As Nullable(Of Long),  _
                    ByVal academicYear As String,  _
                    ByVal startdate As Nullable(Of DateTime),  _
                    ByVal enddate As Nullable(Of DateTime),  _
                    ByVal glFinperiodID As Nullable(Of Long),  _
                    ByVal glFinperiodFin_period_info As String,  _
                    ByVal glFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal glFinperiodaccountnumberClsacc_Acc_Nm As String,  _
                    ByVal glFinperiodaccountnumberAcc_BndAcc_Nm As String,  _
                    ByVal startdatein As Nullable(Of DateTime),  _
                    ByVal startdatepaystart As Nullable(Of DateTime),  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal agecalculatedate As Nullable(Of DateTime)) As List(Of eZee.Data.Objects.schAcademicyear)
            Return [Select](code, academicYear, startdate, enddate, glFinperiodID, glFinperiodFin_period_info, glFinperiodaccountnumberAcc_Nm, glFinperiodaccountnumberClsacc_Acc_Nm, glFinperiodaccountnumberAcc_BndAcc_Nm, startdatein, startdatepaystart, notes, modifiedBy, modifiedOn, createdBy, createdOn, agecalculatedate, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal code As Nullable(Of Long)) As eZee.Data.Objects.schAcademicyear
            Dim list As List(Of eZee.Data.Objects.schAcademicyear) = [Select](code, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schAcademicyear)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("schAcademicyear", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schAcademicyear)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schAcademicyear)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schAcademicyear)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schAcademicyear
            Dim list As List(Of eZee.Data.Objects.schAcademicyear) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theschAcademicyear As eZee.Data.Objects.schAcademicyear, ByVal original_schAcademicyear As eZee.Data.Objects.schAcademicyear) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("Code", original_schAcademicyear.Code, theschAcademicyear.Code, true))
            values.Add(New FieldValue("AcademicYear", original_schAcademicyear.AcademicYear, theschAcademicyear.AcademicYear))
            values.Add(New FieldValue("startdate", original_schAcademicyear.startdate, theschAcademicyear.startdate))
            values.Add(New FieldValue("enddate", original_schAcademicyear.enddate, theschAcademicyear.enddate))
            values.Add(New FieldValue("GlFinperiodID", original_schAcademicyear.GlFinperiodID, theschAcademicyear.GlFinperiodID))
            values.Add(New FieldValue("GlFinperiodFin_period_info", original_schAcademicyear.GlFinperiodFin_period_info, theschAcademicyear.GlFinperiodFin_period_info, true))
            values.Add(New FieldValue("GlFinperiodaccountnumberAcc_Nm", original_schAcademicyear.GlFinperiodaccountnumberAcc_Nm, theschAcademicyear.GlFinperiodaccountnumberAcc_Nm, true))
            values.Add(New FieldValue("GlFinperiodaccountnumberClsacc_Acc_Nm", original_schAcademicyear.GlFinperiodaccountnumberClsacc_Acc_Nm, theschAcademicyear.GlFinperiodaccountnumberClsacc_Acc_Nm, true))
            values.Add(New FieldValue("GlFinperiodaccountnumberAcc_BndAcc_Nm", original_schAcademicyear.GlFinperiodaccountnumberAcc_BndAcc_Nm, theschAcademicyear.GlFinperiodaccountnumberAcc_BndAcc_Nm, true))
            values.Add(New FieldValue("startdatein", original_schAcademicyear.startdatein, theschAcademicyear.startdatein))
            values.Add(New FieldValue("startdatepaystart", original_schAcademicyear.startdatepaystart, theschAcademicyear.startdatepaystart))
            values.Add(New FieldValue("notes", original_schAcademicyear.notes, theschAcademicyear.notes))
            values.Add(New FieldValue("ModifiedBy", original_schAcademicyear.ModifiedBy, theschAcademicyear.ModifiedBy))
            values.Add(New FieldValue("ModifiedOn", original_schAcademicyear.ModifiedOn, theschAcademicyear.ModifiedOn))
            values.Add(New FieldValue("CreatedBy", original_schAcademicyear.CreatedBy, theschAcademicyear.CreatedBy))
            values.Add(New FieldValue("CreatedOn", original_schAcademicyear.CreatedOn, theschAcademicyear.CreatedOn))
            values.Add(New FieldValue("Agecalculatedate", original_schAcademicyear.Agecalculatedate, theschAcademicyear.Agecalculatedate))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theschAcademicyear As eZee.Data.Objects.schAcademicyear, ByVal original_schAcademicyear As eZee.Data.Objects.schAcademicyear, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "schAcademicyear"
            args.View = dataView
            args.Values = CreateFieldValues(theschAcademicyear, original_schAcademicyear)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("schAcademicyear", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theschAcademicyear)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theschAcademicyear As eZee.Data.Objects.schAcademicyear, ByVal original_schAcademicyear As eZee.Data.Objects.schAcademicyear) As Integer
            Return ExecuteAction(theschAcademicyear, original_schAcademicyear, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theschAcademicyear As eZee.Data.Objects.schAcademicyear) As Integer
            Return Update(theschAcademicyear, SelectSingle(theschAcademicyear.Code))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theschAcademicyear As eZee.Data.Objects.schAcademicyear) As Integer
            Return ExecuteAction(theschAcademicyear, New schAcademicyear(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theschAcademicyear As eZee.Data.Objects.schAcademicyear) As Integer
            Return ExecuteAction(theschAcademicyear, theschAcademicyear, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
