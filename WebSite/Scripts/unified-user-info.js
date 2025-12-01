/**
 * 🎯 Unified User Info System - نظام معلومات المستخدم الموحد
 * Purpose: Extract data from MembershipBar and create single dropdown system
 * Features: LocalStorage/Session caching, Roles integration, Security optimized
 */

class UnifiedUserInfoSystem {
    constructor() {
        console.log('🎯 [UnifiedUserInfo] Initializing unified user info system');
        
        this.isRTL = document.documentElement.dir === 'rtl' || document.documentElement.lang.includes('ar');
        this.currentLanguage = document.documentElement.lang || 'en';
        this.isExpanded = false;
        this.userData = null;
        this.storageKey = 'SASERP_UserInfo';
        this.sessionTimeout = 30 * 60 * 1000; // 30 minutes
        
        console.log('🌍 [UnifiedUserInfo] Language settings:', {
            isRTL: this.isRTL,
            currentLanguage: this.currentLanguage,
            dir: document.documentElement.dir,
            lang: document.documentElement.lang
        });
        
        this.init();
    }

    init() {
        console.log('🔧 [UnifiedUserInfo] Starting initialization...');
        
        // Wait for MembershipBar to be ready
        this.waitForMembershipBar().then(() => {
            console.log('✅ [UnifiedUserInfo] MembershipBar ready, proceeding with setup');
            this.extractMembershipData();
            this.createUnifiedContainer();
            this.setupEventListeners();
            this.applyStyling();
            this.hideOriginalWidgets();
        }).catch((error) => {
            console.error('❌ [UnifiedUserInfo] MembershipBar not found, using fallback', error);
            this.createFallbackData();
            this.createUnifiedContainer();
            this.setupEventListeners();
            this.applyStyling();
        });
    }

    waitForMembershipBar() {
        return new Promise((resolve, reject) => {
            let attempts = 0;
            const maxAttempts = 50; // 5 seconds
            
            const checkMembership = () => {
                attempts++;
                
                // Check for Web.Membership instance
                if (typeof Web !== 'undefined' && Web.Membership && Web.Membership._instance) {
                    console.log('✅ [UnifiedUserInfo] Web.Membership._instance found');
                    resolve(Web.Membership._instance);
                    return;
                }
                
                // Check for MembershipBar element
                const membershipBar = document.getElementById('Membership_Login') || 
                                    document.querySelector('.MembershipBar') ||
                                    document.querySelector('[id*="mb"]');
                
                if (membershipBar) {
                    console.log('✅ [UnifiedUserInfo] MembershipBar element found:', membershipBar);
                    resolve(membershipBar);
                    return;
                }
                
                if (attempts >= maxAttempts) {
                    reject(new Error('MembershipBar not found after maximum attempts'));
                    return;
                }
                
                setTimeout(checkMembership, 100);
            };
            
            checkMembership();
        });
    }

    extractMembershipData() {
        console.log('📊 [UnifiedUserInfo] Extracting membership data...');
        
        let userData = this.loadFromCache();
        if (userData && this.isDataValid(userData)) {
            console.log('📋 [UnifiedUserInfo] Using cached user data:', userData);
            this.userData = userData;
            return;
        }
        
        // Extract from Web.Membership if available
        if (typeof Web !== 'undefined' && Web.Membership && Web.Membership._instance) {
            const membership = Web.Membership._instance;
            
            userData = {
                name: this.extractUserName(membership),
                email: this.extractUserEmail(membership),
                roles: this.extractUserRoles(membership),
                isAuthenticated: membership.get_isAuthenticated ? membership.get_isAuthenticated() : false,
                loginTime: new Date().toLocaleTimeString(),
                sessionId: this.extractSessionId(),
                lastActivity: new Date().toISOString(),
                language: this.currentLanguage,
                isRTL: this.isRTL
            };
        } else {
            userData = this.createFallbackData();
        }
        
        console.log('📋 [UnifiedUserInfo] Extracted user data:', userData);
        this.userData = userData;
        this.saveToCache(userData);
    }

