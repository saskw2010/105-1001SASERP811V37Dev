/* ================================================
   🚀 PROMPT BUTTON NAVIGATION SYSTEM
   JavaScript functionality for floating navigation
   ================================================ */

class PromptButtonNavigation {
    constructor() {
        this.isNavOpen = false;
        this.isUserPanelOpen = false;
        this.navContainer = null;
        this.navMenu = null;
        this.backdrop = null;
        
        this.init();
    }

    init() {
        console.log('🚀 Initializing Prompt Button Navigation System');
        
        // Wait for DOM to be ready
        if (document.readyState === 'loading') {
            document.addEventListener('DOMContentLoaded', () => this.setup());
        } else {
            this.setup();
        }
    }

    setup() {
        this.findElements();
        this.createBackdrop();
        this.createCloseButton();
        this.setupEventListeners();
        this.transformExistingNavigation();
        this.setupPromptButtons();
        
        console.log('✅ Prompt Button Navigation System initialized');
    }

    findElements() {
        this.navContainer = document.getElementById('saserp-main-navigation');
        this.navMenu = document.getElementById('navMenu');
        
        if (!this.navContainer) {
            console.warn('⚠️ Navigation container not found');
            return false;
        }
        
        if (!this.navMenu) {
            console.warn('⚠️ Navigation menu not found');
            return false;
        }
        
        return true;
    }

    createBackdrop() {
        if (document.querySelector('.nav-backdrop')) return;
        
        this.backdrop = document.createElement('div');
        this.backdrop.className = 'nav-backdrop';
        this.backdrop.onclick = () => this.closeAllPanels();
        document.body.appendChild(this.backdrop);
    }

    createCloseButton() {
        if (!this.navMenu || this.navMenu.querySelector('.nav-close-btn')) return;
        
        const closeBtn = document.createElement('div');
        closeBtn.className = 'nav-close-btn';
        closeBtn.innerHTML = '✕';
        closeBtn.onclick = () => this.closeNavigation();
        closeBtn.setAttribute('aria-label', 'Close navigation');
        closeBtn.setAttribute('role', 'button');
        closeBtn.setAttribute('tabindex', '0');
        
        // Keyboard support for close button
        closeBtn.addEventListener('keydown', (e) => {
            if (e.key === 'Enter' || e.key === ' ') {
                e.preventDefault();
                this.closeNavigation();
            }
        });
        
        this.navMenu.appendChild(closeBtn);
    }

    setupPromptButtons() {
        if (!this.navContainer) return;

        // Make the pseudo-elements clickable by adding event listeners to the container
        this.navContainer.addEventListener('click', (e) => {
            const rect = this.navContainer.getBoundingClientRect();
            const clickX = e.clientX;
            const clickY = e.clientY;
            
            // Check if click is on navigation button area (::before)
            const navButtonArea = {
                left: window.innerWidth - 85,  // right: 20px, width: 65px
                right: window.innerWidth - 20,
                top: window.innerHeight - 205, // bottom: 140px, height: 65px
                bottom: window.innerHeight - 140
            };
            
            // Check if click is on user button area (::after)
            const userButtonArea = {
                left: window.innerWidth - 75,  // right: 20px, width: 55px
                right: window.innerWidth - 20,
                top: window.innerHeight - 275, // bottom: 220px, height: 55px
                bottom: window.innerHeight - 220
            };
            
            if (clickX >= navButtonArea.left && clickX <= navButtonArea.right &&
                clickY >= navButtonArea.top && clickY <= navButtonArea.bottom) {
                this.toggleNavigation();
            } else if (clickX >= userButtonArea.left && clickX <= userButtonArea.right &&
                       clickY >= userButtonArea.top && clickY <= userButtonArea.bottom) {
                this.toggleUserPanel();
            }
        });

        // Add hover labels
        this.createHoverLabels();
    }

    createHoverLabels() {
        if (!this.navContainer) return;

        // Create navigation button label
        const navLabel = document.createElement('div');
        navLabel.className = 'nav-button-label';
        navLabel.innerHTML = '📋 القائمة الرئيسية';
        navLabel.style.bottom = '142px';
        this.navContainer.appendChild(navLabel);

        // Create user button label
        const userLabel = document.createElement('div');
        userLabel.className = 'nav-button-label';
        userLabel.innerHTML = '👤 معلومات المستخدم';
        userLabel.style.bottom = '222px';
        this.navContainer.appendChild(userLabel);
    }

    transformExistingNavigation() {
        if (!this.navMenu) return;

        // Transform menu items for better display
        const menuContent = this.navMenu.querySelector('.saserp-menu-content');
        if (menuContent) {
            this.enhanceMenuItems(menuContent);
        }

        // Hide elements that are not needed in prompt mode
        this.hideUnneededElements();
    }

