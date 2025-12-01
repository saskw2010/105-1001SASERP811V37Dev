/**
 * =====================================================
 * THEME DROPDOWN CONTROLLER
 * نظام التحكم في قائمة الثيمات المنسدلة
 * =====================================================
 * Features:
 * - Clean dropdown interface
 * - Integrates with existing theme system
 * - No conflicts with main menu
 * - Mobile responsive
 * =====================================================
 */

class ThemeDropdownController {
    constructor() {
        this.isOpen = false;
        this.selectedTheme = 'light';
        this.dropdownContainer = null;
        this.dropdownToggle = null;
        this.dropdownMenu = null;
        
        // Get reference to existing theme system if available
        this.themeSystem = window.advancedThemeSystem || null;
        
        this.init();
    }
    
    /**
     * Initialize the dropdown controller
     */
    init() {
        this.loadCurrentTheme();
        this.createDropdownHTML();
        this.bindEvents();
        this.updateDropdownState();
        
        console.log('🎨 Theme Dropdown Controller initialized');
    }
    
    /**
     * Load current theme from existing system or localStorage
     */
    loadCurrentTheme() {
        if (this.themeSystem) {
            this.selectedTheme = this.themeSystem.currentTheme;
        } else {
            this.selectedTheme = localStorage.getItem('advanced-theme-system') || 'light';
        }
    }
    
    /**
     * Create the dropdown HTML structure
     */
    createDropdownHTML() {
        // Find the language selector or header actions area
        const headerActions = document.querySelector('.header-actions') || 
                            document.querySelector('.language-selector')?.parentNode ||
                            document.querySelector('#PageHeader .toolbar') ||
                            document.querySelector('#PageHeader');
        
        if (!headerActions) {
            console.warn('Could not find header actions area for theme dropdown');
            return;
        }
        
        // Create dropdown container
        const dropdownHTML = `
            <div class="theme-dropdown-container" style="display: none;">
                <button class="theme-dropdown-toggle" type="button" aria-label="اختيار الثيم">
                    <span class="theme-current-icon">${this.getThemeIcon(this.selectedTheme)}</span>
                    <span class="theme-current-name">${this.getThemeName(this.selectedTheme)}</span>
                    <i class="theme-dropdown-icon fas fa-chevron-down"></i>
                </button>
                
                <div class="theme-dropdown-menu">
                    <div class="theme-dropdown-header">
                        <h3 class="theme-dropdown-title">اختيار الثيم</h3>
                        <p class="theme-dropdown-subtitle">اختر الثيم المناسب لك</p>
                    </div>
                    
                    <div class="theme-options-grid">
                        ${this.generateThemeOptions()}
                    </div>
                    
                    <div class="theme-dropdown-footer">
                        <p class="theme-dropdown-footer-text">
                            <i class="fas fa-info-circle"></i>
                            يتم حفظ اختيارك تلقائياً
                        </p>
                    </div>
                </div>
            </div>
        `;
        
        // Insert dropdown into header
        headerActions.insertAdjacentHTML('beforeend', dropdownHTML);
        
        // Get references
        this.dropdownContainer = headerActions.querySelector('.theme-dropdown-container');
        this.dropdownToggle = this.dropdownContainer.querySelector('.theme-dropdown-toggle');
        this.dropdownMenu = this.dropdownContainer.querySelector('.theme-dropdown-menu');
    }
    
    /**
     * Generate theme options HTML
     */
    generateThemeOptions() {
        const themes = {
            light: { name: 'فاتح', nameEn: 'Light', icon: '☀️', desc: 'للاستخدام النهاري' },
            dark: { name: 'داكن', nameEn: 'Dark', icon: '🌙', desc: 'للاستخدام الليلي' },
            ai: { name: 'ذكي', nameEn: 'AI', icon: '🤖', desc: 'ثيم ذكي متقدم' },
            citrus: { name: 'حمضي', nameEn: 'Citrus', icon: '🍊', desc: 'ثيم برتقالي دافئ' },
            emerald: { name: 'زمردي', nameEn: 'Emerald', icon: '💚', desc: 'ثيم أخضر طبيعي' },
            rose: { name: 'وردي', nameEn: 'Rose', icon: '🌹', desc: 'ثيم وردي أنيق' }
        };
        
        return Object.keys(themes).map(themeKey => {
            const theme = themes[themeKey];
            const isActive = themeKey === this.selectedTheme ? 'active' : '';
            
            return `
                <button class="theme-option ${isActive}" 
                        data-theme="${themeKey}" 
                        type="button"
                        aria-label="تطبيق ثيم ${theme.name}">
                    <span class="theme-option-icon">${theme.icon}</span>
                    <div class="theme-option-info">
                        <div class="theme-option-name">${theme.name}</div>
                        <div class="theme-option-desc">${theme.desc}</div>
                    </div>
                </button>
            `;
        }).join('');
    }
    
