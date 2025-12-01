<%@ WebHandler Language="VB" Class="ThemeApplier" %>

Imports System
Imports System.Web
Imports System.Web.SessionState
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json

Public Class ThemeApplier : Implements IHttpHandler, IRequiresSessionState
    
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Try
            ' Set response headers
            context.Response.ContentType = "application/json"
            context.Response.AddHeader("Access-Control-Allow-Origin", "*")
            context.Response.AddHeader("Access-Control-Allow-Methods", "POST")
            context.Response.AddHeader("Access-Control-Allow-Headers", "Content-Type")
            
            ' Handle preflight requests
            If context.Request.HttpMethod = "OPTIONS" Then
                context.Response.StatusCode = 200
                Return
            End If
            
            ' Only accept POST requests
            If context.Request.HttpMethod <> "POST" Then
                SendErrorResponse(context, "Only POST method is allowed", 405)
                Return
            End If
            
            ' Read request body
            Dim requestBody As String = ""
            Using reader As New StreamReader(context.Request.InputStream)
                requestBody = reader.ReadToEnd()
            End Using
            
            ' Parse JSON request
            Dim request As ThemeRequest = JsonConvert.DeserializeObject(Of ThemeRequest)(requestBody)
            
            If request Is Nothing OrElse String.IsNullOrEmpty(request.ThemeId) Then
                SendErrorResponse(context, "Invalid request. ThemeId is required.", 400)
                Return
            End If
            
            ' Apply the theme
            Dim result As ThemeApplyResult = ApplyTheme(request.ThemeId, context)
            
            ' Send response
            SendSuccessResponse(context, result)
            
        Catch ex As Exception
            ' Log error (you might want to use your logging system)
            System.Diagnostics.Debug.WriteLine("Theme Applier Error: " & ex.Message)
            SendErrorResponse(context, "Internal server error: " & ex.Message, 500)
        End Try
    End Sub
    
    Private Function ApplyTheme(themeId As String, context As HttpContext) As ThemeApplyResult
        Try
            ' Validate theme ID
            Dim validThemes As String() = {"citrus", "ezee", "light", "dark", "ai", "emerald", "rose"}
            If Not validThemes.Contains(themeId.ToLower()) Then
                Throw New ArgumentException("Invalid theme ID: " & themeId)
            End If
            
            ' Get server paths
            Dim serverPath As String = context.Server.MapPath("~")
            Dim sourceFile As String = Path.Combine(serverPath, "css", "themes-physical", themeId & "-theme.css")
            Dim targetFile As String = Path.Combine(serverPath, "css", "stylesheet.css")
            
            ' Check if source theme file exists
            If Not File.Exists(sourceFile) Then
                Throw New FileNotFoundException("Theme file not found: " & sourceFile)
            End If
            
            ' Create backup of current stylesheet
            CreateStylesheetBackup(targetFile)
            
            ' Copy theme CSS to stylesheet.css
            File.Copy(sourceFile, targetFile, True)
            
            ' Save theme preference to session/application state
            If context.Session IsNot Nothing Then
                context.Session("SelectedTheme") = themeId
            End If
            
            ' Also save to Application state for global access
            context.Application("DefaultTheme") = themeId
            
            ' Log successful application
            System.Diagnostics.Debug.WriteLine("Theme applied successfully: " & themeId)
            
            Return New ThemeApplyResult With {
                .Success = True,
                .ThemeId = themeId,
                .Message = "Theme '" & themeId & "' applied successfully",
                .Timestamp = DateTime.Now,
                .BackupCreated = True
            }
            
        Catch ex As Exception
            Throw New Exception("Failed to apply theme '" & themeId & "': " & ex.Message, ex)
        End Try
    End Function
    
    Private Sub CreateStylesheetBackup(stylesheetPath As String)
        Try
            If File.Exists(stylesheetPath) Then
                Dim backupDir As String = Path.Combine(Path.GetDirectoryName(stylesheetPath), "backups")
                If Not Directory.Exists(backupDir) Then
                    Directory.CreateDirectory(backupDir)
                End If
                
                Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd-HHmm")
                Dim backupFile As String = Path.Combine(backupDir, "stylesheet-backup-" & timestamp & ".css")
                
                File.Copy(stylesheetPath, backupFile, True)
                System.Diagnostics.Debug.WriteLine("Stylesheet backup created: " & backupFile)
            End If
        Catch ex As Exception
            ' Don't fail the main operation if backup fails
            System.Diagnostics.Debug.WriteLine("Warning: Failed to create stylesheet backup: " & ex.Message)
        End Try
    End Sub
    
    Private Sub SendSuccessResponse(context As HttpContext, result As ThemeApplyResult)
        Dim response As String = JsonConvert.SerializeObject(result)
        context.Response.StatusCode = 200
        context.Response.Write(response)
    End Sub
    
    Private Sub SendErrorResponse(context As HttpContext, message As String, statusCode As Integer)
        Dim errorResponse = New With {
            .Success = False,
            .Message = message,
            .Timestamp = DateTime.Now
        }
        
        Dim response As String = JsonConvert.SerializeObject(errorResponse)
        context.Response.StatusCode = statusCode
        context.Response.Write(response)
    End Sub
    
End Class

' Data models
Public Class ThemeRequest
    Public Property ThemeId As String
    Public Property UserId As String
    Public Property Force As Boolean = False
End Class

Public Class ThemeApplyResult
    Public Property Success As Boolean
    Public Property ThemeId As String
    Public Property Message As String
    Public Property Timestamp As DateTime
    Public Property BackupCreated As Boolean
End Class
