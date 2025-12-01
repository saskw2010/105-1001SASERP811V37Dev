<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="glacncshr.aspx.vb" Inherits="Pages_glacncshr"  Title="glacncshr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">glacncshr</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="GLacnchr" view="grid1" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
  </div>
</asp:Content>