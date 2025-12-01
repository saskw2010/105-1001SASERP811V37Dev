Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schglvchdlyhdregBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view before an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("schglvchdlyhdregr100")> _
        Public Sub schglvchdlyhdregr100Implementation( _
                    ByVal schglvchdlyhdregid As Nullable(Of Long), _
                    ByVal trs_Dt As Nullable(Of DateTime), _
                    ByVal balance As Nullable(Of Decimal), _
                    ByVal referanceNo As String, _
                    ByVal iDregorg As Nullable(Of Long), _
                    ByVal iDregorgNAME_1 As String, _
                    ByVal delevername As String, _
                    ByVal delevercivil As String, _
                    ByVal deleverTel As String, _
                    ByVal notes As String, _
                    ByVal approved As Nullable(Of Boolean), _
                    ByVal posted As Nullable(Of Boolean), _
                    ByVal deleted As Nullable(Of Boolean), _
                    ByVal havdetails As Nullable(Of Boolean), _
                    ByVal modifiedBy As String, _
                    ByVal modifiedOn As Nullable(Of DateTime), _
                    ByVal createdBy As String, _
                    ByVal createdOn As Nullable(Of DateTime), _
                    ByVal branch As Nullable(Of Long), _
                    ByVal thebranchDesc1 As String, _
                    ByVal thebranchsgmsgm_Nm As String, _
                    ByVal thebranchsgmOpcoOpcoName As String, _
                    ByVal thebranchGenderGender As String, _
                    ByVal thebranchstageShortDesc1 As String, _
                    ByVal thebranchschtypschtypDesc As String, _
                    ByVal sgm As Nullable(Of Long), _
                    ByVal sgmsgm_Nm As String, _
                    ByVal sgmOpcoOpcoName As String, _
                    ByVal acdcode As Nullable(Of Long), _
                    ByVal acdAcademicYear As String, _
                    ByVal sumofdebit As Nullable(Of Decimal), _
                    ByVal acdGlFinperiodFin_period_info As String, _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String)
            'This is the placeholder for method implementation.
            If posted = True Then
                PreventDefault()
                Result.ShowAlert(translatemeyamosso.GetResourceValuemosso("The Voucher has been posted "))
            Else
                '-------------------check balance
                UpdateFieldValue("approved", False)
                UpdateFieldValue("havdetails", False)
                UpdateFieldValue("Balance", 0)
                UpdateFieldValue("sumofdebit", 0)
                balance = 0
                Using calc As SqlText = New SqlText(
                        "select sum(Mony_Paid) " +
                        "from [schglvchdlydetailreg] where Schglvchdlyhdregid=@Schglvchdlyhdregid")
                    calc.AddParameter("@Schglvchdlyhdregid", schglvchdlyhdregid)
                    Dim total As Object = calc.ExecuteScalar()
                    If DBNull.Value.Equals(total) Then

                        UpdateFieldValue("sumofdebit", 0)
                        sumofdebit = 0
                    Else

                        UpdateFieldValue("sumofdebit", Convert.ToDecimal(total))
                        sumofdebit = Convert.ToDecimal(total)
                    End If
                End Using
                Using calc1 As SqlText = New SqlText(
                        "select sum(moneypaidto) " +
                        "from [schglvchdlydetailpayment] where Schglvchdlyhdregid=@Schglvchdlyhdregid")
                    calc1.AddParameter("@Schglvchdlyhdregid", schglvchdlyhdregid)
                    Dim total1 As Object = calc1.ExecuteScalar()
                    If DBNull.Value.Equals(total1) Then

                        UpdateFieldValue("Balance", 0)
                        balance = 0
                    Else
                        UpdateFieldValue("Balance", Convert.ToDecimal(total1))
                        balance = Convert.ToDecimal(total1)
                    End If
                End Using
                '0------------------------
                If balance = sumofdebit Then
                    If balance > 0 Then
                        UpdateFieldValue("approved", True)
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
