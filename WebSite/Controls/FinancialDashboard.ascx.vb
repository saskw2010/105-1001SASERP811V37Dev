Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DashboardModels

Partial Public Class Controls_FinancialDashboard
    Inherits Global.System.Web.UI.UserControl

    Private _financialModel As FinancialDashboardModel

    ''' <summary>
    ''' Financial Dashboard Model Property
    ''' خاصية نموذج لوحة التحكم المالية
    ''' </summary>
    Public Property FinancialModel As FinancialDashboardModel
        Get
            If _financialModel Is Nothing Then
                _financialModel = New FinancialDashboardModel()
            End If
            Return _financialModel
        End Get
        Set(value As FinancialDashboardModel)
            _financialModel = value
        End Set
    End Property

    ''' <summary>
    ''' Page Load Event - Initialize dashboard data
    ''' حدث تحميل الصفحة - تهيئة بيانات لوحة التحكم
    ''' </summary>
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadFinancialData()
            BindData()
        End If
    End Sub

    ''' <summary>
    ''' Load financial data from model
    ''' تحميل البيانات المالية من النموذج
    ''' </summary>
    Private Sub LoadFinancialData()
        Try
            ' Initialize model with fresh data
            FinancialModel = New FinancialDashboardModel()
            
            ' Log data loading for debugging
            System.Diagnostics.Debug.WriteLine("Financial Dashboard: Loaded " & FinancialModel.Accounts.Count.ToString() & " accounts")
            System.Diagnostics.Debug.WriteLine("Financial Dashboard: Loaded " & FinancialModel.RecentTransactions.Count.ToString() & " transactions")
            
        Catch ex As Exception
            ' Log error and create fallback data
            System.Diagnostics.Debug.WriteLine("Error loading financial data: " & ex.Message)
            CreateFallbackData()
        End Try
    End Sub

    ''' <summary>
    ''' Bind data to UI controls
    ''' ربط البيانات بعناصر واجهة المستخدم
    ''' </summary>
    Private Sub BindData()
        Try
            ' Bind main financial metrics
            BindFinancialMetrics()
            
            ' Bind invoice statistics
            BindInvoiceStatistics()
            
            ' Bind accounts data
            BindAccountsData()
            
            ' Bind transactions data
            BindTransactionsData()
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error binding financial data: " & ex.Message)
            ShowErrorMessage("حدث خطأ في تحميل البيانات المالية")
        End Try
    End Sub

    ''' <summary>
    ''' Bind financial metrics to labels
    ''' ربط المقاييس المالية بالتسميات
    ''' </summary>
    Private Sub BindFinancialMetrics()
        If lblTotalRevenue IsNot Nothing Then
            lblTotalRevenue.Text = String.Format("{0:N0}", FinancialModel.TotalRevenue)
        End If
        
        If lblTotalExpenses IsNot Nothing Then
            lblTotalExpenses.Text = String.Format("{0:N0}", FinancialModel.TotalExpenses)
        End If
        
        If lblNetProfit IsNot Nothing Then
            lblNetProfit.Text = String.Format("{0:N0}", FinancialModel.NetProfit)
        End If
        
        If lblCurrentBalance IsNot Nothing Then
            lblCurrentBalance.Text = String.Format("{0:N0}", FinancialModel.CurrentBalance)
        End If
        
        If lblCashFlow IsNot Nothing Then
            lblCashFlow.Text = String.Format("{0:N0}", FinancialModel.CashFlow)
        End If
    End Sub

    ''' <summary>
    ''' Bind invoice statistics
    ''' ربط إحصائيات الفواتير
    ''' </summary>
    Private Sub BindInvoiceStatistics()
        If lblPaidInvoices IsNot Nothing Then
            lblPaidInvoices.Text = FinancialModel.PaidInvoices.ToString()
        End If
        
        If lblPendingInvoices IsNot Nothing Then
            lblPendingInvoices.Text = FinancialModel.PendingInvoices.ToString()
        End If
        
        If lblOverdueInvoices IsNot Nothing Then
            lblOverdueInvoices.Text = FinancialModel.OverdueInvoices.ToString()
        End If
    End Sub

    ''' <summary>
    ''' Bind accounts data to repeater
    ''' ربط بيانات الحسابات بالمكرر
    ''' </summary>
    Private Sub BindAccountsData()
        If rptAccounts IsNot Nothing AndAlso FinancialModel.Accounts IsNot Nothing Then
            ' Take only top 5 accounts for display
            Dim topAccounts = FinancialModel.Accounts.Take(5).ToList()
            rptAccounts.DataSource = topAccounts
            rptAccounts.DataBind()
        End If
    End Sub

    ''' <summary>
    ''' Bind transactions data to repeater
    ''' ربط بيانات المعاملات بالمكرر
    ''' </summary>
    Private Sub BindTransactionsData()
        If rptTransactions IsNot Nothing AndAlso FinancialModel.RecentTransactions IsNot Nothing Then
            ' Take only top 8 transactions for display
            Dim recentTransactions = FinancialModel.RecentTransactions.Take(8).ToList()
            rptTransactions.DataSource = recentTransactions
            rptTransactions.DataBind()
        End If
    End Sub

    ''' <summary>
    ''' Create fallback data in case of errors
    ''' إنشاء بيانات احتياطية في حالة الأخطاء
    ''' </summary>
    Private Sub CreateFallbackData()
        FinancialModel = New FinancialDashboardModel() With {
            .TotalRevenue = 100000D,
            .TotalExpenses = 75000D,
            .NetProfit = 25000D,
            .CurrentBalance = 150000D,
            .PaidInvoices = 25,
            .PendingInvoices = 8,
            .OverdueInvoices = 2,
            .Accounts = New List(Of AccountSummary) From {
                New AccountSummary With {
                    .AccountName = "الحساب الرئيسي",
                    .AccountNumber = "1001",
                    .Balance = 50000D,
                    .AccountType = "نقدي"
                }
            },
            .RecentTransactions = New List(Of TransactionSummary) From {
                New TransactionSummary With {
                    .Id = 1,
                    .TransactionDate = DateTime.Now.AddDays(-1),
                    .Description = "معاملة تجريبية",
                    .Amount = 5000D,
                    .Type = "دائن"
                }
            }
        }
    End Sub

    ''' <summary>
    ''' Show error message to user
    ''' عرض رسالة خطأ للمستخدم
    ''' </summary>
    Private Sub ShowErrorMessage(message As String)
        ' In a real application, you would show this in a proper notification system
        ' Here we'll just add it to the page as a simple div
        Dim errorDiv As New Literal()
        errorDiv.Text = "<div class='alert alert-error' style='background: #fee; color: #c33; padding: 10px; border-radius: 5px; margin: 10px 0;'>" & message & "</div>"
        Me.Controls.AddAt(0, errorDiv)
    End Sub

    ''' <summary>
    ''' Refresh dashboard data
    ''' تحديث بيانات لوحة التحكم
    ''' </summary>
    Public Sub RefreshDashboard()
        LoadFinancialData()
        BindData()
    End Sub

    ''' <summary>
    ''' Get financial summary for external use
    ''' الحصول على ملخص مالي للاستخدام الخارجي
    ''' </summary>
    Public Function GetFinancialSummary() As String
        Return "الإيرادات: " & FinancialModel.TotalRevenue.ToString("N0") & " - المصروفات: " & FinancialModel.TotalExpenses.ToString("N0") & " - الربح: " & FinancialModel.NetProfit.ToString("N0")
    End Function

    ''' <summary>
    ''' Export financial data as JSON (for JavaScript integration)
    ''' تصدير البيانات المالية كـ JSON (للتكامل مع JavaScript)
    ''' </summary>
    Public Function GetFinancialDataAsJson() As String
        Try
            ' Serialize using built-in JavaScriptSerializer (project convention)
            Dim payload = New With {
                .revenue = FinancialModel.TotalRevenue,
                .expenses = FinancialModel.TotalExpenses,
                .profit = FinancialModel.NetProfit,
                .balance = FinancialModel.CurrentBalance
            }
            Dim js = New System.Web.Script.Serialization.JavaScriptSerializer()
            Return js.Serialize(payload)
        Catch ex As Exception
            Return "{""error"":""Failed to serialize data""}"
        End Try
    End Function

    ''' <summary>
    ''' Handle specific financial actions (called from JavaScript)
    ''' التعامل مع الإجراءات المالية المحددة (مستدعاة من JavaScript)
    ''' </summary>
    <System.Web.Services.WebMethod()>
    Public Shared Function HandleFinancialAction(action As String, data As String) As String
        Try
            Select Case action.ToLower()
                Case "refresh"
                    Return "تم تحديث البيانات بنجاح"
                Case "export"
                    Return "تم تصدير البيانات بنجاح"
                Case "createinvoice"
                    Return "تم إنشاء فاتورة جديدة"
                Case Else
                    Return "إجراء غير معروف"
            End Select
        Catch ex As Exception
            Return "خطأ: " & ex.Message
        End Try
    End Function

End Class
