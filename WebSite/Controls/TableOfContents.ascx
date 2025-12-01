<%@ Control Language="VB" AutoEventWireup="false" CodeFile="TableOfContents.ascx.vb" Inherits="Controls_TableOfContents"  %>
<%@ Import Namespace="translatemeyamosso"%> 

<div id="<%=Me.ClientID%>" class="toc-container">
    <!-- Modern Navigation Grid Container -->
    <div id="navigationGrid<%=Me.ClientID%>" class="modern-navigation-grid">
        <!-- Dynamic content will be loaded here -->
    </div>

    <!-- Modern TOC Literal Control for Dynamic Content -->
    <asp:Literal ID="litModernToc" runat="server" Visible="false"></asp:Literal>

    <!-- SiteMap Data Source - reads from current node -->
    <asp:SiteMapDataSource ID="SiteMapDataSource1x" runat="server" ShowStartingNode="true" StartFromCurrentNode="true"/>

    <!-- Hidden Repeater for Data Binding - Bound to NavigationItems from code-behind -->
    <asp:Repeater ID="rptNavigation" runat="server">
        <ItemTemplate>
            <div class="nav-card-data" style="display: none; border: 1px solid red;" 
                 data-url='<%# Eval("Url")%>'
                 data-title='<%# Eval("Title")%>'
                 data-image='<%# Eval("Icon") %>'
                 data-description='<%# Eval("Description") %>'>
                 DEBUG: <%# Eval("Title") %> | <%# Eval("Url") %>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <!-- Modern Styles - Instance Specific -->
    <style>
.modern-navigation-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(280px, 1fr));
    gap: 20px;
    padding: 20px 0;
    margin: 0;
    position: relative;
    z-index: 1;
}

/* Ensure each instance is isolated */
#navigationGrid<%=Me.ClientID%> {
    isolation: isolate;
}

/* Hide duplicate instances in sidebar if they exist */
.sidebar .modern-navigation-grid:not(#navigationGrid<%=Me.ClientID%>) {
    display: none !important;
}

/* Ensure main content instance is visible */
.current-menu-section .modern-navigation-grid {
    display: grid !important;
}

