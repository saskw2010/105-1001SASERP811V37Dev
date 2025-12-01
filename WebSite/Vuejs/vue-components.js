/**
 * 🚀 Vue.js Components Framework
 * تحويل JavaScript إلى Vue.js مع النظام الهرمي
 * mainmaster.* hierarchical structure integration
 */

// Vue Components Definition
const VueComponents = {
    /**
     * 📱 Mobile Menu Component
     * مكون القائمة المحمولة
     */
    MobileMenuComponent: {
        name: 'MobileMenuComponent',
        template: `
            <div class="mobile-menu-wrapper">
                <button 
                    class="pagemenu-mobile-toggle"
                    :class="{ active: isOpen }"
                    @click="toggleMenu"
                    :aria-expanded="isOpen.toString()"
                    aria-label="تبديل قائمة التنقل"
                >
                    <i :class="toggleIcon"></i>
                    <span class="toggle-text">{{ toggleText }}</span>
                </button>
                
                <div 
                    class="mobile-menu-backdrop"
                    :class="{ active: isOpen }"
                    @click="closeMenu"
                ></div>
            </div>
        `,
        
        data() {
            return {
                isOpen: false
            }
        },
        
        computed: {
            toggleIcon() {
                return this.isOpen ? 'fas fa-times' : 'fas fa-bars';
            },
            
            toggleText() {
                return this.isOpen ? 'إغلاق' : 'القائمة';
            }
        },
        
        methods: {
            toggleMenu() {
                this.isOpen = !this.isOpen;
                this.updateMenuState();
                
                // Integrate with hierarchical system
                if (window.mainmaster && window.mainmaster.menubar) {
                    window.mainmaster.menubar.mobilefunction();
                }
            },
            
            closeMenu() {
                this.isOpen = false;
                this.updateMenuState();
            },
            
            openMenu() {
                this.isOpen = true;
                this.updateMenuState();
            },
            
            updateMenuState() {
                const pageMenuBars = document.querySelectorAll('.PageMenuBar.responsive-pagemenubar');
                
                pageMenuBars.forEach(menuBar => {
                    if (this.isOpen) {
                        menuBar.classList.add('show');
                        menuBar.style.visibility = 'visible';
                    } else {
                        menuBar.classList.remove('show');
                        setTimeout(() => {
                            menuBar.style.visibility = 'hidden';
                        }, 500);
                    }
                });
                
                // Handle body scroll
                document.body.style.overflow = this.isOpen ? 'hidden' : '';
                
                // Emit event for parent components
                this.$emit('menu-toggled', { isOpen: this.isOpen });
            }
        },
        
        mounted() {
            // Setup responsive behavior
            this.setupResponsiveHandlers();
            
            // Register in hierarchical system
            if (window.mainmaster && window.mainmaster.menubar) {
                window.mainmaster.menubar.vue = this;
            }
        },
        
        methods: {
            ...this.methods,
            
            setupResponsiveHandlers() {
                // Close menu on window resize
                window.addEventListener('resize', () => {
                    if (window.innerWidth > 768 && this.isOpen) {
                        this.closeMenu();
                    }
                });
                
                // Close menu on escape key
                document.addEventListener('keydown', (e) => {
                    if (e.key === 'Escape' && this.isOpen) {
                        this.closeMenu();
                    }
                });
                
                // Close menu when clicking outside
                document.addEventListener('click', (e) => {
                    const isToggle = e.target.closest('.pagemenu-mobile-toggle');
                    const isMenu = e.target.closest('.PageMenuBar.responsive-pagemenubar');
                    
                    if (this.isOpen && !isToggle && !isMenu) {
                        this.closeMenu();
                    }
                });
            }
        }
    },
    
    /**
     * 🎨 Theme Manager Component
     * مكون إدارة المظاهر
     */
    ThemeManagerComponent: {
        name: 'ThemeManagerComponent',
        template: `
            <div class="theme-manager-vue">
                <div class="theme-selector" v-if="showSelector">
                    <select v-model="currentTheme" @change="switchTheme" class="form-control">
                        <option value="">اختر المظهر</option>
                        <option v-for="theme in availableThemes" :key="theme.key" :value="theme.key">
                            {{ theme.name }}
                        </option>
                    </select>
                </div>
                
                <div class="theme-actions" v-if="showActions">
                    <button @click="createCustomTheme" class="btn btn-primary btn-sm">
                        <i class="fas fa-plus"></i> إنشاء مظهر
                    </button>
                    
                    <button @click="exportThemes" class="btn btn-secondary btn-sm">
                        <i class="fas fa-download"></i> تصدير
                    </button>
                    
                    <button @click="showStats" class="btn btn-info btn-sm">
                        <i class="fas fa-chart-bar"></i> الإحصائيات
                    </button>
                </div>
                
                <div class="theme-stats" v-if="statisticsVisible">
                    <div class="stats-card">
                        <h5>إحصائيات المظاهر</h5>
                        <div class="stats-grid">
                            <div class="stat-item">
                                <span class="stat-label">المظهر المفضل:</span>
                                <span class="stat-value">{{ stats.favoriteTheme || 'غير محدد' }}</span>
                            </div>
                            <div class="stat-item">
                                <span class="stat-label">عدد التبديلات:</span>
                                <span class="stat-value">{{ stats.totalSwitches }}</span>
                            </div>
                            <div class="stat-item">
                                <span class="stat-label">المظاهر المخصصة:</span>
                                <span class="stat-value">{{ stats.customThemeCount }}</span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        `,
        
        props: {
            showSelector: {
                type: Boolean,
                default: true
            },
            showActions: {
                type: Boolean,
                default: false
            }
        },
        
        data() {
            return {
                currentTheme: '',
                availableThemes: [
                    { key: 'light', name: 'فاتح' },
                    { key: 'dark', name: 'داكن' },
                    { key: 'ai', name: 'ذكي' },
                    { key: 'citrus', name: 'حمضي' },
                    { key: 'emerald', name: 'زمردي' },
                    { key: 'rose', name: 'وردي' }
                ],
                statisticsVisible: false,
                stats: {
                    favoriteTheme: null,
                    totalSwitches: 0,
                    customThemeCount: 0
                }
            }
        },
        
        mounted() {
            this.loadCurrentTheme();
            this.setupThemeManager();
            
            // Register in hierarchical system
            if (window.mainmaster && window.mainmaster.utils) {
                window.mainmaster.utils.themeComponent = this;
            }
        },
        
        methods: {
            loadCurrentTheme() {
                this.currentTheme = localStorage.getItem('current-theme') || 'light';
            },
            
            switchTheme() {
                if (!this.currentTheme) return;
                
                const previousTheme = localStorage.getItem('current-theme');
                
                // Apply theme
                document.documentElement.setAttribute('data-theme', this.currentTheme);
                localStorage.setItem('current-theme', this.currentTheme);
                
                // Dispatch theme change event
                const event = new CustomEvent('themeChanged', {
                    detail: {
                        theme: this.currentTheme,
                        previousTheme: previousTheme
                    }
                });
                document.dispatchEvent(event);
                
                // Integrate with hierarchical system
                if (window.mainmaster && window.mainmaster.menubar) {
                    window.mainmaster.menubar.switchTheme(this.currentTheme);
                }
                
                // Show notification
                this.showNotification(`تم تغيير المظهر إلى: ${this.getThemeName(this.currentTheme)}`, 'success');
                
                this.$emit('theme-changed', { theme: this.currentTheme, previousTheme });
            },
            
            getThemeName(key) {
                const theme = this.availableThemes.find(t => t.key === key);
                return theme ? theme.name : key;
            },
            
            createCustomTheme() {
                // Implementation for custom theme creation
                this.showNotification('سيتم إضافة هذه الميزة قريباً', 'info');
            },
            
            exportThemes() {
                if (window.themeManager) {
                    const data = window.themeManager.exportAllThemes();
                    this.downloadData(data, 'themes-export.json');
                    this.showNotification('تم تصدير المظاهر بنجاح', 'success');
                }
            },
            
            showStats() {
                this.statisticsVisible = !this.statisticsVisible;
                
                if (this.statisticsVisible && window.themeManager) {
                    this.stats = window.themeManager.getStatistics();
                }
            },
            
            setupThemeManager() {
                // Initialize theme manager if available
                if (window.themeManager) {
                    this.stats = window.themeManager.getStatistics();
                    
                    // Add custom themes to available themes
                    if (window.themeManager.customThemes) {
                        window.themeManager.customThemes.forEach((theme, key) => {
                            this.availableThemes.push({
                                key: key,
                                name: theme.name,
                                isCustom: true
                            });
                        });
                    }
                }
            },
            
            downloadData(data, filename) {
                const blob = new Blob([JSON.stringify(data, null, 2)], {
                    type: 'application/json'
                });
                const url = URL.createObjectURL(blob);
                const a = document.createElement('a');
                a.href = url;
                a.download = filename;
                a.click();
                URL.revokeObjectURL(url);
            },
            
            showNotification(message, type = 'info') {
                // Use main master notification system
                if (window.mainmaster && window.mainmaster.utils) {
                    window.mainmaster.utils.showNotification(message, type);
                } else {
                    console.log(`${type.toUpperCase()}: ${message}`);
                }
            }
        }
    },
    
    /**
     * 🏠 Home Dashboard Component
     * مكون لوحة التحكم الرئيسية
     */
    HomeDashboardComponent: {
        name: 'HomeDashboardComponent',
        template: `
            <div class="home-dashboard-vue">
                <div class="home-widgets-container">
                    <div 
                        v-for="widget in widgets" 
                        :key="widget.id"
                        :class="['home-widget', 'home-card', widget.cssClass]"
                        @click="handleWidgetClick(widget)"
                    >
                        <div class="widget-header">
                            <i :class="widget.icon"></i>
                            <h3>{{ widget.title }}</h3>
                        </div>
                        
                        <div class="widget-content">
                            <div class="widget-value">{{ widget.value }}</div>
                            <div class="widget-description">{{ widget.description }}</div>
                        </div>
                        
                        <div class="widget-actions" v-if="widget.actions">
                            <button 
                                v-for="action in widget.actions"
                                :key="action.id"
                                @click.stop="handleAction(action)"
                                class="btn btn-sm"
                                :class="action.class"
                            >
                                <i :class="action.icon"></i>
                                {{ action.label }}
                            </button>
                        </div>
                    </div>
                </div>
                
                <div class="home-quick-actions">
                    <h4>الإجراءات السريعة</h4>
                    <div class="quick-actions-grid">
                        <button 
                            v-for="action in quickActions"
                            :key="action.id"
                            @click="handleQuickAction(action)"
                            class="quick-action-btn"
                            :class="action.class"
                        >
                            <i :class="action.icon"></i>
                            <span>{{ action.label }}</span>
                        </button>
                    </div>
                </div>
            </div>
        `,
        
        data() {
            return {
                widgets: [
                    {
                        id: 'financial',
                        title: 'المالية',
                        icon: 'fas fa-chart-line',
                        value: '₪ 150,000',
                        description: 'إجمالي الإيرادات',
                        cssClass: 'home-financial-widget',
                        actions: [
                            { id: 'view', label: 'عرض', icon: 'fas fa-eye', class: 'btn-primary' }
                        ]
                    },
                    {
                        id: 'hr',
                        title: 'الموارد البشرية',
                        icon: 'fas fa-users',
                        value: '85',
                        description: 'إجمالي الموظفين',
                        cssClass: 'home-hr-widget',
                        actions: [
                            { id: 'view', label: 'عرض', icon: 'fas fa-eye', class: 'btn-success' }
                        ]
                    },
                    {
                        id: 'operations',
                        title: 'العمليات',
                        icon: 'fas fa-cogs',
                        value: '156',
                        description: 'الطلبات النشطة',
                        cssClass: 'home-operations-widget',
                        actions: [
                            { id: 'view', label: 'عرض', icon: 'fas fa-eye', class: 'btn-warning' }
                        ]
                    },
                    {
                        id: 'reports',
                        title: 'التقارير',
                        icon: 'fas fa-file-alt',
                        value: '45',
                        description: 'التقارير المتاحة',
                        cssClass: 'home-reports-widget',
                        actions: [
                            { id: 'view', label: 'عرض', icon: 'fas fa-eye', class: 'btn-info' }
                        ]
                    }
                ],
                
                quickActions: [
                    {
                        id: 'create-invoice',
                        label: 'إنشاء فاتورة',
                        icon: 'fas fa-plus-circle',
                        class: 'btn-primary'
                    },
                    {
                        id: 'add-employee',
                        label: 'إضافة موظف',
                        icon: 'fas fa-user-plus',
                        class: 'btn-success'
                    },
                    {
                        id: 'new-order',
                        label: 'طلب جديد',
                        icon: 'fas fa-shopping-cart',
                        class: 'btn-warning'
                    },
                    {
                        id: 'generate-report',
                        label: 'إنشاء تقرير',
                        icon: 'fas fa-chart-bar',
                        class: 'btn-info'
                    }
                ]
            }
        },
        
        mounted() {
            this.initializeHomeWidgets();
            
            // Register in hierarchical system
            if (window.mainmaster && window.mainmaster.home) {
                window.mainmaster.home.vueComponent = this;
            }
        },
        
        methods: {
            initializeHomeWidgets() {
                // Animate widgets on load
                this.$nextTick(() => {
                    const widgets = this.$el.querySelectorAll('.home-widget');
                    widgets.forEach((widget, index) => {
                        widget.style.opacity = '0';
                        widget.style.transform = 'translateY(20px)';
                        
                        setTimeout(() => {
                            widget.style.transition = 'all 0.6s ease';
                            widget.style.opacity = '1';
                            widget.style.transform = 'translateY(0)';
                        }, index * 150);
                    });
                });
                
                // Link to hierarchical system
                if (window.mainmaster && window.mainmaster.home) {
                    window.mainmaster.home.loadContent();
                }
            },
            
            handleWidgetClick(widget) {
                console.log(`Widget clicked: ${widget.id}`);
                
                // Route to appropriate dashboard
                switch (widget.id) {
                    case 'financial':
                        if (window.mainmaster && window.mainmaster.financial) {
                            window.mainmaster.financial.refreshDashboard();
                        }
                        break;
                    case 'hr':
                        if (window.mainmaster && window.mainmaster.hr) {
                            window.mainmaster.hr.viewAllDepartments();
                        }
                        break;
                    case 'operations':
                        if (window.mainmaster && window.mainmaster.operations) {
                            window.mainmaster.operations.manageInventory();
                        }
                        break;
                    case 'reports':
                        if (window.mainmaster && window.mainmaster.reports) {
                            window.mainmaster.reports.reportSettings();
                        }
                        break;
                }
                
                this.$emit('widget-clicked', widget);
            },
            
            handleAction(action) {
                console.log(`Action clicked: ${action.id}`);
                this.$emit('action-clicked', action);
            },
            
            handleQuickAction(action) {
                console.log(`Quick action: ${action.id}`);
                
                // Route to hierarchical functions
                switch (action.id) {
                    case 'create-invoice':
                        if (window.mainmaster && window.mainmaster.financial) {
                            window.mainmaster.financial.createInvoice();
                        }
                        break;
                    case 'add-employee':
                        if (window.mainmaster && window.mainmaster.hr) {
                            window.mainmaster.hr.addEmployee();
                        }
                        break;
                    case 'new-order':
                        if (window.mainmaster && window.mainmaster.operations) {
                            window.mainmaster.operations.createOrder();
                        }
                        break;
                    case 'generate-report':
                        if (window.mainmaster && window.mainmaster.reports) {
                            window.mainmaster.reports.createCustomReport();
                        }
                        break;
                }
                
                this.$emit('quick-action-clicked', action);
            },
            
            refreshWidgets() {
                // Animate refresh
                const widgets = this.$el.querySelectorAll('.home-widget');
                widgets.forEach(widget => {
                    widget.style.transform = 'scale(0.95)';
                    setTimeout(() => {
                        widget.style.transition = 'transform 0.3s ease';
                        widget.style.transform = 'scale(1)';
                    }, 100);
                });
                
                // Link to hierarchical system
                if (window.mainmaster && window.mainmaster.home) {
                    window.mainmaster.home.refreshWidgets();
                }
                
                this.$emit('widgets-refreshed');
            },
            
            toggleSidebar() {
                // Implementation for sidebar toggle
                const sidebar = document.querySelector('.home-sidebar');
                if (sidebar) {
                    sidebar.classList.toggle('collapsed');
                }
                
                this.$emit('sidebar-toggled');
            }
        }
    },
    
    /**
     * 🔧 Admin Panel Component
     * مكون لوحة الإدارة
     */
    AdminPanelComponent: {
        name: 'AdminPanelComponent',
        template: `
            <div class="admin-panel-vue">
                <div class="admin-sidebar" :class="{ collapsed: sidebarCollapsed }">
                    <div class="sidebar-header">
                        <h3 v-if="!sidebarCollapsed">لوحة الإدارة</h3>
                        <button @click="toggleSidebar" class="sidebar-toggle">
                            <i :class="sidebarCollapsed ? 'fas fa-expand' : 'fas fa-compress'"></i>
                        </button>
                    </div>
                    
                    <nav class="sidebar-nav">
                        <a 
                            v-for="item in navigationItems"
                            :key="item.id"
                            :href="item.url"
                            :class="['nav-item', { active: currentPage === item.id }]"
                            @click="navigate(item)"
                        >
                            <i :class="item.icon"></i>
                            <span v-if="!sidebarCollapsed">{{ item.label }}</span>
                        </a>
                    </nav>
                </div>
                
                <div class="admin-content">
                    <div class="content-header">
                        <h1>{{ currentPageTitle }}</h1>
                        <div class="page-actions">
                            <button @click="refreshPage" class="btn btn-outline-primary">
                                <i class="fas fa-sync-alt"></i>
                                تحديث
                            </button>
                        </div>
                    </div>
                    
                    <div class="content-body">
                        <slot></slot>
                    </div>
                </div>
            </div>
        `,
        
        data() {
            return {
                sidebarCollapsed: false,
                currentPage: 'dashboard',
                navigationItems: [
                    { id: 'dashboard', label: 'لوحة التحكم', icon: 'fas fa-tachometer-alt', url: '/admin' },
                    { id: 'users', label: 'المستخدمين', icon: 'fas fa-users', url: '/admin/users' },
                    { id: 'settings', label: 'الإعدادات', icon: 'fas fa-cog', url: '/admin/settings' },
                    { id: 'reports', label: 'التقارير', icon: 'fas fa-chart-line', url: '/admin/reports' },
                    { id: 'logs', label: 'السجلات', icon: 'fas fa-list-alt', url: '/admin/logs' }
                ]
            }
        },
        
        computed: {
            currentPageTitle() {
                const page = this.navigationItems.find(item => item.id === this.currentPage);
                return page ? page.label : 'لوحة الإدارة';
            }
        },
        
        mounted() {
            // Register in hierarchical system
            if (window.mainmaster) {
                window.mainmaster.admin = {
                    component: this,
                    navigate: this.navigate,
                    toggleSidebar: this.toggleSidebar,
                    refreshPage: this.refreshPage
                };
            }
        },
        
        methods: {
            toggleSidebar() {
                this.sidebarCollapsed = !this.sidebarCollapsed;
                this.$emit('sidebar-toggled', { collapsed: this.sidebarCollapsed });
            },
            
            navigate(item) {
                this.currentPage = item.id;
                this.$emit('navigate', item);
            },
            
            refreshPage() {
                this.$emit('refresh');
                
                // Show notification
                if (window.mainmaster && window.mainmaster.utils) {
                    window.mainmaster.utils.showNotification('تم تحديث الصفحة', 'success');
                }
            }
        }
    }
};

