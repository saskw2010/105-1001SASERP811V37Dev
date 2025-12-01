/**
 * Advanced User Information & Session Management System
 * Provides real-time user details, language settings, and time information
 */

class UserInfoManager {
    constructor() {
        this.userInfo = {};
        this.initializeUserInfo();
        this.setupRealtimeUpdates();
    }

    // Initialize user information display
    initializeUserInfo() {
        this.createUserInfoWidget();
        this.loadUserDetails();
        this.updateDateTime();
        this.detectLanguage();
    }

    // Create floating user info widget
    createUserInfoWidget() {
        const widget = document.createElement('div');
        widget.id = 'user-info-widget';
        widget.className = 'user-info-widget';
        widget.innerHTML = `
            <div class="user-info-header">
                <i class="fas fa-user-circle"></i>
                <span id="user-display-name">Loading...</span>
                <i class="fas fa-chevron-down toggle-icon"></i>
            </div>
            <div class="user-info-content">
                <div class="info-section">
                    <div class="info-item">
                        <label><i class="fas fa-user"></i> User:</label>
                        <span id="current-username">--</span>
                    </div>
                    <div class="info-item">
                        <label><i class="fas fa-shield-alt"></i> Role:</label>
                        <span id="current-role">--</span>
                    </div>
                    <div class="info-item">
                        <label><i class="fas fa-globe"></i> Language:</label>
                        <span id="current-language">--</span>
                    </div>
                    <div class="info-item">
                        <label><i class="fas fa-clock"></i> Time:</label>
                        <span id="current-time">--</span>
                    </div>
                    <div class="info-item">
                        <label><i class="fas fa-calendar"></i> Session:</label>
                        <span id="session-duration">--</span>
                    </div>
                </div>
                <div class="info-actions">
                    <button onclick="userInfoManager.refreshUserInfo()" class="btn-refresh">
                        <i class="fas fa-sync-alt"></i> Refresh
                    </button>
                    <button onclick="userInfoManager.showFullDetails()" class="btn-details">
                        <i class="fas fa-info-circle"></i> Details
                    </button>
                </div>
            </div>
        `;

        // Add CSS styles
        this.addUserInfoStyles();
        
        // Add to page
        document.body.appendChild(widget);
        
        // Add toggle functionality
        const header = widget.querySelector('.user-info-header');
        const content = widget.querySelector('.user-info-content');
        
        header.addEventListener('click', () => {
            content.classList.toggle('expanded');
            header.querySelector('.toggle-icon').classList.toggle('rotated');
        });
    }

    // Add CSS styles for user info widget
    addUserInfoStyles() {
        const styles = `
            <style>
            .user-info-widget {
                position: fixed;
                top: 10px;
                right: 10px;
                background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
                border-radius: 12px;
                box-shadow: 0 8px 32px rgba(31, 38, 135, 0.37);
                backdrop-filter: blur(8px);
                border: 1px solid rgba(255, 255, 255, 0.18);
                z-index: 9999;
                font-family: 'Cairo', sans-serif;
                min-width: 250px;
                max-width: 300px;
            }

            .user-info-header {
                padding: 12px 16px;
                color: white;
                cursor: pointer;
                display: flex;
                align-items: center;
                gap: 8px;
                font-weight: 500;
                transition: all 0.3s ease;
            }

            .user-info-header:hover {
                background: rgba(255, 255, 255, 0.1);
                border-radius: 12px 12px 0 0;
            }

            .toggle-icon {
                margin-left: auto;
                transition: transform 0.3s ease;
            }

            .toggle-icon.rotated {
                transform: rotate(180deg);
            }

            .user-info-content {
                max-height: 0;
                overflow: hidden;
                transition: max-height 0.3s ease;
                background: rgba(255, 255, 255, 0.95);
                backdrop-filter: blur(10px);
                color: #333;
            }

            .user-info-content.expanded {
                max-height: 400px;
                border-radius: 0 0 12px 12px;
            }

            .info-section {
                padding: 16px;
            }

            .info-item {
                display: flex;
                justify-content: space-between;
                align-items: center;
                margin-bottom: 8px;
                padding: 8px 0;
                border-bottom: 1px solid rgba(0, 0, 0, 0.1);
            }

            .info-item:last-child {
                border-bottom: none;
            }

            .info-item label {
                font-weight: 500;
                color: #2563eb;
                display: flex;
                align-items: center;
                gap: 6px;
            }

            .info-item span {
                font-weight: 400;
                text-align: right;
            }

            .info-actions {
                padding: 12px 16px;
                border-top: 1px solid rgba(0, 0, 0, 0.1);
                display: flex;
                gap: 8px;
            }

            .info-actions button {
                flex: 1;
                padding: 6px 12px;
                border: none;
                border-radius: 6px;
                background: #2563eb;
                color: white;
                font-size: 12px;
                cursor: pointer;
                transition: all 0.3s ease;
                display: flex;
                align-items: center;
                justify-content: center;
                gap: 4px;
            }

            .info-actions button:hover {
                background: #1d4ed8;
                transform: translateY(-1px);
            }

            .btn-refresh {
                background: #059669 !important;
            }

            .btn-refresh:hover {
                background: #047857 !important;
            }

            @keyframes pulse {
                0% { opacity: 1; }
                50% { opacity: 0.7; }
                100% { opacity: 1; }
            }

            .loading {
                animation: pulse 1.5s infinite;
            }
            </style>
        `;
        
        if (!document.querySelector('#user-info-styles')) {
            const styleSheet = document.createElement('div');
            styleSheet.id = 'user-info-styles';
            styleSheet.innerHTML = styles;
            document.head.appendChild(styleSheet);
        }
    }

