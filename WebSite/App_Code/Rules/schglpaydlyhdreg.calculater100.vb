Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schglpaydlyhdregBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in the view with id matching "editForm1" for an action
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("calculater100")>  _
        Public Sub calculater100Implementation( _
                    ByVal schglpaydlyhdregid As Nullable(Of Long),  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal sgmsgm_Nm As String,  _
                    ByVal sgmOpcoOpcoName As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal balance As Nullable(Of Decimal),  _
                    ByVal referanceNo As String,  _
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
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String)
            'This is the placeholder for method implementation.
            If ActionArgs.Current.CommandArgument = "payReferanceNo" Then
                If ActionArgs.Current.Item("approved").Value = True Then
                Else
                    If IsNothing(branch) = False And IsNothing(sgm) = False Then
                        UpdateFieldValue("payReferanceNo", 0)

                        Using calc As SqlText = New SqlText(
                                "select max(payReferanceNo) " +
                                "from [schglpaydlyhdreg] where approved=1 and deleted=0 and Pymnt_No=@paymentway and sgm=@sgm")
                            calc.AddParameter("@sgm", sgm)
                            calc.AddParameter("@paymentway", ActionArgs.Current.Item("Pymnt_No").Value)

                            Dim total As Object = calc.ExecuteScalar()
                            If DBNull.Value.Equals(total) Then

                                UpdateFieldValue("payReferanceNo", 1)
                            Else

                                UpdateFieldValue("payReferanceNo", Convert.ToDecimal(total) + 1)
                            End If
                        End Using
                    End If
                End If
            End If
			  UpdateFieldValue("payBalance", 0)
            UpdateFieldValue("sumofdebit", 0)
            Using calc As SqlText = New SqlText(
                    "select sum(Mony_Paid) " +
                    "from [schglpaydlydetailreg] where schglpaydlyhdregid=@schglpaydlyhdregid")
                calc.AddParameter("@schglpaydlyhdregid", schglpaydlyhdregid)
                Dim total As Object = calc.ExecuteScalar()
                If DBNull.Value.Equals(total) Then

                    UpdateFieldValue("sumofdebit", 0)
                Else

                    UpdateFieldValue("sumofdebit", Convert.ToDecimal(total))
                End If
            End Using
            Using calc1 As SqlText = New SqlText(
                    "select sum(moneypaidto) " +
                    "from [schglpaydlydetailpayment] where schglpaydlyhdregid=@schglpaydlyhdregid")
                calc1.AddParameter("@schglpaydlyhdregid", schglpaydlyhdregid)
                Dim total1 As Object = calc1.ExecuteScalar()
                If DBNull.Value.Equals(total1) Then

                    UpdateFieldValue("payBalance", 0)
                Else
                    UpdateFieldValue("payBalance", Convert.ToDecimal(total1))

                End If
            End Using
        End Sub
    End Class
End Namespace