// Vue Application Factory
const VueAppFactory = {
    /**
     * Create Vue Application with Components
     */
    createApp(elementId, components = []) {
        if (!window.Vue) {
            console.error('Vue.js is not loaded');
            return null;
        }
        
        const { createApp } = Vue;
        
        const app = createApp({
            name: 'MainMasterVueApp',
            
            data() {
                return {
                    appVersion: '1.0.0',
                    isInitialized: false
                }
            },
            
            mounted() {
                this.isInitialized = true;
                console.log('🚀 Vue App Mounted Successfully');
                
                // Integrate with main master system
                this.integrateWithMainMaster();
            },
            
            methods: {
                integrateWithMainMaster() {
                    if (window.mainmaster) {
                        window.mainmaster.vue = {
                            app: this,
                            version: this.appVersion,
                            isInitialized: this.isInitialized
                        };
                    }
                }
            }
        });
        
        // Register components
        components.forEach(componentName => {
            if (VueComponents[componentName]) {
                app.component(componentName.replace('Component', ''), VueComponents[componentName]);
            }
        });
        
        // Register all components globally
        Object.keys(VueComponents).forEach(componentName => {
            const componentKey = componentName.replace('Component', '');
            app.component(componentKey, VueComponents[componentName]);
        });
        
        // Mount app
        const element = document.getElementById(elementId);
        if (element) {
            return app.mount(`#${elementId}`);
        } else {
            console.warn(`Element with id '${elementId}' not found`);
            return null;
        }
    },
    
    /**
     * Create standalone component
     */
    createComponent(componentName, elementId, props = {}) {
        if (!VueComponents[componentName]) {
            console.error(`Component '${componentName}' not found`);
            return null;
        }
        
        const { createApp } = Vue;
        const app = createApp(VueComponents[componentName], props);
        
        const element = document.getElementById(elementId);
        if (element) {
            return app.mount(`#${elementId}`);
        } else {
            console.warn(`Element with id '${elementId}' not found`);
            return null;
        }
    }
};

