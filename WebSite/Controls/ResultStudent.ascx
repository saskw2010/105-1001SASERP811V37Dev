<%@ Control Language="VB" AutoEventWireup="false" CodeFile="ResultStudent.ascx.vb" Inherits="Controls_ResultStudent"  %>

<%--<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxp" %>

<%@ Register Assembly="DevExpress.Web.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxrp" %>
<%@ Register Assembly="DevExpress.Web.v17.1" Namespace="DevExpress.Web"
	TagPrefix="dxe" %>

<%@ Register Assembly="DevExpress.Web.v17.1" Namespace="DevExpress.Web"
	TagPrefix="dxwgv" %>
 
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dxwpg" %>--%>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

    <style type="text/css">

.dialog_body, .dBody {
	background-color: #ffffff;
	color: #666666;
	font-family: Arial, Verdana, Geneva, ms sans serif;
	font-size: 10px;
	text-align: right;
	}

</style>

    <table>

<tr>
<td>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
        DataSourceID="SqlDataSource1" DataTextField="civilid" DataValueField="civilid">
    </asp:DropDownList>
    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
        DataSourceID="SqlDataSource2" DataTextField="cat5name" DataValueField="catid5">
    </asp:DropDownList>

                        <%--<telerik:RadMenu runat="server" Flow="Vertical" 
        DataNavigateUrlField="Navurl" DataFieldID="MenuID" DataTextField="Text" 
        Skin="" DataSourceID="SqlDataSource6" ID="RadMenu3" 
        DataFieldParentID="ParentID" EnableTheming="true" 
        style="top: 0px; right: 0px; height: 27px;" >
                            <DataBindings>
                                <telerik:RadMenuItemBinding ImageUrl="~/Images/index_02.png" NavigateUrlField="Navurl" 
                                     HoveredImageUrl="~/Images/index_05.png" />
                            </DataBindings>
                            
    </telerik:RadMenu>--%>



     <asp:SqlDataSource runat="server" 
        ConnectionString="<%$ ConnectionStrings:eZee %>" 
        SelectCommand="SELECT * FROM [Menu] ORDER BY [MenuID], [ParentID]" 
        ID="SqlDataSource6"></asp:SqlDataSource>



    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:eZee %>" 
        SelectCommand="SELECT * FROM [Qwaizcat5]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:eZee %>" 
        
        SelectCommand="SELECT  [civilid], [full_name]   FROM [Resultnew] WHERE ([civilid] = @civilid) group by   [civilid], [full_name] ">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="303122700177" Name="civilid" 
                SessionField="userIdx" Type="Double" />
        </SelectParameters>
    </asp:SqlDataSource>

    <br />
 <%-- <dxwpg:ASPxPivotGrid ID="ASPxPivotGrid2" runat="server" ClientInstanceName="pivotGrid"
            Caption="بيانات الطالب " 
            CustomizationFieldsLeft="0" CustomizationFieldsTop="0" 
            DataSourceID="SqlDataSource5" EnableTheming="False">
            <Prefilter Enabled="False" />
            <Fields>
                <dxwpg:PivotGridField ID="fieldstname0" Area="RowArea" AreaIndex="0" 
                    FieldName="st_name" Caption="اسم الطالب">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldcat3name0" Area="RowArea" AreaIndex="1" 
                    FieldName="cat3name" Caption="الصف">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldcat5name0" Area="RowArea" AreaIndex="3" 
                    FieldName="cat5name" Caption="الفترة">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldtotal0" Area="RowArea" AreaIndex="4" 
                    FieldName="total" Caption="الدرجة الكلية ">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldperc0" Area="RowArea" AreaIndex="5" 
                    FieldName="perc" Caption="نسبة الفترة">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldstclass" Area="RowArea" AreaIndex="2" 
                    FieldName="st_class" Caption="الفصل">
                </dxwpg:PivotGridField>
            </Fields>
            
            <OptionsView ShowColumnHeaders="False" ShowContextMenus="False" 
                ShowCustomTotalsForSingleValues="True" ShowDataHeaders="False" 
                ShowFilterHeaders="False" />
            <Images ImageFolder="~/App_Themes/Office2003Blue/{0}/">
                <FieldValueCollapsed Height="12px" 
                    Url="~/App_Themes/Office2003Blue/PivotGrid/pgCollapsedButton.png" 
                    Width="11px" />
                <FieldValueExpanded Height="12px" 
                    Url="~/App_Themes/Office2003Blue/PivotGrid/pgExpandedButton.png" Width="11px" />
                <HeaderSortDown Height="8px" 
                    Url="~/App_Themes/Office2003Blue/PivotGrid/pgHeaderSortDown.png" Width="7px" />
                <HeaderSortUp Height="8px" 
                    Url="~/App_Themes/Office2003Blue/PivotGrid/pgHeaderSortUp.png" Width="7px" />
                <SortByColumn Height="7px" 
                    Url="~/App_Themes/Office2003Blue/PivotGrid/pgSortByColumn.png" Width="11px" />
            </Images>
            <OptionsCustomization AllowDrag="False" AllowExpand="False" AllowFilter="False" 
                AllowPrefilter="False" AllowSort="False" AllowSortBySummary="False" />
            <ClientSideEvents CellClick="function(s, e) {
	pivotGrid.SendPostBack(&quot;Data|&quot; + e.ColumnIndex + &quot;|&quot; + e.RowIndex);
}" />
            <OptionsPager NumericButtonCount="30">
                <Summary Position="Right" Text="الصفحة  {0} of {1} ({2} السجلات)" />
            </OptionsPager>
        </dxwpg:ASPxPivotGrid>

