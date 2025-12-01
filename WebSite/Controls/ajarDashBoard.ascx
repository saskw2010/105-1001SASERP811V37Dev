<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ajarDashBoard.ascx.vb" Inherits="Controls_ajarDashBoard" %>
<%@ Import Namespace="translatemeyamosso" %>

<!-- Modern Ajar Dashboard with Rental Management Features -->

<style>
    .ajar-dashboard-container {
        background: linear-gradient(135deg, #11998e 0%, #38ef7d 100%);
        border-radius: 25px;
        padding: 30px;
        box-shadow: 0 25px 50px rgba(17, 153, 142, 0.3);
        margin: 25px 0;
        position: relative;
        overflow: hidden;
        min-height: 600px;
    }

    .ajar-dashboard-container::before {
        content: '';
        position: absolute;
        top: -50%;
        left: -50%;
        width: 200%;
        height: 200%;
        background: 
            conic-gradient(from 45deg, rgba(255,255,255,0.1) 0deg, transparent 90deg, rgba(255,255,255,0.05) 180deg, transparent 270deg),
            radial-gradient(circle at 30% 70%, rgba(255,255,255,0.1) 0%, transparent 50%);
        animation: ajarRotate 25s linear infinite;
        z-index: 1;
    }

    @keyframes ajarRotate {
        0% { transform: translate(-50%, -50%) rotate(0deg); }
        100% { transform: translate(-50%, -50%) rotate(360deg); }
    }

    .dashboard-header {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 30px;
        margin-bottom: 35px;
        box-shadow: 0 15px 40px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(15px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        position: relative;
        z-index: 2;
        text-align: center;
    }

    .dashboard-title {
        font-size: 2.8rem;
        font-weight: 800;
        background: linear-gradient(135deg, #11998e, #38ef7d);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin: 0;
        display: flex;
        align-items: center;
        justify-content: center;
        gap: 15px;
    }

    .title-icon {
        font-size: 3rem;
        background: linear-gradient(135deg, #11998e, #38ef7d);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        animation: iconBounce 3s ease-in-out infinite;
    }

    @keyframes iconBounce {
        0%, 100% { transform: translateY(0); }
        50% { transform: translateY(-10px); }
    }

    .category-section {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 25px;
        margin-bottom: 30px;
        box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(15px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        position: relative;
        z-index: 2;
    }

    .category-section::before {
        content: '';
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        height: 4px;
        background: linear-gradient(90deg, #11998e, #38ef7d);
        border-radius: 20px 20px 0 0;
    }

    .category-title {
        font-size: 1.8rem;
        font-weight: 700;
        color: #1e293b;
        margin: 0 0 25px 0;
        padding-bottom: 15px;
        border-bottom: 2px solid #e2e8f0;
        text-align: center;
    }

    .modules-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(280px, 1fr));
        gap: 25px;
        padding: 10px;
    }

    .module-card {
        background: rgba(255, 255, 255, 0.98);
        border-radius: 18px;
        padding: 0;
        box-shadow: 0 12px 30px rgba(0, 0, 0, 0.08);
        transition: all 0.4s cubic-bezier(0.175, 0.885, 0.32, 1.275);
        border: 2px solid transparent;
        position: relative;
        overflow: hidden;
        cursor: pointer;
        text-decoration: none !important;
    }

    .module-card:hover {
        transform: translateY(-12px) scale(1.02);
        box-shadow: 0 25px 50px rgba(0, 0, 0, 0.15);
        border-color: #11998e;
        text-decoration: none !important;
    }

    .module-image-container {
        position: relative;
        height: 180px;
        overflow: hidden;
        border-radius: 18px 18px 0 0;
        background: linear-gradient(135deg, #11998e, #38ef7d);
        display: flex;
        align-items: center;
        justify-content: center;
    }

    .module-image {
        width: 100%;
        height: 100%;
        object-fit: cover;
        transition: transform 0.4s ease;
        border-radius: 18px 18px 0 0;
    }

    .module-card:hover .module-image {
        transform: scale(1.1);
    }

    .default-module-icon {
        font-size: 4rem;
        color: white;
        text-shadow: 2px 2px 4px rgba(0,0,0,0.3);
    }

    .module-overlay {
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background: linear-gradient(135deg, rgba(17, 153, 142, 0.9), rgba(56, 239, 125, 0.9));
        opacity: 0;
        transition: opacity 0.4s ease;
        display: flex;
        align-items: center;
        justify-content: center;
        border-radius: 18px 18px 0 0;
    }

    .module-card:hover .module-overlay {
        opacity: 1;
    }

    .overlay-text {
        color: white;
        font-size: 1.2rem;
        font-weight: 700;
        text-align: center;
        transform: translateY(20px);
        transition: transform 0.4s ease;
        padding: 0 15px;
    }

    .module-card:hover .overlay-text {
        transform: translateY(0);
    }

    .module-content {
        padding: 20px;
        text-align: center;
    }

    .module-title {
        font-size: 1.3rem;
        font-weight: 700;
        color: #1e293b;
        margin: 0 0 10px 0;
        line-height: 1.4;
        transition: color 0.3s ease;
    }

    .module-card:hover .module-title {
        background: linear-gradient(135deg, #11998e, #38ef7d);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
    }

    .module-description {
        color: #64748b;
        font-size: 0.95rem;
        line-height: 1.5;
        margin-top: 8px;
    }

    .module-link {
        text-decoration: none !important;
        color: inherit;
        display: block;
        width: 100%;
        height: 100%;
    }

    .module-link:hover {
        text-decoration: none !important;
        color: inherit;
    }

    .stats-overview {
        background: rgba(255, 255, 255, 0.9);
        border-radius: 15px;
        padding: 20px;
        margin-bottom: 25px;
        backdrop-filter: blur(10px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        position: relative;
        z-index: 2;
    }

    .stats-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
        gap: 20px;
        text-align: center;
    }

    .stat-item {
        padding: 15px;
        border-radius: 12px;
        background: linear-gradient(135deg, rgba(17, 153, 142, 0.1), rgba(56, 239, 125, 0.1));
        border: 1px solid rgba(17, 153, 142, 0.2);
        transition: transform 0.3s ease;
    }

    .stat-item:hover {
        transform: scale(1.05);
    }

    .stat-number {
        font-size: 2rem;
        font-weight: 700;
        background: linear-gradient(135deg, #11998e, #38ef7d);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin-bottom: 5px;
    }

    .stat-label {
        color: #64748b;
        font-size: 0.9rem;
        font-weight: 600;
    }

    /* RTL Support */
    .rtl {
        direction: rtl;
        text-align: right;
    }

    .rtl .dashboard-header,
    .rtl .category-section {
        text-align: center;
    }

    .rtl .module-content {
        text-align: center;
    }

    /* Responsive Design */
    @media (max-width: 768px) {
        .ajar-dashboard-container {
            padding: 20px;
            margin: 15px 0;
        }
        
        .dashboard-title {
            font-size: 2.2rem;
            flex-direction: column;
            gap: 10px;
        }
        
        .modules-grid {
            grid-template-columns: 1fr;
            gap: 20px;
            padding: 0;
        }
        
        .module-card {
            margin: 0 10px;
        }
        
        .module-image-container {
            height: 140px;
        }
    }

    @media (max-width: 480px) {
        .dashboard-title {
            font-size: 1.8rem;
        }
        
        .stats-grid {
            grid-template-columns: 1fr;
        }
    }
</style>

<div class="ajar-dashboard-container rtl">
    <!-- Dashboard Header -->
    <div class="dashboard-header">
        <h1 class="dashboard-title">
            <i class="fas fa-building title-icon"></i>
            لوحة إدارة الإيجارات
        </h1>
        <p style="color: #64748b; font-size: 1.2rem; margin-top: 15px;">نظام شامل لإدارة العقارات والإيجارات</p>
    </div>

    <!-- Statistics Overview -->
    <div class="stats-overview">
        <div class="stats-grid">
            <div class="stat-item">
                <div class="stat-number">156</div>
                <div class="stat-label">إجمالي العقارات</div>
            </div>
            <div class="stat-item">
                <div class="stat-number">89</div>
                <div class="stat-label">العقارات المؤجرة</div>
            </div>
            <div class="stat-item">
                <div class="stat-number">67</div>
                <div class="stat-label">العقارات المتاحة</div>
            </div>
            <div class="stat-item">
                <div class="stat-number">95%</div>
                <div class="stat-label">معدل الإشغال</div>
            </div>
        </div>
    </div>

    <!-- Modules by Category -->
    <asp:Repeater ID="rptCategories" runat="server">
        <ItemTemplate>
            <div class="category-section">
                <h2 class="category-title">
                    <%# translatemeyamosso.GetResourceValuemosso(Eval("Title"))%>
                </h2>
                
                <div class="modules-grid">
                    <asp:Repeater ID="rptModules" runat="server" DataSource='<%# Eval("Modules") %>'>
                        <ItemTemplate>
                            <a href='<%# Eval("Url") %>' class="module-link" target="_blank">
                                <div class="module-card">
                                    <div class="module-image-container">
                                        <asp:Image ID="imgModule" runat="server" 
                                            CssClass="module-image"
                                            ImageUrl='<%# Eval("Description") %>'
                                            AlternateText='<%# Eval("Title") %>'
                                            onerror="this.style.display='none'; this.parentElement.innerHTML='<div class=\'default-module-icon\'><i class=\'fas fa-home\'></i></div>';" />
                                        <div class="module-overlay">
                                            <div class="overlay-text">
                                                <%# translatemeyamosso.GetResourceValuemosso(Eval("ResourceKey"))%>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="module-content">
                                        <h3 class="module-title">
                                            <%# translatemeyamosso.GetResourceValuemosso(Eval("Title"))%>
                                        </h3>
                                        <p class="module-description">
                                            <%# GetModuleDescription(Eval("Title")) %>
                                        </p>
                                    </div>
                                </div>
                            </a>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <!-- Hidden Data Source for Backward Compatibility -->
    <asp:XmlDataSource ID="xmlModules" runat="server" DataFile="~/eZeeajar/Modules.Sitemap" />
</div>

<script>
// Dashboard initialization
document.addEventListener('DOMContentLoaded', function() {
    animateStats();
    setupImageLazyLoading();
    trackUserInteractions();
});

// Animate statistics counters
function animateStats() {
    const stats = [
        { element: document.querySelector('.stat-number'), target: 156 },
        { element: document.querySelectorAll('.stat-number')[1], target: 89 },
        { element: document.querySelectorAll('.stat-number')[2], target: 67 }
    ];
    
    stats.forEach(stat => {
        if (stat.element) {
            animateCounter(stat.element, stat.target);
        }
    });
}

// Counter animation function
function animateCounter(element, target) {
    let current = 0;
    const increment = target / 50;
    const timer = setInterval(() => {
        current += increment;
        if (current >= target) {
            current = target;
            clearInterval(timer);
        }
        element.textContent = Math.floor(current);
    }, 20);
}

// Setup lazy loading for images
function setupImageLazyLoading() {
    if ('IntersectionObserver' in window) {
        const imageObserver = new IntersectionObserver((entries, observer) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    const img = entry.target;
                    img.classList.add('loaded');
                    observer.unobserve(img);
                }
            });
        });
        
        document.querySelectorAll('.module-image').forEach(img => {
            imageObserver.observe(img);
        });
    }
}

// Track user interactions
function trackUserInteractions() {
    document.querySelectorAll('.module-card').forEach(card => {
        card.addEventListener('click', function() {
            const title = this.querySelector('.module-title').textContent;
            console.log('Module clicked:', title);
            
            // Add click animation
            this.style.transform = 'scale(0.95)';
            setTimeout(() => {
                this.style.transform = '';
            }, 150);
        });
    });
}

// Enhanced error handling for images
function handleImageError(img) {
    const container = img.parentElement;
    container.innerHTML = '<div class="default-module-icon"><i class="fas fa-home"></i></div>';
}

// Performance monitoring
function trackPerformance() {
    if ('performance' in window) {
        window.addEventListener('load', () => {
            const loadTime = performance.timing.loadEventEnd - performance.timing.navigationStart;
            console.log(`Ajar Dashboard loaded in ${loadTime}ms`);
        });
    }
}

trackPerformance();
</script>

