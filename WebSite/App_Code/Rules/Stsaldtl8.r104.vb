Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class Stsaldtl8BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Calculate".
        ''' </summary>
        <Rule("r104")>  _
        Public Sub r104Implementation( _
                    ByVal ln_no As Nullable(Of Long),  _
                    ByVal doc_No As Nullable(Of Long),  _
                    ByVal doc_Notes As String,  _
                    ByVal brn_No As Nullable(Of Long),  _
                    ByVal brn_Brn_Nm As String,  _
                    ByVal brn_BranchDesc1 As String,  _
                    ByVal brn_Branchsgmsgm_Nm As String,  _
                    ByVal brn_BranchGenderGender As String,  _
                    ByVal brn_BranchstageShortDesc1 As String,  _
                    ByVal brn_BranchschtypschtypDesc As String,  _
                    ByVal itm_No As Nullable(Of Long),  _
                    ByVal itm_ID_USER As String,  _
                    ByVal itm_IDGROUPID_USER As String,  _
                    ByVal itm_Sup_Item_name As String,  _
                    ByVal itm_id1DESCRP1 As String,  _
                    ByVal itm_id2DESCRP1 As String,  _
                    ByVal itm_id3DESCRP1 As String,  _
                    ByVal itm_id4DESCRP1 As String,  _
                    ByVal itm_id5DESCRP1 As String,  _
                    ByVal itm_id6DESCRP1 As String,  _
                    ByVal itm_id7DESCRP1 As String,  _
                    ByVal unit_No As Nullable(Of Long),  _
                    ByVal unit_Unit_Nm As String,  _
                    ByVal unitPrice As Nullable(Of Decimal),  _
                    ByVal quantity As Nullable(Of Decimal),  _
                    ByVal discount As Nullable(Of Decimal),  _
                    ByVal titm_Sal As Nullable(Of Decimal),  _
                    ByVal titm_Cost As Nullable(Of Decimal),  _
                    ByVal itm_Cost As Nullable(Of Decimal),  _
                    ByVal catg_No As Nullable(Of Long),  _
                    ByVal paplcprc As Nullable(Of Decimal),  _
                    ByVal nakdy As Nullable(Of Decimal),  _
                    ByVal sup_No As Nullable(Of Long),  _
                    ByVal notesdtl As String,  _
                    ByVal user_Id As Nullable(Of Long),  _
                    ByVal sgm As Nullable(Of Long),  _
                    ByVal darb As Nullable(Of Double),  _
                    ByVal shad As Nullable(Of Decimal),  _
                    ByVal carno As Nullable(Of Decimal),  _
                    ByVal locno As Nullable(Of Decimal),  _
                    ByVal refcode As Nullable(Of Long),  _
                    ByVal reftxt As String,  _
                    ByVal whhus As Nullable(Of Long),  _
                    ByVal reftxt1 As String,  _
                    ByVal idate As Nullable(Of DateTime),  _
                    ByVal modifiedBy As String,  _
                    ByVal modifiedOn As Nullable(Of DateTime),  _
                    ByVal createdBy As String,  _
                    ByVal createdOn As Nullable(Of DateTime),  _
                    ByVal iTEM As String)
            'This is the placeholder for method implementation.
        End Sub
    End Class
End Namespace