    // Load user details from server
    async loadUserDetails() {
        try {
            // Get user info from membership system
            const userInfo = await this.fetchUserInfo();
            this.updateUserDisplay(userInfo);
        } catch (error) {
            console.error('Error loading user details:', error);
            this.updateUserDisplay({
                username: 'Guest',
                role: 'Anonymous',
                isAuthenticated: false
            });
        }
    }

    // Fetch user information from server
    async fetchUserInfo() {
        // Try to get user info from ASP.NET context
        if (typeof __doPostBack !== 'undefined') {
            return {
                username: this.getCurrentUsername(),
                role: this.getCurrentRole(),
                isAuthenticated: this.isUserAuthenticated(),
                language: this.getCurrentLanguage(),
                sessionStart: this.getSessionStartTime()
            };
        }
        
        return {
            username: 'Guest',
            role: 'Anonymous',
            isAuthenticated: false,
            language: navigator.language,
            sessionStart: new Date()
        };
    }

    // Update user display with fetched info
    updateUserDisplay(userInfo) {
        document.getElementById('user-display-name').textContent = userInfo.username || 'Guest';
        document.getElementById('current-username').textContent = userInfo.username || 'Guest';
        document.getElementById('current-role').textContent = userInfo.role || 'Anonymous';
        document.getElementById('current-language').textContent = userInfo.language || 'Auto';
        
        if (userInfo.sessionStart) {
            this.sessionStartTime = new Date(userInfo.sessionStart);
        }
        
        this.userInfo = userInfo;
    }

    // Get current username from ASP.NET context
    getCurrentUsername() {
        // Try multiple methods to get username
        if (window.Page && window.Page.User && window.Page.User.Identity) {
            return window.Page.User.Identity.Name || 'Guest';
        }
        
        // Check for membership bar
        const membershipElements = document.querySelectorAll('[data-user], .user-name, #username');
        for (let element of membershipElements) {
            if (element.textContent.trim()) {
                return element.textContent.trim();
            }
        }
        
        return 'Guest';
    }

    // Get current user role
    getCurrentRole() {
        // Check for role information in page
        const roleElements = document.querySelectorAll('[data-role], .user-role, #user-role');
        for (let element of roleElements) {
            if (element.textContent.trim()) {
                return element.textContent.trim();
            }
        }
        
        return 'User';
    }

    // Check if user is authenticated
    isUserAuthenticated() {
        return this.getCurrentUsername() !== 'Guest';
    }

    // Get current language
    getCurrentLanguage() {
        return document.documentElement.lang || 
               document.querySelector('html').getAttribute('xml:lang') || 
               navigator.language;
    }

    // Detect and update language settings
    detectLanguage() {
        const lang = this.getCurrentLanguage();
        const langName = this.getLanguageName(lang);
        document.getElementById('current-language').textContent = langName;
    }

    // Get language display name
    getLanguageName(langCode) {
        const languages = {
            'ar': 'العربية',
            'en': 'English',
            'ar-SA': 'العربية (السعودية)',
            'en-US': 'English (US)',
            'en-GB': 'English (UK)',
            'fr': 'Français',
            'de': 'Deutsch',
            'es': 'Español'
        };
        
        return languages[langCode] || langCode || 'Auto';
    }

    // Update date and time
    updateDateTime() {
        const now = new Date();
        const timeOptions = {
            hour: '2-digit',
            minute: '2-digit',
            second: '2-digit',
            hour12: false
        };
        
        const timeString = now.toLocaleTimeString(this.getCurrentLanguage(), timeOptions);
        document.getElementById('current-time').textContent = timeString;
        
        // Update session duration
        if (this.sessionStartTime) {
            const duration = Math.floor((now - this.sessionStartTime) / 1000 / 60);
            document.getElementById('session-duration').textContent = `${duration} min`;
        }
    }

    // Setup real-time updates
    setupRealtimeUpdates() {
        // Update time every second
        setInterval(() => {
            this.updateDateTime();
        }, 1000);
        
        // Refresh user info every 5 minutes
        setInterval(() => {
            this.refreshUserInfo();
        }, 5 * 60 * 1000);
        
        // Set session start time
        this.sessionStartTime = new Date();
    }

