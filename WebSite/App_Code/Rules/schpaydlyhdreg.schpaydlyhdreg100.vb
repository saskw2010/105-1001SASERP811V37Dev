Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schpaydlyhdregBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view after an action
        ''' with a command name that matches "Update".
        ''' </summary>
        <Rule("schpaydlyhdreg100")>  _
        Public Sub schpaydlyhdreg100Implementation( _
                    ByVal schpaydlyhdregid As Nullable(Of Long),  _
                    ByVal trs_Dt As Nullable(Of DateTime),  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal sgmsgm_Nm As String,  _
                    ByVal sgmOpcoOpcoName As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal referanceNo As String,  _
                    ByVal iDregorg As Nullable(Of Long),  _
                    ByVal iDregorgNAME_1 As String,  _
                    ByVal delevername As String,  _
                    ByVal delevercivil As String,  _
                    ByVal deleverTel As String,  _
                    ByVal notes1 As String,  _
                    ByVal balance As Nullable(Of Decimal),  _
                    ByVal notes As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal approved As Nullable(Of Boolean),  _
                    ByVal posted As Nullable(Of Boolean),  _
                    ByVal deleted As Nullable(Of Boolean),  _
                    ByVal havdetails As Nullable(Of Boolean))
            'This is the placeholder for method implementation.
            'Dim sosostr As String
            'Dim sosoname As String
            'sosostr = ActionArgs.Current.Item("schpaydlyhdregid").NewValue
            'sosoname = ActionArgs.Current.Item("sgm").NewValue
            ''MsgBox(sosostr & "    " & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
            ''Result.NavigateUrl = "~/crystalviewer/ViewReportcon.aspx?repName=Contractscalc&nemo=" & sosostr
            'Result.NavigateUrl = "webreportviwer.aspx?reportquery=schpaydlyhdreg&idfilter=" & sosostr & "&sosoname=" & sosoname
            'Result.Continue()
        End Sub
    End Class
End Namespace
