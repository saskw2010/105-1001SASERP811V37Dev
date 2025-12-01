<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="QGLTRANSBALNCEYEARMONTH.aspx.vb" Inherits="Pages_QGLTRANSBALNCEYEARMONTH"  Title="Qgltransbalnceyearmonth" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Qgltransbalnceyearmonth</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="QGLTRANSBALNCEYEARMONTH" view="grid1" ShowInSummary="True" SelectionMode="Multiple" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows qgltransbalnceyearmonth management.</div>
    </div>
  </div>
</asp:Content>