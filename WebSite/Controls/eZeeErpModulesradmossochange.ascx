<%@ Control Language="VB" AutoEventWireup="false" CodeFile="eZeeErpModulesradmossochange.ascx.vb" Inherits="Controls_eZeeErpModulesradmossochange" %>
<%@ Import Namespace="translatemeyamosso" %>

 <!-- Dashboard Header -->
 <div class="dashboard-header">
     <h1 class="dashboard-title">
         <i class="fas fa-graduation-cap title-icon"></i>
         <%# translatemeyamosso.GetResourceValuemosso("SKY saas")%>
     </h1>
     <p class="dashboard-subtitle">نظام إدارة المدرسة المتطور</p>
 </div>

 <!-- Statistics Bar -->
 <div class="stats-bar">
     <div class="stats-grid">
         <div class="stat-item">
             <div class="stat-number" id="totalUsers">0</div>
             <div class="stat-label">إجمالي المستخدمين</div>
         </div>
         <div class="stat-item">
             <div class="stat-number" id="activeModules">0</div>
             <div class="stat-label">الوحدات النشطة</div>
         </div>
         <div class="stat-item">
             <div class="stat-number" id="todayAccess">0</div>
             <div class="stat-label">دخول اليوم</div>
         </div>
         <div class="stat-item">
             <div class="stat-number">100%</div>
             <div class="stat-label">معدل التشغيل</div>
         </div>
     </div>
 </div>


<!-- Modern ERP Modules Card Layout -->
<div class="modern-erp-modules">
    <div class="modules-header">
        <h2 class="modules-title">
            <i class="fas fa-cube"></i>
            <span>نظام إدارة الموارد المؤسسية</span>
        </h2>
        <p class="modules-subtitle">اختر الوحدة التي تريد العمل بها</p>
    </div>
    
    <div class="modules-grid" id="modulesContainer">
        <asp:Literal ID="litModules" runat="server"></asp:Literal>
    </div>
    
    <!-- Loading Animation -->
    <div class="modules-loading" id="modulesLoading" style="display: none;">
        <div class="loading-spinner"></div>
        <p>جاري تحميل الوحدات...</p>
    </div>
</div>

<!-- Modern Styles -->
<style>
.modern-erp-modules {
    max-width: 1200px;
    margin: 0 auto;
    padding: 2rem;
    font-family: 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    direction: rtl;
}

.modules-header {
    text-align: center;
    margin-bottom: 3rem;
}

.modules-title {
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 1rem;
    font-size: 2.5rem;
    font-weight: 700;
    background: linear-gradient(135deg, #2563eb, #3b82f6);
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
    background-clip: text;
    margin-bottom: 0.5rem;
}

.modules-subtitle {
    font-size: 1.2rem;
    color: #64748b;
    margin: 0;
}

.modules-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(350px, 1fr));
    gap: 2rem;
    margin-bottom: 2rem;
}

.module-card {
    background: linear-gradient(135deg, 
        rgba(255, 255, 255, 0.9), 
        rgba(255, 255, 255, 0.7)
    );
    backdrop-filter: blur(20px);
    border: 1px solid rgba(37, 99, 235, 0.1);
    border-radius: 20px;
    padding: 2rem;
    text-align: center;
    transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
    position: relative;
    overflow: hidden;
    box-shadow: 0 8px 32px rgba(37, 99, 235, 0.1);
}

