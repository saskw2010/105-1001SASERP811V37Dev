
<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Student_GridTemplete.ascx.vb" Inherits="Controls_Student_GridTemplete"  %>
<div id="SchStudent_grid1" style="display: none">

<table>
<tr>
<td id="xtr" style="vertical-align:top;">
<div class="FieldPlaceholder DataOnly">{StudentCode}</div>
</td>
<td style="vertical-align:top;">
<div class="FieldPlaceholder DataOnly">{Picture}</div>
</td> 
<td style="vertical-align:top;">
<div class="FieldPlaceholder DataOnly">{FirstName1}</div>
</td> 
<td style="vertical-align:top;">
{view3Extender}
</td> 
</tr>
</table>
</div>
<%--
<asp:Repeater ID="Rerightads" runat="server">
                            <ItemTemplate>
                                <div>
                                <asp:Button runat="server"  Text='<%# DataBinder.Eval(Container.DataItem, "reportfullname")%>' />
                                
                                </div>
                            </ItemTemplate>
</asp:Repeater>
--%>