Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class CarInfomBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "UploadFile" and argument that matches "ExternalDoc".
        ''' </summary>
        <Rule("carinfomr100")>  _
        Public Sub carinfomr100Implementation( _
                    ByVal pLAT_No As String,  _
                    ByVal fbrct_Yer As String,  _
                    ByVal car_Chas As String,  _
                    ByVal car_No As Nullable(Of Long),  _
                    ByVal ownr_No As Nullable(Of Long),  _
                    ByVal ownr_Ownr_ID As String,  _
                    ByVal ownr_cmp_Grp_Nm As String,  _
                    ByVal ownr_Cntry_Cntry_Nm As String,  _
                    ByVal trfc_Dpm As Nullable(Of Long),  _
                    ByVal trfc_DpmState_Nm As String,  _
                    ByVal cstm_No As Nullable(Of Long),  _
                    ByVal cstm_Cstm_Nm As String,  _
                    ByVal cstm_AreaArea_name As String,  _
                    ByVal cstm_EvaluationEvaluation_name As String,  _
                    ByVal cstm_acc_Acc_Nm As String,  _
                    ByVal cstm_sgmsgm_Nm As String,  _
                    ByVal cstm_sgmOpcoOpcoName As String,  _
                    ByVal cstm_Cntry_Cntry_Nm As String,  _
                    ByVal cstm_curncy_Curncy_Nm As String,  _
                    ByVal cstm_TSNEFTSNEF_name As String,  _
                    ByVal cstm_TSNEFNO1TSNEF1_name As String,  _
                    ByVal cstm_Slm_Slm_Nm As String,  _
                    ByVal cstm_Slm_masngerclassmasngerclass As String,  _
                    ByVal caseoperationdescid As Nullable(Of Long),  _
                    ByVal caseoperationdesccaseoperationdesc As String,  _
                    ByVal car_Type As Nullable(Of Long),  _
                    ByVal car_TypeStyl_Nm As String,  _
                    ByVal kind As Nullable(Of Long),  _
                    ByVal kindcarkinddesc As String,  _
                    ByVal kindStyl_Styl_Nm As String,  _
                    ByVal car_Colr As Nullable(Of Long),  _
                    ByVal car_ColrColor_name As String,  _
                    ByVal car_Lik As Nullable(Of Long),  _
                    ByVal car_LikLike_name As String,  _
                    ByVal carclass As Nullable(Of Long),  _
                    ByVal thecarclasscarclassname As String,  _
                    ByVal pasengerno As Nullable(Of Decimal),  _
                    ByVal fuelllevel As Nullable(Of Long),  _
                    ByVal fuelllevelFuellevelDisplayname As String,  _
                    ByVal loadton1 As Nullable(Of Decimal),  _
                    ByVal sup_No As Nullable(Of Long),  _
                    ByVal sup_Sup_Nm As String,  _
                    ByVal sup_Acc_Acc_Nm As String,  _
                    ByVal sup_sgmsgm_Nm As String,  _
                    ByVal sup_sgmOpcoOpcoName As String,  _
                    ByVal sup_Cntry_Cntry_Nm As String,  _
                    ByVal sup_Curncy_Curncy_Nm As String,  _
                    ByVal dileverydatesupno As Nullable(Of DateTime),  _
                    ByVal carspesification As String,  _
                    ByVal car_Km As Nullable(Of Decimal),  _
                    ByVal carstutus_no As Nullable(Of Long),  _
                    ByVal carstutus_carstutus_name As String,  _
                    ByVal emp_Delivery As String,  _
                    ByVal deliver_Date As Nullable(Of DateTime),  _
                    ByVal insurance_type As Nullable(Of Long),  _
                    ByVal theInsurance_typeInsurance_name As String,  _
                    ByVal insu_Cmp As Nullable(Of Long),  _
                    ByVal theInsu_CmpInsu_Cmpname As String,  _
                    ByVal insu_No As String,  _
                    ByVal insuissuedt As Nullable(Of DateTime),  _
                    ByVal insu_Stdt As Nullable(Of DateTime),  _
                    ByVal insu_Endt As Nullable(Of DateTime),  _
                    ByVal insu_Value As Nullable(Of Decimal),  _
                    ByVal insu_Cmp1 As Nullable(Of Long),  _
                    ByVal insu_Cmp1Insu_Cmpname As String,  _
                    ByVal insu_No1 As String,  _
                    ByVal insu_issueShamel_dt As Nullable(Of DateTime),  _
                    ByVal insu_Stdt1 As Nullable(Of DateTime),  _
                    ByVal insu_Endt1 As Nullable(Of DateTime),  _
                    ByVal insu_Value1 As Nullable(Of Decimal),  _
                    ByVal insu_Cmp2 As Nullable(Of Long),  _
                    ByVal insu_Cmp2Insu_Cmpname As String,  _
                    ByVal insu_No2 As String,  _
                    ByVal insu_Stdt2 As Nullable(Of DateTime),  _
                    ByVal insu_Endt2 As Nullable(Of DateTime),  _
                    ByVal insu_Value2 As Nullable(Of Decimal),  _
                    ByVal insu_Car_Value As Nullable(Of Decimal),  _
                    ByVal roads_Service As String,  _
                    ByVal service_Start As Nullable(Of DateTime),  _
                    ByVal service_End As Nullable(Of DateTime),  _
                    ByVal service_Value As Nullable(Of Decimal),  _
                    ByVal location As String,  _
                    ByVal guarantee As Nullable(Of Long),  _
                    ByVal theGuaranteeGuaranteename As String,  _
                    ByVal guarantee_Start As Nullable(Of DateTime),  _
                    ByVal guarantee_End As Nullable(Of DateTime),  _
                    ByVal purch_VLue As Nullable(Of Decimal),  _
                    ByVal purch_Date As Nullable(Of DateTime),  _
                    ByVal month_pad As Nullable(Of Decimal),  _
                    ByVal mOnth_No As Nullable(Of Long),  _
                    ByVal valuaftertamweel As Nullable(Of Decimal),  _
                    ByVal tamweelexpensive As Nullable(Of Decimal),  _
                    ByVal padstartdate As Nullable(Of DateTime),  _
                    ByVal padenddate As Nullable(Of DateTime),  _
                    ByVal padnaturewayid As Nullable(Of Long),  _
                    ByVal padnaturewaypadnatureway As String,  _
                    ByVal tamweelreqid As Nullable(Of Long),  _
                    ByVal tamweelreqTamweeldeatails As String,  _
                    ByVal tamweelreqCurncy_Curncy_Nm As String,  _
                    ByVal tamweelreqCstm_Cstm_Nm As String,  _
                    ByVal tamweelreqCstm_AreaArea_name As String,  _
                    ByVal tamweelreqCstm_EvaluationEvaluation_name As String,  _
                    ByVal tamweelreqCstm_acc_Acc_Nm As String,  _
                    ByVal tamweelreqCstm_sgmsgm_Nm As String,  _
                    ByVal tamweelreqCstm_Cntry_Cntry_Nm As String,  _
                    ByVal tamweelreqCstm_curncy_Curncy_Nm As String,  _
                    ByVal tamweelreqCstm_TSNEFTSNEF_name As String,  _
                    ByVal tamweelreqCstm_TSNEFNO1TSNEF1_name As String,  _
                    ByVal tamweelreqCstm_Slm_Slm_Nm As String,  _
                    ByVal tamweelreqtasedwaytasedwayname As String,  _
                    ByVal rent_Value As Nullable(Of Decimal),  _
                    ByVal carKm_No As Nullable(Of Decimal),  _
                    ByVal extKm_Value As Nullable(Of Decimal),  _
                    ByVal lastmaindate As Nullable(Of DateTime),  _
                    ByVal mp3Player As Nullable(Of Boolean),  _
                    ByVal dVDPlayer As Nullable(Of Boolean),  _
                    ByVal airConditioner As Nullable(Of Boolean),  _
                    ByVal aBS As Nullable(Of Boolean),  _
                    ByVal aSR As Nullable(Of Boolean),  _
                    ByVal navigation As Nullable(Of Boolean),  _
                    ByVal forntTV As Nullable(Of Boolean),  _
                    ByVal backAirConditioner As Nullable(Of Boolean),  _
                    ByVal gPSservice As Nullable(Of Boolean),  _
                    ByVal accesoriescomment As String,  _
                    ByVal lastcontnumber As Nullable(Of Long),  _
                    ByVal car_Depreciation As Nullable(Of Boolean),  _
                    ByVal depreciation_days As Nullable(Of Decimal),  _
                    ByVal depreciation_month As Nullable(Of Decimal),  _
                    ByVal depreciation_yearlyvalue As Nullable(Of Decimal),  _
                    ByVal depreciation_startdate As Nullable(Of DateTime),  _
                    ByVal depreciation_beforevalue As Nullable(Of Decimal),  _
                    ByVal depreciation_monthbefore As Nullable(Of Decimal),  _
                    ByVal depreciation_daysbefore As Nullable(Of Decimal),  _
                    ByVal depreciation_note As String,  _
                    ByVal carsalvalue As Nullable(Of Decimal),  _
                    ByVal carsaldate As Nullable(Of DateTime),  _
                    ByVal carsalcompany As String,  _
                    ByVal carsalnote As String,  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal sgmsgm_Nm As String,  _
                    ByVal sgmOpcoOpcoName As String,  _
                    ByVal pLAT_No1 As String,  _
                    ByVal fbrct_Cntry As Nullable(Of Long),  _
                    ByVal fbrct_CntryCntry_Nm As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedByUserId As Nullable(Of System.Guid),  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdById As Nullable(Of System.Guid),  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal externalDocFileName As String,  _
                    ByVal externalDocLength As Nullable(Of Long),  _
                    ByVal externalDocContentType As String,  _
                    ByVal lastannotate As String,  _
                    ByVal anotatuser As String,  _
                    ByVal available As Nullable(Of Boolean),  _
                    ByVal latitude As Nullable(Of Double),  _
                    ByVal longitude As Nullable(Of Double),  _
                    ByVal rating As Nullable(Of Decimal),  _
                    ByVal numberOfRatings As Nullable(Of Integer),  _
                    ByVal extrinsurance11 As Nullable(Of DateTime),  _
                    ByVal extrinsurance12 As Nullable(Of DateTime),  _
                    ByVal extrinsurance13 As Nullable(Of DateTime),  _
                    ByVal extrinsurance14 As Nullable(Of DateTime),  _
                    ByVal extrinsurance15 As Nullable(Of DateTime),  _
                    ByVal extrinsurance16 As Nullable(Of DateTime),  _
                    ByVal extrinsurance17 As Nullable(Of DateTime),  _
                    ByVal emp_No As Nullable(Of Long),  _
                    ByVal emp_Emp_Nmdriver As String,  _
                    ByVal emp_sgmsgm_Nm As String,  _
                    ByVal emp_sgmOpcoOpcoName As String,  _
                    ByVal emp_Emp_no1Emp_NOt As String,  _
                    ByVal emp_Emp_no1Blood_TypeModifiedBy As String,  _
                    ByVal emp_Emp_no1Cntry_Cntry_Nm As String,  _
                    ByVal emp_Emp_no1Depm_Depm_Nm As String,  _
                    ByVal emp_Emp_no1Educt_TypeEduct_Nm As String,  _
                    ByVal emp_Emp_no1Job_StuEmp_Stunm As String,  _
                    ByVal emp_Emp_no1Job_Job_Nm As String,  _
                    ByVal emp_Emp_no1Ownr_Ownr_ID As String,  _
                    ByVal emp_Emp_no1ReljanReljan_nm As String,  _
                    ByVal emp_Emp_no1Status_TypeStatus_Nm As String,  _
                    ByVal lastservicedate As Nullable(Of DateTime),  _
                    ByVal lastservicereadingkm As Nullable(Of Decimal))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
