
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Data.SqlClient
Imports System.Data

''' <summary>
''' Summary description for Ads
''' </summary>
Public Class Ads
	Private db As New dbLayer()
			'
			' TODO: Add constructor logic here
			'
	Public Sub New()
	End Sub


	Public Function insertAds(photoname As String, url As String, Tyype As String) As Boolean
		Dim x As Boolean
		Dim para As SqlParameter() = New SqlParameter(2) {}
		para(0) = New SqlParameter("@PhotoName", photoname)
		para(1) = New SqlParameter("@URL", url)
		para(2) = New SqlParameter("@Type", Tyype)
		x = db.Insert(para, "InsertAds")
		Return x
	End Function
	Public Function UpdateAds(id As Integer, photoname As String, url As String, Tyype As String) As Boolean
		Dim x As Boolean
		Dim para As SqlParameter() = New SqlParameter(3) {}
		para(0) = New SqlParameter("@PhotoName", photoname)
		para(1) = New SqlParameter("@URL", url)
		para(2) = New SqlParameter("@Type", Tyype)
		para(3) = New SqlParameter("@id", id)
		x = db.Update(para, "UpdateAds")
		Return x
	End Function
	Public Function SelectAds(id As Integer) As DataTable
		Dim dt As New DataTable()
		Dim para As SqlParameter() = New SqlParameter(0) {}
		para(0) = New SqlParameter("@id", id)
		dt = db.[Select](para, "SelectAds")
		Return dt

	End Function

	Public Function SelectAllAds() As DataTable
		Dim dt As New DataTable()

        dt = db.[Select]("SelectNews")
		Return dt

	End Function
	Public Function SelectEngineAds() As DataTable
		Dim dt As New DataTable()

		dt = db.[Select]("SelectEngineAds")
		Return dt

	End Function
End Class

'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik
'Facebook: facebook.com/telerik
'=======================================================
