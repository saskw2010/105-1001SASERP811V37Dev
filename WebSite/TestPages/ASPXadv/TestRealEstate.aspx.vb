Imports System

Partial Class TestPages_ASPXADV_TestRealEstate
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then
                ' Set page title and description
                Page.Title = "Real Estate Control Test - " & DateTime.Now.ToString("dd/MM/yyyy")
                
                ' Add console logging for debugging
                Page.ClientScript.RegisterStartupScript(Me.GetType(), "testPageLoad", 
                    "console.log('🏠 Real Estate Test Page loaded at: " & DateTime.Now.ToString("HH:mm:ss") & "');", True)
                
                System.Diagnostics.Debug.WriteLine("🏠 Real Estate Test Page initialized successfully")
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in TestRealEstate Page_Load: " & ex.Message)
            ' Handle error gracefully
            Response.Write("<!-- Error loading test page: " & ex.Message & " -->")
        End Try
    End Sub

End Class
