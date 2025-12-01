Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Xml

Partial Public Class Controls_eZeeErpModulesradmossochange
    Inherits Global.System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadModernModules()
        End If
    End Sub

    ''' <summary>
    ''' تحميل الوحدات بتصميم حديث من ملف Modules.Sitemap
    ''' Load modules with modern design from Modules.Sitemap file
    ''' </summary>
    Private Sub LoadModernModules()
        Try
            Dim siteMapPath As String = Server.MapPath("~/Modules.Sitemap")

            If File.Exists(siteMapPath) Then
                LoadFromSiteMapFile(siteMapPath)
            Else
                ' إنشاء modules افتراضية إذا لم يوجد الملف
                LoadDefaultModules()
            End If

        Catch ex As Exception
            ' في حالة حدوث خطأ، عرض رسالة مناسبة
            litModules.Text = GenerateErrorMessage(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' تحميل الوحدات من ملف XML Sitemap
    ''' Load modules from XML Sitemap file
    ''' </summary>
    Private Sub LoadFromSiteMapFile(ByVal filePath As String)
        Try
            Dim doc As New XmlDocument()
            doc.Load(filePath)

            Dim moduleHtml As New System.Text.StringBuilder()

            ' البحث عن عقد المستوى الأول (الوحدات الرئيسية)
            Dim rootNodes As XmlNodeList = doc.SelectNodes("//siteMapNode[@title]")

            For Each node As XmlNode In rootNodes
                If node.Attributes("level") IsNot Nothing AndAlso node.Attributes("level").Value = "1" Then
                    Continue For ' تخطي العقد الفرعية
                End If

                Dim title As String = GetAttributeValue(node, "title", "وحدة نظام")
                Dim description As String = GetAttributeValue(node, "description", "وصف الوحدة")
                Dim url As String = GetAttributeValue(node, "url", "#")
                Dim resourceKey As String = GetAttributeValue(node, "resourceKey", "/images/default-module.png")

                ' إنشاء كارت الوحدة
                moduleHtml.Append(GenerateModuleCard(title, description, url, resourceKey))
            Next

            If moduleHtml.Length = 0 Then
                LoadDefaultModules()
            Else
                litModules.Text = moduleHtml.ToString()
            End If

        Catch ex As Exception
            LoadDefaultModules()
        End Try
    End Sub

    ''' <summary>
    ''' الحصول على قيمة خاصية من XML Node
    ''' Get attribute value from XML Node
    ''' </summary>
    Private Function GetAttributeValue(ByVal node As XmlNode, ByVal attributeName As String, ByVal defaultValue As String) As String
        If node.Attributes(attributeName) IsNot Nothing Then
            Return node.Attributes(attributeName).Value
        End If
        Return defaultValue
    End Function

    ''' <summary>
    ''' تحميل وحدات افتراضية
    ''' Load default modules
    ''' </summary>
    Private Sub LoadDefaultModules()
        Dim defaultModules As New List(Of ModuleInfo) From {
            New ModuleInfo With {
                .Title = "إدارة المالية",
                .Description = "إدارة الحسابات والمعاملات المالية والتقارير المالية",
                .Url = "~/Pages/Finance/Default.aspx",
                .Icon = "/images/icons/finance.png"
            },
            New ModuleInfo With {
                .Title = "إدارة الموارد البشرية",
                .Description = "إدارة الموظفين والرواتب والحضور والانصراف",
                .Url = "~/Pages/HR/Default.aspx",
                .Icon = "/images/icons/hr.png"
            },
            New ModuleInfo With {
                .Title = "إدارة المخازن",
                .Description = "إدارة المخزون والمواد والمشتريات والمبيعات",
                .Url = "~/Pages/Inventory/Default.aspx",
                .Icon = "/images/icons/inventory.png"
            },
            New ModuleInfo With {
                .Title = "إدارة المبيعات",
                .Description = "إدارة العملاء والفواتير وعمليات البيع",
                .Url = "~/Pages/Sales/Default.aspx",
                .Icon = "/images/icons/sales.png"
            },
            New ModuleInfo With {
                .Title = "إدارة المشتريات",
                .Description = "إدارة الموردين وطلبات الشراء والفواتير",
                .Url = "~/Pages/Purchasing/Default.aspx",
                .Icon = "/images/icons/purchasing.png"
            },
            New ModuleInfo With {
                .Title = "التقارير والتحليلات",
                .Description = "تقارير شاملة وتحليلات مالية وإدارية",
                .Url = "~/Pages/Reports/Default.aspx",
                .Icon = "/images/icons/reports.png"
            },
            New ModuleInfo With {
                .Title = "إعدادات النظام",
                .Description = "إعدادات عامة للنظام وإدارة المستخدمين",
                .Url = "~/Pages/Settings/Default.aspx",
                .Icon = "/images/icons/settings.png"
            },
            New ModuleInfo With {
                .Title = "لوحة التحكم",
                .Description = "نظرة عامة على أداء النظام والإحصائيات",
                .Url = "~/Pages/Dashboard/Default.aspx",
                .Icon = "/images/icons/dashboard.png"
            }
        }

        Dim moduleHtml As New System.Text.StringBuilder()

        For Each moduleInfo As ModuleInfo In defaultModules
            moduleHtml.Append(GenerateModuleCard(
                moduleInfo.Title,
                moduleInfo.Description,
                moduleInfo.Url,
                moduleInfo.Icon
            ))
        Next

        litModules.Text = moduleHtml.ToString()
    End Sub

    ''' <summary>
    ''' إنشاء كارت وحدة بتصميم حديث
    ''' Generate modern module card
    ''' </summary>
    Private Function GenerateModuleCard(ByVal title As String, ByVal description As String, ByVal url As String, ByVal iconPath As String) As String
        ' التأكد من صحة المسار
        If url.StartsWith("~/") Then
            url = ResolveUrl(url)
        End If

        ' إنشاء أيقونة افتراضية إذا لم توجد
        If String.IsNullOrEmpty(iconPath) OrElse iconPath = "#" Then
            iconPath = "/images/icons/default-module.png"
        End If

        Dim cardHtml As String = "<div class='module-card'>" & vbCrLf &
               "    <div class='module-icon'>" & vbCrLf &
               "        <img src='" & iconPath & "' alt='" & HttpUtility.HtmlEncode(title) & "' onerror='this.src=""/images/icons/default.png""' />" & vbCrLf &
               "    </div>" & vbCrLf &
               "    <h3 class='module-title'>" & HttpUtility.HtmlEncode(title) & "</h3>" & vbCrLf &
               "    <p class='module-description'>" & HttpUtility.HtmlEncode(description) & "</p>" & vbCrLf &
               "    <a href='" & url & "' class='module-link'>" & vbCrLf &
               "        <i class='fas fa-arrow-left'></i>" & vbCrLf &
               "        <span>دخول للوحدة</span>" & vbCrLf &
               "    </a>" & vbCrLf &
               "</div>"

        Return cardHtml
    End Function

    ''' <summary>
    ''' إنشاء رسالة خطأ مع تصميم مناسب
    ''' Generate error message with appropriate design
    ''' </summary>
    Private Function GenerateErrorMessage(ByVal errorDetails As String) As String
        Return "<div class='error-container'>" & vbCrLf &
               "    <div class='error-icon'>" & vbCrLf &
               "        <i class='fas fa-exclamation-triangle'></i>" & vbCrLf &
               "    </div>" & vbCrLf &
               "    <h3>خطأ في تحميل الوحدات</h3>" & vbCrLf &
               "    <p>حدث خطأ أثناء تحميل وحدات النظام. يرجى المحاولة مرة أخرى.</p>" & vbCrLf &
               "    <div class='error-details'>" & HttpUtility.HtmlEncode(errorDetails) & "</div>" & vbCrLf &
               "</div>"
    End Function

    ''' <summary>
    ''' فئة معلومات الوحدة
    ''' Module information class
    ''' </summary>
    Private Class ModuleInfo
        Public Property Title As String
        Public Property Description As String
        Public Property Url As String
        Public Property Icon As String
    End Class
End Class
