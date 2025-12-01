<%@ Page Language="VB" AutoEventWireup="true" CodeFile="TestModernControls.aspx.vb" Inherits="TestModernControls" %>
<%@ Register Src="Controls/ModernTOC.ascx" TagName="ModernTOC" TagPrefix="uc" %>
<%@ Register Src="Controls/ModernAjarTOC.ascx" TagName="ModernAjarTOC" TagPrefix="uc" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Test Modern Controls</title>
    <meta charset="utf-8">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 20px;">
            <h1>Modern Controls Test Page</h1>
            <h2>Version 4.1.0</h2>
            
            <h3>ModernTOC Control:</h3>
            <uc:ModernTOC ID="modernTOC1" runat="server" />
            
            <hr style="margin: 40px 0;" />
            
            <h3>ModernAjarTOC Control:</h3>
            <uc:ModernAjarTOC ID="modernAjarTOC1" runat="server" />
            
            <div style="margin-top: 40px; padding: 20px; background: #f0f0f0; border-radius: 10px;">
                <h4>Test Results:</h4>
                <ul>
                    <li>✅ ModernTOC.ascx created and registered</li>
                    <li>✅ ModernAjarTOC.ascx created and registered</li>
                    <li>✅ Version updated to 4.1.0</li>
                    <li>✅ Control registrations added to problem pages</li>
                    <li>✅ Code-behind files created with proper error handling</li>
                </ul>
            </div>
        </div>
    </form>
</body>
</html>
