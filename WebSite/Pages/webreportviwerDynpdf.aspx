<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="webreportviwerDynpdf.aspx.vb" Inherits="webreportviwerDynpdf"  Title="webreportviwerDynpdf" %>
<%@ Register Src="../Controls/Dynwexreportxxpdf.ascx" TagName="Dynwexreportxx"  TagPrefix="uc" %>

<asp:Content ID="Content2"  ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|reportviewer">
        <uc:Dynwexreportxx ID="control1" runat="server"></uc:Dynwexreportxx></div>
  </div>
</asp:Content>