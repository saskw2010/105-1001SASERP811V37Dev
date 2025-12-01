Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schattachglvchlistsBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Select".
        ''' </summary>
        <Rule("r102")>  _
        Public Sub r102Implementation( _
                    ByVal schattachglvchid As Nullable(Of Long),  _
                    ByVal schglvchdlyhdregid As Nullable(Of Long),  _
                    ByVal schglvchdlyhdregDelevername As String,  _
                    ByVal schglvchdlyhdregsgmsgm_Nm As String,  _
                    ByVal schglvchdlyhdregsgmOpcoOpcoName As String,  _
                    ByVal schglvchdlyhdregIDregorgNAME_1 As String,  _
                    ByVal schglvchdlyhdregacdAcademicYear As String,  _
                    ByVal schglvchdlyhdregacdGlFinperiodFin_period_info As String,  _
                    ByVal schglvchdlyhdregbranchDesc1 As String,  _
                    ByVal schglvchdlyhdregbranchsgmsgm_Nm As String,  _
                    ByVal schglvchdlyhdregbranchGenderGender As String,  _
                    ByVal schglvchdlyhdregbranchstageShortDesc1 As String,  _
                    ByVal schglvchdlyhdregbranchschtypschtypDesc As String,  _
                    ByVal schattachglvchtype As String,  _
                    ByVal schattachglvchrefno As String,  _
                    ByVal schattachglvchrefdate As Nullable(Of DateTime),  _
                    ByVal schattachglvchrefpagesno As String,  _
                    ByVal notes As String,  _
                    ByVal externalDocFileName As String,  _
                    ByVal externalDocContentType As String,  _
                    ByVal externalDocLength As Nullable(Of Long))
            'This is the placeholder for method implementation.
            'This is the placeholder for method implementation.
            If Not String.IsNullOrEmpty(externalDocFileName) Then
                UpdateFieldValue("ExternalDoc", schattachglvchid)
            Else
                UpdateFieldValue("ExternalDoc", String.Format("null|{0}", schattachglvchid))
            End If
        End Sub
    End Class
End Namespace
