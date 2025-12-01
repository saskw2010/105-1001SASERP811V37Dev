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

Partial Public Class Controls_wexreport
    Inherits Global.System.Web.UI.UserControl
    Private reportFileName1 As String = Nothing
    Private report As New StiReport()
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'If StiWebViewer1.IsImageRequest Then
        '    Return
        'End If
        If IsPostBack Then
        Else

            Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
            Dim controllernamenew As String = Page.Request.QueryString.[Get]("reportquery")
            reportFileName1 = Page.Request.QueryString.[Get]("reportquery")
            If IsNothing(Page.Request.QueryString.[Get]("sosoname")) Then
            Else
                reportFileName1 = reportFileName1 + Page.Request.QueryString.[Get]("sosoname")
            End If

            If reportFileName1 IsNot Nothing Then
            Else
                reportFileName1 = "first1"
            End If
            Dim connString As String = ConnectionStringSettingsFactory.getconnection().ConnectionString
            If (System.IO.File.Exists(appDirectory + "\Reports\" + reportFileName1 + ".mrt")) Then
                report.Load(appDirectory + "\Reports\" + reportFileName1 + ".mrt")
                Dim CacheFolder As String = System.IO.Path.Combine(appDirectory, "StimulsoftReportsCache")
                If Not System.IO.Directory.Exists(CacheFolder) Then
                    System.IO.Directory.CreateDirectory(CacheFolder)
                End If





                Dim sqlDB1 As Stimulsoft.Report.Dictionary.StiSqlDatabase
                For i = 0 To report.Dictionary.Databases.Count - 1
                    sqlDB1 = report.Dictionary.Databases(i)
                    If Not IsDBNull(sqlDB1) Then
                        sqlDB1.ConnectionString = connString

                    End If

                Next i

                'report.ReportCachePath = CacheFolder
                'report.ReportCacheMode = Stimulsoft.Report.StiReportCacheMode.On
                report.CacheAllData = True
                report.Dictionary.Synchronize()
                report.Compile()
                Dim sqlDB1p As Stimulsoft.Report.Dictionary.StiSqlDatabase
                For i = 0 To report.CompiledReport.Dictionary.Databases.Count - 1
                    sqlDB1p = report.CompiledReport.Dictionary.Databases(i)
                    If Not IsDBNull(sqlDB1p) Then
                        sqlDB1p.ConnectionString = connString

                    End If

                Next i
                Dim idfilter As String = Page.Request.QueryString.[Get]("idfilter")
                If idfilter IsNot Nothing Then
                    Dim xodd As Object
                    xodd = report.CompiledReport.DataSources(0).Parameters(0)
                    If xodd IsNot Nothing Then
                        report.CompiledReport.DataSources(0).Parameters(0).ParameterValue = CInt(idfilter)
                    End If
                    If report.CompiledReport.DataSources.Count > 1 Then
                        Dim xod As Object
                        xod = report.CompiledReport.DataSources(1)
                        If xod IsNot Nothing Then
                            report.CompiledReport.DataSources(1).Parameters(0).ParameterValue = CInt(idfilter)
                        End If
                    End If
                    If report.CompiledReport.DataSources.Count > 2 Then
                        Dim xodx As Object
                        xodx = report.CompiledReport.DataSources(2)
                        If xodx IsNot Nothing Then
                            If report.CompiledReport.DataSources(2).Parameters.Count > 0 Then
                                report.CompiledReport.DataSources(2).Parameters(0).ParameterValue = CInt(idfilter)
                            End If
                        End If
                    End If
                    If report.CompiledReport.DataSources.Count > 3 Then
                        Dim xodx As Object
                        xodx = report.CompiledReport.DataSources(3)
                        If xodx IsNot Nothing Then
                            If report.CompiledReport.DataSources(3).Parameters.Count > 0 Then
                                report.CompiledReport.DataSources(3).Parameters(0).ParameterValue = CInt(idfilter)
                            End If
                        End If
                    End If
                    If report.CompiledReport.DataSources.Count > 4 Then
                        Dim xodx As Object
                        xodx = report.CompiledReport.DataSources(4)
                        If xodx IsNot Nothing Then
                            If report.CompiledReport.DataSources(4).Parameters.Count > 0 Then
                                report.CompiledReport.DataSources(4).Parameters(0).ParameterValue = CInt(idfilter)
                            End If
                        End If
                    End If
                    If report.CompiledReport.DataSources.Count > 5 Then
                        Dim xodx As Object
                        xodx = report.CompiledReport.DataSources(5)
                        If xodx IsNot Nothing Then
                            If report.CompiledReport.DataSources(5).Parameters.Count > 0 Then
                                report.CompiledReport.DataSources(5).Parameters(0).ParameterValue = CInt(idfilter)
                            End If
                        End If
                    End If
                    If report.CompiledReport.DataSources.Count > 6 Then
                        Dim xodx As Object
                        xodx = report.CompiledReport.DataSources(6)
                        If xodx IsNot Nothing Then
                            If report.CompiledReport.DataSources(6).Parameters.Count > 0 Then
                                report.CompiledReport.DataSources(6).Parameters(0).ParameterValue = CInt(idfilter)
                            End If
                        End If
                    End If
                End If
                Dim sosdesc As String = Nothing
                sosdesc = Context.Request("sosdesc")
                If String.IsNullOrEmpty(sosdesc) Or IsNothing(sosdesc) Then
                Else
                    Dim ororo As Object
                    ororo = report.CompiledReport("mytitle")
                    If IsNothing(ororo) Then
                    Else

                        report("mytitle") = sosdesc

                    End If
                End If

                Dim idfilter1 As String = Page.Request.QueryString.[Get]("idfilter")
                If idfilter1 IsNot Nothing Then
                    Dim ororo As Object
                    ororo = report.CompiledReport("var1")
                    If IsNothing(ororo) Then
                    Else

                        report("var1") = CInt(idfilter1)

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
                '------------------------------------------------------------------------
                Dim myvar1 As String = Page.Request.QueryString.[Get]("myvar1")
                If myvar1 IsNot Nothing Then
                    Dim ororo1 As Object
                    ororo1 = report.CompiledReport("myvar1")
                    If IsNothing(ororo1) Then
                    Else

                        report("myvar1") = CStr(myvar1)

                    End If
                End If
                '------------------------------------------------------------------------
                Dim myvar2 As String = Page.Request.QueryString.[Get]("myvar2")
                If myvar2 IsNot Nothing Then
                    Dim ororo2 As Object
                    ororo2 = report.CompiledReport("myvar2")
                    If IsNothing(ororo2) Then
                    Else

                        report("myvar2") = CStr(myvar2)

                    End If
                End If
                '------------------------------------------------------------------------
                Dim myvar3 As String = Page.Request.QueryString.[Get]("myvar3")
                If myvar3 IsNot Nothing Then
                    Dim ororo3 As Object
                    ororo3 = report.CompiledReport("myvar3")
                    If IsNothing(ororo3) Then
                    Else

                        report("myvar3") = CStr(myvar3)

                    End If
                End If
                '------------------------------------------------------------------------
                Dim myvar4 As String = Page.Request.QueryString.[Get]("myvar4")
                If myvar4 IsNot Nothing Then
                    Dim ororo4 As Object
                    ororo4 = report.CompiledReport("myvar4")
                    If IsNothing(ororo4) Then
                    Else

                        report("myvar4") = CStr(myvar4)

                    End If
                End If
                '------------------------------------------------------------------------
                Dim myvar5 As String = Page.Request.QueryString.[Get]("myvar5")
                If myvar5 IsNot Nothing Then
                    Dim ororo5 As Object
                    ororo5 = report.CompiledReport("myvar5")
                    If IsNothing(ororo5) Then
                    Else

                        report("myvar5") = CStr(myvar5)

                    End If
                End If
                '------------------------------------------------------------------------
                Dim myvar6 As String = Page.Request.QueryString.[Get]("myvar6")
                If myvar6 IsNot Nothing Then
                    Dim ororo6 As Object
                    ororo6 = report.CompiledReport("myvar6")
                    If IsNothing(ororo6) Then
                    Else

                        report("myvar6") = CStr(myvar6)

                    End If
                End If
                '------------------------------------------------------------------------
                Dim myvar7 As String = Page.Request.QueryString.[Get]("myvar7")
                If myvar7 IsNot Nothing Then
                    Dim ororo7 As Object
                    ororo7 = report.CompiledReport("myvar7")
                    If IsNothing(ororo7) Then
                    Else

                        report("myvar7") = CStr(myvar7)

                    End If
                End If
                '------------------------------------------------------------------------
                Dim myvar8 As String = Page.Request.QueryString.[Get]("myvar8")
                If myvar8 IsNot Nothing Then
                    Dim ororo8 As Object
                    ororo8 = report.CompiledReport("myvar8")
                    If IsNothing(ororo8) Then
                    Else

                        report("myvar8") = CStr(myvar8)

                    End If
                End If

                'Dim img As New Stimulsoft.Report.Components.StiImage
                'img.Image = System.Drawing.Image.FromFile(HttpContext.Current.Server.MapPath("~/Images/1.jpg"))
                Dim xo As Object
                xo = report.CompiledReport("MyImage")
                If xo IsNot Nothing Then
                    Dim idfiltercar As String = Page.Request.QueryString.[Get]("CarNo")
                    If idfiltercar IsNot Nothing Then
                        If (File.Exists(HttpContext.Current.Server.MapPath("~/Images/" + idfiltercar + ".jpg"))) Then
                            report.CompiledReport("MyImage").file = HttpContext.Current.Server.MapPath("~/Images/" + idfiltercar + ".jpg")

                        Else
                            report.CompiledReport("MyImage").file = HttpContext.Current.Server.MapPath("~/Images/LocalMap.jpg")   ' //It is ok now.
                        End If
                    End If
                End If

                'StiWebViewer1.PrintDestination = StiPrintDestination.Pdf

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



                report.Render(False)
                'report.Save(Server.MapPath("~/Reports/" + reportFileName1 + ".mrt"))
                'StiWebViewer1.CacheMode = Stimulsoft.Report.Web.StiCacheMode.Session
                'StiWebViewer1.RenderMode = StiRenderMode.AjaxWithCache
                'StiWebViewer1.PdfUseUnicode = True
                'StiWebViewer1.PdfStandardFonts = True
                'StiWebViewer1.PdfUseUnicode = True
                'StiWebViewer1.PdfStandardFonts = True
                StiWebDesigner1.Visible = False

                StiWebViewer1.Report = report
                '
                'Create Printer Settings
                '
                'Dim PrinterSettings As New PrinterSettings
                'Dim pd As New System.Windows.Forms.PrintDialog
                'pd.ShowDialog()

                'StiWebViewer1.Report.Print(False, pd.PrinterSettings)
                'StiWebViewer1.Report.Web.StiReportResponse.ResponseAsPdf(me.page, report) 


                'Set Printer to Use for Printing

                'PrinterSettings.PrinterName = "MyPrinterName"



                'Direct Print - Don't Show Print Dialog

                'Report.Print(False)

            Else
                FileCopy(appDirectory + "\Reports\" + "first1.mrt", appDirectory + "\Reports\" + reportFileName1 + ".mrt")
                'Try to update sql source to view grid1 on the name of controoler
                Dim dbinerto As New dblayer
                Dim xinsert As Boolean
                xinsert = dbinerto.Insert("insert into mrtcontrollerName(controllerName,ReportCode) values ('" & controllernamenew & "','" & reportFileName1 & "')")
                Dim moscommand As DbCommand
                Dim connection1 As DbConnection
                Dim factory As System.Data.Common.DbProviderFactory
                factory = System.Data.Common.DbProviderFactories.GetFactory("System.Data.SqlClient")
                connection1 = factory.CreateConnection()
                connection1.ConnectionString = connString
                connection1.Open()
                moscommand = getcommand("command1", connection1, controllernamenew)
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
                Databand.Height = 10.2
                Databand.Name = "mosDataBand1"
                Page.Components.Add(Databand)


                'Create texts
                Dim Pos As Double = 0.0
                Dim hColumnWidth As Double = 1.5
                Dim dColumnWidth As Double = 2.1
                Dim allheight As Double = 0.2
                ' StiAlignValue.AlignToMinGrid(Page.Width / DS1.Columns.Count, 0.1, True)
                Dim NameIndex As Integer = 1
                Dim right As Boolean = True
                Dim x1 As Integer = 0.0
                Dim x2 As Integer = 1.6
                Dim Column As Stimulsoft.Report.Dictionary.StiDataColumn

                For Each Column In DS1.Columns
                    ' If right = True Then
                    '    x1 = 0.0
                    '    x2 = 1.6
                    ' ElseIf right = False Then
                    '     x1 = 4.0
                    '     x2 = 5.6
                    ' End If
                    'Create text on header
                    If NameIndex < 20 Then
                        Dim HeaderText As New StiText(New RectangleD(0.0, Pos, hColumnWidth, allheight))
                        HeaderText.Text.Value = Column.Name
                        HeaderText.HorAlignment = StiTextHorAlignment.Center
                        HeaderText.Name = "HeaderText" + NameIndex.ToString()
                        HeaderText.Brush = New StiSolidBrush(Color.Gainsboro)
                        HeaderText.Border.Side = StiBorderSides.All
                        Databand.Components.Add(HeaderText)

                        'Create text on Data Band
                        Dim DataText As New StiText(New RectangleD(1.6, Pos, dColumnWidth, allheight))
                        DataText.Text.Value = "{mosDataSource1." + Column.Name + "}"
                        DataText.Name = "DataText" + NameIndex.ToString()
                        DataText.Brush = New StiSolidBrush(Color.CornflowerBlue)
                        DataText.Border.Side = StiBorderSides.All

                        Dim HeaderText1 As New StiText(New RectangleD(4.0, Pos, hColumnWidth, allheight))
                        HeaderText1.Text.Value = Column.Name
                        HeaderText1.HorAlignment = StiTextHorAlignment.Center
                        HeaderText1.Name = "Header2Text" + NameIndex.ToString()
                        HeaderText1.Brush = New StiSolidBrush(Color.Gainsboro)
                        HeaderText1.Border.Side = StiBorderSides.All
                        Databand.Components.Add(HeaderText1)

                        'Create text on Data Band
                        Dim DataText1 As New StiText(New RectangleD(5.6, Pos, dColumnWidth, allheight))
                        DataText1.Text.Value = "{mosDataSource1." + Column.Name + "}"
                        DataText1.Name = "Data2Text" + NameIndex.ToString()
                        DataText1.Brush = New StiSolidBrush(Color.CornflowerBlue)
                        DataText1.Border.Side = StiBorderSides.All
                        'Add highlight
                        'Dim Condition As StiCondition = New StiCondition()
                        'Condition.BackColor = Color.CornflowerBlue
                        'Condition.TextColor = Color.Black
                        'Condition.Expression.Value = "(Line And 1) = 1"
                        'Condition.Item = StiFilterItem.Expression
                        'DataText.Conditions.Add(Condition)

                        Databand.Components.Add(DataText)

                        Pos = Pos + 0.3
                        ' If right = True Then
                        '     right = False
                        ' ElseIf right = False Then
                        '     right = False
                        ' End If
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
                Dim sqlDB2 As Stimulsoft.Report.Dictionary.StiSqlDatabase
                For i = 0 To report.CompiledReport.Dictionary.Databases.Count - 1
                    sqlDB2 = report.CompiledReport.Dictionary.Databases(i)
                    If Not IsDBNull(sqlDB2) Then
                        sqlDB2.ConnectionString = connString

                    End If
                Next i
                'Dim datsource As Stimulsoft.Report.Dictionary.StiSqlSource
                'For i = 0 To report.CompiledReport.Dictionary.DataSources.Count - 1
                '    datsource = report.CompiledReport.Dictionary.DataSources(i)
                '    If Not IsDBNull(sqlDB) Then
                '        datsource.SqlCommand = sqlCommand

                '    End If

                'Next i




                StiWebDesigner1.Report = report
            End If


            '   If StiWebViewerFx1.Visible = True Then
            '      StiWebViewerFx1.Report = report
            '      StiWebViewerFx1.BrowserTitle = reportFileName1
            '   End If


            'StiReportResponse.ResponseAsPdf(Me.Page, report)

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

    Protected Sub StiWebDesigner1_SaveReport(ByVal sender As Object, ByVal e As StiMobileDesigner.StiSaveReportEventArgs) Handles StiWebDesigner1.SaveReport
        Dim report As StiReport = e.Report
        Dim str As String = report.SavePackedReportToString()
        Page.Cache.Add(report.ReportGuid, str, Nothing, Cache.NoAbsoluteExpiration, New TimeSpan(0, 5, 0), System.Web.Caching.CacheItemPriority.Low,
         Nothing)
        Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")

        reportFileName1 = Page.Request.QueryString.[Get]("reportquery")
        If IsNothing(Page.Request.QueryString.[Get]("sosoname")) Then
        Else
            reportFileName1 = reportFileName1 + Page.Request.QueryString.[Get]("sosoname")
        End If
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
        If IsNothing(Page.Request.QueryString.[Get]("sosoname")) Then
        Else
            reportFileName1 = reportFileName1 + Page.Request.QueryString.[Get]("sosoname")
        End If
        Dim reportFileName As String = appDirectory + "\Reports\" + reportFileName1 + ".mrt"
        If Not reportFileName Is Nothing Then
            Dim report As StiReport = New StiReport()
            report.Load(reportFileName)
            report.ReportName = reportFileName1
            StiWebViewer1.Visible = False
            StiWebDesigner1.Visible = True
            StiWebDesigner1.Report = report
        End If
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