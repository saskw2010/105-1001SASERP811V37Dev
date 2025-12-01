Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports eZee.Data
Imports eZee.Web

Partial Public Class Controls_Recivedvoucher_gridnew
    Inherits Global.System.Web.UI.UserControl
    
   Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'If Not IsPostBack Then
         '   StudentCodeText.Text = Session("StudentCode")
         '   StudentCodeText1.Text = Session("StudentCode1")
         '   StudentCodeText2.Text = Session("StudentCode2")
       ' End If
    End Sub

    'Protected Sub SearchButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchButton.Click
    ' Dim filter As List(Of FieldFilter) = New List(Of FieldFilter)
    ' If String.IsNullOrEmpty(StudentCodeText.Text) Then
    '     filter.Add(New FieldFilter("StudentCode", RowFilterOperation.None))
    'Else
    '     filter.Add(New FieldFilter("StudentCode", RowFilterOperation.Like, StudentCodeText.Text))
    ' End If
    'If String.IsNullOrEmpty(StudentCodeText1.Text) Then
    '    filter.Add(New FieldFilter("SupplierCompanyName", RowFilterOperation.None))
    ' Else
    '    filter.Add(New FieldFilter("SupplierCompanyName", RowFilterOperation.Like, StudentCodeText1.Text))
    ' End If
    'If String.IsNullOrEmpty(StudentCodeText2.Text) Then
    '    filter.Add(New FieldFilter("CategoryCategoryName", RowFilterOperation.None))
    ' Else
    '    filter.Add(New FieldFilter("CategoryCategoryName", RowFilterOperation.Like, StudentCodeText2.Text))
    ' End If
    ' ProductListExtender.AssignFilter(filter)
    ' StudentCode.Focus()
    '  Session("StudentCode") = StudentCodeText.Text
    'StudentCode.Text=StudentCodeText.Text
    ' Session("SupplierCompanyName") = StudentCodeText1.Text
    ' Session("CategoryCategoryName") = StudentCodeText2.Text
    'End Sub
End Class