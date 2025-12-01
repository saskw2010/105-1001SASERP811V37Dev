<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="FinancialDashboardVue.aspx.cs" Inherits="app_myaspxpages_FinancialDashboardVue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="server">
    لوحة المعلومات المالية - Vue.js
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="server">
    <!-- Font Awesome 6 Integration -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" integrity="sha512-DTOQO9RWCH3ppGqcWaEA1BIZOC6xxalwEsw9c2QQeAIftl+Vegovlnee1c9QX4TctnWMn13TZye+giMm8e2LwA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    
    <!-- Enhanced Vue App with Professional Design -->
    <div id="vueAppContainer" class="vue-enhanced-container" data-app-role="page" data-content-framework="bootstrap">
        <style>
            /* Professional AI-Style Design */
            .vue-enhanced-container {
                font-family: 'Segoe UI', 'Roboto', 'Arial', sans-serif;
                background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
                min-height: 100vh;
                padding: 20px;
                margin: -15px;
                color: #fff;
            }
            
            .enhanced-header {
                background: rgba(255, 255, 255, 0.95);
                border-radius: 15px;
                padding: 25px;
                margin-bottom: 30px;
                box-shadow: 0 10px 30px rgba(0, 0, 0, 0.2);
                backdrop-filter: blur(10px);
                color: #333;
            }
            
            .enhanced-title {
                font-size: 2.5rem;
                font-weight: 700;
                background: linear-gradient(45deg, #667eea, #764ba2);
                background-clip: text;
                -webkit-background-clip: text;
                -webkit-text-fill-color: transparent;
                margin: 0;
                text-align: center;
            }
            
            .control-group {
                display: flex;
                justify-content: center;
                align-items: center;
                gap: 15px;
                margin-top: 20px;
                flex-wrap: wrap;
            }
            
            .enhanced-btn {
                background: linear-gradient(45deg, #667eea, #764ba2);
                border: none;
                color: white;
                padding: 12px 24px;
                border-radius: 25px;
                font-size: 16px;
                font-weight: 600;
                cursor: pointer;
                transition: all 0.3s ease;
                box-shadow: 0 4px 15px rgba(102, 126, 234, 0.4);
            }
            
            .enhanced-btn:hover {
                transform: translateY(-2px);
                box-shadow: 0 6px 20px rgba(102, 126, 234, 0.6);
            }
            
            .enhanced-select {
                background: rgba(255, 255, 255, 0.9);
                border: 2px solid #667eea;
                border-radius: 15px;
                padding: 12px 20px;
                font-size: 16px;
                font-weight: 600;
                color: #333;
                min-width: 150px;
                outline: none;
                transition: all 0.3s ease;
            }
            
            .enhanced-select:focus {
                border-color: #764ba2;
                box-shadow: 0 0 15px rgba(102, 126, 234, 0.3);
            }
            
            .checkbox-enhanced {
                background: rgba(255, 255, 255, 0.9);
                padding: 12px 20px;
                border-radius: 15px;
                display: flex;
                align-items: center;
                gap: 10px;
                font-weight: 600;
                color: #333;
                cursor: pointer;
                transition: all 0.3s ease;
            }
            
            .checkbox-enhanced:hover {
                background: rgba(255, 255, 255, 1);
            }
            
            .stats-grid {
                display: grid;
                grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
                gap: 25px;
                margin: 30px 0;
            }
            
            .stat-card {
                background: rgba(255, 255, 255, 0.95);
                border-radius: 20px;
                padding: 30px;
                box-shadow: 0 10px 30px rgba(0, 0, 0, 0.2);
                backdrop-filter: blur(10px);
                transition: all 0.3s ease;
                color: #333;
            }
            
            .stat-card:hover {
                transform: translateY(-5px);
                box-shadow: 0 15px 40px rgba(0, 0, 0, 0.3);
            }
            
            .stat-icon {
                font-size: 3rem;
                margin-bottom: 15px;
                display: block;
                text-align: center;
            }
            
            .stat-value {
                font-size: 2.5rem;
                font-weight: 700;
                text-align: center;
                margin: 15px 0;
            }
            
            .stat-label {
                font-size: 1.2rem;
                font-weight: 600;
                text-align: center;
                opacity: 0.8;
            }
            
            .stat-count {
                font-size: 0.9rem;
                text-align: center;
                opacity: 0.6;
                margin-top: 10px;
            }
            
            .income-card { border-left: 5px solid #28a745; }
            .income-card .stat-icon { color: #28a745; }
            .income-card .stat-value { color: #28a745; }
            
            .expense-card { border-left: 5px solid #dc3545; }
            .expense-card .stat-icon { color: #dc3545; }
            .expense-card .stat-value { color: #dc3545; }
            
            .balance-card { border-left: 5px solid #007bff; }
            .balance-card .stat-icon { color: #007bff; }
            .balance-card .stat-value { color: #007bff; }
            
            .profit-card { border-left: 5px solid #28a745; }
            .profit-card .stat-icon { color: #28a745; }
            .profit-card .stat-value { color: #28a745; }
            
            .loss-card { border-left: 5px solid #dc3545; }
            .loss-card .stat-icon { color: #dc3545; }
            .loss-card .stat-value { color: #dc3545; }
            
            .data-section {
                background: rgba(255, 255, 255, 0.95);
                border-radius: 20px;
                padding: 30px;
                margin: 25px 0;
                box-shadow: 0 10px 30px rgba(0, 0, 0, 0.2);
                backdrop-filter: blur(10px);
                color: #333;
            }
            
            .section-title {
                font-size: 1.8rem;
                font-weight: 700;
                margin-bottom: 25px;
                padding-bottom: 15px;
                border-bottom: 3px solid #667eea;
                text-align: center;
            }
            
            .data-table {
                width: 100%;
                border-collapse: collapse;
                margin-top: 20px;
            }
            
            .data-table th {
                background: linear-gradient(45deg, #667eea, #764ba2);
                color: white;
                padding: 15px;
                font-weight: 600;
                text-align: center;
                border-radius: 8px 8px 0 0;
            }
            
            .data-table td {
                padding: 15px;
                text-align: center;
                border-bottom: 1px solid #eee;
                font-size: 1.1rem;
            }
            
            .data-table tr:nth-child(even) {
                background: rgba(102, 126, 234, 0.05);
            }
            
            .data-table tr:hover {
                background: rgba(102, 126, 234, 0.1);
                transform: scale(1.01);
                transition: all 0.2s ease;
            }
            
            .loading-spinner {
                text-align: center;
                padding: 50px;
            }
            
            .loading-spinner i {
                font-size: 3rem;
                color: #667eea;
                animation: spin 1s linear infinite;
            }
            
            @keyframes spin {
                from { transform: rotate(0deg); }
                to { transform: rotate(360deg); }
            }
            
            .loading-text {
                font-size: 1.2rem;
                margin-top: 15px;
                color: #667eea;
                font-weight: 600;
            }
            
            .rtl-layout {
                direction: rtl;
                text-align: right;
            }
            
            .ltr-layout {
                direction: ltr;
                text-align: left;
            }
            
            .period-indicator {
                background: linear-gradient(45deg, #28a745, #20c997);
                color: white;
                padding: 10px 20px;
                border-radius: 25px;
                font-size: 1.1rem;
                font-weight: 600;
                display: inline-block;
                margin: 15px 0;
            }
        </style>

        <div id="app" :class="isArabic ? 'rtl-layout' : 'ltr-layout'">
            <!-- Enhanced Header -->
            <div class="enhanced-header">
                <h1 class="enhanced-title">
                    <i class="fas fa-chart-line"></i>
                    {{ pageTitle }}
                </h1>
                
                <div class="control-group">
                    <!-- Language Toggle -->
                    <button @click="toggleLanguage" class="enhanced-btn">
                        <i class="fas fa-language"></i>
                        {{ isArabic ? 'English' : 'العربية' }}
                    </button>
                    
                    <!-- Period Selector -->
                    <select v-model="selectedPeriod" @change="loadData" class="enhanced-select">
                        <option v-for="period in periods" :key="period.value" :value="period.value">
                            {{ period.text }}
                        </option>
                    </select>
                    
                    <!-- Demo Toggle -->
                    <label class="checkbox-enhanced">
                        <input type="checkbox" v-model="isDemo" @change="loadData" />
                        <span>{{ demoText }}</span>
                    </label>
                    
                    <!-- Refresh -->
                    <button @click="loadData" class="enhanced-btn">
                        <i class="fas fa-sync-alt" :class="{ 'fa-spin': loading }"></i>
                        {{ refreshText }}
                    </button>
                </div>
                
                <!-- Period Indicator -->
                <div class="text-center">
                    <span class="period-indicator">
                        <i class="fas fa-calendar"></i>
                        {{ periodDisplay }}
                    </span>
                </div>
            </div>

            <!-- Loading Indicator -->
            <div v-if="loading" class="loading-spinner">
                <i class="fas fa-spinner"></i>
                <div class="loading-text">{{ loadingText }}</div>
            </div>

            <!-- Enhanced Summary Cards -->
            <div class="stats-grid" v-if="!loading">
                <!-- Income Card -->
                <div class="stat-card income-card">
                    <i class="fas fa-arrow-up stat-icon"></i>
                    <div class="stat-value">{{ formatCurrency(summary.totalIncome) }}</div>
                    <div class="stat-label">{{ incomeLabel }}</div>
                    <div class="stat-count">{{ summary.incomeCount }} {{ transactionText }}</div>
                </div>

                <!-- Expenses Card -->
                <div class="stat-card expense-card">
                    <i class="fas fa-arrow-down stat-icon"></i>
                    <div class="stat-value">{{ formatCurrency(summary.totalExpenses) }}</div>
                    <div class="stat-label">{{ expensesLabel }}</div>
                    <div class="stat-count">{{ summary.expensesCount }} {{ transactionText }}</div>
                </div>

                <!-- Balance Card -->
                <div class="stat-card" :class="getBalanceClass()">
                    <i class="fa" :class="getBalanceIcon()" class="stat-icon"></i>
                    <div class="stat-value">{{ formatCurrency(summary.balance) }}</div>
                    <div class="stat-label">{{ balanceLabel }}</div>
                    <div class="stat-count">{{ getBalanceStatus() }}</div>
                </div>
            </div>

            <!-- Enhanced Data Sections -->
            <div v-if="!loading">
                <!-- Income Data Section -->
                <div class="data-section">
                    <h3 class="section-title">
                        <i class="fas fa-money-bill-wave"></i>
                        {{ incomeTableTitle }}
                    </h3>
                    <table class="data-table">
                        <thead>
                            <tr>
                                <th>{{ isArabic ? 'التاريخ' : 'Date' }}</th>
                                <th>{{ isArabic ? 'المبلغ' : 'Amount' }}</th>
                                <th>{{ isArabic ? 'طريقة الدفع' : 'Payment Method' }}</th>
                                <th>{{ isArabic ? 'الوصف' : 'Description' }}</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr v-for="item in income" :key="item.id">
                                <td>{{ formatDate(item.date) }}</td>
                                <td class="stat-value income-card">{{ formatCurrency(item.amount) }}</td>
                                <td>{{ item.method }}</td>
                                <td>{{ item.description }}</td>
                            </tr>
                            <tr v-if="income.length === 0">
                                <td colspan="4" class="text-center">{{ noDataText }}</td>
                            </tr>
                        </tbody>
                    </table>
                </div>

                <!-- Payment Methods Section -->
                <div class="data-section">
                    <h3 class="section-title">
                        <i class="fas fa-credit-card"></i>
                        {{ paymentMethodsTitle }}
                    </h3>
                    <div class="stats-grid">
                        <div v-for="method in paymentMethods" :key="method.method" class="stat-card balance-card">
                            <i class="fas fa-wallet stat-icon"></i>
                            <div class="stat-value">{{ formatCurrency(method.amount) }}</div>
                            <div class="stat-label">{{ method.method }}</div>
                            <div class="stat-count">{{ method.count }} {{ transactionText }}</div>
                        </div>
                        <div v-if="paymentMethods.length === 0" class="stat-card">
                            <i class="fas fa-info-circle stat-icon"></i>
                            <div class="stat-label">{{ noDataText }}</div>
                        </div>
                    </div>
                </div>

                <!-- Expenses Section -->
                <div class="data-section">
                    <h3 class="section-title">
                        <i class="fas fa-shopping-cart"></i>
                        {{ expensesTableTitle }}
                    </h3>
                    <table class="data-table">
                        <thead>
                            <tr>
                                <th>{{ isArabic ? 'التاريخ' : 'Date' }}</th>
                                <th>{{ isArabic ? 'المبلغ' : 'Amount' }}</th>
                                <th>{{ isArabic ? 'الفئة' : 'Category' }}</th>
                                <th>{{ isArabic ? 'الوصف' : 'Description' }}</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr v-for="item in expenses" :key="item.id">
                                <td>{{ formatDate(item.date) }}</td>
                                <td class="stat-value expense-card">{{ formatCurrency(item.amount) }}</td>
                                <td>{{ item.category }}</td>
                                <td>{{ item.description }}</td>
                            </tr>
                            <tr v-if="expenses.length === 0">
                                <td colspan="4" class="text-center">{{ noDataText }}</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
                    </div>
                    <div class="panel-body">
                        <div class="table-responsive">
                            <table class="table table-striped table-hover">
                                <thead>
                                    <tr class="bg-success">
                                        <th>{{ dateHeader }}</th>
                                        <th>{{ descriptionHeader }}</th>
                                        <th class="text-right">{{ amountHeader }}</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr v-for="item in incomeData" :key="item.id">
                                        <td>{{ formatDate(item.date) }}</td>
                                        <td>{{ item.description }}</td>
                                        <td class="text-right text-success">
                                            <strong>{{ formatCurrency(item.amount) }}</strong>
                                        </td>
                                    </tr>
                                    <tr v-if="incomeData.length === 0">
                                        <td colspan="3" class="text-center text-muted">
                                            {{ noDataText }}
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
               
           

            <!-- Payment Methods Summary -->
            <div class="col-md-4">
                <div class="panel panel-info">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <i class="fas fa-credit-card"></i>
                            {{ paymentSummaryTitle }}
                        </h4>
                    </div>
                    <div class="panel-body">
                        <div class="table-responsive">
                            <table class="table table-condensed">
                                <thead>
                                    <tr>
                                        <th>{{ paymentMethodHeader }}</th>
                                        <th class="text-right">{{ amountHeader }}</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr v-for="method in paymentMethods" :key="method.method">
                                        <td>{{ method.method }}</td>
                                        <td class="text-right">
                                            <span class="label label-info">{{ formatCurrency(method.amount) }}</span>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
       

        <!-- Expenses Table (Full Width) -->
        <div class="row" v-if="!loading">
            <div class="col-md-12">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        <h4 class="panel-title">
                            <i class="fas fa-credit-card"></i>
                            {{ expensesTableTitle }}
                        </h4>
                    </div>
                    <div class="panel-body">
                        <div class="table-responsive">
                            <table class="table table-striped table-hover">
                                <thead>
                                    <tr class="bg-danger">
                                        <th>{{ dateHeader }}</th>
                                        <th>{{ descriptionHeader }}</th>
                                        <th class="text-right">{{ amountHeader }}</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr v-for="item in expensesData" :key="item.id">
                                        <td>{{ formatDate(item.date) }}</td>
                                        <td>{{ item.description }}</td>
                                        <td class="text-right text-danger">
                                            <strong>{{ formatCurrency(item.amount) }}</strong>
                                        </td>
                                    </tr>
                                    <tr v-if="expensesData.length === 0">
                                        <td colspan="3" class="text-center text-muted">
                                            {{ noDataText }}
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Report Period Info -->
        <div class="row" v-if="!loading">
            <div class="col-md-12">
                <div class="alert alert-info">
                    <div class="row">
                        <div class="col-md-8">
                            <i class="fas fa-info-circle"></i>
                            <strong>{{ reportPeriodLabel }}</strong> {{ currentPeriodText }}
                        </div>
                        <div class="col-md-4 text-left">
                            {{ dataSourceText }}
                            <small style="display: block; color: #666;">
                                Lang: {{ isArabic ? 'AR' : 'EN' }} | Vue.js
                            </small>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- End Vue App Container -->

    <!-- Vue.js and dependencies -->
    <script src="https://cdn.jsdelivr.net/npm/vue@2.6.14/dist/vue.min.js"></script>
    <script>
        // Fallback for Vue.js if CDN fails
        if (typeof Vue === 'undefined') {
            document.write('<script src="https://unpkg.com/vue@2.6.14/dist/vue.min.js"><\/script>');
        }
    </script>
    <script src="https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js"></script>
    <script>
        // Fallback for Axios if CDN fails
        if (typeof axios === 'undefined') {
            document.write('<script src="https://unpkg.com/axios/dist/axios.min.js"><\/script>');
        }
    </script>

    <script>
        // Wait for DOM to be fully loaded and Master Page scripts to initialize
        document.addEventListener('DOMContentLoaded', function() {
            // Add delay to ensure all scripts are loaded
            setTimeout(function() {
                // Check if all required libraries are loaded
                if (typeof Vue !== 'undefined' && typeof axios !== 'undefined') {
                    initializeVueApp();
                } else {
                    // Retry after additional delay
                    setTimeout(function() {
                        if (typeof Vue !== 'undefined' && typeof axios !== 'undefined') {
                            initializeVueApp();
                        } else {
                            showLibraryError();
                        }
                    }, 1000);
                }
            }, 200);
        });
        
        function showLibraryError() {
            const appContainer = document.getElementById('app');
            if (appContainer) {
                appContainer.innerHTML = `
                    <div class="alert alert-warning">
                        <h4><i class="fas fa-exclamation-triangle"></i> مشكلة في تحميل المكتبات</h4>
                        <p>يبدو أن هناك مشكلة في تحميل Vue.js أو Axios من الإنترنت. يرجى التحقق من الاتصال بالإنترنت.</p>
                        <button class="btn btn-primary" onclick="location.reload()">إعادة المحاولة</button>
                    </div>
                `;
            }
        }
        
        function initializeVueApp() {
            // Check if Vue is loaded
            if (typeof Vue === 'undefined') {
                console.error('Vue.js not loaded');
                setTimeout(initializeVueApp, 100);
                return;
            }
            
            // Ensure the container exists
            const appContainer = document.getElementById('app');
            if (!appContainer) {
                console.error('Vue app container not found');
                return;
            }
            
            // Create Vue instance with error handling
            try {
                // Configure Vue for production
                Vue.config.productionTip = false;
                Vue.config.devtools = false;
                
                // Handle potential conflicts with ASP.NET
                Vue.config.ignoredElements = [
                    'asp:literal',
                    'asp:contentplaceholder'
                ];
                
                // Global error handler
                Vue.config.errorHandler = function (err, vm, info) {
                    console.error('Vue Error:', err);
                    console.error('Component:', vm);
                    console.error('Info:', info);
                };
                
                window.vueApp = new Vue({
            el: '#app',
            data: {
                // Language & UI
                isArabic: true,
                loading: false,
                
                // Period selection - Default to 'today'
                selectedPeriod: 'today',
                
                // Data toggles - Default demo to false for real data
                isDemo: false,
                
                // Data
                incomeData: [],
                expensesData: [],
                paymentMethods: [],
                summary: {
                    totalIncome: 0,
                    totalExpenses: 0,
                    balance: 0,
                    incomeCount: 0,
                    expensesCount: 0
                }
            },
            computed: {
                // Texts based on language
                pageTitle() {
                    return this.isArabic ? 'لوحة المعلومات المالية' : 'Financial Dashboard';
                },
                demoText() {
                    return this.isArabic ? 'بيانات تجريبية' : 'Demo Data';
                },
                refreshText() {
                    return this.isArabic ? 'تحديث' : 'Refresh';
                },
                loadingText() {
                    return this.isArabic ? 'جاري التحميل...' : 'Loading...';
                },
                incomeLabel() {
                    return this.isArabic ? 'إجمالي الإيرادات المباشرة' : 'Total Direct Income';
                },
                expensesLabel() {
                    return this.isArabic ? 'إجمالي المصروفات' : 'Total Expenses';
                },
                balanceLabel() {
                    return this.isArabic ? 'الرصيد الصافي' : 'Net Balance';
                },
                transactionText() {
                    return this.isArabic ? 'معاملة' : 'transaction';
                },
                incomeTableTitle() {
                    return this.isArabic ? 'سندات القبض المباشرة' : 'Direct Payment Receipts';
                },
                expensesTableTitle() {
                    return this.isArabic ? 'سندات الصرف' : 'Payment Vouchers';
                },
                paymentSummaryTitle() {
                    return this.isArabic ? 'ملخص طرق الدفع' : 'Payment Methods Summary';
                },
                dateHeader() {
                    return this.isArabic ? 'التاريخ' : 'Date';
                },
                descriptionHeader() {
                    return this.isArabic ? 'البيان' : 'Description';
                },
                amountHeader() {
                    return this.isArabic ? 'المبلغ' : 'Amount';
                },
                paymentMethodHeader() {
                    return this.isArabic ? 'طريقة الدفع' : 'Payment Method';
                },
                noDataText() {
                    return this.isArabic ? 'لا توجد بيانات للعرض' : 'No data to display';
                },
                reportPeriodLabel() {
                    return this.isArabic ? 'فترة التقرير:' : 'Report Period:';
                },
                dataSourceText() {
                    return this.isDemo ? 
                        (this.isArabic ? 'بيانات تجريبية' : 'Demo Data') : 
                        (this.isArabic ? 'بيانات حقيقية' : 'Real Data');
                },
                currentPeriodText() {
                    const period = this.periods.find(p => p.value === this.selectedPeriod);
                    return period ? period.text : '';
                },
                // Enhanced period display
                periodDisplay() {
                    const periods = {
                        'today': this.isArabic ? 'اليوم' : 'Today',
                        'week': this.isArabic ? 'هذا الأسبوع' : 'This Week', 
                        'month': this.isArabic ? 'هذا الشهر' : 'This Month',
                        'year': this.isArabic ? 'هذه السنة' : 'This Year'
                    };
                    return periods[this.selectedPeriod] || this.selectedPeriod;
                },
                
                // Period options for dropdown
                periods() {
                    return [
                        { value: 'today', text: this.isArabic ? 'اليوم' : 'Today' },
                        { value: 'week', text: this.isArabic ? 'هذا الأسبوع' : 'This Week' },
                        { value: 'month', text: this.isArabic ? 'هذا الشهر' : 'This Month' },
                        { value: 'year', text: this.isArabic ? 'هذه السنة' : 'This Year' }
                    ];
                },
                
                // Data arrays for display
                income() {
                    return this.incomeData || [];
                },
                expenses() {
                    return this.expensesData || [];
                },
            },
            methods: {
                toggleLanguage() {
                    this.isArabic = !this.isArabic;
                    // Update document direction
                    document.documentElement.setAttribute('dir', this.isArabic ? 'rtl' : 'ltr');
                    // Re-load data to update period texts
                    this.loadData();
                },
                
                async loadData() {
                    this.loading = true;
                    console.log('Loading data with params:', {
                        period: this.selectedPeriod,
                        isDemo: this.isDemo,
                        isArabic: this.isArabic
                    });
                    
                    try {
                        // Configure axios for ASP.NET Web Methods
                        const response = await axios({
                            method: 'POST',
                            url: 'FinancialDashboardVue.aspx/GetDashboardData',
                            data: JSON.stringify({
                                period: this.selectedPeriod,
                                isDemo: this.isDemo,
                                isArabic: this.isArabic
                            }),
                            headers: {
                                'Content-Type': 'application/json; charset=utf-8'
                            },
                            timeout: 30000 // 30 seconds timeout
                        });
                        
                        console.log('Raw response:', response.data);
                        
                        if (response.data && response.data.d) {
                            const data = JSON.parse(response.data.d);
                            console.log('Parsed data:', data);
                            
                            // Display debug information if available
                            if (data.debug) {
                                console.log('Debug info:', data.debug);
                            }
                            
                            // Check for errors
                            if (data.error) {
                                console.error('Server error:', data.error);
                                if (data.stackTrace) {
                                    console.error('Stack trace:', data.stackTrace);
                                }
                                alert(`Server Error: ${data.error}`);
                                return;
                            }
                            
                            this.incomeData = data.income || [];
                            this.expensesData = data.expenses || [];
                            this.paymentMethods = data.paymentMethods || [];
                            this.summary = data.summary || {
                                totalIncome: 0,
                                totalExpenses: 0,
                                balance: 0,
                                incomeCount: 0,
                                expensesCount: 0
                            };
                            
                            console.log('=== Data Loading Results ===');
                            console.log('Income data loaded:', this.incomeData.length, 'records');
                            console.log('Payment methods loaded:', this.paymentMethods.length, 'methods');
                            console.log('Summary received:', this.summary);
                            console.log('Summary totalIncome:', this.summary.totalIncome, 'type:', typeof this.summary.totalIncome);
                            console.log('Summary incomeCount:', this.summary.incomeCount, 'type:', typeof this.summary.incomeCount);
                            console.log('formatCurrency test:', this.formatCurrency(this.summary.totalIncome));
                        }
                    } catch (error) {
                        console.error('Error loading data:', error);
                        console.error('Error details:', error.response || error.message);
                        // Show user-friendly error
                        alert(this.isArabic ? 
                            `حدث خطأ في تحميل البيانات: ${error.message}` : 
                            `Error loading data: ${error.message}`);
                    } finally {
                        this.loading = false;
                    }
                },
                
                formatCurrency(amount) {
                    return new Intl.NumberFormat(this.isArabic ? 'ar-SA' : 'en-US', {
                        style: 'decimal',
                        minimumFractionDigits: 2,
                        maximumFractionDigits: 2
                    }).format(amount || 0);
                },
                
                formatDate(date) {
                    if (!date) return '';
                    return new Date(date).toLocaleDateString(this.isArabic ? 'ar-SA' : 'en-US');
                },
                
                // Enhanced balance methods
                getBalanceClass() {
                    return this.summary.balance >= 0 ? 'profit-card' : 'loss-card';
                },
                
                getBalanceIcon() {
                    return this.summary.balance >= 0 ? 'fas fa-chart-line' : 'fas fa-chart-line-down';
                },
                
                getBalanceStatus() {
                    if (this.summary.balance > 0) {
                        return this.isArabic ? 'ربح صافي' : 'Net Profit';
                    } else if (this.summary.balance < 0) {
                        return this.isArabic ? 'خسارة صافية' : 'Net Loss';
                    } else {
                        return this.isArabic ? 'متوازن' : 'Balanced';
                    }
                },
                
                // Enhanced computed properties
                paymentMethodsTitle() {
                    return this.isArabic ? 'ملخص طرق الدفع' : 'Payment Methods Summary';
                },
                
                noDataText() {
                    return this.isArabic ? 'لا توجد بيانات للعرض' : 'No data to display';
                },
                
                // ...existing code...
            },
            
            mounted() {
                // Ensure we're in the right DOM context
                this.$nextTick(() => {
                    // Set initial direction
                    document.documentElement.setAttribute('dir', this.isArabic ? 'rtl' : 'ltr');
                    // Load initial data after DOM is ready
                    this.loadData();
                });
            },
            
            // Add error handling for component lifecycle
            errorCaptured(err, instance, info) {
                console.error('Vue Component Error:', err);
                console.error('Instance:', instance);
                console.error('Info:', info);
                return false; // Prevent the error from propagating further
            }
                });
                
                console.log('Vue app initialized successfully');
                
            } catch (error) {
                console.error('Error initializing Vue app:', error);
                // Fallback: show error message to user
                const appContainer = document.getElementById('app');
                if (appContainer) {
                    appContainer.innerHTML = `
                        <div class="alert alert-danger">
                            <h4><i class="fas fa-exclamation-triangle"></i> خطأ في تحميل التطبيق</h4>
                            <p>حدث خطأ في تحميل واجهة المستخدم. يرجى إعادة تحميل الصفحة أو المحاولة لاحقاً.</p>
                            <button class="btn btn-primary" onclick="location.reload()">إعادة تحميل الصفحة</button>
                        </div>
                    `;
                }
            }
        }
    </script>

    <style>
        /* Vue Container Isolation */
        .vue-isolated-container {
            position: relative;
            z-index: 1;
            isolation: isolate;
        }
        
        /* Prevent Master Page interference */
        #vueAppContainer * {
            box-sizing: border-box;
        }
        
        /* Reset any potential conflicts */
        #app {
            font-family: inherit;
            line-height: inherit;
        }
        
        /* RTL/LTR Styles */
        [dir="rtl"] .pull-left { float: right !important; }
        [dir="rtl"] .pull-right { float: left !important; }
        [dir="rtl"] .text-left { text-align: right !important; }
        [dir="rtl"] .text-right { text-align: left !important; }
        
        /* Vue.js specific styles */
        .fade-enter-active, .fade-leave-active {
            transition: opacity 0.3s;
        }
        .fade-enter, .fade-leave-to {
            opacity: 0;
        }
        
        /* Loading states */
        .loading {
            opacity: 0.7;
            pointer-events: none;
        }
        
        /* Responsive improvements */
        @media (max-width: 768px) {
            .col-md-4, .col-md-8, .col-md-12 {
                margin-bottom: 15px;
            }
        }
    </style>
</asp:Content>
