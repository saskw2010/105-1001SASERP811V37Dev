# Folder: Pages

- Purpose: Main application pages (ASPX) with business modules; role-protected via web.config <location>.
- Menu source: Web.sitemap (security trimmed). Menu JSON via Pages/MenuApi.aspx.
- Examples:
  - Membership.aspx, GLTransaction.aspx, StockControl.aspx, POSINVOICE.aspx, HR*.aspx, sch*.aspx, etc.
- API endpoint: MenuApi.aspx (GetMenuTree).

Testing:
- TestPages/PagesIndex.aspx lists test links.
