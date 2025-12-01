<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="webreportviwer.aspx.vb" Inherits="Pages_webreportviwer"  Title="webreportviwer" %>
<%@ Register Src="../Controls/wexreport.ascx" TagName="wexreport"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">webreportviwer</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|reportviewer"><uc:wexreport ID="control1" runat="server"></uc:wexreport></div>
  </div>
</asp:Content>