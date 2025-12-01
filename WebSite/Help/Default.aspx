<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="Help_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8" />
  <meta http-equiv="X-UA-Compatible" content="IE=edge" />
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
  <link rel="stylesheet" href="Fortestcss/bootstrap/bootstrap.min.css" />
 
  <link rel="stylesheet" href="Fortestcss/dist/css/AdminLTE.min.css" />
  <script src="w3.js"></script>

    <title></title>
    <style type="text/css">
        div.Help
        {
            font-family: Calibri,Tahoma;
            font-size: small;
            padding: 4px;
        }
    </style>
    <link rel="stylesheet" type="text/css" href="css/elastislide.css" />
    
    <script type="text/javascript" src="js/modernizr.custom.17475.js"></script>

   <style type="text/css">
        #divEmployees
        {
            font-family:Arial, Verdana, Sans-Serif;
            font-size:12px;
            padding:10px;
            border:solid 1px #0066CC;
        }
        
        #divEmployees .detail
        {
            border-bottom:dashed 1px #0066CC;
            margin-bottom:10px;
            padding:10px;
        }
    </style>
</head>
<body style="margin: 0px; padding: 0px;">
    <form id="form1" runat="server">
   <div id="LoginControl" data-app-role="page" data-activator="Button|Login" dir="ltr" data-content-framework="bootstrap">
 <div data-role="content"> 
    <div class="container">
    <div class="navbar navbar-default navbar-static-top"  role="navigation" style="width: 100%">
 <div class="row">   
 
    
<div w3-include-html="help1.html"></div>  
  
  
  </div>
        
     </div></div></div></div>
         <div class="Help">
<div class="row">        
        
        <div class="ParaHeader">
          
           Kuwait :  <a href="http://www.whitesky.ca">whitesky Solutions</a> -  <a href="mailto:info@whitesky.ca"> Mail Us </a> Kuwait Tel(+965): 50510300 - 55340435- 90907209 
       
         </div>
        <div class="ParaHeader">
           Egypt :  <a href="http://www.saskw.net">SAS Solutions</a> -  <a href="mailto:info@whitesky.ca"> Mail Us </a> Egypt Tel(+2): 01002389000 - 01092912905   <a href="http://agikw.com">      demo site  </a>
          </div>
        <div class="ParaHeader">
        <div class="container demo-1">
        <div class="main">
       <ul id="carousel" class="elastislide-list">
  <asp:Repeater ID="mylist" runat="server">
      <HeaderTemplate>
           <div id="divEmployees">
                <%# Eval("Title") %>" 
        </HeaderTemplate>
    <ItemTemplate>
        <div class="detail">
        <li><a href="#">
       
       <object width="427" height="258">
            <param name="movie" value="http://www.youtube.com/v/<%# Eval("VideoId")%>"></param>
            <param name="allowFullScreen" value="true"></param>
            <param name="allowscriptaccess" value="always"></param>
            <param name="wmode" value="opaque"></param>
            <embed src="http://www.youtube.com/v/<%# Eval("VideoId") %>?" type="application/x-shockwave-flash" width="427" height="258" allowscriptaccess="always" allowfullscreen="true" wmode="opaque"></embed>
          </object>
     </a></li>
             </div>
    </ItemTemplate>
       <FooterTemplate>
                </div>
            </FooterTemplate>
      </asp:Repeater>
            </ul>
        </div>
    </div>
   
 
</div>
  </div>      
    </div>
	
<div class="row">   
 
    
<div w3-include-html="help2.html"></div>  
  
  
  </div>	
    </form>
    <script>
w3.includeHTML();
</script>
</body>
</html>



       

     

 <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
    <script type="text/javascript" src="js/jquerypp.custom.js"></script>
    <script type="text/javascript" src="js/jquery.elastislide.js"></script>
    <script type="text/javascript">
        $('#carousel').elastislide();
        </script>