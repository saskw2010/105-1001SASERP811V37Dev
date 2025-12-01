/**
 * Modern Responsive Cards System
 * Replaces Telerik cards with modern, responsive, and repeatable card components
 */

class ModernCardsSystem {
    constructor() {
        this.cards = [];
        this.container = null;
        this.currentLayout = 'grid';
        this.initializeSystem();
    }

    // Initialize the cards system
    initializeSystem() {
        this.createCardContainer();
        this.addCardStyles();
        this.setupResponsiveBreakpoints();
        this.loadExistingCards();
    }

    // Create main card container
    createCardContainer() {
        // Check if container already exists
        let container = document.getElementById('modern-cards-container');
        
        if (!container) {
            container = document.createElement('div');
            container.id = 'modern-cards-container';
            container.className = 'modern-cards-grid';
            
            // Find a good place to insert (after menu, before content)
            const targetLocation = document.querySelector('.PageMenuBar') || 
                                 document.querySelector('#menu2') || 
                                 document.querySelector('form');
            
            if (targetLocation) {
                targetLocation.parentNode.insertBefore(container, targetLocation.nextSibling);
            } else {
                document.body.appendChild(container);
            }
        }
        
        this.container = container;
    }

    // Add comprehensive CSS styles
    addCardStyles() {
        const styles = `
            <style id="modern-cards-styles">
            /* Modern Cards Container */
            .modern-cards-grid {
                display: grid;
                grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
                gap: 20px;
                padding: 20px;
                max-width: 1400px;
                margin: 0 auto;
                background: linear-gradient(135deg, #f5f7fa 0%, #c3cfe2 100%);
                min-height: 200px;
                border-radius: 12px;
                margin-bottom: 20px;
            }

            /* Responsive Grid Layouts */
            @media (max-width: 768px) {
                .modern-cards-grid {
                    grid-template-columns: 1fr;
                    padding: 15px;
                    gap: 15px;
                }
            }

            @media (min-width: 769px) and (max-width: 1024px) {
                .modern-cards-grid {
                    grid-template-columns: repeat(2, 1fr);
                }
            }

            @media (min-width: 1025px) {
                .modern-cards-grid {
                    grid-template-columns: repeat(auto-fit, minmax(320px, 1fr));
                }
            }

            @media (min-width: 1400px) {
                .modern-cards-grid {
                    grid-template-columns: repeat(4, 1fr);
                }
            }

            /* Individual Card Styling */
            .modern-card {
                background: rgba(255, 255, 255, 0.95);
                border-radius: 16px;
                box-shadow: 0 8px 32px rgba(31, 38, 135, 0.37);
                backdrop-filter: blur(8px);
                border: 1px solid rgba(255, 255, 255, 0.18);
                overflow: hidden;
                transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
                position: relative;
                min-height: 200px;
                display: flex;
                flex-direction: column;
            }

            .modern-card:hover {
                transform: translateY(-8px);
                box-shadow: 0 20px 60px rgba(31, 38, 135, 0.5);
            }

            .modern-card::before {
                content: '';
                position: absolute;
                top: 0;
                left: 0;
                right: 0;
                height: 4px;
                background: linear-gradient(90deg, #667eea 0%, #764ba2 100%);
                z-index: 1;
            }

            /* Card Header */
            .card-header {
                padding: 20px 24px 16px;
                background: linear-gradient(135deg, rgba(102, 126, 234, 0.1) 0%, rgba(118, 75, 162, 0.1) 100%);
                position: relative;
                z-index: 2;
            }

            .card-title {
                font-size: 1.25rem;
                font-weight: 600;
                color: #1f2937;
                margin: 0 0 8px;
                font-family: 'Cairo', sans-serif;
                display: flex;
                align-items: center;
                gap: 10px;
            }

            .card-subtitle {
                font-size: 0.9rem;
                color: #6b7280;
                margin: 0;
                font-weight: 400;
            }

            .card-icon {
                width: 24px;
                height: 24px;
                background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
                border-radius: 6px;
                display: flex;
                align-items: center;
                justify-content: center;
                color: white;
                font-size: 14px;
            }

            /* Card Content */
            .card-content {
                padding: 16px 24px 20px;
                flex: 1;
                display: flex;
                flex-direction: column;
            }

            .card-description {
                color: #4b5563;
                line-height: 1.6;
                margin-bottom: 16px;
                flex: 1;
            }

            /* Card Actions */
            .card-actions {
                display: flex;
                gap: 8px;
                margin-top: auto;
                padding-top: 16px;
                border-top: 1px solid rgba(0, 0, 0, 0.06);
            }

            .card-btn {
                padding: 8px 16px;
                border: none;
                border-radius: 8px;
                font-size: 0.875rem;
                font-weight: 500;
                cursor: pointer;
                transition: all 0.3s ease;
                text-decoration: none;
                display: inline-flex;
                align-items: center;
                gap: 6px;
                flex: 1;
                justify-content: center;
            }

            .card-btn-primary {
                background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
                color: white;
            }

            .card-btn-primary:hover {
                background: linear-gradient(135deg, #5a67d8 0%, #6b46c1 100%);
                transform: translateY(-2px);
                box-shadow: 0 4px 12px rgba(102, 126, 234, 0.4);
            }

            .card-btn-secondary {
                background: rgba(107, 114, 128, 0.1);
                color: #374151;
                border: 1px solid rgba(107, 114, 128, 0.2);
            }

            .card-btn-secondary:hover {
                background: rgba(107, 114, 128, 0.2);
                transform: translateY(-2px);
            }

            /* Card Types */
            .card-dashboard {
                background: linear-gradient(135deg, rgba(34, 197, 94, 0.1) 0%, rgba(21, 128, 61, 0.1) 100%);
            }

            .card-dashboard::before {
                background: linear-gradient(90deg, #22c55e 0%, #15803d 100%);
            }

            .card-reports {
                background: linear-gradient(135deg, rgba(249, 115, 22, 0.1) 0%, rgba(194, 65, 12, 0.1) 100%);
            }

            .card-reports::before {
                background: linear-gradient(90deg, #f97316 0%, #c2410c 100%);
            }

            .card-settings {
                background: linear-gradient(135deg, rgba(168, 85, 247, 0.1) 0%, rgba(124, 58, 237, 0.1) 100%);
            }

            .card-settings::before {
                background: linear-gradient(90deg, #a855f7 0%, #7c3aed 100%);
            }

            /* News & Updates Card */
            .card-news {
                background: linear-gradient(135deg, rgba(59, 130, 246, 0.1) 0%, rgba(37, 99, 235, 0.1) 100%);
            }

            .card-news::before {
                background: linear-gradient(90deg, #3b82f6 0%, #2563eb 100%);
            }

            .news-item {
                padding: 12px 0;
                border-bottom: 1px solid rgba(0, 0, 0, 0.06);
                display: flex;
                gap: 12px;
                align-items: flex-start;
            }

            .news-item:last-child {
                border-bottom: none;
            }

            .news-date {
                font-size: 0.75rem;
                color: #6b7280;
                background: rgba(59, 130, 246, 0.1);
                padding: 4px 8px;
                border-radius: 4px;
                min-width: 60px;
                text-align: center;
            }

            .news-content {
                flex: 1;
            }

            .news-title {
                font-weight: 500;
                color: #1f2937;
                margin-bottom: 4px;
                font-size: 0.9rem;
            }

            .news-summary {
                font-size: 0.8rem;
                color: #6b7280;
                line-height: 1.4;
            }

            /* Loading and Empty States */
            .cards-loading {
                display: flex;
                justify-content: center;
                align-items: center;
                min-height: 200px;
                color: #6b7280;
                font-size: 1.1rem;
            }

            .cards-empty {
                text-align: center;
                padding: 60px 20px;
                color: #6b7280;
            }

            .cards-empty i {
                font-size: 3rem;
                margin-bottom: 16px;
                display: block;
                opacity: 0.5;
            }

            /* Animation Classes */
            .card-fade-in {
                animation: cardFadeIn 0.6s ease-out forwards;
            }

            @keyframes cardFadeIn {
                from {
                    opacity: 0;
                    transform: translateY(20px);
                }
                to {
                    opacity: 1;
                    transform: translateY(0);
                }
            }

            .card-slide-in {
                animation: cardSlideIn 0.6s ease-out forwards;
            }

            @keyframes cardSlideIn {
                from {
                    opacity: 0;
                    transform: translateX(-20px);
                }
                to {
                    opacity: 1;
                    transform: translateX(0);
                }
            }

            /* RTL Support */
            [dir="rtl"] .card-title {
                text-align: right;
            }

            [dir="rtl"] .card-actions {
                flex-direction: row-reverse;
            }

            /* Dark Mode Support */
            @media (prefers-color-scheme: dark) {
                .modern-cards-grid {
                    background: linear-gradient(135deg, #1f2937 0%, #111827 100%);
                }

                .modern-card {
                    background: rgba(31, 41, 55, 0.95);
                    color: #f9fafb;
                }

                .card-title {
                    color: #f9fafb;
                }

                .card-description {
                    color: #d1d5db;
                }

                .card-subtitle {
                    color: #9ca3af;
                }
            }

            /* Print Styles */
            @media print {
                .modern-cards-grid {
                    display: block;
                    background: none;
                }

                .modern-card {
                    break-inside: avoid;
                    margin-bottom: 20px;
                    box-shadow: none;
                    border: 1px solid #ccc;
                }

                .card-actions {
                    display: none;
                }
            }
            </style>
        `;

        // Remove existing styles and add new ones
        const existingStyles = document.getElementById('modern-cards-styles');
        if (existingStyles) {
            existingStyles.remove();
        }

        document.head.insertAdjacentHTML('beforeend', styles);
    }

