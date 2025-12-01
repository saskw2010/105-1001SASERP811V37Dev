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
    
    Public Enum DataFieldMaskType
        
        None
        
        [Date]
        
        Number
        
        Time
        
        DateTime
    End Enum
    
    Public Enum DataFieldAggregate
        
        None
        
        Sum
        
        Count
        
        Average
        
        Max
        
        Min
    End Enum
    
    Public Enum OnDemandDisplayStyle
        
        Thumbnail
        
        Link
    End Enum
    
    Public Enum TextInputMode
        
        Text
        
        Password
        
        RichText
        
        Note
        
        [Static]
    End Enum
    
    Public Enum FieldSearchMode
        
        [Default]
        
        Required
        
        Suggested
        
        Allowed
        
        Forbidden
    End Enum
    
    Public Class DataField
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Name As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AliasName As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Tag As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Type As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Len As Integer
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Label As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_IsPrimaryKey As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ReadOnly As Boolean
        
        Private m_DefaultValue As String
        
        Private m_HeaderText As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_FooterText As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ToolTip As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Watermark As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Hidden As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AllowQBE As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AllowSorting As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AllowLEV As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_DataFormatString As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Copy As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_HyperlinkFormatString As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_FormatOnClient As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SourceFields As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_CategoryIndex As Integer
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AllowNulls As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Columns As Integer
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Rows As Integer
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_OnDemand As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Search As FieldSearchMode
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SearchOptions As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ItemsDataController As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ItemsDataView As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ItemsDataValueField As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ItemsDataTextField As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ItemsStyle As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ItemsPageSize As Integer
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ItemsNewDataView As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ItemsLetters As Boolean
        
        Private m_Items As List(Of Object())
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Aggregate As DataFieldAggregate
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_OnDemandHandler As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_OnDemandStyle As OnDemandDisplayStyle
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_TextMode As TextInputMode
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_MaskType As DataFieldMaskType
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Mask As String
        
        Private m_ContextFields As String
        
        Private m_SelectExpression As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Formula As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ShowInSummary As Boolean
        
        Private m_IsMirror As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_HtmlEncode As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AutoCompletePrefixLength As Integer
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Calculated As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Configuration As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_Editor As String
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_AutoSelect As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_SearchOnStart As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_ItemsDescription As String
        
        Public Sub New()
            MyBase.New
            m_Items = New List(Of Object())()
            m_FormatOnClient = true
        End Sub
        
  
        
      
        
 
        
        Public Property Name() As String
            Get
                Return Me.m_Name
            End Get
            Set
                Me.m_Name = value
            End Set
        End Property
        
        Public Property AliasName() As String
            Get
                Return Me.m_AliasName
            End Get
            Set
                Me.m_AliasName = value
            End Set
        End Property
        
        Public Property Tag() As String
            Get
                Return Me.m_Tag
            End Get
            Set
                Me.m_Tag = value
            End Set
        End Property
        
        Public Property Type() As String
            Get
                Return Me.m_Type
            End Get
            Set
                Me.m_Type = value
            End Set
        End Property
        
        Public Property Len() As Integer
            Get
                Return Me.m_Len
            End Get
            Set
                Me.m_Len = value
            End Set
        End Property
        
        Public Property Label() As String
            Get
                Return Me.m_Label
            End Get
            Set
                Me.m_Label = value
            End Set
        End Property
        
        Public Property IsPrimaryKey() As Boolean
            Get
                Return Me.m_IsPrimaryKey
            End Get
            Set
                Me.m_IsPrimaryKey = value
            End Set
        End Property
        
        Public Property [ReadOnly]() As Boolean
            Get
                Return Me.m_ReadOnly
            End Get
            Set
                Me.m_ReadOnly = value
            End Set
        End Property
        
        Public ReadOnly Property DefaultValue() As String
            Get
                Return m_DefaultValue
            End Get
        End Property
        
        Public ReadOnly Property HasDefaultValue() As Boolean
            Get
                Return Not (String.IsNullOrEmpty(m_DefaultValue))
            End Get
        End Property
        
        Public Property HeaderText() As String
            Get
                Return m_HeaderText
            End Get
            Set
                m_HeaderText = value
                If (Not (String.IsNullOrEmpty(value)) AndAlso String.IsNullOrEmpty(m_Label)) Then
                    m_Label = value
                End If
            End Set
        End Property
        
        Public Property FooterText() As String
            Get
                Return Me.m_FooterText
            End Get
            Set
                Me.m_FooterText = value
            End Set
        End Property
        
        Public Property ToolTip() As String
            Get
                Return Me.m_ToolTip
            End Get
            Set
                Me.m_ToolTip = value
            End Set
        End Property
        
        Public Property Watermark() As String
            Get
                Return Me.m_Watermark
            End Get
            Set
                Me.m_Watermark = value
            End Set
        End Property
        
        Public Property Hidden() As Boolean
            Get
                Return Me.m_Hidden
            End Get
            Set
                Me.m_Hidden = value
            End Set
        End Property
        
        Public Property AllowQBE() As Boolean
            Get
                Return Me.m_AllowQBE
            End Get
            Set
                Me.m_AllowQBE = value
            End Set
        End Property
        
        Public Property AllowSorting() As Boolean
            Get
                Return Me.m_AllowSorting
            End Get
            Set
                Me.m_AllowSorting = value
            End Set
        End Property
        
        Public Property AllowLEV() As Boolean
            Get
                Return Me.m_AllowLEV
            End Get
            Set
                Me.m_AllowLEV = value
            End Set
        End Property
        
        Public Property DataFormatString() As String
            Get
                Return Me.m_DataFormatString
            End Get
            Set
                Me.m_DataFormatString = value
            End Set
        End Property
        
        Public Property Copy() As String
            Get
                Return Me.m_Copy
            End Get
            Set
                Me.m_Copy = value
            End Set
        End Property
        
        Public Property HyperlinkFormatString() As String
            Get
                Return Me.m_HyperlinkFormatString
            End Get
            Set
                Me.m_HyperlinkFormatString = value
            End Set
        End Property
        
        Public Property FormatOnClient() As Boolean
            Get
                Return Me.m_FormatOnClient
            End Get
            Set
                Me.m_FormatOnClient = value
            End Set
        End Property
        
        Public Property SourceFields() As String
            Get
                Return Me.m_SourceFields
            End Get
            Set
                Me.m_SourceFields = value
            End Set
        End Property
        
        Public Property CategoryIndex() As Integer
            Get
                Return Me.m_CategoryIndex
            End Get
            Set
                Me.m_CategoryIndex = value
            End Set
        End Property
        
        Public Property AllowNulls() As Boolean
            Get
                Return Me.m_AllowNulls
            End Get
            Set
                Me.m_AllowNulls = value
            End Set
        End Property
        
        Public Property Columns() As Integer
            Get
                Return Me.m_Columns
            End Get
            Set
                Me.m_Columns = value
            End Set
        End Property
        
        Public Property Rows() As Integer
            Get
                Return Me.m_Rows
            End Get
            Set
                Me.m_Rows = value
            End Set
        End Property
        
        Public Property OnDemand() As Boolean
            Get
                Return Me.m_OnDemand
            End Get
            Set
                Me.m_OnDemand = value
            End Set
        End Property
        
        Public Property Search() As FieldSearchMode
            Get
                Return Me.m_Search
            End Get
            Set
                Me.m_Search = value
            End Set
        End Property
        
        Public Overridable Property SearchOptions() As String
            Get
                Return Me.m_SearchOptions
            End Get
            Set
                Me.m_SearchOptions = value
            End Set
        End Property
        
        Public Property ItemsDataController() As String
            Get
                Return Me.m_ItemsDataController
            End Get
            Set
                Me.m_ItemsDataController = value
            End Set
        End Property
        
        Public Property ItemsDataView() As String
            Get
                Return Me.m_ItemsDataView
            End Get
            Set
                Me.m_ItemsDataView = value
            End Set
        End Property
        
        Public Property ItemsDataValueField() As String
            Get
                Return Me.m_ItemsDataValueField
            End Get
            Set
                Me.m_ItemsDataValueField = value
            End Set
        End Property
        
        Public Property ItemsDataTextField() As String
            Get
                Return Me.m_ItemsDataTextField
            End Get
            Set
                Me.m_ItemsDataTextField = value
            End Set
        End Property
        
        Public Property ItemsStyle() As String
            Get
                Return Me.m_ItemsStyle
            End Get
            Set
                Me.m_ItemsStyle = value
            End Set
        End Property
        
        Public Property ItemsPageSize() As Integer
            Get
                Return Me.m_ItemsPageSize
            End Get
            Set
                Me.m_ItemsPageSize = value
            End Set
        End Property
        
        Public Property ItemsNewDataView() As String
            Get
                Return Me.m_ItemsNewDataView
            End Get
            Set
                Me.m_ItemsNewDataView = value
            End Set
        End Property
        
        Public Property ItemsLetters() As Boolean
            Get
                Return Me.m_ItemsLetters
            End Get
            Set
                Me.m_ItemsLetters = value
            End Set
        End Property
        
        Public ReadOnly Property Items() As List(Of Object())
            Get
                Return m_Items
            End Get
        End Property
        
        Public Property Aggregate() As DataFieldAggregate
            Get
                Return Me.m_Aggregate
            End Get
            Set
                Me.m_Aggregate = value
            End Set
        End Property
        
        Public Property OnDemandHandler() As String
            Get
                Return Me.m_OnDemandHandler
            End Get
            Set
                Me.m_OnDemandHandler = value
            End Set
        End Property
        
        Public Property OnDemandStyle() As OnDemandDisplayStyle
            Get
                Return Me.m_OnDemandStyle
            End Get
            Set
                Me.m_OnDemandStyle = value
            End Set
        End Property
        
        Public Property TextMode() As TextInputMode
            Get
                Return Me.m_TextMode
            End Get
            Set
                Me.m_TextMode = value
            End Set
        End Property
        
        Public Property MaskType() As DataFieldMaskType
            Get
                Return Me.m_MaskType
            End Get
            Set
                Me.m_MaskType = value
            End Set
        End Property
        
        Public Property Mask() As String
            Get
                Return Me.m_Mask
            End Get
            Set
                Me.m_Mask = value
            End Set
        End Property
        
        Public ReadOnly Property ContextFields() As String
            Get
                Return m_ContextFields
            End Get
        End Property
        
        Public Property Formula() As String
            Get
                Return Me.m_Formula
            End Get
            Set
                Me.m_Formula = value
            End Set
        End Property
        
        Public Property ShowInSummary() As Boolean
            Get
                Return Me.m_ShowInSummary
            End Get
            Set
                Me.m_ShowInSummary = value
            End Set
        End Property
        
        Public ReadOnly Property IsMirror() As Boolean
            Get
                Return m_IsMirror
            End Get
        End Property
        
        Public Property HtmlEncode() As Boolean
            Get
                Return Me.m_HtmlEncode
            End Get
            Set
                Me.m_HtmlEncode = value
            End Set
        End Property
        
        Public Property AutoCompletePrefixLength() As Integer
            Get
                Return Me.m_AutoCompletePrefixLength
            End Get
            Set
                Me.m_AutoCompletePrefixLength = value
            End Set
        End Property
        
        Public Property Calculated() As Boolean
            Get
                Return Me.m_Calculated
            End Get
            Set
                Me.m_Calculated = value
            End Set
        End Property
        
        Public Property Configuration() As String
            Get
                Return Me.m_Configuration
            End Get
            Set
                Me.m_Configuration = value
            End Set
        End Property
        
        Public Property Editor() As String
            Get
                Return Me.m_Editor
            End Get
            Set
                Me.m_Editor = value
            End Set
        End Property
        
        Public Property AutoSelect() As Boolean
            Get
                Return Me.m_AutoSelect
            End Get
            Set
                Me.m_AutoSelect = value
            End Set
        End Property
        
        Public Property SearchOnStart() As Boolean
            Get
                Return Me.m_SearchOnStart
            End Get
            Set
                Me.m_SearchOnStart = value
            End Set
        End Property
        
        Public Property ItemsDescription() As String
            Get
                Return Me.m_ItemsDescription
            End Get
            Set
                Me.m_ItemsDescription = value
            End Set
        End Property
        
        Public Function SelectExpression() As String
            Return m_SelectExpression
        End Function
        
        Public Sub NormalizeDataFormatString()
            If Not (String.IsNullOrEmpty(m_DataFormatString)) Then
                Dim fmt As String = m_DataFormatString
                If Not (fmt.Contains("{")) Then
                    m_DataFormatString = String.Format("{{0:{0}}}", fmt)
                End If
            Else
                If (m_Type = "DateTime") Then
                    m_DataFormatString = "{0:d}"
                End If
            End If
        End Sub
        
        Public Function ExpressionName() As String
            If IsMirror Then
                Return Name.Substring(0, (Name.Length - "_Mirror".Length))
            End If
            Return Name
        End Function
        
        Public Function SupportsStaticItems() As Boolean
            Return (Not (String.IsNullOrEmpty(ItemsDataController)) AndAlso Not (((ItemsStyle = "AutoComplete") OrElse (ItemsStyle = "Lookup"))))
        End Function
        
        Public Overrides Function ToString() As String
            If Not (String.IsNullOrEmpty(Formula)) Then
                Return String.Format("{0} as {1}; SQL: {2}", Name, Type, Formula)
            Else
                Return String.Format("{0} as {1}", Name, Type)
            End If
        End Function
        
        Public Function IsTagged(ByVal tag As String) As Boolean
            If String.IsNullOrEmpty(Me.Tag) Then
                Return false
            End If
            Return Me.Tag.Contains(tag)
        End Function
    End Class
End Namespace
