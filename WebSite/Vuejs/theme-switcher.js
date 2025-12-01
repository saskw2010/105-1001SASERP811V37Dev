/**
 * =====================================================
 * ADVANCED DYNAMIC THEME SYSTEM
 * نظام الثيمات الديناميكي المتقدم
 * =====================================================
 * Features:
 * - Multiple theme support
 * - Smooth transitions
 * - Local storage persistence
 * - Keyboard shortcuts
 * - System preference detection
 * - Performance optimized
 * =====================================================
 */

class AdvancedThemeSystem {
    constructor() {
        this.themes = {
            light: {
                name: 'Light',
                nameAr: 'فاتح',
                icon: '☀️',
                description: 'Clean light theme for day time use'
            },
            dark: {
                name: 'Dark',
                nameAr: 'داكن',
                icon: '🌙',
                description: 'Dark theme for comfortable night viewing'
            },
            ai: {
                name: 'AI',
                nameAr: 'ذكاء اصطناعي',
                icon: '🤖',
                description: 'Futuristic AI-inspired theme with gradients'
            },
            citrus: {
                name: 'Citrus',
                nameAr: 'حمضي',
                icon: '🍊',
                description: 'Warm orange-based theme'
            },
            emerald: {
                name: 'Emerald',
                nameAr: 'زمردي',
                icon: '💚',
                description: 'Fresh green nature-inspired theme'
            },
            rose: {
                name: 'Rose',
                nameAr: 'وردي',
                icon: '🌹',
                description: 'Elegant rose-pink theme'
            }
        };
        
        this.currentTheme = 'light';
        this.transitionDuration = 300;
        this.storageKey = 'advanced-theme-system';
        this.isTransitioning = false;
        
        this.init();
    }
    
    /**
     * Initialize the theme system
     */
    init() {
        this.loadSavedTheme();
        this.detectSystemPreference();
        this.createThemeSelector();
        this.bindKeyboardShortcuts();
        this.bindEvents();
        this.applyTheme(this.currentTheme, false);
        
        console.log('🎨 Advanced Theme System initialized');
    }
    
    /**
     * Load theme from local storage
     */
    loadSavedTheme() {
        try {
            const saved = localStorage.getItem(this.storageKey);
            if (saved && this.themes[saved]) {
                this.currentTheme = saved;
            }
        } catch (error) {
            console.warn('Failed to load saved theme:', error);
        }
    }
    
    /**
     * Detect system color scheme preference
     */
    detectSystemPreference() {
        if (!localStorage.getItem(this.storageKey)) {
            if (window.matchMedia && window.matchMedia('(prefers-color-scheme: dark)').matches) {
                this.currentTheme = 'dark';
            }
        }
        
        // Listen for system preference changes
        if (window.matchMedia) {
            window.matchMedia('(prefers-color-scheme: dark)').addEventListener('change', (e) => {
                if (!localStorage.getItem(this.storageKey)) {
                    this.setTheme(e.matches ? 'dark' : 'light');
                }
            });
        }
    }
    
    /**
     * Create theme selector UI (disabled when dropdown is active)
     */
    createThemeSelector() {
        // Check if dropdown theme controller is active
        if (window.themeDropdownController && window.themeDropdownController.dropdownContainer) {
            console.log('🎨 Theme dropdown is active, skipping floating selector');
            return;
        }
        
        // Remove existing selector if any
        const existing = document.querySelector('.theme-selector');
        if (existing) {
            existing.remove();
        }
        
        const selector = document.createElement('div');
        selector.className = 'theme-selector';
        selector.setAttribute('role', 'toolbar');
        selector.setAttribute('aria-label', 'Theme selector');
        
        Object.keys(this.themes).forEach(themeKey => {
            const theme = this.themes[themeKey];
            const button = document.createElement('button');
            button.className = 'theme-btn';
            button.setAttribute('data-theme', themeKey);
            button.setAttribute('aria-label', `Switch to ${theme.name} theme`);
            button.setAttribute('title', `${theme.icon} ${theme.name} - ${theme.description}`);
            button.textContent = theme.icon;
            
            if (themeKey === this.currentTheme) {
                button.classList.add('active');
            }
            
            button.addEventListener('click', () => this.setTheme(themeKey));
            selector.appendChild(button);
        });
        
        document.body.appendChild(selector);
    }
    
    /**
     * Bind keyboard shortcuts
     */
    bindKeyboardShortcuts() {
        document.addEventListener('keydown', (e) => {
            // Ctrl/Cmd + Shift + shortcuts
            if ((e.ctrlKey || e.metaKey) && e.shiftKey) {
                switch (e.key.toLowerCase()) {
                    case 'l':
                        e.preventDefault();
                        this.setTheme('light');
                        break;
                    case 'd':
                        e.preventDefault();
                        this.setTheme('dark');
                        break;
                    case 'a':
                        e.preventDefault();
                        this.setTheme('ai');
                        break;
                    case 't':
                        e.preventDefault();
                        this.toggleTheme();
                        break;
                }
            }
        });
    }
    