    // Setup responsive breakpoints and handlers
    setupResponsiveBreakpoints() {
        const mediaQueries = {
            mobile: window.matchMedia('(max-width: 768px)'),
            tablet: window.matchMedia('(min-width: 769px) and (max-width: 1024px)'),
            desktop: window.matchMedia('(min-width: 1025px)')
        };

        Object.entries(mediaQueries).forEach(([key, mq]) => {
            mq.addListener(() => this.handleResponsiveChange(key, mq.matches));
        });

        // Initial setup
        this.handleResponsiveLayout();
    }

    // Handle responsive layout changes
    handleResponsiveChange(breakpoint, matches) {
        if (matches) {
            this.currentBreakpoint = breakpoint;
            this.handleResponsiveLayout();
        }
    }

    // Apply responsive layout
    handleResponsiveLayout() {
        if (!this.container) return;

        const isMobile = window.innerWidth <= 768;
        const isTablet = window.innerWidth > 768 && window.innerWidth <= 1024;

        // Adjust card layout based on screen size
        if (isMobile) {
            this.container.style.gridTemplateColumns = '1fr';
        } else if (isTablet) {
            this.container.style.gridTemplateColumns = 'repeat(2, 1fr)';
        } else {
            this.container.style.gridTemplateColumns = 'repeat(auto-fit, minmax(320px, 1fr))';
        }
    }

