<%@ Page Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="DashboardVue.aspx.cs" Inherits="app_myaspxpages_DashboardVue" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="server">
    Dashboard - Vue.js
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="server">
    <!-- Vue.js 2.6.14 -->
    <script src="https://cdn.jsdelivr.net/npm/vue@2.6.14/dist/vue.min.js"></script>
    <!-- Axios for API calls -->
    <script src="https://cdn.jsdelivr.net/npm/axios@0.27.2/dist/axios.min.js"></script>
    <!-- Font Awesome 6.5.1 -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css" rel="stylesheet" />

    <div id="dashboardApp" class="container-fluid mt-4" data-app-role="page" data-content-framework="bootstrap" v-cloak>
        <div class="row">
            <div class="col-12">
                <!-- Header Section -->
                <div class="d-flex justify-content-between align-items-center mb-4">
                    <h1 class="dashboard-title">
                        <i class="fas fa-tachometer-alt me-2"></i>
                        {{ isRtl ? 'لوحة التحكم الذكية' : 'Smart Dashboard' }}
                    </h1>
                    <div class="header-controls">
                        <div class="language-switcher">
                            <button 
                                class="btn-lang" 
                                :class="{ active: !isRtl }" 
                                @click="switchLanguage('en')"
                            >
                                English
                            </button>
                            <button 
                                class="btn-lang" 
                                :class="{ active: isRtl }" 
                                @click="switchLanguage('ar')"
                            >
                                عربي
                            </button>
                        </div>
                        <button 
                            class="btn btn-outline-primary ms-2" 
                            @click="refreshDashboard"
                            :disabled="isLoading"
                        >
                            <i class="fas fa-sync-alt" :class="{ 'fa-spin': isLoading }"></i>
                            {{ isRtl ? 'تحديث' : 'Refresh' }}
                        </button>
                    </div>
                </div>

                <!-- Loading State -->
                <div v-if="isLoading && categories.length === 0" class="text-center py-5">
                    <div class="spinner-border text-primary" role="status">
                        <span class="visually-hidden">{{ isRtl ? 'جاري التحميل...' : 'Loading...' }}</span>
                    </div>
                    <p class="mt-3 text-muted">{{ isRtl ? 'جاري تحميل لوحة التحكم...' : 'Loading dashboard...' }}</p>
                </div>

                <!-- Error State -->
                <div v-if="error" class="alert alert-danger" role="alert">
                    <h5 class="alert-heading">
                        <i class="fas fa-exclamation-triangle me-2"></i>
                        {{ isRtl ? 'خطأ في تحميل البيانات' : 'Error Loading Data' }}
                    </h5>
                    <p>{{ error }}</p>
                    <button class="btn btn-outline-danger" @click="refreshDashboard">
                        <i class="fas fa-retry me-1"></i>
                        {{ isRtl ? 'إعادة المحاولة' : 'Try Again' }}
                    </button>
                </div>

                <!-- Dashboard Categories -->
                <div v-if="!isLoading || categories.length > 0" class="dashboard-sections">
                    <div 
                        v-for="category in categories" 
                        :key="category.id"
                        class="dashboard-section mb-4"
                        :id="'pnlCat_' + category.id"
                    >
                        <div class="card">
                            <div class="card-header" :data-category="category.id">
                                <div class="d-flex align-items-center justify-content-between">
                                    <div class="d-flex align-items-center">
                                        <i :class="category.icon + ' me-2'"></i>
                                        <div>
                                            <h5 class="card-title mb-0">
                                                {{ isRtl ? category.nameAr : category.nameEn }}
                                            </h5>
                                            <small class="text-white-50">
                                                {{ isRtl ? category.nameEn : category.nameAr }}
                                            </small>
                                        </div>
                                    </div>
                                    <div class="category-stats">
                                        <span class="stat">
                                            <i class="fas fa-chart-line me-1"></i>
                                            {{ category.metrics.length }} {{ isRtl ? 'مؤشرات' : 'metrics' }}
                                        </span>
                                    </div>
                                </div>
                                <small v-if="category.description" class="text-white-50 d-block mt-1">
                                    {{ category.description }}
                                </small>
                            </div>
                            
                            <!-- Metrics Grid -->
                            <div class="card-body">
                                <div class="row" v-if="category.metrics.length > 0">
                                    <div 
                                        v-for="metric in category.metrics" 
                                        :key="metric.id"
                                        class="col-md-3 mb-3"
                                    >
                                        <div 
                                            class="card h-100 metric-card" 
                                            :data-metric-id="metric.id"
                                            @click="refreshMetric(metric)"
                                        >
                                            <div class="card-body">
                                                <div class="d-flex align-items-center mb-2">
                                                    <i :class="metric.icon" :style="{ color: metric.color }"></i>
                                                    <h6 class="mb-0 ms-2">{{ metric.description }}</h6>
                                                </div>
                                                <div class="metric-values">
                                                    <div class="current-value">
                                                        <span class="h3" :style="{ color: metric.color }">
                                                            {{ formatValue(metric.currentValue, metric.unitName) }}
                                                        </span>
                                                        <small class="text-muted">{{ metric.unitName }}</small>
                                                    </div>
                                                    <div v-if="metric.monthlyBalance !== 0" class="monthly-trend mt-2">
                                                        <small class="text-muted">
                                                            {{ isRtl ? 'هذا الشهر:' : 'This Month:' }}
                                                        </small>
                                                        <span 
                                                            class="ms-2"
                                                            :class="metric.monthlyBalance > 0 ? 'text-success' : 'text-danger'"
                                                        >
                                                            {{ formatValue(metric.monthlyBalance, metric.unitName) }}
                                                        </span>
                                                    </div>
                                                    <div v-if="metric.subType" class="sub-type mt-1">
                                                        <small class="text-muted">{{ metric.subType }}</small>
                                                    </div>
                                                </div>
                                                <!-- Refresh indicator -->
                                                <div v-if="metric.isRefreshing" class="metric-status">
                                                    <i class="fas fa-spinner fa-spin"></i>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div v-else class="text-center py-4">
                                    <i class="fas fa-chart-bar text-muted mb-2" style="font-size: 2rem;"></i>
                                    <p class="text-muted">{{ isRtl ? 'لا توجد مؤشرات متاحة' : 'No metrics available' }}</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- No Data State -->
                <div v-if="!isLoading && categories.length === 0 && !error" class="text-center py-5">
                    <i class="fas fa-chart-bar text-muted mb-3" style="font-size: 4rem;"></i>
                    <h3 class="text-muted">{{ isRtl ? 'لا توجد فئات متاحة' : 'No Categories Available' }}</h3>
                    <p class="text-muted">{{ isRtl ? 'لا يوجد لديك صلاحيات لعرض أي فئات' : 'You do not have permissions to view any categories' }}</p>
                </div>
            </div>
        </div>
    </div>

    <style>
        [v-cloak] { display: none; }
        
        /* Professional AI-Style Design */
        .dashboard-title {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            font-weight: 700;
            font-size: 2.5rem;
        }

        .header-controls {
            display: flex;
            align-items: center;
            gap: 1rem;
        }

        .language-switcher {
            display: flex;
            background: rgba(255, 255, 255, 0.1);
            border-radius: 25px;
            padding: 4px;
            backdrop-filter: blur(10px);
            border: 1px solid rgba(255, 255, 255, 0.2);
        }

        .btn-lang {
            padding: 8px 16px;
            border: none;
            background: transparent;
            color: #6c757d;
            border-radius: 20px;
            transition: all 0.3s ease;
            font-weight: 500;
        }

        .btn-lang.active {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            box-shadow: 0 4px 15px rgba(102, 126, 234, 0.3);
        }

        .btn-lang:hover:not(.active) {
            background: rgba(102, 126, 234, 0.1);
            color: #495057;
        }

        /* Dashboard Sections */
        .dashboard-section .card {
            border: none;
            background: #fff;
            margin-bottom: 1rem;
            box-shadow: 0 8px 32px rgba(0, 0, 0, 0.1);
            border-radius: 15px;
            overflow: hidden;
        }

        .dashboard-section .card-header {
            background: linear-gradient(135deg, #23272B 0%, #495057 100%);
            border-bottom: none;
            padding: 1.5rem;
            color: white;
        }

        /* Category-specific header gradients */
        .dashboard-section[id^='pnlCat_1'] .card-header { /* Finance */
            background: linear-gradient(135deg, #2C3E50 0%, #3498DB 100%);
        }
        .dashboard-section[id^='pnlCat_2'] .card-header { /* Fleet */
            background: linear-gradient(135deg, #27AE60 0%, #2ECC71 100%);
        }
        .dashboard-section[id^='pnlCat_3'] .card-header { /* Customers (STC) */
            background: linear-gradient(135deg, #8E44AD 0%, #9B59B6 100%);
        }
        .dashboard-section[id^='pnlCat_4'] .card-header { /* Customers */
            background: linear-gradient(135deg, #E67E22 0%, #F39C12 100%);
        }
        .dashboard-section[id^='pnlCat_5'] .card-header { /* Suppliers */
            background: linear-gradient(135deg, #C0392B 0%, #E74C3C 100%);
        }

        .card-title {
            font-weight: 600;
            font-size: 1.25rem;
        }

        .category-stats .stat {
            background: rgba(255, 255, 255, 0.2);
            padding: 0.5rem 1rem;
            border-radius: 20px;
            font-size: 0.85rem;
            backdrop-filter: blur(10px);
        }

        /* Metric Cards */
        .metric-card {
            transition: all 0.3s ease;
            border-radius: 12px;
            border: 1px solid rgba(0,0,0,0.08);
            box-shadow: 0 4px 15px rgba(0,0,0,0.05);
            cursor: pointer;
            position: relative;
            overflow: hidden;
        }

        .metric-card::before {
            content: '';
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background: linear-gradient(135deg, rgba(102, 126, 234, 0.05) 0%, rgba(118, 75, 162, 0.05) 100%);
            opacity: 0;
            transition: opacity 0.3s ease;
        }

        .metric-card:hover {
            transform: translateY(-5px);
            box-shadow: 0 12px 30px rgba(0,0,0,0.15);
        }

        .metric-card:hover::before {
            opacity: 1;
        }

        .metric-card .card-body {
            position: relative;
            z-index: 1;
        }

        .metric-card h6 {
            color: #6c757d;
            font-size: 0.9rem;
            text-transform: uppercase;
            letter-spacing: 0.5px;
            margin: 0;
            font-weight: 600;
        }

        .metric-card .h3 {
            font-weight: 700;
            margin-top: 0.5rem;
            direction: ltr;
            text-align: inherit;
        }

        .metric-card i {
            font-size: 1.2rem;
            margin-right: 0.5rem;
        }

        .metric-status {
            position: absolute;
            top: 8px;
            right: 8px;
            display: flex;
            align-items: center;
            gap: 8px;
            font-size: 12px;
            z-index: 2;
        }

        /* RTL Support */
        [dir="rtl"] .metric-card i {
            margin-right: 0;
            margin-left: 0.5rem;
        }

        [dir="rtl"] .dashboard-section .ms-2 {
            margin-right: 0.5rem !important;
            margin-left: 0 !important;
        }

        [dir="rtl"] .me-2 {
            margin-left: 0.5rem !important;
            margin-right: 0 !important;
        }

        [dir="rtl"] .text-start {
            text-align: right !important;
        }

        [dir="rtl"] .metric-status {
            right: auto;
            left: 8px;
        }

        /* Responsive Design */
        @media (max-width: 768px) {
            .dashboard-title {
                font-size: 1.8rem;
            }
            
            .header-controls {
                flex-direction: column;
                gap: 0.5rem;
            }
            
            .metric-card {
                margin-bottom: 1rem;
            }
        }

        /* Loading Animation */
        .fa-spin {
            animation: fa-spin 1s infinite linear;
        }

        @keyframes fa-spin {
            0% { transform: rotate(0deg); }
            100% { transform: rotate(360deg); }
        }

        /* Just Updated Animation */
        .metric-card.just-updated {
            animation: highlight-update 1s cubic-bezier(0.4, 0, 0.2, 1);
        }

        @keyframes highlight-update {
            0% { 
                background-color: rgba(40, 167, 69, 0.1);
                transform: scale(1.02);
            }
            100% { 
                background-color: transparent;
                transform: scale(1);
            }
        }
    </style>

    <script>
        new Vue({
            el: '#dashboardApp',
            data: {
                categories: [],
                isLoading: true,
                error: null,
                isRtl: false,
                currentLanguage: 'en'
            },
            mounted() {
                this.initializeLanguage();
                this.loadDashboard();
            },
            methods: {
                initializeLanguage() {
                    // Check document direction or saved preference
                    const savedLang = localStorage.getItem('dashboardLanguage') || 'en';
                    this.switchLanguage(savedLang);
                },
                
                switchLanguage(lang) {
                    this.currentLanguage = lang;
                    this.isRtl = lang === 'ar';
                    document.documentElement.dir = this.isRtl ? 'rtl' : 'ltr';
                    document.documentElement.lang = lang;
                    localStorage.setItem('dashboardLanguage', lang);
                },
                
                async loadDashboard() {
                    try {
                        this.isLoading = true;
                        this.error = null;
                        
                        const response = await axios.post('DashboardVue.aspx/GetDashboardData', {}, {
                            headers: {
                                'Content-Type': 'application/json'
                            }
                        });
                        
                        if (response.data && response.data.d) {
                            this.categories = response.data.d;
                        } else {
                            throw new Error('Invalid response format');
                        }
                    } catch (error) {
                        console.error('Error loading dashboard:', error);
                        this.error = this.isRtl ? 
                            'فشل في تحميل البيانات. يرجى المحاولة مرة أخرى.' : 
                            'Failed to load dashboard data. Please try again.';
                    } finally {
                        this.isLoading = false;
                    }
                },
                
                async refreshDashboard() {
                    await this.loadDashboard();
                },
                
                async refreshMetric(metric) {
                    try {
                        this.$set(metric, 'isRefreshing', true);
                        
                        const response = await axios.post('DashboardVue.aspx/RefreshMetric', {
                            categoryId: metric.categoryId,
                            metricId: metric.orderId
                        }, {
                            headers: {
                                'Content-Type': 'application/json'
                            }
                        });
                        
                        if (response.data && response.data.d) {
                            // Update metric data
                            Object.assign(metric, response.data.d);
                            
                            // Add visual feedback
                            const metricElement = document.querySelector(`[data-metric-id="${metric.id}"]`);
                            if (metricElement) {
                                metricElement.classList.add('just-updated');
                                setTimeout(() => {
                                    metricElement.classList.remove('just-updated');
                                }, 1000);
                            }
                        }
                    } catch (error) {
                        console.error('Error refreshing metric:', error);
                    } finally {
                        this.$set(metric, 'isRefreshing', false);
                    }
                },
                
                formatValue(value, unitType) {
                    if (!value && value !== 0) return '0';
                    
                    const numValue = parseFloat(value);
                    if (isNaN(numValue)) return value;
                    
                    if (unitType && (unitType.includes('دينار') || unitType.includes('ريال') || unitType.includes('دولار'))) {
                        return new Intl.NumberFormat('en-US', { 
                            minimumFractionDigits: 3,
                            maximumFractionDigits: 3 
                        }).format(numValue);
                    }
                    
                    if (unitType && unitType.includes('سيارة')) {
                        return Math.round(numValue).toString();
                    }
                    
                    return new Intl.NumberFormat('en-US', { 
                        minimumFractionDigits: 0,
                        maximumFractionDigits: 2 
                    }).format(numValue);
                }
            }
        });
    </script>
</asp:Content>
