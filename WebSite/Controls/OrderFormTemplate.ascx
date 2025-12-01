
<%@ Control Language="VB" AutoEventWireup="false" CodeFile="OrderFormTemplate.ascx.vb" Inherits="Controls_OrderFormTemplate"  %>
<style type="text/css">
    
    .FieldLabel
    {
        font-weight: bold;
        padding: 4px;
        width:50px;
        text-align: right;
        
    }
    .RightAlignedInputs input
    {
        text-align: right;
    }
    table.DataView .FieldPlaceholder.TitleOnly div.Item div.Value
{
    display: none;
}
</style>

<div>
    <div id="schvchdlyhdreg_editForm1_c1" style="display: none" >
      <fieldset>
    <table style="width: 100%" >
        <tr>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder TitleOnly">
        {schvchdlyhdregid}
        </div>
       </td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder DataOnly">
        {schvchdlyhdregid}
        </div>
       </td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
         <td class="FieldLabel" align="right">
             &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
       <td>
        <div class="FieldPlaceholder TitleOnly">
        {Balance}
        </div>
       </td>
        <td>
        <div class="FieldPlaceholder DataOnly">
        {Balance}
        </div>
       </td>
       </tr>
        <tr>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder TitleOnly">
        {Trs_Dt}
        </div>
       </td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder DataOnly">
        {Trs_Dt}
        </div>
       </td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder TitleOnly">
        {Notes}
        </div>
       </td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder DataOnly">
        {Notes}
        </div>
       </td>   
      
        </tr>
       <tr>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder TitleOnly">
        {IDregorg}
        </div>
       </td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder DataOnly">
        {IDregorg}
        </div>
       </td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder TitleOnly">
        {DeleverTel}
        </div>
       </td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder DataOnly">
        {DeleverTel}
        </div>
       </td>   
      
        </tr>
       
      
       <tr>
        <td class="FieldLabel">
        <div class="FieldPlaceholder TitleOnly">
        {Delevername}
        </div>
       </td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder DataOnly">
        {Delevername}
        </div>
       </td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            <asp:Label ID="Label1" runat="server" Text="        " Width="50px"></asp:Label>
       </td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder TitleOnly">
        {havdetails}
        </div>
       </td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder DataOnly">
        {havdetails}
        </div>
       </td>   
      
        </tr>
       
      
       <tr>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder TitleOnly">
        {posted}
        </div>
       </td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder DataOnly">
        {posted}
        </div>
       </td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder TitleOnly">
        {Delevercivil}
        </div>
       </td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder DataOnly">
        {Delevercivil}
        </div>
       </td>   
      
        </tr>
       
      
       <tr>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder TitleOnly">
        {approved}
        </div>
       </td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder DataOnly">
        {approved}
        </div>
       </td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
        <td class="FieldLabel" align="right">
            &nbsp;</td>
<td class="FieldLabel" align="right">
        <div class="FieldPlaceholder TitleOnly">
        {sgm}
        </div>
       </td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder DataOnly">
        {sgm}
        </div>
       </td> 
      
        </tr>
       
      
      </table>
      </fieldset>
      <fieldset>
      <table style="width: 100%">
      <tr>
     <td>
	      {dv101Extender}
		  {view1Extender}
		  {view2Extender}
     </td> 
    </tr>
	<tr>
      <td>
      {dv102Extender}
      </td>
      </tr>
      </table>
      </fieldset>
      <fieldset>
    <table style="width: 100%" >
        <tr>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder TitleOnly">
        {sumofdebit}
        </div>
       </td>
        <td class="FieldLabel" align="right">
        <div class="FieldPlaceholder DataOnly">
        {sumofdebit}
        </div>
       </td>
       </tr>
       </table>
       </fieldset>
    </div>
</div>