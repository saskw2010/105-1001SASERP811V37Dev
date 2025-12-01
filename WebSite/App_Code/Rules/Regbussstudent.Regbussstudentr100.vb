Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security
Imports eZee.Data.Objects
Imports DataLogic
Imports DateDifference
Imports dblayer

Namespace eZee.Rules
    
    Partial Public Class RegbussstudentBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("regbussstudentr100")>  _
        Public Sub regbussstudentr100Implementation( _
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
                    ByVal studentstudentsefadebitaccountAcc_Nm As String,  _
                    ByVal studentschstudenttypschstudenttyp As String,  _
                    ByVal studentSchtransferSchtransferDesc As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchopcoOpcoName As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedByUserId As Nullable(Of System.Guid),  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdById As Nullable(Of System.Guid),  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal schstname1 As String)
            'This is the placeholder for method implementation.
            'Result.ShowAlert(ActionArgs.Current.CommandArgument)
			'ByVal startdate As Nullable(Of DateTime),  _
            'ByVal enddate As Nullable(Of DateTime),  _
		   
		   
            Dim sosoint As Long
            Dim dateDifference As DateDifference
             Dim teko As Object
			 If IsNothing(ActionArgs.Current.Item("startdate").Value) = False Then
             If IsNothing(ActionArgs.Current.Item("enddate").Value) = False Then
                Dim months As Long
                months = DateDiff("m", startdate, enddate)
				
                Dim datfrom, dateTimeFrom As Date
                datfrom = CDate(startdate)
                    dateTimeFrom = CDate(enddate)
                dateDifference = New DateDifference(datfrom.Date, dateTimeFrom.Date)
                                '"Difference between " + datfrom.Date.ToShortDateString() + " and " + dateTimeFrom.Date.ToShortDateString() + " is :"  + 'dateDifference.ToString()
                UpdateFieldValue("firstinstallmentamount", dateDifference.Years.ToString())
                UpdateFieldValue("Amountaddednote", dateDifference.Months.ToString())
                UpdateFieldValue("AmountDiscountnote", dateDifference.Days.ToString())
				if dateDifference.Days.ToString()>0 then
				UpdateFieldValue("periodpermonth", months+1)
                        UpdateFieldValue("TotalAmount", Math.Round(((ActionArgs.Current.Item("standerdprice").Value / 9) * (months + 1)) + (ActionArgs.Current.Item("amountadded").Value - ActionArgs.Current.Item("amountDiscount").Value), 3))
				else
				UpdateFieldValue("periodpermonth", months)
                        UpdateFieldValue("TotalAmount", Math.Round(((ActionArgs.Current.Item("standerdprice").Value / 9) * (months + 1)) + (ActionArgs.Current.Item("amountadded").Value - ActionArgs.Current.Item("amountDiscount").Value), 3))
				end if
				
				
				end if
				end if
				

			
        End Sub
    End Class
End Namespace
