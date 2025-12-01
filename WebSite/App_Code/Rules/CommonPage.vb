' (c) Copyright Microsoft Corporation.
' This source is subject to the Microsoft Public License.
' See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
' All other rights reserved.


Imports System.Collections
Imports System.Web.UI

''' <summary>
''' This Page class is common to all sample pages and exists as a place to
''' implement common functionality
''' </summary>
Public Class CommonPage
    Inherits Page
    Public Sub New()
    End Sub

    Public Function GetContentFillerText() As String
        Return "ASP.NET AJAX is a free framework for building a new generation of richer, more interactive, highly personalized cross-browser web applications.  " & "This new web development technology from Microsoft integrates cross-browser client script libraries with the ASP.NET 2.0 server-based development framework.  " & "In addition, ASP.NET AJAX offers you the same type of development platform for client-based web pages that ASP.NET offers for server-based pages.  " & "And because ASP.NET AJAX is an extension of ASP.NET, it is fully integrated with server-based services. ASP.NET AJAX makes it possible to easily take advantage of AJAX techniques on the web and enables you to create ASP.NET pages with a rich, responsive UI and server communication.  " & "However, AJAX isn't just for ASP.NET.  " & "You can take advantage of the rich client framework to easily build client-centric web applications that integrate with any backend data provider and run on most modern browsers.  "
    End Function
    Private Shared wordListText As String()
    Public Function GetWordListText() As String()
        ' This is the NATO phonetic alphabet (http://en.wikipedia.org/wiki/NATO_phonetic_alphabet)
        ' and was chosen for its size, non-specificity, and presence of multiple words with the same
        ' starting letter.
        If wordListText Is Nothing Then
            Dim tempWordListText As String() = New String() {"Alfa", "Alpha", "Bravo", "Charlie", "Delta", "Echo", _
             "Foxtrot", "Golf", "Hotel", "India", "Juliett", "Juliet", _
             "Kilo", "Lima", "Mike", "November", "Oscar", "Papa", _
             "Quebec", "Romeo", "Sierra", "Tango", "Uniform", "Victor", _
             "Whiskey", "X-ray", "Xray", "Yankee", "Zulu", "Zero", _
             "Nadazero", "One", "Unaone", "Two", "Bissotwo", "Three", _
             "Terrathree", "Four", "Kartefour", "Five", "Pantafive", "Six", _
             "Soxisix", "Seven", "Setteseven", "Eight", "Oktoeight", "Nine", _
             "Novenine"}
            Array.Sort(tempWordListText)
            wordListText = tempWordListText
        End If
        Return wordListText
    End Function
End Class

Public Interface IContentPlaceHolders
    Function GetContentPlaceHolders() As IList
End Interface