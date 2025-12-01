Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Namespace eZee.Rules
    
    Partial Public Class election5handler
        Inherits eZee.Rules.SharedBusinessRules
        <ControllerAction("election5", "Delete", ActionPhase.Execute)> _
       <ControllerAction("election5", "Delete", ActionPhase.Before)> _
        Public Sub smooso()
            PreventDefault()
            Dim xcv As Object
            xcv = InputBox("أدخل رقم الضامن", "لجان", "0")
            '----------------------------------------------------------------------
            
            'Dim controller As IDataController = ControllerFactory.CreateDataController()
            'Dim actionData As SortedDictionary(Of String, String) = New SortedDictionary(Of String, String)()
            'CType(controller, DataControllerBase).Config.ParseActionData(Arguments.Path, actionData)

            

            '---------------------------------------------------------------
            For Each id As Object In Arguments.SelectedValues
                '------------------------------------stordprocedure
                'Using sql As New SqlProcedure("CopyToOtherTable")
                '    sql.AddParameter("@iD", id)
                '    sql.AddParameter("@Name", name)
                '    sql.AddParameter("@Address", address)
                '    sql.ExecuteNonQuery()
                'End Using
                '-------------------------------entkhabat
                ' MsgBox(id & " --------------     " & xcv, MsgBoxStyle.Information, "hi")
                Using applyDiscount As SqlText = New SqlText(
                    "update [election5] " +
                    "set damincode = @damincode " +
                    "where abslutecode = @id"
                    )
                    applyDiscount.AddParameter("@damincode", xcv)
                    applyDiscount.AddParameter("@id", id)
                    applyDiscount.ExecuteNonQuery()
                End Using
                '--------------------------------------------sqltext
                'Using applyDiscount As SqlText = New SqlText(
                '    "update [carstutuslist] " +
                '    "set carstutus_namee = @carstutus_namee " +
                '    "where carstutus_no = @id"
                '    )
                '    applyDiscount.AddParameter("@carstutus_namee", SelectFieldValue("Parameters_Discount"))
                '    applyDiscount.AddParameter("@id", id)
                '    applyDiscount.ExecuteNonQuery()
                'End Using
                Result.RefreshChildren()
            Next
        End Sub
        '<ControllerAction("election5", "Custom", "lgan", ActionPhase.Execute)> _
        'Public Sub smoosokio()
        '    'PreventDefault()
        '    'Dim xcv As Object
        '    'xcv = InputBox("أدخل رقم اللجنة", "لجان", "0")
        '    For Each id As Object In Arguments.SelectedValues
        '        '------------------------------------stordprocedure
        '        'Using sql As New SqlProcedure("CopyToOtherTable")
        '        '    sql.AddParameter("@iD", id)
        '        '    sql.AddParameter("@Name", name)
        '        '    sql.AddParameter("@Address", address)
        '        '    sql.ExecuteNonQuery()
        '        'End Using
        '        '-------------------------------entkhabat
        '        ' MsgBox(id & " --------------     " & xcv, MsgBoxStyle.Information, "hi")
        '        Using applyDiscount As SqlText = New SqlText(
        '            "update [election5] " +
        '            "set eleclgan = @Parameters_eleclgan " +
        '            "where abslutecode = @id")
        '            applyDiscount.AddParameter("@Parameters_eleclgan", SelectFieldValue("Parameters_eleclgan"))
        '            applyDiscount.AddParameter("@id", id)
        '            applyDiscount.ExecuteNonQuery()
        '        End Using
        '        '--------------------------------------------sqltext
        '        'Using applyDiscount As SqlText = New SqlText(
        '        '    "update [carstutuslist] " +
        '        '    "set carstutus_namee = @carstutus_namee " +
        '        '    "where carstutus_no = @id")
        '        '    applyDiscount.AddParameter("@carstutus_namee", SelectFieldValue("Parameters_Discount"))
        '        '    applyDiscount.AddParameter("@id", id)
        '        '    applyDiscount.ExecuteNonQuery()
        '        'End Using
        '        Result.RefreshChildren()
        '    Next
        'End Sub
    End Class
End Namespace
