/**
 * 🔧 Dashboard Fixes V2 JavaScript - SIMPLE & NO SCROLL BUTTONS
 * Resolving Tab Navigation and Sidebar Issues WITHOUT scroll buttons
 */

// Enhanced Dashboard Initialization
document.addEventListener('DOMContentLoaded', function() {
    console.log('🔧 Loading Dashboard Fixes V2 (No Scroll Buttons)...');
    
    // Fix tab navigation - NO SCROLL BUTTONS
    initializeSimpleTabs();
    
    // Fix sidebar behavior
    initializeSidebarFixes();
    
    // Add mobile touch support
    addSimpleTouchSupport();
    
    // Prevent main page scroll
    preventMainPageScroll();
    
    console.log('✅ Dashboard Fixes V2 Applied Successfully');
});

// Initialize Simple Tab Navigation - NO SCROLL BUTTONS
function initializeSimpleTabs() {
    const tabContainer = document.querySelector('.enterprise-tabs');
    const tabLinks = document.querySelectorAll('.enterprise-tabs .nav-link');
    const tabPanes = document.querySelectorAll('.tab-pane');
    
    if (!tabContainer || !tabLinks.length) return;
    
    console.log('🗂️ Initializing simple tab navigation...');
    
    // Ensure proper tab behavior
    tabLinks.forEach((link, index) => {
        link.addEventListener('click', function(e) {
            e.preventDefault();
            e.stopPropagation();
            
            // Remove active from all tabs
            tabLinks.forEach(l => {
                l.classList.remove('active');
                l.setAttribute('aria-selected', 'false');
            });
            
            tabPanes.forEach(p => {
                p.classList.remove('show', 'active');
            });
            
            // Activate clicked tab
            this.classList.add('active');
            this.setAttribute('aria-selected', 'true');
            
            // Show corresponding pane
            const targetId = this.getAttribute('href');
            const targetPane = document.querySelector(targetId);
            
            if (targetPane) {
                // Add delay for smooth transition
                setTimeout(() => {
                    targetPane.classList.add('show', 'active');
                }, 50);
                
                // Simple scroll to center tab
                this.scrollIntoView({
                    behavior: 'smooth',
                    block: 'nearest',
                    inline: 'center'
                });
            }
            
            console.log(`🗂️ Switched to tab: ${targetId}`);
        });
        
        // Add keyboard support
        link.addEventListener('keydown', function(e) {
            if (e.key === 'Enter' || e.key === ' ') {
                e.preventDefault();
                this.click();
            }
        });
    });
    
    // Add keyboard navigation for tabs
    tabContainer.addEventListener('keydown', function(e) {
        const currentTab = document.querySelector('.enterprise-tabs .nav-link.active');
        const allTabs = Array.from(tabLinks);
        const currentIndex = allTabs.indexOf(currentTab);
        
        let targetIndex = currentIndex;
        
        if (e.key === 'ArrowRight' || e.key === 'ArrowDown') {
            e.preventDefault();
            targetIndex = (currentIndex + 1) % allTabs.length;
        } else if (e.key === 'ArrowLeft' || e.key === 'ArrowUp') {
            e.preventDefault();
            targetIndex = currentIndex > 0 ? currentIndex - 1 : allTabs.length - 1;
        } else if (e.key === 'Home') {
            e.preventDefault();
            targetIndex = 0;
        } else if (e.key === 'End') {
            e.preventDefault();
            targetIndex = allTabs.length - 1;
        }
        
        if (targetIndex !== currentIndex) {
            allTabs[targetIndex].click();
            allTabs[targetIndex].focus();
        }
    });
    
    console.log('✅ Simple tab navigation initialized WITHOUT scroll buttons');
}

// Initialize Sidebar Fixes
function initializeSidebarFixes() {
    console.log('📱 Fixing sidebar behavior...');
    
    const sidebar = document.getElementById('dashboardSidebar');
    if (!sidebar) return;
    
    // Create overlay if not exists
    let overlay = document.getElementById('sidebarOverlay');
    if (!overlay) {
        overlay = document.createElement('div');
        overlay.id = 'sidebarOverlay';
        overlay.className = 'sidebar-overlay';
        document.body.appendChild(overlay);
    }
    
    // Enhanced toggle function
    window.toggleDashboardSidebar = function() {
        const isActive = sidebar.classList.contains('active');
        const body = document.body;
        
        if (isActive) {
            // Close sidebar
            sidebar.classList.remove('active');
            overlay.classList.remove('active');
            body.classList.remove('sidebar-open');
            body.style.overflow = '';
            body.style.position = '';
            body.style.width = '';
        } else {
            // Open sidebar
            sidebar.classList.add('active');
            overlay.classList.add('active');
            body.classList.add('sidebar-open');
            body.style.overflow = 'hidden';
            body.style.position = 'fixed';
            body.style.width = '100%';
        }
        
        console.log('📱 Sidebar toggled:', !isActive);
    };
    
    // Close on overlay click
    overlay.addEventListener('click', window.toggleDashboardSidebar);
    
    // Close on escape key
    document.addEventListener('keydown', function(e) {
        if (e.key === 'Escape' && sidebar.classList.contains('active')) {
            window.toggleDashboardSidebar();
        }
    });
    
    // Handle window resize
    let resizeTimeout;
    window.addEventListener('resize', function() {
        clearTimeout(resizeTimeout);
        resizeTimeout = setTimeout(function() {
            if (window.innerWidth > 1024 && sidebar.classList.contains('active')) {
                // Keep sidebar behavior consistent on larger screens
            }
        }, 250);
    });
}

