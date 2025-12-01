<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="UsersTypesroles.aspx.vb" Inherits="Pages_UsersTypesroles"  Title="Users Typesroles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Users Typesroles</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="UsersTypes_roles" view="grid1" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
  </div>
</asp:Content>