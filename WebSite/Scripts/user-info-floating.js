/**
 * 🚀 Floating User Info System with RTL Support
 * Created by: Advanced AI Assistant
 * Purpose: Arabic/English language-based floating user dropdown with mega menu capabilities
 */

class FloatingUserInfoSystem {
    constructor() {
        console.log('🎯 [FloatingUserInfo] Constructor started');
        
        this.isRTL = document.documentElement.dir === 'rtl' || document.documentElement.lang.includes('ar');
        this.currentLanguage = document.documentElement.lang || 'en';
        this.isExpanded = false;
        
        console.log('🌍 [FloatingUserInfo] Language settings:');
        console.log('  - isRTL:', this.isRTL);
        console.log('  - currentLanguage:', this.currentLanguage);
        console.log('  - document.dir:', document.documentElement.dir);
        console.log('  - document.lang:', document.documentElement.lang);
        
        this.init();
        console.log('✅ [FloatingUserInfo] Constructor completed');
    }

    init() {
        console.log('🔧 [FloatingUserInfo] Init process started');
        console.log('⚙️ [FloatingUserInfo] Creating user info container...');
        this.createUserInfoContainer();
        
        console.log('⚙️ [FloatingUserInfo] Setting up event listeners...');
        this.setupEventListeners();
        
        console.log('⚙️ [FloatingUserInfo] Loading user data...');
        this.loadUserData();
        
        console.log('⚙️ [FloatingUserInfo] Applying styling...');
        this.applyStyling();
        
        console.log('✅ [FloatingUserInfo] Init process completed successfully');
    }

    createUserInfoContainer() {
        // Remove existing containers
        const existing = document.getElementById('floating-user-info');
        if (existing) existing.remove();

        // Create main floating container
        const container = document.createElement('div');
        container.id = 'floating-user-info';
        container.className = `floating-user-container ${this.isRTL ? 'rtl-mode' : 'ltr-mode'}`;
        
        container.innerHTML = `
            <div class="user-info-trigger" id="userInfoTrigger">
                <div class="user-avatar">
                    <i class="fas fa-user-circle"></i>
                </div>
                <div class="user-quick-info">
                    <span class="user-name" id="userName">أهلاً بك</span>
                    <span class="user-role" id="userRole">مستخدم</span>
                </div>
                <div class="expand-indicator">
                    <i class="fas fa-chevron-down"></i>
                </div>
            </div>

            <div class="floating-dropdown" id="floatingDropdown">
                <div class="dropdown-header">
                    <div class="user-profile-section">
                        <div class="user-avatar-large">
                            <i class="fas fa-user-circle"></i>
                        </div>
                        <div class="user-details">
                            <h3 id="userFullName">اسم المستخدم</h3>
                            <p id="userEmail">user@example.com</p>
                            <span class="user-status online">متصل الآن</span>
                        </div>
                    </div>
                </div>

                <div class="mega-menu-content">
                    <div class="quick-actions-section">
                        <h4><i class="fas fa-bolt"></i> ${this.isRTL ? 'الوصول السريع' : 'Quick Access'}</h4>
                        <div class="quick-actions-grid">
                            <a href="#" class="quick-action" data-action="profile">
                                <i class="fas fa-user-edit"></i>
                                <span>${this.isRTL ? 'الملف الشخصي' : 'Profile'}</span>
                            </a>
                            <a href="#" class="quick-action" data-action="settings">
                                <i class="fas fa-cog"></i>
                                <span>${this.isRTL ? 'الإعدادات' : 'Settings'}</span>
                            </a>
                            <a href="#" class="quick-action" data-action="notifications">
                                <i class="fas fa-bell"></i>
                                <span>${this.isRTL ? 'الإشعارات' : 'Notifications'}</span>
                                <span class="notification-badge">3</span>
                            </a>
                            <a href="#" class="quick-action" data-action="help">
                                <i class="fas fa-question-circle"></i>
                                <span>${this.isRTL ? 'المساعدة' : 'Help'}</span>
                            </a>
                        </div>
                    </div>

                    <div class="system-info-section">
                        <h4><i class="fas fa-info-circle"></i> ${this.isRTL ? 'معلومات النظام' : 'System Info'}</h4>
                        <div class="system-info-grid">
                            <div class="info-item">
                                <label>${this.isRTL ? 'وقت الدخول:' : 'Login Time:'}</label>
                                <span id="loginTime">--:--</span>
                            </div>
                            <div class="info-item">
                                <label>${this.isRTL ? 'الجلسة:' : 'Session:'}</label>
                                <span id="sessionId">Active</span>
                            </div>
                            <div class="info-item">
                                <label>${this.isRTL ? 'اللغة:' : 'Language:'}</label>
                                <span id="currentLang">${this.isRTL ? 'العربية' : 'English'}</span>
                            </div>
                            <div class="info-item">
                                <label>${this.isRTL ? 'الصلاحيات:' : 'Permissions:'}</label>
                                <span id="userPermissions">Admin</span>
                            </div>
                        </div>
                    </div>

                    <div class="recent-activities-section">
                        <h4><i class="fas fa-history"></i> ${this.isRTL ? 'النشاطات الأخيرة' : 'Recent Activities'}</h4>
                        <div class="activities-list" id="activitiesList">
                            <div class="activity-item">
                                <i class="fas fa-file-alt"></i>
                                <span>${this.isRTL ? 'عرض تقرير المبيعات' : 'Viewed Sales Report'}</span>
                                <time>2 ${this.isRTL ? 'دقائق' : 'min ago'}</time>
                            </div>
                            <div class="activity-item">
                                <i class="fas fa-edit"></i>
                                <span>${this.isRTL ? 'تحديث بيانات العميل' : 'Updated Customer Data'}</span>
                                <time>15 ${this.isRTL ? 'دقيقة' : 'min ago'}</time>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="dropdown-footer">
                    <div class="footer-actions">
                        <button class="btn-secondary" id="changeLanguage">
                            <i class="fas fa-language"></i>
                            ${this.isRTL ? 'English' : 'العربية'}
                        </button>
                        <button class="btn-primary" id="logoutBtn">
                            <i class="fas fa-sign-out-alt"></i>
                            ${this.isRTL ? 'تسجيل خروج' : 'Logout'}
                        </button>
                    </div>
                </div>
            </div>
        `;

        document.body.appendChild(container);
    }

