<%@ Control Language="VB" AutoEventWireup="false" CodeFile="HRDashboard.ascx.vb" Inherits="Controls_HRDashboard" %>
<%@ Import Namespace="translatemeyamosso" %>
<%@ Import Namespace="DashboardModels" %>

<!-- 👥 HR Dashboard Control -->
<div class="hr-dashboard-container main-master-dashboard">
    
    <!-- Header Section -->
    <div class="dashboard-header">
        <div class="header-content">
            <h2><i class="fas fa-users"></i> <%=translatemeyamosso.GetResourceValuemosso("HRDashboard")%></h2>
            <p><%=translatemeyamosso.GetResourceValuemosso("HROverview")%></p>
        </div>
        <div class="last-updated">
            آخر تحديث: <span id="lastUpdated"><%= DateTime.Now.ToString("dd/MM/yyyy HH:mm") %></span>
        </div>
    </div>

    <!-- Employee Statistics -->
    <div class="employee-stats">
        <div class="stat-card total">
            <div class="stat-icon">
                <i class="fas fa-users"></i>
            </div>
            <div class="stat-content">
                <h3>إجمالي الموظفين</h3>
                <div class="stat-value">
                    <asp:Label ID="lblTotalEmployees" runat="server" CssClass="stat-number"></asp:Label>
                    <span class="stat-unit">موظف</span>
                </div>
                <div class="stat-change positive">
                    <i class="fas fa-arrow-up"></i> +5 هذا الشهر
                </div>
            </div>
        </div>

        <div class="stat-card active">
            <div class="stat-icon">
                <i class="fas fa-user-check"></i>
            </div>
            <div class="stat-content">
                <h3>الموظفون النشطون</h3>
                <div class="stat-value">
                    <asp:Label ID="lblActiveEmployees" runat="server" CssClass="stat-number"></asp:Label>
                    <span class="stat-unit">موظف</span>
                </div>
                <div class="stat-change neutral">
                    <i class="fas fa-minus"></i> مستقر
                </div>
            </div>
        </div>

        <div class="stat-card present">
            <div class="stat-icon">
                <i class="fas fa-user-clock"></i>
            </div>
            <div class="stat-content">
                <h3>الحاضرون اليوم</h3>
                <div class="stat-value">
                    <asp:Label ID="lblPresentToday" runat="server" CssClass="stat-number"></asp:Label>
                    <span class="stat-unit">موظف</span>
                </div>
                <div class="stat-change positive">
                    <i class="fas fa-check"></i> متوفر الآن
                </div>
            </div>
        </div>

        <div class="stat-card onleave">
            <div class="stat-icon">
                <i class="fas fa-user-minus"></i>
            </div>
            <div class="stat-content">
                <h3>في إجازة</h3>
                <div class="stat-value">
                    <asp:Label ID="lblOnLeave" runat="server" CssClass="stat-number"></asp:Label>
                    <span class="stat-unit">موظف</span>
                </div>
                <div class="stat-change warning">
                    <i class="fas fa-calendar-day"></i> اليوم
                </div>
            </div>
        </div>

        <div class="stat-card new-hires">
            <div class="stat-icon">
                <i class="fas fa-user-plus"></i>
            </div>
            <div class="stat-content">
                <h3>الموظفون الجدد</h3>
                <div class="stat-value">
                    <asp:Label ID="lblNewHires" runat="server" CssClass="stat-number"></asp:Label>
                    <span class="stat-unit">موظف</span>
                </div>
                <div class="stat-change positive">
                    <i class="fas fa-arrow-up"></i> خلال 30 يوم
                </div>
            </div>
        </div>

        <div class="stat-card leaves">
            <div class="stat-icon">
                <i class="fas fa-calendar-alt"></i>
            </div>
            <div class="stat-content">
                <h3>طلبات الإجازة</h3>
                <div class="stat-value">
                    <asp:Label ID="lblPendingLeaves" runat="server" CssClass="stat-number"></asp:Label>
                    <span class="stat-unit">طلب</span>
                </div>
                <div class="stat-change warning">
                    <i class="fas fa-clock"></i> في الانتظار
                </div>
            </div>
        </div>
    </div>

    <!-- Departments Overview -->
    <div class="departments-section">
        <div class="section-header">
            <h3><i class="fas fa-building"></i> الأقسام</h3>
            <button class="btn-view-all" onclick="mainmaster.hr.viewAllDepartments()">
                عرض الكل <i class="fas fa-arrow-left"></i>
            </button>
        </div>
        <div class="departments-grid">
            <asp:Repeater ID="rptDepartments" runat="server">
                <ItemTemplate>
                    <div class="department-card">
                        <div class="department-header">
                            <div class="department-icon">
                                <i class="fas fa-sitemap"></i>
                            </div>
                            <div class="department-info">
                                <h4><%# Eval("Name") %></h4>
                                <p>المدير: <%# Eval("Manager") %></p>
                            </div>
                        </div>
                        <div class="department-stats">
                            <div class="stat-item">
                                <div class="stat-label">عدد الموظفين</div>
                                <div class="stat-value"><%# Eval("EmployeeCount") %></div>
                            </div>
                            <div class="stat-item">
                                <div class="stat-label">الميزانية</div>
                                <div class="stat-value"><%# String.Format("{0:N0}", Eval("Budget")) %> ريال</div>
                            </div>
                        </div>
                        <div class="department-actions">
                            <button class="btn-action" onclick="mainmaster.hr.viewDepartment('<%# Eval("Name") %>')">
                                <i class="fas fa-eye"></i> عرض
                            </button>
                            <button class="btn-action" onclick="mainmaster.hr.manageDepartment('<%# Eval("Name") %>')">
                                <i class="fas fa-cog"></i> إدارة
                            </button>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <!-- Recent HR Activities -->
    <div class="activities-section">
        <div class="section-header">
            <h3><i class="fas fa-history"></i> النشاطات الأخيرة</h3>
            <button class="btn-view-all" onclick="mainmaster.hr.viewAllActivities()">
                عرض الكل <i class="fas fa-arrow-left"></i>
            </button>
        </div>
        <div class="activities-timeline">
            <asp:Repeater ID="rptActivities" runat="server">
                <ItemTemplate>
                    <div class="activity-item <%# GetActivityClass(Eval("Type")) %>">
                        <div class="activity-icon">
                            <i class="fas <%# GetActivityIcon(Eval("Type")) %>"></i>
                        </div>
                        <div class="activity-content">
                            <div class="activity-header">
                                <h5><%# Eval("Description") %></h5>
                                <span class="activity-date"><%# Convert.ToDateTime(Eval("ActivityDate")).ToString("dd/MM/yyyy") %></span>
                            </div>
                            <div class="activity-details">
                                <span class="activity-type"><%# Eval("Type") %></span>
                                <span class="activity-employee">الموظف: <%# Eval("Employee") %></span>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <!-- Employee Overview Chart -->
    <div class="charts-section">
        <div class="section-header">
            <h3><i class="fas fa-chart-pie"></i> توزيع الموظفين</h3>
        </div>
        <div class="charts-container">
            <div class="chart-card">
                <canvas id="employeeDistributionChart" width="300" height="200"></canvas>
                <div class="chart-legend">
                    <div class="legend-item">
                        <span class="legend-color" style="background: #3b82f6;"></span>
                        <span>دوام كامل</span>
                    </div>
                    <div class="legend-item">
                        <span class="legend-color" style="background: #10b981;"></span>
                        <span>دوام جزئي</span>
                    </div>
                    <div class="legend-item">
                        <span class="legend-color" style="background: #f59e0b;"></span>
                        <span>متدربون</span>
                    </div>
                </div>
            </div>
            
            <div class="performance-metrics">
                <h4>مؤشرات الأداء</h4>
                <div class="metric-bar">
                    <div class="metric-label">معدل الحضور</div>
                    <div class="metric-progress">
                        <div class="progress-bar" style="width: 92%;" data-value="92"></div>
                    </div>
                    <div class="metric-value">92%</div>
                </div>
                <div class="metric-bar">
                    <div class="metric-label">رضا الموظفين</div>
                    <div class="metric-progress">
                        <div class="progress-bar" style="width: 88%;" data-value="88"></div>
                    </div>
                    <div class="metric-value">88%</div>
                </div>
                <div class="metric-bar">
                    <div class="metric-label">معدل الاحتفاظ</div>
                    <div class="metric-progress">
                        <div class="progress-bar" style="width: 95%;" data-value="95"></div>
                    </div>
                    <div class="metric-value">95%</div>
                </div>
            </div>
        </div>
    </div>

    <!-- Quick HR Actions -->
    <div class="quick-actions">
        <div class="section-header">
            <h3><i class="fas fa-bolt"></i> إجراءات سريعة</h3>
        </div>
        <div class="actions-grid">
            <button class="action-btn primary" onclick="mainmaster.hr.addEmployee()">
                <i class="fas fa-user-plus"></i>
                إضافة موظف جديد
            </button>
            <button class="action-btn secondary" onclick="mainmaster.hr.manageLeaves()">
                <i class="fas fa-calendar-check"></i>
                إدارة الإجازات
            </button>
            <button class="action-btn tertiary" onclick="mainmaster.hr.generatePayroll()">
                <i class="fas fa-money-bill-wave"></i>
                إنشاء كشف رواتب
            </button>
            <button class="action-btn quaternary" onclick="mainmaster.hr.viewReports()">
                <i class="fas fa-chart-bar"></i>
                تقارير الموارد البشرية
            </button>
            <button class="action-btn quinary" onclick="mainmaster.hr.training()">
                <i class="fas fa-graduation-cap"></i>
                البرامج التدريبية
            </button>
            <button class="action-btn senary" onclick="mainmaster.hr.performance()">
                <i class="fas fa-trophy"></i>
                تقييم الأداء
            </button>
        </div>
    </div>

