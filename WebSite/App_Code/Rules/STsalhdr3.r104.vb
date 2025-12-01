Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class STsalhdr3BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in the view with id matching "editForm1" after an action
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("r104")>  _
        Public Sub r104Implementation( _
                    ByVal doc_No As Nullable(Of Long),  _
                    ByVal brn_No As Nullable(Of Long),  _
                    ByVal brn_Brn_Nm As String,  _
                    ByVal pym_No As Nullable(Of Long),  _
                    ByVal pym_Pymnt_Nm As String,  _
                    ByVal pym_pymnt_accAcc_Nm As String,  _
                    ByVal pym_pymnt_accClsacc_Acc_Nm As String,  _
                    ByVal pym_pymnt_accAcc_BndAcc_Nm As String,  _
                    ByVal pym_sgmsgm_Nm As String,  _
                    ByVal pym_sgmOpcoOpcoName As String,  _
                    ByVal slm_No As Nullable(Of Long),  _
                    ByVal slm_Slm_Nm As String,  _
                    ByVal slm_masngerclassmasngerclass As String,  _
                    ByVal doc_Dt As Nullable(Of DateTime),  _
                    ByVal doc_ty As Nullable(Of Long),  _
                    ByVal typcmsup As Nullable(Of Long),  _
                    ByVal typcmsupSubledgerDescrption As String,  _
                    ByVal cstm_No As Nullable(Of Long),  _
                    ByVal cstm_Cstm_Nm As String,  _
                    ByVal cstm_AreaArea_name As String,  _
                    ByVal cstm_EvaluationEvaluation_name As String,  _
                    ByVal cstm_acc_Acc_Nm As String,  _
                    ByVal cstm_acc_Clsacc_Acc_Nm As String,  _
                    ByVal cstm_acc_Acc_BndAcc_Nm As String,  _
                    ByVal cstm_Cntry_Cntry_Nm As String,  _
                    ByVal cstm_curncy_Curncy_Nm As String,  _
                    ByVal cstm_TSNEFTSNEF_name As String,  _
                    ByVal cstm_TSNEFNO1TSNEF1_name As String,  _
                    ByVal cstm_Slm_Slm_Nm As String,  _
                    ByVal cstm_Slm_masngerclassmasngerclass As String,  _
                    ByVal curcode As Nullable(Of Long),  _
                    ByVal curCurncy_Nm As String,  _
                    ByVal curprice As Nullable(Of Decimal),  _
                    ByVal post As Nullable(Of Byte),  _
                    ByVal notes As String,  _
                    ByVal cstm_NM As String,  _
                    ByVal cstm_Add As String,  _
                    ByVal cstm_Tel As String,  _
                    ByVal kETAA As String,  _
                    ByVal sTreet As String,  _
                    ByVal gada As String,  _
                    ByVal house As String,  _
                    ByVal door As String,  _
                    ByVal flat As Nullable(Of Long),  _
                    ByVal keed As Nullable(Of Long),  _
                    ByVal wsl As Nullable(Of Long),  _
                    ByVal submit As Nullable(Of Long),  _
                    ByVal carno As Nullable(Of Long),  _
                    ByVal locno As Nullable(Of Long),  _
                    ByVal refcode As Nullable(Of Long),  _
                    ByVal reftxt As String,  _
                    ByVal whhus As Nullable(Of Long),  _
                    ByVal rest As Nullable(Of Decimal),  _
                    ByVal madfoa As Nullable(Of Decimal),  _
                    ByVal tafmadfoa As String,  _
                    ByVal tafrest As String,  _
                    ByVal taftotal As String,  _
                    ByVal discpercent As Nullable(Of Double),  _
                    ByVal tot_Cost1 As Nullable(Of Decimal),  _
                    ByVal tot_Sal As Nullable(Of Decimal),  _
                    ByVal tot_Cost As Nullable(Of Decimal),  _
                    ByVal tot_Disc As Nullable(Of Decimal),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime))
            'This is the placeholder for method implementation.

        End Sub
    End Class
End Namespace
