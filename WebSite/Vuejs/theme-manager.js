/**
 * =====================================================
 * THEME MANAGER - إدارة الثيمات المتقدمة
 * =====================================================
 * Advanced Theme Management System
 * - Theme creation and customization
 * - Import/Export themes
 * - Live preview
 * - Performance monitoring
 * - Analytics and usage tracking
 * =====================================================
 */

class ThemeManager {
    constructor() {
        this.version = '2.1.0';
        this.defaultThemes = [
            'light', 'dark', 'ai', 'citrus', 'emerald', 'rose'
        ];
        
        this.customThemes = new Map();
        this.themeHistory = [];
        this.analytics = {
            switchCount: 0,
            themeUsage: {},
            performanceMetrics: [],
            favoriteTheme: null
        };
        
        this.settings = {
            autoSave: true,
            animationsEnabled: true,
            systemPreferenceSync: true,
            analyticsEnabled: true,
            performanceMonitoring: true
        };
        
        this.init();
    }
    
    /**
     * Initialize Theme Manager
     */
    init() {
        this.loadSettings();
        this.loadCustomThemes();
        this.loadAnalytics();
        this.setupEventListeners();
        this.startPerformanceMonitoring();
        
        console.log('🎛️ Theme Manager v' + this.version + ' initialized');
    }
    
    /**
     * Load settings from storage
     */
    loadSettings() {
        try {
            const saved = localStorage.getItem('themeManager-settings');
            if (saved) {
                this.settings = { ...this.settings, ...JSON.parse(saved) };
            }
        } catch (error) {
            console.warn('Failed to load theme manager settings:', error);
        }
    }
    
    /**
     * Save settings to storage
     */
    saveSettings() {
        try {
            localStorage.setItem('themeManager-settings', JSON.stringify(this.settings));
        } catch (error) {
            console.error('Failed to save theme manager settings:', error);
        }
    }
    
    /**
     * Load custom themes
     */
    loadCustomThemes() {
        try {
            const saved = localStorage.getItem('themeManager-customThemes');
            if (saved) {
                const themes = JSON.parse(saved);
                Object.entries(themes).forEach(([key, theme]) => {
                    this.customThemes.set(key, theme);
                });
            }
        } catch (error) {
            console.warn('Failed to load custom themes:', error);
        }
    }
    
    /**
     * Save custom themes
     */
    saveCustomThemes() {
        try {
            const themes = Object.fromEntries(this.customThemes);
            localStorage.setItem('themeManager-customThemes', JSON.stringify(themes));
        } catch (error) {
            console.error('Failed to save custom themes:', error);
        }
    }
    
    /**
     * Load analytics data
     */
    loadAnalytics() {
        try {
            const saved = localStorage.getItem('themeManager-analytics');
            if (saved) {
                this.analytics = { ...this.analytics, ...JSON.parse(saved) };
            }
        } catch (error) {
            console.warn('Failed to load analytics:', error);
        }
    }
    
    /**
     * Save analytics data
     */
    saveAnalytics() {
        try {
            localStorage.setItem('themeManager-analytics', JSON.stringify(this.analytics));
        } catch (error) {
            console.error('Failed to save analytics:', error);
        }
    }
    
    /**
     * Setup event listeners
     */
    setupEventListeners() {
        // Listen for theme changes
        document.addEventListener('themeChanged', (e) => {
            this.recordThemeSwitch(e.detail.theme, e.detail.previousTheme);
        });
        
        // Listen for performance events
        document.addEventListener('themePerformance', (e) => {
            this.recordPerformanceMetric(e.detail);
        });
        
        // Auto-save on page unload
        window.addEventListener('beforeunload', () => {
            this.saveAll();
        });
    }
    
