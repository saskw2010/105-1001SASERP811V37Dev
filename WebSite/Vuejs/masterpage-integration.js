/**
 * 🔗 Master Page Integration Script
 * تكامل Vue.js Framework مع Master Pages الموجودة
 * Integration with existing ASP.NET Master Pages
 */

// Master Page Integration System
const MasterPageIntegration = {
    version: '1.0.0',
    
    // Initialize integration when DOM is ready
    init() {
        console.log('🔗 Starting Master Page Integration...');
        
        this.detectMasterPage();
        this.integrateVueFramework();
        this.setupNavigationEnhancements();
        this.initializeResponsiveBehavior();
        this.setupLegacyCompatibility();
        
        console.log('✅ Master Page Integration Complete');
    },
    
    /**
     * Detect current master page type
     */
    detectMasterPage() {
        const masterTypes = [
            { selector: '.main-master', type: 'MainMaster', priority: 1 },
            { selector: '[class*="ModernMaster"]', type: 'ModernMaster', priority: 2 },
            { selector: '.PageMenuBar', type: 'ClassicMenuBar', priority: 3 },
            { selector: 'form[id*="form"]', type: 'DefaultMaster', priority: 4 }
        ];
        
        let detectedMaster = null;
        let highestPriority = 999;
        
        masterTypes.forEach(master => {
            if (document.querySelector(master.selector) && master.priority < highestPriority) {
                detectedMaster = master;
                highestPriority = master.priority;
            }
        });
        
        this.currentMaster = detectedMaster;
        console.log(`🎯 Detected Master Page: ${detectedMaster ? detectedMaster.type : 'Unknown'}`);
        
        return detectedMaster;
    },
    
    /**
     * Integrate Vue.js Framework with existing master page
     */
    integrateVueFramework() {
        if (!this.currentMaster) return;
        
        switch (this.currentMaster.type) {
            case 'MainMaster':
                this.integrateWithMainMaster();
                break;
            case 'ModernMaster':
                this.integrateWithModernMaster();
                break;
            case 'ClassicMenuBar':
                this.integrateWithClassicMenuBar();
                break;
            default:
                this.integrateWithDefaultMaster();
        }
    },
    
    /**
     * Integration with Main Master
     */
    integrateWithMainMaster() {
        console.log('🚀 Integrating with Main Master...');
        
        // Find navigation container
        const navContainer = document.querySelector('.main-master .main-master-navigation-container');
        const toggleButton = document.querySelector('.main-master .main-master-mobile-toggle');
        
        if (navContainer && toggleButton) {
            // Replace existing mobile functionality with Vue.js
            toggleButton.onclick = () => {
                if (window.mainmaster && window.mainmaster.menubar) {
                    window.mainmaster.menubar.mobilefunction();
                }
            };
            
            console.log('✅ Main Master navigation enhanced with Vue.js');
        }
        
        // Add Vue components containers
        this.addVueContainers('main-master');
    },
    
    /**
     * Integration with Modern Master
     */
    integrateWithModernMaster() {
        console.log('🚀 Integrating with Modern Master...');
        
        // Find modern master elements
        const modernElements = document.querySelectorAll('[class*="ModernMaster"]');
        
        modernElements.forEach(element => {
            element.classList.add('vue-enhanced');
        });
        
        // Add Vue components containers
        this.addVueContainers('modern-master');
        
        console.log('✅ Modern Master enhanced with Vue.js');
    },
    
    /**
     * Integration with Classic MenuBar
     */
    integrateWithClassicMenuBar() {
        console.log('🚀 Integrating with Classic MenuBar...');
        
        // Find PageMenuBar elements
        const pageMenuBars = document.querySelectorAll('.PageMenuBar');
        
        pageMenuBars.forEach(menuBar => {
            // Add responsive class if not exists
            if (!menuBar.classList.contains('responsive-pagemenubar')) {
                menuBar.classList.add('responsive-pagemenubar');
            }
            
            // Enhance with Vue.js functionality
            menuBar.setAttribute('data-vue-enhanced', 'true');
        });
        
        // Create mobile toggle for classic menu
        this.createClassicMobileToggle();
        
        // Add Vue components containers
        this.addVueContainers('classic-menubar');
        
        console.log('✅ Classic MenuBar enhanced with Vue.js');
    },
    
    /**
     * Integration with Default Master
     */
    integrateWithDefaultMaster() {
        console.log('🚀 Integrating with Default Master...');
        
        // Add modern enhancements to default master
        const form = document.querySelector('form[id*="form"]');
        if (form) {
            form.classList.add('vue-enhanced-form');
        }
        
        // Add Vue components containers
        this.addVueContainers('default-master');
        
        console.log('✅ Default Master enhanced with Vue.js');
    },
    
    /**
     * Add Vue component containers to page
     */
    addVueContainers(masterType) {
        const containers = [
            { id: 'mobile-menu-vue', class: 'vue-mobile-menu-container' },
            { id: 'theme-manager-vue', class: 'vue-theme-manager-container' },
            { id: 'home-dashboard-vue', class: 'vue-home-dashboard-container' }
        ];
        
        containers.forEach(container => {
            if (!document.getElementById(container.id)) {
                const div = document.createElement('div');
                div.id = container.id;
                div.className = `${container.class} vue-container-${masterType}`;
                div.style.cssText = 'position: relative; z-index: 1000;';
                
                // Insert into appropriate location
                this.insertVueContainer(div, container.id);
            }
        });
    },
    
    /**
     * Insert Vue container in appropriate location
     */
    insertVueContainer(container, containerId) {
        let targetLocation;
        
        switch (containerId) {
            case 'mobile-menu-vue':
                // Insert at beginning of body for mobile menu
                targetLocation = document.body;
                if (targetLocation.firstChild) {
                    targetLocation.insertBefore(container, targetLocation.firstChild);
                } else {
                    targetLocation.appendChild(container);
                }
                break;
                
            case 'theme-manager-vue':
                // Insert in header or navigation area
                targetLocation = document.querySelector('header, .header, .navbar, .main-master-header') || document.body;
                targetLocation.appendChild(container);
                break;
                
            case 'home-dashboard-vue':
                // Insert in main content area or specific home containers
                targetLocation = document.querySelector('.home-dashboard-container, .main-content, .content, main') || document.body;
                targetLocation.appendChild(container);
                break;
                
            default:
                document.body.appendChild(container);
        }
    },
    
    /**
     * Create mobile toggle for classic menu
     */
    createClassicMobileToggle() {
        if (document.querySelector('.pagemenu-mobile-toggle')) return;
        
        const toggleButton = document.createElement('button');
        toggleButton.className = 'pagemenu-mobile-toggle';
        toggleButton.innerHTML = `
            <i class="fas fa-bars"></i>
            <span class="toggle-text">القائمة</span>
        `;
        
        toggleButton.addEventListener('click', () => {
            if (window.mainmaster && window.mainmaster.menubar) {
                window.mainmaster.menubar.mobilefunction();
            }
        });
        
        document.body.appendChild(toggleButton);
        console.log('✅ Classic mobile toggle created');
    },
    
    /**
     * Setup navigation enhancements
     */
    setupNavigationEnhancements() {
        // Enhance all navigation links
        const navLinks = document.querySelectorAll('a[href], .nav-link, .menu-item a');
        
        navLinks.forEach(link => {
            // Add smooth scrolling for anchor links
            if (link.getAttribute('href') && link.getAttribute('href').startsWith('#')) {
                link.addEventListener('click', (e) => {
                    const target = document.querySelector(link.getAttribute('href'));
                    if (target) {
                        e.preventDefault();
                        target.scrollIntoView({ behavior: 'smooth' });
                    }
                });
            }
            
            // Add ARIA attributes for accessibility
            if (!link.getAttribute('aria-label') && link.textContent.trim()) {
                link.setAttribute('aria-label', link.textContent.trim());
            }
        });
        
        console.log(`✅ Enhanced ${navLinks.length} navigation links`);
    },
    
    /**
     * Initialize responsive behavior
     */
    initializeResponsiveBehavior() {
        // Handle window resize
        window.addEventListener('resize', () => {
            this.handleResize();
        });
        
        // Handle orientation change
        window.addEventListener('orientationchange', () => {
            setTimeout(() => this.handleResize(), 100);
        });
        
        // Initial responsive setup
        this.handleResize();
    },
    
    /**
     * Handle window resize
     */
    handleResize() {
        const isMobile = window.innerWidth <= 768;
        const isTablet = window.innerWidth > 768 && window.innerWidth <= 1024;
        const isDesktop = window.innerWidth > 1024;
        
        // Update CSS custom properties
        document.documentElement.style.setProperty('--is-mobile', isMobile ? '1' : '0');
        document.documentElement.style.setProperty('--is-tablet', isTablet ? '1' : '0');
        document.documentElement.style.setProperty('--is-desktop', isDesktop ? '1' : '0');
        
        // Close mobile menus on resize to desktop
        if (isDesktop && window.mainmaster && window.mainmaster.menubar) {
            const isMenuOpen = document.querySelector('.pagemenu-mobile-toggle.active');
            if (isMenuOpen) {
                window.mainmaster.menubar.closeMobile();
            }
        }
        
        // Dispatch resize event for Vue components
        const resizeEvent = new CustomEvent('masterPageResize', {
            detail: { isMobile, isTablet, isDesktop, width: window.innerWidth }
        });
        document.dispatchEvent(resizeEvent);
    },
    
    /**
     * Setup legacy compatibility
     */
    setupLegacyCompatibility() {
        // Map old function names to new hierarchical system
        const legacyMappings = {
            'toggleModernMenu': 'mainmaster.menubar.mobilefunction',
            'togglePageMenuBar': 'mainmaster.menubar.mobilefunction',
            'switchTheme': 'mainmaster.menubar.switchTheme',
            'showNotification': 'mainmaster.utils.showNotification'
        };
        
        Object.entries(legacyMappings).forEach(([oldName, newPath]) => {
            if (!window[oldName]) {
                window[oldName] = function(...args) {
                    const pathParts = newPath.split('.');
                    let func = window;
                    
                    for (const part of pathParts) {
                        func = func[part];
                        if (!func) break;
                    }
                    
                    if (typeof func === 'function') {
                        return func.apply(this, args);
                    } else {
                        console.warn(`Legacy function ${oldName} mapping to ${newPath} failed`);
                    }
                };
            }
        });
        
        console.log('✅ Legacy compatibility layer activated');
    },
    
    /**
     * Add CSS enhancements
     */
    addCSSEnhancements() {
        const style = document.createElement('style');
        style.textContent = `
            /* Master Page Integration Enhancements */
            .vue-enhanced {
                transition: all 0.3s ease;
            }
            
            .vue-container-main-master {
                /* Specific styles for main master */
            }
            
            .vue-container-modern-master {
                /* Specific styles for modern master */
            }
            
            .vue-container-classic-menubar {
                /* Specific styles for classic menubar */
            }
            
            .vue-container-default-master {
                /* Specific styles for default master */
            }
            
            /* Responsive enhancements */
            @media (max-width: 768px) {
                .vue-enhanced {
                    font-size: 0.9rem;
                }
            }
            
            /* Animation enhancements */
            .vue-enhanced:hover {
                transform: translateY(-1px);
            }
        `;
        
        document.head.appendChild(style);
        console.log('✅ CSS enhancements added');
    },
    
    /**
     * Initialize home- class enhancements
     */
    initializeHomeClassEnhancements() {
        // Find all elements with home- classes
        const homeElements = document.querySelectorAll('[class*="home-"]');
        
        homeElements.forEach(element => {
            // Add Vue enhancement marker
            element.setAttribute('data-vue-home-enhanced', 'true');
            
            // Add intersection observer for animations
            if ('IntersectionObserver' in window) {
                const observer = new IntersectionObserver((entries) => {
                    entries.forEach(entry => {
                        if (entry.isIntersecting) {
                            entry.target.classList.add('vue-animated');
                        }
                    });
                });
                
                observer.observe(element);
            }
        });
        
        console.log(`✅ Enhanced ${homeElements.length} home- class elements`);
    },
    
    /**
     * Get integration status
     */
    getStatus() {
        return {
            version: this.version,
            masterPageType: this.currentMaster ? this.currentMaster.type : 'Unknown',
            vueFrameworkLoaded: !!window.mainmaster,
            componentsLoaded: !!window.VueComponents,
            containersCreated: {
                mobileMenu: !!document.getElementById('mobile-menu-vue'),
                themeManager: !!document.getElementById('theme-manager-vue'),
                homeDashboard: !!document.getElementById('home-dashboard-vue')
            }
        };
    }
};

