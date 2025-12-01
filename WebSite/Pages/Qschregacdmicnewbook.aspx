<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Qschregacdmicnewbook.aspx.vb" Inherits="Pages_Qschregacdmicnewbook"  Title="Qschregacdmicnewbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Qschregacdmicnewbook</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Qschregacdmicnewbook" view="grid1" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>