<%@ Control Language="VB" AutoEventWireup="false" CodeFile="UniversalHamburgerMenu.ascx.vb" Inherits="UniversalHamburgerMenu" %>

<!-- Universal Hamburger Menu Control -->
<!-- يتم تحميل هذا الكنترول في كل الصفحات لتوفير قائمة برجر موحدة -->

<div id="universalHamburgerMenu" class="universal-hamburger-wrapper">
    <!-- Hamburger Toggle Button -->
    <button id="hamburgerToggle" class="hamburger-toggle" @click="mainmaster.navigation.toggleMenu()">
        <span class="hamburger-line"></span>
        <span class="hamburger-line"></span>
        <span class="hamburger-line"></span>
    </button>

    <!-- App Title/Brand -->
    <div class="app-brand">
        <span class="app-title">{{ appTitle }}</span>
        <span class="current-page">{{ currentPageTitle }}</span>
    </div>

    <!-- User Profile Quick Access -->
    <div class="user-profile-quick">
        <button class="profile-toggle" @click="mainmaster.navigation.toggleProfile()">
            <i class="fas fa-user"></i>
            <span class="username">{{ currentUser }}</span>
        </button>
    </div>

    <!-- Navigation Overlay -->
    <div id="navigationOverlay" class="navigation-overlay" :class="{ 'active': isMenuOpen }" @click="mainmaster.navigation.closeMenu()">
        <div class="navigation-content" @click.stop>
            <!-- Close Button -->
            <button class="close-nav" @click="mainmaster.navigation.closeMenu()">
                <i class="fas fa-times"></i>
            </button>

            <!-- Search Box -->
            <div class="nav-search">
                <input type="text" v-model="searchTerm" @input="mainmaster.navigation.filterMenu()" 
                       placeholder="البحث في القوائم..." class="nav-search-input">
                <i class="fas fa-search search-icon"></i>
            </div>

            <!-- User Profile Section -->
            <div class="user-profile-section" v-if="showProfileSection">
                <div class="profile-info">
                    <div class="profile-avatar">
                        <i class="fas fa-user-circle"></i>
                    </div>
                    <div class="profile-details">
                        <h4>{{ currentUser }}</h4>
                        <p>{{ userRole }}</p>
                    </div>
                </div>
                <div class="profile-actions">
                    <button @click="mainmaster.navigation.goToProfile()" class="profile-btn">
                        <i class="fas fa-cog"></i> الإعدادات
                    </button>
                    <button @click="mainmaster.navigation.logout()" class="logout-btn">
                        <i class="fas fa-sign-out-alt"></i> تسجيل خروج
                    </button>
                </div>
            </div>

            <!-- Navigation Tree -->
            <div class="navigation-tree">
                <nav-menu-item 
                    v-for="item in filteredMenuItems" 
                    :key="item.id"
                    :item="item"
                    :level="0"
                    @navigate="mainmaster.navigation.navigateToPage($event)">
                </nav-menu-item>
            </div>

            <!-- Quick Actions -->
            <div class="quick-actions">
                <button @click="mainmaster.navigation.goToHome()" class="quick-action-btn">
                    <i class="fas fa-home"></i>
                    <span>الرئيسية</span>
                </button>
                <button @click="mainmaster.navigation.goToDashboard()" class="quick-action-btn">
                    <i class="fas fa-chart-pie"></i>
                    <span>لوحة التحكم</span>
                </button>
                <button @click="mainmaster.navigation.goToReports()" class="quick-action-btn">
                    <i class="fas fa-file-alt"></i>
                    <span>التقارير</span>
                </button>
                <button @click="mainmaster.navigation.toggleTheme()" class="quick-action-btn">
                    <i class="fas fa-palette"></i>
                    <span>الثيم</span>
                </button>
            </div>

            <!-- Footer Info -->
            <div class="nav-footer">
                <div class="system-info">
                    <span>SASERP V37</span>
                    <span class="version">إصدار 1.1.37</span>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Vue.js Navigation Component Template -->
<script type="text/x-template" id="nav-menu-item-template">
    <div class="nav-menu-item" :class="{ 'has-children': item.hasChildren, 'level-' + level }">
        <div class="nav-item-header" @click="toggleItem()">
            <div class="nav-item-content">
                <i :class="item.icon" class="nav-item-icon"></i>
                <span class="nav-item-title">{{ item.title }}</span>
                <span class="nav-item-count" v-if="item.childrenCount">{{ item.childrenCount }}</span>
            </div>
            <i v-if="item.hasChildren" :class="{ 'fas fa-chevron-down': !isExpanded, 'fas fa-chevron-up': isExpanded }" 
               class="nav-item-toggle"></i>
        </div>
        
        <div v-if="!item.hasChildren" class="nav-item-link" @click="navigateToPage()">
            <span class="nav-link-text">{{ item.title }}</span>
            <span class="nav-link-description" v-if="item.description">{{ item.description }}</span>
        </div>

        <div v-if="item.hasChildren && isExpanded" class="nav-children">
            <nav-menu-item 
                v-for="child in item.children" 
                :key="child.id"
                :item="child"
                :level="level + 1"
                @navigate="$emit('navigate', $event)">
            </nav-menu-item>
        </div>
    </div>
</script>

<!-- Hidden data elements for server-side data -->
<asp:HiddenField ID="hdnMenuData" runat="server" />
<asp:HiddenField ID="hdnUserInfo" runat="server" />
<asp:HiddenField ID="hdnCurrentPage" runat="server" />
