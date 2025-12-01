Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security
Imports System.Data.SqlClient

Namespace eZee.Rules

    Partial Public Class vwaspnetUsersBusinessRules
        Inherits eZee.Rules.SharedBusinessRules

        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Custom" and argument that matches "changepassword".
        ''' </summary>
        <Rule("changepasswordr100")>
        Public Sub changepasswordr100Implementation(ByVal applicationId As Nullable(Of System.Guid), ByVal userId As Nullable(Of System.Guid), ByVal userName As String, ByVal loweredUserName As String, ByVal mobileAlias As String, ByVal isAnonymous As Nullable(Of Boolean), ByVal lastActivityDate As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
            Dim user As MembershipUser = Membership.GetUser(userName)
            Dim PasswordSaltstring As String
            Dim PasswordAnswerstring As String
            Using mySqlConnection As New SqlConnection(ConnectionStringSettingsFactory.Create("LocalSqlServer").ConnectionString)
                Try
                    Dim strSql As String = "select rtrim(ltrim(PasswordSalt)) as PasswordSalt,rtrim(ltrim(PasswordAnswer)) as PasswordAnswer from dbo.aspnet_Membership where userId in (select userid  FROM [dbo].[aspnet_Users] where UserName='" & userName & "' )"
                    Dim ds1 As New DataSet()
                    Dim da1 As New SqlDataAdapter()
                    da1.SelectCommand = New SqlCommand(strSql, mySqlConnection)
                    da1.Fill(ds1)
                    If (ds1 IsNot Nothing AndAlso ds1.Tables.Count > 0) Then
                        PasswordSaltstring = ds1.Tables(0).Rows(0).Item(0).ToString
                        PasswordAnswerstring = ds1.Tables(0).Rows(0).Item(1).ToString


                        strSql = " Update [dbo].[aspnet_Membership] set PasswordSalt ='ziz4oFovXtSDve7DB29Ojg==',PasswordAnswer='lqWysnT+JSEFCuBj5suFn7rhJ9M='  where userId in (select userid  FROM [dbo].[aspnet_Users] where UserName='" & userName & "' )"
                        da1.UpdateCommand = New SqlCommand(strSql, mySqlConnection)
                        da1.Fill(ds1)

                        ''where userId in (select userid  FROM [dbo].[aspnet_Users] where UserName=userName)
                        If user IsNot Nothing Then
                            Randomize()
                            ' Generate random value between 1 and 6. 
                            Dim value As Integer = CInt(Int((6 * Rnd()) + 1))
                            Dim pw As String
                            value = value + 2016
                            pw = "admin@" & value
                            Dim exuostring As New dblayer
                            pw = exuostring.GeneratedString()
                            pw = "pw123@" & pw
                            user.ChangePassword(user.ResetPassword("a"), pw)

                            Membership.UpdateUser(user)
                            strSql = " Update [dbo].[aspnet_Membership] set PasswordSalt ='" & PasswordSaltstring & "',PasswordAnswer='" & PasswordAnswerstring & "'  where userId in (select userid  FROM [dbo].[aspnet_Users] where UserName='" & userName & "' )"
                            da1.UpdateCommand = New SqlCommand(strSql, mySqlConnection)
                            da1.Fill(ds1)
                            Result.ExecuteOnClient("alert('Password for the user:  " + userName + "   Become:  " + pw + " successfully ')")
                        Else
                            Result.ExecuteOnClient("alert('User does not exist for the employee " + userName + "')")
                        End If



                    Else
                        PasswordSaltstring = ""
                        PasswordAnswerstring = ""
                    End If
                Catch ex As Exception
                Finally
                    If (mySqlConnection.State = ConnectionState.Open) Then mySqlConnection.Close()
                End Try
            End Using


        End Sub
    End Class
End Namespace
