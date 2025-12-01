<%@ Control Language="VB" AutoEventWireup="false" CodeFile="schsttree.ascx.vb" Inherits="Controls_schsttree"  %>
<!-- 
    This section provides a sample markup for Desktop user inteface.
-->
<asp:UpdatePanel ID="UpdatePanel1" runat="server"><ContentTemplate><div style="margin:2px;border: solid 1px silver;padding:8px;">uc:schsttree</div></ContentTemplate></asp:UpdatePanel>
<!-- 
    This section provides a sample markup for Touch UI user interface. 
-->
<div id="schsttree" data-app-role="page" data-activator="Button|schsttree">
  <div data-role="content">
    <p>
              Markup of <i>schsttree</i> custom user control for Touch UI.
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
