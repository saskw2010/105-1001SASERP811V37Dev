<%@ Control Language="VB" AutoEventWireup="false" CodeFile="registerstatictic.ascx.vb" Inherits="Controls_registerstatictic"  %>
<%--<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register assembly="DevExpress.XtraCharts.v17.1.Web, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts.Web" tagprefix="dxchartsui" %>
<%@ Register assembly="DevExpress.XtraCharts.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts" tagprefix="cc1" %>--%>


<%--<div class="ParaHeader" style="text-align: center">
    <h1><strong>إحصائيات التسجيل بالمدارس </strong></h1>
  
</div>
<div class="ParaHeader" style="text-align: center">
<div class="ParaInfo" style="text-align: center">
    <div style="float: left; width: 100%; margin-right: 2%; height: 100%;">
        <dx:ASPxPageControl ID="carTabPage" runat="server" ActiveTabIndex="0"  EnableTabScrolling="True" EnableTheming="True" Theme="Youthful" Height="100%">
            <TabPages >
                <dx:TabPage Text="الميزانية التقديرية والتسجيل الفعلي">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <div class="ParaHeader">
    <dx:ASPxPivotGridExporter ID="ASPxPivotGridExporter2" runat="server" ASPxPivotGridID="ASPxPivotGrid1">
        <OptionsPrint>
            <PageSettings PaperKind="A4" />
        </OptionsPrint>
    </dx:ASPxPivotGridExporter>
    <dx:ASPxButton ID="ASPxButton4" runat="server" Text="Export TO Excel" Theme="Youthful">
    </dx:ASPxButton>
    <dx:ASPxButton ID="ASPxButton5" runat="server" Text="Export TO pdf" Theme="Youthful">
    </dx:ASPxButton>
    <dx:ASPxButton ID="ASPxButton6" runat="server" Text="Export TO XLsx" Theme="Youthful">
    </dx:ASPxButton>
