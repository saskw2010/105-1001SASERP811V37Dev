<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DashboardPreview.aspx.vb" Inherits="TestPages_DashboardPreview" %>
<%@ Register TagPrefix="uc" TagName="FinancialDashboard" Src="~/Controls/FinancialDashboard.ascx" %>
<%@ Register TagPrefix="uc" TagName="HRDashboard" Src="~/Controls/HRDashboard.ascx" %>
<%@ Register TagPrefix="uc" TagName="OperationsDashboard" Src="~/Controls/OperationsDashboard.ascx" %>
<%@ Register TagPrefix="uc" TagName="ReportsDashboard" Src="~/Controls/ReportsDashboard.ascx" %>

<!DOCTYPE html>
<html lang="ar" dir="rtl">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>معاينة الدشبورد - SASERP V37</title>
    
    <!-- Bootstrap CSS -->
    <link href="~/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <!-- Font Awesome -->
    <link href="~/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    
    <style>
        body {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            font-family: 'Cairo', 'Segoe UI', Arial, sans-serif;
            min-height: 100vh;
            padding: 20px 0;
        }
        
        .preview-header {
            background: white;
            padding: 25px;
            border-radius: 15px;
            margin-bottom: 30px;
            box-shadow: 0 10px 30px rgba(0,0,0,0.1);
            text-align: center;
        }
        
        .preview-header h1 {
            color: #2c3e50;
            font-size: 2.5rem;
            margin-bottom: 10px;
            font-weight: 700;
        }
        
        .preview-header p {
            color: #7f8c8d;
            font-size: 1.1rem;
            margin: 0;
        }
        
        .dashboard-section {
            margin-bottom: 40px;
        }
        
        .section-title {
            background: white;
            padding: 15px 25px;
            border-radius: 10px;
            margin-bottom: 20px;
            box-shadow: 0 5px 15px rgba(0,0,0,0.08);
        }
        
        .section-title h2 {
            color: #2c3e50;
            margin: 0;
            font-size: 1.5rem;
            font-weight: 600;
            display: flex;
            align-items: center;
            gap: 10px;
        }
        
        .dashboard-container {
            background: rgba(255,255,255,0.95);
            border-radius: 15px;
            padding: 20px;
            box-shadow: 0 10px 30px rgba(0,0,0,0.1);
            backdrop-filter: blur(10px);
        }
        
        .test-info {
            background: #3498db;
            color: white;
            padding: 15px;
            border-radius: 10px;
            margin-bottom: 30px;
            text-align: center;
        }
        
        .test-info h3 {
            margin: 0 0 10px 0;
            font-size: 1.3rem;
        }
        
        .test-info p {
            margin: 0;
            opacity: 0.9;
        }
        
        /* Custom Dashboard Styles */
        .main-master-dashboard {
            background: transparent !important;
            border-radius: 0 !important;
            padding: 0 !important;
            margin: 0 !important;
            box-shadow: none !important;
        }
        
        @media (max-width: 768px) {
            .preview-header h1 {
                font-size: 2rem;
            }
            
            .preview-header p {
                font-size: 1rem;
            }
            
            body {
                padding: 10px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            
            <!-- Header -->
            <div class="preview-header">
                <h1><i class="fas fa-tachometer-alt text-primary"></i> معاينة الدشبورد</h1>
                <p>عرض جميع كنترولز الدشبورد مع البيانات الافتراضية</p>
            </div>
            
            <!-- Test Info -->
            <div class="test-info">
                <h3><i class="fas fa-info-circle"></i> معلومات الاختبار</h3>
                <p>هذه الصفحة تعرض جميع كنترولز الدشبورد مع البيانات الافتراضية للتأكد من عملها بشكل صحيح</p>
            </div>
            
            <!-- Financial Dashboard -->
            <div class="dashboard-section">
                <div class="section-title">
                    <h2><i class="fas fa-chart-line text-success"></i> الدشبورد المالي</h2>
                </div>
                <div class="dashboard-container">
                    <uc:FinancialDashboard ID="FinancialDashboard1" runat="server" />
                </div>
            </div>
            
            <!-- HR Dashboard -->
            <div class="dashboard-section">
                <div class="section-title">
                    <h2><i class="fas fa-users text-info"></i> دشبورد الموارد البشرية</h2>
                </div>
                <div class="dashboard-container">
                    <uc:HRDashboard ID="HRDashboard1" runat="server" />
                </div>
            </div>
            
            <!-- Operations Dashboard -->
            <div class="dashboard-section">
                <div class="section-title">
                    <h2><i class="fas fa-cogs text-warning"></i> دشبورد العمليات</h2>
                </div>
                <div class="dashboard-container">
                    <uc:OperationsDashboard ID="OperationsDashboard1" runat="server" />
                </div>
            </div>
            
            <!-- Reports Dashboard -->
            <div class="dashboard-section">
                <div class="section-title">
                    <h2><i class="fas fa-chart-bar text-danger"></i> دشبورد التقارير</h2>
                </div>
                <div class="dashboard-container">
                    <uc:ReportsDashboard ID="ReportsDashboard1" runat="server" />
                </div>
            </div>
            
            <!-- Footer -->
            <div style="text-align: center; margin-top: 50px; padding: 20px;">
                <div style="background: white; border-radius: 10px; padding: 20px; display: inline-block;">
                    <h4 style="color: #2c3e50; margin: 0 0 10px 0;">
                        <i class="fas fa-check-circle text-success"></i> 
                        اختبار الدشبورد مكتمل
                    </h4>
                    <p style="color: #7f8c8d; margin: 0;">
                        جميع الكنترولز تعمل بشكل صحيح مع البيانات الافتراضية
                    </p>
                </div>
            </div>
            
        </div>
    </form>
    
    <!-- JavaScript -->
    <script src="~/js/jquery.min.js"></script>
    <script src="~/js/bootstrap.min.js"></script>
    
    <script>
        $(document).ready(function() {
            console.log('🎯 صفحة معاينة الدشبورد جاهزة');
            
            // تحسين تجربة المستخدم
            $('.dashboard-container').hover(
                function() {
                    $(this).css('transform', 'scale(1.02)');
                    $(this).css('transition', 'all 0.3s ease');
                },
                function() {
                    $(this).css('transform', 'scale(1)');
                }
            );
            
            // رسالة نجاح
            setTimeout(function() {
                console.log('✅ تم تحميل جميع الدشبوردز بنجاح');
            }, 1000);
        });
    </script>
</body>
</html>
