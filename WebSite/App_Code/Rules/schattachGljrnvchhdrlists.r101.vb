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

    Partial Public Class schattachGljrnvchhdrlistsBusinessRules
        Inherits eZee.Rules.SharedBusinessRules

        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "DownloadFile" and argument that matches "ExternalDoc".
        ''' </summary>
        <Rule("r101")> _
        Public Sub r101Implementation( _
                    ByVal schattachGljrnvchhdrid As Nullable(Of Long), _
                    ByVal tr_No As Nullable(Of Long), _
                    ByVal tr_Manualcode As String, _
                    ByVal tr_GlFinperiodFin_period_info As String, _
                    ByVal tr_GlFinperiodaccountnumberAcc_Nm As String, _
                    ByVal tr_Jr_TyJrty_Nme As String, _
                    ByVal tr_sgmsgm_Nm As String, _
                    ByVal tr_sgmOpcoOpcoName As String, _
                    ByVal tr_branchDesc1 As String, _
                    ByVal tr_branchsgmsgm_Nm As String, _
                    ByVal tr_branchGenderGender As String, _
                    ByVal tr_branchstageShortDesc1 As String, _
                    ByVal tr_branchschtypschtypDesc As String, _
                    ByVal schattachGljrnvchhdrTtype As String, _
                    ByVal schattachGljrnvchhdrTrefno As String, _
                    ByVal schattachGljrnvchhdrTrefdate As Nullable(Of DateTime), _
                    ByVal schattachGljrnvchhdrTrefpagesno As String, _
                    ByVal notes As String, _
                    ByVal externalDocFileName As String, _
                    ByVal externalDocContentType As String, _
                    ByVal externalDocLength As Nullable(Of Long), ByVal externalDoc As Stream)
            'This is the placeholder for method implementation.
            PreventDefault()
            '--------------------------------------------------
            Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
            Dim CacheFolder As String = System.IO.Path.Combine(appDirectory, "schattachGljrnvchhdrid")
            If Not System.IO.Directory.Exists(CacheFolder) Then
                System.IO.Directory.CreateDirectory(CacheFolder)
            End If
            Dim fileName As String = CacheFolder & "\" & schattachGljrnvchhdrid & ".bin"
            '------------------------------------------------------------
            Dim input As Stream = File.OpenRead(fileName)
            input.CopyTo(externalDoc)
            input.Close()
        End Sub
    End Class
End Namespace
