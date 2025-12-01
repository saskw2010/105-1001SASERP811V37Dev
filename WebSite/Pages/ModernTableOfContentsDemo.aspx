<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="ModernTableOfContentsDemo.aspx.vb" Inherits="Pages_ModernTableOfContentsDemo" Title="Modern Navigation Demo" %>
<%@ Register Src="../Controls/TableOfContents.ascx" TagName="TableOfContents" TagPrefix="uc" %>
<%@ Register Src="../Controls/ModernTOC.ascx" TagName="ModernTOC" TagPrefix="uc" %>

<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
    <style>
        /* Demo Page Styles */
        .demo-container {
            max-width: 1400px;
            margin: 0 auto;
            padding: 2rem 1rem;
        }

        .demo-header {
            text-align: center;
            margin-bottom: 3rem;
            padding: 2rem;
            background: linear-gradient(135deg, rgba(37, 99, 235, 0.1) 0%, rgba(147, 51, 234, 0.1) 100%);
            border-radius: 20px;
            border: 1px solid rgba(37, 99, 235, 0.2);
        }

        .demo-header h1 {
            font-size: 2.5rem;
            font-weight: 700;
            background: linear-gradient(135deg, #2563eb 0%, #7c3aed 100%);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            margin-bottom: 1rem;
        }

        .demo-subtitle {
            font-size: 1.2rem;
            color: #64748b;
            margin-bottom: 2rem;
        }

        .demo-features {
            display: flex;
            justify-content: center;
            flex-wrap: wrap;
            gap: 1rem;
        }

        .feature-badge {
            display: flex;
            align-items: center;
            gap: 0.5rem;
            background: rgba(37, 99, 235, 0.1);
            padding: 0.5rem 1rem;
            border-radius: 50px;
            border: 1px solid rgba(37, 99, 235, 0.2);
            color: #2563eb;
            font-weight: 500;
        }

        .demo-controls {
            background: white;
            padding: 2rem;
            border-radius: 16px;
            margin-bottom: 2rem;
            border: 1px solid #e2e8f0;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.05);
        }

        .demo-controls h3 {
            margin-bottom: 1rem;
            color: #1e293b;
        }

        .control-group {
            display: flex;
            gap: 1rem;
            flex-wrap: wrap;
        }

        .demo-btn {
            background: linear-gradient(135deg, #2563eb 0%, #3b82f6 100%);
            color: white;
            border: none;
            padding: 0.75rem 1.5rem;
            border-radius: 10px;
            font-weight: 500;
            cursor: pointer;
            transition: all 0.3s ease;
        }

        .demo-btn:hover {
            transform: translateY(-2px);
            box-shadow: 0 8px 25px rgba(37, 99, 235, 0.3);
        }

        .demo-component {
            margin-bottom: 3rem;
        }

        .demo-comparison {
            margin-bottom: 3rem;
        }

        .demo-comparison h3 {
            text-align: center;
            margin-bottom: 2rem;
            color: #1e293b;
            font-size: 1.8rem;
        }

        .comparison-grid {
            display: grid;
            grid-template-columns: 1fr 1fr;
            gap: 2rem;
        }

        .comparison-card {
            padding: 2rem;
            border-radius: 16px;
            border: 2px solid;
        }

        .comparison-card.old-design {
            background: rgba(239, 68, 68, 0.05);
            border-color: #ef4444;
        }

        .comparison-card.new-design {
            background: rgba(34, 197, 94, 0.05);
            border-color: #22c55e;
        }

        .comparison-card h4 {
            margin-bottom: 1rem;
            font-size: 1.3rem;
        }

        .comparison-list {
            list-style: none;
            padding: 0;
        }

        .comparison-list li {
            padding: 0.5rem 0;
            padding-left: 1.5rem;
            position: relative;
        }

        

        .new-design .comparison-list li::before {
            content: '✅';
            position: absolute;
            left: 0;
        }

        .demo-tech-details {
            background: #f8fafc;
            padding: 3rem 2rem;
            border-radius: 20px;
            border: 1px solid #e2e8f0;
        }

        .demo-tech-details h3 {
            text-align: center;
            margin-bottom: 2rem;
            color: #1e293b;
            font-size: 1.8rem;
        }

        .tech-grid {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 2rem;
        }

        .tech-card {
            background: white;
            padding: 2rem;
            border-radius: 16px;
            text-align: center;
            border: 1px solid #e2e8f0;
            transition: all 0.3s ease;
        }

        .tech-card:hover {
            transform: translateY(-4px);
            box-shadow: 0 12px 25px rgba(0, 0, 0, 0.1);
        }

        .tech-card i {
            font-size: 3rem;
            margin-bottom: 1rem;
            color: #2563eb;
        }

        .tech-card h4 {
            margin-bottom: 0.5rem;
            color: #1e293b;
        }

        .tech-card p {
            color: #64748b;
            line-height: 1.5;
        }

        /* Responsive Design */
        @media (max-width: 768px) {
            .demo-header h1 {
                font-size: 2rem;
            }
            
            .comparison-grid {
                grid-template-columns: 1fr;
            }
            
            .control-group {
                flex-direction: column;
            }
            
            .demo-features {
                flex-direction: column;
                align-items: center;
            }
        }
    </style>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">
    Modern Navigation Demo
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
    <div class="demo-container">
        <!-- Demo Header -->
        <div class="demo-header">
            <h1>🚀 Modern Table of Contents Demo</h1>
            <p class="demo-subtitle">Experience the new responsive navigation system that replaces Telerik components</p>
            
            <div class="demo-features">
                <div class="feature-badge">
                    <i class="fas fa-mobile-alt"></i>
                    <span>Fully Responsive</span>
                </div>
                <div class="feature-badge">
                    <i class="fas fa-paint-brush"></i>
                    <span>Modern Design</span>
                </div>
                <div class="feature-badge">
                    <i class="fas fa-rocket"></i>
                    <span>No Telerik Dependency</span>
                </div>
                <div class="feature-badge">
                    <i class="fas fa-universal-access"></i>
                    <span>Accessible</span>
                </div>
            </div>
        </div>

        <!-- Controls Panel -->
        <div class="demo-controls">
            <h3>🎛️ Demo Controls</h3>
            <div class="control-group">
                <asp:Button ID="btnToggleTheme" runat="server" Text="🌙 Toggle Dark Mode" CssClass="demo-btn" OnClientClick="toggleDarkMode(); return false;" />
                <asp:Button ID="btnRefreshCards" runat="server" Text="🔄 Refresh Cards" CssClass="demo-btn" OnClick="btnRefreshCards_Click" />
                <asp:Button ID="btnSimulateLoading" runat="server" Text="⏳ Show Loading" CssClass="demo-btn" OnClientClick="simulateLoading(); return false;" />
            </div>
        </div>

        <!-- TableOfContents Component (Modernized) -->
        <div class="demo-component">
            <uc:ModernTOC ID="modernTOC" runat="server" />
        </div>

        <!-- Comparison Section -->
        <div class="demo-comparison">
            <h3>📊 Before vs After Comparison</h3>
            <div class="comparison-grid">
                <div class="comparison-card old-design">
                    <h4>❌ Old Telerik RadSiteMap</h4>
                    <ul class="comparison-list">
                        <li>Heavy Telerik dependency</li>
                        <li>Limited customization</li>
                        <li>Not mobile responsive</li>
                        <li>Fixed layout options</li>
                        <li>Complex styling overrides</li>
                    </ul>
                </div>
                <div class="comparison-card new-design">
                    <h4>✅ New Modern System</h4>
                    <ul class="comparison-list">
                        <li>Zero external dependencies</li>
                        <li>Fully customizable design</li>
                        <li>100% responsive layout</li>
                        <li>Modern card-based UI</li>
                        <li>Easy theme customization</li>
                    </ul>
                </div>
            </div>
        </div>

        <!-- Technical Details -->
        <div class="demo-tech-details">
            <h3>🔧 Technical Implementation</h3>
            <div class="tech-grid">
                <div class="tech-card">
                    <i class="fab fa-html5"></i>
                    <h4>Modern HTML5</h4>
                    <p>Semantic markup with accessibility in mind</p>
                </div>
                <div class="tech-card">
                    <i class="fab fa-css3-alt"></i>
                    <h4>Advanced CSS</h4>
                    <p>CSS Grid, Flexbox, animations, and custom properties</p>
                </div>
                <div class="tech-card">
                    <i class="fas fa-code"></i>
                    <h4>Clean VB.NET</h4>
                    <p>Optimized server-side rendering with error handling</p>
                </div>
                <div class="tech-card">
                    <i class="fas fa-universal-access"></i>
                    <h4>Accessibility</h4>
                    <p>WCAG compliant with keyboard navigation support</p>
                </div>
            </div>
        </div>
    </div>

    <script>
        // Dark mode toggle
        function toggleDarkMode() {
            const container = document.querySelector('.modern-toc-container');
            const body = document.body;
            
            if (body.classList.contains('dark-theme')) {
                body.classList.remove('dark-theme');
                container.classList.remove('dark-theme');
                document.getElementById('<%=btnToggleTheme.ClientID%>').innerHTML = '🌙 Toggle Dark Mode';
            } else {
                body.classList.add('dark-theme');
                container.classList.add('dark-theme');
                document.getElementById('<%=btnToggleTheme.ClientID%>').innerHTML = '☀️ Toggle Light Mode';
            }
        }

        // Simulate loading state
        function simulateLoading() {
            const cardGrid = document.getElementById('<%=modernTOC.FindControl("cardGrid").ClientID%>');
            const loadingContainer = document.getElementById('<%=modernTOC.FindControl("loadingContainer").ClientID%>');
            
            if (cardGrid && loadingContainer) {
                cardGrid.style.display = 'none';
                loadingContainer.style.display = 'block';
                
                setTimeout(() => {
                    loadingContainer.style.display = 'none';
                    cardGrid.style.display = 'grid';
                }, 3000);
            }
        }

        // Add entrance animations
        document.addEventListener('DOMContentLoaded', function() {
            const cards = document.querySelectorAll('.modern-nav-card');
            cards.forEach((card, index) => {
                card.style.animationDelay = (index * 0.1) + 's';
            });
        });
    </script>
</asp:Content>