</td>
</tr>
<tr>
<td>
  <dxwpg:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" ClientInstanceName="pivotGrid"
            Caption="النتيجة " 
            CustomizationFieldsLeft="0" CustomizationFieldsTop="0" 
            DataSourceID="SqlDataSource5" EnableTheming="False">
            <Prefilter Enabled="False" />
            <Fields>
                <dxwpg:PivotGridField ID="fieldcodemat" Area="RowArea" AreaIndex="0" 
                    FieldName="codemat" Caption="      " Options-ShowGrandTotal="False" 
                    Options-ShowTotals="False">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldExpr1" Area="RowArea" AreaIndex="1" 
                    FieldName="Expr1" Caption="المجال الدراسي" Options-ShowGrandTotal="False">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldexam1" Area="RowArea" AreaIndex="2" 
                    FieldName="exam1" Caption="الامتحان" Options-ShowGrandTotal="False" 
                    SummaryType="Max">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldwork1" Area="RowArea" AreaIndex="3" 
                    FieldName="work1" Caption="أعمال" Options-ShowGrandTotal="False" 
                    SummaryType="Max">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldmark1" Area="RowArea" AreaIndex="4" 
                    FieldName="mark1" Caption="درجة الطالب" Options-ShowGrandTotal="False">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldmin1" Area="RowArea" AreaIndex="7" 
                    Caption="الدرجة الصغري" FieldName="min1" Options-ShowGrandTotal="False">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldmax1" Area="RowArea" AreaIndex="8" 
                    Caption="الدرجة العظمي" FieldName="max1">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldmax11" Area="RowArea" AreaIndex="5" 
                    Caption="نسبة المادة" FieldName="max11">
                </dxwpg:PivotGridField>
                <dxwpg:PivotGridField ID="fieldmatresult" Area="RowArea" AreaIndex="6" 
                    Caption="النتيجة" FieldName="matresult">
                </dxwpg:PivotGridField>
            </Fields>
            
            <OptionsView ShowColumnHeaders="False" ShowContextMenus="False" ShowDataHeaders="False" 
                ShowFilterHeaders="False" 
                ShowColumnGrandTotals="False" ShowColumnTotals="False" 
                ShowFilterSeparatorBar="False" 
                ShowRowGrandTotals="False" ShowRowTotals="False" 
                ShowTotalsForSingleValues="True"  />
            <OptionsChartDataSource  />
            <Images ImageFolder="~/App_Themes/Office2003Blue/{0}/">
                <FieldValueCollapsed Height="12px" 
                    Url="~/App_Themes/Office2003Blue/PivotGrid/pgCollapsedButton.png" 
                    Width="11px" />
                <FieldValueExpanded Height="12px" 
                    Url="~/App_Themes/Office2003Blue/PivotGrid/pgExpandedButton.png" Width="11px" />
                <HeaderSortDown Height="8px" 
                    Url="~/App_Themes/Office2003Blue/PivotGrid/pgHeaderSortDown.png" Width="7px" />
                <HeaderSortUp Height="8px" 
                    Url="~/App_Themes/Office2003Blue/PivotGrid/pgHeaderSortUp.png" Width="7px" />
                <SortByColumn Height="7px" 
                    Url="~/App_Themes/Office2003Blue/PivotGrid/pgSortByColumn.png" Width="11px" />
            </Images>
            <OptionsCustomization AllowDrag="False" AllowExpand="False" AllowFilter="False" 
                AllowPrefilter="False" AllowSort="False" AllowSortBySummary="False" />
            <ClientSideEvents CellClick="function(s, e) {
	pivotGrid.SendPostBack(&quot;Data|&quot; + e.ColumnIndex + &quot;|&quot; + e.RowIndex);
}" />
            <OptionsPager NumericButtonCount="30">
                <Summary Position="Right" Text="الصفحة  {0} of {1} ({2} السجلات)" />
            </OptionsPager>
        </dxwpg:ASPxPivotGrid>
        <asp:SqlDataSource ID="SqlDataSource5" runat="server" 
            ConnectionString="<%$ ConnectionStrings:eZee %>" 
            
            
        
        SelectCommand="SELECT * FROM [Resultnew] WHERE (([civilid] = @civilid) AND ([week] = @week))">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" DefaultValue="0" Name="civilid" 
                    PropertyName="SelectedValue" Type="Double" />
                <asp:ControlParameter ControlID="DropDownList2" DefaultValue="0" Name="week" 
                    PropertyName="SelectedValue" Type="Double" />
            </SelectParameters>
            
                
        </asp:SqlDataSource>

 
</td>--%>
</tr>
</table>


