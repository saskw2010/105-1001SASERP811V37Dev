<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="GljrnvchhdrT_1.aspx.vb" Inherits="Pages_GljrnvchhdrT_1"  Title="Gljrnvchhdr T" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Gljrnvchhdr T</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="GljrnvchhdrT" view="grid1" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" ShowRowNumber="True" />
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Details">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="GLjrnvchT" view="grid1" FilterSource="view1Extender" FilterFields="Tr_No" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|attachment">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schattachGljrnvchhdrTlists" view="grid1" FilterSource="view1Extender" FilterFields="Tr_No" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
    </div>
  </div>
</asp:Content>