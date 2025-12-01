<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="POSINVOICE3_1.aspx.vb" Inherits="Pages_POSINVOICE3_1"  Title="POS INVOICE" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">POS INVOICE</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="STsalhdr4" view="grid1" ShowInSummary="True" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
  </div>
  <div data-flow="NewRow" data-width="100%">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Stsaldtl4" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="Doc_No,Brn_No" PageSize="21" SelectionMode="Multiple" ShowActionButtons="Top" ShowViewSelector="False" AutoHide="Container" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>