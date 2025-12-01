<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="StudentForms.aspx.vb" Inherits="Pages_StudentForms"  Title="StudentForms" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">StudentForms</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="dv100" runat="server"></div>
    <aquarium:DataViewExtender id="dv100Extender" runat="server" TargetControlID="dv100" Controller="SchStudent" view="grid1" SelectionMode="Multiple" SearchOnStart="True" />
  </div>
</asp:Content>