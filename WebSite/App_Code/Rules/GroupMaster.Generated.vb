Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class GroupMasterBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("GroupMaster", RowKind.New)>  _
        Public Sub BuildNewGroupMaster()
            UpdateFieldValue("Standardprice", 0)
            UpdateFieldValue("Standardinclude", 1)
            UpdateFieldValue("Proffisionalinclude", 1)
            UpdateFieldValue("Enterpriseinclude", 1)
            UpdateFieldValue("WebEnterpriseinclude", 1)
        End Sub
    End Class
End Namespace
