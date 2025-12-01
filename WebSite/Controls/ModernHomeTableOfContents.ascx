<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ModernHomeTableOfContents.ascx.vb" Inherits="Controls_ModernHomeTableOfContents"  %>
<%@ Import Namespace="translatemeyamosso"%> 

<!-- Modern Home Navigation Control - Non-Telerik Version -->
<div id="modernHomeNavigation" class="modern-home-navigation-container">
    
    <!-- Header Section -->
    <div class="navigation-header">
        <h2 class="nav-title">
            <i class="fas fa-home"></i>
            <%= translatemeyamosso.GetResourceValuemosso("Navigation") %>
        </h2>
        <p class="nav-subtitle">الصفحة الرئيسية - التنقل السريع</p>
    </div>

    <!-- Navigation Grid -->
    <div id="modernHomeGrid" class="modern-home-grid">
        <!-- Loading placeholder -->
        <div class="home-loading-placeholder">
            <div class="loading-animation">
                <i class="fas fa-home fa-spin"></i>
                <p>جاري تحميل صفحات النظام...</p>
            </div>
        </div>
    </div>

    <!-- Statistics Section -->
    <div class="home-statistics-section">
        <div class="stats-grid">
            <div class="stat-card">
                <div class="stat-icon">
                    <i class="fas fa-users"></i>
                </div>
                <div class="stat-content">
                    <h3 id="totalUsers">---</h3>
                    <p>إجمالي المستخدمين</p>
                </div>
            </div>
            
            <div class="stat-card">
                <div class="stat-icon">
                    <i class="fas fa-file-alt"></i>
                </div>
                <div class="stat-content">
                    <h3 id="totalPages">---</h3>
                    <p>إجمالي الصفحات</p>
                </div>
            </div>
            
            <div class="stat-card">
                <div class="stat-icon">
                    <i class="fas fa-clock"></i>
                </div>
                <div class="stat-content">
                    <h3 id="lastUpdate">---</h3>
                    <p>آخر تحديث</p>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Hidden Data Binding -->
<asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="true" StartFromCurrentNode="true"/>

<asp:Repeater ID="rptHomeNavigation" runat="server">
    <ItemTemplate>
        <div class="home-nav-data" style="display: none;"
             data-url='<%# Eval("Url") %>'
             data-title='<%# Eval("Title") %>'
             data-description='<%# Eval("Description") %>'
             data-icon='<%# Eval("Icon") %>'
             data-image='<%# Eval("ImageUrl") %>'>
        </div>
    </ItemTemplate>
</asp:Repeater>

<!-- Modern Styles -->
<style>
.modern-home-navigation-container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 2rem 1rem;
    font-family: var(--font-family, 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif);
}

.navigation-header {
    text-align: center;
    margin-bottom: 3rem;
}

