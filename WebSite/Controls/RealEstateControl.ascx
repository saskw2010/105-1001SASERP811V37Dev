<%@ Control Language="VB" AutoEventWireup="false" CodeFile="RealEstateControl.ascx.vb" Inherits="RealEstateControl" %>

<!-- Real Estate Management Control - Sky365 -->
<div class="real-estate-control" id="realEstateControl">
    <!-- Header Section -->
    <div class="real-estate-header mb-4">
        <div class="d-flex justify-content-between align-items-center">
            <div class="header-title">
                <h3 class="mb-1">
                    <i class="fas fa-building text-primary me-2"></i>
                    <span class="title-text">إدارة العقارات</span>
                    <span class="title-text-en">Real Estate Management</span>
                </h3>
                <p class="text-muted mb-0">نظام إدارة شامل للعقارات والممتلكات</p>
            </div>
            <div class="header-actions">
                <button type="button" class="btn btn-primary btn-sm me-2" onclick="RealEstateControl.addNewProperty()">
                    <i class="fas fa-plus me-1"></i>
                    <span>عقار جديد</span>
                </button>
                <button type="button" class="btn btn-outline-secondary btn-sm" onclick="RealEstateControl.refreshData()">
                    <i class="fas fa-sync-alt me-1"></i>
                    <span>تحديث</span>
                </button>
            </div>
        </div>
    </div>

    <!-- Filters Section -->
    <div class="real-estate-filters card mb-4">
        <div class="card-body">
            <div class="row g-3">
                <div class="col-md-3">
                    <label class="form-label">نوع العقار</label>
                    <asp:DropDownList ID="ddlPropertyType" runat="server" CssClass="form-select form-select-sm">
                        <asp:ListItem Value="" Text="-- جميع الأنواع --" />
                        <asp:ListItem Value="apartment" Text="شقة سكنية" />
                        <asp:ListItem Value="villa" Text="فيلا" />
                        <asp:ListItem Value="office" Text="مكتب تجاري" />
                        <asp:ListItem Value="shop" Text="محل تجاري" />
                        <asp:ListItem Value="warehouse" Text="مستودع" />
                        <asp:ListItem Value="land" Text="أرض فضاء" />
                    </asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <label class="form-label">الحالة</label>
                    <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-select form-select-sm">
                        <asp:ListItem Value="" Text="-- جميع الحالات --" />
                        <asp:ListItem Value="available" Text="متاح" />
                        <asp:ListItem Value="rented" Text="مؤجر" />
                        <asp:ListItem Value="sold" Text="مباع" />
                        <asp:ListItem Value="maintenance" Text="تحت الصيانة" />
                    </asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <label class="form-label">المنطقة</label>
                    <asp:DropDownList ID="ddlArea" runat="server" CssClass="form-select form-select-sm">
                        <asp:ListItem Value="" Text="-- جميع المناطق --" />
                    </asp:DropDownList>
                </div>
                <div class="col-md-3 d-flex align-items-end">
                    <asp:Button ID="btnFilter" runat="server" Text="تطبيق الفلتر" CssClass="btn btn-outline-primary btn-sm w-100" OnClick="btnFilter_Click" />
                </div>
            </div>
        </div>
    </div>

    <!-- Statistics Cards -->
    <div class="real-estate-stats mb-4">
        <div class="row g-3">
            <div class="col-xl-3 col-md-6">
                <div class="card stat-card border-start border-primary border-4">
                    <div class="card-body">
                        <div class="d-flex justify-content-between">
                            <div>
                                <h6 class="text-muted mb-1">إجمالي العقارات</h6>
                                <h4 class="mb-0" id="totalProperties">
                                    <asp:Literal ID="litTotalProperties" runat="server" Text="0" />
                                </h4>
                            </div>
                            <div class="stat-icon">
                                <i class="fas fa-building text-primary"></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xl-3 col-md-6">
                <div class="card stat-card border-start border-success border-4">
                    <div class="card-body">
                        <div class="d-flex justify-content-between">
                            <div>
                                <h6 class="text-muted mb-1">العقارات المتاحة</h6>
                                <h4 class="mb-0" id="availableProperties">
                                    <asp:Literal ID="litAvailableProperties" runat="server" Text="0" />
                                </h4>
                            </div>
                            <div class="stat-icon">
                                <i class="fas fa-check-circle text-success"></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xl-3 col-md-6">
                <div class="card stat-card border-start border-warning border-4">
                    <div class="card-body">
                        <div class="d-flex justify-content-between">
                            <div>
                                <h6 class="text-muted mb-1">العقارات المؤجرة</h6>
                                <h4 class="mb-0" id="rentedProperties">
                                    <asp:Literal ID="litRentedProperties" runat="server" Text="0" />
                                </h4>
                            </div>
                            <div class="stat-icon">
                                <i class="fas fa-key text-warning"></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-xl-3 col-md-6">
                <div class="card stat-card border-start border-info border-4">
                    <div class="card-body">
                        <div class="d-flex justify-content-between">
                            <div>
                                <h6 class="text-muted mb-1">إجمالي القيمة</h6>
                                <h4 class="mb-0" id="totalValue">
                                    <asp:Literal ID="litTotalValue" runat="server" Text="0" />
                                    <small class="text-muted">د.ك</small>
                                </h4>
                            </div>
                            <div class="stat-icon">
                                <i class="fas fa-dollar-sign text-info"></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Properties Grid -->
    <div class="real-estate-grid card">
        <div class="card-header">
            <div class="d-flex justify-content-between align-items-center">
                <h5 class="mb-0">
                    <i class="fas fa-list me-2"></i>
                    قائمة العقارات
                </h5>
                <div class="view-controls">
                    <div class="btn-group btn-group-sm" role="group">
                        <button type="button" class="btn btn-outline-secondary active" onclick="RealEstateControl.setView('grid')">
                            <i class="fas fa-th"></i>
                        </button>
                        <button type="button" class="btn btn-outline-secondary" onclick="RealEstateControl.setView('list')">
                            <i class="fas fa-list"></i>
                        </button>
                    </div>
                </div>
            </div>
        </div>
        <div class="card-body">
            <!-- Loading Indicator -->
            <div class="loading-indicator text-center py-4" id="loadingIndicator" style="display: none;">
                <div class="spinner-border text-primary" role="status">
                    <span class="visually-hidden">جاري التحميل...</span>
                </div>
                <p class="mt-2 text-muted">جاري تحميل العقارات...</p>
            </div>

            <!-- Properties Repeater -->
            <asp:Repeater ID="rptProperties" runat="server" OnItemDataBound="rptProperties_ItemDataBound">
                <HeaderTemplate>
                    <div class="properties-container" id="propertiesContainer">
                        <div class="row g-4">
                </HeaderTemplate>
                <ItemTemplate>
                    <div class="col-xl-4 col-md-6">
                        <div class="property-card card h-100">
                            <div class="property-image">
                                <img src='<%# GetPropertyImage(Eval("PropertyImage")) %>' 
                                     alt='<%# Eval("PropertyTitle") %>' 
                                     class="card-img-top" 
                                     onerror="this.src='/images/property-placeholder.jpg'">
                                <div class="property-status">
                                    <span class="badge bg-<%# GetStatusColor(Eval("Status")) %>">
                                        <%# GetStatusText(Eval("Status")) %>
                                    </span>
                                </div>
                                <div class="property-type">
                                    <span class="badge bg-secondary">
                                        <%# GetPropertyTypeText(Eval("PropertyType")) %>
                                    </span>
                                </div>
                            </div>
                            <div class="card-body">
                                <h6 class="property-title"><%# Eval("PropertyTitle") %></h6>
                                <p class="property-location text-muted mb-2">
                                    <i class="fas fa-map-marker-alt me-1"></i>
                                    <%# Eval("Area") %> - <%# Eval("District") %>
                                </p>
                                <div class="property-details mb-3">
                                    <div class="row g-2 text-sm">
                                        <div class="col-6">
                                            <i class="fas fa-bed text-muted me-1"></i>
                                            <%# Eval("Bedrooms") %> غرف نوم
                                        </div>
                                        <div class="col-6">
                                            <i class="fas fa-bath text-muted me-1"></i>
                                            <%# Eval("Bathrooms") %> حمام
                                        </div>
                                        <div class="col-6">
                                            <i class="fas fa-ruler-combined text-muted me-1"></i>
                                            <%# Eval("Area") %> م²
                                        </div>
                                        <div class="col-6">
                                            <i class="fas fa-car text-muted me-1"></i>
                                            <%# Eval("ParkingSpaces") %> موقف
                                        </div>
                                    </div>
                                </div>
                                <div class="property-price">
                                    <h5 class="text-primary mb-2">
                                        <%# FormatCurrency(Eval("Price")) %> د.ك
                                        <small class="text-muted">/ شهرياً</small>
                                    </h5>
                                </div>
                            </div>
                            <div class="card-footer bg-transparent">
                                <div class="d-flex gap-2">
                                    <button type="button" class="btn btn-primary btn-sm flex-fill" 
                                            onclick="RealEstateControl.viewProperty('<%# Eval("PropertyId") %>')">
                                        <i class="fas fa-eye me-1"></i>
                                        عرض
                                    </button>
                                    <button type="button" class="btn btn-outline-secondary btn-sm flex-fill" 
                                            onclick="RealEstateControl.editProperty('<%# Eval("PropertyId") %>')">
                                        <i class="fas fa-edit me-1"></i>
                                        تعديل
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
                <FooterTemplate>
                        </div>
                    </div>
                </FooterTemplate>
            </asp:Repeater>

            <!-- Empty State -->
            <div class="empty-state text-center py-5" id="emptyState" style="display: none;">
                <i class="fas fa-building text-muted" style="font-size: 3rem; opacity: 0.3;"></i>
                <h5 class="mt-3 text-muted">لا توجد عقارات</h5>
                <p class="text-muted">لا توجد عقارات تطابق معايير البحث الحالية</p>
                <button type="button" class="btn btn-primary" onclick="RealEstateControl.addNewProperty()">
                    <i class="fas fa-plus me-2"></i>
                    إضافة عقار جديد
                </button>
            </div>
        </div>
    </div>

    <!-- Pagination -->
    <div class="real-estate-pagination mt-3" id="paginationSection">
        <nav aria-label="صفحات العقارات">
            <ul class="pagination justify-content-center">
                <li class="page-item">
                    <asp:LinkButton ID="lnkPrevious" runat="server" CssClass="page-link" OnClick="lnkPrevious_Click">
                        <i class="fas fa-chevron-right"></i>
                    </asp:LinkButton>
                </li>
                <asp:Repeater ID="rptPagination" runat="server">
                    <ItemTemplate>
                        <li class="page-item <%# If(CBool(Eval("IsActive")), "active", "") %>">
                            <asp:LinkButton ID="lnkPage" runat="server" 
                                          CssClass="page-link" 
                                          CommandArgument='<%# Eval("PageNumber") %>'
                                          OnClick="lnkPage_Click">
                                <%# Eval("PageNumber") %>
                            </asp:LinkButton>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
                <li class="page-item">
                    <asp:LinkButton ID="lnkNext" runat="server" CssClass="page-link" OnClick="lnkNext_Click">
                        <i class="fas fa-chevron-left"></i>
                    </asp:LinkButton>
                </li>
            </ul>
        </nav>
    </div>
