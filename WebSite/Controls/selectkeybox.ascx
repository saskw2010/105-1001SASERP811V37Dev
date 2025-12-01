<%@ Control Language="VB" AutoEventWireup="false" CodeFile="selectkeybox.ascx.vb" Inherits="Controls_selectkeybox"  %>
<div  style="display: none">
    
<script type="text/javascript">
    $(window).ready(
    setTimeout(function () {
        var dataView = Web.DataView.find('SchStudent', 'Controller');
        if (dataView)
            dataView.add_selected(function () {
                $('.MyTextBox').val(dataView.get_selectedKey())
            });
    }, 50)
    );
</script>
<asp:TextBox type="text" ID="MyTextBox" runat="server" class="MyTextBox"></asp:TextBox>
</div>