    extractUserName(membership) {
        try {
            // Try different methods to get user name
            if (membership._userName && membership._userName.value) {
                return membership._userName.value;
            }
            
            if (membership.get_userName && typeof membership.get_userName === 'function') {
                return membership.get_userName();
            }
            
            // Look for user name in DOM
            const userElements = document.querySelectorAll('[id*="user"], [class*="user"], [data-user]');
            for (let element of userElements) {
                if (element.textContent && element.textContent.trim()) {
                    return element.textContent.trim();
                }
            }
            
            return this.isRTL ? 'مستخدم النظام' : 'System User';
        } catch (error) {
            console.warn('⚠️ [UnifiedUserInfo] Error extracting user name:', error);
            return this.isRTL ? 'مستخدم النظام' : 'System User';
        }
    }

    extractUserEmail(membership) {
        try {
            // Try to get email from membership
            if (membership.get_userEmail && typeof membership.get_userEmail === 'function') {
                return membership.get_userEmail();
            }
            
            // Look for email in DOM
            const emailElements = document.querySelectorAll('[id*="email"], [class*="email"], input[type="email"]');
            for (let element of emailElements) {
                if (element.value && element.value.includes('@')) {
                    return element.value;
                }
            }
            
            return 'user@saserp.com';
        } catch (error) {
            console.warn('⚠️ [UnifiedUserInfo] Error extracting user email:', error);
            return 'user@saserp.com';
        }
    }

    extractUserRoles(membership) {
        try {
            // Try to get roles from membership
            if (membership.get_roles && typeof membership.get_roles === 'function') {
                return membership.get_roles();
            }
            
            // Try to get from global variables
            if (typeof __userRoles !== 'undefined') {
                return __userRoles;
            }
            
            // Default roles based on authentication
            const isAuth = membership.get_isAuthenticated ? membership.get_isAuthenticated() : false;
            return isAuth ? ['User'] : ['Anonymous'];
        } catch (error) {
            console.warn('⚠️ [UnifiedUserInfo] Error extracting user roles:', error);
            return ['User'];
        }
    }

    extractSessionId() {
        try {
            // Try to get session ID from various sources
            if (typeof __sessionId !== 'undefined') {
                return __sessionId;
            }
            
            // Generate a temporary session ID
            return 'temp_' + Math.random().toString(36).substr(2, 9);
        } catch (error) {
            return 'unknown';
        }
    }

    createFallbackData() {
        console.log('🔄 [UnifiedUserInfo] Creating fallback user data');
        
        return {
            name: this.isRTL ? 'مستخدم تجريبي' : 'Demo User',
            email: 'demo@saserp.com',
            roles: ['Administrator'],
            isAuthenticated: true,
            loginTime: new Date().toLocaleTimeString(),
            sessionId: 'demo_session',
            lastActivity: new Date().toISOString(),
            language: this.currentLanguage,
            isRTL: this.isRTL
        };
    }

    loadFromCache() {
        try {
            const cached = localStorage.getItem(this.storageKey);
            if (cached) {
                console.log('📦 [UnifiedUserInfo] Found cached data');
                return JSON.parse(cached);
            }
        } catch (error) {
            console.warn('⚠️ [UnifiedUserInfo] Error loading from cache:', error);
        }
        return null;
    }

    saveToCache(userData) {
        try {
            localStorage.setItem(this.storageKey, JSON.stringify(userData));
            console.log('💾 [UnifiedUserInfo] Data saved to cache');
        } catch (error) {
            console.warn('⚠️ [UnifiedUserInfo] Error saving to cache:', error);
        }
    }

    isDataValid(userData) {
        if (!userData || !userData.lastActivity) return false;
        
        const lastActivity = new Date(userData.lastActivity);
        const now = new Date();
        const timeDiff = now - lastActivity;
        
        const isValid = timeDiff < this.sessionTimeout;
        console.log('🔍 [UnifiedUserInfo] Cache validity check:', {
            timeDiff: timeDiff,
            maxTimeout: this.sessionTimeout,
            isValid: isValid
        });
        
        return isValid;
    }

