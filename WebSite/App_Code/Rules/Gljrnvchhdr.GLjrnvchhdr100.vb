Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class GljrnvchhdrBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view after an action
        ''' with a command name that matches "Update".
        ''' </summary>
        <Rule("GLjrnvchhdr100")>  _
        Public Sub GLjrnvchhdr100Implementation( _
                    ByVal tr_No As Nullable(Of Long),  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal sgmsgm_Nm As String,  _
                    ByVal sgmOpcoOpcoName As String,  _
                    ByVal jr_Ty As Nullable(Of Long),  _
                    ByVal theJr_TyJrty_Nme As String,  _
                    ByVal glFinperiodID As Nullable(Of Long),  _
                    ByVal glFinperiodFin_period_info As String,  _
                    ByVal glFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal glFinperiodaccountnumberClsacc_Acc_Nm As String,  _
                    ByVal glFinperiodaccountnumberAcc_BndAcc_Nm As String,  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal manualcode As String,  _
                    ByVal tr_Ds As String,  _
                    ByVal balance As Nullable(Of Decimal),  _
                    ByVal notes As String,  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal posted As Nullable(Of Boolean),  _
                    ByVal deleted As Nullable(Of Boolean),  _
                    ByVal havdetails As Nullable(Of Boolean),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
			Dim sosostr As String
			Dim sosoname As String
            sosostr = ActionArgs.Current.Item("tr_No").NewValue
            sosoname = ActionArgs.Current.Item("sgm").NewValue
            'MsgBox(sosostr & "    " & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
            'Result.NavigateUrl = "~/crystalviewer/ViewReportcon.aspx?repName=Contractscalc&nemo=" & sosostr
            'Result.NavigateUrl = "webreportviwer.aspx?reportquery=GLjrnvchhdr&idfilter=" & sosostr '& "&sosoname=" & sosoname
            'Result.continue

        End Sub
    End Class
End Namespace
