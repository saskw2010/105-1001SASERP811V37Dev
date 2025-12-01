/* Modern Navigation JavaScript
   SKY ERP - Advanced Navigation System
   Fully responsive with smooth animations */

class ModernNavigation {
    constructor() {
        this.navMenu = document.getElementById('navMenu');
        this.navToggle = document.querySelector('.saserp-mobile-nav-toggle');
        this.navToggleIcon = document.querySelector('.saserp-mobile-nav-toggle i');
        this.navbar = document.querySelector('.modern-navbar');
        this.navLinks = document.querySelectorAll('.nav-link');
        this.dropdownItems = document.querySelectorAll('.nav-dropdown-item');
        
        this.init();
    }

    init() {
        this.bindEvents();
        this.handleScroll();
        this.setActiveLink();
        this.handleKeyboard();
    }

    bindEvents() {
        // Toggle mobile menu
        if (this.navToggle) {
            this.navToggle.addEventListener('click', (e) => {
                e.stopPropagation();
                this.toggleMobileMenu();
            });
        }

        // Close menu when clicking outside
        document.addEventListener('click', (event) => {
            if (this.navMenu && this.navbar && !this.navbar.contains(event.target)) {
                this.closeMobileMenu();
            }
        });

        // Close menu when clicking on a link (mobile)
        this.navLinks.forEach(link => {
            link.addEventListener('click', () => {
                if (window.innerWidth <= 768) {
                    this.closeMobileMenu();
                }
            });
        });

        // Handle dropdown clicks on mobile
        this.navLinks.forEach(link => {
            if (link.nextElementSibling && link.nextElementSibling.classList.contains('nav-dropdown')) {
                link.addEventListener('click', (e) => {
                    if (window.innerWidth <= 768) {
                        e.preventDefault();
                        this.toggleDropdown(link.nextElementSibling);
                    }
                });
            }
        });

        // Scroll event for navbar effects
        window.addEventListener('scroll', () => {
            this.handleScroll();
        });

        // Resize event
        window.addEventListener('resize', () => {
            this.handleResize();
        });
    }

    toggleMobileMenu() {
        if (this.navMenu) {
            const isActive = this.navMenu.classList.contains('active');
            
            if (isActive) {
                this.closeMobileMenu();
            } else {
                this.openMobileMenu();
            }
        }
    }

    openMobileMenu() {
        if (this.navMenu && this.navToggleIcon) {
            this.navMenu.classList.add('active');
            this.navToggleIcon.className = 'fas fa-times';
            document.body.style.overflow = 'hidden'; // Prevent background scroll
        }
    }

    closeMobileMenu() {
        if (this.navMenu && this.navToggleIcon) {
            this.navMenu.classList.remove('active');
            this.navToggleIcon.className = 'fas fa-bars';
            document.body.style.overflow = ''; // Restore scroll
        }
    }

    toggleDropdown(dropdown) {
        if (dropdown) {
            const isVisible = dropdown.style.display === 'block';
            
            // Close all other dropdowns
            document.querySelectorAll('.nav-dropdown').forEach(dd => {
                if (dd !== dropdown) {
                    dd.style.display = 'none';
                }
            });

            // Toggle current dropdown
            dropdown.style.display = isVisible ? 'none' : 'block';
        }
    }

    handleScroll() {
        if (this.navbar) {
            const scrolled = window.scrollY > 50;
            
            if (scrolled) {
                this.navbar.classList.add('scrolled');
                this.navbar.style.background = 'linear-gradient(135deg, rgba(37, 99, 235, 0.95) 0%, rgba(29, 78, 216, 0.95) 100%)';
                this.navbar.style.backdropFilter = 'blur(15px)';
                this.navbar.style.boxShadow = '0 6px 30px rgba(37, 99, 235, 0.2)';
            } else {
                this.navbar.classList.remove('scrolled');
                this.navbar.style.background = 'linear-gradient(135deg, var(--nav-primary) 0%, var(--nav-secondary) 100%)';
                this.navbar.style.backdropFilter = 'blur(10px)';
                this.navbar.style.boxShadow = 'var(--nav-shadow)';
            }
        }
    }