</div>

<!-- Custom CSS -->
<style>
.real-estate-control {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    direction: rtl;
    text-align: right;
}

.real-estate-header .title-text-en {
    font-size: 0.9em;
    color: #6c757d;
    margin-right: 10px;
}

.stat-card {
    transition: transform 0.2s ease, box-shadow 0.2s ease;
}

.stat-card:hover {
    transform: translateY(-2px);
    box-shadow: 0 4px 12px rgba(0,0,0,0.1);
}

.stat-icon {
    background: rgba(var(--bs-primary-rgb), 0.1);
    width: 48px;
    height: 48px;
    border-radius: 12px;
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 1.2rem;
}

.property-card {
    transition: transform 0.3s ease, box-shadow 0.3s ease;
    border: 1px solid rgba(0,0,0,0.1);
}

.property-card:hover {
    transform: translateY(-4px);
    box-shadow: 0 8px 25px rgba(0,0,0,0.15);
}

.property-image {
    position: relative;
    overflow: hidden;
}

.property-image img {
    height: 200px;
    object-fit: cover;
    transition: transform 0.3s ease;
}

.property-card:hover .property-image img {
    transform: scale(1.05);
}

.property-status {
    position: absolute;
    top: 10px;
    right: 10px;
    z-index: 2;
}

