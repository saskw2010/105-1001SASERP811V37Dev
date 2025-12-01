<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ReportsDashboard.ascx.vb" Inherits="Controls_ReportsDashboard" %>
<%@ Import Namespace="translatemeyamosso" %>
<%@ Import Namespace="DashboardModels" %>

<!-- 📊 Reports Dashboard Control -->
<div class="reports-dashboard-container main-master-dashboard">
    
    <!-- Header -->
    <div class="dashboard-header">
        <div class="header-content">
            <h2><i class="fas fa-file-alt"></i> لوحة تحكم التقارير</h2>
            <p>عرض وإنشاء التقارير والإحصائيات</p>
        </div>
    </div>

    <!-- Reports Metrics -->
    <div class="reports-metrics">
        <div class="metric-card total">
            <div class="metric-icon"><i class="fas fa-file-alt"></i></div>
            <div class="metric-content">
                <h3>إجمالي التقارير</h3>
                <div class="metric-value">
                    <asp:Label ID="lblTotalReports" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="metric-unit">تقرير</span>
                </div>
            </div>
        </div>

        <div class="metric-card recent">
            <div class="metric-icon"><i class="fas fa-clock"></i></div>
            <div class="metric-content">
                <h3>التقارير الحديثة</h3>
                <div class="metric-value">
                    <asp:Label ID="lblRecentReports" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="metric-unit">تقرير</span>
                </div>
            </div>
        </div>

        <div class="metric-card scheduled">
            <div class="metric-icon"><i class="fas fa-calendar"></i></div>
            <div class="metric-content">
                <h3>التقارير المجدولة</h3>
                <div class="metric-value">
                    <asp:Label ID="lblScheduledReports" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="metric-unit">تقرير</span>
                </div>
            </div>
        </div>

        <div class="metric-card generated-today">
            <div class="metric-icon"><i class="fas fa-check-double"></i></div>
            <div class="metric-content">
                <h3>تم إنشاؤها اليوم</h3>
                <div class="metric-value">
                    <asp:Label ID="lblGeneratedToday" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="metric-unit">تقرير</span>
                </div>
            </div>
        </div>

        <div class="metric-card active-reports">
            <div class="metric-icon"><i class="fas fa-file-signature"></i></div>
            <div class="metric-content">
                <h3>التقارير النشطة</h3>
                <div class="metric-value">
                    <asp:Label ID="lblActiveReports" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="metric-unit">تقرير</span>
                </div>
            </div>
        </div>
    </div>

    <!-- Available Reports -->
    <div class="available-reports">
        <div class="section-header">
            <h3><i class="fas fa-list"></i> التقارير المتاحة</h3>
        </div>
        <div class="reports-grid">
            <asp:Repeater ID="rptAvailableReports" runat="server">
                <ItemTemplate>
                    <div class="report-card">
                        <div class="report-icon">
                            <i class="fas fa-chart-bar"></i>
                        </div>
                        <div class="report-info">
                            <h4><%# Eval("Name") %></h4>
                            <p><%# Eval("Description") %></p>
                            <div class="report-meta">
                                <span class="category"><%# Eval("Category") %></span>
                                <span class="last-generated">آخر إنشاء: <%# Convert.ToDateTime(Eval("LastGenerated")).ToString("dd/MM/yyyy") %></span>
                            </div>
                        </div>
                        <div class="report-actions">
                            <button class="btn-generate" onclick="mainmaster.reports.generateReport('<%# Eval("Name") %>')">
                                <i class="fas fa-play"></i> إنشاء
                            </button>
                            <button class="btn-view" onclick="mainmaster.reports.viewReport('<%# Eval("Name") %>')">
                                <i class="fas fa-eye"></i> عرض
                            </button>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <!-- Quick Actions -->
    <div class="quick-actions">
        <div class="section-header">
            <h3><i class="fas fa-bolt"></i> إجراءات سريعة</h3>
        </div>
        <div class="actions-grid">
            <button class="action-btn primary" onclick="mainmaster.reports.createCustomReport()">
                <i class="fas fa-plus"></i>
                إنشاء تقرير مخصص
            </button>
            <button class="action-btn secondary" onclick="mainmaster.reports.scheduleReport()">
                <i class="fas fa-calendar-plus"></i>
                جدولة تقرير
            </button>
            <button class="action-btn tertiary" onclick="mainmaster.reports.exportData()">
                <i class="fas fa-download"></i>
                تصدير البيانات
            </button>
            <button class="action-btn quaternary" onclick="mainmaster.reports.reportSettings()">
                <i class="fas fa-cog"></i>
                إعدادات التقارير
            </button>
        </div>
    </div>

</div>

<style>
/* 📊 Reports Dashboard Styles */
.reports-dashboard-container {
    font-family: 'Cairo', 'Segoe UI', sans-serif;
    direction: rtl;
    background: linear-gradient(135deg, #fef3e2 0%, #fde68a 100%);
    padding: 25px;
    border-radius: 20px;
    margin: 20px 0;
}

.dashboard-header {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-bottom: 30px;
    padding: 20px;
    background: white;
    border-radius: 15px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.1);
}

