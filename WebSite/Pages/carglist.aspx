<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="carglist.aspx.vb" Inherits="Pages_carglist"  Title="Carglist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Carglist</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="carglist" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Carservice">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Carservice" view="grid1" FilterSource="view1Extender" FilterFields="carglistid" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Ca Trscargo">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="CaTrscargo" view="grid1" FilterSource="view1Extender" FilterFields="carglistid" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Ca Trs Pymt">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="CaTrsPymt" view="grid1" FilterSource="view1Extender" FilterFields="carglistid" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows carglist management.</div>
    </div>
  </div>
</asp:Content>