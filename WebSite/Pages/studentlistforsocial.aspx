<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="studentlistforsocial.aspx.vb" Inherits="Pages_studentlistforsocial"  Title="Absentdtl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Absentdtl</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schApplication1099" view="grid2" PageSize="44" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
  </div>
  <div data-flow="NewRow">
    <div class="DataViewHeader">الملاحظات</div>
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schComments1" view="grid1" FilterSource="view1Extender" FilterFields="StudentCode,branch,acdcode" SelectionMode="Multiple" ShowActionButtons="None" ShowPager="Top" />
    <div class="DataViewHeader">الغياب</div>
    <div id="view3" runat="server"></div>
    <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="absentdtl" view="grid1" FilterSource="view1Extender" FilterFields="ApplicationCodeauto" SelectionMode="Multiple" ShowActionButtons="None" ShowPager="Top" />
    <div id="view4" runat="server"></div>
    <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="SchSpclCase" view="grid1" FilterSource="view1Extender" FilterFields="StudentCode,branch,acdcode" SelectionMode="Multiple" ShowActionButtons="None" ShowPager="None" />
    <div class="DataViewHeader">الحالات المرضيه</div>
    <div id="view5" runat="server"></div>
    <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="SchHlthcase1" view="grid1" FilterSource="view1Extender" FilterFields="StudentCode,branch,acdcode" SelectionMode="Multiple" ShowActionButtons="None" ShowPager="Top" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows absentdtl management.</div>
    </div>
  </div>
</asp:Content>