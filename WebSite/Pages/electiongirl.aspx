<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="electiongirl.aspx.vb" Inherits="Pages_electiongirl"  Title="electiongirl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">electiongirl</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|">
      <div id="dv100" runat="server"></div>
      <aquarium:DataViewExtender id="dv100Extender" runat="server" TargetControlID="dv100" Controller="election5" view="election5g" SelectionMode="Multiple" ShowDescription="False" ShowViewSelector="False" ShowRowNumber="True" />
    </div>
  </div>
</asp:Content>