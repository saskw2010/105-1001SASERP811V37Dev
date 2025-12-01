<%@ Page Language="VB" MasterPageFile="~/LegacyModernMastercSidebar.master" AutoEventWireup="true" CodeFile="Home-ai.aspx.vb" Inherits="Pages_Home_ai"  Title="Home-ai" %>
<%@ Register Src="../Controls/schoolDashBoard.ascx" TagName="schoolDashBoard"  TagPrefix="uc" %>
<%@ Register Src="../Controls/TableOfContents.ascx" TagName="TableOfContents"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Home</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
   
 <div id="#regContainer1">
    <%--Main Dashboard Layout with Right Sidebar--%>
    <div class="dashboard-layout">
        <!-- Right Sidebar (Collapsed by default) -->
        <div class="dashboard-sidebar" id="dashboardSidebar">
            <div class="sidebar-header">
                <h3 class="sidebar-title">
                    <i class="fas fa-tachometer-alt"></i>
                    لوحة التحكم
                </h3>
                <button type="button" class="sidebar-toggle" id="sidebarToggle">
                    <i class="fas fa-times"></i>
                </button>
            </div>
            
            <div class="sidebar-content">
                <!-- Enhanced Navigation in Sidebar -->
                <div class="sidebar-section">
                    <h4 class="sidebar-section-title">
                        <i class="fas fa-compass"></i>
                        التنقل السريع
                    </h4>
                    <div class="table-of-contents-sidebar">
                        <uc:TableOfContents ID="TableOfContentsSidebar" runat="server" />
                    </div>
                </div>
                
                <!-- Quick Stats -->
                <div class="sidebar-section">
                    <h4 class="sidebar-section-title">
                        <i class="fas fa-chart-bar"></i>
                        إحصائيات سريعة
                    </h4>
                    <div class="quick-stats">
                        <div class="stat-item">
                            <div class="stat-icon">
                                <i class="fas fa-users"></i>
                            </div>
                            <div class="stat-info">
                                <div class="stat-value">1,250</div>
                                <div class="stat-label">المستخدمين</div>
                            </div>
                        </div>
                        <div class="stat-item">
                            <div class="stat-icon">
                                <i class="fas fa-file-alt"></i>
                            </div>
                            <div class="stat-info">
                                <div class="stat-value">850</div>
                                <div class="stat-label">التقارير</div>
                            </div>
                        </div>
                        <div class="stat-item">
                            <div class="stat-icon">
                                <i class="fas fa-tasks"></i>
                            </div>
                            <div class="stat-info">
                                <div class="stat-value">42</div>
                                <div class="stat-label">المهام المعلقة</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        
        <!-- Main Content Area -->
        <div class="dashboard-main-content">
            <!-- School Dashboard Control (Modernized from Telerik) -->
            <div class="container contenthome">
                <uc:schoolDashBoard ID="schoolDashboard" runat="server"></uc:schoolDashBoard>
            </div>
        </div>
    </div>
  <br />
 <div data-flow="row">
 	
	<div class=" container contenthome">
     <!-- Enhanced TableOfContents with Dynamic Converter (Legacy/Modern Toggle) -->
     <div class="navigation-section">
         <uc:TableOfContents ID="control1" runat="server"></uc:TableOfContents>
     </div>
     
     <%--Main Content Display Area for Menu Content--%>
     <div class="main-content-display">
         <div class="content-header">
             <h3 class="content-title">
                 <i class="fas fa-th-large"></i>
                 محتوى القائمة الرئيسية
             </h3>
             <p class="content-description">
                 اختر من القائمة أعلاه أو الشريط الجانبي لعرض المحتوى المطلوب
             </p>
         </div>
         
         <div class="content-area" id="mainContentArea">
             <!-- Dynamic content will be loaded here -->
             <div class="welcome-content">
                 <div class="welcome-card">
                     <div class="welcome-icon">
                         <i class="fas fa-rocket"></i>
                     </div>
                     <h4>مرحباً بك في النظام</h4>
                     <p>ابدأ باختيار إحدى الوحدات من الأعلى أو استخدم القائمة الجانبية للتنقل السريع</p>
                     <div class="welcome-actions">
                         <button type="button" class="btn btn-primary" onclick="showSidebar()">
                             <i class="fas fa-list"></i>
                             عرض القائمة الجانبية
                         </button>
                         <button type="button" class="btn btn-outline-secondary" onclick="scrollToModules()">
                             <i class="fas fa-arrow-up"></i>
                             العودة للوحدات
                         </button>
                     </div>
                 </div>
             </div>
         </div>
     </div>
	</div>
  
     </div>
 
   
  <div data-flow="row">
    
    <div data-activator="Tab|^HRaLarm^HRaLarm^HRaLarm^">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="depmastert" view="grid1" PageSize="100" SelectionMode="Multiple" ShowActionBar="True"  ShowPager="Top" ShowRowNumber="True" Roles="HRaLarm" ShowSearchBar="true" />
    </div>
    <div data-activator="Tab|servicsalarm">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="servicsalarm" view="grid1" PageSize="100" SelectionMode="Multiple"   ShowActionBar="True"   ShowPager="Top" ShowRowNumber="True" Roles="servicsalarm" ShowSearchBar="true" />
    </div>
  <div data-activator="Tab|legalalarm">
      <div id="Div1" runat="server"></div>
      <aquarium:DataViewExtender id="DataViewExtender1" runat="server" TargetControlID="Div1" Controller="legalalarm" view="grid1" PageSize="100" SelectionMode="Multiple"    ShowActionBar="True"  ShowPager="Top" ShowRowNumber="True" Roles="legalalarm" ShowSearchBar="true" />
    </div>
  <div data-activator="Tab|RealALARM">
      <div id="Div2" runat="server"></div>
      <aquarium:DataViewExtender id="DataViewExtender2" runat="server" TargetControlID="Div2" Controller="realpycontloc" view="grid1" PageSize="100" SelectionMode="Multiple" ShowActionBar="True"   ShowPager="Top" ShowRowNumber="True" Roles="Realalarm" ShowSearchBar="true" />
    </div>

      
  </div> 
   
    </div>

