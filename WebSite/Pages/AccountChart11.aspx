<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="AccountChart11.aspx.vb" Inherits="Pages_AccountChart11"  Title="speedAccountChart" %>
<%@ Register Src="../Controls/Treewithdataspeed.ascx" TagName="Treewithdataspeed"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">speedAccountChart</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow"><uc:Treewithdataspeed ID="control1" runat="server"></uc:Treewithdataspeed></div>
</asp:Content>