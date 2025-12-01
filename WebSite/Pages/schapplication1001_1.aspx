<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schapplication1001_1.aspx.vb" Inherits="Pages_schapplication1001_1"  Title="schapplication 1001" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">schapplication 1001</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schApplication10011" view="grid1" ShowInSummary="True" PageSize="100" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowPager="Top" SearchByFirstLetter="True" ShowRowNumber="True" />
  </div>
</asp:Content>