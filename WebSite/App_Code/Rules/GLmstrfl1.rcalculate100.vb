Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class GLmstrfl1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("rcalculate100")>  _
        Public Sub rcalculate100Implementation(ByVal acc_No As Nullable(Of Long), ByVal acc_Bnd As Nullable(Of Long), ByVal theAcc_BndAcc_Nm As String, ByVal theAcc_Bndaccclassaccountclass As String, ByVal theAcc_BndAcc_BabAcc_Nm As String, ByVal acc_Nm As String, ByVal acc_Nme As String, ByVal clsacc_No As Nullable(Of Long), ByVal clsacc_Acc_Nm As String, ByVal acc_Ntr As Nullable(Of Long), ByVal costCntr_No As Nullable(Of Long), ByVal modifiedBy As String, ByVal modifiedOn As Nullable(Of DateTime), ByVal createdBy As String, ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