.property-type {
    position: absolute;
    top: 10px;
    left: 10px;
    z-index: 2;
}

.property-title {
    font-weight: 600;
    color: #2c3e50;
    margin-bottom: 8px;
    line-height: 1.4;
}

.property-location {
    font-size: 0.9rem;
}

.property-details {
    font-size: 0.85rem;
}

.property-price {
    border-top: 1px solid rgba(0,0,0,0.1);
    padding-top: 12px;
}

.loading-indicator {
    min-height: 200px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
}

.view-controls .btn {
    padding: 0.375rem 0.75rem;
}

.pagination .page-link {
    border-radius: 6px;
    margin: 0 2px;
    border: 1px solid #dee2e6;
}

.pagination .page-item.active .page-link {
    background-color: var(--bs-primary);
    border-color: var(--bs-primary);
}

/* RTL Support */
[dir="rtl"] .property-image .property-status {
    right: auto;
    left: 10px;
}

[dir="rtl"] .property-image .property-type {
    left: auto;
    right: 10px;
}

/* Dark Theme Support */
.theme-dark .property-card {
    background-color: #2c3e50;
    border-color: #34495e;
    color: #ecf0f1;
}

.theme-dark .property-title {
    color: #ecf0f1;
}

.theme-dark .card-footer {
    background-color: rgba(0,0,0,0.1) !important;
}