</div>
<div class="ParaInfo">

 <dx:ASPxPivotGrid ID="ASPxPivotGrid2" runat="server" Caption="الميزانية التقديرية والتسجيل الفعلي " 
               ClientIDMode="AutoID" ClientInstanceName="pivotGrid"     Height="100%"    DataSourceID="SqlDataSource2" EnableTheming="True"      Theme="Aqua">
               <Prefilter Enabled="False" />
               <Fields>
			   <dx:pivotgridfield ID="fieldTargetClasscount" Area="DataArea" AreaIndex="2" FieldName="TargetClasscount"  
                       Options-ShowGrandTotal="True" SummaryType="sum" Caption="هدف عدد الفصول" Options-AllowExpand="False" Options-AllowFilter="False" Options-AllowFilterBySummary="False" Options-AllowSortBySummary="False"> 
                                      </dx:PivotGridField>
               <dx:pivotgridfield ID="fieldTargetstudentcount" Area="DataArea" AreaIndex="0" FieldName="Targetstudentcount"  Options-ShowGrandTotal="True" 
                       SummaryType="sum" Caption="هدف اعداد الطلاب"> 
                                      </dx:PivotGridField>									  
               <dx:pivotgridfield ID="fieldbranch2" AreaIndex="2" FieldName="branch"  Options-ShowGrandTotal="True" 
                       SummaryType="sum" Area="RowArea" Caption="كود الفرع"> 
                                      </dx:PivotGridField>
                    <dx:pivotgridfield ID="fieldschBranchDesc12" AreaIndex="3" FieldName="schBranchDesc1"  Options-ShowGrandTotal="True" 
                       SummaryType="sum"  Area="RowArea" Caption="اسم المدرسة او الفرع "> 
                                      </dx:PivotGridField>	

                   <dx:pivotgridfield ID="fieldschGradeShortDesc1" Area="RowArea" AreaIndex="4" 
                       FieldName="schGradeShortDesc1" Options-ShowGrandTotal="True" Caption="الصف ">
                   </dx:PivotGridField>
                   <dx:PivotGridField ID="fieldrealclasscount" Area="DataArea" AreaIndex="3" FieldName="realclasscount" Caption="عدد الفصول الحالية">
                   </dx:PivotGridField>
                   <dx:PivotGridField ID="fieldregistercount" Area="DataArea" AreaIndex="1" FieldName="registercount" Caption="عدد الطلاب المسجل">
                   </dx:PivotGridField>
                   <dx:PivotGridField ID="fieldsgmNm1" Area="RowArea" AreaIndex="1" Caption="القطاع" FieldName="sgm_Nm">
                   </dx:PivotGridField>
                   <dx:PivotGridField ID="fieldsgm2" Area="RowArea" AreaIndex="0" Caption="كود القطاع" FieldName="sgm" Options-AllowExpand="False" Options-AllowFilter="False" Options-AllowFilterBySummary="False" Options-AllowSortBySummary="False" Options-ShowCustomTotals="False" Options-ShowGrandTotal="False" Options-ShowInCustomizationForm="False" Options-ShowInPrefilter="False" Options-ShowTotals="False" Options-ShowValues="False">
                   </dx:PivotGridField>
                   <dx:PivotGridField ID="fieldregpercentage" Area="RowArea" AreaIndex="5" FieldName="regpercentage" TotalsVisibility="None">
                   </dx:PivotGridField>
               </Fields>
                <OptionsView ShowHorizontalScrollBar="True" />
        <OptionsFilter NativeCheckBoxes="True" />
        <OptionsLoadingPanel Text="Loading&amp;hellip;" />
               <OptionsPager NumericButtonCount="30" RowsPerPage="120">
                   <Summary Position="Right" Text="الصفحة  {0} of {1} ({2} السجلات)" />
               </OptionsPager>
               <OptionsData AutoExpandGroups="true" />
      </dx:ASPxPivotGrid>

 <asp:SqlDataSource ID="SqlDataSource2" 
            SelectCommand="SELECT * FROM [QschRegDashBoardcompare] where AcademicYearto=52"
            runat="server" ConnectionString="<%$ ConnectionStrings:eZee %>"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource3" 
           SelectCommand="SELECT SUM([Targetstudentcount])- SUM([registercount]) as valucolmun,'المتبقي ' as Titlecolmun FROM [QschRegDashBoardcompare1001] union all    SELECT   SUM([registercount]) as valucolmun,'التسجيل ' as Titlecolmun FROM [QschRegDashBoardcompare1001]  "

         runat="server" ConnectionString="<%$ ConnectionStrings:eZee %>"></asp:SqlDataSource>
<asp:SqlDataSource ID="SqlDataSource4" 
            SelectCommand="SELECT * FROM [QschRegDashBoardcompare1001]"
            runat="server" ConnectionString="<%$ ConnectionStrings:eZee %>"></asp:SqlDataSource>

</div>
     





                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="احصائية التسجيل بالمدارس">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            
<div class="ParaHeader" style="text-align: center">
    <dx:ASPxPivotGridExporter ID="ASPxPivotGridExporter1" runat="server" ASPxPivotGridID="ASPxPivotGrid1">
        <OptionsPrint>
            <PageSettings PaperKind="A4" />
        </OptionsPrint>
    </dx:ASPxPivotGridExporter>
    <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Export TO Excel" Theme="Youthful">
    </dx:ASPxButton>
    <dx:ASPxButton ID="ASPxButton2" runat="server" Text="Export TO pdf" Theme="Youthful">
    </dx:ASPxButton>
    <dx:ASPxButton ID="ASPxButton3" runat="server" Text="Export TO XLsx" Theme="Youthful">
    </dx:ASPxButton>
