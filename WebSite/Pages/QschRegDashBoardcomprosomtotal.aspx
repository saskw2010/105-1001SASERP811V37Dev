<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="QschRegDashBoardcomprosomtotal.aspx.vb" Inherits="Pages_QschRegDashBoardcomprosomtotal"  Title="Qsch Reg Dash Boardcomprosomtotal 1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Qsch Reg Dash Boardcomprosomtotal 1</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="QschRegDashBoardcomprosomtotaltabl" view="grid1" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" ShowRowNumber="True" />
  </div>
</asp:Content>