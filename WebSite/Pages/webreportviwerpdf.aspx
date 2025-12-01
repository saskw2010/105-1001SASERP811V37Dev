<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="webreportviwerpdf.aspx.vb" Inherits="Pages_webreportviwerpdf"  Title="webreportviwer" %>
<%@ Register Src="../Controls/wexreportpdf.ascx" TagName="wexreportpdf"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">webreportviwerpdf</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|reportviewer"><uc:wexreportpdf ID="control1" runat="server"></uc:wexreportpdf></div>
  </div>
</asp:Content>