    // Load existing cards from page
    loadExistingCards() {
        // Find existing Telerik or old card elements
        const existingCards = document.querySelectorAll('.RadCard, .card, .dashboard-card, .panel');
        
        if (existingCards.length === 0) {
            this.createDefaultCards();
        } else {
            this.convertExistingCards(existingCards);
        }
    }

    // Convert existing cards to modern format
    convertExistingCards(oldCards) {
        oldCards.forEach((oldCard, index) => {
            const cardData = this.extractCardData(oldCard);
            this.createModernCard(cardData, index * 100);
            
            // Hide old card
            oldCard.style.display = 'none';
        });
    }

    // Extract data from old card elements
    extractCardData(element) {
        const title = element.querySelector('h1, h2, h3, h4, .title, .card-title')?.textContent || 'Card';
        const content = element.querySelector('.content, .card-content, p')?.textContent || 'Content';
        const icon = this.extractIcon(element);
        
        return {
            title: title.trim(),
            subtitle: '',
            description: content.trim(),
            icon: icon,
            type: this.determineCardType(title, content),
            actions: this.extractActions(element)
        };
    }

    // Extract icon from old elements
    extractIcon(element) {
        const iconElement = element.querySelector('i[class*="fa"], .icon, img');
        if (iconElement) {
            if (iconElement.tagName === 'I') {
                return iconElement.className;
            } else if (iconElement.tagName === 'IMG') {
                return 'fas fa-image';
            }
        }
        return 'fas fa-square';
    }

