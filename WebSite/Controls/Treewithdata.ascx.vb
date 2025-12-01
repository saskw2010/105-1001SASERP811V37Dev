Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports eZee.Data

Partial Public Class Controls_Treewithdata
    Inherits Global.System.Web.UI.UserControl

    ''' <summary>
    ''' تحميل الصفحة وبناء الشجرة
    ''' Page load and tree building
    ''' </summary>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BuildModernTree()
        End If
    End Sub

    ''' <summary>
    ''' بناء شجرة حديثة من البيانات
    ''' Build modern tree from data
    ''' </summary>
    Private Sub BuildModernTree()
        Try
            Dim treeData As DataTable = GetTreeData()
            If treeData IsNot Nothing AndAlso treeData.Rows.Count > 0 Then
                Dim treeHtml As String = GenerateTreeHTML(treeData)
                litTreeContent.Text = treeHtml
            Else
                litTreeContent.Text = GenerateEmptyTreeMessage()
            End If

        Catch ex As Exception
            litTreeContent.Text = GenerateErrorMessage(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' الحصول على بيانات الشجرة من قاعدة البيانات
    ''' Get tree data from database
    ''' </summary>
    Private Function GetTreeData() As DataTable
        Dim dt As New DataTable()

        Try
            Using conn As New SqlConnection(ConnectionStringSettingsFactory.getconnection().ConnectionString)
                conn.Open()
                
                Dim query As String = "SELECT * FROM Qglmfbandviewtree ORDER BY lvl, Acc_Bnd"
                Using cmd As New SqlCommand(query, conn)
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            Throw New Exception("خطأ في استرداد بيانات الشجرة: " & ex.Message)
        End Try

        Return dt
    End Function

    ''' <summary>
    ''' إنشاء HTML للشجرة الحديثة
    ''' Generate modern tree HTML
    ''' </summary>
    Private Function GenerateTreeHTML(ByVal data As DataTable) As String
        Dim html As New System.Text.StringBuilder()
        Dim processedNodes As New HashSet(Of String)
        
        ' Group data by parent ID to create hierarchy
        Dim groupedData = data.AsEnumerable().GroupBy(Function(row) row.Field(Of Object)("parentid"))
        Dim dataLookup = groupedData.ToDictionary(Function(g) g.Key, Function(g) g.ToList())
        
        ' Start building from root nodes (parentid is null or empty)
        Dim rootNodes = dataLookup.Where(Function(kvp) kvp.Key Is Nothing OrElse kvp.Key.ToString() = "").SelectMany(Function(kvp) kvp.Value).ToList()
        
        For Each rootNode In rootNodes
            html.Append(GenerateNodeHTML(rootNode, dataLookup, processedNodes, 0))
        Next

        Return html.ToString()
    End Function

    ''' <summary>
    ''' إنشاء HTML لعقدة واحدة مع أطفالها
    ''' Generate HTML for a single node with its children
    ''' </summary>
    Private Function GenerateNodeHTML(ByVal node As DataRow, ByVal dataLookup As Dictionary(Of Object, List(Of DataRow)), ByVal processedNodes As HashSet(Of String), ByVal level As Integer) As String
        Dim html As New System.Text.StringBuilder()
        
        Dim nodeId As String = node("Acc_Bnd").ToString()
        Dim nodeName As String = node("Acc_Nm").ToString()
        
        ' Avoid infinite recursion
        If processedNodes.Contains(nodeId) Then
            Return ""
        End If
        processedNodes.Add(nodeId)
        
        ' Get children for this node
        Dim hasChildren As Boolean = dataLookup.ContainsKey(nodeId) AndAlso dataLookup(nodeId).Count > 0
        
        ' Determine node classes based on level and properties
        Dim nodeClasses As String = GetNodeClasses(level, hasChildren)
        
        ' Start node
        html.AppendLine("<div class='tree-node " & nodeClasses & "' data-id='" & HttpUtility.HtmlEncode(nodeId) & "' data-name='" & HttpUtility.HtmlEncode(nodeName) & "' data-level='" & level.ToString() & "'>")
        html.AppendLine("    <span class='node-text'>" & HttpUtility.HtmlEncode(nodeName) & "</span>")
        html.AppendLine("</div>")
        
        ' Add children if they exist
        If hasChildren Then
            html.AppendLine("<div class='tree-children expanded'>")
            
            For Each childNode In dataLookup(nodeId).OrderBy(Function(row) row("Acc_Bnd").ToString())
                html.Append(GenerateNodeHTML(childNode, dataLookup, processedNodes, level + 1))
            Next
            
            html.AppendLine("</div>")
        End If
        
        Return html.ToString()
    End Function

    ''' <summary>
    ''' تحديد فئات CSS للعقدة حسب المستوى والخصائص
    ''' Determine CSS classes for node based on level and properties
    ''' </summary>
    Private Function GetNodeClasses(ByVal level As Integer, ByVal hasChildren As Boolean) As String
        Dim classes As New List(Of String)
        
        ' Add level class
        classes.Add("level-" & level.ToString())
        
        ' Add expandable class if has children
        If hasChildren Then
            classes.Add("expandable")
        End If
        
        ' Add checkable class for levels 5 and above (leaf nodes typically)
        If level >= 5 Then
            classes.Add("checkable")
        End If
        
        Return String.Join(" ", classes)
    End Function

    ''' <summary>
    ''' إنشاء رسالة فارغة عند عدم وجود بيانات
    ''' Generate empty message when no data exists
    ''' </summary>
    Private Function GenerateEmptyTreeMessage() As String
        Return "<div class='tree-loading'>" & vbCrLf &
               "    <i class='fas fa-info-circle'></i>" & vbCrLf &
               "    <p>لا توجد بيانات متاحة لعرض الشجرة</p>" & vbCrLf &
               "</div>"
    End Function

    ''' <summary>
    ''' إنشاء رسالة خطأ
    ''' Generate error message
    ''' </summary>
    Private Function GenerateErrorMessage(ByVal errorMessage As String) As String
        Return "<div class='tree-loading'>" & vbCrLf &
               "    <i class='fas fa-exclamation-triangle' style='color: #ef4444;'></i>" & vbCrLf &
               "    <p style='color: #ef4444;'>خطأ في تحميل بيانات الشجرة</p>" & vbCrLf &
               "    <p style='font-size: 0.9rem; color: #64748b;'>" & HttpUtility.HtmlEncode(errorMessage) & "</p>" & vbCrLf &
               "</div>"
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
    Private Sub Controls_Treewithdata_Init(sender As Object, e As System.EventArgs) Handles Me.Init
        Try
            SqlDataSource1.ConnectionString = ConnectionStringSettingsFactory.getconnection().ConnectionString
        Catch ex As Exception
            ' Handle connection string initialization error
        End Try
    End Sub

    ''' <summary>
    ''' الحصول على العناصر المحددة
    ''' Get selected items
    ''' </summary>
    Public Function GetSelectedItems() As String()
        If Not String.IsNullOrEmpty(MyTextBox.Text) Then
            Return MyTextBox.Text.Split(","c)
        End If
        Return New String() {}
    End Function

    ''' <summary>
    ''' تحديد العناصر المحددة
    ''' Set selected items
    ''' </summary>
    Public Sub SetSelectedItems(ByVal selectedIds As String())
        If selectedIds IsNot Nothing AndAlso selectedIds.Length > 0 Then
            MyTextBox.Text = String.Join(",", selectedIds)
        Else
            MyTextBox.Text = ""
        End If
    End Sub

    ''' <summary>
    ''' تحديث الشجرة مع البيانات الجديدة
    ''' Refresh tree with new data
    ''' </summary>
    Public Sub RefreshTree()
        BuildModernTree()
    End Sub

End Class
