<%@ Page Language="VB" MasterPageFile="~/Main.Master" AutoEventWireup="false" CodeFile="webreportviwers.aspx.vb" Inherits="Pages_webreportviwerS"  Title="webreportviwers" %>
<%@ Register Src="../Controls/Dynwexreportxxy.ascx" TagName="Dynwexreportxxy"  TagPrefix="uc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageTitleContentPlaceHolder" runat="Server">webreportviwer</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PageContentPlaceHolder" runat="Server">
  <div data-flow="NewRow">
    <div data-activator="Tab|reportviewer"><uc:Dynwexreportxxy ID="control1" runat="server"></uc:Dynwexreportxxy></div>
  </div>
</asp:Content>