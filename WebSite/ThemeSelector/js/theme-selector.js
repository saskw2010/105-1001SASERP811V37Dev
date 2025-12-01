/**
 * 🎨 Theme Selector JavaScript Controller
 * SASERP Physical Theme System
 * Created: 2025-08-07
 */

class ThemeSelector {
    constructor() {
        this.themes = {};
        this.categories = {};
        this.selectedTheme = null;
        this.currentTheme = localStorage.getItem('saserp_selected_theme') || 'citrus';
        
        // DOM Elements
        this.elementsCache = {};
        
        // Configuration
        this.config = {
            dataUrl: 'data/themes-config.json',
            physicalPath: '../css/themes-physical/',
            targetCss: '../css/stylesheet.css',
            localStorageKey: 'saserp_selected_theme'
        };
    }

    /**
     * Initialize the theme selector
     */
    async init() {
        console.log('🎨 Initializing Theme Selector...');
        
        try {
            // Cache DOM elements
            this.cacheElements();
            
            // Load themes configuration
            await this.loadThemesConfig();
            
            // Setup event listeners
            this.setupEventListeners();
            
            // Render themes
            this.renderThemes();
            
            // Update current theme display
            this.updateCurrentThemeDisplay();
            
            console.log('✅ Theme Selector initialized successfully');
        } catch (error) {
            console.error('❌ Error initializing Theme Selector:', error);
        }
    }

    /**
     * Cache frequently used DOM elements
     */
    cacheElements() {
        this.elementsCache = {
            themesGrid: document.getElementById('themesGrid'),
            categoryTabs: document.querySelectorAll('.category-tab'),
            currentThemeName: document.getElementById('currentThemeName'),
            applyBtn: document.getElementById('applyThemeBtn'),
            previewBtn: document.getElementById('previewBtn'),
            resetBtn: document.getElementById('resetBtn'),
            successMessage: document.getElementById('successMessage'),
            successText: document.getElementById('successText'),
            previewDemo: document.getElementById('previewDemo')
        };
    }

    /**
     * Load themes configuration from JSON
     */
    async loadThemesConfig() {
        try {
            const response = await fetch(this.config.dataUrl);
            const config = await response.json();
            
            this.themes = config.themes;
            this.categories = config.categories;
            
            console.log(`📚 Loaded ${Object.keys(this.themes).length} themes`);
        } catch (error) {
            console.error('❌ Error loading themes config:', error);
            throw error;
        }
    }

    /**
     * Setup event listeners
     */
    setupEventListeners() {
        // Category tabs
        this.elementsCache.categoryTabs.forEach(tab => {
            tab.addEventListener('click', (e) => {
                this.switchCategory(e.target.dataset.category);
            });
        });

        // Apply theme button
        this.elementsCache.applyBtn.addEventListener('click', () => {
            this.applyTheme();
        });

        // Preview button
        this.elementsCache.previewBtn.addEventListener('click', () => {
            this.previewTheme();
        });

        // Reset button
        this.elementsCache.resetBtn.addEventListener('click', () => {
            this.resetToDefault();
        });
    }

    /**
     * Render themes grid
     */
    renderThemes(category = 'all') {
        const grid = this.elementsCache.themesGrid;
        grid.innerHTML = '';

        Object.values(this.themes).forEach(theme => {
            if (category === 'all' || theme.category === category) {
                const themeCard = this.createThemeCard(theme);
                grid.appendChild(themeCard);
            }
        });
    }

    /**
     * Create a theme card element
     */
    createThemeCard(theme) {
        const card = document.createElement('div');
        card.className = `theme-card ${theme.id === this.currentTheme ? 'selected' : ''}`;
        card.dataset.themeId = theme.id;

        // Create color swatches
        const colorSwatches = Object.values(theme.colors)
            .slice(0, 5)
            .map(color => `<div class="color-swatch" style="background-color: ${color}"></div>`)
            .join('');

        card.innerHTML = `
            <div class="theme-preview">
                <div class="theme-preview-bg" style="background: linear-gradient(135deg, ${theme.colors.primary}, ${theme.colors.secondary})">
                    ${theme.isPremium ? '<i class="fas fa-crown"></i>' : '<i class="fas fa-palette"></i>'}
                </div>
                <div class="theme-colors">
                    ${colorSwatches}
                </div>
            </div>
            <div class="theme-info">
                <h3 class="theme-name">${theme.name}</h3>
                <p class="theme-description">${theme.description}</p>
                <span class="theme-category ${theme.isPremium ? 'premium' : ''}">${theme.isPremium ? 'مميز' : this.categories[theme.category]?.name || theme.category}</span>
            </div>
        `;

        // Add click event
        card.addEventListener('click', () => {
            this.selectTheme(theme.id);
        });

        return card;
    }

    /**
     * Switch category tab
     */
    switchCategory(category) {
        // Update active tab
        this.elementsCache.categoryTabs.forEach(tab => {
            tab.classList.toggle('active', tab.dataset.category === category);
        });

        // Render themes for category
        this.renderThemes(category);
    }

    /**
     * Select a theme
     */
    selectTheme(themeId) {
        // Remove previous selection
        document.querySelectorAll('.theme-card').forEach(card => {
            card.classList.remove('selected');
        });

        // Add selection to clicked card
        const selectedCard = document.querySelector(`[data-theme-id="${themeId}"]`);
        if (selectedCard) {
            selectedCard.classList.add('selected');
        }

        this.selectedTheme = themeId;
        
        // Enable action buttons
        this.elementsCache.applyBtn.disabled = false;
        this.elementsCache.previewBtn.disabled = false;

        // Update preview
        this.updatePreview(themeId);

        console.log(`🎯 Theme selected: ${this.themes[themeId].name}`);
    }

