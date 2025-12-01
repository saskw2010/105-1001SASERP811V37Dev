<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schglpaydlyhdreg.aspx.vb" Inherits="Pages_schglpaydlyhdreg"  Title="Schglpaydlyhdreg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Schglpaydlyhdreg</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schglpaydlyhdreg" view="grid1" ShowInSummary="True" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" ShowDetailsInListMode="False" ShowPager="Top" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Schglpaydlydetailreg">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schglpaydlydetailreg" view="grid1" FilterSource="view1Extender" FilterFields="schglpaydlyhdregid" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowDetailsInListMode="False" ShowQuickFind="False" ShowRowNumber="True" ShowSearchBar="False" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Schglpaydlydetailpayment">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schglpaydlydetailpayment" view="grid1" FilterSource="view1Extender" FilterFields="schglpaydlyhdregid" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowDetailsInListMode="False" ShowPager="Top" ShowQuickFind="False" ShowRowNumber="True" ShowSearchBar="False" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Attachment">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="schattachglpaylists" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="schglpaydlyhdregid" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowDetailsInListMode="False" ShowPager="Top" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows schglpaydlyhdreg management.</div>
    </div>
  </div>
</asp:Content>