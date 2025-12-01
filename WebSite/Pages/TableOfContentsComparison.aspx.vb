Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Class Pages_TableOfContentsComparison
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Try
                ' تحديد عنوان الصفحة
                Page.Title = "TableOfContents Controls Comparison"
                
                ' إضافة meta tags للصفحة
                Dim metaDescription As New HtmlMeta()
                metaDescription.Name = "description"
                metaDescription.Content = "Compare all TableOfContents control implementations in SASERP system"
                Page.Header.Controls.Add(metaDescription)
                
                Dim metaKeywords As New HtmlMeta()
                metaKeywords.Name = "keywords"
                metaKeywords.Content = "TableOfContents, comparison, controls, SASERP, ASP.NET"
                Page.Header.Controls.Add(metaKeywords)
                
                ' إضافة CSS إضافي إذا لزم الأمر
                LoadAdditionalStyles()
                
                ' تسجيل JavaScript للصفحة
                RegisterPageScripts()
                
            Catch ex As Exception
                ' تسجيل الخطأ وعرض رسالة ودية
                Response.Write("<!-- Error loading comparison page: " & ex.Message & " -->")
            End Try
        End If
    End Sub

    Private Sub LoadAdditionalStyles()
        Try
            ' إضافة Font Awesome إذا لم يكن محمل
            Dim fontAwesome As New HtmlLink()
            fontAwesome.Href = "https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css"
            fontAwesome.Attributes("rel") = "stylesheet"
            fontAwesome.Attributes("integrity") = "sha512-iecdLmaskl7CVkqkXNQ/ZH/XLlvWZOJyj7Yy7tcenmpD1ypASozpmT/E0iPtmFIB46ZmdtAc9eNBvH0H/ZpiBw=="
            fontAwesome.Attributes("crossorigin") = "anonymous"
            Page.Header.Controls.Add(fontAwesome)
            
            ' إضافة Google Fonts
            Dim googleFonts As New HtmlLink()
            googleFonts.Href = "https://fonts.googleapis.com/css2?family=Cairo:wght@300;400;500;600;700&display=swap"
            googleFonts.Attributes("rel") = "stylesheet"
            Page.Header.Controls.Add(googleFonts)
            
        Catch ex As Exception
            ' تجاهل أخطاء تحميل الخطوط الخارجية
        End Try
    End Sub

    Private Sub RegisterPageScripts()
        Try
            ' تسجيل JavaScript للتفاعل مع الصفحة
            Dim script As String = "" & _
                "document.addEventListener('DOMContentLoaded', function() {" & vbCrLf & _
                "    // إضافة تأثيرات التمرير السلس" & vbCrLf & _
                "    const tabs = document.querySelectorAll('.tab-btn');" & vbCrLf & _
                "    tabs.forEach(tab => {" & vbCrLf & _
                "        tab.addEventListener('click', function() {" & vbCrLf & _
                "            // إضافة تأثير نقر" & vbCrLf & _
                "            this.style.transform = 'scale(0.95)';" & vbCrLf & _
                "            setTimeout(() => {" & vbCrLf & _
                "                this.style.transform = '';" & vbCrLf & _
                "            }, 150);" & vbCrLf & _
                "        });" & vbCrLf & _
                "    });" & vbCrLf & _
                "    " & vbCrLf & _
                "    // تتبع الإحصائيات" & vbCrLf & _
                "    console.log('TableOfContents Comparison page loaded successfully');" & vbCrLf & _
                "    console.log('Available controls: Original, Ajar, Modern, Modern Ajar');" & vbCrLf & _
                "});" & vbCrLf & _
                "" & vbCrLf & _
                "// دالة لتسجيل استخدام التبويبات" & vbCrLf & _
                "function logTabUsage(tabName) {" & vbCrLf & _
                "    console.log('User switched to tab: ' + tabName);" & vbCrLf & _
                "    // يمكن إضافة تتبع إحصائي هنا" & vbCrLf & _
                "}"
            
            ScriptManager.RegisterStartupScript(Me, GetType(Page), "ComparisonPageScript", script, True)
            
        Catch ex As Exception
            ' تجاهل أخطاء JavaScript
        End Try
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
        Try
            ' التأكد من تحميل جميع الأدوات بشكل صحيح
            ValidateControlsLoaded()
            
        Catch ex As Exception
            Response.Write("<!-- Error in PreRender: " & ex.Message & " -->")
        End Try
    End Sub

    Private Sub ValidateControlsLoaded()
        Try
            ' التحقق من وجود الأدوات
            Dim controlsStatus As String = "<!-- Controls Status:" & vbCrLf
            
            ' Original TOC
            If originalTOC IsNot Nothing Then
                controlsStatus &= "Original TableOfContents: Loaded" & vbCrLf
            Else
                controlsStatus &= "Original TableOfContents: Error" & vbCrLf
            End If
            
            ' Ajar TOC
            If ajarTOC IsNot Nothing Then
                controlsStatus &= "TableOfContentsajar: Loaded" & vbCrLf
            Else
                controlsStatus &= "TableOfContentsajar: Error" & vbCrLf
            End If
            
            ' Modern TOC
            If modernTOC IsNot Nothing Then
                controlsStatus &= "Modern TableOfContents: Loaded" & vbCrLf
            Else
                controlsStatus &= "Modern TableOfContents: Error" & vbCrLf
            End If
            
            ' Modern Ajar TOC
            If modernAjarTOC IsNot Nothing Then
                controlsStatus &= "Modern TableOfContentsajar: Loaded" & vbCrLf
            Else
                controlsStatus &= "Modern TableOfContentsajar: Error" & vbCrLf
            End If
            
            controlsStatus &= "-->"
            Response.Write(controlsStatus)
            
        Catch ex As Exception
            Response.Write("<!-- Error validating controls: " & ex.Message & " -->")
        End Try
    End Sub

    ' معالج الأحداث للتحكم في عرض المحتوى
    Protected Sub ShowControl(ByVal controlType As String)
        Try
            ' يمكن استخدام هذه الدالة للتحكم في عرض الأدوات برمجياً
            Select Case controlType.ToLower()
                Case "original"
                    ' عرض الأداة الأصلية
                Case "ajar"
                    ' عرض أداة ajar
                Case "modern"
                    ' عرض الأداة الحديثة
                Case "modern-ajar"
                    ' عرض الأداة الحديثة المطورة
            End Select
            
        Catch ex As Exception
            ' معالجة الأخطاء
        End Try
    End Sub

End Class
