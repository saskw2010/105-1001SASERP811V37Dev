<%@ Page Language="VB" AutoEventWireup="true" CodeFile="resource-check.aspx.vb" Inherits="resource_check" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Resource Check - JavaScript and CSS Files</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <style>
        body { 
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; 
            margin: 0; 
            padding: 2rem;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
        }
        
        .container {
            max-width: 1200px;
            margin: 0 auto;
            background: white;
            border-radius: 16px;
            padding: 2rem;
            box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
        }
        
        .header {
            text-align: center;
            margin-bottom: 2rem;
            padding-bottom: 1rem;
            border-bottom: 2px solid #e2e8f0;
        }
        
        .resource-section {
            margin: 2rem 0;
            padding: 1.5rem;
            border: 1px solid #e2e8f0;
            border-radius: 12px;
            background: #f8fafc;
        }
        
        .resource-title {
            color: #2563eb;
            margin-bottom: 1rem;
            display: flex;
            align-items: center;
            gap: 0.5rem;
        }
        
        .resource-list {
            display: grid;
            grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
            gap: 1rem;
        }
        
        .resource-item {
            background: white;
            padding: 1rem;
            border-radius: 8px;
            border: 1px solid #e2e8f0;
            display: flex;
            align-items: center;
            gap: 0.5rem;
        }
        
        .status-icon {
            width: 20px;
            height: 20px;
            border-radius: 50%;
            display: flex;
            align-items: center;
            justify-content: center;
            color: white;
            font-size: 0.8rem;
        }
        
        .status-success { background: #10b981; }
        .status-error { background: #ef4444; }
        .status-warning { background: #f59e0b; }
        
        .test-button {
            background: linear-gradient(135deg, #2563eb, #3b82f6);
            color: white;
            border: none;
            padding: 1rem 2rem;
            border-radius: 8px;
            cursor: pointer;
            font-weight: 500;
            margin: 0.5rem;
        }
        
        .test-results {
            margin-top: 2rem;
            padding: 1rem;
            background: #f1f5f9;
            border-radius: 8px;
            white-space: pre-wrap;
            font-family: monospace;
            max-height: 400px;
            overflow-y: auto;
        }
        
        .hidden { display: none; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>🔍 Resource Check & Diagnostics</h1>
                <p>Checking JavaScript, CSS, and other resource files for 404 errors</p>
            </div>

            <!-- JavaScript Files -->
            <div class="resource-section">
                <h2 class="resource-title">
                    <span>📄</span>
                    JavaScript Files Status
                </h2>
                <div class="resource-list" id="jsFilesList">
                    <!-- JavaScript files will be populated here -->
                </div>
                <button type="button" class="test-button" onclick="checkJavaScriptFiles()">
                    Test JavaScript Files
                </button>
            </div>

            <!-- CSS Files -->
            <div class="resource-section">
                <h2 class="resource-title">
                    <span>🎨</span>
                    CSS Files Status
                </h2>
                <div class="resource-list" id="cssFilesList">
                    <!-- CSS files will be populated here -->
                </div>
                <button type="button" class="test-button" onclick="checkCSSFiles()">
                    Test CSS Files
                </button>
            </div>

            <!-- Other Resources -->
            <div class="resource-section">
                <h2 class="resource-title">
                    <span>🖼️</span>
                    Other Resources
                </h2>
                <div class="resource-list" id="otherResourcesList">
                    <!-- Other resources will be populated here -->
                </div>
                <button type="button" class="test-button" onclick="checkOtherResources()">
                    Test Other Resources
                </button>
            </div>

            <!-- Test Results -->
            <div class="resource-section">
                <h2 class="resource-title">
                    <span>📊</span>
                    Test Results
                </h2>
                <button type="button" class="test-button" onclick="runFullDiagnostics()">
                    Run Full Diagnostics
                </button>
                <button type="button" class="test-button" onclick="clearResults()">
                    Clear Results
                </button>
                <div id="testResults" class="test-results hidden"></div>
            </div>
        </div>
    </form>

    <script>
        // Resource lists
        const jsFiles = [
            'Scripts/jquery.min.js',
            'Scripts/bootstrap.min.js',
            'w3.js',
            'invjs/main.js',
            'invjs/main1.js',
            'invjs/main2.js',
            'invjs/main3.js',
            'invjs/main4.js',
            'invjs/mainhead.js',
            'invjs/notify.js',
            'Scripts/modern-navigation.js',
            'Scripts/modern-ui.js',
            'Scripts/user-info.js',
            'Scripts/advanced-system.js',
            'Scripts/modern-cards.js',
            'Scripts/ckeditor.js',
            'Scripts/error-handling.js'
        ];

        const cssFiles = [
            'css/StyleSheet.css',
            'css/AdvancedTheme.css',
            'css/SystemIntegration.css',
            'css/modern-navigation.css',
            'App_Themes/_Shared/ModernTheme.css',
            'App_Themes/_Shared/Integration.css'
        ];

        const otherResources = [
            'favicon.ico',
            'favicon.png'
        ];

        // Initialize page
        document.addEventListener('DOMContentLoaded', function() {
            populateResourceLists();
            log('Resource checker initialized');
        });

        function populateResourceLists() {
            // Populate JavaScript files
            const jsContainer = document.getElementById('jsFilesList');
            jsFiles.forEach(file => {
                const item = createResourceItem(file, 'js');
                jsContainer.appendChild(item);
            });

            // Populate CSS files
            const cssContainer = document.getElementById('cssFilesList');
            cssFiles.forEach(file => {
                const item = createResourceItem(file, 'css');
                cssContainer.appendChild(item);
            });

            // Populate other resources
            const otherContainer = document.getElementById('otherResourcesList');
            otherResources.forEach(file => {
                const item = createResourceItem(file, 'other');
                otherContainer.appendChild(item);
            });
        }

        function createResourceItem(filename, type) {
            const div = document.createElement('div');
            div.className = 'resource-item';
            div.id = 'resource-' + filename.replace(/[\/\.]/g, '-');
            
            div.innerHTML = `
                <div class="status-icon status-warning" id="status-${filename.replace(/[\/\.]/g, '-')}">?</div>
                <span>${filename}</span>
            `;
            
            return div;
        }

        function checkJavaScriptFiles() {
            log('Checking JavaScript files...');
            jsFiles.forEach(file => checkFile(file, 'js'));
        }

        function checkCSSFiles() {
            log('Checking CSS files...');
            cssFiles.forEach(file => checkFile(file, 'css'));
        }

        function checkOtherResources() {
            log('Checking other resources...');
            otherResources.forEach(file => checkFile(file, 'other'));
        }

        function checkFile(filename, type) {
            const statusId = 'status-' + filename.replace(/[\/\.]/g, '-');
            const statusElement = document.getElementById(statusId);
            
            fetch(filename)
                .then(response => {
                    if (response.ok) {
                        statusElement.className = 'status-icon status-success';
                        statusElement.textContent = '✓';
                        log(`✓ ${filename} - OK (${response.status})`);
                    } else {
                        statusElement.className = 'status-icon status-error';
                        statusElement.textContent = '✗';
                        log(`✗ ${filename} - Error ${response.status}`);
                    }
                })
                .catch(error => {
                    statusElement.className = 'status-icon status-error';
                    statusElement.textContent = '✗';
                    log(`✗ ${filename} - Network Error: ${error.message}`);
                });
        }

        function runFullDiagnostics() {
            log('=== FULL DIAGNOSTICS STARTED ===');
            log('Timestamp: ' + new Date().toISOString());
            log('');
            
            // Check browser info
            log('Browser Info:');
            log('User Agent: ' + navigator.userAgent);
            log('Platform: ' + navigator.platform);
            log('');
            
            // Check loaded scripts
            log('Currently Loaded Scripts:');
            const scripts = document.querySelectorAll('script[src]');
            scripts.forEach(script => {
                log('- ' + script.src);
            });
            log('');
            
            // Check loaded stylesheets
            log('Currently Loaded Stylesheets:');
            const stylesheets = document.querySelectorAll('link[rel="stylesheet"]');
            stylesheets.forEach(link => {
                log('- ' + link.href);
            });
            log('');
            
            // Check global objects
            log('Global JavaScript Objects:');
            log('- jQuery: ' + (typeof $ !== 'undefined' ? 'Available' : 'Missing'));
            log('- w3: ' + (typeof w3 !== 'undefined' ? 'Available' : 'Missing'));
            log('- Bootstrap: ' + (typeof bootstrap !== 'undefined' ? 'Available' : 'Missing'));
            log('');
            
            // Test all files
            checkJavaScriptFiles();
            checkCSSFiles();
            checkOtherResources();
            
            log('=== DIAGNOSTICS COMPLETE ===');
        }

        function clearResults() {
            const results = document.getElementById('testResults');
            results.textContent = '';
            results.classList.add('hidden');
        }

        function log(message) {
            const results = document.getElementById('testResults');
            results.classList.remove('hidden');
            results.textContent += message + '\n';
            results.scrollTop = results.scrollHeight;
            console.log(message);
        }
    </script>
</body>
</html>
