<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Stcustmr_3.aspx.vb" Inherits="Pages_Stcustmr_3"  Title="Stcustmr" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Stcustmr</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Stcustmr">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Stcustmr1" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Realstate Strnfhdr">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="RealTblCustomers" view="grid1" FilterSource="view1Extender" FilterFields="Customer_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Realvchdly">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="RealTblCustomers1" view="grid1" FilterSource="view1Extender" FilterFields="Customer_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows stcustmr management.</div>
    </div>
  </div>
</asp:Content>