    createUnifiedContainer() {
        console.log('🏗️ [UnifiedUserInfo] Creating social media bar with unified container');
        
        // Remove existing containers
        this.removeExistingContainers();
        
        // Create social bar container
        const socialBar = document.createElement('div');
        socialBar.id = 'saserp-social-bar';
        socialBar.className = `saserp-social-bar ${this.isRTL ? 'rtl-mode' : 'ltr-mode'}`;
        
        // Create navigation trigger for mobile
        const navTrigger = this.createNavTrigger();
        
        // Create user info container
        const userContainer = document.createElement('div');
        userContainer.id = 'unified-user-info';
        userContainer.className = `unified-user-container social-bar-item ${this.isRTL ? 'rtl-mode' : 'ltr-mode'}`;
        userContainer.innerHTML = this.generateContainerHTML();
        
        // Append items to social bar
        socialBar.appendChild(navTrigger);
        socialBar.appendChild(userContainer);
        
        // Add to body
        document.body.appendChild(socialBar);
        
        // Add smart positioning
        this.applySmartPositioning(userContainer);
        
        console.log('✅ [UnifiedUserInfo] Social bar created with nav trigger and user info');
        
        // Update with actual data
        this.updateDisplayData();
    }

    createNavTrigger() {
        const navTrigger = document.createElement('button');
        navTrigger.className = 'social-bar-nav-trigger social-bar-item saserp-mobile-nav-toggle';
        navTrigger.innerHTML = `
            <div class="nav-icon">
                <i class="fas fa-bars"></i>
            </div>
        `;
        
        // Add click handler for navigation
        navTrigger.addEventListener('click', (e) => {
            e.preventDefault();
            e.stopPropagation();
            
            // Call the global navigation toggle function
            if (typeof toggleNavMenu === 'function') {
                toggleNavMenu();
            } else {
                console.warn('⚠️ [SocialBar] toggleNavMenu function not found');
            }
        });
        
        console.log('🎯 [UnifiedUserInfo] Navigation trigger created');
        return navTrigger;
    }

    createUserInfoContainer() {
        const userContainer = document.createElement('div');
        userContainer.className = 'unified-user-container social-bar-item';
        userContainer.innerHTML = this.generateContainerHTML();
        
        // Add event listeners
        const userTrigger = userContainer.querySelector('#userTrigger');
        const userDropdown = userContainer.querySelector('#userDropdown');
        
        if (userTrigger) {
            userTrigger.addEventListener('click', (e) => {
                e.preventDefault();
                e.stopPropagation();
                this.toggleDropdown();
            });
        }
        
        // Add click handlers for dropdown items
        // this.addDropdownHandlers(userContainer);
        
        console.log('👤 [UnifiedUserInfo] User info container created');
        return userContainer;
    }

    applySmartPositioning(container) {
        // Check container position relative to screen
        const rect = container.getBoundingClientRect();
        const screenWidth = window.innerWidth;
        const dropdownWidth = 500; // width of dropdown
        
        // If container is near right edge, open dropdown to the left
        if (rect.right + dropdownWidth > screenWidth - 20) {
            container.classList.add('near-right-edge');
            console.log('📍 [UnifiedUserInfo] Applied near-right-edge positioning');
        } else {
            container.classList.add('near-left-edge');
            console.log('📍 [UnifiedUserInfo] Applied near-left-edge positioning');
        }
        
        // Re-check on window resize
        window.addEventListener('resize', () => {
            this.applySmartPositioning(container);
        });
    }

    removeExistingContainers() {
        // Remove existing social bar
        const existingSocialBar = document.getElementById('saserp-social-bar');
        if (existingSocialBar) {
            console.log('🗑️ [UnifiedUserInfo] Removed existing social bar');
            existingSocialBar.remove();
        }
        
        // Remove floating user info
        const existingFloating = document.getElementById('floating-user-info');
        if (existingFloating) {
            console.log('🗑️ [UnifiedUserInfo] Removed existing floating container');
            existingFloating.remove();
        }
        
        // Remove any other user info widgets
        const existingUnified = document.getElementById('unified-user-info');
        if (existingUnified) {
            existingUnified.remove();
        }
        
        // Hide original membership bar
        const membershipBar = document.getElementById('Membership_Login');
        if (membershipBar) {
            membershipBar.style.display = 'none';
            console.log('🙈 [UnifiedUserInfo] Hidden original membership bar');
        }
    }