<style>
/* Dashboard Layout with Right Sidebar */
.dashboard-layout {
    position: relative;
    min-height: 100vh;
    background: linear-gradient(135deg, #f8fafc 0%, #e2e8f0 100%);
}

/* Right Sidebar Styles */
.dashboard-sidebar {
    position: fixed;
    top: 0;
    right: -400px; /* Hidden by default */
    width: 400px;
    height: 100vh;
    background: linear-gradient(135deg, #1e293b, #334155);
    color: white;
    z-index: 1000;
    transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
    box-shadow: -10px 0 30px rgba(0, 0, 0, 0.3);
    overflow-y: auto;
    direction: rtl;
}

.dashboard-sidebar.active {
    right: 0;
}

.sidebar-header {
    padding: 2rem;
    background: linear-gradient(135deg, #2563eb, #3b82f6);
    border-bottom: 1px solid rgba(255, 255, 255, 0.1);
    display: flex;
    justify-content: space-between;
    align-items: center;
}

.sidebar-title {
    margin: 0;
    font-size: 1.5rem;
    font-weight: 600;
    display: flex;
    align-items: center;
    gap: 0.75rem;
}

.sidebar-toggle {
    background: rgba(255, 255, 255, 0.1);
    border: none;
    color: white;
    width: 40px;
    height: 40px;
    border-radius: 8px;
    cursor: pointer;
    transition: all 0.3s ease;
    display: flex;
    align-items: center;
    justify-content: center;
}

.sidebar-toggle:hover {
    background: rgba(255, 255, 255, 0.2);
    transform: scale(1.1);
}

.sidebar-content {
    padding: 1.5rem;
}

.sidebar-section {
    margin-bottom: 2rem;
}

.sidebar-section-title {
    display: flex;
    align-items: center;
    gap: 0.75rem;
    font-size: 1.1rem;
    font-weight: 600;
    margin-bottom: 1rem;
    color: #fbbf24;
    padding-bottom: 0.5rem;
    border-bottom: 1px solid rgba(255, 255, 255, 0.1);
}

/* Quick Stats in Sidebar */
.quick-stats {
    display: flex;
    flex-direction: column;
    gap: 1rem;
}

.stat-item {
    display: flex;
    align-items: center;
    gap: 1rem;
    padding: 1rem;
    background: rgba(255, 255, 255, 0.05);
    border-radius: 12px;
    transition: all 0.3s ease;
}

.stat-item:hover {
    background: rgba(255, 255, 255, 0.1);
    transform: translateX(5px);
}

.stat-icon {
    width: 40px;
    height: 40px;
    background: linear-gradient(135deg, #10b981, #06d6a0);
    border-radius: 10px;
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 1.2rem;
}

.stat-info {
    flex: 1;
}

.stat-value {
    font-size: 1.5rem;
    font-weight: 700;
    color: #fbbf24;
}

.stat-label {
    font-size: 0.9rem;
    opacity: 0.8;
}

/* Main Content Area */
.dashboard-main-content {
    transition: margin-right 0.4s cubic-bezier(0.4, 0, 0.2, 1);
}

.dashboard-sidebar.active ~ .dashboard-main-content {
    margin-right: 400px;
}

/* Main Content Display Area */
.main-content-display {
    background: white;
    border-radius: 20px;
    padding: 2rem;
    margin: 2rem 0;
    box-shadow: 0 8px 24px rgba(0, 0, 0, 0.1);
    border: 1px solid #e2e8f0;
}

.content-header {
    text-align: center;
    margin-bottom: 2rem;
    padding-bottom: 1.5rem;
    border-bottom: 2px solid #e2e8f0;
    position: relative;
}

.content-header::after {
    content: '';
    position: absolute;
    bottom: -2px;
    left: 50%;
    transform: translateX(-50%);
    width: 80px;
    height: 2px;
    background: linear-gradient(90deg, #2563eb, #3b82f6);
}

.content-title {
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 1rem;
    font-size: 1.8rem;
    font-weight: 600;
    color: #1e293b;
    margin-bottom: 0.5rem;
}

.content-description {
    color: #64748b;
    font-size: 1.1rem;
    margin: 0;
}

.content-area {
    min-height: 300px;
}

/* Welcome Content */
.welcome-content {
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 300px;
}

.welcome-card {
    text-align: center;
    background: linear-gradient(135deg, #f8fafc, #e2e8f0);
    border-radius: 20px;
    padding: 3rem;
    max-width: 500px;
    border: 1px solid #e2e8f0;
    box-shadow: 0 4px 16px rgba(0, 0, 0, 0.1);
}

.welcome-icon {
    width: 80px;
    height: 80px;
    background: linear-gradient(135deg, #10b981, #06d6a0);
    border-radius: 20px;
    display: flex;
    align-items: center;
    justify-content: center;
    margin: 0 auto 1.5rem;
    color: white;
    font-size: 2rem;
    box-shadow: 0 8px 24px rgba(16, 185, 129, 0.3);
}

.welcome-card h4 {
    font-size: 1.5rem;
    font-weight: 600;
    color: #1e293b;
    margin-bottom: 1rem;
}

.welcome-card p {
    color: #64748b;
    margin-bottom: 2rem;
    line-height: 1.6;
}

.welcome-actions {
    display: flex;
    gap: 1rem;
    justify-content: center;
    flex-wrap: wrap;
}

.btn {
    padding: 0.75rem 1.5rem;
    border-radius: 10px;
    font-weight: 500;
    text-decoration: none;
    border: none;
    cursor: pointer;
    transition: all 0.3s ease;
    display: inline-flex;
    align-items: center;
    gap: 0.5rem;
}

.btn-primary {
    background: linear-gradient(135deg, #2563eb, #3b82f6);
    color: white;
}

.btn-primary:hover {
    background: linear-gradient(135deg, #1d4ed8, #2563eb);
    transform: translateY(-2px);
    color: white;
    text-decoration: none;
}

.btn-outline-secondary {
    background: transparent;
    color: #64748b;
    border: 1px solid #e2e8f0;
}

.btn-outline-secondary:hover {
    background: #f8fafc;
    color: #1e293b;
    border-color: #cbd5e1;
    text-decoration: none;
}

/* Table of Contents Sidebar Styling */
.table-of-contents-sidebar {
    background: rgba(255, 255, 255, 0.05);
    border-radius: 12px;
    padding: 1rem;
}

.table-of-contents-sidebar .modern-card {
    background: rgba(255, 255, 255, 0.05);
    border: 1px solid rgba(255, 255, 255, 0.1);
    margin-bottom: 0.5rem;
}

.table-of-contents-sidebar .modern-card:hover {
    background: rgba(255, 255, 255, 0.1);
}

.table-of-contents-sidebar .card-title {
    color: white;
    font-size: 0.9rem;
}

.table-of-contents-sidebar .card-description {
    color: rgba(255, 255, 255, 0.8);
    font-size: 0.8rem;
}

/* Enhanced Navigation Section Styles */
.navigation-section {
    margin: 2rem 0;
    background: linear-gradient(135deg, rgba(37, 99, 235, 0.02), rgba(147, 51, 234, 0.02));
    border-radius: 20px;
    padding: 1rem;
    border: 1px solid rgba(37, 99, 235, 0.1);
}

/* Responsive Design */
@media (max-width: 1024px) {
    .dashboard-sidebar {
        width: 350px;
        right: -350px;
    }
    
    .dashboard-sidebar.active ~ .dashboard-main-content {
        margin-right: 350px;
    }
}

@media (max-width: 768px) {
    .dashboard-sidebar {
        width: 100%;
        right: -100%;
    }
    
    .dashboard-sidebar.active ~ .dashboard-main-content {
        margin-right: 0;
        transform: translateX(-100%);
    }
    
    .navigation-section {
        margin: 1rem 0;
        padding: 0.5rem;
    }
    
    .container.contenthome {
        padding: 0.5rem;
    }
    
    .main-content-display {
        margin: 1rem 0;
        padding: 1.5rem;
    }
    
    .welcome-card {
        padding: 2rem;
    }
    
    .welcome-actions {
        flex-direction: column;
    }
}

@media (max-width: 576px) {
    .dashboard-sidebar {
        padding: 0;
    }
    
    .sidebar-header {
        padding: 1.5rem;
    }
    
    .sidebar-content {
        padding: 1rem;
    }
    
    .stat-item {
        padding: 0.75rem;
    }
    
    .welcome-card {
        padding: 1.5rem;
    }
    
    .content-title {
        font-size: 1.5rem;
    }
}

/* Dark mode support for navigation */
@media (prefers-color-scheme: dark) {
    .navigation-section {
        background: linear-gradient(135deg, rgba(37, 99, 235, 0.1), rgba(147, 51, 234, 0.1));
        border-color: rgba(37, 99, 235, 0.2);
    }
    
    .main-content-display {
        background: #1e293b;
        color: white;
        border-color: #334155;
    }
    
    .content-title {
        color: white;
    }
    
    .content-description {
        color: #94a3b8;
    }
    
    .welcome-card {
        background: linear-gradient(135deg, #334155, #475569);
        border-color: #475569;
    }
    
    .welcome-card h4 {
        color: white;
    }
    
    .welcome-card p {
        color: #cbd5e1;
    }
}

/* Overlay for mobile sidebar */
.sidebar-overlay {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.5);
    z-index: 999;
    opacity: 0;
    visibility: hidden;
    transition: all 0.3s ease;
}

.sidebar-overlay.active {
    opacity: 1;
    visibility: visible;
}

/* Animation for sidebar content */
.sidebar-section {
    animation: slideInRight 0.6s ease-out;
    animation-fill-mode: both;
}

.sidebar-section:nth-child(1) { animation-delay: 0.1s; }
.sidebar-section:nth-child(2) { animation-delay: 0.2s; }
.sidebar-section:nth-child(3) { animation-delay: 0.3s; }

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

/* Navigation section border enhancement */
.navigation-section:hover {
    border-color: rgba(37, 99, 235, 0.3);
}
</style>

<script>
// Enhanced Home Page Navigation
document.addEventListener('DOMContentLoaded', function() {
    console.log('Home page loaded with enhanced TableOfContents navigation');
    
    // Add smooth scroll behavior for navigation
    const navigationSection = document.querySelector('.navigation-section');
    if (navigationSection) {
        navigationSection.style.opacity = '0';
        navigationSection.style.transform = 'translateY(20px)';
        
        // Animate in after page load
        setTimeout(() => {
            navigationSection.style.transition = 'all 0.8s ease-out';
            navigationSection.style.opacity = '1';
            navigationSection.style.transform = 'translateY(0)';
        }, 200);
    }
});
</script>

<!-- Dashboard Sidebar JavaScript -->
<script>
document.addEventListener('DOMContentLoaded', function() {
    const sidebar = document.getElementById('dashboardSidebar');
    const sidebarToggle = document.getElementById('sidebarToggle');
    const mainContent = document.querySelector('.dashboard-main-content');
    
    // Create overlay for mobile
    const overlay = document.createElement('div');
    overlay.className = 'sidebar-overlay';
    overlay.id = 'sidebarOverlay';
    document.body.appendChild(overlay);
    
    // Toggle sidebar function
    function toggleSidebar() {
        sidebar.classList.toggle('active');
        overlay.classList.toggle('active');
    }
    
    // Event listeners
    if (sidebarToggle) sidebarToggle.addEventListener('click', toggleSidebar);
    if (overlay) overlay.addEventListener('click', toggleSidebar);
    
    // Close sidebar on escape key
    document.addEventListener('keydown', function(e) {
        if (e.key === 'Escape' && sidebar && sidebar.classList.contains('active')) {
            toggleSidebar();
        }
    });
    
    // Handle window resize
    let resizeTimeout;
    window.addEventListener('resize', function() {
        clearTimeout(resizeTimeout);
        resizeTimeout = setTimeout(function() {
            if (window.innerWidth > 1024 && sidebar && sidebar.classList.contains('active')) {
                // Keep sidebar open on larger screens
            } else if (window.innerWidth <= 768) {
                // Ensure proper mobile behavior
                if (overlay) overlay.style.display = 'block';
            }
        }, 250);
    });
    
    // Animate stats counters
    function animateCounter(elementClass, targetValue) {
        const elements = document.querySelectorAll('.' + elementClass);
        elements.forEach(element => {
            let currentValue = 0;
            const increment = targetValue / 100;
            const duration = 2000;
            const stepTime = duration / 100;
            
            const timer = setInterval(function() {
                currentValue += increment;
                if (currentValue >= targetValue) {
                    currentValue = targetValue;
                    clearInterval(timer);
                }
                element.textContent = Math.floor(currentValue).toLocaleString('ar-SA');
            }, stepTime);
        });
    }
    
    // Initialize counter animations when sidebar opens
    if (sidebar) {
        sidebar.addEventListener('transitionend', function() {
            if (sidebar.classList.contains('active')) {
                setTimeout(() => {
                    animateCounter('stat-value', 1250);
                }, 300);
            }
        });
    }
});

// Global functions for welcome actions (declared before DOMContentLoaded)
window.showSidebar = function() {
    const sidebar = document.getElementById('dashboardSidebar');
    const overlay = document.getElementById('sidebarOverlay');
    
    if (sidebar) sidebar.classList.add('active');
    if (overlay) overlay.classList.add('active');
}

window.scrollToModules = function() {
    const modernDashboard = document.querySelector('.modern-school-dashboard');
    if (modernDashboard) {
        modernDashboard.scrollIntoView({ 
            behavior: 'smooth',
            block: 'start'
        });
    }
}

// Content loading function for future use
function loadContent(contentType, contentUrl) {
    const contentArea = document.getElementById('mainContentArea');
    if (!contentArea) return;
    
    // Show loading state
    contentArea.innerHTML = `
        <div style="text-align: center; padding: 3rem;">
            <div style="display: inline-block; width: 40px; height: 40px; border: 4px solid #e2e8f0; border-top: 4px solid #2563eb; border-radius: 50%; animation: spin 1s linear infinite;"></div>
            <p style="margin-top: 1rem; color: #64748b;">جاري التحميل...</p>
        </div>
    `;
    
    // Simulate content loading (replace with actual AJAX call)
    setTimeout(() => {
        contentArea.innerHTML = `
            <div class="loaded-content">
                <h4 style="color: #1e293b; margin-bottom: 1rem;">
                    <i class="fas fa-check-circle" style="color: #10b981; margin-left: 0.5rem;"></i>
                    تم تحميل المحتوى بنجاح
                </h4>
                <p style="color: #64748b; margin-bottom: 2rem;">
                    هنا سيتم عرض محتوى ${contentType} المطلوب.
                </p>
                <div style="background: #f8fafc; border-radius: 12px; padding: 2rem; border: 1px solid #e2e8f0;">
                    <p style="color: #64748b; margin: 0;">
                        يمكنك الآن إضافة المحتوى الديناميكي المطلوب هنا بناءً على اختيار المستخدم من القائمة.
                    </p>
                </div>
            </div>
        `;
    }, 1500);
}

// Add spin animation for loading
const style = document.createElement('style');
style.textContent = `
    @keyframes spin {
        0% { transform: rotate(0deg); }
        100% { transform: rotate(360deg); }
    }
`;
if (document.head) document.head.appendChild(style);
</script>



</asp:Content>