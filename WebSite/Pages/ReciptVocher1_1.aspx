<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ReciptVocher1_1.aspx.vb" Inherits="Pages_ReciptVocher1_1"  Title="ReciptVocher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">ReciptVocher</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Recipt">
      <div id="dv100" runat="server"></div>
      <aquarium:DataViewExtender id="dv100Extender" runat="server" TargetControlID="dv100" Controller="schvchdlyhdreg" view="GRIDALL" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
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
  <div data-flow="NewRow">
    <div data-activator="Tab|Attachment">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schattachvchlists" view="grid1" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" />
    </div>
  </div>
</asp:Content>