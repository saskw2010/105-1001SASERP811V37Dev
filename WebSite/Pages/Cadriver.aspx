<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="Cadriver.aspx.vb" Inherits="Pages_Cadriver"  Title="Cadriver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Cadriver</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="Cadriver" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|Maintncrequest">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="maintncrequest" view="grid1" FilterSource="view1Extender" FilterFields="Div_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Car Infom">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="CarInfom" view="grid1" FilterSource="view1Extender" FilterFields="EMP_NO" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Car Trip">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="CarTrip" view="grid1" FilterSource="view1Extender" FilterFields="Emp_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Carrent Trip">
      <div id="view5" runat="server"></div>
      <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="CarrentTrip" view="grid1" FilterSource="view1Extender" FilterFields="Emp_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Carrent Tripdaily">
      <div id="view6" runat="server"></div>
      <aquarium:DataViewExtender id="view6Extender" runat="server" TargetControlID="view6" Controller="CarrentTripdaily" view="grid1" FilterSource="view1Extender" FilterFields="Emp_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Carservice">
      <div id="view7" runat="server"></div>
      <aquarium:DataViewExtender id="view7Extender" runat="server" TargetControlID="view7" Controller="Carservice" view="grid1" FilterSource="view1Extender" FilterFields="Emp_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Maintncrequestrpt">
      <div id="view8" runat="server"></div>
      <aquarium:DataViewExtender id="view8Extender" runat="server" TargetControlID="view8" Controller="maintncrequestrpt" view="grid1" FilterSource="view1Extender" FilterFields="Div_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Rental Orders">
      <div id="view9" runat="server"></div>
      <aquarium:DataViewExtender id="view9Extender" runat="server" TargetControlID="view9" Controller="RentalOrders" view="grid1" FilterSource="view1Extender" FilterFields="EmployeeID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Transorder Detail">
      <div id="view10" runat="server"></div>
      <aquarium:DataViewExtender id="view10Extender" runat="server" TargetControlID="view10" Controller="TransorderDetail" view="grid1" FilterSource="view1Extender" FilterFields="CardriverNo" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows cadriver management.</div>
    </div>
  </div>
</asp:Content>