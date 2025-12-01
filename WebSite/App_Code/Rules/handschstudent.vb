Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Rules
    
    Partial Public Class handschstudent
        Inherits eZee.Rules.SharedBusinessRules
        <ControllerAction("SchStudent", "grid1", "Custom", "ag9row", ActionPhase.Execute)> _
        Public Sub mosso1()

            Dim sosostr As String
            sosostr = ActionArgs.Current.Values(0).Name
            'MsgBox(sosostr & "    " & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
            Result.NavigateUrl = "~/Pages/p130109095150.aspx?nemo=" & ActionArgs.Current.Values(0).Value

        End Sub
    End Class
End Namespace
