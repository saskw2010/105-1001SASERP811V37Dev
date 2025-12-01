Imports Neodynamic.SDK.Web
Imports System.Web.UI

Partial Class DemoPrintFilePDF
    Inherits System.Web.UI.Page

    Private Sub DemoPrintFilePDF_Load(sender As Object, e As EventArgs) Handles Me.Load
        'If Not Page.IsPostBack Then
        '    ' Your JavaScript code to be executed on page load
        '    Dim script As String = "
        '        ' Your JavaScript code here
        '        jsWebClientPrint.print('printerName=' + encodeURIComponent('Microsoft Print to PDF') + '&fileName=' + encodeURIComponent($('#fileName').text()) + '&trayName=' + encodeURIComponent($('#lstPrinterTrays').val()) + '&paperName=' + encodeURIComponent($('#lstPrinterPapers').val()) + '&printRotation=' + $('#lstPrintRotation').val() + '&pagesRange=' + encodeURIComponent($('#txtPagesRange').val()) + '&printAnnotations=' + $('#chkPrintAnnotations').prop('checked') + '&printAsGrayscale=' + $('#chkPrintAsGrayscale').prop('checked') + '&printInReverseOrder=' + $('#chkPrintInReverseOrder').prop('checked') + '&manualDuplexPrinting=' + $('#chkManualDuplexPrinting').prop('checked') + '&driverDuplexPrinting=' + ($('#chkDriverDuplexPrinting').prop('disabled') ? 'false' : $('#chkDriverDuplexPrinting').prop('checked')) + '&pageSizing=' + $('#lstPageSizing').val() + '&autoRotate=' + ($('#chkAutoRotate').prop('disabled') ? 'false' : $('#chkAutoRotate').prop('checked')) + '&autoCenter=' + ($('#chkAutoCenter').prop('disabled') ? 'false' : $('#chkAutoCenter').prop('checked')));
        '    "

        '    ' RegisterStartupScript to execute the script on page load
        '    ClientScript.RegisterStartupScript(Me.GetType(), "StartupScript", script, True)
        'End If
    End Sub

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