</div>

<style>
/* 👥 HR Dashboard Styles */
.hr-dashboard-container {
    font-family: 'Cairo', 'Segoe UI', sans-serif;
    direction: rtl;
    background: linear-gradient(135deg, #f0f9ff 0%, #e0f2fe 100%);
    padding: 25px;
    border-radius: 20px;
    margin: 20px 0;
}

/* Header */
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
    color: #0ea5e9;
}

.header-content p {
    color: #64748b;
    margin: 0;
    font-size: 1rem;
}

.last-updated {
    color: #64748b;
    font-size: 0.9rem;
}

/* Employee Statistics */
.employee-stats {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
    gap: 20px;
    margin-bottom: 30px;
}

.stat-card {
    background: white;
    border-radius: 15px;
    padding: 25px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.08);
    border-right: 4px solid;
    transition: all 0.3s ease;
    position: relative;
    overflow: hidden;
}

.stat-card::before {
    content: '';
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    height: 3px;
    background: linear-gradient(45deg, var(--card-color), var(--card-color-light));
}

.stat-card.total {
    --card-color: #0ea5e9;
    --card-color-light: #7dd3fc;
    border-right-color: #0ea5e9;
}

.stat-card.active {
    --card-color: #10b981;
    --card-color-light: #6ee7b7;
    border-right-color: #10b981;
}

