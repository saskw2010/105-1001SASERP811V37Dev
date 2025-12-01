Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security
Imports eZee.Data.Objects
Namespace eZee.Rules
    
    Partial Public Class handschvchdlydetailpayment
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view before an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("r101")>  _
        Public Sub r101Implementation( _
                    ByVal schvchdlydetailpaymentid As Nullable(Of Long),  _
                    ByVal schvchdlyhdregid As Nullable(Of Long),  _
                    ByVal schvchdlyhdregDelevername As String,  _
                    ByVal schvchdlyhdregsgmsgm_Nm As String,  _
                    ByVal schvchdlyhdregsgmOpcoOpcoName As String,  _
                    ByVal schvchdlyhdregIDregorgNAME_1 As String,  _
                    ByVal schvchdlyhdregacdAcademicYear As String,  _
                    ByVal schvchdlyhdregacdGlFinperiodFin_period_info As String,  _
                    ByVal schvchdlyhdregbranchDesc1 As String,  _
                    ByVal schvchdlyhdregbranchsgmsgm_Nm As String,  _
                    ByVal schvchdlyhdregbranchGenderGender As String,  _
                    ByVal schvchdlyhdregbranchstageShortDesc1 As String,  _
                    ByVal schvchdlyhdregbranchschtypschtypDesc As String,  _
                    ByVal pymnt_No As Nullable(Of Long),  _
                    ByVal pymnt_Pymnt_Nm As String,  _
                    ByVal pymnt_pymnt_accAcc_Nm As String,  _
                    ByVal pymnt_pymnt_accClsacc_Acc_Nm As String,  _
                    ByVal pymnt_pymnt_accAcc_BndAcc_Nm As String,  _
                    ByVal pymnt_sgmsgm_Nm As String,  _
                    ByVal pymnt_sgmOpcoOpcoName As String,  _
                    ByVal paymentwaynumber As String,  _
                    ByVal cstyp_no As Nullable(Of Long),  _
                    ByVal cstyp_SubledgerDescrption As String,  _
                    ByVal subaccountno As Nullable(Of Long),  _
                    ByVal acc_no As Nullable(Of Long),  _
                    ByVal acc_Acc_Nm As String,  _
                    ByVal acc_Clsacc_Acc_Nm As String,  _
                    ByVal acc_Acc_BndAcc_Nm As String,  _
                    ByVal acc_Acc_Bndaccclassaccountclass As String,  _
                    ByVal acc_Acc_BndAcc_BabAcc_Nm As String,  _
                    ByVal schBnk_No As Nullable(Of Long),  _
                    ByVal schBnk_schBnk_Nm As String,  _
                    ByVal checkAccount As String,  _
                    ByVal checkdate As Nullable(Of DateTime),  _
                    ByVal moneypaidto As Nullable(Of Decimal),  _
                    ByVal paymentnotes As String,  _
                    ByVal deposername As String,  _
                    ByVal depositflage As Nullable(Of Boolean),  _
                    ByVal depositdate As Nullable(Of DateTime),  _
                    ByVal branch1 As Nullable(Of Long),  _
                    ByVal acdcode1 As Nullable(Of Long),  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal schvchdlyhdregReferanceNo As Nullable(Of Long))
            'This is the placeholder for method implementation.
			
			If IsNothing(moneypaidto) Then
			moneypaidto=0
			end if
			If IsNothing(acc_no) Then
	
            Else
            If IsNothing(ActionArgs.Current.Item("cstyp_no").NewValue) Then
            Else
                If IsNothing(ActionArgs.Current.Item("subaccountno").NewValue ) Then
				else
				'---------------------------------------------------------------
				'-------------------------------------------------------------------------------------------------
			Dim creditvalue As Double
            Dim debitvalue As Double
          
            creditvalue = 0
            debitvalue = 0
            Using calc As SqlText = New SqlText(
                    "select sum(tr_db) " +
                    "from [glstatment] where acc_no=@acc_no and subaccountno=@subaccountno and cstyp_no=@cstyp_no ")
                calc.AddParameter("@acc_no", acc_no)
				 calc.AddParameter("@cstyp_no", cstyp_no)
				  calc.AddParameter("@subaccountno", subaccountno)
				  
                Dim total As Object = calc.ExecuteScalar()
                If DBNull.Value.Equals(total) Then
                    debitvalue = 0+moneypaidto
                Else

                   
                    debitvalue = Convert.ToDecimal(total)+moneypaidto
                End If
            End Using
            Using calc1 As SqlText = New SqlText(
                    "select sum(tr_cr) " +
                      "from [glstatment] where acc_no=@acc_no and subaccountno=@subaccountno and cstyp_no=@cstyp_no ")
                            calc1.AddParameter("@acc_no", acc_no)
                            calc1.AddParameter("@cstyp_no", cstyp_no)
                            calc1.AddParameter("@subaccountno", subaccountno)
                Dim total1 As Object = calc1.ExecuteScalar()
                If DBNull.Value.Equals(total1) Then

                    creditvalue = 0
                Else
                    creditvalue = Convert.ToDecimal(total1)

                End If
            End Using
				'---------------------------------------------------------------------------------------
				'----------------------------------------------------------------------------------
				
                    
                        If debitvalue > creditvalue Then
                            PreventDefault()
                            Result.Focus("moneypaidto", translatemeyamosso.GetResourceValuemosso("The paid Money More Than creditvalue  "))
							
                        End If
                   
                End If
            End If
			end if
        End Sub
    End Class
End Namespace
