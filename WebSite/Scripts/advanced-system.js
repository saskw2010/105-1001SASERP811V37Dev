/* Advanced JavaScript System - النظام التفاعلي المتقدم */
/* دمج كل التقنيات المكتشفة من جميع الملفات */

// ===== MAIN SYSTEM CLASS =====
class AdvancedSystemController {
    constructor() {
        this.navigationSystem = null;
        this.themeController = null;
        this.notificationCenter = null;
        this.dataTableManager = null;
        this.formManager = null;
        this.loadingManager = null;
        
        this.init();
    }

    init() {
        console.log('🚀 Advanced System Controller - تهيئة النظام المتقدم');
        
        // انتظار تحميل الصفحة
        if (document.readyState === 'loading') {
            document.addEventListener('DOMContentLoaded', () => this.initializeComponents());
        } else {
            this.initializeComponents();
        }
    }

    initializeComponents() {
        try {
            // تهيئة جميع المكونات
            this.navigationSystem = new AdvancedNavigation();
            this.themeController = new AdvancedThemeController();
            this.notificationCenter = new AdvancedNotificationCenter();
            this.dataTableManager = new AdvancedDataTableManager();
            this.formManager = new AdvancedFormManager();
            this.loadingManager = new AdvancedLoadingManager();
            
            // تطبيق التحسينات على العناصر الحالية
            this.enhanceExistingElements();
            
            // إعداد مراقبة التغييرات
            this.setupMutationObserver();
            
            console.log('✅ جميع المكونات تم تهيئتها بنجاح');
            
            // إشعار النجاح
            this.notificationCenter.show('تم تحميل النظام المتقدم بنجاح!', 'success');
            
        } catch (error) {
            console.error('❌ خطأ في تهيئة النظام:', error);
        }
    }

    enhanceExistingElements() {
        // تحسين الجداول الحالية
        this.enhanceTables();
        
        // تحسين الأزرار الحالية
        this.enhanceButtons();
        
        // تحسين النماذج الحالية
        this.enhanceForms();
        
        // تحسين البطاقات الحالية
        this.enhanceCards();
    }

    enhanceTables() {
        const tables = document.querySelectorAll('table');
        tables.forEach(table => {
            if (!table.classList.contains('enhanced')) {
                table.classList.add('advanced');
                table.classList.add('enhanced');
                
                // إضافة حاوي متقدم
                const container = document.createElement('div');
                container.className = 'advanced-container';
                table.parentNode.insertBefore(container, table);
                container.appendChild(table);
                
                // تحسين أزرار الإجراءات
                this.enhanceActionButtons(table);
                
                console.log('📊 تم تحسين الجدول');
            }
        });
    }

    enhanceActionButtons(table) {
        const actionCells = table.querySelectorAll('td.ActionColumn, td[class*="Action"]');
        actionCells.forEach(cell => {
            const links = cell.querySelectorAll('a');
            links.forEach(link => {
                if (!link.classList.contains('enhanced')) {
                    link.classList.add('advanced-action-button');
                    
                    // تحديد نوع الزر بناء على النص أو الـ href
                    const text = link.textContent.toLowerCase();
                    const href = link.href.toLowerCase();
                    
                    if (text.includes('edit') || text.includes('تعديل') || href.includes('edit')) {
                        link.classList.add('primary');
                    } else if (text.includes('delete') || text.includes('حذف') || href.includes('delete')) {
                        link.classList.add('danger');
                    } else if (text.includes('view') || text.includes('عرض') || href.includes('view')) {
                        link.classList.add('success');
                    } else {
                        link.classList.add('primary');
                    }
                    
                    link.classList.add('enhanced');
                }
            });
        });
    }

    enhanceButtons() {
        const buttons = document.querySelectorAll('input[type="button"], input[type="submit"], button');
        buttons.forEach(button => {
            if (!button.classList.contains('enhanced')) {
                button.classList.add('advanced-button');
                
                // تحديد نوع الزر
                const text = button.value || button.textContent || '';
                if (text.includes('Save') || text.includes('حفظ')) {
                    button.classList.add('primary');
                } else if (text.includes('Cancel') || text.includes('إلغاء')) {
                    button.classList.add('secondary');
                } else {
                    button.classList.add('outline');
                }
                
                button.classList.add('enhanced');
            }
        });
    }

