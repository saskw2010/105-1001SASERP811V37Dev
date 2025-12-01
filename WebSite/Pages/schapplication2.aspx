<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schapplication2.aspx.vb" Inherits="Pages_schapplication2"  Title="schapplication 2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">schapplication 2</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schApplication2" view="grid1" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|schcomment0">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schcomment" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="ApplicationCodeauto" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" SearchOnStart="True" />
    </div>
    <div data-activator="Tab|schcomment1">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schcomment1" view="grid1" FilterSource="view1Extender" FilterFields="ApplicationCodeauto" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" />
    </div>
    <div data-activator="Tab|schcomment2">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="schcomment2" view="grid1" FilterSource="view1Extender" FilterFields="ApplicationCodeauto" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" />
    </div>
    <div data-activator="Tab|schcomment3">
      <div id="view5" runat="server"></div>
      <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="schcomment3" view="grid1" FilterSource="view1Extender" FilterFields="ApplicationCodeauto" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" />
    </div>
  </div>
</asp:Content>