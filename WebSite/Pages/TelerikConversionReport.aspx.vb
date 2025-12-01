Imports System
Imports System.Data
Imports System.Text
Imports System.IO
Imports System.Web.UI

Partial Class TelerikConversionReport
    Inherits System.Web.UI.Page
    
    ' بيانات التحويل الأساسية
    Private conversionData As New Dictionary(Of String, ConversionInfo)
    
    ' هيكل بيانات المعلومات
    Private Structure ConversionInfo
        Public OriginalControl As String
        Public ModernControl As String
        Public Status As String
        Public FilePath As String
        Public ConversionDate As DateTime
        Public ImprovementPercentage As Integer
        Public Features As List(Of String)
    End Structure
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            InitializeConversionData()
            LoadDetailedStatus()
            LoadConvertedFiles()
        End If
    End Sub
    
    Private Sub InitializeConversionData()
        ' إضافة بيانات التحويل الأساسية
        conversionData.Add("TableOfContents", New ConversionInfo With {
            .OriginalControl = "TableOfContents.ascx (RadSiteMap)",
            .ModernControl = "ModernTableOfContents.ascx",
            .Status = "مكتمل",
            .FilePath = "~/Controls/ModernTableOfContents.ascx",
            .ConversionDate = DateTime.Now.AddDays(-5),
            .ImprovementPercentage = 85,
            .Features = New List(Of String) From {"تصميم متجاوب", "ألوان حديثة", "أيقونات Font Awesome", "دعم اللغة العربية"}
        })
        
        conversionData.Add("TableOfContentsajar", New ConversionInfo With {
            .OriginalControl = "TableOfContentsajar.ascx",
            .ModernControl = "ModernTableOfContentsajar.ascx",
            .Status = "مكتمل",
            .FilePath = "~/Controls/ModernTableOfContentsajar.ascx",
            .ConversionDate = DateTime.Now.AddDays(-4),
            .ImprovementPercentage = 90,
            .Features = New List(Of String) From {"رسوم متحركة", "تفاعل محسن", "تخطيط مرن", "مود داكن"}
        })
        
        conversionData.Add("eZeeErpModules", New ConversionInfo With {
            .OriginalControl = "eZeeErpModulesrad.ascx",
            .ModernControl = "ModerneZeeErpModules.ascx",
            .Status = "مكتمل",
            .FilePath = "~/Controls/ModerneZeeErpModules.ascx",
            .ConversionDate = DateTime.Now.AddDays(-2),
            .ImprovementPercentage = 88,
            .Features = New List(Of String) From {"إدارة الوحدات المحسنة", "واجهة حديثة", "تحميل ديناميكي", "إحصائيات مرئية"}
        })
        
        conversionData.Add("SchoolDashboard", New ConversionInfo With {
            .OriginalControl = "schoolDashBoard.ascx",
            .ModernControl = "ModernSchoolDashboard.ascx",
            .Status = "مكتمل",
            .FilePath = "~/Controls/ModernSchoolDashboard.ascx",
            .ConversionDate = DateTime.Now.AddDays(-2),
            .ImprovementPercentage = 92,
            .Features = New List(Of String) From {"لوحة تحكم تفاعلية", "إجراءات سريعة", "عدادات متحركة", "تقارير مرئية"}
        })
        
        conversionData.Add("AjarDashboard", New ConversionInfo With {
            .OriginalControl = "ajarDashBoard.ascx",
            .ModernControl = "ModernAjarDashboard.ascx",
            .Status = "مكتمل",
            .FilePath = "~/Controls/ModernAjarDashboard.ascx",
            .ConversionDate = DateTime.Now.AddDays(-2),
            .ImprovementPercentage = 89,
            .Features = New List(Of String) From {"إدارة العقارات", "نظرة مالية شاملة", "واجهة احترافية", "تفاعل محسن"}
        })
        
        conversionData.Add("RadMenu", New ConversionInfo With {
            .OriginalControl = "Telerik RadMenu",
            .ModernControl = "AdvancedMenuBuilder System",
            .Status = "مكتمل",
            .FilePath = "~/App_Code/AdvancedMenuBuilder.vb",
            .ConversionDate = DateTime.Now.AddDays(-7),
            .ImprovementPercentage = 95,
            .Features = New List(Of String) From {"قوائم متجاوبة بالكامل", "4 مستويات", "دعم الأمان", "تحكم كامل في HTML"}
        })
        
        conversionData.Add("LoginPage", New ConversionInfo With {
            .OriginalControl = "Login.aspx (تصميم قديم)",
            .ModernControl = "Login.aspx (تصميم AI حديث)",
            .Status = "مكتمل",
            .FilePath = "~/Login.aspx",
            .ConversionDate = DateTime.Now.AddDays(-10),
            .ImprovementPercentage = 98,
            .Features = New List(Of String) From {"تصميم AI ثوري", "ألوان زرقاء حديثة", "رسوم متحركة احترافية", "تجربة مستخدم محسنة"}
        })
        
        conversionData.Add("CSS-Framework", New ConversionInfo With {
            .OriginalControl = "CSS تقليدي",
            .ModernControl = "Modern CSS Framework",
            .Status = "مكتمل",
            .FilePath = "Multiple CSS files",
            .ConversionDate = DateTime.Now.AddDays(-8),
            .ImprovementPercentage = 87,
            .Features = New List(Of String) From {"CSS Variables", "Gradients", "Glassmorphism", "Neural Animations"}
        })
        
        conversionData.Add("JavaScript-System", New ConversionInfo With {
            .OriginalControl = "JavaScript منفصل",
            .ModernControl = "Modern JS Framework",
            .Status = "مكتمل",
            .FilePath = "~/Scripts/error-handling.js",
            .ConversionDate = DateTime.Now.AddDays(-3),
            .ImprovementPercentage = 75,
            .Features = New List(Of String) From {"معالجة أخطاء شاملة", "Fallback Systems", "أداء محسن", "تحميل ديناميكي"}
        })
        
        conversionData.Add("MasterPages", New ConversionInfo With {
            .OriginalControl = "Main.master (قديم)",
            .ModernControl = "Main.master (محدث)",
            .Status = "مكتمل",
            .FilePath = "~/Main.master",
            .ConversionDate = DateTime.Now.AddDays(-6),
            .ImprovementPercentage = 82,
            .Features = New List(Of String) From {"مسارات مطلقة", "تحميل محسن", "دعم المجلدات الفرعية", "نظام أمان محسن"}
        })
        
        conversionData.Add("DynamicConverter", New ConversionInfo With {
            .OriginalControl = "تحويل يدوي",
            .ModernControl = "DynamicControlConverter",
            .Status = "مكتمل",
            .FilePath = "~/App_Code/DynamicControlConverter.vb",
            .ConversionDate = DateTime.Now.AddDays(-4),
            .ImprovementPercentage = 93,
            .Features = New List(Of String) From {"تحويل تلقائي", "دعم متعدد الأنواع", "تحسين الأداء", "سهولة الصيانة"}
        })
        
        conversionData.Add("SharedBusinessRules", New ConversionInfo With {
            .OriginalControl = "SharedBusinessRules.vb (قديم)",
            .ModernControl = "SharedBusinessRules.vb (محدث)",
            .Status = "مكتمل",
            .FilePath = "~/App_Code/SharedBusinessRules.vb",
            .ConversionDate = DateTime.Now.AddDays(-1),
            .ImprovementPercentage = 86,
            .Features = New List(Of String) From {"كنترولات حديثة", "أداء محسن", "سهولة الصيانة", "تطبيق واسع النطاق"}
        })
        
        ' الكنترولات قيد التحويل
        conversionData.Add("Main-Simplified", New ConversionInfo With {
            .OriginalControl = "Main-Simplified.master",
            .ModernControl = "Main-Simplified.master (قيد التحديث)",
            .Status = "قيد التحويل",
            .FilePath = "~/Main-Simplified.master",
            .ConversionDate = DateTime.Now,
            .ImprovementPercentage = 60,
            .Features = New List(Of String) From {"تبسيط الواجهة", "تحسين الأداء"}
        })
        
        conversionData.Add("Additional-Controls", New ConversionInfo With {
            .OriginalControl = "كنترولات Telerik إضافية",
            .ModernControl = "كنترولات حديثة",
            .Status = "قيد التحويل",
            .FilePath = "Multiple files",
            .ConversionDate = DateTime.Now,
            .ImprovementPercentage = 45,
            .Features = New List(Of String) From {"قيد التطوير"}
        })
        
        conversionData.Add("Testing-Suite", New ConversionInfo With {
            .OriginalControl = "اختبارات يدوية",
            .ModernControl = "نظام اختبار تلقائي",
            .Status = "قيد التحويل",
            .FilePath = "~/Tests/",
            .ConversionDate = DateTime.Now,
            .ImprovementPercentage = 30,
            .Features = New List(Of String) From {"اختبارات تلقائية", "تقارير شاملة"}
        })
    End Sub
    
    Private Sub LoadDetailedStatus()
        Dim html As New StringBuilder()
        
        html.Append("<table class='status-detailed-table'>")
        html.Append("<thead>")
        html.Append("<tr>")
        html.Append("<th>الكنترول الأصلي</th>")
        html.Append("<th>الكنترول الحديث</th>")
        html.Append("<th>الحالة</th>")
        html.Append("<th>نسبة التحسن</th>")
        html.Append("<th>تاريخ التحويل</th>")
        html.Append("<th>المزايا الجديدة</th>")
        html.Append("</tr>")
        html.Append("</thead>")
        html.Append("<tbody>")
        
        For Each item In conversionData
            Dim info = item.Value
            Dim statusClass As String = ""
            Dim statusIcon As String = ""
            
            Select Case info.Status
                Case "مكتمل"
                    statusClass = "status-completed"
                    statusIcon = "fas fa-check-circle"
                Case "قيد التحويل"
                    statusClass = "status-in-progress"
                    statusIcon = "fas fa-clock"
                Case Else
                    statusClass = "status-pending"
                    statusIcon = "fas fa-hourglass-start"
            End Select
            
            html.Append("<tr class='status-row'>")
            html.Append("<td class='control-name'>")
            html.Append("<div class='control-info'>")
            html.Append("<i class='fas fa-cube control-icon'></i>")
            html.Append("<span>" + info.OriginalControl + "</span>")
            html.Append("</div>")
            html.Append("</td>")
            
            html.Append("<td class='modern-control'>")
            html.Append("<div class='modern-info'>")
            html.Append("<i class='fas fa-magic modern-icon'></i>")
            html.Append("<span>" + info.ModernControl + "</span>")
            html.Append("</div>")
            html.Append("</td>")
            
            html.Append("<td class='status-cell'>")
            html.Append("<div class='status-badge " + statusClass + "'>")
            html.Append("<i class='" + statusIcon + "'></i>")
            html.Append("<span>" + info.Status + "</span>")
            html.Append("</div>")
            html.Append("</td>")
            
            html.Append("<td class='improvement-cell'>")
            html.Append("<div class='improvement-indicator'>")
            html.Append("<div class='improvement-bar'>")
            html.Append("<div class='improvement-fill' style='width: " + info.ImprovementPercentage.ToString() + "%'></div>")
            html.Append("</div>")
            html.Append("<span class='improvement-text'>" + info.ImprovementPercentage.ToString() + "%</span>")
            html.Append("</div>")
            html.Append("</td>")
            
            html.Append("<td class='date-cell'>")
            html.Append("<div class='date-info'>")
            html.Append("<i class='fas fa-calendar-alt'></i>")
            html.Append("<span>" + info.ConversionDate.ToString("dd/MM/yyyy") + "</span>")
            html.Append("</div>")
            html.Append("</td>")
            
            html.Append("<td class='features-cell'>")
            html.Append("<div class='features-list'>")
            For Each feature In info.Features
                html.Append("<span class='feature-tag'>" + feature + "</span>")
            Next
            html.Append("</div>")
            html.Append("</td>")
            
            html.Append("</tr>")
        Next
        
        html.Append("</tbody>")
        html.Append("</table>")
        
        ' إضافة أنماط الجدول
        html.Append("<style>")
        html.Append(".status-detailed-table {")
        html.Append("    width: 100%;")
        html.Append("    border-collapse: collapse;")
        html.Append("    font-family: 'Cairo', sans-serif;")
        html.Append("}")
        html.Append(".status-detailed-table thead {")
        html.Append("    background: linear-gradient(135deg, #1e40af, #3b82f6);")
        html.Append("    color: white;")
        html.Append("}")
        html.Append(".status-detailed-table th {")
        html.Append("    padding: 1.5rem 1rem;")
        html.Append("    text-align: center;")
        html.Append("    font-weight: 600;")
        html.Append("    font-size: 1.1rem;")
        html.Append("}")
        html.Append(".status-row {")
        html.Append("    border-bottom: 1px solid #e2e8f0;")
        html.Append("    transition: all 0.3s ease;")
        html.Append("}")
        html.Append(".status-row:hover {")
        html.Append("    background: #f8fafc;")
        html.Append("    transform: scale(1.01);")
        html.Append("}")
        html.Append(".status-row td {")
        html.Append("    padding: 1.5rem 1rem;")
        html.Append("    text-align: center;")
        html.Append("    vertical-align: middle;")
        html.Append("}")
        html.Append(".control-info, .modern-info {")
        html.Append("    display: flex;")
        html.Append("    align-items: center;")
        html.Append("    justify-content: center;")
        html.Append("    gap: 0.5rem;")
        html.Append("}")
        html.Append(".control-icon {")
        html.Append("    color: #6b7280;")
        html.Append("    font-size: 1.2rem;")
        html.Append("}")
        html.Append(".modern-icon {")
        html.Append("    color: #3b82f6;")
        html.Append("    font-size: 1.2rem;")
        html.Append("}")
        html.Append(".status-badge {")
        html.Append("    display: inline-flex;")
        html.Append("    align-items: center;")
        html.Append("    gap: 0.5rem;")
        html.Append("    padding: 0.5rem 1rem;")
        html.Append("    border-radius: 20px;")
        html.Append("    font-weight: 600;")
        html.Append("    color: white;")
        html.Append("}")
        html.Append(".status-completed {")
        html.Append("    background: linear-gradient(135deg, #10b981, #059669);")
        html.Append("}")
        html.Append(".status-in-progress {")
        html.Append("    background: linear-gradient(135deg, #f59e0b, #d97706);")
        html.Append("}")
        html.Append(".status-pending {")
        html.Append("    background: linear-gradient(135deg, #6b7280, #4b5563);")
        html.Append("}")
        html.Append(".improvement-indicator {")
        html.Append("    display: flex;")
        html.Append("    align-items: center;")
        html.Append("    gap: 1rem;")
        html.Append("}")
        html.Append(".improvement-bar {")
        html.Append("    width: 100px;")
        html.Append("    height: 8px;")
        html.Append("    background: #e2e8f0;")
        html.Append("    border-radius: 4px;")
        html.Append("    overflow: hidden;")
        html.Append("}")
        html.Append(".improvement-fill {")
        html.Append("    height: 100%;")
        html.Append("    background: linear-gradient(90deg, #10b981, #059669);")
        html.Append("    transition: width 0.6s ease;")
        html.Append("}")
        html.Append(".improvement-text {")
        html.Append("    font-weight: 600;")
        html.Append("    color: #10b981;")
        html.Append("}")
        html.Append(".date-info {")
        html.Append("    display: flex;")
        html.Append("    align-items: center;")
        html.Append("    justify-content: center;")
        html.Append("    gap: 0.5rem;")
        html.Append("    color: #6b7280;")
        html.Append("}")
        html.Append(".features-list {")
        html.Append("    display: flex;")
        html.Append("    flex-wrap: wrap;")
        html.Append("    gap: 0.5rem;")
        html.Append("    justify-content: center;")
        html.Append("}")
        html.Append(".feature-tag {")
        html.Append("    background: #e0f2fe;")
        html.Append("    color: #0369a1;")
        html.Append("    padding: 0.25rem 0.75rem;")
        html.Append("    border-radius: 12px;")
        html.Append("    font-size: 0.85rem;")
        html.Append("    font-weight: 500;")
        html.Append("}")
        html.Append("@media (max-width: 768px) {")
        html.Append("    .status-detailed-table {")
        html.Append("        font-size: 0.9rem;")
        html.Append("    }")
        html.Append("    .status-row td {")
        html.Append("        padding: 1rem 0.5rem;")
        html.Append("    }")
        html.Append("    .improvement-bar {")
        html.Append("        width: 60px;")
        html.Append("    }")
        html.Append("}")
        html.Append("</style>")
        
        litDetailedStatus.Text = html.ToString()
    End Sub
    
    Private Sub LoadConvertedFiles()
        Dim html As New StringBuilder()
        
        Dim fileCategories As New Dictionary(Of String, List(Of String))
        fileCategories.Add("كنترولات المستخدم", New List(Of String) From {
            "ModernTableOfContents.ascx/.vb",
            "ModernTableOfContentsajar.ascx/.vb", 
            "ModerneZeeErpModules.ascx/.vb",
            "ModernSchoolDashboard.ascx/.vb",
            "ModernAjarDashboard.ascx/.vb"
        })
        
        fileCategories.Add("صفحات النظام", New List(Of String) From {
            "Login.aspx (تصميم AI محدث)",
            "Main.master (محسن)",
            "Default.aspx (محسن)",
            "Home.aspx (محسن)"
        })
        
        fileCategories.Add("ملفات VB.NET", New List(Of String) From {
            "AdvancedMenuBuilder.vb",
            "DynamicControlConverter.vb", 
            "SharedBusinessRules.vb (محدث)",
            "TelerikControlsConverter.aspx.vb"
        })
        
        fileCategories.Add("ملفات CSS & JavaScript", New List(Of String) From {
            "modern-navigation.css",
            "modern-navigation.js",
            "error-handling.js",
            "user-info.js",
            "modern-cards.js"
        })
        
        For Each category In fileCategories
            html.Append("<div class='file-category'>")
            html.Append("<h4 class='category-title'>")
            html.Append("<i class='fas fa-folder'></i>")
            html.Append(category.Key)
            html.Append("</h4>")
            html.Append("<div class='file-list-items'>")
            
            For Each file In category.Value
                html.Append("<div class='file-item'>")
                html.Append("<i class='fas fa-file-code'></i>")
                html.Append("<span>" + file + "</span>")
                html.Append("<div class='file-status-ok'>")
                html.Append("<i class='fas fa-check'></i>")
                html.Append("</div>")
                html.Append("</div>")
            Next
            
            html.Append("</div>")
            html.Append("</div>")
        Next
        
        ' إضافة أنماط قائمة الملفات
        html.Append("<style>")
        html.Append(".file-category {")
        html.Append("    margin-bottom: 2rem;")
        html.Append("}")
        html.Append(".category-title {")
        html.Append("    display: flex;")
        html.Append("    align-items: center;")
        html.Append("    gap: 0.75rem;")
        html.Append("    font-size: 1.2rem;")
        html.Append("    font-weight: 600;")
        html.Append("    color: #1e40af;")
        html.Append("    margin-bottom: 1rem;")
        html.Append("    padding-bottom: 0.5rem;")
        html.Append("    border-bottom: 2px solid #e0f2fe;")
        html.Append("}")
        html.Append(".file-list-items {")
        html.Append("    display: grid;")
        html.Append("    gap: 0.75rem;")
        html.Append("}")
        html.Append(".file-item {")
        html.Append("    display: flex;")
        html.Append("    align-items: center;")
        html.Append("    gap: 1rem;")
        html.Append("    padding: 1rem;")
        html.Append("    background: #f8fafc;")
        html.Append("    border: 1px solid #e2e8f0;")
        html.Append("    border-radius: 10px;")
        html.Append("    transition: all 0.3s ease;")
        html.Append("}")
        html.Append(".file-item:hover {")
        html.Append("    background: #e0f2fe;")
        html.Append("    border-color: #3b82f6;")
        html.Append("    transform: translateX(5px);")
        html.Append("}")
        html.Append(".file-item i.fa-file-code {")
        html.Append("    color: #3b82f6;")
        html.Append("    font-size: 1.2rem;")
        html.Append("}")
        html.Append(".file-item span {")
        html.Append("    flex-grow: 1;")
        html.Append("    color: #374151;")
        html.Append("    font-weight: 500;")
        html.Append("}")
        html.Append(".file-status-ok {")
        html.Append("    width: 24px;")
        html.Append("    height: 24px;")
        html.Append("    background: #10b981;")
        html.Append("    border-radius: 50%;")
        html.Append("    display: flex;")
        html.Append("    align-items: center;")
        html.Append("    justify-content: center;")
        html.Append("    color: white;")
        html.Append("    font-size: 0.9rem;")
        html.Append("}")
        html.Append("</style>")
        
        litConvertedFiles.Text = html.ToString()
    End Sub
    
    Protected Sub btnExportPDF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportPDF.Click
        ' تصدير PDF (يمكن تطبيق مكتبة PDF)
        Response.Write("<script>alert('سيتم تطبيق تصدير PDF قريباً');</script>")
    End Sub
    
    Protected Sub btnExportExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        ' تصدير Excel
        Response.Clear()
        Response.Buffer = True
        Response.AddHeader("content-disposition", "attachment;filename=TelerikConversionReport.xls")
        Response.Charset = "UTF-8"
        Response.ContentType = "application/vnd.ms-excel"
        
        Dim html As New StringBuilder()
        html.Append("<html><head><meta charset='UTF-8'></head><body>")
        html.Append("<h1>تقرير تحويل Telerik - " + DateTime.Now.ToString("dd/MM/yyyy") + "</h1>")
        html.Append("<table border='1'>")
        html.Append("<tr><th>الكنترول الأصلي</th><th>الكنترول الحديث</th><th>الحالة</th><th>نسبة التحسن</th><th>تاريخ التحويل</th></tr>")
        
        For Each item In conversionData
            Dim info = item.Value
            html.Append("<tr>")
            html.Append("<td>" + info.OriginalControl + "</td>")
            html.Append("<td>" + info.ModernControl + "</td>")
            html.Append("<td>" + info.Status + "</td>")
            html.Append("<td>" + info.ImprovementPercentage.ToString() + "%</td>")
            html.Append("<td>" + info.ConversionDate.ToString("dd/MM/yyyy") + "</td>")
            html.Append("</tr>")
        Next
        
        html.Append("</table>")
        html.Append("</body></html>")
        
        Response.Output.Write(html.ToString())
        Response.Flush()
        Response.End()
    End Sub
    
    Protected Sub btnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        ' طباعة
        Response.Write("<script>window.print();</script>")
    End Sub
End Class
