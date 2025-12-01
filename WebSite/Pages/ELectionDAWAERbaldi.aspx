<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ELectionDAWAERbaldi.aspx.vb" Inherits="Pages_ELectionDAWAERbaldi"  Title="E Lection DAWAE Rbaldi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">E Lection DAWAE Rbaldi</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="ELectionDAWAERbaldi" view="grid1" ShowInSummary="True" SelectionMode="Multiple" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|E Lection Gadwalbaldi">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="ELectionGadwalbaldi" view="grid1" FilterSource="view1Extender" FilterFields="رقمالدائرة" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Election2013">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="election2013" view="grid1" FilterSource="view1Extender" FilterFields="dwaerbaldicode" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows e lection dawae rbaldi management.</div>
    </div>
  </div>
</asp:Content>