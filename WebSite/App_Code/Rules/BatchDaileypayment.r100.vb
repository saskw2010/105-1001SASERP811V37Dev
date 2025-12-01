Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class BatchDaileypaymentBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("r100")>  _
        Public Sub r100Implementation( _
                    ByVal batchDaileypayment As Nullable(Of Long),  _
                    ByVal batchstartdate As Nullable(Of DateTime),  _
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
                    ByVal acc_no As Nullable(Of Long),  _
                    ByVal acc_Acc_Nm As String,  _
                    ByVal acc_Clsacc_Acc_Nm As String,  _
                    ByVal acc_Acc_BndAcc_Nm As String,  _
                    ByVal acc_Acc_Bndaccclassaccountclass As String,  _
                    ByVal acc_Acc_BndAcc_BabAcc_Nm As String,  _
                    ByVal balancesuppose As Nullable(Of Decimal),  _
                    ByVal notes As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal recivedMoney As Nullable(Of Decimal),  _
                    ByVal recievedDate As Nullable(Of DateTime),  _
                    ByVal pymnt_No As Nullable(Of Long),  _
                    ByVal pymnt_Pymnt_Nm As String,  _
                    ByVal pymnt_pymnt_accAcc_Nm As String,  _
                    ByVal pymnt_pymnt_accClsacc_Acc_Nm As String,  _
                    ByVal pymnt_pymnt_accAcc_BndAcc_Nm As String,  _
                    ByVal pymnt_sgmsgm_Nm As String,  _
                    ByVal pymnt_sgmOpcoOpcoName As String,  _
                    ByVal paymentwaynumber As String,  _
                    ByVal schBnk_No As Nullable(Of Long),  _
                    ByVal checkAccount As String,  _
                    ByVal checkdate As Nullable(Of DateTime),  _
                    ByVal paymentnotes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal batchapproved As Nullable(Of Boolean),  _
                    ByVal batchposted As Nullable(Of Boolean),  _
                    ByVal batchdeleted As Nullable(Of Boolean),  _
                    ByVal batchhavdetails As Nullable(Of Boolean),  _
                    ByVal cstyp_NO As Nullable(Of Long),  _
                    ByVal cstyp_SubledgerDescrption As String,  _
                    ByVal cSMSUP_NO As Nullable(Of Long))
            'This is the placeholder for method implementation.
			  UpdateFieldValue("RecivedMoney", 0)
            
            Using calc As SqlText = New SqlText(
                    "select sum(Amounttransaction) " +
                    "from [BatchDaileypaymentDetailes] where BatchDaileypayment=@BatchDaileypayment")
                calc.AddParameter("@BatchDaileypayment", BatchDaileypayment)
                Dim total As Object = calc.ExecuteScalar()
                If DBNull.Value.Equals(total) Then

                    UpdateFieldValue("RecivedMoney", 0)
                Else

                    UpdateFieldValue("RecivedMoney", Convert.ToDecimal(total))
                End If
            End Using
        End Sub
    End Class
End Namespace
