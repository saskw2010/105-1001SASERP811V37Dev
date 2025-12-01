// Modern UI Enhancements for SASERP811V37
document.addEventListener('DOMContentLoaded', function() {
    
    // Add smooth scrolling to all links
    document.querySelectorAll('a[href^="#"]').forEach(anchor => {
        anchor.addEventListener('click', function (e) {
            e.preventDefault();
            const target = document.querySelector(this.getAttribute('href'));
            if (target) {
                target.scrollIntoView({ behavior: 'smooth' });
            }
        });
    });
    
    // Add loading animation to buttons
    document.querySelectorAll('input[type="submit"], button, .Button').forEach(button => {
        button.addEventListener('click', function() {
            if (this.classList.contains('loading')) return;
            
            const originalText = this.innerHTML;
            this.classList.add('loading');
            this.innerHTML = '<span style="display: inline-flex; align-items: center;"><svg width="16" height="16" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" style="animation: spin 1s linear infinite; margin-left: 8px;"><path d="M21 12a9 9 0 1 1-6.219-8.56"/></svg> جاري التحميل...</span>';
            this.disabled = true;
            
            // Re-enable after form submission or 3 seconds
            setTimeout(() => {
                if (this.classList.contains('loading')) {
                    this.innerHTML = originalText;
                    this.disabled = false;
                    this.classList.remove('loading');
                }
            }, 3000);
        });
    });
    
    // Add fade-in animation to content
    const observerOptions = {
        threshold: 0.1,
        rootMargin: '0px 0px -50px 0px'
    };
    
    const observer = new IntersectionObserver(function(entries) {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('fade-in');
            }
        });
    }, observerOptions);
    
    // Observe all task boxes and data tables
    document.querySelectorAll('.TaskBox, table.DataView, .DataViewExtender').forEach(el => {
        observer.observe(el);
    });
    
    // Enhanced search functionality
    const searchInputs = document.querySelectorAll('input[type="text"]');
    searchInputs.forEach(input => {
        if (input.placeholder && (input.placeholder.includes('بحث') || input.placeholder.includes('Search'))) {
            input.addEventListener('focus', function() {
                this.parentElement.classList.add('search-focused');
                this.style.transform = 'scale(1.02)';
                this.style.boxShadow = '0 0 0 3px rgba(37, 99, 235, 0.1)';
            });
            
            input.addEventListener('blur', function() {
                this.parentElement.classList.remove('search-focused');
                this.style.transform = 'scale(1)';
                this.style.boxShadow = '';
            });
        }
    });
    
    // Add hover effects to table rows
    document.querySelectorAll('table.DataView tr.Row, table.DataView tr.AlternatingRow').forEach(row => {
        row.addEventListener('mouseenter', function() {
            this.style.transform = 'scale(1.005)';
            this.style.transition = 'transform 0.2s ease, background-color 0.2s ease';
            this.style.zIndex = '1';
            this.style.position = 'relative';
        });
        
        row.addEventListener('mouseleave', function() {
            this.style.transform = 'scale(1)';
            this.style.zIndex = '';
            this.style.position = '';
        });
    });
    
    // Add ripple effect to buttons
    function addRippleEffect(button) {
        button.addEventListener('click', function(e) {
            const ripple = document.createElement('span');
            const rect = this.getBoundingClientRect();
            const size = Math.max(rect.width, rect.height);
            const x = e.clientX - rect.left - size / 2;
            const y = e.clientY - rect.top - size / 2;
            
            ripple.style.cssText = `
                position: absolute;
                width: ${size}px;
                height: ${size}px;
                left: ${x}px;
                top: ${y}px;
                background: rgba(255, 255, 255, 0.3);
                border-radius: 50%;
                transform: scale(0);
                animation: ripple 0.6s ease-out;
                pointer-events: none;
            `;
            
            this.style.position = 'relative';
            this.style.overflow = 'hidden';
            this.appendChild(ripple);
            
            setTimeout(() => {
                ripple.remove();
            }, 600);
        });
    }
    
    // Apply ripple effect to all buttons
    document.querySelectorAll('button, input[type="submit"], input[type="button"], .Button').forEach(addRippleEffect);
    
    // Enhanced tab functionality
    document.querySelectorAll('.Tab, .ajax__tab_tab').forEach(tab => {
        tab.addEventListener('mouseenter', function() {
            this.style.transform = 'translateY(-2px)';
            this.style.boxShadow = '0 4px 8px rgba(0, 0, 0, 0.1)';
        });
        
        tab.addEventListener('mouseleave', function() {
            if (!this.classList.contains('ajax__tab_active')) {
                this.style.transform = 'translateY(0)';
                this.style.boxShadow = '';
            }
        });
    });
    
    // Add loading overlay for long operations
    function showLoadingOverlay(message = 'جاري التحميل...') {
        const overlay = document.createElement('div');
        overlay.id = 'loadingOverlay';
        overlay.style.cssText = `
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background: rgba(0, 0, 0, 0.5);
            display: flex;
            justify-content: center;
            align-items: center;
            z-index: 9999;
        `;
        
        const loadingBox = document.createElement('div');
        loadingBox.style.cssText = `
            background: white;
            padding: 30px;
            border-radius: 10px;
            text-align: center;
            box-shadow: 0 20px 25px -5px rgba(0, 0, 0, 0.1);
        `;
        
        loadingBox.innerHTML = `
            <div style="margin-bottom: 15px;">
                <svg width="40" height="40" viewBox="0 0 24 24" fill="none" stroke="#2563eb" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" style="animation: spin 1s linear infinite;">
                    <path d="M21 12a9 9 0 1 1-6.219-8.56"/>
                </svg>
            </div>
            <div style="color: #1f2937; font-weight: 500;">${message}</div>
        `;
        
        overlay.appendChild(loadingBox);
        document.body.appendChild(overlay);
        
        return overlay;
    }
    
    // Remove loading overlay
    function hideLoadingOverlay() {
        const overlay = document.getElementById('loadingOverlay');
        if (overlay) {
            overlay.remove();
        }
    }
    
    // Add to global scope for external use
    window.showLoadingOverlay = showLoadingOverlay;
    window.hideLoadingOverlay = hideLoadingOverlay;
    
    // Auto-hide alerts after 5 seconds
    document.querySelectorAll('.Alert, .MessageBar').forEach(alert => {
        setTimeout(() => {
            alert.style.opacity = '0';
            alert.style.transform = 'translateY(-20px)';
            alert.style.transition = 'all 0.3s ease';
            setTimeout(() => {
                alert.style.display = 'none';
            }, 300);
        }, 5000);
    });
    
    // Enhanced form validation feedback
    document.querySelectorAll('input[required], select[required], textarea[required]').forEach(field => {
        field.addEventListener('invalid', function() {
            this.style.borderColor = '#dc2626';
            this.style.boxShadow = '0 0 0 3px rgba(220, 38, 38, 0.1)';
        });
        
        field.addEventListener('input', function() {
            if (this.validity.valid) {
                this.style.borderColor = '#10b981';
                this.style.boxShadow = '0 0 0 3px rgba(16, 185, 129, 0.1)';
            } else {
                this.style.borderColor = '#dc2626';
                this.style.boxShadow = '0 0 0 3px rgba(220, 38, 38, 0.1)';
            }
        });
    });
    
    // Add tooltips to buttons and links
    document.querySelectorAll('[title]').forEach(element => {
        element.addEventListener('mouseenter', function(e) {
            const tooltip = document.createElement('div');
            tooltip.className = 'custom-tooltip';
            tooltip.textContent = this.getAttribute('title');
            tooltip.style.cssText = `
                position: absolute;
                background: #1f2937;
                color: white;
                padding: 8px 12px;
                border-radius: 6px;
                font-size: 12px;
                z-index: 1000;
                pointer-events: none;
                opacity: 0;
                transform: translateY(-10px);
                transition: all 0.2s ease;
            `;
            
            document.body.appendChild(tooltip);
            
            const rect = this.getBoundingClientRect();
            tooltip.style.left = (rect.left + rect.width / 2 - tooltip.offsetWidth / 2) + 'px';
            tooltip.style.top = (rect.top - tooltip.offsetHeight - 8) + 'px';
            
            setTimeout(() => {
                tooltip.style.opacity = '1';
                tooltip.style.transform = 'translateY(0)';
            }, 10);
            
            this.setAttribute('data-original-title', this.getAttribute('title'));
            this.removeAttribute('title');
        });
        
        element.addEventListener('mouseleave', function() {
            const tooltip = document.querySelector('.custom-tooltip');
            if (tooltip) {
                tooltip.remove();
            }
            
            if (this.getAttribute('data-original-title')) {
                this.setAttribute('title', this.getAttribute('data-original-title'));
                this.removeAttribute('data-original-title');
            }
        });
    });
});

// Theme switcher functionality
function toggleTheme() {
    const body = document.body;
    const isDark = body.classList.contains('dark-theme');
    
    if (isDark) {
        body.classList.remove('dark-theme');
        localStorage.setItem('theme', 'light');
    } else {
        body.classList.add('dark-theme');
        localStorage.setItem('theme', 'dark');
    }
}

// Load saved theme
const savedTheme = localStorage.getItem('theme');
if (savedTheme === 'dark') {
    document.body.classList.add('dark-theme');
}

// Add CSS animations
const style = document.createElement('style');
style.textContent = `
    @keyframes spin {
        from { transform: rotate(0deg); }
        to { transform: rotate(360deg); }
    }
    
    @keyframes ripple {
        to {
            transform: scale(4);
            opacity: 0;
        }
    }
    
    .loading {
        pointer-events: none !important;
    }
    
    .search-focused {
        transform: scale(1.02);
        transition: transform 0.2s ease;
    }
`;
document.head.appendChild(style);
