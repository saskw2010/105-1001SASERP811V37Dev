<%@ Control Language="VB" AutoEventWireup="false" CodeFile="FinancialDashboard.ascx.vb" Inherits="Controls_FinancialDashboard" %>
<%@ Import Namespace="translatemeyamosso" %>
<%@ Import Namespace="DashboardModels" %>

<!-- 💰 Financial Dashboard Control -->
<div class="financial-dashboard-container main-master-dashboard">
    
    <!-- Header Section -->
    <div class="dashboard-header">
        <div class="header-content">
            <h2><i class="fas fa-chart-line"></i> <%=translatemeyamosso.GetResourceValuemosso("FinancialDashboard")%></h2>
            <p><%=translatemeyamosso.GetResourceValuemosso("FinancialOverview")%></p>
        </div>
        <div class="last-updated">
            آخر تحديث: <span id="lastUpdated"><%= DateTime.Now.ToString("dd/MM/yyyy HH:mm") %></span>
        </div>
    </div>

    <!-- Key Financial Metrics -->
    <div class="financial-metrics">
        <div class="metric-card revenue">
            <div class="metric-icon">
                <i class="fas fa-arrow-up"></i>
            </div>
            <div class="metric-content">
                <h3>الإيرادات الإجمالية</h3>
                <div class="metric-value">
                    <asp:Label ID="lblTotalRevenue" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="currency">ريال</span>
                </div>
                <div class="metric-change positive">
                    <i class="fas fa-arrow-up"></i> +12.5%
                </div>
            </div>
        </div>

        <div class="metric-card expenses">
            <div class="metric-icon">
                <i class="fas fa-arrow-down"></i>
            </div>
            <div class="metric-content">
                <h3>المصروفات الإجمالية</h3>
                <div class="metric-value">
                    <asp:Label ID="lblTotalExpenses" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="currency">ريال</span>
                </div>
                <div class="metric-change negative">
                    <i class="fas fa-arrow-down"></i> -8.3%
                </div>
            </div>
        </div>

        <div class="metric-card profit">
            <div class="metric-icon">
                <i class="fas fa-chart-pie"></i>
            </div>
            <div class="metric-content">
                <h3>صافي الربح</h3>
                <div class="metric-value">
                    <asp:Label ID="lblNetProfit" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="currency">ريال</span>
                </div>
                <div class="metric-change positive">
                    <i class="fas fa-arrow-up"></i> +18.7%
                </div>
            </div>
        </div>

        <div class="metric-card balance">
            <div class="metric-icon">
                <i class="fas fa-wallet"></i>
            </div>
            <div class="metric-content">
                <h3>الرصيد الحالي</h3>
                <div class="metric-value">
                    <asp:Label ID="lblCurrentBalance" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="currency">ريال</span>
                </div>
                <div class="metric-change neutral">
                    <i class="fas fa-minus"></i> مستقر
                </div>
            </div>
        </div>

        <div class="metric-card cashflow">
            <div class="metric-icon">
                <i class="fas fa-exchange-alt"></i>
            </div>
            <div class="metric-content">
                <h3>التدفق النقدي</h3>
                <div class="metric-value">
                    <asp:Label ID="lblCashFlow" runat="server" CssClass="metric-number"></asp:Label>
                    <span class="currency">ريال</span>
                </div>
                <div class="metric-change positive">
                    <i class="fas fa-arrow-up"></i> إيجابي
                </div>
            </div>
        </div>
    </div>

    <!-- Invoices Summary -->
    <div class="invoices-section">
        <div class="section-header">
            <h3><i class="fas fa-file-invoice"></i> ملخص الفواتير</h3>
        </div>
        <div class="invoices-grid">
            <div class="invoice-stat paid">
                <div class="stat-icon">
                    <i class="fas fa-check-circle"></i>
                </div>
                <div class="stat-content">
                    <div class="stat-number">
                        <asp:Label ID="lblPaidInvoices" runat="server"></asp:Label>
                    </div>
                    <div class="stat-label">فواتير مدفوعة</div>
                </div>
            </div>

            <div class="invoice-stat pending">
                <div class="stat-icon">
                    <i class="fas fa-clock"></i>
                </div>
                <div class="stat-content">
                    <div class="stat-number">
                        <asp:Label ID="lblPendingInvoices" runat="server"></asp:Label>
                    </div>
                    <div class="stat-label">فواتير معلقة</div>
                </div>
            </div>

            <div class="invoice-stat overdue">
                <div class="stat-icon">
                    <i class="fas fa-exclamation-triangle"></i>
                </div>
                <div class="stat-content">
                    <div class="stat-number">
                        <asp:Label ID="lblOverdueInvoices" runat="server"></asp:Label>
                    </div>
                    <div class="stat-label">فواتير متأخرة</div>
                </div>
            </div>
        </div>
    </div>

    <!-- Accounts Summary -->
    <div class="accounts-section">
        <div class="section-header">
            <h3><i class="fas fa-university"></i> ملخص الحسابات</h3>
            <button class="btn-view-all" onclick="mainmaster.financial.viewAllAccounts()">
                عرض الكل <i class="fas fa-arrow-left"></i>
            </button>
        </div>
        <div class="accounts-list">
            <asp:Repeater ID="rptAccounts" runat="server">
                <ItemTemplate>
                    <div class="account-item">
                        <div class="account-info">
                            <div class="account-name"><%# Eval("AccountName") %></div>
                            <div class="account-number">رقم الحساب: <%# Eval("AccountNumber") %></div>
                            <div class="account-type"><%# Eval("AccountType") %></div>
                        </div>
                        <div class="account-balance">
                            <div class="balance-amount"><%# String.Format("{0:N0}", Eval("Balance")) %></div>
                            <div class="balance-currency">ريال</div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>

    <!-- Recent Transactions -->
    <div class="transactions-section">
        <div class="section-header">
            <h3><i class="fas fa-exchange-alt"></i> آخر المعاملات</h3>
            <button class="btn-view-all" onclick="mainmaster.financial.viewAllTransactions()">
                عرض الكل <i class="fas fa-arrow-left"></i>
            </button>
        </div>
        <div class="transactions-list">
            <asp:Repeater ID="rptTransactions" runat="server">
                <ItemTemplate>
                    <div class="transaction-item <%# If(Eval("Type") = "دائن", "credit", "debit") %>">
                        <div class="transaction-icon">
                            <i class="fas <%# If(Eval("Type") = "دائن", "fa-plus", "fa-minus") %>"></i>
                        </div>
                        <div class="transaction-info">
                            <div class="transaction-description"><%# Eval("Description") %></div>
                            <div class="transaction-date"><%# Convert.ToDateTime(Eval("TransactionDate")).ToString("dd/MM/yyyy") %></div>
                        </div>
                        <div class="transaction-amount <%# If(Eval("Type") = "دائن", "positive", "negative") %>">
                            <%# If(Eval("Type") = "دائن", "+", "-") %><%# String.Format("{0:N0}", Eval("Amount")) %> ريال
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
            <button class="action-btn primary" onclick="mainmaster.financial.createInvoice()">
                <i class="fas fa-plus"></i>
                إنشاء فاتورة جديدة
            </button>
            <button class="action-btn secondary" onclick="mainmaster.financial.viewReports()">
                <i class="fas fa-chart-bar"></i>
                عرض التقارير المالية
            </button>
            <button class="action-btn tertiary" onclick="mainmaster.financial.manageAccounts()">
                <i class="fas fa-cog"></i>
                إدارة الحسابات
            </button>
            <button class="action-btn quaternary" onclick="mainmaster.financial.exportData()">
                <i class="fas fa-download"></i>
                تصدير البيانات
            </button>
        </div>
    </div>