    applyStyling() {
        const styles = `
            <style id="floating-user-info-styles">
                .floating-user-container {
                    position: fixed;
                    top: 20px;
                    z-index: 9999;
                    font-family: 'Cairo', 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
                    transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
                }

                .floating-user-container.rtl-mode {
                    left: 20px;
                    direction: rtl;
                }

                .floating-user-container.ltr-mode {
                    right: 20px;
                    direction: ltr;
                }

                .user-info-trigger {
                    background: linear-gradient(135deg, #2563eb 0%, #1d4ed8 100%);
                    border-radius: 50px;
                    padding: 8px 16px;
                    display: flex;
                    align-items: center;
                    gap: 10px;
                    cursor: pointer;
                    box-shadow: 0 8px 32px rgba(37, 99, 235, 0.3);
                    backdrop-filter: blur(10px);
                    border: 1px solid rgba(255, 255, 255, 0.2);
                    transition: all 0.3s ease;
                    min-width: 200px;
                }

                .user-info-trigger:hover {
                    transform: translateY(-2px);
                    box-shadow: 0 12px 40px rgba(37, 99, 235, 0.4);
                }

                .user-avatar {
                    color: white;
                    font-size: 24px;
                }

                .user-quick-info {
                    flex: 1;
                    color: white;
                }

                .user-name {
                    display: block;
                    font-weight: 600;
                    font-size: 14px;
                }

                .user-role {
                    display: block;
                    font-size: 12px;
                    opacity: 0.8;
                }

                .expand-indicator {
                    color: white;
                    transition: transform 0.3s ease;
                }

                .floating-user-container.expanded .expand-indicator {
                    transform: rotate(180deg);
                }

                .floating-dropdown {
                    position: absolute;
                    top: calc(100% + 10px);
                    width: 400px;
                    max-height: 0;
                    overflow: hidden;
                    background: rgba(255, 255, 255, 0.95);
                    backdrop-filter: blur(20px);
                    border-radius: 20px;
                    box-shadow: 0 20px 60px rgba(0, 0, 0, 0.2);
                    border: 1px solid rgba(255, 255, 255, 0.3);
                    transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
                    transform: translateY(-20px);
                    opacity: 0;
                }

                .floating-user-container.rtl-mode .floating-dropdown {
                    right: 0;
                }

                .floating-user-container.ltr-mode .floating-dropdown {
                    left: 0;
                }

                .floating-user-container.expanded .floating-dropdown {
                    max-height: 600px;
                    transform: translateY(0);
                    opacity: 1;
                }

                .dropdown-header {
                    background: linear-gradient(135deg, #2563eb 0%, #1d4ed8 100%);
                    color: white;
                    padding: 20px;
                    border-radius: 20px 20px 0 0;
                }

                .user-profile-section {
                    display: flex;
                    align-items: center;
                    gap: 15px;
                }

                .user-avatar-large {
                    font-size: 40px;
                }

                .user-details h3 {
                    margin: 0 0 5px 0;
                    font-size: 18px;
                    font-weight: 600;
                }

                .user-details p {
                    margin: 0 0 5px 0;
                    opacity: 0.8;
                    font-size: 14px;
                }

                .user-status {
                    background: #10b981;
                    color: white;
                    padding: 2px 8px;
                    border-radius: 12px;
                    font-size: 12px;
                    display: inline-block;
                }

                .mega-menu-content {
                    padding: 20px;
                }

                .mega-menu-content h4 {
                    color: #1f2937;
                    margin: 0 0 15px 0;
                    font-size: 16px;
                    font-weight: 600;
                    display: flex;
                    align-items: center;
                    gap: 8px;
                }

                .quick-actions-grid {
                    display: grid;
                    grid-template-columns: repeat(2, 1fr);
                    gap: 10px;
                    margin-bottom: 25px;
                }

                .quick-action {
                    display: flex;
                    align-items: center;
                    gap: 10px;
                    padding: 12px;
                    background: #f8fafc;
                    border-radius: 12px;
                    text-decoration: none;
                    color: #374151;
                    transition: all 0.3s ease;
                    position: relative;
                }

                .quick-action:hover {
                    background: #e5e7eb;
                    transform: translateY(-2px);
                    color: #2563eb;
                }

                .quick-action i {
                    color: #2563eb;
                    width: 20px;
                }

                .notification-badge {
                    position: absolute;
                    top: 5px;
                    right: 5px;
                    background: #ef4444;
                    color: white;
                    border-radius: 50%;
                    width: 18px;
                    height: 18px;
                    font-size: 10px;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                }

                .system-info-grid {
                    display: grid;
                    grid-template-columns: repeat(2, 1fr);
                    gap: 15px;
                    margin-bottom: 25px;
                }

                .info-item {
                    background: #f8fafc;
                    padding: 12px;
                    border-radius: 8px;
                }

                .info-item label {
                    display: block;
                    font-size: 12px;
                    color: #6b7280;
                    margin-bottom: 4px;
                    font-weight: 500;
                }

                .info-item span {
                    color: #1f2937;
                    font-weight: 600;
                }

                .activities-list {
                    max-height: 150px;
                    overflow-y: auto;
                }

                .activity-item {
                    display: flex;
                    align-items: center;
                    gap: 12px;
                    padding: 10px 0;
                    border-bottom: 1px solid #e5e7eb;
                }

                .activity-item:last-child {
                    border-bottom: none;
                }

                .activity-item i {
                    color: #2563eb;
                    width: 16px;
                }

                .activity-item span {
                    flex: 1;
                    font-size: 14px;
                    color: #374151;
                }

                .activity-item time {
                    font-size: 12px;
                    color: #6b7280;
                }

                .dropdown-footer {
                    padding: 20px;
                    border-top: 1px solid #e5e7eb;
                }

                .footer-actions {
                    display: flex;
                    gap: 10px;
                    justify-content: space-between;
                }

                .btn-secondary, .btn-primary {
                    padding: 10px 20px;
                    border: none;
                    border-radius: 8px;
                    cursor: pointer;
                    font-weight: 500;
                    display: flex;
                    align-items: center;
                    gap: 8px;
                    transition: all 0.3s ease;
                    font-size: 14px;
                }

                .btn-secondary {
                    background: #f3f4f6;
                    color: #374151;
                }

                .btn-secondary:hover {
                    background: #e5e7eb;
                }

                .btn-primary {
                    background: #2563eb;
                    color: white;
                }

                .btn-primary:hover {
                    background: #1d4ed8;
                }

                /* Mobile Responsive */
                @media (max-width: 480px) {
                    .floating-dropdown {
                        width: calc(100vw - 40px);
                        max-width: 350px;
                    }

                    .quick-actions-grid {
                        grid-template-columns: 1fr;
                    }

                    .system-info-grid {
                        grid-template-columns: 1fr;
                    }
                }

                /* Dark Mode Support */
                @media (prefers-color-scheme: dark) {
                    .floating-dropdown {
                        background: rgba(17, 24, 39, 0.95);
                        color: white;
                    }

                    .mega-menu-content h4 {
                        color: #f9fafb;
                    }

                    .quick-action {
                        background: #374151;
                        color: #f9fafb;
                    }

                    .quick-action:hover {
                        background: #4b5563;
                    }

                    .info-item {
                        background: #374151;
                    }

                    .info-item label {
                        color: #9ca3af;
                    }

                    .info-item span {
                        color: #f9fafb;
                    }

                    .activity-item span {
                        color: #f9fafb;
                    }

                    .dropdown-footer {
                        border-top-color: #374151;
                    }
                }
            </style>
        `;

        // Remove existing styles
        const existingStyles = document.getElementById('floating-user-info-styles');
        if (existingStyles) existingStyles.remove();

        // Add new styles
        document.head.insertAdjacentHTML('beforeend', styles);
    }

