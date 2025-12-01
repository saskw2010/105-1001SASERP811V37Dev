Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports eZee.Data
Imports eZee.Web

Partial Public Class Pages_IdentityMembershipManager
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            InitializePage()
        End If
    End Sub

    Private Sub InitializePage()
        Try
            ' Set page title
            Page.Title = "Identity Membership Manager"
            
            ' Configure Users DataView
            ConfigureUsersDataView()
            
            ' Configure Roles DataView
            ConfigureRolesDataView()
            
            ' Configure UserRoles DataView
            ConfigureUserRolesDataView()
            
        Catch ex As Exception
            ' Log error and show user-friendly message
            System.Diagnostics.Debug.WriteLine("Error initializing Identity Membership Manager: " & ex.Message)
            ShowErrorMessage("Error initializing page: " & ex.Message)
        End Try
    End Sub

    Private Sub ConfigureUsersDataView()
        Try
            ' DataViewExtenders are configured in markup, no code configuration needed
            System.Diagnostics.Debug.WriteLine("Users DataViewExtender configured in markup")
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error configuring Users DataView: " & ex.Message)
        End Try
    End Sub

    Private Sub ConfigureRolesDataView()
        Try
            ' DataViewExtenders are configured in markup, no code configuration needed
            System.Diagnostics.Debug.WriteLine("Roles DataViewExtender configured in markup")
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error configuring Roles DataView: " & ex.Message)
        End Try
    End Sub

    Private Sub ConfigureUserRolesDataView()
        Try
            ' DataViewExtenders are configured in markup, no code configuration needed
            System.Diagnostics.Debug.WriteLine("UserRoles DataViewExtender configured in markup")
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error configuring UserRoles DataView: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowErrorMessage(message As String)
        ' Create a simple error display
        Dim errorLabel As New Label()
        errorLabel.Text = message
        errorLabel.CssClass = "alert alert-danger"
        errorLabel.Visible = True
        
        ' Add to the page (you might want to add this to a specific panel)
        Page.Form.Controls.Add(errorLabel)
    End Sub

    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreRender
        ' Add any final configurations before rendering
        Try
            ' Ensure proper styling is applied
            AddClientScriptForStyling()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in Page_PreRender: " & ex.Message)
        End Try
    End Sub

    Private Sub AddClientScriptForStyling()
        ' Add client-side script for enhanced functionality
        Dim script As String = "<script>$(document).ready(function() { $('.DataView').each(function() { $(this).prepend('<div class=""loading-indicator"" style=""display:none;""><i class=""fas fa-spinner fa-spin""></i> Loading...</div>'); }); $('button[data-bs-toggle=""tab""]').on('show.bs.tab', function (e) { var target = $(e.target).attr('data-bs-target'); $(target).find('.loading-indicator').show(); }); $('button[data-bs-toggle=""tab""]').on('shown.bs.tab', function (e) { var target = $(e.target).attr('data-bs-target'); setTimeout(function() { $(target).find('.loading-indicator').hide(); }, 1000); }); });</script>"
        
        Page.ClientScript.RegisterStartupScript(Me.GetType(), "MembershipManagerScript", script, False)
    End Sub
End Class
