<%@ Page Title="Test Menu Levels" Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="TestMenuLevels.aspx.vb" Inherits="Pages_TestMenuLevels" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageHeaderContentPlaceHolder" Runat="Server">
    <style>
        .test-container {
            padding: 20px;
            max-width: 1200px;
            margin: 0 auto;
            font-family: 'Segoe UI', Tahoma, Arial, sans-serif;
            direction: rtl;
        }
        
        .test-header {
            background: linear-gradient(135deg, #1a237e, #0d47a1);
            color: white;
            padding: 20px;
            border-radius: 8px;
            margin-bottom: 20px;
            text-align: center;
        }
        
        .test-section {
            background: white;
            border: 1px solid #e0e0e0;
            border-radius: 8px;
            padding: 20px;
            margin-bottom: 20px;
            box-shadow: 0 2px 4px rgba(0,0,0,0.1);
        }
        
        .test-section h3 {
            color: #1a237e;
            border-bottom: 2px solid #2962ff;
            padding-bottom: 10px;
            margin-bottom: 15px;
        }
        
        .menu-info {
            background: #f5f5f5;
            padding: 15px;
            border-radius: 5px;
            margin: 10px 0;
            border-left: 4px solid #2962ff;
        }
        
        .level-indicator {
            display: inline-block;
            padding: 4px 8px;
            border-radius: 4px;
            font-size: 12px;
            font-weight: bold;
            margin-left: 10px;
        }
        
        .level-0 { background: #e3f2fd; color: #0d47a1; }
        .level-1 { background: #e8f5e8; color: #2e7d32; }
        .level-2 { background: #fff3e0; color: #ef6c00; }
        
        .instructions {
            background: #e3f2fd;
            border: 1px solid #2196f3;
            border-radius: 8px;
            padding: 15px;
            margin: 20px 0;
        }
        
        .instructions h4 {
            color: #1976d2;
            margin-top: 0;
        }
        
        .test-button {
            background: #2962ff;
            color: white;
            border: none;
            padding: 10px 20px;
            border-radius: 5px;
            cursor: pointer;
            font-size: 14px;
            margin: 5px;
        }
        
        .test-button:hover {
            background: #1a237e;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <div class="test-container">
        <div class="test-header">
            <h1>🔍 اختبار هيكل القائمة ثلاثية المستويات</h1>
            <p>صفحة اختبار للتحقق من عمل القائمة الجانبية بثلاثة مستويات</p>
        </div>

        <div class="instructions">
            <h4>📋 تعليمات الاختبار:</h4>
            <ol>
                <li>اضغط على زر القائمة الجانبية (☰) في أعلى الصفحة</li>
                <li>ابحث عن العناصر التي تحتوي على مستويات فرعية</li>
                <li>تحقق من إمكانية توسيع المستوى الثاني والثالث</li>
                <li>تأكد من ظهور المسافات البادئة للمستويات المختلفة</li>
            </ol>
        </div>

        <div class="test-section">
            <h3>🏗️ هيكل القائمة المتوقع</h3>
            
            <div class="menu-info">
                <strong>مثال 1: إدارة المستخدمين</strong>
                <span class="level-indicator level-0">المستوى 0</span>
                <br>
                <div style="margin-right: 20px; margin-top: 10px;">
                    ↳ Membership <span class="level-indicator level-0">المستوى 0</span>
                    <div style="margin-right: 20px; margin-top: 5px;">
                        ↳ Other Tools <span class="level-indicator level-1">المستوى 1</span>
                        <div style="margin-right: 20px; margin-top: 5px;">
                            ↳ vwaspnet Users In Roles <span class="level-indicator level-2">المستوى 2</span><br>
                            ↳ vwaspnet Roles <span class="level-indicator level-2">المستوى 2</span><br>
                            ↳ Asp Net Users <span class="level-indicator level-2">المستوى 2</span>
                        </div>
                    </div>
                </div>
            </div>

            <div class="menu-info">
                <strong>مثال 2: الموقع الشخصي</strong>
                <span class="level-indicator level-0">المستوى 0</span>
                <br>
                <div style="margin-right: 20px; margin-top: 10px;">
                    ↳ My Site <span class="level-indicator level-0">المستوى 0</span>
                    <div style="margin-right: 20px; margin-top: 5px;">
                        ↳ Elmah <span class="level-indicator level-1">المستوى 1</span>
                        <div style="margin-right: 20px; margin-top: 5px;">
                            ↳ Ticket Attachments <span class="level-indicator level-2">المستوى 2</span><br>
                            ↳ Ticket Comments <span class="level-indicator level-2">المستوى 2</span><br>
                            ↳ Tickets <span class="level-indicator level-2">المستوى 2</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="test-section">
            <h3>✅ نقاط التحقق</h3>
            <ul>
                <li><strong>المستوى 0:</strong> العناصر الرئيسية بدون مسافة بادئة</li>
                <li><strong>المستوى 1:</strong> العناصر الفرعية مع مسافة بادئة 40px</li>
                <li><strong>المستوى 2:</strong> العناصر الفرعية من المستوى الثاني مع مسافة بادئة 60px</li>
                <li><strong>الأيقونات:</strong> تظهر أسهم التوسيع/الطي للعناصر التي تحتوي على عناصر فرعية</li>
                <li><strong>التفاعل:</strong> إمكانية النقر لتوسيع وطي المستويات</li>
            </ul>
        </div>

        <div class="test-section">
            <h3>🔧 أدوات الاختبار</h3>
            <button class="test-button" onclick="testMenuStructure()">اختبار هيكل القائمة</button>
            <button class="test-button" onclick="showMenuData()">عرض بيانات القائمة</button>
            <button class="test-button" onclick="checkMenuLevels()">فحص المستويات</button>
            
            <div id="testResults" style="margin-top: 20px; padding: 15px; background: #f9f9f9; border-radius: 5px; display: none;">
                <h4>نتائج الاختبار:</h4>
                <div id="testOutput"></div>
            </div>
        </div>
    </div>

    <script>
        function testMenuStructure() {
            const results = document.getElementById('testResults');
            const output = document.getElementById('testOutput');
            
            results.style.display = 'block';
            output.innerHTML = '<p>🔄 جاري اختبار هيكل القائمة...</p>';
            
            setTimeout(() => {
                let testResults = [];
                
                // Check if menu data is available
                const menuDataElement = document.querySelector('[id$="hdnMenuData"]');
                if (menuDataElement && menuDataElement.value) {
                    try {
                        const menuData = JSON.parse(menuDataElement.value);
                        testResults.push(`✅ تم العثور على ${menuData.length} عنصر رئيسي في القائمة`);
                        
                        let level1Count = 0;
                        let level2Count = 0;
                        
                        menuData.forEach(item => {
                            if (item.children && item.children.length > 0) {
                                level1Count += item.children.length;
                                item.children.forEach(child => {
                                    if (child.children && child.children.length > 0) {
                                        level2Count += child.children.length;
                                    }
                                });
                            }
                        });
                        
                        testResults.push(`✅ تم العثور على ${level1Count} عنصر من المستوى الأول`);
                        testResults.push(`✅ تم العثور على ${level2Count} عنصر من المستوى الثاني`);
                        
                        if (level2Count > 0) {
                            testResults.push(`🎉 القائمة تدعم 3 مستويات بنجاح!`);
                        } else {
                            testResults.push(`⚠️ لم يتم العثور على عناصر من المستوى الثاني`);
                        }
                        
                    } catch (e) {
                        testResults.push(`❌ خطأ في تحليل بيانات القائمة: ${e.message}`);
                    }
                } else {
                    testResults.push(`❌ لم يتم العثور على بيانات القائمة`);
                }
                
                output.innerHTML = testResults.map(result => `<p>${result}</p>`).join('');
            }, 1000);
        }
        
        function showMenuData() {
            const results = document.getElementById('testResults');
            const output = document.getElementById('testOutput');
            
            results.style.display = 'block';
            
            const menuDataElement = document.querySelector('[id$="hdnMenuData"]');
            if (menuDataElement && menuDataElement.value) {
                try {
                    const menuData = JSON.parse(menuDataElement.value);
                    output.innerHTML = `<pre style="background: #f5f5f5; padding: 10px; border-radius: 5px; overflow: auto; max-height: 400px;">${JSON.stringify(menuData, null, 2)}</pre>`;
                } catch (e) {
                    output.innerHTML = `<p>❌ خطأ في عرض البيانات: ${e.message}</p>`;
                }
            } else {
                output.innerHTML = `<p>❌ لا توجد بيانات قائمة متاحة</p>`;
            }
        }
        
        function checkMenuLevels() {
            const results = document.getElementById('testResults');
            const output = document.getElementById('testOutput');
            
            results.style.display = 'block';
            output.innerHTML = '<p>🔄 جاري فحص مستويات القائمة...</p>';
            
            setTimeout(() => {
                const menuItems = document.querySelectorAll('.nav-menu-item');
                let levelCounts = { 0: 0, 1: 0, 2: 0, 3: 0 };
                
                menuItems.forEach(item => {
                    for (let level = 0; level <= 3; level++) {
                        if (item.classList.contains(`level-${level}`)) {
                            levelCounts[level]++;
                            break;
                        }
                    }
                });
                
                let levelResults = [];
                for (let level = 0; level <= 3; level++) {
                    if (levelCounts[level] > 0) {
                        levelResults.push(`المستوى ${level}: ${levelCounts[level]} عنصر`);
                    }
                }
                
                if (levelResults.length > 0) {
                    output.innerHTML = `<h5>📊 إحصائيات المستويات:</h5>${levelResults.map(r => `<p>✅ ${r}</p>`).join('')}`;
                } else {
                    output.innerHTML = `<p>⚠️ لم يتم العثور على عناصر قائمة مرئية. تأكد من فتح القائمة الجانبية أولاً.</p>`;
                }
            }, 1000);
        }
        
        // Auto-run test on page load
        document.addEventListener('DOMContentLoaded', function() {
            setTimeout(testMenuStructure, 2000);
        });
    </script>
</asp:Content>