    generateContainerHTML() {
        const userData = this.userData || {};
        const primaryRole = Array.isArray(userData.roles) ? userData.roles[0] : 'User';
        
        return `
            <div class="user-trigger" id="userTrigger">
                <div class="user-avatar">
                    <i class="fas fa-user-circle"></i>
                </div>
                <div class="user-info">
                    <span class="user-name">${userData.name || (this.isRTL ? 'مستخدم' : 'User')}</span>
                    <span class="user-role">${this.translateRole(primaryRole)}</span>
                </div>
                <div class="dropdown-arrow">
                    <i class="fas fa-chevron-down"></i>
                </div>
            </div>

            <div class="user-dropdown" id="userDropdown">
                <div class="dropdown-header">
                    <div class="user-profile">
                        <div class="user-avatar-large">
                            <i class="fas fa-user-circle"></i>
                        </div>
                        <div class="user-details">
                            <h3 class="user-full-name">${userData.name || (this.isRTL ? 'اسم المستخدم' : 'User Name')}</h3>
                            <p class="user-email">${userData.email || 'user@example.com'}</p>
                            <span class="user-status ${userData.isAuthenticated ? 'online' : 'offline'}">
                                ${userData.isAuthenticated ? 
                                  (this.isRTL ? 'متصل الآن' : 'Online Now') : 
                                  (this.isRTL ? 'غير متصل' : 'Offline')}
                            </span>
                        </div>
                    </div>
                </div>

                <div class="dropdown-content">
                    <div class="info-section">
                        <h4><i class="fas fa-info-circle"></i> ${this.isRTL ? 'معلومات الجلسة' : 'Session Info'}</h4>
                        <div class="info-grid">
                            <div class="info-item">
                                <label>${this.isRTL ? 'وقت الدخول:' : 'Login Time:'}</label>
                                <span>${userData.loginTime || '--:--'}</span>
                            </div>
                            <div class="info-item">
                                <label>${this.isRTL ? 'الجلسة:' : 'Session:'}</label>
                                <span>${userData.sessionId || 'N/A'}</span>
                            </div>
                            <div class="info-item">
                                <label>${this.isRTL ? 'اللغة:' : 'Language:'}</label>
                                <span>${this.isRTL ? 'العربية' : 'English'}</span>
                            </div>
                            <div class="info-item">
                                <label>${this.isRTL ? 'الصلاحيات:' : 'Roles:'}</label>
                                <span>${this.formatRoles(userData.roles)}</span>
                            </div>
                        </div>
                    </div>

                    <div class="actions-section">
                        <h4><i class="fas fa-cog"></i> ${this.isRTL ? 'الإجراءات' : 'Actions'}</h4>
                        <div class="actions-grid">
                            <button class="action-btn" data-action="profile">
                                <i class="fas fa-user-edit"></i>
                                <span>${this.isRTL ? 'الملف الشخصي' : 'Profile'}</span>
                            </button>
                            <button class="action-btn" data-action="settings">
                                <i class="fas fa-cog"></i>
                                <span>${this.isRTL ? 'الإعدادات' : 'Settings'}</span>
                            </button>
                            <button class="action-btn" data-action="refresh">
                                <i class="fas fa-sync-alt"></i>
                                <span>${this.isRTL ? 'تحديث البيانات' : 'Refresh Data'}</span>
                            </button>
                            <button class="action-btn" data-action="language">
                                <i class="fas fa-language"></i>
                                <span>${this.isRTL ? 'English' : 'العربية'}</span>
                            </button>
                        </div>
                    </div>
                </div>

                <div class="dropdown-footer">
                    <button class="logout-btn" data-action="logout">
                        <i class="fas fa-sign-out-alt"></i>
                        <span>${this.isRTL ? 'تسجيل خروج' : 'Logout'}</span>
                    </button>
                </div>
            </div>
        `;
    }

    translateRole(role) {
        if (!this.isRTL) return role;
        
        const translations = {
            'Administrator': 'مدير النظام',
            'Admin': 'مدير',
            'User': 'مستخدم',
            'Manager': 'مدير',
            'Employee': 'موظف',
            'Guest': 'زائر'
        };
        
        return translations[role] || role;
    }

