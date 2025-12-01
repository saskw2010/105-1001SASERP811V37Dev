<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="GljrnvchReview.aspx.vb" Inherits="Pages_GljrnvchReview"  Title="Gljrnvch Review" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Gljrnvch Review</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="GLjrnvch" view="grid1" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>