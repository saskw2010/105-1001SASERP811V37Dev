<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Itemrels_1.aspx.vb" Inherits="Pages_Itemrels_1"  Title="Itemrels" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Itemrels</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|Unit List">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="itemrels" view="gridunit" ShowInSummary="True" FilterFields="ID_comp" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
</asp:Content>