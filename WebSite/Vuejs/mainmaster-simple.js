/**
 * 🚀 Main Master System - نظام ماين ماستر المبسط
 * النظام الهرمي للوظائف بدون تعقيدات
 * mainmaster.pages.*.*() pattern
 */

// تهيئة النظام الأساسي
(function() {
    'use strict';
    
    console.log('🚀 تهيئة نظام Main Master...');
    
    // إنشاء النظام الهرمي الرئيسي
    window.mainmaster = {
        // Menu Bar Functions - وظائف شريط القائمة
        menubar: {
            // Mobile Functions - وظائف الموبايل
            mobilefunction: function() {
                console.log('🍔 تبديل قائمة الموبايل');
                toggleMobileMenu();
            },
            closeMobile: function() {
                console.log('🚪 إغلاق قائمة الموبايل');
                closeMobileMenu();
            },
            openMobile: function() {
                console.log('📱 فتح قائمة الموبايل');
                openMobileMenu();
            },
            
            // Navigation Functions - وظائف التنقل
            navigate: function(url) {
                console.log('🔗 التنقل إلى:', url);
                navigateToPage(url);
            },
            activateTab: function(tabId) {
                console.log('📋 تفعيل التاب:', tabId);
                activateTab(tabId);
            },
            
            // Theme Functions - وظائف الثيم
            switchTheme: function(theme) {
                console.log('🎨 تغيير الثيم إلى:', theme);
                switchTheme(theme);
            },
            toggleDarkMode: function() {
                console.log('🌙 تبديل الوضع المظلم');
                toggleDarkMode();
            }
        },

        // Page Links - روابط الصفحات
        pages: {
            // Main Pages - الصفحات الرئيسية
            home: function() { navigateToPage('~/Default.aspx'); },
            dashboard: function() { navigateToPage('~/TestPages/DashboardExample.aspx'); },
            profile: function() { navigateToPage('~/Pages/Profile.aspx'); },
            settings: function() { navigateToPage('~/Pages/Settings.aspx'); },
            
            // Financial Pages - صفحات المحاسبة
            financial: {
                main: function() { navigateToPage('~/Pages/Financial.aspx'); },
                accounts: function() { navigateToPage('~/Pages/ChartOfAccounts.aspx'); },
                gl: function() { navigateToPage('~/Pages/GeneralLedger.aspx'); },
                transactions: function() { navigateToPage('~/Pages/Transactions.aspx'); },
                vouchers: function() { navigateToPage('~/Pages/Vouchers.aspx'); },
                trialBalance: function() { navigateToPage('~/Pages/TrialBalance.aspx'); },
                cashflow: function() { navigateToPage('~/Pages/CashFlow.aspx'); },
                reports: function() { navigateToPage('~/Pages/FinancialReports.aspx'); }
            },
            
            // HR Pages - صفحات الموارد البشرية
            hr: {
                main: function() { navigateToPage('~/Pages/HR.aspx'); },
                employees: function() { navigateToPage('~/Pages/Employees.aspx'); },
                payroll: function() { navigateToPage('~/Pages/Payroll.aspx'); },
                attendance: function() { navigateToPage('~/Pages/Attendance.aspx'); },
                leaves: function() { navigateToPage('~/Pages/Leaves.aspx'); },
                performance: function() { navigateToPage('~/Pages/Performance.aspx'); }
            },
            
            // Stock Pages - صفحات المخزون
            stock: {
                main: function() { navigateToPage('~/Pages/Stock.aspx'); },
                items: function() { navigateToPage('~/Pages/Items.aspx'); },
                transactions: function() { navigateToPage('~/Pages/StockTransactions.aspx'); },
                reorder: function() { navigateToPage('~/Pages/ReorderLevel.aspx'); },
                barcode: function() { navigateToPage('~/Pages/Barcode.aspx'); },
                reports: function() { navigateToPage('~/Pages/StockReports.aspx'); }
            },
            
            // Sales Pages - صفحات المبيعات
            sales: {
                main: function() { navigateToPage('~/Pages/Sales.aspx'); },
                invoices: function() { navigateToPage('~/Pages/SalesInvoices.aspx'); },
                customers: function() { navigateToPage('~/Pages/Customers.aspx'); },
                pos: function() { navigateToPage('~/Pages/POS.aspx'); },
                reports: function() { navigateToPage('~/Pages/SalesReports.aspx'); }
            },
            
            // Purchase Pages - صفحات المشتريات
            purchase: {
                main: function() { navigateToPage('~/Pages/Purchase.aspx'); },
                orders: function() { navigateToPage('~/Pages/PurchaseOrders.aspx'); },
                suppliers: function() { navigateToPage('~/Pages/Suppliers.aspx'); },
                receiving: function() { navigateToPage('~/Pages/Receiving.aspx'); },
                reports: function() { navigateToPage('~/Pages/PurchaseReports.aspx'); }
            },
            
            // CRM Pages - صفحات إدارة العملاء
            crm: {
                main: function() { navigateToPage('~/Pages/CRM.aspx'); },
                leads: function() { navigateToPage('~/Pages/Leads.aspx'); },
                opportunities: function() { navigateToPage('~/Pages/Opportunities.aspx'); },
                activities: function() { navigateToPage('~/Pages/Activities.aspx'); },
                campaigns: function() { navigateToPage('~/Pages/Campaigns.aspx'); }
            },
            
            // Reports Pages - صفحات التقارير
            reports: {
                main: function() { navigateToPage('~/Pages/Reports.aspx'); },
                financial: function() { navigateToPage('~/Pages/FinancialReports.aspx'); },
                stock: function() { navigateToPage('~/Pages/StockReports.aspx'); },
                sales: function() { navigateToPage('~/Pages/SalesReports.aspx'); },
                hr: function() { navigateToPage('~/Pages/HRReports.aspx'); },
                custom: function() { navigateToPage('~/Pages/CustomReports.aspx'); }
            },
            
            // Admin Pages - صفحات الإدارة
            admin: {
                main: function() { navigateToPage('~/Pages/Admin.aspx'); },
                users: function() { navigateToPage('~/Pages/Users.aspx'); },
                roles: function() { navigateToPage('~/Pages/Roles.aspx'); },
                permissions: function() { navigateToPage('~/Pages/Permissions.aspx'); },
                backup: function() { navigateToPage('~/Pages/Backup.aspx'); },
                settings: function() { navigateToPage('~/Pages/SystemSettings.aspx'); },
                logs: function() { navigateToPage('~/Pages/SystemLogs.aspx'); }
            },
            
            // Test & Demo Pages - صفحات الاختبار والعرض (ملفات موجودة فقط)
            test: {
                main: function() { navigateToPage('~/TestPages/'); },
                index: function() { navigateToPage('~/TestPages/PagesIndex.aspx'); },
                navigation: function() { navigateToPage('~/TestPages/NavigationExample.aspx'); },
                dashboard: function() { navigateToPage('~/TestPages/TestDashboardData.aspx'); },
                linksGuide: function() { navigateToPage('~/TestPages/SystemLinksGuide.aspx'); },
                linksTesting: function() { navigateToPage('~/TestPages/LinksTestingPage.html'); },
                quickTest: function() { navigateToPage('~/TestPages/QuickSystemTest.html'); },
                hierarchyTest: function() { navigateToPage('~/TestPages/HierarchyTest.html'); },
                themes: function() { navigateToPage('~/TestPages/theme-center-index.html'); }
            },
            
            // Quick Access - وصول سريع
            quick: {
                newInvoice: function() { navigateToPage('~/Pages/NewSalesInvoice.aspx'); },
                newPurchase: function() { navigateToPage('~/Pages/NewPurchaseOrder.aspx'); },
                newEmployee: function() { navigateToPage('~/Pages/NewEmployee.aspx'); },
                newCustomer: function() { navigateToPage('~/Pages/NewCustomer.aspx'); },
                newItem: function() { navigateToPage('~/Pages/NewItem.aspx'); },
                dailyReports: function() { navigateToPage('~/Pages/DailyReports.aspx'); }
            }
        },

        // Utility Functions - الوظائف المساعدة
        utils: {
            showNotification: function(message, type) {
                console.log('📢 إشعار:', message, 'نوع:', type);
                showNotification(message, type);
            },
            scrollToTop: function() {
                console.log('⬆️ التمرير إلى الأعلى');
                window.scrollTo({ top: 0, behavior: 'smooth' });
            },
            refresh: function() {
                console.log('🔄 إعادة تحميل الصفحة');
                window.location.reload();
            }
        }
    };

    // Helper Functions - الوظائف المساعدة
    function navigateToPage(url) {
        if (url && url !== '#') {
            console.log('🔗 الانتقال إلى:', url);
            // تحويل ~ إلى المسار النسبي
            if (url.startsWith('~/')) {
                url = url.substring(2);
            }
            window.location.href = url;
        } else {
            console.warn('⚠️ رابط غير صحيح:', url);
        }
    }

    function toggleMobileMenu() {
        var overlay = document.getElementById('navigationOverlay');
        var hamburger = document.getElementById('hamburgerToggle');
        
        if (overlay && hamburger) {
            overlay.classList.toggle('active');
            hamburger.classList.toggle('active');
            document.body.style.overflow = overlay.classList.contains('active') ? 'hidden' : '';
        }
    }

    function closeMobileMenu() {
        var overlay = document.getElementById('navigationOverlay');
        var hamburger = document.getElementById('hamburgerToggle');
        
        if (overlay) overlay.classList.remove('active');
        if (hamburger) hamburger.classList.remove('active');
        document.body.style.overflow = '';
    }

    function openMobileMenu() {
        var overlay = document.getElementById('navigationOverlay');
        var hamburger = document.getElementById('hamburgerToggle');
        
        if (overlay) overlay.classList.add('active');
        if (hamburger) hamburger.classList.add('active');
        document.body.style.overflow = 'hidden';
    }

    function activateTab(tabId) {
        // إزالة التفعيل من جميع التابات
        var tabs = document.querySelectorAll('.tab-button');
        tabs.forEach(function(tab) {
            tab.classList.remove('active');
        });
        
        // تفعيل التاب المحدد
        var activeTab = document.getElementById(tabId);
        if (activeTab) {
            activeTab.classList.add('active');
        }
        
        // إخفاء جميع المحتويات
        var contents = document.querySelectorAll('.tab-content');
        contents.forEach(function(content) {
            content.style.display = 'none';
        });
        
        // إظهار المحتوى المحدد
        var activeContent = document.getElementById(tabId + '-content');
        if (activeContent) {
            activeContent.style.display = 'block';
        }
    }

    function switchTheme(theme) {
        document.body.setAttribute('data-theme', theme);
        localStorage.setItem('app-theme', theme);
        console.log('🎨 تم تغيير الثيم إلى:', theme);
    }

    function toggleDarkMode() {
        var currentTheme = document.body.getAttribute('data-theme') || 'light';
        var newTheme = currentTheme === 'light' ? 'dark' : 'light';
        switchTheme(newTheme);
    }

    function showNotification(message, type) {
        // إنشاء إشعار بسيط
        var notification = document.createElement('div');
        notification.className = 'notification notification-' + (type || 'info');
        notification.textContent = message;
        notification.style.cssText = 'position:fixed;top:20px;right:20px;background:#333;color:white;padding:15px;border-radius:5px;z-index:9999;';
        
        document.body.appendChild(notification);
        
        // إزالة الإشعار بعد 3 ثواني
        setTimeout(function() {
            if (notification.parentNode) {
                notification.parentNode.removeChild(notification);
            }
        }, 3000);
    }

    // تصدير النظام للاستخدام العام
    if (typeof module !== 'undefined' && module.exports) {
        module.exports = window.mainmaster;
    }

    console.log('✅ تم تهيئة نظام Main Master بنجاح');
    console.log('🎯 يمكنك الآن استخدام: mainmaster.pages.financial.accounts()');

})();

// تحميل النظام عند تحميل الصفحة
document.addEventListener('DOMContentLoaded', function() {
    console.log('📄 تم تحميل الصفحة - نظام Main Master جاهز للاستخدام');
    
    // إضافة CSS للإشعارات إذا لم يكن موجوداً
    if (!document.querySelector('#mainmaster-styles')) {
        var style = document.createElement('style');
        style.id = 'mainmaster-styles';
        style.textContent = `
            .notification {
                position: fixed;
                top: 20px;
                right: 20px;
                padding: 15px 20px;
                border-radius: 5px;
                color: white;
                font-weight: bold;
                z-index: 9999;
                transition: all 0.3s ease;
            }
            .notification-success { background-color: #28a745; }
            .notification-warning { background-color: #ffc107; color: #333; }
            .notification-error { background-color: #dc3545; }
            .notification-info { background-color: #17a2b8; }
        `;
        document.head.appendChild(style);
    }
});

console.log('🚀 تم تحميل Main Master System بنجاح');
