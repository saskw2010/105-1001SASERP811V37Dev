// Menu Data Bridge - Connects modern-menu-once.js with pro-modal-menu.js and pro-sidebar.js
// This script ensures menu data with security is properly shared between components

(function() {
    console.log('🌉 Menu Data Bridge: Initializing...');
    
    // Prevent repeated noisy warnings
    var _warnedOnce = false;

    // Check if window.modernMenuData exists or can be loaded from cache
    function checkMenuData() {
        // First check global variable
        if (window.modernMenuData && Array.isArray(window.modernMenuData)) {
            console.log('✅ Menu Data Bridge: window.modernMenuData is available!');
            console.log('📊 Menu Data Stats:', {
                totalRootItems: window.modernMenuData.length,
                source: 'global variable',
                firstItem: window.modernMenuData[0] ? {
                    text: window.modernMenuData[0].text,
                    url: window.modernMenuData[0].url,
                    hasChildren: !!(window.modernMenuData[0].children && window.modernMenuData[0].children.length)
                } : null
            });
            try { document.dispatchEvent(new CustomEvent('modernMenu:dataReady', { detail: window.modernMenuData })); } catch(e) {}
            return true;
        }
        
        // Try to load from localStorage as fallback
        try {
            var userKey = getCurrentUserKey();
            var cached = localStorage.getItem(userKey);
            if (cached) {
                var menuCache = JSON.parse(cached);
                if (menuCache.legacyData && Array.isArray(menuCache.legacyData)) {
                    window.modernMenuData = menuCache.legacyData;
                    console.log('✅ Menu Data Bridge: Loaded from localStorage cache!');
                    console.log('📊 Cached Menu Stats:', {
                        totalRootItems: menuCache.legacyData.length,
                        source: 'localStorage cache',
                        cacheAge: Math.round((new Date().getTime() - menuCache.timestamp) / 1000 / 60) + ' minutes'
                    });
                    try { document.dispatchEvent(new CustomEvent('modernMenu:dataReady', { detail: window.modernMenuData })); } catch(e) {}
                    return true;
                }
            }
        } catch (e) {
            console.warn('⚠️ Menu Data Bridge: Failed to load from cache:', e);
        }
        
        if (!_warnedOnce) {
            console.info('ℹ Menu Data Bridge: window.modernMenuData not available yet');
            _warnedOnce = true;
        }
        return false;
    }
    
    // Helper function to get user key (same as in modern-menu-once.js)
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
    
    // Wait for menu data to be available
    function waitForMenuData(callback, maxAttempts = 20) {
        let attempts = 0;
        
        const check = () => {
            attempts++;
            
            if (checkMenuData()) {
                console.log(`✅ Menu Data Bridge: Data found on attempt ${attempts}`);
                callback(window.modernMenuData);
                return;
            }
            
            if (attempts >= maxAttempts) {
                console.warn(`⏰ Menu Data Bridge: Timeout after ${maxAttempts} attempts, trying legacy DOM extraction...`);
                // Try to extract legacy menu from #PageMenuBar if present
                try {
                    var legacy = extractFromLegacyDom();
                    if (Array.isArray(legacy) && legacy.length) {
                        window.modernMenuData = legacy;
                        try { document.dispatchEvent(new CustomEvent('modernMenu:dataReady', { detail: window.modernMenuData })); } catch(e) {}
                        console.log('✅ Menu Data Bridge: Populated from legacy DOM');
                        callback(window.modernMenuData);
                        return;
                    }
                } catch (e) { /* ignore */ }
                console.error('❌ Menu Data Bridge: No data available (global/cache/legacy)');
                callback(null);
                return;
            }
            
            setTimeout(check, 200);
        };
        
        check();
    }

    // Minimal legacy DOM extractor (mirrors logic in pro-modal-menu.js)
    function extractFromLegacyDom() {
        var host = document.getElementById('PageMenuBar');
        if (!host) return [];
        var rootUl = host.querySelector('ul, .Menu, .Root, nav ul');
        if (!rootUl) return [];
        function walk(ul) {
            var arr = [];
            ul.querySelectorAll(':scope > li').forEach(function(li){
                var a = li.querySelector(':scope > a, :scope > span a, :scope > .link');
                var title = a ? (a.textContent || '').trim() : (li.getAttribute('title') || '').trim();
                var href = a && a.getAttribute('href') ? a.getAttribute('href') : '#';
                var childUl = li.querySelector(':scope > ul');
                arr.push({ text: title, url: href, children: childUl ? walk(childUl) : [] });
            });
            return arr;
        }
        return walk(rootUl);
    }
    
    // Expose utility functions globally
    window.menuDataBridge = {
        check: checkMenuData,
        wait: waitForMenuData,
        getData: function() {
            return window.modernMenuData || null;
        },
        debug: function() {
            console.log('🔍 Menu Data Bridge Debug:');
            console.log('  - window.modernMenuData exists:', !!window.modernMenuData);
            console.log('  - Is array:', Array.isArray(window.modernMenuData));
            console.log('  - Length:', window.modernMenuData ? window.modernMenuData.length : 0);
            console.log('  - Full data:', window.modernMenuData);
            return {
                exists: !!window.modernMenuData,
                isArray: Array.isArray(window.modernMenuData),
                length: window.modernMenuData ? window.modernMenuData.length : 0,
                data: window.modernMenuData
            };
        }
    };
    
    console.log('✅ Menu Data Bridge: Initialized');
    console.log('🛠️ Available functions:');
    console.log('  - window.menuDataBridge.check()');
    console.log('  - window.menuDataBridge.wait(callback)');
    console.log('  - window.menuDataBridge.getData()');
    console.log('  - window.menuDataBridge.debug()');
    
    // Initial check (quiet)
    setTimeout(function(){ checkMenuData(); }, 100);
})();
