<%@ Page Language="VB" AutoEventWireup="true" CodeFile="MenuDemo.aspx.vb" Inherits="MenuDemo" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Advanced Menu Builder Demo - SKY ERP</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
    <!-- Enhanced Responsive Demo Integration -->
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css" rel="stylesheet" />
    <!-- Google Fonts -->
    <link href="https://fonts.googleapis.com/css2?family=Cairo:wght@300;400;500;600;700&display=swap" rel="stylesheet">
    <!-- Enhanced Responsive System -->
    <link rel="stylesheet" type="text/css" href="css/StyleSheet.css" />
    <script src="Scripts/responsive-pagemenubar-system.js"></script>
    <!-- Modern Navigation CSS -->
    <link rel="stylesheet" type="text/css" href="css/modern-navigation.css" />
    
    <style>
        body {
            font-family: 'Cairo', sans-serif;
            margin: 0;
            padding: 80px 20px 20px 20px;
            background: #f8fafc;
        }
        
        .demo-container {
            max-width: 1200px;
            margin: 0 auto;
        }
        
        .demo-section {
            background: white;
            border-radius: 12px;
            padding: 2rem;
            margin-bottom: 2rem;
            box-shadow: 0 4px 20px rgba(0,0,0,0.1);
        }
        
        .demo-title {
            color: #1f2937;
            margin-bottom: 1rem;
            border-bottom: 2px solid #2563eb;
            padding-bottom: 0.5rem;
        }
        
        .controls {
            display: flex;
            gap: 1rem;
            flex-wrap: wrap;
            margin-bottom: 2rem;
        }
        
        .btn {
            padding: 0.75rem 1.5rem;
            border: none;
            border-radius: 8px;
            background: #2563eb;
            color: white;
            cursor: pointer;
            font-weight: 600;
            transition: all 0.3s ease;
        }
        
        .btn:hover {
            background: #1d4ed8;
            transform: translateY(-2px);
        }
        
        .menu-preview {
            border: 1px solid #e5e7eb;
            border-radius: 8px;
            padding: 1rem;
            background: #f9fafb;
            overflow-x: auto;
        }
        
        .config-panel {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
            gap: 1rem;
            margin-bottom: 1rem;
        }
        
        .config-group {
            background: #f3f4f6;
            padding: 1rem;
            border-radius: 8px;
        }
        
        .config-group label {
            display: block;
            margin-bottom: 0.5rem;
            font-weight: 600;
            color: #374151;
        }
        
        .config-group input[type="checkbox"] {
            margin-right: 0.5rem;
        }
        
        .json-output {
            background: #1f2937;
            color: #f9fafb;
            padding: 1rem;
            border-radius: 8px;
            font-family: 'Courier New', monospace;
            font-size: 0.9rem;
            overflow-x: auto;
            white-space: pre-wrap;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <!-- Navigation will be injected here -->
        <asp:Literal ID="litNavigationDemo" runat="server" />
        
        <div class="demo-container">
            <div class="demo-section">
                <h1 class="demo-title">
                    <i class="fas fa-cogs"></i> Advanced Menu Builder Configuration Demo
                </h1>
                
                <div class="config-panel">
                    <div class="config-group">
                        <label>Display Options</label>
                        <div>
                            <input type="checkbox" id="chkShowIcons" runat="server" checked="true" />
                            <label for="chkShowIcons">Show Icons</label>
                        </div>
                        <div>
                            <input type="checkbox" id="chkEnableDropdowns" runat="server" checked="true" />
                            <label for="chkEnableDropdowns">Enable Dropdowns</label>
                        </div>
                        <div>
                            <input type="checkbox" id="chkTranslateTitles" runat="server" checked="true" />
                            <label for="chkTranslateTitles">Translate Menu Titles</label>
                        </div>
                    </div>
                    
                    <div class="config-group">
                        <label>Security Options</label>
                        <div>
                            <input type="checkbox" id="chkUseSecurity" runat="server" checked="true" />
                            <label for="chkUseSecurity">Use Role-Based Security</label>
                        </div>
                        <div>
                            <label for="ddlMaxDepth">Max Depth Level:</label>
                            <asp:DropDownList ID="ddlMaxDepth" runat="server">
                                <asp:ListItem Value="1">1 Level</asp:ListItem>
                                <asp:ListItem Value="2">2 Levels</asp:ListItem>
                                <asp:ListItem Value="3" Selected="True">3 Levels</asp:ListItem>
                                <asp:ListItem Value="4">4 Levels</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    
                    <div class="config-group">
                        <label>Theme Options</label>
                        <div>
                            <label for="ddlTheme">Select Theme:</label>
                            <asp:DropDownList ID="ddlTheme" runat="server">
                                <asp:ListItem Value="default" Selected="True">Default Blue</asp:ListItem>
                                <asp:ListItem Value="dark">Dark Theme</asp:ListItem>
                                <asp:ListItem Value="light">Light Theme</asp:ListItem>
                                <asp:ListItem Value="corporate">Corporate</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
                
                <div class="controls">
                    <asp:Button ID="btnUpdateMenu" runat="server" Text="Update Menu" CssClass="btn" OnClick="btnUpdateMenu_Click" />
                    <asp:Button ID="btnResetConfig" runat="server" Text="Reset to Default" CssClass="btn" OnClick="btnResetConfig_Click" />
                    <asp:Button ID="btnExportConfig" runat="server" Text="Export Configuration" CssClass="btn" OnClick="btnExportConfig_Click" />
                </div>
            </div>
            
            <div class="demo-section">
                <h2 class="demo-title">
                    <i class="fas fa-eye"></i> Menu Preview
                </h2>
                <div class="menu-preview">
                    <asp:Literal ID="litMenuPreview" runat="server" />
                </div>
            </div>
            
            <div class="demo-section">
                <h2 class="demo-title">
                    <i class="fas fa-code"></i> Generated Menu Data (JSON)
                </h2>
                <div class="json-output">
                    <asp:Literal ID="litMenuJson" runat="server" />
                </div>
            </div>
            
            <div class="demo-section">
                <h2 class="demo-title">
                    <i class="fas fa-info-circle"></i> Menu Builder Features
                </h2>
                <ul style="line-height: 1.8;">
                    <li><strong>Role-Based Security:</strong> Automatically filters menu items based on user roles from Web.Sitemap</li>
                    <li><strong>Dynamic Icon Mapping:</strong> Intelligent icon assignment based on menu titles</li>
                    <li><strong>Translation Support:</strong> Integrates with existing translation system</li>
                    <li><strong>Responsive Design:</strong> Mobile-first approach with collapsible navigation</li>
                    <li><strong>Customizable HTML:</strong> Full control over generated HTML structure</li>
                    <li><strong>Performance Optimized:</strong> Efficient sitemap traversal with caching</li>
                    <li><strong>Multi-Level Support:</strong> Configurable depth levels for complex hierarchies</li>
                    <li><strong>CSS Framework Agnostic:</strong> Works with any CSS framework</li>
                </ul>
            </div>
        </div>
        
        <script>
            // Enhanced Menu Demo Responsive System
            document.addEventListener('DOMContentLoaded', function() {
                console.log('Menu Demo Enhanced with Responsive System');
                
                // Initialize responsive system for demo
                if (typeof ResponsivePageMenuBar !== 'undefined') {
                    var responsiveDemo = new ResponsivePageMenuBar({
                        mobileBreakpoint: 768,
                        tabletBreakpoint: 1024,
                        enableKeyboardNavigation: true,
                        enableTouchSwipe: true,
                        customClasses: {
                            mobileToggle: 'demo-mobile-toggle',
                            mobileMenu: 'demo-mobile-menu',
                            dropdownToggle: 'demo-dropdown-toggle'
                        }
                    });
                    
                    responsiveDemo.init();
                    
                    // Add demo status indicator
                    var statusDiv = document.createElement('div');
                    statusDiv.style.cssText = `
                        position: fixed;
                        top: 20px;
                        left: 20px;
                        background: linear-gradient(135deg, #2563eb 0%, #1d4ed8 100%);
                        color: white;
                        padding: 8px 16px;
                        border-radius: 20px;
                        font-size: 0.8rem;
                        font-weight: 600;
                        z-index: 9999;
                        box-shadow: 0 4px 16px rgba(37, 99, 235, 0.3);
                        animation: slideInLeft 0.6s cubic-bezier(.4,0,.2,1);
                    `;
                    statusDiv.innerHTML = '<i class="fas fa-cogs"></i> Menu Demo Responsive ✓';
                    document.body.appendChild(statusDiv);
                    
                    console.log('Menu Demo Responsive System Initialized Successfully');
                }
                
                // Initialize modern navigation
                if (typeof window.modernNav !== 'undefined') {
                    console.log('Modern Navigation initialized successfully');
                }
                
                // Enhanced demo controls
                var demoButtons = document.querySelectorAll('.btn');
                demoButtons.forEach(function(btn) {
                    btn.addEventListener('click', function() {
                        this.style.transform = 'scale(0.95)';
                        setTimeout(() => {
                            this.style.transform = 'scale(1)';
                        }, 150);
                    });
                });
                
                // Add responsive detection for demo
                function updateDemoStatus() {
                    var width = window.innerWidth;
                    var statusText = '';
                    
                    if (width <= 768) {
                        statusText = 'Mobile View';
                    } else if (width <= 1024) {
                        statusText = 'Tablet View';
                    } else {
                        statusText = 'Desktop View';
                    }
                    
                    var existingStatus = document.querySelector('.demo-responsive-status');
                    if (!existingStatus) {
                        existingStatus = document.createElement('div');
                        existingStatus.className = 'demo-responsive-status';
                        existingStatus.style.cssText = `
                            position: fixed;
                            bottom: 20px;
                            right: 20px;
                            background: linear-gradient(135deg, #10b981 0%, #059669 100%);
                            color: white;
                            padding: 8px 16px;
                            border-radius: 20px;
                            font-size: 0.8rem;
                            font-weight: 600;
                            z-index: 9999;
                            box-shadow: 0 4px 16px rgba(16, 185, 129, 0.3);
                        `;
                        document.body.appendChild(existingStatus);
                    }
                    
                    existingStatus.innerHTML = `<i class="fas fa-eye"></i> ${statusText}`;
                }
                
                updateDemoStatus();
                window.addEventListener('resize', updateDemoStatus);
            });
        </script>
    </form>
</body>
</html>
