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
        ''' This method will execute in any view before an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("schvchdlyhdregr100")>  _
        Public Sub schvchdlyhdregr100Implementation(ByVal schvchdlyhdregid As Nullable(Of Long), ByVal trs_Dt As Nullable(Of DateTime), ByVal balance As Nullable(Of Decimal), ByVal notes As String, ByVal approved As Nullable(Of Boolean), ByVal posted As Nullable(Of Boolean), ByVal modifiedBy As String, ByVal modifiedByUserId As Nullable(Of System.Guid), ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdById As Nullable(Of System.Guid), ByVal createdOn As Nullable(Of DateTime), ByVal sumofdebit As Nullable(Of Decimal))
            'This is the placeholder for method implementation.
            Dim creditvalue As Double
            Dim debitvalue As Double
            UpdateFieldValue("approved", False)
            UpdateFieldValue("havdetails", False)
            creditvalue = 0
            UpdateFieldValue("sumofdebit", 0)
            UpdateFieldValue("Balance", 0)
            debitvalue = 0
            Using calc As SqlText = New SqlText(
                    "select sum(Mony_Paid) " +
                    "from [schvchdlydetailreg] where schvchdlyhdregid=@schvchdlyhdregid")
                calc.AddParameter("@schvchdlyhdregid", schvchdlyhdregid)
                Dim total As Object = calc.ExecuteScalar()
                If DBNull.Value.Equals(total) Then

                    UpdateFieldValue("sumofdebit", 0)
                    debitvalue = 0
                Else

                    UpdateFieldValue("sumofdebit", Convert.ToDecimal(total))
                    debitvalue = Convert.ToDecimal(total)
                End If
            End Using
            Using calc1 As SqlText = New SqlText(
                    "select sum(moneypaidto) " +
                    "from [schvchdlydetailpayment] where schvchdlyhdregid=@schvchdlyhdregid")
                calc1.AddParameter("@schvchdlyhdregid", schvchdlyhdregid)
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
            HttpContext.Current.Session("acdcode") = ActionArgs.Current.Item("acdcode").NewValue
            HttpContext.Current.Session("branch") = ActionArgs.Current.Item("branch").NewValue
            HttpContext.Current.Session("sgm") = ActionArgs.Current.Item("sgm").NewValue
                If creditvalue = debitvalue Then
                    If creditvalue > 0 Then
                        UpdateFieldValue("approved", True)
                        UpdateFieldValue("havdetails", True)
                        UpdateFieldValue("Balance", creditvalue)
                    End If
                Else
                    PreventDefault()
                    Result.Focus("Balance", translatemeyamosso.GetResourceValuemosso("The Voucher Not balance sum thing is error"))
                End If
                End If
        End Sub
    End Class
End Namespace
