Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schglpaydlyhdreg2BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in the view with id matching "editForm1" for an action
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("calculater100")>  _
        Public Sub calculater100Implementation( _
                    ByVal schglpaydlyhdregid As Nullable(Of Long),  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal sgmsgm_Nm As String,  _
                    ByVal sgmOpcoOpcoName As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal payBalance As Nullable(Of Decimal),  _
                    ByVal payReferanceNo As Nullable(Of Long),  _
                    ByVal payIDregorg As Nullable(Of Long),  _
                    ByVal payIDregorgNAME_1 As String,  _
                    ByVal payDelevername As String,  _
                    ByVal payDelevercivil As String,  _
                    ByVal payDeleverTel As String,  _
                    ByVal payNotes As String,  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal posted As Nullable(Of Boolean),  _
                    ByVal deleted As Nullable(Of Boolean),  _
                    ByVal havdetails As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal acdAcademicYear As String,  _
                    ByVal acdGlFinperiodFin_period_info As String,  _
                    ByVal acdGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal auditing As Nullable(Of Boolean),  _
                    ByVal auditnotes As String,  _
                    ByVal pymnt_No As Nullable(Of Long),  _
                    ByVal pymnt_Pymnt_Nm As String,  _
                    ByVal pymnt_pymnt_accAcc_Nm As String,  _
                    ByVal pymnt_pymnt_accClsacc_Acc_Nm As String,  _
                    ByVal pymnt_pymnt_accAcc_BndAcc_Nm As String,  _
                    ByVal pymnt_sgmsgm_Nm As String,  _
                    ByVal pymnt_sgmOpcoOpcoName As String,  _
                    ByVal sumofdebit As Nullable(Of Decimal))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
