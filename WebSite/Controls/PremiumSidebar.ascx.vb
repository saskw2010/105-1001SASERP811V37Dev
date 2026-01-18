Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Class Controls_PremiumSidebar
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            BindMenu()
            SetUserInitials()
        End If
    End Sub

    Private Sub BindMenu()
        Dim root As SiteMapNode = SiteMap.RootNode
        If root IsNot Nothing Then
            rptCategories.DataSource = root.ChildNodes
            rptCategories.DataBind()
        End If
    End Sub

    Protected Function GetIconClass(ByVal title As String) As String
        If String.IsNullOrEmpty(title) Then Return "fas fa-circle"
        Dim lowerTitle As String = title.ToLower().Trim()

        ' 1. Core & Admin
        If lowerTitle.Contains("home") OrElse lowerTitle.Contains("sitehome") Then Return "fas fa-home"
        If lowerTitle.Contains("membership") OrElse lowerTitle.Contains("users") OrElse lowerTitle.Contains("role") Then Return "fas fa-users-cog"
        If lowerTitle.Contains("technical support") OrElse lowerTitle.Contains("system") Then Return "fas fa-tools"
        If lowerTitle.Contains("audit") Then Return "fas fa-user-secret"
        If lowerTitle.Contains("security") OrElse lowerTitle.Contains("permission") Then Return "fas fa-shield-alt"
        If lowerTitle.Contains("setting") OrElse lowerTitle.Contains("config") Then Return "fas fa-cogs"

        ' 2. Business & Core Modules
        If lowerTitle.Equals("school") OrElse lowerTitle.Contains("academic") Then Return "fas fa-building-columns"
        If lowerTitle.Contains("student") OrElse lowerTitle.Contains("pupil") Then Return "fas fa-user-tie"
        If lowerTitle.Contains("teacher") OrElse lowerTitle.Contains("staff") Then Return "fas fa-person-chalkboard"
        If lowerTitle.Contains("class") OrElse lowerTitle.Contains("grade") Then Return "fas fa-layer-group"
        If lowerTitle.Contains("control") AndAlso (lowerTitle.Contains("school") OrElse lowerTitle.Contains("exam")) Then Return "fas fa-clipboard-check"
        If lowerTitle.Contains("exam") OrElse lowerTitle.Contains("quiz") OrElse lowerTitle.Contains("test") Then Return "fas fa-file-signature"
        If lowerTitle.Contains("result") OrElse lowerTitle.Contains("mark") Then Return "fas fa-square-poll-vertical"
        If lowerTitle.Contains("transport") OrElse lowerTitle.Contains("bus") Then Return "fas fa-bus-alt"
        If lowerTitle.Contains("community") OrElse lowerTitle.Contains("social") Then Return "fas fa-comments"
        If lowerTitle.Contains("special needs") Then Return "fas fa-hands-helping"
        If lowerTitle.Contains("health") OrElse lowerTitle.Contains("clinic") Then Return "fas fa-heartbeat"
        If lowerTitle.Contains("library") OrElse lowerTitle.Contains("book") Then Return "fas fa-book"

        ' 3. Finance & General Ledger
        If lowerTitle.Contains("general ledger") OrElse lowerTitle.Contains("gl") Then Return "fas fa-book-open"
        If lowerTitle.Contains("finance") OrElse lowerTitle.Contains("financial") Then Return "fas fa-coins"
        If lowerTitle.Contains("bank") OrElse lowerTitle.Contains("cash") Then Return "fas fa-money-check-alt"
        If lowerTitle.Contains("voucher") OrElse lowerTitle.Contains("receipt") OrElse lowerTitle.Contains("invoice") Then Return "fas fa-file-invoice-dollar"
        If lowerTitle.Contains("account") OrElse lowerTitle.Contains("chart") Then Return "fas fa-sitemap"
        If lowerTitle.Contains("asset") OrElse lowerTitle.Contains("fixed") Then Return "fas fa-building"
        If lowerTitle.Contains("budget") Then Return "fas fa-wallet"
        If lowerTitle.Contains("cost") AndAlso lowerTitle.Contains("center") Then Return "fas fa-chart-pie"

        ' 4. Stock & Inventory
        If lowerTitle.Contains("stock") OrElse lowerTitle.Contains("inventory") Then Return "fas fa-boxes"
        If lowerTitle.Contains("item") OrElse lowerTitle.Contains("product") Then Return "fas fa-box-open"
        If lowerTitle.Contains("bundle") OrElse lowerTitle.Contains("package") Then Return "fas fa-cubes"
        If lowerTitle.Contains("store") OrElse lowerTitle.Contains("warehouse") Then Return "fas fa-warehouse"
        If lowerTitle.Contains("supplier") OrElse lowerTitle.Contains("vendor") Then Return "fas fa-truck-loading"

        ' 5. HR & Payroll
        If lowerTitle.Equals("hr") OrElse lowerTitle.Contains("human resource") Then Return "fas fa-user-tie"
        If lowerTitle.Contains("payroll") OrElse lowerTitle.Contains("salary") Then Return "fas fa-file-signature"
        If lowerTitle.Contains("employee") Then Return "fas fa-id-badge"
        If lowerTitle.Contains("attendance") OrElse lowerTitle.Contains("time") Then Return "fas fa-clock"
        If lowerTitle.Contains("vacation") OrElse lowerTitle.Contains("leave") Then Return "fas fa-plane-departure"

        ' 6. Strategy & Planning
        If lowerTitle.Contains("strategic") OrElse lowerTitle.Contains("plan") Then Return "fas fa-chess"
        If lowerTitle.Contains("goal") OrElse lowerTitle.Contains("object") Then Return "fas fa-bullseye"
        If lowerTitle.Contains("memo") OrElse lowerTitle.Contains("task") Then Return "fas fa-sticky-note"

        ' 7. Generic
        If lowerTitle.Contains("report") Then Return "fas fa-chart-bar"
        If lowerTitle.Contains("help") OrElse lowerTitle.Contains("support") Then Return "fas fa-life-ring"
        If lowerTitle.Contains("dash") Then Return "fas fa-tachometer-alt"

        Return "fas fa-folder"
    End Function

    Protected Function IsActive(ByVal url As String) As String
        Dim currentUrl As String = Request.AppRelativeCurrentExecutionFilePath
        If String.IsNullOrEmpty(url) Then Return ""
        If url.Equals(currentUrl, StringComparison.OrdinalIgnoreCase) Then Return "active"
        Return ""
    End Function

    Private Sub SetUserInitials()
        Dim username As String = Page.User.Identity.Name
        If Not String.IsNullOrEmpty(username) Then
            litUserInitials.Text = username.Substring(0, 1).ToUpper()
        Else
            litUserInitials.Text = "?"
        End If
    End Sub
End Class