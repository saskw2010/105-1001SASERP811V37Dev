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

    Partial Public Class schattachvchlistspurchaseBusinessRules
        Inherits eZee.Rules.SharedBusinessRules

        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "UploadFile" and argument that matches "ExternalDoc".
        ''' </summary>
        <Rule("r100")> _
        Public Sub r100Implementation( _
                    ByVal schattachvchid As Nullable(Of Long), _
                    ByVal doc_no As Nullable(Of Long), _
                    ByVal doc_Referanceno As String, _
                    ByVal doc_sgmsgm_Nm As String, _
                    ByVal doc_sgmOpcoOpcoName As String, _
                    ByVal doc_typcmsupSubledgerDescrption As String, _
                    ByVal doc_Pym_Pymnt_Nm As String, _
                    ByVal doc_Pym_pymnt_accAcc_Nm As String, _
                    ByVal doc_Pym_sgmsgm_Nm As String, _
                    ByVal doc_acdAcademicYear As String, _
                    ByVal doc_branchDesc1 As String, _
                    ByVal doc_branchsgmsgm_Nm As String, _
                    ByVal doc_branchGenderGender As String, _
                    ByVal doc_branchstageShortDesc1 As String, _
                    ByVal doc_branchschtypschtypDesc As String, _
                    ByVal doc_curCurncy_Nm As String, _
                    ByVal doc_Cstm_Sup_Nm As String, _
                    ByVal doc_Cstm_Acc_Acc_Nm As String, _
                    ByVal doc_Cstm_sgmsgm_Nm As String, _
                    ByVal doc_Cstm_Cntry_Cntry_Nm As String, _
                    ByVal doc_Cstm_Curncy_Curncy_Nm As String, _
                    ByVal doc_Slm_Slm_Nm As String, _
                    ByVal doc_Slm_masngerclassmasngerclass As String, _
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
            Dim CacheFolder As String = System.IO.Path.Combine(appDirectory, "schattachvchlistspurchase")
            If Not System.IO.Directory.Exists(CacheFolder) Then
                System.IO.Directory.CreateDirectory(CacheFolder)
            End If
            Dim fileName As String = CacheFolder & "\" & schattachvchid & ".bin"
            Dim output As Stream = File.Create(fileName)
            externalDoc.CopyTo(output)
            output.Close()
        End Sub
    End Class
End Namespace
