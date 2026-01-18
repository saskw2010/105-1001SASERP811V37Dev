<%@ Page Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="ModernGridDemo.aspx.vb" Inherits="ModernGridDemo" Title="Modern Grid Demo (Legacy)" %>

<asp:Content ID="Content2" ContentPlaceHolderID="PageTitleContentPlaceHolder" Runat="Server">
    Modern Grid & Excel Export Demo (Legacy)
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <!-- Tabulator CSS -->
    <link href="https://unpkg.com/tabulator-tables@5.5.0/dist/css/tabulator_bootstrap5.min.css" rel="stylesheet">
    <style>
        .action-btn { margin: 0 2px; }
        /* Ensure grid is visible */
        #myGrid { width: 100%; }
    </style>
    <div class="container-fluid mt-4">
        <div class="card shadow">
            <div class="card-header bg-primary text-white d-flex justify-content-between align-items-center">
                <h5 class="mb-0">Projects List</h5>
                <div>
                    <button type="button" id="btnRefresh" class="btn btn-light btn-sm">Refresh</button>
                    <asp:Button ID="btnExport" runat="server" Text="Export to Excel" OnClick="btnExport_Click" CssClass="btn btn-success btn-sm" />
                </div>
            </div>
            <div class="card-body">
                <div id="myGrid"></div>
            </div>
        </div>
    </div>

    <!-- Tabulator JS -->
    <script src="https://unpkg.com/tabulator-tables@5.5.0/dist/js/tabulator.min.js"></script>
    
    <script>
        var table;

        document.addEventListener("DOMContentLoaded", function () {
            // Initialize Tabulator
            table = new Tabulator("#myGrid", {
                layout: "fitColumns",
                height: "500px",
                placeholder: "No Data Available",
                columns: [
                    { title: "ID", field: "ProjectId", width: 70 },
                    { title: "Project Name", field: "ProjectName", headerFilter: "input" },
                    { title: "Status", field: "StatusName", headerFilter: "input" },
                    { title: "Country", field: "CountryName", headerFilter: "input" },
                    { title: "Budget", field: "Budget", formatter: "money", formatterParams: { symbol: "$" } },
                    { title: "Donor", field: "MainDonorName" }
                ],
                ajaxURL: "ModernGridDemo.aspx/GetData",
                ajaxConfig: {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json; charset=utf-8"
                    }
                },
                ajaxContentType: "json",
                ajaxResponse: function (url, params, response) {
                    // ASP.NET WebMethod returns data in "d" property
                    return response.d || response;
                }
            });

            // Refresh Button
            document.getElementById("btnRefresh").addEventListener("click", function () {
                table.setData();
            });
        });
    </script>
</asp:Content>
