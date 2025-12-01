Imports Neodynamic.SDK.Web

Partial Class Default4
    Inherits System.Web.UI.Page
   
    Public Function getquerstring() As String
        Dim returnstring As String = ""
        returnstring = Context.Request.QueryString("reportquery")
        If String.IsNullOrEmpty(returnstring) Or IsNothing(returnstring) Then
            Return "LoremIpsum.pdf"
        Else
            Return returnstring
        End If
    End Function
End Class
