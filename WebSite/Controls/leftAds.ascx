<%@ Control Language="VB" AutoEventWireup="true" CodeFile="leftAds.ascx.vb" Inherits="leftAds" %>
<link rel="stylesheet" href="~/js/marquee.css">
<script type="text/javascript" src="~/js/jquery.min.js"></script>
<script type="text/javascript" src="~/js/marquee.js"></script>
	<script>
	    $(function () {

	        createMarquee({
	        });

	        //example of overwriting defaults: 

	        // createMarquee({
	        // 		duration:30000,

	        // 		padding:20, 
	        // 		marquee_class:'.example-marquee', 
	        // 		container_class: '.example-container', 
	        // 		sibling_class: '.example-sibling', 
	        // 		hover: false});
	        // });
	    });

				</script>
<div class="container" dir="ltr">
  <div class="marquee-sibling">الاخبار </div>
  <div class="marquee">
    <ul class="marquee-content-items">
       <%GetAdds()%>
      </ul>
  </div>
</div>

			
<%--<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>--%>

<%--<table cellpadding="0" cellspacing="0" border="0px" width="0" dir="ltr" style="display:none">
    <tr>
        <td>
            <table >
                <tr>
     
                    <td>
                        <asp:ImageButton ID="btnSubscribe" runat="server" ImageUrl="images/tel.png" 
                            Width="25" Height="25" onclick="btnSubscribe_Click" />  
                    </td>
                    <td height="30" align="left" style="background-image: url('images/searchbackground.png');
                        background-repeat: no-repeat; width: 152px; height: 18px; background-position: center left">
                        <asp:TextBox ID="txtMobileNumber" runat="server" BorderStyle="None" Width="152" Height="18"
                            dir="rtl" BackColor="Transparent" ForeColor="White" ValidationGroup="asdfg" CssClass="mobilenumber" ></asp:TextBox>
                        <asp:TextBoxWatermarkExtender ID="txtUser_TextBoxWatermarkExtender" runat="server"
                            Enabled="True" TargetControlID="txtMobileNumber" WatermarkText="ضع رقم موبايلك ليصلك كل جديد" WatermarkCssClass="mobilenumber">
                        </asp:TextBoxWatermarkExtender>
                        <asp:FilteredTextBoxExtender ID="txtUser_FilteredTextBoxExtender" runat="server"
                            Enabled="True" TargetControlID="txtMobileNumber" ValidChars="0123456789" FilterMode="ValidChars">
                        </asp:FilteredTextBoxExtender>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td style="height: 5px;">
            
        </td>
    </tr>
   
</table>--%>
