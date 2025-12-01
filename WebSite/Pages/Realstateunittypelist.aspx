<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Realstateunittypelist.aspx.vb" Inherits="Pages_Realstateunittypelist"  Title="Realstateunittypelist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Realstateunittypelist</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Realstateunittypelist" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Realstateasstedetail">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Realstateasstedetail" view="grid1" FilterSource="view1Extender" FilterFields="Realstateunittypeid" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Realstate Stock">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="RealstateStock" view="grid1" FilterSource="view1Extender" FilterFields="Realstateunittypeid" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Realclasifacationlistprice">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="Realclasifacationlistprice" view="grid1" FilterSource="view1Extender" FilterFields="Realstateunittypeid" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows realstateunittypelist management.</div>
    </div>
  </div>
</asp:Content>