Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class glmstrflhandler
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("rcalculate100")>  _
        Public Sub rcalculate100Implementation( _
                    ByVal acc_No As Nullable(Of Long),  _
                    ByVal acc_Bnd As Nullable(Of Long),  _
                    ByVal theAcc_BndAcc_Nm As String,  _
                    ByVal theAcc_Bndaccclassaccountclass As String,  _
                    ByVal theAcc_BndAcc_BabAcc_Nm As String,  _
                    ByVal theAcc_Bndsgmsgm_Nm As String,  _
                    ByVal theAcc_BndsgmOpcoOpcoName As String,  _
                    ByVal acc_Nm As String,  _
                    ByVal acc_Nme As String,  _
                    ByVal clsacc_No As Nullable(Of Long),  _
                    ByVal clsacc_Acc_Nm As String,  _
                    ByVal costCntr_No As Nullable(Of Long),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
			 Dim sosostr As Int64
            Dim sosostr1 As Int64
            Dim sosostr2 As Int64
            
                    If IsNothing(ActionArgs.Current.Item("Acc_Bnd").NewValue) Then
                    Else
                         sosostr2 = ActionArgs.Current.Item("Acc_Bnd").NewValue

                        Dim teko As Object = DataLogic.GetValue("SELECT max(acc_no) FROM  glmstrfl  where  acc_bnd=" & sosostr2)
                        If IsNothing(teko) Or IsDBNull(teko) Then
                            UpdateFieldValue("Acc_No", sosostr2 & "0001")
                        Else
                            teko = teko + 1
                            UpdateFieldValue("Acc_No", teko)
                        End If





                    End If
        End Sub
    End Class
End Namespace