    enhanceForms() {
        const forms = document.querySelectorAll('form, .FormView');
        forms.forEach(form => {
            if (!form.classList.contains('enhanced')) {
                // إضافة حاوي متقدم للنماذج
                if (!form.parentNode.classList.contains('advanced-form-container')) {
                    const container = document.createElement('div');
                    container.className = 'advanced-form-container';
                    form.parentNode.insertBefore(container, form);
                    container.appendChild(form);
                }
                
                // تحسين حقول الإدخال
                this.enhanceInputFields(form);
                
                form.classList.add('enhanced');
            }
        });
    }

    enhanceInputFields(form) {
        const inputs = form.querySelectorAll('input[type="text"], input[type="email"], input[type="password"], textarea, select');
        inputs.forEach(input => {
            if (!input.classList.contains('enhanced')) {
                if (input.tagName.toLowerCase() === 'select') {
                    input.classList.add('advanced-select');
                } else {
                    input.classList.add('advanced-input');
                }
                
                // إضافة تسمية عائمة إذا لم تكن موجودة
                if (!input.previousElementSibling || !input.previousElementSibling.classList.contains('advanced-label')) {
                    const label = document.createElement('label');
                    label.className = 'advanced-label';
                    label.textContent = input.placeholder || input.title || 'Field';
                    input.parentNode.insertBefore(label, input.nextSibling);
                    
                    // إضافة حاوي للمجموعة
                    const group = document.createElement('div');
                    group.className = 'advanced-form-group';
                    input.parentNode.insertBefore(group, input);
                    group.appendChild(input);
                    group.appendChild(label);
                }
                
                input.classList.add('enhanced');
            }
        });
    }

    enhanceCards() {
        const cards = document.querySelectorAll('.TaskBox, .Panel, .Card');
        cards.forEach(card => {
            if (!card.classList.contains('enhanced')) {
                card.classList.add('advanced-card');
                
                // إضافة أيقونة للبطاقة إذا لم تكن موجودة
                const header = card.querySelector('h1, h2, h3, .TaskBoxHeaderText');
                if (header && !header.querySelector('.advanced-card-icon')) {
                    header.classList.add('advanced-card-header');
                    const icon = document.createElement('div');
                    icon.className = 'advanced-card-icon';
                    icon.innerHTML = '📊';
                    header.insertBefore(icon, header.firstChild);
                }
                
                card.classList.add('enhanced');
            }
        });
    }

    setupMutationObserver() {
        const observer = new MutationObserver((mutations) => {
            mutations.forEach((mutation) => {
                if (mutation.type === 'childList') {
                    mutation.addedNodes.forEach((node) => {
                        if (node.nodeType === Node.ELEMENT_NODE) {
                            // تحسين العناصر الجديدة
                            this.enhanceNewElement(node);
                        }
                    });
                }
            });
        });

        observer.observe(document.body, {
            childList: true,
            subtree: true
        });
    }

    enhanceNewElement(element) {
        // تحسين الجداول الجديدة
        if (element.matches && element.matches('table')) {
            setTimeout(() => this.enhanceTables(), 100);
        }
        
        // تحسين الأزرار الجديدة
        if (element.matches && (element.matches('input[type="button"]') || element.matches('button'))) {
            setTimeout(() => this.enhanceButtons(), 100);
        }
        
        // البحث عن عناصر فرعية
        if (element.querySelectorAll) {
            const tables = element.querySelectorAll('table');
            if (tables.length > 0) {
                setTimeout(() => this.enhanceTables(), 100);
            }
            
            const buttons = element.querySelectorAll('input[type="button"], button');
            if (buttons.length > 0) {
                setTimeout(() => this.enhanceButtons(), 100);
            }
        }
    }
}

// ===== ADVANCED NAVIGATION SYSTEM =====
class AdvancedNavigation {
    constructor() {
        this.isOpen = false;
        this.init();
    }

    init() {
        // Removed createNavigationMenu() - now handled by master-prompt-menu.js
        this.setupEventListeners();
        console.log('🎨 [AdvancedNavigation] System initialized (navigation menu handled by MasterPromptSystem)');
    }

    // createNavigationMenu() method removed - navigation now handled by master-prompt-menu.js

