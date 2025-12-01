<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Pytree.aspx.vb" Inherits="Pages_Pytree"  Title="Pytree" %>
<%@ Register Src="../Controls/pytree.ascx" TagName="pytree"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Pytree</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow"><uc:pytree ID="control1" runat="server"></uc:pytree></div>
</asp:Content>