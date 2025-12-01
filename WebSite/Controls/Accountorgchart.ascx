<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Accountorgchart.ascx.vb" Inherits="Controls_Accountorgchart"  %>

<!-- Modern Account Organizational Chart -->
<style>
    .modern-orgchart-container {
        background: linear-gradient(135deg, #43e97b 0%, #38f9d7 100%);
        border-radius: 25px;
        padding: 30px;
        box-shadow: 0 20px 40px rgba(67, 233, 123, 0.3);
        margin: 20px 0;
        position: relative;
        overflow: hidden;
        font-family: 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        direction: rtl;
    }

    .modern-orgchart-container::before {
        content: '';
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background: url('data:image/svg+xml,<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 100 100"><defs><pattern id="smallGrid" width="10" height="10" patternUnits="userSpaceOnUse"><path d="M 10 0 L 0 0 0 10" fill="none" stroke="rgba(255,255,255,0.1)" stroke-width="0.5"/></pattern></defs><rect width="100" height="100" fill="url(%23smallGrid)"/></svg>');
        opacity: 0.3;
    }

    .orgchart-header {
        text-align: center;
        margin-bottom: 30px;
        position: relative;
        z-index: 2;
    }

    .orgchart-title {
        color: white;
        font-size: 2.5rem;
        font-weight: 700;
        text-shadow: 2px 2px 4px rgba(0,0,0,0.3);
        margin: 0;
    }

    .orgchart-subtitle {
        color: rgba(255, 255, 255, 0.9);
        font-size: 1.1rem;
        margin-top: 10px;
    }

    .orgchart-controls {
        display: flex;
        gap: 15px;
        margin-bottom: 25px;
        flex-wrap: wrap;
        position: relative;
        z-index: 2;
        justify-content: center;
    }

    .orgchart-btn {
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

    .orgchart-btn:hover {
        background: rgba(255, 255, 255, 0.3);
        transform: translateY(-2px);
    }

    .orgchart-btn.active {
        background: white;
        color: #43e97b;
    }

    .orgchart-content {
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

    .org-tree {
        display: flex;
        flex-direction: column;
        align-items: center;
        min-height: 400px;
    }

    .org-level {
        display: flex;
        justify-content: center;
        gap: 30px;
        margin: 20px 0;
        flex-wrap: wrap;
    }

    .org-node {
        background: linear-gradient(135deg, #43e97b, #38f9d7);
        color: white;
        padding: 20px;
        border-radius: 15px;
        box-shadow: 0 10px 25px rgba(67, 233, 123, 0.3);
        cursor: pointer;
        transition: all 0.3s ease;
        position: relative;
        min-width: 180px;
        text-align: center;
        border: 2px solid transparent;
    }

    .org-node:hover {
        transform: translateY(-5px) scale(1.05);
        box-shadow: 0 15px 35px rgba(67, 233, 123, 0.4);
        border-color: rgba(255, 255, 255, 0.5);
    }

    .org-node.selected {
        background: linear-gradient(135deg, #667eea, #764ba2);
        border-color: white;
    }

    .org-node.checkable {
        cursor: pointer;
    }

    .org-node.checkable::before {
        content: '\f14a';
        font-family: 'Font Awesome 5 Free';
        font-weight: 900;
        position: absolute;
        top: 5px;
        right: 5px;
        font-size: 0.8rem;
        opacity: 0.7;
    }

    .org-node.checked::before {
        content: '\f14a';
        color: #fff;
        opacity: 1;
    }

    .org-node-title {
        font-size: 1.1rem;
        font-weight: 600;
        margin-bottom: 5px;
    }

    .org-node-code {
        font-size: 0.9rem;
        opacity: 0.9;
        font-family: monospace;
    }

    .org-node-level {
        position: absolute;
        top: -8px;
        left: 50%;
        transform: translateX(-50%);
        background: rgba(255, 255, 255, 0.2);
        color: white;
        padding: 2px 8px;
        border-radius: 10px;
        font-size: 0.7rem;
        font-weight: 600;
    }

    .org-connections {
        position: relative;
    }

    .org-line {
        position: absolute;
        background: rgba(67, 233, 123, 0.5);
        height: 2px;
        border-radius: 1px;
    }

    .org-line-vertical {
        width: 2px;
        height: 30px;
        background: rgba(67, 233, 123, 0.5);
        margin: 0 auto;
    }

    .selected-info {
        background: rgba(255, 255, 255, 0.1);
        border-radius: 15px;
        padding: 20px;
        margin-top: 20px;
        color: white;
        text-align: center;
        backdrop-filter: blur(10px);
        border: 1px solid rgba(255, 255, 255, 0.2);
    }

    .selected-info h4 {
        margin-bottom: 10px;
        color: white;
    }

    /* Loading Animation */
    .orgchart-loading {
        text-align: center;
        padding: 3rem;
        color: #43e97b;
    }

    .orgchart-loading i {
        font-size: 3rem;
        animation: bounce 2s infinite;
        margin-bottom: 1rem;
        display: block;
    }

    @keyframes bounce {
        0%, 100% { 
            transform: translateY(0);
        }
        50% { 
            transform: translateY(-20px);
        }
    }

    /* Responsive Design */
    @media (max-width: 768px) {
        .modern-orgchart-container {
            padding: 20px;
            margin: 10px;
        }
        
        .org-level {
            gap: 15px;
        }
        
        .org-node {
            min-width: 150px;
            padding: 15px;
        }
        
        .orgchart-title {
            font-size: 2rem;
        }
        
        .orgchart-controls {
            justify-content: center;
        }
    }
</style>

<div class="ParaHeader"></div>
<div class="ParaInfo">
    <div class="modern-orgchart-container">
        <div class="orgchart-header">
            <h1 class="orgchart-title">
                <i class="fas fa-sitemap" style="margin-left: 15px;"></i>
                الهيكل التنظيمي للحسابات
            </h1>
            <p class="orgchart-subtitle">عرض تفاعلي للشجرة التنظيمية للحسابات</p>
        </div>
        
        <div class="orgchart-controls">
            <button class="orgchart-btn active" onclick="expandAll()">
                <i class="fas fa-expand-arrows-alt"></i> توسيع الكل
            </button>
            <button class="orgchart-btn" onclick="collapseAll()">
                <i class="fas fa-compress-arrows-alt"></i> طي الكل
            </button>
            <button class="orgchart-btn" onclick="toggleSelection()">
                <i class="fas fa-check-square"></i> تبديل التحديد
            </button>
            <button class="orgchart-btn" onclick="resetView()">
                <i class="fas fa-undo"></i> إعادة تعيين
            </button>
            <button class="orgchart-btn" onclick="exportOrgChart()">
                <i class="fas fa-download"></i> تصدير
            </button>
        </div>

        <div class="orgchart-content">
            <div id="orgTreeContainer">
                <div class="orgchart-loading">
                    <i class="fas fa-project-diagram"></i>
                    <p>جاري تحميل الهيكل التنظيمي...</p>
                </div>
            </div>
            
            <div id="selectedInfo" class="selected-info" style="display: none;">
                <h4>تفاصيل العنصر المحدد</h4>
                <div id="selectedDetails"></div>
            </div>
        </div>
    </div>
</div>

<!-- Data Source -->
<asp:SqlDataSource runat="server" ID="SqlDataSource1" 
    SelectCommand="SELECT * FROM Qglmfbandviewtree ORDER BY lvl, Acc_Bnd" />

<!-- Hidden controls for data binding -->
<asp:GridView ID="gvOrgData" runat="server" DataSourceID="SqlDataSource1" 
    Visible="false" AutoGenerateColumns="true" />

<script>
let orgData = [];
let selectedNodes = new Set();
let expandedLevels = new Set();

document.addEventListener('DOMContentLoaded', function() {
    loadOrgChartData();
    renderOrgChart();
});

function loadOrgChartData() {
    // Extract data from GridView (populated from database)
    // This would be populated from the server-side data
    
    // Fallback sample data for demonstration
    orgData = [
        { id: '1', name: 'الحسابات الرئيسية', parentId: null, level: 1, code: 'ACC-001' },
        { id: '1001', name: 'الأصول', parentId: '1', level: 2, code: 'ACC-1001' },
        { id: '1002', name: 'الخصوم', parentId: '1', level: 2, code: 'ACC-1002' },
        { id: '1003', name: 'حقوق الملكية', parentId: '1', level: 2, code: 'ACC-1003' },
        { id: '2001', name: 'الأصول الثابتة', parentId: '1001', level: 3, code: 'ACC-2001' },
        { id: '2002', name: 'الأصول المتداولة', parentId: '1001', level: 3, code: 'ACC-2002' },
        { id: '2003', name: 'الخصوم قصيرة الأجل', parentId: '1002', level: 3, code: 'ACC-2003' },
        { id: '2004', name: 'الخصوم طويلة الأجل', parentId: '1002', level: 3, code: 'ACC-2004' }
    ];
    
    // Initially expand first two levels
    expandedLevels.add(1);
    expandedLevels.add(2);
}

function renderOrgChart() {
    const container = document.getElementById('orgTreeContainer');
    const maxLevel = Math.max(...orgData.map(item => item.level));
    
    let chartHTML = '<div class="org-tree">';
    
    for (let level = 1; level <= maxLevel; level++) {
        const levelNodes = orgData.filter(item => item.level === level);
        if (levelNodes.length === 0) continue;
        
        chartHTML += `<div class="org-level" data-level="${level}">`;
        
        levelNodes.forEach(node => {
            const isVisible = expandedLevels.has(level) || level === 1;
            const hasChildren = orgData.some(item => item.parentId === node.id);
            const isSelected = selectedNodes.has(node.id);
            
            chartHTML += `
                <div class="org-node checkable ${isSelected ? 'selected' : ''}" 
                     data-id="${node.id}" 
                     data-level="${level}"
                     style="display: ${isVisible ? 'block' : 'none'}"
                     onclick="toggleNode('${node.id}')">
                    <div class="org-node-level">المستوى ${level}</div>
                    <div class="org-node-title">${node.name}</div>
                    <div class="org-node-code">${node.code}</div>
                    ${hasChildren ? '<i class="fas fa-chevron-down" style="margin-top: 8px; opacity: 0.7;"></i>' : ''}
                </div>
            `;
        });
        
        chartHTML += '</div>';
        
        // Add connection lines between levels
        if (level < maxLevel) {
            chartHTML += '<div class="org-line-vertical"></div>';
        }
    }
    
    chartHTML += '</div>';
    container.innerHTML = chartHTML;
}

function toggleNode(nodeId) {
    const node = orgData.find(item => item.id === nodeId);
    if (!node) return;
    
    // Toggle selection
    if (selectedNodes.has(nodeId)) {
        selectedNodes.delete(nodeId);
    } else {
        selectedNodes.add(nodeId);
    }
    
    // Update visual state
    const nodeElement = document.querySelector(`[data-id="${nodeId}"]`);
    if (nodeElement) {
        nodeElement.classList.toggle('selected');
    }
    
    // Show selected info
    showSelectedInfo(node);
    
    // Toggle child visibility
    const hasChildren = orgData.some(item => item.parentId === nodeId);
    if (hasChildren) {
        const childLevel = node.level + 1;
        if (expandedLevels.has(childLevel)) {
            expandedLevels.delete(childLevel);
        } else {
            expandedLevels.add(childLevel);
        }
        renderOrgChart();
    }
}

function showSelectedInfo(node) {
    const selectedInfo = document.getElementById('selectedInfo');
    const selectedDetails = document.getElementById('selectedDetails');
    
    selectedDetails.innerHTML = `
        <p><strong>اسم الحساب:</strong> ${node.name}</p>
        <p><strong>رمز الحساب:</strong> ${node.code}</p>
        <p><strong>المستوى:</strong> ${node.level}</p>
        <p><strong>معرف الحساب:</strong> ${node.id}</p>
        ${node.parentId ? `<p><strong>الحساب الأب:</strong> ${orgData.find(item => item.id === node.parentId)?.name || 'غير محدد'}</p>` : ''}
    `;
    
    selectedInfo.style.display = 'block';
}

function expandAll() {
    const maxLevel = Math.max(...orgData.map(item => item.level));
    for (let i = 1; i <= maxLevel; i++) {
        expandedLevels.add(i);
    }
    renderOrgChart();
    updateButtonStates('expand');
}

function collapseAll() {
    expandedLevels.clear();
    expandedLevels.add(1); // Keep root level visible
    renderOrgChart();
    updateButtonStates('collapse');
}

function toggleSelection() {
    if (selectedNodes.size === orgData.length) {
        selectedNodes.clear();
    } else {
        orgData.forEach(node => selectedNodes.add(node.id));
    }
    renderOrgChart();
    updateButtonStates('select');
}

function resetView() {
    selectedNodes.clear();
    expandedLevels.clear();
    expandedLevels.add(1);
    expandedLevels.add(2);
    document.getElementById('selectedInfo').style.display = 'none';
    renderOrgChart();
    updateButtonStates('reset');
}

function updateButtonStates(action) {
    // Remove active class from all buttons
    document.querySelectorAll('.orgchart-btn').forEach(btn => {
        btn.classList.remove('active');
    });
    
    // Add active class to the button that was clicked
    if (action === 'expand') {
        document.querySelector('.orgchart-btn[onclick="expandAll()"]').classList.add('active');
    } else if (action === 'collapse') {
        document.querySelector('.orgchart-btn[onclick="collapseAll()"]').classList.add('active');
    }
}

function exportOrgChart() {
    const selectedData = Array.from(selectedNodes).map(id => 
        orgData.find(item => item.id === id)
    ).filter(item => item);
    
    const dataToExport = selectedData.length > 0 ? selectedData : orgData;
    
    const csvContent = "data:text/csv;charset=utf-8," + 
        "المعرف,الاسم,رمز الحساب,المستوى,الحساب الأب\n" +
        dataToExport.map(item => 
            `${item.id},${item.name},${item.code},${item.level},${item.parentId || ''}`
        ).join("\n");
    
    const encodedUri = encodeURI(csvContent);
    const link = document.createElement("a");
    link.setAttribute("href", encodedUri);
    link.setAttribute("download", "org_chart_data.csv");
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
</script>
   
</div>

