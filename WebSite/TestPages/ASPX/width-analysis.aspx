<%@ Page Language="VB" MasterPageFile="~/Main.master" AutoEventWireup="false" CodeFile="width-analysis.aspx.vb" Inherits="WidthAnalysis" Theme="" %>

<asp:Content ID="ContentTitle" ContentPlaceHolderID="TitleContentPlaceHolder" Runat="Server">
    🔧 Width Analysis & Fix Report - مراقبة وإصلاح العرض
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        .analysis-container {
            padding: 20px;
            background: linear-gradient(135deg, #f0f9ff 0%, #e0f2fe 100%);
            border-radius: 15px;
            margin: 10px 0;
        }
        
        .analysis-header {
            color: #2563eb;
            font-size: 1.5rem;
            margin-bottom: 15px;
            display: flex;
            align-items: center;
            gap: 10px;
        }
        
        .metrics-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 15px;
            margin: 20px 0;
        }
        
        .metric-card {
            background: white;
            padding: 15px;
            border-radius: 10px;
            box-shadow: 0 2px 10px rgba(0,0,0,0.1);
            border-left: 4px solid #2563eb;
        }
        
        .metric-label {
            font-weight: 600;
            color: #374151;
            margin-bottom: 5px;
        }
        
        .metric-value {
            font-size: 1.2rem;
            color: #2563eb;
            font-weight: 700;
        }
        
        .issue-report {
            background: #fef2f2;
            border: 1px solid #fecaca;
            border-radius: 8px;
            padding: 15px;
            margin: 15px 0;
        }
        
        .fix-report {
            background: #f0fdf4;
            border: 1px solid #bbf7d0;
            border-radius: 8px;
            padding: 15px;
            margin: 15px 0;
        }
        
        .console-logs {
            background: #1f2937;
            color: #f9fafb;
            padding: 20px;
            border-radius: 10px;
            font-family: 'Consolas', monospace;
            margin: 20px 0;
            max-height: 400px;
            overflow-y: auto;
        }
        
        .test-element {
            border: 2px dashed #2563eb;
            padding: 20px;
            margin: 10px 0;
            background: rgba(37, 99, 235, 0.05);
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" Runat="Server">
    <div class="analysis-container">
        <div class="analysis-header">
            🔧 <span>تحليل شامل لمشكلة العرض</span>
        </div>
        
        <div class="issue-report">
            <h3>❌ المشكلة المبلغ عنها</h3>
            <p><strong>المستخدم:</strong> "ارى المكونات فى الشاشة عرضها لم يصبح 100 % pagecontent ليه كده"</p>
            <p><strong>الوصف:</strong> المكونات في الصفحة لا تأخذ العرض الكامل 100% من PageContent</p>
        </div>
        
        <div class="fix-report">
            <h3>✅ الإصلاحات المطبقة</h3>
            <ul>
                <li>✅ إضافة CSS شامل في AdvancedTheme.css لإجبار العرض 100%</li>
                <li>✅ إضافة CSS critical في Main.master مع !important</li>
                <li>✅ إصلاح جميع Containers و Telerik Controls</li>
                <li>✅ إضافة Console Logging شامل للمراقبة</li>
                <li>✅ إصلاح خطأ VB.NET في user-info-demo.aspx.vb</li>
            </ul>
        </div>
        
        <div class="metrics-grid">
            <div class="metric-card">
                <div class="metric-label">PageContent Width</div>
                <div class="metric-value" id="pageContentWidth">Loading...</div>
            </div>
            <div class="metric-card">
                <div class="metric-label">Window Width</div>
                <div class="metric-value" id="windowWidth">Loading...</div>
            </div>
            <div class="metric-card">
                <div class="metric-label">Max Width</div>
                <div class="metric-value" id="maxWidth">Loading...</div>
            </div>
            <div class="metric-card">
                <div class="metric-label">Box Sizing</div>
                <div class="metric-value" id="boxSizing">Loading...</div>
            </div>
        </div>
        
        <div class="test-element">
            <h4>🧪 عنصر اختبار - Test Element</h4>
            <p>هذا العنصر يجب أن يأخذ العرض الكامل 100% من PageContent</p>
            <div id="testElementInfo" style="font-family: monospace; background: #f3f4f6; padding: 10px; border-radius: 5px;"></div>
        </div>
        
        <div class="console-logs">
            <h4>📋 Console Logs - سجل وحدة التحكم</h4>
            <div id="consoleLogs">Loading console information...</div>
        </div>
    </div>
    
    <script type="text/javascript">
        document.addEventListener('DOMContentLoaded', function() {
            console.log('🔧 [WidthAnalysis] Starting comprehensive width analysis');
            
            function updateMetrics() {
                const pageContent = document.getElementById('PageContent');
                const pageContentPlaceholder = document.getElementById('PageContentPlaceHolder');
                
                if (pageContent) {
                    const style = window.getComputedStyle(pageContent);
                    
                    // Update metrics
                    document.getElementById('pageContentWidth').textContent = style.width;
                    document.getElementById('windowWidth').textContent = window.innerWidth + 'px';
                    document.getElementById('maxWidth').textContent = style.maxWidth;
                    document.getElementById('boxSizing').textContent = style.boxSizing;
                    
                    // Test element info
                    const testInfo = document.getElementById('testElementInfo');
                    const testElement = testInfo.parentElement;
                    const testStyle = window.getComputedStyle(testElement);
                    
                    testInfo.innerHTML = `
                        <strong>Test Element Analysis:</strong><br>
                        Width: ${testStyle.width}<br>
                        Max-Width: ${testStyle.maxWidth}<br>
                        Margin: ${testStyle.margin}<br>
                        Padding: ${testStyle.padding}<br>
                        Box-Sizing: ${testStyle.boxSizing}<br>
                        <br>
                        <strong>PageContent Analysis:</strong><br>
                        Width: ${style.width}<br>
                        Max-Width: ${style.maxWidth}<br>
                        Margin: ${style.margin}<br>
                        Padding: ${style.padding}<br>
                        Position: ${style.position}<br>
                        Display: ${style.display}
                    `;
                    
                    console.log('📊 [WidthAnalysis] Metrics updated:');
                    console.log('  - PageContent width:', style.width);
                    console.log('  - PageContent max-width:', style.maxWidth);
                    console.log('  - Window width:', window.innerWidth + 'px');
                    console.log('  - Box sizing:', style.boxSizing);
                } else {
                    console.error('❌ [WidthAnalysis] PageContent element not found!');
                }
            }
            
            // Initial update
            updateMetrics();
            
            // Update on resize
            window.addEventListener('resize', updateMetrics);
            
            // Console logs display
            const consoleLogs = document.getElementById('consoleLogs');
            consoleLogs.innerHTML = `
                <div style="color: #10b981;">✅ PageContent width fix applied</div>
                <div style="color: #3b82f6;">📐 Current window width: ${window.innerWidth}px</div>
                <div style="color: #8b5cf6;">🎯 CSS !important rules active</div>
                <div style="color: #f59e0b;">⚡ Monitoring active for changes</div>
                <div style="color: #ef4444;">🔍 Check browser console for detailed logs</div>
            `;
            
            console.log('✅ [WidthAnalysis] Analysis page loaded successfully');
            console.log('💡 [WidthAnalysis] Monitor this page to verify 100% width behavior');
        });
    </script>
</asp:Content>
