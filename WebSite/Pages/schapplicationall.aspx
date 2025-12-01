<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schapplicationall.aspx.vb" Inherits="Pages_schapplicationall"  Title="schapplicationall" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">schapplicationall</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div class="DataViewHeader">schapplicationall</div>
    <div id="dv100" runat="server"></div>
    <aquarium:DataViewExtender id="dv100Extender" runat="server" TargetControlID="dv100" Controller="schApplication" view="grid1" ShowInSummary="True" PageSize="10" SelectionMode="Multiple" ShowRowNumber="True" />
  </div>
</asp:Content>