<%@ Control Language="VB" AutoEventWireup="false" CodeFile="form_templete1.ascx.vb" Inherits="Controls_form_templete1"  %>

<style type="text/css">
    
     .FieldLabel1
    {
        font-weight: bold;
        padding: 4px;
        width:50px;
        text-align: right;
        
    }
    .FieldLabel
    {
        
        padding: 0px;
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
<div id="CarInfom_createForm1_c100" style="display: none;">
 
    <fieldset title="{  تأمين ضد الغير}">
 <table>

  <tr>
       <td class="FieldLabel1" >
     <div class="FieldPlaceholder TitleOnly">{Insu_Cmp}</div>
     </td>
     <td>
     
     <div class="FieldPlaceholder DataOnly">{Insu_Cmp}</div>
        </td>
       <td class="FieldLabel1" >
           <div class="FieldPlaceholder TitleOnly">{Insu_No}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_No}
            </div>
        </td>
 
        <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Insuissuedt}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insuissuedt}
            </div>
         </td>
      </tr>
         <tr align="right"> 
          <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Insu_Stdt}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_Stdt}
           </div>
           </td>
           <td class="FieldLabel1" >
           <div class="FieldPlaceholder TitleOnly">{Insu_Endt}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_Endt}
            </div>
      </td>
      <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Insu_Value}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_Value}
           </div>
          </td>
 </tr>
 </table>
 </fieldset>
 
 <fieldset title="{  تأمين عدم حق الرجوع}">
 <table>
 <tr>
    
           <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Insu_Stdt2}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_Stdt2}
           </div>
           </td>
            <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Insu_Endt2}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_Endt2}
           </div>
           </td>
           </tr>
           <tr>
           <td class="FieldLabel1" >
            <div class="FieldPlaceholder TitleOnly">{Insu_Value2}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
              {Insu_Value2}
             </div>
           </td>
    
 
           <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Insu_Cmp1}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_Cmp1}
           </div>
           </td>
   </tr>
   </table>
   </fieldset>
   <fieldset title="{ تأمين شامل}">
   <table>
     <tr align="right">
          <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Insu_No1}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_No1}
           </div>
         </td>
      <td class="FieldLabel1" >
        <div class="FieldPlaceholder TitleOnly">{Insu_issueShamel_dt}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_issueShamel_dt}
           </div>
           </td>
         <td class="FieldLabel1" >
         <div class="FieldPlaceholder TitleOnly">{Insu_Stdt1}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_Stdt1}
           </div>
           </td>
           </tr>
           <tr align="right">
           <td class="FieldLabel1" >
           <div class="FieldPlaceholder TitleOnly">{Insu_Endt1}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_Endt1}
           </div>
           </td>
           <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Insu_Car_Value}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_Car_Value}
           </div>
           </td>
     <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Insu_Value1}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_Value1}
           </div>
           </td>
           </tr>
      </table>
           </fieldset>
           
           
           
           <fieldset>
           <table>
           <tr align="right">
         <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Insu_No2}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_No2}
           </div>
           </td>

           <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Insu_Cmp2}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Insu_Cmp2}
           </div>
           </td>
           <td class="FieldLabel1" >
           <div class="FieldPlaceholder TitleOnly">{Roads_Service}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Roads_Service}
           </div>
           </td>
           </tr>
           
           
 
 <tr align="right">
     <td class="FieldLabel1" >
          
           <div class="FieldPlaceholder TitleOnly">{Service_Start}</div></td>
     <td class="FieldLabel" align="right">
     <div class="FieldPlaceholder DataOnly">
            {Service_Start}
           </div>
      </td>
    <td class="FieldLabel1" >
         <div class="FieldPlaceholder TitleOnly">{Service_End}
         </div>
         </td>
         <td class="FieldLabel" align="right">
         <div class="FieldPlaceholder DataOnly">
            {Service_End}
           </div>
           </td>
           <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Service_Value}</div></td>
          <td class="FieldLabel" align="right">
          <div class="FieldPlaceholder DataOnly">
            {Service_Value}
           </div>
           </td>
           </tr>
    <tr align="right"> 
           <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Location}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Location}
           </div>
          </td>
          <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Guarantee}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Guarantee}
           </div>
           </td>
           </tr>
           <tr>
           <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Guarantee_Start}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Guarantee_Start}
           </div>
           </td>
           <td class="FieldLabel1" >
          <div class="FieldPlaceholder TitleOnly">{Guarantee_End}</div></td><td class="FieldLabel" align="right"><div class="FieldPlaceholder DataOnly">
            {Guarantee_End}
           </div>
           </td>
 </tr>
 </table>
           </fieldset>
 

  
 
</div>