Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security
Imports System.IO

Namespace eZee.Rules

    Partial Public Class schattachGljrnvchhdrTlistsBusinessRules
        Inherits eZee.Rules.SharedBusinessRules

        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "UploadFile" and argument that matches "ExternalDoc".
        ''' </summary>
        <Rule("r100")> _
        Public Sub r100Implementation( _
                    ByVal schattachGljrnvchhdrTid As Nullable(Of Long), _
                    ByVal schGljrnvchhdrTdlyhdregid As Nullable(Of Long), _
                    ByVal schGljrnvchhdrTdlyhdregManualcode As String, _
                    ByVal schGljrnvchhdrTdlyhdregGlFinperiodFin_period_info As String, _
                    ByVal schGljrnvchhdrTdlyhdregGlFinperiodaccountnumberAcc_Nm As String, _
                    ByVal schGljrnvchhdrTdlyhdregJr_TyJrty_Nme As String, _
                    ByVal schGljrnvchhdrTdlyhdregsgmsgm_Nm As String, _
                    ByVal schGljrnvchhdrTdlyhdregsgmOpcoOpcoName As String, _
                    ByVal schGljrnvchhdrTdlyhdregbranchDesc1 As String, _
                    ByVal schGljrnvchhdrTdlyhdregbranchsgmsgm_Nm As String, _
                    ByVal schGljrnvchhdrTdlyhdregbranchGenderGender As String, _
                    ByVal schGljrnvchhdrTdlyhdregbranchstageShortDesc1 As String, _
                    ByVal schGljrnvchhdrTdlyhdregbranchschtypschtypDesc As String, _
                    ByVal schattachGljrnvchhdrTtype As String, _
                    ByVal schattachGljrnvchhdrTrefno As String, _
                    ByVal schattachGljrnvchhdrTrefdate As Nullable(Of DateTime), _
                    ByVal schattachGljrnvchhdrTrefpagesno As String, _
                    ByVal notes As String, _
                    ByVal externalDocFileName As String, _
                    ByVal externalDocContentType As String, _
                    ByVal externalDocLength As Nullable(Of Long), ByVal externalDoc As Stream)
            PreventDefault()
            Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
            Dim CacheFolder As String = System.IO.Path.Combine(appDirectory, "schattachGljrnvchhdrTid")
            If Not System.IO.Directory.Exists(CacheFolder) Then
                System.IO.Directory.CreateDirectory(CacheFolder)
            End If
            Dim fileName As String = CacheFolder & "\" & schattachGljrnvchhdrTid & ".bin"
            Dim output As Stream = File.Create(fileName)
            externalDoc.CopyTo(output)
            output.Close()

        End Sub
    End Class
End Namespace
