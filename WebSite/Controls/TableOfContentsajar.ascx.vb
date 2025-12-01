Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Xml
Imports System.IO
Imports translatemeyamosso

Partial Public Class Controls_TableOfContentsajar
    Inherits Global.System.Web.UI.UserControl
    
    ' Ajar-specific navigation data structures
    Public Class AjarNavigationItem
        Public Property Title As String
        Public Property Url As String
        Public Property Description As String
        Public Property Icon As String
        Public Property Category As String
        Public Property IsActive As Boolean
        
        Public Sub New()
            IsActive = True
        End Sub
    End Class

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadAjarNavigationData()
        End If
    End Sub

    ''' <summary>
    ''' Load Ajar-specific navigation data from sitemap
    ''' </summary>
    Private Sub LoadAjarNavigationData()
        Try
            Dim ajarItems As New List(Of AjarNavigationItem)()
            
            ' Get sitemap data specific to Ajar modules
            Dim siteMap As SiteMapNode = SiteMap.RootNode
            If siteMap IsNot Nothing Then
                ProcessAjarSiteMapNode(siteMap, ajarItems)
            End If
            
            ' If no sitemap data, load default Ajar modules
            If ajarItems.Count = 0 Then
                LoadDefaultAjarModules(ajarItems)
            End If
            
            ' Bind to repeater
            rptAjarNavigation.DataSource = ajarItems
            rptAjarNavigation.DataBind()
            
        Catch ex As Exception
            ' Load default modules on error
            LoadDefaultAjarModules(New List(Of AjarNavigationItem)())
        End Try
    End Sub

    ''' <summary>
    ''' Process sitemap nodes for Ajar-specific modules
    ''' </summary>
    Private Sub ProcessAjarSiteMapNode(node As SiteMapNode, ajarItems As List(Of AjarNavigationItem))
        If node Is Nothing Then Return
        
        ' Filter for Ajar-related modules
        If IsAjarRelatedNode(node) Then
            Dim navItem As New AjarNavigationItem() With {
                .Title = node.Title,
                .Url = ResolveUrl(node.Url),
                .Description = If(String.IsNullOrEmpty(node.Description), GetDefaultDescription(node.Title), node.Description),
                .Icon = GetAjarIconForNode(node.Title),
                .Category = GetNodeCategory(node.Title)
            }
            ajarItems.Add(navItem)
        End If
        
        ' Process child nodes
        If node.ChildNodes IsNot Nothing Then
            For Each childNode As SiteMapNode In node.ChildNodes
                ProcessAjarSiteMapNode(childNode, ajarItems)
            Next
        End If
    End Sub

    ''' <summary>
    ''' Check if node is related to Ajar (rental management)
    ''' </summary>
    Private Function IsAjarRelatedNode(node As SiteMapNode) As Boolean
        If node Is Nothing OrElse String.IsNullOrEmpty(node.Title) Then Return False
        
        Dim title As String = node.Title.ToLower()
        Return title.Contains("ajar") OrElse 
               title.Contains("rent") OrElse 
               title.Contains("property") OrElse 
               title.Contains("contract") OrElse 
               title.Contains("tenant") OrElse
               title.Contains("إيجار") OrElse
               title.Contains("عقار") OrElse
               title.Contains("مستأجر") OrElse
               title.Contains("عقد")
    End Function

    ''' <summary>
    ''' Get appropriate icon for Ajar modules
    ''' </summary>
    Private Function GetAjarIconForNode(title As String) As String
        If String.IsNullOrEmpty(title) Then Return "fas fa-home"
        
        title = title.ToLower()
        
        If title.Contains("property") OrElse title.Contains("عقار") Then
            Return "fas fa-building"
        ElseIf title.Contains("contract") OrElse title.Contains("عقد") Then
            Return "fas fa-file-contract"
        ElseIf title.Contains("tenant") OrElse title.Contains("مستأجر") Then
            Return "fas fa-users"
        ElseIf title.Contains("payment") OrElse title.Contains("دفع") Then
            Return "fas fa-dollar-sign"
        ElseIf title.Contains("maintenance") OrElse title.Contains("صيانة") Then
            Return "fas fa-tools"
        ElseIf title.Contains("report") OrElse title.Contains("تقرير") Then
            Return "fas fa-chart-line"
        Else
            Return "fas fa-home"
        End If
    End Function

    ''' <summary>
    ''' Get node category for organization
    ''' </summary>
    Private Function GetNodeCategory(title As String) As String
        If String.IsNullOrEmpty(title) Then Return "General"
        
        title = title.ToLower()
        
        If title.Contains("financial") OrElse title.Contains("مالي") Then
            Return "Financial"
        ElseIf title.Contains("management") OrElse title.Contains("إدارة") Then
            Return "Management"
        ElseIf title.Contains("report") OrElse title.Contains("تقرير") Then
            Return "Reporting"
        Else
            Return "Operations"
        End If
    End Function

    ''' <summary>
    ''' Get default description for nodes
    ''' </summary>
    Private Function GetDefaultDescription(title As String) As String
        If String.IsNullOrEmpty(title) Then Return "وحدة النظام"
        
        Return "إدارة " & title & " في نظام الإيجارات"
    End Function

    ''' <summary>
    ''' Load default Ajar modules when sitemap is not available
    ''' </summary>
    Private Sub LoadDefaultAjarModules(ajarItems As List(Of AjarNavigationItem))
        ajarItems.Clear()
        
        ajarItems.AddRange(New AjarNavigationItem() {
            New AjarNavigationItem() With {
                .Title = "إدارة العقارات",
                .Url = "~/Pages/Properties.aspx",
                .Description = "عرض وإدارة جميع العقارات والوحدات السكنية",
                .Icon = "fas fa-building",
                .Category = "Management"
            },
            New AjarNavigationItem() With {
                .Title = "عقود الإيجار",
                .Url = "~/Pages/Contracts.aspx",
                .Description = "إنشاء وإدارة عقود الإيجار للمستأجرين",
                .Icon = "fas fa-file-contract",
                .Category = "Operations"
            },
            New AjarNavigationItem() With {
                .Title = "إدارة المستأجرين",
                .Url = "~/Pages/Tenants.aspx",
                .Description = "قاعدة بيانات المستأجرين ومعلوماتهم",
                .Icon = "fas fa-users",
                .Category = "Management"
            },
            New AjarNavigationItem() With {
                .Title = "الدفعات والفواتير",
                .Url = "~/Pages/Payments.aspx",
                .Description = "تتبع المدفوعات وإصدار الفواتير",
                .Icon = "fas fa-dollar-sign",
                .Category = "Financial"
            },
            New AjarNavigationItem() With {
                .Title = "الصيانة والخدمات",
                .Url = "~/Pages/Maintenance.aspx",
                .Description = "إدارة طلبات الصيانة والخدمات",
                .Icon = "fas fa-tools",
                .Category = "Operations"
            },
            New AjarNavigationItem() With {
                .Title = "التقارير المالية",
                .Url = "~/Pages/FinancialReports.aspx",
                .Description = "تقارير الأرباح والخسائر والإحصائيات",
                .Icon = "fas fa-chart-line",
                .Category = "Reporting"
            }
        })
        
        rptAjarNavigation.DataSource = ajarItems
        rptAjarNavigation.DataBind()
    End Sub
End Class
