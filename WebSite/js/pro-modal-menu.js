(function(){
  console.log('pro-modal-menu.js: 🟢 Script file loaded');
  function ready(fn){ if(document.readyState!=='loading'){ fn(); } else { document.addEventListener('DOMContentLoaded', fn); } }
  ready(function(){
    console.log('pro-modal-menu.js: 🚀 DOMContentLoaded');
    try {
      const menuHost = document.getElementById('ModernMenuHost');
      const toggleBtn = document.getElementById('menuToggleBtn');
      if (!menuHost || !toggleBtn) { console.warn('pro-modal-menu.js: ⚠️ Missing menuHost or toggleBtn', {menuHost: !!menuHost, toggleBtn: !!toggleBtn}); return; }

      const pmList = document.getElementById('pm-list');
      const pmTools = document.getElementById('pm-tools-slot');
      const STORAGE_KEY = 'pmExpandedNodes';
      const loadExpanded = ()=>{ try{ const r=localStorage.getItem(STORAGE_KEY); return r? new Set(JSON.parse(r)) : new Set(); }catch{ return new Set(); } };
      const saveExpanded = (s)=>{ try{ localStorage.setItem(STORAGE_KEY, JSON.stringify(Array.from(s))); }catch{} };
      function extractFromLegacyDom() {
        const host = document.getElementById('PageMenuBar');
        if (!host) return [];
        const rootUl = host.querySelector('ul, .Menu, .Root, nav ul');
        if (!rootUl) return [];
        const walk = (ul) => {
          const arr = [];
          ul.querySelectorAll(':scope > li').forEach(li => {
            const a = li.querySelector(':scope > a, :scope > span a, :scope > .link');
            const title = a ? (a.textContent || '').trim() : (li.getAttribute('title') || '').trim();
            const href = a && a.getAttribute('href') ? a.getAttribute('href') : '#';
            const childUl = li.querySelector(':scope > ul');
            arr.push({ text: title, url: href, children: childUl ? walk(childUl) : [] });
          });
          return arr;
        };
        return walk(rootUl);
      }

      function extractFromModernMenu() {
        // First try: global variable
        if (window.modernMenuData && Array.isArray(window.modernMenuData)) {
          console.log('pro-modal-menu.js: 📦 Using modern menu stored data');
          console.log('pro-modal-menu.js: 🔒 Menu data includes security from original system');
          console.log('pro-modal-menu.js: 📊 Found', window.modernMenuData.length, 'root items');
          return window.modernMenuData;
        }
        
        // Second try: localStorage cache
        try {
          var userKey = getCurrentUserKey();
          var cached = localStorage.getItem(userKey);
          if (cached) {
            var menuCache = JSON.parse(cached);
            if (menuCache.legacyData && Array.isArray(menuCache.legacyData)) {
              window.modernMenuData = menuCache.legacyData; // Set global for future use
              console.log('pro-modal-menu.js: 📦 Using cached menu data from localStorage');
              console.log('pro-modal-menu.js: 🔒 Cached menu includes security from original system');
              console.log('pro-modal-menu.js: 📊 Found', menuCache.legacyData.length, 'root items');
              return menuCache.legacyData;
            }
          }
        } catch (e) {
          console.warn('pro-modal-menu.js: ⚠️ Failed to load from cache:', e);
        }
        
        console.warn('pro-modal-menu.js: ⚠️ window.modernMenuData not available');
        return [];
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

      const nodeKey = (node, parentKey) => {
        const base = (node.url || node.href || node.text || node.title || 'node').toString();
        return parentKey ? parentKey + '>' + base : base;
      };
      // Build FLAT group: top-level node row + a flat list of all descendants as simple links
      function createFlatGroup(node, expandedSet) {
        const key = nodeKey(node, '');
        const li = document.createElement('li');
        li.setAttribute('role','treeitem');
        li.dataset.key = key;
        li.setAttribute('aria-expanded', expandedSet.has(key) ? 'true' : 'false');

        const row = document.createElement('div');
        row.className = 'pm-row';
        const toggle = document.createElement('button');
        toggle.type = 'button';
        toggle.className = 'pm-toggle';
        toggle.setAttribute('aria-label','Toggle');
        toggle.innerHTML = '<span class="caret">▸</span>';
        toggle.addEventListener('click', (e)=>{
          e.preventDefault(); e.stopPropagation();
          const expanded = li.getAttribute('aria-expanded') === 'true';
          const next = expanded ? 'false' : 'true';
          li.setAttribute('aria-expanded', next);
          if (next === 'true') expandedSet.add(key); else expandedSet.delete(key);
          saveExpanded(expandedSet);
        });
        row.appendChild(toggle);

        const a = document.createElement('a');
        a.textContent = node.text || node.title || 'Group';
        a.href = node.url || node.href || '#';
        a.className = 'pm-link';
        row.appendChild(a);
        li.appendChild(row);

        // Collect all descendants as flat links
        const flat = [];
        (function collect(n){
          if (Array.isArray(n.children)) {
            n.children.forEach(ch=>{
              flat.push(ch);
              collect(ch);
            });
          }
        })(node);

        const ul = document.createElement('ul'); ul.setAttribute('role','group');
        flat.forEach(ch => {
          const cli = document.createElement('li');
          cli.setAttribute('role','treeitem');
          const crow = document.createElement('div');
          crow.className = 'pm-row';
          const spacer = document.createElement('span'); spacer.style.width='24px'; spacer.style.display='inline-block'; spacer.setAttribute('aria-hidden','true');
          crow.appendChild(spacer);
          const ca = document.createElement('a');
          ca.className = 'pm-link';
          ca.href = ch.url || '#';
          ca.textContent = ch.text || 'Link';
          crow.appendChild(ca);
          cli.appendChild(crow);
          ul.appendChild(cli);
        });
        li.appendChild(ul);
        return li;
      }

      function highlightActive(pmListEl, expandedSet) {
        try {
          const current = window.location.pathname.toLowerCase();
          const links = pmListEl.querySelectorAll('a.pm-link[href]');
          let best=null; let bestLen=-1;
          links.forEach(a=>{
            const href=a.getAttribute('href'); if(!href || href==='#') return;
            const urlPath = href.split('#')[0].split('?')[0].toLowerCase();
            if (current.endsWith(urlPath) || current.indexOf(urlPath)>=0) { if (urlPath.length>bestLen){ best=a; bestLen=urlPath.length; } }
          });
          if (best) {
            best.classList.add('active');
            // expand parents
            let p = best.closest('li[role="treeitem"]');
            while (p) {
              const key = p.dataset.key;
              if (p.querySelector('ul')) {
                p.setAttribute('aria-expanded', 'true');
                if (key) expandedSet.add(key);
              }
              p = p.parentElement && p.parentElement.closest ? p.parentElement.closest('li[role="treeitem"]') : null;
            }
            saveExpanded(expandedSet);
          }
        } catch {}
      }

      function ensureLegacyStyles(){
        if (document.getElementById('legacyMenuStyles')) return;
        const style = document.createElement('style');
        style.id = 'legacyMenuStyles';
        style.textContent = `
          .legacy-menu-items{padding:.5rem .5rem 1rem;}
          .legacy-menu-item{display:flex;align-items:center;gap:.6rem;padding:.6rem .75rem;border-radius:10px;cursor:pointer;color:#334155;background:#f8fafc;margin:.25rem 0;transition:background .2s,transform .2s}
          .legacy-menu-item:hover{background:#eef2ff;transform:translateX(-2px)}
          .legacy-menu-item i{color:#64748b}
          .legacy-menu-item.has-submenu{justify-content:space-between;background:#f1f5f9}
          .legacy-menu-item.has-submenu .submenu-arrow{transition:transform .2s;color:#64748b}
          .legacy-menu-item.has-submenu.open .submenu-arrow{transform:rotate(180deg)}
          .legacy-menu-subitems{display:none;padding:.25rem .25rem .5rem;border-inline-start:3px solid #e5e7eb;margin-inline-start:.5rem}
          .legacy-menu-item.has-submenu.open + .legacy-menu-subitems{display:block}
          .legacy-menu-subitem{display:flex;align-items:center;gap:.5rem;padding:.5rem .6rem;border-radius:8px;color:#334155;text-decoration:none;background:#ffffff;margin:.2rem 0;transition:background .2s,transform .2s}
          .legacy-menu-subitem:hover{background:#eef2ff;transform:translateX(-2px)}
          .legacy-menu-subitem i{color:#475569}
        `;
        document.head.appendChild(style);
      }

      function navigateToPage(el){
        try { const url = el && el.getAttribute('data-url'); if (url && url !== '#') window.location.href = url; } catch {}
      }
      function toggleSubmenu(el, store){
        try {
          const groupEl = el.closest('.legacy-menu-item.has-submenu');
          if (!groupEl) return; 
          const key = groupEl.getAttribute('data-key')||'';
          const open = !groupEl.classList.contains('open');
          groupEl.classList.toggle('open', open);
          if (store){
            const expandedSet = store.load();
            if (open) expandedSet.add(key); else expandedSet.delete(key);
            store.save(expandedSet);
          }
        } catch {}
      }

      function waitForLegacyMenu(onReady, onTimeout){
        let attempts = 0;
        const maxAttempts = 10;
        const tick = ()=>{
          attempts++;
          const host = document.getElementById('PageMenuBar');
          const ul = host && host.querySelector('ul, .Menu, .Root, nav ul');
          if (ul) {
            console.log(`pro-modal-menu.js: ✅ Legacy menu found on attempt ${attempts}`);
            return onReady();
          }
          if (attempts >= maxAttempts) {
            console.warn(`pro-modal-menu.js: ⏰ Timed out after ${maxAttempts} attempts`);
            return onTimeout ? onTimeout() : null;
          }
          setTimeout(tick, 100);
        };
        tick();
      }


      async function loadDefaultMenu() {
        try {
          console.log('pro-modal-menu.js: 📥 Loading default menu from JSON...');
          const response = await fetch('/js/default-menu.json');
          if (!response.ok) throw new Error('Failed to load default menu');
          const data = await response.json();
          console.log('pro-modal-menu.js: ✅ Default menu loaded successfully');
          return data;
        } catch (err) {
          console.error('pro-modal-menu.js: ❌ Failed to load default menu', err);
          return [];
        }
      }

      function renderPanel() {
        if (!pmList) return;
        
        // Try different data sources in order
        let items = extractFromLegacyDom();
        if (!Array.isArray(items) || !items.length) {
          console.log('pro-modal-menu.js: ⚠️ No legacy DOM, trying modern menu');
          items = extractFromModernMenu();
        }
        if (!Array.isArray(items) || !items.length && window.fallbackMenuData) {
          console.log('pro-modal-menu.js: 📦 Using fallback menu data');
          items = window.fallbackMenuData;
        }
        if (!Array.isArray(items) || !items.length) {
          console.warn('pro-modal-menu.js: ❌ No menu data available');
          return;
        }
        
        console.log('pro-modal-menu.js: ✅ Rendering panel with', items.length, 'root items');

        // Determine desired depth
        const maxDepth = (window.ModernMenuConfig && window.ModernMenuConfig.maxDepth) ? window.ModernMenuConfig.maxDepth : 3;

        // Prepare container
        pmList.innerHTML = '';
        pmList.style.display = '';
        const panel = menuHost.querySelector('.pm-panel') || menuHost;
        if (pmTools && !pmTools.dataset.toolsReady) {
          pmTools.innerHTML = '';
          const toolsBar = document.createElement('div');
          toolsBar.style.display = 'flex'; toolsBar.style.gap = '0.5rem'; toolsBar.style.padding = '0.5rem 0.75rem';
          const btnExpandAll = document.createElement('button'); btnExpandAll.type='button'; btnExpandAll.className='membership-btn'; btnExpandAll.textContent='Expand All';
          const btnCollapseAll = document.createElement('button'); btnCollapseAll.type='button'; btnCollapseAll.className='membership-btn'; btnCollapseAll.textContent='Collapse All';
          pmTools.appendChild(toolsBar); toolsBar.appendChild(btnExpandAll); toolsBar.appendChild(btnCollapseAll);
          pmTools.dataset.toolsReady = '1';
        }

        const expandedSet = loadExpanded();

        // Build nested tree
        pmList.setAttribute('role','tree');
        const buildTree = (nodes, parentEl, level, parentKey) => {
          if (!Array.isArray(nodes)) return;
          nodes.forEach(node => {
            const key = nodeKey(node, parentKey||'');
            const li = document.createElement('li');
            li.setAttribute('role','treeitem');
            li.dataset.key = key;
            li.classList.add(`level-${level}`);

            const row = document.createElement('div');
            row.className = 'pm-row';

            const hasChildren = Array.isArray(node.children) && node.children.length>0 && level < (maxDepth-1);
            if (hasChildren){
              const toggle = document.createElement('button');
              toggle.type = 'button';
              toggle.className = 'pm-toggle';
              toggle.setAttribute('aria-label','Toggle');
              toggle.innerHTML = '<span class="caret">▸</span>';
              toggle.addEventListener('click', (e)=>{
                e.preventDefault(); e.stopPropagation();
                const expanded = li.getAttribute('aria-expanded') === 'true';
                const next = expanded ? 'false' : 'true';
                li.setAttribute('aria-expanded', next);
                if (next === 'true') expandedSet.add(key); else expandedSet.delete(key);
                saveExpanded(expandedSet);
              });
              row.appendChild(toggle);
              li.setAttribute('aria-expanded', expandedSet.has(key) ? 'true' : 'false');
            } else {
              const spacer = document.createElement('span');
              spacer.style.width='24px'; spacer.style.display='inline-block'; spacer.setAttribute('aria-hidden','true');
              row.appendChild(spacer);
            }

            const a = document.createElement('a');
            a.textContent = node.text || node.title || 'Item';
            a.href = node.url || node.href || '#';
            a.className = 'pm-link';
            row.appendChild(a);
            li.appendChild(row);

            if (hasChildren){
              const ul = document.createElement('ul');
              ul.setAttribute('role','group');
              li.appendChild(ul);
              buildTree(node.children, ul, level+1, key);
            }

            parentEl.appendChild(li);
          });
        };

        const rootUl = document.createElement('ul');
        rootUl.setAttribute('role','group');
        pmList.appendChild(rootUl);
        buildTree(items, rootUl, 0, '');

        // Highlight current link and expand its parents
        highlightActive(pmList, expandedSet);

        // Wire tools actions (expand/collapse all)
        const btns = pmTools ? pmTools.querySelectorAll('button') : null;
        if (btns && btns.length>=2){
          const [btnExpandAll, btnCollapseAll] = btns;
          btnExpandAll.onclick = ()=>{
            pmList.querySelectorAll('li[role="treeitem"]').forEach(li=>{
              if (li.querySelector('ul')){
                li.setAttribute('aria-expanded','true');
                const k = li.dataset.key; if (k) expandedSet.add(k);
              }
            });
            saveExpanded(expandedSet);
          };
          btnCollapseAll.onclick = ()=>{
            pmList.querySelectorAll('li[role="treeitem"]').forEach(li=>{
              if (li.querySelector('ul')) li.setAttribute('aria-expanded','false');
            });
            expandedSet.clear(); saveExpanded(expandedSet);
          };
        }
      }

      // Build on first open (when menu becomes active). Observe class changes.
      const obs = new MutationObserver(() => {
        if (menuHost.classList.contains('active')) {
          console.log('pro-modal-menu.js: 📥 Modal opened, preparing to render');
          
          // Simple approach: try to render directly
          let items = extractFromModernMenu();
          if (items && items.length) {
            console.log('pro-modal-menu.js: ✅ Using modern menu data directly');
            renderPanel();
            return;
          }
          
          // Fallback to legacy menu
          waitForLegacyMenu(
            () => {
              console.log('pro-modal-menu.js: ✅ Legacy menu ready, rendering');
              renderPanel();
            },
            async () => {
              console.log('pro-modal-menu.js: 🔄 Loading default menu...');
              const defaultItems = await loadDefaultMenu();
              if (defaultItems && defaultItems.length) {
                window.fallbackMenuData = defaultItems;
                renderPanel();
              }
            }
          );
        }
      });
      obs.observe(menuHost, { attributes: true, attributeFilter: ['class'] });

      // Also wire click for safety if user opens via code
      toggleBtn.addEventListener('click', function(){
        console.log('pro-modal-menu.js: 🟦 Toggle clicked');
        if (!pmList || !pmList.childElementCount) {
          // Simple approach: try to render directly
          let items = extractFromModernMenu();
          if (items && items.length) {
            console.log('pro-modal-menu.js: ✅ Click handler using modern menu data directly');
            renderPanel();
            return;
          }
          
          // Fallback to legacy menu
          waitForLegacyMenu(
            renderPanel,
            async () => {
              console.log('pro-modal-menu.js: 🔄 Click handler loading default menu...');
              const defaultItems = await loadDefaultMenu();
              if (defaultItems && defaultItems.length) {
                window.fallbackMenuData = defaultItems;
                renderPanel();
              }
            }
          );
        }
      });

      // Expose debug
      window.debugProModal = function(){
        const info = {
          host: !!menuHost,
          pmList: !!pmList,
          pmTools: !!pmTools,
          legacyMenuExists: !!document.getElementById('PageMenuBar'),
          legacyUlFound: !!(document.getElementById('PageMenuBar') && document.getElementById('PageMenuBar').querySelector('ul, .Menu, .Root, nav ul'))
        };
        console.log('pro-modal-menu.js: 🧪 debugProModal()', info);
        return info;
      };

      // Listen for menu data ready to avoid race conditions
      try{
        document.addEventListener('modernMenu:dataReady', function(){
          console.log('pro-modal-menu.js: 📣 modernMenu:dataReady received');
          // If menu is open or about to be opened, ensure rendering uses fresh data
          if (menuHost.classList.contains('active')) {
            renderPanel();
          }
        });
      } catch(e) {}
    } catch (e) { console.warn('pro-modal-menu init failed', e); }
  });
})();
