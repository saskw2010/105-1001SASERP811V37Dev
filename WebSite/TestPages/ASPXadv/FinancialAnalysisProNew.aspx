<%@ Page Language="C#"  CodeFile="FinancialAnalysisProNew.aspx.cs" Inherits="FinancialAnalysisProNew" %>



<!DOCTYPE html>
<html lang="ar" dir="rtl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>التحليل المالي المتقدم</title>
    
    <!-- External Libraries -->
    <script src="https://unpkg.com/vue@2.6.14/dist/vue.min.js"></script>
    <script src="https://unpkg.com/axios/dist/axios.min.js"></script>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap/5.3.0/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@300;400;500;600;700&display=swap" rel="stylesheet">
    
    <style>
        :root {
            --primary-blue: #0066FF;
            --secondary-blue: #3399FF;
            --accent-cyan: #00CCFF;
            --success-green: #00E676;
            --warning-orange: #FF6D00;
            --danger-red: #FF1744;
            --neutral-gray: #64748B;
            --bg-gradient: linear-gradient(135deg, #0066FF 0%, #00CCFF 100%);
            --glass-bg: rgba(255, 255, 255, 0.08);
            --glass-border: rgba(255, 255, 255, 0.18);
            --shadow-soft: 0 8px 32px rgba(0, 102, 255, 0.15);
            --shadow-glow: 0 0 40px rgba(0, 204, 255, 0.3);
            --transition-smooth: all 0.4s cubic-bezier(0.25, 0.46, 0.45, 0.94);
        }

        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            font-family: 'Inter', 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background: var(--bg-gradient);
            min-height: 100vh;
            color: #fff;
            line-height: 1.6;
            overflow-x: hidden;
        }

        .financial-analysis-container {
            background: transparent;
            min-height: 100vh;
            padding: 2rem 1rem;
        }

        .glass-card {
            background: var(--glass-bg);
            backdrop-filter: blur(20px) saturate(180%);
            -webkit-backdrop-filter: blur(20px) saturate(180%);
            border: 1px solid var(--glass-border);
            border-radius: 20px;
            box-shadow: var(--shadow-soft);
            padding: 2rem;
            margin-bottom: 2rem;
            transition: var(--transition-smooth);
            position: relative;
            overflow: hidden;
        }

        .glass-card::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            height: 1px;
            background: linear-gradient(90deg, transparent, rgba(255,255,255,0.3), transparent);
        }

        .glass-card:hover {
            transform: translateY(-4px);
            box-shadow: var(--shadow-glow);
            border-color: var(--accent-cyan);
        }

        .page-header {
            text-align: center;
            margin-bottom: 3rem;
        }

        .page-title {
            font-size: 3rem;
            font-weight: 700;
            background: linear-gradient(135deg, #fff 0%, var(--accent-cyan) 100%);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            margin-bottom: 1rem;
            text-shadow: 0 4px 8px rgba(0,0,0,0.3);
        }

        .page-subtitle {
            font-size: 1.2rem;
            color: rgba(255,255,255,0.8);
            font-weight: 300;
        }

        .control-panel {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(280px, 1fr));
            gap: 1.5rem;
            margin-bottom: 2rem;
        }

        .control-group {
            display: flex;
            flex-direction: column;
            gap: 0.5rem;
        }

        .control-label {
            font-weight: 600;
            color: rgba(255,255,255,0.9);
            font-size: 0.9rem;
            text-transform: uppercase;
            letter-spacing: 1px;
        }

        .control-input {
            background: rgba(255,255,255,0.1);
            border: 1px solid rgba(255,255,255,0.2);
            border-radius: 12px;
            padding: 12px 16px;
            color: #fff;
            font-size: 1rem;
            transition: var(--transition-smooth);
        }

        .control-input:focus {
            outline: none;
            border-color: var(--accent-cyan);
            box-shadow: 0 0 0 3px rgba(0, 204, 255, 0.2);
            background: rgba(255,255,255,0.15);
        }

        .control-input option {
            background: var(--primary-blue);
            color: #fff;
        }

        .btn-modern {
            background: linear-gradient(135deg, var(--primary-blue) 0%, var(--secondary-blue) 100%);
            border: none;
            border-radius: 12px;
            padding: 12px 24px;
            color: #fff;
            font-weight: 600;
            font-size: 1rem;
            cursor: pointer;
            transition: var(--transition-smooth);
            text-transform: uppercase;
            letter-spacing: 1px;
            box-shadow: 0 4px 15px rgba(0, 102, 255, 0.3);
        }

        .btn-modern:hover {
            transform: translateY(-2px);
            box-shadow: 0 8px 25px rgba(0, 102, 255, 0.4);
            background: linear-gradient(135deg, var(--secondary-blue) 0%, var(--accent-cyan) 100%);
        }

        .summary-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(280px, 1fr));
            gap: 1.5rem;
            margin-bottom: 2rem;
        }

        .summary-card {
            background: var(--glass-bg);
            backdrop-filter: blur(20px);
            border: 1px solid var(--glass-border);
            border-radius: 16px;
            padding: 1.5rem;
            text-align: center;
            transition: var(--transition-smooth);
            position: relative;
            overflow: hidden;
        }

        .summary-card::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            height: 3px;
            background: linear-gradient(90deg, var(--primary-blue), var(--accent-cyan));
        }

        .summary-card:hover {
            transform: scale(1.02);
            box-shadow: var(--shadow-glow);
        }

        .summary-icon {
            font-size: 2.5rem;
            margin-bottom: 1rem;
            color: var(--accent-cyan);
        }

        .summary-value {
            font-size: 2rem;
            font-weight: 700;
            color: #fff;
            margin-bottom: 0.5rem;
        }

        .summary-label {
            font-size: 0.9rem;
            color: rgba(255,255,255,0.7);
            text-transform: uppercase;
            letter-spacing: 1px;
        }

        .categories-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(320px, 1fr));
            gap: 1.5rem;
            margin-bottom: 2rem;
        }

        .category-card {
            background: var(--glass-bg);
            backdrop-filter: blur(20px);
            border: 1px solid var(--glass-border);
            border-radius: 16px;
            padding: 1.5rem;
            transition: var(--transition-smooth);
        }

        .category-header {
            display: flex;
            align-items: center;
            gap: 1rem;
            margin-bottom: 1rem;
        }

        .category-icon {
            font-size: 1.5rem;
        }

        .category-name {
            font-size: 1.1rem;
            font-weight: 600;
            color: #fff;
        }

        .category-amount {
            font-size: 1.5rem;
            font-weight: 700;
            color: var(--accent-cyan);
            margin-bottom: 0.5rem;
        }

        .category-details {
            display: flex;
            justify-content: space-between;
            color: rgba(255,255,255,0.7);
            font-size: 0.9rem;
        }

        .payment-methods {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 2rem;
        }

        .payment-section {
            background: var(--glass-bg);
            backdrop-filter: blur(20px);
            border: 1px solid var(--glass-border);
            border-radius: 16px;
            padding: 1.5rem;
        }

        .section-title {
            font-size: 1.3rem;
            font-weight: 600;
            color: #fff;
            margin-bottom: 1rem;
            text-align: center;
        }

        .method-item {
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 0.75rem 0;
            border-bottom: 1px solid rgba(255,255,255,0.1);
        }

        .method-item:last-child {
            border-bottom: none;
        }

        .method-name {
            font-weight: 500;
            color: rgba(255,255,255,0.9);
        }

        .method-amount {
            font-weight: 600;
            color: var(--accent-cyan);
        }

        .method-percentage {
            font-size: 0.8rem;
            color: rgba(255,255,255,0.6);
        }

        .transactions-table {
            background: var(--glass-bg);
            backdrop-filter: blur(20px);
            border: 1px solid var(--glass-border);
            border-radius: 16px;
            overflow: hidden;
        }

        .table-header {
            background: rgba(255,255,255,0.1);
            padding: 1rem;
            font-weight: 600;
            text-align: center;
        }

        .table {
            color: #fff;
            margin: 0;
        }

        .table th {
            background: rgba(255,255,255,0.08);
            border: none;
            color: rgba(255,255,255,0.9);
            font-weight: 600;
            padding: 1rem;
            text-align: center;
        }

        .table td {
            border: none;
            border-bottom: 1px solid rgba(255,255,255,0.1);
            padding: 1rem;
            text-align: center;
        }

        .badge-type {
            padding: 0.4rem 0.8rem;
            border-radius: 8px;
            font-size: 0.8rem;
            font-weight: 600;
            text-transform: uppercase;
        }

        .badge-income {
            background: rgba(0, 230, 118, 0.2);
            color: var(--success-green);
            border: 1px solid var(--success-green);
        }

        .badge-expense {
            background: rgba(255, 23, 68, 0.2);
            color: var(--danger-red);
            border: 1px solid var(--danger-red);
        }

        .loading-spinner {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 200px;
        }

        .spinner {
            width: 40px;
            height: 40px;
            border: 3px solid rgba(255,255,255,0.3);
            border-top: 3px solid var(--accent-cyan);
            border-radius: 50%;
            animation: spin 1s linear infinite;
        }

        @keyframes spin {
            0% { transform: rotate(0deg); }
            100% { transform: rotate(360deg); }
        }

        .error-message {
            background: rgba(255, 23, 68, 0.1);
            border: 1px solid var(--danger-red);
            border-radius: 12px;
            padding: 1rem;
            color: var(--danger-red);
            text-align: center;
            margin: 1rem 0;
        }

        .success-message {
            background: rgba(0, 230, 118, 0.1);
            border: 1px solid var(--success-green);
            border-radius: 12px;
            padding: 1rem;
            color: var(--success-green);
            text-align: center;
            margin: 1rem 0;
        }

        @media (max-width: 768px) {
            .financial-analysis-container {
                padding: 1rem 0.5rem;
            }
            
            .page-title {
                font-size: 2rem;
            }
            
            .control-panel {
                grid-template-columns: 1fr;
            }
            
            .summary-grid {
                grid-template-columns: 1fr;
            }
            
            .categories-grid {
                grid-template-columns: 1fr;
            }
            
            .payment-methods {
                grid-template-columns: 1fr;
            }
        }
    </style>