    formatRoles(roles) {
        if (!Array.isArray(roles)) return 'N/A';
        if (this.isRTL) {
            return roles.map(role => this.translateRole(role)).join('، ');
        }
        return roles.join(', ');
    }

    updateDisplayData() {
        if (!this.userData) return;
        
        console.log('🔄 [UnifiedUserInfo] Updating display with data:', this.userData);
        
        const container = document.getElementById('unified-user-info');
        if (!container) return;
        
        // Update trigger
        const userName = container.querySelector('.user-name');
        const userRole = container.querySelector('.user-role');
        
        if (userName) userName.textContent = this.userData.name;
        if (userRole) userRole.textContent = this.translateRole(Array.isArray(this.userData.roles) ? this.userData.roles[0] : 'User');
        
        // Update dropdown content
        const fullName = container.querySelector('.user-full-name');
        const email = container.querySelector('.user-email');
        
        if (fullName) fullName.textContent = this.userData.name;
        if (email) email.textContent = this.userData.email;
        
        console.log('✅ [UnifiedUserInfo] Display updated successfully');
    }

    setupEventListeners() {
        console.log('⚙️ [UnifiedUserInfo] Setting up event listeners');
        
        document.addEventListener('click', (e) => {
            const container = document.getElementById('unified-user-info');
            const trigger = document.getElementById('userTrigger');
            
            if (trigger && trigger.contains(e.target)) {
                this.toggleDropdown();
            } else if (container && !container.contains(e.target)) {
                this.closeDropdown();
            }
            
            // Handle action buttons
            if (e.target.closest('.action-btn, .logout-btn')) {
                const action = e.target.closest('.action-btn, .logout-btn').dataset.action;
                this.handleAction(action);
            }
        });
        
        // ESC key to close
        document.addEventListener('keydown', (e) => {
            if (e.key === 'Escape') {
                this.closeDropdown();
            }
        });
        
        console.log('✅ [UnifiedUserInfo] Event listeners setup completed');
    }

    toggleDropdown() {
        const container = document.getElementById('unified-user-info');
        this.isExpanded = !this.isExpanded;
        
        if (this.isExpanded) {
            container.classList.add('expanded');
            console.log('📂 [UnifiedUserInfo] Dropdown expanded');
        } else {
            container.classList.remove('expanded');
            console.log('📁 [UnifiedUserInfo] Dropdown collapsed');
        }
    }

    closeDropdown() {
        const container = document.getElementById('unified-user-info');
        this.isExpanded = false;
        container.classList.remove('expanded');
    }

    handleAction(action) {
        console.log('🎯 [UnifiedUserInfo] Handling action:', action);
        
        switch (action) {
            case 'profile':
                window.location.href = '/Pages/UserProfile.aspx';
                break;
            case 'settings':
                window.location.href = '/Pages/Settings.aspx';
                break;
            case 'refresh':
                this.refreshUserData();
                break;
            case 'language':
                this.toggleLanguage();
                break;
            case 'logout':
                this.handleLogout();
                break;
        }
    }

    refreshUserData() {
        console.log('🔄 [UnifiedUserInfo] Refreshing user data');
        localStorage.removeItem(this.storageKey);
        this.extractMembershipData();
        this.updateDisplayData();
    }

    toggleLanguage() {
        const newLang = this.isRTL ? 'en' : 'ar';
        window.location.href = `${window.location.pathname}?lang=${newLang}`;
    }

    handleLogout() {
        if (confirm(this.isRTL ? 'هل تريد تسجيل الخروج؟' : 'Are you sure you want to logout?')) {
            localStorage.removeItem(this.storageKey);
            
            // Try Web.Membership logout first
            if (typeof Web !== 'undefined' && Web.Membership && Web.Membership._instance) {
                Web.Membership._instance.logout();
            } else {
                window.location.href = '/Login.aspx?logout=true';
            }
        }
    }

    // ========================================
    // 🎯 MASTER PROMPT MENU SYSTEM
    // نظام القائمة الرئيسية الموحدة
    // ========================================

