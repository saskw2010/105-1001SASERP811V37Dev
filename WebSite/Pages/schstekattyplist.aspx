<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schstekattyplist.aspx.vb" Inherits="Pages_schstekattyplist"  Title="Schstekattyplist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Schstekattyplist</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Schstekattyplist">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schstekattyplist" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
    </div>
  </div>
  <div data-flow="NewRow" style="padding-top:8px;">
    <div data-activator="SideBarTask|Schstekat">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schstekat" view="grid1" FilterSource="view1Extender" FilterFields="schstekattypid" PageSize="5" SelectionMode="Multiple" AutoHide="Container" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows schstekattyplist management.</div>
    </div>
  </div>
</asp:Content>