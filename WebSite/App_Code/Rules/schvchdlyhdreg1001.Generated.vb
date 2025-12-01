Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schvchdlyhdreg1001BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <ControllerAction("schvchdlyhdreg1001", "Calculate", "moneypaidto")>  _
        Public Sub Calculateschvchdlyhdreg1001( _
                    ByVal schvchdlyhdregid As Nullable(Of Long),  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal sgmsgm_Nm As String,  _
                    ByVal sgmOpcoOpcoName As String,  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal balance As Nullable(Of Decimal),  _
                    ByVal referanceNo As Nullable(Of Long),  _
                    ByVal iDregorg As Nullable(Of Long),  _
                    ByVal delevername As String,  _
                    ByVal deleverTel As String,  _
                    ByVal notes As String,  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal posted As Nullable(Of Boolean),  _
                    ByVal deleted As Nullable(Of Boolean),  _
                    ByVal havdetails As Nullable(Of Boolean),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchstageShortDesc1 As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal acdcode As Nullable(Of Long),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal auditing As Nullable(Of Boolean),  _
                    ByVal sumofdebit As Nullable(Of Decimal),  _
                    ByVal countofdetails As Nullable(Of Long),  _
                    ByVal countofpayments As Nullable(Of Long),  _
                    ByVal studentlist As String,  _
                    ByVal academicYear As String,  _
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
                    ByVal checkdate As Nullable(Of DateTime))
            UpdateFieldValue("moneypaidto", rosom+Bookrosom+Transportation+rosomregister)
        End Sub
        
        <RowBuilder("schvchdlyhdreg1001", RowKind.New)>  _
        Public Sub BuildNewschvchdlyhdreg1001()
            UpdateFieldValue("sgm", CType(HttpContext.Current.Session.Item("sgm"),Int64))
            UpdateFieldValue("Trs_Dt", DateTime.Now)
            UpdateFieldValue("Balance", 0)
            '            UpdateFieldValue("ReferanceNo", getmyreferance())
            UpdateFieldValue("branch", CType(HttpContext.Current.Session.Item("branch"),Int64))
            UpdateFieldValue("acdcode", CType(HttpContext.Current.Session.Item("acdcode"),Int64))
            UpdateFieldValue("sumofdebit", 0)
            UpdateFieldValue("rosom", 0)
            UpdateFieldValue("Bookrosom", 0)
            UpdateFieldValue("Transportation", 0)
            UpdateFieldValue("rosomregister", 0)
        End Sub
    End Class
End Namespace
