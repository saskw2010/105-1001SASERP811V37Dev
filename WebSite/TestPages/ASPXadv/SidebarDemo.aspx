<%@ Page Language="VB" MasterPageFile="~/ModernMaster.master" AutoEventWireup="false" Title="AdminLTE Sidebar Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .demo-content {
            padding: 2rem;
            max-width: 1200px;
            margin: 0 auto;
        }
        
        .demo-card {
            background: white;
            border-radius: 8px;
            padding: 1.5rem;
            margin-bottom: 1.5rem;
            box-shadow: 0 2px 4px rgba(0,0,0,0.1);
        }
        
        .demo-title {
            color: #2c3e50;
            margin-bottom: 1rem;
            padding-bottom: 0.5rem;
            border-bottom: 2px solid #3498db;
        }
        
        .feature-list {
            list-style: none;
            padding: 0;
        }
        
        .feature-list li {
            padding: 0.5rem 0;
            border-bottom: 1px solid #ecf0f1;
        }
        
        .feature-list li:before {
            content: "✅ ";
            margin-left: 0.5rem;
        }
        
        .shortcut-key {
            background: #34495e;
            color: white;
            padding: 0.25rem 0.5rem;
            border-radius: 4px;
            font-family: monospace;
            margin: 0 0.25rem;
        }
        
        .demo-actions {
            display: flex;
            gap: 1rem;
            flex-wrap: wrap;
            margin-top: 1rem;
        }
        
        .demo-btn {
            background: linear-gradient(135deg, #3498db, #2980b9);
            color: white;
            border: none;
            padding: 0.75rem 1.5rem;
            border-radius: 6px;
            cursor: pointer;
            transition: all 0.3s ease;
        }
        
        .demo-btn:hover {
            transform: translateY(-2px);
            box-shadow: 0 4px 8px rgba(0,0,0,0.2);
        }
        
        .status-indicator {
            display: inline-block;
            width: 12px;
            height: 12px;
            border-radius: 50%;
            margin-left: 0.5rem;
        }
        
        .status-success {
            background: #27ae60;
        }
        
        .status-warning {
            background: #f39c12;
        }
        
        .status-error {
            background: #e74c3c;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <div class="demo-content">
        <div class="demo-card">
            <h1 class="demo-title">🎛️ AdminLTE Style Sidebar Demo</h1>
            <p>مرحباً بك في عرض توضيحي للقائمة الجانبية بتصميم AdminLTE الحديث مع دعم اللغة العربية (RTL).</p>
            
            <div class="demo-actions">
                <button class="demo-btn" onclick="toggleSidebarDemo()">🔄 تبديل القائمة الجانبية</button>
                <button class="demo-btn" onclick="refreshSidebar()">🔃 تحديث القائمة</button>
                <button class="demo-btn" onclick="testThemeIntegration()">🎨 تجربة الثيمات</button>
            </div>
        </div>
        
        <div class="demo-card">
            <h2 class="demo-title">✨ الميزات الرئيسية</h2>
            <ul class="feature-list">
                <li>تصميم AdminLTE الحديث والأنيق</li>
                <li>دعم كامل للغة العربية (RTL)</li>
                <li>قوائم فرعية قابلة للطي (Treeview)</li>
                <li>استجابة كاملة للهواتف المحمولة</li>
                <li>نسخ تلقائي من PageMenuBar</li>
                <li>حفظ حالة القائمة في Local Storage</li>
                <li>تكامل مع نظام الثيمات</li>
                <li>اختصارات لوحة المفاتيح</li>
                <li>رسوم متحركة سلسة</li>
                <li>تمييز العنصر النشط تلقائياً</li>
            </ul>
        </div>
        
        <div class="demo-card">
            <h2 class="demo-title">⌨️ اختصارات لوحة المفاتيح</h2>
            <p>
                <span class="shortcut-key">Ctrl + B</span> تبديل القائمة الجانبية<br>
                <span class="shortcut-key">Escape</span> إغلاق القائمة الجانبية<br>
                <span class="shortcut-key">Click</span> على الخلفية لإغلاق القائمة (في الهواتف)
            </p>
        </div>
        
        <div class="demo-card">
            <h2 class="demo-title">📊 حالة النظام</h2>
            <p>
                قائمة جانبية: <span id="sidebarStatus">جاري التحقق...</span><span class="status-indicator" id="sidebarStatusIcon"></span><br>
                محتوى القائمة: <span id="menuContentStatus">جاري التحقق...</span><span class="status-indicator" id="menuContentStatusIcon"></span><br>
                تكامل الثيمات: <span id="themeStatus">جاري التحقق...</span><span class="status-indicator" id="themeStatusIcon"></span><br>
                الاستجابة للموبايل: <span id="responsiveStatus">جاري التحقق...</span><span class="status-indicator" id="responsiveStatusIcon"></span>
            </p>
            
            <div class="demo-actions">
                <button class="demo-btn" onclick="runSystemCheck()">🔍 فحص النظام</button>
                <button class="demo-btn" onclick="showDebugInfo()">🐛 معلومات التشخيص</button>
            </div>
        </div>
        
        <div class="demo-card">
            <h2 class="demo-title">🛠️ إعدادات متقدمة</h2>
            <div class="demo-actions">
                <button class="demo-btn" onclick="resetSidebarSettings()">♻️ إعادة تعيين الإعدادات</button>
                <button class="demo-btn" onclick="exportSidebarData()">📤 تصدير البيانات</button>
                <button class="demo-btn" onclick="simulateMenuUpdate()">🔄 محاكاة تحديث القائمة</button>
            </div>
        </div>
    </div>
    
    <script>
        // Demo Functions
        function toggleSidebarDemo() {
            if (window.AdminSidebarManager) {
                window.AdminSidebarManager.toggle();
                updateStatus();
            } else {
                alert('❌ نظام القائمة الجانبية غير متاح');
            }
        }
        
        function refreshSidebar() {
            if (window.AdminSidebarManager) {
                window.AdminSidebarManager.refresh();
                showMessage('✅ تم تحديث القائمة الجانبية', 'success');
            }
        }
        
        function testThemeIntegration() {
            if (window.AdvancedThemeSystem) {
                const themes = ['light', 'dark', 'ai', 'citrus', 'emerald', 'rose'];
                const randomTheme = themes[Math.floor(Math.random() * themes.length)];
                window.AdvancedThemeSystem.setTheme(randomTheme);
                showMessage(`🎨 تم تطبيق ثيم: ${randomTheme}`, 'success');
            } else {
                showMessage('❌ نظام الثيمات غير متاح', 'error');
            }
        }
        
        function runSystemCheck() {
            const statuses = {
                sidebar: window.AdminSidebarManager ? 'متاح' : 'غير متاح',
                menuContent: document.getElementById('dynamicSidebarMenu') ? 'موجود' : 'غير موجود',
                theme: window.AdvancedThemeSystem ? 'متاح' : 'غير متاح',
                responsive: window.innerWidth <= 768 ? 'وضع الموبايل' : 'وضع سطح المكتب'
            };
            
            document.getElementById('sidebarStatus').textContent = statuses.sidebar;
            document.getElementById('menuContentStatus').textContent = statuses.menuContent;
            document.getElementById('themeStatus').textContent = statuses.theme;
            document.getElementById('responsiveStatus').textContent = statuses.responsive;
            
            // Update status indicators
            updateStatusIcon('sidebarStatusIcon', statuses.sidebar === 'متاح');
            updateStatusIcon('menuContentStatusIcon', statuses.menuContent === 'موجود');
            updateStatusIcon('themeStatusIcon', statuses.theme === 'متاح');
            updateStatusIcon('responsiveStatusIcon', true);
            
            showMessage('✅ تم فحص النظام بنجاح', 'success');
        }
        
        function showDebugInfo() {
            const debugInfo = {
                sidebarManager: !!window.AdminSidebarManager,
                sidebarElement: !!document.getElementById('mainSidebar'),
                menuContainer: !!document.getElementById('dynamicSidebarMenu'),
                themeSystem: !!window.AdvancedThemeSystem,
                currentTheme: window.AdvancedThemeSystem ? window.AdvancedThemeSystem.getCurrentTheme() : 'غير متاح',
                screenWidth: window.innerWidth,
                userAgent: navigator.userAgent
            };
            
            console.log('🐛 معلومات تشخيص القائمة الجانبية:', debugInfo);
            alert('تم طباعة معلومات التشخيص في وحدة التحكم (F12)');
        }
        
        function resetSidebarSettings() {
            localStorage.removeItem('admin-sidebar-state');
            localStorage.removeItem('sidebar-open');
            showMessage('♻️ تم إعادة تعيين إعدادات القائمة الجانبية', 'success');
        }
        
        function exportSidebarData() {
            const data = {
                timestamp: new Date().toISOString(),
                sidebarState: localStorage.getItem('admin-sidebar-state'),
                menuItems: Array.from(document.querySelectorAll('#dynamicSidebarMenu .nav-link')).map(link => ({
                    text: link.textContent.trim(),
                    href: link.href
                }))
            };
            
            const blob = new Blob([JSON.stringify(data, null, 2)], { type: 'application/json' });
            const url = URL.createObjectURL(blob);
            const a = document.createElement('a');
            a.href = url;
            a.download = 'sidebar-data.json';
            a.click();
            URL.revokeObjectURL(url);
            
            showMessage('📤 تم تصدير بيانات القائمة الجانبية', 'success');
        }
        
        function simulateMenuUpdate() {
            const menuContainer = document.getElementById('dynamicSidebarMenu');
            if (menuContainer) {
                // Add a test menu item
                const testItem = document.createElement('li');
                testItem.className = 'nav-item';
                testItem.innerHTML = `
                    <a href="#" class="nav-link">
                        <i class="fas fa-star nav-icon"></i>
                        <p>عنصر تجريبي - ${new Date().toLocaleTimeString()}</p>
                    </a>
                `;
                menuContainer.appendChild(testItem);
                showMessage('🔄 تم إضافة عنصر تجريبي للقائمة', 'success');
            }
        }
        
        function updateStatusIcon(elementId, isSuccess) {
            const icon = document.getElementById(elementId);
            if (icon) {
                icon.className = 'status-indicator ' + (isSuccess ? 'status-success' : 'status-error');
            }
        }
        
        function updateStatus() {
            const isOpen = window.AdminSidebarManager && window.AdminSidebarManager.isOpen();
            document.getElementById('sidebarStatus').textContent = isOpen ? 'مفتوحة' : 'مغلقة';
            updateStatusIcon('sidebarStatusIcon', true);
        }
        
        function showMessage(message, type = 'info') {
            console.log(message);
            
            // Create toast notification
            const toast = document.createElement('div');
            toast.style.cssText = `
                position: fixed;
                top: 20px;
                left: 20px;
                background: ${type === 'success' ? '#27ae60' : type === 'error' ? '#e74c3c' : '#3498db'};
                color: white;
                padding: 1rem 1.5rem;
                border-radius: 6px;
                z-index: 9999;
                box-shadow: 0 4px 8px rgba(0,0,0,0.2);
                animation: slideInRight 0.3s ease;
                direction: rtl;
            `;
            toast.textContent = message;
            
            document.body.appendChild(toast);
            
            setTimeout(() => {
                toast.style.animation = 'slideOutRight 0.3s ease';
                setTimeout(() => document.body.removeChild(toast), 300);
            }, 3000);
        }
        
        // Initialize demo
        document.addEventListener('DOMContentLoaded', function() {
            setTimeout(runSystemCheck, 1000);
            
            // Listen for sidebar events
            document.addEventListener('sidebarInitialized', function() {
                showMessage('🎉 تم تحميل القائمة الجانبية بنجاح!', 'success');
            });
            
            document.addEventListener('sidebarOpened', function() {
                updateStatus();
            });
            
            document.addEventListener('sidebarClosed', function() {
                updateStatus();
            });
        });
        
        // Add CSS for toast animations
        const style = document.createElement('style');
        style.textContent = `
            @keyframes slideInRight {
                from { transform: translateX(100%); opacity: 0; }
                to { transform: translateX(0); opacity: 1; }
            }
            @keyframes slideOutRight {
                from { transform: translateX(0); opacity: 1; }
                to { transform: translateX(100%); opacity: 0; }
            }
        `;
        document.head.appendChild(style);
    </script>
</asp:Content>
