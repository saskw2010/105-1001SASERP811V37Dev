<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="html1001.aspx.vb" Inherits="Pages_html1001"  Title="html 1001" %>
<%@ Register Src="../Controls/html1001.ascx" TagName="html1001"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">html 1001</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow=""><uc:html1001 ID="Carousel" runat="server"></uc:html1001></div>
</asp:Content>