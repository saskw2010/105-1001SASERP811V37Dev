<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="webreportviwerRES.aspx.vb" Inherits="Pages_webreportviwerRES"  Title="webreportviwerRES" %>
<%@ Register Src="../Controls/wexreporresponse.ascx" TagName="wexreporresponse"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">webreportviwer</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|reportviewer"><uc:wexreporresponse ID="control1" runat="server"></uc:wexreporresponse></div>
  </div>
</asp:Content>