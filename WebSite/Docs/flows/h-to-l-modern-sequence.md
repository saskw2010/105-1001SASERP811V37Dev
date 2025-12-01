# Modern Sequence (H→L)

```mermaid
sequenceDiagram
  autonumber
  participant UI as Frontend (React/Blazor)
  participant API as ASP.NET Core API
  participant SVC as Service Layer
  participant DB as EF Core / DB

  UI->>API: GET /api/{controller}?pageIndex=..&pageSize=..
  API->>SVC: Build PageRequestDto, validate
  SVC->>DB: Query via DbContext (AsNoTracking, filters)
  DB-->>SVC: Page of data (entities)
  SVC-->>API: ViewPageDto
  API-->>UI: 200 OK (application/json)

  UI->>API: POST /api/{controller}/actions/{action}
  API->>SVC: Validate ActionArgsDto
  SVC->>DB: Transactional update
  DB-->>SVC: ActionResult
  SVC-->>API: ActionResultDto / ProblemDetails
  API-->>UI: 200/4xx
```

Links:
- DataControllerService (legacy): ../TestPages/Documents/docs-html/files/App_Code_Services_DataControllerService.vb.html
- Main.master: ../TestPages/Documents/docs-html/files/Main.master.html
- Menu API: ../TestPages/Documents/docs-html/files/Pages_MenuApi.aspx.vb.html
- RepresentationalStateTransfer: ../TestPages/Documents/docs-html/files/App_Code_Services_RepresentationalStateTransfer.vb.html
- dataview-runtime-adapter.js: ../files/js_dataview-runtime-adapter.js.md
