<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TelerikControlsConverter.aspx.vb" Inherits="TelerikControlsConverter" MasterPageFile="~/Main.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>محول كنترولات Telerik إلى التصميم الحديث</title>
    <meta name="description" content="تحويل جميع كنترولات Telerik في النظام إلى تصميم حديث ومتجاوب">
</asp:Content>

<asp:Content ID="Content2"  ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <!-- Modern Telerik Converter Page -->
    <div class="telerik-converter-page">
        <!-- Page Header -->
        <div class="page-header">
            <div class="header-content">
                <div class="header-icon">
                    <i class="fas fa-magic"></i>
                </div>
                <div class="header-text">
                    <h1 class="page-title">محول كنترولات Telerik</h1>
                    <p class="page-subtitle">تحويل تلقائي من Telerik إلى التصميم الحديث</p>
                </div>
            </div>
            <div class="conversion-stats">
                <div class="stat-item">
                    <div class="stat-value" id="totalConverted">0</div>
                    <div class="stat-label">تم تحويلها</div>
                </div>
                <div class="stat-item">
                    <div class="stat-value" id="totalFound">0</div>
                    <div class="stat-label">تم العثور عليها</div>
                </div>
                <div class="stat-item">
                    <div class="stat-value" id="conversionRate">0%</div>
                    <div class="stat-label">معدل النجاح</div>
                </div>
            </div>
        </div>

        <!-- Conversion Controls -->
        <div class="conversion-controls">
            <h2 class="section-title">
                <i class="fas fa-sliders-h"></i>
                أدوات التحويل
            </h2>
            <div class="controls-grid">
                <div class="control-card">
                    <div class="control-icon">
                        <i class="fas fa-play"></i>
                    </div>
                    <h3>بدء التحويل الشامل</h3>
                    <p>تحويل جميع كنترولات Telerik الموجودة في النظام</p>
                    <asp:Button ID="btnConvertAll" runat="server" Text="تحويل الكل" CssClass="convert-btn primary" />
                </div>
                
                <div class="control-card">
                    <div class="control-icon">
                        <i class="fas fa-search"></i>
                    </div>
                    <h3>فحص الكنترولات</h3>
                    <p>البحث عن جميع كنترولات Telerik في النظام</p>
                    <asp:Button ID="btnScanControls" runat="server" Text="فحص" CssClass="convert-btn secondary" />
                </div>

                <div class="control-card">
                    <div class="control-icon">
                        <i class="fas fa-undo"></i>
                    </div>
                    <h3>استعادة النسخة الأصلية</h3>
                    <p>العودة إلى كنترولات Telerik الأصلية</p>
                    <asp:Button ID="btnRestore" runat="server" Text="استعادة" CssClass="convert-btn warning" />
                </div>
            </div>
        </div>

        <!-- Conversion Results -->
        <div class="conversion-results">
            <h2 class="section-title">
                <i class="fas fa-list-check"></i>
                نتائج التحويل
            </h2>
            <div class="results-container">
                <asp:Literal ID="litConversionResults" runat="server"></asp:Literal>
            </div>
        </div>

        <!-- Live Preview -->
        <div class="live-preview">
            <h2 class="section-title">
                <i class="fas fa-eye"></i>
                معاينة مباشرة للتحويلات
            </h2>
            
            <!-- TableOfContents Preview -->
            <div class="preview-section">
                <h3 class="preview-title">
                    <i class="fas fa-th-large"></i>
                    TableOfContents المحدث
                </h3>
                <div class="preview-container">
                    <asp:Literal ID="litTableOfContentsPreview" runat="server"></asp:Literal>
                </div>
            </div>

            <!-- ERP Modules Preview -->
            <div class="preview-section">
                <h3 class="preview-title">
                    <i class="fas fa-cube"></i>
                    وحدات ERP الحديثة
                </h3>
                <div class="preview-container">
                    <asp:Literal ID="litERPModulesPreview" runat="server"></asp:Literal>
                </div>
            </div>

            <!-- School Dashboard Preview -->
            <div class="preview-section">
                <h3 class="preview-title">
                    <i class="fas fa-graduation-cap"></i>
                    لوحة المدرسة الحديثة
                </h3>
                <div class="preview-container">
                    <asp:Literal ID="litSchoolPreview" runat="server"></asp:Literal>
                </div>
            </div>

            <!-- Ajar Dashboard Preview -->
            <div class="preview-section">
                <h3 class="preview-title">
                    <i class="fas fa-building"></i>
                    لوحة أجار الحديثة
                </h3>
                <div class="preview-container">
                    <asp:Literal ID="litAjarPreview" runat="server"></asp:Literal>
                </div>
            </div>
        </div>
    </div>

    <!-- Modern Styles -->
    <style>
    .telerik-converter-page {
        max-width: 1400px;
        margin: 0 auto;
        padding: 2rem;
        font-family: 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        direction: rtl;
        background: linear-gradient(135deg, #f8fafc 0%, #e2e8f0 100%);
        min-height: 100vh;
    }

    /* Page Header */
    .page-header {
        background: linear-gradient(135deg, #7c3aed, #a855f7);
        border-radius: 24px;
        padding: 3rem;
        margin-bottom: 3rem;
        color: white;
        position: relative;
        overflow: hidden;
        box-shadow: 0 20px 40px rgba(124, 58, 237, 0.3);
    }

    .page-header::before {
        content: '';
        position: absolute;
        top: -50%;
        right: -50%;
        width: 200%;
        height: 200%;
        background: radial-gradient(circle, rgba(255,255,255,0.1) 0%, transparent 70%);
        animation: float 8s ease-in-out infinite;
    }

    @keyframes float {
        0%, 100% { transform: translateY(0px) rotate(0deg); }
        50% { transform: translateY(-30px) rotate(180deg); }
    }

    .header-content {
        display: flex;
        align-items: center;
        gap: 2rem;
        margin-bottom: 2rem;
    }

    .header-icon {
        width: 80px;
        height: 80px;
        background: rgba(255, 255, 255, 0.2);
        backdrop-filter: blur(10px);
        border-radius: 20px;
        display: flex;
        align-items: center;
        justify-content: center;
        font-size: 2.5rem;
    }

    .page-title {
        font-size: 2.5rem;
        font-weight: 700;
        margin: 0;
        text-shadow: 0 2px 4px rgba(0,0,0,0.1);
    }

    .page-subtitle {
        font-size: 1.2rem;
        opacity: 0.9;
        margin: 0.5rem 0 0 0;
    }

    .conversion-stats {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(150px, 1fr));
        gap: 2rem;
    }

    .stat-item {
        text-align: center;
        background: rgba(255, 255, 255, 0.1);
        backdrop-filter: blur(10px);
        border-radius: 16px;
        padding: 1.5rem;
        transition: all 0.3s ease;
    }

    .stat-item:hover {
        transform: translateY(-5px);
        background: rgba(255, 255, 255, 0.2);
    }

    .stat-value {
        font-size: 2.5rem;
        font-weight: 700;
        margin-bottom: 0.5rem;
        color: #fbbf24;
    }

    .stat-label {
        font-size: 0.9rem;
        opacity: 0.8;
    }

    /* Section Titles */
    .section-title {
        display: flex;
        align-items: center;
        gap: 1rem;
        font-size: 1.8rem;
        font-weight: 600;
        color: #1e293b;
        margin-bottom: 2rem;
        padding-bottom: 1rem;
        border-bottom: 3px solid #e2e8f0;
        position: relative;
    }

    .section-title::after {
        content: '';
        position: absolute;
        bottom: -3px;
        right: 0;
        width: 80px;
        height: 3px;
        background: linear-gradient(90deg, #7c3aed, #a855f7);
    }

    /* Conversion Controls */
    .conversion-controls {
        margin-bottom: 3rem;
    }

    .controls-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
        gap: 2rem;
    }

    .control-card {
        background: white;
        border-radius: 20px;
        padding: 2.5rem;
        text-align: center;
        transition: all 0.4s ease;
        border: 1px solid #e2e8f0;
        position: relative;
        overflow: hidden;
        box-shadow: 0 8px 24px rgba(0,0,0,0.1);
    }

    .control-card::before {
        content: '';
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        height: 4px;
        background: linear-gradient(90deg, #7c3aed, #a855f7);
        transform: scaleX(0);
        transition: transform 0.3s ease;
    }

    .control-card:hover::before {
        transform: scaleX(1);
    }

    .control-card:hover {
        transform: translateY(-10px) scale(1.02);
        box-shadow: 0 20px 40px rgba(124, 58, 237, 0.15);
    }

    .control-icon {
        width: 70px;
        height: 70px;
        background: linear-gradient(135deg, #7c3aed, #a855f7);
        border-radius: 18px;
        display: flex;
        align-items: center;
        justify-content: center;
        margin: 0 auto 1.5rem;
        color: white;
        font-size: 1.8rem;
        box-shadow: 0 8px 24px rgba(124, 58, 237, 0.3);
    }

    .control-card h3 {
        font-size: 1.5rem;
        font-weight: 600;
        color: #1e293b;
        margin-bottom: 1rem;
    }

    .control-card p {
        color: #64748b;
        margin-bottom: 2rem;
        line-height: 1.6;
    }

    /* Convert Buttons */
    .convert-btn {
        display: inline-flex;
        align-items: center;
        gap: 0.5rem;
        padding: 1rem 2rem;
        border: none;
        border-radius: 12px;
        font-weight: 600;
        font-size: 1rem;
        cursor: pointer;
        transition: all 0.3s ease;
        text-decoration: none;
        outline: none;
    }

    .convert-btn.primary {
        background: linear-gradient(135deg, #7c3aed, #a855f7);
        color: white;
    }

    .convert-btn.primary:hover {
        background: linear-gradient(135deg, #6d28d9, #7c3aed);
        transform: translateY(-2px);
        box-shadow: 0 8px 20px rgba(124, 58, 237, 0.4);
    }

    .convert-btn.secondary {
        background: linear-gradient(135deg, #2563eb, #3b82f6);
        color: white;
    }

    .convert-btn.secondary:hover {
        background: linear-gradient(135deg, #1d4ed8, #2563eb);
        transform: translateY(-2px);
        box-shadow: 0 8px 20px rgba(37, 99, 235, 0.4);
    }

    .convert-btn.warning {
        background: linear-gradient(135deg, #f59e0b, #fbbf24);
        color: white;
    }

    .convert-btn.warning:hover {
        background: linear-gradient(135deg, #d97706, #f59e0b);
        transform: translateY(-2px);
        box-shadow: 0 8px 20px rgba(245, 158, 11, 0.4);
    }

    /* Results Container */
    .conversion-results {
        margin-bottom: 3rem;
    }

    .results-container {
        background: white;
        border-radius: 20px;
        padding: 2rem;
        box-shadow: 0 8px 24px rgba(0,0,0,0.1);
        min-height: 200px;
    }

    /* Live Preview */
    .live-preview {
        margin-bottom: 2rem;
    }

    .preview-section {
        margin-bottom: 3rem;
        background: white;
        border-radius: 20px;
        padding: 2rem;
        box-shadow: 0 8px 24px rgba(0,0,0,0.1);
    }

    .preview-title {
        display: flex;
        align-items: center;
        gap: 1rem;
        font-size: 1.5rem;
        font-weight: 600;
        color: #1e293b;
        margin-bottom: 2rem;
        padding-bottom: 1rem;
        border-bottom: 2px solid #e2e8f0;
    }

    .preview-container {
        background: #f8fafc;
        border: 2px dashed #cbd5e1;
        border-radius: 12px;
        padding: 2rem;
        min-height: 300px;
        position: relative;
        overflow: hidden;
    }

    .preview-container::before {
        content: '';
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background: repeating-linear-gradient(
            45deg,
            transparent,
            transparent 10px,
            rgba(203, 213, 225, 0.1) 10px,
            rgba(203, 213, 225, 0.1) 20px
        );
        pointer-events: none;
    }

    /* Loading Animation */
    .loading-spinner {
        width: 40px;
        height: 40px;
        border: 4px solid #e2e8f0;
        border-top: 4px solid #7c3aed;
        border-radius: 50%;
        animation: spin 1s linear infinite;
        margin: 0 auto;
    }

    @keyframes spin {
        0% { transform: rotate(0deg); }
        100% { transform: rotate(360deg); }
    }

    /* Responsive Design */
    @media (max-width: 768px) {
        .telerik-converter-page {
            padding: 1rem;
        }
        
        .page-header {
            padding: 2rem;
        }
        
        .header-content {
            flex-direction: column;
            text-align: center;
            gap: 1rem;
        }
        
        .conversion-stats {
            grid-template-columns: repeat(auto-fit, minmax(120px, 1fr));
            gap: 1rem;
        }
        
        .controls-grid {
            grid-template-columns: 1fr;
        }
        
        .page-title {
            font-size: 2rem;
        }
    }

    /* Animation Effects */
    .control-card,
    .preview-section {
        animation: slideInUp 0.6s ease-out;
    }

    @keyframes slideInUp {
        from {
            opacity: 0;
            transform: translateY(30px);
        }
        to {
            opacity: 1;
            transform: translateY(0);
        }
    }

    /* Success/Error Messages */
    .conversion-message {
        padding: 1rem;
        border-radius: 8px;
        margin-bottom: 1rem;
        display: flex;
        align-items: center;
        gap: 0.5rem;
    }

    .conversion-message.success {
        background: rgba(16, 185, 129, 0.1);
        border: 1px solid rgba(16, 185, 129, 0.3);
        color: #059669;
    }

    .conversion-message.error {
        background: rgba(239, 68, 68, 0.1);
        border: 1px solid rgba(239, 68, 68, 0.3);
        color: #dc2626;
    }

    .conversion-message.info {
        background: rgba(59, 130, 246, 0.1);
        border: 1px solid rgba(59, 130, 246, 0.3);
        color: #2563eb;
    }
    </style>

    <!-- JavaScript for Interactive Features -->
    <script>
    document.addEventListener('DOMContentLoaded', function() {
        // إحصائيات متحركة
        animateStats();
        
        // إضافة تأثيرات تفاعلية للكاردات
        const cards = document.querySelectorAll('.control-card, .preview-section');
        cards.forEach((card, index) => {
            card.style.animationDelay = (index * 0.1) + 's';
            
            card.addEventListener('mouseenter', function() {
                this.style.zIndex = '10';
            });
            
            card.addEventListener('mouseleave', function() {
                this.style.zIndex = '1';
            });
        });
        
        // تحديث الإحصائيات بشكل دوري
        setInterval(updateStats, 30000); // كل 30 ثانية
    });

    function animateStats() {
        animateCounter('totalConverted', 12, 'controls');
        animateCounter('totalFound', 15, 'controls');
        setTimeout(function() {
            document.getElementById('conversionRate').textContent = '80%';
        }, 2000);
    }

    function animateCounter(elementId, targetValue, type) {
        const element = document.getElementById(elementId);
        if (!element) return;
        
        let currentValue = 0;
        const increment = targetValue / 50;
        const duration = 2000;
        const stepTime = duration / 50;
        
        const timer = setInterval(function() {
            currentValue += increment;
            if (currentValue >= targetValue) {
                currentValue = targetValue;
                clearInterval(timer);
            }
            element.textContent = Math.floor(currentValue);
        }, stepTime);
    }

    function updateStats() {
        // يمكن إضافة تحديثات ديناميكية للإحصائيات هنا
        console.log('تحديث الإحصائيات...');
    }

    function showConversionProgress() {
        const container = document.querySelector('.results-container');
        container.innerHTML = `
            <div style="text-align: center; padding: 2rem;">
                <div class="loading-spinner"></div>
                <p style="margin-top: 1rem; color: #64748b;">جاري تحويل الكنترولات...</p>
            </div>
        `;
    }

    // إضافة تأثير parallax للخلفية
    window.addEventListener('scroll', function() {
        const scrolled = window.pageYOffset;
        const header = document.querySelector('.page-header');
        if (header) {
            header.style.transform = 'translateY(' + (scrolled * 0.2) + 'px)';
        }
    });
    </script>
</asp:Content>
