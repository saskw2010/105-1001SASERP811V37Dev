<%@ Page Title="Modern System Test" Language="VB" MasterPageFile="~/Main.master" CodeFile="ModernTest.aspx.vb" Inherits="ModernTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .test-section {
            margin: 2rem 0;
            padding: 1.5rem;
            background: var(--bg-secondary);
            border-radius: var(--border-radius-lg);
            box-shadow: var(--shadow-sm);
        }
        
        .test-title {
            color: var(--primary-color);
            font-size: 1.5rem;
            margin-bottom: 1rem;
            border-bottom: 2px solid var(--primary-color);
            padding-bottom: 0.5rem;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="server">
    <div class="modern-page-header">
        <h1><i class="fas fa-cogs"></i> اختبار النظام الحديث</h1>
        <p>صفحة اختبار شاملة للتصميم الحديث والمكونات المطورة</p>
    </div>

    <!-- اختبار الأزرار -->
    <div class="test-section">
        <h2 class="test-title"><i class="fas fa-mouse-pointer"></i> اختبار الأزرار</h2>
        <div class="modern-buttons-group">
            <asp:Button ID="btnPrimary" runat="server" Text="زر أساسي" CssClass="btn btn-primary" />
            <asp:Button ID="btnSecondary" runat="server" Text="زر ثانوي" CssClass="btn btn-secondary" />
            <asp:Button ID="btnSuccess" runat="server" Text="نجح" CssClass="btn btn-success" />
            <asp:Button ID="btnDanger" runat="server" Text="خطر" CssClass="btn btn-danger" />
            <asp:Button ID="btnWarning" runat="server" Text="تحذير" CssClass="btn btn-warning" />
        </div>
    </div>

    <!-- اختبار النماذج -->
    <div class="test-section">
        <h2 class="test-title"><i class="fas fa-wpforms"></i> اختبار النماذج</h2>
        <div class="modern-form">
            <div class="form-group">
                <label for="txtName" class="form-label">الاسم:</label>
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="أدخل اسمك هنا" />
            </div>
            <div class="form-group">
                <label for="txtEmail" class="form-label">البريد الإلكتروني:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" placeholder="example@email.com" />
            </div>
            <div class="form-group">
                <label for="ddlDepartment" class="form-label">القسم:</label>
                <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="form-control">
                    <asp:ListItem Text="اختر القسم" Value="" />
                    <asp:ListItem Text="المبيعات" Value="sales" />
                    <asp:ListItem Text="المحاسبة" Value="accounting" />
                    <asp:ListItem Text="الموارد البشرية" Value="hr" />
                    <asp:ListItem Text="تقنية المعلومات" Value="it" />
                </asp:DropDownList>
            </div>
        </div>
    </div>

    <!-- اختبار البطاقات -->
    <div class="test-section">
        <h2 class="test-title"><i class="fas fa-id-card"></i> اختبار البطاقات</h2>
        <div class="cards-grid">
            <div class="modern-card">
                <div class="card-header">
                    <h3><i class="fas fa-chart-line"></i> المبيعات</h3>
                </div>
                <div class="card-body">
                    <p class="card-number">1,234,567</p>
                    <p class="card-label">إجمالي المبيعات</p>
                </div>
            </div>
            
            <div class="modern-card">
                <div class="card-header">
                    <h3><i class="fas fa-users"></i> العملاء</h3>
                </div>
                <div class="card-body">
                    <p class="card-number">856</p>
                    <p class="card-label">عدد العملاء</p>
                </div>
            </div>
            
            <div class="modern-card">
                <div class="card-header">
                    <h3><i class="fas fa-box"></i> المنتجات</h3>
                </div>
                <div class="card-body">
                    <p class="card-number">342</p>
                    <p class="card-label">المنتجات المتاحة</p>
                </div>
            </div>
        </div>
    </div>

    <!-- اختبار الجداول -->
    <div class="test-section">
        <h2 class="test-title"><i class="fas fa-table"></i> اختبار الجداول</h2>
        <div class="modern-table-container">
            <asp:GridView ID="gvSampleData" runat="server" CssClass="modern-table" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="المعرف" />
                    <asp:BoundField DataField="Name" HeaderText="الاسم" />
                    <asp:BoundField DataField="Department" HeaderText="القسم" />
                    <asp:BoundField DataField="Salary" HeaderText="الراتب" DataFormatString="{0:C}" />
                    <asp:TemplateField HeaderText="الإجراءات">
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" Text="تعديل" CssClass="btn btn-sm btn-primary" />
                            <asp:Button ID="btnDelete" runat="server" Text="حذف" CssClass="btn btn-sm btn-danger" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>

    <!-- اختبار التبويبات -->
    <div class="test-section">
        <h2 class="test-title"><i class="fas fa-folder-open"></i> اختبار التبويبات</h2>
        <div class="modern-tabs">
            <div class="tab-buttons">
                <button type="button" class="tab-button active" onclick="showTab('tab1')">المعلومات العامة</button>
                <button type="button" class="tab-button" onclick="showTab('tab2')">الإعدادات</button>
                <button type="button" class="tab-button" onclick="showTab('tab3')">التقارير</button>
            </div>
            
            <div class="tab-content active" id="tab1">
                <h3>المعلومات العامة</h3>
                <p>هذا النص يوضح كيفية عرض المعلومات العامة في التبويب الأول. يمكنك إضافة أي محتوى هنا.</p>
            </div>
            
            <div class="tab-content" id="tab2">
                <h3>الإعدادات</h3>
                <p>تبويب الإعدادات يحتوي على خيارات التكوين والتخصيص الخاصة بالنظام.</p>
            </div>
            
            <div class="tab-content" id="tab3">
                <h3>التقارير</h3>
                <p>في هذا القسم يمكنك الوصول إلى جميع التقارير والإحصائيات المتاحة.</p>
            </div>
        </div>
    </div>

    <script>
        function showTab(tabId) {
            // إخفاء جميع التبويبات
            document.querySelectorAll('.tab-content').forEach(tab => {
                tab.classList.remove('active');
            });
            
            // إزالة التفعيل من جميع الأزرار
            document.querySelectorAll('.tab-button').forEach(btn => {
                btn.classList.remove('active');
            });
            
            // إظهار التبويب المحدد
            document.getElementById(tabId).classList.add('active');
            
            // تفعيل الزر المناسب
            event.target.classList.add('active');
        }
    </script>
</asp:Content>
