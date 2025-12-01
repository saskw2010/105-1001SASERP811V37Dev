Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq

Namespace DashboardModels

    ''' <summary>
    ''' Base Dashboard Item Model
    ''' نموذج العنصر الأساسي للوحة التحكم
    ''' </summary>
    Public Class DashboardItemBase
        Public Property Id As Integer
        Public Property Title As String
        Public Property Description As String
        Public Property IconClass As String
        Public Property Value As String
        Public Property Url As String
        Public Property Color As String
        Public Property IsActive As Boolean = True
        Public Property CreatedDate As DateTime = DateTime.Now
        Public Property LastUpdated As DateTime = DateTime.Now
    End Class

    ''' <summary>
    ''' Financial Dashboard Model
    ''' نموذج لوحة التحكم المالية
    ''' </summary>
    Public Class FinancialDashboardModel
        Public Property TotalRevenue As Decimal
        Public Property TotalExpenses As Decimal
        Public Property NetProfit As Decimal
        Public Property CashFlow As Decimal
        Public Property CurrentBalance As Decimal
        Public Property PendingInvoices As Integer
        Public Property PaidInvoices As Integer
        Public Property OverdueInvoices As Integer
        Public Property Accounts As List(Of AccountSummary)
        Public Property RecentTransactions As List(Of TransactionSummary)
        Public Property MonthlyReports As List(Of MonthlyFinancialReport)

        Public Sub New()
            Accounts = New List(Of AccountSummary)
            RecentTransactions = New List(Of TransactionSummary)
            MonthlyReports = New List(Of MonthlyFinancialReport)
            LoadSampleData()
        End Sub

        Public Sub LoadSampleData()
            ' Sample financial data
            TotalRevenue = 150000D
            TotalExpenses = 95000D
            NetProfit = TotalRevenue - TotalExpenses
            CashFlow = 85000D ' التدفق النقدي الإيجابي
            CurrentBalance = 275000D
            PendingInvoices = 12
            PaidInvoices = 45
            OverdueInvoices = 3

            ' Sample accounts
            Accounts.Add(New AccountSummary With {
                .AccountName = "الصندوق الرئيسي",
                .AccountNumber = "1001",
                .Balance = 50000D,
                .AccountType = "نقدية"
            })
            Accounts.Add(New AccountSummary With {
                .AccountName = "البنك الأهلي",
                .AccountNumber = "1002", 
                .Balance = 125000D,
                .AccountType = "بنكي"
            })
            Accounts.Add(New AccountSummary With {
                .AccountName = "حسابات العملاء",
                .AccountNumber = "2001",
                .Balance = 85000D,
                .AccountType = "مدينون"
            })

            ' Sample transactions
            For i As Integer = 1 To 10
                RecentTransactions.Add(New TransactionSummary With {
                    .Id = i,
                    .TransactionDate = DateTime.Now.AddDays(-i),
                    .Description = "معاملة رقم " & i.ToString(),
                    .Amount = (i * 1000) + (i * 500),
                    .Type = If(i Mod 2 = 0, "دائن", "مدين")
                })
            Next
        End Sub
    End Class

    ''' <summary>
    ''' HR Dashboard Model  
    ''' نموذج لوحة تحكم الموارد البشرية
    ''' </summary>
    Public Class HRDashboardModel
        Public Property TotalEmployees As Integer
        Public Property ActiveEmployees As Integer
        Public Property PresentToday As Integer
        Public Property OnLeave As Integer
        Public Property NewHires As Integer
        Public Property PendingLeaves As Integer
        Public Property Departments As List(Of DepartmentSummary)
        Public Property EmployeeStats As List(Of EmployeeStatistic)
        Public Property RecentActivities As List(Of HRActivity)

        Public Sub New()
            Departments = New List(Of DepartmentSummary)
            EmployeeStats = New List(Of EmployeeStatistic)
            RecentActivities = New List(Of HRActivity)
            LoadSampleData()
        End Sub

        Public Sub LoadSampleData()
            ' Sample HR data
            TotalEmployees = 85
            ActiveEmployees = 82
            PresentToday = 75
            OnLeave = 7
            NewHires = 5
            PendingLeaves = 8

            ' Sample departments
            Departments.Add(New DepartmentSummary With {
                .Name = "إدارة الموارد البشرية",
                .EmployeeCount = 12,
                .Manager = "أحمد محمد",
                .Budget = 50000D
            })
            Departments.Add(New DepartmentSummary With {
                .Name = "قسم المالية",
                .EmployeeCount = 15,
                .Manager = "فاطمة علي",
                .Budget = 75000D
            })
            Departments.Add(New DepartmentSummary With {
                .Name = "قسم التطوير",
                .EmployeeCount = 25,
                .Manager = "محمود حسن",
                .Budget = 120000D
            })

            ' Sample activities
            For i As Integer = 1 To 8
                RecentActivities.Add(New HRActivity With {
                    .Id = i,
                    .ActivityDate = DateTime.Now.AddDays(-i),
                    .Description = "نشاط الموارد البشرية رقم " & i.ToString(),
                    .Type = If(i Mod 3 = 0, "توظيف", If(i Mod 2 = 0, "إجازة", "تدريب")),
                    .Employee = "موظف " & i.ToString()
                })
            Next
        End Sub
    End Class

    ''' <summary>
    ''' Operations Dashboard Model
    ''' نموذج لوحة تحكم العمليات
    ''' </summary>
    Public Class OperationsDashboardModel
        Public Property TotalOrders As Integer
        Public Property CompletedOrders As Integer
        Public Property PendingOrders As Integer
        Public Property ProcessedToday As Integer
        Public Property TotalInventory As Integer
        Public Property LowStockItems As Integer
        Public Property Suppliers As List(Of SupplierSummary)
        Public Property ProductCategories As List(Of CategorySummary)
        Public Property RecentOperations As List(Of OperationActivity)

        Public Sub New()
            Suppliers = New List(Of SupplierSummary)
            ProductCategories = New List(Of CategorySummary)
            RecentOperations = New List(Of OperationActivity)
            LoadSampleData()
        End Sub

        Public Sub LoadSampleData()
            ' Sample operations data
            TotalOrders = 156
            CompletedOrders = 142
            PendingOrders = 14
            ProcessedToday = 28
            TotalInventory = 2450
            LowStockItems = 12

            ' Sample suppliers
            Suppliers.Add(New SupplierSummary With {
                .Name = "شركة الأولى للتوريدات",
                .ContactPerson = "خالد أحمد",
                .TotalOrders = 25,
                .TotalValue = 125000D
            })
            Suppliers.Add(New SupplierSummary With {
                .Name = "مؤسسة التقنية المتقدمة",
                .ContactPerson = "سارة محمد",
                .TotalOrders = 18,
                .TotalValue = 89000D
            })

            ' Sample categories
            ProductCategories.Add(New CategorySummary With {
                .Name = "أجهزة كمبيوتر",
                .ItemCount = 45,
                .TotalValue = 125000D
            })
            ProductCategories.Add(New CategorySummary With {
                .Name = "مستلزمات مكتبية",
                .ItemCount = 128,
                .TotalValue = 25000D
            })
        End Sub
    End Class

    ''' <summary>
    ''' Reports Dashboard Model
    ''' نموذج لوحة تحكم التقارير
    ''' </summary>
    Public Class ReportsDashboardModel
        Public Property TotalReports As Integer
        Public Property GeneratedToday As Integer
        Public Property ScheduledReports As Integer
        Public Property ActiveReports As Integer
        Public Property AvailableReports As List(Of ReportSummary)
        Public Property PopularReports As List(Of ReportSummary)
        Public Property RecentActivities As List(Of ReportActivity)

        Public Sub New()
            AvailableReports = New List(Of ReportSummary)
            PopularReports = New List(Of ReportSummary)
            RecentActivities = New List(Of ReportActivity)
            LoadSampleData()
        End Sub

        Public Sub LoadSampleData()
            ' Sample reports data
            TotalReports = 45
            GeneratedToday = 5
            ScheduledReports = 3
            ActiveReports = 12

            ' Sample available reports
            AvailableReports.Add(New ReportSummary With {
                .Name = "التقرير المالي الشهري",
                .Description = "تقرير شامل للوضع المالي الشهري",
                .Category = "مالي",
                .LastGenerated = DateTime.Now.AddDays(-2)
            })
            AvailableReports.Add(New ReportSummary With {
                .Name = "تقرير حضور الموظفين",
                .Description = "تقرير حضور وغياب الموظفين",
                .Category = "موارد بشرية",
                .LastGenerated = DateTime.Now.AddDays(-1)
            })
            AvailableReports.Add(New ReportSummary With {
                .Name = "تقرير المخزون",
                .Description = "تقرير حالة المخزون والمواد",
                .Category = "عمليات",
                .LastGenerated = DateTime.Now.AddHours(-6)
            })
        End Sub
    End Class

    ' Supporting Models / النماذج المساعدة

    Public Class AccountSummary
        Public Property AccountName As String
        Public Property AccountNumber As String
        Public Property Balance As Decimal
        Public Property AccountType As String
    End Class

    Public Class TransactionSummary
        Public Property Id As Integer
        Public Property TransactionDate As DateTime
        Public Property Description As String
        Public Property Amount As Decimal
        Public Property Type As String
    End Class

    Public Class MonthlyFinancialReport
        Public Property Month As String
        Public Property Revenue As Decimal
        Public Property Expenses As Decimal
        Public Property Profit As Decimal
    End Class

    Public Class DepartmentSummary
        Public Property Name As String
        Public Property EmployeeCount As Integer
        Public Property Manager As String
        Public Property Budget As Decimal
    End Class

    Public Class EmployeeStatistic
        Public Property Category As String
        Public Property Count As Integer
        Public Property Percentage As Double
    End Class

    Public Class HRActivity
        Public Property Id As Integer
        Public Property ActivityDate As DateTime
        Public Property Description As String
        Public Property Type As String
        Public Property Employee As String
    End Class

    Public Class SupplierSummary
        Public Property Name As String
        Public Property ContactPerson As String
        Public Property TotalOrders As Integer
        Public Property TotalValue As Decimal
    End Class

    Public Class CategorySummary
        Public Property Name As String
        Public Property ItemCount As Integer
        Public Property TotalValue As Decimal
    End Class

    Public Class OperationActivity
        Public Property Id As Integer
        Public Property ActivityDate As DateTime
        Public Property Description As String
        Public Property Type As String
        Public Property Status As String
    End Class

    Public Class ReportSummary
        Public Property Name As String
        Public Property Description As String
        Public Property Category As String
        Public Property LastGenerated As DateTime
    End Class

    Public Class ReportActivity
        Public Property Id As Integer
        Public Property ActivityDate As DateTime
        Public Property ReportName As String
        Public Property User As String
        Public Property Action As String
    End Class

End Namespace
