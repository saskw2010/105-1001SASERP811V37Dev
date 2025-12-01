<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FinancialAnalysisProFixed.aspx.cs" Inherits="FinancialAnalysisProFixed" %>

<!DOCTYPE html>
<html lang="ar" dir="rtl">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>التحليل المالي المتقدم - Vue.js Pro</title>
    
    <!-- External Libraries -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@300;400;500;600;700;800&display=swap" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css" rel="stylesheet">
    
    <style>
        :root {
            --primary-blue: #0066FF;
            --secondary-blue: #3399FF;
            --accent-cyan: #00CCFF;
            --success-green: #00D4AA;
            --warning-orange: #FFB74D;
            --danger-red: #FF6B6B;
        }
        
        /* Professional AI-Style Design - Enhanced */
        .vue-enhanced-container {
            font-family: 'Inter', 'Segoe UI', 'Roboto', sans-serif;
            background: linear-gradient(135deg, #0066FF 0%, #3399FF 25%, #00CCFF 75%, #667eea 100%);
            min-height: 100vh;
            padding: 20px;
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
        
        .enhanced-btn:hover {
            transform: translateY(-3px);
            box-shadow: 0 12px 35px rgba(0, 102, 255, 0.4);
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
        
        .stat-card:hover {
            transform: translateY(-8px) scale(1.02);
            box-shadow: 0 25px 60px rgba(0, 102, 255, 0.15);
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
        
        @keyframes loading-progress {
            0% { transform: translateX(-100%); }
            50% { transform: translateX(0%); }
            100% { transform: translateX(100%); }
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
        
        .rtl-layout {
            direction: rtl;
            text-align: right;
        }
        
        .ltr-layout {
            direction: ltr;
            text-align: left;
        }
        
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
        
        /* Responsive Design */
        @media (max-width: 768px) {
            .vue-enhanced-container {
                padding: 15px;
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
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div id="vueAppContainer" class="vue-enhanced-container">
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
                        <span class="period-indicator" style="background: linear-gradient(45deg, #22c55e, #16a34a); color: white; padding: 12px 24px; border-radius: 30px; font-size: 1.2rem; font-weight: 600; display: inline-block; margin: 20px 0; box-shadow: 0 8px 25px rgba(34, 197, 94, 0.3);">
                            <i class="fas fa-calendar"></i>
                            {{ periodDisplay }}
                        </span>
                    </div>
                </div>

                <!-- Error Message Container -->
                <div v-if="errorMessage" class="data-section fade-in" style="border-left: 4px solid #ef4444;">
                    <div style="display: flex; align-items: center; gap: 15px;">
                        <i class="fas fa-exclamation-triangle" style="color: #ef4444; font-size: 2rem;"></i>
                        <div>
                            <h5 style="color: #ef4444; margin: 0;">حدث خطأ في النظام</h5>
                            <p style="margin: 5px 0; color: rgba(0,0,0,0.8);">{{ errorMessage }}</p>
                            <small style="color: rgba(0,0,0,0.6);">سيتم تحميل البيانات التجريبية تلقائياً</small>
                        </div>
                        <button @click="clearError" style="background: #ef4444; color: white; border: none; padding: 8px 12px; border-radius: 8px; cursor: pointer;">
                            <i class="fas fa-times"></i>
                        </button>
                    </div>
                </div>

                <!-- Success Message Container -->
                <div v-if="successMessage" class="data-section fade-in" style="border-left: 4px solid #22c55e;">
                    <div style="display: flex; align-items: center; gap: 15px;">
                        <i class="fas fa-check-circle" style="color: #22c55e; font-size: 2rem;"></i>
                        <div>
                            <h5 style="color: #22c55e; margin: 0;">تم بنجاح</h5>
                            <p style="margin: 5px 0; color: rgba(0,0,0,0.8);">{{ successMessage }}</p>
                        </div>
                        <button @click="clearSuccess" style="background: #22c55e; color: white; border: none; padding: 8px 12px; border-radius: 8px; cursor: pointer;">
                            <i class="fas fa-times"></i>
                        </button>
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
    </form>

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
                            
                            this.successMessage = 'تم تحميل البيانات التجريبية بنجاح (وضع الطوارئ)';
                            setTimeout(() => { this.successMessage = ''; }, 5000);
                        },
                        
                        showErrorMessage(message) {
                            this.errorMessage = message;
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
</body>
</html>
