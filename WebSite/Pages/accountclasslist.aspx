<%@ Page Language="VB" MasterPageFile="~/main.Master" AutoEventWireup="false" CodeFile="accountclasslist.aspx.vb" Inherits="Pages_accountclasslist"  Title="Accountclasslist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Accountclasslist</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="accountclasslist" view="grid1" ShowInSummary="True" SelectionMode="Multiple" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|G Lmfband">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="GLmfband" view="grid1" FilterSource="view1Extender" FilterFields="accclass" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows accountclasslist management.</div>
    </div>
  </div>
</asp:Content>