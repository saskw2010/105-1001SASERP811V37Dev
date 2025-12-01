(function(){
  'use strict';

  if (window.__modernRootSidebarLoaded) return; 
  window.__modernRootSidebarLoaded = true;

  var CFG = {
    hostId: 'rootSidebarHost',
    panelId: 'rootSidebarPanel',
    listId: 'rootSidebarList',
    toggleId: 'rootSidebarToggleBtn',
    maxDepth: 3,
    z: 1000000
  };

  function injectStyles(){
    if (document.getElementById('rootSidebarStyles')) return;
    var css = ''+
    '#'+CFG.toggleId+'{position:fixed;top:20px;left:20px;z-index:'+(CFG.z+2)+';background:linear-gradient(135deg,#1e293b,#334155);color:#fff;border:none;padding:14px 22px;border-radius:12px;cursor:pointer;font-size:16px;font-weight:700;box-shadow:0 6px 20px rgba(30,41,59,.5);transition:all .2s ease;display:flex;align-items:center;gap:10px}'+
    '#'+CFG.toggleId+':hover{transform:translateY(-2px);box-shadow:0 10px 24px rgba(30,41,59,.6)}'+
    '#'+CFG.hostId+'{position:fixed;inset:0;z-index:'+CFG.z+';display:none}'+
    '#'+CFG.hostId+'.open{display:block}'+
    '#'+CFG.hostId+' .rb{position:absolute;inset:0;background:rgba(15,23,42,.45);backdrop-filter:blur(2px)}'+
    '#'+CFG.panelId+'{position:absolute;top:0;bottom:0;left:0;width:340px;max-width:86vw;background:linear-gradient(180deg,#0b1020,#121a2e);color:#f8fafc;box-shadow:0 10px 30px rgba(2,6,23,.55);transform:translateX(-100%);transition:transform .28s ease;overflow:auto;direction:rtl}'+
    '#'+CFG.hostId+'.open #'+CFG.panelId+'{transform:translateX(0)}'+
    '#'+CFG.panelId+' .hd{display:flex;align-items:center;justify-content:space-between;padding:18px 16px;border-bottom:1px solid rgba(148,163,184,.15);background:linear-gradient(180deg,rgba(255,255,255,.04),rgba(255,255,255,0))}'+
    '#'+CFG.panelId+' .hd .ttl{font-weight:800;font-size:17px;letter-spacing:.3px}'+
    '#'+CFG.panelId+' .hd .x{background:#1f2937;border:1px solid rgba(148,163,184,.25);color:#e5e7eb;border-radius:10px;padding:8px 12px;cursor:pointer}'+
    '#'+CFG.listId+'{list-style:none;margin:12px 0;padding:6px 10px 28px 10px}'+
    '#'+CFG.listId+' li{margin:2px 0}'+
    '#'+CFG.listId+' .item{display:flex;align-items:center;justify-content:space-between;padding:10px 12px;border-radius:10px;cursor:pointer;user-select:none;transition:background .15s ease}'+
    '#'+CFG.listId+' .item:hover{background:rgba(148,163,184,.12)}'+
    '#'+CFG.listId+' .txt{display:flex;align-items:center;gap:10px;overflow:hidden;text-overflow:ellipsis;white-space:nowrap}'+
    '#'+CFG.listId+' a{color:inherit;text-decoration:none;flex:1;overflow:hidden;text-overflow:ellipsis}'+
    '#'+CFG.listId+' .tog{margin-inline-start:8px;background:transparent;border:1px solid rgba(148,163,184,.25);color:#cbd5e1;border-radius:8px;padding:4px 8px;cursor:pointer}'+
    '#'+CFG.listId+' ul{list-style:none;margin:4px 0 6px 0;padding:0 10px 0 0;border-right:1px dashed rgba(148,163,184,.2)}'+
    '#'+CFG.listId+' li.open > ul{display:block}'+
    '#'+CFG.listId+' li > ul{display:none}'+
    '@media (max-width:600px){#'+CFG.toggleId+'{padding:12px 16px;left:12px;top:12px}#'+CFG.panelId+'{width:86vw}}';
    var s=document.createElement('style');s.id='rootSidebarStyles';s.textContent=css;document.head.appendChild(s);
  }

  function ensureButton(){
    var btn = document.getElementById(CFG.toggleId);
    if (!btn){
      btn = document.createElement('button');
      btn.id = CFG.toggleId;
      btn.setAttribute('type','button');
      btn.innerHTML = '<span style="font-size:18px">☰</span><span>القائمة</span>';
      document.body.appendChild(btn);
    }
    if (!btn.dataset.bound){
      btn.addEventListener('click', toggle);
      btn.dataset.bound = '1';
    }
    return btn;
  }

  function ensureHost(){
    var host = document.getElementById(CFG.hostId);
    if (!host){
      host = document.createElement('div');
      host.id = CFG.hostId;
      var rb = document.createElement('div'); rb.className = 'rb'; rb.setAttribute('data-close','1');
      var pn = document.createElement('div'); pn.id = CFG.panelId;
      var hd = document.createElement('div'); hd.className='hd';
      var ttl = document.createElement('div'); ttl.className='ttl'; ttl.textContent='القائمة الرئيسية';
      var x = document.createElement('button'); x.className='x'; x.type='button'; x.textContent='إغلاق'; x.addEventListener('click', close);
      hd.appendChild(ttl); hd.appendChild(x);
      var ul = document.createElement('ul'); ul.id = CFG.listId;
      pn.appendChild(hd); pn.appendChild(ul);
      host.appendChild(rb); host.appendChild(pn);
      document.body.appendChild(host);
    }
    if (!host.dataset.bound){
      host.addEventListener('click', function(e){ if (e.target && e.target.getAttribute('data-close')==='1') close(); });
      host.dataset.bound='1';
    }
    return host;
  }

  function open(){ var h=document.getElementById(CFG.hostId); if (h) h.classList.add('open'); }
  function close(){ var h=document.getElementById(CFG.hostId); if (h) h.classList.remove('open'); }
  function toggle(){ var h=document.getElementById(CFG.hostId); if (!h) return; h.classList.toggle('open'); }

  function normalizeTitle(t){ if(!t) return ''; var s=String(t).trim(); if(s.indexOf('^')>=0){ var parts=[],m,re=/\^([^\^]+)\^/g; while((m=re.exec(s))!==null){ var tok=(m[1]||'').trim(); if(tok) parts.push(tok);} var best=parts.find(function(p){return /[^\x00-\x7F]/.test(p)})||parts.find(function(p){return /\s/.test(p)}); if(!best && parts.length) best=parts[Math.floor(parts.length/2)]; return best||s.replace(/\^/g,''); } return s; }

  function convertToSimpleTree(items){
    if (!Array.isArray(items)) return [];
    function mapNode(n){
      var o={ text: normalizeTitle(n.Title||n.text||''), url: n.Url||n.url||'#', children: [] };
      if (Array.isArray(n.Children)) o.children = n.Children.map(mapNode);
      else if (Array.isArray(n.children)) o.children = n.children.map(mapNode);
      return o;
    }
    return items.map(mapNode);
  }

  function getMenuData(){
    if (Array.isArray(window.modernMenuData) && window.modernMenuData.length){
      return Promise.resolve(window.modernMenuData);
    }
    return fetch('/Pages/MenuApi.aspx/GetMenuTree', {
      method:'POST', headers:{'Content-Type':'application/json; charset=utf-8'}, body:'{}'
    }).then(function(res){return res.json();}).then(function(json){ var d=json.d||json||{}; return convertToSimpleTree(d.items||[]); }).catch(function(){ return []; });
  }

  function render(tree){
    var host = ensureHost();
    var ul = document.getElementById(CFG.listId); if (!ul) return;
    ul.innerHTML='';
    (tree||[]).forEach(function(n){ ul.appendChild(renderNode(n,1)); });
  }

  function renderNode(node, depth){
    var li=document.createElement('li');
    var row=document.createElement('div'); row.className='item';
    var txt=document.createElement('div'); txt.className='txt';
    var a=document.createElement('a'); a.href=node.url||'#'; a.textContent=node.text||''; a.title=node.text||'';
    txt.appendChild(a); row.appendChild(txt);
    var hasKids=Array.isArray(node.children)&&node.children.length>0 && depth<CFG.maxDepth;
    if(hasKids){
      var tog=document.createElement('button'); tog.className='tog'; tog.type='button'; tog.textContent='▼';
      tog.addEventListener('click', function(e){ e.preventDefault(); e.stopPropagation(); li.classList.toggle('open'); });
      row.appendChild(tog);
    }
    row.addEventListener('click', function(e){ if (e.target && e.target.tagName==='BUTTON') return; if (a && a.href) { window.location.href=a.href; }});
    li.appendChild(row);
    if(hasKids){
      var ul=document.createElement('ul');
      node.children.forEach(function(c){ ul.appendChild(renderNode(c, depth+1)); });
      li.appendChild(ul);
    }
    return li;
  }

  function init(){
    injectStyles();
    ensureButton();
    ensureHost();
    getMenuData().then(function(tree){ render(tree); });
    
    function handleGlobalKeydown(e){
      // Do not interfere with typing unless Ctrl is held
      var tag = (e.target && e.target.tagName) ? e.target.tagName.toLowerCase() : '';
      var isTyping = tag === 'input' || tag === 'textarea' || (e.target && e.target.isContentEditable);
      if (!e.ctrlKey && isTyping) return;
      
      if (e.key === 'Escape') {
        close();
        return;
      }
      var isCtrlB = e.ctrlKey && (e.key === 'b' || e.key === 'B' || e.code === 'KeyB');
      if (isCtrlB){
        try { e.preventDefault(); } catch(_){}
        try { e.stopPropagation(); } catch(_){}
        // Helpful debug log
        if (window && typeof console !== 'undefined') console.log('RootSidebar: Ctrl+B detected -> toggle');
        toggle();
      }
    }
    // Add multiple listeners to survive stopPropagation in other scripts
    document.addEventListener('keydown', handleGlobalKeydown, true);   // capture
    window.addEventListener('keydown', handleGlobalKeydown, true);     // capture on window
    document.body && document.body.addEventListener('keydown', handleGlobalKeydown, true);
    
    window.RootSidebar = { open: open, close: close, toggle: toggle };
  }

  if (document.readyState === 'loading') document.addEventListener('DOMContentLoaded', init); else init();
})();