    setActiveLink() {
        const currentPath = window.location.pathname;
        
        this.navLinks.forEach(link => {
            const href = link.getAttribute('href');
            
            if (href && (currentPath.includes(href) || href === currentPath)) {
                link.classList.add('active');
            } else {
                link.classList.remove('active');
            }
        });

        this.dropdownItems.forEach(item => {
            const href = item.getAttribute('href');
            
            if (href && (currentPath.includes(href) || href === currentPath)) {
                item.classList.add('active');
                // Also highlight parent nav item
                const parentDropdown = item.closest('.nav-dropdown');
                if (parentDropdown) {
                    const parentNavItem = parentDropdown.previousElementSibling;
                    if (parentNavItem) {
                        parentNavItem.classList.add('active');
                    }
                }
            } else {
                item.classList.remove('active');
            }
        });
    }

    handleKeyboard() {
        // ESC key to close mobile menu
        document.addEventListener('keydown', (e) => {
            if (e.key === 'Escape') {
                this.closeMobileMenu();
            }
        });

        // Enter and Space to activate nav toggle
        if (this.navToggle) {
            this.navToggle.addEventListener('keydown', (e) => {
                if (e.key === 'Enter' || e.key === ' ') {
                    e.preventDefault();
                    this.toggleMobileMenu();
                }
            });
        }
    }

    handleResize() {
        // Close mobile menu on resize to desktop
        if (window.innerWidth > 768) {
            this.closeMobileMenu();
            
            // Reset dropdown displays
            document.querySelectorAll('.nav-dropdown').forEach(dropdown => {
                dropdown.style.display = '';
            });
        }
    }

    // Public method to programmatically navigate
    navigateTo(url) {
        if (url) {
            window.location.href = url;
        }
    }

    // Public method to highlight specific menu item
    setActiveMenuItem(selector) {
        // Remove all active states
        document.querySelectorAll('.nav-link.active, .nav-dropdown-item.active').forEach(item => {
            item.classList.remove('active');
        });

        // Add active state to specified item
        const targetItem = document.querySelector(selector);
        if (targetItem) {
            targetItem.classList.add('active');
        }
    }

    // Public method to add notification badge
    addNotificationBadge(menuSelector, count) {
        const menuItem = document.querySelector(menuSelector);
        if (menuItem && count > 0) {
            // Remove existing badge
            const existingBadge = menuItem.querySelector('.nav-notification-badge');
            if (existingBadge) {
                existingBadge.remove();
            }

            // Create new badge
            const badge = document.createElement('span');
            badge.className = 'nav-notification-badge';
            badge.textContent = count > 99 ? '99+' : count;
            badge.style.cssText = `
                position: absolute;
                top: -5px;
                right: -5px;
                background: #ef4444;
                color: white;
                border-radius: 10px;
                padding: 2px 6px;
                font-size: 0.7rem;
                font-weight: bold;
                min-width: 18px;
                text-align: center;
                z-index: 10;
            `;
            
            menuItem.style.position = 'relative';
            menuItem.appendChild(badge);
        }
    }

    // Public method to remove notification badge
    removeNotificationBadge(menuSelector) {
        const menuItem = document.querySelector(menuSelector);
        if (menuItem) {
            const badge = menuItem.querySelector('.nav-notification-badge');
            if (badge) {
                badge.remove();
            }
        }
    }
}

// Utility functions
const NavigationUtils = {
    // Smooth scroll to element
    scrollToElement: function(selector, offset = 70) {
        const element = document.querySelector(selector);
        if (element) {
            const elementPosition = element.getBoundingClientRect().top + window.pageYOffset;
            const offsetPosition = elementPosition - offset;

            window.scrollTo({
                top: offsetPosition,
                behavior: 'smooth'
            });
        }
    },

    // Check if element is in viewport
    isInViewport: function(element) {
        const rect = element.getBoundingClientRect();
        return (
            rect.top >= 0 &&
            rect.left >= 0 &&
            rect.bottom <= (window.innerHeight || document.documentElement.clientHeight) &&
            rect.right <= (window.innerWidth || document.documentElement.clientWidth)
        );
    },

    // Get current page info
    getCurrentPageInfo: function() {
        return {
            url: window.location.href,
            pathname: window.location.pathname,
            search: window.location.search,
            hash: window.location.hash
        };
    }
};

