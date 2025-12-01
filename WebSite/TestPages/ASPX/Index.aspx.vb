Imports System

Partial Class TestPages_ASPX_Index
    Inherits System.Web.UI.Page
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            ' تحديد عنوان الصفحة
            Page.Title = "Test Pages ASPX - فهرس صفحات الاختبار"
            
            ' إضافة Meta Tags
            AddMetaTags()
            
            ' تحميل بيانات الصفحات
            LoadPageData()
            
        Catch ex As Exception
            ' تسجيل الخطأ
            Response.Write("<!-- Error: " & ex.Message & " -->")
        End Try
    End Sub
    
    ''' <summary>
    ''' إضافة Meta Tags للصفحة
    ''' </summary>
    Private Sub AddMetaTags()
        Try
            ' إضافة meta description
            Dim metaDesc As New HtmlMeta()
            metaDesc.Name = "description"
            metaDesc.Content = "فهرس شامل لجميع صفحات اختبار ASPX في النظام"
            Page.Header.Controls.Add(metaDesc)
            
            ' إضافة meta keywords
            Dim metaKeywords As New HtmlMeta()
            metaKeywords.Name = "keywords"
            metaKeywords.Content = "ASPX, Test Pages, Code On Time, فهرس الصفحات"
            Page.Header.Controls.Add(metaKeywords)
            
        Catch ex As Exception
            ' تجاهل الأخطاء في Meta Tags
        End Try
    End Sub
    
    ''' <summary>
    ''' تحميل بيانات الصفحات
    ''' </summary>
    Private Sub LoadPageData()
        Try
            ' يمكن إضافة منطق تحميل البيانات هنا إذا لزم الأمر
            ' مثل قراءة قائمة الصفحات من قاعدة البيانات أو ملف
            
        Catch ex As Exception
            ' تسجيل الخطأ
            Response.Write("<!-- LoadPageData Error: " & ex.Message & " -->")
        End Try
    End Sub
    
End Class
