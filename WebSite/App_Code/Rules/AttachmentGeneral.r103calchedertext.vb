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
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("r103calchedertext")>  _
        Public Sub r103calchedertextImplementation( _
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
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal fielde1001 As String,  _
                    ByVal fielde1002 As String,  _
                    ByVal fielde1003 As String,  _
                    ByVal fielde1004 As String,  _
                    ByVal fielde1005 As String,  _
                    ByVal fielde1006 As String,  _
                    ByVal fielde1007 As String,  _
                    ByVal fielde1008 As String,  _
                    ByVal fielde1009 As String,  _
                    ByVal fielde1010 As String,  _
                    ByVal fielde1011 As String,  _
                    ByVal fielde1012 As String,  _
                    ByVal someFieldHeaderText As String)
            'This is the placeholder for method implementation.



        End Sub
    End Class
End Namespace
