Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security
Imports eZee.Data.Objects
Namespace eZee.Rules
    
    Partial Public Class schvchdlydetailregBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view before an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("schvchdlydetailregbefore")>  _
        Public Sub schvchdlydetailregbeforeImplementation( _
                    ByVal trs_No As Nullable(Of Long),  _
                    ByVal schvchdlyhdregid As Nullable(Of Long),  _
                    ByVal schvchdlyhdregDelevername As String,  _
                    ByVal schvchdlyhdregIDregorgNAME_1 As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchopcoOpcoName As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal studentSchstCivilidnumber As String,  _
                    ByVal studentareaDesc1 As String,  _
                    ByVal studentbranchDesc1 As String,  _
                    ByVal studentbranchsgmsgm_Nm As String,  _
                    ByVal studentbranchopcoOpcoName As String,  _
                    ByVal studentbranchschtypschtypDesc As String,  _
                    ByVal studentCntry_Cntry_Nm As String,  _
                    ByVal studentGenderGender As String,  _
                    ByVal studentReligionReljan_nm As String,  _
                    ByVal studentstateState_Nm As String,  _
                    ByVal studentidname_1 As String,  _
                    ByVal studentacdAcademicYear As String,  _
                    ByVal studentApplicationCodeautocivilidst As String,  _
                    ByVal studentApplicationCodeautoCntry_Cntry_Nm As String,  _
                    ByVal studentApplicationCodeautoAcademicYeartoAcademicYear As String,  _
                    ByVal studentApplicationCodeautobranchDesc1 As String,  _
                    ByVal studentApplicationCodeautoGradeAppliedShortDesc1 As String,  _
                    ByVal studentApplicationCodeautoStageAppliedtoShortDesc1 As String,  _
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
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal schpaymenttypeid As Nullable(Of Long),  _
                    ByVal schpaymenttypeschpaymenttypenm As String,  _
                    ByVal schpaymenttypedebitaccountAcc_Nm As String,  _
                    ByVal schpaymenttypedebitaccountClsacc_Acc_Nm As String,  _
                    ByVal schpaymenttypedebitaccountsgmsgm_Nm As String,  _
                    ByVal schpaymenttypecreditaccountAcc_Nm As String,  _
                    ByVal schpaymenttypecreditaccountClsacc_Acc_Nm As String,  _
                    ByVal schpaymenttypecreditaccountsgmsgm_Nm As String,  _
                    ByVal mony_Paid As Nullable(Of Decimal),  _
                    ByVal voucherno As String,  _
                    ByVal schpaymenttypedt As String,  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedByUserId As Nullable(Of System.Guid),  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdById As Nullable(Of System.Guid),  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal firstName1 As String,  _
                    ByVal firstName2 As String,  _
                    ByVal schstEmail As String,  _
                    ByVal totalbalance As Nullable(Of Decimal),  _
                    ByVal sumofdebitcal As String,  _
                    ByVal sumofdebitcal1 As String,  _
                    ByVal sumofcerditcal As String,  _
                    ByVal totalbalance1 As Nullable(Of Decimal))
            'This is the placeholder for method implementation.
           
			  Dim StudentCodereadFieldValue As FieldValue = SelectFieldValueObject("StudentCoderead")
                    If (Not (StudentCodereadFieldValue) Is Nothing) Then
                        StudentCodereadFieldValue.Modified = false
                    End If
			
            If IsNothing(totalbalance1) Then
			UpdateFieldValue("totalbalance1",0)
           end if
			UpdateFieldValue("totalbalance", ActionArgs.Current.Item("totalbalance1").NewValue - ActionArgs.Current.Item("Mony_Paid").NewValue )
            If IsNothing(ActionArgs.Current.Item("schpaymenttypeid").NewValue) Then
            Else
                'If (ActionArgs.Current.Item("schpaymenttypeid").NewValue > 2) Then
                    If IsNumeric(ActionArgs.Current.Item("totalbalance1").NewValue) Then
                        If ActionArgs.Current.Item("totalbalance1").NewValue < ActionArgs.Current.Item("Mony_Paid").NewValue Then
                            'PreventDefault()
                             'Result.Focus("Mony_Paid", translatemeyamosso.GetResourceValuemosso("The paid Money More Than totalbalance1  "))
							Result.ShowAlert("Mony_Paid", translatemeyamosso.GetResourceValuemosso("The paid Money More Than totalbalance1  "))
                        End If
                    End If
                'End If
            End If
           
           

        End Sub
    End Class
End Namespace
