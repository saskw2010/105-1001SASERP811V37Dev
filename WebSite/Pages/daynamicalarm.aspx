<%@ Page Language="VB" MasterPageFile="~/MasterPage.Master" AutoEventWireup="false" CodeFile="daynamicalarm.aspx.vb" Inherits="Pages_daynamicalarm"  Title="daynamicalarm" %>

<asp:Content ID="Content2"  ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
     <div style="padding:8px" class="panel-body text-center">
  
       
      <div id="view1" runat="server"></div>
      <aquarium:DataViewExtender id="view1Extender" runat="server" TargetControlID="view1" Controller="depmastert" view="grid1" PageSize="21" RefreshInterval="60"  Roles="hralarm" ShowSearchBar="False" />
    
    
      <div id="view2" runat="server"></div>
      <aquarium:DataViewExtender id="view2Extender" runat="server" TargetControlID="view2" Controller="realpycontloc" view="grid1" PageSize="21" RefreshInterval="60" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" Roles="realalarm" />
  
  
      <div id="view3" runat="server"></div>
      <aquarium:DataViewExtender id="view3Extender" runat="server" TargetControlID="view3" Controller="caralarm" view="grid1" PageSize="21" RefreshInterval="60" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" />

 
      <div id="view4" runat="server"></div>
      <aquarium:DataViewExtender id="view4Extender" runat="server" TargetControlID="view4" Controller="QGlasatalarm" view="grid1" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" ShowRowNumber="True" />
  
  
      <div id="view5" runat="server"></div>
      <aquarium:DataViewExtender id="view5Extender" runat="server" TargetControlID="view5" Controller="PyAlarms" view="grid1" PageSize="21" ShowActionButtons="Top" AutoHide="Self" ShowPager="Top" ShowRowNumber="True" />
  
     
     
     
     
     
     
     </div>
</ContentTemplate></asp:UpdatePanel>
</asp:Content>



  


 
