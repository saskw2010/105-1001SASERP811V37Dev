<%@ Page Language="VB" AutoEventWireup="true" CodeFile="NewsManager.aspx.vb" Inherits="Pages_NewsManager" %>
<%@ Register Src="~/Controls/NewsPanel.ascx" TagPrefix="uc" TagName="NewsPanel" %>

<!DOCTYPE html>
<html lang="ar" dir="rtl">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>إدارة الأخبار - WYTSKY</title>
    
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet">
    <!-- Font Awesome -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css" rel="stylesheet" />
    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css2?family=Cairo:wght@300;400;500;600;700&display=swap" rel="stylesheet">
    
    <style>
        body {
            font-family: 'Cairo', sans-serif;
            background-color: #f8f9fa;
            direction: rtl;
        }
        
        .navbar-brand {
            font-weight: 700;
            color: #1a237e !important;
        }
        
        .card {
            border: none;
            border-radius: 15px;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
        }
        
        .card-header {
            background: linear-gradient(135deg, #1a237e, #2962ff);
            color: #f8f9fa;
            border-radius: 15px 15px 0 0 !important;
            padding: 1.5rem;
        }
        
        .btn-primary {
            background: linear-gradient(135deg, #1a237e, #2962ff);
            border: none;
            border-radius: 10px;
            padding: 0.75rem 1.5rem;
            font-weight: 500;
        }
        
        .btn-primary:hover {
            background: linear-gradient(135deg, #0d47a1, #1a237e);
            transform: translateY(-1px);
        }
        
        .form-control, .form-select {
            border-radius: 10px;
            border: 2px solid #e0e0e0;
            padding: 0.75rem;
        }
        
        .form-control:focus, .form-select:focus {
            border-color: #2962ff;
            box-shadow: 0 0 0 3px rgba(41, 98, 255, 0.1);
        }
        
        .news-preview {
            background-color: white;
            border-radius: 15px;
            padding: 2rem;
            margin-top: 2rem;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
        }
        
        .alert {
            border-radius: 10px;
            border: none;
        }
        
        .table {
            border-radius: 15px;
            overflow: hidden;
            box-shadow: 0 4px 6px rgba(0,0,0,0.1);
        }
        
        .table th {
            background-color: #1a237e;
            color: white;
            font-weight: 600;
            padding: 1rem;
        }
        
        .badge {
            padding: 0.5rem 1rem;
            border-radius: 20px;
            font-weight: 500;
        }
        
        .action-buttons .btn {
            margin: 0 0.25rem;
            border-radius: 8px;
        }
        
        .news-item-footer {
            font-size: 0.8rem;
            color: #f8f9fa;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Navigation -->
        <nav class="navbar navbar-expand-lg navbar-light bg-white shadow-sm">
            <div class="container">
                <a class="navbar-brand" href="#">
                    <i class="fas fa-newspaper me-2"></i>
                    نظام إدارة الأخبار - WYTSKY
                </a>
                <div class="navbar-nav ms-auto">
                    <a class="nav-link" href="../Login.aspx">
                        <i class="fas fa-home me-1"></i>
                        الصفحة الرئيسية
                    </a>
                </div>
            </div>
        </nav>

        <div class="container my-5">
            <!-- Success/Error Messages -->
            <asp:Panel ID="pnlMessage" runat="server" Visible="false">
                <div class="alert alert-success alert-dismissible fade show" role="alert">
                    <asp:Literal ID="litMessage" runat="server"></asp:Literal>
                    <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
                </div>
            </asp:Panel>

            <asp:Panel ID="pnlError" runat="server" Visible="false">
                <div class="alert alert-danger alert-dismissible fade show" role="alert">
                    <asp:Literal ID="litError" runat="server"></asp:Literal>
                    <button type="button" class="btn-close" data-bs-dismiss="alert"></button>
                </div>
            </asp:Panel>

            <div class="row">
                <!-- Add/Edit News Form -->
                <div class="col-lg-6">
                    <div class="card">
                        <div class="card-header">
                            <h4 class="mb-0">
                                <i class="fas fa-plus-circle me-2"></i>
                                <asp:Literal ID="litFormTitle" runat="server" Text="إضافة خبر جديد"></asp:Literal>
                            </h4>
                        </div>
                        <div class="card-body">
                            <div class="mb-3">
                                <label for="txtTitle" class="form-label">عنوان الخبر *</label>
                                <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control" 
                                    placeholder="اكتب عنوان الخبر هنا..." MaxLength="200" required></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <label for="txtSummary" class="form-label">ملخص مختصر</label>
                                <asp:TextBox ID="txtSummary" runat="server" CssClass="form-control" 
                                    TextMode="MultiLine" Rows="2" MaxLength="500"
                                    placeholder="ملخص مختصر للخبر (اختياري)..."></asp:TextBox>
                            </div>

                            <div class="mb-3">
                                <label for="txtContent" class="form-label">محتوى الخبر *</label>
                                <asp:TextBox ID="txtContent" runat="server" CssClass="form-control" 
                                    TextMode="MultiLine" Rows="6" 
                                    placeholder="اكتب محتوى الخبر بالتفصيل..." required></asp:TextBox>
                            </div>

                            <div class="row">
                                <div class="col-md-6">
                                    <div class="mb-3">
                                        <label for="ddlTag" class="form-label">تصنيف الخبر</label>
                                        <asp:DropDownList ID="ddlTag" runat="server" CssClass="form-select">
                                            <asp:ListItem Value="" Text="-- اختر التصنيف --"></asp:ListItem>
                                            <asp:ListItem Value="تحديث النظام" Text="تحديث النظام"></asp:ListItem>
                                            <asp:ListItem Value="الأمان" Text="الأمان"></asp:ListItem>
                                            <asp:ListItem Value="التدريب" Text="التدريب"></asp:ListItem>
                                            <asp:ListItem Value="التطبيق" Text="التطبيق"></asp:ListItem>
                                            <asp:ListItem Value="الشراكات" Text="الشراكات"></asp:ListItem>
                                            <asp:ListItem Value="خدمة العملاء" Text="خدمة العملاء"></asp:ListItem>
                                            <asp:ListItem Value="المميزات" Text="المميزات"></asp:ListItem>
                                            <asp:ListItem Value="الأداء" Text="الأداء"></asp:ListItem>
                                            <asp:ListItem Value="عام" Text="عام"></asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-md-6">
                                    <div class="mb-3">
                                        <label for="txtPriority" class="form-label">الأولوية</label>
                                        <asp:TextBox ID="txtPriority" runat="server" CssClass="form-control" 
                                            TextMode="Number" Text="0" Min="0" Max="100"></asp:TextBox>
                                        <div class="form-text">0 = أعلى أولوية، 100 = أقل أولوية</div>
                                    </div>
                                </div>
                            </div>

                            <div class="mb-3">
                                <label for="txtReadMoreUrl" class="form-label">رابط التفاصيل</label>
                                <asp:TextBox ID="txtReadMoreUrl" runat="server" CssClass="form-control" 
                                    placeholder="~/Pages/NewsDetails.aspx?id=1 أو # للعدم"></asp:TextBox>
                            </div>

                            <div class="d-grid">
                                <asp:Button ID="btnSave" runat="server" Text="حفظ الخبر" 
                                    CssClass="btn btn-primary btn-lg" OnClick="btnSave_Click" />
                            </div>

                            <asp:Panel ID="pnlEditButtons" runat="server" Visible="false">
                                <div class="d-grid gap-2 mt-2">
                                    <asp:Button ID="btnUpdate" runat="server" Text="تحديث الخبر" 
                                        CssClass="btn btn-warning" OnClick="btnUpdate_Click" />
                                    <asp:Button ID="btnCancel" runat="server" Text="إلغاء التعديل" 
                                        CssClass="btn btn-secondary" OnClick="btnCancel_Click" />
                                </div>
                            </asp:Panel>
                        </div>
                    </div>
                </div>

                <!-- News Preview -->
                <div class="col-lg-6">
                    <uc:NewsPanel ID="ucNewsPreview" runat="server" 
                        MaxNewsItems="3" 
                        ShowLoadMore="false"
                        NewsTitle="معاينة الأخبار"
                        NewsSubtitle="آخر الأخبار المضافة" />
                </div>
            </div>

            <!-- News Management Table -->
            <div class="row mt-5">
                <div class="col-12">
                    <div class="card">
                        <div class="card-header">
                            <h4 class="mb-0">
                                <i class="fas fa-list me-2"></i>
                                إدارة الأخبار المحفوظة
                            </h4>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">
                                <asp:GridView ID="gvNews" runat="server" AutoGenerateColumns="false" 
                                    CssClass="table table-hover" DataKeyNames="ID"
                                    OnRowCommand="gvNews_RowCommand" OnRowDataBound="gvNews_RowDataBound">
                                    <Columns>
                                        <asp:BoundField DataField="ID" HeaderText="الرقم" ItemStyle-Width="60px" />
                                        <asp:BoundField DataField="Title" HeaderText="العنوان" ItemStyle-Width="250px" />
                                        <asp:BoundField DataField="Tag" HeaderText="التصنيف" ItemStyle-Width="100px" />
                                        <asp:BoundField DataField="Date" HeaderText="التاريخ" DataFormatString="{0:dd/MM/yyyy}" ItemStyle-Width="100px" />
                                        <asp:BoundField DataField="Priority" HeaderText="الأولوية" ItemStyle-Width="80px" />
                                        <asp:TemplateField HeaderText="الحالة" ItemStyle-Width="80px">
                                            <ItemTemplate>
                                                <span class="badge bg-success" runat="server" visible='<%# CBool(Eval("IsActive")) %>'>نشط</span>
                                                <span class="badge bg-secondary" runat="server" visible='<%# Not CBool(Eval("IsActive")) %>'>غير نشط</span>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="الإجراءات" ItemStyle-Width="200px">
                                            <ItemTemplate>
                                                <div class="action-buttons">
                                                    <asp:Button ID="btnEdit" runat="server" Text="تعديل" 
                                                        CssClass="btn btn-sm btn-outline-primary" 
                                                        CommandName="EditNews" CommandArgument='<%# Eval("ID") %>' />
                                                    <asp:Button ID="btnToggle" runat="server" 
                                                        Text='<%# If(CBool(Eval("IsActive")), "إخفاء", "إظهار") %>'
                                                        CssClass='<%# If(CBool(Eval("IsActive")), "btn btn-sm btn-outline-warning", "btn btn-sm btn-outline-success") %>'
                                                        CommandName="ToggleActive" CommandArgument='<%# Eval("ID") %>' />
                                                    <asp:Button ID="btnDelete" runat="server" Text="حذف" 
                                                        CssClass="btn btn-sm btn-outline-danger" 
                                                        CommandName="DeleteNews" CommandArgument='<%# Eval("ID") %>'
                                                        OnClientClick="return confirm('هل أنت متأكد من حذف هذا الخبر؟');" />
                                                </div>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <EmptyDataTemplate>
                                        <div class="text-center py-4">
                                            <i class="fas fa-inbox fa-3x text-muted mb-3"></i>
                                            <h5 class="text-muted">لا توجد أخبار محفوظة</h5>
                                            <p class="text-muted">ابدأ بإضافة خبر جديد من النموذج أعلاه</p>
                                        </div>
                                    </EmptyDataTemplate>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>

    <!-- Bootstrap JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    
    <script>
        // Auto-hide alerts after 5 seconds
        setTimeout(function() {
            var alerts = document.querySelectorAll('.alert');
            alerts.forEach(function(alert) {
                var bootstrapAlert = new bootstrap.Alert(alert);
                bootstrapAlert.close();
            });
        }, 5000);
    </script>
</body>
</html>
