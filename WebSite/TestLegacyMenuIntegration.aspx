<%@ Page Language="VB" MasterPageFile="~/LegacyModernMaster.master" AutoEventWireup="false" CodeFile="TestLegacyMenuIntegration.aspx.vb" Inherits="TestLegacyMenuIntegration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-12">
                <div class="d-flex justify-content-between align-items-center mb-4">
                    <h1 class="h3 mb-0 text-gradient">اختبار دمج المنيو الليجاسي مع التصميم الحديث</h1>
                    <div>
                        <button onclick="LegacyMenuIntegration.toggleMenu()" class="btn btn-gradient me-2">
                            <i class="fas fa-bars me-2"></i>فتح القائمة
                        </button>
                        <button onclick="LegacyMenuIntegration.api.search('مبيعات')" class="btn btn-secondary">
                            <i class="fas fa-search me-2"></i>البحث عن المبيعات
                        </button>
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-8">
                <div class="glass-card">
                    <div class="card-header">
                        <h5 class="card-title mb-0">معلومات النظام</h5>
                    </div>
                    <div class="card-body">
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="mb-3">
                                    <label class="form-label">اسم المستخدم:</label>
                                    <p class="form-control-plaintext" id="testUserName">جارٍ التحميل...</p>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="mb-3">
                                    <label class="form-label">حالة المنيو:</label>
                                    <p class="form-control-plaintext" id="testMenuStatus">غير محدد</p>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6">
                                <div class="mb-3">
                                    <label class="form-label">عرض الشاشة:</label>
                                    <p class="form-control-plaintext" id="testScreenSize">-</p>
                                </div>
                            </div>
                            <div class="col-sm-6">
                                <div class="mb-3">
                                    <label class="form-label">حالة التحميل:</label>
                                    <p class="form-control-plaintext" id="testLoadStatus">جارٍ التحميل...</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="glass-card mt-4">
                    <div class="card-header">
                        <h5 class="card-title mb-0">اختبار المنيو</h5>
                    </div>
                    <div class="card-body">
                        <div class="row g-3">
                            <div class="col-md-6">
                                <button onclick="testDropdownToggle()" class="btn btn-outline-primary w-100">
                                    <i class="fas fa-chevron-down me-2"></i>اختبار القوائم المنسدلة
                                </button>
                            </div>
                            <div class="col-md-6">
                                <button onclick="testSearchFunctionality()" class="btn btn-outline-secondary w-100">
                                    <i class="fas fa-search me-2"></i>اختبار البحث
                                </button>
                            </div>
                            <div class="col-md-6">
                                <button onclick="testActiveItemHighlight()" class="btn btn-outline-success w-100">
                                    <i class="fas fa-check me-2"></i>اختبار تمييز العنصر النشط
                                </button>
                            </div>
                            <div class="col-md-6">
                                <button onclick="testMobileResponsiveness()" class="btn btn-outline-warning w-100">
                                    <i class="fas fa-mobile-alt me-2"></i>اختبار التجاوب مع الشاشات
                                </button>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="glass-card mt-4">
                    <div class="card-header">
                        <h5 class="card-title mb-0">وحدة التحكم (Console)</h5>
                    </div>
                    <div class="card-body">
                        <div class="bg-light p-3 rounded" style="font-family: 'Courier New', monospace; font-size: 0.875rem;">
                            <div id="consoleOutput"></div>
                        </div>
                        <div class="mt-3">
                            <button onclick="clearConsole()" class="btn btn-sm btn-outline-danger">
                                <i class="fas fa-trash me-1"></i>مسح وحدة التحكم
                            </button>
                            <button onclick="runDiagnostic()" class="btn btn-sm btn-outline-info">
                                <i class="fas fa-stethoscope me-1"></i>تشخيص النظام
                            </button>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-md-4">
                <div class="glass-card">
                    <div class="card-header">
                        <h5 class="card-title mb-0">معلومات الاختبار</h5>
                    </div>
                    <div class="card-body">
                        <div class="mb-3">
                            <h6>المميزات المتوفرة:</h6>
                            <ul class="list-unstyled">
                                <li><i class="fas fa-check text-success me-2"></i>منيو أفقي في الشاشات الكبيرة</li>
                                <li><i class="fas fa-check text-success me-2"></i>منيو جانبي في الشاشات المحمولة</li>
                                <li><i class="fas fa-check text-success me-2"></i>بحث فوري</li>
                                <li><i class="fas fa-check text-success me-2"></i>قوائم فرعية قابلة للطي</li>
                                <li><i class="fas fa-check text-success me-2"></i>تمييز العنصر النشط</li>
                                <li><i class="fas fa-check text-success me-2"></i>دعم إمكانية الوصول</li>
                            </ul>
                        </div>
                        <div class="mb-3">
                            <h6>اختبار سريع:</h6>
                            <div class="btn-group-vertical w-100">
                                <button onclick="logToConsole('تم اختبار زر الاختبار 1')" class="btn btn-sm btn-outline-primary">
                                    اختبار 1
                                </button>
                                <button onclick="logToConsole('تم اختبار زر الاختبار 2')" class="btn btn-sm btn-outline-primary">
                                    اختبار 2
                                </button>
                                <button onclick="logToConsole('تم اختبار زر الاختبار 3')" class="btn btn-sm btn-outline-primary">
                                    اختبار 3
                                </button>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="glass-card mt-3">
                    <div class="card-header">
                        <h5 class="card-title mb-0">حالة النظام</h5>
                    </div>
                    <div class="card-body">
                        <div id="systemStatus">
                            <div class="text-center">
                                <div class="spinner-border text-primary" role="status">
                                    <span class="visually-hidden">جارٍ التحميل...</span>
                                </div>
                                <p class="mt-2 mb-0">جارٍ فحص حالة النظام...</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        // Test page JavaScript
        function updateTestInfo() {
            // Update username
            const userNameElement = document.getElementById('testUserName');
            const currentUserName = document.getElementById('currentUserName');
            if (userNameElement && currentUserName) {
                userNameElement.textContent = currentUserName.textContent;
            }

            // Update menu status
            const menuStatusElement = document.getElementById('testMenuStatus');
            if (menuStatusElement) {
                const isMenuOpen = LegacyMenuIntegration.state.isMenuOpen;
                menuStatusElement.textContent = isMenuOpen ? 'مفتوح' : 'مغلق';
                menuStatusElement.className = 'form-control-plaintext ' + (isMenuOpen ? 'text-success' : 'text-muted');
            }

            // Update screen size
            const screenSizeElement = document.getElementById('testScreenSize');
            if (screenSizeElement) {
                screenSizeElement.textContent = window.innerWidth + 'px × ' + window.innerHeight + 'px';
            }

            // Update load status
            const loadStatusElement = document.getElementById('testLoadStatus');
            if (loadStatusElement) {
                const isInitialized = LegacyMenuIntegration.state.isInitialized;
                loadStatusElement.textContent = isInitialized ? 'تم التحميل' : 'جارٍ التحميل...';
                loadStatusElement.className = 'form-control-plaintext ' + (isInitialized ? 'text-success' : 'text-warning');
            }
        }

        function testDropdownToggle() {
            logToConsole('اختبار القوائم المنسدلة - سيتم إغلاق جميع القوائم المنسدلة');
            LegacyMenuIntegration.closeAllDropdowns();
        }

        function testSearchFunctionality() {
            logToConsole('اختبار البحث - سيتم فتح القائمة وتفعيل البحث');
            LegacyMenuIntegration.toggleMenu();
            setTimeout(() => {
                LegacyMenuIntegration.api.search('تقارير');
            }, 500);
        }

        function testActiveItemHighlight() {
            logToConsole('اختبار تمييز العنصر النشط - سيتم تمييز عنصر التقارير');
            const reportsLink = document.querySelector('a[href*="Reports"]');
            if (reportsLink) {
                reportsLink.classList.add('active');
                logToConsole('تم تمييز عنصر التقارير بنجاح');
            } else {
                logToConsole('لم يتم العثور على عنصر التقارير');
            }
        }

        function testMobileResponsiveness() {
            logToConsole('اختبار التجاوب - سيتم تغيير عرض النافذة');

            // Simulate mobile view
            const originalWidth = window.innerWidth;
            const mobileWidth = 480;

            if (window.innerWidth > mobileWidth) {
                logToConsole('محاكاة الشاشة المحمولة (' + mobileWidth + 'px)');
                window.resizeTo(mobileWidth, window.innerHeight);
            } else {
                logToConsole('محاكاة الشاشة الكبيرة (' + originalWidth + 'px)');
                window.resizeTo(originalWidth, window.innerHeight);
            }

            setTimeout(() => {
                updateTestInfo();
            }, 100);
        }

        function logToConsole(message) {
            const consoleOutput = document.getElementById('consoleOutput');
            const timestamp = new Date().toLocaleTimeString('ar-SA');
            const logEntry = document.createElement('div');
            logEntry.className = 'console-entry';
            logEntry.innerHTML = `<span class="console-time">[${timestamp}]</span> <span class="console-message">${message}</span>`;

            consoleOutput.appendChild(logEntry);
            consoleOutput.scrollTop = consoleOutput.scrollHeight;

            // Also log to actual console
            console.log(`[${timestamp}] ${message}`);
        }

        function clearConsole() {
            const consoleOutput = document.getElementById('consoleOutput');
            consoleOutput.innerHTML = '';
            logToConsole('تم مسح وحدة التحكم');
        }

        function runDiagnostic() {
            logToConsole('=== بدء التشخيص ===');
            logToConsole('حالة النظام: ' + (LegacyMenuIntegration.state.isInitialized ? 'مُهيأ' : 'غير مُهيأ'));
            logToConsole('المنيو مفتوح: ' + (LegacyMenuIntegration.state.isMenuOpen ? 'نعم' : 'لا'));
            logToConsole('عرض الشاشة: ' + window.innerWidth + 'px');
            logToConsole('متغير المستخدم: ' + (window.LegacyMenuUserInfo ? 'متوفر' : 'غير متوفر'));
            logToConsole('بيانات المنيو: ' + (window.LegacyMenuData ? 'متوفرة' : 'غير متوفرة'));
            logToConsole('معلومات الصفحة: ' + (window.LegacyMenuPageInfo ? 'متوفرة' : 'غير متوفرة'));
            logToConsole('=== انتهاء التشخيص ===');
        }

        // Update test info when page loads
        document.addEventListener('DOMContentLoaded', function() {
            logToConsole('تم تحميل صفحة الاختبار');

            // Update info periodically
            updateTestInfo();
            setInterval(updateTestInfo, 1000);

            // Initialize system status
            setTimeout(() => {
                const systemStatus = document.getElementById('systemStatus');
                if (systemStatus) {
                    const isReady = LegacyMenuIntegration.state.isInitialized;
                    systemStatus.innerHTML = `
                        <div class="text-center">
                            <i class="fas fa-${isReady ? 'check-circle text-success' : 'times-circle text-danger'}" style="font-size: 3rem;"></i>
                            <p class="mt-2 mb-0">${isReady ? 'النظام يعمل بشكل طبيعي' : 'هناك مشكلة في النظام'}</p>
                            <small class="text-muted">${isReady ? 'جميع المكونات تعمل' : 'يرجى مراجعة وحدة التحكم'}</small>
                        </div>
                    `;
                }
            }, 2000);

            logToConsole('صفحة الاختبار جاهزة للاستخدام');
        });

        // Handle window resize
        window.addEventListener('resize', function() {
            logToConsole('تم تغيير حجم النافذة إلى: ' + window.innerWidth + 'px × ' + window.innerHeight + 'px');
            updateTestInfo();
        });
    </script>

    <style>
        .console-entry {
            margin-bottom: 0.5rem;
            padding: 0.25rem 0;
            border-bottom: 1px solid #eee;
        }

        .console-time {
            color: #666;
            font-size: 0.75rem;
        }

        .console-message {
            color: #333;
        }

        .glass-card {
            box-shadow: 0 2px 10px rgba(0,0,0,0.1);
            border: none;
            border-radius: 10px;
            margin-bottom: 1.5rem;
        }

        .glass-card .card-header {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            border-radius: 10px 10px 0 0 !important;
            border: none;
        }

        .btn-group-vertical .btn {
            margin-bottom: 0.5rem;
        }

        .btn-group-vertical .btn:last-child {
            margin-bottom: 0;
        }

        #consoleOutput {
            max-height: 300px;
            overflow-y: auto;
            background: #f8f9fa;
            border: 1px solid #dee2e6;
            border-radius: 5px;
            padding: 0.5rem;
        }
    </style>
</asp:Content>