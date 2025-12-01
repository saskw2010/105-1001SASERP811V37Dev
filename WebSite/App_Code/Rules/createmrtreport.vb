Imports Microsoft.VisualBasic
Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports eZee.Web
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Xml.XPath
Imports System.Xml
Imports System.ComponentModel
Imports System.Text
Imports System.Data.SqlClient
Imports translatemeyamosso
Imports System.Configuration
Imports System.Data.Common
Imports System.IO
Imports System.Transactions
Imports System.Web
Imports System.Web.Caching
Imports System.Web.Configuration
Imports System.Web.Security
Imports System.Xml.Xsl
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports Stimulsoft.Report
Imports Stimulsoft.Report.Web
Imports Microsoft.VisualBasic.ApplicationServices
Imports Stimulsoft.Report.Dictionary
Imports Stimulsoft.Report.Components
Imports Stimulsoft.Base.Drawing
Imports Stimulsoft.Base
Imports System.Drawing
Namespace eZee.Data
    Class createmrtreport
        Public Sub New()
        End Sub
        Public Sub textseete(ByVal reportFileName1 As String, ByVal filteradress As String, ByVal filterarray As Array, ByVal table As DataTable)

            Dim report As New StiReport()
            Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
            If reportFileName1 IsNot Nothing Then
            Else
                reportFileName1 = "first1"
            End If
            Dim connString As String = ConnectionStringSettingsFactory.getconnection().ConnectionString
            If (System.IO.File.Exists(appDirectory + "\Reports\" + reportFileName1 + ".mrt")) Then
                report.Load(appDirectory + "\Reports\" + reportFileName1 + ".mrt")
                report.Compile()
                Dim sqlDB As Stimulsoft.Report.Dictionary.StiSqlDatabase
                For i = 0 To report.CompiledReport.Dictionary.Databases.Count - 1
                    sqlDB = report.CompiledReport.Dictionary.Databases(i)
                    If Not IsDBNull(sqlDB) Then
                        sqlDB.ConnectionString = connString

                    End If
                Next i
                'report.DataStore.Clear()
                'report.Dictionary.Databases.Clear()
                'report.Dictionary.Databases.Add(New Stimulsoft.Report.Dictionary.StiSqlDatabase("mosConnection1", connString))
                'Dim DS1 As Stimulsoft.Report.Dictionary.StiSqlSource = New Stimulsoft.Report.Dictionary.StiSqlSource("mosConnection1", "mosDataSource1", "mosDataSource1", table., True, False)
                'report.Dictionary.DataSources.Add(DS1)

                Dim idfilter As String = filteradress
                If idfilter IsNot Nothing Then

                    Dim parameter As Stimulsoft.Report.Dictionary.StiDataParameter = New Stimulsoft.Report.Dictionary.StiDataParameter()
                    parameter.Name = "PersonalCode"
                    parameter.Value = "932"
                    report.CompiledReport.DataSources(0).Parameters.Add(parameter)
                    'report.CompiledReport.DataSources(0).Parameters("PersonalCode").ParameterValue = CInt(idfilter)
                    report.CompiledReport.DataSources(0).Parameters("PersonalCode") = parameter
                    report.Save(HttpContext.Current.Server.MapPath("~/Reports/" + reportFileName1 + ".mrt"))
                End If
            End If
        End Sub
        Public Sub createmrtreport1(ByVal reportFileName1 As String, ByVal controllername As String)
            Dim report As New StiReport()
            Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
            FileCopy(appDirectory + "\Reports\" + "first1.mrt", appDirectory + "\Reports\" + reportFileName1 + ".mrt")
            'Try to update sql source to view grid1 on the name of controoler
            Dim moscommand As DbCommand
            Dim connection1 As DbConnection
            Dim factory As System.Data.Common.DbProviderFactory
            factory = System.Data.Common.DbProviderFactories.GetFactory("System.Data.SqlClient")
            connection1 = factory.CreateConnection()
            Dim connString As String = ConnectionStringSettingsFactory.getconnection().ConnectionString
            connection1.ConnectionString = connString
            connection1.Open()
            moscommand = getcommand("command1", connection1, controllername)
            Dim sqlCommand As String = moscommand.CommandText
            Dim ds As DataSet = GetDataSet(sqlCommand, connString)
            report.Load(appDirectory + "\Reports\" + reportFileName1 + ".mrt")
            'Dim sqlconnection As New SqlConnection(connString)
            'report.RegData("connection1", sqlconnection)
            'report.RegData("DataSource1", ds)
            report.DataStore.Clear()
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
            HeaderBand.Height = 0.5
            HeaderBand.Name = "HeaderBand"
            Page.Components.Add(HeaderBand)

            'Create Databand 
            Dim Databand As New StiDataBand()
            Databand.DataSourceName = "mosDataSource1"
            Databand.Height = 0.4 * 5 / 2
            Databand.Name = "mosDataBand1"
            Page.Components.Add(Databand)
            'Create texts
            Dim Pos As Double = 0.1
            Dim hColumnWidth As Double = 1.1
            Dim dColumnWidth As Double = 2.5
            Dim allheight As Double = 0.2
            ' StiAlignValue.AlignToMinGrid(Page.Width / DS1.Columns.Count, 0.1, True)
            Dim NameIndex As Integer = 1
            Dim right As Boolean = True
            Dim x1 As Integer = 0.1
            Dim x2 As Integer = 1.3
            Dim Column As Stimulsoft.Report.Dictionary.StiDataColumn

            For Each Column In DS1.Columns
                If right = True Then
                    x1 = 0.1
                    x2 = 1.3
                ElseIf right = False Then
                    x1 = 3.9
                    x2 = 5.1
                End If
                'Create text on header
                If NameIndex < 9 Then
                    Dim HeaderText As New StiText(New RectangleD(x1, Pos, hColumnWidth, allheight))
                    HeaderText.Text.Value = Column.Name
                    HeaderText.HorAlignment = StiTextHorAlignment.Center
                    HeaderText.Name = "HeaderText" + NameIndex.ToString()
                    HeaderText.Brush = New StiSolidBrush(Color.LightGreen)
                    HeaderText.Border.Side = StiBorderSides.All
                    HeaderBand.Components.Add(HeaderText)

                    'Create text on Data Band
                    Dim DataText As New StiText(New RectangleD(x2, Pos, dColumnWidth, allheight))
                    DataText.Text.Value = "{mosDataSource1." + Column.Name + "}"
                    DataText.Name = "DataText" + NameIndex.ToString()
                    DataText.Border.Side = StiBorderSides.All

                    'Add highlight
                    'Dim Condition As StiCondition = New StiCondition()
                    'Condition.BackColor = Color.CornflowerBlue
                    'Condition.TextColor = Color.Black
                    'Condition.Expression.Value = "(Line And 1) = 1"
                    'Condition.Item = StiFilterItem.Expression
                    'DataText.Conditions.Add(Condition)

                    Databand.Components.Add(DataText)

                    Pos = Pos + 0.4
                    If right = True Then
                        right = False
                    ElseIf right = False Then
                        right = False
                    End If
                End If
                NameIndex = NameIndex + 1

            Next

            'Create FooterBand
            Dim FooterBand As New StiFooterBand()
            FooterBand.Height = 0.5
            FooterBand.Name = "FooterBand"
            Page.Components.Add(FooterBand)

            'Create text on footer
            Dim FooterText As New StiText(New RectangleD(0, 0, Page.Width, 0.5))
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

            report.Save(HttpContext.Current.Server.MapPath("~/Reports/" + reportFileName1 + ".mrt"))



            'StiWebDesigner1.Design(report)
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

    End Class
End Namespace
