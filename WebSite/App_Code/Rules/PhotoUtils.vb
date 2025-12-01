Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO



Public NotInheritable Class PhotoUtils

    Private Sub New()
    End Sub
    Public Shared Function Inscribe(ByVal image As Image, ByVal size As Integer) As Image
        Return Inscribe(image, size, size)
    End Function

    Public Shared Function Inscribe(ByVal image As Image, ByVal width As Integer, ByVal height As Integer) As Image
        Dim result As New Bitmap(width, height)
        Using graphics As Graphics = graphics.FromImage(result)
            Dim factor As Double = 1.0 * width / image.Width
            If image.Height * factor < height Then
                factor = 1.0 * height / image.Height
            End If
            Dim size As New Size(CInt(Fix(width / factor)), CInt(Fix(height / factor)))
            Dim sourceLocation As New Point((image.Width - size.Width) / 2, (image.Height - size.Height) / 2)

            SmoothGraphics(graphics)
            graphics.DrawImage(image, New Rectangle(0, 0, width, height), New Rectangle(sourceLocation, size), GraphicsUnit.Pixel)
        End Using
        Return result
    End Function

    Private Shared Sub SmoothGraphics(ByVal g As Graphics)
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.InterpolationMode = InterpolationMode.HighQualityBicubic
        g.PixelOffsetMode = PixelOffsetMode.HighQuality
    End Sub

    Public Shared Sub SaveToJpeg(ByVal image As Image, ByVal output As Stream)
        image.Save(output, ImageFormat.Jpeg)
    End Sub

    Public Shared Sub SaveToJpeg(ByVal image As Image, ByVal fileName As String)
        image.Save(fileName, ImageFormat.Jpeg)
    End Sub


End Class


