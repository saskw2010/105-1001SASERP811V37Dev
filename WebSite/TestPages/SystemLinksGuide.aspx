<%@ Page Title="دليل روابط النظام - System Links Guide" Language="VB" MasterPageFile="~/UniversalNavMaster.master" AutoEventWireup="false" CodeFile="SystemLinksGuide.aspx.vb" Inherits="SystemLinksGuide" %>

<asp:Content ID="TitleContent" ContentPlaceHolderID="TitleContentPlaceHolder" runat="server">
    دليل روابط النظام الشامل - SASERP V37
</asp:Content>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
    <style>
        .links-section {
            background: white;
            border-radius: 10px;
            padding: 25px;
            margin-bottom: 20px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
            border-left: 5px solid #3498db;
        }
        
        .links-section h3 {
            color: #2c3e50;
            margin-bottom: 15px;
            font-size: 1.4em;
            display: flex;
            align-items: center;
            gap: 10px;
        }
        
        .link-button {
            display: inline-block;
            background: linear-gradient(135deg, #3498db, #2980b9);
            color: white;
            text-decoration: none;
            padding: 10px 15px;
            margin: 5px;
            border-radius: 8px;
            font-size: 13px;
            transition: all 0.3s;
            border: none;
            cursor: pointer;
            box-shadow: 0 2px 4px rgba(0,0,0,0.2);
        }
        
        .link-button:hover {
            background: linear-gradient(135deg, #2980b9, #1a5f7a);
            transform: translateY(-2px);
            box-shadow: 0 4px 8px rgba(0,0,0,0.3);
            color: white;
            text-decoration: none;
        }
        
        .link-button.financial { background: linear-gradient(135deg, #27ae60, #229954); }
        .link-button.hr { background: linear-gradient(135deg, #e74c3c, #c0392b); }
        .link-button.stock { background: linear-gradient(135deg, #f39c12, #e67e22); }
        .link-button.sales { background: linear-gradient(135deg, #9b59b6, #8e44ad); }
        .link-button.purchase { background: linear-gradient(135deg, #34495e, #2c3e50); }
        .link-button.admin { background: linear-gradient(135deg, #e67e22, #d35400); }
        .link-button.test { background: linear-gradient(135deg, #16a085, #138d75); }
        
        .code-example {
            background: #2c3e50;
            color: #ecf0f1;
            padding: 15px;
            border-radius: 8px;
            font-family: 'Courier New', monospace;
            margin: 10px 0;
            overflow-x: auto;
            font-size: 12px;
            direction: ltr;
            text-align: left;
        }
        
        .quick-demo {
            background: #f8f9fa;
            padding: 20px;
            border-radius: 8px;
            border: 2px dashed #3498db;
            text-align: center;
            margin: 20px 0;
        }
        
        .demo-button {
            background: #3498db;
            color: white;
            border: none;
            padding: 12px 20px;
            margin: 5px;
            border-radius: 6px;
            cursor: pointer;
            transition: all 0.3s;
        }
        
        .demo-button:hover {
            background: #2980b9;
            transform: scale(1.05);
        }
        
        .search-box {
            width: 100%;
            padding: 12px;
            border: 2px solid #bdc3c7;
            border-radius: 8px;
            font-size: 14px;
            margin-bottom: 20px;
        }
        
        .search-box:focus {
            outline: none;
            border-color: #3498db;
        }
        
        .hidden {
            display: none;
        }
    </style>
</asp:Content>

<asp:Content ID="PageHeaderContent" ContentPlaceHolderID="PageHeaderPlaceHolder" runat="server">
    <div class="page-header bg-gradient-primary text-white p-4 mb-4">
        <div class="container-fluid">
            <h1 class="h2 mb-0">
                <i class="fas fa-external-link-alt"></i>
                دليل روابط النظام الشامل
            </h1>
            <p class="mb-0">جميع روابط صفحات SASERP V37 منظمة حسب الوحدات مع أمثلة Vue.js</p>
        </div>
    </div>
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    
    <!-- البحث السريع -->
    <div class="row mb-4">
        <div class="col-lg-8 mx-auto">
            <input type="text" id="searchLinks" class="search-box" placeholder="🔍 ابحث في الروابط..." onkeyup="searchLinks(this.value)">
        </div>
    </div>

    <!-- عرض توضيحي سريع -->
    <div class="quick-demo">
        <h4><i class="fas fa-rocket text-primary"></i> تجربة سريعة للروابط</h4>
        <p>اضغط على الأزرار التالية لاختبار نظام الروابط:</p>
        <button class="demo-button" onclick="mainmaster.pages.home()">الرئيسية</button>
        <button class="demo-button" onclick="mainmaster.pages.test.navigation()">مثال التنقل</button>
        <button class="demo-button" onclick="mainmaster.pages.financial.accounts()">خطة الحسابات</button>
        <button class="demo-button" onclick="mainmaster.pages.quick.newInvoice()">فاتورة جديدة</button>
    </div>

    <div class="row">
        <div class="col-lg-12">
            
            <!-- الصفحات الرئيسية -->
            <div class="links-section" data-category="main">
                <h3><i class="fas fa-home text-primary"></i> الصفحات الرئيسية</h3>
                <a href="#" class="link-button" onclick="mainmaster.pages.home(); return false;">الرئيسية</a>
                <a href="#" class="link-button" onclick="mainmaster.pages.dashboard(); return false;">لوحة التحكم</a>
                <a href="#" class="link-button" onclick="mainmaster.pages.profile(); return false;">الملف الشخصي</a>
                <a href="#" class="link-button" onclick="mainmaster.pages.settings(); return false;">الإعدادات</a>
                
                <div class="code-example">
// استخدام الروابط الرئيسية<br/>
mainmaster.pages.home();        // الذهاب للرئيسية<br/>
mainmaster.pages.dashboard();   // لوحة التحكم<br/>
mainmaster.pages.profile();     // الملف الشخصي<br/>
mainmaster.pages.settings();    // الإعدادات
                </div>
            </div>

            <!-- المحاسبة المالية -->
            <div class="links-section" data-category="financial">
                <h3><i class="fas fa-calculator text-success"></i> المحاسبة المالية</h3>
                <a href="#" class="link-button financial" onclick="mainmaster.pages.financial.main(); return false;">المحاسبة الرئيسية</a>
                <a href="#" class="link-button financial" onclick="mainmaster.pages.financial.accounts(); return false;">خطة الحسابات</a>
                <a href="#" class="link-button financial" onclick="mainmaster.pages.financial.gl(); return false;">الأستاذ العام</a>
                <a href="#" class="link-button financial" onclick="mainmaster.pages.financial.transactions(); return false;">القيود</a>
                <a href="#" class="link-button financial" onclick="mainmaster.pages.financial.vouchers(); return false;">السندات</a>
                <a href="#" class="link-button financial" onclick="mainmaster.pages.financial.trialBalance(); return false;">ميزان المراجعة</a>
                <a href="#" class="link-button financial" onclick="mainmaster.pages.financial.cashflow(); return false;">التدفق النقدي</a>
                <a href="#" class="link-button financial" onclick="mainmaster.pages.financial.reports(); return false;">تقارير مالية</a>
                
                <div class="code-example">
// استخدام روابط المحاسبة<br/>
mainmaster.pages.financial.main();          // الصفحة الرئيسية<br/>
mainmaster.pages.financial.accounts();      // خطة الحسابات<br/>
mainmaster.pages.financial.transactions();  // القيود<br/>
mainmaster.pages.financial.reports();       // التقارير
                </div>
            </div>

            <!-- الموارد البشرية -->
            <div class="links-section" data-category="hr">
                <h3><i class="fas fa-users text-danger"></i> الموارد البشرية</h3>
                <a href="#" class="link-button hr" onclick="mainmaster.pages.hr.main(); return false;">الموارد البشرية</a>
                <a href="#" class="link-button hr" onclick="mainmaster.pages.hr.employees(); return false;">الموظفون</a>
                <a href="#" class="link-button hr" onclick="mainmaster.pages.hr.payroll(); return false;">كشوف المرتبات</a>
                <a href="#" class="link-button hr" onclick="mainmaster.pages.hr.attendance(); return false;">الحضور والانصراف</a>
                <a href="#" class="link-button hr" onclick="mainmaster.pages.hr.leaves(); return false;">الإجازات</a>
                <a href="#" class="link-button hr" onclick="mainmaster.pages.hr.performance(); return false;">تقييم الأداء</a>
                
                <div class="code-example">
// استخدام روابط الموارد البشرية<br/>
mainmaster.pages.hr.employees();   // الموظفون<br/>
mainmaster.pages.hr.payroll();     // كشوف المرتبات<br/>
mainmaster.pages.hr.attendance();  // الحضور والانصراف<br/>
mainmaster.pages.hr.leaves();      // الإجازات
                </div>
            </div>

            <!-- إدارة المخزون -->
            <div class="links-section" data-category="stock">
                <h3><i class="fas fa-boxes text-warning"></i> إدارة المخزون</h3>
                <a href="#" class="link-button stock" onclick="mainmaster.pages.stock.main(); return false;">إدارة المخزون</a>
                <a href="#" class="link-button stock" onclick="mainmaster.pages.stock.items(); return false;">الأصناف</a>
                <a href="#" class="link-button stock" onclick="mainmaster.pages.stock.transactions(); return false;">حركة المخزون</a>
                <a href="#" class="link-button stock" onclick="mainmaster.pages.stock.reorder(); return false;">طلب إعادة الشراء</a>
                <a href="#" class="link-button stock" onclick="mainmaster.pages.stock.barcode(); return false;">الباركود</a>
                <a href="#" class="link-button stock" onclick="mainmaster.pages.stock.reports(); return false;">تقارير المخزون</a>
                
                <div class="code-example">
// استخدام روابط المخزون<br/>
mainmaster.pages.stock.items();        // الأصناف<br/>
mainmaster.pages.stock.transactions(); // حركة المخزون<br/>
mainmaster.pages.stock.reports();      // التقارير
                </div>
            </div>

            <!-- المبيعات -->
            <div class="links-section" data-category="sales">
                <h3><i class="fas fa-shopping-cart text-info"></i> المبيعات</h3>
                <a href="#" class="link-button sales" onclick="mainmaster.pages.sales.main(); return false;">المبيعات</a>
                <a href="#" class="link-button sales" onclick="mainmaster.pages.sales.invoices(); return false;">فواتير المبيعات</a>
                <a href="#" class="link-button sales" onclick="mainmaster.pages.sales.customers(); return false;">العملاء</a>
                <a href="#" class="link-button sales" onclick="mainmaster.pages.sales.pos(); return false;">نقطة البيع</a>
                <a href="#" class="link-button sales" onclick="mainmaster.pages.sales.reports(); return false;">تقارير المبيعات</a>
                
                <div class="code-example">
// استخدام روابط المبيعات<br/>
mainmaster.pages.sales.invoices();  // فواتير المبيعات<br/>
mainmaster.pages.sales.customers(); // العملاء<br/>
mainmaster.pages.sales.pos();       // نقطة البيع
                </div>
            </div>

            <!-- المشتريات -->
            <div class="links-section" data-category="purchase">
                <h3><i class="fas fa-truck text-secondary"></i> المشتريات</h3>
                <a href="#" class="link-button purchase" onclick="mainmaster.pages.purchase.main(); return false;">المشتريات</a>
                <a href="#" class="link-button purchase" onclick="mainmaster.pages.purchase.orders(); return false;">أوامر الشراء</a>
                <a href="#" class="link-button purchase" onclick="mainmaster.pages.purchase.suppliers(); return false;">الموردون</a>
                <a href="#" class="link-button purchase" onclick="mainmaster.pages.purchase.receiving(); return false;">الاستلام</a>
                <a href="#" class="link-button purchase" onclick="mainmaster.pages.purchase.reports(); return false;">تقارير المشتريات</a>
                
                <div class="code-example">
// استخدام روابط المشتريات<br/>
mainmaster.pages.purchase.orders();    // أوامر الشراء<br/>
mainmaster.pages.purchase.suppliers(); // الموردون<br/>
mainmaster.pages.purchase.receiving(); // الاستلام
                </div>
            </div>

            <!-- إدارة العملاء -->
            <div class="links-section" data-category="crm">
                <h3><i class="fas fa-handshake text-purple"></i> إدارة العملاء CRM</h3>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #6f42c1, #5a32a3);" onclick="mainmaster.pages.crm.main(); return false;">إدارة العملاء</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #6f42c1, #5a32a3);" onclick="mainmaster.pages.crm.leads(); return false;">العملاء المحتملون</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #6f42c1, #5a32a3);" onclick="mainmaster.pages.crm.opportunities(); return false;">الفرص</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #6f42c1, #5a32a3);" onclick="mainmaster.pages.crm.activities(); return false;">الأنشطة</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #6f42c1, #5a32a3);" onclick="mainmaster.pages.crm.campaigns(); return false;">الحملات</a>
            </div>

            <!-- التقارير -->
            <div class="links-section" data-category="reports">
                <h3><i class="fas fa-chart-bar text-success"></i> التقارير</h3>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #28a745, #20612c);" onclick="mainmaster.pages.reports.main(); return false;">التقارير الرئيسية</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #28a745, #20612c);" onclick="mainmaster.pages.reports.financial(); return false;">التقارير المالية</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #28a745, #20612c);" onclick="mainmaster.pages.reports.stock(); return false;">تقارير المخزون</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #28a745, #20612c);" onclick="mainmaster.pages.reports.sales(); return false;">تقارير المبيعات</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #28a745, #20612c);" onclick="mainmaster.pages.reports.hr(); return false;">تقارير الموارد البشرية</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #28a745, #20612c);" onclick="mainmaster.pages.reports.custom(); return false;">تقارير مخصصة</a>
            </div>

            <!-- الإدارة -->
            <div class="links-section" data-category="admin">
                <h3><i class="fas fa-cogs text-warning"></i> الإدارة</h3>
                <a href="#" class="link-button admin" onclick="mainmaster.pages.admin.main(); return false;">لوحة الإدارة</a>
                <a href="#" class="link-button admin" onclick="mainmaster.pages.admin.users(); return false;">المستخدمون</a>
                <a href="#" class="link-button admin" onclick="mainmaster.pages.admin.roles(); return false;">الأدوار</a>
                <a href="#" class="link-button admin" onclick="mainmaster.pages.admin.permissions(); return false;">الصلاحيات</a>
                <a href="#" class="link-button admin" onclick="mainmaster.pages.admin.backup(); return false;">النسخ الاحتياطي</a>
                <a href="#" class="link-button admin" onclick="mainmaster.pages.admin.settings(); return false;">إعدادات النظام</a>
                <a href="#" class="link-button admin" onclick="mainmaster.pages.admin.logs(); return false;">سجلات النظام</a>
                
                <div class="code-example">
// استخدام روابط الإدارة<br/>
mainmaster.pages.admin.users();       // المستخدمون<br/>
mainmaster.pages.admin.roles();       // الأدوار<br/>
mainmaster.pages.admin.permissions(); // الصلاحيات<br/>
mainmaster.pages.admin.settings();    // إعدادات النظام
                </div>
            </div>

            <!-- صفحات الاختبار -->
            <div class="links-section" data-category="test">
                <h3><i class="fas fa-flask text-info"></i> صفحات الاختبار والعرض</h3>
                <a href="#" class="link-button test" onclick="mainmaster.pages.test.main(); return false;">صفحات الاختبار</a>
                <a href="#" class="link-button test" onclick="mainmaster.pages.test.navigation(); return false;">مثال التنقل</a>
                <a href="#" class="link-button test" onclick="mainmaster.pages.test.dashboard(); return false;">مثال لوحة التحكم</a>
                <a href="#" class="link-button test" onclick="mainmaster.pages.test.forms(); return false;">مثال النماذج</a>
                <a href="#" class="link-button test" onclick="mainmaster.pages.test.charts(); return false;">مثال الرسوم البيانية</a>
                <a href="#" class="link-button test" onclick="mainmaster.pages.test.tables(); return false;">مثال الجداول</a>
            </div>

            <!-- الوصول السريع -->
            <div class="links-section" data-category="quick">
                <h3><i class="fas fa-bolt text-danger"></i> الوصول السريع</h3>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #dc3545, #a71e2a);" onclick="mainmaster.pages.quick.newInvoice(); return false;">فاتورة مبيعات جديدة</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #dc3545, #a71e2a);" onclick="mainmaster.pages.quick.newPurchase(); return false;">أمر شراء جديد</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #dc3545, #a71e2a);" onclick="mainmaster.pages.quick.newEmployee(); return false;">موظف جديد</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #dc3545, #a71e2a);" onclick="mainmaster.pages.quick.newCustomer(); return false;">عميل جديد</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #dc3545, #a71e2a);" onclick="mainmaster.pages.quick.newItem(); return false;">صنف جديد</a>
                <a href="#" class="link-button" style="background: linear-gradient(135deg, #dc3545, #a71e2a);" onclick="mainmaster.pages.quick.dailyReports(); return false;">التقارير اليومية</a>
                
                <div class="code-example">
// الوصول السريع للعمليات المهمة<br/>
mainmaster.pages.quick.newInvoice();   // فاتورة جديدة<br/>
mainmaster.pages.quick.newCustomer();  // عميل جديد<br/>
mainmaster.pages.quick.dailyReports(); // التقارير اليومية
                </div>
            </div>

        </div>
    </div>

    <!-- معلومات إضافية -->
    <div class="row mt-4">
        <div class="col-lg-12">
            <div class="alert alert-info">
                <h5><i class="fas fa-info-circle"></i> معلومات مهمة:</h5>
                <ul class="mb-0">
                    <li>جميع الروابط تعمل من خلال النظام الهرمي <code>mainmaster.pages.*.*</code></li>
                    <li>يمكن استخدام الروابط في أي مكان في JavaScript</li>
                    <li>النظام يدعم التنقل الآمن مع التحقق من الصلاحيات</li>
                    <li>جميع الروابط متوافقة مع Vue.js والنظام التقليدي</li>
                </ul>
            </div>
        </div>
    </div>

</asp:Content>

<asp:Content ID="PageFooterContent" ContentPlaceHolderID="PageFooterPlaceHolder" runat="server">
    <script type="text/javascript">
        // وظيفة البحث في الروابط
        function searchLinks(searchTerm) {
            const sections = document.querySelectorAll('.links-section');
            const term = searchTerm.toLowerCase().trim();
            
            sections.forEach(section => {
                const text = section.textContent.toLowerCase();
                const category = section.getAttribute('data-category');
                
                if (!term || text.includes(term) || category.includes(term)) {
                    section.classList.remove('hidden');
                } else {
                    section.classList.add('hidden');
                }
            });
            
            // عرض رسالة إذا لم توجد نتائج
            const visibleSections = document.querySelectorAll('.links-section:not(.hidden)');
            const noResults = document.getElementById('noResults');
            
            if (visibleSections.length === 0 && term) {
                if (!noResults) {
                    const msg = document.createElement('div');
                    msg.id = 'noResults';
                    msg.className = 'alert alert-warning text-center';
                    msg.innerHTML = '<i class="fas fa-search"></i> لم يتم العثور على نتائج للبحث: "' + searchTerm + '"';
                    document.querySelector('.row').appendChild(msg);
                }
            } else {
                if (noResults) {
                    noResults.remove();
                }
            }
        }

        // تحديث عداد الاستخدام
        let linkUsageCount = {};
        
        // مراقبة النقرات على الروابط
        document.addEventListener('click', function(e) {
            if (e.target.classList.contains('link-button')) {
                const linkText = e.target.textContent;
                linkUsageCount[linkText] = (linkUsageCount[linkText] || 0) + 1;
                
                console.log('🔗 تم النقر على:', linkText, '| عدد المرات:', linkUsageCount[linkText]);
                
                // حفظ في localStorage
                localStorage.setItem('linkUsageCount', JSON.stringify(linkUsageCount));
            }
        });

        // تحميل عداد الاستخدام من localStorage
        document.addEventListener('DOMContentLoaded', function() {
            const saved = localStorage.getItem('linkUsageCount');
            if (saved) {
                linkUsageCount = JSON.parse(saved);
            }
        });

        // إضافة اختصارات لوحة المفاتيح
        document.addEventListener('keydown', function(e) {
            // Ctrl + / للبحث
            if (e.ctrlKey && e.key === '/') {
                e.preventDefault();
                document.getElementById('searchLinks').focus();
            }
            
            // ESC لمسح البحث
            if (e.key === 'Escape') {
                const searchBox = document.getElementById('searchLinks');
                searchBox.value = '';
                searchLinks('');
                searchBox.blur();
            }
        });

        // تحديث العنوان عند البحث
        function updatePageTitle(searchTerm) {
            const originalTitle = 'دليل روابط النظام الشامل';
            if (searchTerm.trim()) {
                document.title = `${originalTitle} - البحث: ${searchTerm}`;
            } else {
                document.title = originalTitle;
            }
        }

        // ربط تحديث العنوان مع البحث
        document.getElementById('searchLinks').addEventListener('input', function(e) {
            updatePageTitle(e.target.value);
        });
    </script>
</asp:Content>
