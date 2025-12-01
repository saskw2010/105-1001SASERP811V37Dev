/* ========================================================================
   🎯 PROFESSIONAL GRID ENHANCEMENTS - JavaScript
   Interactive features for DataView tables
   ======================================================================== */

class ProfessionalGridEnhancer {
    constructor() {
        this.initialized = false;
        this.sortableColumns = new Set();
        this.filterableColumns = new Set();
        this.init();
    }

    init() {
        if (document.readyState === 'loading') {
            document.addEventListener('DOMContentLoaded', () => this.setup());
        } else {
            this.setup();
        }
    }

    setup() {
        console.log('🎯 Initializing Professional Grid Enhancements...');
        
        this.enhanceExistingGrids();
        this.setupMutationObserver();
        this.addKeyboardNavigation();
        this.setupResponsiveFeatures();
        
        this.initialized = true;
        console.log('✅ Professional Grid Enhancements ready!');
    }

    enhanceExistingGrids() {
        const dataViews = document.querySelectorAll('table.DataView');
        
        dataViews.forEach((table, index) => {
            this.enhanceGrid(table, index);
        });
        
        console.log(`🔧 Enhanced ${dataViews.length} DataView tables`);
    }

    enhanceGrid(table, index) {
        if (table.classList.contains('enhanced')) {
            return; // Already enhanced
        }

        // Mark as enhanced
        table.classList.add('enhanced');
        table.setAttribute('data-grid-id', `grid-${index}`);

        // Add loading capability
        this.addLoadingCapability(table);
        
        // Enhance headers
        this.enhanceHeaders(table);
        
        // Enhance rows
        this.enhanceRows(table);
        
        // Add hover effects
        this.addHoverEffects(table);
        
        // Setup cell interactions
        this.setupCellInteractions(table);
        
        console.log(`✨ Enhanced grid #${index}`);
    }

    addLoadingCapability(table) {
        // Add loading state methods
        table.showLoading = function() {
            this.classList.add('loading');
        };
        
        table.hideLoading = function() {
            this.classList.remove('loading');
        };
    }

    enhanceHeaders(table) {
        const headers = table.querySelectorAll('tr.HeaderRow th');
        
        headers.forEach((header, index) => {
            // Add sort capability if there's a link
            const link = header.querySelector('a');
            if (link) {
                this.setupSortableHeader(header, link, index);
            }
            
            // Add resize capability
            this.addColumnResize(header, index);
            
            // Add tooltip
            this.addHeaderTooltip(header);
        });
    }

    setupSortableHeader(header, link, index) {
        header.classList.add('sortable');
        
        // Store original click handler
        const originalHref = link.href;
        
        link.addEventListener('click', (e) => {
            // Add visual feedback
            header.classList.add('sorting');
            
            // Show loading
            const table = header.closest('table');
            if (table && table.showLoading) {
                table.showLoading();
            }
            
            // Allow normal navigation
            setTimeout(() => {
                header.classList.remove('sorting');
            }, 1000);
        });
        
        // Add sort indicator
        const sortIndicator = document.createElement('span');
        sortIndicator.className = 'sort-indicator';
        sortIndicator.innerHTML = '⇅';
        link.appendChild(sortIndicator);
    }

    addColumnResize(header, index) {
        const resizer = document.createElement('div');
        resizer.className = 'column-resizer';
        resizer.innerHTML = '⋮';
        
        let isResizing = false;
        let startX = 0;
        let startWidth = 0;
        
        resizer.addEventListener('mousedown', (e) => {
            isResizing = true;
            startX = e.clientX;
            startWidth = header.offsetWidth;
            document.body.style.cursor = 'col-resize';
            e.preventDefault();
        });
        
        document.addEventListener('mousemove', (e) => {
            if (!isResizing) return;
            
            const deltaX = e.clientX - startX;
            const newWidth = Math.max(50, startWidth + deltaX);
            header.style.width = newWidth + 'px';
        });
        
        document.addEventListener('mouseup', () => {
            if (isResizing) {
                isResizing = false;
                document.body.style.cursor = '';
            }
        });
        
        header.appendChild(resizer);
    }

    addHeaderTooltip(header) {
        const text = header.textContent.trim();
        if (text) {
            header.title = `${text}\nClick to sort • Drag right edge to resize`;
        }
    }

