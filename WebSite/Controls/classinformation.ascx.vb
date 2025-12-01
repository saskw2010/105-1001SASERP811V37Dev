Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data

Partial Public Class Controls_classinformation
    Inherits Global.System.Web.UI.UserControl
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadClassInformationData()
        End If
    End Sub
    
    Private Sub LoadClassInformationData()
        Try
            ' Load filter data
            LoadBranches()
            LoadStages()
            LoadGrades()
            LoadClasses()
            LoadStudents()
        Catch ex As Exception
            ' Fallback to sample data
            LoadSampleData()
        End Try
    End Sub
    
    Private Sub LoadBranches()
        Try
            rptBranches.DataSource = odsBranches
            rptBranches.DataBind()
        Catch ex As Exception
            LoadSampleBranches()
        End Try
    End Sub
    
    Private Sub LoadStages()
        Try
            rptStages.DataSource = odsStages
            rptStages.DataBind()
        Catch ex As Exception
            LoadSampleStages()
        End Try
    End Sub
    
    Private Sub LoadGrades()
        Try
            rptGrades.DataSource = odsGrades
            rptGrades.DataBind()
        Catch ex As Exception
            LoadSampleGrades()
        End Try
    End Sub
    
    Private Sub LoadClasses()
        Try
            rptClasses.DataSource = odsClasses
            rptClasses.DataBind()
        Catch ex As Exception
            LoadSampleClasses()
        End Try
    End Sub
    
    Private Sub LoadStudents()
        Try
            rptStudents.DataSource = odsStudents
            rptStudents.DataBind()
        Catch ex As Exception
            LoadSampleStudents()
        End Try
    End Sub
    
    ' Sample data methods for fallback
    Private Sub LoadSampleBranches()
        Dim branches As New List(Of Object)()
        branches.Add(New With {.branch = "1", .Desc1 = "الفرع الرئيسي"})
        branches.Add(New With {.branch = "2", .Desc1 = "فرع المدينة"})
        branches.Add(New With {.branch = "3", .Desc1 = "فرع الشمال"})
        branches.Add(New With {.branch = "4", .Desc1 = "فرع الجنوب"})
        branches.Add(New With {.branch = "5", .Desc1 = "فرع الشرق"})
        
        rptBranches.DataSource = branches
        rptBranches.DataBind()
    End Sub
    
    Private Sub LoadSampleStages()
        Dim stages As New List(Of Object)()
        stages.Add(New With {.Code = "1", .ShortDesc1 = "ابتدائي"})
        stages.Add(New With {.Code = "2", .ShortDesc1 = "متوسط"})
        stages.Add(New With {.Code = "3", .ShortDesc1 = "ثانوي"})
        
        rptStages.DataSource = stages
        rptStages.DataBind()
    End Sub
    
    Private Sub LoadSampleGrades()
        Dim grades As New List(Of Object)()
        grades.Add(New With {.GradeCode = "1", .ShortDesc1 = "الأول"})
        grades.Add(New With {.GradeCode = "2", .ShortDesc1 = "الثاني"})
        grades.Add(New With {.GradeCode = "3", .ShortDesc1 = "الثالث"})
        grades.Add(New With {.GradeCode = "4", .ShortDesc1 = "الرابع"})
        grades.Add(New With {.GradeCode = "5", .ShortDesc1 = "الخامس"})
        grades.Add(New With {.GradeCode = "6", .ShortDesc1 = "السادس"})
        
        rptGrades.DataSource = grades
        rptGrades.DataBind()
    End Sub
    
    Private Sub LoadSampleClasses()
        Dim classes As New List(Of Object)()
        classes.Add(New With {.classcode = "A", .ClassDesc1 = "فصل أ"})
        classes.Add(New With {.classcode = "B", .ClassDesc1 = "فصل ب"})
        classes.Add(New With {.classcode = "C", .ClassDesc1 = "فصل ج"})
        classes.Add(New With {.classcode = "D", .ClassDesc1 = "فصل د"})
        
        rptClasses.DataSource = classes
        rptClasses.DataBind()
    End Sub
    
    Private Sub LoadSampleStudents()
        Dim students As New List(Of Object)()
        students.Add(New With {
            .StudentCode = "ST001",
            .FirstName1 = "أحمد محمد علي",
            .Class = "أ",
            .Stage = "ابتدائي",
            .Branch = "الفرع الرئيسي"
        })
        students.Add(New With {
            .StudentCode = "ST002",
            .FirstName1 = "فاطمة أحمد حسن",
            .Class = "ب",
            .Stage = "ابتدائي",
            .Branch = "الفرع الرئيسي"
        })
        students.Add(New With {
            .StudentCode = "ST003",
            .FirstName1 = "محمد سالم خالد",
            .Class = "أ",
            .Stage = "متوسط",
            .Branch = "فرع المدينة"
        })
        students.Add(New With {
            .StudentCode = "ST004",
            .FirstName1 = "نورا عبدالله محمد",
            .Class = "ج",
            .Stage = "ثانوي",
            .Branch = "فرع الشمال"
        })
        students.Add(New With {
            .StudentCode = "ST005",
            .FirstName1 = "عبدالرحمن عمر سعد",
            .Class = "ب",
            .Stage = "ثانوي",
            .Branch = "فرع الجنوب"
        })
        students.Add(New With {
            .StudentCode = "ST006",
            .FirstName1 = "مريم حسام الدين",
            .Class = "د",
            .Stage = "متوسط",
            .Branch = "فرع الشرق"
        })
        
        rptStudents.DataSource = students
        rptStudents.DataBind()
    End Sub
    
    Private Sub LoadSampleData()
        LoadSampleBranches()
        LoadSampleStages()
        LoadSampleGrades()
        LoadSampleClasses()
        LoadSampleStudents()
    End Sub
    
    ' Helper methods for UI
    Protected Function GetStudentImagePath(studentCode As Object) As String
        If studentCode Is Nothing Then Return "/assets/img/default-avatar.jpg"
        
        Dim code As String = studentCode.ToString()
        Dim imagePath As String = String.Format("~/Images/student/{0}.jpg", code)
        
        ' Check if file exists, otherwise return default
        Try
            Dim physicalPath As String = Server.MapPath(imagePath)
            If System.IO.File.Exists(physicalPath) Then
                Return ResolveUrl(imagePath)
            End If
        Catch
            ' File doesn't exist or path error
        End Try
        
        Return "/assets/img/default-avatar.jpg"
    End Function
    
    Protected Function GetStudentDetails(dataItem As Object) As String
        If dataItem Is Nothing Then Return ""
        
        Try
            Dim student = dataItem
            Dim details As String = ""
            
            ' Use reflection to get properties
            Dim studentType = student.GetType()
            
            If studentType.GetProperty("Class") IsNot Nothing Then
                Dim classValue = studentType.GetProperty("Class").GetValue(student, Nothing)
                If classValue IsNot Nothing Then
                    details += String.Format("الفصل: {0}<br/>", classValue.ToString())
                End If
            End If
            
            If studentType.GetProperty("Stage") IsNot Nothing Then
                Dim stageValue = studentType.GetProperty("Stage").GetValue(student, Nothing)
                If stageValue IsNot Nothing Then
                    details += String.Format("المرحلة: {0}<br/>", stageValue.ToString())
                End If
            End If
            
            If studentType.GetProperty("Branch") IsNot Nothing Then
                Dim branchValue = studentType.GetProperty("Branch").GetValue(student, Nothing)
                If branchValue IsNot Nothing Then
                    details += String.Format("الفرع: {0}", branchValue.ToString())
                End If
            End If
            
            Return details
        Catch ex As Exception
            Return "معلومات الطالب"
        End Try
    End Function
    
    ' Content method for backward compatibility
    Protected Function ContentToShow(container As Object) As String
        Try
            If container IsNot Nothing Then
                Return GetStudentDetails(container)
            End If
        Catch ex As Exception
            ' Handle any errors gracefully
        End Try
        Return ""
    End Function
    
    ' Image path helper for backward compatibility
    Protected Function getpath(basePath As String) As String
        Return ResolveUrl(basePath)
    End Function

End Class
