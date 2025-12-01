<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schsthealthcase.aspx.vb" Inherits="Pages_schsthealthcase"  Title="Schsthealthcase" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Schsthealthcase</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Schsthealthcase">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schsthealthcase" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
    </div>
  </div>
  <div data-flow="NewRow" style="padding-top:8px;">
    <div data-activator="SideBarTask|Sch Student">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="SchStudent" view="grid1" FilterSource="view1Extender" FilterFields="schsthlthcaseid" PageSize="5" SelectionMode="Multiple" AutoHide="Container" ShowModalForms="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows schsthealthcase management.</div>
    </div>
  </div>
</asp:Content>