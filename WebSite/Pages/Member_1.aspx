<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Member_1.aspx.vb" Inherits="Pages_Member_1"  Title="Member" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Member</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow" style="padding-top:15px">
    <div data-activator="Tab|Userlist">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="AspNetUsers" view="grid1" PageSize="21" ShowActionButtons="Top" ShowPager="Top" ShowRowNumber="True" />
    </div>
    <div data-activator="Tab|UserRoles">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="AspNetRoles" view="grid1" PageSize="21" ShowActionButtons="Top" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
</asp:Content>