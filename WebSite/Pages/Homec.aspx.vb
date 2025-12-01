Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Text
Imports eZee.Data

Partial Public Class Pages_Home
    Inherits Global.eZee.Web.PageBase
    
    Public ReadOnly Property CssClass() As String
        Get
            Return "HomePage Wide"
        End Get
    End Property

    Protected Overloads Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If IsPostBack Then
        Else
            ' 🏢 Enterprise Multi-Tab Dashboard V4.1.0
            InitializeEnterpriseDashboard()
            
            ' Original order check functionality preserved
            Dim sqlstatmentcheck As String = "select count(*) as tecko from orders"
            Dim tekost As Object
            tekost = DataLogic.GetValue(sqlstatmentcheck)
            If tekost > 0 Then
                Dim message As String = "console.log('✅ Order data detected: " & tekost.ToString() & " records found');"
                ScriptManager.RegisterClientScriptBlock(TryCast(sender, Control), Me.GetType(), "orderCheck", message, True)
            End If
        End If
    End Sub
    
    ''' <summary>
    ''' Initialize Enterprise Dashboard with Role-Based Tabs
    ''' </summary>
    Private Sub InitializeEnterpriseDashboard()
        Try
            ' Get current user roles
            Dim userRoles As List(Of String) = GetCurrentUserRoles()
            
            ' Generate tabs based on roles
            GenerateRoleBasedTabs(userRoles)
            
            ' Log dashboard initialization
            Dim initScript As String = String.Format(
                "console.log('🏢 Enterprise Dashboard initialized for user: {0} with roles: {1}');",
                HttpContext.Current.User.Identity.Name,
                String.Join(", ", userRoles)
            )
            ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "dashboardInit", initScript, True)
            
        Catch ex As Exception
            ' Log error and continue with basic dashboard
            Dim errorScript As String = String.Format(
                "console.error('❌ Dashboard initialization error: {0}');",
                ex.Message.Replace("'", "\'")
            )
            ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "dashboardError", errorScript, True)
        End Try
    End Sub
    
    ''' <summary>
    ''' Get current user roles from security system
    ''' </summary>
    Private Function GetCurrentUserRoles() As List(Of String)
        Dim roles As New List(Of String)
        
        Try
            ' Check standard ASP.NET roles
            If HttpContext.Current.User.IsInRole("Admin") Then roles.Add("Admin")
            If HttpContext.Current.User.IsInRole("Manager") Then roles.Add("Manager")
            If HttpContext.Current.User.IsInRole("Accounting") Then roles.Add("Accounting")
            If HttpContext.Current.User.IsInRole("Operations") Then roles.Add("Operations")
            If HttpContext.Current.User.IsInRole("HR") Then roles.Add("HR")
            If HttpContext.Current.User.IsInRole("Employee") Then roles.Add("Employee")
            
            ' If no roles found, assign default Employee role
            If roles.Count = 0 Then
                roles.Add("Employee")
            End If
            
        Catch ex As Exception
            ' Fallback to Employee role
            roles.Clear()
            roles.Add("Employee")
        End Try
        
        Return roles
    End Function
    
    ''' <summary>
    ''' Generate tabs based on user roles
    ''' </summary>
    Private Sub GenerateRoleBasedTabs(userRoles As List(Of String))
        Dim tabsHtml As New StringBuilder()
        Dim contentHtml As New StringBuilder()
        
        ' Financial Tab - For Admin, Manager, Accounting
        If userRoles.Contains("Admin") OrElse userRoles.Contains("Manager") OrElse userRoles.Contains("Accounting") Then
            tabsHtml.AppendLine(GenerateTabNavigation("financial", "💰 المالية", "fas fa-chart-line"))
            contentHtml.AppendLine(GenerateTabContent("financial", "Financial Dashboard", "المالية"))
        End If
        
        ' Operations Tab - For Admin, Manager, Operations
        If userRoles.Contains("Admin") OrElse userRoles.Contains("Manager") OrElse userRoles.Contains("Operations") Then
            tabsHtml.AppendLine(GenerateTabNavigation("operations", "⚙️ العمليات", "fas fa-cogs"))
            contentHtml.AppendLine(GenerateTabContent("operations", "Operations Dashboard", "العمليات"))
        End If
        
        ' HR Tab - For Admin, Manager, HR
        If userRoles.Contains("Admin") OrElse userRoles.Contains("Manager") OrElse userRoles.Contains("HR") Then
            tabsHtml.AppendLine(GenerateTabNavigation("hr", "👥 الموارد البشرية", "fas fa-users"))
            contentHtml.AppendLine(GenerateTabContent("hr", "HR Dashboard", "الموارد البشرية"))
        End If
        
        ' Analytics Tab - For Admin, Manager only
        If userRoles.Contains("Admin") OrElse userRoles.Contains("Manager") Then
            tabsHtml.AppendLine(GenerateTabNavigation("analytics", "📊 التحليلات", "fas fa-chart-bar"))
            contentHtml.AppendLine(GenerateTabContent("analytics", "Analytics Dashboard", "التحليلات"))
        End If
        
        ' Add tabs to placeholders
        AdditionalTabsPlaceHolder.Controls.Add(New LiteralControl(tabsHtml.ToString()))
        AdditionalTabContentPlaceHolder.Controls.Add(New LiteralControl(contentHtml.ToString()))
        
        ' Add JavaScript to initialize new tabs
        Dim tabInitScript As String = String.Format(
            "setTimeout(function() {{ console.log('🗂️ Generated {0} additional tabs based on user roles'); }}, 1000);",
            CountGeneratedTabs(userRoles)
        )
        ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "tabInit", tabInitScript, True)
    End Sub
    
    ''' <summary>
    ''' Generate HTML for tab navigation
    ''' </summary>
    Private Function GenerateTabNavigation(tabId As String, tabTitle As String, iconClass As String) As String
        Return String.Format(
            "<li class=""nav-item"">" &
            "<a class=""nav-link"" id=""{0}-tab"" data-toggle=""tab"" href=""#{0}-dashboard"" role=""tab"" aria-controls=""{0}-dashboard"" aria-selected=""false"" onclick=""window.dashboardPerformance.trackTabSwitch('{0}'); loadTabContent('{0}-dashboard', '/Controls/Dashboard/{0}Dashboard.aspx');"">" &
            "<i class=""{1}""></i>" &
            "<span>{2}</span>" &
            "</a>" &
            "</li>",
            tabId, iconClass, tabTitle
        )
    End Function
    
    ''' <summary>
    ''' Generate HTML for tab content
    ''' </summary>
    Private Function GenerateTabContent(tabId As String, tabTitle As String, arabicTitle As String) As String
        Return String.Format(
            "<div class=""tab-pane fade"" id=""{0}-dashboard"" role=""tabpanel"" aria-labelledby=""{0}-tab"">" &
            "<div class=""tab-loading-placeholder"">" &
            "<div style=""text-align: center; padding: 4rem; background: linear-gradient(135deg, #f8fafc, #e2e8f0); border-radius: 15px; margin: 2rem;"">" &
            "<div style=""width: 80px; height: 80px; background: linear-gradient(135deg, #3b82f6, #1d4ed8); border-radius: 20px; display: flex; align-items: center; justify-content: center; margin: 0 auto 2rem; color: white; font-size: 2rem;"">" &
            "<i class=""fas fa-rocket""></i>" &
            "</div>" &
            "<h3 style=""color: #1e293b; margin-bottom: 1rem;"">{1} - {2}</h3>" &
            "<p style=""color: #64748b; margin-bottom: 2rem;"">سيتم تحميل محتوى هذا القسم تلقائياً عند النقر على التاب</p>" &
            "<button type=""button"" class=""btn btn-primary"" onclick=""loadTabContent('{0}-dashboard', '/Controls/Dashboard/{0}Dashboard.aspx')"">" &
            "<i class=""fas fa-sync-alt""></i> تحميل المحتوى الآن" &
            "</button>" &
            "</div>" &
            "</div>" &
            "</div>",
            tabId, tabTitle, arabicTitle
        )
    End Function
    
    ''' <summary>
    ''' Count how many tabs were generated
    ''' </summary>
    Private Function CountGeneratedTabs(userRoles As List(Of String)) As Integer
        Dim count As Integer = 0
        
        If userRoles.Contains("Admin") OrElse userRoles.Contains("Manager") OrElse userRoles.Contains("Accounting") Then count += 1
        If userRoles.Contains("Admin") OrElse userRoles.Contains("Manager") OrElse userRoles.Contains("Operations") Then count += 1
        If userRoles.Contains("Admin") OrElse userRoles.Contains("Manager") OrElse userRoles.Contains("HR") Then count += 1
        If userRoles.Contains("Admin") OrElse userRoles.Contains("Manager") Then count += 1
        
        Return count
    End Function
    
    ''' <summary>
    ''' Get dashboard statistics for display
    ''' </summary>
    Private Function GetDashboardStats() As Dictionary(Of String, Object)
        Dim stats As New Dictionary(Of String, Object)
        
        Try
            ' Example queries - replace with your actual database queries
            stats("TotalUsers") = DataLogic.GetValue("SELECT COUNT(*) FROM Users") ' Example
            stats("TotalOrders") = DataLogic.GetValue("SELECT COUNT(*) FROM Orders") ' Example  
            stats("PendingTasks") = DataLogic.GetValue("SELECT COUNT(*) FROM Tasks WHERE Status = 'Pending'") ' Example
            
        Catch ex As Exception
            ' Fallback values
            stats("TotalUsers") = 0
            stats("TotalOrders") = 0
            stats("PendingTasks") = 0
        End Try
        
        Return stats
    End Function

End Class
