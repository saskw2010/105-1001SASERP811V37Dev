Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class ajarContracts1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view before an action
        ''' with a command name that matches "Delete".
        ''' </summary>
        <Rule("Beforedeleter101")>  _
        Public Sub Beforedeleter101Implementation( _
                    ByVal pLAT_No As String,  _
                    ByVal ajrCntrctSr As Nullable(Of Long),  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal cntctDate As Nullable(Of DateTime),  _
                    ByVal cstm_No As Nullable(Of Long),  _
                    ByVal cstm_Cstm_Nm As String,  _
                    ByVal cstm_AreaArea_name As String,  _
                    ByVal cstm_EvaluationEvaluation_name As String,  _
                    ByVal cstm_acc_Acc_Nm As String,  _
                    ByVal cstm_Cntry_Cntry_Nm As String,  _
                    ByVal cstm_curncy_Curncy_Nm As String,  _
                    ByVal cstm_TSNEFTSNEF_name As String,  _
                    ByVal cstm_TSNEFNO1TSNEF1_name As String,  _
                    ByVal cstm_Slm_Slm_Nm As String,  _
                    ByVal cstm_Slm_masngerclassmasngerclass As String,  _
                    ByVal plantypeid As Nullable(Of Long),  _
                    ByVal plantypeplantypeDesc As String,  _
                    ByVal car_No As Nullable(Of Long),  _
                    ByVal car_PLAT_No As String,  _
                    ByVal car_Car_TypeStyl_Nm As String,  _
                    ByVal car_caseoperationdesccaseoperationdesc As String,  _
                    ByVal car_carclasscarclassname As String,  _
                    ByVal car_Insu_CmpInsu_Cmpname As String,  _
                    ByVal car_Insu_Cmp1Insu_Cmpname As String,  _
                    ByVal car_Insu_Cmp2Insu_Cmpname As String,  _
                    ByVal car_kindcarkinddesc As String,  _
                    ByVal car_carstutus_carstutus_name As String,  _
                    ByVal car_Car_ColrColor_name As String,  _
                    ByVal car_fuelllevelFuellevelDisplayname As String,  _
                    ByVal car_GuaranteeGuaranteename As String,  _
                    ByVal car_Insurance_typeInsurance_name As String,  _
                    ByVal car_Car_LikLike_name As String,  _
                    ByVal car_padnaturewaypadnatureway As String,  _
                    ByVal car_Fbrct_CntryCntry_Nm As String,  _
                    ByVal car_Ownr_Ownr_ID As String,  _
                    ByVal car_Ownr_cmp_Grp_Nm As String,  _
                    ByVal car_Ownr_Cntry_Cntry_Nm As String,  _
                    ByVal car_Trfc_DpmState_Nm As String,  _
                    ByVal car_Cstm_Cstm_Nm As String,  _
                    ByVal car_Cstm_AreaArea_name As String,  _
                    ByVal car_Cstm_EvaluationEvaluation_name As String,  _
                    ByVal car_Cstm_acc_Acc_Nm As String,  _
                    ByVal car_Cstm_Cntry_Cntry_Nm As String,  _
                    ByVal car_Cstm_curncy_Curncy_Nm As String,  _
                    ByVal car_Cstm_TSNEFTSNEF_name As String,  _
                    ByVal car_Cstm_TSNEFNO1TSNEF1_name As String,  _
                    ByVal car_Cstm_Slm_Slm_Nm As String,  _
                    ByVal car_Sup_Sup_Nm As String,  _
                    ByVal car_Sup_Acc_Acc_Nm As String,  _
                    ByVal car_Sup_Cntry_Cntry_Nm As String,  _
                    ByVal car_Sup_Curncy_Curncy_Nm As String,  _
                    ByVal car_TamweelreqTamweeldeatails As String,  _
                    ByVal car_TamweelreqCurncy_Curncy_Nm As String,  _
                    ByVal car_TamweelreqCstm_Cstm_Nm As String,  _
                    ByVal car_Tamweelreqtasedwaytasedwayname As String,  _
                    ByVal kmReading As Nullable(Of Decimal),  _
                    ByVal nOfDays As Nullable(Of Decimal),  _
                    ByVal discountpercentage As Nullable(Of Decimal),  _
                    ByVal priceperunit As Nullable(Of Decimal),  _
                    ByVal pricePerDay As Nullable(Of Decimal),  _
                    ByVal fuel As Nullable(Of Long),  _
                    ByVal fuelFuellevelname As String,  _
                    ByVal freekm As Nullable(Of Decimal),  _
                    ByVal startDate As Nullable(Of DateTime),  _
                    ByVal startTime As Nullable(Of System.TimeSpan),  _
                    ByVal endDate As Nullable(Of DateTime),  _
                    ByVal endtime As Nullable(Of System.TimeSpan),  _
                    ByVal notes As String,  _
                    ByVal cntstcode As Nullable(Of Long),  _
                    ByVal cntststatus_name As String,  _
                    ByVal rLEndDate As Nullable(Of DateTime),  _
                    ByVal rLEndtime As Nullable(Of System.TimeSpan),  _
                    ByVal slm_No As Nullable(Of Long),  _
                    ByVal slm_Slm_Nm As String,  _
                    ByVal slm_masngerclassmasngerclass As String,  _
                    ByVal rtkmReading As Nullable(Of Decimal),  _
                    ByVal rtFuel As Nullable(Of Long),  _
                    ByVal rTsgm As Nullable(Of Long),  _
                    ByVal typcoid As Nullable(Of Long),  _
                    ByVal typcotypcoDesc As String,  _
                    ByVal prostermcode As Nullable(Of Long),  _
                    ByVal prostermProgramStDesc As String,  _
                    ByVal prostermplantypeplantypeDesc As String,  _
                    ByVal usingcod As Nullable(Of Long),  _
                    ByVal usingcodCstm_Nm As String,  _
                    ByVal usingcodAreaArea_name As String,  _
                    ByVal usingcodEvaluationEvaluation_name As String,  _
                    ByVal usingcodacc_Acc_Nm As String,  _
                    ByVal usingcodCntry_Cntry_Nm As String,  _
                    ByVal usingcodcurncy_Curncy_Nm As String,  _
                    ByVal usingcodTSNEFTSNEF_name As String,  _
                    ByVal usingcodTSNEFNO1TSNEF1_name As String,  _
                    ByVal usingcodSlm_Slm_Nm As String,  _
                    ByVal usingcodSlm_masngerclassmasngerclass As String,  _
                    ByVal usingcod1 As Nullable(Of Long),  _
                    ByVal usingcod1Cstm_Nm As String,  _
                    ByVal usingcod1AreaArea_name As String,  _
                    ByVal usingcod1EvaluationEvaluation_name As String,  _
                    ByVal usingcod1acc_Acc_Nm As String,  _
                    ByVal usingcod1Cntry_Cntry_Nm As String,  _
                    ByVal usingcod1curncy_Curncy_Nm As String,  _
                    ByVal usingcod1TSNEFTSNEF_name As String,  _
                    ByVal usingcod1TSNEFNO1TSNEF1_name As String,  _
                    ByVal usingcod1Slm_Slm_Nm As String,  _
                    ByVal usingcod1Slm_masngerclassmasngerclass As String,  _
                    ByVal requestNumber As String,  _
                    ByVal deleviryservice As Nullable(Of Boolean),  _
                    ByVal extKm_Value As Nullable(Of Decimal),  _
                    ByVal lattype As Nullable(Of Long),  _
                    ByVal latedayes As Nullable(Of Short),  _
                    ByVal latedhours As Nullable(Of Double),  _
                    ByVal latedprice As Nullable(Of Decimal),  _
                    ByVal latemoney As Nullable(Of Decimal),  _
                    ByVal returnbroken As Nullable(Of Decimal),  _
                    ByVal extraMoney As Nullable(Of Decimal),  _
                    ByVal contractanotat As String,  _
                    ByVal pricebeforeDescountx As Nullable(Of Decimal),  _
                    ByVal pricebeforedescperunitx As Nullable(Of Decimal),  _
                    ByVal normalsumofcontractx As Nullable(Of Decimal),  _
                    ByVal normalCounterreturnx As Nullable(Of Decimal),  _
                    ByVal descountamountcalcx As Nullable(Of Decimal),  _
                    ByVal descountamountcalc1 As Nullable(Of Decimal),  _
                    ByVal descountamountcalc2 As Nullable(Of Decimal),  _
                    ByVal descountamountcalc3 As Nullable(Of Decimal),  _
                    ByVal descountamountcalc4 As Nullable(Of Decimal),  _
                    ByVal descountamountcalc5 As Nullable(Of Decimal),  _
                    ByVal descountamountcalc6 As Nullable(Of Decimal),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedByUserId As Nullable(Of System.Guid),  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdById As Nullable(Of System.Guid),  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal hyapertoanotate As String,  _
                    ByVal cstm_Tel As String,  _
                    ByVal cstm_Email As String,  _
                    ByVal civilID As String,  _
                    ByVal civilEnddate As Nullable(Of DateTime),  _
                    ByVal licenceNumber As String,  _
                    ByVal licenceEnddate As Nullable(Of DateTime),  _
                    ByVal cstm_Adr As String,  _
                    ByVal workadress As String,  _
                    ByVal cstm_Tel2 As String,  _
                    ByVal othercountrycvlid As String,  _
                    ByVal othercountrydate As Nullable(Of DateTime),  _
                    ByVal cstm_Othr As String,  _
                    ByVal cstm_Fax As String,  _
                    ByVal fbrct_Yer As String)
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
