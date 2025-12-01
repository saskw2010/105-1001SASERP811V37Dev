Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class SchClass
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchClassid As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SchName As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StartTime As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_EndTime As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_LateMinutes As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_EarlyMinutes As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CheckIn As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CheckOut As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CheckInTime1 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CheckInTime2 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CheckOutTime1 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CheckOutTime2 As Nullable(Of DateTime)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Color As Nullable(Of Integer)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AutoBind As Nullable(Of Short)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_WorkDay As Nullable(Of Double)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SensorID As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_WorkMins As Nullable(Of Double)
        
        Public Sub New()
            MyBase.New
        End Sub
        
        <System.ComponentModel.DataObjectField(true, true, false)>  _
        Public Property schClassid() As Nullable(Of Integer)
            Get
                Return m_SchClassid
            End Get
            Set
                m_SchClassid = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property schName() As String
            Get
                Return m_SchName
            End Get
            Set
                m_SchName = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property StartTime() As Nullable(Of DateTime)
            Get
                Return m_StartTime
            End Get
            Set
                m_StartTime = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, false)>  _
        Public Property EndTime() As Nullable(Of DateTime)
            Get
                Return m_EndTime
            End Get
            Set
                m_EndTime = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property LateMinutes() As Nullable(Of Integer)
            Get
                Return m_LateMinutes
            End Get
            Set
                m_LateMinutes = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property EarlyMinutes() As Nullable(Of Integer)
            Get
                Return m_EarlyMinutes
            End Get
            Set
                m_EarlyMinutes = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CheckIn() As Nullable(Of Integer)
            Get
                Return m_CheckIn
            End Get
            Set
                m_CheckIn = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CheckOut() As Nullable(Of Integer)
            Get
                Return m_CheckOut
            End Get
            Set
                m_CheckOut = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CheckInTime1() As Nullable(Of DateTime)
            Get
                Return m_CheckInTime1
            End Get
            Set
                m_CheckInTime1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CheckInTime2() As Nullable(Of DateTime)
            Get
                Return m_CheckInTime2
            End Get
            Set
                m_CheckInTime2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CheckOutTime1() As Nullable(Of DateTime)
            Get
                Return m_CheckOutTime1
            End Get
            Set
                m_CheckOutTime1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property CheckOutTime2() As Nullable(Of DateTime)
            Get
                Return m_CheckOutTime2
            End Get
            Set
                m_CheckOutTime2 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property Color() As Nullable(Of Integer)
            Get
                Return m_Color
            End Get
            Set
                m_Color = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property AutoBind() As Nullable(Of Short)
            Get
                Return m_AutoBind
            End Get
            Set
                m_AutoBind = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property WorkDay() As Nullable(Of Double)
            Get
                Return m_WorkDay
            End Get
            Set
                m_WorkDay = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property SensorID() As String
            Get
                Return m_SensorID
            End Get
            Set
                m_SensorID = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property WorkMins() As Nullable(Of Double)
            Get
                Return m_WorkMins
            End Get
            Set
                m_WorkMins = value
            End Set
        End Property
        
        Public Overloads Shared Function [Select]( _
                    ByVal schClassid As Nullable(Of Integer),  _
                    ByVal schName As String,  _
                    ByVal startTime As Nullable(Of DateTime),  _
                    ByVal endTime As Nullable(Of DateTime),  _
                    ByVal lateMinutes As Nullable(Of Integer),  _
                    ByVal earlyMinutes As Nullable(Of Integer),  _
                    ByVal checkIn As Nullable(Of Integer),  _
                    ByVal checkOut As Nullable(Of Integer),  _
                    ByVal checkInTime1 As Nullable(Of DateTime),  _
                    ByVal checkInTime2 As Nullable(Of DateTime),  _
                    ByVal checkOutTime1 As Nullable(Of DateTime),  _
                    ByVal checkOutTime2 As Nullable(Of DateTime),  _
                    ByVal color As Nullable(Of Integer),  _
                    ByVal autoBind As Nullable(Of Short),  _
                    ByVal workDay As Nullable(Of Double),  _
                    ByVal sensorID As String,  _
                    ByVal workMins As Nullable(Of Double)) As List(Of eZee.Data.Objects.SchClass)
            Return New SchClassFactory().Select(schClassid, schName, startTime, endTime, lateMinutes, earlyMinutes, checkIn, checkOut, checkInTime1, checkInTime2, checkOutTime1, checkOutTime2, color, autoBind, workDay, sensorID, workMins)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.SchClass) As List(Of eZee.Data.Objects.SchClass)
            Return New SchClassFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.SchClass)
            Return New SchClassFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.SchClass)
            Return New SchClassFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.SchClass)
            Return New SchClassFactory().Select(filter, sort, SchClassFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.SchClass)
            Return New SchClassFactory().Select(filter, sort, SchClassFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.SchClass)
            Return New SchClassFactory().Select(filter, Nothing, SchClassFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.SchClass)
            Return New SchClassFactory().Select(filter, Nothing, SchClassFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.SchClass
            Return New SchClassFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.SchClass
            Return New SchClassFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal schClassid As Nullable(Of Integer)) As eZee.Data.Objects.SchClass
            Return New SchClassFactory().SelectSingle(schClassid)
        End Function
        
        Public Function Insert() As Integer
            Return New SchClassFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New SchClassFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New SchClassFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("schClassid: {0}", Me.schClassid)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class SchClassFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("SchClass")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("SchClass")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("SchClass")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("SchClass")
            End Get
        End Property
        
        Public Shared Function Create() As SchClassFactory
            Return New SchClassFactory()
        End Function
        
        Protected Overridable Function CreateRequest( _
                    ByVal schClassid As Nullable(Of Integer),  _
                    ByVal schName As String,  _
                    ByVal startTime As Nullable(Of DateTime),  _
                    ByVal endTime As Nullable(Of DateTime),  _
                    ByVal lateMinutes As Nullable(Of Integer),  _
                    ByVal earlyMinutes As Nullable(Of Integer),  _
                    ByVal checkIn As Nullable(Of Integer),  _
                    ByVal checkOut As Nullable(Of Integer),  _
                    ByVal checkInTime1 As Nullable(Of DateTime),  _
                    ByVal checkInTime2 As Nullable(Of DateTime),  _
                    ByVal checkOutTime1 As Nullable(Of DateTime),  _
                    ByVal checkOutTime2 As Nullable(Of DateTime),  _
                    ByVal color As Nullable(Of Integer),  _
                    ByVal autoBind As Nullable(Of Short),  _
                    ByVal workDay As Nullable(Of Double),  _
                    ByVal sensorID As String,  _
                    ByVal workMins As Nullable(Of Double),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If schClassid.HasValue Then
                filter.Add(("schClassid:=" + schClassid.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(schName)) Then
                filter.Add(("schName:*" + schName))
            End If
            If startTime.HasValue Then
                filter.Add(("StartTime:=" + startTime.Value.ToString()))
            End If
            If endTime.HasValue Then
                filter.Add(("EndTime:=" + endTime.Value.ToString()))
            End If
            If lateMinutes.HasValue Then
                filter.Add(("LateMinutes:=" + lateMinutes.Value.ToString()))
            End If
            If earlyMinutes.HasValue Then
                filter.Add(("EarlyMinutes:=" + earlyMinutes.Value.ToString()))
            End If
            If checkIn.HasValue Then
                filter.Add(("CheckIn:=" + checkIn.Value.ToString()))
            End If
            If checkOut.HasValue Then
                filter.Add(("CheckOut:=" + checkOut.Value.ToString()))
            End If
            If checkInTime1.HasValue Then
                filter.Add(("CheckInTime1:=" + checkInTime1.Value.ToString()))
            End If
            If checkInTime2.HasValue Then
                filter.Add(("CheckInTime2:=" + checkInTime2.Value.ToString()))
            End If
            If checkOutTime1.HasValue Then
                filter.Add(("CheckOutTime1:=" + checkOutTime1.Value.ToString()))
            End If
            If checkOutTime2.HasValue Then
                filter.Add(("CheckOutTime2:=" + checkOutTime2.Value.ToString()))
            End If
            If color.HasValue Then
                filter.Add(("Color:=" + color.Value.ToString()))
            End If
            If autoBind.HasValue Then
                filter.Add(("AutoBind:=" + autoBind.Value.ToString()))
            End If
            If workDay.HasValue Then
                filter.Add(("WorkDay:=" + workDay.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(sensorID)) Then
                filter.Add(("SensorID:*" + sensorID))
            End If
            If workMins.HasValue Then
                filter.Add(("WorkMins:=" + workMins.Value.ToString()))
            End If
            Return New PageRequest((startRowIndex / maximumRows), maximumRows, sort, filter.ToArray())
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select)>  _
        Public Overloads Function [Select]( _
                    ByVal schClassid As Nullable(Of Integer),  _
                    ByVal schName As String,  _
                    ByVal startTime As Nullable(Of DateTime),  _
                    ByVal endTime As Nullable(Of DateTime),  _
                    ByVal lateMinutes As Nullable(Of Integer),  _
                    ByVal earlyMinutes As Nullable(Of Integer),  _
                    ByVal checkIn As Nullable(Of Integer),  _
                    ByVal checkOut As Nullable(Of Integer),  _
                    ByVal checkInTime1 As Nullable(Of DateTime),  _
                    ByVal checkInTime2 As Nullable(Of DateTime),  _
                    ByVal checkOutTime1 As Nullable(Of DateTime),  _
                    ByVal checkOutTime2 As Nullable(Of DateTime),  _
                    ByVal color As Nullable(Of Integer),  _
                    ByVal autoBind As Nullable(Of Short),  _
                    ByVal workDay As Nullable(Of Double),  _
                    ByVal sensorID As String,  _
                    ByVal workMins As Nullable(Of Double),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As List(Of eZee.Data.Objects.SchClass)
            Dim request As PageRequest = CreateRequest(schClassid, schName, startTime, endTime, lateMinutes, earlyMinutes, checkIn, checkOut, checkInTime1, checkInTime2, checkOutTime1, checkOutTime2, color, autoBind, workDay, sensorID, workMins, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("SchClass", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.SchClass)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.SchClass) As List(Of eZee.Data.Objects.SchClass)
            Return [Select](qbe.schClassid, qbe.schName, qbe.StartTime, qbe.EndTime, qbe.LateMinutes, qbe.EarlyMinutes, qbe.CheckIn, qbe.CheckOut, qbe.CheckInTime1, qbe.CheckInTime2, qbe.CheckOutTime1, qbe.CheckOutTime2, qbe.Color, qbe.AutoBind, qbe.WorkDay, qbe.SensorID, qbe.WorkMins)
        End Function
        
        Public Function SelectCount( _
                    ByVal schClassid As Nullable(Of Integer),  _
                    ByVal schName As String,  _
                    ByVal startTime As Nullable(Of DateTime),  _
                    ByVal endTime As Nullable(Of DateTime),  _
                    ByVal lateMinutes As Nullable(Of Integer),  _
                    ByVal earlyMinutes As Nullable(Of Integer),  _
                    ByVal checkIn As Nullable(Of Integer),  _
                    ByVal checkOut As Nullable(Of Integer),  _
                    ByVal checkInTime1 As Nullable(Of DateTime),  _
                    ByVal checkInTime2 As Nullable(Of DateTime),  _
                    ByVal checkOutTime1 As Nullable(Of DateTime),  _
                    ByVal checkOutTime2 As Nullable(Of DateTime),  _
                    ByVal color As Nullable(Of Integer),  _
                    ByVal autoBind As Nullable(Of Short),  _
                    ByVal workDay As Nullable(Of Double),  _
                    ByVal sensorID As String,  _
                    ByVal workMins As Nullable(Of Double),  _
                    ByVal sort As String,  _
                    ByVal maximumRows As Integer,  _
                    ByVal startRowIndex As Integer,  _
                    ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(schClassid, schName, startTime, endTime, lateMinutes, earlyMinutes, checkIn, checkOut, checkInTime1, checkInTime2, checkOutTime1, checkOutTime2, color, autoBind, workDay, sensorID, workMins, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("SchClass", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select]( _
                    ByVal schClassid As Nullable(Of Integer),  _
                    ByVal schName As String,  _
                    ByVal startTime As Nullable(Of DateTime),  _
                    ByVal endTime As Nullable(Of DateTime),  _
                    ByVal lateMinutes As Nullable(Of Integer),  _
                    ByVal earlyMinutes As Nullable(Of Integer),  _
                    ByVal checkIn As Nullable(Of Integer),  _
                    ByVal checkOut As Nullable(Of Integer),  _
                    ByVal checkInTime1 As Nullable(Of DateTime),  _
                    ByVal checkInTime2 As Nullable(Of DateTime),  _
                    ByVal checkOutTime1 As Nullable(Of DateTime),  _
                    ByVal checkOutTime2 As Nullable(Of DateTime),  _
                    ByVal color As Nullable(Of Integer),  _
                    ByVal autoBind As Nullable(Of Short),  _
                    ByVal workDay As Nullable(Of Double),  _
                    ByVal sensorID As String,  _
                    ByVal workMins As Nullable(Of Double)) As List(Of eZee.Data.Objects.SchClass)
            Return [Select](schClassid, schName, startTime, endTime, lateMinutes, earlyMinutes, checkIn, checkOut, checkInTime1, checkInTime2, checkOutTime1, checkOutTime2, color, autoBind, workDay, sensorID, workMins, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal schClassid As Nullable(Of Integer)) As eZee.Data.Objects.SchClass
            Dim list As List(Of eZee.Data.Objects.SchClass) = [Select](schClassid, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.SchClass)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("SchClass", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.SchClass)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.SchClass)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.SchClass)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.SchClass
            Dim list As List(Of eZee.Data.Objects.SchClass) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theSchClass As eZee.Data.Objects.SchClass, ByVal original_SchClass As eZee.Data.Objects.SchClass) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("schClassid", original_SchClass.schClassid, theSchClass.schClassid, true))
            values.Add(New FieldValue("schName", original_SchClass.schName, theSchClass.schName))
            values.Add(New FieldValue("StartTime", original_SchClass.StartTime, theSchClass.StartTime))
            values.Add(New FieldValue("EndTime", original_SchClass.EndTime, theSchClass.EndTime))
            values.Add(New FieldValue("LateMinutes", original_SchClass.LateMinutes, theSchClass.LateMinutes))
            values.Add(New FieldValue("EarlyMinutes", original_SchClass.EarlyMinutes, theSchClass.EarlyMinutes))
            values.Add(New FieldValue("CheckIn", original_SchClass.CheckIn, theSchClass.CheckIn))
            values.Add(New FieldValue("CheckOut", original_SchClass.CheckOut, theSchClass.CheckOut))
            values.Add(New FieldValue("CheckInTime1", original_SchClass.CheckInTime1, theSchClass.CheckInTime1))
            values.Add(New FieldValue("CheckInTime2", original_SchClass.CheckInTime2, theSchClass.CheckInTime2))
            values.Add(New FieldValue("CheckOutTime1", original_SchClass.CheckOutTime1, theSchClass.CheckOutTime1))
            values.Add(New FieldValue("CheckOutTime2", original_SchClass.CheckOutTime2, theSchClass.CheckOutTime2))
            values.Add(New FieldValue("Color", original_SchClass.Color, theSchClass.Color))
            values.Add(New FieldValue("AutoBind", original_SchClass.AutoBind, theSchClass.AutoBind))
            values.Add(New FieldValue("WorkDay", original_SchClass.WorkDay, theSchClass.WorkDay))
            values.Add(New FieldValue("SensorID", original_SchClass.SensorID, theSchClass.SensorID))
            values.Add(New FieldValue("WorkMins", original_SchClass.WorkMins, theSchClass.WorkMins))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theSchClass As eZee.Data.Objects.SchClass, ByVal original_SchClass As eZee.Data.Objects.SchClass, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "SchClass"
            args.View = dataView
            args.Values = CreateFieldValues(theSchClass, original_SchClass)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("SchClass", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theSchClass)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theSchClass As eZee.Data.Objects.SchClass, ByVal original_SchClass As eZee.Data.Objects.SchClass) As Integer
            Return ExecuteAction(theSchClass, original_SchClass, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theSchClass As eZee.Data.Objects.SchClass) As Integer
            Return Update(theSchClass, SelectSingle(theSchClass.schClassid))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theSchClass As eZee.Data.Objects.SchClass) As Integer
            Return ExecuteAction(theSchClass, New SchClass(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theSchClass As eZee.Data.Objects.SchClass) As Integer
            Return ExecuteAction(theSchClass, theSchClass, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
