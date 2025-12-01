Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Caching
Imports System.Web.Configuration
Imports System.Web.Security
Imports System.Xml
Imports System.Xml.XPath

Namespace eZee.Data
    
    Public Class ViewPage
        
        Private m_SkipCount As Integer
        
        Private m_ReadCount As Integer
        
        Private m_OriginalFilter() As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Tag As String
        
        Private m_RequiresMetaData As Boolean
        
        Private m_RequiresRowCount As Boolean
        
        Private m_Aggregates() As Object
        
        Private m_NewRow() As Object
        
        Private m_Fields As List(Of DataField)
        
        Private m_SortExpression As String
        
        Private m_TotalRowCount As Integer
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PageIndex As Integer
        
        Private m_PageSize As Integer
        
        Private m_PageOffset As Integer
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ClientScript As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_FirstLetters As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Filter() As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SystemFilter() As String
        
        Private m_Rows As List(Of Object())
        
        Private m_DistinctValueFieldName As String
        
        Private m_Views As List(Of View)
        
        Private m_ActionGroups As List(Of ActionGroup)
        
        Private m_Categories As List(Of Category)
        
        Private m_Expressions() As DynamicExpression
        
        Private m_Controller As String
        
        Private m_View As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SupportsCaching As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ViewType As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_LastView As String
        
        Private m_InTransaction As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_StatusBar As String
        
        Private m_AllowDistinctFieldInFilter As Boolean
        
        Private m_Icons() As String
        
        Private m_Levs() As FieldValue
        
        <ThreadStatic()>  _
        Public Shared PopulatingStaticItems As Boolean
        
        Private m_CustomFilter As SortedDictionary(Of String, Object)
        
        Public Sub New()
            Me.New(New PageRequest(0, 0, Nothing, Nothing))
        End Sub
        
        Public Sub New(ByVal request As DistinctValueRequest)
            Me.New(New PageRequest(0, 0, Nothing, request.Filter))
            m_Tag = request.Tag
            m_DistinctValueFieldName = request.FieldName
            m_PageSize = request.MaximumValueCount
            m_AllowDistinctFieldInFilter = request.AllowFieldInFilter
            m_Controller = request.Controller
            m_View = request.View
            m_Filter = request.Filter
        End Sub
        
        Public Sub New(ByVal request As PageRequest)
            MyBase.New
            m_Tag = request.Tag
            Me.PageOffset = request.PageOffset
            m_RequiresMetaData = ((request.PageIndex = -1) OrElse request.RequiresMetaData)
            m_RequiresRowCount = ((request.PageIndex < 0) OrElse request.RequiresRowCount)
            If (request.PageIndex = -2) Then
                request.PageIndex = 0
            End If
            m_PageSize = request.PageSize
            If (request.PageIndex > 0) Then
                m_PageIndex = request.PageIndex
            End If
            m_Rows = New List(Of Object())()
            m_Fields = New List(Of DataField)()
            ResetSkipCount(false)
            m_ReadCount = request.PageSize
            m_SortExpression = request.SortExpression
            m_Filter = request.Filter
            m_SystemFilter = request.SystemFilter
            m_TotalRowCount = -1
            m_Views = New List(Of View)()
            m_ActionGroups = New List(Of ActionGroup)()
            m_Categories = New List(Of Category)()
            m_Controller = request.Controller
            m_View = request.View
            m_InTransaction = Not (String.IsNullOrEmpty(request.Transaction))
            m_LastView = request.LastView
            m_ViewType = request.ViewType
            m_SupportsCaching = request.SupportsCaching
        End Sub
        
        Public Property Tag() As String
            Get
                Return Me.m_Tag
            End Get
            Set
                Me.m_Tag = value
            End Set
        End Property
        
        Public ReadOnly Property RequiresMetaData() As Boolean
            Get
                Return m_RequiresMetaData
            End Get
        End Property
        
        Public ReadOnly Property RequiresRowCount() As Boolean
            Get
                Return m_RequiresRowCount
            End Get
        End Property
        
        Public ReadOnly Property RequiresAggregates() As Boolean
            Get
                For Each field As DataField in Fields
                    If Not ((field.Aggregate = DataFieldAggregate.None)) Then
                        Return true
                    End If
                Next
                Return false
            End Get
        End Property
        
        Public Property Aggregates() As Object()
            Get
                Return m_Aggregates
            End Get
            Set
                m_Aggregates = value
            End Set
        End Property
        
        Public Property NewRow() As Object()
            Get
                Return m_NewRow
            End Get
            Set
                m_NewRow = value
            End Set
        End Property
        
        Public ReadOnly Property Fields() As List(Of DataField)
            Get
                Return m_Fields
            End Get
        End Property
        
        Public Property SortExpression() As String
            Get
                Return m_SortExpression
            End Get
            Set
                m_SortExpression = value
            End Set
        End Property
        
        Public Property TotalRowCount() As Integer
            Get
                Return m_TotalRowCount
            End Get
            Set
                m_TotalRowCount = value
                Dim pageCount As Integer = (value / Me.PageSize)
                If ((value Mod Me.PageSize) > 0) Then
                    pageCount = (pageCount + 1)
                End If
                If (pageCount <= PageIndex) Then
                    Me.m_PageIndex = 0
                End If
            End Set
        End Property
        
        Public Property PageIndex() As Integer
            Get
                Return Me.m_PageIndex
            End Get
            Set
                Me.m_PageIndex = value
            End Set
        End Property
        
        Public ReadOnly Property PageSize() As Integer
            Get
                Return m_PageSize
            End Get
        End Property
        
        Public Property PageOffset() As Integer
            Get
                Return m_PageOffset
            End Get
            Set
                m_PageOffset = value
            End Set
        End Property
        
        Public Property ClientScript() As String
            Get
                Return Me.m_ClientScript
            End Get
            Set
                Me.m_ClientScript = value
            End Set
        End Property
        
        Public Property FirstLetters() As String
            Get
                Return Me.m_FirstLetters
            End Get
            Set
                Me.m_FirstLetters = value
            End Set
        End Property
        
        Public Property Filter() As String()
            Get
                Return Me.m_Filter
            End Get
            Set
                Me.m_Filter = value
            End Set
        End Property
        
        Public Property SystemFilter() As String()
            Get
                Return Me.m_SystemFilter
            End Get
            Set
                Me.m_SystemFilter = value
            End Set
        End Property
        
        Public ReadOnly Property Rows() As List(Of Object())
            Get
                Return m_Rows
            End Get
        End Property
        
        Public ReadOnly Property DistinctValueFieldName() As String
            Get
                Return m_DistinctValueFieldName
            End Get
        End Property
        
        Public ReadOnly Property Views() As List(Of View)
            Get
                Return m_Views
            End Get
        End Property
        
        Public ReadOnly Property ActionGroups() As List(Of ActionGroup)
            Get
                Return m_ActionGroups
            End Get
        End Property
        
        Public ReadOnly Property Categories() As List(Of Category)
            Get
                Return m_Categories
            End Get
        End Property
        
        Public Property Expressions() As DynamicExpression()
            Get
                Return m_Expressions
            End Get
            Set
                m_Expressions = value
            End Set
        End Property
        
        Public ReadOnly Property Controller() As String
            Get
                Return m_Controller
            End Get
        End Property
        
        Public ReadOnly Property View() As String
            Get
                Return m_View
            End Get
        End Property
        
        Public Property SupportsCaching() As Boolean
            Get
                Return Me.m_SupportsCaching
            End Get
            Set
                Me.m_SupportsCaching = value
            End Set
        End Property
        
        Public Property ViewType() As String
            Get
                Return Me.m_ViewType
            End Get
            Set
                Me.m_ViewType = value
            End Set
        End Property
        
        Public Property LastView() As String
            Get
                Return Me.m_LastView
            End Get
            Set
                Me.m_LastView = value
            End Set
        End Property
        
        Public ReadOnly Property InTransaction() As Boolean
            Get
                Return m_InTransaction
            End Get
        End Property
        
        Public Property StatusBar() As String
            Get
                Return Me.m_StatusBar
            End Get
            Set
                Me.m_StatusBar = value
            End Set
        End Property
        
        Public ReadOnly Property AllowDistinctFieldInFilter() As Boolean
            Get
                Return m_AllowDistinctFieldInFilter
            End Get
        End Property
        
        Public Property Icons() As String()
            Get
                Return m_Icons
            End Get
            Set
                m_Icons = value
            End Set
        End Property
        
        Public ReadOnly Property IsAuthenticated() As Boolean
            Get
                Return HttpContext.Current.User.Identity.IsAuthenticated
            End Get
        End Property
        
        Public Property LEVs() As FieldValue()
            Get
                Return m_Levs
            End Get
            Set
                m_Levs = value
            End Set
        End Property
        
        Public Sub ChangeFilter(ByVal filter() As String)
            m_Filter = filter
            m_OriginalFilter = Nothing
        End Sub
        
        Public Function SkipNext() As Boolean
            If (m_SkipCount = 0) Then
                Return false
            End If
            m_SkipCount = (m_SkipCount - 1)
            Return true
        End Function
        
        Public Sub ResetSkipCount(ByVal preFetch As Boolean)
            If preFetch Then
                m_SkipCount = ((m_PageIndex - 1)  _
                            * m_PageSize)
                m_ReadCount = (m_ReadCount * 3)
                If (m_SkipCount < 0) Then
                    m_SkipCount = 0
                    m_ReadCount = (m_ReadCount - m_PageSize)
                End If
            Else
                m_SkipCount = (m_PageIndex * m_PageSize)
            End If
        End Sub
        
        Public Function ReadNext() As Boolean
            If (m_ReadCount = 0) Then
                Return false
            End If
            m_ReadCount = (m_ReadCount - 1)
            Return true
        End Function
        
        Public Sub AcceptAllRows()
            m_ReadCount = Int32.MaxValue
            m_SkipCount = 0
        End Sub
        
        Public Function ContainsField(ByVal name As String) As Boolean
            Return (Not (FindField(name)) Is Nothing)
        End Function
        
        Public Function FindField(ByVal name As String) As DataField
            For Each field As DataField in Fields
                If field.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase) Then
                    Return field
                End If
            Next
            Return Nothing
        End Function
        
        Public Function PopulateStaticItems(ByVal field As DataField, ByVal contextValues() As FieldValue) As Boolean
            If (field.SupportsStaticItems() AndAlso (String.IsNullOrEmpty(field.ContextFields) OrElse ((Not (contextValues) Is Nothing) OrElse (field.ItemsStyle = "CheckBoxList")))) Then
                If PopulatingStaticItems Then
                    Return true
                End If
                PopulatingStaticItems = true
                Try 
                    Dim filter() As String = Nothing
                    If Not (String.IsNullOrEmpty(field.ContextFields)) Then
                        Dim contextFilter As List(Of String) = New List(Of String)()
                        Dim m As Match = Regex.Match(field.ContextFields, "(\w+)=(.+?)($|,)")
                        Do While m.Success
                            Dim vm As Match = Regex.Match(m.Groups(2).Value, "^'(.+?)'$")
                            If vm.Success Then
                                contextFilter.Add(String.Format("{0}:={1}", m.Groups(1).Value, vm.Groups(1).Value))
                            Else
                                If (Not (contextValues) Is Nothing) Then
                                    For Each cv As FieldValue in contextValues
                                        If (cv.Name = m.Groups(2).Value) Then
                                            contextFilter.Add(String.Format("{0}:={1}", m.Groups(1).Value, cv.NewValue))
                                            Exit For
                                        End If
                                    Next
                                End If
                            End If
                            m = m.NextMatch()
                        Loop
                        filter = contextFilter.ToArray()
                    End If
                    Dim request As PageRequest = New PageRequest(-1, 1000, field.ItemsDataTextField, filter)
                    If (Not (ActionArgs.Current) Is Nothing) Then
                        request.ExternalFilter = ActionArgs.Current.ExternalFilter
                    End If
                    Dim page As ViewPage = ControllerFactory.CreateDataController().GetPage(field.ItemsDataController, field.ItemsDataView, request)
                    Dim dataValueFieldIndex As Integer = page.Fields.IndexOf(page.FindField(field.ItemsDataValueField))
                    If (dataValueFieldIndex = -1) Then
                        For Each aField As DataField in page.Fields
                            If aField.IsPrimaryKey Then
                                dataValueFieldIndex = page.Fields.IndexOf(aField)
                                Exit For
                            End If
                        Next
                    End If
                    Dim dataTextFieldIndex As Integer = page.Fields.IndexOf(page.FindField(field.ItemsDataTextField))
                    If (dataTextFieldIndex = -1) Then
                        Dim i As Integer = 0
                        Do While ((dataTextFieldIndex = -1) AndAlso (i < page.Fields.Count))
                            Dim f As DataField = page.Fields(i)
                            If (Not (f.Hidden) AndAlso (f.Type = "String")) Then
                                dataTextFieldIndex = i
                            End If
                            i = (i + 1)
                        Loop
                        If (dataTextFieldIndex = -1) Then
                            dataTextFieldIndex = 0
                        End If
                    End If
                    Dim fieldIndexes As List(Of Integer) = New List(Of Integer)()
                    fieldIndexes.Add(dataValueFieldIndex)
                    fieldIndexes.Add(dataTextFieldIndex)
                    If Not (String.IsNullOrEmpty(field.Copy)) Then
                        Dim m As Match = Regex.Match(field.Copy, "(\w+)=(\w+)")
                        Do While m.Success
                            Dim copyFieldIndex As Integer = page.Fields.IndexOf(page.FindField(m.Groups(2).Value))
                            If (copyFieldIndex >= 0) Then
                                fieldIndexes.Add(copyFieldIndex)
                            End If
                            m = m.NextMatch()
                        Loop
                    End If
                    For Each row() As Object in page.Rows
                        Dim values((fieldIndexes.Count) - 1) As Object
                        Dim i As Integer = 0
                        Do While (i < fieldIndexes.Count)
                            Dim copyFieldIndex As Integer = fieldIndexes(i)
                            If (copyFieldIndex >= 0) Then
                                values(i) = row(copyFieldIndex)
                            End If
                            i = (i + 1)
                        Loop
                        field.Items.Add(values)
                    Next
                    Return true
                Finally
                    PopulatingStaticItems = false
                End Try
            End If
            Return false
        End Function
        
        Public Function ToResult(ByVal configuration As ControllerConfiguration, ByVal mainView As XPathNavigator) As ViewPage
            If Not (m_RequiresMetaData) Then
                Fields.Clear()
                Expressions = Nothing
            Else
                Dim viewIterator As XPathNodeIterator = configuration.Select("/c:dataController/c:views/c:view[not(@virtualViewId!='')]")
                Do While viewIterator.MoveNext()
                    Views.Add(New View(viewIterator.Current, mainView, configuration.Resolver))
                Loop
                Dim actionGroupIterator As XPathNodeIterator = configuration.Select("/c:dataController/c:actions//c:actionGroup")
                Do While actionGroupIterator.MoveNext()
                    ActionGroups.Add(New ActionGroup(actionGroupIterator.Current, configuration.Resolver))
                Loop
                For Each field As DataField in Fields
                    PopulateStaticItems(field, Nothing)
                Next
            End If
            If (Not (m_OriginalFilter) Is Nothing) Then
                m_Filter = m_OriginalFilter
            End If
            If New ControllerUtilities().SupportsLastEnteredValues(Me.Controller) Then
                If (RequiresMetaData AndAlso ((Not (HttpContext.Current) Is Nothing) AndAlso (Not (HttpContext.Current.Session) Is Nothing))) Then
                    LEVs = CType(HttpContext.Current.Session(String.Format("{0}$LEVs", m_Controller)),FieldValue())
                End If
            End If
            DataControllerBase.EnsureJsonCompatibility(NewRow)
            DataControllerBase.EnsureJsonCompatibility(Rows)
            Return Me
        End Function
        
        Public Overloads Function ToDataTable() As DataTable
            Return ToDataTable("table")
        End Function
        
        Public Overloads Function ToDataTable(ByVal tableName As String) As DataTable
            Dim table As DataTable = New DataTable(tableName)
            Dim columnTypes As List(Of Type) = New List(Of Type)()
            For Each field As DataField in Fields
                Dim t As System.Type = GetType(String)
                If Not ((field.Type = "Byte[]")) Then
                    t = DataControllerBase.TypeMap(field.Type)
                End If
                table.Columns.Add(field.Name, t)
                columnTypes.Add(t)
            Next
            For Each row() As Object in Rows
                Dim newRow As DataRow = table.NewRow()
                Dim i As Integer = 0
                Do While (i < Fields.Count)
                    Dim v As Object = row(i)
                    If (v Is Nothing) Then
                        v = DBNull.Value
                    Else
                        Dim t As Type = columnTypes(i)
                        If ((t Is GetType(DateTimeOffset)) AndAlso TypeOf v Is String) Then
                            Dim dto As DateTimeOffset
                            If DateTimeOffset.TryParse(CType(v,String), dto) Then
                                v = dto
                            Else
                                v = DBNull.Value
                            End If
                        End If
                    End If
                    newRow(i) = v
                    i = (i + 1)
                Loop
                table.Rows.Add(newRow)
            Next
            table.AcceptChanges()
            Return table
        End Function
        
        Public Function ToList(Of T)() As List(Of T)
            Dim objectType As Type = GetType(T)
            Dim list As List(Of T) = New List(Of T)()
            Dim args((1) - 1) As Object
            Dim types((Fields.Count) - 1) As Type
            Dim j As Integer = 0
            Do While (j < Fields.Count)
                Dim propInfo As System.Reflection.PropertyInfo = objectType.GetProperty(Fields(j).Name)
                If (Not (propInfo) Is Nothing) Then
                    types(j) = propInfo.PropertyType
                End If
                j = (j + 1)
            Loop
            For Each row() As Object in Rows
                Dim instance As T = CType(objectType.Assembly.CreateInstance(objectType.FullName),T)
                Dim i As Integer = 0
                For Each field As DataField in Fields
                    Try 
                        Dim fieldType As Type = types(i)
                        If (Not (fieldType) Is Nothing) Then
                            args(0) = DataControllerBase.ConvertToType(fieldType, row(i))
                            objectType.InvokeMember(field.Name, System.Reflection.BindingFlags.SetProperty, Nothing, instance, args)
                        End If
                    Catch __exception As Exception
                    End Try
                    i = (i + 1)
                Next
                list.Add(instance)
            Next
            Return list
        End Function
        
        Public Function CustomFilteredBy(ByVal fieldName As String) As Boolean
            Return ((Not (m_CustomFilter) Is Nothing) AndAlso m_CustomFilter.ContainsKey(fieldName))
        End Function
        
        Public Sub ApplyDataFilter(ByVal dataFilter As IDataFilter, ByVal controller As String, ByVal view As String, ByVal lookupContextController As String, ByVal lookupContextView As String, ByVal lookupContextFieldName As String)
            If (dataFilter Is Nothing) Then
                Return
            End If
            If (m_Filter Is Nothing) Then
                m_Filter = New String((0) - 1) {}
            End If
            Dim dataFilter2 As IDataFilter2 = Nothing
            If GetType(IDataFilter2).IsInstanceOfType(dataFilter) Then
                dataFilter2 = CType(dataFilter,IDataFilter2)
                dataFilter2.AssignContext(controller, view, lookupContextController, lookupContextView, lookupContextFieldName)
            End If
            Dim newFilter As List(Of String) = New List(Of String)(m_Filter)
            m_CustomFilter = New SortedDictionary(Of String, Object)()
            If (Not (dataFilter2) Is Nothing) Then
                dataFilter2.Filter(controller, view, m_CustomFilter)
            Else
                dataFilter.Filter(m_CustomFilter)
            End If
            For Each key As String in m_CustomFilter.Keys
                Dim v As Object = m_CustomFilter(key)
                If ((v Is Nothing) OrElse Not (v.GetType().IsArray)) Then
                    v = New Object() {v}
                End If
                Dim sb As StringBuilder = New StringBuilder()
                sb.AppendFormat("{0}:", key)
                For Each item As Object in CType(v,Array)
                    If (Not (dataFilter2) Is Nothing) Then
                        sb.Append(item)
                    Else
                        sb.AppendFormat("={0}", item)
                    End If
                    sb.Append(Convert.ToChar(0))
                Next
                newFilter.Add(sb.ToString())
            Next
            m_OriginalFilter = m_Filter
            m_Filter = newFilter.ToArray()
        End Sub
        
        Public Sub UpdateFieldValue(ByVal fieldName As String, ByVal row() As Object, ByVal value As Object)
            Dim i As Integer = 0
            Do While (i < Fields.Count)
                If Fields(i).Name.Equals(fieldName, StringComparison.InvariantCultureIgnoreCase) Then
                    row(i) = value
                End If
                i = (i + 1)
            Loop
        End Sub
        
        Public Function SelectFieldValue(ByVal fieldName As String, ByVal row() As Object) As Object
            Dim i As Integer = 0
            Do While (i < Fields.Count)
                If Fields(i).Name.Equals(fieldName, StringComparison.InvariantCultureIgnoreCase) Then
                    Return row(i)
                End If
                i = (i + 1)
            Loop
            Return Nothing
        End Function
        
        Public Function SelectFieldValueObject(ByVal fieldName As String, ByVal row() As Object) As FieldValue
            Dim i As Integer = 0
            Do While (i < Fields.Count)
                If Fields(i).Name.Equals(fieldName, StringComparison.InvariantCultureIgnoreCase) Then
                    Return New FieldValue(fieldName, row(i))
                End If
                i = (i + 1)
            Loop
            Return Nothing
        End Function
        
        Public Sub RemoveFromFilter(ByVal fieldName As String)
            If (m_Filter Is Nothing) Then
                Return
            End If
            Dim newFilter As List(Of String) = New List(Of String)(m_Filter)
            Dim prefix As String = (fieldName + ":")
            For Each s As String in newFilter
                If s.StartsWith(prefix) Then
                    newFilter.Remove(s)
                    Exit For
                End If
            Next
            m_Filter = newFilter.ToArray()
        End Sub
    End Class
End Namespace
