<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Dynwexreport.ascx.vb" Inherits="Dynwexreport"  %>
<%@ Register Assembly="Stimulsoft.Report.MobileDesign" Namespace="Stimulsoft.Report.MobileDesign" TagPrefix="cc1" %>
<%@ Register assembly="Stimulsoft.Report.Web" namespace="Stimulsoft.Report.Web" tagprefix="cc2" %>

<div>
<asp:Button ID="Button1" runat="server" Font-Bold="False" Font-Names="Arial" 
            Font-Size="12pt" Height="28px" OnClick="Button1_Click" Text="Design" 
            Width="140px" />

    <asp:Panel ID="SavePanel" runat="server" BackColor="#c0c0c0" 
        BorderStyle="Solid" BorderWidth="1" Height="40px" Visible="false" 
        Width="491px">
        <asp:Label ID="ReportNameLabel" runat="server" Font-Names="Arial" />
               <asp:TextBox ID="ReportNameTextBox" runat="server" />
        <asp:Button ID="SaveReportButton" runat="server" 
            OnClick="SaveReportButton_Click" Text="Save" />
        
    </asp:Panel>
   
   
</div><cc1:StiMobileDesigner ID="StiWebDesigner1" runat="server"
           OnSaveReport="StiWebDesigner1_SaveReport" />
       <cc2:stiwebviewer ID="StiWebViewerFx1"  runat="server"   Width="100%" 
Height="800px"  ToolBarBackColor="SteelBlue"     RenderMode="AjaxWithCache" ScrollBarsMode="True" PdfStandardFonts="True" ShowExportToBmp="False" ShowExportToDbf="False" ShowExportToDif="False" ShowExportToGif="False" ShowExportToJpeg="False" ShowExportToMetafile="False" ShowExportToMht="False" ShowExportToOds="False" ShowExportToOdt="False" ShowExportToPcx="False" ShowExportToRtf="False" ShowExportToSvg="False" ShowExportToSvgz="False" ShowExportToSylk="False" ShowExportToText="False" ShowExportToTiff="False" ShowExportToXml="False" ShowExportToXps="False" ShowMenuAnimation="False" ShowPageShadow="False" ShowViewMode="True" ToolbarAlignment="Center" XpsShowDialog="False" ServerTimeOut="01:30:00" CacheMode="StringSession" ShowExportToCsv="False" ShowExportDialog="False" ShowEmailExportDialog="False" ShowEmailDialog="False" ShowDesignButton="False" ShowEditorButton="False" ShowExportToDocument="False" ShowExportToExcel="False" ShowExportToExcel2007="False" ShowExportToExcelXml="False" ShowExportToHtml="False" ShowExportToHtml5="False" ShowExportToImageBmp="False" ShowExportToImageGif="False" ShowExportToImageJpeg="False" ShowExportToImageMetafile="False" ShowExportToImagePcx="False" ShowExportToImagePng="False" ShowExportToImageSvg="False" ShowExportToImageSvgz="False" ShowExportToImageTiff="False" ShowExportToOpenDocumentCalc="False" ShowExportToOpenDocumentWriter="False" ShowExportToWord2007="False" />


