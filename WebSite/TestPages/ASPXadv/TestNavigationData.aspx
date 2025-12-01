<%@ Page Language="VB" MasterPageFile="~/ModernMaster.master" AutoEventWireup="false" CodeFile="TestNavigationData.aspx.vb" Inherits="TestPages_ASPXADV_TestNavigationData" Title="Navigation Data Test" %>
<%@ Register TagPrefix="uc" TagName="RealEstate" Src="~/Controls/RealEstateControl.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <!-- Navigation Data Test Page Styles -->
    <style>
        .nav-test-header {
            background: linear-gradient(135deg, #2c3e50 0%, #34495e 100%);
            color: white;
            padding: 2rem 0;
            margin-bottom: 2rem;
        }
        
        .nav-test-header h1 {
            font-size: 2.5rem;
            font-weight: 300;
            margin: 0;
        }
        
        .nav-test-header p {
            font-size: 1.1rem;
            margin: 0.5rem 0 0 0;
            opacity: 0.9;
        }
        
        .nav-info-section {
            background: #f8f9fa;
            border: 1px solid #e9ecef;
            border-radius: 8px;
            padding: 1.5rem;
            margin-bottom: 2rem;
        }
        
        .nav-info-section h3 {
            color: #495057;
            font-size: 1.3rem;
            margin: 0 0 1rem 0;
            display: flex;
            align-items: center;
            gap: 0.5rem;
        }
        
        .nav-data-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 1rem;
            margin-bottom: 2rem;
        }
        
        .nav-data-card {
            background: white;
            border: 1px solid #dee2e6;
            border-radius: 6px;
            padding: 1rem;
        }
        
        .nav-data-card h5 {
            color: #007bff;
            margin: 0 0 0.5rem 0;
            font-size: 1rem;
        }
        
        .nav-data-card p {
            margin: 0.3rem 0;
            font-size: 0.9rem;
            color: #6c757d;
        }
        
        .nav-url {
            background: #f8f9fa;
            padding: 0.2rem 0.5rem;
            border-radius: 3px;
            font-family: monospace;
            font-size: 0.8rem;
        }
        
        .control-section {
            background: white;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            padding: 2rem;
            margin-bottom: 2rem;
        }
        
        .debug-info {
            background: #e3f2fd;
            border: 1px solid #90caf9;
            border-radius: 6px;
            padding: 1rem;
            margin-top: 1rem;
        }
        
        .debug-info h4 {
            color: #1976d2;
            margin: 0 0 0.5rem 0;
            font-size: 1.1rem;
        }
        
        .debug-info pre {
            background: #f5f5f5;
            padding: 0.5rem;
            border-radius: 3px;
            font-size: 0.8rem;
            overflow-x: auto;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <!-- Test Header -->
    <div class="nav-test-header">
        <div class="container">
            <h1>🗺️ Navigation Data Integration Test</h1>
            <p>اختبار تكامل بيانات الـ Navigation مع الـ Real Estate Control</p>
        </div>
    </div>

    <div class="container">
        <!-- Navigation Data Information -->
        <div class="nav-info-section">
            <h3>
                <i class="fas fa-sitemap"></i>
                معلومات بيانات الـ Navigation
            </h3>
            <div class="row">
                <div class="col-md-6">
                    <h5>المصادر:</h5>
                    <ul>
                        <li><strong>SiteMap Provider:</strong> <code><asp:Literal ID="litSiteMapProvider" runat="server" /></code></li>
                        <li><strong>Root Node:</strong> <code><asp:Literal ID="litRootNode" runat="server" /></code></li>
                        <li><strong>Total Nodes:</strong> <code><asp:Literal ID="litTotalNodes" runat="server" /></code></li>
                        <li><strong>Security Enabled:</strong> <code><asp:Literal ID="litSecurityEnabled" runat="server" /></code></li>
                    </ul>
                </div>
                <div class="col-md-6">
                    <h5>الإحصائيات:</h5>
                    <ul>
                        <li><strong>Top Level Items:</strong> <code><asp:Literal ID="litTopLevelItems" runat="server" /></code></li>
                        <li><strong>Navigation Items:</strong> <code><asp:Literal ID="litNavigationItems" runat="server" /></code></li>
                        <li><strong>Properties Generated:</strong> <code><asp:Literal ID="litPropertiesGenerated" runat="server" /></code></li>
                        <li><strong>Last Updated:</strong> <code><%= DateTime.Now.ToString("HH:mm:ss") %></code></li>
                    </ul>
                </div>
            </div>
        </div>

        <!-- Navigation Data Preview -->
        <div class="nav-info-section">
            <h3>
                <i class="fas fa-list"></i>
                عينة من بيانات الـ Navigation
            </h3>
            <div class="nav-data-grid">
                <asp:Repeater ID="rptNavigationData" runat="server">
                    <ItemTemplate>
                        <div class="nav-data-card">
                            <h5><%# Eval("Title") %></h5>
                            <p><strong>URL:</strong> <span class="nav-url"><%# Eval("Url") %></span></p>
                            <p><strong>Description:</strong> <%# If(String.IsNullOrEmpty(Eval("Description").ToString()), "لا يوجد وصف", Eval("Description")) %></p>
                            <p><strong>Has Children:</strong> <%# If(CBool(Eval("HasChildren")), "نعم", "لا") %></p>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>

        <!-- Real Estate Control Test Section -->
        <div class="control-section">
            <h2 style="color: #343a40; margin-bottom: 1.5rem;">
                <i class="fas fa-building"></i>
                Real Estate Control with Navigation Data
            </h2>
            
            <!-- Real Estate Control -->
            <uc:RealEstate ID="RealEstateControl1" runat="server" />
        </div>

        <!-- Debug Information -->
        <div class="debug-info">
            <h4>
                <i class="fas fa-bug"></i>
                Debug Information
            </h4>
            <div class="row">
                <div class="col-md-6">
                    <h6>SiteMap Debug:</h6>
                    <pre><asp:Literal ID="litSiteMapDebug" runat="server" /></pre>
                </div>
                <div class="col-md-6">
                    <h6>Navigation Debug:</h6>
                    <pre><asp:Literal ID="litNavigationDebug" runat="server" /></pre>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