    setupEventListeners() {
        document.addEventListener('click', (e) => {
            const container = document.getElementById('floating-user-info');
            const trigger = document.getElementById('userInfoTrigger');
            
            if (trigger && trigger.contains(e.target)) {
                this.toggleDropdown();
            } else if (container && !container.contains(e.target)) {
                this.closeDropdown();
            }
        });

        // Quick actions
        document.addEventListener('click', (e) => {
            if (e.target.closest('.quick-action')) {
                const action = e.target.closest('.quick-action').dataset.action;
                this.handleQuickAction(action);
            }
        });

        // Language change
        document.addEventListener('click', (e) => {
            if (e.target.closest('#changeLanguage')) {
                this.toggleLanguage();
            }
        });

        // Logout
        document.addEventListener('click', (e) => {
            if (e.target.closest('#logoutBtn')) {
                this.handleLogout();
            }
        });

        // ESC key to close
        document.addEventListener('keydown', (e) => {
            if (e.key === 'Escape') {
                this.closeDropdown();
            }
        });
    }

    toggleDropdown() {
        const container = document.getElementById('floating-user-info');
        this.isExpanded = !this.isExpanded;
        
        if (this.isExpanded) {
            container.classList.add('expanded');
        } else {
            container.classList.remove('expanded');
        }
    }

