<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Stpurhdr_5.aspx.vb" Inherits="Pages_Stpurhdr_5"  Title="Stpurhdr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Stpurhdr</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Stpurhdr5" view="grid1" ShowInSummary="True" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
  </div>
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Stpurdtl5" view="gridDetails" FilterSource="view1Extender" FilterFields="Doc_No" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows stsaldtl management.</div>
    </div>
  </div>
</asp:Content>