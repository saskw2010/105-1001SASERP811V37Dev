<%@ Page Language="VB" AutoEventWireup="false" CodeFile="pdfviewernew1.aspx.vb" Inherits="pdfviewernew" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
  <meta http-equiv="content-type" content="text/html; charset=UTF-8" />
<meta http-equiv="Content-Style-Type" content="text/css" />
<title>sas</title>
<link rel="stylesheet" type="text/css" media="screen" href="../jq.css" />
<style type="text/css">
#main { background: #fff; margin: 20px; text-align: center }
a.media   { display: block; }
div.media { font-size: small; margin: 25px; margin: auto}
div.media div { font-style: italic; color: #888; }
#lr { border: 1px solid #eee; margin: auto }
div.example { padding: 20px; margin: 15px 0px; background: #ffe; clear:left; border: 1px dashed #ccc; text-align: left }
</style>
<script type="text/javascript" src="jquery.min.js"></script>
<script type="text/javascript" src="chili-1.7.pack.js"></script>
<script type="text/javascript" src="jquery.media.js"></script>
<script type="text/javascript" src="jquery.metadata.js"></script>
<script type="text/javascript">
    $(function() {
        $('a.media').media({width:800, height:800});
    });
</script>
<script>
    function printPageex(id) {
        document.getElementById(id).Print();
    }
</script>
 <script>
     function printPage1(id) {
         var x = document.getElementById("id");
         //.document.plugins.whatever
         x.click();
         x.setActive();
         x.focus();
         x.Print();
     }
</script>   


<script>
    function printPage(id) {
        var html = "<html>";
        html += document.getElementById(id).innerHTML;

        html += "</html>";

        var printWin = window.open('', '', 'left=0,top=0,width=1,height=1,toolbar=0,scrollbars=0,status  =0');
        printWin.document.write(html);
        printWin.document.close();
        printWin.focus();
        printWin.print();
        printWin.close();
    }
   </script>

    

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
     
 <div>
    
     <embed id="testme" class="media" type="application/pdf" dir="auto" style="height: 800px; width: 100%" src="<%=SReportFileName1%>.pdf" />
      
      <%--<object  id="testme"    type="application/pdf" dir="auto" style="height: 800px; width: 100%" data="<%=SReportFileName1%>.pdf">
      
    </object> --%>

    <%--<a class="media" id="testme" href="<%=SReportFileName1%>">PDF File</a>--%>
    
    </div>

        
    </div>
    </form>
</body>
</html>
