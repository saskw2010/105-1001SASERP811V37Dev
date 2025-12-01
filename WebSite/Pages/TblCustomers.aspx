<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="TblCustomers.aspx.vb" Inherits="Pages_TblCustomers"  Title="Tbl Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Tbl Customers</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="TblCustomers" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Tbl Gifts Transactions">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="TblGiftsTransactions" view="grid1" FilterSource="view1Extender" FilterFields="Rainbow_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
      <div data-activator="Tab|Tbl_PromissoryNotes">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view2" Controller="Tbl_PromissoryNotes" view="grid1" FilterSource="view1Extender" FilterFields="Rainbow_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
      <div data-activator="Tab|Tbl_ServAppoint">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view2" Controller="Tbl_ServAppoint" view="grid1" FilterSource="view1Extender" FilterFields="Rainbow_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
     
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows tbl customers management.</div>
    </div>
  </div>
</asp:Content>