<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schFather1_1.aspx.vb" Inherits="Pages_schFather1_1"  Title="sch Father" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">sch Father</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|sch Father">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schFather1001" view="Grid2" ShowInSummary="True" PageSize="1" ShowActionButtons="Top" ShowViewSelector="False" SearchOnStart="True" ShowDetailsInListMode="False" ShowPager="Top" AutoSelectFirstRow="True" ShowRowNumber="True" />
    </div>
  </div>
  <div data-flow="NewRow" style="padding-top:8px;">
    <div data-activator="SideBarTask|cheldren">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="SchStudent1001" view="Gridfjr" FilterSource="view1Extender" FilterFields="FatherCode" PageSize="8" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowModalForms="True" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows sch father management.</div>
    </div>
  </div>
</asp:Content>