Imports System
Imports System.Web
Imports System.Web.Security

Partial Public Class Logout
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Try
            ' Standard ASP.NET sign-out
            FormsAuthentication.SignOut()

            ' Clear session
            Session.Clear()
            Session.Abandon()

            ' Expire auth cookie if present
            Dim authCookieName As String = FormsAuthentication.FormsCookieName
            If Request.Cookies(authCookieName) IsNot Nothing Then
                Dim c As New HttpCookie(authCookieName, "")
                c.Expires = DateTime.UtcNow.AddDays(-1)
                c.Path = FormsAuthentication.FormsCookiePath
                Response.Cookies.Add(c)
            End If

            ' Clear legacy membership cookies if any
            ExpireCookie(".ASPXAUTH")
            ExpireCookie("ASP.NET_SessionId")

            ' Optional: keep culture cookie; remove if you want to reset language
            'ExpireCookie(".COTCULTURE")

        Catch ex As Exception
            ' swallow and proceed to redirect
        Finally
            Response.Redirect("~/Login.aspx", False)
        End Try
    End Sub

    Private Sub ExpireCookie(name As String)
        If Request.Cookies(name) IsNot Nothing Then
            Dim c As New HttpCookie(name, "")
            c.Expires = DateTime.UtcNow.AddDays(-1)
            c.Path = "/"
            Response.Cookies.Add(c)
        End If
    End Sub
End Class
