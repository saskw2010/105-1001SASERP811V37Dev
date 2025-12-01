<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Reviewreciptgeneral.aspx.vb" Inherits="Pages_Reviewreciptgeneral"  Title="Reviewreciptgeneral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Reviewreciptgeneral</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schglvchdlydetailpayment" view="grid1" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" ShowViewSelector="False" ShowPager="Top" />
  </div>
</asp:Content>