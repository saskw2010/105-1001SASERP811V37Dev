(function(){
  console.log('pro-sidebar.js: 🟢 Script file loaded');
  // Safe, isolated initializer for brand + sidebar
  function ready(fn){ if(document.readyState!=='loading'){ fn(); } else { document.addEventListener('DOMContentLoaded', fn); } }
  ready(function(){
    console.log('pro-sidebar.js: 🚀 DOMContentLoaded');
    try {
      const topBar = document.querySelector('.membership-top-bar .membership-content');
      if (topBar && !topBar.querySelector('.system-brand')) {
        const brand = document.createElement('div');
        brand.className = 'system-brand';
        // Burger that triggers existing modal menu toggle button
        const brandBtn = document.createElement('button');
        brandBtn.type = 'button';
        brandBtn.className = 'membership-btn';
        brandBtn.title = 'القائمة';
        brandBtn.addEventListener('click', function(){
          const b = document.getElementById('menuToggleBtn'); if (b) b.click();
        });
        brandBtn.innerHTML = '<i class="fas fa-bars"></i>';
        const icon = document.createElement('div'); icon.className = 'brand-icon'; icon.innerHTML = '<i class="fas fa-cube"></i>';
        const text = document.createElement('div'); text.className = 'brand-text'; text.textContent = 'SKYsaas ERP - نظام إدارة الموارد المؤسسية';
        brand.appendChild(brandBtn); brand.appendChild(icon); brand.appendChild(text);
        // Insert brand as first child
        topBar.insertBefore(brand, topBar.firstChild);
      }

      // Ensure a sidebar toggle button exists next to #menuToggleBtn without editing markup
      const actions = document.querySelector('.membership-top-bar .membership-actions');
      if (actions && !document.getElementById('proSidebarToggleBtn')) {
        const sbBtn = document.createElement('button');
        sbBtn.type = 'button';
        sbBtn.id = 'proSidebarToggleBtn';
        sbBtn.className = 'membership-btn';
        sbBtn.title = 'إظهار/إخفاء الشريط الجانبي';
        sbBtn.innerHTML = '<i class="fas fa-border-all"></i>';
        actions.insertBefore(sbBtn, actions.firstChild);
      }

      // Create sidebar host once
      if (!document.getElementById('ProSidebarHost')) {
        const nav = document.createElement('nav');
        nav.id = 'ProSidebarHost';
        nav.setAttribute('aria-label','التنقل');
        nav.innerHTML = [
          '<div class="psb-header">',
          '  <div class="psb-title">Navigation</div>',
          '  <div class="psb-tools">',
          '    <button type="button" class="psb-btn" id="psbCollapseBtn" title="Collapse/Expand"><i class="fas fa-angle-double-left"></i></button>',
          '  </div>',
          '</div>',
          '<div class="psb-search"><input type="text" id="psbSearchInput" placeholder="بحث في القوائم..." aria-label="بحث"></div>',
          '<div class="psb-scroll"><ul class="psb-list" id="psb-list" role="tree"></ul></div>',
          '<div class="psb-static" id="psb-static"><div class="psb-static-title">Quick Access</div><ul class="psb-quick" id="psb-quick"></ul></div>'
        ].join('');
        document.body.appendChild(nav);
      }

      // Wire behavior safely
      (function initSidebar(){
        console.log('pro-sidebar.js: 🔧 initSidebar() starting');
        const proSidebar = document.getElementById('ProSidebarHost');
        const proSidebarToggleBtn = document.getElementById('proSidebarToggleBtn');
        if (!proSidebar || !proSidebarToggleBtn) { console.warn('pro-sidebar.js: ⚠️ Missing elements', {proSidebar: !!proSidebar, proSidebarToggleBtn: !!proSidebarToggleBtn}); return; }
        const psbList = document.getElementById('psb-list');
        const psbCollapseBtn = document.getElementById('psbCollapseBtn');
        const psbSearchInput = document.getElementById('psbSearchInput');
        const STORAGE_EXPANDED = 'psbExpandedNodes';
        const STORAGE_COLLAPSED = 'psbCollapsed';
        const loadSet = (k)=>{ try{ const r=localStorage.getItem(k); return r? new Set(JSON.parse(r)) : new Set(); }catch{ return new Set(); } };
        const saveSet = (k,s)=>{ try{ localStorage.setItem(k, JSON.stringify(Array.from(s))); }catch{} };
        const expandedSet = loadSet(STORAGE_EXPANDED);

        function extractFromLegacyDom() {
          const host = document.getElementById('PageMenuBar');
          if (!host) return [];
          const rootUl = host.querySelector('ul, .Menu, .Root, nav ul');
          if (!rootUl) return [];
          const walk = (ul, level)=>{
            const arr=[];
            ul.querySelectorAll(':scope > li').forEach(li=>{
              const a = li.querySelector(':scope > a, :scope > span a, :scope > .link');
              const text = a ? (a.textContent||'').trim() : (li.getAttribute('title')||'').trim();
              const href = a && a.getAttribute('href') ? a.getAttribute('href') : '#';
              const childUl = li.querySelector(':scope > ul');
              arr.push({ text, url: href, level, children: childUl ? walk(childUl, level+1) : [] });
            });
          };
          return walk(rootUl, 1);
        }

        function extractFromModernMenu() {
          // First try: global variable
          if (window.modernMenuData && Array.isArray(window.modernMenuData)) {
            console.log('pro-sidebar.js: 📦 Using modern menu stored data');
            console.log('pro-sidebar.js: 🔒 Menu data includes security from original system');
            console.log('pro-sidebar.js: 📊 Found', window.modernMenuData.length, 'root items');
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
                console.log('pro-sidebar.js: 📦 Using cached menu data from localStorage');
                console.log('pro-sidebar.js: 🔒 Cached menu includes security from original system');
                console.log('pro-sidebar.js: 📊 Found', menuCache.legacyData.length, 'root items');
                return menuCache.legacyData;
              }
            }
          } catch (e) {
            console.warn('pro-sidebar.js: ⚠️ Failed to load from cache:', e);
          }
          
          console.warn('pro-sidebar.js: ⚠️ window.modernMenuData not available');
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

        function findContextRoot(items){
          try {
            const current = location.pathname.toLowerCase();
            let bestNode=null; let bestLen=-1;
            function scan(list){
              list.forEach(n=>{
                const urlPath = (n.url||'').split('#')[0].split('?')[0].toLowerCase();
                if (urlPath && (current.endsWith(urlPath) || current.indexOf(urlPath)>=0)){
                  if (urlPath.length>bestLen){ bestNode=n; bestLen=urlPath.length; }
                }
                if (n.children && n.children.length) scan(n.children);
              });
            }
            scan(items);
            return bestNode;
          } catch { return null; }
        }

        function nodeKey(n, parent){ const base=(n.url||n.text||'node'); return parent? parent+'>'+base : base; }

        function createRow(node, parentKey){
          const key = nodeKey(node, parentKey);
          const li = document.createElement('li');
          li.dataset.key = key;
          li.setAttribute('role','treeitem');
          li.setAttribute('data-level', String(node.level||1));
          const hasChildren = Array.isArray(node.children) && node.children.length>0;

          const rowLink = document.createElement('a');
          rowLink.href = node.url || '#';
          rowLink.className = 'psb-row';
          const icon = document.createElement('span'); icon.className = 'psb-icon';
          const lvl = Number(node.level||1);
          const iconClass = lvl===1? 'fa-sitemap' : lvl===2? 'fa-layer-group' : lvl===3? 'fa-folder' : 'fa-file';
          icon.innerHTML = '<i class="fas '+iconClass+'"></i>';
          const text = document.createElement('span'); text.className = 'psb-text'; text.textContent = node.text || 'Link';

          let toggle;
          if (hasChildren) {
            toggle = document.createElement('button'); toggle.type='button'; toggle.className='psb-toggle'; toggle.innerHTML = '<span class="caret">▸</span>';
            toggle.addEventListener('click', (e)=>{
              e.preventDefault(); e.stopPropagation();
              const expanded = li.getAttribute('aria-expanded') === 'true';
              const next = expanded ? 'false' : 'true';
              li.setAttribute('aria-expanded', next);
              if (next==='true') expandedSet.add(key); else expandedSet.delete(key);
              saveSet(STORAGE_EXPANDED, expandedSet);
            });
          } else {
            const spacer = document.createElement('span'); spacer.style.width='24px'; spacer.style.display='inline-block'; spacer.setAttribute('aria-hidden','true'); toggle = spacer;
          }

          li.setAttribute('aria-expanded', expandedSet.has(key) ? 'true' : 'false');
          const rowWrap = document.createElement('div'); rowWrap.className = 'psb-row-wrap';
          rowWrap.appendChild(toggle); rowLink.appendChild(icon); rowLink.appendChild(text); rowWrap.appendChild(rowLink); li.appendChild(rowWrap);

          if (hasChildren) { const ul = document.createElement('ul'); node.children.forEach(ch => ul.appendChild(createRow(ch, key))); li.appendChild(ul); }
          return li;
        }

        async function loadDefaultMenu() {
          try {
            console.log('pro-sidebar.js: 📥 Loading default menu from JSON...');
            const response = await fetch('/js/default-menu.json');
            if (!response.ok) throw new Error('Failed to load default menu');
            const data = await response.json();
            const addLevel = (items, level=1) => items.map(n => ({...n, level, children: n.children ? addLevel(n.children, level+1) : []}));
            console.log('pro-sidebar.js: ✅ Default menu loaded successfully');
            return addLevel(data);
          } catch (err) {
            console.error('pro-sidebar.js: ❌ Failed to load default menu', err);
            return [];
          }
        }


        async function buildSidebar(){
          let items = extractFromLegacyDom();
          if (!Array.isArray(items) || !items.length) {
            console.log('pro-sidebar.js: ⚠️ No legacy DOM, trying modern menu');
            items = extractFromModernMenu();
          }
          if (!Array.isArray(items) || !items.length) {
            console.log('pro-sidebar.js: 🔄 Trying default menu...');
            items = await loadDefaultMenu();
          }
          buildSidebarWithData(items);
        }

        function buildSidebarWithData(items) {
          if (!psbList || !Array.isArray(items) || !items.length) {
            console.warn('pro-sidebar.js: ❌ No menu data available');
            return;
          }
          // Determine contextual subtree: show children of the best matched node; fallback to full
          const ctx = findContextRoot(items);
          const toRender = (ctx && Array.isArray(ctx.children) && ctx.children.length) ? ctx.children : items;
          psbList.innerHTML=''; toRender.forEach(n=> psbList.appendChild(createRow(n, '')));
          // highlight current
          try { const current = location.pathname.toLowerCase(); const links = psbList.querySelectorAll('a.psb-row[href]'); let best=null; let bestLen=-1; links.forEach(a=>{ const href=a.getAttribute('href'); if(!href || href==='#') return; const urlPath = href.split('#')[0].split('?')[0].toLowerCase(); if (current.endsWith(urlPath) || current.indexOf(urlPath)>=0) { if (urlPath.length>bestLen){ best=a; bestLen=urlPath.length; } } }); if (best) { best.classList.add('active'); } } catch {}

          // Build static quick section
          const quick = document.getElementById('psb-quick');
          if (quick && !quick.dataset.ready){
            quick.innerHTML = '';
            const shortcuts = [
              { text:'لوحة المعلومات', icon:'fa-chart-line', url:'#' },
              { text:'المبيعات', icon:'fa-receipt', url:'#' },
              { text:'المشتريات', icon:'fa-shopping-cart', url:'#' },
              { text:'المخزون', icon:'fa-warehouse', url:'#' }
            ];
            shortcuts.forEach(s=>{
              const li=document.createElement('li');
              const a=document.createElement('a'); a.href=s.url; a.className='psb-quick-link';
              a.innerHTML = '<span class="qi"><i class="fas '+s.icon+'"></i></span><span class="qt">'+s.text+'</span>';
              li.appendChild(a); quick.appendChild(li);
            });
            quick.dataset.ready='1';
          }
        }

        proSidebarToggleBtn.addEventListener('click', ()=>{ console.log('pro-sidebar.js: 🟦 toggle clicked'); document.body.classList.toggle('sidebar-open'); if (!psbList || !psbList.childElementCount) buildSidebar(); });
        if (psbCollapseBtn) psbCollapseBtn.addEventListener('click', ()=>{ const c = document.body.classList.toggle('sidebar-collapsed'); try { localStorage.setItem(STORAGE_COLLAPSED, c? '1':'0'); } catch{} });
        try { if (localStorage.getItem(STORAGE_COLLAPSED)==='1') document.body.classList.add('sidebar-collapsed'); } catch{}
        if (psbSearchInput) { psbSearchInput.addEventListener('input', (e)=>{ const term=(e.target.value||'').trim().toLowerCase(); psbList.querySelectorAll('li[role="treeitem"]').forEach(li=>{ const label=(li.querySelector('.psb-text')?.textContent||'').toLowerCase(); const match=!term || label.indexOf(term)>=0; li.style.display = match? '' : 'none'; }); }); }
        console.log('pro-sidebar.js: ✅ initSidebar() done');
      })();
      // Expose debug helper
      window.debugProSidebar = function(){
        const info = {
          host: !!document.getElementById('ProSidebarHost'),
          toggleBtn: !!document.getElementById('proSidebarToggleBtn'),
          list: !!document.getElementById('psb-list'),
          items: (document.getElementById('psb-list')||{}).childElementCount || 0
        };
        console.log('pro-sidebar.js: 🧪 debugProSidebar()', info);
        return info;
      };
    } catch (e) { console.warn('pro-sidebar init failed', e); }
  });
})();
