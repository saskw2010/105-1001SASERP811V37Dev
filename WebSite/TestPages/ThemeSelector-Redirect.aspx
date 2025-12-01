<%@ Page Language="VB" MasterPageFile="~/ModernMaster.master" AutoEventWireup="false" Title="Theme Selector - إعادة توجيه" %>

<asp:Content ID="ContentHead" ContentPlaceHolderID="head" runat="Server">
    <meta http-equiv="refresh" content="3;url=~/ThemeSelector/index.html">
    <style>
        .redirect-container {
            display: flex;
            flex-direction: column;
            align-items: center;
            justify-content: center;
            min-height: 60vh;
            text-align: center;
            padding: 2rem;
        }
        
        .redirect-icon {
            font-size: 4rem;
            color: var(--primary-color, #2563eb);
            margin-bottom: 1.5rem;
            animation: pulse 2s infinite;
        }
        
        .redirect-title {
            color: var(--text-primary, #1f2937);
            font-size: 2rem;
            margin-bottom: 1rem;
        }
        
        .redirect-message {
            color: var(--text-secondary, #6b7280);
            font-size: 1.2rem;
            margin-bottom: 2rem;
            max-width: 600px;
        }
        
        .redirect-button {
            background: var(--primary-gradient, linear-gradient(135deg, #2563eb, #1d4ed8));
            color: white;
            padding: 1rem 2rem;
            border: none;
            border-radius: 12px;
            font-size: 1.1rem;
            text-decoration: none;
            display: inline-flex;
            align-items: center;
            gap: 0.5rem;
            transition: all 0.3s ease;
        }
        
        .redirect-button:hover {
            transform: translateY(-2px);
            box-shadow: 0 8px 25px rgba(37, 99, 235, 0.3);
        }
        
        .countdown {
            color: var(--primary-color, #2563eb);
            font-weight: bold;
            font-size: 1.5rem;
        }
        
        @keyframes pulse {
            0%, 100% { opacity: 1; }
            50% { opacity: 0.6; }
        }
        
        .loading-dots {
            display: inline-block;
        }
        
        .loading-dots::after {
            content: '';
            animation: dots 1.5s infinite;
        }
        
        @keyframes dots {
            0%, 20% { content: ''; }
            40% { content: '.'; }
            60% { content: '..'; }
            80%, 100% { content: '...'; }
        }
    </style>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">
    Theme Selector - إعادة توجيه
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
    <div class="redirect-container">
        <div class="redirect-icon">
            <i class="fas fa-palette"></i>
        </div>
        
        <h1 class="redirect-title">
            🎨 نظام اختيار الثيم الجديد
        </h1>
        
        <p class="redirect-message">
            تم نقل نظام اختيار الثيم إلى موقع جديد محسّن مع واجهة أكثر تطوراً وميزات متقدمة.
            <br>
            سيتم توجيهك تلقائياً خلال <span class="countdown" id="countdown">3</span> ثوانٍ<span class="loading-dots"></span>
        </p>
        
        <a href="~/ThemeSelector/index.html" class="redirect-button">
            <i class="fas fa-external-link-alt"></i>
            انتقل إلى محدد الثيم الجديد
        </a>
        
        <div style="margin-top: 2rem; font-size: 0.9rem; color: var(--text-muted, #9ca3af);">
            <p>
                <i class="fas fa-info-circle"></i>
                إذا لم يتم التوجيه تلقائياً، يرجى النقر على الزر أعلاه
            </p>
        </div>
    </div>
    
    <script>
        // Countdown timer
        let seconds = 3;
        const countdownElement = document.getElementById('countdown');
        
        const timer = setInterval(() => {
            seconds--;
            countdownElement.textContent = seconds;
            
            if (seconds <= 0) {
                clearInterval(timer);
                countdownElement.textContent = '0';
                window.location.href = '<%= ResolveUrl("~/ThemeSelector/index.html") %>';
            }
        }, 1000);
    </script>
</asp:Content>
