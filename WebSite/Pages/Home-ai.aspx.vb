Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports eZee.Data

Partial Public Class Pages_Home_ai
    Inherits Global.eZee.Web.PageBase

    Public ReadOnly Property CssClass() As String
        Get
            Return "HomePage Wide"
        End Get
    End Property

    Protected Overloads Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If IsPostBack Then
        Else

            Dim sqlstatmentcheck As String = "select count(*) as tecko from orders"
            Dim tekost As Object
            tekost = DataLogic.GetValue(sqlstatmentcheck)
            If tekost > 0 Then
                Dim message As String = "alert('Hello! Mudassar.')"
                ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "alert", message, True)


            End If
        End If
    End Sub

End Class
