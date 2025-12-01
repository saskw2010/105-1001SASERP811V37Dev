Imports System.Data

Partial Class ModernTestPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadTestData()
            ShowTestMessages()
        End If
    End Sub

    Private Sub LoadTestData()
        ' إنشاء بيانات تجريبية للجدول
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Department", GetType(String))
        dt.Columns.Add("Position", GetType(String))
        dt.Columns.Add("Salary", GetType(Decimal))
        dt.Columns.Add("JoinDate", GetType(DateTime))

        ' إضافة بيانات تجريبية
        dt.Rows.Add(1, "أحمد محمد علي", "المبيعات", "مدير المبيعات", 8500.0, New DateTime(2020, 3, 15))
        dt.Rows.Add(2, "فاطمة أحمد", "المحاسبة", "محاسب أول", 6500.0, New DateTime(2019, 7, 22))
        dt.Rows.Add(3, "محمد عبدالله", "تقنية المعلومات", "مطور نظم", 9000.0, New DateTime(2021, 1, 10))
        dt.Rows.Add(4, "نور الهدى", "الموارد البشرية", "أخصائي موارد بشرية", 5500.0, New DateTime(2020, 11, 5))
        dt.Rows.Add(5, "عبدالرحمن سعد", "التسويق", "منسق تسويق", 4800.0, New DateTime(2021, 6, 18))
        dt.Rows.Add(6, "مريم حسن", "المبيعات", "مندوب مبيعات", 4200.0, New DateTime(2022, 2, 12))
        dt.Rows.Add(7, "خالد أحمد", "تقنية المعلومات", "مدير تقنية", 12000.0, New DateTime(2018, 9, 30))
        dt.Rows.Add(8, "أسماء محمد", "المحاسبة", "مدير مالي", 11000.0, New DateTime(2017, 12, 8))

        gvTestData.DataSource = dt
        gvTestData.DataBind()
    End Sub

    Private Sub ShowTestMessages()
        ' إنشاء رسائل تجريبية
        Dim messagesHtml As String = ""
        
        ' رسالة نجح
        messagesHtml += "<div class='alert alert-success' style='margin: 10px 0; padding: 15px; border-radius: 8px; background: var(--success-color-light); color: var(--success-color-dark); border-left: 4px solid var(--success-color);'>"
        messagesHtml += "<i class='fas fa-check-circle'></i> تم حفظ البيانات بنجاح!"
        messagesHtml += "</div>"
        
        ' رسالة تحذير
        messagesHtml += "<div class='alert alert-warning' style='margin: 10px 0; padding: 15px; border-radius: 8px; background: var(--warning-color-light); color: var(--warning-color-dark); border-left: 4px solid var(--warning-color);'>"
        messagesHtml += "<i class='fas fa-exclamation-triangle'></i> تحذير: تأكد من صحة البيانات المدخلة."
        messagesHtml += "</div>"
        
        ' رسالة معلومات
        messagesHtml += "<div class='alert alert-info' style='margin: 10px 0; padding: 15px; border-radius: 8px; background: var(--info-color-light); color: var(--info-color-dark); border-left: 4px solid var(--info-color);'>"
        messagesHtml += "<i class='fas fa-info-circle'></i> معلومة: يمكنك استخدام البحث المتقدم للوصول السريع للبيانات."
        messagesHtml += "</div>"
        
        ' رسالة خطأ
        messagesHtml += "<div class='alert alert-danger' style='margin: 10px 0; padding: 15px; border-radius: 8px; background: var(--danger-color-light); color: var(--danger-color-dark); border-left: 4px solid var(--danger-color);'>"
        messagesHtml += "<i class='fas fa-times-circle'></i> خطأ: لا يمكن حذف هذا السجل لأنه مرتبط ببيانات أخرى."
        messagesHtml += "</div>"
        
        pnlMessages.Controls.Add(New LiteralControl(messagesHtml))
    End Sub

    ' معالجات الأحداث للأزرار
    Protected Sub btnPrimary_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ShowMessage("تم النقر على الزر الأساسي!", "success")
    End Sub

    Protected Sub btnSecondary_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ShowMessage("تم النقر على الزر الثانوي!", "info")
    End Sub

    Protected Sub btnSuccess_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ShowMessage("عملية ناجحة تماماً!", "success")
    End Sub

    Protected Sub btnDanger_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ShowMessage("تحذير: هذا إجراء خطير!", "danger")
    End Sub

    Protected Sub btnWarning_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ShowMessage("تنبيه: تأكد من العملية قبل المتابعة!", "warning")
    End Sub

    Protected Sub lnkInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        ShowMessage("معلومات إضافية حول النظام.", "info")
    End Sub

    Private Sub ShowMessage(message As String, type As String)
        Dim script As String = String.Format("showNotification('{0}', '{1}');", message, type)
        ClientScript.RegisterStartupScript(Me.GetType(), "notification", script, True)
    End Sub

    ' معالج أحداث الجدول
    Protected Sub gvTestData_RowCommand(ByVal sender As Object, ByVal e As GridViewCommandEventArgs) Handles gvTestData.RowCommand
        If e.CommandName = "Edit" Then
            ShowMessage("فتح نموذج التعديل...", "info")
        ElseIf e.CommandName = "Delete" Then
            ShowMessage("هل أنت متأكد من حذف هذا السجل؟", "warning")
        End If
    End Sub
End Class
