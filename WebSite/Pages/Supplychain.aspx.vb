Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls


Partial Public Class Pages_Supplychain
    Inherits Global.eZee.Web.PageBase
    
    Public ReadOnly Property CssClass() As String
        Get
            Return "HomePage Wide"
        End Get
    End Property
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
    End Sub
End Class