    /**
     * Update preview with selected theme
     */
    updatePreview(themeId) {
        const theme = this.themes[themeId];
        if (!theme) return;

        const demo = this.elementsCache.previewDemo;
        
        // Apply theme colors to preview elements
        const demoHeader = demo.querySelector('#demoHeader');
        const demoCard = demo.querySelector('#demoCard');
        const demoButton = demo.querySelector('#demoButton');
        const demoTable = demo.querySelector('#demoTable');

        if (demoHeader) {
            demoHeader.style.background = `linear-gradient(135deg, ${theme.colors.primary}, ${theme.colors.secondary})`;
            demoHeader.style.color = '#ffffff';
        }

        if (demoCard) {
            demoCard.style.background = theme.colors.surface;
            demoCard.style.color = theme.colors.text;
            demoCard.style.border = `1px solid ${theme.colors.primary}`;
        }

        if (demoButton) {
            const btn = demoButton.querySelector('button');
            if (btn) {
                btn.style.background = theme.colors.primary;
                btn.style.borderColor = theme.colors.primary;
            }
        }

        if (demoTable) {
            demoTable.style.background = theme.colors.surface;
            demoTable.style.color = theme.colors.text;
            demoTable.style.border = `1px solid ${theme.colors.primary}`;
        }
    }

    /**
     * Apply selected theme permanently
     */
    async applyTheme() {
        if (!this.selectedTheme) {
            this.showMessage('يرجى اختيار ثيم أولاً', 'error');
            return;
        }

        try {
            // Show loading state
            this.elementsCache.applyBtn.classList.add('loading');
            this.elementsCache.applyBtn.disabled = true;

            // Copy theme CSS to stylesheet.css
            await this.copyThemeToStylesheet(this.selectedTheme);

            // Save to localStorage
            localStorage.setItem(this.config.localStorageKey, this.selectedTheme);
            this.currentTheme = this.selectedTheme;

            // Update current theme display
            this.updateCurrentThemeDisplay();

            // Show success message
            this.showMessage(`تم تطبيق ثيم ${this.themes[this.selectedTheme].name} بنجاح!`, 'success');

            console.log(`✅ Theme applied: ${this.themes[this.selectedTheme].name}`);

        } catch (error) {
            console.error('❌ Error applying theme:', error);
            this.showMessage('حدث خطأ في تطبيق الثيم', 'error');
        } finally {
            // Remove loading state
            this.elementsCache.applyBtn.classList.remove('loading');
            this.elementsCache.applyBtn.disabled = false;
        }
    }

    /**
     * Copy theme CSS to stylesheet.css via server-side handler
     */
    async copyThemeToStylesheet(themeId) {
        const theme = this.themes[themeId];
        
        try {
            const response = await fetch('../Handlers/ThemeApplier.ashx', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({
                    ThemeId: themeId,
                    UserId: null, // Could be populated from session
                    Force: false
                })
            });

            const result = await response.json();

            if (!response.ok || !result.Success) {
                throw new Error(result.Message || 'Server error occurred');
            }

            console.log(`📄 Theme CSS applied successfully: ${theme.cssFile} → stylesheet.css`);
            return result;

        } catch (error) {
            console.error('❌ Error applying theme on server:', error);
            throw error;
        }
    }

    /**
     * Preview theme temporarily
     */
    previewTheme() {
        if (!this.selectedTheme) return;

        // For preview, we could temporarily inject CSS
        // This is a simplified implementation
        this.showMessage(`معاينة ثيم ${this.themes[this.selectedTheme].name}`, 'info');
    }

    /**
     * Reset to default theme
     */
    async resetToDefault() {
        try {
            const defaultTheme = 'citrus';
            
            // Apply default theme
            await this.copyThemeToStylesheet(defaultTheme);
            
            // Update localStorage
            localStorage.setItem(this.config.localStorageKey, defaultTheme);
            this.currentTheme = defaultTheme;
            
            // Update display
            this.updateCurrentThemeDisplay();
            
            // Re-render themes
            this.renderThemes();
            
            this.showMessage('تم استعادة الثيم الافتراضي', 'success');
            
        } catch (error) {
            console.error('❌ Error resetting theme:', error);
            this.showMessage('حدث خطأ في استعادة الثيم', 'error');
        }
    }

    /**
     * Update current theme display
     */
    updateCurrentThemeDisplay() {
        const currentTheme = this.themes[this.currentTheme];
        if (currentTheme && this.elementsCache.currentThemeName) {
            this.elementsCache.currentThemeName.textContent = currentTheme.name;
        }
    }

    /**
     * Show success/error message
     */
    showMessage(text, type = 'success') {
        const message = this.elementsCache.successMessage;
        const textElement = this.elementsCache.successText;
        
        if (textElement) {
            textElement.textContent = text;
        }
        
        // Update message type styling
        message.className = `success-message ${type}`;
        
        // Show message
        message.classList.add('show');
        
        // Hide after 3 seconds
        setTimeout(() => {
            message.classList.remove('show');
        }, 3000);
    }
}

// Create global instance
window.ThemeSelector = new ThemeSelector();

// Auto-initialize if DOM is already loaded
if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', () => {
        window.ThemeSelector.init();
    });
} else {
    window.ThemeSelector.init();
}
