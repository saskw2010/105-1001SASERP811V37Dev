Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Configuration
Imports eZee.Data

Public Class defaultsc
    Inherits System.Web.UI.Page
    
    ' Modern control management variables
    Dim controlID As String = "ModernUserControl"
    Shared createAgain As Boolean = False

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            InitializeControls()
            LoadUserInformation()
        End If
    End Sub

    ''' <summary>
    ''' Initialize modern control settings
    ''' </summary>
    Private Sub InitializeControls()
        Try
            ' Set initial values and configurations
            If String.IsNullOrEmpty(ModernTextBox1.Text) Then
                ModernTextBox1.Text = ""
            End If

            ' Configure modern button
            Button1.Text = "إضافة مكون بسيط"
            Button1.CssClass = "modern-button"

            ' Set user label initial text
            If String.IsNullOrEmpty(lblUser.Text) Then
                lblUser.Text = "مرحباً بك في النظام"
            End If

        Catch ex As Exception
            ' Handle initialization errors gracefully
            lblUser.Text = "خطأ في تهيئة عناصر التحكم: " & ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' Load and display user information
    ''' </summary>
    Private Sub LoadUserInformation()
        Try
            ' Get current user context (using traditional VB.NET syntax for compatibility)
            Dim currentUser As String = "مجهول"
            If HttpContext.Current.User IsNot Nothing AndAlso HttpContext.Current.User.Identity IsNot Nothing AndAlso Not String.IsNullOrEmpty(HttpContext.Current.User.Identity.Name) Then
                currentUser = HttpContext.Current.User.Identity.Name
            End If
            Dim currentTime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
            
            ' Update user display
            lblUser.Text = String.Format("المستخدم: {0} | الوقت: {1}", currentUser, currentTime)

        Catch ex As Exception
            lblUser.Text = "غير متاح"
        End Try
    End Sub

    ''' <summary>
    ''' Handle modern textbox text change event (replacement for RadTextBox)
    ''' </summary>
    Protected Sub ModernTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ModernTextBox1.TextChanged
        Try
            ' Process modern textbox input
            Dim inputText As String = ModernTextBox1.Text.Trim()
            
            If Not String.IsNullOrEmpty(inputText) Then
                ' Update user label with input feedback
                lblUser.Text = String.Format("تم إدخال النص: '{0}' في {1}", inputText, DateTime.Now.ToString("HH:mm:ss"))
                
                ' Create user control with modern input
                CreateModernUserControl(inputText)
            End If

        Catch ex As Exception
            lblUser.Text = "خطأ في معالجة النص: " & ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' Handle traditional textbox text change event
    ''' </summary>
    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim inputText As String = TextBox1.Text.Trim()
            
            If Not String.IsNullOrEmpty(inputText) Then
                ' Update display with traditional textbox input
                lblUser.Text = String.Format("النص التقليدي: '{0}' | تم التحديث: {1}", inputText, DateTime.Now.ToString("HH:mm:ss"))
                
                ' Create user control with traditional method
                CreateTraditionalUserControl(inputText)
            End If

        Catch ex As Exception
            lblUser.Text = "خطأ في معالجة النص التقليدي: " & ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' Handle button click to add simple control
    ''' </summary>
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            ' Create instance of the UserControl SimpleControl
            Dim myControl As UserControl = LoadControl("SimpleControl.ascx")
            Dim simpleControl As usercontrol_SimpleControl = DirectCast(myControl, usercontrol_SimpleControl)
            
            ' Clear placeholder and add new control
            Placeholder1.Controls.Clear()
            Placeholder1.Controls.Add(simpleControl)
            
            ' Add event handler for modern interaction
            AddHandler simpleControl.btnPostClk, AddressOf ucSimpleControl_onPostClk
            
            ' Update user feedback
            lblUser.Text = String.Format("تم إضافة مكون جديد في {0}", DateTime.Now.ToString("HH:mm:ss"))
            
            ' Set flag for recreation
            createAgain = True

        Catch ex As Exception
            lblUser.Text = "خطأ في إضافة المكون: " & ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' Handle user control post click event
    ''' </summary>
    Protected Sub ucSimpleControl_onPostClk(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            ' Find the user control by traversing up the control hierarchy
            Dim button As Button = DirectCast(sender, Button)
            Dim ucSimpleControl As usercontrol_SimpleControl = DirectCast(button.Parent.Parent, usercontrol_SimpleControl)
            lblUser.Text = String.Format("مرحباً {0} {1} - تم التفاعل في {2}", 
                                       ucSimpleControl.FirstName.Text, 
                                       ucSimpleControl.LastName.Text,
                                       DateTime.Now.ToString("HH:mm:ss"))

        Catch ex As Exception
            lblUser.Text = "خطأ في معالجة التفاعل: " & ex.Message
        End Try
    End Sub

    ''' <summary>
    ''' Create modern user control with enhanced functionality
    ''' </summary>
    Private Sub CreateModernUserControl(inputText As String)
        Try
            ' Create instance of the UserControl SimpleControl
            Dim loadedControl As UserControl = LoadControl("SimpleControl.ascx")
            Dim ucSimpleControl As usercontrol_SimpleControl = DirectCast(loadedControl, usercontrol_SimpleControl)

            ' Set enhanced properties based on input
            If inputText.Contains(" ") Then
                Dim parts() As String = inputText.Split(" "c)
                ucSimpleControl.FirstName.Text = parts(0)
                ucSimpleControl.LastName.Text = If(parts.Length > 1, parts(1), "")
            Else
                ucSimpleControl.FirstName.Text = inputText
                ucSimpleControl.LastName.Text = "مستخدم"
            End If

            ' Create Event Handler for btnPost Click 
            AddHandler ucSimpleControl.btnPostClk, AddressOf ucSimpleControl_onPostClk

            ' Add the SimpleControl to Placeholder
            Placeholder1.Controls.Add(ucSimpleControl)

            ' Add the instance to Session for persistence
            Session.Add((Session.Count + 1).ToString(), ucSimpleControl)

            ' Set createAgain flag
            createAgain = True

        Catch ex As Exception
            ' Handle control creation errors
        End Try
    End Sub

    ''' <summary>
    ''' Create traditional user control (legacy method maintained)
    ''' </summary>
    Private Sub CreateTraditionalUserControl(inputText As String)
        Try
            Dim loadedControl As UserControl = LoadControl("SimpleControl.ascx")
            Dim ucSimpleControl As usercontrol_SimpleControl = DirectCast(loadedControl, usercontrol_SimpleControl)

            ' Set the Public Properties with traditional approach
            ucSimpleControl.FirstName.Text = If(IsNumeric(inputText), "رقم", inputText)
            ucSimpleControl.LastName.Text = "تقليدي"

            ' Create Event Handler for btnPost Click 
            AddHandler ucSimpleControl.btnPostClk, AddressOf ucSimpleControl_onPostClk

            ' Add the SimpleControl to Placeholder
            Placeholder1.Controls.Add(ucSimpleControl)

            ' Add the instance to Session Variable
            Session.Add((Session.Count + 1).ToString(), ucSimpleControl)

            ' Set createAgain flag
            createAgain = True

        Catch ex As Exception
            ' Handle traditional control creation errors
        End Try
    End Sub

    ''' <summary>
    ''' Page PreInit event for control recreation
    ''' </summary>
    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit
        Try
            Dim ctrl As Control = GetPostBackControl(Me.Page)

            ' Check if the postback is caused by the button or if createAgain is true
            If (ctrl IsNot Nothing AndAlso ctrl.ClientID = Button1.ClientID) OrElse createAgain Then
                createAgain = True
                CreateUserControl(controlID)
            End If

        Catch ex As Exception
            ' Handle PreInit errors gracefully
        End Try
    End Sub

    ''' <summary>
    ''' Get the control that caused the postback
    ''' </summary>
    Protected Function GetPostBackControl(ByVal pg As Page) As Control
        Dim ctl1 As Control = Nothing

        Try
            Dim ctrlName As String = pg.Request.Params.Get("__EVENTTARGET")

            If ctrlName IsNot Nothing AndAlso ctrlName <> String.Empty Then
                ctl1 = Page.FindControl(ctrlName)
            Else
                ' Alternative method for finding the control
                Dim i As Integer = 0
                Dim len As Integer = Page.Request.Form.Count
                
                While i < len
                    Dim formKey As String = Page.Request.Form.AllKeys(i)
                    If formKey IsNot Nothing Then
                        Dim ctl As String() = formKey.Split("$"c)
                        If ctl.Length > 2 Then
                            ctl1 = TryCast(Page.FindControl(ctl(2)), System.Web.UI.WebControls.Button)
                        End If
                    End If

                    If ctl1 IsNot Nothing Then
                        Exit While
                    End If
                    i += 1
                End While
            End If

        Catch ex As Exception
            ' Handle postback control detection errors
        End Try

        Return ctl1
    End Function

    ''' <summary>
    ''' Create user control during postback recreation
    ''' </summary>
    Protected Sub CreateUserControl(ByVal controlID As String)
        Try
            If createAgain AndAlso Placeholder1 IsNot Nothing Then
                If Session.Count > 0 Then
                    Placeholder1.Controls.Clear()
                    
                    For i As Integer = 0 To Session.Count - 1
                        If Session(i) IsNot Nothing Then
                            Select Case Session(i).ToString()
                                Case "ASP.usercontrol_simplecontrol_ascx"
                                    ' Create instance of the UserControl SimpleControl
                                    Dim ucSimpleControl As usercontrol_SimpleControl = TryCast(LoadControl("SimpleControl.ascx"), usercontrol_SimpleControl)

                                    If ucSimpleControl IsNot Nothing Then
                                        ' Set the Public Properties from session
                                        Dim sessionControl As usercontrol_SimpleControl = DirectCast(Session(i), usercontrol_SimpleControl)
                                        ucSimpleControl.FirstName.Text = sessionControl.FirstName.Text
                                        ucSimpleControl.LastName.Text = sessionControl.LastName.Text

                                        ' Create Event Handler for btnPost Click 
                                        AddHandler ucSimpleControl.btnPostClk, AddressOf ucSimpleControl_onPostClk

                                        ' Add the SimpleControl to Placeholder
                                        Placeholder1.Controls.Add(ucSimpleControl)
                                    End If
                                    Exit Select
                            End Select
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            ' Handle user control creation errors
        End Try
    End Sub
End Class