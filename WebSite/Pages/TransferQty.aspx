<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="TransferQty.aspx.vb" Inherits="Pages_TransferQty"  Title="Transfer Qty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Transfer Qty</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="azonhdrtrnsfer1" view="grid1" SelectionMode="Multiple" ShowActionButtons="Top" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
  </div>
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="azondtltrnsfer1" view="grid1" FilterSource="view1Extender" FilterFields="countrdus" PageSize="25" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>