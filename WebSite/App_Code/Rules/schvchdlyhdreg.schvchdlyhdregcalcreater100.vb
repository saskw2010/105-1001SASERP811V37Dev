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
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Calculate" and argument that matches "createForm1".
        ''' </summary>
        <Rule("schvchdlyhdregcalcreater100")>  _
        Public Sub schvchdlyhdregcalcreater100Implementation( _
                    ByVal schvchdlyhdregid As Nullable(Of Long),  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal sgmsgm_Nm As String,  _
                    ByVal sgmOpcoOpcoName As String,  _
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
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal sumofdebit As Nullable(Of Decimal))
            'This is the placeholder for method implementation.
             'Result.ShowAlert()
			if ActionArgs.Current.CommandArgument="ReferanceNo" then
             if ActionArgs.Current.Item("approved").Value=True then
			else
                If IsNothing(branch) = False And IsNothing(sgm) = False Then
                    UpdateFieldValue("ReferanceNo", 0)

                    Using calc As SqlText = New SqlText(
                            "select max(ReferanceNo) " +
                            "from [schvchReferancno] where sgm=@sgm")
                        calc.AddParameter("@sgm", sgm)
                        Dim total As Object = calc.ExecuteScalar()
                        If DBNull.Value.Equals(total) Then

                            UpdateFieldValue("ReferanceNo",1)
                        Else

                            UpdateFieldValue("ReferanceNo", Convert.ToDecimal(total) + 1)
                        End If
                    End Using
                End If
				end if
            End If
            '----------------------------------------------checkbalance
            'UpdateFieldValue("Balance", 0)
            'UpdateFieldValue("sumofdebit", 0)
            'Using calc As SqlText = New SqlText(
            '        "select sum(Mony_Paid) " +
            '        "from [schvchdlydetailreg] where schvchdlyhdregid=@schvchdlyhdregid")
            '    calc.AddParameter("@schvchdlyhdregid", schvchdlyhdregid)
            '    Dim total As Object = calc.ExecuteScalar()
            '    If DBNull.Value.Equals(total) Then

            '        UpdateFieldValue("sumofdebit", 0)
            '    Else

            '        UpdateFieldValue("sumofdebit", Convert.ToDecimal(total))
            '    End If
            'End Using
            'Using calc1 As SqlText = New SqlText(
            '        "select sum(moneypaidto) " +
            '        "from [schvchdlydetailpayment] where schvchdlyhdregid=@schvchdlyhdregid")
            '    calc1.AddParameter("@schvchdlyhdregid", schvchdlyhdregid)
            '    Dim total1 As Object = calc1.ExecuteScalar()
            '    If DBNull.Value.Equals(total1) Then

            '        UpdateFieldValue("Balance", 0)
            '    Else
            '        UpdateFieldValue("Balance", Convert.ToDecimal(total1))

            '    End If
            'End Using
            'then complete 
        End Sub
	
    End Class
End Namespace