    createMasterPromptTrigger() {
        console.log('🎯 [UnifiedUserInfo] Creating master prompt trigger');
        
        const trigger = document.createElement('div');
        trigger.className = 'master-prompt-trigger';
        trigger.id = 'master-prompt-trigger';
        
        trigger.innerHTML = `
            <i class="fas fa-th-large trigger-icon"></i>
            <span style="display: none;">القائمة الرئيسية</span>
        `;
        
        // Add click handler
        trigger.addEventListener('click', (e) => {
            e.stopPropagation();
            this.toggleMasterPromptMenu();
        });
        
        return trigger;
    }

    createMasterPromptMenu() {
        console.log('🎯 [UnifiedUserInfo] Creating master prompt menu');
        
        const menu = document.createElement('div');
        menu.className = 'master-prompt-menu';
        menu.id = 'master-prompt-menu';
        
        menu.innerHTML = `
            <div class="prompt-menu-header">
                <div class="prompt-menu-title">🚀 لوحة التحكم الرئيسية</div>
                <div class="prompt-menu-subtitle">جميع الأدوات والقوائم في مكان واحد</div>
            </div>
            
            <div class="prompt-sections">
                ${this.createNavigationSection()}
                ${this.createUserSection()}
                ${this.createToolsSection()}
                ${this.createSystemSection()}
            </div>
        `;
        
        return menu;
    }

    createNavigationSection() {
        return `
            <div class="prompt-section">
                <div class="section-title">
                    <i class="fas fa-compass section-icon"></i>
                    التنقل والصفحات
                </div>
                <div class="prompt-item" onclick="window.open('/Default.aspx', '_blank')">
                    <div class="prompt-item-icon"><i class="fas fa-home"></i></div>
                    <div class="prompt-item-content">
                        <div class="prompt-item-title">الصفحة الرئيسية</div>
                        <div class="prompt-item-desc">العودة للوحة الرئيسية</div>
                    </div>
                </div>
                <div class="prompt-item" onclick="window.open('/navigation-hub.html', '_blank')">
                    <div class="prompt-item-icon"><i class="fas fa-sitemap"></i></div>
                    <div class="prompt-item-content">
                        <div class="prompt-item-title">مركز التنقل</div>
                        <div class="prompt-item-desc">جميع صفحات النظام</div>
                    </div>
                </div>
                <div class="prompt-item" onclick="window.open('/MenuDemo.aspx', '_blank')">
                    <div class="prompt-item-icon"><i class="fas fa-bars"></i></div>
                    <div class="prompt-item-content">
                        <div class="prompt-item-title">عرض القوائم</div>
                        <div class="prompt-item-desc">تجربة أنظمة القوائم</div>
                    </div>
                </div>
            </div>
        `;
    }

    createUserSection() {
        return `
            <div class="prompt-section">
                <div class="section-title">
                    <i class="fas fa-user-circle section-icon"></i>
                    المستخدم والحساب
                </div>
                <div class="prompt-item" onclick="this.showUserInfo()">
                    <div class="prompt-item-icon"><i class="fas fa-id-card"></i></div>
                    <div class="prompt-item-content">
                        <div class="prompt-item-title">معلومات المستخدم</div>
                        <div class="prompt-item-desc">عرض بيانات الحساب</div>
                    </div>
                </div>
                <div class="prompt-item" onclick="this.changeLanguage()">
                    <div class="prompt-item-icon"><i class="fas fa-language"></i></div>
                    <div class="prompt-item-content">
                        <div class="prompt-item-title">تغيير اللغة</div>
                        <div class="prompt-item-desc">عربي / English</div>
                    </div>
                </div>
                <div class="prompt-item" onclick="this.logout()">
                    <div class="prompt-item-icon"><i class="fas fa-sign-out-alt"></i></div>
                    <div class="prompt-item-content">
                        <div class="prompt-item-title">تسجيل الخروج</div>
                        <div class="prompt-item-desc">إنهاء الجلسة</div>
                    </div>
                </div>
            </div>
        `;
    }

