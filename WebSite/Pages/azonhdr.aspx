<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="azonhdr.aspx.vb" Inherits="Pages_azonhdr"  Title="Azonhdr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Azonhdr</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="azonhdr" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowDetailsInListMode="False" />
  </div>
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="azondtl" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="countrdus" SelectionMode="Multiple" ShowDetailsInListMode="False" ShowRowNumber="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows azonhdr management.</div>
    </div>
  </div>
</asp:Content>