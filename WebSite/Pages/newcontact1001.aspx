<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="newcontact1001.aspx.vb" Inherits="Pages_newcontact1001"  Title="newcontact 1001" %>
<%@ Register Src="../Controls/newcontact1001.ascx" TagName="newcontact1001"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">newcontact 1001</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow=""><uc:newcontact1001 ID="StarterTemplate" runat="server"></uc:newcontact1001></div>
</asp:Content>