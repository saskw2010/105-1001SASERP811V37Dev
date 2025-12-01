Imports AjaxControlToolkit
Imports eZee.Data
Imports eZee.Services
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.HtmlControls
Imports System.Web.UI.WebControls

Namespace eZee.Web
    
    Public Enum MenuHoverStyle
        
        [Auto] = 1
        
        Click = 1
        
        ClickAndStay = 1
    End Enum
    
    Public Enum MenuPresentationStyle
        
        MultiLevel
        
        TwoLevel
        
        NavigationButton
    End Enum
    
    Public Enum MenuOrientation
        
        Horizontal
    End Enum
    
    Public Enum MenuPopupPosition
        
        Left
        
        Right
    End Enum
    
    Public Enum MenuItemDescriptionStyle
        
        None
        
        Inline
        
        ToolTip
    End Enum
    
    <TargetControlType(GetType(Panel)),  _
     TargetControlType(GetType(HtmlContainerControl)),  _
     DefaultProperty("TargetControlID")>  _
    Public Class MenuExtender
        Inherits System.Web.UI.WebControls.HierarchicalDataBoundControl
        Implements IExtenderControl
        
        Private m_Items As String
        
        Private m_Sm As ScriptManager
        
        Private m_TargetControlID As String
        
        Private m_Visible As Boolean
        
        Private m_HoverStyle As MenuHoverStyle
        
        Private m_PopupPosition As MenuPopupPosition
        
        Private m_ItemDescriptionStyle As MenuItemDescriptionStyle
        
        Private m_ShowSiteActions As Boolean
        
        <System.Diagnostics.DebuggerBrowsable(System.Diagnostics.DebuggerBrowsableState.Never)>  _
        Private m_PresentationStyle As MenuPresentationStyle
        
        Public Sub New()
            MyBase.New()
            Me.Visible = true
            ItemDescriptionStyle = MenuItemDescriptionStyle.ToolTip
            HoverStyle = MenuHoverStyle.Auto
        End Sub
        
        <IDReferenceProperty(),  _
         Category("Behavior"),  _
         DefaultValue("")>  _
        Public Property TargetControlID() As String
            Get
                Return m_TargetControlID
            End Get
            Set
                m_TargetControlID = value
            End Set
        End Property
        
        <EditorBrowsable(EditorBrowsableState.Never),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Browsable(false)>  _
        Public Overrides Property Visible() As Boolean
            Get
                Return m_Visible
            End Get
            Set
                m_Visible = value
            End Set
        End Property
        
        Public Property HoverStyle() As MenuHoverStyle
            Get
                Return m_HoverStyle
            End Get
            Set
                m_HoverStyle = value
            End Set
        End Property
        
        Public Property PopupPosition() As MenuPopupPosition
            Get
                Return m_PopupPosition
            End Get
            Set
                m_PopupPosition = value
            End Set
        End Property
        
        Public Property ItemDescriptionStyle() As MenuItemDescriptionStyle
            Get
                Return m_ItemDescriptionStyle
            End Get
            Set
                m_ItemDescriptionStyle = value
            End Set
        End Property
        
        <System.ComponentModel.Description("The ""Site Actions"" menu is automatically displayed."),  _
         System.ComponentModel.DefaultValue(false)>  _
        Public Property ShowSiteActions() As Boolean
            Get
                Return m_ShowSiteActions
            End Get
            Set
                m_ShowSiteActions = value
            End Set
        End Property
        
        <System.ComponentModel.Description("Specifies the menu presentation style."),  _
         System.ComponentModel.DefaultValue(MenuPresentationStyle.MultiLevel)>  _
        Public Property PresentationStyle() As MenuPresentationStyle
            Get
                Return Me.m_PresentationStyle
            End Get
            Set
                Me.m_PresentationStyle = value
            End Set
        End Property
        
        Protected Overrides Sub PerformDataBinding()
            MyBase.PerformDataBinding()
            If (Not (IsBoundUsingDataSourceID) AndAlso (Not (DataSource) Is Nothing)) Then
                Return
            End If
            Dim view As HierarchicalDataSourceView = GetData(String.Empty)
            Dim enumerable As IHierarchicalEnumerable = view.Select()
            If (Not (enumerable) Is Nothing) Then
                Dim sb As StringBuilder = New StringBuilder()
                RecursiveDataBindInternal(enumerable, sb)
                m_Items = sb.ToString()
            End If
        End Sub
        
  
        
        Protected Overrides Sub OnInit(ByVal e As EventArgs)
            MyBase.OnInit(e)
            m_Sm = ScriptManager.GetCurrent(Page)
        End Sub
        
        Protected Overrides Sub OnPreRender(ByVal e As EventArgs)
            MyBase.OnPreRender(e)
            If (Nothing Is m_Sm) Then
                Return
            End If
            Dim script As String = String.Format("Web.Menu.Nodes.{0}=[{1}];", Me.ClientID, m_Items)
            Dim target As Control = Page.Form.FindControl(TargetControlID)
            If ((Not (target) Is Nothing) AndAlso target.Visible) Then
                ScriptManager.RegisterStartupScript(Me, GetType(MenuExtender), "Nodes", script, true)
            End If
            m_Sm.RegisterExtenderControl(Of MenuExtender)(Me, target)
        End Sub
        
        Protected Overrides Sub Render(ByVal writer As HtmlTextWriter)
            If ((Nothing Is m_Sm) OrElse m_Sm.IsInAsyncPostBack) Then
                Return
            End If
            m_Sm.RegisterScriptDescriptors(Me)
        End Sub
        
        Function IExtenderControl_GetScriptDescriptors(ByVal targetControl As Control) As IEnumerable(Of ScriptDescriptor) Implements IExtenderControl.GetScriptDescriptors
            Dim descriptor As ScriptBehaviorDescriptor = New ScriptBehaviorDescriptor("Web.Menu", targetControl.ClientID)
            descriptor.AddProperty("id", Me.ClientID)
            If Not ((HoverStyle = MenuHoverStyle.Auto)) Then
                descriptor.AddProperty("hoverStyle", Convert.ToInt32(HoverStyle))
            End If
            If Not ((PopupPosition = MenuPopupPosition.Left)) Then
                descriptor.AddProperty("popupPosition", Convert.ToInt32(PopupPosition))
            End If
            If Not ((ItemDescriptionStyle = MenuItemDescriptionStyle.ToolTip)) Then
                descriptor.AddProperty("itemDescriptionStyle", Convert.ToInt32(ItemDescriptionStyle))
            End If
            If ShowSiteActions Then
                descriptor.AddProperty("showSiteActions", "true")
            End If
            If Not ((PresentationStyle = MenuPresentationStyle.MultiLevel)) Then
                descriptor.AddProperty("presentationStyle", Convert.ToInt32(PresentationStyle))
            End If
            Return New ScriptBehaviorDescriptor() {descriptor}
        End Function
        
        Function IExtenderControl_GetScriptReferences() As IEnumerable(Of ScriptReference) Implements IExtenderControl.GetScriptReferences
            Return AquariumExtenderBase.StandardScripts()
        End Function
    End Class
End Namespace
