<%@ Page Language="vb" AutoEventWireup="false" CodeFile="defaultsc.aspx.vb" Inherits="defaultsc" %>
<%@ Register src="Imagwithanotate.ascx" tagname="Imagwithanotate" tagprefix="uc1" %>
<%@ Register src="SimpleControl.ascx" tagname="SimpleControl" tagprefix="uc2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>المراقب الافتراضي</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    
    <!-- Modern CSS Framework -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css" rel="stylesheet">
    
    <style>
        :root {
            --primary-color: #1976d2;
            --secondary-color: #424242;
            --accent-color: #ff5722;
            --success-color: #4caf50;
            --warning-color: #ff9800;
            --error-color: #f44336;
            --surface-color: #ffffff;
            --background-color: #f5f5f5;
            --text-primary: #212121;
            --text-secondary: #757575;
            --border-radius: 12px;
            --elevation-1: 0 2px 4px rgba(0,0,0,0.1);
            --elevation-2: 0 4px 8px rgba(0,0,0,0.12);
            --elevation-3: 0 8px 16px rgba(0,0,0,0.15);
            --transition-fast: 0.2s cubic-bezier(0.4, 0, 0.2, 1);
            --transition-standard: 0.3s cubic-bezier(0.4, 0, 0.2, 1);
        }

        body {
            font-family: 'Segoe UI', 'Roboto', sans-serif;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
            margin: 0;
            padding: 20px;
            direction: rtl;
        }

        .main-container {
            max-width: 1200px;
            margin: 0 auto;
            background: var(--surface-color);
            border-radius: var(--border-radius);
            box-shadow: var(--elevation-3);
            overflow: hidden;
        }

        .header-section {
            background: linear-gradient(135deg, var(--primary-color), #1565c0);
            color: white;
            padding: 24px;
            text-align: center;
        }

        .header-title {
            margin: 0;
            font-size: 28px;
            font-weight: 300;
            display: flex;
            align-items: center;
            justify-content: center;
            gap: 12px;
        }

        .content-section {
            padding: 32px;
        }

        .controls-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 24px;
            margin-bottom: 32px;
        }

        .control-card {
            background: var(--surface-color);
            border: 1px solid #e0e0e0;
            border-radius: var(--border-radius);
            padding: 24px;
            box-shadow: var(--elevation-1);
            transition: var(--transition-standard);
        }

        .control-card:hover {
            box-shadow: var(--elevation-2);
            transform: translateY(-2px);
        }

        .control-title {
            font-size: 18px;
            font-weight: 500;
            color: var(--text-primary);
            margin-bottom: 16px;
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
            background: #fafafa;
        }

        .modern-textbox:focus {
            outline: none;
            border-color: var(--primary-color);
            background: white;
            box-shadow: 0 0 0 3px rgba(25, 118, 210, 0.1);
        }

        .modern-button {
            background: linear-gradient(135deg, var(--primary-color), #1565c0);
            color: white;
            border: none;
            border-radius: 8px;
            padding: 12px 24px;
            font-size: 16px;
            font-weight: 500;
            cursor: pointer;
            transition: var(--transition-fast);
            display: inline-flex;
            align-items: center;
            gap: 8px;
            text-transform: none;
        }

        .modern-button:hover {
            background: linear-gradient(135deg, #1565c0, #0d47a1);
            transform: translateY(-1px);
            box-shadow: var(--elevation-2);
        }

        .modern-button:active {
            transform: translateY(0);
        }

        .info-display {
            background: linear-gradient(135deg, #e3f2fd, #bbdefb);
            border: 1px solid #2196f3;
            border-radius: var(--border-radius);
            padding: 20px;
            margin-top: 24px;
        }

        .info-label {
            font-size: 16px;
            color: var(--text-primary);
            font-weight: 500;
            min-height: 24px;
            display: flex;
            align-items: center;
            gap: 8px;
        }

        .controls-placeholder {
            background: #f8f9fa;
            border: 2px dashed #dee2e6;
            border-radius: var(--border-radius);
            padding: 32px;
            text-align: center;
            color: var(--text-secondary);
            min-height: 120px;
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            gap: 12px;
        }

        .image-annotation-section {
            margin-bottom: 32px;
        }

        .section-divider {
            height: 1px;
            background: linear-gradient(90deg, transparent, #e0e0e0, transparent);
            margin: 32px 0;
        }

        @media (max-width: 768px) {
            .controls-grid {
                grid-template-columns: 1fr;
            }
            
            .content-section {
                padding: 20px;
            }
            
            body {
                padding: 10px;
            }
        }

        /* RTL Enhancements */
        [dir="rtl"] {
            text-align: right;
        }

        [dir="rtl"] .control-title {
            flex-direction: row-reverse;
        }

        [dir="rtl"] .modern-button {
            flex-direction: row-reverse;
        }

        [dir="rtl"] .info-label {
            flex-direction: row-reverse;
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

        .slide-in {
            animation: slideIn 0.6s cubic-bezier(0.4, 0, 0.2, 1);
        }

        @keyframes slideIn {
            from { 
                opacity: 0; 
                transform: translateX(-30px); 
            }
            to { 
                opacity: 1; 
                transform: translateX(0); 
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        
        <div class="main-container">
            <!-- Header Section -->
            <div class="header-section">
                <h1 class="header-title fade-in">
                    <i class="material-icons">dashboard</i>
                    لوحة التحكم الافتراضية
                </h1>
            </div>

            <!-- Content Section -->
            <div class="content-section">
                <!-- Image Annotation Section -->
                <div class="image-annotation-section slide-in">
                    <div class="control-card">
                        <div class="control-title">
                            <i class="fas fa-image"></i>
                            مكون التعليق على الصور
                        </div>
                        <uc1:Imagwithanotate ID="Imagwithanotate1" runat="server" />
                    </div>
                </div>

                <div class="section-divider"></div>

                <!-- Controls Grid -->
                <div class="controls-grid">
                    <!-- Text Input Section -->
                    <div class="control-card slide-in">
                        <div class="control-title">
                            <i class="fas fa-edit"></i>
                            إدخال النص المتقدم
                        </div>
                        <div class="mb-3">
                            <label for="ModernTextBox1" class="form-label">النص التفاعلي:</label>
                            <asp:TextBox runat="server" ID="ModernTextBox1" CssClass="modern-textbox" 
                                        AutoPostBack="True" placeholder="أدخل النص هنا..." />
                        </div>
                        <div class="mb-3">
                            <label for="TextBox1" class="form-label">مربع النص التقليدي:</label>
                            <asp:TextBox runat="server" ID="TextBox1" CssClass="modern-textbox" 
                                        AutoPostBack="True" ontextchanged="TextBox1_TextChanged">1</asp:TextBox>
                        </div>
                    </div>

                    <!-- Action Controls Section -->
                    <div class="control-card slide-in">
                        <div class="control-title">
                            <i class="fas fa-cogs"></i>
                            عناصر التحكم التفاعلية
                        </div>
                        <div class="d-grid gap-3">
                            <asp:Button ID="Button1" runat="server" CssClass="modern-button" 
                                       Text="إضافة مكون بسيط" />
                            <div class="mt-3">
                                <uc2:SimpleControl ID="SimpleControl1" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>

                <div class="section-divider"></div>

                <!-- Dynamic Content Section -->
                <div class="control-card slide-in">
                    <div class="control-title">
                        <i class="fas fa-layer-group"></i>
                        المحتوى الديناميكي
                    </div>
                    <div class="controls-placeholder">
                        <i class="fas fa-plus-circle fa-2x"></i>
                        <span>منطقة العناصر الديناميكية</span>
                        <asp:PlaceHolder runat="server" ID="Placeholder1"></asp:PlaceHolder>
                    </div>
                </div>

                <div class="section-divider"></div>

                <!-- User Information Display -->
                <div class="info-display slide-in">
                    <div class="control-title">
                        <i class="fas fa-user-circle"></i>
                        معلومات المستخدم
                    </div>
                    <div class="info-label">
                        <i class="fas fa-info-circle"></i>
                        <asp:Label ID="lblUser" runat="server" Text="مرحباً بك في النظام"></asp:Label>
                    </div>
                </div>
            </div>
        </div>

        <!-- Modern JavaScript -->
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>
        <script>
            document.addEventListener('DOMContentLoaded', function() {
                // Add loading states for form interactions
                const textboxes = document.querySelectorAll('.modern-textbox');
                const buttons = document.querySelectorAll('.modern-button');

                textboxes.forEach(textbox => {
                    textbox.addEventListener('focus', function() {
                        this.parentElement.classList.add('focused');
                    });

                    textbox.addEventListener('blur', function() {
                        this.parentElement.classList.remove('focused');
                    });
                });

                buttons.forEach(button => {
                    button.addEventListener('click', function() {
                        // Add loading state
                        const originalText = this.textContent;
                        this.innerHTML = '<i class="fas fa-spinner fa-spin"></i> جاري المعالجة...';
                        this.disabled = true;

                        // Reset after a short delay (the postback will handle the actual reset)
                        setTimeout(() => {
                            this.textContent = originalText;
                            this.disabled = false;
                        }, 2000);
                    });
                });

                // Animate cards on scroll
                const observerOptions = {
                    threshold: 0.1,
                    rootMargin: '0px 0px -50px 0px'
                };

                const observer = new IntersectionObserver((entries) => {
                    entries.forEach(entry => {
                        if (entry.isIntersecting) {
                            entry.target.style.opacity = '1';
                            entry.target.style.transform = 'translateY(0)';
                        }
                    });
                }, observerOptions);

                document.querySelectorAll('.control-card').forEach(card => {
                    card.style.opacity = '0';
                    card.style.transform = 'translateY(20px)';
                    card.style.transition = 'opacity 0.6s ease, transform 0.6s ease';
                    observer.observe(card);
                });

                // Enhanced textbox interactions
                const modernTextboxes = document.querySelectorAll('.modern-textbox');
                modernTextboxes.forEach(textbox => {
                    // Add floating label effect
                    const label = textbox.previousElementSibling;
                    if (label && label.tagName === 'LABEL') {
                        if (textbox.value) {
                            label.classList.add('floating');
                        }

                        textbox.addEventListener('focus', () => {
                            label.classList.add('floating');
                        });

                        textbox.addEventListener('blur', () => {
                            if (!textbox.value) {
                                label.classList.remove('floating');
                            }
                        });
                    }
                });

                console.log('Modern Default Control Interface initialized successfully');
            });
        </script>
    </form>
</body>
</html>
