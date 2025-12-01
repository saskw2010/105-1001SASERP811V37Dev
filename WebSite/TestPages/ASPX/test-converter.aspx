<%@ Page Language="VB" AutoEventWireup="true" CodeFile="test-converter.aspx.vb" Inherits="test_converter" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Test Dynamic Control Converter</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" rel="stylesheet">
    <style>
        body { 
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; 
            margin: 0; 
            padding: 2rem;
            background: linear-gradient(135deg, #f8fafc 0%, #e2e8f0 100%);
        }
        .test-container {
            max-width: 1200px;
            margin: 0 auto;
            background: white;
            border-radius: 16px;
            padding: 2rem;
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
        }
        .test-header {
            text-align: center;
            margin-bottom: 2rem;
            padding-bottom: 1rem;
            border-bottom: 2px solid #e2e8f0;
        }
        .test-header h1 {
            color: #2563eb;
            margin-bottom: 0.5rem;
        }
        .test-section {
            margin: 2rem 0;
            padding: 1.5rem;
            border: 1px solid #e2e8f0;
            border-radius: 12px;
            background: #f8fafc;
        }
        .test-title {
            color: #1e293b;
            margin-bottom: 1rem;
            display: flex;
            align-items: center;
            gap: 0.5rem;
        }
        .status-success { color: #059669; }
        .status-error { color: #dc2626; }
        .status-warning { color: #d97706; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="test-container">
            <div class="test-header">
                <h1><i class="fas fa-flask"></i> Dynamic Control Converter Test</h1>
                <p>Testing the conversion of TableOfContents controls from Telerik to modern design</p>
            </div>

            <!-- Compilation Test -->
            <div class="test-section">
                <h2 class="test-title">
                    <i class="fas fa-code"></i>
                    <span>Compilation Test</span>
                </h2>
                <asp:Literal ID="litCompilationTest" runat="server"></asp:Literal>
            </div>

            <!-- Converter Test -->
            <div class="test-section">
                <h2 class="test-title">
                    <i class="fas fa-magic"></i>
                    <span>Dynamic Converter Test</span>
                </h2>
                <asp:Literal ID="litConverterTest" runat="server"></asp:Literal>
            </div>

            <!-- SiteMap Test -->
            <div class="test-section">
                <h2 class="test-title">
                    <i class="fas fa-sitemap"></i>
                    <span>SiteMap Data Test</span>
                </h2>
                <asp:Literal ID="litSiteMapTest" runat="server"></asp:Literal>
            </div>

            <!-- Modern Output -->
            <div class="test-section">
                <h2 class="test-title">
                    <i class="fas fa-rocket"></i>
                    <span>Modern TableOfContents Output</span>
                </h2>
                <asp:Literal ID="litModernOutput" runat="server"></asp:Literal>
            </div>

        </div>
    </form>
</body>
</html>
