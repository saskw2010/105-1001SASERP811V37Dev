<%@ Page Language="vb" AutoEventWireup="false" CodeFile="annotate.aspx.vb" Inherits="annotate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="Form1" method="post" runat="server">
			<P>
				<asp:ImageButton id="MarkupImage" runat="server" ImageUrl="Markup.aspx?desc="></asp:ImageButton></P>
			<P>Type :
				<asp:DropDownList id="listType" runat="server"></asp:DropDownList>&nbsp;Param :
				<asp:TextBox id="txtParam" runat="server" Width="300px"></asp:TextBox>&nbsp;
				<asp:Button id="btnRemove" runat="server" Text="Remove #" 
                    onclick="btnRemove_Click1"></asp:Button>

				<asp:TextBox id="txtRemove" runat="server" Width="60px"></asp:TextBox><BR>
				Param Example :
				<asp:Label id="lblExample" EnableViewState="true" runat="server"></asp:Label>
			</P>
            <P>&nbsp;</P>
            <P>&nbsp;</P>
            <P>
            
                    <asp:Button id="Button2" runat="server" Text="save 1" 
                    onclick="btnRemove_Click2"></asp:Button>
                    <asp:Button id="Button3" runat="server" Text="save 2" 
                    onclick="btnRemove_Click3"></asp:Button>
				<asp:TextBox id="txtParam0" runat="server" Width="872px" Height="235px" 
                    TextMode="MultiLine"></asp:TextBox>
			</P>
		</form>
    
</body>
</html>