// Initialize navigation when DOM is ready
document.addEventListener('DOMContentLoaded', function() {
    // Initialize modern navigation
    window.modernNav = new ModernNavigation();
    
    // Add any page-specific navigation enhancements here
    console.log('Modern Navigation System Initialized');
});

/**
 * Enhanced Multi-Level Menu Navigation System
 * Provides advanced dropdown handling and mobile responsiveness
 */
class EnhancedNavigationSystem {
    constructor() {
        this.activeDropdowns = new Set();
        this.mobileBreakpoint = 768;
        this.touchDevice = 'ontouchstart' in window;
        this.init();
    }

    init() {
        this.bindEvents();
        this.setupMobileMenu();
        this.setupKeyboardNavigation();
        this.setupTouchHandling();
    }

    bindEvents() {
        // Mobile menu toggle
        document.addEventListener('click', (e) => {
            if (e.target.matches('.saserp-mobile-nav-toggle, .saserp-mobile-nav-toggle *')) {
                this.toggleMobileMenu();
            }
        });

        // Dropdown toggles
        document.addEventListener('click', (e) => {
            const dropdownToggle = e.target.closest('.dropdown-toggle');
            if (dropdownToggle) {
                e.preventDefault();
                this.toggleDropdown(dropdownToggle);
            }
        });

        // Close dropdown buttons
        document.addEventListener('click', (e) => {
            if (e.target.matches('.dropdown-close')) {
                this.closeDropdown(e.target);
            }
        });

        // Close dropdowns when clicking outside
        document.addEventListener('click', (e) => {
            if (!e.target.closest('.nav-item.has-dropdown')) {
                this.closeAllDropdowns();
            }
        });

        // Handle window resize
        window.addEventListener('resize', () => {
            this.handleResize();
        });

        // Handle escape key
        document.addEventListener('keydown', (e) => {
            if (e.key === 'Escape') {
                this.closeAllDropdowns();
                this.closeMobileMenu();
            }
        });
    }

    toggleMobileMenu() {
        const navMenu = document.getElementById('navMenu') || document.querySelector('.nav-menu');
        const body = document.body;
        
        if (navMenu) {
            const isActive = navMenu.classList.contains('active');
            
            if (isActive) {
                this.closeMobileMenu();
            } else {
                this.openMobileMenu();
            }
        }
    }

    openMobileMenu() {
        const navMenu = document.getElementById('navMenu') || document.querySelector('.nav-menu');
        const body = document.body;
        
        if (navMenu) {
            navMenu.classList.add('active');
            body.classList.add('mobile-menu-open');
            
            // Add entrance animation to menu items
            const menuItems = navMenu.querySelectorAll('.nav-item');
            menuItems.forEach((item, index) => {
                item.style.animationDelay = `${index * 0.1}s`;
                item.classList.add('menu-item-enter');
            });
        }
    }

    closeMobileMenu() {
        const navMenu = document.getElementById('navMenu') || document.querySelector('.nav-menu');
        const body = document.body;
        
        if (navMenu) {
            navMenu.classList.remove('active');
            body.classList.remove('mobile-menu-open');
            
            // Remove animation classes
            const menuItems = navMenu.querySelectorAll('.nav-item');
            menuItems.forEach(item => {
                item.classList.remove('menu-item-enter');
                item.style.animationDelay = '';
            });
        }
    }

    toggleDropdown(toggleElement) {
        const parentItem = toggleElement.closest('.nav-item');
        const dropdown = parentItem?.querySelector('.nav-dropdown');
        
        if (!parentItem || !dropdown) return;

        const isOpen = parentItem.classList.contains('dropdown-open');
        
        if (isOpen) {
            this.closeDropdown(parentItem);
        } else {
            // Close other dropdowns first
            this.closeAllDropdowns();
            this.openDropdown(parentItem);
        }
    }

