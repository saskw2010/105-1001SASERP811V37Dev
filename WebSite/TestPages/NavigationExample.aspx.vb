Imports System

Partial Class NavigationExample
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                ' Set page metadata
                Dim master As UniversalNavMaster = TryCast(Me.Master, UniversalNavMaster)
                If master IsNot Nothing Then
                    master.SetMetaDescription("مثال توضيحي لاستخدام النظام الموحد للتنقل في SASERP V37")
                    master.SetMetaKeywords("navigation, hamburger menu, vue.js, asp.net, saserp")
                End If

                ' Log page visit
                LogPageVisit()
            End If
        Catch ex As Exception
            ' Log error but don't break the page
            System.Diagnostics.Debug.WriteLine("Error in NavigationExample Page_Load: " & ex.Message)
        End Try
    End Sub

    Private Sub LogPageVisit()
        Try
            ' Log page visit for analytics (if needed)
            Dim logEntry As String = String.Format("User: {0}, Page: NavigationExample, Time: {1}", 
                                                  If(User.Identity.IsAuthenticated, User.Identity.Name, "Anonymous"),
                                                  DateTime.Now.ToString())
            
            System.Diagnostics.Debug.WriteLine("Page Visit: " & logEntry)
            
            ' You could also log to database or file here
            
        Catch ex As Exception
            ' Don't break the page for logging errors
            System.Diagnostics.Debug.WriteLine("Error logging page visit: " & ex.Message)
        End Try
    End Sub

End Class
