Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text
Imports System.Web.Script.Serialization
Imports eZee.Data

Partial Public Class Controls_schoolview
    Inherits Global.System.Web.UI.UserControl

    ''' <summary>
    ''' تحميل الصفحة وإعداد البيانات
    ''' Page load and data setup
    ''' </summary>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadChartData()
        End If
        
        ' Handle refresh postback
        If Request("__EVENTARGUMENT") = "RefreshCharts" Then
            LoadChartData()
        End If
    End Sub

    ''' <summary>
    ''' تحميل بيانات الرسوم البيانية
    ''' Load chart data
    ''' </summary>
    Private Sub LoadChartData()
        Try
            ' Load branch data
            Dim branchData As List(Of ChartDataItem) = GetBranchData()
            hdnBranchData.Value = ConvertToJson(branchData)

            ' Load gender data
            Dim genderData As List(Of ChartDataItem) = GetGenderData()
            hdnGenderData.Value = ConvertToJson(genderData)

            ' Load status data
            Dim statusData As List(Of ChartDataItem) = GetStatusData()
            hdnStatusData.Value = ConvertToJson(statusData)

            ' Load nationality data
            Dim nationalityData As List(Of ChartDataItem) = GetNationalityData()
            hdnNationalityData.Value = ConvertToJson(nationalityData)

        Catch ex As Exception
            ' Handle error and set empty data
            hdnBranchData.Value = "[]"
            hdnGenderData.Value = "[]"
            hdnStatusData.Value = "[]"
            hdnNationalityData.Value = "[]"
        End Try
    End Sub

    ''' <summary>
    ''' الحصول على بيانات الطلاب حسب الفرع
    ''' Get students data by branch
    ''' </summary>
    Private Function GetBranchData() As List(Of ChartDataItem)
        Dim data As New List(Of ChartDataItem)()
        
        Try
            Using conn As New SqlConnection(ConnectionStringSettingsFactory.getconnection().ConnectionString)
                conn.Open()
                
                Dim query As String = "SELECT count([StudentCode]) as valuer, [ThebranchDesc1] FROM [studentcontroller] WHERE [ThebranchDesc1] IS NOT NULL group by [ThebranchDesc1] order by count([StudentCode]) desc"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            data.Add(New ChartDataItem() With {
                                .label = If(reader("ThebranchDesc1") IsNot DBNull.Value, reader("ThebranchDesc1").ToString(), "غير محدد"),
                                .value = Convert.ToInt32(reader("valuer"))
                            })
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            ' Return sample data on error
            data.Add(New ChartDataItem() With {.label = "خطأ في البيانات", .value = 0})
        End Try

        Return data
    End Function

    ''' <summary>
    ''' الحصول على بيانات الطلاب حسب النوع
    ''' Get students data by gender
    ''' </summary>
    Private Function GetGenderData() As List(Of ChartDataItem)
        Dim data As New List(Of ChartDataItem)()
        
        Try
            Using conn As New SqlConnection(ConnectionStringSettingsFactory.getconnection().ConnectionString)
                conn.Open()
                
                Dim query As String = "SELECT count([StudentCode]) as valuer, [GenderGender] FROM [studentcontroller] WHERE [GenderGender] IS NOT NULL group by [GenderGender] order by count([StudentCode]) desc"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim genderLabel As String = If(reader("GenderGender") IsNot DBNull.Value, reader("GenderGender").ToString(), "غير محدد")
                            ' Translate common gender values
                            If genderLabel.ToLower() = "male" OrElse genderLabel = "ذكر" Then
                                genderLabel = "ذكر"
                            ElseIf genderLabel.ToLower() = "female" OrElse genderLabel = "أنثى" Then
                                genderLabel = "أنثى"
                            End If
                            
                            data.Add(New ChartDataItem() With {
                                .label = genderLabel,
                                .value = Convert.ToInt32(reader("valuer"))
                            })
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            data.Add(New ChartDataItem() With {.label = "خطأ في البيانات", .value = 0})
        End Try

        Return data
    End Function

    ''' <summary>
    ''' الحصول على بيانات الطلاب حسب الصفة
    ''' Get students data by status
    ''' </summary>
    Private Function GetStatusData() As List(Of ChartDataItem)
        Dim data As New List(Of ChartDataItem)()
        
        Try
            Using conn As New SqlConnection(ConnectionStringSettingsFactory.getconnection().ConnectionString)
                conn.Open()
                
                Dim query As String = "SELECT count([StudentCode]) as valuer, [studentsefastudentsefaar] FROM [studentcontroller] WHERE [studentsefastudentsefaar] IS NOT NULL group by [studentsefastudentsefaar] order by count([StudentCode]) desc"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            data.Add(New ChartDataItem() With {
                                .label = If(reader("studentsefastudentsefaar") IsNot DBNull.Value, reader("studentsefastudentsefaar").ToString(), "غير محدد"),
                                .value = Convert.ToInt32(reader("valuer"))
                            })
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            data.Add(New ChartDataItem() With {.label = "خطأ في البيانات", .value = 0})
        End Try

        Return data
    End Function

    ''' <summary>
    ''' الحصول على بيانات الطلاب حسب الجنسية
    ''' Get students data by nationality
    ''' </summary>
    Private Function GetNationalityData() As List(Of ChartDataItem)
        Dim data As New List(Of ChartDataItem)()
        
        Try
            Using conn As New SqlConnection(ConnectionStringSettingsFactory.getconnection().ConnectionString)
                conn.Open()
                
                Dim query As String = "SELECT TOP 15 count([StudentCode]) as valuer, [Cntry_Cntry_Nm] FROM [studentcontroller] WHERE [Cntry_Cntry_Nm] IS NOT NULL group by [Cntry_Cntry_Nm] order by count([StudentCode]) desc"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            data.Add(New ChartDataItem() With {
                                .label = If(reader("Cntry_Cntry_Nm") IsNot DBNull.Value, reader("Cntry_Cntry_Nm").ToString(), "غير محدد"),
                                .value = Convert.ToInt32(reader("valuer"))
                            })
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            data.Add(New ChartDataItem() With {.label = "خطأ في البيانات", .value = 0})
        End Try

        Return data
    End Function

    ''' <summary>
    ''' تحويل البيانات إلى JSON
    ''' Convert data to JSON
    ''' </summary>
    Private Function ConvertToJson(ByVal data As List(Of ChartDataItem)) As String
        Dim serializer As New JavaScriptSerializer()
        Return serializer.Serialize(data)
    End Function

    ''' <summary>
    ''' الحصول على إعدادات الاتصال بقاعدة البيانات
    ''' Get database connection settings
    ''' </summary>
    Public Function GetConnection() As ConnectionStringSettings
        Return ConnectionStringSettingsFactory.getconnection()
    End Function

    ''' <summary>
    ''' تهيئة مصادر البيانات
    ''' Initialize data sources
    ''' </summary>
    Private Sub Controls_schoolview_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        Try
            Dim connectionString As String = ConnectionStringSettingsFactory.getconnection().ConnectionString
            
            SqlDataSource1.ConnectionString = connectionString
            SqlDataSource2.ConnectionString = connectionString
            SqlDataSource3.ConnectionString = connectionString
            SqlDataSource4z.ConnectionString = connectionString
            SqlDataSource4x.ConnectionString = connectionString
            
        Catch ex As Exception
            ' Handle connection string initialization error
        End Try
    End Sub

    ''' <summary>
    ''' تصدير البيانات إلى CSV
    ''' Export data to CSV
    ''' </summary>
    Public Sub ExportToCSV(ByVal chartType As String)
        Try
            Dim data As List(Of ChartDataItem) = Nothing
            Dim filename As String = ""
            
            Select Case chartType.ToLower()
                Case "branch"
                    data = GetBranchData()
                    filename = "students_by_branch.csv"
                Case "gender"
                    data = GetGenderData()
                    filename = "students_by_gender.csv"
                Case "status"
                    data = GetStatusData()
                    filename = "students_by_status.csv"
                Case "nationality"
                    data = GetNationalityData()
                    filename = "students_by_nationality.csv"
            End Select
            
            If data IsNot Nothing Then
                ExportDataToCSV(data, filename)
            End If
            
        Catch ex As Exception
            ' Handle export error
        End Try
    End Sub

    ''' <summary>
    ''' تصدير البيانات إلى ملف CSV
    ''' Export data to CSV file
    ''' </summary>
    Private Sub ExportDataToCSV(ByVal data As List(Of ChartDataItem), ByVal filename As String)
        Response.Clear()
        Response.ContentType = "text/csv"
        Response.AddHeader("Content-Disposition", "attachment; filename=" + filename)
        
        Dim csv As New StringBuilder()
        csv.AppendLine("التصنيف,العدد")
        
        For Each item In data
            csv.AppendLine(item.label + "," + item.value.ToString())
        Next
        
        Response.Write(csv.ToString())
        Response.End()
    End Sub

    ''' <summary>
    ''' كلاس عنصر بيانات الرسم البياني
    ''' Chart data item class
    ''' </summary>
    Public Class ChartDataItem
        Public Property label As String
        Public Property value As Integer
    End Class

End Class