.module-card::before {
    content: '';
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    height: 4px;
    background: linear-gradient(90deg, #2563eb, #3b82f6, #06b6d4);
    transform: scaleX(0);
    transition: transform 0.3s ease;
}

.module-card:hover::before {
    transform: scaleX(1);
}

.module-card:hover {
    transform: translateY(-8px) scale(1.02);
    box-shadow: 0 20px 40px rgba(37, 99, 235, 0.2);
    border-color: rgba(37, 99, 235, 0.3);
}

.module-icon {
    width: 80px;
    height: 80px;
    border-radius: 20px;
    margin: 0 auto 1.5rem;
    display: flex;
    align-items: center;
    justify-content: center;
    background: linear-gradient(135deg, #2563eb, #3b82f6);
    box-shadow: 0 8px 24px rgba(37, 99, 235, 0.3);
    transition: all 0.3s ease;
}

.module-card:hover .module-icon {
    transform: scale(1.1) rotate(5deg);
    box-shadow: 0 12px 32px rgba(37, 99, 235, 0.4);
}

.module-icon img {
    max-width: 50px;
    max-height: 50px;
    filter: brightness(0) invert(1);
}

.module-title {
    font-size: 1.5rem;
    font-weight: 600;
    color: #1e293b;
    margin-bottom: 1rem;
    line-height: 1.4;
}

.module-description {
    color: #64748b;
    font-size: 1rem;
    line-height: 1.6;
    margin-bottom: 2rem;
    min-height: 48px;
}

.module-link {
    display: inline-flex;
    align-items: center;
    gap: 0.5rem;
    padding: 0.75rem 1.5rem;
    background: linear-gradient(135deg, #2563eb, #3b82f6);
    color: white;
    text-decoration: none;
    border-radius: 12px;
    font-weight: 500;
    transition: all 0.3s ease;
    box-shadow: 0 4px 12px rgba(37, 99, 235, 0.3);
}

.module-link:hover {
    background: linear-gradient(135deg, #1d4ed8, #2563eb);
    transform: translateY(-2px);
    box-shadow: 0 6px 20px rgba(37, 99, 235, 0.4);
    color: white;
    text-decoration: none;
}

.modules-loading {
    text-align: center;
    padding: 3rem;
    color: #64748b;
}

.loading-spinner {
    width: 50px;
    height: 50px;
    margin: 0 auto 1rem;
    border: 4px solid #e2e8f0;
    border-top: 4px solid #2563eb;
    border-radius: 50%;
    animation: spin 1s linear infinite;
}

@keyframes spin {
    0% { transform: rotate(0deg); }
    100% { transform: rotate(360deg); }
}

/* Responsive Design */
@media (max-width: 768px) {
    .modern-erp-modules {
        padding: 1rem;
    }
    
    .modules-grid {
        grid-template-columns: 1fr;
        gap: 1.5rem;
    }
    
    .module-card {
        padding: 1.5rem;
    }
    
    .modules-title {
        font-size: 2rem;
    }
}

/* Dark Mode Support */
@media (prefers-color-scheme: dark) {
    .modern-erp-modules {
        background: linear-gradient(135deg, #0f172a, #1e293b);
        color: white;
    }
    
    .module-card {
        background: linear-gradient(135deg, 
            rgba(30, 41, 59, 0.9), 
            rgba(15, 23, 42, 0.7)
        );
        border-color: rgba(59, 130, 246, 0.2);
        color: white;
    }
    
    .module-title {
        color: #f1f5f9;
    }
    
    .module-description {
        color: #cbd5e1;
    }
}

/* Animation Effects */
.module-card {
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

/* Stagger Animation for Cards */
.module-card:nth-child(1) { animation-delay: 0.1s; }
.module-card:nth-child(2) { animation-delay: 0.2s; }
.module-card:nth-child(3) { animation-delay: 0.3s; }
.module-card:nth-child(4) { animation-delay: 0.4s; }
.module-card:nth-child(5) { animation-delay: 0.5s; }
.module-card:nth-child(6) { animation-delay: 0.6s; }
.module-card:nth-child(7) { animation-delay: 0.7s; }
.module-card:nth-child(8) { animation-delay: 0.8s; }
.module-card:nth-child(9) { animation-delay: 0.9s; }
</style>

<!-- Modern JavaScript -->
<script>
document.addEventListener('DOMContentLoaded', function() {
    // Add loading animation
    const container = document.getElementById('modulesContainer');
    const loading = document.getElementById('modulesLoading');
    
    if (container && loading) {
        // Show loading initially
        loading.style.display = 'block';
        container.style.display = 'none';
        
        // Simulate loading time and then show content
        setTimeout(function() {
            loading.style.display = 'none';
            container.style.display = 'grid';
            
            // Add stagger animation to cards
            const cards = container.querySelectorAll('.module-card');
            cards.forEach((card, index) => {
                card.style.animationDelay = (index * 0.1) + 's';
            });
        }, 800);
    }
    
    // Add click tracking
    const moduleLinks = document.querySelectorAll('.module-link');
    moduleLinks.forEach(link => {
        link.addEventListener('click', function(e) {
            const moduleName = this.closest('.module-card').querySelector('.module-title').textContent;
            console.log('Module accessed:', moduleName);
            
            // Add click effect
            this.style.transform = 'translateY(-2px) scale(0.98)';
            setTimeout(() => {
                this.style.transform = 'translateY(-2px) scale(1)';
            }, 150);
        });
    });
    
    // Add hover effects for better interactivity
    const cards = document.querySelectorAll('.module-card');
    cards.forEach(card => {
        card.addEventListener('mouseenter', function() {
            this.style.zIndex = '10';
        });
        
        card.addEventListener('mouseleave', function() {
            this.style.zIndex = '1';
        });
    });
});
</script>