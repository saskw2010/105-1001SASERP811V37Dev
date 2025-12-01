Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DashboardModels

Partial Public Class Controls_OperationsDashboard
    Inherits Global.System.Web.UI.UserControl

    Private _operationsModel As OperationsDashboardModel

    Public Property OperationsModel As OperationsDashboardModel
        Get
            If _operationsModel Is Nothing Then
                _operationsModel = New OperationsDashboardModel()
            End If
            Return _operationsModel
        End Get
        Set(value As OperationsDashboardModel)
            _operationsModel = value
        End Set
    End Property

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadOperationsData()
            BindData()
        End If
    End Sub

    Private Sub LoadOperationsData()
        Try
            OperationsModel = New OperationsDashboardModel()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error loading operations data: " & ex.Message)
        End Try
    End Sub

    Private Sub BindData()
        Try
            BindOperationsMetrics()
            BindSuppliersData()
            BindCategoriesData()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error binding operations data: " & ex.Message)
        End Try
    End Sub

    Private Sub BindOperationsMetrics()
        If lblTotalOrders IsNot Nothing Then
            lblTotalOrders.Text = OperationsModel.TotalOrders.ToString()
        End If
        
        If lblCompletedOrders IsNot Nothing Then
            lblCompletedOrders.Text = OperationsModel.CompletedOrders.ToString()
        End If
        
        If lblProcessedToday IsNot Nothing Then
            lblProcessedToday.Text = OperationsModel.ProcessedToday.ToString()
        End If
        
        If lblTotalInventory IsNot Nothing Then
            lblTotalInventory.Text = OperationsModel.TotalInventory.ToString()
        End If
        
        If lblPendingOrders IsNot Nothing Then
            lblPendingOrders.Text = OperationsModel.PendingOrders.ToString()
        End If
        
        If lblLowStockItems IsNot Nothing Then
            lblLowStockItems.Text = OperationsModel.LowStockItems.ToString()
        End If
    End Sub

    Private Sub BindSuppliersData()
        If rptSuppliers IsNot Nothing AndAlso OperationsModel.Suppliers IsNot Nothing Then
            rptSuppliers.DataSource = OperationsModel.Suppliers
            rptSuppliers.DataBind()
        End If
    End Sub

    Private Sub BindCategoriesData()
        If rptCategories IsNot Nothing AndAlso OperationsModel.ProductCategories IsNot Nothing Then
            rptCategories.DataSource = OperationsModel.ProductCategories
            rptCategories.DataBind()
        End If
    End Sub

    <System.Web.Services.WebMethod()>
    Public Shared Function HandleOperationsAction(action As String, data As String) As String
        Try
            Select Case action.ToLower()
                Case "createorder"
                    Return "تم إنشاء طلب جديد بنجاح"
                Case "manageinventory"
                    Return "تم فتح إدارة المخزون"
                Case "managesuppliers"
                    Return "تم فتح إدارة الموردين"
                Case "viewreports"
                    Return "تم فتح تقارير العمليات"
                Case Else
                    Return "إجراء غير معروف"
            End Select
        Catch ex As Exception
            Return "خطأ: " & ex.Message
        End Try
    End Function

    Public Sub RefreshDashboard()
        LoadOperationsData()
        BindData()
    End Sub

End Class
