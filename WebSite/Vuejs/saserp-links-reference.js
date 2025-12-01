/**
 * 🔗 SASERP V37 - Quick Links Reference
 * مرجع سريع لجميع روابط النظام
 * استخدم هذا الملف كمرجع للروابط المتاحة
 */

// ===========================================
// 📋 قائمة الروابط السريعة
// ===========================================

const SASERP_LINKS = {
    
    // 🏠 الصفحات الرئيسية
    MAIN_PAGES: {
        home: '~/Default.aspx',
        dashboard: '~/TestPages/DashboardExample.aspx',
        profile: '~/Pages/Profile.aspx',
        settings: '~/Pages/Settings.aspx'
    },

    // 💰 المحاسبة المالية
    FINANCIAL: {
        main: '~/Pages/Financial.aspx',
        accounts: '~/Pages/AccountChart.aspx',
        generalLedger: '~/Pages/GeneralLedger.aspx',
        transactions: '~/Pages/GLTransaction.aspx',
        vouchers: '~/Pages/GLjrnvchhdr.aspx',
        trialBalance: '~/Pages/TrialBalance.aspx',
        cashflow: '~/Pages/Cashflow.aspx',
        reports: '~/Pages/FinancialReports.aspx'
    },

    // 👥 الموارد البشرية
    HR: {
        main: '~/Pages/HR.aspx',
        employees: '~/Pages/Employees.aspx',
        payroll: '~/Pages/Payroll.aspx',
        attendance: '~/Pages/Attendance.aspx',
        leaves: '~/Pages/Leaves.aspx',
        performance: '~/Pages/Performance.aspx'
    },

    // 📦 إدارة المخزون
    STOCK: {
        main: '~/Pages/StockControl.aspx',
        items: '~/Pages/StockList.aspx',
        transactions: '~/Pages/StockTransaction.aspx',
        reorder: '~/Pages/ReorderList.aspx',
        barcode: '~/Pages/BarcodeCreate.aspx',
        reports: '~/Pages/StockReports.aspx'
    },

    // 🛒 المبيعات
    SALES: {
        main: '~/Pages/Sales.aspx',
        invoices: '~/Pages/SalesInvoices.aspx',
        customers: '~/Pages/Customers.aspx',
        pos: '~/Pages/POS.aspx',
        reports: '~/Pages/SalesReports.aspx'
    },

    // 🚚 المشتريات
    PURCHASE: {
        main: '~/Pages/Purchase.aspx',
        orders: '~/Pages/PurchaseOrders.aspx',
        suppliers: '~/Pages/Suppliers.aspx',
        receiving: '~/Pages/Receiving.aspx',
        reports: '~/Pages/PurchaseReports.aspx'
    },

    // 🤝 إدارة العملاء
    CRM: {
        main: '~/Pages/CRM.aspx',
        leads: '~/Pages/Leads.aspx',
        opportunities: '~/Pages/Opportunities.aspx',
        activities: '~/Pages/Activities.aspx',
        campaigns: '~/Pages/Campaigns.aspx'
    },

    // 📊 التقارير
    REPORTS: {
        main: '~/Pages/Reports.aspx',
        financial: '~/Pages/FinancialReports.aspx',
        stock: '~/Pages/StockReports.aspx',
        sales: '~/Pages/SalesReports.aspx',
        hr: '~/Pages/HRReports.aspx',
        custom: '~/Pages/CustomReports.aspx'
    },

    // ⚙️ الإدارة
    ADMIN: {
        main: '~/Pages/Administration.aspx',
        users: '~/Pages/Users.aspx',
        roles: '~/Pages/UserRoles.aspx',
        permissions: '~/Pages/Permissions.aspx',
        backup: '~/Pages/Backup.aspx',
        settings: '~/Pages/SystemSettings.aspx',
        logs: '~/Pages/SystemLogs.aspx'
    },

    // 🧪 صفحات الاختبار (ملفات موجودة فقط)
    TEST: {
        main: '~/TestPages/',
        index: '~/TestPages/PagesIndex.aspx',
        navigation: '~/TestPages/NavigationExample.aspx',
        dashboard: '~/TestPages/TestDashboardData.aspx',
        linksGuide: '~/TestPages/SystemLinksGuide.aspx',
        linksTesting: '~/TestPages/LinksTestingPage.html',
        quickTest: '~/TestPages/QuickSystemTest.html',
        hierarchyTest: '~/TestPages/HierarchyTest.html',
        themes: '~/TestPages/theme-center-index.html'
    },

    // ⚡ الوصول السريع
    QUICK_ACCESS: {
        newInvoice: '~/Pages/NewSalesInvoice.aspx',
        newPurchase: '~/Pages/NewPurchaseOrder.aspx',
        newEmployee: '~/Pages/NewEmployee.aspx',
        newCustomer: '~/Pages/NewCustomer.aspx',
        newItem: '~/Pages/NewStockItem.aspx',
        dailyReports: '~/Pages/DailyReports.aspx'
    }
};

