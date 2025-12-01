Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class CardstudentBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view before an action
        ''' with a command name that matches "Cancel".
        ''' </summary>
        <Rule("r101")>  _
        Public Sub r101Implementation(ByVal rosom As Nullable(Of Decimal), ByVal bookrosom As Nullable(Of Decimal), ByVal transportation As Nullable(Of Decimal), ByVal rosomregister As Nullable(Of Decimal), ByVal cash As Nullable(Of Decimal), ByVal keynet As Nullable(Of Decimal), ByVal checkvalue As Nullable(Of Decimal), ByVal checknumber As Nullable(Of Decimal), ByVal transno As Nullable(Of Long))
            'This is the placeholder for method implementation.
             PreventDefault()
			Dim rosomFieldValue As FieldValue = SelectFieldValueObject("rosom")
                    If (Not (rosomFieldValue) Is Nothing) Then
                        rosomFieldValue.Modified = false
                    End If
			        Dim BookrosomFieldValue As FieldValue = SelectFieldValueObject("Bookrosom")
                    If (Not (BookrosomFieldValue) Is Nothing) Then
                        BookrosomFieldValue.Modified = false
                    End If
			        Dim TransportationFieldValue As FieldValue = SelectFieldValueObject("Transportation")
                    If (Not (TransportationFieldValue) Is Nothing) Then
                        TransportationFieldValue.Modified = false
                    End If
					Dim rosomregisterFieldValue As FieldValue = SelectFieldValueObject("rosomregister")
                    If (Not (rosomregisterFieldValue) Is Nothing) Then
                        rosomregisterFieldValue.Modified = false
                    End If
					Dim transnoFieldValue As FieldValue = SelectFieldValueObject("transno")
                    If (Not (transnoFieldValue) Is Nothing) Then
                        transnoFieldValue.Modified = false
                    End If
					Dim CashFieldValue As FieldValue = SelectFieldValueObject("Cash")
                    If (Not (CashFieldValue) Is Nothing) Then
                        CashFieldValue.Modified = false
                    End If
					Dim keynetFieldValue As FieldValue = SelectFieldValueObject("keynet")
                    If (Not (keynetFieldValue) Is Nothing) Then
                        keynetFieldValue.Modified = false
                    End If
					Dim checkvalueFieldValue As FieldValue = SelectFieldValueObject("checkvalue")
                    If (Not (checkvalueFieldValue) Is Nothing) Then
                        checkvalueFieldValue.Modified = false
                    End If
					Dim checknumberFieldValue As FieldValue = SelectFieldValueObject("checknumber")
                    If (Not (checknumberFieldValue) Is Nothing) Then
                        checknumberFieldValue.Modified = false
                    End If
            Dim dbinerto As New dblayer
            Dim xinsert As Boolean
            Dim sqlstatment As String
            Dim sosostr As String
            Dim sosoname As String
            sqlstatment = "update schvchdlydetailreg set Mony_Paid=" & ActionArgs.Current.Item("rosom").NewValue & "  where schvchdlyhdregid=" & ActionArgs.Current.Item("transno").NewValue & " and schpaymenttypeid=2"
            xinsert = dbinerto.Update(sqlstatment)
            sqlstatment = "update schvchdlydetailreg set Mony_Paid=" & ActionArgs.Current.Item("Bookrosom").NewValue & "  where schvchdlyhdregid=" & ActionArgs.Current.Item("transno").NewValue & " and schpaymenttypeid=3"
            xinsert = dbinerto.Update(sqlstatment)
            sqlstatment = "update schvchdlydetailreg set Mony_Paid=" & ActionArgs.Current.Item("Transportation").NewValue & "  where schvchdlyhdregid=" & ActionArgs.Current.Item("transno").NewValue & " and schpaymenttypeid=4"
            xinsert = dbinerto.Update(sqlstatment)
            sqlstatment = "update schvchdlydetailreg set Mony_Paid=" & ActionArgs.Current.Item("rosomregister").NewValue & "  where schvchdlyhdregid=" & ActionArgs.Current.Item("transno").NewValue & " and schpaymenttypeid=1"
            xinsert = dbinerto.Update(sqlstatment)
            ' "~/pages/ReciptVoucher1.aspx?schvchdlyhdregid=" & ActionArgs.Current.Item("transno").NewValue & "&_controller=schvchdlyhdreg&_commandName=Edit&_commandArgument=editForm1"
            'Context.Response.Redirect(Result.NavigateUrl)
			sqlstatment = "delete from schvchdlydetailpayment   where schvchdlyhdregid=" & ActionArgs.Current.Item("transno").NewValue & ""
            xinsert = dbinerto.delete(sqlstatment)
			if isnothing(ActionArgs.Current.Item("Pymnt_No").NewValue) then
			else
			
			'HttpContext.Current.Session("acdcode") = ActionArgs.Current.Item("acdcode").NewValue
            'HttpContext.Current.Session("branch") = ActionArgs.Current.Item("branch").NewValue
            'HttpContext.Current.Session("sgm") = ActionArgs.Current.Item("sgm").NewValue

                    'Dim dbinerto As New dblayer
                    'Dim xinsert As Boolean
                'Dim sqlstatment As String
                Dim moneypaid As Double = ActionArgs.Current.Item("rosom").NewValue + ActionArgs.Current.Item("Bookrosom").NewValue + ActionArgs.Current.Item("Transportation").NewValue + ActionArgs.Current.Item("rosomregister").NewValue

                sqlstatment = "Insert Into schvchdlydetailpayment(schvchdlyhdregid,Pymnt_No,moneypaidto) values(" & ActionArgs.Current.Item("transno").NewValue & "," & ActionArgs.Current.Item("Pymnt_No").NewValue & "," & moneypaid & ")"
                xinsert = dbinerto.Insert(sqlstatment)
                If ActionArgs.Current.Item("Pymnt_No").NewValue = 1 Then

                    sqlstatment = " delete [dbo].[schvchdlydetailregtmp] where branch=" & HttpContext.Current.Session("branch")
                    xinsert = dbinerto.Delete(sqlstatment)
                    sqlstatment = "INSERT INTO [dbo].[schvchdlydetailregtmp] ([schvchdlyhdregid] ,[branch] ,[acdcode] ,[StudentCode] ,[FatherCode] ,[Trsd_Dt] ,[schpaymenttypeid] ,[Mony_Paid],[Notes] ,[totalbalance] ,[Sumofdebitcal] ,[Sumofdebitcal1] ,[Sumofcerditcal] ,[totalbalance1])" & _
                    " SELECT  [schvchdlyhdregid] ,[branch] ,[acdcode] ,[StudentCode],[FatherCode]  ,[Trsd_Dt]      ,[schpaymenttypeid]      ,[Mony_Paid]      ,[Notes]      ,[totalbalance]      ,[Sumofdebitcal]      ,[Sumofdebitcal1]      ,[Sumofcerditcal]      ,[totalbalance1]  FROM [dbo].[schvchdlydetailreg]" & _
                     " where  acdcode>0 and branch>0 and  schvchdlyhdregid=" & ActionArgs.Current.Item("transno").NewValue
                    ' " VALUES (" & ActionArgs.Current.Item("transno").NewValue & "," & tekost & ")"
                    xinsert = dbinerto.Insert(sqlstatment)
                    Dim sqlstatmentcheck As String
                    sqlstatmentcheck = "select count(*) as tecko from schvchdlydetailregtmp  where  schvchdlyhdregid=" & ActionArgs.Current.Item("transno").NewValue & ""
                    Dim tekost As Object
                    tekost = DataLogic.GetValue(sqlstatmentcheck)
                    If IsNothing(tekost) = False Then

                        If tekost > 0 Then
                            Dim i, lasti As Integer
                            If tekost < 7 Then
                                lasti = 6 - tekost
                            End If

                            'sqlstatmentcheck = "select max(StudentCode),acdcode,branch,schvchdlyhdregid from schvchdlydetailreg  where  acdcode>0 and branch>0 and  schvchdlyhdregid=" & ActionArgs.Current.Item("transno").NewValue & " group by acdcode,branch,schvchdlyhdregid"
                            ''tekost = DataLogic.GetValue(sqlstatmentcheck)
                            For i = 1 To lasti

                                sqlstatment = "INSERT INTO [schvchdlydetailregtmp] (StudentCode,acdcode,branch,schvchdlyhdregid)" & _
                                "select max(StudentCode),acdcode,branch,schvchdlyhdregid from schvchdlydetailreg  where  acdcode>0 and branch>0 and  schvchdlyhdregid=" & ActionArgs.Current.Item("transno").NewValue & " group by acdcode,branch,schvchdlyhdregid"
                                ' " VALUES (" & ActionArgs.Current.Item("transno").NewValue & "," & tekost & ")"
                                xinsert = dbinerto.Insert(sqlstatment)
                            Next i
                        End If
                    End If

                    sosostr = ActionArgs.Current.Item("transno").NewValue
                    sosoname = HttpContext.Current.Session("sgm")
                    'MsgBox(sosostr & "    " & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
                    'Result.NavigateUrl = "~/crystalviewer/ViewReportcon.aspx?repName=Contractscalc&nemo=" & sosostr

                End If
			end if
		   Result.HideModal()
           Result.ExecuteOnClient( _
            String.Format("$find('{0}').goToPage(-1)", _
            Context.Session("ControllerID")))
            Result.RefreshChildren()
            If ActionArgs.Current.Item("Pymnt_No").NewValue = 1 Then
                Result.NavigateUrl = "webreportviwer.aspx?reportquery=schvchdlyhdreg&idfilter=" & sosostr & "&sosoname=" & sosoname
            End If
        End Sub
    End Class
End Namespace
