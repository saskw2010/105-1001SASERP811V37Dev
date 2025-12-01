<%@ Page Language="VB" MasterPageFile="~/ModernMaster.master" AutoEventWireup="false" CodeFile="Index.aspx.vb" Inherits="TestPages_ASPX_Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Test Pages ASPX - فهرس صفحات الاختبار</title>
    <style>
        .test-index-container {
            padding: 2rem;
            max-width: 1200px;
            margin: 0 auto;
        }
        
        .page-header {
            text-align: center;
            margin-bottom: 3rem;
        }
        
        .page-header h1 {
            color: var(--primary-color, #2c3e50);
            font-size: 2.5rem;
            margin-bottom: 1rem;
        }
        
        .page-header p {
            color: var(--text-secondary, #666);
            font-size: 1.1rem;
        }
        
        .tests-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(350px, 1fr));
            gap: 2rem;
            margin-bottom: 3rem;
        }
        
        .test-card {
            background: var(--card-background, #fff);
            border-radius: 12px;
            padding: 1.5rem;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
            border: 1px solid var(--border-color, #e1e5e9);
            transition: all 0.3s ease;
        }
        
        .test-card:hover {
            transform: translateY(-4px);
            box-shadow: 0 8px 15px rgba(0,0,0,0.15);
        }
        
        .test-card h3 {
            color: var(--primary-color, #2c3e50);
            font-size: 1.3rem;
            margin-bottom: 0.5rem;
        }
        
        .test-card p {
            color: var(--text-secondary, #666);
            margin-bottom: 1rem;
            line-height: 1.5;
        }
        
        .test-card .test-link {
            display: inline-block;
            background: var(--primary-color, #3498db);
            color: white;
            padding: 0.8rem 1.5rem;
            border-radius: 8px;
            text-decoration: none;
            font-weight: 500;
            transition: all 0.3s ease;
        }
        
        .test-card .test-link:hover {
            background: var(--primary-dark, #2980b9);
            transform: translateY(-2px);
        }
        
        .test-date {
            font-size: 0.9rem;
            color: var(--text-muted, #999);
            margin-top: 0.5rem;
        }
        
        .stats-section {
            background: var(--secondary-background, #f8f9fa);
            padding: 2rem;
            border-radius: 12px;
            margin-bottom: 2rem;
        }
        
        .stats-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
            gap: 1rem;
        }
        
        .stat-item {
            text-align: center;
            padding: 1rem;
            background: white;
            border-radius: 8px;
            border: 1px solid var(--border-color, #e1e5e9);
        }
        
        .stat-number {
            font-size: 2rem;
            font-weight: bold;
            color: var(--primary-color, #3498db);
        }
        
        .stat-label {
            color: var(--text-secondary, #666);
            font-size: 0.9rem;
        }
        
        .navigation-links {
            text-align: center;
            margin-top: 2rem;
        }
        
        .navigation-links a {
            display: inline-block;
            margin: 0 1rem;
            padding: 0.8rem 1.5rem;
            background: var(--secondary-color, #95a5a6);
            color: white;
            text-decoration: none;
            border-radius: 8px;
            transition: all 0.3s ease;
        }
        
        .navigation-links a:hover {
            background: var(--secondary-dark, #7f8c8d);
            transform: translateY(-2px);
        }
        
        @media (max-width: 768px) {
            .tests-grid {
                grid-template-columns: 1fr;
            }
            
            .page-header h1 {
                font-size: 2rem;
            }
            
            .test-index-container {
                padding: 1rem;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2"  ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <div class="test-index-container">
        <!-- Page Header -->
        <div class="page-header">
            <h1>📊 فهرس صفحات اختبار ASPX</h1>
            <p>مجموعة شاملة من صفحات الاختبار والتطوير المختلفة</p>
        </div>
        
        <!-- Statistics Section -->
        <div class="stats-section">
            <h2 style="text-align: center; margin-bottom: 1.5rem; color: var(--primary-color, #2c3e50);">📈 إحصائيات الصفحات</h2>
            <div class="stats-grid">
                <div class="stat-item">
                    <div class="stat-number" id="totalPages">11</div>
                    <div class="stat-label">إجمالي الصفحات</div>
                </div>
                <div class="stat-item">
                    <div class="stat-number">5</div>
                    <div class="stat-label">صفحات اختبار</div>
                </div>
                <div class="stat-item">
                    <div class="stat-number">3</div>
                    <div class="stat-label">صفحات تحليل</div>
                </div>
                <div class="stat-item">
                    <div class="stat-number">3</div>
                    <div class="stat-label">صفحات حديثة</div>
                </div>
            </div>
        </div>
        
        <!-- Test Pages Grid -->
        <div class="tests-grid">
            <!-- Test Converter Page -->
            <div class="test-card">
                <h3>🔄 محول الاختبار</h3>
                <p>صفحة اختبار لتحويل وتقييم المكونات والعناصر المختلفة في النظام</p>
                <a href="test-converter.aspx" class="test-link">فتح الصفحة</a>
                <div class="test-date">تاريخ الإنشاء: 4 أغسطس 2025</div>
            </div>
            
            <!-- Conversion Status Page -->
            <div class="test-card">
                <h3>📊 حالة التحويل</h3>
                <p>متابعة حالة عمليات التحويل والتقدم في المعالجة</p>
                <a href="conversion-status.aspx" class="test-link">فتح الصفحة</a>
                <div class="test-date">تاريخ الإنشاء: 4 أغسطس 2025</div>
            </div>
            
            <!-- Resource Check Page -->
            <div class="test-card">
                <h3>🔍 فحص الموارد</h3>
                <p>فحص وتحليل الموارد المتاحة في النظام والتحقق من حالتها</p>
                <a href="resource-check.aspx" class="test-link">فتح الصفحة</a>
                <div class="test-date">تاريخ الإنشاء: 4 أغسطس 2025</div>
            </div>
            
            <!-- Unified User Test Page -->
            <div class="test-card">
                <h3>👤 اختبار المستخدم الموحد</h3>
                <p>اختبار شامل لوظائف المستخدم والأذونات في النظام</p>
                <a href="unified-user-test.aspx" class="test-link">فتح الصفحة</a>
                <div class="test-date">تاريخ الإنشاء: 4 أغسطس 2025</div>
            </div>
            
            <!-- Width Analysis Page -->
            <div class="test-card">
                <h3>📏 تحليل العرض</h3>
                <p>تحليل عرض الصفحات والعناصر واختبار التصميم المتجاوب</p>
                <a href="width-analysis.aspx" class="test-link">فتح الصفحة</a>
                <div class="test-date">تاريخ الإنشاء: 4 أغسطس 2025</div>
            </div>
            
            <!-- User Info Demo Page -->
            <div class="test-card">
                <h3>ℹ️ عرض معلومات المستخدم</h3>
                <p>صفحة عرض معلومات المستخدم والبيانات الشخصية</p>
                <a href="user-info-demo.aspx" class="test-link">فتح الصفحة</a>
                <div class="test-date">تاريخ الإنشاء: 5 أغسطس 2025</div>
            </div>
            
            <!-- Modern Test Page -->
            <div class="test-card">
                <h3>🎨 اختبار حديث</h3>
                <p>صفحة اختبار للتصميم الحديث والمكونات المتطورة</p>
                <a href="ModernTest.aspx" class="test-link">فتح الصفحة</a>
                <div class="test-date">تاريخ الإنشاء: 6 أغسطس 2025</div>
            </div>
            
            <!-- Full Width Test Page -->
            <div class="test-card">
                <h3>🖥️ اختبار العرض الكامل</h3>
                <p>اختبار التصميم بعرض كامل والتخطيط المتجاوب</p>
                <a href="full-width-test.aspx" class="test-link">فتح الصفحة</a>
                <div class="test-date">تاريخ الإنشاء: 6 أغسطس 2025</div>
            </div>
            
            <!-- Test Login Page -->
            <div class="test-card">
                <h3>🔐 اختبار تسجيل الدخول</h3>
                <p>صفحة اختبار نظام تسجيل الدخول والأذونات</p>
                <a href="TestLogin.aspx" class="test-link">فتح الصفحة</a>
                <div class="test-date">تاريخ الإنشاء: 6 أغسطس 2025</div>
            </div>
            
            <!-- Modern Test Page (Main) -->
            <div class="test-card">
                <h3>🚀 الصفحة الحديثة الرئيسية</h3>
                <p>الصفحة الرئيسية للاختبار الحديث مع جميع المكونات</p>
                <a href="ModernTestPage.aspx" class="test-link">فتح الصفحة</a>
                <div class="test-date">تاريخ الإنشاء: 6 أغسطس 2025</div>
            </div>
            
            <!-- Menu Demo Page -->
            <div class="test-card">
                <h3>📋 عرض القوائم المتقدم</h3>
                <p>صفحة عرض توضيحي لبناء القوائم المتقدمة مع تصميم متجاوب وتأثيرات تفاعلية</p>
                <a href="MenuDemo.aspx" class="test-link">فتح الصفحة</a>
                <div class="test-date">تاريخ الإنشاء: 5 أغسطس 2025</div>
            </div>
        </div>
        
        <!-- Navigation Links -->
        <div class="navigation-links">
            <a href="../HTML/Index.html">📄 صفحات HTML</a>
            <a href="../Index.html">🏠 الفهرس الرئيسي</a>
            <a href="../../Default.aspx">🏠 الصفحة الرئيسية</a>
        </div>
    </div>
    
    <script>
        document.addEventListener('DOMContentLoaded', function() {
            console.log('ASPX Test Pages Index loaded');
            
            // Add hover effects
            const cards = document.querySelectorAll('.test-card');
            cards.forEach(card => {
                card.addEventListener('mouseenter', function() {
                    this.style.borderColor = 'var(--primary-color, #3498db)';
                });
                
                card.addEventListener('mouseleave', function() {
                    this.style.borderColor = 'var(--border-color, #e1e5e9)';
                });
            });
            
            // Update page count dynamically
            const totalPagesElement = document.getElementById('totalPages');
            const actualCount = cards.length;
            if (totalPagesElement) {
                totalPagesElement.textContent = actualCount;
            }
        });
    </script>
</asp:Content>
