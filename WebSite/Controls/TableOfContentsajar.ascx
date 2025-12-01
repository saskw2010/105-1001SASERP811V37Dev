<%@ Control Language="VB" AutoEventWireup="false" CodeFile="TableOfContentsajar.ascx.vb" Inherits="Controls_TableOfContentsajar"  %>
<%@ Import Namespace="translatemeyamosso"%>  

<!-- Modern Ajar Table of Contents -->
<style>
    .ajar-toc-container {
        background: linear-gradient(135deg, #f093fb 0%, #f5576c 100%);
        border-radius: 25px;
        padding: 30px;
        box-shadow: 0 20px 40px rgba(240, 147, 251, 0.3);
        margin: 20px;
        position: relative;
        overflow: hidden;
        font-family: 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        direction: rtl;
        min-height: 600px;
    }

    .ajar-toc-container::before {
        content: '';
        position: absolute;
        top: -50%;
        left: -50%;
        width: 200%;
        height: 200%;
        background: radial-gradient(circle, rgba(255,255,255,0.1) 2px, transparent 2px);
        background-size: 50px 50px;
        animation: floatPattern 15s ease-in-out infinite;
        opacity: 0.4;
    }

    @keyframes floatPattern {
        0%, 100% { transform: translate(-50%, -50%) rotate(0deg); }
        50% { transform: translate(-50%, -50%) rotate(180deg); }
    }

    .ajar-header {
        text-align: center;
        margin-bottom: 30px;
        position: relative;
        z-index: 2;
    }

    .ajar-title {
        color: white;
        font-size: 2.8rem;
        font-weight: 700;
        text-shadow: 2px 2px 4px rgba(0,0,0,0.3);
        margin: 0;
        background: linear-gradient(45deg, #fff, #fef7ff);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
    }

    .ajar-subtitle {
        color: rgba(255, 255, 255, 0.95);
        font-size: 1.3rem;
        margin-top: 15px;
        font-weight: 500;
    }

    .ajar-navigation-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(280px, 1fr));
        gap: 20px;
        position: relative;
        z-index: 2;
    }

    .ajar-nav-card {
        background: rgba(255, 255, 255, 0.98);
        border-radius: 20px;
        padding: 25px;
        text-decoration: none;
        color: #2d3748;
        transition: all 0.4s ease;
        box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(20px);
        border: 1px solid rgba(255, 255, 255, 0.4);
        position: relative;
        overflow: hidden;
        transform: translateY(0);
    }

    .ajar-nav-card::before {
        content: '';
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        height: 5px;
        background: linear-gradient(90deg, #f093fb, #f5576c, #4facfe);
        transform: scaleX(0);
        transition: transform 0.4s ease;
    }

    .ajar-nav-card:hover {
        transform: translateY(-15px) scale(1.02);
        box-shadow: 0 30px 60px rgba(0, 0, 0, 0.2);
        color: #2d3748;
        text-decoration: none;
    }

    .ajar-nav-card:hover::before {
        transform: scaleX(1);
    }

    .ajar-nav-icon {
        font-size: 3.5rem;
        background: linear-gradient(135deg, #f093fb, #f5576c);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        text-align: center;
        margin-bottom: 20px;
        display: block;
        position: relative;
    }

    .ajar-nav-icon::after {
        content: '';
        position: absolute;
        bottom: -10px;
        left: 50%;
        transform: translateX(-50%);
        width: 30px;
        height: 3px;
        background: linear-gradient(90deg, #f093fb, #f5576c);
        border-radius: 2px;
    }

    .ajar-nav-title {
        font-size: 1.4rem;
        font-weight: 700;
        text-align: center;
        margin-bottom: 12px;
        color: #2d3748;
        line-height: 1.3;
    }

    .ajar-nav-description {
        font-size: 1rem;
        color: #64748b;
        text-align: center;
        line-height: 1.7;
        margin-bottom: 15px;
    }

    .ajar-nav-badge {
        display: inline-block;
        background: linear-gradient(135deg, #f093fb, #f5576c);
        color: white;
        padding: 5px 12px;
        border-radius: 15px;
        font-size: 0.8rem;
        font-weight: 600;
        text-align: center;
        width: 100%;
        box-sizing: border-box;
    }

    /* Enhanced Loading Animation */
    .ajar-loading {
        text-align: center;
        padding: 4rem;
        color: white;
    }

    .ajar-loading i {
        font-size: 4rem;
        animation: pulse 2s ease-in-out infinite;
        margin-bottom: 1.5rem;
        display: block;
    }

    @keyframes pulse {
        0%, 100% { 
            opacity: 1; 
            transform: scale(1);
        }
        50% { 
            opacity: 0.7; 
            transform: scale(1.1);
        }
    }

    /* Responsive Design */
    @media (max-width: 768px) {
        .ajar-toc-container {
            padding: 20px;
            margin: 10px;
        }
        
        .ajar-navigation-grid {
            grid-template-columns: 1fr;
            gap: 15px;
        }
        
        .ajar-title {
            font-size: 2.2rem;
        }
        
        .ajar-nav-card {
            padding: 20px;
        }
        
        .ajar-nav-icon {
            font-size: 3rem;
        }
    }

    /* RTL Enhancements */
    .rtl-enhanced {
        direction: rtl;
        text-align: right;
    }
</style>

<div class="fullscreen_bgq" />
<div id="#regContainer1">
    <div class="ajar-toc-container rtl-enhanced">
        <div class="ajar-header">
            <h1 class="ajar-title">
                <i class="fas fa-building" style="margin-left: 20px;"></i>
                نظام إدارة الإيجارات
            </h1>
            <p class="ajar-subtitle">إدارة شاملة لعقود الإيجار والممتلكات</p>
        </div>
        
        <div class="ajar-navigation-grid" id="ajarNavigationGrid">
            <div class="ajar-loading">
                <i class="fas fa-home"></i>
                <p>جاري تحميل وحدات الإيجار...</p>
            </div>
        </div>
    </div>
</div>

<!-- Hidden Controls for Data Binding -->
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="true" StartFromCurrentNode="true"/>
<asp:Repeater ID="rptAjarNavigation" runat="server">
    <ItemTemplate>
        <a href='<%# Eval("Url") %>' class="ajar-nav-card" style="display: none;">
            <i class="ajar-nav-icon <%# Eval("Icon") %>"></i>
            <div class="ajar-nav-title"><%# translatemeyamosso.GetResourceValuemosso(Eval("Title")) %></div>
            <div class="ajar-nav-description"><%# translatemeyamosso.GetResourceValuemosso(Eval("Description")) %></div>
            <div class="ajar-nav-badge">الوحدة متاحة</div>
        </a>
    </ItemTemplate>
</asp:Repeater>

<script>
document.addEventListener('DOMContentLoaded', function() {
    loadAjarNavigationItems();
    addAjarAnimations();
});

function loadAjarNavigationItems() {
    // Get the hidden repeater items and convert them to visible navigation cards
    const hiddenCards = document.querySelectorAll('.ajar-nav-card[style*="display: none"]');
    const navigationGrid = document.getElementById('ajarNavigationGrid');
    
    // Clear loading
    navigationGrid.innerHTML = '';
    
    if (hiddenCards.length === 0) {
        // Fallback Ajar-specific navigation items
        const ajarItems = [
            { 
                icon: 'fas fa-home', 
                title: 'إدارة العقارات', 
                description: 'عرض وإدارة جميع العقارات والوحدات السكنية',
                url: '~/Pages/Properties.aspx' 
            },
            { 
                icon: 'fas fa-file-contract', 
                title: 'عقود الإيجار', 
                description: 'إنشاء وإدارة عقود الإيجار للمستأجرين',
                url: '~/Pages/Contracts.aspx' 
            },
            { 
                icon: 'fas fa-users', 
                title: 'إدارة المستأجرين', 
                description: 'قاعدة بيانات المستأجرين ومعلوماتهم',
                url: '~/Pages/Tenants.aspx' 
            },
            { 
                icon: 'fas fa-dollar-sign', 
                title: 'الدفعات والفواتير', 
                description: 'تتبع المدفوعات وإصدار الفواتير',
                url: '~/Pages/Payments.aspx' 
            },
            { 
                icon: 'fas fa-tools', 
                title: 'الصيانة والخدمات', 
                description: 'إدارة طلبات الصيانة والخدمات',
                url: '~/Pages/Maintenance.aspx' 
            },
            { 
                icon: 'fas fa-chart-line', 
                title: 'التقارير المالية', 
                description: 'تقارير الأرباح والخسائر والإحصائيات',
                url: '~/Pages/FinancialReports.aspx' 
            }
        ];
        
        ajarItems.forEach(item => {
            const card = createAjarNavigationCard(item);
            navigationGrid.appendChild(card);
        });
    } else {
        // Use sitemap data
        hiddenCards.forEach(card => {
            card.style.display = '';
            navigationGrid.appendChild(card.cloneNode(true));
        });
    }
}

function createAjarNavigationCard(item) {
    const card = document.createElement('a');
    card.href = item.url;
    card.className = 'ajar-nav-card';
    card.innerHTML = `
        <i class="ajar-nav-icon ${item.icon}"></i>
        <div class="ajar-nav-title">${item.title}</div>
        <div class="ajar-nav-description">${item.description}</div>
        <div class="ajar-nav-badge">الوحدة متاحة</div>
    `;
    return card;
}

function addAjarAnimations() {
    const cards = document.querySelectorAll('.ajar-nav-card');
    cards.forEach((card, index) => {
        card.style.opacity = '0';
        card.style.transform = 'translateY(50px) scale(0.9)';
        
        setTimeout(() => {
            card.style.transition = 'all 0.8s cubic-bezier(0.175, 0.885, 0.32, 1.275)';
            card.style.opacity = '1';
            card.style.transform = 'translateY(0) scale(1)';
        }, index * 150);
    });
}
</script>
      <span class="round-tabs1 buttonhomeimage1 text-center">
          فهرس المحتوى - أجار
      </span>

</div>
                        
</div>


</div>
</div>
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />