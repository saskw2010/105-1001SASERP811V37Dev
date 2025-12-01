<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ModernCardsDemo.aspx.vb" Inherits="ModernCardsDemo" MasterPageFile="~/Main.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>تجربة الكروت الحديثة - Modern Cards Demo</title>
    <meta name="description" content="صفحة تجريبية لعرض واختبار الكروت الحديثة">
</asp:Content>

<asp:Content ID="Content2"  ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <div class="modern-cards-demo-page">
        <!-- Header -->
        <div class="demo-header">
            <h1><i class="fas fa-th-large"></i> تجربة الكروت الحديثة</h1>
            <p>اختبار وتجربة نظام الكروت الحديث المستقل</p>
        </div>

        <!-- Controls -->
        <div class="demo-controls">
            <button id="btnLoadCards" class="demo-btn primary">
                <i class="fas fa-play"></i>
                تحميل الكروت
            </button>
            
            <button id="btnClearCards" class="demo-btn secondary">
                <i class="fas fa-trash"></i>
                مسح الكروت
            </button>
            
            <button id="btnToggleTheme" class="demo-btn secondary">
                <i class="fas fa-palette"></i>
                تغيير الثيم
            </button>
        </div>

        <!-- Cards Container -->
        <div id="modern-cards-container" class="modern-cards-grid">
            <div class="demo-placeholder">
                <i class="fas fa-mouse-pointer"></i>
                <p>اضغط "تحميل الكروت" لعرض الكروت الحديثة</p>
            </div>
        </div>

        <!-- Status Info -->
        <div class="demo-status">
            <h3>معلومات الحالة</h3>
            <div class="status-grid">
                <div class="status-item">
                    <strong>عدد الكروت:</strong>
                    <span id="cardsCount">0</span>
                </div>
                <div class="status-item">
                    <strong>الثيم الحالي:</strong>
                    <span id="currentTheme">افتراضي</span>
                </div>
                <div class="status-item">
                    <strong>آخر تحديث:</strong>
                    <span id="lastUpdate">-</span>
                </div>
            </div>
        </div>
    </div>

    <!-- Modern Cards Script (تحميل مستقل) -->
    <script src="/Scripts/modern-cards.js"></script>

    <style>
    .modern-cards-demo-page {
        max-width: 1200px;
        margin: 0 auto;
        padding: 2rem;
        font-family: 'Cairo', sans-serif;
        direction: rtl;
    }

    .demo-header {
        text-align: center;
        margin-bottom: 2rem;
        padding: 2rem;
        background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
        color: white;
        border-radius: 16px;
    }

    .demo-header h1 {
        font-size: 2.5rem;
        margin-bottom: 1rem;
        display: flex;
        align-items: center;
        justify-content: center;
        gap: 1rem;
    }

    .demo-header p {
        font-size: 1.2rem;
        opacity: 0.9;
    }

    .demo-controls {
        display: flex;
        justify-content: center;
        gap: 1rem;
        margin-bottom: 2rem;
        flex-wrap: wrap;
    }

    .demo-btn {
        display: inline-flex;
        align-items: center;
        gap: 0.5rem;
        padding: 0.75rem 1.5rem;
        border: none;
        border-radius: 8px;
        font-weight: 600;
        cursor: pointer;
        transition: all 0.3s ease;
        color: white;
    }

    .demo-btn.primary {
        background: linear-gradient(135deg, #10b981, #059669);
    }

    .demo-btn.secondary {
        background: linear-gradient(135deg, #6b7280, #4b5563);
    }

    .demo-btn:hover {
        transform: translateY(-2px);
        box-shadow: 0 4px 12px rgba(0,0,0,0.2);
    }

    .demo-placeholder {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        padding: 4rem 2rem;
        background: #f8fafc;
        border: 2px dashed #cbd5e1;
        border-radius: 16px;
        color: #64748b;
        text-align: center;
        min-height: 300px;
    }

    .demo-placeholder i {
        font-size: 3rem;
        margin-bottom: 1rem;
        color: #94a3b8;
    }

    .demo-placeholder p {
        font-size: 1.2rem;
        margin: 0;
    }

    .demo-status {
        margin-top: 2rem;
        padding: 1.5rem;
        background: white;
        border-radius: 12px;
        box-shadow: 0 4px 12px rgba(0,0,0,0.1);
    }

    .demo-status h3 {
        color: #1e293b;
        margin-bottom: 1rem;
        font-size: 1.3rem;
    }

    .status-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
        gap: 1rem;
    }

    .status-item {
        padding: 1rem;
        background: #f8fafc;
        border-radius: 8px;
        border-right: 4px solid #3b82f6;
    }

    .status-item strong {
        display: block;
        color: #374151;
        margin-bottom: 0.25rem;
    }

    .status-item span {
        color: #3b82f6;
        font-weight: 600;
    }

    /* إخفاء الكروت عند عدم الحاجة */
    .cards-hidden #modern-cards-container {
        display: none;
    }

    /* ثيم داكن */
    .dark-theme {
        background: #1e293b;
        color: white;
    }

    .dark-theme .demo-status {
        background: #334155;
        color: white;
    }

    .dark-theme .status-item {
        background: #475569;
    }

    @media (max-width: 768px) {
        .modern-cards-demo-page {
            padding: 1rem;
        }
        
        .demo-header h1 {
            font-size: 1.8rem;
            flex-direction: column;
        }
        
        .demo-controls {
            flex-direction: column;
            align-items: center;
        }
        
        .demo-btn {
            width: 100%;
            max-width: 250px;
            justify-content: center;
        }
    }
    </style>

    <script>
    document.addEventListener('DOMContentLoaded', function() {
        const btnLoadCards = document.getElementById('btnLoadCards');
        const btnClearCards = document.getElementById('btnClearCards');
        const btnToggleTheme = document.getElementById('btnToggleTheme');
        const cardsContainer = document.getElementById('modern-cards-container');
        const cardsCount = document.getElementById('cardsCount');
        const currentTheme = document.getElementById('currentTheme');
        const lastUpdate = document.getElementById('lastUpdate');
        
        let isDarkTheme = false;
        
        // تحميل الكروت
        btnLoadCards.addEventListener('click', function() {
            // إزالة placeholder
            cardsContainer.innerHTML = '';
            
            // محاكاة تحميل الكروت
            const sampleCards = [
                { title: 'المبيعات', description: 'إدارة المبيعات والفواتير', icon: 'fas fa-chart-line', url: '#' },
                { title: 'المخازن', description: 'إدارة المخزون والمواد', icon: 'fas fa-warehouse', url: '#' },
                { title: 'المحاسبة', description: 'النظام المحاسبي المتكامل', icon: 'fas fa-calculator', url: '#' },
                { title: 'الموارد البشرية', description: 'إدارة الموظفين والرواتب', icon: 'fas fa-users', url: '#' },
                { title: 'التقارير', description: 'تقارير شاملة وتحليلات', icon: 'fas fa-chart-pie', url: '#' },
                { title: 'الإعدادات', description: 'إعدادات النظام العامة', icon: 'fas fa-cogs', url: '#' }
            ];
            
            sampleCards.forEach((card, index) => {
                setTimeout(() => {
                    const cardElement = createModernCard(card);
                    cardsContainer.appendChild(cardElement);
                    updateStatus();
                }, index * 200);
            });
        });
        
        // مسح الكروت
        btnClearCards.addEventListener('click', function() {
            cardsContainer.innerHTML = `
                <div class="demo-placeholder">
                    <i class="fas fa-mouse-pointer"></i>
                    <p>اضغط "تحميل الكروت" لعرض الكروت الحديثة</p>
                </div>
            `;
            updateStatus();
        });
        
        // تغيير الثيم
        btnToggleTheme.addEventListener('click', function() {
            isDarkTheme = !isDarkTheme;
            document.body.classList.toggle('dark-theme', isDarkTheme);
            currentTheme.textContent = isDarkTheme ? 'داكن' : 'افتراضي';
        });
        
        // إنشاء كارت حديث
        function createModernCard(cardData) {
            const card = document.createElement('div');
            card.className = 'modern-card card-fade-in';
            card.innerHTML = `
                <div class="card-icon">
                    <i class="${cardData.icon}"></i>
                </div>
                <h3 class="card-title">${cardData.title}</h3>
                <p class="card-description">${cardData.description}</p>
                <div class="card-action">
                    <i class="fas fa-arrow-left"></i>
                </div>
            `;
            
            // إضافة أنماط CSS للكارت
            if (!document.getElementById('modernCardStyles')) {
                const styles = document.createElement('style');
                styles.id = 'modernCardStyles';
                styles.textContent = `
                    .modern-card {
                        background: linear-gradient(135deg, #ffffff, #f8fafc);
                        border-radius: 16px;
                        padding: 2rem;
                        text-align: center;
                        box-shadow: 0 4px 16px rgba(0,0,0,0.1);
                        transition: all 0.3s ease;
                        border: 1px solid #e2e8f0;
                        cursor: pointer;
                        position: relative;
                        overflow: hidden;
                    }
                    
                    .modern-card:hover {
                        transform: translateY(-5px);
                        box-shadow: 0 8px 25px rgba(0,0,0,0.15);
                    }
                    
                    .modern-card .card-icon {
                        width: 60px;
                        height: 60px;
                        background: linear-gradient(135deg, #3b82f6, #1d4ed8);
                        border-radius: 50%;
                        display: flex;
                        align-items: center;
                        justify-content: center;
                        margin: 0 auto 1.5rem;
                        color: white;
                        font-size: 1.5rem;
                    }
                    
                    .modern-card .card-title {
                        font-size: 1.5rem;
                        font-weight: 600;
                        color: #1e293b;
                        margin-bottom: 1rem;
                    }
                    
                    .modern-card .card-description {
                        color: #64748b;
                        line-height: 1.6;
                        margin-bottom: 1.5rem;
                    }
                    
                    .modern-card .card-action {
                        width: 40px;
                        height: 40px;
                        background: #3b82f6;
                        border-radius: 50%;
                        display: flex;
                        align-items: center;
                        justify-content: center;
                        margin: 0 auto;
                        color: white;
                        opacity: 0;
                        transition: all 0.3s ease;
                    }
                    
                    .modern-card:hover .card-action {
                        opacity: 1;
                        transform: scale(1.1);
                    }
                    
                    .card-fade-in {
                        animation: fadeInUp 0.6s ease-out;
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
                    
                    .dark-theme .modern-card {
                        background: linear-gradient(135deg, #334155, #475569);
                        color: white;
                        border-color: #475569;
                    }
                    
                    .dark-theme .modern-card .card-title {
                        color: white;
                    }
                    
                    .dark-theme .modern-card .card-description {
                        color: #cbd5e1;
                    }
                `;
                document.head.appendChild(styles);
            }
            
            return card;
        }
        
        // تحديث معلومات الحالة
        function updateStatus() {
            const cards = cardsContainer.querySelectorAll('.modern-card');
            cardsCount.textContent = cards.length;
            lastUpdate.textContent = new Date().toLocaleTimeString('ar-EG');
        }
        
        // تهيئة الحالة
        updateStatus();
    });
    </script>
</asp:Content>