</div>

<style>
/* 💰 Financial Dashboard Styles */
.financial-dashboard-container {
    font-family: 'Cairo', 'Segoe UI', sans-serif;
    direction: rtl;
    background: linear-gradient(135deg, #f8fafc 0%, #e2e8f0 100%);
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
    color: #3b82f6;
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

/* Financial Metrics */
.financial-metrics {
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

.metric-card::before {
    content: '';
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    height: 3px;
    background: linear-gradient(45deg, var(--card-color), var(--card-color-light));
}

.metric-card.revenue {
    --card-color: #10b981;
    --card-color-light: #6ee7b7;
    border-right-color: #10b981;
}

.metric-card.expenses {
    --card-color: #ef4444;
    --card-color-light: #fca5a5;
    border-right-color: #ef4444;
}

.metric-card.profit {
    --card-color: #8b5cf6;
    --card-color-light: #c4b5fd;
    border-right-color: #8b5cf6;
}

.metric-card.balance {
    --card-color: #3b82f6;
    --card-color-light: #93c5fd;
    border-right-color: #3b82f6;
}

.metric-card.cashflow {
    --card-color: #10b981;
    --card-color-light: #6ee7b7;
    border-right-color: #10b981;
}

.metric-card:hover {
    transform: translateY(-5px);
    box-shadow: 0 8px 25px rgba(0,0,0,0.15);
}

.metric-icon {
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

.metric-content {
    padding-left: 80px;
}

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

.currency {
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

.metric-change.positive {
    color: #10b981;
}

.metric-change.negative {
    color: #ef4444;
}

.metric-change.neutral {
    color: #64748b;
}

/* Invoices Section */
.invoices-section {
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
    color: #3b82f6;
}

.btn-view-all {
    background: #3b82f6;
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
    background: #2563eb;
    transform: translateX(-2px);
}

.invoices-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
    gap: 20px;
}

.invoice-stat {
    background: #f8fafc;
    border-radius: 12px;
    padding: 20px;
    text-align: center;
    border: 2px solid;
    transition: all 0.3s ease;
}

.invoice-stat.paid {
    border-color: #10b981;
    background: linear-gradient(135deg, #f0fdf4, #dcfce7);
}

.invoice-stat.pending {
    border-color: #f59e0b;
    background: linear-gradient(135deg, #fffbeb, #fef3c7);
}

.invoice-stat.overdue {
    border-color: #ef4444;
    background: linear-gradient(135deg, #fef2f2, #fecaca);
}

.invoice-stat:hover {
    transform: translateY(-3px);
    box-shadow: 0 6px 20px rgba(0,0,0,0.1);
}

.stat-icon {
    font-size: 2rem;
    margin-bottom: 10px;
}

.invoice-stat.paid .stat-icon {
    color: #10b981;
}

.invoice-stat.pending .stat-icon {
    color: #f59e0b;
}

.invoice-stat.overdue .stat-icon {
    color: #ef4444;
}

.stat-number {
    font-size: 2rem;
    font-weight: 700;
    color: #1e293b;
    margin-bottom: 5px;
}

.stat-label {
    color: #64748b;
    font-size: 0.9rem;
    font-weight: 500;
}

/* Accounts Section */
.accounts-section {
    background: white;
    border-radius: 15px;
    padding: 25px;
    margin-bottom: 30px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.08);
}

.accounts-list {
    display: flex;
    flex-direction: column;
    gap: 15px;
}

.account-item {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 20px;
    background: #f8fafc;
    border-radius: 12px;
    border: 1px solid #e2e8f0;
    transition: all 0.3s ease;
}

.account-item:hover {
    background: #f1f5f9;
    border-color: #cbd5e1;
    transform: translateX(-5px);
}

.account-info {
    flex: 1;
}

.account-name {
    font-size: 1.1rem;
    font-weight: 600;
    color: #1e293b;
    margin-bottom: 5px;
}

.account-number {
    font-size: 0.9rem;
    color: #64748b;
    margin-bottom: 3px;
}

.account-type {
    font-size: 0.85rem;
    color: #3b82f6;
    font-weight: 500;
}

.account-balance {
    text-align: left;
}

.balance-amount {
    font-size: 1.4rem;
    font-weight: 700;
    color: #1e293b;
}

.balance-currency {
    font-size: 0.9rem;
    color: #64748b;
}

/* Transactions Section */
.transactions-section {
    background: white;
    border-radius: 15px;
    padding: 25px;
    margin-bottom: 30px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.08);
}

.transactions-list {
    display: flex;
    flex-direction: column;
    gap: 12px;
}

.transaction-item {
    display: flex;
    align-items: center;
    padding: 15px;
    background: #f8fafc;
    border-radius: 10px;
    border-right: 4px solid;
    transition: all 0.3s ease;
}

.transaction-item.credit {
    border-right-color: #10b981;
}

.transaction-item.debit {
    border-right-color: #ef4444;
}

.transaction-item:hover {
    background: #f1f5f9;
    transform: translateX(-3px);
}

.transaction-icon {
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

.transaction-item.credit .transaction-icon {
    background: #10b981;
}

.transaction-item.debit .transaction-icon {
    background: #ef4444;
}

.transaction-info {
    flex: 1;
}

.transaction-description {
    font-weight: 600;
    color: #1e293b;
    margin-bottom: 3px;
}

.transaction-date {
    font-size: 0.85rem;
    color: #64748b;
}

.transaction-amount {
    font-size: 1.1rem;
    font-weight: 700;
}

.transaction-amount.positive {
    color: #10b981;
}

.transaction-amount.negative {
    color: #ef4444;
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
    background: linear-gradient(135deg, #3b82f6, #1d4ed8);
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

.action-btn:hover {
    transform: translateY(-3px);
    box-shadow: 0 6px 20px rgba(0,0,0,0.15);
}

/* Responsive Design */
@media (max-width: 768px) {
    .financial-dashboard-container {
        padding: 15px;
    }
    
    .dashboard-header {
        flex-direction: column;
        gap: 15px;
        text-align: center;
    }
    
    .financial-metrics {
        grid-template-columns: 1fr;
    }
    
    .invoices-grid {
        grid-template-columns: 1fr;
    }
    
    .actions-grid {
        grid-template-columns: 1fr;
    }
    
    .account-item {
        flex-direction: column;
        gap: 10px;
        text-align: center;
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

@media (max-width: 480px) {
    .section-header {
        flex-direction: column;
        gap: 10px;
    }
    
    .btn-view-all {
        width: 100%;
        justify-content: center;
    }
}
</style>
