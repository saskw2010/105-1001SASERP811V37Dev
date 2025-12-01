<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="BalanceSheet.aspx.vb" Inherits="Pages_BalanceSheet"  Title="Balance Sheet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Balance Sheet</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="QGLBalancsheetReport" view="grid1" ShowInSummary="True" SelectionMode="Multiple" />
  </div>
</asp:Content>