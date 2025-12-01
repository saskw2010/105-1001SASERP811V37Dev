Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports eZee.Web
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Xml.XPath
Imports System.Xml
Imports System.ComponentModel
Imports System.Text
Imports System.Data.SqlClient
Imports translatemeyamosso
Imports System.Configuration
Imports System.Data.Common
Imports System.IO
Imports System.Transactions
Imports System.Web
Imports System.Web.Caching
Imports System.Web.Configuration
Imports System.Web.Security
Imports System.Xml.Xsl
Imports System.Reflection
Imports eZee.Data.Objects
Imports Telerik
Imports Telerik.Web
Imports Telerik.Web.UI
Imports DataLogic
Imports Microsoft.VisualBasic



Namespace eZee.Data

    Partial Public Class View

        Public Sub New(ByVal view As XPathNavigator, ByVal mainView As XPathNavigator, ByVal resolver As IXmlNamespaceResolver)
            MyBase.New()
            Me.m_Id = view.GetAttribute("id", String.Empty)
            Me.m_Type = view.GetAttribute("type", String.Empty)
            If (Me.m_Id = mainView.GetAttribute("virtualViewId", String.Empty)) Then
                view = mainView
            End If
            Me.m_Label = GetResourceValuemosso(view.GetAttribute("label", String.Empty))
            Me.m_HeaderText = GetResourceValuemosso(CType(view.Evaluate("string(c:headerText)", resolver), String))
            m_Group = view.GetAttribute("group", String.Empty)
            m_ShowInSelector = Not ((view.GetAttribute("showInSelector", String.Empty) = "false"))
        End Sub

    End Class

    Partial Public Class Category
        Public Sub New(ByVal category As XPathNavigator, ByVal resolver As IXmlNamespaceResolver)
            MyBase.New()
            Me.Id = category.GetAttribute("id", String.Empty)
            Me.m_Index = Convert.ToInt32(category.Evaluate("count(preceding-sibling::c:category)", resolver))
            Me.m_HeaderText = GetResourceValuemosso(CType(category.GetAttribute("headerText", String.Empty), String))
            Me.m_Description = GetResourceValuemosso(CType(category.Evaluate("string(c:description)", resolver), String).Trim())
            m_Tab = GetResourceValuemosso(CType(category.GetAttribute("tab", String.Empty), String).Trim())

            m_NewColumn = (category.GetAttribute("newColumn", String.Empty) = "true")
            m_Template = CType(category.Evaluate("string(c:template)", resolver), String)
            m_Floating = (category.GetAttribute("floating", String.Empty) = "true")
            m_Collapsed = (category.GetAttribute("collapsed", String.Empty) = "true")
        End Sub
    End Class

    Partial Public Class DataField

        Public Sub New(ByVal field As XPathNavigator, ByVal nm As IXmlNamespaceResolver, ByVal hidden As Boolean)
            Me.New(field, nm)
            Me.m_Hidden = hidden
        End Sub


        Public Sub New(ByVal field As XPathNavigator, ByVal nm As IXmlNamespaceResolver)
            Me.New()
            Me.m_Name = field.GetAttribute("name", String.Empty)
            Me.m_Type = field.GetAttribute("type", String.Empty)
            Dim l As String = field.GetAttribute("length", String.Empty)
            If Not (String.IsNullOrEmpty(l)) Then
                m_Len = Convert.ToInt32(l)
            End If
            Me.m_Label = GetResourceValuemosso(field.GetAttribute("label", String.Empty))
            Me.m_IsPrimaryKey = (field.GetAttribute("isPrimaryKey", String.Empty) = "true")
            Me.m_ReadOnly = (field.GetAttribute("readOnly", String.Empty) = "true")
            Me.m_OnDemand = (field.GetAttribute("onDemand", String.Empty) = "true")
            Me.m_DefaultValue = field.GetAttribute("default", String.Empty)
            Me.m_AllowNulls = Not ((field.GetAttribute("allowNulls", String.Empty) = "false"))
            Me.m_Hidden = (field.GetAttribute("hidden", String.Empty) = "true")
            Me.m_AllowQBE = Not ((field.GetAttribute("allowQBE", String.Empty) = "false"))
            Me.m_AllowLEV = (field.GetAttribute("allowLEV", String.Empty) = "true")
            Me.m_AllowSorting = Not ((field.GetAttribute("allowSorting", String.Empty) = "false"))
            Me.m_SourceFields = field.GetAttribute("sourceFields", String.Empty)
            If (field.GetAttribute("onDemandStyle", String.Empty) = "Link") Then
                Me.m_OnDemandStyle = OnDemandDisplayStyle.Link
            End If
            Me.m_OnDemandHandler = field.GetAttribute("onDemandHandler", String.Empty)
            Me.m_ContextFields = field.GetAttribute("contextFields", String.Empty)
            Me.m_SelectExpression = field.GetAttribute("select", String.Empty)
            Dim computed As Boolean = (field.GetAttribute("computed", String.Empty) = "true")
            If computed Then
                m_Formula = CType(field.Evaluate("string(self::c:field/c:formula)", nm), String)
                Dim firststring As String = Nothing
                firststring = "mosso9000010000mosso"
                m_Formula = Regex.Replace(m_Formula, firststring, "NVARCHAR(MAX),DECRYPTBYKEYAUTOASYMKEY(ASYMKEY_ID('AsymKeyPwd'), N'17SomeHiddenPassword!76'")

                If String.IsNullOrEmpty(m_Formula) Then
                    m_Formula = "null"
                End If
            End If
            Me.m_ShowInSummary = (field.GetAttribute("showInSummary", String.Empty) = "true")
            Me.m_HtmlEncode = Not ((field.GetAttribute("htmlEncode", String.Empty) = "false"))
            m_Calculated = (field.GetAttribute("calculated", String.Empty) = "true")
            Me.m_Configuration = CType(field.Evaluate("string(self::c:field/c:configuration)", nm), String)
            Me.m_DataFormatString = field.GetAttribute("dataFormatString", String.Empty)
            m_FormatOnClient = Not ((field.GetAttribute("formatOnClient", String.Empty) = "false"))
            Dim editor As String = field.GetAttribute("editor", String.Empty)
            If Not (String.IsNullOrEmpty(editor)) Then
                m_Editor = editor
            End If
        End Sub

        Public Sub New(ByVal field As DataField)
            Me.New()
            Me.m_IsMirror = True
            Me.m_Name = (field.Name + "_Mirror")
            Me.m_Type = field.Type
            Me.m_Len = field.Len
            Me.m_Label = GetResourceValuemosso(field.Label)
            Me.m_ReadOnly = True
            Me.m_AllowNulls = field.AllowNulls
            Me.m_AllowQBE = field.AllowQBE
            Me.m_AllowSorting = field.AllowSorting
            Me.m_AllowLEV = field.AllowLEV
            Me.m_DataFormatString = field.DataFormatString
            Me.m_Aggregate = field.Aggregate
            If Not (Me.m_DataFormatString.Contains("{")) Then
                Me.m_DataFormatString = String.Format("{{0:{0}}}", Me.m_DataFormatString)
            End If
            field.m_AliasName = Me.m_Name
            Me.FormatOnClient = False
            field.FormatOnClient = True
            field.DataFormatString = String.Empty
            Me.m_Hidden = True
        End Sub



    End Class

