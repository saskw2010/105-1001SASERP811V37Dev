<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ReciptVoucher1_5.aspx.vb" Inherits="Pages_ReciptVoucher1_5"  Title="Recipt Voucher 1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Recipt Voucher 1</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Recipt">
      <div id="dv100" runat="server"></div>
      <aquarium:DataViewExtender id="dv100Extender" runat="server" TargetControlID="dv100" Controller="schvchdlyhdreg1001" view="grid1" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Bottom" ShowViewSelector="False" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div id="dv101" runat="server"></div>
    <aquarium:DataViewExtender id="dv101Extender" runat="server" TargetControlID="dv101" Controller="schvchdlydetailreg1001" view="gridnew" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="6" SelectionMode="Multiple" ShowActionButtons="Top" ShowDescription="False" ShowViewSelector="False" AutoHide="Container" ShowPager="Top" ShowQuickFind="False" />
  </div>
</asp:Content>