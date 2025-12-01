<%@ Control Language="VB" AutoEventWireup="true" CodeFile="schoolview.ascx.vb" Inherits="Controls_schoolview" %>

<!-- Modern School Statistics Dashboard with Charts.js -->

<style>
    .school-dashboard {
        background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
        border-radius: 20px;
        padding: 30px;
        box-shadow: 0 20px 40px rgba(102, 126, 234, 0.3);
        margin: 20px 0;
        position: relative;
        overflow: hidden;
    }

    .school-dashboard::before {
        content: '';
        position: absolute;
        top: -50%;
        left: -50%;
        width: 200%;
        height: 200%;
        background: linear-gradient(45deg, rgba(255,255,255,0.1) 25%, transparent 25%, transparent 75%, rgba(255,255,255,0.1) 75%, rgba(255,255,255,0.1)),
                    linear-gradient(45deg, rgba(255,255,255,0.1) 25%, transparent 25%, transparent 75%, rgba(255,255,255,0.1) 75%, rgba(255,255,255,0.1));
        background-size: 60px 60px;
        background-position: 0 0, 30px 30px;
        animation: move 20s linear infinite;
        z-index: 1;
    }

    @keyframes move {
        0% { transform: translate(-50%, -50%) rotate(0deg); }
        100% { transform: translate(-50%, -50%) rotate(360deg); }
    }

    .dashboard-header {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 15px;
        padding: 25px;
        margin-bottom: 30px;
        box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(10px);
        border: 1px solid rgba(255, 255, 255, 0.2);
        position: relative;
        z-index: 2;
    }

    .dashboard-title {
        font-size: 2.5rem;
        font-weight: 700;
        background: linear-gradient(135deg, #667eea, #764ba2);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        text-align: center;
        margin: 0;
        text-shadow: 2px 2px 4px rgba(0,0,0,0.1);
    }

    .dashboard-subtitle {
        text-align: center;
        color: #64748b;
        font-size: 1.1rem;
        margin-top: 10px;
    }

    .charts-container {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(400px, 1fr));
        gap: 30px;
        position: relative;
        z-index: 2;
    }

    .chart-card {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 25px;
        box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
        transition: all 0.3s ease;
        backdrop-filter: blur(10px);
        border: 1px solid rgba(255, 255, 255, 0.2);
        position: relative;
        overflow: hidden;
    }

    .chart-card:hover {
        transform: translateY(-10px);
        box-shadow: 0 25px 50px rgba(0, 0, 0, 0.2);
    }

    .chart-card::before {
        content: '';
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        height: 4px;
        background: linear-gradient(90deg, #667eea, #764ba2, #f093fb, #f5576c);
        border-radius: 20px 20px 0 0;
    }

    .chart-title {
        font-size: 1.4rem;
        font-weight: 600;
        color: #1e293b;
        margin-bottom: 20px;
        text-align: center;
        padding-bottom: 15px;
        border-bottom: 2px solid #e2e8f0;
    }

    .chart-wrapper {
        position: relative;
        height: 400px;
        width: 100%;
    }

    .chart-large {
        height: 600px;
    }

    .loading-spinner {
        display: inline-block;
        width: 40px;
        height: 40px;
        border: 4px solid #f3f3f3;
        border-top: 4px solid #667eea;
        border-radius: 50%;
        animation: spin 1s linear infinite;
        margin: 20px auto;
    }

    @keyframes spin {
        0% { transform: rotate(0deg); }
        100% { transform: rotate(360deg); }
    }

    .stats-summary {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 15px;
        padding: 25px;
        margin-bottom: 30px;
        text-align: center;
        backdrop-filter: blur(10px);
        border: 1px solid rgba(255, 255, 255, 0.2);
        position: relative;
        z-index: 2;
    }

    .stats-grid {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
        gap: 20px;
        margin-top: 20px;
    }

    .stat-item {
        background: linear-gradient(135deg, #667eea, #764ba2);
        color: white;
        padding: 20px;
        border-radius: 15px;
        text-align: center;
        box-shadow: 0 10px 20px rgba(102, 126, 234, 0.3);
        transition: transform 0.3s ease;
    }

    .stat-item:hover {
        transform: scale(1.05);
    }

    .stat-number {
        font-size: 2rem;
        font-weight: 700;
        margin-bottom: 5px;
    }

    .stat-label {
        font-size: 0.9rem;
        opacity: 0.9;
    }

    .refresh-btn {
        background: linear-gradient(135deg, #667eea, #764ba2);
        color: white;
        border: none;
        padding: 12px 30px;
        border-radius: 25px;
        font-weight: 600;
        cursor: pointer;
        transition: all 0.3s ease;
        box-shadow: 0 5px 15px rgba(102, 126, 234, 0.4);
        margin: 20px auto;
        display: block;
    }

    .refresh-btn:hover {
        transform: translateY(-2px);
        box-shadow: 0 8px 25px rgba(102, 126, 234, 0.6);
    }

    .error-message {
        background: #fee2e2;
        color: #dc2626;
        padding: 15px;
        border-radius: 10px;
        text-align: center;
        margin: 20px 0;
        border-left: 4px solid #dc2626;
    }

    /* Arabic RTL Support */
    .rtl {
        direction: rtl;
        text-align: right;
    }

    .rtl .chart-title {
        text-align: center;
    }

    /* Responsive Design */
    @media (max-width: 768px) {
        .charts-container {
            grid-template-columns: 1fr;
        }
        
        .dashboard-title {
            font-size: 2rem;
        }
        
        .chart-wrapper {
            height: 300px;
        }
        
        .chart-large {
            height: 400px;
        }
    }
</style>

<div class="school-dashboard rtl">
    <div class="dashboard-header">
        <h1 class="dashboard-title">
            <i class="fas fa-graduation-cap" style="margin-left: 15px;"></i>
            لوحة إحصائيات المدرسة
        </h1>
        <p class="dashboard-subtitle">نظرة شاملة على بيانات الطلاب والإحصائيات</p>
    </div>

    <!-- Loading Panel -->
    <div id="loadingPanel" class="text-center" style="display: none;">
        <div class="loading-spinner"></div>
        <p>جاري تحميل البيانات...</p>
    </div>

    <!-- Statistics Summary -->
    <div class="stats-summary">
        <h3><i class="fas fa-chart-bar" style="margin-left: 10px;"></i>ملخص الإحصائيات</h3>
        <div class="stats-grid">
            <div class="stat-item">
                <div class="stat-number" id="totalStudents">0</div>
                <div class="stat-label">إجمالي الطلاب</div>
            </div>
            <div class="stat-item">
                <div class="stat-number" id="totalBranches">0</div>
                <div class="stat-label">عدد الفروع</div>
            </div>
            <div class="stat-item">
                <div class="stat-number" id="totalNationalities">0</div>
                <div class="stat-label">عدد الجنسيات</div>
            </div>
            <div class="stat-item">
                <div class="stat-number" id="currentYear">2024</div>
                <div class="stat-label">العام الدراسي</div>
            </div>
        </div>
    </div>

    <!-- Charts Container -->
    <div class="charts-container">
        <!-- Students by Branch Chart -->
        <div class="chart-card">
            <h3 class="chart-title">
                <i class="fas fa-building" style="margin-left: 10px; color: #667eea;"></i>
                إحصائية الطلاب حسب الفرع
            </h3>
            <div class="chart-wrapper">
                <canvas id="branchChart"></canvas>
            </div>
        </div>

        <!-- Students by Gender Chart -->
        <div class="chart-card">
            <h3 class="chart-title">
                <i class="fas fa-users" style="margin-left: 10px; color: #f093fb;"></i>
                إحصائية الطلاب حسب النوع
            </h3>
            <div class="chart-wrapper">
                <canvas id="genderChart"></canvas>
            </div>
        </div>

        <!-- Students by Status Chart -->
        <div class="chart-card">
            <h3 class="chart-title">
                <i class="fas fa-user-graduate" style="margin-left: 10px; color: #f5576c;"></i>
                إحصائية الطلاب حسب الصفة
            </h3>
            <div class="chart-wrapper">
                <canvas id="statusChart"></canvas>
            </div>
        </div>

        <!-- Students by Nationality Chart (Large) -->
        <div class="chart-card" style="grid-column: 1 / -1;">
            <h3 class="chart-title">
                <i class="fas fa-globe" style="margin-left: 10px; color: #764ba2;"></i>
                إحصائية الطلاب حسب الجنسية
            </h3>
            <div class="chart-wrapper chart-large">
                <canvas id="nationalityChart"></canvas>
            </div>
        </div>
    </div>

    <!-- Refresh Button -->
    <button type="button" class="refresh-btn" onclick="refreshAllCharts()">
        <i class="fas fa-sync-alt" style="margin-left: 8px;"></i>
        تحديث البيانات
    </button>

    <!-- Hidden Data Sources -->
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
        SelectCommand="SELECT [StudentCode],[FirstName1], [ClassClassDesc1], [GradeShortDesc1], [StageShortDesc1], [ThebranchDesc1], [GenderGender], [acdAcademicYear] FROM [studentcontroller]" />
    
    <asp:SqlDataSource ID="SqlDataSource2" runat="server"
        SelectCommand="SELECT count([StudentCode]) as valuer, [ThebranchDesc1] FROM [studentcontroller] group by [ThebranchDesc1] order by count([StudentCode]) desc" />
    
    <asp:SqlDataSource ID="SqlDataSource3" runat="server"
        SelectCommand="SELECT count([StudentCode]) as valuer, [GenderGender] FROM [studentcontroller] group by [GenderGender] order by count([StudentCode]) desc" />
    
    <asp:SqlDataSource ID="SqlDataSource4z" runat="server"
        SelectCommand="SELECT count([StudentCode]) as valuer, [studentsefastudentsefaar] FROM [studentcontroller] group by [studentsefastudentsefaar] order by count([StudentCode]) desc" />
    
    <asp:SqlDataSource ID="SqlDataSource4x" runat="server"
        SelectCommand="SELECT count([StudentCode]) as valuer, [Cntry_Cntry_Nm] FROM [studentcontroller] group by [Cntry_Cntry_Nm] order by count([StudentCode]) desc" />

    <!-- Hidden fields for data -->
    <asp:HiddenField ID="hdnBranchData" runat="server" />
    <asp:HiddenField ID="hdnGenderData" runat="server" />
    <asp:HiddenField ID="hdnStatusData" runat="server" />
    <asp:HiddenField ID="hdnNationalityData" runat="server" />
</div>

<!-- Include Chart.js Library -->
<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
<script src="https://cdn.jsdelivr.net/npm/chartjs-plugin-datalabels@2"></script>

<script>
// Global chart instances
let branchChart, genderChart, statusChart, nationalityChart;

// Initialize all charts when page loads
document.addEventListener('DOMContentLoaded', function() {
    initializeCharts();
    updateStatsSummary();
});

// Chart configurations
const chartColors = {
    primary: ['#667eea', '#764ba2', '#f093fb', '#f5576c', '#4facfe', '#00f2fe'],
    gradients: [
        'linear-gradient(135deg, #667eea 0%, #764ba2 100%)',
        'linear-gradient(135deg, #f093fb 0%, #f5576c 100%)',
        'linear-gradient(135deg, #4facfe 0%, #00f2fe 100%)',
        'linear-gradient(135deg, #43e97b 0%, #38f9d7 100%)'
    ]
};

const defaultOptions = {
    responsive: true,
    maintainAspectRatio: false,
    plugins: {
        legend: {
            position: 'bottom',
            labels: {
                padding: 20,
                usePointStyle: true,
                font: {
                    size: 12,
                    family: "'Segoe UI', Tahoma, Geneva, Verdana, sans-serif"
                }
            }
        },
        tooltip: {
            backgroundColor: 'rgba(0, 0, 0, 0.8)',
            titleColor: '#ffffff',
            bodyColor: '#ffffff',
            borderColor: '#667eea',
            borderWidth: 1,
            cornerRadius: 8,
            displayColors: true
        }
    },
    animation: {
        duration: 1500,
        easing: 'easeInOutQuart'
    }
};

// Initialize all charts
function initializeCharts() {
    try {
        // Branch Chart (Bar Chart)
        const branchData = JSON.parse(document.getElementById('<%= hdnBranchData.ClientID %>').value || '[]');
        branchChart = createBarChart('branchChart', branchData, 'الطلاب حسب الفرع');

        // Gender Chart (Doughnut Chart)
        const genderData = JSON.parse(document.getElementById('<%= hdnGenderData.ClientID %>').value || '[]');
        genderChart = createDoughnutChart('genderChart', genderData, 'الطلاب حسب النوع');

        // Status Chart (Pie Chart)
        const statusData = JSON.parse(document.getElementById('<%= hdnStatusData.ClientID %>').value || '[]');
        statusChart = createPieChart('statusChart', statusData, 'الطلاب حسب الصفة');

        // Nationality Chart (Horizontal Bar Chart)
        const nationalityData = JSON.parse(document.getElementById('<%= hdnNationalityData.ClientID %>').value || '[]');
        nationalityChart = createHorizontalBarChart('nationalityChart', nationalityData, 'الطلاب حسب الجنسية');

    } catch (error) {
        console.error('Error initializing charts:', error);
        showError('خطأ في تحميل الرسوم البيانية');
    }
}

// Create Bar Chart
function createBarChart(canvasId, data, title) {
    const ctx = document.getElementById(canvasId).getContext('2d');
    
    return new Chart(ctx, {
        type: 'bar',
        data: {
            labels: data.map(item => item.label),
            datasets: [{
                label: 'عدد الطلاب',
                data: data.map(item => item.value),
                backgroundColor: chartColors.primary,
                borderColor: chartColors.primary.map(color => color + '80'),
                borderWidth: 2,
                borderRadius: 8,
                borderSkipped: false
            }]
        },
        options: {
            ...defaultOptions,
            scales: {
                y: {
                    beginAtZero: true,
                    grid: {
                        color: 'rgba(0, 0, 0, 0.1)'
                    },
                    ticks: {
                        font: {
                            size: 11
                        }
                    }
                },
                x: {
                    grid: {
                        display: false
                    },
                    ticks: {
                        font: {
                            size: 11
                        },
                        maxRotation: 45
                    }
                }
            }
        }
    });
}

// Create Doughnut Chart
function createDoughnutChart(canvasId, data, title) {
    const ctx = document.getElementById(canvasId).getContext('2d');
    
    return new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: data.map(item => item.label),
            datasets: [{
                data: data.map(item => item.value),
                backgroundColor: chartColors.primary,
                borderColor: '#ffffff',
                borderWidth: 3,
                hoverBorderWidth: 5
            }]
        },
        options: {
            ...defaultOptions,
            cutout: '60%',
            plugins: {
                ...defaultOptions.plugins,
                legend: {
                    ...defaultOptions.plugins.legend,
                    position: 'right'
                }
            }
        }
    });
}

