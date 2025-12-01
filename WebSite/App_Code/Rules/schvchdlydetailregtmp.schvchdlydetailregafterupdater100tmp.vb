Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schvchdlydetailregtmpBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in the view with id matching "createForm1|editForm1" after an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("schvchdlydetailregafterupdater100tmp")>  _
        Public Sub schvchdlydetailregafterupdater100tmpImplementation( _
                    ByVal trs_No As Nullable(Of Long),  _
                    ByVal schvchdlyhdregid As Nullable(Of Long),  _
                    ByVal schvchdlyhdregReferanceNo As String,  _
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
                    ByVal studentareaDesc1 As String,  _
                    ByVal studentbranchDesc1 As String,  _
                    ByVal studentbranchsgmsgm_Nm As String,  _
                    ByVal studentbranchGenderGender As String,  _
                    ByVal studentbranchstageShortDesc1 As String,  _
                    ByVal studentbranchschtypschtypDesc As String,  _
                    ByVal studentCntry_Cntry_Nm As String,  _
                    ByVal studentGenderGender As String,  _
                    ByVal studentReligionReljan_nm As String,  _
                    ByVal studentstateState_Nm As String,  _
                    ByVal studentidname_1 As String,  _
                    ByVal studentacdAcademicYear As String,  _
                    ByVal studentacdGlFinperiodFin_period_info As String,  _
                    ByVal studentClassClassDesc1 As String,  _
                    ByVal studentSchclasskindSchclasskinddesc As String,  _
                    ByVal studentFatherfathfirstname1 As String,  _
                    ByVal studentFatherMaritalStatusStatus_Nm As String,  _
                    ByVal studentFatherareaDesc1 As String,  _
                    ByVal studentFatherCntry_Cntry_Nm As String,  _
                    ByVal studentFatherreligionReljan_nm As String,  _
                    ByVal studentFatherStateState_Nm As String,  _
                    ByVal studentFatherjob_job_desc As String,  _
                    ByVal studentGradeShortDesc1 As String,  _
                    ByVal studentGradeacdAcademicYear As String,  _
                    ByVal studentGradeStageShortDesc1 As String,  _
                    ByVal studentMotherfirstname1 As String,  _
                    ByVal studentMotherareaDesc1 As String,  _
                    ByVal studentMotherCntry_Cntry_Nm As String,  _
                    ByVal studentMotherreligionReljan_nm As String,  _
                    ByVal studentMotherStateState_Nm As String,  _
                    ByVal studentMotherjob_job_desc As String,  _
                    ByVal studentStageShortDesc1 As String,  _
                    ByVal studentschstatus_schstatus_name As String,  _
                    ByVal studentschstclasskinddmgschstclasskinddmgDesc As String,  _
                    ByVal studentschstsplschstsplDsc As String,  _
                    ByVal studentschsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal studentstudentsefastudentsefaar As String,  _
                    ByVal studentstudentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentschstudenttypschstudenttyp As String,  _
                    ByVal studentSchtransferSchtransferDesc As String,  _
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
                    ByVal totalbalance1 As Nullable(Of Decimal))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