.stat-card.present {
    --card-color: #06d6a0;
    --card-color-light: #7fdbcd;
    border-right-color: #06d6a0;
}

.stat-card.onleave {
    --card-color: #f59e0b;
    --card-color-light: #fcd34d;
    border-right-color: #f59e0b;
}

.stat-card.new-hires {
    --card-color: #8b5cf6;
    --card-color-light: #c4b5fd;
    border-right-color: #8b5cf6;
}

.stat-card.leaves {
    --card-color: #f59e0b;
    --card-color-light: #fbbf24;
    border-right-color: #f59e0b;
}

.stat-card:hover {
    transform: translateY(-5px);
    box-shadow: 0 8px 25px rgba(0,0,0,0.15);
}

.stat-icon {
    position: absolute;
    top: 20px;
    left: 20px;
    width: 50px;
    height: 50px;
    border-radius: 12px;
    background: linear-gradient(45deg, var(--card-color), var(--card-color-light));
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    font-size: 1.5rem;
}

.stat-content {
    padding-left: 80px;
}

.stat-content h3 {
    color: #64748b;
    font-size: 0.95rem;
    font-weight: 600;
    margin: 0 0 10px 0;
}

.stat-value {
    display: flex;
    align-items: baseline;
    gap: 8px;
    margin-bottom: 10px;
}

.stat-number {
    color: #1e293b;
    font-size: 1.8rem;
    font-weight: 700;
}

.stat-unit {
    color: #64748b;
    font-size: 0.9rem;
}

.stat-change {
    display: flex;
    align-items: center;
    gap: 5px;
    font-size: 0.85rem;
    font-weight: 600;
}

.stat-change.positive {
    color: #10b981;
}

.stat-change.negative {
    color: #ef4444;
}

.stat-change.neutral {
    color: #64748b;
}

.stat-change.warning {
    color: #f59e0b;
}

