Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class BatchInvoicingBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view before an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("BatchInvoicingr100")>  _
        Public Sub BatchInvoicingr100Implementation( _
                    ByVal batchInvoicingid As Nullable(Of Long),  _
                    ByVal batchInvoicingdate As Nullable(Of DateTime),  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal sgmsgm_Nm As String,  _
                    ByVal sgmOpcoOpcoName As String,  _
                    ByVal branch As Nullable(Of Long),  _
                    ByVal thebranchDesc1 As String,  _
                    ByVal thebranchsgmsgm_Nm As String,  _
                    ByVal thebranchsgmOpcoOpcoName As String,  _
                    ByVal thebranchGenderGender As String,  _
                    ByVal thebranchschtypschtypDesc As String,  _
                    ByVal batchInvoicingacc_no As Nullable(Of Long),  _
                    ByVal batchInvoicingacc_Acc_Nm As String,  _
                    ByVal batchInvoicingacc_Clsacc_Acc_Nm As String,  _
                    ByVal batchInvoicingacc_Acc_BndAcc_Nm As String,  _
                    ByVal batchInvoicingacc_Acc_Bndaccclassaccountclass As String,  _
                    ByVal batchInvoicingacc_Acc_BndAcc_BabAcc_Nm As String,  _
                    ByVal batchInvoicingTypNO As Nullable(Of Long),  _
                    ByVal batchInvoicingCSUPNO As Nullable(Of Long),  _
                    ByVal batchInvoicingNotes As String)
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
