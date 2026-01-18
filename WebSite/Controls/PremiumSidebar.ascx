<%@ Control Language="VB" AutoEventWireup="false" CodeFile="PremiumSidebar.ascx.vb" Inherits="Controls_PremiumSidebar" %>

<!-- Floating Sidebar Trigger Button (Burger Icon) -->
<button type="button" class="premium-sidebar-trigger" id="sidebar-trigger" title="القائمة">
    <i class="fas fa-bars"></i>
</button>

<!-- Sidebar Container -->
<aside class="premium-sidebar" id="sidebar">
    <!-- Header (Brand + Close) -->
    <div class="sidebar-header">
        <div class="sidebar-brand">
            <i class="fas fa-cloud-bolt"></i>
            <span>Sky365 ERP</span>
        </div>
        <button type="button" class="sidebar-close-btn" id="sidebar-close-btn" title="إغلاق">
            <i class="fas fa-times"></i>
            <span>إغلاق</span>
        </button>
    </div>

    <!-- Navigation -->
    <nav class="sidebar-nav">
        <div class="nav-section-title">القائمة الرئيسية</div>

        <asp:Repeater ID="rptCategories" runat="server">
            <ItemTemplate>
                <asp:PlaceHolder ID="phSimpleLink" runat="server" Visible='<%# Not DirectCast(Container.DataItem, SiteMapNode).HasChildNodes %>'>
                    <div class="nav-item">
                        <a href='<%# ResolveUrl(Eval("Url").ToString()) %>' class='nav-link <%# IsActive(Eval("Url").ToString()) %>'>
                            <i class='<%# GetIconClass(Eval("Title").ToString()) %>'></i>
                            <span>
                                <%# Eval("Title") %></span>
</a>
</div>
</asp:PlaceHolder>

<asp:PlaceHolder ID="phCollapsible" runat="server" Visible='<%# DirectCast(Container.DataItem, SiteMapNode).HasChildNodes %>'>
                                    <div class="nav-item-collapsible">
                                        <div class="nav-toggle">
                                            <div style="display: flex; align-items: center; gap: 12px;">
                                                <i class='<%# GetIconClass(Eval("Title").ToString()) %>'></i>
                                                <span>
                                                    <%# Eval("Title") %></span>
</div>
<i class="fas fa-chevron-down toggle-icon"></i>
                                                </div>
                                                <div class="nav-submenu">
                                                    <asp:Repeater ID="rptSubItems" runat="server" DataSource='<%# DirectCast(Container.DataItem, SiteMapNode).ChildNodes %>'>
                                                        <ItemTemplate>
                                                            <a href='<%# ResolveUrl(Eval("Url").ToString()) %>' class='nav-link <%# IsActive(Eval("Url").ToString()) %>'>
                                                                <i class="fas fa-circle" style="font-size: 0.5rem;"></i>
                                                                <span>
                                                                    <%# Eval("Title") %></span>
</a>
</ItemTemplate>
</asp:Repeater>
</div>
</div>
</asp:PlaceHolder>
</ItemTemplate>
</asp:Repeater>
</nav>

<!-- Footer -->
<div class="sidebar-footer">
                                                                        <div class="user-profile">
                                                                            <div class="user-avatar">
                                                                                <asp:Literal ID="litUserInitials" runat="server">U</asp:Literal>
                                                                            </div>
                                                                            <div class="user-info">
                                                                                <p class="user-name">
                                                                                    <asp:LoginName ID="LoginName1" runat="server" FormatString="{0}" />
                                                                                </p>
                                                                                <p class="user-role">
                                                                                    <asp:LoginStatus ID="LoginStatus1" runat="server" LogoutText="تسجيل خروج" LogoutAction="Redirect" LogoutPageUrl="~/Default.aspx" />
                                                                                </p>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </aside>

                                                                <!-- Sidebar Backdrop -->
                                                                <div class="sidebar-backdrop" id="sidebar-backdrop"></div>

                                                                <script>
    document.addEventListener("DOMContentLoaded", function () {
        const sidebar = document.getElementById('sidebar');
        const trigger = document.getElementById('sidebar-trigger');
        const closeBtn = document.getElementById('sidebar-close-btn');
        const backdrop = document.getElementById('sidebar-backdrop');
        const body = document.body;

        if (trigger) {
            const icon = trigger.querySelector('i');
            if (icon) {
                icon.className = 'fas fa-bars';
            }
        }

        const openSidebar = (e) => {
            if (e) e.stopPropagation();
            sidebar.classList.add('visible');
            backdrop.classList.add('visible');
            trigger.classList.add('hidden');
            body.classList.add('sidebar-open');
        };

        const closeSidebar = () => {
            sidebar.classList.remove('visible');
            backdrop.classList.remove('visible');
            trigger.classList.remove('hidden');
            body.classList.remove('sidebar-open');
            document.querySelectorAll('.nav-submenu.expanded').forEach(el => el.classList.remove('expanded'));
            document.querySelectorAll('.nav-toggle.expanded').forEach(el => el.classList.remove('expanded'));
        };

        trigger.addEventListener('click', openSidebar);
        closeBtn.addEventListener('click', closeSidebar);
        backdrop.addEventListener('click', closeSidebar);

        sidebar.addEventListener('click', (e) => {
            const toggleBtn = e.target.closest('.nav-toggle');
            if (toggleBtn) {
                e.stopPropagation();
                toggleBtn.classList.toggle('expanded');
                const submenu = toggleBtn.nextElementSibling;
                if (submenu) submenu.classList.toggle('expanded');
            }
        });
    });
                                                                </script>