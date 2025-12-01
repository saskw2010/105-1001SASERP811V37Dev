<%@ Control Language="VB" AutoEventWireup="false" CodeFile="jqueryupload.ascx.vb" Inherits="Controls_jqueryupload"  %>

<div id="AttachmentGeneral_editForm1_upload" >
<table>
<tr>
<td>
<script type="text/javascript">
    $(window).ready(
    setTimeout(function () {
        var dataView = Web.DataView.find('AttachmentGeneral', 'Controller');
        if (dataView)
            dataView.add_selected(function () {
                $('.MyTextBox').val("");
                $('.MyTextBox').val(dataView.get_selectedKey());
                $('.Button1').val("~/controls" + dataView.get_selectedKey());
            });
    }, 50)
    );
</script>
<asp:TextBox type="text" ID="TextBox1" runat="server" class="MyTextBox" 
        Width="101px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" class="Button1" Text="uploadfiles" />
    
</td>
</tr>
</table>




</div>

