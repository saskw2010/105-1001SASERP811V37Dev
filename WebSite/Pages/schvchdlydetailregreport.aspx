<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schvchdlydetailregreport.aspx.vb" Inherits="Pages_schvchdlydetailregreport"  Title="Schvchdlydetailregreport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Schvchdlydetailregreport</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schvchdlydetailregreport" view="grid1" ShowInSummary="True" PageSize="5" SelectionMode="Multiple" Tag="Reports" ShowActionButtons="Top" SearchOnStart="True" ShowPager="Top" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows schvchdlydetailregreport management.</div>
    </div>
  </div>
</asp:Content>