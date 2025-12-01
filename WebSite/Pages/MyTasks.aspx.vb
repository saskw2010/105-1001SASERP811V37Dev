Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls


Partial Public Class Pages_MyTasks
    Inherits Global.eZee.Web.PageBase
    
    Public ReadOnly Property CssClass() As String
        Get
            Return "TasksPage"
        End Get
    End Property
    
    Public Overrides ReadOnly Property Device() As String
        Get
            Return "Touch UI"
        End Get
    End Property
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
    End Sub
End Class
