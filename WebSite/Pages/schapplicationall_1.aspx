<%@ Page Language="VB" MasterPageFile="~/MyOwnRegistration.Master" AutoEventWireup="false" CodeFile="schapplicationall_1.aspx.vb" Inherits="Pages_schapplicationall_1"  Title="schapplicationall" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">schapplicationall</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div class="DataViewHeader">schapplicationall</div>
    <div id="dv100" runat="server"></div>
    <aquarium:DataViewExtender id="dv100Extender" runat="server" TargetControlID="dv100" Controller="schApplication3" view="grid1" ShowInSummary="True" PageSize="10" SelectionMode="Multiple" ShowActionBar="False" ShowActionButtons="Top" ShowDescription="False" ShowViewSelector="False" StartCommandName="New" StartCommandArgument="createForm1" ShowDetailsInListMode="False" ShowPager="None" ShowPageSize="False" ShowQuickFind="False" ShowSearchBar="False" />
  </div>
</asp:Content>