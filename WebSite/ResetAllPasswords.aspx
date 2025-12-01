<%@ Page Language="VB" AutoEventWireup="true" CodeFile="ResetAllPasswords.aspx.vb" Inherits="SKY365.ResetAllPasswords" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Reset All Passwords - Admin Only</title>
    <style>
        body { font-family: Arial, sans-serif; padding: 20px; background: #f5f5f5; }
        .container { max-width: 800px; margin: 0 auto; background: white; padding: 20px; border-radius: 8px; box-shadow: 0 2px 8px rgba(0,0,0,0.1); }
        .login-box { background: #e3f2fd; border: 2px solid #2196f3; padding: 20px; border-radius: 8px; margin-bottom: 20px; }
        .warning { background: #fff3cd; border: 1px solid #ffc107; padding: 15px; border-radius: 4px; margin-bottom: 20px; }
        .btn { padding: 10px 20px; background: #dc3545; color: white; border: none; border-radius: 4px; cursor: pointer; font-size: 16px; }
        .btn:hover { background: #c82333; }
        .btn-login { background: #2196f3; }
        .btn-login:hover { background: #1976d2; }
        .form-group { margin-bottom: 15px; }
        .form-control { width: 100%; padding: 8px; border: 1px solid #ddd; border-radius: 4px; font-size: 14px; }
        .results { background: #f8f9fa; padding: 15px; border-radius: 4px; margin-top: 20px; font-family: monospace; white-space: pre-wrap; }
        .error { background: #f8d7da; border: 1px solid #f5c6cb; padding: 10px; border-radius: 4px; color: #721c24; margin-bottom: 15px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>🔧 Reset All User Passwords</h1>
            
            <!-- Login Section -->
            <asp:Panel ID="pnlLogin" runat="server">
                <div class="login-box">
                    <h3>🔐 تسجيل الدخول للمتابعة</h3>
                    <p><strong>Username:</strong> administrator</p>
                    <p><strong>Password:</strong> YYYY-MM-DD@123 (مثال: 2025-10-02@123)</p>
                    
                    <asp:Label ID="lblLoginError" runat="server" CssClass="error" Visible="false"></asp:Label>
                    
                    <div class="form-group">
                        <label>اسم المستخدم:</label>
                        <asp:TextBox ID="txtAdminUser" runat="server" CssClass="form-control" placeholder="administrator"></asp:TextBox>
                    </div>
                    
                    <div class="form-group">
                        <label>كلمة المرور:</label>
                        <asp:TextBox ID="txtAdminPass" runat="server" TextMode="Password" CssClass="form-control" placeholder="YYYY-MM-DD@123"></asp:TextBox>
                    </div>
                    
                    <asp:Button ID="btnAdminLogin" runat="server" Text="تسجيل الدخول" CssClass="btn btn-login" OnClick="btnAdminLogin_Click" />
                </div>
            </asp:Panel>
            
            <!-- Reset Section (Hidden until logged in) -->
            <asp:Panel ID="pnlReset" runat="server" Visible="false">
                <div class="warning">
                    <strong>⚠️ تحذير:</strong> هذه الصفحة ستعيد تعيين كلمات المرور لجميع المستخدمين!<br/>
                    استخدمها فقط بعد تغيير passwordFormat من Encrypted إلى Hashed.<br/><br/>
                    <strong>🔑 كلمة المرور الجديدة الموحدة:</strong> <code style="background:#fff;padding:4px 8px;border-radius:4px;font-size:16px;color:#dc3545;font-weight:bold;">NewPass@123</code>
                </div>
                
                <asp:Button ID="btnReset" runat="server" Text="تغيير كلمات المرور لجميع المستخدمين إلى: NewPass@123" 
                    CssClass="btn" OnClick="btnReset_Click" 
                    OnClientClick="return confirm('هل أنت متأكد من تغيير كلمات المرور لجميع المستخدمين إلى: NewPass@123 ؟');" />
                
                <asp:Panel ID="pnlResults" runat="server" CssClass="results" Visible="false">
                    <asp:Literal ID="litResults" runat="server"></asp:Literal>
                </asp:Panel>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
