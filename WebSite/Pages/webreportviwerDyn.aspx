<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="webreportviwerDyn.aspx.vb" Inherits="webreportviwerDyn"  Title="webreportviwerDyn" %>
<%@ Register Src="../Controls/Dynwexreport.ascx" TagName="Dynwexreport"  TagPrefix="uc" %>

<asp:Content ID="Content2"  ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|reportviewer"><uc:Dynwexreport ID="control1" runat="server"></uc:Dynwexreport></div>
  </div>
</asp:Content>