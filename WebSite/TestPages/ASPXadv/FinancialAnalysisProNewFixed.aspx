<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FinancialAnalysisProNew.aspx.cs" Inherits="FinancialAnalysisProNew" %>

<!DOCTYPE html>
<html lang="ar" dir="rtl">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>التحليل المالي الجديد - Glass Effect</title>
    
    <!-- External Libraries -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@300;400;500;600;700;800&display=swap" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css" rel="stylesheet">
    
    <style>
        :root {
            --glass-bg: rgba(255, 255, 255, 0.1);
            --glass-border: rgba(255, 255, 255, 0.2);
            --glass-shadow: 0 25px 50px rgba(0, 0, 0, 0.1);
            --primary-gradient: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            --success-gradient: linear-gradient(135deg, #11998e 0%, #38ef7d 100%);
            --danger-gradient: linear-gradient(135deg, #ff6b6b 0%, #ee5a52 100%);
            --warning-gradient: linear-gradient(135deg, #f093fb 0%, #f5576c 100%);
        }
        
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }
        
        body {
            font-family: 'Inter', 'Segoe UI', 'Roboto', sans-serif;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 25%, #f093fb 75%, #f5576c 100%);
            min-height: 100vh;
            overflow-x: hidden;
            position: relative;
        }
        
        body::before {
            content: '';
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background-image: 
                radial-gradient(circle at 20% 80%, rgba(120, 119, 198, 0.3) 0%, transparent 50%),
                radial-gradient(circle at 80% 20%, rgba(255, 255, 255, 0.15) 0%, transparent 50%),
                radial-gradient(circle at 40% 40%, rgba(120, 119, 198, 0.15) 0%, transparent 50%);
            pointer-events: none;
            z-index: 0;
        }
        
        .glass-container {
            background: var(--glass-bg);
            backdrop-filter: blur(20px);
            border: 1px solid var(--glass-border);
            border-radius: 24px;
            box-shadow: var(--glass-shadow);
            padding: 40px;
            margin: 20px;
            position: relative;
            z-index: 1;
        }
        
        .glass-header {
            text-align: center;
            margin-bottom: 40px;
            position: relative;
        }
        
        .glass-title {
            font-size: 3.5rem;
            font-weight: 800;
            background: linear-gradient(45deg, #fff, #f0f0f0);
            background-clip: text;
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            text-shadow: 0 4px 20px rgba(0, 0, 0, 0.3);
            margin-bottom: 20px;
            letter-spacing: -2px;
        }
        
        .glass-subtitle {
            font-size: 1.4rem;
            color: rgba(255, 255, 255, 0.8);
            font-weight: 400;
            margin-bottom: 30px;
        }
        
        .controls-section {
            display: flex;
            justify-content: center;
            align-items: center;
            gap: 25px;
            margin-bottom: 40px;
            flex-wrap: wrap;
        }
        
        .glass-btn {
            background: rgba(255, 255, 255, 0.2);
            backdrop-filter: blur(10px);
            border: 1px solid rgba(255, 255, 255, 0.3);
            border-radius: 50px;
            padding: 16px 32px;
            color: white;
            font-size: 16px;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
            text-decoration: none;
            display: inline-flex;
            align-items: center;
            gap: 12px;
            position: relative;
            overflow: hidden;
        }
        
        .glass-btn:hover {
            background: rgba(255, 255, 255, 0.3);
            transform: translateY(-5px);
            box-shadow: 0 20px 40px rgba(0, 0, 0, 0.2);
            color: white;
        }
        
        .glass-btn::before {
            content: '';
            position: absolute;
            top: 0;
            left: -100%;
            width: 100%;
            height: 100%;
            background: linear-gradient(90deg, transparent, rgba(255, 255, 255, 0.2), transparent);
            transition: left 0.5s;
        }
        
        .glass-btn:hover::before {
            left: 100%;
        }
        
        .glass-select {
            background: rgba(255, 255, 255, 0.15);
            backdrop-filter: blur(10px);
            border: 1px solid rgba(255, 255, 255, 0.3);
            border-radius: 20px;
            padding: 16px 24px;
            color: white;
            font-size: 16px;
            font-weight: 600;
            outline: none;
            cursor: pointer;
            transition: all 0.3s ease;
            min-width: 200px;
        }
        
        .glass-select option {
            background: rgba(102, 126, 234, 0.9);
            color: white;
            padding: 10px;
        }
        
        .glass-select:focus {
            background: rgba(255, 255, 255, 0.25);
            box-shadow: 0 0 30px rgba(255, 255, 255, 0.3);
            transform: scale(1.05);
        }
        
        .stats-glass-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(350px, 1fr));
            gap: 30px;
            margin: 40px 0;
        }
        
        .glass-stat-card {
            background: rgba(255, 255, 255, 0.1);
            backdrop-filter: blur(20px);
            border: 1px solid rgba(255, 255, 255, 0.2);
            border-radius: 28px;
            padding: 40px 32px;
            text-align: center;
            transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
            position: relative;
            overflow: hidden;
        }
        
        .glass-stat-card::before {
            content: '';
            position: absolute;
            top: -2px;
            left: -2px;
            right: -2px;
            bottom: -2px;
            background: var(--primary-gradient);
            border-radius: 30px;
            z-index: -1;
            opacity: 0;
            transition: opacity 0.3s ease;
        }
        
        .glass-stat-card:hover::before {
            opacity: 0.1;
        }
        
        .glass-stat-card:hover {
            transform: translateY(-10px) scale(1.02);
            box-shadow: 0 30px 60px rgba(0, 0, 0, 0.2);
            background: rgba(255, 255, 255, 0.15);
        }
        
        .glass-stat-icon {
            font-size: 4rem;
            margin-bottom: 24px;
            display: block;
            filter: drop-shadow(0 4px 12px rgba(0, 0, 0, 0.3));
        }
        
        .glass-stat-value {
            font-size: 3.2rem;
            font-weight: 800;
            margin: 24px 0;
            text-shadow: 0 2px 8px rgba(0, 0, 0, 0.3);
            letter-spacing: -1px;
        }
        
        .glass-stat-label {
            font-size: 1.4rem;
            font-weight: 600;
            opacity: 0.9;
            margin-bottom: 12px;
            text-shadow: 0 1px 4px rgba(0, 0, 0, 0.2);
        }
        
        .glass-stat-count {
            font-size: 1.1rem;
            opacity: 0.7;
            margin-top: 16px;
            font-weight: 500;
        }
        
        .income-glass { 
            color: #4ade80;
            text-shadow: 0 0 20px rgba(74, 222, 128, 0.5);
        }
        
        .expense-glass { 
            color: #f87171;
            text-shadow: 0 0 20px rgba(248, 113, 113, 0.5);
        }
        
        .balance-glass { 
            color: #60a5fa;
            text-shadow: 0 0 20px rgba(96, 165, 250, 0.5);
        }
        
        .profit-glass { 
            color: #34d399;
            text-shadow: 0 0 20px rgba(52, 211, 153, 0.5);
        }
        
        .loss-glass { 
            color: #fbbf24;
            text-shadow: 0 0 20px rgba(251, 191, 36, 0.5);
        }
        
        .glass-loading {
            text-align: center;
            padding: 80px 40px;
            color: white;
        }
        
        .glass-loading i {
            font-size: 5rem;
            margin-bottom: 30px;
            animation: float 2s ease-in-out infinite;
            filter: drop-shadow(0 4px 20px rgba(255, 255, 255, 0.3));
        }
        
        @keyframes float {
            0%, 100% { transform: translateY(0px); }
            50% { transform: translateY(-20px); }
        }
        
        .glass-loading-text {
            font-size: 1.8rem;
            font-weight: 600;
            margin-bottom: 20px;
            text-shadow: 0 2px 8px rgba(0, 0, 0, 0.3);
        }
        
        .glass-progress {
            width: 300px;
            height: 8px;
            background: rgba(255, 255, 255, 0.2);
            border-radius: 10px;
            margin: 30px auto;
            overflow: hidden;
            position: relative;
        }
        
        .glass-progress::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: linear-gradient(90deg, transparent, rgba(255, 255, 255, 0.8), transparent);
            animation: shimmer 2s ease-in-out infinite;
        }
        
        @keyframes shimmer {
            0% { transform: translateX(-100%); }
            100% { transform: translateX(100%); }
        }
        
        .glass-message {
            background: rgba(255, 255, 255, 0.1);
            backdrop-filter: blur(15px);
            border: 1px solid rgba(255, 255, 255, 0.2);
            border-radius: 20px;
            padding: 24px;
            margin: 20px 0;
            color: white;
            display: flex;
            align-items: center;
            gap: 20px;
            transition: all 0.3s ease;
        }
        
        .glass-message:hover {
            background: rgba(255, 255, 255, 0.15);
            transform: translateY(-2px);
        }
        
        .glass-message.error {
            border-left: 4px solid #f87171;
            box-shadow: 0 0 20px rgba(248, 113, 113, 0.2);
        }
        
        .glass-message.success {
            border-left: 4px solid #4ade80;
            box-shadow: 0 0 20px rgba(74, 222, 128, 0.2);
        }
        
        .glass-message.warning {
            border-left: 4px solid #fbbf24;
            box-shadow: 0 0 20px rgba(251, 191, 36, 0.2);
        }
        
        .glass-close-btn {
            background: rgba(255, 255, 255, 0.2);
            border: none;
            color: white;
            padding: 8px 12px;
            border-radius: 12px;
            cursor: pointer;
            transition: all 0.3s ease;
            margin-left: auto;
        }
        
        .glass-close-btn:hover {
            background: rgba(255, 255, 255, 0.3);
            transform: scale(1.1);
        }
        
        .glass-categories-section {
            background: rgba(255, 255, 255, 0.08);
            backdrop-filter: blur(20px);
            border: 1px solid rgba(255, 255, 255, 0.15);
            border-radius: 24px;
            margin: 30px 0;
            overflow: hidden;
            transition: all 0.4s ease;
        }
        
        .glass-categories-header {
            background: rgba(255, 255, 255, 0.1);
            padding: 24px 32px;
            cursor: pointer;
            transition: all 0.3s ease;
            border-bottom: 1px solid rgba(255, 255, 255, 0.1);
        }
        
        .glass-categories-header:hover {
            background: rgba(255, 255, 255, 0.15);
        }
        
        .glass-categories-title {
            font-size: 1.8rem;
            font-weight: 700;
            color: white;
            margin: 0;
            display: flex;
            align-items: center;
            justify-content: space-between;
            text-shadow: 0 2px 8px rgba(0, 0, 0, 0.3);
        }
        
        .glass-categories-content {
            max-height: 0;
            overflow: hidden;
            transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
            opacity: 0;
        }
        
        .glass-categories-content.expanded {
            max-height: 2000px;
            opacity: 1;
            padding: 32px;
        }
        
        .glass-categories-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 24px;
        }
        
        .glass-category-card {
            background: rgba(255, 255, 255, 0.1);
            backdrop-filter: blur(15px);
            border: 1px solid rgba(255, 255, 255, 0.2);
            border-radius: 20px;
            padding: 28px;
            text-align: center;
            transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
            color: white;
        }
        
        .glass-category-card:hover {
            transform: translateY(-8px) scale(1.02);
            background: rgba(255, 255, 255, 0.15);
            box-shadow: 0 25px 50px rgba(0, 0, 0, 0.2);
        }
        
        .glass-info-panel {
            background: rgba(255, 255, 255, 0.08);
            backdrop-filter: blur(20px);
            border: 1px solid rgba(255, 255, 255, 0.15);
            border-radius: 20px;
            padding: 28px;
            margin: 30px 0;
            color: white;
        }
        
        .glass-warning {
            background: rgba(251, 191, 36, 0.1);
            border: 1px solid rgba(251, 191, 36, 0.3);
            backdrop-filter: blur(15px);
            border-radius: 16px;
            padding: 20px;
            margin: 20px 0;
            color: #fbbf24;
            display: flex;
            align-items: center;
            gap: 16px;
        }
        
        /* Responsive Design */
        @media (max-width: 768px) {
            .glass-container {
                margin: 10px;
                padding: 24px;
            }
            
            .glass-title {
                font-size: 2.5rem;
            }
            
            .controls-section {
                flex-direction: column;
                gap: 20px;
            }
            
            .stats-glass-grid {
                grid-template-columns: 1fr;
                gap: 20px;
            }
            
            .glass-categories-grid {
                grid-template-columns: 1fr;
            }
        }
        
        /* Animation Classes */
        .fade-in-glass {
            animation: fadeInGlass 0.8s ease-out forwards;
        }
        
        @keyframes fadeInGlass {
            from {
                opacity: 0;
                transform: translateY(30px) scale(0.95);
            }
            to {
                opacity: 1;
                transform: translateY(0) scale(1);
            }
        }
        
        .pulse-glow {
            animation: pulseGlow 2s ease-in-out infinite;
        }
        
        @keyframes pulseGlow {
            0%, 100% {
                box-shadow: 0 0 20px rgba(255, 255, 255, 0.1);
            }
            50% {
                box-shadow: 0 0 40px rgba(255, 255, 255, 0.2);
            }
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="glass-container fade-in-glass">
            <div id="glassApp" :class="isArabic ? 'rtl' : 'ltr'">
                <!-- Glass Header -->
                <div class="glass-header">
                    <h1 class="glass-title">
                        <i class="fas fa-chart-pie"></i>
                        {{ pageTitle }}
                    </h1>
                    <p class="glass-subtitle">{{ pageSubtitle }}</p>
                    
                    <!-- Controls -->
                    <div class="controls-section">
                        <button @click="toggleLanguage" class="glass-btn">
                            <i class="fas fa-language"></i>
                            {{ isArabic ? 'English' : 'العربية' }}
                        </button>
                        
                        <select v-model="selectedPeriod" @change="loadData" class="glass-select">
                            <option v-for="period in periods" :key="period.value" :value="period.value">
                                {{ period.text }}
                            </option>
                        </select>
                        
                        <button @click="toggleDataType" class="glass-btn">
                            <i class="fas fa-database"></i>
                            {{ dataTypeText }}
                        </button>
                        
                        <button @click="loadData" class="glass-btn" :disabled="loading">
                            <i class="fas fa-sync-alt" :class="{ 'fa-spin': loading }"></i>
                            {{ refreshText }}
                        </button>
                        
                        <button @click="toggleDebugMode" class="glass-btn">
                            <i class="fas fa-bug"></i>
                            {{ debugText }}
                        </button>
                    </div>
                </div>

                <!-- Error Messages -->
                <div v-if="errorMessage" class="glass-message error fade-in-glass">
                    <i class="fas fa-exclamation-triangle" style="font-size: 2rem;"></i>
                    <div>
                        <h5 style="margin: 0;">خطأ في النظام</h5>
                        <p style="margin: 5px 0 0 0;">{{ errorMessage }}</p>
                    </div>
                    <button @click="clearError" class="glass-close-btn">
                        <i class="fas fa-times"></i>
                    </button>
                </div>

                <!-- Success Messages -->
                <div v-if="successMessage" class="glass-message success fade-in-glass">
                    <i class="fas fa-check-circle" style="font-size: 2rem;"></i>
                    <div>
                        <h5 style="margin: 0;">نجح التحميل</h5>
                        <p style="margin: 5px 0 0 0;">{{ successMessage }}</p>
                    </div>
                    <button @click="clearSuccess" class="glass-close-btn">
                        <i class="fas fa-times"></i>
                    </button>
                </div>

                <!-- Loading Indicator -->
                <div v-if="loading" class="glass-loading fade-in-glass">
                    <i class="fas fa-spinner fa-spin"></i>
                    <div class="glass-loading-text">{{ loadingText }}</div>
                    <div class="glass-progress"></div>
                    <p style="opacity: 0.8; margin-top: 20px;">جاري معالجة البيانات المالية...</p>
                </div>

                <!-- Statistics Cards -->
                <div class="stats-glass-grid fade-in-glass" v-if="!loading && summary">
                    <!-- Income Card -->
                    <div class="glass-stat-card pulse-glow">
                        <i class="fas fa-arrow-trend-up glass-stat-icon income-glass"></i>
                        <div class="glass-stat-value income-glass">{{ formatCurrency(summary.totalIncome) }}</div>
                        <div class="glass-stat-label">{{ incomeLabel }}</div>
                        <div class="glass-stat-count">{{ summary.incomeCount }} {{ transactionText }}</div>
                    </div>

                    <!-- Expenses Card -->
                    <div class="glass-stat-card pulse-glow">
                        <i class="fas fa-arrow-trend-down glass-stat-icon expense-glass"></i>
                        <div class="glass-stat-value expense-glass">{{ formatCurrency(summary.totalExpenses) }}</div>
                        <div class="glass-stat-label">{{ expensesLabel }}</div>
                        <div class="glass-stat-count">{{ summary.expenseCount }} {{ transactionText }}</div>
                    </div>

                    <!-- Balance Card -->
                    <div class="glass-stat-card pulse-glow">
                        <i class="fas" :class="getBalanceIcon()" class="glass-stat-icon" :class="getBalanceColorClass()"></i>
                        <div class="glass-stat-value" :class="getBalanceColorClass()">{{ formatCurrency(summary.netBalance) }}</div>
                        <div class="glass-stat-label">{{ balanceLabel }}</div>
                        <div class="glass-stat-count">{{ getBalanceStatus() }}</div>
                    </div>
                </div>

                <!-- Income Categories -->
                <div v-if="!loading && incomeCategories.length > 0" class="glass-categories-section fade-in-glass">
                    <div class="glass-categories-header" @click="toggleSection('incomeCategories')">
                        <h3 class="glass-categories-title">
                            <span>
                                <i class="fas fa-coins"></i>
                                {{ incomeCategoriesTitle }}
                            </span>
                            <i class="fas fa-chevron-down" :id="'incomeCategoriesIcon'" style="transition: transform 0.3s ease;"></i>
                        </h3>
                    </div>
                    <div class="glass-categories-content" :id="'incomeCategoriesContent'">
                        <div class="glass-categories-grid">
                            <div v-for="category in incomeCategories" :key="category.category" class="glass-category-card">
                                <div style="font-size: 3rem; margin-bottom: 20px;">{{ category.categoryIcon }}</div>
                                <h6 style="font-weight: 600; margin-bottom: 16px; font-size: 1.1rem;">{{ category.category }}</h6>
                                <div style="font-size: 2rem; font-weight: 700; margin: 16px 0; color: #4ade80;">
                                    {{ formatCurrency(category.totalAmount) }}
                                </div>
                                <div style="opacity: 0.8; font-size: 0.9rem;">
                                    {{ category.voucherCount }} سند | متوسط: {{ formatCurrency(category.avgAmount) }}
                                </div>
                                <div style="margin-top: 16px;">
                                    <span class="badge" :style="getDataSourceStyle(category.dataSource)">{{ category.dataSource }}</span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Info Panel -->
                <div v-if="!loading" class="glass-info-panel fade-in-glass">
                    <div style="display: flex; justify-content: space-between; align-items: center; flex-wrap: wrap; gap: 20px;">
                        <div>
                            <h5 style="margin: 0; display: flex; align-items: center; gap: 12px;">
                                <i class="fas fa-info-circle" style="color: #60a5fa;"></i>
                                {{ reportPeriodLabel }} {{ currentPeriodText }}
                            </h5>
                            <p style="margin: 8px 0 0 0; opacity: 0.8; font-size: 0.9rem;">
                                Glass Effect Financial Dashboard • Vue.js Pro
                            </p>
                        </div>
                        <div style="text-align: right;">
                            <span :style="getDataSourceStyle(dataSourceText)" style="padding: 10px 20px; border-radius: 25px; font-weight: 600;">
                                {{ dataSourceText }}
                            </span>
                            <div style="margin-top: 8px; opacity: 0.7; font-size: 0.8rem;">
                                {{ new Date().toLocaleDateString('ar-SA') }}
                            </div>
                        </div>
                    </div>
                </div>

                <!-- Demo Warning -->
                <div v-if="isDemo || errorMessage" class="glass-warning fade-in-glass">
                    <i class="fas fa-exclamation-triangle" style="font-size: 1.5rem;"></i>
                    <div>
                        <strong>تنبيه: وضع البيانات التجريبية</strong>
                        <p style="margin: 5px 0 0 0; font-size: 0.9rem; opacity: 0.9;">
                            {{ errorMessage ? 'تم تحميل البيانات التجريبية بسبب خطأ في الاتصال.' : 'أنت تعرض البيانات التجريبية.' }}
                        </p>
                    </div>
                    <button @click="retryConnection" class="glass-btn" style="margin-left: auto;">
                        <i class="fas fa-redo"></i> إعادة محاولة
                    </button>
                </div>

                <!-- Debug Panel -->
                <div v-if="debugMode" class="glass-info-panel fade-in-glass" style="border: 1px solid #60a5fa;">
                    <h5 style="color: #60a5fa; margin: 0 0 20px 0; display: flex; align-items: center; gap: 12px;">
                        <i class="fas fa-bug"></i>
                        لوحة التشخيص
                    </h5>
                    <div style="display: grid; grid-template-columns: repeat(auto-fit, minmax(250px, 1fr)); gap: 16px; font-size: 0.9rem;">
                        <div><strong>الفترة:</strong> {{ selectedPeriod }}</div>
                        <div><strong>نوع البيانات:</strong> {{ dataTypeText }}</div>
                        <div><strong>اللغة:</strong> {{ isArabic ? 'العربية' : 'English' }}</div>
                        <div><strong>حالة التحميل:</strong> {{ loading ? 'جاري...' : 'مكتمل' }}</div>
                        <div><strong>Vue.js:</strong> {{ typeof Vue !== 'undefined' ? Vue.version : 'غير متوفر' }}</div>
                        <div><strong>الوقت:</strong> {{ new Date().toLocaleTimeString('ar-SA') }}</div>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <!-- Scripts -->
    <script src="https://cdn.jsdelivr.net/npm/vue@2.6.14/dist/vue.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/axios/dist/axios.min.js"></script>

    <script>
        document.addEventListener('DOMContentLoaded', function() {
            setTimeout(function() {
                if (typeof Vue !== 'undefined' && typeof axios !== 'undefined') {
                    initializeGlassApp();
                } else {
                    showLibraryError();
                }
            }, 300);
        });
        
        function showLibraryError() {
            const appContainer = document.getElementById('glassApp');
            if (appContainer) {
                appContainer.innerHTML = `
                    <div class="glass-message error">
                        <i class="fas fa-exclamation-triangle" style="font-size: 2rem;"></i>
                        <div>
                            <h4>مشكلة في تحميل المكتبات</h4>
                            <p>يبدو أن هناك مشكلة في تحميل Vue.js أو Axios. يرجى التحقق من اتصال الإنترنت.</p>
                        </div>
                        <button onclick="location.reload()" class="glass-btn">إعادة المحاولة</button>
                    </div>
                `;
            }
        }
        
        function initializeGlassApp() {
            try {
                Vue.config.productionTip = false;
                Vue.config.devtools = false;
                
                window.glassApp = new Vue({
                    el: '#glassApp',
                    data: {
                        // Language & UI
                        isArabic: true,
                        loading: false,
                        errorMessage: '',
                        successMessage: '',
                        debugMode: false,
                        
                        // Data controls
                        selectedPeriod: 'month',
                        isDemo: false,
                        
                        // Expanded sections
                        expandedSections: {},
                        
                        // Data
                        summary: null,
                        incomeCategories: [],
                        incomePaymentMethods: [],
                        expensePaymentMethods: []
                    },
                    computed: {
                        pageTitle() {
                            return this.isArabic ? 'التحليل المالي الجديد' : 'New Financial Analysis';
                        },
                        pageSubtitle() {
                            return this.isArabic ? 'تقرير متقدم بتقنية Glass Effect' : 'Advanced Glass Effect Dashboard';
                        },
                        refreshText() {
                            return this.isArabic ? 'تحديث' : 'Refresh';
                        },
                        debugText() {
                            return this.isArabic ? 'تشخيص' : 'Debug';
                        },
                        loadingText() {
                            return this.isArabic ? 'جاري تحميل البيانات المالية...' : 'Loading financial data...';
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
                        dataTypeText() {
                            return this.isDemo ? 
                                (this.isArabic ? 'بيانات تجريبية' : 'Demo Data') : 
                                (this.isArabic ? 'بيانات حقيقية' : 'Real Data');
                        },
                        dataSourceText() {
                            return this.isDemo ? 
                                (this.isArabic ? 'تجريبي' : 'Demo') : 
                                (this.isArabic ? 'حقيقي' : 'Real');
                        },
                        currentPeriodText() {
                            const period = this.periods.find(p => p.value === this.selectedPeriod);
                            return period ? period.text : '';
                        },
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
                        },
                        
                        toggleDataType() {
                            this.isDemo = !this.isDemo;
                            this.loadData();
                        },
                        
                        async loadData() {
                            this.loading = true;
                            this.clearMessages();
                            
                            try {
                                const response = await axios({
                                    method: 'POST',
                                    url: 'FinancialAnalysisProNew.aspx/GetFinancialAnalysisData',
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
                                
                                if (response.data && response.data.d) {
                                    const data = JSON.parse(response.data.d);
                                    
                                    if (data.error) {
                                        this.showErrorMessage(data.error);
                                        this.loadDemoDataAsFallback();
                                        return;
                                    }
                                    
                                    this.summary = data.summary;
                                    this.incomeCategories = data.incomeCategories || [];
                                    this.incomePaymentMethods = data.incomePaymentMethods || [];
                                    this.expensePaymentMethods = data.expensePaymentMethods || [];
                                    
                                    this.showSuccessMessage(data.message || 'تم تحميل البيانات بنجاح');
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
                            this.summary = {
                                totalIncome: 52000.00,
                                totalExpenses: 28500.00,
                                netBalance: 23500.00,
                                incomeCount: 15,
                                expenseCount: 8,
                                profitMargin: 45.2
                            };
                            
                            this.incomeCategories = [
                                { category: "💼 إيرادات الخدمات", categoryIcon: "💼", totalAmount: 32000.00, voucherCount: 10, avgAmount: 3200.00, dataSource: "تجريبي" },
                                { category: "🛒 إيرادات المبيعات", categoryIcon: "🛒", totalAmount: 15000.00, voucherCount: 4, avgAmount: 3750.00, dataSource: "تجريبي" },
                                { category: "📌 إيرادات متنوعة", categoryIcon: "📌", totalAmount: 5000.00, voucherCount: 1, avgAmount: 5000.00, dataSource: "تجريبي" }
                            ];
                        },
                        
                        formatCurrency(amount) {
                            return new Intl.NumberFormat(this.isArabic ? 'ar-SA' : 'en-US', {
                                style: 'decimal',
                                minimumFractionDigits: 2,
                                maximumFractionDigits: 2
                            }).format(amount || 0) + (this.isArabic ? ' ريال' : '');
                        },
                        
                        getBalanceIcon() {
                            if (!this.summary) return 'fas fa-chart-line';
                            return this.summary.netBalance >= 0 ? 'fas fa-chart-line' : 'fas fa-chart-line-down';
                        },
                        
                        getBalanceColorClass() {
                            if (!this.summary) return 'balance-glass';
                            return this.summary.netBalance >= 0 ? 'profit-glass' : 'loss-glass';
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
                                'حقيقي': 'background: rgba(74, 222, 128, 0.2); color: #4ade80; border: 1px solid #4ade80; padding: 6px 12px; border-radius: 15px; font-size: 0.8rem; font-weight: 600;',
                                'تجريبي': 'background: rgba(96, 165, 250, 0.2); color: #60a5fa; border: 1px solid #60a5fa; padding: 6px 12px; border-radius: 15px; font-size: 0.8rem; font-weight: 600;',
                                'Real': 'background: rgba(74, 222, 128, 0.2); color: #4ade80; border: 1px solid #4ade80; padding: 6px 12px; border-radius: 15px; font-size: 0.8rem; font-weight: 600;',
                                'Demo': 'background: rgba(96, 165, 250, 0.2); color: #60a5fa; border: 1px solid #60a5fa; padding: 6px 12px; border-radius: 15px; font-size: 0.8rem; font-weight: 600;'
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
                        
                        toggleDebugMode() {
                            this.debugMode = !this.debugMode;
                        },
                        
                        showErrorMessage(message) {
                            this.errorMessage = message;
                            setTimeout(() => { this.errorMessage = ''; }, 8000);
                        },
                        
                        showSuccessMessage(message) {
                            this.successMessage = message;
                            setTimeout(() => { this.successMessage = ''; }, 5000);
                        },
                        
                        clearError() {
                            this.errorMessage = '';
                        },
                        
                        clearSuccess() {
                            this.successMessage = '';
                        },
                        
                        clearMessages() {
                            this.errorMessage = '';
                            this.successMessage = '';
                        },
                        
                        retryConnection() {
                            this.clearMessages();
                            this.loadData();
                        }
                    },
                    
                    mounted() {
                        this.$nextTick(() => {
                            document.documentElement.setAttribute('dir', this.isArabic ? 'rtl' : 'ltr');
                            this.loadData();
                        });
                    }
                });
                
                console.log('Glass Effect app initialized successfully');
                
            } catch (error) {
                console.error('Error initializing Glass app:', error);
                showLibraryError();
            }
        }
    </script>
</body>
</html>