</head>

<body>
    <div id="financialAnalysisApp" class="financial-analysis-container">
        <!-- Page Header -->
        <div class="page-header">
            <h1 class="page-title">💼 التحليل المالي المتقدم</h1>
            <p class="page-subtitle">نظام تحليل شامل مع بيانات حقيقية وتجريبية</p>
        </div>

        <!-- Control Panel -->
        <div class="glass-card">
            <div class="control-panel">
                <div class="control-group">
                    <label class="control-label">📅 الفترة الزمنية</label>
                    <select v-model="selectedPeriod" @change="loadFinancialData" class="control-input">
                        <option value="today">اليوم</option>
                        <option value="week">هذا الأسبوع</option>
                        <option value="month">هذا الشهر</option>
                        <option value="year">هذا العام</option>
                    </select>
                </div>

                <div class="control-group">
                    <label class="control-label">🔢 نوع البيانات</label>
                    <select v-model="selectedDataType" @change="loadFinancialData" class="control-input">
                        <option value="Real">بيانات حقيقية (افتراضي)</option>
                        <option value="Demo">بيانات تجريبية</option>
                    </select>
                </div>

                <div class="control-group">
                    <label class="control-label">⚡ إجراءات</label>
                    <div style="display: flex; gap: 10px;">
                        <button @click="loadFinancialData" class="btn-modern" :disabled="isLoading" style="flex: 1;">
                            <i class="fas fa-sync-alt" :class="{'fa-spin': isLoading}"></i>
                            {{ isLoading ? 'جاري التحميل...' : 'تحديث البيانات' }}
                        </button>
                        <button @click="toggleDebugMode" class="btn-modern" style="background: linear-gradient(135deg, #FFB74D, #FF6D00); min-width: auto;">
                            <i class="fas fa-bug"></i>
                        </button>
                    </div>
                </div>
            </div>
        </div>

        <!-- Loading State -->
        <div v-if="isLoading" class="loading-spinner">
            <div class="spinner"></div>
        </div>

        <!-- Enhanced Error Message -->
        <div v-if="errorMessage" class="error-message" style="position: relative;">
            <div style="display: flex; align-items: center; gap: 15px;">
                <i class="fas fa-exclamation-triangle" style="font-size: 1.5rem;"></i>
                <div style="flex: 1;">
                    <h6 style="margin: 0 0 5px 0; color: var(--danger-red);">تنبيه: حدث خطأ في النظام</h6>
                    <p style="margin: 0; font-size: 0.9rem;">{{ errorMessage }}</p>
                    <small style="opacity: 0.8;">تم تحميل البيانات التجريبية بدلاً من ذلك</small>
                </div>
                <button @click="errorMessage = ''" style="background: var(--danger-red); color: white; border: none; padding: 8px 12px; border-radius: 8px; cursor: pointer;">
                    <i class="fas fa-times"></i>
                </button>
            </div>
        </div>

        <!-- Enhanced Success Message -->
        <div v-if="successMessage" class="success-message" style="position: relative;">
            <div style="display: flex; align-items: center; gap: 15px;">
                <i class="fas fa-check-circle" style="font-size: 1.5rem;"></i>
                <div style="flex: 1;">
                    <h6 style="margin: 0 0 5px 0; color: var(--success-green);">تم بنجاح</h6>
                    <p style="margin: 0; font-size: 0.9rem;">{{ successMessage }}</p>
                </div>
                <button @click="successMessage = ''" style="background: var(--success-green); color: white; border: none; padding: 8px 12px; border-radius: 8px; cursor: pointer;">
                    <i class="fas fa-times"></i>
                </button>
            </div>
        </div>

        <!-- Financial Summary -->
        <div v-if="!isLoading && financialData.summary" class="glass-card">
            <h2 class="section-title">📊 الملخص المالي</h2>
            <div class="summary-grid">
                <div class="summary-card">
                    <div class="summary-icon">💰</div>
                    <div class="summary-value">{{ formatCurrency(financialData.summary.totalIncome) }}</div>
                    <div class="summary-label">إجمالي الإيرادات</div>
                </div>
                <div class="summary-card">
                    <div class="summary-icon">💸</div>
                    <div class="summary-value">{{ formatCurrency(financialData.summary.totalExpenses) }}</div>
                    <div class="summary-label">إجمالي المصروفات</div>
                </div>
                <div class="summary-card">
                    <div class="summary-icon">💵</div>
                    <div class="summary-value" :class="financialData.summary.netBalance >= 0 ? 'text-success' : 'text-danger'">
                        {{ formatCurrency(financialData.summary.netBalance) }}
                    </div>
                    <div class="summary-label">صافي الربح</div>
                </div>
                <div class="summary-card">
                    <div class="summary-icon">📈</div>
                    <div class="summary-value">{{ financialData.summary.profitMargin }}%</div>
                    <div class="summary-label">هامش الربح</div>
                </div>
            </div>
        </div>

        <!-- Income Categories -->
        <div v-if="!isLoading && financialData.incomeCategories && financialData.incomeCategories.length > 0" class="glass-card">
            <h2 class="section-title">📋 تصنيف الإيرادات</h2>
            <div class="categories-grid">
                <div v-for="category in financialData.incomeCategories" :key="category.category" class="category-card">
                    <div class="category-header">
                        <span class="category-icon">{{ category.categoryIcon }}</span>
                        <span class="category-name">{{ category.category }}</span>
                    </div>
                    <div class="category-amount">{{ formatCurrency(category.totalAmount) }}</div>
                    <div class="category-details">
                        <span>{{ category.voucherCount }} مستند</span>
                        <span>متوسط: {{ formatCurrency(category.avgAmount) }}</span>
                    </div>
                </div>
            </div>
        </div>

        <!-- Payment Methods Analysis -->
        <div v-if="!isLoading && (financialData.incomePaymentMethods || financialData.expensePaymentMethods)" class="glass-card">
            <h2 class="section-title">💳 تحليل طرق الدفع</h2>
            <div class="payment-methods">
                <div v-if="financialData.incomePaymentMethods" class="payment-section">
                    <h3 class="section-title">💰 طرق دفع الإيرادات</h3>
                    <div v-for="method in financialData.incomePaymentMethods" :key="method.paymentMethod" class="method-item">
                        <div class="method-name">{{ method.paymentMethod }}</div>
                        <div>
                            <div class="method-amount">{{ formatCurrency(method.totalAmount) }}</div>
                            <div class="method-percentage">{{ method.percentage }}%</div>
                        </div>
                    </div>
                </div>

                <div v-if="financialData.expensePaymentMethods" class="payment-section">
                    <h3 class="section-title">💸 طرق دفع المصروفات</h3>
                    <div v-for="method in financialData.expensePaymentMethods" :key="method.paymentMethod" class="method-item">
                        <div class="method-name">{{ method.paymentMethod }}</div>
                        <div>
                            <div class="method-amount">{{ formatCurrency(method.totalAmount) }}</div>
                            <div class="method-percentage">{{ method.percentage }}%</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Detailed Transactions -->
        <div v-if="!isLoading && financialData.detailedTransactions && financialData.detailedTransactions.length > 0" class="glass-card">
            <h2 class="section-title">📄 المعاملات التفصيلية</h2>
            <div class="transactions-table">
                <table class="table">
                    <thead>
                        <tr>
                            <th>النوع</th>
                            <th>رقم المستند</th>
                            <th>التاريخ</th>
                            <th>الوصف</th>
                            <th>المبلغ</th>
                            <th>طريقة الدفع</th>
                            <th>التصنيف</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr v-for="transaction in financialData.detailedTransactions" :key="transaction.voucherNo">
                            <td>
                                <span class="badge-type" :class="transaction.type === 'income' ? 'badge-income' : 'badge-expense'">
                                    {{ transaction.type === 'income' ? 'إيراد' : 'مصروف' }}
                                </span>
                            </td>
                            <td>{{ transaction.voucherNo }}</td>
                            <td>{{ formatDate(transaction.date) }}</td>
                            <td>{{ transaction.description }}</td>
                            <td>{{ formatCurrency(transaction.amount) }}</td>
                            <td>{{ transaction.paymentMethod }}</td>
                            <td>{{ transaction.category }}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>

        <!-- Debug Information -->
        <div v-if="debugMode && financialData.debug" class="glass-card">
            <h2 class="section-title">🔧 معلومات التشخيص</h2>
            <pre style="color: rgba(255,255,255,0.8); font-size: 0.9rem;">{{ JSON.stringify(financialData.debug, null, 2) }}</pre>
        </div>
    </div>

    <script>
        // Error handling for Vue app
        window.addEventListener('error', function(e) {
            console.error('Global Error:', e.error);
            showFallbackInterface('حدث خطأ عام في الصفحة: ' + e.error.message);
        });

        window.addEventListener('unhandledrejection', function(e) {
            console.error('Unhandled Promise Rejection:', e.reason);
            showFallbackInterface('خطأ في معالجة البيانات: ' + e.reason);
        });

        function showFallbackInterface(errorMessage) {
            const appContainer = document.getElementById('financialAnalysisApp');
            if (appContainer) {
                appContainer.innerHTML = `
                    <div class="financial-analysis-container">
                        <div style="background: rgba(255,255,255,0.1); padding: 30px; border-radius: 20px; margin: 20px; backdrop-filter: blur(20px);">
                            <h2 style="text-align: center; color: #fff; margin-bottom: 20px;">
                                <i class="fas fa-exclamation-triangle" style="color: #FFB74D;"></i> 
                                خطأ في النظام
                            </h2>
                            
                            <div style="background: rgba(255,23,68,0.1); border: 1px solid #FF1744; border-radius: 12px; padding: 20px; margin: 20px 0; color: #FF1744;">
                                <h5><i class="fas fa-bug"></i> تفاصيل الخطأ:</h5>
                                <p style="font-family: 'Courier New', monospace; background: rgba(0,0,0,0.2); padding: 10px; border-radius: 5px; margin: 10px 0;">${errorMessage}</p>
                            </div>
                            
                            <div style="background: rgba(0,230,118,0.1); border: 1px solid #00E676; border-radius: 12px; padding: 20px; margin: 20px 0;">
                                <h4 style="color: #00E676; margin-bottom: 15px;"><i class="fas fa-chart-bar"></i> بيانات تجريبية - وضع الطوارئ</h4>
                                
                                <div style="display: grid; grid-template-columns: repeat(auto-fit, minmax(250px, 1fr)); gap: 15px; margin: 20px 0;">
                                    <div style="background: rgba(255,255,255,0.1); padding: 20px; border-radius: 15px; text-align: center;">
                                        <div style="font-size: 2rem; color: #00E676; margin-bottom: 10px;">💰</div>
                                        <div style="font-size: 1.8rem; font-weight: bold; color: #fff;">48,500 ر.س</div>
                                        <div style="color: rgba(255,255,255,0.7);">إجمالي الإيرادات</div>
                                    </div>
                                    
                                    <div style="background: rgba(255,255,255,0.1); padding: 20px; border-radius: 15px; text-align: center;">
                                        <div style="font-size: 2rem; color: #FF1744; margin-bottom: 10px;">💸</div>
                                        <div style="font-size: 1.8rem; font-weight: bold; color: #fff;">25,500 ر.س</div>
                                        <div style="color: rgba(255,255,255,0.7);">إجمالي المصروفات</div>
                                    </div>
                                    
                                    <div style="background: rgba(255,255,255,0.1); padding: 20px; border-radius: 15px; text-align: center;">
                                        <div style="font-size: 2rem; color: #00CCFF; margin-bottom: 10px;">📈</div>
                                        <div style="font-size: 1.8rem; font-weight: bold; color: #fff;">23,000 ر.س</div>
                                        <div style="color: rgba(255,255,255,0.7);">صافي الربح</div>
                                    </div>
                                </div>
                                
                                <div style="text-align: center; margin-top: 20px;">
                                    <button onclick="location.reload()" style="background: linear-gradient(135deg, #0066FF, #3399FF); color: white; border: none; padding: 12px 24px; border-radius: 12px; margin: 5px; cursor: pointer; font-weight: 600;">
                                        <i class="fas fa-sync-alt"></i> إعادة المحاولة
                                    </button>
                                    <button onclick="toggleDebugMode()" style="background: linear-gradient(135deg, #FFB74D, #FF6D00); color: white; border: none; padding: 12px 24px; border-radius: 12px; margin: 5px; cursor: pointer; font-weight: 600;">
                                        <i class="fas fa-bug"></i> وضع التشخيص
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                `;
            }
        }

        function toggleDebugMode() {
            const debugInfo = document.createElement('div');
            debugInfo.id = 'debugInfo';
            debugInfo.style.cssText = 'position: fixed; top: 20px; right: 20px; width: 400px; max-height: 80vh; overflow-y: auto; background: rgba(0,0,0,0.9); color: #00E676; padding: 20px; border-radius: 10px; font-family: monospace; font-size: 12px; z-index: 9999; border: 1px solid #00E676;';
            debugInfo.innerHTML = `
                <div style="display: flex; justify-content: space-between; align-items: center; margin-bottom: 15px;">
                    <h5 style="margin: 0; color: #00E676;">🔧 معلومات التشخيص</h5>
                    <button onclick="document.getElementById('debugInfo').remove()" style="background: #FF1744; color: white; border: none; padding: 5px 10px; border-radius: 5px; cursor: pointer;">✕</button>
                </div>
                <div style="border-bottom: 1px solid #333; padding-bottom: 10px; margin-bottom: 10px;">
                    <strong>📅 الوقت:</strong> ${new Date().toLocaleString('ar-SA')}<br>
                    <strong>🌐 المتصفح:</strong> ${navigator.userAgent}<br>
                    <strong>📱 الشاشة:</strong> ${window.innerWidth}x${window.innerHeight}<br>
                    <strong>🔗 الرابط:</strong> ${window.location.href}
                </div>
                <div style="border-bottom: 1px solid #333; padding-bottom: 10px; margin-bottom: 10px;">
                    <strong>📚 المكتبات المحملة:</strong><br>
                    Vue.js: ${typeof Vue !== 'undefined' ? '✅ متوفر' : '❌ غير متوفر'}<br>
                    Axios: ${typeof axios !== 'undefined' ? '✅ متوفر' : '❌ غير متوفر'}<br>
                    Bootstrap: ${typeof bootstrap !== 'undefined' ? '✅ متوفر' : '❌ غير متوفر'}
                </div>
                <div>
                    <strong>💾 حالة التطبيق:</strong><br>
                    العنصر الرئيسي: ${document.getElementById('financialAnalysisApp') ? '✅ موجود' : '❌ غير موجود'}<br>
                    وضع الطوارئ: ✅ نشط<br>
                    آخر خطأ: انظر console.log
                </div>
            `;
            document.body.appendChild(debugInfo);
        }

        new Vue({
            el: '#financialAnalysisApp',
            data: {
                isLoading: false,
                errorMessage: '',
                successMessage: '',
                debugMode: false,
                selectedPeriod: 'month',
                selectedDataType: 'Real',
                financialData: {
                    summary: null,
                    incomeCategories: [],
                    incomePaymentMethods: [],
                    expensePaymentMethods: [],
                    detailedTransactions: [],
                    debug: null
                }
            },
            mounted() {
                this.loadFinancialData();
            },
            methods: {
                async loadFinancialData() {
                    this.isLoading = true;
                    this.errorMessage = '';
                    this.successMessage = '';

                    try {
                        const response = await axios.post('FinancialAnalysisProNew.aspx/GetAdvancedFinancialData', {
                            period: this.selectedPeriod,
                            dataType: this.selectedDataType,
                            isArabic: true
                        }, {
                            headers: {
                                'Content-Type': 'application/json'
                            },
                            timeout: 30000
                        });

                        if (response.data && response.data.d) {
                            const result = JSON.parse(response.data.d);
                            
                            if (result.success) {
                                this.financialData = {
                                    summary: result.summary,
                                    incomeCategories: result.incomeCategories || [],
                                    incomePaymentMethods: result.incomePaymentMethods || [],
                                    expensePaymentMethods: result.expensePaymentMethods || [],
                                    detailedTransactions: result.detailedTransactions || [],
                                    debug: result.debug
                                };
                                this.successMessage = 'تم تحميل البيانات بنجاح';
                                setTimeout(() => { this.successMessage = ''; }, 3000);
                            } else {
                                this.errorMessage = result.error || 'حدث خطأ في تحميل البيانات';
                                console.error('Server Error:', result);
                                this.loadDemoData();
                            }
                        } else {
                            throw new Error('Invalid response format');
                        }
                    } catch (error) {
                        console.error('Error loading financial data:', error);
                        
                        if (error.code === 'ECONNABORTED') {
                            this.errorMessage = 'انتهت مهلة الاتصال - جاري تحميل البيانات التجريبية';
                        } else if (error.response && error.response.status === 500) {
                            this.errorMessage = 'خطأ في السيرفر - جاري تحميل البيانات التجريبية';
                        } else if (error.response && error.response.status === 404) {
                            this.errorMessage = 'الصفحة غير موجودة - جاري تحميل البيانات التجريبية';
                        } else {
                            this.errorMessage = `خطأ في الاتصال: ${error.message} - جاري تحميل البيانات التجريبية`;
                        }
                        
                        // Load demo data as fallback
                        this.loadDemoData();
                    } finally {
                        this.isLoading = false;
                    }
                },

                loadDemoData() {
                    console.log('Loading demo data as fallback...');
                    this.financialData = {
                        summary: {
                            totalIncome: 48500.00,
                            totalExpenses: 25500.00,
                            netBalance: 23000.00,
                            incomeCount: 12,
                            expenseCount: 6,
                            profitMargin: 47.4
                        },
                        incomeCategories: [
                            { category: "💼 الإيرادات المباشرة", categoryIcon: "💼", totalAmount: 28500.00, voucherCount: 8, avgAmount: 3562.50, dataSource: "تجريبي" },
                            { category: "🛒 إيرادات البيع", categoryIcon: "🛒", totalAmount: 15000.00, voucherCount: 3, avgAmount: 5000.00, dataSource: "تجريبي" },
                            { category: "📌 إيرادات أخرى", categoryIcon: "📌", totalAmount: 5000.00, voucherCount: 1, avgAmount: 5000.00, dataSource: "تجريبي" }
                        ],
                        incomePaymentMethods: [
                            { paymentMethod: "تحويل بنكي", totalAmount: 25000.00, transactionCount: 6, percentage: 51.5 },
                            { paymentMethod: "نقداً", totalAmount: 18500.00, transactionCount: 4, percentage: 38.1 },
                            { paymentMethod: "بطاقة ائتمان", totalAmount: 5000.00, transactionCount: 2, percentage: 10.3 }
                        ],
                        expensePaymentMethods: [
                            { paymentMethod: "تحويل بنكي", totalAmount: 15000.00, transactionCount: 3, percentage: 58.8 },
                            { paymentMethod: "نقداً", totalAmount: 8500.00, transactionCount: 2, percentage: 33.3 },
                            { paymentMethod: "شيك", totalAmount: 2000.00, transactionCount: 1, percentage: 7.8 }
                        ],
                        detailedTransactions: [
                            { type: "income", voucherNo: "IV001", date: new Date(), description: "إيراد خدمات استشارية (تجريبي)", amount: 15000.00, paymentMethod: "تحويل بنكي", category: "💼 الإيرادات المباشرة", dataSource: "تجريبي" },
                            { type: "income", voucherNo: "IV002", date: new Date(), description: "إيراد مبيعات منتجات (تجريبي)", amount: 25000.00, paymentMethod: "نقداً", category: "🛒 إيرادات البيع", dataSource: "تجريبي" },
                            { type: "expense", voucherNo: "EV001", date: new Date(), description: "مصروف رواتب (تجريبي)", amount: 12000.00, paymentMethod: "تحويل بنكي", category: "رواتب", dataSource: "تجريبي" },
                            { type: "expense", voucherNo: "EV002", date: new Date(), description: "مصروف كهرباء (تجريبي)", amount: 3500.00, paymentMethod: "نقداً", category: "مرافق", dataSource: "تجريبي" }
                        ],
                        debug: { 
                            dataSource: "Demo Data - Fallback", 
                            timestamp: new Date().toISOString(),
                            reason: "Server connection failed or data unavailable"
                        }
                    };
                    this.successMessage = 'تم تحميل البيانات التجريبية بنجاح (وضع الطوارئ)';
                    setTimeout(() => { this.successMessage = ''; }, 5000);
                },

                formatCurrency(amount) {
                    if (amount == null || isNaN(amount)) return '0.00 ر.س';
                    return new Intl.NumberFormat('ar-SA', {
                        style: 'currency',
                        currency: 'SAR',
                        minimumFractionDigits: 2
                    }).format(amount);
                },

                formatDate(date) {
                    if (!date) return '';
                    const dateObj = new Date(date);
                    return dateObj.toLocaleDateString('ar-SA');
                },

                toggleDebugMode() {
                    this.debugMode = !this.debugMode;
                    if (this.debugMode) {
                        this.showAdvancedDebugInfo();
                    }
                },

                showAdvancedDebugInfo() {
                    const debugInfo = {
                        system: {
                            timestamp: new Date().toISOString(),
                            userAgent: navigator.userAgent,
                            language: navigator.language,
                            screenResolution: `${screen.width}x${screen.height}`,
                            windowSize: `${window.innerWidth}x${window.innerHeight}`,
                            timezone: Intl.DateTimeFormat().resolvedOptions().timeZone
                        },
                        libraries: {
                            vue: typeof Vue !== 'undefined' ? Vue.version : 'غير متوفر',
                            axios: typeof axios !== 'undefined' ? axios.defaults.headers : 'غير متوفر',
                            bootstrap: typeof bootstrap !== 'undefined' ? 'متوفر' : 'غير متوفر'
                        },
                        application: {
                            selectedPeriod: this.selectedPeriod,
                            selectedDataType: this.selectedDataType,
                            isLoading: this.isLoading,
                            hasErrors: !!this.errorMessage,
                            lastError: this.errorMessage,
                            lastSuccess: this.successMessage,
                            dataStatus: {
                                summary: !!this.financialData.summary,
                                incomeCategories: this.financialData.incomeCategories.length,
                                incomePaymentMethods: this.financialData.incomePaymentMethods.length,
                                expensePaymentMethods: this.financialData.expensePaymentMethods.length,
                                detailedTransactions: this.financialData.detailedTransactions.length
                            }
                        },
                        network: {
                            online: navigator.onLine,
                            connection: navigator.connection ? {
                                type: navigator.connection.effectiveType,
                                downlink: navigator.connection.downlink
                            } : 'غير متوفر'
                        }
                    };
                    
                    console.log('=== ADVANCED DEBUG INFO ===', debugInfo);
                    
                    // Create visual debug panel
                    const debugPanel = document.createElement('div');
                    debugPanel.id = 'advancedDebugPanel';
                    debugPanel.style.cssText = 'position: fixed; top: 20px; left: 20px; width: 400px; max-height: 80vh; overflow-y: auto; background: rgba(0,0,0,0.95); color: #00E676; padding: 20px; border-radius: 15px; font-family: monospace; font-size: 12px; z-index: 9999; border: 2px solid #00E676; box-shadow: 0 10px 30px rgba(0,230,118,0.3);';
                    debugPanel.innerHTML = `
                        <div style="display: flex; justify-content: space-between; align-items: center; margin-bottom: 15px; border-bottom: 1px solid #00E676; padding-bottom: 10px;">
                            <h4 style="margin: 0; color: #00E676;">🔧 التشخيص المتقدم</h4>
                            <button onclick="document.getElementById('advancedDebugPanel').remove()" style="background: #FF1744; color: white; border: none; padding: 5px 10px; border-radius: 5px; cursor: pointer;">✕</button>
                        </div>
                        <div style="margin: 10px 0;"><strong style="color: #FFB74D;">📅 الوقت:</strong> ${debugInfo.system.timestamp}</div>
                        <div style="margin: 10px 0;"><strong style="color: #FFB74D;">📱 الجهاز:</strong> ${debugInfo.system.screenResolution}</div>
                        <div style="margin: 10px 0;"><strong style="color: #FFB74D;">🌐 الاتصال:</strong> ${debugInfo.network.online ? '✅ متصل' : '❌ غير متصل'}</div>
                        <div style="margin: 10px 0;"><strong style="color: #FFB74D;">📚 Vue.js:</strong> ${debugInfo.libraries.vue}</div>
                        <div style="margin: 10px 0;"><strong style="color: #FFB74D;">🔧 النوع:</strong> ${debugInfo.application.selectedDataType}</div>
                        <div style="margin: 10px 0;"><strong style="color: #FFB74D;">📊 البيانات:</strong> ${debugInfo.application.dataStatus.summary ? '✅' : '❌'}</div>
                        <div style="margin: 10px 0;"><strong style="color: #FFB74D;">🏷️ الفئات:</strong> ${debugInfo.application.dataStatus.incomeCategories}</div>
                        <div style="margin: 10px 0;"><strong style="color: #FFB74D;">💳 الدفع:</strong> ${debugInfo.application.dataStatus.incomePaymentMethods + debugInfo.application.dataStatus.expensePaymentMethods}</div>
                        <div style="margin: 10px 0;"><strong style="color: #FFB74D;">📋 المعاملات:</strong> ${debugInfo.application.dataStatus.detailedTransactions}</div>
                        ${debugInfo.application.hasErrors ? `<div style="margin: 10px 0; color: #FF1744;"><strong>❌ الخطأ:</strong> ${debugInfo.application.lastError}</div>` : ''}
                        <div style="margin-top: 15px; padding-top: 10px; border-top: 1px solid #333;">
                            <button onclick="navigator.clipboard.writeText(JSON.stringify(${JSON.stringify(debugInfo)}, null, 2))" style="background: #00CCFF; color: white; border: none; padding: 8px 12px; border-radius: 5px; cursor: pointer; width: 100%;">📋 نسخ البيانات</button>
                        </div>
                    `;
                    document.body.appendChild(debugPanel);
                }
            },
            mounted() {
                console.log('Vue app mounted successfully');
                this.loadFinancialData();
            },
            errorCaptured(err, instance, info) {
                console.error('Vue Component Error:', err);
                console.error('Error Info:', info);
                this.errorMessage = `خطأ في المكون: ${err.message}`;
                this.loadDemoData();
                return false;
            }
        }).$mount('#financialAnalysisApp');

        // Global error handler for Vue
        Vue.config.errorHandler = function (err, vm, info) {
            console.error('Vue Global Error:', err);
            console.error('Component Info:', info);
            showFallbackInterface(`خطأ في Vue.js: ${err.message}`);
        };

        // Fallback initialization
        document.addEventListener('DOMContentLoaded', function() {
            setTimeout(function() {
                if (!document.querySelector('#financialAnalysisApp .__vue__')) {
                    console.warn('Vue app not initialized, showing fallback');
                    showFallbackInterface('فشل في تحميل Vue.js - استخدام وضع الطوارئ');
                }
            }, 3000);
        });
    </script>
</body>
</html>
