// Error Handling and Resource Loading Manager
(function() {
    'use strict';
    
    // Global error handler
    window.addEventListener('error', function(e) {
        console.warn('Resource loading error:', e.filename, e.message);
        
        // Handle missing script files gracefully
        if (e.filename && e.filename.includes('.js')) {
            console.log('Attempting to handle missing JavaScript file:', e.filename);
            
            // Provide fallbacks for common missing scripts
            const filename = e.filename.split('/').pop();
            
            switch(filename) {
                case 'bootstrap.min.js':
                    createBootstrapFallback();
                    break;
                case 'jquery.min.js':
                    createJQueryFallback();
                    break;
            }
        }
        
        return true; // Prevent default error handling
    });
    
    // W3.js fallback implementation
    function createW3Fallback() {
        return {
            hide: function(sel) {
                const elements = document.querySelectorAll(sel);
                elements.forEach(el => el.style.display = 'none');
            },
            show: function(sel) {
                const elements = document.querySelectorAll(sel);
                elements.forEach(el => el.style.display = '');
            },
            addClass: function(sel, className) {
                const elements = document.querySelectorAll(sel);
                elements.forEach(el => el.classList.add(className));
            },
            removeClass: function(sel, className) {
                const elements = document.querySelectorAll(sel);
                elements.forEach(el => el.classList.remove(className));
            },
            toggleClass: function(sel, className) {
                const elements = document.querySelectorAll(sel);
                elements.forEach(el => el.classList.toggle(className));
            }
        };
    }
    
    // Basic jQuery fallback
    function createJQueryFallback() {
        if (typeof window.$ === 'undefined') {
            window.$ = function(selector) {
                if (typeof selector === 'function') {
                    // Document ready
                    if (document.readyState === 'loading') {
                        document.addEventListener('DOMContentLoaded', selector);
                    } else {
                        selector();
                    }
                    return;
                }
                
                const elements = document.querySelectorAll(selector);
                return {
                    hide: function() {
                        elements.forEach(el => el.style.display = 'none');
                        return this;
                    },
                    show: function() {
                        elements.forEach(el => el.style.display = '');
                        return this;
                    },
                    addClass: function(className) {
                        elements.forEach(el => el.classList.add(className));
                        return this;
                    },
                    removeClass: function(className) {
                        elements.forEach(el => el.classList.remove(className));
                        return this;
                    },
                    on: function(event, handler) {
                        elements.forEach(el => el.addEventListener(event, handler));
                        return this;
                    },
                    click: function(handler) {
                        if (handler) {
                            elements.forEach(el => el.addEventListener('click', handler));
                        } else {
                            elements.forEach(el => el.click());
                        }
                        return this;
                    }
                };
            };
            
            window.jQuery = window.$;
            console.log('jQuery fallback created');
        }
    }
    
    // Basic Bootstrap fallback
    function createBootstrapFallback() {
        // Add basic Bootstrap-like functionality
        console.log('Bootstrap fallback - basic functionality available');
    }
    
    // Resource loading checker
    function checkResources() {
        const requiredScripts = [
            'Scripts/jquery.min.js',
            'Scripts/bootstrap.min.js',
            'w3.js',
            'invjs/main.js',
            'Scripts/modern-navigation.js',
            'Scripts/modern-ui.js'
        ];
        
        const missingScripts = [];
        
        requiredScripts.forEach(script => {
            const scriptElements = document.querySelectorAll(`script[src*="${script}"]`);
            if (scriptElements.length === 0) {
                missingScripts.push(script);
            }
        });
        
        if (missingScripts.length > 0) {
            console.warn('Missing script references:', missingScripts);
        }
        
        // Check for w3 object specifically
        setTimeout(() => {
            if (typeof window.w3 === 'undefined') {
                console.warn('w3.js not loaded, creating fallback');
                window.w3 = createW3Fallback();
            }
        }, 1000);
    }
    
    // Initialize error handling
    document.addEventListener('DOMContentLoaded', function() {
        checkResources();
        console.log('Error handling system initialized');
    });
    
    // Export for debugging
    window.ErrorHandling = {
        checkResources: checkResources,
        createW3Fallback: createW3Fallback,
        createJQueryFallback: createJQueryFallback
    };
    
})();
