# Folder: App_Code

- Purpose: Shared VB.NET code (services, models, utils) compiled at runtime in Web Site projects.
- Notable subfolders: Data/, Handlers/, Rules/, Security/, Services/, VBCode/, Web/
- Key files:
  - AdvancedMenuBuilder.vb: Builds modern menu data/HTML; icon mapping; role-based checks.
  - DashboardModels.vb: Dashboard data models with LoadSampleData.
  - Services/DataControllerService.vb: ASMX ScriptService (Code On Time) exposing CRUD, auth.
  - MyUtils.vb, DynamicControlConverter.vb: utilities.

Conventions:
- Explicit types. Use JavaScriptSerializer for JSON when needed.
- WebMethods are decorated with <WebMethod>/<ScriptMethod>.
