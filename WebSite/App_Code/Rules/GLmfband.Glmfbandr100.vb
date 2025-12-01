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
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("Glmfbandr100")>  _
        Public Sub Glmfbandr100Implementation( _
                    ByVal acc_Bnd As Nullable(Of Long),  _
                    ByVal parentid As Nullable(Of Long),  _
                    ByVal parentAcc_Nm As String,  _
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
                    ByVal modifiedBy As String,  _
                    ByVal modifiedByUserId As Nullable(Of System.Guid),  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdById As Nullable(Of System.Guid),  _
                    ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.
			
            Dim sosostr As Int64
            Dim sosostr1 As Int64
            Dim sosostr2 As Int64
			If IsNothing(ActionArgs.Current.Item("lvl").NewValue) Then
			 UpdateFieldValue("lvl", 1)
			
			else
			
			 UpdateFieldValue("lvl", ActionArgs.Current.Item("lvl").NewValue+1)
			 
			end if
            If IsNothing(ActionArgs.Current.Item("Acc_bab").NewValue) Then
            Else
                If IsNothing(ActionArgs.Current.Item("parentid").NewValue) Then
				sosostr = ActionArgs.Current.Item("Acc_bab").NewValue
				Dim teko11 As Object = DataLogic.GetValue("SELECT max(acc_bnd) FROM  Glmfband  where acc_bab=" & sosostr & "and lvl=" & 1 )
                        If IsNothing(teko11) Or IsDBNull(teko11) Then
                            UpdateFieldValue("Acc_Bnd", sosostr & "01")
                        Else
                            teko11 = teko11 + 1
                            UpdateFieldValue("Acc_Bnd", teko11)
                        End If

                Else
                    
                        sosostr = ActionArgs.Current.Item("Acc_bab").NewValue
                        sosostr1 = ActionArgs.Current.Item("parentid").NewValue
                       

                        Dim teko1 As Object = DataLogic.GetValue("SELECT max(acc_bnd) FROM  Glmfband  where acc_bab=" & sosostr & " and parentid=" & sosostr1 )
                        If IsNothing(teko1) Or IsDBNull(teko1) Then
                            UpdateFieldValue("Acc_Bnd", sosostr1 & "01")
                        Else
                            teko1 = teko1 + 1
                            UpdateFieldValue("Acc_Bnd", teko1)
                        End If

                End If
            End If
        End Sub
    End Class
End Namespace
