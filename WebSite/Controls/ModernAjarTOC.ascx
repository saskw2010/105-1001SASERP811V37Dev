<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ModernAjarTOC.ascx.vb" Inherits="Controls_ModernAjarTOC" %>
<%@ Import Namespace="translatemeyamosso" %>

<style>
    .modern-ajar-container {
        background: linear-gradient(135deg, #667eea 0%, #764ba2 100%, #f093fb 100%);
        border-radius: 30px;
        padding: 40px;
        box-shadow: 0 25px 50px rgba(102, 126, 234, 0.4);
        margin: 20px 0;
        position: relative;
        overflow: hidden;
        font-family: 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    }

    .modern-ajar-container::before {
        content: '';
        position: absolute;
        top: -50%;
        left: -50%;
        width: 200%;
        height: 200%;
        background: radial-gradient(circle, rgba(255,255,255,0.15) 2px, transparent 2px);
        background-size: 40px 40px;
        animation: orbitalMove 30s linear infinite;
        opacity: 0.6;
    }

    @keyframes orbitalMove {
        0% { transform: translate(-50%, -50%) rotate(0deg); }
        100% { transform: translate(-50%, -50%) rotate(360deg); }
    }

    .modern-ajar-header {
        text-align: center;
        margin-bottom: 40px;
        position: relative;
        z-index: 2;
    }

    .modern-ajar-title {
        color: white;
        font-size: 3rem;
        font-weight: 800;
        text-shadow: 3px 3px 6px rgba(0,0,0,0.4);
        margin: 0;
        background: linear-gradient(45deg, #ffffff, #f0f9ff);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
    }

    .modern-ajar-subtitle {
        color: rgba(255, 255, 255, 0.95);
        font-size: 1.4rem;
        margin-top: 15px;
        font-weight: 300;
    }

    .modern-ajar-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(320px, 1fr));
        gap: 30px;
        position: relative;
        z-index: 2;
    }

    .modern-ajar-card {
        background: rgba(255, 255, 255, 0.98);
        border-radius: 25px;
        padding: 30px;
        text-decoration: none;
        color: #1a202c;
        transition: all 0.4s cubic-bezier(0.175, 0.885, 0.32, 1.275);
        box-shadow: 0 20px 40px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(20px);
        border: 2px solid rgba(255, 255, 255, 0.4);
        position: relative;
        overflow: hidden;
        display: block;
    }

    .modern-ajar-card::before {
        content: '';
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        height: 5px;
        background: linear-gradient(90deg, #667eea, #764ba2, #f093fb);
        transform: scaleX(0);
        transition: transform 0.4s ease;
    }

    .modern-ajar-card::after {
        content: '';
        position: absolute;
        top: 15px;
        right: 15px;
        width: 40px;
        height: 40px;
        border-radius: 50%;
        background: linear-gradient(135deg, rgba(102, 126, 234, 0.2), rgba(240, 147, 251, 0.2));
        opacity: 0;
        transition: all 0.3s ease;
    }

    .modern-ajar-card:hover {
        transform: translateY(-15px) scale(1.02);
        box-shadow: 0 35px 70px rgba(0, 0, 0, 0.25);
        color: #1a202c;
        text-decoration: none;
    }

    .modern-ajar-card:hover::before {
        transform: scaleX(1);
    }

    .modern-ajar-card:hover::after {
        opacity: 1;
        transform: scale(1.2);
    }

    .modern-ajar-icon {
        font-size: 3.5rem;
        background: linear-gradient(135deg, #667eea, #764ba2, #f093fb);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        text-align: center;
        margin-bottom: 20px;
        display: block;
        transition: transform 0.3s ease;
    }

    .modern-ajar-card:hover .modern-ajar-icon {
        transform: scale(1.1) rotate(5deg);
    }

    .modern-ajar-title-text {
        font-size: 1.5rem;
        font-weight: 700;
        text-align: center;
        margin-bottom: 15px;
        color: #1a202c;
        background: linear-gradient(135deg, #1a202c, #4a5568);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
    }

    .modern-ajar-description {
        font-size: 1rem;
        color: #4a5568;
        text-align: center;
        line-height: 1.7;
        margin-bottom: 15px;
    }

    .modern-ajar-badge {
        display: inline-block;
        background: linear-gradient(135deg, rgba(102, 126, 234, 0.1), rgba(240, 147, 251, 0.1));
        color: #667eea;
        padding: 0.5rem 1rem;
        border-radius: 20px;
        font-size: 0.8rem;
        font-weight: 600;
        text-transform: uppercase;
        letter-spacing: 1px;
        border: 1px solid rgba(102, 126, 234, 0.2);
        margin-top: 10px;
    }

    /* Enhanced Loading Animation */
    .modern-ajar-loading {
        text-align: center;
        padding: 4rem;
        color: white;
        display: none;
    }

    .modern-ajar-loading.active {
        display: block;
    }

    .orbital-loader {
        display: inline-block;
        position: relative;
        width: 80px;
        height: 80px;
        margin-bottom: 2rem;
    }

    .orbital-loader div {
        position: absolute;
        top: 33px;
        width: 13px;
        height: 13px;
        border-radius: 50%;
        background: white;
        animation-timing-function: cubic-bezier(0, 1, 1, 0);
    }

    .orbital-loader div:nth-child(1) {
        left: 8px;
        animation: orbital1 0.6s infinite;
    }

    .orbital-loader div:nth-child(2) {
        left: 8px;
        animation: orbital2 0.6s infinite;
    }

    .orbital-loader div:nth-child(3) {
        left: 32px;
        animation: orbital2 0.6s infinite;
    }

    .orbital-loader div:nth-child(4) {
        left: 56px;
        animation: orbital3 0.6s infinite;
    }

    @keyframes orbital1 {
        0% { transform: scale(0); }
        100% { transform: scale(1); }
    }

    @keyframes orbital3 {
        0% { transform: scale(1); }
        100% { transform: scale(0); }
    }

    @keyframes orbital2 {
        0% { transform: translate(0, 0); }
        100% { transform: translate(24px, 0); }
    }

    /* Dark Theme Support */
    .dark-theme .modern-ajar-container {
        background: linear-gradient(135deg, #1a202c 0%, #2d3748 50%, #4a5568 100%);
    }

    .dark-theme .modern-ajar-card {
        background: rgba(26, 32, 44, 0.95);
        color: #e2e8f0;
    }

    .dark-theme .modern-ajar-title-text {
        color: #e2e8f0;
        background: linear-gradient(135deg, #e2e8f0, #cbd5e0);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
    }

    /* Enhanced Responsive Design */
    @media (max-width: 768px) {
        .modern-ajar-container {
            padding: 25px;
            margin: 15px;
        }
        
        .modern-ajar-grid {
            grid-template-columns: 1fr;
            gap: 20px;
        }
        
        .modern-ajar-title {
            font-size: 2.2rem;
        }
        
        .modern-ajar-card {
            padding: 25px;
        }
        
        .modern-ajar-icon {
            font-size: 3rem;
        }
    }

    @media (max-width: 480px) {
        .modern-ajar-title {
            font-size: 1.8rem;
        }
        
        .modern-ajar-card {
            padding: 20px;
        }
    }
</style>

<div class="modern-ajar-container">
    <div class="modern-ajar-header">
        <h1 class="modern-ajar-title">
            <i class="fas fa-rocket" style="margin-right: 20px;"></i>
            Premium Navigation
        </h1>
        <p class="modern-ajar-subtitle">Advanced navigation with enhanced features</p>
    </div>
    
    <!-- Enhanced Loading Container -->
    <div id="ajarLoadingContainer" class="modern-ajar-loading" runat="server">
        <div class="orbital-loader">
            <div></div>
            <div></div>
            <div></div>
            <div></div>
        </div>
        <p>Loading premium content...</p>
    </div>
    
    <!-- Enhanced Card Grid -->
    <div id="ajarCardGrid" class="modern-ajar-grid" runat="server">
        <asp:Repeater ID="rptModernAjarNavigation" runat="server">
            <ItemTemplate>
                <a href='<%# Eval("Url") %>' class="modern-ajar-card">
                    <i class="modern-ajar-icon <%# Eval("IconClass", "fas fa-cube") %>"></i>
                    <div class="modern-ajar-title-text"><%# translatemeyamosso.GetResourceValuemosso(Eval("Title")) %></div>
                    <div class="modern-ajar-description"><%# translatemeyamosso.GetResourceValuemosso(Eval("Description")) %></div>
                    <div class="modern-ajar-badge">Premium</div>
                </a>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>

<!-- Hidden SiteMap Data Source -->
<asp:SiteMapDataSource ID="SiteMapDataSourceAjar" runat="server" ShowStartingNode="true" StartFromCurrentNode="true"/>

<script>
document.addEventListener('DOMContentLoaded', function() {
    initializeModernAjarTOC();
});

function initializeModernAjarTOC() {
    const cards = document.querySelectorAll('.modern-ajar-card');
    cards.forEach((card, index) => {
        card.style.opacity = '0';
        card.style.transform = 'translateY(50px) scale(0.9)';
        
        setTimeout(() => {
            card.style.transition = 'all 0.8s cubic-bezier(0.175, 0.885, 0.32, 1.275)';
            card.style.opacity = '1';
            card.style.transform = 'translateY(0) scale(1)';
        }, index * 150);
    });

    // Add scroll-triggered animations
    const observerOptions = {
        threshold: 0.1,
        rootMargin: '0px 0px -50px 0px'
    };

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.style.animationPlayState = 'running';
            }
        });
    }, observerOptions);

    cards.forEach(card => {
        observer.observe(card);
    });
}
</script>
