<%@ Page Language="VB" MasterPageFile="~/ModernMaster.master" AutoEventWireup="false" CodeFile="Index.aspx.vb" Inherits="TestPages_ASPXadv_Index" Title="Advanced ASPX Pages Index - فهرس الصفحات المتقدمة" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta charset="UTF-8">
    <meta name="description" content="فهرس شامل للصفحات المتقدمة في النظام - Advanced ASPX Pages Index">
    <meta name="keywords" content="ASPX, Advanced Pages, Financial Analysis, Dashboard, Customer Statement, Trial Balance">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
    <style>
        /* Ensure navigation menu is visible - CRITICAL FIX */
        .modern-navigation {
            position: relative !important;
            z-index: 1000 !important;
            display: block !important;
            visibility: visible !important;
            background: linear-gradient(135deg, #2563eb, #3b82f6) !important;
            border-top: 1px solid rgba(255, 255, 255, 0.1) !important;
        }
        
        .modern-header {
            position: relative !important;
            z-index: 999 !important;
            display: block !important;
            visibility: visible !important;
        }
        
        .modern-menu-wrapper {
            display: block !important;
            visibility: visible !important;
        }
        
        #PageMenuBar {
            display: block !important;
            visibility: visible !important;
        }
        
        .nav-container {
            max-width: 1400px !important;
            margin: 0 auto !important;
            padding: 0 2rem !important;
        }
        
        .aspx-index-container {
            max-width: 1400px;
            margin: 0 auto;
            padding: 2rem;
            margin-top: 3rem; /* Increased space for navigation menu */
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            direction: rtl;
            text-align: right;
            position: relative;
            z-index: 1; /* Lower z-index than navigation */
        }
        
        /* Emoji support for better icon display */
        .category-icon, .page-icon, .stat-card, .hero-title, .breadcrumb, .action-btn {
            font-family: 'Segoe UI Emoji', 'Segoe UI Symbol', 'Apple Color Emoji', 'Twemoji Mozilla', 'Noto Color Emoji', sans-serif;
        }
        
        /* Fix for icon alignment in RTL */
        .page-link {
            direction: rtl;
            text-align: right;
        }
        
        .hero-section {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            padding: 3rem 2rem;
            border-radius: 20px;
            margin-bottom: 3rem;
            text-align: center;
            box-shadow: 0 10px 30px rgba(0,0,0,0.2);
        }
        
        .hero-title {
            font-size: 3rem;
            font-weight: 700;
            margin-bottom: 1rem;
            text-shadow: 2px 2px 4px rgba(0,0,0,0.3);
        }
        
        .hero-subtitle {
            font-size: 1.2rem;
            opacity: 0.9;
            margin-bottom: 2rem;
        }
        
        .stats-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
            gap: 1rem;
            margin-top: 2rem;
        }
        
        .stat-card {
            background: rgba(255,255,255,0.1);
            padding: 1.5rem;
            border-radius: 15px;
            text-align: center;
            backdrop-filter: blur(10px);
        }
        
        .stat-number {
            font-size: 2.5rem;
            font-weight: bold;
            display: block;
        }
        
        .stat-label {
            font-size: 0.9rem;
            opacity: 0.8;
        }
        
        .categories-section {
            margin-bottom: 3rem;
        }
        
        .section-title {
            font-size: 2.5rem;
            color: #2c3e50;
            margin-bottom: 2rem;
            text-align: center;
            position: relative;
        }
        
        .section-title::after {
            content: '';
            position: absolute;
            bottom: -10px;
            left: 50%;
            transform: translateX(-50%);
            width: 100px;
            height: 4px;
            background: linear-gradient(135deg, #667eea, #764ba2);
            border-radius: 2px;
        }
        
        .category-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(400px, 1fr));
            gap: 2rem;
            margin-bottom: 3rem;
        }
        
        .category-card {
            background: white;
            border-radius: 20px;
            padding: 2rem;
            box-shadow: 0 8px 25px rgba(0,0,0,0.1);
            border: 1px solid #e1e5e9;
            transition: all 0.3s ease;
            position: relative;
            overflow: hidden;
        }
        
        .category-card::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            height: 6px;
        }
        
        .category-card.financial::before {
            background: linear-gradient(135deg, #667eea, #764ba2);
        }
        
        .category-card.customer::before {
            background: linear-gradient(135deg, #f093fb, #f5576c);
        }
        
        .category-card.dashboard::before {
            background: linear-gradient(135deg, #4facfe, #00f2fe);
        }
        
        .category-card:hover {
            transform: translateY(-8px);
            box-shadow: 0 15px 35px rgba(0,0,0,0.15);
        }
        
        .category-icon {
            font-size: 3rem;
            margin-bottom: 1rem;
            display: block;
            text-align: center;
            font-family: 'Segoe UI Emoji', 'Segoe UI Symbol', 'Apple Color Emoji', sans-serif;
        }
        
        .category-title {
            font-size: 1.8rem;
            color: #2c3e50;
            margin-bottom: 1rem;
            font-weight: 600;
        }
        
        .category-description {
            color: #666;
            margin-bottom: 1.5rem;
            line-height: 1.6;
        }
        
        .pages-list {
            list-style: none;
            padding: 0;
            margin: 0;
        }
        
        .page-item {
            margin-bottom: 0.8rem;
        }
        
        .page-link {
            display: flex;
            align-items: center;
            padding: 1rem;
            background: #f8f9fa;
            border-radius: 12px;
            text-decoration: none;
            color: #2c3e50;
            transition: all 0.3s ease;
            border: 1px solid #e9ecef;
        }
        
        .page-link:hover {
            background: #667eea;
            color: white;
            transform: translateX(-5px);
            box-shadow: 0 4px 15px rgba(102, 126, 234, 0.3);
        }
        
        .page-icon {
            font-size: 1.3rem;
            margin-left: 1rem;
            margin-right: 0;
            width: 30px;
            display: inline-block;
            text-align: center;
            font-family: 'Segoe UI Emoji', 'Segoe UI Symbol', 'Apple Color Emoji', sans-serif;
        }
        
        .page-title {
            font-weight: 500;
            flex: 1;
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        
        .page-status {
            font-size: 0.8rem;
            padding: 0.3rem 0.8rem;
            border-radius: 15px;
            font-weight: 500;
        }
        
        .status-active {
            background: #d4edda;
            color: #155724;
        }
        
        .status-new {
            background: #cce5ff;
            color: #0066cc;
        }
        
        .status-fixed {
            background: #fff3cd;
            color: #856404;
        }
        
        .quick-actions {
            display: flex;
            gap: 1rem;
            margin-bottom: 2rem;
            flex-wrap: wrap;
        }
        
        .action-btn {
            padding: 1rem 2rem;
            background: linear-gradient(135deg, #667eea, #764ba2);
            color: white;
            border: none;
            border-radius: 25px;
            font-weight: 500;
            text-decoration: none;
            cursor: pointer;
            transition: all 0.3s ease;
            box-shadow: 0 4px 15px rgba(0,0,0,0.1);
        }
        
        .action-btn:hover {
            transform: translateY(-2px);
            box-shadow: 0 6px 20px rgba(0,0,0,0.2);
            color: white;
        }
        
        .breadcrumb {
            background: #f8f9fa;
            padding: 1rem 1.5rem;
            border-radius: 10px;
            margin-bottom: 2rem;
        }
        
        .breadcrumb-link {
            color: #667eea;
            text-decoration: none;
            font-weight: 500;
        }
        
        .breadcrumb-link:hover {
            text-decoration: underline;
        }
        
        .search-box {
            background: white;
            padding: 1.5rem;
            border-radius: 15px;
            margin-bottom: 2rem;
            box-shadow: 0 4px 15px rgba(0,0,0,0.1);
        }
        
        .search-input {
            width: 100%;
            padding: 1rem;
            border: 2px solid #e9ecef;
            border-radius: 10px;
            font-size: 1rem;
            transition: all 0.3s ease;
        }
        
        .search-input:focus {
            border-color: #667eea;
            outline: none;
            box-shadow: 0 0 0 3px rgba(102, 126, 234, 0.1);
        }
        
        @media (max-width: 768px) {
            .hero-title {
                font-size: 2rem;
            }
            
            .category-grid {
                grid-template-columns: 1fr;
            }
            
            .quick-actions {
                flex-direction: column;
            }
            
            .aspx-index-container {
                padding: 1rem;
            }
        }
        
        .fade-in {
            animation: fadeIn 0.6s ease-in;
        }
        
        @keyframes fadeIn {
            from { opacity: 0; transform: translateY(20px); }
            to { opacity: 1; transform: translateY(0); }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageHeaderContentPlaceHolder" Runat="Server">
    📋 فهرس الصفحات المتقدمة - Advanced ASPX Pages Index
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <div class="aspx-index-container">
        <!-- Breadcrumb -->
        <nav class="breadcrumb">
            <a href="../../Default.aspx" class="breadcrumb-link">🏠 الرئيسية</a> / 
            <a href="../Index.html" class="breadcrumb-link">📂 صفحات الاختبار</a> / 
            <span>📋 الصفحات المتقدمة</span>
        </nav>

        <!-- Hero Section -->
        <div class="hero-section fade-in">
            <h1 class="hero-title">📋 فهرس الصفحات المتقدمة</h1>
            <p class="hero-subtitle">Advanced ASPX Pages Index - مجموعة شاملة من الصفحات المتقدمة للتحليل المالي ولوحات التحكم</p>
            
            <div class="stats-grid">
                <div class="stat-card">
                    <span class="stat-number">12</span>
                    <span class="stat-label">إجمالي الصفحات</span>
                </div>
                <div class="stat-card">
                    <span class="stat-number">4</span>
                    <span class="stat-label">فئات رئيسية</span>
                </div>
                <div class="stat-card">
                    <span class="stat-number">100%</span>
                    <span class="stat-label">جاهز للاستخدام</span>
                </div>
                <div class="stat-card">
                    <span class="stat-number">VB.NET</span>
                    <span class="stat-label">التقنية</span>
                </div>
            </div>
        </div>

        <!-- Quick Actions -->
        <div class="quick-actions">
            <a href="../Index.html" class="action-btn">🔙 العودة للفهرس الرئيسي</a>
            <a href="#financial" class="action-btn">📊 التحليل المالي</a>
            <a href="#customer" class="action-btn">👥 كشوف العملاء</a>
            <a href="#dashboard" class="action-btn">📈 لوحات التحكم</a>
        </div>

        <!-- Search Box -->
        <div class="search-box">
            <input type="text" id="searchInput" class="search-input" placeholder="🔍 البحث في الصفحات... (اكتب اسم الصفحة أو الوظيفة)">
        </div>

        <!-- Categories Section -->
        <div class="categories-section">
            <h2 class="section-title">📂 الفئات الرئيسية</h2>
            
            <div class="category-grid">
                <!-- Financial Analysis Category -->
                <div class="category-card financial" id="financial">
                    <span class="category-icon">📊</span>
                    <h3 class="category-title">التحليل المالي المتقدم</h3>
                    <p class="category-description">
                        مجموعة من صفحات التحليل المالي المتقدم مع إصدارات محسنة ومُحدثة لتحليل البيانات المالية بدقة عالية.
                    </p>
                    
                    <ul class="pages-list">
                        <li class="page-item">
                            <a href="FinancialAnalysisPro.aspx" class="page-link">
                                <span class="page-icon">📈</span>
                                <span class="page-title">التحليل المالي الاحترافي</span>
                                <span class="page-status status-active">نشط</span>
                            </a>
                        </li>
                        <li class="page-item">
                            <a href="FinancialAnalysisProFixed.aspx" class="page-link">
                                <span class="page-icon">🔧</span>
                                <span class="page-title">التحليل المالي الاحترافي (محسن)</span>
                                <span class="page-status status-fixed">محسن</span>
                            </a>
                        </li>
                        <li class="page-item">
                            <a href="FinancialAnalysisProNew.aspx" class="page-link">
                                <span class="page-icon">🆕</span>
                                <span class="page-title">التحليل المالي الاحترافي (جديد)</span>
                                <span class="page-status status-new">جديد</span>
                            </a>
                        </li>
                        <li class="page-item">
                            <a href="FinancialAnalysisProNewFixed.aspx" class="page-link">
                                <span class="page-icon">✨</span>
                                <span class="page-title">التحليل المالي الاحترافي (جديد محسن)</span>
                                <span class="page-status status-fixed">جديد محسن</span>
                            </a>
                        </li>
                    </ul>
                </div>

                <!-- Customer Statements Category -->
                <div class="category-card customer" id="customer">
                    <span class="category-icon">👥</span>
                    <h3 class="category-title">كشوف العملاء والموازين</h3>
                    <p class="category-description">
                        صفحات متخصصة في إدارة كشوف حسابات العملاء وميزان المراجعة مع إصدارات متقدمة ومحسنة.
                    </p>
                    
                    <ul class="pages-list">
                        <li class="page-item">
                            <a href="CustomerStatement.aspx" class="page-link">
                                <span class="page-icon">📄</span>
                                <span class="page-title">كشف حساب العميل</span>
                                <span class="page-status status-active">نشط</span>
                            </a>
                        </li>
                        <li class="page-item">
                            <a href="CustomerStatement_NEW.aspx" class="page-link">
                                <span class="page-icon">🆕</span>
                                <span class="page-title">كشف حساب العميل (جديد)</span>
                                <span class="page-status status-new">جديد</span>
                            </a>
                        </li>
                        <li class="page-item">
                            <a href="CustomerStatementAdvanced.aspx" class="page-link">
                                <span class="page-icon">⚡</span>
                                <span class="page-title">كشف حساب العميل المتقدم</span>
                                <span class="page-status status-active">متقدم</span>
                            </a>
                        </li>
                        <li class="page-item">
                            <a href="CustomerStatementAdvanced_NEW.aspx" class="page-link">
                                <span class="page-icon">🚀</span>
                                <span class="page-title">كشف حساب العميل المتقدم (جديد)</span>
                                <span class="page-status status-new">متقدم جديد</span>
                            </a>
                        </li>
                        <li class="page-item">
                            <a href="CustomersTrialBalance.aspx" class="page-link">
                                <span class="page-icon">⚖️</span>
                                <span class="page-title">ميزان مراجعة العملاء</span>
                                <span class="page-status status-active">نشط</span>
                            </a>
                        </li>
                    </ul>
                </div>

                <!-- Dashboard Category -->
                <div class="category-card dashboard" id="dashboard">
                    <span class="category-icon">📈</span>
                    <h3 class="category-title">لوحات التحكم التفاعلية</h3>
                    <p class="category-description">
                        لوحات تحكم حديثة باستخدام تقنيات Vanilla JavaScript و Vue.js لعرض البيانات المالية بشكل تفاعلي.
                    </p>
                    
                    <ul class="pages-list">
                        <li class="page-item">
                            <a href="DashboardVanilla.aspx" class="page-link">
                                <span class="page-icon">🍦</span>
                                <span class="page-title">لوحة التحكم (Vanilla JS)</span>
                                <span class="page-status status-active">نشط</span>
                            </a>
                        </li>
                        <li class="page-item">
                            <a href="DashboardVue.aspx" class="page-link">
                                <span class="page-icon">💚</span>
                                <span class="page-title">لوحة التحكم (Vue.js)</span>
                                <span class="page-status status-active">نشط</span>
                            </a>
                        </li>
                        <li class="page-item">
                            <a href="FinancialDashboardVanilla.aspx" class="page-link">
                                <span class="page-icon">💼</span>
                                <span class="page-title">لوحة التحكم المالية (Vanilla JS)</span>
                                <span class="page-status status-active">مالي</span>
                            </a>
                        </li>
                        <li class="page-item">
                            <a href="FinancialDashboardVue.aspx" class="page-link">
                                <span class="page-icon">💰</span>
                                <span class="page-title">لوحة التحكم المالية (Vue.js)</span>
                                <span class="page-status status-active">مالي</span>
                            </a>
                        </li>
                        <li class="page-item">
                            <a href="SidebarDemo.aspx" class="page-link">
                                <span class="page-icon">🎛️</span>
                                <span class="page-title">عرض القائمة الجانبية AdminLTE</span>
                                <span class="page-status status-new">جديد</span>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>

    <script>
        document.addEventListener('DOMContentLoaded', function() {
            // Ensure navigation menu is visible
            const navigation = document.querySelector('.modern-navigation');
            const menuBar = document.querySelector('#PageMenuBar');
            const menuWrapper = document.querySelector('.modern-menu-wrapper');
            
            if (navigation) {
                navigation.style.display = 'block';
                navigation.style.visibility = 'visible';
                navigation.style.zIndex = '1000';
                console.log('Navigation element found and made visible');
            } else {
                console.warn('Navigation element not found');
            }
            
            if (menuBar) {
                menuBar.style.display = 'block';
                menuBar.style.visibility = 'visible';
                console.log('PageMenuBar found and made visible');
            } else {
                console.warn('PageMenuBar not found');
            }
            
            if (menuWrapper) {
                menuWrapper.style.display = 'block';
                menuWrapper.style.visibility = 'visible';
                console.log('Menu wrapper found and made visible');
            } else {
                console.warn('Menu wrapper not found');
            }
            
            console.log('Advanced ASPX Pages Index loaded');
            console.log('Page icons found:', document.querySelectorAll('.page-icon').length);
            console.log('Category icons found:', document.querySelectorAll('.category-icon').length);
            console.log('Page titles found:', document.querySelectorAll('.page-title').length);
            
            // Additional check with delay for menu elements
            setTimeout(function() {
                const navigation = document.querySelector('.modern-navigation');
                const menuBar = document.querySelector('#PageMenuBar');
                const menuWrapper = document.querySelector('.modern-menu-wrapper');
                const headerElement = document.querySelector('.modern-header');
                
                console.log('Delayed check:');
                console.log('- Header found:', !!headerElement);
                console.log('- Navigation found:', !!navigation);
                console.log('- MenuBar found:', !!menuBar);
                console.log('- MenuWrapper found:', !!menuWrapper);
                
                if (navigation) {
                    navigation.style.display = 'block';
                    navigation.style.visibility = 'visible';
                    navigation.style.position = 'relative';
                    navigation.style.zIndex = '1000';
                }
                
                if (menuBar) {
                    menuBar.style.display = 'block';
                    menuBar.style.visibility = 'visible';
                }
                
                if (headerElement) {
                    headerElement.style.display = 'block';
                    headerElement.style.visibility = 'visible';
                    console.log('Header made visible');
                }
            }, 500);
            
            // Check if emojis are rendering
            const testEmoji = document.querySelector('.category-icon');
            if (testEmoji) {
                console.log('First category icon content:', testEmoji.textContent);
            }
            
            // Search functionality
            const searchInput = document.getElementById('searchInput');
            const pageLinks = document.querySelectorAll('.page-link');
            
            searchInput.addEventListener('input', function() {
                const searchTerm = this.value.toLowerCase();
                
                pageLinks.forEach(link => {
                    const pageTitle = link.querySelector('.page-title').textContent.toLowerCase();
                    const pageItem = link.closest('.page-item');
                    
                    if (pageTitle.includes(searchTerm)) {
                        pageItem.style.display = 'block';
                        link.style.backgroundColor = searchTerm ? '#fff3cd' : '';
                    } else {
                        pageItem.style.display = searchTerm ? 'none' : 'block';
                        link.style.backgroundColor = '';
                    }
                });
                
                // Update category visibility
                document.querySelectorAll('.category-card').forEach(card => {
                    const visiblePages = card.querySelectorAll('.page-item[style*="block"], .page-item:not([style])');
                    card.style.display = visiblePages.length > 0 ? 'block' : 'none';
                });
            });
            
            // Smooth scrolling for quick actions
            document.querySelectorAll('a[href^="#"]').forEach(anchor => {
                anchor.addEventListener('click', function (e) {
                    e.preventDefault();
                    const target = document.querySelector(this.getAttribute('href'));
                    if (target) {
                        target.scrollIntoView({
                            behavior: 'smooth',
                            block: 'start'
                        });
                    }
                });
            });
            
            // Page link interactions
            pageLinks.forEach(link => {
                link.addEventListener('click', function(e) {
                    // Add loading effect
                    this.style.opacity = '0.7';
                    this.style.pointerEvents = 'none';
                    
                    // Track page access
                    const pageTitle = this.querySelector('.page-title').textContent;
                    console.log(`Accessing page: ${pageTitle}`);
                    
                    // Note: In a real implementation, you might want to add analytics here
                });
            });
            
            // Keyboard shortcuts
            document.addEventListener('keydown', function(e) {
                if (e.ctrlKey) {
                    switch(e.key) {
                        case 'f':
                            e.preventDefault();
                            searchInput.focus();
                            break;
                        case 'h':
                            e.preventDefault();
                            window.location.href = '../../Default.aspx';
                            break;
                        case 'b':
                            e.preventDefault();
                            window.location.href = '../Index.html';
                            break;
                    }
                }
            });
            
            // Initialize animations
            const observer = new IntersectionObserver((entries) => {
                entries.forEach(entry => {
                    if (entry.isIntersecting) {
                        entry.target.classList.add('fade-in');
                    }
                });
            }, {
                threshold: 0.1
            });
            
            document.querySelectorAll('.category-card').forEach(card => {
                observer.observe(card);
            });
            
            // Performance monitoring
            window.addEventListener('load', function() {
                const loadTime = performance.now();
                console.log(`Advanced ASPX Index loaded in ${loadTime.toFixed(2)}ms`);
            });
        });
    </script>
</asp:Content>
