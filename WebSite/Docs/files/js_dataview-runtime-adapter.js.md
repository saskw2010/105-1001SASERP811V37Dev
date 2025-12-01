# File: js/dataview-runtime-adapter.js

Minimal client adapter to consume server ViewPage JSON (ASMX or REST) and render a classic DataView table compatible with existing CSS.

### Function: fetchViewPageAsmx
- Signature: function fetchViewPageAsmx(req, options)
- Purpose: POSTs to /Services/DataControllerService.asmx/GetPage and returns the ASMX ScriptService JSON payload (unwraps { d }).
- Params: req {controller, view, pageIndex, pageSize, sortExpression, filter[]}, options {asmxUrl?}.
- Returns: Promise<ViewPageDto>

### Function: fetchViewPageRest
- Signature: function fetchViewPageRest(req, options)
- Purpose: GETs REST endpoint (default base /appservices) and returns JSON.
- Params: req as above, options {restBaseUrl?}.
- Returns: Promise<ViewPageDto>

### Function: buildModel
- Signature: function buildModel(vp)
- Purpose: Normalize ViewPageDto to a simple runtime model: columns[], rows[], total, pageSize, pageIndex, sort.
- Returns: RuntimeModel

### Function: renderDataView
- Signature: function renderDataView(root, model, onCommand)
- Purpose: Render a table with CSS classes: DataView, HeaderRow, Row/AlternatingRow, Cell, FooterRow, DataViewPager. Emits onCommand for sort/page.

### Function: mountDataView
- Signature: function mountDataView(root, req, options)
- Purpose: Orchestrate fetch -> buildModel -> renderDataView. Wires sorting/paging and recalls itself on command.
- Returns: Promise<RuntimeModel>