    enhanceRows(table) {
        const rows = table.querySelectorAll('tr.Row, tr.AlternatingRow');
        
        rows.forEach((row, index) => {
            // Add row selection
            this.addRowSelection(row, index);
            
            // Add row actions
            this.addRowContextMenu(row);
            
            // Add loading animation
            if (index % 10 === 0) { // Every 10th row gets fade animation
                row.classList.add('fadeIn');
            }
        });
    }

    addRowSelection(row, index) {
        // Add click handler for row selection
        row.addEventListener('click', (e) => {
            // Don't select if clicking on action buttons or links
            if (e.target.tagName === 'A' || e.target.tagName === 'BUTTON' || 
                e.target.closest('.ActionColumn')) {
                return;
            }
            
            // Toggle selection
            const isSelected = row.classList.contains('Selected');
            
            // Clear other selections if not holding Ctrl
            if (!e.ctrlKey && !e.metaKey) {
                const table = row.closest('table');
                const selectedRows = table.querySelectorAll('tr.Selected');
                selectedRows.forEach(r => r.classList.remove('Selected'));
            }
            
            // Toggle this row
            if (isSelected) {
                row.classList.remove('Selected');
            } else {
                row.classList.add('Selected');
            }
            
            this.updateSelectionInfo(row.closest('table'));
        });
    }

    updateSelectionInfo(table) {
        const selectedRows = table.querySelectorAll('tr.Selected');
        const count = selectedRows.length;
        
        // Dispatch custom event
        const event = new CustomEvent('gridSelectionChanged', {
            detail: {
                table: table,
                selectedCount: count,
                selectedRows: Array.from(selectedRows)
            }
        });
        
        document.dispatchEvent(event);
        
        console.log(`📊 Selected ${count} rows in grid`);
    }

    addRowContextMenu(row) {
        row.addEventListener('contextmenu', (e) => {
            e.preventDefault();
            this.showContextMenu(e, row);
        });
    }

    showContextMenu(e, row) {
        // Remove existing context menu
        const existingMenu = document.querySelector('.grid-context-menu');
        if (existingMenu) {
            existingMenu.remove();
        }
        
        // Create context menu
        const menu = document.createElement('div');
        menu.className = 'grid-context-menu';
        menu.innerHTML = `
            <div class="context-menu-item" data-action="edit">
                <i class="fas fa-edit"></i> تحرير
            </div>
            <div class="context-menu-item" data-action="copy">
                <i class="fas fa-copy"></i> نسخ
            </div>
            <div class="context-menu-item" data-action="delete">
                <i class="fas fa-trash"></i> حذف
            </div>
            <div class="context-menu-separator"></div>
            <div class="context-menu-item" data-action="export">
                <i class="fas fa-download"></i> تصدير
            </div>
        `;
        
        // Position menu
        menu.style.cssText = `
            position: fixed;
            top: ${e.clientY}px;
            left: ${e.clientX}px;
            background: white;
            border: 1px solid #e2e8f0;
            border-radius: 6px;
            box-shadow: 0 10px 15px -3px rgba(0, 0, 0, 0.1);
            z-index: 1000;
            min-width: 150px;
            padding: 4px 0;
            font-family: var(--grid-font-family, 'Cairo');
            font-size: 14px;
        `;
        
        // Add event listeners
        menu.addEventListener('click', (e) => {
            const action = e.target.closest('.context-menu-item')?.dataset.action;
            if (action) {
                this.handleContextAction(action, row);
                menu.remove();
            }
        });
        
        // Remove menu on outside click
        setTimeout(() => {
            document.addEventListener('click', () => menu.remove(), { once: true });
        }, 10);
        
        document.body.appendChild(menu);
    }

    handleContextAction(action, row) {
        console.log(`🎯 Context action: ${action} on row`, row);
        
        switch (action) {
            case 'edit':
                this.editRow(row);
                break;
            case 'copy':
                this.copyRowData(row);
                break;
            case 'delete':
                this.deleteRow(row);
                break;
            case 'export':
                this.exportRow(row);
                break;
        }
    }

    editRow(row) {
        // Find edit button/link in the row
        const editButton = row.querySelector('a[href*="edit"], a[href*="Edit"]');
        if (editButton) {
            editButton.click();
        } else {
            alert('لا يمكن تحرير هذا السجل');
        }
    }

