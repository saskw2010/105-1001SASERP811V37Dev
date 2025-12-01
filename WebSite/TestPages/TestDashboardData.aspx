<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TestDashboardData.aspx.vb" Inherits="TestPages_TestDashboardData" %>
<%@ Import Namespace="DashboardModels" %>

<!DOCTYPE html>
<html lang="ar" dir="rtl">
<head runat="server">
    <meta charset="utf-8" />
    <title>اختبار البيانات الافتراضية للداش بورد</title>
    <style>
        body { font-family: Arial, sans-serif; padding: 20px; background-color: #f5f5f5; }
        .test-container { background: white; padding: 20px; border-radius: 8px; box-shadow: 0 2px 10px rgba(0,0,0,0.1); margin-bottom: 20px; }
        .test-title { color: #2c3e50; border-bottom: 2px solid #3498db; padding-bottom: 10px; margin-bottom: 20px; }
        .data-item { padding: 8px; margin: 5px 0; background-color: #ecf0f1; border-radius: 4px; }
        .data-label { font-weight: bold; color: #34495e; }
        .data-value { color: #27ae60; }
        .error { color: #e74c3c; background-color: #fadbd8; padding: 10px; border-radius: 4px; }
        .success { color: #27ae60; background-color: #d5f4e6; padding: 10px; border-radius: 4px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>🔍 اختبار البيانات الافتراضية للداش بورد</h1>
        
        <!-- Financial Dashboard Test -->
        <div class="test-container">
            <h2 class="test-title">💰 اختبار البيانات المالية</h2>
            <asp:PlaceHolder ID="phFinancialTest" runat="server"></asp:PlaceHolder>
        </div>
        
        <!-- HR Dashboard Test -->
        <div class="test-container">
            <h2 class="test-title">👥 اختبار بيانات الموارد البشرية</h2>
            <asp:PlaceHolder ID="phHRTest" runat="server"></asp:PlaceHolder>
        </div>
        
        <!-- Operations Dashboard Test -->
        <div class="test-container">
            <h2 class="test-title">⚙️ اختبار بيانات العمليات</h2>
            <asp:PlaceHolder ID="phOperationsTest" runat="server"></asp:PlaceHolder>
        </div>
        
        <!-- Reports Dashboard Test -->
        <div class="test-container">
            <h2 class="test-title">📊 اختبار بيانات التقارير</h2>
            <asp:PlaceHolder ID="phReportsTest" runat="server"></asp:PlaceHolder>
        </div>
        
        <div style="text-align: center; margin-top: 30px;">
            <asp:Button ID="btnRefreshTest" runat="server" Text="🔄 إعادة اختبار البيانات" 
                CssClass="btn btn-primary" style="padding: 10px 20px; background: #3498db; color: white; border: none; border-radius: 4px; cursor: pointer;" />
        </div>
        
    </form>
</body>
</html>
