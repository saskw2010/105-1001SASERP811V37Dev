<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ItemTree.ascx.vb" Inherits="Controls_ItemTree"  %>
<!-- 
    This section provides a sample markup for Desktop user inteface.
-->
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div style="margin:2px;border: solid 1px silver;padding:8px;">
           
               <asp:Repeater ID="menudata" runat="server" DataSourceID="SqlDataSource1">
                    <ItemTemplate>
                        <div>
                            <a href="products.aspx?cid=<%# DataBinder.Eval(Container.DataItem, "Tasneefcode1")%>"
                                class="but-menu">
                                <%# DataBinder.Eval(Container.DataItem, "TasneefDesc1")%>
                            </a>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>



               <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eZee %>" SelectCommand="SELECT [Tasneefcode1], [TasneefDesc1], [TasneefDesc2] FROM [AttchTasneefgen1]"></asp:SqlDataSource>



        </div>

    </ContentTemplate>

</asp:UpdatePanel>
<!-- 
    This section provides a sample markup for Touch UI user interface. 
-->
<div id="ItemTree" data-app-role="page" data-activator="Button|ItemTree">
  <div data-role="content">
    <p>
              Markup of <i>ItemTree</i> custom user control for Touch UI.
            </p>
  </div>
</div>
        
<script type="text/javascript">
    (function() {
        if ($app.mobile)
            $(document).one('start.app', function () {
                // The page of Touch UI application is ready to be configured
        });
    })();
</script>
