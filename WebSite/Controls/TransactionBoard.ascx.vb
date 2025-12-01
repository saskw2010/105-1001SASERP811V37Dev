Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports Telerik.Web.UI
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Net
Imports eZee.Data


Partial Public Class Controls_TransactionBoard
    Inherits Global.System.Web.UI.UserControl
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
    End Sub
    Public Function getconnection() As ConnectionStringSettings
        Return ConnectionStringSettingsFactory.getconnection()
    End Function

    Private Sub Controls_Gridwithdata_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        SqlDataSource1.ConnectionString = ConnectionStringSettingsFactory.getconnection().ConnectionString
        'SqlDataSource2.ConnectionString = ConnectionStringSettingsFactory.getconnection().ConnectionString
        'SqlDataSource3.ConnectionString = ConnectionStringSettingsFactory.getconnection().ConnectionString
    End Sub
End Class
