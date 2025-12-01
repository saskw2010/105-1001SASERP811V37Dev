/* 🚀 SASERP Modern Responsive Navigation JavaScript System */
/* ========================================================================= */

class SASERPNavigationSystem {
    constructor() {
        this.isMenuOpen = false;
        this.userInfo = {
            name: 'Guest User',
            role: 'Visitor',
            isAuthenticated: false,
            avatar: null,
            notifications: 0
        };
        
        this.init();
    }
    
    init() {
        console.log('🚀 Initializing SASERP Navigation System...');
        
        // Wait for DOM to be ready
        if (document.readyState === 'loading') {
            document.addEventListener('DOMContentLoaded', () => this.setupNavigation());
        } else {
            this.setupNavigation();
        }
    }
    
    setupNavigation() {
        this.bindEvents();
        this.loadUserInfo();
        this.initializeMenuState();
        this.setupKeyboardNavigation();
        this.setupResponsiveHandlers();
        
        console.log('✅ SASERP Navigation System initialized successfully');
    }
    
    bindEvents() {
        // Mobile toggle button
        const toggleBtn = document.querySelector('.saserp-mobile-nav-toggle');
        if (toggleBtn) {
            toggleBtn.addEventListener('click', (e) => {
                e.preventDefault();
                e.stopPropagation();
                this.toggleMobileMenu();
            });
        }
        
        // Overlay click to close
        const overlay = document.querySelector('.saserp-nav-overlay');
        if (overlay) {
            overlay.addEventListener('click', () => this.closeMobileMenu());
        }
        
        // Close menu on escape key
        document.addEventListener('keydown', (e) => {
            if (e.key === 'Escape' && this.isMenuOpen) {
                this.closeMobileMenu();
            }
        });
        
        // Quick action buttons
        this.bindQuickActions();
        
        // Menu item clicks
        this.bindMenuItems();
    }
    
    bindQuickActions() {
        const actions = {
            'showUserProfile': () => this.showUserProfile(),
            'showUserSettings': () => this.showUserSettings(),
            'showNotifications': () => this.showNotifications(),
            'performLogout': () => this.performLogout()
        };
        
        Object.keys(actions).forEach(action => {
            window[action] = actions[action];
        });
    }
    
    bindMenuItems() {
        // Handle main navigation toggle
        this.setupMainNavToggle();
        
        // Handle submenu toggles (arrows)
        this.setupSubmenuToggles();
        
        // Handle menu link clicks (title areas)
        this.setupMenuLinks();
        
        // Auto-close menu after navigation
        this.setupAutoClose();
    }
    
    setupMainNavToggle() {
        const toggleBtn = document.querySelector('.saserp-mobile-nav-toggle');
        if (toggleBtn) {
            toggleBtn.addEventListener('click', (e) => {
                e.preventDefault();
                e.stopPropagation();
                this.toggleMobileMenu();
            });
        }
    }
    
    setupSubmenuToggles() {
        const dropdownToggles = document.querySelectorAll('.dropdown-toggle');
        dropdownToggles.forEach(toggle => {
            toggle.addEventListener('click', (e) => {
                e.preventDefault();
                e.stopPropagation();
                this.toggleSubmenu(toggle);
            });
        });
    }
    
    setupMenuLinks() {
        const menuLinks = document.querySelectorAll('.menu-link-content');
        menuLinks.forEach(link => {
            link.addEventListener('click', (e) => {
                // Don't prevent default - allow normal navigation
                console.log('📍 Navigating to:', link.href || link.getAttribute('data-url'));
                
                // Close mobile menu after navigation (with delay for visual feedback)
                if (window.innerWidth <= 768) {
                    setTimeout(() => this.closeMobileMenu(), 150);
                }
            });
        });
    }
    
    setupAutoClose() {
        // Close menu when clicking outside
        document.addEventListener('click', (e) => {
            const navMenu = document.getElementById('navMenu');
            const navToggle = document.querySelector('.saserp-mobile-nav-toggle');
            
            if (navMenu && navToggle && this.isMenuOpen) {
                if (!navMenu.contains(e.target) && !navToggle.contains(e.target)) {
                    this.closeMobileMenu();
                }
            }
        });
    }
    
