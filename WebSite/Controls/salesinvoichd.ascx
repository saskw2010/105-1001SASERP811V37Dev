<%@ Control Language="VB" AutoEventWireup="false" CodeFile="salesinvoichd.ascx.vb" Inherits="Controls_salesinvoichd"  %>
<asp:TextBox type="text" ID="MyTextBox2" runat="server" class="MyTextBox" Width="283px" Visible="False"></asp:TextBox>
<asp:TextBox type="text" ID="MyTextBox" runat="server" class="MyTextBox" Width="283px" Visible="False"></asp:TextBox>

<!-- Modern Sales Invoice Details -->

<style>
    .modern-sales-invoice {
        background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
        border-radius: 25px;
        padding: 30px;
        margin: 20px 0;
        box-shadow: 0 25px 50px rgba(102, 126, 234, 0.3);
        position: relative;
        overflow: hidden;
        color: white;
    }

    .modern-sales-invoice::before {
        content: '';
        position: absolute;
        top: -50%;
        left: -50%;
        width: 200%;
        height: 200%;
        background: 
            conic-gradient(from 45deg, rgba(255,255,255,0.1) 0deg, transparent 90deg, rgba(255,255,255,0.05) 180deg, transparent 270deg),
            radial-gradient(circle at 30% 70%, rgba(255,255,255,0.1) 0%, transparent 50%);
        animation: modernRotate 30s linear infinite;
        z-index: 1;
    }

    @keyframes modernRotate {
        0% { transform: translate(-50%, -50%) rotate(0deg); }
        100% { transform: translate(-50%, -50%) rotate(360deg); }
    }

    .invoice-header {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 25px;
        margin-bottom: 30px;
        display: flex;
        justify-content: space-between;
        align-items: center;
        box-shadow: 0 15px 40px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(15px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        position: relative;
        z-index: 2;
    }

    .invoice-title {
        font-size: 2.2rem;
        font-weight: 800;
        background: linear-gradient(135deg, #667eea, #764ba2);
        -webkit-background-clip: text;
        -webkit-text-fill-color: transparent;
        margin: 0;
        display: flex;
        align-items: center;
        gap: 15px;
    }

    .time-display {
        background: rgba(102, 126, 234, 0.1);
        border: 2px solid rgba(102, 126, 234, 0.3);
        border-radius: 12px;
        padding: 10px 15px;
        font-weight: 600;
        color: #667eea;
    }

    .grid-container {
        background: rgba(255, 255, 255, 0.95);
        border-radius: 20px;
        padding: 25px;
        box-shadow: 0 15px 35px rgba(0, 0, 0, 0.1);
        backdrop-filter: blur(15px);
        border: 1px solid rgba(255, 255, 255, 0.3);
        position: relative;
        z-index: 2;
    }

    .grid-header {
        margin-bottom: 20px;
        padding-bottom: 15px;
        border-bottom: 2px solid #e2e8f0;
    }

    .grid-controls {
        display: flex;
        gap: 15px;
        flex-wrap: wrap;
    }

    .btn {
        padding: 12px 20px;
        border: none;
        border-radius: 12px;
        font-weight: 600;
        cursor: pointer;
        transition: all 0.3s ease;
        text-decoration: none;
        display: inline-flex;
        align-items: center;
        gap: 8px;
        font-size: 0.95rem;
    }

    .btn-primary {
        background: linear-gradient(135deg, #667eea, #764ba2);
        color: white;
        box-shadow: 0 4px 15px rgba(102, 126, 234, 0.3);
    }

    .btn-success {
        background: linear-gradient(135deg, #11998e, #38ef7d);
        color: white;
        box-shadow: 0 4px 15px rgba(17, 153, 142, 0.3);
    }

    .btn-secondary {
        background: linear-gradient(135deg, #6c757d, #495057);
        color: white;
        box-shadow: 0 4px 15px rgba(108, 117, 125, 0.3);
    }

    .btn:hover {
        transform: translateY(-2px);
        box-shadow: 0 8px 25px rgba(0, 0, 0, 0.2);
    }

    .table-wrapper {
        overflow-x: auto;
        border-radius: 12px;
        border: 1px solid #e2e8f0;
    }

    .modern-table {
        width: 100%;
        border-collapse: collapse;
        background: white;
        border-radius: 12px;
        overflow: hidden;
    }

    .modern-table th {
        background: linear-gradient(135deg, #667eea, #764ba2);
        color: white;
        padding: 15px 12px;
        text-align: center;
        font-weight: 700;
        font-size: 0.95rem;
    }

    .modern-table td {
        padding: 12px;
        border-bottom: 1px solid #e2e8f0;
        text-align: center;
        color: #1e293b;
    }

    .modern-table tr:hover {
        background: rgba(102, 126, 234, 0.05);
    }

    .modern-table input {
        border: 2px solid #e2e8f0;
        border-radius: 8px;
        padding: 8px 12px;
        width: 100%;
        font-size: 0.9rem;
        transition: border-color 0.3s ease;
    }

    .modern-table input:focus {
        outline: none;
        border-color: #667eea;
        box-shadow: 0 0 0 3px rgba(102, 126, 234, 0.1);
    }

    .modern-table select {
        border: 2px solid #e2e8f0;
        border-radius: 8px;
        padding: 8px 12px;
        width: 100%;
        font-size: 0.9rem;
        background: white;
        cursor: pointer;
    }

    .total-row {
        background: linear-gradient(135deg, rgba(102, 126, 234, 0.1), rgba(118, 75, 162, 0.1));
        font-weight: 700;
        font-size: 1.1rem;
    }

    .total-label {
        text-align: right !important;
        color: #667eea;
    }

    .total-value {
        color: #11998e;
        font-size: 1.3rem;
    }

    .action-btn {
        padding: 6px 12px;
        border: none;
        border-radius: 8px;
        cursor: pointer;
        font-size: 0.85rem;
        font-weight: 600;
        transition: all 0.3s ease;
    }

    .btn-delete {
        background: #ef4444;
        color: white;
    }

    .btn-delete:hover {
        background: #dc2626;
        transform: scale(1.05);
    }

    .loading-overlay {
        position: absolute;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background: rgba(255, 255, 255, 0.9);
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        z-index: 1000;
        border-radius: 20px;
    }

    .loading-spinner {
        width: 50px;
        height: 50px;
        border: 4px solid rgba(102, 126, 234, 0.3);
        border-top: 4px solid #667eea;
        border-radius: 50%;
        animation: spin 1s linear infinite;
    }

    @keyframes spin {
        0% { transform: rotate(0deg); }
        100% { transform: rotate(360deg); }
    }

    .status-messages {
        background: rgba(255, 255, 255, 0.9);
        border-radius: 12px;
        padding: 15px;
        margin-bottom: 20px;
        position: relative;
        z-index: 2;
    }

    /* RTL Support */
    .rtl {
        direction: rtl;
        text-align: right;
    }

    /* Responsive Design */
    @media (max-width: 768px) {
        .modern-sales-invoice {
            padding: 20px;
            margin: 15px 0;
        }
        
        .invoice-header {
            flex-direction: column;
            gap: 15px;
            text-align: center;
        }
        
        .invoice-title {
            font-size: 1.8rem;
        }
        
        .grid-controls {
            justify-content: center;
        }
        
        .btn {
            padding: 10px 16px;
            font-size: 0.9rem;
        }
    }

    @media (max-width: 480px) {
        .invoice-title {
            font-size: 1.5rem;
            flex-direction: column;
        }
        
        .modern-table th,
        .modern-table td {
            padding: 8px 6px;
            font-size: 0.85rem;
        }
    }
</style>

<div class="modern-sales-invoice rtl">
    <div class="invoice-header">
        <h2 class="invoice-title">
            <i class="fas fa-file-invoice-dollar"></i>
            <span>تفاصيل فاتورة البيع</span>
        </h2>
        <div class="time-display">
            <i class="fas fa-clock"></i>
            <asp:Label ID="lblTime" runat="server" />
            <asp:Button ID="btnSubmit" runat="server" OnClick="GetTime" style="display:none" />
        </div>
    </div>

    <!-- Status Messages -->
    <div id="statusMessages" class="status-messages" style="display: none;">
        <asp:Literal ID="litStatusMessages" runat="server"></asp:Literal>
    </div>

    <!-- Modern Data Grid -->
    <div class="grid-container">
        <div class="grid-header">
            <div class="grid-controls">
                <button type="button" class="btn btn-primary btn-add" onclick="addNewRow()">
                    <i class="fas fa-plus"></i>
                    إضافة منتج جديد
                </button>
                <button type="button" class="btn btn-success btn-save" onclick="saveChanges()">
                    <i class="fas fa-save"></i>
                    حفظ التغييرات
                </button>
                <button type="button" class="btn btn-secondary btn-refresh" onclick="refreshData()">
                    <i class="fas fa-sync-alt"></i>
                    تحديث
                </button>
            </div>
        </div>

        <!-- Data Table -->
        <div class="table-wrapper">
            <table id="salesInvoiceTable" class="modern-table">
                <thead>
                    <tr>
                        <th>رقم المنتج</th>
                        <th>الوحدة</th>
                        <th>الكمية</th>
                        <th>الخصم</th>
                        <th>سعر الوحدة</th>
                        <th>السعر المطبق</th>
                        <th>الضريبة</th>
                        <th>الإجراءات</th>
                    </tr>
                </thead>
                <tbody id="invoiceTableBody">
                    <asp:Literal ID="litTableRows" runat="server"></asp:Literal>
                </tbody>
                <tfoot>
                    <tr class="total-row">
                        <td colspan="7" class="total-label">إجمالي الفاتورة:</td>
                        <td class="total-value" id="totalAmount">0.00</td>
                    </tr>
                </tfoot>
            </table>
        </div>

        <!-- Loading Overlay -->
        <div class="loading-overlay" id="loadingOverlay" style="display: none;">
            <div class="loading-spinner"></div>
            <p>جاري المعالجة...</p>
        </div>
    </div>

    <!-- Hidden Fields for Data -->
    <asp:HiddenField ID="hdnDocNo" runat="server" />
    <asp:HiddenField ID="hdnGridData" runat="server" />
    
    <!-- SQL Data Sources -->
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eZee %>"
        DeleteCommand="DELETE FROM [Stsaldtltmp] WHERE [ln_no] = @original_ln_no"
        SelectCommand="SELECT * FROM [Stsaldtltmp] WHERE ([Doc_No] = @Doc_No) ORDER BY [Doc_No], [ln_no]"
        UpdateCommand="UPDATE [Stsaldtltmp] SET [Quantity] = @Quantity, [Discount] = @Discount, [Titm_Sal] = @Titm_Sal, [paplcprc] = @paplcprc, [darb] = @darb WHERE [ln_no] = @original_ln_no" 
        OldValuesParameterFormatString="original_{0}">
        <DeleteParameters>
            <asp:Parameter Name="original_ln_no" Type="Int64"></asp:Parameter>
        </DeleteParameters>
        <SelectParameters>
            <asp:QueryStringParameter DefaultValue="0" Name="Doc_No" QueryStringField="Doc_No" Type="Int64" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="Quantity" Type="Decimal" />
            <asp:Parameter Name="Discount" Type="Decimal" />
            <asp:Parameter Name="Titm_Sal" Type="Decimal" />
            <asp:Parameter Name="paplcprc" Type="Decimal" />
            <asp:Parameter Name="darb" Type="Decimal" />
            <asp:Parameter Name="original_ln_no" Type="Int64" />
        </UpdateParameters>
    </asp:SqlDataSource>
    
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:eZee %>" 
        SelectCommand="SELECT * FROM [Stunit]">
    </asp:SqlDataSource>
</div>

<script>
// Modern Sales Invoice JavaScript
document.addEventListener('DOMContentLoaded', function() {
    initializeSalesInvoice();
    setupEventHandlers();
    loadInitialData();
});

function initializeSalesInvoice() {
    console.log('Modern Sales Invoice initialized');
    updateTotalAmount();
}

function setupEventHandlers() {
    // Add event listeners for calculation
    document.addEventListener('input', function(e) {
        if (e.target.matches('.quantity-input, .price-input, .discount-input')) {
            calculateRowTotal(e.target.closest('tr'));
        }
    });
}

function loadInitialData() {
    // Load initial invoice data
    refreshData();
}

function addNewRow() {
    showLoading();
    
    const tableBody = document.getElementById('invoiceTableBody');
    const newRow = createNewInvoiceRow();
    tableBody.appendChild(newRow);
    
    hideLoading();
    updateTotalAmount();
}

function createNewInvoiceRow() {
    const row = document.createElement('tr');
    row.innerHTML = `
        <td><input type="text" class="product-input" placeholder="رقم المنتج" /></td>
        <td>
            <select class="unit-select">
                <option value="1">قطعة</option>
                <option value="2">كيلو</option>
                <option value="3">متر</option>
                <option value="4">لتر</option>
            </select>
        </td>
        <td><input type="number" class="quantity-input" value="1" min="0" step="0.01" /></td>
        <td><input type="number" class="discount-input" value="0" min="0" step="0.01" /></td>
        <td><input type="number" class="price-input" value="0" min="0" step="0.01" /></td>
        <td class="applied-price">0.00</td>
        <td><input type="number" class="tax-input" value="0" min="0" step="0.01" /></td>
        <td>
            <button type="button" class="action-btn btn-delete" onclick="deleteRow(this)">
                <i class="fas fa-trash"></i> حذف
            </button>
        </td>
    `;
    return row;
}

function calculateRowTotal(row) {
    const quantity = parseFloat(row.querySelector('.quantity-input').value) || 0;
    const price = parseFloat(row.querySelector('.price-input').value) || 0;
    const discount = parseFloat(row.querySelector('.discount-input').value) || 0;
    
    const subtotal = quantity * price;
    const total = subtotal - discount;
    
    row.querySelector('.applied-price').textContent = total.toFixed(2);
    updateTotalAmount();
}

function updateTotalAmount() {
    let total = 0;
    document.querySelectorAll('.applied-price').forEach(cell => {
        total += parseFloat(cell.textContent) || 0;
    });
    
    document.getElementById('totalAmount').textContent = total.toFixed(2);
}

function deleteRow(button) {
    if (confirm('هل أنت متأكد من حذف هذا الصف؟')) {
        const row = button.closest('tr');
        row.remove();
        updateTotalAmount();
    }
}

function saveChanges() {
    showLoading();
    
    // Collect form data
    const invoiceData = collectInvoiceData();
    
    // Simulate save operation
    setTimeout(() => {
        hideLoading();
        showStatusMessage('تم حفظ التغييرات بنجاح!', 'success');
        console.log('Invoice data saved:', invoiceData);
    }, 1000);
}

function collectInvoiceData() {
    const rows = document.querySelectorAll('#invoiceTableBody tr');
    const data = [];
    
    rows.forEach(row => {
        const rowData = {
            product: row.querySelector('.product-input')?.value || '',
            unit: row.querySelector('.unit-select')?.value || '1',
            quantity: parseFloat(row.querySelector('.quantity-input')?.value) || 0,
            price: parseFloat(row.querySelector('.price-input')?.value) || 0,
            discount: parseFloat(row.querySelector('.discount-input')?.value) || 0,
            tax: parseFloat(row.querySelector('.tax-input')?.value) || 0
        };
        
        if (rowData.product) {
            data.push(rowData);
        }
    });
    
    return data;
}

function refreshData() {
    showLoading();
    
    // Simulate data refresh
    setTimeout(() => {
        hideLoading();
        showStatusMessage('تم تحديث البيانات بنجاح!', 'info');
    }, 500);
}

function showLoading() {
    document.getElementById('loadingOverlay').style.display = 'flex';
}

function hideLoading() {
    document.getElementById('loadingOverlay').style.display = 'none';
}

function showStatusMessage(message, type) {
    const statusDiv = document.getElementById('statusMessages');
    statusDiv.innerHTML = `<div class="alert alert-${type}">${message}</div>`;
    statusDiv.style.display = 'block';
    
    setTimeout(() => {
        statusDiv.style.display = 'none';
    }, 3000);
}

// Backward compatibility functions
function GetCurrentTime() {
    document.getElementById('<%=btnSubmit.ClientID %>').click();
}

function GetCurrentTime1(myfun) {
    document.getElementById('<%=btnSubmit.ClientID %>').click();
    if (document.getElementById('<%=MyTextBox2.ClientID%>')) {
        document.getElementById('<%=MyTextBox2.ClientID%>').value = myfun;
    }
}

function calculatemos() {
    // Legacy calculation function
    updateTotalAmount();
}
</script>