</div>
<div class="ParaInfo" style="text-align: center">

 <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" Caption="احصائية التسجيل بالمدارس " 
               ClientIDMode="AutoID" ClientInstanceName="pivotGrid" 
                 DataSourceID="SqlDataSource1" EnableTheming="True"  Width="100%" Height="100%"
        Theme="Aqua" >
              
               <Fields>
			   
									  <dx:pivotgridfield ID="fieldsgm" Area="RowArea" AreaIndex="0" FieldName="sgm" Caption="-" Options-AllowDrag="False" Options-AllowDragInCustomizationForm="False" Options-AllowExpand="False" Options-AllowFilter="False" Options-AllowFilterBySummary="False" Options-AllowSortBySummary="False" Options-ShowCustomTotals="False" Options-ShowGrandTotal="False" Options-ShowInCustomizationForm="False" Options-ShowInPrefilter="False" Options-ShowTotals="False" Options-ShowValues="False" TotalsVisibility="None" > 
                                      </dx:PivotGridField>	
									  <dx:pivotgridfield ID="fieldsgmNm" Area="RowArea" AreaIndex="1" FieldName="sgm_Nm"  
                       Options-ShowGrandTotal="True" SummaryType="sum" Caption="القطاع"> 
                                      </dx:PivotGridField>
									   <dx:pivotgridfield ID="fieldbranch" Area="RowArea" AreaIndex="2" FieldName="branch" Caption="-" Options-AllowDrag="False" Options-AllowDragInCustomizationForm="False" Options-AllowExpand="False" Options-AllowFilter="False" Options-AllowFilterBySummary="False" Options-AllowSortBySummary="False" Options-ShowCustomTotals="False" Options-ShowGrandTotal="False" Options-ShowInCustomizationForm="False" Options-ShowInPrefilter="False" Options-ShowTotals="False" Options-ShowValues="False" > 
                                      </dx:PivotGridField>	
               								  
               <dx:pivotgridfield ID="fieldschBranchDesc1" AreaIndex="3" FieldName="schBranchDesc1"  Options-ShowGrandTotal="True" 
                       SummaryType="sum" Area="RowArea" Caption="اسم المدرسة او الفرع    "> 
                                      </dx:PivotGridField>
                    <dx:pivotgridfield ID="fieldGradeCode" AreaIndex="4" FieldName="GradeCode"  Options-ShowGrandTotal="False" 
                       SummaryType="sum" Caption=" كود الصف" Options-AllowDrag="False" Options-AllowDragInCustomizationForm="False" Options-AllowExpand="False" Options-AllowFilter="False" Options-AllowFilterBySummary="False" Options-AllowSortBySummary="False" Options-ShowCustomTotals="False" Options-ShowInCustomizationForm="False" Options-ShowInPrefilter="False" Options-ShowTotals="False" Options-ShowValues="False" > 
                                      </dx:PivotGridField>	
				<dx:pivotgridfield ID="fieldShortDesc1" Area="ColumnArea" AreaIndex="0" FieldName="ShortDesc1" Options-ShowGrandTotal="True" 
                       SummaryType="sum" Caption="المرحلة">
                   </dx:PivotGridField>
				  
				<dx:pivotgridfield ID="fieldCntryNm" AreaIndex="0" 
                       FieldName="Cntry_Nm" Options-ShowGrandTotal="True" SummaryType="sum" Caption="الجنسية ">
                   </dx:PivotGridField>   
				  <dx:pivotgridfield ID="fieldGender" AreaIndex="1" FieldName="Gender" Caption="النوع"  >
                      
                   </dx:PivotGridField>
                   <dx:pivotgridfield ID="fieldApplicationCodeauto" AreaIndex="0" FieldName="ApplicationCodeauto" Options-ShowGrandTotal="True" 
                       SummaryType="Count" Area="DataArea" Caption="عدد التسجيل" >
                   </dx:PivotGridField>

                   <dx:pivotgridfield ID="fieldschtrnsDesc" AreaIndex="2" 
                       FieldName="schtrnsDesc" Options-ShowGrandTotal="True" Caption="تسجيل جديد- اعادة تسجيل">
                   </dx:PivotGridField>
                                      <dx:PivotGridField ID="fieldExpr1" AreaIndex="3" Caption="الصف" FieldName="Expr1">
                                      </dx:PivotGridField>
               </Fields>
               <OptionsView ShowHorizontalScrollBar="True" />
        <OptionsFilter NativeCheckBoxes="True" />
        <OptionsLoadingPanel Text="Loading&amp;hellip;" />
               <OptionsPager NumericButtonCount="30" RowsPerPage="120">
                   <Summary Position="Right" Text="الصفحة  {0} of {1} ({2} السجلات)" />
               </OptionsPager>
               <OptionsData AutoExpandGroups="true" />
      </dx:ASPxPivotGrid>

 <asp:SqlDataSource ID="SqlDataSource1" 
            SelectCommand="SELECT * FROM [QschRegDashBoard] where AcademicYearto=52 "
            runat="server" ConnectionString="<%$ ConnectionStrings:eZee %>"></asp:SqlDataSource>
