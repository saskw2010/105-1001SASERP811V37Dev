Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data.SqlClient
Imports System.Data
Imports eZee


Partial Public Class Controls_Student_GridTemplete
    Inherits Global.System.Web.UI.UserControl
    Private cnn As New SqlConnection(DataLogic.GetConnectionString())
    Private Dadapter As New SqlDataAdapter()
    Private dt As New DataTable()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load


        'Dim dtrightads As New DataTable()
        'Dim SQLrightads As String = "SELECT *  from schreportpath  order by schidauto asc"

        'Dim cmdrightads As New SqlCommand(SQLrightads, cnn)
        'Dadapter.SelectCommand = cmdrightads
        'Dadapter.Fill(dtrightads)

        'Rerightads.DataSource = dtrightads
        'Rerightads.DataBind()
        'cnn.Close()

    End Sub
End Class
