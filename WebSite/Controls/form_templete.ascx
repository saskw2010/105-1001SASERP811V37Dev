<%@ Control Language="VB" AutoEventWireup="false" CodeFile="form_templete.ascx.vb" Inherits="Controls_form_templete"  %>
   

 

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

<div id="CarInfom_createForm1_c1" style="display: none;">



<fieldset title="{البيانات العامة }">
    <table>
    <tr>
    <td>
    <table >
    <td>
    <tr>
              <td class="FieldLabel1" >
              <div class="FieldPlaceholder TitleOnly">
              {Ownr_No}
                </div>
                </td>
                <td class="FieldLabel" >
                <div class="FieldPlaceholder DataOnly">
               {Ownr_No}
                </div>
                </td>
                  <td class="FieldLabel1" >
             <div class="FieldPlaceholder TitleOnly">
            {pasengerno}
            </div>
            </td>
            <td class="FieldLabel" >
            <div class="FieldPlaceholder DataOnly">
            {pasengerno}
            </div>
            </td>
                </tr>
         
                <tr>
                <td class="FieldLabel1" >
                <div class="FieldPlaceholder TitleOnly">
                {Trfc_Dpm}
                </div></td>
                <td class="FieldLabel" >
                <div class="FieldPlaceholder DataOnly">
                    {Trfc_Dpm}
                </div>
                 </td>
                 <td class="FieldLabel1" >
            <div class="FieldPlaceholder TitleOnly">
            {fuelllevel}
            </div>
            </td>
            <td class="FieldLabel" >
            <div class="FieldPlaceholder DataOnly">
            {fuelllevel}
            </div>
            </td>
                 </tr>
                 <tr>
              <td class="FieldLabel1" >
               <div class="FieldPlaceholder TitleOnly">
               {Cstm_No}
               </div>
               </td>
               <td class="FieldLabel" >
               <div class="FieldPlaceholder DataOnly">
                    {Cstm_No}
                </div>
                </td>
             <td class="FieldLabel1" >
           <div class="FieldPlaceholder TitleOnly">
           {loadton1}
           </div>
           </td>
           <td class="FieldLabel" >
           <div class="FieldPlaceholder DataOnly">
            {loadton1}
            </div>
            </td>

            </tr>
            <tr>
            <td class="FieldLabel1" >
               <div class="FieldPlaceholder TitleOnly">
               {caseoperationid}</div>
               </td>
               <td class="FieldLabel" >
               <div class="FieldPlaceholder DataOnly">
                    {caseoperationid}
                </div>
                 </td>
                 <td class="FieldLabel1" >
            <div class="FieldPlaceholder TitleOnly">
            {Sup_No}</div>
            </td>
            <td class="FieldLabel" >
            <div class="FieldPlaceholder DataOnly">
            {Sup_No}
            </div>
            </td>
            </tr >
             <tr>
              <td class="FieldLabel1" >
               <div class="FieldPlaceholder TitleOnly">{Car_Type}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
                    {Car_Type}
                </div>
                 </td>
                 <td class="FieldLabel1" >
            <div class="FieldPlaceholder TitleOnly">{dileverydatesupno}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
            {dileverydatesupno}
            </div>
            </td>
                 </tr>
                 <tr>

              <td class="FieldLabel1" >
               <div class="FieldPlaceholder TitleOnly">{kind}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
                    {kind}
                </div>
            </td>
             <td class="FieldLabel1" >
            <div class="FieldPlaceholder TitleOnly">{Carspesification}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
            {Carspesification}
            </div>
            </td>
            </tr>
            <tr>
            <td class="FieldLabel1" >
             <div class="FieldPlaceholder TitleOnly">{Fbrct_Yer}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
               {Fbrct_Yer}
              </div>
              </td>
               <td class="FieldLabel1" >
           <div class="FieldPlaceholder TitleOnly">{Deliver_Date}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
            {Deliver_Date}
            </div>
            </td>
              </tr>
              <tr>
            <td class="FieldLabel1" >
             <div class="FieldPlaceholder TitleOnly">{Car_Colr}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
               {Car_Colr}
              </div>
              </td>
               <td class="FieldLabel1" >
           <div class="FieldPlaceholder TitleOnly">{Emp_Delivery}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
            {Emp_Delivery}
            </div>
            </td>
              </tr>
              <tr>
             <td class="FieldLabel1" >
             <div class="FieldPlaceholder TitleOnly">{Car_Lik}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
               {Car_Lik}
              </div>
              </td>
              <td class="FieldLabel1" >
           <div class="FieldPlaceholder TitleOnly">{lastcontnumber}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
            {lastcontnumber}
            </div>
            </td>
              </tr>
              <tr>
              <td class="FieldLabel1" >
             <div class="FieldPlaceholder TitleOnly">{Car_Chas}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
               {Car_Chas}
              </div>
             </td>
              <td class="FieldLabel1" >
           <div class="FieldPlaceholder TitleOnly">{carstutus_no}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
            {carstutus_no}
            </div>
            </td>
              </tr>
              <tr>
              
            <td class="FieldLabel1" >
           <div class="FieldPlaceholder TitleOnly">{PLAT_No}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
            {PLAT_No}
            </div>
            </td>
             <td class="FieldLabel1" >
           <div class="FieldPlaceholder TitleOnly">{carclass}</div></td><td class="FieldLabel" ><div class="FieldPlaceholder DataOnly">
            {carclass}
            </div>
            </td>
            </tr>
            <tr>
           
            </tr>
       </td>
    </table>
    
    </td>
    
    
    </tr>
           
          
    </table>
 </fieldset>

 
                            
</div>
