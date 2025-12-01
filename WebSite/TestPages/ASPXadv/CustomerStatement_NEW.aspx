<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerStatement.aspx.cs" Inherits="CustomerStatement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>كشف حساب العميل</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <!-- Bootstrap 5.3.2 RTL -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.rtl.min.css" rel="stylesheet" />
    <!-- Font Awesome 6.0 -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css" />
    <!-- Cairo Font -->
    <link href="https://fonts.googleapis.com/css2?family=Cairo:wght@200;300;400;500;600;700;800&display=swap" rel="stylesheet" />
    
    <style>
        * {
            font-family: 'Cairo', sans-serif;
        }
        
        body {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
            padding: 20px 0;
        }
        
        .main-container {
            background: white;
            border-radius: 15px;
            box-shadow: 0 15px 35px rgba(0,0,0,0.1);
            overflow: hidden;
        }
        
        .page-header {
            background: linear-gradient(135deg, #2c3e50, #3498db);
            color: white;
            padding: 30px;
            margin: -20px -20px 30px -20px;
            text-align: center;
            position: relative;
        }
        
        .page-header::before {
            content: '';
            position: absolute;
            bottom: 0;
            left: 0;
            right: 0;
            height: 20px;
            background: white;
            border-radius: 20px 20px 0 0;
        }
        
        .page-title {
            font-size: 2.2rem;
            font-weight: 700;
            margin: 0 0 15px 0;
            text-shadow: 0 2px 4px rgba(0,0,0,0.3);
        }
        
        .page-subtitle {
            font-size: 1.1rem;
            opacity: 0.9;
            margin: 0;
        }
        
        .customer-info {
            background: rgba(255,255,255,0.1);
            padding: 15px;
            border-radius: 10px;
            margin-top: 20px;
        }
        
        .customer-info h2 {
            margin: 0;
            font-size: 1.5rem;
            color: #ecf0f1;
        }
        
        .controls-section {
            background: #f8f9fa;
            padding: 25px;
            border-bottom: 1px solid #e9ecef;
        }
        
        .control-group {
            margin-bottom: 1rem;
        }
        
        .options-panel {
            background: linear-gradient(135deg, #ecf0f1, #d5dbdb);
            padding: 20px;
            border-radius: 10px;
            margin: 20px 0;
            display: flex;
            gap: 30px;
            justify-content: center;
            flex-wrap: wrap;
        }
        
        .form-check {
            display: flex;
            align-items: center;
            gap: 10px;
            padding: 10px 15px;
            background: white;
            border-radius: 8px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
            transition: all 0.3s ease;
        }
        
        .form-check:hover {
            transform: translateY(-2px);
            box-shadow: 0 4px 10px rgba(0,0,0,0.15);
        }
        
        .form-check-input {
            width: 18px;
            height: 18px;
            cursor: pointer;
        }
        
        .form-check-label {
            cursor: pointer;
            font-weight: 500;
            color: #2c3e50;
            display: flex;
            align-items: center;
            gap: 8px;
            margin: 0;
        }
        
        .form-check-label i {
            color: #3498db;
        }
        
        .btn-search {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            border: none;
            color: white;
            font-weight: 600;
            padding: 12px 25px;
            border-radius: 8px;
            transition: all 0.3s ease;
        }
        
        .btn-search:hover {
            transform: translateY(-2px);
            box-shadow: 0 5px 15px rgba(102, 126, 234, 0.4);
            color: white;
        }
        
        .btn-export {
            background: linear-gradient(135deg, #27ae60, #2ecc71);
            border: none;
            color: white;
            font-weight: 600;
            padding: 10px 20px;
            margin: 0 5px;
            border-radius: 6px;
            transition: all 0.3s ease;
        }
        
        .btn-export:hover {
            transform: translateY(-1px);
            box-shadow: 0 3px 10px rgba(39, 174, 96, 0.3);
            color: white;
        }
        
        .btn-print {
            background: linear-gradient(135deg, #e74c3c, #c0392b);
        }
        
        .btn-print:hover {
            box-shadow: 0 3px 10px rgba(231, 76, 60, 0.3);
        }
        
        .balance-cards {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 20px;
            margin-bottom: 30px;
        }
        
        .balance-card {
            background: linear-gradient(135deg, #ffffff, #f8f9fa);
            border-radius: 15px;
            padding: 25px;
            text-align: center;
            box-shadow: 0 5px 15px rgba(0,0,0,0.1);
            transition: transform 0.3s ease;
        }
        
        .balance-card:hover {
            transform: translateY(-5px);
        }
        
        .balance-card.opening {
            border-top: 4px solid #3498db;
        }
        
        .balance-card.period {
            border-top: 4px solid #f39c12;
        }
        
        .balance-card.closing {
            border-top: 4px solid #27ae60;
        }
        
        .balance-card.stats {
            border-top: 4px solid #9b59b6;
        }
        
        .balance-title {
            font-size: 1.1rem;
            font-weight: 600;
            color: #34495e;
            margin-bottom: 10px;
        }
        
        .balance-amount {
            font-size: 2rem;
            font-weight: 700;
            margin: 10px 0;
        }
        
        .balance-amount.positive {
            color: #28a745;
        }
        
        .balance-amount.negative {
            color: #dc3545;
        }
        
        .balance-amount.zero {
            color: #6c757d;
        }
        
        .statement-table {
            background: white;
            border-radius: 15px;
            overflow: hidden;
            box-shadow: 0 5px 15px rgba(0, 0, 0, 0.1);
            margin-bottom: 25px;
        }
        
        .table {
            margin-bottom: 0;
            font-size: 0.95rem;
        }
        
        .table thead th {
            background: linear-gradient(135deg, #34495e, #2c3e50);
            color: white;
            font-weight: 600;
            padding: 15px 10px;
            border: none;
            text-align: center;
            position: sticky;
            top: 0;
            z-index: 10;
        }
        
        .table tbody tr {
            transition: all 0.3s ease;
            background: linear-gradient(135deg, #ffffff, #fafbfc);
        }
        
        .table tbody tr:nth-child(even) {
            background: linear-gradient(135deg, #f8fbff, #f0f7ff);
        }
        
        .table tbody tr:hover {
            background: linear-gradient(135deg, #e8f4fd, #d6eaff);
            transform: translateY(-1px);
            box-shadow: 0 3px 8px rgba(102, 126, 234, 0.15);
        }
        
        .table tbody td {
            padding: 12px 10px;
            vertical-align: middle;
            border-color: #e9ecef;
            color: #2c3e50 !important;
        }
        
        /* Enhanced Opening Balance Row Style */
        .opening-row {
            background: linear-gradient(135deg, #3498db, #2980b9) !important;
            color: white !important;
            font-weight: 700 !important;
            border-top: 3px solid #2c3e50 !important;
            border-bottom: 3px solid #2c3e50 !important;
            box-shadow: 0 4px 8px rgba(52, 152, 219, 0.3) !important;
        }
        
        .opening-row td {
            color: white !important;
            font-weight: 700 !important;
            text-shadow: 0 1px 2px rgba(0, 0, 0, 0.2) !important;
            padding: 18px 10px !important;
        }
        
        .opening-row:hover {
            background: linear-gradient(135deg, #2980b9, #1f4e79) !important;
            transform: none !important;
        }
        
        .totals-row {
            background: linear-gradient(135deg, #f39c12, #e67e22) !important;
            color: white !important;
            font-weight: 700 !important;
            border-top: 3px solid #d35400 !important;
            box-shadow: 0 4px 8px rgba(243, 156, 18, 0.3) !important;
        }
        
        .totals-row td {
            color: white !important;
            font-weight: 700 !important;
            text-shadow: 0 1px 2px rgba(0, 0, 0, 0.2) !important;
            padding: 18px 10px !important;
        }
        
        .totals-row:hover {
            background: linear-gradient(135deg, #e67e22, #d35400) !important;
            transform: none !important;
        }
        
        .closing-row {
            background: linear-gradient(135deg, #27ae60, #229954) !important;
            color: white !important;
            font-weight: 700 !important;
            border-top: 3px solid #1e8449 !important;
            box-shadow: 0 4px 8px rgba(39, 174, 96, 0.3) !important;
        }
        
        .closing-row td {
            color: white !important;
            font-weight: 700 !important;
            text-shadow: 0 1px 2px rgba(0, 0, 0, 0.2) !important;
            padding: 18px 10px !important;
        }
        
        .closing-row:hover {
            background: linear-gradient(135deg, #229954, #1e8449) !important;
            transform: none !important;
        }
        
        .amount-cell {
            text-align: left;
            font-weight: 600;
            font-family: 'Cairo', 'Courier New', monospace;
            padding: 8px 12px;
            border-radius: 6px;
            background: linear-gradient(135deg, #f8f9fa, #e9ecef);
            color: #2c3e50 !important;
        }
        
        .positive-amount {
            color: #ffffff;
            background: linear-gradient(135deg, #27ae60, #229954);
            box-shadow: 0 2px 4px rgba(39, 174, 96, 0.2);
            text-shadow: 0 1px 2px rgba(0, 0, 0, 0.1);
        }
        
        .negative-amount {
            color: #ffffff;
            background: linear-gradient(135deg, #e74c3c, #c0392b);
            box-shadow: 0 2px 4px rgba(231, 76, 60, 0.2);
            text-shadow: 0 1px 2px rgba(0, 0, 0, 0.1);
        }
        
        .message {
            padding: 15px 20px;
            border-radius: 8px;
            margin: 15px 0;
            font-weight: 500;
            display: flex;
            align-items: center;
        }
        
        .success-message {
            background: linear-gradient(135deg, #d4edda, #c3e6cb);
            border-left: 4px solid #28a745;
            color: #155724;
        }
        
        .error-message {
            background: linear-gradient(135deg, #f8d7da, #f5c6cb);
            border-left: 4px solid #dc3545;
            color: #721c24;
        }
        
        .message i {
            margin-left: 8px;
            font-size: 1.1rem;
        }
        
        .no-data {
            text-align: center;
            padding: 60px 20px;
            color: #6c757d;
        }
        
        .no-data i {
            font-size: 3rem;
            margin-bottom: 15px;
            color: #dee2e6;
        }
        
        /* Monthly Pivot Table Styles */
        .analysis-section {
            margin-top: 30px;
            border-radius: 15px;
            overflow: hidden;
            box-shadow: 0 5px 15px rgba(0,0,0,0.1);
        }
        
        .section-header {
            background: linear-gradient(135deg, #6f42c1, #8e44ad);
            color: white;
            padding: 20px;
            border-radius: 15px 15px 0 0;
            margin-bottom: 0;
        }
        
        .section-title {
            margin: 0;
            font-size: 1.4rem;
            font-weight: 600;
        }
        
        .month-cell {
            font-weight: 600;
            color: #2c3e50 !important;
        }
        
        .amount-pivot {
            font-weight: 500;
            font-family: 'Cairo', 'Courier New', monospace;
            color: #2c3e50 !important;
        }
        
        .positive-pivot {
            color: #ffffff;
            background: linear-gradient(135deg, #27ae60, #229954);
            box-shadow: 0 2px 4px rgba(39, 174, 96, 0.2);
            text-shadow: 0 1px 2px rgba(0, 0, 0, 0.1);
            padding: 4px 8px;
            border-radius: 4px;
        }
        
        .negative-pivot {
            color: #ffffff;
            background: linear-gradient(135deg, #e74c3c, #c0392b);
            box-shadow: 0 2px 4px rgba(231, 76, 60, 0.2);
            text-shadow: 0 1px 2px rgba(0, 0, 0, 0.1);
            padding: 4px 8px;
            border-radius: 4px;
        }
        
        .total-row {
            background: linear-gradient(135deg, #f39c12, #e67e22) !important;
            color: white !important;
            font-weight: 700 !important;
        }
        
        .total-row td {
            color: white !important;
            font-weight: 700 !important;
            text-shadow: 0 1px 2px rgba(0, 0, 0, 0.2) !important;
        }
        
        /* تأكيد على لون النص في جميع خانات الجدول */
        .table td,
        .table th {
            color: #2c3e50 !important;
        }
        
        .table thead th {
            background: linear-gradient(135deg, #34495e, #2c3e50);
            color: white !important;
        }
        
        /* إضافة قواعد شاملة لضمان ظهور النص بوضوح */
        .table tbody tr td,
        .table tbody tr th,
        .table td *,
        .table th *,
        .gridview td,
        .gridview th,
        .form-control,
        .form-select,
        .form-check-label,
        .balance-title,
        .section-title,
        .card-body,
        .card-header {
            color: #2c3e50 !important;
        }
        
        /* تأكيد لون النص في البطاقات */
        .balance-card,
        .balance-card *,
        .card,
        .card * {
            color: #2c3e50 !important;
        }
        
        /* استثناءات للنصوص البيضاء المطلوبة */
        .page-header,
        .page-header *,
        .table thead th,
        .table thead th *,
        .opening-row,
        .opening-row *,
        .totals-row,
        .totals-row *,
        .closing-row,
        .closing-row *,
        .total-row,
        .total-row *,
        .positive-amount,
        .positive-amount *,
        .negative-amount,
        .negative-amount *,
        .positive-pivot,
        .positive-pivot *,
        .negative-pivot,
        .negative-pivot *,
        .btn,
        .btn * {
            color: white !important;
        }
        
        @media print {
            body { 
                background: white;
                padding: 0;
            }
            
            .main-container {
                box-shadow: none;
                border-radius: 0;
            }
            
            .page-header,
            .controls-section,
            .btn,
            .analysis-section {
                display: none !important;
            }
            
            .table {
                font-size: 12px;
            }
            
            .balance-cards {
                grid-template-columns: repeat(3, 1fr);
                gap: 10px;
                margin-bottom: 20px;
            }
            
            .balance-card {
                padding: 15px;
            }
            
            @page {
                size: A4 landscape;
                margin: 1cm;
            }
        }
        
        @media (max-width: 768px) {
            .balance-cards {
                grid-template-columns: 1fr;
            }
            
            .table {
                font-size: 0.8rem;
            }
            
            .balance-card {
                padding: 15px;
            }
            
            .page-title {
                font-size: 1.8rem;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="row justify-content-center">
                <div class="col-12 col-xl-11">
                    <div class="main-container">
                        <!-- Page Header -->
                        <div class="page-header">
                            <h1 class="page-title">
                                <i class="fas fa-user-tie me-3"></i>
                                كشف حساب العميل
                            </h1>
                            <p class="page-subtitle">تقرير شامل لحركة حساب العميل</p>
                            
                            <div class="customer-info" runat="server" id="customerInfo" visible="false">
                                <h2 runat="server" id="customerName">العميل: غير محدد</h2>
                            </div>
                        </div>

                        <!-- Controls Section -->
                        <div class="controls-section">
                            <div class="row">
                                <div class="col-md-2">
                                    <div class="control-group">
                                        <label class="form-label">
                                            <i class="fas fa-building me-2"></i>
                                            اختيار الحساب
                                        </label>
                                        <asp:DropDownList ID="ddlAccount" runat="server" CssClass="form-select" 
                                                        AutoPostBack="true" OnSelectedIndexChanged="ddlAccount_SelectedIndexChanged">
                                            <asp:ListItem Value="" Text="-- جميع الحسابات --"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-2">
                                    <div class="control-group">
                                        <label class="form-label">
                                            <i class="fas fa-user-tie me-2"></i>
                                            اختيار العميل
                                        </label>
                                        <asp:DropDownList ID="ddlCustomer" runat="server" CssClass="form-select" 
                                                        AutoPostBack="true" OnSelectedIndexChanged="ddlCustomer_SelectedIndexChanged">
                                            <asp:ListItem Value="" Text="اختر العميل"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-2">
                                    <div class="control-group">
                                        <label class="form-label">
                                            <i class="fas fa-user me-2"></i>
                                            أو أدخل رقم العميل
                                        </label>
                                        <asp:TextBox ID="txtCustomer" runat="server" CssClass="form-control" 
                                                   placeholder="رقم العميل"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-2">
                                    <div class="control-group">
                                        <label class="form-label">
                                            <i class="fas fa-calendar-alt me-2"></i>
                                            من تاريخ
                                        </label>
                                        <asp:TextBox ID="txtFromDate" runat="server" CssClass="form-control" 
                                                   TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-2">
                                    <div class="control-group">
                                        <label class="form-label">
                                            <i class="fas fa-calendar-alt me-2"></i>
                                            إلى تاريخ
                                        </label>
                                        <asp:TextBox ID="txtToDate" runat="server" CssClass="form-control" 
                                                   TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-2">
                                    <div class="control-group">
                                        <label class="form-label">&nbsp;</label>
                                        <div class="d-grid">
                                            <asp:Button ID="btnSearch" runat="server" Text="عرض الكشف" 
                                                      CssClass="btn btn-search" OnClick="btnSearch_Click" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            
                            <!-- Additional Options -->
                            <div class="row mt-3">
                                <div class="col-12">
                                    <div class="options-panel">
                                        <div class="form-check">
                                            <asp:CheckBox ID="chkShowOpeningBalance" runat="server" CssClass="form-check-input" />
                                            <label class="form-check-label" for="<%= chkShowOpeningBalance.ClientID %>">
                                                <i class="fas fa-balance-scale"></i> عرض الرصيد الافتتاحي
                                            </label>
                                        </div>
                                        <div class="form-check">
                                            <asp:CheckBox ID="chkShowMonthlyPivot" runat="server" CssClass="form-check-input" />
                                            <label class="form-check-label" for="<%= chkShowMonthlyPivot.ClientID %>">
                                                <i class="fas fa-calendar-alt"></i> عرض جدول البيفوت الشهري
                                            </label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            
                            <!-- Export Buttons -->
                            <div class="row mt-3" id="exportButtons" runat="server" visible="false">
                                <div class="col-12 text-center">
                                    <asp:Button ID="btnExportExcel" runat="server" Text="تصدير إكسل" 
                                              CssClass="btn btn-export" OnClick="btnExportExcel_Click" />
                                    <asp:Button ID="btnPrint" runat="server" Text="طباعة" 
                                              CssClass="btn btn-export btn-print" OnClientClick="window.print(); return false;" />
                                </div>
                            </div>
                        </div>

                        <!-- Messages -->
                        <asp:Literal ID="litMessage" runat="server"></asp:Literal>

                        <!-- Balance Cards -->
                        <div id="balanceSection" runat="server" visible="false">
                            <div class="balance-cards">
                                <div class="balance-card opening">
                                    <div class="balance-title">الرصيد الافتتاحي</div>
                                    <div id="openingBalanceCard" runat="server" class="balance-amount">0.00</div>
                                    <small class="text-muted">قبل الفترة المحددة</small>
                                </div>
                                <div class="balance-card period">
                                    <div class="balance-title">حركة الفترة</div>
                                    <div id="periodMovementCard" runat="server" class="balance-amount">0.00</div>
                                    <small class="text-muted">صافي الحركة</small>
                                </div>
                                <div class="balance-card closing">
                                    <div class="balance-title">الرصيد الختامي</div>
                                    <div id="closingBalanceCard" runat="server" class="balance-amount">0.00</div>
                                    <small class="text-muted">نهاية الفترة</small>
                                </div>
                                <div class="balance-card stats">
                                    <div class="balance-title">عدد المعاملات</div>
                                    <div id="transactionCountCard" runat="server" class="balance-amount">0</div>
                                    <small class="text-muted">إجمالي المعاملات</small>
                                </div>
                            </div>
                        </div>

                        <!-- Statement Table -->
                        <div id="tableContainer" runat="server" visible="false" class="statement-table">
                            <div class="table-responsive">
                                <asp:GridView ID="gvStatement" runat="server" CssClass="table table-hover" 
                                            AutoGenerateColumns="false" OnRowDataBound="gvStatement_RowDataBound"
                                            GridLines="None" ShowHeaderWhenEmpty="true">
                                    <Columns>
                                        <asp:BoundField DataField="Tr_Dt" HeaderText="التاريخ" DataFormatString="{0:dd/MM/yyyy}" 
                                                      ItemStyle-CssClass="text-center" HeaderStyle-Width="100px" />
                                        <asp:BoundField DataField="Tr_no" HeaderText="رقم القيد" 
                                                      ItemStyle-CssClass="text-center" HeaderStyle-Width="100px" />
                                        <asp:BoundField DataField="Acc_no" HeaderText="رقم الحساب" 
                                                      ItemStyle-CssClass="text-center" HeaderStyle-Width="100px" />
                                        <asp:BoundField DataField="Acc_Nm" HeaderText="اسم الحساب" 
                                                      ItemStyle-CssClass="text-right" HeaderStyle-Width="200px" />
                                        <asp:BoundField DataField="Description" HeaderText="البيان" 
                                                      ItemStyle-CssClass="text-right" />
                                        <asp:BoundField DataField="Tr_db" HeaderText="مدين" 
                                                      ItemStyle-CssClass="amount-cell text-end" HeaderStyle-Width="120px" />
                                        <asp:BoundField DataField="tr_cr" HeaderText="دائن" 
                                                      ItemStyle-CssClass="amount-cell text-end" HeaderStyle-Width="120px" />
                                        <asp:BoundField DataField="RunningBalance" HeaderText="الرصيد الجاري" 
                                                      ItemStyle-CssClass="amount-cell text-end" HeaderStyle-Width="140px" />
                                    </Columns>
                                    <EmptyDataTemplate>
                                        <div class="no-data">
                                            <i class="fas fa-inbox"></i>
                                            <div>لا توجد بيانات لعرضها</div>
                                        </div>
                                    </EmptyDataTemplate>
                                </asp:GridView>
                            </div>
                        </div>

                        <!-- Monthly Pivot Section -->
                        <div id="monthlyPivotSection" runat="server" visible="false">
                            <div class="analysis-section">
                                <div class="section-header">
                                    <h4 class="section-title">
                                        <i class="fas fa-calendar-alt me-2"></i>
                                        التحليل الشهري للعميل
                                    </h4>
                                </div>
                                <div class="table-responsive" style="background: white; padding: 20px;">
                                    <asp:GridView ID="gvMonthlyPivot" runat="server" CssClass="table table-hover" 
                                                AutoGenerateColumns="False" EmptyDataText="لا توجد بيانات للتحليل الشهري"
                                                OnRowDataBound="gvMonthlyPivot_RowDataBound" GridLines="None" ShowHeaderWhenEmpty="true">
                                        <Columns>
                                            <asp:BoundField DataField="MonthName" HeaderText="الشهر" 
                                                ItemStyle-CssClass="month-cell text-center" HeaderStyle-Width="150px" />
                                            <asp:BoundField DataField="TotalDebit" HeaderText="إجمالي المدين" 
                                                DataFormatString="{0:N2}" ItemStyle-CssClass="amount-pivot text-end" HeaderStyle-Width="120px" />
                                            <asp:BoundField DataField="TotalCredit" HeaderText="إجمالي الدائن" 
                                                DataFormatString="{0:N2}" ItemStyle-CssClass="amount-pivot text-end" HeaderStyle-Width="120px" />
                                            <asp:BoundField DataField="NetMovement" HeaderText="صافي الحركة" 
                                                DataFormatString="{0:N2}" ItemStyle-CssClass="amount-pivot text-end" HeaderStyle-Width="120px" />
                                            <asp:BoundField DataField="TransactionCount" HeaderText="عدد المعاملات" 
                                                ItemStyle-CssClass="month-cell text-center" HeaderStyle-Width="100px" />
                                        </Columns>
                                        <EmptyDataTemplate>
                                            <div class="no-data">
                                                <i class="fas fa-chart-bar"></i>
                                                <div>لا توجد بيانات للتحليل الشهري</div>
                                            </div>
                                        </EmptyDataTemplate>
                                    </asp:GridView>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <!-- Bootstrap 5 JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
    
    <script type="text/javascript">
        // Initialize page
        document.addEventListener('DOMContentLoaded', function() {
            // Set default dates if empty
            const today = new Date().toISOString().split('T')[0];
            const fromDateInput = document.getElementById('<%= txtFromDate.ClientID %>');
            const toDateInput = document.getElementById('<%= txtToDate.ClientID %>');
            
            if (fromDateInput && !fromDateInput.value) {
                const firstOfYear = new Date(new Date().getFullYear(), 0, 1);
                fromDateInput.value = firstOfYear.toISOString().split('T')[0];
            }
            
            if (toDateInput && !toDateInput.value) {
                toDateInput.value = today;
            }
        });
    </script>
</body>
</html>