/* Responsive Design */
@media (max-width: 768px) {
    .real-estate-header .d-flex {
        flex-direction: column;
        gap: 1rem;
    }
    
    .header-actions {
        align-self: stretch;
    }
    
    .header-actions .btn {
        flex: 1;
    }
    
    .property-details .row > div {
        font-size: 0.8rem;
    }
}
</style>

<!-- JavaScript for Real Estate Control -->
<script type="text/javascript">
// Real Estate Control JavaScript Class
class RealEstateControlClass {
    constructor() {
        this.currentView = 'grid';
        this.currentPage = 1;
        this.pageSize = 12;
        this.filters = {
            propertyType: '',
            status: '',
            area: ''
        };
        this.initializeControl();
    }

    initializeControl() {
        console.log('🏢 Real Estate Control initialized');
        this.bindEvents();
        this.loadInitialData();
    }

    bindEvents() {
        // Add event listeners for filter changes
        const filterElements = ['ddlPropertyType', 'ddlStatus', 'ddlArea'];
        filterElements.forEach(elementId => {
            const element = document.getElementById(elementId);
            if (element) {
                element.addEventListener('change', () => this.onFilterChange());
            }
        });
    }

    onFilterChange() {
        console.log('📝 Filters changed, reloading data...');
        this.currentPage = 1;
        this.loadProperties();
    }

    addNewProperty() {
        console.log('➕ Adding new property...');
        // Navigate to property creation page or show modal
        window.location.href = '/Pages/RealstateStock.aspx?mode=add';
    }

    editProperty(propertyId) {
        console.log('✏️ Editing property:', propertyId);
        // Navigate to property edit page
        window.location.href = `/Pages/RealstateStock.aspx?id=${propertyId}&mode=edit`;
    }

    viewProperty(propertyId) {
        console.log('👁️ Viewing property:', propertyId);
        // Navigate to property details page
        window.location.href = `/Pages/RealstateStock.aspx?id=${propertyId}&mode=view`;
    }

    setView(viewType) {
        console.log('🔄 Changing view to:', viewType);
        this.currentView = viewType;
        
        // Update view buttons
        const gridBtn = document.querySelector('[onclick*="setView(\'grid\')"]');
        const listBtn = document.querySelector('[onclick*="setView(\'list\')"]');
        
        if (gridBtn && listBtn) {
            gridBtn.classList.toggle('active', viewType === 'grid');
            listBtn.classList.toggle('active', viewType === 'list');
        }

        // Update container class
        const container = document.getElementById('propertiesContainer');
        if (container) {
            container.className = viewType === 'grid' ? 'row g-4' : 'list-view';
        }
    }

    refreshData() {
        console.log('🔄 Refreshing real estate data...');
        this.showLoading(true);
        this.loadProperties();
    }

    loadInitialData() {
        console.log('📊 Loading initial real estate data...');
        this.loadStatistics();
        this.loadProperties();
    }

    loadStatistics() {
        // This would typically make an AJAX call to get statistics
        console.log('📈 Loading statistics...');
        // Update statistics in the UI
    }

    loadProperties() {
        this.showLoading(true);
        
        // Simulate loading delay (in real implementation, this would be an AJAX call)
        setTimeout(() => {
            this.showLoading(false);
            console.log('🏠 Properties loaded successfully');
        }, 1000);
    }

    showLoading(show) {
        const loadingIndicator = document.getElementById('loadingIndicator');
        const propertiesContainer = document.getElementById('propertiesContainer');
        const emptyState = document.getElementById('emptyState');
        
        if (loadingIndicator) {
            loadingIndicator.style.display = show ? 'flex' : 'none';
        }
        
        if (propertiesContainer) {
            propertiesContainer.style.display = show ? 'none' : 'block';
        }
        
        if (emptyState) {
            emptyState.style.display = 'none';
        }
    }

    showEmptyState() {
        const loadingIndicator = document.getElementById('loadingIndicator');
        const propertiesContainer = document.getElementById('propertiesContainer');
        const emptyState = document.getElementById('emptyState');
        
        if (loadingIndicator) loadingIndicator.style.display = 'none';
        if (propertiesContainer) propertiesContainer.style.display = 'none';
        if (emptyState) emptyState.style.display = 'block';
    }
}

// Initialize the control when DOM is ready
document.addEventListener('DOMContentLoaded', function() {
    window.RealEstateControl = new RealEstateControlClass();
});

// Fallback for older browsers
if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', function() {
        if (!window.RealEstateControl) {
            window.RealEstateControl = new RealEstateControlClass();
        }
    });
} else {
    window.RealEstateControl = new RealEstateControlClass();
}
</script>