.nav-title {
    color: var(--primary-color, #2563eb);
    font-size: 2.5rem;
    font-weight: 700;
    margin-bottom: 0.5rem;
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 1rem;
}

.nav-title i {
    color: var(--accent-color, #f59e0b);
}

.nav-subtitle {
    color: var(--text-secondary, #6b7280);
    font-size: 1.1rem;
    margin: 0;
}

.modern-home-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    gap: 2rem;
    margin-bottom: 3rem;
}

.home-card {
    background: var(--card-background, #ffffff);
    border-radius: 16px;
    overflow: hidden;
    box-shadow: 0 4px 20px rgba(0, 0, 0, 0.08);
    transition: all 0.3s ease;
    text-decoration: none;
    color: inherit;
    position: relative;
    min-height: 280px;
}

.home-card:hover {
    transform: translateY(-8px);
    box-shadow: 0 12px 40px rgba(0, 0, 0, 0.15);
    text-decoration: none;
    color: inherit;
}

.card-image-section {
    position: relative;
    height: 180px;
    overflow: hidden;
    background: linear-gradient(135deg, var(--primary-color, #2563eb), var(--accent-color, #f59e0b));
}

.card-image {
    width: 100%;
    height: 100%;
    object-fit: cover;
    transition: transform 0.3s ease;
}

.home-card:hover .card-image {
    transform: scale(1.05);
}

.card-overlay {
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background: rgba(0, 0, 0, 0.4);
    display: flex;
    align-items: center;
    justify-content: center;
    opacity: 0;
    transition: opacity 0.3s ease;
}

.home-card:hover .card-overlay {
    opacity: 1;
}

.card-icon {
    font-size: 3rem;
    color: white;
    text-shadow: 0 2px 4px rgba(0, 0, 0, 0.3);
}

.card-content {
    padding: 1.5rem;
    text-align: center;
}

.card-title {
    font-size: 1.3rem;
    font-weight: 600;
    color: var(--text-primary, #1f2937);
    margin-bottom: 0.5rem;
}

.card-description {
    color: var(--text-secondary, #6b7280);
    font-size: 0.9rem;
    line-height: 1.5;
    margin: 0;
}

/* Statistics Section */
.home-statistics-section {
    background: var(--card-background, #ffffff);
    border-radius: 16px;
    padding: 2rem;
    box-shadow: 0 4px 20px rgba(0, 0, 0, 0.08);
}

.stats-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
    gap: 1.5rem;
}

.stat-card {
    display: flex;
    align-items: center;
    gap: 1rem;
    padding: 1rem;
    background: var(--background-light, #f8fafc);
    border-radius: 12px;
    transition: transform 0.2s ease;
}

.stat-card:hover {
    transform: translateY(-2px);
}

.stat-icon {
    width: 50px;
    height: 50px;
    border-radius: 12px;
    background: linear-gradient(135deg, var(--primary-color, #2563eb), var(--accent-color, #f59e0b));
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    font-size: 1.5rem;
}

.stat-content h3 {
    margin: 0;
    font-size: 1.5rem;
    font-weight: 700;
    color: var(--text-primary, #1f2937);
}

.stat-content p {
    margin: 0;
    color: var(--text-secondary, #6b7280);
    font-size: 0.9rem;
}

/* Loading Animation */
.home-loading-placeholder {
    grid-column: 1 / -1;
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 200px;
}

.loading-animation {
    text-align: center;
    color: var(--text-secondary, #6b7280);
}

.loading-animation i {
    font-size: 3rem;
    color: var(--primary-color, #2563eb);
    margin-bottom: 1rem;
}

.loading-animation p {
    font-size: 1.1rem;
    margin: 0;
}

/* Responsive Design */
@media (max-width: 768px) {
    .modern-home-navigation-container {
        padding: 1rem;
    }
    
    .nav-title {
        font-size: 2rem;
    }
    
    .modern-home-grid {
        grid-template-columns: 1fr;
        gap: 1.5rem;
    }
    
    .home-card {
        min-height: 250px;
    }
    
    .card-image-section {
        height: 150px;
    }
    
    .stats-grid {
        grid-template-columns: 1fr;
    }
}

/* Animation Classes */
.fade-in-up {
    animation: fadeInUp 0.6s ease forwards;
}

@keyframes fadeInUp {
    from {
        opacity: 0;
        transform: translateY(30px);
    }
    to {
        opacity: 1;
        transform: translateY(0);
    }
}

/* Dark Mode Support */
@media (prefers-color-scheme: dark) {
    .modern-home-navigation-container {
        --card-background: #1f2937;
        --background-light: #374151;
        --text-primary: #f9fafb;
        --text-secondary: #d1d5db;
    }
}
</style>

<!-- Modern JavaScript -->
<script>
document.addEventListener('DOMContentLoaded', function() {
    console.log('🏠 ModernHomeTableOfContents initializing...');
    
    // Load navigation data
    loadModernHomeNavigation();
    
    // Update statistics
    updateHomeStatistics();
    
    // Setup auto-refresh
    setInterval(updateHomeStatistics, 30000); // Update every 30 seconds
});

function loadModernHomeNavigation() {
    console.log('📋 Loading modern home navigation...');
    
    const grid = document.getElementById('modernHomeGrid');
    const navDataElements = document.querySelectorAll('.home-nav-data');
    
    if (!grid) {
        console.error('❌ Modern home grid not found');
        return;
    }
    
    // Clear loading placeholder
    grid.innerHTML = '';
    
    console.log('🔍 Found navigation data elements:', navDataElements.length);
    
    if (navDataElements.length === 0) {
        // Show sample data if no real data available
        showSampleHomeNavigation(grid);
        return;
    }
    
    // Process real navigation data
    let delay = 0;
    navDataElements.forEach((element, index) => {
        setTimeout(() => {
            const card = createHomeNavigationCard(element);
            if (card) {
                grid.appendChild(card);
                card.classList.add('fade-in-up');
            }
        }, delay);
        delay += 100; // Stagger animations
    });
}

function createHomeNavigationCard(dataElement) {
    const url = dataElement.getAttribute('data-url') || '#';
    const title = dataElement.getAttribute('data-title') || 'صفحة';
    const description = dataElement.getAttribute('data-description') || 'وصف الصفحة';
    const icon = dataElement.getAttribute('data-icon') || 'fas fa-file';
    const imageUrl = dataElement.getAttribute('data-image') || '';
    
    const card = document.createElement('a');
    card.href = url;
    card.className = 'home-card';
    
    card.innerHTML = `
        <div class="card-image-section">
            ${imageUrl ? 
                `<img src="${imageUrl}" alt="${title}" class="card-image">` : 
                `<div class="card-image" style="background: linear-gradient(135deg, var(--primary-color, #2563eb), var(--accent-color, #f59e0b));"></div>`
            }
            <div class="card-overlay">
                <i class="${icon} card-icon"></i>
            </div>
        </div>
        <div class="card-content">
            <h3 class="card-title">${title}</h3>
            <p class="card-description">${description}</p>
        </div>
    `;
    
    return card;
}

function showSampleHomeNavigation(grid) {
    console.log('📝 Showing sample navigation data');
    
    const sampleData = [
        { title: 'إدارة المستخدمين', description: 'إدارة حسابات المستخدمين والصلاحيات', icon: 'fas fa-users', url: '~/Pages/Users.aspx' },
        { title: 'التقارير', description: 'عرض التقارير والإحصائيات', icon: 'fas fa-chart-bar', url: '~/Pages/Reports.aspx' },
        { title: 'الإعدادات', description: 'إعدادات النظام والتكوين', icon: 'fas fa-cog', url: '~/Pages/Settings.aspx' },
        { title: 'المساعدة', description: 'دليل المستخدم والدعم الفني', icon: 'fas fa-question-circle', url: '~/Pages/Help.aspx' },
        { title: 'العقارات', description: 'إدارة العقارات والوحدات السكنية', icon: 'fas fa-building', url: '~/Pages/Properties.aspx' },
        { title: 'العقود', description: 'إدارة عقود الإيجار والمبيعات', icon: 'fas fa-file-contract', url: '~/Pages/Contracts.aspx' }
    ];
    
    let delay = 0;
    sampleData.forEach((item, index) => {
        setTimeout(() => {
            const card = document.createElement('a');
            card.href = item.url;
            card.className = 'home-card fade-in-up';
            
            card.innerHTML = `
                <div class="card-image-section">
                    <div class="card-image" style="background: linear-gradient(135deg, var(--primary-color, #2563eb), var(--accent-color, #f59e0b));"></div>
                    <div class="card-overlay">
                        <i class="${item.icon} card-icon"></i>
                    </div>
                </div>
                <div class="card-content">
                    <h3 class="card-title">${item.title}</h3>
                    <p class="card-description">${item.description}</p>
                </div>
            `;
            
            grid.appendChild(card);
        }, delay);
        delay += 150;
    });
}

function updateHomeStatistics() {
    console.log('📊 Updating home statistics...');
    
    // Simulate getting statistics (replace with real data calls)
    const stats = {
        totalUsers: Math.floor(Math.random() * 100) + 50,
        totalPages: document.querySelectorAll('a[href*=".aspx"]').length || 15,
        lastUpdate: new Date().toLocaleTimeString('ar-EG')
    };
    
    // Update statistics display
    const totalUsersElement = document.getElementById('totalUsers');
    const totalPagesElement = document.getElementById('totalPages');
    const lastUpdateElement = document.getElementById('lastUpdate');
    
    if (totalUsersElement) totalUsersElement.textContent = stats.totalUsers;
    if (totalPagesElement) totalPagesElement.textContent = stats.totalPages;
    if (lastUpdateElement) lastUpdateElement.textContent = stats.lastUpdate;
    
    console.log('📈 Statistics updated:', stats);
}

// Export functions for debugging
window.ModernHomeTableOfContents = {
    reload: loadModernHomeNavigation,
    updateStats: updateHomeStatistics
};

console.log('🚀 ModernHomeTableOfContents loaded successfully');
</script>

<!-- Hidden debug labels (compatible with original) -->
<div style="display:none">
    <asp:Label ID="Label1" runat="server" Text="Label" Height="210"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" Height="16px" TextMode="MultiLine" Width="236px"></asp:TextBox>
    <asp:Label ID="Label6" runat="server" Text="Label" Height="210"></asp:Label>
</div>