    openDropdown(parentItem) {
        const dropdown = parentItem.querySelector('.nav-dropdown');
        if (!dropdown) return;

        parentItem.classList.add('dropdown-open');
        this.activeDropdowns.add(parentItem);
        
        // Add entrance animation
        dropdown.classList.add('dropdown-enter');
        setTimeout(() => dropdown.classList.remove('dropdown-enter'), 300);
        
        // Adjust position if needed
        this.adjustDropdownPosition(dropdown);
        
        // Focus management for accessibility
        const firstFocusable = dropdown.querySelector('a, button, [tabindex]:not([tabindex="-1"])');
        if (firstFocusable && !this.isMobile()) {
            setTimeout(() => firstFocusable.focus(), 100);
        }
    }

    closeDropdown(element) {
        const parentItem = element.closest('.nav-item');
        if (!parentItem) return;

        parentItem.classList.remove('dropdown-open');
        this.activeDropdowns.delete(parentItem);
        
        const dropdown = parentItem.querySelector('.nav-dropdown');
        if (dropdown) {
            dropdown.classList.remove('dropdown-enter');
        }
    }

    closeAllDropdowns() {
        this.activeDropdowns.forEach(item => {
            item.classList.remove('dropdown-open');
            const dropdown = item.querySelector('.nav-dropdown');
            if (dropdown) {
                dropdown.classList.remove('dropdown-enter');
            }
        });
        this.activeDropdowns.clear();
    }

    adjustDropdownPosition(dropdown) {
        if (this.isMobile()) return;

        const rect = dropdown.getBoundingClientRect();
        const viewportWidth = window.innerWidth;
        const viewportHeight = window.innerHeight;
        
        // Adjust horizontal position
        if (rect.right > viewportWidth - 20) {
            dropdown.style.left = 'auto';
            dropdown.style.right = '0';
        }
        
        // Adjust vertical position
        if (rect.bottom > viewportHeight - 20) {
            dropdown.style.top = 'auto';
            dropdown.style.bottom = '100%';
        }
    }

    setupMobileMenu() {
        // Add mobile menu backdrop
        if (!document.querySelector('.mobile-menu-backdrop')) {
            const backdrop = document.createElement('div');
            backdrop.className = 'mobile-menu-backdrop';
            backdrop.style.cssText = `
                position: fixed;
                top: 0;
                left: 0;
                width: 100%;
                height: 100%;
                background: rgba(0, 0, 0, 0.5);
                z-index: 999;
                opacity: 0;
                visibility: hidden;
                transition: all 0.3s ease;
            `;
            
            backdrop.addEventListener('click', () => {
                this.closeMobileMenu();
            });
            
            document.body.appendChild(backdrop);
        }
    }

    setupKeyboardNavigation() {
        document.addEventListener('keydown', (e) => {
            const focusedElement = document.activeElement;
            const isInDropdown = focusedElement.closest('.nav-dropdown');
            const isNavLink = focusedElement.classList.contains('nav-link');
            
            switch (e.key) {
                case 'ArrowDown':
                    if (isNavLink) {
                        e.preventDefault();
                        this.navigateToNext(focusedElement, 'down');
                    }
                    break;
                    
                case 'ArrowUp':
                    if (isNavLink) {
                        e.preventDefault();
                        this.navigateToNext(focusedElement, 'up');
                    }
                    break;
                    
                case 'ArrowRight':
                    if (isNavLink && focusedElement.parentElement.querySelector('.nav-dropdown')) {
                        e.preventDefault();
                        this.openDropdownFromKeyboard(focusedElement);
                    }
                    break;
                    
                case 'ArrowLeft':
                    if (isInDropdown) {
                        e.preventDefault();
                        this.closeDropdownFromKeyboard(focusedElement);
                    }
                    break;
                    
                case 'Enter':
                case ' ':
                    if (isNavLink && focusedElement.classList.contains('dropdown-toggle')) {
                        e.preventDefault();
                        this.toggleDropdown(focusedElement);
                    }
                    break;
            }
        });
    }

