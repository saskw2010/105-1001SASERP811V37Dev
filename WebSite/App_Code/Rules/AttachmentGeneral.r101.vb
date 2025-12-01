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
        ''' with a command name that matches "Scanfile" and argument that matches "Scanfile".
        ''' </summary>
        <Rule("r101")>  _
        Public Sub r101Implementation( _
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
                    ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
            HttpContext.Current.Session.Add("attachmentNoscan", attachmentNo)
            'Result.NavigateUrl = "~/online_demo_scan.aspx?sacnfilename=" + attachmentNo.ToString() + ""
            Dim urlstring As String
            urlstring = ConfigurationManager.AppSettings("scanurl").ToString()
            Result.NavigateUrl = urlstring + "?sacnfilename=" + attachmentNo.ToString() + ""
        End Sub
    End Class
End Namespace
