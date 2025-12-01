# Deep-dive: Steps H → L (WebForms Generic Flow)

Scope: Analyze H–L from TestPages/Documents/SystemFlows/flow-webforms-generic.html and produce AS-IS/TO-BE with links.

- H = Call ASMX / WebMethod / Handler
- I = Database
- J = JSON/XML Response
- K = Bind to controls & JS render
- L = Render HTML

---

## H. Call ASMX / WebMethod / Handler

### AS-IS (WebForms)
- Key files:
  - Services/DataControllerService.asmx → App_Code/Services/DataControllerService.vb
    - WebMethods: GetPage, GetListOfValues, Execute, GetCompletionList, Login, Logout, Roles
  - App_Code/Services/RepresentationalStateTransfer.vb (REST handler)
- Callers:
  - Client JS fetches ASMX or REST: Services/DataControllerService.asmx/GetPage (POST), or REST routes handled by RepresentationalStateTransfer.PerformRequest
  - Server code also calls ControllerFactory.CreateDataController() directly (ControllerDataSource etc.)
- Callees:
  - ControllerFactory.CreateDataController().GetPage / Execute / GetListOfValues
  - AutoCompleteManager.GetCompletionList
- HTTP
  - ASMX: SOAP/JSON via ScriptService; POST; content-type text/plain or application/json; JSONP supported in REST handler
  - REST: GET/POST/PUT/DELETE; JSON or XML; JSONP via callback and _instance
- Serialization
  - System.Web.Script.Serialization.JavaScriptSerializer (built-in), JSON dates via /Date(ticks)/ in some paths; REST converts to strings with ConvertDateToJSON
- Error handling
  - REST: errors → XML <error> or JSON structure; 400/404 codes
- Links
  - ../files/App_Code_Services_DataControllerService.vb.html#function-GetPage
  - ../files/App_Code_Services_DataControllerService.vb.html#function-Execute

### PAIN POINTS
- Legacy ASMX/ScriptService and custom REST handler; mixed protocols; JSONP
- Tight coupling to ControllerFactory/IDataController
- Weak typing of payloads; limited validation
- Session coupling (EnableSession:=true)
- Harder to version/secure contracts; manual date handling

### TO-BE (Modern Stack)
- Backend: ASP.NET Core 8 Web API; Controllers per bounded context
- Endpoints (OpenAPI):
  - GET /api/{controller}?pageIndex=&pageSize=&sort=&filters=
  - POST /api/{controller}/actions/{action}
- DTOs: typed PageRequestDto, ViewPageDto, ActionArgsDto, ActionResultDto
- Validation: FluentValidation
- Auth: JWT or Cookies; role claims
- Caching: Response caching, ETags; Memory/Dist cache

### CODE SKETCHES
- C# Controller (sample) and DTOs
- React hook using fetch/axios

### RISKS & MITIGATIONS
- Contract drift vs existing ViewPage shape → add mapping layer
- Phased rollout with backend adapter exposing legacy shapes

### TESTS
- Unit tests for controller/services; integration tests against EF Core; contract tests using OpenAPI samples

#### Function Links
| Node | File                                          | Function  | Link                                                                 |
|-----:|-----------------------------------------------|-----------|----------------------------------------------------------------------|
| H    | App_Code/Services/DataControllerService.vb    | GetPage   | ../files/App_Code_Services_DataControllerService.vb.html#function-GetPage |
| H    | App_Code/Services/DataControllerService.vb    | Execute   | ../files/App_Code_Services_DataControllerService.vb.html#function-Execute |

---

## I. Database

### AS-IS (WebForms)
- Key files:
  - App_Code/Data/DataAccess.vb (SqlStatement/SqlText/SqlProcedure), Transactions.vb, Controller*.vb
  - Connection strings via Web.config (name: eZee)
- Patterns:
  - DbProviderFactories; parameter markers @ or : based on provider
  - Stored procedures and text queries; BusinessRules for filtering; Controller pipeline builds PageRequest → ViewPage
- Transactions & caching:
  - Transactions.vb (ambient control)
  - Some caching via PageRequest.SupportsCaching

### PAIN POINTS
- Mixed providers; manual ADO.NET
- Business logic spread across Controller* and BusinessRules
- Hard to unit test

### TO-BE
- EF Core DbContext, entities, configurations
- Repositories/UnitOfWork; TransactionScope or DbContext transaction
- Migrations for schema
- Retry policies (Polly)

