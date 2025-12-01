<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="GlstatmentBalanceSheet.aspx.vb" Inherits="Pages_GlstatmentBalanceSheet"  Title="Glstatment Balance Sheet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Glstatment Balance Sheet</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="_Dates" view="grid1" PageSize="1" RefreshInterval="30" ShowActionButtons="Top" SearchByFirstLetter="True" AutoHighlightFirstRow="True" ShowRowNumber="True" />
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Trail Balance">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="GlstatmentBalanceSheet" view="grid1" ShowInSummary="True" FilterSource="view2Extender" FilterFields="ModifiedBy,d1,d2" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" ShowViewSelector="False" AutoHide="Container" SearchOnStart="True" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows glstatment balance sheet management.</div>
    </div>
  </div>
</asp:Content>