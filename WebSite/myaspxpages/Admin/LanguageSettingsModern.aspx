<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LanguageSettingsModern.aspx.cs" Inherits="myaspxpages_Admin_LanguageSettingsModern" MasterPageFile="~/Main.master" %>

<asp:Content ID="TitleContent" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="server">
    Language Settings
</asp:Content>

<asp:Content ID="PageContent" ContentPlaceHolderID="PageContentPlaceHolder" runat="server">
   <!-- External CSS and JS -->
   <link rel="stylesheet" href='<%= ResolveUrl("~/myaspxpages/css/sweetalert2.min.css") %>' />
   <link rel="stylesheet" href='<%= ResolveUrl("~/myaspxpages/css/modern-page-styles.css") %>' />
   <script src='<%= ResolveUrl("~/myaspxpages/js/sweetalert2.all.min.js") %>'></script>
   
   <div class="main-container" data-app-role="page" data-content-framework="bootstrap">
    <!-- Header -->
        <div class="page-header">
            <h1>
                <i class="fas fa-language"></i>
                <asp:Label ID="lblHeader" runat="server" />
            </h1>
            <p><asp:Label ID="lblDescription" runat="server" /></p>
        </div>

        <!-- Statistics Cards -->
        <div class="stats-row">
            <div class="stat-card">
                <i class="fas fa-globe"></i>
                <h3 id="totalCount">0</h3>
                <p><asp:Label ID="lblTotalLabel" runat="server" /></p>
            </div>
            <div class="stat-card success">
                <i class="fas fa-check-circle"></i>
                <h3 id="enabledCount">0</h3>
                <p><asp:Label ID="lblEnabledLabel" runat="server" /></p>
            </div>
            <div class="stat-card warning">
                <i class="fas fa-times-circle"></i>
                <h3 id="disabledCount">0</h3>
                <p><asp:Label ID="lblDisabledLabel" runat="server" /></p>
            </div>
        </div>

        <!-- Loading Spinner -->
        <div class="loading-spinner" id="loadingSpinner">
            <div class="spinner"></div>
            <p>Loading languages...</p>
        </div>

        <!-- Languages Grid (Client-side rendered) -->
        <div class="languages-grid" id="languagesGrid"></div>

        <!-- Action Buttons -->
        <div class="action-buttons">
            <button type="button" class="btn btn-secondary" onclick="enableAllLanguages()">
                <i class="fas fa-check-double"></i>
                <asp:Label ID="lblEnableAll" runat="server" />
            </button>
            <button type="button" class="btn btn-danger" onclick="disableAllLanguages()">
                <i class="fas fa-ban"></i>
                <asp:Label ID="lblDisableAll" runat="server" />
            </button>
            <button type="button" class="btn btn-primary" id="btnSave" onclick="saveLanguages()">
                <i class="fas fa-save"></i>
                <asp:Label ID="lblSaveBtn" runat="server" />
            </button>
        </div>
    </div>

    <script>
        // ============================================
        // Global State
        // ============================================
        let languagesData = [];
        const API_ENDPOINT = '<%= ResolveUrl("~/myaspxpages/Admin/languages.ashx") %>';
        const CACHE_KEY = 'languageSettings_cache';
        const CACHE_DURATION = 60 * 60 * 1000; // 1 hour in milliseconds

        // Group translations
        const groupNames = {
            'primary': 'Primary Languages',
            'european': 'European Languages',
            'asian': 'Asian Languages',
            'slavic': 'Slavic Languages',
            'middleEast': 'Middle Eastern Languages',
            'african': 'African Languages',
            'new': 'New Languages'
        };

        // ============================================
        // Initialization
        // ============================================
        document.addEventListener('DOMContentLoaded', function() {
            console.log('🚀 Modern Language Settings loaded');
            console.log('📍 API Endpoint:', API_ENDPOINT);
            loadLanguages();
        });

        // ============================================
        // Load Languages (localStorage + API)
        // ============================================
        async function loadLanguages() {
            showLoading(true);

            try {
                // Try localStorage first
                const cached = getCachedData();
                if (cached) {
                    console.log('📦 Using cached data');
                    languagesData = cached.data;
                    renderLanguages();
                    updateStatistics(cached.statistics);
                    showLoading(false);
                    
                    // Refresh in background
                    fetchFromAPI(true);
                    return;
                }

                // Fetch from API
                await fetchFromAPI(false);
            } catch (error) {
                console.error('❌ Load error:', error);
                showError('Failed to load languages: ' + error.message);
                showLoading(false);
            }
        }

        // ============================================
        // Fetch from API
        // ============================================
        async function fetchFromAPI(background = false) {
            try {
                console.log('🌐 Fetching from API:', API_ENDPOINT);
                
                const response = await fetch(API_ENDPOINT, {
                    method: 'GET',
                    headers: { 'Content-Type': 'application/json' },
                    cache: 'no-cache'
                });

                console.log('📡 Response status:', response.status, response.statusText);

                if (!response.ok) {
                    throw new Error(`HTTP ${response.status}: ${response.statusText}`);
                }

                const result = await response.json();
                
                if (result.success) {
                    languagesData = result.data;
                    
                    // Cache the data
                    setCachedData(result);
                    
                    if (!background) {
                        renderLanguages();
                        updateStatistics(result.statistics);
                        showLoading(false);
                    }
                    
                    console.log('✅ Loaded', languagesData.length, 'languages from API');
                } else {
                    throw new Error(result.error || 'Unknown API error');
                }
            } catch (error) {
                console.error('❌ API fetch error:', error);
                if (!background) {
                    throw error;
                }
            }
        }

        // ============================================
        // Render Languages Grid
        // ============================================
        function renderLanguages() {
            const grid = document.getElementById('languagesGrid');
            grid.innerHTML = '';

            // Group languages
            const grouped = {};
            languagesData.forEach(lang => {
                const group = lang.group || 'other';
                if (!grouped[group]) grouped[group] = [];
                grouped[group].push(lang);
            });

            // Render each group
            const groupOrder = ['primary', 'european', 'asian', 'slavic', 'middleEast', 'african', 'new'];
            groupOrder.forEach(groupKey => {
                if (!grouped[groupKey]) return;

                // Group header
                const header = document.createElement('div');
                header.className = 'group-header';
                header.textContent = groupNames[groupKey] || groupKey;
                grid.appendChild(header);

                // Language cards
                grouped[groupKey].forEach(lang => {
                    const card = createLanguageCard(lang);
                    grid.appendChild(card);
                });
            });
        }

        // ============================================
        // Create Language Card
        // ============================================
        function createLanguageCard(lang) {
            const card = document.createElement('div');
            card.className = `language-card ${lang.enabled ? 'enabled' : 'disabled'}`;
            card.dataset.code = lang.code;

            card.innerHTML = `
                <div class="language-header">
                    <span class="language-flag">${lang.flag}</span>
                    <div class="language-info">
                        <div class="language-name">
                            ${lang.displayName}
                            ${lang.isNew ? '<span class="badge-new">NEW</span>' : ''}
                        </div>
                        <div class="language-code">${lang.code}</div>
                    </div>
                    <input type="checkbox" 
                           class="language-toggle" 
                           ${lang.enabled ? 'checked' : ''} 
                           onchange="toggleLanguage('${lang.code}', this.checked)">
                </div>
            `;

            return card;
        }

        // ============================================
        // Toggle Language
        // ============================================
        function toggleLanguage(code, enabled) {
            const lang = languagesData.find(l => l.code === code);
            if (lang) {
                lang.enabled = enabled;
                
                // Update card appearance
                const card = document.querySelector(`[data-code="${code}"]`);
                if (card) {
                    card.className = `language-card ${enabled ? 'enabled' : 'disabled'}`;
                }
                
                // Update statistics
                const stats = calculateStatistics();
                updateStatistics(stats);
                
                // Mark as dirty
                console.log(`🔄 ${code} ${enabled ? 'enabled' : 'disabled'}`);
            }
        }

        // ============================================
        // Save Languages
        // ============================================
        async function saveLanguages() {
            const btn = document.getElementById('btnSave');
            const originalText = btn.innerHTML;

            try {
                // Confirm with SweetAlert
                const result = await Swal.fire({
                    title: 'تأكيد الحفظ',
                    text: 'هل تريد حفظ التغييرات؟',
                    icon: 'question',
                    showCancelButton: true,
                    confirmButtonColor: '#48bb78',
                    cancelButtonColor: '#d33',
                    confirmButtonText: '💾 نعم، احفظ',
                    cancelButtonText: '❌ إلغاء'
                });

                if (!result.isConfirmed) return;

                // Disable button
                btn.disabled = true;
                btn.innerHTML = '<i class="fas fa-spinner fa-spin"></i> جاري الحفظ...';

                // Prepare payload
                const payload = {
                    languages: languagesData.map(l => ({
                        code: l.code,
                        enabled: l.enabled
                    }))
                };

                // POST to API
                const response = await fetch(API_ENDPOINT, {
                    method: 'POST',
                    headers: { 'Content-Type': 'application/json' },
                    body: JSON.stringify(payload)
                });

                console.log('📡 Save response status:', response.status, response.statusText);

                if (!response.ok) {
                    // Try to get error details from response
                    const errorText = await response.text();
                    console.error('❌ Server error response:', errorText);
                    throw new Error(`HTTP ${response.status}: ${response.statusText}\nDetails: ${errorText.substring(0, 200)}`);
                }

                const apiResult = await response.json();

                if (apiResult.success) {
                    // Clear cache to force refresh
                    clearCache();
                    
                    // Update localStorage with new state
                    const stats = calculateStatistics();
                    setCachedData({ data: languagesData, statistics: stats, timestamp: new Date().toISOString() });
                    
                    // Success message
                    await Swal.fire({
                        title: 'تم الحفظ بنجاح!',
                        text: `تم تحديث ${apiResult.updated} لغة`,
                        icon: 'success',
                        confirmButtonColor: '#48bb78',
                        timer: 2000
                    });

                    console.log('✅ Saved successfully:', apiResult.updated, 'languages');
                } else {
                    throw new Error(apiResult.error || 'Save failed');
                }
            } catch (error) {
                console.error('❌ Save error:', error);
                console.error('Error details:', {
                    message: error.message,
                    stack: error.stack,
                    type: error.constructor.name
                });
                
                // Check if Swal is available
                if (typeof Swal === 'undefined') {
                    alert('خطأ! فشل في حفظ التغييرات: ' + error.message);
                } else {
                    await Swal.fire({
                        title: 'خطأ!',
                        text: 'فشل في حفظ التغييرات: ' + error.message,
                        icon: 'error',
                        confirmButtonColor: '#dc3545'
                    });
                }
            } finally {
                btn.disabled = false;
                btn.innerHTML = originalText;
            }
        }

        // ============================================
        // Enable/Disable All
        // ============================================
        function enableAllLanguages() {
            languagesData.forEach(lang => lang.enabled = true);
            renderLanguages();
            const stats = calculateStatistics();
            updateStatistics(stats);
        }

        function disableAllLanguages() {
            languagesData.forEach(lang => lang.enabled = false);
            renderLanguages();
            const stats = calculateStatistics();
            updateStatistics(stats);
        }

        // ============================================
        // Statistics
        // ============================================
        function calculateStatistics() {
            return {
                total: languagesData.length,
                enabled: languagesData.filter(l => l.enabled).length,
                disabled: languagesData.filter(l => !l.enabled).length
            };
        }

        function updateStatistics(stats) {
            document.getElementById('totalCount').textContent = stats.total;
            document.getElementById('enabledCount').textContent = stats.enabled;
            document.getElementById('disabledCount').textContent = stats.disabled;
        }

        // ============================================
        // localStorage Cache Management
        // ============================================
        function getCachedData() {
            try {
                const cached = localStorage.getItem(CACHE_KEY);
                if (!cached) return null;

                const parsed = JSON.parse(cached);
                const age = Date.now() - new Date(parsed.timestamp).getTime();

                if (age > CACHE_DURATION) {
                    console.log('⏰ Cache expired, will fetch fresh data');
                    localStorage.removeItem(CACHE_KEY);
                    return null;
                }

                return parsed;
            } catch (error) {
                console.warn('⚠️ Cache read error:', error);
                return null;
            }
        }

        function setCachedData(data) {
            try {
                const payload = {
                    data: data.data,
                    statistics: data.statistics,
                    timestamp: data.timestamp || new Date().toISOString()
                };
                localStorage.setItem(CACHE_KEY, JSON.stringify(payload));
                console.log('💾 Data cached successfully');
            } catch (error) {
                console.warn('⚠️ Cache write error:', error);
            }
        }

        function clearCache() {
            localStorage.removeItem(CACHE_KEY);
            console.log('🗑️ Cache cleared');
        }

        // ============================================
        // UI Helpers
        // ============================================
        function showLoading(show) {
            const spinner = document.getElementById('loadingSpinner');
            const grid = document.getElementById('languagesGrid');
            
            if (show) {
                spinner.classList.add('active');
                grid.style.display = 'none';
            } else {
                spinner.classList.remove('active');
                grid.style.display = 'grid';
            }
        }

        function showError(message) {
            Swal.fire({
                title: 'خطأ',
                text: message,
                icon: 'error',
                confirmButtonColor: '#dc3545'
            });
        }
    </script>
</asp:Content>
