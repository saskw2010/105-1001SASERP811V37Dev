Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports Telerik.Web.UI

Partial Public Class Pages_daynamiclist
    Inherits Global.eZee.Web.PageBase

    Public ReadOnly Property CssClass() As String
        Get
            Return ""
        End Get
    End Property

    Protected Overloads Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim keyval As String = GetResourcemossoqury()
        Extender1.Controller = keyval ' ControllerDropDown.SelectedValue

    End Sub
    Protected Function GetResourcemossoqury() As String

        Dim keyval As String
        If IsNothing(HttpContext.Current.Request.QueryString("Querypage")) = False Then
            keyval = HttpContext.Current.Request.QueryString("Querypage")
            If String.IsNullOrEmpty(keyval) Or String.IsNullOrWhiteSpace(keyval) Then
                Return "_dates"
            Else
                Return keyval
            End If
        Else
            Return "_dates"
        End If

    End Function
    Public Shared Function MyMapPath(path As String) As String
        If HttpContext.Current.Request.ApplicationPath = "/" Then
        Else
            path = HttpContext.Current.Request.ApplicationPath + path

        End If
        Return HttpContext.Current.Server.MapPath(path)

    End Function


    Private Sub RadMenu1_ItemDataBound(sender As Object, e As RadMenuEventArgs) Handles RadMenu1.ItemDataBound
        e.Item.ToolTip = translatemeyamosso.GetResourceValuemosso(CStr(DataBinder.Eval(e.Item.DataItem, "title")))
        e.Item.Text = translatemeyamosso.GetResourceValuemosso(CStr(DataBinder.Eval(e.Item.DataItem, "title")))

        Dim spage As String = Path.GetFileName(e.Item.NavigateUrl)
        If Right(spage, 5) = ".aspx" Then
            spage = Left(spage, Len(spage) - 5)
        End If
        e.Item.Value = spage
        e.Item.NavigateUrl = ""
    End Sub

    Public Sub RadDropDownTree1_EntryAdded(sender As Object, e As DropDownTreeEntryEventArgs) Handles RadDropDownTree1.EntryAdded
        Extender1.Controller = RadDropDownTree1.SelectedText
    End Sub

    Public Sub RadDropDownTree1_EntryRemoved(sender As Object, e As DropDownTreeEntryEventArgs) Handles RadDropDownTree1.EntryRemoved

    End Sub
    'Protected Sub ControllerDropDown_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ControllerDropDown.SelectedIndexChanged
    '    Extender1.Controller = ControllerDropDown.SelectedValue
    'End Sub


    Protected Sub RadMenu1_ItemClick(sender As Object, e As RadMenuEventArgs) Handles RadMenu1.ItemClick
        Dim spage As String = e.Item.Value
        Dim filpathe As String = MyMapPath("/Controllers")

        If (System.IO.File.Exists(filpathe + "\" + spage + ".xml")) Then
            '' e.Item.NavigateUrl = "~/Pages/daynamiclist.aspx?Querypage=" + spage
            Extender1.Controller = spage
        Else
            '' e.Item.NavigateUrl = "~/Pages/daynamiclist.aspx?Querypage=" + "_dates"

            Extender1.Controller = "_dates"
        End If
    End Sub

    Private Sub RadDropDownTree1_NodeDataBound(sender As Object, e As DropDownTreeNodeDataBoundEventArguments) Handles RadDropDownTree1.NodeDataBound
        e.DropDownTreeNode.Value = ""

    End Sub
End Class
