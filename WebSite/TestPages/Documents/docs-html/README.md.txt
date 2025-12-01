# SASERP V37 - README

This document provides a comprehensive overview of the SASERP V37 project. It is intended for developers, system administrators, and anyone involved in the maintenance and development of the application.

## 1. Project Overview

SASERP V37 is a classic ASP.NET WebForms application built on the .NET Framework 4.7.2, using VB.NET as the code-behind language. It serves as a comprehensive Enterprise Resource Planning (ERP) system with modules for financials, HR, operations, and reporting.

The system is designed to be a robust, data-driven platform with a flexible and themeable user interface.

- **Project Type:** ASP.NET Web Site Project
- **Language:** VB.NET
- **Framework:** .NET Framework 4.7.2
- **Frontend:** Bootstrap, Font Awesome, custom JavaScript framework

## 2. Getting Started

### Prerequisites

- Visual Studio with .NET Framework 4.7.2 support
- IIS Express (or a local IIS instance)

### Running the Application

The recommended way to run the project is using the provided PowerShell script:

1.  Open a PowerShell terminal in the `WebSite` directory.
2.  Execute the script:
    ```powershell
    .\RunSASERP.ps1
    ```
This script will configure and start an IIS Express instance on `http://localhost:8080`.

### Key Directories

- `/App_Code/`: Contains all server-side business logic, data models, and utilities.
- `/Controls/`: Reusable ASP.NET User Controls (.ascx) that form the core UI components.
- `/Pages/`: Contains the individual ASPX pages of the application.
- `/TestPages/`: A collection of pages for testing, debugging, and system guides.
- `/Docs/`: Contains all project documentation.

## 3. Core Concepts

- **Master Pages:** The application uses a system of nested master pages (`Main.master`, `UniversalNavMaster.master`) to provide a consistent layout and global functionality.
- **User Controls:** Functionality is encapsulated in user controls (`.ascx`), promoting reusability. The dashboard widgets are a prime example.
- **Data Binding:** The application follows a classic WebForms data-binding pattern, where controls in the UI are bound to data from the code-behind.
- **Configuration:** The `web.config` file contains all application settings, connection strings, and handlers. The `Web.Sitemap` file defines the navigation structure.

## 4. Documentation

For more detailed information, please refer to the documents in the `/Docs/` directory:

- `ARCHITECTURE.md`: In-depth explanation of the technical architecture.
- `STRUCTURE.md`: A guide to the project's folder and file structure.
- `FUNCTIONALITY.md`: A breakdown of the ERP's features and modules.
- `ROADMAP.md`: The development roadmap for the project.

