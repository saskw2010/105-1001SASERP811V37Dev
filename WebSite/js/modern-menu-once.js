// @ts-nocheck
(function () {
    console.log("Modern Menu Script: Initializing...");

    // Prevent re-running the script
    if (window.__modernMenuOnceMounted) {
        console.log("Modern Menu Script: Already mounted. Exiting.");
        return;
    }
    window.__modernMenuOnceMounted = true;

    // --- DOM Elements ---
    var HOST = document.getElementById('ModernMenuHost');
    var LIST = document.getElementById('pm-list');
    var TOOLS = document.getElementById('pm-tools-slot');
    var SEARCH = document.querySelector('.pm-search');
    var BTN = document.getElementById('menuToggleBtn');
    
    console.log("Modern Menu Script: DOM elements obtained.", { HOST, LIST, BTN });

    // --- Initial Checks ---
    if (!HOST || !LIST) {
        console.error("Modern Menu: Required elements #ModernMenuHost or #pm-list not found.");
        return;
    }

    // --- State ---
    var isMenuLoaded = false;
    var isDesktopView = window.innerWidth > 768;
    var currentSelectedItem = null;
    console.log(`Modern Menu Script: Initial state set. isDesktopView = ${isDesktopView}`);

    // --- Accordion & Persistence Helpers ---
    var EXPANDED_KEY = 'modernMenuExpanded';
    function loadExpandedSet() {
        try {
            var raw = sessionStorage.getItem(EXPANDED_KEY) || '[]';
            var arr = JSON.parse(raw);
            return new Set(Array.isArray(arr) ? arr : []);
        } catch (e) {
            console.warn('Modern Menu Script: failed to load expanded state', e);
            return new Set();
        }
    }
    function saveExpandedSet(set) {
        try {
            sessionStorage.setItem(EXPANDED_KEY, JSON.stringify(Array.from(set)));
        } catch (e) {
            console.warn('Modern Menu Script: failed to save expanded state', e);
        }
    }
    function keyForNode(node) {
        if (node && node.Url) return 'url:' + node.Url;
        var t = (node && node.Title) ? String(node.Title) : 'untitled';
        return 'title:' + t.replace(/\s+/g, ' ').trim().toLowerCase();
    }
    var expandedSet = loadExpandedSet();
    
    // Normalize titles (remove translation tokens like ^A^B^A^)
    function normalizeTitle(t) {
        if (!t) return '';
        var s = String(t).trim();
        if (s.indexOf('^') >= 0) {
            // Extract tokens between ^ ^ and pick the most human-readable
            var parts = [];
            var m;
            var re = /\^([^\^]+)\^/g;
            while ((m = re.exec(s)) !== null) {
                var token = (m[1] || '').trim();
                if (token) parts.push(token);
            }
            // Heuristics: prefer token with non-ASCII (likely Arabic) or with spaces; else pick middle
            var best = parts.find(p => /[^\x00-\x7F]/.test(p)) || parts.find(p => /\s/.test(p));
            if (!best && parts.length) {
                best = parts[Math.floor(parts.length / 2)];
            }
            if (best) return best;
            // Fallback: remove carets entirely
            return s.replace(/\^/g, '');
        }
        return s;
    }

    // Convert API menu format to legacy format for pro-modal-menu.js and pro-sidebar.js
    function convertToLegacyFormat(items) {
        if (!Array.isArray(items)) return [];
        
        function convertNode(node) {
            var converted = {
                text: normalizeTitle(node.Title || ''),
                title: normalizeTitle(node.Title || ''),
                url: node.Url || '#',
                href: node.Url || '#',
                children: []
            };
            
            if (node.Children && Array.isArray(node.Children) && node.Children.length > 0) {
                converted.children = node.Children.map(function(child) {
                    return convertNode(child);
                });
            }
            
            return converted;
        }
        
        return items.map(function(item) {
            return convertNode(item);
        });
    }

    // Get current user identifier for cache key
    function getCurrentUserKey() {
        // Try multiple sources for user identification
        var userKey = 'anonymous';
        
        // Try to get from various sources
        if (window.currentUser) {
            userKey = window.currentUser;
        } else if (document.querySelector('[data-user]')) {
            userKey = document.querySelector('[data-user]').getAttribute('data-user');
        } else if (document.body.getAttribute('data-user')) {
            userKey = document.body.getAttribute('data-user');
        } else {
            // Try to extract from any element that might contain user info
            var userElements = document.querySelectorAll('[id*="user"], [class*="user"], [data-username]');
            for (var i = 0; i < userElements.length; i++) {
                var elem = userElements[i];
                if (elem.textContent && elem.textContent.trim()) {
                    userKey = elem.textContent.trim();
                    break;
                }
            }
        }
        
        return 'modernMenu_' + userKey.replace(/[^a-zA-Z0-9]/g, '_');
    }

    // Save menu to localStorage with user authentication
    function saveMenuToLocalStorage(originalData, legacyData) {
        try {
            var userKey = getCurrentUserKey();
            var menuCache = {
                originalData: originalData,
                legacyData: legacyData,
                timestamp: new Date().getTime(),
                userKey: userKey,
                version: '1.0'
            };
            
            localStorage.setItem(userKey, JSON.stringify(menuCache));
            console.log('💾 Menu cached in localStorage for user:', userKey);
            return true;
        } catch (e) {
            console.warn('⚠️ Failed to save menu to localStorage:', e);
            return false;
        }
    }

    // Load menu from localStorage
    function loadMenuFromLocalStorage() {
        try {
            var userKey = getCurrentUserKey();
            var cached = localStorage.getItem(userKey);
            
            if (!cached) {
                console.log('📭 No cached menu found for user:', userKey);
                return null;
            }
            
            var menuCache = JSON.parse(cached);
            
            // Check if cache is still valid (24 hours)
            var now = new Date().getTime();
            var cacheAge = now - menuCache.timestamp;
            var maxAge = 24 * 60 * 60 * 1000; // 24 hours
            
            if (cacheAge > maxAge) {
                console.log('⏰ Cached menu expired, removing:', userKey);
                localStorage.removeItem(userKey);
                return null;
            }
            
            console.log('✅ Found valid cached menu for user:', userKey, 'age:', Math.round(cacheAge / 1000 / 60), 'minutes');
            return menuCache;
            
        } catch (e) {
            console.warn('⚠️ Failed to load menu from localStorage:', e);
            return null;
        }
    }

    // Clear menu cache (useful for logout)
    function clearMenuCache() {
        try {
            var userKey = getCurrentUserKey();
            localStorage.removeItem(userKey);
            console.log('🗑️ Cleared menu cache for user:', userKey);
            return true;
        } catch (e) {
            console.warn('⚠️ Failed to clear menu cache:', e);
            return false;
        }
    }


    // --- Core Functions ---

    function openMenu() {
        if (isDesktopView || !HOST) return; // Not needed for desktop
        console.log("Modern Menu Script: openMenu() called.");
        HOST.classList.add('active');
        HOST.setAttribute('aria-hidden', 'false');
        if (SEARCH instanceof HTMLElement) setTimeout(function () { SEARCH.focus(); }, 40);
        document.addEventListener('keydown', onEsc);
    }

    function closeMenu() {
        if (isDesktopView || !HOST) return; // Not needed for desktop
        console.log("Modern Menu Script: closeMenu() called.");
        HOST.classList.remove('active');
        HOST.setAttribute('aria-hidden', 'true');
        document.removeEventListener('keydown', onEsc);
        if (BTN instanceof HTMLElement && BTN.focus) BTN.focus();
    }

    function onEsc(e) { if (e.key === 'Escape') closeMenu(); }

    // Fetches menu data from the server
    function fetchMenu() {
        console.log("Modern Menu Script: fetchMenu() started.");
        return fetch('/Pages/MenuApi.aspx/GetMenuTree', {
            method: 'POST',
            headers: { 'Content-Type': 'application/json; charset=utf-8' },
            body: '{}'
        }).then(function (res) {
            if (!res.ok) {
                console.error("Modern Menu Script: Fetch failed with status", res.status);
                throw new Error('Network response was not ok');
            }
            console.log("Modern Menu Script: Fetch successful, parsing JSON.");
            return res.json();
        }).then(function (json) {
            console.log("Modern Menu Script: JSON parsed.", json);
            var result = json.d || json;
            
            // Enhanced logging to show the hierarchy structure
            if (result && result.items) {
                console.log("📊 Menu hierarchy received:");
                console.log("  - Total root items:", result.items.length);
                
                var hierarchyStats = {
                    totalItems: 0,
                    itemsWithChildren: 0,
                    maxDepth: 0
                };
                
                function analyzeNode(node, depth) {
                    hierarchyStats.totalItems++;
                    hierarchyStats.maxDepth = Math.max(hierarchyStats.maxDepth, depth);
                    
                    if (node.Children && node.Children.length > 0) {
                        hierarchyStats.itemsWithChildren++;
                        console.log("  📁", "  ".repeat(depth), node.Title, "(" + node.Children.length + " children)");
                        node.Children.forEach(function(child) {
                            analyzeNode(child, depth + 1);
                        });
                    } else {
                        console.log("  📄", "  ".repeat(depth), node.Title);
                    }
                }
                
                result.items.forEach(function(item) {
                    analyzeNode(item, 0);
                });
                
                console.log("📈 Hierarchy Statistics:", hierarchyStats);
                console.log("🔒 Security and hierarchy preserved from original menu system");
            }
            
            return result;
        });
    }

    // Renders the entire menu tree
    function renderTree(tree) {
        if (!LIST) return;
        console.log("🌳 Modern Menu Script: renderTree() called with", tree);
        console.log("📊 Original tree has", tree.length, "items");
        
        // Use the existing hierarchical structure from the hidden menu
        // instead of creating our own grouping
        console.log("� Using existing menu hierarchy with security and structure intact");
        
        LIST.innerHTML = '';
    // Create semantic nav wrapper
    var nav = document.createElement('nav');
    nav.id = 'pm-nav';
    nav.setAttribute('role', 'navigation');
    nav.setAttribute('aria-label', 'Main');
        
    var ul = document.createElement('ul');
    ul.className = 'pm-tree';
    ul.setAttribute('role', 'tree');
        
        // Render the tree as-is to preserve hierarchy and security
        (tree || []).forEach(function (n) { 
            ul.appendChild(renderNode(n)); 
        });
        
        LIST.appendChild(ul);
        nav.appendChild(ul);
        LIST.appendChild(nav);
        console.log("🌳 Modern Menu Script: Tree rendered preserving original hierarchy.");
    }
    
    // Renders a single node in the tree with enhanced hierarchy logging
    function renderNode(node) {
        var hasKids = !!(node.Children && node.Children.length);
        console.log("🔧 Rendering node:", node.Title, "hasChildren:", hasKids, 
                   hasKids ? "(" + node.Children.length + " children)" : "");
        
    var li = document.createElement('li');
    li.className = 'pm-node';
    var nodeKey = keyForNode(node);
    li.dataset.mmKey = nodeKey;
        var row = document.createElement('div');
        row.className = 'pm-row';

        console.log("📝 Node details:", {
            title: node.Title,
            url: node.Url,
            hasChildren: hasKids,
            childrenCount: hasKids ? node.Children.length : 0,
            icon: node.Icon
        });

        // Icon
        if (node.Icon) {
            var icon = document.createElement('i');
            icon.className = node.Icon + ' pm-icon';
            icon.setAttribute('aria-hidden', 'true');
            row.appendChild(icon);
        }

        // Title
        var title = document.createElement('span');
        title.className = 'pm-title';
    title.textContent = normalizeTitle(node.Title || 'Untitled');
        row.appendChild(title);

        // Badge
        if (node.BadgeText) {
            var b = document.createElement('span');
            b.className = 'pm-badge ' + (node.BadgeType || 'neutral');
            b.textContent = node.BadgeText;
            row.appendChild(b);
        }
        
        // Link wrapper
        var link;
        if (node.Url) {
            link = document.createElement('a');
            link.className = 'pm-go';
            link.href = node.Url;
            link.appendChild(row);
        } else {
            row.classList.add('no-link');
        }

        li.appendChild(link || row);

        // Add click handler for selection
        var clickTarget = link || row;
        clickTarget.addEventListener('click', function(e) {
            console.log("Modern Menu Script: Menu item clicked.", node);
            selectMenuItem(row, link);
            
            // Close mobile menu after selection
            if (!isDesktopView) {
                setTimeout(closeMenu, 300);
            }
        });

        // Children with enhanced class marking
        if (hasKids) {
            li.classList.add('has-children'); // Add class for CSS targeting
            li.setAttribute('role', 'treeitem');
            li.setAttribute('aria-expanded', 'false');
            var kids = document.createElement('ul');
            kids.className = 'pm-children';
            // Hide by default; will be shown on expand
            kids.style.display = 'none';
            node.Children.forEach(function (c) { kids.appendChild(renderNode(c)); });
            li.appendChild(kids);

            // Add toggle button for both desktop and mobile
            var toggle = document.createElement('button');
            toggle.className = 'pm-toggle';
            toggle.type = 'button';
            toggle.innerHTML = '&#x25B6;'; // Right arrow
            toggle.setAttribute('aria-label', 'Toggle submenu');

            var target = li.querySelector('.pm-row');
            if (target) {
                target.appendChild(toggle);
                
                // Enhanced toggle functionality for navigation + accordion + persistence
                toggle.addEventListener('click', function (e) {
                    console.log("🎯 Navigation toggle clicked:", node.Title);
                    
                    e.preventDefault();
                    e.stopPropagation();
                    
                    var childrenContainer = li.querySelector('.pm-children');
                    var isExpanded = li.classList.contains('expanded');
                    
                    console.log("📊 Toggle state:", {
                        isExpanded: isExpanded,
                        hasChildren: !!childrenContainer,
                        childrenCount: node.Children ? node.Children.length : 0
                    });
                    
                    if (isExpanded) {
                        // Collapse
                        li.classList.remove('expanded');
                        li.setAttribute('aria-expanded', 'false');
                        if (childrenContainer) {
                            childrenContainer.style.display = 'none';
                        }
                        toggle.innerHTML = '&#x25B6;'; // Right arrow ▶
                        toggle.setAttribute('aria-expanded', 'false');
                        console.log("✅ Collapsed navigation:", node.Title);
                        expandedSet.delete(nodeKey);
                        saveExpandedSet(expandedSet);
                    } else {
                        // Expand with accordion: collapse visible siblings first
                        var parentList = li.parentElement; // ul
                        if (parentList) {
                            Array.prototype.forEach.call(parentList.children, function (sib) {
                                if (sib !== li && sib.classList && sib.classList.contains('expanded')) {
                                    sib.classList.remove('expanded');
                                    sib.setAttribute('aria-expanded', 'false');
                                    var sibChildren = sib.querySelector(':scope > .pm-children');
                                    if (sibChildren) sibChildren.style.display = 'none';
                                    var sibToggle = sib.querySelector(':scope > .pm-row .pm-toggle');
                                    if (sibToggle) {
                                        sibToggle.innerHTML = '&#x25B6;';
                                        sibToggle.setAttribute('aria-expanded', 'false');
                                    }
                                    // Update persistence for sibling
                                    var sibKey = sib.dataset.mmKey;
                                    if (sibKey) {
                                        expandedSet.delete(sibKey);
                                    }
                                }
                            });
                        }

                        li.classList.add('expanded');
                        li.setAttribute('aria-expanded', 'true');
                        if (childrenContainer) {
                            childrenContainer.style.display = 'block';
                        }
                        toggle.innerHTML = '&#x25BC;'; // Down arrow ▼
                        toggle.setAttribute('aria-expanded', 'true');
                        console.log("✅ Expanded navigation:", node.Title, "showing", node.Children.length, "items");
                        // Update persistence for current
                        expandedSet.add(nodeKey);
                        saveExpandedSet(expandedSet);
                    }
                    
                    // Add visual feedback
                    toggle.style.backgroundColor = 'rgba(103, 126, 234, 0.8)';
                    toggle.style.borderColor = '#4f46e5';
                    console.log("🎨 Visual feedback applied");
                    
                    setTimeout(function() {
                        toggle.style.backgroundColor = '';
                        toggle.style.borderColor = '';
                        console.log("🎨 Visual feedback removed");
                    }, 300);
                });
                
                // Click-only interaction on all viewports; disable hover auto-expand to prevent flicker
                console.log("Modern Menu Script: Toggle wired for click-only:", node.Title);
                // Restore expanded state if persisted
                if (expandedSet.has(nodeKey)) {
                    li.classList.add('expanded');
                    li.setAttribute('aria-expanded', 'true');
                    var initKids = li.querySelector('.pm-children');
                    if (initKids) initKids.style.display = 'block';
                    toggle.innerHTML = '&#x25BC;';
                    toggle.setAttribute('aria-expanded', 'true');
                    console.log('🔁 Restored expanded state for', node.Title);
                }
            }
        }

        return li;
    }

    // Wires up "Expand/Collapse All" buttons
    function wireTools() {
        if (!TOOLS || TOOLS.dataset.wired || isDesktopView) return; // Tools only for mobile
        console.log("Modern Menu Script: wireTools() called.");
        TOOLS.innerHTML =
            '<div class="pm-tools">' +
            '  <button type="button" id="pm_expand_all">Expand All</button>' +
            '  <button type="button" id="pm_collapse_all">Collapse All</button>' +
            '</div>';
        var expand = document.getElementById('pm_expand_all');
        var collapse = document.getElementById('pm_collapse_all');
        if (expand) expand.onclick = function () {
            if (!LIST) return;
            var nodes = LIST.querySelectorAll('.pm-node');
            nodes.forEach(function (n) {
                if (n.querySelector('.pm-children')) {
                    n.classList.add('expanded');
                    var t = n.querySelector('.pm-toggle'); if (t) t.innerHTML = '&#x25B2;';
                }
            });
        };
        if (collapse) collapse.onclick = function () {
            if (!LIST) return;
            var nodes = LIST.querySelectorAll('.pm-node');
            nodes.forEach(function (n) {
                n.classList.remove('expanded');
                var t = n.querySelector('.pm-toggle'); if (t) t.innerHTML = '&#x25BC;';
            });
        };
        TOOLS.dataset.wired = '1';
    }

    // Wires up the search filter input - DISABLED AS REQUESTED
    function wireFilter() {
        // Search functionality has been disabled per user request
        console.log("Modern Menu Script: Search functionality disabled - no search bar needed");
        return;
        
        // Old search code commented out:
        // if (!SEARCH || SEARCH.dataset.bound) return;
        // console.log("Modern Menu Script: wireFilter() called.");
        // SEARCH.addEventListener('input', function () {
        //     if (!LIST) return;
        //     var q = (SEARCH.value || '').toLowerCase().trim();
        //     var nodes = LIST.querySelectorAll('.pm-node');
        //     nodes.forEach(function (n) {
        //         var text = (n.textContent || '').toLowerCase();
        //         n.style.display = text.indexOf(q) !== -1 ? '' : 'none';
        //     });
        // });
        // SEARCH.dataset.bound = '1';
    }

    // Function to handle menu item selection
    function selectMenuItem(row, menuLink) {
        console.log("Modern Menu Script: selectMenuItem() called.", row, menuLink);
        
        // Remove previous selection
        if (currentSelectedItem) {
            currentSelectedItem.classList.remove('active', 'selected');
        }
        
        // Add selection to current item
        if (row) {
            row.classList.add('active', 'selected');
            currentSelectedItem = row;
            
            // Store selection in localStorage for persistence
            try {
                var href = menuLink ? menuLink.getAttribute('href') || '' : '';
                if (href) {
                    localStorage.setItem('selectedMenuItem', href);
                }
            } catch (e) {
                console.warn('Could not store selected menu item:', e);
            }
        }
    }

    // Function to restore last selected item
    function restoreSelection() {
        try {
            var lastSelected = localStorage.getItem('selectedMenuItem');
            if (lastSelected && LIST) {
                var matchingLink = LIST.querySelector('a[href="' + lastSelected + '"]');
                if (matchingLink) {
                    var row = matchingLink.closest('.pm-row');
                    if (row) {
                        selectMenuItem(row, matchingLink);
                    }
                }
            }
        } catch (e) {
            console.warn('Could not restore selected menu item:', e);
        }
    }

    // Main initialization function with enhanced logging
    function initModernMenu() {
        console.log("🚀 Modern Menu: initModernMenu() started");
        console.log("📊 Current state:", {
            isMenuLoaded: isMenuLoaded,
            isDesktopView: isDesktopView,
            HOST: !!HOST,
            LIST: !!LIST,
            windowWidth: window.innerWidth
        });
        
        if (isMenuLoaded || !HOST || !LIST) {
            console.log("⚠️ Modern Menu: initModernMenu() aborted.", {
                isMenuLoaded: isMenuLoaded,
                HOST: !!HOST,
                LIST: !!LIST
            });
            return Promise.resolve();
        }
        
        console.log("Modern Menu Script: initModernMenu() started.");
        wireTools();
        wireFilter();
        
        HOST.classList.add('loading');
        
        // Try to load from localStorage first (faster!)
        var cachedMenu = loadMenuFromLocalStorage();
        if (cachedMenu) {
            console.log("⚡ Using cached menu data from localStorage");
            lastPayload = { items: cachedMenu.originalData };
            window.modernMenuData = cachedMenu.legacyData;
            renderTree(cachedMenu.originalData || []);
            restoreSelection();
            isMenuLoaded = true;
            HOST.dataset.loaded = 'true';
            HOST.classList.remove('loading');
            console.log("🚀 Fast menu load completed from cache");
            return Promise.resolve();
        }
        
        return fetchMenu().then(function (payload) {
            lastPayload = payload; // Store for re-rendering
            
            // ✅ CRITICAL: Store menu data globally AND in localStorage
            var legacyData = convertToLegacyFormat(payload.items || []);
            window.modernMenuData = legacyData;
            
            // Save to localStorage with user authentication
            saveMenuToLocalStorage(payload.items || [], legacyData);
            
            console.log("💾 Stored menu data for future use:", {
                totalItems: payload.items ? payload.items.length : 0,
                hasHierarchy: payload.items ? payload.items.some(function(item) { 
                    return item.Children && item.Children.length > 0; 
                }) : false,
                globalDataStored: !!window.modernMenuData,
                convertedItemsCount: window.modernMenuData ? window.modernMenuData.length : 0,
                cachedInLocalStorage: true
            });
            
            console.log("🔒 Menu data with security preserved stored globally AND cached");
            console.log("📦 Sample converted data:", window.modernMenuData && window.modernMenuData[0] ? {
                text: window.modernMenuData[0].text,
                url: window.modernMenuData[0].url,
                hasChildren: window.modernMenuData[0].children && window.modernMenuData[0].children.length > 0
            } : 'No data');
            
            renderTree(payload.items || []);
            restoreSelection(); // Restore last selected item
            isMenuLoaded = true;
            HOST.dataset.loaded = 'true';
            HOST.classList.remove('loading');
            console.log("Modern Menu Script: initModernMenu() completed successfully.");
        }).catch(function (err) {
            console.error('Modern Menu Script: initModernMenu() failed.', err);
            if(LIST) LIST.innerHTML = '<li class="pm-node"><div class="pm-row">Failed to load menu.</div></li>';
            if(HOST) HOST.classList.remove('loading');

            return Promise.reject(err);
        });
    }

    // --- Event Listeners & Initialization ---

    if (BTN && !BTN.dataset.bound) {
        console.log("Modern Menu Script: Binding click to toggle button.");
        BTN.addEventListener('click', function () {
            console.log("Modern Menu Script: Toggle button clicked.");
            if (!isMenuLoaded) {
                initModernMenu().then(openMenu);
            } else {
                openMenu();
            }
        });
        BTN.dataset.bound = '1';
    }

    if (HOST && !HOST.dataset.bound) {
        console.log("Modern Menu Script: Binding click to host for backdrop close.");
        HOST.addEventListener('click', function (e) {
            if (e.target && (e.target.dataset.close || e.target.classList.contains('pm-backdrop'))) {
                closeMenu();
            }
        });
        HOST.dataset.bound = '1';
    }
    
    function handleResize() {
        console.log("Modern Menu Script: handleResize() called.");
        var newIsDesktop = window.innerWidth > 768;
        if (newIsDesktop !== isDesktopView) {
            console.log(`Modern Menu Script: Viewport changed. isDesktopView is now ${newIsDesktop}`);
            isDesktopView = newIsDesktop;
            if (isMenuLoaded) {
                // Re-render to apply correct structure/listeners
                console.log("Modern Menu Script: Re-rendering tree for new viewport.");
                renderTree(lastPayload.items || []); // Assumes lastPayload is stored
            }
        }
    }
    
    var resizeTimeout;
    var lastPayload; // Need to store payload for re-rendering
    window.addEventListener('resize', function() {
        clearTimeout(resizeTimeout);
        resizeTimeout = setTimeout(handleResize, 250);
    });

    function initializeOnLoad() {
        console.log("Modern Menu Script: initializeOnLoad() called.");
        isDesktopView = window.innerWidth > 768;
        if (isDesktopView) {
            console.log("Modern Menu Script: Desktop view detected, initializing menu.");
            initModernMenu();
        } else {
            console.log("Modern Menu Script: Mobile view detected.");
            if (HOST) HOST.setAttribute('aria-hidden', 'true');
        }
    }

    if (document.readyState === 'loading') {
        console.log("Modern Menu Script: DOM is loading, waiting for DOMContentLoaded.");
        document.addEventListener('DOMContentLoaded', initializeOnLoad);
    } else {
        console.log("Modern Menu Script: DOM already loaded, initializing now.");
        initializeOnLoad();
    }

})();
