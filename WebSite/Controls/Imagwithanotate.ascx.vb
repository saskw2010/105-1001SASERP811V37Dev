Imports eZee.Data

Public Class Imagwithanotate
    Inherits System.Web.UI.UserControl
    Dim mylastcode As String
    Protected Sub lbLogin_Click(sender As Object, e As EventArgs) Handles lbLogin.Click
        Dim myControl As usercontrol_SimpleControl
        myControl = LoadControl("SimpleControl.ascx")
        Me.Panel1.Controls.Clear()
        Me.Panel1.Controls.Add(myControl)
        ' AddHandler myControl.btnPostClk, AddressOf ucSimpleControl_onPostClk
        'Dim ucSimpleControl As usercontrol_SimpleControl = LoadControl("~/usercontrol/SimpleControl.ascx")
        '' Set the Public Properties
        If String.IsNullOrEmpty(TextBox1.Text) Then TextBox1.Text = 1
        myControl.FirstName.Text = TextBox1.Text
        ' Dim desc As String = HttpUtility.HtmlDecode(Request.Params("carid"))
        If String.IsNullOrEmpty(myControl.FirstName.Text) Then
        Else
            ' MarkupImage.ImageUrl = "Markup.aspx?backimage=LocalMap.jpg&desc=90,63,2,mostafa anotate;"
            Using calc As SqlText = New SqlText(
                   "select lastannotate from [CarInfom] where Car_No=@Car_No")
                calc.AddParameter("@Car_No", CInt(Left(myControl.FirstName.Text, 1)))
                Dim total As Object = calc.ExecuteScalar()
                Dim descstring As String
                If (DBNull.Value.Equals(total)) Or IsNothing(total) Then
                    descstring = "Havnot annotate"
                    Dim ctl1 As ImageButton = TryCast(myControl.FindControl("MarkupImage"), System.Web.UI.WebControls.ImageButton)
                    If ctl1 IsNot Nothing Then
                        ctl1.ImageUrl = "Markup.aspx?backimage=LocalMap.jpg&desc="
                    End If
                Else
                    descstring = total.ToString()
                    Dim ctl1 As ImageButton = TryCast(myControl.FindControl("MarkupImage"), System.Web.UI.WebControls.ImageButton)
                    If ctl1 IsNot Nothing Then
                        myControl.LastName.Text = descstring
                        ctl1.ImageUrl = "Markup.aspx?backimage=LocalMap.jpg&desc=" & descstring
                    End If
                End If
            End Using
        End If
    End Sub 'lbLogin_Click

    Public Sub LoadUserControl(controlName As String)
        Dim previousControl As Control = Panel1.FindControl(controlName.Split("."c)(0))
        If Not (previousControl Is Nothing) Then
            Me.Panel1.Controls.Remove(previousControl)
        End If
        Dim userControlID As String = controlName.Split("."c)(0)
        Dim targetControl As Control = Panel1.FindControl(userControlID)
        If targetControl Is Nothing Then
            Dim userControl As UserControl = CType(Me.LoadControl(controlName), UserControl)
            'slashes and tildes are forbidden
            userControl.ID = userControlID.Replace("/", "").Replace("~", "")
            Me.Panel1.Controls.Add(userControl)
            'Dim targetControl As Control = Panel1.FindControl(userControlID)
        End If
    End Sub 'LoadUserControl


   
    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If String.IsNullOrEmpty(TextBox1.Text) Then
        Else
            If String.IsNullOrEmpty(mylastcode) Then
                'for first time
                lbLogin_Click(Nothing, Nothing)
                mylastcode = TextBox1.Text
            Else
                If mylastcode = TextBox1.Text Then
                Else
                    'for change value
                    lbLogin_Click(Nothing, Nothing)
                    mylastcode = TextBox1.Text
                End If
            End If
        End If
    End Sub
End Class