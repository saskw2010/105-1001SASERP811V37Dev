<%@ Page Language="VB" MasterPageFile="~/ModernMaster.master" AutoEventWireup="false" CodeFile="TestRealEstate.aspx.vb" Inherits="TestPages_ASPXADV_TestRealEstate" Title="Real Estate Control Test" %>
<%@ Register TagPrefix="uc" TagName="RealEstate" Src="~/Controls/RealEstateControl.ascx" %>
<%@ Register TagPrefix="modern" TagName="ModernAjarTOC" Src="~/Controls/ModernAjarTOC.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <!-- Real Estate Control Test Page Styles -->
    <style>
        .test-header {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            padding: 2rem 0;
            margin-bottom: 2rem;
        }
        
        .test-header h1 {
            font-size: 2.5rem;
            font-weight: 300;
            margin: 0;
        }
        
        .test-header p {
            font-size: 1.1rem;
            margin: 0.5rem 0 0 0;
            opacity: 0.9;
        }
        
        .test-section {
            background: white;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            padding: 2rem;
            margin-bottom: 2rem;
        }
        
        .test-info {
            background: #f8f9fa;
            border: 1px solid #e9ecef;
            border-radius: 6px;
            padding: 1rem;
            margin-bottom: 2rem;
        }
        
        .test-info h3 {
            color: #495057;
            font-size: 1.2rem;
            margin: 0 0 0.5rem 0;
        }
        
        .test-info ul {
            margin: 0;
            padding-right: 1.5rem;
        }
        
        .test-info li {
            margin-bottom: 0.3rem;
            color: #6c757d;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <!-- Test Header -->
    <div class="test-header">
        <div class="container">
            <h1>🏠 Real Estate Control Test</h1>
            <p>اختبار شامل لنظام إدارة العقارات</p>
        </div>
    </div>

    <div class="container">
        <!-- Test Information -->
        <div class="test-info">
            <h3>📋 معلومات الاختبار</h3>
            <ul>
                <li><strong>تاريخ الإنشاء:</strong> <%= DateTime.Now.ToString("dd/MM/yyyy HH:mm") %></li>
                <li><strong>إصدار الكنترول:</strong> RealEstateControl v1.0</li>
                <li><strong>المميزات المتاحة:</strong> إحصائيات، بحث وتصفية، عرض العقارات، ترقيم الصفحات</li>
                <li><strong>قاعدة البيانات:</strong> بيانات تجريبية (Sample Data)</li>
                <li><strong>التوافق:</strong> Bootstrap 4+, Font Awesome 6, Arabic RTL</li>
                <li><strong>Modern Navigation:</strong> ModernAjarTOC متضمن للتنقل المتقدم</li>
            </ul>
        </div>

        <!-- Modern Ajar Table of Contents Section -->
        <div class="test-section">
            <h2 style="color: #343a40; margin-bottom: 1.5rem;">
                <i class="fas fa-sitemap"></i>
                التنقل المتقدم - Modern Ajar Navigation
            </h2>
            
            <!-- Modern Ajar TOC -->
            <modern:ModernAjarTOC ID="ModernAjarNavigation" runat="server" />
        </div>

        <!-- Real Estate Control Test Section -->
        <div class="test-section">
            <h2 style="color: #343a40; margin-bottom: 1.5rem;">
                <i class="fas fa-building"></i>
                نظام إدارة العقارات
            </h2>
            
            <!-- Real Estate Control -->
            <uc:RealEstate ID="RealEstateControl1" runat="server" />
        </div>

        <!-- Test Notes -->
        <div class="test-section">
            <h3 style="color: #495057;">📝 ملاحظات الاختبار</h3>
            <div class="row">
                <div class="col-md-6">
                    <h5>المميزات المتاحة:</h5>
                    <ul>
                        <li>عرض إحصائيات العقارات في الوقت الفعلي</li>
                        <li>تصفية متقدمة حسب النوع والحالة والمنطقة</li>
                        <li>عرض العقارات في تخطيط شبكي متجاوب</li>
                        <li>نظام ترقيم صفحات متقدم</li>
                        <li>دعم كامل للغة العربية واتجاه RTL</li>
                        <li>تصميم متجاوب للجوال والتابلت</li>
                    </ul>
                </div>
                <div class="col-md-6">
                    <h5>الاختبارات المطلوبة:</h5>
                    <ul>
                        <li>✅ تحميل البيانات الأولية</li>
                        <li>✅ عرض الإحصائيات</li>
                        <li>🔄 اختبار التصفية والبحث</li>
                        <li>🔄 اختبار التنقل بين الصفحات</li>
                        <li>🔄 اختبار التجاوب على الشاشات المختلفة</li>
                        <li>🔄 اختبار الأداء مع البيانات الكثيرة</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
