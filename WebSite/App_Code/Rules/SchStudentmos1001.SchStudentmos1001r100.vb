Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class SchStudentmos1001BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Custom" and argument that matches "printbaraa".
        ''' </summary>
        <Rule("SchStudentmos1001r100")>  _
        Public Sub SchStudentmos1001r100Implementation( _
                    ByVal studentCode As Nullable(Of Long),  _
                    ByVal schstCivilidnumber As String,  _
                    ByVal firstName1 As String,  _
                    ByVal firstName2 As String,  _
                    ByVal schstEmail As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchopcoOpcoName As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal fatherCode As Nullable(Of Long),  _
                    ByVal fatherfathfirstname1 As String,  _
                    ByVal fatherMaritalStatusStatus_Nm As String,  _
                    ByVal fatherareaDesc1 As String,  _
                    ByVal fatherCntry_Cntry_Nm As String,  _
                    ByVal fatherreligionReljan_nm As String,  _
                    ByVal fatherStateState_Nm As String,  _
                    ByVal fatherjob_job_desc As String,  _
                    ByVal motherCode As Nullable(Of Long),  _
                    ByVal motherfirstname1 As String,  _
                    ByVal motherareaDesc1 As String,  _
                    ByVal motherCntry_Cntry_Nm As String,  _
                    ByVal motherreligionReljan_nm As String,  _
                    ByVal motherStateState_Nm As String,  _
                    ByVal motherjob_job_desc As String,  _
                    ByVal religion As Nullable(Of Long),  _
                    ByVal religionReljan_nm As String,  _
                    ByVal cntry_No As Nullable(Of Long),  _
                    ByVal cntry_Cntry_Nm As String,  _
                    ByVal genderid As Nullable(Of Long),  _
                    ByVal genderGender As String,  _
                    ByVal joiningdate As Nullable(Of DateTime),  _
                    ByVal state As Nullable(Of Long),  _
                    ByVal stateState_Nm As String,  _
                    ByVal area As Nullable(Of Long),  _
                    ByVal areaDesc1 As String,  _
                    ByVal blockno As String,  _
                    ByVal streetno As String,  _
                    ByVal gadah As Nullable(Of Long),  _
                    ByVal houseno As String,  _
                    ByVal addressdetail As String,  _
                    ByVal emergencyTelNo1 As String,  _
                    ByVal emergencyTelNo2 As String,  _
                    ByVal emergencyTelNo3 As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal stage As Nullable(Of Long),  _
                    ByVal stageShortDesc1 As String,  _
                    ByVal gradeCode As Nullable(Of Long),  _
                    ByVal gradeShortDesc1 As String,  _
                    ByVal gradeacdAcademicYear As String,  _
                    ByVal [class] As Nullable(Of Long),  _
                    ByVal classClassDesc1 As String,  _
                    ByVal schstatus_code As Nullable(Of Long),  _
                    ByVal schstatus_schstatus_name As String,  _
                    ByVal schstudenttypid As Nullable(Of Long),  _
                    ByVal schstudenttypschstudenttyp As String,  _
                    ByVal birthDate As Nullable(Of DateTime),  _
                    ByVal birthDocNo As String,  _
                    ByVal birthdocdate As Nullable(Of DateTime),  _
                    ByVal birthDocPlace As String,  _
                    ByVal birthPlace As String,  _
                    ByVal residencenumber As String,  _
                    ByVal residenceExpDate As Nullable(Of DateTime),  _
                    ByVal residenceaddress As String,  _
                    ByVal id As Nullable(Of Long),  _
                    ByVal theidname_1 As String,  _
                    ByVal joindate As Nullable(Of DateTime),  _
                    ByVal schstsplid As Nullable(Of Long),  _
                    ByVal schstsplschstsplDsc As String,  _
                    ByVal schclasskindid As Nullable(Of Long),  _
                    ByVal schclasskindSchclasskinddesc As String,  _
                    ByVal schstclasskinddmgid As Nullable(Of Long),  _
                    ByVal schstclasskinddmgschstclasskinddmgDesc As String,  _
                    ByVal schtransferid As Nullable(Of Long),  _
                    ByVal schtransferSchtransferDesc As String,  _
                    ByVal studentsefa As Nullable(Of Long),  _
                    ByVal studentsefastudentsefaar As String,  _
                    ByVal schsthlthcaseid As Nullable(Of Long),  _
                    ByVal schsthlthcaseschsthlthcaseDesc As String,  _
                    ByVal resigncases As String,  _
                    ByVal civilidExpDate As Nullable(Of DateTime),  _
                    ByVal notes As String,  _
                    ByVal passportNumber As String,  _
                    ByVal passportPlace As String,  _
                    ByVal passportIssueDate As Nullable(Of DateTime),  _
                    ByVal passportExpDate As Nullable(Of DateTime),  _
                    ByVal photoFileName As String,  _
                    ByVal photoLength As Nullable(Of Integer),  _
                    ByVal photoContentType As String,  _
                    ByVal pictureFileName As String,  _
                    ByVal pictureContentType As String,  _
                    ByVal pictureLength As Nullable(Of Integer),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal accountnumber As Nullable(Of Decimal),  _
                    ByVal fatherrecord As Nullable(Of Boolean),  _
                    ByVal field1 As String,  _
                    ByVal field11 As String,  _
                    ByVal field12 As String,  _
                    ByVal field13 As String,  _
                    ByVal field14 As String,  _
                    ByVal field15 As String,  _
                    ByVal field16 As String,  _
                    ByVal field17 As String,  _
                    ByVal field171 As String,  _
                    ByVal applicationCodeauto As Nullable(Of Long),  _
                    ByVal theApplicationCodeautocivilidst As String,  _
                    ByVal theApplicationCodeautoCntry_Cntry_Nm As String,  _
                    ByVal theApplicationCodeautoAcademicYeartoAcademicYear As String,  _
                    ByVal theApplicationCodeautobranchDesc1 As String,  _
                    ByVal theApplicationCodeautobranchsgmsgm_Nm As String,  _
                    ByVal theApplicationCodeautobranchopcoOpcoName As String,  _
                    ByVal theApplicationCodeautobranchschtypschtypDesc As String,  _
                    ByVal theApplicationCodeautoGradeAppliedShortDesc1 As String,  _
                    ByVal theApplicationCodeautoGradeAppliedacdAcademicYear As String,  _
                    ByVal theApplicationCodeautoStageAppliedtoShortDesc1 As String,  _
                    ByVal startdate As Nullable(Of DateTime),  _
                    ByVal enddate As Nullable(Of DateTime),  _
                    ByVal glFinperiodID As Nullable(Of Long),  _
                    ByVal startdatein As Nullable(Of DateTime),  _
                    ByVal startdatepaystart As Nullable(Of DateTime),  _
                    ByVal typ As Nullable(Of Long))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
