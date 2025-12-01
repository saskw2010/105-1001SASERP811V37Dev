<%@ Page Language="VB" MasterPageFile="~/Main.master" Title="DataView Adapter Demo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div class="container" style="padding:12px 0;">
    <h2 style="margin:0 0 12px;">DataView Runtime Adapter Demo</h2>

    <div class="card" style="margin-bottom:12px;">
      <div class="card-body" style="display:flex; flex-wrap:wrap; gap:.75rem; align-items:flex-end;">
        <div style="min-width:220px;">
          <label class="form-label">Controller</label>
          <input id="ctrlName" class="form-control" value="glmfbab" />
        </div>
        <div style="min-width:160px;">
          <label class="form-label">View</label>
          <input id="viewName" class="form-control" value="grid1" />
        </div>
        <div style="min-width:200px;">
          <label class="form-label">Quick Find</label>
          <input id="qfText" class="form-control" placeholder="optional" />
        </div>
        <div>
          <button id="btnLoad" type="button" class="btn btn-primary">Load</button>
          <button id="btnClearQf" type="button" class="btn btn-outline-secondary">Clear QF</button>
        </div>
        <div style="margin-left:auto; color:#666;">
          <small>Endpoint base: <code id="endpointBase">(resolving…)</code></small>
        </div>
      </div>
    </div>

    <div id="demoGrid" style="min-height:240px;"></div>

    <div class="card mt-3">
      <div class="card-header">Last Execute Result</div>
      <div class="card-body">
        <pre id="execOut" style="margin:0; max-height:220px; overflow:auto; background:#0b1520; color:#d3e1f0; padding:.75rem; border-radius:.25rem;">
<em>No actions executed yet.</em>
        </pre>
      </div>
    </div>
  </div>

  <script>
    (function(){
      function resolveBase(){
        try{
          var b = (window.AppConfig && window.AppConfig.asmxBase) || (document.body && document.body.getAttribute('data-asmx-base')) || localStorage.getItem('saserp.asmxBase') || '/Services/DataControllerService.asmx';
          return String(b).replace(/\/(GetPage|Execute|GetListOfValues)(?:\/?|$)/i,'');
        }catch(e){ return '/Services/DataControllerService.asmx'; }
      }
      function mount(){
        var root = document.getElementById('demoGrid');
        var controller = document.getElementById('ctrlName').value.trim() || 'glmfbab';
        var view = document.getElementById('viewName').value.trim() || 'grid1';
        var qf = document.getElementById('qfText').value.trim();
        var req = { controller: controller, view: view, pageIndex: 0, pageSize: 20, filter: [], quickFind: qf };
        var base = resolveBase();
        document.getElementById('endpointBase').textContent = base + '/GetPage';
        var execOut = document.getElementById('execOut');
        try {
          root.removeEventListener('dataview:execute', root.__dvExecListener__);
        } catch(e){}
        root.__dvExecListener__ = function(ev){
          try {
            var detail = ev && ev.detail ? ev.detail : null;
            if (!detail) return;
            var pretty = JSON.stringify(detail, null, 2);
            execOut.textContent = pretty;
          } catch(err){ execOut.textContent = String(err); }
        };
        root.addEventListener('dataview:execute', root.__dvExecListener__);
        DataViewRuntime.mountDataView(root, req, { asmxBase: base, requireMetaData: true, requireRowCount: true, onExecuteResult: function(r){
          try { execOut.textContent = JSON.stringify(r, null, 2); } catch(e){ execOut.textContent = String(r); }
        }});
      }
      document.getElementById('btnLoad').addEventListener('click', mount);
      document.getElementById('btnClearQf').addEventListener('click', function(){ document.getElementById('qfText').value=''; mount(); });
      document.addEventListener('DOMContentLoaded', mount);
    })();
  </script>
</asp:Content>

<asp:Content ID="Head1" ContentPlaceHolderID="PageHeaderContentPlaceHolder" runat="Server">
  <script src="/js/dataview-runtime-adapter.js"></script>
  <script src="/js/dataview-editor.js"></script>
  <link rel="stylesheet" href="/css/dataview-modern.css" />
  <style>
    .demo-host{ padding:1rem; }
  </style>
  </asp:Content>
<asp:Content ID="Footer1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  <div class="container" style="padding: 1rem 0;">
    <hr />
    <h3>Build Roadmap</h3>
    <div class="table-responsive">
      <table class="table table-bordered table-sm align-middle">
        <thead class="table-light">
          <tr>
            <th>Filename</th>
            <th>Function Call</th>
            <th>Input Required</th>
            <th>Job Description</th>
            <th>Details</th>
            <th>Output</th>
          </tr>
        </thead>
        <tbody>
          <tr>
            <td>/Services/DataControllerService.asmx</td>
            <td>GetPage (ASMX)</td>
            <td>controller=glmfbab, view=grid1, PageRequest { PageIndex, PageSize, SortExpression, Filter[], RequiresMetaData, RequiresRowCount }</td>
            <td>Legacy service: returns ViewPage payload</td>
            <td>Old version; used in this demo via JSON POST to /Services/DataControllerService.asmx/GetPage</td>
            <td>ViewPage JSON (Rows[], Fields[] possibly empty, TotalRowCount)</td>
          </tr>
          <tr>
            <td>/App_Code/Services/RepresentationalStateTransfer.vb</td>
            <td>ExecuteHttpGetRequest (REST GET)</td>
            <td>controller, view, page, size, sort, filter</td>
            <td>Legacy REST endpoint for data pages</td>
            <td>Old version; optional alternative path: /appservices/{controller}/{view}</td>
            <td>JSON/XML items with paging</td>
          </tr>
          <tr>
            <td>/js/dataview-runtime-adapter.js</td>
            <td>fetchViewPageAsmx(req, options)</td>
            <td>{ controller:'glmfbab', view:'grid1', pageSize, pageIndex }, { requireMetaData:true, requireRowCount:true }</td>
            <td>Fetch ViewPage via ASMX</td>
            <td>New adapter; posts JSON; unwraps { d } from ScriptService</td>
            <td>Raw ViewPage JSON</td>
          </tr>
          <tr>
            <td>/js/dataview-runtime-adapter.js</td>
            <td>buildModel(viewPage)</td>
            <td>ViewPage payload</td>
            <td>Normalize to runtime model</td>
            <td>Infers columns when Fields[] missing; fixes TotalRowCount -1</td>
            <td>{ columns[], rows[], total, pageSize, pageIndex, sort }</td>
          </tr>
          <tr>
            <td>/js/dataview-runtime-adapter.js</td>
            <td>renderDataView(root, model)</td>
            <td>root Element, RuntimeModel</td>
            <td>Render classic .DataView table</td>
            <td>Uses CSS: DataView, HeaderRow, Row, AlternatingRow, Cell, FooterRow, DataViewPager</td>
            <td>DOM table with header, rows, pager</td>
          </tr>
          <tr>
            <td>/js/dataview-runtime-adapter.js</td>
            <td>mountDataView(root, req, options)</td>
            <td>root Element, { controller, view, pageSize, pageIndex }, { transport:'asmx', requireMetaData, requireRowCount }</td>
            <td>Orchestrate fetch → build → render</td>
            <td>New adapter; replaces reliance on legacy combined client scripts</td>
            <td>Interactive grid with sorting/paging</td>
          </tr>
          <tr>
            <td>/VueCss/dataview-modern-reset.css; /VueCss/Integration.css</td>
            <td>N/A</td>
            <td>N/A</td>
            <td>Styling for classic DataView</td>
            <td>Old CSS retained; no change required</td>
            <td>Visual appearance</td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</asp:Content>
