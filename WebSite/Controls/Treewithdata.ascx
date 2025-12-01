<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Treewithdata.ascx.vb" Inherits="Controls_Treewithdata"  %>

<!-- Modern Tree View Component -->
<div class="modern-tree-container">
    <div class="tree-header">
        <h2 class="tree-title">
            <i class="fas fa-sitemap"></i>
            <span>شجرة البيانات</span>
        </h2>
        <div class="tree-controls">
            <button type="button" class="btn btn-primary btn-sm" onclick="expandAll()">
                <i class="fas fa-expand-arrows-alt"></i>
                توسيع الكل
            </button>
            <button type="button" class="btn btn-secondary btn-sm" onclick="collapseAll()">
                <i class="fas fa-compress-arrows-alt"></i>
                طي الكل
            </button>
            <button type="button" class="btn btn-success btn-sm" onclick="getSelectedItems()">
                <i class="fas fa-check-circle"></i>
                العناصر المحددة
            </button>
            <button type="button" class="btn btn-info btn-sm" onclick="exportData()">
                <i class="fas fa-download"></i>
                تصدير البيانات
            </button>
        </div>
    </div>

    <!-- Search Box -->
    <div class="search-container">
        <div class="search-input-wrapper">
            <i class="fas fa-search"></i>
            <input type="text" id="treeSearch" placeholder="البحث في البيانات..." onkeyup="filterTree(this.value)" />
            <button type="button" class="clear-search" onclick="clearSearch()">
                <i class="fas fa-times"></i>
            </button>
        </div>
    </div>

    <!-- Tree View -->
    <div class="tree-view" id="modernTreeView">
        <asp:Literal ID="litTreeContent" runat="server"></asp:Literal>
    </div>

    <!-- Selected Items Panel -->
    <div class="selected-panel" id="selectedPanel" style="display: none;">
        <div class="selected-header">
            <h4>العناصر المحددة</h4>
            <button type="button" class="btn-close" onclick="hideSelectedPanel()">×</button>
        </div>
        <div class="selected-content" id="selectedContent">
            <!-- Selected items will be populated here -->
        </div>
    </div>

    <!-- Hidden Field for Selected Values -->
    <asp:TextBox type="text" ID="MyTextBox" runat="server" class="MyTextBox" style="display: none;"></asp:TextBox>
    <asp:HiddenField ID="hdnSelectedItems" runat="server" />
    
    <!-- Data Source -->
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" 
        SelectCommand="SELECT * from Qglmfbandviewtree order by lvl,Acc_Bnd"></asp:SqlDataSource>
</div>

<!-- Modern Styles -->
<style>
.modern-tree-container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 2rem;
    font-family: 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    direction: rtl;
    background: linear-gradient(135deg, #f8fafc, #e2e8f0);
    min-height: 100vh;
}

