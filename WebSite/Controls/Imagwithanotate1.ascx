<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Imagwithanotate1.ascx.vb" Inherits="Controls_Imagwithanotate1"  %>
<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>



<script type="text/javascript">
    $(window).ready(
    setTimeout(function () {
        var dataView = Web.DataView.find('CarInfom', 'Controller');
        if (dataView)
            dataView.add_selected(function () {
                $('.MyTextBox').val(dataView.get_selectedKey())
               
            });
    }, 50)
    );
</script>
<%--lastannotate--%>
<div id="CarInfom_editForm1_c5" style="display: table;">
    <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        <AjaxSettings>
            <telerik:AjaxSetting AjaxControlID="Timer1">
                <UpdatedControls>
      
                     <telerik:AjaxUpdatedControl ControlID="Panel3" LoadingPanelID="LoadingPanel1"></telerik:AjaxUpdatedControl>
                   
                    
                </UpdatedControls>
            </telerik:AjaxSetting>
  
            <telerik:AjaxSetting AjaxControlID="DropDownList1">
                <UpdatedControls>
    
                    <telerik:AjaxUpdatedControl ControlID="Panel2"></telerik:AjaxUpdatedControl>
                    <telerik:AjaxUpdatedControl ControlID="Panel3"></telerik:AjaxUpdatedControl>
                </UpdatedControls>
            </telerik:AjaxSetting>
        </AjaxSettings>
    </telerik:RadAjaxManager>
    <telerik:RadAjaxLoadingPanel ID="LoadingPanel1" runat="server">
    </telerik:RadAjaxLoadingPanel>
   
    <asp:Panel ID="Panel1" runat="server">
        <asp:Timer ID="Timer1" runat="server" Interval="10000" OnTick="Timer1_Tick">
        </asp:Timer>
    </asp:Panel>
    
   
   <asp:Panel ID="Panel3" runat="server">
    <asp:TextBox type="text" ID="TextBox2" runat="server" ></asp:TextBox>
<asp:TextBox type="text" ID="TextBox3" runat="server" class="MyTextBox3"></asp:TextBox>
<asp:ImageButton id="MarkupImage" runat="server"></asp:ImageButton>
 </asp:Panel>

        <table>
            <tr>
                <td style="width: 300px">
                    Change Timer Interval:
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Panel ID="Panel2" runat="server">
                    <asp:TextBox type="text" ID="TextBox1" runat="server"   AutoPostBack="True" class="MyTextBox"></asp:TextBox>
                        Timer interval:
                        <asp:Label ID="lblInterval" runat="server" Text="3000" Style="font-weight: bold;"></asp:Label>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    
<%--    <div style="float: left;">
        <telerik:RadGrid ID="RadGrid1" runat="server" Width="450px" OnItemDataBound="RadGrid1_ItemDataBound"
            OnNeedDataSource="RadGrid1_NeedDataSource">
            <MasterTableView AutoGenerateColumns="False" DataKeyNames="Change" TableLayout="Fixed">
                <Columns>
                    <telerik:GridBoundColumn DataField="Index" HeaderText="Index" UniqueName="Index">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="Value" HeaderText="Value" DataFormatString="{0:C2}"
                        UniqueName="Value">
                    </telerik:GridBoundColumn>
                    <telerik:GridBoundColumn DataField="Change" HeaderText="Change" DataFormatString="{0:P2}"
                        UniqueName="Change">
                    </telerik:GridBoundColumn>
                    <telerik:GridTemplateColumn UniqueName="TemplateColumn">
                        <HeaderStyle Width="40px"></HeaderStyle>
                        <ItemTemplate>
                            <asp:Image ID="Image1" AlternateText="progress" BorderWidth="0px" runat="server">
                            </asp:Image>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                </Columns>
            </MasterTableView>
        </telerik:RadGrid>
    </div>--%>
   

                            
</div>