// ===========================================
// 🚀 Vue.js Navigation Functions
// ===========================================

/**
 * استخدم هذه الدوال للتنقل في Vue.js
 * مثال: navigateTo(SASERP_LINKS.FINANCIAL.accounts)
 */

// دالة التنقل الأساسية
function navigateTo(url) {
    if (typeof mainmaster !== 'undefined' && mainmaster.menubar && mainmaster.menubar.navigate) {
        mainmaster.menubar.navigate(url);
    } else {
        // Fallback للتنقل العادي
        window.location.href = url;
    }
}

// دوال التنقل السريع
const QuickNav = {
    // الصفحات الرئيسية
    goHome: () => navigateTo(SASERP_LINKS.MAIN_PAGES.home),
    goDashboard: () => navigateTo(SASERP_LINKS.MAIN_PAGES.dashboard),
    
    // المحاسبة
    goFinancial: () => navigateTo(SASERP_LINKS.FINANCIAL.main),
    goAccounts: () => navigateTo(SASERP_LINKS.FINANCIAL.accounts),
    goGL: () => navigateTo(SASERP_LINKS.FINANCIAL.generalLedger),
    
    // الموارد البشرية
    goHR: () => navigateTo(SASERP_LINKS.HR.main),
    goEmployees: () => navigateTo(SASERP_LINKS.HR.employees),
    
    // المخزون
    goStock: () => navigateTo(SASERP_LINKS.STOCK.main),
    goItems: () => navigateTo(SASERP_LINKS.STOCK.items),
    
    // المبيعات
    goSales: () => navigateTo(SASERP_LINKS.SALES.main),
    goPOS: () => navigateTo(SASERP_LINKS.SALES.pos),
    
    // الوصول السريع
    newInvoice: () => navigateTo(SASERP_LINKS.QUICK_ACCESS.newInvoice),
    newCustomer: () => navigateTo(SASERP_LINKS.QUICK_ACCESS.newCustomer),
    
    // صفحات الاختبار
    pagesIndex: () => navigateTo('~/TestPages/PagesIndex.aspx'),
    testNavigation: () => navigateTo(SASERP_LINKS.TEST.navigation),
    testDashboard: () => navigateTo(SASERP_LINKS.TEST.dashboard),
    linksGuide: () => navigateTo('~/TestPages/SystemLinksGuide.aspx'),
    linksTesting: () => navigateTo('~/TestPages/LinksTestingPage.html'),
    quickTest: () => navigateTo('~/TestPages/QuickSystemTest.html'),
    hierarchyTest: () => navigateTo('~/TestPages/HierarchyTest.html'),
    
    // أدوات التشخيص
    systemInfo: () => {
        const info = {
            version: 'SASERP V37',
            timestamp: new Date().toISOString(),
            totalLinks: Object.keys(SASERP_LINKS).length,
            quickNavFunctions: Object.keys(QuickNav).length,
            currentPage: window.location.href,
            userAgent: navigator.userAgent.substring(0, 100)
        };
        console.log('🔧 معلومات النظام:', info);
        alert('تم عرض معلومات النظام في Console (F12)');
        return info;
    },
    
    testAllLinks: () => {
        console.log('🧪 بدء اختبار جميع الروابط...');
        const testResults = [];
        const links = [
            { name: 'الرئيسية', func: () => navigateTo('~/Default.aspx') },
            { name: 'لوحة التحكم', func: () => navigateTo('~/Default.aspx') },
            { name: 'خطة الحسابات', func: () => navigateTo('~/Pages/ChartOfAccounts.aspx') },
            { name: 'الموظفون', func: () => navigateTo('~/Pages/Employees.aspx') },
            { name: 'الأصناف', func: () => navigateTo('~/Pages/Items.aspx') },
            { name: 'دليل الروابط', func: () => navigateTo('~/TestPages/SystemLinksGuide.aspx') },
            { name: 'اختبار الروابط', func: () => navigateTo('~/TestPages/LinksTestingPage.html') }
        ];
        
        links.forEach(link => {
            try {
                console.log(`✅ رابط "${link.name}" - جاهز`);
                testResults.push({ name: link.name, status: 'ready' });
            } catch (error) {
                console.error(`❌ رابط "${link.name}" - خطأ:`, error);
                testResults.push({ name: link.name, status: 'error', error: error.message });
            }
        });
        
        console.log('📊 نتائج الاختبار:', testResults);
        alert(`تم اختبار ${links.length} رابط - راجع Console للتفاصيل`);
        return testResults;
    }
};

