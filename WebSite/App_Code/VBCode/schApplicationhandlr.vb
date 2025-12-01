Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports eZee.Data.Objects
Imports DataLogic
Imports DateDifference
Imports dblayer
Namespace eZee.Rules
    
    Partial Public Class schApplicationhandlr
        Inherits eZee.Rules.SharedBusinessRules

        
     

       
        <ControllerAction("schApplication", "editForm1", "Calculate", ActionPhase.Execute), _
         ControllerAction("schApplication", "createForm1", "Calculate", ActionPhase.Execute)> _
        Public Sub mossoxcv()
            Dim tekost As Object
            If IsNothing(ActionArgs.Current.Item("civilidst").NewValue) Or String.IsNullOrEmpty(ActionArgs.Current.Item("civilidst").NewValue) Then
            Else
            tekost = DataLogic.GetValue("SELECT SchstCivilidnumber FROM  SchStudent  where SchstCivilidnumber='" & ActionArgs.Current.Item("civilidst").NewValue & "'")
                If IsNothing(tekost) Then
                    '''UpdateFieldValue("AssessmentFees", 0)
                Else
                    'Result.ShowAlert("this student in our student list before ")
                    PreventDefault()
                    Result.Focus("civilidst", translatemeyamosso.GetResourceValuemosso("this student in our student list before Make reregister for hime"))

                End If


                tekost = DataLogic.GetValue("SELECT civilidst FROM  schApplication  where civilidst='" & ActionArgs.Current.Item("civilidst").NewValue & "'")
                If IsNothing(tekost) Then
                    '''UpdateFieldValue("AssessmentFees", 0)
                Else
                    'Result.ShowAlert("this student in our Application list before ")

                End If
                Dim sosostr As String
                Dim dateDifference As DateDifference
                sosostr = SelectFieldValueObject("civilidst").NewValue.ToString()
                Dim sosostr1 As String = Left(sosostr, 1)
                sosostr1 = CStr(((CInt(sosostr1) - 1) * 100) + 1800 + CInt(Right(Left(sosostr, 3), 2)))
                Dim monthstr1 As String = Right(Left(sosostr, 5), 2)
                Dim daystr1 As String = Right(Left(sosostr, 7), 2)
                Dim birthdate As String = daystr1 & "/" & monthstr1 & "/" & sosostr1
                If IsDate(birthdate) Then

                    Dim datfrom, dateTimeFrom As Date
                    datfrom = CDate(birthdate)
                    UpdateFieldValue("DateofBirth", datfrom.Date.ToShortDateString().ToString())
                    dateTimeFrom = DateTime.Now
                    dateDifference = New DateDifference(datfrom.Date, dateTimeFrom.Date)
                   
                    UpdateFieldValue("ageyear", dateDifference.Years.ToString())
                    UpdateFieldValue("agemonth", dateDifference.Months.ToString())
                    UpdateFieldValue("ageday", dateDifference.Days.ToString())
                    UpdateFieldValue("fromout", False)
                    UpdateFieldValue("Remarks", datfrom.Date.ToShortDateString().ToString())

                End If
                If IsNothing(ActionArgs.Current.Item("dateofcalculate").NewValue) Then
                Else
                    Dim dateDifference1 As New DateDifference(ActionArgs.Current.Item("dateofcalculate").NewValue, DateTime.Now)
                    If dateDifference1.Years.ToString() = "0" Then
                        If dateDifference1.Months.ToString() = "0" Then
                         
                        End If
                    End If
                End If
                If IsNothing(ActionArgs.Current.Item("studentfullname").NewValue) Then
                Else
                    Dim str As String = ActionArgs.Current.Item("studentfullname").NewValue
                    Dim words As String() = str.Split(New Char() {" "c})
                    Dim word1 As String
                    Dim wordfather As String = ""
                    Dim iword As Integer
                    iword = 0
                    For Each word In words
                        If iword = 0 Then
                            word1 = word
                        Else
                            wordfather = wordfather & word & " "
                        End If
                        iword = iword + 1
                    Next
                    wordfather = Trim(wordfather)

                    UpdateFieldValue("Fathername", wordfather)
                End If
                If IsNothing(ActionArgs.Current.Item("GradeApplied").NewValue) Then
                Else
                    If IsNothing(ActionArgs.Current.Item("academicYearto").NewValue) Then
                    Else
                        Dim s2 As schGrade = schGrade.SelectSingle("GradeCode=@GradeCode",
                                           New FieldValue("@GradeCode", ActionArgs.Current.Item("GradeApplied").NewValue))
                        If s2 Is Nothing Then
                            'PreventDefault()
                            'Result.Focus("GradeApplied", translatemeyamosso.GetResourceValuemosso(" age Rule  not Valied"))

                        Else

                            'UpdateFieldValue("AssessmentFees", s2.registerationfees)acdcode = @acdcode and GradeCode=@GradeCode
                            UpdateFieldValue("agarulyear", s2.ageexpectedbyyear)
                            UpdateFieldValue("agarulmonth", s2.ageexpectedbymonth)
                            UpdateFieldValue("dateofcalculate", s2.agecalculatedate) ' يفضل ان تاتي من جدول السنوات للعام القادم  
                            UpdateFieldValue("agarulyearmax", s2.ageexpectedbyyear1)
                            UpdateFieldValue("agarulmonthmax", s2.ageexpectedbymonth1)

                            If IsNothing(ActionArgs.Current.Item("DateofBirth").NewValue) Then
                            Else
                                If IsNothing(s2.agecalculatedate) Then
                                Else

                                    Dim claculateddate As DateTime
                                    claculateddate = s2.agecalculatedate
                                    Dim dateDifference2 As New DateDifference(ActionArgs.Current.Item("DateofBirth").NewValue, claculateddate)

                                    If IsNothing(dateDifference2.Years.ToString()) Then
                                    Else
                                        UpdateFieldValue("ageyear", dateDifference2.Years.ToString())
                                        UpdateFieldValue("agemonth", dateDifference2.Months.ToString())
                                        UpdateFieldValue("ageday", dateDifference2.Days.ToString())
                                        Dim agenow As Object
                                        Dim agerul As Object
                                        Dim agerul1 As Object
                                        agenow = dateDifference2.Years.ToString() + (dateDifference2.Months.ToString() / 12)
                                        agerul = s2.ageexpectedbyyear + (s2.ageexpectedbymonth / 12)
                                        agerul1 = s2.ageexpectedbyyear1 + (s2.ageexpectedbymonth1 / 12)
                                        If agerul > agenow Or agerul1 < agenow Then
                                            UpdateFieldValue("fromout", False)
                                            PreventDefault()
                                            Result.Focus("GradeApplied", translatemeyamosso.GetResourceValuemosso(" age Rule  not Valied"))

                                        Else
                                            UpdateFieldValue("fromout", True)

                                        End If
                                    End If
                                End If
                            End If
                           

                        End If
                    End If
                End If
            End If


        End Sub

      
          
         <ControllerAction("schApplication", "editForm1", "Update", ActionPhase.Before)> _
        Public Sub AssignFieldValuesToschApplicationedit( _
                    ByVal applicationCodeauto As Nullable(Of Long), _
                    ByVal branch As Nullable(Of Long), _
                    ByVal thebranchDesc1 As String, _
                    ByVal thebranchsgmAcc_Nm As String, _
                    ByVal thebranchopcoOpcoName As String, _
                    ByVal thebranchschtypschtypDesc As String, _
                    ByVal civilidst As String, _
                    ByVal applicationDate As Nullable(Of DateTime), _
                    ByVal studentfullname As String, _
                    ByVal fathername As String, _
                    ByVal cntry_No As Nullable(Of Long), _
                    ByVal cntry_Cntry_Nm As String, _
                    ByVal dateofBirth As Nullable(Of DateTime), _
                    ByVal genderid As Nullable(Of Long), _
                    ByVal stageAppliedto As Nullable(Of Long), _
                    ByVal stageAppliedtoShortDesc1 As String, _
                    ByVal gradeApplied As Nullable(Of Long), _
                    ByVal gradeAppliedShortDesc1 As String, _
                    ByVal academicYearto As Nullable(Of Long), _
                    ByVal academicYeartoAcademicYear As String, _
                    ByVal currentSchool As String, _
                    ByVal assessmentFees As Nullable(Of Decimal), _
                    ByVal remarks As String, _
                    ByVal assesmentDate1 As Nullable(Of DateTime), _
                    ByVal assesmentTime1 As Nullable(Of DateTime), _
                    ByVal assesmentRemarks1 As String, _
                    ByVal assesmentDate2 As Nullable(Of DateTime), _
                    ByVal assesmentTime2 As Nullable(Of DateTime), _
                    ByVal fathertel As String, _
                    ByVal fathertel2 As String, _
                    ByVal passfail As Nullable(Of Boolean), _
                    ByVal fromout As Nullable(Of Boolean), _
                    ByVal id As Nullable(Of Long), _
                    ByVal fatherjob As String, _
                    ByVal fatheraddress As String, _
                    ByVal fathertel3 As String, _
                    ByVal fatheremail As String, _
                    ByVal ageyear As Nullable(Of Long), _
                    ByVal agemonth As Nullable(Of Long), _
                    ByVal ageday As Nullable(Of Long))

           Dim tekost As Object
            If IsNothing(ActionArgs.Current.Item("civilidst").NewValue) Or String.IsNullOrEmpty(ActionArgs.Current.Item("civilidst").NewValue) Then
            Else

                tekost = DataLogic.GetValue("SELECT SchstCivilidnumber FROM  SchStudent  where SchstCivilidnumber='" & ActionArgs.Current.Item("civilidst").NewValue & "'")
                If IsNothing(tekost) Then
                    '''UpdateFieldValue("AssessmentFees", 0)
                Else
                    'Result.ShowAlert("this student in our student list before ")

                End If


                tekost = DataLogic.GetValue("SELECT civilidst FROM  schApplication  where  passfail=1 and GradeApplied=" & ActionArgs.Current.Item("GradeApplied").NewValue & " and civilidst='" & ActionArgs.Current.Item("civilidst").NewValue & "'")
                If IsNothing(tekost) Then
                    '''UpdateFieldValue("AssessmentFees", 0)
                Else

                    'Result.ShowAlert("this student in our Application list before ")

                End If
                Dim sosostr As String
                Dim dateDifference As DateDifference
                sosostr = SelectFieldValueObject("civilidst").NewValue.ToString()
                Dim sosostr1 As String = Left(sosostr, 1)
                sosostr1 = CStr(((CInt(sosostr1) - 1) * 100) + 1800 + CInt(Right(Left(sosostr, 3), 2)))
                Dim monthstr1 As String = Right(Left(sosostr, 5), 2)
                Dim daystr1 As String = Right(Left(sosostr, 7), 2)
                Dim birthdate As String = daystr1 & "/" & monthstr1 & "/" & sosostr1
                If IsDate(birthdate) Then

                    Dim datfrom, dateTimeFrom As Date
                    datfrom = CDate(birthdate)
                    UpdateFieldValue("DateofBirth", datfrom.Date.ToShortDateString().ToString())
                    dateTimeFrom = DateTime.Now
                    dateDifference = New DateDifference(datfrom.Date, dateTimeFrom.Date)

                    ' MsgBox("Difference between " + datfrom.Date.ToShortDateString() + " and " + dateTimeFrom.Date.ToShortDateString() + " is :" & vbLf + dateDifference.ToString())
                    UpdateFieldValue("ageyear", dateDifference.Years.ToString())
                    UpdateFieldValue("agemonth", dateDifference.Months.ToString())
                    UpdateFieldValue("ageday", dateDifference.Days.ToString())
                    'UpdateFieldValue("AssessmentFees",)
                    UpdateFieldValue("fromout", False)
                    UpdateFieldValue("Remarks", datfrom.Date.ToShortDateString().ToString())

                End If
                If IsNothing(ActionArgs.Current.Item("dateofcalculate").NewValue) Then
                Else
                    Dim dateDifference1 As New DateDifference(ActionArgs.Current.Item("dateofcalculate").NewValue, DateTime.Now)
                    If dateDifference1.Years.ToString() = "0" Then
                        If dateDifference1.Months.ToString() = "0" Then
                            'PreventDefault()
                            'Result.Focus("GradeApplied", translatemeyamosso.GetResourceValuemosso(" Check schGrade Rule  From Grade List"))
                        End If
                    End If
                End If
                If IsNothing(ActionArgs.Current.Item("studentfullname").NewValue) Then
                Else
                    Dim str As String = ActionArgs.Current.Item("studentfullname").NewValue
                    Dim words As String() = str.Split(New Char() {" "c})
                    Dim word1 As String
                    Dim wordfather As String = ""
                    Dim iword As Integer
                    iword = 0
                    For Each word In words
                        If iword = 0 Then
                            word1 = word
                        Else
                            wordfather = wordfather & word & " "
                        End If
                        iword = iword + 1
                    Next
                    wordfather = Trim(wordfather)

                    UpdateFieldValue("Fathername", wordfather)







                End If
                If IsNothing(ActionArgs.Current.Item("GradeApplied").NewValue) Then
                Else
                    If IsNothing(ActionArgs.Current.Item("academicYearto").NewValue) Then
                    Else
                        Dim s2 As schGrade = schGrade.SelectSingle("GradeCode=@GradeCode",
                                      New FieldValue("@GradeCode", ActionArgs.Current.Item("GradeApplied").NewValue))
                        If s2 Is Nothing Then
                            PreventDefault()
                            Result.Focus("GradeApplied", translatemeyamosso.GetResourceValuemosso(" Check schGrade Rule  From Grade List"))

                        Else

                            'UpdateFieldValue("AssessmentFees", s2.registerationfees)
                            UpdateFieldValue("agarulyear", s2.ageexpectedbyyear)
                            UpdateFieldValue("agarulmonth", s2.ageexpectedbymonth)
                            UpdateFieldValue("dateofcalculate", s2.agecalculatedate) ' يفضل ان تاتي من جدول السنوات للعام القادم  
                            UpdateFieldValue("agarulyearmax", s2.ageexpectedbyyear1)
                            UpdateFieldValue("agarulmonthmax", s2.ageexpectedbymonth1)
                            If IsNothing(ActionArgs.Current.Item("DateofBirth").NewValue) Then
                            Else
                                If IsNothing(s2.agecalculatedate) Then
                                Else

                                    Dim claculateddate As DateTime
                                    claculateddate = s2.agecalculatedate
                                    Dim dateDifference2 As New DateDifference(ActionArgs.Current.Item("DateofBirth").NewValue, claculateddate)

                                    If IsNothing(dateDifference2.Years.ToString()) Then
                                    Else
                                        UpdateFieldValue("ageyear", dateDifference2.Years.ToString())
                                        UpdateFieldValue("agemonth", dateDifference2.Months.ToString())
                                        UpdateFieldValue("ageday", dateDifference2.Days.ToString())
                                        Dim agenow As Object
                                        Dim agerul As Object
                                        Dim agerul1 As Object
                                        agenow = dateDifference2.Years.ToString() + (dateDifference2.Months.ToString() / 12)
                                        agerul = s2.ageexpectedbyyear + (s2.ageexpectedbymonth / 12)
                                        agerul1 = s2.ageexpectedbyyear1 + (s2.ageexpectedbymonth1 / 12)
                                        If agerul > agenow Or agerul1 < agenow Then
                                            UpdateFieldValue("fromout", False)
                                            PreventDefault()
                                            Result.Focus("GradeApplied", translatemeyamosso.GetResourceValuemosso(" age Rule  not Valied"))

                                        Else
                                            UpdateFieldValue("fromout", True)

                                        End If
                                    End If
                                End If
                            End If
                            's.registerationfees = s2.registerationfees
                            's.registrationstartdate = s2.registrationstartdate
                            's.schstatus_code = 1    ' check this
                            's.schstudenttypid = 1    ' check this
                            's.schtrnsid = 1

                            's.Totutionsfees = s2.Totutionsfees
                            's.Books = s2.Books
                            's.Totalfees = s2.Totalfees
                            's.Firstinstalmmentdate = s2.Firstinstalmmentdate
                            's.Firstinstalmmentpercent1 = s2.Firstinstalmmentpercent1

                        End If
                    End If
                End If

                Dim passfailFieldValue As FieldValue = SelectFieldValueObject("passfail")
              
                If passfailFieldValue.NewValue = True Then
                Using myProc As SqlProcedure = New SqlProcedure("schappnewafterupdate")
                myProc.AddParameter("@schappnewafterupdateID", applicationCodeauto)
                myProc.ExecuteNonQuery()
            End Using
                End If
            End If
        End Sub
    End Class
End Namespace