    toggleSubmenu(toggleButton) {
        const menuItem = toggleButton.closest('.saserp-menu-item');
        const submenu = menuItem.querySelector('.saserp-submenu');
        
        if (!submenu) return;
        
        const isExpanded = submenu.classList.contains('expanded');
        
        if (isExpanded) {
            // Collapse submenu
            submenu.classList.remove('expanded');
            toggleButton.classList.remove('expanded');
            menuItem.classList.remove('expanded');
            
            // Also collapse any child submenus
            const childSubmenus = submenu.querySelectorAll('.saserp-submenu.expanded');
            childSubmenus.forEach(child => {
                child.classList.remove('expanded');
                const childToggle = child.closest('.saserp-menu-item').querySelector('.dropdown-toggle');
                if (childToggle) {
                    childToggle.classList.remove('expanded');
                }
            });
            
            console.log('📁 Submenu collapsed');
        } else {
            // Expand submenu
            submenu.classList.add('expanded');
            toggleButton.classList.add('expanded');
            menuItem.classList.add('expanded');
            
            // Optional: Close other submenus at the same level
            const parentSubmenu = menuItem.closest('.saserp-submenu');
            if (parentSubmenu) {
                const siblingItems = parentSubmenu.querySelectorAll('.saserp-menu-item');
                siblingItems.forEach(sibling => {
                    if (sibling !== menuItem) {
                        const siblingSubmenu = sibling.querySelector('.saserp-submenu');
                        const siblingToggle = sibling.querySelector('.dropdown-toggle');
                        if (siblingSubmenu && siblingSubmenu.classList.contains('expanded')) {
                            siblingSubmenu.classList.remove('expanded');
                            if (siblingToggle) siblingToggle.classList.remove('expanded');
                            sibling.classList.remove('expanded');
                        }
                    }
                });
            } else {
                // Close other top-level submenus (optional)
                const topLevelItems = document.querySelectorAll('.saserp-responsive-menu > .saserp-menu-item');
                topLevelItems.forEach(item => {
                    if (item !== menuItem) {
                        const itemSubmenu = item.querySelector('.saserp-submenu');
                        const itemToggle = item.querySelector('.dropdown-toggle');
                        if (itemSubmenu && itemSubmenu.classList.contains('expanded')) {
                            itemSubmenu.classList.remove('expanded');
                            if (itemToggle) itemToggle.classList.remove('expanded');
                            item.classList.remove('expanded');
                        }
                    }
                });
            }
            
            console.log('📂 Submenu expanded');
        }
        
        // Scroll into view if needed
        if (!isExpanded && window.innerWidth <= 768) {
            setTimeout(() => {
                submenu.scrollIntoView({ behavior: 'smooth', block: 'nearest' });
            }, 100);
        }
    }
    
    toggleMobileMenu() {
        if (this.isMenuOpen) {
            this.closeMobileMenu();
        } else {
            this.openMobileMenu();
        }
    }
    
    openMobileMenu() {
        const menu = document.getElementById('navMenu');
        const overlay = document.querySelector('.saserp-nav-overlay');
        const toggleBtn = document.querySelector('.saserp-mobile-nav-toggle');
        
        if (menu) {
            menu.classList.add('active');
            this.isMenuOpen = true;
            document.body.style.overflow = 'hidden';
            
            // Update toggle button icon
            const icon = toggleBtn?.querySelector('i');
            if (icon) {
                icon.className = 'fas fa-times';
            }
            
            // Show overlay
            if (overlay) {
                overlay.classList.add('active');
            }
            
            console.log('📱 Mobile menu opened');
        }
    }
    
    closeMobileMenu() {
        const menu = document.getElementById('navMenu');
        const overlay = document.querySelector('.saserp-nav-overlay');
        const toggleBtn = document.querySelector('.saserp-mobile-nav-toggle');
        
        if (menu) {
            menu.classList.remove('active');
            this.isMenuOpen = false;
            document.body.style.overflow = '';
            
            // Update toggle button icon
            const icon = toggleBtn?.querySelector('i');
            if (icon) {
                icon.className = 'fas fa-bars';
            }
            
            // Hide overlay
            if (overlay) {
                overlay.classList.remove('active');
            }
            
            console.log('📱 Mobile menu closed');
        }
    }
    
    loadUserInfo() {
        try {
            // Try to get user info from MembershipBar or session
            this.getUserFromMembershipBar();
            
            // Update UI with user info
            this.updateUserDisplay();
            
        } catch (error) {
            console.warn('⚠️ Could not load user info:', error);
            this.setGuestUser();
        }
    }
    
