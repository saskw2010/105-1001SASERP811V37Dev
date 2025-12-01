Imports eZee.Data
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Web
Imports System.Web.Security

Namespace eZee.Rules
    
    Partial Public Class CardstudentBusinessRules
        Inherits eZee.Rules.SharedBusinessRules
        
        ''' <summary>
        ''' This method will execute in any view for an action
        ''' with a command name that matches "Insert|Update".
        ''' </summary>
        <Rule("r100")>  _
        Public Sub r100Implementation(ByVal rosom As Nullable(Of Decimal), ByVal bookrosom As Nullable(Of Decimal), ByVal transportation As Nullable(Of Decimal), ByVal rosomregister As Nullable(Of Decimal), ByVal cash As Nullable(Of Decimal), ByVal keynet As Nullable(Of Decimal), ByVal checkvalue As Nullable(Of Decimal), ByVal checknumber As Nullable(Of Decimal), ByVal transno As Nullable(Of Long))
            'This is the placeholder for method implementation.
			        Dim rosomFieldValue As FieldValue = SelectFieldValueObject("rosom")
                    If (Not (rosomFieldValue) Is Nothing) Then
                        rosomFieldValue.Modified = false
                    End If
			        Dim BookrosomFieldValue As FieldValue = SelectFieldValueObject("Bookrosom")
                    If (Not (BookrosomFieldValue) Is Nothing) Then
                        BookrosomFieldValue.Modified = false
                    End If
			        Dim TransportationFieldValue As FieldValue = SelectFieldValueObject("Transportation")
                    If (Not (TransportationFieldValue) Is Nothing) Then
                        TransportationFieldValue.Modified = false
                    End If
					Dim rosomregisterFieldValue As FieldValue = SelectFieldValueObject("rosomregister")
                    If (Not (rosomregisterFieldValue) Is Nothing) Then
                        rosomregisterFieldValue.Modified = false
                    End If
					Dim transnoFieldValue As FieldValue = SelectFieldValueObject("transno")
                    If (Not (transnoFieldValue) Is Nothing) Then
                        transnoFieldValue.Modified = false
                    End If
					Dim CashFieldValue As FieldValue = SelectFieldValueObject("Cash")
                    If (Not (CashFieldValue) Is Nothing) Then
                        CashFieldValue.Modified = false
                    End If
					Dim keynetFieldValue As FieldValue = SelectFieldValueObject("keynet")
                    If (Not (keynetFieldValue) Is Nothing) Then
                        keynetFieldValue.Modified = false
                    End If
					Dim checkvalueFieldValue As FieldValue = SelectFieldValueObject("checkvalue")
                    If (Not (checkvalueFieldValue) Is Nothing) Then
                        checkvalueFieldValue.Modified = false
                    End If
					Dim checknumberFieldValue As FieldValue = SelectFieldValueObject("checknumber")
                    If (Not (checknumberFieldValue) Is Nothing) Then
                        checknumberFieldValue.Modified = false
                    End If
					
					
					
					
			       
			

        End Sub
    End Class
End Namespace
