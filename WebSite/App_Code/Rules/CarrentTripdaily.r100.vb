Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class CarrentTripdailyBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' Rule "newdayreg" implementation:
        ''' This method will execute in any view for an action
        ''' with a command name that matches "New" and argument that matches "Dayreg".
        ''' </summary>
        <Rule("r100")>  _
        Public Sub r100Implementation( _
                    ByVal carrentTripdailyID As Nullable(Of Long),  _
                    ByVal car_no As Nullable(Of Long),  _
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
                    ByVal fuel As Nullable(Of Long),  _
                    ByVal fuelFuellevelname As String,  _
                    ByVal startDate As Nullable(Of DateTime),  _
                    ByVal tripkinddesc As String,  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