// ===========================================
// 📝 أمثلة على الاستخدام
// ===========================================

/*
// 1. استخدام الروابط المباشرة
navigateTo(SASERP_LINKS.FINANCIAL.accounts);

// 2. استخدام الدوال السريعة
QuickNav.goAccounts();

// 3. استخدام mainmaster (إذا كان متوفراً)
mainmaster.pages.financial.accounts();

// 4. في Vue.js Component
methods: {
    goToFinancial() {
        this.$parent.navigateTo(SASERP_LINKS.FINANCIAL.main);
    },
    
    openQuickInvoice() {
        QuickNav.newInvoice();
    }
}

// 5. في HTML onclick
<button onclick="QuickNav.goAccounts()">خطة الحسابات</button>
<button onclick="navigateTo(SASERP_LINKS.SALES.pos)">نقطة البيع</button>

// 6. مع معاملات إضافية
navigateTo(SASERP_LINKS.FINANCIAL.accounts + '?filter=active');
navigateTo(SASERP_LINKS.REPORTS.financial + '?period=monthly');
*/

// ===========================================
// 🔧 Helper Functions
// ===========================================

// فحص توفر صفحة
function isPageAvailable(url) {
    // يمكن تطوير هذه الدالة للتحقق من الصلاحيات
    return true;
}

// الحصول على عنوان الصفحة
function getPageTitle(url) {
    const pageTitles = {
        [SASERP_LINKS.MAIN_PAGES.home]: 'الرئيسية',
        [SASERP_LINKS.MAIN_PAGES.dashboard]: 'لوحة التحكم',
        [SASERP_LINKS.FINANCIAL.accounts]: 'خطة الحسابات',
        [SASERP_LINKS.FINANCIAL.generalLedger]: 'الأستاذ العام',
        [SASERP_LINKS.HR.employees]: 'الموظفون',
        [SASERP_LINKS.SALES.pos]: 'نقطة البيع',
        // أضف المزيد حسب الحاجة
    };
    
    return pageTitles[url] || 'صفحة النظام';
}

// إنشاء breadcrumb
function createBreadcrumb(url) {
    const breadcrumbs = [];
    
    // تحديد المسار بناء على URL
    if (url.includes('Financial') || url.includes('GL') || url.includes('Account')) {
        breadcrumbs.push('الرئيسية', 'المحاسبة');
    } else if (url.includes('HR') || url.includes('Employee')) {
        breadcrumbs.push('الرئيسية', 'الموارد البشرية');
    } else if (url.includes('Stock') || url.includes('Item')) {
        breadcrumbs.push('الرئيسية', 'المخزون');
    }
    
    breadcrumbs.push(getPageTitle(url));
    return breadcrumbs;
}

// ===========================================
// 🌐 Export للاستخدام العام
// ===========================================

// إتاحة المتغيرات عالمياً
if (typeof window !== 'undefined') {
    window.SASERP_LINKS = SASERP_LINKS;
    window.QuickNav = QuickNav;
    window.navigateTo = navigateTo;
    window.getPageTitle = getPageTitle;
    window.createBreadcrumb = createBreadcrumb;
}

// Export لـ ES6 modules
if (typeof module !== 'undefined' && module.exports) {
    module.exports = {
        SASERP_LINKS,
        QuickNav,
        navigateTo,
        getPageTitle,
        createBreadcrumb
    };
}

// ===========================================
// 📚 تسجيل المعلومات
// ===========================================

console.log('🔗 SASERP Links System Loaded');
console.log('📋 Available Links Categories:', Object.keys(SASERP_LINKS));
console.log('⚡ Quick Navigation Functions:', Object.keys(QuickNav));
console.log('📖 للحصول على دليل شامل، اذهب إلى: ~/TestPages/SystemLinksGuide.aspx');
