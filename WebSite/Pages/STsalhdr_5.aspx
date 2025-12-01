<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="STsalhdr_5.aspx.vb" Inherits="Pages_STsalhdr_5"  Title="S Tsalhdr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">S Tsalhdr</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="STsalhdr5" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Stsaldtl5">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Stsaldtl5" view="griddetailes" ShowInSummary="True" FilterSource="view1Extender" FilterFields="Doc_No" PageSize="21" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows s tsalhdr management.</div>
    </div>
  </div>
</asp:Content>