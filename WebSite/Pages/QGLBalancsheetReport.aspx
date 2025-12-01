<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="QGLBalancsheetReport.aspx.vb" Inherits="Pages_QGLBalancsheetReport"  Title="QGL Balancsheet Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">QGL Balancsheet Report</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="_Dates2" view="grid1" PageSize="1" RefreshInterval="30" SelectionMode="Multiple" ShowActionButtons="Top" SearchByFirstLetter="True" AutoHighlightFirstRow="True" ShowRowNumber="True" />
  </div>
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="QGLBalancsheetReport" view="grid1" ShowInSummary="True" FilterSource="view2Extender" FilterFields="ModifiedBy,d1,d2" SelectionMode="Multiple" AutoHide="Container" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows qgl balancsheet report management.</div>
    </div>
  </div>
</asp:Content>