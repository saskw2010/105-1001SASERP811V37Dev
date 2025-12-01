<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="electionleganhakelplan.aspx.vb" Inherits="Pages_electionleganhakelplan"  Title="Electionleganhakelplan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Electionleganhakelplan</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="electionleganhakelplan" view="grid1" ShowInSummary="True" PageSize="50" RefreshInterval="50" SelectionMode="Multiple" ShowActionBar="False" ShowActionButtons="Top" ShowViewSelector="False" ShowPager="Top" ShowQuickFind="False" ShowRowNumber="True" ShowSearchBar="False" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows electionleganhakelplan management.</div>
    </div>
  </div>
</asp:Content>