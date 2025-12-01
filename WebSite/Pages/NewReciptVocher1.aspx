<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="NewReciptVocher1.aspx.vb" Inherits="Pages_NewReciptVocher1"  Title="New Recipt Vocher 1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">New Recipt Vocher 1</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="SideBarTask|Recipt">
      <div id="dv100" runat="server"></div>
      <aquarium:DataViewExtender id="dv100Extender" runat="server" TargetControlID="dv100" Controller="schvchdlyhdreg" view="grid1" PageSize="10" SelectionMode="Multiple" ShowActionButtons="Bottom" ShowViewSelector="False" ShowDetailsInListMode="False" ShowPager="Top" ShowRowNumber="True" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|newgrid">
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="schvchdlydetailregtmp" view="grid1" ShowInSummary="True" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="6" SelectionMode="Multiple" ShowActionButtons="Top" ShowPager="Top" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Payment Details">
      <div id="dv102" runat="server"></div>
      <aquarium:DataViewExtender id="dv102Extender" runat="server" TargetControlID="dv102" Controller="schvchdlydetailpayment" view="grid1" ShowInSummary="True" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="10" SelectionMode="Multiple" ShowActionButtons="None" ShowViewSelector="False" AutoHide="Container" ShowPager="Top" ShowQuickFind="False" ShowSearchBar="False" />
    </div>
  </div>
  <div data-flow="NewRow">
    <div data-activator="Tab|Attachment">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="schattachvchlists" view="grid1" FilterSource="dv100Extender" FilterFields="schvchdlyhdregid" PageSize="5" SelectionMode="Multiple" ShowActionButtons="Top" AutoHide="Container" ShowPager="Top" />
    </div>
  </div>
</asp:Content>