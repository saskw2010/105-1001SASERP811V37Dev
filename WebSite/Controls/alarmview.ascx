<%@ Control Language="VB" AutoEventWireup="true" CodeFile="alarmview.ascx.vb" Inherits="Controls_alarmview" %>

<!-- Modern Car Fleet Dashboard with Alarm Monitoring -->
<div class="modern-alarm-dashboard">
    <!-- Modern CSS Framework -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/chartjs-adapter-date-fns"></script>
    
    <style>
        .modern-alarm-dashboard {
            --primary-color: #1976d2;
            --secondary-color: #424242;
            --accent-color: #ff5722;
            --success-color: #4caf50;
            --warning-color: #ff9800;
            --error-color: #f44336;
            --info-color: #2196f3;
            --surface-color: #ffffff;
            --background-color: #f5f5f5;
            --text-primary: #212121;
            --text-secondary: #757575;
            --border-radius: 12px;
            --elevation-1: 0 2px 4px rgba(0,0,0,0.1);
            --elevation-2: 0 4px 8px rgba(0,0,0,0.12);
            --elevation-3: 0 8px 16px rgba(0,0,0,0.15);
            --transition-fast: 0.2s cubic-bezier(0.4, 0, 0.2, 1);
            --transition-standard: 0.3s cubic-bezier(0.4, 0, 0.2, 1);
        }

        .dashboard-container {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
            padding: 20px;
            direction: rtl;
        }

        .dashboard-card {
            background: var(--surface-color);
            border-radius: var(--border-radius);
            box-shadow: var(--elevation-2);
            margin-bottom: 24px;
            overflow: hidden;
            transition: var(--transition-standard);
        }

        .dashboard-card:hover {
            box-shadow: var(--elevation-3);
            transform: translateY(-2px);
        }

        .card-header {
            background: linear-gradient(135deg, var(--primary-color), #1565c0);
            color: white;
            padding: 20px;
            display: flex;
            align-items: center;
            justify-content: space-between;
            flex-wrap: wrap;
            gap: 16px;
        }

        .card-title {
            font-size: 24px;
            font-weight: 500;
            margin: 0;
            display: flex;
            align-items: center;
            gap: 12px;
        }

        .refresh-button {
            background: rgba(255, 255, 255, 0.1);
            border: 1px solid rgba(255, 255, 255, 0.3);
            color: white;
            border-radius: 8px;
            padding: 8px 16px;
            font-size: 14px;
            cursor: pointer;
            transition: var(--transition-fast);
            display: flex;
            align-items: center;
            gap: 6px;
        }

        .refresh-button:hover {
            background: rgba(255, 255, 255, 0.2);
            border-color: rgba(255, 255, 255, 0.5);
        }

        .stats-section {
            padding: 24px;
            background: #f8f9fa;
            border-bottom: 1px solid #dee2e6;
        }

        .stats-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
            gap: 20px;
        }

        .stat-card {
            background: var(--surface-color);
            border-radius: 12px;
            padding: 20px;
            text-align: center;
            box-shadow: var(--elevation-1);
            transition: var(--transition-standard);
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
            background: linear-gradient(90deg, var(--primary-color), var(--accent-color));
        }

        .stat-card:hover {
            transform: translateY(-4px);
            box-shadow: var(--elevation-2);
        }

        .stat-icon {
            width: 48px;
            height: 48px;
            border-radius: 50%;
            display: flex;
            align-items: center;
            justify-content: center;
            margin: 0 auto 12px;
            font-size: 24px;
            color: white;
        }

        .stat-icon.status { background: linear-gradient(135deg, #4caf50, #8bc34a); }
        .stat-icon.type { background: linear-gradient(135deg, #2196f3, #03a9f4); }
        .stat-icon.branch { background: linear-gradient(135deg, #ff9800, #ffc107); }
        .stat-icon.total { background: linear-gradient(135deg, #9c27b0, #e91e63); }

        .stat-value {
            font-size: 32px;
            font-weight: 700;
            color: var(--text-primary);
            margin-bottom: 8px;
            display: block;
        }

        .stat-label {
            font-size: 14px;
            color: var(--text-secondary);
            font-weight: 500;
        }

        .charts-section {
            padding: 24px;
        }

        .charts-grid {
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 24px;
            margin-bottom: 24px;
        }

        .chart-container {
            background: var(--surface-color);
            border-radius: var(--border-radius);
            padding: 20px;
            box-shadow: var(--elevation-1);
            position: relative;
        }

        .chart-title {
            font-size: 18px;
            font-weight: 600;
            color: var(--text-primary);
            margin-bottom: 20px;
            text-align: center;
            display: flex;
            align-items: center;
            justify-content: center;
            gap: 8px;
        }

        .chart-canvas {
            max-height: 400px;
            margin: 0 auto;
        }

        .loading-overlay {
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background: rgba(255, 255, 255, 0.9);
            display: flex;
            align-items: center;
            justify-content: center;
            border-radius: var(--border-radius);
            opacity: 0;
            visibility: hidden;
            transition: var(--transition-standard);
        }

        .loading-overlay.active {
            opacity: 1;
            visibility: visible;
        }

        .loading-spinner {
            width: 40px;
            height: 40px;
            border: 4px solid #e0e0e0;
            border-top: 4px solid var(--primary-color);
            border-radius: 50%;
            animation: spin 1s linear infinite;
        }

        @keyframes spin {
            0% { transform: rotate(0deg); }
            100% { transform: rotate(360deg); }
        }

        .data-table-section {
            background: var(--surface-color);
            border-radius: var(--border-radius);
            margin-top: 24px;
            overflow: hidden;
            box-shadow: var(--elevation-1);
        }

        .table-header {
            background: linear-gradient(135deg, #673ab7, #9c27b0);
            color: white;
            padding: 16px 24px;
            font-size: 18px;
            font-weight: 500;
            display: flex;
            align-items: center;
            gap: 8px;
        }

        .modern-table {
            width: 100%;
            border-collapse: collapse;
        }

        .modern-table th {
            background: #f8f9fa;
            padding: 12px 16px;
            text-align: right;
            font-weight: 600;
            color: var(--text-primary);
            border-bottom: 2px solid #dee2e6;
        }

        .modern-table td {
            padding: 12px 16px;
            border-bottom: 1px solid #f0f0f0;
            transition: var(--transition-fast);
        }

        .modern-table tr:hover td {
            background: rgba(25, 118, 210, 0.04);
        }

        /* Alert/Status Indicators */
        .status-indicator {
            display: inline-flex;
            align-items: center;
            gap: 6px;
            padding: 4px 12px;
            border-radius: 16px;
            font-size: 12px;
            font-weight: 500;
        }

        .status-indicator.active {
            background: rgba(76, 175, 80, 0.1);
            color: var(--success-color);
        }

        .status-indicator.inactive {
            background: rgba(244, 67, 54, 0.1);
            color: var(--error-color);
        }

        .status-indicator.maintenance {
            background: rgba(255, 152, 0, 0.1);
            color: var(--warning-color);
        }

        /* Responsive Design */
        @media (max-width: 1200px) {
            .charts-grid {
                grid-template-columns: 1fr;
            }
        }

        @media (max-width: 768px) {
            .dashboard-container {
                padding: 10px;
            }
            
            .card-header {
                flex-direction: column;
                align-items: stretch;
            }
            
            .stats-grid {
                grid-template-columns: repeat(2, 1fr);
            }
            
            .charts-section {
                padding: 16px;
            }
        }

        /* RTL Enhancements */
        [dir="rtl"] .card-title {
            flex-direction: row-reverse;
        }

        [dir="rtl"] .chart-title {
            flex-direction: row-reverse;
        }

        [dir="rtl"] .table-header {
            flex-direction: row-reverse;
        }

        /* Animation Classes */
        .fade-in {
            animation: fadeIn 0.6s ease-out;
        }

        .slide-up {
            animation: slideUp 0.5s ease-out;
        }

        @keyframes fadeIn {
            from { opacity: 0; transform: translateY(20px); }
            to { opacity: 1; transform: translateY(0); }
        }

        @keyframes slideUp {
            from { opacity: 0; transform: translateY(30px); }
            to { opacity: 1; transform: translateY(0); }
        }
    </style>

    <div class="dashboard-container">
        <!-- Main Dashboard Card -->
        <div class="dashboard-card fade-in">
            <!-- Header -->
            <div class="card-header">
                <h2 class="card-title">
                    <i class="fas fa-car"></i>
                    لوحة مراقبة الأسطول والإنذارات
                </h2>
                <button class="refresh-button" onclick="refreshDashboard()">
                    <i class="fas fa-sync-alt"></i>
                    تحديث البيانات
                </button>
            </div>

            <!-- Statistics Section -->
            <div class="stats-section">
                <div class="stats-grid">
                    <div class="stat-card slide-up">
                        <div class="stat-icon status">
                            <i class="fas fa-car"></i>
                        </div>
                        <span class="stat-value">
                            <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
                        </span>
                        <div class="stat-label">حالة السيارات</div>
                    </div>
                    
                    <div class="stat-card slide-up">
                        <div class="stat-icon type">
                            <i class="fas fa-list"></i>
                        </div>
                        <span class="stat-value">
                            <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
                        </span>
                        <div class="stat-label">أنواع السيارات</div>
                    </div>
                    
                    <div class="stat-card slide-up">
                        <div class="stat-icon branch">
                            <i class="fas fa-building"></i>
                        </div>
                        <span class="stat-value">
                            <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>
                        </span>
                        <div class="stat-label">الفروع النشطة</div>
                    </div>
                    
                    <div class="stat-card slide-up">
                        <div class="stat-icon total">
                            <i class="fas fa-chart-bar"></i>
                        </div>
                        <span class="stat-value">
                            <asp:Label ID="Label4" runat="server" Text="0"></asp:Label>
                        </span>
                        <div class="stat-label">إجمالي التقارير</div>
                    </div>
                </div>
            </div>

            <!-- Charts Section -->
            <div class="charts-section">
                <div class="charts-grid">
                    <!-- Car Status Chart -->
                    <div class="chart-container">
                        <div class="chart-title">
                            <i class="fas fa-chart-column"></i>
                            إحصائية حالات السيارات
                        </div>
                        <canvas id="carStatusChart" class="chart-canvas"></canvas>
                        <div class="loading-overlay" id="chart1Loading">
                            <div class="loading-spinner"></div>
                        </div>
                    </div>

                    <!-- Car Types Chart -->
                    <div class="chart-container">
                        <div class="chart-title">
                            <i class="fas fa-chart-bar"></i>
                            إحصائية أنواع السيارات
                        </div>
                        <canvas id="carTypesChart" class="chart-canvas"></canvas>
                        <div class="loading-overlay" id="chart2Loading">
                            <div class="loading-spinner"></div>
                        </div>
                    </div>
                </div>

                <!-- Additional Analytics -->
                <div class="chart-container">
                    <div class="chart-title">
                        <i class="fas fa-chart-pie"></i>
                        توزيع الأسطول حسب الفروع
                    </div>
                    <canvas id="fleetDistributionChart" class="chart-canvas" style="max-height: 300px;"></canvas>
                    <div class="loading-overlay" id="chart3Loading">
                        <div class="loading-spinner"></div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Data Table Section -->
        <div class="data-table-section slide-up">
            <div class="table-header">
                <i class="fas fa-table"></i>
                بيانات الأسطول التفصيلية
            </div>
            <div style="overflow-x: auto; padding: 20px;">
                <asp:GridView ID="gvFleetData" runat="server" CssClass="modern-table" 
                            AutoGenerateColumns="false" EmptyDataText="لا توجد بيانات للعرض">
                    <Columns>
                        <asp:BoundField DataField="Car_No" HeaderText="رقم السيارة" />
                        <asp:BoundField DataField="carstutus_name" HeaderText="الحالة" />
                        <asp:BoundField DataField="Styl_Nm" HeaderText="النوع" />
                        <asp:BoundField DataField="carclassname" HeaderText="الفئة" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

    <!-- Hidden Data Sources for Charts -->
    <div style="display: none;">
        <asp:SqlDataSource ID="SqlDataSource2" runat="server"
            SelectCommand="SELECT count([Car_No]) as valuer, [carstutus_name] FROM [Carallinformation] group by [carstutus_name]">
        </asp:SqlDataSource>
        
        <asp:SqlDataSource ID="SqlDataSource3" runat="server"
            SelectCommand="SELECT count([Car_No]) as valuer, [Styl_Nm] FROM [Carallinformation] group by [Styl_Nm]">
        </asp:SqlDataSource>
        
        <asp:SqlDataSource ID="SqlDataSource5" runat="server"
            SelectCommand="SELECT * FROM [Carallinformation]">
        </asp:SqlDataSource>

        <!-- Hidden GridViews for data binding -->
        <asp:GridView ID="gvCarStatus" runat="server" DataSourceID="SqlDataSource2" style="display: none;" />
        <asp:GridView ID="gvCarTypes" runat="server" DataSourceID="SqlDataSource3" style="display: none;" />
    </div>

    <!-- Modern JavaScript for Chart Integration -->
    <script>
        let carStatusChart, carTypesChart, fleetDistributionChart;

        document.addEventListener('DOMContentLoaded', function() {
            initializeCharts();
            
            // Auto-refresh every 5 minutes
            setInterval(refreshDashboard, 300000);
            
            console.log('Modern Car Fleet Dashboard initialized');
        });

        function initializeCharts() {
            // Car Status Chart (Column Chart)
            const ctx1 = document.getElementById('carStatusChart').getContext('2d');
            carStatusChart = new Chart(ctx1, {
                type: 'bar',
                data: {
                    labels: [],
                    datasets: [{
                        label: 'عدد السيارات',
                        data: [],
                        backgroundColor: [
                            'rgba(76, 175, 80, 0.8)',   // Active - Green
                            'rgba(244, 67, 54, 0.8)',   // Inactive - Red  
                            'rgba(255, 152, 0, 0.8)',   // Maintenance - Orange
                            'rgba(33, 150, 243, 0.8)',  // Available - Blue
                            'rgba(156, 39, 176, 0.8)'   // Reserved - Purple
                        ],
                        borderColor: [
                            'rgba(76, 175, 80, 1)',
                            'rgba(244, 67, 54, 1)',
                            'rgba(255, 152, 0, 1)',
                            'rgba(33, 150, 243, 1)',
                            'rgba(156, 39, 176, 1)'
                        ],
                        borderWidth: 2,
                        borderRadius: 8
                    }]
                },
                options: {
                    responsive: true,
                    maintainAspectRatio: false,
                    plugins: {
                        legend: {
                            display: false
                        },
                        tooltip: {
                            backgroundColor: 'rgba(0, 0, 0, 0.8)',
                            titleColor: 'white',
                            bodyColor: 'white',
                            cornerRadius: 8
                        }
                    },
                    scales: {
                        y: {
                            beginAtZero: true,
                            grid: {
                                color: 'rgba(0, 0, 0, 0.1)'
                            }
                        },
                        x: {
                            grid: {
                                display: false
                            }
                        }
                    }
                }
            });

            // Car Types Chart (Horizontal Bar Chart)
            const ctx2 = document.getElementById('carTypesChart').getContext('2d');
            carTypesChart = new Chart(ctx2, {
                type: 'horizontalBar',
                data: {
                    labels: [],
                    datasets: [{
                        label: 'عدد السيارات',
                        data: [],
                        backgroundColor: 'rgba(33, 150, 243, 0.8)',
                        borderColor: 'rgba(33, 150, 243, 1)',
                        borderWidth: 2
                    }]
                },
                options: {
                    responsive: true,
                    maintainAspectRatio: false,
                    indexAxis: 'y',
                    plugins: {
                        legend: {
                            display: false
                        }
                    },
                    scales: {
                        x: {
                            beginAtZero: true
                        }
                    }
                }
            });

            // Fleet Distribution Chart (Pie Chart)
            const ctx3 = document.getElementById('fleetDistributionChart').getContext('2d');
            fleetDistributionChart = new Chart(ctx3, {
                type: 'doughnut',
                data: {
                    labels: ['فرع الرياض', 'فرع جدة', 'فرع الدمام', 'فرع المدينة', 'فروع أخرى'],
                    datasets: [{
                        data: [30, 25, 20, 15, 10],
                        backgroundColor: [
                            'rgba(25, 118, 210, 0.8)',
                            'rgba(255, 87, 34, 0.8)',
                            'rgba(76, 175, 80, 0.8)',
                            'rgba(255, 152, 0, 0.8)',
                            'rgba(156, 39, 176, 0.8)'
                        ],
                        borderWidth: 2,
                        borderColor: '#fff'
                    }]
                },
                options: {
                    responsive: true,
                    maintainAspectRatio: false,
                    plugins: {
                        legend: {
                            position: 'bottom',
                            labels: {
                                padding: 20,
                                usePointStyle: true
                            }
                        }
                    }
                }
            });

            // Load real data
            loadChartData();
        }

        function loadChartData() {
            // Show loading overlays
            document.getElementById('chart1Loading').classList.add('active');
            document.getElementById('chart2Loading').classList.add('active');
            document.getElementById('chart3Loading').classList.add('active');

            // Simulate data loading (replace with actual AJAX calls)
            setTimeout(() => {
                // Sample data - replace with server data
                updateCarStatusChart(['نشط', 'غير نشط', 'صيانة', 'متاح', 'محجوز'], [45, 12, 8, 25, 10]);
                updateCarTypesChart(['تويوتا', 'نيسان', 'هونداي', 'كيا', 'فورد'], [30, 25, 20, 15, 10]);
                
                // Hide loading overlays
                document.getElementById('chart1Loading').classList.remove('active');
                document.getElementById('chart2Loading').classList.remove('active');
                document.getElementById('chart3Loading').classList.remove('active');
            }, 2000);
        }

        function updateCarStatusChart(labels, data) {
            carStatusChart.data.labels = labels;
            carStatusChart.data.datasets[0].data = data;
            carStatusChart.update('active');
        }

        function updateCarTypesChart(labels, data) {
            carTypesChart.data.labels = labels;
            carTypesChart.data.datasets[0].data = data;
            carTypesChart.update('active');
        }

        function refreshDashboard() {
            // Show refresh animation
            const refreshBtn = document.querySelector('.refresh-button i');
            refreshBtn.style.animation = 'spin 1s linear infinite';
            
            // Reload chart data
            loadChartData();
            
            // Show success message
            setTimeout(() => {
                refreshBtn.style.animation = '';
                showNotification('تم تحديث البيانات بنجاح', 'success');
            }, 2000);
        }

        function showNotification(message, type) {
            const notification = document.createElement('div');
            notification.style.cssText = `
                position: fixed;
                top: 20px;
                left: 50%;
                transform: translateX(-50%);
                background: ${type === 'success' ? '#4caf50' : '#f44336'};
                color: white;
                padding: 12px 24px;
                border-radius: 8px;
                box-shadow: 0 4px 8px rgba(0,0,0,0.15);
                z-index: 1000;
                font-weight: 500;
            `;
            notification.textContent = message;
            
            document.body.appendChild(notification);
            
            setTimeout(() => {
                notification.remove();
            }, 3000);
        }

        // Export functionality
        function exportDashboard(format) {
            switch(format) {
                case 'pdf':
                    window.print();
                    break;
                case 'excel':
                    // Implement Excel export
                    showNotification('تصدير Excel قيد التطوير', 'info');
                    break;
                case 'image':
                    // Implement image export
                    showNotification('تصدير الصورة قيد التطوير', 'info');
                    break;
            }
        }
    </script>
</div>