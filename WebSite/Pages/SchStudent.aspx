<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="SchStudent.aspx.vb" Inherits="Pages_SchStudent"  Title="Sch Student" %>
<%@ Register Src="../Controls/selectkeybox.ascx" TagName="selectkeybox"  TagPrefix="uc" %>
<%@ Register Src="../Controls/Student_GridTemplete.ascx" TagName="Student_GridTemplete"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Sch Student</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Sch Student">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="SchStudent" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
    </div><uc:selectkeybox ID="c100" runat="server"></uc:selectkeybox><uc:Student_GridTemplete ID="c101" runat="server"></uc:Student_GridTemplete></div>
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Schregacdmic">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schregacdmic" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="StudentCode" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div id="view4" runat="server"></div>
    <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="schregacdmicnew" view="grid1" ShowInSummary="True" FilterSource="view3Extender" FilterFields="regacdmic" SelectionMode="Multiple" Tag="Reports" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows sch student management.</div>
    </div>
  </div>
</asp:Content>