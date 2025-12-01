Imports System.Data

Partial Class ModernTest
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadSampleData()
        End If
    End Sub

    Private Sub LoadSampleData()
        ' إنشاء بيانات تجريبية للجدول
        Dim dt As New DataTable()
        dt.Columns.Add("ID", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("Department", GetType(String))
        dt.Columns.Add("Salary", GetType(Decimal))

        ' إضافة بيانات تجريبية
        dt.Rows.Add(1, "أحمد محمد", "المبيعات", 5000)
        dt.Rows.Add(2, "فاطمة علي", "المحاسبة", 6000)
        dt.Rows.Add(3, "محمد أحمد", "تقنية المعلومات", 7500)
        dt.Rows.Add(4, "نور الهدى", "الموارد البشرية", 5500)
        dt.Rows.Add(5, "عبدالله سعد", "المبيعات", 4800)

        gvSampleData.DataSource = dt
        gvSampleData.DataBind()
    End Sub

    Protected Sub btnPrimary_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrimary.Click
        ' مثال على معالج الحدث
        ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('تم النقر على الزر الأساسي!');", True)
    End Sub

    Protected Sub btnSecondary_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSecondary.Click
        ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('تم النقر على الزر الثانوي!');", True)
    End Sub

    Protected Sub btnSuccess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSuccess.Click
        ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('نجحت العملية!');", True)
    End Sub

    Protected Sub btnDanger_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDanger.Click
        ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('تحذير: عملية خطيرة!');", True)
    End Sub

    Protected Sub btnWarning_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWarning.Click
        ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('تحذير عام!');", True)
    End Sub
End Class
