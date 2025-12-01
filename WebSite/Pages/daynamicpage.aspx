<%@ Page Language="VB" MasterPageFile="~/MasterPage.Master" AutoEventWireup="false" CodeFile="daynamicpage.aspx.vb" Inherits="Pages_daynamicpage" %>

<asp:Content ID="Content2"  ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
     <div style="padding:8px" class="panel-body text-center">
    <div id="Div1" runat="server" />
        <aquarium:DataViewExtender ID="Extender1" runat="server" TargetControlID="Div1" PageSize="100" SelectionMode="Multiple" ShowActionButtons="Top"  ShowPager="Top" />
       <div id="div2" runat="server" />
      <aquarium:DataViewExtender id="Extender2" runat="server" TargetControlID="div2"   PageSize="100" SelectionMode="Multiple" ShowActionButtons="Top"  ShowPager="Top" />
       </div>
</ContentTemplate></asp:UpdatePanel>
</asp:Content>





