<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Gridwithdata.ascx.vb" Inherits="Controls_Gridwithdata"  %>




<div class="ParaHeader">
  
</div>
<div class="ParaInfo">

 

 <asp:SqlDataSource ID="SqlDataSource1" 
            SelectCommand="SELECT *  FROM [QschRegDashBoard]"
            runat="server"></asp:SqlDataSource>
</div>