    setupTouchHandling() {
        if (!this.touchDevice) return;

        let touchStartY = 0;
        let touchStartX = 0;
        
        document.addEventListener('touchstart', (e) => {
            touchStartY = e.touches[0].clientY;
            touchStartX = e.touches[0].clientX;
        }, { passive: true });
        
        document.addEventListener('touchend', (e) => {
            const touchEndY = e.changedTouches[0].clientY;
            const touchEndX = e.changedTouches[0].clientX;
            
            const deltaY = touchStartY - touchEndY;
            const deltaX = touchStartX - touchEndX;
            
            // Swipe to close mobile menu
            const navMenu = document.querySelector('.nav-menu.active');
            if (navMenu && Math.abs(deltaX) > Math.abs(deltaY) && deltaX > 50) {
                this.closeMobileMenu();
            }
        }, { passive: true });
    }

    navigateToNext(currentElement, direction) {
        const allNavLinks = Array.from(document.querySelectorAll('.nav-link'));
        const currentIndex = allNavLinks.indexOf(currentElement);
        
        let nextIndex;
        if (direction === 'down') {
            nextIndex = currentIndex + 1 >= allNavLinks.length ? 0 : currentIndex + 1;
        } else {
            nextIndex = currentIndex - 1 < 0 ? allNavLinks.length - 1 : currentIndex - 1;
        }
        
        allNavLinks[nextIndex]?.focus();
    }

    openDropdownFromKeyboard(navLink) {
        const parentItem = navLink.closest('.nav-item');
        if (parentItem) {
            this.openDropdown(parentItem);
        }
    }

    closeDropdownFromKeyboard(element) {
        const parentItem = element.closest('.nav-item.dropdown-open');
        if (parentItem) {
            this.closeDropdown(parentItem);
            const navLink = parentItem.querySelector('.nav-link');
            navLink?.focus();
        }
    }

    handleResize() {
        const wasMobile = this.wasMobile;
        this.wasMobile = this.isMobile();
        
        if (wasMobile !== this.wasMobile) {
            // Close all dropdowns and mobile menu when switching modes
            this.closeAllDropdowns();
            this.closeMobileMenu();
        }
        
        // Readjust dropdown positions
        this.activeDropdowns.forEach(item => {
            const dropdown = item.querySelector('.nav-dropdown');
            if (dropdown) {
                // Reset positions
                dropdown.style.left = '';
                dropdown.style.right = '';
                dropdown.style.top = '';
                dropdown.style.bottom = '';
                
                // Readjust
                this.adjustDropdownPosition(dropdown);
            }
        });
    }

    isMobile() {
        return window.innerWidth <= this.mobileBreakpoint;
    }

    // Public API methods
    static toggleNavMenu() {
        if (window.enhancedNav) {
            window.enhancedNav.toggleMobileMenu();
        }
    }

    static toggleDropdown(element) {
        if (window.enhancedNav) {
            window.enhancedNav.toggleDropdown(element);
        }
    }

    static closeDropdown(element) {
        if (window.enhancedNav) {
            window.enhancedNav.closeDropdown(element);
        }
    }
}

// Global functions for backward compatibility and direct usage
function toggleNavMenu() {
    EnhancedNavigationSystem.toggleNavMenu();
}

function toggleDropdown(element) {
    EnhancedNavigationSystem.toggleDropdown(element);
}

function closeDropdown(element) {
    EnhancedNavigationSystem.closeDropdown(element);
}

// Initialize enhanced navigation system
document.addEventListener('DOMContentLoaded', function() {
    if (!window.enhancedNav) {
        window.enhancedNav = new EnhancedNavigationSystem();
    }
});

// Export for use in other scripts
if (typeof module !== 'undefined' && module.exports) {
    module.exports = { ModernNavigation, NavigationUtils, EnhancedNavigationSystem };
}