    createToolsSection() {
        return `
            <div class="prompt-section">
                <div class="section-title">
                    <i class="fas fa-tools section-icon"></i>
                    الأدوات والاختبارات
                </div>
                <div class="prompt-item" onclick="window.open('/full-width-test.aspx', '_blank')">
                    <div class="prompt-item-icon"><i class="fas fa-expand-arrows-alt"></i></div>
                    <div class="prompt-item-content">
                        <div class="prompt-item-title">اختبار العرض</div>
                        <div class="prompt-item-desc">مراقب عرض الصفحة</div>
                    </div>
                </div>
                <div class="prompt-item" onclick="window.open('/social-bar-test.html', '_blank')">
                    <div class="prompt-item-icon"><i class="fas fa-share-alt"></i></div>
                    <div class="prompt-item-content">
                        <div class="prompt-item-title">اختبار الشريط</div>
                        <div class="prompt-item-desc">اختبار الشريط الاجتماعي</div>
                    </div>
                </div>
                <div class="prompt-item" onclick="window.open('/modern-cards.html', '_blank')">
                    <div class="prompt-item-icon"><i class="fas fa-th-large"></i></div>
                    <div class="prompt-item-content">
                        <div class="prompt-item-title">البطاقات الحديثة</div>
                        <div class="prompt-item-desc">عرض البطاقات المتقدمة</div>
                    </div>
                </div>
            </div>
        `;
    }

    createSystemSection() {
        return `
            <div class="prompt-section">
                <div class="section-title">
                    <i class="fas fa-cog section-icon"></i>
                    النظام والإعدادات
                </div>
                <div class="prompt-item" onclick="window.open('/system-ready.html', '_blank')">
                    <div class="prompt-item-icon"><i class="fas fa-check-circle"></i></div>
                    <div class="prompt-item-content">
                        <div class="prompt-item-title">حالة النظام</div>
                        <div class="prompt-item-desc">تقرير النظام المحدث</div>
                    </div>
                </div>
                <div class="prompt-item" onclick="this.toggleDebugMode()">
                    <div class="prompt-item-icon"><i class="fas fa-bug"></i></div>
                    <div class="prompt-item-content">
                        <div class="prompt-item-title">وضع التصحيح</div>
                        <div class="prompt-item-desc">تفعيل/إلغاء التصحيح</div>
                    </div>
                </div>
                <div class="prompt-item" onclick="this.refreshSystem()">
                    <div class="prompt-item-icon"><i class="fas fa-sync-alt"></i></div>
                    <div class="prompt-item-content">
                        <div class="prompt-item-title">تحديث النظام</div>
                        <div class="prompt-item-desc">إعادة تحميل المكونات</div>
                    </div>
                </div>
            </div>
        `;
    }

    updateSocialBarWithMasterPrompt() {
        console.log('🔄 [UnifiedUserInfo] Updating social bar with master prompt');
        
        // Remove existing containers
        this.removeExistingContainers();
        
        // Create new unified container with master prompt
        const container = document.createElement('div');
        container.className = `saserp-social-bar ${this.isRTL ? 'rtl-mode' : 'ltr-mode'}`;
        container.id = 'saserp-social-bar';
        
        // Add master prompt trigger
        const masterTrigger = this.createMasterPromptTrigger();
        const masterMenu = this.createMasterPromptMenu();
        
        // Create wrapper for trigger and menu
        const masterWrapper = document.createElement('div');
        masterWrapper.style.position = 'relative';
        masterWrapper.appendChild(masterTrigger);
        masterWrapper.appendChild(masterMenu);
        
        container.appendChild(masterWrapper);
        
        // Add navigation trigger (for mobile)
        const navTrigger = this.createNavTrigger();
        container.appendChild(navTrigger);
        
        // Add user info container
        const userContainer = this.createUserInfoContainer();
        container.appendChild(userContainer);
        
        document.body.appendChild(container);
        
        console.log('✅ [UnifiedUserInfo] Social bar updated with master prompt system');
    }

    toggleMasterPromptMenu() {
        console.log('🎯 [UnifiedUserInfo] Toggling master prompt menu');
        
        const menu = document.getElementById('master-prompt-menu');
        if (menu) {
            const isActive = menu.classList.contains('active');
            
            if (isActive) {
                menu.classList.remove('active');
                console.log('🔒 [UnifiedUserInfo] Master prompt menu closed');
            } else {
                // Close other menus first
                this.closeAllMenus();
                menu.classList.add('active');
                console.log('🔓 [UnifiedUserInfo] Master prompt menu opened');
            }
        }
    }

