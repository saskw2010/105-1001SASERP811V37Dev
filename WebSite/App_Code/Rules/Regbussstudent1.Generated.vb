Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class Regbussstudent1BusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        <RowBuilder("Regbussstudent1", RowKind.New)>  _
        Public Sub BuildNewRegbussstudent1()
            UpdateFieldValue("transdate", DateTime.Now())
            UpdateFieldValue("startdate", DateTime.Parse("2014-09-01"))
            UpdateFieldValue("enddate", DateTime.Parse("2015-05-31"))
            UpdateFieldValue("periodpermonth", 9)
            UpdateFieldValue("AmountDiscount", 0)
            UpdateFieldValue("Amountadded", 0)
            UpdateFieldValue("TotalAmount", 0)
            UpdateFieldValue("acdcode", 32)
            UpdateFieldValue("Restperiodpermonth", 0)
            UpdateFieldValue("RestTotalAmount", 0)
            UpdateFieldValue("gomorning", 1)
            UpdateFieldValue("backafternono", 1)
            UpdateFieldValue("clubway", 0)
        End Sub
    End Class
End Namespace
