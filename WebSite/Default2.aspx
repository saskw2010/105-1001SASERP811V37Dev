<%@ Page Title="SKYsaas - لوحة التحكم الرئيسية" Language="VB" MasterPageFile="~/LegacyModernMastercSidebar.master" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <!-- Ultra Modern Dashboard Content -->
    <div class="ultra-dashboard" style="animation: fadeInUp 0.8s ease-out;">
        
        <!-- Hero Welcome Section -->
        <div class="hero-welcome glass-card" style="padding: 2.5rem; margin-bottom: 2rem; background: linear-gradient(135deg, rgba(255,255,255,0.95) 0%, rgba(255,255,255,0.8) 100%); backdrop-filter: blur(20px); border-radius: 24px; box-shadow: 0 20px 60px rgba(0,0,0,0.1);">
            <div style="display: flex; align-items: center; justify-content: space-between; flex-wrap: wrap; gap: 2rem;">
                <div style="flex: 1; min-width: 300px;">
                    <h1 style="font-size: 2.5rem; font-weight: 800; background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); -webkit-background-clip: text; -webkit-text-fill-color: transparent; background-clip: text; margin-bottom: 1rem; line-height: 1.2;">
                        مرحباً بك في نظام SKYsaas
                    </h1>
                    <p style="font-size: 1.1rem; color: #64748b; font-weight: 500; line-height: 1.6; margin-bottom: 1.5rem;">
                        نظام إدارة الموارد المؤسسية الأكثر تطوراً في المنطقة
                    </p>
                    <div style="display: flex; gap: 1rem; flex-wrap: wrap;">
                        <button class="btn-gradient" style="background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); border: none; color: white; padding: 0.875rem 2rem; border-radius: 12px; font-weight: 600; font-size: 1rem; cursor: pointer; transition: all 0.3s ease;">
                            <i class="fas fa-rocket" style="margin-left: 0.5rem;"></i>
                            ابدأ الآن
                        </button>
                        <button style="background: rgba(103, 126, 234, 0.1); border: 2px solid #667eea; color: #667eea; padding: 0.875rem 2rem; border-radius: 12px; font-weight: 600; font-size: 1rem; cursor: pointer; transition: all 0.3s ease;">
                            <i class="fas fa-chart-line" style="margin-left: 0.5rem;"></i>
                            عرض التقارير
                        </button>
                    </div>
                </div>
                <div style="flex-shrink: 0;">
                    <div style="width: 120px; height: 120px; background: linear-gradient(135deg, #667eea 0%, #764ba2 100%); border-radius: 24px; display: flex; align-items: center; justify-content: center; box-shadow: 0 20px 40px rgba(102, 126, 234, 0.3); animation: float 3s ease-in-out infinite;">
                        <i class="fas fa-cloud" style="font-size: 3rem; color: white;"></i>
                    </div>
                </div>
            </div>
        </div>

        <!-- Quick Stats Grid -->
        <div style="display: grid; grid-template-columns: repeat(auto-fit, minmax(280px, 1fr)); gap: 1.5rem; margin-bottom: 2rem;">
            
            <!-- HR Stats -->
            <div class="glass-card" style="padding: 2rem; border-radius: 20px; background: rgba(255,255,255,0.9); backdrop-filter: blur(20px); border: 1px solid rgba(255,255,255,0.2); transition: all 0.3s ease; position: relative; overflow: hidden;">
                <div style="position: absolute; top: -50%; right: -50%; width: 100%; height: 100%; background: linear-gradient(135deg, rgba(34, 197, 94, 0.1), rgba(59, 130, 246, 0.1)); border-radius: 50%; z-index: -1;"></div>
                <div style="display: flex; align-items: center; gap: 1.5rem;">
                    <div style="width: 70px; height: 70px; background: linear-gradient(135deg, #34d399, #3b82f6); border-radius: 16px; display: flex; align-items: center; justify-content: center; box-shadow: 0 10px 25px rgba(52, 211, 153, 0.3);">
                        <i class="fas fa-users" style="font-size: 1.8rem; color: white;"></i>
                    </div>
                    <div style="flex: 1;">
                        <h3 style="font-size: 1.125rem; font-weight: 700; color: #1e293b; margin-bottom: 0.5rem;">الموارد البشرية</h3>
                        <p style="color: #64748b; font-size: 0.9rem; margin-bottom: 1rem;">إدارة شاملة للموظفين</p>
                        <div style="font-size: 2rem; font-weight: 800; background: linear-gradient(135deg, #34d399, #3b82f6); -webkit-background-clip: text; -webkit-text-fill-color: transparent;">247</div>
                        <small style="color: #10b981; font-weight: 600;">+12% من الشهر الماضي</small>
                    </div>
                </div>
            </div>

            <!-- Finance Stats -->
            <div class="glass-card" style="padding: 2rem; border-radius: 20px; background: rgba(255,255,255,0.9); backdrop-filter: blur(20px); border: 1px solid rgba(255,255,255,0.2); transition: all 0.3s ease; position: relative; overflow: hidden;">
                <div style="position: absolute; top: -50%; right: -50%; width: 100%; height: 100%; background: linear-gradient(135deg, rgba(249, 115, 22, 0.1), rgba(239, 68, 68, 0.1)); border-radius: 50%; z-index: -1;"></div>
                <div style="display: flex; align-items: center; gap: 1.5rem;">
                    <div style="width: 70px; height: 70px; background: linear-gradient(135deg, #f97316, #ef4444); border-radius: 16px; display: flex; align-items: center; justify-content: center; box-shadow: 0 10px 25px rgba(249, 115, 22, 0.3);">
                        <i class="fas fa-chart-pie" style="font-size: 1.8rem; color: white;"></i>
                    </div>
                    <div style="flex: 1;">
                        <h3 style="font-size: 1.125rem; font-weight: 700; color: #1e293b; margin-bottom: 0.5rem;">المالية والحسابات</h3>
                        <p style="color: #64748b; font-size: 0.9rem; margin-bottom: 1rem;">إدارة مالية متقدمة</p>
                        <div style="font-size: 1.5rem; font-weight: 800; background: linear-gradient(135deg, #f97316, #ef4444); -webkit-background-clip: text; -webkit-text-fill-color: transparent;">52,840 د.ك</div>
                        <small style="color: #10b981; font-weight: 600;">+8.3% نمو شهري</small>
                    </div>
                </div>
            </div>

            <!-- School Stats -->
            <div class="glass-card" style="padding: 2rem; border-radius: 20px; background: rgba(255,255,255,0.9); backdrop-filter: blur(20px); border: 1px solid rgba(255,255,255,0.2); transition: all 0.3s ease; position: relative; overflow: hidden;">
                <div style="position: absolute; top: -50%; right: -50%; width: 100%; height: 100%; background: linear-gradient(135deg, rgba(139, 92, 246, 0.1), rgba(168, 85, 247, 0.1)); border-radius: 50%; z-index: -1;"></div>
                <div style="display: flex; align-items: center; gap: 1.5rem;">
                    <div style="width: 70px; height: 70px; background: linear-gradient(135deg, #8b5cf6, #a855f7); border-radius: 16px; display: flex; align-items: center; justify-content: center; box-shadow: 0 10px 25px rgba(139, 92, 246, 0.3);">
                        <i class="fas fa-graduation-cap" style="font-size: 1.8rem; color: white;"></i>
                    </div>
                    <div style="flex: 1;">
                        <h3 style="font-size: 1.125rem; font-weight: 700; color: #1e293b; margin-bottom: 0.5rem;">إدارة المدارس</h3>
                        <p style="color: #64748b; font-size: 0.9rem; margin-bottom: 1rem;">نظام تعليمي متكامل</p>
                        <div style="font-size: 2rem; font-weight: 800; background: linear-gradient(135deg, #8b5cf6, #a855f7); -webkit-background-clip: text; -webkit-text-fill-color: transparent;">1,234</div>
                        <small style="color: #10b981; font-weight: 600;">طالب مسجل</small>
                    </div>
                </div>
            </div>

            <!-- Inventory Stats -->
            <div class="glass-card" style="padding: 2rem; border-radius: 20px; background: rgba(255,255,255,0.9); backdrop-filter: blur(20px); border: 1px solid rgba(255,255,255,0.2); transition: all 0.3s ease; position: relative; overflow: hidden;">
                <div style="position: absolute; top: -50%; right: -50%; width: 100%; height: 100%; background: linear-gradient(135deg, rgba(6, 182, 212, 0.1), rgba(14, 165, 233, 0.1)); border-radius: 50%; z-index: -1;"></div>
                <div style="display: flex; align-items: center; gap: 1.5rem;">
                    <div style="width: 70px; height: 70px; background: linear-gradient(135deg, #06b6d4, #0ea5e9); border-radius: 16px; display: flex; align-items: center; justify-content: center; box-shadow: 0 10px 25px rgba(6, 182, 212, 0.3);">
                        <i class="fas fa-boxes" style="font-size: 1.8rem; color: white;"></i>
                    </div>
                    <div style="flex: 1;">
                        <h3 style="font-size: 1.125rem; font-weight: 700; color: #1e293b; margin-bottom: 0.5rem;">إدارة المخزون</h3>
                        <p style="color: #64748b; font-size: 0.9rem; margin-bottom: 1rem;">تحكم كامل في المخزون</p>
                        <div style="font-size: 2rem; font-weight: 800; background: linear-gradient(135deg, #06b6d4, #0ea5e9); -webkit-background-clip: text; -webkit-text-fill-color: transparent;">98%</div>
                        <small style="color: #10b981; font-weight: 600;">كفاءة المخزون</small>
                    </div>
                </div>
            </div>
        </div>

        <!-- Quick Actions Section -->
        <div style="display: grid; grid-template-columns: 2fr 1fr; gap: 2rem; margin-bottom: 2rem;">
            
            <!-- Actions Grid -->
            <div class="glass-card" style="padding: 2rem; border-radius: 20px; background: rgba(255,255,255,0.9); backdrop-filter: blur(20px);">
                <h2 style="font-size: 1.5rem; font-weight: 700; color: #1e293b; margin-bottom: 1.5rem; display: flex; align-items: center; gap: 0.75rem;">
                    <div style="width: 40px; height: 40px; background: linear-gradient(135deg, #667eea, #764ba2); border-radius: 10px; display: flex; align-items: center; justify-content: center;">
                        <i class="fas fa-bolt" style="color: white; font-size: 1.1rem;"></i>
                    </div>
                    الإجراءات السريعة
                </h2>
                <div style="display: grid; grid-template-columns: repeat(auto-fit, minmax(250px, 1fr)); gap: 1rem;">
                    
                    <a href="/Pages/PyEmpolyee.aspx" style="text-decoration: none; padding: 1.25rem; border-radius: 16px; background: linear-gradient(135deg, rgba(34, 197, 94, 0.1), rgba(34, 197, 94, 0.05)); border: 2px solid rgba(34, 197, 94, 0.2); transition: all 0.3s ease; display: flex; align-items: center; gap: 1rem; color: inherit;">
                        <div style="width: 50px; height: 50px; background: linear-gradient(135deg, #22c55e, #16a34a); border-radius: 12px; display: flex; align-items: center; justify-content: center;">
                            <i class="fas fa-user-plus" style="color: white; font-size: 1.2rem;"></i>
                        </div>
                        <div>
                            <h4 style="font-weight: 600; color: #1e293b; margin-bottom: 0.25rem;">إضافة موظف</h4>
                            <p style="color: #64748b; font-size: 0.875rem; margin: 0;">تسجيل موظف جديد</p>
                        </div>
                    </a>

                    <a href="/Pages/schApplication.aspx" style="text-decoration: none; padding: 1.25rem; border-radius: 16px; background: linear-gradient(135deg, rgba(59, 130, 246, 0.1), rgba(59, 130, 246, 0.05)); border: 2px solid rgba(59, 130, 246, 0.2); transition: all 0.3s ease; display: flex; align-items: center; gap: 1rem; color: inherit;">
                        <div style="width: 50px; height: 50px; background: linear-gradient(135deg, #3b82f6, #2563eb); border-radius: 12px; display: flex; align-items: center; justify-content: center;">
                            <i class="fas fa-graduation-cap" style="color: white; font-size: 1.2rem;"></i>
                        </div>
                        <div>
                            <h4 style="font-weight: 600; color: #1e293b; margin-bottom: 0.25rem;">تسجيل طالب</h4>
                            <p style="color: #64748b; font-size: 0.875rem; margin: 0;">طالب جديد بالمدرسة</p>
                        </div>
                    </a>

                    <a href="/Pages/ReciptVoucher1.aspx" style="text-decoration: none; padding: 1.25rem; border-radius: 16px; background: linear-gradient(135deg, rgba(168, 85, 247, 0.1), rgba(168, 85, 247, 0.05)); border: 2px solid rgba(168, 85, 247, 0.2); transition: all 0.3s ease; display: flex; align-items: center; gap: 1rem; color: inherit;">
                        <div style="width: 50px; height: 50px; background: linear-gradient(135deg, #a855f7, #9333ea); border-radius: 12px; display: flex; align-items: center; justify-content: center;">
                            <i class="fas fa-receipt" style="color: white; font-size: 1.2rem;"></i>
                        </div>
                        <div>
                            <h4 style="font-weight: 600; color: #1e293b; margin-bottom: 0.25rem;">إصدار فاتورة</h4>
                            <p style="color: #64748b; font-size: 0.875rem; margin: 0;">سند قبض جديد</p>
                        </div>
                    </a>

                    <a href="/Pages/GLjrnvchhdr.aspx" style="text-decoration: none; padding: 1.25rem; border-radius: 16px; background: linear-gradient(135deg, rgba(245, 101, 101, 0.1), rgba(245, 101, 101, 0.05)); border: 2px solid rgba(245, 101, 101, 0.2); transition: all 0.3s ease; display: flex; align-items: center; gap: 1rem; color: inherit;">
                        <div style="width: 50px; height: 50px; background: linear-gradient(135deg, #f56565, #e53e3e); border-radius: 12px; display: flex; align-items: center; justify-content: center;">
                            <i class="fas fa-file-invoice" style="color: white; font-size: 1.2rem;"></i>
                        </div>
                        <div>
                            <h4 style="font-weight: 600; color: #1e293b; margin-bottom: 0.25rem;">قيد يومية</h4>
                            <p style="color: #64748b; font-size: 0.875rem; margin: 0;">إدخال قيد محاسبي</p>
                        </div>
                    </a>
                </div>
            </div>

            <!-- Recent Activity -->
            <div class="glass-card" style="padding: 2rem; border-radius: 20px; background: rgba(255,255,255,0.9); backdrop-filter: blur(20px);">
                <h2 style="font-size: 1.25rem; font-weight: 700; color: #1e293b; margin-bottom: 1.5rem; display: flex; align-items: center; gap: 0.75rem;">
                    <div style="width: 40px; height: 40px; background: linear-gradient(135deg, #06b6d4, #0ea5e9); border-radius: 10px; display: flex; align-items: center; justify-content: center;">
                        <i class="fas fa-bell" style="color: white; font-size: 1.1rem;"></i>
                    </div>
                    الإشعارات
                </h2>
                <div style="display: flex; flex-direction: column; gap: 1rem;">
                    
                    <div style="padding: 1rem; border-radius: 12px; background: rgba(34, 197, 94, 0.1); border-left: 4px solid #22c55e;">
                        <h4 style="font-weight: 600; color: #16a34a; margin-bottom: 0.5rem; font-size: 0.875rem;">تم اعتماد الرواتب</h4>
                        <p style="color: #64748b; font-size: 0.8rem; margin: 0;">رواتب شهر ديسمبر 2024</p>
                        <small style="color: #94a3b8; font-size: 0.75rem;">اليوم 14:30</small>
                    </div>

                    <div style="padding: 1rem; border-radius: 12px; background: rgba(245, 158, 11, 0.1); border-left: 4px solid #f59e0b;">
                        <h4 style="font-weight: 600; color: #d97706; margin-bottom: 0.5rem; font-size: 0.875rem;">تنبيه مخزون</h4>
                        <p style="color: #64748b; font-size: 0.8rem; margin: 0;">5 أصناف تحتاج إعادة طلب</p>
                        <small style="color: #94a3b8; font-size: 0.75rem;">منذ ساعتين</small>
                    </div>

                    <div style="padding: 1rem; border-radius: 12px; background: rgba(59, 130, 246, 0.1); border-left: 4px solid #3b82f6;">
                        <h4 style="font-weight: 600; color: #2563eb; margin-bottom: 0.5rem; font-size: 0.875rem;">تحديث النظام</h4>
                        <p style="color: #64748b; font-size: 0.8rem; margin: 0;">إصدار جديد متاح</p>
                        <small style="color: #94a3b8; font-size: 0.75rem;">أمس 09:15</small>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Advanced Animations and Interactions -->
    <style>
        @keyframes float {
            0%, 100% { transform: translateY(0px); }
            50% { transform: translateY(-10px); }
        }

        @keyframes fadeInUp {
            from {
                opacity: 0;
                transform: translateY(30px);
            }
            to {
                opacity: 1;
                transform: translateY(0);
            }
        }

        .glass-card:hover {
            transform: translateY(-8px) scale(1.02);
            box-shadow: 0 30px 80px rgba(0,0,0,0.15);
        }

        .btn-gradient:hover {
            transform: translateY(-2px) scale(1.05);
            box-shadow: 0 15px 35px rgba(102, 126, 234, 0.4);
        }

        .ultra-dashboard a:hover {
            transform: translateY(-4px) scale(1.02);
            box-shadow: 0 15px 35px rgba(0,0,0,0.1);
        }

        /* Responsive Design */
        @media (max-width: 768px) {
            .ultra-dashboard {
                padding: 0;
            }
            
            .hero-welcome {
                padding: 1.5rem !important;
                margin-bottom: 1.5rem !important;
            }
            
            .hero-welcome h1 {
                font-size: 2rem !important;
            }
            
            .hero-welcome div[style*="grid-template-columns"] {
                grid-template-columns: 1fr !important;
                gap: 1rem !important;
            }
        }
    </style>

    <!-- Interactive JavaScript -->
    <script>
        document.addEventListener('DOMContentLoaded', function() {
            // Add hover effects to cards
            const cards = document.querySelectorAll('.glass-card');
            cards.forEach(card => {
                card.addEventListener('mouseenter', function() {
                    this.style.transform = 'translateY(-8px) scale(1.02)';
                });
                
                card.addEventListener('mouseleave', function() {
                    this.style.transform = 'translateY(0) scale(1)';
                });
            });

            // Button interactions
            const buttons = document.querySelectorAll('.btn-gradient');
            buttons.forEach(btn => {
                btn.addEventListener('click', function(e) {
                    // Create ripple effect
                    const ripple = document.createElement('span');
                    const rect = this.getBoundingClientRect();
                    const size = Math.max(rect.width, rect.height);
                    const x = e.clientX - rect.left - size / 2;
                    const y = e.clientY - rect.top - size / 2;
                    
                    ripple.style.cssText = `
                        width: ${size}px;
                        height: ${size}px;
                        left: ${x}px;
                        top: ${y}px;
                        position: absolute;
                        border-radius: 50%;
                        background: rgba(255,255,255,0.3);
                        transform: scale(0);
                        animation: ripple 0.6s linear;
                        pointer-events: none;
                    `;
                    
                    this.appendChild(ripple);
                    setTimeout(() => ripple.remove(), 600);
                });
            });

            // Add staggered animation to stats cards
            const statsCards = document.querySelectorAll('[style*="grid-template-columns: repeat(auto-fit, minmax(280px, 1fr))"] .glass-card');
            statsCards.forEach((card, index) => {
                card.style.animationDelay = `${index * 0.1}s`;
                card.style.animation = 'fadeInUp 0.8s ease-out forwards';
            });

            console.log('🚀 Ultra Modern Dashboard Initialized!');
        });

        // Add ripple animation
        const style = document.createElement('style');
        style.textContent = `
            @keyframes ripple {
                to {
                    transform: scale(4);
                    opacity: 0;
                }
            }
        `;
        document.head.appendChild(style);
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="PageTitleContentPlaceHolder" Runat="Server">
    لوحة التحكم الرئيسية - SKYsaas
</asp:Content>


