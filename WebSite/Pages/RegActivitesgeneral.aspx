<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="RegActivitesgeneral.aspx.vb" Inherits="Pages_RegActivitesgeneral"  Title="Reg Activitesgeneral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Reg Activitesgeneral</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="RegActivitesStudent1" view="grid1" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
  </div>
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="RegActivitesStudentdetailes1" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="RegActivitesstudentid1" SelectionMode="Multiple" AutoHide="Container" />
  </div>
  <div data-flow="NewRow">
    <div id="view3" runat="server"></div>
    <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="RegActivitesStudentdetailes" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="RegActivitesstudentid1" SelectionMode="Multiple" AutoHide="Container" />
  </div>
</asp:Content>