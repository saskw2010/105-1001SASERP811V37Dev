<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="adjustment.aspx.vb" Inherits="Pages_adjustment"  Title="adjustment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">adjustment</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="azonhdrtrnsfer4" view="grid1" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
  </div>
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="azondtltrnsfer4" view="grid1" FilterSource="view1Extender" FilterFields="countrdus" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowDetailsInListMode="False" ShowPager="Top" />
  </div>
</asp:Content>