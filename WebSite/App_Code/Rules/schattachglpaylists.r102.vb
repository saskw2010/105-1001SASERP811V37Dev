Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schattachglpaylistsBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Select".
        ''' </summary>
        <Rule("r102")>  _
        Public Sub r102Implementation( _
                    ByVal schattachglpayid As Nullable(Of Long),  _
                    ByVal schglpaydlyhdregid As Nullable(Of Long),  _
                    ByVal schglpaydlyhdregpayDelevername As String,  _
                    ByVal schglpaydlyhdregsgmsgm_Nm As String,  _
                    ByVal schglpaydlyhdregsgmOpcoOpcoName As String,  _
                    ByVal schglpaydlyhdregpayIDregorgNAME_1 As String,  _
                    ByVal schglpaydlyhdregacdAcademicYear As String,  _
                    ByVal schglpaydlyhdregacdGlFinperiodFin_period_info As String,  _
                    ByVal schglpaydlyhdregbranchDesc1 As String,  _
                    ByVal schglpaydlyhdregbranchsgmsgm_Nm As String,  _
                    ByVal schglpaydlyhdregbranchGenderGender As String,  _
                    ByVal schglpaydlyhdregbranchstageShortDesc1 As String,  _
                    ByVal schglpaydlyhdregbranchschtypschtypDesc As String,  _
                    ByVal schattachglpaytype As String,  _
                    ByVal schattachglpayrefno As String,  _
                    ByVal schattachglpayrefdate As Nullable(Of DateTime),  _
                    ByVal schattachglpayrefpagesno As String,  _
                    ByVal notes As String,  _
                    ByVal externalDocFileName As String,  _
                    ByVal externalDocContentType As String,  _
                    ByVal externalDocLength As Nullable(Of Long))
            'This is the placeholder for method implementation.
            'This is the placeholder for method implementation.
            If Not String.IsNullOrEmpty(externalDocFileName) Then
                UpdateFieldValue("ExternalDoc", schattachglpayid)
            Else
                UpdateFieldValue("ExternalDoc", String.Format("null|{0}", schattachglpayid))
            End If
        End Sub
    End Class
End Namespace
