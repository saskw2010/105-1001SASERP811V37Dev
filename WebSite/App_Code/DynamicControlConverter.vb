Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.Text
Imports System.IO

''' <summary>
''' محول الكنترولات الديناميكية - يحول الكنترولات القديمة إلى تصميم حديث
''' Dynamic Control Converter - Converts old controls to modern design
''' </summary>
Public Class DynamicControlConverter

    ''' <summary>
    ''' تحويل أي Telerik control إلى تصميم حديث بناءً على النوع
    ''' Convert any Telerik control to modern design based on type
    ''' </summary>
    Public Shared Function ConvertTelerikControlToModern(ByVal controlType As String, ByVal page As System.Web.UI.Page, ByVal containerId As String) As String
        Select Case controlType.ToLower()
            Case "tableofcontents", "tableofcontentsajar"
                Return ConvertTableOfContentsToModern(page, containerId)
            Case "ezeeerpmdulesrad", "ezeeerp"
                Return ConvertEZeeErpModulesToModern(page, containerId)
            Case "schooldashboard", "school"
                Return ConvertSchoolDashboardToModern(page, containerId)
            Case "ajardashboard", "ajar"
                Return ConvertAjarDashboardToModern(page, containerId)
            Case Else
                Return ConvertGenericTelerikToModern(controlType, page, containerId)
        End Select
    End Function

    ''' <summary>
    ''' تحويل TableOfContents من Telerik إلى تصميم حديث متطور
    ''' Convert TableOfContents from Telerik to advanced modern design
    ''' </summary>
    Public Shared Function ConvertTableOfContentsToModern(ByVal page As Page, ByVal containerId As String) As String
        Try
            Dim modernHtml As New StringBuilder()
            
            ' بناء التصميم الحديث المتكامل
            modernHtml.AppendLine("<div id='" & containerId & "' class='modern-table-of-contents-converter'>")
            
            ' الهيدر الحديث مع تأثيرات بصرية
            modernHtml.AppendLine("  <div class='toc-modern-header'>")
            modernHtml.AppendLine("    <div class='header-backdrop'></div>")
            modernHtml.AppendLine("    <div class='header-content-wrapper'>")
            modernHtml.AppendLine("      <div class='header-icon-container'>")
            modernHtml.AppendLine("        <div class='header-icon-bg'></div>")
            modernHtml.AppendLine("        <i class='fas fa-th-large header-main-icon'></i>")
            modernHtml.AppendLine("      </div>")
            modernHtml.AppendLine("      <div class='header-text-content'>")
            modernHtml.AppendLine("        <h1 class='main-title'>الوحدات الرئيسية للنظام</h1>")
            modernHtml.AppendLine("        <p class='main-subtitle'>اختر الوحدة التي تريد الوصول إليها من القائمة أدناه</p>")
            modernHtml.AppendLine("        <div class='title-decorator'>")
            modernHtml.AppendLine("          <div class='decorator-line'></div>")
            modernHtml.AppendLine("          <div class='decorator-diamond'></div>")
            modernHtml.AppendLine("          <div class='decorator-line'></div>")
            modernHtml.AppendLine("        </div>")
            modernHtml.AppendLine("      </div>")
            modernHtml.AppendLine("    </div>")
            modernHtml.AppendLine("  </div>")
            
            ' شبكة الوحدات الحديثة
            modernHtml.AppendLine("  <div class='modules-container'>")
            modernHtml.AppendLine("    <div class='modules-grid-modern' id='modernModulesGrid'>")
            
            ' إنشاء الوحدات بناءً على SiteMap أو الوحدات الافتراضية
            Dim moduleCards As String = GenerateSystemModuleCards()
            modernHtml.AppendLine(moduleCards)
            
            modernHtml.AppendLine("    </div>")
            modernHtml.AppendLine("  </div>")
            
            ' قسم الإحصائيات السريعة
            modernHtml.AppendLine("  <div class='quick-overview-section'>")
            modernHtml.AppendLine("    <div class='overview-header'>")
            modernHtml.AppendLine("      <h3 class='overview-title'>")
            modernHtml.AppendLine("        <i class='fas fa-chart-bar'></i>")
            modernHtml.AppendLine("        <span>نظرة عامة سريعة</span>")
            modernHtml.AppendLine("      </h3>")
            modernHtml.AppendLine("    </div>")
            modernHtml.AppendLine("    <div class='overview-stats-grid'>")
            modernHtml.AppendLine("      <div class='stat-modern-card'>")
            modernHtml.AppendLine("        <div class='stat-icon stat-blue'>")
            modernHtml.AppendLine("          <i class='fas fa-users'></i>")
            modernHtml.AppendLine("        </div>")
            modernHtml.AppendLine("        <div class='stat-content'>")
            modernHtml.AppendLine("          <div class='stat-number' data-target='1250'>0</div>")
            modernHtml.AppendLine("          <div class='stat-label'>المستخدمين النشطين</div>")
            modernHtml.AppendLine("        </div>")
            modernHtml.AppendLine("      </div>")
            modernHtml.AppendLine("      <div class='stat-modern-card'>")
            modernHtml.AppendLine("        <div class='stat-icon stat-green'>")
            modernHtml.AppendLine("          <i class='fas fa-file-alt'></i>")
            modernHtml.AppendLine("        </div>")
            modernHtml.AppendLine("        <div class='stat-content'>")
            modernHtml.AppendLine("          <div class='stat-number' data-target='850'>0</div>")
            modernHtml.AppendLine("          <div class='stat-label'>التقارير المُنجزة</div>")
            modernHtml.AppendLine("        </div>")
            modernHtml.AppendLine("      </div>")
            modernHtml.AppendLine("      <div class='stat-modern-card'>")
            modernHtml.AppendLine("        <div class='stat-icon stat-orange'>")
            modernHtml.AppendLine("          <i class='fas fa-tasks'></i>")
            modernHtml.AppendLine("        </div>")
            modernHtml.AppendLine("        <div class='stat-content'>")
            modernHtml.AppendLine("          <div class='stat-number' data-target='42'>0</div>")
            modernHtml.AppendLine("          <div class='stat-label'>المهام المعلقة</div>")
            modernHtml.AppendLine("        </div>")
            modernHtml.AppendLine("      </div>")
            modernHtml.AppendLine("      <div class='stat-modern-card'>")
            modernHtml.AppendLine("        <div class='stat-icon stat-purple'>")
            modernHtml.AppendLine("          <i class='fas fa-check-circle'></i>")
            modernHtml.AppendLine("        </div>")
            modernHtml.AppendLine("        <div class='stat-content'>")
            modernHtml.AppendLine("          <div class='stat-number' data-target='98'>0</div>")
            modernHtml.AppendLine("          <div class='stat-label'>معدل الإنجاز%</div>")
            modernHtml.AppendLine("        </div>")
            modernHtml.AppendLine("      </div>")
            modernHtml.AppendLine("    </div>")
            modernHtml.AppendLine("  </div>")
            
            modernHtml.AppendLine("</div>")
            
            ' إضافة CSS المتقدم
            modernHtml.AppendLine(GetAdvancedModernTocStyles())
            
            ' إضافة JavaScript التفاعلي
            modernHtml.AppendLine(GetAdvancedModernTocScript())
            
            Return modernHtml.ToString()
            
        Catch ex As Exception
            Return GenerateErrorDisplay("خطأ في تحويل TableOfContents إلى التصميم الحديث: " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' إنشاء بطاقات الوحدات المتطورة
    ''' Generate advanced system module cards
    ''' </summary>
    Private Shared Function GenerateSystemModuleCards() As String
        Dim cardsHtml As New StringBuilder()
        
        ' وحدات النظام الرئيسية مع تصميم متطور
        Dim systemModules() As SystemModuleInfo = {
            New SystemModuleInfo() With {
                .Id = "students",
                .Title = "إدارة الطلاب",
                .Description = "تسجيل ومتابعة بيانات الطلاب والدرجات والحضور",
                .Icon = "fas fa-graduation-cap",
                .Color = "blue",
                .Gradient = "linear-gradient(135deg, #2563eb, #3b82f6)",
                .Url = "~/Pages/Students/Default.aspx",
                .Badge = "التعليم",
                .Stats = "1,250 طالب"
            },
            New SystemModuleInfo() With {
                .Id = "hr",
                .Title = "الموارد البشرية",
                .Description = "إدارة الموظفين والرواتب والحضور والإجازات",
                .Icon = "fas fa-users",
                .Color = "green",
                .Gradient = "linear-gradient(135deg, #10b981, #06d6a0)",
                .Url = "~/Pages/HR/Default.aspx",
                .Badge = "الموظفين",
                .Stats = "350 موظف"
            },
            New SystemModuleInfo() With {
                .Id = "accounting",
                .Title = "المحاسبة",
                .Description = "إدارة الحسابات والفواتير والميزانية العمومية",
                .Icon = "fas fa-calculator",
                .Color = "purple",
                .Gradient = "linear-gradient(135deg, #7c3aed, #8b5cf6)",
                .Url = "~/Pages/Accounting/Default.aspx",
                .Badge = "المالية",
                .Stats = "850 عملية"
            },
            New SystemModuleInfo() With {
                .Id = "library",
                .Title = "إدارة المكتبة",
                .Description = "تسجيل الكتب والاستعارة والإرجاع وإدارة المواد",
                .Icon = "fas fa-book",
                .Color = "orange",
                .Gradient = "linear-gradient(135deg, #f59e0b, #fbbf24)",
                .Url = "~/Pages/Library/Default.aspx",
                .Badge = "الكتب",
                .Stats = "5,200 كتاب"
            },
            New SystemModuleInfo() With {
                .Id = "reports",
                .Title = "التقارير",
                .Description = "تقارير شاملة لجميع أقسام النظام مع الرسوم البيانية",
                .Icon = "fas fa-chart-line",
                .Color = "red",
                .Gradient = "linear-gradient(135deg, #dc2626, #ef4444)",
                .Url = "~/Pages/Reports/Default.aspx",
                .Badge = "التحليل",
                .Stats = "125 تقرير"
            },
            New SystemModuleInfo() With {
                .Id = "settings",
                .Title = "الإعدادات",
                .Description = "إعدادات النظام والصلاحيات وإدارة المستخدمين",
                .Icon = "fas fa-cog",
                .Color = "gray",
                .Gradient = "linear-gradient(135deg, #64748b, #94a3b8)",
                .Url = "~/Pages/Settings/Default.aspx",
                .Badge = "النظام",
                .Stats = "15 إعداد"
            }
        }
        
        For Each moduleInfo As SystemModuleInfo In systemModules
            cardsHtml.AppendLine(GenerateAdvancedModuleCard(moduleInfo))
        Next
        
        Return cardsHtml.ToString()
    End Function
    
    ''' <summary>
    ''' إنشاء بطاقة وحدة متطورة
    ''' Generate advanced module card
    ''' </summary>
    Private Shared Function GenerateAdvancedModuleCard(ByVal moduleInfo As SystemModuleInfo) As String
        Dim cardHtml As New StringBuilder()
        
        cardHtml.AppendLine("      <div class='module-card-advanced " & moduleInfo.Color & "-card' data-module='" & moduleInfo.Id & "' data-url='" & ResolveUrl(moduleInfo.Url) & "'>")
        cardHtml.AppendLine("        <div class='card-background-pattern'></div>")
        cardHtml.AppendLine("        <div class='card-content-wrapper'>")
        
        ' هيدر البطاقة مع الأيقونة والشارة
        cardHtml.AppendLine("          <div class='card-header-advanced'>")
        cardHtml.AppendLine("            <div class='card-icon-wrapper'>")
        cardHtml.AppendLine("              <div class='icon-bg' style='background: " & moduleInfo.Gradient & ";'></div>")
        cardHtml.AppendLine("              <i class='" & moduleInfo.Icon & " card-main-icon'></i>")
        cardHtml.AppendLine("            </div>")
        cardHtml.AppendLine("            <div class='card-badge " & moduleInfo.Color & "-badge'>")
        cardHtml.AppendLine("              <span>" & moduleInfo.Badge & "</span>")
        cardHtml.AppendLine("            </div>")
        cardHtml.AppendLine("          </div>")
        
        ' محتوى البطاقة
        cardHtml.AppendLine("          <div class='card-body-advanced'>")
        cardHtml.AppendLine("            <h3 class='card-title-advanced'>" & HttpUtility.HtmlEncode(moduleInfo.Title) & "</h3>")
        cardHtml.AppendLine("            <p class='card-description-advanced'>" & HttpUtility.HtmlEncode(moduleInfo.Description) & "</p>")
        cardHtml.AppendLine("            <div class='card-stats'>")
        cardHtml.AppendLine("              <i class='fas fa-chart-bar'></i>")
        cardHtml.AppendLine("              <span>" & moduleInfo.Stats & "</span>")
        cardHtml.AppendLine("            </div>")
        cardHtml.AppendLine("          </div>")
        
        ' فوتر البطاقة مع الزر
        cardHtml.AppendLine("          <div class='card-footer-advanced'>")
        cardHtml.AppendLine("            <button class='card-action-btn " & moduleInfo.Color & "-btn' onclick='navigateToModule(""" & ResolveUrl(moduleInfo.Url) & """, """ & moduleInfo.Id & """)'>")
        cardHtml.AppendLine("              <span>دخول للوحدة</span>")
        cardHtml.AppendLine("              <i class='fas fa-arrow-left'></i>")
        cardHtml.AppendLine("            </button>")
        cardHtml.AppendLine("          </div>")
        
        cardHtml.AppendLine("        </div>")
        cardHtml.AppendLine("        <div class='card-hover-effect'></div>")
        cardHtml.AppendLine("      </div>")
        
        Return cardHtml.ToString()
    End Function
    
    ''' <summary>
    ''' الحصول على أنماط CSS المتقدمة
    ''' Get advanced CSS styles
    ''' </summary>
    Private Shared Function GetAdvancedModernTocStyles() As String
        Return "<style>" & vbCrLf & _
"/* Modern TableOfContents Advanced Styles */" & vbCrLf & _
".modern-table-of-contents-converter {" & vbCrLf & _
"  max-width: 1400px;" & vbCrLf & _
"  margin: 0 auto;" & vbCrLf & _
"  padding: 2rem;" & vbCrLf & _
"  font-family: 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;" & vbCrLf & _
"  direction: rtl;" & vbCrLf & _
"  background: linear-gradient(135deg, #f8fafc 0%, #e2e8f0 100%);" & vbCrLf & _
"  border-radius: 24px;" & vbCrLf & _
"  box-shadow: 0 8px 32px rgba(0, 0, 0, 0.08);" & vbCrLf & _
"  position: relative;" & vbCrLf & _
"  overflow: hidden;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".modern-table-of-contents-converter::before {" & vbCrLf & _
"  content: '';" & vbCrLf & _
"  position: absolute;" & vbCrLf & _
"  top: 0;" & vbCrLf & _
"  left: 0;" & vbCrLf & _
"  right: 0;" & vbCrLf & _
"  height: 4px;" & vbCrLf & _
"  background: linear-gradient(90deg, #2563eb, #3b82f6, #8b5cf6, #ec4899);" & vbCrLf & _
"  background-size: 200% 100%;" & vbCrLf & _
"  animation: gradientShift 3s ease-in-out infinite;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"@keyframes gradientShift {" & vbCrLf & _
"  0%, 100% { background-position: 0% 50%; }" & vbCrLf & _
"  50% { background-position: 100% 50%; }" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"/* Advanced Header Styles */" & vbCrLf & _
".toc-modern-header {" & vbCrLf & _
"  position: relative;" & vbCrLf & _
"  text-align: center;" & vbCrLf & _
"  padding: 3rem 2rem;" & vbCrLf & _
"  margin-bottom: 3rem;" & vbCrLf & _
"  overflow: hidden;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".header-backdrop {" & vbCrLf & _
"  position: absolute;" & vbCrLf & _
"  top: 0;" & vbCrLf & _
"  left: 0;" & vbCrLf & _
"  right: 0;" & vbCrLf & _
"  bottom: 0;" & vbCrLf & _
"  background: linear-gradient(135deg, rgba(37, 99, 235, 0.05), rgba(147, 51, 234, 0.05));" & vbCrLf & _
"  border-radius: 20px;" & vbCrLf & _
"  backdrop-filter: blur(10px);" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".header-content-wrapper {" & vbCrLf & _
"  position: relative;" & vbCrLf & _
"  z-index: 2;" & vbCrLf & _
"  display: flex;" & vbCrLf & _
"  flex-direction: column;" & vbCrLf & _
"  align-items: center;" & vbCrLf & _
"  gap: 2rem;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".header-icon-container {" & vbCrLf & _
"  position: relative;" & vbCrLf & _
"  width: 120px;" & vbCrLf & _
"  height: 120px;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".header-icon-bg {" & vbCrLf & _
"  position: absolute;" & vbCrLf & _
"  top: 0;" & vbCrLf & _
"  left: 0;" & vbCrLf & _
"  right: 0;" & vbCrLf & _
"  bottom: 0;" & vbCrLf & _
"  background: linear-gradient(135deg, #2563eb, #3b82f6);" & vbCrLf & _
"  border-radius: 30px;" & vbCrLf & _
"  box-shadow: 0 12px 30px rgba(37, 99, 235, 0.3);" & vbCrLf & _
"  animation: iconPulse 2s ease-in-out infinite;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".header-main-icon {" & vbCrLf & _
"  position: absolute;" & vbCrLf & _
"  top: 50%;" & vbCrLf & _
"  left: 50%;" & vbCrLf & _
"  transform: translate(-50%, -50%);" & vbCrLf & _
"  font-size: 3rem;" & vbCrLf & _
"  color: white;" & vbCrLf & _
"  z-index: 2;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"@keyframes iconPulse {" & vbCrLf & _
"  0%, 100% { transform: scale(1); }" & vbCrLf & _
"  50% { transform: scale(1.05); }" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".main-title {" & vbCrLf & _
"  font-size: 3rem;" & vbCrLf & _
"  font-weight: 800;" & vbCrLf & _
"  background: linear-gradient(135deg, #1e293b, #475569);" & vbCrLf & _
"  -webkit-background-clip: text;" & vbCrLf & _
"  -webkit-text-fill-color: transparent;" & vbCrLf & _
"  margin: 0;" & vbCrLf & _
"  line-height: 1.2;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".main-subtitle {" & vbCrLf & _
"  font-size: 1.3rem;" & vbCrLf & _
"  color: #64748b;" & vbCrLf & _
"  margin: 0;" & vbCrLf & _
"  line-height: 1.6;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".title-decorator {" & vbCrLf & _
"  display: flex;" & vbCrLf & _
"  align-items: center;" & vbCrLf & _
"  justify-content: center;" & vbCrLf & _
"  gap: 1rem;" & vbCrLf & _
"  margin-top: 1.5rem;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".decorator-line {" & vbCrLf & _
"  width: 60px;" & vbCrLf & _
"  height: 3px;" & vbCrLf & _
"  background: linear-gradient(90deg, #2563eb, #3b82f6);" & vbCrLf & _
"  border-radius: 2px;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".decorator-diamond {" & vbCrLf & _
"  width: 12px;" & vbCrLf & _
"  height: 12px;" & vbCrLf & _
"  background: #2563eb;" & vbCrLf & _
"  transform: rotate(45deg);" & vbCrLf & _
"  border-radius: 2px;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"/* Modules Grid */" & vbCrLf & _
".modules-container {" & vbCrLf & _
"  margin-bottom: 3rem;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".modules-grid-modern {" & vbCrLf & _
"  display: grid;" & vbCrLf & _
"  grid-template-columns: repeat(auto-fit, minmax(380px, 1fr));" & vbCrLf & _
"  gap: 2rem;" & vbCrLf & _
"  padding: 1rem;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"/* Advanced Module Cards */" & vbCrLf & _
".module-card-advanced {" & vbCrLf & _
"  position: relative;" & vbCrLf & _
"  background: white;" & vbCrLf & _
"  border-radius: 20px;" & vbCrLf & _
"  padding: 0;" & vbCrLf & _
"  overflow: hidden;" & vbCrLf & _
"  transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);" & vbCrLf & _
"  cursor: pointer;" & vbCrLf & _
"  border: 1px solid rgba(226, 232, 240, 0.8);" & vbCrLf & _
"  box-shadow: 0 4px 16px rgba(0, 0, 0, 0.08);" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".module-card-advanced:hover {" & vbCrLf & _
"  transform: translateY(-8px) scale(1.02);" & vbCrLf & _
"  box-shadow: 0 20px 40px rgba(0, 0, 0, 0.15);" & vbCrLf & _
"  border-color: rgba(37, 99, 235, 0.3);" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".card-background-pattern {" & vbCrLf & _
"  position: absolute;" & vbCrLf & _
"  top: 0;" & vbCrLf & _
"  right: 0;" & vbCrLf & _
"  width: 100px;" & vbCrLf & _
"  height: 100px;" & vbCrLf & _
"  background: linear-gradient(135deg, rgba(37, 99, 235, 0.05), rgba(147, 51, 234, 0.05));" & vbCrLf & _
"  border-radius: 0 20px 0 100px;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".card-content-wrapper {" & vbCrLf & _
"  position: relative;" & vbCrLf & _
"  z-index: 2;" & vbCrLf & _
"  padding: 2rem;" & vbCrLf & _
"  height: 100%;" & vbCrLf & _
"  display: flex;" & vbCrLf & _
"  flex-direction: column;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".card-header-advanced {" & vbCrLf & _
"  display: flex;" & vbCrLf & _
"  justify-content: space-between;" & vbCrLf & _
"  align-items: center;" & vbCrLf & _
"  margin-bottom: 1.5rem;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".card-icon-wrapper {" & vbCrLf & _
"  position: relative;" & vbCrLf & _
"  width: 60px;" & vbCrLf & _
"  height: 60px;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".icon-bg {" & vbCrLf & _
"  position: absolute;" & vbCrLf & _
"  top: 0;" & vbCrLf & _
"  left: 0;" & vbCrLf & _
"  right: 0;" & vbCrLf & _
"  bottom: 0;" & vbCrLf & _
"  border-radius: 16px;" & vbCrLf & _
"  box-shadow: 0 4px 12px rgba(0, 0, 0, 0.2);" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".card-main-icon {" & vbCrLf & _
"  position: absolute;" & vbCrLf & _
"  top: 50%;" & vbCrLf & _
"  left: 50%;" & vbCrLf & _
"  transform: translate(-50%, -50%);" & vbCrLf & _
"  font-size: 1.8rem;" & vbCrLf & _
"  color: white;" & vbCrLf & _
"  z-index: 2;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".card-badge {" & vbCrLf & _
"  padding: 0.4rem 1rem;" & vbCrLf & _
"  border-radius: 50px;" & vbCrLf & _
"  font-size: 0.85rem;" & vbCrLf & _
"  font-weight: 600;" & vbCrLf & _
"  color: white;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".blue-badge { background: linear-gradient(135deg, #2563eb, #3b82f6); }" & vbCrLf & _
".green-badge { background: linear-gradient(135deg, #10b981, #06d6a0); }" & vbCrLf & _
".purple-badge { background: linear-gradient(135deg, #7c3aed, #8b5cf6); }" & vbCrLf & _
".orange-badge { background: linear-gradient(135deg, #f59e0b, #fbbf24); }" & vbCrLf & _
".red-badge { background: linear-gradient(135deg, #dc2626, #ef4444); }" & vbCrLf & _
".gray-badge { background: linear-gradient(135deg, #64748b, #94a3b8); }" & vbCrLf & _
"" & vbCrLf & _
".card-body-advanced {" & vbCrLf & _
"  flex-grow: 1;" & vbCrLf & _
"  margin-bottom: 1.5rem;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".card-title-advanced {" & vbCrLf & _
"  font-size: 1.4rem;" & vbCrLf & _
"  font-weight: 700;" & vbCrLf & _
"  color: #1e293b;" & vbCrLf & _
"  margin: 0 0 0.75rem 0;" & vbCrLf & _
"  line-height: 1.3;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".card-description-advanced {" & vbCrLf & _
"  color: #64748b;" & vbCrLf & _
"  font-size: 0.95rem;" & vbCrLf & _
"  line-height: 1.6;" & vbCrLf & _
"  margin: 0 0 1rem 0;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".card-stats {" & vbCrLf & _
"  display: flex;" & vbCrLf & _
"  align-items: center;" & vbCrLf & _
"  gap: 0.5rem;" & vbCrLf & _
"  color: #6b7280;" & vbCrLf & _
"  font-size: 0.9rem;" & vbCrLf & _
"  font-weight: 600;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".card-footer-advanced {" & vbCrLf & _
"  margin-top: auto;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".card-action-btn {" & vbCrLf & _
"  width: 100%;" & vbCrLf & _
"  padding: 0.875rem 1.5rem;" & vbCrLf & _
"  border: none;" & vbCrLf & _
"  border-radius: 12px;" & vbCrLf & _
"  font-weight: 600;" & vbCrLf & _
"  font-size: 0.95rem;" & vbCrLf & _
"  color: white;" & vbCrLf & _
"  cursor: pointer;" & vbCrLf & _
"  transition: all 0.3s ease;" & vbCrLf & _
"  display: flex;" & vbCrLf & _
"  align-items: center;" & vbCrLf & _
"  justify-content: center;" & vbCrLf & _
"  gap: 0.5rem;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".blue-btn { background: linear-gradient(135deg, #2563eb, #3b82f6); }" & vbCrLf & _
".green-btn { background: linear-gradient(135deg, #10b981, #06d6a0); }" & vbCrLf & _
".purple-btn { background: linear-gradient(135deg, #7c3aed, #8b5cf6); }" & vbCrLf & _
".orange-btn { background: linear-gradient(135deg, #f59e0b, #fbbf24); }" & vbCrLf & _
".red-btn { background: linear-gradient(135deg, #dc2626, #ef4444); }" & vbCrLf & _
".gray-btn { background: linear-gradient(135deg, #64748b, #94a3b8); }" & vbCrLf & _
"" & vbCrLf & _
".card-action-btn:hover {" & vbCrLf & _
"  transform: translateY(-2px);" & vbCrLf & _
"  box-shadow: 0 8px 20px rgba(0, 0, 0, 0.2);" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".card-hover-effect {" & vbCrLf & _
"  position: absolute;" & vbCrLf & _
"  top: 0;" & vbCrLf & _
"  left: 0;" & vbCrLf & _
"  right: 0;" & vbCrLf & _
"  bottom: 0;" & vbCrLf & _
"  background: linear-gradient(135deg, rgba(37, 99, 235, 0.05), rgba(147, 51, 234, 0.05));" & vbCrLf & _
"  opacity: 0;" & vbCrLf & _
"  transition: opacity 0.3s ease;" & vbCrLf & _
"  pointer-events: none;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".module-card-advanced:hover .card-hover-effect {" & vbCrLf & _
"  opacity: 1;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"/* Quick Overview Section */" & vbCrLf & _
".quick-overview-section {" & vbCrLf & _
"  background: white;" & vbCrLf & _
"  border-radius: 20px;" & vbCrLf & _
"  padding: 2.5rem;" & vbCrLf & _
"  box-shadow: 0 4px 16px rgba(0, 0, 0, 0.08);" & vbCrLf & _
"  border: 1px solid rgba(226, 232, 240, 0.8);" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".overview-header {" & vbCrLf & _
"  text-align: center;" & vbCrLf & _
"  margin-bottom: 2.5rem;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".overview-title {" & vbCrLf & _
"  display: flex;" & vbCrLf & _
"  align-items: center;" & vbCrLf & _
"  justify-content: center;" & vbCrLf & _
"  gap: 1rem;" & vbCrLf & _
"  font-size: 1.8rem;" & vbCrLf & _
"  font-weight: 700;" & vbCrLf & _
"  color: #1e293b;" & vbCrLf & _
"  margin: 0;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".overview-stats-grid {" & vbCrLf & _
"  display: grid;" & vbCrLf & _
"  grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));" & vbCrLf & _
"  gap: 1.5rem;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".stat-modern-card {" & vbCrLf & _
"  display: flex;" & vbCrLf & _
"  align-items: center;" & vbCrLf & _
"  gap: 1.25rem;" & vbCrLf & _
"  background: linear-gradient(135deg, #f8fafc, #e2e8f0);" & vbCrLf & _
"  border-radius: 16px;" & vbCrLf & _
"  padding: 1.75rem;" & vbCrLf & _
"  border: 1px solid rgba(226, 232, 240, 0.8);" & vbCrLf & _
"  transition: all 0.3s ease;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".stat-modern-card:hover {" & vbCrLf & _
"  transform: translateY(-4px);" & vbCrLf & _
"  box-shadow: 0 12px 28px rgba(0, 0, 0, 0.12);" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".stat-icon {" & vbCrLf & _
"  width: 60px;" & vbCrLf & _
"  height: 60px;" & vbCrLf & _
"  border-radius: 16px;" & vbCrLf & _
"  display: flex;" & vbCrLf & _
"  align-items: center;" & vbCrLf & _
"  justify-content: center;" & vbCrLf & _
"  color: white;" & vbCrLf & _
"  font-size: 1.5rem;" & vbCrLf & _
"  flex-shrink: 0;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".stat-blue { background: linear-gradient(135deg, #2563eb, #3b82f6); }" & vbCrLf & _
".stat-green { background: linear-gradient(135deg, #10b981, #06d6a0); }" & vbCrLf & _
".stat-orange { background: linear-gradient(135deg, #f59e0b, #fbbf24); }" & vbCrLf & _
".stat-purple { background: linear-gradient(135deg, #7c3aed, #8b5cf6); }" & vbCrLf & _
"" & vbCrLf & _
".stat-content {" & vbCrLf & _
"  flex-grow: 1;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".stat-number {" & vbCrLf & _
"  font-size: 2.25rem;" & vbCrLf & _
"  font-weight: 800;" & vbCrLf & _
"  color: #1e293b;" & vbCrLf & _
"  line-height: 1;" & vbCrLf & _
"  margin-bottom: 0.25rem;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".stat-label {" & vbCrLf & _
"  font-size: 0.95rem;" & vbCrLf & _
"  color: #64748b;" & vbCrLf & _
"  font-weight: 600;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"/* Responsive Design */" & vbCrLf & _
"@media (max-width: 1200px) {" & vbCrLf & _
"  .modules-grid-modern {" & vbCrLf & _
"    grid-template-columns: repeat(auto-fit, minmax(320px, 1fr));" & vbCrLf & _
"  }" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"@media (max-width: 768px) {" & vbCrLf & _
"  .modern-table-of-contents-converter {" & vbCrLf & _
"    padding: 1rem;" & vbCrLf & _
"  }" & vbCrLf & _
"  " & vbCrLf & _
"  .toc-modern-header {" & vbCrLf & _
"    padding: 2rem 1rem;" & vbCrLf & _
"  }" & vbCrLf & _
"  " & vbCrLf & _
"  .main-title {" & vbCrLf & _
"    font-size: 2rem;" & vbCrLf & _
"  }" & vbCrLf & _
"  " & vbCrLf & _
"  .modules-grid-modern {" & vbCrLf & _
"    grid-template-columns: 1fr;" & vbCrLf & _
"    gap: 1.5rem;" & vbCrLf & _
"    padding: 0.5rem;" & vbCrLf & _
"  }" & vbCrLf & _
"  " & vbCrLf & _
"  .overview-stats-grid {" & vbCrLf & _
"    grid-template-columns: repeat(2, 1fr);" & vbCrLf & _
"  }" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"@media (max-width: 480px) {" & vbCrLf & _
"  .header-icon-container {" & vbCrLf & _
"    width: 80px;" & vbCrLf & _
"    height: 80px;" & vbCrLf & _
"  }" & vbCrLf & _
"  " & vbCrLf & _
"  .header-main-icon {" & vbCrLf & _
"    font-size: 2rem;" & vbCrLf & _
"  }" & vbCrLf & _
"  " & vbCrLf & _
"  .overview-stats-grid {" & vbCrLf & _
"    grid-template-columns: 1fr;" & vbCrLf & _
"  }" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"/* Animation Classes */" & vbCrLf & _
".module-card-advanced {" & vbCrLf & _
"  animation: cardFadeIn 0.6s ease-out;" & vbCrLf & _
"  animation-fill-mode: both;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".module-card-advanced:nth-child(1) { animation-delay: 0.1s; }" & vbCrLf & _
".module-card-advanced:nth-child(2) { animation-delay: 0.2s; }" & vbCrLf & _
".module-card-advanced:nth-child(3) { animation-delay: 0.3s; }" & vbCrLf & _
".module-card-advanced:nth-child(4) { animation-delay: 0.4s; }" & vbCrLf & _
".module-card-advanced:nth-child(5) { animation-delay: 0.5s; }" & vbCrLf & _
".module-card-advanced:nth-child(6) { animation-delay: 0.6s; }" & vbCrLf & _
"" & vbCrLf & _
".stat-modern-card {" & vbCrLf & _
"  animation: statFadeIn 0.5s ease-out;" & vbCrLf & _
"  animation-fill-mode: both;" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
".stat-modern-card:nth-child(1) { animation-delay: 0.7s; }" & vbCrLf & _
".stat-modern-card:nth-child(2) { animation-delay: 0.8s; }" & vbCrLf & _
".stat-modern-card:nth-child(3) { animation-delay: 0.9s; }" & vbCrLf & _
".stat-modern-card:nth-child(4) { animation-delay: 1s; }" & vbCrLf & _
"" & vbCrLf & _
"@keyframes cardFadeIn {" & vbCrLf & _
"  from {" & vbCrLf & _
"    opacity: 0;" & vbCrLf & _
"    transform: translateY(30px) scale(0.95);" & vbCrLf & _
"  }" & vbCrLf & _
"  to {" & vbCrLf & _
"    opacity: 1;" & vbCrLf & _
"    transform: translateY(0) scale(1);" & vbCrLf & _
"  }" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"@keyframes statFadeIn {" & vbCrLf & _
"  from {" & vbCrLf & _
"    opacity: 0;" & vbCrLf & _
"    transform: translateX(-20px);" & vbCrLf & _
"  }" & vbCrLf & _
"  to {" & vbCrLf & _
"    opacity: 1;" & vbCrLf & _
"    transform: translateX(0);" & vbCrLf & _
"  }" & vbCrLf & _
"}" & vbCrLf & _
"</style>"
    End Function
    
    ''' <summary>
    ''' الحصول على JavaScript المتقدم
    ''' Get advanced JavaScript
    ''' </summary>
    Private Shared Function GetAdvancedModernTocScript() As String
        Return "<script>" & vbCrLf & _
"// Advanced Modern TableOfContents JavaScript" & vbCrLf & _
"document.addEventListener('DOMContentLoaded', function() {" & vbCrLf & _
"  console.log('Advanced Modern TableOfContents initialized');" & vbCrLf & _
"  " & vbCrLf & _
"  // تفعيل العداد المتحرك للإحصائيات" & vbCrLf & _
"  initializeStatCounters();" & vbCrLf & _
"  " & vbCrLf & _
"  // تفعيل تأثيرات البطاقات" & vbCrLf & _
"  initializeCardEffects();" & vbCrLf & _
"  " & vbCrLf & _
"  // مراقبة ظهور العناصر" & vbCrLf & _
"  initializeIntersectionObserver();" & vbCrLf & _
"});" & vbCrLf & _
"" & vbCrLf & _
"// دالة التنقل إلى الوحدة" & vbCrLf & _
"function navigateToModule(moduleUrl, moduleId) {" & vbCrLf & _
"  if (!moduleUrl || moduleUrl === '#') {" & vbCrLf & _
"    showModuleNotification('هذه الوحدة قيد التطوير', 'info');" & vbCrLf & _
"    return;" & vbCrLf & _
"  }" & vbCrLf & _
"  " & vbCrLf & _
"  // إضافة تأثير الانتقال" & vbCrLf & _
"  const card = event.target.closest('.module-card-advanced');" & vbCrLf & _
"  if (card) {" & vbCrLf & _
"    card.style.transform = 'scale(0.95)';" & vbCrLf & _
"    card.style.opacity = '0.7';" & vbCrLf & _
"  }" & vbCrLf & _
"  " & vbCrLf & _
"  // حفظ الوحدة المختارة" & vbCrLf & _
"  if (typeof localStorage !== 'undefined') {" & vbCrLf & _
"    localStorage.setItem('lastSelectedModule', moduleId);" & vbCrLf & _
"  }" & vbCrLf & _
"  " & vbCrLf & _
"  // الانتقال بعد تأخير قصير" & vbCrLf & _
"  setTimeout(function() {" & vbCrLf & _
"    window.location.href = moduleUrl;" & vbCrLf & _
"  }, 300);" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"// تفعيل العداد المتحرك" & vbCrLf & _
"function initializeStatCounters() {" & vbCrLf & _
"  const statNumbers = document.querySelectorAll('.stat-number[data-target]');" & vbCrLf & _
"  " & vbCrLf & _
"  statNumbers.forEach(function(stat) {" & vbCrLf & _
"    const target = parseInt(stat.getAttribute('data-target'));" & vbCrLf & _
"    if (isNaN(target)) return;" & vbCrLf & _
"    " & vbCrLf & _
"    let current = 0;" & vbCrLf & _
"    const increment = target / 60;" & vbCrLf & _
"    const duration = 2000;" & vbCrLf & _
"    const stepTime = duration / 60;" & vbCrLf & _
"    " & vbCrLf & _
"    const timer = setInterval(function() {" & vbCrLf & _
"      current += increment;" & vbCrLf & _
"      if (current >= target) {" & vbCrLf & _
"        current = target;" & vbCrLf & _
"        clearInterval(timer);" & vbCrLf & _
"      }" & vbCrLf & _
"      " & vbCrLf & _
"      stat.textContent = Math.floor(current).toLocaleString('ar-SA');" & vbCrLf & _
"    }, stepTime);" & vbCrLf & _
"  });" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"// تفعيل تأثيرات البطاقات" & vbCrLf & _
"function initializeCardEffects() {" & vbCrLf & _
"  const moduleCards = document.querySelectorAll('.module-card-advanced');" & vbCrLf & _
"  " & vbCrLf & _
"  moduleCards.forEach(function(card) {" & vbCrLf & _
"    // إضافة تأثير النقر على البطاقة" & vbCrLf & _
"    card.addEventListener('click', function(e) {" & vbCrLf & _
"      // منع النقر إذا كان على الزر" & vbCrLf & _
"      if (e.target.closest('.card-action-btn')) {" & vbCrLf & _
"        return;" & vbCrLf & _
"      }" & vbCrLf & _
"      " & vbCrLf & _
"      // تفعيل الزر" & vbCrLf & _
"      const button = card.querySelector('.card-action-btn');" & vbCrLf & _
"      if (button) {" & vbCrLf & _
"        button.click();" & vbCrLf & _
"      }" & vbCrLf & _
"    });" & vbCrLf & _
"    " & vbCrLf & _
"    // تأثير الماوس" & vbCrLf & _
"    card.addEventListener('mouseenter', function() {" & vbCrLf & _
"      this.style.transition = 'all 0.4s cubic-bezier(0.4, 0, 0.2, 1)';" & vbCrLf & _
"    });" & vbCrLf & _
"    " & vbCrLf & _
"    card.addEventListener('mouseleave', function() {" & vbCrLf & _
"      this.style.transform = '';" & vbCrLf & _
"      this.style.opacity = '';" & vbCrLf & _
"    });" & vbCrLf & _
"  });" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"// مراقبة ظهور العناصر" & vbCrLf & _
"function initializeIntersectionObserver() {" & vbCrLf & _
"  if (!window.IntersectionObserver) return;" & vbCrLf & _
"  " & vbCrLf & _
"  const observerOptions = {" & vbCrLf & _
"    threshold: 0.3," & vbCrLf & _
"    rootMargin: '0px 0px -50px 0px'" & vbCrLf & _
"  };" & vbCrLf & _
"  " & vbCrLf & _
"  const observer = new IntersectionObserver(function(entries) {" & vbCrLf & _
"    entries.forEach(function(entry) {" & vbCrLf & _
"      if (entry.isIntersecting) {" & vbCrLf & _
"        entry.target.classList.add('animate-in');" & vbCrLf & _
"      }" & vbCrLf & _
"    });" & vbCrLf & _
"  }, observerOptions);" & vbCrLf & _
"  " & vbCrLf & _
"  // مراقبة العناصر" & vbCrLf & _
"  const elements = document.querySelectorAll('.module-card-advanced, .stat-modern-card');" & vbCrLf & _
"  elements.forEach(function(el) {" & vbCrLf & _
"    observer.observe(el);" & vbCrLf & _
"  });" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"// دالة عرض الإشعارات" & vbCrLf & _
"function showModuleNotification(message, type) {" & vbCrLf & _
"  if (typeof window.showNotification === 'function') {" & vbCrLf & _
"    window.showNotification(message, type);" & vbCrLf & _
"  } else {" & vbCrLf & _
"    alert(message);" & vbCrLf & _
"  }" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"// استعادة الوحدة المختارة سابقاً" & vbCrLf & _
"function highlightLastSelectedModule() {" & vbCrLf & _
"  if (typeof localStorage === 'undefined') return;" & vbCrLf & _
"  " & vbCrLf & _
"  const lastModule = localStorage.getItem('lastSelectedModule');" & vbCrLf & _
"  if (lastModule) {" & vbCrLf & _
"    const card = document.querySelector('[data-module=""' + lastModule + '""]');" & vbCrLf & _
"    if (card) {" & vbCrLf & _
"      card.style.boxShadow = '0 0 0 2px #2563eb';" & vbCrLf & _
"      setTimeout(function() {" & vbCrLf & _
"        card.style.boxShadow = '';" & vbCrLf & _
"      }, 3000);" & vbCrLf & _
"    }" & vbCrLf & _
"  }" & vbCrLf & _
"}" & vbCrLf & _
"" & vbCrLf & _
"// تشغيل التمييز عند التحميل" & vbCrLf & _
"setTimeout(highlightLastSelectedModule, 1000);" & vbCrLf & _
"</script>"
    End Function

    ''' <summary>
    ''' الحصول على بيانات خريطة الموقع
    ''' Get site map data
    ''' </summary>
    Private Shared Function GetSiteMapData() As SiteMapNodeCollection
        Try
            If SiteMap.RootNode IsNot Nothing Then
                Return SiteMap.RootNode.ChildNodes
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' التحقق من إمكانية وصول المستخدم للعقدة
    ''' Check if user can access the node
    ''' </summary>
    Private Shared Function CanUserAccessNode(ByVal node As SiteMapNode) As Boolean
        Try
            If HttpContext.Current Is Nothing Then Return True
            If HttpContext.Current.User Is Nothing Then Return False
            
            ' التحقق من الأدوار
            If node.Roles IsNot Nothing Then
                For Each role As String In node.Roles
                    If HttpContext.Current.User.IsInRole(role) Then
                        Return True
                    End If
                Next
            End If
            
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    ''' <summary>
    ''' تحديد الأيقونة للعقدة
    ''' Determine icon for node
    ''' </summary>
    Private Shared Function GetIconForNode(ByVal node As SiteMapNode) As String
        If node.Url IsNot Nothing Then
            Dim url As String = node.Url.ToLower()
            
            If url.Contains("home") Or url.Contains("default") Then
                Return "fas fa-home"
            ElseIf url.Contains("user") Or url.Contains("profile") Then
                Return "fas fa-user"
            ElseIf url.Contains("report") Then
                Return "fas fa-chart-bar"
            ElseIf url.Contains("setting") Then
                Return "fas fa-cog"
            ElseIf url.Contains("admin") Then
                Return "fas fa-shield-alt"
            ElseIf url.Contains("finance") Or url.Contains("accounting") Then
                Return "fas fa-dollar-sign"
            ElseIf url.Contains("inventory") Or url.Contains("warehouse") Then
                Return "fas fa-boxes"
            ElseIf url.Contains("sales") Then
                Return "fas fa-shopping-cart"
            ElseIf url.Contains("hr") Or url.Contains("employee") Then
                Return "fas fa-users"
            Else
                Return "fas fa-file-alt"
            End If
        End If
        
        Return "fas fa-file-alt"
    End Function

    ''' <summary>
    ''' تحديد لون الكارت
    ''' Determine card color
    ''' </summary>
    Private Shared Function GetCardColor(ByVal node As SiteMapNode) As String
        Dim colors() As String = {"blue", "purple", "green", "orange", "red", "cyan"}
        Dim index As Integer = Math.Abs(node.Title.GetHashCode()) Mod colors.Length
        Return "card-" & colors(index)
    End Function

    ''' <summary>
    ''' حل URL النسبي
    ''' Resolve relative URL
    ''' </summary>
    Private Shared Function ResolveUrl(ByVal url As String) As String
        If String.IsNullOrEmpty(url) Then Return "#"
        
        If url.StartsWith("~/") Then
            If HttpContext.Current IsNot Nothing Then
                Return VirtualPathUtility.ToAbsolute(url)
            Else
                Return url.Substring(1) ' Remove ~
            End If
        End If
        
        Return url
    End Function

    ''' <summary>
    ''' الحصول على النص المترجم
    ''' Get localized text
    ''' </summary>
    Private Shared Function GetLocalizedText(ByVal key As String) As String
        Try
            ' محاولة الحصول على الترجمة من الموارد
            If HttpContext.Current IsNot Nothing Then
                Dim resourceValue As Object = HttpContext.GetLocalResourceObject("~/App_LocalResources/Default.aspx.resx", key, HttpContext.Current.Session("Culture"))
                If resourceValue IsNot Nothing Then
                    Return resourceValue.ToString()
                End If
            End If
        Catch
            ' تجاهل أخطاء الترجمة
        End Try
        
        ' إرجاع النص الافتراضي
        Select Case key
            Case "Navigation" : Return "التنقل"
            Case "Module" : Return "وحدة"
            Case "Open" : Return "فتح"
            Case "Loading" : Return "جاري التحميل"
            Case Else : Return key
        End Select
    End Function

    ''' <summary>
    ''' إنشاء عرض الخطأ
    ''' Generate error display
    ''' </summary>
    Private Shared Function GenerateErrorDisplay(ByVal errorMessage As String) As String
        Return "<div class='error-display'>" & _
               "<i class='fas fa-exclamation-triangle'></i>" & _
               "<p>" & HttpUtility.HtmlEncode(errorMessage) & "</p>" & _
               "</div>"
    End Function

    ''' <summary>
    ''' الحصول على أنماط CSS الحديثة
    ''' Get modern CSS styles
    ''' </summary>
    Private Shared Function GetModernTocStyles() As String
        Return "<style>" & vbCrLf & _
               ".modern-toc-container.converted-control {" & vbCrLf & _
               "  background: linear-gradient(135deg, rgba(37, 99, 235, 0.05), rgba(147, 51, 234, 0.05));" & vbCrLf & _
               "  border-radius: 20px;" & vbCrLf & _
               "  padding: 2rem;" & vbCrLf & _
               "  margin: 2rem 0;" & vbCrLf & _
               "  border: 1px solid rgba(37, 99, 235, 0.1);" & vbCrLf & _
               "}" & vbCrLf & _
               ".modern-toc-header {" & vbCrLf & _
               "  text-align: center;" & vbCrLf & _
               "  margin-bottom: 2rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".toc-title {" & vbCrLf & _
               "  display: flex;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "  justify-content: center;" & vbCrLf & _
               "  gap: 0.5rem;" & vbCrLf & _
               "  color: #2563eb;" & vbCrLf & _
               "  margin-bottom: 1rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".header-decoration {" & vbCrLf & _
               "  display: flex;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "  justify-content: center;" & vbCrLf & _
               "  gap: 0.5rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".decoration-line {" & vbCrLf & _
               "  height: 2px;" & vbCrLf & _
               "  width: 50px;" & vbCrLf & _
               "  background: linear-gradient(135deg, #2563eb, #3b82f6);" & vbCrLf & _
               "}" & vbCrLf & _
               ".decoration-dot {" & vbCrLf & _
               "  width: 8px;" & vbCrLf & _
               "  height: 8px;" & vbCrLf & _
               "  background: #2563eb;" & vbCrLf & _
               "  border-radius: 50%;" & vbCrLf & _
               "}" & vbCrLf & _
               ".modern-cards-grid {" & vbCrLf & _
               "  display: grid;" & vbCrLf & _
               "  grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));" & vbCrLf & _
               "  gap: 1.5rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".modern-card {" & vbCrLf & _
               "  background: white;" & vbCrLf & _
               "  border-radius: 16px;" & vbCrLf & _
               "  overflow: hidden;" & vbCrLf & _
               "  box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);" & vbCrLf & _
               "  transition: all 0.3s ease;" & vbCrLf & _
               "  cursor: pointer;" & vbCrLf & _
               "  position: relative;" & vbCrLf & _
               "}" & vbCrLf & _
               ".modern-card:hover {" & vbCrLf & _
               "  transform: translateY(-5px);" & vbCrLf & _
               "  box-shadow: 0 12px 30px rgba(0, 0, 0, 0.15);" & vbCrLf & _
               "}" & vbCrLf & _
               ".card-header {" & vbCrLf & _
               "  padding: 1.5rem;" & vbCrLf & _
               "  background: linear-gradient(135deg, #2563eb, #3b82f6);" & vbCrLf & _
               "  color: white;" & vbCrLf & _
               "  display: flex;" & vbCrLf & _
               "  justify-content: space-between;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "}" & vbCrLf & _
               ".card-icon {" & vbCrLf & _
               "  font-size: 2rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".card-badge {" & vbCrLf & _
               "  background: rgba(255, 255, 255, 0.2);" & vbCrLf & _
               "  padding: 0.25rem 0.75rem;" & vbCrLf & _
               "  border-radius: 50px;" & vbCrLf & _
               "  font-size: 0.8rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".card-content {" & vbCrLf & _
               "  padding: 1.5rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".card-title {" & vbCrLf & _
               "  color: #1e293b;" & vbCrLf & _
               "  margin-bottom: 0.5rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".card-description {" & vbCrLf & _
               "  color: #64748b;" & vbCrLf & _
               "  line-height: 1.6;" & vbCrLf & _
               "}" & vbCrLf & _
               ".card-footer {" & vbCrLf & _
               "  padding: 1rem 1.5rem;" & vbCrLf & _
               "  border-top: 1px solid #e2e8f0;" & vbCrLf & _
               "}" & vbCrLf & _
               ".card-button {" & vbCrLf & _
               "  background: linear-gradient(135deg, #2563eb, #3b82f6);" & vbCrLf & _
               "  color: white;" & vbCrLf & _
               "  border: none;" & vbCrLf & _
               "  padding: 0.75rem 1.5rem;" & vbCrLf & _
               "  border-radius: 8px;" & vbCrLf & _
               "  cursor: pointer;" & vbCrLf & _
               "  display: flex;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "  gap: 0.5rem;" & vbCrLf & _
               "  width: 100%;" & vbCrLf & _
               "  justify-content: center;" & vbCrLf & _
               "  transition: all 0.3s ease;" & vbCrLf & _
               "}" & vbCrLf & _
               ".card-button:hover {" & vbCrLf & _
               "  background: linear-gradient(135deg, #1d4ed8, #2563eb);" & vbCrLf & _
               "}" & vbCrLf & _
               ".loading-state {" & vbCrLf & _
               "  text-align: center;" & vbCrLf & _
               "  padding: 2rem;" & vbCrLf & _
               "  display: none;" & vbCrLf & _
               "}" & vbCrLf & _
               ".loading-spinner {" & vbCrLf & _
               "  width: 40px;" & vbCrLf & _
               "  height: 40px;" & vbCrLf & _
               "  border: 4px solid #e2e8f0;" & vbCrLf & _
               "  border-top: 4px solid #2563eb;" & vbCrLf & _
               "  border-radius: 50%;" & vbCrLf & _
               "  animation: spin 1s linear infinite;" & vbCrLf & _
               "  margin: 0 auto 1rem auto;" & vbCrLf & _
               "}" & vbCrLf & _
               "@keyframes spin {" & vbCrLf & _
               "  0% { transform: rotate(0deg); }" & vbCrLf & _
               "  100% { transform: rotate(360deg); }" & vbCrLf & _
               "}" & vbCrLf & _
               "@media (max-width: 768px) {" & vbCrLf & _
               "  .modern-cards-grid {" & vbCrLf & _
               "    grid-template-columns: 1fr;" & vbCrLf & _
               "  }" & vbCrLf & _
               "}" & vbCrLf & _
               "</style>"
    End Function

    ''' <summary>
    ''' الحصول على JavaScript للتفاعل
    ''' Get interactive JavaScript
    ''' </summary>
    Private Shared Function GetModernTocScript() As String
        Return "<script>" & vbCrLf & _
               "function navigateToPage(url) {" & vbCrLf & _
               "  if (url && url !== '#') {" & vbCrLf & _
               "    window.location.href = url;" & vbCrLf & _
               "  }" & vbCrLf & _
               "}" & vbCrLf & _
               "document.addEventListener('DOMContentLoaded', function() {" & vbCrLf & _
               "  const cards = document.querySelectorAll('.modern-card');" & vbCrLf & _
               "  cards.forEach(card => {" & vbCrLf & _
               "    card.addEventListener('click', function() {" & vbCrLf & _
               "      const url = this.getAttribute('data-url');" & vbCrLf & _
               "      if (url && url !== '#') {" & vbCrLf & _
               "        navigateToPage(url);" & vbCrLf & _
               "      }" & vbCrLf & _
               "    });" & vbCrLf & _
               "  });" & vbCrLf & _
               "  console.log('Modern TableOfContents converted and initialized');" & vbCrLf & _
               "});" & vbCrLf & _
               "</script>"
    End Function

    ''' <summary>
    ''' تحويل eZeeErpModulesrad إلى تصميم حديث
    ''' Convert eZeeErpModulesrad to modern design
    ''' </summary>
    Public Shared Function ConvertEZeeErpModulesToModern(ByVal page As Page, ByVal containerId As String) As String
        Try
            Return GenerateModernErpModules(containerId)
        Catch ex As Exception
            Return GenerateErrorMessage("خطأ في تحويل وحدات ERP", ex.Message, containerId)
        End Try
    End Function

    ''' <summary>
    ''' تحويل schoolDashBoard إلى تصميم حديث
    ''' Convert schoolDashBoard to modern design
    ''' </summary>
    Public Shared Function ConvertSchoolDashboardToModern(ByVal page As Page, ByVal containerId As String) As String
        Try
            Return GenerateModernSchoolDashboard(containerId)
        Catch ex As Exception
            Return GenerateErrorMessage("خطأ في تحويل لوحة المدرسة", ex.Message, containerId)
        End Try
    End Function

    ''' <summary>
    ''' تحويل ajarDashBoard إلى تصميم حديث
    ''' Convert ajarDashBoard to modern design
    ''' </summary>
    Public Shared Function ConvertAjarDashboardToModern(ByVal page As Page, ByVal containerId As String) As String
        Try
            Return GenerateModernAjarDashboard(containerId)
        Catch ex As Exception
            Return GenerateErrorMessage("خطأ في تحويل لوحة أجار", ex.Message, containerId)
        End Try
    End Function

    ''' <summary>
    ''' تحويل أي Telerik control عام إلى تصميم حديث
    ''' Convert any generic Telerik control to modern design
    ''' </summary>
    Public Shared Function ConvertGenericTelerikToModern(ByVal controlType As String, ByVal page As Page, ByVal containerId As String) As String
        Try
            Return GenerateGenericModernControl(controlType, containerId)
        Catch ex As Exception
            Return GenerateErrorMessage("خطأ في تحويل " & controlType, ex.Message, containerId)
        End Try
    End Function

    ''' <summary>
    ''' إنشاء وحدات ERP حديثة
    ''' Generate modern ERP modules
    ''' </summary>
    Private Shared Function GenerateModernErpModules(ByVal containerId As String) As String
        Dim html As New StringBuilder()
        
        html.AppendLine("<div id='" & containerId & "' class='modern-erp-modules converted-control'>")
        html.AppendLine("  <div class='modules-header'>")
        html.AppendLine("    <h2 class='modules-title'>")
        html.AppendLine("      <i class='fas fa-cube'></i>")
        html.AppendLine("      <span>نظام إدارة الموارد المؤسسية</span>")
        html.AppendLine("    </h2>")
        html.AppendLine("    <p class='modules-subtitle'>اختر الوحدة التي تريد العمل بها</p>")
        html.AppendLine("  </div>")
        html.AppendLine("  <div class='modules-grid'>")
        
        ' إضافة وحدات افتراضية
        Dim erpModules() As String = {
            "إدارة المالية|إدارة الحسابات والمعاملات المالية|fas fa-money-bill-wave|~/Pages/Finance/Default.aspx",
            "إدارة الموارد البشرية|إدارة الموظفين والرواتب|fas fa-users|~/Pages/HR/Default.aspx",
            "إدارة المخازن|إدارة المخزون والمواد|fas fa-warehouse|~/Pages/Inventory/Default.aspx",
            "إدارة المبيعات|إدارة العملاء والفواتير|fas fa-shopping-cart|~/Pages/Sales/Default.aspx",
            "إدارة المشتريات|إدارة الموردين وطلبات الشراء|fas fa-shopping-bag|~/Pages/Purchasing/Default.aspx",
            "التقارير والتحليلات|تقارير شاملة وتحليلات|fas fa-chart-bar|~/Pages/Reports/Default.aspx"
        }
        
        For Each moduleData As String In erpModules
            Dim parts() As String = moduleData.Split("|"c)
            html.AppendLine(GenerateERPModuleCard(parts(0), parts(1), parts(2), parts(3)))
        Next
        
        html.AppendLine("  </div>")
        html.AppendLine("</div>")
        html.AppendLine(GetERPModulesStyles())
        
        Return html.ToString()
    End Function

    ''' <summary>
    ''' إنشاء لوحة المدرسة الحديثة
    ''' Generate modern school dashboard
    ''' </summary>
    Private Shared Function GenerateModernSchoolDashboard(ByVal containerId As String) As String
        Dim html As New StringBuilder()
        
        html.AppendLine("<div id='" & containerId & "' class='modern-school-dashboard converted-control'>")
        html.AppendLine("  <div class='dashboard-header'>")
        html.AppendLine("    <div class='header-content'>")
        html.AppendLine("      <div class='header-icon'>")
        html.AppendLine("        <i class='fas fa-graduation-cap'></i>")
        html.AppendLine("      </div>")
        html.AppendLine("      <div class='header-text'>")
        html.AppendLine("        <h1 class='dashboard-title'>نظام إدارة المدرسة الذكي</h1>")
        html.AppendLine("        <p class='dashboard-subtitle'>لوحة التحكم الرئيسية</p>")
        html.AppendLine("      </div>")
        html.AppendLine("    </div>")
        html.AppendLine("  </div>")
        html.AppendLine("  <div class='modules-grid'>")
        
        ' إضافة وحدات المدرسة
        Dim schoolModules() As String = {
            "إدارة الطلاب|تسجيل وإدارة بيانات الطلاب|fas fa-users|~/Pages/Students/Default.aspx",
            "إدارة المعلمين|إدارة بيانات المعلمين|fas fa-chalkboard-teacher|~/Pages/Teachers/Default.aspx",
            "الجداول الدراسية|إنشاء وإدارة الجداول|fas fa-calendar-alt|~/Pages/Schedule/Default.aspx",
            "الحضور والغياب|تسجيل ومتابعة الحضور|fas fa-clipboard-list|~/Pages/Attendance/Default.aspx",
            "الدرجات والامتحانات|إدارة الامتحانات والدرجات|fas fa-trophy|~/Pages/Grades/Default.aspx",
            "التقارير|تقارير شاملة عن الأداء|fas fa-chart-bar|~/Pages/Reports/Default.aspx"
        }
        
        For Each moduleData As String In schoolModules
            Dim parts() As String = moduleData.Split("|"c)
            html.AppendLine(GenerateSchoolModuleCard(parts(0), parts(1), parts(2), parts(3)))
        Next
        
        html.AppendLine("  </div>")
        html.AppendLine("</div>")
        html.AppendLine(GetSchoolDashboardStyles())
        
        Return html.ToString()
    End Function

    ''' <summary>
    ''' إنشاء لوحة أجار الحديثة
    ''' Generate modern ajar dashboard
    ''' </summary>
    Private Shared Function GenerateModernAjarDashboard(ByVal containerId As String) As String
        Dim html As New StringBuilder()
        
        html.AppendLine("<div id='" & containerId & "' class='modern-ajar-dashboard converted-control'>")
        html.AppendLine("  <div class='dashboard-header'>")
        html.AppendLine("    <div class='header-content'>")
        html.AppendLine("      <div class='header-icon'>")
        html.AppendLine("        <i class='fas fa-building'></i>")
        html.AppendLine("      </div>")
        html.AppendLine("      <div class='header-text'>")
        html.AppendLine("        <h1 class='dashboard-title'>لوحة تحكم أجار</h1>")
        html.AppendLine("        <p class='dashboard-subtitle'>نظام إدارة العقارات والإيجارات</p>")
        html.AppendLine("      </div>")
        html.AppendLine("    </div>")
        html.AppendLine("  </div>")
        html.AppendLine("  <div class='properties-grid'>")
        
        ' إضافة وحدات العقارات
        Dim propertyModules() As String = {
            "إدارة العقارات|تسجيل وإدارة بيانات العقارات|fas fa-building|~/Pages/Properties/Default.aspx",
            "إدارة المستأجرين|إدارة بيانات المستأجرين|fas fa-users|~/Pages/Tenants/Default.aspx",
            "عقود الإيجار|إنشاء وإدارة عقود الإيجار|fas fa-file-contract|~/Pages/Contracts/Default.aspx",
            "إدارة المدفوعات|تحصيل الإيجارات|fas fa-credit-card|~/Pages/Payments/Default.aspx",
            "الصيانة والإصلاحات|إدارة طلبات الصيانة|fas fa-wrench|~/Pages/Maintenance/Default.aspx",
            "التقارير المالية|تقارير الإيرادات والربحية|fas fa-chart-bar|~/Pages/Reports/Default.aspx"
        }
        
        For Each moduleData As String In propertyModules
            Dim parts() As String = moduleData.Split("|"c)
            html.AppendLine(GeneratePropertyModuleCard(parts(0), parts(1), parts(2), parts(3)))
        Next
        
        html.AppendLine("  </div>")
        html.AppendLine("</div>")
        html.AppendLine(GetAjarDashboardStyles())
        
        Return html.ToString()
    End Function

    ''' <summary>
    ''' إنشاء كنترول عام حديث
    ''' Generate generic modern control
    ''' </summary>
    Private Shared Function GenerateGenericModernControl(ByVal controlType As String, ByVal containerId As String) As String
        Dim html As New StringBuilder()
        
        html.AppendLine("<div id='" & containerId & "' class='modern-generic-control converted-control'>")
        html.AppendLine("  <div class='generic-header'>")
        html.AppendLine("    <div class='header-icon'>")
        html.AppendLine("      <i class='fas fa-cogs'></i>")
        html.AppendLine("    </div>")
        html.AppendLine("    <h2 class='generic-title'>")
        html.AppendLine("      تم تحويل " & HttpUtility.HtmlEncode(controlType) & " إلى التصميم الحديث")
        html.AppendLine("    </h2>")
        html.AppendLine("    <p class='generic-subtitle'>")
        html.AppendLine("      هذا الكنترول تم تحويله تلقائياً من Telerik إلى تصميم حديث")
        html.AppendLine("    </p>")
        html.AppendLine("  </div>")
        html.AppendLine("  <div class='generic-content'>")
        html.AppendLine("    <div class='conversion-info'>")
        html.AppendLine("      <i class='fas fa-check-circle'></i>")
        html.AppendLine("      <span>تم التحويل بنجاح</span>")
        html.AppendLine("    </div>")
        html.AppendLine("  </div>")
        html.AppendLine("</div>")
        html.AppendLine(GetGenericControlStyles())
        
        Return html.ToString()
    End Function

    ''' <summary>
    ''' إنشاء كارت وحدة ERP
    ''' Generate ERP module card
    ''' </summary>
    Private Shared Function GenerateERPModuleCard(ByVal title As String, ByVal description As String, ByVal icon As String, ByVal url As String) As String
        Return "<div class='module-card' data-url='" & url & "'>" & vbCrLf & _
               "  <div class='module-icon'>" & vbCrLf & _
               "    <i class='" & icon & "'></i>" & vbCrLf & _
               "  </div>" & vbCrLf & _
               "  <h3 class='module-title'>" & HttpUtility.HtmlEncode(title) & "</h3>" & vbCrLf & _
               "  <p class='module-description'>" & HttpUtility.HtmlEncode(description) & "</p>" & vbCrLf & _
               "  <div class='module-arrow'>" & vbCrLf & _
               "    <i class='fas fa-arrow-left'></i>" & vbCrLf & _
               "  </div>" & vbCrLf & _
               "</div>"
    End Function

    ''' <summary>
    ''' إنشاء كارت وحدة المدرسة
    ''' Generate school module card
    ''' </summary>
    Private Shared Function GenerateSchoolModuleCard(ByVal title As String, ByVal description As String, ByVal icon As String, ByVal url As String) As String
        Return "<div class='module-card' data-url='" & url & "'>" & vbCrLf & _
               "  <div class='module-icon'>" & vbCrLf & _
               "    <i class='" & icon & "'></i>" & vbCrLf & _
               "  </div>" & vbCrLf & _
               "  <h3 class='module-title'>" & HttpUtility.HtmlEncode(title) & "</h3>" & vbCrLf & _
               "  <p class='module-description'>" & HttpUtility.HtmlEncode(description) & "</p>" & vbCrLf & _
               "  <div class='module-badge'>" & vbCrLf & _
               "    <i class='fas fa-graduation-cap'></i>" & vbCrLf & _
               "  </div>" & vbCrLf & _
               "</div>"
    End Function

    ''' <summary>
    ''' إنشاء كارت وحدة العقارات
    ''' Generate property module card
    ''' </summary>
    Private Shared Function GeneratePropertyModuleCard(ByVal title As String, ByVal description As String, ByVal icon As String, ByVal url As String) As String
        Return "<div class='property-card' data-url='" & url & "'>" & vbCrLf & _
               "  <div class='property-icon'>" & vbCrLf & _
               "    <i class='" & icon & "'></i>" & vbCrLf & _
               "  </div>" & vbCrLf & _
               "  <h3 class='property-title'>" & HttpUtility.HtmlEncode(title) & "</h3>" & vbCrLf & _
               "  <p class='property-description'>" & HttpUtility.HtmlEncode(description) & "</p>" & vbCrLf & _
               "  <div class='property-badge'>" & vbCrLf & _
               "    <i class='fas fa-building'></i>" & vbCrLf & _
               "  </div>" & vbCrLf & _
               "</div>"
    End Function

    ''' <summary>
    ''' الحصول على أنماط وحدات ERP
    ''' Get ERP modules styles
    ''' </summary>
    Private Shared Function GetERPModulesStyles() As String
        Return "<style>" & vbCrLf & _
               ".modern-erp-modules {" & vbCrLf & _
               "  max-width: 1200px;" & vbCrLf & _
               "  margin: 0 auto;" & vbCrLf & _
               "  padding: 2rem;" & vbCrLf & _
               "  font-family: 'Cairo', sans-serif;" & vbCrLf & _
               "  direction: rtl;" & vbCrLf & _
               "}" & vbCrLf & _
               ".modules-header {" & vbCrLf & _
               "  text-align: center;" & vbCrLf & _
               "  margin-bottom: 3rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".modules-title {" & vbCrLf & _
               "  display: flex;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "  justify-content: center;" & vbCrLf & _
               "  gap: 1rem;" & vbCrLf & _
               "  font-size: 2.5rem;" & vbCrLf & _
               "  font-weight: 700;" & vbCrLf & _
               "  background: linear-gradient(135deg, #2563eb, #3b82f6);" & vbCrLf & _
               "  -webkit-background-clip: text;" & vbCrLf & _
               "  -webkit-text-fill-color: transparent;" & vbCrLf & _
               "  margin-bottom: 0.5rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".modules-subtitle {" & vbCrLf & _
               "  font-size: 1.2rem;" & vbCrLf & _
               "  color: #64748b;" & vbCrLf & _
               "}" & vbCrLf & _
               ".modules-grid {" & vbCrLf & _
               "  display: grid;" & vbCrLf & _
               "  grid-template-columns: repeat(auto-fit, minmax(350px, 1fr));" & vbCrLf & _
               "  gap: 2rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".module-card {" & vbCrLf & _
               "  background: linear-gradient(135deg, rgba(255,255,255,0.9), rgba(255,255,255,0.7));" & vbCrLf & _
               "  backdrop-filter: blur(20px);" & vbCrLf & _
               "  border: 1px solid rgba(37,99,235,0.1);" & vbCrLf & _
               "  border-radius: 20px;" & vbCrLf & _
               "  padding: 2rem;" & vbCrLf & _
               "  text-align: center;" & vbCrLf & _
               "  transition: all 0.4s ease;" & vbCrLf & _
               "  cursor: pointer;" & vbCrLf & _
               "  position: relative;" & vbCrLf & _
               "  overflow: hidden;" & vbCrLf & _
               "}" & vbCrLf & _
               ".module-card:hover {" & vbCrLf & _
               "  transform: translateY(-8px) scale(1.02);" & vbCrLf & _
               "  box-shadow: 0 20px 40px rgba(37,99,235,0.2);" & vbCrLf & _
               "}" & vbCrLf & _
               ".module-icon {" & vbCrLf & _
               "  width: 80px;" & vbCrLf & _
               "  height: 80px;" & vbCrLf & _
               "  background: linear-gradient(135deg, #2563eb, #3b82f6);" & vbCrLf & _
               "  border-radius: 20px;" & vbCrLf & _
               "  display: flex;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "  justify-content: center;" & vbCrLf & _
               "  margin: 0 auto 1.5rem;" & vbCrLf & _
               "  color: white;" & vbCrLf & _
               "  font-size: 2rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".module-title {" & vbCrLf & _
               "  font-size: 1.5rem;" & vbCrLf & _
               "  font-weight: 600;" & vbCrLf & _
               "  color: #1e293b;" & vbCrLf & _
               "  margin-bottom: 1rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".module-description {" & vbCrLf & _
               "  color: #64748b;" & vbCrLf & _
               "  line-height: 1.6;" & vbCrLf & _
               "}" & vbCrLf & _
               ".module-arrow {" & vbCrLf & _
               "  position: absolute;" & vbCrLf & _
               "  top: 1rem;" & vbCrLf & _
               "  left: 1rem;" & vbCrLf & _
               "  opacity: 0;" & vbCrLf & _
               "  transition: opacity 0.3s ease;" & vbCrLf & _
               "  color: #2563eb;" & vbCrLf & _
               "}" & vbCrLf & _
               ".module-card:hover .module-arrow {" & vbCrLf & _
               "  opacity: 1;" & vbCrLf & _
               "}" & vbCrLf & _
               "@media (max-width: 768px) {" & vbCrLf & _
               "  .modules-grid { grid-template-columns: 1fr; }" & vbCrLf & _
               "  .modules-title { font-size: 2rem; }" & vbCrLf & _
               "}" & vbCrLf & _
               "</style>"
    End Function

    ''' <summary>
    ''' الحصول على أنماط لوحة المدرسة
    ''' Get school dashboard styles
    ''' </summary>
    Private Shared Function GetSchoolDashboardStyles() As String
        Return "<style>" & vbCrLf & _
               ".modern-school-dashboard {" & vbCrLf & _
               "  max-width: 1400px;" & vbCrLf & _
               "  margin: 0 auto;" & vbCrLf & _
               "  padding: 2rem;" & vbCrLf & _
               "  font-family: 'Cairo', sans-serif;" & vbCrLf & _
               "  direction: rtl;" & vbCrLf & _
               "}" & vbCrLf & _
               ".dashboard-header {" & vbCrLf & _
               "  background: linear-gradient(135deg, #2563eb, #3b82f6);" & vbCrLf & _
               "  border-radius: 24px;" & vbCrLf & _
               "  padding: 3rem;" & vbCrLf & _
               "  margin-bottom: 3rem;" & vbCrLf & _
               "  color: white;" & vbCrLf & _
               "}" & vbCrLf & _
               ".header-content {" & vbCrLf & _
               "  display: flex;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "  gap: 2rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".header-icon {" & vbCrLf & _
               "  width: 80px;" & vbCrLf & _
               "  height: 80px;" & vbCrLf & _
               "  background: rgba(255,255,255,0.2);" & vbCrLf & _
               "  border-radius: 20px;" & vbCrLf & _
               "  display: flex;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "  justify-content: center;" & vbCrLf & _
               "  font-size: 2.5rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".dashboard-title {" & vbCrLf & _
               "  font-size: 2.5rem;" & vbCrLf & _
               "  font-weight: 700;" & vbCrLf & _
               "  margin: 0;" & vbCrLf & _
               "}" & vbCrLf & _
               ".dashboard-subtitle {" & vbCrLf & _
               "  font-size: 1.2rem;" & vbCrLf & _
               "  opacity: 0.9;" & vbCrLf & _
               "  margin: 0.5rem 0 0 0;" & vbCrLf & _
               "}" & vbCrLf & _
               "</style>"
    End Function

    ''' <summary>
    ''' الحصول على أنماط لوحة أجار
    ''' Get ajar dashboard styles
    ''' </summary>
    Private Shared Function GetAjarDashboardStyles() As String
        Return "<style>" & vbCrLf & _
               ".modern-ajar-dashboard {" & vbCrLf & _
               "  max-width: 1400px;" & vbCrLf & _
               "  margin: 0 auto;" & vbCrLf & _
               "  padding: 2rem;" & vbCrLf & _
               "  font-family: 'Cairo', sans-serif;" & vbCrLf & _
               "  direction: rtl;" & vbCrLf & _
               "}" & vbCrLf & _
               ".dashboard-header {" & vbCrLf & _
               "  background: linear-gradient(135deg, #1e40af, #3b82f6);" & vbCrLf & _
               "  border-radius: 24px;" & vbCrLf & _
               "  padding: 3rem;" & vbCrLf & _
               "  margin-bottom: 3rem;" & vbCrLf & _
               "  color: white;" & vbCrLf & _
               "}" & vbCrLf & _
               ".properties-grid {" & vbCrLf & _
               "  display: grid;" & vbCrLf & _
               "  grid-template-columns: repeat(auto-fit, minmax(320px, 1fr));" & vbCrLf & _
               "  gap: 2rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".property-card {" & vbCrLf & _
               "  background: white;" & vbCrLf & _
               "  border-radius: 20px;" & vbCrLf & _
               "  padding: 2.5rem;" & vbCrLf & _
               "  text-align: center;" & vbCrLf & _
               "  transition: all 0.4s ease;" & vbCrLf & _
               "  cursor: pointer;" & vbCrLf & _
               "  box-shadow: 0 8px 24px rgba(0,0,0,0.1);" & vbCrLf & _
               "}" & vbCrLf & _
               ".property-card:hover {" & vbCrLf & _
               "  transform: translateY(-10px) scale(1.02);" & vbCrLf & _
               "  box-shadow: 0 20px 40px rgba(124,58,237,0.15);" & vbCrLf & _
               "}" & vbCrLf & _
               ".property-icon {" & vbCrLf & _
               "  width: 80px;" & vbCrLf & _
               "  height: 80px;" & vbCrLf & _
               "  background: linear-gradient(135deg, #7c3aed, #a855f7);" & vbCrLf & _
               "  border-radius: 20px;" & vbCrLf & _
               "  display: flex;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "  justify-content: center;" & vbCrLf & _
               "  margin: 0 auto 1.5rem;" & vbCrLf & _
               "  color: white;" & vbCrLf & _
               "  font-size: 2rem;" & vbCrLf & _
               "}" & vbCrLf & _
               "</style>"
    End Function

    ''' <summary>
    ''' الحصول على أنماط الكنترول العام
    ''' Get generic control styles
    ''' </summary>
    Private Shared Function GetGenericControlStyles() As String
        Return "<style>" & vbCrLf & _
               ".modern-generic-control {" & vbCrLf & _
               "  max-width: 800px;" & vbCrLf & _
               "  margin: 0 auto;" & vbCrLf & _
               "  padding: 2rem;" & vbCrLf & _
               "  font-family: 'Cairo', sans-serif;" & vbCrLf & _
               "  direction: rtl;" & vbCrLf & _
               "  text-align: center;" & vbCrLf & _
               "}" & vbCrLf & _
               ".generic-header {" & vbCrLf & _
               "  background: linear-gradient(135deg, #059669, #10b981);" & vbCrLf & _
               "  border-radius: 20px;" & vbCrLf & _
               "  padding: 2rem;" & vbCrLf & _
               "  color: white;" & vbCrLf & _
               "  margin-bottom: 2rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".header-icon {" & vbCrLf & _
               "  font-size: 3rem;" & vbCrLf & _
               "  margin-bottom: 1rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".generic-title {" & vbCrLf & _
               "  font-size: 1.8rem;" & vbCrLf & _
               "  font-weight: 600;" & vbCrLf & _
               "  margin-bottom: 1rem;" & vbCrLf & _
               "}" & vbCrLf & _
               ".conversion-info {" & vbCrLf & _
               "  display: flex;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "  justify-content: center;" & vbCrLf & _
               "  gap: 1rem;" & vbCrLf & _
               "  background: rgba(16, 185, 129, 0.1);" & vbCrLf & _
               "  border: 1px solid rgba(16, 185, 129, 0.3);" & vbCrLf & _
               "  border-radius: 12px;" & vbCrLf & _
               "  padding: 1.5rem;" & vbCrLf & _
               "  color: #059669;" & vbCrLf & _
               "  font-weight: 600;" & vbCrLf & _
               "}" & vbCrLf & _
               "</style>"
    End Function

    ''' <summary>
    ''' إنشاء رسالة خطأ مع تصميم حديث
    ''' Generate error message with modern design
    ''' </summary>
    Private Shared Function GenerateErrorMessage(ByVal title As String, ByVal errorDetails As String, ByVal containerId As String) As String
        Return "<div id='" & containerId & "' class='modern-error-container'>" & vbCrLf & _
               "  <div class='error-icon'>" & vbCrLf & _
               "    <i class='fas fa-exclamation-triangle'></i>" & vbCrLf & _
               "  </div>" & vbCrLf & _
               "  <div class='error-content'>" & vbCrLf & _
               "    <h3 class='error-title'>" & title & "</h3>" & vbCrLf & _
               "    <p class='error-message'>" & errorDetails & "</p>" & vbCrLf & _
               "    <button class='retry-btn' onclick='location.reload()'>" & vbCrLf & _
               "      <i class='fas fa-redo'></i>" & vbCrLf & _
               "      إعادة المحاولة" & vbCrLf & _
               "    </button>" & vbCrLf & _
               "  </div>" & vbCrLf & _
               "</div>" & vbCrLf & _
               "<style>" & vbCrLf & _
               ".modern-error-container {" & vbCrLf & _
               "  display: flex;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "  gap: 1.5rem;" & vbCrLf & _
               "  padding: 2rem;" & vbCrLf & _
               "  background: linear-gradient(135deg, #fef2f2, #fee2e2);" & vbCrLf & _
               "  border: 2px solid #fecaca;" & vbCrLf & _
               "  border-radius: 16px;" & vbCrLf & _
               "  margin: 1rem 0;" & vbCrLf & _
               "  box-shadow: 0 4px 12px rgba(239, 68, 68, 0.2);" & vbCrLf & _
               "  direction: rtl;" & vbCrLf & _
               "  font-family: 'Cairo', 'Segoe UI', sans-serif;" & vbCrLf & _
               "}" & vbCrLf & _
               ".error-icon {" & vbCrLf & _
               "  width: 60px;" & vbCrLf & _
               "  height: 60px;" & vbCrLf & _
               "  background: linear-gradient(135deg, #ef4444, #dc2626);" & vbCrLf & _
               "  border-radius: 50%;" & vbCrLf & _
               "  display: flex;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "  justify-content: center;" & vbCrLf & _
               "  color: white;" & vbCrLf & _
               "  font-size: 1.5rem;" & vbCrLf & _
               "  flex-shrink: 0;" & vbCrLf & _
               "}" & vbCrLf & _
               ".error-content {" & vbCrLf & _
               "  flex-grow: 1;" & vbCrLf & _
               "}" & vbCrLf & _
               ".error-title {" & vbCrLf & _
               "  color: #dc2626;" & vbCrLf & _
               "  font-size: 1.5rem;" & vbCrLf & _
               "  font-weight: 600;" & vbCrLf & _
               "  margin: 0 0 0.5rem 0;" & vbCrLf & _
               "}" & vbCrLf & _
               ".error-message {" & vbCrLf & _
               "  color: #991b1b;" & vbCrLf & _
               "  margin: 0 0 1rem 0;" & vbCrLf & _
               "  line-height: 1.6;" & vbCrLf & _
               "}" & vbCrLf & _
               ".retry-btn {" & vbCrLf & _
               "  display: inline-flex;" & vbCrLf & _
               "  align-items: center;" & vbCrLf & _
               "  gap: 0.5rem;" & vbCrLf & _
               "  padding: 0.75rem 1.5rem;" & vbCrLf & _
               "  background: linear-gradient(135deg, #ef4444, #dc2626);" & vbCrLf & _
               "  color: white;" & vbCrLf & _
               "  border: none;" & vbCrLf & _
               "  border-radius: 8px;" & vbCrLf & _
               "  font-weight: 600;" & vbCrLf & _
               "  cursor: pointer;" & vbCrLf & _
               "  transition: all 0.3s ease;" & vbCrLf & _
               "}" & vbCrLf & _
               ".retry-btn:hover {" & vbCrLf & _
               "  transform: translateY(-2px);" & vbCrLf & _
               "  box-shadow: 0 4px 12px rgba(239, 68, 68, 0.3);" & vbCrLf & _
               "}" & vbCrLf & _
               "@media (max-width: 768px) {" & vbCrLf & _
               "  .modern-error-container {" & vbCrLf & _
               "    flex-direction: column;" & vbCrLf & _
               "    text-align: center;" & vbCrLf & _
               "    padding: 1.5rem;" & vbCrLf & _
               "  }" & vbCrLf & _
               "}" & vbCrLf & _
               "</style>"
    End Function

End Class

''' <summary>
''' معلومات الوحدة المتطورة
''' Advanced system module information
''' </summary>
Public Class SystemModuleInfo
    Public Property Id As String
    Public Property Title As String
    Public Property Description As String
    Public Property Icon As String
    Public Property Color As String
    Public Property Gradient As String
    Public Property Url As String
    Public Property Badge As String
    Public Property Stats As String
End Class
