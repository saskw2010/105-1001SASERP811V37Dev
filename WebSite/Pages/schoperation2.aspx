<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schoperation2.aspx.vb" Inherits="Pages_schoperation2"  Title="schoperation2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">schoperation2</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="SchStudentsearch1004" view="grid1" ShowInSummary="True" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
  </div>
</asp:Content>