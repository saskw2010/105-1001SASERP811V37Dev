<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="azonhdr1.aspx.vb" Inherits="Pages_azonhdr1"  Title="Azonhdr1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Azonhdr1</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="azonhdr1" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" ShowDetailsInListMode="False" />
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|ItemFromHand">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="itembatchfromstock" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="Brn_No,countrdus" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" ShowRowNumber="True" />
    </div>
    <div data-activator="Tab|GardDetails">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="azondtl1" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="countrdus" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows azonhdr1 management.</div>
    </div>
  </div>
</asp:Content>