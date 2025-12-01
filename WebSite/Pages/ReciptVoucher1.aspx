<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ReciptVoucher1.aspx.vb" Inherits="Pages_ReciptVoucher1"  Title="Recipt Voucher 1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Recipt Voucher 1</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Recipt">
      <div id="dv100" runat="server"></div>
      <aquarium:DataViewExtender id="dv100Extender" runat="server" TargetControlID="dv100" Controller="schvchdlyhdreg" view="grid1" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Bottom" ShowViewSelector="False" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Recipt Details">
      <div id="dv101" runat="server"></div>
      <aquarium:DataViewExtender id="dv101Extender" runat="server" TargetControlID="dv101" Controller="schvchdlydetailreg" view="gridnew" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="6" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" ShowQuickFind="False" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Payment Details">
      <div id="dv102" runat="server"></div>
      <aquarium:DataViewExtender id="dv102Extender" runat="server" TargetControlID="dv102" Controller="schvchdlydetailpayment" view="grid1" ShowInSummary="True" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="10" SelectionMode="Multiple" ShowActionButtons="None" ShowViewSelector="False" AutoHide="Container" ShowPager="Top" ShowQuickFind="False" ShowSearchBar="False" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Attachment">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schattachvchlists" view="grid1" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" />
    </div>
  </div>
</asp:Content>