</div>



                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="النسبة العامة للتسجيل للعام 2016-2017">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl1" runat="server">
                               <div>
                                   <br />

     <dxchartsui:WebChartControl ID="WebChartControl3" runat="server" AutoBindingSettingsEnabled="False" CrosshairEnabled="True" DataSourceID="SqlDataSource3"  SeriesSorting="Descending"  AppearanceNameSerializable="Light" PaletteName="Concourse" Height="562px" Width="987px">
        <diagramserializable>
            <cc1:SimpleDiagram3D RotationMatrixSerializable="1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1" LayoutDirection="Vertical">
            </cc1:SimpleDiagram3D>
        </diagramserializable>
        <legend  maxhorizontalpercentage="30" alignmenthorizontal="LeftOutside" usecheckboxes="True">
           
        </legend>
         <seriesserializable>
             <cc1:Series ArgumentDataMember="Titlecolmun" LabelsVisibility="True" LegendText="عدد المسجلين" Name="Series 1" SynchronizePointOptions="False" SeriesPointsSorting="Descending" SeriesPointsSortingKey="Value_1" ArgumentScaleType="Qualitative" ValueDataMembersSerializable="valucolmun" CheckableInLegend="False" CheckedInLegend="False" ShowInLegend="False">
                 <viewserializable>
                     <cc1:Pie3DSeriesView SizeAsPercentage="100">
                     </cc1:Pie3DSeriesView>
                 </viewserializable>
                 <labelserializable>
                     <cc1:Pie3DSeriesLabel >
                         <pointoptionsserializable>
                             <cc1:PiePointOptions PercentOptions-PercentageAccuracy="3" PointView="ArgumentAndValues">
                                 <valuenumericoptions format="Percent" Precision="3" />
                             </cc1:PiePointOptions>
                         </pointoptionsserializable>
                     </cc1:Pie3DSeriesLabel>
                 </labelserializable>
                 <legendpointoptionsserializable>
                     <cc1:PiePointOptions PercentOptions-PercentageAccuracy="3" PercentOptions-ValueAsPercent="False" PointView="ArgumentAndValues">
                         <valuenumericoptions format="Number" Precision="3" />
                     </cc1:PiePointOptions>
                 </legendpointoptionsserializable>
                 <topnoptions showothers="False" thresholdvalue="11156" />
             </cc1:Series>
         </seriesserializable>
        <seriestemplate argumentscaletype="Qualitative" seriespointssorting="Ascending" seriespointssortingkey="Value_1">
            <viewserializable>
                <cc1:Pie3DSeriesView SizeAsPercentage="100">
                </cc1:Pie3DSeriesView>
            </viewserializable>
            <labelserializable>
                <cc1:Pie3DSeriesLabel>
                    <pointoptionsserializable>
                        <cc1:PiePointOptions>
                            <valuenumericoptions format="General" />
                        </cc1:PiePointOptions>
                    </pointoptionsserializable>
                </cc1:Pie3DSeriesLabel>
            </labelserializable>
            <legendpointoptionsserializable>
                <cc1:PiePointOptions>
                    <valuenumericoptions format="General" />
                </cc1:PiePointOptions>
            </legendpointoptionsserializable>
        </seriestemplate>




    </dxchartsui:WebChartControl>
        </div>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="مقارنة القطاعات  باعداد التسجيل">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl2" runat="server">
                            

                            <div class="ParaInfo">
<asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource5" Height="575px" Width="947px" IsMapAreaAttributesEncoded="True" Palette="Bright" RightToLeft="Yes">
    <Series>
        <asp:Series ChartType="Pie" Name="Series1" XValueMember="sgm_Nm" YValueMembers="counterst" IsValueShownAsLabel="True" Label="#VALX" LabelAngle="25" LabelToolTip=" #PERCENT" Legend="Legend1" LegendText="#VALX  --   #VAL" YValueType="Double">
            <SmartLabelStyle CalloutStyle="Box" IsMarkerOverlappingAllowed="True" MaxMovingDistance="50" />
        </asp:Series>
    </Series>
    <ChartAreas>
        <asp:ChartArea Name="ChartArea1">
        </asp:ChartArea>
    </ChartAreas>
    <Legends>
        <asp:Legend DockedToChartArea="ChartArea1" ItemColumnSeparator="ThickGradientLine" Name="Legend1" TableStyle="Tall">
        </asp:Legend>
    </Legends>
</asp:Chart>
<asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:eZee %>" SelectCommand="select sgm_Nm,sgm,sum(counterst) as counterst from 
(SELECT glmulcmp.sgm_Nm, schBranch.sgm, 1 counterst FROM glmulcmp RIGHT OUTER JOIN schBranch ON glmulcmp.sgmid = schBranch.sgm RIGHT OUTER JOIN schApplication ON schBranch.branch = schApplication.branch WHERE (schApplication.Schtransferid = 1 and schApplication.AcademicYearto=52) )as table_1 group by sgm_Nm,sgm"></asp:SqlDataSource>
 
</div>
      <br />


                            <div>
    <dxchartsui:WebChartControl ID="WebChartControl2" runat="server" AutoBindingSettingsEnabled="False" AutoLayoutSettingsEnabled="False" CrosshairEnabled="True" DataSourceID="SqlDataSource1" Height="487px" SeriesSorting="Descending" Width="1035px">
        <diagramserializable>
            <cc1:XYDiagram Rotated="True">
                <axisx reverse="True" visibleinpanesserializable="-1">
                </axisx>
                <axisy visibleinpanesserializable="-1">
                </axisy>
                <defaultpane sizeinpixels="700" sizemode="UseSizeInPixels">
                </defaultpane>
            </cc1:XYDiagram>
        </diagramserializable>
        <legend  maxhorizontalpercentage="30">
           
        </legend>
        <seriesserializable>
            <cc1:Series ArgumentDataMember="sgm_Nm" ArgumentScaleType="Qualitative" LabelsVisibility="True" LegendText="عدد المسجلين" Name="Series 1" SeriesPointsSorting="Descending" SeriesPointsSortingKey="Value_1" SummaryFunction="COUNT()">
                <labelserializable>
                    <cc1:SideBySideBarSeriesLabel ShowForZeroValues="True">
                    </cc1:SideBySideBarSeriesLabel>
                </labelserializable>
            </cc1:Series>
        </seriesserializable>
        <seriestemplate argumentscaletype="Qualitative">
        </seriestemplate>

    </dxchartsui:WebChartControl>

    </div>
 

                         </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="مقارنة الفروع باعداد التسجيل">
                    <ContentCollection>
                        <dx:ContentControl ID="ContentControl3" runat="server">
                            
    

<div class="ParaInfo" style="text-align: center">

