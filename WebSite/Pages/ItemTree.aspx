<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ItemTree.aspx.vb" Inherits="Pages_ItemTree"  Title="Item Tree" %>
<%@ Register Src="../Controls/ItemTree.ascx" TagName="ItemTree"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Item Tree</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow"><uc:ItemTree ID="control1" runat="server"></uc:ItemTree></div>
</asp:Content>