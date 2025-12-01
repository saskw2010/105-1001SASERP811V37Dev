Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class AttachmentGeneralBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "UploadFile" and argument that matches "ExternalDoc".
        ''' </summary>
        <Rule("r100")>  _
        Public Sub r100Implementation( _
                    ByVal attachmentNo As Nullable(Of Long),  _
                    ByVal attachmentpath As String,  _
                    ByVal attachmentDescription As String,  _
                    ByVal attachmentNotes As String,  _
                    ByVal tasneefcode1 As Nullable(Of Long),  _
                    ByVal theTasneefcode1TasneefDesc1 As String,  _
                    ByVal tasneefcode2 As Nullable(Of Long),  _
                    ByVal theTasneefcode2TasneefDesc1 As String,  _
                    ByVal tasneefcode3 As Nullable(Of Long),  _
                    ByVal theTasneefcode3TasneefDesc1 As String,  _
                    ByVal tasneefcode4 As Nullable(Of Long),  _
                    ByVal theTasneefcode4TasneefDesc1 As String,  _
                    ByVal externalDocFileName As String,  _
                    ByVal externalDocLength As Nullable(Of Long),  _
                    ByVal externalDocContentType As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedByUserId As Nullable(Of System.Guid),  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdById As Nullable(Of System.Guid),  _
                    ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
