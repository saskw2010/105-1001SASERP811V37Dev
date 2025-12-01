<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Storestock.aspx.vb" Inherits="Pages_Storestock"  Title="Storestock" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Storestock</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="ItemTransQuantity" view="grid3" ShowInSummary="True" SelectionMode="Multiple" ShowActionButtons="Top" ShowViewSelector="False" SearchOnStart="True" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows item trans quantity management.</div>
    </div>
  </div>
</asp:Content>