    /**
     * Bind event listeners
     */
    bindEvents() {
        if (!this.dropdownToggle || !this.dropdownMenu) return;
        
        // Toggle dropdown
        this.dropdownToggle.addEventListener('click', (e) => {
            e.stopPropagation();
            this.toggleDropdown();
        });
        
        // Theme option clicks
        this.dropdownMenu.addEventListener('click', (e) => {
            const themeOption = e.target.closest('.theme-option');
            if (themeOption) {
                e.stopPropagation();
                const themeName = themeOption.dataset.theme;
                this.selectTheme(themeName);
            }
        });
        
        // Close dropdown when clicking outside
        document.addEventListener('click', (e) => {
            if (!this.dropdownContainer.contains(e.target)) {
                this.closeDropdown();
            }
        });
        
        // Close dropdown on escape key
        document.addEventListener('keydown', (e) => {
            if (e.key === 'Escape' && this.isOpen) {
                this.closeDropdown();
            }
        });
        
        // Listen to theme changes from other sources
        document.addEventListener('themeChanged', (e) => {
            if (e.detail && e.detail.theme) {
                this.selectedTheme = e.detail.theme;
                this.updateDropdownState();
            }
        });
    }
    
    /**
     * Toggle dropdown open/close
     */
    toggleDropdown() {
        if (this.isOpen) {
            this.closeDropdown();
        } else {
            this.openDropdown();
        }
    }
    
    /**
     * Open dropdown
     */
    openDropdown() {
        this.isOpen = true;
        this.dropdownToggle.classList.add('active');
        this.dropdownMenu.classList.add('show');
        
        // Update aria attributes
        this.dropdownToggle.setAttribute('aria-expanded', 'true');
        
        // Focus first theme option for accessibility
        const firstOption = this.dropdownMenu.querySelector('.theme-option');
        if (firstOption) {
            firstOption.focus();
        }
    }
    
    /**
     * Close dropdown
     */
    closeDropdown() {
        this.isOpen = false;
        this.dropdownToggle.classList.remove('active');
        this.dropdownMenu.classList.remove('show');
        
        // Update aria attributes
        this.dropdownToggle.setAttribute('aria-expanded', 'false');
    }
    
    /**
     * Select a theme
     */
    selectTheme(themeName) {
        this.selectedTheme = themeName;
        
        // Apply theme using existing system if available
        if (this.themeSystem) {
            this.themeSystem.setTheme(themeName);
        } else {
            // Fallback: save to localStorage and dispatch event
            localStorage.setItem('advanced-theme-system', themeName);
            this.applyThemeDirectly(themeName);
        }
        
        this.updateDropdownState();
        this.closeDropdown();
        
        // Show confirmation message
        this.showThemeChangeConfirmation(themeName);
    }
    
    /**
     * Apply theme directly if no theme system is available
     */
    applyThemeDirectly(themeName) {
        // Remove all existing theme classes
        const themes = ['light', 'dark', 'ai', 'citrus', 'emerald', 'rose'];
        themes.forEach(theme => {
            document.body.classList.remove(`theme-${theme}`);
        });
        
        // Add new theme class
        document.body.classList.add(`theme-${themeName}`);
        document.documentElement.setAttribute('data-theme', themeName);
        
        // Dispatch custom event
        const event = new CustomEvent('themeChanged', {
            detail: { theme: themeName, source: 'dropdown' }
        });
        document.dispatchEvent(event);
    }
    
