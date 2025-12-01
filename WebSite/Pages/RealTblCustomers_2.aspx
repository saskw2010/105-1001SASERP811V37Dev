<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="RealTblCustomers_2.aspx.vb" Inherits="Pages_RealTblCustomers_2"  Title="Real Tbl Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Real Tbl Customers</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="RealTblCustomers2" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
  </div>
  <div data-flow="NewRow">
    <div id="view2" runat="server"></div>
    <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="RealTblPromissoryNotes" view="grid1" ShowInSummary="True" FilterSource="view1Extender" FilterFields="Rainbow_no" PageSize="21" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowRowNumber="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows real tbl customers management.</div>
    </div>
  </div>
</asp:Content>