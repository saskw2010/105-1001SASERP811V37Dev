<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ELectionGadwal.aspx.vb" Inherits="Pages_ELectionGadwal"  Title="E Lection Gadwal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">E Lection Gadwal</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="ELectionGadwal" view="grid1" ShowInSummary="True" PageSize="25" RefreshInterval="30" SelectionMode="Multiple" ShowActionBar="False" ShowActionButtons="Top" ShowViewSelector="False" ShowPager="Top" ShowQuickFind="False" ShowRowNumber="True" ShowSearchBar="False" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows e lection gadwal management.</div>
    </div>
  </div>
</asp:Content>