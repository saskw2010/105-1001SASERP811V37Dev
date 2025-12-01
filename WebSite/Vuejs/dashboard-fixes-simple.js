/**
 * 🔧 Dashboard Fixes V2 JavaScript - Simple & No Scroll Buttons
 * Clean implementation without TypeScript warnings
 */

// Initialize everything when DOM is ready
(function() {
    'use strict';
    
    // Wait for DOM to be ready
    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', initializeDashboard);
    } else {
        initializeDashboard();
    }
    
    function initializeDashboard() {
        console.log('🔧 Initializing Dashboard V2 (No Scroll Buttons)...');
        
        // Initialize components
        initSimpleTabs();
        initSidebar();
        addTouchSupport();
        preventPageScroll();
        addKeyboardShortcuts();
        
        console.log('✅ Dashboard V2 initialized successfully');
    }
    
    // Simple Tab Navigation - NO SCROLL BUTTONS
    function initSimpleTabs() {
        var tabContainer = document.querySelector('.enterprise-tabs');
        var tabLinks = document.querySelectorAll('.enterprise-tabs .nav-link');
        var tabPanes = document.querySelectorAll('.tab-pane');
        
        if (!tabContainer || tabLinks.length === 0) return;
        
        console.log('🗂️ Setting up simple tabs...');
        
        // Add click handlers to tabs
        for (var i = 0; i < tabLinks.length; i++) {
            addTabClickHandler(tabLinks[i], tabLinks, tabPanes);
        }
        
        // Add keyboard navigation
        tabContainer.addEventListener('keydown', function(e) {
            handleTabKeyboard(e, tabLinks);
        });
        
        console.log('✅ Simple tabs ready');
    }
    
    function addTabClickHandler(link, allLinks, allPanes) {
        link.addEventListener('click', function(e) {
            e.preventDefault();
            e.stopPropagation();
            
            // Remove active class from all tabs
            for (var i = 0; i < allLinks.length; i++) {
                allLinks[i].classList.remove('active');
                allLinks[i].setAttribute('aria-selected', 'false');
            }
            
            for (var j = 0; j < allPanes.length; j++) {
                allPanes[j].classList.remove('show', 'active');
            }
            
            // Activate clicked tab
            this.classList.add('active');
            this.setAttribute('aria-selected', 'true');
            
            // Show corresponding pane
            var targetId = this.getAttribute('href');
            var targetPane = document.querySelector(targetId);
            
            if (targetPane) {
                setTimeout(function() {
                    targetPane.classList.add('show', 'active');
                }, 50);
                
                // Center the tab
                if (this.scrollIntoView) {
                    this.scrollIntoView({
                        behavior: 'smooth',
                        block: 'nearest',
                        inline: 'center'
                    });
                }
            }
        });
        
        // Add keyboard support
        link.addEventListener('keydown', function(e) {
            if (e.keyCode === 13 || e.keyCode === 32) { // Enter or Space
                e.preventDefault();
                this.click();
            }
        });
    }
    
    function handleTabKeyboard(e, tabLinks) {
        var activeTab = document.querySelector('.enterprise-tabs .nav-link.active');
        if (!activeTab) return;
        
        var allTabs = Array.prototype.slice.call(tabLinks);
        var currentIndex = allTabs.indexOf(activeTab);
        var targetIndex = currentIndex;
        
        if (e.keyCode === 39 || e.keyCode === 40) { // Right or Down
            e.preventDefault();
            targetIndex = (currentIndex + 1) % allTabs.length;
        } else if (e.keyCode === 37 || e.keyCode === 38) { // Left or Up
            e.preventDefault();
            targetIndex = currentIndex > 0 ? currentIndex - 1 : allTabs.length - 1;
        } else if (e.keyCode === 36) { // Home
            e.preventDefault();
            targetIndex = 0;
        } else if (e.keyCode === 35) { // End
            e.preventDefault();
            targetIndex = allTabs.length - 1;
        }
        
        if (targetIndex !== currentIndex && allTabs[targetIndex]) {
            allTabs[targetIndex].click();
            allTabs[targetIndex].focus();
        }
    }
    
    // Initialize Sidebar
    function initSidebar() {
        console.log('📱 Setting up sidebar...');
        
        var sidebar = document.getElementById('dashboardSidebar');
        if (!sidebar) return;
        
        // Create overlay
        var overlay = document.getElementById('sidebarOverlay');
        if (!overlay) {
            overlay = document.createElement('div');
            overlay.id = 'sidebarOverlay';
            overlay.className = 'sidebar-overlay';
            document.body.appendChild(overlay);
        }
        
        // Global toggle function
        window.toggleDashboardSidebar = function() {
            var isActive = sidebar.classList.contains('active');
            var body = document.body;
            
            if (isActive) {
                sidebar.classList.remove('active');
                overlay.classList.remove('active');
                body.classList.remove('sidebar-open');
                body.style.overflow = '';
                body.style.position = '';
                body.style.width = '';
            } else {
                sidebar.classList.add('active');
                overlay.classList.add('active');
                body.classList.add('sidebar-open');
                body.style.overflow = 'hidden';
                body.style.position = 'fixed';
                body.style.width = '100%';
            }
        };
        
        // Close on overlay click
        overlay.addEventListener('click', window.toggleDashboardSidebar);
        
        // Close on escape
        document.addEventListener('keydown', function(e) {
            if (e.keyCode === 27 && sidebar.classList.contains('active')) { // Escape
                window.toggleDashboardSidebar();
            }
        });
    }
    
    // Add Touch Support
    function addTouchSupport() {
        if (!('ontouchstart' in window)) return;
        
        console.log('📱 Adding touch support...');
        
        var startX = 0;
        var startY = 0;
        
        document.addEventListener('touchstart', function(e) {
            startX = e.touches[0].clientX;
            startY = e.touches[0].clientY;
        }, { passive: true });
        
        document.addEventListener('touchend', function(e) {
            var endX = e.changedTouches[0].clientX;
            var endY = e.changedTouches[0].clientY;
            var diffX = startX - endX;
            var diffY = startY - endY;
            
            // Swipe detection
            if (Math.abs(diffX) > 50 && Math.abs(diffX) > Math.abs(diffY)) {
                var sidebar = document.getElementById('dashboardSidebar');
                if (sidebar && window.toggleDashboardSidebar) {
                    if (diffX > 0 && startX > window.innerWidth - 50) {
                        // Swipe left from right edge
                        if (!sidebar.classList.contains('active')) {
                            window.toggleDashboardSidebar();
                        }
                    } else if (diffX < 0 && sidebar.classList.contains('active')) {
                        // Swipe right when sidebar open
                        window.toggleDashboardSidebar();
                    }
                }
            }
        }, { passive: true });
    }
    
    // Prevent Page Scroll
    function preventPageScroll() {
        console.log('🚫 Preventing page scroll...');
        
        // Set body overflow
        document.body.style.overflowX = 'hidden';
        
        // Fix dashboard container
        var dashboard = document.querySelector('.enterprise-dashboard-container');
        if (dashboard) {
            dashboard.style.overflow = 'hidden';
            dashboard.style.maxHeight = '85vh';
        }
        
        // Remove scroll buttons
        function removeScrollButtons() {
            var scrollElements = document.querySelectorAll('.tab-scroll-wrapper, .tab-scroll-btn, .tab-scroll-left, .tab-scroll-right');
            for (var i = 0; i < scrollElements.length; i++) {
                var elem = scrollElements[i];
                elem.style.display = 'none';
                elem.style.visibility = 'hidden';
                elem.style.opacity = '0';
            }
        }
        
        removeScrollButtons();
        setTimeout(removeScrollButtons, 1000);
        
        console.log('✅ Page scroll prevented');
    }
    
    // Add Keyboard Shortcuts
    function addKeyboardShortcuts() {
        document.addEventListener('keydown', function(e) {
            // Alt + S = Toggle Sidebar
            if (e.altKey && e.keyCode === 83) { // S
                e.preventDefault();
                if (window.toggleDashboardSidebar) {
                    window.toggleDashboardSidebar();
                }
            }
            
            // Alt + H = Home Tab
            if (e.altKey && e.keyCode === 72) { // H
                e.preventDefault();
                var homeTab = document.getElementById('original-tab');
                if (homeTab) {
                    homeTab.click();
                }
            }
            
            // Ctrl + Arrow Keys = Navigate Tabs
            if (e.ctrlKey && (e.keyCode === 37 || e.keyCode === 39)) { // Left/Right
                e.preventDefault();
                var activeTab = document.querySelector('.enterprise-tabs .nav-link.active');
                var allTabs = document.querySelectorAll('.enterprise-tabs .nav-link');
                
                if (activeTab && allTabs.length > 0) {
                    var currentIndex = Array.prototype.slice.call(allTabs).indexOf(activeTab);
                    
                    if (e.keyCode === 37 && currentIndex > 0) { // Left
                        allTabs[currentIndex - 1].click();
                    } else if (e.keyCode === 39 && currentIndex < allTabs.length - 1) { // Right
                        allTabs[currentIndex + 1].click();
                    }
                }
            }
        });
    }
    
    // Utility Functions
    window.scrollToActiveTab = function() {
        var activeTab = document.querySelector('.enterprise-tabs .nav-link.active');
        if (activeTab && activeTab.scrollIntoView) {
            activeTab.scrollIntoView({
                behavior: 'smooth',
                block: 'nearest',
                inline: 'center'
            });
        }
    };
    
    window.focusActiveTab = function() {
        var activeTab = document.querySelector('.enterprise-tabs .nav-link.active');
        if (activeTab && activeTab.focus) {
            activeTab.focus();
        }
    };
    
    // Auto-scroll on load
    window.addEventListener('load', function() {
        setTimeout(function() {
            if (window.scrollToActiveTab) {
                window.scrollToActiveTab();
            }
        }, 500);
    });
    
    // Console message
    console.log('%c🔧 Dashboard Fixes V2 Loaded!', 'color: #28a745; font-weight: bold;');
    console.log('%c✅ Simple tabs, ✅ No scroll buttons, ✅ Clean UI', 'color: #6c757d;');
    
})();
