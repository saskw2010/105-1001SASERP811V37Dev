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

Partial Public Class Controls_ajarDashBoard
    Inherits Global.System.Web.UI.UserControl
    
    ' Modern dashboard data structures
    Public Class NavigationCategory
        Public Property Title As String
        Public Property Modules As List(Of NavigationModule)
        
        Public Sub New()
            Modules = New List(Of NavigationModule)()
        End Sub
    End Class
    
    Public Class NavigationModule
        Public Property Title As String
        Public Property Url As String
        Public Property Description As String
        Public Property ResourceKey As String
        Public Property Level As Integer
        Public Property Category As String
        
        Public Sub New()
        End Sub
    End Class
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadAjarModules()
        End If
    End Sub
    
    Private Sub LoadAjarModules()
        Try
            Dim categories As List(Of NavigationCategory) = ParseAjarSiteMap()
            rptCategories.DataSource = categories
            rptCategories.DataBind()
        Catch ex As Exception
            ' Fallback to sample data if XML parsing fails
            LoadSampleAjarData()
        End Try
    End Sub
    
    Private Function ParseAjarSiteMap() As List(Of NavigationCategory)
        Dim categories As New List(Of NavigationCategory)()
        Dim siteMapPath As String = Server.MapPath("~/appsitemap/Home.Sitemap")

        If File.Exists(siteMapPath) Then
            Dim xmlDoc As New XmlDocument()
            xmlDoc.Load(siteMapPath)
            
            ' Parse XML structure
            Dim rootNode As XmlNode = xmlDoc.SelectSingleNode("//siteMap/siteMapNode")
            If rootNode IsNot Nothing Then
                ParseAjarSiteMapNode(rootNode, categories, 0)
            End If
        End If
        
        ' If no categories found, load sample data
        If categories.Count = 0 Then
            LoadSampleAjarData()
            Return CType(rptCategories.DataSource, List(Of NavigationCategory))
        End If
        
        Return categories
    End Function
    
    Private Sub ParseAjarSiteMapNode(node As XmlNode, categories As List(Of NavigationCategory), level As Integer)
        If node.Attributes IsNot Nothing Then
            If level = 1 Then
                ' This is a category
                Dim category As New NavigationCategory()
                category.Title = GetAttributeValue(node, "title", "Category")
                categories.Add(category)
                
                ' Parse child modules
                For Each childNode As XmlNode In node.ChildNodes
                    If childNode.NodeType = XmlNodeType.Element Then
                        ParseAjarModules(childNode, category, level + 1)
                    End If
                Next
            End If
        End If
        
        ' Parse child nodes at current level
        For Each childNode As XmlNode In node.ChildNodes
            If childNode.NodeType = XmlNodeType.Element AndAlso level = 0 Then
                ParseAjarSiteMapNode(childNode, categories, level + 1)
            End If
        Next
    End Sub
    
    Private Sub ParseAjarModules(node As XmlNode, category As NavigationCategory, level As Integer)
        If node.Attributes IsNot Nothing Then
            Dim navModule As New NavigationModule()
            navModule.Title = GetAttributeValue(node, "title", "Module")
            navModule.Url = GetAttributeValue(node, "url", "#")
            navModule.Description = GetAttributeValue(node, "description", "")
            navModule.ResourceKey = GetAttributeValue(node, "resourceKey", navModule.Title)
            navModule.Level = level
            navModule.Category = category.Title
            
            category.Modules.Add(navModule)
        End If
    End Sub
    
    Private Function GetAttributeValue(node As XmlNode, attributeName As String, defaultValue As String) As String
        If node.Attributes(attributeName) IsNot Nothing Then
            Return node.Attributes(attributeName).Value
        End If
        Return defaultValue
    End Function
    
    Private Sub LoadSampleAjarData()
        Dim categories As New List(Of NavigationCategory)()
        
        ' Property Management Category
        Dim propertyCategory As New NavigationCategory()
        propertyCategory.Title = "إدارة العقارات"
        propertyCategory.Modules.Add(New NavigationModule() With {
            .Title = "قائمة العقارات",
            .Url = "/Properties/PropertyList.aspx",
            .Description = "/assets/img/properties.jpg",
            .ResourceKey = "PropertyList"
        })
        propertyCategory.Modules.Add(New NavigationModule() With {
            .Title = "إضافة عقار جديد",
            .Url = "/Properties/AddProperty.aspx",
            .Description = "/assets/img/add-property.jpg",
            .ResourceKey = "AddProperty"
        })
        propertyCategory.Modules.Add(New NavigationModule() With {
            .Title = "صيانة العقارات",
            .Url = "/Properties/Maintenance.aspx",
            .Description = "/assets/img/maintenance.jpg",
            .ResourceKey = "PropertyMaintenance"
        })
        categories.Add(propertyCategory)
        
        ' Rental Management Category
        Dim rentalCategory As New NavigationCategory()
        rentalCategory.Title = "إدارة الإيجارات"
        rentalCategory.Modules.Add(New NavigationModule() With {
            .Title = "عقود الإيجار",
            .Url = "/Rentals/RentalContracts.aspx",
            .Description = "/assets/img/contracts.jpg",
            .ResourceKey = "RentalContracts"
        })
        rentalCategory.Modules.Add(New NavigationModule() With {
            .Title = "المدفوعات",
            .Url = "/Rentals/Payments.aspx",
            .Description = "/assets/img/payments.jpg",
            .ResourceKey = "RentalPayments"
        })
        rentalCategory.Modules.Add(New NavigationModule() With {
            .Title = "المستأجرين",
            .Url = "/Rentals/Tenants.aspx",
            .Description = "/assets/img/tenants.jpg",
            .ResourceKey = "Tenants"
        })
        categories.Add(rentalCategory)
        
        ' Financial Management Category
        Dim financeCategory As New NavigationCategory()
        financeCategory.Title = "الإدارة المالية"
        financeCategory.Modules.Add(New NavigationModule() With {
            .Title = "التقارير المالية",
            .Url = "/Finance/FinancialReports.aspx",
            .Description = "/assets/img/financial-reports.jpg",
            .ResourceKey = "FinancialReports"
        })
        financeCategory.Modules.Add(New NavigationModule() With {
            .Title = "الفواتير",
            .Url = "/Finance/Invoices.aspx",
            .Description = "/assets/img/invoices.jpg",
            .ResourceKey = "Invoices"
        })
        financeCategory.Modules.Add(New NavigationModule() With {
            .Title = "الضرائب",
            .Url = "/Finance/Taxes.aspx",
            .Description = "/assets/img/taxes.jpg",
            .ResourceKey = "Taxes"
        })
        categories.Add(financeCategory)
        
        ' Settings Category
        Dim settingsCategory As New NavigationCategory()
        settingsCategory.Title = "الإعدادات"
        settingsCategory.Modules.Add(New NavigationModule() With {
            .Title = "إعدادات النظام",
            .Url = "/Settings/SystemSettings.aspx",
            .Description = "/assets/img/settings.jpg",
            .ResourceKey = "SystemSettings"
        })
        settingsCategory.Modules.Add(New NavigationModule() With {
            .Title = "إدارة المستخدمين",
            .Url = "/Settings/UserManagement.aspx",
            .Description = "/assets/img/users.jpg",
            .ResourceKey = "UserManagement"
        })
        settingsCategory.Modules.Add(New NavigationModule() With {
            .Title = "النسخ الاحتياطي",
            .Url = "/Settings/Backup.aspx",
            .Description = "/assets/img/backup.jpg",
            .ResourceKey = "Backup"
        })
        categories.Add(settingsCategory)
        
        rptCategories.DataSource = categories
        rptCategories.DataBind()
    End Sub
    
    ' Helper method for module descriptions
    Protected Function GetModuleDescription(title As Object) As String
        If title Is Nothing Then Return ""
        
        Dim moduleTitle As String = title.ToString().ToLower()
        
        Select Case True
            Case moduleTitle.Contains("عقار")
                Return "إدارة شاملة للعقارات والوحدات السكنية"
            Case moduleTitle.Contains("إيجار") OrElse moduleTitle.Contains("عقود")
                Return "متابعة عقود الإيجار والمستأجرين"
            Case moduleTitle.Contains("مدفوعات") OrElse moduleTitle.Contains("فواتير")
                Return "إدارة المدفوعات والفواتير المالية"
            Case moduleTitle.Contains("تقارير")
                Return "تقارير مالية وإحصائية شاملة"
            Case moduleTitle.Contains("صيانة")
                Return "طلبات الصيانة والإصلاحات"
            Case moduleTitle.Contains("مستأجر")
                Return "بيانات المستأجرين والاتصال"
            Case moduleTitle.Contains("إعدادات")
                Return "إعدادات النظام والتخصيص"
            Case moduleTitle.Contains("مستخدم")
                Return "إدارة حسابات المستخدمين"
            Case moduleTitle.Contains("نسخ")
                Return "النسخ الاحتياطي واستعادة البيانات"
            Case moduleTitle.Contains("ضرائب")
                Return "حسابات الضرائب والرسوم"
            Case Else
                Return "وحدة نظام إدارة الإيجارات"
        End Select
    End Function
    
    Protected Sub rptCategories_ItemDataBound(sender As Object, e As RepeaterItemEventArgs) Handles rptCategories.ItemDataBound
        If e.Item.ItemType = ListItemType.Item OrElse e.Item.ItemType = ListItemType.AlternatingItem Then
            Dim category As NavigationCategory = CType(e.Item.DataItem, NavigationCategory)
            Dim rptModules As Repeater = CType(e.Item.FindControl("rptModules"), Repeater)
            
            If rptModules IsNot Nothing AndAlso category.Modules IsNot Nothing Then
                rptModules.DataSource = category.Modules
                rptModules.DataBind()
            End If
        End If
    End Sub

End Class
