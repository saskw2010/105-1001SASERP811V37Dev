<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Expires.aspx.vb" Inherits="Help_Expires" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
 <%-- <link rel="stylesheet" href="../css/StyleSheet.css" />--%>
  <link rel="stylesheet" href="../invcss/StyleSheetinvcss.css" />
  <link rel="stylesheet" href="../invcss/sidnavbar.css" />
 <title>SKY SaaSExpire Licsense</title>
  <script type="text/javascript" src="../invjs/help.js"></script>
  <script src="w3.js"></script>
</head>
<body>
    <form id="form1" runat="server">


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
   
        <div class="row upcontent">   
 
    
<div calss="uprowcontent" w3-include-html="nav1.html"></div>  
  
  
  </div>	
         <div class="row midsupport"> 
            call technical support 
            info@wytsky.com
        </div>
        <div class="row midcontent"> 
        <div calss="midrowcontent" w3-include-html="nav2.html"></div> 
            </div> 
        <div class="row downcontent">   
 
    
<div  calss="downrowcontent"  w3-include-html="nav3.html"></div>  
  
  
  </div>	
    </form>
     <script>
w3.includeHTML();
     </script>
</body>
</html>
