<%@ Control Language="VB" AutoEventWireup="false" CodeFile="mycharts.ascx.vb" Inherits="Controls_mycharts" %>
<%--<%@ Register assembly="DevExpress.XtraCharts.v17.1.Web, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts.Web" tagprefix="dx" %>
<%@ Register assembly="DevExpress.XtraCharts.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts" tagprefix="dx" %>

<dx:WebChartControl ID="WebChartControl2" runat="server" CrosshairEnabled="True" Height="488px" Width="1144px" DataSourceID="SqlDataSource1">
    <DiagramSerializable>
        <dx:XYDiagram>
            <axisx visibleinpanesserializable="-1">
            </axisx>
            <axisy visibleinpanesserializable="-1">
            </axisy>
        </dx:XYDiagram>
    </DiagramSerializable>
<Legend Name="Default Legend"></Legend>
    <SeriesSerializable>
        <dx:Series Name="Series 1" ArgumentDataMember="CreatedBy" ArgumentScaleType="Qualitative" LabelsVisibility="True" LegendText="Document "  SummaryFunction="COUNT()">
        </dx:Series>
    </SeriesSerializable>
</dx:WebChartControl>--%>


