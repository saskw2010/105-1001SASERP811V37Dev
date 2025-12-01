<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="CarInfom.aspx.vb" Inherits="Pages_CarInfom"  Title="Car Infom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Car Infom</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div id="view1" runat="server"></div>
    <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="CarInfom" view="grid1" ShowInSummary="True" SelectionMode="Multiple" SearchOnStart="True" />
  </div>
  <div data-flow="NewRow" style="padding-top:8px">
    <div data-activator="Tab|ajr Contracts">
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="ajrContracts" view="grid1" FilterSource="view1Extender" FilterFields="Car_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Azonhdr">
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="azonhdr" view="grid1" FilterSource="view1Extender" FilterFields="carno" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Car Trip">
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="CarTrip" view="grid1" FilterSource="view1Extender" FilterFields="car_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Ajrbadelacontract">
      <div id="view5" runat="server"></div>
      <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="ajrbadelacontract" view="grid1" FilterSource="view1Extender" FilterFields="Car_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Ajrcheckinouttrans">
      <div id="view6" runat="server"></div>
      <aquarium:DataViewExtender id="view6Extender" runat="server" TargetControlID="view6" Controller="ajrcheckinouttrans" view="grid1" FilterSource="view1Extender" FilterFields="Car_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Attachmentcar">
      <div id="view7" runat="server"></div>
      <aquarium:DataViewExtender id="view7Extender" runat="server" TargetControlID="view7" Controller="Attachmentcar" view="grid1" FilterSource="view1Extender" FilterFields="car_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Cacotractdtl">
      <div id="view8" runat="server"></div>
      <aquarium:DataViewExtender id="view8Extender" runat="server" TargetControlID="view8" Controller="cacotractdtl" view="grid1" FilterSource="view1Extender" FilterFields="car_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Caraccesories">
      <div id="view9" runat="server"></div>
      <aquarium:DataViewExtender id="view9Extender" runat="server" TargetControlID="view9" Controller="Caraccesories" view="grid1" FilterSource="view1Extender" FilterFields="Car_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Carrent Trip">
      <div id="view10" runat="server"></div>
      <aquarium:DataViewExtender id="view10Extender" runat="server" TargetControlID="view10" Controller="CarrentTrip" view="grid1" FilterSource="view1Extender" FilterFields="car_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Carrent Tripdaily">
      <div id="view11" runat="server"></div>
      <aquarium:DataViewExtender id="view11Extender" runat="server" TargetControlID="view11" Controller="CarrentTripdaily" view="grid1" FilterSource="view1Extender" FilterFields="car_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Car Reserved">
      <div id="view12" runat="server"></div>
      <aquarium:DataViewExtender id="view12Extender" runat="server" TargetControlID="view12" Controller="CarReserved" view="grid1" FilterSource="view1Extender" FilterFields="car_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Carservice">
      <div id="view13" runat="server"></div>
      <aquarium:DataViewExtender id="view13Extender" runat="server" TargetControlID="view13" Controller="Carservice" view="grid1" FilterSource="view1Extender" FilterFields="car_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Carsoled">
      <div id="view14" runat="server"></div>
      <aquarium:DataViewExtender id="view14Extender" runat="server" TargetControlID="view14" Controller="Carsoled" view="grid1" FilterSource="view1Extender" FilterFields="car_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Catrfcdly">
      <div id="view15" runat="server"></div>
      <aquarium:DataViewExtender id="view15Extender" runat="server" TargetControlID="view15" Controller="Catrfcdly" view="grid1" FilterSource="view1Extender" FilterFields="car_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Ca Trscargo">
      <div id="view16" runat="server"></div>
      <aquarium:DataViewExtender id="view16Extender" runat="server" TargetControlID="view16" Controller="CaTrscargo" view="grid1" FilterSource="view1Extender" FilterFields="Car_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Ca Trs Pymt">
      <div id="view17" runat="server"></div>
      <aquarium:DataViewExtender id="view17Extender" runat="server" TargetControlID="view17" Controller="CaTrsPymt" view="grid1" FilterSource="view1Extender" FilterFields="Car_No" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Maintdetailstril">
      <div id="view18" runat="server"></div>
      <aquarium:DataViewExtender id="view18Extender" runat="server" TargetControlID="view18" Controller="maintdetailstril" view="grid1" FilterSource="view1Extender" FilterFields="Tril_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Rental Orders">
      <div id="view19" runat="server"></div>
      <aquarium:DataViewExtender id="view19Extender" runat="server" TargetControlID="view19" Controller="RentalOrders" view="grid1" FilterSource="view1Extender" FilterFields="CarID" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Storderdtl">
      <div id="view20" runat="server"></div>
      <aquarium:DataViewExtender id="view20Extender" runat="server" TargetControlID="view20" Controller="Storderdtl" view="grid1" FilterSource="view1Extender" FilterFields="carno" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
    <div data-activator="Tab|Transorder Detail">
      <div id="view21" runat="server"></div>
      <aquarium:DataViewExtender id="view21Extender" runat="server" TargetControlID="view21" Controller="TransorderDetail" view="grid1" FilterSource="view1Extender" FilterFields="Car_no" PageSize="5" SelectionMode="Multiple" AutoHide="Container" />
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  <div class="TaskBox About">
    <div class="Inner">
      <div class="Header">About</div>
      <div class="Value">This page allows car infom management.</div>
    </div>
  </div>
</asp:Content>