    // Determine card type based on content
    determineCardType(title, content) {
        const titleLower = title.toLowerCase();
        const contentLower = content.toLowerCase();
        
        if (titleLower.includes('dashboard') || titleLower.includes('home')) return 'dashboard';
        if (titleLower.includes('report') || titleLower.includes('تقرير')) return 'reports';
        if (titleLower.includes('setting') || titleLower.includes('إعداد')) return 'settings';
        if (titleLower.includes('news') || titleLower.includes('أخبار')) return 'news';
        
        return 'default';
    }

    // Extract actions from old elements
    extractActions(element) {
        const actions = [];
        const buttons = element.querySelectorAll('button, a, .btn');
        
        buttons.forEach(btn => {
            actions.push({
                text: btn.textContent?.trim() || 'Action',
                action: btn.getAttribute('onclick') || btn.getAttribute('href') || '',
                type: 'primary'
            });
        });

        return actions.length > 0 ? actions : [
            { text: 'عرض', action: '#', type: 'primary' },
            { text: 'تفاصيل', action: '#', type: 'secondary' }
        ];
    }

    // Create default cards
    createDefaultCards() {
        const defaultCards = [
            {
                title: 'لوحة المعلومات',
                subtitle: 'نظرة عامة على النظام',
                description: 'عرض سريع للإحصائيات والمعلومات الهامة في النظام',
                icon: 'fas fa-tachometer-alt',
                type: 'dashboard',
                actions: [
                    { text: 'عرض اللوحة', action: 'Default.aspx', type: 'primary' },
                    { text: 'الإعدادات', action: '#', type: 'secondary' }
                ]
            },
            {
                title: 'التقارير والتحليلات',
                subtitle: 'تقارير شاملة ومفصلة',
                description: 'إنشاء وعرض التقارير المالية والإدارية مع إمكانية التصدير',
                icon: 'fas fa-chart-bar',
                type: 'reports',
                actions: [
                    { text: 'عرض التقارير', action: '#', type: 'primary' },
                    { text: 'إنشاء تقرير', action: '#', type: 'secondary' }
                ]
            },
            {
                title: 'إدارة المستخدمين',
                subtitle: 'إدارة الحسابات والصلاحيات',
                description: 'إضافة وتعديل المستخدمين وإدارة الأدوار والصلاحيات',
                icon: 'fas fa-users-cog',
                type: 'settings',
                actions: [
                    { text: 'إدارة المستخدمين', action: 'Pages/Membership.aspx', type: 'primary' },
                    { text: 'الصلاحيات', action: '#', type: 'secondary' }
                ]
            },
            {
                title: 'الأخبار والتحديثات',
                subtitle: 'آخر الأخبار والتحديثات',
                description: 'تابع آخر الأخبار وتحديثات النظام والإعلانات المهمة',
                icon: 'fas fa-newspaper',
                type: 'news',
                actions: [
                    { text: 'عرض الأخبار', action: '#', type: 'primary' },
                    { text: 'إضافة خبر', action: 'Pages/NewsManager.aspx', type: 'secondary' }
                ],
                newsItems: [
                    {
                        date: '2025-08-04',
                        title: 'تحديث النظام الجديد',
                        summary: 'تم إطلاق النسخة الجديدة من النظام مع تحسينات في الأداء'
                    },
                    {
                        date: '2025-08-03',
                        title: 'صيانة دورية',
                        summary: 'ستتم صيانة دورية للنظام يوم الجمعة من 12-2 ظهراً'
                    }
                ]
            }
        ];

        defaultCards.forEach((cardData, index) => {
            this.createModernCard(cardData, index * 150);
        });
    }

