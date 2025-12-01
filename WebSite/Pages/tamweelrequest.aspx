<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="tamweelrequest.aspx.vb" Inherits="Pages_tamweelrequest"  Title="tamweelrequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">tamweelrequest</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Tamweelrequest">
      <div id="dv100" runat="server"></div>
      <aquarium:DataViewExtender id="dv100Extender" runat="server" TargetControlID="dv100" Controller="Tamweelrequest" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" AutoSelectFirstRow="True" AutoHighlightFirstRow="True" ShowRowNumber="True" />
    </div>
    <div data-activator="Tab|installment">
      <div id="dv101" runat="server"></div>
      <aquarium:DataViewExtender id="dv101Extender" runat="server" TargetControlID="dv101" Controller="tamweelinstallment" view="grid1" ShowInSummary="True" FilterSource="dv100Extender" FilterFields="Tamweelreqid" SelectionMode="Multiple" ShowRowNumber="True" />
    </div>
  </div>
</asp:Content>