Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schattachGljrnvchhdrTlistsBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Select".
        ''' </summary>
        <Rule("r102")>  _
        Public Sub r102Implementation( _
                    ByVal schattachGljrnvchhdrTid As Nullable(Of Long),  _
                    ByVal schGljrnvchhdrTdlyhdregid As Nullable(Of Long),  _
                    ByVal schGljrnvchhdrTdlyhdregManualcode As String,  _
                    ByVal schGljrnvchhdrTdlyhdregGlFinperiodFin_period_info As String,  _
                    ByVal schGljrnvchhdrTdlyhdregGlFinperiodaccountnumberAcc_Nm As String,  _
                    ByVal schGljrnvchhdrTdlyhdregJr_TyJrty_Nme As String,  _
                    ByVal schGljrnvchhdrTdlyhdregsgmsgm_Nm As String,  _
                    ByVal schGljrnvchhdrTdlyhdregsgmOpcoOpcoName As String,  _
                    ByVal schGljrnvchhdrTdlyhdregbranchDesc1 As String,  _
                    ByVal schGljrnvchhdrTdlyhdregbranchsgmsgm_Nm As String,  _
                    ByVal schGljrnvchhdrTdlyhdregbranchGenderGender As String,  _
                    ByVal schGljrnvchhdrTdlyhdregbranchstageShortDesc1 As String,  _
                    ByVal schGljrnvchhdrTdlyhdregbranchschtypschtypDesc As String,  _
                    ByVal schattachGljrnvchhdrTtype As String,  _
                    ByVal schattachGljrnvchhdrTrefno As String,  _
                    ByVal schattachGljrnvchhdrTrefdate As Nullable(Of DateTime),  _
                    ByVal schattachGljrnvchhdrTrefpagesno As String,  _
                    ByVal notes As String,  _
                    ByVal externalDocFileName As String,  _
                    ByVal externalDocContentType As String,  _
                    ByVal externalDocLength As Nullable(Of Long))
            'This is the placeholder for method implementation.
            'This is the placeholder for method implementation.
            If Not String.IsNullOrEmpty(externalDocFileName) Then
                UpdateFieldValue("ExternalDoc", schattachGljrnvchhdrTid)
            Else
                UpdateFieldValue("ExternalDoc", String.Format("null|{0}", schattachGljrnvchhdrTid))
            End If
        End Sub
    End Class
End Namespace
