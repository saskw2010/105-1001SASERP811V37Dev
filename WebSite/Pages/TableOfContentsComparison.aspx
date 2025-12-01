<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeFile="TableOfContentsComparison.aspx.vb" Inherits="Pages_TableOfContentsComparison" Title="TableOfContents Comparison" %>
<%@ Register Src="../Controls/TableOfContents.ascx" TagName="OriginalTOC" TagPrefix="uc" %>
<%@ Register Src="../Controls/TableOfContentsajar.ascx" TagName="AjarTOC" TagPrefix="uc" %>
<%@ Register Src="../Controls/ModernTOC.ascx" TagName="ModernTOC" TagPrefix="uc" %>
<%@ Register Src="../Controls/ModernAjarTOC.ascx" TagName="ModernAjarTOC" TagPrefix="uc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">
    TableOfContents Comparison
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
    <div class="comparison-container">
        <!-- Page Header -->
        <div class="comparison-header">
            <h1>🔍 TableOfContents Controls Comparison</h1>
            <p class="subtitle">Compare all available TableOfContents implementations in the system</p>
            
            <div class="comparison-stats">
                <div class="stat-card">
                    <i class="fas fa-layer-group"></i>
                    <span class="stat-number">4</span>
                    <span class="stat-label">Total Controls</span>
                </div>
                <div class="stat-card">
                    <i class="fas fa-rocket"></i>
                    <span class="stat-number">2</span>
                    <span class="stat-label">Modern Versions</span>
                </div>
                <div class="stat-card">
                    <i class="fas fa-mobile-alt"></i>
                    <span class="stat-number">100%</span>
                    <span class="stat-label">Responsive</span>
                </div>
            </div>
        </div>

        <!-- Navigation Tabs -->
        <div class="comparison-tabs">
            <button class="tab-btn active" onclick="showComparison('original')" id="btnOriginal">
                <i class="fas fa-archive"></i>
                Original TableOfContents
            </button>
            <button class="tab-btn" onclick="showComparison('ajar')" id="btnAjar">
                <i class="fas fa-layer-group"></i>
                TableOfContentsajar
            </button>
            <button class="tab-btn" onclick="showComparison('modern')" id="btnModern">
                <i class="fas fa-rocket"></i>
                Modern TableOfContents
            </button>
            <button class="tab-btn" onclick="showComparison('modern-ajar')" id="btnModernAjar">
                <i class="fas fa-star"></i>
                Modern TableOfContentsajar
            </button>
            <button class="tab-btn" onclick="showComparison('all')" id="btnAll">
                <i class="fas fa-th"></i>
                Show All
            </button>
        </div>

        <!-- Comparison Content -->
        <div class="comparison-content">
            <!-- Original TableOfContents -->
            <div id="comparison-original" class="comparison-section active">
                <div class="section-header">
                    <h2>📜 Original TableOfContents.ascx</h2>
                    <div class="section-badges">
                        <span class="badge telerik">Uses Telerik</span>
                        <span class="badge legacy">Legacy</span>
                        <span class="badge functional">Functional</span>
                    </div>
                </div>
                <div class="section-description">
                    <p><strong>Description:</strong> The original TableOfContents control using Telerik RadSiteMap with image overlay design.</p>
                    <p><strong>Used in:</strong> Home.aspx and other main pages</p>
                    <p><strong>Features:</strong> 3-column layout, image cards, translation support</p>
                </div>
                <div class="control-container">
                    <uc:OriginalTOC ID="originalTOC" runat="server" />
                </div>
            </div>

            <!-- TableOfContentsajar -->
            <div id="comparison-ajar" class="comparison-section">
                <div class="section-header">
                    <h2>⚡ TableOfContentsajar.ascx</h2>
                    <div class="section-badges">
                        <span class="badge telerik">Uses Telerik</span>
                        <span class="badge dynamic">Dynamic</span>
                        <span class="badge simple">Simplified</span>
                    </div>
                </div>
                <div class="section-description">
                    <p><strong>Description:</strong> Simplified version with header decoration and similar card layout.</p>
                    <p><strong>Used in:</strong> Dynamically loaded through SharedBusinessRules.vb</p>
                    <p><strong>Features:</strong> Header with title, same card design but simpler code</p>
                </div>
                <div class="control-container">
                    <uc:AjarTOC ID="ajarTOC" runat="server" />
                </div>
            </div>

            <!-- Modern TableOfContents -->
            <div id="comparison-modern" class="comparison-section">
                <div class="section-header">
                    <h2>🚀 Modern TableOfContents.ascx</h2>
                    <div class="section-badges">
                        <span class="badge modern">No Telerik</span>
                        <span class="badge responsive">Responsive</span>
                        <span class="badge animated">Animated</span>
                    </div>
                </div>
                <div class="section-description">
                    <p><strong>Description:</strong> Complete modern replacement with CSS Grid, animations, and responsive design.</p>
                    <p><strong>Used in:</strong> New modern pages and as replacement for original</p>
                    <p><strong>Features:</strong> Responsive grid, hover effects, loading states, no dependencies</p>
                </div>
                <div class="control-container">
                    <uc:ModernTOC ID="modernTOC" runat="server" />
                </div>
            </div>

            <!-- Modern TableOfContentsajar -->
            <div id="comparison-modern-ajar" class="comparison-section">
                <div class="section-header">
                    <h2>⭐ Modern TableOfContentsajar.ascx</h2>
                    <div class="section-badges">
                        <span class="badge premium">Premium</span>
                        <span class="badge enhanced">Enhanced</span>
                        <span class="badge future">Future-Ready</span>
                    </div>
                </div>
                <div class="section-description">
                    <p><strong>Description:</strong> Advanced modern version with premium design, orbital loading, and enhanced interactions.</p>
                    <p><strong>Used in:</strong> High-end applications and premium sections</p>
                    <p><strong>Features:</strong> Gradient header, orbital loading, enhanced cards, scroll animations</p>
                </div>
                <div class="control-container">
                    <uc:ModernAjarTOC ID="modernAjarTOC" runat="server" />
                </div>
            </div>

            <!-- Show All -->
            <div id="comparison-all" class="comparison-section">
                <div class="section-header">
                    <h2>🔍 All Controls Side by Side</h2>
                    <div class="section-badges">
                        <span class="badge info">Comparison Mode</span>
                    </div>
                </div>
                <div class="all-controls-grid">
                    <div class="mini-control">
                        <h3>Original</h3>
                        <div class="mini-container">
                            <uc:OriginalTOC ID="originalTOCMini" runat="server" />
                        </div>
                    </div>
                    <div class="mini-control">
                        <h3>Ajar</h3>
                        <div class="mini-container">
                            <uc:AjarTOC ID="ajarTOCMini" runat="server" />
                        </div>
                    </div>
                    <div class="mini-control">
                        <h3>Modern</h3>
                        <div class="mini-container">
                            <uc:ModernTOC ID="modernTOCMini" runat="server" />
                        </div>
                    </div>
                    <div class="mini-control">
                        <h3>Modern Ajar</h3>
                        <div class="mini-container">
                            <uc:ModernAjarTOC ID="modernAjarTOCMini" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Technical Comparison Table -->
        <div class="technical-comparison">
            <h2>📊 Technical Comparison</h2>
            <div class="comparison-table-container">
                <table class="comparison-table">
                    <thead>
                        <tr>
                            <th>Feature</th>
                            <th>Original</th>
                            <th>Ajar</th>
                            <th>Modern</th>
                            <th>Modern Ajar</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><strong>Telerik Dependency</strong></td>
                            <td><span class="status negative">Yes</span></td>
                            <td><span class="status negative">Yes</span></td>
                            <td><span class="status positive">No</span></td>
                            <td><span class="status positive">No</span></td>
                        </tr>
                        <tr>
                            <td><strong>Responsive Design</strong></td>
                            <td><span class="status partial">Partial</span></td>
                            <td><span class="status partial">Partial</span></td>
                            <td><span class="status positive">Full</span></td>
                            <td><span class="status positive">Full</span></td>
                        </tr>
                        <tr>
                            <td><strong>Modern Animations</strong></td>
                            <td><span class="status negative">No</span></td>
                            <td><span class="status negative">No</span></td>
                            <td><span class="status positive">Yes</span></td>
                            <td><span class="status positive">Advanced</span></td>
                        </tr>
                        <tr>
                            <td><strong>Loading States</strong></td>
                            <td><span class="status negative">No</span></td>
                            <td><span class="status negative">No</span></td>
                            <td><span class="status positive">Basic</span></td>
                            <td><span class="status positive">Advanced</span></td>
                        </tr>
                        <tr>
                            <td><strong>Dark Mode Support</strong></td>
                            <td><span class="status negative">No</span></td>
                            <td><span class="status negative">No</span></td>
                            <td><span class="status positive">Yes</span></td>
                            <td><span class="status positive">Yes</span></td>
                        </tr>
                        <tr>
                            <td><strong>Accessibility</strong></td>
                            <td><span class="status partial">Basic</span></td>
                            <td><span class="status partial">Basic</span></td>
                            <td><span class="status positive">Good</span></td>
                            <td><span class="status positive">Excellent</span></td>
                        </tr>
                        <tr>
                            <td><strong>Performance</strong></td>
                            <td><span class="status partial">Medium</span></td>
                            <td><span class="status positive">Good</span></td>
                            <td><span class="status positive">Excellent</span></td>
                            <td><span class="status positive">Excellent</span></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>

        <!-- Recommendations -->
        <div class="recommendations">
            <h2>💡 Recommendations</h2>
            <div class="recommendation-cards">
                <div class="recommendation-card">
                    <div class="recommendation-icon">
                        <i class="fas fa-rocket"></i>
                    </div>
                    <h3>For New Projects</h3>
                    <p>Use <strong>ModernTableOfContents.ascx</strong> for new implementations. It provides the best balance of features, performance, and maintainability.</p>
                </div>
                <div class="recommendation-card">
                    <div class="recommendation-icon">
                        <i class="fas fa-star"></i>
                    </div>
                    <h3>For Premium Applications</h3>
                    <p>Use <strong>ModernTableOfContentsajar.ascx</strong> when you need the most advanced features and premium visual design.</p>
                </div>
                <div class="recommendation-card">
                    <div class="recommendation-icon">
                        <i class="fas fa-tools"></i>
                    </div>
                    <h3>For Legacy Support</h3>
                    <p>Keep existing <strong>TableOfContents.ascx</strong> for backward compatibility while gradually migrating to modern versions.</p>
                </div>
            </div>
        </div>
    </div>

    <script>
        function showComparison(type) {
            // Hide all sections
            const sections = document.querySelectorAll('.comparison-section');
            sections.forEach(section => section.classList.remove('active'));
            
            // Remove active class from all tabs
            const tabs = document.querySelectorAll('.tab-btn');
            tabs.forEach(tab => tab.classList.remove('active'));
            
            // Show selected section
            const targetSection = document.getElementById('comparison-' + type);
            if (targetSection) {
                targetSection.classList.add('active');
            }
            
            // Add active class to clicked tab
            const activeTab = document.getElementById('btn' + type.split('-').map(word => word.charAt(0).toUpperCase() + word.slice(1)).join(''));
            if (activeTab) {
                activeTab.classList.add('active');
            }
        }

        // Add smooth scrolling and animations
        document.addEventListener('DOMContentLoaded', function() {
            // Animate stats on load
            const stats = document.querySelectorAll('.stat-number');
            stats.forEach((stat, index) => {
                setTimeout(() => {
                    stat.style.transform = 'scale(1.2)';
                    setTimeout(() => {
                        stat.style.transform = 'scale(1)';
                    }, 200);
                }, index * 100);
            });
        });
    </script>

    <style>
    /* Comparison Page Styles */
    .comparison-container {
    max-width: 1400px;
    margin: 0 auto;
    padding: 2rem 1rem;
}

