<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ItemTransQuantity_1.aspx.vb" Inherits="Pages_ItemTransQuantity_1"  Title="Item Trans Quantity" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Item Trans Quantity</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="ItemTransQuantity" view="grid2" ShowInSummary="True" PageSize="21" SelectionMode="Multiple" ShowActionButtons="Top" ShowViewSelector="False" SearchOnStart="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows item trans quantity management.</div>
    </div>
  </div>
</asp:Content>