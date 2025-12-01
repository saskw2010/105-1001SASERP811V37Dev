Imports eZee.Data

Public Class usercontrol_SimpleControl
    Inherits System.Web.UI.UserControl
    'Create Delegate to Handle Click event in Default page
    Public Delegate Sub btnDelPost_Click(ByVal sender As Object, ByVal e As System.EventArgs)

#Region "Public Event"

    Public Event btnPostClk As btnDelPost_Click

#End Region

#Region "Public Properties"

    Public Property FirstName() As TextBox
        Get
            Return txtFirstName
        End Get
        Protected Set(ByVal value As TextBox)
            txtFirstName = value
        End Set
    End Property
    Public Property MarkupImageurl() As String
        Get
            Return MarkupImage.ImageUrl
        End Get
        Protected Set(ByVal value As String)
            MarkupImage.ImageUrl = value
        End Set
    End Property

    Public Property LastName() As TextBox
        Get
            Return txtLastName
        End Get
        Protected Set(ByVal value As TextBox)
            txtLastName = value
        End Set
    End Property

#End Region

    Protected Sub btnPost_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPost.Click
        RaiseEvent btnPostClk(sender, e)
    End Sub


End Class