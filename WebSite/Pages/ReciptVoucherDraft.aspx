<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ReciptVoucherDraft.aspx.vb" Inherits="Pages_ReciptVoucherDraft"  Title="Recipt Voucher Draft" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Recipt Voucher Draft</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow" style=" background-color: #FF5353;
    border-bottom-color: #993300;
    border-bottom-width: thin;
    border-bottom-style: solid;">
    <div data-activator="Tab|Recipt Drafted Or Have error">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schvchdlyhdreg" view="grid2" PageSize="3" SelectionMode="Multiple" Tag="dangerReport" ShowActionBar="False" ShowActionButtons="None" ShowDescription="False" ShowViewSelector="False" ShowPager="Top" ShowRowNumber="True" VisibleWhen="approved='False'" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div class="DataViewHeader">Recipt Drafted Details</div>
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schvchdlydetailreg" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="schvchdlyhdregid" PageSize="10" SelectionMode="Multiple" ShowActionBar="False" ShowActionButtons="None" ShowDescription="False" ShowViewSelector="False" AutoHide="Container" />
  </div>
  <div data-flow="NewRow">
    <div class="DataViewHeader">Recipt Drafted payment Details</div>
    <div id="view3" runat="server"></div>
    <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schvchdlydetailpayment" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="schvchdlyhdregid" PageSize="10" SelectionMode="Multiple" ShowActionBar="False" ShowActionButtons="None" ShowDescription="False" ShowViewSelector="False" AutoHide="Container" />
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Balance">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="GLschassmentBalance" view="grid1" FilterSource="view3Extender" FilterFields="branch,StudentCode,acdcode,schpaymenttypeid" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
    </div>
    <div data-activator="Tab|TotalBalance">
      <div id="view5" runat="server"></div>
      <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="GLschassmentBalanceT" view="grid1" FilterSource="view3Extender" FilterFields="branch,StudentCode,acdcode" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
    </div>
  </div>
</asp:Content>