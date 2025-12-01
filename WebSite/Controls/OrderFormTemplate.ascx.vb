Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
' add for translate 
Imports translatemeyamosso

Partial Public Class Controls_OrderFormTemplate
    Inherits Global.System.Web.UI.UserControl
   
    Public Sub CheckControls(parent As Control)
        For Each c As Control In parent.Controls
            If (c.[GetType]() = GetType(Label)) Then

                DirectCast(c, Label).Text = GetResourceValuemosso(DirectCast(c, Label).Text)
                'If DirectCast(c, Label).Text = "0" Then
                '    'Hide Panel1
                'End If
            End If
            If c.HasControls() Then
                CheckControls(c)
            End If
        Next
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CheckControls(Me.Page)
    End Sub
End Class
