<%@ Page Language="VB" AutoEventWireup="false" %>
<%@ Import Namespace="System.IO" %>

<!DOCTYPE html>
<html lang="ar" dir="rtl">
<head runat="server">
    <title>📋 فهرس صفحات الاختبار - SASERP V37</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    
    <style>
        body { 
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; 
            margin: 0; padding: 20px; background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); 
            min-height: 100vh; color: #333;
        }
        .container { 
            max-width: 1200px; margin: 0 auto; background: rgba(255,255,255,0.95); 
            padding: 30px; border-radius: 15px; box-shadow: 0 10px 30px rgba(0,0,0,0.3); 
        }
        h1 { 
            color: #2c3e50; text-align: center; margin-bottom: 10px; 
            text-shadow: 2px 2px 4px rgba(0,0,0,0.1); 
        }
        .subtitle { 
            text-align: center; color: #7f8c8d; margin-bottom: 30px; 
            font-size: 18px; 
        }
        .section { 
            margin: 30px 0; padding: 20px; border-radius: 10px; 
            box-shadow: 0 4px 6px rgba(0,0,0,0.1); 
        }
        .section.aspx { background: linear-gradient(135deg, #74b9ff, #0984e3); color: white; }
        .section.html { background: linear-gradient(135deg, #fd79a8, #e84393); color: white; }
        .section.system { background: linear-gradient(135deg, #55a3ff, #3742fa); color: white; }
        .section h2 { margin-top: 0; display: flex; align-items: center; }
        .section h2 i { margin-left: 10px; font-size: 24px; }
        .links-grid { 
            display: grid; grid-template-columns: repeat(auto-fit, minmax(300px, 1fr)); 
            gap: 15px; margin-top: 20px; 
        }
        .link-card { 
            background: rgba(255,255,255,0.2); padding: 15px; border-radius: 8px; 
            transition: all 0.3s ease; cursor: pointer; 
        }
        .link-card:hover { 
            background: rgba(255,255,255,0.3); transform: translateY(-2px); 
        }
        .link-card h3 { margin: 0 0 10px 0; font-size: 16px; }
        .link-card p { margin: 0; font-size: 14px; opacity: 0.9; }
        .link-card .url { 
            font-family: 'Courier New', monospace; font-size: 12px; 
            background: rgba(0,0,0,0.2); padding: 5px; border-radius: 4px; 
            margin-top: 10px; 
        }
        .stats { 
            display: grid; grid-template-columns: repeat(auto-fit, minmax(200px, 1fr)); 
            gap: 20px; margin: 30px 0; 
        }
        .stat-card { 
            background: linear-gradient(135deg, #00b894, #00a085); color: white; 
            padding: 20px; border-radius: 10px; text-align: center; 
        }
        .stat-number { font-size: 36px; font-weight: bold; display: block; }
        .stat-label { font-size: 14px; opacity: 0.9; }
        .footer { 
            text-align: center; margin-top: 40px; padding: 20px; 
            background: rgba(52, 73, 94, 0.1); border-radius: 10px; 
        }
        .test-links { 
            display: flex; flex-wrap: wrap; gap: 10px; justify-content: center; 
            margin-top: 20px; 
        }
        .test-btn { 
            padding: 10px 20px; background: #3498db; color: white; 
            text-decoration: none; border-radius: 5px; transition: all 0.3s ease; 
        }
        .test-btn:hover { background: #2980b9; transform: scale(1.05); }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>📋 فهرس صفحات النظام</h1>
            <p class="subtitle">SASERP V37 - مراجعة شاملة للصفحات المتاحة</p>
            
            <div class="stats">
                <div class="stat-card">
                    <span class="stat-number" id="aspx-count">0</span>
                    <span class="stat-label">صفحات ASPX</span>
                </div>
                <div class="stat-card">
                    <span class="stat-number" id="html-count">0</span>
                    <span class="stat-label">صفحات HTML</span>
                </div>
                <div class="stat-card">
                    <span class="stat-number" id="total-count">0</span>
                    <span class="stat-label">إجمالي الصفحات</span>
                </div>
            </div>

            <!-- صفحات ASPX -->
            <div class="section aspx">
                <h2>🌐 صفحات ASP.NET (.aspx)</h2>
                <div class="links-grid" id="aspx-links">
                    <!-- سيتم ملؤها بواسطة JavaScript -->
                </div>
            </div>

            <!-- صفحات HTML -->
            <div class="section html">
                <h2>📄 صفحات HTML</h2>
                <div class="links-grid" id="html-links">
                    <!-- سيتم ملؤها بواسطة JavaScript -->
                </div>
            </div>

            <!-- روابط النظام -->
            <div class="section system">
                <h2>⚡ اختبار النظام الهرمي</h2>
                <div class="test-links">
                    <a href="#" class="test-btn" onclick="testMainMaster()">اختبار mainmaster</a>
                    <a href="#" class="test-btn" onclick="testQuickNav()">اختبار QuickNav</a>
                    <a href="#" class="test-btn" onclick="testNavigation()">اختبار التنقل</a>
                    <a href="#" class="test-btn" onclick="openConsole()">فتح Console</a>
                </div>
            </div>

            <div class="footer">
                <p><strong>📝 ملاحظة:</strong> جميع الصفحات المعروضة موجودة فعلياً في النظام</p>
                <p><strong>🎯 التقنية:</strong> ASP.NET 4.7.2 Framework</p>
                <p><strong>📅 آخر تحديث:</strong> <span id="last-update"></span></p>
            </div>
        </div>
    </form>

    <!-- تحميل ملفات النظام -->
    <script src="../js/mainmaster-simple.js"></script>
    <script src="../js/saserp-links-reference.js"></script>

    <script>
        // قائمة الصفحات المتاحة
        const availablePages = {
            aspx: [
                {
                    name: 'SystemLinksGuide.aspx',
                    title: 'دليل الروابط الشامل',
                    description: 'دليل تفاعلي لجميع روابط النظام مع أمثلة وشرح مفصل',
                    path: '~/TestPages/SystemLinksGuide.aspx'
                },
                {
                    name: 'NavigationExample.aspx',
                    title: 'مثال نظام التنقل',
                    description: 'عرض توضيحي للقائمة الموحدة ونظام التنقل',
                    path: '~/TestPages/NavigationExample.aspx'
                },
                {
                    name: 'TestDashboardData.aspx',
                    title: 'بيانات لوحة التحكم',
                    description: 'عرض بيانات Dashboard مع WebMethods و JSON',
                    path: '~/TestPages/TestDashboardData.aspx'
                }
            ],
            html: [
                {
                    name: 'HierarchyTest.html',
                    title: 'اختبار النظام الهرمي',
                    description: 'اختبار شامل لنظام mainmaster.pages.*.*',
                    path: '~/TestPages/HierarchyTest.html'
                },
                {
                    name: 'QuickSystemTest.html',
                    title: 'اختبار النظام السريع',
                    description: 'فحص سريع لجميع مكونات النظام',
                    path: '~/TestPages/QuickSystemTest.html'
                },
                {
                    name: 'LinksTestingPage.html',
                    title: 'صفحة اختبار الروابط',
                    description: 'اختبار تفاعلي لجميع الروابط مع أدوات التشخيص',
                    path: '~/TestPages/LinksTestingPage.html'
                },
                {
                    name: 'theme-center-index.html',
                    title: 'مركز الثيمات',
                    description: 'إدارة وتبديل ثيمات النظام',
                    path: '~/TestPages/theme-center-index.html'
                }
            ]
        };

        // ملء الصفحات
        function populatePages() {
            const aspxContainer = document.getElementById('aspx-links');
            const htmlContainer = document.getElementById('html-links');

            // صفحات ASPX
            availablePages.aspx.forEach(page => {
                const card = createPageCard(page);
                aspxContainer.appendChild(card);
            });

            // صفحات HTML
            availablePages.html.forEach(page => {
                const card = createPageCard(page);
                htmlContainer.appendChild(card);
            });

            // تحديث الإحصائيات
            document.getElementById('aspx-count').textContent = availablePages.aspx.length;
            document.getElementById('html-count').textContent = availablePages.html.length;
            document.getElementById('total-count').textContent = availablePages.aspx.length + availablePages.html.length;
        }

        // إنشاء بطاقة صفحة
        function createPageCard(page) {
            const card = document.createElement('div');
            card.className = 'link-card';
            card.onclick = () => window.open(page.path.replace('~/', '../'), '_blank');
            
            card.innerHTML = `
                <h3>${page.title}</h3>
                <p>${page.description}</p>
                <div class="url">${page.path}</div>
            `;
            
            return card;
        }

        // دوال الاختبار
        function testMainMaster() {
            if (typeof mainmaster !== 'undefined') {
                console.log('✅ mainmaster متاح:', mainmaster);
                alert('✅ mainmaster يعمل بشكل صحيح - راجع Console للتفاصيل');
            } else {
                alert('❌ mainmaster غير متاح');
            }
        }

        function testQuickNav() {
            if (typeof QuickNav !== 'undefined') {
                console.log('✅ QuickNav متاح:', QuickNav);
                alert(`✅ QuickNav يعمل مع ${Object.keys(QuickNav).length} دالة`);
            } else {
                alert('❌ QuickNav غير متاح');
            }
        }

        function testNavigation() {
            if (typeof mainmaster !== 'undefined' && mainmaster.pages) {
                console.log('✅ نظام التنقل متاح');
                // تجربة التنقل
                console.log('🧪 اختبار mainmaster.pages.test.hierarchyTest');
                alert('✅ نظام التنقل يعمل - راجع Console');
            } else {
                alert('❌ نظام التنقل غير متاح');
            }
        }

        function openConsole() {
            alert('اضغط F12 لفتح Developer Console واختبار الأوامر التالية:\n\n' +
                  'mainmaster.pages.test.hierarchyTest()\n' +
                  'QuickNav.systemInfo()\n' +
                  'QuickNav.linksGuide()');
        }

        // تهيئة الصفحة
        window.addEventListener('load', function() {
            populatePages();
            document.getElementById('last-update').textContent = new Date().toLocaleString('ar-SA');
            
            // اختبار النظام
            setTimeout(() => {
                if (typeof mainmaster !== 'undefined') {
                    console.log('🎉 النظام محمل بنجاح');
                }
            }, 1000);
        });
    </script>
</body>
</html>
