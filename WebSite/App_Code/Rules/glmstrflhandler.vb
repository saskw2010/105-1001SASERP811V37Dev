Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Rules
    
    Partial Public Class glmstrflhandler
        Inherits eZee.Rules.SharedBusinessRules
        <ControllerAction("GLmstrfl", "Calculate", ActionPhase.Execute)> _
        Public Sub mosso()

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
