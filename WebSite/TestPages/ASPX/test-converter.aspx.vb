Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Text

Partial Class test_converter
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            RunTests()
        End If
    End Sub

    Private Sub RunTests()
        Try
            ' اختبار التجميع
            TestCompilation()
            
            ' اختبار المحول
            TestConverter()
            
            ' اختبار بيانات SiteMap
            TestSiteMapData()
            
            ' إنشاء الإخراج الحديث
            GenerateModernOutput()
            
        Catch ex As Exception
            litCompilationTest.Text = "<div class='status-error'>" & _
                                    "<i class='fas fa-times-circle'></i> " & _
                                    "Critical Error: " & ex.Message & _
                                    "</div>"
        End Try
    End Sub

    Private Sub TestCompilation()
        Try
            litCompilationTest.Text = "<div class='status-success'>" & _
                                    "<i class='fas fa-check-circle'></i> " & _
                                    "VB.NET compilation successful! DynamicControlConverter class is accessible." & _
                                    "</div>"
        Catch ex As Exception
            litCompilationTest.Text = "<div class='status-error'>" & _
                                    "<i class='fas fa-times-circle'></i> " & _
                                    "Compilation Error: " & ex.Message & _
                                    "</div>"
        End Try
    End Sub

    Private Sub TestConverter()
        Try
            ' اختبار إنشاء كائن من المحول
            Dim testResult As String = "Testing DynamicControlConverter..."
            
            ' محاولة استدعاء الدالة
            Dim convertedHtml As String = DynamicControlConverter.ConvertTableOfContentsToModern(Me, "testContainer")
            
            If Not String.IsNullOrEmpty(convertedHtml) Then
                litConverterTest.Text = "<div class='status-success'>" & _
                                      "<i class='fas fa-check-circle'></i> " & _
                                      "Converter working successfully! Generated " & convertedHtml.Length & " characters of HTML." & _
                                      "</div>"
            Else
                litConverterTest.Text = "<div class='status-warning'>" & _
                                      "<i class='fas fa-exclamation-triangle'></i> " & _
                                      "Converter returned empty result." & _
                                      "</div>"
            End If
            
        Catch ex As Exception
            litConverterTest.Text = "<div class='status-error'>" & _
                                  "<i class='fas fa-times-circle'></i> " & _
                                  "Converter Error: " & ex.Message & _
                                  "</div>"
        End Try
    End Sub

    Private Sub TestSiteMapData()
        Try
            Dim resultText As New StringBuilder()
            
            ' اختبار وجود SiteMap
            If SiteMap.RootNode IsNot Nothing Then
                resultText.AppendLine("<div class='status-success'>")
                resultText.AppendLine("<i class='fas fa-check-circle'></i> SiteMap is available<br>")
                resultText.AppendLine("Root Node: " & SiteMap.RootNode.Title & "<br>")
                
                If SiteMap.RootNode.ChildNodes IsNot Nothing Then
                    resultText.AppendLine("Child Nodes: " & SiteMap.RootNode.ChildNodes.Count & "<br>")
                    
                    ' عرض أول 3 عقد فرعية
                    Dim count As Integer = 0
                    For Each node As SiteMapNode In SiteMap.RootNode.ChildNodes
                        If count < 3 Then
                            resultText.AppendLine("- " & node.Title & " (" & node.Url & ")<br>")
                            count += 1
                        Else
                            Exit For
                        End If
                    Next
                    
                    If SiteMap.RootNode.ChildNodes.Count > 3 Then
                        resultText.AppendLine("... and " & (SiteMap.RootNode.ChildNodes.Count - 3) & " more")
                    End If
                End If
                
                resultText.AppendLine("</div>")
            Else
                resultText.AppendLine("<div class='status-warning'>")
                resultText.AppendLine("<i class='fas fa-exclamation-triangle'></i> SiteMap.RootNode is null")
                resultText.AppendLine("</div>")
            End If
            
            litSiteMapTest.Text = resultText.ToString()
            
        Catch ex As Exception
            litSiteMapTest.Text = "<div class='status-error'>" & _
                                "<i class='fas fa-times-circle'></i> " & _
                                "SiteMap Error: " & ex.Message & _
                                "</div>"
        End Try
    End Sub

    Private Sub GenerateModernOutput()
        Try
            ' إنشاء الإخراج الحديث الفعلي
            Dim modernHtml As String = DynamicControlConverter.ConvertTableOfContentsToModern(Me, "actualOutput")
            
            If Not String.IsNullOrEmpty(modernHtml) Then
                litModernOutput.Text = modernHtml
            Else
                litModernOutput.Text = "<div class='status-warning'>" & _
                                     "<i class='fas fa-exclamation-triangle'></i> " & _
                                     "No modern output generated." & _
                                     "</div>"
            End If
            
        Catch ex As Exception
            litModernOutput.Text = "<div class='status-error'>" & _
                                 "<i class='fas fa-times-circle'></i> " & _
                                 "Failed to generate modern output: " & ex.Message & _
                                 "</div>"
        End Try
    End Sub

End Class
