<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Stcurncy.aspx.vb" Inherits="Pages_Stcurncy"  Title="Stcurncy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Stcurncy</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Stcurncy">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Stcurncy" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
    </div>
    <div data-activator="SideBarTask|Stcustmr">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Stcustmr" view="grid1" FilterSource="view1Extender" FilterFields="curncy_no" SelectionMode="Multiple" AutoHide="Self" />
    </div>
    <div data-activator="SideBarTask|Stsuplir">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="Stsuplir" view="grid1" FilterSource="view1Extender" FilterFields="Curncy_No" SelectionMode="Multiple" AutoHide="Self" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows stcurncy management.</div>
    </div>
  </div>
</asp:Content>