<dxchartsui:WebChartControl ID="WebChartControl1" runat="server" CrosshairEnabled="True" DataSourceID="SqlDataSource4" Height="833px" SeriesSorting="Ascending" Width="1187px" AutoBindingSettingsEnabled="False" AutoLayoutSettingsEnabled="False">
    <emptycharttext text="الفروع" />
    <diagramserializable>
        <cc1:XYDiagram Rotated="True">
            <axisx interlaced="True" reverse="True" visibleinpanesserializable="-1">
                <tickmarks crossaxis="True" />
                
                <gridlines minorvisible="True" visible="True">
                </gridlines>
            </axisx>
            <axisy visibleinpanesserializable="-1">
                <autoscalebreaks enabled="True" />
                
            </axisy>
            <defaultpane sizeinpixels="800" sizemode="UseSizeInPixels">
            </defaultpane>
        </cc1:XYDiagram>
    </diagramserializable>
    <legend maxhorizontalpercentage="30"  usecheckboxes="True">
       
    </legend>
    <seriesserializable>
        <cc1:Series ArgumentDataMember="schBranchDesc1" ArgumentScaleType="Qualitative" LabelsVisibility="True" Name="عدد الطلاب المسجلين" SeriesPointsSorting="Descending" SeriesPointsSortingKey="Value_1" SummaryFunction="SUM([registercount])">
            <labelserializable>
                <cc1:SideBySideBarSeriesLabel  ResolveOverlappingMode="Default" ShowForZeroValues="True">
                </cc1:SideBySideBarSeriesLabel>
            </labelserializable>
        </cc1:Series>
        <cc1:Series ArgumentDataMember="schBranchDesc1" ArgumentScaleType="Qualitative" LabelsVisibility="True" Name="النسبة المحققة من الهدف" ValueDataMembersSerializable="regpercentage">
            <labelserializable>
                <cc1:SideBySideBarSeriesLabel  ShowForZeroValues="True">
                </cc1:SideBySideBarSeriesLabel>
            </labelserializable>
        </cc1:Series>
        <cc1:Series ArgumentDataMember="schBranchDesc1" ArgumentScaleType="Qualitative" LabelsVisibility="True" Name="عدد الطلاب الهدف" ValueDataMembersSerializable="Targetstudentcount">
            <labelserializable>
                <cc1:SideBySideBarSeriesLabel   ShowForZeroValues="True">
                    <shadow visible="True" />
                </cc1:SideBySideBarSeriesLabel>
            </labelserializable>
        </cc1:Series>
    </seriesserializable>
    <seriestemplate argumentscaletype="Qualitative" labelsvisibility="True" seriespointssorting="Ascending" seriespointssortingkey="Value_1">
        <labelserializable>
            <cc1:SideBySideBarSeriesLabel   ResolveOverlappingMode="Default" ShowForZeroValues="True">
                <fillstyle fillmode="Gradient">
                </fillstyle>
            </cc1:SideBySideBarSeriesLabel>
        </labelserializable>
    </seriestemplate>
</dxchartsui:WebChartControl>


</div>
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                
               
               
                <dx:TabPage Text="مقارنة الطلاب التاركين">
                    <ContentCollection>
                        <dx:ContentControl runat="server">


                            <br />
                             <div class="ParaInfo">
                            <asp:Chart ID="Chart2" runat="server" DataSourceID="SqlDataSource6" Height="575px" IsMapAreaAttributesEncoded="True" Palette="Bright" RightToLeft="Yes" Width="919px">
                                <Series>
                                    <asp:Series ChartArea="ChartArea1" ChartType="Pie" IsValueShownAsLabel="True" Label="#VALX" LabelAngle="25" LabelToolTip=" #PERCENT" Legend="Legend1" LegendText="#VALX  --   #VAL" Name="Series1" XValueMember="sgm_Nm" YValueMembers="counterst" YValueType="Double">
                                        <SmartLabelStyle CalloutStyle="Box" IsMarkerOverlappingAllowed="True" MaxMovingDistance="50" />
                                    </asp:Series>
                                </Series>
                                <ChartAreas>
                                    <asp:ChartArea Name="ChartArea1">
                                    </asp:ChartArea>
                                </ChartAreas>
                                <Legends>
                                    <asp:Legend DockedToChartArea="ChartArea1" ItemColumnSeparator="ThickGradientLine" Name="Legend1" TableStyle="Tall">
                                    </asp:Legend>
                                </Legends>
                            </asp:Chart>


                           
<asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:eZee %>" SelectCommand="select sgm_Nm,sgm,sum(counterst) as counterst from 
(SELECT glmulcmp.sgm_Nm, schBranch.sgm, 1 counterst FROM glmulcmp RIGHT OUTER JOIN schBranch ON glmulcmp.sgmid = schBranch.sgm RIGHT OUTER JOIN schregtransF ON schBranch.branch = schregtransF.branch WHERE ( schregtransF.acdcodeapplay=52) )as table_1 group by sgm_Nm,sgm"></asp:SqlDataSource>
 
