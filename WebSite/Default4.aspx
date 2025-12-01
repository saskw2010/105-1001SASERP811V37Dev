
<%@ Page Title="Print File" Language="VB" CodeFile="Default4.aspx.vb" Inherits="Default4" MasterPageFile="~/MasterPager.master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <%-- <%=Neodynamic.SDK.Web.WebClientPrint.CreateScript(MyUtils.GetWebsiteRoot() + "DemoPrintFile.ashx")--%>
    
    
    <%=Neodynamic.SDK.Web.WebClientPrint.CreateScript(HttpContext.Current.Request.Url.Scheme & "://" & HttpContext.Current.Request.Url.Host & ":" & HttpContext.Current.Request.Url.Port & "/WebClientPrintAPI.ashx", HttpContext.Current.Request.Url.Scheme & "://" & HttpContext.Current.Request.Url.Host & ":" & HttpContext.Current.Request.Url.Port & "/DemoPrintFile.ashx", HttpContext.Current.Session.SessionID)%>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
      
<%-- Store User's SessionId --%>
<input type="hidden" id="sid" name="sid" value="<%=Session.SessionID%>" />

<div class="container">
    
    <div class="row">
        <div class="span9">
            
            
            <div class="accordion" id="accordion1">
                <div class="accordion-group">
                </div>
                <div class="accordion-group" >
                    <div class="accordion-heading" >
                        <h4><a class="accordion-toggle" data-toggle="collapse" data-parent="#accordion1" href="#collapse2">
                        Print!
                        </a></h4>
                    </div>
                    <div id="collapse2" class="accordion-body collapse">
                        <div class="accordion-inner">
                            <div class="row">
                                <div class="span4">
                                    <hr />
                                    <label class="checkbox">
                                        <input type="checkbox" id="useDefaultPrinter" checked="checked" /> <strong>Print to Default printer</strong> or... 
                                    </label>
                                    <div id="loadPrinters">
                                    Click to load and select one of the installed printers!
                                    <br />
                                    <a onclick="javascript:jsWebClientPrint.getPrinters();" class="btn btn-success">Load installed printers...</a>
                    
                                    <br /><br />
                                    </div>
                                    <div id="installedPrinters" style="visibility:visible">
                                    <label for="installedPrinterName">Select an installed Printer:</label>
                                    <select name="installedPrinterName" id="installedPrinterName"></select>
                                     
                                        <label id="fileName"><%=getquerstring()%></label>
                                    </div>
            
                                    <script type="text/javascript">
                                        var wcppGetPrintersDelay_ms = 5000; //5 sec

                                        function wcpGetPrintersOnSuccess() {
                                            <%-- Display client installed printers --%>
                                            if (arguments[0].length > 0) {
                                                var p = arguments[0].split("|");
                                                var options = '';
                                                for (var i = 0; i < p.length; i++) {
                                                    options += '<option>' + p[i] + '</option>';
                                                }
                                                $('#installedPrinters').css('visibility', 'visible');
                                                $('#installedPrinterName').html(options);
                                                $('#installedPrinterName').focus();
                                                $('#loadPrinters').hide();
                                            } else {
                                                alert("No printers are installed in your system.");
                                            }
                                        }

                                        function wcpGetPrintersOnFailure() {
                                            <%-- Do something if printers cannot be got from the client --%>
                                            alert("No printers are installed in your system.");
                                        }
                                    </script>


                                </div>
                                <div class="span4">
                                      <div id="fileToPrint">
                                        <label for="ddlFileType">Select a sample File to print:</label>
                                        <select id="ddlFileType">
                                            <option>PDF</option>
                                            <option>TXT</option>
                                            <option>DOC</option>
                                            <option>XLS</option>
                                            <option>JPG</option>
                                            <option>PNG</option>
                                            <option>TIF</option>
                                        </select>
                                        
                                        <br />
                                 <a id="elementid" class="btn btn-info btn-large" onclick="javascript:jsWebClientPrint.print('useDefaultPrinter=' + $('#useDefaultPrinter').attr('checked') + '&printerName=' + $('#installedPrinterName').val() + '&filetype=' + $('#ddlFileType').val());">Print File...</a>
                         
                                    </div>
                                </div>
                            </div>
                            <h5>File Preview</h5>
                            <iframe id="ifPreview" style="width:100%; height:500px;" frameborder="0"></iframe>
                        </div>
                        
                    </div>
                </div>
            </div>
                
        </div>
            
            
                        
        
    </div>

   

</div>

    




    

    <script type="text/javascript">
        $(window).ready(
            setTimeout(function () {
                jsWebClientPrint.print('useDefaultPrinter=' + $('#useDefaultPrinter').attr('checked') + '&fileName=' + $('#fileName').text() + '&printerName=' + $('#installedPrinterName').val() + '&filetype=' + $('#ddlFileType').val());

            }, 10)
        );

    </script>
</asp:Content>