// Auto-initialize when DOM is ready
document.addEventListener('DOMContentLoaded', function() {
    // Wait for Vue framework to load
    const initIntegration = () => {
        if (window.mainmaster) {
            MasterPageIntegration.init();
            MasterPageIntegration.addCSSEnhancements();
            MasterPageIntegration.initializeHomeClassEnhancements();
            
            // Expose globally for debugging
            window.MasterPageIntegration = MasterPageIntegration;
            
            console.log('🎯 Master Page Integration Status:', MasterPageIntegration.getStatus());
        } else {
            // Retry after a short delay
            setTimeout(initIntegration, 500);
        }
    };
    
    // Start integration
    setTimeout(initIntegration, 100);
});

// Export for module systems
if (typeof module !== 'undefined' && module.exports) {
    module.exports = MasterPageIntegration;
}

/**
 * 🎯 Integration Features:
 * 
 * ✅ Automatic master page detection
 * ✅ Vue.js framework integration
 * ✅ Legacy function compatibility
 * ✅ Responsive behavior enhancements
 * ✅ Navigation improvements
 * ✅ Home- class element enhancements
 * ✅ Mobile menu creation for classic pages
 * ✅ CSS and animation enhancements
 * ✅ Accessibility improvements
 * ✅ Debug and status reporting
 * 
 * 🔧 Usage:
 * - Automatically integrates on page load
 * - Access status: MasterPageIntegration.getStatus()
 * - Legacy functions still work: togglePageMenuBar(), switchTheme()
 * - New hierarchical system: mainmaster.menubar.mobilefunction()
 */

console.log(`
🔗 Master Page Integration Loaded!
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
✅ Auto-detects master page type
✅ Integrates Vue.js framework seamlessly  
✅ Maintains backward compatibility
✅ Enhances responsive behavior
✅ Improves accessibility and animations
✅ Links home- classes to Vue system

🎯 Supported Master Pages:
   • Main Master (.main-master)
   • Modern Master ([class*="ModernMaster"])
   • Classic MenuBar (.PageMenuBar)
   • Default Master (form elements)

🔧 Integration Status: Ready
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
`);
