<%@ Control Language="VB" AutoEventWireup="false" CodeFile="TransactionBoard.ascx.vb" Inherits="Controls_TransactionBoard" %>

<!-- Modern Transaction Board Dashboard -->

<style>
    .board-dashboard {
        background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
        border-radius: 20px;
        padding: 30px;
        box-shadow: 0 20px 40px rgba(102, 126, 234, 0.3);
        margin: 20px 0;
        position: relative;
        overflow: hidden;
    }

    .board-dashboard::before {
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
        animation: boardMove 20s linear infinite;
        z-index: 1;
    }

    @keyframes boardMove {
        0% { transform: translate(-50%, -50%) rotate(0deg); }
        100% { transform: translate(-50%, -50%) rotate(360deg); }
    }

    .dashboard-header {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 15px;
        padding: 25px;
        margin-bottom: 30px;
        box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(10px);
        border: 1px solid rgba(255, 255, 255, 0.2);
        position: relative;
        z-index: 2;
        text-align: center;
    }

    .dashboard-title {
        font-size: 2.5rem;
        font-weight: 700;
        background: linear-gradient(135deg, #667eea, #764ba2);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin: 0;
        text-shadow: 2px 2px 4px rgba(0,0,0,0.1);
    }

    .dashboard-subtitle {
        color: #64748b;
        font-size: 1.1rem;
        margin-top: 10px;
    }

    .content-card {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 30px;
        box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(10px);
        border: 1px solid rgba(255, 255, 255, 0.2);
        position: relative;
        z-index: 2;
        overflow: hidden;
    }

    .content-card::before {
        content: '';
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        height: 4px;
        background: linear-gradient(90deg, #667eea, #764ba2);
        border-radius: 20px 20px 0 0;
    }

    .placeholder-content {
        text-align: center;
        padding: 60px 20px;
        color: #64748b;
    }

    .placeholder-icon {
        font-size: 4rem;
        color: #667eea;
        margin-bottom: 20px;
        opacity: 0.7;
    }

    .placeholder-title {
        font-size: 1.8rem;
        font-weight: 600;
        margin-bottom: 15px;
        color: #1e293b;
    }

    .placeholder-text {
        font-size: 1.1rem;
        line-height: 1.6;
        margin-bottom: 30px;
    }

    .coming-soon-badge {
        display: inline-block;
        background: linear-gradient(135deg, #667eea, #764ba2);
        color: white;
        padding: 10px 25px;
        border-radius: 25px;
        font-weight: 600;
        box-shadow: 0 5px 15px rgba(102, 126, 234, 0.4);
        margin-top: 20px;
    }

    .feature-list {
        list-style: none;
        padding: 0;
        margin: 30px 0;
        text-align: right;
    }

    .feature-list li {
        padding: 10px 0;
        border-bottom: 1px solid #e2e8f0;
        color: #475569;
    }

    .feature-list li:last-child {
        border-bottom: none;
    }

    .feature-list li i {
        color: #667eea;
        margin-left: 10px;
        font-size: 1.1rem;
    }

    .rtl {
        direction: rtl;
        text-align: right;
    }

    .rtl .dashboard-header {
        text-align: center;
    }

    .rtl .placeholder-content {
        text-align: center;
    }

    /* Responsive Design */
    @media (max-width: 768px) {
        .dashboard-title {
            font-size: 2rem;
        }
        
        .board-dashboard {
            padding: 20px;
            margin: 10px 0;
        }
        
        .content-card {
            padding: 20px;
        }
    }
</style>

<div class="board-dashboard rtl">
    <div class="dashboard-header">
        <h1 class="dashboard-title">
            <i class="fas fa-clipboard-list" style="margin-left: 15px;"></i>
            لوحة المعاملات اليومية
        </h1>
        <p class="dashboard-subtitle">مراقبة وتحليل شامل للمعاملات اليومية</p>
    </div>

    <div class="content-card">
        <div class="placeholder-content">
            <div class="placeholder-icon">
                <i class="fas fa-chart-line"></i>
            </div>
            
            <h2 class="placeholder-title">لوحة المعاملات قيد التطوير</h2>
            
            <p class="placeholder-text">
                نعمل حالياً على تطوير لوحة المعاملات المتقدمة التي ستوفر رؤية شاملة 
                لجميع العمليات اليومية والإحصائيات التفصيلية.
            </p>

            <div class="coming-soon-badge">
                <i class="fas fa-cogs" style="margin-left: 8px;"></i>
                تحت التطوير
            </div>

            <ul class="feature-list">
                <li><i class="fas fa-tachometer-alt"></i> لوحة تحكم تفاعلية للمعاملات</li>
                <li><i class="fas fa-chart-pie"></i> إحصائيات مرئية للأداء اليومي</li>
                <li><i class="fas fa-filter"></i> فلاتر متقدمة حسب السيارة والسائق</li>
                <li><i class="fas fa-clock"></i> تتبع زمني للمعاملات</li>
                <li><i class="fas fa-bell"></i> تنبيهات تلقائية للأحداث المهمة</li>
                <li><i class="fas fa-file-export"></i> تقارير قابلة للتخصيص والتصدير</li>
            </ul>
        </div>
    </div>

    <!-- Hidden Data Source for Future Use -->
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        SelectCommand="SELECT * FROM [Qleelas]" />
</div>