.comparison-header {
    text-align: center;
    margin-bottom: 3rem;
    padding: 3rem 2rem;
    background: linear-gradient(135deg, rgba(37, 99, 235, 0.1) 0%, rgba(147, 51, 234, 0.1) 100%);
    border-radius: 20px;
    border: 1px solid rgba(37, 99, 235, 0.2);
}

.comparison-header h1 {
    font-size: 2.5rem;
    font-weight: 700;
    background: linear-gradient(135deg, #2563eb 0%, #7c3aed 100%);
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
    background-clip: text;
    margin-bottom: 1rem;
}

.subtitle {
    font-size: 1.2rem;
    color: #64748b;
    margin-bottom: 2rem;
}

.comparison-stats {
    display: flex;
    justify-content: center;
    gap: 2rem;
    flex-wrap: wrap;
}

.stat-card {
    display: flex;
    flex-direction: column;
    align-items: center;
    padding: 1.5rem;
    background: white;
    border-radius: 16px;
    border: 1px solid rgba(37, 99, 235, 0.1);
    min-width: 120px;
    transition: transform 0.3s ease;
}

.stat-card:hover {
    transform: translateY(-4px);
    box-shadow: 0 8px 25px rgba(37, 99, 235, 0.1);
}

.stat-card i {
    font-size: 2rem;
    color: #2563eb;
    margin-bottom: 0.5rem;
}

.stat-number {
    font-size: 2rem;
    font-weight: 700;
    color: #1e293b;
    transition: transform 0.3s ease;
}

.stat-label {
    font-size: 0.9rem;
    color: #64748b;
    text-align: center;
}

.comparison-tabs {
    display: flex;
    gap: 0.5rem;
    margin-bottom: 3rem;
    flex-wrap: wrap;
    justify-content: center;
}

.tab-btn {
    padding: 1rem 1.5rem;
    background: white;
    border: 1px solid #e2e8f0;
    border-radius: 12px;
    cursor: pointer;
    transition: all 0.3s ease;
    display: flex;
    align-items: center;
    gap: 0.5rem;
    font-weight: 500;
    color: #64748b;
}

.tab-btn:hover {
    background: rgba(37, 99, 235, 0.05);
    border-color: rgba(37, 99, 235, 0.2);
    color: #2563eb;
}

.tab-btn.active {
    background: linear-gradient(135deg, #2563eb, #3b82f6);
    color: white;
    border-color: #2563eb;
    transform: translateY(-2px);
    box-shadow: 0 4px 15px rgba(37, 99, 235, 0.3);
}

.comparison-section {
    display: none;
    margin-bottom: 3rem;
}

.comparison-section.active {
    display: block;
    animation: fadeInUp 0.5s ease-out;
}

@keyframes fadeInUp {
    from {
        opacity: 0;
        transform: translateY(20px);
    }
    to {
        opacity: 1;
        transform: translateY(0);
    }
}

.section-header {
    display: flex;
    align-items: center;
    justify-content: space-between;
    margin-bottom: 1rem;
    flex-wrap: wrap;
    gap: 1rem;
}

.section-header h2 {
    color: #1e293b;
    margin: 0;
}

.section-badges {
    display: flex;
    gap: 0.5rem;
    flex-wrap: wrap;
}

.badge {
    padding: 0.25rem 0.75rem;
    border-radius: 50px;
    font-size: 0.8rem;
    font-weight: 500;
    text-transform: uppercase;
    letter-spacing: 0.5px;
}

.badge.telerik { background: #ef4444; color: white; }
.badge.legacy { background: #f59e0b; color: white; }
.badge.functional { background: #10b981; color: white; }
.badge.dynamic { background: #8b5cf6; color: white; }
.badge.simple { background: #06b6d4; color: white; }
.badge.modern { background: #059669; color: white; }
.badge.responsive { background: #0ea5e9; color: white; }
.badge.animated { background: #ec4899; color: white; }
.badge.premium { background: #7c3aed; color: white; }
.badge.enhanced { background: #f59e0b; color: white; }
.badge.future { background: #059669; color: white; }
.badge.info { background: #64748b; color: white; }

.section-description {
    background: #f8fafc;
    padding: 1.5rem;
    border-radius: 12px;
    margin-bottom: 2rem;
    border-left: 4px solid #2563eb;
}

.section-description p {
    margin: 0.5rem 0;
    color: #64748b;
}

.control-container {
    background: white;
    border: 1px solid #e2e8f0;
    border-radius: 16px;
    overflow: hidden;
    box-shadow: 0 4px 15px rgba(0, 0, 0, 0.05);
}

.all-controls-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    gap: 2rem;
}

.mini-control {
    border: 1px solid #e2e8f0;
    border-radius: 12px;
    overflow: hidden;
}

.mini-control h3 {
    background: linear-gradient(135deg, #2563eb, #3b82f6);
    color: white;
    padding: 1rem;
    margin: 0;
    text-align: center;
    font-size: 1rem;
}

.mini-container {
    padding: 1rem;
    max-height: 400px;
    overflow-y: auto;
}

.technical-comparison {
    margin: 4rem 0;
}

.technical-comparison h2 {
    text-align: center;
    margin-bottom: 2rem;
    color: #1e293b;
}

.comparison-table-container {
    overflow-x: auto;
    background: white;
    border-radius: 16px;
    border: 1px solid #e2e8f0;
    box-shadow: 0 4px 15px rgba(0, 0, 0, 0.05);
}

.comparison-table {
    width: 100%;
    border-collapse: collapse;
}

.comparison-table th,
.comparison-table td {
    padding: 1rem;
    text-align: left;
    border-bottom: 1px solid #e2e8f0;
}

.comparison-table th {
    background: linear-gradient(135deg, #f8fafc, #f1f5f9);
    font-weight: 600;
    color: #1e293b;
}

.status {
    padding: 0.25rem 0.75rem;
    border-radius: 50px;
    font-size: 0.8rem;
    font-weight: 500;
}

.status.positive { background: #dcfce7; color: #166534; }
.status.negative { background: #fef2f2; color: #dc2626; }
.status.partial { background: #fef3c7; color: #d97706; }

.recommendations {
    margin: 4rem 0;
}

.recommendations h2 {
    text-align: center;
    margin-bottom: 2rem;
    color: #1e293b;
}

.recommendation-cards {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    gap: 2rem;
}

.recommendation-card {
    background: white;
    padding: 2rem;
    border-radius: 16px;
    border: 1px solid #e2e8f0;
    text-align: center;
    transition: transform 0.3s ease, box-shadow 0.3s ease;
}

.recommendation-card:hover {
    transform: translateY(-4px);
    box-shadow: 0 12px 30px rgba(0, 0, 0, 0.1);
}

.recommendation-icon {
    width: 60px;
    height: 60px;
    background: linear-gradient(135deg, #2563eb, #3b82f6);
    border-radius: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    margin: 0 auto 1rem auto;
    color: white;
    font-size: 1.5rem;
}

.recommendation-card h3 {
    color: #1e293b;
    margin-bottom: 1rem;
}

.recommendation-card p {
    color: #64748b;
    line-height: 1.6;
}

/* Responsive Design */
@media (max-width: 768px) {
    .comparison-header h1 {
        font-size: 2rem;
    }
    
    .comparison-stats {
        flex-direction: column;
        align-items: center;
    }
    
    .section-header {
        flex-direction: column;
        align-items: flex-start;
    }
    
    .all-controls-grid {
        grid-template-columns: 1fr;
    }
}
</style>
</asp:Content>