    // Refresh user information
    async refreshUserInfo() {
        const refreshBtn = document.querySelector('.btn-refresh');
        if (refreshBtn) {
            refreshBtn.classList.add('loading');
        }
        
        try {
            await this.loadUserDetails();
        } finally {
            if (refreshBtn) {
                refreshBtn.classList.remove('loading');
            }
        }
    }

    // Show full user details modal
    showFullDetails() {
        const modal = document.createElement('div');
        modal.className = 'user-details-modal';
        modal.innerHTML = `
            <div class="modal-backdrop"></div>
            <div class="modal-content">
                <div class="modal-header">
                    <h3><i class="fas fa-user-cog"></i> تفاصيل المستخدم الكاملة</h3>
                    <button class="close-btn">&times;</button>
                </div>
                <div class="modal-body">
                    <div class="detail-section">
                        <h4>معلومات الجلسة</h4>
                        <table class="details-table">
                            <tr><td>اسم المستخدم:</td><td>${this.userInfo.username || 'Guest'}</td></tr>
                            <tr><td>الدور:</td><td>${this.userInfo.role || 'Anonymous'}</td></tr>
                            <tr><td>مصادق:</td><td>${this.userInfo.isAuthenticated ? 'نعم' : 'لا'}</td></tr>
                            <tr><td>اللغة:</td><td>${this.getCurrentLanguage()}</td></tr>
                            <tr><td>المتصفح:</td><td>${navigator.userAgent.split(') ')[0]})</td></tr>
                            <tr><td>النظام:</td><td>${navigator.platform}</td></tr>
                            <tr><td>الوقت المحلي:</td><td>${new Date().toLocaleString()}</td></tr>
                            <tr><td>المنطقة الزمنية:</td><td>${Intl.DateTimeFormat().resolvedOptions().timeZone}</td></tr>
                        </table>
                    </div>
                </div>
            </div>
        `;
        
        // Add modal styles
        const modalStyles = `
            <style>
            .user-details-modal {
                position: fixed;
                top: 0;
                left: 0;
                width: 100%;
                height: 100%;
                z-index: 10000;
                font-family: 'Cairo', sans-serif;
            }
            
            .modal-backdrop {
                position: absolute;
                top: 0;
                left: 0;
                width: 100%;
                height: 100%;
                background: rgba(0, 0, 0, 0.5);
                backdrop-filter: blur(5px);
            }
            
            .modal-content {
                position: absolute;
                top: 50%;
                left: 50%;
                transform: translate(-50%, -50%);
                background: white;
                border-radius: 12px;
                box-shadow: 0 20px 60px rgba(0, 0, 0, 0.3);
                max-width: 500px;
                width: 90%;
                max-height: 80vh;
                overflow: hidden;
            }
            
            .modal-header {
                background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
                color: white;
                padding: 20px;
                display: flex;
                justify-content: space-between;
                align-items: center;
            }
            
            .modal-header h3 {
                margin: 0;
                display: flex;
                align-items: center;
                gap: 10px;
            }
            
            .close-btn {
                background: none;
                border: none;
                color: white;
                font-size: 24px;
                cursor: pointer;
                padding: 0;
                width: 30px;
                height: 30px;
                display: flex;
                align-items: center;
                justify-content: center;
                border-radius: 50%;
                transition: background 0.3s ease;
            }
            
            .close-btn:hover {
                background: rgba(255, 255, 255, 0.2);
            }
            
            .modal-body {
                padding: 20px;
                max-height: 60vh;
                overflow-y: auto;
            }
            
            .detail-section h4 {
                color: #2563eb;
                margin-bottom: 15px;
                border-bottom: 2px solid #e5e7eb;
                padding-bottom: 5px;
            }
            
            .details-table {
                width: 100%;
                border-collapse: collapse;
            }
            
            .details-table td {
                padding: 8px 12px;
                border-bottom: 1px solid #f3f4f6;
            }
            
            .details-table td:first-child {
                font-weight: 500;
                color: #374151;
                width: 40%;
            }
            
            .details-table td:last-child {
                color: #1f2937;
            }
            </style>
        `;
        
        modal.querySelector('.modal-content').insertAdjacentHTML('beforebegin', modalStyles);
        
        // Add event listeners
        modal.querySelector('.close-btn').addEventListener('click', () => {
            document.body.removeChild(modal);
        });
        
        modal.querySelector('.modal-backdrop').addEventListener('click', () => {
            document.body.removeChild(modal);
        });
        
        document.body.appendChild(modal);
    }

    // Get session start time
    getSessionStartTime() {
        return sessionStorage.getItem('sessionStartTime') || new Date().toISOString();
    }
}

// Initialize user info manager when DOM is ready
document.addEventListener('DOMContentLoaded', function() {
    window.userInfoManager = new UserInfoManager();
});

// Also initialize if DOM is already loaded
if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', function() {
        window.userInfoManager = new UserInfoManager();
    });
} else {
    window.userInfoManager = new UserInfoManager();
}
