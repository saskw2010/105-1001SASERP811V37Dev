<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Treewithdataspeed.ascx.vb" Inherits="Controls_Treewithdataspeed"  %>

<!-- Modern Tree View Control with High Performance -->
<div class="modern-tree-control">
    <!-- Modern CSS Framework -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" rel="stylesheet">
    
    <style>
        .modern-tree-control {
            --primary-color: #1976d2;
            --secondary-color: #424242;
            --accent-color: #ff5722;
            --success-color: #4caf50;
            --warning-color: #ff9800;
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

        .tree-container {
            background: var(--surface-color);
            border-radius: var(--border-radius);
            box-shadow: var(--elevation-1);
            overflow: hidden;
            margin: 16px 0;
        }

        .tree-header {
            background: linear-gradient(135deg, var(--primary-color), #1565c0);
            color: white;
            padding: 20px;
            display: flex;
            align-items: center;
            justify-content: space-between;
            flex-wrap: wrap;
            gap: 16px;
        }

        .tree-title {
            font-size: 20px;
            font-weight: 500;
            margin: 0;
            display: flex;
            align-items: center;
            gap: 12px;
        }

        .tree-controls {
            display: flex;
            gap: 12px;
            flex-wrap: wrap;
        }

        .modern-button {
            background: rgba(255, 255, 255, 0.1);
            border: 1px solid rgba(255, 255, 255, 0.3);
            color: white;
            border-radius: 8px;
            padding: 8px 16px;
            font-size: 14px;
            font-weight: 500;
            cursor: pointer;
            transition: var(--transition-fast);
            display: flex;
            align-items: center;
            gap: 6px;
            text-decoration: none;
        }

        .modern-button:hover {
            background: rgba(255, 255, 255, 0.2);
            border-color: rgba(255, 255, 255, 0.5);
            color: white;
            transform: translateY(-1px);
            text-decoration: none;
        }

        .search-section {
            background: #f8f9fa;
            border-bottom: 1px solid #dee2e6;
            padding: 20px;
        }

        .search-input-group {
            position: relative;
            max-width: 400px;
        }

        .search-textbox {
            width: 100%;
            padding: 12px 16px 12px 48px;
            border: 2px solid #e0e0e0;
            border-radius: 25px;
            font-size: 16px;
            transition: var(--transition-fast);
            background: var(--surface-color);
        }

        .search-textbox:focus {
            outline: none;
            border-color: var(--primary-color);
            box-shadow: 0 0 0 3px rgba(25, 118, 210, 0.1);
        }

        .search-icon {
            position: absolute;
            left: 16px;
            top: 50%;
            transform: translateY(-50%);
            color: var(--text-secondary);
            pointer-events: none;
        }

        .tree-content {
            padding: 24px;
            max-height: 600px;
            overflow-y: auto;
        }

        .tree-view {
            list-style: none;
            padding: 0;
            margin: 0;
        }

        .tree-node {
            margin: 4px 0;
            border-radius: 8px;
            transition: var(--transition-fast);
        }

        .tree-node:hover {
            background: rgba(25, 118, 210, 0.04);
        }

        .tree-node-content {
            display: flex;
            align-items: center;
            padding: 12px 16px;
            cursor: pointer;
            border-radius: 8px;
            gap: 12px;
            position: relative;
        }

        .tree-node-content:hover {
            background: rgba(25, 118, 210, 0.08);
        }

        .tree-expand-button {
            width: 24px;
            height: 24px;
            border: none;
            background: none;
            cursor: pointer;
            display: flex;
            align-items: center;
            justify-content: center;
            border-radius: 4px;
            transition: var(--transition-fast);
            color: var(--text-secondary);
        }

        .tree-expand-button:hover {
            background: rgba(0, 0, 0, 0.1);
            color: var(--primary-color);
        }

        .tree-expand-button.expanded {
            transform: rotate(90deg);
        }

        .tree-node-icon {
            width: 20px;
            height: 20px;
            display: flex;
            align-items: center;
            justify-content: center;
            color: var(--primary-color);
        }

        .tree-node-label {
            flex: 1;
            font-size: 14px;
            font-weight: 500;
            color: var(--text-primary);
        }

        .tree-node-code {
            font-size: 12px;
            color: var(--text-secondary);
            background: #f0f0f0;
            padding: 2px 8px;
            border-radius: 12px;
            font-family: monospace;
        }

        .tree-checkbox {
            width: 18px;
            height: 18px;
            margin-right: 8px;
            accent-color: var(--primary-color);
        }

        .tree-children {
            margin-left: 32px;
            border-left: 2px solid #e0e0e0;
            padding-left: 16px;
            margin-top: 4px;
            display: none;
        }

        .tree-children.expanded {
            display: block;
            animation: slideDown 0.3s ease-out;
        }

        @keyframes slideDown {
            from {
                opacity: 0;
                max-height: 0;
            }
            to {
                opacity: 1;
                max-height: 1000px;
            }
        }

        .tree-node.level-0 .tree-node-content {
            background: linear-gradient(135deg, #e3f2fd, #bbdefb);
            border: 1px solid #2196f3;
            font-weight: 600;
            margin-bottom: 8px;
        }

        .tree-node.level-1 .tree-node-content {
            background: linear-gradient(135deg, #f3e5f5, #e1bee7);
            border: 1px solid #9c27b0;
            font-weight: 500;
        }

        .tree-node.level-2 .tree-node-content {
            background: linear-gradient(135deg, #e8f5e8, #c8e6c9);
            border: 1px solid #4caf50;
        }

        .tree-node.selected .tree-node-content {
            background: var(--primary-color);
            color: white;
        }

        .tree-node.selected .tree-node-code {
            background: rgba(255, 255, 255, 0.2);
            color: white;
        }

        .export-section {
            background: #f8f9fa;
            border-top: 1px solid #dee2e6;
            padding: 16px 24px;
            display: flex;
            gap: 12px;
            flex-wrap: wrap;
        }

        .export-button {
            background: var(--success-color);
            color: white;
            border: none;
            border-radius: 8px;
            padding: 10px 16px;
            font-size: 14px;
            font-weight: 500;
            cursor: pointer;
            transition: var(--transition-fast);
            display: flex;
            align-items: center;
            gap: 6px;
        }

        .export-button:hover {
            background: #388e3c;
            transform: translateY(-1px);
            box-shadow: var(--elevation-1);
        }

        .stats-panel {
            background: linear-gradient(135deg, #fff3e0, #ffe0b2);
            border: 1px solid var(--warning-color);
            border-radius: var(--border-radius);
            padding: 16px;
            margin-bottom: 16px;
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(120px, 1fr));
            gap: 16px;
        }

        .stat-item {
            text-align: center;
        }

        .stat-number {
            font-size: 24px;
            font-weight: 700;
            color: var(--warning-color);
            display: block;
        }

        .stat-label {
            font-size: 12px;
            color: var(--text-secondary);
            font-weight: 500;
        }

        /* Loading States */
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

        /* RTL Support */
        [dir="rtl"] .tree-children {
            margin-left: 0;
            margin-right: 32px;
            border-left: none;
            border-right: 2px solid #e0e0e0;
            padding-left: 0;
            padding-right: 16px;
        }

        [dir="rtl"] .search-textbox {
            padding-left: 16px;
            padding-right: 48px;
        }

        [dir="rtl"] .search-icon {
            left: auto;
            right: 16px;
        }

        /* Responsive Design */
        @media (max-width: 768px) {
            .tree-header {
                flex-direction: column;
                align-items: stretch;
            }
            
            .tree-controls {
                justify-content: center;
            }
            
            .tree-content {
                padding: 16px;
                max-height: 400px;
            }
            
            .stats-panel {
                grid-template-columns: repeat(2, 1fr);
            }
        }
    </style>

    <script type="text/javascript">
        $(document).ready(function() {
            // Modern DataView integration with enhanced performance
            setTimeout(function () {
                var dataView = Web.DataView.find('GLmfbab', 'Controller');
                if (dataView) {
                    dataView.add_selected(function () {
                        const selectedKey = dataView.get_selectedKey();
                        $('.MyTextBox').val(selectedKey);
                        
                        // Highlight selected node in tree
                        highlightTreeNode(selectedKey);
                        
                        // Show visual feedback
                        showSelectionFeedback(selectedKey);
                    });
                }
            }, 50);

            // Initialize modern tree features
            initializeModernTree();
        });

        function initializeModernTree() {
            // Tree node interactions
            $(document).on('click', '.tree-expand-button', function(e) {
                e.stopPropagation();
                const button = $(this);
                const node = button.closest('.tree-node');
                const children = node.find('> .tree-children');
                
                button.toggleClass('expanded');
                children.toggleClass('expanded');
                
                // Update icon
                const icon = button.find('i');
                if (button.hasClass('expanded')) {
                    icon.removeClass('fa-chevron-right').addClass('fa-chevron-down');
                } else {
                    icon.removeClass('fa-chevron-down').addClass('fa-chevron-right');
                }
            });

            // Node selection
            $(document).on('click', '.tree-node-content', function(e) {
                if (!$(e.target).hasClass('tree-expand-button') && !$(e.target).closest('.tree-expand-button').length) {
                    $('.tree-node').removeClass('selected');
                    $(this).closest('.tree-node').addClass('selected');
                    
                    const nodeId = $(this).data('node-id');
                    const nodeText = $(this).find('.tree-node-label').text();
                    
                    // Update search textbox
                    $('.MyTextBox').val(nodeId);
                    
                    // Show selection feedback
                    showSelectionFeedback(nodeText);
                }
            });

            // Search functionality
            $('.search-textbox').on('input', function() {
                const searchTerm = $(this).val().toLowerCase();
                performTreeSearch(searchTerm);
            });

            // Checkbox interactions
            $(document).on('change', '.tree-checkbox', function() {
                const isChecked = $(this).is(':checked');
                const node = $(this).closest('.tree-node');
                const nodeText = node.find('.tree-node-label').text();
                
                // Update child checkboxes
                node.find('.tree-children .tree-checkbox').prop('checked', isChecked);
                
                // Update parent checkboxes
                updateParentCheckboxes(node);
                
                showSelectionFeedback(`تم ${isChecked ? 'تحديد' : 'إلغاء تحديد'}: ${nodeText}`);
            });

            // Export functionality
            $('.export-button').on('click', function() {
                const exportType = $(this).data('export-type');
                exportTreeData(exportType);
            });

            console.log('Modern Tree Control initialized with enhanced performance');
        }

        function highlightTreeNode(nodeId) {
            $('.tree-node').removeClass('selected');
            $(`.tree-node-content[data-node-id="${nodeId}"]`).closest('.tree-node').addClass('selected');
        }

        function showSelectionFeedback(message) {
            // Create temporary feedback element
            const feedback = $(`
                <div class="selection-feedback" style="
                    position: fixed;
                    top: 20px;
                    left: 50%;
                    transform: translateX(-50%);
                    background: var(--success-color);
                    color: white;
                    padding: 12px 24px;
                    border-radius: 25px;
                    box-shadow: var(--elevation-2);
                    z-index: 1000;
                    font-weight: 500;
                ">
                    <i class="fas fa-check-circle"></i> ${message}
                </div>
            `);
            
            $('body').append(feedback);
            
            setTimeout(function() {
                feedback.fadeOut(function() {
                    feedback.remove();
                });
            }, 3000);
        }

        function performTreeSearch(searchTerm) {
            if (!searchTerm) {
                $('.tree-node').show();
                return;
            }

            $('.tree-node').each(function() {
                const nodeText = $(this).find('.tree-node-label').text().toLowerCase();
                const nodeCode = $(this).find('.tree-node-code').text().toLowerCase();
                
                if (nodeText.includes(searchTerm) || nodeCode.includes(searchTerm)) {
                    $(this).show();
                    // Show parent nodes
                    $(this).parents('.tree-node').show();
                    // Expand parent nodes
                    $(this).parents('.tree-children').addClass('expanded');
                    $(this).parents('.tree-node').find('> .tree-node-content .tree-expand-button').addClass('expanded');
                } else {
                    $(this).hide();
                }
            });
        }

        function updateParentCheckboxes(node) {
            const parent = node.closest('.tree-children').closest('.tree-node');
            if (parent.length) {
                const siblings = parent.find('> .tree-children > .tree-node');
                const checkedSiblings = siblings.find('.tree-checkbox:checked');
                const parentCheckbox = parent.find('> .tree-node-content .tree-checkbox');
                
                if (checkedSiblings.length === siblings.length) {
                    parentCheckbox.prop('checked', true).prop('indeterminate', false);
                } else if (checkedSiblings.length > 0) {
                    parentCheckbox.prop('checked', false).prop('indeterminate', true);
                } else {
                    parentCheckbox.prop('checked', false).prop('indeterminate', false);
                }
                
                updateParentCheckboxes(parent);
            }
        }

        function exportTreeData(exportType) {
            const selectedNodes = [];
            $('.tree-checkbox:checked').each(function() {
                const node = $(this).closest('.tree-node');
                selectedNodes.push({
                    id: node.find('.tree-node-content').data('node-id'),
                    text: node.find('.tree-node-label').text(),
                    code: node.find('.tree-node-code').text()
                });
            });

            if (selectedNodes.length === 0) {
                alert('يرجى تحديد عقد للتصدير');
                return;
            }

            // Show loading
            showLoadingOverlay();

            // Simulate export process
            setTimeout(function() {
                hideLoadingOverlay();
                
                switch(exportType) {
                    case 'pdf':
                        showSelectionFeedback(`تم تصدير ${selectedNodes.length} عقدة إلى PDF`);
                        break;
                    case 'excel':
                        showSelectionFeedback(`تم تصدير ${selectedNodes.length} عقدة إلى Excel`);
                        break;
                    case 'json':
                        downloadAsJson(selectedNodes);
                        break;
                }
            }, 2000);
        }

        function downloadAsJson(data) {
            const jsonData = JSON.stringify(data, null, 2);
            const blob = new Blob([jsonData], { type: 'application/json' });
            const url = URL.createObjectURL(blob);
            const a = document.createElement('a');
            a.href = url;
            a.download = 'tree-export.json';
            document.body.appendChild(a);
            a.click();
            document.body.removeChild(a);
            URL.revokeObjectURL(url);
            
            showSelectionFeedback('تم تنزيل ملف JSON بنجاح');
        }

        function showLoadingOverlay() {
            $('.loading-overlay').addClass('active');
        }

        function hideLoadingOverlay() {
            $('.loading-overlay').removeClass('active');
        }
    </script>

    <div class="tree-container">
        <!-- Header with Controls -->
        <div class="tree-header">
            <h3 class="tree-title">
                <i class="fas fa-sitemap"></i>
                شجرة البيانات المتقدمة
            </h3>
            <div class="tree-controls">
                <button class="modern-button" onclick="expandAllNodes()">
                    <i class="fas fa-expand-alt"></i>
                    توسيع الكل
                </button>
                <button class="modern-button" onclick="collapseAllNodes()">
                    <i class="fas fa-compress-alt"></i>
                    طي الكل
                </button>
                <button class="modern-button" onclick="refreshTreeData()">
                    <i class="fas fa-sync-alt"></i>
                    تحديث
                </button>
            </div>
        </div>

        <!-- Search Section -->
        <div class="search-section">
            <div class="search-input-group">
                <i class="fas fa-search search-icon"></i>
                <asp:TextBox type="text" ID="MyTextBox" runat="server" 
                           CssClass="search-textbox MyTextBox" 
                           placeholder="البحث في الشجرة..." />
            </div>
        </div>

        <!-- Statistics Panel -->
        <div class="stats-panel">
            <div class="stat-item">
                <span class="stat-number" id="totalNodes">0</span>
                <span class="stat-label">إجمالي العقد</span>
            </div>
            <div class="stat-item">
                <span class="stat-number" id="selectedNodes">0</span>
                <span class="stat-label">العقد المحددة</span>
            </div>
            <div class="stat-item">
                <span class="stat-number" id="maxDepth">0</span>
                <span class="stat-label">أقصى عمق</span>
            </div>
            <div class="stat-item">
                <span class="stat-number" id="visibleNodes">0</span>
                <span class="stat-label">العقد المرئية</span>
            </div>
        </div>

        <!-- Tree Content -->
        <div class="tree-content" style="position: relative;">
            <!-- Modern Tree View (Replaces RadTreeView) -->
            <div id="modernTreeView" class="tree-view">
                <!-- Tree nodes will be populated here via JavaScript -->
            </div>

            <!-- Hidden GridView for data binding -->
            <asp:GridView ID="gvTreeData" runat="server" style="display: none;" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Acc_Bnd" HeaderText="Code" />
                    <asp:BoundField DataField="Acc_Nm" HeaderText="Name" />
                    <asp:BoundField DataField="parentid" HeaderText="Parent" />
                    <asp:BoundField DataField="lvl" HeaderText="Level" />
                </Columns>
            </asp:GridView>

            <!-- Loading Overlay -->
            <div class="loading-overlay">
                <div class="loading-spinner"></div>
            </div>
        </div>

        <!-- Export Section -->
        <div class="export-section">
            <button class="export-button" data-export-type="pdf">
                <i class="fas fa-file-pdf"></i>
                تصدير PDF
            </button>
            <button class="export-button" data-export-type="excel">
                <i class="fas fa-file-excel"></i>
                تصدير Excel
            </button>
            <button class="export-button" data-export-type="json">
                <i class="fas fa-file-code"></i>
                تصدير JSON
            </button>
        </div>
    </div>

    <!-- Data Source -->
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" 
        SelectCommand="SELECT * from Qglmfbandviewtree1001 order by lvl,Acc_Bnd">
    </asp:SqlDataSource>

    <script>
        function expandAllNodes() {
            $('.tree-expand-button').addClass('expanded');
            $('.tree-children').addClass('expanded');
            $('.tree-expand-button i').removeClass('fa-chevron-right').addClass('fa-chevron-down');
            showSelectionFeedback('تم توسيع جميع العقد');
        }

        function collapseAllNodes() {
            $('.tree-expand-button').removeClass('expanded');
            $('.tree-children').removeClass('expanded');
            $('.tree-expand-button i').removeClass('fa-chevron-down').addClass('fa-chevron-right');
            showSelectionFeedback('تم طي جميع العقد');
        }

        function refreshTreeData() {
            showLoadingOverlay();
            
            // Simulate data refresh
            setTimeout(function() {
                hideLoadingOverlay();
                showSelectionFeedback('تم تحديث بيانات الشجرة');
                updateTreeStatistics();
            }, 1500);
        }

        function updateTreeStatistics() {
            const totalNodes = $('.tree-node').length;
            const selectedNodes = $('.tree-checkbox:checked').length;
            const visibleNodes = $('.tree-node:visible').length;
            const maxDepth = Math.max(...$('.tree-node').map(function() {
                return $(this).parents('.tree-children').length;
            }).get());

            $('#totalNodes').text(totalNodes);
            $('#selectedNodes').text(selectedNodes);
            $('#visibleNodes').text(visibleNodes);
            $('#maxDepth').text(maxDepth);
        }

        // Initialize statistics on page load
        $(document).ready(function() {
            setTimeout(updateTreeStatistics, 1000);
        });
    </script>
</div>