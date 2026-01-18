# Modernization & Excel Export Plan

This document outlines the steps to implement high-performance Excel export and modern grid components in the legacy and new projects.

## 1. Excel Export Implementation (Priority: High)

### Objective
Implement a memory-efficient "Export to Excel" feature using `DocumentFormat.OpenXml` (SAX approach) to handle large datasets without crashing the server.

### Steps
1.  **Install Library:**
    *   Ensure `DocumentFormat.OpenXml` is available.
    *   For `811v37` (Legacy): Copy the DLL to `Bin/` or install via NuGet if possible.
    *   For `ezeequizz` (New): Install NuGet package `DocumentFormat.OpenXml`.

2.  **Create Helper Class:**
    *   **File:** `App_Code/ExcelExportHelper.vb` (for 811v37) and `.cs` (for ezeequizz).
    *   **Functionality:**
        *   Accept `DataTable` or `IEnumerable<T>`.
        *   Use `OpenXmlWriter` to stream data directly to `Response.OutputStream`.
        *   Format dates as `yyyy-MM-dd`.
        *   Auto-generate headers.

3.  **UI Integration:**
    *   Add an "Export" button to the target ASPX pages (e.g., `CustomersDataGrid.aspx`).
    *   **Code-Behind:**
        ```vb
        Protected Sub btnExport_Click(sender As Object, e As EventArgs)
            Dim data As DataTable = GetData() ' Fetch your data
            ExcelExportHelper.Export(data, "Report.xlsx", Response)
        End Sub
        ```

## 2. Modern Grid Implementation (Tabulator)

### Objective
Replace heavy/slow grids with **Tabulator**, a fast JavaScript grid that connects to existing APIs.

### Steps
1.  **Setup:**
    *   Add `tabulator.min.js` and `tabulator.min.css` to `assets/`.

2.  **Create Template:**
    *   Create `ModernGrid.html` as a reusable component.

3.  **Data Binding Strategy:**
    *   **Legacy (811v37):**
        *   Use `Services/DataControllerService.asmx/GetPage`.
        *   Method: `POST`.
        *   Payload: JSON object matching CodeOnTime request structure.
    *   **New (ezeequizz):**
        *   Use `api/v2/sql` or specific API controllers.
        *   Method: `GET` or `POST` with Bearer Token.

## 3. API Strategy

*   **Legacy (811v37):**
    *   **Status:** Has `RepresentationalStateTransfer.vb` but routes are not active.
    *   **Decision:** Do **NOT** refactor to use modern API controllers. Use the existing stable `DataControllerService.asmx`.
*   **New (ezeequizz):**
    *   **Status:** Fully supports `api/v2`.
    *   **Decision:** Use the new API endpoints.

## 4. Pending Tasks
*   [ ] Create `ExcelExportHelper.vb` in `811v37`.
*   [ ] Create `ExcelExportHelper.cs` in `ezeequizz`.
*   [ ] Create `ModernGrid.html` prototype.
