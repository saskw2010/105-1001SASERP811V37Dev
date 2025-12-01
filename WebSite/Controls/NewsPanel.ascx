<%@ Control Language="VB" AutoEventWireup="true" CodeFile="NewsPanel.ascx.vb" Inherits="Controls_NewsPanel" %>

<div class="news-section" id="newsSection" runat="server">
    <div class="news-header">
        <h2 class="news-title">
            <i class="fas fa-newspaper news-icon"></i>
            <asp:Literal ID="litNewsTitle" runat="server" Text="آخر الأخبار والتحديثات" />
        </h2>
        <p class="news-subtitle">
            <asp:Literal ID="litNewsSubtitle" runat="server" Text="ابق على اطلاع بأحدث التطورات في WYTSKY.COM" />
        </p>
    </div>
    
    <div class="news-content">
        <asp:Repeater ID="rptNews" runat="server">
            <ItemTemplate>
                <div class="news-item">
                    <div class="news-item-header">
                        <h3 class="news-item-title"><%# Eval("Title") %></h3>
                        <span class="news-date"><%# GetFormattedDate(DirectCast(Eval("NewsDate"), DateTime)) %></span>
                    </div>
                    <div class="news-item-content">
                        <%# Eval("Content") %>
                    </div>
                    <div class="news-item-footer">
                        <span class="news-tag"><%# Eval("Tag") %></span>
                        <a href="<%# Eval("ReadMoreUrl") %>" class="read-more">
                            <%# If(Eval("Tag").ToString() = "التدريب", "سجل الآن", If(Eval("Tag").ToString() = "التطبيق", "حمل الآن", "اقرأ المزيد")) %>
                        </a>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        
        <!-- Load More Button -->
        <div class="text-center mt-3" id="divLoadMore" runat="server" visible="false">
            <asp:Button ID="btnLoadMore" runat="server" Text="تحميل المزيد من الأخبار" 
                CssClass="btn btn-outline" OnClick="btnLoadMore_Click" />
        </div>
    </div>
</div>

<style>
    .news-section {
        background-color: rgba(255, 255, 255, 0.95);
        border-radius: 15px;
        box-shadow: 0 8px 32px rgba(0, 0, 0, 0.15);
        padding: 1.5rem;
        backdrop-filter: blur(10px);
        border: 1px solid rgba(255, 255, 255, 0.2);
        height: 100%;
        overflow-y: auto;
        display: flex;
        flex-direction: column;
    }
    
    .news-header {
        text-align: center;
        margin-bottom: 1.5rem;
        border-bottom: 2px solid #2563eb;
        padding-bottom: 0.8rem;
        flex-shrink: 0;
    }
    
    .news-content {
        flex: 1;
        overflow-y: auto;
    }
    
    .news-title {
        font-size: 1.3rem;
        font-weight: 700;
        color: #1d4ed8;
        margin-bottom: 0.4rem;
    }
    
    .news-subtitle {
        font-size: 0.85rem;
        color: #666;
        font-weight: 400;
    }
    
    .news-item {
        background-color: #ffffff;
        border-radius: 8px;
        padding: 1rem;
        margin-bottom: 1rem;
        box-shadow: 0 2px 8px rgba(0, 0, 0, 0.1);
        border-left: 3px solid #2563eb;
        transition: all 0.3s ease;
    }
    
    .news-item:hover {
        transform: translateY(-2px);
        box-shadow: 0 4px 15px rgba(37, 99, 235, 0.15);
    }
    
    .news-item-header {
        display: flex;
        justify-content: space-between;
        align-items: flex-start;
        margin-bottom: 0.8rem;
    }
    
    .news-date {
        font-size: 0.75rem;
        color: #999;
        background-color: #f8f9fa;
        padding: 0.2rem 0.6rem;
        border-radius: 12px;
        white-space: nowrap;
    }
    
    .news-item-title {
        font-size: 1rem;
        font-weight: 600;
        color: #1d4ed8;
        margin-bottom: 0.4rem;
        flex: 1;
        margin-right: 0.8rem;
    }
    
    .news-item-content {
        font-size: 0.85rem;
        color: #333;
        line-height: 1.5;
        margin-bottom: 0.8rem;
    }
    
    .news-item-footer {
        display: flex;
        justify-content: space-between;
        align-items: center;
    }
    
    .news-tag {
        background-color: #2563eb;
        color: #ffffff;
        padding: 0.3rem 0.8rem;
        border-radius: 15px;
        font-size: 0.75rem;
        font-weight: 500;
    }
    
    .read-more {
        color: #2563eb;
        text-decoration: none;
        font-size: 0.85rem;
        font-weight: 500;
        transition: all 0.3s ease;
    }
    
    .read-more:hover {
        color: #1d4ed8;
        text-decoration: underline;
    }
    
    .news-icon {
        color: #2563eb;
        margin-right: 0.5rem;
    }
    
    /* Responsive */
    @media (max-width: 768px) {
        .news-section {
            max-height: 350px;
            padding: 1.5rem;
        }
        
        .news-item-header {
            flex-direction: column;
            align-items: flex-start;
        }
        
        .news-item-title {
            margin-right: 0;
            margin-bottom: 0.5rem;
            font-size: 1rem;
        }
        
        .news-item {
            padding: 1rem;
            margin-bottom: 1rem;
        }
        
        .news-title {
            font-size: 1.3rem;
        }
    }
    
    @media (max-width: 576px) {
        .news-section {
            max-height: 300px;
            padding: 1rem;
        }
        
        .news-item {
            padding: 0.8rem;
        }
        
        .news-title {
            font-size: 1.2rem;
        }
        
        .news-item-title {
            font-size: 0.95rem;
        }
        
        .news-item-content {
            font-size: 0.85rem;
        }
    }
</style>
