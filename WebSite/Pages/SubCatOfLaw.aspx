<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="SubCatOfLaw.aspx.vb" Inherits="Pages_SubCatOfLaw"  Title="Sub Cat Of Law" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Sub Cat Of Law</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="SubCatOfLaw" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Profile Main">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="ProfileMain" view="grid1" FilterSource="view1Extender" FilterFields="SubCatOfLawID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Sub Cat Of Law">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="SubCatOfLaw" view="grid1" FilterSource="view1Extender" FilterFields="SubCatOfLawID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Excution">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="Excution" view="grid1" FilterSource="view1Extender" FilterFields="profileSubCatOfLawSubCatOfLawID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Attachmentprofilemain">
      <div id="view5" runat="server"></div>
      <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="Attachmentprofilemain" view="grid1" FilterSource="view1Extender" FilterFields="profileSubCatOfLawSubCatOfLawID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Galasat">
      <div id="view6" runat="server"></div>
      <aquarium:DataViewExtender id="view6Extender" runat="server" TargetControlID="view6" Controller="Galasat" view="grid1" FilterSource="view1Extender" FilterFields="profileSubCatOfLawSubCatOfLawID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Khobara">
      <div id="view7" runat="server"></div>
      <aquarium:DataViewExtender id="view7Extender" runat="server" TargetControlID="view7" Controller="Khobara" view="grid1" FilterSource="view1Extender" FilterFields="profileSubCatOfLawSubCatOfLawID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Khosom Related">
      <div id="view8" runat="server"></div>
      <aquarium:DataViewExtender id="view8Extender" runat="server" TargetControlID="view8" Controller="KhosomRelated" view="grid1" FilterSource="view1Extender" FilterFields="profileSubCatOfLawSubCatOfLawID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Mowakel Related">
      <div id="view9" runat="server"></div>
      <aquarium:DataViewExtender id="view9Extender" runat="server" TargetControlID="view9" Controller="MowakelRelated" view="grid1" FilterSource="view1Extender" FilterFields="profileSubCatOfLawSubCatOfLawID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|process Excution">
      <div id="view10" runat="server"></div>
      <aquarium:DataViewExtender id="view10Extender" runat="server" TargetControlID="view10" Controller="processExcution" view="grid1" FilterSource="view1Extender" FilterFields="ExecutionprofileSubCatOfLawSubCatOfLawID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Profile Mainhist">
      <div id="view11" runat="server"></div>
      <aquarium:DataViewExtender id="view11Extender" runat="server" TargetControlID="view11" Controller="ProfileMainhist" view="grid1" FilterSource="view1Extender" FilterFields="profileSubCatOfLawSubCatOfLawID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Rel Case">
      <div id="view12" runat="server"></div>
      <aquarium:DataViewExtender id="view12Extender" runat="server" TargetControlID="view12" Controller="RelCase" view="grid1" FilterSource="view1Extender" FilterFields="profileSubCatOfLawSubCatOfLawID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows sub cat of law management.</div>
    </div>
  </div>
</asp:Content>