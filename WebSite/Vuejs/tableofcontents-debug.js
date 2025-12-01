// TableOfContents Debugging Script
// قم بتشغيل هذا في Developer Console لتشخيص المشكلة

console.log('🔍 TableOfContents Debug Script Started');
console.log('=====================================');

// 1. فحص جميع instances
function debugTableOfContents() {
    console.log('📊 Debugging TableOfContents instances...');
    
    // البحث عن جميع navigation grids
    const allGrids = document.querySelectorAll('[id^="navigationGrid"]');
    console.log('🎯 Found ' + allGrids.length + ' navigation grids:');
    
    allGrids.forEach((grid, index) => {
        console.log(`   ${index + 1}. Grid ID: ${grid.id}`);
        console.log(`      Visible: ${getComputedStyle(grid).display !== 'none'}`);
        console.log(`      Cards inside: ${grid.querySelectorAll('.modern-nav-card').length}`);
        console.log(`      Position: ${grid.getBoundingClientRect().top}px from top`);
        
        // إذا كان مخفي، اظهره للاختبار
        if (getComputedStyle(grid).display === 'none') {
            console.log(`      🔄 Attempting to show hidden grid: ${grid.id}`);
            grid.style.display = 'grid';
            grid.style.visibility = 'visible';
            grid.style.zIndex = '999';
        }
    });
    
    // البحث عن hidden cards
    const hiddenCards = document.querySelectorAll('.nav-card-data');
    console.log('🃏 Found ' + hiddenCards.length + ' hidden card data elements:');
    hiddenCards.forEach((card, index) => {
        console.log(`   ${index + 1}. Title: ${card.getAttribute('data-title')}`);
        console.log(`      URL: ${card.getAttribute('data-url')}`);
        console.log(`      Description: ${card.getAttribute('data-description')}`);
    });
    
    // البحث عن محتوى hardcoded
    const staticContent = document.querySelectorAll('.placeholder-card, .dashboard-card, [class*="hardcoded"]');
    console.log('🏗️ Found ' + staticContent.length + ' static/hardcoded elements:');
    staticContent.forEach((element, index) => {
        console.log(`   ${index + 1}. Class: ${element.className}`);
        console.log(`      Text: ${element.textContent.substring(0, 50)}...`);
        console.log(`      Visible: ${getComputedStyle(element).display !== 'none'}`);
    });
    
    // فحص الـ viewport الحالي
    const visibleCards = Array.from(document.querySelectorAll('.modern-nav-card')).filter(el => {
        const rect = el.getBoundingClientRect();
        return rect.top >= 0 && rect.left >= 0 && rect.bottom <= window.innerHeight && rect.right <= window.innerWidth;
    });
    
    console.log('👁️ Currently visible modern cards in viewport: ' + visibleCards.length);
    visibleCards.forEach((card, index) => {
        const title = card.querySelector('.card-title')?.textContent || 'No title';
        console.log(`   ${index + 1}. ${title}`);
    });
}

// 2. إجبار إعادة تحميل جميع instances
function forceReloadAllInstances() {
    console.log('🔄 Force reloading all TableOfContents instances...');
    
    const allGrids = document.querySelectorAll('[id^="navigationGrid"]');
    allGrids.forEach(grid => {
        console.log(`🔄 Reloading grid: ${grid.id}`);
        
        // مسح المحتوى الحالي
        grid.innerHTML = '<div class="loading-skeleton" style="height: 200px; border-radius: 16px;"></div>';
        
        // إعادة تحميل بعد تأخير قصير
        setTimeout(() => {
            const clientId = grid.id.replace('navigationGrid', '');
            const functionName = 'loadModernNavigation_' + clientId;
            
            if (typeof window[functionName] === 'function') {
                console.log(`✅ Calling ${functionName}`);
                window[functionName]();
            } else {
                console.log(`⚠️ Function ${functionName} not found, trying global loadModernNavigation`);
                if (typeof loadModernNavigation === 'function') {
                    loadModernNavigation();
                }
            }
        }, 500);
    });
}

// 3. إخفاء المحتوى المتداخل
function hideConflictingContent() {
    console.log('🚫 Hiding conflicting content...');
    
    // إخفاء الـ instances المكررة
    const allGrids = document.querySelectorAll('[id^="navigationGrid"]');
    if (allGrids.length > 1) {
        for (let i = 1; i < allGrids.length; i++) {
            console.log(`🚫 Hiding duplicate grid: ${allGrids[i].id}`);
            allGrids[i].style.display = 'none';
        }
        
        // إظهار الأول فقط
        if (allGrids[0]) {
            console.log(`✅ Showing primary grid: ${allGrids[0].id}`);
            allGrids[0].style.display = 'grid';
            allGrids[0].style.zIndex = '999';
        }
    }
    
    // إخفاء المحتوى الثابت المتداخل
    const staticElements = document.querySelectorAll('.placeholder-content, [class*="static-cards"]');
    staticElements.forEach(element => {
        console.log(`🚫 Hiding static element: ${element.className}`);
        element.style.display = 'none';
    });
}

// 4. اختبار إنشاء card يدوياً
function createTestCard() {
    console.log('🧪 Creating test card...');
    
    const firstGrid = document.querySelector('[id^="navigationGrid"]');
    if (!firstGrid) {
        console.error('❌ No navigation grid found for test');
        return;
    }
    
    const testCard = document.createElement('a');
    testCard.href = '#';
    testCard.className = 'modern-nav-card test-card';
    testCard.style.border = '3px solid red';
    
    testCard.innerHTML = `
        <div class="card-image-container" style="background: linear-gradient(45deg, #ff6b6b, #4ecdc4);">
            <div style="color: white; font-size: 2rem;">🧪</div>
        </div>
        <div class="card-content">
            <h3 class="card-title">TEST CARD</h3>
            <p class="card-description">This is a test card to verify the system is working</p>
        </div>
    `;
    
    firstGrid.appendChild(testCard);
    console.log('✅ Test card created in grid:', firstGrid.id);
}

// تشغيل الفحص الأولي
debugTableOfContents();

// إضافة وظائف إلى window للوصول السهل
window.debugTOC = debugTableOfContents;
window.forceReloadTOC = forceReloadAllInstances;
window.hideConflictingTOC = hideConflictingContent;
window.createTestTOC = createTestCard;

console.log('');
console.log('🛠️ Available debugging functions:');
console.log('   debugTOC() - فحص شامل للحالة');
console.log('   forceReloadTOC() - إعادة تحميل جميع instances');
console.log('   hideConflictingTOC() - إخفاء المحتوى المتداخل');
console.log('   createTestTOC() - إنشاء test card');
console.log('');
console.log('🔍 TableOfContents Debug Script Ready!');