    getUserFromMembershipBar() {
        // Try to get user info from ASP.NET MembershipBar
        const membershipBar = document.querySelector('#mb, [id*="MembershipBar"]');
        
        if (membershipBar) {
            // Look for user info in hidden fields or data attributes
            const userNameField = document.querySelector('input[id*="UserName"], [data-username]');
            const userRoleField = document.querySelector('input[id*="Role"], [data-userrole]');
            
            if (userNameField && userNameField.value) {
                this.userInfo.name = userNameField.value;
                this.userInfo.isAuthenticated = true;
            }
            
            if (userRoleField && userRoleField.value) {
                this.userInfo.role = userRoleField.value;
            }
        }
        
        // Try to get from page context or global variables
        if (window.currentUser) {
            this.userInfo = { ...this.userInfo, ...window.currentUser };
        }
        
        // Try to get from ASP.NET Page methods
        if (typeof GetCurrentUserInfo === 'function') {
            GetCurrentUserInfo((result) => {
                if (result && result.success) {
                    this.userInfo = { ...this.userInfo, ...result.data };
                    this.updateUserDisplay();
                }
            });
        }
    }
    
    setGuestUser() {
        this.userInfo = {
            name: 'Guest User',
            role: 'Visitor',
            isAuthenticated: false,
            avatar: null,
            notifications: 0
        };
        this.updateUserDisplay();
    }
    
    updateUserDisplay() {
        // Update mobile user info
        const mobileUserName = document.getElementById('mobileUserName');
        const mobileUserRole = document.getElementById('mobileUserRole');
        
        if (mobileUserName) mobileUserName.textContent = this.userInfo.name;
        if (mobileUserRole) mobileUserRole.textContent = this.userInfo.role;
        
        // Update desktop user info
        const desktopUserName = document.getElementById('desktopUserName');
        const desktopUserRole = document.getElementById('desktopUserRole');
        
        if (desktopUserName) desktopUserName.textContent = this.userInfo.name;
        if (desktopUserRole) desktopUserRole.textContent = this.userInfo.role;
        
        // Update notification badge
        const notificationBadge = document.querySelector('.notification-badge');
        if (notificationBadge && this.userInfo.notifications > 0) {
            notificationBadge.textContent = this.userInfo.notifications;
            notificationBadge.style.display = 'block';
        } else if (notificationBadge) {
            notificationBadge.style.display = 'none';
        }
        
        // Update online status
        const statusIndicator = document.querySelector('.user-status.online');
        if (statusIndicator && this.userInfo.isAuthenticated) {
            statusIndicator.style.display = 'block';
        } else if (statusIndicator) {
            statusIndicator.style.display = 'none';
        }
        
        console.log('👤 User display updated:', this.userInfo);
    }
    
    initializeMenuState() {
        // Ensure menu is closed on desktop
        if (window.innerWidth > 768) {
            this.closeMobileMenu();
        }
    }
    
    setupKeyboardNavigation() {
        // Handle keyboard navigation for accessibility
        const menuItems = document.querySelectorAll('.saserp-menu-content a, .quick-action-btn, .action-link');
        
        menuItems.forEach((item, index) => {
            item.addEventListener('keydown', (e) => {
                switch (e.key) {
                    case 'ArrowDown':
                        e.preventDefault();
                        const nextItem = menuItems[index + 1];
                        if (nextItem) nextItem.focus();
                        break;
                        
                    case 'ArrowUp':
                        e.preventDefault();
                        const prevItem = menuItems[index - 1];
                        if (prevItem) prevItem.focus();
                        break;
                        
                    case 'Enter':
                    case ' ':
                        e.preventDefault();
                        item.click();
                        break;
                }
            });
        });
    }
    
    setupResponsiveHandlers() {
        // Handle window resize
        window.addEventListener('resize', () => {
            if (window.innerWidth > 768 && this.isMenuOpen) {
                this.closeMobileMenu();
            }
        });
        
        // Handle orientation change on mobile
        window.addEventListener('orientationchange', () => {
            setTimeout(() => {
                this.initializeMenuState();
            }, 100);
        });
    }
    
    // User Action Methods
    showUserProfile() {
        console.log('👤 Opening user profile...');
        
        // Try to navigate to profile page
        if (this.userInfo.isAuthenticated) {
            window.location.href = '/Profile.aspx';
        } else {
            window.location.href = '/Login.aspx';
        }
    }
    
    showUserSettings() {
        console.log('⚙️ Opening user settings...');
        
        if (this.userInfo.isAuthenticated) {
            window.location.href = '/Settings.aspx';
        } else {
            alert('Please login to access settings.');
        }
    }
    
    showNotifications() {
        console.log('🔔 Opening notifications...');
        
        if (this.userInfo.isAuthenticated) {
            // You can implement a modal or navigate to notifications page
            alert(`You have ${this.userInfo.notifications} notifications.`);
        } else {
            alert('Please login to view notifications.');
        }
    }
    
    performLogout() {
        console.log('🚪 Performing logout...');
        
        if (this.userInfo.isAuthenticated) {
            if (confirm('Are you sure you want to logout?')) {
                // Try ASP.NET logout first
                if (window.Membership && window.Membership.logout) {
                    window.Membership.logout();
                } else {
                    // Fallback to standard logout
                    window.location.href = '/Login.aspx?logout=true';
                }
            }
        }
    }
    
