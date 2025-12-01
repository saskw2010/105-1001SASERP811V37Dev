# File: Pages/MenuApi.aspx.vb

- WebMethod GetMenuTree(): returns {version, items[]} where items are MenuNodeDto built from Web.sitemap.
- Trims by user access (IsAccessibleToUser).
- CacheDependency on web.sitemap; per-user cache key; 2-4h TTL.
- Node fields: Title, Url, BadgeText, BadgeType, Icon, Children[].

### Function: GetMenuTree
- Signature: <WebMethod()> Public Shared Function GetMenuTree() As Object
- Purpose: Return the menu JSON for the current user.
- Returns: { version As String, items As List(Of MenuNodeDto) }
- Calls: GetMenuVersion(HttpContext), BuildNode(SiteMapNode, HttpContext)
- Called by: POST /Pages/MenuApi.aspx/GetMenuTree

### Function: BuildNode
- Signature: Private Shared Function BuildNode(node As SiteMapNode, ctx As HttpContext) As MenuNodeDto
- Purpose: Convert a SiteMapNode to MenuNodeDto, recursively.
- Calls: SafeAttr(SiteMapNode, String)
- Called by: GetMenuTree()

### Function: GetMenuVersion
- Signature: Private Shared Function GetMenuVersion(ctx As HttpContext) As String
- Purpose: Create a version string for cache invalidation.
- Called by: GetMenuTree()

### Function: SafeAttr
- Signature: Private Shared Function SafeAttr(n As SiteMapNode, key As String) As String
- Purpose: Safely read node attributes.
- Called by: BuildNode()
