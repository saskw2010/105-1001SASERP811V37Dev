Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schvchdlydetailpayment1001BusinessRules
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
                    ByVal depositRefNo As String,  _
                    ByVal depositAcc_no As Nullable(Of Long),  _
                    ByVal depositnotes As String,  _
                    ByVal cSMSUP_NM As String,  _
                    ByVal depositflage1 As Nullable(Of Long),  _
                    ByVal auditing As Nullable(Of Boolean),  _
                    ByVal auditnotes As String,  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal schvchdlyhdregReferanceNo As Nullable(Of Long))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
