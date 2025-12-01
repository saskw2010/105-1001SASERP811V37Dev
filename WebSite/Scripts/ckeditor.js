// CKEditor Placeholder - Basic Text Editor Functionality
// This is a minimal implementation to prevent 404 errors

(function() {
    'use strict';
    
    // Create global CKEDITOR object if it doesn't exist
    if (typeof window.CKEDITOR === 'undefined') {
        window.CKEDITOR = {
            instances: {},
            config: {
                toolbar: 'Basic',
                height: 300,
                language: 'en'
            },
            
            replace: function(elementId, config) {
                console.log('CKEditor placeholder: replacing element', elementId);
                const element = document.getElementById(elementId);
                if (element) {
                    // Basic textarea enhancement
                    element.style.border = '1px solid #ccc';
                    element.style.borderRadius = '4px';
                    element.style.padding = '10px';
                    element.style.fontFamily = 'Arial, sans-serif';
                    element.style.minHeight = config && config.height ? config.height + 'px' : '300px';
                    
                    // Store instance
                    this.instances[elementId] = {
                        element: element,
                        getData: function() {
                            return element.value;
                        },
                        setData: function(data) {
                            element.value = data;
                        },
                        destroy: function() {
                            // Cleanup if needed
                        }
                    };
                }
                return this.instances[elementId];
            },
            
            replaceAll: function() {
                console.log('CKEditor placeholder: replaceAll called');
                const textareas = document.querySelectorAll('textarea.ckeditor');
                textareas.forEach((textarea, index) => {
                    if (!textarea.id) {
                        textarea.id = 'ckeditor-' + index;
                    }
                    this.replace(textarea.id);
                });
            },
            
            on: function(event, callback) {
                console.log('CKEditor placeholder: event listener added for', event);
                // Basic event system placeholder
                if (event === 'instanceReady' && typeof callback === 'function') {
                    // Simulate ready event after short delay
                    setTimeout(callback, 100);
                }
            }
        };
    }
    
    // Auto-initialize when DOM is ready
    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', function() {
            setTimeout(function() {
                if (window.CKEDITOR && window.CKEDITOR.replaceAll) {
                    window.CKEDITOR.replaceAll();
                }
            }, 500);
        });
    } else {
        setTimeout(function() {
            if (window.CKEDITOR && window.CKEDITOR.replaceAll) {
                window.CKEDITOR.replaceAll();
            }
        }, 500);
    }
    
    console.log('CKEditor placeholder loaded successfully');
})();
