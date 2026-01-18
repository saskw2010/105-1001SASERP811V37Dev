Imports System
Imports System.Data
Imports System.IO
Imports System.Web
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet

Public Class ExcelExportHelper
    Public Shared Sub Export(ByVal dt As DataTable, ByVal fileName As String, ByVal response As HttpResponse)
        response.Clear()
        response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
        response.AddHeader("content-disposition", String.Format("attachment;filename={0}", fileName))

        Using memoryStream As New MemoryStream()
            Using document As SpreadsheetDocument = SpreadsheetDocument.Create(memoryStream, SpreadsheetDocumentType.Workbook)
                Dim workbookPart As WorkbookPart = document.AddWorkbookPart()
                workbookPart.Workbook = New Workbook()

                Dim worksheetPart As WorksheetPart = workbookPart.AddNewPart(Of WorksheetPart)()
                worksheetPart.Worksheet = New Worksheet()

                Dim sheets As Sheets = document.WorkbookPart.Workbook.AppendChild(New Sheets())
                Dim sheet As Sheet = New Sheet() With {
                    .Id = document.WorkbookPart.GetIdOfPart(worksheetPart),
                    .SheetId = 1,
                    .Name = "Sheet1"
                }
                sheets.Append(sheet)

                Dim writer As OpenXmlWriter = OpenXmlWriter.Create(worksheetPart)
                writer.WriteStartElement(New Worksheet())
                writer.WriteStartElement(New SheetData())

                ' Write Header
                writer.WriteStartElement(New Row())
                For Each col As DataColumn In dt.Columns
                    Dim cell As New Cell()
                    cell.DataType = CellValues.String
                    cell.CellValue = New CellValue(col.ColumnName)
                    writer.WriteElement(cell)
                Next
                writer.WriteEndElement() ' Row

                ' Write Data
                For Each row As DataRow In dt.Rows
                    writer.WriteStartElement(New Row())
                    For Each col As DataColumn In dt.Columns
                        Dim cell As New Cell()
                        Dim val As Object = row(col)
                        
                        If val IsNot DBNull.Value Then
                            If IsNumeric(val) Then
                                cell.DataType = CellValues.Number
                                cell.CellValue = New CellValue(Convert.ToString(val))
                            ElseIf TypeOf val Is DateTime Then
                                ' For simplicity treating dates as string in this basic implementation
                                ' To do it properly requires Stylesheet
                                cell.DataType = CellValues.String
                                cell.CellValue = New CellValue(CType(val, DateTime).ToString("yyyy-MM-dd"))
                            Else
                                cell.DataType = CellValues.String
                                cell.CellValue = New CellValue(Convert.ToString(val))
                            End If
                        Else
                             cell.DataType = CellValues.String
                             cell.CellValue = New CellValue("")
                        End If
                        
                        writer.WriteElement(cell)
                    Next
                    writer.WriteEndElement() ' Row
                Next

                writer.WriteEndElement() ' SheetData
                writer.WriteEndElement() ' Worksheet
                writer.Close()
            End Using

            memoryStream.WriteTo(response.OutputStream)
        End Using

        response.Flush()
        response.End()
    End Sub
End Class
