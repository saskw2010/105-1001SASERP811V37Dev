<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="html1002.aspx.vb" Inherits="Pages_html1002"  Title="html 1002" %>
<%@ Register Src="../Controls/html1002.ascx" TagName="html1002"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">html 1002</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow=""><uc:html1002 ID="Carousel" runat="server"></uc:html1002></div>
</asp:Content>