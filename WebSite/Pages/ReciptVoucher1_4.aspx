<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ReciptVoucher1_4.aspx.vb" Inherits="Pages_ReciptVoucher1_4"  Title="Recipt Voucher 1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Recipt Voucher 1</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Recipt">
      <div id="dv100" runat="server"></div>
      <aquarium:DataViewExtender id="dv100Extender" runat="server" TargetControlID="dv100" Controller="schvchdlyhdreg" view="grid1" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Bottom" ShowViewSelector="False" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div id="dv101" runat="server"></div>
    <aquarium:DataViewExtender id="dv101Extender" runat="server" TargetControlID="dv101" Controller="schvchdlydetailreg1001" view="gridnew" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="6" SelectionMode="Multiple" ShowActionButtons="Top" ShowDescription="False" ShowViewSelector="False" AutoHide="Container" ShowDetailsInListMode="False" ShowPageSize="False" ShowQuickFind="False" ShowRowNumber="True" ShowSearchBar="False" />
  </div>
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="SchStudentPay" view="grid1" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="8" SelectionMode="Multiple" ShowActionButtons="Top" ShowDescription="False" ShowViewSelector="False" ShowDetailsInListMode="False" ShowPageSize="False" ShowQuickFind="False" ShowRowNumber="True" ShowSearchBar="False" />
  </div>
</asp:Content>