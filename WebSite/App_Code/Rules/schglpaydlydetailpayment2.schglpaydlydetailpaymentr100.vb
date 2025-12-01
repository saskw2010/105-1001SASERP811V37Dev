Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schglpaydlydetailpayment2BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("schglpaydlydetailpaymentr100")>  _
        Public Sub schglpaydlydetailpaymentr100Implementation( _
                    ByVal schglpaydlydetailpaymentid As Nullable(Of Long),  _
                    ByVal schglpaydlyhdregid As Nullable(Of Long),  _
                    ByVal schglpaydlyhdregpayDelevername As String,  _
                    ByVal schglpaydlyhdregsgmsgm_Nm As String,  _
                    ByVal schglpaydlyhdregsgmOpcoOpcoName As String,  _
                    ByVal schglpaydlyhdregPymnt_Pymnt_Nm As String,  _
                    ByVal schglpaydlyhdregPymnt_pymnt_accAcc_Nm As String,  _
                    ByVal schglpaydlyhdregPymnt_sgmsgm_Nm As String,  _
                    ByVal schglpaydlyhdregpayIDregorgNAME_1 As String,  _
                    ByVal schglpaydlyhdregacdAcademicYear As String,  _
                    ByVal schglpaydlyhdregacdGlFinperiodFin_period_info As String,  _
                    ByVal schglpaydlyhdregbranchDesc1 As String,  _
                    ByVal schglpaydlyhdregbranchsgmsgm_Nm As String,  _
                    ByVal schglpaydlyhdregbranchGenderGender As String,  _
                    ByVal schglpaydlyhdregbranchstageShortDesc1 As String,  _
                    ByVal schglpaydlyhdregbranchschtypschtypDesc As String,  _
                    ByVal pymnt_No As Nullable(Of Long),  _
                    ByVal pymnt_Pymnt_Nm As String,  _
                    ByVal pymnt_pymnt_accAcc_Nm As String,  _
                    ByVal pymnt_pymnt_accClsacc_Acc_Nm As String,  _
                    ByVal pymnt_pymnt_accAcc_BndAcc_Nm As String,  _
                    ByVal pymnt_sgmsgm_Nm As String,  _
                    ByVal pymnt_sgmOpcoOpcoName As String,  _
                    ByVal acc_no As Nullable(Of Long),  _
                    ByVal acc_Acc_Nm As String,  _
                    ByVal acc_Clsacc_Acc_Nm As String,  _
                    ByVal acc_Acc_BndAcc_Nm As String,  _
                    ByVal acc_Acc_Bndaccclassaccountclass As String,  _
                    ByVal acc_Acc_BndAcc_BabAcc_Nm As String,  _
                    ByVal paymentwaynumber As String,  _
                    ByVal schBnk_No As Nullable(Of Long),  _
                    ByVal schBnk_schBnk_Nm As String,  _
                    ByVal checkAccount As Nullable(Of Long),  _
                    ByVal checkdate As Nullable(Of DateTime),  _
                    ByVal moneypaidto As Nullable(Of Decimal),  _
                    ByVal paymentnotes As String,  _
                    ByVal cstyp_no As Nullable(Of Long),  _
                    ByVal subaccountno As Nullable(Of Long),  _
                    ByVal glcostcntr As Nullable(Of Long),  _
                    ByVal glcostcntrCostcntr_Nm As String,  _
                    ByVal glcostcntrcost_typCostcntr_Nm As String,  _
                    ByVal glcostcntr1 As Nullable(Of Long),  _
                    ByVal glcostcntr1Costcntr_Nm As String,  _
                    ByVal glcostcntr1cost_typCostcntr_Nm As String,  _
                    ByVal recivename As String,  _
                    ByVal recivedflage As Nullable(Of Boolean),  _
                    ByVal reciveddate As Nullable(Of DateTime),  _
                    ByVal auditing As Nullable(Of Boolean),  _
                    ByVal auditnotes As String)
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
