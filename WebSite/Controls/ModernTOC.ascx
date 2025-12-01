<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ModernTOC.ascx.vb" Inherits="Controls_ModernTOC" %>
<%@ Import Namespace="translatemeyamosso" %>

<style>
    .modern-toc-container {
        background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
        border-radius: 25px;
        padding: 30px;
        box-shadow: 0 20px 40px rgba(102, 126, 234, 0.3);
        margin: 20px 0;
        position: relative;
        overflow: hidden;
        font-family: 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    }

    .modern-toc-container::before {
        content: '';
        position: absolute;
        top: -50%;
        left: -50%;
        width: 200%;
        height: 200%;
        background: linear-gradient(45deg, rgba(255,255,255,0.1) 25%, transparent 25%, transparent 75%, rgba(255,255,255,0.1) 75%, rgba(255,255,255,0.1)),
                    linear-gradient(45deg, rgba(255,255,255,0.1) 25%, transparent 25%, transparent 75%, rgba(255,255,255,0.1) 75%, rgba(255,255,255,0.1));
        background-size: 60px 60px;
        background-position: 0 0, 30px 30px;
        animation: movePattern 20s linear infinite;
        opacity: 0.3;
    }

    @keyframes movePattern {
        0% { transform: translate(-50%, -50%) rotate(0deg); }
        100% { transform: translate(-50%, -50%) rotate(360deg); }
    }

    .modern-toc-header {
        text-align: center;
        margin-bottom: 30px;
        position: relative;
        z-index: 2;
    }

    .modern-toc-title {
        color: white;
        font-size: 2.5rem;
        font-weight: 700;
        text-shadow: 2px 2px 4px rgba(0,0,0,0.3);
        margin: 0;
    }

    .modern-toc-subtitle {
        color: rgba(255, 255, 255, 0.9);
        font-size: 1.2rem;
        margin-top: 10px;
    }

    .modern-nav-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
        gap: 25px;
        position: relative;
        z-index: 2;
    }

    .modern-nav-card {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 25px;
        text-decoration: none;
        color: #2d3748;
        transition: all 0.3s ease;
        box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(15px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        position: relative;
        overflow: hidden;
        display: block;
    }

    .modern-nav-card::before {
        content: '';
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        height: 4px;
        background: linear-gradient(90deg, #667eea, #764ba2);
        transform: scaleX(0);
        transition: transform 0.3s ease;
    }

    .modern-nav-card:hover {
        transform: translateY(-10px);
        box-shadow: 0 25px 50px rgba(0, 0, 0, 0.2);
        color: #2d3748;
        text-decoration: none;
    }

    .modern-nav-card:hover::before {
        transform: scaleX(1);
    }

    .modern-nav-icon {
        font-size: 3rem;
        background: linear-gradient(135deg, #667eea, #764ba2);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        text-align: center;
        margin-bottom: 15px;
        display: block;
    }

    .modern-nav-title {
        font-size: 1.3rem;
        font-weight: 600;
        text-align: center;
        margin-bottom: 10px;
        color: #2d3748;
    }

    .modern-nav-description {
        font-size: 0.9rem;
        color: #64748b;
        text-align: center;
        line-height: 1.6;
    }

    /* Loading Animation */
    .modern-loading-container {
        text-align: center;
        padding: 3rem;
        color: white;
        display: none;
    }

    .modern-loading-container.active {
        display: block;
    }

    .modern-loading-container i {
        font-size: 3rem;
        animation: spin 1s linear infinite;
        margin-bottom: 1rem;
        display: block;
    }

    @keyframes spin {
        0% { transform: rotate(0deg); }
        100% { transform: rotate(360deg); }
    }

    /* Dark Theme Support */
    .dark-theme .modern-toc-container {
        background: linear-gradient(135deg, #1a202c 0%, #2d3748 100%);
    }

    .dark-theme .modern-nav-card {
        background: rgba(45, 55, 72, 0.95);
        color: #e2e8f0;
    }

    .dark-theme .modern-nav-title {
        color: #e2e8f0;
    }

    /* Responsive Design */
    @media (max-width: 768px) {
        .modern-toc-container {
            padding: 20px;
            margin: 10px;
        }
        
        .modern-nav-grid {
            grid-template-columns: 1fr;
            gap: 15px;
        }
        
        .modern-toc-title {
            font-size: 2rem;
        }
        
        .modern-nav-card {
            padding: 20px;
        }
    }
</style>

<div class="modern-toc-container">
    <div class="modern-toc-header">
        <h1 class="modern-toc-title">
            <i class="fas fa-compass" style="margin-right: 15px;"></i>
            Modern Navigation
        </h1>
        <p class="modern-toc-subtitle">Choose the section you want to access</p>
    </div>
    
    <!-- Loading Container (for demo scripts) -->
    <div id="loadingContainer" class="modern-loading-container" runat="server">
        <i class="fas fa-spinner"></i>
        <p>Loading content...</p>
    </div>
    
    <!-- Card Grid (for demo scripts) -->
    <div id="cardGrid" class="modern-nav-grid" runat="server">
        <asp:Repeater ID="rptModernNavigation" runat="server">
            <ItemTemplate>
                <a href='<%# Eval("Url") %>' class="modern-nav-card">
                    <i class="modern-nav-icon <%# Eval("IconClass", "fas fa-cube") %>"></i>
                    <div class="modern-nav-title"><%# translatemeyamosso.GetResourceValuemosso(Eval("Title")) %></div>
                    <div class="modern-nav-description"><%# translatemeyamosso.GetResourceValuemosso(Eval("Description")) %></div>
                </a>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>

<!-- Hidden SiteMap Data Source -->
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="true" StartFromCurrentNode="true"/>

<script>
document.addEventListener('DOMContentLoaded', function() {
    initializeModernTOC();
});

function initializeModernTOC() {
    const cards = document.querySelectorAll('.modern-nav-card');
    cards.forEach((card, index) => {
        card.style.opacity = '0';
        card.style.transform = 'translateY(30px)';
        
        setTimeout(() => {
            card.style.transition = 'all 0.6s ease';
            card.style.opacity = '1';
            card.style.transform = 'translateY(0)';
        }, index * 100);
    });
}
</script>
