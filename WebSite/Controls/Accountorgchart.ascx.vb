Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Net
Imports System.Web.Script.Serialization
Imports eZee.Data

Partial Public Class Controls_Accountorgchart
    Inherits Global.System.Web.UI.UserControl
    
    ' Modern organizational chart data structures
    Public Class OrgChartNode
        Public Property Id As String
        Public Property Name As String
        Public Property Code As String
        Public Property ParentId As String
        Public Property Level As Integer
        Public Property HasChildren As Boolean
        Public Property IsExpanded As Boolean
        Public Property IsSelected As Boolean
        
        Public Sub New()
            IsExpanded = False
            IsSelected = False
        End Sub
    End Class
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadOrgChartData()
        End If
    End Sub
    
    Public Function getconnection() As ConnectionStringSettings
        Return ConnectionStringSettingsFactory.getconnection()
    End Function

    Private Sub Controls_Accountorgchart_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        Try
            SqlDataSource1.ConnectionString = ConnectionStringSettingsFactory.getconnection().ConnectionString
        Catch ex As Exception
            ' Handle connection error gracefully
        End Try
    End Sub

    ''' <summary>
    ''' Load organizational chart data from database
    ''' </summary>
    Private Sub LoadOrgChartData()
        Try
            Dim orgNodes As List(Of OrgChartNode) = GetOrgChartNodes()
            
            ' Bind to hidden GridView for JavaScript processing
            gvOrgData.DataSource = ConvertToDataTable(orgNodes)
            gvOrgData.DataBind()
            
            ' Register client script with data
            RegisterOrgChartDataScript(orgNodes)
            
        Catch ex As Exception
            ' Handle error and load sample data
            LoadSampleOrgData()
        End Try
    End Sub

    ''' <summary>
    ''' Get organizational chart nodes from database
    ''' </summary>
    Private Function GetOrgChartNodes() As List(Of OrgChartNode)
        Dim nodes As New List(Of OrgChartNode)()
        
        Try
            Using connection As New SqlConnection(getconnection().ConnectionString)
                Dim query As String = "SELECT Acc_Bnd, Acc_Nm, parentid, lvl FROM Qglmfbandviewtree ORDER BY lvl, Acc_Bnd"
                
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim node As New OrgChartNode() With {
                                .Id = If(reader("Acc_Bnd") IsNot DBNull.Value, reader("Acc_Bnd").ToString(), Guid.NewGuid().ToString()),
                                .Name = If(reader("Acc_Nm") IsNot DBNull.Value, reader("Acc_Nm").ToString(), "غير محدد"),
                                .Code = "ACC-" & If(reader("Acc_Bnd") IsNot DBNull.Value, reader("Acc_Bnd").ToString(), "000"),
                                .ParentId = If(reader("parentid") IsNot DBNull.Value AndAlso Not String.IsNullOrEmpty(reader("parentid").ToString()), reader("parentid").ToString(), Nothing),
                                .Level = If(reader("lvl") IsNot DBNull.Value, Convert.ToInt32(reader("lvl")), 1)
                            }
                            nodes.Add(node)
                        End While
                    End Using
                End Using
            End Using
            
            ' Set HasChildren property
            For Each node As OrgChartNode In nodes
                node.HasChildren = nodes.Any(Function(n) n.ParentId = node.Id)
            Next
            
        Catch ex As Exception
            ' Return sample data if database query fails
            Return GetSampleOrgNodes()
        End Try
        
        Return nodes
    End Function

    ''' <summary>
    ''' Get sample organizational chart data for demonstration
    ''' </summary>
    Private Function GetSampleOrgNodes() As List(Of OrgChartNode)
        Dim sampleNodes As New List(Of OrgChartNode)() From {
            New OrgChartNode() With {
                .Id = "1",
                .Name = "الحسابات الرئيسية",
                .Code = "ACC-001",
                .ParentId = Nothing,
                .Level = 1,
                .HasChildren = True
            },
            New OrgChartNode() With {
                .Id = "1001",
                .Name = "الأصول",
                .Code = "ACC-1001",
                .ParentId = "1",
                .Level = 2,
                .HasChildren = True
            },
            New OrgChartNode() With {
                .Id = "1002",
                .Name = "الخصوم",
                .Code = "ACC-1002",
                .ParentId = "1",
                .Level = 2,
                .HasChildren = True
            },
            New OrgChartNode() With {
                .Id = "1003",
                .Name = "حقوق الملكية",
                .Code = "ACC-1003",
                .ParentId = "1",
                .Level = 2,
                .HasChildren = False
            },
            New OrgChartNode() With {
                .Id = "2001",
                .Name = "الأصول الثابتة",
                .Code = "ACC-2001",
                .ParentId = "1001",
                .Level = 3,
                .HasChildren = False
            },
            New OrgChartNode() With {
                .Id = "2002",
                .Name = "الأصول المتداولة",
                .Code = "ACC-2002",
                .ParentId = "1001",
                .Level = 3,
                .HasChildren = False
            },
            New OrgChartNode() With {
                .Id = "2003",
                .Name = "الخصوم قصيرة الأجل",
                .Code = "ACC-2003",
                .ParentId = "1002",
                .Level = 3,
                .HasChildren = False
            },
            New OrgChartNode() With {
                .Id = "2004",
                .Name = "الخصوم طويلة الأجل",
                .Code = "ACC-2004",
                .ParentId = "1002",
                .Level = 3,
                .HasChildren = False
            }
        }
        
        Return sampleNodes
    End Function

    ''' <summary>
    ''' Convert nodes list to DataTable for GridView binding
    ''' </summary>
    Private Function ConvertToDataTable(nodes As List(Of OrgChartNode)) As DataTable
        Dim table As New DataTable()
        table.Columns.Add("Id", GetType(String))
        table.Columns.Add("Name", GetType(String))
        table.Columns.Add("Code", GetType(String))
        table.Columns.Add("ParentId", GetType(String))
        table.Columns.Add("Level", GetType(Integer))
        table.Columns.Add("HasChildren", GetType(Boolean))
        
        For Each node As OrgChartNode In nodes
            table.Rows.Add(node.Id, node.Name, node.Code, node.ParentId, node.Level, node.HasChildren)
        Next
        
        Return table
    End Function

    ''' <summary>
    ''' Register JavaScript with organizational chart data
    ''' </summary>
    Private Sub RegisterOrgChartDataScript(nodes As List(Of OrgChartNode))
        Dim serializer As New JavaScriptSerializer()
        Dim jsonData As String = serializer.Serialize(nodes.Select(Function(n) New With {
            .id = n.Id,
            .name = n.Name,
            .code = n.Code,
            .parentId = n.ParentId,
            .level = n.Level,
            .hasChildren = n.HasChildren
        }))
        
        Dim script As String = String.Format("var serverOrgData = {0};", jsonData)
        Page.ClientScript.RegisterStartupScript(Me.GetType(), "OrgChartData", script, True)
    End Sub

    ''' <summary>
    ''' Load sample data when database connection fails
    ''' </summary>
    Private Sub LoadSampleOrgData()
        Dim sampleNodes As List(Of OrgChartNode) = GetSampleOrgNodes()
        gvOrgData.DataSource = ConvertToDataTable(sampleNodes)
        gvOrgData.DataBind()
        RegisterOrgChartDataScript(sampleNodes)
    End Sub

    ''' <summary>
    ''' Get node hierarchy for specific parent
    ''' </summary>
    Public Function GetNodeHierarchy(parentId As String) As List(Of OrgChartNode)
        Dim allNodes As List(Of OrgChartNode) = GetOrgChartNodes()
        Dim hierarchy As New List(Of OrgChartNode)()
        
        ' Get all children of the specified parent
        Dim children As List(Of OrgChartNode) = allNodes.Where(Function(n) n.ParentId = parentId).ToList()
        
        For Each child As OrgChartNode In children
            hierarchy.Add(child)
            ' Recursively get children of this child
            hierarchy.AddRange(GetNodeHierarchy(child.Id))
        Next
        
        Return hierarchy
    End Function

    ''' <summary>
    ''' Get organization chart statistics
    ''' </summary>
    Public Function GetOrgChartStats() As Object
        Dim nodes As List(Of OrgChartNode) = GetOrgChartNodes()
        
        Return New With {
            .TotalNodes = nodes.Count,
            .MaxLevel = If(nodes.Count > 0, nodes.Max(Function(n) n.Level), 0),
            .RootNodes = nodes.Where(Function(n) String.IsNullOrEmpty(n.ParentId)).Count(),
            .LeafNodes = nodes.Where(Function(n) Not n.HasChildren).Count(),
            .LevelDistribution = nodes.GroupBy(Function(n) n.Level).Select(Function(g) New With {.Level = g.Key, .Count = g.Count()}).OrderBy(Function(x) x.Level)
        }
    End Function
End Class
