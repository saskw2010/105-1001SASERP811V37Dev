<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="GLDashBoard.aspx.vb" Inherits="Pages_GLDashBoard"  Title="GLDash Board" %>
<%@ Register Src="../Controls/Accountorgchart.ascx" TagName="Accountorgchart"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">GLDash Board</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="GLacnBnk" view="grid1" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
    <div data-activator="Tab|Account Tree"><uc:Accountorgchart ID="control1" runat="server"></uc:Accountorgchart></div>
  </div>
</asp:Content>