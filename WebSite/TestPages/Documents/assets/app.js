(function(){
  const TOC_URL = 'assets/toc.json';
  const SEARCH_URL = 'assets/search.json';
  const DOCS_BASE = 'docs-html/';

  const tocEl = /** @type {HTMLElement|null} */ (document.getElementById('toc'));
  const docEl = /** @type {HTMLElement|null} */ (document.getElementById('doc'));
  const rawLink = /** @type {HTMLAnchorElement|null} */ (document.getElementById('openRaw'));
  const themeToggle = /** @type {HTMLButtonElement|null} */ (document.getElementById('themeToggle'));
  const searchEl = /** @type {HTMLInputElement|null} */ (document.getElementById('search'));

  let TOC = null, INDEX = [];

  function setTheme(mode){ document.documentElement.setAttribute('data-theme', mode); }
  if (themeToggle) themeToggle.addEventListener('click',()=>{
    const cur = document.documentElement.getAttribute('data-theme')||'light';
    setTheme(cur==='light'?'dark':'light');
  });

  function parseHash(){
    const raw = (location.hash||'#/index');
    const nohash = raw.replace(/^#\//,'')
    const [path, query] = nohash.split('?');
    const params = new URLSearchParams(query||'');
    return { path: path.replace(/\.md$/i,''), params };
  }

  function navTo(hash){ if(location.hash!==hash) location.hash=hash; else onRoute(); }
  window.addEventListener('hashchange', onRoute);

  function buildToc(){
    if (!tocEl) return;
    tocEl.innerHTML = '';
    (TOC && TOC.groups ? TOC.groups : []).forEach(function(g){
      const title = document.createElement('div'); title.className='group-title'; title.textContent=g.title; tocEl.appendChild(title);
      (g.items||[]).forEach(function(it){
        const a=document.createElement('a'); a.href = '#/'+String(it.path).replace(/\\/g,'/'); a.textContent=it.title; a.dataset.path = it.path; tocEl.appendChild(a);
      });
    });
    tocEl.addEventListener('click', function(e){
      const t = /** @type {HTMLElement} */ (e.target); const a=t && t.closest ? t.closest('a') : null; if(!a) return; e.preventDefault(); navTo(a.getAttribute('href'));
    });
  }

  function markActive(path){
    if (!tocEl) return;
    [].forEach.call(tocEl.querySelectorAll('a'), function(a){ a.classList.toggle('active', a.dataset.path===path); });
  }

  function escapeHtml(s){
    return s.replace(/&/g,'&amp;').replace(/</g,'&lt;').replace(/>/g,'&gt;');
  }

  function mdInline(txt){
    // inline code
    txt = txt.replace(/`([^`]+)`/g, function(_,code){ return '<code>'+escapeHtml(code)+'</code>'; });
    // links [text](url)
    txt = txt.replace(/\[([^\]]+)\]\(([^)]+)\)/g, '<a href="$2" target="_blank" rel="noopener">$1</a>');
    return txt;
  }

  function mdToHtml(md){
    const lines = md.replace(/\r\n/g,'\n').split('\n');
    let out = [];
    let inCode = false; let codeLang = '';
    let inUl = false, inOl = false, para = '';
    function flushPara(){ if(para){ out.push('<p>'+mdInline(escapeHtml(para.trim()))+'</p>'); para=''; } }
    function closeLists(){ if(inUl){ out.push('</ul>'); inUl=false; } if(inOl){ out.push('</ol>'); inOl=false; } }
    for(let i=0;i<lines.length;i++){
      const raw = lines[i];
      const line = raw.replace(/\t/g,'    ');
      const fence = line.match(/^```(.*)/);
      if(fence){
        if(!inCode){ flushPara(); closeLists(); inCode=true; codeLang=(fence[1]||'').trim(); out.push('<pre><code'+(codeLang?(' class="lang-'+escapeHtml(codeLang)+'"'):'')+'>'); }
        else { inCode=false; out.push('</code></pre>'); }
        continue;
      }
      if(inCode){ out.push(escapeHtml(raw)); continue; }
      if(/^\s*$/.test(line)){ flushPara(); closeLists(); continue; }
      let m;
      if(m=line.match(/^######\s+(.*)/)){ flushPara(); closeLists(); out.push('<h6>'+mdInline(escapeHtml(m[1].trim()))+'</h6>'); continue; }
      if(m=line.match(/^#####\s+(.*)/)){ flushPara(); closeLists(); out.push('<h5>'+mdInline(escapeHtml(m[1].trim()))+'</h5>'); continue; }
      if(m=line.match(/^####\s+(.*)/)){ flushPara(); closeLists(); out.push('<h4>'+mdInline(escapeHtml(m[1].trim()))+'</h4>'); continue; }
      if(m=line.match(/^###\s+(.*)/)){ flushPara(); closeLists(); out.push('<h3>'+mdInline(escapeHtml(m[1].trim()))+'</h3>'); continue; }
      if(m=line.match(/^##\s+(.*)/)){ flushPara(); closeLists(); out.push('<h2>'+mdInline(escapeHtml(m[1].trim()))+'</h2>'); continue; }
      if(m=line.match(/^#\s+(.*)/)){ flushPara(); closeLists(); out.push('<h1>'+mdInline(escapeHtml(m[1].trim()))+'</h1>'); continue; }
      if(m=line.match(/^\s*[-*]\s+(.*)/)){
        flushPara(); if(inOl){ out.push('</ol>'); inOl=false; } if(!inUl){ out.push('<ul>'); inUl=true; }
        out.push('<li>'+mdInline(escapeHtml(m[1].trim()))+'</li>'); continue;
      }
      if(m=line.match(/^\s*\d+\.\s+(.*)/)){
        flushPara(); if(inUl){ out.push('</ul>'); inUl=false; } if(!inOl){ out.push('<ol>'); inOl=true; }
        out.push('<li>'+mdInline(escapeHtml(m[1].trim()))+'</li>'); continue;
      }
      // default paragraph accumulation
      para += (para? ' ' : '') + raw;
    }
    // close states
    if(inCode){ out.push('</code></pre>'); inCode=false; }
    flushPara(); closeLists();
    return out.join('\n');
  }

  async function fetchDocHtml(path){
    const htmlPath = DOCS_BASE + path + '.html';
    try{
      const resp = await fetch(htmlPath, {cache:'no-store'});
      if(!resp.ok) throw new Error('not found');
      return await resp.text();
    }catch{ return null; }
  }

  async function fetchDocMarkdown(path){
    const mdPath = DOCS_BASE + path + '.md.txt';
    try{
      const resp = await fetch(mdPath, {cache:'no-store'});
      if(!resp.ok) throw new Error('not found');
      const md = await resp.text();
      return mdToHtml(md);
    }catch{ return null; }
  }

  async function onRoute(){
    const { path, params } = parseHash();
    markActive(path+'.md');
    if (rawLink) rawLink.href = DOCS_BASE + path + '.md.txt';
    let html = await fetchDocHtml(path);
    if(html==null){ html = await fetchDocMarkdown(path); }
    if(html==null){ html = '<h1>Not found</h1><p>Neither HTML mirror nor Markdown source could be loaded for '+path+'.</p>'; }
    renderDoc(path, html);
    const anchor = params.get('anchor');
    if(anchor && docEl){
      // wait a tick for DOM
      setTimeout(()=>{
        const target = docEl.querySelector('#'+CSS.escape(anchor));
        if(target && target.scrollIntoView){ target.scrollIntoView({behavior:'instant', block:'start'}); }
      }, 0);
    }
  }

  function renderDoc(path, html){
    const tplEl = document.getElementById('docTemplate');
    const tpl = tplEl ? tplEl.innerHTML : '{{HTML}}';
    const out = tpl.replace('{{HTML}}', html);
    if (docEl) {
      docEl.innerHTML = out;
      const crumbs = docEl.querySelector('.crumbs'); if(crumbs) crumbs.textContent = path.split('/').join(' › ');
      const source = /** @type {HTMLAnchorElement|null} */ (docEl.querySelector('.source')); if(source) source.href=DOCS_BASE+path+'.md.txt';
    }
  }

  function indexSearch(){
    if (!tocEl) return;
    const q = ((searchEl && searchEl.value) ? searchEl.value : '').toLowerCase().trim();
    [].forEach.call(tocEl.querySelectorAll('a'), function(a){
      const item = INDEX.find(function(x){return x.path===a.dataset.path;});
      const hay = (a.textContent + ' ' + (item?item.text:'' )).toLowerCase();
      a.style.display = hay.indexOf(q) !== -1 ? '' : 'none';
    });
  }
  if (searchEl) searchEl.addEventListener('input', indexSearch);

  async function load(){
    try{ TOC = await (await fetch(TOC_URL, {cache:'no-store'})).json(); buildToc(); }catch{}
    try{ INDEX = await (await fetch(SEARCH_URL, {cache:'no-store'})).json(); }catch{}
    if(!location.hash){ navTo('#/index'); } else { onRoute(); }
  }

  load();
})();