    copyRowData(row) {
        const cells = row.querySelectorAll('td:not(.ActionColumn)');
        const data = Array.from(cells).map(cell => cell.textContent.trim()).join('\t');
        
        if (navigator.clipboard) {
            navigator.clipboard.writeText(data).then(() => {
                this.showToast('تم نسخ البيانات بنجاح');
            });
        } else {
            // Fallback for older browsers
            const textarea = document.createElement('textarea');
            textarea.value = data;
            document.body.appendChild(textarea);
            textarea.select();
            document.execCommand('copy');
            document.body.removeChild(textarea);
            this.showToast('تم نسخ البيانات بنجاح');
        }
    }

    deleteRow(row) {
        if (confirm('هل أنت متأكد من حذف هذا السجل؟')) {
            // Find delete button/link in the row
            const deleteButton = row.querySelector('a[href*="delete"], a[href*="Delete"]');
            if (deleteButton) {
                deleteButton.click();
            } else {
                alert('لا يمكن حذف هذا السجل');
            }
        }
    }

    exportRow(row) {
        const cells = row.querySelectorAll('td:not(.ActionColumn)');
        const headers = row.closest('table').querySelectorAll('tr.HeaderRow th:not(.ActionColumn)');
        
        const data = Array.from(cells).map((cell, index) => {
            const header = headers[index]?.textContent.trim() || `Column ${index + 1}`;
            const value = cell.textContent.trim();
            return `${header}: ${value}`;
        }).join('\n');
        
        this.downloadText(`row-data-${Date.now()}.txt`, data);
    }

    downloadText(filename, text) {
        const element = document.createElement('a');
        element.setAttribute('href', 'data:text/plain;charset=utf-8,' + encodeURIComponent(text));
        element.setAttribute('download', filename);
        element.style.display = 'none';
        document.body.appendChild(element);
        element.click();
        document.body.removeChild(element);
    }

    addHoverEffects(table) {
        const rows = table.querySelectorAll('tr.Row, tr.AlternatingRow');
        
        rows.forEach(row => {
            row.addEventListener('mouseenter', () => {
                // Highlight corresponding column headers
                const cells = row.querySelectorAll('td');
                cells.forEach((cell, index) => {
                    const header = table.querySelector(`tr.HeaderRow th:nth-child(${index + 1})`);
                    if (header) {
                        header.classList.add('column-highlight');
                    }
                });
            });
            
            row.addEventListener('mouseleave', () => {
                // Remove column highlighting
                const headers = table.querySelectorAll('tr.HeaderRow th.column-highlight');
                headers.forEach(header => header.classList.remove('column-highlight'));
            });
        });
    }

    setupCellInteractions(table) {
        const cells = table.querySelectorAll('td.Cell');
        
        cells.forEach(cell => {
            // Add double-click to edit (if applicable)
            cell.addEventListener('dblclick', () => {
                if (cell.classList.contains('ActionColumn')) return;
                
                const row = cell.closest('tr');
                this.editRow(row);
            });
            
            // Add cell type-specific enhancements
            this.enhanceCellByType(cell);
        });
    }

    enhanceCellByType(cell) {
        const text = cell.textContent.trim();
        
        // Detect and enhance numeric cells
        if (/^-?\d+(\.\d+)?$/.test(text)) {
            cell.classList.add('Number');
            this.formatNumber(cell, parseFloat(text));
        }
        
        // Detect and enhance date cells
        if (this.isDate(text)) {
            cell.classList.add('Date');
            this.formatDate(cell, text);
        }
        
        // Detect and enhance status cells
        if (this.isStatus(text)) {
            cell.classList.add('Status');
            this.formatStatus(cell, text);
        }
    }

    formatNumber(cell, number) {
        // Format numbers with proper Arabic/English formatting
        const formatted = new Intl.NumberFormat('ar-SA', {
            minimumFractionDigits: number % 1 === 0 ? 0 : 2,
            maximumFractionDigits: 2
        }).format(number);
        
        cell.textContent = formatted;
        cell.title = `قيمة: ${number}`;
    }

    formatDate(cell, dateText) {
        try {
            const date = new Date(dateText);
            if (!isNaN(date.getTime())) {
                const formatted = new Intl.DateTimeFormat('ar-SA').format(date);
                cell.textContent = formatted;
                cell.title = `تاريخ: ${dateText}`;
            }
        } catch (e) {
            // Keep original text if date parsing fails
        }
    }

