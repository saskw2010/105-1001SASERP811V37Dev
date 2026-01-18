<%@ Page Language="VB" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="Home.aspx.vb"
    Inherits="Pages_Home" Title="Home" %>
    <%@ Register Src="../Controls/schoolDashBoard.ascx" TagName="schoolDashBoard" TagPrefix="uc" %>
        <%@ Register Src="../Controls/TableOfContents.ascx" TagName="TableOfContents" TagPrefix="uc" %>
            <%@ Register Src="../Controls/HomeTableOfContents.ascx" TagName="HomeTableOfContents" TagPrefix="home" %>

                <asp:Content ID="ContentHead" ContentPlaceHolderID="PageHeaderContentPlaceHolder" runat="server">
                    <!-- 🔧 Dashboard Fixes V2.1 - HIDE SIDEBAR + NO SCROLL + CLEAN UI -->
                    <link href="../VueCss/dashboard-fixes-v2.1.css" rel="stylesheet" type="text/css" />
                    <!-- Dashboard Fixes JavaScript -->
                    <script src="../Vuejs/dashboard-fixes-simple.js" type="text/javascript"></script>


                </asp:Content>

                <asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">

                    <!-- 🌟 High-End Collapsible Hero Section -->
                    <div id="SkyHeroContainer" class="hero-card-container">
                        <div class="hero-glass-card sky-green-theme">
                            <!-- Header (Always Visible) -->
                            <div class="hero-header-modern">
                                <div class="hero-center-branding">
                                    <div class="hero-cloud-icon">
                                        <i class="fas fa-cloud"></i>
                                    </div>
                                    <h1 class="hero-main-title">SKY365 ERP AI</h1>

                                    <div class="hero-action-group mt-3">
                                        <div class="hero-action-row">
                                            <button type="button" class="btn-hero-icon" title="View Classic"><i
                                                    class="fas fa-hexagon"></i></button>
                                            <button type="button" class="btn-hero-icon" title="View Bento"><i
                                                    class="fas fa-grid-2"></i></button>
                                            <button type="button" class="btn-hero-icon" title="View Circles"><i
                                                    class="fas fa-circle"></i></button>
                                            <button type="button" class="btn-hero-icon active" title="View Dashboard"><i
                                                    class="fas fa-table-cells-large"></i></button>
                                            <button type="button" class="btn-hero-icon" title="Toggle Theme"><i
                                                    class="fas fa-moon"></i></button>
                                            <button type="button" class="btn-hero-icon main-burger" id="heroSidebarBtn"
                                                title="القائمة الرئيسية">
                                                <i class="fas fa-bars"></i>
                                            </button>
                                        </div>
                                    </div>

                                    <p class="hero-modern-subtitle">Modern Enterprise Resource Planning system for
                                        seamless business management.</p>
                                </div>

                                <button type="button" class="hero-mini-toggle" id="heroCollapseBtn" title="إخفاء/إظهار">
                                    <i class="fas fa-chevron-up"></i>
                                </button>
                            </div>

                            <!-- Collapsible Body -->
                            <div class="hero-body" id="heroBody">
                                <div class="hero-license-box" id="license-hero-wrapper">
                                    <i class="fas fa-shield-check"></i>
                                    <div class="hero-license-text" id="modern-license-container">
                                        جاري التحقق من حالة الترخيص...
                                    </div>
                                </div>

                                <div class="hero-description mt-3">
                                    <p class="text-muted small">
                                        أهلاً بك في الجيل القادم من إدارة الأعمال. يوفر نظام SKY365 تجربة مستخدم فريدة
                                        مع أدوات ذكاء اصطناعي متكاملة لتسريع وتيرة العمل واتخاذ القرارات بدقة.
                                    </p>
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- 🏢 Enterprise Multi-Tab Modular Dashboard V4.1.0 -->
                    <div class="enterprise-dashboard-container">

                        <!-- Tab Navigation - Fixed Horizontal Layout -->
                        <div class="dashboard-tabs-container">
                            <ul class="nav nav-tabs enterprise-tabs" role="tablist" id="dashboardTabs">
                                <li class="nav-item">
                                    <a class="nav-link active" id="original-tab" data-toggle="tab"
                                        href="#original-dashboard" role="tab" aria-controls="original-dashboard"
                                        aria-selected="true">
                                        <i class="fas fa-home"></i>
                                        <span>
                                            <%=translatemeyamosso.GetResourceValuemosso("Home")%>
                                        </span>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" id="financial-tab" data-toggle="tab" href="#financial-dashboard"
                                        role="tab" aria-controls="financial-dashboard" aria-selected="false">
                                        <i class="fas fa-chart-line"></i>
                                        <span>
                                            <%=translatemeyamosso.GetResourceValuemosso("Financial")%>
                                        </span>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" id="hr-tab" data-toggle="tab" href="#hr-dashboard" role="tab"
                                        aria-controls="hr-dashboard" aria-selected="false">
                                        <i class="fas fa-users"></i>
                                        <span>
                                            <%=translatemeyamosso.GetResourceValuemosso("HumanResources")%>
                                        </span>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" id="operations-tab" data-toggle="tab"
                                        href="#operations-dashboard" role="tab" aria-controls="operations-dashboard"
                                        aria-selected="false">
                                        <i class="fas fa-cogs"></i>
                                        <span>
                                            <%=translatemeyamosso.GetResourceValuemosso("Operations")%>
                                        </span>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link" id="reports-tab" data-toggle="tab" href="#reports-dashboard"
                                        role="tab" aria-controls="reports-dashboard" aria-selected="false">
                                        <i class="fas fa-file-alt"></i>
                                        <span>
                                            <%=translatemeyamosso.GetResourceValuemosso("Reports")%>
                                        </span>
                                    </a>
                                </li>
                                <!-- Additional tabs will be added based on user roles -->
                                <asp:PlaceHolder ID="AdditionalTabsPlaceHolder" runat="server"></asp:PlaceHolder>
                            </ul>
                        </div>

                        <!-- Tab Content -->
                        <div class="tab-content enterprise-tab-content" id="dashboardTabContent">

                            <!-- 🏠 Original Dashboard Tab (Always First and Active) -->
                            <div class="tab-pane fade show active" id="original-dashboard" role="tabpanel"
                                aria-labelledby="original-tab">
                                <div class="original-dashboard-content">

                                    <!-- Main Dashboard Content - Sidebar Removed -->
                                    <div class="dashboard-layout">
                                        <!-- Main Content Area - FULL WIDTH -->
                                        <div class="dashboard-main-content full-width">
                                            <!-- School Dashboard Control - SKY365 -v25 as requested -->
                                            <div class="school-dashboard-section">
                                                <div class="section-header">
                                                    <h2>
                                                        <i class="fas fa-school"></i>
                                                        <%=translatemeyamosso.GetResourceValuemosso("MainMenus")%> -
                                                            SKY365 -v25
                                                    </h2>
                                                    <p>
                                                        <%=translatemeyamosso.GetResourceValuemosso("SystemModules")%>
                                                    </p>
                                                </div>
                                                <div class="container contenthome">
                                                    <uc:schoolDashBoard ID="schoolDashboard" runat="server">
                                                    </uc:schoolDashBoard>
                                                </div>
                                            </div>

                                            <!-- 🚀 System Updates Section - COMPACT V2 -->
                                            <div class="system-updates-section">
                                                <div class="updates-card">
                                                    <div class="updates-header">
                                                        <i class="fas fa-sparkles"></i>
                                                        <h3>تحديثات النظام والتقدم</h3>
                                                    </div>
                                                    <div class="updates-grid">
                                                        <!-- Progress 1 -->
                                                        <div class="update-item">
                                                            <div class="update-icon"
                                                                style="background: rgba(16, 185, 129, 0.1); color: #10b981;">
                                                                <i class="fas fa-mobile-screen"></i>
                                                            </div>
                                                            <div class="update-content">
                                                                <h4>تطبيق الموبايل (Noor Mobile) <span
                                                                        class="badge-update">مكتمل</span></h4>
                                                                <p>إطلاق النسخة التجريبية من تطبيق الموبايل بتقنية .NET
                                                                    MAUI</p>
                                                            </div>
                                                        </div>
                                                        <!-- Progress 2 -->
                                                        <div class="update-item">
                                                            <div class="update-icon"
                                                                style="background: rgba(59, 130, 246, 0.1); color: #3b82f6;">
                                                                <i class="fas fa-robot"></i>
                                                            </div>
                                                            <div class="update-content">
                                                                <h4>تكامل الذكاء الاصطناعي <span
                                                                        class="badge-update">مكتمل</span></h4>
                                                                <p>إضافة مساعد ذكي لتحليل البيانات والتقارير بشكل آلي
                                                                </p>
                                                            </div>
                                                        </div>
                                                        <!-- Upcoming 1 -->
                                                        <div class="update-item">
                                                            <div class="update-icon"
                                                                style="background: rgba(245, 158, 11, 0.1); color: #f59e0b;">
                                                                <i class="fas fa-chart-pie"></i>
                                                            </div>
                                                            <div class="update-content">
                                                                <h4>لوحة تحليلات متقدمة <span
                                                                        class="badge-update badge-upcoming">قريباً</span>
                                                                </h4>
                                                                <p>نظام تقارير تفاعلي جديد كلياً مع رسوم بيانية متطورة
                                                                </p>
                                                            </div>
                                                        </div>
                                                        <!-- Upcoming 2 -->
                                                        <div class="update-item">
                                                            <div class="update-icon"
                                                                style="background: rgba(139, 92, 246, 0.1); color: #8b5cf6;">
                                                                <i class="fas fa-cloud-arrow-up"></i>
                                                            </div>
                                                            <div class="update-content">
                                                                <h4>دعم السحابة المتعددة <span
                                                                        class="badge-update badge-upcoming">قريباً</span>
                                                                </h4>
                                                                <p>توسيع نطاق النظام ليدعم بيئات سحابية متعددة (SaaS)
                                                                </p>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                    <br />

                                    <!-- Current Menu Content Display Section -->
                                    <div class="current-menu-section">
                                        <div class="container contenthome">
                                            <!-- TableOfContents for Current Menu Display - Dynamic Only -->
                                            <div class="navigation-section">
                                                <div class="section-header">
                                                    <h2>
                                                        <i class="fas fa-sitemap"></i>
                                                        <%=translatemeyamosso.GetResourceValuemosso("TableOfContents")%>
                                                            -
                                                            <%=translatemeyamosso.GetResourceValuemosso("CurrentMenu")%>
                                                    </h2>
                                                    <p>
                                                        <%=translatemeyamosso.GetResourceValuemosso("CurrentPageContent")%>
                                                    </p>
                                                </div>
                                                <uc:TableOfContents ID="CurrentMenuTableOfContents" runat="server">
                                                </uc:TableOfContents>
                                            </div>

                                            <!-- 🏠 Home Navigation Section using Backup Telerik Style -->
                                            <div class="home-navigation-section" style="margin-top: 3rem;">
                                                <div class="section-header">
                                                    <h2>
                                                        <i class="fas fa-home"></i>
                                                        <%=translatemeyamosso.GetResourceValuemosso("HomeNavigation")%>
                                                            - الطريقة التقليدية
                                                    </h2>
                                                    <p>استخدام Telerik RadSiteMap الأصلي مع التصميم التقليدي</p>
                                                </div>
                                                <home:HomeTableOfContents ID="HomeNavigationTelerik" runat="server" />
                                            </div>
                                        </div>
                                    </div>

                                </div>
                            </div>

                            <!-- Additional tab content with all modules visible -->

                            <!-- 💰 Financial Dashboard Tab -->
                            <div class="tab-pane fade" id="financial-dashboard" role="tabpanel"
                                aria-labelledby="financial-tab">
                                <div class="tab-content-container">
                                    <div class="tab-header">
                                        <h2><i class="fas fa-chart-line"></i>
                                            <%=translatemeyamosso.GetResourceValuemosso("FinancialModule")%>
                                        </h2>
                                        <p>
                                            <%=translatemeyamosso.GetResourceValuemosso("FinancialDescription")%>
                                        </p>
                                    </div>
                                    <div class="placeholder-content">
                                        <div class="placeholder-card">
                                            <i class="fas fa-chart-line"></i>
                                            <h3>
                                                <%=translatemeyamosso.GetResourceValuemosso("FinancialAccounting")%>
                                            </h3>
                                            <p>
                                                <%=translatemeyamosso.GetResourceValuemosso("FinancialContentTBA")%>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <!-- 👥 HR Dashboard Tab -->
                            <div class="tab-pane fade" id="hr-dashboard" role="tabpanel" aria-labelledby="hr-tab">
                                <div class="tab-content-container">
                                    <div class="tab-header">
                                        <h2><i class="fas fa-users"></i>
                                            <%=translatemeyamosso.GetResourceValuemosso("HRModule")%>
                                        </h2>
                                        <p>
                                            <%=translatemeyamosso.GetResourceValuemosso("HRDescription")%>
                                        </p>
                                    </div>
                                    <div class="placeholder-content">
                                        <div class="placeholder-card">
                                            <i class="fas fa-users"></i>
                                            <h3>
                                                <%=translatemeyamosso.GetResourceValuemosso("HumanResourcesModule")%>
                                            </h3>
                                            <p>
                                                <%=translatemeyamosso.GetResourceValuemosso("HRContentTBA")%>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <!-- ⚙️ Operations Dashboard Tab -->
                            <div class="tab-pane fade" id="operations-dashboard" role="tabpanel"
                                aria-labelledby="operations-tab">
                                <div class="tab-content-container">
                                    <div class="tab-header">
                                        <h2><i class="fas fa-cogs"></i> وحدة العمليات</h2>
                                        <p>إدارة العمليات التشغيلية والمخازن</p>
                                    </div>
                                    <div class="placeholder-content">
                                        <div class="placeholder-card">
                                            <i class="fas fa-cogs"></i>
                                            <h3>وحدة العمليات</h3>
                                            <p>سيتم إضافة محتوى وحدة العمليات هنا</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <!-- 📊 Reports Dashboard Tab -->
                            <div class="tab-pane fade" id="reports-dashboard" role="tabpanel"
                                aria-labelledby="reports-tab">
                                <div class="tab-content-container">
                                    <div class="tab-header">
                                        <h2><i class="fas fa-file-alt"></i> وحدة التقارير</h2>
                                        <p>عرض وإنشاء التقارير والإحصائيات</p>
                                    </div>
                                    <div class="placeholder-content">
                                        <div class="placeholder-card">
                                            <i class="fas fa-file-alt"></i>
                                            <h3>وحدة التقارير</h3>
                                            <p>سيتم إضافة محتوى وحدة التقارير هنا</p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <asp:PlaceHolder ID="AdditionalTabContentPlaceHolder" runat="server"></asp:PlaceHolder>

                        </div>

                        <!-- 🛡️ License Warning Footer - Persistent on Home Page -->
                        <div id="license-footer-warning"
                            style="display:none; margin-top: 2rem; padding: 1rem; border-radius: 12px; background: linear-gradient(135deg, #fff5f5 0%, #fed7d7 100%); border: 1px solid #feb2b2; color: #c53030; text-align: center; font-weight: 600; box-shadow: 0 4px 12px rgba(229, 62, 62, 0.1);">
                            <i class="fas fa-exclamation-triangle" style="margin-left: 10px;"></i>
                            <span id="license-warning-text"></span>
                        </div>
                    </div>

                    <style>
                        /* 🏢 Enterprise Multi-Tab Modular Dashboard V4.1.0 */
                        .enterprise-dashboard-container {
                            background: linear-gradient(135deg, #f8fafc 0%, #e2e8f0 100%);
                            padding: 20px;
                            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
                            outline: none !important;
                            border: none !important;
                        }

                        /* Tab Navigation Styles - FIXED */
                        .dashboard-tabs-container {
                            background: white;
                            border-radius: 15px 15px 0 0;
                            box-shadow: 0 -5px 15px rgba(0, 0, 0, 0.1);
                            overflow: visible;
                            margin-bottom: 0;
                        }

                        .tabs-header {
                            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
                            color: white;
                            text-align: center;
                            padding: 20px;
                            border-radius: 15px 15px 0 0;
                        }

                        .tabs-header h2 {
                            margin: 0;
                            font-size: 1.8rem;
                            font-weight: 600;
                            display: flex;
                            align-items: center;
                            justify-content: center;
                            gap: 15px;
                        }

                        .enterprise-tabs {
                            border: none;
                            background: #f8fafc;
                            margin: 0;
                            padding: 0;
                            display: flex;
                            flex-wrap: nowrap;
                            overflow-x: auto;
                            overflow-y: hidden;
                            white-space: nowrap;
                            scrollbar-width: thin;
                            scrollbar-color: #cbd5e1 #f1f5f9;
                        }

                        .enterprise-tabs::-webkit-scrollbar {
                            height: 6px;
                        }

                        .enterprise-tabs::-webkit-scrollbar-track {
                            background: #f1f5f9;
                        }

                        .enterprise-tabs::-webkit-scrollbar-thumb {
                            background: #cbd5e1;
                            border-radius: 3px;
                        }

                        .enterprise-tabs::-webkit-scrollbar-thumb:hover {
                            background: #94a3b8;
                        }

                        .enterprise-tabs .nav-item {
                            margin: 0;
                            flex-shrink: 0;
                        }

                        .enterprise-tabs .nav-link {
                            background: none;
                            border: none;
                            color: #64748b;
                            padding: 15px 25px;
                            font-weight: 600;
                            font-size: 15px;
                            transition: all 0.3s ease;
                            border-radius: 0;
                            position: relative;
                            display: flex;
                            align-items: center;
                            gap: 8px;
                            white-space: nowrap;
                            min-width: 120px;
                            justify-content: center;
                            border-bottom: 3px solid transparent;
                        }

                        .enterprise-tabs .nav-link:hover {
                            color: #3b82f6;
                            background: rgba(59, 130, 246, 0.05);
                            border-bottom-color: #93c5fd;
                        }

                        .enterprise-tabs .nav-link.active {
                            color: #1e40af;
                            background: white;
                            border-bottom-color: #3b82f6;
                            box-shadow: 0 -2px 8px rgba(59, 130, 246, 0.1);
                        }

                        .enterprise-tabs .nav-link i {
                            font-size: 16px;
                        }

                        .enterprise-tabs .nav-link span {
                            font-weight: 600;
                        }

                        /* Tab Content */
                        .enterprise-tab-content {
                            background: white;
                            border-radius: 0 0 15px 15px;
                            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
                        }

                        .tab-pane {
                            padding: 0;
                        }

                        /* Original Dashboard Content */
                        .original-dashboard-content {
                            padding: 30px;
                            background: linear-gradient(135deg, #f8fafc 0%, #e2e8f0 100%);
                        }

                        /* Dashboard Layout - Sidebar Removed */
                        .dashboard-layout {
                            position: relative;
                            margin-top: 20px;
                        }

                        /* Main Content Area - Full Width */
                        .dashboard-main-content {
                            padding: 20px;
                            width: 100%;
                        }

                        /* Section Headers */
                        .section-header {
                            text-align: center;
                            margin-bottom: 2rem;
                            padding: 2rem;
                            background: linear-gradient(135deg, rgba(52, 152, 219, 0.1), rgba(155, 89, 182, 0.1));
                            border-radius: 15px;
                            border: 2px solid rgba(52, 152, 219, 0.2);
                        }

                        .section-header h2 {
                            color: #2c3e50;
                            font-size: 2rem;
                            font-weight: 700;
                            margin-bottom: 0.5rem;
                            display: flex;
                            align-items: center;
                            justify-content: center;
                            gap: 15px;
                        }

                        .section-header h2 i {
                            color: #3498db;
                            font-size: 2.2rem;
                        }

                        .section-header p {
                            color: #7f8c8d;
                            font-size: 1.1rem;
                            margin: 0;
                        }

                        /* School Dashboard Section */
                        .school-dashboard-section {
                            background: white;
                            border-radius: 20px;
                            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
                            margin-bottom: 3rem;
                            overflow: hidden;
                            border: 1px solid #e8f4f8;
                        }

                        .school-dashboard-section .container {
                            padding: 2rem;
                        }

                        /* Current Menu Section */
                        .current-menu-section {
                            background: white;
                            border-radius: 20px;
                            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
                            overflow: hidden;
                            border: 1px solid #e8f4f8;
                        }

                        .current-menu-section .container {
                            padding: 2rem;
                        }

                        /* Navigation Section */
                        .navigation-section {
                            background: linear-gradient(135deg, rgba(46, 204, 113, 0.02), rgba(26, 188, 156, 0.02));
                            border-radius: 15px;
                            padding: 1.5rem;
                            border: 2px solid rgba(46, 204, 113, 0.1);
                            transition: all 0.3s ease;
                        }

                        .navigation-section:hover {
                            border-color: rgba(46, 204, 113, 0.3);
                            box-shadow: 0 5px 20px rgba(46, 204, 113, 0.1);
                        }

                        /* Responsive Design */
                        @media (max-width: 1200px) {
                            .enterprise-tabs .nav-link {
                                padding: 15px 20px;
                                font-size: 14px;
                            }

                            .section-header h2 {
                                font-size: 1.7rem;
                            }
                        }

                        @media (max-width: 768px) {
                            .enterprise-dashboard-container {
                                padding: 10px;
                            }

                            .original-dashboard-content {
                                padding: 15px;
                            }

                            .enterprise-tabs {
                                padding: 0 10px;
                            }

                            .enterprise-tabs .nav-link {
                                padding: 12px 15px;
                                font-size: 13px;
                            }

                            .enterprise-tabs .nav-link span {
                                display: none;
                            }

                            .section-header {
                                padding: 1.5rem;
                                margin-bottom: 1.5rem;
                            }

                            .section-header h2 {
                                font-size: 1.5rem;
                                flex-direction: column;
                                gap: 10px;
                            }

                            .section-header h2 i {
                                font-size: 1.8rem;
                            }
                        }

                        @media (max-width: 576px) {
                            .enterprise-tabs .nav-link {
                                padding: 10px 12px;
                            }

                            .section-header h2 {
                                font-size: 1.3rem;
                            }

                            .section-header p {
                                font-size: 1rem;
                            }
                        }

                        /* Animation improvements */

                        @keyframes slideInRight {
                            from {
                                opacity: 0;
                                transform: translateX(30px);
                            }

                            to {
                                opacity: 1;
                                transform: translateX(0);
                            }
                        }

                        /* Tab content animation */
                        .tab-pane {
                            animation: fadeInUp 0.5s ease-out;
                        }

                        @keyframes fadeInUp {
                            from {
                                opacity: 0;
                                transform: translateY(20px);
                            }

                            to {
                                opacity: 1;
                                transform: translateY(0);
                            }
                        }

                        /* Enhanced hover effects */
                        .navigation-section:hover {
                            transform: translateY(-2px);
                        }

                        .school-dashboard-section:hover {
                            transform: translateY(-2px);
                            box-shadow: 0 15px 40px rgba(0, 0, 0, 0.15);
                        }

                        .current-menu-section:hover {
                            transform: translateY(-2px);
                            box-shadow: 0 15px 40px rgba(0, 0, 0, 0.15);
                        }

                        /* Loading state for future use */
                        .loading-spinner {
                            display: inline-block;
                            width: 40px;
                            height: 40px;
                            border: 4px solid #e2e8f0;
                            border-top: 4px solid #3498db;
                            border-radius: 50%;
                            animation: spin 1s linear infinite;
                        }

                        @keyframes spin {
                            0% {
                                transform: rotate(0deg);
                            }

                            100% {
                                transform: rotate(360deg);
                            }
                        }

                        /* Focus states removed to prevent keyboard navigation issues */
                        .enterprise-tabs .nav-link:focus,
                        *:focus {
                            outline: none !important;
                            border: none !important;
                            box-shadow: none !important;
                        }

                        /* Remove all focus outlines from containers */
                        .enterprise-dashboard-container:focus,
                        .tab-content:focus,
                        .tab-pane:focus,
                        .original-dashboard-content:focus,
                        .dashboard-main-content:focus,
                        .navigation-section:focus,
                        .current-menu-section:focus {
                            outline: none !important;
                            border: none !important;
                            box-shadow: none !important;
                        }

                        /* Ensure body and html don't capture focus */
                        body:focus,
                        html:focus,
                        form:focus,
                        div:focus {
                            outline: none !important;
                            border: none !important;
                            box-shadow: none !important;
                        }

                        /* Remove any default browser focus styles */
                        *:focus-visible {
                            outline: none !important;
                        }

                        /* Prevent containers from being focusable */
                        .enterprise-dashboard-container,
                        .tab-content,
                        .tab-pane,
                        .original-dashboard-content {
                            -webkit-user-select: none;
                            -moz-user-select: none;
                            -ms-user-select: none;
                            user-select: none;
                        }

                        /* Ensure normal page scrolling */
                        html,
                        body {
                            overflow: auto !important;
                            height: auto !important;
                        }

                        .enterprise-dashboard-container {
                            height: auto !important;
                            overflow: visible !important;
                        }

                        /* Print styles */
                        @media print {
                            .enterprise-tabs {
                                display: none !important;
                            }

                            .original-dashboard-content {
                                padding: 0;
                                background: white;
                            }

                            .dashboard-main-content {
                                margin-right: 0 !important;
                            }
                        }

                        /* 🔧 FIXES FOR ISSUES - Added */

                        /* Tab Content Styling */
                        .tab-content-container {
                            padding: 30px;
                            background: linear-gradient(135deg, #f8fafc 0%, #e2e8f0 100%);
                        }

                        .tab-header {
                            text-align: center;
                            margin-bottom: 30px;
                            padding: 25px;
                            background: white;
                            border-radius: 15px;
                            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.1);
                        }

                        .tab-header h2 {
                            color: #2c3e50;
                            font-size: 2rem;
                            font-weight: 600;
                            margin-bottom: 10px;
                            display: flex;
                            align-items: center;
                            justify-content: center;
                            gap: 15px;
                        }

                        .tab-header p {
                            color: #64748b;
                            font-size: 1.1rem;
                            margin: 0;
                        }

                        .placeholder-content {
                            display: flex;
                            justify-content: center;
                            align-items: center;
                            min-height: 300px;
                        }

                        .placeholder-card {
                            background: white;
                            border-radius: 20px;
                            padding: 40px;
                            text-align: center;
                            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
                            max-width: 500px;
                            border: 2px solid #e2e8f0;
                        }

                        .placeholder-card i {
                            font-size: 4rem;
                            color: #3b82f6;
                            margin-bottom: 20px;
                        }

                        .placeholder-card h3 {
                            color: #1e293b;
                            font-size: 1.5rem;
                            font-weight: 600;
                            margin-bottom: 15px;
                        }

                        .placeholder-card p {
                            color: #64748b;
                            font-size: 1.1rem;
                            margin: 0;
                        }

                        /* Current Menu Section */
                        .current-menu-section {
                            background: white;
                            border-radius: 20px;
                            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
                            overflow: hidden;
                            border: 1px solid #e8f4f8;
                        }

                        .current-menu-section .container {
                            padding: 2rem;
                        }

                        /* Navigation Section */
                        .navigation-section {
                            background: linear-gradient(135deg, rgba(46, 204, 113, 0.02), rgba(26, 188, 156, 0.02));
                            border-radius: 15px;
                            padding: 1.5rem;
                            border: 2px solid rgba(46, 204, 113, 0.1);
                            transition: all 0.3s ease;
                        }

                        .navigation-section:hover {
                            border-color: rgba(46, 204, 113, 0.3);
                            box-shadow: 0 5px 20px rgba(46, 204, 113, 0.1);
                        }

                        /* 🚀 System Updates Section Styles */
                        .system-updates-section {
                            margin-bottom: 3rem;
                        }

                        .updates-card {
                            background: white;
                            border-radius: 20px;
                            padding: 2rem;
                            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.05);
                            border: 1px solid #e2e8f0;
                        }

                        .updates-header {
                            display: flex;
                            align-items: center;
                            gap: 1rem;
                            margin-bottom: 1.5rem;
                            padding-bottom: 1rem;
                            border-bottom: 1px solid #f1f5f9;
                        }

                        .updates-header i {
                            font-size: 1.5rem;
                            color: #3b82f6;
                        }

                        .updates-header h3 {
                            margin: 0;
                            font-size: 1.2rem;
                            font-weight: 700;
                            color: #1e293b;
                        }

                        .updates-grid {
                            display: grid;
                            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
                            gap: 1.5rem;
                        }

                        .update-item {
                            display: flex;
                            gap: 1rem;
                            padding: 1rem;
                            background: #f8fafc;
                            border-radius: 15px;
                            border: 1px solid #f1f5f9;
                            transition: all 0.3s ease;
                        }

                        .update-item:hover {
                            transform: translateY(-3px);
                            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.05);
                            border-color: #e2e8f0;
                        }

                        .update-icon {
                            width: 45px;
                            height: 45px;
                            min-width: 45px;
                            border-radius: 12px;
                            display: flex;
                            align-items: center;
                            justify-content: center;
                            font-size: 1.3rem;
                        }

                        .update-content {
                            flex: 1;
                        }

                        .update-content h4 {
                            margin: 0 0 5px 0;
                            font-size: 0.95rem;
                            font-weight: 700;
                            color: #334155;
                        }

                        .update-content p {
                            margin: 0;
                            font-size: 0.8rem;
                            color: #64748b;
                            line-height: 1.5;
                        }

                        .badge-update {
                            font-size: 0.65rem;
                            padding: 2px 6px;
                            border-radius: 4px;
                            background: #10b981;
                            color: white;
                            margin-right: 5px;
                            vertical-align: middle;
                        }

                        .badge-upcoming {
                            background: #3b82f6;
                        }
                    </style>

                    <script>
                        // 🏢 Enterprise Multi-Tab Modular Dashboard V4.1.0 JavaScript
                        document.addEventListener('DOMContentLoaded', function () {
                            console.log('🚀 Enterprise Dashboard V4.1.0 Loaded Successfully');

                            // --- 🌟 Sky365 Hero Logic ---
                            const heroBtn = document.getElementById('heroCollapseBtn');
                            const heroContainer = document.getElementById('SkyHeroContainer');

                            if (heroBtn && heroContainer) {
                                // Load saved state
                                const isCollapsed = localStorage.getItem('skyHeroCollapsed') === 'true';
                                if (isCollapsed) heroContainer.classList.add('collapsed');

                                heroBtn.addEventListener('click', function () {
                                    heroContainer.classList.toggle('collapsed');
                                    localStorage.setItem('skyHeroCollapsed', heroContainer.classList.contains('collapsed'));
                                });
                            }

                            // --- 🍔 Hero Sidebar Toggle ---
                            const heroSidebarBtn = document.getElementById('heroSidebarBtn');
                            if (heroSidebarBtn) {
                                heroSidebarBtn.addEventListener('click', function (e) {
                                    e.preventDefault();
                                    e.stopPropagation();
                                    const sidebarTrigger = document.getElementById('sidebar-trigger') ||
                                        document.getElementById('rootSidebarToggleBtn') ||
                                        document.getElementById('menuToggleBtn');
                                    if (sidebarTrigger) sidebarTrigger.click();
                                });
                            }

                            // --- 🛡️ License Bar Relocation ---
                            function relocateLicenseToHero() {
                                const membershipBar = document.getElementById('Membership_Login') ||
                                    document.querySelector('.MembershipBar') ||
                                    document.getElementById('mb_Login');
                                const modernLicenseArea = document.getElementById('ModernLicenseArea');
                                const licenseContainer = document.getElementById('modern-license-container');

                                if (!licenseContainer) return;

                                const sourceNode = (modernLicenseArea && (modernLicenseArea.innerText || modernLicenseArea.textContent || '').trim())
                                    ? modernLicenseArea
                                    : membershipBar;

                                if (sourceNode) {
                                    const content = (sourceNode.innerText || sourceNode.textContent || '').trim();
                                    if (content.length > 0) {
                                        licenseContainer.textContent = content;
                                        licenseContainer.setAttribute('data-license-loaded', 'true');
                                    }
                                }
                            }

                            // Run relocation with delays to ensure MembershipBar is loaded
                            setTimeout(relocateLicenseToHero, 100);
                            setTimeout(relocateLicenseToHero, 1500);
                            setTimeout(relocateLicenseToHero, 4000);

                            // Remove focus and tabindex from all containers to fix keyboard navigation
                            const containers = document.querySelectorAll('.enterprise-dashboard-container, .tab-content, .tab-pane, .original-dashboard-content, .dashboard-main-content');
                            containers.forEach(container => {
                                container.removeAttribute('tabindex');
                                container.style.outline = 'none';
                                container.style.border = 'none';
                                if (container.focus) {
                                    container.blur();
                                }
                            });

                            // Remove focus from body if it has it
                            if (document.activeElement && document.activeElement !== document.body) {
                                document.activeElement.blur();
                            }

                            console.log('🔧 Focus and keyboard navigation issues fixed');

                            // Initialize dashboard components  
                            initializeDashboard();
                            initializeTabSystem();

                            // Add loading animation
                            const dashboardContainer = document.querySelector('.enterprise-dashboard-container');
                            if (dashboardContainer) {
                                dashboardContainer.style.opacity = '0';
                                dashboardContainer.style.transform = 'translateY(20px)';

                                setTimeout(() => {
                                    dashboardContainer.style.transition = 'all 0.8s ease-out';
                                    dashboardContainer.style.opacity = '1';
                                    dashboardContainer.style.transform = 'translateY(0)';
                                }, 200);
                            }
                        });

                        // Initialize Dashboard
                        function initializeDashboard() {
                            console.log('📊 Initializing Enterprise Dashboard Components...');

                            // Animate section headers
                            const sectionHeaders = document.querySelectorAll('.section-header');
                            sectionHeaders.forEach((header, index) => {
                                header.style.opacity = '0';
                                header.style.transform = 'translateY(30px)';

                                setTimeout(() => {
                                    header.style.transition = 'all 0.6s ease-out';
                                    header.style.opacity = '1';
                                    header.style.transform = 'translateY(0)';
                                }, 300 + (index * 200));
                            });

                            // Add hover effects to dashboard sections
                            const dashboardSections = document.querySelectorAll('.school-dashboard-section, .current-menu-section');
                            dashboardSections.forEach(section => {
                                section.addEventListener('mouseenter', function () {
                                    this.style.transform = 'translateY(-5px)';
                                    this.style.boxShadow = '0 15px 40px rgba(0,0,0,0.15)';
                                });

                                section.addEventListener('mouseleave', function () {
                                    this.style.transform = 'translateY(0)';
                                    this.style.boxShadow = '0 10px 30px rgba(0,0,0,0.1)';
                                });
                            });
                        }

                        // Initialize Tab System - ENHANCED
                        function initializeTabSystem() {
                            console.log('🗂️ Initializing Tab System...');

                            // Bootstrap tab functionality (if Bootstrap is available)
                            if (typeof $ !== 'undefined' && $.fn.tab) {
                                $('#dashboardTabs a').on('click', function (e) {
                                    e.preventDefault();
                                    $(this).tab('show');
                                });

                                // Add tab switch animation
                                $('#dashboardTabs a').on('shown.bs.tab', function (e) {
                                    const targetPane = $($(this).attr('href'));
                                    targetPane.addClass('animated fadeInUp');

                                    setTimeout(() => {
                                        targetPane.removeClass('animated fadeInUp');
                                    }, 600);
                                });
                            } else {
                                // Enhanced fallback tab functionality
                                const tabLinks = document.querySelectorAll('.enterprise-tabs .nav-link');
                                const tabPanes = document.querySelectorAll('.tab-pane');

                                tabLinks.forEach((link, index) => {
                                    link.addEventListener('click', function (e) {
                                        e.preventDefault();

                                        // Remove active classes from all tabs
                                        tabLinks.forEach(l => {
                                            l.classList.remove('active');
                                            l.setAttribute('aria-selected', 'false');
                                        });
                                        tabPanes.forEach(p => {
                                            p.classList.remove('show', 'active');
                                        });

                                        // Add active class to clicked tab
                                        this.classList.add('active');
                                        this.setAttribute('aria-selected', 'true');

                                        // Show corresponding tab pane with animation
                                        const targetId = this.getAttribute('href');
                                        const targetPane = document.querySelector(targetId);
                                        if (targetPane) {
                                            targetPane.classList.add('show', 'active');

                                            // Add smooth scroll to ensure tab is visible
                                            targetPane.scrollIntoView({
                                                behavior: 'smooth',
                                                block: 'start'
                                            });
                                        }

                                        // Track tab switch for performance monitoring
                                        if (window.dashboardPerformance) {
                                            window.dashboardPerformance.trackTabSwitch(targetId);
                                        }

                                        console.log(`🗂️ Switched to tab: ${targetId}`);
                                    });
                                });
                            }

                            // Tab keyboard navigation disabled to fix arrow key scrolling
                            /*
                            const tabContainer = document.querySelector('.enterprise-tabs');
                            if (tabContainer) {
                                tabContainer.addEventListener('keydown', function(e) {
                                    const currentTab = document.querySelector('.enterprise-tabs .nav-link.active');
                                    const allTabs = Array.from(document.querySelectorAll('.enterprise-tabs .nav-link'));
                                    const currentIndex = allTabs.indexOf(currentTab);
                                    
                                    let targetIndex = currentIndex;
                                    
                                    if (e.key === 'ArrowRight' || e.key === 'ArrowDown') {
                                        e.preventDefault();
                                        targetIndex = (currentIndex + 1) % allTabs.length;
                                    } else if (e.key === 'ArrowLeft' || e.key === 'ArrowUp') {
                                        e.preventDefault();
                                        targetIndex = currentIndex > 0 ? currentIndex - 1 : allTabs.length - 1;
                                    } else if (e.key === 'Home') {
                                        e.preventDefault();
                                        targetIndex = 0;
                                    } else if (e.key === 'End') {
                                        e.preventDefault();
                                        targetIndex = allTabs.length - 1;
                                    }
                                    
                                    if (targetIndex !== currentIndex) {
                                        allTabs[targetIndex].click();
                                        allTabs[targetIndex].focus();
                                    }
                                });
                            }
                            */
                        }

                        // Enhanced Navigation Functions
                        window.loadTabContent = function (tabId, contentUrl) {
                            console.log(`🔄 Loading content for tab: ${tabId}`);

                            const tabPane = document.getElementById(tabId);
                            if (!tabPane) return;

                            // Show loading state
                            tabPane.innerHTML = `
        <div class="loading-container" style="text-align: center; padding: 4rem;">
            <div class="loading-spinner"></div>
            <h4 style="margin-top: 2rem; color: #64748b;">جاري تحميل المحتوى...</h4>
            <p style="color: #94a3b8;">يرجى الانتظار قليلاً</p>
        </div>
    `;

                            // Simulate AJAX loading (replace with actual implementation)
                            setTimeout(() => {
                                tabPane.innerHTML = `
            <div class="tab-content-loaded" style="padding: 3rem; text-align: center;">
                <div style="background: linear-gradient(135deg, #10b981, #06d6a0); width: 80px; height: 80px; border-radius: 20px; display: flex; align-items: center; justify-content: center; margin: 0 auto 2rem; color: white; font-size: 2rem;">
                    <i class="fas fa-check-circle"></i>
                </div>
                <h3 style="color: #1e293b; margin-bottom: 1rem;">تم تحميل محتوى ${tabId} بنجاح</h3>
                <p style="color: #64748b; margin-bottom: 2rem;">هنا سيتم عرض المحتوى الفعلي للتاب المحدد</p>
                <div style="background: #f8fafc; border-radius: 15px; padding: 2rem; border: 1px solid #e2e8f0;">
                    <p style="color: #64748b; margin: 0;">
                        يمكن الآن إضافة الـ Dashboard الخاص بهذا القسم مع الـ Widgets والبيانات المطلوبة.
                    </p>
                </div>
            </div>
        `;

                                // Add animation
                                const loadedContent = tabPane.querySelector('.tab-content-loaded');
                                if (loadedContent) {
                                    loadedContent.style.opacity = '0';
                                    loadedContent.style.transform = 'translateY(20px)';

                                    setTimeout(() => {
                                        loadedContent.style.transition = 'all 0.6s ease-out';
                                        loadedContent.style.opacity = '1';
                                        loadedContent.style.transform = 'translateY(0)';
                                    }, 100);
                                }

                            }, 2000); // Simulate loading time
                        }

                        // Utility Functions
                        window.scrollToSection = function (sectionClass) {
                            const section = document.querySelector(`.${sectionClass}`);
                            if (section) {
                                section.scrollIntoView({
                                    behavior: 'smooth',
                                    block: 'start'
                                });
                            }
                        }

                        window.showNotification = function (message, type = 'info') {
                            const notification = document.createElement('div');
                            notification.className = `notification notification-${type}`;
                            notification.style.cssText = `
        position: fixed;
        top: 20px;
        right: 20px;
        background: ${type === 'success' ? '#10b981' : type === 'error' ? '#ef4444' : '#3b82f6'};
        color: white;
        padding: 1rem 1.5rem;
        border-radius: 10px;
        box-shadow: 0 10px 25px rgba(0,0,0,0.2);
        z-index: 9999;
        animation: slideInRight 0.5s ease-out;
        max-width: 300px;
        font-weight: 500;
    `;
                            notification.textContent = message;

                            document.body.appendChild(notification);

                            setTimeout(() => {
                                notification.style.animation = 'slideOutRight 0.5s ease-out';
                                setTimeout(() => {
                                    if (notification.parentNode) {
                                        notification.parentNode.removeChild(notification);
                                    }
                                }, 500);
                            }, 3000);
                        }

                        // Performance Monitoring
                        window.dashboardPerformance = {
                            startTime: performance.now(),

                            logLoadTime: function () {
                                const loadTime = performance.now() - this.startTime;
                                console.log(`⚡ Dashboard loaded in ${Math.round(loadTime)}ms`);

                                if (loadTime > 3000) {
                                    console.warn('⚠️ Dashboard loading time is high. Consider optimization.');
                                }
                            },

                            trackTabSwitch: function (tabId) {
                                const switchTime = performance.now();
                                console.log(`🗂️ Switched to tab: ${tabId} at ${Math.round(switchTime)}ms`);
                            }
                        };

                        // Call performance logging after page load
                        window.addEventListener('load', function () {
                            setTimeout(() => {
                                window.dashboardPerformance.logLoadTime();
                            }, 100);
                        });

                        // Keyboard shortcuts disabled to fix navigation issues
                        /*
                        document.addEventListener('keydown', function(e) {
                            // Alt + H = Go to Home Tab
                            if (e.altKey && e.key === 'h') {
                                e.preventDefault();
                                const homeTab = document.getElementById('original-tab');
                                if (homeTab) {
                                    homeTab.click();
                                    showNotification('تم الانتقال للصفحة الرئيسية', 'success');
                                }
                            }
                            
                            // Ctrl + Arrow Keys = Navigate Tabs - DISABLED TO FIX KEYBOARD NAVIGATION
                            if (e.ctrlKey && (e.key === 'ArrowLeft' || e.key === 'ArrowRight')) {
                                e.preventDefault();
                                const activeTab = document.querySelector('.enterprise-tabs .nav-link.active');
                                const allTabs = document.querySelectorAll('.enterprise-tabs .nav-link');
                                const currentIndex = Array.from(allTabs).indexOf(activeTab);
                                
                                if (e.key === 'ArrowLeft' && currentIndex > 0) {
                                    allTabs[currentIndex - 1].click();
                                } else if (e.key === 'ArrowRight' && currentIndex < allTabs.length - 1) {
                                    allTabs[currentIndex + 1].click();
                                }
                            }
                        });
                        */

                        // Add CSS animations
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
    
    @keyframes fadeInUp {
        from { opacity: 0; transform: translateY(30px); }
        to { opacity: 1; transform: translateY(0); }
    }
    
    .animated {
        animation-duration: 0.6s;
        animation-fill-mode: both;
    }
    
    .fadeInUp {
        animation-name: fadeInUp;
    }
`;

                        if (document.head) {
                            document.head.appendChild(style);
                        }

                        // Console welcome message
                        console.log(`
🏢 SASERP Enterprise Dashboard V4.1.0
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
✅ Multi-tab modular system loaded
✅ Role-based access control ready
✅ Responsive design active
✅ Performance monitoring enabled

🎯 Keyboard shortcuts:
   Alt + H: Go to home tab
   Ctrl + ←/→: Navigate tabs
   
{{ ... }}
`);
                    </script>

                </asp:Content>