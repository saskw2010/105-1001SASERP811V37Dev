<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="CarrentTripdaily.aspx.vb" Inherits="Pages_CarrentTripdaily"  Title="Carrent Tripdaily" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Carrent Tripdaily</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="CarrentTripdaily" view="grid1" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" ShowDetailsInListMode="False" ShowPager="Top" />
  </div>
</asp:Content>