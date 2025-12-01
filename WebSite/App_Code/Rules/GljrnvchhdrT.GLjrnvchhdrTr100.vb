Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class GljrnvchhdrTBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view before an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("GLjrnvchhdrTr100")>  _
        Public Sub GLjrnvchhdrTr100Implementation( _
                    ByVal tr_No As Nullable(Of Long),  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal sgmsgm_Nm As String,  _
                    ByVal sgmOpcoOpcoName As String,  _
                    ByVal jr_Ty As Nullable(Of Long),  _
                    ByVal theJr_TyJrty_Nme As String,  _
                    ByVal glFinperiodID As Nullable(Of Long),  _
                    ByVal glFinperiodFin_period_info As String,  _
                    ByVal glFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal glFinperiodaccountnumberClsacc_Acc_Nm As String,  _
                    ByVal glFinperiodaccountnumberAcc_BndAcc_Nm As String,  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal manualcode As String,  _
                    ByVal tr_Ds As String,  _
                    ByVal balance As Nullable(Of Decimal),  _
                    ByVal notes As String,  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal posted As Nullable(Of Boolean),  _
                    ByVal deleted As Nullable(Of Boolean),  _
                    ByVal havdetails As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchschtypschtypDesc As String)
            'This is the placeholder for method implementation.
			UpdateFieldValue("havdetails",false)
            UpdateFieldValue("approved", false)
			dim debitvalue as double
			dim creditvalue as double
            Using calc As SqlText = New SqlText(
                    "select sum(Tr_db) " +
                    "from [GLjrnvchT] where tr_No=@tr_No")
                calc.AddParameter("@tr_No", tr_No)
                Dim total As Object = calc.ExecuteScalar()
                If DBNull.Value.Equals(total) Then
                   debitvalue= 0
                Else

                    debitvalue = Convert.ToDecimal(total)
                End If
            End Using
            Using calc1 As SqlText = New SqlText(
                    "select sum(tr_cr) " +
                    "from [GLjrnvchT] where tr_No=@tr_No")
                calc1.AddParameter("@tr_No", tr_No)
                Dim total1 As Object = calc1.ExecuteScalar()
                If DBNull.Value.Equals(total1) Then

                   creditvalue = 0
                Else
                   creditvalue = Convert.ToDecimal(total1)

                End If
            End Using
            If posted = True Then
                PreventDefault()
                Result.ShowAlert(translatemeyamosso.GetResourceValuemosso("The Voucher has been posted "))
            Else
            'HttpContext.Current.Session("acdcode") = ActionArgs.Current.Item("acdcode").NewValue
            'HttpContext.Current.Session("branch") = ActionArgs.Current.Item("branch").NewValue
            'HttpContext.Current.Session("sgm") = ActionArgs.Current.Item("sgm").NewValue
                If creditvalue = debitvalue Then
                    If debitvalue > 0 Then
                        UpdateFieldValue("approved", True)
                        UpdateFieldValue("balance", debitvalue)
						UpdateFieldValue("havdetails", True)
                    End If
                Else
                    PreventDefault()
                    Result.Focus("Balance", translatemeyamosso.GetResourceValuemosso("The Voucher Not balance sum thing is error"))
                End If
                End If
        End Sub
    End Class
End Namespace