/* Departments Section */
.departments-section {
    background: white;
    border-radius: 15px;
    padding: 25px;
    margin-bottom: 30px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.08);
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
    color: #0ea5e9;
}

.btn-view-all {
    background: #0ea5e9;
    color: white;
    border: none;
    padding: 8px 15px;
    border-radius: 8px;
    font-size: 0.9rem;
    cursor: pointer;
    transition: all 0.3s ease;
    display: flex;
    align-items: center;
    gap: 5px;
}

.btn-view-all:hover {
    background: #0284c7;
    transform: translateX(-2px);
}

.departments-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    gap: 20px;
}

.department-card {
    background: #f8fafc;
    border-radius: 12px;
    padding: 20px;
    border: 1px solid #e2e8f0;
    transition: all 0.3s ease;
}

.department-card:hover {
    background: #f1f5f9;
    border-color: #cbd5e1;
    transform: translateY(-3px);
    box-shadow: 0 6px 20px rgba(0,0,0,0.1);
}

.department-header {
    display: flex;
    align-items: center;
    gap: 15px;
    margin-bottom: 15px;
}

.department-icon {
    width: 50px;
    height: 50px;
    background: linear-gradient(135deg, #0ea5e9, #0284c7);
    border-radius: 12px;
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    font-size: 1.3rem;
}

.department-info h4 {
    color: #1e293b;
    font-size: 1.1rem;
    font-weight: 600;
    margin: 0 0 5px 0;
}

.department-info p {
    color: #64748b;
    font-size: 0.9rem;
    margin: 0;
}

.department-stats {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 15px;
    margin-bottom: 15px;
}

.stat-item {
    text-align: center;
}

.stat-label {
    color: #64748b;
    font-size: 0.85rem;
    margin-bottom: 5px;
}

.stat-value {
    color: #1e293b;
    font-size: 1.1rem;
    font-weight: 600;
}

.department-actions {
    display: flex;
    gap: 10px;
}

.btn-action {
    flex: 1;
    background: #0ea5e9;
    color: white;
    border: none;
    padding: 8px 12px;
    border-radius: 6px;
    font-size: 0.85rem;
    cursor: pointer;
    transition: all 0.3s ease;
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 5px;
}

.btn-action:hover {
    background: #0284c7;
}

/* Activities Section */
.activities-section {
    background: white;
    border-radius: 15px;
    padding: 25px;
    margin-bottom: 30px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.08);
}

.activities-timeline {
    display: flex;
    flex-direction: column;
    gap: 15px;
}

.activity-item {
    display: flex;
    align-items: center;
    padding: 15px;
    background: #f8fafc;
    border-radius: 10px;
    border-right: 4px solid;
    transition: all 0.3s ease;
}

.activity-item.hiring {
    border-right-color: #10b981;
}

.activity-item.leave {
    border-right-color: #f59e0b;
}

.activity-item.training {
    border-right-color: #8b5cf6;
}

.activity-item:hover {
    background: #f1f5f9;
    transform: translateX(-3px);
}

.activity-icon {
    width: 40px;
    height: 40px;
    border-radius: 10px;
    display: flex;
    align-items: center;
    justify-content: center;
    margin-left: 15px;
    color: white;
    font-size: 1.1rem;
}

.activity-item.hiring .activity-icon {
    background: #10b981;
}

.activity-item.leave .activity-icon {
    background: #f59e0b;
}

.activity-item.training .activity-icon {
    background: #8b5cf6;
}

.activity-content {
    flex: 1;
}

.activity-header {
    display: flex;
    justify-content: space-between;
    align-items: center;
    margin-bottom: 5px;
}

.activity-header h5 {
    color: #1e293b;
    font-size: 1rem;
    font-weight: 600;
    margin: 0;
}

.activity-date {
    color: #64748b;
    font-size: 0.85rem;
}

.activity-details {
    display: flex;
    gap: 15px;
}

.activity-type {
    background: #0ea5e9;
    color: white;
    padding: 2px 8px;
    border-radius: 12px;
    font-size: 0.75rem;
    font-weight: 500;
}

.activity-employee {
    color: #64748b;
    font-size: 0.85rem;
}

/* Charts Section */
.charts-section {
    background: white;
    border-radius: 15px;
    padding: 25px;
    margin-bottom: 30px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.08);
}

.charts-container {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 30px;
    align-items: start;
}

.chart-card {
    text-align: center;
}