    /**
     * Record theme switch for analytics
     */
    recordThemeSwitch(newTheme, previousTheme) {
        if (!this.settings.analyticsEnabled) return;
        
        this.analytics.switchCount++;
        
        // Update theme usage
        if (!this.analytics.themeUsage[newTheme]) {
            this.analytics.themeUsage[newTheme] = 0;
        }
        this.analytics.themeUsage[newTheme]++;
        
        // Update favorite theme
        const mostUsed = Object.entries(this.analytics.themeUsage)
            .sort(([,a], [,b]) => b - a)[0];
        if (mostUsed) {
            this.analytics.favoriteTheme = mostUsed[0];
        }
        
        // Add to history
        this.themeHistory.push({
            from: previousTheme,
            to: newTheme,
            timestamp: Date.now()
        });
        
        // Keep history limited to last 100 switches
        if (this.themeHistory.length > 100) {
            this.themeHistory = this.themeHistory.slice(-100);
        }
        
        if (this.settings.autoSave) {
            this.saveAnalytics();
        }
    }
    
    /**
     * Record performance metric
     */
    recordPerformanceMetric(metric) {
        if (!this.settings.performanceMonitoring) return;
        
        this.analytics.performanceMetrics.push({
            ...metric,
            timestamp: Date.now()
        });
        
        // Keep only last 50 metrics
        if (this.analytics.performanceMetrics.length > 50) {
            this.analytics.performanceMetrics = this.analytics.performanceMetrics.slice(-50);
        }
        
        if (this.settings.autoSave) {
            this.saveAnalytics();
        }
    }
    
    /**
     * Create a custom theme
     */
    createCustomTheme(name, config) {
        if (!name || !config) return false;
        
        const themeKey = this.generateThemeKey(name);
        const theme = {
            name: name,
            key: themeKey,
            config: config,
            created: Date.now(),
            author: 'user',
            version: '1.0.0',
            isCustom: true
        };
        
        this.customThemes.set(themeKey, theme);
        
        if (this.settings.autoSave) {
            this.saveCustomThemes();
        }
        
        return themeKey;
    }
    
    /**
     * Generate unique theme key
     */
    generateThemeKey(name) {
        const base = name.toLowerCase()
            .replace(/[^a-z0-9]/g, '-')
            .replace(/-+/g, '-')
            .replace(/^-|-$/g, '');
        
        let key = base;
        let counter = 1;
        
        while (this.customThemes.has(key) || this.defaultThemes.includes(key)) {
            key = `${base}-${counter}`;
            counter++;
        }
        
        return key;
    }
    
    /**
     * Update custom theme
     */
    updateCustomTheme(key, config) {
        if (!this.customThemes.has(key)) return false;
        
        const theme = this.customThemes.get(key);
        theme.config = { ...theme.config, ...config };
        theme.modified = Date.now();
        
        this.customThemes.set(key, theme);
        
        if (this.settings.autoSave) {
            this.saveCustomThemes();
        }
        
        return true;
    }
    
    /**
     * Delete custom theme
     */
    deleteCustomTheme(key) {
        if (!this.customThemes.has(key)) return false;
        
        this.customThemes.delete(key);
        
        if (this.settings.autoSave) {
            this.saveCustomThemes();
        }
        
        return true;
    }
    
    /**
     * Export theme
     */
    exportTheme(key) {
        const theme = this.customThemes.get(key);
        if (!theme) return null;
        
        return {
            ...theme,
            exportedAt: Date.now(),
            exportVersion: this.version
        };
    }
    
    /**
     * Import theme
     */
    importTheme(themeData) {
        if (!themeData || !themeData.name || !themeData.config) {
            return { success: false, error: 'Invalid theme data' };
        }
        
        try {
            const key = this.createCustomTheme(themeData.name, themeData.config);
            return { success: true, key: key };
        } catch (error) {
            return { success: false, error: error.message };
        }
    }
    
    /**
     * Export all custom themes
     */
    exportAllThemes() {
        const themes = {};
        this.customThemes.forEach((theme, key) => {
            themes[key] = theme;
        });
        
        return {
            themes: themes,
            analytics: this.analytics,
            settings: this.settings,
            exportedAt: Date.now(),
            version: this.version
        };
    }
    
