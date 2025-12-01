<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="GROUPStk.aspx.vb" Inherits="Pages_GROUPStk"  Title="GROUP Stk" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">GROUP Stk</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="GROUPStk" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowActionButtons="Top" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Items">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="ITEMS" view="grid1" FilterSource="view1Extender" FilterFields="IDGROUP" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Unit List">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="itemrels" view="grid1" ShowInSummary="True" FilterSource="view3Extender" FilterFields="ID_comp" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows group stk management.</div>
    </div>
  </div>
</asp:Content>