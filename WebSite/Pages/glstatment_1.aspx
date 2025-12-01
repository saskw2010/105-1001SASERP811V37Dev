<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="glstatment_1.aspx.vb" Inherits="Pages_glstatment_1"  Title="Glstatment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Glstatment</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="AccnoDates1" view="grid1" ShowInSummary="True" SelectionMode="Multiple" />
  </div>
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="glstatment1" view="grid1" ShowInSummary="True" FilterSource="view2Extender" FilterFields="autoid" PageSize="21" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows glstatment management.</div>
    </div>
  </div>
</asp:Content>