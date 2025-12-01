<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ReciveDepositReview.aspx.vb" Inherits="Pages_ReciveDepositReview"  Title="Recive Deposit Review" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Recive Deposit Review</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|Review Cashier">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schvchdlydetailpayment" view="Review" ShowInSummary="True" PageSize="30" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowPager="Top" />
    </div>
  </div>
</asp:Content>