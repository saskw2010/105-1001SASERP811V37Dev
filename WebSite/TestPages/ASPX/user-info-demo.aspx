<%@ Page Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="user-info-demo.aspx.vb" Inherits="UserInfoDemo" %>

<asp:Content ID="ContentTitle" ContentPlaceHolderID="pageTitleContentPlaceHolder" Runat="Server">
    🚀 Advanced User Info System Demo - SASERP811V37
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .demo-container {
            padding: 40px;
            max-width: 1200px;
            margin: 0 auto;
        }

        .demo-header {
            text-align: center;
            margin-bottom: 40px;
        }

        .demo-header h1 {
            color: #2563eb;
            font-size: 2.5rem;
            margin-bottom: 10px;
            background: linear-gradient(135deg, #2563eb, #1d4ed8);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
        }

        .demo-features {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 20px;
            margin: 40px 0;
        }

        .feature-card {
            background: white;
            border-radius: 15px;
            padding: 25px;
            box-shadow: 0 8px 32px rgba(0, 0, 0, 0.1);
            border: 1px solid rgba(255, 255, 255, 0.2);
            transition: transform 0.3s ease;
        }

        .feature-card:hover {
            transform: translateY(-5px);
        }

        .feature-icon {
            color: #2563eb;
            font-size: 2rem;
            margin-bottom: 15px;
        }

        .instructions {
            background: linear-gradient(135deg, #f0f9ff 0%, #e0f2fe 100%);
            border-radius: 15px;
            padding: 30px;
            margin: 30px 0;
            border-left: 5px solid #2563eb;
        }

        .instructions h3 {
            color: #1e40af;
            margin-bottom: 15px;
        }

        .rtl-demo {
            direction: rtl;
            text-align: right;
            font-family: 'Cairo', Arial, sans-serif;
        }

        .language-toggle {
            text-align: center;
            margin: 30px 0;
        }

        .toggle-btn {
            background: linear-gradient(135deg, #2563eb 0%, #1d4ed8 100%);
            color: white;
            border: none;
            padding: 12px 24px;
            border-radius: 25px;
            cursor: pointer;
            font-weight: 600;
            transition: all 0.3s ease;
        }

        .toggle-btn:hover {
            transform: translateY(-2px);
            box-shadow: 0 8px 25px rgba(37, 99, 235, 0.3);
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <div class="demo-container">
        <div class="demo-header">
            <h1>🚀 نظام معلومات المستخدم المتطور</h1>
            <h2>Advanced Floating User Info System</h2>
            <p>نظام متطور لعرض معلومات المستخدم مع دعم RTL والتوسع Mega Menu</p>
        </div>

        <div class="instructions">
            <h3>📋 تعليمات الاستخدام - Usage Instructions</h3>
            <div class="rtl-demo">
                <p><strong>🌟 الميزات الجديدة:</strong></p>
                <ul>
                    <li>✅ نظام floating dropdown متطور بدعم RTL كامل</li>
                    <li>✅ positioning ذكي حسب اللغة (عربي = يسار، إنجليزي = يمين)</li>
                    <li>✅ Mega menu مع quick access وrecent activities</li>
                    <li>✅ معلومات النظام والجلسة في الوقت الفعلي</li>
                    <li>✅ تصميم احترافي مع animations وeffects</li>
                </ul>
            </div>
            
            <p><strong>🔥 How to Test:</strong></p>
            <ol>
                <li><strong>انظر لأعلى يمين/يسار الصفحة</strong> - Look at top right/left of page</li>
                <li><strong>اضغط على User Info Trigger</strong> - Click on the floating user trigger</li>
                <li><strong>اكتشف Mega Menu المتطور</strong> - Explore the advanced mega menu</li>
                <li><strong>جرب Quick Actions</strong> - Try the quick action buttons</li>
                <li><strong>غير اللغة واختبر RTL</strong> - Change language and test RTL</li>
            </ol>
        </div>

        <div class="demo-features">
            <div class="feature-card">
                <div class="feature-icon">🌐</div>
                <h3>RTL Language Support</h3>
                <p>دعم كامل للغة العربية مع positioning ذكي حسب اتجاه اللغة. النظام يتكيف تلقائياً مع العربية والإنجليزية.</p>
            </div>

            <div class="feature-card">
                <div class="feature-icon">⚡</div>
                <h3>Quick Access Actions</h3>
                <p>وصول سريع للوظائف المهمة: الملف الشخصي، الإعدادات، الإشعارات، والمساعدة مع notification badges.</p>
            </div>

            <div class="feature-card">
                <div class="feature-icon">📊</div>
                <h3>System Information</h3>
                <p>عرض معلومات النظام والجلسة: وقت الدخول، Session ID، اللغة الحالية، والصلاحيات.</p>
            </div>

            <div class="feature-card">
                <div class="feature-icon">🎨</div>
                <h3>Modern Design</h3>
                <p>تصميم عصري مع glassmorphism، gradients، animations، وdark mode support للمظهر الاحترافي.</p>
            </div>

            <div class="feature-card">
                <div class="feature-icon">📱</div>
                <h3>Responsive Layout</h3>
                <p>تصميم متجاوب يعمل على جميع الشاشات من الهواتف إلى أجهزة الكمبيوتر المكتبية.</p>
            </div>

            <div class="feature-card">
                <div class="feature-icon">🔄</div>
                <h3>Dynamic Integration</h3>
                <p>تكامل مع ASP.NET Membership System ويخفي membership_login div القديم تلقائياً.</p>
            </div>
        </div>

        <div class="language-toggle">
            <button class="toggle-btn" onclick="toggleDemoLanguage()">
                🌍 Toggle Language / تبديل اللغة
            </button>
        </div>

        <div class="instructions">
            <h3>🛠️ Technical Implementation</h3>
            <div>
                <p><strong>🔧 System Integration:</strong></p>
                <ul>
                    <li>✅ <strong>Main.master</strong> updated with user-info-floating.js</li>
                    <li>✅ <strong>Automatic detection</strong> of existing membership_login div</li>
                    <li>✅ <strong>Language detection</strong> from document.documentElement.lang</li>
                    <li>✅ <strong>RTL positioning</strong> based on dir="rtl" attribute</li>
                    <li>✅ <strong>ASP.NET integration</strong> with membership system</li>
                </ul>
                
                <p><strong>🎯 Key Features Implemented:</strong></p>
                <ul>
                    <li>🚀 <code>FloatingUserInfoSystem</code> class with full RTL support</li>
                    <li>⚡ Mega menu expansion with quick actions grid</li>
                    <li>📊 Real-time system information display</li>
                    <li>🎨 Modern CSS with glassmorphism and neural gradients</li>
                    <li>📱 Responsive design for all screen sizes</li>
                    <li>🌙 Dark mode support with media queries</li>
                </ul>
            </div>
        </div>
    </div>

    <script>
        function toggleDemoLanguage() {
            const html = document.documentElement;
            const currentLang = html.lang;
            const currentDir = html.dir;
            
            if (currentLang.includes('ar') || currentDir === 'rtl') {
                html.lang = 'en';
                html.dir = 'ltr';
                alert('Language changed to English. User dropdown will appear on the right.');
            } else {
                html.lang = 'ar';
                html.dir = 'rtl';
                alert('تم تغيير اللغة إلى العربية. قائمة المستخدم ستظهر على اليسار.');
            }
            
            // Recreate floating user info with new language
            if (window.floatingUserInfo) {
                const container = document.getElementById('floating-user-info');
                if (container) container.remove();
                
                setTimeout(() => {
                    window.floatingUserInfo = new FloatingUserInfoSystem();
                }, 100);
            }
        }

        // Demo helper to show membership_login div status
        document.addEventListener('DOMContentLoaded', function() {
            setTimeout(() => {
                const membershipDiv = document.getElementById('membership_login') || 
                                    document.querySelector('[id*="membership"]');
                
                if (membershipDiv) {
                    console.log('✅ membership_login div found and hidden:', membershipDiv);
                    console.log('✅ Display style:', window.getComputedStyle(membershipDiv).display);
                } else {
                    console.log('ℹ️ No membership_login div found (this is normal)');
                }
                
                console.log('🚀 Floating User Info System initialized');
                console.log('🌍 Current language:', document.documentElement.lang);
                console.log('📍 Current direction:', document.documentElement.dir);
            }, 1000);
        });
    </script>
</asp:Content>
