<%@ Control Language="VB" AutoEventWireup="false" CodeFile="customsearch.ascx.vb" Inherits="Controls_customsearch"  %>

<%@ Register assembly="Stimulsoft.Report.MobileDesign, Culture=neutral, PublicKeyToken=ebe6666cba19647a" namespace="Stimulsoft.Report.MobileDesign" tagprefix="cc1" %>
<%@ Register assembly="Stimulsoft.Report.Web,  PublicKeyToken=ebe6666cba19647a" namespace="Stimulsoft.Report.Web" tagprefix="cc2" %>
<%@ Register assembly="Stimulsoft.Report.Mobile,  PublicKeyToken=ebe6666cba19647a" namespace="Stimulsoft.Report.Mobile" tagprefix="cc3" %>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
 <div style="margin:2px;border: solid 1px silver;padding:8px;">
            <cc3:StiMobileViewer ID="StiMobileViewer1" runat="server" />
            <cc2:StiWebViewer ID="StiWebViewer1" runat="server" />
            <cc1:StiMobileDesigner ID="StiMobileDesigner1" runat="server" />
            <cc2:StiWebViewerFx ID="StiWebViewerFx1" runat="server" />
 </div>

    </ContentTemplate>


</asp:UpdatePanel>




