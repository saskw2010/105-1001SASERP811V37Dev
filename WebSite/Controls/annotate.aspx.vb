
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Web.SessionState
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.Net
Imports System.IO
Imports mostafalibarary
Imports eZee.Data

Public Class annotate
    Inherits System.Web.UI.Page
    Private carno As String
    Private descstring As String

    <Obsolete>
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ' Put user code to initialize the page here
        Dim markload As String = Nothing
        carno = Request.Params("carno")
        descstring = Request.Params("desc")
        Dim backimage As String = Request.Params("backimage")
        If backimage Is Nothing Then
            'backimage = "LocalMap.jpg";
            Response.Redirect("annotate.aspx?backimage=LocalMap.jpg")
        End If
        If Not IsPostBack Then
            ' Bind the dropdown list
            Dim tbl As DataTable = GetMarkTypeTable()
            listType.DataSource = tbl
            listType.DataValueField = "value"
            listType.DataTextField = "desc"
            listType.DataBind()
            ' Create javascript for displaying example text
            Dim script As String = "<script language=javascript> function getExample() {"
            script += "var examples = new Array(" + tbl.Rows.Count.ToString() + ");"
            For i As Integer = 1 To tbl.Rows.Count - 1
                script += "examples[" + tbl.Rows(i)("value") + "]=""" + tbl.Rows(i)("example") + """;"
            Next
            script += "document.getElementById(""lblExample"").innerHTML="
            script += "examples[document.getElementById(""listType"").value]; }"
            script += "</script>"
            Session("ExampleScript") = script
            'If (String.IsNullOrEmpty(carno)) Or (carno Is Nothing) Then
            'Else
            '    'Dim descstring As String
            '    '' MarkupImage.ImageUrl = "Markup.aspx?backimage=LocalMap.jpg&desc=90,63,2,mostafa anotate;"
            '    'Using calc As SqlText = New SqlText(
            '    '       "select lastannotate from [CarInfom] where Car_No=@Car_No")
            '    '    calc.AddParameter("@Car_No", CInt(Left(carno, 1)))
            '    '    Dim total As Object = calc.ExecuteScalar()
            '    '    If (DBNull.Value.Equals(total)) Or IsNothing(total) Then
            '    '        descstring = "100,63,2,Havnot anotate;"
            '    '        'Dim ctl1 As ImageButton = TryCast(myControl.FindControl("MarkupImage"), System.Web.UI.WebControls.ImageButton)
            '    '        'If ctl1 IsNot Nothing Then
            '    '        '    ctl1.ImageUrl = "Markup.aspx?backimage=LocalMap.jpg&desc="
            '    '        'End If
            '    '    Else
            '    '        descstring = total.ToString()
            '    '        'Dim ctl1 As ImageButton = TryCast(myControl.FindControl("MarkupImage"), System.Web.UI.WebControls.ImageButton)
            '    '        'If ctl1 IsNot Nothing Then
            '    '        '    myControl.LastName.Text = descstring
            '    '        '    ctl1.ImageUrl = "Markup.aspx?backimage=LocalMap.jpg&desc=" & descstring
            '    '        'End If
            '    '    End If
            '    'End Using
            'End If
            markload = (Convert.ToString("Markup.aspx?backimage=") & backimage) + "&carno=" & carno + "&desc=" + descstring
        End If

        ' Register client-side javascript for displaying example text
        Dim javascript As String = TryCast(Session("ExampleScript"), String)
        If javascript IsNot Nothing Then
            Page.RegisterStartupScript("getExample", javascript)
            listType.Attributes.Add("onChange", "getExample()")
        End If

        ' Retrieve x and y where the mouse click took place
        Dim x As String = Request.Params("MarkupImage.x")
        Dim y As String = Request.Params("MarkupImage.y")
        ' Get type of annotation selected
        Dim type As String = listType.SelectedValue
        ' Get any applicable argument
        Dim param As String = txtParam.Text
        ' Create the MarkableType
        Dim mark As MarkableType = MarkManager.CreateByID(type)
        If mark IsNot Nothing AndAlso param.Length > 0 Then
            mark.LoadFromString(param)
        End If
        ' Construct the new ImageURL

        If x IsNot Nothing AndAlso y IsNot Nothing AndAlso x.Length >= 0 AndAlso y.Length >= 0 AndAlso mark IsNot Nothing Then
            Dim append As String = String.Join(",", New String() {x, y, type, mark.SaveAsString()})
            MarkupImage.ImageUrl += HttpUtility.HtmlEncode(append & Convert.ToString(";"))
            txtParam0.Text = MarkupImage.ImageUrl
        End If

        If markload IsNot Nothing Then
            MarkupImage.ImageUrl = markload
            txtParam0.Text = MarkupImage.ImageUrl
        End If

    End Sub

    Protected Function GetMarkTypeTable() As DataTable
        Dim tbl As New DataTable()

        Dim col As New DataColumn("value", Type.[GetType]("System.String"))
        tbl.Columns.Add(col)

        col = New DataColumn("desc", Type.[GetType]("System.String"))
        tbl.Columns.Add(col)

        col = New DataColumn("example", Type.[GetType]("System.String"))
        tbl.Columns.Add(col)

        Dim row As DataRow = tbl.NewRow()
        row("value") = "-1"
        row("desc") = ""
        row("example") = ""
        tbl.Rows.Add(row)

        row = tbl.NewRow()
        row("value") = "0"
        row("desc") = "Rectangle"
        row("example") = "format: 'width,height'. eg. 5,6"
        tbl.Rows.Add(row)

        row = tbl.NewRow()
        row("value") = "1"
        row("desc") = "Circle"
        row("example") = "format: 'radius'. eg. 10"
        tbl.Rows.Add(row)

        row = tbl.NewRow()
        row("value") = "2"
        row("desc") = "Text"
        row("example") = "format: 'text'."
        tbl.Rows.Add(row)

        row = tbl.NewRow()
        row("value") = "3"
        row("desc") = "Image"
        row("example") = "format: 'image.jpg'. Type eg. left.ico, right.ico, stop.ico. Relative to the current directory"
        tbl.Rows.Add(row)

        tbl.AcceptChanges()

        Return tbl
    End Function

    Protected Sub btnRemove_Click1(sender As Object, e As System.EventArgs) Handles btnRemove.Click
        ' To remove an item, simply remove its corresponding part in MarkupImage.ImageUrl

        If txtRemove.Text.Length <= 0 Then
            Return
        End If

        Dim url As String = HttpUtility.HtmlDecode(MarkupImage.ImageUrl)

        Dim id As Integer = -1
        Try
            id = Integer.Parse(txtRemove.Text)
        Catch
        End Try

        Dim pos1 As Integer = url.IndexOf("?desc=") + 5
        Dim pos2 As Integer = -1
        ' pos1 is to the right of pos2
        While id >= 0
            pos2 = pos1
            pos1 = url.IndexOf(";", System.Math.Max(0, pos2 + 1))
            ' non-negative
            If pos1 >= 0 Then
                id -= 1
            Else
                ' did not find the id
                Return
            End If
        End While

        ' discard between pos2+1 and pos1, inclusive
        MarkupImage.ImageUrl = url.Remove(pos2 + 1, pos1 - pos2)
    End Sub
    Protected Sub btnRemove_Click2(sender As Object, e As EventArgs)

        ' getting error at this point.

        'newImage = System.Drawing.Image.FromStream(stream);

        'newImage.Save(strFileName);
    End Sub
    Protected Sub btnRemove_Click3(sender As Object, e As EventArgs)

    End Sub
    Public Sub SaveFileOnDisk(ms As MemoryStream, FileName As String)
        Try
            Dim appPath As String = HttpContext.Current.Request.ApplicationPath
            Dim physicalPath As String = HttpContext.Current.Request.MapPath(appPath)
            Dim strpath As String = physicalPath & Convert.ToString("\Images")
            Dim WorkingDirectory As String = strpath


            Dim imgSave As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
            Dim bmSave As New Bitmap(imgSave)
            Dim bmTemp As New Bitmap(bmSave)

            Dim grSave As Graphics = Graphics.FromImage(bmTemp)
            grSave.DrawImage(imgSave, 0, 0, imgSave.Width, imgSave.Height)

            bmTemp.Save((Convert.ToString(WorkingDirectory & Convert.ToString("\")) & FileName) + ".jpg")


            imgSave.Dispose()
            bmSave.Dispose()
            bmTemp.Dispose()
            grSave.Dispose()
            'lblMsg.Text = "Please try again later.";
        Catch ex As Exception
        End Try

    End Sub

    
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
