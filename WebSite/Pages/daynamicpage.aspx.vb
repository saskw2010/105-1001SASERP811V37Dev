Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class Pages_daynamicpage
    Inherits Global.eZee.Web.PageBase

    Public ReadOnly Property CssClass() As String
        Get
            Return ""
        End Get
    End Property

    Protected Overloads Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim keyval As String = GetResourcemossoqury()
        Extender1.Controller = keyval ' ControllerDropDown.SelectedValue
        Dim keyval1 As String = GetResourcemossoqury1()
        Extender2.Controller = keyval1 ' ControllerDropDown.SelectedValue

        If keyval = "_nolink" Then
            Extender1.Controller = "dayofweek"
            Div1.Visible = False
        End If
        If keyval1 = "_nolink" Then
            Extender2.Controller = "dayofweek"
            div2.Visible = False
        End If

        Dim keyval2 As String = GetResourcemossoqury2()
        If keyval2 = "_nolink" Then
        Else
            Extender2.FilterSource = "Extender1"
            Extender2.FilterFields = keyval2
        End If

    End Sub
    Protected Function GetResourcemossoqury() As String

        Dim keyval As String
        If IsNothing(HttpContext.Current.Request.QueryString("_Querypage")) = False Then
            keyval = HttpContext.Current.Request.QueryString("_Querypage")
            If String.IsNullOrEmpty(keyval) Or String.IsNullOrWhiteSpace(keyval) Then
                Return "_nolink"
            Else
                Return keyval
            End If
        Else
            Return "_nolink"
        End If

    End Function
    Protected Function GetResourcemossoqury1() As String
        Dim keyval As String
        If IsNothing(HttpContext.Current.Request.QueryString("_Querypage1")) = False Then
            keyval = HttpContext.Current.Request.QueryString("_Querypage1")
            If String.IsNullOrEmpty(keyval) Or String.IsNullOrWhiteSpace(keyval) Then
                Return "_nolink"
            Else
                Return keyval
            End If
        Else
            Return "_nolink"
        End If

    End Function
    Protected Function GetResourcemossoqury2() As String
        Dim keyval As String
        If IsNothing(HttpContext.Current.Request.QueryString("_FilterFields")) = False Then
            keyval = HttpContext.Current.Request.QueryString("_FilterFields")
            If String.IsNullOrEmpty(keyval) Or String.IsNullOrWhiteSpace(keyval) Then
                Return "_nolink"
            Else
                Return keyval
            End If
        Else
            Return "_nolink"
        End If

    End Function
    Public Shared Function MyMapPath(path As String) As String
        If HttpContext.Current.Request.ApplicationPath = "/" Then
        Else
            path = HttpContext.Current.Request.ApplicationPath + path

        End If
        Return HttpContext.Current.Server.MapPath(path)

    End Function

End Class
