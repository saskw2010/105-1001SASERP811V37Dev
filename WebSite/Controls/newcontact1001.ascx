<%@ Control Language="VB" AutoEventWireup="false" CodeFile="newcontact1001.ascx.vb" Inherits="Controls_newcontact1001" %>
<%--<dxchartsui:WebChartControl ID="WebChartControl1" runat="server" CrosshairEnabled="True" DataSourceID="SqlDataSource1" Height="829px" Width="1052px">
    <diagramserializable>
        <cc1:XYDiagram PaneDistance="5" PaneLayoutDirection="Horizontal" Rotated="True">
            <axisx visibleinpanesserializable="-1">
                <label angle="45" enableantialiasing="True" staggered="True">
                    <resolveoverlappingoptions allowhide="False" />
                </label>
            </axisx>
            <axisy visibleinpanesserializable="-1">
            </axisy>
            <defaultpane weight="0.8">
            </defaultpane>
        </cc1:XYDiagram>
    </diagramserializable>
    <legend usecheckboxes="True"></legend>
    <seriesserializable>
        <cc1:Series ArgumentDataMember="CreatedBy" ArgumentScaleType="Qualitative" LabelsVisibility="True" LegendText="Document " Name="Series 1" SummaryFunction="COUNT()">
            <labelserializable>
                <cc1:SideBySideBarSeriesLabel  Position="TopInside" ShowForZeroValues="True">
                    <shadow visible="True" />
                    <pointoptionsserializable>
                        <cc1:PointOptions>
                            <valuenumericoptions format="Number" precision="3" />
                        </cc1:PointOptions>
                    </pointoptionsserializable>
                </cc1:SideBySideBarSeriesLabel>
            </labelserializable>
            <legendpointoptionsserializable>
                <cc1:PointOptions>
                    <valuenumericoptions format="Number" precision="3" />
                </cc1:PointOptions>
            </legendpointoptionsserializable>
        </cc1:Series>
    </seriesserializable>
</dxchartsui:WebChartControl>--%>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ezee %>" SelectCommand="SELECT * FROM [EVOL_Memo]"></asp:SqlDataSource>

