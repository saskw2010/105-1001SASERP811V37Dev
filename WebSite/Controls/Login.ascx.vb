Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.Security
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Partial Public Class Controls_Login
    Inherits Global.System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If (Page.User.Identity.IsAuthenticated AndAlso Not (String.IsNullOrEmpty(Request.Params("ReturnUrl")))) Then
            Response.Redirect("~/Pages/Home.aspx")
        End If
    End Sub

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        ' التحقق من صحة البيانات المدخلة
        If Not Page.IsValid Then
            Return
        End If

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' التحقق من عدم وجود بيانات فارغة
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            ShowError("يرجى إدخال اسم المستخدم وكلمة المرور")
            Return
        End If

        ' محاولة المصادقة
        If AuthenticateUser(username, password) Then
            ' المصادقة نجحت - التحقق من اكتمال البيانات
            If ValidateUserInDetails(username) Then
                ' البيانات مكتملة - دخول عادي
                FormsAuthentication.SetAuthCookie(username, False)
                
                ' إعادة التوجيه للصفحة المطلوبة أو الصفحة الرئيسية
                Dim returnUrl As String = Request.QueryString("ReturnUrl")
                If Not String.IsNullOrEmpty(returnUrl) AndAlso IsLocalUrl(returnUrl) Then
                    Response.Redirect(returnUrl)
                Else
                    Response.Redirect("~/Default.aspx")
                End If
            Else
                ' المصادقة نجحت لكن البيانات ناقصة - توجيه لإكمال البيانات
                FormsAuthentication.SetAuthCookie(username, False)
                Response.Redirect("~/Pages/MYprofile_1.aspx?reason=missing_details")
            End If
        Else
            ' المصادقة فشلت
            ShowError("اسم المستخدم أو كلمة المرور غير صحيحة")
            ClearForm()
        End If
    End Sub

    Private Function AuthenticateUser(ByVal username As String, ByVal password As String) As Boolean
        Try
            ' التحقق من صحة البيانات المدخلة أولاً
            If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
                Return False
            End If

            ' التحقق من طول البيانات (حماية من الهجمات)
            If username.Length > 50 OrElse password.Length > 100 Then
                Return False
            End If

            ' تسجيل محاولة تسجيل الدخول للمراقبة
            System.Diagnostics.Debug.WriteLine("Authentication attempt for user: " & username & " at " & DateTime.Now.ToString())

            ' طريقة 1: المصادقة عبر Membership Provider أولاً (الأكثر أماناً)
            If Membership.ValidateUser(username, password) Then
                System.Diagnostics.Debug.WriteLine("Authentication successful via Membership Provider for user: " & username)
                Return True
            End If

            ' طريقة 2: المصادقة عبر قاعدة البيانات المخصصة
            If AuthenticateViaDatabase(username, password) Then
                System.Diagnostics.Debug.WriteLine("Authentication successful via Database for user: " & username)
                Return True
            End If

            ' طريقة 3: المصادقة عبر API (الأقل أماناً - فقط كآخر محاولة)
            If AuthenticateViaAPI(username, password) Then
                System.Diagnostics.Debug.WriteLine("Authentication successful via API for user: " & username)
                Return True
            End If

            ' تسجيل فشل المصادقة
            System.Diagnostics.Debug.WriteLine("Authentication failed for user: " & username & " at " & DateTime.Now.ToString())
            Return False

        Catch ex As Exception
            ' تسجيل الخطأ
            System.Diagnostics.Debug.WriteLine("Authentication error for user " & username & ": " & ex.Message)
            Return False
        End Try
    End Function

    Private Function AuthenticateViaAPI(ByVal username As String, ByVal password As String) As Boolean
        Try
            ' التحقق من وجود خدمة المصادقة محلياً فقط
            Dim baseUrl As String = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority)
            Dim authUrl As String = baseUrl & "/appservices/_auth?skyuser=" & HttpUtility.UrlEncode(username) & "&skyuserpwd=" & HttpUtility.UrlEncode(password)

            ' استخدام HttpWebRequest بدلاً من WebClient للتحكم في Timeout
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(authUrl), HttpWebRequest)
            request.Method = "GET"
            request.Timeout = 5000 ' 5 ثواني
            request.Headers.Add("X-Requested-With", "XMLHttpRequest")

            Dim response As String = ""
            Using webResponse As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(webResponse.GetResponseStream())
                    response = reader.ReadToEnd()
                End Using
            End Using

            ' التحقق الصارم من الاستجابة
            If String.IsNullOrEmpty(response) Then
                Return False
            End If

            ' يجب أن تحتوي الاستجابة على نص إيجابي صريح
            Dim responseText As String = response.Trim().ToLower()

            ' فحص صارم للاستجابة الصحيحة
            If responseText.Contains("success") OrElse
               responseText.Contains("true") OrElse
               responseText.Contains("authenticated") OrElse
               responseText.Contains("valid") Then

                ' تأكد من عدم وجود رسائل خطأ
                If Not responseText.Contains("error") AndAlso
                   Not responseText.Contains("invalid") AndAlso
                   Not responseText.Contains("failed") AndAlso
                   Not responseText.Contains("denied") Then
                    Return True
                End If
            End If

            Return False

        Catch ex As System.Net.WebException
            ' خطأ في الشبكة = فشل المصادقة
            System.Diagnostics.Debug.WriteLine("Network error during API authentication: " & ex.Message)
            Return False
        Catch ex As Exception
            ' أي خطأ آخر = فشل المصادقة
            System.Diagnostics.Debug.WriteLine("API Authentication error: " & ex.Message)
            Return False
        End Try
    End Function
    
    Private Function AuthenticateViaDatabase(ByVal username As String, ByVal password As String) As Boolean
        Try
            Dim connectionString As String = Nothing
            If ConfigurationManager.ConnectionStrings("DefaultConnection") IsNot Nothing Then
                connectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
            End If
            
            If String.IsNullOrEmpty(connectionString) Then
                Return False
            End If
            
            Using conn As New SqlConnection(connectionString)
                ' ⚠️ فحص مع تشفير كلمة المرور - يجب تشفيرها بنفس الطريقة المحفوظة
                ' هذا مثال باستخدام SHA256 - يجب تعديله حسب طريقة التشفير المستخدمة
                Dim hashedPassword As String = ComputeSHA256Hash(password)
                
                ' فحص المستخدم في جدول Users فقط
                Dim query As String = "SELECT UserID, Username, IsActive FROM Users WHERE Username = @username AND PasswordHash = @passwordHash AND IsActive = 1"
                
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@passwordHash", hashedPassword)
                    
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim dbUsername As String = reader("Username").ToString()
                            Dim isActive As Boolean = Convert.ToBoolean(reader("IsActive"))
                            
                            ' التحقق من مطابقة اسم المستخدم تماماً وأن الحساب نشط
                            Return String.Equals(dbUsername, username, StringComparison.Ordinal) AndAlso isActive
                        End If
                    End Using
                End Using
            End Using
            
            Return False
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Database Authentication error: " & ex.Message)
            Return False
        End Try
    End Function
    
    ' 🔒 دالة للتحقق من وجود المستخدم في جدول user_details باستخدام username
    Private Function ValidateUserInDetails(ByVal username As String) As Boolean
        Try
            Dim connectionString As String = Nothing
            If ConfigurationManager.ConnectionStrings("DefaultConnection") IsNot Nothing Then
                connectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
            End If
            
            If String.IsNullOrEmpty(connectionString) Then
                Return False
            End If
            
            Using conn As New SqlConnection(connectionString)
                ' البحث عن المستخدم في user_details باستخدام JOIN مع جدول Users
                Dim query As String = "SELECT COUNT(*) FROM user_details ud " &
                                    "INNER JOIN Users u ON ud.UserID = u.UserID " &
                                    "WHERE u.Username = @username AND u.IsActive = 1 AND ud.IsActive = 1"
                
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    
                    conn.Open()
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    
                    ' يجب أن يكون هناك سجل واحد في user_details
                    Return count = 1
                End Using
            End Using
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error validating user in user_details: " & ex.Message)
            Return False
        End Try
    End Function
    
    ' 🔒 دالة للتحقق من وجود المستخدم في جدول user_details باستخدام UserID
    Private Function CheckUserDetailsExists(ByVal userId As Integer, ByVal connection As SqlConnection) As Boolean
        Try
            ' فحص وجود المستخدم في جدول user_details مع شروط إضافية
            Dim detailsQuery As String = "SELECT COUNT(*) FROM user_details WHERE UserID = @userId AND IsActive = 1"
            
            Using detailsCmd As New SqlCommand(detailsQuery, connection)
                detailsCmd.Parameters.AddWithValue("@userId", userId)
                
                Dim count As Integer = Convert.ToInt32(detailsCmd.ExecuteScalar())
                
                ' يجب أن يكون هناك سجل واحد في user_details
                Return count = 1
            End Using
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error checking user_details: " & ex.Message)
            Return False
        End Try
    End Function
    
    ' دالة مساعدة لتشفير كلمة المرور - يجب تعديلها حسب طريقة التشفير المستخدمة في النظام
    Private Function ComputeSHA256Hash(ByVal input As String) As String
        Try
            Using sha256Hash As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()
                ' تحويل النص إلى bytes
                Dim data As Byte() = sha256Hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input))
                
                ' تحويل bytes إلى string hex
                Dim sBuilder As New StringBuilder()
                For i As Integer = 0 To data.Length - 1
                    sBuilder.Append(data(i).ToString("x2"))
                Next
                
                Return sBuilder.ToString()
            End Using
        Catch
            Return String.Empty
        End Try
    End Function
    
    Private Function IsLocalUrl(ByVal url As String) As Boolean
        If String.IsNullOrEmpty(url) Then
            Return False
        End If
        
        Return url.StartsWith("/") AndAlso Not url.StartsWith("//") AndAlso Not url.StartsWith("/\")
    End Function
    
    Private Sub ShowError(ByVal message As String)
        litError.Text = message
        pnlError.Visible = True
    End Sub
    
    Private Sub ClearForm()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Focus()
    End Sub
End Class
