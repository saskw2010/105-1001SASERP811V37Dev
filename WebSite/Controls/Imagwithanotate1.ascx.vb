Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Timers
Imports System.IO
Imports Telerik.Web.UI
Imports System.Data
Imports eZee.Data

Partial Public Class Controls_Imagwithanotate1
    Inherits Global.System.Web.UI.UserControl
    Protected Sub DropDownList1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Timer1.Interval = Integer.Parse(DropDownList1.SelectedValue)
        lblInterval.Text = Timer1.Interval.ToString()
    End Sub


    'Protected Sub RadGrid1_NeedDataSource(ByVal source As Object, ByVal e As Telerik.Web.UI.GridNeedDataSourceEventArgs) Handles RadGrid1.NeedDataSource
    '    Dim table As New DataTable()
    '    table.Columns.Add("Index", GetType(String))
    '    table.Columns.Add("Value", GetType(Double))
    '    table.Columns.Add("Change", GetType(Double))

    '    Dim r As New Random()

    '    table.Rows.Add(New Object() {"Composite", r.[Next](7000, 8000), r.[Next](-50, 500) / 100})
    '    table.Rows.Add(New Object() {"Energy", r.[Next](8000, 9000), r.[Next](-50, 50) / 100})
    '    table.Rows.Add(New Object() {"Financial", r.[Next](7000, 8000), r.[Next](-50, 50) / 100})
    '    table.Rows.Add(New Object() {"Health care", r.[Next](5000, 6000), r.[Next](-50, 50) / 100})

    '    RadGrid1.DataSource = table

    '    System.Threading.Thread.Sleep(500)
    'End Sub

    'Protected Sub RadGrid1_ItemDataBound(ByVal sender As Object, ByVal e As GridItemEventArgs) Handles RadGrid1.ItemDataBound
    '    If TypeOf e.Item Is GridDataItem Then
    '        Dim item As GridDataItem = TryCast(e.Item, GridDataItem)
    '        Dim img As System.Web.UI.WebControls.Image = DirectCast(item.FindControl("Image1"), System.Web.UI.WebControls.Image)

    '        Dim val As Double = DirectCast(item.GetDataKeyValue("Change"), Double)
    '        If val > 0 Then
    '            img.ImageUrl = "1.gif"
    '            img.AlternateText = "increase"
    '        Else
    '            img.ImageUrl = "2.gif"
    '            img.AlternateText = "decrease"
    '        End If
    '    End If
    'End Sub


    Protected Sub Controls_Imagwithanotate1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Timer1.Interval = 3000
        Timer1.Enabled = True
        If String.IsNullOrEmpty(TextBox1.Text) Then
        Else


            ' MarkupImage.ImageUrl = "Markup.aspx?backimage=LocalMap.jpg&desc=90,63,2,mostafa anotate;"
            TextBox2.Text = TextBox1.Text
            Using calc As SqlText = New SqlText(
                   "select lastannotate from [CarInfom] where Car_No=@Car_No")


                calc.AddParameter("@Car_No", TextBox1.Text)
                Dim total As Object = calc.ExecuteScalar()
                Dim descstring As String = total.ToString()
                If DBNull.Value.Equals(total) Then
                    MarkupImage.ImageUrl = "Markup.aspx?backimage=LocalMap.jpg&desc="
                Else
                    TextBox3.Text = descstring
                    MarkupImage.ImageUrl = "Markup.aspx?backimage=LocalMap.jpg&desc=" & descstring
                End If
                Timer1.Enabled = True
            End Using
        End If
    End Sub

    Protected Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'RadGrid1.Rebind()
    End Sub


    Protected Sub TextBox1_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If String.IsNullOrEmpty(TextBox1.Text) Then
        Else


            ' MarkupImage.ImageUrl = "Markup.aspx?backimage=LocalMap.jpg&desc=90,63,2,mostafa anotate;"
            TextBox2.Text = TextBox1.Text
            Using calc As SqlText = New SqlText(
                   "select lastannotate from [CarInfom] where Car_No=@Car_No")


                calc.AddParameter("@Car_No", TextBox1.Text)
                Dim total As Object = calc.ExecuteScalar()
                Dim descstring As String = total.ToString()
                If DBNull.Value.Equals(total) Then
                    MarkupImage.ImageUrl = "Markup.aspx?backimage=LocalMap.jpg&desc="
                Else
                    TextBox3.Text = descstring
                    MarkupImage.ImageUrl = "Markup.aspx?backimage=LocalMap.jpg&desc=" & descstring
                End If
                Timer1.Enabled = True
            End Using
        End If
    End Sub
End Class
