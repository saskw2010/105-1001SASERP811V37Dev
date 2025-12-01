/**
 * Menu Manager - إدارة ومراقبة القوائم المتعددة
 * يتتبع جميع القوائم المتولدة في النظام ويوفر تحكم موحد
 */

class MenuManager {
    constructor() {
        this.menus = new Map();
        this.initializeCounter = 0;
        this.debugMode = false;
        this.init();
    }

    init() {
        // انتظار تحميل DOM
        if (document.readyState === 'loading') {
            document.addEventListener('DOMContentLoaded', () => this.scanForMenus());
        } else {
            this.scanForMenus();
        }

        // مراقبة التغييرات في DOM
        this.observeMenuChanges();
    }

    scanForMenus() {
        // البحث عن القوائم المختلفة
        this.scanPageMenuBar();
        this.scanAdvancedMenus();
        this.scanRadMenus();
        this.scanCustomMenus();
        
        this.updateCounter();
        
        if (this.debugMode) {
            console.log('📊 Menu scan completed:', this.getMenuSummary());
        }
    }

    scanPageMenuBar() {
        const pageMenuBar = document.getElementById('ctl00_PageMenuBar') || 
                           document.querySelector('.PageMenuBar');
        
        if (pageMenuBar) {
            this.menus.set('PageMenuBar', {
                type: 'ASP.NET PageMenuBar',
                element: pageMenuBar,
                responsive: pageMenuBar.classList.contains('mobile-active'),
                itemCount: pageMenuBar.querySelectorAll('.Menu .Item').length,
                status: 'active'
            });
        }
    }

    scanAdvancedMenus() {
        const advancedMenus = document.querySelectorAll('.advanced-nav-wrapper');
        advancedMenus.forEach((menu, index) => {
            this.menus.set(`AdvancedMenu_${index}`, {
                type: 'AdvancedMenuBuilder',
                element: menu,
                responsive: true,
                itemCount: menu.querySelectorAll('.advanced-nav-item').length,
                status: 'active'
            });
        });
    }

    scanRadMenus() {
        const radMenus = document.querySelectorAll('.RadMenu');
        radMenus.forEach((menu, index) => {
            this.menus.set(`RadMenu_${index}`, {
                type: 'Telerik RadMenu',
                element: menu,
                responsive: menu.classList.contains('responsive-enabled'),
                itemCount: menu.querySelectorAll('.rmItem').length,
                status: 'active'
            });
        });
    }

    scanCustomMenus() {
        // البحث عن القوائم المخصصة الأخرى
        const customSelectors = [
            '.saserp-main-navigation',
            '.nav-menu',
            '.custom-menu',
            '.floating-menu'
        ];

        customSelectors.forEach(selector => {
            const menus = document.querySelectorAll(selector);
            menus.forEach((menu, index) => {
                const menuId = `${selector.replace('.', '')}_${index}`;
                this.menus.set(menuId, {
                    type: 'Custom Menu',
                    element: menu,
                    responsive: menu.classList.contains('responsive'),
                    itemCount: menu.querySelectorAll('a, .menu-item').length,
                    status: 'active'
                });
            });
        });
    }

    observeMenuChanges() {
        const observer = new MutationObserver((mutations) => {
            let needsRescan = false;
            
            mutations.forEach((mutation) => {
                if (mutation.type === 'childList') {
                    // تحقق من إضافة/حذف عقد قد تكون قوائم
                    mutation.addedNodes.forEach((node) => {
                        if (node.nodeType === 1) { // عقدة عنصر
                            if (this.isMenuElement(node)) {
                                needsRescan = true;
                            }
                        }
                    });
                }
            });
            
            if (needsRescan) {
                setTimeout(() => this.scanForMenus(), 100);
            }
        });

        observer.observe(document.body, {
            childList: true,
            subtree: true
        });
    }

    isMenuElement(element) {
        const menuSelectors = [
            '.PageMenuBar', '.Menu', '.RadMenu', 
            '.advanced-nav-wrapper', '.nav-menu',
            '.saserp-main-navigation'
        ];
        
        return menuSelectors.some(selector => 
            element.matches && element.matches(selector)
        );
    }

