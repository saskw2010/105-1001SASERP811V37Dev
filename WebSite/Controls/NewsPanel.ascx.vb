Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Partial Public Class Controls_NewsPanel
    Inherits System.Web.UI.UserControl

    ' News data structure
    <Serializable>
    Public Class NewsItem
        Public Property ID As Integer
        Public Property Title As String
        Public Property Content As String
        Public Property NewsDate As DateTime
        Public Property Tag As String
        Public Property ReadMoreUrl As String
        Public Property IsActive As Boolean
        Public Property Priority As Integer
    End Class

    ' Properties for customization
    Public Property MaxNewsItems As Integer = 4
    Public Property ShowLoadMore As Boolean = True
    Public Property NewsTitle As String = "آخر الأخبار والتحديثات"
    Public Property NewsSubtitle As String = "ابق على اطلاع بأحدث التطورات في WYTSKY.COM"

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LoadNewsItems()
        End If
        
        ' Set custom titles if provided
        litNewsTitle.Text = NewsTitle
        litNewsSubtitle.Text = NewsSubtitle
    End Sub

    Private Sub LoadNewsItems()
        Try
            Dim newsItems As List(Of NewsItem) = GetNewsItems()
            
            ' Take only the specified number of items
            Dim displayItems = newsItems.Take(MaxNewsItems).ToList()
            
            ' Bind to repeater
            rptNews.DataSource = displayItems
            rptNews.DataBind()
            
            ' Show/hide load more button
            If ShowLoadMore AndAlso newsItems.Count > MaxNewsItems Then
                divLoadMore.Visible = True
            Else
                divLoadMore.Visible = False
            End If
            
        Catch ex As Exception
            ' Log error and show fallback content
            System.Diagnostics.Debug.WriteLine("Error loading news: " & ex.Message)
            ShowFallbackNews()
        End Try
    End Sub

    Private Function GetNewsItems() As List(Of NewsItem)
        Dim newsItems As New List(Of NewsItem)
        
        Try
            ' Try to get from database first
            newsItems = GetNewsFromDatabase()
            
            ' If no database news, use static content
            If newsItems.Count = 0 Then
                newsItems = GetStaticNews()
            End If
            
        Catch ex As Exception
            ' Fallback to static news
            newsItems = GetStaticNews()
        End Try
        
        ' Sort by priority and date
        Return newsItems.Where(Function(n) n.IsActive).OrderBy(Function(n) n.Priority).ThenByDescending(Function(n) n.NewsDate).ToList()
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
                Dim query As String = "SELECT TOP 10 ID, Title, Content, Date, Tag, ReadMoreUrl, IsActive, Priority " &
                                     "FROM News WHERE IsActive = 1 ORDER BY Priority ASC, Date DESC"
                
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
                                .Priority = If(reader.IsDBNull(reader.GetOrdinal("Priority")), 0, reader.GetInt32("Priority"))
                            })
                        End While
                    End Using
                End Using
            End Using
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Database error: " & ex.Message)
        End Try
        
        Return newsItems
    End Function

    Private Function GetStaticNews() As List(Of NewsItem)
        Return New List(Of NewsItem) From {
            New NewsItem With {
                .ID = 1,
                .Title = "إطلاق نظام إدارة المشاريع الجديد",
                .Content = "نعلن عن إطلاق النسخة المحدثة من نظام إدارة المشاريع مع واجهة مستخدم محسنة وميزات جديدة لتتبع التقدم وإدارة الفرق بكفاءة أكبر.",
                .NewsDate = DateTime.Now.AddDays(-2),
                .Tag = "تحديث النظام",
                .ReadMoreUrl = "#",
                .IsActive = True,
                .Priority = 1
            },
            New NewsItem With {
                .ID = 2,
                .Title = "تحسينات الأمان والحماية",
                .Content = "تم تطبيق تحديثات أمنية شاملة تتضمن مصادقة ثنائية العامل وتشفير محسن لضمان حماية بياناتك بأعلى معايير الأمان.",
                .NewsDate = DateTime.Now.AddDays(-4),
                .Tag = "الأمان",
                .ReadMoreUrl = "#",
                .IsActive = True,
                .Priority = 2
            },
            New NewsItem With {
                .ID = 3,
                .Title = "دورة تدريبية مجانية للمستخدمين الجدد",
                .Content = "انضم إلى دورتنا التدريبية المجانية لتعلم كيفية استخدام جميع ميزات النظام بفعالية. التسجيل مفتوح الآن للمستخدمين الجدد.",
                .NewsDate = DateTime.Now.AddDays(-6),
                .Tag = "التدريب",
                .ReadMoreUrl = "~/Pages/Training.aspx",
                .IsActive = True,
                .Priority = 3
            },
            New NewsItem With {
                .ID = 4,
                .Title = "تطبيق الهاتف المحمول متاح الآن",
                .Content = "حمل تطبيق WYTSKY على هاتفك المحمول الآن! متاح على App Store و Google Play Store مع جميع الميزات الأساسية.",
                .NewsDate = DateTime.Now.AddDays(-9),
                .Tag = "التطبيق",
                .ReadMoreUrl = "~/Pages/MobileApp.aspx",
                .IsActive = True,
                .Priority = 4
            },
            New NewsItem With {
                .ID = 5,
                .Title = "شراكة استراتيجية جديدة",
                .Content = "نعلن عن شراكة استراتيجية مع شركة رائدة في مجال التكنولوجيا لتطوير حلول مبتكرة وتحسين خدماتنا.",
                .NewsDate = DateTime.Now.AddDays(-12),
                .Tag = "الشراكات",
                .ReadMoreUrl = "#",
                .IsActive = True,
                .Priority = 5
            },
            New NewsItem With {
                .ID = 6,
                .Title = "تحديث خدمة العملاء 24/7",
                .Content = "أصبحت خدمة العملاء متاحة الآن على مدار 24 ساعة طوال أيام الأسبوع لضمان حصولكم على الدعم في أي وقت تحتاجونه.",
                .NewsDate = DateTime.Now.AddDays(-15),
                .Tag = "خدمة العملاء",
                .ReadMoreUrl = "~/Pages/Support.aspx",
                .IsActive = True,
                .Priority = 6
            }
        }
    End Function

    Private Sub ShowFallbackNews()
        ' Simple fallback in case everything fails
        Dim fallbackNews As New List(Of NewsItem) From {
            New NewsItem With {
                .Title = "مرحباً بك في WYTSKY",
                .Content = "نظام إدارة المؤسسات الذكي الذي يساعدك في تنظيم وإدارة أعمالك بكفاءة عالية.",
                .NewsDate = DateTime.Now,
                .Tag = "عام",
                .ReadMoreUrl = "#",
                .IsActive = True,
                .Priority = 1
            }
        }
        
        rptNews.DataSource = fallbackNews
        rptNews.DataBind()
        divLoadMore.Visible = False
    End Sub

    Protected Sub btnLoadMore_Click(sender As Object, e As EventArgs) Handles btnLoadMore.Click
        ' Increase the number of items to show
        MaxNewsItems += 4
        LoadNewsItems()
    End Sub

    Public Function GetFormattedDate(ByVal newsDate As DateTime) As String
        Try
            Dim daysDiff As Integer = (DateTime.Now - newsDate).Days
            
            If daysDiff = 0 Then
                Return "اليوم"
            ElseIf daysDiff = 1 Then
                Return "أمس"
            ElseIf daysDiff <= 7 Then
                Return daysDiff.ToString() & " أيام مضت"
            ElseIf daysDiff <= 30 Then
                Dim weeksDiff As Integer = Math.Floor(daysDiff / 7)
                Return If(weeksDiff = 1, "أسبوع مضى", weeksDiff.ToString() & " أسابيع مضت")
            Else
                Return newsDate.ToString("dd MMMM yyyy", New System.Globalization.CultureInfo("ar-SA"))
            End If
        Catch
            Return newsDate.ToString("dd/MM/yyyy")
        End Try
    End Function

    ' Method to refresh news programmatically
    Public Sub RefreshNews()
        LoadNewsItems()
    End Sub

    ' Method to set custom news data
    Public Sub SetCustomNews(ByVal customNews As List(Of NewsItem))
        rptNews.DataSource = customNews
        rptNews.DataBind()
        divLoadMore.Visible = False
    End Sub
End Class
