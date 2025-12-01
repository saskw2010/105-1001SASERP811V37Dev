<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schstudentmos.aspx.vb" Inherits="Pages_schstudentmos"  Title="Schstudentmos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Schstudentmos</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="SchStudentmos1001" view="grid2" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowPager="Top" />
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Statment ">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="QGlschstatment" view="grid1" FilterSource="view1Extender" FilterFields="StudentCode,acdcode" PageSize="10" SelectionMode="Multiple" ShowActionBar="False" ShowActionButtons="None" ShowDescription="False" ShowViewSelector="False" AutoHide="Self" ShowPager="Top" />
    </div>
    <div id="view5" runat="server"></div>
    <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="schregacdmicnew" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="StudentCode" SelectionMode="Multiple" AutoHide="Self" />
    <div data-activator="Tab|ALL Statment Details">
      <div id="view8" runat="server"></div>
      <aquarium:DataViewExtender id="view8Extender" runat="server" TargetControlID="view8" Controller="GLschassmentBalance" view="grid1" FilterSource="view1Extender" FilterFields="branch,StudentCode" SelectionMode="Multiple" ShowActionButtons="None" AutoHide="Self" ShowPager="Top" ShowRowNumber="True" />
    </div>
    <div data-activator="Tab|Total Balance">
      <div id="view10" runat="server"></div>
      <aquarium:DataViewExtender id="view10Extender" runat="server" TargetControlID="view10" Controller="GLschassmentBalanceT" view="grid1" FilterSource="view1Extender" FilterFields="branch,StudentCode" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowRowNumber="True" />
    </div>
    <div data-activator="Tab|REG_ORGANIZATION">
      <div id="view12" runat="server"></div>
      <aquarium:DataViewExtender id="view12Extender" runat="server" TargetControlID="view12" Controller="REG_ORGANIZATIONSlist" view="grid1" FilterSource="view1Extender" FilterFields="StudentCode" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" ShowRowNumber="True" />
    </div>
    <div data-activator="Tab|Last Year Required">
      <div id="view6" runat="server"></div>
      <aquarium:DataViewExtender id="view6Extender" runat="server" TargetControlID="view6" Controller="QGlschstatment" view="grid1" FilterSource="view1Extender" FilterFields="branch,acdcode,StudentCode" PageSize="10" SelectionMode="Multiple" ShowActionBar="False" ShowActionButtons="None" ShowDescription="False" ShowViewSelector="False" AutoHide="Self" ShowPager="Top" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows schstudentmos management.</div>
    </div>
  </div>
</asp:Content>