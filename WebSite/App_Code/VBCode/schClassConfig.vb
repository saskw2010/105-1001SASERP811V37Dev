Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Data.Objects
    
    <System.ComponentModel.DataObject(false)>  _
    Partial Public Class schClassConfig
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Classcode As Nullable(Of Long)
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ClassDesc1 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ClassDesc2 As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Remarks As String
        
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
        Public Property classcode() As Nullable(Of Long)
            Get
                Return m_Classcode
            End Get
            Set
                m_Classcode = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ClassDesc1() As String
            Get
                Return m_ClassDesc1
            End Get
            Set
                m_ClassDesc1 = value
            End Set
        End Property
        
        <System.ComponentModel.DataObjectField(false, false, true)>  _
        Public Property ClassDesc2() As String
            Get
                Return m_ClassDesc2
            End Get
            Set
                m_ClassDesc2 = value
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
        
        Public Overloads Shared Function [Select](ByVal classcode As Nullable(Of Long), ByVal classDesc1 As String, ByVal classDesc2 As String, ByVal remarks As String, ByVal modifiedBy As String, ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdOn As Nullable(Of DateTime)) As List(Of eZee.Data.Objects.schClassConfig)
            Return New schClassConfigFactory().Select(classcode, classDesc1, classDesc2, remarks, modifiedBy, modifiedOn, createdBy, createdOn)
        End Function
        
        Public Overloads Shared Function [Select](ByVal qbe As eZee.Data.Objects.schClassConfig) As List(Of eZee.Data.Objects.schClassConfig)
            Return New schClassConfigFactory().Select(qbe)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schClassConfig)
            Return New schClassConfigFactory().Select(filter, sort, dataView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schClassConfig)
            Return New schClassConfigFactory().Select(filter, sort, dataView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schClassConfig)
            Return New schClassConfigFactory().Select(filter, sort, schClassConfigFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal sort As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schClassConfig)
            Return New schClassConfigFactory().Select(filter, sort, schClassConfigFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schClassConfig)
            Return New schClassConfigFactory().Select(filter, Nothing, schClassConfigFactory.SelectView, parameters)
        End Function
        
        Public Overloads Shared Function [Select](ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As List(Of eZee.Data.Objects.schClassConfig)
            Return New schClassConfigFactory().Select(filter, Nothing, schClassConfigFactory.SelectView, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schClassConfig
            Return New schClassConfigFactory().SelectSingle(filter, parameters)
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal filter As String, ByVal ParamArray parameters() as FieldValue) As eZee.Data.Objects.schClassConfig
            Return New schClassConfigFactory().SelectSingle(filter, New BusinessObjectParameters(parameters))
        End Function
        
        Public Overloads Shared Function SelectSingle(ByVal classcode As Nullable(Of Long)) As eZee.Data.Objects.schClassConfig
            Return New schClassConfigFactory().SelectSingle(classcode)
        End Function
        
        Public Function Insert() As Integer
            Return New schClassConfigFactory().Insert(Me)
        End Function
        
        Public Function Update() As Integer
            Return New schClassConfigFactory().Update(Me)
        End Function
        
        Public Function Delete() As Integer
            Return New schClassConfigFactory().Delete(Me)
        End Function
        
        Public Overrides Function ToString() As String
            Return String.Format("classcode: {0}", Me.classcode)
        End Function
    End Class
    
    <System.ComponentModel.DataObject(true)>  _
    Partial Public Class schClassConfigFactory
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Shared ReadOnly Property SelectView() As String
            Get
                Return Controller.GetSelectView("schClassConfig")
            End Get
        End Property
        
        Public Shared ReadOnly Property InsertView() As String
            Get
                Return Controller.GetInsertView("schClassConfig")
            End Get
        End Property
        
        Public Shared ReadOnly Property UpdateView() As String
            Get
                Return Controller.GetUpdateView("schClassConfig")
            End Get
        End Property
        
        Public Shared ReadOnly Property DeleteView() As String
            Get
                Return Controller.GetDeleteView("schClassConfig")
            End Get
        End Property
        
        Public Shared Function Create() As schClassConfigFactory
            Return New schClassConfigFactory()
        End Function
        
        Protected Overridable Function CreateRequest(ByVal classcode As Nullable(Of Long), ByVal classDesc1 As String, ByVal classDesc2 As String, ByVal remarks As String, ByVal modifiedBy As String, ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdOn As Nullable(Of DateTime), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer) As PageRequest
            Dim filter As List(Of String) = New List(Of String)()
            If classcode.HasValue Then
                filter.Add(("classcode:=" + classcode.Value.ToString()))
            End If
            If Not (String.IsNullOrEmpty(classDesc1)) Then
                filter.Add(("ClassDesc1:*" + classDesc1))
            End If
            If Not (String.IsNullOrEmpty(classDesc2)) Then
                filter.Add(("ClassDesc2:*" + classDesc2))
            End If
            If Not (String.IsNullOrEmpty(remarks)) Then
                filter.Add(("Remarks:*" + remarks))
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
        Public Overloads Function [Select](ByVal classcode As Nullable(Of Long), ByVal classDesc1 As String, ByVal classDesc2 As String, ByVal remarks As String, ByVal modifiedBy As String, ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdOn As Nullable(Of DateTime), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As List(Of eZee.Data.Objects.schClassConfig)
            Dim request As PageRequest = CreateRequest(classcode, classDesc1, classDesc2, remarks, modifiedBy, modifiedOn, createdBy, createdOn, sort, maximumRows, startRowIndex)
            request.RequiresMetaData = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schClassConfig", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schClassConfig)()
        End Function
        
        Public Overloads Function [Select](ByVal qbe As eZee.Data.Objects.schClassConfig) As List(Of eZee.Data.Objects.schClassConfig)
            Return [Select](qbe.classcode, qbe.ClassDesc1, qbe.ClassDesc2, qbe.Remarks, qbe.ModifiedBy, qbe.ModifiedOn, qbe.CreatedBy, qbe.CreatedOn)
        End Function
        
        Public Function SelectCount(ByVal classcode As Nullable(Of Long), ByVal classDesc1 As String, ByVal classDesc2 As String, ByVal remarks As String, ByVal modifiedBy As String, ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdOn As Nullable(Of DateTime), ByVal sort As String, ByVal maximumRows As Integer, ByVal startRowIndex As Integer, ByVal dataView As String) As Integer
            Dim request As PageRequest = CreateRequest(classcode, classDesc1, classDesc2, remarks, modifiedBy, modifiedOn, createdBy, createdOn, sort, -1, startRowIndex)
            request.RequiresMetaData = false
            request.RequiresRowCount = true
            Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage("schClassConfig", dataView, request)
            Return page.TotalRowCount
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)>  _
        Public Overloads Function [Select](ByVal classcode As Nullable(Of Long), ByVal classDesc1 As String, ByVal classDesc2 As String, ByVal remarks As String, ByVal modifiedBy As String, ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdOn As Nullable(Of DateTime)) As List(Of eZee.Data.Objects.schClassConfig)
            Return [Select](classcode, classDesc1, classDesc2, remarks, modifiedBy, modifiedOn, createdBy, createdOn, Nothing, Int32.MaxValue, 0, SelectView)
        End Function
        
        Public Overloads Function SelectSingle(ByVal classcode As Nullable(Of Long)) As eZee.Data.Objects.schClassConfig
            Dim list As List(Of eZee.Data.Objects.schClassConfig) = [Select](classcode, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If (list.Count = 0) Then
                Return Nothing
            End If
            Return list(0)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal sort As String, ByVal dataView As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schClassConfig)
            Dim request As PageRequest = New PageRequest(0, Int32.MaxValue, sort, New String(-1) {})
            request.RequiresMetaData = true
            Dim c As IDataController = ControllerFactory.CreateDataController()
            Dim bo As IBusinessObject = CType(c,IBusinessObject)
            bo.AssignFilter(filter, parameters)
            Dim page As ViewPage = c.GetPage("schClassConfig", dataView, request)
            Return page.ToList(Of eZee.Data.Objects.schClassConfig)()
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal sort As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schClassConfig)
            Return [Select](filter, sort, SelectView, parameters)
        End Function
        
        Public Overloads Function [Select](ByVal filter As String, ByVal parameters As BusinessObjectParameters) As List(Of eZee.Data.Objects.schClassConfig)
            Return [Select](filter, Nothing, SelectView, parameters)
        End Function
        
        Public Overloads Function SelectSingle(ByVal filter As String, ByVal parameters As BusinessObjectParameters) As eZee.Data.Objects.schClassConfig
            Dim list As List(Of eZee.Data.Objects.schClassConfig) = [Select](filter, parameters)
            If (list.Count > 0) Then
                Return list(0)
            End If
            Return Nothing
        End Function
        
        Protected Overridable Function CreateFieldValues(ByVal theschClassConfig As eZee.Data.Objects.schClassConfig, ByVal original_schClassConfig As eZee.Data.Objects.schClassConfig) As FieldValue()
            Dim values As List(Of FieldValue) = New List(Of FieldValue)()
            values.Add(New FieldValue("classcode", original_schClassConfig.classcode, theschClassConfig.classcode))
            values.Add(New FieldValue("ClassDesc1", original_schClassConfig.ClassDesc1, theschClassConfig.ClassDesc1))
            values.Add(New FieldValue("ClassDesc2", original_schClassConfig.ClassDesc2, theschClassConfig.ClassDesc2))
            values.Add(New FieldValue("Remarks", original_schClassConfig.Remarks, theschClassConfig.Remarks))
            values.Add(New FieldValue("ModifiedBy", original_schClassConfig.ModifiedBy, theschClassConfig.ModifiedBy))
            values.Add(New FieldValue("ModifiedOn", original_schClassConfig.ModifiedOn, theschClassConfig.ModifiedOn))
            values.Add(New FieldValue("CreatedBy", original_schClassConfig.CreatedBy, theschClassConfig.CreatedBy))
            values.Add(New FieldValue("CreatedOn", original_schClassConfig.CreatedOn, theschClassConfig.CreatedOn))
            Return values.ToArray()
        End Function
        
        Protected Overridable Function ExecuteAction(ByVal theschClassConfig As eZee.Data.Objects.schClassConfig, ByVal original_schClassConfig As eZee.Data.Objects.schClassConfig, ByVal lastCommandName As String, ByVal commandName As String, ByVal dataView As String) As Integer
            Dim args As ActionArgs = New ActionArgs()
            args.Controller = "schClassConfig"
            args.View = dataView
            args.Values = CreateFieldValues(theschClassConfig, original_schClassConfig)
            args.LastCommandName = lastCommandName
            args.CommandName = commandName
            Dim result As ActionResult = ControllerFactory.CreateDataController().Execute("schClassConfig", dataView, args)
            result.RaiseExceptionIfErrors()
            result.AssignTo(theschClassConfig)
            Return result.RowsAffected
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>  _
        Public Overloads Overridable Function Update(ByVal theschClassConfig As eZee.Data.Objects.schClassConfig, ByVal original_schClassConfig As eZee.Data.Objects.schClassConfig) As Integer
            Return ExecuteAction(theschClassConfig, original_schClassConfig, "Edit", "Update", UpdateView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)>  _
        Public Overloads Overridable Function Update(ByVal theschClassConfig As eZee.Data.Objects.schClassConfig) As Integer
            Return Update(theschClassConfig, SelectSingle(theschClassConfig.classcode))
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)>  _
        Public Overridable Function Insert(ByVal theschClassConfig As eZee.Data.Objects.schClassConfig) As Integer
            Return ExecuteAction(theschClassConfig, New schClassConfig(), "New", "Insert", InsertView)
        End Function
        
        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)>  _
        Public Overridable Function Delete(ByVal theschClassConfig As eZee.Data.Objects.schClassConfig) As Integer
            Return ExecuteAction(theschClassConfig, theschClassConfig, "Select", "Delete", DeleteView)
        End Function
    End Class
End Namespace
