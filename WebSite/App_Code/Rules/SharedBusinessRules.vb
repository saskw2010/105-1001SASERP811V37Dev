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
Imports System.Reflection
Imports eZee.Data.Objects
Imports Telerik
Imports Telerik.Web
Imports DataLogic
Imports Microsoft.VisualBasic
Namespace eZee.Rules

    Partial Public Class SharedBusinessRules
        Inherits eZee.Data.BusinessRules

        Public Sub New()
            MyBase.New()
        End Sub


        Public Function getuseremail() As String

            Dim user As MembershipUser = Membership.GetUser(UserName)
            'Dim user As newmembership = newmembership.SelectSingle(newUser.ProviderUserKey)
            If (Not (user) Is Nothing) Then
                Dim userApplicationId1 As String
                userApplicationId1 = user.Email
                Return userApplicationId1
            Else
                Return "   _no_n0_name////   "
            End If
        End Function


        '<ControllerAction(, "editForm1", "Update", ActionPhase.Before)>
        'Public Sub AssignFieldValuesToschApplicationedit()

        '    Result.ShowMessage("Custom:   " & args.CommandName)

        '    Dim Requestsx As New PageRequest
        '        Requestsx.Controller = args.Controller
        '        Requestsx.View = args.View
        '        Requestsx.SortExpression = args.SortExpression
        '        If (Not (args.Filter) Is Nothing) Then
        '            'Dim dve As eZee.Web.DataViewExtender = New DataViewExtender()
        '            'dve.AssignStartupFilter(args.Filter)
        '            Requestsx.Filter = args.Filter.ToArray()
        '        End If
        '        Request.PageSize = Int32.MaxValue
        '        Request.RequiresRowCount = True
        '        Request.RequiresMetaData = True
        '        Dim page As ViewPage = ControllerFactory.CreateDataController.GetPage(Requestsx.Controller, Requestsx.View, Requestsx)
        '        Dim tablerequestreport1 As DataTable = page.ToDataTable()
        '        'context.Session("tablerequestreport") = tablerequestreport1
        '        Dim appDirectory1 As String = HttpContext.Current.Server.MapPath("~")
        '        Dim username As String
        '        Dim timestampstring As String
        '        username = HttpContext.Current.User.Identity.Name()
        '        timestampstring = System.DateTime.Now.ToString("yyyyMMddHHmmss")
        '        Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        '        Dim reportFileNamemossopath As String = appDirectory1 + "\Reportsdata\" ' mydocpath
        '        Dim reportFileNamemosso As String = "mostafaxlml" + username + timestampstring
        '        'Dim writer = New XmlTextWriter(@"C:\test.xml", encoding.)
        '        Dim utfencoder As Encoding = UTF8Encoding.GetEncoding("UTF-8", New EncoderReplacementFallback(""), New DecoderReplacementFallback(""))
        '        Dim sbWrite As New StringBuilder()
        '        Dim strWrite As New StringWriter(sbWrite)
        '        Dim xmlWrite As New CustomXmlWriter(reportFileNamemossopath + reportFileNamemosso + ".xml", UTF8Encoding.GetEncoding("UTF-8", New EncoderReplacementFallback(""), New DecoderReplacementFallback("")))

        '        tablerequestreport1.WriteXml(xmlWrite, System.Data.XmlWriteMode.WriteSchema)

        '        xmlWrite.Flush()
        '        xmlWrite.Close()

        '    End If
        'End Sub
        Protected Overrides Sub AfterSqlAction(args As ActionArgs, result As ActionResult)
            If (result.Errors.Count = 0 And Arguments.CommandName = "Update" Or Arguments.CommandName = "Report" Or
                Arguments.CommandName = "Insert" Or Arguments.CommandName = "Delete") Then

                Dim dbinerto As New dblayer
                Dim xinsert As Boolean
                xinsert = dbinerto.Insert("insert into webuserlog([username] ,[controllername]  ,[viewnm]  ,[Actionnm] ,[Actionargument]) values ('" & HttpContext.Current.User.Identity.Name & "','" & args.Controller & "','" & args.View & "','" & Arguments.CommandName & "','" & Arguments.CommandArgument & "')")


                result.Continue()

            End If



        End Sub

        Protected Overrides Sub ExecuteAction(args As ActionArgs, result As ActionResult)
            If (args.CommandName = "Report") Then
                result.ShowMessage("Report" & args.CommandName)

            ElseIf (args.CommandName = "Custom") Then
                result.ShowMessage("Custom:   " & args.CommandName)
            End If
        End Sub
        Public Shared Function getdatatable(argsController As String, argsView As String, argfilter As String) As DataTable

            Dim Request As New PageRequest
            Request.Controller = argsController
            Dim mArr() As String
            mArr = Split(argfilter, "-mos//tafa//-")
            Request.Filter = mArr
            Request.ExternalFilter = Nothing
            Request.View = argsView
            Request.SortExpression = Nothing
            Request.PageSize = 1000000
            Request.RequiresRowCount = True
            Request.RequiresMetaData = True
            Dim page As ViewPage = ControllerFactory.CreateDataController.GetPage(argsController, argsView, Request)
            Dim table As DataTable = page.ToDataTable()
            Return table
        End Function
        Public Shared Function getdatatable2016() As DataTable

            Dim Request As New PageRequest
            Request.Controller = eZee.Data.ActionArgs.Current.Controller
            Request.Filter = eZee.Data.ActionArgs.Current.Filter
            Request.ExternalFilter = eZee.Data.ActionArgs.Current.ExternalFilter
            Request.View = eZee.Data.ActionArgs.Current.View
            Request.SortExpression = eZee.Data.ActionArgs.Current.SortExpression
            Request.PageSize = 10000000
            Request.RequiresRowCount = True
            Request.RequiresMetaData = True
            Dim page As ViewPage = ControllerFactory.CreateDataController.GetPage(eZee.Data.ActionArgs.Current.Controller, eZee.Data.ActionArgs.Current.View, Request)
            Dim table As DataTable = page.ToDataTable()
            'Dim appDirectory1 As String = HttpContext.Current.Server.MapPath("~")
            'Dim username As String
            'Dim timestampstring As String
            'username = HttpContext.Current.User.Identity.Name()
            'timestampstring = System.DateTime.Now.ToString("yyyyMMddHHmmss")
            'Dim reportFileName As String = appDirectory1 + "\Reports\mostafaxlml" + username + timestampstring + ".xml"
            'table.WriteXml(reportFileName, System.Data.XmlWriteMode.IgnoreSchema)
            'Dim reportFileName1 As String = appDirectory1 + "\Reports\mostafaxlml" + username + timestampstring + ".xsd"
            'table.WriteXmlSchema(reportFileName1)
            Return table
        End Function
        Protected Overrides Sub EnumerateDynamicAccessControlRules(controllerName As String)

            If (IsTagged("searchme")) Then
                If IsNothing(Context.Session("HomePhoneText")) Or String.IsNullOrEmpty(Context.Session("HomePhoneText")) Then
                    Context.Session("HomePhoneText") = "0"
                End If

                If IsNothing(Context.Session("HomePhoneText")) Or String.IsNullOrEmpty(Context.Session("HomePhoneText")) Then
                Else
                    Select Case controllerName ' check table then put it or no by select from informationschema where table 
                        Case "TblAppointments"
                            RegisterAccessControlRule("IDATUTO", "IDATUTO in(select IDATUTO from TblAppointments where HomePhone=@HomePhone OR MobilePhone=@MobilePhone )", AccessPermission.Allow,
                       New SqlParam("@HomePhone", Context.Session("HomePhoneText")), New SqlParam("@MobilePhone", Context.Session("HomePhoneText")))

                            ' Case "TblAppointmentsArchive"
                            '    RegisterAccessControlRule("Archivid", "Archivid in(select Archivid from TblAppointmentsArchive where HomePhone=@HomePhone OR MobilePhone=@MobilePhone )", AccessPermission.Allow,
                            'New SqlParam("@HomePhone", Context.Session("HomePhoneText")), New SqlParam("@MobilePhone", Context.Session("HomePhoneText")))
                            ' Case "Tbl_ArchAppoint"
                            '     RegisterAccessControlRule("ArchAppointAutoid", "ArchAppointAutoid in(select ArchAppointAutoid from Tbl_ArchAppoint where HomePhone=@HomePhone OR MobilePhone=@MobilePhone )", AccessPermission.Allow,
                            ' New SqlParam("@HomePhone", Context.Session("HomePhoneText")), New SqlParam("@MobilePhone", Context.Session("HomePhoneText")))

                            '---------------------------------------------------
                        Case "HomePhoneliststatus"
                            RegisterAccessControlRule("HomePhonelook", "HomePhonelook=@HomePhone", AccessPermission.Allow,
                       New SqlParam("@HomePhone", Context.Session("HomePhoneText")))

                        Case "TblCustomers"
                            RegisterAccessControlRule("Rainbow_no", "Rainbow_no in(select Rainbow_no from TblCustomers where HomePhone=@HomePhone OR MobilePhone=@MobilePhone OR Workphone=@Workphone )", AccessPermission.Allow,
                       New SqlParam("@HomePhone", Context.Session("HomePhoneText")), New SqlParam("@MobilePhone", Context.Session("HomePhoneText")), New SqlParam("@Workphone", Context.Session("HomePhoneText")))
                            'Case "TblCustomersArchive"
                            '    RegisterAccessControlRule("Archiveidauo", "Archiveidauo in(select Archiveidauo from TblCustomersArchive where HomePhone=@HomePhone OR MobilePhone=@MobilePhone OR Workphone=@Workphone )", AccessPermission.Allow,
                            '         New SqlParam("@HomePhone", Context.Session("HomePhoneText")), New SqlParam("@MobilePhone", Context.Session("HomePhoneText")), New SqlParam("@Workphone", Context.Session("HomePhoneText")))

                            'Case "Tbl_ArchCustomers"
                            '    RegisterAccessControlRule("Rainbow_no", "Rainbow_no in(select Rainbow_no from Tbl_ArchCustomers where HomePhone=@HomePhone OR MobilePhone=@MobilePhone OR Workphone=@Workphone )", AccessPermission.Allow,
                            '         New SqlParam("@HomePhone", Context.Session("HomePhoneText")), New SqlParam("@MobilePhone", Context.Session("HomePhoneText")), New SqlParam("@Workphone", Context.Session("HomePhoneText")))



                        Case Else
                    End Select
                End If
            End If
            'AddTag("UserIsInformed")




            If HttpContext.Current.User.Identity.IsAuthenticated Then
                If UserIsInRole("Administrator") Then
                    'UnrestrictedAccess()
                ElseIf UserIsInRole("Administrators") Then
                    RegisterAccessControlRule("CompanyAccount", "CompanyAccount=@CompanyAccount", AccessPermission.Allow,
                   New SqlParam("@CompanyAccount", companycode()))
                    RegisterAccessControlRule("RoleName", "RoleName=@RoleName", AccessPermission.Deny,
                                      New SqlParam("@RoleName", "Administrator"))

                Else
                    RegisterAccessControlRule("CompanyAccount", "CompanyAccount=@CompanyAccount", AccessPermission.Allow,
                    New SqlParam("@CompanyAccount", companycode()))

                    RegisterAccessControlRule("RoleName", "RoleName=@RoleName", AccessPermission.Deny,
                                      New SqlParam("@RoleName", "Administrator"))

                    RegisterAccessControlRule("activeflage", "activeflage=@activeflage", AccessPermission.Deny,
                                        New SqlParam("@activeflage", 0))
                    RegisterAccessControlRule("activeflageD", "activeflageD=@activeflageD", AccessPermission.Deny,
                                        New SqlParam("@activeflageD", 0))
                    RegisterAccessControlRule("activeflagetele", "activeflagetele=@activeflagetele", AccessPermission.Deny,
                                        New SqlParam("@activeflagetele", 0))
                    RegisterAccessControlRule("activeflageserviced", "activeflageserviced=@activeflageserviced", AccessPermission.Deny,
                     New SqlParam("@activeflageserviced", 0))
                    Select Case controllerName ' check table then put it or no by select from informationschema where table 
                        Case "schApplication1001", "schApplication1002"
                            If getThebranchDesc1("schApplication") = "" Then
                            Else
                                RegisterAccessControlRule("branch", getThebranchDesc1("schApplication"), AccessPermission.Allow)
                            End If
                        Case "EVOL_Memo"
                            RegisterAccessControlRule("ID", " EVOL_Memo.ID in (select id from EVOLMemo where UserName=@UserName)", AccessPermission.Allow, New SqlParam("@UserName", HttpContext.Current.User.Identity.Name))
                        Case Else
                            If getThebranchDesc1(controllerName) = "" Then
                            Else
                                RegisterAccessControlRule("branch", getThebranchDesc1(controllerName), AccessPermission.Allow)

                            End If
                            If getThebranchDesc1sgm(controllerName) = "" Then
                            Else
                                RegisterAccessControlRule("sgm", getThebranchDesc1sgm(controllerName), AccessPermission.Allow)

                            End If
                    End Select
                End If
            End If
        End Sub
        Public Function getsgmusername() As String
            Dim myIntsgm As String = HttpContext.Current.User.Identity.Name
            If String.IsNullOrEmpty(myIntsgm) Then
                Return "   _"
            Else
                Return myIntsgm
            End If
        End Function
        Public Function getmycashaccount() As String
            Dim myIntsgm As String = 1 ' HttpContext.Current.User.Identity.Name
            If String.IsNullOrEmpty(myIntsgm) Then
                Return "   _"
            Else
                Return myIntsgm
            End If
        End Function
        Public Function getmysalesaccount() As String
            Dim myIntsgm As String = 1 'HttpContext.Current.User.Identity.Name
            If String.IsNullOrEmpty(myIntsgm) Then
                Return "   _"
            Else
                Return myIntsgm
            End If
        End Function
        Public Function getmyfirstbranch() As String
            Dim myIntsgm As String = 1
            If UserIsInRole("Administrator") Or UserIsInRole("Administrators") Then
                Return myIntsgm
            Else

                Using calc As SqlText = New SqlText("select Top(1) brn_no from QUserdetailsegmentbrnch where UserName='" & HttpContext.Current.User.Identity.Name & "'")

                    Dim total As Object = calc.ExecuteScalar()
                    If DBNull.Value.Equals(total) Then
                        myIntsgm = 1

                    Else

                        myIntsgm = Convert.ToDecimal(total).ToString

                    End If
                End Using
                Return myIntsgm

            End If
        End Function
        Public Function companycode() As String
            Dim myInt As String = HttpContext.Current.Session("nameofmycompany")
            If String.IsNullOrEmpty(myInt) Then
                Return "   _"
            Else
                Return myInt
            End If

        End Function
        Public Function getThebranchDesc1sgm(controllerName As String) As String
            If IsNothing(HttpContext.Current.Session("getThebranchDesc1sgm")) Or String.IsNullOrEmpty(HttpContext.Current.Session("getThebranchDesc1sgm")) Then

                getThebranchDesc1sgm = ""
                Using mySqlConnection As New SqlConnection(ConnectionStringSettingsFactory.getconnection().ConnectionString)
                    Try
                        '------------------------------------------------
                        Dim strSql As String = "select * from Userdetailsegmentsgm where UserName='" & HttpContext.Current.User.Identity.Name & "'"
                        Dim ds1 As New DataSet()
                        Dim da1 As New SqlDataAdapter()
                        da1.SelectCommand = New SqlCommand(strSql, mySqlConnection)
                        da1.Fill(ds1)
                        If (ds1 IsNot Nothing AndAlso ds1.Tables.Count > 0) Then

                            Dim satot As String = ""
                            If ds1.Tables(0).Rows.Count > 0 Then

                                For Each idatarow As DataRow In ds1.Tables(0).Rows
                                    If satot = "" Then
                                        'satot = controllerName & ".branch=" & idatarow.Item("branch") & ""
                                        satot = " sgm=" & idatarow.Item("sgm") & ""
                                    Else
                                        'satot = satot & " OR " & controllerName & ".branch=" & idatarow.Item("branch") & ""
                                        satot = satot & " OR " & "sgm=" & idatarow.Item("sgm") & ""
                                    End If

                                Next
                                satot = " Select sgm from glmulcmp where sgm=0 OR " & satot
                                HttpContext.Current.Session("getThebranchDesc1sgm") = satot
                                Return satot
                            End If
                            HttpContext.Current.Session("getThebranchDesc1sgm") = satot
                            Return satot
                        Else
                            HttpContext.Current.Session("getThebranchDesc1sgm") = getThebranchDesc1sgm
                            Return getThebranchDesc1sgm
                        End If
                    Catch ex As Exception
                    Finally
                        If (mySqlConnection.State = ConnectionState.Open) Then mySqlConnection.Close()
                    End Try
                End Using
            Else
                Return HttpContext.Current.Session("getThebranchDesc1sgm")
            End If
        End Function
        Public Function getThebranchDesc1(controllerName As String) As String
            If IsNothing(HttpContext.Current.Session("getThebranchDesc1")) Or String.IsNullOrEmpty(HttpContext.Current.Session("getThebranchDesc1")) Then

                getThebranchDesc1 = ""
                Using mySqlConnection As New SqlConnection(ConnectionStringSettingsFactory.getconnection().ConnectionString)
                    Try
                        '------------------------------------------------
                        Dim strSql As String = "select * from Userdetailsegment where UserName='" & HttpContext.Current.User.Identity.Name & "'"
                        Dim ds1 As New DataSet()
                        Dim da1 As New SqlDataAdapter()
                        da1.SelectCommand = New SqlCommand(strSql, mySqlConnection)
                        da1.Fill(ds1)
                        If (ds1 IsNot Nothing AndAlso ds1.Tables.Count > 0) Then

                            Dim satot As String = ""
                            If ds1.Tables(0).Rows.Count > 0 Then

                                For Each idatarow As DataRow In ds1.Tables(0).Rows
                                    If satot = "" Then
                                        'satot = controllerName & ".branch=" & idatarow.Item("branch") & ""
                                        satot = " branch=" & idatarow.Item("branch") & ""
                                    Else
                                        'satot = satot & " OR " & controllerName & ".branch=" & idatarow.Item("branch") & ""
                                        satot = satot & " OR " & "branch=" & idatarow.Item("branch") & ""
                                    End If

                                Next
                                satot = " Select branch from schbranch where branch=0 OR " & satot
                                HttpContext.Current.Session("getThebranchDesc1") = satot
                                Return satot
                            End If
                            HttpContext.Current.Session("getThebranchDesc1") = satot
                            Return satot
                        Else
                            HttpContext.Current.Session("getThebranchDesc1") = getThebranchDesc1
                            Return getThebranchDesc1
                        End If
                    Catch ex As Exception
                    Finally
                        If (mySqlConnection.State = ConnectionState.Open) Then mySqlConnection.Close()
                    End Try
                End Using
            Else
                Return HttpContext.Current.Session("getThebranchDesc1")
            End If
        End Function
        Public Function getsgm() As String

            Using mySqlConnection As New SqlConnection(ConnectionStringSettingsFactory.getconnection().ConnectionString)
                Try
                    '------------------------------------------------
                    Dim strSql As String = "select * from Quserdetailesegment where UserName='" & HttpContext.Current.User.Identity.Name & "'"
                    Dim ds1 As New DataSet()
                    Dim da1 As New SqlDataAdapter()
                    da1.SelectCommand = New SqlCommand(strSql, mySqlConnection)
                    da1.Fill(ds1)
                    If (ds1 IsNot Nothing AndAlso ds1.Tables.Count > 0) Then

                        Dim satot As String = ""
                        If ds1.Tables(0).Rows.Count > 0 Then

                            For Each idatarow As DataRow In ds1.Tables(0).Rows
                                satot = satot & idatarow.Item("branch") & ","  '"','"
                            Next
                        End If
                        If Right(satot, 1) = "," Then
                            satot = Left(satot, Len(satot) - 1)
                        End If
                        If Len(satot) = 1 Then
                            System.Web.HttpContext.Current.Session("getsgm") = Nothing
                        Else
                            System.Web.HttpContext.Current.Session("getsgm") = satot

                        End If

                    Else
                        System.Web.HttpContext.Current.Session("getsgm") = Nothing
                    End If
                Catch ex As Exception
                Finally
                    If (mySqlConnection.State = ConnectionState.Open) Then mySqlConnection.Close()
                End Try
            End Using
            Dim myIntsgm As String = HttpContext.Current.Session("getsgm")
            If String.IsNullOrEmpty(myIntsgm) Then
                Return "0"
            Else
                Return myIntsgm
            End If

        End Function
        Public Function userApplicationId() As String

            Dim newUser As MembershipUser = Membership.GetUser(UserName)
            Dim user As newmembership = newmembership.SelectSingle(newUser.ProviderUserKey)
            If (Not (user) Is Nothing) Then
                Dim userApplicationId1 As String
                userApplicationId1 = user.Email
                Return userApplicationId1
            Else
                Return "   _no_n0_name////   "
            End If
        End Function
        Public Function checkNewrole(ByVal controllerNamestr As String) As Boolean
            Try
                Using mySqlConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("LocalSqlServer").ToString)
                    Try



                        '------------------------------------------------
                        Dim strSql As String = "select insertAction  from vwaspnetpageforUsers where insertAction=0 and   UserName='" & HttpContext.Current.User.Identity.Name & "' and tablo='" & controllerNamestr & "'"
                        Dim ds1 As New DataSet()
                        Dim da1 As New SqlDataAdapter()
                        da1.SelectCommand = New SqlCommand(strSql, mySqlConnection)
                        da1.Fill(ds1)
                        If (ds1 IsNot Nothing AndAlso ds1.Tables(0).Rows.Count > 0) Then
                            Return True
                        Else
                            Return False



                        End If
                    Catch ex As Exception
                        Return False
                    Finally
                        If (mySqlConnection.State = ConnectionState.Open) Then mySqlConnection.Close()
                    End Try
                End Using

            Catch ex As Exception
                Return False
            End Try



        End Function
        Public Function checkeditrole(ByVal controllerNamestr As String) As Boolean
            Try
                Using mySqlConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("LocalSqlServer").ToString)
                    Try

                        '------------------------------------------------
                        Dim strSql As String = "select updateAction  from vwaspnetpageforUsers where updateAction=0 and   UserName='" & HttpContext.Current.User.Identity.Name & "' and tablo='" & controllerNamestr & "'"
                        Dim ds1 As New DataSet()
                        Dim da1 As New SqlDataAdapter()
                        da1.SelectCommand = New SqlCommand(strSql, mySqlConnection)
                        da1.Fill(ds1)
                        If (ds1 IsNot Nothing AndAlso ds1.Tables(0).Rows.Count > 0) Then
                            Return True





                        Else
                            Return False


                        End If
                    Catch ex As Exception
                        Return False
                    Finally
                        If (mySqlConnection.State = ConnectionState.Open) Then mySqlConnection.Close()
                    End Try
                End Using




            Catch ex As Exception
                Return False
            End Try
        End Function
        Public Function checkdeleterole(ByVal controllerNamestr As String) As Boolean
            Try
                Using mySqlConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("LocalSqlServer").ToString)
                    Try
                        '------------------------------------------------
                        Dim strSql As String = "select deleteAction  from vwaspnetpageforUsers where deleteAction=0 and   UserName='" & HttpContext.Current.User.Identity.Name & "' and tablo='" & controllerNamestr & "'"
                        Dim ds1 As New DataSet()
                        Dim da1 As New SqlDataAdapter()
                        da1.SelectCommand = New SqlCommand(strSql, mySqlConnection)
                        da1.Fill(ds1)
                        If (ds1 IsNot Nothing AndAlso ds1.Tables(0).Rows.Count > 0) Then
                            Return True
                        Else
                            Return False


                        End If
                    Catch ex As Exception
                        Return False
                    Finally
                        If (mySqlConnection.State = ConnectionState.Open) Then mySqlConnection.Close()
                    End Try
                End Using




            Catch ex As Exception
                Return False
            End Try
        End Function
        Public Overrides Function SupportsVirtualization(ByVal controllerName As String) As Boolean
            Return True    'Not UserIsInRole("Administrators")
        End Function
        Protected Overrides Sub VirtualizeController(ByVal controllerName As String)
            NodeSet().SelectActions("ReportAsWord", "ReportAsPdf", "ReportAsImage", "ExportRss", "DataSheet", "Grid").Delete()
            
			If UserIsInRole("ReportAsExcel") Then
            Else
                NodeSet().SelectActions("ReportAsExcel").Delete()
				NodeSet().SelectActions("ExportCsv").Delete()
            End If
			If UserIsInRole("ExportRowset") Then
            Else
                NodeSet().SelectActions("ExportRowset").Delete()
            End If
            If UserIsInRole("Import") Then
            Else
                NodeSet().SelectActions("Import").Delete()
            End If
            If UserIsInRole("Administrator") Then

            Else
                NodeSet().SelectActions("ReportAsWord", "ReportAsPdf", "ReportAsImage").Delete()
                'If UserIsInRole("exportexcel") Then
                '    NodeSet().SelectActions("ReportAsWord", "ReportAsPdf", "ReportAsImage").Delete()
                'End If
                '''
                '-----------------------------
                If UserIsInRole("ReadOnley") Or (IsTagged("masterlist")) Then
                    'Dim restrictedCommands() As String =
                    '    {"Edit", "New", "Delete", "Duplicate", "Import"}
                    'Dim actionIterator As XPathNodeIterator = navigator.Select("//c:action", resolver)
                    'While (actionIterator.MoveNext())
                    '    Dim commandName As String = actionIterator.Current.GetAttribute(
                    '        "commandName", String.Empty)
                    '    If (restrictedCommands.Contains(commandName)) Then
                    '        actionIterator.Current.CreateAttribute(
                    '            String.Empty, "roles", String.Empty, "Administrators")
                    '    End If
                    'End While
                    Select Case controllerName
                        Case "AccnoDates", "_Dates", "_Dates1", "_Dates2", "_Dates3", "_Dates4", "AccnoDates1", "AccnoDates2", "AccnoDates3", "accinstallment1001"



                        Case Else
                            NodeSet().SelectActions("New", "Update", "Delete", "Insert", "Duplicate", "Import", "ExportCsv", "ExportRowset", "ExportRss", "DataSheet", "Grid", "ReportAsExcel") _
                                            .Delete()
                            NodeSet().SelectActionGroups("Grid") _
                                    .SelectActions("New", "Update", "Delete", "Edit", "Insert", "Duplicate", "Import", "ExportCsv", "ExportRowset", "ExportRss", "DataSheet", "Grid", "ReportAsExcel") _
                                    .Delete()

                    End Select
                Else
                    'Select Case controllerName



                    '    Case "GLmstrfl", "accountclasslist", "GLmfband", "GLmfbab"


                    '        '       If (IsTagged("runningcontract")) Then
                    '        '        End If
                    '        NodeSet().SelectActions("New", "Edit", "Delete", "Duplicate", "Import") _
                    '                    .Delete()
                    '        ' delete all remaining actions in the 'Grid' scope 
                    '        NodeSet().SelectActionGroups("Grid") _
                    '            .SelectActions() _
                    '            .Delete()
                    '        '            ' add new 'Navigate' action to the 'Grid' scope 
                    '        '            NodeSet().SelectActionGroups("Grid") _
                    '        '                .CreateAction(
                    '        '                    "Navigate",
                    '        '                    "ajrcontractrun.aspx?ajrCntrctSr={ajrCntrctSr}&_controller=ajrContracts" +
                    '        '                    "&_commandName=Edit&_commandArgument=editcontract")




                    'End Select

                End If
            End If
            'Dim myrolbool As Boolean = False
            'myrolbool = iseditinginmyrol(controllerName)
            'myrolbool = False
            'If (myrolbool) Then
            '    NodeSet().SelectActions("New", "Edit", "Delete", "Duplicate", "Import").Delete()
            'End If



            Dim kf As String = String.Empty
            Dim iterator As Object = NodeSet().Select("/c:dataController/c:fields").Select("c:field[@isPrimaryKey='true']/@name")
            If (Not (iterator) Is Nothing) Then
                kf = iterator.ToString
            End If
            'workflow----- idfilter=" + Controller. +"&
            If IsNothing(iterator) Then
                If NodeSet().SelectActionGroup("ag2").IsEmpty Then
                Else
                    NodeSet().SelectActionGroups("Grid").CreateAction("Navigate", "webreportviwer.aspx?reportquery=" + controllerName)
				End if
			
			Else
                If NodeSet().SelectActionGroup("ag2").IsEmpty Then
                Else
                    NodeSet().SelectActionGroups("Grid").CreateAction("Navigate", "_blank:webreportviwer.aspx?idfilter={" + iterator.ToString + "}&reportquery=" + controllerName)
				End if
		   End If
            '"webreportviwerDyn.aspx?reportquery=" + controllerName + "", "mrt100001")
            Select Case controllerName
                Case "schvchdlydetailreg1001", "schvchdlydetailpayment1001"
                Case Else
                    Dim dtDataTable As DataTable
                    dtDataTable = GetData("select * from mrtcontrollerName where controllerName<>ReportCode and   controllerName='" & controllerName & "' order by controllerNameid")
                    If dtDataTable.Rows.Count > 0 Then
                        Dim row As DataRow
                        Dim strDetail As String = ""
                        Dim strDetailid As Double = 0
                        'NodeSet().Select("/c:dataController/c:actions").CreateActionGroup("ag7pdfmos1")

                        'NodeSet().SelectActionGroup("ag7pdfmos1").Attr("headerText", translatemeyamosso.GetResourceValuemosso("PdfReports1"))
                        'NodeSet().Select("/c:dataController/c:actions").CreateActionGroup("ag7xlxmos1")

                        'NodeSet().SelectActionGroup("ag7xlxmos1").Attr("headerText", translatemeyamosso.GetResourceValuemosso("xlxReports1"))

                        For Each row In dtDataTable.Rows
                            strDetailid = Convert.ToDouble(row("controllerNameid"))
                            strDetailid = 10000 + strDetailid
                            If NodeSet().SelectActionGroup("ag7").IsEmpty Then
                            Else
                                NodeSet().SelectActionGroup("ag7").CreateAction("Report", "_blank", row("ReportCode"))
                                NodeSet().SelectActionGroup("ag7").SelectAction(row("ReportCode")).Attr("headerText", translatemeyamosso.GetResourceValuemosso(row("ReportCode")))
                            End If

                            If NodeSet().SelectActionGroup("ag7pdfmos").IsEmpty Then
                            Else

                                NodeSet().SelectActionGroup("ag7pdfmos").CreateAction("Report", "mospdf", row("ReportCode"))
                                NodeSet().SelectActionGroup("ag7pdfmos").SelectAction(row("ReportCode")).Attr("headerText", translatemeyamosso.GetResourceValuemosso(row("ReportCode")))
                            End If
                            If NodeSet().SelectActionGroup("ag7xlxmos").IsEmpty Then
                            Else
                                NodeSet().SelectActionGroup("ag7xlxmos").CreateAction("Report", "mosxlx", row("ReportCode"))
                                NodeSet().SelectActionGroup("ag7xlxmos").SelectAction(row("ReportCode")).Attr("headerText", translatemeyamosso.GetResourceValuemosso(row("ReportCode")))
                            End If

                        Next row
                        If UserIsInRole("ReportDesigner") Then
                            Dim newnumberreport As String
                            newnumberreport = strDetailid + 1
                            newnumberreport = 10000 + newnumberreport
                            If NodeSet().SelectActionGroup("ag7").IsEmpty Then
                            Else
                                NodeSet().SelectActionGroup("ag7").CreateAction("Report", "_blank", "mrt" & controllerName & newnumberreport)
                                NodeSet().SelectActionGroup("ag7").SelectAction("mrt" & controllerName & newnumberreport).Attr("headerText", translatemeyamosso.GetResourceValuemosso("NewReport"))
                            End If
                        End If
                    Else
                        If UserIsInRole("ReportDesigner") Then
						If NodeSet().SelectActionGroup("ag7").IsEmpty Then
                            Else
                            NodeSet().SelectActionGroup("ag7").CreateAction("Report", "_blank", "mrt" & controllerName & "100001")
                            NodeSet().SelectActionGroup("ag7").SelectAction("mrt" & controllerName & "100001").Attr("headerText", translatemeyamosso.GetResourceValuemosso("NewReport"))
							End if
						End If
                    End If
                    If UserIsInRole("ReportDesigner") Then
						If NodeSet().SelectActionGroup("ag7").IsEmpty Then
                        Else
							NodeSet().SelectActionGroup("ag7").CreateAction("Report", "DaynamicMrtReport", "Daynamic100001")
						End if
                    End If
            End Select
        End Sub
        Public Function iseditinginmyrol(ByVal controllerNamestr As String) As Boolean
            Try
                If (HttpContext.Current.Session("rolesList") IsNot Nothing) Then
                    Dim dt As New DataTable
                    dt = CType(HttpContext.Current.Session("rolesList"), DataTable)
                    Dim filterExp As String = "Rolesname = '" & controllerNamestr & "'"
                    Dim sortExp As String = "Rolesname"
                    Dim drarray() As DataRow
                    'Dim i As Integer
                    drarray = dt.Select(filterExp, sortExp, DataViewRowState.CurrentRows)
                    If drarray.Length > 0 Then

                        Return False

                    Else
                        Return True
                    End If
                Else
                    Return False

                End If
            Catch ex As Exception
                Return True
            End Try



        End Function
        Protected Overridable Function UserIsInRole1(ByVal ParamArray rules() As System.String) As Boolean
            Return DataControllerBase.UserIsInRole(rules)
        End Function
        Function authorizedme(ByVal varclass As String) As String
            'Try

            If (HttpContext.Current.Session("rolesList") Is Nothing) Then
                Using mySqlConnection As New SqlConnection(ConfigurationManager.ConnectionStrings("LocalSqlServer").ToString)
                    'Try

                    '------------------------------------------------
                    Dim strSql As String = "select pagesname as Rolesname from vwaspnetpageforUsers where  UserName='" & HttpContext.Current.User.Identity.Name & "'"
                    Dim ds1 As New DataSet()
                    Dim da1 As New SqlDataAdapter()
                    da1.SelectCommand = New SqlCommand(strSql, mySqlConnection)
                    da1.Fill(ds1)
                    If (ds1 IsNot Nothing AndAlso ds1.Tables.Count > 0) Then
                        System.Web.HttpContext.Current.Session("rolesList") = ds1.Tables(0)
                    Else
                        System.Web.HttpContext.Current.Session("rolesList") = Nothing

                    End If
                    ' Catch ex As Exception
                    ' Finally
                    'If (mySqlConnection.State = ConnectionState.Open) Then mySqlConnection.Close()
                    ' End Try
                End Using

            End If
            If (HttpContext.Current.Session("rolesList") IsNot Nothing) Then
                Dim dt As New DataTable
                dt = CType(HttpContext.Current.Session("rolesList"), DataTable)
                Dim filterExp As String = "Rolesname = '" & varclass & "'"
                Dim sortExp As String = "Rolesname"
                Dim drarray() As DataRow
                Dim i As Integer
                drarray = dt.Select(filterExp, sortExp, DataViewRowState.CurrentRows)
                If drarray.Length > 0 Then
                    For i = 0 To (drarray.Length - 1)
                        Return drarray(i)("Rolesname").ToString
                    Next
                Else
                    Return " "
                End If
            Else
                Return varclass


            End If

            'Catch ex As Exception
            ' End Try


            Return varclass
        End Function


    End Class

    Public Class CustomXmlWriter
        Inherits XmlTextWriter
        Public Sub New(writer As TextWriter)
            MyBase.New(writer)
        End Sub
        Public Sub New(stream As Stream, encoding As Encoding)
            MyBase.New(stream, encoding)
        End Sub
        Public Sub New(file As String, encoding As Encoding)
            MyBase.New(file, encoding)
        End Sub
        Public Overrides Sub WriteString(text As String)
            Dim utfencoder As Encoding = UTF8Encoding.GetEncoding("UTF-8", New EncoderReplacementFallback(""), New DecoderReplacementFallback(""))
            Dim bytText As Byte() = utfencoder.GetBytes(text)
            Dim strEncodedText As String = utfencoder.GetString(bytText)
            MyBase.WriteString(strEncodedText)
        End Sub

    End Class
End Namespace

Namespace eZee.Services

    Partial Public Class ApplicationServices
        Inherits EnterpriseApplicationServices
        ' Creates standard membership accounts and assigns all existing roles to them.
        ' This method is safe to call multiple times (idempotent user creation and role assignment).
        Public Sub CreateStandardMembershipAccounts_Custom()
            Try
                ' Run pre-fix if available
                Using calc1 As New SqlText("exec dbo.fixuserlist")
                    calc1.ExecuteNonQuery()
                End Using

                ' Ensure users exist and assign all roles
                EnsureUserAndAllRoles("skyai365", "skyai365@365", "skyai365@wytsky.com")
                EnsureUserAndAllRoles("wytskyai2025", "wytskyai2025@365", "wytskyai2025@wytsky.com")
                EnsureUserAndAllRoles("2025user5", "2025user5@365", "2025user5@wytsky.com")
                EnsureUserAndAllRoles("2025user4", "2025user4@365", "2025user4@wytsky.com")
                EnsureUserAndAllRoles("2025user3", "2025user3@365", "2025user3@wytsky.com")
                EnsureUserAndAllRoles("2025user2", "2025user2@365", "2025user2@wytsky.com")
                EnsureUserAndAllRoles("2025user1", "2025user1@365", "2025user1@wytsky.com")

                ' Run post-fix if available
                Using calc2 As New SqlText("exec dbo.fixuserlistroles")
                    calc2.ExecuteNonQuery()
                End Using
            Catch
                ' Optionally log
            End Try
        End Sub

        Private Sub EnsureUserAndAllRoles(ByVal username As String, ByVal password As String, ByVal email As String)
            Dim u As MembershipUser = Membership.GetUser(username)
            If (u Is Nothing) Then
                Dim status As MembershipCreateStatus
                Dim _unused As MembershipUser = Membership.CreateUser(username, password, email, "aaa", "a", True, status)
            End If
            AssignAllRolesToUser(username)
        End Sub

        Private Sub AssignAllRolesToUser(ByVal username As String)
            Dim sql As String = "insert into AspNetUserRoles(UserId,RoleId) " &
                                "select u.id, r.id " &
                                "from AspNetUsers u " &
                                "cross join AspNetRoles r " &
                                "where u.UserName=@u " &
                                "and not exists (select 1 from AspNetUserRoles ur where ur.UserId=u.id and ur.RoleId=r.id)"
            Using cmd As New SqlText(sql)
                cmd.AddParameter("@u", username)
                cmd.ExecuteNonQuery()
            End Using
        End Sub



        Public Overrides Sub CreateStandardMembershipAccounts()
            'Create a separate code file with a definition of the partial class ApplicationServices overriding
            'this method to prevent automatic registration of 'admin' and 'user'. Do not change this file directly.
            'RegisterStandardMembershipAccounts()

            Dim admin As MembershipUser = Membership.GetUser("admin")
            If ((Not (admin) Is Nothing) AndAlso admin.IsLockedOut) Then
                admin.UnlockUser()
            End If

            Dim zaker As MembershipUser = Membership.GetUser("zaker")
            If ((Not (zaker) Is Nothing) AndAlso zaker.IsLockedOut) Then
                zaker.UnlockUser()
            End If
            Dim zaker1 As MembershipUser = Membership.GetUser("wytsky2019")
            If ((Not (zaker1) Is Nothing) AndAlso zaker1.IsLockedOut) Then
                zaker1.UnlockUser()
            End If
            Dim zakerxc As MembershipUser = Membership.GetUser("wytsky2020")
            If ((Not (zakerxc) Is Nothing) AndAlso zakerxc.IsLockedOut) Then
                zakerxc.UnlockUser()
            End If
            Dim sky365xc As MembershipUser = Membership.GetUser("sky365")
            If ((Not (sky365xc) Is Nothing) AndAlso sky365xc.IsLockedOut) Then
                sky365xc.UnlockUser()
            End If
            ' Delete existing seed users only if explicitly enabled via appSettings: Setup.ResetMembership=true
            Dim resetFlag As Boolean = False
            Dim flagValue As String = ConfigurationManager.AppSettings("Setup.ResetMembership")
            If Not String.IsNullOrEmpty(flagValue) Then
                Boolean.TryParse(flagValue, resetFlag)
            End If
            If resetFlag Then
                If (Membership.GetUser("admin") IsNot Nothing) Then
                    Membership.DeleteUser("admin")
                End If
                If (Membership.GetUser("user") IsNot Nothing) Then
                    Membership.DeleteUser("user")
                End If
                If (Membership.GetUser("zaker") IsNot Nothing) Then
                    Membership.DeleteUser("zaker")
                End If
                If (Membership.GetUser("wytsky2019") IsNot Nothing) Then
                    Membership.DeleteUser("wytsky2019")
                End If
                If (Membership.GetUser("wytsky2020") IsNot Nothing) Then
                    Membership.DeleteUser("wytsky2020")
                End If
                If (Membership.GetUser("sky365") IsNot Nothing) Then
                    Membership.DeleteUser("sky365")
                End If
            End If

            If System.Web.Security.Roles.RoleExists("Administrators") Then
            Else
                System.Web.Security.Roles.CreateRole("Administrators")
            End If
            If System.Web.Security.Roles.RoleExists("Administrator") Then
            Else
                System.Web.Security.Roles.CreateRole("Administrator")
            End If
            If System.Web.Security.Roles.RoleExists("Membership") Then
            Else
                System.Web.Security.Roles.CreateRole("Membership")
            End If
            If System.Web.Security.Roles.RoleExists("itadmin") Then
            Else
                System.Web.Security.Roles.CreateRole("itadmin")
            End If
            If System.Web.Security.Roles.RoleExists("wytsky2019") Then
            Else
                System.Web.Security.Roles.CreateRole("wytsky2019")
            End If
            If (Membership.GetUser("skyai") Is Nothing) Then
                Dim status As MembershipCreateStatus
                zaker = Membership.CreateUser("skyai", "skyai@365", "info@skyai.com", "aaa", "a", True, status)
                System.Web.Security.Roles.AddUserToRole(zaker.UserName, "Administrators")
                System.Web.Security.Roles.AddUserToRole(zaker.UserName, "Administrator")
                System.Web.Security.Roles.AddUserToRole(zaker.UserName, "Membership")
                System.Web.Security.Roles.AddUserToRole(zaker.UserName, "itadmin")
            End If
            CreateStandardMembershipAccounts_Custom()
        End Sub
    End Class
End Namespace
Namespace eZee.Web

    Partial Public Class PageBase
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            If Not (IsPostBack) Then
                Dim rolesstringtitle As String
                rolesstringtitle = Right(Me.Page.AppRelativeVirtualPath, Len(Me.Page.AppRelativeVirtualPath) - Len(Me.Page.AppRelativeTemplateSourceDirectory))
                rolesstringtitle = Left(rolesstringtitle, Len(rolesstringtitle) - 5)
                Me.Page.Title = translatemeyamosso.GetResourceValuemosso(rolesstringtitle)

                Dim d As System.DateTime
                d = DateTime.Now
                Dim filepathlic As String
                filepathlic = HttpContext.Current.Server.MapPath("~/help/Tblmodellistapp.aspx")
                If My.Computer.FileSystem.FileExists(filepathlic) Then
                Else
                    Dim file As System.IO.StreamWriter
                    file = My.Computer.FileSystem.OpenTextFileWriter(filepathlic, True)
                    file.WriteLine("Ü*     ")
                    file.Close()
                End If
                Dim filepathlic1 As String
                filepathlic1 = HttpContext.Current.Server.MapPath("~/help/Stimulsoft.compare.dll")
                If My.Computer.FileSystem.FileExists(filepathlic1) Then
                Else
                    Dim file As System.IO.StreamWriter
                    file = My.Computer.FileSystem.OpenTextFileWriter(filepathlic1, True)
                    file.WriteLine("Ü*     ")
                    file.Close()
                End If
                Dim fileReader As String
                fileReader = My.Computer.FileSystem.ReadAllText(filepathlic)
                Dim fileReader1 As String
                fileReader1 = My.Computer.FileSystem.ReadAllText(filepathlic1)
                If fileReader = fileReader1 Then
                Else
                    Context.Response.Redirect("~/help/Expires.aspx")
                End If
				Dim hostName As String = HttpContext.Current.Request.Url.Host
                If System.Text.RegularExpressions.Regex.IsMatch(hostName, "^[a-z0-9]+\.(saskw\.net|wytsky\.com|wytsky\.net|whitesky\.tech|skyaierp\.com)$") Then
				Else
                    If DateValue(d.ToString) > DateValue("2025-12-12") Then
                        Dim filepathlic2 As String
                        filepathlic2 = HttpContext.Current.Server.MapPath("~/help/Stimulsoft.compare.dll")
                        Dim file As System.IO.StreamWriter
                        file = My.Computer.FileSystem.OpenTextFileWriter(filepathlic2, True)
                        file.WriteLine("Ü*     0")
                        file.Close()
                        Dim filepathlic3 As String
                        filepathlic3 = HttpContext.Current.Server.MapPath("~/help/Member.aspx")
                        Dim file1 As System.IO.StreamWriter
                        file1 = My.Computer.FileSystem.OpenTextFileWriter(filepathlic3, True)
                        file1.Write("Ü*     0")
                        file1.Close()
                        Context.Response.Redirect("~/help/Expires.aspx")
                    End If
                End If
                If IsNothing(Context.User.Identity.Name) Or String.IsNullOrEmpty(Context.User.Identity.Name) Then
                Else

                    'workstation id from connection 
                    ' DirectCast(connection, System.Data.SqlClient.SqlConnection).WorkstationId()

                    Dim rolesstring1 As String
                    'Dim rolesstringtitle As String
                    rolesstring1 = Right(Me.Page.AppRelativeVirtualPath, Len(Me.Page.AppRelativeVirtualPath) - Len(Me.Page.AppRelativeTemplateSourceDirectory))
                    'rolesstringtitle = Left(rolesstring1, Len(rolesstring1) - 5) 

                    Select Case rolesstring1
                        Case "user_details.aspx", "MYprofile_1.aspx", "MYprofile.aspx"

                        Case Else
                            Dim sqlstatmentcheck As String
                            sqlstatmentcheck = "select count(*) as tecko from [user_details]  where  UserName='" & Context.User.Identity.Name & "'"
                            Dim tekost As Object
                            tekost = DataLogic.GetValue(sqlstatmentcheck)
                            If IsNothing(tekost) = True Then
                                Response.Redirect("~/Pages/MYprofile_1.aspx")
                            Else
                                If tekost = 0 Then
                                    Response.Redirect("~/Pages/MYprofile_1.aspx")
                                End If
                            End If
                    End Select
                End If                '' MsgBox("wow", MsgBoxStyle.Exclamation, "teto")
                'rolesList
                Dim rolesstring As String
                rolesstring = Right(Me.Page.AppRelativeVirtualPath, Len(Me.Page.AppRelativeVirtualPath) - Len(Me.Page.AppRelativeTemplateSourceDirectory))
                ' rolesstring = Left(rolesstring, Len(rolesstring) - 5) 
                Select Case rolesstring
                    Case "myinfo.aspx", "Login.aspx", "Users.aspx", "UsersTypes.aspx", "UsersTypes_roles.aspx", "usertypRolsjoin.aspx", "userRights.aspx"
                    Case "Home.aspx", "UserRolesGroup.aspx", "UserRolesGroupjoin.aspx", "userRolesnew.aspx", "Users_Home.aspx"
                    Case "SignIn.aspx"
                    Case "SignOut.aspx", "SendUserInfo.aspx", "LargeListSelector.aspx", "changeUsersPage.aspx", "SetLanguagePage.aspx", "AddTransaltsystemPage.aspx", "TransaltsystemWebReport.aspx", "SelectEditTransaltsystemPage.aspx"
                    Case "ConfigureAddRecord.aspx", "ConfigureEditRecord.aspx", "ConfigureSpecialEditRecord.aspx", "ConfigureSpecialViewRecord.aspx", "ShowTransaltsystemTablePage.aspx", "ShowTransaltsystemPage.aspx", "EditTransaltsystemTablePage.aspx"
                    Case "ConfigureViewRecord.aspx", "ExportFieldValue.aspx", "Forbidden.aspx", "SelectFileToImport.aspx", "Show_Error.aspx", "EditTransaltsystemPage.aspx", "SearchEditTransaltsystemPage.aspx", "ForgotUser.aspx"
                    Case Else
                        'rolesstring = "New" & rolesstring.ToString()
                        'If (authorizedme(UCase(rolesstring).ToString()) = UCase(rolesstring).ToString) Then

                        'Else
                        '    Response.Red   irect("../Security.aspx")
                        'End If
                End Select
				
                Dim stmap As Control = FindControlRecursive(Me.Page, "SiteMapDataSource1")
                Dim txtCtl As Control = FindControlRecursive(Me.Page, "TreeView1")

                If IsNothing(txtCtl) Then
                Else
                    Dim ca As System.Web.UI.WebControls.TreeView = TryCast(txtCtl, System.Web.UI.WebControls.TreeView)
                    If IsNothing(ca) Then
                    Else
                        ca.Visible = False

                        ''oldtreeview will disable and hiden
                        ''ca.DataBind()
                        ''ConfigureNodeTargets(ca.Nodes)
                        ''/// use telrik  module  this example for from file
                        'Dim teleric As RadSiteMapDataSource
                        'teleric = New RadSiteMapDataSource
                        'teleric.ShowStartingNode = "false"
                        'teleric.StartFromCurrentNode = "true"
                        ''teleric.SiteMapFile = translatemeyamosso.GetVirtualPath(Server.MapPath("../Web.Sitemap"))
                        ' ''// Create an instance of the XmlSiteMapProvider class.
                        ''Dim testXmlProvider As XmlSiteMapProvider = New XmlSiteMapProvider()
                        ''Dim providerAttributes As NameValueCollection = New NameValueCollection(1)
                        ''providerAttributes.Add("siteMapFile", translatemeyamosso.GetVirtualPath(Server.MapPath("../Web.Sitemap")))
                        ' ''// Initialize the provider with a provider name and file name.
                        ''testXmlProvider.Initialize("testProvider", providerAttributes)
                        ' ''// Call the BuildSiteMap to load the site map information into memory.
                        ''testXmlProvider.BuildSiteMap()
                        ''-------------------------------end of example but we dont use it for security cannot control if read from sitmape
                        'Dim smd As SiteMapDataSource = New SiteMapDataSource()
                        'smd.Provider = SiteMap.Providers("XmlSiteMapProvider")     'testXmlProvider  this is the secrte
                        'smd.ShowStartingNode = "true"
                        'smd.StartFromCurrentNode = "true"
                        'Dim tv2 As TreeView = New TreeView()
                        ''-----------------------startmostafa2014-11-12
                        ' Dim telrikrad As RadSiteMap = New RadSiteMap
                        'telrikrad.DataSourceID = "XmlSiteMapProvider"
                        ' telrikrad.ShowNodeLines = "true"
                        ' telrikrad.Width = 450
                        'Dim telriksitemaplevelsetting As SiteMapLevelSetting = New SiteMapLevelSetting
                        'telriksitemaplevelsetting.Layout = SiteMapLayout.List
                        'telriksitemaplevelsetting.Level = "0"
                        'telriksitemaplevelsetting.ListLayout.RepeatColumns = 3
                        'telriksitemaplevelsetting.ListLayout.RepeatDirection = SiteMapRepeatDirection.Vertical
                        'telrikrad.LevelSettings.Add(telriksitemaplevelsetting)
                        ''----------------endmostafa2014-11-12
                        'tv2.DataSource = smd
                        'tv2.DataBind() '//Important or all is blank
                        'tv2.CssClass = "TreeView"
                        'tv2.ImageSet = TreeViewImageSet.Simple2
                        'Dim stmap1 As ContentPlaceHolder = FindControlRecursive(Me.Page, "PageContentPlaceHolder")
                        'If IsNothing(stmap1) Then
                        'Else

                        '    ConfigureNodeTargets(tv2.Nodes)

                        '    stmap1.Controls.Add(tv2)
                        '    stmap1.Controls.Add(telrikrad)
                        '    telrikrad.Visible = True
                        '    tv2.Visible = True
                        'End If

                        ' استخدام النسخة الحديثة من TableOfContentsajar بدلاً من Telerik
                        Dim DynamicUserControl As UserControl = LoadControl("~/Controls/HomeTableOfContents.ascx")
                        Dim stmap1 As ContentPlaceHolder = FindControlRecursive(Me.Page, "PageContentPlaceHolder")
                        If IsNothing(stmap1) Then
                        Else
                            'telrikrad.Visible = False
                            ' ConfigureNodeTargets1(telrikrad.Nodes)
                            DynamicUserControl.Visible = False
                            stmap1.Controls.Add(DynamicUserControl)
                            ' stmap1.Controls.Add(telrikrad)
                            DynamicUserControl.Visible = True
                            'telrikrad.Visible = True
                        End If

                    End If
                End If
                '---------------------------------------------------------



                '            '---------------------------------------------------------------
                '            'For Each c As Control In Me.Page.Controls

                '            '    Dim xcv As String = c.GetType.ToString()
                '            '    MsgBox(xcv)

                'Next
            End If
        End Sub
        Function FindControlRecursive(ByVal ctrl As Control, _
            ByVal id As String) As Control
            ' Exit if this is the control we're looking for.
            If ctrl.ID = id Then Return ctrl

            ' Else, look in the hiearchy.
            Dim childCtrl As Control


            For Each childCtrl In ctrl.Controls
                Dim resCtrl As Control = FindControlRecursive(childCtrl, id)
                ' Exit if we've found the result
                If Not resCtrl Is Nothing Then Return resCtrl
            Next
        End Function
        Private Sub ConfigureNodeTargets(ByVal nodes As TreeNodeCollection)
            For Each n As TreeNode In nodes
                Dim m As Match = Regex.Match(n.NavigateUrl, "^(_\w+):(.+)$")
                If m.Success Then
                    n.Target = m.Groups(1).Value
                    n.NavigateUrl = m.Groups(2).Value
                End If
                n.Text = GetResourceValuemosso(n.Text)

                ConfigureNodeTargets(n.ChildNodes)
            Next
        End Sub
        Function authorizedme(ByVal varclass As String) As String
            Try
                If (HttpContext.Current.Session("rolesList") IsNot Nothing) Then
                    Dim dt As New DataTable
                    dt = CType(HttpContext.Current.Session("rolesList"), DataTable)
                    Dim filterExp As String = "Rolesname = '" & varclass & "'"
                    Dim sortExp As String = "Rolesname"
                    Dim drarray() As DataRow
                    Dim i As Integer
                    drarray = dt.Select(filterExp, sortExp, DataViewRowState.CurrentRows)
                    If drarray.Length > 0 Then
                        For i = 0 To (drarray.Length - 1)
                            Return drarray(i)("Rolesname").ToString
                        Next
                    Else
                        Return " "
                    End If
                Else
                    Return varclass

                End If
            Catch ex As Exception
            End Try

            Return varclass
        End Function
    End Class
End Namespace

Namespace eZee.Data

    Partial Public Class ConnectionStringSettingsFactory
        Protected Overrides Function CreateSettings(connectionStringName As String) As ConnectionStringSettings

            Dim settings As ConnectionStringSettings = MyBase.CreateSettings(connectionStringName)
            Dim settings1 As ConnectionStringSettings = CreateSettings1("LocalSqlServer")

            If (HttpContext.Current.User) IsNot Nothing Then

                If HttpContext.Current.User.Identity.IsAuthenticated Then
                    Dim csb As New SqlConnectionStringBuilder(settings.ConnectionString)
                    Dim urlstring As String
                    If IsNothing(ConfigurationManager.AppSettings("saskw")) = False Then


                        If IsNothing(ConfigurationManager.AppSettings("ChartImageHandlerphras")) Then
                            urlstring = "saskw"
                        Else
                            urlstring = Right(ConfigurationManager.AppSettings("ChartImageHandlerphras").ToString(), Len(ConfigurationManager.AppSettings("ChartImageHandlerphras").ToString()) - 5)
                        End If

                        Dim urlstring1 As String
                        If IsNothing(ConfigurationManager.AppSettings("ChartImageHandlerphras1")) Then
                            urlstring1 = "mos@2017"
                        Else
                            urlstring1 = Right(ConfigurationManager.AppSettings("ChartImageHandlerphras1").ToString(), Len(ConfigurationManager.AppSettings("ChartImageHandlerphras1").ToString()) - 5)
                        End If
                        csb.UserID = urlstring
                        csb.Password = urlstring1
                        settings = New ConnectionStringSettings(Nothing, "Data Source=" + csb.DataSource + ";Initial Catalog=" + csb.InitialCatalog + ";Persist Security Info=True;User ID=" + csb.UserID + ";Password=" + csb.Password + ";", settings.ProviderName)
                    End If
                End If
                End If
            Return settings
        End Function
        Public Shared Function CreateSettings1(ByVal connectionStringName As String) As ConnectionStringSettings
            If String.IsNullOrEmpty(connectionStringName) Then
                connectionStringName = "eZee"
            End If
            Dim settings As ConnectionStringSettings = WebConfigurationManager.ConnectionStrings(connectionStringName)
            If (HttpContext.Current.User) IsNot Nothing Then

                If HttpContext.Current.User.Identity.IsAuthenticated Then
                    Dim csb As New SqlConnectionStringBuilder(settings.ConnectionString)
                    Dim urlstring As String
                    If IsNothing(ConfigurationManager.AppSettings("saskw")) = False Then

                        If IsNothing(ConfigurationManager.AppSettings("ChartImageHandlerphras")) Then
                            urlstring = "saskw"
                        Else
                            urlstring = Right(ConfigurationManager.AppSettings("ChartImageHandlerphras").ToString(), Len(ConfigurationManager.AppSettings("ChartImageHandlerphras").ToString()) - 5)
                        End If

                        Dim urlstring1 As String
                        If IsNothing(ConfigurationManager.AppSettings("ChartImageHandlerphras1")) Then
                            urlstring1 = "mos@2017"
                        Else
                            urlstring1 = Right(ConfigurationManager.AppSettings("ChartImageHandlerphras1").ToString(), Len(ConfigurationManager.AppSettings("ChartImageHandlerphras1").ToString()) - 5)
                        End If
                        csb.UserID = urlstring
                        csb.Password = urlstring1
                        settings = New ConnectionStringSettings(Nothing, "Data Source=" + csb.DataSource + ";Initial Catalog=" + csb.InitialCatalog + ";Persist Security Info=True;User ID=" + csb.UserID + ";Password=" + csb.Password + ";", settings.ProviderName)

                    End If
                End If
            End If
            Return settings
        End Function
        Public Shared Function getconnection() As ConnectionStringSettings
            Dim settings As ConnectionStringSettings = CreateSettings1("eZee")
            Dim settings1 As ConnectionStringSettings = CreateSettings1("LocalSqlServer")
            If (HttpContext.Current.User) IsNot Nothing Then
                If HttpContext.Current.User.Identity.IsAuthenticated Then
                    Dim csb As New SqlConnectionStringBuilder(settings.ConnectionString)
                    Dim urlstring As String
                    If IsNothing(ConfigurationManager.AppSettings("saskw")) = False Then

                        If IsNothing(ConfigurationManager.AppSettings("ChartImageHandlerphras")) Then
                            urlstring = "saskw"
                        Else
                            urlstring = Right(ConfigurationManager.AppSettings("ChartImageHandlerphras").ToString(), Len(ConfigurationManager.AppSettings("ChartImageHandlerphras").ToString()) - 5)
                        End If

                        Dim urlstring1 As String
                        If IsNothing(ConfigurationManager.AppSettings("ChartImageHandlerphras1")) Then
                            urlstring1 = "mos@2017"
                        Else
                            urlstring1 = Right(ConfigurationManager.AppSettings("ChartImageHandlerphras1").ToString(), Len(ConfigurationManager.AppSettings("ChartImageHandlerphras1").ToString()) - 5)
                        End If
                        csb.UserID = urlstring
                        csb.Password = urlstring1
                        settings = New ConnectionStringSettings(Nothing, "Data Source=" + csb.DataSource + ";Initial Catalog=" + csb.InitialCatalog + ";Persist Security Info=True;User ID=" + csb.UserID + ";Password=" + csb.Password + ";", settings.ProviderName)

                    End If
                End If
            End If
            Return settings
        End Function

    End Class

    Partial Public Class Controller
        Protected Overrides Function CreateCommand(connection As DbConnection) As DbCommand
            Dim command As DbCommand = MyBase.CreateCommand(connection)
            If IsNothing(command) Then
            Else
                command.CommandTimeout = 60 * 60
            End If


            Return command
        End Function
        '----------------------------------------------------------------------------
        Public Overrides Function GetDataControllerStream(controller As String) As Stream
            Dim fileName = String.Format("c:\\clients\Acme\{0}.xml", controller)
            If (File.Exists(fileName)) Then
                Return New MemoryStream(File.ReadAllBytes(fileName))
            End If
            Return DefaultDataControllerStream
        End Function
    End Class

    Partial Public Class ControllerUtilities
        Inherits ControllerUtilitiesBase

        Public Shared ReadOnly Property UtcOffsetInMinutes() As Double
            Get
                Return TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).TotalMinutes
            End Get
        End Property
        Public Overrides ReadOnly Property SupportsScrollingInDataSheet As Boolean
            Get
                Return False
            End Get
        End Property
    End Class





End Namespace