</div> 
                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
                <dx:TabPage Text="تحليل المواصلات" ToolTip="تحليل المواصلات">
                    <ContentCollection>
                        <dx:ContentControl runat="server">

                           <br />
                             <div class="ParaInfo">
                            <asp:Chart ID="Chart3" runat="server" DataSourceID="SqlDataSource7" Height="575px" IsMapAreaAttributesEncoded="True" Palette="Bright"  Width="919px">
                                <Series>
                                    <asp:Series ChartArea="ChartArea1" ChartType="Pie" IsValueShownAsLabel="True" Label="#VALX" LabelAngle="25" LabelToolTip=" #PERCENT" Legend="Legend1" LegendText="#VALX  --   #VAL" Name="Series1" XValueMember="sgm_Nm" YValueMembers="counterst" YValueType="Double">
                                        <SmartLabelStyle CalloutStyle="Box" IsMarkerOverlappingAllowed="True" MaxMovingDistance="50" />
                                    </asp:Series>
                                </Series>
                                <ChartAreas>
                                    <asp:ChartArea Name="ChartArea1">
                                    </asp:ChartArea>
                                </ChartAreas>
                                <Legends>
                                    <asp:Legend DockedToChartArea="ChartArea1" ItemColumnSeparator="ThickGradientLine" Name="Legend1" TableStyle="Tall">
                                    </asp:Legend>
                                </Legends>
                            </asp:Chart>

</div>
 <div class="ParaInfo">                          
<asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:eZee %>" SelectCommand="select sgm_Nm,sgm,sum(counterst) as counterst from 
(SELECT glmulcmp.sgm_Nm, schBranch.sgm, 1 counterst FROM glmulcmp RIGHT OUTER JOIN schBranch ON glmulcmp.sgmid = schBranch.sgm RIGHT OUTER JOIN Regbussstudent ON schBranch.branch = Regbussstudent.branch WHERE ( Regbussstudent.acdcode=52) )as table_1 group by sgm_Nm,sgm"></asp:SqlDataSource>
 
</div> 

                            <div>


                                <dxchartsui:WebChartControl ID="WebChartControl4" runat="server" AutoBindingSettingsEnabled="False" AutoLayoutSettingsEnabled="False" CrosshairEnabled="True" DataSourceID="SqlDataSource8" Height="487px" SeriesSorting="Descending" Width="1081px">
                                    <diagramserializable>
                                        <cc1:XYDiagram Rotated="True">
                                            <axisx reverse="True" visibleinpanesserializable="-1">
                                            </axisx>
                                            <axisy visibleinpanesserializable="-1">
                                            </axisy>
                                            <defaultpane sizeinpixels="700" sizemode="UseSizeInPixels">
                                            </defaultpane>
                                        </cc1:XYDiagram>
                                    </diagramserializable>
                                    <legend   maxhorizontalpercentage="30">
                                        <shadow visible="True" />
                                    </legend>
                                    <seriesserializable>
                                        <cc1:Series ArgumentScaleType="Qualitative" LabelsVisibility="True" LegendText="المشتركين بالمواصلات " Name="Series 1" SeriesPointsSorting="Descending" SeriesPointsSortingKey="Value_1" ArgumentDataMember="schBranchDesc1" ValueDataMembersSerializable="counterst">
                                            <labelserializable>
                                                <cc1:SideBySideBarSeriesLabel ShowForZeroValues="True">
                                                </cc1:SideBySideBarSeriesLabel>
                                            </labelserializable>
                                        </cc1:Series>
                                    </seriesserializable>
                                    <seriestemplate argumentscaletype="Qualitative">
                                    </seriestemplate>
                                </dxchartsui:WebChartControl>












                                <asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:eZee %>" SelectCommand="SELECT        branch, schBranchDesc1, SUM(counterst) AS counterst
FROM            (SELECT        dbo.schBranch.branch, dbo.schBranch.Desc1 AS schBranchDesc1, 1 AS counterst
                           FROM            dbo.schBranch RIGHT OUTER JOIN
                                                    dbo.Regbussstudent ON dbo.schBranch.branch = dbo.Regbussstudent.branch
                           WHERE        (dbo.Regbussstudent.acdcode = 52)) AS table1
