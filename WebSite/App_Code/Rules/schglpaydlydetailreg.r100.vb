Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schglpaydlydetailregBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view before an action
        ''' with a command name that matches "Insert".
        ''' </summary>
        <Rule("r100")>  _
        Public Sub r100Implementation( _
                    ByVal trs_No As Nullable(Of Long),  _
                    ByVal schglpaydlyhdregid As Nullable(Of Long),  _
                    ByVal schglpaydlyhdregpayDelevername As String,  _
                    ByVal schglpaydlyhdregsgmsgm_Nm As String,  _
                    ByVal schglpaydlyhdregsgmOpcoOpcoName As String,  _
                    ByVal schglpaydlyhdregpayIDregorgNAME_1 As String,  _
                    ByVal schglpaydlyhdregacdAcademicYear As String,  _
                    ByVal schglpaydlyhdregacdGlFinperiodFin_period_info As String,  _
                    ByVal schglpaydlyhdregbranchDesc1 As String,  _
                    ByVal schglpaydlyhdregbranchsgmsgm_Nm As String,  _
                    ByVal schglpaydlyhdregbranchGenderGender As String,  _
                    ByVal schglpaydlyhdregbranchstageShortDesc1 As String,  _
                    ByVal schglpaydlyhdregbranchschtypschtypDesc As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdFin_period_info As String,  _
                    ByVal acdaccountnumberAcc_Nm As String,  _
                    ByVal acdaccountnumberClsacc_Acc_Nm As String,  _
                    ByVal acdaccountnumberAcc_BndAcc_Nm As String,  _
                    ByVal acc_no As Nullable(Of Long),  _
                    ByVal acc_Acc_Nm As String,  _
                    ByVal acc_Clsacc_Acc_Nm As String,  _
                    ByVal acc_Acc_BndAcc_Nm As String,  _
                    ByVal acc_Acc_Bndaccclassaccountclass As String,  _
                    ByVal acc_Acc_BndAcc_BabAcc_Nm As String,  _
                    ByVal cstyp_no As Nullable(Of Long),  _
                    ByVal subaccountno As Nullable(Of Long),  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal schpaymenttypeid As Nullable(Of Long),  _
                    ByVal schpaymenttypeschpaymenttypenm As String,  _
                    ByVal schpaymenttypedebitaccountAcc_Nm As String,  _
                    ByVal schpaymenttypedebitaccountClsacc_Acc_Nm As String,  _
                    ByVal schpaymenttypedebitaccountAcc_BndAcc_Nm As String,  _
                    ByVal schpaymenttypecreditaccountAcc_Nm As String,  _
                    ByVal schpaymenttypecreditaccountClsacc_Acc_Nm As String,  _
                    ByVal schpaymenttypecreditaccountAcc_BndAcc_Nm As String,  _
                    ByVal mony_Paid As Nullable(Of Decimal),  _
                    ByVal notes As String,  _
                    ByVal glcostcntr As Nullable(Of Long),  _
                    ByVal glcostcntrCostcntr_Nm As String,  _
                    ByVal glcostcntrcost_typCostcntr_Nm As String,  _
                    ByVal glcostcntr1 As Nullable(Of Long),  _
                    ByVal glcostcntr1Costcntr_Nm As String,  _
                    ByVal glcostcntr1cost_typCostcntr_Nm As String,  _
                    ByVal cstm_nm As String)
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