    /**
     * Import theme package
     */
    importThemePackage(packageData) {
        if (!packageData || !packageData.themes) {
            return { success: false, error: 'Invalid package data' };
        }
        
        try {
            const imported = [];
            
            Object.entries(packageData.themes).forEach(([key, theme]) => {
                const newKey = this.createCustomTheme(theme.name, theme.config);
                imported.push(newKey);
            });
            
            // Optionally import settings
            if (packageData.settings && confirm('Import settings as well?')) {
                this.settings = { ...this.settings, ...packageData.settings };
                this.saveSettings();
            }
            
            return { success: true, imported: imported };
        } catch (error) {
            return { success: false, error: error.message };
        }
    }
    
    /**
     * Get theme statistics
     */
    getStatistics() {
        return {
            totalSwitches: this.analytics.switchCount,
            themeUsage: { ...this.analytics.themeUsage },
            favoriteTheme: this.analytics.favoriteTheme,
            customThemeCount: this.customThemes.size,
            averagePerformance: this.calculateAveragePerformance(),
            recentHistory: this.themeHistory.slice(-10),
            lastSwitch: this.themeHistory[this.themeHistory.length - 1]
        };
    }
    
    /**
     * Calculate average performance
     */
    calculateAveragePerformance() {
        if (this.analytics.performanceMetrics.length === 0) return null;
        
        const sum = this.analytics.performanceMetrics
            .reduce((total, metric) => total + (metric.duration || 0), 0);
        
        return Math.round(sum / this.analytics.performanceMetrics.length);
    }
    
    /**
     * Get theme recommendations
     */
    getRecommendations() {
        const stats = this.getStatistics();
        const recommendations = [];
        
        // Time-based recommendations
        const hour = new Date().getHours();
        if (hour >= 20 || hour <= 6) {
            recommendations.push({
                type: 'time',
                theme: 'dark',
                reason: 'Dark theme is easier on the eyes during night time'
            });
        } else {
            recommendations.push({
                type: 'time',
                theme: 'light',
                reason: 'Light theme provides better visibility during day time'
            });
        }
        
        // Usage-based recommendations
        if (stats.favoriteTheme) {
            recommendations.push({
                type: 'usage',
                theme: stats.favoriteTheme,
                reason: `Your most used theme (${stats.themeUsage[stats.favoriteTheme]} times)`
            });
        }
        
        // Performance-based recommendations
        if (stats.averagePerformance && stats.averagePerformance > 500) {
            recommendations.push({
                type: 'performance',
                theme: 'light',
                reason: 'Light theme has better performance on your device'
            });
        }
        
        return recommendations;
    }
    
    /**
     * Start performance monitoring
     */
    startPerformanceMonitoring() {
        if (!this.settings.performanceMonitoring) return;
        
        let lastTime = performance.now();
        
        const monitor = () => {
            const currentTime = performance.now();
            const deltaTime = currentTime - lastTime;
            
            // Monitor frame rate
            if (deltaTime > 16.67) { // More than 60 FPS
                this.recordPerformanceMetric({
                    type: 'frame',
                    duration: deltaTime,
                    fps: 1000 / deltaTime
                });
            }
            
            lastTime = currentTime;
            requestAnimationFrame(monitor);
        };
        
        requestAnimationFrame(monitor);
    }
    
    /**
     * Generate CSS for custom theme
     */
    generateCustomThemeCSS(config) {
        let css = ':root {\n';
        
        Object.entries(config).forEach(([property, value]) => {
            if (property.startsWith('--')) {
                css += `  ${property}: ${value};\n`;
            } else {
                css += `  --${property}: ${value};\n`;
            }
        });
        
        css += '}\n';
        return css;
    }
    
