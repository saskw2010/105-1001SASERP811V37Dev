Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security
Imports System.IO
Namespace eZee.Rules
    
    Partial Public Class BatchDaileypaymentDetailesBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Select".
        ''' </summary>
        <Rule("r102")>  _
        Public Sub r102Implementation( _
                    ByVal batchDaileypaymentD As Nullable(Of Long),  _
                    ByVal batchDaileypayment As Nullable(Of Long),  _
                    ByVal theBatchDaileypaymentNotes As String,  _
                    ByVal theBatchDaileypaymentacc_Acc_Nm As String,  _
                    ByVal theBatchDaileypaymentacc_Clsacc_Acc_Nm As String,  _
                    ByVal theBatchDaileypaymentacc_Acc_BndAcc_Nm As String,  _
                    ByVal theBatchDaileypaymentsgmsgm_Nm As String,  _
                    ByVal theBatchDaileypaymentsgmOpcoOpcoName As String,  _
                    ByVal theBatchDaileypaymentPymnt_Pymnt_Nm As String,  _
                    ByVal theBatchDaileypaymentPymnt_pymnt_accAcc_Nm As String,  _
                    ByVal theBatchDaileypaymentPymnt_sgmsgm_Nm As String,  _
                    ByVal theBatchDaileypaymentacdAcademicYear As String,  _
                    ByVal theBatchDaileypaymentacdGlFinperiodFin_period_info As String,  _
                    ByVal theBatchDaileypaymentbranchDesc1 As String,  _
                    ByVal theBatchDaileypaymentbranchsgmsgm_Nm As String,  _
                    ByVal theBatchDaileypaymentbranchGenderGender As String,  _
                    ByVal theBatchDaileypaymentbranchstageShortDesc1 As String,  _
                    ByVal theBatchDaileypaymentbranchschtypschtypDesc As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal itmiD As Nullable(Of Long),  _
                    ByVal itmitmDescription As String,  _
                    ByVal itmitmacc_Acc_Nm As String,  _
                    ByVal itmitmacc_Clsacc_Acc_Nm As String,  _
                    ByVal itmitmacc_Acc_BndAcc_Nm As String,  _
                    ByVal cstyp_NO As Nullable(Of Long),  _
                    ByVal cstyp_SubledgerDescrption As String,  _
                    ByVal cSMSUP_NO As Nullable(Of Long),  _
                    ByVal acc_no As Nullable(Of Long),  _
                    ByVal acc_Acc_Nm As String,  _
                    ByVal acc_Clsacc_Acc_Nm As String,  _
                    ByVal acc_Acc_BndAcc_Nm As String,  _
                    ByVal acc_Acc_Bndaccclassaccountclass As String,  _
                    ByVal acc_Acc_BndAcc_BabAcc_Nm As String,  _
                    ByVal transactionDetailes As String,  _
                    ByVal transactiondate As Nullable(Of DateTime),  _
                    ByVal amounttransaction As Nullable(Of Decimal),  _
                    ByVal referanceNo As String,  _
                    ByVal referancedate As Nullable(Of DateTime),  _
                    ByVal companysupplieier As String,  _
                    ByVal glcostcenter1 As Nullable(Of Long),  _
                    ByVal glcostcenter1Costcntr_Nm As String,  _
                    ByVal glcostcenter1cost_typCostcntr_Nm As String,  _
                    ByVal glcostcenter As Nullable(Of Long),  _
                    ByVal glcostcenterCostcntr_Nm As String,  _
                    ByVal glcostcentercost_typCostcntr_Nm As String,  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal externalDocFileName As String,  _
                    ByVal externalDocContentType As String,  _
                    ByVal externalDocLength As Nullable(Of Long))
            'This is the placeholder for method implementation.
			 If Not String.IsNullOrEmpty(externalDocFileName) Then
                UpdateFieldValue("ExternalDoc", BatchDaileypaymentD)
            Else
                UpdateFieldValue("ExternalDoc", String.Format("null|{0}", BatchDaileypaymentD))
            End If
        End Sub
    End Class
End Namespace
