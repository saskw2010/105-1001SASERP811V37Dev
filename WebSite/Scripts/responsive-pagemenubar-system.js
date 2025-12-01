/**
 * RESPONSIVE PAGEMENUBAR SYSTEM
 * نظام PageMenuBar المستجيب الشامل
 * خاص بالقائمة المحملة ديناميكياً من ASP.NET
 */

(function() {
    'use strict';

    // ===== RESPONSIVE PAGEMENUBAR CLASS =====
    class ResponsivePageMenuBar {
        constructor() {
            this.pageMenuBar = null;
            this.mobileToggle = null;
            this.isMenuOpen = false;
            this.isMobile = false;
            this.resizeTimeout = null;
            this.menuItems = [];
            
            this.init();
        }

        init() {
            // انتظار تحميل DOM والقائمة
            if (document.readyState === 'loading') {
                document.addEventListener('DOMContentLoaded', () => this.setup());
            } else {
                this.setup();
            }
        }

        setup() {
            console.log('🚀 بدء تهيئة نظام PageMenuBar المستجيب');
            
            // البحث عن PageMenuBar
            this.findMenuElements();
            
            // إنشاء زر الموبايل
            this.createMobileToggle();
            
            // تحسين القائمة
            this.enhanceMenu();
            
            // ربط الأحداث
            this.bindEvents();
            
            // تحديد حالة الجهاز
            this.checkDeviceType();
            
            // تهيئة النظام
            this.initializeSystem();
            
            console.log('✅ تم تهيئة نظام PageMenuBar المستجيب بنجاح');
        }

        findMenuElements() {
            // البحث عن PageMenuBar
            this.pageMenuBar = document.getElementById('ctl00_PageMenuBar') || 
                              document.querySelector('.PageMenuBar');
            
            if (!this.pageMenuBar) {
                console.warn('⚠️ لم يتم العثور على PageMenuBar');
                return;
            }

            // البحث عن جدول القائمة
            this.menuTable = this.pageMenuBar.querySelector('.Menu');
            
            if (!this.menuTable) {
                console.warn('⚠️ لم يتم العثور على جدول القائمة');
                return;
            }

            // جمع عناصر القائمة
            this.menuItems = Array.from(this.menuTable.querySelectorAll('.Item'));
            console.log(`📋 تم العثور على ${this.menuItems.length} عنصر في القائمة`);
        }

        createMobileToggle() {
            // إنشاء زر التبديل للموبايل
            this.mobileToggle = document.createElement('button');
            this.mobileToggle.className = 'pagemenu-mobile-toggle';
            this.mobileToggle.setAttribute('aria-label', 'فتح/إغلاق القائمة الرئيسية');
            this.mobileToggle.setAttribute('aria-expanded', 'false');
            this.mobileToggle.innerHTML = '☰';

            // إضافة الزر إلى الصفحة
            document.body.appendChild(this.mobileToggle);
        }

        enhanceMenu() {
            if (!this.pageMenuBar || !this.menuTable) return;

            // تحسين عناصر القائمة
            this.enhanceMenuItems();
            
            // إضافة دعم إمكانية الوصول
            this.addAccessibilityFeatures();
            
            // تحسين التنقل
            this.enhanceNavigation();
            
            // إضافة دعم اللمس
            this.addTouchSupport();
        }

        enhanceMenuItems() {
            this.menuItems.forEach((item, index) => {
                // إضافة معرف فريد
                if (!item.id) {
                    item.id = `pagemenu-item-${index}`;
                }

                // تحسين الرابط
                const link = item.querySelector('.Link a');
                if (link) {
                    // إضافة خصائص إمكانية الوصول
                    link.setAttribute('role', 'menuitem');
                    link.setAttribute('tabindex', index === 0 ? '0' : '-1');
                    
                    // تحسين النص للموبايل
                    this.optimizeLinkForMobile(link);
                }

                // إضافة مؤشر للعناصر النشطة
                if (item.classList.contains('Selected')) {
                    item.setAttribute('aria-current', 'page');
                }
            });
        }

        optimizeLinkForMobile(link) {
            const originalText = link.textContent.trim();
            
            // تخزين النص الأصلي
            link.setAttribute('data-original-text', originalText);
            
            // إضافة أيقونات للعناصر (اختيارية)
            this.addIconToMenuItem(link, originalText);
        }

        addIconToMenuItem(link, text) {
            // إضافة أيقونات بناءً على النص
            const icons = {
                'منزل': '🏠',
                'نظام المدارس': '🏫',
                'الحسابات العامة': '💰',
                'إدارة المخزون': '📦',
                'الموارد البشرية': '👥',
                'إدارة العمليات': '⚙️',
                'الأنشطة الأخري': '📋'
            };

            const icon = icons[text] || '📌';
            
            // إضافة الأيقونة فقط على الموبايل
            if (window.innerWidth <= 768) {
                link.innerHTML = `<span class="menu-icon">${icon}</span> ${text}`;
            }
        }

        addAccessibilityFeatures() {
            // إضافة ARIA attributes للقائمة
            if (this.menuTable) {
                this.menuTable.setAttribute('role', 'menubar');
                this.menuTable.setAttribute('aria-label', 'القائمة الرئيسية');
            }

            // إعداد navigation بلوحة المفاتيح
            this.setupKeyboardNavigation();
        }

        setupKeyboardNavigation() {
            const menuLinks = this.pageMenuBar.querySelectorAll('.Link a');
            let currentIndex = 0;

            menuLinks.forEach((link, index) => {
                link.addEventListener('keydown', (e) => {
                    switch(e.key) {
                        case 'ArrowRight':
                            e.preventDefault();
                            currentIndex = (index + 1) % menuLinks.length;
                            this.focusMenuItem(menuLinks[currentIndex]);
                            break;
                        case 'ArrowLeft':
                            e.preventDefault();
                            currentIndex = (index - 1 + menuLinks.length) % menuLinks.length;
                            this.focusMenuItem(menuLinks[currentIndex]);
                            break;
                        case 'Home':
                            e.preventDefault();
                            this.focusMenuItem(menuLinks[0]);
                            break;
                        case 'End':
                            e.preventDefault();
                            this.focusMenuItem(menuLinks[menuLinks.length - 1]);
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

        focusMenuItem(link) {
            // إزالة tabindex من جميع العناصر
            const allLinks = this.pageMenuBar.querySelectorAll('.Link a');
            allLinks.forEach(l => l.setAttribute('tabindex', '-1'));
            
            // تعيين التركيز للعنصر الحالي
            link.setAttribute('tabindex', '0');
            link.focus();
        }

        enhanceNavigation() {
            // تحسين سلوك النقر والحوم
            this.menuItems.forEach(item => {
                const link = item.querySelector('.Link a');
                if (link) {
                    // تحسين النقر للموبايل
                    link.addEventListener('click', (e) => {
                        if (this.isMobile && this.isMenuOpen) {
                            // إغلاق القائمة بعد النقر على عنصر
                            setTimeout(() => {
                                this.closeMobileMenu();
                            }, 200);
                        }
                    });

                    // إضافة تأثيرات بصرية
                    this.addVisualEffects(item, link);
                }
            });
        }

        addVisualEffects(item, link) {
            // تأثير الحوم المحسن
            item.addEventListener('mouseenter', () => {
                if (!this.isMobile) {
                    item.style.transform = 'translateY(-2px) scale(1.02)';
                }
            });

            item.addEventListener('mouseleave', () => {
                if (!this.isMobile) {
                    item.style.transform = '';
                }
            });

            // تأثير النقر
            link.addEventListener('mousedown', () => {
                item.style.transform = 'scale(0.98)';
            });

            link.addEventListener('mouseup', () => {
                item.style.transform = '';
            });
        }

        addTouchSupport() {
            // إضافة دعم اللمس للأجهزة التي تدعم اللمس
            if ('ontouchstart' in window) {
                this.menuItems.forEach(item => {
                    const link = item.querySelector('.Link a');
                    if (link) {
                        link.addEventListener('touchstart', (e) => {
                            item.classList.add('touch-active');
                        }, { passive: true });
                        
                        link.addEventListener('touchend', (e) => {
                            setTimeout(() => {
                                item.classList.remove('touch-active');
                            }, 150);
                        }, { passive: true });
                    }
                });
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
                if (this.isMenuOpen && this.isMobile && 
                    this.pageMenuBar && !this.pageMenuBar.contains(e.target) && 
                    e.target !== this.mobileToggle) {
                    this.closeMobileMenu();
                }
            });

            // منع التمرير عند فتح القائمة على الموبايل
            document.addEventListener('touchmove', (e) => {
                if (this.isMenuOpen && this.isMobile) {
                    e.preventDefault();
                }
            }, { passive: false });
        }

        checkDeviceType() {
            this.isMobile = window.innerWidth <= 768;
            
            // تحديث الكلاسات
            document.body.classList.toggle('pagemenu-mobile', this.isMobile);
            document.body.classList.toggle('pagemenu-desktop', !this.isMobile);
            
            // إظهار/إخفاء زر التبديل
            if (this.mobileToggle) {
                this.mobileToggle.style.display = this.isMobile ? 'flex' : 'none';
            }
            
            // تحديث القائمة
            if (this.pageMenuBar) {
                this.pageMenuBar.classList.toggle('mobile-view', this.isMobile);
                
                // إعادة تعيين الأيقونات
                this.updateMenuIcons();
            }
        }

        updateMenuIcons() {
            const links = this.pageMenuBar.querySelectorAll('.Link a');
            links.forEach(link => {
                const originalText = link.getAttribute('data-original-text');
                if (originalText) {
                    if (this.isMobile) {
                        this.addIconToMenuItem(link, originalText);
                    } else {
                        link.textContent = originalText;
                    }
                }
            });
        }

        handleResize() {
            const wasMobile = this.isMobile;
            this.checkDeviceType();
            
            // إذا تغير نوع الجهاز
            if (wasMobile !== this.isMobile) {
                this.resetMenuState();
                
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
            if (!this.isMobile || !this.pageMenuBar) return;
            
            this.isMenuOpen = true;
            this.pageMenuBar.classList.add('mobile-active');
            
            if (this.mobileToggle) {
                this.mobileToggle.classList.add('active');
                this.mobileToggle.setAttribute('aria-expanded', 'true');
                this.mobileToggle.innerHTML = '✕';
            }
            
            // منع التمرير في الخلفية
            document.body.style.overflow = 'hidden';
            
            // تركيز على أول عنصر في القائمة
            const firstLink = this.pageMenuBar.querySelector('.Link a');
            if (firstLink) {
                setTimeout(() => firstLink.focus(), 300);
            }
            
            // إضافة animation للعناصر
            this.animateMenuItems();
        }

        closeMobileMenu() {
            if (!this.isMenuOpen || !this.pageMenuBar) return;
            
            this.isMenuOpen = false;
            this.pageMenuBar.classList.remove('mobile-active');
            
            if (this.mobileToggle) {
                this.mobileToggle.classList.remove('active');
                this.mobileToggle.setAttribute('aria-expanded', 'false');
                this.mobileToggle.innerHTML = '☰';
            }
            
            // استعادة التمرير
            document.body.style.overflow = '';
        }

        animateMenuItems() {
            // إضافة animation للعناصر عند فتح القائمة
            this.menuItems.forEach((item, index) => {
                item.style.animationDelay = `${index * 0.1}s`;
                item.style.animation = 'menuItemFadeIn 0.4s ease-out forwards';
            });
        }

        resetMenuState() {
            if (this.pageMenuBar) {
                this.pageMenuBar.classList.remove('mobile-active');
            }
            
            if (this.mobileToggle) {
                this.mobileToggle.classList.remove('active');
                this.mobileToggle.setAttribute('aria-expanded', 'false');
                this.mobileToggle.innerHTML = '☰';
            }
            
            this.isMenuOpen = false;
            document.body.style.overflow = '';
        }

        initializeSystem() {
            // تهيئة نظام القائمة
            this.checkDeviceType();
            
            // إضافة كلاس التحميل
            if (this.pageMenuBar) {
                this.pageMenuBar.classList.add('pagemenu-loaded');
            }
            
            // عرض رسالة نجاح
            this.showSuccessMessage();
        }

        showSuccessMessage() {
            const message = document.createElement('div');
            message.style.cssText = `
                position: fixed;
                bottom: 20px;
                right: 20px;
                background: #2563eb;
                color: white;
                padding: 15px 20px;
                border-radius: 10px;
                box-shadow: 0 4px 15px rgba(37, 99, 235, 0.4);
                z-index: 10001;
                font-weight: 500;
                animation: slideUp 0.5s ease;
            `;
            message.textContent = '✅ تم تحويل PageMenuBar إلى responsive بنجاح!';
            
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
                menuElement: this.pageMenuBar,
                itemsCount: this.menuItems.length
            };
        }

        forceUpdate() {
            this.handleResize();
            this.updateMenuIcons();
        }

        destroy() {
            // تنظيف النظام
            if (this.mobileToggle) {
                this.mobileToggle.remove();
            }
            
            this.resetMenuState();
        }
    }

    // ===== CSS ANIMATIONS =====
    const styles = `
        @keyframes slideUp {
            from { opacity: 0; transform: translateY(20px); }
            to { opacity: 1; transform: translateY(0); }
        }
        
        .touch-active {
            background: rgba(255, 255, 255, 0.2) !important;
        }
        
        .menu-icon {
            margin-left: 8px;
            font-size: 16px;
        }
    `;

    const styleSheet = document.createElement('style');
    styleSheet.textContent = styles;
    document.head.appendChild(styleSheet);

    // ===== INITIALIZATION =====
    window.ResponsivePageMenuBar = null;

    // تهيئة النظام عند تحميل الصفحة
    function initializePageMenuSystem() {
        try {
            window.ResponsivePageMenuBar = new ResponsivePageMenuBar();
            console.log('🎉 تم تشغيل نظام PageMenuBar المستجيب بنجاح');
        } catch (error) {
            console.error('❌ خطأ في تهيئة نظام PageMenuBar:', error);
        }
    }

    // التهيئة مع التأخير للتأكد من تحميل القائمة
    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', () => {
            setTimeout(initializePageMenuSystem, 500);
        });
    } else {
        setTimeout(initializePageMenuSystem, 500);
    }

    // إعادة التهيئة إذا تم تحديث القائمة ديناميكياً
    const observer = new MutationObserver((mutations) => {
        mutations.forEach((mutation) => {
            if (mutation.type === 'childList') {
                const pageMenuBar = document.getElementById('ctl00_PageMenuBar');
                if (pageMenuBar && !window.ResponsivePageMenuBar) {
                    setTimeout(initializePageMenuSystem, 100);
                }
            }
        });
    });

    observer.observe(document.body, {
        childList: true,
        subtree: true
    });

})();

console.log('📱 Responsive PageMenuBar System - تم تحميل النظام بنجاح');
console.log('المطور: مهندس متخصص في تطوير الواجهات المستجيبة');
console.log('الهدف: تحويل PageMenuBar إلى نظام responsive متقدم');
