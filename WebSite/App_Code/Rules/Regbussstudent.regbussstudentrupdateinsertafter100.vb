Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security
Imports DataLogic
Imports DateDifference
Namespace eZee.Rules
    
    Partial Public Class RegbussstudentBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("regbussstudentrupdateinsertafter100")>  _
        Public Sub regbussstudentrupdateinsertafter100Implementation( _
                    ByVal regbussstudentid As Nullable(Of Long),  _
                    ByVal busid As Nullable(Of Long),  _
                    ByVal busname_1 As String,  _
                    ByVal schareaid As Nullable(Of Long),  _
                    ByVal schareaDesc1 As String,  _
                    ByVal standerdprice As Nullable(Of Long),  _
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
                    ByVal studentareaDesc1 As String,  _
                    ByVal studentbranchDesc1 As String,  _
                    ByVal studentbranchsgmsgm_Nm As String,  _
                    ByVal studentbranchGenderGender As String,  _
                    ByVal studentbranchschtypschtypDesc As String,  _
                    ByVal studentCntry_Cntry_Nm As String,  _
                    ByVal studentGenderGender As String,  _
                    ByVal studentReligionReljan_nm As String,  _
                    ByVal studentstateState_Nm As String,  _
                    ByVal studentidname_1 As String,  _
                    ByVal studentacdAcademicYear As String,  _
                    ByVal studentacdGlFinperiodFin_period_info As String,  _
                    ByVal studentApplicationCodeautocivilidst As String,  _
                    ByVal studentApplicationCodeautoCntry_Cntry_Nm As String,  _
                    ByVal studentApplicationCodeautoCntry_No2Cntry_Nm As String,  _
                    ByVal studentApplicationCodeautoCntry_No1Cntry_Nm As String,  _
                    ByVal studentApplicationCodeautoGenderGender As String,  _
                    ByVal studentApplicationCodeautostateState_Nm As String,  _
                    ByVal studentApplicationCodeautoidname_1 As String,  _
                    ByVal studentApplicationCodeautoAcademicYeartoAcademicYear As String,  _
                    ByVal studentApplicationCodeautoareaDesc1 As String,  _
                    ByVal studentApplicationCodeautobranchDesc1 As String,  _
                    ByVal studentApplicationCodeautoClassClassDesc1 As String,  _
                    ByVal studentApplicationCodeautoSchclasskindSchclasskinddesc As String,  _
                    ByVal studentApplicationCodeautofathercasejob_desc As String,  _
                    ByVal studentApplicationCodeautoGradeAppliedShortDesc1 As String,  _
                    ByVal studentApplicationCodeautomothercasejob_desc As String,  _
                    ByVal studentApplicationCodeautosocialstatusschsocialstatuscaseDesc As String,  _
                    ByVal studentApplicationCodeautoStageAppliedtoShortDesc1 As String,  _
                    ByVal studentApplicationCodeautoschstatus_schstatus_name As String,  _
                    ByVal studentApplicationCodeautoschstclasskinddmgschstclasskinddmgDesc As String,  _
                    ByVal studentApplicationCodeautoschsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal studentApplicationCodeautostudentsefastudentsefaar As String,  _
                    ByVal studentApplicationCodeautoschstudenttypschstudenttyp As String,  _
                    ByVal studentApplicationCodeautoSchtransferSchtransferDesc As String,  _
                    ByVal studentApplicationCodeautoschtrnsschtrnsDesc As String,  _
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
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal gradeacdGlFinperiodFin_period_info As String,  _
                    ByVal gradeStageShortDesc1 As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedByUserId As Nullable(Of System.Guid),  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdById As Nullable(Of System.Guid),  _
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
                    ByVal firstName1 As String)
            'This is the placeholder for method implementation.
            Dim dbinerto As New dblayer
            Dim xinsert As Boolean
            Dim sqlstamemt As String
            sqlstamemt = " select max(regacdmic) as regacdmic from schregacdmic where studentcode=" & ActionArgs.Current.Item("studentcode").NewValue & "" & _
            " and branch=" & ActionArgs.Current.Item("branch").NewValue & " and acdcode=" & ActionArgs.Current.Item("acdcode").NewValue & ""
            Dim tekost As Object
            tekost = DataLogic.GetValue(sqlstamemt)
            If IsNothing(tekost) = False Then
                '----delete old debit amount
                sqlstamemt = " delete  from schregacdmicnew where  amounttype=4 and   regacdmic=" & tekost
                xinsert = dbinerto.Delete(sqlstamemt)
                sqlstamemt = " INSERT INTO [dbo].[schregacdmicnew]([regacdmic] ,[transdate] ,[acdcode] ,[StudentCode] ,[branch] ,[Amount]  ,[amounttype] ,[instalmmentdutydate] )" & _
                               " SELECT    " & tekost & " as tekost,transdate,acdcode,StudentCode, branch, TotalAmount,4 as  amounttype,isnull(firstinstallmentdate,transdate) FROM  Regbussstudent " & _
                               " where regbussstudentid=" & regbussstudentid

                xinsert = dbinerto.Insert(sqlstamemt)


            End If
        End Sub
    End Class
End Namespace
