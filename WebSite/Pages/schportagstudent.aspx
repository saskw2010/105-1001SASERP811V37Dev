<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schportagstudent.aspx.vb" Inherits="Pages_schportagstudent"  Title="Schportagstudent" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Schportagstudent</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schportagstudent" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|اختبار تقيم الاتصال">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schportagstudentdetailes" view="grid2" ShowInSummary="True" FilterSource="view1Extender" FilterFields="schportagstudentid" PageSize="40" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" Roles="schportgmgr1" />
    </div>
    <div data-activator="Tab|اختبار العمر الادراكي">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schportagstudentdetailes" view="grid3" ShowInSummary="True" FilterSource="view1Extender" FilterFields="schportagstudentid" PageSize="40" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" Roles="schportgmgr2" />
    </div>
    <div data-activator="Tab|اختبار العمر  الاجتماعي">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="schportagstudentdetailes" view="grid4" ShowInSummary="True" FilterSource="view1Extender" FilterFields="schportagstudentid" PageSize="40" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" Roles="schportgmgr3" />
    </div>
    <div data-activator="Tab|اختبار المساعده الذاتية">
      <div id="view5" runat="server"></div>
      <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="schportagstudentdetailes" view="grid5" ShowInSummary="True" FilterSource="view1Extender" FilterFields="schportagstudentid" PageSize="40" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" Roles="schportgmgr5" />
    </div>
    <div data-activator="Tab|اختبار التطور الجسمي">
      <div id="view6" runat="server"></div>
      <aquarium:DataViewExtender id="view6Extender" runat="server" TargetControlID="view6" Controller="schportagstudentdetailes" view="grid6" ShowInSummary="True" FilterSource="view1Extender" FilterFields="schportagstudentid" PageSize="40" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" Roles="schportgmgr5" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows schportagstudent management.</div>
    </div>
  </div>
</asp:Content>