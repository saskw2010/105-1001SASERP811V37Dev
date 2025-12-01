<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Login.ascx.vb" Inherits="Controls_Login"  %>              
   <style>
            .div
             {

                direction:ltr;
            }


        </style>
<script src="w3.js"></script>

<div id="LoginControl"   data-app-role="page"   data-content-framework="bootstrap " dir="ltr" >
 <div data-role="content" dir="ltr"> 
  <div class="fullscreen_bgqlogin" dir="ltr"/>
 <div id="regContainer" class="container" dir="ltr">
    
 <div id="firstdiv" class="row" dir="ltr"> 
 
    <br />

   </div>
 
 <div id="seconddiv" class="row" dir="ltr">
 <div class="col-sm-3" id="loginl1box" > 
 <div w3-include-html="realstatel1.html"></div> 
 </div>
 <div id="loginboxall" class="col-sm-6"> 
	       <div class="panel-login">
           
            
             
                   <div class="panel-login panel-heading">
                       <span></span>
             <div   id="loginlogo"  >
            
            </div>
             
              
          
          </div>  
</div>
          
<div class="panel-login panel-body">
   <div class="row">
<div class="col-sm-1">
</div>
<div class="col-sm-10">


<div class="panel-login panel-success">
                        <div class="panel-heading">
   
  
 
  <div id="AiOptimal" >
      
      <span><i class="info-box-number"> Ai Optimal Enterprise Solutions </i></span>

   
     
    

</div>
 </div>
               
    
    
    
    
                    <div class="panel-body text-center">
                        <form id="loginForm" runat="server">
                            <div class="form-group">
                                <asp:TextBox ID="txtUsername" runat="server" placeholder="Username" CssClass="form-control" Width="100%" />
                                <asp:RequiredFieldValidator ID="rfvUsername" runat="server" 
                                    ControlToValidate="txtUsername" 
                                    ErrorMessage="اسم المستخدم مطلوب" 
                                    Display="Dynamic" 
                                    CssClass="text-danger" />
                            </div>
                            <div class="form-group">
                                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password" CssClass="form-control" Width="100%" />
                                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                                    ControlToValidate="txtPassword" 
                                    ErrorMessage="كلمة المرور مطلوبة" 
                                    Display="Dynamic" 
                                    CssClass="text-danger" />
                            </div>
                            
                            <!-- Error Message Panel -->
                            <asp:Panel ID="pnlError" runat="server" Visible="false" CssClass="alert alert-danger">
                                <asp:Literal ID="litError" runat="server" />
                            </asp:Panel>
						
                            <div class="col text-center">
                                <asp:Button ID="btnLogin" runat="server" Text="تسجيل الدخول" 
                                    CssClass="btn btn-primary btn-lg text-center" 
                                    OnClick="btnLogin_Click" />
                            </div>
                        </form>

 </div> 
  

                        </div>
						

                         
   <div class="panel-heading">
   
  
 
  <div >
     

 <button id="forget-Password" type="button" class="btn  active btn-secondary btn-lg text-center" onclick="javascript:Web.Membership._instance.passwordRecovery();" dir="ltr">Forget Password?</button>

   <div id="WytSkyClouding">   
     <span><i class="info-box-number"> WytSky Clouding Solutions </i></span>  
    </div>
      <div id="Versionlight">   
 <span class="info-box-number active"><i class="btn btn-primary btn-lg" role="button"> Ver.SKYsaas.2020 </i> </span>
   </div>
  <div id="Picreqid">      
    
      </div>
</div>
                        </div>
        

 </div>

    
 </div>
  
  <div class="col-sm-2">
</div>     
        </div>
        </div>
      </div>
   
 
 <div class="col-sm-3" id="loginr1box" > 
 <div w3-include-html="realstater1.html" id="loginr1boxline"></div> 
 </div>
 
 
 </div>
 


 <div class="row container" dir="ltr">  



<div w3-include-html="realstatedown.html"  id="logindown"></div> 
  
  
  </div>

 </div>
 
  
  </div>
 
 </div>
   

 


<!-- JavaScript removed for security - Server-side authentication is now used -->
<script>
w3.includeHTML();
</script>

  
            