End Namespace
Namespace eZee.Web
    Partial Public Class MenuExtender
        Public Sub RecursiveDataBindInternal(ByVal enumerable As IHierarchicalEnumerable, ByVal sb As StringBuilder)
            Dim first As Boolean = True
            If (Not (Me.Site) Is Nothing) Then
                Return
            End If
            For Each item As Object In enumerable
                Dim data As IHierarchyData = enumerable.GetHierarchyData(item)
                If (Not (data) Is Nothing) Then
                    Dim props As PropertyDescriptorCollection = TypeDescriptor.GetProperties(data)
                    If (props.Count > 0) Then
                        Dim title As String = GetResourceValuemosso(CType(props("Title").GetValue(data), String))
                        Dim description As String = GetResourceValuemosso(CType(props("Description").GetValue(data), String))
                        Dim url As String = CType(props("Url").GetValue(data), String)
                        If first Then
                            first = False
                        Else
                            sb.Append(",")
                        End If
                        sb.AppendFormat("{{'title':'{0}','url':'{1}'", title, BusinessRules.JavaScriptString(url))
                        If Not (String.IsNullOrEmpty(description)) Then
                            sb.AppendFormat(",'description':'{0}'", description)
                        End If
                        If (url = Page.Request.RawUrl) Then
                            sb.Append(",'selected':true")
                        End If
                        If data.HasChildren Then
                            Dim childEnumerable As IHierarchicalEnumerable = data.GetChildren()
                            If (Not (childEnumerable) Is Nothing) Then
                                sb.Append(",'children':[")
                                RecursiveDataBindInternal(childEnumerable, sb)
                                sb.Append("]")
                            End If
                        End If
                        sb.Append("}")
                    End If
                End If
            Next
        End Sub
    End Class
End Namespace
