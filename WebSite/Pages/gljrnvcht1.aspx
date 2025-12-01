<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="gljrnvcht1.aspx.vb" Inherits="Pages_gljrnvcht1"  Title="gljrnvcht 1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">gljrnvcht 1</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="GLjrnvchT1" view="grid1" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>