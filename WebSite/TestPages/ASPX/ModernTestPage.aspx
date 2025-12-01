<%@ Page Title="Modern Test Dashboard" Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="ModernTestPage.aspx.vb" Inherits="ModernTestPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* صفحة الاختبار الدائمة للنظام الحديث */
        .test-dashboard {
            padding: 20px;
            max-width: 1400px;
            margin: 0 auto;
        }

        .dashboard-header {
            background: var(--bg-primary);
            padding: 30px;
            border-radius: var(--border-radius-lg);
            margin-bottom: 30px;
            box-shadow: var(--shadow-md);
            text-align: center;
        }

        .dashboard-title {
            color: var(--primary-color);
            font-size: 2.5rem;
            font-weight: 700;
            margin-bottom: 10px;
        }

        .dashboard-subtitle {
            color: var(--text-secondary);
            font-size: 1.1rem;
        }

        .test-sections {
            display: grid;
            gap: 30px;
        }

        .test-section {
            background: var(--bg-primary);
            border-radius: var(--border-radius-lg);
            padding: 25px;
            box-shadow: var(--shadow-sm);
            border-left: 4px solid var(--primary-color);
        }

        .section-title {
            color: var(--text-primary);
            font-size: 1.4rem;
            font-weight: 600;
            margin-bottom: 20px;
            display: flex;
            align-items: center;
            gap: 10px;
        }

        .section-title i {
            color: var(--primary-color);
        }

        /* اختبار النماذج */
        .form-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 20px;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-label {
            display: block;
            margin-bottom: 8px;
            color: var(--text-primary);
            font-weight: 500;
        }

        .form-control {
            width: 100%;
            padding: 12px 15px;
            border: 2px solid var(--border-color);
            border-radius: var(--border-radius-md);
            font-size: 1rem;
            transition: var(--transition-normal);
            background: var(--bg-primary);
            color: var(--text-primary);
        }

        .form-control:focus {
            outline: none;
            border-color: var(--primary-color);
            box-shadow: 0 0 0 3px var(--primary-color-light);
        }

        /* اختبار الأزرار */
        .buttons-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(150px, 1fr));
            gap: 15px;
        }

        .btn {
            padding: 12px 20px;
            border: none;
            border-radius: var(--border-radius-md);
            font-size: 1rem;
            font-weight: 500;
            cursor: pointer;
            transition: var(--transition-normal);
            text-decoration: none;
            display: inline-flex;
            align-items: center;
            justify-content: center;
            gap: 8px;
        }

        .btn-primary {
            background: var(--primary-color);
            color: var(--text-light);
        }

        .btn-primary:hover {
            background: var(--primary-color-dark);
            transform: translateY(-2px);
            box-shadow: var(--shadow-md);
        }

        .btn-secondary {
            background: var(--secondary-color);
            color: var(--text-light);
        }

        .btn-success {
            background: var(--success-color);
            color: var(--text-light);
        }

        .btn-danger {
            background: var(--danger-color);
            color: var(--text-light);
        }

        .btn-warning {
            background: var(--warning-color);
            color: var(--text-dark);
        }

        /* اختبار الجداول */
        .table-container {
            overflow-x: auto;
            border-radius: var(--border-radius-md);
            box-shadow: var(--shadow-sm);
        }

        .modern-table {
            width: 100%;
            border-collapse: collapse;
            background: var(--bg-primary);
        }

        .modern-table th {
            background: var(--primary-color);
            color: var(--text-light);
            padding: 15px;
            text-align: right;
            font-weight: 600;
        }

        .modern-table td {
            padding: 12px 15px;
            border-bottom: 1px solid var(--border-color);
            color: var(--text-primary);
        }

        .modern-table tr:hover {
            background: var(--bg-hover);
        }

        /* اختبار البطاقات */
        .cards-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 20px;
        }

        .test-card {
            background: var(--bg-primary);
            border-radius: var(--border-radius-lg);
            padding: 20px;
            box-shadow: var(--shadow-sm);
            transition: var(--transition-normal);
            border: 1px solid var(--border-color);
        }

        .test-card:hover {
            transform: translateY(-5px);
            box-shadow: var(--shadow-lg);
        }

        .card-icon {
            font-size: 2rem;
            color: var(--primary-color);
            margin-bottom: 15px;
        }

        .card-title {
            color: var(--text-primary);
            font-size: 1.2rem;
            font-weight: 600;
            margin-bottom: 10px;
        }

        .card-content {
            color: var(--text-secondary);
            line-height: 1.6;
        }

        /* اختبار التبويبات */
        .tabs-container {
            margin-top: 20px;
        }

        .tab-buttons {
            display: flex;
            background: var(--bg-secondary);
            border-radius: var(--border-radius-md);
            padding: 5px;
            margin-bottom: 20px;
        }

        .tab-button {
            flex: 1;
            padding: 12px 20px;
            background: transparent;
            border: none;
            border-radius: var(--border-radius-sm);
            cursor: pointer;
            color: var(--text-secondary);
            font-weight: 500;
            transition: var(--transition-normal);
        }

        .tab-button.active {
            background: var(--primary-color);
            color: var(--text-light);
            box-shadow: var(--shadow-sm);
        }

        .tab-content {
            display: none;
            padding: 20px;
            background: var(--bg-primary);
            border-radius: var(--border-radius-md);
            border: 1px solid var(--border-color);
        }

        .tab-content.active {
            display: block;
        }

        /* اختبار الحالات */
        .status-indicators {
            display: flex;
            gap: 15px;
            flex-wrap: wrap;
        }

        .status-badge {
            padding: 8px 16px;
            border-radius: var(--border-radius-full);
            font-size: 0.9rem;
            font-weight: 500;
        }

        .status-success {
            background: var(--success-color-light);
            color: var(--success-color-dark);
        }

        .status-warning {
            background: var(--warning-color-light);
            color: var(--warning-color-dark);
        }

        .status-error {
            background: var(--danger-color-light);
            color: var(--danger-color-dark);
        }

        .status-info {
            background: var(--info-color-light);
            color: var(--info-color-dark);
        }

        /* اختبار المكونات التفاعلية */
        .interactive-demo {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
            gap: 20px;
        }

        .demo-item {
            text-align: center;
            padding: 20px;
            border: 2px dashed var(--border-color);
            border-radius: var(--border-radius-md);
            transition: var(--transition-normal);
        }

        .demo-item:hover {
            border-color: var(--primary-color);
            background: var(--primary-color-light);
        }

        @media (max-width: 768px) {
            .test-dashboard {
                padding: 15px;
            }

            .dashboard-title {
                font-size: 2rem;
            }

            .form-grid,
            .buttons-grid,
            .cards-grid {
                grid-template-columns: 1fr;
            }

            .tab-buttons {
                flex-direction: column;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="server">
    <div class="test-dashboard">
        <!-- رأس لوحة الاختبار -->
        <div class="dashboard-header">
            <h1 class="dashboard-title">
                <i class="fas fa-rocket"></i>
                لوحة الاختبار الحديثة
            </h1>
            <p class="dashboard-subtitle">
                اختبار شامل لجميع مكونات النظام الحديث - تحديث مستمر
            </p>
        </div>

        <div class="test-sections">
            <!-- اختبار النماذج -->
            <div class="test-section">
                <h2 class="section-title">
                    <i class="fas fa-wpforms"></i>
                    اختبار النماذج والمدخلات
                </h2>
                <div class="form-grid">
                    <div>
                        <div class="form-group">
                            <label class="form-label">الاسم الكامل:</label>
                            <asp:TextBox ID="txtFullName" runat="server" CssClass="form-control" placeholder="أدخل اسمك الكامل" />
                        </div>
                        <div class="form-group">
                            <label class="form-label">البريد الإلكتروني:</label>
                            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" placeholder="example@domain.com" />
                        </div>
                        <div class="form-group">
                            <label class="form-label">القسم:</label>
                            <asp:DropDownList ID="ddlDepartment" runat="server" CssClass="form-control">
                                <asp:ListItem Text="اختر القسم" Value="" />
                                <asp:ListItem Text="المبيعات" Value="sales" />
                                <asp:ListItem Text="المحاسبة" Value="accounting" />
                                <asp:ListItem Text="الموارد البشرية" Value="hr" />
                                <asp:ListItem Text="تقنية المعلومات" Value="it" />
                                <asp:ListItem Text="التسويق" Value="marketing" />
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div>
                        <div class="form-group">
                            <label class="form-label">تاريخ الميلاد:</label>
                            <asp:TextBox ID="txtBirthDate" runat="server" CssClass="form-control" TextMode="Date" />
                        </div>
                        <div class="form-group">
                            <label class="form-label">الراتب:</label>
                            <asp:TextBox ID="txtSalary" runat="server" CssClass="form-control" TextMode="Number" placeholder="0.00" />
                        </div>
                        <div class="form-group">
                            <label class="form-label">ملاحظات:</label>
                            <asp:TextBox ID="txtNotes" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="3" placeholder="أضف ملاحظاتك هنا..." />
                        </div>
                    </div>
                </div>
            </div>

            <!-- اختبار الأزرار -->
            <div class="test-section">
                <h2 class="section-title">
                    <i class="fas fa-mouse-pointer"></i>
                    اختبار الأزرار والإجراءات
                </h2>
                <div class="buttons-grid">
                    <asp:Button ID="btnPrimary" runat="server" Text="أساسي" CssClass="btn btn-primary" OnClick="btnPrimary_Click" />
                    <asp:Button ID="btnSecondary" runat="server" Text="⚙️ ثانوي" CssClass="btn btn-secondary" OnClick="btnSecondary_Click" />
                    <asp:Button ID="btnSuccess" runat="server" Text="نجح" CssClass="btn btn-success" OnClick="btnSuccess_Click" />
                    <asp:Button ID="btnDanger" runat="server" Text="خطر" CssClass="btn btn-danger" OnClick="btnDanger_Click" />
                    <asp:Button ID="btnWarning" runat="server" Text="تحذير" CssClass="btn btn-warning" OnClick="btnWarning_Click" />
                    <asp:LinkButton ID="lnkInfo" runat="server" CssClass="btn btn-primary" OnClick="lnkInfo_Click">
                        <i class="fas fa-info-circle"></i>
                        معلومات
                    </asp:LinkButton>
                </div>
            </div>

            <!-- اختبار البطاقات -->
            <div class="test-section">
                <h2 class="section-title">
                    <i class="fas fa-th-large"></i>
                    اختبار البطاقات والمكونات
                </h2>
                <div class="cards-grid">
                    <div class="test-card">
                        <div class="card-icon">
                            <i class="fas fa-users"></i>
                        </div>
                        <h3 class="card-title">إدارة المستخدمين</h3>
                        <p class="card-content">
                            إضافة وتعديل وحذف المستخدمين، إدارة الصلاحيات والأدوار.
                        </p>
                    </div>
                    <div class="test-card">
                        <div class="card-icon">
                            <i class="fas fa-chart-bar"></i>
                        </div>
                        <h3 class="card-title">التقارير والإحصائيات</h3>
                        <p class="card-content">
                            تقارير مفصلة وإحصائيات شاملة لجميع العمليات.
                        </p>
                    </div>
                    <div class="test-card">
                        <div class="card-icon">
                            <i class="fas fa-cogs"></i>
                        </div>
                        <h3 class="card-title">إعدادات النظام</h3>
                        <p class="card-content">
                            تخصيص النظام وإعداد المعايير والقواعد.
                        </p>
                    </div>
                    <div class="test-card">
                        <div class="card-icon">
                            <i class="fas fa-shield-alt"></i>
                        </div>
                        <h3 class="card-title">الأمان والحماية</h3>
                        <p class="card-content">
                            نظام أمان متقدم مع تشفير ومراقبة العمليات.
                        </p>
                    </div>
                </div>
            </div>

            <!-- اختبار الجداول -->
            <div class="test-section">
                <h2 class="section-title">
                    <i class="fas fa-table"></i>
                    اختبار الجداول والبيانات
                </h2>
                <div class="table-container">
                    <asp:GridView ID="gvTestData" runat="server" CssClass="modern-table" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="المعرف" />
                            <asp:BoundField DataField="Name" HeaderText="الاسم" />
                            <asp:BoundField DataField="Department" HeaderText="القسم" />
                            <asp:BoundField DataField="Position" HeaderText="المنصب" />
                            <asp:BoundField DataField="Salary" HeaderText="الراتب" DataFormatString="{0:C}" />
                            <asp:BoundField DataField="JoinDate" HeaderText="تاريخ الانضمام" DataFormatString="{0:yyyy-MM-dd}" />
                            <asp:TemplateField HeaderText="الحالة">
                                <ItemTemplate>
                                    <span class="status-badge status-success">نشط</span>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="الإجراءات">
                                <ItemTemplate>
                                    <asp:Button ID="btnEdit" runat="server" Text="تعديل" CssClass="btn btn-primary" CommandName="Edit" />
                                    <asp:Button ID="btnDelete" runat="server" Text="حذف" CssClass="btn btn-danger" CommandName="Delete" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

            <!-- اختبار التبويبات -->
            <div class="test-section">
                <h2 class="section-title">
                    <i class="fas fa-folder-open"></i>
                    اختبار التبويبات والتنقل
                </h2>
                <div class="tabs-container">
                    <div class="tab-buttons">
                        <button type="button" class="tab-button active" onclick="showTab('overview')">نظرة عامة</button>
                        <button type="button" class="tab-button" onclick="showTab('settings')">الإعدادات</button>
                        <button type="button" class="tab-button" onclick="showTab('reports')">التقارير</button>
                        <button type="button" class="tab-button" onclick="showTab('help')">المساعدة</button>
                    </div>
                    
                    <div class="tab-content active" id="overview">
                        <h3>نظرة عامة على النظام</h3>
                        <p>هذا القسم يعرض معلومات عامة عن النظام وحالته الحالية. يمكنك من خلاله متابعة الإحصائيات الأساسية والتحديثات الأخيرة.</p>
                        <div class="status-indicators">
                            <span class="status-badge status-success">النظام يعمل بشكل طبيعي</span>
                            <span class="status-badge status-info">آخر تحديث: اليوم</span>
                            <span class="status-badge status-warning">يوجد تحديثات متاحة</span>
                        </div>
                    </div>
                    
                    <div class="tab-content" id="settings">
                        <h3>إعدادات النظام</h3>
                        <p>تخصيص وإعداد المعايير الأساسية للنظام. يمكنك تغيير الثيمات، اللغة، والتفضيلات الشخصية.</p>
                        <div class="interactive-demo">
                            <div class="demo-item">
                                <i class="fas fa-palette"></i>
                                <p>الثيمات والألوان</p>
                            </div>
                            <div class="demo-item">
                                <i class="fas fa-language"></i>
                                <p>اللغة والترجمة</p>
                            </div>
                            <div class="demo-item">
                                <i class="fas fa-bell"></i>
                                <p>الإشعارات</p>
                            </div>
                        </div>
                    </div>
                    
                    <div class="tab-content" id="reports">
                        <h3>التقارير والتحليلات</h3>
                        <p>تقارير مفصلة وتحليلات شاملة لأداء النظام والعمليات. إمكانية تصدير البيانات بصيغ مختلفة.</p>
                    </div>
                    
                    <div class="tab-content" id="help">
                        <h3>المساعدة والدعم</h3>
                        <p>دليل المستخدم، الأسئلة الشائعة، وطرق التواصل مع فريق الدعم الفني.</p>
                    </div>
                </div>
            </div>

            <!-- اختبار الرسائل -->
            <div class="test-section">
                <h2 class="section-title">
                    <i class="fas fa-exclamation-triangle"></i>
                    اختبار الرسائل والتنبيهات
                </h2>
                <asp:Panel ID="pnlMessages" runat="server">
                    <!-- سيتم ملؤها من الكود -->
                </asp:Panel>
            </div>
        </div>
    </div>

    <script>
        function showTab(tabName) {
            // إخفاء جميع التبويبات
            document.querySelectorAll('.tab-content').forEach(tab => {
                tab.classList.remove('active');
            });
            
            // إزالة التفعيل من جميع الأزرار
            document.querySelectorAll('.tab-button').forEach(btn => {
                btn.classList.remove('active');
            });
            
            // إظهار التبويب المحدد
            document.getElementById(tabName).classList.add('active');
            
            // تفعيل الزر المناسب
            event.target.classList.add('active');
        }

        // تأثيرات بصرية إضافية
        document.addEventListener('DOMContentLoaded', function() {
            // إضافة تأثير hover للبطاقات
            document.querySelectorAll('.test-card').forEach(card => {
                card.addEventListener('mouseenter', function() {
                    this.style.transform = 'translateY(-5px) scale(1.02)';
                });
                
                card.addEventListener('mouseleave', function() {
                    this.style.transform = 'translateY(0) scale(1)';
                });
            });
        });
    </script>
</asp:Content>
