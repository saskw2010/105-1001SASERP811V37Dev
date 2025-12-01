/**
 * AdminLTE Style Sidebar Manager
 * Modern sidebar with RTL support and smooth animations
 * Inspired by AdminLTE dashboard theme
 */

class AdminSidebarManager {
    constructor() {
        this.sidebar = null;
        this.sidebarToggle = null;
        this.contentWrapper = null;
        this.dynamicMenuContainer = null;
        this.overlay = null;
        this.sidebarOpen = false;
        this.isInitialized = false;
        
        // Configuration
        this.config = {
            storageKey: 'admin-sidebar-state',
            animationDuration: 300,
            mobileBreakpoint: 768,
            collapsedWidth: 60,
            expandedWidth: 280
        };
        
        this.init();
    }
    
    init() {
        if (this.isInitialized) return;
        
        console.log('🚀 AdminLTE Sidebar Manager Initializing...');
        
        // Wait for DOM to be ready
        if (document.readyState === 'loading') {
            document.addEventListener('DOMContentLoaded', () => this.initializeElements());
        } else {
            this.initializeElements();
        }
    }
    
    initializeElements() {
        // Get DOM elements
        this.sidebar = document.getElementById('mainSidebar');
        this.sidebarToggle = document.getElementById('sidebarToggle');
        this.contentWrapper = document.getElementById('contentWrapper');
        this.dynamicMenuContainer = document.getElementById('dynamicSidebarMenu');
        
        if (!this.sidebar) {
            console.warn('❌ Sidebar element not found');
            return;
        }
        
        // Create overlay
        this.createOverlay();
        
        // Load saved state
        this.loadSidebarState();
        
        // Initialize components
        this.setupEventListeners();
        this.initializeTreeview();
        this.copyMenuContent();
        this.highlightActiveMenuItem();
        this.setupKeyboardShortcuts();
        this.setupThemeIntegration();
        
        this.isInitialized = true;
        console.log('✅ AdminLTE Sidebar Manager Initialized Successfully');
        
        // Dispatch custom event
        this.dispatchEvent('sidebarInitialized');
    }
    
    createOverlay() {
        this.overlay = document.createElement('div');
        this.overlay.className = 'sidebar-overlay';
        this.overlay.id = 'sidebarOverlay';
        document.body.appendChild(this.overlay);
    }
    
    setupEventListeners() {
        // Toggle button
        if (this.sidebarToggle) {
            this.sidebarToggle.addEventListener('click', (e) => {
                e.preventDefault();
                this.toggle();
            });
        }
        
        // Overlay click
        if (this.overlay) {
            this.overlay.addEventListener('click', () => this.close());
        }
        
        // Window resize
        window.addEventListener('resize', () => this.handleResize());
        
        // Route changes (for SPA-like behavior)
        window.addEventListener('popstate', () => this.highlightActiveMenuItem());
    }
    
    setupKeyboardShortcuts() {
        document.addEventListener('keydown', (e) => {
            // Escape key to close sidebar
            if (e.key === 'Escape' && this.sidebarOpen) {
                this.close();
            }
            
            // Ctrl/Cmd + B to toggle sidebar
            if ((e.ctrlKey || e.metaKey) && e.key === 'b') {
                e.preventDefault();
                this.toggle();
            }
        });
    }
    
    toggle() {
        if (this.sidebarOpen) {
            this.close();
        } else {
            this.open();
        }
    }
    
    open() {
        if (!this.sidebar) return;
        
        this.sidebarOpen = true;
        this.sidebar.classList.add('sidebar-open');
        
        if (this.contentWrapper) {
            this.contentWrapper.classList.add('sidebar-open');
        }
        
        // Show overlay on mobile
        if (this.isMobile() && this.overlay) {
            this.overlay.classList.add('show');
        }
        
        this.saveSidebarState();
        this.dispatchEvent('sidebarOpened');
        
        console.log('📖 Sidebar opened');
    }
    
    close() {
        if (!this.sidebar) return;
        
        this.sidebarOpen = false;
        this.sidebar.classList.remove('sidebar-open');
        
        if (this.contentWrapper) {
            this.contentWrapper.classList.remove('sidebar-open');
        }
        
        if (this.overlay) {
            this.overlay.classList.remove('show');
        }
        
        this.saveSidebarState();
        this.dispatchEvent('sidebarClosed');
        
        console.log('📕 Sidebar closed');
    }
    
    initializeTreeview() {
        const treeviewToggles = document.querySelectorAll('.nav-item.has-treeview > .nav-link');
        
        treeviewToggles.forEach(toggle => {
            toggle.addEventListener('click', (e) => {
                e.preventDefault();
                this.toggleTreeviewItem(toggle);
            });
        });
    }
    
