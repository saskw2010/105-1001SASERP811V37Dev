<%@ Control Language="VB" AutoEventWireup="true" CodeFile="classinformation.ascx.vb"
    Inherits="Controls_classinformation" %>

<!-- Modern Class Information Dashboard -->

<style>
    .class-info-container {
        background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
        border-radius: 25px;
        padding: 30px;
        box-shadow: 0 25px 50px rgba(102, 126, 234, 0.3);
        margin: 25px 0;
        position: relative;
        overflow: hidden;
        min-height: 600px;
    }

    .class-info-container::before {
        content: '';
        position: absolute;
        top: -50%;
        left: -50%;
        width: 200%;
        height: 200%;
        background: 
            conic-gradient(from 45deg, rgba(255,255,255,0.1) 0deg, transparent 90deg, rgba(255,255,255,0.05) 180deg, transparent 270deg),
            radial-gradient(circle at 30% 70%, rgba(255,255,255,0.1) 0%, transparent 50%);
        animation: classRotate 30s linear infinite;
        z-index: 1;
    }

    @keyframes classRotate {
        0% { transform: translate(-50%, -50%) rotate(0deg); }
        100% { transform: translate(-50%, -50%) rotate(360deg); }
    }

    .dashboard-header {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 30px;
        margin-bottom: 35px;
        box-shadow: 0 15px 40px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(15px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        position: relative;
        z-index: 2;
        text-align: center;
    }

    .dashboard-title {
        font-size: 2.8rem;
        font-weight: 800;
        background: linear-gradient(135deg, #667eea, #764ba2);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin: 0;
        display: flex;
        align-items: center;
        justify-content: center;
        gap: 15px;
    }

    .title-icon {
        font-size: 3rem;
        background: linear-gradient(135deg, #667eea, #764ba2);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        animation: iconPulse 2s ease-in-out infinite;
    }

    @keyframes iconPulse {
        0%, 100% { transform: scale(1); }
        50% { transform: scale(1.1); }
    }

    .filter-section {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 25px;
        margin-bottom: 30px;
        box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(15px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        position: relative;
        z-index: 2;
    }

    .filter-section::before {
        content: '';
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        height: 4px;
        background: linear-gradient(90deg, #667eea, #764ba2);
        border-radius: 20px 20px 0 0;
    }

    .filter-row {
        display: grid;
        grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
        gap: 20px;
        margin-bottom: 20px;
    }

    .filter-group {
        display: flex;
        flex-direction: column;
        gap: 8px;
    }

    .filter-label {
        font-weight: 600;
        color: #1e293b;
        font-size: 0.95rem;
    }

    .modern-toolbar {
        display: flex;
        flex-wrap: wrap;
        gap: 10px;
    }

    .toolbar-button {
        background: linear-gradient(135deg, #667eea, #764ba2);
        color: white;
        border: none;
        padding: 12px 20px;
        border-radius: 12px;
        font-weight: 600;
        cursor: pointer;
        transition: all 0.3s ease;
        box-shadow: 0 4px 15px rgba(102, 126, 234, 0.3);
        font-size: 0.9rem;
    }

    .toolbar-button:hover {
        transform: translateY(-2px);
        box-shadow: 0 8px 25px rgba(102, 126, 234, 0.4);
    }

    .toolbar-button.active {
        background: linear-gradient(135deg, #764ba2, #667eea);
        transform: scale(1.05);
    }

    .students-grid {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 25px;
        box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(15px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        position: relative;
        z-index: 2;
    }

    .students-container {
        display: grid;
        grid-template-columns: repeat(auto-fill, minmax(280px, 1fr));
        gap: 25px;
        padding: 20px 0;
    }

    .student-card {
        background: rgba(255, 255, 255, 0.98);
        border-radius: 18px;
        padding: 0;
        box-shadow: 0 12px 30px rgba(0, 0, 0, 0.08);
        transition: all 0.4s cubic-bezier(0.175, 0.885, 0.32, 1.275);
        border: 2px solid transparent;
        position: relative;
        overflow: hidden;
        cursor: pointer;
    }

    .student-card:hover {
        transform: translateY(-12px) scale(1.02);
        box-shadow: 0 25px 50px rgba(0, 0, 0, 0.15);
        border-color: #667eea;
    }

    .student-image-container {
        position: relative;
        height: 200px;
        overflow: hidden;
        border-radius: 18px 18px 0 0;
        background: linear-gradient(135deg, #667eea, #764ba2);
        display: flex;
        align-items: center;
        justify-content: center;
    }

    .student-image {
        width: 100%;
        height: 100%;
        object-fit: cover;
        transition: transform 0.4s ease;
    }

    .student-card:hover .student-image {
        transform: scale(1.1);
    }

    .default-avatar {
        font-size: 4rem;
        color: white;
        text-shadow: 2px 2px 4px rgba(0,0,0,0.3);
    }

    .student-info {
        padding: 20px;
        text-align: center;
    }

    .student-name {
        font-size: 1.3rem;
        font-weight: 700;
        color: #1e293b;
        margin: 0 0 8px 0;
        line-height: 1.4;
    }

    .student-code {
        color: #667eea;
        font-weight: 600;
        font-size: 1rem;
        margin-bottom: 10px;
    }

    .student-details {
        color: #64748b;
        font-size: 0.9rem;
        line-height: 1.5;
    }

    .student-tooltip {
        position: absolute;
        background: rgba(0, 0, 0, 0.9);
        color: white;
        padding: 15px;
        border-radius: 12px;
        font-size: 0.9rem;
        box-shadow: 0 10px 30px rgba(0, 0, 0, 0.3);
        z-index: 1000;
        opacity: 0;
        transform: translateY(10px);
        transition: all 0.3s ease;
        pointer-events: none;
        max-width: 250px;
    }

    .student-card:hover .student-tooltip {
        opacity: 1;
        transform: translateY(0);
    }

    .loading-spinner {
        display: flex;
        justify-content: center;
        align-items: center;
        height: 200px;
    }

    .spinner {
        width: 50px;
        height: 50px;
        border: 4px solid rgba(102, 126, 234, 0.3);
        border-top: 4px solid #667eea;
        border-radius: 50%;
        animation: spin 1s linear infinite;
    }

    @keyframes spin {
        0% { transform: rotate(0deg); }
        100% { transform: rotate(360deg); }
    }

    .empty-state {
        text-align: center;
        padding: 60px 20px;
        color: #64748b;
    }

    .empty-state-icon {
        font-size: 4rem;
        margin-bottom: 20px;
        color: #667eea;
    }

    .stats-bar {
        display: flex;
        justify-content: space-around;
        background: rgba(255, 255, 255, 0.9);
        border-radius: 15px;
        padding: 20px;
        margin-bottom: 25px;
        backdrop-filter: blur(10px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        position: relative;
        z-index: 2;
    }

    .stat-item {
        text-align: center;
        flex: 1;
    }

    .stat-number {
        font-size: 2rem;
        font-weight: 700;
        background: linear-gradient(135deg, #667eea, #764ba2);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin-bottom: 5px;
    }

    .stat-label {
        color: #64748b;
        font-size: 0.9rem;
        font-weight: 600;
    }

    /* RTL Support */
    .rtl {
        direction: rtl;
        text-align: right;
    }

    .rtl .dashboard-header,
    .rtl .filter-section,
    .rtl .students-grid {
        text-align: center;
    }

    .rtl .student-info {
        text-align: center;
    }

    /* Responsive Design */
    @media (max-width: 768px) {
        .class-info-container {
            padding: 20px;
            margin: 15px 0;
        }
        
        .dashboard-title {
            font-size: 2.2rem;
            flex-direction: column;
            gap: 10px;
        }
        
        .filter-row {
            grid-template-columns: 1fr;
            gap: 15px;
        }
        
        .students-container {
            grid-template-columns: 1fr;
            gap: 20px;
        }
        
        .stats-bar {
            flex-direction: column;
            gap: 15px;
        }
    }

    @media (max-width: 480px) {
        .dashboard-title {
            font-size: 1.8rem;
        }
        
        .modern-toolbar {
            justify-content: center;
        }
        
        .toolbar-button {
            padding: 10px 16px;
            font-size: 0.85rem;
        }
    }
</style>

<div class="class-info-container rtl">
    <!-- Dashboard Header -->
    <div class="dashboard-header">
        <h1 class="dashboard-title">
            <i class="fas fa-graduation-cap title-icon"></i>
            معلومات الفصول الدراسية
        </h1>
        <p style="color: #64748b; font-size: 1.2rem; margin-top: 15px;">نظام إدارة الطلاب والفصول الدراسية</p>
    </div>

    <!-- Statistics Overview -->
    <div class="stats-bar">
        <div class="stat-item">
            <div class="stat-number" id="totalStudents">156</div>
            <div class="stat-label">إجمالي الطلاب</div>
        </div>
        <div class="stat-item">
            <div class="stat-number" id="activeClasses">12</div>
            <div class="stat-label">الفصول النشطة</div>
        </div>
        <div class="stat-item">
            <div class="stat-number" id="totalBranches">5</div>
            <div class="stat-label">الفروع</div>
        </div>
        <div class="stat-item">
            <div class="stat-number" id="totalGrades">8</div>
            <div class="stat-label">المراحل الدراسية</div>
        </div>
    </div>

    <!-- Filter Section -->
    <div class="filter-section">
        <div class="filter-row">
            <div class="filter-group">
                <label class="filter-label">الفرع</label>
                <div class="modern-toolbar" id="branchToolbar">
                    <asp:Repeater ID="rptBranches" runat="server">
                        <ItemTemplate>
                            <button type="button" class="toolbar-button" 
                                    data-value='<%# Eval("branch") %>'
                                    onclick="filterByBranch(this)">
                                <%# Eval("Desc1") %>
                            </button>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            
            <div class="filter-group">
                <label class="filter-label">المرحلة</label>
                <div class="modern-toolbar" id="stageToolbar">
                    <asp:Repeater ID="rptStages" runat="server">
                        <ItemTemplate>
                            <button type="button" class="toolbar-button"
                                    data-value='<%# Eval("Code") %>'
                                    onclick="filterByStage(this)">
                                <%# Eval("ShortDesc1") %>
                            </button>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
        
        <div class="filter-row">
            <div class="filter-group">
                <label class="filter-label">الصف</label>
                <div class="modern-toolbar" id="gradeToolbar">
                    <asp:Repeater ID="rptGrades" runat="server">
                        <ItemTemplate>
                            <button type="button" class="toolbar-button"
                                    data-value='<%# Eval("GradeCode") %>'
                                    onclick="filterByGrade(this)">
                                <%# Eval("ShortDesc1") %>
                            </button>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
            
            <div class="filter-group">
                <label class="filter-label">الفصل</label>
                <div class="modern-toolbar" id="classToolbar">
                    <asp:Repeater ID="rptClasses" runat="server">
                        <ItemTemplate>
                            <button type="button" class="toolbar-button"
                                    data-value='<%# Eval("classcode") %>'
                                    onclick="filterByClass(this)">
                                <%# Eval("ClassDesc1") %>
                            </button>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
    </div>

    <!-- Students Grid -->
    <div class="students-grid">
        <div id="loadingSpinner" class="loading-spinner" style="display: none;">
            <div class="spinner"></div>
        </div>
        
        <div class="students-container" id="studentsContainer">
            <asp:Repeater ID="rptStudents" runat="server">
                <ItemTemplate>
                    <div class="student-card" onclick="showStudentDetails('<%# Eval("StudentCode") %>')">
                        <div class="student-image-container">
                            <img class="student-image" 
                                 src='<%# GetStudentImagePath(Eval("StudentCode")) %>'
                                 alt='<%# Eval("FirstName1") %>'
                                 onerror="this.style.display='none'; this.parentElement.innerHTML='<div class=\'default-avatar\'><i class=\'fas fa-user-graduate\'></i></div>';" />
                        </div>
                        <div class="student-info">
                            <h3 class="student-name"><%# Eval("FirstName1") %></h3>
                            <div class="student-code"><%# Eval("StudentCode") %></div>
                            <div class="student-details">
                                <%# GetStudentDetails(Container.DataItem) %>
                            </div>
                        </div>
                        <div class="student-tooltip">
                            <strong>كود الطالب:</strong> <%# Eval("StudentCode") %><br/>
                            <strong>الاسم:</strong> <%# Eval("FirstName1") %><br/>
                            <strong>الفصل:</strong> <%# Eval("Class") %><br/>
                            <strong>المرحلة:</strong> <%# Eval("Stage") %>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        
        <div id="emptyState" class="empty-state" style="display: none;">
            <div class="empty-state-icon">
                <i class="fas fa-user-friends"></i>
            </div>
            <h3>لا توجد بيانات طلاب</h3>
            <p>لم يتم العثور على طلاب بالمعايير المحددة</p>
        </div>
    </div>

    <!-- Hidden Data Sources -->
    <aquarium:ControllerDataSource ID="odsBranches" runat="server" 
        DataController="schBranch" DataView="grid1" />
    <aquarium:ControllerDataSource ID="odsStages" runat="server" 
        DataController="schStage" DataView="grid1" />
    <aquarium:ControllerDataSource ID="odsGrades" runat="server" 
        DataController="schGrade" DataView="grid1" />
    <aquarium:ControllerDataSource ID="odsClasses" runat="server" 
        DataController="schClassConfig" DataView="grid1" />
    <aquarium:ControllerDataSource ID="odsStudents" runat="server" 
        DataController="SchStudent" DataView="grid1">
        <FilterParameters>
            <asp:Parameter Name="branch" DefaultValue="0" />
            <asp:Parameter Name="Stage" DefaultValue="0" />
            <asp:Parameter Name="GradeCode" DefaultValue="0" />
            <asp:Parameter Name="[Class]" DefaultValue="0" />
        </FilterParameters>
    </aquarium:ControllerDataSource>
</div>

<script>
// Global filter state
let currentFilters = {
    branch: '0',
    stage: '0',
    grade: '0',
    class: '0'
};

// Initialize dashboard
document.addEventListener('DOMContentLoaded', function() {
    animateStats();
    setupFilterHandlers();
    loadInitialData();
});

// Animate statistics counters
function animateStats() {
    const stats = [
        { element: document.getElementById('totalStudents'), target: 156 },
        { element: document.getElementById('activeClasses'), target: 12 },
        { element: document.getElementById('totalBranches'), target: 5 },
        { element: document.getElementById('totalGrades'), target: 8 }
    ];
    
    stats.forEach(stat => {
        if (stat.element) {
            animateCounter(stat.element, stat.target);
        }
    });
}

// Counter animation function
function animateCounter(element, target) {
    let current = 0;
    const increment = target / 50;
    const timer = setInterval(() => {
        current += increment;
        if (current >= target) {
            current = target;
            clearInterval(timer);
        }
        element.textContent = Math.floor(current);
    }, 20);
}

// Filter handlers
function filterByBranch(button) {
    setActiveButton(button, 'branchToolbar');
    currentFilters.branch = button.dataset.value;
    updateStudentsData();
}

function filterByStage(button) {
    setActiveButton(button, 'stageToolbar');
    currentFilters.stage = button.dataset.value;
    updateStudentsData();
}

function filterByGrade(button) {
    setActiveButton(button, 'gradeToolbar');
    currentFilters.grade = button.dataset.value;
    updateStudentsData();
}

function filterByClass(button) {
    setActiveButton(button, 'classToolbar');
    currentFilters.class = button.dataset.value;
    updateStudentsData();
}

// Set active button state
function setActiveButton(activeButton, toolbarId) {
    const toolbar = document.getElementById(toolbarId);
    const buttons = toolbar.querySelectorAll('.toolbar-button');
    
    buttons.forEach(btn => btn.classList.remove('active'));
    activeButton.classList.add('active');
}

// Update students data
function updateStudentsData() {
    showLoading();
    
    // Simulate API call delay
    setTimeout(() => {
        hideLoading();
        // In real implementation, this would trigger server-side filtering
        console.log('Filtering students with:', currentFilters);
    }, 500);
}

// Loading states
function showLoading() {
    document.getElementById('loadingSpinner').style.display = 'flex';
    document.getElementById('studentsContainer').style.display = 'none';
    document.getElementById('emptyState').style.display = 'none';
}

function hideLoading() {
    document.getElementById('loadingSpinner').style.display = 'none';
    document.getElementById('studentsContainer').style.display = 'grid';
}

// Student details modal (placeholder)
function showStudentDetails(studentCode) {
    console.log('Show details for student:', studentCode);
    
    // Add click animation
    const card = event.currentTarget;
    card.style.transform = 'scale(0.95)';
    setTimeout(() => {
        card.style.transform = '';
    }, 150);
    
    // In real implementation, this would open a modal or navigate to details page
    alert('عرض تفاصيل الطالب: ' + studentCode);
}

// Setup filter handlers
function setupFilterHandlers() {
    // Set first buttons as active by default
    const toolbars = ['branchToolbar', 'stageToolbar', 'gradeToolbar', 'classToolbar'];
    
    toolbars.forEach(toolbarId => {
        const toolbar = document.getElementById(toolbarId);
        const firstButton = toolbar?.querySelector('.toolbar-button');
        if (firstButton) {
            firstButton.classList.add('active');
        }
    });
}

// Load initial data
function loadInitialData() {
    // In real implementation, this would load initial student data
    console.log('Loading initial class information data...');
}

// Performance monitoring
function trackPerformance() {
    if ('performance' in window) {
        window.addEventListener('load', () => {
            const loadTime = performance.timing.loadEventEnd - performance.timing.navigationStart;
            console.log(`Class Information dashboard loaded in ${loadTime}ms`);
        });
    }
}

trackPerformance();
</script>

