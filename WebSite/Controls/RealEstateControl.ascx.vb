Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls

Partial Public Class RealEstateControl
    Inherits System.Web.UI.UserControl

    #Region "Helper Classes"
    
    ''' <summary>
    ''' Navigation item data structure
    ''' </summary>
    Public Class NavigationItem
        Public Property Title As String
        Public Property Url As String
        Public Property Description As String
        Public Property HasChildren As Boolean
    End Class
    
    #End Region

    #Region "Properties"
    
    ''' <summary>
    ''' Current page number for pagination
    ''' </summary>
    Public Property CurrentPage As Integer
        Get
            If ViewState("CurrentPage") IsNot Nothing Then
                Return CInt(ViewState("CurrentPage"))
            End If
            Return 1
        End Get
        Set(value As Integer)
            ViewState("CurrentPage") = value
        End Set
    End Property

    ''' <summary>
    ''' Number of items per page
    ''' </summary>
    Public Property PageSize As Integer
        Get
            If ViewState("PageSize") IsNot Nothing Then
                Return CInt(ViewState("PageSize"))
            End If
            Return 12
        End Get
        Set(value As Integer)
            ViewState("PageSize") = value
        End Set
    End Property

    ''' <summary>
    ''' Total number of properties
    ''' </summary>
    Public Property TotalRecords As Integer
        Get
            If ViewState("TotalRecords") IsNot Nothing Then
                Return CInt(ViewState("TotalRecords"))
            End If
            Return 0
        End Get
        Set(value As Integer)
            ViewState("TotalRecords") = value
        End Set
    End Property

    #End Region

    #Region "Page Events"

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If Not Page.IsPostBack Then
                InitializeControl()
                LoadInitialData()
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in RealEstateControl Page_Load: " & ex.Message)
            ShowErrorMessage("حدث خطأ في تحميل بيانات العقارات: " & ex.Message)
        End Try
    End Sub

    #End Region

    #Region "Control Events"

    Protected Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            CurrentPage = 1
            LoadPropertiesData()
            System.Diagnostics.Debug.WriteLine("🔍 Filter applied successfully")
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error applying filter: " & ex.Message)
            ShowErrorMessage("حدث خطأ في تطبيق المرشح: " & ex.Message)
        End Try
    End Sub

    Protected Sub lnkPrevious_Click(sender As Object, e As EventArgs) Handles lnkPrevious.Click
        Try
            If CurrentPage > 1 Then
                CurrentPage -= 1
                LoadPropertiesData()
                UpdatePagination()
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in previous page: " & ex.Message)
        End Try
    End Sub

    Protected Sub lnkNext_Click(sender As Object, e As EventArgs) Handles lnkNext.Click
        Try
            Dim totalPages As Integer = Math.Ceiling(TotalRecords / PageSize)
            If CurrentPage < totalPages Then
                CurrentPage += 1
                LoadPropertiesData()
                UpdatePagination()
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in next page: " & ex.Message)
        End Try
    End Sub

    Protected Sub lnkPage_Click(sender As Object, e As EventArgs)
        Try
            Dim lnk As LinkButton = DirectCast(sender, LinkButton)
            CurrentPage = CInt(lnk.CommandArgument)
            LoadPropertiesData()
            UpdatePagination()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in page click: " & ex.Message)
        End Try
    End Sub

    Protected Sub rptProperties_ItemDataBound(sender As Object, e As RepeaterItemEventArgs) Handles rptProperties.ItemDataBound
        Try
            If e.Item.ItemType = ListItemType.Item OrElse e.Item.ItemType = ListItemType.AlternatingItem Then
                ' Additional item binding logic can be added here
                System.Diagnostics.Debug.WriteLine("🏠 Property item bound successfully")
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error in item data bound: " & ex.Message)
        End Try
    End Sub

    #End Region

    #Region "Private Methods"

    Private Sub InitializeControl()
        Try
            LoadAreas()
            System.Diagnostics.Debug.WriteLine("🏗️ RealEstateControl initialized successfully")
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error initializing control: " & ex.Message)
            Throw
        End Try
    End Sub

    Private Sub LoadInitialData()
        Try
            LoadStatistics()
            LoadPropertiesData()
            UpdatePagination()
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error loading initial data: " & ex.Message)
            Throw
        End Try
    End Sub

    Private Sub LoadAreas()
        Try
            ' Load areas from SiteMap Navigation System
            ddlArea.Items.Clear()
            ddlArea.Items.Add(New ListItem("-- جميع المناطق --", ""))
            
            ' Get navigation data from SiteMap
            Dim navigationItems = GetNavigationItems()
            
            ' Add navigation items as areas
            For Each item In navigationItems
                If Not String.IsNullOrEmpty(item.Title) AndAlso item.Title <> "Home" Then
                    ddlArea.Items.Add(New ListItem(item.Title, item.Url))
                End If
            Next
            
            System.Diagnostics.Debug.WriteLine("🌍 Areas loaded from Navigation System: " & ddlArea.Items.Count & " items")
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error loading areas: " & ex.Message)
            ' Fallback to sample data
            LoadFallbackAreas()
        End Try
    End Sub

    ''' <summary>
    ''' Get navigation items from SiteMap for dropdown population
    ''' </summary>
    Private Function GetNavigationItems() As List(Of NavigationItem)
        Dim items As New List(Of NavigationItem)
        
        Try
            ' Get sitemap provider
            Dim siteMapProvider = SiteMap.Provider
            If siteMapProvider IsNot Nothing AndAlso siteMapProvider.RootNode IsNot Nothing Then
                
                ' Get all top-level menu items
                For Each childNode As SiteMapNode In siteMapProvider.RootNode.ChildNodes
                    If childNode.HasChildNodes Then
                        ' Add main menu item
                        items.Add(New NavigationItem With {
                            .Title = CleanMenuTitle(childNode.Title),
                            .Url = If(String.IsNullOrEmpty(childNode.Url), "#", childNode.Url),
                            .Description = childNode.Description,
                            .HasChildren = True
                        })
                        
                        ' Add sub-menu items as separate entries
                        For Each subNode As SiteMapNode In childNode.ChildNodes
                            items.Add(New NavigationItem With {
                                .Title = CleanMenuTitle(subNode.Title),
                                .Url = If(String.IsNullOrEmpty(subNode.Url), "#", subNode.Url),
                                .Description = subNode.Description,
                                .HasChildren = False
                            })
                        Next
                    End If
                Next
                
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error getting navigation items: " & ex.Message)
        End Try
        
        Return items
    End Function

    ''' <summary>
    ''' Clean menu title from translation markers
    ''' </summary>
    Private Function CleanMenuTitle(title As String) As String
        If String.IsNullOrEmpty(title) Then Return ""
        
        ' Remove translation markers like ^SiteHome^Home^SiteHome^
        Dim cleanTitle = title
        If cleanTitle.Contains("^") Then
            Dim parts = cleanTitle.Split("^"c)
            If parts.Length >= 3 Then
                cleanTitle = parts(2) ' Take the middle part
            End If
        End If
        
        Return cleanTitle.Trim()
    End Function

    ''' <summary>
    ''' Fallback method to load sample areas if navigation system fails
    ''' </summary>
    Private Sub LoadFallbackAreas()
        Try
            ddlArea.Items.Add(New ListItem("الجهراء", "jahra"))
            ddlArea.Items.Add(New ListItem("الأحمدي", "ahmadi"))
            ddlArea.Items.Add(New ListItem("حولي", "hawalli"))
            ddlArea.Items.Add(New ListItem("الفروانية", "farwaniya"))
            ddlArea.Items.Add(New ListItem("العاصمة", "capital"))
            ddlArea.Items.Add(New ListItem("مبارك الكبير", "mubarak"))
            
            System.Diagnostics.Debug.WriteLine("🔄 Fallback areas loaded")
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error loading fallback areas: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadStatistics()
        Try
            ' In real implementation, these would come from database queries
            Dim totalProperties As Integer = GetTotalPropertiesCount()
            Dim availableProperties As Integer = GetAvailablePropertiesCount()
            Dim rentedProperties As Integer = GetRentedPropertiesCount()
            Dim totalValue As Decimal = GetTotalPropertiesValue()

            litTotalProperties.Text = totalProperties.ToString("N0")
            litAvailableProperties.Text = availableProperties.ToString("N0")
            litRentedProperties.Text = rentedProperties.ToString("N0")
            litTotalValue.Text = totalValue.ToString("N0")

            System.Diagnostics.Debug.WriteLine("📊 Statistics loaded - Total: " & totalProperties & ", Available: " & availableProperties)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error loading statistics: " & ex.Message)
            Throw
        End Try
    End Sub

    Private Sub LoadPropertiesData()
        Try
            Dim propertiesData As DataTable = GetPropertiesData()
            
            If propertiesData IsNot Nothing AndAlso propertiesData.Rows.Count > 0 Then
                rptProperties.DataSource = propertiesData
                rptProperties.DataBind()
                System.Diagnostics.Debug.WriteLine("🏠 Properties data loaded: " & propertiesData.Rows.Count & " records")
            Else
                rptProperties.DataSource = Nothing
                rptProperties.DataBind()
                System.Diagnostics.Debug.WriteLine("📭 No properties found")
            End If
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error loading properties data: " & ex.Message)
            Throw
        End Try
    End Sub

    Private Function GetPropertiesData() As DataTable
        Try
            ' Create data table structure
            Dim dt As New DataTable()
            
            ' Define columns
            dt.Columns.Add("PropertyId", GetType(Integer))
            dt.Columns.Add("PropertyTitle", GetType(String))
            dt.Columns.Add("PropertyType", GetType(String))
            dt.Columns.Add("Status", GetType(String))
            dt.Columns.Add("Area", GetType(String))
            dt.Columns.Add("District", GetType(String))
            dt.Columns.Add("Bedrooms", GetType(Integer))
            dt.Columns.Add("Bathrooms", GetType(Integer))
            dt.Columns.Add("AreaSize", GetType(Integer))
            dt.Columns.Add("ParkingSpaces", GetType(Integer))
            dt.Columns.Add("Price", GetType(Decimal))
            dt.Columns.Add("PropertyImage", GetType(String))

            ' Get navigation items and create properties from them
            Dim navigationItems = GetNavigationItems()
            Dim propertyId As Integer = 1
            
            For Each navItem In navigationItems
                If Not navItem.HasChildren AndAlso Not String.IsNullOrEmpty(navItem.Title) Then
                    ' Create property from navigation item
                    Dim propertyType = DeterminePropertyType(navItem.Title)
                    Dim status = DeterminePropertyStatus(propertyId)
                    Dim area = DetermineAreaFromUrl(navItem.Url)
                    
                    dt.Rows.Add(
                        propertyId,
                        navItem.Title,
                        propertyType,
                        status,
                        area,
                        ExtractDistrictFromTitle(navItem.Title),
                        GetRandomBedrooms(propertyType),
                        GetRandomBathrooms(),
                        GetRandomAreaSize(propertyType),
                        GetRandomParking(propertyType),
                        GetRandomPrice(propertyType),
                        ""
                    )
                    
                    propertyId += 1
                End If
            Next

            ' If no navigation items found, add some fallback data
            If dt.Rows.Count = 0 Then
                dt.Rows.Add(1, "شقة فاخرة في الجهراء", "apartment", "available", "الجهراء", "الجهراء الجديدة", 3, 2, 120, 1, 450, "")
                dt.Rows.Add(2, "فيلا عائلية في الأحمدي", "villa", "rented", "الأحمدي", "المهبولة", 4, 3, 300, 2, 800, "")
                dt.Rows.Add(3, "مكتب تجاري في العاصمة", "office", "available", "العاصمة", "شرق", 0, 1, 80, 1, 350, "")
            End If

            ' Apply filters
            ApplyFilters(dt)
            
            ' Update total records for pagination
            TotalRecords = dt.Rows.Count
            
            ' Apply pagination
            Return ApplyPagination(dt)
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error getting properties data: " & ex.Message)
            Throw
        End Try
    End Function

    ''' <summary>
    ''' Determine property type from navigation title
    ''' </summary>
    Private Function DeterminePropertyType(title As String) As String
        title = title.ToLower()
        If title.Contains("office") OrElse title.Contains("مكتب") Then Return "office"
        If title.Contains("shop") OrElse title.Contains("محل") Then Return "shop"
        If title.Contains("warehouse") OrElse title.Contains("مستودع") Then Return "warehouse"
        If title.Contains("land") OrElse title.Contains("أرض") Then Return "land"
        If title.Contains("villa") OrElse title.Contains("فيلا") Then Return "villa"
        Return "apartment" ' Default
    End Function

    ''' <summary>
    ''' Determine property status in rotation
    ''' </summary>
    Private Function DeterminePropertyStatus(id As Integer) As String
        Dim statuses = {"available", "rented", "sold", "maintenance"}
        Return statuses(id Mod statuses.Length)
    End Function

    ''' <summary>
    ''' Extract area from URL
    ''' </summary>
    Private Function DetermineAreaFromUrl(url As String) As String
        If String.IsNullOrEmpty(url) Then Return "غير محدد"
        
        If url.ToLower().Contains("membership") Then Return "الإدارة"
        If url.ToLower().Contains("finance") Then Return "المالية"
        If url.ToLower().Contains("hr") Then Return "الموارد البشرية"
        If url.ToLower().Contains("account") Then Return "المحاسبة"
        If url.ToLower().Contains("report") Then Return "التقارير"
        
        Return "العامة"
    End Function

    ''' <summary>
    ''' Extract district from title
    ''' </summary>
    Private Function ExtractDistrictFromTitle(title As String) As String
        If String.IsNullOrEmpty(title) Then Return "غير محدد"
        
        ' Extract meaningful district from title
        Dim words = title.Split(" "c)
        If words.Length > 1 Then
            Return words(words.Length - 1) ' Last word as district
        End If
        
        Return title
    End Function

    ''' <summary>
    ''' Get random bedrooms based on property type
    ''' </summary>
    Private Function GetRandomBedrooms(propertyType As String) As Integer
        Select Case propertyType.ToLower()
            Case "villa"
                Return New Random().Next(3, 6)
            Case "apartment"
                Return New Random().Next(1, 4)
            Case Else
                Return 0
        End Select
    End Function

    ''' <summary>
    ''' Get random bathrooms
    ''' </summary>
    Private Function GetRandomBathrooms() As Integer
        Return New Random().Next(1, 4)
    End Function

    ''' <summary>
    ''' Get random area size based on property type
    ''' </summary>
    Private Function GetRandomAreaSize(propertyType As String) As Integer
        Select Case propertyType.ToLower()
            Case "villa"
                Return New Random().Next(200, 500)
            Case "apartment"
                Return New Random().Next(80, 200)
            Case "office"
                Return New Random().Next(50, 150)
            Case "shop"
                Return New Random().Next(30, 100)
            Case "warehouse"
                Return New Random().Next(100, 1000)
            Case "land"
                Return New Random().Next(300, 2000)
            Case Else
                Return New Random().Next(50, 200)
        End Select
    End Function

    ''' <summary>
    ''' Get random parking spaces based on property type
    ''' </summary>
    Private Function GetRandomParking(propertyType As String) As Integer
        Select Case propertyType.ToLower()
            Case "villa"
                Return New Random().Next(1, 4)
            Case "apartment"
                Return New Random().Next(0, 2)
            Case "office"
                Return New Random().Next(0, 2)
            Case Else
                Return 0
        End Select
    End Function

    ''' <summary>
    ''' Get random price based on property type
    ''' </summary>
    Private Function GetRandomPrice(propertyType As String) As Decimal
        Select Case propertyType.ToLower()
            Case "villa"
                Return New Random().Next(800, 2000)
            Case "apartment"
                Return New Random().Next(300, 800)
            Case "office"
                Return New Random().Next(200, 600)
            Case "shop"
                Return New Random().Next(150, 500)
            Case "warehouse"
                Return New Random().Next(300, 1000)
            Case "land"
                Return New Random().Next(500, 3000)
            Case Else
                Return New Random().Next(200, 800)
        End Select
    End Function

    Private Sub ApplyFilters(dt As DataTable)
        Try
            Dim filterExpression As String = "1=1"
            
            ' Property Type filter
            If Not String.IsNullOrEmpty(ddlPropertyType.SelectedValue) Then
                filterExpression &= " AND PropertyType = '" & ddlPropertyType.SelectedValue & "'"
            End If
            
            ' Status filter
            If Not String.IsNullOrEmpty(ddlStatus.SelectedValue) Then
                filterExpression &= " AND Status = '" & ddlStatus.SelectedValue & "'"
            End If
            
            ' Area filter
            If Not String.IsNullOrEmpty(ddlArea.SelectedValue) Then
                filterExpression &= " AND Area = '" & ddlArea.Text & "'"
            End If
            
            If filterExpression <> "1=1" Then
                Dim filteredRows() As DataRow = dt.Select(filterExpression)
                dt = filteredRows.CopyToDataTable()
            End If
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error applying filters: " & ex.Message)
        End Try
    End Sub

    Private Function ApplyPagination(dt As DataTable) As DataTable
        Try
            Dim startIndex As Integer = (CurrentPage - 1) * PageSize
            Dim endIndex As Integer = Math.Min(startIndex + PageSize - 1, dt.Rows.Count - 1)
            
            If startIndex >= dt.Rows.Count Then
                Return dt.Clone() ' Return empty table with same structure
            End If
            
            Dim pagedTable As DataTable = dt.Clone()
            For i As Integer = startIndex To endIndex
                pagedTable.ImportRow(dt.Rows(i))
            Next
            
            Return pagedTable
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error applying pagination: " & ex.Message)
            Return dt
        End Try
    End Function

    Private Sub UpdatePagination()
        Try
            Dim totalPages As Integer = Math.Ceiling(TotalRecords / PageSize)
            
            ' Enable/disable navigation buttons
            lnkPrevious.Enabled = CurrentPage > 1
            lnkNext.Enabled = CurrentPage < totalPages
            
            ' Build pagination data
            Dim paginationData As New List(Of Object)()
            
            Dim startPage As Integer = Math.Max(1, CurrentPage - 2)
            Dim endPage As Integer = Math.Min(totalPages, CurrentPage + 2)
            
            For i As Integer = startPage To endPage
                paginationData.Add(New With {
                    .PageNumber = i,
                    .IsActive = (i = CurrentPage)
                })
            Next
            
            rptPagination.DataSource = paginationData
            rptPagination.DataBind()
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error updating pagination: " & ex.Message)
        End Try
    End Sub

    Private Function GetTotalPropertiesCount() As Integer
        ' In real implementation, query database
        Return 156
    End Function

    Private Function GetAvailablePropertiesCount() As Integer
        ' In real implementation, query database
        Return 89
    End Function

    Private Function GetRentedPropertiesCount() As Integer
        ' In real implementation, query database
        Return 45
    End Function

    Private Function GetTotalPropertiesValue() As Decimal
        ' In real implementation, query database
        Return 12500000
    End Function

    Private Sub ShowErrorMessage(message As String)
        Try
            ' In real implementation, you might use a notification system
            Page.ClientScript.RegisterStartupScript(Me.GetType(), "error", "alert('" & message & "');", True)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error showing error message: " & ex.Message)
        End Try
    End Sub

    #End Region

    #Region "Public Helper Methods"

    ''' <summary>
    ''' Get property image URL with fallback
    ''' </summary>
    Public Function GetPropertyImage(imageValue As Object) As String
        Try
            If imageValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(imageValue.ToString()) Then
                Return "/images/properties/" & imageValue.ToString()
            Else
                Return "/images/property-placeholder.jpg"
            End If
        Catch ex As Exception
            Return "/images/property-placeholder.jpg"
        End Try
    End Function

    ''' <summary>
    ''' Get status color for badge
    ''' </summary>
    Public Function GetStatusColor(status As Object) As String
        Try
            If status Is Nothing Then Return "secondary"
            
            Select Case status.ToString().ToLower()
                Case "available"
                    Return "success"
                Case "rented"
                    Return "warning"
                Case "sold"
                    Return "info"
                Case "maintenance"
                    Return "danger"
                Case Else
                    Return "secondary"
            End Select
        Catch ex As Exception
            Return "secondary"
        End Try
    End Function

    ''' <summary>
    ''' Get localized status text
    ''' </summary>
    Public Function GetStatusText(status As Object) As String
        Try
            If status Is Nothing Then Return "غير محدد"
            
            Select Case status.ToString().ToLower()
                Case "available"
                    Return "متاح"
                Case "rented"
                    Return "مؤجر"
                Case "sold"
                    Return "مباع"
                Case "maintenance"
                    Return "صيانة"
                Case Else
                    Return "غير محدد"
            End Select
        Catch ex As Exception
            Return "غير محدد"
        End Try
    End Function

    ''' <summary>
    ''' Get localized property type text
    ''' </summary>
    Public Function GetPropertyTypeText(propertyType As Object) As String
        Try
            If propertyType Is Nothing Then Return "غير محدد"
            
            Select Case propertyType.ToString().ToLower()
                Case "apartment"
                    Return "شقة"
                Case "villa"
                    Return "فيلا"
                Case "office"
                    Return "مكتب"
                Case "shop"
                    Return "محل"
                Case "warehouse"
                    Return "مستودع"
                Case "land"
                    Return "أرض"
                Case Else
                    Return "غير محدد"
            End Select
        Catch ex As Exception
            Return "غير محدد"
        End Try
    End Function

    ''' <summary>
    ''' Format currency value
    ''' </summary>
    Public Function FormatCurrency(price As Object) As String
        Try
            If price IsNot Nothing AndAlso IsNumeric(price) Then
                Return CDec(price).ToString("N0")
            Else
                Return "0"
            End If
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    #End Region

End Class
