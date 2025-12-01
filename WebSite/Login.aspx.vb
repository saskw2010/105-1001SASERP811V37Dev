Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.Security
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.Text

Namespace SKY365
    Partial Public Class Login
        Inherits Global.System.Web.UI.Page

        ' إعدادات التحكم في مراحل المصادقة (تقرأ من Web.config > appSettings)
        Private ReadOnly Property ENABLE_STAGE1_USER_CHECK As Boolean
            Get
                Dim v As String = ConfigurationManager.AppSettings("Auth.EnableStage1UserCheck")
                Dim b As Boolean = False
                If Not String.IsNullOrEmpty(v) Then Boolean.TryParse(v, b)
                Return b
            End Get
        End Property

        Private ReadOnly Property ENABLE_STAGE2_PASSWORD_CHECK As Boolean
            Get
                Dim v As String = ConfigurationManager.AppSettings("Auth.EnableStage2PasswordCheck")
                Dim b As Boolean = False
                If Not String.IsNullOrEmpty(v) Then Boolean.TryParse(v, b)
                Return b
            End Get
        End Property

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            ' تنظيف الأخطاء السابقة
            lblError.Visible = False

            ' إذا كان المستخدم مسجل دخول بالفعل، توجيهه للصفحة الرئيسية
            If Page.User.Identity.IsAuthenticated Then
                Dim returnUrl As String = Request.QueryString("ReturnUrl")
                If Not String.IsNullOrEmpty(returnUrl) AndAlso IsLocalUrl(returnUrl) AndAlso Not returnUrl.ToLower().Contains("login.aspx") Then
                    Response.Redirect(returnUrl)
                Else
                    Response.Redirect("~/Pages/Home.aspx")
                End If
            End If
        End Sub

        ' خاصية للتحكم في إظهار Google Login من web.config
        Public ReadOnly Property IsGoogleLoginEnabled As Boolean
            Get
                Dim configValue As String = ConfigurationManager.AppSettings("Login.EnableGoogleLogin")
                If String.IsNullOrEmpty(configValue) Then
                    Return False
                End If
                Dim result As Boolean = False
                Boolean.TryParse(configValue, result)
                Return result
            End Get
        End Property

        ' خاصية للتحكم في إظهار زر التشخيص من web.config
        Public ReadOnly Property ShowDiagnosticButton As Boolean
            Get
#If DEBUG Then
                    Return True
#Else
                Dim configValue As String = ConfigurationManager.AppSettings("Login.ShowDiagnosticButton")
                If String.IsNullOrEmpty(configValue) Then
                    Return False
                End If
                Dim result As Boolean = False
                Boolean.TryParse(configValue, result)
                Return result