    updateCounter() {
        const count = this.menus.size;
        let counterBadge = document.querySelector('.menu-counter-badge');
        
        if (this.debugMode && count > 0) {
            if (!counterBadge) {
                counterBadge = document.createElement('div');
                counterBadge.className = 'menu-counter-badge';
                document.body.appendChild(counterBadge);
            }
            
            counterBadge.textContent = `${count} قوائم`;
            counterBadge.style.display = 'block';
            counterBadge.title = this.getMenuSummary().join('\n');
        } else if (counterBadge) {
            counterBadge.style.display = 'none';
        }
    }

    getMenuSummary() {
        const summary = [];
        this.menus.forEach((menu, key) => {
            summary.push(`${key}: ${menu.type} (${menu.itemCount} عناصر)`);
        });
        return summary;
    }

    enableDebugMode() {
        this.debugMode = true;
        this.updateCounter();
        console.log('🔍 Menu Manager Debug Mode Enabled');
        return this.getMenuSummary();
    }

    disableDebugMode() {
        this.debugMode = false;
        const counterBadge = document.querySelector('.menu-counter-badge');
        if (counterBadge) counterBadge.style.display = 'none';
        console.log('🔍 Menu Manager Debug Mode Disabled');
    }

    getMenuByType(type) {
        const result = [];
        this.menus.forEach((menu, key) => {
            if (menu.type.includes(type)) {
                result.push({ key, ...menu });
            }
        });
        return result;
    }

    toggleAllMenus(show = null) {
        this.menus.forEach((menu) => {
            if (menu.element) {
                if (show === null) {
                    menu.element.style.display = 
                        menu.element.style.display === 'none' ? '' : 'none';
                } else {
                    menu.element.style.display = show ? '' : 'none';
                }
            }
        });
    }

    // إضافة وظائف المساعدة العامة
    static addRippleEffect(button, event) {
        const ripple = document.createElement('span');
        const rect = button.getBoundingClientRect();
        const size = Math.max(rect.width, rect.height);
        const x = event.clientX - rect.left - size / 2;
        const y = event.clientY - rect.top - size / 2;
        
        ripple.style.cssText = `
            position: absolute;
            border-radius: 50%;
            background: rgba(255, 255, 255, 0.6);
            width: ${size}px;
            height: ${size}px;
            left: ${x}px;
            top: ${y}px;
            animation: ripple 0.6s linear;
            pointer-events: none;
        `;
        
        button.appendChild(ripple);
        setTimeout(() => ripple.remove(), 600);
    }
}

// إنشاء مثيل عام للمدير
window.menuManager = new MenuManager();

// إضافة دوال مساعدة للوحة التحكم
window.debugMenus = () => window.menuManager.enableDebugMode();
window.hideMenuDebug = () => window.menuManager.disableDebugMode();
window.listMenus = () => {
    console.table(
        Array.from(window.menuManager.menus.entries()).map(([key, menu]) => ({
            'اسم القائمة': key,
            'النوع': menu.type,
            'عدد العناصر': menu.itemCount,
            'استجابة': menu.responsive ? 'نعم' : 'لا',
            'الحالة': menu.status
        }))
    );
};

// تحسين وظيفة togglePageMenuBar الموجودة
if (typeof window.togglePageMenuBar === 'function') {
    const originalToggle = window.togglePageMenuBar;
    window.togglePageMenuBar = function(event) {
        // إضافة تأثير الموجة إذا كان الحدث متوفر
        if (event && event.target) {
            MenuManager.addRippleEffect(event.target, event);
        }
        
        // استدعاء الوظيفة الأصلية
        originalToggle.apply(this, arguments);
        
        // إعادة فحص القوائم
        setTimeout(() => window.menuManager.scanForMenus(), 100);
    };
}

console.log('📱 Menu Manager initialized successfully');
console.log('💡 Use debugMenus() to enable debug mode or listMenus() to see all menus');
