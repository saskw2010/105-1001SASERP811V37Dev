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

Partial Public Class Controls_Treewithdataspeed
    Inherits Global.System.Web.UI.UserControl

    'Protected Sub btnExportToPdf_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    PrepareExporter()
    '    treeListExporter.WritePdfToResponse()
    'End Sub
    'Protected Sub btnExportToXls_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    PrepareExporter()
    '    treeListExporter.WriteXlsToResponse()
    'End Sub
    'Protected Sub btnExportToXlsx_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    PrepareExporter()
    '    treeListExporter.WriteXlsxToResponse()
    'End Sub
    'Protected Sub btnExportToRtf_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    PrepareExporter()
    '    treeListExporter.WriteRtfToResponse()
    'End Sub
    'Private Sub PrepareExporter()
    '    treeListExporter.Settings.AutoWidth = chkAutoWidth.Checked
    '    treeListExporter.Settings.ExpandAllNodes = chkExpandAll.Checked
    'End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'If (Not IsPostBack) Then
        '    DataBind()
        '    treeList.ExpandToLevel(5)
        'End If

        'Dim show As Boolean = chkServiceColumns.Checked
        'treeList.Columns("ID").Visible = show
        'treeList.Columns("ParentID").Visible = show
    End Sub
    Public Function getconnection() As ConnectionStringSettings
        Return ConnectionStringSettingsFactory.getconnection()
    End Function

    Private Sub Controls_Treewithdataspeed_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        SqlDataSource1.ConnectionString = ConnectionStringSettingsFactory.getconnection().ConnectionString
        'SqlDataSource2.ConnectionString = ConnectionStringSettingsFactory.getconnection().ConnectionString
        'SqlDataSource3.ConnectionString = ConnectionStringSettingsFactory.getconnection().ConnectionString
    End Sub
End Class
