<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="GLjrnvchhdrdly.aspx.vb" Inherits="Pages_GLjrnvchhdrdly"  Title="GLjrnvchhdrdly" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">GLjrnvchhdrdly</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Gljrnvchhdr" view="grid1" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowDetailsInListMode="False" ShowPager="Top" />
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Detailes">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="GLjrnvch" view="grid2" FilterSource="view1Extender" FilterFields="Tr_No" PageSize="100" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" ShowQuickFind="False" ShowRowNumber="True" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Attachment">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schattachGljrnvchhdrlists" view="grid1" FilterSource="view1Extender" FilterFields="Tr_No" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" />
    </div>
  </div>
</asp:Content>