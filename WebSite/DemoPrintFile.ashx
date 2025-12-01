<%@ WebHandler Language="VB" Class="DemoPrintFile" %>

Imports System
Imports System.Web
Imports Neodynamic.SDK.Web

Public Class DemoPrintFile : Implements IHttpHandler

    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        Dim useDefaultPrinter As Boolean = True '(context.Request("useDefaultPrinter") = "checked")
        Dim printerName As String = context.Server.UrlDecode(context.Request("printerName"))

        Dim fileName As String = context.Server.UrlDecode(context.Request("fileName"))
        If IsNothing(fileName) Then
            fileName = "chicklistgl.pdf"
        End If
        Dim appDirectory1 As String = HttpContext.Current.Server.MapPath("~")


        Dim filePath As String = "~/Pages/reportstock/web/" + fileName

        If (filePath <> Nothing) Then

            Dim file As New PrintFile(context.Server.MapPath(filePath), fileName)
            Dim cpj As New ClientPrintJob()
            cpj.PrintFile = file
            If (useDefaultPrinter OrElse printerName = "null") Then
                cpj.ClientPrinter = New DefaultPrinter()
            Else
                cpj.ClientPrinter = New InstalledPrinter(printerName)
            End If
            ' cpj.SendToClient(context.Response)


            context.Response.ContentType = "application/octet-stream"
            context.Response.BinaryWrite(cpj.GetContent())
            context.Response.End()
        End If


    End Sub

    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class