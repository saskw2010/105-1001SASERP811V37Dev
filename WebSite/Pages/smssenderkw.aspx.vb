
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml

Partial Class Pages_smssenderkw
    Inherits Global.eZee.Web.PageBase

    Public ReadOnly Property CssClass() As String
        Get
            Return ""
        End Get
    End Property
    Private Sub WriteToFile(text As String)
        Dim path As String = Server.MapPath("~/App_Data/ServiceLog.txt")
        ''"c:\\ServiceLog.txt"
        Using writer As New StreamWriter(path, True)
            writer.WriteLine(String.Format(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
            writer.Close()
        End Using
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dt As New DataTable()
            Dim query As String = " Select  [SMSQUEUEID],[SMSQUEUENumber],[smsdone],[smsContent],[smscatid],[smsbrand],[smsdate],[SCHDATE] From [QSMSList] WHERE smsdone=0 and  SMSQUEUENumber is Not null  and len(SMSQUEUENumber)>6"
            Using con As New SqlConnection(ConfigurationManager.ConnectionStrings("ezee").ToString)
                Using cmd As New SqlCommand(query)
                    cmd.Connection = con
                    'cmd.Parameters.AddWithValue("@Day", DateTime.Today.Day)
                    'cmd.Parameters.AddWithValue("@Month", DateTime.Today.Month)
                    Using sda As New SqlDataAdapter(cmd)
                        sda.Fill(dt)
                    End Using
                End Using
            End Using
            For Each row As DataRow In dt.Rows
                Dim SMSQUEUEID As String = row("SMSQUEUEID").ToString()
                Dim namestr As String = row("SMSQUEUENumber").ToString()
                Dim email As String = row("smsContent").ToString()
                WriteToFile("Trying to send sms to: " & namestr & " " & email)
                '--------------------- get prameter to activate specific way 
                Response.Write("Trying to send sms to: " & namestr & " " & email)
                ''Dim SMSResponse As String = ServiceSMS.SendSMS("ACC_512-974", "PvR8Qsl6TthY4IkN", 1718, namestr, email)
                Dim urlstring As String
                urlstring = ConfigurationManager.AppSettings("SMSBOX").ToString()
                If IsNothing(urlstring) Or String.IsNullOrEmpty(urlstring) Or String.IsNullOrWhiteSpace(urlstring) Then
                    urlstring = "SMSBOX.COM"
                End If
                Dim urlstring1 As String
                urlstring1 = ConfigurationManager.AppSettings("SMSUsername").ToString()
                If IsNothing(urlstring1) Or String.IsNullOrEmpty(urlstring1) Or String.IsNullOrWhiteSpace(urlstring1) Then
                    urlstring1 = "saskw2012"
                End If
                Dim urlstring2 As String
                urlstring2 = ConfigurationManager.AppSettings("SMSPassword").ToString()
                If IsNothing(urlstring2) Or String.IsNullOrEmpty(urlstring2) Or String.IsNullOrWhiteSpace(urlstring2) Then
                    urlstring2 = "Admin@sas123"
                End If

                Dim urlstringid As String
                urlstringid = ConfigurationManager.AppSettings("SMSCustomerId").ToString()
                If IsNothing(urlstringid) Or String.IsNullOrEmpty(urlstringid) Or String.IsNullOrWhiteSpace(urlstringid) Then
                    urlstringid = "1374"
                End If
                Dim smssendrequestuser As New kwsms.SoapUser()
                smssendrequestuser.CustomerId = urlstringid.ToString()
                smssendrequestuser.Username = urlstring1.ToString()
                smssendrequestuser.Password = urlstring2.ToString()
                Dim smssendrequest As New kwsms.SendingSMSRequest
                smssendrequest.User = smssendrequestuser
                smssendrequest.SenderText = urlstring.ToString()
                smssendrequest.RecipientNumbers = namestr
                smssendrequest.MessageBody = email
                Dim smssendrequestresult As New kwsms.SendingSMSResult
                Dim smsboxservice As New kwsms.Messaging
                smssendrequestresult = smsboxservice.SendSMS(smssendrequest)
                Dim resultflage As String
                resultflage = smssendrequestresult.Result.ToString

                WriteToFile(" sms sent to: " & namestr & " " & email & "  " & resultflage)
                Response.Write(" sms sent to: " & namestr & " " & email & "  " & resultflage)
                '-----------------------------------------
                Dim query1 As String = "update  SMSQUEUEListd set smsdone=1 where  SMSQUEUEID=@SMSQUEUEID"
                Dim i As Integer
                Dim con1 As New SqlConnection(ConfigurationManager.ConnectionStrings("ezee").ToString)
                Dim cmd1 As SqlCommand = New SqlCommand(query1, con1)

                cmd1.Parameters.Add("@SMSQUEUEID", SqlDbType.BigInt).Value = SMSQUEUEID.ToString()
                cmd1.Connection.Open()
                i = cmd1.ExecuteNonQuery()
                cmd1.Connection.Close()
                WriteToFile(" sms sent to: " & namestr & " " & email & "  and updated")
                Response.Write(" sms sent to: " & namestr & " " & email & "  and updated")
            Next
            Response.Write(" this from mosso sassmssender payload execution")
            WriteToFile(" this from mosso sassmssender payload execution")
        Catch ex As Exception
            WriteToFile("An error occurred: " & ex.Message)
        End Try
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim extraInfo As String = String.Empty
        Dim xmlr As XmlReader = Nothing
        Using conn As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ezee").ToString)
            Using xmlStream As FileStream = File.OpenRead(Server.MapPath("~/App_Data/_Dates.xml"))
                extraInfo = New StreamReader(xmlStream).ReadToEnd()
            End Using

            Dim cmd As SqlCommand = New SqlCommand("INSERT INTO rgn_Xml (ExtraInfo) VALUES(@ExtraInfo)", conn)
            cmd.Parameters.Add("@ExtraInfo", SqlDbType.Xml)
            cmd.Parameters("@ExtraInfo").Value = extraInfo.Trim()
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
        End Using
        Using conn1 As SqlConnection = New SqlConnection(ConfigurationManager.ConnectionStrings("ezee").ToString)
            Dim cmdXml As SqlCommand = New SqlCommand("Select  ExtraInfo From rgn_Xml ", conn1)
            conn1.Open()
            xmlr = cmdXml.ExecuteXmlReader()
            Dim DS As DataSet = New DataSet("ExtraInfo")
            DS.ReadXml(xmlr)
            GridViewXmlData.DataSource = DS
            GridViewXmlData.DataBind()
        End Using
    End Sub
End Class
