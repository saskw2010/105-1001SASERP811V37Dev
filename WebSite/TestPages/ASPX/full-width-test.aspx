<%@ Page Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="full-width-test.aspx.vb" Inherits="FullWidthTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="pageTitleContentPlaceHolder" Runat="Server">
    🚀 Full Width Test - اختبار العرض الكامل
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <style>
        .test-container {
            background: linear-gradient(135deg, #f0f9ff 0%, #e0f2fe 100%);
            border-radius: 15px;
            padding: 20px;
            margin: 0;
            box-shadow: 0 10px 25px rgba(0, 0, 0, 0.1);
        }
        
        .test-header {
            text-align: center;
            margin-bottom: 30px;
        }
        
        .test-title {
            color: #2563eb;
            font-size: 2.5rem;
            margin-bottom: 10px;
            font-weight: 700;
        }
        
        .test-subtitle {
            color: #6b7280;
            font-size: 1.2rem;
            line-height: 1.6;
        }
        
        .metrics-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 20px;
            margin: 30px 0;
        }
        
        .metric-card {
            background: white;
            border-radius: 12px;
            padding: 20px;
            text-align: center;
            box-shadow: 0 4px 15px rgba(0, 0, 0, 0.1);
            border-left: 4px solid #2563eb;
        }
        
        .metric-value {
            font-size: 2rem;
            font-weight: 700;
            color: #2563eb;
            margin-bottom: 5px;
        }
        
        .metric-label {
            color: #6b7280;
            font-size: 0.9rem;
            text-transform: uppercase;
            letter-spacing: 0.5px;
        }
        
        .width-bar {
            background: #e5e7eb;
            height: 20px;
            border-radius: 10px;
            margin: 20px 0;
            position: relative;
            overflow: hidden;
        }
        
        .width-fill {
            background: linear-gradient(45deg, #2563eb, #3b82f6);
            height: 100%;
            transition: width 0.5s ease;
            border-radius: 10px;
            display: flex;
            align-items: center;
            justify-content: center;
            color: white;
            font-weight: 600;
            font-size: 0.8rem;
        }
        
        .status-panel {
            background: #1f2937;
            color: #f9fafb;
            padding: 20px;
            border-radius: 12px;
            font-family: 'Consolas', monospace;
            margin: 20px 0;
            max-height: 300px;
            overflow-y: auto;
            font-size: 0.85rem;
            line-height: 1.4;
        }
        
        .test-actions {
            display: flex;
            flex-wrap: wrap;
            gap: 15px;
            justify-content: center;
            margin: 30px 0;
        }
        
        .test-btn {
            background: linear-gradient(135deg, #2563eb 0%, #1d4ed8 100%);
            color: white;
            border: none;
            padding: 12px 24px;
            border-radius: 25px;
            cursor: pointer;
            font-weight: 600;
            text-decoration: none;
            display: inline-flex;
            align-items: center;
            gap: 8px;
            transition: all 0.3s ease;
            font-family: 'Cairo', Arial, sans-serif;
        }
        
        .test-btn:hover {
            transform: translateY(-2px);
            box-shadow: 0 8px 25px rgba(37, 99, 235, 0.3);
        }
        
        .test-btn.secondary {
            background: linear-gradient(135deg, #6b7280 0%, #4b5563 100%);
        }
        
        .test-btn.success {
            background: linear-gradient(135deg, #10b981 0%, #059669 100%);
        }
        
        .test-btn.warning {
            background: linear-gradient(135deg, #f59e0b 0%, #d97706 100%);
        }
        
        .warning-box {
            background: #fef3c7;
            border: 2px solid #f59e0b;
            border-radius: 12px;
            padding: 20px;
            margin: 20px 0;
            color: #92400e;
        }
        
        .success-box {
            background: #d1fae5;
            border: 2px solid #10b981;
            border-radius: 12px;
            padding: 20px;
            margin: 20px 0;
            color: #065f46;
        }
        
        .debug-info {
            background: #f3f4f6;
            border-radius: 8px;
            padding: 15px;
            margin: 15px 0;
            font-family: 'Consolas', monospace;
            font-size: 0.8rem;
            line-height: 1.4;
        }
    </style>

    <div class="test-container">
        <div class="test-header">
            <div class="test-title">🚀 Full Width Test</div>
            <div class="test-subtitle">مراقب العرض الكامل - تشخيص وإصلاح مشاكل عرض المحتوى</div>
        </div>

        <div class="metrics-grid">
            <div class="metric-card">
                <div class="metric-value" id="windowWidth">--</div>
                <div class="metric-label">Window Width</div>
            </div>
            <div class="metric-card">
                <div class="metric-value" id="pageContentWidth">--</div>
                <div class="metric-label">PageContent Width</div>
            </div>
            <div class="metric-card">
                <div class="metric-value" id="utilizationPercent">--</div>
                <div class="metric-label">Width Utilization</div>
            </div>
            <div class="metric-card">
                <div class="metric-value" id="statusIndicator">🔄</div>
                <div class="metric-label">Status</div>
            </div>
        </div>

        <div class="width-bar">
            <div class="width-fill" id="widthFill" style="width: 0%;">
                <span id="widthText">تحديد العرض...</span>
            </div>
        </div>

        <div class="test-actions">
            <button class="test-btn" onclick="forceFullWidth()">
                🔧 إصلاح العرض فوراً
            </button>
            <button class="test-btn secondary" onclick="refreshMetrics()">
                🔄 تحديث القياسات
            </button>
            <button class="test-btn success" onclick="runDiagnostics()">
                🔍 تشخيص شامل
            </button>
            <button class="test-btn warning" onclick="toggleDebugMode()">
                🐛 وضع التصحيح
            </button>
        </div>

        <div id="warningBox" class="warning-box" style="display: none;">
            <strong>⚠️ تحذير:</strong> <span id="warningText"></span>
        </div>

        <div id="successBox" class="success-box" style="display: none;">
            <strong>✅ نجح:</strong> <span id="successText"></span>
        </div>

        <div class="debug-info">
            <strong>معلومات CSS المطبقة:</strong><br>
            • FullWidthFix.css - إصلاح نهائي للعرض الكامل<br>
            • AdvancedTheme.css - إصلاحات متقدمة للحاويات<br>
            • JavaScript Monitor - مراقب ديناميكي للعرض<br>
            • Critical CSS Classes - فئات CSS حرجة للإصلاح الفوري
        </div>

        <div class="status-panel" id="statusPanel">
            <div>[البدء] 🚀 Full Width Test Panel Initialized</div>
        </div>
    </div>

    <script>
        let debugMode = false;
        let monitorInterval;

        function logToPanel(message) {
            const panel = document.getElementById('statusPanel');
            const time = new Date().toLocaleTimeString();
            panel.innerHTML += `<div>[${time}] ${message}</div>`;
            panel.scrollTop = panel.scrollHeight;
        }

        function updateMetrics() {
            const windowWidth = window.innerWidth;
            const pageContent = document.getElementById('PageContent');
            
            let pageContentWidth = 0;
            let utilization = 0;
            let status = '❌';

            if (pageContent) {
                const computedStyle = window.getComputedStyle(pageContent);
                pageContentWidth = parseInt(computedStyle.width);
                utilization = Math.round((pageContentWidth / windowWidth) * 100);
                
                if (utilization >= 95) {
                    status = '✅';
                    hideWarning();
                    showSuccess('العرض مُحسَّن بشكل مثالي!');
                } else if (utilization >= 80) {
                    status = '⚠️';
                    showWarning(`العرض ${utilization}% - يمكن تحسينه`);
                } else {
                    status = '❌';
                    showWarning(`العرض ${utilization}% - يحتاج إصلاح فوري`);
                }
            }

            // Update display
            document.getElementById('windowWidth').textContent = windowWidth + 'px';
            document.getElementById('pageContentWidth').textContent = pageContentWidth + 'px';
            document.getElementById('utilizationPercent').textContent = utilization + '%';
            document.getElementById('statusIndicator').textContent = status;

            // Update width bar
            const widthFill = document.getElementById('widthFill');
            const widthText = document.getElementById('widthText');
            widthFill.style.width = utilization + '%';
            widthText.textContent = `${utilization}% من عرض الشاشة`;

            // Color coding
            if (utilization >= 95) {
                widthFill.style.background = 'linear-gradient(45deg, #10b981, #059669)';
            } else if (utilization >= 80) {
                widthFill.style.background = 'linear-gradient(45deg, #f59e0b, #d97706)';
            } else {
                widthFill.style.background = 'linear-gradient(45deg, #ef4444, #dc2626)';
            }

            if (debugMode) {
                logToPanel(`📊 Metrics - Window: ${windowWidth}px, Content: ${pageContentWidth}px, Utilization: ${utilization}%`);
            }
        }

        function forceFullWidth() {
            logToPanel('🔧 بدء إصلاح العرض الفوري...');
            
            const pageContent = document.getElementById('PageContent');
            const form1 = document.getElementById('form1');
            const body = document.body;
            const html = document.documentElement;

            if (pageContent) {
                pageContent.style.width = '100%';
                pageContent.style.maxWidth = '100%';
                pageContent.style.margin = '0';
                pageContent.style.padding = '15px';
                pageContent.style.boxSizing = 'border-box';
                pageContent.classList.add('full-width-critical');
                logToPanel('✅ تم إصلاح PageContent');
            }

            if (form1) {
                form1.style.width = '100%';
                form1.style.maxWidth = '100%';
                form1.style.margin = '0';
                form1.style.padding = '0';
                logToPanel('✅ تم إصلاح Form1');
            }

            body.style.width = '100%';
            body.style.maxWidth = '100%';
            body.style.margin = '0';
            body.style.padding = '0';
            body.style.overflowX = 'hidden';

            html.style.width = '100%';
            html.style.maxWidth = '100%';
            html.style.margin = '0';
            html.style.padding = '0';

            logToPanel('✅ تم إصلاح Body و HTML');
            
            setTimeout(updateMetrics, 100);
            logToPanel('🎯 إصلاح العرض مكتمل!');
        }

        function refreshMetrics() {
            logToPanel('🔄 تحديث القياسات...');
            updateMetrics();
            logToPanel('✅ تم تحديث القياسات');
        }

        function runDiagnostics() {
            logToPanel('🔍 بدء التشخيص الشامل...');
            
            const pageContent = document.getElementById('PageContent');
            if (pageContent) {
                const computedStyle = window.getComputedStyle(pageContent);
                logToPanel(`📐 PageContent computed width: ${computedStyle.width}`);
                logToPanel(`📐 PageContent computed max-width: ${computedStyle.maxWidth}`);
                logToPanel(`📐 PageContent computed margin: ${computedStyle.margin}`);
                logToPanel(`📐 PageContent computed padding: ${computedStyle.padding}`);
                logToPanel(`📐 PageContent computed box-sizing: ${computedStyle.boxSizing}`);
                
                const boundingRect = pageContent.getBoundingClientRect();
                logToPanel(`📏 PageContent bounding width: ${boundingRect.width}px`);
                logToPanel(`📏 PageContent offset width: ${pageContent.offsetWidth}px`);
                logToPanel(`📏 PageContent scroll width: ${pageContent.scrollWidth}px`);
            }
            
            logToPanel(`🖥️ Window inner width: ${window.innerWidth}px`);
            logToPanel(`🖥️ Screen width: ${screen.width}px`);
            logToPanel(`📱 Device pixel ratio: ${window.devicePixelRatio}`);
            
            logToPanel('✅ تشخيص مكتمل');
        }

        function toggleDebugMode() {
            debugMode = !debugMode;
            const btn = event.target;
            
            if (debugMode) {
                btn.textContent = '🐛 إيقاف التصحيح';
                btn.classList.remove('warning');
                btn.classList.add('success');
                logToPanel('🐛 وضع التصحيح مفعل');
                
                // Start continuous monitoring
                monitorInterval = setInterval(updateMetrics, 1000);
            } else {
                btn.textContent = '🐛 وضع التصحيح';
                btn.classList.remove('success');
                btn.classList.add('warning');
                logToPanel('🐛 وضع التصحيح معطل');
                
                // Stop continuous monitoring
                if (monitorInterval) {
                    clearInterval(monitorInterval);
                }
            }
        }

        function showWarning(text) {
            const warningBox = document.getElementById('warningBox');
            const warningText = document.getElementById('warningText');
            warningText.textContent = text;
            warningBox.style.display = 'block';
        }

        function hideWarning() {
            document.getElementById('warningBox').style.display = 'none';
        }

        function showSuccess(text) {
            const successBox = document.getElementById('successBox');
            const successText = document.getElementById('successText');
            successText.textContent = text;
            successBox.style.display = 'block';
            
            setTimeout(() => {
                successBox.style.display = 'none';
            }, 3000);
        }

        // Initialize
        document.addEventListener('DOMContentLoaded', function() {
            logToPanel('🚀 Full Width Test Panel initialized');
            updateMetrics();
            
            // Auto-refresh metrics every 5 seconds
            setInterval(updateMetrics, 5000);
            
            // Listen for window resize
            window.addEventListener('resize', function() {
                logToPanel('📐 Window resized');
                setTimeout(updateMetrics, 100);
            });
            
            logToPanel('👁️ Monitoring started');
        });
    </script>
</asp:Content>
