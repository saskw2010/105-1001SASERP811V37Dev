<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="StLcHdr.aspx.vb" Inherits="Pages_StLcHdr"  Title="St Lc Hdr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">St Lc Hdr</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="StLcHdr" view="grid1" ShowInSummary="True" SelectionMode="Multiple" />
  </div>
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="StLcDtl" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="Doc_No" SelectionMode="Multiple" AutoHide="Self" />
    <div id="view3" runat="server"></div>
    <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="GLjrnvchslpr" view="grid1" FilterSource="view1Extender" FilterFields="Tr_No" PageSize="21" SelectionMode="Multiple" AutoHide="Self" ShowPager="TopAndBottom" ShowRowNumber="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows st lc hdr management.</div>
    </div>
  </div>
</asp:Content>