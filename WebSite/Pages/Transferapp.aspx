<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Transferapp.aspx.vb" Inherits="Pages_Transferapp"  Title="Transferapp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Transferapp</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="azonhdrtrnsfer2" view="grid2" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" ShowDetailsInListMode="False" ShowPager="Top" />
  </div>
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="azondtltrnsfer2" view="grid1" FilterSource="view1Extender" FilterFields="countrdus" PageSize="25" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>