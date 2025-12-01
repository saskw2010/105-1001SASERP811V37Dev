<%@ Control Language="C#" AutoEventWireup="true" CodeFile="login-1002.ascx.cs" Inherits="controls_login_with_captcha" %>
<%@ Register TagPrefix="cc1" Namespace="WebControlCaptcha" Assembly="WebControlCaptcha" %>

<%-- LOGIN USER CONTROL WITH CAPTCHA-- liWrap --%>
<div>
<table>
<tr>
<td  valign="top">
    <a name="login" id="login" style="display: block; height: 0px; width: 0px; border: 0px;"></a>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ValidationGroup="Login1" EnableClientScript="False" />
    <%-- success label --%>
    <div class="LiMessage">
        <asp:HyperLink ID="lblFailureText" runat="server" Width="220px" Visible="false" EnableViewState="false"></asp:HyperLink>
    </div>
    
    <asp:Literal ID="Msg" runat="server" Visible="false"></asp:Literal>
    <asp:LoginView ID="loginBox" runat="server">
        <LoggedInTemplate>
        </LoggedInTemplate>
        <AnonymousTemplate>
            <div class="loginIcon">
               
            </div>
            <asp:Login ID="Login1" runat="server"
                 OnAuthenticate="Login1_Authenticate" 
                OnLoginError="Login1_LoginError" VisibleWhenLoggedIn="False" OnLoggingIn="Login1_LoggingIn"
               TitleText="" Style="border-collapse: separate;"
                CreateUserText="Sign Up Now" CreateUserUrl="javascript:Web.Membership._instance.signUp();"
                 PasswordRecoveryText="Forgot Your Password?" PasswordRecoveryUrl="javascript:Web.Membership._instance.passwordRecovery();">
                <LayoutTemplate>
                    <asp:Panel ID="pnlLogin" runat="server" DefaultButton="LoginButton">
                        <div class="clearBoth2">
                        </div>
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:*</asp:Label>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1" Display="Dynamic" EnableClientScript="False">*</asp:RequiredFieldValidator>
                        <asp:TextBox ID="UserName" runat="server" TabIndex="1" 
                            ToolTip="enter your user name" MaxLength="50" Width="150px"></asp:TextBox>
                        <div class="clearBoth2">
                        </div>
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password"> Password : *</asp:Label>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1" Display="Dynamic" EnableClientScript="False">*</asp:RequiredFieldValidator>
                        <asp:TextBox ID="Password" runat="server" TabIndex="2" TextMode="Password" ToolTip="enter your password" MaxLength="50" Width="150px"></asp:TextBox>
                        <div class="clearBoth2">
                        </div>
                        <div class="hr">
                            <b>SECURITY CODE</b>
                        </div>
                        <div title="enter the code shown on the image.">
                            <cc1:CaptchaControl ID="CAPTCHA" runat="server" LayoutStyle="Vertical" 
                                ShowSubmitButton="False" TabIndex="3" CaptchaFontWarping="Medium" 
                                CssClass="captcha" ToolTip="enter the code shown above" Width="220px" />
                        </div>
                        <div class="clearBoth2">
                        </div>
                        <asp:Button ID="LoginButton" runat="server" CommandName="Login" TabIndex="4" 
                            Text="Log In" ValidationGroup="Login1" Width="150px" />
                        
                        <div class="clearBoth2">
                        </div>
                        <asp:CheckBox ID="RememberMe" runat="server" TabIndex="5" Text="Remember me next time." Visible="False" />
                        <br />
                    </asp:Panel>
                </LayoutTemplate>
            </asp:Login>
        </AnonymousTemplate>
    </asp:LoginView>
    <asp:LoginView ID="userStatus" runat="server">
        <LoggedInTemplate>
            <div class="logoutIcon">
            </div>
            <div style="font-size: 20px;">
                
                <asp:LoginName ID="LoginName1" runat="server" />
            </div>
            You are currently logged in.
           
            <asp:LoginStatus ID="LoginStatus1" runat="server" />
        </LoggedInTemplate>
    </asp:LoginView>
    
    <img alt=""     src="images7.jpg" />
 
    </td>
<td>
 <asp:Label ID="Label1" runat="server" Width="10px" Text="" />
 </td>
 <td valign="top">
 <div >
 
 <img alt=""     src="startimage.png"/>
   
    </div>
 </td>
    </tr>
  </table>
</div>
