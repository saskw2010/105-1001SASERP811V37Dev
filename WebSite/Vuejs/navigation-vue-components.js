/**
 * Navigation Vue Components for Universal Hamburger Menu
 * يدمج Vue.js مع النظام الهرمي mainmaster.navigation.*
 * يقرأ البيانات من SiteMap ويعرضها في قائمة برجر موحدة
 */

// تمديد نظام mainmaster لإضافة وحدة navigation
if (typeof mainmaster === 'undefined') {
    window.mainmaster = {};
}

// وحدة Navigation داخل mainmaster
mainmaster.navigation = {
    // حالة القائمة
    state: {
        isMenuOpen: false,
        isProfileOpen: false,
        searchTerm: '',
        currentPath: '',
        menuItems: [],
        filteredItems: [],
        userInfo: {},
        currentPage: {}
    },

    // تهيئة النظام
    init() {
        try {
            console.log('🚀 تهيئة نظام Navigation...');
            
            this.loadDataFromServer();
            this.initializeVueApp();
            this.setupEventListeners();
            this.applyMobileFirstDesign();
            
            console.log('✅ تم تهيئة نظام Navigation بنجاح');
        } catch (error) {
            console.error('❌ خطأ في تهيئة Navigation:', error);
            this.initializeFallback();
        }
    },

    // تحميل البيانات من الخادم
    loadDataFromServer() {
        try {
            // قراءة بيانات القائمة من Hidden Field
            const menuDataElement = document.getElementById('ctl00_hdnMenuData') || 
                                   document.getElementById('hdnMenuData') ||
                                   document.querySelector('[id$="hdnMenuData"]');
            
            if (menuDataElement && menuDataElement.value) {
                this.state.menuItems = JSON.parse(menuDataElement.value);
                this.state.filteredItems = [...this.state.menuItems];
                console.log('📋 تم تحميل', this.state.menuItems.length, 'عنصر من القائمة');
            }

            // قراءة معلومات المستخدم
            const userInfoElement = document.getElementById('ctl00_hdnUserInfo') || 
                                   document.getElementById('hdnUserInfo') ||
                                   document.querySelector('[id$="hdnUserInfo"]');
            
            if (userInfoElement && userInfoElement.value) {
                this.state.userInfo = JSON.parse(userInfoElement.value);
                console.log('👤 معلومات المستخدم:', this.state.userInfo.username);
            }

            // قراءة معلومات الصفحة الحالية
            const currentPageElement = document.getElementById('ctl00_hdnCurrentPage') || 
                                      document.getElementById('hdnCurrentPage') ||
                                      document.querySelector('[id$="hdnCurrentPage"]');
            
            if (currentPageElement && currentPageElement.value) {
                this.state.currentPage = JSON.parse(currentPageElement.value);
                this.state.currentPath = this.state.currentPage.path;
                console.log('📄 الصفحة الحالية:', this.state.currentPage.title);
            }

        } catch (error) {
            console.error('❌ خطأ في تحميل البيانات:', error);
            this.loadFallbackData();
        }
    },

    // تهيئة تطبيق Vue.js
    initializeVueApp() {
        try {
            // التحقق من وجود Vue.js
            if (typeof Vue === 'undefined') {
                console.warn('⚠️ Vue.js غير متوفر، سيتم استخدام JavaScript عادي');
                this.initializeVanillaJS();
                return;
            }

            // إنشاء Vue app للقائمة العامة
            this.vueApp = Vue.createApp({
                data() {
                    return {
                        isMenuOpen: mainmaster.navigation.state.isMenuOpen,
                        showProfileSection: false,
                        searchTerm: '',
                        appTitle: 'SASERP V37',
                        currentUser: mainmaster.navigation.state.userInfo.displayName || 'مستخدم',
                        userRole: mainmaster.navigation.state.userInfo.role || 'مستخدم',
                        currentPageTitle: mainmaster.navigation.state.currentPage.title || 'النظام',
                        filteredMenuItems: mainmaster.navigation.state.filteredItems
                    };
                },
                mounted() {
                    console.log('🎯 تم تحميل Vue App للقائمة');
                    this.updateMenuItems();
                },
                methods: {
                    updateMenuItems() {
                        this.filteredMenuItems = mainmaster.navigation.state.filteredItems;
                    },
                    toggleProfileSection() {
                        this.showProfileSection = !this.showProfileSection;
                    }
                }
            });

            // تسجيل مكون nav-menu-item
            this.vueApp.component('nav-menu-item', {
                template: '#nav-menu-item-template',
                props: ['item', 'level'],
                emits: ['navigate'],
                data() {
                    return {
                        isExpanded: false
                    };
                },
                methods: {
                    toggleItem() {
                        if (this.item.hasChildren) {
                            this.isExpanded = !this.isExpanded;
                        } else {
                            this.navigateToPage();
                        }
                    },
                    navigateToPage() {
                        if (!this.item.hasChildren && this.item.url && this.item.url !== '#') {
                            this.$emit('navigate', this.item);
                        }
                    }
                }
            });

            // ربط التطبيق بالعنصر
            const menuElement = document.getElementById('universalHamburgerMenu');
            if (menuElement) {
                this.vueApp.mount('#universalHamburgerMenu');
                console.log('✅ تم ربط Vue App بنجاح');
            }

        } catch (error) {
            console.error('❌ خطأ في تهيئة Vue App:', error);
            this.initializeVanillaJS();
        }
    },

    // تهيئة JavaScript عادي كبديل
    initializeVanillaJS() {
        console.log('🔄 تهيئة النظام بـ JavaScript عادي...');
        
        // إضافة event listeners أساسية
        const toggleButton = document.getElementById('hamburgerToggle');
        if (toggleButton) {
            toggleButton.addEventListener('click', () => this.toggleMenu());
        }

        const overlay = document.getElementById('navigationOverlay');
        if (overlay) {
            overlay.addEventListener('click', (e) => {
                if (e.target === overlay) {
                    this.closeMenu();
                }
            });
        }

        this.renderMenuItems();
        console.log('✅ تم تهيئة النظام العادي');
    },

    // عرض عناصر القائمة بـ JavaScript عادي
    renderMenuItems() {
        const container = document.querySelector('.navigation-tree');
        if (!container) return;

        container.innerHTML = '';
        
        this.state.filteredItems.forEach(item => {
            const menuItemElement = this.createMenuItemElement(item, 0);
            container.appendChild(menuItemElement);
        });
    },

    // إنشاء عنصر قائمة
    createMenuItemElement(item, level) {
        const div = document.createElement('div');
        div.className = `nav-menu-item level-${level}`;
        if (item.hasChildren) div.classList.add('has-children');

        const header = document.createElement('div');
        header.className = 'nav-item-header';
        header.innerHTML = `
            <div class="nav-item-content">
                <i class="${item.icon} nav-item-icon"></i>
                <span class="nav-item-title">${item.title}</span>
                ${item.childrenCount ? `<span class="nav-item-count">${item.childrenCount}</span>` : ''}
            </div>
            ${item.hasChildren ? '<i class="fas fa-chevron-down nav-item-toggle"></i>' : ''}
        `;

        header.addEventListener('click', () => {
            if (item.hasChildren) {
                this.toggleMenuItem(div);
            } else if (item.url && item.url !== '#') {
                this.navigateToPage(item);
            }
        });

        div.appendChild(header);

        if (item.hasChildren && item.children) {
            const childrenContainer = document.createElement('div');
            childrenContainer.className = 'nav-children';
            childrenContainer.style.display = 'none';

            item.children.forEach(child => {
                const childElement = this.createMenuItemElement(child, level + 1);
                childrenContainer.appendChild(childElement);
            });

            div.appendChild(childrenContainer);
        }

        return div;
    },

    // توسيع/طي عنصر القائمة
    toggleMenuItem(element) {
        const children = element.querySelector('.nav-children');
        const toggle = element.querySelector('.nav-item-toggle');
        
        if (children) {
            const isVisible = children.style.display !== 'none';
            children.style.display = isVisible ? 'none' : 'block';
            
            if (toggle) {
                toggle.className = isVisible ? 'fas fa-chevron-down nav-item-toggle' : 'fas fa-chevron-up nav-item-toggle';
            }
        }
    },

    // إعداد Event Listeners
    setupEventListeners() {
        // إخفاء القوائم الأفقية الموجودة
        this.hideHorizontalMenus();

        // مراقبة تغيير حجم الشاشة
        window.addEventListener('resize', () => {
            this.handleScreenResize();
        });

        // مراقبة الضغط على Escape
        document.addEventListener('keydown', (e) => {
            if (e.key === 'Escape' && this.state.isMenuOpen) {
                this.closeMenu();
            }
        });

        // منع scroll في الخلفية عند فتح القائمة
        document.addEventListener('touchmove', (e) => {
            if (this.state.isMenuOpen) {
                e.preventDefault();
            }
        }, { passive: false });
    },

    // تطبيق التصميم Mobile-First
    applyMobileFirstDesign() {
        // إخفاء القوائم الأفقية نهائياً
        const horizontalMenus = [
            '.nav-horizontal',
            '.navbar-nav',
            '.main-navigation',
            '.top-menu',
            '.header-menu',
            '#MainMenu',
            '.MenuBar'
        ];

        horizontalMenus.forEach(selector => {
            const elements = document.querySelectorAll(selector);
            elements.forEach(el => {
                el.style.display = 'none';
                el.style.visibility = 'hidden';
            });
        });

        // إضافة CSS class للجسم
        document.body.classList.add('mobile-first-navigation');
        
        console.log('📱 تم تطبيق التصميم Mobile-First');
    },

    // إخفاء القوائم الأفقية
    hideHorizontalMenus() {
        // قائمة المحددات للقوائم التي يجب إخفاؤها
        const menuSelectors = [
            '.asp-menu',
            '.menu-horizontal',
            '.nav-tabs',
            '.navbar',
            '.main-menu',
            '[id*="Menu"]',
            '[class*="menu"]',
            '[class*="Menu"]'
        ];

        menuSelectors.forEach(selector => {
            try {
                const elements = document.querySelectorAll(selector);
                elements.forEach(element => {
                    // التحقق من أن العنصر ليس القائمة الجديدة
                    if (!element.closest('#universalHamburgerMenu')) {
                        element.style.display = 'none';
                        element.setAttribute('data-hidden-by-universal-menu', 'true');
                    }
                });
            } catch (error) {
                console.warn('تحذير: لا يمكن إخفاء القائمة:', selector);
            }
        });
    },

    // الدوال الرئيسية للقائمة
    toggleMenu() {
        this.state.isMenuOpen = !this.state.isMenuOpen;
        
        const overlay = document.getElementById('navigationOverlay');
        const hamburger = document.getElementById('hamburgerToggle');
        
        if (overlay) {
            overlay.classList.toggle('active', this.state.isMenuOpen);
        }
        
        if (hamburger) {
            hamburger.classList.toggle('active', this.state.isMenuOpen);
        }

        // منع/السماح بالـ scroll
        document.body.style.overflow = this.state.isMenuOpen ? 'hidden' : '';
        
        console.log(this.state.isMenuOpen ? '🍔 فتح القائمة' : '🚪 إغلاق القائمة');
    },

    closeMenu() {
        this.state.isMenuOpen = false;
        
        const overlay = document.getElementById('navigationOverlay');
        const hamburger = document.getElementById('hamburgerToggle');
        
        if (overlay) {
            overlay.classList.remove('active');
        }
        
        if (hamburger) {
            hamburger.classList.remove('active');
        }

        document.body.style.overflow = '';
    },

    toggleProfile() {
        this.state.isProfileOpen = !this.state.isProfileOpen;
        
        if (this.vueApp && this.vueApp._instance) {
            this.vueApp._instance.ctx.showProfileSection = this.state.isProfileOpen;
        }
    },

    // تصفية القائمة
    filterMenu() {
        const searchTerm = this.state.searchTerm.toLowerCase();
        
        if (!searchTerm) {
            this.state.filteredItems = [...this.state.menuItems];
        } else {
            this.state.filteredItems = this.filterItemsRecursively(this.state.menuItems, searchTerm);
        }

        // تحديث Vue app إذا كان متوفراً
        if (this.vueApp && this.vueApp._instance) {
            this.vueApp._instance.ctx.filteredMenuItems = this.state.filteredItems;
        } else {
            // إعادة عرض العناصر بـ JavaScript عادي
            this.renderMenuItems();
        }

        console.log('🔍 تصفية القائمة:', this.state.filteredItems.length, 'نتيجة');
    },

    filterItemsRecursively(items, searchTerm) {
        const filtered = [];
        
        items.forEach(item => {
            const matchesSearch = item.title.toLowerCase().includes(searchTerm) ||
                                 (item.description && item.description.toLowerCase().includes(searchTerm));
            
            let filteredChildren = [];
            if (item.children && item.children.length > 0) {
                filteredChildren = this.filterItemsRecursively(item.children, searchTerm);
            }
            
            if (matchesSearch || filteredChildren.length > 0) {
                const filteredItem = { ...item };
                if (filteredChildren.length > 0) {
                    filteredItem.children = filteredChildren;
                    filteredItem.childrenCount = filteredChildren.length;
                }
                filtered.push(filteredItem);
            }
        });
        
        return filtered;
    },

    // دوال التنقل
    navigateToPage(item) {
        if (!item.url || item.url === '#') {
            console.warn('⚠️ رابط غير صحيح:', item.title);
            return;
        }

        console.log('🔗 التنقل إلى:', item.title, item.url);
        
        // إغلاق القائمة أولاً
        this.closeMenu();
        
        // انتظار قصير ثم التنقل
        setTimeout(() => {
            window.location.href = item.url;
        }, 300);
    },

    goToHome() {
        this.navigateToPage({ title: 'الرئيسية', url: '~/Default.aspx' });
    },

    goToDashboard() {
        this.navigateToPage({ title: 'لوحة التحكم', url: '~/Pages/Dashboard.aspx' });
    },

    goToReports() {
        this.navigateToPage({ title: 'التقارير', url: '~/Pages/Reports.aspx' });
    },

    goToProfile() {
        this.navigateToPage({ title: 'الملف الشخصي', url: '~/Pages/Profile.aspx' });
    },

    // دوال روابط سريعة إضافية
    goToLinksGuide() {
        this.navigateToPage({ title: 'دليل الروابط', url: '~/TestPages/SystemLinksGuide.aspx' });
    },

    goToFinancialAccounts() {
        this.navigateToPage({ title: 'خطة الحسابات', url: '~/Pages/AccountChart.aspx' });
    },

    goToHREmployees() {
        this.navigateToPage({ title: 'الموظفون', url: '~/Pages/Employees.aspx' });
    },

    goToStockItems() {
        this.navigateToPage({ title: 'الأصناف', url: '~/Pages/StockList.aspx' });
    },

    goToPOS() {
        this.navigateToPage({ title: 'نقطة البيع', url: '~/Pages/POS.aspx' });
    },

    logout() {
        if (confirm('هل تريد تسجيل الخروج؟')) {
            console.log('🚪 تسجيل خروج المستخدم');
            window.location.href = '~/Login.aspx';
        }
    },

    toggleTheme() {
        const currentTheme = document.body.getAttribute('data-theme') || 'light';
        const newTheme = currentTheme === 'light' ? 'dark' : 'light';
        
        document.body.setAttribute('data-theme', newTheme);
        localStorage.setItem('app-theme', newTheme);
        
        console.log('🎨 تغيير الثيم إلى:', newTheme);
    },

    // معالجة تغيير حجم الشاشة
    handleScreenResize() {
        // إغلاق القائمة إذا تم تكبير الشاشة
        if (window.innerWidth > 768 && this.state.isMenuOpen) {
            this.closeMenu();
        }
    },

    // تحميل بيانات احتياطية
    loadFallbackData() {
        this.state.menuItems = [
            {
                id: 'home',
                title: 'الرئيسية',
                url: '~/Default.aspx',
                icon: 'fas fa-home',
                hasChildren: false,
                isVisible: true
            },
            {
                id: 'dashboard',
                title: 'لوحة التحكم',
                url: '~/Pages/Dashboard.aspx',
                icon: 'fas fa-chart-pie',
                hasChildren: false,
                isVisible: true
            }
        ];
        
        this.state.filteredItems = [...this.state.menuItems];
        this.state.userInfo = { username: 'مستخدم', isAuthenticated: false };
        this.state.currentPage = { title: 'النظام' };
    },

    // تهيئة احتياطية
    initializeFallback() {
        console.log('🔄 تهيئة النظام الاحتياطي...');
        this.loadFallbackData();
        this.initializeVanillaJS();
        this.applyMobileFirstDesign();
    }
};

// تهيئة النظام عند تحميل الصفحة
document.addEventListener('DOMContentLoaded', function() {
    // انتظار قصير للتأكد من تحميل Vue.js
    setTimeout(() => {
        mainmaster.navigation.init();
    }, 100);
});

// إضافة CSS عبر JavaScript إذا لم يتم تحميله
function ensureNavigationCSS() {
    if (!document.querySelector('link[href*="universal-hamburger-menu.css"]')) {
        const link = document.createElement('link');
        link.rel = 'stylesheet';
        link.type = 'text/css';
        link.href = './css/universal-hamburger-menu.css';
        document.head.appendChild(link);
    }
}

// استدعاء الدالة
ensureNavigationCSS();

// تصدير للاستخدام العام
if (typeof module !== 'undefined' && module.exports) {
    module.exports = mainmaster.navigation;
}

console.log('🍔 تم تحميل Navigation Vue Components');
