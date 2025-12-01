Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class Regbussstudent1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view after an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("regbussstudentrupdateinsertafter100")>  _
        Public Sub regbussstudentrupdateinsertafter100Implementation( _
                    ByVal regbussstudentid As Nullable(Of Long),  _
                    ByVal busid As Nullable(Of Long),  _
                    ByVal busname_1 As String,  _
                    ByVal busbranchDesc1 As String,  _
                    ByVal busbranchsgmsgm_Nm As String,  _
                    ByVal busbranchGenderGender As String,  _
                    ByVal busbranchstageShortDesc1 As String,  _
                    ByVal busbranchschtypschtypDesc As String,  _
                    ByVal schareaid As Nullable(Of Long),  _
                    ByVal schareaDesc1 As String,  _
                    ByVal standerdprice As Nullable(Of Decimal),  _
                    ByVal notes As String,  _
                    ByVal transdate As Nullable(Of DateTime),  _
                    ByVal startdate As Nullable(Of DateTime),  _
                    ByVal enddate As Nullable(Of DateTime),  _
                    ByVal periodpermonth As Nullable(Of Decimal),  _
                    ByVal amountDiscount As Nullable(Of Decimal),  _
                    ByVal amountadded As Nullable(Of Decimal),  _
                    ByVal totalAmount As Nullable(Of Decimal),  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal gradeStageShortDesc1 As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
                    ByVal classTeacherEmp_NOt As String,  _
                    ByVal classTeacherHld_ErnReq_NM As String,  _
                    ByVal classTeachersgmsgm_Nm As String,  _
                    ByVal classTeachersalrycatgrade_desc_a As String,  _
                    ByVal classTeacherBlood_TypeModifiedBy As String,  _
                    ByVal classTeacherBnk_Bnk_Acc As String,  _
                    ByVal classTeacherSub_BnkBnk_Acc As String,  _
                    ByVal classTeacherCntry_Cntry_Nm As String,  _
                    ByVal classTeacherDepm_Depm_Nm As String,  _
                    ByVal classTeacherEduct_TypeEduct_Nm As String,  _
                    ByVal classTeacherJob_StuEmp_Stunm As String,  _
                    ByVal classTeacherEarning_Earning_Nm As String,  _
                    ByVal classTeacherGenderGender As String,  _
                    ByVal classTeacherJob_Job_Nm As String,  _
                    ByVal classTeacherLoc_Loc_Nm As String,  _
                    ByVal classTeacherOwnr_Ownr_ID As String,  _
                    ByVal classTeacherReljanReljan_nm As String,  _
                    ByVal classTeacherStatus_TypeStatus_Nm As String,  _
                    ByVal classTeacherbranchDesc1 As String,  _
                    ByVal classTeacherUniq_BADGENUMBER As String,  _
                    ByVal classBranchDesc1 As String,  _
                    ByVal classBranchsgmsgm_Nm As String,  _
                    ByVal classBranchGenderGender As String,  _
                    ByVal classBranchstageShortDesc1 As String,  _
                    ByVal classBranchschtypschtypDesc As String,  _
                    ByVal classGradeShortDesc1 As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal amountDiscountnote As String,  _
                    ByVal amountaddednote As String,  _
                    ByVal subscriptionstatus As Nullable(Of Long),  _
                    ByVal theSubscriptionstatusSubscriptionstatusDesc As String,  _
                    ByVal subscriptionstopeddate As Nullable(Of DateTime),  _
                    ByVal restperiodpermonth As Nullable(Of Decimal),  _
                    ByVal restTotalAmount As Nullable(Of Decimal),  _
                    ByVal firstinstallmentamount As Nullable(Of Decimal),  _
                    ByVal firstinstallmentdate As Nullable(Of DateTime),  _
                    ByVal secondinstallmentamount1 As Nullable(Of Decimal),  _
                    ByVal secondinstallmentdate1 As Nullable(Of DateTime),  _
                    ByVal gomorning As Nullable(Of Long),  _
                    ByVal backafternono As Nullable(Of Long),  _
                    ByVal clubway As Nullable(Of Long),  _
                    ByVal subscriptionReturnvalue As Nullable(Of Decimal),  _
                    ByVal amountReturnnote1 As String,  _
                    ByVal firstName1 As String,  _
                    ByVal trdb1 As Nullable(Of Decimal),  _
                    ByVal trcr1 As Nullable(Of Decimal),  _
                    ByVal balance As Nullable(Of Decimal))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
