<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ALLMessage.aspx.vb" Inherits="Pages_ALLMessage"  Title="ALLMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">ALLMessage</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|ALL MESSAGES">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="EVOL_Memo" view="Totalmessages" ShowInSummary="True" PageSize="10" RefreshInterval="30" SelectionMode="Multiple" ShowActionButtons="Top" ShowViewSelector="False" ShowPager="Top" ShowRowNumber="True" />
    </div>
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="EVOLMemo" view="grid1" FilterSource="view1Extender" FilterFields="ID" PageSize="10" RefreshInterval="30" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>