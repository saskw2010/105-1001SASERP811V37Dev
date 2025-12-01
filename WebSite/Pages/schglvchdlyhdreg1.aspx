<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schglvchdlyhdreg1.aspx.vb" Inherits="Pages_schglvchdlyhdreg1"  Title="Schglvchdlyhdreg1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Schglvchdlyhdreg1</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schglvchdlyhdreg1" view="grid1" ShowInSummary="True" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowDetailsInListMode="False" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Schglvchdlydetailreg">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schglvchdlydetailreg1" view="grid1" FilterSource="view1Extender" FilterFields="schglvchdlyhdregid,branch,acdcode" PageSize="5" SelectionMode="Multiple" ShowActionButtons="None" AutoHide="Container" ShowPager="Top" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Schglvchdlydetailpayment">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schglvchdlydetailpayment1" view="grid1" FilterSource="view1Extender" FilterFields="schglvchdlyhdregid" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows schglvchdlyhdreg management.</div>
    </div>
  </div>
</asp:Content>