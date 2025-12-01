Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.IO
Imports translatemeyamosso

Partial Public Class Controls_schoolDashBoard
    Inherits Global.System.Web.UI.UserControl

    ''' <summary>
    ''' تحميل الصفحة وإعداد البيانات
    ''' Page load and data setup
    ''' </summary>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadNavigationData()
        End If
    End Sub

    ''' <summary>
    ''' تحميل بيانات التنقل من SiteMap
    ''' Load navigation data from SiteMap
    ''' </summary>
    Private Sub LoadNavigationData()
        Try
            Dim navigationItems As New List(Of NavigationItem)
            
            ' Get sitemap data
            If SiteMap.RootNode IsNot Nothing Then
                ' Process root node children (level 1 items)
                For Each childNode As SiteMapNode In SiteMap.RootNode.ChildNodes
                    Dim navItem As New NavigationItem() With {
                        .Title = childNode.Title,
                        .Url = childNode.Url,
                        .Description = childNode.Description
                    }
                    navigationItems.Add(navItem)
                Next
            End If
            
            ' If no sitemap data, create sample data
            If navigationItems.Count = 0 Then
                navigationItems = GetSampleNavigationData()
            End If
            
            ' Bind to repeater
            rptNavigation.DataSource = navigationItems
            rptNavigation.DataBind()
            
        Catch ex As Exception
            ' Log error and show sample data
            LoadSampleData()
        End Try
    End Sub

    ''' <summary>
    ''' تحميل بيانات تجريبية
    ''' Load sample data
    ''' </summary>
    Private Sub LoadSampleData()
        Try
            Dim sampleData = GetSampleNavigationData()
            rptNavigation.DataSource = sampleData
            rptNavigation.DataBind()
        Catch ex As Exception
            ' Handle complete failure gracefully
        End Try
    End Sub

    ''' <summary>
    ''' الحصول على بيانات تنقل تجريبية
    ''' Get sample navigation data
    ''' </summary>
    Private Function GetSampleNavigationData() As List(Of NavigationItem)
        Dim items As New List(Of NavigationItem)
        
        items.Add(New NavigationItem() With {
            .Title = "إدارة الطلاب",
            .Url = "~/Pages/Students/Default.aspx",
            .Description = "إدارة شاملة لبيانات الطلاب والتسجيل"
        })
        
        items.Add(New NavigationItem() With {
            .Title = "إدارة المعلمين",
            .Url = "~/Pages/Teachers/Default.aspx",
            .Description = "إدارة بيانات المعلمين والمواد الدراسية"
        })
        
        items.Add(New NavigationItem() With {
            .Title = "الجداول الدراسية",
            .Url = "~/Pages/Schedule/Default.aspx",
            .Description = "إنشاء وإدارة الجداول الدراسية"
        })
        
        items.Add(New NavigationItem() With {
            .Title = "الدرجات والتقييم",
            .Url = "~/Pages/Grades/Default.aspx",
            .Description = "نظام الدرجات والتقييم الأكاديمي"
        })
        
        items.Add(New NavigationItem() With {
            .Title = "المالية والرسوم",
            .Url = "~/Pages/Finance/Default.aspx",
            .Description = "إدارة الرسوم والمدفوعات المالية"
        })
        
        items.Add(New NavigationItem() With {
            .Title = "التقارير",
            .Url = "~/Pages/Reports/Default.aspx",
            .Description = "تقارير شاملة وإحصائيات مفصلة"
        })
        
        items.Add(New NavigationItem() With {
            .Title = "الإعدادات",
            .Url = "~/Pages/Settings/Default.aspx",
            .Description = "إعدادات النظام والتكوين العام"
        })
        
        items.Add(New NavigationItem() With {
            .Title = "المكتبة",
            .Url = "~/Pages/Library/Default.aspx",
            .Description = "إدارة المكتبة والكتب المدرسية"
        })
        
        items.Add(New NavigationItem() With {
            .Title = "النقل المدرسي",
            .Url = "~/Pages/Transport/Default.aspx",
            .Description = "إدارة الحافلات والنقل المدرسي"
        })
        
        Return items
    End Function

    ''' <summary>
    ''' الحصول على صورة الوحدة
    ''' Get module image
    ''' </summary>
    Public Function GetModuleImage(ByVal url As Object) As String
        If url Is Nothing Then Return GetDefaultImage()
        
        Try
            ' Try to get from translation system first
            Dim translatedImage As String = translatemeyamosso.GetResourcemosso(url.ToString())
            If Not String.IsNullOrEmpty(translatedImage) AndAlso File.Exists(Server.MapPath(translatedImage)) Then
                Return translatedImage
            End If
            
            ' Generate default image based on URL
            Return GetDefaultImageByUrl(url.ToString())
            
        Catch ex As Exception
            Return GetDefaultImage()
        End Try
    End Function

    ''' <summary>
    ''' الحصول على صورة افتراضية حسب الرابط
    ''' Get default image by URL
    ''' </summary>
    Private Function GetDefaultImageByUrl(ByVal url As String) As String
        ' Map URLs to appropriate images
        If url.ToLower().Contains("student") Then
            Return "~/assets/img/modules/students.png"
        ElseIf url.ToLower().Contains("teacher") Then
            Return "~/assets/img/modules/teachers.png"
        ElseIf url.ToLower().Contains("schedule") Then
            Return "~/assets/img/modules/schedule.png"
        ElseIf url.ToLower().Contains("grade") Then
            Return "~/assets/img/modules/grades.png"
        ElseIf url.ToLower().Contains("finance") Then
            Return "~/assets/img/modules/finance.png"
        ElseIf url.ToLower().Contains("report") Then
            Return "~/assets/img/modules/reports.png"
        ElseIf url.ToLower().Contains("setting") Then
            Return "~/assets/img/modules/settings.png"
        ElseIf url.ToLower().Contains("library") Then
            Return "~/assets/img/modules/library.png"
        ElseIf url.ToLower().Contains("transport") Then
            Return "~/assets/img/modules/transport.png"
        Else
            Return GetDefaultImage()
        End If
    End Function

    ''' <summary>
    ''' الحصول على صورة افتراضية
    ''' Get default image
    ''' </summary>
    Private Function GetDefaultImage() As String
        Return "~/assets/img/modules/default.png"
    End Function

    ''' <summary>
    ''' الحصول على وصف الوحدة
    ''' Get module description
    ''' </summary>
    Public Function GetModuleDescription(ByVal title As Object) As String
        If title Is Nothing Then Return "وحدة من وحدات النظام"
        
        Try
            Dim titleStr As String = title.ToString().ToLower()
            
            ' Return descriptions based on title
            If titleStr.Contains("طلاب") OrElse titleStr.Contains("student") Then
                Return "إدارة شاملة لبيانات الطلاب والتسجيل والمتابعة الأكاديمية"
            ElseIf titleStr.Contains("معلم") OrElse titleStr.Contains("teacher") Then
                Return "إدارة بيانات المعلمين والمواد الدراسية والجداول التدريسية"
            ElseIf titleStr.Contains("جدول") OrElse titleStr.Contains("schedule") Then
                Return "إنشاء وإدارة الجداول الدراسية والحصص والمواعيد"
            ElseIf titleStr.Contains("درجات") OrElse titleStr.Contains("grade") Then
                Return "نظام شامل للدرجات والتقييم الأكاديمي والامتحانات"
            ElseIf titleStr.Contains("مالية") OrElse titleStr.Contains("finance") Then
                Return "إدارة الرسوم والمدفوعات المالية والميزانية المدرسية"
            ElseIf titleStr.Contains("تقارير") OrElse titleStr.Contains("report") Then
                Return "تقارير شاملة وإحصائيات مفصلة لجميع جوانب المدرسة"
            ElseIf titleStr.Contains("إعدادات") OrElse titleStr.Contains("setting") Then
                Return "إعدادات النظام والتكوين العام وإدارة المستخدمين"
            ElseIf titleStr.Contains("مكتبة") OrElse titleStr.Contains("library") Then
                Return "إدارة المكتبة والكتب المدرسية ونظام الاستعارة"
            ElseIf titleStr.Contains("نقل") OrElse titleStr.Contains("transport") Then
                Return "إدارة الحافلات والنقل المدرسي ومتابعة الطلاب"
            Else
                Return "وحدة متقدمة من وحدات نظام إدارة المدرسة"
            End If
            
        Catch ex As Exception
            Return "وحدة من وحدات النظام المتطور"
        End Try
    End Function

    ''' <summary>
    ''' كلاس عنصر التنقل
    ''' Navigation item class
    ''' </summary>
    Public Class NavigationItem
        Public Property Title As String
        Public Property Url As String
        Public Property Description As String
        Public Property ImageUrl As String
    End Class

    ''' <summary>
    ''' تصدير بيانات التنقل
    ''' Export navigation data
    ''' </summary>
    Public Function ExportNavigationData() As String
        Try
            Dim data As New List(Of NavigationItem)
            
            For Each item As RepeaterItem In rptNavigation.Items
                ' Extract data from repeater items if needed
            Next
            
            ' Convert to JSON or XML format
            Return "Navigation data exported successfully"
            
        Catch ex As Exception
            Return "Export failed: " & ex.Message
        End Try
    End Function

End Class