.chart-legend {
    display: flex;
    justify-content: center;
    gap: 20px;
    margin-top: 15px;
}

.legend-item {
    display: flex;
    align-items: center;
    gap: 8px;
    font-size: 0.9rem;
}

.legend-color {
    width: 16px;
    height: 16px;
    border-radius: 4px;
}

.performance-metrics h4 {
    color: #1e293b;
    font-size: 1.2rem;
    font-weight: 600;
    margin-bottom: 20px;
}

.metric-bar {
    display: grid;
    grid-template-columns: 1fr 2fr 60px;
    gap: 15px;
    align-items: center;
    margin-bottom: 15px;
}

.metric-label {
    color: #64748b;
    font-size: 0.9rem;
    font-weight: 500;
}

.metric-progress {
    background: #e2e8f0;
    border-radius: 10px;
    height: 8px;
    overflow: hidden;
}

.progress-bar {
    height: 100%;
    background: linear-gradient(135deg, #0ea5e9, #0284c7);
    border-radius: 10px;
    transition: width 0.8s ease;
}

.metric-value {
    color: #1e293b;
    font-weight: 600;
    text-align: center;
}

/* Quick Actions */
.quick-actions {
    background: white;
    border-radius: 15px;
    padding: 25px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.08);
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
    text-align: center;
}

.action-btn.primary {
    background: linear-gradient(135deg, #0ea5e9, #0284c7);
    color: white;
}

.action-btn.secondary {
    background: linear-gradient(135deg, #10b981, #047857);
    color: white;
}

.action-btn.tertiary {
    background: linear-gradient(135deg, #8b5cf6, #6d28d9);
    color: white;
}

.action-btn.quaternary {
    background: linear-gradient(135deg, #f59e0b, #d97706);
    color: white;
}

.action-btn.quinary {
    background: linear-gradient(135deg, #ef4444, #dc2626);
    color: white;
}

.action-btn.senary {
    background: linear-gradient(135deg, #06b6d4, #0891b2);
    color: white;
}

.action-btn:hover {
    transform: translateY(-3px);
    box-shadow: 0 6px 20px rgba(0,0,0,0.15);
}

/* Responsive Design */
@media (max-width: 768px) {
    .hr-dashboard-container {
        padding: 15px;
    }
    
    .dashboard-header {
        flex-direction: column;
        gap: 15px;
        text-align: center;
    }
    
    .employee-stats {
        grid-template-columns: 1fr;
    }
    
    .departments-grid {
        grid-template-columns: 1fr;
    }
    
    .charts-container {
        grid-template-columns: 1fr;
    }
    
    .actions-grid {
        grid-template-columns: 1fr;
    }
    
    .stat-content {
        padding-left: 0;
        text-align: center;
    }
    
    .stat-icon {
        position: static;
        margin: 0 auto 15px auto;
    }
    
    .department-stats {
        grid-template-columns: 1fr;
    }
}

@media (max-width: 480px) {
    .section-header {
        flex-direction: column;
        gap: 10px;
    }
    
    .btn-view-all {
        width: 100%;
        justify-content: center;
    }
    
    .metric-bar {
        grid-template-columns: 1fr;
        gap: 8px;
    }
    
    .activity-header {
        flex-direction: column;
        align-items: flex-start;
        gap: 5px;
    }
}
</style>

<script>
// Initialize HR Dashboard
document.addEventListener('DOMContentLoaded', function() {
    console.log('👥 HR Dashboard Loaded');
    
    // Initialize charts if Chart.js is available
    if (typeof Chart !== 'undefined') {
        initEmployeeDistributionChart();
    }
    
    // Animate progress bars
    animateProgressBars();
});

function initEmployeeDistributionChart() {
    const ctx = document.getElementById('employeeDistributionChart');
    if (!ctx) return;
    
    new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: ['دوام كامل', 'دوام جزئي', 'متدربون'],
            datasets: [{
                data: [65, 25, 10],
                backgroundColor: ['#3b82f6', '#10b981', '#f59e0b'],
                borderWidth: 2,
                borderColor: '#ffffff'
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            plugins: {
                legend: {
                    display: false
                }
            }
        }
    });
}

function animateProgressBars() {
    const progressBars = document.querySelectorAll('.progress-bar');
    progressBars.forEach(bar => {
        const width = bar.style.width;
        bar.style.width = '0%';
        setTimeout(() => {
            bar.style.width = width;
        }, 500);
    });
}
</script>
