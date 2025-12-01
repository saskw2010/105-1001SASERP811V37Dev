Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls


Partial Public Class Pages_MySite
    Inherits Global.eZee.Web.PageBase
    
    Public ReadOnly Property CssClass() As String
        Get
            Return ""
        End Get
    End Property

    Protected Overloads Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim title As String = "Greetings"
        Dim body As String = "Welcome to ASPSnippets.com"
        ClientScript.RegisterStartupScript(Me.[GetType](), "Popup", "ShowPopup('" & title & "', '" & body & "');", True)

    End Sub
End Class
