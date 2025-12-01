Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schpaydlyhdregBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view before an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("schpaydlyhdregr100")>  _
        Public Sub schpaydlyhdregr100Implementation( _
                    ByVal schpaydlyhdregid As Nullable(Of Long),  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal sgmsgm_Nm As String,  _
                    ByVal sgmOpcoOpcoName As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal referanceNo As String,  _
                    ByVal iDregorg As Nullable(Of Long),  _
                    ByVal iDregorgNAME_1 As String,  _
                    ByVal delevername As String,  _
                    ByVal delevercivil As String,  _
                    ByVal deleverTel As String,  _
                    ByVal notes1 As String,  _
                    ByVal balance As Nullable(Of Decimal),  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal posted As Nullable(Of Boolean),  _
                    ByVal deleted As Nullable(Of Boolean),  _
                    ByVal havdetails As Nullable(Of Boolean))
            'This is the placeholder for method implementation.
			UpdateFieldValue("havdetails",false)
            UpdateFieldValue("approved", false)
			dim debitvalue as double
			dim creditvalue as double
            Using calc As SqlText = New SqlText(
                    "select sum(mony_Paid) " +
                    "from [schglpaydlydetailreg] where schglpaydlyhdregid=@schglpaydlyhdregid")
                calc.AddParameter("@schpaydlyhdregid", schpaydlyhdregid)
                Dim total As Object = calc.ExecuteScalar()
                If DBNull.Value.Equals(total) Then
                    debitvalue = 0
                Else

                    debitvalue = Convert.ToDecimal(total)
                End If
            End Using
            Using calc1 As SqlText = New SqlText(
                    "select sum(moneypaidto) " +
                    "from [schvchdlydetailpayment] where schpaydlyhdregid=@schpaydlyhdregid")
                calc1.AddParameter("@schpaydlyhdregid", schpaydlyhdregid)
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