// Create Pie Chart
function createPieChart(canvasId, data, title) {
    const ctx = document.getElementById(canvasId).getContext('2d');
    
    return new Chart(ctx, {
        type: 'pie',
        data: {
            labels: data.map(item => item.label),
            datasets: [{
                data: data.map(item => item.value),
                backgroundColor: chartColors.primary,
                borderColor: '#ffffff',
                borderWidth: 2,
                hoverBorderWidth: 4
            }]
        },
        options: defaultOptions
    });
}

// Create Horizontal Bar Chart
function createHorizontalBarChart(canvasId, data, title) {
    const ctx = document.getElementById(canvasId).getContext('2d');
    
    return new Chart(ctx, {
        type: 'bar',
        data: {
            labels: data.map(item => item.label),
            datasets: [{
                label: 'عدد الطلاب',
                data: data.map(item => item.value),
                backgroundColor: chartColors.primary,
                borderColor: chartColors.primary.map(color => color + '80'),
                borderWidth: 2,
                borderRadius: 6
            }]
        },
        options: {
            ...defaultOptions,
            indexAxis: 'y',
            scales: {
                x: {
                    beginAtZero: true,
                    grid: {
                        color: 'rgba(0, 0, 0, 0.1)'
                    }
                },
                y: {
                    grid: {
                        display: false
                    },
                    ticks: {
                        font: {
                            size: 10
                        }
                    }
                }
            }
        }
    });
}

