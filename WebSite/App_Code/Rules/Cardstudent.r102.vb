Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class CardstudentBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("r102")>  _
        Public Sub r102Implementation( _
                    ByVal rosom As Nullable(Of Decimal),  _
                    ByVal bookrosom As Nullable(Of Decimal),  _
                    ByVal transportation As Nullable(Of Decimal),  _
                    ByVal rosomregister As Nullable(Of Decimal),  _
                    ByVal cash As Nullable(Of Decimal),  _
                    ByVal keynet As Nullable(Of Decimal),  _
                    ByVal checkvalue As Nullable(Of Decimal),  _
                    ByVal checknumber As Nullable(Of Decimal),  _
                    ByVal transno As Nullable(Of Long),  _
                    ByVal tRANSFER As Nullable(Of Decimal),  _
                    ByVal dISTRIBUTION As Nullable(Of Decimal),  _
                    ByVal pymnt_No As Nullable(Of Long),  _
                    ByVal checkAccount As String,  _
                    ByVal moneypaidto As Nullable(Of Decimal),  _
                    ByVal schBnk_No As Nullable(Of Long),  _
                    ByVal checkdate As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
