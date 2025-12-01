<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="AccountChart.aspx.vb" Inherits="Pages_AccountChart"  Title="Account Chart" %>
<%@ Register Src="../Controls/Treewithdata.ascx" TagName="Treewithdata"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Account Chart</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow"><uc:Treewithdata ID="control1" runat="server"></uc:Treewithdata></div>
</asp:Content>