#End If
            End Get
        End Property
        Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
            ' Ensure validation runs even if the button has CausesValidation="false"
            Page.Validate()
            If Not Page.IsValid Then
                Return
            End If

            Dim username As String = txtUsername.Text.Trim()
            Dim password As String = txtPassword.Text.Trim()

            If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
                ShowError("يرجى إدخال اسم المستخدم وكلمة المرور")
                Return
            End If

            'Try

            ' ===== المرحلة الأولى: التحقق من وجود المستخدم في قاعدة البيانات =====
            If ENABLE_STAGE1_USER_CHECK Then
                If Not CheckUserExistsInDatabase(username) Then
                    ShowError("المرحلة الأولى: المستخدم غير موجود في قاعدة البيانات المخصصة")
                    ClearForm()
                    Return
                End If
            End If

            ' ===== المرحلة الثانية: التحقق من اليوزر + الباسورد في قاعدة البيانات =====
            If ENABLE_STAGE2_PASSWORD_CHECK Then
                If Not ValidateUserPasswordInDatabase(username, password) Then
                    ShowError("المرحلة الثانية: كلمة المرور غير صحيحة في قاعدة البيانات المخصصة")
                    ClearForm()
                    Return
                End If
            End If

            ' ===== المصادقة الأساسية =====
            If Membership.ValidateUser(username, password) Then


                ' جميع المراحل نجحت - تسجيل دخول
                FormsAuthentication.SetAuthCookie(username, False)

                ' إعادة التوجيه
                Dim returnUrl As String = Request.QueryString("ReturnUrl")
                If Not String.IsNullOrEmpty(returnUrl) AndAlso IsLocalUrl(returnUrl) Then
                    If Not returnUrl.ToLower().Contains("login.aspx") Then
                        Response.Redirect(returnUrl, False)
                    Else
                        Response.Redirect("~/Pages/Home.aspx", False)
                    End If
                Else
                    Response.Redirect("~/Pages/Home.aspx", False)
                End If

                Context.ApplicationInstance.CompleteRequest()
            Else
                ShowError("اسم المستخدم أو كلمة المرور غير صحيحة")
                ClearForm()
            End If
            'Catch ex As Exception
            '    ShowError("حدث خطأ أثناء تسجيل الدخول: " & ex.Message)
            '    ClearForm()
            'End Try
        End Sub

        Protected Sub btnDiagnose_Click(ByVal sender As Object, ByVal e As EventArgs)
            ShowMembershipProviderInfo()
        End Sub

        Private Function IsLocalUrl(ByVal url As String) As Boolean
            If String.IsNullOrEmpty(url) Then
                Return False
            End If
            Return url.StartsWith("/") AndAlso Not url.StartsWith("//") AndAlso Not url.StartsWith("/\")
        End Function

        ' ===== المرحلة الثانية: تحقق من المستخدم وكلمة المرور فعليًا (باستخدام مزود الموقع AspNetUsers) =====
        ' يعتمد على MembershipProvider الحالي الذي يخزن كلمة المرور في AspNetUsers.PasswordHash بنفس خوارزمية HMACSHA1/Unicode + ValidationKey
        Private Function ValidateUserPasswordInDatabase(ByVal username As String, ByVal password As String) As Boolean
            Try
                Dim connectionString As String = ConfigurationManager.ConnectionStrings("eZee").ConnectionString
                Using conn As New SqlConnection(connectionString)
                    conn.Open()

                    ' اجلب صف المستخدم مباشرة من AspNetUsers (يتماشى مع MembershipProvider في App_Code/Security/MembershipProvider.vb)
                    Dim sql As String = "SELECT PasswordHash, IsApproved, IsLockedOut FROM AspNetUsers WHERE UserName = @UserName"
                    Using cmd As New SqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@UserName", username)
                        Using r As SqlDataReader = cmd.ExecuteReader()
                            If Not r.Read() Then Return False

                            Dim storedPwd As String = If(r.IsDBNull(0), Nothing, Convert.ToString(r.GetValue(0)))
                            Dim isApproved As Boolean = If(r.IsDBNull(1), False, Convert.ToBoolean(r.GetValue(1)))
                            Dim isLocked As Boolean = If(r.IsDBNull(2), False, Convert.ToBoolean(r.GetValue(2)))
                            If Not isApproved OrElse isLocked Then Return False

                            ' استخدم الدالة المشتركة في الـ Provider لحساب الهاش بنفس الإعدادات
                            Dim inputHash As String = eZee.Security.ApplicationMembershipProviderBase.EncodeUserPassword(password)
                            If String.IsNullOrEmpty(storedPwd) OrElse String.IsNullOrEmpty(inputHash) Then Return False
                            Return String.Equals(inputHash, storedPwd, StringComparison.Ordinal)
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("خطأ في المرحلة الثانية - فحص كلمة المرور (AspNetUsers): " & ex.Message)
                Return False
            End Try
        End Function

        ' ===== المرحلة الأولى: التحقق من وجود المستخدم في قاعدة البيانات (AspNetUsers) =====
        Private Function CheckUserExistsInDatabase(ByVal username As String) As Boolean
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("eZee").ConnectionString
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT COUNT(*) FROM AspNetUsers WHERE UserName = @UserName"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@UserName", username)
                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        End Function

        ' ===== فحص شامل لإعدادات المصادقة =====
        Private Sub ShowMembershipProviderInfo()
            Try
                Dim provider As MembershipProvider = Membership.Provider
                Dim info As New StringBuilder()

                info.AppendLine("==== فحص إعدادات المصادقة ====")
                info.AppendLine("Provider Name: " & provider.Name)
                info.AppendLine("Provider Type: " & provider.GetType().FullName)
                info.AppendLine("Application Name: " & provider.ApplicationName)
                info.AppendLine("Password Format: " & provider.PasswordFormat.ToString())
                info.AppendLine("Enable Password Retrieval: " & provider.EnablePasswordRetrieval.ToString())
                info.AppendLine("Enable Password Reset: " & provider.EnablePasswordReset.ToString())
                info.AppendLine("Requires Question And Answer: " & provider.RequiresQuestionAndAnswer.ToString())
                info.AppendLine("Max Invalid Password Attempts: " & provider.MaxInvalidPasswordAttempts.ToString())
                info.AppendLine("Password Attempt Window: " & provider.PasswordAttemptWindow.ToString())
                info.AppendLine("Min Required Password Length: " & provider.MinRequiredPasswordLength.ToString())

                ' فحص نوع Provider المخصص من مجلد Security
                If TypeOf provider Is eZee.Security.ApplicationMembershipProviderBase Then
                    info.AppendLine("** يستخدم Custom Provider من مجلد Security **")
                    info.AppendLine("يقرأ من جدول: AspNetUsers (حسب SQL Statements)")
                Else
                    info.AppendLine("** يستخدم SqlMembershipProvider العادي **")
                    info.AppendLine("يقرأ من جداول: aspnet_Users, aspnet_Membership")
                End If

                ' فحص connection string
                Dim connStr As String = ConfigurationManager.ConnectionStrings("LocalSqlServer").ConnectionString
                info.AppendLine("Connection String: " & connStr.Substring(0, Math.Min(50, connStr.Length)) & "...")

                ' عرض النتائج في Debug
                System.Diagnostics.Debug.WriteLine(info.ToString())

                ' إضافة إخراج للكونسول في المتصفح
                Dim infoText As String = info.ToString().Replace(vbCrLf, "\n").Replace("""", "\""")
                Dim jsScript As String = String.Format("console.log(""{0}"");", infoText)
                Response.Write("<script type='text/javascript'>" & jsScript & "</script>")

                ' إضافة إخراج مرئي في الصفحة (للمطورين)
                Dim htmlInfo As String = "<div style='background:#f0f0f0; border:1px solid #ccc; padding:10px; margin:10px; font-family:monospace; white-space:pre-wrap; direction:ltr;'>" &
                                       HttpUtility.HtmlEncode(info.ToString()) & "</div>"
                Response.Write(htmlInfo)

                ' عرض نتيجة مختصرة للمستخدم
                ShowError("فحص المصادقة: " & provider.Name & " (" & provider.PasswordFormat.ToString() & ")")

            Catch ex As Exception
                ShowError("خطأ في فحص إعدادات المصادقة: " & ex.Message)
                ' إضافة إخراج الأخطاء للكونسول أيضاً
                Dim errorMsg As String = "خطأ في فحص إعدادات المصادقة: " & ex.Message.Replace("""", "\""")
                Response.Write("<script type='text/javascript'>console.error(""" & errorMsg & """);</script>")
            End Try
        End Sub

        ' ===== فحص تفصيلي للمستخدم في قاعدة البيانات =====
        Private Sub CheckUserInDatabase(ByVal username As String)
            Try
                Dim connStr As String = ConfigurationManager.ConnectionStrings("eZee").ConnectionString
                Using conn As New SqlConnection(connStr)
                    Dim query As String = "SELECT UserName, IsApproved, IsLockedOut FROM AspNetUsers WHERE UserName = @UserName"

                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@UserName", username)
                        conn.Open()

                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                Dim info As String = String.Format("المستخدم موجود - IsApproved: {0}, IsLockedOut: {1}",
                                                                  reader("IsApproved"), reader("IsLockedOut"))
                                ShowError(info)
                            Else
                                ShowError("المستخدم غير موجود في جدول AspNetUsers")
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                ShowError("خطأ في فحص المستخدم: " & ex.Message)
            End Try
        End Sub

        Private Sub ShowError(ByVal message As String)
            lblError.Text = message
            lblError.Visible = True
        End Sub

        Private Sub ClearForm()
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Focus()
        End Sub
        Private Function mydomainname() As String
            Return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath.TrimEnd("/")
        End Function

        Private Function MyMapPath(ByVal virtualPath As String) As String
            Return HttpContext.Current.Server.MapPath(virtualPath)
        End Function

        Private Function myvirtualpathfun() As String
            Return HttpContext.Current.Request.ApplicationPath
        End Function

        Private Function myvirtualpathfunwithout() As String
            Return HttpContext.Current.Request.ApplicationPath.TrimEnd("/")
        End Function

    End Class



End Namespace