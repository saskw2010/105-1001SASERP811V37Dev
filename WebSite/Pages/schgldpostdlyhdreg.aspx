<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schgldpostdlyhdreg.aspx.vb" Inherits="Pages_schgldpostdlyhdreg"  Title="Schgldpostdlyhdreg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Schgldpostdlyhdreg</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schgldpostdlyhdreg" view="grid1" ShowInSummary="True" SelectionMode="Multiple" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Schgldpostdlydetailreg">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schgldpostdlydetailreg" view="grid1" FilterSource="view1Extender" FilterFields="schgldpostdlyhdregid" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Schgldpostdlydetailpayment">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schgldpostdlydetailpayment" view="grid1" FilterSource="view1Extender" FilterFields="schgldpostdlyhdregid" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows schgldpostdlyhdreg management.</div>
    </div>
  </div>
</asp:Content>