<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ardmast.aspx.vb" Inherits="Pages_ardmast"  Title="Ardmast" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Ardmast</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="ardmast" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowActionButtons="Top" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
  </div>
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="arddital" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="countrdus" SelectionMode="Multiple" ShowActionButtons="Top" ShowDetailsInListMode="False" ShowPager="Top" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows ardmast management.</div>
    </div>
  </div>
</asp:Content>