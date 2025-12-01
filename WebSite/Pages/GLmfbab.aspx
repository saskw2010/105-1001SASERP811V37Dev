<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="GLmfbab.aspx.vb" Inherits="Pages_GLmfbab"  Title="G Lmfbab" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">G Lmfbab</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|G Lmfbab">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="GLmfbab" view="grid1" ShowInSummary="True" Tag="MasterList" ShowActionButtons="None" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|G Lmfmag">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="GLmfmag" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="Acc_Bab" SelectionMode="Multiple" ShowActionBar="False" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|G Lmfband">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="GLmfband" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="Acc_Bab" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|G Lmstrfl">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="GLmstrfl" view="grid1" ShowInSummary="True" FilterSource="view3Extender" FilterFields="Acc_Bnd" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows g lmfbab management.</div>
    </div>
  </div>
</asp:Content>