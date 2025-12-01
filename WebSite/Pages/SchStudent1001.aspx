<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="SchStudent1001.aspx.vb" Inherits="Pages_SchStudent1001"  Title="Sch Student 1001" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Sch Student 1001</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="SchStudent" view="studentsearch" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" SearchOnStart="True" ShowRowNumber="True" />
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Statment">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="GLschassmentBalance" view="grid1" FilterSource="view1Extender" FilterFields="branch,StudentCode,acdcode" SelectionMode="Multiple" ShowActionButtons="None" AutoHide="Self" ShowPager="Top" ShowRowNumber="True" />
    </div>
    <div data-activator="Tab|Register Restricted">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="schComments" view="grid1" FilterSource="view1Extender" FilterFields="StudentCode" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" ShowRowNumber="True" />
    </div>
    <div data-activator="Tab|Registerd years">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="schregacdmic" view="grid1" FilterSource="view1Extender" FilterFields="StudentCode,branch" SelectionMode="Multiple" ShowActionButtons="None" AutoHide="Self" ShowPager="Top" ShowRowNumber="True" />
    </div>
    <div data-activator="Tab|Statment All Years">
      <div id="view5" runat="server"></div>
      <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="GLschassmentBalance" view="grid1" FilterSource="view1Extender" FilterFields="StudentCode" SelectionMode="Multiple" ShowActionButtons="None" AutoHide="Self" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
</asp:Content>