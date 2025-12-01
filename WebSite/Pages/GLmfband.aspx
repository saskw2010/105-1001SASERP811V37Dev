<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="GLmfband.aspx.vb" Inherits="Pages_GLmfband"  Title="G Lmfband" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">G Lmfband</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|G Lmfband">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="GLmfband" view="grid1" ShowInSummary="True" SelectionMode="Multiple" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|G Lmstrfl">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="GLmstrfl" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="Acc_Bnd" SelectionMode="Multiple" SearchOnStart="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows g lmfband management.</div>
    </div>
  </div>
</asp:Content>