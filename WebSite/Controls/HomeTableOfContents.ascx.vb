Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Net
Imports eZee.Data

Partial Public Class Controls_HomeTableOfContents
    Inherits Global.System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not (IsPostBack) Then
            Try
                ' User tracking
                OnlineActiveUsers.OnlineUsersInstance.OnlineUsers.SetUserOnline(Page.User.Identity.Name)
                
                ' Workstation tracking
                Dim workstationidstring As String = DataLogic.GetConnectionStringworkstation()
                Session.Add("workstationidstring", workstationidstring)
                Dim ixi As Integer = DataLogic.logintrack(Page.User.Identity.Name, DateTime.Now(), workstationidstring)
                
                ' Set labels for debugging (hidden)
                Label1.Text = HttpContext.Current.User.Identity.Name
                Label2.Text = Dns.GetHostName()
                
                ' Get IP addresses
                Dim ipmosso As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName)
                Label3.Text = ipmosso.AddressList(0).ToString()
                
                Dim ipaddress As String = Request.ServerVariables("HTTP_X_FORWARDED_FOR")
                If String.IsNullOrEmpty(ipaddress) Then
                    ipaddress = Request.ServerVariables("REMOTE_ADDR")
                End If
                Label3.Text = Label3.Text & "  ::  " & ipaddress
                
                If ipmosso.AddressList.Count > 1 Then
                    Label4.Text = ipmosso.AddressList(1).ToString()
                End If

                ' Build IP list
                TextBox1.Text = ""
                For i = 0 To ipmosso.AddressList.Count() - 1
                    TextBox1.Text = TextBox1.Text + ipmosso.AddressList(i).ToString() + vbNewLine
                Next
                
                Label6.Text = Session("workstationidstring").ToString

            Catch ex As Exception
                ' Handle errors gracefully
                Label1.Text = "Error: " & ex.Message
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Get external IP address
    ''' </summary>
    Function GetExternalIP(ByVal webPath As String) As String
        Try
            Dim output As String = ""
            Dim webReq As New System.Net.WebClient
            output = System.Text.Encoding.ASCII.GetString((webReq.DownloadData(webPath)))
            webReq.Dispose()
            Return output
        Catch
            Return "Unable to get external IP"
        End Try
    End Function

    ''' <summary>
    ''' Configure node targets for TreeView (if needed)
    ''' </summary>
    Private Sub ConfigureNodeTargets(ByVal nodes As TreeNodeCollection)
        For Each n As TreeNode In nodes
            Dim m As Match = Regex.Match(n.NavigateUrl, "^(_\w+):(.+)$")
            If m.Success Then
                n.Target = m.Groups(1).Value
                n.NavigateUrl = m.Groups(2).Value
            End If
            ConfigureNodeTargets(n.ChildNodes)
        Next
    End Sub
End Class
