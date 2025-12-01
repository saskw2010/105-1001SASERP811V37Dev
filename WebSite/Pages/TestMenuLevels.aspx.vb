Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Class Pages_TestMenuLevels
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                ' Set page title and meta information
                Page.Title = "Test Menu Levels - SASERP V37"
                Page.MetaDescription = "Test page for verifying 3-level menu structure in Universal Hamburger Menu"
                
                ' Add any initialization logic here
                LogPageAccess()
            End If
        Catch ex As Exception
            ' Log error but don't break the page
            System.Diagnostics.Debug.WriteLine("Error in TestMenuLevels Page_Load: " & ex.Message)
        End Try
    End Sub

    Private Sub LogPageAccess()
        Try
            ' Log that someone accessed the test page
            Dim currentUser As String = If(HttpContext.Current.User.Identity.IsAuthenticated, 
                                         HttpContext.Current.User.Identity.Name, "Anonymous")
            
            System.Diagnostics.Debug.WriteLine("TestMenuLevels accessed by: " & currentUser & " at " & DateTime.Now.ToString())
        Catch ex As Exception
            ' Ignore logging errors
        End Try
    End Sub

    Protected Sub Page_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
        Try
            ' Ensure the Universal Hamburger Menu is properly initialized
            ' This helps with testing the menu structure
            
            ' Add any pre-render logic here if needed
            EnsureMenuTestingResources()
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in TestMenuLevels Page_PreRender: " & ex.Message)
        End Try
    End Sub

    Private Sub EnsureMenuTestingResources()
        Try
            ' Register additional CSS for better testing visualization if needed
            Dim testingCSS As String = _
                ".nav-menu-item.level-0 { border-left: 3px solid #2196f3; }" & vbCrLf & _
                ".nav-menu-item.level-1 { border-left: 3px solid #4caf50; }" & vbCrLf & _
                ".nav-menu-item.level-2 { border-left: 3px solid #ff9800; }" & vbCrLf & _
                ".nav-menu-item.level-3 { border-left: 3px solid #f44336; }"
            
            Page.ClientScript.RegisterClientScriptBlock(Me.GetType(), "MenuTestingCSS", 
                "<style>" & testingCSS & "</style>", False)
                
        Catch ex As Exception
            ' Ignore CSS registration errors
        End Try
    End Sub

End Class
