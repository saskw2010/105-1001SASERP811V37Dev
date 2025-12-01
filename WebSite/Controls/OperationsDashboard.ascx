<%@ Control Language="VB" AutoEventWireup="false" CodeFile="OperationsDashboard.ascx.vb" Inherits="Controls_OperationsDashboard" %>
<%@ Import Namespace="translatemeyamosso" %>
<%@ Import Namespace="DashboardModels" %>

<!-- ⚙️ Operations Dashboard Control -->
<div class="operations-dashboard-container main-master-dashboard">
    
    <!-- Header Section -->
    <div class="dashboard-header">
        <div class="header-content">
            <h2><i class="fas fa-cogs"></i> لوحة تحكم العمليات</h2>
            <p>إدارة العمليات والمخازن والموردين</p>
        </div>
        <div class="last-updated">
            آخر تحديث: <span><%= DateTime.Now.ToString("dd/MM/yyyy HH:mm") %></span>
        </div>
    </div>

    <!-- Operations Metrics -->
    <div class="operations-metrics">
        <div class="metric-card orders">
            <div class="metric-icon">
                <i class="fas fa-shopping-cart"></i>
            </div>
            <div class="metric-content">
                <h3>إجمالي الطلبات</h3>
                <div class="metric-value">
                    <asp:Label ID="lblTotalOrders" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="metric-unit">طلب</span>
                </div>
                <div class="metric-change positive">
                    <i class="fas fa-arrow-up"></i> +15 اليوم
                </div>
            </div>
        </div>

        <div class="metric-card completed">
            <div class="metric-icon">
                <i class="fas fa-check-circle"></i>
            </div>
            <div class="metric-content">
                <h3>الطلبات المكتملة</h3>
                <div class="metric-value">
                    <asp:Label ID="lblCompletedOrders" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="metric-unit">طلب</span>
                </div>
                <div class="metric-change positive">
                    <i class="fas fa-arrow-up"></i> 91% معدل الإنجاز
                </div>
            </div>
        </div>

        <div class="metric-card processed">
            <div class="metric-icon">
                <i class="fas fa-tasks"></i>
            </div>
            <div class="metric-content">
                <h3>تمت معالجتها اليوم</h3>
                <div class="metric-value">
                    <asp:Label ID="lblProcessedToday" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="metric-unit">طلب</span>
                </div>
                <div class="metric-change positive">
                    <i class="fas fa-clock"></i> في آخر 24 ساعة
                </div>
            </div>
        </div>

        <div class="metric-card inventory">
            <div class="metric-icon">
                <i class="fas fa-boxes"></i>
            </div>
            <div class="metric-content">
                <h3>إجمالي المخزون</h3>
                <div class="metric-value">
                    <asp:Label ID="lblTotalInventory" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="metric-unit">صنف</span>
                </div>
                <div class="metric-change warning">
                    <i class="fas fa-exclamation-triangle"></i> <asp:Label ID="lblLowStockItems" runat="server"></asp:Label> ناقص
                </div>
            </div>
        </div>

        <div class="metric-card pending">
            <div class="metric-icon">
                <i class="fas fa-clock"></i>
            </div>
            <div class="metric-content">
                <h3>الطلبات المعلقة</h3>
                <div class="metric-value">
                    <asp:Label ID="lblPendingOrders" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="metric-unit">طلب</span>
                </div>
                <div class="metric-change neutral">
                    <i class="fas fa-clock"></i> في المراجعة
                </div>
            </div>
        </div>
    </div>

    <!-- Suppliers Section -->
    <div class="suppliers-section">
        <div class="section-header">
            <h3><i class="fas fa-truck"></i> الموردون الرئيسيون</h3>
            <button class="btn-view-all" onclick="mainmaster.operations.viewAllSuppliers()">
                عرض الكل <i class="fas fa-arrow-left"></i>
            </button>
        </div>
        <div class="suppliers-grid">
            <asp:Repeater ID="rptSuppliers" runat="server">
                <ItemTemplate>
                    <div class="supplier-card">
                        <div class="supplier-header">
                            <div class="supplier-icon">
                                <i class="fas fa-building"></i>
                            </div>
                            <div class="supplier-info">
                                <h4><%# Eval("Name") %></h4>
                                <p>المسؤول: <%# Eval("ContactPerson") %></p>
                            </div>
                        </div>
                        <div class="supplier-stats">
                            <div class="stat-item">
                                <div class="stat-label">عدد الطلبات</div>
                                <div class="stat-value"><%# Eval("TotalOrders") %></div>
                            </div>
                            <div class="stat-item">
                                <div class="stat-label">إجمالي القيمة</div>
                                <div class="stat-value"><%# String.Format("{0:N0}", Eval("TotalValue")) %> ريال</div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <!-- Inventory Categories -->
    <div class="categories-section">
        <div class="section-header">
            <h3><i class="fas fa-tags"></i> فئات المخزون</h3>
        </div>
        <div class="categories-grid">
            <asp:Repeater ID="rptCategories" runat="server">
                <ItemTemplate>
                    <div class="category-item">
                        <div class="category-icon">
                            <i class="fas fa-layer-group"></i>
                        </div>
                        <div class="category-info">
                            <h4><%# Eval("Name") %></h4>
                            <p><%# Eval("ItemCount") %> صنف</p>
                            <div class="category-value"><%# String.Format("{0:N0}", Eval("TotalValue")) %> ريال</div>
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
            <button class="action-btn primary" onclick="mainmaster.operations.createOrder()">
                <i class="fas fa-plus"></i>
                إنشاء طلب جديد
            </button>
            <button class="action-btn secondary" onclick="mainmaster.operations.manageInventory()">
                <i class="fas fa-boxes"></i>
                إدارة المخزون
            </button>
            <button class="action-btn tertiary" onclick="mainmaster.operations.manageSuppliers()">
                <i class="fas fa-truck"></i>
                إدارة الموردين
            </button>
            <button class="action-btn quaternary" onclick="mainmaster.operations.viewReports()">
                <i class="fas fa-chart-bar"></i>
                تقارير العمليات
            </button>
        </div>
    </div>

