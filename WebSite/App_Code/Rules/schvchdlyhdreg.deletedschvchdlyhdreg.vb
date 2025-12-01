Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class schvchdlyhandeler
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view before an action
        ''' with a command name that matches "Delete".
        ''' </summary>
        <Rule("deletedschvchdlyhdreg")>  _
        Public Sub deletedschvchdlyhdregImplementation(ByVal schvchdlyhdregid As Nullable(Of Long), ByVal trs_Dt As Nullable(Of DateTime), ByVal balance As Nullable(Of Decimal), ByVal notes As String, ByVal approved As Nullable(Of Boolean), ByVal posted As Nullable(Of Boolean), ByVal modifiedBy As String, ByVal modifiedByUserId As Nullable(Of System.Guid), ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdById As Nullable(Of System.Guid), ByVal createdOn As Nullable(Of DateTime), ByVal sumofdebit As Nullable(Of Decimal))
            'This is the placeholder for method implementation.
            Dim dbinerto As New dblayer
            Dim xinsert As Boolean
            Dim sqlstamemt As String
            If approved = 1 Then
                PreventDefault()
                sqlstamemt = "update schvchdlyhdreg set deleted=1  where   schvchdlyhdregid=" & ActionArgs.Current.Item("schvchdlyhdregid").NewValue & ""
                xinsert = dbinerto.Update(sqlstamemt)
            Else
                sqlstamemt = "delete  from schvchdlydetailreg   where   schvchdlyhdregid=" & ActionArgs.Current.Item("schvchdlyhdregid").NewValue & ""
                xinsert = dbinerto.Delete(sqlstamemt)
                sqlstamemt = "delete  from schvchdlydetailpayment   where   schvchdlyhdregid=" & ActionArgs.Current.Item("schvchdlyhdregid").NewValue & ""
                xinsert = dbinerto.Delete(sqlstamemt)
            End If
        End Sub
    End Class
End Namespace
