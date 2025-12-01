<%@ Page Title="مثال على الاستخدام - Universal Navigation" Language="VB" MasterPageFile="~/UniversalNavMaster.master" AutoEventWireup="false" CodeFile="NavigationExample.aspx.vb" Inherits="NavigationExample" %>

<asp:Content ID="TitleContent" ContentPlaceHolderID="TitleContentPlaceHolder" runat="server">
    مثال على استخدام النظام الموحد للتنقل
</asp:Content>

<asp:Content ID="HeadContent" ContentPlaceHolderID="HeadContentPlaceHolder" runat="server">
    <!-- CSS خاص بهذه الصفحة -->
    <style>
        .demo-section {
            background: white;
            border-radius: 8px;
            padding: 20px;
            margin-bottom: 20px;
            box-shadow: 0 2px 4px rgba(0,0,0,0.1);
        }
        
        .demo-button {
            background: #3498db;
            color: white;
            border: none;
            padding: 10px 20px;
            border-radius: 5px;
            cursor: pointer;
            margin: 5px;
            transition: all 0.3s;
        }
        
        .demo-button:hover {
            background: #2980b9;
            transform: translateY(-2px);
        }
    </style>
</asp:Content>

<asp:Content ID="PageHeaderContent" ContentPlaceHolderID="PageHeaderPlaceHolder" runat="server">
    <!-- Page Header (اختياري) -->
    <div class="page-header bg-primary text-white p-3 mb-4">
        <div class="container-fluid">
            <h1 class="h3 mb-0">
                <i class="fas fa-hamburger"></i>
                مثال على النظام الموحد للتنقل
            </h1>
            <p class="mb-0">توضيح كيفية استخدام Universal Hamburger Menu مع Vue.js</p>
        </div>
    </div>
</asp:Content>

<asp:Content ID="MainContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    
    <div class="row">
        <div class="col-lg-8">
            
            <!-- قسم التوضيح -->
            <div class="demo-section">
                <h2><i class="fas fa-info-circle text-primary"></i> حول النظام</h2>
                <p>تم تطوير نظام التنقل الموحد ليوفر:</p>
                <ul>
                    <li>✅ قائمة برجر موحدة في كل الصفحات</li>
                    <li>✅ قراءة مباشرة من Web.Sitemap</li>
                    <li>✅ أمان مدمج مع نظام الأدوار</li>
                    <li>✅ تصميم Mobile-First متجاوب</li>
                    <li>✅ إخفاء القوائم الأفقية نهائياً</li>
                    <li>✅ دمج مع Vue.js Framework</li>
                </ul>
            </div>

            <!-- قسم التحكم في القائمة -->
            <div class="demo-section">
                <h3><i class="fas fa-cogs text-success"></i> التحكم في القائمة</h3>
                <p>يمكنك التحكم في القائمة برمجياً باستخدام JavaScript:</p>
                
                <div class="row">
                    <div class="col-md-6">
                        <button class="demo-button btn-block" onclick="mainmaster.navigation.toggleMenu()">
                            <i class="fas fa-bars"></i> فتح/إغلاق القائمة
                        </button>
                    </div>
                    <div class="col-md-6">
                        <button class="demo-button btn-block" onclick="mainmaster.navigation.toggleProfile()">
                            <i class="fas fa-user"></i> عرض/إخفاء الملف الشخصي
                        </button>
                    </div>
                </div>
                
                <div class="row mt-2">
                    <div class="col-md-6">
                        <button class="demo-button btn-block" onclick="mainmaster.navigation.goToHome()">
                            <i class="fas fa-home"></i> الذهاب للرئيسية
                        </button>
                    </div>
                    <div class="col-md-6">
                        <button class="demo-button btn-block" onclick="mainmaster.navigation.toggleTheme()">
                            <i class="fas fa-palette"></i> تغيير الثيم
                        </button>
                    </div>
                </div>
            </div>

            <!-- قسم البحث -->
            <div class="demo-section">
                <h3><i class="fas fa-search text-warning"></i> البحث في القائمة</h3>
                <p>يمكنك البحث في عناصر القائمة:</p>
                
                <div class="input-group">
                    <input type="text" id="searchDemo" class="form-control" placeholder="ابحث في القوائم..." onkeyup="searchInMenu(this.value)">
                    <div class="input-group-append">
                        <button class="btn btn-outline-secondary" onclick="clearSearch()">
                            <i class="fas fa-times"></i>
                        </button>
                    </div>
                </div>
                
                <div id="searchResults" class="mt-3"></div>
            </div>

        </div>
        
        <div class="col-lg-4">
            
            <!-- معلومات النظام -->
            <div class="demo-section">
                <h4><i class="fas fa-info text-info"></i> معلومات النظام</h4>
                <div id="systemInfo">
                    <p><strong>المستخدم:</strong> <span id="currentUser">جارٍ التحميل...</span></p>
                    <p><strong>الصفحة:</strong> <span id="currentPage">جارٍ التحميل...</span></p>
                    <p><strong>عدد عناصر القائمة:</strong> <span id="menuCount">جارٍ التحميل...</span></p>
                    <p><strong>حالة القائمة:</strong> <span id="menuStatus">مغلقة</span></p>
                </div>
            </div>

            <!-- الإحصائيات -->
            <div class="demo-section">
                <h4><i class="fas fa-chart-bar text-success"></i> إحصائيات الاستخدام</h4>
                <div class="small">
                    <p>عدد مرات فتح القائمة: <span id="menuOpenCount">0</span></p>
                    <p>عدد مرات البحث: <span id="searchCount">0</span></p>
                    <p>آخر تنقل: <span id="lastNavigation">-</span></p>
                </div>
            </div>

            <!-- الإعدادات -->
            <div class="demo-section">
                <h4><i class="fas fa-sliders-h text-secondary"></i> الإعدادات</h4>
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="enableNotifications" checked>
                    <label class="form-check-label" for="enableNotifications">
                        تفعيل الإشعارات
                    </label>
                </div>
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="enableAnimations" checked>
                    <label class="form-check-label" for="enableAnimations">
                        تفعيل الحركات
                    </label>
                </div>
                <div class="form-check">
                    <input class="form-check-input" type="checkbox" id="compactMode">
                    <label class="form-check-label" for="compactMode">
                        الوضع المضغوط
                    </label>
                </div>
            </div>

        </div>
    </div>

    <!-- Message Area -->
    <div id="messageArea" class="mt-4"></div>

