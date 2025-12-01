<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="GLjrnvchhdr_2.aspx.vb" Inherits="Pages_GLjrnvchhdr_2"  Title="GLjrnvchhdr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">GLjrnvchhdr</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Gljrnvchhdr2" view="grid1" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowDetailsInListMode="False" ShowPager="Top" />
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Detailes">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="GLjrnvch1" view="grid2" FilterSource="view1Extender" FilterFields="Tr_No,branch,acdcode" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" ShowQuickFind="False" ShowRowNumber="True" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Attachment">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schattachGljrnvchhdrlists" view="grid1" FilterSource="view1Extender" FilterFields="Tr_No" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" />
    </div>
  </div>
</asp:Content>