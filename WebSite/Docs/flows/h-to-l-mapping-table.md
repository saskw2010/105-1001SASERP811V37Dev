# H→L Mapping Table

| Step | Old File:Function | Callers | Callees | HTTP/DB Details | New Endpoint/DTO | New Module (file) | Notes/Risks |
|------|--------------------|---------|---------|------------------|------------------|-------------------|-------------|
| H | App_Code/Services/DataControllerService.vb::GetPage | JS fetch; ControllerDataSource | IDataController.GetPage | POST ASMX or GET REST; JSON/XML | GET /api/{controller}?pageIndex=... | Api/{Controller}Controller.cs | Map legacy filters |
| H | App_Code/Services/DataControllerService.vb::Execute | JS fetch; forms | IDataController.Execute | POST; JSON | POST /api/{controller}/actions/{action} | Api/{Controller}Controller.cs | Action semantics |
| I | App_Code/Data/* (Controller.*.vb, DataAccess.vb) | Controllers, BusinessRules | DbProviderFactories, ADO.NET | SP/Text SQL; params; transactions | EF Core DbContext/Repos | Infrastructure/Data/* | Filter parser needed |
| J | App_Code/Services/RepresentationalStateTransfer.vb::ExecuteHttpGetRequest | REST GET | IDataController.GetPage | JSON/XML; JSONP; gzip/deflate | JSON only; ProblemDetails | Middleware + Controllers | Remove JSONP |
| K | Pages/*.aspx(.vb), js/* | User actions | WebMethods/REST | ViewState + JS | React/Blazor UI components | webapp/src/* | Mixed binding to SPA |
| L | Main.master(.vb) | ASP.NET pipeline | n/a | Rendered HTML | SPA shell | webapp/index.html | Hybrid deployment |
| VPG1 | App_Code/Services/DataControllerService.vb::GetPage | Web DataView scripts | Controllers via ControllerFactory | ASMX ScriptService returns ViewPage | PageRequestDto/ViewPageDto | js/dataview-runtime-adapter.js::mountDataView | Client render aligned to .DataView CSS; no dependency on combined scripts |
