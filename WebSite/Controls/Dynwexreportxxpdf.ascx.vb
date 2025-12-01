Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports Stimulsoft.Report
Imports Stimulsoft.Report.Web
Imports eZee.Data
Imports System.Xml.XPath
Imports System.ComponentModel
Imports Stimulsoft.Report.Components
Imports Stimulsoft.Base.Drawing
Imports System.Drawing
Imports Stimulsoft.Report.Export
Imports System.IO
Imports eZee.Handlers
Imports eZee.Web
Imports Stimulsoft.Report.MobileDesign

Partial Public Class Dynwexreportxxpdf
    Inherits Global.System.Web.UI.UserControl
    Private reportFileName1 As String = Nothing
    Private report As New StiReport()
    Private controllername As String = Nothing
    Private viewname As String = Nothing
    Private argfilter As String = Nothing
    Private sosdesc As String = Nothing
    Private reportFileNamemosso As String = Nothing
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If IsPostBack Then
        Else
            Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
            reportFileName1 = Context.Request("reportquery") 'Page.Request.QueryString.[Get]("reportquery")
            controllername = Context.Request("controllername")
            viewname = "grid1" 'Page.Request.QueryString.[Get]("viewname")
            argfilter = Context.Request("argfilter")
            sosdesc = Context.Request("sosdesc")
            reportFileNamemosso = Context.Request("reportFileNamemosso")
            Dim ds As New DataSet()
            Dim table As New DataTable
            If reportFileName1 IsNot Nothing Then
            Else
                reportFileName1 = "first1x"
            End If
            Dim connString As String = ConnectionStringSettingsFactory.getconnection().ConnectionString
            If (System.IO.File.Exists(appDirectory + "\Reports\" + reportFileName1 + ".mrt")) Then
                report.Load(appDirectory + "\Reports\" + reportFileName1 + ".mrt")
                '-----------------------------------------------------------------
                Dim CacheFolder As String = System.IO.Path.Combine(appDirectory, "StimulsoftReportsCache")
                If Not System.IO.Directory.Exists(CacheFolder) Then
                    System.IO.Directory.CreateDirectory(CacheFolder)
                End If
                report.ReportCachePath = CacheFolder
                report.ReportCacheMode = Stimulsoft.Report.StiReportCacheMode.On

                ds.Tables.Clear()
                Dim xx As Stimulsoft.Report.Dictionary.StiDataTableSource

                xx = report.Dictionary.DataSources("table")
                If IsNothing(xx) Then
                Else
                    xx.ResetData()
                End If

                Dim reportFileNamemossopath As String = appDirectory + "\Reportsdata\"
                Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

                'Dim reportFileNamemossopath As String = mydocpath  ' appDirectory1 + "\Reportsdata\"


                Dim reader As New System.Xml.XmlTextReader(reportFileNamemossopath + reportFileNamemosso + ".xml")

                table.ReadXml(reader)



                ' table.ReadXmlSchema(reportFileNamemossopath + reportFileNamemosso + ".xsd")
                ' table.ReadXml(reportFileNamemossopath + reportFileNamemosso + ".xml")


                ' Session("tablerequestreport")
                'table = eZee.Rules.SharedBusinessRules.getdatatable2016()
                'eZee.Rules.SharedBusinessRules.getdatatable(controllername, viewname, argfilter)


                If table IsNot Nothing Then
                    ds.Tables.Clear()
                    ds.Reset()
                    ds.Tables.Add(table)
                    report.RegData(ds)
                    report.CacheAllData = True
                    report.Dictionary.Synchronize()

                    report.Compile()
                    Dim sqlDB As Stimulsoft.Report.Dictionary.StiSqlDatabase
                    For i = 0 To report.CompiledReport.Dictionary.Databases.Count - 1
                        sqlDB = report.CompiledReport.Dictionary.Databases(i)
                        If Not IsDBNull(sqlDB) Then
                            sqlDB.ConnectionString = connString

                        End If


                    Next i
                    If String.IsNullOrEmpty(sosdesc) Or IsNothing(sosdesc) Then
                    Else
                        Dim ororo As Object
                        ororo = report.CompiledReport("mytitle")
                        If IsNothing(ororo) Then
                        Else

                            report("mytitle") = sosdesc

                        End If
                    End If
                Else
                End If

            Else
                FileCopy(appDirectory + "\Reports\" + "first1.mrt", appDirectory + "\Reports\" + reportFileName1 + ".mrt")

                Dim dbinerto As New dblayer
                Dim xinsert As Boolean
                xinsert = dbinerto.Insert("insert into mrtcontrollerName(controllerName,ReportCode) values ('" & controllername & "','" & reportFileName1 & "')")


                report.Load(appDirectory + "\Reports\" + reportFileName1 + ".mrt")

                report.Dictionary.DataSources.Clear()

                ds.Tables.Clear()
                '//

                Dim reportFileNamemosso As String = Context.Request("reportFileNamemosso")
                Dim reportFileNamemossopath As String = appDirectory + "\Reportsdata\"
                Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                Dim reader As New System.Xml.XmlTextReader(reportFileNamemossopath + reportFileNamemosso + ".xml")

                table.ReadXml(reader)



                If table IsNot Nothing Then
                    ds.Tables.Clear()
                    ds.Reset()
                    ds.Tables.Add(table)


                    report.Dictionary.DataSources.Clear()
                    report.RegData(ds)
                    report.CacheAllData = True

                    report.Dictionary.Synchronize()

                End If

                Dim reportPage As StiPage = report.Pages.Item(0)
                'Create HeaderBand
                Dim HeaderBand As New StiHeaderBand()
                HeaderBand.Height = 0.2
                HeaderBand.Name = "HeaderBand"
                reportPage.Components.Add(HeaderBand)

                'Create Databand 
                Dim Databand As New StiDataBand()
                Databand.DataSourceName = "table"
                Databand.Height = 0.2
                Databand.Name = "mosDataBand1"
                reportPage.Components.Add(Databand)


                'Create texts
                Dim Pos As Double = 0.1
                Dim hColumnWidth As Double = 0.8
                Dim dColumnWidth As Double = 0.8
                Dim allheight As Double = 0.2
                ' StiAlignValue.AlignToMinGrid(Page.Width / DS1.Columns.Count, 0.1, True)
                Dim NameIndex As Integer = 1

                Dim x1 As Integer = 0.0

                Dim Column As DataColumn

                For Each Column In ds.Tables(0).Columns

                    'Create text on header
                    If NameIndex < 11 Then
                        Dim HeaderText As New StiText(New RectangleD(Pos, 0, hColumnWidth, allheight))
                        HeaderText.Text.Value = Column.ColumnName
                        HeaderText.HorAlignment = StiTextHorAlignment.Center
                        HeaderText.Name = "HeaderText" + NameIndex.ToString()
                        HeaderText.Brush = New StiSolidBrush(Color.LightGreen)
                        HeaderText.Border.Side = StiBorderSides.All
                        HeaderBand.Components.Add(HeaderText)

                        'Create text on Data Band
                        Dim DataText As New StiText(New RectangleD(Pos, 0, dColumnWidth, allheight))
                        DataText.Text.Value = "{table." + Column.ColumnName + "}"
                        DataText.Name = "DataText" + NameIndex.ToString()
                        DataText.Border.Side = StiBorderSides.All


                        Databand.Components.Add(DataText)


                        Pos = Pos + 0.9

                    End If
                    NameIndex = NameIndex + 1

                Next

                'Create FooterBand
                Dim FooterBand As New StiFooterBand()
                FooterBand.Height = 0.2
                FooterBand.Name = "FooterBand"
                reportPage.Components.Add(FooterBand)

                'Create text on footer
                Dim FooterText As New StiText(New RectangleD(0, 0, reportPage.Width, 0.2))
                FooterText.Text.Value = "Count - {Count()}"
                FooterText.HorAlignment = StiTextHorAlignment.Right
                FooterText.Name = "FooterText"
                FooterText.Brush = New StiSolidBrush(Color.LightGreen)
                FooterBand.Components.Add(FooterText)

                report.Compile()





                StiWebDesigner1.Report = report
            End If
            Dim designflag, reportFileName As String
            designflag = Me.Request.QueryString.[Get]("designflag")
            If (designflag Is Nothing) Or (designflag = "false") Then
                REM report.Render(False)
                REM StiWebViewerFx1.CacheMode = StiCacheMode.Session
                REM StiWebViewerFx1.RenderMode = StiRenderMode.AjaxWithCache
                REM StiWebViewerFx1.PdfUseUnicode = True
                REM StiWebViewerFx1.PdfStandardFonts = True
                REM StiWebViewerFx1.Report = report
                REM 'StiWebViewerFx2.Report = report
                REM StiWebViewerFx1.Page.Title = translatemeyamosso.GetResourceValuemosso(reportFileName1)

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

                report.Render(False)

                Dim appDirectory1 As String = HttpContext.Current.Server.MapPath("~")
                Dim filenamefinal As String = reportFileName1 + username + timestampstring + ".pdf"
                Dim reportFileNamexz As String = appDirectory1 + "Pages\reportstock\web\" + filenamefinal
                Dim PdfExport As StiPdfExportService = New StiPdfExportService()
                'PdfExport.PdfUseUnicode = True
                ''report.PdfStandardFonts = True
                ''report.PdfUseUnicode = True
                ''report.PdfStandardFonts = True
                PdfExport.ExportPdf(report, reportFileNamexz)

                Response.Redirect("/pages/reportstock/web/pdfviewernewjr.aspx?file=" + filenamefinal)
                ''SReportFileName1 = reportFileNamexz
            Else
                appDirectory = HttpContext.Current.Server.MapPath("~")
                reportFileName1 = Me.Request.QueryString.[Get]("reportquery")
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
        controllername = Page.Request.QueryString.[Get]("controllername")
        viewname = "grid1" 'Page.Request.QueryString.[Get]("viewname")
        argfilter = Page.Request.QueryString.[Get]("argfilter")
        Dim ds As New DataSet()
        Dim table As DataTable
        '//Bind data in DataSet 
        ds.Tables.Clear()
        '//
        table = eZee.Rules.SharedBusinessRules.getdatatable(controllername, viewname, argfilter)
        'read table and push in Sqlserver
        If table IsNot Nothing Then
            'session either expired or invalid page being accessed.
            ds.Tables.Add(table)

            'ds.WriteXml("test.xml")
            '' report.Dictionary.DataSources.Clear()
            Dim xx As Stimulsoft.Report.Dictionary.StiDataTableSource
            'xx = ("NewDataSet.table")
            xx = report.Dictionary.DataSources("table")
            xx.ResetData()
            report.RegData(ds)
            report.CacheAllData = True
            report.Dictionary.Synchronize()
            'StiWebDesigner1.Report = report
            'report.Compile()
        End If
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

    'Protected Sub StiWebViewerFx1_GetDataSet(sender As Object, e As WebFx.StiWebViewerFx.StiGetDataSetEventArgs) Handles StiWebViewerFx1.GetDataSet
    '    controllername = Page.Request.QueryString.[Get]("controllername")
    '    viewname = "grid1" 'Page.Request.QueryString.[Get]("viewname")
    '    argfilter = Page.Request.QueryString.[Get]("argfilter")
    '    sosdesc = Page.Request.QueryString.[Get]("sosdesc")
    '    Dim ds As New DataSet()
    '    Dim table As DataTable
    '    ds.Tables.Clear()
    '    'Dim xx As Stimulsoft.Report.Dictionary.StiDataTableSource
    '    'xx = report.Dictionary.DataSources("table")
    '    'xx.ResetData()


    '    table = eZee.Rules.SharedBusinessRules.getdatatable(controllername, viewname, argfilter)
    '    'read table and push in Sqlserver
    '    If table IsNot Nothing Then

    '        ds.Tables.Add(table)


    '        e.DataSet = ds
    '        'report.RegData(ds)
    '        'report.CacheAllData = True
    '        'report.Dictionary.Synchronize()

    '        ' ''StiWebDesigner1.Report = report

    '        'If String.IsNullOrEmpty(sosdesc) Or IsNothing(sosdesc) Then
    '        'Else
    '        '    Dim ororo As Object
    '        '    ororo = report.CompiledReport("mytitle")
    '        '    If IsNothing(ororo) Then
    '        '    Else
    '        '        'argfilter = Replace(argfilter, "=%js%", "= :")
    '        '        'argfilter = Replace(argfilter, "$in$%js%", " in ")
    '        '        'argfilter = Replace(argfilter, "$notin$%js%", "not in ")
    '        '        'argfilter = Replace(argfilter, "$or$%js%", ",")
    '        '        'argfilter = Replace(argfilter, "&lt;&gt;%js%", "<>")
    '        '        'argfilter = Replace(argfilter, "$beginswith$%js%", "like ")
    '        '        'argfilter = Replace(argfilter, "$doesnotbeginwith$%js%", " not like ")
    '        '        'argfilter = Replace(argfilter, "$contains$%js%", " like ")
    '        '        'argfilter = Replace(argfilter, "=%js%\/Date", "=")
    '        '        report("mytitle") = sosdesc
    '        '        'report.Dictionary.Variables("mytitle").Value=argfilter
    '        '        'report.CompiledReport("mytitle").Text.Value=argfilter
    '        '        'report.Dictionary.Variables.Items(0).Value=argfilter
    '        '    End If
    '        'End If
    '    Else
    '    End If

    'End Sub


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