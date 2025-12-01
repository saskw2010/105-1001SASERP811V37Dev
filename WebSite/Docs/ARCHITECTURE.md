# SASERP V37 - Architecture

This document provides a detailed overview of the technical architecture of the SASERP V37 application.

## 1. Core Technology Stack

- **Backend:** ASP.NET WebForms with VB.NET
- **Framework:** .NET Framework 4.7.2
- **Web Server:** IIS / IIS Express
- **Database:** (Not specified, but typically SQL Server for such applications)
- **Frontend:** HTML, CSS, JavaScript, Bootstrap, Font Awesome

## 2. Architectural Layers

The application follows a traditional n-tier architecture, logically separated into the following layers:

### 2.1. Presentation Layer

This is what the user interacts with. It is composed of:

- **ASPX Pages:** The main entry points for user requests. They contain the markup and references to user controls.
- **User Controls (.ascx):** Reusable UI components that encapsulate specific functionality (e.g., dashboards, forms, menus). They have their own markup and code-behind.
- **Master Pages (.master):** Provide the overall page layout, navigation, and global styles/scripts. `Main.master` and `UniversalNavMaster.master` are the key master pages.
- **CSS & JavaScript:**
    - `/css/`: Contains stylesheets for the application, including `modern-menu.css` for the navigation drawer.
    - `/js/`: Contains JavaScript files, including `modern-menu-once.js` for the main navigation logic.
    - `/VueCss/` & `/Vuejs/`: Contain Vue-related assets for modern UI components and documentation pages.

### 2.2. Business Logic Layer

This layer contains the core business rules and application logic. It is primarily located in the `App_Code` directory:

- **VB.NET Classes:** Files like `DashboardModels.vb` and `AdvancedMenuBuilder.vb` contain the application's business logic.
- **Services:** The `/App_Code/Services/` directory is intended for web services or API-like functionality.
- **Rules:** The `/App_Code/Rules/` directory is for business rule definitions and validation logic.

### 2.3. Data Access Layer

This layer is responsible for interacting with the database.

- **Data Models:** The classes within `DashboardModels.vb` represent the data structures used in the application.
- **Database Connectivity:** Connection strings and data source configurations are managed in `web.config`. The actual data access logic is likely within the business layer or a dedicated data access component.

## 3. Key Architectural Patterns

- **Web Site Project Model:** This project is an ASP.NET Web Site, which means there is no `.vbproj` file, and compilation occurs dynamically at runtime. This allows for easy changes and updates without needing to recompile the entire application.
- **Server-Side Rendering:** As a classic WebForms application, most of the UI is rendered on the server.
- **AJAX with UpdatePanels:** The application may use `UpdatePanel` controls for partial page updates to provide a more responsive user experience without full page reloads.
- **JSON Serialization:** The application uses the built-in `System.Web.Script.Serialization.JavaScriptSerializer` for serializing .NET objects to JSON, avoiding external dependencies like Newtonsoft.Json.

## 4. Navigation System

The navigation is a hybrid system:

- **Legacy System:** Uses `Web.Sitemap` with a `SiteMapDataSource` and the `aquarium:MenuExtender` to generate the main menu (`PageMenuBar`).
- **Modern System:** A modern, accessible navigation drawer is implemented in `js/modern-menu-once.js`. It fetches menu data from a JSON endpoint (`/Pages/MenuApi.aspx/GetMenuTree`) and renders it on the client-side. The legacy menu is hidden but remains as a data source and for compatibility.
