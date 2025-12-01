<%@ Page Title="تسجيل الدخول - اختبار الأدوار" Language="VB" MasterPageFile="~/Main.master" CodeFile="TestLogin.aspx.vb" Inherits="TestLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .login-test-container {
            max-width: 800px;
            margin: 2rem auto;
            padding: 2rem;
            background: linear-gradient(135deg, #f8fafc 0%, #e2e8f0 100%);
            border-radius: 20px;
            box-shadow: 0 20px 40px rgba(0,0,0,0.1);
        }

        .login-header {
            text-align: center;
            margin-bottom: 3rem;
        }

        .login-title {
            font-size: 2.5rem;
            font-weight: 700;
            color: #1e293b;
            margin-bottom: 1rem;
        }

        .login-subtitle {
            color: #64748b;
            font-size: 1.1rem;
        }

        .test-users-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 2rem;
            margin-bottom: 3rem;
        }

        .user-card {
            background: white;
            border-radius: 16px;
            padding: 2rem;
            box-shadow: 0 8px 24px rgba(0,0,0,0.1);
            transition: all 0.3s ease;
            border: 2px solid transparent;
        }

        .user-card:hover {
            transform: translateY(-5px);
            border-color: #3b82f6;
            box-shadow: 0 20px 40px rgba(59, 130, 246, 0.15);
        }

        .user-icon {
            width: 60px;
            height: 60px;
            background: linear-gradient(135deg, #3b82f6, #2563eb);
            border-radius: 12px;
            display: flex;
            align-items: center;
            justify-content: center;
            margin: 0 auto 1rem;
            color: white;
            font-size: 1.5rem;
        }

        .user-name {
            font-size: 1.3rem;
            font-weight: 600;
            color: #1e293b;
            margin-bottom: 0.5rem;
            text-align: center;
        }

        .user-roles {
            background: #f1f5f9;
            border-radius: 8px;
            padding: 0.75rem;
            margin-bottom: 1rem;
            font-size: 0.9rem;
            color: #475569;
        }

        .role-badge {
            display: inline-block;
            background: linear-gradient(135deg, #10b981, #06d6a0);
            color: white;
            padding: 0.25rem 0.75rem;
            border-radius: 20px;
            font-size: 0.8rem;
            margin: 0.25rem;
        }

        .login-btn {
            width: 100%;
            padding: 0.75rem 1.5rem;
            background: linear-gradient(135deg, #3b82f6, #2563eb);
            color: white;
            border: none;
            border-radius: 8px;
            font-weight: 500;
            cursor: pointer;
            transition: all 0.3s ease;
            display: flex;
            align-items: center;
            justify-content: center;
            gap: 0.5rem;
        }

        .login-btn:hover {
            background: linear-gradient(135deg, #2563eb, #1d4ed8);
            transform: translateY(-2px);
        }

        .current-user-info {
            background: white;
            border-radius: 16px;
            padding: 2rem;
            box-shadow: 0 8px 24px rgba(0,0,0,0.1);
            border-left: 4px solid #10b981;
        }

        .current-user-header {
            display: flex;
            align-items: center;
            gap: 1rem;
            margin-bottom: 1rem;
        }

        .current-user-avatar {
            width: 50px;
            height: 50px;
            background: linear-gradient(135deg, #10b981, #06d6a0);
            border-radius: 12px;
            display: flex;
            align-items: center;
            justify-content: center;
            color: white;
            font-size: 1.2rem;
        }

        .current-user-details h3 {
            margin: 0 0 0.25rem 0;
            color: #1e293b;
        }

        .current-user-details p {
            margin: 0;
            color: #64748b;
            font-size: 0.9rem;
        }

        .logout-btn {
            background: linear-gradient(135deg, #ef4444, #dc2626);
            color: white;
            border: none;
            padding: 0.75rem 1.5rem;
            border-radius: 8px;
            cursor: pointer;
            font-weight: 500;
            transition: all 0.3s ease;
            margin-top: 1rem;
        }

        .logout-btn:hover {
            background: linear-gradient(135deg, #dc2626, #b91c1c);
            transform: translateY(-2px);
        }

        .test-actions {
            background: white;
            border-radius: 16px;
            padding: 2rem;
            box-shadow: 0 8px 24px rgba(0,0,0,0.1);
            margin-top: 2rem;
        }

        .test-actions h3 {
            color: #1e293b;
            margin-bottom: 1rem;
        }

        .test-buttons {
            display: flex;
            gap: 1rem;
            flex-wrap: wrap;
        }

        .test-btn {
            padding: 0.75rem 1.5rem;
            border: none;
            border-radius: 8px;
            cursor: pointer;
            font-weight: 500;
            transition: all 0.3s ease;
            text-decoration: none;
            display: inline-flex;
            align-items: center;
            gap: 0.5rem;
        }

        .test-btn-primary {
            background: linear-gradient(135deg, #8b5cf6, #7c3aed);
            color: white;
        }

        .test-btn-secondary {
            background: linear-gradient(135deg, #6b7280, #4b5563);
            color: white;
        }

        .test-btn:hover {
            transform: translateY(-2px);
            text-decoration: none;
            color: white;
        }

        @media (max-width: 768px) {
            .test-users-grid {
                grid-template-columns: 1fr;
            }
            
            .test-buttons {
                flex-direction: column;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="server">
    <div class="login-test-container">
        <div class="login-header">
            <h1 class="login-title">
                <i class="fas fa-user-shield"></i>
                اختبار نظام الأدوار والصلاحيات
            </h1>
            <p class="login-subtitle">
                اختر مستخدم للدخول واختبار الصلاحيات المختلفة
            </p>
        </div>

        <!-- معلومات المستخدم الحالي -->
        <div id="currentUserSection" class="current-user-info" style="display: none;">
            <div class="current-user-header">
                <div class="current-user-avatar">
                    <i class="fas fa-user"></i>
                </div>
                <div class="current-user-details">
                    <h3 id="currentUserName">—</h3>
                    <p id="currentUserRoles">—</p>
                </div>
            </div>
            <button type="button" class="logout-btn" onclick="testLogout()">
                <i class="fas fa-sign-out-alt"></i>
                تسجيل خروج
            </button>
        </div>

        <!-- قائمة المستخدمين للاختبار -->
        <div id="testUsersSection" class="test-users-grid">
            <div class="user-card">
                <div class="user-icon">
                    <i class="fas fa-crown"></i>
                </div>
                <h3 class="user-name">أحمد المدير</h3>
                <div class="user-roles">
                    <strong>الأدوار:</strong><br>
                    <span class="role-badge">Admin</span>
                    <span class="role-badge">HR</span>
                    <span class="role-badge">Accounting</span>
                    <span class="role-badge">Public</span>
                </div>
                <button type="button" class="login-btn" onclick="testLogin('admin')">
                    <i class="fas fa-sign-in-alt"></i>
                    دخول كمدير
                </button>
            </div>

            <div class="user-card">
                <div class="user-icon">
                    <i class="fas fa-users"></i>
                </div>
                <h3 class="user-name">فاطمة محمد</h3>
                <div class="user-roles">
                    <strong>الأدوار:</strong><br>
                    <span class="role-badge">HR</span>
                    <span class="role-badge">Public</span>
                </div>
                <button type="button" class="login-btn" onclick="testLogin('hr')">
                    <i class="fas fa-sign-in-alt"></i>
                    دخول كموارد بشرية
                </button>
            </div>

            <div class="user-card">
                <div class="user-icon">
                    <i class="fas fa-calculator"></i>
                </div>
                <h3 class="user-name">محمد أحمد</h3>
                <div class="user-roles">
                    <strong>الأدوار:</strong><br>
                    <span class="role-badge">Accounting</span>
                    <span class="role-badge">Public</span>
                </div>
                <button type="button" class="login-btn" onclick="testLogin('accountant')">
                    <i class="fas fa-sign-in-alt"></i>
                    دخول كمحاسب
                </button>
            </div>

            <div class="user-card">
                <div class="user-icon">
                    <i class="fas fa-chalkboard-teacher"></i>
                </div>
                <h3 class="user-name">نور الهدى</h3>
                <div class="user-roles">
                    <strong>الأدوار:</strong><br>
                    <span class="role-badge">Public</span>
                </div>
                <button type="button" class="login-btn" onclick="testLogin('teacher')">
                    <i class="fas fa-sign-in-alt"></i>
                    دخول كمدرسة
                </button>
            </div>
        </div>

        <!-- إجراءات الاختبار -->
        <div class="test-actions">
            <h3>
                <i class="fas fa-flask"></i>
                إجراءات الاختبار
            </h3>
            <div class="test-buttons">
                <a href="/Pages/Home.aspx" class="test-btn test-btn-primary">
                    <i class="fas fa-home"></i>
                    الذهاب للصفحة الرئيسية
                </a>
                <a href="/ModernTestPage.aspx" class="test-btn test-btn-secondary">
                    <i class="fas fa-vial"></i>
                    صفحة الاختبار الشاملة
                </a>
                <button type="button" class="test-btn test-btn-secondary" onclick="checkCurrentUser()">
                    <i class="fas fa-info-circle"></i>
                    فحص المستخدم الحالي
                </button>
                <button type="button" class="test-btn test-btn-secondary" onclick="clearAllData()">
                    <i class="fas fa-trash"></i>
                    مسح جميع البيانات
                </button>
            </div>
        </div>
    </div>

    <script>
        // تحديث واجهة المستخدم عند تحميل الصفحة
        document.addEventListener('DOMContentLoaded', function() {
            updateUserInterface();
            
            // مراقبة تغييرات localStorage
            window.addEventListener('storage', updateUserInterface);
        });

        function testLogin(username) {
            console.log('🔑 Attempting login for:', username);
            
            if (window.userLogin && window.userLogin(username, 'password')) {
                showNotification('تم تسجيل الدخول بنجاح!', 'success');
                updateUserInterface();
                
                // تحديث Dashboard بعد ثانيتين
                setTimeout(() => {
                    if (window.userManager) {
                        window.userManager.applyRoleBasedAccess();
                    }
                }, 2000);
            } else {
                showNotification('فشل في تسجيل الدخول!', 'error');
            }
        }

        function testLogout() {
            console.log('🚪 Attempting logout');
            
            if (window.userLogout) {
                window.userLogout();
                showNotification('تم تسجيل الخروج بنجاح!', 'info');
                updateUserInterface();
            }
        }

        function updateUserInterface() {
            const currentUser = window.getCurrentUser ? window.getCurrentUser() : null;
            const userRoles = window.userManager ? window.userManager.getUserRoles() : [];
            
            const currentUserSection = document.getElementById('currentUserSection');
            const testUsersSection = document.getElementById('testUsersSection');
            
            if (currentUser && currentUser.id !== 'guest') {
                // إظهار معلومات المستخدم الحالي
                currentUserSection.style.display = 'block';
                testUsersSection.style.display = 'none';
                
                document.getElementById('currentUserName').textContent = currentUser.name;
                document.getElementById('currentUserRoles').textContent = 
                    `القسم: ${currentUser.department} | الأدوار: ${userRoles.join(', ')}`;
            } else {
                // إظهار قائمة المستخدمين للاختبار
                currentUserSection.style.display = 'none';
                testUsersSection.style.display = 'grid';
            }
        }

        function checkCurrentUser() {
            const currentUser = window.getCurrentUser ? window.getCurrentUser() : null;
            const userRoles = window.userManager ? window.userManager.getUserRoles() : [];
            
            const info = `
المستخدم الحالي: ${currentUser?.name || 'غير محدد'}
البريد الإلكتروني: ${currentUser?.email || 'غير محدد'}
القسم: ${currentUser?.department || 'غير محدد'}
الأدوار: ${userRoles.join(', ') || 'لا توجد أدوار'}
            `;
            
            alert(info);
            console.log('👤 Current User Info:', { currentUser, userRoles });
        }

        function clearAllData() {
            if (confirm('هل أنت متأكد من مسح جميع بيانات الجلسة؟')) {
                localStorage.clear();
                showNotification('تم مسح جميع البيانات بنجاح!', 'info');
                updateUserInterface();
                
                // إعادة تحميل الصفحة لإعادة التهيئة
                setTimeout(() => {
                    location.reload();
                }, 1000);
            }
        }

        // التأكد من تحميل نظام User Roles
        if (!window.userManager) {
            console.warn('⚠️ User Roles Manager not loaded yet, retrying...');
            setTimeout(() => {
                updateUserInterface();
            }, 1000);
        }
    </script>
</asp:Content>