.tree-header {
    display: flex;
    justify-content: space-between;
    align-items: center;
    background: linear-gradient(135deg, #059669, #10b981);
    color: white;
    padding: 2rem;
    border-radius: 20px;
    margin-bottom: 2rem;
    box-shadow: 0 8px 32px rgba(5, 150, 105, 0.3);
}

.tree-title {
    display: flex;
    align-items: center;
    gap: 1rem;
    font-size: 2rem;
    font-weight: 700;
    margin: 0;
}

.tree-controls {
    display: flex;
    gap: 1rem;
    flex-wrap: wrap;
}

.btn {
    display: inline-flex;
    align-items: center;
    gap: 0.5rem;
    padding: 0.75rem 1.5rem;
    border: none;
    border-radius: 12px;
    font-weight: 500;
    font-size: 1rem;
    cursor: pointer;
    transition: all 0.3s ease;
    text-decoration: none;
    box-shadow: 0 4px 12px rgba(0, 0, 0, 0.1);
}

.btn:hover {
    transform: translateY(-2px);
    box-shadow: 0 6px 20px rgba(0, 0, 0, 0.15);
}

.btn-primary {
    background: linear-gradient(135deg, #2563eb, #3b82f6);
    color: white;
}

.btn-secondary {
    background: linear-gradient(135deg, #6b7280, #4b5563);
    color: white;
}

.btn-success {
    background: linear-gradient(135deg, #10b981, #059669);
    color: white;
}

.btn-info {
    background: linear-gradient(135deg, #0ea5e9, #0284c7);
    color: white;
}

.btn-sm {
    padding: 0.5rem 1rem;
    font-size: 0.9rem;
}

.search-container {
    background: white;
    border-radius: 16px;
    padding: 1.5rem;
    margin-bottom: 2rem;
    box-shadow: 0 4px 12px rgba(0, 0, 0, 0.1);
}

.search-input-wrapper {
    position: relative;
    display: flex;
    align-items: center;
}

.search-input-wrapper i.fa-search {
    position: absolute;
    right: 1rem;
    color: #6b7280;
    z-index: 2;
}

.search-input-wrapper input {
    width: 100%;
    padding: 1rem 3rem 1rem 3rem;
    border: 2px solid #e2e8f0;
    border-radius: 12px;
    font-size: 1.1rem;
    transition: all 0.3s ease;
    text-align: right;
}

.search-input-wrapper input:focus {
    outline: none;
    border-color: #10b981;
    box-shadow: 0 0 0 3px rgba(16, 185, 129, 0.1);
}

.clear-search {
    position: absolute;
    left: 1rem;
    background: none;
    border: none;
    color: #6b7280;
    cursor: pointer;
    font-size: 1.2rem;
    transition: color 0.3s ease;
    z-index: 2;
}

.clear-search:hover {
    color: #ef4444;
}

.tree-view {
    background: white;
    border-radius: 16px;
    padding: 2rem;
    box-shadow: 0 8px 32px rgba(0, 0, 0, 0.1);
    max-height: 600px;
    overflow-y: auto;
}

.tree-node {
    margin: 0.5rem 0;
    padding: 0.75rem;
    border-radius: 12px;
    transition: all 0.3s ease;
    cursor: pointer;
    position: relative;
}

.tree-node:hover {
    background: linear-gradient(135deg, rgba(16, 185, 129, 0.1), rgba(5, 150, 105, 0.05));
    transform: translateX(-5px);
}

.tree-node.level-0 {
    background: linear-gradient(135deg, #059669, #10b981);
    color: white;
    font-weight: 700;
    font-size: 1.2rem;
    margin: 1rem 0;
}

.tree-node.level-1 {
    background: linear-gradient(135deg, #34d399, #10b981);
    color: white;
    font-weight: 600;
    margin-right: 2rem;
}

.tree-node.level-2 {
    background: linear-gradient(135deg, #d1fae5, #a7f3d0);
    color: #064e3b;
    font-weight: 500;
    margin-right: 4rem;
}

.tree-node.level-3 {
    background: #f0fdf4;
    color: #166534;
    margin-right: 6rem;
    border-right: 4px solid #bbf7d0;
}

.tree-node.level-4 {
    background: #ffffff;
    color: #374151;
    margin-right: 8rem;
    border-right: 2px solid #d1fae5;
}

.tree-node.level-5 {
    background: #ffffff;
    color: #374151;
    margin-right: 10rem;
    border-right: 2px solid #d1fae5;
    border-left: 4px solid #10b981;
}

.tree-node.checkable {
    padding-right: 3rem;
}

.tree-node.checkable::before {
    content: '';
    position: absolute;
    right: 1rem;
    top: 50%;
    transform: translateY(-50%);
    width: 20px;
    height: 20px;
    border: 2px solid #d1d5db;
    border-radius: 4px;
    background: white;
    transition: all 0.3s ease;
}

.tree-node.checkable.checked::before {
    background: linear-gradient(135deg, #10b981, #059669);
    border-color: #10b981;
}

.tree-node.checkable.checked::after {
    content: '✓';
    position: absolute;
    right: 1.25rem;
    top: 50%;
    transform: translateY(-50%);
    color: white;
    font-weight: bold;
    font-size: 0.9rem;
}

.tree-node.expandable {
    position: relative;
}

.tree-node.expandable::before {
    content: '▼';
    position: absolute;
    left: 1rem;
    top: 50%;
    transform: translateY(-50%);
    transition: transform 0.3s ease;
    font-size: 0.8rem;
    opacity: 0.7;
}

.tree-node.expandable.collapsed::before {
    transform: translateY(-50%) rotate(-90deg);
}

.tree-children {
    overflow: hidden;
    transition: all 0.3s ease;
}

.tree-children.collapsed {
    max-height: 0;
    opacity: 0;
}

.tree-children.expanded {
    max-height: 1000px;
    opacity: 1;
}

.selected-panel {
    position: fixed;
    top: 50%;
    right: 2rem;
    transform: translateY(-50%);
    width: 350px;
    max-height: 70vh;
    background: white;
    border-radius: 16px;
    box-shadow: 0 20px 40px rgba(0, 0, 0, 0.15);
    z-index: 1000;
    overflow: hidden;
}

.selected-header {
    background: linear-gradient(135deg, #10b981, #059669);
    color: white;
    padding: 1.5rem;
    display: flex;
    justify-content: space-between;
    align-items: center;
}

.selected-header h4 {
    margin: 0;
    font-size: 1.2rem;
}

.btn-close {
    background: none;
    border: none;
    color: white;
    font-size: 1.5rem;
    cursor: pointer;
    padding: 0;
    width: 30px;
    height: 30px;
    display: flex;
    align-items: center;
    justify-content: center;
    border-radius: 50%;
    transition: background 0.3s ease;
}

.btn-close:hover {
    background: rgba(255, 255, 255, 0.2);
}

.selected-content {
    padding: 1.5rem;
    max-height: 50vh;
    overflow-y: auto;
}

.selected-item {
    padding: 0.75rem;
    background: #f0fdf4;
    border-radius: 8px;
    margin-bottom: 0.5rem;
    display: flex;
    justify-content: space-between;
    align-items: center;
    border-right: 4px solid #10b981;
}

.selected-item:last-child {
    margin-bottom: 0;
}

.item-info {
    flex: 1;
}

.item-id {
    font-weight: 600;
    color: #064e3b;
}

.item-name {
    font-size: 0.9rem;
    color: #166534;
    margin-top: 0.25rem;
}

.remove-item {
    background: linear-gradient(135deg, #ef4444, #dc2626);
    color: white;
    border: none;
    border-radius: 6px;
    padding: 0.25rem 0.5rem;
    cursor: pointer;
    font-size: 0.8rem;
    transition: all 0.3s ease;
}

.remove-item:hover {
    transform: scale(1.05);
}

/* Animation Effects */
.tree-view {
    animation: slideInUp 0.6s ease-out;
}

@keyframes slideInUp {
    from {
        opacity: 0;
        transform: translateY(30px);
    }
    to {
        opacity: 1;
        transform: translateY(0);
    }
}

/* Responsive Design */
@media (max-width: 768px) {
    .modern-tree-container {
        padding: 1rem;
    }
    
    .tree-header {
        flex-direction: column;
        gap: 1rem;
        text-align: center;
    }
    
    .tree-controls {
        justify-content: center;
    }
    
    .selected-panel {
        position: fixed;
        top: 50%;
        left: 1rem;
        right: 1rem;
        width: auto;
        transform: translateY(-50%);
    }
    
    .tree-node.level-3,
    .tree-node.level-4,
    .tree-node.level-5 {
        margin-right: 2rem;
    }
}

/* Hidden State */
.tree-node.hidden {
    display: none;
}

/* Loading State */
.tree-loading {
    text-align: center;
    padding: 3rem;
    color: #64748b;
}

.tree-loading i {
    font-size: 2rem;
    animation: spin 1s linear infinite;
    margin-bottom: 1rem;
    display: block;
}

@keyframes spin {
    0% { transform: rotate(0deg); }
    100% { transform: rotate(360deg); }
}
</style>

<!-- Modern JavaScript -->
<script>
let selectedItems = new Map();

document.addEventListener('DOMContentLoaded', function() {
    initializeTree();
    
    // Initialize all tree nodes
    const nodes = document.querySelectorAll('.tree-node');
    nodes.forEach(node => {
        // Add click handlers for checkable nodes
        if (node.classList.contains('checkable')) {
            node.addEventListener('click', function(e) {
                e.stopPropagation();
                toggleCheck(this);
            });
        }
        
        // Add click handlers for expandable nodes
        if (node.classList.contains('expandable')) {
            node.addEventListener('click', function(e) {
                if (!e.target.closest('.checkable')) {
                    toggleExpand(this);
                }
            });
        }
    });
});

function initializeTree() {
    // Set initial expanded state for all levels
    const level0Nodes = document.querySelectorAll('.tree-node.level-0, .tree-node.level-1, .tree-node.level-2');
    level0Nodes.forEach(node => {
        if (node.classList.contains('expandable')) {
            expandNode(node);
        }
    });
}

function toggleCheck(node) {
    const nodeId = node.getAttribute('data-id');
    const nodeName = node.getAttribute('data-name');
    
    if (node.classList.contains('checked')) {
        node.classList.remove('checked');
        selectedItems.delete(nodeId);
    } else {
        node.classList.add('checked');
        selectedItems.set(nodeId, {
            id: nodeId,
            name: nodeName,
            element: node
        });
    }
    
    updateSelectedValue();
    updateSelectedPanel();
}

function toggleExpand(node) {
    const childrenContainer = node.nextElementSibling;
    
    if (node.classList.contains('collapsed')) {
        expandNode(node);
    } else {
        collapseNode(node);
    }
}

function expandNode(node) {
    const childrenContainer = node.nextElementSibling;
    
    if (childrenContainer && childrenContainer.classList.contains('tree-children')) {
        node.classList.remove('collapsed');
        childrenContainer.classList.remove('collapsed');
        childrenContainer.classList.add('expanded');
    }
}

function collapseNode(node) {
    const childrenContainer = node.nextElementSibling;
    
    if (childrenContainer && childrenContainer.classList.contains('tree-children')) {
        node.classList.add('collapsed');
        childrenContainer.classList.remove('expanded');
        childrenContainer.classList.add('collapsed');
    }
}

function expandAll() {
    const expandableNodes = document.querySelectorAll('.tree-node.expandable');
    expandableNodes.forEach(node => {
        expandNode(node);
    });
}

function collapseAll() {
    const expandableNodes = document.querySelectorAll('.tree-node.expandable');
    expandableNodes.forEach(node => {
        collapseNode(node);
    });
}

function filterTree(searchTerm) {
    const nodes = document.querySelectorAll('.tree-node');
    searchTerm = searchTerm.toLowerCase().trim();
    
    if (searchTerm === '') {
        // Show all nodes
        nodes.forEach(node => {
            node.classList.remove('hidden');
        });
        return;
    }
    
    nodes.forEach(node => {
        const nodeName = node.getAttribute('data-name') || '';
        const nodeId = node.getAttribute('data-id') || '';
        
        if (nodeName.toLowerCase().includes(searchTerm) || nodeId.toLowerCase().includes(searchTerm)) {
            node.classList.remove('hidden');
            // Also show parent nodes
            showParentNodes(node);
        } else {
            node.classList.add('hidden');
        }
    });
}

function showParentNodes(node) {
    let parent = node.parentElement;
    while (parent && !parent.classList.contains('tree-view')) {
        if (parent.classList.contains('tree-node')) {
            parent.classList.remove('hidden');
        }
        parent = parent.parentElement;
    }
}

function clearSearch() {
    document.getElementById('treeSearch').value = '';
    filterTree('');
}

function getSelectedItems() {
    if (selectedItems.size === 0) {
        alert('لم يتم تحديد أي عناصر');
        return;
    }
    
    updateSelectedPanel();
    showSelectedPanel();
}

function exportData() {
    if (selectedItems.size === 0) {
        alert('لا توجد عناصر محددة للتصدير');
        return;
    }
    
    const data = Array.from(selectedItems.values());
    const csv = generateCSV(data);
    downloadCSV(csv, 'tree_data_export.csv');
}

function generateCSV(data) {
    let csv = 'ID,Name\n';
    data.forEach(item => {
        csv += `"${item.id}","${item.name}"\n`;
    });
    return csv;
}

function downloadCSV(csv, filename) {
    const blob = new Blob([csv], { type: 'text/csv;charset=utf-8;' });
    const link = document.createElement('a');
    const url = URL.createObjectURL(blob);
    link.setAttribute('href', url);
    link.setAttribute('download', filename);
    link.style.visibility = 'hidden';
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

function updateSelectedPanel() {
    const content = document.getElementById('selectedContent');
    
    if (selectedItems.size === 0) {
        content.innerHTML = '<p style="text-align: center; color: #64748b;">لا توجد عناصر محددة</p>';
        return;
    }
    
    let html = '';
    selectedItems.forEach((item, id) => {
        html += `
            <div class="selected-item">
                <div class="item-info">
                    <div class="item-id">${item.id}</div>
                    <div class="item-name">${item.name}</div>
                </div>
                <button type="button" class="remove-item" onclick="removeSelectedItem('${id}')">
                    <i class="fas fa-times"></i>
                </button>
            </div>
        `;
    });
    
    content.innerHTML = html;
}

function removeSelectedItem(itemId) {
    const item = selectedItems.get(itemId);
    if (item && item.element) {
        item.element.classList.remove('checked');
    }
    
    selectedItems.delete(itemId);
    updateSelectedValue();
    updateSelectedPanel();
}

function showSelectedPanel() {
    document.getElementById('selectedPanel').style.display = 'block';
}

function hideSelectedPanel() {
    document.getElementById('selectedPanel').style.display = 'none';
}

function updateSelectedValue() {
    const selectedIds = Array.from(selectedItems.keys());
    document.getElementById('<%=MyTextBox.ClientID %>').value = selectedIds.join(',');
    document.getElementById('<%=hdnSelectedItems.ClientID %>').value = JSON.stringify(Array.from(selectedItems.values()));
}

// Initialize tree on page load
window.addEventListener('load', function() {
    // Trigger any existing dataView integration
    setTimeout(function () {
        if (typeof Web !== 'undefined' && Web.DataView) {
            var dataView = Web.DataView.find('GLmfbab', 'Controller');
            if (dataView) {
                dataView.add_selected(function () {
                    const selectedIds = Array.from(selectedItems.keys());
                    $('.MyTextBox').val(selectedIds.join(','));
                });
            }
        }
    }, 50);
});
</script>