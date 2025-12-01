Imports System
Imports System.Web.UI
Imports System.Collections.Generic
Imports System.Text

Partial Class TestPages_ASPXADV_TestNavigationData
    Inherits System.Web.UI.Page

    #Region "Helper Classes"
    
    Public Class NavigationItem
        Public Property Title As String
        Public Property Url As String
        Public Property Description As String
        Public Property HasChildren As Boolean
    End Class
    
    #End Region

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then
                LoadNavigationDebugInfo()
                LoadNavigationData()
                
                ' Add console logging for debugging
                Page.ClientScript.RegisterStartupScript(Me.GetType(), "testPageLoad", 
                    "console.log('🗺️ Navigation Data Test Page loaded at: " & DateTime.Now.ToString("HH:mm:ss") & "');", True)
                
                System.Diagnostics.Debug.WriteLine("🗺️ Navigation Data Test Page initialized successfully")
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in TestNavigationData Page_Load: " & ex.Message)
            ShowError("حدث خطأ في تحميل صفحة اختبار البيانات: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadNavigationDebugInfo()
        Try
            ' SiteMap Provider Information
            Dim siteMapProvider = SiteMap.Provider
            If siteMapProvider IsNot Nothing Then
                litSiteMapProvider.Text = siteMapProvider.GetType().Name
                
                If siteMapProvider.RootNode IsNot Nothing Then
                    litRootNode.Text = siteMapProvider.RootNode.Title
                    litTotalNodes.Text = CountAllNodes(siteMapProvider.RootNode).ToString()
                    litTopLevelItems.Text = siteMapProvider.RootNode.ChildNodes.Count.ToString()
                Else
                    litRootNode.Text = "NULL"
                    litTotalNodes.Text = "0"
                    litTopLevelItems.Text = "0"
                End If
                
                litSecurityEnabled.Text = siteMapProvider.SecurityTrimmingEnabled.ToString()
            Else
                litSiteMapProvider.Text = "NULL"
                litRootNode.Text = "NULL"
                litTotalNodes.Text = "0"
                litTopLevelItems.Text = "0"
                litSecurityEnabled.Text = "False"
            End If

            ' Navigation Items Count
            Dim navigationItems = GetNavigationItems()
            litNavigationItems.Text = navigationItems.Count.ToString()
            litPropertiesGenerated.Text = navigationItems.Where(Function(n) Not n.HasChildren).Count().ToString()

            ' Debug Information
            Dim siteMapDebug As New StringBuilder()
            siteMapDebug.AppendLine("SiteMap Provider: " & If(siteMapProvider IsNot Nothing, siteMapProvider.GetType().Name, "NULL"))
            siteMapDebug.AppendLine("Security Trimming: " & If(siteMapProvider IsNot Nothing, siteMapProvider.SecurityTrimmingEnabled.ToString(), "Unknown"))
            siteMapDebug.AppendLine("Root Node URL: " & If(siteMapProvider IsNot Nothing AndAlso siteMapProvider.RootNode IsNot Nothing, siteMapProvider.RootNode.Url, "NULL"))
            If siteMapProvider IsNot Nothing AndAlso siteMapProvider.RootNode IsNot Nothing Then
                siteMapDebug.AppendLine("Child Nodes: " & siteMapProvider.RootNode.ChildNodes.Count.ToString())
            End If
            litSiteMapDebug.Text = siteMapDebug.ToString()

            Dim navDebug As New StringBuilder()
            navDebug.AppendLine("Navigation Items Found: " & navigationItems.Count.ToString())
            navDebug.AppendLine("Items with Children: " & navigationItems.Where(Function(n) n.HasChildren).Count().ToString())
            navDebug.AppendLine("Items without Children: " & navigationItems.Where(Function(n) Not n.HasChildren).Count().ToString())
            navDebug.AppendLine("Sample Items:")
            For i As Integer = 0 To Math.Min(4, navigationItems.Count - 1)
                navDebug.AppendLine("  " & (i + 1).ToString() & ". " & navigationItems(i).Title)
            Next
            litNavigationDebug.Text = navDebug.ToString()

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error loading navigation debug info: " & ex.Message)
            litSiteMapProvider.Text = "ERROR: " & ex.Message
        End Try
    End Sub

    Private Sub LoadNavigationData()
        Try
            Dim navigationItems = GetNavigationItems()
            
            ' Take first 12 items for preview
            Dim previewItems = navigationItems.Take(12).ToList()
            
            rptNavigationData.DataSource = previewItems
            rptNavigationData.DataBind()
            
            System.Diagnostics.Debug.WriteLine("🗺️ Navigation data loaded for preview: " & previewItems.Count & " items")
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error loading navigation data: " & ex.Message)
            ShowError("حدث خطأ في تحميل بيانات الـ Navigation: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Get navigation items from SiteMap
    ''' </summary>
    Private Function GetNavigationItems() As List(Of NavigationItem)
        Dim items As New List(Of NavigationItem)
        
        Try
            ' Get sitemap provider
            Dim siteMapProvider = SiteMap.Provider
            If siteMapProvider IsNot Nothing AndAlso siteMapProvider.RootNode IsNot Nothing Then
                
                ' Get all top-level menu items
                For Each childNode As SiteMapNode In siteMapProvider.RootNode.ChildNodes
                    If childNode.HasChildNodes Then
                        ' Add main menu item
                        items.Add(New NavigationItem With {
                            .Title = CleanMenuTitle(childNode.Title),
                            .Url = If(String.IsNullOrEmpty(childNode.Url), "#", childNode.Url),
                            .Description = childNode.Description,
                            .HasChildren = True
                        })
                        
                        ' Add sub-menu items as separate entries
                        For Each subNode As SiteMapNode In childNode.ChildNodes
                            items.Add(New NavigationItem With {
                                .Title = CleanMenuTitle(subNode.Title),
                                .Url = If(String.IsNullOrEmpty(subNode.Url), "#", subNode.Url),
                                .Description = subNode.Description,
                                .HasChildren = subNode.HasChildNodes
                            })
                        Next
                    End If
                Next
                
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error getting navigation items: " & ex.Message)
        End Try
        
        Return items
    End Function

    ''' <summary>
    ''' Clean menu title from translation markers
    ''' </summary>
    Private Function CleanMenuTitle(title As String) As String
        If String.IsNullOrEmpty(title) Then Return ""
        
        ' Remove translation markers like ^SiteHome^Home^SiteHome^
        Dim cleanTitle = title
        If cleanTitle.Contains("^") Then
            Dim parts = cleanTitle.Split("^"c)
            If parts.Length >= 3 Then
                cleanTitle = parts(2) ' Take the middle part
            End If
        End If
        
        Return cleanTitle.Trim()
    End Function

    ''' <summary>
    ''' Count all nodes recursively
    ''' </summary>
    Private Function CountAllNodes(node As SiteMapNode) As Integer
        Dim count As Integer = 1 ' Current node
        
        If node.HasChildNodes Then
            For Each childNode As SiteMapNode In node.ChildNodes
                count += CountAllNodes(childNode)
            Next
        End If
        
        Return count
    End Function

    Private Sub ShowError(message As String)
        Try
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "error", 
                "console.error('Navigation Test Error: " & message.Replace("'", "\'") & "');", True)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error showing error message: " & ex.Message)
        End Try
    End Sub

End Class