</asp:Content>

<asp:Content ID="PageFooterContent" ContentPlaceHolderID="PageFooterPlaceHolder" runat="server">
    <!-- JavaScript خاص بهذه الصفحة -->
    <script type="text/javascript">
        // متغيرات للإحصائيات
        let menuOpenCount = 0;
        let searchCount = 0;

        // تهيئة الصفحة
        document.addEventListener('DOMContentLoaded', function() {
            console.log('🚀 تهيئة صفحة مثال Navigation');
            
            // تحديث معلومات النظام
            updateSystemInfo();
            
            // مراقبة حالة القائمة
            monitorMenuState();
            
            // إعداد الإعدادات
            setupSettings();
            
            console.log('✅ تم تهيئة صفحة المثال');
        });

        // تحديث معلومات النظام
        function updateSystemInfo() {
            try {
                if (typeof mainmaster !== 'undefined' && mainmaster.navigation) {
                    const state = mainmaster.navigation.state;
                    
                    document.getElementById('currentUser').textContent = 
                        state.userInfo.displayName || state.userInfo.username || 'غير محدد';
                    
                    document.getElementById('currentPage').textContent = 
                        state.currentPage.title || 'غير محدد';
                    
                    document.getElementById('menuCount').textContent = 
                        state.menuItems.length || '0';
                }
            } catch (error) {
                console.warn('تحذير: لا يمكن تحديث معلومات النظام:', error);
            }
        }

        // مراقبة حالة القائمة
        function monitorMenuState() {
            setInterval(function() {
                try {
                    if (typeof mainmaster !== 'undefined' && mainmaster.navigation) {
                        const isOpen = mainmaster.navigation.state.isMenuOpen;
                        document.getElementById('menuStatus').textContent = isOpen ? 'مفتوحة' : 'مغلقة';
                        
                        if (isOpen) {
                            menuOpenCount++;
                            document.getElementById('menuOpenCount').textContent = menuOpenCount;
                        }
                    }
                } catch (error) {
                    // تجاهل الأخطاء البسيطة
                }
            }, 1000);
        }

        // البحث في القائمة
        function searchInMenu(term) {
            try {
                searchCount++;
                document.getElementById('searchCount').textContent = searchCount;
                
                if (typeof mainmaster !== 'undefined' && mainmaster.navigation) {
                    mainmaster.navigation.state.searchTerm = term;
                    mainmaster.navigation.filterMenu();
                    
                    // عرض النتائج
                    const results = mainmaster.navigation.state.filteredItems;
                    const resultsDiv = document.getElementById('searchResults');
                    
                    if (term.trim()) {
                        resultsDiv.innerHTML = `
                            <div class="alert alert-info">
                                <i class="fas fa-search"></i>
                                تم العثور على ${results.length} نتيجة للبحث: "${term}"
                            </div>
                        `;
                    } else {
                        resultsDiv.innerHTML = '';
                    }
                }
            } catch (error) {
                showMessage('خطأ في البحث: ' + error.message, 'error');
            }
        }

        // مسح البحث
        function clearSearch() {
            document.getElementById('searchDemo').value = '';
            searchInMenu('');
        }

        // إعداد الإعدادات
        function setupSettings() {
            // مراقبة تغيير الإعدادات
            document.getElementById('enableNotifications').addEventListener('change', function(e) {
                showMessage('تم ' + (e.target.checked ? 'تفعيل' : 'إلغاء') + ' الإشعارات', 'info');
            });

            document.getElementById('enableAnimations').addEventListener('change', function(e) {
                if (e.target.checked) {
                    document.body.classList.remove('reduced-motion');
                } else {
                    document.body.classList.add('reduced-motion');
                }
                showMessage('تم ' + (e.target.checked ? 'تفعيل' : 'إلغاء') + ' الحركات', 'info');
            });

            document.getElementById('compactMode').addEventListener('change', function(e) {
                if (e.target.checked) {
                    document.body.classList.add('compact-mode');
                } else {
                    document.body.classList.remove('compact-mode');
                }
                showMessage('تم ' + (e.target.checked ? 'تفعيل' : 'إلغاء') + ' الوضع المضغوط', 'info');
            });
        }

        // عرض رسالة
        function showMessage(message, type = 'info') {
            const messageArea = document.getElementById('messageArea');
            const alertClass = type === 'error' ? 'alert-danger' : 
                              type === 'success' ? 'alert-success' : 'alert-info';
            
            const messageHtml = `
                <div class="alert ${alertClass} alert-dismissible fade show">
                    <i class="fas fa-${type === 'error' ? 'exclamation-triangle' : 'info-circle'}"></i>
                    ${message}
                    <button type="button" class="close" data-dismiss="alert">
                        <span>&times;</span>
                    </button>
                </div>
            `;
            
            messageArea.innerHTML = messageHtml;
            
            // إخفاء الرسالة تلقائياً بعد 5 ثوان
            setTimeout(function() {
                const alert = messageArea.querySelector('.alert');
                if (alert) {
                    alert.classList.remove('show');
                    setTimeout(() => alert.remove(), 300);
                }
            }, 5000);
        }

        // تسجيل الأحداث
        if (typeof mainmaster !== 'undefined' && mainmaster.navigation) {
            // مراقبة التنقل
            const originalNavigate = mainmaster.navigation.navigateToPage;
            mainmaster.navigation.navigateToPage = function(item) {
                document.getElementById('lastNavigation').textContent = 
                    new Date().toLocaleTimeString('ar-EG') + ' - ' + item.title;
                return originalNavigate.call(this, item);
            };
        }

        // CSS للوضع المضغوط
        const compactCSS = `
            .compact-mode .universal-hamburger-wrapper {
                height: 50px !important;
            }
            .compact-mode .app-title {
                font-size: 16px !important;
            }
            .compact-mode .current-page {
                display: none !important;
            }
            .compact-mode .mobile-first-navigation {
                padding-top: 50px !important;
            }
        `;
        
        const style = document.createElement('style');
        style.textContent = compactCSS;
        document.head.appendChild(style);
    </script>
</asp:Content>
