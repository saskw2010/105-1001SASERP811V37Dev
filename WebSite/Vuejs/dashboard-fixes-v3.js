/**
 * 🔧 Dashboard Fixes V3 JavaScript - NO SIDEBAR + NO SCROLL BUTTONS
 * Clean implementation for tabs only
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
        console.log('🔧 Initializing Dashboard V3 (No Sidebar)...');
        
        // Initialize components
        initSimpleTabs();
        preventPageScroll();
        addKeyboardShortcuts();
        removeSidebarElements();
        
        console.log('✅ Dashboard V3 initialized successfully');
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
    
    // Remove Sidebar Elements
    function removeSidebarElements() {
        console.log('🗑️ Removing sidebar elements...');
        
        // Remove sidebar elements
        function removeSidebars() {
            var sidebarElements = document.querySelectorAll(
                '.dashboard-sidebar, .sidebar-toggle-btn, .sidebar-overlay, ' +
                '.sidebar-header, .sidebar-content, .sidebar-section, .sidebar-close'
            );
            
            for (var i = 0; i < sidebarElements.length; i++) {
                var elem = sidebarElements[i];
                if (elem && elem.parentNode) {
                    elem.parentNode.removeChild(elem);
                }
            }
        }
        
        removeSidebars();
        setTimeout(removeSidebars, 500);
        
        console.log('✅ Sidebar elements removed');
    }
    
    // Add Keyboard Shortcuts - NO SIDEBAR SHORTCUTS
    function addKeyboardShortcuts() {
        document.addEventListener('keydown', function(e) {
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
    
    // Clean up any remaining sidebar references
    window.addEventListener('DOMContentLoaded', function() {
        setTimeout(function() {
            // Remove any dynamically created sidebar elements
            var sidebarElements = document.querySelectorAll('[class*="sidebar"], [id*="sidebar"]');
            for (var i = 0; i < sidebarElements.length; i++) {
                var elem = sidebarElements[i];
                if (elem.className.includes('sidebar') || elem.id.includes('sidebar')) {
                    elem.style.display = 'none';
                    elem.style.visibility = 'hidden';
                }
            }
        }, 1000);
    });
    
    // Console message
    console.log('%c🔧 Dashboard Fixes V3 Loaded!', 'color: #28a745; font-weight: bold;');
    console.log('%c✅ Clean tabs, ✅ No sidebar, ✅ No scroll buttons', 'color: #6c757d;');
    
})();