    toggleTreeviewItem(toggleElement) {
        const parentItem = toggleElement.closest('.nav-item');
        const isOpen = parentItem.classList.contains('menu-open');
        
        // Close all other open menus (accordion behavior)
        document.querySelectorAll('.nav-item.menu-open').forEach(item => {
            if (item !== parentItem) {
                item.classList.remove('menu-open');
            }
        });
        
        // Toggle current menu
        if (isOpen) {
            parentItem.classList.remove('menu-open');
        } else {
            parentItem.classList.add('menu-open');
            // Add animation class
            const treeview = parentItem.querySelector('.nav-treeview');
            if (treeview) {
                treeview.style.animation = 'slideDown 0.3s ease';
            }
        }
        
        this.dispatchEvent('treeviewToggled', { item: parentItem, isOpen: !isOpen });
    }
    
    copyMenuContent() {
        if (!this.dynamicMenuContainer) return;
        
        // Wait for PageMenuBar to be fully loaded
        setTimeout(() => {
            const menuSources = [
                document.getElementById('PageMenuBar'),
                document.getElementById('ctl00_PageMenuBar'),
                document.querySelector('[id*="PageMenuBar"]'),
                document.querySelector('.modern-menu-wrapper')
            ];
            
            let foundMenu = null;
            for (const source of menuSources) {
                if (source && source.children.length > 0) {
                    foundMenu = source;
                    break;
                }
            }
            
            if (foundMenu) {
                console.log('📋 Found menu source, copying to sidebar...');
                this.extractMenuItems(foundMenu);
            } else {
                console.log('🔍 PageMenuBar not found, scanning for menu items...');
                this.scanForMenuItems();
            }
        }, 1500);
    }
    
    extractMenuItems(menuSource) {
        const menuItems = menuSource.querySelectorAll('a, .menuItem, .MenuItem, [class*="menu"]');
        let itemCount = 0;
        
        menuItems.forEach(item => {
            const text = this.getMenuItemText(item);
            const href = this.getMenuItemHref(item);
            
            if (text && text.trim() && text.length > 1) {
                this.createSidebarMenuItem(text, href);
                itemCount++;
            }
        });
        
        console.log(`📝 Copied ${itemCount} menu items to sidebar`);
        this.dispatchEvent('menuCopied', { itemCount });
    }
    
    scanForMenuItems() {
        // Fallback: scan common menu patterns
        const menuSelectors = [
            '[id*="menu"] a',
            '[class*="menu"] a',
            '[id*="nav"] a',
            '[class*="nav"] a',
            '.sitemap a'
        ];
        
        let foundItems = 0;
        menuSelectors.forEach(selector => {
            const items = document.querySelectorAll(selector);
            items.forEach(item => {
                const text = this.getMenuItemText(item);
                const href = this.getMenuItemHref(item);
                
                if (text && href && text.length > 2) {
                    this.createSidebarMenuItem(text, href);
                    foundItems++;
                }
            });
        });
        
        if (foundItems > 0) {
            console.log(`🔍 Found ${foundItems} menu items via scanning`);
        }
    }
    
    getMenuItemText(item) {
        return item.textContent || item.innerText || item.title || '';
    }
    
    getMenuItemHref(item) {
        return item.href || item.getAttribute('href') || '#';
    }
    
    createSidebarMenuItem(text, href) {
        const navItem = document.createElement('li');
        navItem.className = 'nav-item';
        
        const navLink = document.createElement('a');
        navLink.className = 'nav-link';
        navLink.href = href;
        
        const icon = document.createElement('i');
        icon.className = 'far fa-circle nav-icon';
        
        const textElement = document.createElement('p');
        textElement.textContent = text.trim();
        
        navLink.appendChild(icon);
        navLink.appendChild(textElement);
        navItem.appendChild(navLink);
        
        this.dynamicMenuContainer.appendChild(navItem);
    }
    
    highlightActiveMenuItem() {
        const currentPath = window.location.pathname.toLowerCase();
        const menuLinks = this.sidebar?.querySelectorAll('.nav-link[href]') || [];
        
        // Remove existing active classes
        menuLinks.forEach(link => link.classList.remove('active'));
        
        // Find and highlight active menu item
        let activeLink = null;
        let bestMatch = 0;
        
        menuLinks.forEach(link => {
            const linkPath = link.getAttribute('href').toLowerCase();
            
            if (linkPath === currentPath) {
                activeLink = link;
                bestMatch = linkPath.length;
            } else if (currentPath.includes(linkPath) && linkPath.length > bestMatch && linkPath !== '#') {
                activeLink = link;
                bestMatch = linkPath.length;
            }
        });
        
        if (activeLink) {
            activeLink.classList.add('active');
            
            // Open parent treeview if needed
            const parentTreeview = activeLink.closest('.nav-item.has-treeview');
            if (parentTreeview) {
                parentTreeview.classList.add('menu-open');
            }
            
            console.log('🎯 Active menu item highlighted:', activeLink.textContent.trim());
        }
    }
    