    /**
     * Bind additional events
     */
    bindEvents() {
        // Listen for custom theme change events
        document.addEventListener('themeChangeRequest', (e) => {
            if (e.detail && e.detail.theme) {
                this.setTheme(e.detail.theme);
            }
        });
        
        // Handle page visibility changes
        document.addEventListener('visibilitychange', () => {
            if (!document.hidden) {
                this.refreshTheme();
            }
        });
    }
    
    /**
     * Set a specific theme
     */
    setTheme(themeName, animate = true) {
        if (!this.themes[themeName] || this.isTransitioning || themeName === this.currentTheme) {
            return;
        }
        
        this.isTransitioning = true;
        const previousTheme = this.currentTheme;
        this.currentTheme = themeName;
        
        if (animate) {
            this.animateThemeTransition(previousTheme, themeName);
        } else {
            this.applyTheme(themeName, false);
        }
        
        this.saveTheme();
        this.updateThemeSelector();
        this.dispatchThemeEvent(themeName, previousTheme);
        
        setTimeout(() => {
            this.isTransitioning = false;
        }, this.transitionDuration);
    }
    
    /**
     * Toggle between themes
     */
    toggleTheme() {
        const themeKeys = Object.keys(this.themes);
        const currentIndex = themeKeys.indexOf(this.currentTheme);
        const nextIndex = (currentIndex + 1) % themeKeys.length;
        this.setTheme(themeKeys[nextIndex]);
    }
    
    /**
     * Apply theme styles
     */
    applyTheme(themeName, animate = true) {
        if (!this.themes[themeName]) return;
        
        const body = document.body;
        const html = document.documentElement;
        
        // Remove all theme classes
        Object.keys(this.themes).forEach(theme => {
            body.classList.remove(`theme-${theme}`);
            html.removeAttribute('data-theme');
        });
        
        // Add new theme
        body.classList.add(`theme-${themeName}`);
        html.setAttribute('data-theme', themeName);
        
        // Apply specific theme logic
        this.applyThemeSpecifics(themeName);
        
        if (animate) {
            body.classList.add('theme-transitioning');
            setTimeout(() => {
                body.classList.remove('theme-transitioning');
            }, this.transitionDuration);
        }
    }
    
    /**
     * Apply theme-specific effects
     */
    applyThemeSpecifics(themeName) {
        switch (themeName) {
            case 'ai':
                this.applyAIThemeEffects();
                break;
            case 'dark':
                this.applyDarkThemeEffects();
                break;
            case 'citrus':
                this.applyCitrusThemeEffects();
                break;
            // Add more theme-specific effects as needed
        }
    }
    
    /**
     * AI theme specific effects
     */
    applyAIThemeEffects() {
        // Add AI-specific animations and effects
        const cards = document.querySelectorAll('.card, .demo-card');
        cards.forEach(card => {
            card.style.setProperty('--hover-transform', 'translateY(-4px) scale(1.02)');
        });
        
        // Add gradient animations
        const buttons = document.querySelectorAll('button, .btn');
        buttons.forEach(btn => {
            btn.style.setProperty('background-size', '200% 200%');
        });
    }
    
    /**
     * Dark theme specific effects
     */
    applyDarkThemeEffects() {
        // Adjust shadows for dark theme
        const cards = document.querySelectorAll('.card, .demo-card');
        cards.forEach(card => {
            card.style.setProperty('--shadow-intensity', '0.3');
        });
    }
    
    /**
     * Citrus theme specific effects
     */
    applyCitrusThemeEffects() {
        // Add warm, energetic effects
        const body = document.body;
        body.style.setProperty('--energy-level', 'high');
    }
    
    /**
     * Animate theme transition
     */
    animateThemeTransition(fromTheme, toTheme) {
        const overlay = document.createElement('div');
        overlay.className = 'theme-transition-overlay';
        overlay.style.cssText = `
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: var(--primary-gradient);
            z-index: 9999;
            opacity: 0;
            transition: opacity ${this.transitionDuration / 2}ms ease-in-out;
            pointer-events: none;
        `;
        
        document.body.appendChild(overlay);
        
        // Fade in overlay
        requestAnimationFrame(() => {
            overlay.style.opacity = '0.8';
        });
        
        // Change theme at peak opacity
        setTimeout(() => {
            this.applyTheme(toTheme, false);
            
            // Fade out overlay
            overlay.style.opacity = '0';
            
            setTimeout(() => {
                document.body.removeChild(overlay);
            }, this.transitionDuration / 2);
            
        }, this.transitionDuration / 2);
    }
    