    closeAllMenus() {
        // Close master prompt menu
        const masterMenu = document.getElementById('master-prompt-menu');
        if (masterMenu) {
            masterMenu.classList.remove('active');
        }
        
        // Close user dropdown
        const userDropdown = document.querySelector('.user-dropdown');
        if (userDropdown) {
            userDropdown.classList.remove('active');
        }
        
        this.isExpanded = false;
        console.log('🔒 [UnifiedUserInfo] All menus closed');
    }

    // Master Prompt Menu Action Handlers
    showUserInfo() {
        console.log('👤 [UnifiedUserInfo] Showing user info');
        this.closeAllMenus();
        this.toggleUserMenu();
    }

    changeLanguage() {
        console.log('🌍 [UnifiedUserInfo] Changing language');
        this.closeAllMenus();
        
        const currentLang = document.documentElement.lang;
        const newLang = currentLang.includes('ar') ? 'en' : 'ar';
        const newDir = newLang === 'ar' ? 'rtl' : 'ltr';
        
        document.documentElement.lang = newLang;
        document.documentElement.dir = newDir;
        
        // Refresh the page to apply language changes
        setTimeout(() => {
            window.location.reload();
        }, 500);
    }

    toggleDebugMode() {
        console.log('🐛 [UnifiedUserInfo] Toggling debug mode');
        this.closeAllMenus();
        
        const debugMode = localStorage.getItem('SASERP_DebugMode') === 'true';
        const newDebugMode = !debugMode;
        
        localStorage.setItem('SASERP_DebugMode', newDebugMode.toString());
        
        if (newDebugMode) {
            console.log('🔧 [UnifiedUserInfo] Debug mode enabled');
            document.body.classList.add('debug-mode');
        } else {
            console.log('🔧 [UnifiedUserInfo] Debug mode disabled');
            document.body.classList.remove('debug-mode');
        }
    }

    refreshSystem() {
        console.log('🔄 [UnifiedUserInfo] Refreshing system');
        this.closeAllMenus();
        
        // Clear cache
        localStorage.removeItem(this.storageKey);
        
        // Reinitialize
        setTimeout(() => {
            window.location.reload();
        }, 500);
    }

    createUnifiedContainer() {
        console.log('🔧 [UnifiedUserInfo] Creating unified container with master prompt');
        this.updateSocialBarWithMasterPrompt();
    }

    hideOriginalWidgets() {
        console.log('🙈 [UnifiedUserInfo] Hiding original widgets');
        
        // Hide MembershipBar
        const membershipBar = document.getElementById('Membership_Login') || 
                             document.querySelector('.MembershipBar');
        if (membershipBar) {
            membershipBar.style.display = 'none';
            console.log('✅ [UnifiedUserInfo] MembershipBar hidden');
        }
        
        // Hide any other user info widgets
        const otherWidgets = document.querySelectorAll('[id*="membership"], [class*="membership"]');
        otherWidgets.forEach(widget => {
            if (widget.id !== 'unified-user-info') {
                widget.style.display = 'none';
            }
        });
        
        console.log('✅ [UnifiedUserInfo] Original widgets hidden');
    }

    setupEventListeners() {
        console.log('🎧 [UnifiedUserInfo] Setting up event listeners with master prompt support');
        
        // Close menus when clicking outside
        document.addEventListener('click', (e) => {
            const socialBar = document.getElementById('saserp-social-bar');
            if (socialBar && !socialBar.contains(e.target)) {
                this.closeAllMenus();
            }
        });
        
        // Handle escape key
        document.addEventListener('keydown', (e) => {
            if (e.key === 'Escape') {
                this.closeAllMenus();
            }
        });
        
        console.log('✅ [UnifiedUserInfo] Event listeners setup complete');
    }

    applyStyling() {
        // This will be handled by CSS file
        console.log('🎨 [UnifiedUserInfo] Styling applied via CSS');
    }
}

// Initialize when ready
document.addEventListener('DOMContentLoaded', function() {
    console.log('🚀 [UnifiedUserInfo] DOM ready, initializing unified system with master prompt');
    window.unifiedUserInfo = new UnifiedUserInfoSystem();
});

// Export for global access
if (typeof module !== 'undefined' && module.exports) {
    module.exports = UnifiedUserInfoSystem;
}
