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

    Partial Public Class schattachvchlistsBusinessRules
        Inherits eZee.Rules.SharedBusinessRules

        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "UploadFile" and argument that matches "ExternalDoc".
        ''' </summary>
        <Rule("r100")> _
        Public Sub r100Implementation( _
                    ByVal schattachvchid As Nullable(Of Long), _
                    ByVal schvchdlyhdregid As Nullable(Of Long), _
                    ByVal schvchdlyhdregDelevername As String, _
                    ByVal schvchdlyhdregsgmsgm_Nm As String, _
                    ByVal schvchdlyhdregsgmOpcoOpcoName As String, _
                    ByVal schvchdlyhdregIDregorgNAME_1 As String, _
                    ByVal schvchdlyhdregacdAcademicYear As String, _
                    ByVal schvchdlyhdregacdGlFinperiodFin_period_info As String, _
                    ByVal schvchdlyhdregbranchDesc1 As String, _
                    ByVal schvchdlyhdregbranchsgmsgm_Nm As String, _
                    ByVal schvchdlyhdregbranchGenderGender As String, _
                    ByVal schvchdlyhdregbranchstageShortDesc1 As String, _
                    ByVal schvchdlyhdregbranchschtypschtypDesc As String, _
                    ByVal schattachvchtype As String, _
                    ByVal schattachvchrefno As String, _
                    ByVal schattachvchrefdate As Nullable(Of DateTime), _
                    ByVal schattachvchrefpagesno As String, _
                    ByVal notes As String, _
                    ByVal externalDocFileName As String, _
                    ByVal externalDocContentType As String, _
                    ByVal externalDocLength As Nullable(Of Long), ByVal externalDoc As Stream)
            PreventDefault()
            Dim appDirectory As String = HttpContext.Current.Server.MapPath("~")
            Dim CacheFolder As String = System.IO.Path.Combine(appDirectory, "schattachvchid")
            If Not System.IO.Directory.Exists(CacheFolder) Then
                System.IO.Directory.CreateDirectory(CacheFolder)
            End If
            Dim fileName As String = CacheFolder & "\" & schattachvchid & ".bin"
            Dim output As Stream = File.Create(fileName)
            externalDoc.CopyTo(output)
            output.Close()


            'This is the placeholder for method implementation.

        End Sub
    End Class
End Namespace