    // Helper method to refresh menu state after DOM changes
    refreshMenuBindings() {
        console.log('🔄 Refreshing menu bindings...');
        this.setupSubmenuToggles();
        this.setupMenuLinks();
    }
    
    // Collapse all open submenus
    collapseAllSubmenus() {
        const expandedSubmenus = document.querySelectorAll('.saserp-submenu.expanded');
        const expandedToggles = document.querySelectorAll('.dropdown-toggle.expanded');
        const expandedItems = document.querySelectorAll('.saserp-menu-item.expanded');
        
        expandedSubmenus.forEach(submenu => submenu.classList.remove('expanded'));
        expandedToggles.forEach(toggle => toggle.classList.remove('expanded'));
        expandedItems.forEach(item => item.classList.remove('expanded'));
        
        console.log('📁 All submenus collapsed');
    }
    
    // Set active menu item
    setActiveMenuItem(url) {
        // Remove existing active states
        const activeItems = document.querySelectorAll('.saserp-menu-item.active');
        activeItems.forEach(item => item.classList.remove('active'));
        
        // Find and set new active item
        const menuLinks = document.querySelectorAll('.menu-link-content');
        menuLinks.forEach(link => {
            const linkHref = link.getAttribute('href') || link.getAttribute('data-url') || '';
            if (linkHref === url || window.location.pathname.endsWith(linkHref)) {
                const menuItem = link.closest('.saserp-menu-item');
                if (menuItem) {
                    menuItem.classList.add('active');
                    
                    // Expand parent submenus to show active item
                    let parent = menuItem.closest('.saserp-submenu');
                    while (parent) {
                        parent.classList.add('expanded');
                        const parentItem = parent.closest('.saserp-menu-item');
                        if (parentItem) {
                            parentItem.classList.add('expanded');
                            const parentToggle = parentItem.querySelector('.dropdown-toggle');
                            if (parentToggle) {
                                parentToggle.classList.add('expanded');
                            }
                        }
                        parent = parentItem ? parentItem.closest('.saserp-submenu') : null;
                    }
                }
            }
        });
    }
    
    // Set user information for display
    setUserInfo(userInfo) {
        console.log('👤 Setting user info:', userInfo);
        
        if (!userInfo) {
            console.warn('⚠️ No user info provided to setUserInfo');
            return;
        }
        
        // Update internal user info
        if (typeof userInfo === 'object') {
            this.userInfo = { ...this.userInfo, ...userInfo };
        }
        
        // Update mobile user display
        const mobileUserName = document.getElementById('mobileUserName');
        const mobileUserRole = document.getElementById('mobileUserRole');
        
        if (mobileUserName && userInfo.name) {
            mobileUserName.textContent = userInfo.name;
        }
        
        if (mobileUserRole && userInfo.role) {
            mobileUserRole.textContent = userInfo.role;
        }
        
        // Update desktop user display
        const desktopUserName = document.getElementById('desktopUserName');
        const desktopUserRole = document.getElementById('desktopUserRole');
        
        if (desktopUserName && userInfo.name) {
            desktopUserName.textContent = userInfo.name;
        }
        
        if (desktopUserRole && userInfo.role) {
            desktopUserRole.textContent = userInfo.role;
        }
        
        console.log('✅ User info updated successfully');
    }
}

// Initialize the navigation system
let saserpNav;

// Ensure it's initialized when DOM is ready
function initializeSASERPNavigation() {
    if (!saserpNav) {
        saserpNav = new SASERPNavigationSystem();
        
        // Make it globally available
        window.SASERPNav = saserpNav;
        
        // Expose useful methods globally for backward compatibility
        window.toggleNavMenu = () => saserpNav.toggleMobileMenu();
        window.showUserProfile = () => saserpNav.showUserProfile();
        window.showUserSettings = () => saserpNav.showUserSettings();
        window.showNotifications = () => saserpNav.showNotifications();
        window.performLogout = () => saserpNav.performLogout();
    }
}

// Initialize immediately if DOM is ready, otherwise wait
if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', initializeSASERPNavigation);
} else {
    initializeSASERPNavigation();
}

// Fallback initialization for older browsers
if (window.attachEvent) {
    window.attachEvent('onload', initializeSASERPNavigation);
} else if (window.addEventListener) {
    window.addEventListener('load', initializeSASERPNavigation, false);
}

console.log('📄 SASERP Navigation System script loaded');

// Export for module systems if available
if (typeof module !== 'undefined' && module.exports) {
    module.exports = SASERPNavigationSystem;
}
