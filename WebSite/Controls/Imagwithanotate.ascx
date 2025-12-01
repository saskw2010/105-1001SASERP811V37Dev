<%@ Control Language="vb" AutoEventWireup="false" CodeFile="Imagwithanotate.ascx.vb" Inherits="Imagwithanotate" %>
<%@ Register src="SimpleControl.ascx" tagname="SimpleControl" tagprefix="uc1" %>

<!-- Modern Image Annotation Control -->
<div class="modern-image-annotation">
    <!-- Modern CSS Framework -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" rel="stylesheet">
    
    <style>
        .modern-image-annotation {
            --primary-color: #1976d2;
            --secondary-color: #424242;
            --accent-color: #ff5722;
            --success-color: #4caf50;
            --surface-color: #ffffff;
            --background-color: #f5f5f5;
            --text-primary: #212121;
            --text-secondary: #757575;
            --border-radius: 12px;
            --elevation-1: 0 2px 4px rgba(0,0,0,0.1);
            --elevation-2: 0 4px 8px rgba(0,0,0,0.12);
            --transition-fast: 0.2s cubic-bezier(0.4, 0, 0.2, 1);
            --transition-standard: 0.3s cubic-bezier(0.4, 0, 0.2, 1);
        }

        .annotation-container {
            background: var(--surface-color);
            border-radius: var(--border-radius);
            box-shadow: var(--elevation-1);
            overflow: hidden;
            margin: 16px 0;
            transition: var(--transition-standard);
        }

        .annotation-container:hover {
            box-shadow: var(--elevation-2);
            transform: translateY(-2px);
        }

        .annotation-header {
            background: linear-gradient(135deg, var(--primary-color), #1565c0);
            color: white;
            padding: 20px;
            display: flex;
            align-items: center;
            gap: 12px;
        }

        .annotation-title {
            font-size: 20px;
            font-weight: 500;
            margin: 0;
        }

        .annotation-tabs {
            background: #f8f9fa;
            border-bottom: 1px solid #dee2e6;
            padding: 16px 20px;
            display: flex;
            gap: 16px;
            flex-wrap: wrap;
        }

        .tab-button {
            background: var(--surface-color);
            border: 2px solid #e0e0e0;
            border-radius: 8px;
            padding: 12px 20px;
            text-decoration: none;
            color: var(--text-primary);
            font-weight: 500;
            transition: var(--transition-fast);
            display: flex;
            align-items: center;
            gap: 8px;
            cursor: pointer;
        }

        .tab-button:hover {
            border-color: var(--primary-color);
            background: rgba(25, 118, 210, 0.04);
            color: var(--primary-color);
            text-decoration: none;
            transform: translateY(-1px);
        }

        .tab-button.active {
            background: var(--primary-color);
            border-color: var(--primary-color);
            color: white;
        }

        .annotation-content {
            padding: 24px;
        }

        .image-display-area {
            background: #f8f9fa;
            border: 2px dashed #dee2e6;
            border-radius: var(--border-radius);
            padding: 40px;
            text-align: center;
            margin-bottom: 24px;
            position: relative;
            min-height: 200px;
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            gap: 16px;
        }

        .image-placeholder {
            width: 80px;
            height: 80px;
            background: var(--primary-color);
            border-radius: 50%;
            display: flex;
            align-items: center;
            justify-content: center;
            color: white;
            font-size: 32px;
            margin-bottom: 16px;
        }

        .image-controls {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 20px;
            margin-bottom: 24px;
        }

        .control-group {
            background: #f8f9fa;
            border-radius: var(--border-radius);
            padding: 20px;
            border: 1px solid #e0e0e0;
        }

        .control-label {
            font-size: 14px;
            font-weight: 600;
            color: var(--text-primary);
            margin-bottom: 8px;
            display: flex;
            align-items: center;
            gap: 8px;
        }

        .modern-textbox {
            width: 100%;
            padding: 12px 16px;
            border: 2px solid #e0e0e0;
            border-radius: 8px;
            font-size: 16px;
            transition: var(--transition-fast);
            background: var(--surface-color);
        }

        .modern-textbox:focus {
            outline: none;
            border-color: var(--primary-color);
            box-shadow: 0 0 0 3px rgba(25, 118, 210, 0.1);
        }

        .timer-display {
            background: linear-gradient(135deg, #e8f5e8, #c8e6c9);
            border: 1px solid var(--success-color);
            border-radius: var(--border-radius);
            padding: 16px;
            text-align: center;
            margin: 16px 0;
        }

        .timer-text {
            font-size: 18px;
            font-weight: 500;
            color: var(--success-color);
            display: flex;
            align-items: center;
            justify-content: center;
            gap: 8px;
        }

        .content-panel {
            background: var(--surface-color);
            border: 1px solid #e0e0e0;
            border-radius: var(--border-radius);
            padding: 20px;
            margin-top: 20px;
            min-height: 120px;
        }

        .loading-overlay {
            position: absolute;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background: rgba(255, 255, 255, 0.9);
            display: flex;
            align-items: center;
            justify-content: center;
            border-radius: var(--border-radius);
            opacity: 0;
            visibility: hidden;
            transition: var(--transition-standard);
        }

        .loading-overlay.active {
            opacity: 1;
            visibility: visible;
        }

        .loading-spinner {
            width: 48px;
            height: 48px;
            border: 4px solid #e0e0e0;
            border-top: 4px solid var(--primary-color);
            border-radius: 50%;
            animation: spin 1s linear infinite;
        }

        @keyframes spin {
            0% { transform: rotate(0deg); }
            100% { transform: rotate(360deg); }
        }

        .simple-control-container {
            background: #fff;
            border-radius: var(--border-radius);
            padding: 20px;
            margin-top: 16px;
            border: 1px solid #e0e0e0;
        }

        /* RTL Support */
        [dir="rtl"] .annotation-tabs {
            flex-direction: row-reverse;
        }

        [dir="rtl"] .tab-button {
            flex-direction: row-reverse;
        }

        [dir="rtl"] .control-label {
            flex-direction: row-reverse;
        }

        /* Responsive Design */
        @media (max-width: 768px) {
            .annotation-content {
                padding: 16px;
            }
            
            .image-controls {
                grid-template-columns: 1fr;
            }
            
            .annotation-tabs {
                flex-direction: column;
                gap: 8px;
            }
        }

        /* Animation Classes */
        .fade-in {
            animation: fadeIn 0.5s ease-out;
        }

        @keyframes fadeIn {
            from { 
                opacity: 0; 
                transform: translateY(20px); 
            }
            to { 
                opacity: 1; 
                transform: translateY(0); 
            }
        }
    </style>

    <script type="text/javascript">
        $(document).ready(function() {
            // Modern DataView integration
            setTimeout(function () {
                var dataView = Web.DataView.find('CarInfom', 'Controller');
                if (dataView) {
                    dataView.add_selected(function () {
                        $('.MyTextBox').val(dataView.get_selectedKey());
                        
                        // Add visual feedback
                        $('.MyTextBox').addClass('updated');
                        setTimeout(function() {
                            $('.MyTextBox').removeClass('updated');
                        }, 1000);
                    });
                }
            }, 50);

            // Initialize modern interactions
            initializeModernFeatures();
        });

        function initializeModernFeatures() {
            // Add loading states
            const textboxes = document.querySelectorAll('.modern-textbox');
            textboxes.forEach(textbox => {
                textbox.addEventListener('focus', function() {
                    this.parentElement.classList.add('focused');
                });

                textbox.addEventListener('blur', function() {
                    this.parentElement.classList.remove('focused');
                });
            });

            // Tab button interactions
            const tabButtons = document.querySelectorAll('.tab-button');
            tabButtons.forEach(button => {
                button.addEventListener('click', function(e) {
                    // Remove active class from all buttons
                    tabButtons.forEach(btn => btn.classList.remove('active'));
                    
                    // Add active class to clicked button
                    this.classList.add('active');
                    
                    // Show loading overlay
                    showLoadingOverlay();
                });
            });

            console.log('Modern Image Annotation Control initialized');
        }

        function showLoadingOverlay() {
            const overlay = document.querySelector('.loading-overlay');
            if (overlay) {
                overlay.classList.add('active');
                
                setTimeout(function() {
                    overlay.classList.remove('active');
                }, 2000);
            }
        }

        function updateImageDisplay(imageSrc) {
            const displayArea = document.querySelector('.image-display-area');
            if (displayArea && imageSrc) {
                displayArea.innerHTML = `
                    <img src="${imageSrc}" alt="التعليق على الصورة" style="max-width: 100%; max-height: 300px; border-radius: 8px; box-shadow: var(--elevation-1);">
                `;
            }
        }
    </script>

    <div id="CarInfom_editForm1_c55" class="annotation-container fade-in">
        <!-- Header -->
        <div class="annotation-header">
            <i class="fas fa-image"></i>
            <h3 class="annotation-title">نظام التعليق على الصور المتقدم</h3>
        </div>

        <!-- Navigation Tabs -->
        <div class="annotation-tabs">
            <asp:LinkButton ID="lbLogin" runat="server" CssClass="tab-button active">
                <i class="fas fa-sign-in-alt"></i>
                تسجيل الدخول
            </asp:LinkButton>
            <a href="#" class="tab-button" onclick="showLoadingOverlay(); return false;">
                <i class="fas fa-edit"></i>
                تحرير التعليق
            </a>
            <a href="#" class="tab-button" onclick="showLoadingOverlay(); return false;">
                <i class="fas fa-save"></i>
                حفظ التعليق
            </a>
            <a href="#" class="tab-button" onclick="showLoadingOverlay(); return false;">
                <i class="fas fa-download"></i>
                تصدير الصورة
            </a>
        </div>

        <!-- Main Content Area -->
        <div class="annotation-content">
            <!-- Modern AJAX Panel Replacement -->
            <div class="modern-ajax-panel" style="position: relative;">
                <!-- Timer Display -->
                <div class="timer-display">
                    <div class="timer-text">
                        <i class="fas fa-clock"></i>
                        <span>التحديث التلقائي كل 3 ثوانٍ</span>
                        <asp:Timer ID="Timer1" runat="server" Interval="3000" OnTick="Timer1_Tick"></asp:Timer>
                    </div>
                </div>

                <!-- Image Display Area -->
                <div class="image-display-area">
                    <div class="image-placeholder">
                        <i class="fas fa-image"></i>
                    </div>
                    <h4>منطقة عرض الصورة</h4>
                    <p class="text-muted">سيتم عرض الصورة المحددة هنا مع إمكانية إضافة التعليقات</p>
                </div>

                <!-- Control Groups -->
                <div class="image-controls">
                    <!-- Text Input Control -->
                    <div class="control-group">
                        <div class="control-label">
                            <i class="fas fa-keyboard"></i>
                            إدخال البيانات التفاعلي
                        </div>
                        <asp:TextBox type="text" ID="TextBox1" runat="server" 
                                   AutoPostBack="True" CssClass="modern-textbox MyTextBox" 
                                   placeholder="أدخل النص أو معرف الصورة..." />
                    </div>

                    <!-- Simple Control Integration -->
                    <div class="control-group">
                        <div class="control-label">
                            <i class="fas fa-puzzle-piece"></i>
                            مكون التحكم البسيط
                        </div>
                        <div class="simple-control-container">
                            <uc1:SimpleControl ID="SimpleControl1" runat="server" />
                        </div>
                    </div>
                </div>

                <!-- Content Panel -->
                <div class="content-panel">
                    <asp:Panel ID="Panel1" runat="server" 
                             Style="font: normal 14px 'Segoe UI', Arial, sans-serif; color: #424242; line-height: 1.6;">
                        <div style="text-align: center; padding: 20px;">
                            <i class="fas fa-info-circle" style="font-size: 24px; color: #1976d2; margin-bottom: 8px;"></i>
                            <p><strong>مرحباً بك في نظام التعليق على الصور المتقدم</strong></p>
                            <p>استخدم الأدوات أعلاه لتحديد الصور وإضافة التعليقات التفاعلية</p>
                        </div>
                    </asp:Panel>
                </div>

                <!-- Loading Overlay (Replaces RadAjaxLoadingPanel) -->
                <div class="loading-overlay">
                    <div class="loading-spinner"></div>
                </div>
            </div>
        </div>
    </div>
</div>