</div>

<style>
/* ⚙️ Operations Dashboard Styles */
.operations-dashboard-container {
    font-family: 'Cairo', 'Segoe UI', sans-serif;
    direction: rtl;
    background: linear-gradient(135deg, #f0f9ff 0%, #e0f2fe 100%);
    padding: 25px;
    border-radius: 20px;
    margin: 20px 0;
}

/* Inherits styles from other dashboards with operations-specific colors */
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

.operations-metrics {
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
    border-right: 4px solid;
    transition: all 0.3s ease;
    position: relative;
    overflow: hidden;
}

.metric-card.orders {
    --card-color: #f59e0b;
    border-right-color: #f59e0b;
}

.metric-card.completed {
    --card-color: #10b981;
    border-right-color: #10b981;
}

.metric-card.processed {
    --card-color: #06b6d4;
    border-right-color: #06b6d4;
}

.metric-card.inventory {
    --card-color: #8b5cf6;
    border-right-color: #8b5cf6;
}

.metric-card.pending {
    --card-color: #ef4444;
    border-right-color: #ef4444;
}

.metric-icon {
    position: absolute;
    top: 20px;
    left: 20px;
    width: 50px;
    height: 50px;
    border-radius: 12px;
    background: var(--card-color);
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    font-size: 1.5rem;
}

.metric-content {
    padding-left: 80px;
}

.suppliers-section, .categories-section, .quick-actions {
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

.suppliers-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    gap: 20px;
}

.supplier-card {
    background: #f8fafc;
    border-radius: 12px;
    padding: 20px;
    border: 1px solid #e2e8f0;
    transition: all 0.3s ease;
}

.supplier-card:hover {
    transform: translateY(-3px);
    box-shadow: 0 6px 20px rgba(0,0,0,0.1);
}

.categories-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
    gap: 15px;
}

.category-item {
    background: #f8fafc;
    border-radius: 12px;
    padding: 20px;
    text-align: center;
    border: 1px solid #e2e8f0;
    transition: all 0.3s ease;
}

.category-item:hover {
    transform: translateY(-3px);
    box-shadow: 0 6px 20px rgba(0,0,0,0.1);
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
    background: linear-gradient(135deg, #8b5cf6, #6d28d9);
    color: white;
}

.action-btn.tertiary {
    background: linear-gradient(135deg, #10b981, #047857);
    color: white;
}

.action-btn.quaternary {
    background: linear-gradient(135deg, #3b82f6, #1d4ed8);
    color: white;
}

.action-btn:hover {
    transform: translateY(-3px);
    box-shadow: 0 6px 20px rgba(0,0,0,0.15);
}

/* Additional shared styles from other components */
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
    margin-bottom: 10px;
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

.metric-change {
    display: flex;
    align-items: center;
    gap: 5px;
    font-size: 0.85rem;
    font-weight: 600;
}

.metric-change.positive { color: #10b981; }
.metric-change.negative { color: #ef4444; }
.metric-change.neutral { color: #64748b; }
.metric-change.warning { color: #f59e0b; }

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

.btn-view-all {
    background: #f59e0b;
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
    background: #d97706;
    transform: translateX(-2px);
}

/* Responsive Design */
@media (max-width: 768px) {
    .operations-dashboard-container {
        padding: 15px;
    }
    
    .operations-metrics {
        grid-template-columns: 1fr;
    }
    
    .suppliers-grid, .categories-grid, .actions-grid {
        grid-template-columns: 1fr;
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
