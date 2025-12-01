Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security
Imports System.Xml.XPath
Imports System.ComponentModel
Imports Stimulsoft.Report.Dictionary
Imports Stimulsoft.Report.Components
Imports Stimulsoft.Base.Drawing
Imports Stimulsoft.Base
Imports System.Drawing
Imports eZee.Data.Objects
Imports Telerik
Imports Telerik.Web
Imports Telerik.Web.UI
Imports DataLogic
Namespace eZee.Rules
    
    Partial Public Class schreportpathBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Custom" and argument that matches "copyoff".
        ''' </summary>
        <Rule("r100")>  _
        Public Sub r100Implementation(ByVal controllerNameid As Nullable(Of Long), ByVal controllerName As String, ByVal reportCode As String, ByVal modifiedBy As String, ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdOn As Nullable(Of DateTime), ByVal notes As String, ByVal notes1 As String, ByVal mynotes As String)
            'This is the placeholder for method implementation.
			 'This is the placeholder for method implementation.
			
                'Try to update sql source to view grid1 on the name of controoler
                Dim dbinerto As New dblayer
                Dim xinsert As Boolean
				Dim dtDataTable As DataTable
                   dtDataTable = GetData("select count(controllerNameid) as controllerNameid from schreportpath where controllerName='" & controllerName & "' order by controllerNameid")
                    If dtDataTable.Rows.Count > 0 Then
                        Dim row As DataRow
                        Dim strDetail As String = ""
                        Dim strDetailid As Double = 0
                For Each row In dtDataTable.Rows
                    strDetailid = Convert.ToDouble(row("controllerNameid"))
                    strDetailid = 10000 + strDetailid
                Next
                Dim newnumberreport As String
                newnumberreport = strDetailid + 1

                xinsert = dbinerto.Insert("insert into schreportpath(controllerName,ReportCode) values ('" & controllerName  & "','" & "mrtschpath" & controllerName & newnumberreport & "')")
                Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
                FileCopy(appDirectory + "\Reports\" + reportCode + ".mrt", appDirectory + "\Reports\" + "mrtschpath" & controllerName & newnumberreport + ".mrt")
            End If
        End Sub
    End Class
End Namespace