    enhanceMenuItems(menuContent) {
        const menuItems = menuContent.querySelectorAll('.saserp-menu-item');
        
        menuItems.forEach((item, index) => {
            // Add icons to menu items if they don't have them
            const linkContent = item.querySelector('.menu-link-content');
            if (linkContent) {
                const existingIcon = linkContent.querySelector('.menu-icon');
                if (!existingIcon) {
                    const icon = this.getMenuIcon(linkContent.textContent || '', index);
                    const iconSpan = document.createElement('span');
                    iconSpan.className = 'menu-icon';
                    iconSpan.innerHTML = icon;
                    linkContent.insertBefore(iconSpan, linkContent.firstChild);
                }
            }

            // Enhanced hover effects
            item.addEventListener('mouseenter', () => {
                item.style.transform = 'translateY(-3px) scale(1.02)';
            });

            item.addEventListener('mouseleave', () => {
                item.style.transform = 'translateY(0) scale(1)';
            });

            // Click handler for navigation
            const link = item.querySelector('a, .menu-link-content');
            if (link) {
                link.addEventListener('click', (e) => {
                    // Allow normal navigation and close panel
                    setTimeout(() => this.closeNavigation(), 150);
                });
            }
        });
    }

    hideUnneededElements() {
        // Hide mobile toggle and user info that are now replaced by prompt buttons
        const mobileToggle = this.navContainer.querySelector('.saserp-mobile-nav-toggle');
        const mobileUserInfo = this.navContainer.querySelector('.saserp-user-info-mobile');
        
        if (mobileToggle) mobileToggle.style.display = 'none';
        if (mobileUserInfo) mobileUserInfo.style.display = 'none';
    }

    getMenuIcon(text, index) {
        const icons = ['🏠', '📊', '👥', '📋', '⚙️', '📈', '💼', '🔧', '📱', '🌐'];
        
        // Smart icon assignment based on text content
        const lowerText = text.toLowerCase();
        
        if (lowerText.includes('home') || lowerText.includes('الرئيسية') || lowerText.includes('dashboard')) return '🏠';
        if (lowerText.includes('sales') || lowerText.includes('مبيعات') || lowerText.includes('بيع')) return '💰';
        if (lowerText.includes('purchase') || lowerText.includes('مشتريات') || lowerText.includes('شراء')) return '🛒';
        if (lowerText.includes('inventory') || lowerText.includes('مخزون') || lowerText.includes('مستودع')) return '📦';
        if (lowerText.includes('customer') || lowerText.includes('عملاء') || lowerText.includes('زبائن')) return '👥';
        if (lowerText.includes('supplier') || lowerText.includes('موردين') || lowerText.includes('مورد')) return '🏭';
        if (lowerText.includes('account') || lowerText.includes('حسابات') || lowerText.includes('محاسبة')) return '📊';
        if (lowerText.includes('report') || lowerText.includes('تقرير') || lowerText.includes('تقارير')) return '📈';
        if (lowerText.includes('settings') || lowerText.includes('إعدادات') || lowerText.includes('ضبط')) return '⚙️';
        if (lowerText.includes('admin') || lowerText.includes('إدارة') || lowerText.includes('مدير')) return '💼';
        if (lowerText.includes('user') || lowerText.includes('مستخدم') || lowerText.includes('مستخدمين')) return '👤';
        if (lowerText.includes('security') || lowerText.includes('أمان') || lowerText.includes('حماية')) return '🔒';
        if (lowerText.includes('backup') || lowerText.includes('نسخ احتياطي')) return '💾';
        if (lowerText.includes('help') || lowerText.includes('مساعدة') || lowerText.includes('دعم')) return '❓';
        
        return icons[index % icons.length];
    }

    setupEventListeners() {
        // Escape key to close panels
        document.addEventListener('keydown', (e) => {
            if (e.key === 'Escape') {
                this.closeAllPanels();
            }
        });

        // Window resize handler
        window.addEventListener('resize', () => {
            if (this.isNavOpen) {
                this.repositionPanels();
            }
        });

        // Prevent body scroll when panels are open
        document.addEventListener('touchmove', (e) => {
            if (this.isNavOpen) {
                e.preventDefault();
            }
        }, { passive: false });

        // Close on outside click
        document.addEventListener('click', (e) => {
            if (this.isNavOpen && 
                !this.navMenu.contains(e.target) && 
                !this.navContainer.contains(e.target)) {
                this.closeNavigation();
            }
        });
    }

