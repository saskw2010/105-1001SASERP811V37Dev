<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="schglpaydlydetails.aspx.vb" Inherits="Pages_schglpaydlydetails"  Title="schglpaydlydetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">schglpaydlydetails</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schglpaydlydetailreg" view="grid2" SelectionMode="Multiple" ShowActionButtons="None" SearchOnStart="True" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>