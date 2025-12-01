<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schapplication1002.aspx.vb" Inherits="Pages_schapplication1002"  Title="schapplication 1002" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">schapplication 1002</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Schapplication1002" view="grid1" ShowInSummary="True" PageSize="5" SelectionMode="Multiple" Tag="masterlist" ShowActionButtons="Top" SearchOnStart="True" ShowRowNumber="True" />
  </div>
</asp:Content>