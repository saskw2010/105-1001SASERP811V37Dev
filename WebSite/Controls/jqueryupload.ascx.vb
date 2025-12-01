Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
'Imports CuteWebUI
Partial Public Class Controls_jqueryupload
    Inherits Global.System.Web.UI.UserControl
   
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pathurl As String = "/Controls/p130530044258.aspx?attachfileid=" + Left(TextBox1.Text.ToString(), 1)
        Response.Redirect(HttpContext.Current.Server.MapPath(pathurl))
    End Sub


End Class
