<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schapplication2_1.aspx.vb" Inherits="Pages_schapplication2_1"  Title="schapplication 2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">schapplication 2</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schApplication2" view="grid2" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|schcomment0">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schcommentcal" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="ApplicationCodeauto" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
    </div>
    <div data-activator="Tab|schcomment1">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schcommentcal" view="grid2" FilterSource="view1Extender" FilterFields="ApplicationCodeauto" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" />
    </div>
    <div data-activator="Tab|schcomment2">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="schcommentcal" view="grid3" FilterSource="view1Extender" FilterFields="ApplicationCodeauto" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" />
    </div>
    <div data-activator="Tab|schcomment3">
      <div id="view5" runat="server"></div>
      <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="schcommentcal" view="grid4" FilterSource="view1Extender" FilterFields="ApplicationCodeauto" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" />
    </div>
  </div>
</asp:Content>