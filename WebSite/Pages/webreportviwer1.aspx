<%@ Page Language="VB" MasterPageFile="~/MasterPage.Master" AutoEventWireup="false" CodeFile="webreportviwer1.aspx.vb" Inherits="Pages_webreportviwer1"  Title="webreportviwer1" %>
<%@ Register Src="../Controls/wexreport.ascx" TagName="wexreport"  TagPrefix="uc" %>

<asp:Content ID="Content2"  ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|reportviewer"><uc:wexreport ID="control1" runat="server"></uc:wexreport></div>
  </div>
</asp:Content>
