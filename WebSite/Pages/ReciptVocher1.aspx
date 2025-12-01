<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ReciptVocher1.aspx.vb" Inherits="Pages_ReciptVocher1"  Title="ReciptVocher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">ReciptVocher</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Recipt">
      <div id="dv100" runat="server"></div>
      <aquarium:DataViewExtender id="dv100Extender" runat="server" TargetControlID="dv100" Controller="schvchdlyhdreg" view="grid1" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div class="DataViewHeader">Recipt Details</div>
    <div id="dv101" runat="server"></div>
    <aquarium:DataViewExtender id="dv101Extender" runat="server" TargetControlID="dv101" Controller="schvchdlydetailreg" view="grid1" ShowInSummary="True" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" ShowDescription="False" ShowViewSelector="False" AutoHide="Container" ShowPager="Top" ShowQuickFind="False" ShowRowNumber="True" ShowSearchBar="False" />
  </div>
  <div data-flow="NewRow">
    <div class="DataViewHeader">Payment Details</div>
    <div id="dv102" runat="server"></div>
    <aquarium:DataViewExtender id="dv102Extender" runat="server" TargetControlID="dv102" Controller="schvchdlydetailpayment" view="grid1" ShowInSummary="True" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Bottom" ShowDescription="False" ShowViewSelector="False" AutoHide="Container" ShowPager="Top" ShowQuickFind="False" ShowRowNumber="True" ShowSearchBar="False" />
  </div>
</asp:Content>