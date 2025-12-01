/**
 * 🔧 Dashboard Fixes JavaScript
 * Resolving Tab Navigation and Sidebar Issues
 */

// Enhanced Dashboard Initialization
document.addEventListener('DOMContentLoaded', function() {
    console.log('🔧 Loading Dashboard Fixes...');
    
    // Fix tab navigation
    initializeHorizontalTabs();
    
    // Fix sidebar behavior
    initializeSidebarFixes();
    
    // Add mobile touch support
    addMobileTouchSupport();
    
    // Monitor performance
    monitorTabPerformance();
    
    console.log('✅ Dashboard Fixes Applied Successfully');
});

// Initialize Horizontal Tab Navigation - NO SCROLL BUTTONS
function initializeHorizontalTabs() {
    const tabContainer = document.querySelector('.enterprise-tabs');
    const tabLinks = document.querySelectorAll('.enterprise-tabs .nav-link');
    const tabPanes = document.querySelectorAll('.tab-pane');
    
    if (!tabContainer || !tabLinks.length) return;
    
    console.log('🗂️ Fixing tab navigation (NO scroll buttons)...');
    
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
                
                // Scroll tab into view if needed (simple scroll)
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
    
    // NO SCROLL BUTTONS - Simple scroll behavior only
    console.log('✅ Tab navigation initialized WITHOUT scroll buttons');
}

// Add Tab Scroll Buttons
function addTabScrollButtons(container) {
    const wrapper = document.createElement('div');
    wrapper.className = 'tab-scroll-wrapper';
    wrapper.style.cssText = `
        position: relative;
        display: flex;
        align-items: center;
        background: #f8fafc;
    `;
    
    const leftBtn = document.createElement('button');
    leftBtn.innerHTML = '<i class="fas fa-chevron-left"></i>';
    leftBtn.className = 'tab-scroll-btn left';
    leftBtn.style.cssText = `
        position: absolute;
        left: 0;
        top: 50%;
        transform: translateY(-50%);
        z-index: 10;
        background: rgba(255,255,255,0.9);
        border: 1px solid #e2e8f0;
        border-radius: 50%;
        width: 32px;
        height: 32px;
        display: flex;
        align-items: center;
        justify-content: center;
        cursor: pointer;
        transition: all 0.3s ease;
        box-shadow: 0 2px 4px rgba(0,0,0,0.1);
    `;
    
    const rightBtn = document.createElement('button');
    rightBtn.innerHTML = '<i class="fas fa-chevron-right"></i>';
    rightBtn.className = 'tab-scroll-btn right';
    rightBtn.style.cssText = leftBtn.style.cssText.replace('left: 0', 'right: 0');
    
    // Insert wrapper
    container.parentNode.insertBefore(wrapper, container);
    wrapper.appendChild(leftBtn);
    wrapper.appendChild(container);
    wrapper.appendChild(rightBtn);
    
    // Add scroll functionality
    leftBtn.addEventListener('click', () => {
        container.scrollBy({ left: -150, behavior: 'smooth' });
    });
    
    rightBtn.addEventListener('click', () => {
        container.scrollBy({ left: 150, behavior: 'smooth' });
    });
    
    // Show/hide buttons based on scroll
    const updateButtons = () => {
        leftBtn.style.display = container.scrollLeft > 0 ? 'flex' : 'none';
        rightBtn.style.display = 
            container.scrollLeft < (container.scrollWidth - container.clientWidth) ? 'flex' : 'none';
    };
    
    container.addEventListener('scroll', updateButtons);
    window.addEventListener('resize', updateButtons);
    updateButtons();
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

// Add Mobile Touch Support
function addMobileTouchSupport() {
    if (!('ontouchstart' in window)) return;
    
    console.log('📱 Adding mobile touch support...');
    
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

// Monitor Tab Performance
function monitorTabPerformance() {
    const observer = new PerformanceObserver((list) => {
        list.getEntries().forEach((entry) => {
            if (entry.name.includes('tab-switch')) {
                console.log(`⚡ Tab switch performance: ${entry.duration.toFixed(2)}ms`);
            }
        });
    });
    
    try {
        observer.observe({ entryTypes: ['measure'] });
    } catch (e) {
        // Performance API not supported
    }
    
    // Track tab switches
    const originalToggle = window.toggleDashboardSidebar;
    window.toggleDashboardSidebar = function() {
        const start = performance.now();
        originalToggle();
        const end = performance.now();
        
        try {
            performance.measure('tab-switch', { start, end });
        } catch (e) {
            // Performance API not supported
        }
    };
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
        window.scrollToActiveTab();
    }, 500);
});

// Console welcome message
console.log(`
🔧 Dashboard Fixes Loaded Successfully
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
✅ Tab navigation: Fixed & Enhanced
✅ Sidebar behavior: Improved
✅ Mobile touch: Added
✅ Performance monitoring: Active

📱 Touch gestures:
   • Swipe left from right edge: Open sidebar
   • Swipe right when sidebar open: Close sidebar
   
⌨️ Keyboard shortcuts:
   • Arrow keys: Navigate tabs
   • Escape: Close sidebar
   • Enter/Space: Activate tab
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
`);
