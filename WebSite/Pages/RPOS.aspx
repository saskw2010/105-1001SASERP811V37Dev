<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="RPOS.aspx.vb" Inherits="Pages_RPOS"  Title="RPOS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">RPOS</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="STsalhdr1001" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowActionButtons="Top" StartCommandName="New" StartCommandArgument="createForm1" SearchOnStart="True" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
  </div>
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Stsaldtl" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="Doc_No" PageSize="21" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" />
  </div>
</asp:Content>