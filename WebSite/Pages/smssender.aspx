<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/Main.Master"  CodeFile ="smssender.aspx.vb" Inherits="Pages_smssender" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Account</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
    <radscriptmanager runat="server" id="RadScriptManager1" />
    <radskinmanager ID="RadSkinManager1" runat="server" ShowChooser="true" />
    <script type="text/javascript" src="scripts.js"></script>
    <asp:UpdatePanel ID="UpdatePanel1xx" runat="server">
        <ContentTemplate>
            <div style="padding:8px" class="panel-body text-center"> 
                 <br />
                <br />

            <asp:Button ID="Button1" runat="server" Text="send all sms pinding" Width="314px" />
                 <telerik:RadProgressBar ID="RadProgressBar1" runat="server">
                 </telerik:RadProgressBar>
                <br />
                <br />
            <asp:Button ID="Button2" runat="server" Text="put xml into database" Width="323px" />
            </div>
            <div style="padding:8px" class="panel-body text-center">
            <asp:GridView ID="GridViewXmlData" runat="server">
            </asp:GridView>
             </div>
<div class="demo-container no-bg">
        <div class="tvWrapper">
            <asp:Panel ID="tvScreen" runat="server" CssClass="tvContent">
            
            </asp:Panel>
        </div>
    </div>

 </ContentTemplate></asp:UpdatePanel>
   
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  
</asp:Content>