<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ReciptVocher1_3.aspx.vb" Inherits="Pages_ReciptVocher1_3"  Title="ReciptVocher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">ReciptVocher</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Recipt">
      <div id="dv100" runat="server"></div>
      <aquarium:DataViewExtender id="dv100Extender" runat="server" TargetControlID="dv100" Controller="schvchdlyhdreg1" view="GRIDALL" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div class="DataViewHeader">Recipt Details</div>
    <div id="dv101" runat="server"></div>
    <aquarium:DataViewExtender id="dv101Extender" runat="server" TargetControlID="dv101" Controller="schvchdlydetailreg1" view="grid1" ShowInSummary="True" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" ShowDescription="False" ShowViewSelector="False" AutoHide="Container" ShowDetailsInListMode="False" ShowPager="Top" ShowQuickFind="False" ShowRowNumber="True" ShowSearchBar="False" />
  </div>
  <div data-flow="NewRow">
    <div class="DataViewHeader">Payment Details</div>
    <div id="dv102" runat="server"></div>
    <aquarium:DataViewExtender id="dv102Extender" runat="server" TargetControlID="dv102" Controller="schvchdlydetailpayment1" view="grid1" ShowInSummary="True" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Bottom" ShowDescription="False" ShowViewSelector="False" AutoHide="Container" ShowDetailsInListMode="False" ShowPager="Top" ShowQuickFind="False" ShowRowNumber="True" ShowSearchBar="False" />
  </div>
</asp:Content>