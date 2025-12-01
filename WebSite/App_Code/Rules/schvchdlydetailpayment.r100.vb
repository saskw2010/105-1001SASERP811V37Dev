Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class handschvchdlydetailpayment
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in the view with id matching "grid1" for an action
        ''' with a command name that matches "Calculate" and argument that matches "schvchdlydetailreg".
        ''' </summary>
        <Rule("r100")>  _
        Public Sub r100Implementation( _
                    ByVal schvchdlydetailpaymentid As Nullable(Of Long),  _
                    ByVal schvchdlyhdregid As Nullable(Of Long),  _
                    ByVal schvchdlyhdregReferanceNo As String,  _
                    ByVal schvchdlyhdregsgmsgm_Nm As String,  _
                    ByVal schvchdlyhdregsgmOpcoOpcoName As String,  _
                    ByVal schvchdlyhdregIDregorgNAME_1 As String,  _
                    ByVal pymnt_No As Nullable(Of Long),  _
                    ByVal pymnt_Pymnt_Nm As String,  _
                    ByVal pymnt_pymnt_accAcc_Nm As String,  _
                    ByVal pymnt_pymnt_accClsacc_Acc_Nm As String,  _
                    ByVal pymnt_pymnt_accAcc_BndAcc_Nm As String,  _
                    ByVal pymnt_sgmsgm_Nm As String,  _
                    ByVal pymnt_sgmOpcoOpcoName As String,  _
                    ByVal paymentwaynumber As String,  _
                    ByVal schBnk_No As Nullable(Of Long),  _
                    ByVal schBnk_schBnk_Nm As String,  _
                    ByVal checkAccount As String,  _
                    ByVal checkdate As Nullable(Of DateTime),  _
                    ByVal moneypaidto As Nullable(Of Decimal),  _
                    ByVal paymentnotes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedByUserId As Nullable(Of System.Guid),  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdById As Nullable(Of System.Guid),  _
                    ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
			'Result.ShowAlert(ActionArgs.Current.CommandArgument)
	
            Using calc As SqlText = New SqlText(
                    "select sum(Mony_Paid) " +
                    "from [schvchdlydetailreg] where schvchdlyhdregid=@schvchdlyhdregid")
                calc.AddParameter("@schvchdlyhdregid", schvchdlyhdregid)
                Dim total As Object = calc.ExecuteScalar()
                If DBNull.Value.Equals(total) Then

                    UpdateFieldValue("moneypaidto", 0)
                Else

                    UpdateFieldValue("moneypaidto", Convert.ToDecimal(total))
                End If
            End Using
        End Sub
    End Class
End Namespace
