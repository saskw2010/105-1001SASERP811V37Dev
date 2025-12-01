# API Endpoints

- Pages/MenuApi.aspx [WebMethod]
  - POST GetMenuTree: returns { version, items: MenuNodeDto[] } built from Web.sitemap with IsAccessibleToUser trimming and CacheDependency on web.sitemap

- Services/DataControllerService.asmx (ScriptService)
  - GetPage(controller, view, PageRequest): ViewPage
  - GetListOfValues(controller, view, DistinctValueRequest): Object[]
  - Execute(controller, view, ActionArgs): ActionResult
  - GetCompletionList(prefixText, count, contextKey): String[]
  - SavePermalink(link, html)
  - EncodePermalink(link, rooted): String
  - ListAllPermalinks(): String[][]
  - Login(username, password, persistent): Boolean
  - Logout()
  - Roles(): String[]

- TestPages/TestDashboardData.aspx [WebMethod]
  - GetLiveData(): FinancialDashboardModel JSON
  - GetQuickStats(): quick stats JSON

- Handlers (*.ashx)
  - Blob.ashx, Report.ashx, Import.ashx, Export.ashx, WebClientPrintAPI.ashx, Handlers/ThemeApplier.ashx, plus WCP demo handlers
