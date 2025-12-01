<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="ResultStudent.aspx.vb" Inherits="Pages_ResultStudent"  Title="ResultStudent" %>
<%@ Register Src="../Controls/ResultStudent.ascx" TagName="ResultStudent"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">ResultStudent</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|ResultStudent"><uc:ResultStudent ID="control1" runat="server"></uc:ResultStudent></div>
  </div>
</asp:Content>