.modern-nav-card {
    position: relative;
    background: linear-gradient(135deg, #ffffff 0%, #f8fafc 100%);
    border-radius: 16px;
    overflow: hidden;
    box-shadow: 0 4px 20px rgba(0, 0, 0, 0.08);
    transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
    text-decoration: none;
    color: inherit;
    border: 1px solid rgba(148, 163, 184, 0.1);
}

.modern-nav-card:hover {
    transform: translateY(-8px) scale(1.02);
    box-shadow: 0 12px 40px rgba(0, 0, 0, 0.15);
    text-decoration: none;
    color: inherit;
}

.modern-nav-card:focus {
    outline: none !important;
    border: none !important;
    box-shadow: none !important;
}

.card-image-container {
    position: relative;
    height: 160px;
    background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
    display: flex;
    align-items: center;
    justify-content: center;
    overflow: hidden;
}

.card-image {
    width: 80px;
    height: 80px;
    object-fit: cover;
    border-radius: 12px;
    transition: transform 0.3s ease;
    background: rgba(255, 255, 255, 0.9);
    padding: 8px;
}

.modern-nav-card:hover .card-image {
    transform: scale(1.1);
}

.card-overlay {
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background: linear-gradient(to bottom, rgba(0,0,0,0) 0%, rgba(0,0,0,0.3) 100%);
    opacity: 0;
    transition: opacity 0.3s ease;
}

.modern-nav-card:hover .card-overlay {
    opacity: 1;
}

.card-content {
    padding: 20px;
    text-align: center;
}

.card-title {
    font-size: 1.2rem;
    font-weight: 700;
    color: #1e293b;
    margin: 0 0 8px 0;
    line-height: 1.3;
    transition: color 0.3s ease;
}

.modern-nav-card:hover .card-title {
    color: #3b82f6;
}

.card-description {
    font-size: 0.9rem;
    color: #64748b;
    margin: 0;
    line-height: 1.5;
}

.no-content-message {
    grid-column: 1 / -1;
    text-align: center;
    padding: 40px 20px;
}

.alert {
    background: linear-gradient(135deg, #dbeafe 0%, #bfdbfe 100%);
    border: 1px solid #93c5fd;
    border-radius: 12px;
    padding: 20px;
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 12px;
    color: #1e40af;
}

.alert i {
    font-size: 1.5rem;
}

.alert p {
    margin: 0;
    font-weight: 500;
}

/* Loading Animation */
.loading-skeleton {
    background: linear-gradient(90deg, #f0f0f0 25%, #e0e0e0 50%, #f0f0f0 75%);
    background-size: 200% 100%;
    animation: loading 1.5s infinite;
}

@keyframes loading {
    0% {
        background-position: 200% 0;
    }
    100% {
        background-position: -200% 0;
    }
}

/* Responsive Design */
@media (max-width: 768px) {
    .modern-navigation-grid {
        grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
        gap: 15px;
        padding: 15px 0;
    }
    
    .card-image-container {
        height: 120px;
    }
    
    .card-image {
        width: 60px;
        height: 60px;
    }
    
    .card-content {
        padding: 15px;
    }
    
    .card-title {
        font-size: 1.1rem;
    }
}

@media (max-width: 480px) {
    .modern-navigation-grid {
        grid-template-columns: 1fr;
        gap: 12px;
    }
}

/* Animation for card entrance */
.fade-in-up {
    animation: fadeInUp 0.6s ease forwards;
}

@keyframes fadeInUp {
    from {
        opacity: 0;
        transform: translateY(30px);
    }
    to {
        opacity: 1;
        transform: translateY(0);
    }
}
    </style>

    <!-- Modern JavaScript -->
    <script>
var tableOfContentsInstanceId = '<%=Me.ClientID%>';
console.log('🚀 TableOfContents.ascx [' + tableOfContentsInstanceId + '] - JavaScript Loading...');

// Reset navigation load flag for this instance
window['loadModernNavigation_<%=Me.ClientID%>_loaded'] = false;

document.addEventListener('DOMContentLoaded', function() {
    console.log('📋 TableOfContents [' + tableOfContentsInstanceId + '] - DOM Content Loaded');
    loadModernNavigation_<%=Me.ClientID%>();
});

// Define switchToModernMode function for this instance
function switchToModernMode_<%=Me.ClientID%>() {
    console.log('🎨 switchToModernMode() called for instance: ' + tableOfContentsInstanceId);
    
    try {
        // Hide any legacy controls if they exist
        const legacyControls = document.querySelectorAll('.legacy-toc, .old-navigation');
        legacyControls.forEach(control => {
            console.log('🔄 Hiding legacy control:', control);
            control.style.display = 'none';
        });
        
        // Show modern navigation grid for this instance
        const modernGrid = document.getElementById('navigationGrid<%=Me.ClientID%>');
        if (modernGrid) {
            console.log('✅ Showing modern navigation grid for: ' + tableOfContentsInstanceId);
            modernGrid.style.display = 'grid';
            modernGrid.style.opacity = '1';
        } else {
            console.warn('⚠️ Modern navigation grid not found for: ' + tableOfContentsInstanceId);
        }
        
        // Reload modern navigation to ensure it's current
        console.log('🔄 Reloading modern navigation for: ' + tableOfContentsInstanceId);
        loadModernNavigation_<%=Me.ClientID%>();
        
        console.log('✅ Switch to modern mode completed for: ' + tableOfContentsInstanceId);
        
    } catch (error) {
        console.error('❌ Error in switchToModernMode for ' + tableOfContentsInstanceId + ':', error);
    }
}

// Global switchToModernMode function that calls all instances
if (typeof switchToModernMode === 'undefined') {
    function switchToModernMode() {
        console.log('🎨 Global switchToModernMode() called - triggering all instances');
        // This will be called by each instance
        switchToModernMode_<%=Me.ClientID%>();
    }
}

function loadModernNavigation_<%=Me.ClientID%>() {
    // Prevent multiple execution for same instance
    if (window['loadModernNavigation_<%=Me.ClientID%>_loaded']) {
        console.log('⚠️ loadModernNavigation_<%=Me.ClientID%>() already loaded, skipping...');
        return;
    }
    window['loadModernNavigation_<%=Me.ClientID%>_loaded'] = true;
    
    console.log('📊 loadModernNavigation() called for: ' + tableOfContentsInstanceId);
    
    const navigationGrid = document.getElementById('navigationGrid<%=Me.ClientID%>');
    
    // Fix: Search for hidden cards within this specific control instance
    const controlContainer = document.getElementById('<%=Me.ClientID%>');
    const hiddenCards = controlContainer ? 
        controlContainer.querySelectorAll('.nav-card-data') : 
        document.querySelectorAll('.nav-card-data');
    
    console.log('📦 Found navigation grid for ' + tableOfContentsInstanceId + ':', !!navigationGrid);
    console.log('🔍 Control container found:', !!controlContainer);
    console.log('🎯 Found hidden cards for ' + tableOfContentsInstanceId + ':', hiddenCards.length);
    
    // Debug: Log each hidden card found
    hiddenCards.forEach((card, index) => {
        console.log(`   🃏 Card ${index + 1}: ${card.getAttribute('data-title')} | URL: ${card.getAttribute('data-url')}`);
    });
    
    if (!navigationGrid) {
        console.error('❌ Navigation grid not found for: ' + tableOfContentsInstanceId);
        return;
    }
    
    // Show loading
    console.log('⏳ Showing loading skeleton for: ' + tableOfContentsInstanceId);
    navigationGrid.innerHTML = '<div class="loading-skeleton" style="height: 200px; border-radius: 16px;"></div>';
    
    setTimeout(() => {
        console.log('🔄 Building navigation cards for: ' + tableOfContentsInstanceId);
        navigationGrid.innerHTML = '';
        
        if (hiddenCards.length === 0) {
            console.log('ℹ️ No dynamic content available for ' + tableOfContentsInstanceId + ', showing default message');
            // No dynamic content available
            const noContentMessage = document.createElement('div');
            noContentMessage.className = 'no-content-message';
            noContentMessage.innerHTML = `
                <div class="alert">
                    <i class="fas fa-info-circle"></i>
                    <p><%=translatemeyamosso.GetResourceValuemosso("NoMenuItems")%></p>
                </div>
            `;
            navigationGrid.appendChild(noContentMessage);
        } else {
            console.log('🎨 Creating', hiddenCards.length, 'modern cards from dynamic content for: ' + tableOfContentsInstanceId);
            // Create modern cards from dynamic content
            hiddenCards.forEach((cardData, index) => {
                console.log('🏗️ Creating card', index + 1, 'for ' + tableOfContentsInstanceId + ':', cardData.getAttribute('data-title'));
                
                const card = createModernNavCard_<%=Me.ClientID%>({
                    url: cardData.getAttribute('data-url'),
                    title: cardData.getAttribute('data-title'),
                    image: cardData.getAttribute('data-image'),
                    description: cardData.getAttribute('data-description')
                });
                
                // Add entrance animation with delay
                setTimeout(() => {
                    card.classList.add('fade-in-up');
                    navigationGrid.appendChild(card);
                    console.log('✨ Card added with animation for ' + tableOfContentsInstanceId + ':', cardData.getAttribute('data-title'));
                }, index * 100);
            });
        }
        
        console.log('✅ Navigation loading completed for: ' + tableOfContentsInstanceId);
    }, 500);
}

function createModernNavCard_<%=Me.ClientID%>(item) {
    console.log('🎴 Creating modern nav card for ' + tableOfContentsInstanceId + ':', item.title);
    
    const card = document.createElement('a');
    card.href = item.url;
    card.className = 'modern-nav-card';
    
    // Use the image from data or fallback
    const imageUrl = item.image || '<%=ResolveUrl("~/images/dashboard/10001.png")%>';
    const description = item.description || '<%=translatemeyamosso.GetResourceValuemosso("ClickToAccess")%>';
    
    console.log('🖼️ Card image URL for ' + tableOfContentsInstanceId + ':', imageUrl);
    console.log('📝 Card description for ' + tableOfContentsInstanceId + ':', description);
    
    card.innerHTML = `
        <div class="card-image-container">
            <img src="${imageUrl}" alt="${item.title}" class="card-image" 
                 onerror="this.src='<%=ResolveUrl("~/images/dashboard/10001.png")%>'; console.log('⚠️ Image failed to load for ${tableOfContentsInstanceId}, using fallback');">
            <div class="card-overlay"></div>
        </div>
        <div class="card-content">
            <h3 class="card-title">${item.title}</h3>
            <p class="card-description">${description}</p>
        </div>
    `;
    
    console.log('✅ Card created successfully for ' + tableOfContentsInstanceId + ':', item.title);
    return card;
}

// Add click tracking with enhanced logging for this instance
document.addEventListener('click', function(e) {
    if (e.target.closest('.modern-nav-card') && e.target.closest('#navigationGrid<%=Me.ClientID%>')) {
        const card = e.target.closest('.modern-nav-card');
        const title = card.querySelector('.card-title').textContent;
        const url = card.href;
        
        console.log('🖱️ Navigation card clicked in ' + tableOfContentsInstanceId + ':');
        console.log('   📄 Title:', title);
        console.log('   🔗 URL:', url);
        console.log('   🕒 Time:', new Date().toLocaleTimeString());
    }
});

// Log when script finishes loading
console.log('✅ TableOfContents.ascx [' + tableOfContentsInstanceId + '] - JavaScript Loaded Successfully');

// Additional debugging and cleanup
document.addEventListener('DOMContentLoaded', function() {
    // Log all TableOfContents instances
    const allGrids = document.querySelectorAll('[id^="navigationGrid"]');
    console.log('🔍 Found ' + allGrids.length + ' TableOfContents instances:', Array.from(allGrids).map(g => g.id));
    
    // Debug: Find ALL nav-card-data elements in the entire document
    const allNavCards = document.querySelectorAll('.nav-card-data');
    console.log('🔍 Found ' + allNavCards.length + ' total nav-card-data elements in document');
    allNavCards.forEach((card, index) => {
        const parentId = card.closest('[id]')?.id || 'no-parent-id';
        console.log(`   🃏 Global card ${index + 1}: "${card.getAttribute('data-title')}" in parent: ${parentId}`);
    });
    
    // Debug: Check our specific container
    console.log('🔍 Looking for container with ClientID: <%=Me.ClientID%>');
    const ourContainer = document.getElementById('<%=Me.ClientID%>');
    if (ourContainer) {
        console.log('✅ Found our container:', ourContainer);
        const ourCards = ourContainer.querySelectorAll('.nav-card-data');
        console.log('🎯 Found ' + ourCards.length + ' nav-card-data elements in our container: <%=Me.ClientID%>');
        ourCards.forEach((card, index) => {
            console.log(`   🃏 Our card ${index + 1}: "${card.getAttribute('data-title')}"`);
        });
    } else {
        console.error('❌ Our container not found: <%=Me.ClientID%>');
        console.log('🔍 Available elements with similar IDs:');
        const allElements = document.querySelectorAll('[id*="CurrentMenuTableOfContents"]');
        allElements.forEach(el => {
            console.log('   📋 Found element:', el.id, el);
        });
    }
    
    // Hide any hardcoded content that might be interfering
    const hardcodedSections = document.querySelectorAll('.hardcoded-navigation, .static-cards, .dashboard-cards');
    hardcodedSections.forEach(section => {
        console.log('🚫 Hiding hardcoded section:', section);
        section.style.display = 'none';
    });
    
    // Ensure our instance is visible
    const ourGrid = document.getElementById('navigationGrid<%=Me.ClientID%>');
    if (ourGrid) {
        ourGrid.style.display = 'grid';
        ourGrid.style.visibility = 'visible';
        ourGrid.style.zIndex = '10';
        console.log('✅ Our grid [' + tableOfContentsInstanceId + '] is now visible');
    }
    
    // Debug: Show what's currently visible in the viewport
    setTimeout(() => {
        const visibleElements = Array.from(document.querySelectorAll('.modern-nav-card')).filter(el => {
            const rect = el.getBoundingClientRect();
            return rect.top >= 0 && rect.left >= 0 && rect.bottom <= window.innerHeight && rect.right <= window.innerWidth;
        });
        console.log('👁️ Currently visible cards:', visibleElements.length);
        visibleElements.forEach(el => {
            console.log('   📍 Visible card:', el.querySelector('.card-title')?.textContent);
        });
        
        // Force a manual search and reload if no cards found
        if (visibleElements.length === 0) {
            console.log('⚠️ No visible cards found, attempting manual debugging...');
            
            // Try different selectors to find the hidden cards
            const allPossibleCards = [
                ...document.querySelectorAll('.nav-card-data'),
                ...document.querySelectorAll('[class*="nav-card"]'),
                ...document.querySelectorAll('[data-title]'),
                ...document.querySelectorAll('[id*="rptNavigation"]')
            ];
            
            console.log('🔍 Manual search found ' + allPossibleCards.length + ' potential card elements');
            allPossibleCards.forEach((el, index) => {
                console.log(`   🔎 Element ${index + 1}:`, {
                    tagName: el.tagName,
                    className: el.className,
                    id: el.id,
                    dataTitle: el.getAttribute('data-title'),
                    textContent: el.textContent?.substring(0, 50)
                });
            });
            
            // Try to force reload our specific instance
            if (typeof window['loadModernNavigation_<%=Me.ClientID%>'] === 'function') {
                console.log('🔄 Forcing reload of our instance...');
                window['loadModernNavigation_<%=Me.ClientID%>']();
            }
        }
    }, 3000); // Increased delay to ensure everything is loaded
    
    // Global debugging function accessible from console
    window['debugTableOfContents_<%=Me.ClientID%>'] = function() {
        console.log('🐛 Manual Debug for TableOfContents <%=Me.ClientID%>');
        console.log('📊 DOM Elements Analysis:');
        
        // Check our specific container
        const ourContainer = document.getElementById('navigationGrid<%=Me.ClientID%>');
        console.log('   🏠 Our container:', ourContainer);
        if (ourContainer) {
            console.log('   📐 Container dimensions:', {
                width: ourContainer.offsetWidth,
                height: ourContainer.offsetHeight,
                innerHTML: ourContainer.innerHTML.length + ' chars'
            });
        }
        
        // Check all possible data sources
        console.log('🔍 All potential data sources:');
        ['.nav-card-data', '[data-title]', '[data-url]', '[id*="rpt"]'].forEach(selector => {
            const elements = document.querySelectorAll(selector);
            console.log(`   ${selector}: ${elements.length} elements`);
            elements.forEach((el, i) => {
                if (i < 3) { // Show first 3
                    console.log(`      ${i + 1}. ${el.tagName}.${el.className} - ${el.textContent?.substring(0, 30)}`);
                }
            });
        });
        
        // Force reload
        console.log('🔄 Attempting force reload...');
        if (typeof window['loadModernNavigation_<%=Me.ClientID%>'] === 'function') {
            window['loadModernNavigation_<%=Me.ClientID%>']();
        }
        
        return 'Debug complete - check console for results';
    };
    
    console.log('🛠️ Debug function available: debugTableOfContents_<%=Me.ClientID%>()');
});
    </script>

    <!-- Hidden Labels (keeping for compatibility) -->
    <div style="display:none">
        <asp:Label ID="Label1" runat="server" Text="Label" Height="210"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" Height="16px" TextMode="MultiLine" Width="236px"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Label" Height="210"></asp:Label>
    </div>
</div>