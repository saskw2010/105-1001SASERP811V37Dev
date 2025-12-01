Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schvchdlydetailreg1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view after an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("schvchdlydetailregafterupdater100")>  _
        Public Sub schvchdlydetailregafterupdater100Implementation( _
                    ByVal trs_No As Nullable(Of Long),  _
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
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal cSMSUP_NM As String,  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal fatherfathfirstname1 As String,  _
                    ByVal fatherMaritalStatusStatus_Nm As String,  _
                    ByVal fatherareaDesc1 As String,  _
                    ByVal fatherCntry_Cntry_Nm As String,  _
                    ByVal fatherreligionReljan_nm As String,  _
                    ByVal fatherStateState_Nm As String,  _
                    ByVal fatherjob_job_desc As String,  _
                    ByVal trsd_Dt As Nullable(Of DateTime),  _
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
                    ByVal totalbalance As Nullable(Of Decimal),  _
                    ByVal sumofdebitcal As Nullable(Of Decimal),  _
                    ByVal sumofdebitcal1 As Nullable(Of Decimal),  _
                    ByVal sumofcerditcal As Nullable(Of Decimal),  _
                    ByVal totalbalance1 As Nullable(Of Decimal),  _
                    ByVal acc_no As Nullable(Of Long),  _
                    ByVal glcostcntr As Nullable(Of Long),  _
                    ByVal glcostcntr1 As Nullable(Of Long),  _
                    ByVal schstEmail As String,  _
                    ByVal totalbalance_1 As Nullable(Of Decimal),  _
                    ByVal sumofcebitcal1_1 As Nullable(Of Decimal),  _
                    ByVal totalbalance_2 As Nullable(Of Decimal),  _
                    ByVal sumofdebitcal_2 As Nullable(Of Decimal),  _
                    ByVal balance As Nullable(Of Decimal),  _
                    ByVal delevername As String,  _
                    ByVal delevercivil As String,  _
                    ByVal deleverTel As String,  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal posted As Nullable(Of Boolean),  _
                    ByVal deleted As Nullable(Of Boolean),  _
                    ByVal havdetails As Nullable(Of Boolean),  _
                    ByVal firstName1 As String,  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal studentCoderead As Nullable(Of Long),  _
                    ByVal schvchdlyhdregbranch As Nullable(Of Long),  _
                    ByVal schvchdlyhdregacdcode As Nullable(Of Long),  _
                    ByVal schvchdlyhdregReferanceNo As Nullable(Of Long))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
