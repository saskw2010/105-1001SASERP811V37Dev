<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ITEMS1.aspx.vb" Inherits="Pages_ITEMS1"  Title="Items1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Items1</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="ITEMS1" view="grid1" ShowInSummary="True" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Unit List">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="itemrels1" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="ID_comp" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" ShowRowNumber="True" />
    </div>
    <div data-activator="Tab|Itembatch">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="itembatch" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="ID_comp" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" ShowRowNumber="True" />
    </div>
    <div data-activator="Tab|Itemstorebalance">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="ItemTransQuantity" view="grid1" FilterSource="view1Extender" FilterFields="ID_comp" PageSize="30" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows items price management.</div>
    </div>
  </div>
</asp:Content>