// Update statistics summary
function updateStatsSummary() {
    try {
        const branchData = JSON.parse(document.getElementById('<%= hdnBranchData.ClientID %>').value || '[]');
        const nationalityData = JSON.parse(document.getElementById('<%= hdnNationalityData.ClientID %>').value || '[]');
        
        const totalStudents = branchData.reduce((sum, item) => sum + item.value, 0);
        const totalBranches = branchData.length;
        const totalNationalities = nationalityData.length;
        
        document.getElementById('totalStudents').textContent = totalStudents.toLocaleString();
        document.getElementById('totalBranches').textContent = totalBranches;
        document.getElementById('totalNationalities').textContent = totalNationalities;
        
    } catch (error) {
        console.error('Error updating stats:', error);
    }
}

// Refresh all charts
function refreshAllCharts() {
    showLoading(true);
    
    // Simulate refresh (in real app, this would trigger a postback)
    setTimeout(() => {
        // Trigger postback to refresh data
        __doPostBack('<%= Page.ClientID %>', 'RefreshCharts');
        showLoading(false);
    }, 1000);
}

// Show/hide loading panel
function showLoading(show) {
    document.getElementById('loadingPanel').style.display = show ? 'block' : 'none';
}

// Show error message
function showError(message) {
    const errorDiv = document.createElement('div');
    errorDiv.className = 'error-message';
    errorDiv.innerHTML = `<i class="fas fa-exclamation-triangle"></i> ${message}`;
    
    const dashboard = document.querySelector('.school-dashboard');
    dashboard.insertBefore(errorDiv, dashboard.firstChild);
    
    setTimeout(() => {
        errorDiv.remove();
    }, 5000);
}

// Export chart as image
function exportChart(chartInstance, filename) {
    const canvas = chartInstance.canvas;
    const url = canvas.toDataURL('image/png');
    
    const link = document.createElement('a');
    link.download = filename;
    link.href = url;
    link.click();
}

// Print dashboard
function printDashboard() {
    window.print();
}

// Responsive chart resize
window.addEventListener('resize', () => {
    [branchChart, genderChart, statusChart, nationalityChart].forEach(chart => {
        if (chart) {
            chart.resize();
        }
    });
});
</script>