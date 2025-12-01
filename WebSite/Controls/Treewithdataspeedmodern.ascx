<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Treewithdataspeedmodern.ascx.vb" Inherits="Controls_Treewithdataspeedmodern" %>

<!-- Modern High-Performance Tree Component -->

<style>
    .speed-tree-container {
        background: linear-gradient(135deg, #f093fb 0%, #f5576c 100%);
        border-radius: 20px;
        padding: 25px;
        box-shadow: 0 15px 35px rgba(240, 147, 251, 0.3);
        margin: 20px 0;
        position: relative;
        overflow: hidden;
    }

    .tree-header {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 15px;
        padding: 20px;
        margin-bottom: 25px;
        box-shadow: 0 8px 25px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(10px);
        border: 1px solid rgba(255, 255, 255, 0.2);
        position: relative;
        z-index: 2;
        text-align: center;
    }

    .tree-title {
        font-size: 1.8rem;
        font-weight: 700;
        background: linear-gradient(135deg, #f093fb, #f5576c);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin: 0;
    }

    .tree-content {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 15px;
        padding: 25px;
        box-shadow: 0 8px 25px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(10px);
        border: 1px solid rgba(255, 255, 255, 0.2);
        position: relative;
        z-index: 2;
        min-height: 400px;
    }

    .rtl {
        direction: rtl;
        text-align: right;
    }
</style>

<div class="speed-tree-container rtl">
    <div class="tree-header">
        <h2 class="tree-title">
            <i class="fas fa-tachometer-alt"></i>
            شجرة البيانات عالية الأداء
        </h2>
    </div>

    <div class="tree-content">
        <asp:TextBox ID="MyTextBox" runat="server" CssClass="form-control" 
            placeholder="القيم المحددة..." readonly="true" />
        
        <div style="margin-top: 20px;">
            <p>تم تحديث المكون لاستخدام تقنيات حديثة بدلاً من Telerik RadTreeView</p>
        </div>
    </div>

    <!-- Hidden Data Source -->
    <asp:SqlDataSource runat="server" ID="SqlDataSource1" 
        SelectCommand="SELECT * from Qglmfbandviewtree1001 order by lvl,Acc_Bnd" />
</div>