    toggleNavigation() {
        if (this.isNavOpen) {
            this.closeNavigation();
        } else {
            this.openNavigation();
        }
    }

    openNavigation() {
        if (!this.navMenu || !this.backdrop) return;

        // Close user panel if open
        this.closeUserPanel();

        this.navMenu.classList.add('active');
        this.backdrop.classList.add('active');
        document.body.style.overflow = 'hidden';
        
        this.isNavOpen = true;
        
        // Focus management for accessibility
        const firstFocusable = this.navMenu.querySelector('a, button, [tabindex="0"]');
        if (firstFocusable) {
            setTimeout(() => firstFocusable.focus(), 100);
        }

        console.log('📋 Navigation panel opened');
    }

    closeNavigation() {
        if (!this.navMenu || !this.backdrop) return;

        this.navMenu.classList.remove('active');
        this.backdrop.classList.remove('active');
        document.body.style.overflow = '';
        
        this.isNavOpen = false;
        
        console.log('📋 Navigation panel closed');
    }

    toggleUserPanel() {
        // Try to integrate with existing unified user info system
        const userContainer = document.querySelector('.unified-user-container');
        if (userContainer) {
            const userTrigger = userContainer.querySelector('.user-trigger');
            if (userTrigger) {
                userTrigger.click();
                return;
            }
        }
        
        // Fallback: create simple user panel
        this.createSimpleUserPanel();
    }

    createSimpleUserPanel() {
        // Remove existing panel if any
        const existingPanel = document.querySelector('.simple-user-panel');
        if (existingPanel) {
            existingPanel.remove();
            return;
        }

        console.log('👤 Creating simple user panel');
        
        const userPanel = document.createElement('div');
        userPanel.className = 'simple-user-panel';
        userPanel.innerHTML = `
            <div class="user-panel-header">
                <h3>👤 معلومات المستخدم</h3>
                <div class="user-close-btn">✕</div>
            </div>
            <div class="user-panel-content">
                <div class="user-info">
                    <p><strong>المستخدم:</strong> ${this.getCurrentUserName()}</p>
                    <p><strong>الدور:</strong> ${this.getCurrentUserRole()}</p>
                    <p><strong>الحالة:</strong> <span style="color: green;">متصل</span></p>
                    <p><strong>آخر دخول:</strong> ${new Date().toLocaleDateString('ar-SA')}</p>
                </div>
                <div class="user-actions">
                    <button onclick="this.handleProfileClick()">الملف الشخصي</button>
                    <button onclick="this.handleSettingsClick()">الإعدادات</button>
                    <button onclick="this.handleNotificationsClick()">الإشعارات</button>
                    <button onclick="this.handleLogoutClick()" style="background: #dc2626; color: white;">تسجيل الخروج</button>
                </div>
            </div>
        `;
        
        userPanel.style.cssText = `
            position: fixed;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            width: 320px;
            background: white;
            border-radius: 15px;
            box-shadow: 0 20px 60px rgba(0,0,0,0.3);
            z-index: 10001;
            padding: 20px;
            animation: fadeInScale 0.3s ease-out;
            direction: rtl;
            text-align: right;
        `;
        
        document.body.appendChild(userPanel);
        
        // Show backdrop
        if (this.backdrop) {
            this.backdrop.classList.add('active');
        }
        
        // Close button functionality
        userPanel.querySelector('.user-close-btn').onclick = () => {
            userPanel.remove();
            if (this.backdrop) {
                this.backdrop.classList.remove('active');
            }
        };

        // Button handlers
        const buttons = userPanel.querySelectorAll('button');
        buttons[0].onclick = () => this.handleProfileClick();
        buttons[1].onclick = () => this.handleSettingsClick();
        buttons[2].onclick = () => this.handleNotificationsClick();
        buttons[3].onclick = () => this.handleLogoutClick();
    }

    getCurrentUserName() {
        // Try to get from various sources
        const userName = document.getElementById('desktopUserName')?.textContent ||
                        document.getElementById('mobileUserName')?.textContent ||
                        'مستخدم ضيف';
        return userName;
    }

    getCurrentUserRole() {
        const userRole = document.getElementById('desktopUserRole')?.textContent ||
                        document.getElementById('mobileUserRole')?.textContent ||
                        'زائر';
        return userRole;
    }

    handleProfileClick() {
        alert('سيتم فتح صفحة الملف الشخصي');
        // Add your profile logic here
    }

    handleSettingsClick() {
        alert('سيتم فتح صفحة الإعدادات');
        // Add your settings logic here
    }

    handleNotificationsClick() {
        alert('سيتم فتح صفحة الإشعارات');
        // Add your notifications logic here
    }

