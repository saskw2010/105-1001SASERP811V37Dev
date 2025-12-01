<%@ Control Language="VB" AutoEventWireup="false" CodeFile="wexreportpdf.ascx.vb" Inherits="Controls_wexreportpdf"  %>
<%@ Register Assembly="Stimulsoft.Report.MobileDesign" Namespace="Stimulsoft.Report.MobileDesign" TagPrefix="cc1" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc2" %>

<div class="ParaHeader">
</div>
<div class="ParaInfo">
    

   <table dir="ltr">
  <tr>
   <td>
     

<asp:Button ID="Button1" runat="server" Font-Bold="False" Font-Names="Arial" 
            Font-Size="12pt" Height="28px" OnClick="Button1_Click" Text="Design" 
            Width="140px" />
<asp:Button ID="Button2" runat="server" Font-Bold="False" Font-Names="Arial" 
            Font-Size="12pt" Height="28px" OnClick="Button2_Click" Text="printme" 
            Width="140px" />
			<asp:Button ID="Button3" runat="server" Font-Bold="False" Font-Names="Arial" 
            Font-Size="12pt" Height="28px" OnClick="Button3_Click" Text="download" 
            Width="140px" />
     <asp:Label ID="ReportNameLabel" runat="server" Font-Names="Arial" Visible="False" />
               <asp:TextBox ID="ReportNameTextBox" runat="server" />
        <asp:Button ID="SaveReportButton" runat="server" 
            OnClick="SaveReportButton_Click" Text="Save" Visible="False" />
    
       <br />
       <asp:Panel ID="SavePanel123" runat="server" BackColor="#c0c0c0" 
        BorderStyle="Solid" BorderWidth="1" Height="900px"  
        Width="100%">
<cc1:StiMobileDesigner ID="StiWebDesigner1" runat="server"
           OnSaveReport="StiWebDesigner1_SaveReport" />
<cc2:stiwebviewer ID="StiWebViewer1"  runat="server"   Width="100%" 
Height="800px"  ToolBarBackColor="SteelBlue"     RenderMode="AjaxWithCache" ScrollBarsMode="True" PdfStandardFonts="True" ShowExportToBmp="False" ShowExportToDbf="False" ShowExportToDif="False" ShowExportToGif="False" ShowExportToJpeg="False" ShowExportToMetafile="False" ShowExportToMht="False" ShowExportToOds="False" ShowExportToOdt="False" ShowExportToPcx="False" ShowExportToRtf="False" ShowExportToSvg="False" ShowExportToSvgz="False" ShowExportToSylk="False" ShowExportToText="False" ShowExportToTiff="False" ShowExportToXml="False" ShowExportToXps="False" ShowMenuAnimation="False" ShowPageShadow="False" ShowViewMode="True" ToolbarAlignment="Center" XpsShowDialog="False" ServerTimeOut="01:30:00" CacheMode="StringSession" />

   </asp:Panel>
   
     </td> 
   </tr> 
   </table>
   

   

<div class="ParaHeader">
</div>

   </div>