    /**
     * Update dropdown state
     */
    updateDropdownState() {
        if (!this.dropdownToggle) return;
        
        // Update toggle button
        const currentIcon = this.dropdownToggle.querySelector('.theme-current-icon');
        const currentName = this.dropdownToggle.querySelector('.theme-current-name');
        
        if (currentIcon) currentIcon.textContent = this.getThemeIcon(this.selectedTheme);
        if (currentName) currentName.textContent = this.getThemeName(this.selectedTheme);
        
        // Update active option
        const options = this.dropdownMenu.querySelectorAll('.theme-option');
        options.forEach(option => {
            option.classList.toggle('active', option.dataset.theme === this.selectedTheme);
        });
    }
    
    /**
     * Get theme icon
     */
    getThemeIcon(themeName) {
        const icons = {
            light: '☀️',
            dark: '🌙',
            ai: '🤖',
            citrus: '🍊',
            emerald: '💚',
            rose: '🌹'
        };
        return icons[themeName] || '🎨';
    }
    
    /**
     * Get theme name
     */
    getThemeName(themeName) {
        const names = {
            light: 'فاتح',
            dark: 'داكن',
            ai: 'ذكي',
            citrus: 'حمضي',
            emerald: 'زمردي',
            rose: 'وردي'
        };
        return names[themeName] || 'مخصص';
    }
    
    /**
     * Show theme change confirmation
     */
    showThemeChangeConfirmation(themeName) {
        // Create temporary notification
        const notification = document.createElement('div');
        notification.className = 'theme-change-notification';
        notification.innerHTML = `
            <i class="fas fa-check-circle"></i>
            <span>تم تطبيق ثيم "${this.getThemeName(themeName)}" بنجاح</span>
        `;
        
        // Add styles
        Object.assign(notification.style, {
            position: 'fixed',
            top: '20px',
            right: '20px',
            background: 'var(--success-color, #10b981)',
            color: 'white',
            padding: '12px 16px',
            borderRadius: '8px',
            boxShadow: '0 4px 12px rgba(0, 0, 0, 0.15)',
            zIndex: '9999',
            display: 'flex',
            alignItems: 'center',
            gap: '8px',
            fontSize: '14px',
            fontWeight: '500',
            transform: 'translateX(100%)',
            transition: 'transform 0.3s ease'
        });
        
        document.body.appendChild(notification);
        
        // Animate in
        setTimeout(() => {
            notification.style.transform = 'translateX(0)';
        }, 100);
        
        // Remove after delay
        setTimeout(() => {
            notification.style.transform = 'translateX(100%)';
            setTimeout(() => {
                if (notification.parentNode) {
                    notification.parentNode.removeChild(notification);
                }
            }, 300);
        }, 2000);
    }
    
    /**
     * Enable the dropdown (call this when ready to activate)
     */
    enable() {
        if (this.dropdownContainer) {
            this.dropdownContainer.style.display = 'inline-block';
        }
    }
    
    /**
     * Disable the dropdown
     */
    disable() {
        if (this.dropdownContainer) {
            this.dropdownContainer.style.display = 'none';
        }
        this.closeDropdown();
    }
    
    /**
     * Destroy the dropdown
     */
    destroy() {
        if (this.dropdownContainer) {
            this.dropdownContainer.remove();
        }
        this.dropdownContainer = null;
        this.dropdownToggle = null;
        this.dropdownMenu = null;
    }
}

// Initialize when DOM is ready
document.addEventListener('DOMContentLoaded', function() {
    // Create theme dropdown controller but don't enable it yet
    window.themeDropdownController = new ThemeDropdownController();
    
    // Add to global scope for compatibility
    if (window.advancedSystem) {
        window.advancedSystem.themeDropdown = window.themeDropdownController;
    } else {
        window.advancedSystem = {
            themeDropdown: window.themeDropdownController
        };
    }
    
    console.log('🎨 Theme Dropdown ready! (Use themeDropdownController.enable() to activate)');
});

// Export for module systems
if (typeof module !== 'undefined' && module.exports) {
    module.exports = ThemeDropdownController;
}
