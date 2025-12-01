<%@ Control Language="VB" AutoEventWireup="false" CodeFile="HomeTableOfContents.ascx.vb" Inherits="Controls_HomeTableOfContents"  %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>   
<%@ Import Namespace="translatemeyamosso"%> 

<!-- Home Page Table of Contents using Telerik RadSiteMap -->
<div id="homeTableOfContents" class="home-navigation-container">
    <asp:SiteMapDataSource ID="SiteMapDataSource1x" runat="server" ShowStartingNode="true" StartFromCurrentNode="true"/>
    
    <telerik:radsitemap runat="server" ID="SiteMap1x" DataSourceID="SiteMapDataSource1x">
        <LevelSettings>
            <telerik:SiteMapLevelSetting Level="0" MaximumNodes="100" SeparatorText="">
                <NodeTemplate>
                    <!-- Level 0 Template (if needed) -->
                </NodeTemplate>
            </telerik:SiteMapLevelSetting>

            <telerik:SiteMapLevelSetting Level="1" MaximumNodes="100" ListLayout-AlignRows="True" ListLayout-RepeatColumns="3" Layout="Flow" ListLayout-RepeatDirection="Vertical" SeparatorText="">
                <NodeTemplate>
                    <a href="<%# DataBinder.Eval(Container.DataItem, "url")%>" class="home-nav-item">
                        <div class="clearfixhomeimage">
                            <div class="cardhomeimage text-center">
                                <div class="containerhomeimage text-center">
                                    <img src="<%# translatemeyamosso.GetResourcemosso(DataBinder.Eval(Container.DataItem, "url")) %>" class="imageWrappermehome imagehomeimage">
                                    
                                    <div class="overlay">
                                        <div class="containerhomeimagetext">
                                            <%# translatemeyamosso.GetResourceValuemosso(DataBinder.Eval(Container.DataItem, "title"))%>
                                        </div>
                                    </div>
                                </div>
                                <div class="buttonhomeimage">
                                    <p style="font-size: 16px">
                                        <%# translatemeyamosso.GetResourceValuemosso(DataBinder.Eval(Container.DataItem, "title"))%>
                                    </p>
                                </div>
                            </div>
                        </div>
                    </a> 
                </NodeTemplate>
            </telerik:SiteMapLevelSetting>
        </LevelSettings>                  
    </telerik:radsitemap>  

    <!-- Hidden debug labels -->
    <div style="display:none">
        <asp:Label ID="Label1" runat="server" Text="Label" Height="210"></asp:Label>
        <span></span><span></span>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <span></span><span></span><span></span>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Solid" Height="16px" TextMode="MultiLine" Width="236px"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" Text="Label" Height="210"></asp:Label>
    </div>
</div>

<style>
.home-navigation-container {
    margin: 2rem 0;
}

.home-nav-item {
    text-decoration: none;
    display: block;
    transition: transform 0.3s ease;
}

.home-nav-item:hover {
    transform: translateY(-5px);
}

/* Existing home image styles preserved */
.clearfixhomeimage {
    overflow: auto;
}

.cardhomeimage {
    position: relative;
    margin: 1rem;
    border-radius: 12px;
    overflow: hidden;
    box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
    transition: box-shadow 0.3s ease;
}

.cardhomeimage:hover {
    box-shadow: 0 8px 25px rgba(0, 0, 0, 0.15);
}

.containerhomeimage {
    position: relative;
    width: 100%;
    height: 200px;
    overflow: hidden;
}

.imagehomeimage {
    width: 100%;
    height: 100%;
    object-fit: cover;
    transition: transform 0.3s ease;
}

.cardhomeimage:hover .imagehomeimage {
    transform: scale(1.05);
}

.overlay {
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background: linear-gradient(45deg, rgba(0, 0, 0, 0.6), transparent);
    opacity: 0;
    transition: opacity 0.3s ease;
    display: flex;
    align-items: center;
    justify-content: center;
}

.cardhomeimage:hover .overlay {
    opacity: 1;
}

.containerhomeimagetext {
    color: white;
    font-weight: bold;
    text-align: center;
    padding: 1rem;
    font-size: 1.1rem;
}

.buttonhomeimage {
    background: linear-gradient(135deg, var(--primary-color, #007bff), var(--secondary-color, #6c757d));
    color: white;
    padding: 1rem;
    text-align: center;
}

.buttonhomeimage p {
    margin: 0;
    font-weight: 600;
}

/* Responsive design */
@media (max-width: 768px) {
    .containerhomeimage {
        height: 150px;
    }
    
    .buttonhomeimage {
        padding: 0.75rem;
    }
    
    .buttonhomeimage p {
        font-size: 14px !important;
    }
}
</style>