    closeDropdown() {
        const container = document.getElementById('floating-user-info');
        this.isExpanded = false;
        container.classList.remove('expanded');
    }

    loadUserData() {
        console.log('📊 [FloatingUserInfo] Loading user data...');
        
        // Get user data from ASP.NET membership system
        try {
            const membershipData = this.getMembershipData();
            console.log('📋 [FloatingUserInfo] Membership data retrieved:', membershipData);
            this.updateUserDisplay(membershipData);
        } catch (error) {
            console.log('⚠️ [FloatingUserInfo] Using default user data due to error:', error);
            this.updateUserDisplay({
                name: this.isRTL ? 'مستخدم النظام' : 'System User',
                email: 'user@system.com',
                role: this.isRTL ? 'مدير' : 'Administrator',
                loginTime: new Date().toLocaleTimeString()
            });
        }
        
        console.log('✅ [FloatingUserInfo] User data loading completed');
    }

    getMembershipData() {
        // Try to get data from ASP.NET controls
        const membershipBar = document.querySelector('[id*="mb"]');
        if (membershipBar) {
            // Extract user info from membership bar
            return this.extractUserFromMembershipBar();
        }
        
        // Try to get from server variables
        if (typeof __userInfo !== 'undefined') {
            return __userInfo;
        }

        return null;
    }

