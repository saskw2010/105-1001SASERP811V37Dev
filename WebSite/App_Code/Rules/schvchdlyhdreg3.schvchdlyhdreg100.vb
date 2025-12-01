Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schvchdlyhdreg3BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view after an action
        ''' with a command name that matches "Update".
        ''' </summary>
        <Rule("schvchdlyhdreg100")>  _
        Public Sub schvchdlyhdreg100Implementation( _
                    ByVal schvchdlyhdregid As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal sgmsgm_Nm As String,  _
                    ByVal sgmOpcoOpcoName As String,  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal balance As Nullable(Of Decimal),  _
                    ByVal referanceNo As Nullable(Of Long),  _
                    ByVal iDregorg As Nullable(Of Long),  _
                    ByVal delevername As String,  _
                    ByVal delevercivil As String,  _
                    ByVal deleverTel As String,  _
                    ByVal notes As String,  _
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
                    ByVal auditing As Nullable(Of Boolean),  _
                    ByVal auditnotes As String,  _
                    ByVal rosom As Nullable(Of Decimal),  _
                    ByVal bookrosom As Nullable(Of Decimal),  _
                    ByVal transportation As Nullable(Of Decimal),  _
                    ByVal rosomregister As Nullable(Of Decimal),  _
                    ByVal cash As Nullable(Of Decimal),  _
                    ByVal keynet As Nullable(Of Decimal),  _
                    ByVal transno As Nullable(Of Long),  _
                    ByVal checkvalue As Nullable(Of Decimal),  _
                    ByVal checknumber As Nullable(Of Decimal),  _
                    ByVal tRANSFER As Nullable(Of Decimal),  _
                    ByVal dISTRIBUTION As Nullable(Of Decimal),  _
                    ByVal sumofdebitcal1 As Nullable(Of Decimal),  _
                    ByVal sumofcerditcal As Nullable(Of Decimal),  _
                    ByVal totalbalance1 As Nullable(Of Decimal),  _
                    ByVal pymnt_No As Nullable(Of Long),  _
                    ByVal schBnk_No As Nullable(Of Long),  _
                    ByVal checkAccount As String,  _
                    ByVal moneypaidto As Nullable(Of Decimal),  _
                    ByVal checkdate As Nullable(Of DateTime),  _
                    ByVal sumofdebit As Nullable(Of Decimal),  _
                    ByVal fathercode As Nullable(Of Long),  _
                    ByVal printcount As Nullable(Of Long),  _
                    ByVal schpaymenttypeid As Nullable(Of Long),  _
                    ByVal countofdetails As Nullable(Of Long),  _
                    ByVal countofpayments As Nullable(Of Long),  _
                    ByVal studentlist As String,  _
                    ByVal academicYear As String,  _
                    ByVal trcrvalue As Nullable(Of Decimal))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
