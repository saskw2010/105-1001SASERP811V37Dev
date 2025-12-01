Imports System
Imports System.Web.UI

Partial Class UserInfoDemo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Console Logging - بداية تحميل الصفحة
        System.Diagnostics.Debug.WriteLine("🚀 [UserInfoDemo] Page_Load started - تم بدء تحميل صفحة معلومات المستخدم")
        
        ' Set page properties for RTL demo
        If Not IsPostBack Then
            System.Diagnostics.Debug.WriteLine("📋 [UserInfoDemo] First page load - أول تحميل للصفحة")
            
            ' Check if we should use RTL based on query parameter
            Dim lang As String = Request.QueryString("lang")
            System.Diagnostics.Debug.WriteLine("🌍 [UserInfoDemo] Language parameter: " & If(String.IsNullOrEmpty(lang), "Not specified", lang))
            
            If Not String.IsNullOrEmpty(lang) Then
                If lang.ToLower() = "ar" Then
                    ' Set Arabic RTL
                    Page.Culture = "ar-SA"
                    Page.UICulture = "ar-SA"
                    Response.Write("<script>document.documentElement.lang = 'ar'; document.documentElement.dir = 'rtl';</script>")
                    System.Diagnostics.Debug.WriteLine("🌐 [UserInfoDemo] Arabic RTL mode activated - تم تفعيل الوضع العربي")
                Else
                    ' Set English LTR
                    Page.Culture = "en-US"
                    Page.UICulture = "en-US"
                    Response.Write("<script>document.documentElement.lang = 'en'; document.documentElement.dir = 'ltr';</script>")
                    System.Diagnostics.Debug.WriteLine("🌐 [UserInfoDemo] English LTR mode activated - تم تفعيل الوضع الإنجليزي")
                End If
            Else
                System.Diagnostics.Debug.WriteLine("🌐 [UserInfoDemo] Using default language settings")
            End If
        End If
        
        ' Add user info to page for JavaScript access
        System.Diagnostics.Debug.WriteLine("📊 [UserInfoDemo] Registering user info for JavaScript")
        RegisterUserInfo()
        
        System.Diagnostics.Debug.WriteLine("✅ [UserInfoDemo] Page_Load completed successfully")
    End Sub

    Private Sub RegisterUserInfo()
        System.Diagnostics.Debug.WriteLine("📝 [UserInfoDemo] Starting user info registration")
        
        ' Get user information
        Dim userName As String = GetCurrentUserName()
        Dim userEmail As String = GetCurrentUserEmail()
        Dim userRole As String = GetCurrentUserRole()
        Dim isRTL As Boolean = IsRTLMode()
        
        System.Diagnostics.Debug.WriteLine("👤 [UserInfoDemo] User Name: " & userName)
        System.Diagnostics.Debug.WriteLine("📧 [UserInfoDemo] User Email: " & userEmail)
        System.Diagnostics.Debug.WriteLine("🔐 [UserInfoDemo] User Role: " & userRole)
        System.Diagnostics.Debug.WriteLine("🌍 [UserInfoDemo] RTL Mode: " & isRTL.ToString())
        
        ' Create user info object for JavaScript
        Dim userInfo As String = "{"
        userInfo &= """name"": """ & userName & ""","
        userInfo &= """email"": """ & userEmail & ""","
        userInfo &= """role"": """ & userRole & ""","
        userInfo &= """loginTime"": """ & DateTime.Now.ToString("HH:mm:ss") & ""","
        userInfo &= """sessionId"": """ & Session.SessionID & ""","
        userInfo &= """isRTL"": " & If(isRTL, "true", "false")
        userInfo &= "}"
        
        System.Diagnostics.Debug.WriteLine("📋 [UserInfoDemo] Generated user info JSON: " & userInfo)
        
        ' Register the user info for JavaScript access
        Dim script As String = "window.__userInfo = " & userInfo & "; console.log('🚀 User info loaded:', window.__userInfo);"
        ClientScript.RegisterStartupScript(Me.GetType(), "UserInfo", script, True)
        
        System.Diagnostics.Debug.WriteLine("✅ [UserInfoDemo] User info registration completed")
    End Sub

    Private Function GetCurrentUserName() As String
        System.Diagnostics.Debug.WriteLine("👤 [UserInfoDemo] Getting current user name")
        
        If User.Identity.IsAuthenticated Then
            System.Diagnostics.Debug.WriteLine("✅ [UserInfoDemo] User is authenticated: " & User.Identity.Name)
            Return User.Identity.Name
        Else
            Dim defaultName As String = If(IsRTLMode(), "مستخدم تجريبي", "Demo User")
            System.Diagnostics.Debug.WriteLine("⚠️ [UserInfoDemo] User not authenticated, using default: " & defaultName)
            Return defaultName
        End If
    End Function

    Private Function GetCurrentUserEmail() As String
        System.Diagnostics.Debug.WriteLine("📧 [UserInfoDemo] Getting current user email")
        
        If User.Identity.IsAuthenticated Then
            ' Try to get email from membership
            Try
                Dim user = Membership.GetUser()
                If user IsNot Nothing Then
                    System.Diagnostics.Debug.WriteLine("✅ [UserInfoDemo] Email retrieved from membership: " & user.Email)
                    Return user.Email
                Else
                    System.Diagnostics.Debug.WriteLine("⚠️ [UserInfoDemo] Membership.GetUser() returned null")
                End If
            Catch ex As Exception
                ' Fallback if membership not available
                System.Diagnostics.Debug.WriteLine("🔧 [UserInfoDemo] Membership email retrieval failed: " & ex.Message)
            End Try
        Else
            System.Diagnostics.Debug.WriteLine("⚠️ [UserInfoDemo] User not authenticated for email retrieval")
        End If
        
        System.Diagnostics.Debug.WriteLine("🔄 [UserInfoDemo] Using default email: demo@saserp.com")
        Return "demo@saserp.com"
    End Function

    Private Function GetCurrentUserRole() As String
        If User.Identity.IsAuthenticated Then
            ' Get user roles
            Try
                Dim userRoles As String() = Roles.GetRolesForUser()
                If userRoles IsNot Nothing AndAlso userRoles.Length > 0 Then
                    Return userRoles(0)
                End If
            Catch ex As Exception
                ' Fallback if roles not available
                System.Diagnostics.Debug.WriteLine("🔧 [UserInfoDemo] Role retrieval failed: " & ex.Message)
            End Try
        End If
        Return If(IsRTLMode(), "مدير النظام", "System Administrator")
    End Function

    Private Function IsRTLMode() As Boolean
        ' Check if we're in RTL mode
        Return Page.Culture.StartsWith("ar") OrElse 
               Request.QueryString("lang") = "ar"
    End Function
End Class
