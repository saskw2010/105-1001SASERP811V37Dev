Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Configuration
Imports System.Web.Security
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports Stimulsoft.Report
Imports Stimulsoft.Report.Web
Imports Microsoft.VisualBasic.ApplicationServices
Imports eZee.Data
Imports System.Xml.XPath
Imports System.ComponentModel
Imports Stimulsoft.Report.Dictionary
Imports Stimulsoft.Report.Components
Imports Stimulsoft.Base.Drawing
Imports Stimulsoft.Base
Imports System.Drawing
Imports System.IO
Imports Stimulsoft.Report.MobileDesign

Partial Public Class Dynwexreport1
    Inherits Global.System.Web.UI.UserControl
    Private reportFileName1 As String = Nothing
    Private report As New StiReport()
    Private controllername As String = Nothing
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If IsPostBack Then
        Else

            Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
            reportFileName1 = Page.Request.QueryString.[Get]("reportquery")
            controllername = Page.Request.QueryString.[Get]("controllername")
            If reportFileName1 IsNot Nothing Then
            Else
                reportFileName1 = "first1"
            End If
            Dim connString As String = ConnectionStringSettingsFactory.getconnection().ConnectionString
            If (System.IO.File.Exists(appDirectory + "\Reports\" + reportFileName1 + ".mrt")) Then
                report.Load(appDirectory + "\Reports\" + reportFileName1 + ".mrt")
                '-----------------------------------------------------------------
                'Dim orginalfilter As String = Nothing

                'orginalfilter = Page.Request.QueryString.[Get]("filterarr")
                ''--------------------------------------------------------------------

                'Dim idfilter As String = orginalfilter
                'If String.IsNullOrEmpty(idfilter) Or IsNothing(idfilter) Then
                'Else
                '    Dim moscommand As DbCommand
                '    Dim connection1 As DbConnection
                '    Dim factory As System.Data.Common.DbProviderFactory
                '    factory = System.Data.Common.DbProviderFactories.GetFactory("System.Data.SqlClient")
                '    connection1 = factory.CreateConnection()
                '    connection1.ConnectionString = connString
                '    connection1.Open()
                '    moscommand = getcommand("command1", connection1, controllername)
                '    Dim sqlCommand As String = " select * from (" & moscommand.CommandText & ") as derivedtbl_1 where " & orginalfilter
                '    Dim ds As DataSet = GetDataSet(sqlCommand, connString)
                '    Dim sqlDB1 As Stimulsoft.Report.Dictionary.StiDataSource
                '    'For i = 0 To report.Dictionary.DataSources.Count - 1
                '    sqlDB1 = report.Dictionary.DataSources(0)
                '    If Not IsDBNull(sqlDB1) Then
                '        report.Dictionary.DataSources.Remove(sqlDB1)

                '    End If

                '    'Next i
                '    'StiDataTableSource

                '    ' report.Dictionary.Databases.Add(New Stimulsoft.Report.Dictionary.StiSqlDatabase("mosConnection1", connString))
                '    Dim DS1 As Stimulsoft.Report.Dictionary.StiSqlSource = New Stimulsoft.Report.Dictionary.StiSqlSource("mosConnection1", "mosDataSource1", "mosDataSource1", sqlCommand, True, False)
                '    report.Dictionary.DataSources.Add(DS1)
                '    Dim dataTableDS1 As DataTable
                '    Dim col As DataColumn
                '    For Each dataTableDS1 In ds.Tables
                '        For Each col In dataTableDS1.Columns
                '            DS1.Columns.Add(col.ColumnName, col.DataType)
                '        Next
                '    Next
                '    'report.CompiledReport.DataSources(0).Parameters(0).ParameterValue = "keedno='1'"

                'End If
                '                var tables = new DataTable[4];
                'tables[0] = mynewtable;
                'tables[1] = mydataset.Tables[0];
                'tables[2] = mydataset.Tables[1];
                'tables[3] = mydataset.Tables[2];
                'mydataset.Tables.Clear();
                'mydataset.Tables.Add(Tables[0]);
                'mydataset.Tables.Add(Tables[1]);
                'mydataset.Tables.Add(Tables[2]);
                'mydataset.Tables.Add(Tables[3]);
                report.Dictionary.DataSources.Clear()
                '//Bind data in DataSet 
                Dim ds As New DataSet()
                Dim table As DataTable = TryCast(Session("YourDataTableName"), DataTable)

                'read table and push in Sqlserver
                If table IsNot Nothing Then
                    'session either expired or invalid page being accessed.

                    ds.Tables.Add(table)
                    '//ds.WriteXml("c:\\test.xml")
                    report.RegData("mosDataSource1", ds)
                    report.Dictionary.Synchronize()
                    report.Compile()
                    Dim sqlDB As Stimulsoft.Report.Dictionary.StiSqlDatabase
                    For i = 0 To report.CompiledReport.Dictionary.Databases.Count - 1
                        sqlDB = report.CompiledReport.Dictionary.Databases(i)
                        If Not IsDBNull(sqlDB) Then
                            sqlDB.ConnectionString = connString

                        End If

                    Next i
                Else
                End If
                'new variable  Report.Dictionary.Variables.Add(New StiVariable("Category", "MyVariable", CType(GetType(String), Type), """1""", False))

                'If String.IsNullOrEmpty(idfilter) Or IsNothing(idfilter) Then
                'Else
                '   report.Dictionary.Variables.Items(0).Value = idfilter
                'end if
            Else
                FileCopy(appDirectory + "\Reports\" + "first1.mrt", appDirectory + "\Reports\" + reportFileName1 + ".mrt")
                'Try to update sql source to view grid1 on the name of controoler
                Dim dbinerto As New dblayer
                Dim xinsert As Boolean
                xinsert = dbinerto.Insert("insert into mrtcontrollerName(controllerName,ReportCode) values ('" & controllername & "','" & reportFileName1 & "')")
                Dim moscommand As DbCommand
                Dim connection1 As DbConnection
                Dim factory As System.Data.Common.DbProviderFactory
                factory = System.Data.Common.DbProviderFactories.GetFactory("System.Data.SqlClient")
                connection1 = factory.CreateConnection()
                connection1.ConnectionString = connString
                connection1.Open()
                moscommand = getcommand("command1", connection1, controllername)
                Dim sqlCommand As String = moscommand.CommandText
                Dim ds As DataSet = GetDataSet(sqlCommand, connString)
                report.Load(appDirectory + "\Reports\" + reportFileName1 + ".mrt")
                'Dim sqlconnection As New SqlConnection(connString)
                'report.RegData("connection1", sqlconnection)
                'report.RegData("DataSource1", ds)
                report.Dictionary.Databases.Clear()
                report.Dictionary.Databases.Add(New Stimulsoft.Report.Dictionary.StiSqlDatabase("mosConnection1", connString))
                Dim DS1 As Stimulsoft.Report.Dictionary.StiSqlSource = New Stimulsoft.Report.Dictionary.StiSqlSource("mosConnection1", "mosDataSource1", "mosDataSource1", sqlCommand, True, False)
                report.Dictionary.DataSources.Add(DS1)
                '---------------------------------------------------------
                Dim dataTableDS1 As DataTable
                Dim col As DataColumn
                For Each dataTableDS1 In ds.Tables
                    For Each col In dataTableDS1.Columns
                        DS1.Columns.Add(col.ColumnName, col.DataType)
                    Next
                Next
                Dim Page As StiPage = report.Pages.Item(0)
                'Create HeaderBand
                Dim HeaderBand As New StiHeaderBand()
                HeaderBand.Height = 0.2
                HeaderBand.Name = "HeaderBand"
                Page.Components.Add(HeaderBand)

                'Create Databand 
                Dim Databand As New StiDataBand()
                Databand.DataSourceName = "mosDataSource1"
                Databand.Height = 0.2
                Databand.Name = "mosDataBand1"
                Page.Components.Add(Databand)


                'Create texts
                Dim Pos As Double = 0.1
                Dim hColumnWidth As Double = 0.8
                Dim dColumnWidth As Double = 0.8
                Dim allheight As Double = 0.2
                ' StiAlignValue.AlignToMinGrid(Page.Width / DS1.Columns.Count, 0.1, True)
                Dim NameIndex As Integer = 1

                Dim x1 As Integer = 0.0

                Dim Column As Stimulsoft.Report.Dictionary.StiDataColumn

                For Each Column In DS1.Columns

                    'Create text on header
                    If NameIndex < 11 Then
                        Dim HeaderText As New StiText(New RectangleD(Pos, 0, hColumnWidth, allheight))
                        HeaderText.Text.Value = Column.Name
                        HeaderText.HorAlignment = StiTextHorAlignment.Center
                        HeaderText.Name = "HeaderText" + NameIndex.ToString()
                        HeaderText.Brush = New StiSolidBrush(Color.LightGreen)
                        HeaderText.Border.Side = StiBorderSides.All
                        HeaderBand.Components.Add(HeaderText)

                        'Create text on Data Band
                        Dim DataText As New StiText(New RectangleD(Pos, 0, dColumnWidth, allheight))
                        DataText.Text.Value = "{mosDataSource1." + Column.Name + "}"
                        DataText.Name = "DataText" + NameIndex.ToString()
                        DataText.Border.Side = StiBorderSides.All


                        Databand.Components.Add(DataText)

                        'Add highlight
                        'Dim Condition As StiCondition = New StiCondition()
                        'Condition.BackColor = Color.CornflowerBlue
                        'Condition.TextColor = Color.Black
                        'Condition.Expression.Value = "(Line And 1) = 1"
                        'Condition.Item = StiFilterItem.Expression
                        'DataText.Conditions.Add(Condition)
                        Pos = Pos + 0.9

                    End If
                    NameIndex = NameIndex + 1

                Next

                'Create FooterBand
                Dim FooterBand As New StiFooterBand()
                FooterBand.Height = 0.2
                FooterBand.Name = "FooterBand"
                Page.Components.Add(FooterBand)

                'Create text on footer
                Dim FooterText As New StiText(New RectangleD(0, 0, Page.Width, 0.2))
                FooterText.Text.Value = "Count - {Count()}"
                FooterText.HorAlignment = StiTextHorAlignment.Right
                FooterText.Name = "FooterText"
                FooterText.Brush = New StiSolidBrush(Color.LightGreen)
                FooterBand.Components.Add(FooterText)

                report.Compile()
                'Dim sqlDB As Stimulsoft.Report.Dictionary.StiSqlDatabase
                'For i = 0 To report.CompiledReport.Dictionary.Databases.Count - 1
                '    sqlDB = report.CompiledReport.Dictionary.Databases(i)
                '    If Not IsDBNull(sqlDB) Then
                '        sqlDB.ConnectionString = connString
                '    End If
                'Next i
                'Dim datsource As Stimulsoft.Report.Dictionary.StiSqlSource
                'For i = 0 To report.CompiledReport.Dictionary.DataSources.Count - 1
                '    datsource = report.CompiledReport.Dictionary.DataSources(i)
                '    If Not IsDBNull(sqlDB) Then
                '        datsource.SqlCommand = sqlCommand
                '    End If
                'Next i




                StiWebDesigner1.Report = report
            End If
            Dim designflag, reportFileName As String
            designflag = Page.Request.QueryString.[Get]("designflag")
            If (designflag Is Nothing) Or (designflag = "false") Then


                '--------------------------------------------------
                Dim xo1 As Object
                xo1 = report.CompiledReport("xo1")
                If xo1 IsNot Nothing Then

                    If (File.Exists(HttpContext.Current.Server.MapPath("~/Images/xo1.jpg"))) Then
                        report.CompiledReport("xo1").file = HttpContext.Current.Server.MapPath("~/Images/xo1.jpg")
                    End If
                End If
                '--------------------------------------------------
                Dim xo2 As Object
                xo2 = report.CompiledReport("xo2")
                If xo2 IsNot Nothing Then
                    If (File.Exists(HttpContext.Current.Server.MapPath("~/Images/xo2.jpg"))) Then
                        report.CompiledReport("xo2").file = HttpContext.Current.Server.MapPath("~/Images/xo2.jpg")
                    End If
                End If


                Dim username As String
                Dim timestampstring As String

                username = HttpContext.Current.User.Identity.Name()
                timestampstring = System.DateTime.Now.ToString("yyyyMMddHHmmss")

                '------------------------------------------------------------------------
                Dim myvar9 As String = username
                If myvar9 IsNot Nothing Then
                    Dim ororo9 As Object
                    ororo9 = report.CompiledReport("myvar9")
                    If IsNothing(ororo9) Then
                    Else

                        report("myvar9") = CStr(myvar9)

                    End If
                End If
                '------------------------------------------------------------------------
                Dim myvarsec1 As String = "xx1976"
                If myvarsec1 IsNot Nothing Then
                    Dim ororosec1 As Object
                    ororosec1 = report.CompiledReport("myvarsec1")
                    If IsNothing(ororosec1) Then
                    Else

                        report("myvarsec1") = CStr(myvarsec1)

                    End If
                End If
                '------------------------------------------------------------------------


                StiWebViewerFx1.Report = report
                StiWebViewerFx1.Page.Title = reportFileName1
            Else
                appDirectory = HttpContext.Current.Server.MapPath("~")
                reportFileName1 = Page.Request.QueryString.[Get]("reportquery")
                reportFileName = appDirectory + "\Reports\" + reportFileName1 + ".mrt"

                Dim report1 As StiReport = New StiReport()
                report1.Load(reportFileName)
                report1.ReportName = reportFileName1
                StiWebDesigner1.Report = report1

            End If

            If HttpContext.Current.User.IsInRole("ReportDesigner") Then
                Button1.Visible = True
            Else
                Button1.Visible = False
            End If

        End If
    End Sub

    Function GetDataSet(sqlCommand As String, connectionString As String) As DataSet
        Dim ds As New DataSet()
        Using cmd As New SqlCommand(sqlCommand, New SqlConnection(connectionString))
            cmd.Connection.Open()
            Dim table As New DataTable()
            table.Load(cmd.ExecuteReader())
            ds.Tables.Add(table)
        End Using
        Return ds
    End Function

    Protected Sub StiWebDesigner1_SaveReport(ByVal sender As Object, ByVal e As StiMobileDesigner.StiSaveReportEventArgs)
        Dim report As StiReport = e.Report
        Dim str As String = report.SavePackedReportToString()
        Page.Cache.Add(report.ReportGuid, str, Nothing, Cache.NoAbsoluteExpiration, New TimeSpan(0, 5, 0), System.Web.Caching.CacheItemPriority.Low,
         Nothing)
        Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
        reportFileName1 = Page.Request.QueryString.[Get]("reportquery")
        report.Save(Server.MapPath("~/Reports/" + reportFileName1 + ".mrt"))
        '' Page.Response.Redirect("~/Pages/webreportviwer.aspx?savepanel=" + report.ReportGuid)
    End Sub

    Protected Sub SaveReportButton_Click(sender As Object, e As EventArgs) Handles SaveReportButton.Click
        Dim report As New StiReport()
        Dim str As String = TryCast(Page.Cache(ReportNameLabel.Text), String)
        report.LoadPackedReportFromString(str)
        ' you code here

        Page.Response.Redirect("~/Pages/webreportviwer.aspx")
    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
        reportFileName1 = Page.Request.QueryString.[Get]("reportquery")
        Dim reportFileName As String = appDirectory + "\Reports\" + reportFileName1 + ".mrt"

        Dim report As StiReport = New StiReport()
        report.Load(reportFileName)
        report.ReportName = reportFileName1
        StiWebDesigner1.Report = report


    End Sub

    Protected Friend Function CreateConfiguration1(ByVal controller As String) As ControllerConfiguration
        Return eZee.Data.Controller.CreateConfigurationInstance([GetType](), controller)
    End Function
    Function getcommand(commandId As String, ByVal connection As DbConnection, ByVal Controller As String) As DbCommand
        If String.IsNullOrEmpty(commandId) Or String.IsNullOrWhiteSpace(commandId) Then
            commandId = "command1"
        End If
        ' how to get m_config from controller.vb
        Dim mConfig As ControllerConfiguration = CType(CreateConfiguration1(Controller), ControllerConfiguration)
        Dim commandNav As XPathNavigator = mConfig.SelectSingleNode("/c:dataController/c:commands/c:command[@id='{0}']", commandId)
        '//if command have argument 
        'If ((Not (args) Is Nothing) AndAlso Not (String.IsNullOrEmpty(args.CommandArgument))) Then
        '    Dim commandNav2 As XPathNavigator = m_Config.SelectSingleNode("/c:dataController/c:commands/c:command[@id='{0}']", args.CommandArgument)
        '    If (Not (commandNav2) Is Nothing) Then
        '        commandNav = commandNav2
        '    End If
        'End If
        If (commandNav Is Nothing) Then
            Return Nothing
        End If
        Dim command As DbCommand = SqlStatement.CreateCommand(connection)
        If (Not (SinglePhaseTransactionScope.Current) Is Nothing) Then
            SinglePhaseTransactionScope.Current.Enlist(command)
        End If
        command.CommandType = CType(TypeDescriptor.GetConverter(GetType(CommandType)).ConvertFromString(commandNav.GetAttribute("type", String.Empty)), CommandType)
        ' how to get Resolver
        '
        command.CommandText = CType(commandNav.Evaluate("string(c:text)", mConfig.Resolver), String)
        If String.IsNullOrEmpty(command.CommandText) Then
            command.CommandText = commandNav.InnerXml
        End If
        Return command

    End Function


End Class
'' Prepare data
'Dim dataSet As New DataSet()
'dataSet.ReadXml(appDirectory + "\Data\Demo.xml")
'dataSet.ReadXmlSchema(appDirectory + "\Data\Demo.xsd")
'' Load report
'If Page IsNot Nothing Then
'    Dim keyValue As String = Page.Request.QueryString.[Get]("savepanel")
'    If keyValue IsNot Nothing Then
'        SavePanel.Visible = True
'        ReportNameLabel.Text = keyValue
'        StiWebDesigner1.Visible = False

'    Else
'report.RegData(dataSet)

'' View report
'        End If
'End If