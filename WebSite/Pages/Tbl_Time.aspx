<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Tbl_Time.aspx.vb" Inherits="Pages_Tbl_Time"  Title="Tbl Time" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Tbl Time</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Tbl_Time" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Tbl Arch Appoint">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="Tbl_ArchAppoint" view="grid1" FilterSource="view1Extender" FilterFields="TheIDATUTOTime" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Tbl Promissory Notes">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="Tbl_PromissoryNotes" view="grid1" FilterSource="view1Extender" FilterFields="Rainbow_IDATUTOTime" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Tbl Serv Appoint">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="Tbl_ServAppoint" view="grid1" FilterSource="view1Extender" FilterFields="Rainbow_IDATUTOTime" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows tbl time management.</div>
    </div>
  </div>
</asp:Content>