    handleLogoutClick() {
        if (confirm('هل أنت متأكد من تسجيل الخروج؟')) {
            // Add your logout logic here
            window.location.href = '/Login.aspx?logout=true';
        }
    }

    closeUserPanel() {
        // Close unified user info panel
        const userContainer = document.querySelector('.unified-user-container');
        if (userContainer && userContainer.classList.contains('expanded')) {
            const userTrigger = userContainer.querySelector('.user-trigger');
            if (userTrigger) {
                userTrigger.click();
            }
        }
        
        // Remove simple user panel if exists
        const simplePanel = document.querySelector('.simple-user-panel');
        if (simplePanel) {
            simplePanel.remove();
        }
        
        // Hide backdrop if no other panels are open
        if (!this.isNavOpen && this.backdrop) {
            this.backdrop.classList.remove('active');
        }
        
        this.isUserPanelOpen = false;
    }

    closeAllPanels() {
        this.closeNavigation();
        this.closeUserPanel();
    }

    repositionPanels() {
        // Reposition panels on window resize
        if (this.navMenu && this.isNavOpen) {
            this.navMenu.style.transform = 'translate(-50%, -50%) scale(1)';
        }
    }

    // Public API methods
    open() {
        this.openNavigation();
    }

    close() {
        this.closeAllPanels();
    }

    toggle() {
        this.toggleNavigation();
    }

    isOpen() {
        return this.isNavOpen;
    }
}

// Auto-initialize when DOM is ready
document.addEventListener('DOMContentLoaded', () => {
    // Check if navigation container exists
    const navContainer = document.getElementById('saserp-main-navigation');
    if (navContainer) {
        // Initialize the prompt navigation system
        window.promptNavigation = new PromptButtonNavigation();
        
        // Make it globally accessible
        window.toggleNav = () => window.promptNavigation.toggle();
        window.openNav = () => window.promptNavigation.open();
        window.closeNav = () => window.promptNavigation.close();
        
        console.log('🚀 Prompt Button Navigation System ready!');
    } else {
        console.warn('⚠️ Navigation container not found. Prompt buttons not initialized.');
    }
});

// CSS injection for additional styling
const injectAdditionalCSS = () => {
    const style = document.createElement('style');
    style.textContent = `
        @keyframes fadeInScale {
            from {
                opacity: 0;
                transform: translate(-50%, -50%) scale(0.8);
            }
            to {
                opacity: 1;
                transform: translate(-50%, -50%) scale(1);
            }
        }
        
        .simple-user-panel {
            font-family: 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        
        .user-panel-header {
            display: flex;
            justify-content: space-between;
            align-items: center;
            margin-bottom: 15px;
            padding-bottom: 10px;
            border-bottom: 1px solid #e5e7eb;
        }
        
        .user-panel-header h3 {
            margin: 0;
            color: #1f2937;
            font-size: 16px;
        }
        
        .user-close-btn {
            cursor: pointer;
            padding: 5px;
            border-radius: 50%;
            width: 25px;
            height: 25px;
            display: flex;
            align-items: center;
            justify-content: center;
            background: #f3f4f6;
            transition: all 0.3s ease;
        }
        
        .user-close-btn:hover {
            background: #ef4444;
            color: white;
        }
        
        .user-info p {
            margin: 8px 0;
            font-size: 14px;
            color: #374151;
        }
        
        .user-actions {
            margin-top: 15px;
            padding-top: 15px;
            border-top: 1px solid #e5e7eb;
        }
        
        .user-actions button {
            display: block;
            width: 100%;
            margin: 8px 0;
            padding: 12px;
            border: 1px solid #d1d5db;
            border-radius: 8px;
            background: #f9fafb;
            cursor: pointer;
            transition: all 0.3s ease;
            font-size: 14px;
            font-weight: 500;
        }
        
        .user-actions button:hover {
            background: #2563eb;
            color: white;
            border-color: #2563eb;
            transform: translateY(-1px);
        }
        
        /* Accessibility improvements */
        .nav-close-btn:focus,
        .user-close-btn:focus {
            outline: 2px solid #2563eb;
            outline-offset: 2px;
        }
        
        /* Loading state for buttons */
        .prompt-loading {
            opacity: 0.7;
            pointer-events: none;
        }
        
        /* Error state */
        .prompt-error {
            border-color: #ef4444 !important;
            background: rgba(239, 68, 68, 0.1) !important;
        }
    `;
    document.head.appendChild(style);
};

// Inject CSS when script loads
injectAdditionalCSS();

// Export for module systems if available
if (typeof module !== 'undefined' && module.exports) {
    module.exports = PromptButtonNavigation;
}
