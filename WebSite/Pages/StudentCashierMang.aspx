<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="StudentCashierMang.aspx.vb" Inherits="Pages_StudentCashierMang"  Title="Student Cashier Mang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Student Cashier Mang</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view3" runat="server"></div>
    <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schvchdlyhdreg4" view="grid1" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" ShowRowNumber="True" />
  </div>
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schApplication4" view="grid1" PageSize="21" RefreshInterval="90" SelectionMode="Multiple" ShowActionButtons="Top" ShowViewSelector="False" ShowPager="Top" ShowRowNumber="True" />
  </div>
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Regbussstudent1" view="grid1" PageSize="21" RefreshInterval="90" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>