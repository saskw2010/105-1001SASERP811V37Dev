Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Web.Script.Serialization
Imports eZee.Data

Namespace eZee.Api
    Public Class DynamicV2Controller
        
        Public Shared Function GetData(ByVal controllerName As String, ByVal limit As Integer, ByVal pageIndex As Integer) As Object
            Try
                ' Create Page Request
                Dim request As New PageRequest(pageIndex, limit, Nothing, Nothing)
                request.Controller = controllerName
                request.View = "grid1" ' Default view
                request.RequiresMetaData = True
                
                ' Execute Request
                Dim controller As IDataController = ControllerFactory.CreateDataController()
                Dim page As ViewPage = controller.GetPage(controllerName, "grid1", request)
                
                ' Convert to List of Dictionaries
                Dim result As New List(Of Dictionary(Of String, Object))
                
                For Each row As Object() In page.Rows
                    Dim rowDict As New Dictionary(Of String, Object)
                    For i As Integer = 0 To page.Fields.Count - 1
                        Dim field As DataField = page.Fields(i)
                        rowDict(field.Name) = row(i)
                    Next
                    result.Add(rowDict)
                Next
                
                Return result
                
            Catch ex As Exception
                Dim errorDict As New Dictionary(Of String, Object)
                errorDict("error") = ex.Message
                errorDict("stack") = ex.StackTrace
                Return errorDict
            End Try
        End Function
        
    End Class
End Namespace
