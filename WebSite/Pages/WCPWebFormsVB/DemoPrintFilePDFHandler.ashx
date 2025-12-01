<%@ WebHandler Language="VB" Class="DemoPrintFilePDFHandler" %>

Imports System
Imports System.Web

Imports Neodynamic.SDK.Web

Public Class DemoPrintFilePDFHandler : Implements IHttpHandler


    '############### IMPORTANT!!! ############
    ' If your website requires AUTHENTICATION, then you MUST configure THIS Handler file
    ' to be ANONYMOUS access allowed!!!
    '######################################### 


    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest

        If WebClientPrint.ProcessPrintJob(context.Request.Url.Query) Then


            'Dim useDefaultPrinter As Boolean = True '(context.Request("useDefaultPrinter") = "checked")
            'Dim printerName As String = context.Server.UrlDecode(context.Request("printerName"))

            'Dim fileName As String = "chicklistgl.pdf" ' context.Server.UrlDecode(context.Request("fileName"))
            'If IsNothing(fileName) Then
            '    fileName = "chicklistgl.pdf"
            'End If
            'Dim appDirectory1 As String = HttpContext.Current.Server.MapPath("~")


            'Dim filePath As String = "~/Pages/WCPWebFormsVB/files/" + fileName

            'If (filePath <> Nothing) Then

            '    Dim file As New PrintFile(context.Server.MapPath(filePath), fileName)
            '    Dim cpj As New ClientPrintJob()
            '    cpj.PrintFile = file
            '    If (useDefaultPrinter OrElse printerName = "null") Then
            '        cpj.ClientPrinter = New DefaultPrinter()
            '    Else
            '        cpj.ClientPrinter = New InstalledPrinter(printerName)
            '    End If
            '    cpj.SendToClient(context.Response)


            '    context.Response.ContentType = "application/octet-stream"
            '    context.Response.BinaryWrite(cpj.GetContent())
            '    context.Response.End()
            'End If

            Dim printerName As String = context.Server.UrlDecode(context.Request("printerName"))
            Dim trayName As String = context.Server.UrlDecode(context.Request("trayName"))
            Dim paperName As String = context.Server.UrlDecode(context.Request("paperName"))

            Dim PrintRotation As String = context.Server.UrlDecode(context.Request("printRotation"))
            Dim pagesRange As String = context.Server.UrlDecode(context.Request("pagesRange"))

            Dim printAnnotations As Boolean = (context.Request("printAnnotations") = "true")
            Dim printAsGrayscale As Boolean = (context.Request("printAsGrayscale") = "true")
            Dim printInReverseOrder As Boolean = (context.Request("printInReverseOrder") = "true")
            Dim manualDuplexPrinting As Boolean = (context.Request("manualDuplexPrinting") = "true")
            Dim driverDuplexPrinting As Boolean = (context.Request("driverDuplexPrinting") = "true")

            If (manualDuplexPrinting AndAlso driverDuplexPrinting) Then
                manualDuplexPrinting = False
            End If

            Dim pageSizing As String = context.Server.UrlDecode(context.Request("pageSizing"))
            Dim autoRotate As Boolean = (context.Request("autoRotate") = "true")
            Dim autoCenter As Boolean = (context.Request("autoCenter") = "true")

            Dim fileName As String = Guid.NewGuid().ToString("N")
            Dim filePath As String = "~/Pages/WCPWebFormsVB/files/mixed-page-orientation.pdf"

            Dim file As New PrintFilePDF(context.Server.MapPath(filePath), fileName)
            file.PrintRotation = [Enum].Parse(GetType(PrintRotation), PrintRotation)
            file.PagesRange = pagesRange
            file.PrintAnnotations = printAnnotations
            file.PrintAsGrayscale = printAsGrayscale
            file.PrintInReverseOrder = printInReverseOrder
            If manualDuplexPrinting Then
                file.DuplexPrinting = manualDuplexPrinting
                'file.DuplexPrintingDialogMessage = "Your custom dialog message for duplex printing"
            End If
            file.Sizing = [Enum].Parse(GetType(Sizing), pageSizing)
            file.AutoCenter = autoCenter
            file.AutoRotate = autoRotate

            Dim cpj As New ClientPrintJob()
            cpj.PrintFile = file
            If printerName = "null" Then
                cpj.ClientPrinter = New DefaultPrinter()
            Else
                If (trayName = "null") Then trayName = ""
                If (paperName = "null") Then paperName = ""
                cpj.ClientPrinter = New InstalledPrinter(printerName, True, trayName, paperName)
                If driverDuplexPrinting Then
                    DirectCast(cpj.ClientPrinter, InstalledPrinter).Duplex = Duplex.Vertical
                End If
            End If

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