### CODE SKETCHES
- DbContext + entity + repository; example LINQ query and pagination

### RISKS & MITIGATIONS
- Mapping legacy filters (string-based) → expression trees; provide compatibility filter parser

### TESTS
- EF in-memory tests; integration tests with Testcontainers

#### Function Links
| Node | File                               | Function         | Link                                                                 |
|-----:|------------------------------------|------------------|----------------------------------------------------------------------|
| I    | App_Code/Data/DataAccess.vb        | ExecuteReader    | ../files/App_Code_Data_DataAccess.vb.html#function-ExecuteReader     |
| I    | App_Code/Data/DataAccess.vb        | ExecuteScalar    | ../files/App_Code_Data_DataAccess.vb.html#function-ExecuteScalar     |
| I    | App_Code/Data/DataAccess.vb        | ExecuteNonQuery  | ../files/App_Code_Data_DataAccess.vb.html#function-ExecuteNonQuery   |
| I    | App_Code/Data/DataAccess.vb        | AssignParameter  | ../files/App_Code_Data_DataAccess.vb.html#function-AssignParameter   |

---

## J. JSON/XML Response

### AS-IS (WebForms)
- ASMX returns serialized objects via JavaScriptSerializer
- REST handler streams JSON/XML manually; supports JSONP; date formatting via ConvertDateToJSON
- Content negotiation by AcceptTypes/_dataType

### PAIN POINTS
- Manual streaming; JSONP; inconsistent date formats

### TO-BE
- System.Text.Json (camelCase), ProblemDetails for errors
- Content negotiation automatic; no JSONP

### CODE SKETCHES
- ASP.NET Core produces IActionResult; ProblemDetails

### TESTS
- Contract tests (OpenAPI), serialization roundtrips

#### Function Links
| Node | File                                              | Function              | Link                                                                                      |
|-----:|---------------------------------------------------|-----------------------|-------------------------------------------------------------------------------------------|
| J    | App_Code/Services/DataControllerService.vb        | Execute               | ../files/App_Code_Services_DataControllerService.vb.html#function-Execute                |
| J    | App_Code/Services/RepresentationalStateTransfer.vb| ExecuteHttpGetRequest | ../files/App_Code_Services_RepresentationalStateTransfer.vb.html#function-ExecuteHttpGetRequest |
| J    | App_Code/Services/RepresentationalStateTransfer.vb| ExecuteActionRequest  | ../files/App_Code_Services_RepresentationalStateTransfer.vb.html#function-ExecuteActionRequest  |

---

## K. Bind to controls & JS render

### AS-IS (WebForms)
- Server-side: .aspx + code-behind binds data to server controls
- Client-side: custom JS (e.g., /js/*) updates DOM; global scripts from master

### PAIN POINTS
- ViewState-heavy; limited testability; mixed server/client binding

### TO-BE
- React (Vite): components, hooks; or Blazor WASM
- Fetch API/axios with SWR/React Query
- Accessible components; SSR/CSR trade-offs

### CODE SKETCHES
- React component consuming /api endpoints; simple table render

### TESTS
- Component tests (RTL), E2E (Playwright)

#### Function Links
| Node | File          | Function  | Link                                              |
|-----:|---------------|-----------|---------------------------------------------------|
| K    | Main.master   | Page_Load | ../files/Main.master.html#function-Page_Load      |
| K    | (client js)   | (todo)    | ../todo.html                                      |

---

## L. Render HTML

### AS-IS (WebForms)
- Main.master handles layout, scripts; final render via ASP.NET pipeline

### TO-BE
- React SPA shell or Blazor root; Bootstrap 5; route-based code-splitting

### RISKS
- Coexistence with legacy WebForms; use sub-app or reverse proxy

#### Function Links
| Node | File        | Function  | Link                                             |
|-----:|-------------|-----------|--------------------------------------------------|
| L    | Main.master | Page_Load | ../files/Main.master.html#function-Page_Load     |

---

## Client Rendering (Modernized)
- Introduce a thin runtime adapter that consumes ViewPage JSON and renders table markup compatible with existing .DataView CSS.
- See: files/js_dataview-runtime-adapter.js.md (functions: fetchViewPageAsmx, fetchViewPageRest, buildModel, renderDataView, mountDataView)

Related Links
- Main.master::Page_Load → ../files/Main.master.html#function-Page_Load
- DataControllerService → ../files/App_Code_Services_DataControllerService.vb.html
