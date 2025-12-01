/**
 * RESPONSIVE MENU1 JAVASCRIPT SYSTEM
 * نظام تحسين menu1 وتحويله إلى responsive
 * تطوير خاص لحل مشاكل Telerik RadMenu وتحسين الأداء
 */

(function() {
    'use strict';

    // ===== RESPONSIVE MENU1 CLASS =====
    class ResponsiveMenu1System {
        constructor() {
            this.menu = null;
            this.mobileToggle = null;
            this.isMenuOpen = false;
            this.isMobile = false;
            this.resizeTimeout = null;
            
            this.init();
        }

        init() {
            // انتظار تحميل DOM
            if (document.readyState === 'loading') {
                document.addEventListener('DOMContentLoaded', () => this.setup());
            } else {
                this.setup();
            }
        }

        setup() {
            console.log('🚀 بدء تهيئة نظام Menu1 المستجيب');
            
            // البحث عن menu1
            this.findMenuElements();
            
            // إنشاء زر الموبايل
            this.createMobileToggle();
            
            // تحسين RadMenu
            this.enhanceRadMenu();
            
            // ربط الأحداث
            this.bindEvents();
            
            // تحديد حالة الجهاز
            this.checkDeviceType();
            
            // تهيئة النظام
            this.initializeSystem();
            
            console.log('✅ تم تهيئة نظام Menu1 المستجيب بنجاح');
        }

        findMenuElements() {
            // البحث عن menu1 container
            this.menu = document.getElementById('menu1');
            
            if (!this.menu) {
                console.warn('⚠️ لم يتم العثور على menu1 container');
                return;
            }

            // البحث عن RadMenu
            this.radMenu = this.menu.querySelector('#RadMenu1') || 
                          this.menu.querySelector('.RadMenu') ||
                          document.getElementById('RadMenu1');
                          
            if (!this.radMenu) {
                console.warn('⚠️ لم يتم العثور على RadMenu1');
            }
        }

        createMobileToggle() {
            // إنشاء زر التبديل للموبايل
            this.mobileToggle = document.createElement('button');
            this.mobileToggle.className = 'menu1-mobile-toggle';
            this.mobileToggle.setAttribute('aria-label', 'فتح/إغلاق القائمة');
            this.mobileToggle.innerHTML = `
                <svg viewBox="0 0 24 24" fill="currentColor">
                    <path d="M3 12h18m-9-9v18"/>
                </svg>
            `;

            // إضافة الزر إلى الصفحة
            document.body.appendChild(this.mobileToggle);
        }

        enhanceRadMenu() {
            if (!this.radMenu) return;

            // تحسين هيكل RadMenu
            this.addAccessibilityFeatures();
            this.enhanceDropdownBehavior();
            this.addTouchSupport();
            this.optimizeForMobile();
        }

        addAccessibilityFeatures() {
            // إضافة ARIA attributes
            const menuItems = this.radMenu.querySelectorAll('.rmLink');
            menuItems.forEach((link, index) => {
                link.setAttribute('role', 'menuitem');
                link.setAttribute('tabindex', index === 0 ? '0' : '-1');
                
                // إضافة معرف فريد
                if (!link.id) {
                    link.id = `menu1-item-${index}`;
                }
            });

            // إعداد navigation بلوحة المفاتيح
            this.setupKeyboardNavigation();
        }

        setupKeyboardNavigation() {
            const menuItems = this.radMenu.querySelectorAll('.rmLink');
            let currentIndex = 0;

            menuItems.forEach((item, index) => {
                item.addEventListener('keydown', (e) => {
                    switch(e.key) {
                        case 'ArrowRight':
                            e.preventDefault();
                            currentIndex = (index + 1) % menuItems.length;
                            menuItems[currentIndex].focus();
                            break;
                        case 'ArrowLeft':
                            e.preventDefault();
                            currentIndex = (index - 1 + menuItems.length) % menuItems.length;
                            menuItems[currentIndex].focus();
                            break;
                        case 'Enter':
                        case ' ':
                            e.preventDefault();
                            item.click();
                            break;
                        case 'Escape':
                            if (this.isMenuOpen && this.isMobile) {
                                this.closeMobileMenu();
                            }
                            break;
                    }
                });
            });
        }

        enhanceDropdownBehavior() {
            // تحسين سلوك القوائم المنسدلة
            const dropdownItems = this.radMenu.querySelectorAll('.rmItem.rmHasChildren');
            
            dropdownItems.forEach(item => {
                const link = item.querySelector('.rmLink');
                const dropdown = item.querySelector('.rmGroup');
                
                if (link && dropdown) {
                    // إضافة مؤشر مرئي للقوائم المنسدلة
                    if (!link.querySelector('.dropdown-indicator')) {
                        const indicator = document.createElement('span');
                        indicator.className = 'dropdown-indicator';
                        indicator.innerHTML = '▼';
                        link.appendChild(indicator);
                    }

                    // تحسين سلوك الحوم والنقر
                    this.setupDropdownInteraction(item, link, dropdown);
                }
            });
        }

        setupDropdownInteraction(item, link, dropdown) {
            let hoverTimeout;

            // Desktop hover behavior
            item.addEventListener('mouseenter', () => {
                if (!this.isMobile) {
                    clearTimeout(hoverTimeout);
                    this.showDropdown(dropdown);
                }
            });

            item.addEventListener('mouseleave', () => {
                if (!this.isMobile) {
                    hoverTimeout = setTimeout(() => {
                        this.hideDropdown(dropdown);
                    }, 300);
                }
            });

            // Mobile click behavior
            link.addEventListener('click', (e) => {
                if (this.isMobile) {
                    e.preventDefault();
                    const isExpanded = item.classList.contains('rmExpanded');
                    
                    // إغلاق جميع القوائم المنسدلة الأخرى
                    this.closeAllDropdowns();
                    
                    if (!isExpanded) {
                        this.showDropdown(dropdown);
                        item.classList.add('rmExpanded');
                    }
                }
            });
        }

        showDropdown(dropdown) {
            dropdown.style.display = 'block';
            dropdown.style.opacity = '0';
            dropdown.style.transform = 'translateY(-10px)';
            
            // Animation
            requestAnimationFrame(() => {
                dropdown.style.transition = 'all 0.3s ease';
                dropdown.style.opacity = '1';
                dropdown.style.transform = 'translateY(0)';
            });
        }

        hideDropdown(dropdown) {
            dropdown.style.transition = 'all 0.3s ease';
            dropdown.style.opacity = '0';
            dropdown.style.transform = 'translateY(-10px)';
            
            setTimeout(() => {
                dropdown.style.display = 'none';
                dropdown.parentElement.classList.remove('rmExpanded');
            }, 300);
        }

        closeAllDropdowns() {
            const allDropdowns = this.radMenu.querySelectorAll('.rmGroup');
            const allExpandedItems = this.radMenu.querySelectorAll('.rmExpanded');
            
            allDropdowns.forEach(dropdown => this.hideDropdown(dropdown));
            allExpandedItems.forEach(item => item.classList.remove('rmExpanded'));
        }

        addTouchSupport() {
            // إضافة دعم اللمس للأجهزة التي تدعم اللمس
            if ('ontouchstart' in window) {
                const menuItems = this.radMenu.querySelectorAll('.rmLink');
                
                menuItems.forEach(item => {
                    item.addEventListener('touchstart', (e) => {
                        item.classList.add('touch-active');
                    });
                    
                    item.addEventListener('touchend', (e) => {
                        setTimeout(() => {
                            item.classList.remove('touch-active');
                        }, 150);
                    });
                });
            }
        }

        optimizeForMobile() {
            // تحسينات خاصة بالموبايل
            if (this.isMobile) {
                this.menu.classList.add('mobile-mode');
                
                // تحسين النقر للأجهزة المحمولة
                const menuItems = this.radMenu.querySelectorAll('.rmLink');
                menuItems.forEach(item => {
                    item.style.touchAction = 'manipulation';
                });
            } else {
                this.menu.classList.remove('mobile-mode');
            }
        }

        bindEvents() {
            // ربط أحداث زر التبديل
            if (this.mobileToggle) {
                this.mobileToggle.addEventListener('click', () => {
                    this.toggleMobileMenu();
                });
            }

            // ربط أحداث تغيير حجم النافذة
            window.addEventListener('resize', () => {
                clearTimeout(this.resizeTimeout);
                this.resizeTimeout = setTimeout(() => {
                    this.handleResize();
                }, 250);
            });

            // إغلاق القائمة عند النقر خارجها
            document.addEventListener('click', (e) => {
                if (this.isMenuOpen && this.isMobile && this.menu && !this.menu.contains(e.target) && e.target !== this.mobileToggle) {
                    this.closeMobileMenu();
                }
            });

            // إغلاق القائمة عند الضغط على Escape
            document.addEventListener('keydown', (e) => {
                if (e.key === 'Escape' && this.isMenuOpen && this.isMobile) {
                    this.closeMobileMenu();
                }
            });

            // تحسين الأداء أثناء التمرير
            let scrollTimeout;
            window.addEventListener('scroll', () => {
                clearTimeout(scrollTimeout);
                scrollTimeout = setTimeout(() => {
                    if (this.isMobile && this.isMenuOpen) {
                        this.updateMobileMenuPosition();
                    }
                }, 100);
            });
        }

        checkDeviceType() {
            this.isMobile = window.innerWidth <= 768;
            
            // تحديث الكلاسات
            document.body.classList.toggle('menu1-mobile', this.isMobile);
            document.body.classList.toggle('menu1-desktop', !this.isMobile);
            
            // إظهار/إخفاء زر التبديل
            if (this.mobileToggle) {
                this.mobileToggle.style.display = this.isMobile ? 'flex' : 'none';
            }
            
            // تحديث menu1
            if (this.menu) {
                this.menu.classList.toggle('mobile-view', this.isMobile);
            }
        }

        handleResize() {
            const wasMobile = this.isMobile;
            this.checkDeviceType();
            
            // إذا تغير نوع الجهاز
            if (wasMobile !== this.isMobile) {
                this.resetMenuState();
                this.optimizeForMobile();
                
                if (!this.isMobile && this.isMenuOpen) {
                    this.closeMobileMenu();
                }
            }
        }

        toggleMobileMenu() {
            if (this.isMenuOpen) {
                this.closeMobileMenu();
            } else {
                this.openMobileMenu();
            }
        }

        openMobileMenu() {
            if (!this.isMobile || !this.menu) return;
            
            this.isMenuOpen = true;
            this.menu.classList.add('mobile-open');
            
            if (this.mobileToggle) {
                this.mobileToggle.classList.add('active');
                this.mobileToggle.setAttribute('aria-expanded', 'true');
            }
            
            // منع التمرير في الخلفية
            document.body.style.overflow = 'hidden';
            
            // إضافة animation
            requestAnimationFrame(() => {
                this.menu.style.transform = 'translateY(0)';
            });
            
            // تركيز على أول عنصر في القائمة
            const firstMenuItem = this.radMenu?.querySelector('.rmLink');
            if (firstMenuItem) {
                setTimeout(() => firstMenuItem.focus(), 300);
            }
        }

        closeMobileMenu() {
            if (!this.isMenuOpen || !this.menu) return;
            
            this.isMenuOpen = false;
            this.menu.classList.remove('mobile-open');
            
            if (this.mobileToggle) {
                this.mobileToggle.classList.remove('active');
                this.mobileToggle.setAttribute('aria-expanded', 'false');
            }
            
            // استعادة التمرير
            document.body.style.overflow = '';
            
            // إغلاق جميع القوائم المنسدلة
            this.closeAllDropdowns();
            
            // إضافة animation
            this.menu.style.transform = 'translateY(-100%)';
        }

        updateMobileMenuPosition() {
            // تحديث موقع القائمة أثناء التمرير على الموبايل
            if (this.menu && this.isMobile) {
                const scrollY = window.scrollY;
                this.menu.style.top = `${scrollY}px`;
            }
        }

        resetMenuState() {
            if (this.menu) {
                this.menu.classList.remove('mobile-open');
                this.menu.style.transform = '';
                this.menu.style.top = '';
            }
            
            if (this.mobileToggle) {
                this.mobileToggle.classList.remove('active');
                this.mobileToggle.setAttribute('aria-expanded', 'false');
            }
            
            this.isMenuOpen = false;
            document.body.style.overflow = '';
            this.closeAllDropdowns();
        }

        initializeSystem() {
            // تهيئة نظام القائمة
            this.checkDeviceType();
            
            // إضافة كلاس التحميل
            if (this.menu) {
                this.menu.classList.add('menu1-loaded');
            }
            
            // عرض رسالة نجاح
            this.showSuccessMessage();
            
            // تحسين الأداء
            this.optimizePerformance();
        }

        optimizePerformance() {
            // تحسين الأداء باستخدام requestAnimationFrame
            const menuItems = this.radMenu?.querySelectorAll('.rmItem');
            if (menuItems) {
                menuItems.forEach((item, index) => {
                    item.style.willChange = 'transform';
                    item.style.animationDelay = `${index * 0.1}s`;
                });
            }
            
            // Lazy loading للعناصر غير المرئية
            if ('IntersectionObserver' in window) {
                this.setupLazyLoading();
            }
        }

        setupLazyLoading() {
            const observer = new IntersectionObserver((entries) => {
                entries.forEach(entry => {
                    if (entry.isIntersecting) {
                        entry.target.classList.add('visible');
                        observer.unobserve(entry.target);
                    }
                });
            }, {
                threshold: 0.1,
                rootMargin: '50px'
            });

            const menuItems = this.radMenu?.querySelectorAll('.rmItem');
            if (menuItems) {
                menuItems.forEach(item => observer.observe(item));
            }
        }

        showSuccessMessage() {
            const message = document.createElement('div');
            message.className = 'menu1-enhancement-loaded';
            message.textContent = '✅ تم تحسين Menu1 وتفعيل النظام المستجيب';
            
            document.body.appendChild(message);
            
            // إزالة الرسالة بعد 3 ثوانِ
            setTimeout(() => {
                message.style.opacity = '0';
                setTimeout(() => message.remove(), 300);
            }, 3000);
        }

        // API العامة للاستخدام الخارجي
        getMenuState() {
            return {
                isOpen: this.isMenuOpen,
                isMobile: this.isMobile,
                menuElement: this.menu,
                radMenuElement: this.radMenu
            };
        }

        forceUpdate() {
            this.handleResize();
            this.optimizeForMobile();
        }

        destroy() {
            // تنظيف النظام
            if (this.mobileToggle) {
                this.mobileToggle.remove();
            }
            
            this.resetMenuState();
            
            // إزالة event listeners
            window.removeEventListener('resize', this.handleResize);
            document.removeEventListener('click', this.closeMobileMenu);
            document.removeEventListener('keydown', this.closeMobileMenu);
        }
    }

    // ===== ENHANCED MENU UTILITIES =====
    class Menu1Utilities {
        static addCustomMenuItem(text, url, iconClass = '') {
            const menu1System = window.ResponsiveMenu1;
            if (!menu1System || !menu1System.radMenu) return;

            const menuGroup = menu1System.radMenu.querySelector('.rmRootGroup');
            if (!menuGroup) return;

            const newItem = document.createElement('li');
            newItem.className = 'rmItem';
            newItem.innerHTML = `
                <a href="${url}" class="rmLink">
                    ${iconClass ? `<i class="${iconClass}"></i>` : ''}
                    <span>${text}</span>
                </a>
            `;

            menuGroup.appendChild(newItem);
            
            // إعادة تهيئة النظام
            menu1System.enhanceRadMenu();
        }

        static setActiveMenuItem(url) {
            const menu1System = window.ResponsiveMenu1;
            if (!menu1System || !menu1System.radMenu) return;

            const allItems = menu1System.radMenu.querySelectorAll('.rmItem');
            allItems.forEach(item => {
                const link = item.querySelector('.rmLink');
                if (link && link.href === url) {
                    item.classList.add('rmSelected');
                } else {
                    item.classList.remove('rmSelected');
                }
            });
        }

        static toggleMobileMenu() {
            const menu1System = window.ResponsiveMenu1;
            if (menu1System) {
                menu1System.toggleMobileMenu();
            }
        }
    }

    // ===== INITIALIZATION =====
    // إنشاء نسخة عامة للنظام
    window.ResponsiveMenu1 = null;
    window.Menu1Utils = Menu1Utilities;

    // تهيئة النظام عند تحميل الصفحة
    function initializeMenu1System() {
        try {
            window.ResponsiveMenu1 = new ResponsiveMenu1System();
            console.log('🎉 تم تشغيل نظام Menu1 المستجيب بنجاح');
        } catch (error) {
            console.error('❌ خطأ في تهيئة نظام Menu1:', error);
        }
    }

    // التهيئة
    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', initializeMenu1System);
    } else {
        initializeMenu1System();
    }

    // دعم Hot Reload للتطوير
    if (window.ResponsiveMenu1) {
        console.log('🔄 إعادة تحميل نظام Menu1...');
        window.ResponsiveMenu1.destroy();
    }

})();

/**
 * TELERIK RADMENU INTEGRATION HELPERS
 * مساعدات التكامل مع Telerik RadMenu
 */

// دالة مساعدة للتكامل مع Telerik
function enhanceTelerikRadMenu() {
    // انتظار تحميل Telerik
    if (typeof Telerik !== 'undefined' && Telerik.Web && Telerik.Web.UI) {
        const radMenu = $find('RadMenu1');
        if (radMenu) {
            // تحسين خصائص RadMenu
            radMenu.set_enableRoundedCorners(true);
            radMenu.set_enableShadows(true);
            radMenu.set_enableAnimation(true);
            
            console.log('✅ تم تحسين Telerik RadMenu');
        }
    } else {
        // إعادة المحاولة بعد ثانية واحدة
        setTimeout(enhanceTelerikRadMenu, 1000);
    }
}

// تشغيل تحسينات Telerik
setTimeout(enhanceTelerikRadMenu, 500);

console.log('📱 Responsive Menu1 System - تم تحميل النظام بنجاح');
console.log('المطور: مهندس متخصص في تطوير الواجهات المستجيبة');
console.log('الهدف: حل مشاكل menu1 وتحويله إلى نظام responsive متقدم');
