Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class glmfbandhandeler
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Calculate" and argument that matches "lvl".
        ''' </summary>
        <Rule("calclvlr100")>  _
        Public Sub calclvlr100Implementation( _
                    ByVal acc_Bnd As Nullable(Of Long),  _
                    ByVal parentid As Nullable(Of Long),  _
                    ByVal parentAcc_Nm As String,  _
                    ByVal parentaccclassaccountclass As String,  _
                    ByVal parentAcc_BabAcc_Nm As String,  _
                    ByVal parentsgmsgm_Nm As String,  _
                    ByVal parentsgmOpcoOpcoName As String,  _
                    ByVal acc_Bab As Nullable(Of Long),  _
                    ByVal theAcc_BabAcc_Nm As String,  _
                    ByVal lvl As Nullable(Of Long),  _
                    ByVal acc_Nm As String,  _
                    ByVal acc_Nme As String,  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal thesgmsgm_Nm As String,  _
                    ByVal thesgmOpcoOpcoName As String,  _
                    ByVal accclass As Nullable(Of Long),  _
                    ByVal accclassaccountclass As String,  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedByUserId As Nullable(Of System.Guid),  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdById As Nullable(Of System.Guid),  _
                    ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
			'Result.ShowAlert("wow")
        End Sub
    End Class
End Namespace