.header-content h2 {
    color: #1e293b;
    font-size: 1.8rem;
    font-weight: 700;
    margin: 0 0 5px 0;
    display: flex;
    align-items: center;
    gap: 10px;
}

.header-content h2 i {
    color: #f59e0b;
}

.reports-metrics {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
    gap: 20px;
    margin-bottom: 30px;
}

.metric-card {
    background: white;
    border-radius: 15px;
    padding: 25px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.08);
    border-right: 4px solid #f59e0b;
    transition: all 0.3s ease;
    position: relative;
}

.metric-icon {
    position: absolute;
    top: 20px;
    left: 20px;
    width: 50px;
    height: 50px;
    border-radius: 12px;
    background: #f59e0b;
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    font-size: 1.5rem;
}

.metric-content {
    padding-left: 80px;
}

.available-reports, .quick-actions {
    background: white;
    border-radius: 15px;
    padding: 25px;
    margin-bottom: 30px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.08);
}

.reports-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(350px, 1fr));
    gap: 20px;
}

.report-card {
    background: #f8fafc;
    border-radius: 12px;
    padding: 20px;
    border: 1px solid #e2e8f0;
    transition: all 0.3s ease;
    display: flex;
    align-items: center;
    gap: 15px;
}

.report-card:hover {
    transform: translateY(-3px);
    box-shadow: 0 6px 20px rgba(0,0,0,0.1);
}

.report-icon {
    width: 50px;
    height: 50px;
    background: linear-gradient(135deg, #f59e0b, #d97706);
    border-radius: 12px;
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    font-size: 1.3rem;
    flex-shrink: 0;
}

.report-info {
    flex: 1;
}

.report-info h4 {
    color: #1e293b;
    font-size: 1.1rem;
    font-weight: 600;
    margin: 0 0 5px 0;
}

.report-info p {
    color: #64748b;
    font-size: 0.9rem;
    margin: 0 0 10px 0;
}

.report-meta {
    display: flex;
    gap: 15px;
    font-size: 0.85rem;
}

.category {
    background: #f59e0b;
    color: white;
    padding: 2px 8px;
    border-radius: 12px;
    font-weight: 500;
}

.last-generated {
    color: #64748b;
}

.report-actions {
    display: flex;
    flex-direction: column;
    gap: 8px;
}

.btn-generate, .btn-view {
    padding: 8px 12px;
    border: none;
    border-radius: 6px;
    font-size: 0.85rem;
    cursor: pointer;
    transition: all 0.3s ease;
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 5px;
    min-width: 80px;
}

.btn-generate {
    background: #10b981;
    color: white;
}

.btn-view {
    background: #3b82f6;
    color: white;
}

.btn-generate:hover {
    background: #047857;
}

.btn-view:hover {
    background: #1d4ed8;
}

.actions-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
    gap: 15px;
}

.action-btn {
    padding: 15px 20px;
    border: none;
    border-radius: 12px;
    font-size: 0.95rem;
    font-weight: 600;
    cursor: pointer;
    transition: all 0.3s ease;
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 8px;
}

.action-btn.primary {
    background: linear-gradient(135deg, #f59e0b, #d97706);
    color: white;
}

.action-btn.secondary {
    background: linear-gradient(135deg, #10b981, #047857);
    color: white;
}

.action-btn.tertiary {
    background: linear-gradient(135deg, #3b82f6, #1d4ed8);
    color: white;
}

.action-btn.quaternary {
    background: linear-gradient(135deg, #8b5cf6, #6d28d9);
    color: white;
}

.action-btn:hover {
    transform: translateY(-3px);
    box-shadow: 0 6px 20px rgba(0,0,0,0.15);
}

/* Shared styles */
.metric-content h3 {
    color: #64748b;
    font-size: 0.95rem;
    font-weight: 600;
    margin: 0 0 10px 0;
}

.metric-value {
    display: flex;
    align-items: baseline;
    gap: 8px;
}

.metric-number {
    color: #1e293b;
    font-size: 1.8rem;
    font-weight: 700;
}

.metric-unit {
    color: #64748b;
    font-size: 0.9rem;
}

.section-header {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-bottom: 20px;
    padding-bottom: 15px;
    border-bottom: 2px solid #f1f5f9;
}

.section-header h3 {
    color: #1e293b;
    font-size: 1.3rem;
    font-weight: 600;
    margin: 0;
    display: flex;
    align-items: center;
    gap: 10px;
}

.section-header h3 i {
    color: #f59e0b;
}

/* Responsive Design */
@media (max-width: 768px) {
    .reports-dashboard-container {
        padding: 15px;
    }
    
    .reports-metrics, .reports-grid, .actions-grid {
        grid-template-columns: 1fr;
    }
    
    .report-card {
        flex-direction: column;
        text-align: center;
    }
    
    .report-actions {
        flex-direction: row;
        justify-content: center;
    }
    
    .metric-content {
        padding-left: 0;
        text-align: center;
    }
    
    .metric-icon {
        position: static;
        margin: 0 auto 15px auto;
    }
}
</style>