    formatStatus(cell, status) {
        const statusLower = status.toLowerCase();
        
        if (statusLower.includes('active') || statusLower.includes('نشط')) {
            cell.innerHTML = `<span class="status-active">${status}</span>`;
        } else if (statusLower.includes('inactive') || statusLower.includes('غير نشط')) {
            cell.innerHTML = `<span class="status-inactive">${status}</span>`;
        } else if (statusLower.includes('pending') || statusLower.includes('معلق')) {
            cell.innerHTML = `<span class="status-pending">${status}</span>`;
        }
    }

    isDate(text) {
        // Simple date detection
        const datePatterns = [
            /^\d{1,2}\/\d{1,2}\/\d{4}$/,
            /^\d{4}-\d{2}-\d{2}$/,
            /^\d{1,2}-\d{1,2}-\d{4}$/
        ];
        
        return datePatterns.some(pattern => pattern.test(text));
    }

    isStatus(text) {
        const statusKeywords = ['active', 'inactive', 'pending', 'نشط', 'غير نشط', 'معلق', 'مفعل', 'غير مفعل'];
        const lowerText = text.toLowerCase();
        return statusKeywords.some(keyword => lowerText.includes(keyword));
    }

    addKeyboardNavigation() {
        document.addEventListener('keydown', (e) => {
            const activeGrid = document.querySelector('table.DataView:focus-within');
            if (!activeGrid) return;
            
            switch (e.key) {
                case 'ArrowUp':
                case 'ArrowDown':
                    this.navigateRows(activeGrid, e.key === 'ArrowUp' ? -1 : 1);
                    e.preventDefault();
                    break;
                case 'Enter':
                    this.activateCurrentRow(activeGrid);
                    e.preventDefault();
                    break;
                case 'Escape':
                    this.clearSelection(activeGrid);
                    e.preventDefault();
                    break;
            }
        });
    }

    navigateRows(table, direction) {
        const rows = table.querySelectorAll('tr.Row, tr.AlternatingRow');
        const currentSelected = table.querySelector('tr.Selected');
        
        let currentIndex = currentSelected ? 
            Array.from(rows).indexOf(currentSelected) : -1;
        
        const newIndex = Math.max(0, Math.min(rows.length - 1, currentIndex + direction));
        
        if (rows[newIndex]) {
            // Clear current selection
            if (currentSelected) {
                currentSelected.classList.remove('Selected');
            }
            
            // Select new row
            rows[newIndex].classList.add('Selected');
            rows[newIndex].scrollIntoView({ behavior: 'smooth', block: 'nearest' });
        }
    }

    activateCurrentRow(table) {
        const selectedRow = table.querySelector('tr.Selected');
        if (selectedRow) {
            this.editRow(selectedRow);
        }
    }

    clearSelection(table) {
        const selectedRows = table.querySelectorAll('tr.Selected');
        selectedRows.forEach(row => row.classList.remove('Selected'));
    }

    setupResponsiveFeatures() {
        // Add horizontal scroll shadows
        this.addScrollShadows();
        
        // Setup responsive column hiding
        this.setupResponsiveColumns();
    }

    addScrollShadows() {
        const containers = document.querySelectorAll('div.DataViewContainer');
        
        containers.forEach(container => {
            container.addEventListener('scroll', () => {
                const scrollLeft = container.scrollLeft;
                const scrollWidth = container.scrollWidth;
                const clientWidth = container.clientWidth;
                
                container.classList.toggle('has-left-shadow', scrollLeft > 0);
                container.classList.toggle('has-right-shadow', 
                    scrollLeft < scrollWidth - clientWidth - 1);
            });
            
            // Initial check
            container.dispatchEvent(new Event('scroll'));
        });
    }

    setupResponsiveColumns() {
        if (window.innerWidth <= 768) {
            const tables = document.querySelectorAll('table.DataView');
            
            tables.forEach(table => {
                // Hide less important columns on mobile
                const headers = table.querySelectorAll('tr.HeaderRow th');
                const rows = table.querySelectorAll('tr.Row, tr.AlternatingRow');
                
                headers.forEach((header, index) => {
                    const headerText = header.textContent.toLowerCase();
                    
                    // Hide columns that are less important on mobile
                    if (index > 3 && !headerText.includes('اسم') && 
                        !headerText.includes('name') && 
                        !headerText.includes('action')) {
                        header.classList.add('mobile-hidden');
                        
                        rows.forEach(row => {
                            const cell = row.querySelector(`td:nth-child(${index + 1})`);
                            if (cell) {
                                cell.classList.add('mobile-hidden');
                            }
                        });
                    }
                });
            });
        }
    }

