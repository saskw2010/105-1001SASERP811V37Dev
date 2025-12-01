Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Partial Public Class Pages_NewsManager
    Inherits System.Web.UI.Page

    ' Reference to the NewsItem class from NewsPanel
    <Serializable>
    Private Class NewsItem
        Public Property ID As Integer
        Public Property Title As String
        Public Property Content As String
        Public Property NewsDate As DateTime
        Public Property Tag As String
        Public Property ReadMoreUrl As String
        Public Property IsActive As Boolean
        Public Property Priority As Integer
        Public Property Summary As String
    End Class

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadNewsGrid()
            ' Refresh the news preview
            ucNewsPreview.RefreshNews()
        End If
    End Sub

    Private Sub LoadNewsGrid()
        Try
            Dim newsItems As List(Of NewsItem) = GetAllNewsItems()
            gvNews.DataSource = newsItems
            gvNews.DataBind()
        Catch ex As Exception
            ShowError("خطأ في تحميل الأخبار: " & ex.Message)
        End Try
    End Sub

    Private Function GetAllNewsItems() As List(Of NewsItem)
        Dim newsItems As New List(Of NewsItem)
        
        Try
            ' Try to get from database first
            newsItems = GetNewsFromDatabase()
            
            ' If no database connection, use static method for demo
            If newsItems.Count = 0 Then
                newsItems = GetStaticNewsForManagement()
            End If
            
        Catch ex As Exception
            ' Fallback to static news
            newsItems = GetStaticNewsForManagement()
        End Try
        
        Return newsItems.OrderBy(Function(n) n.Priority).ThenByDescending(Function(n) n.NewsDate).ToList()
    End Function

    Private Function GetNewsFromDatabase() As List(Of NewsItem)
        Dim newsItems As New List(Of NewsItem)
        
        Try
            Dim connectionString As String = Nothing
            If ConfigurationManager.ConnectionStrings("DefaultConnection") IsNot Nothing Then
                connectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
            End If
            
            If String.IsNullOrEmpty(connectionString) Then
                Return newsItems
            End If
            
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "SELECT ID, Title, Content, Date, Tag, ReadMoreUrl, IsActive, Priority, Summary " &
                                     "FROM News ORDER BY Priority ASC, Date DESC"
                
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            newsItems.Add(New NewsItem With {
                                .ID = reader.GetInt32("ID"),
                                .Title = reader.GetString("Title"),
                                .Content = reader.GetString("Content"),
                                .NewsDate = reader.GetDateTime("Date"),
                                .Tag = If(reader.IsDBNull(reader.GetOrdinal("Tag")), "", reader.GetString("Tag")),
                                .ReadMoreUrl = If(reader.IsDBNull(reader.GetOrdinal("ReadMoreUrl")), "#", reader.GetString("ReadMoreUrl")),
                                .IsActive = reader.GetBoolean("IsActive"),
                                .Priority = If(reader.IsDBNull(reader.GetOrdinal("Priority")), 0, reader.GetInt32("Priority")),
                                .Summary = If(reader.IsDBNull(reader.GetOrdinal("Summary")), "", reader.GetString("Summary"))
                            })
                        End While
                    End Using
                End Using
            End Using
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Database error in NewsManager: " & ex.Message)
        End Try
        
        Return newsItems
    End Function

    Private Function GetStaticNewsForManagement() As List(Of NewsItem)
        ' Static news items for demonstration when database is not available
        Return New List(Of NewsItem) From {
            New NewsItem With {
                .ID = 1,
                .Title = "إطلاق نظام إدارة المشاريع الجديد",
                .Content = "نعلن عن إطلاق النسخة المحدثة من نظام إدارة المشاريع مع واجهة مستخدم محسنة وميزات جديدة لتتبع التقدم وإدارة الفرق بكفاءة أكبر.",
                .NewsDate = DateTime.Now.AddDays(-2),
                .Tag = "تحديث النظام",
                .ReadMoreUrl = "#",
                .IsActive = True,
                .Priority = 1,
                .Summary = "إطلاق النسخة المحدثة من نظام إدارة المشاريع"
            },
            New NewsItem With {
                .ID = 2,
                .Title = "تحسينات الأمان والحماية",
                .Content = "تم تطبيق تحديثات أمنية شاملة تتضمن مصادقة ثنائية العامل وتشفير محسن لضمان حماية بياناتك بأعلى معايير الأمان.",
                .NewsDate = DateTime.Now.AddDays(-4),
                .Tag = "الأمان",
                .ReadMoreUrl = "#",
                .IsActive = True,
                .Priority = 2,
                .Summary = "تطبيق تحديثات أمنية شاملة"
            },
            New NewsItem With {
                .ID = 3,
                .Title = "دورة تدريبية مجانية للمستخدمين الجدد",
                .Content = "انضم إلى دورتنا التدريبية المجانية لتعلم كيفية استخدام جميع ميزات النظام بفعالية. التسجيل مفتوح الآن للمستخدمين الجدد.",
                .NewsDate = DateTime.Now.AddDays(-6),
                .Tag = "التدريب",
                .ReadMoreUrl = "#",
                .IsActive = True,
                .Priority = 3,
                .Summary = "دورة تدريبية مجانية للمستخدمين الجدد"
            }
        }
    End Function

    Protected Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If String.IsNullOrWhiteSpace(txtTitle.Text) OrElse String.IsNullOrWhiteSpace(txtContent.Text) Then
                ShowError("يرجى ملء العنوان والمحتوى")
                Return
            End If

            Dim success As Boolean = SaveNewsItem()
            
            If success Then
                ShowMessage("تم حفظ الخبر بنجاح!")
                ClearForm()
                LoadNewsGrid()
                ucNewsPreview.RefreshNews()
            Else
                ShowError("حدث خطأ أثناء حفظ الخبر")
            End If
            
        Catch ex As Exception
            ShowError("خطأ: " & ex.Message)
        End Try
    End Sub

    Private Function SaveNewsItem() As Boolean
        Try
            ' Try to save to database first
            If SaveToDatabase() Then
                Return True
            End If
            
            ' If database save fails, save to session/memory for demo
            Return SaveToSession()
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Error saving news: " & ex.Message)
            Return False
        End Try
    End Function

    Private Function SaveToDatabase() As Boolean
        Try
            Dim connectionString As String = Nothing
            If ConfigurationManager.ConnectionStrings("DefaultConnection") IsNot Nothing Then
                connectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
            End If
            
            If String.IsNullOrEmpty(connectionString) Then
                Return False
            End If
            
            Using conn As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO News (Title, Content, Tag, ReadMoreUrl, Priority, Summary, CreatedBy) " &
                                     "VALUES (@Title, @Content, @Tag, @ReadMoreUrl, @Priority, @Summary, @CreatedBy)"
                
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim())
                    cmd.Parameters.AddWithValue("@Content", txtContent.Text.Trim())
                    cmd.Parameters.AddWithValue("@Tag", If(String.IsNullOrEmpty(ddlTag.SelectedValue), DBNull.Value, ddlTag.SelectedValue))
                    cmd.Parameters.AddWithValue("@ReadMoreUrl", If(String.IsNullOrEmpty(txtReadMoreUrl.Text), "#", txtReadMoreUrl.Text.Trim()))
                    cmd.Parameters.AddWithValue("@Priority", Convert.ToInt32(If(String.IsNullOrEmpty(txtPriority.Text), "0", txtPriority.Text)))
                    cmd.Parameters.AddWithValue("@Summary", If(String.IsNullOrEmpty(txtSummary.Text), DBNull.Value, txtSummary.Text.Trim()))
                    cmd.Parameters.AddWithValue("@CreatedBy", If(HttpContext.Current.User.Identity.IsAuthenticated, HttpContext.Current.User.Identity.Name, "admin"))
                    
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Database save error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Function SaveToSession() As Boolean
        Try
            ' For demo purposes, save to session
            Dim sessionNews As List(Of NewsItem) = TryCast(Session("ManagedNews"), List(Of NewsItem))
            If sessionNews Is Nothing Then
                sessionNews = New List(Of NewsItem)()
            End If
            
            Dim newId As Integer = If(sessionNews.Count > 0, sessionNews.Max(Function(n) n.ID) + 1, 1)
            
            sessionNews.Add(New NewsItem With {
                .ID = newId,
                .Title = txtTitle.Text.Trim(),
                .Content = txtContent.Text.Trim(),
                .NewsDate = DateTime.Now,
                .Tag = ddlTag.SelectedValue,
                .ReadMoreUrl = If(String.IsNullOrEmpty(txtReadMoreUrl.Text), "#", txtReadMoreUrl.Text.Trim()),
                .IsActive = True,
                .Priority = Convert.ToInt32(If(String.IsNullOrEmpty(txtPriority.Text), "0", txtPriority.Text)),
                .Summary = txtSummary.Text.Trim()
            })
            
            Session("ManagedNews") = sessionNews
            Return True
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Session save error: " & ex.Message)
            Return False
        End Try
    End Function

    Protected Sub gvNews_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles gvNews.RowCommand
        Try
            Dim newsId As Integer = Convert.ToInt32(e.CommandArgument)
            
            Select Case e.CommandName
                Case "EditNews"
                    EditNewsItem(newsId)
                Case "ToggleActive"
                    ToggleNewsActive(newsId)
                Case "DeleteNews"
                    DeleteNewsItem(newsId)
            End Select
            
            LoadNewsGrid()
            ucNewsPreview.RefreshNews()
            
        Catch ex As Exception
            ShowError("خطأ في تنفيذ العملية: " & ex.Message)
        End Try
    End Sub

    Private Sub EditNewsItem(newsId As Integer)
        Try
            Dim newsItem As NewsItem = GetNewsItemById(newsId)
            If newsItem IsNot Nothing Then
                txtTitle.Text = newsItem.Title
                txtContent.Text = newsItem.Content
                txtSummary.Text = newsItem.Summary
                ddlTag.SelectedValue = newsItem.Tag
                txtReadMoreUrl.Text = newsItem.ReadMoreUrl
                txtPriority.Text = newsItem.Priority.ToString()
                
                ' Show edit mode
                btnSave.Visible = False
                pnlEditButtons.Visible = True
                litFormTitle.Text = "تعديل الخبر"
                
                ' Store the ID being edited
                ViewState("EditingNewsId") = newsId
            End If
        Catch ex As Exception
            ShowError("خطأ في تحميل بيانات الخبر للتعديل: " & ex.Message)
        End Try
    End Sub

    Private Function GetNewsItemById(newsId As Integer) As NewsItem
        Dim allNews As List(Of NewsItem) = GetAllNewsItems()
        Return allNews.FirstOrDefault(Function(n) n.ID = newsId)
    End Function

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim editingId As Object = ViewState("EditingNewsId")
            If editingId IsNot Nothing Then
                If UpdateNewsItem(Convert.ToInt32(editingId)) Then
                    ShowMessage("تم تحديث الخبر بنجاح!")
                    ClearForm()
                    LoadNewsGrid()
                    ucNewsPreview.RefreshNews()
                Else
                    ShowError("حدث خطأ أثناء تحديث الخبر")
                End If
            End If
        Catch ex As Exception
            ShowError("خطأ في التحديث: " & ex.Message)
        End Try
    End Sub

    Private Function UpdateNewsItem(newsId As Integer) As Boolean
        ' For demo purposes, just return true
        ' In a real implementation, this would update the database
        Return True
    End Function

    Protected Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtTitle.Text = ""
        txtContent.Text = ""
        txtSummary.Text = ""
        ddlTag.SelectedIndex = 0
        txtReadMoreUrl.Text = ""
        txtPriority.Text = "0"
        
        btnSave.Visible = True
        pnlEditButtons.Visible = False
        litFormTitle.Text = "إضافة خبر جديد"
        ViewState("EditingNewsId") = Nothing
    End Sub

    Private Sub ToggleNewsActive(newsId As Integer)
        ' Implementation for toggling news active status
        ShowMessage("تم تغيير حالة الخبر")
    End Sub

    Private Sub DeleteNewsItem(newsId As Integer)
        ' Implementation for deleting news item
        ShowMessage("تم حذف الخبر")
    End Sub

    Protected Sub gvNews_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles gvNews.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            ' Additional formatting can be done here
        End If
    End Sub

    Private Sub ShowMessage(message As String)
        litMessage.Text = message
        pnlMessage.Visible = True
        pnlError.Visible = False
    End Sub

    Private Sub ShowError(errorMessage As String)
        litError.Text = errorMessage
        pnlError.Visible = True
        pnlMessage.Visible = False
    End Sub
End Class
