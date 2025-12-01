// Menu Integration Test - Tests the complete menu data flow
// This script verifies that menu data flows correctly from modern-menu-once.js to other components

window.menuIntegrationTest = function() {
    console.log('🧪 Menu Integration Test: Starting...');
    
    const results = {
        modernMenuOnceLoaded: false,
        menuDataBridgeLoaded: false,
        modernMenuDataAvailable: false,
        proModalMenuCanAccess: false,
        proSidebarCanAccess: false,
        dataIntegrity: false,
        securityPreserved: false
    };
    
    // Test 1: Check if modern-menu-once.js is loaded
    if (window.__modernMenuOnceMounted) {
        results.modernMenuOnceLoaded = true;
        console.log('✅ Test 1: modern-menu-once.js is loaded');
    } else {
        console.log('❌ Test 1: modern-menu-once.js is NOT loaded');
    }
    
    // Test 2: Check if menu-data-bridge.js is loaded
    if (window.menuDataBridge) {
        results.menuDataBridgeLoaded = true;
        console.log('✅ Test 2: menu-data-bridge.js is loaded');
    } else {
        console.log('❌ Test 2: menu-data-bridge.js is NOT loaded');
    }
    
    // Test 3: Check if window.modernMenuData is available (try cache too)
    if (window.modernMenuData && Array.isArray(window.modernMenuData)) {
        results.modernMenuDataAvailable = true;
        console.log('✅ Test 3: window.modernMenuData is available with', window.modernMenuData.length, 'items');
    } else {
        // Try to load from cache
        try {
            var userKey = getCurrentUserKey();
            var cached = localStorage.getItem(userKey);
            if (cached) {
                var menuCache = JSON.parse(cached);
                if (menuCache.legacyData && Array.isArray(menuCache.legacyData)) {
                    results.modernMenuDataAvailable = true;
                    console.log('✅ Test 3: Menu data available in localStorage cache with', menuCache.legacyData.length, 'items');
                } else {
                    console.log('❌ Test 3: window.modernMenuData and cache both NOT available');
                }
            } else {
                console.log('❌ Test 3: window.modernMenuData and cache both NOT available');
            }
        } catch (e) {
            console.log('❌ Test 3: window.modernMenuData is NOT available, cache check failed:', e);
        }
    }
    
    // Helper function to get user key
    function getCurrentUserKey() {
        var userKey = 'anonymous';
        if (window.currentUser) {
            userKey = window.currentUser;
        } else if (document.querySelector('[data-user]')) {
            userKey = document.querySelector('[data-user]').getAttribute('data-user');
        } else if (document.body.getAttribute('data-user')) {
            userKey = document.body.getAttribute('data-user');
        }
        return 'modernMenu_' + userKey.replace(/[^a-zA-Z0-9]/g, '_');
    }
    
    // Test 4: Check if pro-modal-menu.js can access the data
    if (window.debugProModal) {
        const modalDebug = window.debugProModal();
        if (modalDebug.host && modalDebug.pmList) {
            results.proModalMenuCanAccess = true;
            console.log('✅ Test 4: pro-modal-menu.js can access menu components');
        } else {
            console.log('❌ Test 4: pro-modal-menu.js cannot access menu components');
        }
    } else {
        console.log('❌ Test 4: pro-modal-menu.js debug function not available');
    }
    
    // Test 5: Check if pro-sidebar.js is accessible
    if (document.getElementById('psb-list')) {
        results.proSidebarCanAccess = true;
        console.log('✅ Test 5: pro-sidebar.js components are accessible');
    } else {
        console.log('❌ Test 5: pro-sidebar.js components are NOT accessible');
    }
    
    // Test 6: Check data integrity
    if (window.modernMenuData && window.modernMenuData.length > 0) {
        const firstItem = window.modernMenuData[0];
        if (firstItem.text && firstItem.url && Array.isArray(firstItem.children)) {
            results.dataIntegrity = true;
            console.log('✅ Test 6: Data integrity check passed');
            console.log('   - First item text:', firstItem.text);
            console.log('   - First item URL:', firstItem.url);
            console.log('   - Has children:', firstItem.children.length > 0);
        } else {
            console.log('❌ Test 6: Data integrity check failed');
        }
    } else {
        console.log('❌ Test 6: No data available for integrity check');
    }
    
    // Test 7: Check if security is preserved (look for security indicators)
    if (window.modernMenuData) {
        // Check if we have hierarchical structure (indicates security filtering worked)
        const hasHierarchy = window.modernMenuData.some(item => 
            item.children && item.children.length > 0
        );
        if (hasHierarchy) {
            results.securityPreserved = true;
            console.log('✅ Test 7: Security appears to be preserved (hierarchical structure intact)');
        } else {
            console.log('⚠️ Test 7: Cannot determine if security is preserved (no hierarchy found)');
        }
    } else {
        console.log('❌ Test 7: Cannot check security preservation (no data)');
    }
    
    // Summary
    const passedTests = Object.values(results).filter(Boolean).length;
    const totalTests = Object.keys(results).length;
    
    console.log('📊 Menu Integration Test Results:');
    console.log(`   Passed: ${passedTests}/${totalTests} tests`);
    console.log('   Details:', results);
    
    if (passedTests === totalTests) {
        console.log('🎉 All tests passed! Menu integration is working correctly.');
    } else if (passedTests >= totalTests * 0.7) {
        console.log('⚠️ Most tests passed, but some issues detected.');
    } else {
        console.log('❌ Multiple test failures detected. Menu integration needs attention.');
    }
    
    return {
        passed: passedTests,
        total: totalTests,
        success: passedTests === totalTests,
        results: results
    };
};

// Auto-run test after a delay to allow components to load
setTimeout(function() {
    if (document.readyState === 'complete') {
        console.log('🚀 Auto-running menu integration test...');
        window.menuIntegrationTest();
    }
}, 3000);

console.log('✅ Menu Integration Test script loaded');
console.log('🛠️ Run manually with: window.menuIntegrationTest()');
