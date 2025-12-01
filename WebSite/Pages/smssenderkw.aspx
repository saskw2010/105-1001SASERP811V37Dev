<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/Main.Master"  CodeFile ="smssenderkw.aspx.vb" Inherits="Pages_smssenderkw" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Account</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div style="padding:8px" class="panel-body text-center"> 
                 <br />
                <br />

            <asp:Button ID="Button1" runat="server" Text="send all sms pinding" Width="314px" />
                <br />
                <br />
            <asp:Button ID="Button2" runat="server" Text="put xml into database" Width="323px" />
            </div>
            <div style="padding:8px" class="panel-body text-center">
            <asp:GridView ID="GridViewXmlData" runat="server">
            </asp:GridView>
             </div>


 </ContentTemplate></asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  
</asp:Content>