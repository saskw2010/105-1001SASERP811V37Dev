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

    Partial Public Class schattachglpaylistsBusinessRules
        Inherits eZee.Rules.SharedBusinessRules

        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "UploadFile" and argument that matches "ExternalDoc".
        ''' </summary>
        <Rule("r100")> _
        Public Sub r100Implementation( _
                    ByVal schattachglpayid As Nullable(Of Long), _
                    ByVal schglpaydlyhdregid As Nullable(Of Long), _
                    ByVal schglpaydlyhdregpayDelevername As String, _
                    ByVal schglpaydlyhdregsgmsgm_Nm As String, _
                    ByVal schglpaydlyhdregsgmOpcoOpcoName As String, _
                    ByVal schglpaydlyhdregpayIDregorgNAME_1 As String, _
                    ByVal schglpaydlyhdregacdAcademicYear As String, _
                    ByVal schglpaydlyhdregacdGlFinperiodFin_period_info As String, _
                    ByVal schglpaydlyhdregbranchDesc1 As String, _
                    ByVal schglpaydlyhdregbranchsgmsgm_Nm As String, _
                    ByVal schglpaydlyhdregbranchGenderGender As String, _
                    ByVal schglpaydlyhdregbranchstageShortDesc1 As String, _
                    ByVal schglpaydlyhdregbranchschtypschtypDesc As String, _
                    ByVal schattachglpaytype As String, _
                    ByVal schattachglpayrefno As String, _
                    ByVal schattachglpayrefdate As Nullable(Of DateTime), _
                    ByVal schattachglpayrefpagesno As String, _
                    ByVal notes As String, _
                    ByVal externalDocFileName As String, _
                    ByVal externalDocContentType As String, _
                    ByVal externalDocLength As Nullable(Of Long), ByVal externalDoc As Stream)
            PreventDefault()
            Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
            Dim CacheFolder As String = System.IO.Path.Combine(appDirectory, "schattachglpayid")
            If Not System.IO.Directory.Exists(CacheFolder) Then
                System.IO.Directory.CreateDirectory(CacheFolder)
            End If
            Dim fileName As String = CacheFolder & "\" & schattachglpayid & ".bin"
            Dim output As Stream = File.Create(fileName)
            externalDoc.CopyTo(output)
            output.Close()

        End Sub
    End Class
End Namespace