    /**
     * Update theme selector UI
     */
    updateThemeSelector() {
        const buttons = document.querySelectorAll('.theme-btn');
        buttons.forEach(btn => {
            btn.classList.remove('active');
            if (btn.getAttribute('data-theme') === this.currentTheme) {
                btn.classList.add('active');
            }
        });
    }
    
    /**
     * Save theme to local storage
     */
    saveTheme() {
        try {
            localStorage.setItem(this.storageKey, this.currentTheme);
            this.showSaveIndicator();
        } catch (error) {
            console.warn('Failed to save theme:', error);
        }
    }
    
    /**
     * Show save indicator
     */
    showSaveIndicator() {
        const indicator = document.createElement('div');
        indicator.className = 'theme-saved';
        indicator.textContent = `✅ Theme saved: ${this.themes[this.currentTheme].name}`;
        
        document.body.appendChild(indicator);
        
        setTimeout(() => {
            indicator.classList.add('show');
        }, 100);
        
        setTimeout(() => {
            indicator.classList.remove('show');
            setTimeout(() => {
                if (document.body.contains(indicator)) {
                    document.body.removeChild(indicator);
                }
            }, 300);
        }, 2000);
    }
    
    /**
     * Dispatch theme change event
     */
    dispatchThemeEvent(newTheme, previousTheme) {
        const event = new CustomEvent('themeChanged', {
            detail: {
                theme: newTheme,
                previousTheme: previousTheme,
                themeData: this.themes[newTheme]
            }
        });
        
        document.dispatchEvent(event);
        
        // Also dispatch on window for compatibility
        window.dispatchEvent(new CustomEvent('themeChanged', {
            detail: { theme: newTheme, previousTheme: previousTheme }
        }));
    }
    
    /**
     * Refresh current theme
     */
    refreshTheme() {
        this.applyTheme(this.currentTheme, false);
    }
    
    /**
     * Get current theme info
     */
    getCurrentTheme() {
        return {
            key: this.currentTheme,
            ...this.themes[this.currentTheme]
        };
    }
    
    /**
     * Get all available themes
     */
    getAvailableThemes() {
        return { ...this.themes };
    }
    
    /**
     * Check if theme exists
     */
    hasTheme(themeName) {
        return !!this.themes[themeName];
    }
    
    /**
     * Add custom theme
     */
    addTheme(key, themeData) {
        if (key && themeData && themeData.name) {
            this.themes[key] = {
                name: themeData.name,
                nameAr: themeData.nameAr || themeData.name,
                icon: themeData.icon || '🎨',
                description: themeData.description || 'Custom theme',
                ...themeData
            };
            
            // Recreate selector to include new theme
            this.createThemeSelector();
            
            return true;
        }
        return false;
    }
    
    /**
     * Remove custom theme
     */
    removeTheme(key) {
        if (key && this.themes[key] && key !== 'light' && key !== 'dark') {
            delete this.themes[key];
            
            if (this.currentTheme === key) {
                this.setTheme('light');
            }
            
            this.createThemeSelector();
            return true;
        }
        return false;
    }
    
    /**
     * Export theme settings
     */
    exportSettings() {
        return {
            currentTheme: this.currentTheme,
            customThemes: Object.keys(this.themes).filter(key => 
                !['light', 'dark', 'ai', 'citrus', 'emerald', 'rose'].includes(key)
            ).map(key => ({ key, ...this.themes[key] }))
        };
    }
    
    /**
     * Import theme settings
     */
    importSettings(settings) {
        try {
            if (settings.customThemes) {
                settings.customThemes.forEach(theme => {
                    this.addTheme(theme.key, theme);
                });
            }
            
            if (settings.currentTheme && this.themes[settings.currentTheme]) {
                this.setTheme(settings.currentTheme);
            }
            
            return true;
        } catch (error) {
            console.error('Failed to import theme settings:', error);
            return false;
        }
    }
}

// Initialize theme system when DOM is ready
document.addEventListener('DOMContentLoaded', function() {
    // Initialize theme system
    window.advancedThemeSystem = new AdvancedThemeSystem();
    
    // Expose to global scope for compatibility
    if (window.advancedSystem) {
        window.advancedSystem.themeController = window.advancedThemeSystem;
    } else {
        window.advancedSystem = {
            themeController: window.advancedThemeSystem
        };
    }
    
    console.log('🎨 Advanced Theme System ready!');
});

// Export for module systems
if (typeof module !== 'undefined' && module.exports) {
    module.exports = AdvancedThemeSystem;
}
