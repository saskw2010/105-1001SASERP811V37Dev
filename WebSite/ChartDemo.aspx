<%@ Page Title="Chart Comparison Demo" Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <!-- Bootstrap 5 -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css" rel="stylesheet" />
    
    <!-- Tabulator CSS -->
    <link href="https://unpkg.com/tabulator-tables@5.5.2/dist/css/tabulator_bootstrap5.min.css" rel="stylesheet">
    
    <!-- Chart Libraries -->
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/apexcharts"></script>

    <style>
        /* ⚠️ CSS Isolation - MANDATORY */
        .main-container,
        .main-container *,
        .main-container *::before,
        .main-container *::after {
            box-sizing: border-box;
        }

        .main-container {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            background-color: #f0f2f5;
            padding: 20px;
            border-radius: 0.75rem;
            margin-top: 2rem;
            margin-bottom: 2rem;
        }
        .main-card {
            background: white;
            border-radius: 15px;
            box-shadow: 0 4px 20px rgba(0,0,0,0.05);
            padding: 20px;
            margin-bottom: 20px;
            border: 1px solid #eef0f2;
        }
        .header-section {
            background: linear-gradient(135deg, #1a237e 0%, #283593 100%);
            color: white;
            padding: 20px;
            border-radius: 10px;
            margin-bottom: 20px;
        }
        .chart-card {
            height: 100%;
            min-height: 400px;
        }
        .chart-header {
            border-bottom: 1px solid #eee;
            padding-bottom: 10px;
            margin-bottom: 15px;
            display: flex;
            justify-content: space-between;
            align-items: center;
        }
        .badge-engine {
            font-size: 0.8em;
            padding: 5px 10px;
            border-radius: 20px;
        }
        .badge-chartjs { background-color: #FF6384; color: white; }
        .badge-apex { background-color: #008FFB; color: white; }
        
        /* Tabulator Customization */
        .tabulator { border: none !important; }
        .tabulator-header { background-color: #f8f9fa !important; border-bottom: 2px solid #dee2e6 !important; }
        .tabulator-row:hover { background-color: #f1f8ff !important; }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageTitleContentPlaceHolder" Runat="Server">
    Chart Comparison Demo (ASPX Wrapper)
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <div class="main-container" data-app-role="page" data-content-framework="bootstrap">
        
        <!-- Header -->
        <div class="header-section d-flex justify-content-between align-items-center">
            <div>
                <h2 class="mb-0"><i class="fas fa-chart-pie me-2"></i>مقارنة محركات الرسم</h2>
                <p class="mb-0 opacity-75">مقارنة حية بين Chart.js (الأداء) و ApexCharts (الجماليات) مع Tabulator</p>
            </div>
            <div>
                <span class="badge bg-light text-dark">v3.0 Prototype (ASPX)</span>
            </div>
        </div>

        <!-- Controls -->
        <div class="main-card">
            <div class="row g-3 align-items-end">
                <div class="col-md-4">
                    <label class="form-label fw-bold">اختر الوحدة (Controller):</label>
                    <div class="input-group">
                        <input type="text" class="form-control" id="controllerInput" list="controllerOptions" placeholder="اكتب اسم الكنترولر..." value="users">
                        <datalist id="controllerOptions">
                            <option value="projects">Projects - المشاريع</option>
                            <option value="charityprojects">Charity Projects - المشاريع الخيرية</option>
                            <option value="softwareprojects">Software Projects - مشاريع البرمجيات</option>
                            <option value="realestateprojects">Real Estate Projects - المشاريع العقارية</option>
                            <option value="countries">Countries - البلدان</option>
                            <option value="cities">Cities - المدن</option>
                            <option value="complexes">Complexes - المجمعات</option>
                            <option value="users">Users - المستخدمين</option>
                            <option value="categories">Categories - الفئات</option>
                            <option value="statuses">Statuses - الحالات</option>
                        </datalist>
                        <button class="btn btn-outline-secondary" type="button" onclick="document.getElementById('controllerInput').value=''">
                            <i class="fas fa-times"></i>
                        </button>
                    </div>
                </div>
                <div class="col-md-2">
                    <label class="form-label fw-bold">عدد السجلات:</label>
                    <select class="form-select" id="recordCount">
                        <option value="10">10</option>
                        <option value="50">50</option>
                        <option value="100">100</option>
                    </select>
                </div>
                <div class="col-md-3">
                    <button class="btn btn-primary w-100" onclick="loadData(); return false;">
                        <i class="fas fa-sync me-1"></i> تحميل وعرض البيانات
                    </button>
                </div>
            </div>
        </div>

        <!-- Comparison Section -->
        <div class="row mb-4">
            <!-- Chart.js Side -->
            <div class="col-md-6">
                <div class="main-card chart-card">
                    <div class="chart-header">
                        <h5 class="mb-0"><i class="fas fa-chart-bar me-2"></i>Chart.js</h5>
                        <span class="badge badge-engine badge-chartjs">Canvas Based (Fast)</span>
                    </div>
                    <div style="position: relative; height: 300px;">
                        <canvas id="chartJsCanvas"></canvas>
                    </div>
                    <div class="mt-3 text-muted small">
                        <i class="fas fa-info-circle"></i> المزايا: خفيف جداً، أداء عالي مع البيانات الضخمة.
                    </div>
                </div>
            </div>

            <!-- ApexCharts Side -->
            <div class="col-md-6">
                <div class="main-card chart-card">
                    <div class="chart-header">
                        <h5 class="mb-0"><i class="fas fa-chart-area me-2"></i>ApexCharts</h5>
                        <span class="badge badge-engine badge-apex">SVG Based (Interactive)</span>
                    </div>
                    <div id="apexChartContainer" style="height: 300px;"></div>
                    <div class="mt-3 text-muted small">
                        <i class="fas fa-info-circle"></i> المزايا: تفاعلي (Zoom/Pan)، Tooltips غنية، مظهر عصري، تصدير جاهز.
                    </div>
                </div>
            </div>
        </div>

        <!-- Data Grid Section -->
        <div class="main-card">
            <h5 class="mb-3"><i class="fas fa-table me-2"></i>مصدر البيانات (Tabulator Engine)</h5>
            <div id="data-table"></div>
        </div>

    </div>

    <!-- Scripts -->
    <script src="https://unpkg.com/tabulator-tables@5.5.2/dist/js/tabulator.min.js"></script>
    
    <script>
        // Global Variables
        let table;
        let chartJsInstance = null;
        let apexChartInstance = null;
        
        // API Configuration
        const API_CONFIG = {
            baseUrl: '', // Use relative path
            apiKey: 'w4b79da7-e3a9-4152-9213-886f4c810bec-sky' // Default key
        };

        // Initialize API Manager
        const apiManager = {
            async init() {
                // Optional: Load config
            },

            async fetchData(controller, limit = 10) {
                // Clean up the endpoint - remove v2/ prefix if already present
                const cleanEndpoint = controller.replace(/^v2\//, '');
                
                // Use the v2 endpoint which is rewritten to v2_handler.aspx
                const url = `/v2/${cleanEndpoint}?limit=${limit}&page=0&count=true&x-api-key=${API_CONFIG.apiKey}`;
                console.log(`Fetching: ${url}`);
                
                try {
                    const response = await fetch(url, {
                        headers: {
                            'Accept': 'application/json',
                            'x-api-key': API_CONFIG.apiKey
                        }
                    });
                    
                    if (!response.ok) throw new Error(`HTTP ${response.status}`);
                    
                    const data = await response.json();
                    
                    if (data.error) {
                        throw new Error(data.error);
                    }

                    // Handle OData format { value: [] } or direct array [] or Custom API { collection: [] }
                    return data.collection || data.value || data;
                } catch (error) {
                    console.error('API Error:', error);
                    alert(`Error fetching data: ${error.message}`);
                    return [];
                }
            }
        };

        // Main Load Function
        async function loadData() {
            const controller = document.getElementById('controllerInput').value;
            const count = parseInt(document.getElementById('recordCount').value);
            
            if (!controller) {
                alert("الرجاء إدخال اسم الكنترولر");
                return;
            }
            
            // Show Loading
            document.getElementById('data-table').innerHTML = '<div class="text-center p-3"><i class="fas fa-spinner fa-spin"></i> جاري التحميل...</div>';

            // 1. Fetch Real Data
            const data = await apiManager.fetchData(controller, count);

            if (!data || data.length === 0) {
                document.getElementById('data-table').innerHTML = '<div class="alert alert-warning">لا توجد بيانات</div>';
                return;
            }

            // 2. Auto-Detect Columns & Render Table
            renderDynamicTable(data);

            // 3. Auto-Detect Chart Fields & Render Charts
            const chartData = processDynamicChartData(data);
            renderChartJs(chartData);
            renderApexChart(chartData);
        }

        // Render Dynamic Table
        function renderDynamicTable(data) {
            if (!data || data.length === 0) return;

            // Auto-generate columns from first row
            const firstRow = data[0];
            const columns = Object.keys(firstRow).map(key => {
                const val = firstRow[key];
                let type = "string";
                let formatter = undefined;
                let editor = undefined;
                let headerFilter = "input";

                // Simple Type Inference
                if (typeof val === 'number') {
                    type = "number";
                    headerFilter = "number";
                    // Heuristic: if key contains 'amount' or 'price', format as money
                    if (key.toLowerCase().includes('amount') || key.toLowerCase().includes('price')) {
                        formatter = "money";
                    }
                } else if (typeof val === 'boolean') {
                    type = "boolean";
                    formatter = "tickCross";
                    headerFilter = "tickCross";
                    editor = "tickCross";
                } else if (key.toLowerCase().includes('date')) {
                    // Basic date detection
                }

                return {
                    title: key, // Can be enhanced with a dictionary to map "SprDesc" -> "Project Name"
                    field: key,
                    formatter: formatter,
                    headerFilter: headerFilter,
                    editor: editor
                };
            });

            // Add ID column if not present (optional)
            // columns.unshift({title:"#", field:"rownum", formatter:"rownum", width:50});

            table = new Tabulator("#data-table", {
                data: data,
                layout: "fitColumns",
                columns: columns,
                textDirection: "rtl",
                pagination: "local",
                paginationSize: 10
            });
            
            // Connect Engine
            table.on("dataFiltered", function(filters, rows){
                const filteredData = rows.map(row => row.getData());
                updateCharts(filteredData);
            });
        }

        // Smart Chart Data Processor
        function processDynamicChartData(data) {
            if (!data || data.length === 0) return { labels: [], values: [], title: "No Data" };

            const firstRow = data[0];
            const keys = Object.keys(firstRow);

            // Heuristics to find Label and Value fields
            let labelField = keys.find(k => k.toLowerCase().includes('name') || k.toLowerCase().includes('desc') || k.toLowerCase().includes('title'));
            let valueField = keys.find(k => (k.toLowerCase().includes('amount') || k.toLowerCase().includes('total') || k.toLowerCase().includes('count') || k.toLowerCase().includes('budget')) && typeof firstRow[k] === 'number');

            // Fallback if no obvious fields found
            if (!labelField) labelField = keys.find(k => typeof firstRow[k] === 'string') || keys[0];
            if (!valueField) valueField = keys.find(k => typeof firstRow[k] === 'number') || keys[1];

            console.log(`Auto-detected Chart Fields: Label=${labelField}, Value=${valueField}`);

            // Aggregate Data (Sum by Label)
            const aggregated = {};
            data.forEach(row => {
                const label = row[labelField] || 'Unknown';
                const val = parseFloat(row[valueField]) || 0;
                aggregated[label] = (aggregated[label] || 0) + val;
            });

            // Sort by value desc and take top 10
            const sorted = Object.entries(aggregated)
                .sort((a, b) => b[1] - a[1])
                .slice(0, 10);

            return {
                labels: sorted.map(s => s[0]),
                values: sorted.map(s => s[1]),
                title: `تحليل ${valueField} حسب ${labelField}`
            };
        }

        // Render Chart.js
        function renderChartJs(chartData) {
            const ctx = document.getElementById('chartJsCanvas').getContext('2d');
            
            if (chartJsInstance) {
                chartJsInstance.destroy();
            }

            chartJsInstance = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: chartData.labels,
                    datasets: [{
                        label: chartData.title,
                        data: chartData.values,
                        backgroundColor: 'rgba(54, 162, 235, 0.6)',
                        borderColor: 'rgba(54, 162, 235, 1)',
                        borderWidth: 1
                    }]
                },
                options: {
                    responsive: true,
                    maintainAspectRatio: false,
                    plugins: {
                        legend: {
                            position: 'top',
                        },
                        title: {
                            display: true,
                            text: chartData.title
                        }
                    }
                }
            });
        }

        // Render ApexCharts
        function renderApexChart(chartData) {
            const options = {
                series: [{
                    name: chartData.title,
                    data: chartData.values
                }],
                chart: {
                    type: 'bar',
                    height: 300,
                    fontFamily: 'Segoe UI, sans-serif'
                },
                plotOptions: {
                    bar: {
                        borderRadius: 4,
                        horizontal: true,
                    }
                },
                dataLabels: {
                    enabled: false
                },
                xaxis: {
                    categories: chartData.labels,
                },
                title: {
                    text: chartData.title,
                    align: 'center'
                },
                theme: {
                    mode: 'light', 
                    palette: 'palette1'
                }
            };

            if (apexChartInstance) {
                apexChartInstance.destroy();
            }

            const chartEl = document.querySelector("#apexChartContainer");
            chartEl.innerHTML = ""; // Clear previous
            apexChartInstance = new ApexCharts(chartEl, options);
            apexChartInstance.render();
        }

        // Update Charts Dynamically
        function updateCharts(data) {
            const chartData = processDynamicChartData(data);
            
            // Update Chart.js
            if (chartJsInstance) {
                chartJsInstance.data.labels = chartData.labels;
                chartJsInstance.data.datasets[0].label = chartData.title;
                chartJsInstance.data.datasets[0].data = chartData.values;
                chartJsInstance.update();
            }

            // Update ApexCharts
            if (apexChartInstance) {
                apexChartInstance.updateOptions({
                    xaxis: { categories: chartData.labels },
                    title: { text: chartData.title }
                });
                apexChartInstance.updateSeries([{
                    name: chartData.title,
                    data: chartData.values
                }]);
            }
        }

        // Initialize
        apiManager.init();
    </script>
</asp:Content>
