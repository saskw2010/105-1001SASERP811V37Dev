<%@ Page Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="unified-user-test.aspx.vb" Inherits="UnifiedUserTest" %>

<asp:Content ID="ContentTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    🎯 Unified User Info System Test - اختبار النظام الموحد
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .test-container {
            padding: 30px;
            background: linear-gradient(135deg, #f0f9ff 0%, #e0f2fe 100%);
            border-radius: 20px;
            margin: 20px 0;
        }
        
        .test-header {
            color: #2563eb;
            font-size: 2rem;
            margin-bottom: 20px;
            display: flex;
            align-items: center;
            gap: 12px;
        }
        
        .solution-summary {
            background: #f0fdf4;
            border: 2px solid #22c55e;
            border-radius: 15px;
            padding: 25px;
            margin: 20px 0;
        }
        
        .solution-summary h3 {
            color: #15803d;
            margin-bottom: 15px;
        }
        
        .features-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 20px;
            margin: 30px 0;
        }
        
        .feature-card {
            background: white;
            border-radius: 15px;
            padding: 20px;
            box-shadow: 0 8px 32px rgba(0, 0, 0, 0.1);
            border-left: 5px solid #2563eb;
        }
        
        .feature-icon {
            color: #2563eb;
            font-size: 2rem;
            margin-bottom: 15px;
        }
        
        .status-panel {
            background: #1f2937;
            color: #f9fafb;
            padding: 20px;
            border-radius: 15px;
            font-family: 'Consolas', monospace;
            margin: 20px 0;
        }
        
        .test-button {
            background: linear-gradient(135deg, #2563eb 0%, #1d4ed8 100%);
            color: white;
            border: none;
            padding: 12px 24px;
            border-radius: 25px;
            cursor: pointer;
            font-weight: 600;
            margin: 10px;
            transition: all 0.3s ease;
        }
        
        .test-button:hover {
            transform: translateY(-2px);
            box-shadow: 0 8px 25px rgba(37, 99, 235, 0.3);
        }
        
        .comparison-table {
            width: 100%;
            border-collapse: collapse;
            margin: 20px 0;
            background: white;
            border-radius: 15px;
            overflow: hidden;
            box-shadow: 0 8px 32px rgba(0, 0, 0, 0.1);
        }
        
        .comparison-table th,
        .comparison-table td {
            padding: 15px;
            text-align: right;
            border-bottom: 1px solid #e5e7eb;
        }
        
        .comparison-table th {
            background: #2563eb;
            color: white;
            font-weight: 600;
        }
        
        .comparison-table tr:nth-child(even) {
            background: #f8fafc;
        }
        
        .rtl-text {
            direction: rtl;
            text-align: right;
            font-family: 'Cairo', Arial, sans-serif;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <div class="test-container">
        <div class="test-header">
            🎯 <span>النظام الموحد لمعلومات المستخدم</span>
        </div>
        
        <div class="solution-summary">
            <h3>✅ الحل المطبق - تم توحيد الأنظمة!</h3>
            <div class="rtl-text">
                <p><strong>المشكلة الأصلية:</strong> كان لدينا اتنين user-info widget - واحد عايم ومش بيجيب بيانات وواحد dropdown مش بيجيب البيانات</p>
                <p><strong>الحل المطبق:</strong> تم إنشاء نظام موحد واحد يجمع البيانات من MembershipBar ويعرضها في dropdown واحد فقط</p>
                <p><strong>المميزات الجديدة:</strong></p>
                <ul>
                    <li>✅ استخراج البيانات مباشرة من Web.Membership._instance</li>
                    <li>✅ تخزين البيانات في LocalStorage مع انتهاء صلاحية (30 دقيقة)</li>
                    <li>✅ دعم الأدوار (Roles) والصلاحيات</li>
                    <li>✅ تحديث البيانات تلقائياً</li>
                    <li>✅ دعم RTL كامل للعربية والإنجليزية</li>
                    <li>✅ إخفاء الأنظمة القديمة تلقائياً</li>
                </ul>
            </div>
        </div>
        
        <div class="features-grid">
            <div class="feature-card">
                <div class="feature-icon">🔄</div>
                <h3>Data Extraction</h3>
                <p>يستخرج البيانات مباشرة من Web.Membership._instance ويحصل على الاسم والإيميل والأدوار والجلسة</p>
            </div>
            
            <div class="feature-card">
                <div class="feature-icon">💾</div>
                <h3>Smart Caching</h3>
                <p>يحفظ البيانات في LocalStorage لمدة 30 دقيقة ويتحقق من صحة البيانات تلقائياً</p>
            </div>
            
            <div class="feature-card">
                <div class="feature-icon">🔐</div>
                <h3>Security Optimized</h3>
                <p>يدعم الأدوار والصلاحيات ويتعامل مع Session ID بشكل آمن</p>
            </div>
            
            <div class="feature-card">
                <div class="feature-icon">🌍</div>
                <h3>RTL Support</h3>
                <p>دعم كامل للعربية مع positioning ذكي حسب اللغة</p>
            </div>
        </div>
        
        <div class="comparison-table">
            <table>
                <thead>
                    <tr>
                        <th>المقارنة</th>
                        <th>النظام القديم</th>
                        <th>النظام الموحد الجديد</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>عدد الـ Widgets</td>
                        <td>❌ اتنين منفصلين</td>
                        <td>✅ واحد موحد</td>
                    </tr>
                    <tr>
                        <td>مصدر البيانات</td>
                        <td>❌ مش محدد</td>
                        <td>✅ Web.Membership._instance</td>
                    </tr>
                    <tr>
                        <td>التخزين المؤقت</td>
                        <td>❌ غير موجود</td>
                        <td>✅ LocalStorage مع انتهاء صلاحية</td>
                    </tr>
                    <tr>
                        <td>الأدوار والصلاحيات</td>
                        <td>❌ غير مدعومة</td>
                        <td>✅ مدعومة بالكامل</td>
                    </tr>
                    <tr>
                        <td>تحديث البيانات</td>
                        <td>❌ يدوي</td>
                        <td>✅ تلقائي مع زر تحديث</td>
                    </tr>
                    <tr>
                        <td>دعم اللغات</td>
                        <td>⚠️ محدود</td>
                        <td>✅ RTL كامل</td>
                    </tr>
                </tbody>
            </table>
        </div>
        
        <div class="status-panel">
            <h4>📋 System Status & Console Logs</h4>
            <div id="systemStatus">Loading system status...</div>
        </div>
        
        <div style="text-align: center; margin: 30px 0;">
            <button class="test-button" onclick="testDataExtraction()">🔍 Test Data Extraction</button>
            <button class="test-button" onclick="testCaching()">💾 Test Caching System</button>
            <button class="test-button" onclick="testRTL()">🌍 Test RTL Support</button>
            <button class="test-button" onclick="refreshUserData()">🔄 Refresh User Data</button>
        </div>
    </div>
    
    <script type="text/javascript">
        document.addEventListener('DOMContentLoaded', function() {
            console.log('🎯 [UnifiedUserTest] Test page loaded');
            
            // Update status panel
            updateSystemStatus();
            
            // Monitor unified user info system
            setTimeout(() => {
                if (window.unifiedUserInfo) {
                    console.log('✅ [UnifiedUserTest] Unified system found:', window.unifiedUserInfo);
                    updateSystemStatus();
                } else {
                    console.warn('⚠️ [UnifiedUserTest] Unified system not found');
                }
            }, 2000);
        });
        
        function updateSystemStatus() {
            const statusDiv = document.getElementById('systemStatus');
            let statusHTML = '';
            
            // Check unified system
            if (window.unifiedUserInfo) {
                statusHTML += '<div style="color: #10b981;">✅ Unified User Info System: Active</div>';
                statusHTML += '<div style="color: #3b82f6;">📊 User Data: ' + (window.unifiedUserInfo.userData ? 'Loaded' : 'Loading...') + '</div>';
            } else {
                statusHTML += '<div style="color: #ef4444;">❌ Unified User Info System: Not Found</div>';
            }
            
            // Check Web.Membership
            if (typeof Web !== 'undefined' && Web.Membership) {
                statusHTML += '<div style="color: #10b981;">✅ Web.Membership: Available</div>';
                if (Web.Membership._instance) {
                    statusHTML += '<div style="color: #10b981;">✅ Membership Instance: Active</div>';
                }
            } else {
                statusHTML += '<div style="color: #f59e0b;">⚠️ Web.Membership: Not Available Yet</div>';
            }
            
            // Check LocalStorage
            try {
                const cached = localStorage.getItem('SASERP_UserInfo');
                if (cached) {
                    const data = JSON.parse(cached);
                    statusHTML += '<div style="color: #10b981;">✅ LocalStorage Cache: Found (' + data.name + ')</div>';
                } else {
                    statusHTML += '<div style="color: #6b7280;">ℹ️ LocalStorage Cache: Empty</div>';
                }
            } catch (e) {
                statusHTML += '<div style="color: #ef4444;">❌ LocalStorage: Error</div>';
            }
            
            // Check original widgets
            const membershipBar = document.getElementById('Membership_Login');
            if (membershipBar) {
                const isHidden = window.getComputedStyle(membershipBar).display === 'none';
                statusHTML += '<div style="color: ' + (isHidden ? '#10b981' : '#f59e0b') + ';">🙈 Original MembershipBar: ' + (isHidden ? 'Hidden' : 'Visible') + '</div>';
            }
            
            statusHTML += '<div style="color: #8b5cf6;">🌍 Language: ' + document.documentElement.lang + ' (RTL: ' + (document.documentElement.dir === 'rtl') + ')</div>';
            statusHTML += '<div style="color: #f59e0b;">⏰ Last Update: ' + new Date().toLocaleTimeString() + '</div>';
            
            statusDiv.innerHTML = statusHTML;
        }
        
        function testDataExtraction() {
            console.log('🔍 [UnifiedUserTest] Testing data extraction...');
            
            if (window.unifiedUserInfo) {
                window.unifiedUserInfo.extractMembershipData();
                console.log('📊 Extracted data:', window.unifiedUserInfo.userData);
                alert('Data extraction test completed. Check console for details.');
                updateSystemStatus();
            } else {
                alert('Unified User Info System not found!');
            }
        }
        
        function testCaching() {
            console.log('💾 [UnifiedUserTest] Testing caching system...');
            
            try {
                const testData = {
                    name: 'Test User',
                    email: 'test@example.com',
                    roles: ['Tester'],
                    lastActivity: new Date().toISOString()
                };
                
                localStorage.setItem('SASERP_UserInfo', JSON.stringify(testData));
                console.log('✅ Cache test data saved');
                
                const retrieved = JSON.parse(localStorage.getItem('SASERP_UserInfo'));
                console.log('📋 Retrieved data:', retrieved);
                
                alert('Caching test completed. Check console for details.');
                updateSystemStatus();
            } catch (e) {
                console.error('❌ Caching test failed:', e);
                alert('Caching test failed: ' + e.message);
            }
        }
        
        function testRTL() {
            console.log('🌍 [UnifiedUserTest] Testing RTL support...');
            
            const currentLang = document.documentElement.lang;
            const currentDir = document.documentElement.dir;
            
            if (currentLang.includes('ar') || currentDir === 'rtl') {
                document.documentElement.lang = 'en';
                document.documentElement.dir = 'ltr';
                alert('Switched to English LTR mode. Check user widget position.');
            } else {
                document.documentElement.lang = 'ar';
                document.documentElement.dir = 'rtl';
                alert('تم التبديل للوضع العربي RTL. تحقق من موضع أداة المستخدم.');
            }
            
            // Reinitialize unified system with new language
            if (window.unifiedUserInfo) {
                const container = document.getElementById('unified-user-info');
                if (container) container.remove();
                
                setTimeout(() => {
                    window.unifiedUserInfo = new UnifiedUserInfoSystem();
                    updateSystemStatus();
                }, 100);
            }
        }
        
        function refreshUserData() {
            console.log('🔄 [UnifiedUserTest] Refreshing user data...');
            
            if (window.unifiedUserInfo) {
                window.unifiedUserInfo.refreshUserData();
                alert('User data refreshed successfully!');
                updateSystemStatus();
            } else {
                alert('Unified User Info System not found!');
            }
        }
        
        // Auto-update status every 5 seconds
        setInterval(updateSystemStatus, 5000);
    </script>
</asp:Content>