    setupEventListeners() {
        // Navigation event listeners removed - handled by MasterPromptSystem
        console.log('🎨 [AdvancedNavigation] Event listeners setup (navigation handled by MasterPromptSystem)');
    }

    // Navigation methods removed since handled by MasterPromptSystem
    // toggle(), close() methods removed

    // Keep only the action handlers for integration with MasterPromptSystem
    handleAction(action) {
        switch(action) {
            case 'theme':
                if (window['advancedSystem'] && window['advancedSystem'].themeController) {
                    window['advancedSystem'].themeController.toggleTheme();
                }
                break;
            case 'refresh':
                window.location.reload();
                break;
            case 'print':
                window.print();
                break;
            case 'fullscreen':
                this.toggleFullscreen();
                break;
            case 'export':
                this.exportData();
                break;
        }
    }

    toggleFullscreen() {
        if (!document.fullscreenElement) {
            document.documentElement.requestFullscreen();
        } else {
            document.exitFullscreen();
        }
    }

    exportData() {
        const tables = document.querySelectorAll('table');
        if (tables.length > 0) {
            this.exportTableToCSV(tables[0]);
        }
    }

    exportTableToCSV(table) {
        let csv = [];
        const rows = table.querySelectorAll('tr');
        
        rows.forEach(row => {
            const cols = row.querySelectorAll('td, th');
            const rowData = [];
            cols.forEach(col => {
                rowData.push('"' + col.textContent.replace(/"/g, '""') + '"');
            });
            csv.push(rowData.join(','));
        });

        const csvContent = csv.join('\n');
        const blob = new Blob([csvContent], { type: 'text/csv;charset=utf-8;' });
        const link = document.createElement('a');
        const url = URL.createObjectURL(blob);
        link.setAttribute('href', url);
        link.setAttribute('download', 'data_export.csv');
        link.style.visibility = 'hidden';
        document.body.appendChild(link);
        link.click();
        document.body.removeChild(link);
    }
}

// ===== ADVANCED THEME CONTROLLER =====
class AdvancedThemeController {
    constructor() {
        this.currentTheme = 'blue';
        this.themes = {
            blue: {
                primary: '#2563eb',
                secondary: '#3b82f6',
                accent: '#1d4ed8'
            },
            purple: {
                primary: '#7c3aed',
                secondary: '#8b5cf6',
                accent: '#6d28d9'
            },
            green: {
                primary: '#10b981',
                secondary: '#34d399',
                accent: '#059669'
            },
            orange: {
                primary: '#f59e0b',
                secondary: '#fbbf24',
                accent: '#d97706'
            }
        };
        this.init();
    }

    init() {
        // تحميل المظهر المحفوظ
        const savedTheme = localStorage.getItem('advanced-theme');
        if (savedTheme && this.themes[savedTheme]) {
            this.currentTheme = savedTheme;
        }
        this.applyTheme(this.currentTheme);
    }

    toggleTheme() {
        const themeNames = Object.keys(this.themes);
        const currentIndex = themeNames.indexOf(this.currentTheme);
        const nextIndex = (currentIndex + 1) % themeNames.length;
        const newTheme = themeNames[nextIndex];
        
        this.setTheme(newTheme);
    }

    setTheme(themeName) {
        if (this.themes[themeName]) {
            this.currentTheme = themeName;
            this.applyTheme(themeName);
            localStorage.setItem('advanced-theme', themeName);
            
            if (window.advancedSystem.notificationCenter) {
                window.advancedSystem.notificationCenter.show(
                    `تم تطبيق مظهر ${themeName}`, 
                    'success'
                );
            }
        }
    }

    applyTheme(themeName) {
        const theme = this.themes[themeName];
        const root = document.documentElement;
        
        root.style.setProperty('--primary-color', theme.primary);
        root.style.setProperty('--primary-blue', theme.primary);
        root.style.setProperty('--secondary-blue', theme.secondary);
        root.style.setProperty('--accent-blue', theme.accent);
        
        // تحديث المتدرجات
        root.style.setProperty('--gradient-primary', 
            `linear-gradient(135deg, ${theme.primary} 0%, ${theme.secondary} 100%)`);
        
        // تحديث الظلال
        const rgba = this.hexToRgba(theme.primary, 0.2);
        root.style.setProperty('--shadow-blue', `0 4px 15px ${rgba}`);
    }

    hexToRgba(hex, alpha) {
        const r = parseInt(hex.slice(1, 3), 16);
        const g = parseInt(hex.slice(3, 5), 16);
        const b = parseInt(hex.slice(5, 7), 16);
        return `rgba(${r}, ${g}, ${b}, ${alpha})`;
    }
}

// ===== ADVANCED NOTIFICATION CENTER =====
class AdvancedNotificationCenter {
    constructor() {
        this.notifications = [];
        this.container = null;
        this.init();
    }

    init() {
        this.createContainer();
    }

    createContainer() {
        this.container = document.createElement('div');
        this.container.className = 'advanced-notifications-container';
        this.container.style.position = 'fixed';
        this.container.style.top = '20px';
        this.container.style.right = '20px';
        this.container.style.zIndex = '10000';
        this.container.style.pointerEvents = 'none';
        document.body.appendChild(this.container);
    }

    show(message, type = 'info', title = '', duration = 5000) {
        const notification = this.createNotification(message, type, title);
        this.container.appendChild(notification);
        
        // إظهار الإشعار
        setTimeout(() => {
            notification.classList.add('show');
        }, 100);
        
        // إخفاء الإشعار تلقائياً
        setTimeout(() => {
            this.hide(notification);
        }, duration);
        
        return notification;
    }

    createNotification(message, type, title) {
        const notification = document.createElement('div');
        notification.className = `advanced-notification ${type}`;
        notification.style.pointerEvents = 'auto';
        notification.style.marginBottom = '10px';
        
        const icons = {
            success: '✓',
            error: '✕',
            warning: '⚠',
            info: 'ℹ'
        };
        
        notification.innerHTML = `
            <div class="advanced-notification-content">
                <div class="advanced-notification-icon">${icons[type] || icons.info}</div>
                <div class="advanced-notification-text">
                    ${title ? `<div class="advanced-notification-title">${title}</div>` : ''}
                    <div>${message}</div>
                </div>
                <button class="advanced-notification-close">✕</button>
            </div>
        `;
        
        // إضافة مستمع إغلاق
        const closeBtn = notification.querySelector('.advanced-notification-close');
        closeBtn.addEventListener('click', () => {
            this.hide(notification);
        });
        
        return notification;
    }

    hide(notification) {
        notification.classList.remove('show');
        setTimeout(() => {
            if (notification.parentNode) {
                notification.parentNode.removeChild(notification);
            }
        }, 300);
    }

    success(message, title = '') {
        return this.show(message, 'success', title);
    }

    error(message, title = '') {
        return this.show(message, 'error', title);
    }

    warning(message, title = '') {
        return this.show(message, 'warning', title);
    }

    info(message, title = '') {
        return this.show(message, 'info', title);
    }
}

// ===== ADVANCED DATA TABLE MANAGER =====
class AdvancedDataTableManager {
    constructor() {
        this.tables = [];
        this.init();
    }

    init() {
        this.enhanceExistingTables();
        this.setupTableFeatures();
    }

    enhanceExistingTables() {
        const tables = document.querySelectorAll('table');
        tables.forEach(table => this.enhanceTable(table));
    }

    setupTableFeatures() {
        // إعداد ميزات إضافية للجداول
        console.log('تم إعداد ميزات الجداول المتقدمة');
        
        // إضافة CSS للجداول المحسنة
        if (!document.getElementById('advanced-table-styles')) {
            const tableStyles = document.createElement('style');
            tableStyles.id = 'advanced-table-styles';
            tableStyles.textContent = `
                .table-search input:focus {
                    outline: none;
                    border-color: var(--blue-500, #3b82f6);
                    box-shadow: 0 0 0 3px rgba(59, 130, 246, 0.1);
                }
                .enhanced-table th {
                    background: linear-gradient(135deg, #f8fafc, #e2e8f0);
                    transition: all 0.3s ease;
                }
                .enhanced-table th:hover {
                    background: linear-gradient(135deg, #e2e8f0, #cbd5e1);
                }
            `;
            document.head.appendChild(tableStyles);
        }
    }

    enhanceTable(table) {
        if (table.dataset.enhanced) return;
        
        // إضافة ميزات متقدمة للجدول
        this.addTableSearch(table);
        this.addTableSort(table);
        this.addRowHover(table);
        this.addLoadingState(table);
        
        table.dataset.enhanced = 'true';
        this.tables.push(table);
    }

    addTableSearch(table) {
        const container = table.closest('.advanced-container');
        if (!container || container.querySelector('.table-search')) return;
        
        const searchContainer = document.createElement('div');
        searchContainer.className = 'table-search';
        searchContainer.style.padding = '15px';
        searchContainer.style.borderBottom = '1px solid #e5e7eb';
        
        searchContainer.innerHTML = `
            <div style="display: flex; align-items: center; gap: 10px;">
                <input type="text" placeholder="البحث في الجدول..." 
                       style="flex: 1; padding: 8px 12px; border: 1px solid #d1d5db; border-radius: 6px;">
                <button style="padding: 8px 16px; background: var(--gradient-primary); color: white; border: none; border-radius: 6px; cursor: pointer;">
                    بحث
                </button>
            </div>
        `;
        
        container.insertBefore(searchContainer, table);
        
        // إضافة وظيفة البحث
        const input = searchContainer.querySelector('input');
        const button = searchContainer.querySelector('button');
        
        const search = () => {
            const searchTerm = input.value.toLowerCase();
            const rows = table.querySelectorAll('tr.Row, tr.AlternatingRow');
            
            rows.forEach(row => {
                const text = row.textContent.toLowerCase();
                row.style.display = text.includes(searchTerm) ? '' : 'none';
            });
        };
        
        input.addEventListener('input', search);
        button.addEventListener('click', search);
    }

    addTableSort(table) {
        const headers = table.querySelectorAll('th');
        headers.forEach((header, index) => {
            header.style.cursor = 'pointer';
            header.style.userSelect = 'none';
            header.title = 'انقر للترتيب';
            
            header.addEventListener('click', () => {
                this.sortTable(table, index);
            });
        });
    }

    sortTable(table, columnIndex) {
        const rows = Array.from(table.querySelectorAll('tr.Row, tr.AlternatingRow'));
        const isAscending = table.dataset.sortDirection !== 'asc';
        
        rows.sort((a, b) => {
            const aText = a.cells[columnIndex]?.textContent || '';
            const bText = b.cells[columnIndex]?.textContent || '';
            
            const comparison = aText.localeCompare(bText, 'ar', { numeric: true });
            return isAscending ? comparison : -comparison;
        });
        
        const tbody = table.querySelector('tbody') || table;
        rows.forEach(row => tbody.appendChild(row));
        
        table.dataset.sortDirection = isAscending ? 'asc' : 'desc';
        
        // تحديث مؤشر الترتيب
        const headers = table.querySelectorAll('th');
        headers.forEach(h => h.classList.remove('sorted-asc', 'sorted-desc'));
        headers[columnIndex].classList.add(isAscending ? 'sorted-asc' : 'sorted-desc');
    }

    addRowHover(table) {
        const rows = table.querySelectorAll('tr.Row, tr.AlternatingRow');
        rows.forEach(row => {
            row.addEventListener('mouseenter', () => {
                row.style.transform = 'translateX(4px)';
            });
            
            row.addEventListener('mouseleave', () => {
                row.style.transform = '';
            });
        });
    }

    addLoadingState(table) {
        table.loadingOverlay = window.advancedSystem.loadingManager.create(table);
    }

    showLoading(table) {
        if (table.loadingOverlay) {
            table.loadingOverlay.show();
        }
    }

    hideLoading(table) {
        if (table.loadingOverlay) {
            table.loadingOverlay.hide();
        }
    }
}

// ===== ADVANCED FORM MANAGER =====
class AdvancedFormManager {
    constructor() {
        this.forms = [];
        this.init();
    }

    init() {
        this.enhanceExistingForms();
    }

    enhanceExistingForms() {
        const forms = document.querySelectorAll('form, .FormView');
        forms.forEach(form => this.enhanceForm(form));
    }

    enhanceForm(form) {
        if (form.dataset.enhanced) return;
        
        this.addFormValidation(form);
        this.addInputAnimations(form);
        this.addSubmitHandling(form);
        
        form.dataset.enhanced = 'true';
        this.forms.push(form);
    }

    addFormValidation(form) {
        const inputs = form.querySelectorAll('input, select, textarea');
        inputs.forEach(input => {
            input.addEventListener('blur', () => this.validateField(input));
            input.addEventListener('input', () => this.clearValidation(input));
        });
    }

    validateField(input) {
        const value = input.value.trim();
        const isRequired = input.hasAttribute('required') || input.classList.contains('required');
        
        if (isRequired && !value) {
            this.showFieldError(input, 'هذا الحقل مطلوب');
            return false;
        }
        
        if (input.type === 'email' && value && !this.isValidEmail(value)) {
            this.showFieldError(input, 'البريد الإلكتروني غير صحيح');
            return false;
        }
        
        this.clearFieldError(input);
        return true;
    }

    showFieldError(input, message) {
        this.clearFieldError(input);
        
        const errorDiv = document.createElement('div');
        errorDiv.className = 'field-error';
        errorDiv.style.color = '#ef4444';
        errorDiv.style.fontSize = '12px';
        errorDiv.style.marginTop = '4px';
        errorDiv.textContent = message;
        
        input.style.borderColor = '#ef4444';
        input.parentNode.appendChild(errorDiv);
    }

    clearFieldError(input) {
        input.style.borderColor = '';
        const error = input.parentNode.querySelector('.field-error');
        if (error) {
            error.remove();
        }
    }

    clearValidation(input) {
        this.clearFieldError(input);
    }

    isValidEmail(email) {
        return /^[^\s@]+@[^\s@]+\.[^\s@]+$/.test(email);
    }

    addInputAnimations(form) {
        const inputs = form.querySelectorAll('input, select, textarea');
        inputs.forEach(input => {
            input.addEventListener('focus', () => {
                input.style.transform = 'translateY(-2px)';
            });
            
            input.addEventListener('blur', () => {
                input.style.transform = '';
            });
        });
    }

    addSubmitHandling(form) {
        form.addEventListener('submit', (e) => {
            const isValid = this.validateForm(form);
            if (!isValid) {
                e.preventDefault();
                window.advancedSystem.notificationCenter.error('يرجى تصحيح الأخطاء في النموذج');
            }
        });
    }

    validateForm(form) {
        const inputs = form.querySelectorAll('input, select, textarea');
        let isValid = true;
        
        inputs.forEach(input => {
            if (!this.validateField(input)) {
                isValid = false;
            }
        });
        
        return isValid;
    }
}

// ===== ADVANCED LOADING MANAGER =====
class AdvancedLoadingManager {
    constructor() {
        this.overlays = new Map();
    }

    create(element) {
        const overlay = document.createElement('div');
        overlay.className = 'advanced-loading-overlay';
        overlay.innerHTML = `
            <div class="advanced-loading-spinner"></div>
            <div class="advanced-loading-text">جاري التحميل...</div>
        `;
        overlay.style.display = 'none';
        
        element.style.position = 'relative';
        element.appendChild(overlay);
        
        const manager = {
            show: () => {
                overlay.style.display = 'flex';
                overlay.style.opacity = '0';
                setTimeout(() => overlay.style.opacity = '1', 10);
            },
            hide: () => {
                overlay.style.opacity = '0';
                setTimeout(() => overlay.style.display = 'none', 300);
            },
            setText: (text) => {
                overlay.querySelector('.advanced-loading-text').textContent = text;
            },
            remove: () => {
                if (overlay.parentNode) {
                    overlay.parentNode.removeChild(overlay);
                }
            }
        };
        
        this.overlays.set(element, manager);
        return manager;
    }

    show(element, text = 'جاري التحميل...') {
        let manager = this.overlays.get(element);
        if (!manager) {
            manager = this.create(element);
        }
        manager.setText(text);
        manager.show();
    }

    hide(element) {
        const manager = this.overlays.get(element);
        if (manager) {
            manager.hide();
        }
    }

    showGlobal(text = 'جاري التحميل...') {
        if (!this.globalOverlay) {
            this.globalOverlay = document.createElement('div');
            this.globalOverlay.style.cssText = `
                position: fixed;
                top: 0;
                left: 0;
                right: 0;
                bottom: 0;
                background: rgba(255, 255, 255, 0.95);
                backdrop-filter: blur(4px);
                display: flex;
                flex-direction: column;
                align-items: center;
                justify-content: center;
                z-index: 10000;
                font-family: var(--font-primary);
            `;
            this.globalOverlay.innerHTML = `
                <div class="advanced-loading-spinner" style="margin-bottom: 20px;"></div>
                <div class="advanced-loading-text" style="font-size: 18px; color: #6b7280;">${text}</div>
            `;
            document.body.appendChild(this.globalOverlay);
        } else {
            this.globalOverlay.querySelector('.advanced-loading-text').textContent = text;
            this.globalOverlay.style.display = 'flex';
        }
    }

    hideGlobal() {
        if (this.globalOverlay) {
            this.globalOverlay.style.display = 'none';
        }
    }
}

// ===== UTILITY FUNCTIONS =====
class AdvancedUtilities {
    static debounce(func, wait) {
        let timeout;
        return function executedFunction(...args) {
            const later = () => {
                clearTimeout(timeout);
                func(...args);
            };
            clearTimeout(timeout);
            timeout = setTimeout(later, wait);
        };
    }

    static throttle(func, limit) {
        let inThrottle;
        return function() {
            const args = arguments;
            const context = this;
            if (!inThrottle) {
                func.apply(context, args);
                inThrottle = true;
                setTimeout(() => inThrottle = false, limit);
            }
        };
    }

    static animate(element, properties, duration = 300) {
        return new Promise(resolve => {
            const start = performance.now();
            const startProps = {};
            
            // حفظ القيم الابتدائية
            for (let prop in properties) {
                startProps[prop] = parseFloat(getComputedStyle(element)[prop]) || 0;
            }
            
            function tick(now) {
                const elapsed = now - start;
                const progress = Math.min(elapsed / duration, 1);
                const eased = 1 - Math.pow(1 - progress, 3); // ease-out
                
                for (let prop in properties) {
                    const start = startProps[prop];
                    const end = properties[prop];
                    const current = start + (end - start) * eased;
                    element.style[prop] = current + (prop.includes('opacity') ? '' : 'px');
                }
                
                if (progress < 1) {
                    requestAnimationFrame(tick);
                } else {
                    resolve();
                }
            }
            
            requestAnimationFrame(tick);
        });
    }

    static formatCurrency(amount, currency = 'EGP') {
        return new Intl.NumberFormat('ar-EG', {
            style: 'currency',
            currency: currency
        }).format(amount);
    }

    static formatDate(date, options = {}) {
        const defaultOptions = {
            year: 'numeric',
            month: 'long',
            day: 'numeric'
        };
        return new Intl.DateTimeFormat('ar-EG', {...defaultOptions, ...options}).format(date);
    }

    static copyToClipboard(text) {
        if (navigator.clipboard) {
            return navigator.clipboard.writeText(text);
        } else {
            // Fallback
            const textArea = document.createElement('textarea');
            textArea.value = text;
            document.body.appendChild(textArea);
            textArea.select();
            document.execCommand('copy');
            document.body.removeChild(textArea);
            return Promise.resolve();
        }
    }
}

// ===== INITIALIZATION =====
// تهيئة النظام المتقدم عند تحميل الصفحة
window['AdvancedSystemController'] = AdvancedSystemController;
window['AdvancedUtilities'] = AdvancedUtilities;

// إنشاء نسخة عامة من النظام
window['advancedSystem'] = new AdvancedSystemController();

// إضافة دوال مساعدة عامة
window['showNotification'] = (message, type = 'info') => {
    if (window['advancedSystem'].notificationCenter) {
        window['advancedSystem'].notificationCenter.show(message, type);
    }
};

window['showLoading'] = (text) => {
    if (window['advancedSystem'].loadingManager) {
        window['advancedSystem'].loadingManager.showGlobal(text);
    }
};

window.hideLoading = () => {
    if (window.advancedSystem.loadingManager) {
        window.advancedSystem.loadingManager.hideGlobal();
    }
};

// معالجة الأخطاء العامة
window.addEventListener('error', (event) => {
    console.error('خطأ في الصفحة:', event.error);
    if (window.advancedSystem.notificationCenter) {
        window.advancedSystem.notificationCenter.error('حدث خطأ غير متوقع');
    }
});

// معالجة الأخطاء في الشبكة
window.addEventListener('unhandledrejection', (event) => {
    console.error('خطأ في Promise:', event.reason);
    if (window.advancedSystem.notificationCenter) {
        window.advancedSystem.notificationCenter.error('خطأ في الاتصال');
    }
});

console.log('🚀 Advanced System JavaScript - تم التحميل بنجاح!');
