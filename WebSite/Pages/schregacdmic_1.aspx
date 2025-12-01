<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schregacdmic_1.aspx.vb" Inherits="Pages_schregacdmic_1"  Title="Schregacdmic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Schregacdmic</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Schregacdmic">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schregacdmic" view="grid1" ShowInSummary="True" SelectionMode="Multiple" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schregacdmicnew" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="regacdmic,acdcode,StudentCode,branch" SelectionMode="Multiple" AutoHide="Container" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows schregacdmic management.</div>
    </div>
  </div>
</asp:Content>