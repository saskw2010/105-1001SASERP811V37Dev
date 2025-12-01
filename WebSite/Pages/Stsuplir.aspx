<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Stsuplir.aspx.vb" Inherits="Pages_Stsuplir"  Title="Stsuplir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Stsuplir</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Stsuplir">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Stsuplir" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="puritemrels" view="grid1" FilterSource="view1Extender" FilterFields="Sup_No" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows stsuplir management.</div>
    </div>
  </div>
</asp:Content>