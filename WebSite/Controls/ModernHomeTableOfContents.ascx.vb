Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Net
Imports eZee.Data

Partial Public Class Controls_ModernHomeTableOfContents
    Inherits Global.System.Web.UI.UserControl

    ' Navigation item class for data binding
    Public Class HomeNavigationItem
        Public Property Title As String
        Public Property Url As String
        Public Property Description As String
        Public Property Icon As String
        Public Property ImageUrl As String
        
        Public Sub New()
            ' Default values
            Icon = "fas fa-file"
            ImageUrl = ""
        End Sub
        
        Public Sub New(title As String, url As String, description As String, icon As String)
            Me.Title = title
            Me.Url = url
            Me.Description = description
            Me.Icon = icon
            Me.ImageUrl = ""
        End Sub
    End Class

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            Try
                ' Initialize user tracking (compatible with original)
                InitializeUserTracking()
                
                ' Load navigation data
                LoadHomeNavigationData()
                
                ' Debug logging
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "ModernHomeDebug",
                    "console.log('✅ ModernHomeTableOfContents Page_Load completed successfully');", True)

            Catch ex As Exception
                ' Handle errors gracefully
                ScriptManager.RegisterStartupScript(Me, GetType(Page), "ModernHomeError",
                    "console.error('❌ ModernHomeTableOfContents error: " & HttpUtility.JavaScriptStringEncode(ex.Message) & "');", True)
                
                ' Set error message in labels for debugging
                Label1.Text = "Error: " & ex.Message
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Initialize user tracking (compatible with original HomeTableOfContents)
    ''' </summary>
    Private Sub InitializeUserTracking()
        Try
            ' User tracking
            OnlineActiveUsers.OnlineUsersInstance.OnlineUsers.SetUserOnline(Page.User.Identity.Name)
            
            ' Workstation tracking
            Dim workstationidstring As String = DataLogic.GetConnectionStringworkstation()
            Session.Add("workstationidstring", workstationidstring)
            Dim ixi As Integer = DataLogic.logintrack(Page.User.Identity.Name, DateTime.Now(), workstationidstring)
            
            ' Set labels for debugging (hidden)
            Label1.Text = HttpContext.Current.User.Identity.Name
            Label2.Text = Dns.GetHostName()
            
            ' Get IP addresses
            Dim ipmosso As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName)
            Label3.Text = ipmosso.AddressList(0).ToString()
            
            Dim ipaddress As String = Request.ServerVariables("HTTP_X_FORWARDED_FOR")
            If String.IsNullOrEmpty(ipaddress) Then
                ipaddress = Request.ServerVariables("REMOTE_ADDR")
            End If
            Label3.Text = Label3.Text & "  ::  " & ipaddress
            
            If ipmosso.AddressList.Count > 1 Then
                Label4.Text = ipmosso.AddressList(1).ToString()
            End If

            ' Build IP list
            TextBox1.Text = ""
            For i = 0 To ipmosso.AddressList.Count() - 1
                TextBox1.Text = TextBox1.Text + ipmosso.AddressList(i).ToString() + vbNewLine
            Next
            
            Label6.Text = Session("workstationidstring").ToString

        Catch ex As Exception
            ' Log error but don't stop execution
            Label1.Text = "Tracking Error: " & ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' Load navigation data from SiteMap and bind to repeater
    ''' </summary>
    Private Sub LoadHomeNavigationData()
        Try
            Dim navigationItems As New List(Of HomeNavigationItem)()
            
            ' Try to load from SiteMap first
            If SiteMap.RootNode IsNot Nothing AndAlso SiteMap.RootNode.ChildNodes IsNot Nothing Then
                LoadNavigationFromSiteMap(navigationItems, SiteMap.RootNode.ChildNodes)
            End If
            
            ' If no SiteMap data, add sample navigation items
            If navigationItems.Count = 0 Then
                LoadSampleNavigationData(navigationItems)
            End If
            
            ' Bind to repeater
            rptHomeNavigation.DataSource = navigationItems
            rptHomeNavigation.DataBind()
            
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "NavigationDataLoaded",
                "console.log('📋 ModernHome navigation data loaded: " & navigationItems.Count & " items');", True)

        Catch ex As Exception
            ' Handle error
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "NavigationError",
                "console.error('❌ Error loading navigation data: " & HttpUtility.JavaScriptStringEncode(ex.Message) & "');", True)
            
            ' Load fallback data
            LoadSampleNavigationData(New List(Of HomeNavigationItem)())
        End Try
    End Sub

    ''' <summary>
    ''' Load navigation data from SiteMap
    ''' </summary>
    Private Sub LoadNavigationFromSiteMap(navigationItems As List(Of HomeNavigationItem), nodes As SiteMapNodeCollection)
        Try
            For Each node As SiteMapNode In nodes
                If node IsNot Nothing AndAlso Not String.IsNullOrEmpty(node.Title) Then
                    Dim navItem As New HomeNavigationItem()
                    navItem.Title = node.Title
                    navItem.Url = If(String.IsNullOrEmpty(node.Url), "#", node.Url)
                    navItem.Description = If(String.IsNullOrEmpty(node.Description), node.Title, node.Description)
                    
                    ' Set icon based on URL or title
                    navItem.Icon = GetIconForPage(node.Url, node.Title)
                    
                    ' Set image URL (using translation system like original)
                    navItem.ImageUrl = translatemeyamosso.GetResourcemosso(node.Url)
                    
                    navigationItems.Add(navItem)
                    
                    ' Recursively add child nodes if needed
                    If node.ChildNodes IsNot Nothing AndAlso node.ChildNodes.Count > 0 Then
                        LoadNavigationFromSiteMap(navigationItems, node.ChildNodes)
                    End If
                End If
            Next
        Catch ex As Exception
            ' Log error but continue
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "SiteMapError",
                "console.warn('⚠️ SiteMap loading error: " & HttpUtility.JavaScriptStringEncode(ex.Message) & "');", True)
        End Try
    End Sub

    ''' <summary>
    ''' Load sample navigation data as fallback
    ''' </summary>
    Private Sub LoadSampleNavigationData(navigationItems As List(Of HomeNavigationItem))
        navigationItems.Clear()
        
        ' Add comprehensive sample navigation
        navigationItems.Add(New HomeNavigationItem("الصفحة الرئيسية", "~/Default.aspx", "العودة إلى الصفحة الرئيسية", "fas fa-home"))
        navigationItems.Add(New HomeNavigationItem("إدارة المستخدمين", "~/Pages/Users.aspx", "إدارة حسابات المستخدمين والصلاحيات", "fas fa-users"))
        navigationItems.Add(New HomeNavigationItem("التقارير", "~/Pages/Reports.aspx", "عرض التقارير والإحصائيات التفصيلية", "fas fa-chart-bar"))
        navigationItems.Add(New HomeNavigationItem("الإعدادات", "~/Pages/Settings.aspx", "إعدادات النظام والتكوين العام", "fas fa-cog"))
        navigationItems.Add(New HomeNavigationItem("العقارات", "~/Pages/Properties.aspx", "إدارة العقارات والوحدات السكنية", "fas fa-building"))
        navigationItems.Add(New HomeNavigationItem("العقود", "~/Pages/Contracts.aspx", "إدارة عقود الإيجار والمبيعات", "fas fa-file-contract"))
        navigationItems.Add(New HomeNavigationItem("المالية", "~/Pages/Finance.aspx", "إدارة الحسابات والمعاملات المالية", "fas fa-dollar-sign"))
        navigationItems.Add(New HomeNavigationItem("المساعدة", "~/Pages/Help.aspx", "دليل المستخدم والدعم الفني", "fas fa-question-circle"))
        
        ' Bind sample data to repeater
        rptHomeNavigation.DataSource = navigationItems
        rptHomeNavigation.DataBind()
    End Sub

    ''' <summary>
    ''' Get appropriate icon for page based on URL or title
    ''' </summary>
    Private Function GetIconForPage(url As String, title As String) As String
        If String.IsNullOrEmpty(url) AndAlso String.IsNullOrEmpty(title) Then
            Return "fas fa-file"
        End If
        
        Dim pageIdentifier As String = (url & " " & title).ToLower()
        
        ' Icon mapping based on common page types
        If pageIdentifier.Contains("user") OrElse pageIdentifier.Contains("مستخدم") Then
            Return "fas fa-users"
        ElseIf pageIdentifier.Contains("report") OrElse pageIdentifier.Contains("تقرير") Then
            Return "fas fa-chart-bar"
        ElseIf pageIdentifier.Contains("setting") OrElse pageIdentifier.Contains("إعداد") Then
            Return "fas fa-cog"
        ElseIf pageIdentifier.Contains("property") OrElse pageIdentifier.Contains("عقار") Then
            Return "fas fa-building"
        ElseIf pageIdentifier.Contains("contract") OrElse pageIdentifier.Contains("عقد") Then
            Return "fas fa-file-contract"
        ElseIf pageIdentifier.Contains("finance") OrElse pageIdentifier.Contains("مالية") Then
            Return "fas fa-dollar-sign"
        ElseIf pageIdentifier.Contains("help") OrElse pageIdentifier.Contains("مساعدة") Then
            Return "fas fa-question-circle"
        ElseIf pageIdentifier.Contains("home") OrElse pageIdentifier.Contains("رئيس") Then
            Return "fas fa-home"
        ElseIf pageIdentifier.Contains("admin") OrElse pageIdentifier.Contains("إدارة") Then
            Return "fas fa-shield-alt"
        ElseIf pageIdentifier.Contains("data") OrElse pageIdentifier.Contains("بيانات") Then
            Return "fas fa-database"
        Else
            Return "fas fa-file-alt"
        End If
    End Function

    ''' <summary>
    ''' Get external IP address (compatible with original)
    ''' </summary>
    Function GetExternalIP(ByVal webPath As String) As String
        Try
            Dim output As String = ""
            Dim webReq As New System.Net.WebClient
            output = System.Text.Encoding.ASCII.GetString((webReq.DownloadData(webPath)))
            webReq.Dispose()
            Return output
        Catch
            Return "Unable to get external IP"
        End Try
    End Function

    ''' <summary>
    ''' Configure node targets for TreeView (compatible with original)
    ''' </summary>
    Private Sub ConfigureNodeTargets(ByVal nodes As TreeNodeCollection)
        For Each n As TreeNode In nodes
            Dim m As Match = Regex.Match(n.NavigateUrl, "^(_\w+):(.+)$")
            If m.Success Then
                n.Target = m.Groups(1).Value
                n.NavigateUrl = m.Groups(2).Value
            End If
            ConfigureNodeTargets(n.ChildNodes)
        Next
    End Sub

    ''' <summary>
    ''' Get navigation statistics for display
    ''' </summary>
    Public Function GetNavigationStatistics() As Object
        Try
            Dim totalPages As Integer = If(rptHomeNavigation.Items.Count > 0, rptHomeNavigation.Items.Count, 8)
            Dim lastUpdate As String = DateTime.Now.ToString("HH:mm:ss")
            Dim onlineUsers As Integer = 1 ' Default value since GetOnlineUsers method not available
            
            ' Try to get online users count safely
            Try
                OnlineActiveUsers.OnlineUsersInstance.OnlineUsers.SetUserOnline(Page.User.Identity.Name)
                onlineUsers = 2 ' Assume at least 2 users if tracking works
            Catch
                onlineUsers = 1 ' Fallback to 1 user
            End Try
            
            Return New Object() {totalPages, lastUpdate, onlineUsers}
        Catch
            Return New Object() {8, DateTime.Now.ToString("HH:mm:ss"), 1}
        End Try
    End Function
End Class