    extractUserFromMembershipBar() {
        // This would extract user info from the existing membership bar
        return {
            name: this.isRTL ? 'المستخدم الحالي' : 'Current User',
            email: 'user@erp.com',
            role: this.isRTL ? 'مدير النظام' : 'System Admin',
            loginTime: new Date().toLocaleTimeString()
        };
    }

    updateUserDisplay(userData) {
        document.getElementById('userName').textContent = userData.name;
        document.getElementById('userRole').textContent = userData.role;
        document.getElementById('userFullName').textContent = userData.name;
        document.getElementById('userEmail').textContent = userData.email;
        document.getElementById('loginTime').textContent = userData.loginTime;
        document.getElementById('userPermissions').textContent = userData.role;
    }

    handleQuickAction(action) {
        console.log(`Quick action: ${action}`);
        
        switch (action) {
            case 'profile':
                window.location.href = this.isRTL ? '/Pages/UserProfile.aspx' : '/Pages/UserProfile.aspx';
                break;
            case 'settings':
                window.location.href = '/Pages/Settings.aspx';
                break;
            case 'notifications':
                this.showNotifications();
                break;
            case 'help':
                window.open('/Help/index.html', '_blank');
                break;
        }
    }

    toggleLanguage() {
        // This would trigger language change in the application
        const newLang = this.isRTL ? 'en' : 'ar';
        window.location.href = `${window.location.pathname}?lang=${newLang}`;
    }

    handleLogout() {
        if (confirm(this.isRTL ? 'هل تريد تسجيل الخروج؟' : 'Are you sure you want to logout?')) {
            window.location.href = '/Login.aspx?logout=true';
        }
    }

    showNotifications() {
        // Implementation for notifications popup
        alert(this.isRTL ? 'قريباً: نظام الإشعارات' : 'Coming Soon: Notifications System');
    }
}

// Initialize when DOM is ready
document.addEventListener('DOMContentLoaded', function() {
    console.log('🚀 [FloatingUserInfo] DOM Content Loaded - initializing system');
    console.log('🌍 [FloatingUserInfo] Document language:', document.documentElement.lang);
    console.log('📍 [FloatingUserInfo] Document direction:', document.documentElement.dir);
    
    // Hide existing membership_login div if exists
    const membershipLogin = document.getElementById('membership_login') || 
                           document.querySelector('[id*="membership"]') ||
                           document.querySelector('.membership-login');
    
    if (membershipLogin) {
        membershipLogin.style.display = 'none';
        console.log('✅ [FloatingUserInfo] Hidden existing membership div:', membershipLogin);
        console.log('🔧 [FloatingUserInfo] Display style set to:', window.getComputedStyle(membershipLogin).display);
    } else {
        console.log('ℹ️ [FloatingUserInfo] No existing membership_login div found (this is normal)');
    }

    // Initialize floating user info system
    try {
        window.floatingUserInfo = new FloatingUserInfoSystem();
        console.log('✅ [FloatingUserInfo] System initialized successfully');
        console.log('📊 [FloatingUserInfo] FloatingUserInfo object:', window.floatingUserInfo);
    } catch (error) {
        console.error('❌ [FloatingUserInfo] Initialization failed:', error);
    }
});

// Export for global access
if (typeof module !== 'undefined' && module.exports) {
    module.exports = FloatingUserInfoSystem;
}