    // Create a modern card element
    createModernCard(cardData, delay = 0) {
        const card = document.createElement('div');
        card.className = `modern-card card-${cardData.type}`;
        
        // Card content
        let cardHTML = `
            <div class="card-header">
                <h3 class="card-title">
                    <span class="card-icon">
                        <i class="${cardData.icon}"></i>
                    </span>
                    ${cardData.title}
                </h3>
                ${cardData.subtitle ? `<p class="card-subtitle">${cardData.subtitle}</p>` : ''}
            </div>
            <div class="card-content">
                <div class="card-description">${cardData.description}</div>
        `;

        // Add news items if it's a news card
        if (cardData.type === 'news' && cardData.newsItems) {
            cardHTML += '<div class="news-items">';
            cardData.newsItems.forEach(item => {
                cardHTML += `
                    <div class="news-item">
                        <div class="news-date">${this.formatDate(item.date)}</div>
                        <div class="news-content">
                            <div class="news-title">${item.title}</div>
                            <div class="news-summary">${item.summary}</div>
                        </div>
                    </div>
                `;
            });
            cardHTML += '</div>';
        }

        // Add actions
        if (cardData.actions && cardData.actions.length > 0) {
            cardHTML += '<div class="card-actions">';
            cardData.actions.forEach(action => {
                const actionClass = action.type === 'primary' ? 'card-btn-primary' : 'card-btn-secondary';
                const actionHandler = action.action.startsWith('#') ? 
                    `onclick="event.preventDefault(); console.log('${action.text} clicked');"` :
                    action.action.includes('(') ? `onclick="${action.action}"` : `onclick="window.location.href='${action.action}'"`;
                
                cardHTML += `
                    <button class="card-btn ${actionClass}" ${actionHandler}>
                        <i class="fas fa-arrow-right"></i>
                        ${action.text}
                    </button>
                `;
            });
            cardHTML += '</div>';
        }

        cardHTML += `
            </div>
        `;

        card.innerHTML = cardHTML;

        // Add animation
        setTimeout(() => {
            card.classList.add('card-fade-in');
            this.container.appendChild(card);
        }, delay);

        // Store card reference
        this.cards.push({
            element: card,
            data: cardData
        });

        return card;
    }

    // Format date for display
    formatDate(dateString) {
        const date = new Date(dateString);
        return date.toLocaleDateString('ar-SA', { 
            month: 'short', 
            day: 'numeric' 
        });
    }

    // Add a new card dynamically
    addCard(cardData) {
        return this.createModernCard(cardData);
    }

    // Remove a card
    removeCard(cardElement) {
        const index = this.cards.findIndex(card => card.element === cardElement);
        if (index > -1) {
            cardElement.remove();
            this.cards.splice(index, 1);
        }
    }

    // Update card content
    updateCard(cardElement, newData) {
        const index = this.cards.findIndex(card => card.element === cardElement);
        if (index > -1) {
            this.cards[index].data = { ...this.cards[index].data, ...newData };
            // Recreate card with new data
            const newCard = this.createModernCard(this.cards[index].data);
            cardElement.parentNode.replaceChild(newCard, cardElement);
            this.cards[index].element = newCard;
        }
    }

    // Refresh all cards
    refreshCards() {
        this.container.innerHTML = '';
        this.cards = [];
        this.loadExistingCards();
    }

    // Get all cards
    getAllCards() {
        return this.cards;
    }

    // Set loading state
    setLoading(isLoading) {
        if (isLoading) {
            this.container.innerHTML = `
                <div class="cards-loading">
                    <i class="fas fa-spinner fa-spin"></i>
                    جاري التحميل...
                </div>
            `;
        } else if (this.cards.length === 0) {
            this.createDefaultCards();
        }
    }
}

// Initialize Modern Cards System
document.addEventListener('DOMContentLoaded', function() {
    window.modernCardsSystem = new ModernCardsSystem();
});

// Also initialize if DOM is already loaded
if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', function() {
        window.modernCardsSystem = new ModernCardsSystem();
    });
} else {
    window.modernCardsSystem = new ModernCardsSystem();
}
