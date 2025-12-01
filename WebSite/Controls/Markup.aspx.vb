Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Web.SessionState
Imports System.Web.UI.HtmlControls
Imports System.IO
Imports System.Text
Imports System.Drawing.Imaging
Imports System.Drawing.Text
Imports System.Drawing.Drawing2D
Imports System.Net
Imports mostafalibarary
Imports eZee.Data
Public Class Markup
    Inherits System.Web.UI.Page
    Private carno As String
    Private Sub MarkupImage(image As String, desc As String)
        Dim bitmap As New Bitmap(Server.MapPath(image))
        Dim memStream As New MemoryStream()

        Dim g As Graphics = Graphics.FromImage(bitmap)
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' Draw each annotation object of MarkableType, ; separated
        If desc.IndexOf(";") > 0 Then
            Dim width As Integer = bitmap.Width
            Dim height As Integer = bitmap.Height

            Dim xys As String() = desc.Split(";"c)
            Dim points As Point() = New Point(xys.Length - 1) {}
            Dim marks As New ArrayList(xys.Length)

            Dim i As Integer = 0
            For Each xy As String In xys
                ' Internally comma separated
                Dim tmp As String() = xy.Split(","c)

                If tmp.Length <= 2 Then
                    ' skip if incomplete pair
                    Continue For
                End If

                ' Get x, y
                Dim x As Integer = Integer.Parse(tmp(0))
                Dim y As Integer = Integer.Parse(tmp(1))
                points(System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)) = New Point(x, y)

                ' Get type
                Dim typeid As String = tmp(2)

                ' Get the rest as the arguments
                Dim param As String = String.Empty
                If tmp.Length = 4 Then
                    param = tmp(3)
                ElseIf tmp.Length > 4 Then
                    Dim rest As String() = New String(tmp.Length - 4) {}
                    For j As Integer = 3 To tmp.Length - 1
                        rest(j - 3) = tmp(j)
                    Next
                    param = String.Join(",", rest)
                End If

                ' Create MarkableType oject from its string form
                Dim mark As MarkableType = MarkManager.CreateByID(typeid)
                If param.Length > 0 Then
                    mark.LoadFromString(param)
                End If
                marks.Add(mark)
            Next

            ' The number of marks is i
            Dim brush As New SolidBrush(Color.Blue)
            For j As Integer = 0 To i - 1
                Dim familyName As String = "Tahoma"

                Dim font As Font
                font = New Font(familyName, 10.0F, FontStyle.Bold)

                Dim format As New StringFormat()
                format.Alignment = StringAlignment.Center
                format.LineAlignment = StringAlignment.Center

                ' Draw an identifier
                g.DrawString(j.ToString(), font, brush, New Point(points(j).X + 12, points(j).Y), format)

                ' Draw the annotation itself
                MarkManager.Draw(g, points(j).X, points(j).Y, DirectCast(marks(j), MarkableType))
            Next
            brush.Dispose()
        End If

        ' Set the content type
        Response.Clear()
        Response.ContentType = "image/jpeg"

        ' Send the bitmap to the output stream
        bitmap.Save(memStream, ImageFormat.Jpeg)
        SaveFileOnDisk(memStream, carno, desc)
        memStream.WriteTo(Response.OutputStream)

        ' Cleanup
        g.Dispose()
        bitmap.Dispose()
    End Sub

    Public Sub SaveFileOnDisk(ms As MemoryStream, FileName As String, desc As String)
        Try
            Dim appPath As String = HttpContext.Current.Request.ApplicationPath
            Dim physicalPath As String = HttpContext.Current.Request.MapPath(appPath)
            Dim strpath As String = physicalPath & Convert.ToString("Images")
            Dim WorkingDirectory As String = strpath

            Dim imgSave As System.Drawing.Image = System.Drawing.Image.FromStream(ms)
            Dim bmSave As New Bitmap(imgSave)
            Dim bmTemp As New Bitmap(bmSave)

            Dim grSave As Graphics = Graphics.FromImage(bmTemp)
            grSave.DrawImage(imgSave, 0, 0, imgSave.Width, imgSave.Height)

            bmTemp.Save((Convert.ToString(WorkingDirectory & Convert.ToString("\")) & FileName) + ".jpg")
            Using calc As SqlText = New SqlText(
                       "update [CarInfom] set lastannotate=@desc  where Car_No=@Car_No")
                calc.AddParameter("@Car_No", carno)
                calc.AddParameter("@desc", desc)
                Dim total As Object = calc.ExecuteScalar()

            End Using
            imgSave.Dispose()
            bmSave.Dispose()
            bmTemp.Dispose()
            grSave.Dispose()
            'lblMsg.Text = "Please try again later.";
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ' Put user code to initialize the page here
        carno = Request.Params("carno")
        Dim backimage As String = Request.Params("backimage")
        Dim desc As String = HttpUtility.HtmlDecode(Request.Params("desc"))
        If desc Is Nothing Then
            desc = String.Empty
        End If
        If backimage Is Nothing Then
            backimage = "LocalMap.jpg"
        End If

        MarkupImage(backimage, desc)
    End Sub
End Class