GROUP BY branch, schBranchDesc1"></asp:SqlDataSource>
 
                            </div>
                             


                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
   
                <dx:TabPage Text="مقارنة المواصلات مع التقديرى ">
                    <ContentCollection>
                        <dx:ContentControl runat="server">
                            <br />
                              <div style="height: 14px">




                                   <dx:ASPxPivotGrid ID="ASPxPivotGrid3" runat="server" Caption="الميزانية التقديرية والتسجيل الفعلي " ClientIDMode="AutoID" ClientInstanceName="pivotGrid" DataSourceID="SqlDataSource9" EnableTheming="True" Height="100%" Theme="Aqua">
                                       <Fields>
                                           <dx:PivotGridField ID="fieldTargetClasscount0" Area="DataArea" AreaIndex="2" Caption="هدف عدد الناقلات" FieldName="TargetClasscount" Options-AllowExpand="False" Options-AllowFilter="False" Options-AllowFilterBySummary="False" Options-AllowSortBySummary="False">
                                           </dx:PivotGridField>
                                           <dx:PivotGridField ID="fieldTargetstudentcount0" Area="DataArea" AreaIndex="0" Caption="هدف اعداد الطلاب" FieldName="Targetstudentcount">
                                           </dx:PivotGridField>
                                           <dx:PivotGridField ID="fieldbranch3" Area="RowArea" AreaIndex="2" Caption="كود الفرع" FieldName="branch">
                                           </dx:PivotGridField>
                                           <dx:PivotGridField ID="fieldschBranchDesc13" Area="RowArea" AreaIndex="3" Caption="اسم المدرسة او الفرع " FieldName="schBranchDesc1">
                                           </dx:PivotGridField>
                                           <dx:PivotGridField ID="fieldschGradeShortDesc2" Area="RowArea" AreaIndex="4" Caption="الصف " FieldName="schGradeShortDesc1">
                                           </dx:PivotGridField>
                                           <dx:PivotGridField ID="fieldrealclasscount0" Area="DataArea" AreaIndex="3" Caption="عدد الباصات الحالية" FieldName="realclasscount">
                                           </dx:PivotGridField>
                                           <dx:PivotGridField ID="fieldregistercount0" Area="DataArea" AreaIndex="1" Caption="عدد الطلاب المسجل" FieldName="registercount">
                                           </dx:PivotGridField>
                                           <dx:PivotGridField ID="fieldsgmNm2" Area="RowArea" AreaIndex="1" Caption="القطاع" FieldName="sgm_Nm">
                                           </dx:PivotGridField>
                                           <dx:PivotGridField ID="fieldsgm3" Area="RowArea" AreaIndex="0" Caption="كود القطاع" FieldName="sgm" Options-AllowExpand="False" Options-AllowFilter="False" Options-AllowFilterBySummary="False" Options-AllowSortBySummary="False" Options-ShowCustomTotals="False" Options-ShowGrandTotal="False" Options-ShowInCustomizationForm="False" Options-ShowInPrefilter="False" Options-ShowTotals="False" Options-ShowValues="False">
                                           </dx:PivotGridField>
                                           <dx:PivotGridField ID="fieldregpercentage0" Area="RowArea" AreaIndex="5" FieldName="regpercentage" TotalsVisibility="None">
                                           </dx:PivotGridField>
                                       </Fields>
                                       <Prefilter Enabled="False" />
                                       <OptionsView ShowHorizontalScrollBar="True" />
                                       <OptionsPager NumericButtonCount="30" RowsPerPage="120">
                                           <Summary Position="Right" Text="الصفحة  {0} of {1} ({2} السجلات)" />
                                       </OptionsPager>
                                       <OptionsData AutoExpandGroups="True" />
                                   </dx:ASPxPivotGrid>



                                </div>
                            <div>

                                <asp:SqlDataSource ID="SqlDataSource9" 
            SelectCommand="SELECT * FROM [QschRegDashBoardcomparetrans] where AcademicYearto=52"
            runat="server" ConnectionString="<%$ ConnectionStrings:eZee %>"></asp:SqlDataSource>


                            </div>


                        </dx:ContentControl>
                    </ContentCollection>
                </dx:TabPage>
   
            </TabPages>
        </dx:ASPxPageControl>--%>
    </div>
    </div>
 </div>


    
    

 


