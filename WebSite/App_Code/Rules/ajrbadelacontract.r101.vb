Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class ajrbadelacontractBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in the view with id matching "editForm1" after an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("r101")>  _
        Public Sub r101Implementation( _
                    ByVal ajrbadelaid As Nullable(Of Long),  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal ajrCntrctSr As Nullable(Of Long),  _
                    ByVal theajrCntrctSrStartTime As String,  _
                    ByVal theajrCntrctSrCar_PLAT_No As String,  _
                    ByVal theajrCntrctSrCar_Car_TypeStyl_Nm As String,  _
                    ByVal theajrCntrctSrCar_Emp_Emp_Nmdriver As String,  _
                    ByVal theajrCntrctSrCar_caseoperationdesccaseoperationdesc As String,  _
                    ByVal theajrCntrctSrCar_carclasscarclassname As String,  _
                    ByVal theajrCntrctSrCar_Insu_CmpInsu_Cmpname As String,  _
                    ByVal theajrCntrctSrCar_Insu_Cmp1Insu_Cmpname As String,  _
                    ByVal theajrCntrctSrCar_Insu_Cmp2Insu_Cmpname As String,  _
                    ByVal theajrCntrctSrCar_kindcarkinddesc As String,  _
                    ByVal theajrCntrctSrCar_carstutus_carstutus_name As String,  _
                    ByVal theajrCntrctSrCar_Car_ColrColor_name As String,  _
                    ByVal theajrCntrctSrCar_fuelllevelFuellevelDisplayname As String,  _
                    ByVal theajrCntrctSrCar_sgmsgm_Nm As String,  _
                    ByVal theajrCntrctSrCar_GuaranteeGuaranteename As String,  _
                    ByVal theajrCntrctSrCar_Insurance_typeInsurance_name As String,  _
                    ByVal theajrCntrctSrCar_Car_LikLike_name As String,  _
                    ByVal theajrCntrctSrCar_padnaturewaypadnatureway As String,  _
                    ByVal theajrCntrctSrCar_Fbrct_CntryCntry_Nm As String,  _
                    ByVal theajrCntrctSrCar_Ownr_Ownr_ID As String,  _
                    ByVal theajrCntrctSrCar_Trfc_DpmState_Nm As String,  _
                    ByVal theajrCntrctSrCar_Cstm_Cstm_Nm As String,  _
                    ByVal theajrCntrctSrCar_Sup_Sup_Nm As String,  _
                    ByVal theajrCntrctSrCar_TamweelreqTamweeldeatails As String,  _
                    ByVal theajrCntrctSrplantypeplantypeDesc As String,  _
                    ByVal theajrCntrctSrcntststatus_name As String,  _
                    ByVal theajrCntrctSrFuelFuellevelname As String,  _
                    ByVal theajrCntrctSrprostermProgramStDesc As String,  _
                    ByVal theajrCntrctSrprostermplantypeplantypeDesc As String,  _
                    ByVal theajrCntrctSrCstm_Cstm_Nm As String,  _
                    ByVal theajrCntrctSrCstm_AreaArea_name As String,  _
                    ByVal theajrCntrctSrCstm_EvaluationEvaluation_name As String,  _
                    ByVal theajrCntrctSrCstm_acc_Acc_Nm As String,  _
                    ByVal theajrCntrctSrCstm_sgmsgm_Nm As String,  _
                    ByVal theajrCntrctSrCstm_Cntry_Cntry_Nm As String,  _
                    ByVal theajrCntrctSrCstm_curncy_Curncy_Nm As String,  _
                    ByVal theajrCntrctSrCstm_TSNEFTSNEF_name As String,  _
                    ByVal theajrCntrctSrCstm_TSNEFNO1TSNEF1_name As String,  _
                    ByVal theajrCntrctSrCstm_Slm_Slm_Nm As String,  _
                    ByVal theajrCntrctSrusingcodCstm_Nm As String,  _
                    ByVal theajrCntrctSrusingcodAreaArea_name As String,  _
                    ByVal theajrCntrctSrusingcodEvaluationEvaluation_name As String,  _
                    ByVal theajrCntrctSrusingcodacc_Acc_Nm As String,  _
                    ByVal theajrCntrctSrusingcodsgmsgm_Nm As String,  _
                    ByVal theajrCntrctSrusingcodCntry_Cntry_Nm As String,  _
                    ByVal theajrCntrctSrusingcodcurncy_Curncy_Nm As String,  _
                    ByVal theajrCntrctSrusingcodTSNEFTSNEF_name As String,  _
                    ByVal theajrCntrctSrusingcodTSNEFNO1TSNEF1_name As String,  _
                    ByVal theajrCntrctSrusingcodSlm_Slm_Nm As String,  _
                    ByVal theajrCntrctSrusingcod1Cstm_Nm As String,  _
                    ByVal theajrCntrctSrusingcod1AreaArea_name As String,  _
                    ByVal theajrCntrctSrusingcod1EvaluationEvaluation_name As String,  _
                    ByVal theajrCntrctSrusingcod1acc_Acc_Nm As String,  _
                    ByVal theajrCntrctSrusingcod1sgmsgm_Nm As String,  _
                    ByVal theajrCntrctSrusingcod1Cntry_Cntry_Nm As String,  _
                    ByVal theajrCntrctSrusingcod1curncy_Curncy_Nm As String,  _
                    ByVal theajrCntrctSrusingcod1TSNEFTSNEF_name As String,  _
                    ByVal theajrCntrctSrusingcod1TSNEFNO1TSNEF1_name As String,  _
                    ByVal theajrCntrctSrusingcod1Slm_Slm_Nm As String,  _
                    ByVal theajrCntrctSrSlm_Slm_Nm As String,  _
                    ByVal theajrCntrctSrSlm_masngerclassmasngerclass As String,  _
                    ByVal theajrCntrctSrtypcotypcoDesc As String,  _
                    ByVal car_No As Nullable(Of Long),  _
                    ByVal car_PLAT_No As String,  _
                    ByVal car_Car_TypeStyl_Nm As String,  _
                    ByVal car_Emp_Emp_Nmdriver As String,  _
                    ByVal car_Emp_sgmsgm_Nm As String,  _
                    ByVal car_Emp_Emp_no1Emp_NOt As String,  _
                    ByVal car_caseoperationdesccaseoperationdesc As String,  _
                    ByVal car_carclasscarclassname As String,  _
                    ByVal car_Insu_CmpInsu_Cmpname As String,  _
                    ByVal car_Insu_Cmp1Insu_Cmpname As String,  _
                    ByVal car_Insu_Cmp2Insu_Cmpname As String,  _
                    ByVal car_kindcarkinddesc As String,  _
                    ByVal car_kindStyl_Styl_Nm As String,  _
                    ByVal car_carstutus_carstutus_name As String,  _
                    ByVal car_Car_ColrColor_name As String,  _
                    ByVal car_fuelllevelFuellevelDisplayname As String,  _
                    ByVal car_sgmsgm_Nm As String,  _
                    ByVal car_sgmOpcoOpcoName As String,  _
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
                    ByVal car_Cstm_sgmsgm_Nm As String,  _
                    ByVal car_Cstm_Cntry_Cntry_Nm As String,  _
                    ByVal car_Cstm_curncy_Curncy_Nm As String,  _
                    ByVal car_Cstm_TSNEFTSNEF_name As String,  _
                    ByVal car_Cstm_TSNEFNO1TSNEF1_name As String,  _
                    ByVal car_Cstm_Slm_Slm_Nm As String,  _
                    ByVal car_Sup_Sup_Nm As String,  _
                    ByVal car_Sup_Acc_Acc_Nm As String,  _
                    ByVal car_Sup_sgmsgm_Nm As String,  _
                    ByVal car_Sup_Cntry_Cntry_Nm As String,  _
                    ByVal car_Sup_Curncy_Curncy_Nm As String,  _
                    ByVal car_TamweelreqTamweeldeatails As String,  _
                    ByVal car_TamweelreqCurncy_Curncy_Nm As String,  _
                    ByVal car_TamweelreqCstm_Cstm_Nm As String,  _
                    ByVal car_Tamweelreqtasedwaytasedwayname As String,  _
                    ByVal kmReading As Nullable(Of Decimal),  _
                    ByVal nOfDays As Nullable(Of Decimal),  _
                    ByVal priceperunit As Nullable(Of Decimal),  _
                    ByVal pricePerDay As Nullable(Of Decimal),  _
                    ByVal fuel As Nullable(Of Long),  _
                    ByVal fuelFuellevelname As String,  _
                    ByVal freekm As Nullable(Of Decimal),  _
                    ByVal startDate As Nullable(Of DateTime),  _
                    ByVal startTime As String,  _
                    ByVal endDate As Nullable(Of DateTime),  _
                    ByVal endtime As String,  _
                    ByVal notes As String,  _
                    ByVal cntstcode As Nullable(Of Long),  _
                    ByVal cntststatus_name As String,  _
                    ByVal rLEndDate As Nullable(Of DateTime),  _
                    ByVal rLEndtime As String,  _
                    ByVal rtkmReading As Nullable(Of Decimal),  _
                    ByVal rtFuel As Nullable(Of Long),  _
                    ByVal rtFuelFuellevelname As String,  _
                    ByVal rTsgm As Nullable(Of Long),  _
                    ByVal rTNotes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedByUserId As Nullable(Of System.Guid),  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdById As Nullable(Of System.Guid),  _
                    ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
