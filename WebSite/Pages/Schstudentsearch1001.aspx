<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Schstudentsearch1001.aspx.vb" Inherits="Pages_Schstudentsearch1001"  Title="Schstudentsearch1001" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Schstudentsearch1001</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Schstudentsearch1001" view="grid1" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowDetailsInListMode="False" ShowPager="Top" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows schstudentsearch1001 management.</div>
    </div>
  </div>
</asp:Content>