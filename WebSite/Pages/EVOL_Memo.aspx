<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="EVOL_Memo.aspx.vb" Inherits="Pages_EVOL_Memo"  Title="EVOL Memo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">EVOL Memo</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="EVOL_Memo" view="grid1" ShowInSummary="True" PageSize="10" RefreshInterval="30" SelectionMode="Multiple" ShowActionButtons="Top" ShowDescription="False" ShowDetailsInListMode="False" ShowRowNumber="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows evol memo management.</div>
    </div>
  </div>
</asp:Content>