    setupThemeIntegration() {
        // Theme switcher in sidebar
        const sidebarThemeSwitcher = document.getElementById('sidebarThemeSwitcher');
        if (sidebarThemeSwitcher) {
            sidebarThemeSwitcher.addEventListener('click', (e) => {
                e.preventDefault();
                this.handleThemeSwitch();
            });
        }
        
        // Listen for theme changes
        document.addEventListener('themeChanged', (e) => {
            this.updateSidebarTheme(e.detail.theme);
        });
    }
    
    handleThemeSwitch() {
        // Try to trigger main theme switcher
        const mainThemeSwitcher = document.querySelector('.theme-switcher-dropdown');
        if (mainThemeSwitcher) {
            mainThemeSwitcher.click();
        } else if (window.AdvancedThemeSystem) {
            // Fallback: cycle through themes
            const themes = ['light', 'dark', 'ai', 'citrus', 'emerald', 'rose'];
            const currentTheme = window.AdvancedThemeSystem.getCurrentTheme();
            const currentIndex = themes.indexOf(currentTheme);
            const nextIndex = (currentIndex + 1) % themes.length;
            window.AdvancedThemeSystem.setTheme(themes[nextIndex]);
        }
    }
    
    updateSidebarTheme(theme) {
        if (!this.sidebar) return;
        
        // Remove existing theme classes
        this.sidebar.classList.remove('theme-light', 'theme-dark', 'theme-ai', 'theme-citrus', 'theme-emerald', 'theme-rose');
        
        // Add new theme class
        this.sidebar.classList.add(`theme-${theme}`);
        
        console.log(`🎨 Sidebar theme updated to: ${theme}`);
    }
    
    handleResize() {
        if (this.isMobile()) {
            // Mobile behavior
            if (this.sidebarOpen && this.overlay) {
                this.overlay.classList.add('show');
            }
            if (this.contentWrapper) {
                this.contentWrapper.classList.remove('sidebar-open');
            }
        } else {
            // Desktop behavior
            if (this.overlay) {
                this.overlay.classList.remove('show');
            }
            if (this.sidebarOpen && this.contentWrapper) {
                this.contentWrapper.classList.add('sidebar-open');
            }
        }
    }
    
    isMobile() {
        return window.innerWidth <= this.config.mobileBreakpoint;
    }
    
    saveSidebarState() {
        try {
            localStorage.setItem(this.config.storageKey, JSON.stringify({
                open: this.sidebarOpen,
                timestamp: Date.now()
            }));
        } catch (e) {
            console.warn('Could not save sidebar state:', e);
        }
    }
    
    loadSidebarState() {
        try {
            const saved = localStorage.getItem(this.config.storageKey);
            if (saved) {
                const state = JSON.parse(saved);
                // Only restore if saved recently (within 24 hours)
                if (Date.now() - state.timestamp < 24 * 60 * 60 * 1000) {
                    if (state.open) {
                        this.open();
                    }
                }
            }
        } catch (e) {
            console.warn('Could not load sidebar state:', e);
        }
    }
    
    dispatchEvent(eventName, detail = {}) {
        const event = new CustomEvent(`sidebar${eventName}`, {
            detail: { sidebar: this, ...detail },
            bubbles: true
        });
        document.dispatchEvent(event);
    }
    
    // Public API methods
    isOpen() {
        return this.sidebarOpen;
    }
    
    refresh() {
        this.copyMenuContent();
        this.highlightActiveMenuItem();
    }
    
    destroy() {
        if (this.overlay && this.overlay.parentNode) {
            this.overlay.parentNode.removeChild(this.overlay);
        }
        this.isInitialized = false;
        console.log('🗑️ Sidebar manager destroyed');
    }
}

// Auto-initialize when script loads
let sidebarManager = null;

document.addEventListener('DOMContentLoaded', function() {
    if (!sidebarManager) {
        sidebarManager = new AdminSidebarManager();
        
        // Make it globally accessible
        window.AdminSidebarManager = sidebarManager;
    }
});

// Export for module systems
if (typeof module !== 'undefined' && module.exports) {
    module.exports = AdminSidebarManager;
}
