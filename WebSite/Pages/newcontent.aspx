<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="newcontent.aspx.vb" Inherits="Pages_newcontent"  Title="newcontent" %>
<%@ Register Src="../Controls/newcontent.ascx" TagName="newcontent"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">newcontent</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewColumn"><uc:newcontent ID="Carousel" runat="server"></uc:newcontent></div>
</asp:Content>