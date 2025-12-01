<%@ Page Language="C#" CodeFile="CustomersTrialBalance.aspx.cs" Inherits="CustomersTrialBalance" %>

<!DOCTYPE html>
<html lang="ar" dir="rtl">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ميزان مراجعة العملاء</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Cairo:wght@300;400;600;700&display=swap');
        
        body {
            font-family: 'Cairo', sans-serif;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
            direction: rtl;
            color: #2c3e50 !important;
        }

        .main-container {
            margin: 20px auto;
            max-width: 1400px;
            background: rgba(255, 255, 255, 0.95);
            border-radius: 20px;
            box-shadow: 0 20px 40px rgba(0, 0, 0, 0.1);
            padding: 30px;
            backdrop-filter: blur(10px);
            border: 1px solid rgba(255, 255, 255, 0.2);
        }

        .header-section {
            background: linear-gradient(135deg, #2c3e50 0%, #3498db 100%);
            color: white !important;
            padding: 25px;
            border-radius: 15px;
            margin-bottom: 30px;
            text-align: center;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.2);
        }

        .header-section h1 {
            margin: 0;
            font-size: 2.2rem;
            font-weight: 700;
            text-shadow: 2px 2px 4px rgba(0, 0, 0, 0.3);
            color: white !important;
        }

        .search-section {
            background: linear-gradient(135deg, #f8f9fa 0%, #e9ecef 100%);
            padding: 25px;
            border-radius: 15px;
            margin-bottom: 25px;
            border: 2px solid #e9ecef;
            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.08);
        }

        .form-label {
            font-weight: 600;
            color: #2c3e50 !important;
            margin-bottom: 8px;
        }

        .form-control, .form-select {
            border: 2px solid #e9ecef;
            border-radius: 10px;
            padding: 12px 15px;
            font-size: 14px;
            transition: all 0.3s ease;
            background-color: white !important;
            color: #2c3e50 !important;
        }

        .form-control:focus, .form-select:focus {
            border-color: #3498db;
            box-shadow: 0 0 0 0.25rem rgba(52, 152, 219, 0.25);
            outline: none;
        }

        .btn-primary {
            background: linear-gradient(135deg, #3498db 0%, #2980b9 100%);
            border: none;
            border-radius: 10px;
            padding: 12px 30px;
            font-weight: 600;
            transition: all 0.3s ease;
            box-shadow: 0 5px 15px rgba(52, 152, 219, 0.4);
            color: white !important;
        }

        .btn-primary:hover {
            transform: translateY(-2px);
            box-shadow: 0 8px 25px rgba(52, 152, 219, 0.6);
            background: linear-gradient(135deg, #2980b9 0%, #3498db 100%);
        }

        .btn-success {
            background: linear-gradient(135deg, #27ae60 0%, #2ecc71 100%);
            border: none;
            border-radius: 10px;
            padding: 10px 25px;
            font-weight: 600;
            transition: all 0.3s ease;
            box-shadow: 0 5px 15px rgba(46, 204, 113, 0.4);
            color: white !important;
        }

        .btn-success:hover {
            transform: translateY(-2px);
            box-shadow: 0 8px 25px rgba(46, 204, 113, 0.6);
            background: linear-gradient(135deg, #2ecc71 0%, #27ae60 100%);
        }

        .table-container {
            background: white;
            border-radius: 15px;
            padding: 25px;
            margin-bottom: 25px;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
            border: 1px solid #e9ecef;
        }

        .table {
            margin-bottom: 0;
            font-size: 13px;
            color: #2c3e50 !important;
        }

        .table thead th {
            background: linear-gradient(135deg, #34495e 0%, #2c3e50 100%);
            color: white !important;
            border: none;
            padding: 15px 8px;
            font-weight: 600;
            text-align: center;
            vertical-align: middle;
            font-size: 12px;
        }

        .table tbody td {
            padding: 12px 8px;
            vertical-align: middle;
            border-bottom: 1px solid #e9ecef;
            text-align: center;
            color: #2c3e50 !important;
            background-color: white !important;
        }

        .table tbody tr:hover {
            background-color: #f8f9fa !important;
        }

        .opening-row {
            background: linear-gradient(135deg, #e8f5e8 0%, #c8e6c9 100%) !important;
            font-weight: 600;
            color: #2e7d32 !important;
        }

        .opening-row td {
            background: transparent !important;
            color: #2e7d32 !important;
        }

        .total-row {
            background: linear-gradient(135deg, #fff3e0 0%, #ffcc02 100%) !important;
            font-weight: bold;
            color: #f57900 !important;
        }

        .total-row td {
            background: transparent !important;
            color: #f57900 !important;
            border-top: 2px solid #ffcc02;
            border-bottom: 2px solid #ffcc02;
        }

        .closing-row {
            background: linear-gradient(135deg, #e3f2fd 0%, #90caf9 100%) !important;
            font-weight: bold;
            color: #1565c0 !important;
        }

        .closing-row td {
            background: transparent !important;
            color: #1565c0 !important;
        }

        .progress-container {
            background: white;
            border-radius: 15px;
            padding: 25px;
            margin-bottom: 25px;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
            border: 1px solid #e9ecef;
            display: none;
        }

        .progress {
            height: 25px;
            border-radius: 12px;
            background-color: #e9ecef;
            overflow: hidden;
            box-shadow: inset 0 2px 4px rgba(0, 0, 0, 0.1);
        }

        .progress-bar {
            background: linear-gradient(135deg, #3498db 0%, #2980b9 100%);
            transition: width 0.3s ease;
            border-radius: 12px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.2);
        }

        .progress-text {
            text-align: center;
            font-weight: 600;
            color: #2c3e50 !important;
            margin-bottom: 10px;
        }

        .loading-spinner {
            display: inline-block;
            width: 20px;
            height: 20px;
            border: 3px solid #f3f3f3;
            border-top: 3px solid #3498db;
            border-radius: 50%;
            animation: spin 1s linear infinite;
            margin-left: 10px;
        }

        @keyframes spin {
            0% { transform: rotate(0deg); }
            100% { transform: rotate(360deg); }
        }

        .checkbox-container {
            display: flex;
            align-items: center;
            gap: 15px;
            background: linear-gradient(135deg, #f8f9fa 0%, #e9ecef 100%);
            padding: 15px;
            border-radius: 10px;
            border: 1px solid #dee2e6;
        }

        .form-check {
            margin-bottom: 0;
        }

        .form-check-input:checked {
            background-color: #3498db;
            border-color: #3498db;
        }

        .form-check-label {
            color: #2c3e50 !important;
            font-weight: 500;
        }

        .export-buttons {
            text-align: center;
            margin-top: 20px;
        }

        .message {
            padding: 15px;
            border-radius: 10px;
            margin-bottom: 20px;
            font-weight: 500;
        }

        .error-message {
            background-color: #f8d7da;
            color: #721c24 !important;
            border: 1px solid #f5c6cb;
        }

        .success-message {
            background-color: #d4edda;
            color: #155724 !important;
            border: 1px solid #c3e6cb;
        }

        .analysis-section {
            background: white;
            border-radius: 15px;
            padding: 25px;
            margin-bottom: 25px;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
            border: 1px solid #e9ecef;
        }

        .chart-container {
            position: relative;
            height: 400px;
            margin-top: 20px;
        }

        .summary-cards {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
            gap: 20px;
            margin-bottom: 25px;
        }

        .summary-card {
            background: linear-gradient(135deg, #f8f9fa 0%, #e9ecef 100%);
            border-radius: 15px;
            padding: 20px;
            text-align: center;
            border: 1px solid #dee2e6;
            transition: transform 0.3s ease, box-shadow 0.3s ease;
        }

        .summary-card:hover {
            transform: translateY(-5px);
            box-shadow: 0 15px 35px rgba(0, 0, 0, 0.15);
        }

        .summary-card .card-title {
            font-size: 14px;
            color: #6c757d !important;
            margin-bottom: 10px;
            font-weight: 600;
        }

        .summary-card .card-value {
            font-size: 24px;
            font-weight: bold;
            color: #2c3e50 !important;
        }

        .summary-card.positive .card-value {
            color: #27ae60 !important;
        }

        .summary-card.negative .card-value {
            color: #e74c3c !important;
        }

        @media print {
            body {
                background: white !important;
            }
            
            .main-container {
                box-shadow: none !important;
                border-radius: 0 !important;
                margin: 0 !important;
                max-width: none !important;
                background: white !important;
            }
            
            .btn, .search-section {
                display: none !important;
            }
            
            .table {
                font-size: 11px !important;
            }
            
            .table thead th {
                background: #f8f9fa !important;
                color: black !important;
            }
        }

        @media (max-width: 768px) {
            .main-container {
                margin: 10px;
                padding: 15px;
                border-radius: 15px;
            }
            
            .header-section h1 {
                font-size: 1.5rem;
            }
            
            .table {
                font-size: 11px;
            }
            
            .table thead th,
            .table tbody td {
                padding: 8px 4px;
            }
            
            .summary-cards {
                grid-template-columns: 1fr;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="main-container">
            <div class="header-section">
                <h1><i class="fas fa-balance-scale"></i> ميزان مراجعة العملاء</h1>
            </div>

            <asp:Literal ID="litMessage" runat="server"></asp:Literal>

            <div class="search-section">
                <div class="row">
                    <div class="col-md-3">
                        <label class="form-label">من تاريخ:</label>
                        <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label class="form-label">إلى تاريخ:</label>
                        <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    </div>
                    <div class="col-md-4">
                        <div class="checkbox-container">
                            <asp:CheckBox ID="chkShowOpeningBalance" runat="server" CssClass="form-check-input" />
                            <label class="form-check-label">عرض الرصيد الافتتاحي</label>
                            
                            <asp:CheckBox ID="chkShowAnalysis" runat="server" CssClass="form-check-input" />
                            <label class="form-check-label">تحليل بيفوت</label>
                        </div>
                    </div>
                    <div class="col-md-2">
                        <label class="form-label">&nbsp;</label>
                        <asp:Button ID="btnSearch" runat="server" Text="عرض التقرير" CssClass="btn btn-primary w-100"
                            OnClick="btnSearch_Click" OnClientClick="showProgress(); return true;" />
                    </div>
                </div>
            </div>

            <div id="progressContainer" class="progress-container">
                <div class="progress-text">
                    <span id="progressText">جاري تحضير البيانات...</span>
                    <span class="loading-spinner"></span>
                </div>
                <div class="progress">
                    <div id="progressBar" class="progress-bar" role="progressbar" style="width: 0%"></div>
                </div>
                <div style="text-align: center; margin-top: 10px;">
                    <small id="progressDetails" style="color: #6c757d;"></small>
                </div>
            </div>

            <div id="summarySection" runat="server" visible="false">
                <div class="summary-cards">
                    <div class="summary-card">
                        <div class="card-title">إجمالي العملاء</div>
                        <div class="card-value" id="totalCustomersCard" runat="server">0</div>
                    </div>
                    <div class="summary-card">
                        <div class="card-title">إجمالي المدين</div>
                        <div class="card-value positive" id="totalDebitCard" runat="server">0.00</div>
                    </div>
                    <div class="summary-card">
                        <div class="card-title">إجمالي الدائن</div>
                        <div class="card-value negative" id="totalCreditCard" runat="server">0.00</div>
                    </div>
                    <div class="summary-card">
                        <div class="card-title">صافي الرصيد</div>
                        <div class="card-value" id="netBalanceCard" runat="server">0.00</div>
                    </div>
                </div>
            </div>

            <div id="tableContainer" runat="server" visible="false" class="table-container">
                <h4 style="color: #2c3e50; margin-bottom: 20px;">
                    <i class="fas fa-table"></i> ميزان مراجعة العملاء
                </h4>
                <div class="table-responsive">
                    <asp:GridView ID="gvTrialBalance" runat="server" 
                        CssClass="table table-striped" 
                        AutoGenerateColumns="false"
                        OnRowDataBound="gvTrialBalance_RowDataBound"
                        GridLines="None"
                        ShowHeaderWhenEmpty="true">
                        <HeaderStyle CssClass="table-header" />
                        <Columns>
                            <asp:BoundField DataField="CustomerNo" HeaderText="رقم العميل" />
                            <asp:BoundField DataField="CustomerName" HeaderText="اسم العميل" />
                            <asp:BoundField DataField="OpeningBalance" HeaderText="الرصيد الافتتاحي" DataFormatString="{0:N2}" />
                            <asp:BoundField DataField="TotalDebit" HeaderText="إجمالي المدين" DataFormatString="{0:N2}" />
                            <asp:BoundField DataField="TotalCredit" HeaderText="إجمالي الدائن" DataFormatString="{0:N2}" />
                            <asp:BoundField DataField="PeriodMovement" HeaderText="حركة الفترة" DataFormatString="{0:N2}" />
                            <asp:BoundField DataField="ClosingBalance" HeaderText="الرصيد الختامي" DataFormatString="{0:N2}" />
                            <asp:BoundField DataField="TransactionCount" HeaderText="عدد الحركات" />
                        </Columns>
                        <EmptyDataTemplate>
                            <div class="text-center p-4">
                                <i class="fas fa-info-circle fa-2x text-muted mb-3"></i>
                                <p class="text-muted">لا توجد بيانات لعرضها في الفترة المحددة</p>
                            </div>
                        </EmptyDataTemplate>
                    </asp:GridView>
                </div>
            </div>

            <div id="analysisSection" runat="server" visible="false" class="analysis-section">
                <h4 style="color: #2c3e50; margin-bottom: 20px;">
                    <i class="fas fa-chart-pie"></i> تحليل العملاء والحسابات
                </h4>
                <div class="table-responsive">
                    <asp:GridView ID="gvAnalysis" runat="server" 
                        CssClass="table table-striped" 
                        AutoGenerateColumns="false"
                        OnRowDataBound="gvAnalysis_RowDataBound"
                        GridLines="None"
                        ShowHeaderWhenEmpty="true">
                        <HeaderStyle CssClass="table-header" />
                        <Columns>
                            <asp:BoundField DataField="CustomerNo" HeaderText="رقم العميل" />
                            <asp:BoundField DataField="CustomerName" HeaderText="اسم العميل" />
                            <asp:BoundField DataField="AccountNo" HeaderText="رقم الحساب" />
                            <asp:BoundField DataField="AccountName" HeaderText="اسم الحساب" />
                            <asp:BoundField DataField="TotalDebit" HeaderText="إجمالي المدين" DataFormatString="{0:N2}" />
                            <asp:BoundField DataField="TotalCredit" HeaderText="إجمالي الدائن" DataFormatString="{0:N2}" />
                            <asp:BoundField DataField="NetMovement" HeaderText="صافي الحركة" DataFormatString="{0:N2}" />
                            <asp:BoundField DataField="TransactionCount" HeaderText="عدد الحركات" />
                        </Columns>
                        <EmptyDataTemplate>
                            <div class="text-center p-4">
                                <i class="fas fa-info-circle fa-2x text-muted mb-3"></i>
                                <p class="text-muted">لا توجد بيانات تحليلية لعرضها</p>
                            </div>
                        </EmptyDataTemplate>
                    </asp:GridView>
                </div>

                <div class="chart-container">
                    <canvas id="analysisChart"></canvas>
                </div>
            </div>

            <div id="exportButtons" runat="server" visible="false" class="export-buttons">
                <asp:Button ID="btnExportExcel" runat="server" Text="تصدير إلى Excel" 
                    CssClass="btn btn-success" OnClick="btnExportExcel_Click" />
            </div>
        </div>

        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
        <script>
            function showProgress() {
                document.getElementById('progressContainer').style.display = 'block';
                document.getElementById('tableContainer').style.display = 'none';
                document.getElementById('analysisSection').style.display = 'none';
                document.getElementById('summarySection').style.display = 'none';
                
                updateProgress(0, 'بدء المعالجة...');
                
                // Simulate progress updates
                setTimeout(() => updateProgress(20, 'جاري تحميل بيانات العملاء...'), 500);
                setTimeout(() => updateProgress(40, 'جاري حساب الأرصدة الافتتاحية...'), 1000);
                setTimeout(() => updateProgress(60, 'جاري معالجة الحركات...'), 1500);
                setTimeout(() => updateProgress(80, 'جاري تجميع النتائج...'), 2000);
                setTimeout(() => updateProgress(100, 'اكتمل التحضير!'), 2500);
            }
            
            function updateProgress(percentage, message) {
                const progressBar = document.getElementById('progressBar');
                const progressText = document.getElementById('progressText');
                const progressDetails = document.getElementById('progressDetails');
                
                progressBar.style.width = percentage + '%';
                progressText.innerHTML = message;
                progressDetails.innerHTML = `${percentage}% مكتمل`;
                
                if (percentage >= 100) {
                    setTimeout(() => {
                        document.getElementById('progressContainer').style.display = 'none';
                    }, 1000);
                }
            }
            
            let analysisChart;
            
            function updateAnalysisChart(chartData) {
                const ctx = document.getElementById('analysisChart').getContext('2d');
                
                if (analysisChart) {
                    analysisChart.destroy();
                }
                
                analysisChart = new Chart(ctx, {
                    type: 'bar',
                    data: {
                        labels: chartData.map(item => item.customerName),
                        datasets: [{
                            label: 'الرصيد الختامي',
                            data: chartData.map(item => item.closingBalance),
                            backgroundColor: 'rgba(52, 152, 219, 0.8)',
                            borderColor: 'rgba(52, 152, 219, 1)',
                            borderWidth: 1
                        }]
                    },
                    options: {
                        responsive: true,
                        maintainAspectRatio: false,
                        plugins: {
                            title: {
                                display: true,
                                text: 'الأرصدة الختامية للعملاء'
                            },
                            legend: {
                                display: false
                            }
                        },
                        scales: {
                            y: {
                                beginAtZero: true,
                                ticks: {
                                    callback: function(value) {
                                        return value.toLocaleString('ar-EG');
                                    }
                                }
                            }
                        }
                    }
                });
            }
        </script>
    </form>
</body>
</html>
