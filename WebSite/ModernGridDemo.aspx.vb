Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.Services
Imports System.Web.UI
Imports eZee.Web

Imports System.Web.Security

Partial Class ModernGridDemo
    Inherits PageBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Authentication check is handled by PageBase or web.config
        ' But we can enforce it here if needed
        If Not User.Identity.IsAuthenticated Then
            FormsAuthentication.RedirectToLoginPage()
        End If
    End Sub

    ' Shared method to fetch data
    Private Shared Function FetchData() As DataTable
        Dim dt As New DataTable()
        Dim connStr As String = ConfigurationManager.ConnectionStrings("eZee").ConnectionString

        ' Simplified query for demo purposes
        Dim query As String = "SELECT TOP 100 " & _
                "p.ProjectId, " & _
                "p.ProjectName_Ar AS ProjectName, " & _
                "CASE p.StatusID " & _
                "    WHEN 1 THEN N'Planned' " & _
                "    WHEN 2 THEN N'In Progress' " & _
                "    WHEN 3 THEN N'Completed' " & _
                "    ELSE N'Unknown' " & _
                "END AS StatusName, " & _
                "ISNULL(c.CountryName_En, 'N/A') AS CountryName, " & _
                "p.ProjectCost AS Budget, " & _
                "ISNULL(d.DonorName, 'N/A') AS MainDonorName " & _
                "FROM Projects p WITH (NOLOCK) " & _
                "LEFT JOIN Countries c WITH (NOLOCK) ON p.CountryID = c.CountryID " & _
                "LEFT JOIN Donors d WITH (NOLOCK) ON p.DonorID = d.DonorID " & _
                "ORDER BY p.ProjectId DESC"

        Using conn As New SqlConnection(connStr)
            Using cmd As New SqlCommand(query, conn)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    <WebMethod> _
    Public Shared Function GetData() As Object
        Try
            Dim dt As DataTable = FetchData()
            Dim list As New List(Of Dictionary(Of String, Object))()

            For Each row As DataRow In dt.Rows
                Dim dict As New Dictionary(Of String, Object)()
                For Each col As DataColumn In dt.Columns
                    dict(col.ColumnName) = row(col)
                Next
                list.Add(dict)
            Next

            Return list
        Catch ex As Exception
            Return New With {
                .error = ex.Message,
                .stackTrace = ex.StackTrace
            }
        End Try
    End Function

    Protected Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try
            Dim dt As DataTable = FetchData()
            ExcelExportHelper.Export(dt, "ModernGridExport_Legacy.xlsx", Response)
        Catch ex As Exception
            ' Handle error
            Dim script As String = String.Format("alert('Error: {0}');", ex.Message.Replace("'", "\'"))
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "ErrorAlert", script, True)
        End Try
    End Sub
End Class