    /**
     * Apply custom theme temporarily
     */
    previewCustomTheme(config) {
        const css = this.generateCustomThemeCSS(config);
        
        // Remove existing preview
        const existing = document.getElementById('theme-preview-style');
        if (existing) {
            existing.remove();
        }
        
        // Add new preview
        const style = document.createElement('style');
        style.id = 'theme-preview-style';
        style.textContent = css;
        document.head.appendChild(style);
        
        return true;
    }
    
    /**
     * Clear theme preview
     */
    clearPreview() {
        const existing = document.getElementById('theme-preview-style');
        if (existing) {
            existing.remove();
            return true;
        }
        return false;
    }
    
    /**
     * Get theme color palette
     */
    getThemePalette(themeName) {
        const element = document.documentElement;
        const computedStyle = getComputedStyle(element);
        
        const properties = [
            '--primary', '--secondary', '--accent',
            '--success', '--warning', '--danger', '--info',
            '--bg-primary', '--bg-secondary', '--bg-tertiary',
            '--text-primary', '--text-secondary', '--text-muted'
        ];
        
        const palette = {};
        properties.forEach(prop => {
            palette[prop] = computedStyle.getPropertyValue(prop).trim();
        });
        
        return palette;
    }
    
    /**
     * Validate theme configuration
     */
    validateThemeConfig(config) {
        const errors = [];
        const warnings = [];
        
        const requiredProperties = [
            '--primary', '--bg-primary', '--text-primary'
        ];
        
        requiredProperties.forEach(prop => {
            if (!config[prop] && !config[prop.substring(2)]) {
                errors.push(`Missing required property: ${prop}`);
            }
        });
        
        // Check color format
        Object.entries(config).forEach(([prop, value]) => {
            if (typeof value === 'string' && value.startsWith('#')) {
                if (!/^#[0-9A-Fa-f]{6}$/.test(value) && !/^#[0-9A-Fa-f]{3}$/.test(value)) {
                    warnings.push(`Invalid color format for ${prop}: ${value}`);
                }
            }
        });
        
        return { valid: errors.length === 0, errors, warnings };
    }
    
    /**
     * Save all data
     */
    saveAll() {
        this.saveSettings();
        this.saveCustomThemes();
        this.saveAnalytics();
    }
    
    /**
     * Reset all data
     */
    resetAll() {
        if (confirm('هل أنت متأكد من حذف جميع البيانات؟ هذا الإجراء لا يمكن التراجع عنه.')) {
            this.customThemes.clear();
            this.themeHistory = [];
            this.analytics = {
                switchCount: 0,
                themeUsage: {},
                performanceMetrics: [],
                favoriteTheme: null
            };
            
            localStorage.removeItem('themeManager-settings');
            localStorage.removeItem('themeManager-customThemes');
            localStorage.removeItem('themeManager-analytics');
            
            return true;
        }
        return false;
    }
    
    /**
     * Get manager info
     */
    getInfo() {
        return {
            version: this.version,
            customThemeCount: this.customThemes.size,
            totalSwitches: this.analytics.switchCount,
            settings: { ...this.settings },
            memoryUsage: this.calculateMemoryUsage()
        };
    }
    
    /**
     * Calculate approximate memory usage
     */
    calculateMemoryUsage() {
        const data = {
            customThemes: Object.fromEntries(this.customThemes),
            analytics: this.analytics,
            settings: this.settings,
            history: this.themeHistory
        };
        
        return new Blob([JSON.stringify(data)]).size;
    }
}

// Initialize Theme Manager when DOM is ready
document.addEventListener('DOMContentLoaded', function() {
    // Create global theme manager instance
    window.themeManager = new ThemeManager();
    
    // Integrate with existing theme system
    if (window.advancedSystem && window.advancedSystem.themeController) {
        window.advancedSystem.themeManager = window.themeManager;
    }
    
    console.log('🎛️ Theme Manager ready!');
});

// Export for module systems
if (typeof module !== 'undefined' && module.exports) {
    module.exports = ThemeManager;
}