    setupMutationObserver() {
        // Watch for new grids being added to the page
        const observer = new MutationObserver((mutations) => {
            mutations.forEach((mutation) => {
                mutation.addedNodes.forEach((node) => {
                    if (node.nodeType === 1) { // Element node
                        // Check if the added node is a DataView table
                        if (node.classList && node.classList.contains('DataView')) {
                            this.enhanceGrid(node, Date.now());
                        }
                        
                        // Check for DataView tables within the added node
                        const dataViews = node.querySelectorAll('table.DataView');
                        dataViews.forEach((table, index) => {
                            if (!table.classList.contains('enhanced')) {
                                this.enhanceGrid(table, Date.now() + index);
                            }
                        });
                    }
                });
            });
        });
        
        observer.observe(document.body, {
            childList: true,
            subtree: true
        });
    }

    showToast(message, type = 'success') {
        const toast = document.createElement('div');
        toast.className = `grid-toast toast-${type}`;
        toast.textContent = message;
        
        toast.style.cssText = `
            position: fixed;
            top: 20px;
            right: 20px;
            background: ${type === 'success' ? '#10b981' : '#ef4444'};
            color: white;
            padding: 12px 20px;
            border-radius: 6px;
            box-shadow: 0 4px 6px -1px rgba(0, 0, 0, 0.1);
            z-index: 1000;
            font-family: var(--grid-font-family, 'Cairo');
            transition: all 0.3s ease;
            transform: translateX(100%);
        `;
        
        document.body.appendChild(toast);
        
        // Animate in
        setTimeout(() => {
            toast.style.transform = 'translateX(0)';
        }, 10);
        
        // Animate out and remove
        setTimeout(() => {
            toast.style.transform = 'translateX(100%)';
            setTimeout(() => toast.remove(), 300);
        }, 3000);
    }
}

// Auto-initialize when DOM is ready
document.addEventListener('DOMContentLoaded', () => {
    window.gridEnhancer = new ProfessionalGridEnhancer();
    console.log('🎯 Professional Grid Enhancer loaded and ready!');
});

// Export for global access
window.ProfessionalGridEnhancer = ProfessionalGridEnhancer;

// Additional CSS for enhanced features
const additionalCSS = `
    /* Column resizer styles */
    .column-resizer {
        position: absolute;
        right: 0;
        top: 0;
        bottom: 0;
        width: 4px;
        cursor: col-resize;
        opacity: 0;
        transition: opacity 0.3s ease;
        background: rgba(255, 255, 255, 0.3);
    }
    
    table.DataView tr.HeaderRow th:hover .column-resizer {
        opacity: 1;
    }
    
    /* Sort indicator */
    .sort-indicator {
        margin-left: 6px;
        opacity: 0.7;
        font-size: 12px;
    }
    
    /* Column highlighting */
    table.DataView tr.HeaderRow th.column-highlight {
        background: linear-gradient(135deg, #3b82f6, #1d4ed8) !important;
    }
    
    /* Sorting state */
    table.DataView tr.HeaderRow th.sorting {
        opacity: 0.7;
    }
    
    /* Mobile hidden columns */
    @media (max-width: 768px) {
        .mobile-hidden {
            display: none !important;
        }
    }
    
    /* Scroll shadows */
    div.DataViewContainer.has-left-shadow::before {
        content: '';
        position: absolute;
        left: 0;
        top: 0;
        bottom: 0;
        width: 10px;
        background: linear-gradient(to right, rgba(0,0,0,0.1), transparent);
        z-index: 1;
        pointer-events: none;
    }
    
    div.DataViewContainer.has-right-shadow::after {
        content: '';
        position: absolute;
        right: 0;
        top: 0;
        bottom: 0;
        width: 10px;
        background: linear-gradient(to left, rgba(0,0,0,0.1), transparent);
        z-index: 1;
        pointer-events: none;
    }
    
    /* Context menu styles */
    .context-menu-item {
        padding: 8px 16px;
        cursor: pointer;
        display: flex;
        align-items: center;
        gap: 8px;
        transition: background 0.2s ease;
    }
    
    .context-menu-item:hover {
        background: #f1f5f9;
    }
    
    .context-menu-separator {
        height: 1px;
        background: #e2e8f0;
        margin: 4px 0;
    }
`;

// Inject additional CSS
const styleSheet = document.createElement('style');
styleSheet.textContent = additionalCSS;
document.head.appendChild(styleSheet);
