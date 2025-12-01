<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="carrenttrip.aspx.vb" Inherits="Pages_carrenttrip"  Title="carrenttrip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">carrenttrip</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="CarrentTrip" view="grid1" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
  </div>
</asp:Content>