# SASERP V37 - Project Structure

This document outlines the folder and file structure of the SASERP V37 project.

## Root Directory

- `Main.master`: The primary master page for the application.
- `UniversalNavMaster.master`: A master page providing universal navigation.
- `web.config`: The main configuration file for the ASP.NET application.
- `Web.Sitemap`: Defines the navigation structure of the site.
- `Global.asax`: Handles global application-level events.
- `RunSASERP.ps1`: A PowerShell script to easily start the application.
- `Docs/`: Contains all project documentation.

## Key Folders

### `/App_Code/`

This is the heart of the application's backend logic.

- `DashboardModels.vb`: Contains the data models for all dashboards.
- `AdvancedMenuBuilder.vb`: Logic for building and customizing the navigation menu.
- `MyUtils.vb`: A collection of utility functions.
- `Services/`: Contains web services and API endpoints.
- `Security/`: Code related to authentication and authorization.

### `/Controls/`

Contains reusable ASP.NET User Controls (`.ascx`).

- `*Dashboard.ascx`: A set of controls for the various dashboards (Financial, HR, etc.).
- `UniversalHamburgerMenu.ascx`: The user control for the main navigation menu.
- `HomeTableOfContents.ascx`: The control for the table of contents on the home page.

### `/Pages/`

Contains the individual pages (`.aspx`) of the application. This directory is extensive and contains thousands of pages, each corresponding to a specific feature or view in the ERP system.

### `/TestPages/`

A directory for testing and documentation.

- `PagesIndex.aspx`: An index of all test pages and system guides.
- `TestDashboardData.aspx`: A page with WebMethods for testing dashboard data.
- `docs/`: Contains the Vue-based interactive documentation site.

### `/css/`

Contains the application's stylesheets.

- `modern-menu.css`: Styles for the modern navigation drawer.
- `pagemenubar.css`: Styles for the legacy menu system.
- `notifications.css`: Styles for UI notifications.

### `/js/`

Contains the application's JavaScript files.

- `modern-menu-once.js`: The primary script for the modern navigation drawer.
- `pagemenubar-mobile.js`: JavaScript for the legacy mobile menu.
- `notifications.js`: A helper for displaying UI notifications.

### `/VueCss/` & `/Vuejs/`

These folders contain assets related to the Vue.js framework, used for modern UI components and the interactive documentation pages.

- `/Vuejs/vue.global.prod.js`: The Vue 3 runtime.
- `/VueCss/ModernTheme.css`: A modern theme used by Vue components.
