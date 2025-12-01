-- Create MenuItems table
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'MenuItems')
BEGIN
    CREATE TABLE [dbo].[MenuItems] (
        [Id] [int] IDENTITY(1,1) NOT NULL,
        [ParentId] [int] NULL,
        [Title] [nvarchar](100) NOT NULL,
        [Description] [nvarchar](255) NULL,
        [Url] [nvarchar](255) NOT NULL,
        [Icon] [nvarchar](100) NULL,
        [DisplayOrder] [int] NOT NULL DEFAULT 0,
        [IsActive] [bit] NOT NULL DEFAULT 1,
        [CreatedDate] [datetime] NOT NULL DEFAULT GETDATE(),
        [ModifiedDate] [datetime] NULL,
        CONSTRAINT [PK_MenuItems] PRIMARY KEY CLUSTERED ([Id] ASC),
        CONSTRAINT [FK_MenuItems_Parent] FOREIGN KEY ([ParentId]) REFERENCES [dbo].[MenuItems] ([Id])
    )
    
    -- Insert default menu items
    INSERT INTO [dbo].[MenuItems] ([ParentId], [Title], [Description], [Url], [Icon], [DisplayOrder], [IsActive])
    VALUES 
    (NULL, 'الرئيسية', 'الصفحة الرئيسية للنظام', '/Default.aspx', 'fas fa-home', 1, 1),
    
    -- Inventory
    (NULL, 'المخازن', 'إدارة المنتجات والمخزون', '#', 'fas fa-boxes', 2, 1),
    (IDENT_CURRENT('MenuItems'), 'إدارة المخازن', 'إدارة المخازن والأصناف', '/Pages/Inventory.aspx', 'fas fa-warehouse', 1, 1),
    (IDENT_CURRENT('MenuItems')-1, 'جرد المخزون', 'جرد المخزون الفعلي', '/Pages/Stock.aspx', 'fas fa-cubes', 2, 1),
    (IDENT_CURRENT('MenuItems')-2, 'تحويلات', 'تحويلات بين المخازن', '/Pages/Transfer.aspx', 'fas fa-exchange-alt', 3, 1),
    
    -- Sales
    (NULL, 'المبيعات', 'إدارة المبيعات والعملاء', '#', 'fas fa-shopping-cart', 3, 1),
    (IDENT_CURRENT('MenuItems'), 'فواتير المبيعات', 'إدارة فواتير المبيعات', '/Pages/Sales.aspx', 'fas fa-file-invoice-dollar', 1, 1),
    (IDENT_CURRENT('MenuItems')-1, 'العملاء', 'إدارة بيانات العملاء', '/Pages/Customers.aspx', 'fas fa-users', 2, 1),
    (IDENT_CURRENT('MenuItems')-2, 'عروض الأسعار', 'إدارة عروض الأسعار', '/Pages/Quotes.aspx', 'fas fa-file-alt', 3, 1),
    
    -- Purchases
    (NULL, 'المشتريات', 'إدارة المشتريات والموردين', '#', 'fas fa-shopping-bag', 4, 1),
    (IDENT_CURRENT('MenuItems'), 'فواتير المشتريات', 'إدارة فواتير المشتريات', '/Pages/Purchases.aspx', 'fas fa-file-invoice', 1, 1),
    (IDENT_CURRENT('MenuItems')-1, 'الموردين', 'إدارة بيانات الموردين', '/Pages/Suppliers.aspx', 'fas fa-truck', 2, 1),
    (IDENT_CURRENT('MenuItems')-2, 'طلبات الشراء', 'إدارة طلبات الشراء', '/Pages/PurchaseOrders.aspx', 'fas fa-clipboard-list', 3, 1),
    
    -- Reports
    (NULL, 'التقارير', 'التقارير والتحليلات', '#', 'fas fa-chart-pie', 5, 1),
    (IDENT_CURRENT('MenuItems'), 'التقارير المالية', 'التقارير المالية', '/Pages/FinancialReports.aspx', 'fas fa-chart-line', 1, 1),
    (IDENT_CURRENT('MenuItems')-1, 'تقارير المبيعات', 'تقارير المبيعات', '/Pages/SalesReports.aspx', 'fas fa-chart-bar', 2, 1),
    (IDENT_CURRENT('MenuItems')-2, 'تقارير المخازن', 'تقارير المخازن', '/Pages/InventoryReports.aspx', 'fas fa-warehouse', 3, 1),
    
    -- Settings
    (NULL, 'الإعدادات', 'إعدادات النظام', '/Pages/Settings.aspx', 'fas fa-cog', 6, 1)
    
    PRINT 'MenuItems table created and populated with default data.'
END
ELSE
BEGIN
    PRINT 'MenuItems table already exists.'
END
