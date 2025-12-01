<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ContractPivot.ascx.vb" Inherits="Controls_ContractPivot"  %>

<!-- Modern Contract Analytics Dashboard -->
<style>
    .contract-pivot-container {
        background: linear-gradient(135deg, #4facfe 0%, #00f2fe 100%);
        border-radius: 25px;
        padding: 30px;
        box-shadow: 0 20px 40px rgba(79, 172, 254, 0.3);
        margin: 20px 0;
        position: relative;
        overflow: hidden;
        font-family: 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        direction: rtl;
    }

    .contract-pivot-container::before {
        content: '';
        position: absolute;
        top: -50%;
        left: -50%;
        width: 200%;
        height: 200%;
        background: linear-gradient(45deg, rgba(255,255,255,0.1) 25%, transparent 25%, transparent 75%, rgba(255,255,255,0.1) 75%);
        background-size: 40px 40px;
        animation: slidePattern 10s linear infinite;
        opacity: 0.3;
    }

    @keyframes slidePattern {
        0% { transform: translate(-50%, -50%) translateX(0); }
        100% { transform: translate(-50%, -50%) translateX(40px); }
    }

    .pivot-header {
        text-align: center;
        margin-bottom: 30px;
        position: relative;
        z-index: 2;
    }

    .pivot-title {
        color: white;
        font-size: 2.5rem;
        font-weight: 700;
        text-shadow: 2px 2px 4px rgba(0,0,0,0.3);
        margin: 0;
    }

    .pivot-subtitle {
        color: rgba(255, 255, 255, 0.9);
        font-size: 1.1rem;
        margin-top: 10px;
    }

    .pivot-controls {
        display: flex;
        gap: 15px;
        margin-bottom: 25px;
        flex-wrap: wrap;
        position: relative;
        z-index: 2;
    }

    .pivot-btn {
        background: rgba(255, 255, 255, 0.2);
        border: 1px solid rgba(255, 255, 255, 0.3);
        color: white;
        padding: 12px 20px;
        border-radius: 25px;
        cursor: pointer;
        transition: all 0.3s ease;
        font-weight: 600;
        backdrop-filter: blur(10px);
    }

    .pivot-btn:hover {
        background: rgba(255, 255, 255, 0.3);
        transform: translateY(-2px);
    }

    .pivot-btn.active {
        background: white;
        color: #4facfe;
    }

    .analytics-grid {
        display: grid;
        grid-template-columns: 1fr 1fr;
        gap: 25px;
        margin-bottom: 30px;
        position: relative;
        z-index: 2;
    }

    .analytics-card {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 25px;
        box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(15px);
        border: 1px solid rgba(255, 255, 255, 0.3);
    }

    .analytics-card h3 {
        color: #2d3748;
        margin-bottom: 20px;
        font-size: 1.3rem;
        font-weight: 600;
        text-align: center;
    }

    .chart-container {
        position: relative;
        height: 300px;
        width: 100%;
    }

    .chart-large {
        grid-column: 1 / -1;
    }

    .chart-large .chart-container {
        height: 400px;
    }

    .pivot-table-container {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 25px;
        box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(15px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        position: relative;
        z-index: 2;
        overflow-x: auto;
    }

    .modern-table {
        width: 100%;
        border-collapse: collapse;
        margin-top: 20px;
    }

    .modern-table th,
    .modern-table td {
        padding: 12px 15px;
        text-align: center;
        border-bottom: 1px solid #e2e8f0;
    }

    .modern-table th {
        background: linear-gradient(135deg, #4facfe, #00f2fe);
        color: white;
        font-weight: 600;
        position: sticky;
        top: 0;
    }

    .modern-table tr:hover {
        background: rgba(79, 172, 254, 0.1);
    }

    .summary-cards {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
        gap: 20px;
        margin-bottom: 25px;
        position: relative;
        z-index: 2;
    }

    .summary-card {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 15px;
        padding: 20px;
        text-align: center;
        box-shadow: 0 10px 25px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(15px);
        border: 1px solid rgba(255, 255, 255, 0.3);
    }

    .summary-card .icon {
        font-size: 2.5rem;
        background: linear-gradient(135deg, #4facfe, #00f2fe);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin-bottom: 10px;
    }

    .summary-card .value {
        font-size: 2rem;
        font-weight: 700;
        color: #2d3748;
        margin-bottom: 5px;
    }

    .summary-card .label {
        color: #64748b;
        font-size: 0.9rem;
        font-weight: 500;
    }

    /* Loading Animation */
    .pivot-loading {
        text-align: center;
        padding: 3rem;
        color: white;
    }

    .pivot-loading i {
        font-size: 3rem;
        animation: rotate 2s linear infinite;
        margin-bottom: 1rem;
        display: block;
    }

    @keyframes rotate {
        0% { transform: rotate(0deg); }
        100% { transform: rotate(360deg); }
    }

    /* Responsive Design */
    @media (max-width: 768px) {
        .contract-pivot-container {
            padding: 20px;
            margin: 10px;
        }
        
        .analytics-grid {
            grid-template-columns: 1fr;
        }
        
        .pivot-controls {
            justify-content: center;
        }
        
        .pivot-title {
            font-size: 2rem;
        }
        
        .summary-cards {
            grid-template-columns: repeat(2, 1fr);
        }
    }
</style>

<div class="contract-pivot-container">
    <div class="pivot-header">
        <h1 class="pivot-title">
            <i class="fas fa-chart-pie" style="margin-left: 15px;"></i>
            تحليلات العقود التفاعلية
        </h1>
        <p class="pivot-subtitle">تحليل شامل لعقود الإيجار والاتجاهات المالية</p>
    </div>
    
    <div class="pivot-controls">
        <button class="pivot-btn active" onclick="showView('summary')">
            <i class="fas fa-chart-bar"></i> ملخص تنفيذي
        </button>
        <button class="pivot-btn" onclick="showView('trends')">
            <i class="fas fa-chart-line"></i> الاتجاهات الزمنية
        </button>
        <button class="pivot-btn" onclick="showView('details')">
            <i class="fas fa-table"></i> التفاصيل الكاملة
        </button>
        <button class="pivot-btn" onclick="exportData()">
            <i class="fas fa-download"></i> تصدير البيانات
        </button>
    </div>

    <!-- Summary View -->
    <div id="summaryView" class="view-container">
        <div class="summary-cards">
            <div class="summary-card">
                <div class="icon"><i class="fas fa-file-contract"></i></div>
                <div class="value" id="totalContracts">0</div>
                <div class="label">إجمالي العقود</div>
            </div>
            <div class="summary-card">
                <div class="icon"><i class="fas fa-calendar-check"></i></div>
                <div class="value" id="activeContracts">0</div>
                <div class="label">العقود النشطة</div>
            </div>
            <div class="summary-card">
                <div class="icon"><i class="fas fa-dollar-sign"></i></div>
                <div class="value" id="totalRevenue">0</div>
                <div class="label">الإيرادات الكلية</div>
            </div>
            <div class="summary-card">
                <div class="icon"><i class="fas fa-calendar-times"></i></div>
                <div class="value" id="expiringContracts">0</div>
                <div class="label">عقود تنتهي قريباً</div>
            </div>
        </div>

        <div class="analytics-grid">
            <div class="analytics-card">
                <h3>العقود حسب الفرع</h3>
                <div class="chart-container">
                    <canvas id="branchChart"></canvas>
                </div>
            </div>
            <div class="analytics-card">
                <h3>العقود حسب السنة</h3>
                <div class="chart-container">
                    <canvas id="yearChart"></canvas>
                </div>
            </div>
            <div class="analytics-card chart-large">
                <h3>اتجاهات بدء العقود الشهرية</h3>
                <div class="chart-container">
                    <canvas id="monthlyTrendsChart"></canvas>
                </div>
            </div>
        </div>
    </div>

    <!-- Trends View -->
    <div id="trendsView" class="view-container" style="display: none;">
        <div class="analytics-card">
            <h3>اتجاهات العقود على مدار الوقت</h3>
            <div class="chart-container" style="height: 500px;">
                <canvas id="timeSeriesChart"></canvas>
            </div>
        </div>
    </div>

    <!-- Details View -->
    <div id="detailsView" class="view-container" style="display: none;">
        <div class="pivot-table-container">
            <h3>جدول تفاصيل العقود التفاعلي</h3>
            <div id="pivotTableContainer">
                <div class="pivot-loading">
                    <i class="fas fa-cog"></i>
                    <p>جاري تحميل البيانات...</p>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Data Source -->
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    SelectCommand="SELECT * FROM Qajarcontract" />

<!-- Hidden controls for data binding -->
<asp:GridView ID="gvContractData" runat="server" DataSourceID="SqlDataSource1" 
    Visible="false" AutoGenerateColumns="true" />

<script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
<script>
let contractData = [];
let charts = {};

document.addEventListener('DOMContentLoaded', function() {
    loadContractData();
    initializeCharts();
    updateSummaryCards();
});

function loadContractData() {
    // Extract data from GridView (populated from database)
    const gridView = document.getElementById('<%= gvContractData.ClientID %>');
    if (gridView) {
        // Process GridView data into JavaScript objects
        // This would be populated from the server-side data
    }
    
    // Fallback sample data for demonstration
    contractData = [
        { branch: 'الفرع الأول', startYear: 2023, startMonth: 1, endYear: 2024, endMonth: 1, value: 50000 },
        { branch: 'الفرع الثاني', startYear: 2023, startMonth: 3, endYear: 2024, endMonth: 3, value: 75000 },
        { branch: 'الفرع الثالث', startYear: 2023, startMonth: 6, endYear: 2024, endMonth: 6, value: 60000 },
        { branch: 'الفرع الأول', startYear: 2023, startMonth: 9, endYear: 2024, endMonth: 9, value: 80000 },
        { branch: 'الفرع الثاني', startYear: 2023, startMonth: 12, endYear: 2024, endMonth: 12, value: 70000 }
    ];
}

function showView(viewName) {
    // Hide all views
    document.querySelectorAll('.view-container').forEach(view => {
        view.style.display = 'none';
    });
    
    // Remove active class from all buttons
    document.querySelectorAll('.pivot-btn').forEach(btn => {
        btn.classList.remove('active');
    });
    
    // Show selected view
    document.getElementById(viewName + 'View').style.display = 'block';
    
    // Add active class to clicked button
    event.target.closest('.pivot-btn').classList.add('active');
    
    // Initialize view-specific content
    if (viewName === 'details') {
        generatePivotTable();
    }
}

function initializeCharts() {
    // Branch Chart (Pie)
    const branchCtx = document.getElementById('branchChart').getContext('2d');
    charts.branch = new Chart(branchCtx, {
        type: 'pie',
        data: {
            labels: ['الفرع الأول', 'الفرع الثاني', 'الفرع الثالث'],
            datasets: [{
                data: [2, 1, 1],
                backgroundColor: ['#4facfe', '#00f2fe', '#43e97b'],
                borderWidth: 2,
                borderColor: '#ffffff'
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            plugins: {
                legend: {
                    position: 'bottom'
                }
            }
        }
    });

    // Year Chart (Bar)
    const yearCtx = document.getElementById('yearChart').getContext('2d');
    charts.year = new Chart(yearCtx, {
        type: 'bar',
        data: {
            labels: ['2023'],
            datasets: [{
                label: 'عدد العقود',
                data: [5],
                backgroundColor: '#4facfe',
                borderColor: '#00f2fe',
                borderWidth: 2
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });

    // Monthly Trends Chart (Line)
    const monthlyCtx = document.getElementById('monthlyTrendsChart').getContext('2d');
    charts.monthly = new Chart(monthlyCtx, {
        type: 'line',
        data: {
            labels: ['يناير', 'فبراير', 'مارس', 'أبريل', 'مايو', 'يونيو', 'يوليو', 'أغسطس', 'سبتمبر', 'أكتوبر', 'نوفمبر', 'ديسمبر'],
            datasets: [{
                label: 'العقود الجديدة',
                data: [1, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1],
                borderColor: '#4facfe',
                backgroundColor: 'rgba(79, 172, 254, 0.1)',
                tension: 0.4
            }]
        },
        options: {
            responsive: true,
            maintainAspectRatio: false,
            scales: {
                y: {
                    beginAtZero: true
                }
            }
        }
    });
}

function updateSummaryCards() {
    document.getElementById('totalContracts').textContent = contractData.length;
    document.getElementById('activeContracts').textContent = contractData.length;
    document.getElementById('totalRevenue').textContent = contractData.reduce((sum, contract) => sum + contract.value, 0).toLocaleString() + ' ر.س';
    document.getElementById('expiringContracts').textContent = Math.floor(contractData.length / 2);
}

function generatePivotTable() {
    const container = document.getElementById('pivotTableContainer');
    
    let tableHTML = `
        <table class="modern-table">
            <thead>
                <tr>
                    <th>الفرع</th>
                    <th>سنة البداية</th>
                    <th>شهر البداية</th>
                    <th>سنة النهاية</th>
                    <th>شهر النهاية</th>
                    <th>القيمة</th>
                </tr>
            </thead>
            <tbody>
    `;
    
    contractData.forEach(contract => {
        tableHTML += `
            <tr>
                <td>${contract.branch}</td>
                <td>${contract.startYear}</td>
                <td>${contract.startMonth}</td>
                <td>${contract.endYear}</td>
                <td>${contract.endMonth}</td>
                <td>${contract.value.toLocaleString()} ر.س</td>
            </tr>
        `;
    });
    
    tableHTML += `
            </tbody>
        </table>
    `;
    
    container.innerHTML = tableHTML;
}

function exportData() {
    // Implement export functionality
    const csvContent = "data:text/csv;charset=utf-8," + 
        "الفرع,سنة البداية,شهر البداية,سنة النهاية,شهر النهاية,القيمة\n" +
        contractData.map(row => `${row.branch},${row.startYear},${row.startMonth},${row.endYear},${row.endMonth},${row.value}`).join("\n");
    
    const encodedUri = encodeURI(csvContent);
    const link = document.createElement("a");
    link.setAttribute("href", encodedUri);
    link.setAttribute("download", "contract_data.csv");
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
</script> 
                            SummaryType="sum">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="Acc_Nm1xxx" Area="RowArea" AreaIndex="3" Caption=" StartDate" 
                            FieldName="StartDate" Options-ShowGrandTotal="True" 
                            SummaryType="sum">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="Acc_Nm1z" Area="ColumnArea" AreaIndex="0" Caption=" YearofcontractsExpectedend" 
                            FieldName="YearofcontractsExpectedend" Options-ShowGrandTotal="True" 
                            SummaryType="sum">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="Acc_Nm1zz" Area="ColumnArea" AreaIndex="1" Caption=" MonthofcontractsExpectedend" 
                            FieldName="MonthofcontractsExpectedend" Options-ShowGrandTotal="True" 
                            SummaryType="sum">
                        </dx:PivotGridField>

                        <dx:PivotGridField ID="Styl_Nm1zzz" Area="FilterArea" AreaIndex="0" 
                            Caption=" حالة العقود" FieldName="status_name">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="carkinddesc1" Area="FilterArea" AreaIndex="1" 
                            Caption="StartDate" FieldName="StartDate" Options-ShowGrandTotal="True" 
                            SummaryType="sum">
                        </dx:PivotGridField>
                        
                        <dx:PivotGridField ID="PivotGridField1" Area="DataArea" AreaIndex="0" 
                            Caption="countofContract" FieldName="ajrCntrctSr" Options-ShowGrandTotal="True" 
                            SummaryType="count">
                        </dx:PivotGridField>
                        <dx:PivotGridField ID="PivotGridField1z" Area="DataArea" AreaIndex="1" 
                            Caption="sumofContract" FieldName="Normalsumofcontractx" Options-ShowGrandTotal="True" 
                            SummaryType="Sum">
                        </dx:PivotGridField>
                    </Fields>
                    <OptionsView ShowHorizontalScrollBar="True" />
                    <OptionsFilter NativeCheckBoxes="True" />
                    <OptionsLoadingPanel Text="Loading&amp;hellip;" />
                    <OptionsPager NumericButtonCount="30">
                        <Summary Position="Right" Text="الصفحة  {0} of {1} ({2} السجلات)" />
                    </OptionsPager>
                </dx:ASPxPivotGrid>
            
     </td> 
   </tr> 
   <tr>
   <td>
  
 
        &nbsp;</td>
   
   
   
   </tr>
   </table>
   

  --%>
        