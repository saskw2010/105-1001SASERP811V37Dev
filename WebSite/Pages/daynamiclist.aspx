<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="daynamiclist.aspx.vb" Inherits="Pages_daynamiclist" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">Account</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
             <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" ShowStartingNode="False" />
          
        <div style="margin:2px;border: solid 1px silver;padding:8px;">
             <div      id="menu" class="PageMenuBar" style="background-color: #000000;overflow:visible">
 <telerik:RadMenu ID="RadMenu1" Runat="server"  Skin="Black"  
     
     OnItemClick="RadMenu1_ItemClick"
      DataSourceID="SiteMapDataSource1"  RenderMode="Classic"  EnableEmbeddedSkins="true" EnableTheming="True"  >



        </telerik:RadMenu>
 </div>

        

    <div style="padding:8px" class="panel-body text-center">
        
     <asp:DropDownList ID="ControllerDropDown" runat="server" AutoPostBack="True" Font-Names="Arial" Style="margin-bottom: 8px" Font-Size="12.5pt" Height="44px" Width="400px" Visible="False">
          <asp:ListItem Text="AspNetUserRoles" Value="AspNetUserRoles" />
          <asp:ListItem Text="AspNetUsers" Value="AspNetUsers" Selected="true" />
        </asp:DropDownList>
        <telerik:RadDropDownTree ID="RadDropDownTree1" runat="server" AutoPostBack="False"  OnEntryAdded="RadDropDownTree1_EntryAdded" OnEntryRemoved="RadDropDownTree1_EntryRemoved" Visible="False"
            DataSourceID="SiteMapDataSource1" ExpandNodeOnSingleClick="True" Width="400px" Font-Names="Arial" Font-Size="Large" DataTextField="Title" DataValueField="" DataFieldID="Url" OnClientEntryAdded="RadDropDownTree1_EntryAdded">
             <DropDownSettings AutoWidth="Enabled"  Width="400px" CloseDropDownOnSelection="True" />
             <ButtonSettings ShowClear="True" />
             <FilterSettings Highlight="None" />
         </telerik:RadDropDownTree>
    <div id="Div1" runat="server" />
        <aquarium:DataViewExtender ID="Extender1" runat="server" TargetControlID="Div1" />
         
      </div>
      </div>


        </ContentTemplate></asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="SideBarPlaceHolder" runat="Server">
  
</asp:Content>

<asp:Content ID="Content4" runat="server" contentplaceholderid="head">
    
    <script type="text/javascript" id="telerikClientEvents2">
//<![CDATA[

	function RadDropDownTree1_EntryAdded(sender,args)
	{
	    args.set_cancel(true);
	}
//]]>
</script>
</asp:Content>


