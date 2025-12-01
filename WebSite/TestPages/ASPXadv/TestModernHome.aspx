<%@ Page Language="VB" MasterPageFile="~/ModernMaster.master" AutoEventWireup="false" CodeFile="TestModernHome.aspx.vb" Inherits="TestPages_ASPXADV_TestModernHome" Title="Modern Home Table of Contents Test" %>
<%@ Register TagPrefix="modern" TagName="ModernHomeTOC" Src="~/Controls/ModernHomeTableOfContents.ascx" %>

<asp:Content ID="ContentHead" ContentPlaceHolderID="head" runat="Server">
    <style>
    .test-page-header {
        background: linear-gradient(135deg, var(--primary-color, #2563eb), var(--accent-color, #f59e0b));
        color: white;
        padding: 3rem 2rem;
        border-radius: 16px;
        margin-bottom: 2rem;
        text-align: center;
    }

    .page-title {
        font-size: 2.5rem;
        margin-bottom: 1rem;
        display: flex;
        align-items: center;
        justify-content: center;
        gap: 1rem;
    }

    .page-description {
        font-size: 1.2rem;
        opacity: 0.9;
        margin: 0;
        max-width: 800px;
        margin: 0 auto;
    }

    .test-info-section,
    .control-test-section,
    .comparison-section,
    .technical-section {
        background: var(--card-background, #ffffff);
        border-radius: 16px;
        padding: 2rem;
        margin-bottom: 2rem;
        box-shadow: 0 4px 20px rgba(0, 0, 0, 0.08);
    }

    .test-info-section h2,
    .control-test-section h2,
    .comparison-section h2,
    .technical-section h2 {
        color: var(--primary-color, #2563eb);
        display: flex;
        align-items: center;
        gap: 0.5rem;
        margin-bottom: 1.5rem;
    }

    .info-grid,
    .comparison-grid,
    .technical-grid {
        display: grid;
        gap: 1.5rem;
    }

    .info-grid {
        grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    }

    .comparison-grid {
        grid-template-columns: repeat(auto-fit, minmax(350px, 1fr));
    }

    .technical-grid {
        grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
    }

    .info-card,
    .comparison-card,
    .tech-card {
        background: var(--background-light, #f8fafc);
        border-radius: 12px;
        padding: 1.5rem;
        border-left: 4px solid var(--primary-color, #2563eb);
    }

    .comparison-card.original {
        border-left-color: var(--warning-color, #f59e0b);
    }

    .comparison-card.modern {
        border-left-color: var(--success-color, #10b981);
    }

    .info-card h3,
    .comparison-card h3,
    .tech-card h3 {
        color: var(--text-primary, #1f2937);
        margin-bottom: 1rem;
        font-size: 1.1rem;
    }

    .info-card ul,
    .tech-card ul {
        list-style: none;
        padding: 0;
        margin: 0;
    }

    .info-card li,
    .tech-card li {
        padding: 0.5rem 0;
        border-bottom: 1px solid var(--border-color, #e5e7eb);
        color: var(--text-secondary, #6b7280);
    }

    .info-card li:last-child,
    .tech-card li:last-child {
        border-bottom: none;
    }

    .features-list {
        display: flex;
        flex-direction: column;
        gap: 0.5rem;
    }

    .feature {
        display: flex;
        align-items: center;
        gap: 0.5rem;
        padding: 0.5rem;
        border-radius: 8px;
        background: rgba(255, 255, 255, 0.5);
    }

    .text-success {
        color: var(--success-color, #10b981) !important;
    }

    .text-danger {
        color: var(--danger-color, #ef4444) !important;
    }

    .control-container {
        background: var(--background-light, #f8fafc);
        border-radius: 12px;
        padding: 1rem;
        min-height: 400px;
    }

    /* Responsive Design */
    @media (max-width: 768px) {
        .page-title {
            font-size: 2rem;
            flex-direction: column;
            gap: 0.5rem;
        }
        
        .test-info-section,
        .control-test-section,
        .comparison-section,
        .technical-section {
            padding: 1.5rem;
        }
        
        .info-grid,
        .comparison-grid,
        .technical-grid {
            grid-template-columns: 1fr;
        }
    }
    </style>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">
    Modern Home Navigation Test
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
    
    <!-- Page Header -->
    <div class="test-page-header">
        <h1 class="page-title">
            <i class="fas fa-home"></i>
            Modern Home Table of Contents Test
        </h1>
        <p class="page-description">
            اختبار شامل لكونترول التنقل الرئيسي الحديث - نسخة محدثة من HomeTableOfContents بدون Telerik
        </p>
    </div>

    <!-- Test Information Section -->
    <div class="test-info-section">
        <h2><i class="fas fa-info-circle"></i> معلومات الاختبار</h2>
        <div class="info-grid">
            <div class="info-card">
                <h3>الهدف من الاختبار</h3>
                <ul>
                    <li>اختبار ModernHomeTableOfContents.ascx</li>
                    <li>التأكد من عمل التنقل بدون Telerik</li>
                    <li>اختبار التصميم المتجاوب</li>
                    <li>التحقق من دعم الترجمة العربية</li>
                </ul>
            </div>
            
            <div class="info-card">
                <h3>الميزات المختبرة</h3>
                <ul>
                    <li>SiteMap integration</li>
                    <li>Responsive grid layout</li>
                    <li>Font Awesome icons</li>
                    <li>Hover animations</li>
                    <li>Loading animations</li>
                    <li>Statistics display</li>
                </ul>
            </div>
            
            <div class="info-card">
                <h3>التحسينات المضافة</h3>
                <ul>
                    <li>تصميم modern مع CSS Grid</li>
                    <li>إحصائيات تفاعلية</li>
                    <li>رسوم متحركة محسنة</li>
                    <li>دعم Dark Mode</li>
                    <li>Performance optimization</li>
                    <li>Better error handling</li>
                </ul>
            </div>
        </div>
    </div>

    <!-- Modern Home Navigation Control -->
    <div class="control-test-section">
        <h2><i class="fas fa-cogs"></i> Modern Home Navigation Control</h2>
        <div class="control-container">
            <modern:ModernHomeTOC ID="modernHomeNavigation" runat="server" />
        </div>
    </div>

    <!-- Comparison Section -->
    <div class="comparison-section">
        <h2><i class="fas fa-balance-scale"></i> مقارنة مع النسخة الأصلية</h2>
        <div class="comparison-grid">
            <div class="comparison-card original">
                <h3>HomeTableOfContents.ascx (الأصلي)</h3>
                <div class="features-list">
                    <div class="feature"><i class="fas fa-check text-success"></i> Telerik RadSiteMap</div>
                    <div class="feature"><i class="fas fa-check text-success"></i> Image overlay design</div>
                    <div class="feature"><i class="fas fa-check text-success"></i> Translation support</div>
                    <div class="feature"><i class="fas fa-times text-danger"></i> Heavy dependencies</div>
                    <div class="feature"><i class="fas fa-times text-danger"></i> Limited animations</div>
                </div>
            </div>
            
            <div class="comparison-card modern">
                <h3>ModernHomeTableOfContents.ascx (الجديد)</h3>
                <div class="features-list">
                    <div class="feature"><i class="fas fa-check text-success"></i> Native ASP.NET controls</div>
                    <div class="feature"><i class="fas fa-check text-success"></i> CSS Grid layout</div>
                    <div class="feature"><i class="fas fa-check text-success"></i> Font Awesome icons</div>
                    <div class="feature"><i class="fas fa-check text-success"></i> Responsive design</div>
                    <div class="feature"><i class="fas fa-check text-success"></i> Modern animations</div>
                    <div class="feature"><i class="fas fa-check text-success"></i> Statistics dashboard</div>
                    <div class="feature"><i class="fas fa-check text-success"></i> Dark mode support</div>
                </div>
            </div>
        </div>
    </div>

    <!-- Technical Details -->
    <div class="technical-section">
        <h2><i class="fas fa-code"></i> التفاصيل التقنية</h2>
        <div class="technical-grid">
            <div class="tech-card">
                <h3>Frontend Technologies</h3>
                <ul>
                    <li>CSS Grid & Flexbox</li>
                    <li>CSS Variables</li>
                    <li>Font Awesome 6</li>
                    <li>Vanilla JavaScript</li>
                    <li>CSS Animations</li>
                </ul>
            </div>
            
            <div class="tech-card">
                <h3>Backend Integration</h3>
                <ul>
                    <li>ASP.NET Repeater</li>
                    <li>SiteMap Provider</li>
                    <li>VB.NET Code-behind</li>
                    <li>Error Handling</li>
                    <li>User Tracking</li>
                </ul>
            </div>
            
            <div class="tech-card">
                <h3>Performance Features</h3>
                <ul>
                    <li>Lazy Loading</li>
                    <li>Minimal Dependencies</li>
                    <li>Optimized Animations</li>
                    <li>Responsive Images</li>
                    <li>Efficient DOM Updates</li>
                </ul>
            </div>
        </div>
    </div>

</asp:Content>
