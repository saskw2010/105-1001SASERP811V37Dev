<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="IdentityMembershipManager.aspx.vb" Inherits="Pages_IdentityMembershipManager" Title="Identity Membership Manager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">
    Identity Membership Manager
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
    <div class="container-fluid" data-app-role="page">
        <div class="row">
            <div class="col-12">
                <div class="card">
                    <div class="card-header bg-primary text-white">
                        <h4 class="mb-0">
                            <i class="fas fa-users-cog me-2"></i>
                            Identity Membership Management
                        </h4>
                        <p class="mb-0 mt-1">Manage users, roles, and user-role assignments using ASP.NET Identity tables</p>
                    </div>
                    <div class="card-body p-0">
                        <!-- Tab Navigation -->
                        <ul class="nav nav-tabs nav-fill" id="membershipTabs" role="tablist">
                            <li class="nav-item" role="presentation">
                                <button class="nav-link active" id="users-tab" data-bs-toggle="tab" data-bs-target="#users-panel" 
                                        type="button" role="tab" aria-controls="users-panel" aria-selected="true">
                                    <i class="fas fa-users me-2"></i>
                                    Users Management
                                </button>
                            </li>
                            <li class="nav-item" role="presentation">
                                <button class="nav-link" id="roles-tab" data-bs-toggle="tab" data-bs-target="#roles-panel" 
                                        type="button" role="tab" aria-controls="roles-panel" aria-selected="false">
                                    <i class="fas fa-user-tag me-2"></i>
                                    Roles Management
                                </button>
                            </li>
                            <li class="nav-item" role="presentation">
                                <button class="nav-link" id="userroles-tab" data-bs-toggle="tab" data-bs-target="#userroles-panel" 
                                        type="button" role="tab" aria-controls="userroles-panel" aria-selected="false">
                                    <i class="fas fa-user-shield me-2"></i>
                                    User-Role Assignments
                                </button>
                            </li>
                        </ul>

                        <!-- Tab Content -->
                        <div class="tab-content" id="membershipTabContent">
                            <!-- Users Tab -->
                            <div class="tab-pane fade show active" id="users-panel" role="tabpanel" aria-labelledby="users-tab">
                                <div class="p-3">
                                    <h5 class="text-primary mb-3">
                                        <i class="fas fa-users me-2"></i>
                                        ASP.NET Identity Users
                                    </h5>
                                    <div data-flow="NewRow">
                                        <div id="usersDataView" runat="server"></div>
                                        <aquarium:DataViewExtender ID="UsersDataViewExtender" runat="server" 
                                            TargetControlID="usersDataView"
                                            Controller="AspNetUsers" 
                                            View="grid1"
                                            ShowInSummary="true"
                                            SelectionMode="Multiple"
                                            SearchOnStart="true" />
                                    </div>
                                </div>
                            </div>

                            <!-- Roles Tab -->
                            <div class="tab-pane fade" id="roles-panel" role="tabpanel" aria-labelledby="roles-tab">
                                <div class="p-3">
                                    <h5 class="text-primary mb-3">
                                        <i class="fas fa-user-tag me-2"></i>
                                        ASP.NET Identity Roles
                                    </h5>
                                    <div data-flow="NewRow">
                                        <div id="rolesDataView" runat="server"></div>
                                        <aquarium:DataViewExtender ID="RolesDataViewExtender" runat="server" 
                                            TargetControlID="rolesDataView"
                                            Controller="AspNetRoles" 
                                            View="grid1"
                                            ShowInSummary="true"
                                            SelectionMode="Multiple"
                                            SearchOnStart="true" />
                                    </div>
                                </div>
                            </div>

                            <!-- User-Role Assignments Tab -->
                            <div class="tab-pane fade" id="userroles-panel" role="tabpanel" aria-labelledby="userroles-tab">
                                <div class="p-3">
                                    <h5 class="text-primary mb-3">
                                        <i class="fas fa-user-shield me-2"></i>
                                        User-Role Assignments
                                    </h5>
                                    <div data-flow="NewRow">
                                        <div id="userRolesDataView" runat="server"></div>
                                        <aquarium:DataViewExtender ID="UserRolesDataViewExtender" runat="server" 
                                            TargetControlID="userRolesDataView"
                                            Controller="AspNetUserRoles" 
                                            View="grid1"
                                            ShowInSummary="true"
                                            SelectionMode="Multiple"
                                            SearchOnStart="true" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <style>
        .card {
            border: none;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }
        
        .card-header {
            background: linear-gradient(135deg, #1a237e, #0d47a1) !important;
            border-radius: 8px 8px 0 0 !important;
        }
        
        .nav-tabs {
            border-bottom: 2px solid #dee2e6;
            background-color: #f8f9fa;
        }
        
        .nav-tabs .nav-link {
            border: none;
            color: #6c757d;
            font-weight: 500;
            padding: 12px 20px;
            transition: all 0.3s ease;
        }
        
        .nav-tabs .nav-link:hover {
            background-color: #e9ecef;
            color: #1a237e;
        }
        
        .nav-tabs .nav-link.active {
            background-color: #1a237e;
            color: white;
            border-radius: 0;
        }
        
        .tab-content {
            min-height: 500px;
        }
        
        .text-primary {
            color: #1a237e !important;
        }
        
        /* DataView styling */
        .DataView {
            border: 1px solid #dee2e6;
            border-radius: 6px;
            overflow: hidden;
        }
        
        .DataView .HeaderText {
            background: linear-gradient(135deg, #f8f9fa, #e9ecef);
            padding: 10px 15px;
            border-bottom: 1px solid #dee2e6;
            font-weight: 600;
            color: #495057;
        }
        
        /* RTL Support */
        [dir="rtl"] .me-2 {
            margin-left: 0.5rem !important;
            margin-right: 0 !important;
        }
        
        [dir="rtl"] .nav-tabs .nav-link {
            text-align: right;
        }
    </style>

    <script>
        // Initialize Bootstrap tabs
        document.addEventListener('DOMContentLoaded', function() {
            // Initialize tab functionality
            var triggerTabList = [].slice.call(document.querySelectorAll('#membershipTabs button'));
            triggerTabList.forEach(function (triggerEl) {
                var tabTrigger = new bootstrap.Tab(triggerEl);
                
                triggerEl.addEventListener('click', function (event) {
                    event.preventDefault();
                    tabTrigger.show();
                });
            });
            
            // Add smooth transitions
            $('.tab-pane').addClass('fade');
            
            // Auto-refresh data views when switching tabs
            $('button[data-bs-toggle="tab"]').on('shown.bs.tab', function (e) {
                var target = $(e.target).attr("data-bs-target");
                var dataView = $(target).find('.DataView');
                if (dataView.length > 0) {
                    // Trigger refresh if DataView exists
                    try {
                        var dvId = dataView.attr('id');
                        if (window[dvId] && window[dvId].refresh) {
                            window[dvId].refresh();
                        }
                    } catch (ex) {
                        console.log('DataView refresh not available');
                    }
                }
            });
        });
    </script>
</asp:Content>
