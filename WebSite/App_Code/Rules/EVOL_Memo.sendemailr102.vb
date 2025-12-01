Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security
Imports System.Data.SqlClient
'Imports System.Web.Mail
Imports System.Net.Mail
Imports System.Net
Imports System.Net.Configuration
Imports System.Web.Configuration

Namespace eZee.Rules

    Partial Public Class EVOL_MemoBusinessRules
        Inherits eZee.Rules.SharedBusinessRules

        ''' <summary>
        ''' This method will execute in any view after an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("sendemailr102")> _
        Public Sub sendemailr102Implementation(ByVal iD As Nullable(Of Integer), ByVal title As String, ByVal categoryID As Nullable(Of Integer), ByVal categoryCategoryname As String, ByVal notes As String, ByVal modifiedBy As String, ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdOn As Nullable(Of DateTime), ByVal sendTo As String, ByVal currentUserName As String)
            'This is the placeholder for method implementation.

            Using mySqlConnection As New SqlConnection(ConnectionStringSettingsFactory.getconnection().ConnectionString)
                Try
                    '------------------------------------------------
                    Dim strSql As String = "select * from QEvolMemo where iD=" & iD & ""
                    Dim ds1 As New DataSet()
                    Dim da1 As New SqlDataAdapter()
                    da1.SelectCommand = New SqlCommand(strSql, mySqlConnection)
                    da1.Fill(ds1)
                    If (ds1 IsNot Nothing AndAlso ds1.Tables.Count > 0) Then
                        Dim message As MailMessage = New MailMessage()
                        Dim webConfigFile As System.Configuration.Configuration = WebConfigurationManager.OpenWebConfiguration("~/web.config")
                        Dim memailsettings As MailSettingsSectionGroup = webConfigFile.GetSectionGroup("system.net/mailSettings")

                        ' prepare smtp client
                        Dim smtp As SmtpClient = New SmtpClient(memailsettings.Smtp.Network.Host, memailsettings.Smtp.Network.Port)
                        smtp.EnableSsl = memailsettings.Smtp.Network.EnableSsl
                        smtp.UseDefaultCredentials = memailsettings.Smtp.Network.DefaultCredentials
                        smtp.Credentials = New NetworkCredential(memailsettings.Smtp.Network.UserName, memailsettings.Smtp.Network.Password)

                        Dim satot As String = ""
                        If ds1.Tables(0).Rows.Count > 0 Then

                            For Each idatarow As DataRow In ds1.Tables(0).Rows
                                '
                                message.From = New MailAddress(memailsettings.Smtp.Network.UserName, idatarow.Item("UserName").ToString)
                                ' use CustomerID to find the recipient's email
                                Dim sendTomail As String = idatarow.Item("TheUserNameUserEmail").ToString
                                If String.IsNullOrEmpty(sendTomail) Then
                                Else
                                    message.To.Add(New MailAddress(sendTomail, idatarow.Item("UserName").ToString))
                                End If
                                '------------------------------------------------
                                message.Subject = idatarow.Item("TheIDtitle").ToString
                                message.Body = idatarow.Item("notes").ToString
                                message.Body = message.Body & "    " & vbCrLf & "http://s.alnajattschool.com/Pages/EVOL_Memo.aspx?id=" & iD & "&_controller=EVOL_Memo&_commandName=Select&_commandArgument=editForm1"

                            Next
                            smtp.Send(message)
                            Result.ShowAlert("Email has been sent   For all.")

                        End If


                    Else

                    End If
                Catch ex As Exception
                Finally
                    If (mySqlConnection.State = ConnectionState.Open) Then mySqlConnection.Close()
                End Try
            End Using
            'Dim myIntsgm As String = HttpContext.Current.Session("getThebranchDesc1")
            'If String.IsNullOrEmpty(myIntsgm) Then
            '    Return "'   >>>>>> _'"
            'Else
            '    Return myIntsgm
            'End If



        End Sub
    End Class
End Namespace
