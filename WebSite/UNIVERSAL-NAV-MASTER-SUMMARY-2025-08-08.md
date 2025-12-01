# SASERP V37 – Navigation and Master Pages Summary (2025-08-08)

## Platform
- ASP.NET WebForms (VB.NET), .NET Framework 4.7.2, IIS Express (port 8080).
- Forms Authentication working; unauthenticated redirects to Login.

## Masters – Current State and Direction
- UniversalNavMaster.master (modern):
  - Injects `window.AppConfig` (culture, auth, features, nav.startingNodeUrl).
  - Adds mobile/PWA meta, performance tweaks, optional analytics.
  - Hides navigation on Login pages.
  - Ensures Vue 3 local (`/js/vue.global.prod.js`) is included once.
- Main.master (legacy-modern hybrid):
  - Uses `aquarium:MenuExtender` + `asp:SiteMapDataSource` (ShowStartingNode=False).
  - Button toggle for PageMenuBar on mobile (`togglePageMenuBar`).
  - Code-behind sets menu to start from CurrentNode (or Parent when page is leaf).
  - Exposes minimal `window.AppConfig` (nav.startingNodeUrl). Ensures Vue once.

## UniversalHamburgerMenu (Controls/UniversalHamburgerMenu.ascx.vb)
- Start node logic:
  - Builds menu from the current sitemap node (children only). If page is leaf → use parent. Falls back to root.
  - Optional override: `?startNode=/Pages/Finance/Default.aspx` (or any sitemap URL).
- Access control: filters by user auth and roles per node.
- Caching: per-user + per-startNode key for 10 minutes to avoid rebuilding.
- Output data:
  - `hdnMenuData`: JSON array of navigation items (JavaScriptSerializer).
  - `hdnCurrentPage`: JSON with path, title, description, breadcrumbs.
- Resources: ensures CSS `/css/universal-hamburger-menu.css`, Vue 3, and `/js/navigation-vue-components.js` are loaded.
- JSON policy: uses `System.Web.Script.Serialization.JavaScriptSerializer` (no Newtonsoft).

## Main.master behavior (navigation scope)
- `SiteMapDataSource1` configured at runtime:
  - If CurrentNode has children → `StartFromCurrentNode=True`.
  - If page is leaf → `StartingNodeUrl = Parent.Url` (children of parent only).
  - `ShowStartingNode=False` always.

## Test Pages (UniversalNavMaster)
- Navigation Example: http://localhost:8080/TestPages/NavigationExample.aspx
- System Links Guide: http://localhost:8080/TestPages/SystemLinksGuide.aspx
- Tip: append `?startNode=/Pages/Finance/Default.aspx` to test alternative scopes.

## Recent Fixes
- Replaced Newtonsoft with JavaScriptSerializer in UniversalHamburgerMenu.
- Fixed VB JSON string literals (BC30205) by using doubled quotes.
- Aligned Reports dashboard binding with model; other compile fixes done earlier.

## Notes & Recommendations
- Styling: recent manual edits in `css/StyleSheet.css`. Verify no conflicts with Bootstrap 5 / FA 6.
- Adoption plan: keep Main.master for legacy pages; adopt UniversalNavMaster for new/modern pages, migrate gradually.
- Consistency: ensure Vue version alignment (test pages used Vue 2 CDN; app ships Vue 3 locally).
- Assets: verify fallback images used by TableOfContents/Home TOC exist (default icons).

## Troubleshooting
- If you see BC30205 around JSON literals, ensure VB strings use doubled quotes, e.g.:
  - Bad: `hdnUserInfo.Value = "{\"username\":\"Guest\"}"`
  - Good: `hdnUserInfo.Value = "{""username"":""Guest""}"`
- If nav shows too many nodes, confirm StartFromCurrentNode/StartingNodeUrl and the current sitemap position.

## Next Steps (Todo)
- Unify navigation UX between UniversalNavMaster and Main.master (optional: use same start logic everywhere).
- Add breadcrumbs renderer in the UI using `hdnCurrentPage`.
- Cache invalidation on role change or sitemap updates (optional: vary by auth cookie).
- Review SharedBusinessRules consumers that might rebuild menus; scope to subtree if applicable.