// Add Simple Mobile Touch Support
function addSimpleTouchSupport() {
    if (!('ontouchstart' in window)) return;
    
    console.log('📱 Adding simple mobile touch support...');
    
    let startX = 0;
    let startY = 0;
    
    document.addEventListener('touchstart', function(e) {
        startX = e.touches[0].clientX;
        startY = e.touches[0].clientY;
    }, { passive: true });
    
    document.addEventListener('touchend', function(e) {
        const endX = e.changedTouches[0].clientX;
        const endY = e.changedTouches[0].clientY;
        const diffX = startX - endX;
        const diffY = startY - endY;
        
        // Swipe detection (minimum 50px, mostly horizontal)
        if (Math.abs(diffX) > 50 && Math.abs(diffX) > Math.abs(diffY)) {
            const sidebar = document.getElementById('dashboardSidebar');
            if (sidebar) {
                if (diffX > 0 && startX > window.innerWidth - 50) {
                    // Swipe left from right edge - open sidebar
                    if (!sidebar.classList.contains('active')) {
                        window.toggleDashboardSidebar();
                    }
                } else if (diffX < 0 && sidebar.classList.contains('active')) {
                    // Swipe right when sidebar is open - close sidebar
                    window.toggleDashboardSidebar();
                }
            }
        }
    }, { passive: true });
}

// Prevent Main Page Scroll
function preventMainPageScroll() {
    console.log('🚫 Preventing main page scroll...');
    
    // Prevent body scroll overflow
    document.body.style.overflowX = 'hidden';
    
    // Monitor for any elements that might cause scroll
    const dashboard = document.querySelector('.enterprise-dashboard-container');
    if (dashboard) {
        dashboard.style.overflow = 'hidden';
        dashboard.style.maxHeight = '85vh';
    }
    
    // Remove any existing scroll buttons
    const removeScrollButtons = () => {
        const scrollButtons = document.querySelectorAll('.tab-scroll-wrapper, .tab-scroll-btn');
        scrollButtons.forEach(btn => {
            btn.style.display = 'none';
            btn.style.visibility = 'hidden';
            btn.style.opacity = '0';
        });
    };
    
    // Run immediately and after a delay
    removeScrollButtons();
    setTimeout(removeScrollButtons, 1000);
    
    console.log('✅ Main page scroll prevention applied');
}

// Utility Functions
window.scrollToActiveTab = function() {
    const activeTab = document.querySelector('.enterprise-tabs .nav-link.active');
    if (activeTab) {
        activeTab.scrollIntoView({
            behavior: 'smooth',
            block: 'nearest',
            inline: 'center'
        });
    }
};

window.focusActiveTab = function() {
    const activeTab = document.querySelector('.enterprise-tabs .nav-link.active');
    if (activeTab) {
        activeTab.focus();
    }
};

// Auto-scroll to active tab on load
window.addEventListener('load', function() {
    setTimeout(() => {
        if (window.scrollToActiveTab) {
            window.scrollToActiveTab();
        }
    }, 500);
});

// Add keyboard shortcuts
document.addEventListener('keydown', function(e) {
    // Alt + S = Toggle Sidebar
    if (e.altKey && e.key === 's') {
        e.preventDefault();
        if (window.toggleDashboardSidebar) {
            window.toggleDashboardSidebar();
        }
    }
    
    // Alt + H = Go to Home Tab
    if (e.altKey && e.key === 'h') {
        e.preventDefault();
        const homeTab = document.getElementById('original-tab');
        if (homeTab) {
            homeTab.click();
        }
    }
    
    // Ctrl + Arrow Keys = Navigate Tabs
    if (e.ctrlKey && (e.key === 'ArrowLeft' || e.key === 'ArrowRight')) {
        e.preventDefault();
        const activeTab = document.querySelector('.enterprise-tabs .nav-link.active');
        const allTabs = document.querySelectorAll('.enterprise-tabs .nav-link');
        const currentIndex = Array.from(allTabs).indexOf(activeTab);
        
        if (e.key === 'ArrowLeft' && currentIndex > 0) {
            allTabs[currentIndex - 1].click();
        } else if (e.key === 'ArrowRight' && currentIndex < allTabs.length - 1) {
            allTabs[currentIndex + 1].click();
        }
    }
});

// Console welcome message
console.log(`
🔧 Dashboard Fixes V2 Loaded Successfully
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
✅ Tab navigation: Simple & Clean
✅ Sidebar behavior: Enhanced
✅ Mobile touch: Basic support  
✅ Main page scroll: PREVENTED
✅ Tab scroll buttons: REMOVED

📱 Touch gestures:
   • Swipe left from right edge: Open sidebar
   • Swipe right when sidebar open: Close sidebar
   
⌨️ Keyboard shortcuts:
   • Alt + S: Toggle sidebar
   • Alt + H: Go to home tab
   • Ctrl + ←/→: Navigate tabs
   • Arrow keys: Navigate tabs (when focused)
   • Escape: Close sidebar
   
🚫 Removed features:
   • Tab scroll buttons
   • Main page scrollbar
   • Complex animations
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
`);