// Auto-initialize when DOM is ready
document.addEventListener('DOMContentLoaded', function() {
    console.log('🔧 Vue Components Framework Loaded');
    
    // Auto-mount components if elements exist
    const autoMountComponents = [
        { component: 'MobileMenuComponent', element: 'mobile-menu-vue' },
        { component: 'ThemeManagerComponent', element: 'theme-manager-vue' },
        { component: 'HomeDashboardComponent', element: 'home-dashboard-vue' },
        { component: 'AdminPanelComponent', element: 'admin-panel-vue' }
    ];
    
    autoMountComponents.forEach(({ component, element }) => {
        if (document.getElementById(element)) {
            VueAppFactory.createComponent(component, element);
            console.log(`✅ Auto-mounted ${component} to #${element}`);
        }
    });
    
    // Expose factory globally
    window.VueAppFactory = VueAppFactory;
    window.VueComponents = VueComponents;
    
    // Integration with main master
    if (window.mainmaster) {
        window.mainmaster.vue = {
            factory: VueAppFactory,
            components: VueComponents
        };
    }
});

// Export for module systems
if (typeof module !== 'undefined' && module.exports) {
    module.exports = { VueComponents, VueAppFactory };
}

/**
 * 🎯 Usage Examples:
 * 
 * // Create full app with components
 * VueAppFactory.createApp('app', ['MobileMenuComponent', 'ThemeManagerComponent']);
 * 
 * // Create standalone component
 * VueAppFactory.createComponent('HomeDashboardComponent', 'dashboard-container');
 * 
 * // Access through hierarchical system
 * mainmaster.vue.factory.createComponent('ThemeManagerComponent', 'theme-container');
 * 
 * // Integration with home classes
 * <div class="home-dashboard-container" id="home-dashboard-vue"></div>
 * 
 */

console.log(`
🚀 Vue Components Framework Ready!
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
✅ Mobile Menu Component (PageMenuBar replacement)
✅ Theme Manager Component (Advanced theme system)
✅ Home Dashboard Component (home- classes integration)
✅ Admin Panel Component (Management interface)

📱 Auto-mounting Components:
   #mobile-menu-vue → MobileMenuComponent
   #theme-manager-vue → ThemeManagerComponent  
   #home-dashboard-vue → HomeDashboardComponent
   #admin-panel-vue → AdminPanelComponent

🔧 Integration:
   mainmaster.vue.factory → VueAppFactory
   mainmaster.vue.components → VueComponents
   
🏠 Home Classes Integration:
   .home-dashboard-container
   .home-widget
   .home-card
   .home-section
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
`);
