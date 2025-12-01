Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schvchdlyhandeler
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view after an action
        ''' with a command name that matches "Update".
        ''' </summary>
        <Rule("schvchdlyhdreg100")>  _
        Public Sub schvchdlyhdreg100Implementation( _
                    ByVal schvchdlyhdregid As Nullable(Of Long),  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal balance As Nullable(Of Decimal),  _
                    ByVal iDregorg As Nullable(Of Long),  _
                    ByVal iDregorgNAME_1 As String,  _
                    ByVal delevername As String,  _
                    ByVal delevercivil As String,  _
                    ByVal deleverTel As String,  _
                    ByVal notes As String,  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal posted As Nullable(Of Boolean),  _
                    ByVal deleted As Nullable(Of Boolean),  _
                    ByVal havdetails As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedByUserId As Nullable(Of System.Guid),  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdById As Nullable(Of System.Guid),  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal sumofdebit As Nullable(Of Decimal))
            'This is the placeholder for method implementation.
            HttpContext.Current.Session("acdcode") = ActionArgs.Current.Item("acdcode").NewValue
            HttpContext.Current.Session("branch") = ActionArgs.Current.Item("branch").NewValue
            HttpContext.Current.Session("sgm") = ActionArgs.Current.Item("sgm").NewValue

			        Dim dbinerto As New dblayer
                    Dim xinsert As Boolean
                    Dim sqlstatment As String
            sqlstatment = " delete [dbo].[schvchdlydetailregtmp] where branch=" & ActionArgs.Current.Item("branch").NewValue
			               xinsert = dbinerto.delete(sqlstatment)
						   sqlstatment = "INSERT INTO [dbo].[schvchdlydetailregtmp] ([schvchdlyhdregid] ,[branch] ,[acdcode] ,[StudentCode] ,[FatherCode] ,[Trsd_Dt] ,[schpaymenttypeid] ,[Mony_Paid],[Notes] ,[totalbalance] ,[Sumofdebitcal] ,[Sumofdebitcal1] ,[Sumofcerditcal] ,[totalbalance1])" & _
                           " SELECT  [schvchdlyhdregid] ,[branch] ,[acdcode] ,[StudentCode],[FatherCode]  ,[Trsd_Dt]      ,[schpaymenttypeid]      ,[Mony_Paid]      ,[Notes]      ,[totalbalance]      ,[Sumofdebitcal]      ,[Sumofdebitcal1]      ,[Sumofcerditcal]      ,[totalbalance1]  FROM [dbo].[schvchdlydetailreg]" & _
                            " where  acdcode>0 and branch>0 and  schvchdlyhdregid=" & ActionArgs.Current.Item("schvchdlyhdregid").NewValue 
                        ' " VALUES (" & ActionArgs.Current.Item("schvchdlyhdregid").NewValue & "," & tekost & ")"
                        xinsert = dbinerto.Insert(sqlstatment)
            Dim sqlstatmentcheck As String
            sqlstatmentcheck = "select count(*) as tecko from schvchdlydetailregtmp  where  schvchdlyhdregid=" & ActionArgs.Current.Item("schvchdlyhdregid").NewValue & ""
            Dim tekost As Object
            tekost = DataLogic.GetValue(sqlstatmentcheck)
            If IsNothing(tekost)=false Then

                If tekost > 0 Then
                    Dim i, lasti As Integer
                    If tekost < 7 Then
                        lasti = 6 - tekost
                    End If
                    
                    'sqlstatmentcheck = "select max(StudentCode),acdcode,branch,schvchdlyhdregid from schvchdlydetailreg  where  acdcode>0 and branch>0 and  schvchdlyhdregid=" & ActionArgs.Current.Item("schvchdlyhdregid").NewValue & " group by acdcode,branch,schvchdlyhdregid"
                    ''tekost = DataLogic.GetValue(sqlstatmentcheck)
                    For i = 1 To lasti

                        sqlstatment = "INSERT INTO [schvchdlydetailregtmp] (StudentCode,acdcode,branch,schvchdlyhdregid)" & _
                        "select max(StudentCode),acdcode,branch,schvchdlyhdregid from schvchdlydetailreg  where  acdcode>0 and branch>0 and  schvchdlyhdregid=" & ActionArgs.Current.Item("schvchdlyhdregid").NewValue & " group by acdcode,branch,schvchdlyhdregid"
                        ' " VALUES (" & ActionArgs.Current.Item("schvchdlyhdregid").NewValue & "," & tekost & ")"
                        xinsert = dbinerto.Insert(sqlstatment)
                    Next i
                End If
            End If
            Dim sosostr As String
			Dim sosoname As String
            sosostr = ActionArgs.Current.Item("schvchdlyhdregid").NewValue
            sosoname = ActionArgs.Current.Item("sgm").NewValue
            'MsgBox(sosostr & "    " & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
            'Result.NavigateUrl = "~/crystalviewer/ViewReportcon.aspx?repName=Contractscalc&nemo=" & sosostr
            Result.NavigateUrl = "webreportviwer.aspx?reportquery=schvchdlyhdreg&idfilter=" & sosostr & "&sosoname=" & sosoname
            Result.continue
        End Sub
    End Class
End Namespace
