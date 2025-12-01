Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports DataLogic
Imports dblayer
Namespace eZee.Rules
    
    Partial Public Class contractshandler
        Inherits eZee.Rules.SharedBusinessRules

        <ControllerAction("Contracts", "editForm1", "Custom", "printreq", ActionPhase.After)> _
       <ControllerAction("Contracts", "editForm1", "Custom", "printreq", ActionPhase.Before)> _
       <ControllerAction("Contracts", "editForm1", "Custom", "printreq", ActionPhase.Execute)> _
        Public Sub mosso()

            Dim sosostr As String
            sosostr = ActionArgs.Current.Values(0).Name

            'MsgBox(sosostr & "    " & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
            Result.NavigateUrl = "~/crystalviewer/ViewReportcon.aspx?repName=contracts&nemo=" & ActionArgs.Current.Values(0).Value

        End Sub
        <ControllerAction("Contracts", "editForm1", "Custom", "printcalc", ActionPhase.After)> _
       <ControllerAction("Contracts", "editForm1", "Custom", "printcalc", ActionPhase.Before)> _
       <ControllerAction("Contracts", "editForm1", "Custom", "printcalc", ActionPhase.Execute)> _
        Public Sub mosso1()

            Dim sosostr As String
            sosostr = ActionArgs.Current.Values(0).Name
            ' MsgBox(sosostr & "    " & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
            Result.NavigateUrl = "~/crystalviewer/ViewReportcon.aspx?repName=contractscalc&nemo=" & ActionArgs.Current.Values(0).Value

        End Sub
        <ControllerAction("Contracts", "grid1", "Custom", "printcon", ActionPhase.After)> _
    <ControllerAction("Contracts", "grid1", "Custom", "printcon", ActionPhase.Before)> _
    <ControllerAction("Contracts", "grid1", "Custom", "printcon", ActionPhase.Execute)> _
        Public Sub mosso3()

            Dim sosostr As String
            sosostr = ActionArgs.Current.Values(0).Name
            ' MsgBox(sosostr & "    " & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
            ' Result.NavigateUrl =
            Result.NavigateUrl = "~/crystalviewer/ViewReportcon.aspx?repName=contractscont&nemo=" & ActionArgs.Current.Values(0).Value

        End Sub

        <ControllerAction("Contracts", "createForm1", "Calculate", ActionPhase.Execute)> _
        Public Sub mossoxcv()

            'Dim sosostr As String
            Dim sosoint As Int32
            sosoint = ActionArgs.Current.Values(1).Value
            'MsgBox(sosostr & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
            'Result.NavigateUrl = "http://www.saskw.com?nemo=" & ActionArgs.Current.Values(0).Value
            Dim teko As Object
            teko = DataLogic.GetValue("SELECT km FROM  ProsTerm  where prostermcode=" & ActionArgs.Current.Values(2).Value)
            If IsDBNull(teko) Then

                UpdateFieldValue("freekm", 0)

            Else

                UpdateFieldValue("freekm", teko)
            End If
            Select Case sosoint
                Case 1
                    teko = DataLogic.GetValue("SELECT Daily_Rate FROM  ProsTerm  where prostermcode=" & ActionArgs.Current.Values(2).Value)
                    If IsDBNull(teko) Then

                        UpdateFieldValue("PricePerDay", 0)

                    Else
                        sosoint = teko
                        UpdateFieldValue("PricePerDay", teko)
                    End If

                Case 2
                    teko = DataLogic.GetValue("SELECT weekly_Rate FROM  ProsTerm  where prostermcode=" & ActionArgs.Current.Values(2).Value)
                    If IsDBNull(teko) Then

                        UpdateFieldValue("PricePerDay", 0)

                    Else
                        sosoint = teko
                        UpdateFieldValue("PricePerDay", teko)
                    End If

                Case 3
                    teko = DataLogic.GetValue("SELECT Monthly_Rate FROM  ProsTerm  where prostermcode=" & ActionArgs.Current.Values(2).Value)
                    If IsDBNull(teko) Then

                        UpdateFieldValue("PricePerDay", 0)

                    Else
                        sosoint = teko
                        UpdateFieldValue("PricePerDay", teko)
                    End If



            End Select



        End Sub
        <ControllerAction("Contracts", "editForm1", "Calculate", ActionPhase.Execute)> _
        Public Sub mossobnk()

            'Dim sosostr As String
            Dim sosoint As Int32
            sosoint = ActionArgs.Current.Values(2).Value
            'MsgBox(sosostr & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
            'Result.NavigateUrl = "http://www.saskw.com?nemo=" & ActionArgs.Current.Values(0).Value
            Dim teko As Object
            teko = DataLogic.GetValue("SELECT km FROM  ProsTerm  where prostermcode=" & ActionArgs.Current.Values(3).Value)
            If IsDBNull(teko) Then

                UpdateFieldValue("freekm", 0)

            Else

                UpdateFieldValue("freekm", teko)
            End If
            Select Case sosoint
                Case 1
                    teko = DataLogic.GetValue("SELECT Daily_Rate FROM  ProsTerm  where prostermcode=" & ActionArgs.Current.Values(3).Value)
                    If IsDBNull(teko) Then

                        UpdateFieldValue("PricePerDay", 0)

                    Else
                        sosoint = teko
                        UpdateFieldValue("PricePerDay", teko)
                    End If

                Case 2
                    teko = DataLogic.GetValue("SELECT weekly_Rate FROM  ProsTerm  where prostermcode=" & ActionArgs.Current.Values(3).Value)
                    If IsDBNull(teko) Then

                        UpdateFieldValue("PricePerDay", 0)

                    Else
                        sosoint = teko
                        UpdateFieldValue("PricePerDay", teko)
                    End If

                Case 3
                    teko = DataLogic.GetValue("SELECT Monthly_Rate FROM  ProsTerm  where prostermcode=" & ActionArgs.Current.Values(3).Value)
                    If IsDBNull(teko) Then

                        UpdateFieldValue("PricePerDay", 0)

                    Else
                        sosoint = teko
                        UpdateFieldValue("PricePerDay", teko)
                    End If



            End Select



        End Sub
        <ControllerAction("Contracts", "editForm1", "Custom", "printcon", ActionPhase.After)> _
   <ControllerAction("Contracts", "editForm1", "Custom", "printcon", ActionPhase.Before)> _
   <ControllerAction("Contracts", "editForm1", "Custom", "printcon", ActionPhase.Execute)> _
        Public Sub mosso6()
            Dim sosostr As String
            sosostr = ActionArgs.Current.Values(0).Name
            ' MsgBox(sosostr & "    " & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
            ' Result.NavigateUrl =
            Result.NavigateUrl = "~/crystalviewer/ViewReportcon.aspx?repName=contractscont&nemo=" & ActionArgs.Current.Values(0).Value

        End Sub
        <ControllerAction("Contracts", "editForm1", "Custom", "printpur", ActionPhase.After)> _
     <ControllerAction("Contracts", "editForm1", "Custom", "printpur", ActionPhase.Before)> _
     <ControllerAction("Contracts", "editForm1", "Custom", "printpur", ActionPhase.Execute)> _
        Public Sub mosso4()
            Dim sosostr As String
            sosostr = ActionArgs.Current.Values(0).Name
            ' MsgBox(sosostr & "    " & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
            Result.NavigateUrl = "~/crystalviewer/ViewReportcon.aspx?repName=contractstalab&nemo=" & ActionArgs.Current.Values(0).Value

        End Sub
        <ControllerAction("Contracts", "editForm1", "Custom", "printezn", ActionPhase.After)> _
     <ControllerAction("Contracts", "editForm1", "Custom", "printezn", ActionPhase.Before)> _
     <ControllerAction("Contracts", "editForm1", "Custom", "printezn", ActionPhase.Execute)> _
        Public Sub mosso5()

            Dim sosostr As String
            sosostr = ActionArgs.Current.Values(0).Name
            ' MsgBox(sosostr & "    " & ActionArgs.Current.Values(0).Value, MsgBoxStyle.Information + MsgBoxStyle.SystemModal, "yam=wad")
            Result.NavigateUrl = "~/crystalviewer/ViewReportcon.aspx?repName=contractsezn&nemo=" & ActionArgs.Current.Values(0).Value

        End Sub
    End Class
End Namespace
