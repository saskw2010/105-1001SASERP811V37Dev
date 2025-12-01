<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Stslsman.aspx.vb" Inherits="Pages_Stslsman"  Title="Stslsman" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Stslsman</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Stslsman">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Stslsman" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
    </div>
    <div data-activator="SideBarTask|Stcustmr">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Stcustmr" view="grid1" FilterSource="view1Extender" FilterFields="Slm_No" SelectionMode="Multiple" AutoHide="Self" />
    </div>
    <div data-activator="SideBarTask|Contracts">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="Contracts" view="grid1" FilterSource="view1Extender" FilterFields="" SelectionMode="Multiple" AutoHide="Self" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows stslsman management.</div>
    </div>
  </div>
</asp:Content>