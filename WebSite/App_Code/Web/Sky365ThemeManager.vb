Imports System
Imports System.Web
Imports System.Web.UI
Imports System.IO

Namespace eZee.Web

    Public Class Sky365ThemeManager

        ''' <summary>
        ''' Get the current theme from session, application, or default
        ''' </summary>
        Public Shared Function GetCurrentTheme(page As Page) As String
            Try
                ' First check session
                If page.Session IsNot Nothing AndAlso page.Session("SelectedTheme") IsNot Nothing Then
                    Return page.Session("SelectedTheme").ToString()
                End If

                ' Then check application state
                If page.Application("DefaultTheme") IsNot Nothing Then
                    Return page.Application("DefaultTheme").ToString()
                End If

                ' Finally return default
                Return "citrus"

            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("Error getting current theme: " & ex.Message)
                Return "citrus"
            End Try
        End Function

        ''' <summary>
        ''' Apply theme CSS to page header
        ''' </summary>
        Public Shared Sub ApplyThemeToPage(page As Page)
            Try
                Dim currentTheme As String = GetCurrentTheme(page)

                ' Add theme CSS link to page header
                Dim cssLink As New HtmlControls.HtmlLink()
                cssLink.Attributes("rel") = "stylesheet"
                cssLink.Attributes("type") = "text/css"
                cssLink.Href = "~/css/themes-physical/" & currentTheme & "-theme.css"

                ' Add to page header
                If page.Header IsNot Nothing Then
                    page.Header.Controls.Add(cssLink)
                End If

                ' Add theme class to body (if accessible)
                If TypeOf page.Master Is MasterPage Then
                    Dim body As Control = page.Master.FindControl("Body")
                    If body IsNot Nothing AndAlso TypeOf body Is HtmlControls.HtmlGenericControl Then
                        Dim htmlBody As HtmlControls.HtmlGenericControl = DirectCast(body, HtmlControls.HtmlGenericControl)
                        Dim existingClass As String = If(htmlBody.Attributes("class"), "")

                        ' Remove any existing theme classes
                        existingClass = System.Text.RegularExpressions.Regex.Replace(existingClass, "theme-\w+", "").Trim()

                        ' Add current theme class
                        htmlBody.Attributes("class") = (existingClass & " theme-" & currentTheme).Trim()
                    End If
                End If

                System.Diagnostics.Debug.WriteLine("Theme applied to page: " & currentTheme)

            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("Error applying theme to page: " & ex.Message)
            End Try
        End Sub

        ''' <summary>
        ''' Get theme CSS as inline styles (fallback method)
        ''' </summary>
        Public Shared Function GetThemeInlineCSS(page As Page) As String
            Try
                Dim currentTheme As String = GetCurrentTheme(page)
                Dim cssPath As String = page.Server.MapPath("~/css/themes-physical/" & currentTheme & "-theme.css")

                If File.Exists(cssPath) Then
                    Return File.ReadAllText(cssPath)
                End If

            Catch ex As Exception
                System.Diagnostics.Debug.WriteLine("Error reading theme CSS: " & ex.Message)
            End Try

            Return ""
        End Function

        ''' <summary>
        ''' Check if theme file exists
        ''' </summary>
        Public Shared Function ThemeExists(page As Page, themeId As String) As Boolean
            Try
                Dim cssPath As String = page.Server.MapPath("~/css/themes-physical/" & themeId & "-theme.css")
                Return File.Exists(cssPath)
            Catch
                Return False
            End Try
        End Function

    End Class

End Namespace
