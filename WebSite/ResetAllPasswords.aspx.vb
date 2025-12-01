Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.Security
Imports System.Text

Namespace SKY365
    Partial Public Class ResetAllPasswords
        Inherits Global.System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            ' فحص Session للتأكد من تسجيل الدخول
            If Session("AdminAuthenticated") IsNot Nothing AndAlso CBool(Session("AdminAuthenticated")) = True Then
                ' المستخدم مسجل دخول
                pnlLogin.Visible = False
                pnlReset.Visible = True
            Else
                ' المستخدم غير مسجل دخول
                pnlLogin.Visible = True
                pnlReset.Visible = False
            End If
        End Sub
        
        Protected Sub btnAdminLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim username As String = txtAdminUser.Text.Trim()
            Dim password As String = txtAdminPass.Text.Trim()
            
            ' التحقق من اسم المستخدم
            If username.ToLower() <> "administrator" Then
                lblLoginError.Text = "❌ اسم المستخدم غير صحيح"
                lblLoginError.Visible = True
                Return
            End If
            
            ' التحقق من كلمة المرور (YYYY-MM-DD@123)
            Dim today As String = DateTime.Now.ToString("yyyy-MM-dd")
            Dim expectedPassword As String = today & "@123"
            
            If password = expectedPassword Then
                ' تسجيل دخول ناجح
                Session("AdminAuthenticated") = True
                pnlLogin.Visible = False
                pnlReset.Visible = True
                lblLoginError.Visible = False
            Else
                ' كلمة مرور خاطئة
                lblLoginError.Text = "❌ كلمة المرور غير صحيحة. استخدم: " & expectedPassword
                lblLoginError.Visible = True
            End If
        End Sub

        Protected Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim results As New StringBuilder()
            Dim successCount As Integer = 0
            Dim failCount As Integer = 0
            Dim newPassword As String = "NewPass@123"  ' كلمة المرور الموحدة الجديدة
            
            Try
                results.AppendLine("=== بدء إعادة تعيين كلمات المرور ===")
                results.AppendLine("كلمة المرور الجديدة الموحدة: " & newPassword)
                results.AppendLine("")
                
                Dim users As MembershipUserCollection = Membership.GetAllUsers()
                results.AppendLine("إجمالي المستخدمين: " & users.Count.ToString())
                results.AppendLine("")
                
                ' استخدام Admin Provider الذي لا يحتاج passwordAnswer
                Dim adminProvider As MembershipProvider = Membership.Providers("dbSqlMemberShipProviderAdmin")
                
                If adminProvider Is Nothing Then
                    results.AppendLine("❌ خطأ: dbSqlMemberShipProviderAdmin غير موجود في web.config")
                    litResults.Text = results.ToString()
                    pnlResults.Visible = True
                    Return
                End If
                
                For Each user As MembershipUser In users
                    Try
                        ' الحصول على المستخدم من Admin Provider
                        Dim adminUser As MembershipUser = adminProvider.GetUser(user.UserName, False)
                        
                        If adminUser IsNot Nothing Then
                            ' فك القفل إن كان مقفولاً
                            If adminUser.IsLockedOut Then
                                If adminUser.UnlockUser() Then
                                    results.AppendLine("🔓 " & user.UserName & " → تم فك القفل")
                                Else
                                    results.AppendLine("⚠️ " & user.UserName & " → فشل فك القفل")
                                End If
                            End If

                            ' التأكد من الموافقة على الحساب
                            If Not adminUser.IsApproved Then
                                adminUser.IsApproved = True
                                Membership.UpdateUser(adminUser)
                                results.AppendLine("✅ " & user.UserName & " → تم تعيين IsApproved=True")
                            End If

                            ' إعادة تعيين كلمة المرور بدون passwordAnswer
                            Dim tempPassword As String = adminUser.ResetPassword()
                            
                            ' تغيير كلمة المرور إلى الكلمة الموحدة الجديدة
                            Dim changeSuccess As Boolean = adminUser.ChangePassword(tempPassword, newPassword)
                            
                            If changeSuccess Then
                                results.AppendLine("✅ " & user.UserName & " → تم التغيير بنجاح")
                                successCount += 1
                            Else
                                results.AppendLine("⚠️ " & user.UserName & " → فشل تغيير كلمة المرور")
                                failCount += 1
                            End If
                        Else
                            results.AppendLine("⚠️ " & user.UserName & " → لم يتم العثور على المستخدم")
                            failCount += 1
                        End If
                        
                    Catch ex As Exception
                        results.AppendLine("❌ " & user.UserName & " → خطأ: " & ex.Message)
                        failCount += 1
                    End Try
                Next
                
                results.AppendLine("")
                results.AppendLine("=== النتائج ===")
                results.AppendLine("نجح: " & successCount.ToString())
                results.AppendLine("فشل: " & failCount.ToString())
                results.AppendLine("")
                results.AppendLine("🔑 كلمة المرور الجديدة لجميع المستخدمين: " & newPassword)
                results.AppendLine("")
                results.AppendLine("⚠️ مهم: أخبر جميع المستخدمين بكلمة المرور الجديدة!")
                
            Catch ex As Exception
                results.AppendLine("")
                results.AppendLine("❌ خطأ عام: " & ex.Message)
            End Try
            
            ' عرض النتائج
            litResults.Text = results.ToString()
            pnlResults.Visible = True
        End Sub

    End Class
End Namespace
