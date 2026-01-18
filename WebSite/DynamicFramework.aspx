<%@ Page Title="Dynamic Framework Viewer" Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="DynamicFramework.aspx.vb" Inherits="DynamicFramework" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <!-- Bootstrap 5 (Scoped to not break legacy styles if possible, or just included) -->
    <!-- Note: Main.master might already have Bootstrap. If not, we add it. -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.rtl.min.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.1/css/all.min.css">
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/chartjs-adapter-date-fns/dist/chartjs-adapter-date-fns.bundle.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/xlsx/0.18.5/xlsx.full.min.js"></script>

    <style>
        /* Scoped Styles for the Dynamic Viewer */
        .dynamic-framework-container {
            --primary-color: #0F4C75;
            --islamic-green: #00A86B;
            --gold: #FFD700;
            --gradient-islamic: linear-gradient(135deg, #00A86B 0%, #FFD700 100%);
            --gradient-tech: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            padding: 20px;
        }

        .dynamic-framework-container .main-card {
            background: rgba(255, 255, 255, 0.95);
            border-radius: 20px;
            padding: 2rem;
            box-shadow: 0 15px 35px rgba(0, 0, 0, 0.15);
            border: 1px solid rgba(255, 255, 255, 0.3);
            margin-bottom: 2rem;
        }

        .dynamic-framework-container .hero-section {
            background: var(--gradient-islamic);
            color: white;
            padding: 2rem;
            border-radius: 15px;
            text-align: center;
            margin-bottom: 2rem;
        }

        .dynamic-framework-container .btn-fetch {
            background: var(--gradient-islamic);
            border: none;
            color: white;
            padding: 0.75rem 2rem;
            border-radius: 25px;
            font-weight: 600;
            transition: all 0.3s ease;
        }

        .dynamic-framework-container .btn-fetch:hover {
            transform: translateY(-2px);
            box-shadow: 0 8px 25px rgba(0, 168, 107, 0.3);
            color: white;
        }

        /* Ensure Bootstrap 5 styles don't conflict too much with legacy */
        .dynamic-framework-container .form-control, 
        .dynamic-framework-container .form-select {
            border-radius: 10px;
            padding: 0.75rem 1rem;
        }
        
        .dynamic-framework-container .table th {
            background-color: #2c3e50 !important;
            color: white !important;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageTitleContentPlaceHolder" Runat="Server">
    Dynamic Framework Viewer (Microservices Ready)
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <div class="dynamic-framework-container">
        
        <!-- Hero Section -->
        <div class="hero-section">
            <h1><i class="fas fa-cubes me-3"></i>إطار العمل الديناميكي الموحد</h1>
            <p class="lead">واجهة واحدة.. لجميع الخدمات (Microservices Ready)</p>
        </div>

        <!-- Control Section -->
        <div class="main-card">
            <div class="row mb-4">
                <div class="col-md-6">
                    <label class="form-label fw-bold">اختر الخدمة / الوحدة (Controller):</label>
                    <select class="form-select" id="endpointSelect">
                        <option value="">-- اختر الوحدة --</option>
                        <option value="projects">Projects - المشاريع</option>
                        <option value="charityprojects">Charity Projects - المشاريع الخيرية</option>
                        <option value="softwareprojects">Software Projects - مشاريع البرمجيات</option>
                        <option value="realestateprojects">Real Estate Projects - المشاريع العقارية</option>
                        <option value="users">Users - المستخدمين</option>
                    </select>
                </div>
                <div class="col-md-4">
                    <label class="form-label fw-bold">الإجراء:</label>
                    <div class="btn-group w-100">
                        <button class="btn btn-outline-primary active" onclick="setMode('list'); return false;"><i class="fas fa-list me-1"></i>عرض</button>
                        <button class="btn btn-outline-success" onclick="setMode('create'); return false;"><i class="fas fa-plus me-1"></i>جديد</button>
                        <button class="btn btn-outline-info" onclick="setMode('analytics'); return false;"><i class="fas fa-chart-pie me-1"></i>تحليل</button>
                    </div>
                </div>
                <div class="col-md-2 d-flex align-items-end">
                    <button class="btn btn-fetch w-100" id="fetchButton" onclick="fetchEndpointData(); return false;">
                        <i class="fas fa-play me-1"></i> تنفيذ
                    </button>
                </div>
            </div>

            <!-- Dynamic Content Area -->
            <div id="dynamicContentArea">
                <div class="alert alert-info text-center">
                    <i class="fas fa-info-circle me-2"></i>
                    الرجاء اختيار وحدة للبدء. سيقوم النظام ببناء الواجهة تلقائياً بناءً على الـ Metadata.
                </div>
            </div>
            
            <!-- Data Grid Container (Hidden by default) -->
            <div id="dataGridContainer" style="display:none;">
                <div class="d-flex justify-content-between align-items-center mb-3">
                    <h5 id="gridTitle">نتائج البحث</h5>
                    <button class="btn btn-sm btn-success" onclick="exportToExcel(); return false;">
                        <i class="fas fa-file-excel me-1"></i> Excel
                    </button>
                </div>
                <div class="table-responsive">
                    <table class="table table-striped table-hover" id="dataTable">
                        <thead>
                            <tr id="tableHeader"></tr>
                        </thead>
                        <tbody id="tableBody"></tbody>
                    </table>
                </div>
            </div>

        </div>
    </div>

    <!-- Include the Configuration Script -->
    <!-- <script src="projects-api-config.js"></script> -->
    
    <!-- Inline Logic for the Framework -->
    <script>
        // Simple Logic to demonstrate the concept
        async function fetchEndpointData() {
            const controller = document.getElementById('endpointSelect').value;
            if (!controller) {
                alert('الرجاء اختيار وحدة أولاً');
                return;
            }

            const contentArea = document.getElementById('dynamicContentArea');
            const gridContainer = document.getElementById('dataGridContainer');
            
            // Show Loading
            contentArea.innerHTML = '<div class="text-center p-5"><div class="spinner-border text-primary"></div><div class="mt-2">جاري الاتصال بـ Microservice...</div></div>';
            gridContainer.style.display = 'none';

            try {
                // Simulate API Call (Using the Config Manager if available, or direct fetch)
                // For demo, we use the window.projectsApiManager we loaded
                
                // 1. Get Metadata/Data
                // Note: In a real scenario, we would call metadata endpoint first.
                // Here we just fetch list to show data.
                
                let data = [];
                
                // Use the existing manager to fetch data
                if (window.projectsApiManager) {
                    // Map selection to manager method
                    let result;
                    if (controller === 'softwareprojects') {
                        result = await window.projectsApiManager.getSoftwareProjects();
                    } else if (controller === 'realestateprojects') {
                        result = await window.projectsApiManager.getRealEstateProjects();
                    } else {
                        // Generic fallback or mock
                        result = { success: true, data: { value: [
                            { ID: 1, Name: 'Project A', Status: 'Active' },
                            { ID: 2, Name: 'Project B', Status: 'Pending' }
                        ]}};
                    }

                    if (result.success && result.data) {
                        // OData usually returns { value: [] } or just []
                        data = result.data.value || result.data;
                        renderGrid(data);
                    } else {
                        throw new Error(result.error || 'Failed to fetch data');
                    }
                } else {
                     // Fallback Mock Data for Legacy Demo
                     setTimeout(() => {
                        const mockData = [
                            { ID: 101, Name: 'Legacy Project Alpha', Status: 'Active', Budget: 50000 },
                            { ID: 102, Name: 'Legacy Project Beta', Status: 'Closed', Budget: 12000 },
                            { ID: 103, Name: 'Legacy Project Gamma', Status: 'Pending', Budget: 75000 }
                        ];
                        renderGrid(mockData);
                     }, 500);
                }

            } catch (error) {
                contentArea.innerHTML = `<div class="alert alert-danger">خطأ: ${error.message}</div>`;
            }
        }

        function renderGrid(data) {
            const contentArea = document.getElementById('dynamicContentArea');
            const gridContainer = document.getElementById('dataGridContainer');
            const tableHeader = document.getElementById('tableHeader');
            const tableBody = document.getElementById('tableBody');

            contentArea.innerHTML = ''; // Clear loading
            gridContainer.style.display = 'block';
            tableHeader.innerHTML = '';
            tableBody.innerHTML = '';

            if (!data || data.length === 0) {
                contentArea.innerHTML = '<div class="alert alert-warning">لا توجد بيانات لعرضها</div>';
                gridContainer.style.display = 'none';
                return;
            }

            // Dynamic Headers
            const columns = Object.keys(data[0]);
            columns.forEach(col => {
                const th = document.createElement('th');
                th.textContent = col;
                tableHeader.appendChild(th);
            });

            // Dynamic Rows
            data.forEach(row => {
                const tr = document.createElement('tr');
                columns.forEach(col => {
                    const td = document.createElement('td');
                    td.textContent = row[col];
                    tr.appendChild(td);
                });
                tableBody.appendChild(tr);
            });
        }

        function setMode(mode) {
            // Visual toggle only for demo
            document.querySelectorAll('.btn-group .btn').forEach(b => b.classList.remove('active'));
            event.target.closest('.btn').classList.add('active');
        }

        function exportToExcel() {
            const table = document.getElementById('dataTable');
            const wb = XLSX.utils.table_to_book(table, {sheet: "Sheet1"});
            XLSX.writeFile(wb, 'Export.xlsx');
        }
    </script>
</asp:Content>
