<%@ Control Language="VB" AutoEventWireup="false" CodeFile="schoolDashBoard.ascx.vb" Inherits="Controls_schoolDashBoard" %>
<%@ Import Namespace="translatemeyamosso" %>

<!-- Modern School Dashboard with Material Design -->

 <style>
    .school-dashboard-container {
        background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
        border-radius: 25px;
        padding: 30px;
        box-shadow: 0 25px 50px rgba(102, 126, 234, 0.3);
        margin: 25px 0;
        position: relative;
        overflow: hidden;
        min-height: 500px;
    }

    .school-dashboard-container::before {
        content: '';
        position: absolute;
        top: -50%;
        left: -50%;
        width: 200%;
        height: 200%;
        background: 
            radial-gradient(circle at 20% 80%, rgba(255,255,255,0.1) 0%, transparent 50%),
            radial-gradient(circle at 80% 20%, rgba(255,255,255,0.15) 0%, transparent 50%),
            linear-gradient(45deg, rgba(255,255,255,0.05) 25%, transparent 25%, transparent 75%, rgba(255,255,255,0.05) 75%);
        background-size: 100% 100%, 100% 100%, 60px 60px;
        animation: dashboardFloat 20s ease-in-out infinite;
        z-index: 1;
    }

    @keyframes dashboardFloat {
        0%, 100% { transform: translate(-50%, -50%) rotate(0deg) scale(1); }
        33% { transform: translate(-45%, -55%) rotate(1deg) scale(1.02); }
        66% { transform: translate(-55%, -45%) rotate(-1deg) scale(0.98); }
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
        transform: translateY(0);
        transition: transform 0.3s ease;
    }

    .dashboard-header:hover {
        transform: translateY(-5px);
    }

    .dashboard-title {
        font-size: 2.8rem;
        font-weight: 800;
        background: linear-gradient(135deg, #667eea, #764ba2);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin: 0;
        display: flex;
        align-items: center;
        justify-content: center;
        gap: 15px;
        text-shadow: 2px 2px 4px rgba(0,0,0,0.1);
    }

    .title-icon {
        font-size: 3rem;
        background: linear-gradient(135deg, #667eea, #764ba2);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        animation: iconPulse 2s ease-in-out infinite;
    }

    @keyframes iconPulse {
        0%, 100% { transform: scale(1); }
        50% { transform: scale(1.1); }
    }

    .dashboard-subtitle {
        color: #64748b;
        font-size: 1.2rem;
        margin-top: 15px;
        font-weight: 500;
    }

    .navigation-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
        gap: 25px;
        position: relative;
        z-index: 2;
        padding: 0 10px;
    }

    .nav-card {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 0;
        box-shadow: 0 20px 40px rgba(0, 0, 0, 0.1);
        transition: all 0.4s cubic-bezier(0.175, 0.885, 0.32, 1.275);
        backdrop-filter: blur(15px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        position: relative;
        overflow: hidden;
        cursor: pointer;
        text-decoration: none !important;
    }

    .nav-card::before {
        content: '';
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        height: 5px;
        background: linear-gradient(90deg, #667eea, #764ba2, #f093fb, #f5576c);
        border-radius: 20px 20px 0 0;
    }

    .nav-card:hover {
        transform: translateY(-15px) scale(1.03);
        box-shadow: 0 30px 60px rgba(0, 0, 0, 0.2);
        text-decoration: none !important;
    }

    .nav-card:hover .card-image {
        transform: scale(1.1);
    }

    .nav-card:hover .overlay {
        opacity: 0.9;
    }

    .card-image-container {
        position: relative;
        height: 200px;
        overflow: hidden;
        border-radius: 20px 20px 0 0;
    }

    .card-image {
        width: 100%;
        height: 100%;
        object-fit: cover;
        transition: transform 0.4s ease;
        border-radius: 20px 20px 0 0;
    }

    .overlay {
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background: linear-gradient(135deg, rgba(102, 126, 234, 0.8), rgba(118, 75, 162, 0.8));
        opacity: 0;
        transition: opacity 0.4s ease;
        display: flex;
        align-items: center;
        justify-content: center;
        border-radius: 20px 20px 0 0;
    }

    .overlay-text {
        color: white;
        font-size: 1.3rem;
        font-weight: 700;
        text-align: center;
        transform: translateY(10px);
        transition: transform 0.4s ease;
        padding: 0 20px;
        text-shadow: 2px 2px 4px rgba(0,0,0,0.3);
    }

    .nav-card:hover .overlay-text {
        transform: translateY(0);
    }

    .card-content {
        padding: 25px;
        text-align: center;
    }

    .card-title {
        font-size: 1.4rem;
        font-weight: 700;
        color: #1e293b;
        margin: 0;
        line-height: 1.4;
        transition: color 0.3s ease;
    }

    .nav-card:hover .card-title {
        background: linear-gradient(135deg, #667eea, #764ba2);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
    }

    .card-description {
        color: #64748b;
        font-size: 0.95rem;
        margin-top: 10px;
        line-height: 1.5;
    }

    .nav-link {
        text-decoration: none !important;
        color: inherit;
        display: block;
    }

    .nav-link:hover {
        text-decoration: none !important;
        color: inherit;
    }

    .default-image {
        background: linear-gradient(135deg, #667eea, #764ba2);
        display: flex;
        align-items: center;
        justify-content: center;
        color: white;
        font-size: 4rem;
        width: 100%;
        height: 100%;
    }

    .loading-placeholder {
        background: linear-gradient(90deg, #f0f0f0 25%, #e0e0e0 50%, #f0f0f0 75%);
        background-size: 200% 100%;
        animation: loading 1.5s infinite;
        height: 200px;
        border-radius: 20px 20px 0 0;
    }

    @keyframes loading {
        0% { background-position: 200% 0; }
        100% { background-position: -200% 0; }
    }

    .stats-bar {
        background: rgba(255, 255, 255, 0.9);
        border-radius: 15px;
        padding: 20px;
        margin-bottom: 25px;
        box-shadow: 0 10px 25px rgba(0, 0, 0, 0.1);
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
        background: linear-gradient(135deg, rgba(102, 126, 234, 0.1), rgba(118, 75, 162, 0.1));
        border: 1px solid rgba(102, 126, 234, 0.2);
        transition: transform 0.3s ease;
    }

    .stat-item:hover {
        transform: scale(1.05);
    }

    .stat-number {
        font-size: 2rem;
        font-weight: 700;
        background: linear-gradient(135deg, #667eea, #764ba2);
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

    .rtl .dashboard-header {
        text-align: center;
    }

    .rtl .card-content {
        text-align: center;
    }

    /* Responsive Design */
    @media (max-width: 768px) {
        .school-dashboard-container {
            padding: 20px;
            margin: 15px 0;
        }
        
        .dashboard-title {
            font-size: 2.2rem;
            flex-direction: column;
            gap: 10px;
        }
        
        .navigation-grid {
            grid-template-columns: 1fr;
            gap: 20px;
            padding: 0;
        }
        
        .nav-card {
            margin: 0 10px;
        }
        
        .card-image-container {
            height: 150px;
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

<div class="school-dashboard-container rtl">
   

    <!-- Navigation Grid -->
    <div class="navigation-grid">
        <asp:Repeater ID="rptNavigation" runat="server">
            <ItemTemplate>
                <a href='<%# Eval("Url") %>' class="nav-link">
                    <div class="nav-card">
                        <div class="card-image-container">
                            <asp:Image ID="imgModule" runat="server" 
                                CssClass="card-image"
                                ImageUrl='<%# GetModuleImage(Eval("Url")) %>'
                                AlternateText='<%# Eval("Title") %>'
                                onerror="this.style.display='none'; this.parentElement.innerHTML='<div class=\'default-image\'><i class=\'fas fa-cogs\'></i></div>';" />
                            <div class="overlay">
                                <div class="overlay-text">
                                    <%# translatemeyamosso.GetResourceValuemosso(Eval("Title"))%>
                                </div>
                            </div>
                        </div>
                        <div class="card-content">
                            <h3 class="card-title">
                                <%# translatemeyamosso.GetResourceValuemosso(Eval("Title"))%>
                            </h3>
                            <p class="card-description">
                                <%# GetModuleDescription(Eval("Title")) %>
                            </p>
                        </div>
                    </div>
                </a>
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <!-- Hidden Data Source for Backward Compatibility -->
    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" 
        ShowStartingNode="true" StartFromCurrentNode="false" />
</div>

<script>
// Dashboard initialization
document.addEventListener('DOMContentLoaded', function() {
    animateStats();
    preloadImages();
    setupLazyLoading();
});

// Animate statistics counters
function animateStats() {
    const stats = [
        { element: 'totalUsers', target: 1247 },
        { element: 'activeModules', target: 12 },
        { element: 'todayAccess', target: 89 }
    ];
    
    stats.forEach(stat => {
        animateCounter(stat.element, stat.target);
    });
}

// Counter animation function
function animateCounter(elementId, target) {
    const element = document.getElementById(elementId);
    if (!element) return;
    
    let current = 0;
    const increment = target / 60; // 60 frames for smooth animation
    const timer = setInterval(() => {
        current += increment;
        if (current >= target) {
            current = target;
            clearInterval(timer);
        }
        element.textContent = Math.floor(current).toLocaleString();
    }, 16); // ~60fps
}

// Preload images for better performance
function preloadImages() {
    const images = document.querySelectorAll('.card-image');
    images.forEach(img => {
        if (img.src) {
            const preload = new Image();
            preload.src = img.src;
        }
    });
}

// Setup lazy loading for images
function setupLazyLoading() {
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
        
        document.querySelectorAll('.card-image').forEach(img => {
            imageObserver.observe(img);
        });
    }
}

// Enhanced error handling for images
function handleImageError(img) {
    const container = img.parentElement;
    container.innerHTML = '<div class="default-image"><i class="fas fa-cogs"></i></div>';
}

// Add smooth scrolling for navigation
function scrollToTop() {
    window.scrollTo({
        top: 0,
        behavior: 'smooth'
    });
}

// Performance monitoring
function trackPerformance() {
    if ('performance' in window) {
        window.addEventListener('load', () => {
            const loadTime = performance.timing.loadEventEnd - performance.timing.navigationStart;
            console.log(`Dashboard loaded in ${loadTime}ms`);
        });
    }
}

trackPerformance();
</script>
     

      
    

