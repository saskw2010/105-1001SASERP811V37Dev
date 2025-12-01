<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="FinancialAnalysisPro.aspx.cs" Inherits="FinancialAnalysisPro" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>التحليل المالي المتقدم - Vue.js Pro</title>
    
    <!-- External Libraries -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@300;400;500;600;700;800&display=swap" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css" rel="stylesheet">

    
    <!-- Enhanced Vue App with Professional AI Design -->
    <div id="vueAppContainer" class="vue-enhanced-container">
        <style>
            /* Professional AI-Style Design - Enhanced */
            .vue-enhanced-container {
                font-family: 'Inter', 'Segoe UI', 'Roboto', sans-serif;
                background: linear-gradient(135deg, #0066FF 0%, #3399FF 25%, #00CCFF 75%, #667eea 100%);
                min-height: 100vh;
                padding: 20px;
                margin: -15px;
                color: #fff;
                position: relative;
                overflow-x: hidden;
            }
            
            .vue-enhanced-container::before {
                content: '';
                position: absolute;
                top: 0;
                left: 0;
                right: 0;
                bottom: 0;
                background: url('data:image/svg+xml,<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 100 100"><defs><pattern id="grid" width="10" height="10" patternUnits="userSpaceOnUse"><path d="M 10 0 L 0 0 0 10" fill="none" stroke="rgba(255,255,255,0.1)" stroke-width="0.5"/></pattern></defs><rect width="100" height="100" fill="url(%23grid)"/></svg>');
                pointer-events: none;
                z-index: 0;
            }
            
            .enhanced-header {
                background: rgba(255, 255, 255, 0.95);
                border-radius: 20px;
                padding: 30px;
                margin-bottom: 30px;
                box-shadow: 0 20px 50px rgba(0, 0, 0, 0.15);
                backdrop-filter: blur(20px);
                border: 1px solid rgba(255, 255, 255, 0.2);
                color: #333;
                position: relative;
                z-index: 1;
            }
            
            .enhanced-title {
                font-size: 2.8rem;
                font-weight: 800;
                background: linear-gradient(45deg, #0066FF, #3399FF, #00CCFF);
                background-clip: text;
                -webkit-background-clip: text;
                -webkit-text-fill-color: transparent;
                margin: 0;
                text-align: center;
                letter-spacing: -1px;
            }
            
            .control-group {
                display: flex;
                justify-content: center;
                align-items: center;
                gap: 20px;
                margin-top: 25px;
                flex-wrap: wrap;
            }
            
            .enhanced-btn {
                background: linear-gradient(45deg, #0066FF, #3399FF);
                border: none;
                color: white;
                padding: 14px 28px;
                border-radius: 30px;
                font-size: 16px;
                font-weight: 600;
                cursor: pointer;
                transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
                box-shadow: 0 8px 25px rgba(0, 102, 255, 0.3);
                position: relative;
                overflow: hidden;
            }
            
            .enhanced-btn::before {
                content: '';
                position: absolute;
                top: 0;
                left: -100%;
                width: 100%;
                height: 100%;
                background: linear-gradient(90deg, transparent, rgba(255,255,255,0.3), transparent);
                transition: left 0.5s;
            }
            
            .enhanced-btn:hover {
                transform: translateY(-3px);
                box-shadow: 0 12px 35px rgba(0, 102, 255, 0.4);
            }
            
            .enhanced-btn:hover::before {
                left: 100%;
            }
            
            .enhanced-select {
                background: rgba(255, 255, 255, 0.95);
                border: 2px solid rgba(0, 102, 255, 0.3);
                border-radius: 15px;
                padding: 14px 20px;
                font-size: 16px;
                font-weight: 600;
                color: #333;
                min-width: 180px;
                outline: none;
                transition: all 0.3s ease;
                backdrop-filter: blur(10px);
            }
            
            .enhanced-select:focus {
                border-color: #0066FF;
                box-shadow: 0 0 20px rgba(0, 102, 255, 0.3);
                transform: scale(1.02);
            }
            
            .checkbox-enhanced {
                background: rgba(255, 255, 255, 0.95);
                padding: 14px 24px;
                border-radius: 15px;
                display: flex;
                align-items: center;
                gap: 12px;
                font-weight: 600;
                color: #333;
                cursor: pointer;
                transition: all 0.3s ease;
                backdrop-filter: blur(10px);
                border: 2px solid rgba(0, 102, 255, 0.2);
            }
            
            .checkbox-enhanced:hover {
                background: rgba(255, 255, 255, 1);
                transform: translateY(-2px);
                box-shadow: 0 8px 25px rgba(0, 102, 255, 0.2);
            }
            
            .stats-grid {
                display: grid;
                grid-template-columns: repeat(auto-fit, minmax(320px, 1fr));
                gap: 25px;
                margin: 30px 0;
                position: relative;
                z-index: 1;
            }
            
            .stat-card {
                background: rgba(255, 255, 255, 0.95);
                border-radius: 24px;
                padding: 32px;
                box-shadow: 0 15px 40px rgba(0, 0, 0, 0.1);
                backdrop-filter: blur(20px);
                border: 1px solid rgba(255, 255, 255, 0.3);
                transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
                color: #333;
                position: relative;
                overflow: hidden;
            }
            
            .stat-card::before {
                content: '';
                position: absolute;
                top: 0;
                left: 0;
                right: 0;
                height: 4px;
                background: linear-gradient(90deg, #0066FF, #3399FF, #00CCFF);
                transform: scaleX(0);
                transition: transform 0.3s ease;
            }
            
            .stat-card:hover {
                transform: translateY(-8px) scale(1.02);
                box-shadow: 0 25px 60px rgba(0, 102, 255, 0.15);
            }
            
            .stat-card:hover::before {
                transform: scaleX(1);
            }
            
            .stat-icon {
                font-size: 3.5rem;
                margin-bottom: 20px;
                display: block;
                text-align: center;
                filter: drop-shadow(0 4px 8px rgba(0,0,0,0.1));
            }
            
            .stat-value {
                font-size: 2.8rem;
                font-weight: 800;
                text-align: center;
                margin: 20px 0;
                letter-spacing: -1px;
            }
            
            .stat-label {
                font-size: 1.3rem;
                font-weight: 600;
                text-align: center;
                opacity: 0.8;
                margin-bottom: 8px;
            }
            
            .stat-count {
                font-size: 1rem;
                text-align: center;
                opacity: 0.6;
                margin-top: 12px;
            }
            
            /* Enhanced color schemes */
            .income-card { 
                border-left: 6px solid #22c55e;
                background: linear-gradient(135deg, rgba(34, 197, 94, 0.05) 0%, rgba(255, 255, 255, 0.95) 100%);
            }
            .income-card .stat-icon { color: #22c55e; }
            .income-card .stat-value { color: #16a34a; }
            
            .expense-card { 
                border-left: 6px solid #ef4444;
                background: linear-gradient(135deg, rgba(239, 68, 68, 0.05) 0%, rgba(255, 255, 255, 0.95) 100%);
            }
            .expense-card .stat-icon { color: #ef4444; }
            .expense-card .stat-value { color: #dc2626; }
            
            .balance-card { 
                border-left: 6px solid #0066FF;
                background: linear-gradient(135deg, rgba(0, 102, 255, 0.05) 0%, rgba(255, 255, 255, 0.95) 100%);
            }
            .balance-card .stat-icon { color: #0066FF; }
            .balance-card .stat-value { color: #0052CC; }
            
            .profit-card { 
                border-left: 6px solid #22c55e;
                background: linear-gradient(135deg, rgba(34, 197, 94, 0.1) 0%, rgba(255, 255, 255, 0.95) 100%);
            }
            .profit-card .stat-icon { color: #22c55e; }
            .profit-card .stat-value { color: #16a34a; }
            
            .loss-card { 
                border-left: 6px solid #ef4444;
                background: linear-gradient(135deg, rgba(239, 68, 68, 0.1) 0%, rgba(255, 255, 255, 0.95) 100%);
            }
            .loss-card .stat-icon { color: #ef4444; }
            .loss-card .stat-value { color: #dc2626; }
            
            .data-section {
                background: rgba(255, 255, 255, 0.95);
                border-radius: 24px;
                padding: 32px;
                margin: 30px 0;
                box-shadow: 0 15px 40px rgba(0, 0, 0, 0.1);
                backdrop-filter: blur(20px);
                border: 1px solid rgba(255, 255, 255, 0.3);
                color: #333;
                position: relative;
                z-index: 1;
            }
            
            .section-title {
                font-size: 2rem;
                font-weight: 700;
                margin-bottom: 30px;
                padding-bottom: 20px;
                border-bottom: 3px solid transparent;
                background: linear-gradient(90deg, #0066FF, #3399FF, #00CCFF) bottom left / 100% 3px no-repeat;
                text-align: center;
            }
            
            .loading-spinner {
                text-align: center;
                padding: 60px;
                position: relative;
                z-index: 1;
            }
            
            .loading-spinner i {
                font-size: 4rem;
                background: linear-gradient(45deg, #0066FF, #3399FF, #00CCFF);
                background-clip: text;
                -webkit-background-clip: text;
                -webkit-text-fill-color: transparent;
                animation: spin 1s linear infinite;
            }
            
            @keyframes spin {
                from { transform: rotate(0deg); }
                to { transform: rotate(360deg); }
            }
            
            .loading-text {
                font-size: 1.4rem;
                margin-top: 20px;
                background: linear-gradient(45deg, #0066FF, #3399FF);
                background-clip: text;
                -webkit-background-clip: text;
                -webkit-text-fill-color: transparent;
                font-weight: 600;
            }
            
            .period-indicator {
                background: linear-gradient(45deg, #22c55e, #16a34a);
                color: white;
                padding: 12px 24px;
                border-radius: 30px;
                font-size: 1.2rem;
                font-weight: 600;
                display: inline-block;
                margin: 20px 0;
                box-shadow: 0 8px 25px rgba(34, 197, 94, 0.3);
            }
            
            /* Dynamic Cards Grid */
            .dynamic-cards-grid {
                display: grid;
                grid-template-columns: repeat(auto-fit, minmax(280px, 1fr));
                gap: 20px;
                margin: 25px 0;
            }
            
            .dynamic-card {
                background: rgba(255, 255, 255, 0.95);
                border-radius: 20px;
                padding: 24px;
                box-shadow: 0 10px 30px rgba(0, 0, 0, 0.08);
                transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
                backdrop-filter: blur(15px);
                border: 1px solid rgba(255, 255, 255, 0.2);
            }
            
            .dynamic-card:hover {
                transform: translateY(-5px);
                box-shadow: 0 20px 50px rgba(0, 102, 255, 0.15);
            }
            
            .card-amount {
                font-size: 1.8rem;
                font-weight: 700;
                margin: 12px 0;
            }
            
            /* Collapsible Sections */
            .collapsible-section {
                margin: 25px 0;
            }
            
            .section-header {
                background: rgba(255, 255, 255, 0.95);
                padding: 20px 30px;
                border-radius: 15px 15px 0 0;
                cursor: pointer;
                transition: all 0.3s ease;
                border-bottom: 1px solid rgba(0, 102, 255, 0.1);
                backdrop-filter: blur(15px);
            }
            
            .section-header:hover {
                background: rgba(255, 255, 255, 1);
                transform: translateY(-2px);
            }
            
            .section-content {
                background: rgba(255, 255, 255, 0.95);
                border-radius: 0 0 15px 15px;
                overflow: hidden;
                transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
                max-height: 0;
                opacity: 0;
                backdrop-filter: blur(15px);
            }
            
            .section-content.expanded {
                max-height: 2000px;
                opacity: 1;
                padding: 25px 30px;
            }
            
            /* RTL Support */
            .rtl-layout {
                direction: rtl;
                text-align: right;
            }
            
            .ltr-layout {
                direction: ltr;
                text-align: left;
            }
            
            /* Responsive Design */
            @media (max-width: 768px) {
                .vue-enhanced-container {
                    padding: 15px;
                    margin: -10px;
                }
                
                .enhanced-header {
                    padding: 20px;
                }
                
                .enhanced-title {
                    font-size: 2.2rem;
                }
                
                .control-group {
                    flex-direction: column;
                    gap: 15px;
                }
                
                .stats-grid {
                    grid-template-columns: 1fr;
                }
                
                .dynamic-cards-grid {
                    grid-template-columns: 1fr;
                }
            }
            
            /* Animation Classes */
            .fade-in {
                animation: fadeIn 0.6s ease-out forwards;
            }
            
            @keyframes fadeIn {
                from {
                    opacity: 0;
                    transform: translateY(20px);
                }
                to {
                    opacity: 1;
                    transform: translateY(0);
                }
            }
            
            @keyframes loading-progress {
                0% { transform: translateX(-100%); }
                50% { transform: translateX(0%); }
                100% { transform: translateX(100%); }
            }
        </style>

        <div id="app" :class="isArabic ? 'rtl-layout' : 'ltr-layout'">
            <!-- Enhanced Header -->
            <div class="enhanced-header fade-in">
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
                    
                    <!-- Data Type Toggle -->
                    <label class="checkbox-enhanced">
                        <input type="checkbox" v-model="isDemo" @change="loadData" />
                        <span>{{ demoText }}</span>
                    </label>
                    
                    <!-- Refresh -->
                    <button @click="loadData" class="enhanced-btn">
                        <i class="fas fa-sync-alt" :class="{ 'fa-spin': loading }"></i>
                        {{ refreshText }}
                    </button>
                    
                    <!-- Debug Mode Toggle -->
                    <button @click="toggleDebugMode" class="enhanced-btn" style="background: linear-gradient(45deg, #f59e0b, #d97706);">
                        <i class="fas fa-bug"></i>
                        {{ isArabic ? 'تشخيص' : 'Debug' }}
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
            <div style="margin-top: 20px;">
                <div style="width: 300px; height: 6px; background: rgba(255,255,255,0.2); border-radius: 3px; margin: 0 auto; overflow: hidden;">
                    <div style="width: 100%; height: 100%; background: linear-gradient(45deg, #0066FF, #00CCFF); animation: loading-progress 2s ease-in-out infinite;"></div>
                </div>
                <p style="margin: 10px 0 0 0; color: rgba(255,255,255,0.7); font-size: 0.9rem;">جاري الاتصال بقاعدة البيانات...</p>
            </div>
        </div>

            <!-- Enhanced Summary Cards -->
            <div class="stats-grid fade-in" v-if="!loading && summary">
                <!-- Income Card -->
                <div class="stat-card income-card">
                    <i class="fas fa-arrow-trend-up stat-icon"></i>
                    <div class="stat-value">{{ formatCurrency(summary.totalIncome) }}</div>
                    <div class="stat-label">{{ incomeLabel }}</div>
                    <div class="stat-count">{{ summary.incomeCount }} {{ transactionText }}</div>
                </div>

                <!-- Expenses Card -->
                <div class="stat-card expense-card">
                    <i class="fas fa-arrow-trend-down stat-icon"></i>
                    <div class="stat-value">{{ formatCurrency(summary.totalExpenses) }}</div>
                    <div class="stat-label">{{ expensesLabel }}</div>
                    <div class="stat-count">{{ summary.expenseCount }} {{ transactionText }}</div>
                </div>

                <!-- Balance Card -->
                <div class="stat-card" :class="getBalanceClass()">
                    <i class="fas" :class="getBalanceIcon()" class="stat-icon"></i>
                    <div class="stat-value">{{ formatCurrency(summary.netBalance) }}</div>
                    <div class="stat-label">{{ balanceLabel }}</div>
                    <div class="stat-count">{{ getBalanceStatus() }}</div>
                </div>
            </div>

            <!-- Income Categories Section -->
            <div v-if="!loading && incomeCategories.length > 0" class="collapsible-section fade-in">
                <div class="section-header" @click="toggleSection('incomeCategories')">
                    <h3 style="margin: 0; display: flex; align-items: center; justify-content: space-between;">
                        <span>
                            <i class="fas fa-coins"></i>
                            {{ incomeCategoriesTitle }}
                        </span>
                        <i class="fas fa-chevron-down" :id="'incomeCategoriesIcon'" style="transition: transform 0.3s ease;"></i>
                    </h3>
                </div>
                <div class="section-content" :id="'incomeCategoriesContent'">
                    <div class="dynamic-cards-grid">
                        <div v-for="(category, index) in incomeCategories" :key="category.category" class="dynamic-card income">
                            <div class="text-center">
                                <div style="font-size: 2.5rem; margin-bottom: 15px;">{{ category.categoryIcon }}</div>
                                <h6 style="font-weight: 600; margin-bottom: 10px;">{{ category.category }}</h6>
                                <div class="card-amount" style="color: #22c55e;">{{ formatCurrency(category.totalAmount) }}</div>
                                <small style="color: #666;">
                                    {{ category.voucherCount }} سند | متوسط: {{ formatCurrency(category.avgAmount) }}
                                </small>
                                <div style="margin-top: 10px;">
                                    <span class="badge" :style="getDataSourceStyle(category.dataSource)">{{ category.dataSource }}</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Payment Methods Analysis Section -->
            <div v-if="!loading && (incomePaymentMethods.length > 0 || expensePaymentMethods.length > 0)" class="collapsible-section fade-in">
                <div class="section-header" @click="toggleSection('paymentMethods')">
                    <h3 style="margin: 0; display: flex; align-items: center; justify-content: space-between;">
                        <span>
                            <i class="fas fa-credit-card"></i>
                            {{ paymentMethodsTitle }}
                        </span>
                        <i class="fas fa-chevron-down" :id="'paymentMethodsIcon'" style="transition: transform 0.3s ease;"></i>
                    </h3>
                </div>
                <div class="section-content" :id="'paymentMethodsContent'">
                    <!-- Income Payment Methods -->
                    <div v-if="incomePaymentMethods.length > 0" style="margin-bottom: 30px;">
                        <h4 style="color: #22c55e; margin-bottom: 20px;">
                            <i class="fas fa-arrow-up"></i>
                            {{ isArabic ? 'طرق دفع الإيرادات' : 'Income Payment Methods' }}
                        </h4>
                        <div class="dynamic-cards-grid">
                            <div v-for="method in incomePaymentMethods" :key="'income-' + method.paymentMethod" class="dynamic-card">
                                <div style="display: flex; justify-content: space-between; align-items: center;">
                                    <div>
                                        <div style="display: flex; align-items: center; margin-bottom: 10px;">
                                            <i :class="getPaymentMethodIcon(method.paymentMethod)" style="margin-left: 8px; color: #22c55e;"></i>
                                            <strong>{{ method.paymentMethod }}</strong>
                                        </div>
                                        <div class="card-amount" style="color: #22c55e;">{{ formatCurrency(method.totalAmount) }}</div>
                                        <small style="color: #666;">
                                            {{ method.transactionCount }} معاملة | {{ method.percentage.toFixed(1) }}%
                                        </small>
                                    </div>
                                    <div style="text-align: center;">
                                        <div :style="getPercentageCircle(method.percentage, '#22c55e')">
                                            {{ method.percentage.toFixed(0) }}%
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <!-- Expense Payment Methods -->
                    <div v-if="expensePaymentMethods.length > 0">
                        <h4 style="color: #ef4444; margin-bottom: 20px;">
                            <i class="fas fa-arrow-down"></i>
                            {{ isArabic ? 'طرق دفع المصروفات' : 'Expense Payment Methods' }}
                        </h4>
                        <div class="dynamic-cards-grid">
                            <div v-for="method in expensePaymentMethods" :key="'expense-' + method.paymentMethod" class="dynamic-card">
                                <div style="display: flex; justify-content: space-between; align-items: center;">
                                    <div>
                                        <div style="display: flex; align-items: center; margin-bottom: 10px;">
                                            <i :class="getPaymentMethodIcon(method.paymentMethod)" style="margin-left: 8px; color: #ef4444;"></i>
                                            <strong>{{ method.paymentMethod }}</strong>
                                        </div>
                                        <div class="card-amount" style="color: #ef4444;">{{ formatCurrency(method.totalAmount) }}</div>
                                        <small style="color: #666;">
                                            {{ method.transactionCount }} معاملة | {{ method.percentage.toFixed(1) }}%
                                        </small>
                                    </div>
                                    <div style="text-align: center;">
                                        <div :style="getPercentageCircle(method.percentage, '#ef4444')">
                                            {{ method.percentage.toFixed(0) }}%
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Detailed Transactions Section -->
            <div v-if="!loading && detailedTransactions.length > 0" class="collapsible-section fade-in">
                <div class="section-header" @click="toggleSection('detailedTransactions')">
                    <h3 style="margin: 0; display: flex; align-items: center; justify-content: space-between;">
                        <span>
                            <i class="fas fa-list-alt"></i>
                            {{ detailedTransactionsTitle }}
                        </span>
                        <i class="fas fa-chevron-down" :id="'detailedTransactionsIcon'" style="transition: transform 0.3s ease;"></i>
                    </h3>
                </div>
                <div class="section-content" :id="'detailedTransactionsContent'">
                    <div style="overflow-x: auto;">
                        <table style="width: 100%; border-collapse: collapse; margin-top: 15px;">
                            <thead>
                                <tr style="background: linear-gradient(45deg, #0066FF, #3399FF); color: white;">
                                    <th style="padding: 15px; text-align: center; border-radius: 8px 0 0 0;">{{ isArabic ? 'النوع' : 'Type' }}</th>
                                    <th style="padding: 15px; text-align: center;">{{ isArabic ? 'رقم السند' : 'Voucher No' }}</th>
                                    <th style="padding: 15px; text-align: center;">{{ isArabic ? 'التاريخ' : 'Date' }}</th>
                                    <th style="padding: 15px; text-align: center;">{{ isArabic ? 'الوصف' : 'Description' }}</th>
                                    <th style="padding: 15px; text-align: center;">{{ isArabic ? 'المبلغ' : 'Amount' }}</th>
                                    <th style="padding: 15px; text-align: center;">{{ isArabic ? 'طريقة الدفع' : 'Payment Method' }}</th>
                                    <th style="padding: 15px; text-align: center; border-radius: 0 8px 0 0;">{{ isArabic ? 'المصدر' : 'Source' }}</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr v-for="(transaction, index) in detailedTransactions" :key="index" 
                                    style="border-bottom: 1px solid #eee; transition: all 0.2s ease;"
                                    @mouseover="$event.target.parentElement.style.backgroundColor = 'rgba(0, 102, 255, 0.05)'"
                                    @mouseout="$event.target.parentElement.style.backgroundColor = ''">
                                    <td style="padding: 15px; text-align: center;">
                                        <span :class="'badge badge-' + (transaction.type === 'income' ? 'success' : 'danger')" 
                                              :style="getBadgeStyle(transaction.type)">
                                            <i :class="'fas fa-arrow-' + (transaction.type === 'income' ? 'up' : 'down')"></i>
                                            {{ transaction.type === 'income' ? (isArabic ? 'إيراد' : 'Income') : (isArabic ? 'مصروف' : 'Expense') }}
                                        </span>
                                    </td>
                                    <td style="padding: 15px; text-align: center; font-weight: 600;">{{ transaction.voucherNo }}</td>
                                    <td style="padding: 15px; text-align: center;">{{ formatDate(transaction.date) }}</td>
                                    <td style="padding: 15px; text-align: center;">{{ transaction.description }}</td>
                                    <td style="padding: 15px; text-align: center; font-weight: 700;" 
                                        :style="{ color: transaction.type === 'income' ? '#22c55e' : '#ef4444' }">
                                        {{ formatCurrency(transaction.amount) }}
                                    </td>
                                    <td style="padding: 15px; text-align: center;">
                                        <i :class="getPaymentMethodIcon(transaction.paymentMethod)" style="margin-left: 8px;"></i>
                                        {{ transaction.paymentMethod }}
                                    </td>
                                    <td style="padding: 15px; text-align: center;">
                                        <span :style="getDataSourceStyle(transaction.dataSource)">{{ transaction.dataSource }}</span>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>

            <!-- Report Info -->
            <div v-if="!loading" class="data-section fade-in">
                <div style="display: flex; justify-content: space-between; align-items: center; flex-wrap: wrap; gap: 15px;">
                    <div>
                        <i class="fas fa-info-circle" style="color: #0066FF; margin-left: 8px;"></i>
                        <strong>{{ reportPeriodLabel }}</strong> {{ currentPeriodText }}
                    </div>
                    <div style="text-align: left;">
                        <span :style="getDataSourceStyle(dataSourceText)" style="padding: 8px 16px; border-radius: 20px; font-weight: 600;">
                            {{ dataSourceText }}
                        </span>
                        <small style="display: block; color: #666; margin-top: 5px;">
                            Lang: {{ isArabic ? 'AR' : 'EN' }} | Vue.js Pro | SP Analytics
                        </small>
                    </div>
                </div>
                
                <!-- Demo Data Warning -->
                <div v-if="isDemo || errorMessage" style="margin-top: 20px; padding: 15px; background: rgba(245, 158, 11, 0.1); border: 1px solid #f59e0b; border-radius: 12px;">
                    <div style="display: flex; align-items: center; gap: 10px;">
                        <i class="fas fa-exclamation-triangle" style="color: #f59e0b; font-size: 1.2rem;"></i>
                        <div>
                            <strong style="color: #92400e;">تنبيه: وضع البيانات التجريبية</strong>
                            <p style="margin: 5px 0 0 0; color: #92400e; font-size: 0.9rem;">
                                {{ errorMessage ? 'تم تحميل البيانات التجريبية بسبب خطأ في الاتصال.' : 'أنت تعرض البيانات التجريبية.' }}
                                للحصول على البيانات الحقيقية، تأكد من اتصال قاعدة البيانات.
                            </p>
                        </div>
                        <button @click="retryConnection" style="background: #f59e0b; color: white; border: none; padding: 8px 12px; border-radius: 8px; cursor: pointer;">
                            <i class="fas fa-redo"></i> إعادة محاولة
                        </button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Vue.js and dependencies -->
    <script src="https://cdn.jsdelivr.net/npm/vue@2.6.14/dist/vue.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js"></script>

    <script>
        // Wait for DOM to be fully loaded
        document.addEventListener('DOMContentLoaded', function() {
            setTimeout(function() {
                if (typeof Vue !== 'undefined' && typeof axios !== 'undefined') {
                    initializeVueApp();
                } else {
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
                    <div style="background: rgba(255,255,255,0.9); padding: 30px; border-radius: 15px; text-align: center; color: #333;">
                        <h4><i class="fas fa-exclamation-triangle" style="color: #f59e0b;"></i> مشكلة في تحميل المكتبات</h4>
                        <p>يبدو أن هناك مشكلة في تحميل Vue.js أو Axios من الإنترنت. يرجى التحقق من الاتصال بالإنترنت.</p>
                        <button onclick="location.reload()" style="background: linear-gradient(45deg, #0066FF, #3399FF); color: white; border: none; padding: 12px 24px; border-radius: 25px; cursor: pointer;">إعادة المحاولة</button>
                    </div>
                `;
            }
        }
        
        function initializeVueApp() {
            if (typeof Vue === 'undefined') {
                console.error('Vue.js not loaded');
                showLibraryError();
                return;
            }
            
            const appContainer = document.getElementById('app');
            if (!appContainer) {
                console.error('Vue app container not found');
                return;
            }
            
            try {
                Vue.config.productionTip = false;
                Vue.config.devtools = false;
                
                Vue.config.errorHandler = function (err, vm, info) {
                    console.error('Vue Error:', err);
                    console.error('Component Info:', info);
                    showVueError(err.message, info);
                };
                
                window.vueApp = new Vue({
                    el: '#app',
                    data: {
                        // Language & UI
                        isArabic: true,
                        loading: false,
                        errorMessage: '',
                        successMessage: '',
                        debugMode: false,
                        
                        // Period selection - Default to 'month'
                        selectedPeriod: 'month',
                        
                        // Data type - Default to real data
                        isDemo: false,
                        
                        // Expanded sections
                        expandedSections: {},
                        
                        // Data
                        summary: null,
                        incomeCategories: [],
                        incomePaymentMethods: [],
                        expensePaymentMethods: [],
                        detailedTransactions: []
                    },
                    computed: {
                        // Texts based on language
                        pageTitle() {
                            return this.isArabic ? 'التحليل المالي المتقدم' : 'Advanced Financial Analysis';
                        },
                        demoText() {
                            return this.isArabic ? 'بيانات تجريبية' : 'Demo Data';
                        },
                        refreshText() {
                            return this.isArabic ? 'تحديث' : 'Refresh';
                        },
                        loadingText() {
                            return this.isArabic ? 'جاري التحميل البيانات المالية...' : 'Loading financial data...';
                        },
                        incomeLabel() {
                            return this.isArabic ? 'إجمالي الإيرادات' : 'Total Income';
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
                        incomeCategoriesTitle() {
                            return this.isArabic ? 'تصنيفات الإيرادات' : 'Income Categories';
                        },
                        paymentMethodsTitle() {
                            return this.isArabic ? 'تحليل طرق الدفع' : 'Payment Methods Analysis';
                        },
                        detailedTransactionsTitle() {
                            return this.isArabic ? 'تفاصيل المعاملات' : 'Detailed Transactions';
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
                        }
                    },
                    methods: {
                        toggleLanguage() {
                            this.isArabic = !this.isArabic;
                            document.documentElement.setAttribute('dir', this.isArabic ? 'rtl' : 'ltr');
                            this.loadData();
                        },
                        
                        async loadData() {
                            this.loading = true;
                            console.log('Loading data with params:', {
                                period: this.selectedPeriod,
                                dataType: this.isDemo ? 'Demo' : 'Real',
                                isArabic: this.isArabic
                            });
                            
                            try {
                                const response = await axios({
                                    method: 'POST',
                                    url: 'FinancialAnalysisPro.aspx/GetAdvancedFinancialData',
                                    data: JSON.stringify({
                                        period: this.selectedPeriod,
                                        dataType: this.isDemo ? 'Demo' : 'Real',
                                        isArabic: this.isArabic
                                    }),
                                    headers: {
                                        'Content-Type': 'application/json; charset=utf-8'
                                    },
                                    timeout: 30000
                                });
                                
                                console.log('Raw response:', response.data);
                                
                                if (response.data && response.data.d) {
                                    const data = JSON.parse(response.data.d);
                                    console.log('Parsed data:', data);
                                    
                                    if (data.error) {
                                        console.error('Server error:', data.error);
                                        this.showErrorMessage(`خطأ من السيرفر: ${data.error}`);
                                        this.loadDemoDataAsFallback();
                                        return;
                                    }
                                    
                                    this.summary = data.summary || null;
                                    this.incomeCategories = data.incomeCategories || [];
                                    this.incomePaymentMethods = data.incomePaymentMethods || [];
                                    this.expensePaymentMethods = data.expensePaymentMethods || [];
                                    this.detailedTransactions = data.detailedTransactions || [];
                                    
                                    console.log('=== Advanced Data Loading Results ===');
                                    console.log('Summary:', this.summary);
                                    console.log('Income categories:', this.incomeCategories.length);
                                    console.log('Payment methods (income):', this.incomePaymentMethods.length);
                                    console.log('Payment methods (expense):', this.expensePaymentMethods.length);
                                    console.log('Detailed transactions:', this.detailedTransactions.length);
                                }
                            } catch (error) {
                                console.error('Error loading data:', error);
                                this.showErrorMessage(`خطأ في الاتصال: ${error.message}`);
                                this.loadDemoDataAsFallback();
                            } finally {
                                this.loading = false;
                            }
                        },
                        
                        loadDemoDataAsFallback() {
                            console.log('Loading demo data as fallback...');
                            this.summary = {
                                totalIncome: 48500.00,
                                totalExpenses: 25500.00,
                                netBalance: 23000.00,
                                incomeCount: 12,
                                expenseCount: 6,
                                profitMargin: 47.4
                            };
                            
                            this.incomeCategories = [
                                { category: "💼 الإيرادات المباشرة", categoryIcon: "💼", totalAmount: 28500.00, voucherCount: 8, avgAmount: 3562.50, dataSource: "تجريبي" },
                                { category: "🛒 إيرادات البيع", categoryIcon: "🛒", totalAmount: 15000.00, voucherCount: 3, avgAmount: 5000.00, dataSource: "تجريبي" },
                                { category: "📌 إيرادات أخرى", categoryIcon: "📌", totalAmount: 5000.00, voucherCount: 1, avgAmount: 5000.00, dataSource: "تجريبي" }
                            ];
                            
                            this.incomePaymentMethods = [
                                { paymentMethod: "تحويل بنكي", totalAmount: 25000.00, transactionCount: 6, percentage: 51.5 },
                                { paymentMethod: "نقداً", totalAmount: 18500.00, transactionCount: 4, percentage: 38.1 },
                                { paymentMethod: "بطاقة ائتمان", totalAmount: 5000.00, transactionCount: 2, percentage: 10.3 }
                            ];
                            
                            this.expensePaymentMethods = [
                                { paymentMethod: "تحويل بنكي", totalAmount: 15000.00, transactionCount: 3, percentage: 58.8 },
                                { paymentMethod: "نقداً", totalAmount: 8500.00, transactionCount: 2, percentage: 33.3 },
                                { paymentMethod: "شيك", totalAmount: 2000.00, transactionCount: 1, percentage: 7.8 }
                            ];
                            
                            this.detailedTransactions = [
                                { type: "income", voucherNo: "IV001", date: new Date(), description: "إيراد خدمات استشارية (تجريبي)", amount: 15000.00, paymentMethod: "تحويل بنكي", category: "💼 الإيرادات المباشرة", dataSource: "تجريبي" },
                                { type: "expense", voucherNo: "EV001", date: new Date(), description: "مصروف رواتب (تجريبي)", amount: 12000.00, paymentMethod: "تحويل بنكي", category: "رواتب", dataSource: "تجريبي" }
                            ];
                        },
                        
                        showErrorMessage(message) {
                            // Create error toast notification
                            const errorToast = document.createElement('div');
                            errorToast.className = 'position-fixed top-0 end-0 p-3';
                            errorToast.style.zIndex = '9999';
                            errorToast.innerHTML = `
                                <div class="toast show" role="alert">
                                    <div class="toast-header bg-danger text-white">
                                        <i class="fas fa-exclamation-triangle me-2"></i>
                                        <strong class="me-auto">خطأ في النظام</strong>
                                        <button type="button" class="btn-close btn-close-white" onclick="this.closest('.position-fixed').remove()"></button>
                                    </div>
                                    <div class="toast-body">
                                        ${message}
                                        <hr>
                                        <small class="text-muted">سيتم تحميل البيانات التجريبية...</small>
                                    </div>
                                </div>
                            `;
                            document.body.appendChild(errorToast);
                            
                            // Auto-remove after 5 seconds
                            setTimeout(() => {
                                if (errorToast.parentElement) {
                                    errorToast.remove();
                                }
                            }, 5000);
                        },
                        
                        formatCurrency(amount) {
                            return new Intl.NumberFormat(this.isArabic ? 'ar-SA' : 'en-US', {
                                style: 'decimal',
                                minimumFractionDigits: 2,
                                maximumFractionDigits: 2
                            }).format(amount || 0) + (this.isArabic ? ' ريال' : '');
                        },
                        
                        formatDate(date) {
                            if (!date) return '';
                            return new Date(date).toLocaleDateString(this.isArabic ? 'ar-SA' : 'en-US');
                        },
                        
                        // Enhanced balance methods
                        getBalanceClass() {
                            if (!this.summary) return 'balance-card';
                            return this.summary.netBalance >= 0 ? 'profit-card' : 'loss-card';
                        },
                        
                        getBalanceIcon() {
                            if (!this.summary) return 'fas fa-chart-line';
                            return this.summary.netBalance >= 0 ? 'fas fa-chart-line' : 'fas fa-chart-line-down';
                        },
                        
                        getBalanceStatus() {
                            if (!this.summary) return '';
                            if (this.summary.netBalance > 0) {
                                return this.isArabic ? 'ربح صافي' : 'Net Profit';
                            } else if (this.summary.netBalance < 0) {
                                return this.isArabic ? 'خسارة صافية' : 'Net Loss';
                            } else {
                                return this.isArabic ? 'متوازن' : 'Balanced';
                            }
                        },
                        
                        getPaymentMethodIcon(method) {
                            const icons = {
                                'نقداً': 'fas fa-money-bill',
                                'بطاقة ائتمان': 'fas fa-credit-card',
                                'تحويل بنكي': 'fas fa-university',
                                'شيك': 'fas fa-file-invoice',
                                'Cash': 'fas fa-money-bill',
                                'Credit Card': 'fas fa-credit-card',
                                'Bank Transfer': 'fas fa-university',
                                'Check': 'fas fa-file-invoice'
                            };
                            return icons[method] || 'fas fa-money-bill';
                        },
                        
                        getDataSourceStyle(dataSource) {
                            const styles = {
                                'حقيقي': 'background: rgba(34, 197, 94, 0.1); color: #22c55e; border: 1px solid #22c55e; padding: 4px 8px; border-radius: 12px; font-size: 0.8rem; font-weight: 600;',
                                'تجريبي': 'background: rgba(0, 102, 255, 0.1); color: #0066FF; border: 1px solid #0066FF; padding: 4px 8px; border-radius: 12px; font-size: 0.8rem; font-weight: 600;',
                                'مختلط': 'background: rgba(245, 158, 11, 0.1); color: #f59e0b; border: 1px solid #f59e0b; padding: 4px 8px; border-radius: 12px; font-size: 0.8rem; font-weight: 600;',
                                'Real': 'background: rgba(34, 197, 94, 0.1); color: #22c55e; border: 1px solid #22c55e; padding: 4px 8px; border-radius: 12px; font-size: 0.8rem; font-weight: 600;',
                                'Demo': 'background: rgba(0, 102, 255, 0.1); color: #0066FF; border: 1px solid #0066FF; padding: 4px 8px; border-radius: 12px; font-size: 0.8rem; font-weight: 600;'
                            };
                            return styles[dataSource] || styles['تجريبي'];
                        },
                        
                        getBadgeStyle(type) {
                            return type === 'income' ? 
                                'background: rgba(34, 197, 94, 0.1); color: #22c55e; border: 1px solid #22c55e; padding: 6px 12px; border-radius: 20px; font-size: 0.8rem; font-weight: 600;' :
                                'background: rgba(239, 68, 68, 0.1); color: #ef4444; border: 1px solid #ef4444; padding: 6px 12px; border-radius: 20px; font-size: 0.8rem; font-weight: 600;';
                        },
                        
                        getPercentageCircle(percentage, color) {
                            return `width: 60px; height: 60px; border-radius: 50%; background: conic-gradient(from 0deg, ${color} 0deg, ${color} ${percentage * 3.6}deg, #f0f0f0 ${percentage * 3.6}deg); display: flex; align-items: center; justify-content: center; font-weight: bold; color: white; font-size: 0.9em;`;
                        },
                        
                        toggleSection(sectionName) {
                            const content = document.getElementById(sectionName + 'Content');
                            const icon = document.getElementById(sectionName + 'Icon');
                            
                            this.expandedSections[sectionName] = !this.expandedSections[sectionName];
                            
                            if (this.expandedSections[sectionName]) {
                                content.classList.add('expanded');
                                icon.style.transform = 'rotate(180deg)';
                            } else {
                                content.classList.remove('expanded');
                                icon.style.transform = 'rotate(0deg)';
                            }
                        },
                        
                        clearError() {
                            this.errorMessage = '';
                        },
                        
                        clearSuccess() {
                            this.successMessage = '';
                        },
                        
                        retryConnection() {
                            this.errorMessage = '';
                            this.successMessage = '';
                            this.loadData();
                        },
                        
                        toggleDebugMode() {
                            this.debugMode = !this.debugMode;
                            if (this.debugMode) {
                                this.showDebugInfo();
                            }
                        },
                        
                        showDebugInfo() {
                            const debugData = {
                                timestamp: new Date().toISOString(),
                                userAgent: navigator.userAgent,
                                screenSize: `${window.innerWidth}x${window.innerHeight}`,
                                pageUrl: window.location.href,
                                libraries: {
                                    vue: typeof Vue !== 'undefined' ? Vue.version : 'غير متوفر',
                                    axios: typeof axios !== 'undefined' ? 'متوفر' : 'غير متوفر',
                                    bootstrap: typeof bootstrap !== 'undefined' ? 'متوفر' : 'غير متوفر'
                                },
                                appState: {
                                    period: this.selectedPeriod,
                                    dataType: this.isDemo ? 'Demo' : 'Real',
                                    language: this.isArabic ? 'Arabic' : 'English',
                                    loading: this.loading,
                                    hasData: {
                                        summary: !!this.summary,
                                        incomeCategories: this.incomeCategories.length,
                                        paymentMethods: this.incomePaymentMethods.length + this.expensePaymentMethods.length,
                                        transactions: this.detailedTransactions.length
                                    }
                                },
                                lastError: this.errorMessage,
                                lastSuccess: this.successMessage
                            };
                            
                            console.log('=== DEBUG INFO ===', debugData);
                            alert('تم عرض معلومات التشخيص في الـ Console. اضغط F12 لرؤيتها.');
                        }
                    },
                    
                    mounted() {
                        this.$nextTick(() => {
                            document.documentElement.setAttribute('dir', this.isArabic ? 'rtl' : 'ltr');
                            this.loadData();
                        });
                    },
                    
                    errorCaptured(err, instance, info) {
                        console.error('Vue Component Error:', err);
                        console.error('Error Info:', info);
                        this.showErrorMessage(`خطأ في المكون: ${err.message}`);
                        return false;
                    }
                });
                
                console.log('Vue Pro app initialized successfully');
                
            } catch (error) {
                console.error('Error initializing Vue app:', error);
                showVueError(error.message, 'App Initialization');
            }
        }
        
        function showVueError(message, info) {
            const appContainer = document.getElementById('app');
            if (appContainer) {
                appContainer.innerHTML = `
                    <div style="background: rgba(255,255,255,0.9); padding: 30px; border-radius: 15px; text-align: center; color: #333; margin: 20px;">
                        <h4><i class="fas fa-exclamation-triangle" style="color: #ef4444;"></i> خطأ في تحميل التطبيق</h4>
                        <p><strong>رسالة الخطأ:</strong> ${message}</p>
                        <p><strong>تفاصيل:</strong> ${info || 'غير متوفر'}</p>
                        <hr>
                        <p>الصفحة ستعمل بوضع البيانات التجريبية فقط.</p>
                        <button onclick="location.reload()" style="background: linear-gradient(45deg, #0066FF, #3399FF); color: white; border: none; padding: 12px 24px; border-radius: 25px; cursor: pointer; margin: 5px;">إعادة تحميل الصفحة</button>
                        <button onclick="loadFallbackMode()" style="background: linear-gradient(45deg, #22c55e, #16a34a); color: white; border: none; padding: 12px 24px; border-radius: 25px; cursor: pointer; margin: 5px;">تحميل البيانات التجريبية</button>
                    </div>
                `;
            }
        }
        
        function loadFallbackMode() {
            // Simple fallback mode without Vue
            const appContainer = document.getElementById('app');
            if (appContainer) {
                appContainer.innerHTML = `
                    <div style="background: rgba(255,255,255,0.9); padding: 30px; border-radius: 15px; color: #333; margin: 20px;">
                        <h2 style="text-align: center; color: #0066FF; margin-bottom: 30px;">
                            <i class="fas fa-chart-line"></i> التحليل المالي - وضع الطوارئ
                        </h2>
                        
                        <div style="display: grid; grid-template-columns: repeat(auto-fit, minmax(250px, 1fr)); gap: 20px; margin: 30px 0;">
                            <div style="background: #f8f9fa; padding: 20px; border-radius: 10px; text-align: center; border-left: 4px solid #22c55e;">
                                <h4 style="color: #22c55e; margin-bottom: 10px;">💰 إجمالي الإيرادات</h4>
                                <div style="font-size: 2em; font-weight: bold; color: #16a34a;">48,500 ريال</div>
                                <small style="color: #666;">12 معاملة</small>
                            </div>
                            
                            <div style="background: #f8f9fa; padding: 20px; border-radius: 10px; text-align: center; border-left: 4px solid #ef4444;">
                                <h4 style="color: #ef4444; margin-bottom: 10px;">💸 إجمالي المصروفات</h4>
                                <div style="font-size: 2em; font-weight: bold; color: #dc2626;">25,500 ريال</div>
                                <small style="color: #666;">6 معاملات</small>
                            </div>
                            
                            <div style="background: #f8f9fa; padding: 20px; border-radius: 10px; text-align: center; border-left: 4px solid #0066FF;">
                                <h4 style="color: #0066FF; margin-bottom: 10px;">📈 صافي الربح</h4>
                                <div style="font-size: 2em; font-weight: bold; color: #0052CC;">23,000 ريال</div>
                                <small style="color: #666;">47.4% هامش ربح</small>
                            </div>
                        </div>
                        
                        <div style="background: #e7f3ff; padding: 20px; border-radius: 10px; margin: 20px 0; border: 1px solid #0066FF;">
                            <h5 style="color: #0066FF; margin-bottom: 15px;">📋 أهم فئات الإيرادات:</h5>
                            <ul style="margin: 0; padding-right: 20px;">
                                <li style="margin: 8px 0; color: #333;">💼 الإيرادات المباشرة: 28,500 ريال (8 سندات)</li>
                                <li style="margin: 8px 0; color: #333;">🛒 إيرادات البيع: 15,000 ريال (3 سندات)</li>
                                <li style="margin: 8px 0; color: #333;">📌 إيرادات أخرى: 5,000 ريال (1 سند)</li>
                            </ul>
                        </div>
                        
                        <div style="text-align: center; margin-top: 30px; padding: 20px; background: #fef3c7; border-radius: 10px; border: 1px solid #f59e0b;">
                            <p style="color: #92400e; margin: 0;"><i class="fas fa-info-circle"></i> البيانات المعروضة تجريبية - للحصول على البيانات الحقيقية، يرجى إصلاح اتصال قاعدة البيانات.</p>
                        </div>
                    </div>
                `;
            }
        }
    </script>



    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@300;400;500;600;700;800&display=swap" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" rel="stylesheet">
    <style>
        :root {
            --primary-blue: #0066FF;
            --secondary-blue: #3399FF;
            --accent-cyan: #00CCFF;
            --success-green: #00D4AA;
            --warning-orange: #FFB74D;
            --danger-red: #FF6B6B;
            --income-gradient: linear-gradient(135deg, #00D4AA, #00CCFF);
            --expense-gradient: linear-gradient(135deg, #FF6B6B, #FFB74D);
            --mixed-gradient: linear-gradient(135deg, #9C27B0, #3F51B5);
        }
        
        body { 
            font-family: 'Inter', sans-serif;
            background: linear-gradient(135deg, var(--primary-blue) 0%, var(--secondary-blue) 100%); 
            min-height: 100vh; 
        }
        
        .container-fluid { margin-top: 20px; }
        
        /* 📊 Control Panel */
        .control-panel {
            background: rgba(255, 255, 255, 0.95);
            border-radius: 20px;
            padding: 25px;
            margin-bottom: 30px;
            box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
            backdrop-filter: blur(10px);
        }
        
        /* 🎯 Data Type Tabs */
        .data-type-tabs {
            background: rgba(255, 255, 255, 0.1);
            border-radius: 15px;
            padding: 8px;
            backdrop-filter: blur(10px);
        }
        
        .data-type-tabs .nav-link {
            border: none;
            color: white;
            border-radius: 12px;
            margin: 0 3px;
            font-weight: 600;
            transition: all 0.3s ease;
            background: transparent;
            position: relative;
        }
        
        .data-type-tabs .nav-link:hover {
            background: rgba(255, 255, 255, 0.2);
            color: white;
            transform: translateY(-2px);
        }
        
        .data-type-tabs .nav-link.active {
            background: white;
            color: var(--primary-blue);
            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.2);
        }
        
        /* 💰 Summary Cards */
        .summary-section {
            margin-bottom: 30px;
        }
        
        .summary-card {
            background: rgba(255, 255, 255, 0.95);
            border-radius: 20px;
            padding: 25px;
            margin-bottom: 20px;
            box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
            transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
            backdrop-filter: blur(10px);
            position: relative;
            overflow: hidden;
        }
        
        .summary-card::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            height: 5px;
            background: var(--income-gradient);
        }
        
        .summary-card.expense::before {
            background: var(--expense-gradient);
        }
        
        .summary-card:hover {
            transform: translateY(-8px) scale(1.02);
            box-shadow: 0 25px 50px rgba(0, 0, 0, 0.2);
        }
        
        .summary-amount {
            font-size: 2.5em;
            font-weight: 800;
            margin: 15px 0;
        }
        
        .income-amount { color: var(--success-green); }
        .expense-amount { color: var(--danger-red); }
        .profit-amount { color: var(--primary-blue); }
        
        /* 🎴 Category & Payment Method Cards */
        .dynamic-cards {
            margin-bottom: 30px;
        }
        
        .dynamic-card {
            background: rgba(255, 255, 255, 0.95);
            border-radius: 15px;
            padding: 20px;
            margin-bottom: 15px;
            box-shadow: 0 10px 25px rgba(0, 0, 0, 0.1);
            transition: all 0.3s ease;
            border-left: 4px solid var(--primary-blue);
        }
        
        .dynamic-card:hover {
            transform: translateY(-3px);
            box-shadow: 0 15px 35px rgba(0, 0, 0, 0.15);
        }
        
        .dynamic-card.income { border-left-color: var(--success-green); }
        .dynamic-card.expense { border-left-color: var(--danger-red); }
        
        .card-icon {
            font-size: 2em;
            margin-bottom: 10px;
        }
        
        .card-amount {
            font-size: 1.5em;
            font-weight: 700;
        }
        
        /* 🔽 Collapsible Sections */
        .collapsible-section {
            background: rgba(255, 255, 255, 0.95);
            border-radius: 20px;
            margin-bottom: 30px;
            overflow: hidden;
            box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
            backdrop-filter: blur(10px);
        }
        
        .section-header {
            background: var(--income-gradient);
            color: white;
            padding: 20px;
            cursor: pointer;
            transition: all 0.3s ease;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }
        
        .section-header.expense {
            background: var(--expense-gradient);
        }
        
        .section-header:hover {
            filter: brightness(1.1);
        }
        
        .section-content {
            max-height: 0;
            overflow: hidden;
            transition: max-height 0.6s cubic-bezier(0.4, 0, 0.2, 1);
        }
        
        .section-content.expanded {
            max-height: 1200px;
        }
        
        .section-body {
            padding: 25px;
        }
        
        /* 📊 Loading & Animations */
        .loading {
            text-align: center;
            padding: 60px;
            color: white;
        }
        
        .loading i {
            animation: spin 2s linear infinite;
        }
        
        @keyframes spin {
            0% { transform: rotate(0deg); }
            100% { transform: rotate(360deg); }
        }
        
        .fade-in {
            animation: fadeIn 0.8s ease forwards;
            opacity: 0;
        }
        
        @keyframes fadeIn {
            to { opacity: 1; }
        }
        
        /* 📱 Responsive */
        @media (max-width: 768px) {
            .summary-amount { font-size: 2em; }
            .card-amount { font-size: 1.3em; }
            .section-body { padding: 15px; }
        }
        
        /* 🏷️ Badges & Status */
        .status-badge {
            padding: 5px 12px;
            border-radius: 20px;
            font-size: 0.85em;
            font-weight: 600;
        }
        
        .status-real { background: var(--success-green); color: white; }
        .status-demo { background: var(--warning-orange); color: white; }
        .status-mixed { background: var(--mixed-gradient); color: white; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <!-- 🎯 Header & Controls -->
            <div class="row">
                <div class="col-12">
                    <div class="text-center text-white mb-4">
                        <h1><i class="fas fa-chart-line"></i> التحليل المالي المتقدم</h1>
                        <p class="lead">تحليل شامل للإيرادات والمصروفات مع طرق الدفع</p>
                    </div>
                    
                    <!-- Data Type Control -->
                    <ul class="nav data-type-tabs justify-content-center mb-4" role="tablist">
                        <li class="nav-item" role="presentation">
                            <button class="nav-link active" id="real-tab" onclick="switchDataType('real')">
                                <i class="fas fa-database"></i> البيانات الحقيقية
                            </button>
                        </li>
                        <li class="nav-item" role="presentation">
                            <button class="nav-link" id="demo-tab" onclick="switchDataType('demo')">
                                <i class="fas fa-play-circle"></i> البيانات التجريبية
                            </button>
                        </li>
                        <li class="nav-item" role="presentation">
                            <button class="nav-link" id="mixed-tab" onclick="switchDataType('mixed')">
                                <i class="fas fa-layer-group"></i> البيانات المختلطة
                            </button>
                        </li>
                        <li class="nav-item" role="presentation">
                            <button class="nav-link" onclick="refreshData()">
                                <i class="fas fa-refresh"></i> تحديث
                            </button>
                        </li>
                    </ul>
                </div>
            </div>
            
            <!-- 🔄 Loading -->
            <div id="loading" class="loading" style="display: none;">
                <i class="fas fa-chart-pie fa-spin fa-3x"></i><br>
                <h4 style="margin-top: 20px;">جارٍ تحليل البيانات المالية...</h4>
                <div class="progress mt-3" style="height: 8px; max-width: 400px; margin: 0 auto;">
                    <div class="progress-bar progress-bar-striped progress-bar-animated" 
                         style="width: 100%; background: var(--income-gradient);"></div>
                </div>
            </div>
            
            <!-- 💰 Financial Summary -->
            <div id="summarySection" class="summary-section fade-in" style="display: none;">
                <div class="row">
                    <div class="col-md-4">
                        <div class="summary-card">
                            <div class="text-center">
                                <i class="fas fa-arrow-up fa-2x text-success"></i>
                                <h5>إجمالي الإيرادات</h5>
                                <div class="summary-amount income-amount" id="totalIncome">0 ريال</div>
                                <small class="text-muted">عدد السندات: <span id="incomeCount">0</span></small>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="summary-card expense">
                            <div class="text-center">
                                <i class="fas fa-arrow-down fa-2x text-danger"></i>
                                <h5>إجمالي المصروفات</h5>
                                <div class="summary-amount expense-amount" id="totalExpense">0 ريال</div>
                                <small class="text-muted">عدد السندات: <span id="expenseCount">0</span></small>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="summary-card">
                            <div class="text-center">
                                <i class="fas fa-chart-line fa-2x text-primary"></i>
                                <h5>صافي الربح</h5>
                                <div class="summary-amount profit-amount" id="netProfit">0 ريال</div>
                                <small class="text-muted">نسبة الربح: <span id="profitMargin">0%</span></small>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
            <!-- 🎴 Income Categories Section -->
            <div id="incomeCategoriesSection" class="collapsible-section fade-in" style="display: none;">
                <div class="section-header" onclick="toggleSection('incomeCategories')">
                    <div>
                        <h5><i class="fas fa-coins"></i> تصنيفات الإيرادات</h5>
                        <small>تحليل مفصل لأنواع الإيرادات</small>
                    </div>
                    <i id="incomeCategoriesIcon" class="fas fa-chevron-down" style="transition: transform 0.3s ease;"></i>
                </div>
                <div id="incomeCategoriesContent" class="section-content">
                    <div class="section-body">
                        <div id="incomeCategoriesCards" class="row"></div>
                    </div>
                </div>
            </div>
            
            <!-- 💳 Payment Methods Analysis -->
            <div id="paymentMethodsSection" class="collapsible-section fade-in" style="display: none;">
                <div class="section-header" onclick="toggleSection('paymentMethods')">
                    <div>
                        <h5><i class="fas fa-credit-card"></i> تحليل طرق الدفع</h5>
                        <small>تحليل شامل لطرق الدفع في الإيرادات والمصروفات</small>
                    </div>
                    <i id="paymentMethodsIcon" class="fas fa-chevron-down" style="transition: transform 0.3s ease;"></i>
                </div>
                <div id="paymentMethodsContent" class="section-content">
                    <div class="section-body">
                        <div class="row">
                            <div class="col-md-6">
                                <h6 class="text-success mb-3"><i class="fas fa-arrow-up"></i> طرق دفع الإيرادات</h6>
                                <div id="incomePaymentMethods" class="dynamic-cards"></div>
                            </div>
                            <div class="col-md-6">
                                <h6 class="text-danger mb-3"><i class="fas fa-arrow-down"></i> طرق دفع المصروفات</h6>
                                <div id="expensePaymentMethods" class="dynamic-cards"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            
            <!-- 📊 Detailed Analysis -->
            <div id="detailedSection" class="collapsible-section fade-in" style="display: none;">
                <div class="section-header" onclick="toggleSection('detailed')">
                    <div>
                        <h5><i class="fas fa-table"></i> التحليل التفصيلي</h5>
                        <small>جميع الحركات مع التفاصيل الكاملة</small>
                    </div>
                    <i id="detailedIcon" class="fas fa-chevron-down" style="transition: transform 0.3s ease;"></i>
                </div>
                <div id="detailedContent" class="section-content">
                    <div class="section-body">
                        <div class="table-responsive">
                            <table class="table table-hover">
                                <thead class="table-primary">
                                    <tr>
                                        <th><i class="fas fa-tag"></i> النوع</th>
                                        <th><i class="fas fa-receipt"></i> رقم السند</th>
                                        <th><i class="fas fa-calendar"></i> التاريخ</th>
                                        <th><i class="fas fa-info-circle"></i> الوصف</th>
                                        <th><i class="fas fa-money-bill"></i> المبلغ</th>
                                        <th><i class="fas fa-credit-card"></i> طريقة الدفع</th>
                                        <th><i class="fas fa-source"></i> المصدر</th>
                                    </tr>
                                </thead>
                                <tbody id="detailedTableBody"></tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/js/bootstrap.bundle.min.js"></script>
    <script>
        let currentDataType = 'real';
        let expandedSections = {};
        
        function showLoading() {
            document.getElementById('loading').style.display = 'block';
            hideAllSections();
        }
        
        function hideLoading() {
            document.getElementById('loading').style.display = 'none';
        }
        
        function hideAllSections() {
            ['summarySection', 'incomeCategoriesSection', 'paymentMethodsSection', 'detailedSection'].forEach(id => {
                document.getElementById(id).style.display = 'none';
            });
        }
        
        function switchDataType(type) {
            currentDataType = type;
            
            // Update active tab
            document.querySelectorAll('.data-type-tabs .nav-link').forEach(tab => {
                tab.classList.remove('active');
            });
            document.getElementById(type + '-tab').classList.add('active');
            
            // Smooth transition
            hideAllSections();
            setTimeout(() => {
                loadFinancialData();
            }, 300);
        }
        
        function refreshData() {
            loadFinancialData();
        }
        
        function loadFinancialData() {
            showLoading();
            
            const useDemo = currentDataType === 'demo';
            const useMixed = currentDataType === 'mixed';
            
            Promise.all([
                loadSummaryData(useDemo, useMixed),
                loadIncomeCategories(useDemo, useMixed),
                loadPaymentMethodsAnalysis(useDemo, useMixed),
                loadDetailedData(useDemo, useMixed)
            ]).then(() => {
                hideLoading();
                showAllSections();
            }).catch(error => {
                hideLoading();
                showError('خطأ في تحميل البيانات: ' + error.message);
            });
        }
        
        function loadSummaryData(useDemo, useMixed) {
            return fetch('FinancialAnalysisPro.aspx/GetFinancialSummary', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    startDate: getStartDate(),
                    endDate: getEndDate(),
                    useDemo: useDemo,
                    useMixed: useMixed
                })
            })
            .then(response => response.json())
            .then(data => {
                if (data.d && data.d.success) {
                    displaySummary(data.d.data);
                } else {
                    throw new Error(data.d ? data.d.error : 'فشل في تحميل الملخص');
                }
            });
        }
        
        function loadIncomeCategories(useDemo, useMixed) {
            return fetch('FinancialAnalysisPro.aspx/GetIncomeCategories', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    startDate: getStartDate(),
                    endDate: getEndDate(),
                    useDemo: useDemo,
                    useMixed: useMixed
                })
            })
            .then(response => response.json())
            .then(data => {
                if (data.d && data.d.success) {
                    displayIncomeCategories(data.d.data);
                }
            });
        }
        
        function loadPaymentMethodsAnalysis(useDemo, useMixed) {
            return fetch('FinancialAnalysisPro.aspx/GetPaymentMethodsAnalysis', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    startDate: getStartDate(),
                    endDate: getEndDate(),
                    useDemo: useDemo,
                    useMixed: useMixed
                })
            })
            .then(response => response.json())
            .then(data => {
                if (data.d && data.d.success) {
                    displayPaymentMethods(data.d.data);
                }
            });
        }
        
        function loadDetailedData(useDemo, useMixed) {
            return fetch('FinancialAnalysisPro.aspx/GetDetailedTransactions', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({
                    startDate: getStartDate(),
                    endDate: getEndDate(),
                    useDemo: useDemo,
                    useMixed: useMixed
                })
            })
            .then(response => response.json())
            .then(data => {
                if (data.d && data.d.success) {
                    displayDetailedData(data.d.data);
                }
            });
        }
        
        function displaySummary(summary) {
            document.getElementById('totalIncome').textContent = summary.totalIncome.toLocaleString('ar-SA') + ' ريال';
            document.getElementById('totalExpense').textContent = summary.totalExpense.toLocaleString('ar-SA') + ' ريال';
            document.getElementById('netProfit').textContent = summary.netProfit.toLocaleString('ar-SA') + ' ريال';
            document.getElementById('incomeCount').textContent = summary.incomeCount;
            document.getElementById('expenseCount').textContent = summary.expenseCount;
            document.getElementById('profitMargin').textContent = summary.profitMargin.toFixed(1) + '%';
        }
        
        function displayIncomeCategories(categories) {
            const container = document.getElementById('incomeCategoriesCards');
            container.innerHTML = '';
            
            categories.forEach((cat, index) => {
                const cardHtml = `
                    <div class="col-md-4">
                        <div class="dynamic-card income fade-in" style="animation-delay: ${index * 0.1}s;">
                            <div class="text-center">
                                <div class="card-icon">${cat.categoryIcon}</div>
                                <h6>${cat.categoryName}</h6>
                                <div class="card-amount text-success">${cat.totalAmount.toLocaleString('ar-SA')} ريال</div>
                                <small class="text-muted">
                                    ${cat.voucherCount} سند | متوسط: ${cat.avgAmount.toFixed(0)} ريال
                                </small>
                                <div class="mt-2">
                                    <span class="status-badge ${getDataStatusClass(cat.dataSource)}">${cat.dataSource}</span>
                                </div>
                            </div>
                        </div>
                    </div>
                `;
                container.innerHTML += cardHtml;
            });
        }
        
        function displayPaymentMethods(paymentData) {
            displayPaymentMethodCards('incomePaymentMethods', paymentData.income, 'income');
            displayPaymentMethodCards('expensePaymentMethods', paymentData.expenses, 'expense');
        }
        
        function displayPaymentMethodCards(containerId, methods, type) {
            const container = document.getElementById(containerId);
            container.innerHTML = '';
            
            methods.forEach((method, index) => {
                const cardHtml = `
                    <div class="dynamic-card ${type} fade-in" style="animation-delay: ${index * 0.1}s;">
                        <div class="d-flex justify-content-between align-items-center">
                            <div>
                                <div class="d-flex align-items-center mb-2">
                                    <i class="${getPaymentMethodIcon(method.paymentMethod)} me-2"></i>
                                    <strong>${method.paymentMethod}</strong>
                                </div>
                                <div class="card-amount ${type === 'income' ? 'text-success' : 'text-danger'}">
                                    ${method.totalAmount.toLocaleString('ar-SA')} ريال
                                </div>
                                <small class="text-muted">
                                    ${method.transactionCount} معاملة | ${method.percentage.toFixed(1)}%
                                </small>
                            </div>
                            <div class="text-end">
                                <div style="width: 60px; height: 60px; border-radius: 50%; background: conic-gradient(from 0deg, var(--${type === 'income' ? 'success-green' : 'danger-red'}) 0deg, var(--${type === 'income' ? 'success-green' : 'danger-red'}) ${method.percentage * 3.6}deg, #f0f0f0 ${method.percentage * 3.6}deg); display: flex; align-items: center; justify-content: center; font-weight: bold; color: white; font-size: 0.9em;">
                                    ${method.percentage.toFixed(0)}%
                                </div>
                            </div>
                        </div>
                    </div>
                `;
                container.innerHTML += cardHtml;
            });
        }
        
        function displayDetailedData(transactions) {
            const tbody = document.getElementById('detailedTableBody');
            tbody.innerHTML = '';
            
            transactions.forEach((transaction, index) => {
                const typeClass = transaction.type === 'income' ? 'success' : 'danger';
                const typeIcon = transaction.type === 'income' ? 'arrow-up' : 'arrow-down';
                
                const row = `
                    <tr style="animation: slideInUp 0.5s ease forwards; animation-delay: ${index * 0.02}s; opacity: 0;">
                        <td>
                            <span class="badge bg-${typeClass}">
                                <i class="fas fa-${typeIcon}"></i> ${transaction.type === 'income' ? 'إيراد' : 'مصروف'}
                            </span>
                        </td>
                        <td><strong>${transaction.voucherNo}</strong></td>
                        <td>${new Date(transaction.date).toLocaleDateString('ar-SA')}</td>
                        <td>${transaction.description}</td>
                        <td><strong class="text-${typeClass}">${transaction.amount.toLocaleString('ar-SA')} ريال</strong></td>
                        <td>
                            <i class="${getPaymentMethodIcon(transaction.paymentMethod)} me-1"></i>
                            ${transaction.paymentMethod}
                        </td>
                        <td>
                            <span class="status-badge ${getDataStatusClass(transaction.dataSource)}">${transaction.dataSource}</span>
                        </td>
                    </tr>
                `;
                tbody.innerHTML += row;
            });
        }
        
        function toggleSection(sectionName) {
            const content = document.getElementById(sectionName + 'Content');
            const icon = document.getElementById(sectionName + 'Icon');
            
            expandedSections[sectionName] = !expandedSections[sectionName];
            
            if (expandedSections[sectionName]) {
                content.classList.add('expanded');
                icon.style.transform = 'rotate(180deg)';
            } else {
                content.classList.remove('expanded');
                icon.style.transform = 'rotate(0deg)';
            }
        }
        
        function showAllSections() {
            setTimeout(() => {
                document.getElementById('summarySection').style.display = 'block';
                document.getElementById('summarySection').classList.add('fade-in');
            }, 200);
            
            setTimeout(() => {
                document.getElementById('incomeCategoriesSection').style.display = 'block';
                document.getElementById('incomeCategoriesSection').classList.add('fade-in');
            }, 400);
            
            setTimeout(() => {
                document.getElementById('paymentMethodsSection').style.display = 'block';
                document.getElementById('paymentMethodsSection').classList.add('fade-in');
            }, 600);
            
            setTimeout(() => {
                document.getElementById('detailedSection').style.display = 'block';
                document.getElementById('detailedSection').classList.add('fade-in');
            }, 800);
        }
        
        function getPaymentMethodIcon(method) {
            const icons = {
                'نقداً': 'fas fa-money-bill',
                'بطاقة ائتمان': 'fas fa-credit-card',
                'تحويل بنكي': 'fas fa-university',
                'شيك': 'fas fa-file-invoice',
                'Cash': 'fas fa-money-bill',
                'Credit Card': 'fas fa-credit-card',
                'Bank Transfer': 'fas fa-university',
                'Check': 'fas fa-file-invoice'
            };
            return icons[method] || 'fas fa-money-bill';
        }
        
        function getDataStatusClass(dataSource) {
            const classes = {
                'حقيقي': 'status-real',
                'تجريبي': 'status-demo',
                'مختلط': 'status-mixed',
                'Real': 'status-real',
                'Demo': 'status-demo',
                'Mixed': 'status-mixed'
            };
            return classes[dataSource] || 'status-demo';
        }
        
        function showError(message) {
            const errorDiv = document.createElement('div');
            errorDiv.className = 'alert alert-danger alert-dismissible fade show position-fixed';
            errorDiv.style.cssText = 'top: 20px; right: 20px; z-index: 9999; min-width: 350px;';
            errorDiv.innerHTML = `
                <i class="fas fa-exclamation-triangle me-2"></i>
                ${message}
                <button type="button" class="btn-close" onclick="this.parentElement.remove()"></button>
            `;
            document.body.appendChild(errorDiv);
            
            setTimeout(() => {
                if (errorDiv.parentElement) errorDiv.remove();
            }, 7000);
        }
        
        function getStartDate() {
            const today = new Date();
            const firstDay = new Date(today.getFullYear(), today.getMonth(), 1);
            return firstDay.toISOString().split('T')[0];
        }
        
        function getEndDate() {
            const today = new Date();
            return today.toISOString().split('T')[0];
        }
        
        // Add CSS animations
        const style = document.createElement('style');
        style.textContent = `
            @keyframes slideInUp {
                from { opacity: 0; transform: translateY(20px); }
                to { opacity: 1; transform: translateY(0); }
            }
        `;
        document.head.appendChild(style);
        
        // Auto-load real data on page ready
        document.addEventListener('DOMContentLoaded', function() {
            setTimeout(() => loadFinancialData(), 1000);
        });
    </script>
</body>
</html>
